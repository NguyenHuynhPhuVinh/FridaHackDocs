class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7ed220c*/ EmbeddedAttribute();
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
                /*0x7ed2214*/ IsUnmanagedAttribute();
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

            /*0x7ed221c*/ HierarchyFlattenedNodeChildren(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed2500*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren.Enumerator GetEnumerator();
            /*0x7ed25d8*/ void ThrowIfVersionChanged();

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren m_Enumerable;
                /*0x28*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x30*/ Unity.Hierarchy.HierarchyNode m_Node;
                /*0x38*/ int m_CurrentIndex;
                /*0x3c*/ int m_ChildrenIndex;
                /*0x40*/ int m_ChildrenCount;

                /*0x7ed2580*/ Enumerator(Unity.Hierarchy.HierarchyFlattenedNodeChildren enumerable, Unity.Hierarchy.HierarchyNode node);
                /*0x7ed2648*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ed2724*/ bool MoveNext();
            }
        }

        struct HierarchyNodeChildren
        {
            /*0x10*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x18*/ Unity.Hierarchy.HierarchyNode* m_Ptr;
            /*0x20*/ int m_Version;
            /*0x24*/ int m_Count;

            /*0x7ed29d0*/ HierarchyNodeChildren(Unity.Hierarchy.Hierarchy hierarchy, nint nodeChildrenPtr);
            /*0x7ed2b70*/ Unity.Hierarchy.HierarchyNodeChildren.Enumerator GetEnumerator();
            /*0x7ed2bd8*/ void ThrowIfVersionChanged();

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyNodeChildren m_Enumerable;
                /*0x28*/ int m_Index;

                /*0x7ed2ba8*/ Enumerator(ref Unity.Hierarchy.HierarchyNodeChildren enumerable);
                /*0x7ed2c54*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ed2ce8*/ bool MoveNext();
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

            static /*0x7ed3cd8*/ HierarchyNodeTypeHandlerBase();
            static /*0x7ed31f4*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBase FromIntPtr(nint handlePtr);
            static /*0x7ed32f4*/ nint CreateNodeTypeHandlerFromType(nint nativePtr, System.Type handlerType, nint hierarchyPtr, nint cmdListPtr);
            static /*0x7ed35cc*/ bool TryGetStaticNodeType(System.Type handlerType, ref int nodeType);
            static /*0x7ed3744*/ void InvokeInitialize(nint handlePtr);
            static /*0x7ed37b0*/ void InvokeDispose(nint handlePtr);
            static /*0x7ed3854*/ string InvokeGetNodeTypeName(nint handlePtr);
            static /*0x7ed38c0*/ Unity.Hierarchy.HierarchyNodeFlags InvokeGetDefaultNodeFlags(nint handlePtr, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            static /*0x7ed3944*/ bool InvokeChangesPending(nint handlePtr);
            static /*0x7ed39b0*/ bool InvokeIntegrateChanges(nint handlePtr, nint cmdListPtr);
            static /*0x7ed3a40*/ bool InvokeSearchMatch(nint handlePtr, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed3abc*/ void InvokeSearchEnd(nint handlePtr);
            static /*0x7ed2e20*/ void GetNodeTypeName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7ed2f0c*/ Unity.Hierarchy.HierarchyNodeFlags GetDefaultNodeFlags_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            static /*0x7ed3000*/ void SearchBegin_Injected(nint _unity_self, Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            static /*0x7ed30e4*/ bool SearchMatch_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed31b8*/ void SearchEnd_Injected(nint _unity_self);
            static /*0x7ed3bb8*/ bool ChangesPending_Injected(nint _unity_self);
            static /*0x7ed3c94*/ bool IntegrateChanges_Injected(nint _unity_self, nint cmdList);
            /*0x7ed2d04*/ void Initialize();
            /*0x7ed2d08*/ void Dispose(bool disposing);
            /*0x7ed2d0c*/ string GetNodeTypeName();
            /*0x7ed2e64*/ Unity.Hierarchy.HierarchyNodeFlags GetDefaultNodeFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            /*0x7ed2f60*/ void SearchBegin(Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            /*0x7ed3044*/ bool SearchMatch(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed3128*/ void SearchEnd();
            /*0x7ed32e8*/ void Internal_SearchBegin(Unity.Hierarchy.HierarchySearchQueryDescriptor query);
            /*0x7ed3b28*/ bool ChangesPending();
            /*0x7ed3bf4*/ bool IntegrateChanges(Unity.Hierarchy.HierarchyCommandList cmdList);

            class BindingsMarshaller
            {
                static /*0x7ed3d70*/ nint ConvertToNative(Unity.Hierarchy.HierarchyNodeTypeHandlerBase handler);
            }

            struct ConstructorScope : System.IDisposable
            {
                [ThreadStatic] static nint m_Ptr;
                [ThreadStatic] static Unity.Hierarchy.Hierarchy m_Hierarchy;
                [ThreadStatic] static Unity.Hierarchy.HierarchyCommandList m_CommandList;

                static /*0x7ed3d88*/ void set_Ptr(nint value);
                static /*0x7ed3dd4*/ void set_Hierarchy(Unity.Hierarchy.Hierarchy value);
                static /*0x7ed3e30*/ void set_CommandList(Unity.Hierarchy.HierarchyCommandList value);
                /*0x7ed34f4*/ ConstructorScope(nint nativePtr, Unity.Hierarchy.Hierarchy hierarchy, Unity.Hierarchy.HierarchyCommandList cmdList);
                /*0x7ed3e8c*/ void Dispose();
            }
        }

        struct HierarchyNodeTypeHandlerBaseEnumerable
        {
            /*0x10*/ Unity.Hierarchy.Hierarchy m_Hierarchy;

            /*0x7ed3f50*/ HierarchyNodeTypeHandlerBaseEnumerable(Unity.Hierarchy.Hierarchy hierarchy);
            /*0x7ed3f58*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable.Enumerator GetEnumerator();

            struct Enumerator : System.IDisposable
            {
                /*0x10*/ System.Buffers.IMemoryOwner<nint> m_Handlers;
                /*0x18*/ int m_Count;
                /*0x1c*/ int m_Index;

                /*0x7ed3f80*/ Enumerator(Unity.Hierarchy.Hierarchy hierarchy);
                /*0x7ed4278*/ void Dispose();
                /*0x7ed4318*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBase get_Current();
                /*0x7ed4438*/ bool MoveNext();
            }
        }

        struct HierarchyPropertyUnmanaged<T> : System.IEquatable<Unity.Hierarchy.HierarchyPropertyUnmanaged<T>>, Unity.Hierarchy.IHierarchyProperty<T>
        {
            /*0x0*/ Unity.Hierarchy.Hierarchy m_Hierarchy;
            /*0x0*/ Unity.Hierarchy.HierarchyPropertyId m_Property;

            /*0x3816810*/ HierarchyPropertyUnmanaged(Unity.Hierarchy.Hierarchy hierarchy, ref Unity.Hierarchy.HierarchyPropertyId property);
            /*0x3910ae8*/ void SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
            /*0x3910ae8*/ T GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3910ae8*/ bool Equals(Unity.Hierarchy.HierarchyPropertyUnmanaged<T> other);
            /*0x38148bc*/ string ToString();
            /*0x38141c4*/ bool Equals(object obj);
            /*0x3814574*/ int GetHashCode();
            /*0x3910ae8*/ T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3910ae8*/ void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
        }

        interface IHierarchySearchQueryParser
        {
        }

        class DefaultHierarchySearchQueryParser : Unity.Hierarchy.IHierarchySearchQueryParser
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex s_Filter;

            static /*0x7ed445c*/ DefaultHierarchySearchQueryParser();
            /*0x7ed4454*/ DefaultHierarchySearchQueryParser();
        }

        struct HierarchyViewNodesEnumerable
        {
            /*0x10*/ Unity.Hierarchy.HierarchyViewModel m_HierarchyViewModel;
            /*0x18*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate m_Predicate;
            /*0x20*/ Unity.Hierarchy.HierarchyNodeFlags m_Flags;

            /*0x7ed44fc*/ HierarchyViewNodesEnumerable(Unity.Hierarchy.HierarchyViewModel viewModel, Unity.Hierarchy.HierarchyNodeFlags flags, Unity.Hierarchy.HierarchyViewNodesEnumerable.Predicate predicate);
            /*0x7ed45b0*/ Unity.Hierarchy.HierarchyViewNodesEnumerable.Enumerator GetEnumerator();

            class Predicate : System.MulticastDelegate
            {
                /*0x7ed4664*/ Predicate(object object, nint method);
                /*0x7ed4718*/ bool Invoke(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
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

                /*0x7ed45ec*/ Enumerator(Unity.Hierarchy.HierarchyViewNodesEnumerable enumerable);
                /*0x7ed4738*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ed47b8*/ bool MoveNext();
                /*0x7ed488c*/ void ThrowIfVersionChanged();
            }
        }

        interface IHierarchyProperty<T>
        {
            /*0x3910ae8*/ T GetValue(ref Unity.Hierarchy.HierarchyNode node);
            /*0x3910ae8*/ void SetValue(ref Unity.Hierarchy.HierarchyNode node, T value);
        }

        class Hierarchy : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ nint m_RootPtr;
            /*0x20*/ nint m_VersionPtr;
            /*0x28*/ bool m_IsOwner;

            static /*0x7ed53c8*/ Unity.Hierarchy.Hierarchy FromIntPtr(nint handlePtr);
            static /*0x7ed4a4c*/ nint Create(nint handlePtr, ref nint rootPtr, ref nint versionPtr);
            static /*0x7ed4c30*/ void Destroy(nint nativePtr);
            static /*0x7ed5980*/ nint CreateHierarchy(nint nativePtr, nint rootPtr, nint versionPtr);
            static /*0x7ed4968*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x7ed4ce4*/ bool Exists_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed4e04*/ bool SetParent_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode parent);
            static /*0x7ed4ec8*/ void GetParent_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode ret);
            static /*0x7ed5048*/ void GetChildren_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            static /*0x7ed5180*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed522c*/ void SetSortIndex_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, int sortIndex);
            static /*0x7ed52e8*/ void SortChildren_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, bool recurse);
            static /*0x7ed538c*/ void Update_Injected(nint _unity_self);
            static /*0x7ed54a0*/ int GetNodeTypeHandlersBaseCount_Injected(nint _unity_self);
            static /*0x7ed54dc*/ int GetNodeTypeHandlersBaseSpan_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper outHandlers);
            static /*0x7ed5520*/ void AddNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode parent, ref Unity.Hierarchy.HierarchyNode ret);
            static /*0x7ed5574*/ nint EnumerateChildrenPtr_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed576c*/ void GetOrCreateProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref Unity.Hierarchy.HierarchyPropertyDescriptor descriptor, ref Unity.Hierarchy.HierarchyPropertyId ret);
            static /*0x7ed5848*/ void SetPropertyRaw_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, void* ptr, int size);
            static /*0x7ed5924*/ void* GetPropertyRaw_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, ref int size);
            /*0x7ed49c0*/ Hierarchy();
            /*0x7ed4aa0*/ Hierarchy(nint nativePtr, nint rootPtr, nint versionPtr);
            /*0x7ed48fc*/ bool get_IsCreated();
            /*0x7ed490c*/ ref Unity.Hierarchy.HierarchyNode get_Root();
            /*0x7ed4918*/ bool get_UpdateNeeded();
            /*0x7ed49a4*/ int get_Version();
            /*0x7ed4ae0*/ void Finalize();
            /*0x7ed4bcc*/ void Dispose();
            /*0x7ed4b78*/ void Dispose(bool disposing);
            /*0x7ed4c6c*/ Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase();
            /*0x7ed4c8c*/ bool Exists(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed4d28*/ Unity.Hierarchy.HierarchyNode Add(ref Unity.Hierarchy.HierarchyNode parent);
            /*0x7ed4d9c*/ bool SetParent(ref Unity.Hierarchy.HierarchyNode node, ref Unity.Hierarchy.HierarchyNode parent);
            /*0x7ed4e58*/ Unity.Hierarchy.HierarchyNode GetParent(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed4f1c*/ Unity.Hierarchy.HierarchyNode[] GetChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed509c*/ Unity.Hierarchy.HierarchyNodeChildren EnumerateChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed5128*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed51c4*/ void SetSortIndex(ref Unity.Hierarchy.HierarchyNode node, int sortIndex);
            /*0x7ed5280*/ void SortChildren(ref Unity.Hierarchy.HierarchyNode node, bool recurse);
            /*0x3910ae8*/ Unity.Hierarchy.HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged<T>(string name, Unity.Hierarchy.HierarchyPropertyStorageType type);
            /*0x7ed533c*/ void Update();
            /*0x7ed4150*/ int GetNodeTypeHandlersBaseCount();
            /*0x7ed41a0*/ int GetNodeTypeHandlersBaseSpan(System.Span<nint> outHandlers);
            /*0x7ed4d2c*/ Unity.Hierarchy.HierarchyNode AddNode(ref Unity.Hierarchy.HierarchyNode parent);
            /*0x7ed50d0*/ nint EnumerateChildrenPtr(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed55b8*/ Unity.Hierarchy.HierarchyPropertyId GetOrCreateProperty(string name, ref Unity.Hierarchy.HierarchyPropertyDescriptor descriptor);
            /*0x7ed57c8*/ void SetPropertyRaw(ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, void* ptr, int size);
            /*0x7ed58b4*/ void* GetPropertyRaw(ref Unity.Hierarchy.HierarchyPropertyId property, ref Unity.Hierarchy.HierarchyNode node, ref int size);

            class BindingsMarshaller
            {
                static /*0x7ed5a00*/ nint ConvertToNative(Unity.Hierarchy.Hierarchy hierarchy);
            }
        }

        class HierarchyCommandList : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_IsOwner;

            static /*0x7ed5bd0*/ Unity.Hierarchy.HierarchyCommandList FromIntPtr(nint handlePtr);
            static /*0x7ed5b94*/ void Destroy(nint nativePtr);
            static /*0x7ed5ca8*/ nint CreateCommandList(nint nativePtr);
            /*0x7ed5a18*/ HierarchyCommandList(nint nativePtr);
            /*0x7ed5a44*/ void Finalize();
            /*0x7ed5b30*/ void Dispose();
            /*0x7ed5adc*/ void Dispose(bool disposing);

            class BindingsMarshaller
            {
                static /*0x7ed5d14*/ nint ConvertToNative(Unity.Hierarchy.HierarchyCommandList cmdList);
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

            static /*0x7ed635c*/ Unity.Hierarchy.HierarchyFlattened FromIntPtr(nint handlePtr);
            static /*0x7ed5ea8*/ nint Create(nint handlePtr, Unity.Hierarchy.Hierarchy hierarchy, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x7ed60d4*/ void Destroy(nint nativePtr);
            static /*0x7ed64a0*/ nint CreateHierarchyFlattened(nint nativePtr, nint hierarchyPtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ed6558*/ void UpdateHierarchyFlattened(nint handlePtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ed5d94*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x7ed618c*/ int IndexOf_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed61d0*/ bool Contains_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed622c*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed62c0*/ void Update_Injected(nint _unity_self);
            static /*0x7ed6434*/ nint Create_Injected(nint handlePtr, nint hierarchy, ref nint nodesPtr, ref int nodesCount, ref int version);
            /*0x7ed5de0*/ HierarchyFlattened(Unity.Hierarchy.Hierarchy hierarchy);
            /*0x7ed5f20*/ HierarchyFlattened(nint nativePtr, Unity.Hierarchy.Hierarchy hierarchy, nint nodesPtr, int nodesCount, int version);
            /*0x7ed5d2c*/ bool get_IsCreated();
            /*0x7ed5d3c*/ int get_Count();
            /*0x7ed5d44*/ bool get_UpdateNeeded();
            /*0x7ed5dd0*/ Unity.Hierarchy.Hierarchy get_Hierarchy();
            /*0x7ed472c*/ Unity.Hierarchy.HierarchyFlattenedNode* get_NodesPtr();
            /*0x7ed5dd8*/ int get_Version();
            /*0x7ed5f84*/ void Finalize();
            /*0x7ed6070*/ void Dispose();
            /*0x7ed601c*/ void Dispose(bool disposing);
            /*0x7ed6110*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Item(int index);
            /*0x7ed2914*/ int IndexOf(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed2450*/ bool Contains(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed6214*/ Unity.Hierarchy.HierarchyFlattenedNodeChildren EnumerateChildren(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed24a8*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed6270*/ void Update();
            /*0x7ed62fc*/ Unity.Hierarchy.HierarchyFlattened.Enumerator GetEnumerator();

            class BindingsMarshaller
            {
                static /*0x7ed6590*/ nint ConvertToNative(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x18*/ Unity.Hierarchy.HierarchyFlattenedNode* m_NodesPtr;
                /*0x20*/ int m_NodesCount;
                /*0x24*/ int m_Version;
                /*0x28*/ int m_Index;

                /*0x7ed6310*/ Enumerator(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened);
                /*0x7ed65a8*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Current();
                /*0x7ed6628*/ bool MoveNext();
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

            static /*0x7ed296c*/ ref Unity.Hierarchy.HierarchyFlattenedNode get_Null();
            static /*0x7ed29b0*/ bool op_Equality(ref Unity.Hierarchy.HierarchyFlattenedNode lhs, ref Unity.Hierarchy.HierarchyFlattenedNode rhs);
            static /*0x7ed68dc*/ ref Unity.Hierarchy.HierarchyNode GetNodeByRef(ref Unity.Hierarchy.HierarchyFlattenedNode hierarchyFlattenedNode);
            /*0x7ed6648*/ Unity.Hierarchy.HierarchyNode get_Node();
            /*0x7ed6650*/ int get_NextSiblingOffset();
            /*0x7ed6658*/ int get_ChildrenCount();
            /*0x7ed6660*/ bool Equals(Unity.Hierarchy.HierarchyFlattenedNode other);
            /*0x7ed6680*/ string ToString();
            /*0x7ed67c4*/ bool Equals(object obj);
            /*0x7ed6848*/ int GetHashCode();
        }

        struct HierarchyNode : System.IEquatable<Unity.Hierarchy.HierarchyNode>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyNode s_Null;
            /*0x10*/ int m_Id;
            /*0x14*/ int m_Version;

            static /*0x7ed23e0*/ ref Unity.Hierarchy.HierarchyNode get_Null();
            static /*0x7ed2424*/ bool op_Equality(ref Unity.Hierarchy.HierarchyNode lhs, ref Unity.Hierarchy.HierarchyNode rhs);
            static /*0x7ed2b44*/ bool op_Inequality(ref Unity.Hierarchy.HierarchyNode lhs, ref Unity.Hierarchy.HierarchyNode rhs);
            /*0x7ed68f0*/ HierarchyNode();
            /*0x7ed68e0*/ int get_Id();
            /*0x7ed68e8*/ int get_Version();
            /*0x7ed68f8*/ bool Equals(Unity.Hierarchy.HierarchyNode other);
            /*0x7ed6920*/ string ToString();
            /*0x7ed6a70*/ bool Equals(object obj);
            /*0x7ed6868*/ int GetHashCode();
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

            static /*0x7ed6af8*/ ref Unity.Hierarchy.HierarchyNodeType get_Null();
            static /*0x7ed6b44*/ bool op_Equality(ref Unity.Hierarchy.HierarchyNodeType lhs, ref Unity.Hierarchy.HierarchyNodeType rhs);
            /*0x7ed6b3c*/ int get_Id();
            /*0x7ed6b58*/ bool Equals(Unity.Hierarchy.HierarchyNodeType other);
            /*0x7ed6b68*/ string ToString();
            /*0x7ed6c5c*/ bool Equals(object obj);
            /*0x7ed6cd4*/ int GetHashCode();
        }

        struct HierarchyPropertyDescriptor
        {
            /*0x10*/ int m_Size;
            /*0x14*/ Unity.Hierarchy.HierarchyPropertyStorageType m_Type;

            /*0x7ed6cf8*/ void set_Size(int value);
            /*0x7ed6d00*/ void set_Type(Unity.Hierarchy.HierarchyPropertyStorageType value);
        }

        struct HierarchyPropertyId : System.IEquatable<Unity.Hierarchy.HierarchyPropertyId>
        {
            static /*0x0*/ Unity.Hierarchy.HierarchyPropertyId s_Null;
            /*0x10*/ int m_Id;

            static /*0x7ed6d08*/ ref Unity.Hierarchy.HierarchyPropertyId get_Null();
            static /*0x7ed6d5c*/ bool op_Equality(ref Unity.Hierarchy.HierarchyPropertyId lhs, ref Unity.Hierarchy.HierarchyPropertyId rhs);
            /*0x7ed6d54*/ HierarchyPropertyId();
            /*0x7ed6d4c*/ int get_Id();
            /*0x7ed6d70*/ bool Equals(Unity.Hierarchy.HierarchyPropertyId other);
            /*0x7ed6d80*/ string ToString();
            /*0x7ed6e74*/ bool Equals(object obj);
            /*0x7ed6eec*/ int GetHashCode();
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

            static /*0x7ed72cc*/ HierarchySearchFilter();
            static /*0x7ed6f10*/ ref Unity.Hierarchy.HierarchySearchFilter get_Invalid();
            static /*0x7ed6fec*/ string ToString(Unity.Hierarchy.HierarchySearchFilterOperator op);
            static /*0x7ed71f8*/ string QuoteStringIfNeeded(string s);
            /*0x7ed6f68*/ bool get_IsValid();
            /*0x7ed6fcc*/ string get_Name();
            /*0x7ed6fd4*/ string get_Value();
            /*0x7ed6fdc*/ float get_NumValue();
            /*0x7ed6fe4*/ Unity.Hierarchy.HierarchySearchFilterOperator get_Op();
            /*0x7ed7100*/ string ToString();
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

            static /*0x7ed7a9c*/ HierarchySearchQueryDescriptor();
            static /*0x38395d4*/ T[] Where<T>(System.Collections.Generic.IEnumerable<T> src, System.Func<T, bool> pred);
            /*0x7ed73b4*/ HierarchySearchQueryDescriptor(Unity.Hierarchy.HierarchySearchFilter[] filters, string[] textValues);
            /*0x7ed736c*/ Unity.Hierarchy.HierarchySearchFilter[] get_SystemFilters();
            /*0x7ed7374*/ void set_SystemFilters(Unity.Hierarchy.HierarchySearchFilter[] value);
            /*0x7ed737c*/ Unity.Hierarchy.HierarchySearchFilter[] get_Filters();
            /*0x7ed7384*/ void set_Filters(Unity.Hierarchy.HierarchySearchFilter[] value);
            /*0x7ed738c*/ string[] get_TextValues();
            /*0x7ed7394*/ void set_TextValues(string[] value);
            /*0x7ed739c*/ void set_Strict(bool value);
            /*0x7ed73a8*/ void set_Invalid(bool value);
            /*0x7ed776c*/ string ToString();
            /*0x7ed78a8*/ string BuildFilterQuery();
            /*0x7ed7910*/ string BuildSystemFilterQuery();
            /*0x7ed7978*/ string BuildTextQuery();
            /*0x7ed7770*/ string BuildQuery();

            class <>c
            {
                static /*0x0*/ Unity.Hierarchy.HierarchySearchQueryDescriptor.<> <>9;
                static /*0x8*/ System.Func<Unity.Hierarchy.HierarchySearchFilter, bool> <>9__33_0;
                static /*0x10*/ System.Func<Unity.Hierarchy.HierarchySearchFilter, bool> <>9__33_1;

                static /*0x7ed7c2c*/ <>c();
                /*0x7ed7c94*/ <>c();
                /*0x7ed7c9c*/ bool <.ctor>b__33_0(Unity.Hierarchy.HierarchySearchFilter f);
                /*0x7ed7d54*/ bool <.ctor>b__33_1(Unity.Hierarchy.HierarchySearchFilter f);
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

            static /*0x7ed8914*/ Unity.Hierarchy.HierarchyViewModel FromIntPtr(nint handlePtr);
            static /*0x7ed808c*/ nint Create(nint handlePtr, Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x7ed8324*/ void Destroy(nint nativePtr);
            static /*0x7ed8b6c*/ nint CreateHierarchyViewModel(nint nativePtr, nint flattenedPtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ed8c14*/ void UpdateHierarchyViewModel(nint handlePtr, nint nodesPtr, int nodesCount, int version);
            static /*0x7ed8c4c*/ void SearchBegin(nint handlePtr);
            static /*0x7ed7e68*/ bool get_UpdateNeeded_Injected(nint _unity_self);
            static /*0x7ed7f0c*/ Unity.Hierarchy.HierarchySearchQueryDescriptor get_Query_Injected(nint _unity_self);
            static /*0x7ed84a0*/ int IndexOf_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed853c*/ bool Contains_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed85d8*/ int GetChildrenCount_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node);
            static /*0x7ed8864*/ void Update_Injected(nint _unity_self);
            static /*0x7ed89ec*/ nint Create_Injected(nint handlePtr, nint hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags, ref nint nodesPtr, ref int nodesCount, ref int version);
            static /*0x7ed8a60*/ void SetFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            static /*0x7ed8abc*/ bool HasAllFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            static /*0x7ed8b10*/ void ClearFlagsNode_Injected(nint _unity_self, ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ed7f48*/ HierarchyViewModel(Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, Unity.Hierarchy.HierarchyNodeFlags defaultFlags);
            /*0x7ed810c*/ HierarchyViewModel(nint nativePtr, Unity.Hierarchy.HierarchyFlattened hierarchyFlattened, nint nodesPtr, int nodesCount, int version);
            /*0x7ed7e00*/ bool get_IsCreated();
            /*0x7ed7e10*/ int get_Count();
            /*0x7ed7e18*/ bool get_UpdateNeeded();
            /*0x7ed7ea4*/ Unity.Hierarchy.HierarchyFlattened get_HierarchyFlattened();
            /*0x7ed7eac*/ int get_Version();
            /*0x7ed7eb4*/ void set_QueryParser(Unity.Hierarchy.IHierarchySearchQueryParser value);
            /*0x7ed7ebc*/ Unity.Hierarchy.HierarchySearchQueryDescriptor get_Query();
            /*0x7ed81d4*/ void Finalize();
            /*0x7ed82c0*/ void Dispose();
            /*0x7ed826c*/ void Dispose(bool disposing);
            /*0x7ed8360*/ ref Unity.Hierarchy.HierarchyNode get_Item(int index);
            /*0x7ed8448*/ int IndexOf(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed84e4*/ bool Contains(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed8580*/ int GetChildrenCount(ref Unity.Hierarchy.HierarchyNode node);
            /*0x7ed861c*/ void SetFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ed8694*/ bool HasAllFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x7ed8700*/ void ClearFlags(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ed8778*/ Unity.Hierarchy.HierarchyViewNodesEnumerable EnumerateNodesWithAllFlags(Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x7ed8814*/ void Update();
            /*0x7ed88a0*/ Unity.Hierarchy.HierarchyViewModel.Enumerator GetEnumerator();
            /*0x7ed8624*/ void SetFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);
            /*0x7ed8698*/ bool HasAllFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags);
            /*0x7ed8708*/ void ClearFlagsNode(ref Unity.Hierarchy.HierarchyNode node, Unity.Hierarchy.HierarchyNodeFlags flags, bool recurse);

            class BindingsMarshaller
            {
                static /*0x7ed8d70*/ nint ConvertToNative(Unity.Hierarchy.HierarchyViewModel viewModel);
            }

            struct Enumerator
            {
                /*0x10*/ Unity.Hierarchy.HierarchyViewModel m_ViewModel;
                /*0x18*/ Unity.Hierarchy.HierarchyFlattened m_HierarchyFlattened;
                /*0x20*/ int* m_NodesPtr;
                /*0x28*/ int m_NodesCount;
                /*0x2c*/ int m_Version;
                /*0x30*/ int m_Index;

                /*0x7ed88b8*/ Enumerator(Unity.Hierarchy.HierarchyViewModel hierarchyViewModel);
                /*0x7ed8d88*/ ref Unity.Hierarchy.HierarchyNode get_Current();
                /*0x7ed8e6c*/ bool MoveNext();
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
