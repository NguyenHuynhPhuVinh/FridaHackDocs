class <Module>
{
}

namespace EA
{
    namespace Debugging
    {
        namespace Menu
        {
            class DebugMenuStateController : UnityEngine.MonoBehaviour
            {
                /*0x20*/ EA.Debugging.Menu.DebugMenuView _debugMenuView;
                /*0x28*/ EA.Debugging.Menu.DebugSwipeTracker _debugSwipeTracker;

                static /*0x2babe24*/ bool IsRightClick();
                static /*0x2babfcc*/ bool IsDebugKeyPressed();
                /*0x2bac140*/ DebugMenuStateController();
                /*0x2babd3c*/ void Awake();
                /*0x2babda4*/ void Update();
            }

            class DebugSwipeTracker
            {
                static float FirstTouchPercentageFromTopOfScreen = 0.10000000149011612;
                static float SwipeHeightPercentageThreshold = 0.20000000298023224;
                /*0x10*/ System.Nullable<UnityEngine.Vector3> _firstTouchPosition;
                /*0x20*/ float _swipeWidthPercentageThreshold;

                /*0x2bac1a8*/ DebugSwipeTracker();
                /*0x2babe94*/ bool TrackSwipe();
                /*0x2bac2c8*/ bool TrackSwipeForTouch();
                /*0x2bac218*/ bool TrackSwipeForMouse();
                /*0x2bac3e8*/ bool IsDebugSwipe(UnityEngine.Vector3 endPosition);
            }

            class MultiTouchDebugTracker
            {
                static /*0x2babebc*/ bool TrackMultiTouch();
            }

            class StickyDebugWindowManager
            {
                static string PersistenceDataKey = "StickDebugMenuWindows";
                static /*0x0*/ UnityEngine.Rect SpawnRect;
                static /*0x10*/ UnityEngine.Vector2 Size;
                /*0x10*/ EA.Debugging.Menu.DebugMenuTree _tree;
                /*0x18*/ EA.Debugging.Menu.IDebugMenuWindowFactory _windowFactory;
                /*0x20*/ System.Collections.Generic.IDictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.IDebugMenuWindow> _stickyMenuViews;

                static /*0x2bacedc*/ StickyDebugWindowManager();
                /*0x2bac5f8*/ StickyDebugWindowManager(EA.Debugging.Menu.DebugMenuTree tree, EA.Debugging.Menu.IDebugMenuWindowFactory windowFactory);
                /*0x2bac538*/ System.Collections.Generic.IEnumerable<EA.Debugging.Menu.IDebugMenuWindow> get_StickyMenus();
                /*0x2bac6b0*/ void CreateStickyDebugWindow(EA.Debugging.Menu.PathString pathName);
                /*0x2bac78c*/ void CreateStickyDebugWindow(EA.Debugging.Menu.PathString pathName, UnityEngine.Rect bounds, EA.Debugging.Menu.DebugWindowOptions options);
                /*0x2bacb80*/ void DestroyStickyDebugWindow(EA.Debugging.Menu.PathString pathName);
                /*0x2bacda4*/ void Load();
                /*0x2bac9ec*/ void Save();
                /*0x2bac6e4*/ UnityEngine.Rect GetRandomWindowPosition();
                /*0x2bac7a4*/ void AddWindow(EA.Debugging.Menu.PathString pathName, UnityEngine.Rect position, EA.Debugging.Menu.DebugWindowOptions options);
                /*0x2bacb98*/ void RemoveWindow(EA.Debugging.Menu.PathString pathName);

                class <>c
                {
                    static /*0x0*/ EA.Debugging.Menu.StickyDebugWindowManager.<> <>9;
                    static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<EA.Debugging.Menu.PathString, EA.Debugging.Menu.IDebugMenuWindow>, EA.Debugging.Menu.StickyDebugWindowData> <>9__14_0;

                    static /*0x2bacf6c*/ <>c();
                    /*0x2bacfd4*/ <>c();
                    /*0x2bacfdc*/ EA.Debugging.Menu.StickyDebugWindowData <Save>b__14_0(System.Collections.Generic.KeyValuePair<EA.Debugging.Menu.PathString, EA.Debugging.Menu.IDebugMenuWindow> p);
                }
            }

            class StickyDebugWindowListData
            {
                /*0x10*/ EA.Debugging.Menu.StickyDebugWindowData[] WindowData;

                /*0x2baced4*/ StickyDebugWindowListData();
            }

            class StickyDebugWindowData
            {
                /*0x10*/ string Path;
                /*0x18*/ UnityEngine.Rect Bounds;

                /*0x2bad214*/ StickyDebugWindowData();
            }

            class DebugConfig
            {
                /*0x10*/ UnityEngine.Vector2 SourceScreenSize;
                /*0x18*/ float SwipeThreshold;
                /*0x1c*/ bool SupportMultitouch;
                /*0x20*/ UnityEngine.Rect StickySpawnRect;
                /*0x30*/ UnityEngine.Rect DefaultPosition;
                /*0x40*/ UnityEngine.Rect BackButtonRect;
                /*0x50*/ UnityEngine.Color DisabledBoxColor;
                /*0x60*/ int ResizeButtonSize;
                /*0x64*/ int MoveIconSize;
                /*0x68*/ int DragAreaHeight;
                /*0x6c*/ int CloseButtonWidth;
                /*0x70*/ int CloseButtonHeight;
                /*0x74*/ int FixedButtonHeight;
                /*0x78*/ int FixedButtonWidth;
                /*0x7c*/ int HeaderTextSize;
                /*0x80*/ int PathFontSize;
                /*0x84*/ bool EnableRecentTruncation;
                /*0x88*/ int RecentPathDepth;
                /*0x8c*/ int RecentSize;
                /*0x90*/ int RecentWidth;
                /*0x94*/ bool DebugMenuKeyToggle;
                /*0x98*/ UnityEngine.KeyCode DebugMenuToggleKey;
                /*0x9c*/ UnityEngine.Rect MainMenuBounds;
                /*0xac*/ float TargetDeltaToProcessScroll;

                /*0x2bad348*/ DebugConfig();
                /*0x2bad21c*/ UnityEngine.GUIStyle get_IconButtonSkin();
            }

            enum ResourceType
            {
                PinIcon = 0,
                MoveIcon = 1,
                ResizeIcon = 2,
                CollapsedIcon = 3,
                ExpandedIcon = 4,
            }

            class DebugMenuResourceManager
            {
                static /*0x0*/ UnityEngine.Texture DefaultTexture;
                static /*0x8*/ System.Collections.Generic.IDictionary<EA.Debugging.Menu.ResourceType, UnityEngine.Texture> _textureMap;
                static /*0x10*/ System.Collections.Generic.IDictionary<EA.Debugging.Menu.ResourceType, string> _resourcePathMap;

                static /*0x2bad878*/ DebugMenuResourceManager();
                static /*0x2bad3e4*/ UnityEngine.Texture GetTexture(EA.Debugging.Menu.ResourceType type);
                static /*0x2bad604*/ void CreateTexture(EA.Debugging.Menu.ResourceType type, float width, float height);
                static /*0x2bad704*/ string GetResourcePath(EA.Debugging.Menu.ResourceType type);
            }

            class DebugMenuSystem : UnityEngine.MonoBehaviour
            {
                static string EnabledConditional = "EA_DEBUGMENU_UNITY";
                static /*0x0*/ EA.Debugging.Menu.DebugConfig _config;
                static /*0x8*/ System.Collections.Generic.List<EA.Debugging.Menu.RecentCommandEntry> <RecentCommandEntries>k__BackingField;
                /*0x20*/ EA.Debugging.Menu.ImGui.ImGuiDebugMenuMainView _debugMenuView;

                static /*0x2bae2a4*/ DebugMenuSystem();
                static /*0x2bac090*/ EA.Debugging.Menu.DebugConfig get_Config();
                static /*0x2badac0*/ System.Collections.Generic.List<EA.Debugging.Menu.RecentCommandEntry> get_RecentCommandEntries();
                static /*0x2badb18*/ void set_RecentCommandEntries(System.Collections.Generic.List<EA.Debugging.Menu.RecentCommandEntry> value);
                static /*0x2badb78*/ void AddRecentCommand(EA.Debugging.Menu.PathString path, System.Action action);
                static /*0x2badf6c*/ void Create(EA.Debugging.Menu.DebugConfig config);
                static /*0x2badfd4*/ void SetDefaultConfig(EA.Debugging.Menu.DebugConfig config);
                static /*0x2bae0a0*/ void Create();
                /*0x2bae29c*/ DebugMenuSystem();
                /*0x2bae164*/ void Awake();
                /*0x2bae1f8*/ void CreateDebugMenuView(EA.Debugging.Menu.PathString pathName);
                /*0x2bae22c*/ void CreateDebugMenuView(EA.Debugging.Menu.PathString pathName, UnityEngine.Rect bounds, EA.Debugging.Menu.DebugWindowOptions options);
                /*0x2bae264*/ void DestroyDebugMenuView(EA.Debugging.Menu.PathString pathName);

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ System.Action action;
                    /*0x18*/ EA.Debugging.Menu.PathString path;

                    /*0x2badef0*/ <>c__DisplayClass9_0();
                    /*0x2bae334*/ bool <AddRecentCommand>b__0(EA.Debugging.Menu.RecentCommandEntry cme);
                }
            }

            class DebugUtils
            {
                static /*0x2bae4dc*/ void ActionWrapper(System.Action action, EA.Debugging.Menu.PathString path);
                static /*0x1ffc854*/ void ActionWrapper<T>(System.Action<T> action, T obj, EA.Debugging.Menu.PathString path);

                class <>c__DisplayClass1_0<T>
                {
                    /*0x0*/ System.Action<T> action;
                    /*0x0*/ T obj;

                    /*0x1f309e4*/ <>c__DisplayClass1_0();
                    /*0x1f309e4*/ void <ActionWrapper>b__0();
                }
            }

            class RecentCommandEntry
            {
                /*0x10*/ EA.Debugging.Menu.PathString <Path>k__BackingField;
                /*0x18*/ System.Action <CachedAction>k__BackingField;

                /*0x2badf28*/ RecentCommandEntry(EA.Debugging.Menu.PathString initialPath, System.Action action);
                /*0x2badef8*/ RecentCommandEntry(EA.Debugging.Menu.PathString initialPath);
                /*0x2bae564*/ EA.Debugging.Menu.PathString get_Path();
                /*0x2bae56c*/ void set_Path(EA.Debugging.Menu.PathString value);
                /*0x2bae574*/ System.Action get_CachedAction();
                /*0x2bae57c*/ void set_CachedAction(System.Action value);
                /*0x2bae3a0*/ bool ReplacePath(EA.Debugging.Menu.PathString newPath);
                /*0x2bae4a0*/ bool ReplacePath(EA.Debugging.Menu.PathString newPath, System.Action action);
            }

            class DebugMenuPathNodeSorter
            {
                static int UnassignedInitialSortOrder = 10000;
                /*0x10*/ EA.Debugging.Menu.PathMetaDataProvider _metaDataProvider;
                /*0x18*/ System.Collections.Generic.IDictionary<EA.Debugging.Menu.PathString, int> _knownSortOrders;
                /*0x20*/ int _nextGeneratedSortOrder;

                /*0x2bae584*/ DebugMenuPathNodeSorter(EA.Debugging.Menu.PathMetaDataProvider metaDataProvider);
                /*0x2bae628*/ System.Collections.Generic.List<EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand>> CreateSortedChildrenList(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                /*0x2bae778*/ void AssignSortOrders(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                /*0x2baebf8*/ int FindSortOrder(EA.Debugging.Menu.PathString childPath);
                /*0x2baeca8*/ int SortByKnownSortOrders(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> x, EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> y);
            }

            class DebugMenuView : UnityEngine.MonoBehaviour
            {
                static string SystemDebugMenuPathBase = "System/Debug menu/";
                /*0x20*/ EA.Debugging.Menu.DebugMenuViewModel _mainViewModel;
                /*0x28*/ EA.Debugging.Menu.StickyDebugWindowManager _stickyWindowManager;
                /*0x30*/ EA.Debugging.Menu.DebugMenuTree _tree;

                /*0x2baf18c*/ DebugMenuView();
                /*0x2bac05c*/ bool get_IsMainMenuOpen();
                /*0x2bac074*/ void set_IsMainMenuOpen(bool value);
                /*0x1f30214*/ EA.Debugging.Menu.IDebugMenuWindowFactory GetWindowFactory();
                /*0x2baeeb8*/ void Awake();
                /*0x2baf084*/ void OnDestroy();
                /*0x2baf134*/ void OnApplicationPause(bool pauseStatus);
                /*0x2bae218*/ void CreateDebugMenuView(EA.Debugging.Menu.PathString pathName);
                /*0x2bae240*/ void CreateDebugMenuView(EA.Debugging.Menu.PathString pathName, UnityEngine.Rect rect, EA.Debugging.Menu.DebugWindowOptions options);
                /*0x2bae278*/ void DestroyDebugMenuView(EA.Debugging.Menu.PathString pathName);
                /*0x2baf150*/ void CheckIsCurrentPathValid();
                /*0x2baf080*/ void RegisterInternalDebugOptions();
                /*0x2baf130*/ void UnregisterInternalDebugOptions();
            }

            enum DebugWindowOptions
            {
                None = 1,
                Draggable = 2,
                Resizeable = 4,
                AllowStickyCreation = 8,
                CloseOnAction = 16,
                OptionsExpandedByDefault = 32,
                CloseOnOutOfBounds = 64,
                DrawCloseButton = 128,
                All = 2147483647,
            }

            interface IDebugMenuWindow
            {
                /*0x1f30214*/ EA.Debugging.Menu.PathString get_RootPath();
                UnityEngine.Rect get_Bounds();
                /*0x1f309e4*/ void Destroy();
            }

            interface IDebugMenuWindowFactory
            {
                EA.Debugging.Menu.IDebugMenuWindow CreateDebugMenuWindow(EA.Debugging.Menu.DebugMenuViewModel model, EA.Debugging.Menu.DebugWindowOptions windowOptions, UnityEngine.Rect bounds);
            }

            namespace ImGui
            {
                interface IImGuiDrawable
                {
                    /*0x1f309e4*/ void Draw();
                }

                interface IImGuiDrawable<T>
                {
                    /*0x1ffc854*/ T Draw(T value, UnityEngine.GUILayoutOption[] options);
                }

                class ImGuiBoolInputControl : EA.Debugging.Menu.ImGui.IImGuiDrawable<bool>
                {
                    /*0x2baf1f0*/ ImGuiBoolInputControl();
                    /*0x2baf194*/ bool Draw(bool value, UnityEngine.GUILayoutOption[] options);
                }

                class ImGuiBoolParamCommandView : EA.Debugging.Menu.ImGui.ImGuiDebugMenuExpandableButton
                {
                    /*0x58*/ EA.Debugging.Menu.ImGui.IImGuiDrawable _widgetView;

                    /*0x2baf1f8*/ ImGuiBoolParamCommandView(string label, EA.Debugging.Menu.DebugMenuCommand debugCommand, System.Action<bool> action, System.Action addStickyClicked);
                    /*0x2baf4e0*/ void OnDrawExpanded();

                    class <>c
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiBoolParamCommandView.<> <>9;
                        static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_0;

                        static /*0x2baf724*/ <>c();
                        /*0x2baf78c*/ <>c();
                        /*0x2baf794*/ bool <.ctor>b__1_0(EA.Debugging.Menu.DebugMenuCommandOption c);
                    }
                }

                class ImGuiDebugMenuButtonBase<TAction> : EA.Debugging.Menu.ImGui.IImGuiDrawable
                {
                    /*0x0*/ string _label;
                    /*0x0*/ TAction _action;
                    /*0x0*/ System.Action _addStickyClicked;
                    /*0x0*/ UnityEngine.Texture _texture;

                    /*0x1ffc854*/ ImGuiDebugMenuButtonBase(string label, TAction action, System.Action addStickyClicked);
                    /*0x1f309e4*/ void Draw();
                    /*0x1f309e4*/ void DrawStickyButton();
                    /*0x1f309e4*/ void OnAction();
                    /*0x1f30214*/ string GetLabel();
                }

                class ImGuiDebugMenuCommandButtonBase<TAction> : EA.Debugging.Menu.ImGui.ImGuiDebugMenuButtonBase<TAction>
                {
                    /*0x0*/ string _baseLabel;
                    /*0x0*/ EA.Debugging.Menu.DebugOptionDynamicLabelDelegate _dynamicLabelAction;

                    /*0x1ffc854*/ ImGuiDebugMenuCommandButtonBase(string label, EA.Debugging.Menu.DebugMenuCommand command, TAction action, System.Action addStickyClicked);
                    /*0x1f30214*/ string GetLabel();

                    class <>c<TAction>
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiDebugMenuCommandButtonBase.<>c<TAction> <>9;
                        static /*0x0*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__2_0;

                        static /*0x1f33998*/ <>c();
                        /*0x1f309e4*/ <>c();
                        /*0x1f2fec8*/ bool <.ctor>b__2_0(EA.Debugging.Menu.DebugMenuCommandOption p);
                    }
                }

                class ImGuiDebugMenuExpandableButton : EA.Debugging.Menu.ImGui.ImGuiDebugMenuCommandButtonBase<System.Action>
                {
                    /*0x40*/ UnityEngine.Texture _expandedTexture;
                    /*0x48*/ UnityEngine.Texture _collapsedTexture;
                    /*0x50*/ bool <IsExpanded>k__BackingField;

                    /*0x2baf418*/ ImGuiDebugMenuExpandableButton(string label, EA.Debugging.Menu.DebugMenuCommand command, System.Action addStickyClicked);
                    /*0x2baf7b0*/ bool get_IsExpanded();
                    /*0x2baf7b8*/ void set_IsExpanded(bool value);
                    /*0x2baf7c0*/ void Draw();
                    /*0x1f309e4*/ void OnDrawExpanded();
                    /*0x2bafc5c*/ void OnAction();
                }

                class ImGuiDebugMenuMainView : EA.Debugging.Menu.DebugMenuView
                {
                    static float WindowWidthRemovalThreshold = 0.75;
                    /*0x38*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView _mainMenuView;
                    /*0x40*/ EA.Debugging.Menu.IDebugMenuWindowFactory _windowFactory;
                    /*0x48*/ UnityEngine.GameObject _windowBackingsContainer;

                    /*0x2bb0c0c*/ ImGuiDebugMenuMainView();
                    /*0x2bafc6c*/ void Awake();
                    /*0x2bafe8c*/ UnityEngine.GameObject CreateWindowBackingContainer();
                    /*0x2bb01f8*/ EA.Debugging.Menu.IDebugMenuWindowFactory GetWindowFactory();
                    /*0x2bb0320*/ void OnGUI();
                    /*0x2bb06b4*/ bool IsMenuOutOfBounds(EA.Debugging.Menu.IDebugMenuWindow view);
                    /*0x2bb07f8*/ void CheckForStickyMenuRemovalCandidates();
                }

                class ImGuiDebugMenuNavigationButton : EA.Debugging.Menu.ImGui.ImGuiDebugMenuButtonBase<System.Action>
                {
                    /*0x30*/ EA.Debugging.Menu.PathString _path;

                    /*0x2bb0c14*/ ImGuiDebugMenuNavigationButton(string label, EA.Debugging.Menu.PathString path, System.Action action, System.Action addStickyClicked);
                    /*0x2bb0c98*/ void OnAction();
                }

                class ImGuiDebugMenuScaler
                {
                    static /*0x2bb0ca8*/ void ScaleGui();
                    static /*0x2bb0b98*/ float GetGuiScale();
                    static /*0x2bb0ddc*/ UnityEngine.Vector2 ConvertToSourceCoords(UnityEngine.Vector2 screenCoords);
                    static /*0x2bb0e08*/ UnityEngine.Vector2 ConvertToScreenCoords(UnityEngine.Vector2 screenCoords);
                    static /*0x2bb0dc4*/ UnityEngine.Vector3 GetGuiScaleVec3();
                }

                class ImGuiDebugMenuSimpleCommandButton : EA.Debugging.Menu.ImGui.ImGuiDebugMenuCommandButtonBase<System.Action>
                {
                    /*0x40*/ EA.Debugging.Menu.PathString _path;

                    /*0x2bb0e34*/ ImGuiDebugMenuSimpleCommandButton(string label, EA.Debugging.Menu.PathString path, EA.Debugging.Menu.DebugMenuCommand command, System.Action action, System.Action addStickyClicked);
                    /*0x2bb0ec8*/ void OnAction();
                }

                class ImGuiDebugMenuSkins
                {
                    static /*0x0*/ UnityEngine.GUIStyle button;
                    static /*0x8*/ UnityEngine.GUIStyle iconbutton;
                    static /*0x10*/ UnityEngine.GUIStyle pathlabel;
                    static /*0x18*/ UnityEngine.GUIStyle headerLabel;
                    static /*0x20*/ UnityEngine.GUIStyle window;

                    static /*0x2bb0ed8*/ ImGuiDebugMenuSkins();
                }

                class ImGuiDebugWindowBase
                {
                    /*0x10*/ int _id;
                    /*0x18*/ string _name;
                    /*0x20*/ UnityEngine.Rect _position;
                    /*0x30*/ EA.Debugging.Menu.DebugWindowOptions _windowOptions;
                    /*0x34*/ bool _isResizing;
                    /*0x38*/ UnityEngine.Rect _dragArea;
                    /*0x48*/ UnityEngine.GUILayoutOption[] _options;
                    /*0x50*/ UnityEngine.Texture _resizeIcon;
                    /*0x58*/ UnityEngine.Texture _moveIcon;

                    static /*0x2bb1738*/ UnityEngine.Vector2 GetRelativeMouseCoords();
                    /*0x2bb1224*/ ImGuiDebugWindowBase(int id, string name, UnityEngine.Rect startPosition, EA.Debugging.Menu.DebugWindowOptions windowOptions, UnityEngine.GUILayoutOption[] options);
                    /*0x2bb1218*/ UnityEngine.Rect get_Bounds();
                    /*0x2bb131c*/ void Draw();
                    /*0x2bb1654*/ UnityEngine.Rect GetTopRightCoords();
                    /*0x2bb06a8*/ bool ShouldRemoveOnOutOfBounds();
                    /*0x2bb1668*/ void OnBeforeDrawWindow();
                    /*0x2bb166c*/ void OnAfterDrawWindow();
                    /*0x2bb1670*/ bool CanDraw();
                    /*0x2bb1374*/ void UpdatePosition();
                    /*0x2bb1724*/ void UpdatePosition(UnityEngine.Rect position, bool forceUpdate);
                    /*0x2bb1550*/ void UpdateResizeRect();
                    /*0x2bb1848*/ void DrawDraggableWindow(int windowId);
                    /*0x2bb1ad8*/ void DrawLayoutCloseButton();
                    /*0x2bb1c98*/ void UpdateDragState();
                    /*0x2bb1d44*/ bool IsMouseDownForResizing();
                    /*0x2bb1784*/ UnityEngine.Rect GetResizeButtonRect();
                    /*0x2bb1678*/ UnityEngine.Rect GetMoveIconRect();
                    /*0x2bb1e00*/ void BeforeDrawHeader();
                    /*0x2bb1e04*/ void AfterDrawHeader();
                    /*0x1f309e4*/ void DrawContents();
                    /*0x1f309e4*/ void CloseWindow();
                }

                class ImGuiDebugWindowFactory : EA.Debugging.Menu.IDebugMenuWindowFactory
                {
                    static /*0x0*/ UnityEngine.Color BackingColor;
                    static /*0x10*/ UnityEngine.GameObject <WindowBackingsContainer>k__BackingField;

                    static /*0x2bb2754*/ ImGuiDebugWindowFactory();
                    static /*0x2bb1e08*/ UnityEngine.GameObject get_WindowBackingsContainer();
                    static /*0x2bb1e60*/ void set_WindowBackingsContainer(UnityEngine.GameObject value);
                    /*0x2bb0278*/ ImGuiDebugWindowFactory(UnityEngine.GameObject container);
                    /*0x2bb1ec0*/ EA.Debugging.Menu.IDebugMenuWindow CreateDebugMenuWindow(EA.Debugging.Menu.DebugMenuViewModel model, EA.Debugging.Menu.DebugWindowOptions windowOptions, UnityEngine.Rect bounds);
                    /*0x2bb1f7c*/ UnityEngine.UI.Image CreateWindowBacking(string name);
                }

                class ImGuiDebugWindowView : EA.Debugging.Menu.ImGui.ImGuiDebugWindowBase, EA.Debugging.Menu.IDebugMenuWindow
                {
                    static /*0x0*/ int WindowId;
                    /*0x60*/ System.Action<EA.Debugging.Menu.PathString> AddStickyWindow;
                    /*0x68*/ EA.Debugging.Menu.DebugMenuViewModel _viewModel;
                    /*0x70*/ System.Collections.Generic.IDictionary<EA.Debugging.Menu.PathString, EA.Debugging.Menu.ImGui.IImGuiDrawable> _options;
                    /*0x78*/ EA.Debugging.Menu.DebugMenuPathNodeSorter _debugMenuPathNodeSorter;
                    /*0x80*/ UnityEngine.UI.Image _backing;
                    /*0x88*/ string _path;
                    /*0x90*/ UnityEngine.Vector2 _scrollPosition;
                    /*0x98*/ bool _rebuildNeeded;
                    /*0x9c*/ UnityEngine.Vector2 _previousMousePosition;
                    /*0xa4*/ float _totalDelta;
                    /*0xa8*/ bool <MarkForRemoval>k__BackingField;
                    /*0xb0*/ EA.Debugging.Menu.ImGui.ImGuiSubwindow <ActiveSubwindow>k__BackingField;

                    static /*0x2bb635c*/ ImGuiDebugWindowView();
                    /*0x2bb2204*/ ImGuiDebugWindowView(EA.Debugging.Menu.DebugMenuViewModel viewModel, EA.Debugging.Menu.DebugWindowOptions windowOptions, UnityEngine.UI.Image backing, UnityEngine.Rect position);
                    /*0x2bb0148*/ void add_AddStickyWindow(System.Action<EA.Debugging.Menu.PathString> value);
                    /*0x2bb27a4*/ void remove_AddStickyWindow(System.Action<EA.Debugging.Menu.PathString> value);
                    /*0x2bb2854*/ EA.Debugging.Menu.PathString get_RootPath();
                    /*0x2bb286c*/ bool get_MarkForRemoval();
                    /*0x2bb2874*/ void set_MarkForRemoval(bool value);
                    /*0x2bb287c*/ EA.Debugging.Menu.ImGui.ImGuiSubwindow get_ActiveSubwindow();
                    /*0x2bb2884*/ void set_ActiveSubwindow(EA.Debugging.Menu.ImGui.ImGuiSubwindow value);
                    /*0x2bb2be8*/ void Destroy();
                    /*0x2bb288c*/ void CreateOptions(EA.Debugging.Menu.PathString path);
                    /*0x2bb2c5c*/ void ResolveCommand(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb39f4*/ void UpdatePath(EA.Debugging.Menu.PathString path);
                    /*0x2bb3258*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateSimpleAction(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb3458*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateLabel(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb3584*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateParamAction(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb3ce8*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateIntParamAction(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb3ea0*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateFloatParamAction(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb4058*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateStringParamAction(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb4210*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateBoolParamAction(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb383c*/ EA.Debugging.Menu.ImGui.IImGuiDrawable CreateToggleGroup(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb3178*/ System.Action GetStickyActionClicked(EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node);
                    /*0x2bb50f0*/ bool CanDraw();
                    /*0x2bb5108*/ void OnBeforeDrawWindow();
                    /*0x2bb51a4*/ void OnAfterDrawWindow();
                    /*0x2bb52a0*/ void DrawContents();
                    /*0x2bb5670*/ void DrawPath();
                    /*0x2bb5218*/ void UpdateBacking();
                    /*0x2bb5e7c*/ void BeforeDrawHeader();
                    /*0x2bb5e94*/ void DrawBackButton();
                    /*0x2bb60ec*/ void DrawRecentOptions();
                    /*0x2bb5908*/ void DrawOptions();
                    /*0x2bb62c4*/ void CloseOnAction();
                    /*0x2bb62dc*/ void OnStickyClicked(EA.Debugging.Menu.PathString pathName);
                    /*0x2bb62f8*/ void CloseWindow();
                    /*0x2bb6350*/ void ClearSubwindow();
                    /*0x2bb5458*/ void UpdateMouseDrag();
                    /*0x2bb63a8*/ void <.ctor>b__23_0();
                    /*0x2bb63b4*/ void <.ctor>b__23_1(bool isOpen);

                    class <>c__DisplayClass26_0
                    {
                        /*0x10*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;
                        /*0x18*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;

                        /*0x2bb3170*/ <>c__DisplayClass26_0();
                        /*0x2bb63e4*/ void <ResolveCommand>b__0();
                    }

                    class <>c__DisplayClass28_0
                    {
                        /*0x10*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;
                        /*0x18*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;

                        /*0x2bb3a0c*/ <>c__DisplayClass28_0();
                        /*0x2bb6464*/ void <CreateSimpleAction>b__0();
                    }

                    class <>c__DisplayClass31_0
                    {
                        /*0x10*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;
                        /*0x18*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;

                        /*0x2bb43c8*/ <>c__DisplayClass31_0();
                        /*0x2bb65c4*/ void <CreateIntParamAction>b__0(int value);
                    }

                    class <>c__DisplayClass32_0
                    {
                        /*0x10*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;
                        /*0x18*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;

                        /*0x2bb47dc*/ <>c__DisplayClass32_0();
                        /*0x2bb6738*/ void <CreateFloatParamAction>b__0(float value);
                    }

                    class <>c__DisplayClass33_0
                    {
                        /*0x10*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;
                        /*0x18*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;

                        /*0x2bb4bc4*/ <>c__DisplayClass33_0();
                        /*0x2bb68b4*/ void <CreateStringParamAction>b__0(string value);
                    }

                    class <>c__DisplayClass34_0
                    {
                        /*0x10*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;
                        /*0x18*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;

                        /*0x2bb4dbc*/ <>c__DisplayClass34_0();
                        /*0x2bb6a28*/ void <CreateBoolParamAction>b__0(bool value);
                    }

                    class <>c__DisplayClass35_0
                    {
                        /*0x10*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;
                        /*0x18*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;

                        /*0x2bb4dc4*/ <>c__DisplayClass35_0();
                        /*0x2bb6ba0*/ void <CreateToggleGroup>b__0(string value);
                    }

                    class <>c__DisplayClass36_0
                    {
                        /*0x10*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView <>4__this;
                        /*0x18*/ EA.Debugging.Menu.PathNode<EA.Debugging.Menu.DebugMenuCommand> node;

                        /*0x2bb50e8*/ <>c__DisplayClass36_0();
                        /*0x2bb6d14*/ void <GetStickyActionClicked>b__0();
                    }
                }

                class ImGuiFloatInputControl : EA.Debugging.Menu.ImGui.IImGuiDrawable<float>
                {
                    /*0x10*/ float _min;
                    /*0x14*/ float _max;
                    /*0x18*/ string _lastValidValue;

                    static /*0x2bb6f44*/ float ParseFloat(string value, float defaultValue);
                    /*0x2bb6da4*/ ImGuiFloatInputControl(float min, float max);
                    /*0x2bb6dd0*/ float Draw(float value, UnityEngine.GUILayoutOption[] options);
                }

                class ImGuiFloatParamCommandView : EA.Debugging.Menu.ImGui.ImGuiDebugMenuExpandableButton
                {
                    /*0x58*/ EA.Debugging.Menu.ImGui.IImGuiDrawable _controlView;

                    /*0x2bb47e4*/ ImGuiFloatParamCommandView(string label, EA.Debugging.Menu.DebugMenuCommand debugCommand, System.Action<float> action, System.Action addStickyClicked);
                    /*0x2bb6fdc*/ void OnDrawExpanded();

                    class <>c
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiFloatParamCommandView.<> <>9;
                        static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_0;
                        static /*0x10*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_1;
                        static /*0x18*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_2;

                        static /*0x2bb7220*/ <>c();
                        /*0x2bb7288*/ <>c();
                        /*0x2bb7290*/ bool <.ctor>b__1_0(EA.Debugging.Menu.DebugMenuCommandOption c);
                        /*0x2bb72ac*/ bool <.ctor>b__1_1(EA.Debugging.Menu.DebugMenuCommandOption c);
                        /*0x2bb72c8*/ bool <.ctor>b__1_2(EA.Debugging.Menu.DebugMenuCommandOption c);
                    }
                }

                class ImGuiIntInputControl : EA.Debugging.Menu.ImGui.IImGuiDrawable<int>
                {
                    /*0x10*/ int _min;
                    /*0x14*/ int _max;
                    /*0x18*/ int _default;

                    /*0x2bb72e4*/ ImGuiIntInputControl(int defaultValue, int min, int max);
                    /*0x2bb7320*/ int Draw(int value, UnityEngine.GUILayoutOption[] options);
                }

                class ImGuiIntParamCommandView : EA.Debugging.Menu.ImGui.ImGuiDebugMenuExpandableButton
                {
                    /*0x58*/ EA.Debugging.Menu.ImGui.IImGuiDrawable _controlView;

                    static /*0x2bb7504*/ int GetValueFromOption(EA.Debugging.Menu.DebugMenuCommandOption option, int defaultValue);
                    /*0x2bb43d0*/ ImGuiIntParamCommandView(string label, EA.Debugging.Menu.DebugMenuCommand debugCommand, System.Action<int> action, System.Action addStickyClicked);
                    /*0x2bb7674*/ void OnDrawExpanded();

                    class <>c
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiIntParamCommandView.<> <>9;
                        static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_0;
                        static /*0x10*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_1;
                        static /*0x18*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_2;

                        static /*0x2bb78b8*/ <>c();
                        /*0x2bb7920*/ <>c();
                        /*0x2bb7928*/ bool <.ctor>b__1_0(EA.Debugging.Menu.DebugMenuCommandOption c);
                        /*0x2bb7944*/ bool <.ctor>b__1_1(EA.Debugging.Menu.DebugMenuCommandOption c);
                        /*0x2bb7960*/ bool <.ctor>b__1_2(EA.Debugging.Menu.DebugMenuCommandOption c);
                    }
                }

                class ImGuiSliderWidget : EA.Debugging.Menu.ImGui.IImGuiDrawable
                {
                    /*0x10*/ EA.Debugging.Menu.ImGui.ImGuiIntInputControl _inputControl;
                    /*0x18*/ System.Action<int> _action;
                    /*0x20*/ int _min;
                    /*0x24*/ int _max;
                    /*0x28*/ int _value;
                    /*0x30*/ EA.Debugging.Menu.PathString _path;

                    /*0x2bb75ac*/ ImGuiSliderWidget(System.Action<int> action, EA.Debugging.Menu.PathString path, int min, int max, int defaultValue);
                    /*0x2bb797c*/ void Draw();
                    /*0x2bb7c20*/ void UpdateValue();
                    /*0x2bb7e54*/ void UpdateSlider();
                }

                class ImGuiLabelButton : EA.Debugging.Menu.ImGui.ImGuiDebugMenuExpandableButton
                {
                    /*0x58*/ EA.Debugging.Menu.ImGui.ImGuiLabelWidget<string> _labelWidget;

                    /*0x2bb3a14*/ ImGuiLabelButton(string label, EA.Debugging.Menu.DebugMenuCommand command, System.Action addStickyClicked);
                    /*0x2bb7fe4*/ void OnDrawExpanded();

                    class <>c
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiLabelButton.<> <>9;
                        static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_0;
                        static /*0x10*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_1;

                        static /*0x2bb81c0*/ <>c();
                        /*0x2bb8228*/ <>c();
                        /*0x2bb8230*/ bool <.ctor>b__1_0(EA.Debugging.Menu.DebugMenuCommandOption p);
                        /*0x2bb824c*/ bool <.ctor>b__1_1(EA.Debugging.Menu.DebugMenuCommandOption p);
                    }
                }

                class ImGuiLabelWidget<T> : EA.Debugging.Menu.ImGui.IImGuiDrawable
                {
                    /*0x0*/ string _label;
                    /*0x0*/ EA.Debugging.Menu.DebugOptionDynamicValueDelegate<T> _dynamicValue;
                    /*0x0*/ float _updateRateInSeconds;
                    /*0x0*/ float _lastUpdateTime;
                    /*0x0*/ string _cachedText;
                    /*0x0*/ bool _isUpdating;

                    ImGuiLabelWidget(string label, EA.Debugging.Menu.DebugOptionDynamicValueDelegate<T> dynamicValue, float updateRateInSeconds);
                    /*0x1f309e4*/ void Draw();
                }

                class ImGuiPrimitiveTypeInputWidget<T> : EA.Debugging.Menu.ImGui.IImGuiDrawable
                {
                    /*0x0*/ EA.Debugging.Menu.ImGui.IImGuiDrawable<T> _inputControl;
                    /*0x0*/ System.Action<T> _action;
                    /*0x0*/ T _value;
                    /*0x0*/ EA.Debugging.Menu.PathString _label;
                    /*0x0*/ UnityEngine.GUIStyle buttonLayout;

                    /*0x1ffc854*/ ImGuiPrimitiveTypeInputWidget(System.Action<T> action, EA.Debugging.Menu.PathString label, T defaultValue, EA.Debugging.Menu.ImGui.IImGuiDrawable<T> inputControl);
                    /*0x1f309e4*/ void Draw();
                }

                class ImGuiRecentPathWindow : EA.Debugging.Menu.ImGui.ImGuiSubwindow
                {
                    /*0x2bb6248*/ ImGuiRecentPathWindow(EA.Debugging.Menu.ImGui.ImGuiDebugWindowView parentWindow);
                    /*0x2bb85bc*/ void DrawContents();
                    /*0x2bb88a4*/ void <DrawContents>b__1_0(EA.Debugging.Menu.RecentCommandEntry x);
                }

                class ImGuiStringInputControl : EA.Debugging.Menu.ImGui.IImGuiDrawable<string>
                {
                    /*0x2bb908c*/ ImGuiStringInputControl();
                    /*0x2bb907c*/ string Draw(string value, UnityEngine.GUILayoutOption[] options);
                }

                class ImGuiStringParamCommandView : EA.Debugging.Menu.ImGui.ImGuiDebugMenuExpandableButton
                {
                    /*0x58*/ EA.Debugging.Menu.ImGui.IImGuiDrawable _widgetView;

                    /*0x2bb4bcc*/ ImGuiStringParamCommandView(string label, EA.Debugging.Menu.DebugMenuCommand debugCommand, System.Action<string> action, System.Action addStickyClicked);
                    /*0x2bb9094*/ void OnDrawExpanded();

                    class <>c
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiStringParamCommandView.<> <>9;
                        static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_0;

                        static /*0x2bb92d8*/ <>c();
                        /*0x2bb9340*/ <>c();
                        /*0x2bb9348*/ bool <.ctor>b__1_0(EA.Debugging.Menu.DebugMenuCommandOption c);
                    }
                }

                class ImGuiStringToggleGroupCommandView : EA.Debugging.Menu.ImGui.ImGuiDebugMenuExpandableButton
                {
                    /*0x58*/ EA.Debugging.Menu.ImGui.ImGuiToggleGroupWidget<string> _toggleGroup;

                    /*0x2bb4dcc*/ ImGuiStringToggleGroupCommandView(string label, EA.Debugging.Menu.DebugMenuCommand command, System.Action<string> action, System.Action addStickyClicked);
                    /*0x2bb9364*/ void OnDrawExpanded();

                    class <>c
                    {
                        static /*0x0*/ EA.Debugging.Menu.ImGui.ImGuiStringToggleGroupCommandView.<> <>9;
                        static /*0x8*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_0;
                        static /*0x10*/ System.Func<EA.Debugging.Menu.DebugMenuCommandOption, bool> <>9__1_1;

                        static /*0x2bb9540*/ <>c();
                        /*0x2bb95a8*/ <>c();
                        /*0x2bb95b0*/ bool <.ctor>b__1_0(EA.Debugging.Menu.DebugMenuCommandOption p);
                        /*0x2bb95cc*/ bool <.ctor>b__1_1(EA.Debugging.Menu.DebugMenuCommandOption p);
                    }
                }

                class ImGuiSubwindow : EA.Debugging.Menu.ImGui.ImGuiDebugWindowBase
                {
                    static /*0x0*/ int WindowId;
                    /*0x60*/ UnityEngine.UI.Image _backing;
                    /*0x68*/ EA.Debugging.Menu.ImGui.ImGuiDebugWindowView _parentWindow;

                    static /*0x2bb9a20*/ ImGuiSubwindow();
                    static /*0x2bb95e8*/ UnityEngine.Rect GeneratePosition(EA.Debugging.Menu.ImGui.ImGuiDebugWindowBase parentWindow);
                    /*0x2bb8268*/ ImGuiSubwindow(EA.Debugging.Menu.ImGui.ImGuiDebugWindowView parentWindow, string name);
                    /*0x2bb9904*/ void Draw();
                    /*0x2bb9674*/ UnityEngine.UI.Image GenerateBackingContainer();
                    /*0x2bb987c*/ void UpdateBacking();
                    /*0x2bb9994*/ void DrawContents();
                    /*0x2bb623c*/ void Close();
                    /*0x2bb9998*/ void CloseWindow();
                }

                class ImGuiToggleGroupWidget<T> : EA.Debugging.Menu.ImGui.IImGuiDrawable
                {
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> _dataProvider;
                    /*0x0*/ System.Action<T> _action;
                    /*0x0*/ EA.Debugging.Menu.DebugOptionDynamicValueDelegate<T> _dynamicValue;
                    /*0x0*/ string _path;

                    /*0x1f31134*/ ImGuiToggleGroupWidget(System.Collections.Generic.IEnumerable<T> dataProvider, System.Action<T> action, EA.Debugging.Menu.DebugOptionDynamicValueDelegate<T> dynamicValue, string path);
                    /*0x1f309e4*/ void Draw();
                }
            }
        }
    }
}
