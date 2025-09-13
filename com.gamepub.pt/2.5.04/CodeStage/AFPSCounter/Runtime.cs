class <Module>
{
}

namespace CodeStage
{
    namespace AdvancedFPSCounter
    {
        class AFPSCounter : UnityEngine.MonoBehaviour
        {
            static string MenuPath = "Code Stage/🚀 Advanced FPS Count";
            static string ComponentName = "Advanced FPS Counter";
            static string LogPrefix = "[AFPSCounter]: ";
            static char NewLine = 10;
            static char Space = 32;
            static /*0x0*/ CodeStage.AdvancedFPSCounter.AFPSCounter <Instance>k__BackingField;
            /*0x18*/ CodeStage.AdvancedFPSCounter.CountersData.FPSCounterData fpsCounter;
            /*0x20*/ CodeStage.AdvancedFPSCounter.CountersData.MemoryCounterData memoryCounter;
            /*0x28*/ CodeStage.AdvancedFPSCounter.CountersData.DeviceInfoCounterData deviceInfoCounter;
            /*0x30*/ UnityEngine.KeyCode hotKey;
            /*0x34*/ bool circleGesture;
            /*0x35*/ bool hotKeyCtrl;
            /*0x36*/ bool hotKeyShift;
            /*0x37*/ bool hotKeyAlt;
            /*0x38*/ bool keepAlive;
            /*0x40*/ UnityEngine.Canvas canvas;
            /*0x48*/ UnityEngine.UI.CanvasScaler canvasScaler;
            /*0x50*/ bool externalCanvas;
            /*0x58*/ CodeStage.AdvancedFPSCounter.Labels.DrawableLabel[] labels;
            /*0x60*/ int anchorsCount;
            /*0x64*/ int cachedVSync;
            /*0x68*/ int cachedFrameRate;
            /*0x6c*/ bool inited;
            /*0x70*/ System.Collections.Generic.List<UnityEngine.Vector2> gesturePoints;
            /*0x78*/ int gestureCount;
            /*0x7c*/ CodeStage.AdvancedFPSCounter.OperationMode operationMode;
            /*0x7d*/ bool forceFrameRate;
            /*0x80*/ int forcedFrameRate;
            /*0x84*/ bool background;
            /*0x88*/ UnityEngine.Color backgroundColor;
            /*0x98*/ int backgroundPadding;
            /*0x9c*/ bool shadow;
            /*0xa0*/ UnityEngine.Color shadowColor;
            /*0xb0*/ UnityEngine.Vector2 shadowDistance;
            /*0xb8*/ bool outline;
            /*0xbc*/ UnityEngine.Color outlineColor;
            /*0xcc*/ UnityEngine.Vector2 outlineDistance;
            /*0xd4*/ bool autoScale;
            /*0xd8*/ float scaleFactor;
            /*0xe0*/ UnityEngine.Font labelsFont;
            /*0xe8*/ int fontSize;
            /*0xec*/ float lineSpacing;
            /*0xf0*/ int countersSpacing;
            /*0xf4*/ UnityEngine.Vector2 paddingOffset;
            /*0xfc*/ bool pixelPerfect;
            /*0x100*/ int sortingOrder;

            static /*0x26cee68*/ CodeStage.AdvancedFPSCounter.AFPSCounter get_Instance();
            static /*0x26ceeb4*/ void set_Instance(CodeStage.AdvancedFPSCounter.AFPSCounter value);
            static /*0x26cef04*/ CodeStage.AdvancedFPSCounter.AFPSCounter GetOrCreateInstance(bool keepAlive);
            static /*0x26cf19c*/ CodeStage.AdvancedFPSCounter.AFPSCounter AddToScene();
            static /*0x26cf1a4*/ CodeStage.AdvancedFPSCounter.AFPSCounter AddToScene(bool keepAlive);
            static /*0x26cf1ac*/ void Dispose();
            static /*0x26cf1b0*/ void SelfDestroy();
            static /*0x26cf370*/ string Color32ToHex(UnityEngine.Color32 color);
            static /*0x26cf070*/ CodeStage.AdvancedFPSCounter.AFPSCounter CreateInScene(bool lookForExistingContainer);
            /*0x26cea6c*/ AFPSCounter();
            /*0x26cd108*/ bool get_KeepAlive();
            /*0x26cd110*/ CodeStage.AdvancedFPSCounter.OperationMode get_OperationMode();
            /*0x26cd118*/ void set_OperationMode(CodeStage.AdvancedFPSCounter.OperationMode value);
            /*0x26cd7a8*/ bool get_ForceFrameRate();
            /*0x26cd7b0*/ void set_ForceFrameRate(bool value);
            /*0x26cd81c*/ int get_ForcedFrameRate();
            /*0x26cd824*/ void set_ForcedFrameRate(int value);
            /*0x26cd87c*/ bool get_Background();
            /*0x26cd884*/ void set_Background(bool value);
            /*0x26cd954*/ UnityEngine.Color get_BackgroundColor();
            /*0x26cd960*/ void set_BackgroundColor(UnityEngine.Color value);
            /*0x26cda64*/ int get_BackgroundPadding();
            /*0x26cda6c*/ void set_BackgroundPadding(int value);
            /*0x26cdb38*/ bool get_Shadow();
            /*0x26cdb40*/ void set_Shadow(bool value);
            /*0x26cdc10*/ UnityEngine.Color get_ShadowColor();
            /*0x26cdc1c*/ void set_ShadowColor(UnityEngine.Color value);
            /*0x26cdd20*/ UnityEngine.Vector2 get_ShadowDistance();
            /*0x26cdd28*/ void set_ShadowDistance(UnityEngine.Vector2 value);
            /*0x26cde10*/ bool get_Outline();
            /*0x26cde18*/ void set_Outline(bool value);
            /*0x26cdee8*/ UnityEngine.Color get_OutlineColor();
            /*0x26cdef4*/ void set_OutlineColor(UnityEngine.Color value);
            /*0x26cdff8*/ UnityEngine.Vector2 get_OutlineDistance();
            /*0x26ce000*/ void set_OutlineDistance(UnityEngine.Vector2 value);
            /*0x26ce0e8*/ bool get_AutoScale();
            /*0x26ce0f0*/ void set_AutoScale(bool value);
            /*0x26ce1bc*/ float get_ScaleFactor();
            /*0x26ce1c4*/ void set_ScaleFactor(float value);
            /*0x26ce2c4*/ UnityEngine.Font get_LabelsFont();
            /*0x26ce2cc*/ void set_LabelsFont(UnityEngine.Font value);
            /*0x26ce3fc*/ int get_FontSize();
            /*0x26ce404*/ void set_FontSize(int value);
            /*0x26ce548*/ float get_LineSpacing();
            /*0x26ce550*/ void set_LineSpacing(float value);
            /*0x26ce6e8*/ int get_CountersSpacing();
            /*0x26ce6f0*/ void set_CountersSpacing(int value);
            /*0x26ce79c*/ UnityEngine.Vector2 get_PaddingOffset();
            /*0x26ce7a4*/ void set_PaddingOffset(UnityEngine.Vector2 value);
            /*0x26ce91c*/ bool get_PixelPerfect();
            /*0x26ce924*/ void set_PixelPerfect(bool value);
            /*0x26ce99c*/ int get_SortingOrder();
            /*0x26ce9a4*/ void set_SortingOrder(int value);
            /*0x26cf42c*/ void Awake();
            /*0x26cfc4c*/ void Start();
            /*0x26cfd84*/ void Update();
            /*0x26d0204*/ void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x26d0208*/ void OnLevelLoadedCallback();
            /*0x26cd340*/ void OnEnable();
            /*0x26cd6d0*/ void OnDisable();
            /*0x26d04d4*/ void OnDestroy();
            /*0x26d0784*/ void MakeDrawableLabelDirty(CodeStage.AdvancedFPSCounter.Labels.LabelAnchor anchor);
            /*0x26cd3b8*/ void UpdateTexts();
            /*0x26cf5b4*/ void ConfigureCanvas();
            /*0x26cf95c*/ void ConfigureLabels();
            /*0x26cf298*/ void DisposeInternal();
            /*0x26cfdd0*/ void ProcessHotKey();
            /*0x26cfed4*/ bool CircleGestureMade();
            /*0x26d01e0*/ void SwitchCounter();
            /*0x26d02bc*/ void ActivateCounters();
            /*0x26d0358*/ void DeactivateCounters();
            /*0x26cd814*/ void RefreshForcedFrameRate();
            /*0x26d0444*/ void RefreshForcedFrameRate(bool disabling);
        }

        enum FPSLevel
        {
            Normal = 0,
            Warning = 1,
            Critical = 2,
        }

        enum OperationMode
        {
            Disabled = 0,
            Background = 1,
            Normal = 2,
        }

        namespace Utils
        {
            class AFPSRenderRecorder : UnityEngine.MonoBehaviour
            {
                /*0x18*/ bool recording;
                /*0x1c*/ float renderTime;

                /*0x26d101c*/ AFPSRenderRecorder();
                /*0x26d0e0c*/ void OnPreCull();
                /*0x26d0ecc*/ void OnPostRender();
            }

            class CachedNumbers
            {
                static int IntMax = 1000;
                static /*0x0*/ string[] cachedFloatDigits;
                static /*0x8*/ string[] cachedIntegers;

                static /*0x26d1a38*/ CachedNumbers();
                static /*0x26d1640*/ string ToStringLookup(long value, bool useFloatDigits);
                static /*0x26d1768*/ System.Text.StringBuilder AppendLookup(System.Text.StringBuilder text, int value);
                static /*0x26d17f0*/ System.Text.StringBuilder AppendLookup(System.Text.StringBuilder text, long value);
                static /*0x26d1878*/ System.Text.StringBuilder AppendLookup(System.Text.StringBuilder text, float value);
            }

            class UIUtils
            {
                static /*0x2b09ccc*/ void ResetRectTransform(UnityEngine.RectTransform rectTransform);
                /*0x2b09d8c*/ UIUtils();
            }
        }

        namespace Labels
        {
            class DrawableLabel
            {
                /*0x10*/ UnityEngine.GameObject container;
                /*0x18*/ CodeStage.AdvancedFPSCounter.Labels.LabelAnchor anchor;
                /*0x20*/ System.Text.StringBuilder newText;
                /*0x28*/ bool dirty;
                /*0x30*/ UnityEngine.GameObject labelGameObject;
                /*0x38*/ UnityEngine.RectTransform labelTransform;
                /*0x40*/ UnityEngine.UI.ContentSizeFitter labelFitter;
                /*0x48*/ UnityEngine.UI.HorizontalLayoutGroup labelGroup;
                /*0x50*/ UnityEngine.GameObject uiTextGameObject;
                /*0x58*/ UnityEngine.UI.Text uiText;
                /*0x60*/ UnityEngine.Font font;
                /*0x68*/ int fontSize;
                /*0x6c*/ float lineSpacing;
                /*0x70*/ UnityEngine.Vector2 pixelOffset;
                /*0x78*/ CodeStage.AdvancedFPSCounter.Labels.LabelEffect background;
                /*0x80*/ UnityEngine.UI.Image backgroundImage;
                /*0x88*/ CodeStage.AdvancedFPSCounter.Labels.LabelEffect shadow;
                /*0x90*/ UnityEngine.UI.Shadow shadowComponent;
                /*0x98*/ CodeStage.AdvancedFPSCounter.Labels.LabelEffect outline;
                /*0xa0*/ UnityEngine.UI.Outline outlineComponent;

                /*0x26d0d1c*/ DrawableLabel(UnityEngine.GameObject container, CodeStage.AdvancedFPSCounter.Labels.LabelAnchor anchor, CodeStage.AdvancedFPSCounter.Labels.LabelEffect background, CodeStage.AdvancedFPSCounter.Labels.LabelEffect shadow, CodeStage.AdvancedFPSCounter.Labels.LabelEffect outline, UnityEngine.Font font, int fontSize, float lineSpacing, UnityEngine.Vector2 pixelOffset);
                /*0x26d07dc*/ void CheckAndUpdate();
                /*0x26cd21c*/ void Clear();
                /*0x26d0760*/ void Destroy();
                /*0x26ce3d4*/ void ChangeFont(UnityEngine.Font labelsFont);
                /*0x26ce4a8*/ void ChangeFontSize(int newSize);
                /*0x26ce870*/ void ChangeOffset(UnityEngine.Vector2 newPixelOffset);
                /*0x26ce648*/ void ChangeLineSpacing(float newValueLineSpacing);
                /*0x26cd934*/ void ChangeBackground(bool enabled);
                /*0x26cda44*/ void ChangeBackgroundColor(UnityEngine.Color color);
                /*0x26cdb1c*/ void ChangeBackgroundPadding(int backgroundPadding);
                /*0x26cdbf0*/ void ChangeShadow(bool enabled);
                /*0x26cdd00*/ void ChangeShadowColor(UnityEngine.Color color);
                /*0x26cddf4*/ void ChangeShadowDistance(UnityEngine.Vector2 distance);
                /*0x26cdec8*/ void ChangeOutline(bool enabled);
                /*0x26cdfd8*/ void ChangeOutlineColor(UnityEngine.Color color);
                /*0x26ce0cc*/ void ChangeOutlineDistance(UnityEngine.Vector2 distance);
                /*0x26e2e58*/ void UpdateTextPosition();
                /*0x26e296c*/ void NormalizeOffset();
                /*0x26e31d8*/ void ApplyBackground();
                /*0x26e29d0*/ void ApplyShadow();
                /*0x26e2b90*/ void ApplyOutline();
                /*0x26e2d50*/ void ApplyFont();
            }

            enum LabelAnchor
            {
                UpperLeft = 0,
                UpperRight = 1,
                LowerLeft = 2,
                LowerRight = 3,
                UpperCenter = 4,
                LowerCenter = 5,
            }

            class LabelEffect
            {
                /*0x10*/ bool enabled;
                /*0x14*/ UnityEngine.Color color;
                /*0x24*/ UnityEngine.Vector2 distance;
                /*0x2c*/ int padding;

                /*0x2b08eec*/ LabelEffect(bool enabled, UnityEngine.Color color, int padding);
                /*0x2b08f74*/ LabelEffect(bool enabled, UnityEngine.Color color, UnityEngine.Vector2 distance);
            }
        }

        namespace CountersData
        {
            class BaseCounterData
            {
                static string BoldStart = "<b>";
                static string BoldEnd = "</b>";
                static string ItalicStart = "<i>";
                static string ItalicEnd = "</i>";
                /*0x10*/ System.Text.StringBuilder text;
                /*0x18*/ bool dirty;
                /*0x20*/ CodeStage.AdvancedFPSCounter.AFPSCounter main;
                /*0x28*/ string colorCached;
                /*0x30*/ bool inited;
                /*0x31*/ bool enabled;
                /*0x32*/ CodeStage.AdvancedFPSCounter.Labels.LabelAnchor anchor;
                /*0x34*/ UnityEngine.Color color;
                /*0x44*/ UnityEngine.FontStyle style;
                /*0x48*/ string extraText;

                /*0x26d1630*/ BaseCounterData();
                /*0x26d1024*/ bool get_Enabled();
                /*0x26d102c*/ void set_Enabled(bool value);
                /*0x26d10a8*/ CodeStage.AdvancedFPSCounter.Labels.LabelAnchor get_Anchor();
                /*0x26d10b0*/ void set_Anchor(CodeStage.AdvancedFPSCounter.Labels.LabelAnchor value);
                /*0x26d1124*/ UnityEngine.Color get_Color();
                /*0x26d1130*/ void set_Color(UnityEngine.Color value);
                /*0x26d1234*/ UnityEngine.FontStyle get_Style();
                /*0x26d123c*/ void set_Style(UnityEngine.FontStyle value);
                /*0x26d1290*/ string get_ExtraText();
                /*0x26d1298*/ void set_ExtraText(string value);
                /*0x26d11d8*/ void Refresh();
                /*0x26d12f0*/ void UpdateValue();
                void UpdateValue(bool force);
                /*0x26d1300*/ void Init(CodeStage.AdvancedFPSCounter.AFPSCounter reference);
                /*0x26d0714*/ void Destroy();
                /*0x26d1308*/ void Activate();
                /*0x26d140c*/ void Deactivate();
                /*0x26d146c*/ void PerformInitActions();
                /*0x26d1470*/ void PerformActivationActions();
                /*0x26d1474*/ void PerformDeActivationActions();
                bool HasData();
                void CacheCurrentColor();
                /*0x26d1478*/ void ApplyTextStyles();
            }

            class StaticCounterData : CodeStage.AdvancedFPSCounter.CountersData.BaseCounterData
            {
                /*0x2b09cc4*/ StaticCounterData();
                /*0x2b09c80*/ void Activate();
            }

            class UpdatableCounterData : CodeStage.AdvancedFPSCounter.CountersData.BaseCounterData
            {
                /*0x50*/ UnityEngine.Coroutine updateCoroutine;
                /*0x58*/ float updateInterval;

                /*0x2b092dc*/ UpdatableCounterData();
                /*0x2b09d94*/ float get_UpdateInterval();
                /*0x2b09d9c*/ void set_UpdateInterval(float value);
                /*0x2b09e2c*/ void PerformInitActions();
                /*0x2b09b18*/ void PerformDeActivationActions();
                System.Collections.IEnumerator UpdateCounter();
                /*0x2b09e54*/ void StartUpdateCoroutine();
                /*0x2b09ea0*/ void StopUpdateCoroutine();
            }

            class DeviceInfoCounterData : CodeStage.AdvancedFPSCounter.CountersData.StaticCounterData
            {
                /*0x50*/ bool platform;
                /*0x51*/ bool cpuModel;
                /*0x52*/ bool cpuModelNewLine;
                /*0x53*/ bool gpuModel;
                /*0x54*/ bool gpuModelNewLine;
                /*0x55*/ bool gpuApi;
                /*0x56*/ bool gpuApiNewLine;
                /*0x57*/ bool gpuSpec;
                /*0x58*/ bool gpuSpecNewLine;
                /*0x59*/ bool ramSize;
                /*0x5a*/ bool ramSizeNewLine;
                /*0x5b*/ bool screenData;
                /*0x5c*/ bool screenDataNewLine;
                /*0x5d*/ bool deviceModel;
                /*0x5e*/ bool deviceModelNewLine;
                /*0x60*/ string <LastValue>k__BackingField;

                /*0x26cedf4*/ DeviceInfoCounterData();
                /*0x26e18e4*/ bool get_Platform();
                /*0x26e18ec*/ void set_Platform(bool value);
                /*0x26e194c*/ bool get_CpuModel();
                /*0x26e1954*/ void set_CpuModel(bool value);
                /*0x26e19b4*/ bool get_CpuModelNewLine();
                /*0x26e19bc*/ void set_CpuModelNewLine(bool value);
                /*0x26e1a1c*/ bool get_GpuModel();
                /*0x26e1a24*/ void set_GpuModel(bool value);
                /*0x26e1a84*/ bool get_GpuModelNewLine();
                /*0x26e1a8c*/ void set_GpuModelNewLine(bool value);
                /*0x26e1aec*/ bool get_GpuApi();
                /*0x26e1af4*/ void set_GpuApi(bool value);
                /*0x26e1b54*/ bool get_GpuApiNewLine();
                /*0x26e1b5c*/ void set_GpuApiNewLine(bool value);
                /*0x26e1bbc*/ bool get_GpuSpec();
                /*0x26e1bc4*/ void set_GpuSpec(bool value);
                /*0x26e1c24*/ bool get_GpuSpecNewLine();
                /*0x26e1c2c*/ void set_GpuSpecNewLine(bool value);
                /*0x26e1c8c*/ bool get_RamSize();
                /*0x26e1c94*/ void set_RamSize(bool value);
                /*0x26e1cf4*/ bool get_RamSizeNewLine();
                /*0x26e1cfc*/ void set_RamSizeNewLine(bool value);
                /*0x26e1d5c*/ bool get_ScreenData();
                /*0x26e1d64*/ void set_ScreenData(bool value);
                /*0x26e1dc4*/ bool get_ScreenDataNewLine();
                /*0x26e1dcc*/ void set_ScreenDataNewLine(bool value);
                /*0x26e1e2c*/ bool get_DeviceModel();
                /*0x26e1e34*/ void set_DeviceModel(bool value);
                /*0x26e1e94*/ bool get_DeviceModelNewLine();
                /*0x26e1e9c*/ void set_DeviceModelNewLine(bool value);
                /*0x26e1efc*/ string get_LastValue();
                /*0x26e1f04*/ void set_LastValue(string value);
                /*0x26e1f0c*/ void UpdateValue(bool force);
                /*0x26e28b0*/ bool HasData();
                /*0x26e28e0*/ void CacheCurrentColor();
            }

            class FPSCounterData : CodeStage.AdvancedFPSCounter.CountersData.UpdatableCounterData
            {
                static string ColorTextStart = "<color=#{0}>";
                static string ColorTextEnd = "</color>";
                static string FPSTextStart = "<color=#{0}>FPS: ";
                static string MsTextStart = " <color=#{0}>[";
                static string MsTextEnd = " MS]</color>";
                static string MinTextStart = "<color=#{0}>MIN: ";
                static string MaxTextStart = "<color=#{0}>MAX: ";
                static string AvgTextStart = "<color=#{0}>AVG: ";
                static string RenderTextStart = "<color=#{0}>REN: ";
                /*0x5c*/ int warningLevelValue;
                /*0x60*/ int criticalLevelValue;
                /*0x64*/ bool resetAverageOnNewScene;
                /*0x65*/ bool resetMinMaxOnNewScene;
                /*0x68*/ int minMaxIntervalsToSkip;
                /*0x70*/ System.Action<CodeStage.AdvancedFPSCounter.FPSLevel> OnFPSLevelChange;
                /*0x78*/ float newValue;
                /*0x80*/ string colorCachedMs;
                /*0x88*/ string colorCachedMin;
                /*0x90*/ string colorCachedMax;
                /*0x98*/ string colorCachedAvg;
                /*0xa0*/ string colorCachedRender;
                /*0xa8*/ string colorWarningCached;
                /*0xb0*/ string colorWarningCachedMs;
                /*0xb8*/ string colorWarningCachedMin;
                /*0xc0*/ string colorWarningCachedMax;
                /*0xc8*/ string colorWarningCachedAvg;
                /*0xd0*/ string colorCriticalCached;
                /*0xd8*/ string colorCriticalCachedMs;
                /*0xe0*/ string colorCriticalCachedMin;
                /*0xe8*/ string colorCriticalCachedMax;
                /*0xf0*/ string colorCriticalCachedAvg;
                /*0xf8*/ int currentAverageSamples;
                /*0xfc*/ float currentAverageRaw;
                /*0x100*/ int minMaxIntervalsSkipped;
                /*0x104*/ float renderTimeBank;
                /*0x108*/ int previousFrameCount;
                /*0x10c*/ bool realtimeFPS;
                /*0x10d*/ bool milliseconds;
                /*0x10e*/ bool average;
                /*0x10f*/ bool averageMilliseconds;
                /*0x110*/ bool averageNewLine;
                /*0x114*/ int averageSamples;
                /*0x118*/ bool minMax;
                /*0x119*/ bool minMaxMilliseconds;
                /*0x11a*/ bool minMaxNewLine;
                /*0x11b*/ bool minMaxTwoLines;
                /*0x11c*/ bool render;
                /*0x11d*/ bool renderNewLine;
                /*0x11e*/ bool renderAutoAdd;
                /*0x120*/ UnityEngine.Color colorWarning;
                /*0x130*/ UnityEngine.Color colorCritical;
                /*0x140*/ UnityEngine.Color colorRender;
                /*0x150*/ int <LastValue>k__BackingField;
                /*0x154*/ float <LastMillisecondsValue>k__BackingField;
                /*0x158*/ float <LastRenderValue>k__BackingField;
                /*0x15c*/ int <LastAverageValue>k__BackingField;
                /*0x160*/ float <LastAverageMillisecondsValue>k__BackingField;
                /*0x164*/ int <LastMinimumValue>k__BackingField;
                /*0x168*/ int <LastMaximumValue>k__BackingField;
                /*0x16c*/ float <LastMinMillisecondsValue>k__BackingField;
                /*0x170*/ float <LastMaxMillisecondsValue>k__BackingField;
                /*0x174*/ CodeStage.AdvancedFPSCounter.FPSLevel <CurrentFpsLevel>k__BackingField;

                static /*0x26e3d24*/ void TryToAddRenderRecorder();
                static /*0x26e3c20*/ void TryToRemoveRenderRecorder();
                /*0x26cec88*/ FPSCounterData();
                /*0x26e3514*/ void add_OnFPSLevelChange(System.Action<CodeStage.AdvancedFPSCounter.FPSLevel> value);
                /*0x26e35b4*/ void remove_OnFPSLevelChange(System.Action<CodeStage.AdvancedFPSCounter.FPSLevel> value);
                /*0x26e3654*/ bool get_RealtimeFPS();
                /*0x26e365c*/ void set_RealtimeFPS(bool value);
                /*0x26e36c4*/ bool get_Milliseconds();
                /*0x26e36cc*/ void set_Milliseconds(bool value);
                /*0x26e3734*/ bool get_Average();
                /*0x26e373c*/ void set_Average(bool value);
                /*0x26e380c*/ bool get_AverageMilliseconds();
                /*0x26e3814*/ void set_AverageMilliseconds(bool value);
                /*0x26e387c*/ bool get_AverageNewLine();
                /*0x26e3884*/ void set_AverageNewLine(bool value);
                /*0x26e38e4*/ int get_AverageSamples();
                /*0x26e38ec*/ void set_AverageSamples(int value);
                /*0x26e3968*/ bool get_MinMax();
                /*0x26e3970*/ void set_MinMax(bool value);
                /*0x26e3a30*/ bool get_MinMaxMilliseconds();
                /*0x26e3a38*/ void set_MinMaxMilliseconds(bool value);
                /*0x26e3ac0*/ bool get_MinMaxNewLine();
                /*0x26e3ac8*/ void set_MinMaxNewLine(bool value);
                /*0x26e3b28*/ bool get_MinMaxTwoLines();
                /*0x26e3b30*/ void set_MinMaxTwoLines(bool value);
                /*0x26e3b90*/ bool get_Render();
                /*0x26e3b98*/ void set_Render(bool value);
                /*0x26e3e30*/ bool get_RenderNewLine();
                /*0x26e3e38*/ void set_RenderNewLine(bool value);
                /*0x26e3e98*/ bool get_RenderAutoAdd();
                /*0x26e3ea0*/ void set_RenderAutoAdd(bool value);
                /*0x26e3f04*/ UnityEngine.Color get_ColorWarning();
                /*0x26e3f18*/ void set_ColorWarning(UnityEngine.Color value);
                /*0x26e40e8*/ UnityEngine.Color get_ColorCritical();
                /*0x26e40fc*/ void set_ColorCritical(UnityEngine.Color value);
                /*0x26e42cc*/ UnityEngine.Color get_ColorRender();
                /*0x26e42e0*/ void set_ColorRender(UnityEngine.Color value);
                /*0x26e4398*/ int get_LastValue();
                /*0x26e43a0*/ void set_LastValue(int value);
                /*0x26e43a8*/ float get_LastMillisecondsValue();
                /*0x26e43b0*/ void set_LastMillisecondsValue(float value);
                /*0x26e43b8*/ float get_LastRenderValue();
                /*0x26e43c0*/ void set_LastRenderValue(float value);
                /*0x26e43c8*/ int get_LastAverageValue();
                /*0x26e43d0*/ void set_LastAverageValue(int value);
                /*0x26e43d8*/ float get_LastAverageMillisecondsValue();
                /*0x26e43e0*/ void set_LastAverageMillisecondsValue(float value);
                /*0x26e43e8*/ int get_LastMinimumValue();
                /*0x26e43f0*/ void set_LastMinimumValue(int value);
                /*0x26e43f8*/ int get_LastMaximumValue();
                /*0x26e4400*/ void set_LastMaximumValue(int value);
                /*0x26e4408*/ float get_LastMinMillisecondsValue();
                /*0x26e4410*/ void set_LastMinMillisecondsValue(float value);
                /*0x26e4418*/ float get_LastMaxMillisecondsValue();
                /*0x26e4420*/ void set_LastMaxMillisecondsValue(float value);
                /*0x26e4428*/ CodeStage.AdvancedFPSCounter.FPSLevel get_CurrentFpsLevel();
                /*0x26e4430*/ void set_CurrentFpsLevel(CodeStage.AdvancedFPSCounter.FPSLevel value);
                /*0x26e37c8*/ void ResetAverage();
                /*0x26e39dc*/ void ResetMinMax();
                /*0x26d0234*/ void OnLevelLoadedCallback();
                /*0x26d0ffc*/ void AddRenderTime(float time);
                /*0x26e4438*/ void UpdateValue(bool force);
                /*0x26e4e14*/ void PerformActivationActions();
                /*0x26e4ecc*/ void PerformDeActivationActions();
                /*0x26e4f28*/ System.Collections.IEnumerator UpdateCounter();
                /*0x26e4f94*/ bool HasData();
                /*0x26e4f9c*/ void CacheCurrentColor();
                /*0x26e3fc8*/ void CacheWarningColor();
                /*0x26e41ac*/ void CacheCriticalColor();

                class <UpdateCounter>d__150 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ CodeStage.AdvancedFPSCounter.CountersData.FPSCounterData <>4__this;
                    /*0x28*/ float <previousUpdateTime>5__2;
                    /*0x2c*/ int <previousUpdateFrames>5__3;

                    /*0x2b09ec4*/ <UpdateCounter>d__150(int <>1__state);
                    /*0x2b09ef0*/ void System.IDisposable.Dispose();
                    /*0x2b09ef4*/ bool MoveNext();
                    /*0x2b09fe8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2b09ff0*/ void System.Collections.IEnumerator.Reset();
                    /*0x2b0a030*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class MemoryCounterData : CodeStage.AdvancedFPSCounter.CountersData.UpdatableCounterData
            {
                static long MemoryDivider = 1048576;
                static string TextStart = "<color=#{0}>";
                static string LineStartTotal = "MEM TOTAL: ";
                static string LineStartAllocated = "MEM ALLOC: ";
                static string LineStartMono = "MEM MONO: ";
                static string LineEnd = " MB";
                static string TextEnd = "</color>";
                /*0x5c*/ bool precise;
                /*0x5d*/ bool total;
                /*0x5e*/ bool allocated;
                /*0x5f*/ bool monoUsage;
                /*0x60*/ bool gfx;
                /*0x68*/ long <LastTotalValue>k__BackingField;
                /*0x70*/ long <LastAllocatedValue>k__BackingField;
                /*0x78*/ long <LastMonoValue>k__BackingField;
                /*0x80*/ long <LastGfxValue>k__BackingField;

                /*0x2b0925c*/ MemoryCounterData();
                /*0x2b08fe0*/ bool get_Precise();
                /*0x2b08fe8*/ void set_Precise(bool value);
                /*0x2b0904c*/ bool get_Total();
                /*0x2b09054*/ void set_Total(bool value);
                /*0x2b090c0*/ bool get_Allocated();
                /*0x2b090c8*/ void set_Allocated(bool value);
                /*0x2b09134*/ bool get_MonoUsage();
                /*0x2b0913c*/ void set_MonoUsage(bool value);
                /*0x2b091a8*/ bool get_Gfx();
                /*0x2b091b0*/ void set_Gfx(bool value);
                /*0x2b0921c*/ long get_LastTotalValue();
                /*0x2b09224*/ void set_LastTotalValue(long value);
                /*0x2b0922c*/ long get_LastAllocatedValue();
                /*0x2b09234*/ void set_LastAllocatedValue(long value);
                /*0x2b0923c*/ long get_LastMonoValue();
                /*0x2b09244*/ void set_LastMonoValue(long value);
                /*0x2b0924c*/ long get_LastGfxValue();
                /*0x2b09254*/ void set_LastGfxValue(long value);
                /*0x2b092ec*/ void UpdateValue(bool force);
                /*0x2b097d0*/ void PerformActivationActions();
                /*0x2b09ac4*/ void PerformDeActivationActions();
                /*0x2b09b40*/ System.Collections.IEnumerator UpdateCounter();
                /*0x2b09bd8*/ bool HasData();
                /*0x2b09c08*/ void CacheCurrentColor();

                class <UpdateCounter>d__47 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ CodeStage.AdvancedFPSCounter.CountersData.MemoryCounterData <>4__this;
                    /*0x28*/ float <previousUpdateTime>5__2;

                    /*0x2b09bac*/ <UpdateCounter>d__47(int <>1__state);
                    /*0x2b0a038*/ void System.IDisposable.Dispose();
                    /*0x2b0a03c*/ bool MoveNext();
                    /*0x2b0a0f4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2b0a0fc*/ void System.Collections.IEnumerator.Reset();
                    /*0x2b0a13c*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }
    }
}
