class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7ebaddc*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x7ebade4*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace Unity
{
    namespace Hierarchy
    {
        struct HierarchyFlattenedNodeChildren
        {
            /*0x10*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
            /*0x18*/ Unity.Hierarchy.HierarchyNode m_Node;
            /*0x20*/ int m_Version;
            /*0x24*/ int m_Count;

            /*0x7ebadec*/ HierarchyFlattenedNodeChildren(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebb0d0*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren.Enumerator GetEnumerator();
            /*0x7ebb1a8*/ void ThrowIfVersionChanged();

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren m_Enumerable;
                /*0x28*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x30*/ Unity.Hierarchy.HierarchyNode m_Node;
                /*0x38*/ int m_CurrentIndex;
                /*0x3c*/ int m_ChildrenIndex;
                /*0x40*/ int m_ChildrenCount;

                /*0x7ebb150*/ Enumerator(Unity.Hierarchy.HierarchyFlattenedNodeChildren enumerable, Unity.Hierarchy.HierarchyNode node);
                /*0x7ebb218*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ebb2f4*/ bool MoveNext();
            }
        }

        struct HierarchyNodeChildren
        {
            /*0x10*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x18*/ Unity.Hierarchy.HierarchyNode* m_Ptr;
            /*0x20*/ int m_Version;
            /*0x24*/ int m_Count;

            /*0x7ebb5a0*/ HierarchyNodeChildren(Unity.Hierarchy.Hierarchy hierarchy, nint nodeChildrenPtr);
            /*0x7ebb740*/ Unity.Hierarchy.HierarchyNodeChildren.Enumerator GetEnumerator();
            /*0x7ebb7a8*/ void ThrowIfVersionChanged();

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyNodeChildren m_Enumerable;
                /*0x28*/ int m_Index;

                /*0x7ebb778*/ Enumerator(ref Unity.Hierarchy.HierarchyNodeChildren enumerable);
                /*0x7ebb824*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ebb8b8*/ bool MoveNext();
            }
        }

        struct HierarchyNodeChildrenAlloc
        {
            /*0x10*/ Unity.Hierarchy.HierarchyNode* Ptr;
            /*0x18*/ int Size;
            /*0x1c*/ int Capacity;
            /*0x20*/ int RemovedCount;
            /*0x24*/ Unity.Hierarchy.HierarchyNodeChildrenAlloc.<Reserved> Reserved;

            struct <Reserved>e__FixedBuffer
            {
                /*0x10*/ int FixedElementField;
            }
        }

        class HierarchyNodeTypeHandlerBase
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, int> s_NodeTypes;
            /*0x10*/ nint m_Ptr;
            /*0x18*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x20*/ Unity.Hierarchy.HierarchyCommandList m_CommandList;

            static /*0x7ebc8a8*/ HierarchyNodeTypeHandlerBase();
            static /*0x7ebbdc4*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBase FromIntPtr(nint handlePtr);
            static /*0x7ebbec4*/ nint CreateNodeTypeHandlerFromType(nint nativePtr, System.Type handlerType, nint hierarchyPtr, nint cmdListPtr);
            static /*0x7ebc19c*/ bool TryGetStaticNodeType(System.Type handlerType, ref int nodeType);
            static /*0x7ebc314*/ void InvokeInitialize(nint handlePtr);
            static /*0x7ebc380*/ void InvokeDispose(nint handlePtr);
            static /*0x7ebc424*/ string InvokeGetNodeTypeName(nint handlePtr);
            static /*0x7ebc490*/ Unity.Hierarchy.HierarchyNodeFlags InvokeGetDefaultNodeFlags(nint handlePtr, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            static /*0x7ebc514*/ bool InvokeChangesPending(nint handlePtr);
            static /*0x7ebc580*/ bool InvokeIntegrateChanges(nint handlePtr, nint cmdListPtr);
            static /*0x7ebc610*/ bool InvokeSearchMatch(nint handlePtr, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebc68c*/ void InvokeSearchEnd(nint handlePtr);
            static /*0x7ebb9f0*/ void GetNodeTypeName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7ebbadc*/ Unity.Hierarchy.HierarchyNodeFlags GetDefaultNodeFlags_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            static /*0x7ebbbd0*/ void SearchBegin_Injected(nint _unity_self, Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            static /*0x7ebbcb4*/ bool SearchMatch_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebbd88*/ void SearchEnd_Injected(nint _unity_self);
            static /*0x7ebc788*/ bool ChangesPending_Injected(nint _unity_self);
            static /*0x7ebc864*/ bool IntegrateChanges_Injected(nint _unity_self, nint cmdList);
            /*0x7ebb8d4*/ void Initialize();
            /*0x7ebb8d8*/ void Dispose(bool disposing);
            /*0x7ebb8dc*/ string GetNodeTypeName();
            /*0x7ebba34*/ Unity.Hierarchy.HierarchyNodeFlags GetDefaultNodeFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            /*0x7ebbb30*/ void SearchBegin(Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            /*0x7ebbc14*/ bool SearchMatch(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebbcf8*/ void SearchEnd();
            /*0x7ebbeb8*/ void Internal_SearchBegin(Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            /*0x7ebc6f8*/ bool ChangesPending();
            /*0x7ebc7c4*/ bool IntegrateChanges(Unity.Hierarchy.HierarchyCommandList cmdList);

            class BindingsMarshaller
            {
                static /*0x7ebc940*/ nint ConvertToNative(Unity.Hierarchy.HierarchyNodeTypeHandlerBase handler);
            }

            struct ConstructorScope : System.IDisposable
            {
                [ThreadStatic] static nint m_Ptr;
                [ThreadStatic] static Unity.Hierarchy.Hierarchy m_Hierarchy;
                [ThreadStatic] static Unity.Hierarchy.HierarchyCommandList m_CommandList;

                static /*0x7ebc958*/ void set_Ptr(nint value);
                static /*0x7ebc9a4*/ void set_Hierarchy(Unity.Hierarchy.Hierarchy value);
                static /*0x7ebca00*/ void set_CommandList(Unity.Hierarchy.HierarchyCommandList value);
                /*0x7ebc0c4*/ ConstructorScope(nint nativePtr, Unity.Hierarchy.Hierarchy hierarchy, Unity.Hierarchy.HierarchyCommandList cmdList);
                /*0x7ebca5c*/ void Dispose();
            }
        }

        struct HierarchyNodeTypeHandlerBaseEnumerable
        {
            /*0x10*/ Unity.Hierarchy.Hierarchy m_Hierarchy;

            /*0x7ebcb20*/ HierarchyNodeTypeHandlerBaseEnumerable(Unity.Hierarchy.Hierarchy hierarchy);
            /*0x7ebcb28*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable.Enumerator GetEnumerator();

            struct Enumerator : System.IDisposable
            {
                /*0x10*/ System.Buffers.IMemoryOwner<nint> m_Handlers;
                /*0x18*/ int m_Count;
                /*0x1c*/ int m_Index;

                /*0x7ebcb50*/ Enumerator(Unity.Hierarchy.Hierarchy hierarchy);
                /*0x7ebce48*/ void Dispose();
                /*0x7ebcee8*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBase get_Current();
                /*0x7ebd008*/ bool MoveNext();
            }
        }

        struct HierarchyPropertyUnmanaged<T> : System.IEquatable<Unity.Hierarchy.HierarchyPropertyUnmanaged<T>>, Unity.Hierarchy.IHierarchyProperty<T>
        {
            /*0x0*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x0*/ Unity.Hierarchy.HierarchyPropertyId m_Property;

            /*0x380d93c*/ HierarchyPropertyUnmanaged(Unity.Hierarchy.Hierarchy hierarchy, ref Unity.Hierarchy.HierarchyPropertyId property);
            /*0x3907c14*/ void SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
            /*0x3907c14*/ T GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3907c14*/ bool Equals(Unity.Hierarchy.HierarchyPropertyUnmanaged<T> other);
            /*0x380b9e8*/ string ToString();
            /*0x380b2f0*/ bool Equals(object obj);
            /*0x380b6a0*/ int GetHashCode();
            /*0x3907c14*/ T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3907c14*/ void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
        }

        interface IHierarchySearchQueryParser
        {
        }

        class DefaultHierarchySearchQueryParser : Unity.Hierarchy.IHierarchySearchQueryParser
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex s_Filter;

            static /*0x7ebd02c*/ DefaultHierarchySearchQueryParser();
            /*0x7ebd024*/ DefaultHierarchySearchQueryParser();
        }

        struct HierarchyViewNodesEnumerable
        {
            /*0x10*/ Unity.Hierarchy.HierarchyViewModel m_HierarchyViewModel;
            /*0x18*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate m_Predicate;
            /*0x20*/ Unity.Hierarchy.HierarchyNodeFlags m_Flags;

            /*0x7ebd0cc*/ HierarchyViewNodesEnumerable(Unity.Hierarchy.HierarchyViewModel viewModel, Unity.Hierarchy.HierarchyNodeFlags flags, Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate predicate);
            /*0x7ebd180*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Enumerator GetEnumerator();

            class Predicate : System.MulticastDelegate
            {
                /*0x7ebd234*/ Predicate(object object, nint method);
                /*0x7ebd2e8*/ bool Invoke(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x18*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate m_Predicate;
                /*0x20*/ Unity.Hierarchy.HierarchyNodeFlags m_Flags;
                /*0x28*/ Unity.Hierarchy.HierarchyFlattenedNode* m_NodesPtr;
                /*0x30*/ int m_NodesCount;
                /*0x34*/ int m_Version;
                /*0x38*/ int m_Index;

                /*0x7ebd1bc*/ Enumerator(Unity.Hierarchy.HierarchyViewNodesEnumerable enumerable);
                /*0x7ebd308*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ebd388*/ bool MoveNext();
                /*0x7ebd45c*/ void ThrowIfVersionChanged();
            }
        }

        interface IHierarchyProperty<T>
        {
            /*0x3907c14*/ T GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3907c14*/ void SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
        }

        class Hierarchy : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ nint m_RootPtr;
            /*0x20*/ nint m_VersionPtr;
            /*0x28*/ bool m_IsOwner;

            static /*0x7ebdf98*/ Unity.Hierarchy.Hierarchy FromIntPtr(nint handlePtr);
            static /*0x7ebd61c*/ nint Create(nint handlePtr, ref nint rootPtr, ref nint versionPtr);
            static /*0x7ebd800*/ void Destroy(nint nativePtr);
            static /*0x7ebe550*/ nint CreateHierarchy(nint nativePtr, nint rootPtr, nint versionPtr);
            static /*0x7ebd538*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x7ebd8b4*/ bool Exists_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebd9d4*/ bool SetParent_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode parent);
            static /*0x7ebda98*/ void GetParent_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode ret);
            static /*0x7ebdc18*/ void GetChildren_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            static /*0x7ebdd50*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebddfc*/ void SetSortIndex_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, int sortIndex);
            static /*0x7ebdeb8*/ void SortChildren_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, bool recurse);
            static /*0x7ebdf5c*/ void Update_Injected(nint _unity_self);
            static /*0x7ebe070*/ int GetNodeTypeHandlersBaseCount_Injected(nint _unity_self);
            static /*0x7ebe0ac*/ int GetNodeTypeHandlersBaseSpan_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper outHandlers);
            static /*0x7ebe0f0*/ void AddNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode parent, ref Unity.Hierarchy.HierarchyNode ret);
            static /*0x7ebe144*/ nint EnumerateChildrenPtr_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebe33c*/ void GetOrCreateProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref Unity.Hierarchy.HierarchyPropertyDescriptor descriptor, ref Unity.Hierarchy.HierarchyPropertyId ret);
            static /*0x7ebe418*/ void SetPropertyRaw_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, void* ptr, int size);
            static /*0x7ebe4f4*/ void* GetPropertyRaw_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, ref int size);
            /*0x7ebd590*/ Hierarchy();
            /*0x7ebd670*/ Hierarchy(nint nativePtr, nint rootPtr, nint versionPtr);
            /*0x7ebd4cc*/ bool get_IsCreated();
            /*0x7ebd4dc*/ ref Unity.Hierarchy.HierarchyNode get_Root();
            /*0x7ebd4e8*/ bool get_UpdateNeeded();
            /*0x7ebd574*/ int get_Version();
            /*0x7ebd6b0*/ void Finalize();
            /*0x7ebd79c*/ void Dispose();
            /*0x7ebd748*/ void Dispose(bool disposing);
            /*0x7ebd83c*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase();
            /*0x7ebd85c*/ bool Exists(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebd8f8*/ Unity.Hierarchy.HierarchyNode Add(ref Unity.Hierarchy.HierarchyNode parent);
            /*0x7ebd96c*/ bool SetParent(ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode parent);
            /*0x7ebda28*/ Unity.Hierarchy.HierarchyNode GetParent(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebdaec*/ Unity.Hierarchy.HierarchyNode[] GetChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebdc6c*/ Unity.Hierarchy.HierarchyNodeChildren EnumerateChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebdcf8*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebdd94*/ void SetSortIndex(ref Unity.Hierarchy.HierarchyNode node, int sortIndex);
            /*0x7ebde50*/ void SortChildren(ref Unity.Hierarchy.HierarchyNode node, bool recurse);
            /*0x3907c14*/ Unity.Hierarchy.HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged<T>(string name, Unity.Hierarchy.HierarchyPropertyStorageType type);
            /*0x7ebdf0c*/ void Update();
            /*0x7ebcd20*/ int GetNodeTypeHandlersBaseCount();
            /*0x7ebcd70*/ int GetNodeTypeHandlersBaseSpan(System.Span<nint> outHandlers);
            /*0x7ebd8fc*/ Unity.Hierarchy.HierarchyNode AddNode(ref Unity.Hierarchy.HierarchyNode parent);
            /*0x7ebdca0*/ nint EnumerateChildrenPtr(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebe188*/ Unity.Hierarchy.HierarchyPropertyId GetOrCreateProperty(string name, ref Unity.Hierarchy.HierarchyPropertyDescriptor descriptor);
            /*0x7ebe398*/ void SetPropertyRaw(ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, void* ptr, int size);
            /*0x7ebe484*/ void* GetPropertyRaw(ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, ref int size);

            class BindingsMarshaller
            {
                static /*0x7ebe5d0*/ nint ConvertToNative(Unity.Hierarchy.Hierarchy hierarchy);
            }
        }

        class HierarchyCommandList : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_IsOwner;

            static /*0x7ebe7a0*/ Unity.Hierarchy.HierarchyCommandList FromIntPtr(nint handlePtr);
            static /*0x7ebe764*/ void Destroy(nint nativePtr);
            static /*0x7ebe878*/ nint CreateCommandList(nint nativePtr);
            /*0x7ebe5e8*/ HierarchyCommandList(nint nativePtr);
            /*0x7ebe614*/ void Finalize();
            /*0x7ebe700*/ void Dispose();
            /*0x7ebe6ac*/ void Dispose(bool disposing);

            class BindingsMarshaller
            {
                static /*0x7ebe8e4*/ nint ConvertToNative(Unity.Hierarchy.HierarchyCommandList cmdList);
            }
        }

        class HierarchyFlattened : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x20*/ nint m_NodesPtr;
            /*0x28*/ int m_NodesCount;
            /*0x2c*/ int m_Version;
            /*0x30*/ bool m_IsOwner;

            static /*0x7ebef2c*/ Unity.Hierarchy.HierarchyFlattened FromIntPtr(nint handlePtr);
            static /*0x7ebea78*/ nint Create(nint handlePtr, Unity.Hierarchy.Hierarchy hierarchy, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x7ebeca4*/ void Destroy(nint nativePtr);
            static /*0x7ebf070*/ nint CreateHierarchyFlattened(nint nativePtr, nint hierarchyPtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ebf128*/ void UpdateHierarchyFlattened(nint handlePtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ebe964*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x7ebed5c*/ int IndexOf_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebeda0*/ bool Contains_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebedfc*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ebee90*/ void Update_Injected(nint _unity_self);
            static /*0x7ebf004*/ nint Create_Injected(nint handlePtr, nint hierarchy, ref nint nodesPtr, ref int nodesCount, ref int version);
            /*0x7ebe9b0*/ HierarchyFlattened(Unity.Hierarchy.Hierarchy hierarchy);
            /*0x7ebeaf0*/ HierarchyFlattened(nint nativePtr, Unity.Hierarchy.Hierarchy hierarchy, nint nodesPtr, int nodesCount, int version);
            /*0x7ebe8fc*/ bool get_IsCreated();
            /*0x7ebe90c*/ int get_Count();
            /*0x7ebe914*/ bool get_UpdateNeeded();
            /*0x7ebe9a0*/ Unity.Hierarchy.Hierarchy get_Hierarchy();
            /*0x7ebd2fc*/ Unity.Hierarchy.HierarchyFlattenedNode* get_NodesPtr();
            /*0x7ebe9a8*/ int get_Version();
            /*0x7ebeb54*/ void Finalize();
            /*0x7ebec40*/ void Dispose();
            /*0x7ebebec*/ void Dispose(bool disposing);
            /*0x7ebece0*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Item(int index);
            /*0x7ebb4e4*/ int IndexOf(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebb020*/ bool Contains(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebede4*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren EnumerateChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebb078*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ebee40*/ void Update();
            /*0x7ebeecc*/ Unity.Hierarchy.HierarchyFlattened.Enumerator GetEnumerator();

            class BindingsMarshaller
            {
                static /*0x7ebf160*/ nint ConvertToNative(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x18*/ Unity.Hierarchy.HierarchyFlattenedNode* m_NodesPtr;
                /*0x20*/ int m_NodesCount;
                /*0x24*/ int m_Version;
                /*0x28*/ int m_Index;

                /*0x7ebeee0*/ Enumerator(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened);
                /*0x7ebf178*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Current();
                /*0x7ebf1f8*/ bool MoveNext();
            }
        }

        struct HierarchyFlattenedNode : System.IEquatable<Unity.Hierarchy.HierarchyFlattenedNode>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyFlattenedNode s_Null;
            /*0x10*/ Unity.Hierarchy.HierarchyNode m_Node;
            /*0x18*/ Unity.Hierarchy.HierarchyNodeType m_Type;
            /*0x1c*/ int m_ParentOffset;
            /*0x20*/ int m_NextSiblingOffset;
            /*0x24*/ int m_ChildrenCount;
            /*0x28*/ int m_Depth;

            static /*0x7ebb53c*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Null();
            static /*0x7ebb580*/ bool op_Equality(ref Unity.Hierarchy.HierarchyFlattenedNode lhs, ref Unity.Hierarchy.HierarchyFlattenedNode rhs);
            static /*0x7ebf4ac*/ ref Unity.Hierarchy.HierarchyNode GetNodeByRef(ref Unity.Hierarchy.HierarchyFlattenedNode hierarchyFlattenedNode);
            /*0x7ebf218*/ Unity.Hierarchy.HierarchyNode get_Node();
            /*0x7ebf220*/ int get_NextSiblingOffset();
            /*0x7ebf228*/ int get_ChildrenCount();
            /*0x7ebf230*/ bool Equals(Unity.Hierarchy.HierarchyFlattenedNode other);
            /*0x7ebf250*/ string ToString();
            /*0x7ebf394*/ bool Equals(object obj);
            /*0x7ebf418*/ int GetHashCode();
        }

        struct HierarchyNode : System.IEquatable<Unity.Hierarchy.HierarchyNode>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyNode s_Null;
            /*0x10*/ int m_Id;
            /*0x14*/ int m_Version;

            static /*0x7ebafb0*/ ref Unity.Hierarchy.HierarchyNode get_Null();
            static /*0x7ebaff4*/ bool op_Equality(ref Unity.Hierarchy.HierarchyNode lhs, ref Unity.Hierarchy.HierarchyNode rhs);
            static /*0x7ebb714*/ bool op_Inequality(ref Unity.Hierarchy.HierarchyNode lhs, ref Unity.Hierarchy.HierarchyNode rhs);
            /*0x7ebf4c0*/ HierarchyNode();
            /*0x7ebf4b0*/ int get_Id();
            /*0x7ebf4b8*/ int get_Version();
            /*0x7ebf4c8*/ bool Equals(Unity.Hierarchy.HierarchyNode other);
            /*0x7ebf4f0*/ string ToString();
            /*0x7ebf640*/ bool Equals(object obj);
            /*0x7ebf438*/ int GetHashCode();
        }

        enum HierarchyNodeFlags
        {
            None = 0,
            Expanded = 1,
            Selected = 2,
            Cut = 4,
            Hidden = 8,
        }

        struct HierarchyNodeType : System.IEquatable<Unity.Hierarchy.HierarchyNodeType>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyNodeType s_Null;
            /*0x10*/ int m_Id;

            static /*0x7ebf6c8*/ ref Unity.Hierarchy.HierarchyNodeType get_Null();
            static /*0x7ebf714*/ bool op_Equality(ref Unity.Hierarchy.HierarchyNodeType lhs, ref Unity.Hierarchy.HierarchyNodeType rhs);
            /*0x7ebf70c*/ int get_Id();
            /*0x7ebf728*/ bool Equals(Unity.Hierarchy.HierarchyNodeType other);
            /*0x7ebf738*/ string ToString();
            /*0x7ebf82c*/ bool Equals(object obj);
            /*0x7ebf8a4*/ int GetHashCode();
        }

        struct HierarchyPropertyDescriptor
        {
            /*0x10*/ int m_Size;
            /*0x14*/ Unity.Hierarchy.HierarchyPropertyStorageType m_Type;

            /*0x7ebf8c8*/ void set_Size(int value);
            /*0x7ebf8d0*/ void set_Type(Unity.Hierarchy.HierarchyPropertyStorageType value);
        }

        struct HierarchyPropertyId : System.IEquatable<Unity.Hierarchy.HierarchyPropertyId>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyPropertyId s_Null;
            /*0x10*/ int m_Id;

            static /*0x7ebf8d8*/ ref Unity.Hierarchy.HierarchyPropertyId get_Null();
            static /*0x7ebf92c*/ bool op_Equality(ref Unity.Hierarchy.HierarchyPropertyId lhs, ref Unity.Hierarchy.HierarchyPropertyId rhs);
            /*0x7ebf924*/ HierarchyPropertyId();
            /*0x7ebf91c*/ int get_Id();
            /*0x7ebf940*/ bool Equals(Unity.Hierarchy.HierarchyPropertyId other);
            /*0x7ebf950*/ string ToString();
            /*0x7ebfa44*/ bool Equals(object obj);
            /*0x7ebfabc*/ int GetHashCode();
        }

        enum HierarchyPropertyStorageType
        {
            Sparse = 0,
            Dense = 1,
            Blob = 2,
            Default = 1,
        }

        enum HierarchySearchFilterOperator
        {
            Equal = 0,
            Contains = 1,
            Greater = 2,
            GreaterOrEqual = 3,
            Lesser = 4,
            LesserOrEqual = 5,
            NotEqual = 6,
            Not = 7,
        }

        struct HierarchySearchFilter
        {
            static /*0x0*/ char[] s_WhiteSpaces;
            static /*0x8*/ Unity.Hierarchy.HierarchySearchFilter s_Invalid;
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ string <Value>k__BackingField;
            /*0x20*/ float <NumValue>k__BackingField;
            /*0x24*/ Unity.Hierarchy.HierarchySearchFilterOperator <Op>k__BackingField;

            static /*0x7ebfe9c*/ HierarchySearchFilter();
            static /*0x7ebfae0*/ ref Unity.Hierarchy.HierarchySearchFilter get_Invalid();
            static /*0x7ebfbbc*/ string ToString(Unity.Hierarchy.HierarchySearchFilterOperator op);
            static /*0x7ebfdc8*/ string QuoteStringIfNeeded(string s);
            /*0x7ebfb38*/ bool get_IsValid();
            /*0x7ebfb9c*/ string get_Name();
            /*0x7ebfba4*/ string get_Value();
            /*0x7ebfbac*/ float get_NumValue();
            /*0x7ebfbb4*/ Unity.Hierarchy.HierarchySearchFilterOperator get_Op();
            /*0x7ebfcd0*/ string ToString();
        }

        class HierarchySearchQueryDescriptor
        {
            static /*0x0*/ System.Collections.Generic.HashSet<string> s_SystemFilters;
            static /*0x8*/ Unity.Hierarchy.HierarchySearchQueryDescriptor s_Empty;
            static /*0x10*/ Unity.Hierarchy.HierarchySearchQueryDescriptor s_InvalidQuery;
            /*0x10*/ Unity.Hierarchy.HierarchySearchFilter[] <SystemFilters>k__BackingField;
            /*0x18*/ Unity.Hierarchy.HierarchySearchFilter[] <Filters>k__BackingField;
            /*0x20*/ string[] <TextValues>k__BackingField;
            /*0x28*/ bool <Strict>k__BackingField;
            /*0x29*/ bool <Invalid>k__BackingField;

            static /*0x7ec066c*/ HierarchySearchQueryDescriptor();
            static /*0x3830700*/ T[] Where<T>(System.Collections.Generic.IEnumerable<T> src, System.Func<T, bool> pred);
            /*0x7ebff84*/ HierarchySearchQueryDescriptor(Unity.Hierarchy.HierarchySearchFilter[] filters, string[] textValues);
            /*0x7ebff3c*/ Unity.Hierarchy.HierarchySearchFilter[] get_SystemFilters();
            /*0x7ebff44*/ void set_SystemFilters(Unity.Hierarchy.HierarchySearchFilter[] value);
            /*0x7ebff4c*/ Unity.Hierarchy.HierarchySearchFilter[] get_Filters();
            /*0x7ebff54*/ void set_Filters(Unity.Hierarchy.HierarchySearchFilter[] value);
            /*0x7ebff5c*/ string[] get_TextValues();
            /*0x7ebff64*/ void set_TextValues(string[] value);
            /*0x7ebff6c*/ void set_Strict(bool value);
            /*0x7ebff78*/ void set_Invalid(bool value);
            /*0x7ec033c*/ string ToString();
            /*0x7ec0478*/ string BuildFilterQuery();
            /*0x7ec04e0*/ string BuildSystemFilterQuery();
            /*0x7ec0548*/ string BuildTextQuery();
            /*0x7ec0340*/ string BuildQuery();

            class <>c
            {
                static /*0x0*/ Unity.Hierarchy.HierarchySearchQueryDescriptor.<> <>9;
                static /*0x8*/ System.Func<Unity.Hierarchy.HierarchySearchFilter, bool> <>9__33_0;
                static /*0x10*/ System.Func<Unity.Hierarchy.HierarchySearchFilter, bool> <>9__33_1;

                static /*0x7ec07fc*/ <>c();
                /*0x7ec0864*/ <>c();
                /*0x7ec086c*/ bool <.ctor>b__33_0(Unity.Hierarchy.HierarchySearchFilter f);
                /*0x7ec0924*/ bool <.ctor>b__33_1(Unity.Hierarchy.HierarchySearchFilter f);
            }
        }

        class HierarchyViewModel : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x20*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
            /*0x28*/ nint m_NodesPtr;
            /*0x30*/ int m_NodesCount;
            /*0x34*/ int m_Version;
            /*0x38*/ bool m_IsOwner;
            /*0x40*/ Unity.Hierarchy.IHierarchySearchQueryParser <QueryParser>k__BackingField;

            static /*0x7ec14e4*/ Unity.Hierarchy.HierarchyViewModel FromIntPtr(nint handlePtr);
            static /*0x7ec0c5c*/ nint Create(nint handlePtr, Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x7ec0ef4*/ void Destroy(nint nativePtr);
            static /*0x7ec173c*/ nint CreateHierarchyViewModel(nint nativePtr, nint flattenedPtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ec17e4*/ void UpdateHierarchyViewModel(nint handlePtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ec181c*/ void SearchBegin(nint handlePtr);
            static /*0x7ec0a38*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x7ec0adc*/ Unity.Hierarchy.HierarchySearchQueryDescriptor get_Query_Injected(nint _unity_self);
            static /*0x7ec1070*/ int IndexOf_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ec110c*/ bool Contains_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ec11a8*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ec1434*/ void Update_Injected(nint _unity_self);
            static /*0x7ec15bc*/ nint Create_Injected(nint handlePtr, nint hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x7ec1630*/ void SetFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            static /*0x7ec168c*/ bool HasAllFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            static /*0x7ec16e0*/ void ClearFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ec0b18*/ HierarchyViewModel(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            /*0x7ec0cdc*/ HierarchyViewModel(nint nativePtr, Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, nint nodesPtr, int nodesCount, int version);
            /*0x7ec09d0*/ bool get_IsCreated();
            /*0x7ec09e0*/ int get_Count();
            /*0x7ec09e8*/ bool get_UpdateNeeded();
            /*0x7ec0a74*/ Unity.Hierarchy.HierarchyFlattened get_HierarchyFlattened();
            /*0x7ec0a7c*/ int get_Version();
            /*0x7ec0a84*/ void set_QueryParser(Unity.Hierarchy.IHierarchySearchQueryParser value);
            /*0x7ec0a8c*/ Unity.Hierarchy.HierarchySearchQueryDescriptor get_Query();
            /*0x7ec0da4*/ void Finalize();
            /*0x7ec0e90*/ void Dispose();
            /*0x7ec0e3c*/ void Dispose(bool disposing);
            /*0x7ec0f30*/ ref Unity.Hierarchy.HierarchyNode get_Item(int index);
            /*0x7ec1018*/ int IndexOf(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ec10b4*/ bool Contains(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ec1150*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ec11ec*/ void SetFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ec1264*/ bool HasAllFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x7ec12d0*/ void ClearFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ec1348*/ Unity.Hierarchy.HierarchyViewNodesEnumerable EnumerateNodesWithAllFlags(Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x7ec13e4*/ void Update();
            /*0x7ec1470*/ Unity.Hierarchy.HierarchyViewModel.Enumerator GetEnumerator();
            /*0x7ec11f4*/ void SetFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ec1268*/ bool HasAllFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x7ec12d8*/ void ClearFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);

            class BindingsMarshaller
            {
                static /*0x7ec1940*/ nint ConvertToNative(Unity.Hierarchy.HierarchyViewModel viewModel);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyViewModel m_ViewModel;
                /*0x18*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x20*/ int* m_NodesPtr;
                /*0x28*/ int m_NodesCount;
                /*0x2c*/ int m_Version;
                /*0x30*/ int m_Index;

                /*0x7ec1488*/ Enumerator(Unity.Hierarchy.HierarchyViewModel hierarchyViewModel);
                /*0x7ec1958*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ec1a3c*/ bool MoveNext();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43;

    struct __StaticArrayInitTypeSize=6
    {
    }
}
