class <Module>
{
}

namespace EA
{
    namespace Debugging
    {
        namespace Menu
        {
            class DebugMenuCommand
            {
                /*0x10*/ EA.Debugging.Menu.PathString <Path>k__BackingField;
                /*0x18*/ EA.Debugging.Menu.DebugMenuCommandType <CommandType>k__BackingField;
                /*0x20*/ System.Type <ParamType>k__BackingField;
                /*0x28*/ EA.Debugging.Menu.IDebugCommandHandler<EA.Debugging.Menu.IDebugCommand> <CommandHandler>k__BackingField;
                /*0x30*/ System.Collections.Generic.IEnumerable<EA.Debugging.Menu.DebugMenuCommandOption> <Options>k__BackingField;

                /*0x2ba9244*/ EA.Debugging.Menu.PathString get_Path();
                /*0x2ba924c*/ EA.Debugging.Menu.DebugMenuCommandType get_CommandType();
                /*0x2ba9254*/ System.Type get_ParamType();
                /*0x2ba925c*/ EA.Debugging.Menu.IDebugCommandHandler<EA.Debugging.Menu.IDebugCommand> get_CommandHandler();
                /*0x2ba9264*/ System.Collections.Generic.IEnumerable<EA.Debugging.Menu.DebugMenuCommandOption> get_Options();
            }

            class DebugOptionDynamicLabelDelegate : System.MulticastDelegate
            {
                /*0x2ba926c*/ DebugOptionDynamicLabelDelegate(object object, nint method);
                /*0x2ba9308*/ string Invoke();
            }

            class DebugOptionDynamicValueDelegate<T> : System.MulticastDelegate
            {
                DebugOptionDynamicValueDelegate(object object, nint method);
                /*0x1ffc854*/ T Invoke();
            }

            class DebugMenuCommandOption
            {
                /*0x10*/ EA.Debugging.Menu.DebugMenuCommandOption.DebugMenuCommandOptionType <Type>k__BackingField;
                /*0x18*/ object <Value>k__BackingField;

                /*0x2ba931c*/ EA.Debugging.Menu.DebugMenuCommandOption.DebugMenuCommandOptionType get_Type();
                /*0x2ba9324*/ object get_Value();

                enum DebugMenuCommandOptionType
                {
                    Min = 0,
                    Max = 1,
                    DefaultValue = 2,
                    DynamicLabel = 3,
                    DynamicValue = 4,
                    DataProvider = 5,
                    RefreshInterval = 6,
                    IsRenderedOnScreen = 7,
                }
            }

            enum DebugMenuCommandType
            {
                SimpleAction = 0,
                ParamAction = 1,
                ToggleGroup = 2,
                Label = 3,
            }

            class GenericParamActionCommand<T> : EA.Debugging.Menu.IDebugCommand
            {
                /*0x0*/ T <Value>k__BackingField;

                /*0x1ffc854*/ GenericParamActionCommand(T value);
            }

            interface IDebugCommand
            {
            }

            interface IDebugCommandHandler<TCommand>
            {
                /*0x1ffc854*/ void Handle(TCommand command);
            }

            class SimpleActionCommand : EA.Debugging.Menu.IDebugCommand
            {
                static /*0x0*/ EA.Debugging.Menu.SimpleActionCommand Default;

                static /*0x2ba9334*/ SimpleActionCommand();
                /*0x2ba932c*/ SimpleActionCommand();
            }

            class DebugMenu
            {
                static string EnabledConditional = "EA_DEBUGMENU_CORE";
                static string RecentRoot = "/Recent/";
                static /*0x0*/ EA.Debugging.Menu.DebugMenu Instance;
                static /*0x8*/ EA.Debugging.Menu.DebugMenu.DebugOptionAdded OnDebugOptionAdded;
                static /*0x10*/ EA.Debugging.Menu.DebugMenu.DebugOptionRemoved OnDebugOptionRemoved;
                static /*0x18*/ EA.Debugging.Menu.DebugMenu.DebugOptionsChanged OnDebugOptionsChanged;
                /*0x10*/ System.Collections.Generic.Dictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.DebugMenuCommand> _entries;
                /*0x18*/ EA.Debugging.Menu.PathMetaDataRegistry _pathMetaDataRegistry;

                static /*0x2ba9a1c*/ DebugMenu();
                static /*0x2ba939c*/ void add_OnDebugOptionAdded(EA.Debugging.Menu.DebugMenu.DebugOptionAdded value);
                static /*0x2ba9478*/ void remove_OnDebugOptionAdded(EA.Debugging.Menu.DebugMenu.DebugOptionAdded value);
                static /*0x2ba9554*/ void add_OnDebugOptionRemoved(EA.Debugging.Menu.DebugMenu.DebugOptionRemoved value);
                static /*0x2ba9630*/ void remove_OnDebugOptionRemoved(EA.Debugging.Menu.DebugMenu.DebugOptionRemoved value);
                /*0x2ba98d4*/ DebugMenu();
                /*0x2ba970c*/ System.Collections.Generic.IReadOnlyDictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.DebugMenuCommand> get_Entries();
                /*0x2ba9714*/ EA.Debugging.Menu.PathMetaDataProvider get_PathMetaDataProvider();
                /*0x2ba971c*/ EA.Debugging.Menu.DebugMenuCommand GetDebugMenuCommand(string pathName);

                class DebugOptionAdded : System.MulticastDelegate
                {
                    /*0x2ba9a80*/ DebugOptionAdded(object object, nint method);
                    /*0x2ba9b8c*/ void Invoke(EA.Debugging.Menu.PathString pathName, EA.Debugging.Menu.DebugMenuCommand command);
                }

                class DebugOptionRemoved : System.MulticastDelegate
                {
                    /*0x2ba9ba0*/ DebugOptionRemoved(object object, nint method);
                    /*0x2ba9ca8*/ void Invoke(EA.Debugging.Menu.PathString pathName);
                }

                class DebugOptionsChanged : System.MulticastDelegate
                {
                    /*0x2ba9cbc*/ DebugOptionsChanged(object object, nint method);
                    /*0x2ba9dc4*/ void Invoke(System.Collections.Generic.IReadOnlyDictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.DebugMenuCommand> entries);
                }
            }

            class DebugMenuTree : EA.Debugging.Menu.IPathNodeProvider
            {
                /*0x10*/ System.Action OnNodesRebuilt;
                /*0x18*/ EA.Debugging.Menu.PathTreeBuilder<EA.Debugging.Menu.DebugMenuCommand> _builder;
                /*0x20*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> _root;

                /*0x2ba9f78*/ DebugMenuTree(EA.Debugging.Menu.DebugMenu registry);
                /*0x2ba9dd8*/ void add_OnNodesRebuilt(System.Action value);
                /*0x2ba9e74*/ void remove_OnNodesRebuilt(System.Action value);
                /*0x2ba9f10*/ EA.Debugging.Menu.PathString get_RootPath();
                /*0x2baa534*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> GetNode(EA.Debugging.Menu.PathString node);
                /*0x2baa110*/ void Rebuild(System.Collections.Generic.IReadOnlyDictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.DebugMenuCommand> entries);
                /*0x2baa674*/ void AddOption(EA.Debugging.Menu.PathString pathname, EA.Debugging.Menu.DebugMenuCommand command);
                /*0x2baa824*/ void OptionAdded(EA.Debugging.Menu.PathString pathname, EA.Debugging.Menu.DebugMenuCommand command);
                /*0x2baa8bc*/ void OptionRemoved(EA.Debugging.Menu.PathString pathname);

                class <>c
                {
                    static /*0x0*/ EA.Debugging.Menu.DebugMenuTree.<> <>9;
                    static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__10_0;

                    static /*0x2baa958*/ <>c();
                    /*0x2baa9c0*/ <>c();
                    /*0x2baa9c8*/ bool <AddOption>b__10_0(EA.Debugging.Menu.DebugMenuCommandOption p);
                }
            }

            interface IPathNodeProvider
            {
                /*0x1f30ebc*/ void add_OnNodesRebuilt(System.Action value);
                /*0x1f30ebc*/ void remove_OnNodesRebuilt(System.Action value);
                /*0x1f302cc*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> GetNode(EA.Debugging.Menu.PathString node);
            }

            class DebugMenuViewModel
            {
                /*0x10*/ EA.Debugging.Menu.DebugMenuViewModel.CurrentPathChanged OnCurrentPathChanged;
                /*0x18*/ System.Action OnRebuild;
                /*0x20*/ System.Action<bool> OnOpenStatusChanged;
                /*0x28*/ EA.Debugging.Menu.PathString <RootPath>k__BackingField;
                /*0x30*/ EA.Debugging.Menu.IPathNodeProvider _nodeProvider;
                /*0x38*/ EA.Debugging.Menu.PathString _currentPath;
                /*0x40*/ bool _isOpen;

                /*0x2baaf70*/ DebugMenuViewModel(EA.Debugging.Menu.IPathNodeProvider nodeProvider, EA.Debugging.Menu.PathString rootPath, bool isOpen);
                /*0x2baa9e4*/ void add_OnCurrentPathChanged(EA.Debugging.Menu.DebugMenuViewModel.CurrentPathChanged value);
                /*0x2baaa80*/ void remove_OnCurrentPathChanged(EA.Debugging.Menu.DebugMenuViewModel.CurrentPathChanged value);
                /*0x2baab1c*/ void add_OnRebuild(System.Action value);
                /*0x2baabb8*/ void remove_OnRebuild(System.Action value);
                /*0x2baac54*/ void add_OnOpenStatusChanged(System.Action<bool> value);
                /*0x2baad04*/ void remove_OnOpenStatusChanged(System.Action<bool> value);
                /*0x2baadb4*/ EA.Debugging.Menu.PathString get_RootPath();
                /*0x2baadbc*/ EA.Debugging.Menu.PathString get_CurrentPath();
                /*0x2baadc4*/ void set_CurrentPath(EA.Debugging.Menu.PathString value);
                /*0x2baae28*/ bool get_IsOpen();
                /*0x2baae30*/ void set_IsOpen(bool value);
                /*0x2baae70*/ bool get_CanGoBack();
                /*0x2baaeac*/ bool get_IsCurrentNodeValid();
                /*0x2bab0e0*/ void GoBack();
                /*0x2bab198*/ void ResetToRoot();
                /*0x2baaec4*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> GetNode(EA.Debugging.Menu.PathString path);
                /*0x2bab1a0*/ void ClearEventListeners();
                /*0x2bab1d8*/ void <.ctor>b__26_0();

                class CurrentPathChanged : System.MulticastDelegate
                {
                    /*0x2bab1f4*/ CurrentPathChanged(object object, nint method);
                    /*0x2bab2fc*/ void Invoke(EA.Debugging.Menu.PathString currentPath);
                }
            }

            interface PathMetaDataProvider
            {
                int GetSortOrder(EA.Debugging.Menu.PathString path, int defaultValue);
            }

            class PathMetaDataRegistry : EA.Debugging.Menu.PathMetaDataProvider
            {
                /*0x10*/ System.Collections.Generic.Dictionary<EA.Debugging.Menu.PathString, int> _sortOrders;

                /*0x2ba9994*/ PathMetaDataRegistry();
                /*0x2bab310*/ int GetSortOrder(EA.Debugging.Menu.PathString path, int defaultValue);
            }

            class PathNode<T>
            {
                /*0x0*/ EA.Debugging.Menu.PathString <Path>k__BackingField;
                /*0x0*/ string <Name>k__BackingField;
                /*0x0*/ EA.Debugging.Menu.PathNode<T> <Parent>k__BackingField;
                /*0x0*/ System.Collections.Generic.ISet<EA.Debugging.Menu.PathNode<T>> <Children>k__BackingField;
                /*0x0*/ T <Data>k__BackingField;

                /*0x1f309e4*/ PathNode();
                /*0x1ffc854*/ PathNode(EA.Debugging.Menu.PathString path, T data);
                /*0x1f30214*/ EA.Debugging.Menu.PathString get_Path();
                /*0x1f30214*/ string get_Name();
                /*0x1f30214*/ EA.Debugging.Menu.PathNode<T> get_Parent();
                /*0x1f30ebc*/ void set_Parent(EA.Debugging.Menu.PathNode<T> value);
                /*0x1f30214*/ System.Collections.Generic.ISet<EA.Debugging.Menu.PathNode<T>> get_Children();
                /*0x1ffc854*/ T get_Data();
                /*0x1ffc854*/ void set_Data(T value);
                /*0x1f2fe14*/ bool get_IsLeaf();
                /*0x1f2fe14*/ bool get_IsRoot();
                /*0x1f30ebc*/ void AddChild(EA.Debugging.Menu.PathNode<T> child);
                /*0x1f30ebc*/ void RemoveChild(EA.Debugging.Menu.PathNode<T> child);
                /*0x1f30214*/ string ToString();
            }

            class PathString : System.IComparable<EA.Debugging.Menu.PathString>
            {
                static string PathSeparator = "/";
                static string RootPath = "/";
                static /*0x0*/ System.Text.StringBuilder PathBuilder;
                static /*0x8*/ string[] PathSplitOptions;
                static /*0x10*/ char PathSeparatorChar;
                /*0x10*/ string[] _components;
                /*0x18*/ string <StringValue>k__BackingField;

                static /*0x2babc14*/ PathString();
                static /*0x2ba987c*/ EA.Debugging.Menu.PathString op_Implicit(string path);
                static /*0x2bab8cc*/ string op_Implicit(EA.Debugging.Menu.PathString path);
                static /*0x2bab408*/ string EnsurePathFormat(string path);
                /*0x2bab38c*/ PathString(string path);
                /*0x2bab820*/ string get_StringValue();
                /*0x2bab828*/ void set_StringValue(string value);
                /*0x2bab830*/ string[] get_Components();
                /*0x2bab8e0*/ void SetStringValue(string path);
                /*0x2bab97c*/ bool Equals(EA.Debugging.Menu.PathString other);
                /*0x2bab998*/ bool Equals(object obj);
                /*0x2baba98*/ int GetHashCode();
                /*0x2babab0*/ string ToString();
                /*0x2babab8*/ int CompareTo(EA.Debugging.Menu.PathString other);
                /*0x2babae4*/ EA.Debugging.Menu.PathString.PartialComparisonResult PartialCompare(EA.Debugging.Menu.PathString other);

                enum PartialComparisonResult
                {
                    Empty = 0,
                    None = 1,
                    Larger = 2,
                    Partial = 3,
                    Full = 4,
                    Identical = 5,
                }
            }

            class PathTreeBuilder<T>
            {
                static /*0x0*/ EA.Debugging.Menu.PathString _scratchPathString;
                /*0x0*/ System.Collections.Generic.IDictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.PathNode<T>> PathNodeMapping;
                /*0x0*/ System.Collections.Generic.Dictionary<EA.Debugging.Menu.PathString, T> _pathsPendingAddition;
                /*0x0*/ System.Collections.Generic.HashSet<EA.Debugging.Menu.PathString> _pathsPendingRemoval;
                /*0x0*/ System.Text.StringBuilder PendingObjectStringBuilder;

                static /*0x1f33998*/ PathTreeBuilder();
                static /*0x1f327a0*/ EA.Debugging.Menu.PathTreeBuilder<T> Builder();
                /*0x1f309e4*/ PathTreeBuilder();
                /*0x1ffc854*/ EA.Debugging.Menu.PathTreeBuilder<T> AddPath(EA.Debugging.Menu.PathString path, T data);
                /*0x1f302cc*/ EA.Debugging.Menu.PathTreeBuilder<T> RemovePath(EA.Debugging.Menu.PathString path);
                /*0x1f309e4*/ void Clear();
                /*0x1f30214*/ EA.Debugging.Menu.PathNode<T> Build();
                /*0x1f30214*/ EA.Debugging.Menu.PathNode<T> AddPendingObjects();
                /*0x1f309e4*/ void RemovePendingObjects();
                /*0x1f30ebc*/ void RemoveNodeByPathRecursive(EA.Debugging.Menu.PathString path);
                /*0x1f302cc*/ EA.Debugging.Menu.PathNode<T> CreateOrRetrieveNode(string path);
            }
        }
    }
}
