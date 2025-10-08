class <Module>
{
}

namespace Entitas
{
    class Context<TEntity> : Entitas.IContext
    {
        /*0x0*/ Entitas.ContextEntityChanged OnEntityCreated;
        /*0x0*/ Entitas.ContextEntityChanged OnEntityWillBeDestroyed;
        /*0x0*/ Entitas.ContextEntityChanged OnEntityDestroyed;
        /*0x0*/ Entitas.ContextGroupChanged OnGroupCreated;
        /*0x0*/ int _totalComponents;
        /*0x0*/ System.Collections.Generic.Stack<Entitas.IComponent> _componentPools;
        /*0x0*/ Entitas.ContextInfo _contextInfo;
        /*0x0*/ System.Func<Entitas.IEntity, Entitas.IAERC> _aercFactory;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _entities;
        /*0x0*/ System.Collections.Generic.Stack<TEntity> _reusableEntities;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _retainedEntities;
        /*0x0*/ System.Collections.Generic.Dictionary<Entitas.IMatcher<TEntity>, Entitas.IGroup<TEntity>> _groups;
        /*0x0*/ System.Collections.Generic.List<Entitas.IGroup<TEntity>> _groupsForIndex;
        /*0x0*/ Entitas.Utils.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<TEntity>>> _groupChangedListPool;
        /*0x0*/ System.Collections.Generic.Dictionary<string, Entitas.IEntityIndex> _entityIndices;
        /*0x0*/ int _creationIndex;
        /*0x0*/ TEntity[] _entitiesCache;
        /*0x0*/ Entitas.EntityComponentChanged _cachedEntityChanged;
        /*0x0*/ Entitas.EntityComponentReplaced _cachedComponentReplaced;
        /*0x0*/ Entitas.EntityEvent _cachedEntityReleased;
        /*0x0*/ Entitas.EntityEvent _cachedDestroyEntity;

        /*0x1f30c40*/ Context(int totalComponents, int startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity, Entitas.IAERC> aercFactory);
        /*0x1f2ffc8*/ int get_totalComponents();
        /*0x1f30214*/ Entitas.ContextInfo createDefaultContextInfo();
        /*0x1ffc854*/ TEntity CreateEntity();
        /*0x1ffc854*/ void DestroyEntity(TEntity entity);
        /*0x1f30214*/ TEntity[] GetEntities();
        /*0x1f302cc*/ Entitas.IGroup<TEntity> GetGroup(Entitas.IMatcher<TEntity> matcher);
        /*0x1f30b78*/ void ResetCreationIndex(int index);
        /*0x1f30214*/ string ToString();
        /*0x1f30f2c*/ void updateGroupsComponentAddedOrRemoved(Entitas.IEntity entity, int index, Entitas.IComponent component);
        /*0x1f30f6c*/ void updateGroupsComponentReplaced(Entitas.IEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        /*0x1f30ebc*/ void onEntityReleased(Entitas.IEntity entity);
        /*0x1f30ebc*/ void onDestroyEntity(Entitas.IEntity entity);

        class <>c<TEntity>
        {
            static /*0x0*/ Entitas.Context.<>c<TEntity> <>9;
            static /*0x0*/ System.Func<Entitas.IEntity, Entitas.IAERC> <>9__43_0;
            static /*0x0*/ System.Func<System.Collections.Generic.List<Entitas.GroupChanged<TEntity>>> <>9__43_1;
            static /*0x0*/ System.Action<System.Collections.Generic.List<Entitas.GroupChanged<TEntity>>> <>9__43_2;

            static /*0x1f33998*/ <>c();
            /*0x1f309e4*/ <>c();
            /*0x1f302cc*/ Entitas.IAERC <.ctor>b__43_0(Entitas.IEntity entity);
            /*0x1f30214*/ System.Collections.Generic.List<Entitas.GroupChanged<TEntity>> <.ctor>b__43_1();
            /*0x1f30ebc*/ void <.ctor>b__43_2(System.Collections.Generic.List<Entitas.GroupChanged<TEntity>> list);
        }
    }

    class ContextDoesNotContainEntityException : Entitas.EntitasException
    {
        /*0x2d1d434*/ ContextDoesNotContainEntityException(string message, string hint);
    }

    class ContextInfoException : Entitas.EntitasException
    {
        /*0x2d1d53c*/ ContextInfoException(Entitas.IContext context, Entitas.ContextInfo contextInfo);
    }

    class EntityIsNotDestroyedException : Entitas.EntitasException
    {
        /*0x2d1d7d4*/ EntityIsNotDestroyedException(string message);
    }

    class ContextEntityChanged : System.MulticastDelegate
    {
        /*0x2d1d850*/ ContextEntityChanged(object object, nint method);
        /*0x2d1d95c*/ void Invoke(Entitas.IContext context, Entitas.IEntity entity);
    }

    class ContextGroupChanged : System.MulticastDelegate
    {
        /*0x2d1d970*/ ContextGroupChanged(object object, nint method);
        /*0x2d1da7c*/ void Invoke(Entitas.IContext context, Entitas.IGroup group);
    }

    interface IContext
    {
        /*0x1f2ffc8*/ int get_totalComponents();
    }

    class ContextInfo
    {
        /*0x10*/ string name;
        /*0x18*/ string[] componentNames;
        /*0x20*/ System.Type[] componentTypes;

        /*0x2d1da90*/ ContextInfo(string name, string[] componentNames, System.Type[] componentTypes);
    }

    class EntitasCache
    {
        static /*0x0*/ Entitas.Utils.ObjectCache _cache;

        static /*0x2d1dee8*/ EntitasCache();
        static /*0x2d1daf0*/ System.Collections.Generic.List<Entitas.IComponent> GetIComponentList();
        static /*0x2d1db74*/ void PushIComponentList(System.Collections.Generic.List<Entitas.IComponent> list);
        static /*0x2d1dc58*/ System.Collections.Generic.List<int> GetIntList();
        static /*0x2d1dcdc*/ void PushIntList(System.Collections.Generic.List<int> list);
        static /*0x2d1ddc0*/ System.Collections.Generic.HashSet<int> GetIntHashSet();
        static /*0x2d1de44*/ void PushIntHashSet(System.Collections.Generic.HashSet<int> hashSet);
    }

    class EntitasException : System.Exception
    {
        /*0x2d1d4a0*/ EntitasException(string message, string hint);
    }

    class Entity : Entitas.IEntity, Entitas.IAERC
    {
        /*0x10*/ Entitas.EntityComponentChanged OnComponentAdded;
        /*0x18*/ Entitas.EntityComponentChanged OnComponentRemoved;
        /*0x20*/ Entitas.EntityComponentReplaced OnComponentReplaced;
        /*0x28*/ Entitas.EntityEvent OnEntityReleased;
        /*0x30*/ Entitas.EntityEvent OnDestroyEntity;
        /*0x38*/ int _creationIndex;
        /*0x3c*/ bool _isEnabled;
        /*0x40*/ int _totalComponents;
        /*0x48*/ Entitas.IComponent[] _components;
        /*0x50*/ System.Collections.Generic.Stack<Entitas.IComponent> _componentPools;
        /*0x58*/ Entitas.ContextInfo _contextInfo;
        /*0x60*/ Entitas.IAERC _aerc;
        /*0x68*/ Entitas.IComponent[] _componentsCache;
        /*0x70*/ int[] _componentIndicesCache;
        /*0x78*/ string _toStringCache;
        /*0x80*/ System.Text.StringBuilder _toStringBuilder;

        /*0x2d20188*/ Entity();
        /*0x2d1df64*/ void add_OnComponentAdded(Entitas.EntityComponentChanged value);
        /*0x2d1e000*/ void remove_OnComponentAdded(Entitas.EntityComponentChanged value);
        /*0x2d1e09c*/ void add_OnComponentRemoved(Entitas.EntityComponentChanged value);
        /*0x2d1e138*/ void remove_OnComponentRemoved(Entitas.EntityComponentChanged value);
        /*0x2d1e1d4*/ void add_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        /*0x2d1e270*/ void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        /*0x2d1e30c*/ void add_OnEntityReleased(Entitas.EntityEvent value);
        /*0x2d1e3a8*/ void remove_OnEntityReleased(Entitas.EntityEvent value);
        /*0x2d1e444*/ void add_OnDestroyEntity(Entitas.EntityEvent value);
        /*0x2d1e4e0*/ void remove_OnDestroyEntity(Entitas.EntityEvent value);
        /*0x2d1e57c*/ int get_totalComponents();
        /*0x2d1e584*/ int get_creationIndex();
        /*0x2d1e58c*/ bool get_isEnabled();
        /*0x2d1e594*/ void Initialize(int creationIndex, int totalComponents, System.Collections.Generic.Stack<Entitas.IComponent> componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc);
        /*0x2d1e6a4*/ Entitas.ContextInfo createDefaultContextInfo();
        /*0x2d1e694*/ void Reactivate(int creationIndex);
        /*0x2d1e84c*/ void AddComponent(int index, Entitas.IComponent component);
        /*0x2d1ecd0*/ void RemoveComponent(int index);
        /*0x2d1f1b0*/ void ReplaceComponent(int index, Entitas.IComponent component);
        /*0x2d1eff4*/ void replaceComponent(int index, Entitas.IComponent replacement);
        /*0x2d1f420*/ Entitas.IComponent GetComponent(int index);
        /*0x2d1f594*/ Entitas.IComponent[] GetComponents();
        /*0x2d1f6bc*/ int[] GetComponentIndices();
        /*0x2d1ebf4*/ bool HasComponent(int index);
        /*0x2d1f7ec*/ bool HasComponents(int[] indices);
        /*0x2d1f864*/ bool HasAnyComponent(int[] indices);
        /*0x2d1f8dc*/ void RemoveAllComponents();
        /*0x2d1f334*/ System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(int index);
        /*0x2d1f958*/ Entitas.IComponent CreateComponent(int index, System.Type type);
        /*0x1ffc854*/ T CreateComponent<T>(int index);
        /*0x2d1fa2c*/ int get_retainCount();
        /*0x2d1facc*/ void Retain(object owner);
        /*0x2d1fb88*/ void Release(object owner);
        /*0x2d1fce0*/ void Destroy();
        /*0x2d1fd90*/ void InternalDestroy();
        /*0x2d1fde4*/ void RemoveAllOnEntityReleasedHandlers();
        /*0x2d1fdf0*/ string ToString();
    }

    class EntityEqualityComparer<TEntity> : System.Collections.Generic.IEqualityComparer<TEntity>
    {
        static /*0x0*/ System.Collections.Generic.IEqualityComparer<TEntity> comparer;

        static /*0x1f33998*/ EntityEqualityComparer();
        /*0x1f309e4*/ EntityEqualityComparer();
        /*0x1ffc854*/ bool Equals(TEntity x, TEntity y);
        /*0x1ffc854*/ int GetHashCode(TEntity obj);
    }

    class EntityAlreadyHasComponentException : Entitas.EntitasException
    {
        /*0x2d1ec2c*/ EntityAlreadyHasComponentException(int index, string message, string hint);
    }

    class EntityDoesNotHaveComponentException : Entitas.EntitasException
    {
        /*0x2d1ef50*/ EntityDoesNotHaveComponentException(int index, string message, string hint);
    }

    class EntityIsAlreadyRetainedByOwnerException : Entitas.EntitasException
    {
        /*0x2d20190*/ EntityIsAlreadyRetainedByOwnerException(Entitas.IEntity entity, object owner);
    }

    class EntityIsNotEnabledException : Entitas.EntitasException
    {
        /*0x2d1eb78*/ EntityIsNotEnabledException(string message);
    }

    class EntityIsNotRetainedByOwnerException : Entitas.EntitasException
    {
        /*0x2d2032c*/ EntityIsNotRetainedByOwnerException(Entitas.IEntity entity, object owner);
    }

    interface IAERC
    {
        /*0x1f2ffc8*/ int get_retainCount();
        /*0x1f30ebc*/ void Retain(object owner);
        /*0x1f30ebc*/ void Release(object owner);
    }

    class EntityComponentChanged : System.MulticastDelegate
    {
        /*0x2d204c8*/ EntityComponentChanged(object object, nint method);
        /*0x2d205d4*/ void Invoke(Entitas.IEntity entity, int index, Entitas.IComponent component);
    }

    class EntityComponentReplaced : System.MulticastDelegate
    {
        /*0x2d205e8*/ EntityComponentReplaced(object object, nint method);
        /*0x2d206f4*/ void Invoke(Entitas.IEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
    }

    class EntityEvent : System.MulticastDelegate
    {
        /*0x2d20708*/ EntityEvent(object object, nint method);
        /*0x2d20810*/ void Invoke(Entitas.IEntity entity);
    }

    interface IEntity : Entitas.IAERC
    {
        /*0x1f30ebc*/ void add_OnComponentAdded(Entitas.EntityComponentChanged value);
        /*0x1f30ebc*/ void remove_OnComponentAdded(Entitas.EntityComponentChanged value);
        /*0x1f30ebc*/ void add_OnComponentRemoved(Entitas.EntityComponentChanged value);
        /*0x1f30ebc*/ void remove_OnComponentRemoved(Entitas.EntityComponentChanged value);
        /*0x1f30ebc*/ void add_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        /*0x1f30ebc*/ void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        /*0x1f30ebc*/ void add_OnEntityReleased(Entitas.EntityEvent value);
        /*0x1f30ebc*/ void remove_OnEntityReleased(Entitas.EntityEvent value);
        /*0x1f30ebc*/ void add_OnDestroyEntity(Entitas.EntityEvent value);
        /*0x1f30ebc*/ void remove_OnDestroyEntity(Entitas.EntityEvent value);
        /*0x1f2ffc8*/ int get_creationIndex();
        /*0x1f2fe14*/ bool get_isEnabled();
        void Initialize(int creationIndex, int totalComponents, System.Collections.Generic.Stack<Entitas.IComponent> componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc);
        /*0x1f30b78*/ void Reactivate(int creationIndex);
        /*0x1f30c88*/ void AddComponent(int index, Entitas.IComponent component);
        /*0x1f30240*/ Entitas.IComponent GetComponent(int index);
        /*0x1f30214*/ int[] GetComponentIndices();
        /*0x1f2fe40*/ bool HasComponent(int index);
        /*0x1f2fec8*/ bool HasComponents(int[] indices);
        /*0x1f2fec8*/ bool HasAnyComponent(int[] indices);
        Entitas.IComponent CreateComponent(int index, System.Type type);
        /*0x1ffc854*/ T CreateComponent<T>(int index);
        /*0x1f309e4*/ void InternalDestroy();
        /*0x1f309e4*/ void RemoveAllOnEntityReleasedHandlers();
    }

    class SafeAERC : Entitas.IAERC
    {
        /*0x10*/ Entitas.IEntity _entity;
        /*0x18*/ System.Collections.Generic.HashSet<object> _owners;

        /*0x2d1e7b0*/ SafeAERC(Entitas.IEntity entity);
        /*0x2d20824*/ int get_retainCount();
        /*0x2d2086c*/ System.Collections.Generic.HashSet<object> get_owners();
        /*0x2d20874*/ void Retain(object owner);
        /*0x2d20910*/ void Release(object owner);
    }

    interface IEntityIndex
    {
    }

    class ComponentStringExtension
    {
        static /*0x2d200f8*/ string RemoveComponentSuffix(string componentName);
    }

    class Group<TEntity> : Entitas.IGroup<TEntity>, Entitas.IGroup, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<TEntity>
    {
        /*0x0*/ Entitas.GroupChanged<TEntity> OnEntityAdded;
        /*0x0*/ Entitas.GroupChanged<TEntity> OnEntityRemoved;
        /*0x0*/ Entitas.GroupUpdated<TEntity> OnEntityUpdated;
        /*0x0*/ Entitas.IMatcher<TEntity> _matcher;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _entities;
        /*0x0*/ System.Collections.Generic.List<TEntity> _entitiesList;
        /*0x0*/ bool _hasValidCachedEntities;
        /*0x0*/ TEntity[] _entitiesCache;
        /*0x0*/ TEntity _singleEntityCache;
        /*0x0*/ string _toStringCache;

        /*0x1f30ebc*/ Group(Entitas.IMatcher<TEntity> matcher);
        /*0x1f2ffc8*/ int get_count();
        /*0x1ffc854*/ void HandleEntitySilently(TEntity entity);
        /*0x1ffc854*/ void UpdateEntity(TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        /*0x1ffc854*/ Entitas.GroupChanged<TEntity> HandleEntity(TEntity entity);
        /*0x1ffc854*/ bool addEntitySilently(TEntity entity);
        /*0x1ffc854*/ bool removeEntitySilently(TEntity entity);
        /*0x1f30214*/ TEntity[] GetEntities();
        /*0x1f30214*/ System.Collections.Generic.List<TEntity> GetEntitiesNonAlloc();
        /*0x1f30214*/ System.Collections.Generic.IEnumerator<TEntity> GetEnumerator();
        /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x1ffc854*/ TEntity GetSingleEntity();
        /*0x1f30214*/ string ToString();
    }

    class GroupSingleEntityException<TEntity> : Entitas.EntitasException
    {
        /*0x1f30ebc*/ GroupSingleEntityException(Entitas.IGroup<TEntity> group);

        class <>c<TEntity>
        {
            static /*0x0*/ Entitas.GroupSingleEntityException.<>c<TEntity> <>9;
            static /*0x0*/ System.Func<TEntity, string> <>9__0_0;

            static /*0x1f33998*/ <>c();
            /*0x1f309e4*/ <>c();
            /*0x1ffc854*/ string <.ctor>b__0_0(TEntity e);
        }
    }

    class GroupChanged<TEntity> : System.MulticastDelegate
    {
        GroupChanged(object object, nint method);
        /*0x1ffc854*/ void Invoke(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent component);
    }

    class GroupUpdated<TEntity> : System.MulticastDelegate
    {
        GroupUpdated(object object, nint method);
        /*0x1ffc854*/ void Invoke(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
    }

    interface IGroup : System.Collections.IEnumerable
    {
        /*0x1f2ffc8*/ int get_count();
    }

    interface IGroup<TEntity> : Entitas.IGroup, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<TEntity>
    {
        /*0x1ffc854*/ void HandleEntitySilently(TEntity entity);
        /*0x1ffc854*/ Entitas.GroupChanged<TEntity> HandleEntity(TEntity entity);
        /*0x1ffc854*/ void UpdateEntity(TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        /*0x1f30214*/ TEntity[] GetEntities();
        /*0x1f30214*/ System.Collections.Generic.List<TEntity> GetEntitiesNonAlloc();
        /*0x1ffc854*/ TEntity GetSingleEntity();
    }

    interface IComponent
    {
    }

    interface IAllOfMatcher<TEntity> : Entitas.IAnyOfMatcher<TEntity>, Entitas.INoneOfMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
        /*0x1f302cc*/ Entitas.IAnyOfMatcher<TEntity> AnyOf(int[] indices);
        /*0x1f302cc*/ Entitas.IAnyOfMatcher<TEntity> AnyOf(Entitas.IMatcher<TEntity> matchers);
    }

    interface IAnyOfMatcher<TEntity> : Entitas.INoneOfMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
        /*0x1f302cc*/ Entitas.INoneOfMatcher<TEntity> NoneOf(Entitas.IMatcher<TEntity> matchers);
    }

    interface IMatcher<TEntity>
    {
        /*0x1f30214*/ int[] get_indices();
        /*0x1ffc854*/ bool Matches(TEntity entity);
    }

    interface INoneOfMatcher<TEntity> : Entitas.IMatcher<TEntity>
    {
    }

    class Matcher<TEntity> : Entitas.IAllOfMatcher<TEntity>, Entitas.IAnyOfMatcher<TEntity>, Entitas.INoneOfMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
        /*0x0*/ string[] <componentNames>k__BackingField;
        /*0x0*/ int[] _indices;
        /*0x0*/ int[] _allOfIndices;
        /*0x0*/ int[] _anyOfIndices;
        /*0x0*/ int[] _noneOfIndices;
        /*0x0*/ int _hash;
        /*0x0*/ bool _isHashCached;
        /*0x0*/ string _toStringCache;
        /*0x0*/ System.Text.StringBuilder _toStringBuilder;

        static /*0x1f318fc*/ bool equalIndices(int[] i1, int[] i2);
        static /*0x1ffc854*/ int applyHash(int hash, int[] indices, int i1, int i2);
        static /*0x1f327cc*/ Entitas.IAllOfMatcher<TEntity> AllOf(int[] indices);
        static /*0x1f327cc*/ Entitas.IAllOfMatcher<TEntity> AllOf(Entitas.IMatcher<TEntity> matchers);
        static /*0x1f327cc*/ Entitas.IAnyOfMatcher<TEntity> AnyOf(int[] indices);
        static /*0x1f327cc*/ Entitas.IAnyOfMatcher<TEntity> AnyOf(Entitas.IMatcher<TEntity> matchers);
        static /*0x1f3299c*/ int[] mergeIndices(int[] allOfIndices, int[] anyOfIndices, int[] noneOfIndices);
        static /*0x1f327cc*/ int[] mergeIndices(Entitas.IMatcher<TEntity> matchers);
        static /*0x1f327cc*/ string[] getComponentNames(Entitas.IMatcher<TEntity> matchers);
        static /*0x1f36f18*/ void setComponentNames(Entitas.Matcher<TEntity> matcher, Entitas.IMatcher<TEntity> matchers);
        static /*0x1f327cc*/ int[] distinctIndices(System.Collections.Generic.IList<int> indices);
        static /*0x1f375c4*/ void appendIndices(System.Text.StringBuilder sb, string prefix, int[] indexArray, string[] componentNames);
        /*0x1f309e4*/ Matcher();
        /*0x1f30214*/ int[] get_indices();
        /*0x1f30214*/ int[] get_allOfIndices();
        /*0x1f30214*/ int[] get_anyOfIndices();
        /*0x1f30214*/ int[] get_noneOfIndices();
        /*0x1f30214*/ string[] get_componentNames();
        /*0x1f30ebc*/ void set_componentNames(string[] value);
        /*0x1f302cc*/ Entitas.IAnyOfMatcher<TEntity> Entitas.IAllOfMatcher<TEntity>.AnyOf(int[] indices);
        /*0x1f302cc*/ Entitas.IAnyOfMatcher<TEntity> Entitas.IAllOfMatcher<TEntity>.AnyOf(Entitas.IMatcher<TEntity> matchers);
        /*0x1f302cc*/ Entitas.INoneOfMatcher<TEntity> NoneOf(int[] indices);
        /*0x1f302cc*/ Entitas.INoneOfMatcher<TEntity> NoneOf(Entitas.IMatcher<TEntity> matchers);
        /*0x1ffc854*/ bool Matches(TEntity entity);
        /*0x1f2fec8*/ bool Equals(object obj);
        /*0x1f2ffc8*/ int GetHashCode();
        /*0x1f30214*/ string ToString();
    }

    class MatcherException : System.Exception
    {
        /*0x2d209ac*/ MatcherException(int indices);
    }
}
