class <Module>
{
}

namespace UnityEngine
{
    namespace Accessibility
    {
        class AccessibilityAction : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ System.Func<bool> <activated>k__BackingField;

            static /*0x7dbf1c4*/ void Internal_Destroy(nint ptr);
            /*0x7dbf0e4*/ void Dispose();
            /*0x7dbf178*/ void Dispose(bool disposing);
            /*0x7dbf200*/ System.Func<bool> get_activated();
            /*0x7dbf208*/ bool Internal_InvokeActivated();
        }

        class AccessibilityManager
        {
            static /*0x0*/ System.Collections.Generic.Queue<UnityEngine.Accessibility.AccessibilityManager.NotificationContext> s_AsyncNotificationContexts;
            static /*0x8*/ System.Action<bool> screenReaderStatusChanged;
            static /*0x10*/ System.Action<UnityEngine.Accessibility.AccessibilityNode> nodeFocusChanged;

            static /*0x7dc0a08*/ AccessibilityManager();
            static /*0x7dbf228*/ void add_screenReaderStatusChanged(System.Action<bool> value);
            static /*0x7dbf31c*/ void remove_screenReaderStatusChanged(System.Action<bool> value);
            static /*0x7dbf410*/ void add_nodeFocusChanged(System.Action<UnityEngine.Accessibility.AccessibilityNode> value);
            static /*0x7dbf504*/ void remove_nodeFocusChanged(System.Action<UnityEngine.Accessibility.AccessibilityNode> value);
            static /*0x7dbf5f8*/ bool IsScreenReaderEnabled();
            static /*0x7dbf620*/ void SendAccessibilityNotification(ref UnityEngine.Accessibility.AccessibilityNotificationContext context);
            static /*0x7dbf65c*/ void Internal_Initialize();
            static /*0x7dbf860*/ void Internal_Update();
            static /*0x7dbff5c*/ int[] Internal_GetRootNodeIds();
            static /*0x7dc0228*/ bool Internal_GetNode(int id, ref UnityEngine.Accessibility.AccessibilityNodeData nodeData);
            static /*0x7dc04e8*/ int Internal_GetNodeIdAt(float x, float y);
            static /*0x7dc0630*/ void Internal_OnAccessibilityNotificationReceived(ref UnityEngine.Accessibility.AccessibilityNotificationContext context);
            static /*0x7dc07d8*/ void QueueNotification(UnityEngine.Accessibility.AccessibilityManager.NotificationContext notification);
            static /*0x7dbfd94*/ System.IDisposable GetExclusiveLock();
            static /*0x7dc09b8*/ void Lock();
            static /*0x7dc09e0*/ void Unlock();

            struct NotificationContext
            {
                /*0x10*/ UnityEngine.Accessibility.AccessibilityNotification <notification>k__BackingField;
                /*0x14*/ bool <isScreenReaderEnabled>k__BackingField;
                /*0x18*/ string <announcement>k__BackingField;
                /*0x20*/ bool <wasAnnouncementSuccessful>k__BackingField;
                /*0x28*/ UnityEngine.Accessibility.AccessibilityNode <currentNode>k__BackingField;
                /*0x30*/ UnityEngine.Accessibility.AccessibilityNode <nextNode>k__BackingField;
                /*0x38*/ float <fontScale>k__BackingField;
                /*0x3c*/ bool <isBoldTextEnabled>k__BackingField;
                /*0x3d*/ bool <isClosedCaptioningEnabled>k__BackingField;
                /*0x40*/ UnityEngine.Accessibility.AccessibilityNotificationContext <nativeContext>k__BackingField;

                /*0x7dc06c8*/ NotificationContext(ref UnityEngine.Accessibility.AccessibilityNotificationContext nativeNotification);
                /*0x7dc0aa0*/ UnityEngine.Accessibility.AccessibilityNotification get_notification();
                /*0x7dc0aa8*/ void set_notification(UnityEngine.Accessibility.AccessibilityNotification value);
                /*0x7dc0ab0*/ bool get_isScreenReaderEnabled();
                /*0x7dc0ab8*/ void set_isScreenReaderEnabled(bool value);
                /*0x7dc0ac4*/ void set_announcement(string value);
                /*0x7dc0acc*/ void set_wasAnnouncementSuccessful(bool value);
                /*0x7dc0ad8*/ UnityEngine.Accessibility.AccessibilityNode get_currentNode();
                /*0x7dc0ae0*/ void set_currentNode(UnityEngine.Accessibility.AccessibilityNode value);
                /*0x7dc0ae8*/ void set_nextNode(UnityEngine.Accessibility.AccessibilityNode value);
                /*0x7dc0af0*/ float get_fontScale();
                /*0x7dc0af8*/ void set_fontScale(float value);
                /*0x7dc0b00*/ bool get_isBoldTextEnabled();
                /*0x7dc0b08*/ void set_isBoldTextEnabled(bool value);
                /*0x7dc0b14*/ bool get_isClosedCaptioningEnabled();
                /*0x7dc0b1c*/ void set_isClosedCaptioningEnabled(bool value);
                /*0x7dc0b28*/ void set_nativeContext(UnityEngine.Accessibility.AccessibilityNotificationContext value);
            }

            class ExclusiveLock : System.IDisposable
            {
                /*0x10*/ bool m_Disposed;

                /*0x7dc0940*/ ExclusiveLock();
                /*0x7dc0c6c*/ void Finalize();
                /*0x7dc0d00*/ void InternalDispose();
                /*0x7dc0d80*/ void Dispose();
            }
        }

        enum AccessibilityRole
        {
            None = 0,
            Button = 1,
            Image = 2,
            StaticText = 4,
            SearchField = 8,
            KeyboardKey = 16,
            Header = 32,
            TabBar = 64,
            Slider = 128,
            Toggle = 256,
        }

        enum AccessibilityState
        {
            None = 0,
            Disabled = 1,
            Selected = 2,
        }

        struct AccessibilityNodeData
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x14*/ bool <isActive>k__BackingField;
            /*0x18*/ string <label>k__BackingField;
            /*0x20*/ string <value>k__BackingField;
            /*0x28*/ string <hint>k__BackingField;
            /*0x30*/ UnityEngine.Accessibility.AccessibilityRole <role>k__BackingField;
            /*0x32*/ bool <allowsDirectInteraction>k__BackingField;
            /*0x34*/ UnityEngine.Accessibility.AccessibilityState <state>k__BackingField;
            /*0x38*/ UnityEngine.Rect <frame>k__BackingField;
            /*0x48*/ int <parentId>k__BackingField;
            /*0x50*/ int[] <childIds>k__BackingField;
            /*0x58*/ bool <isFocused>k__BackingField;
            /*0x5c*/ UnityEngine.SystemLanguage <language>k__BackingField;
            /*0x60*/ bool <implementsSelected>k__BackingField;
            /*0x61*/ bool <implementsDismissed>k__BackingField;

            /*0x7dc0de0*/ void set_id(int value);
            /*0x7dc0de8*/ void set_isActive(bool value);
            /*0x7dc0df4*/ void set_label(string value);
            /*0x7dc0dfc*/ void set_value(string value);
            /*0x7dc0e04*/ void set_hint(string value);
            /*0x7dc0e0c*/ void set_role(UnityEngine.Accessibility.AccessibilityRole value);
            /*0x7dc0e14*/ void set_allowsDirectInteraction(bool value);
            /*0x7dc0e20*/ void set_state(UnityEngine.Accessibility.AccessibilityState value);
            /*0x7dc0e28*/ void set_frame(UnityEngine.Rect value);
            /*0x7dc0e34*/ void set_parentId(int value);
            /*0x7dc0e3c*/ void set_childIds(int[] value);
            /*0x7dc0e44*/ void set_language(UnityEngine.SystemLanguage value);
            /*0x7dc0e4c*/ void set_implementsSelected(bool value);
            /*0x7dc0e58*/ void set_implementsDismissed(bool value);
        }

        class AccessibilityNodeManager
        {
            static /*0x7dc0e64*/ void DestroyNativeNode(int id, int parentId);
            static /*0x7dc0ea8*/ void SetFrame(int id, UnityEngine.Rect frame);
            static /*0x7dc0f40*/ void SetChildren(int id, int[] childIds);
            static /*0x7dc1058*/ void SetActions(int id, UnityEngine.Accessibility.AccessibilityAction[] actions);
            static /*0x7dc109c*/ void Internal_InvokeFocusChanged(int id, bool isNodeFocused);
            static /*0x7dc1200*/ bool Internal_InvokeSelected(int id);
            static /*0x7dc12dc*/ void Internal_InvokeIncremented(int id);
            static /*0x7dc13a8*/ void Internal_InvokeDecremented(int id);
            static /*0x7dc1474*/ bool Internal_InvokeDismissed(int id);
            static /*0x7dc0efc*/ void SetFrame_Injected(int id, ref UnityEngine.Rect frame);
            static /*0x7dc1014*/ void SetChildren_Injected(int id, ref UnityEngine.Bindings.ManagedSpanWrapper childIds);
        }

        enum AccessibilityNotification
        {
            None = 0,
            Announcement = 1,
            AnnouncementFinished = 2,
            ScreenReaderStatusChanged = 3,
            ScreenChanged = 4,
            LayoutChanged = 5,
            PageScrolled = 6,
            ElementFocused = 7,
            ElementUnfocused = 8,
            FontScaleChanged = 9,
            BoldTextStatusChanged = 10,
            ClosedCaptioningStatusChanged = 11,
        }

        struct AccessibilityNotificationContext
        {
            /*0x10*/ UnityEngine.Accessibility.AccessibilityNotification <notification>k__BackingField;
            /*0x14*/ bool <isScreenReaderEnabled>k__BackingField;
            /*0x18*/ string <announcement>k__BackingField;
            /*0x20*/ bool <wasAnnouncementSuccessful>k__BackingField;
            /*0x24*/ int <currentNodeId>k__BackingField;
            /*0x28*/ int <nextNodeId>k__BackingField;

            /*0x7dc1550*/ UnityEngine.Accessibility.AccessibilityNotification get_notification();
            /*0x7dc1558*/ void set_notification(UnityEngine.Accessibility.AccessibilityNotification value);
            /*0x7dc1560*/ bool get_isScreenReaderEnabled();
            /*0x7dc1568*/ string get_announcement();
            /*0x7dc1570*/ bool get_wasAnnouncementSuccessful();
            /*0x7dc1578*/ int get_currentNodeId();
            /*0x7dc1580*/ int get_nextNodeId();
            /*0x7dc1588*/ void set_nextNodeId(int value);
        }

        class AccessibilitySettings
        {
            static /*0x0*/ System.Action<float> fontScaleChanged;
            static /*0x8*/ System.Action<bool> boldTextStatusChanged;
            static /*0x10*/ System.Action<bool> closedCaptioningStatusChanged;

            static /*0x7dc1590*/ void Internal_OnFontScaleChanged(float newFontScale);
            static /*0x7dc1660*/ void Internal_OnBoldTextStatusChanged(bool enabled);
            static /*0x7dc1734*/ void Internal_OnClosedCaptioningStatusChanged(bool enabled);
            static /*0x7dbfe0c*/ void InvokeFontScaleChanged(float newFontScale);
            static /*0x7dbfe84*/ void InvokeBoldTextStatusChanged(bool enabled);
            static /*0x7dbfef0*/ void InvokeClosedCaptionStatusChanged(bool enabled);
        }

        class AssistiveSupport
        {
            static /*0x0*/ System.Action<UnityEngine.Accessibility.AccessibilityNode> nodeFocusChanged;
            static /*0x8*/ System.Action<bool> screenReaderStatusChanged;
            static /*0x10*/ bool <isScreenReaderEnabled>k__BackingField;
            static /*0x18*/ UnityEngine.Accessibility.IAccessibilityNotificationDispatcher <notificationDispatcher>k__BackingField;
            static /*0x20*/ UnityEngine.Accessibility.ServiceManager s_ServiceManager;

            static /*0x7dc1c5c*/ AssistiveSupport();
            static /*0x7dc180c*/ bool get_isScreenReaderEnabled();
            static /*0x7dc1864*/ void set_isScreenReaderEnabled(bool value);
            static /*0x7dc18c4*/ UnityEngine.Accessibility.IAccessibilityNotificationDispatcher get_notificationDispatcher();
            static /*0x7dbf6a8*/ void Initialize();
            static /*0x3907c14*/ T GetService<T>();
            static /*0x7dc1a84*/ void ScreenReaderStatusChanged(bool screenReaderEnabled);
            static /*0x7dc1be0*/ void NodeFocusChanged(UnityEngine.Accessibility.AccessibilityNode currentNode);
            static /*0x7dc0b40*/ UnityEngine.Accessibility.AccessibilityHierarchy get_activeHierarchy();

            class NotificationDispatcher : UnityEngine.Accessibility.IAccessibilityNotificationDispatcher
            {
                static /*0x7dc1cd8*/ void Send(ref UnityEngine.Accessibility.AccessibilityNotificationContext context);
                /*0x7dc1cd0*/ NotificationDispatcher();
                /*0x7dc1d4c*/ void SendScreenChanged(UnityEngine.Accessibility.AccessibilityNode nodeToFocus);
            }
        }

        class AccessibilityHierarchy
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Accessibility.AccessibilityNode> m_RootNodes;
            /*0x18*/ System.Collections.Generic.IDictionary<int, UnityEngine.Accessibility.AccessibilityNode> m_Nodes;

            static /*0x7dc231c*/ UnityEngine.Accessibility.AccessibilityNode <TryGetNodeAt>g__FindNodeContainingPoint|27_0(System.Collections.Generic.IList<UnityEngine.Accessibility.AccessibilityNode> nodes, UnityEngine.Vector2 pos);
            /*0x7dc0bb0*/ bool TryGetNode(int id, ref UnityEngine.Accessibility.AccessibilityNode node);
            /*0x7dc1dc4*/ void FreeNative();
            /*0x7dc22e8*/ bool TryGetNodeAt(float horizontalPosition, float verticalPosition, ref UnityEngine.Accessibility.AccessibilityNode node);
        }

        class AccessibilityNode
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ System.Func<UnityEngine.Rect> m_FrameGetter;
            /*0x20*/ System.Action<UnityEngine.Accessibility.AccessibilityNode, bool> focusChanged;
            /*0x28*/ System.Func<bool> selected;
            /*0x30*/ System.Action incremented;
            /*0x38*/ System.Action decremented;
            /*0x40*/ System.Func<bool> dismissed;
            /*0x48*/ string m_Label;
            /*0x50*/ string m_Value;
            /*0x58*/ string m_Hint;
            /*0x60*/ bool m_IsActive;
            /*0x62*/ UnityEngine.Accessibility.AccessibilityRole m_Role;
            /*0x64*/ bool m_AllowsDirectInteraction;
            /*0x66*/ UnityEngine.Accessibility.AccessibilityState m_State;
            /*0x68*/ UnityEngine.Accessibility.AccessibilityNode m_Parent;
            /*0x70*/ UnityEngine.Accessibility.AccessibilityNode.ObservableList<UnityEngine.Accessibility.AccessibilityNode> m_Children;
            /*0x78*/ UnityEngine.Accessibility.AccessibilityNode.ObservableList<UnityEngine.Accessibility.AccessibilityAction> m_Actions;
            /*0x80*/ UnityEngine.Rect m_Frame;
            /*0x90*/ UnityEngine.SystemLanguage m_Language;
            /*0x98*/ UnityEngine.Accessibility.AccessibilityHierarchy m_Hierarchy;

            /*0x7dc1f10*/ void FreeNative(bool freeChildren);
            /*0x7dc257c*/ int get_id();
            /*0x7dc2584*/ string get_label();
            /*0x7dc258c*/ string get_value();
            /*0x7dc2594*/ string get_hint();
            /*0x7dc259c*/ bool get_isActive();
            /*0x7dc25a4*/ UnityEngine.Accessibility.AccessibilityRole get_role();
            /*0x7dc25ac*/ bool get_allowsDirectInteraction();
            /*0x7dc25b4*/ UnityEngine.Accessibility.AccessibilityState get_state();
            /*0x7dc25bc*/ UnityEngine.Accessibility.AccessibilityNode get_parent();
            /*0x7dc25c4*/ System.Collections.Generic.IList<UnityEngine.Accessibility.AccessibilityNode> get_childList();
            /*0x7dc24b8*/ UnityEngine.Rect get_frame();
            /*0x7dc2604*/ void SetFrame(UnityEngine.Rect frame);
            /*0x7dc269c*/ System.Func<UnityEngine.Rect> get_frameGetter();
            /*0x7dc25cc*/ void CalculateFrame();
            /*0x7dc26a4*/ UnityEngine.SystemLanguage get_language();
            /*0x7dc0324*/ void GetNodeData(ref UnityEngine.Accessibility.AccessibilityNodeData nodeData);
            /*0x7dc26ac*/ void ChildrenChanged();
            /*0x7dc27d8*/ void ActionsChanged();
            /*0x7dc250c*/ bool IsInActiveHierarchy();
            /*0x7dc1140*/ void NotifyFocusChanged(bool isNodeFocused);
            /*0x7dbfde4*/ void InvokeFocusChanged(bool isNodeFocused);
            /*0x7dc12bc*/ bool InvokeSelected();
            /*0x7dc138c*/ void InvokeIncremented();
            /*0x7dc1458*/ void InvokeDecremented();
            /*0x7dc1530*/ bool Dismissed();

            class ObservableList<T>
            {
                /*0x0*/ System.Collections.Generic.List<T> m_Items;
                /*0x0*/ System.Action listChanged;

                /*0x380b6a0*/ int get_Count();
                /*0x3907c14*/ T get_Item(int index);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380d83c*/ void add_listChanged(System.Action value);
                /*0x380d83c*/ void remove_listChanged(System.Action value);
            }
        }

        interface IAccessibilityNotificationDispatcher
        {
            /*0x380d83c*/ void SendScreenChanged(UnityEngine.Accessibility.AccessibilityNode nodeToFocus);
        }

        class AccessibilityHierarchyService : UnityEngine.Accessibility.IService
        {
            /*0x10*/ UnityEngine.Accessibility.AccessibilityHierarchy m_Hierarchy;

            /*0x7dc2a84*/ AccessibilityHierarchyService();
            /*0x7dc2934*/ UnityEngine.Accessibility.AccessibilityHierarchy get_hierarchy();
            /*0x7dc293c*/ void Start();
            /*0x7dc2940*/ void Stop();
            /*0x7dc2954*/ void RemoveActiveHierarchy(bool notifyScreenChanged);
            /*0x7dc02d8*/ bool TryGetNode(int id, ref UnityEngine.Accessibility.AccessibilityNode node);
            /*0x7dc0210*/ System.Collections.Generic.List<UnityEngine.Accessibility.AccessibilityNode> GetRootNodes();
            /*0x7dc05b8*/ bool TryGetNodeAt(float x, float y, ref UnityEngine.Accessibility.AccessibilityNode node);
        }

        interface IService
        {
            /*0x380cb08*/ void Stop();
        }

        class ServiceManager
        {
            /*0x10*/ System.Collections.Generic.IDictionary<System.Type, UnityEngine.Accessibility.IService> m_Services;

            /*0x7dc191c*/ ServiceManager();
            /*0x3907c14*/ T GetService<T>();
            /*0x380cb08*/ void StopService<T>();
            /*0x7dc2a8c*/ void UpdateServices(bool isScreenReaderEnabled);
            /*0x7dc2c90*/ void ScreenReaderStatusChanged(bool isScreenReaderEnabled);
        }
    }
}
