class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x73c68f4*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x73c68fc*/ IsReadOnlyAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x73c6904*/ NullableAttribute(byte );
                /*0x73c698c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x73c69bc*/ NullableContextAttribute(byte );
            }

            class NullablePublicOnlyAttribute : System.Attribute
            {
                /*0x10*/ bool IncludesInternals;

                /*0x73c69e4*/ NullablePublicOnlyAttribute(bool );
            }

            class RefSafetyRulesAttribute : System.Attribute
            {
                /*0x10*/ int Version;

                /*0x73c6a0c*/ RefSafetyRulesAttribute(int );
            }
        }
    }
}

namespace FxResources
{
    namespace System
    {
        namespace Collections
        {
            namespace Immutable
            {
                class SR
                {
                }
            }
        }
    }
}

namespace System
{
    class SR
    {
        static /*0x0*/ bool s_usingResourceKeys;
        static /*0x8*/ System.Resources.ResourceManager s_resourceManager;

        static /*0x73c70f4*/ SR();
        static /*0x73c6a34*/ bool UsingResourceKeys();
        static /*0x73c6a8c*/ string GetResourceString(string resourceKey);
        static /*0x73c6cc0*/ string Format(string resourceFormat, object p1);
        static /*0x73c6bcc*/ System.Resources.ResourceManager get_ResourceManager();
        static /*0x73c6e38*/ string get_Arg_KeyNotFoundWithKey();
        static /*0x73c6e9c*/ string get_ArrayInitializedStateNotEqual();
        static /*0x73c6f00*/ string get_ArrayLengthsNotEqual();
        static /*0x73c6f64*/ string get_CollectionModifiedDuringEnumeration();
        static /*0x73c6fc8*/ string get_DuplicateKey();
        static /*0x73c702c*/ string get_InvalidEmptyOperation();
        static /*0x73c7090*/ string get_InvalidOperationOnDefaultArray();
    }

    namespace Diagnostics
    {
        namespace CodeAnalysis
        {
            class NotNullAttribute : System.Attribute
            {
                /*0x73c7198*/ NotNullAttribute();
            }

            class MaybeNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x73c71a0*/ MaybeNullWhenAttribute(bool returnValue);
            }

            class NotNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x73c71c8*/ NotNullWhenAttribute(bool returnValue);
            }

            class DoesNotReturnAttribute : System.Attribute
            {
                /*0x73c71f0*/ DoesNotReturnAttribute();
            }

            class DoesNotReturnIfAttribute : System.Attribute
            {
                /*0x10*/ bool <ParameterValue>k__BackingField;

                /*0x73c71f8*/ DoesNotReturnIfAttribute(bool parameterValue);
            }
        }
    }

    namespace Runtime
    {
        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x73c7220*/ NonVersionableAttribute();
            }
        }

        namespace CompilerServices
        {
            class CollectionBuilderAttribute : System.Attribute
            {
                /*0x10*/ System.Type <BuilderType>k__BackingField;
                /*0x18*/ string <MethodName>k__BackingField;

                /*0x73c7228*/ CollectionBuilderAttribute(System.Type builderType, string methodName);
            }
        }
    }

    namespace Collections
    {
        namespace Immutable
        {
            class AllocFreeConcurrentStack<T>
            {
                static /*0x0*/ System.Type s_typeOfT;

                static /*0x38358cc*/ AllocFreeConcurrentStack();
                static /*0x3907c14*/ void TryAdd(T item);
                static /*0x381ac0c*/ bool TryTake(ref T item);
                static /*0x382dee4*/ System.Collections.Generic.Stack<System.Collections.Immutable.RefAsValueType<T>> get_ThreadLocalStack();
            }

            class AllocFreeConcurrentStack
            {
                [ThreadStatic] static System.Collections.Generic.Dictionary<System.Type, object> t_stacks;
            }

            class DictionaryEnumerator<TKey, TValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
            {
                /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _inner;

                /*0x380d83c*/ DictionaryEnumerator(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> inner);
                System.Collections.DictionaryEntry get_Entry();
                /*0x380b9e8*/ object get_Key();
                /*0x380b9e8*/ object get_Value();
                /*0x380b9e8*/ object get_Current();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Reset();
            }

            struct DisposableEnumeratorAdapter<T, TEnumerator> : System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.IEnumerator<T> _enumeratorObject;
                /*0x0*/ TEnumerator _enumeratorStruct;

                /*0x3907c14*/ DisposableEnumeratorAdapter(TEnumerator enumerator);
                /*0x380d83c*/ DisposableEnumeratorAdapter(System.Collections.Generic.IEnumerator<T> enumerator);
                /*0x3907c14*/ T get_Current();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Dispose();
                /*0x3907c14*/ System.Collections.Immutable.DisposableEnumeratorAdapter<T, TEnumerator> GetEnumerator();
            }

            interface IImmutableArray
            {
                /*0x380b9e8*/ System.Array get_Array();
            }

            interface IImmutableDictionary<TKey, TValue> : System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
            }

            interface IImmutableDictionaryInternal<TKey, TValue>
            {
                /*0x3907c14*/ bool ContainsValue(TValue value);
            }

            interface IImmutableList<T> : System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x3907c14*/ int IndexOf(T item, int index, int count, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
            }

            interface IImmutableQueue<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }

            interface IImmutableSet<T> : System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }

            interface IImmutableStack<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }

            class ImmutableHashSet<T> : System.Collections.Immutable.IImmutableSet<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.ISet<T>, System.Collections.ICollection, System.Collections.Immutable.IStrongEnumerable<T, System.Collections.Immutable.ImmutableHashSet.Enumerator<T>>
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableHashSet<T> Empty;
                static /*0x0*/ System.Action<System.Collections.Generic.KeyValuePair<int, System.Collections.Immutable.ImmutableHashSet.HashBucket<T>>> s_FreezeBucketAction;
                /*0x0*/ System.Collections.Generic.IEqualityComparer<T> _equalityComparer;
                /*0x0*/ int _count;
                /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _root;
                /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _hashBucketEqualityComparer;

                static /*0x38358cc*/ ImmutableHashSet();
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.MutationResult<T> Add(T item, System.Collections.Immutable.ImmutableHashSet.MutationInput<T> origin);
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.MutationResult<T> Remove(T item, System.Collections.Immutable.ImmutableHashSet.MutationInput<T> origin);
                static /*0x3907c14*/ bool Contains(T item, System.Collections.Immutable.ImmutableHashSet.MutationInput<T> origin);
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.MutationResult<T> Union(System.Collections.Generic.IEnumerable<T> other, System.Collections.Immutable.ImmutableHashSet.MutationInput<T> origin);
                static /*0x3907c14*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> UpdateRoot(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, int hashCode, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> hashBucketEqualityComparer, System.Collections.Immutable.ImmutableHashSet.HashBucket<T> newBucket);
                static /*0x383094c*/ System.Collections.Immutable.ImmutableHashSet<T> Wrap(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, System.Collections.Generic.IEqualityComparer<T> equalityComparer, int count);
                static /*0x382eaf0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> GetHashBucketEqualityComparer(System.Collections.Generic.IEqualityComparer<T> valueComparer);
                /*0x380d83c*/ ImmutableHashSet(System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                ImmutableHashSet(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, System.Collections.Generic.IEqualityComparer<T> equalityComparer, int count);
                /*0x380b6a0*/ int get_Count();
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<T> get_KeyComparer();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.MutationInput<T> get_Origin();
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableHashSet.Builder<T> ToBuilder();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet<T> Add(T item);
                /*0x3907c14*/ bool Contains(T item);
                /*0x380bb68*/ System.Collections.Immutable.ImmutableHashSet<T> WithComparer(System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x380d8b8*/ void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x380cb08*/ void System.Collections.Generic.ICollection<T>.Clear();
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<T>.Remove(T item);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.Enumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380bc74*/ System.Collections.Immutable.ImmutableHashSet<T> Wrap(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, int adjustedCountIfDifferentRoot);
                /*0x380bba0*/ System.Collections.Immutable.ImmutableHashSet<T> Union(System.Collections.Generic.IEnumerable<T> items, bool avoidWithComparer);

                class HashBucketByValueEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> s_defaultInstance;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<T> _valueComparer;

                    static /*0x38358cc*/ HashBucketByValueEqualityComparer();
                    static /*0x382dee4*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> get_DefaultInstance();
                    /*0x380d83c*/ HashBucketByValueEqualityComparer(System.Collections.Generic.IEqualityComparer<T> valueComparer);
                    /*0x3907c14*/ bool Equals(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> x, System.Collections.Immutable.ImmutableHashSet.HashBucket<T> y);
                    /*0x3907c14*/ int GetHashCode(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> obj);
                }

                class HashBucketByRefEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> s_defaultInstance;

                    static /*0x38358cc*/ HashBucketByRefEqualityComparer();
                    static /*0x382dee4*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> get_DefaultInstance();
                    /*0x380cb08*/ HashBucketByRefEqualityComparer();
                    /*0x3907c14*/ bool Equals(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> x, System.Collections.Immutable.ImmutableHashSet.HashBucket<T> y);
                    /*0x3907c14*/ int GetHashCode(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> obj);
                }

                class Builder<T> : System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.ISet<T>, System.Collections.Generic.ICollection<T>
                {
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _root;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<T> _equalityComparer;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _hashBucketEqualityComparer;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Immutable.ImmutableHashSet<T> _immutable;
                    /*0x0*/ int _version;

                    /*0x380d83c*/ Builder(System.Collections.Immutable.ImmutableHashSet<T> set);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                    /*0x380b6a0*/ int get_Version();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.MutationInput<T> get_Origin();
                    /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> get_Root();
                    /*0x380d83c*/ void set_Root(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> value);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.Enumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableHashSet<T> ToImmutable();
                    /*0x3907c14*/ bool Add(T item);
                    /*0x3907c14*/ bool Remove(T item);
                    /*0x3907c14*/ bool Contains(T item);
                    /*0x380cb08*/ void Clear();
                    /*0x380d83c*/ void UnionWith(System.Collections.Generic.IEnumerable<T> other);
                    /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                    /*0x380d8b8*/ void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ void Apply(System.Collections.Immutable.ImmutableHashSet.MutationResult<T> result);
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Collections.Immutable.IStrongEnumerator<T>
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableHashSet.Builder<T> _builder;
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode.Enumerator<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _mapEnumerator;
                    /*0x0*/ System.Collections.Immutable.ImmutableHashSet.HashBucket.Enumerator<T> _bucketEnumerator;
                    /*0x0*/ int _enumeratingBuilderVersion;

                    /*0x380d93c*/ Enumerator(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, System.Collections.Immutable.ImmutableHashSet.Builder<T> builder);
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void Dispose();
                    /*0x380cb08*/ void ThrowIfChanged();
                }

                enum OperationResult<T>
                {
                    SizeChanged = 0,
                    NoChangeRequired = 1,
                }

                struct HashBucket<T>
                {
                    /*0x0*/ T _firstValue;
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _additionalElements;

                    /*0x3907c14*/ HashBucket(T firstElement, System.Collections.Immutable.ImmutableList.Node<T> additionalElements);
                    /*0x380b128*/ bool get_IsEmpty();
                    /*0x380b2f0*/ bool Equals(object obj);
                    /*0x380b6a0*/ int GetHashCode();
                    /*0x3907c14*/ bool EqualsByRef(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> other);
                    /*0x3907c14*/ bool EqualsByValue(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> other, System.Collections.Generic.IEqualityComparer<T> valueComparer);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.HashBucket<T> Add(T value, System.Collections.Generic.IEqualityComparer<T> valueComparer, ref System.Collections.Immutable.ImmutableHashSet.OperationResult<T> result);
                    /*0x3907c14*/ bool Contains(T value, System.Collections.Generic.IEqualityComparer<T> valueComparer);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.HashBucket<T> Remove(T value, System.Collections.Generic.IEqualityComparer<T> equalityComparer, ref System.Collections.Immutable.ImmutableHashSet.OperationResult<T> result);
                    /*0x380cb08*/ void Freeze();

                    struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ System.Collections.Immutable.ImmutableHashSet.HashBucket<T> _bucket;
                        /*0x0*/ bool _disposed;
                        /*0x0*/ System.Collections.Immutable.ImmutableHashSet.HashBucket.Enumerator.Position<T> _currentPosition;
                        /*0x0*/ System.Collections.Immutable.ImmutableList.Enumerator<T> _additionalEnumerator;

                        /*0x3907c14*/ Enumerator(System.Collections.Immutable.ImmutableHashSet.HashBucket<T> bucket);
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x3907c14*/ T get_Current();
                        /*0x380b128*/ bool MoveNext();
                        /*0x380cb08*/ void Reset();
                        /*0x380cb08*/ void Dispose();
                        /*0x380cb08*/ void ThrowIfDisposed();

                        enum Position<T>
                        {
                            BeforeFirst = 0,
                            First = 1,
                            Additional = 2,
                            End = 3,
                        }
                    }
                }

                struct MutationInput<T>
                {
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _root;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<T> _equalityComparer;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _hashBucketEqualityComparer;

                    /*0x380d83c*/ MutationInput(System.Collections.Immutable.ImmutableHashSet<T> set);
                    MutationInput(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, System.Collections.Generic.IEqualityComparer<T> equalityComparer, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> hashBucketEqualityComparer, int count);
                    /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> get_Root();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<T> get_EqualityComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> get_HashBucketEqualityComparer();
                }

                enum CountType<T>
                {
                    Adjustment = 0,
                    FinalValue = 1,
                }

                struct MutationResult<T>
                {
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> _root;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Immutable.ImmutableHashSet.CountType<T> _countType;

                    /*0x3907c14*/ MutationResult(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> root, int count, System.Collections.Immutable.ImmutableHashSet.CountType<T> countType);
                    /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> get_Root();
                    /*0x380b6a0*/ int get_Count();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.CountType<T> get_CountType();
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableHashSet<T> Finalize(System.Collections.Immutable.ImmutableHashSet<T> priorSet);
                }

                class <>c<T>
                {
                    static /*0x0*/ System.Collections.Immutable.ImmutableHashSet.<>c<T> <>9;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x3907c14*/ void <.cctor>b__91_0(System.Collections.Generic.KeyValuePair<int, System.Collections.Immutable.ImmutableHashSet.HashBucket<T>> kv);
                }
            }

            interface IStrongEnumerable<T, TEnumerator>
            {
                /*0x3907c14*/ TEnumerator GetEnumerator();
            }

            interface IStrongEnumerator<T>
            {
            }

            interface IOrderedCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x380b6a0*/ int get_Count();
                /*0x3907c14*/ T get_Item(int index);
            }

            class ImmutableArray
            {
                static /*0x0*/ byte[] TwoElementArray;

                static /*0x73c726c*/ ImmutableArray();
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableArray<T> Create<T>(T[] items);
            }

            struct ImmutableArray<T> : System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.IEquatable<System.Collections.Immutable.ImmutableArray<T>>, System.Collections.IList, System.Collections.ICollection, System.Collections.Immutable.IImmutableArray, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.Collections.Immutable.IImmutableList<T>
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableArray<T> Empty;
                /*0x0*/ T[] array;

                static /*0x38358cc*/ ImmutableArray();
                static /*0x381ac0c*/ bool IsCompatibleObject(object value);
                /*0x380d83c*/ ImmutableArray(T[] items);
                /*0x3907c14*/ T System.Collections.Generic.IList<T>.get_Item(int index);
                /*0x3907c14*/ void System.Collections.Generic.IList<T>.set_Item(int index, T value);
                /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x380b6a0*/ int System.Collections.Generic.ICollection<T>.get_Count();
                /*0x380b6a0*/ int System.Collections.Generic.IReadOnlyCollection<T>.get_Count();
                /*0x3907c14*/ T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index);
                /*0x3907c14*/ int IndexOf(T item);
                /*0x3907c14*/ int IndexOf(T item, int startIndex, int count, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                /*0x3907c14*/ bool Contains(T item);
                /*0x3907c14*/ void System.Collections.Generic.IList<T>.Insert(int index, T item);
                /*0x380cffc*/ void System.Collections.Generic.IList<T>.RemoveAt(int index);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x380cb08*/ void System.Collections.Generic.ICollection<T>.Clear();
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<T>.Remove(T item);
                /*0x380b7a8*/ int System.Collections.IList.Add(object value);
                /*0x380cb08*/ void System.Collections.IList.Clear();
                /*0x380b2f0*/ bool System.Collections.IList.Contains(object value);
                /*0x380b7a8*/ int System.Collections.IList.IndexOf(object value);
                /*0x380d170*/ void System.Collections.IList.Insert(int index, object value);
                /*0x380b128*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x380b6a0*/ int System.Collections.ICollection.get_Count();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380d83c*/ void System.Collections.IList.Remove(object value);
                /*0x380cffc*/ void System.Collections.IList.RemoveAt(int index);
                /*0x380ba90*/ object System.Collections.IList.get_Item(int index);
                /*0x380d170*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b32c*/ bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer);
                /*0x380b7a8*/ int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer);
                int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer);
                /*0x3907c14*/ T get_Item(int index);
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b6a0*/ int get_Length();
                /*0x380b128*/ bool get_IsDefault();
                /*0x380b9e8*/ System.Array System.Collections.Immutable.IImmutableArray.get_Array();
                /*0x380d8b8*/ void CopyTo(T[] destination, int destinationIndex);
                /*0x3907c14*/ System.Collections.Immutable.ImmutableArray.Enumerator<T> GetEnumerator();
                /*0x380b6a0*/ int GetHashCode();
                /*0x380b2f0*/ bool Equals(object obj);
                /*0x3907c14*/ bool Equals(System.Collections.Immutable.ImmutableArray<T> other);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380cb08*/ void ThrowNullRefIfNotInitialized();
                /*0x380cb08*/ void ThrowInvalidOperationIfNotInitialized();

                struct Enumerator<T>
                {
                    /*0x0*/ T[] _array;
                    /*0x0*/ int _index;

                    /*0x380d83c*/ Enumerator(T[] array);
                    /*0x3907c14*/ T get_Current();
                    /*0x380b128*/ bool MoveNext();
                }

                class EnumeratorObject<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    static /*0x0*/ System.Collections.Generic.IEnumerator<T> s_EmptyEnumerator;
                    /*0x0*/ T[] _array;
                    /*0x0*/ int _index;

                    static /*0x38358cc*/ EnumeratorObject();
                    static /*0x382eaf0*/ System.Collections.Generic.IEnumerator<T> Create(T[] array);
                    /*0x380d83c*/ EnumeratorObject(T[] array);
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380cb08*/ void Dispose();
                }
            }

            class ImmutableDictionary
            {
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Create<TKey, TValue>(System.Collections.Generic.IEqualityComparer<TKey> keyComparer);
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> CreateBuilder<TKey, TValue>(System.Collections.Generic.IEqualityComparer<TKey> keyComparer);
            }

            class ImmutableDictionary<TKey, TValue> : System.Collections.Immutable.IImmutableDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Immutable.IImmutableDictionaryInternal<TKey, TValue>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Empty;
                static /*0x0*/ System.Action<System.Collections.Generic.KeyValuePair<int, System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>>> s_FreezeBucketAction;
                /*0x0*/ int _count;
                /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> _root;
                /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> _comparers;

                static /*0x38358cc*/ ImmutableDictionary();
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> EmptyWithComparers(System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> comparers);
                static /*0x381cca4*/ bool TryCastToImmutableMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> sequence, ref System.Collections.Immutable.ImmutableDictionary<TKey, TValue> other);
                static /*0x3907c14*/ bool ContainsKey(TKey key, System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> origin);
                static /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair, System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> origin);
                static /*0x3907c14*/ bool TryGetValue(TKey key, System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> origin, ref TValue value);
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.MutationResult<TKey, TValue> Add(TKey key, TValue value, System.Collections.Immutable.ImmutableDictionary.KeyCollisionBehavior<TKey, TValue> behavior, System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> origin);
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.MutationResult<TKey, TValue> AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> items, System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> origin, System.Collections.Immutable.ImmutableDictionary.KeyCollisionBehavior<TKey, TValue> collisionBehavior);
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.MutationResult<TKey, TValue> Remove(TKey key, System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> origin);
                static /*0x3907c14*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> UpdateRoot(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, int hashCode, System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> newBucket, System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> hashBucketComparer);
                static /*0x383094c*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Wrap(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> comparers, int count);
                ImmutableDictionary(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> comparers, int count);
                /*0x380d83c*/ ImmutableDictionary(System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> comparers);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Clear();
                /*0x380b6a0*/ int get_Count();
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TKey> get_KeyComparer();
                /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TValue> get_ValueComparer();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> get_Values();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> get_Origin();
                /*0x3907c14*/ TValue get_Item(TKey key);
                /*0x3907c14*/ TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key);
                /*0x3907c14*/ void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value);
                /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> ToBuilder();
                /*0x3907c14*/ bool ContainsKey(TKey key);
                /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x380bcbc*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> WithComparers(System.Collections.Generic.IEqualityComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                /*0x380bb68*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> WithComparers(System.Collections.Generic.IEqualityComparer<TKey> keyComparer);
                /*0x3907c14*/ bool ContainsValue(TValue value);
                /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue> GetEnumerator();
                /*0x3907c14*/ void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value);
                /*0x3907c14*/ bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380cb08*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear();
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);
                /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x380cb08*/ void System.Collections.IDictionary.Clear();
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380bc74*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Wrap(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, int adjustedCountIfDifferentRoot);
                /*0x380bba0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> pairs, bool avoidToHashMap);

                class Builder<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> _root;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> _comparers;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> _immutable;
                    /*0x0*/ int _version;
                    /*0x0*/ object _syncRoot;

                    /*0x380d83c*/ Builder(System.Collections.Immutable.ImmutableDictionary<TKey, TValue> map);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> get_Keys();
                    /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> get_Values();
                    /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                    /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                    /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
                    /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                    /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                    /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                    /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                    /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);
                    /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                    /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x380b6a0*/ int get_Version();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> get_Origin();
                    /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> get_Root();
                    /*0x380d83c*/ void set_Root(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> value);
                    /*0x3907c14*/ TValue get_Item(TKey key);
                    /*0x3907c14*/ void set_Item(TKey key, TValue value);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> ToImmutable();
                    /*0x3907c14*/ void Add(TKey key, TValue value);
                    /*0x3907c14*/ bool ContainsKey(TKey key);
                    /*0x3907c14*/ bool Remove(TKey key);
                    /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                    /*0x3907c14*/ void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                    /*0x380cb08*/ void Clear();
                    /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                    /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                    /*0x3907c14*/ bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ bool Apply(System.Collections.Immutable.ImmutableDictionary.MutationResult<TKey, TValue> result);

                    class <get_Keys>d__18<TKey, TValue> : System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ TKey <>2__current;
                        /*0x0*/ int <>l__initialThreadId;
                        /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> <>4__this;
                        /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue> <>7__wrap1;

                        /*0x380cffc*/ <get_Keys>d__18(int <>1__state);
                        /*0x380cb08*/ void System.IDisposable.Dispose();
                        /*0x380b128*/ bool MoveNext();
                        /*0x380cb08*/ void <>m__Finally1();
                        /*0x3907c14*/ TKey System.Collections.Generic.IEnumerator<TKey>.get_Current();
                        /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                        /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }

                    class <get_Values>d__<TKey, TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ TValue <>2__current;
                        /*0x0*/ int <>l__initialThreadId;
                        /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> <>4__this;
                        /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue> <>7__wrap1;

                        /*0x380cffc*/ <get_Values>d__(int <>1__state);
                        /*0x380cb08*/ void System.IDisposable.Dispose();
                        /*0x380b128*/ bool MoveNext();
                        /*0x380cb08*/ void <>m__Finally1();
                        /*0x3907c14*/ TValue System.Collections.Generic.IEnumerator<TValue>.get_Current();
                        /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                        /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class Comparers<TKey, TValue> : System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>>, System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                {
                    static /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> Default;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<TKey> _keyComparer;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<TValue> _valueComparer;

                    static /*0x38358cc*/ Comparers();
                    static /*0x3830700*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> Get(System.Collections.Generic.IEqualityComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                    /*0x380d93c*/ Comparers(System.Collections.Generic.IEqualityComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TKey> get_KeyComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey, TValue>> get_KeyOnlyComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TValue> get_ValueComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> get_HashBucketEqualityComparer();
                    /*0x3907c14*/ bool Equals(System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> x, System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> y);
                    /*0x3907c14*/ int GetHashCode(System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> obj);
                    /*0x3907c14*/ bool System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(System.Collections.Generic.KeyValuePair<TKey, TValue> x, System.Collections.Generic.KeyValuePair<TKey, TValue> y);
                    /*0x3907c14*/ int System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(System.Collections.Generic.KeyValuePair<TKey, TValue> obj);
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> WithValueComparer(System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                }

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> _builder;
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode.Enumerator<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> _mapEnumerator;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> _bucketEnumerator;
                    /*0x0*/ int _enumeratingBuilderVersion;

                    /*0x380d93c*/ Enumerator(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> builder);
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void Dispose();
                    /*0x380cb08*/ void ThrowIfChanged();
                }

                struct HashBucket<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.KeyValuePair<TKey, TValue> _firstValue;
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> _additionalElements;

                    /*0x3907c14*/ HashBucket(System.Collections.Generic.KeyValuePair<TKey, TValue> firstElement, System.Collections.Immutable.ImmutableList.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> additionalElements);
                    /*0x380b128*/ bool get_IsEmpty();
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_FirstValue();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> get_AdditionalElements();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x380b2f0*/ bool Equals(object obj);
                    /*0x380b6a0*/ int GetHashCode();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> Add(TKey key, TValue value, System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey, TValue>> keyOnlyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, System.Collections.Immutable.ImmutableDictionary.KeyCollisionBehavior<TKey, TValue> behavior, ref System.Collections.Immutable.ImmutableDictionary.OperationResult<TKey, TValue> result);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> Remove(TKey key, System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey, TValue>> keyOnlyComparer, ref System.Collections.Immutable.ImmutableDictionary.OperationResult<TKey, TValue> result);
                    /*0x3907c14*/ bool TryGetValue(TKey key, System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> comparers, ref TValue value);
                    /*0x380cb08*/ void Freeze();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> _bucket;
                        /*0x0*/ System.Collections.Immutable.ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> _currentPosition;
                        /*0x0*/ System.Collections.Immutable.ImmutableList.Enumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _additionalEnumerator;

                        /*0x3907c14*/ Enumerator(System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue> bucket);
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                        /*0x380b128*/ bool MoveNext();
                        /*0x380cb08*/ void Reset();
                        /*0x380cb08*/ void Dispose();

                        enum Position<TKey, TValue>
                        {
                            BeforeFirst = 0,
                            First = 1,
                            Additional = 2,
                            End = 3,
                        }
                    }
                }

                struct MutationInput<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> _root;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> _comparers;

                    /*0x380d93c*/ MutationInput(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> comparers);
                    /*0x380d83c*/ MutationInput(System.Collections.Immutable.ImmutableDictionary<TKey, TValue> map);
                    /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> get_Root();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableDictionary.Comparers<TKey, TValue> get_Comparers();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TKey> get_KeyComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey, TValue>> get_KeyOnlyComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TValue> get_ValueComparer();
                    /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> get_HashBucketComparer();
                }

                struct MutationResult<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> _root;
                    /*0x0*/ int _countAdjustment;

                    /*0x3907c14*/ MutationResult(System.Collections.Immutable.ImmutableDictionary.MutationInput<TKey, TValue> unchangedInput);
                    /*0x380d8b8*/ MutationResult(System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> root, int countAdjustment);
                    /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> get_Root();
                    /*0x380b6a0*/ int get_CountAdjustment();
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Finalize(System.Collections.Immutable.ImmutableDictionary<TKey, TValue> priorMap);
                }

                enum KeyCollisionBehavior<TKey, TValue>
                {
                    SetValue = 0,
                    Skip = 1,
                    ThrowIfValueDifferent = 2,
                    ThrowAlways = 3,
                }

                enum OperationResult<TKey, TValue>
                {
                    AppliedWithoutSizeChange = 0,
                    SizeChanged = 1,
                    NoChangeRequired = 2,
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ System.Collections.Immutable.ImmutableDictionary.<>c<TKey, TValue> <>9;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x3907c14*/ void <.cctor>b__107_0(System.Collections.Generic.KeyValuePair<int, System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> kv);
                }

                class <get_Keys>d__25<TKey, TValue> : System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ TKey <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> <>4__this;
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode.Enumerator<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> <>7__wrap1;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> <>7__wrap2;

                    /*0x380cffc*/ <get_Keys>d__25(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void <>m__Finally1();
                    /*0x380cb08*/ void <>m__Finally2();
                    /*0x3907c14*/ TKey System.Collections.Generic.IEnumerator<TKey>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <get_Values>d__27<TKey, TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ TValue <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> <>4__this;
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode.Enumerator<System.Collections.Immutable.ImmutableDictionary.HashBucket<TKey, TValue>> <>7__wrap1;
                    /*0x0*/ System.Collections.Immutable.ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> <>7__wrap2;

                    /*0x380cffc*/ <get_Values>d__27(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void <>m__Finally1();
                    /*0x380cb08*/ void <>m__Finally2();
                    /*0x3907c14*/ TValue System.Collections.Generic.IEnumerator<TValue>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class ImmutableDictionaryBuilderDebuggerProxy<TKey, TValue>
            {
            }

            class ImmutableDictionaryDebuggerProxy<TKey, TValue> : System.Collections.Immutable.ImmutableEnumerableDebuggerProxy<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
            }

            class ImmutableEnumerableDebuggerProxy<T>
            {
            }

            class ImmutableExtensions
            {
                static /*0x3818690*/ bool IsValueType<T>();
                static /*0x382eaf0*/ System.Collections.Immutable.IOrderedCollection<T> AsOrderedCollection<T>(System.Collections.Generic.IEnumerable<T> sequence);
                static /*0x3837da0*/ void ClearFastWhenEmpty<T>(System.Collections.Generic.Stack<T> stack);
                static /*0x3907c14*/ System.Collections.Immutable.DisposableEnumeratorAdapter<T, TEnumerator> GetEnumerableDisposable<T, TEnumerator>(System.Collections.Generic.IEnumerable<T> enumerable);
                static /*0x381cca4*/ bool TryGetCount<T>(System.Collections.Generic.IEnumerable<T> sequence, ref int count);
                static /*0x381cca4*/ bool TryGetCount<T>(System.Collections.IEnumerable sequence, ref int count);
                static /*0x381ccdc*/ bool TryCopyTo<T>(System.Collections.Generic.IEnumerable<T> sequence, T[] array, int arrayIndex);
                static /*0x38301ec*/ T[] ToArray<T>(System.Collections.Generic.IEnumerable<T> sequence, int count);

                class ListOfTWrapper<T> : System.Collections.Immutable.IOrderedCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.IList<T> _collection;

                    /*0x380d83c*/ ListOfTWrapper(System.Collections.Generic.IList<T> collection);
                    /*0x380b6a0*/ int get_Count();
                    /*0x3907c14*/ T get_Item(int index);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class FallbackWrapper<T> : System.Collections.Immutable.IOrderedCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> _sequence;
                    /*0x0*/ System.Collections.Generic.IList<T> _collection;

                    /*0x380d83c*/ FallbackWrapper(System.Collections.Generic.IEnumerable<T> sequence);
                    /*0x380b6a0*/ int get_Count();
                    /*0x3907c14*/ T get_Item(int index);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class ImmutableHashSet
            {
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableHashSet<T> Create<T>(System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableHashSet.Builder<T> CreateBuilder<T>(System.Collections.Generic.IEqualityComparer<T> equalityComparer);
            }

            class ImmutableList
            {
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableList<T> Create<T>();
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableList.Builder<T> CreateBuilder<T>();
                static /*0x3907c14*/ int IndexOf<T>(System.Collections.Immutable.IImmutableList<T> list, T item, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
            }

            class ImmutableList<T> : System.Collections.Immutable.IImmutableList<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.IList, System.Collections.ICollection, System.Collections.Immutable.IOrderedCollection<T>, System.Collections.Immutable.IStrongEnumerable<T, System.Collections.Immutable.ImmutableList.Enumerator<T>>
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableList<T> Empty;
                /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _root;

                static /*0x38358cc*/ ImmutableList();
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableList<T> WrapNode(System.Collections.Immutable.ImmutableList.Node<T> root);
                static /*0x381ac0c*/ bool IsCompatibleObject(object value);
                /*0x380cb08*/ ImmutableList();
                /*0x380d83c*/ ImmutableList(System.Collections.Immutable.ImmutableList.Node<T> root);
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x3907c14*/ T get_Item(int index);
                /*0x3907c14*/ T System.Collections.Immutable.IOrderedCollection<T>.get_Item(int index);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Builder<T> ToBuilder();
                /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x3907c14*/ int IndexOf(T item, int index, int count, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                /*0x3907c14*/ bool Contains(T value);
                /*0x3907c14*/ int IndexOf(T value);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ void System.Collections.Generic.IList<T>.Insert(int index, T item);
                /*0x380cffc*/ void System.Collections.Generic.IList<T>.RemoveAt(int index);
                /*0x3907c14*/ T System.Collections.Generic.IList<T>.get_Item(int index);
                /*0x3907c14*/ void System.Collections.Generic.IList<T>.set_Item(int index, T value);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x380cb08*/ void System.Collections.Generic.ICollection<T>.Clear();
                /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<T>.Remove(T item);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x380b7a8*/ int System.Collections.IList.Add(object value);
                /*0x380cffc*/ void System.Collections.IList.RemoveAt(int index);
                /*0x380cb08*/ void System.Collections.IList.Clear();
                /*0x380b2f0*/ bool System.Collections.IList.Contains(object value);
                /*0x380b7a8*/ int System.Collections.IList.IndexOf(object value);
                /*0x380d170*/ void System.Collections.IList.Insert(int index, object value);
                /*0x380b128*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x380d83c*/ void System.Collections.IList.Remove(object value);
                /*0x380ba90*/ object System.Collections.IList.get_Item(int index);
                /*0x380d170*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Enumerator<T> GetEnumerator();

                class Builder<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Immutable.IOrderedCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _root;
                    /*0x0*/ System.Collections.Immutable.ImmutableList<T> _immutable;
                    /*0x0*/ int _version;
                    /*0x0*/ object _syncRoot;

                    /*0x380d83c*/ Builder(System.Collections.Immutable.ImmutableList<T> list);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                    /*0x380b6a0*/ int get_Version();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> get_Root();
                    /*0x380d83c*/ void set_Root(System.Collections.Immutable.ImmutableList.Node<T> value);
                    /*0x3907c14*/ T get_Item(int index);
                    /*0x3907c14*/ void set_Item(int index, T value);
                    /*0x3907c14*/ T System.Collections.Immutable.IOrderedCollection<T>.get_Item(int index);
                    /*0x3907c14*/ int IndexOf(T item);
                    /*0x3907c14*/ void Insert(int index, T item);
                    /*0x380cffc*/ void RemoveAt(int index);
                    /*0x3907c14*/ void Add(T item);
                    /*0x380cb08*/ void Clear();
                    /*0x3907c14*/ bool Contains(T item);
                    /*0x3907c14*/ bool Remove(T item);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Enumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList<T> ToImmutable();
                    /*0x380b7a8*/ int System.Collections.IList.Add(object value);
                    /*0x380cb08*/ void System.Collections.IList.Clear();
                    /*0x380b2f0*/ bool System.Collections.IList.Contains(object value);
                    /*0x380b7a8*/ int System.Collections.IList.IndexOf(object value);
                    /*0x380d170*/ void System.Collections.IList.Insert(int index, object value);
                    /*0x380b128*/ bool System.Collections.IList.get_IsFixedSize();
                    /*0x380b128*/ bool System.Collections.IList.get_IsReadOnly();
                    /*0x380d83c*/ void System.Collections.IList.Remove(object value);
                    /*0x380ba90*/ object System.Collections.IList.get_Item(int index);
                    /*0x380d170*/ void System.Collections.IList.set_Item(int index, object value);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Collections.Immutable.ISecurePooledObjectUser, System.Collections.Immutable.IStrongEnumerator<T>
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Builder<T> _builder;
                    /*0x0*/ int _poolUserId;
                    /*0x0*/ int _startIndex;
                    /*0x0*/ int _count;
                    /*0x0*/ int _remainingCount;
                    /*0x0*/ bool _reversed;
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _root;
                    /*0x0*/ System.Collections.Immutable.SecurePooledObject<System.Collections.Generic.Stack<System.Collections.Immutable.RefAsValueType<System.Collections.Immutable.ImmutableList.Node<T>>>> _stack;
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _current;
                    /*0x0*/ int _enumeratingBuilderVersion;

                    /*0x3907c14*/ Enumerator(System.Collections.Immutable.ImmutableList.Node<T> root, System.Collections.Immutable.ImmutableList.Builder<T> builder, int startIndex, int count, bool reversed);
                    /*0x380b6a0*/ int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId();
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void ResetStack();
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableList.Node<T> NextBranch(System.Collections.Immutable.ImmutableList.Node<T> node);
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableList.Node<T> PreviousBranch(System.Collections.Immutable.ImmutableList.Node<T> node);
                    /*0x380cb08*/ void ThrowIfDisposed();
                    /*0x380cb08*/ void ThrowIfChanged();
                    /*0x380d83c*/ void PushNext(System.Collections.Immutable.ImmutableList.Node<T> node);
                }

                class Node<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    static /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> EmptyNode;
                    /*0x0*/ T _key;
                    /*0x0*/ bool _frozen;
                    /*0x0*/ byte _height;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _left;
                    /*0x0*/ System.Collections.Immutable.ImmutableList.Node<T> _right;

                    static /*0x38358cc*/ Node();
                    static /*0x381cca4*/ byte ParentHeight(System.Collections.Immutable.ImmutableList.Node<T> left, System.Collections.Immutable.ImmutableList.Node<T> right);
                    static /*0x3827170*/ int ParentCount(System.Collections.Immutable.ImmutableList.Node<T> left, System.Collections.Immutable.ImmutableList.Node<T> right);
                    static /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Node<T> CreateLeaf(T key);
                    static /*0x3907c14*/ bool Contains(System.Collections.Immutable.ImmutableList.Node<T> node, T value, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                    /*0x380cb08*/ Node();
                    /*0x3907c14*/ Node(T key, System.Collections.Immutable.ImmutableList.Node<T> left, System.Collections.Immutable.ImmutableList.Node<T> right, bool frozen);
                    /*0x380b128*/ bool get_IsEmpty();
                    /*0x380b6a0*/ int get_Height();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> get_Left();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> get_Right();
                    /*0x3907c14*/ T get_Value();
                    /*0x380b6a0*/ int get_Count();
                    /*0x3907c14*/ T get_Key();
                    /*0x380ba90*/ ref T ItemRef(int index);
                    /*0x380ba90*/ ref T ItemRefUnchecked(int index);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Enumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Enumerator<T> GetEnumerator(System.Collections.Immutable.ImmutableList.Builder<T> builder);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Node<T> Add(T key);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Node<T> Insert(int index, T key);
                    /*0x380ba90*/ System.Collections.Immutable.ImmutableList.Node<T> RemoveAt(int index);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Node<T> ReplaceAt(int index, T value);
                    /*0x3907c14*/ int IndexOf(T item, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                    /*0x3907c14*/ bool Contains(T item, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                    /*0x3907c14*/ int IndexOf(T item, int index, int count, System.Collections.Generic.IEqualityComparer<T> equalityComparer);
                    /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                    /*0x380d8b8*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0x380cb08*/ void Freeze();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> RotateLeft();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> RotateRight();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> DoubleLeft();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> DoubleRight();
                    /*0x380b6a0*/ int get_BalanceFactor();
                    /*0x380b128*/ bool get_IsLeftHeavy();
                    /*0x380b128*/ bool get_IsBalanced();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> Balance();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> BalanceLeft();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableList.Node<T> BalanceRight();
                    /*0x380bcbc*/ System.Collections.Immutable.ImmutableList.Node<T> MutateBoth(System.Collections.Immutable.ImmutableList.Node<T> left, System.Collections.Immutable.ImmutableList.Node<T> right);
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableList.Node<T> MutateLeft(System.Collections.Immutable.ImmutableList.Node<T> left);
                    /*0x380bb68*/ System.Collections.Immutable.ImmutableList.Node<T> MutateRight(System.Collections.Immutable.ImmutableList.Node<T> right);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Node<T> MutateKey(T key);
                }
            }

            class ImmutableListBuilderDebuggerProxy<T>
            {
            }

            class ImmutableQueue
            {
            }

            class ImmutableQueue<T> : System.Collections.Immutable.IImmutableQueue<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableQueue<T> s_EmptyField;
                /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _backwards;
                /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _forwards;
                /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _backwardsReversed;

                static /*0x38358cc*/ ImmutableQueue();
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableQueue<T> get_Empty();
                /*0x380d93c*/ ImmutableQueue(System.Collections.Immutable.ImmutableStack<T> forwards, System.Collections.Immutable.ImmutableStack<T> backwards);
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableStack<T> get_BackwardsReversed();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableQueue<T> Enqueue(T value);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                class EnumeratorObject<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableQueue<T> _originalQueue;
                    /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _remainingForwardsStack;
                    /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _remainingBackwardsStack;
                    /*0x0*/ bool _disposed;

                    /*0x380d83c*/ EnumeratorObject(System.Collections.Immutable.ImmutableQueue<T> queue);
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void Dispose();
                    /*0x380cb08*/ void ThrowIfDisposed();
                }
            }

            class ImmutableSortedDictionary
            {
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Create<TKey, TValue>();
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> CreateBuilder<TKey, TValue>();
            }

            class ImmutableSortedDictionary<TKey, TValue> : System.Collections.Immutable.IImmutableDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Empty;
                /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> _root;
                /*0x0*/ int _count;
                /*0x0*/ System.Collections.Generic.IComparer<TKey> _keyComparer;
                /*0x0*/ System.Collections.Generic.IEqualityComparer<TValue> _valueComparer;

                static /*0x38358cc*/ ImmutableSortedDictionary();
                static /*0x3830350*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Wrap(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> root, int count, System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                static /*0x381cca4*/ bool TryCastToImmutableMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> sequence, ref System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> other);
                /*0x380d93c*/ ImmutableSortedDictionary(System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                ImmutableSortedDictionary(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> root, int count, System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Clear();
                /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<TValue> get_ValueComparer();
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> get_Values();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x380b9e8*/ System.Collections.Generic.IComparer<TKey> get_KeyComparer();
                /*0x3907c14*/ TValue get_Item(TKey key);
                /*0x3907c14*/ TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key);
                /*0x3907c14*/ void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> ToBuilder();
                /*0x380bcbc*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> WithComparers(System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                /*0x3907c14*/ bool ContainsValue(TValue value);
                /*0x3907c14*/ bool ContainsKey(TKey key);
                /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x3907c14*/ void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value);
                /*0x3907c14*/ bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380cb08*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear();
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);
                /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x380cb08*/ void System.Collections.IDictionary.Clear();
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> items, bool overwriteOnCollision, bool avoidToSortedMap);
                /*0x380bc74*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Wrap(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> root, int adjustedCountIfDifferentRoot);
                /*0x380bba0*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> FillFromEmpty(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> items, bool overwriteOnCollision);

                class Builder<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> _root;
                    /*0x0*/ System.Collections.Generic.IComparer<TKey> _keyComparer;
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<TValue> _valueComparer;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> _immutable;
                    /*0x0*/ int _version;
                    /*0x0*/ object _syncRoot;

                    /*0x380d83c*/ Builder(System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> map);
                    /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> get_Keys();
                    /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> get_Values();
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                    /*0x380b6a0*/ int get_Version();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> get_Root();
                    /*0x380d83c*/ void set_Root(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> value);
                    /*0x3907c14*/ TValue get_Item(TKey key);
                    /*0x3907c14*/ void set_Item(TKey key, TValue value);
                    /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                    /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
                    /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                    /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                    /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                    /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                    /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);
                    /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                    /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x3907c14*/ void Add(TKey key, TValue value);
                    /*0x3907c14*/ bool ContainsKey(TKey key);
                    /*0x3907c14*/ bool Remove(TKey key);
                    /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                    /*0x3907c14*/ void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                    /*0x380cb08*/ void Clear();
                    /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                    /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                    /*0x3907c14*/ bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> ToImmutable();
                }

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable, System.Collections.Immutable.ISecurePooledObjectUser
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> _builder;
                    /*0x0*/ int _poolUserId;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> _root;
                    /*0x0*/ System.Collections.Immutable.SecurePooledObject<System.Collections.Generic.Stack<System.Collections.Immutable.RefAsValueType<System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue>>>> _stack;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> _current;
                    /*0x0*/ int _enumeratingBuilderVersion;

                    /*0x380d93c*/ Enumerator(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> root, System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> builder);
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x380b6a0*/ int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void ThrowIfDisposed();
                    /*0x380cb08*/ void ThrowIfChanged();
                    /*0x380d83c*/ void PushLeft(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> node);
                }

                class Node<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
                {
                    static /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> EmptyNode;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ bool _frozen;
                    /*0x0*/ byte _height;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> _left;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> _right;

                    static /*0x38358cc*/ Node();
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> NodeTreeFromSortedDictionary(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> RotateLeft(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> RotateRight(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> DoubleLeft(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> DoubleRight(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x3824ba4*/ int Balance(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x381ac0c*/ bool IsRightHeavy(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x381ac0c*/ bool IsLeftHeavy(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> MakeBalanced(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> tree);
                    static /*0x3830278*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> NodeTreeFromList(System.Collections.Immutable.IOrderedCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>> items, int start, int length);
                    /*0x380cb08*/ Node();
                    /*0x3907c14*/ Node(TKey key, TValue value, System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> left, System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> right, bool frozen);
                    /*0x380b128*/ bool get_IsEmpty();
                    /*0x380b6a0*/ int get_Height();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> get_Left();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> get_Right();
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Value();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> get_Keys();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> get_Values();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue> GetEnumerator(System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> builder);
                    void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex, int dictionarySize);
                    void CopyTo(System.Array array, int arrayIndex, int dictionarySize);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> Add(TKey key, TValue value, System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, ref bool mutated);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> SetItem(TKey key, TValue value, System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, ref bool replacedExistingValue, ref bool mutated);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> Remove(TKey key, System.Collections.Generic.IComparer<TKey> keyComparer, ref bool mutated);
                    /*0x3907c14*/ bool TryGetValue(TKey key, System.Collections.Generic.IComparer<TKey> keyComparer, ref TValue value);
                    /*0x3907c14*/ bool ContainsKey(TKey key, System.Collections.Generic.IComparer<TKey> keyComparer);
                    /*0x3907c14*/ bool ContainsValue(TValue value, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                    /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> pair, System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer);
                    /*0x380cb08*/ void Freeze();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> SetOrAdd(TKey key, TValue value, System.Collections.Generic.IComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, bool overwriteExistingValue, ref bool replacedExistingValue, ref bool mutated);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> RemoveRecursive(TKey key, System.Collections.Generic.IComparer<TKey> keyComparer, ref bool mutated);
                    /*0x380bcbc*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> Mutate(System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> left, System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> right);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Node<TKey, TValue> Search(TKey key, System.Collections.Generic.IComparer<TKey> keyComparer);

                    class <>c<TKey, TValue>
                    {
                        static /*0x0*/ System.Collections.Immutable.ImmutableSortedDictionary.Node.<>c<TKey, TValue> <>9;
                        static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TKey> <>9__30_0;
                        static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TValue> <>9__32_0;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x3907c14*/ TKey <get_Keys>b__30_0(System.Collections.Generic.KeyValuePair<TKey, TValue> p);
                        /*0x3907c14*/ TValue <get_Values>b__32_0(System.Collections.Generic.KeyValuePair<TKey, TValue> p);
                    }
                }
            }

            class ImmutableSortedDictionaryBuilderDebuggerProxy<TKey, TValue>
            {
            }

            class ImmutableSortedSet
            {
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableSortedSet<T> Create<T>();
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableSortedSet.Builder<T> CreateBuilder<T>();
            }

            class ImmutableSortedSet<T> : System.Collections.Immutable.IImmutableSet<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.ISet<T>, System.Collections.IList, System.Collections.ICollection, System.Collections.Immutable.IStrongEnumerable<T, System.Collections.Immutable.ImmutableSortedSet.Enumerator<T>>
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableSortedSet<T> Empty;
                /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> _root;
                /*0x0*/ System.Collections.Generic.IComparer<T> _comparer;

                static /*0x38358cc*/ ImmutableSortedSet();
                static /*0x381ac0c*/ bool IsCompatibleObject(object value);
                static /*0x381cca4*/ bool TryCastToImmutableSortedSet(System.Collections.Generic.IEnumerable<T> sequence, ref System.Collections.Immutable.ImmutableSortedSet<T> other);
                static /*0x3830700*/ System.Collections.Immutable.ImmutableSortedSet<T> Wrap(System.Collections.Immutable.ImmutableSortedSet.Node<T> root, System.Collections.Generic.IComparer<T> comparer);
                /*0x380d83c*/ ImmutableSortedSet(System.Collections.Generic.IComparer<T> comparer);
                /*0x380d93c*/ ImmutableSortedSet(System.Collections.Immutable.ImmutableSortedSet.Node<T> root, System.Collections.Generic.IComparer<T> comparer);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedSet<T> Clear();
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ System.Collections.Generic.IComparer<T> get_KeyComparer();
                /*0x3907c14*/ T get_Item(int index);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedSet.Builder<T> ToBuilder();
                /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedSet<T> Union(System.Collections.Generic.IEnumerable<T> other);
                /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedSet<T> WithComparer(System.Collections.Generic.IComparer<T> comparer);
                /*0x3907c14*/ int IndexOf(T item);
                /*0x3907c14*/ bool Contains(T value);
                /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x380d8b8*/ void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x380cb08*/ void System.Collections.Generic.ICollection<T>.Clear();
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<T>.Remove(T item);
                /*0x3907c14*/ T System.Collections.Generic.IList<T>.get_Item(int index);
                /*0x3907c14*/ void System.Collections.Generic.IList<T>.set_Item(int index, T value);
                /*0x3907c14*/ void System.Collections.Generic.IList<T>.Insert(int index, T item);
                /*0x380cffc*/ void System.Collections.Generic.IList<T>.RemoveAt(int index);
                /*0x380b128*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b7a8*/ int System.Collections.IList.Add(object value);
                /*0x380cb08*/ void System.Collections.IList.Clear();
                /*0x380b2f0*/ bool System.Collections.IList.Contains(object value);
                /*0x380b7a8*/ int System.Collections.IList.IndexOf(object value);
                /*0x380d170*/ void System.Collections.IList.Insert(int index, object value);
                /*0x380d83c*/ void System.Collections.IList.Remove(object value);
                /*0x380cffc*/ void System.Collections.IList.RemoveAt(int index);
                /*0x380ba90*/ object System.Collections.IList.get_Item(int index);
                /*0x380d170*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Enumerator<T> GetEnumerator();
                /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedSet<T> UnionIncremental(System.Collections.Generic.IEnumerable<T> items);
                /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedSet<T> Wrap(System.Collections.Immutable.ImmutableSortedSet.Node<T> root);
                /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedSet<T> LeafToRootRefill(System.Collections.Generic.IEnumerable<T> addedItems);

                class Builder<T> : System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.ISet<T>, System.Collections.Generic.ICollection<T>, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> _root;
                    /*0x0*/ System.Collections.Generic.IComparer<T> _comparer;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet<T> _immutable;
                    /*0x0*/ int _version;
                    /*0x0*/ object _syncRoot;

                    /*0x380d83c*/ Builder(System.Collections.Immutable.ImmutableSortedSet<T> set);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                    /*0x380b6a0*/ int get_Version();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> get_Root();
                    /*0x380d83c*/ void set_Root(System.Collections.Immutable.ImmutableSortedSet.Node<T> value);
                    /*0x3907c14*/ bool Add(T item);
                    /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                    /*0x380cb08*/ void Clear();
                    /*0x3907c14*/ bool Contains(T item);
                    /*0x380d8b8*/ void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex);
                    /*0x3907c14*/ bool Remove(T item);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Enumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedSet<T> ToImmutable();
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Collections.Immutable.ISecurePooledObjectUser, System.Collections.Immutable.IStrongEnumerator<T>
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Builder<T> _builder;
                    /*0x0*/ int _poolUserId;
                    /*0x0*/ bool _reverse;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> _root;
                    /*0x0*/ System.Collections.Immutable.SecurePooledObject<System.Collections.Generic.Stack<System.Collections.Immutable.RefAsValueType<System.Collections.Immutable.ImmutableSortedSet.Node<T>>>> _stack;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> _current;
                    /*0x0*/ int _enumeratingBuilderVersion;

                    Enumerator(System.Collections.Immutable.ImmutableSortedSet.Node<T> root, System.Collections.Immutable.ImmutableSortedSet.Builder<T> builder, bool reverse);
                    /*0x380b6a0*/ int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId();
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void ThrowIfDisposed();
                    /*0x380cb08*/ void ThrowIfChanged();
                    /*0x380d83c*/ void PushNext(System.Collections.Immutable.ImmutableSortedSet.Node<T> node);
                }

                class Node<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    static /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> EmptyNode;
                    /*0x0*/ T _key;
                    /*0x0*/ bool _frozen;
                    /*0x0*/ byte _height;
                    /*0x0*/ int _count;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> _left;
                    /*0x0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> _right;

                    static /*0x38358cc*/ Node();
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> RotateLeft(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> RotateRight(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> DoubleLeft(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> DoubleRight(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x3824ba4*/ int Balance(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x381ac0c*/ bool IsRightHeavy(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x381ac0c*/ bool IsLeftHeavy(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x382eaf0*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> MakeBalanced(System.Collections.Immutable.ImmutableSortedSet.Node<T> tree);
                    static /*0x3830278*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> NodeTreeFromList(System.Collections.Immutable.IOrderedCollection<T> items, int start, int length);
                    /*0x380cb08*/ Node();
                    /*0x3907c14*/ Node(T key, System.Collections.Immutable.ImmutableSortedSet.Node<T> left, System.Collections.Immutable.ImmutableSortedSet.Node<T> right, bool frozen);
                    /*0x380b128*/ bool get_IsEmpty();
                    /*0x380b6a0*/ int get_Height();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> get_Left();
                    /*0x380b9e8*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> get_Right();
                    /*0x3907c14*/ T get_Value();
                    /*0x380b6a0*/ int get_Count();
                    /*0x380ba90*/ ref T ItemRef(int index);
                    /*0x380ba90*/ ref T ItemRefUnchecked(int index);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Enumerator<T> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Enumerator<T> GetEnumerator(System.Collections.Immutable.ImmutableSortedSet.Builder<T> builder);
                    /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                    /*0x380d8b8*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> Add(T key, System.Collections.Generic.IComparer<T> comparer, ref bool mutated);
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> Remove(T key, System.Collections.Generic.IComparer<T> comparer, ref bool mutated);
                    /*0x3907c14*/ bool Contains(T key, System.Collections.Generic.IComparer<T> comparer);
                    /*0x380cb08*/ void Freeze();
                    /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> Search(T key, System.Collections.Generic.IComparer<T> comparer);
                    /*0x3907c14*/ int IndexOf(T key, System.Collections.Generic.IComparer<T> comparer);
                    /*0x380bcbc*/ System.Collections.Immutable.ImmutableSortedSet.Node<T> Mutate(System.Collections.Immutable.ImmutableSortedSet.Node<T> left, System.Collections.Immutable.ImmutableSortedSet.Node<T> right);
                }
            }

            class ImmutableSortedSetBuilderDebuggerProxy<T>
            {
            }

            class ImmutableStack
            {
                static /*0x3907c14*/ System.Collections.Immutable.ImmutableStack<T> Create<T>(T item);
                static /*0x382eaf0*/ System.Collections.Immutable.ImmutableStack<T> CreateRange<T>(System.Collections.Generic.IEnumerable<T> items);
            }

            class ImmutableStack<T> : System.Collections.Immutable.IImmutableStack<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                static /*0x0*/ System.Collections.Immutable.ImmutableStack<T> s_EmptyField;
                /*0x0*/ T _head;
                /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _tail;

                static /*0x38358cc*/ ImmutableStack();
                static /*0x382dee4*/ System.Collections.Immutable.ImmutableStack<T> get_Empty();
                /*0x380cb08*/ ImmutableStack();
                /*0x3907c14*/ ImmutableStack(T head, System.Collections.Immutable.ImmutableStack<T> tail);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableStack<T> Clear();
                /*0x380b128*/ bool get_IsEmpty();
                /*0x3907c14*/ T Peek();
                /*0x3907c14*/ System.Collections.Immutable.ImmutableStack<T> Push(T value);
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableStack<T> Pop();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380b9e8*/ System.Collections.Immutable.ImmutableStack<T> Reverse();

                class EnumeratorObject<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _originalStack;
                    /*0x0*/ System.Collections.Immutable.ImmutableStack<T> _remainingStack;
                    /*0x0*/ bool _disposed;

                    /*0x380d83c*/ EnumeratorObject(System.Collections.Immutable.ImmutableStack<T> stack);
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void Dispose();
                    /*0x380cb08*/ void ThrowIfDisposed();
                }
            }

            class KeysOrValuesCollectionAccessor<TKey, TValue, T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.Immutable.IImmutableDictionary<TKey, TValue> _dictionary;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> _keysOrValues;

                /*0x380d93c*/ KeysOrValuesCollectionAccessor(System.Collections.Immutable.IImmutableDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEnumerable<T> keysOrValues);
                /*0x380b128*/ bool get_IsReadOnly();
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ System.Collections.Immutable.IImmutableDictionary<TKey, TValue> get_Dictionary();
                /*0x3907c14*/ void Add(T item);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool Contains(T item);
                /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x3907c14*/ bool Remove(T item);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
            }

            class KeysCollectionAccessor<TKey, TValue> : System.Collections.Immutable.KeysOrValuesCollectionAccessor<TKey, TValue, TKey>
            {
                /*0x380d83c*/ KeysCollectionAccessor(System.Collections.Immutable.IImmutableDictionary<TKey, TValue> dictionary);
                /*0x3907c14*/ bool Contains(TKey item);
            }

            class ValuesCollectionAccessor<TKey, TValue> : System.Collections.Immutable.KeysOrValuesCollectionAccessor<TKey, TValue, TValue>
            {
                /*0x380d83c*/ ValuesCollectionAccessor(System.Collections.Immutable.IImmutableDictionary<TKey, TValue> dictionary);
                /*0x3907c14*/ bool Contains(TValue item);
            }

            struct RefAsValueType<T>
            {
                /*0x0*/ T Value;

                /*0x3907c14*/ RefAsValueType(T value);
            }

            class SecureObjectPool
            {
                static /*0x0*/ int s_poolUserIdCounter;

                static /*0x73c72e0*/ int NewId();
            }

            class SecureObjectPool<T, TCaller>
            {
                static /*0x3907c14*/ void TryAdd(TCaller caller, System.Collections.Immutable.SecurePooledObject<T> item);
                static /*0x3907c14*/ bool TryTake(TCaller caller, ref System.Collections.Immutable.SecurePooledObject<T> item);
                static /*0x3907c14*/ System.Collections.Immutable.SecurePooledObject<T> PrepNew(TCaller caller, T newValue);
            }

            interface ISecurePooledObjectUser
            {
                /*0x380b6a0*/ int get_PoolUserId();
            }

            class SecurePooledObject<T>
            {
                /*0x0*/ T _value;
                /*0x0*/ int _owner;

                /*0x3907c14*/ SecurePooledObject(T newValue);
                /*0x380b6a0*/ int get_Owner();
                /*0x380cffc*/ void set_Owner(int value);
                /*0x3907c14*/ T Use<TCaller>(ref TCaller caller);
                /*0x380b32c*/ bool TryUse<TCaller>(ref TCaller caller, ref T value);
                /*0x380b2f0*/ bool IsOwned<TCaller>(ref TCaller caller);
            }

            class SortedInt32KeyNode<TValue>
            {
                static /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> EmptyNode;
                /*0x0*/ int _key;
                /*0x0*/ TValue _value;
                /*0x0*/ bool _frozen;
                /*0x0*/ byte _height;
                /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> _left;
                /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> _right;

                static /*0x38358cc*/ SortedInt32KeyNode();
                static /*0x382eaf0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> RotateLeft(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x382eaf0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> RotateRight(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x382eaf0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x382eaf0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> DoubleRight(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x3824ba4*/ int Balance(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x381ac0c*/ bool IsRightHeavy(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x381ac0c*/ bool IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                static /*0x382eaf0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode<TValue> tree);
                /*0x380cb08*/ SortedInt32KeyNode();
                /*0x3907c14*/ SortedInt32KeyNode(int key, TValue value, System.Collections.Immutable.SortedInt32KeyNode<TValue> left, System.Collections.Immutable.SortedInt32KeyNode<TValue> right, bool frozen);
                /*0x380b128*/ bool get_IsEmpty();
                /*0x380b6a0*/ int get_Height();
                /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> get_Left();
                /*0x380b9e8*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> get_Right();
                /*0x3907c14*/ System.Collections.Generic.KeyValuePair<int, TValue> get_Value();
                /*0x3907c14*/ System.Collections.Immutable.SortedInt32KeyNode.Enumerator<TValue> GetEnumerator();
                /*0x3907c14*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> SetItem(int key, TValue value, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, ref bool replacedExistingValue, ref bool mutated);
                System.Collections.Immutable.SortedInt32KeyNode<TValue> Remove(int key, ref bool mutated);
                /*0x3907c14*/ TValue GetValueOrDefault(int key);
                /*0x380b26c*/ bool TryGetValue(int key, ref TValue value);
                /*0x380d83c*/ void Freeze(System.Action<System.Collections.Generic.KeyValuePair<int, TValue>> freezeAction);
                /*0x3907c14*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> SetOrAdd(int key, TValue value, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, bool overwriteExistingValue, ref bool replacedExistingValue, ref bool mutated);
                System.Collections.Immutable.SortedInt32KeyNode<TValue> RemoveRecursive(int key, ref bool mutated);
                /*0x380bcbc*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> Mutate(System.Collections.Immutable.SortedInt32KeyNode<TValue> left, System.Collections.Immutable.SortedInt32KeyNode<TValue> right);

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int, TValue>>, System.Collections.IEnumerator, System.IDisposable, System.Collections.Immutable.ISecurePooledObjectUser
                {
                    /*0x0*/ int _poolUserId;
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> _root;
                    /*0x0*/ System.Collections.Immutable.SecurePooledObject<System.Collections.Generic.Stack<System.Collections.Immutable.RefAsValueType<System.Collections.Immutable.SortedInt32KeyNode<TValue>>>> _stack;
                    /*0x0*/ System.Collections.Immutable.SortedInt32KeyNode<TValue> _current;

                    /*0x380d83c*/ Enumerator(System.Collections.Immutable.SortedInt32KeyNode<TValue> root);
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<int, TValue> get_Current();
                    /*0x380b6a0*/ int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void ThrowIfDisposed();
                    /*0x380d83c*/ void PushLeft(System.Collections.Immutable.SortedInt32KeyNode<TValue> node);
                }
            }

            class Requires
            {
                static /*0x3907c14*/ void NotNull<T>(T value, string parameterName);
                static /*0x3907c14*/ T NotNullPassthrough<T>(T value, string parameterName);
                static /*0x3907c14*/ void NotNullAllowStructs<T>(T value, string parameterName);
                static /*0x73c732c*/ void FailArgumentNullException(string parameterName);
                static /*0x73c7370*/ void Range(bool condition, string parameterName, string message);
                static /*0x73c7388*/ void FailRange(string parameterName, string message);
                static /*0x73c73f8*/ void Argument(bool condition);
                static /*0x3907c14*/ void FailObjectDisposed<TDisposed>(TDisposed disposed);
            }
        }
    }
}
