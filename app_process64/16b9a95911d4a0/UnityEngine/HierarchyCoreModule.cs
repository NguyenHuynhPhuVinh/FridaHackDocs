class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3e30d10*/ EmbeddedAttribute();
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
                /*0x3e30d18*/ IsUnmanagedAttribute();
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

            /*0x3e30d20*/ HierarchyFlattenedNodeChildren(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e31004*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren.Enumerator GetEnumerator();
            /*0x3e310cc*/ void ThrowIfVersionChanged();

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren m_Enumerable;
                /*0x28*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x30*/ Unity.Hierarchy.HierarchyNode m_Node;
                /*0x38*/ int m_CurrentIndex;
                /*0x3c*/ int m_ChildrenIndex;
                /*0x40*/ int m_ChildrenCount;

                /*0x3e31074*/ Enumerator(Unity.Hierarchy.HierarchyFlattenedNodeChildren enumerable, Unity.Hierarchy.HierarchyNode node);
                /*0x3e3113c*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x3e31218*/ bool MoveNext();
            }
        }

        struct HierarchyNodeChildren
        {
            /*0x10*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x18*/ Unity.Hierarchy.HierarchyNode* m_Ptr;
            /*0x20*/ int m_Version;
            /*0x24*/ int m_Count;

            /*0x3e314ac*/ HierarchyNodeChildren(Unity.Hierarchy.Hierarchy hierarchy, nint nodeChildrenPtr);
            /*0x3e31644*/ Unity.Hierarchy.HierarchyNodeChildren.Enumerator GetEnumerator();
            /*0x3e316a8*/ void ThrowIfVersionChanged();

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyNodeChildren m_Enumerable;
                /*0x28*/ int m_Index;

                /*0x3e31678*/ Enumerator(ref Unity.Hierarchy.HierarchyNodeChildren enumerable);
                /*0x3e31724*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x3e317b8*/ bool MoveNext();
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

            static /*0x3e327e8*/ HierarchyNodeTypeHandlerBase();
            static /*0x3e31cf4*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBase FromIntPtr(nint handlePtr);
            static /*0x3e31df4*/ nint CreateNodeTypeHandlerFromType(nint nativePtr, System.Type handlerType, nint hierarchyPtr, nint cmdListPtr);
            static /*0x3e320d4*/ bool TryGetStaticNodeType(System.Type handlerType, ref int nodeType);
            static /*0x3e32254*/ void InvokeInitialize(nint handlePtr);
            static /*0x3e322c0*/ void InvokeDispose(nint handlePtr);
            static /*0x3e32364*/ string InvokeGetNodeTypeName(nint handlePtr);
            static /*0x3e323d0*/ Unity.Hierarchy.HierarchyNodeFlags InvokeGetDefaultNodeFlags(nint handlePtr, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            static /*0x3e32454*/ bool InvokeChangesPending(nint handlePtr);
            static /*0x3e324c0*/ bool InvokeIntegrateChanges(nint handlePtr, nint cmdListPtr);
            static /*0x3e32550*/ bool InvokeSearchMatch(nint handlePtr, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e325cc*/ void InvokeSearchEnd(nint handlePtr);
            static /*0x3e31920*/ void GetNodeTypeName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x3e31a0c*/ Unity.Hierarchy.HierarchyNodeFlags GetDefaultNodeFlags_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            static /*0x3e31b00*/ void SearchBegin_Injected(nint _unity_self, Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            static /*0x3e31be4*/ bool SearchMatch_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e31cb8*/ void SearchEnd_Injected(nint _unity_self);
            static /*0x3e326c8*/ bool ChangesPending_Injected(nint _unity_self);
            static /*0x3e327a4*/ bool IntegrateChanges_Injected(nint _unity_self, nint cmdList);
            /*0x3e317d4*/ void Initialize();
            /*0x3e317d8*/ void Dispose(bool disposing);
            /*0x3e317dc*/ string GetNodeTypeName();
            /*0x3e31964*/ Unity.Hierarchy.HierarchyNodeFlags GetDefaultNodeFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            /*0x3e31a60*/ void SearchBegin(Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            /*0x3e31b44*/ bool SearchMatch(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e31c28*/ void SearchEnd();
            /*0x3e31de8*/ void Internal_SearchBegin(Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            /*0x3e32638*/ bool ChangesPending();
            /*0x3e32704*/ bool IntegrateChanges(Unity.Hierarchy.HierarchyCommandList cmdList);

            class BindingsMarshaller
            {
                static /*0x3e32880*/ nint ConvertToNative(Unity.Hierarchy.HierarchyNodeTypeHandlerBase handler);
            }

            struct ConstructorScope : System.IDisposable
            {
                [ThreadStatic] static nint m_Ptr;
                [ThreadStatic] static Unity.Hierarchy.Hierarchy m_Hierarchy;
                [ThreadStatic] static Unity.Hierarchy.HierarchyCommandList m_CommandList;

                static /*0x3e32894*/ void set_Ptr(nint value);
                static /*0x3e328e0*/ void set_Hierarchy(Unity.Hierarchy.Hierarchy value);
                static /*0x3e32940*/ void set_CommandList(Unity.Hierarchy.HierarchyCommandList value);
                /*0x3e31ff4*/ ConstructorScope(nint nativePtr, Unity.Hierarchy.Hierarchy hierarchy, Unity.Hierarchy.HierarchyCommandList cmdList);
                /*0x3e329a0*/ void Dispose();
            }
        }

        struct HierarchyNodeTypeHandlerBaseEnumerable
        {
            /*0x10*/ Unity.Hierarchy.Hierarchy m_Hierarchy;

            /*0x3e32a6c*/ HierarchyNodeTypeHandlerBaseEnumerable(Unity.Hierarchy.Hierarchy hierarchy);
            /*0x3e32a74*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable.Enumerator GetEnumerator();

            struct Enumerator : System.IDisposable
            {
                /*0x10*/ System.Buffers.IMemoryOwner<nint> m_Handlers;
                /*0x18*/ int m_Count;
                /*0x1c*/ int m_Index;

                /*0x3e32a9c*/ Enumerator(Unity.Hierarchy.Hierarchy hierarchy);
                /*0x3e32da4*/ void Dispose();
                /*0x3e32e44*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBase get_Current();
                /*0x3e32f64*/ bool MoveNext();
            }
        }

        struct HierarchyPropertyUnmanaged<T> : System.IEquatable<Unity.Hierarchy.HierarchyPropertyUnmanaged<T>>, Unity.Hierarchy.IHierarchyProperty<T>
        {
            /*0x0*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x0*/ Unity.Hierarchy.HierarchyPropertyId m_Property;

            /*0x1f30ff0*/ HierarchyPropertyUnmanaged(Unity.Hierarchy.Hierarchy hierarchy, ref Unity.Hierarchy.HierarchyPropertyId property);
            /*0x1ffc854*/ void SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
            /*0x1ffc854*/ T GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x1ffc854*/ bool Equals(Unity.Hierarchy.HierarchyPropertyUnmanaged<T> other);
            /*0x1f30214*/ string ToString();
            /*0x1f2fec8*/ bool Equals(object obj);
            /*0x1f2ffc8*/ int GetHashCode();
            /*0x1ffc854*/ T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x1ffc854*/ void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
        }

        interface IHierarchySearchQueryParser
        {
        }

        class DefaultHierarchySearchQueryParser : Unity.Hierarchy.IHierarchySearchQueryParser
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex s_Filter;

            static /*0x3e32f88*/ DefaultHierarchySearchQueryParser();
            /*0x3e32f80*/ DefaultHierarchySearchQueryParser();
        }

        struct HierarchyViewNodesEnumerable
        {
            /*0x10*/ Unity.Hierarchy.HierarchyViewModel m_HierarchyViewModel;
            /*0x18*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate m_Predicate;
            /*0x20*/ Unity.Hierarchy.HierarchyNodeFlags m_Flags;

            /*0x3e33028*/ HierarchyViewNodesEnumerable(Unity.Hierarchy.HierarchyViewModel viewModel, Unity.Hierarchy.HierarchyNodeFlags flags, Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate predicate);
            /*0x3e330d4*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Enumerator GetEnumerator();

            class Predicate : System.MulticastDelegate
            {
                /*0x3e33188*/ Predicate(object object, nint method);
                /*0x3e3323c*/ bool Invoke(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
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

                /*0x3e33110*/ Enumerator(Unity.Hierarchy.HierarchyViewNodesEnumerable enumerable);
                /*0x3e3325c*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x3e332e0*/ bool MoveNext();
                /*0x3e333b4*/ void ThrowIfVersionChanged();
            }
        }

        interface IHierarchyProperty<T>
        {
            /*0x1ffc854*/ T GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x1ffc854*/ void SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
        }

        class Hierarchy : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ nint m_RootPtr;
            /*0x20*/ nint m_VersionPtr;
            /*0x28*/ bool m_IsOwner;

            static /*0x3e33f00*/ Unity.Hierarchy.Hierarchy FromIntPtr(nint handlePtr);
            static /*0x3e33570*/ nint Create(nint handlePtr, ref nint rootPtr, ref nint versionPtr);
            static /*0x3e33744*/ void Destroy(nint nativePtr);
            static /*0x3e344b4*/ nint CreateHierarchy(nint nativePtr, nint rootPtr, nint versionPtr);
            static /*0x3e33490*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x3e337f4*/ bool Exists_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e33914*/ bool SetParent_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode parent);
            static /*0x3e339d8*/ void GetParent_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode ret);
            static /*0x3e33b80*/ void GetChildren_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            static /*0x3e33cb8*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e33d64*/ void SetSortIndex_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, int sortIndex);
            static /*0x3e33e20*/ void SortChildren_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, bool recurse);
            static /*0x3e33ec4*/ void Update_Injected(nint _unity_self);
            static /*0x3e33fd8*/ int GetNodeTypeHandlersBaseCount_Injected(nint _unity_self);
            static /*0x3e34014*/ int GetNodeTypeHandlersBaseSpan_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper outHandlers);
            static /*0x3e34058*/ void AddNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode parent, ref Unity.Hierarchy.HierarchyNode ret);
            static /*0x3e340ac*/ nint EnumerateChildrenPtr_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e342a0*/ void GetOrCreateProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref Unity.Hierarchy.HierarchyPropertyDescriptor descriptor, ref Unity.Hierarchy.HierarchyPropertyId ret);
            static /*0x3e3437c*/ void SetPropertyRaw_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, void* ptr, int size);
            static /*0x3e34458*/ void* GetPropertyRaw_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, ref int size);
            /*0x3e334e8*/ Hierarchy();
            /*0x3e335c4*/ Hierarchy(nint nativePtr, nint rootPtr, nint versionPtr);
            /*0x3e33424*/ bool get_IsCreated();
            /*0x3e33434*/ ref Unity.Hierarchy.HierarchyNode get_Root();
            /*0x3e33440*/ bool get_UpdateNeeded();
            /*0x3e334cc*/ int get_Version();
            /*0x3e33604*/ void Finalize();
            /*0x3e336e0*/ void Dispose();
            /*0x3e3368c*/ void Dispose(bool disposing);
            /*0x3e33780*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase();
            /*0x3e3379c*/ bool Exists(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e33838*/ Unity.Hierarchy.HierarchyNode Add(ref Unity.Hierarchy.HierarchyNode parent);
            /*0x3e338ac*/ bool SetParent(ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode parent);
            /*0x3e33968*/ Unity.Hierarchy.HierarchyNode GetParent(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e33a2c*/ Unity.Hierarchy.HierarchyNode[] GetChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e33bd4*/ Unity.Hierarchy.HierarchyNodeChildren EnumerateChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e33c60*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e33cfc*/ void SetSortIndex(ref Unity.Hierarchy.HierarchyNode node, int sortIndex);
            /*0x3e33db8*/ void SortChildren(ref Unity.Hierarchy.HierarchyNode node, bool recurse);
            /*0x1ffc854*/ Unity.Hierarchy.HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged<T>(string name, Unity.Hierarchy.HierarchyPropertyStorageType type);
            /*0x3e33e74*/ void Update();
            /*0x3e32c7c*/ int GetNodeTypeHandlersBaseCount();
            /*0x3e32ccc*/ int GetNodeTypeHandlersBaseSpan(System.Span<nint> outHandlers);
            /*0x3e3383c*/ Unity.Hierarchy.HierarchyNode AddNode(ref Unity.Hierarchy.HierarchyNode parent);
            /*0x3e33c08*/ nint EnumerateChildrenPtr(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e340f0*/ Unity.Hierarchy.HierarchyPropertyId GetOrCreateProperty(string name, ref Unity.Hierarchy.HierarchyPropertyDescriptor descriptor);
            /*0x3e342fc*/ void SetPropertyRaw(ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, void* ptr, int size);
            /*0x3e343e8*/ void* GetPropertyRaw(ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, ref int size);

            class BindingsMarshaller
            {
                static /*0x3e34534*/ nint ConvertToNative(Unity.Hierarchy.Hierarchy hierarchy);
            }
        }

        class HierarchyCommandList : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_IsOwner;

            static /*0x3e346f0*/ Unity.Hierarchy.HierarchyCommandList FromIntPtr(nint handlePtr);
            static /*0x3e346b4*/ void Destroy(nint nativePtr);
            static /*0x3e347c8*/ nint CreateCommandList(nint nativePtr);
            /*0x3e34548*/ HierarchyCommandList(nint nativePtr);
            /*0x3e34574*/ void Finalize();
            /*0x3e34650*/ void Dispose();
            /*0x3e345fc*/ void Dispose(bool disposing);

            class BindingsMarshaller
            {
                static /*0x3e34834*/ nint ConvertToNative(Unity.Hierarchy.HierarchyCommandList cmdList);
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

            static /*0x3e34e64*/ Unity.Hierarchy.HierarchyFlattened FromIntPtr(nint handlePtr);
            static /*0x3e349c0*/ nint Create(nint handlePtr, Unity.Hierarchy.Hierarchy hierarchy, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x3e34bdc*/ void Destroy(nint nativePtr);
            static /*0x3e34fa8*/ nint CreateHierarchyFlattened(nint nativePtr, nint hierarchyPtr, nint nodesPtr, int nodesCount, int version);
            static /*0x3e35060*/ void UpdateHierarchyFlattened(nint handlePtr, nint nodesPtr, int nodesCount, int version);
            static /*0x3e348b0*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x3e34c94*/ int IndexOf_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e34cd8*/ bool Contains_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e34d34*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e34dc8*/ void Update_Injected(nint _unity_self);
            static /*0x3e34f3c*/ nint Create_Injected(nint handlePtr, nint hierarchy, ref nint nodesPtr, ref int nodesCount, ref int version);
            /*0x3e348fc*/ HierarchyFlattened(Unity.Hierarchy.Hierarchy hierarchy);
            /*0x3e34a38*/ HierarchyFlattened(nint nativePtr, Unity.Hierarchy.Hierarchy hierarchy, nint nodesPtr, int nodesCount, int version);
            /*0x3e34848*/ bool get_IsCreated();
            /*0x3e34858*/ int get_Count();
            /*0x3e34860*/ bool get_UpdateNeeded();
            /*0x3e348ec*/ Unity.Hierarchy.Hierarchy get_Hierarchy();
            /*0x3e33250*/ Unity.Hierarchy.HierarchyFlattenedNode* get_NodesPtr();
            /*0x3e348f4*/ int get_Version();
            /*0x3e34a9c*/ void Finalize();
            /*0x3e34b78*/ void Dispose();
            /*0x3e34b24*/ void Dispose(bool disposing);
            /*0x3e34c18*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Item(int index);
            /*0x3e313fc*/ int IndexOf(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e30f54*/ bool Contains(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e34d1c*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren EnumerateChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e30fac*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e34d78*/ void Update();
            /*0x3e34e04*/ Unity.Hierarchy.HierarchyFlattened.Enumerator GetEnumerator();

            class BindingsMarshaller
            {
                static /*0x3e35098*/ nint ConvertToNative(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x18*/ Unity.Hierarchy.HierarchyFlattenedNode* m_NodesPtr;
                /*0x20*/ int m_NodesCount;
                /*0x24*/ int m_Version;
                /*0x28*/ int m_Index;

                /*0x3e34e18*/ Enumerator(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened);
                /*0x3e350ac*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Current();
                /*0x3e35130*/ bool MoveNext();
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

            static /*0x3e31454*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Null();
            static /*0x3e31498*/ bool op_Equality(ref Unity.Hierarchy.HierarchyFlattenedNode lhs, ref Unity.Hierarchy.HierarchyFlattenedNode rhs);
            static /*0x3e353c4*/ ref Unity.Hierarchy.HierarchyNode GetNodeByRef(ref Unity.Hierarchy.HierarchyFlattenedNode hierarchyFlattenedNode);
            /*0x3e35150*/ Unity.Hierarchy.HierarchyNode get_Node();
            /*0x3e35158*/ int get_NextSiblingOffset();
            /*0x3e35160*/ int get_ChildrenCount();
            /*0x3e35168*/ bool Equals(Unity.Hierarchy.HierarchyFlattenedNode other);
            /*0x3e3517c*/ string ToString();
            /*0x3e352b0*/ bool Equals(object obj);
            /*0x3e35328*/ int GetHashCode();
        }

        struct HierarchyNode : System.IEquatable<Unity.Hierarchy.HierarchyNode>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyNode s_Null;
            /*0x10*/ int m_Id;
            /*0x14*/ int m_Version;

            static /*0x3e30ee4*/ ref Unity.Hierarchy.HierarchyNode get_Null();
            static /*0x3e30f28*/ bool op_Equality(ref Unity.Hierarchy.HierarchyNode lhs, ref Unity.Hierarchy.HierarchyNode rhs);
            static /*0x3e31618*/ bool op_Inequality(ref Unity.Hierarchy.HierarchyNode lhs, ref Unity.Hierarchy.HierarchyNode rhs);
            /*0x3e353d8*/ HierarchyNode();
            /*0x3e353c8*/ int get_Id();
            /*0x3e353d0*/ int get_Version();
            /*0x3e353e0*/ bool Equals(Unity.Hierarchy.HierarchyNode other);
            /*0x3e35408*/ string ToString();
            /*0x3e35550*/ bool Equals(object obj);
            /*0x3e35340*/ int GetHashCode();
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

            static /*0x3e355d8*/ ref Unity.Hierarchy.HierarchyNodeType get_Null();
            static /*0x3e35624*/ bool op_Equality(ref Unity.Hierarchy.HierarchyNodeType lhs, ref Unity.Hierarchy.HierarchyNodeType rhs);
            /*0x3e3561c*/ int get_Id();
            /*0x3e35638*/ bool Equals(Unity.Hierarchy.HierarchyNodeType other);
            /*0x3e35648*/ string ToString();
            /*0x3e3573c*/ bool Equals(object obj);
            /*0x3e357b4*/ int GetHashCode();
        }

        struct HierarchyPropertyDescriptor
        {
            /*0x10*/ int m_Size;
            /*0x14*/ Unity.Hierarchy.HierarchyPropertyStorageType m_Type;

            /*0x3e357d4*/ void set_Size(int value);
            /*0x3e357dc*/ void set_Type(Unity.Hierarchy.HierarchyPropertyStorageType value);
        }

        struct HierarchyPropertyId : System.IEquatable<Unity.Hierarchy.HierarchyPropertyId>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyPropertyId s_Null;
            /*0x10*/ int m_Id;

            static /*0x3e357e4*/ ref Unity.Hierarchy.HierarchyPropertyId get_Null();
            static /*0x3e35838*/ bool op_Equality(ref Unity.Hierarchy.HierarchyPropertyId lhs, ref Unity.Hierarchy.HierarchyPropertyId rhs);
            /*0x3e35830*/ HierarchyPropertyId();
            /*0x3e35828*/ int get_Id();
            /*0x3e3584c*/ bool Equals(Unity.Hierarchy.HierarchyPropertyId other);
            /*0x3e3585c*/ string ToString();
            /*0x3e35950*/ bool Equals(object obj);
            /*0x3e359c8*/ int GetHashCode();
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

            static /*0x3e35d94*/ HierarchySearchFilter();
            static /*0x3e359e8*/ ref Unity.Hierarchy.HierarchySearchFilter get_Invalid();
            static /*0x3e35ac4*/ string ToString(Unity.Hierarchy.HierarchySearchFilterOperator op);
            static /*0x3e35cc0*/ string QuoteStringIfNeeded(string s);
            /*0x3e35a40*/ bool get_IsValid();
            /*0x3e35aa4*/ string get_Name();
            /*0x3e35aac*/ string get_Value();
            /*0x3e35ab4*/ float get_NumValue();
            /*0x3e35abc*/ Unity.Hierarchy.HierarchySearchFilterOperator get_Op();
            /*0x3e35bd8*/ string ToString();
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

            static /*0x3e3655c*/ HierarchySearchQueryDescriptor();
            static /*0x1f32888*/ T[] Where<T>(System.Collections.Generic.IEnumerable<T> src, System.Func<T, bool> pred);
            /*0x3e35e74*/ HierarchySearchQueryDescriptor(Unity.Hierarchy.HierarchySearchFilter[] filters, string[] textValues);
            /*0x3e35e34*/ Unity.Hierarchy.HierarchySearchFilter[] get_SystemFilters();
            /*0x3e35e3c*/ void set_SystemFilters(Unity.Hierarchy.HierarchySearchFilter[] value);
            /*0x3e35e44*/ Unity.Hierarchy.HierarchySearchFilter[] get_Filters();
            /*0x3e35e4c*/ void set_Filters(Unity.Hierarchy.HierarchySearchFilter[] value);
            /*0x3e35e54*/ string[] get_TextValues();
            /*0x3e35e5c*/ void set_TextValues(string[] value);
            /*0x3e35e64*/ void set_Strict(bool value);
            /*0x3e35e6c*/ void set_Invalid(bool value);
            /*0x3e3622c*/ string ToString();
            /*0x3e36368*/ string BuildFilterQuery();
            /*0x3e363d0*/ string BuildSystemFilterQuery();
            /*0x3e36438*/ string BuildTextQuery();
            /*0x3e36230*/ string BuildQuery();

            class <>c
            {
                static /*0x0*/ Unity.Hierarchy.HierarchySearchQueryDescriptor.<> <>9;
                static /*0x8*/ System.Func<Unity.Hierarchy.HierarchySearchFilter, bool> <>9__33_0;
                static /*0x10*/ System.Func<Unity.Hierarchy.HierarchySearchFilter, bool> <>9__33_1;

                static /*0x3e366ec*/ <>c();
                /*0x3e36754*/ <>c();
                /*0x3e3675c*/ bool <.ctor>b__33_0(Unity.Hierarchy.HierarchySearchFilter f);
                /*0x3e36814*/ bool <.ctor>b__33_1(Unity.Hierarchy.HierarchySearchFilter f);
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

            static /*0x3e37414*/ Unity.Hierarchy.HierarchyViewModel FromIntPtr(nint handlePtr);
            static /*0x3e36b48*/ nint Create(nint handlePtr, Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x3e36dd0*/ void Destroy(nint nativePtr);
            static /*0x3e376b0*/ nint CreateHierarchyViewModel(nint nativePtr, nint flattenedPtr, nint nodesPtr, int nodesCount, int version);
            static /*0x3e37758*/ void UpdateHierarchyViewModel(nint handlePtr, nint nodesPtr, int nodesCount, int version);
            static /*0x3e37790*/ void SearchBegin(nint handlePtr);
            static /*0x3e36928*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x3e369cc*/ Unity.Hierarchy.HierarchySearchQueryDescriptor get_Query_Injected(nint _unity_self);
            static /*0x3e36f4c*/ int IndexOf_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e36fe8*/ bool Contains_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e37084*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x3e37364*/ void Update_Injected(nint _unity_self);
            static /*0x3e374ec*/ nint Create_Injected(nint handlePtr, nint hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x3e37560*/ void SetFlagsAll_Injected(nint _unity_self, Unity.Hierarchy.HierarchyNodeFlags flags);
            static /*0x3e375a4*/ void SetFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            static /*0x3e37600*/ bool HasAllFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            static /*0x3e37654*/ void ClearFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x3e36a08*/ HierarchyViewModel(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            /*0x3e36bc8*/ HierarchyViewModel(nint nativePtr, Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, nint nodesPtr, int nodesCount, int version);
            /*0x3e368c0*/ bool get_IsCreated();
            /*0x3e368d0*/ int get_Count();
            /*0x3e368d8*/ bool get_UpdateNeeded();
            /*0x3e36964*/ Unity.Hierarchy.HierarchyFlattened get_HierarchyFlattened();
            /*0x3e3696c*/ int get_Version();
            /*0x3e36974*/ void set_QueryParser(Unity.Hierarchy.IHierarchySearchQueryParser value);
            /*0x3e3697c*/ Unity.Hierarchy.HierarchySearchQueryDescriptor get_Query();
            /*0x3e36c90*/ void Finalize();
            /*0x3e36d6c*/ void Dispose();
            /*0x3e36d18*/ void Dispose(bool disposing);
            /*0x3e36e0c*/ ref Unity.Hierarchy.HierarchyNode get_Item(int index);
            /*0x3e36ef4*/ int IndexOf(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e36f90*/ bool Contains(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e3702c*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3e370c8*/ void SetFlags(Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x3e37124*/ void SetFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x3e37198*/ bool HasAllFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x3e37204*/ void ClearFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x3e37278*/ Unity.Hierarchy.HierarchyViewNodesEnumerable EnumerateNodesWithAllFlags(Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x3e37314*/ void Update();
            /*0x3e373a0*/ Unity.Hierarchy.HierarchyViewModel.Enumerator GetEnumerator();
            /*0x3e370cc*/ void SetFlagsAll(Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x3e37128*/ void SetFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x3e3719c*/ bool HasAllFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x3e37208*/ void ClearFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);

            class BindingsMarshaller
            {
                static /*0x3e378a0*/ nint ConvertToNative(Unity.Hierarchy.HierarchyViewModel viewModel);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyViewModel m_ViewModel;
                /*0x18*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x20*/ int* m_NodesPtr;
                /*0x28*/ int m_NodesCount;
                /*0x2c*/ int m_Version;
                /*0x30*/ int m_Index;

                /*0x3e373b8*/ Enumerator(Unity.Hierarchy.HierarchyViewModel hierarchyViewModel);
                /*0x3e378b4*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x3e37998*/ bool MoveNext();
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
