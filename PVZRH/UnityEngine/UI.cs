class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x16b9e60*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
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

namespace UnityEngine
{
    namespace UI
    {
        class AnimationTriggers
        {
            static string kDefaultNormalAnimName = "Normal";
            static string kDefaultHighlightedAnimName = "Highlighted";
            static string kDefaultPressedAnimName = "Pressed";
            static string kDefaultSelectedAnimName = "Selected";
            static string kDefaultDisabledAnimName = "Disabled";
            /*0x10*/ string m_NormalTrigger;
            /*0x18*/ string m_HighlightedTrigger;
            /*0x20*/ string m_PressedTrigger;
            /*0x28*/ string m_SelectedTrigger;
            /*0x30*/ string m_DisabledTrigger;

            /*0x169efd0*/ AnimationTriggers();
            /*0x73d3e0*/ string get_normalTrigger();
            /*0x9f12f0*/ void set_normalTrigger(string value);
            /*0x32f410*/ string get_highlightedTrigger();
            /*0x7963c0*/ void set_highlightedTrigger(string value);
            /*0x61a260*/ string get_pressedTrigger();
            /*0x7965a0*/ void set_pressedTrigger(string value);
            /*0x79a150*/ string get_selectedTrigger();
            /*0x98b030*/ void set_selectedTrigger(string value);
            /*0x997630*/ string get_disabledTrigger();
            /*0x997640*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0x100*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x169f2e0*/ Button();
            /*0x136fc90*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x136fd50*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x169f250*/ void Press();
            /*0x169f140*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x169f170*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x169f0d0*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x169f0c0*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x32f460*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x16b9ae0*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x16b9c10*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        enum CanvasUpdate
        {
            Prelayout = 0,
            Layout = 1,
            PostLayout = 2,
            PreRender = 3,
            LatePreRender = 4,
            MaxUpdateValue = 5,
        }

        interface ICanvasElement
        {
            /*0x17aa40*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x1803b0*/ UnityEngine.Transform get_transform();
            /*0x180fc0*/ void LayoutComplete();
            /*0x180fc0*/ void GraphicUpdateComplete();
            /*0x17cb40*/ bool IsDestroyed();
        }

        class CanvasUpdateRegistry
        {
            static string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
            static /*0x0*/ UnityEngine.UI.CanvasUpdateRegistry s_Instance;
            static /*0x8*/ System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction;
            /*0x10*/ bool m_PerformingLayoutUpdate;
            /*0x11*/ bool m_PerformingGraphicUpdate;
            /*0x18*/ string[] m_CanvasUpdateProfilerStrings;
            /*0x20*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
            /*0x28*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;

            static /*0x16a0a50*/ CanvasUpdateRegistry();
            static /*0x16a0cf0*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x169fe70*/ int ParentCount(UnityEngine.Transform child);
            static /*0x16a06a0*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x16a0640*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x16a07b0*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x16a05e0*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x16a0750*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x16a0810*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x169f530*/ void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x169fd50*/ bool IsRebuildingLayout();
            static /*0x169fd00*/ bool IsRebuildingGraphics();
            /*0x16a0ae0*/ CanvasUpdateRegistry();
            /*0x169fda0*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x169f370*/ void CleanInvalidItems();
            /*0x169ff40*/ void PerformUpdate();
            /*0x169fa50*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x169f990*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x169fbf0*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x169fae0*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x169f880*/ void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x169f770*/ void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        }

        struct ColorBlock : System.IEquatable<UnityEngine.UI.ColorBlock>
        {
            static /*0x0*/ UnityEngine.UI.ColorBlock defaultColorBlock;
            /*0x10*/ UnityEngine.Color m_NormalColor;
            /*0x20*/ UnityEngine.Color m_HighlightedColor;
            /*0x30*/ UnityEngine.Color m_PressedColor;
            /*0x40*/ UnityEngine.Color m_SelectedColor;
            /*0x50*/ UnityEngine.Color m_DisabledColor;
            /*0x60*/ float m_ColorMultiplier;
            /*0x64*/ float m_FadeDuration;

            static /*0x16a1900*/ ColorBlock();
            static /*0x16a1c40*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x16a1ce0*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0x6bba70*/ UnityEngine.Color get_normalColor();
            /*0xdb4640*/ void set_normalColor(UnityEngine.Color value);
            /*0x8b2880*/ UnityEngine.Color get_highlightedColor();
            /*0x9f0700*/ void set_highlightedColor(UnityEngine.Color value);
            /*0xc53890*/ UnityEngine.Color get_pressedColor();
            /*0x12f4b90*/ void set_pressedColor(UnityEngine.Color value);
            /*0x10daa90*/ UnityEngine.Color get_selectedColor();
            /*0x12f4ba0*/ void set_selectedColor(UnityEngine.Color value);
            /*0xcf6ca0*/ UnityEngine.Color get_disabledColor();
            /*0xcf6cf0*/ void set_disabledColor(UnityEngine.Color value);
            /*0x16a1c30*/ float get_colorMultiplier();
            /*0x1659590*/ void set_colorMultiplier(float value);
            /*0x136fc20*/ float get_fadeDuration();
            /*0x14a59e0*/ void set_fadeDuration(float value);
            /*0x16a1480*/ bool Equals(object obj);
            /*0x16a1570*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0x16a1870*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x16a10c0*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x16a0f70*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x16a0fe0*/ void Unregister(UnityEngine.UI.IClipper c);
            static /*0x16a0f10*/ void Disable(UnityEngine.UI.IClipper c);
            /*0x16a1040*/ ClipperRegistry();
            /*0x16a0dd0*/ void Cull();
        }

        class Clipping
        {
            static /*0x16a11c0*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
        }

        interface IClipper
        {
            /*0x180fc0*/ void PerformClipping();
        }

        interface IClippable
        {
            /*0x1803b0*/ UnityEngine.GameObject get_gameObject();
            /*0x180fc0*/ void RecalculateClipping();
            /*0x1803b0*/ UnityEngine.RectTransform get_rectTransform();
            void Cull(UnityEngine.Rect clipRect, bool validRect);
            void SetClipRect(UnityEngine.Rect value, bool validRect);
            /*0x17aca0*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
        }

        class RectangularVertexClipper
        {
            /*0x10*/ UnityEngine.Vector3[] m_WorldCorners;
            /*0x18*/ UnityEngine.Vector3[] m_CanvasCorners;

            /*0x16b9960*/ RectangularVertexClipper();
            /*0x16b9790*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
        }

        class DefaultControls
        {
            static float kWidth = 160;
            static float kThickHeight = 30;
            static float kThinHeight = 20;
            static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls m_CurrentFactory;
            static /*0x8*/ UnityEngine.Vector2 s_ThickElementSize;
            static /*0x10*/ UnityEngine.Vector2 s_ThinElementSize;
            static /*0x18*/ UnityEngine.Vector2 s_ImageElementSize;
            static /*0x20*/ UnityEngine.Color s_DefaultSelectableColor;
            static /*0x30*/ UnityEngine.Color s_PanelColor;
            static /*0x40*/ UnityEngine.Color s_TextColor;

            static /*0x16a7340*/ DefaultControls();
            static /*0x16a7460*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x16a6e60*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x16a6f70*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x16a70a0*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x16a7050*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x16a7260*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x16a7180*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x16a44d0*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a1d80*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a6520*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a3b50*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a4850*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a5b90*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a5540*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a66e0*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a3ca0*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a22a0*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x16a49a0*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                /*0x177730*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x16a7520*/ DefaultRuntimeFactory();
                /*0x32f970*/ DefaultRuntimeFactory();
                /*0x16a74b0*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            struct Resources
            {
                /*0x10*/ UnityEngine.Sprite standard;
                /*0x18*/ UnityEngine.Sprite background;
                /*0x20*/ UnityEngine.Sprite inputField;
                /*0x28*/ UnityEngine.Sprite knob;
                /*0x30*/ UnityEngine.Sprite checkmark;
                /*0x38*/ UnityEngine.Sprite dropdown;
                /*0x40*/ UnityEngine.Sprite mask;
            }
        }

        class Dropdown : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            static int kHighSortingLayer = 30000;
            static /*0x0*/ UnityEngine.UI.Dropdown.OptionData s_NoOptionData;
            /*0x100*/ UnityEngine.RectTransform m_Template;
            /*0x108*/ UnityEngine.UI.Text m_CaptionText;
            /*0x110*/ UnityEngine.UI.Image m_CaptionImage;
            /*0x118*/ UnityEngine.UI.Text m_ItemText;
            /*0x120*/ UnityEngine.UI.Image m_ItemImage;
            /*0x128*/ int m_Value;
            /*0x130*/ UnityEngine.UI.Dropdown.OptionDataList m_Options;
            /*0x138*/ UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged;
            /*0x140*/ float m_AlphaFadeSpeed;
            /*0x148*/ UnityEngine.GameObject m_Dropdown;
            /*0x150*/ UnityEngine.GameObject m_Blocker;
            /*0x158*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items;
            /*0x160*/ UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner;
            /*0x168*/ bool validTemplate;

            static /*0x16aa9c0*/ Dropdown();
            static /*0x2a5510*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x16aaa40*/ Dropdown();
            /*0x136fc90*/ UnityEngine.RectTransform get_template();
            /*0x16aad10*/ void set_template(UnityEngine.RectTransform value);
            /*0x136fcb0*/ UnityEngine.UI.Text get_captionText();
            /*0x16aac40*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x1355380*/ UnityEngine.UI.Image get_captionImage();
            /*0x16aac10*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x134cc10*/ UnityEngine.UI.Text get_itemText();
            /*0x16aaca0*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x10f4ac0*/ UnityEngine.UI.Image get_itemImage();
            /*0x16aac70*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x16aabe0*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x16aacd0*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x1369450*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x1369480*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x10f4790*/ float get_alphaFadeSpeed();
            /*0x10f4f40*/ void set_alphaFadeSpeed(float value);
            /*0x16aac00*/ int get_value();
            /*0x16aad40*/ void set_value(int value);
            /*0x16a9080*/ void SetValueWithoutNotify(int input);
            /*0x16a9090*/ void Set(int value, bool sendCallback);
            /*0x16a7f70*/ void Awake();
            /*0x16aa900*/ void Start();
            /*0x16a8be0*/ void OnDisable();
            /*0x16a8dc0*/ void RefreshShownValue();
            /*0x16a7d00*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x16a7a00*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x16a7b80*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x16a8080*/ void ClearOptions();
            /*0x16a91c0*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x16a8c90*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16a8c90*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x16a8bd0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x16a98e0*/ void Show();
            /*0x16a8100*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x16a8790*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x16a8650*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x16a87e0*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x16a86b0*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x32d010*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x16a76e0*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x16a7ee0*/ void AlphaFadeList(float duration, float alpha);
            /*0x16a7d70*/ void AlphaFadeList(float duration, float start, float end);
            /*0x16a8fd0*/ void SetAlpha(float alpha);
            /*0x16a8830*/ void Hide();
            /*0x16a8710*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x16a8a10*/ void ImmediateDestroyDropdownList();
            /*0x16a8ca0*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x20*/ UnityEngine.UI.Text m_Text;
                /*0x28*/ UnityEngine.UI.Image m_Image;
                /*0x30*/ UnityEngine.RectTransform m_RectTransform;
                /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x31c640*/ DropdownItem();
                /*0x61a260*/ UnityEngine.UI.Text get_text();
                /*0x7965a0*/ void set_text(UnityEngine.UI.Text value);
                /*0x79a150*/ UnityEngine.UI.Image get_image();
                /*0x98b030*/ void set_image(UnityEngine.UI.Image value);
                /*0x997630*/ UnityEngine.RectTransform get_rectTransform();
                /*0x997640*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x995140*/ UnityEngine.UI.Toggle get_toggle();
                /*0xe5a080*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x16a7660*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x16a75d0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x32f970*/ OptionData();
                /*0x49b490*/ OptionData(string text);
                /*0xe78ae0*/ OptionData(UnityEngine.Sprite image);
                /*0xce3b90*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x73d3e0*/ string get_text();
                /*0x9f12f0*/ void set_text(string value);
                /*0x32f410*/ UnityEngine.Sprite get_image();
                /*0x7963c0*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x16b9710*/ OptionDataList();
                /*0x73d3e0*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x9f12f0*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x16a7590*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x32f970*/ <>c__DisplayClass63_0();
                /*0x16b9cc0*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x32f460*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x16b99e0*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x16b9aa0*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FontData : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Font m_Font;
            /*0x18*/ int m_FontSize;
            /*0x1c*/ UnityEngine.FontStyle m_FontStyle;
            /*0x20*/ bool m_BestFit;
            /*0x24*/ int m_MinSize;
            /*0x28*/ int m_MaxSize;
            /*0x2c*/ UnityEngine.TextAnchor m_Alignment;
            /*0x30*/ bool m_AlignByGeometry;
            /*0x31*/ bool m_RichText;
            /*0x34*/ UnityEngine.HorizontalWrapMode m_HorizontalOverflow;
            /*0x38*/ UnityEngine.VerticalWrapMode m_VerticalOverflow;
            /*0x3c*/ float m_LineSpacing;

            static /*0x16aada0*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x32f970*/ FontData();
            /*0x73d3e0*/ UnityEngine.Font get_font();
            /*0x9f12f0*/ void set_font(UnityEngine.Font value);
            /*0x8a5c20*/ int get_fontSize();
            /*0x8a5c50*/ void set_fontSize(int value);
            /*0xc70b00*/ UnityEngine.FontStyle get_fontStyle();
            /*0xc70b50*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x796120*/ bool get_bestFit();
            /*0x7963b0*/ void set_bestFit(bool value);
            /*0x3e3ad0*/ int get_minSize();
            /*0xc70b30*/ void set_minSize(int value);
            /*0x3e3ae0*/ int get_maxSize();
            /*0xc6dab0*/ void set_maxSize(int value);
            /*0xbe6c70*/ UnityEngine.TextAnchor get_alignment();
            /*0xbe6cd0*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x995050*/ bool get_alignByGeometry();
            /*0x995180*/ void set_alignByGeometry(bool value);
            /*0x14f46c0*/ bool get_richText();
            /*0x16aae20*/ void set_richText(bool value);
            /*0x995160*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x9952f0*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0xeab1d0*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x12d8f70*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x129f7b0*/ float get_lineSpacing();
            /*0x136a120*/ void set_lineSpacing(float value);
            /*0x32d010*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x16aad50*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x16ab400*/ FontUpdateTracker();
            static /*0x16aafa0*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x16aae30*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x16ab1f0*/ void UntrackText(UnityEngine.UI.Text t);
        }

        class Graphic : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultUI;
            static /*0x8*/ UnityEngine.Texture2D s_WhiteTexture;
            static /*0x10*/ UnityEngine.Mesh s_Mesh;
            static /*0x18*/ UnityEngine.UI.VertexHelper s_VertexHelper;
            /*0x20*/ UnityEngine.Material m_Material;
            /*0x28*/ UnityEngine.Color m_Color;
            /*0x38*/ bool m_SkipLayoutUpdate;
            /*0x39*/ bool m_SkipMaterialUpdate;
            /*0x3a*/ bool m_RaycastTarget;
            /*0x3b*/ bool m_RaycastTargetCache;
            /*0x3c*/ UnityEngine.Vector4 m_RaycastPadding;
            /*0x50*/ UnityEngine.RectTransform m_RectTransform;
            /*0x58*/ UnityEngine.CanvasRenderer m_CanvasRenderer;
            /*0x60*/ UnityEngine.Canvas m_Canvas;
            /*0x68*/ bool m_VertsDirty;
            /*0x69*/ bool m_MaterialDirty;
            /*0x70*/ UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback;
            /*0x78*/ UnityEngine.Events.UnityAction m_OnDirtyVertsCallback;
            /*0x80*/ UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback;
            /*0x88*/ UnityEngine.Mesh m_CachedMesh;
            /*0x90*/ UnityEngine.Vector2[] m_CachedUvs;
            /*0x98*/ UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner;
            /*0xa0*/ bool <useLegacyMeshGeneration>k__BackingField;

            static /*0x16b0b00*/ Graphic();
            static /*0x16b0db0*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x16b1320*/ UnityEngine.Mesh get_workerMesh();
            static /*0x16adfc0*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x16b0bd0*/ Graphic();
            /*0xa75be0*/ UnityEngine.Color get_color();
            /*0x16b1470*/ void set_color(UnityEngine.Color value);
            /*0xe69700*/ bool get_raycastTarget();
            /*0x16b1570*/ void set_raycastTarget(bool value);
            /*0x16b12b0*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x16b1560*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x9c7a40*/ bool get_useLegacyMeshGeneration();
            /*0x9c7a60*/ void set_useLegacyMeshGeneration(bool value);
            /*0x16b0430*/ void SetAllDirty();
            /*0x16b04a0*/ void SetLayoutDirty();
            /*0x16b0740*/ void SetVerticesDirty();
            /*0x16b0580*/ void SetMaterialDirty();
            /*0x16b0660*/ void SetRaycastDirty();
            /*0x16afac0*/ void OnRectTransformDimensionsChange();
            /*0x16aeff0*/ void OnBeforeTransformParentChanged();
            /*0x16afbb0*/ void OnTransformParentChanged();
            /*0x16b0fd0*/ int get_depth();
            /*0x16b12c0*/ UnityEngine.RectTransform get_rectTransform();
            /*0x16b0d40*/ UnityEngine.Canvas get_canvas();
            /*0x16ade40*/ void CacheCanvas();
            /*0x16b0ca0*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x16b0eb0*/ UnityEngine.Material get_defaultMaterial();
            /*0x16b1220*/ UnityEngine.Material get_material();
            /*0x16b14c0*/ void set_material(UnityEngine.Material value);
            /*0x16b1050*/ UnityEngine.Material get_materialForRendering();
            /*0x16b1000*/ UnityEngine.Texture get_mainTexture();
            /*0x16af680*/ void OnEnable();
            /*0x16af4c0*/ void OnDisable();
            /*0x16af340*/ void OnDestroy();
            /*0x16af110*/ void OnCanvasHierarchyChanged();
            /*0x16af270*/ void OnCullingChanged();
            /*0x16b0160*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x32d010*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x16b0a30*/ void UpdateMaterial();
            /*0x16b0a10*/ void UpdateGeometry();
            /*0x16ae8c0*/ void DoMeshGeneration();
            /*0x16ae3d0*/ void DoLegacyMeshGeneration();
            /*0x32d010*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x16af810*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x16af8b0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x16af4a0*/ void OnDidApplyAnimationProperties();
            /*0x32d010*/ void SetNativeSize();
            /*0x16afe00*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x16afc70*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x16aee00*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x16ae390*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x16ae0b0*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x16adfe0*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x16b0240*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x16b0820*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x16b0390*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x16b0970*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x16b02e0*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x16b08c0*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
        }

        class GraphicRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics;
            /*0x28*/ bool m_IgnoreReversedGraphics;
            /*0x2c*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects;
            /*0x30*/ UnityEngine.LayerMask m_BlockingMask;
            /*0x38*/ UnityEngine.Canvas m_Canvas;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults;

            static /*0x16ac910*/ GraphicRaycaster();
            static /*0x16ab490*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x16ac9a0*/ GraphicRaycaster();
            /*0x16acbe0*/ int get_sortOrderPriority();
            /*0x16acb80*/ int get_renderOrderPriority();
            /*0x4ba480*/ bool get_ignoreReversedGraphics();
            /*0xd18990*/ void set_ignoreReversedGraphics(bool value);
            /*0xbe6c70*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0xbe6cd0*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0xa79cc0*/ UnityEngine.LayerMask get_blockingMask();
            /*0xa79cd0*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x16aca30*/ UnityEngine.Canvas get_canvas();
            /*0x16aba70*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x16acac0*/ UnityEngine.Camera get_eventCamera();

            enum BlockingObjects
            {
                None = 0,
                TwoD = 1,
                ThreeD = 2,
                All = 3,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.GraphicRaycaster.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.UI.Graphic> <>9__27_0;

                static /*0x16b9df0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x16b9c50*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x16ad9c0*/ GraphicRegistry();
            static /*0x16adbe0*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x16ad250*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x16ad450*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x16ad670*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x16ad830*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x16acc40*/ void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x16acf40*/ void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x16ad0d0*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x16ad190*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x16ada50*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            /*0x180fc0*/ void OnSiblingGraphicEnabledDisabled();
        }

        class Image : UnityEngine.UI.MaskableGraphic, UnityEngine.ISerializationCallbackReceiver, UnityEngine.UI.ILayoutElement, UnityEngine.ICanvasRaycastFilter
        {
            static /*0x0*/ UnityEngine.Material s_ETC1DefaultUI;
            static /*0x8*/ UnityEngine.Vector2[] s_VertScratch;
            static /*0x10*/ UnityEngine.Vector2[] s_UVScratch;
            static /*0x18*/ UnityEngine.Vector3[] s_Xy;
            static /*0x20*/ UnityEngine.Vector3[] s_Uv;
            static /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Image> m_TrackedTexturelessImages;
            static /*0x30*/ bool s_Initialized;
            /*0xe0*/ UnityEngine.Sprite m_Sprite;
            /*0xe8*/ UnityEngine.Sprite m_OverrideSprite;
            /*0xf0*/ UnityEngine.UI.Image.Type m_Type;
            /*0xf4*/ bool m_PreserveAspect;
            /*0xf5*/ bool m_FillCenter;
            /*0xf8*/ UnityEngine.UI.Image.FillMethod m_FillMethod;
            /*0xfc*/ float m_FillAmount;
            /*0x100*/ bool m_FillClockwise;
            /*0x104*/ int m_FillOrigin;
            /*0x108*/ float m_AlphaHitTestMinimumThreshold;
            /*0x10c*/ bool m_Tracked;
            /*0x10d*/ bool m_UseSpriteMesh;
            /*0x110*/ float m_PixelsPerUnitMultiplier;
            /*0x114*/ float m_CachedReferencePixelsPerUnit;

            static /*0x16b80c0*/ Image();
            static /*0x16b8370*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x16b1890*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x16b1650*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x16b6da0*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x16b6ef0*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x16b73d0*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x16b77f0*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x16b7e90*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x16b8280*/ Image();
            /*0x139ece0*/ UnityEngine.Sprite get_sprite();
            /*0x16b9340*/ void set_sprite(UnityEngine.Sprite value);
            /*0x16b1a10*/ void DisableSpriteOptimizations();
            /*0x16b8980*/ UnityEngine.Sprite get_overrideSprite();
            /*0x16b9220*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x16b82e0*/ UnityEngine.Sprite get_activeSprite();
            /*0x10e8be0*/ UnityEngine.UI.Image.Type get_type();
            /*0x16b9630*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x14126a0*/ bool get_preserveAspect();
            /*0x16b92d0*/ void set_preserveAspect(bool value);
            /*0x16b8490*/ bool get_fillCenter();
            /*0x16b9060*/ void set_fillCenter(bool value);
            /*0x16b84a0*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x16b9140*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x1355370*/ float get_fillAmount();
            /*0x16b8fd0*/ void set_fillAmount(float value);
            /*0x1414170*/ bool get_fillClockwise();
            /*0x16b90d0*/ void set_fillClockwise(bool value);
            /*0x16b84b0*/ int get_fillOrigin();
            /*0x16b91b0*/ void set_fillOrigin(int value);
            /*0x16b8470*/ float get_eventAlphaThreshold();
            /*0x16b8e60*/ void set_eventAlphaThreshold(float value);
            /*0x16b8360*/ float get_alphaHitTestMinimumThreshold();
            /*0x16b8d00*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0xbf28b0*/ bool get_useSpriteMesh();
            /*0x16b96a0*/ void set_useSpriteMesh(bool value);
            /*0x16b85b0*/ UnityEngine.Texture get_mainTexture();
            /*0x16b84c0*/ bool get_hasBorder();
            /*0x16b8990*/ float get_pixelsPerUnitMultiplier();
            /*0x16b92a0*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x16b89a0*/ float get_pixelsPerUnit();
            /*0x16b8960*/ float get_multipliedPixelsPerUnit();
            /*0x16b8740*/ UnityEngine.Material get_material();
            /*0x16b14c0*/ void set_material(UnityEngine.Material value);
            /*0x32d010*/ void OnBeforeSerialize();
            /*0x16b67c0*/ void OnAfterDeserialize();
            /*0x16b6c20*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x16b5930*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x16b75d0*/ void SetNativeSize();
            /*0x16b6ad0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x16b7960*/ void TrackSprite();
            /*0x16b6ab0*/ void OnEnable();
            /*0x16b69e0*/ void OnDisable();
            /*0x16b7f10*/ void UpdateMaterial();
            /*0x16b6830*/ void OnCanvasHierarchyChanged();
            /*0x16b2e10*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x16b3c10*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x16b31d0*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x16b41f0*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x16b55d0*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x16b1a20*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x32d010*/ void CalculateLayoutInputHorizontal();
            /*0x32d010*/ void CalculateLayoutInputVertical();
            /*0x1301790*/ float get_minWidth();
            /*0x16b8bf0*/ float get_preferredWidth();
            /*0x1474a00*/ float get_flexibleWidth();
            /*0x1301790*/ float get_minHeight();
            /*0x16b8ae0*/ float get_preferredHeight();
            /*0x1474a00*/ float get_flexibleHeight();
            /*0x388e90*/ int get_layoutPriority();
            /*0x16b5ca0*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x16b60f0*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x16b6990*/ void OnDidApplyAnimationProperties();
            /*0x16b7ba0*/ void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0();
            /*0x16b7d50*/ bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1();

            enum Type
            {
                Simple = 0,
                Sliced = 1,
                Tiled = 2,
                Filled = 3,
            }

            enum FillMethod
            {
                Horizontal = 0,
                Vertical = 1,
                Radial90 = 2,
                Radial180 = 3,
                Radial360 = 4,
            }

            enum OriginHorizontal
            {
                Left = 0,
                Right = 1,
            }

            enum OriginVertical
            {
                Bottom = 0,
                Top = 1,
            }

            enum Origin90
            {
                BottomLeft = 0,
                TopLeft = 1,
                TopRight = 2,
                BottomRight = 3,
            }

            enum Origin180
            {
                Bottom = 0,
                Left = 1,
                Top = 2,
                Right = 3,
            }

            enum Origin360
            {
                Bottom = 0,
                Right = 1,
                Top = 2,
                Left = 3,
            }
        }

        interface IMask
        {
            /*0x17cb40*/ bool Enabled();
            /*0x1803b0*/ UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            /*0x180fc0*/ void RecalculateMasking();
        }

        class InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement
        {
            static float kHScrollSpeed = 0.05000000074505806;
            static float kVScrollSpeed = 0.10000000149011612;
            static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
            static string kOculusQuestDeviceModel = "Oculus Quest";
            static int k_MaxTextLength = 16382;
            static /*0x0*/ char[] kSeparators;
            static /*0x8*/ bool s_IsQuestDevice;
            /*0x100*/ UnityEngine.TouchScreenKeyboard m_Keyboard;
            /*0x108*/ UnityEngine.UI.Text m_TextComponent;
            /*0x110*/ UnityEngine.UI.Graphic m_Placeholder;
            /*0x118*/ UnityEngine.UI.InputField.ContentType m_ContentType;
            /*0x11c*/ UnityEngine.UI.InputField.InputType m_InputType;
            /*0x120*/ char m_AsteriskChar;
            /*0x124*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
            /*0x128*/ UnityEngine.UI.InputField.LineType m_LineType;
            /*0x12c*/ bool m_HideMobileInput;
            /*0x130*/ UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation;
            /*0x134*/ int m_CharacterLimit;
            /*0x138*/ UnityEngine.UI.InputField.SubmitEvent m_OnSubmit;
            /*0x140*/ UnityEngine.UI.InputField.EndEditEvent m_OnDidEndEdit;
            /*0x148*/ UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;
            /*0x150*/ UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;
            /*0x158*/ UnityEngine.Color m_CaretColor;
            /*0x168*/ bool m_CustomCaretColor;
            /*0x16c*/ UnityEngine.Color m_SelectionColor;
            /*0x180*/ string m_Text;
            /*0x188*/ float m_CaretBlinkRate;
            /*0x18c*/ int m_CaretWidth;
            /*0x190*/ bool m_ReadOnly;
            /*0x191*/ bool m_ShouldActivateOnSelect;
            /*0x194*/ int m_CaretPosition;
            /*0x198*/ int m_CaretSelectPosition;
            /*0x1a0*/ UnityEngine.RectTransform caretRectTrans;
            /*0x1a8*/ UnityEngine.UIVertex[] m_CursorVerts;
            /*0x1b0*/ UnityEngine.TextGenerator m_InputTextCache;
            /*0x1b8*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
            /*0x1c0*/ bool m_PreventFontCallback;
            /*0x1c8*/ UnityEngine.Mesh m_Mesh;
            /*0x1d0*/ bool m_AllowInput;
            /*0x1d1*/ bool m_ShouldActivateNextUpdate;
            /*0x1d2*/ bool m_UpdateDrag;
            /*0x1d3*/ bool m_DragPositionOutOfBounds;
            /*0x1d4*/ bool m_CaretVisible;
            /*0x1d8*/ UnityEngine.Coroutine m_BlinkCoroutine;
            /*0x1e0*/ float m_BlinkStartTime;
            /*0x1e4*/ int m_DrawStart;
            /*0x1e8*/ int m_DrawEnd;
            /*0x1f0*/ UnityEngine.Coroutine m_DragCoroutine;
            /*0x1f8*/ string m_OriginalText;
            /*0x200*/ bool m_WasCanceled;
            /*0x201*/ bool m_HasDoneFocusTransition;
            /*0x208*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
            /*0x210*/ bool m_TouchKeyboardAllowsInPlaceEditing;
            /*0x211*/ bool m_IsCompositionActive;
            /*0x218*/ UnityEngine.Event m_ProcessingEvent;

            static /*0x1836790*/ InputField();
            static /*0x1836bf0*/ string get_clipboard();
            static /*0x1837850*/ void set_clipboard(string value);
            static /*0x1830630*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x1830570*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x1836830*/ InputField();
            /*0x1836d40*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x1836c30*/ string get_compositionString();
            /*0x1836e60*/ UnityEngine.Mesh get_mesh();
            /*0x1836a90*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x1838000*/ void set_shouldHideMobileInput(bool value);
            /*0x1837380*/ bool get_shouldHideMobileInput();
            /*0x1837ff0*/ void set_shouldActivateOnSelect(bool value);
            /*0x1837320*/ bool get_shouldActivateOnSelect();
            /*0x18373e0*/ string get_text();
            /*0x18382f0*/ void set_text(string value);
            /*0x1834d50*/ void SetTextWithoutNotify(string input);
            /*0x1834d60*/ void SetText(string value, bool sendCallback);
            /*0x1836e40*/ bool get_isFocused();
            /*0x1836b10*/ float get_caretBlinkRate();
            /*0x1837460*/ void set_caretBlinkRate(float value);
            /*0x1474be0*/ int get_caretWidth();
            /*0x18376a0*/ void set_caretWidth(int value);
            /*0x136fcb0*/ UnityEngine.UI.Text get_textComponent();
            /*0x1838050*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x1355380*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x1837e40*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x1836b20*/ UnityEngine.Color get_caretColor();
            /*0x18374d0*/ void set_caretColor(UnityEngine.Color value);
            /*0x1492b90*/ bool get_customCaretColor();
            /*0x1837ae0*/ void set_customCaretColor(bool value);
            /*0x1837310*/ UnityEngine.Color get_selectionColor();
            /*0x1837f10*/ void set_selectionColor(UnityEngine.Color value);
            /*0x1369470*/ UnityEngine.UI.InputField.EndEditEvent get_onEndEdit();
            /*0x1837d00*/ void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value);
            /*0x1369450*/ UnityEngine.UI.InputField.SubmitEvent get_onSubmit();
            /*0x1837d50*/ void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x1474d80*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x1837df0*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x1474d80*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x1837df0*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x1475250*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x1837da0*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x1836be0*/ int get_characterLimit();
            /*0x1837730*/ void set_characterLimit(int value);
            /*0x173c9e0*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x18378a0*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x16aac00*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x1837c20*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x137d930*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x1837b40*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x136fc90*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x1836e50*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x1837bb0*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x134cc20*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x18377e0*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x1837300*/ bool get_readOnly();
            /*0x1837e90*/ void set_readOnly(bool value);
            /*0x1836f20*/ bool get_multiLine();
            /*0x1836a80*/ char get_asteriskChar();
            /*0x1837400*/ void set_asteriskChar(char value);
            /*0x18373f0*/ bool get_wasCanceled();
            /*0x182e130*/ void ClampPos(ref int pos);
            /*0x1836b80*/ int get_caretPositionInternal();
            /*0x1837540*/ void set_caretPositionInternal(int value);
            /*0x1836bb0*/ int get_caretSelectPositionInternal();
            /*0x1837650*/ void set_caretSelectPositionInternal(int value);
            /*0x1836ce0*/ bool get_hasSelection();
            /*0x1836bb0*/ int get_caretPosition();
            /*0x1837590*/ void set_caretPosition(int value);
            /*0x1836b80*/ int get_selectionAnchorPosition();
            /*0x1837ea0*/ void set_selectionAnchorPosition(int value);
            /*0x1836bb0*/ int get_selectionFocusPosition();
            /*0x1837f80*/ void set_selectionFocusPosition(int value);
            /*0x18332a0*/ void OnEnable();
            /*0x1832d40*/ void OnDisable();
            /*0x1832ce0*/ void OnDestroy();
            /*0x182e0c0*/ System.Collections.IEnumerator CaretBlink();
            /*0x18344b0*/ void SetCaretVisible();
            /*0x18343f0*/ void SetCaretActive();
            /*0x1835440*/ void UpdateCaretMaterial();
            /*0x1833750*/ void OnFocus();
            /*0x18341c0*/ void SelectAll();
            /*0x1832880*/ void MoveTextEnd(bool shift);
            /*0x18329a0*/ void MoveTextStart(bool shift);
            /*0x1835260*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x1830b50*/ bool InPlaceEditing();
            /*0x1830ad0*/ bool InPlaceEditingChanged();
            /*0x1830470*/ UnityEngine.RangeInt GetInternalSelection();
            /*0x1835a30*/ void UpdateKeyboardCaret();
            /*0x1835310*/ void UpdateCaretFromKeyboard();
            /*0x1831390*/ void LateUpdate();
            /*0x1833cc0*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x1830850*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x1830220*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x1831fa0*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1832c80*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1832fc0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1832090*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1833520*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1833790*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1830e70*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x1830e10*/ bool IsValidChar(char c);
            /*0x1833ca0*/ void ProcessEvent(UnityEngine.Event e);
            /*0x1833ad0*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1830750*/ string GetSelectedString();
            /*0x182ecb0*/ int FindtNextWordBegin();
            /*0x18325d0*/ void MoveRight(bool shift, bool ctrl);
            /*0x182edb0*/ int FindtPrevWordBegin();
            /*0x1832350*/ void MoveLeft(bool shift, bool ctrl);
            /*0x182e8b0*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x1831d30*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x1831a80*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x1832340*/ void MoveDown(bool shift);
            /*0x1832120*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x1832a90*/ void MoveUp(bool shift);
            /*0x1832aa0*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x182e580*/ void Delete();
            /*0x182eeb0*/ void ForwardSpace();
            /*0x182df00*/ void Backspace();
            /*0x1830b80*/ void Insert(char c);
            /*0x1836000*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x1834350*/ void SendOnValueChangedAndUpdateLabel();
            /*0x1834370*/ void SendOnValueChanged();
            /*0x1834250*/ void SendOnEndEdit();
            /*0x18342d0*/ void SendOnSubmit();
            /*0x182d6d0*/ void Append(string input);
            /*0x182d350*/ void Append(char input);
            /*0x1835b00*/ void UpdateLabel();
            /*0x1830d40*/ bool IsSelectionVisible();
            /*0x18344f0*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x182eea0*/ void ForceLabelUpdate();
            /*0x1831f50*/ void MarkGeometryAsDirty();
            /*0x1833cb0*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x32d010*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x1835550*/ void UpdateGeometry();
            /*0x182d780*/ void AssignPositioningIfNeeded();
            /*0x1833550*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x182f010*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x182e170*/ void CreateCursorVerts();
            /*0x182fad0*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x1836060*/ char Validate(string text, int pos, char ch);
            /*0x182d210*/ void ActivateInputField();
            /*0x182cdb0*/ void ActivateInputFieldInternal();
            /*0x1833a40*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1833760*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x182e330*/ void DeactivateInputField();
            /*0x1832cb0*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1833a80*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x182ea00*/ void EnforceContentType();
            /*0x182ec00*/ void EnforceTextHOverflow();
            /*0x18351d0*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x1835240*/ void SetToCustom();
            /*0x182e9d0*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x32d010*/ void CalculateLayoutInputHorizontal();
            /*0x32d010*/ void CalculateLayoutInputVertical();
            /*0x1836f10*/ float get_minWidth();
            /*0x1837120*/ float get_preferredWidth();
            /*0x1474a00*/ float get_flexibleWidth();
            /*0x1301790*/ float get_minHeight();
            /*0x1836f40*/ float get_preferredHeight();
            /*0x1474a00*/ float get_flexibleHeight();
            /*0x6bba80*/ int get_layoutPriority();
            /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ContentType
            {
                Standard = 0,
                Autocorrected = 1,
                IntegerNumber = 2,
                DecimalNumber = 3,
                Alphanumeric = 4,
                Name = 5,
                EmailAddress = 6,
                Password = 7,
                Pin = 8,
                Custom = 9,
            }

            enum InputType
            {
                Standard = 0,
                AutoCorrect = 1,
                Password = 2,
            }

            enum CharacterValidation
            {
                None = 0,
                Integer = 1,
                Decimal = 2,
                Alphanumeric = 3,
                Name = 4,
                EmailAddress = 5,
            }

            enum LineType
            {
                SingleLine = 0,
                MultiLineSubmit = 1,
                MultiLineNewline = 2,
            }

            class OnValidateInput : System.MulticastDelegate
            {
                /*0x1495390*/ OnValidateInput(object object, nint method);
                /*0x723400*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x183efc0*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x1495360*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x183f060*/ SubmitEvent();
            }

            class EndEditEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x182adf0*/ EndEditEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x183ef80*/ OnChangeEvent();
            }

            enum EditState
            {
                Continue = 0,
                Finish = 1,
            }

            class <CaretBlink>d__170 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.InputField <>4__this;

                /*0x32f460*/ <CaretBlink>d__170(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x183f0a0*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x183f1f0*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__194 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x32f460*/ <MouseDragOutsideRect>d__194(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x183f300*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x183f6c0*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class AspectRatioFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
        {
            /*0x20*/ UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode;
            /*0x24*/ float m_AspectRatio;
            /*0x28*/ UnityEngine.RectTransform m_Rect;
            /*0x30*/ bool m_DelayedSetDirty;
            /*0x31*/ bool m_DoesParentExist;
            /*0x32*/ UnityEngine.DrivenRectTransformTracker m_Tracker;

            /*0x182a020*/ AspectRatioFitter();
            /*0x3e3af0*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x182a0d0*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x182a030*/ float get_aspectRatio();
            /*0x182a130*/ void set_aspectRatio(float value);
            /*0x182a040*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1829a70*/ void OnEnable();
            /*0x1829bc0*/ void Start();
            /*0x18299f0*/ void OnDisable();
            /*0x1829b20*/ void OnTransformParentChanged();
            /*0x182a000*/ void Update();
            /*0x1829b10*/ void OnRectTransformDimensionsChange();
            /*0x1829c10*/ void UpdateRect();
            /*0x1829750*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x1829650*/ UnityEngine.Vector2 GetParentSize();
            /*0x32d010*/ void SetLayoutHorizontal();
            /*0x32d010*/ void SetLayoutVertical();
            /*0x1829b10*/ void SetDirty();
            /*0x1829940*/ bool IsComponentValidOnObject();
            /*0x1829920*/ bool IsAspectModeValid();
            /*0x14f46c0*/ bool DoesParentExists();

            enum AspectMode
            {
                None = 0,
                WidthControlsHeight = 1,
                HeightControlsWidth = 2,
                FitInParent = 3,
                EnvelopeParent = 4,
            }
        }

        class CanvasScaler : UnityEngine.EventSystems.UIBehaviour
        {
            static float kLogBase = 2;
            /*0x20*/ UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode;
            /*0x24*/ float m_ReferencePixelsPerUnit;
            /*0x28*/ float m_ScaleFactor;
            /*0x2c*/ UnityEngine.Vector2 m_ReferenceResolution;
            /*0x34*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode;
            /*0x38*/ float m_MatchWidthOrHeight;
            /*0x3c*/ UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit;
            /*0x40*/ float m_FallbackScreenDPI;
            /*0x44*/ float m_DefaultSpriteDPI;
            /*0x48*/ float m_DynamicPixelsPerUnit;
            /*0x50*/ UnityEngine.Canvas m_Canvas;
            /*0x58*/ float m_PrevScaleFactor;
            /*0x5c*/ float m_PrevReferencePixelsPerUnit;
            /*0x60*/ bool m_PresetInfoIsWorld;

            /*0x182a8d0*/ CanvasScaler();
            /*0x3e3af0*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x11172b0*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x182a030*/ float get_referencePixelsPerUnit();
            /*0x136a070*/ void set_referencePixelsPerUnit(float value);
            /*0x182a940*/ float get_scaleFactor();
            /*0x182a9f0*/ void set_scaleFactor(float value);
            /*0x182a920*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x182a970*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x995160*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x9952f0*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x136e840*/ float get_matchWidthOrHeight();
            /*0x14c88d0*/ void set_matchWidthOrHeight(float value);
            /*0xee1680*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x136a430*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0xcf6cb0*/ float get_fallbackScreenDPI();
            /*0xcf6d00*/ void set_fallbackScreenDPI(float value);
            /*0x129f7a0*/ float get_defaultSpriteDPI();
            /*0x182a950*/ void set_defaultSpriteDPI(float value);
            /*0x136a360*/ float get_dynamicPixelsPerUnit();
            /*0x136a440*/ void set_dynamicPixelsPerUnit(float value);
            /*0x182a790*/ void OnEnable();
            /*0x1040b90*/ void Canvas_preWillRenderCanvases();
            /*0x182a6c0*/ void OnDisable();
            /*0x182a5a0*/ void Handle();
            /*0x182a530*/ void HandleWorldCanvas();
            /*0x182a270*/ void HandleConstantPixelSize();
            /*0x182a2e0*/ void HandleScaleWithScreenSize();
            /*0x182a190*/ void HandleConstantPhysicalSize();
            /*0x182a890*/ void SetScaleFactor(float scaleFactor);
            /*0x182a850*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

            enum ScaleMode
            {
                ConstantPixelSize = 0,
                ScaleWithScreenSize = 1,
                ConstantPhysicalSize = 2,
            }

            enum ScreenMatchMode
            {
                MatchWidthOrHeight = 0,
                Expand = 1,
                Shrink = 2,
            }

            enum Unit
            {
                Centimeters = 0,
                Millimeters = 1,
                Inches = 2,
                Points = 3,
                Picas = 4,
            }
        }

        class ContentSizeFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
        {
            /*0x20*/ UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit;
            /*0x24*/ UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit;
            /*0x28*/ UnityEngine.RectTransform m_Rect;
            /*0x30*/ UnityEngine.DrivenRectTransformTracker m_Tracker;

            /*0x317730*/ ContentSizeFitter();
            /*0x3e3af0*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x182acf0*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x3e3ad0*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x182ad50*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x182ac60*/ UnityEngine.RectTransform get_rectTransform();
            /*0x182ab70*/ void OnEnable();
            /*0x182aaf0*/ void OnDisable();
            /*0x182ab90*/ void OnRectTransformDimensionsChange();
            /*0x182aa10*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x182ac20*/ void SetLayoutHorizontal();
            /*0x182ac50*/ void SetLayoutVertical();
            /*0x182aba0*/ void SetDirty();

            enum FitMode
            {
                Unconstrained = 0,
                MinSize = 1,
                PreferredSize = 2,
            }
        }

        class GridLayoutGroup : UnityEngine.UI.LayoutGroup
        {
            /*0x60*/ UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner;
            /*0x64*/ UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis;
            /*0x68*/ UnityEngine.Vector2 m_CellSize;
            /*0x70*/ UnityEngine.Vector2 m_Spacing;
            /*0x78*/ UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint;
            /*0x7c*/ int m_ConstraintCount;

            /*0x182b980*/ GridLayoutGroup();
            /*0xf91dd0*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x182bbf0*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x12fd4b0*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x182bba0*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x182b9f0*/ UnityEngine.Vector2 get_cellSize();
            /*0x182ba30*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x182ba10*/ UnityEngine.Vector2 get_spacing();
            /*0x182bb40*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x1101d10*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x182baf0*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x137cfa0*/ int get_constraintCount();
            /*0x182ba90*/ void set_constraintCount(int value);
            /*0x182ae30*/ void CalculateLayoutInputHorizontal();
            /*0x182b030*/ void CalculateLayoutInputVertical();
            /*0x182b960*/ void SetLayoutHorizontal();
            /*0x182b970*/ void SetLayoutVertical();
            /*0x182b210*/ void SetCellsAlongAxis(int axis);

            enum Corner
            {
                UpperLeft = 0,
                UpperRight = 1,
                LowerLeft = 2,
                LowerRight = 3,
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }

            enum Constraint
            {
                Flexible = 0,
                FixedColumnCount = 1,
                FixedRowCount = 2,
            }
        }

        class HorizontalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x182bca0*/ HorizontalLayoutGroup();
            /*0x182bc40*/ void CalculateLayoutInputHorizontal();
            /*0x182bc70*/ void CalculateLayoutInputVertical();
            /*0x182bc80*/ void SetLayoutHorizontal();
            /*0x182bc90*/ void SetLayoutVertical();
        }

        class HorizontalOrVerticalLayoutGroup : UnityEngine.UI.LayoutGroup
        {
            /*0x60*/ float m_Spacing;
            /*0x64*/ bool m_ChildForceExpandWidth;
            /*0x65*/ bool m_ChildForceExpandHeight;
            /*0x66*/ bool m_ChildControlWidth;
            /*0x67*/ bool m_ChildControlHeight;
            /*0x68*/ bool m_ChildScaleWidth;
            /*0x69*/ bool m_ChildScaleHeight;
            /*0x6a*/ bool m_ReverseArrangement;

            /*0x182bca0*/ HorizontalOrVerticalLayoutGroup();
            /*0x137d040*/ float get_spacing();
            /*0x182cd60*/ void set_spacing(float value);
            /*0x182cb20*/ bool get_childForceExpandWidth();
            /*0x182cc20*/ void set_childForceExpandWidth(bool value);
            /*0x182cb10*/ bool get_childForceExpandHeight();
            /*0x182cbd0*/ void set_childForceExpandHeight(bool value);
            /*0x182cb00*/ bool get_childControlWidth();
            /*0x182cb80*/ void set_childControlWidth(bool value);
            /*0x182caf0*/ bool get_childControlHeight();
            /*0x182cb30*/ void set_childControlHeight(bool value);
            /*0xe7e580*/ bool get_childScaleWidth();
            /*0x182ccc0*/ void set_childScaleWidth(bool value);
            /*0x10b58f0*/ bool get_childScaleHeight();
            /*0x182cc70*/ void set_childScaleHeight(bool value);
            /*0x10b5900*/ bool get_reverseArrangement();
            /*0x182cd10*/ void set_reverseArrangement(bool value);
            /*0x182bcb0*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x182c1c0*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x182c0b0*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
        }

        interface ILayoutElement
        {
            /*0x180fc0*/ void CalculateLayoutInputHorizontal();
            /*0x180fc0*/ void CalculateLayoutInputVertical();
            /*0x17fc30*/ float get_minWidth();
            /*0x17fc30*/ float get_preferredWidth();
            /*0x17fc30*/ float get_flexibleWidth();
            /*0x17fc30*/ float get_minHeight();
            /*0x17fc30*/ float get_preferredHeight();
            /*0x17fc30*/ float get_flexibleHeight();
            /*0x180980*/ int get_layoutPriority();
        }

        interface ILayoutController
        {
            /*0x180fc0*/ void SetLayoutHorizontal();
            /*0x180fc0*/ void SetLayoutVertical();
        }

        interface ILayoutGroup : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutSelfController : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutIgnorer
        {
            /*0x17cb40*/ bool get_ignoreLayout();
        }

        class LayoutElement : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutIgnorer
        {
            /*0x20*/ bool m_IgnoreLayout;
            /*0x24*/ float m_MinWidth;
            /*0x28*/ float m_MinHeight;
            /*0x2c*/ float m_PreferredWidth;
            /*0x30*/ float m_PreferredHeight;
            /*0x34*/ float m_FlexibleWidth;
            /*0x38*/ float m_FlexibleHeight;
            /*0x3c*/ int m_LayoutPriority;

            /*0x18383f0*/ LayoutElement();
            /*0x796120*/ bool get_ignoreLayout();
            /*0x18384f0*/ void set_ignoreLayout(bool value);
            /*0x32d010*/ void CalculateLayoutInputHorizontal();
            /*0x32d010*/ void CalculateLayoutInputVertical();
            /*0x182a030*/ float get_minWidth();
            /*0x1838610*/ void set_minWidth(float value);
            /*0x182a940*/ float get_minHeight();
            /*0x18385b0*/ void set_minHeight(float value);
            /*0x4ccc40*/ float get_preferredWidth();
            /*0x18386d0*/ void set_preferredWidth(float value);
            /*0x1101d20*/ float get_preferredHeight();
            /*0x1838670*/ void set_preferredHeight(float value);
            /*0x995150*/ float get_flexibleWidth();
            /*0x1838490*/ void set_flexibleWidth(float value);
            /*0x136e840*/ float get_flexibleHeight();
            /*0x1838430*/ void set_flexibleHeight(float value);
            /*0xee1680*/ int get_layoutPriority();
            /*0x1838550*/ void set_layoutPriority(int value);
            /*0x1838330*/ void OnEnable();
            /*0x1838300*/ void OnTransformParentChanged();
            /*0x1838310*/ void OnDisable();
            /*0x1838300*/ void OnDidApplyAnimationProperties();
            /*0x1838300*/ void OnBeforeTransformParentChanged();
            /*0x1838350*/ void SetDirty();
        }

        class LayoutGroup : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x20*/ UnityEngine.RectOffset m_Padding;
            /*0x28*/ UnityEngine.TextAnchor m_ChildAlignment;
            /*0x30*/ UnityEngine.RectTransform m_Rect;
            /*0x38*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x3c*/ UnityEngine.Vector2 m_TotalMinSize;
            /*0x44*/ UnityEngine.Vector2 m_TotalPreferredSize;
            /*0x4c*/ UnityEngine.Vector2 m_TotalFlexibleSize;
            /*0x58*/ System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren;

            /*0x18396e0*/ LayoutGroup();
            /*0x61a260*/ UnityEngine.RectOffset get_padding();
            /*0x1839a90*/ void set_padding(UnityEngine.RectOffset value);
            /*0x3e3ae0*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x1839a40*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x18399b0*/ UnityEngine.RectTransform get_rectTransform();
            /*0xb61940*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x1838730*/ void CalculateLayoutInputHorizontal();
            /*0x180fc0*/ void CalculateLayoutInputVertical();
            /*0x1441630*/ float get_minWidth();
            /*0x1659500*/ float get_preferredWidth();
            /*0x1659530*/ float get_flexibleWidth();
            /*0x1644eb0*/ float get_minHeight();
            /*0x1659510*/ float get_preferredHeight();
            /*0x1659540*/ float get_flexibleHeight();
            /*0x388e90*/ int get_layoutPriority();
            /*0x180fc0*/ void SetLayoutHorizontal();
            /*0x180fc0*/ void SetLayoutVertical();
            /*0x1838d50*/ void OnEnable();
            /*0x1838cd0*/ void OnDisable();
            /*0x1838cc0*/ void OnDidApplyAnimationProperties();
            /*0x1838ca0*/ float GetTotalMinSize(int axis);
            /*0x1838cb0*/ float GetTotalPreferredSize(int axis);
            /*0x1838c90*/ float GetTotalFlexibleSize(int axis);
            /*0x1838b30*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x1838ae0*/ float GetAlignmentOnAxis(int axis);
            /*0x1839650*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x18393d0*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x1839180*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x1839470*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x1838eb0*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x1839880*/ bool get_isRootLayoutGroup();
            /*0x1838d70*/ void OnRectTransformDimensionsChange();
            /*0x1838cc0*/ void OnTransformChildrenChanged();
            /*0x2a5510*/ void SetProperty<T>(ref T currentValue, T newValue);
            /*0x1839520*/ void SetDirty();
            /*0x1838a70*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x32f460*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x183f230*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x183f2c0*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x183b1c0*/ LayoutRebuilder();
            static /*0x183aa90*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x183ae30*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x1839b70*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x1839d90*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x183afb0*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x183a2c0*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x32f970*/ LayoutRebuilder();
            /*0x1839c70*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x1839ae0*/ void Clear();
            /*0x73d3e0*/ UnityEngine.Transform get_transform();
            /*0x1839cc0*/ bool IsDestroyed();
            /*0x183aae0*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x183a6d0*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x183a440*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x1839d10*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x8a5c20*/ int GetHashCode();
            /*0x1839b10*/ bool Equals(object obj);
            /*0x183af50*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x183fce0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x183fbe0*/ UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0();
                /*0x183fc30*/ void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x);
                /*0x183fb40*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x183f980*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x183f9f0*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x183fa60*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x183fad0*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x183bbc0*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x183c0b0*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x183b4a0*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x183bdb0*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x183c440*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x183b690*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x183bab0*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x183bec0*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x183b390*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x183b7a0*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x183b7c0*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutUtility.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__3_0;
                static /*0x10*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__4_0;
                static /*0x18*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__4_1;
                static /*0x20*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__5_0;
                static /*0x28*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__6_0;
                static /*0x30*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__7_0;
                static /*0x38*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__7_1;
                static /*0x40*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__8_0;

                static /*0x183fc70*/ <>c();
                /*0x32f970*/ <>c();
                /*0x183f7f0*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x183f8e0*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x183f930*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x183f750*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x183f7a0*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x183f840*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x183f890*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x183f700*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x182bca0*/ VerticalLayoutGroup();
            /*0x183fd50*/ void CalculateLayoutInputHorizontal();
            /*0x183fd80*/ void CalculateLayoutInputVertical();
            /*0x183fd90*/ void SetLayoutHorizontal();
            /*0x183fda0*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x20*/ UnityEngine.RectTransform m_RectTransform;
            /*0x28*/ bool m_ShowMaskGraphic;
            /*0x30*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x38*/ UnityEngine.Material m_MaskMaterial;
            /*0x40*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x183e120*/ Mask();
            /*0x183e1a0*/ UnityEngine.RectTransform get_rectTransform();
            /*0x4ba480*/ bool get_showMaskGraphic();
            /*0x183e210*/ void set_showMaskGraphic(bool value);
            /*0x183e130*/ UnityEngine.UI.Graphic get_graphic();
            /*0x183da60*/ bool MaskEnabled();
            /*0x32d010*/ void OnSiblingGraphicEnabledDisabled();
            /*0x183de90*/ void OnEnable();
            /*0x183db20*/ void OnDisable();
            /*0x183d970*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x183d660*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class MaskableGraphic : UnityEngine.UI.Graphic, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier
        {
            /*0xa8*/ bool m_ShouldRecalculateStencil;
            /*0xb0*/ UnityEngine.Material m_MaskMaterial;
            /*0xb8*/ UnityEngine.UI.RectMask2D m_ParentMask;
            /*0xc0*/ bool m_Maskable;
            /*0xc1*/ bool m_IsMaskingGraphic;
            /*0xc2*/ bool m_IncludeForMasking;
            /*0xc8*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;
            /*0xd0*/ bool m_ShouldRecalculate;
            /*0xd4*/ int m_StencilValue;
            /*0xd8*/ UnityEngine.Vector3[] m_Corners;

            /*0x183eb50*/ MaskableGraphic();
            /*0x136fca0*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x17b31f0*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x183ec60*/ bool get_maskable();
            /*0x183ef50*/ void set_maskable(bool value);
            /*0x183ec50*/ bool get_isMaskingGraphic();
            /*0x183ef40*/ void set_isMaskingGraphic(bool value);
            /*0x183e460*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x183e2f0*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x183ea80*/ void UpdateCull(bool cull);
            /*0x183e840*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x183e8a0*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x183e6e0*/ void OnEnable();
            /*0x183e620*/ void OnDisable();
            /*0x183e740*/ void OnTransformParentChanged();
            /*0x32d010*/ void ParentMaskStateChanged();
            /*0x183e5c0*/ void OnCanvasHierarchyChanged();
            /*0x183ec70*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x183e8f0*/ void UpdateClipParent();
            /*0x183e7a0*/ void RecalculateClipping();
            /*0x183e7b0*/ void RecalculateMasking();
            /*0x183e8e0*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x182adb0*/ CullStateChangedEvent();
            }
        }

        class MaskUtilities
        {
            static /*0x183d240*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x183d450*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x183c630*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x183ce30*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x183d0d0*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x183c7b0*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x183cae0*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x32f970*/ MaskUtilities();
        }

        interface IMaterialModifier
        {
            /*0x1858d0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x1840770*/ void Destroy(UnityEngine.Object obj);
            static /*0x18406b0*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x1840890*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x1840980*/ UnityEngine.Vector3 GetRelativeMousePositionForRaycast(UnityEngine.EventSystems.PointerEventData eventData);
            static /*0x1840aa0*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position, int displayIndex);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x1841010*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0x6bba50*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0x6bbd40*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0xa5a770*/ bool get_wrapAround();
            /*0x1626cf0*/ void set_wrapAround(bool value);
            /*0xa5a7f0*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0x1659550*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0x73d3e0*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0x9f12f0*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0x32f410*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0x7963c0*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0x61a260*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0x7965a0*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0x1840f00*/ bool Equals(UnityEngine.UI.Navigation other);

            enum Mode
            {
                None = 0,
                Horizontal = 1,
                Vertical = 2,
                Automatic = 3,
                Explicit = 4,
            }
        }

        class RawImage : UnityEngine.UI.MaskableGraphic
        {
            /*0xe0*/ UnityEngine.Texture m_Texture;
            /*0xe8*/ UnityEngine.Rect m_UVRect;

            /*0x1841940*/ RawImage();
            /*0x1841970*/ UnityEngine.Texture get_mainTexture();
            /*0x139ece0*/ UnityEngine.Texture get_texture();
            /*0x1841b00*/ void set_texture(UnityEngine.Texture value);
            /*0x1841af0*/ UnityEngine.Rect get_uvRect();
            /*0x1841bc0*/ void set_uvRect(UnityEngine.Rect value);
            /*0x18417e0*/ void SetNativeSize();
            /*0x18413b0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x16b6990*/ void OnDidApplyAnimationProperties();
        }

        class RectMask2D : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IClipper, UnityEngine.ICanvasRaycastFilter
        {
            /*0x20*/ UnityEngine.UI.RectangularVertexClipper m_VertexClipper;
            /*0x28*/ UnityEngine.RectTransform m_RectTransform;
            /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets;
            /*0x38*/ System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets;
            /*0x40*/ bool m_ShouldRecalculateClipRects;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers;
            /*0x50*/ UnityEngine.Rect m_LastClipRectCanvasSpace;
            /*0x60*/ bool m_ForceClip;
            /*0x64*/ UnityEngine.Vector4 m_Padding;
            /*0x74*/ UnityEngine.Vector2Int m_Softness;
            /*0x80*/ UnityEngine.Canvas m_Canvas;
            /*0x88*/ UnityEngine.Vector3[] m_Corners;

            /*0x1843460*/ RectMask2D();
            /*0x1843800*/ UnityEngine.Vector4 get_padding();
            /*0x1843a70*/ void set_padding(UnityEngine.Vector4 value);
            /*0x1843a60*/ UnityEngine.Vector2Int get_softness();
            /*0x1843a80*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x18435d0*/ UnityEngine.Canvas get_Canvas();
            /*0x1843740*/ UnityEngine.Rect get_canvasRect();
            /*0x1843810*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1842450*/ void OnEnable();
            /*0x1842390*/ void OnDisable();
            /*0x1842370*/ void OnDestroy();
            /*0x1842220*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x1843880*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x1842480*/ void PerformClipping();
            /*0x1843140*/ void UpdateClipSoftness();
            /*0x1842110*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x1842f90*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x1842330*/ void OnTransformParentChanged();
            /*0x1842330*/ void OnCanvasHierarchyChanged();
        }

        class Scrollbar : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
        {
            /*0x100*/ UnityEngine.RectTransform m_HandleRect;
            /*0x108*/ UnityEngine.UI.Scrollbar.Direction m_Direction;
            /*0x10c*/ float m_Value;
            /*0x110*/ float m_Size;
            /*0x114*/ int m_NumberOfSteps;
            /*0x118*/ UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged;
            /*0x120*/ UnityEngine.RectTransform m_ContainerRect;
            /*0x128*/ UnityEngine.Vector2 m_Offset;
            /*0x130*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x138*/ UnityEngine.Coroutine m_PointerDownRepeat;
            /*0x140*/ bool isPointerDownAndNotDragging;
            /*0x141*/ bool m_DelayedUpdateVisuals;

            /*0x184b050*/ Scrollbar();
            /*0x136fc90*/ UnityEngine.RectTransform get_handleRect();
            /*0x184b280*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0xbf2c70*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x184b220*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x184b1c0*/ float get_value();
            /*0x184b3e0*/ void set_value(float value);
            /*0x184a760*/ void SetValueWithoutNotify(float input);
            /*0x16b8990*/ float get_size();
            /*0x184b360*/ void set_size(float value);
            /*0x14659d0*/ int get_numberOfSteps();
            /*0x184b2f0*/ void set_numberOfSteps(int value);
            /*0x134cc10*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x134cc40*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x184b190*/ float get_stepSize();
            /*0x32d010*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x32d010*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x1849e30*/ void OnEnable();
            /*0x1849d30*/ void OnDisable();
            /*0x184b030*/ void Update();
            /*0x184a940*/ void UpdateCachedReferences();
            /*0x184a810*/ void Set(float input, bool sendCallback);
            /*0x184a550*/ void OnRectTransformDimensionsChange();
            /*0x184b150*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x184b170*/ bool get_reverseValue();
            /*0x184adb0*/ void UpdateVisuals();
            /*0x184aa40*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x18498a0*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x1849a20*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1849a90*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1849d60*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184a410*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1849830*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1849790*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x184a510*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1849f20*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x1849990*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x18499c0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x18499f0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x1849960*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x1849f00*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184a590*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x1844b00*/ ScrollEvent();
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }

            class <ClickRepeat>d__58 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Scrollbar <>4__this;
                /*0x28*/ UnityEngine.Vector2 screenPosition;
                /*0x30*/ UnityEngine.Camera camera;

                /*0x32f460*/ <ClickRepeat>d__58(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x1854620*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x1854890*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class ScrollRect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x20*/ UnityEngine.RectTransform m_Content;
            /*0x28*/ bool m_Horizontal;
            /*0x29*/ bool m_Vertical;
            /*0x2c*/ UnityEngine.UI.ScrollRect.MovementType m_MovementType;
            /*0x30*/ float m_Elasticity;
            /*0x34*/ bool m_Inertia;
            /*0x38*/ float m_DecelerationRate;
            /*0x3c*/ float m_ScrollSensitivity;
            /*0x40*/ UnityEngine.RectTransform m_Viewport;
            /*0x48*/ UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
            /*0x50*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
            /*0x58*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;
            /*0x5c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;
            /*0x60*/ float m_HorizontalScrollbarSpacing;
            /*0x64*/ float m_VerticalScrollbarSpacing;
            /*0x68*/ UnityEngine.UI.ScrollRect.ScrollRectEvent m_OnValueChanged;
            /*0x70*/ UnityEngine.Vector2 m_PointerStartLocalCursor;
            /*0x78*/ UnityEngine.Vector2 m_ContentStartPosition;
            /*0x80*/ UnityEngine.RectTransform m_ViewRect;
            /*0x88*/ UnityEngine.Bounds m_ContentBounds;
            /*0xa0*/ UnityEngine.Bounds m_ViewBounds;
            /*0xb8*/ UnityEngine.Vector2 m_Velocity;
            /*0xc0*/ bool m_Dragging;
            /*0xc1*/ bool m_Scrolling;
            /*0xc4*/ UnityEngine.Vector2 m_PrevPosition;
            /*0xcc*/ UnityEngine.Bounds m_PrevContentBounds;
            /*0xe4*/ UnityEngine.Bounds m_PrevViewBounds;
            /*0xfc*/ bool m_HasRebuiltLayout;
            /*0xfd*/ bool m_HSliderExpand;
            /*0xfe*/ bool m_VSliderExpand;
            /*0x100*/ float m_HSliderHeight;
            /*0x104*/ float m_VSliderWidth;
            /*0x108*/ UnityEngine.RectTransform m_Rect;
            /*0x110*/ UnityEngine.RectTransform m_HorizontalScrollbarRect;
            /*0x118*/ UnityEngine.RectTransform m_VerticalScrollbarRect;
            /*0x120*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x128*/ UnityEngine.Vector3[] m_Corners;

            static /*0x1846960*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x1848450*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x1844b80*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x1845150*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x1844fa0*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x1848c90*/ ScrollRect();
            /*0x61a260*/ UnityEngine.RectTransform get_content();
            /*0x7965a0*/ void set_content(UnityEngine.RectTransform value);
            /*0x4ba480*/ bool get_horizontal();
            /*0xd18990*/ void set_horizontal(bool value);
            /*0x12a2930*/ bool get_vertical();
            /*0x12a21f0*/ void set_vertical(bool value);
            /*0xbe6c70*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0xbe6cd0*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x1101d20*/ float get_elasticity();
            /*0x1102a70*/ void set_elasticity(float value);
            /*0x1102a60*/ bool get_inertia();
            /*0x1102a80*/ void set_inertia(bool value);
            /*0x136e840*/ float get_decelerationRate();
            /*0x14c88d0*/ void set_decelerationRate(float value);
            /*0x129f7b0*/ float get_scrollSensitivity();
            /*0x136a120*/ void set_scrollSensitivity(float value);
            /*0xb61870*/ UnityEngine.RectTransform get_viewport();
            /*0x1849760*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x4e40d0*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x18493b0*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x4e40e0*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x18495d0*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x104a520*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x18493a0*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x12d9c40*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x18495c0*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x137d040*/ float get_horizontalScrollbarSpacing();
            /*0x1849390*/ void set_horizontalScrollbarSpacing(float value);
            /*0x17cb200*/ float get_verticalScrollbarSpacing();
            /*0x18495b0*/ void set_verticalScrollbarSpacing(float value);
            /*0x8af030*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0xe69480*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x1849260*/ UnityEngine.RectTransform get_viewRect();
            /*0x1849130*/ UnityEngine.Vector2 get_velocity();
            /*0x18495a0*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x1849010*/ UnityEngine.RectTransform get_rectTransform();
            /*0x18468d0*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x32d010*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x18480b0*/ void UpdateCachedData();
            /*0x1846450*/ void OnEnable();
            /*0x1845fc0*/ void OnDisable();
            /*0x18453d0*/ bool IsActive();
            /*0x1844e00*/ void EnsureLayoutHasRebuilt();
            /*0x18479f0*/ void StopMovement();
            /*0x18466b0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x1846630*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1845e50*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1846600*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1846200*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x18469c0*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x1845440*/ void LateUpdate();
            /*0x1848540*/ void UpdatePrevData();
            /*0x1848aa0*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x1848fd0*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x1849540*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x1848ec0*/ float get_horizontalNormalizedPosition();
            /*0x1846c20*/ void set_horizontalNormalizedPosition(float value);
            /*0x1849150*/ float get_verticalNormalizedPosition();
            /*0x18479d0*/ void set_verticalNormalizedPosition(float value);
            /*0x1846c20*/ void SetHorizontalNormalizedPosition(float value);
            /*0x18479d0*/ void SetVerticalNormalizedPosition(float value);
            /*0x18474b0*/ void SetNormalizedPosition(float value, int axis);
            /*0x18466a0*/ void OnRectTransformDimensionsChange();
            /*0x1848e30*/ bool get_hScrollingNeeded();
            /*0x18490b0*/ bool get_vScrollingNeeded();
            /*0x32d010*/ void CalculateLayoutInputHorizontal();
            /*0x32d010*/ void CalculateLayoutInputVertical();
            /*0x1474a00*/ float get_minWidth();
            /*0x1474a00*/ float get_preferredWidth();
            /*0x1474a00*/ float get_flexibleWidth();
            /*0x1474a00*/ float get_minHeight();
            /*0x1474a00*/ float get_preferredHeight();
            /*0x1474a00*/ float get_flexibleHeight();
            /*0xec2ac0*/ int get_layoutPriority();
            /*0x1846c40*/ void SetLayoutHorizontal();
            /*0x1847380*/ void SetLayoutVertical();
            /*0x1848a40*/ void UpdateScrollbarVisibility();
            /*0x1848660*/ void UpdateScrollbarLayout();
            /*0x1847a50*/ void UpdateBounds();
            /*0x1844e60*/ UnityEngine.Bounds GetBounds();
            /*0x1844c20*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x1846ba0*/ void SetDirty();
            /*0x1846ae0*/ void SetDirtyCaching();
            /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum MovementType
            {
                Unrestricted = 0,
                Elastic = 1,
                Clamped = 2,
            }

            enum ScrollbarVisibility
            {
                Permanent = 0,
                AutoHide = 1,
                AutoHideAndExpandViewport = 2,
            }

            class ScrollRectEvent : UnityEngine.Events.UnityEvent<UnityEngine.Vector2>
            {
                /*0x1844b40*/ ScrollRectEvent();
            }
        }

        class Selectable : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler
        {
            static /*0x0*/ UnityEngine.UI.Selectable[] s_Selectables;
            static /*0x8*/ int s_SelectableCount;
            /*0x20*/ bool m_EnableCalled;
            /*0x28*/ UnityEngine.UI.Navigation m_Navigation;
            /*0x50*/ UnityEngine.UI.Selectable.Transition m_Transition;
            /*0x54*/ UnityEngine.UI.ColorBlock m_Colors;
            /*0xb0*/ UnityEngine.UI.SpriteState m_SpriteState;
            /*0xd0*/ UnityEngine.UI.AnimationTriggers m_AnimationTriggers;
            /*0xd8*/ bool m_Interactable;
            /*0xe0*/ UnityEngine.UI.Graphic m_TargetGraphic;
            /*0xe8*/ bool m_GroupsAllowInteraction;
            /*0xec*/ int m_CurrentIndex;
            /*0xf0*/ bool <isPointerInside>k__BackingField;
            /*0xf1*/ bool <isPointerDown>k__BackingField;
            /*0xf2*/ bool <hasSelection>k__BackingField;
            /*0xf8*/ System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache;

            static /*0x184d8c0*/ Selectable();
            static /*0x184db20*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x184dad0*/ int get_allSelectableCount();
            static /*0x184dbb0*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x184b3f0*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x184c350*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x184d940*/ Selectable();
            /*0x12fe8f0*/ UnityEngine.UI.Navigation get_navigation();
            /*0x184e120*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0xc70ac0*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x184e270*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x184dcf0*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x184dee0*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x184de60*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x184e1a0*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x136fcc0*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x184de80*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x139ece0*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x184e210*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x184de30*/ bool get_interactable();
            /*0x184df90*/ void set_interactable(bool value);
            /*0x184de50*/ bool get_isPointerInside();
            /*0x184e110*/ void set_isPointerInside(bool value);
            /*0x184de40*/ bool get_isPointerDown();
            /*0x184e100*/ void set_isPointerDown(bool value);
            /*0x184dda0*/ bool get_hasSelection();
            /*0x184df80*/ void set_hasSelection(bool value);
            /*0x184ddb0*/ UnityEngine.UI.Image get_image();
            /*0x14126d0*/ void set_image(UnityEngine.UI.Image value);
            /*0x184dcb0*/ UnityEngine.Animator get_animator();
            /*0x184b4c0*/ void Awake();
            /*0x184c890*/ void OnCanvasGroupChanged();
            /*0x184d2f0*/ bool ParentGroupAllowsInteraction();
            /*0x184c710*/ bool IsInteractable();
            /*0x184c950*/ void OnDidApplyAnimationProperties();
            /*0x184cb10*/ void OnEnable();
            /*0x184d2c0*/ void OnTransformParentChanged();
            /*0x184d240*/ void OnSetProperty();
            /*0x184c960*/ void OnDisable();
            /*0x184c820*/ void OnApplicationFocus(bool hasFocus);
            /*0x184dd30*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x184c580*/ void InstantClearState();
            /*0x184b600*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x184bc90*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x184c780*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x184b9f0*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x184bad0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x184bbb0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x184b910*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x184ce30*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x184d570*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x184b560*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x184d670*/ void TriggerAnimation(string triggername);
            /*0x184c6a0*/ bool IsHighlighted();
            /*0x184c730*/ bool IsPressed();
            /*0x184b8a0*/ void EvaluateAndTransitionToSelectionState();
            /*0x184cf60*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184d190*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184d090*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184d110*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184d1c0*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x184c8d0*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x184d480*/ void Select();

            enum Transition
            {
                None = 0,
                ColorTint = 1,
                SpriteSwap = 2,
                Animation = 3,
            }

            enum SelectionState
            {
                Normal = 0,
                Highlighted = 1,
                Pressed = 2,
                Selected = 3,
                Disabled = 4,
            }
        }

        class SetPropertyUtility
        {
            static /*0x1495490*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
            static /*0x2a5510*/ bool SetStruct<T>(ref T currentValue, T newValue);
            static /*0x2a5510*/ bool SetClass<T>(ref T currentValue, T newValue);
        }

        class Slider : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
        {
            /*0x100*/ UnityEngine.RectTransform m_FillRect;
            /*0x108*/ UnityEngine.RectTransform m_HandleRect;
            /*0x110*/ UnityEngine.UI.Slider.Direction m_Direction;
            /*0x114*/ float m_MinValue;
            /*0x118*/ float m_MaxValue;
            /*0x11c*/ bool m_WholeNumbers;
            /*0x120*/ float m_Value;
            /*0x128*/ UnityEngine.UI.Slider.SliderEvent m_OnValueChanged;
            /*0x130*/ UnityEngine.UI.Image m_FillImage;
            /*0x138*/ UnityEngine.Transform m_FillTransform;
            /*0x140*/ UnityEngine.RectTransform m_FillContainerRect;
            /*0x148*/ UnityEngine.Transform m_HandleTransform;
            /*0x150*/ UnityEngine.RectTransform m_HandleContainerRect;
            /*0x158*/ UnityEngine.Vector2 m_Offset;
            /*0x160*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x161*/ bool m_DelayedUpdateVisuals;

            /*0x184fbd0*/ Slider();
            /*0x136fc90*/ UnityEngine.RectTransform get_fillRect();
            /*0x184fe90*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x136fcb0*/ UnityEngine.RectTransform get_handleRect();
            /*0x184ff00*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x1404ac0*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x184fe30*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x14a40b0*/ float get_minValue();
            /*0x184fff0*/ void set_minValue(float value);
            /*0x184fcf0*/ float get_maxValue();
            /*0x184ff70*/ void set_maxValue(float value);
            /*0x184fe20*/ bool get_wholeNumbers();
            /*0x18500e0*/ void set_wholeNumbers(bool value);
            /*0x184fe00*/ float get_value();
            /*0x18500c0*/ void set_value(float value);
            /*0x184f040*/ void SetValueWithoutNotify(float input);
            /*0x184fd00*/ float get_normalizedValue();
            /*0x1850070*/ void set_normalizedValue(float value);
            /*0x10d2010*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x10f5010*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x184fdd0*/ float get_stepSize();
            /*0x32d010*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x32d010*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x184e730*/ void OnEnable();
            /*0x184e680*/ void OnDisable();
            /*0x184fb80*/ void Update();
            /*0x184e400*/ void OnDidApplyAnimationProperties();
            /*0x184f140*/ void UpdateCachedReferences();
            /*0x184e310*/ float ClampValue(float input);
            /*0x184f060*/ void Set(float input, bool sendCallback);
            /*0x184ee30*/ void OnRectTransformDimensionsChange();
            /*0x184fcd0*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x184fdb0*/ bool get_reverseValue();
            /*0x184f790*/ void UpdateVisuals();
            /*0x184f4d0*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x1849a20*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184ebd0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184e6b0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184e780*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x184e370*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x184e3a0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x184e3d0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x184e340*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x1849f00*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x184ee70*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x184e2d0*/ SliderEvent();
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }
        }

        struct SpriteState : System.IEquatable<UnityEngine.UI.SpriteState>
        {
            /*0x10*/ UnityEngine.Sprite m_HighlightedSprite;
            /*0x18*/ UnityEngine.Sprite m_PressedSprite;
            /*0x20*/ UnityEngine.Sprite m_SelectedSprite;
            /*0x28*/ UnityEngine.Sprite m_DisabledSprite;

            /*0x6937d0*/ UnityEngine.Sprite get_highlightedSprite();
            /*0x792990*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0xa5a7f0*/ UnityEngine.Sprite get_pressedSprite();
            /*0x1659550*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0x73d3e0*/ UnityEngine.Sprite get_selectedSprite();
            /*0x9f12f0*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0x32f410*/ UnityEngine.Sprite get_disabledSprite();
            /*0x7963c0*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0x1850160*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x1851150*/ StencilMaterial();
            static /*0x388e90*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x1850260*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x1850ef0*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x1850300*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x1850f80*/ void Remove(UnityEngine.Material customMat);
            static /*0x1850d80*/ void ClearAll();

            class MatEntry
            {
                /*0x10*/ UnityEngine.Material baseMat;
                /*0x18*/ UnityEngine.Material customMat;
                /*0x20*/ int count;
                /*0x24*/ int stencilId;
                /*0x28*/ UnityEngine.Rendering.StencilOp operation;
                /*0x2c*/ UnityEngine.Rendering.CompareFunction compareFunction;
                /*0x30*/ int readMask;
                /*0x34*/ int writeMask;
                /*0x38*/ bool useAlphaClip;
                /*0x3c*/ UnityEngine.Rendering.ColorWriteMask colorMask;

                /*0x18406a0*/ MatEntry();
            }
        }

        class Text : UnityEngine.UI.MaskableGraphic, UnityEngine.UI.ILayoutElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultText;
            /*0xe0*/ UnityEngine.UI.FontData m_FontData;
            /*0xe8*/ string m_Text;
            /*0xf0*/ UnityEngine.TextGenerator m_TextCache;
            /*0xf8*/ UnityEngine.TextGenerator m_TextCacheForLayout;
            /*0x100*/ bool m_DisableFontTextureRebuiltCallback;
            /*0x108*/ UnityEngine.UIVertex[] m_TempVerts;

            static /*0x1851660*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x1852080*/ Text();
            /*0x18521f0*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x1852170*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x1852340*/ UnityEngine.Texture get_mainTexture();
            /*0x18512f0*/ void FontTextureChanged();
            /*0x18522e0*/ UnityEngine.Font get_font();
            /*0x1852ae0*/ void set_font(UnityEngine.Font value);
            /*0x10d00b0*/ string get_text();
            /*0x1852e50*/ void set_text(string value);
            /*0x1852940*/ bool get_supportRichText();
            /*0x1852df0*/ void set_supportRichText(bool value);
            /*0x18528e0*/ bool get_resizeTextForBestFit();
            /*0x1852cd0*/ void set_resizeTextForBestFit(bool value);
            /*0x1852920*/ int get_resizeTextMinSize();
            /*0x1852d90*/ void set_resizeTextMinSize(int value);
            /*0x1852900*/ int get_resizeTextMaxSize();
            /*0x1852d30*/ void set_resizeTextMaxSize(int value);
            /*0x1852150*/ UnityEngine.TextAnchor get_alignment();
            /*0x18529c0*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x1852130*/ bool get_alignByGeometry();
            /*0x1852980*/ void set_alignByGeometry(bool value);
            /*0x18522a0*/ int get_fontSize();
            /*0x1852a20*/ void set_fontSize(int value);
            /*0x1852300*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x1852c00*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x1852960*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x1852f40*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x1852320*/ float get_lineSpacing();
            /*0x1852c60*/ void set_lineSpacing(float value);
            /*0x18522c0*/ UnityEngine.FontStyle get_fontStyle();
            /*0x1852a80*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x1852540*/ float get_pixelsPerUnit();
            /*0x1851830*/ void OnEnable();
            /*0x18517d0*/ void OnDisable();
            /*0x1852000*/ void UpdateGeometry();
            /*0x1851290*/ void AssignDefaultFont();
            /*0x18511e0*/ void AssignDefaultFontIfNecessary();
            /*0x1851410*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x18518b0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x32d010*/ void CalculateLayoutInputHorizontal();
            /*0x32d010*/ void CalculateLayoutInputVertical();
            /*0x1301790*/ float get_minWidth();
            /*0x18527c0*/ float get_preferredWidth();
            /*0x1474a00*/ float get_flexibleWidth();
            /*0x1301790*/ float get_minHeight();
            /*0x18526b0*/ float get_preferredHeight();
            /*0x1474a00*/ float get_flexibleHeight();
            /*0x388e90*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0x100*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x108*/ UnityEngine.UI.Graphic graphic;
            /*0x110*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x118*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x120*/ bool m_IsOn;

            /*0x1854520*/ Toggle();
            /*0x1355380*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x18545e0*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x32d010*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x32d010*/ void LayoutComplete();
            /*0x32d010*/ void GraphicUpdateComplete();
            /*0x1853de0*/ void OnDestroy();
            /*0x1853f70*/ void OnEnable();
            /*0x1853f40*/ void OnDisable();
            /*0x1853e70*/ void OnDidApplyAnimationProperties();
            /*0x1854100*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x12ddf30*/ bool get_isOn();
            /*0x1854610*/ void set_isOn(bool value);
            /*0x18540f0*/ void SetIsOnWithoutNotify(bool value);
            /*0x1854380*/ void Set(bool value, bool sendCallback);
            /*0x1854030*/ void PlayEffect(bool instant);
            /*0x1854510*/ void Start();
            /*0x1853d80*/ void InternalToggle();
            /*0x1853fb0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1853d80*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x1852fa0*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ bool m_AllowSwitchOff;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x1853d00*/ ToggleGroup();
            /*0x796120*/ bool get_allowSwitchOff();
            /*0x7963b0*/ void set_allowSwitchOff(bool value);
            /*0x1853920*/ void Start();
            /*0x1853920*/ void OnEnable();
            /*0x1853bb0*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x18536c0*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x1853b30*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x1853940*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x1853250*/ void EnsureValidState();
            /*0x1853100*/ bool AnyTogglesOn();
            /*0x1852fe0*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x1853650*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x1853a20*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x18548f0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x18548d0*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x18548d0*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
            }
        }

        class ReflectionMethodsCache
        {
            static /*0x0*/ UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache;
            /*0x10*/ UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback raycast3D;
            /*0x18*/ UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback raycast3DAll;
            /*0x20*/ UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;
            /*0x28*/ UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback raycast2D;
            /*0x30*/ UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;
            /*0x38*/ UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

            static /*0x1844a70*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x1843ab0*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x1841fa0*/ Raycast3DCallback(object object, nint method);
                /*0x18404e0*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x1841e70*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x1841f60*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x1840360*/ RaycastAllCallback(object object, nint method);
                /*0x1840320*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x1842050*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x723cb0*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x1840520*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x18404e0*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x18405d0*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0xf338c0*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x1841dc0*/ Raycast2DCallback(object object, nint method);
                /*0x1841d60*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x1841c30*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x1841d10*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x1840360*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x1840320*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x1840260*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x723cb0*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x1840520*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x18404e0*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x1840410*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0xf338c0*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class VertexHelper : System.IDisposable
        {
            static /*0x0*/ UnityEngine.Vector4 s_DefaultTangent;
            static /*0x10*/ UnityEngine.Vector3 s_DefaultNormal;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Vector3> m_Positions;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Color32> m_Colors;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv0S;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv1S;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv2S;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv3S;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Vector3> m_Normals;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Tangents;
            /*0x50*/ System.Collections.Generic.List<int> m_Indices;
            /*0x58*/ bool m_ListsInitalized;

            static /*0x18562c0*/ VertexHelper();
            /*0x32f970*/ VertexHelper();
            /*0x1856350*/ VertexHelper(UnityEngine.Mesh m);
            /*0x1855bd0*/ void InitializeListIfRequired();
            /*0x18557e0*/ void Dispose();
            /*0x18556f0*/ void Clear();
            /*0x18565e0*/ int get_currentVertCount();
            /*0x1856590*/ int get_currentIndexCount();
            /*0x1855db0*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x1855f70*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x18559f0*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x18552b0*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x1855090*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x1854ea0*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x1855200*/ void AddVert(UnityEngine.UIVertex v);
            /*0x1854960*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x1854ad0*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x1854d60*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x1854e20*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x1855b50*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x32f970*/ BaseVertexEffect();
            /*0x17aec0*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x20*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x317730*/ BaseMeshEffect();
            /*0x18401d0*/ UnityEngine.UI.Graphic get_graphic();
            /*0x1840130*/ void OnEnable();
            /*0x1840090*/ void OnDisable();
            /*0x183fff0*/ void OnDidApplyAnimationProperties();
            /*0x183fdb0*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x17aec0*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        interface IVertexModifier
        {
            /*0x17aec0*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
        }

        interface IMeshModifier
        {
            /*0x17aec0*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x17aec0*/ void ModifyMesh(UnityEngine.UI.VertexHelper verts);
        }

        class Outline : UnityEngine.UI.Shadow
        {
            /*0x18413a0*/ Outline();
            /*0x1841030*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x546660*/ PositionAsUV1();
            /*0x1863f70*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x28*/ UnityEngine.Color m_EffectColor;
            /*0x38*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x40*/ bool m_UseGraphicAlpha;

            /*0x1864fd0*/ Shadow();
            /*0xa75be0*/ UnityEngine.Color get_effectColor();
            /*0x1865000*/ void set_effectColor(UnityEngine.Color value);
            /*0x1820b70*/ UnityEngine.Vector2 get_effectDistance();
            /*0x18650a0*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0xb61dd0*/ bool get_useGraphicAlpha();
            /*0x18651a0*/ void set_useGraphicAlpha(bool value);
            /*0x1864b00*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x1864e80*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x1864e90*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;
                /*0x0*/ int m_EnabledObjectCount;

                /*0x180fc0*/ IndexedSet();
                /*0x2a5510*/ void Add(T item);
                /*0x2a5510*/ void Add(T item, bool isActive);
                /*0x2a5510*/ bool AddUnique(T item, bool isActive);
                /*0x2a5510*/ bool EnableItem(T item);
                /*0x2a5510*/ bool DisableItem(T item);
                /*0x2a5510*/ bool Remove(T item);
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x180fc0*/ void Clear();
                /*0x2a5510*/ bool Contains(T item);
                /*0x182a70*/ void CopyTo(T[] array, int arrayIndex);
                /*0x180980*/ int get_Count();
                /*0x180980*/ int get_Capacity();
                /*0x17cb40*/ bool get_IsReadOnly();
                /*0x2a5510*/ int IndexOf(T item);
                /*0x2a5510*/ void Insert(int index, T item);
                /*0x17aa40*/ void RemoveAt(int index);
                /*0x1817d0*/ void Swap(int index1, int index2);
                /*0x2a5510*/ T get_Item(int index);
                /*0x2a5510*/ void set_Item(int index, T value);
                /*0x17aec0*/ void RemoveAll(System.Predicate<T> match);
                /*0x17aec0*/ void Sort(System.Comparison<T> sortLayoutFunction);
            }
        }

        namespace CoroutineTween
        {
            interface ITweenValue
            {
                /*0x178d00*/ void TweenValue(float floatPercentage);
                /*0x17cb40*/ bool get_ignoreTimeScale();
                /*0x17fc30*/ float get_duration();
                /*0x17cb40*/ bool ValidTarget();
            }

            struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;
                /*0x18*/ UnityEngine.Color m_StartColor;
                /*0x28*/ UnityEngine.Color m_TargetColor;
                /*0x38*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;
                /*0x3c*/ float m_Duration;
                /*0x40*/ bool m_IgnoreTimeScale;

                /*0xa5a790*/ UnityEngine.Color get_startColor();
                /*0xf2b430*/ void set_startColor(UnityEngine.Color value);
                /*0x716050*/ UnityEngine.Color get_targetColor();
                /*0xdd5220*/ void set_targetColor(UnityEngine.Color value);
                /*0x3e3ae0*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0xc6dab0*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0x4ccc40*/ float get_duration();
                /*0x4ccc50*/ void set_duration(float value);
                /*0x995050*/ bool get_ignoreTimeScale();
                /*0x995180*/ void set_ignoreTimeScale(bool value);
                /*0x1858630*/ void TweenValue(float floatPercentage);
                /*0x1858570*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0x995050*/ bool GetIgnoreTimescale();
                /*0x4ccc40*/ float GetDuration();
                /*0xfbe040*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x1858530*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0xa5a910*/ float get_startValue();
                /*0x14544b0*/ void set_startValue(float value);
                /*0x1202400*/ float get_targetValue();
                /*0x1202470*/ void set_targetValue(float value);
                /*0x8c2b50*/ float get_duration();
                /*0x10e91a0*/ void set_duration(float value);
                /*0x8b9820*/ bool get_ignoreTimeScale();
                /*0xe29380*/ void set_ignoreTimeScale(bool value);
                /*0x185c840*/ void TweenValue(float floatPercentage);
                /*0x185c780*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0x8b9820*/ bool GetIgnoreTimescale();
                /*0x8c2b50*/ float GetDuration();
                /*0xfbe040*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x185c740*/ FloatTweenCallback();
                }
            }

            class TweenRunner<T>
            {
                /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
                /*0x0*/ System.Collections.IEnumerator m_Tween;

                static /*0x2a5510*/ System.Collections.IEnumerator Start(T tweenInfo);
                /*0x180fc0*/ TweenRunner();
                /*0x17aec0*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
                /*0x2a5510*/ void StartTween(T info);
                /*0x180fc0*/ void StopTween();

                class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ T tweenInfo;
                    /*0x0*/ float <elapsedTime>5__2;

                    /*0x17aa40*/ <Start>d__2(int <>1__state);
                    /*0x180fc0*/ void System.IDisposable.Dispose();
                    /*0x17cb40*/ bool MoveNext();
                    /*0x1803b0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                    /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }
    }

    namespace UIElements
    {
        class PanelEventHandler : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.UIElements.IRuntimePanelComponent, UnityEngine.EventSystems.IPointerClickHandler
        {
            static /*0x0*/ UnityEngine.EventModifiers s_Modifiers;
            /*0x20*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;
            /*0x28*/ UnityEngine.UIElements.PanelEventHandler.PointerEvent m_PointerEvent;
            /*0x30*/ float m_LastClickTime;
            /*0x34*/ bool m_Selecting;
            /*0x38*/ UnityEngine.Event m_Event;

            /*0x185ecf0*/ PanelEventHandler();
            /*0x61a260*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x185ef90*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x185ef70*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x185edd0*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x185eea0*/ bool get_isCurrentFocusedPanel();
            /*0x185ed90*/ UnityEngine.UIElements.Focusable get_currentFocusedElement();
            /*0x185cff0*/ void OnEnable();
            /*0x185cf30*/ void OnDisable();
            /*0x185e3b0*/ void RegisterCallbacks();
            /*0x185ea00*/ void UnregisterCallbacks();
            /*0x185d210*/ void OnPanelDestroyed();
            /*0x185cf40*/ void OnElementFocus(UnityEngine.UIElements.FocusEvent e);
            /*0x32d010*/ void OnElementBlur(UnityEngine.UIElements.BlurEvent e);
            /*0x185dd10*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185cf10*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185d820*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185d970*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185d290*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185d520*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185d4b0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185d270*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185dd80*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185cd40*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185d000*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x185db30*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185e560*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData);
            /*0x185e5d0*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent);
            /*0x185ebb0*/ void Update();
            /*0x185cd30*/ void LateUpdate();
            /*0x185df50*/ void ProcessImguiEvents(UnityEngine.UIElements.Focusable target);
            /*0x185e100*/ void ProcessKeyboardEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x185e190*/ void ProcessTabEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x185e8c0*/ void SendTabEvent(UnityEngine.Event e, UnityEngine.UIElements.NavigationMoveEvent.Direction direction, UnityEngine.UIElements.Focusable target);
            /*0x185e760*/ void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x185e600*/ void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x185e200*/ bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);

            enum PointerEventType
            {
                Default = 0,
                Down = 1,
                Up = 2,
            }

            class PointerEvent : UnityEngine.UIElements.IPointerEvent
            {
                /*0x10*/ int <pointerId>k__BackingField;
                /*0x18*/ string <pointerType>k__BackingField;
                /*0x20*/ bool <isPrimary>k__BackingField;
                /*0x24*/ int <button>k__BackingField;
                /*0x28*/ int <pressedButtons>k__BackingField;
                /*0x2c*/ UnityEngine.Vector3 <position>k__BackingField;
                /*0x38*/ UnityEngine.Vector3 <localPosition>k__BackingField;
                /*0x44*/ UnityEngine.Vector3 <deltaPosition>k__BackingField;
                /*0x50*/ float <deltaTime>k__BackingField;
                /*0x54*/ int <clickCount>k__BackingField;
                /*0x58*/ float <pressure>k__BackingField;
                /*0x5c*/ float <tangentialPressure>k__BackingField;
                /*0x60*/ float <altitudeAngle>k__BackingField;
                /*0x64*/ float <azimuthAngle>k__BackingField;
                /*0x68*/ float <twist>k__BackingField;
                /*0x6c*/ UnityEngine.Vector2 <tilt>k__BackingField;
                /*0x74*/ UnityEngine.PenStatus <penStatus>k__BackingField;
                /*0x78*/ UnityEngine.Vector2 <radius>k__BackingField;
                /*0x80*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
                /*0x88*/ UnityEngine.EventModifiers <modifiers>k__BackingField;

                static /*0x1862360*/ bool <Read>g__InRange|90_0(int i, int start, int count);
                /*0x32f970*/ PointerEvent();
                /*0x417e30*/ int get_pointerId();
                /*0xdcd9c0*/ void set_pointerId(int value);
                /*0x32f410*/ string get_pointerType();
                /*0x7963c0*/ void set_pointerType(string value);
                /*0x796120*/ bool get_isPrimary();
                /*0x7963b0*/ void set_isPrimary(bool value);
                /*0x3e3ad0*/ int get_button();
                /*0xc70b30*/ void set_button(int value);
                /*0x3e3ae0*/ int get_pressedButtons();
                /*0xc6dab0*/ void set_pressedButtons(int value);
                /*0x1862480*/ UnityEngine.Vector3 get_position();
                /*0x1862550*/ void set_position(UnityEngine.Vector3 value);
                /*0x1862460*/ UnityEngine.Vector3 get_localPosition();
                /*0x1862530*/ void set_localPosition(UnityEngine.Vector3 value);
                /*0x1862440*/ UnityEngine.Vector3 get_deltaPosition();
                /*0x1862520*/ void set_deltaPosition(UnityEngine.Vector3 value);
                /*0x16a1c30*/ float get_deltaTime();
                /*0x1659590*/ void set_deltaTime(float value);
                /*0x136e810*/ int get_clickCount();
                /*0x13db570*/ void set_clickCount(int value);
                /*0x136fc70*/ float get_pressure();
                /*0x1659560*/ void set_pressure(float value);
                /*0x176e7f0*/ float get_tangentialPressure();
                /*0x1659570*/ void set_tangentialPressure(float value);
                /*0x137d040*/ float get_altitudeAngle();
                /*0x1862500*/ void set_altitudeAngle(float value);
                /*0x17cb200*/ float get_azimuthAngle();
                /*0x1862510*/ void set_azimuthAngle(float value);
                /*0x18624f0*/ float get_twist();
                /*0x1862580*/ void set_twist(float value);
                /*0x18624d0*/ UnityEngine.Vector2 get_tilt();
                /*0x1862570*/ void set_tilt(UnityEngine.Vector2 value);
                /*0x136fc60*/ UnityEngine.PenStatus get_penStatus();
                /*0x1862540*/ void set_penStatus(UnityEngine.PenStatus value);
                /*0x179f1e0*/ UnityEngine.Vector2 get_radius();
                /*0x12a10b0*/ void set_radius(UnityEngine.Vector2 value);
                /*0x18624a0*/ UnityEngine.Vector2 get_radiusVariance();
                /*0x1862560*/ void set_radiusVariance(UnityEngine.Vector2 value);
                /*0x737a20*/ UnityEngine.EventModifiers get_modifiers();
                /*0x737e20*/ void set_modifiers(UnityEngine.EventModifiers value);
                /*0x18624c0*/ bool get_shiftKey();
                /*0x1862430*/ bool get_ctrlKey();
                /*0x1862420*/ bool get_commandKey();
                /*0x1862410*/ bool get_altKey();
                /*0x1862380*/ bool get_actionKey();
                /*0x1861d70*/ void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);
                /*0x1862330*/ void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride);
            }
        }

        class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
        {
            /*0x28*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;

            /*0x31c640*/ PanelRaycaster();
            /*0x79a150*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x185f8c0*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x185f690*/ void RegisterCallbacks();
            /*0x185f720*/ void UnregisterCallbacks();
            /*0x185f030*/ void OnPanelDestroyed();
            /*0x185f830*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x185f850*/ int get_sortOrderPriority();
            /*0x185f7b0*/ int get_renderOrderPriority();
            /*0x185f160*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x388e90*/ UnityEngine.Camera get_eventCamera();
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x1856910*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x1856990*/ UnityEngine.Vector2 get_moveVector();
            /*0x10cb140*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x3e3ae0*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0xc6dab0*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x32f970*/ AbstractEventData();
            /*0x1856900*/ void Reset();
            /*0xbe4ad0*/ void Use();
            /*0x793eb0*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0xe78ae0*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x18569b0*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x18569d0*/ UnityEngine.GameObject get_selectedObject();
            /*0x18569f0*/ void set_selectedObject(UnityEngine.GameObject value);
        }

        class PointerEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.GameObject <pointerEnter>k__BackingField;
            /*0x28*/ UnityEngine.GameObject m_PointerPress;
            /*0x30*/ UnityEngine.GameObject <lastPress>k__BackingField;
            /*0x38*/ UnityEngine.GameObject <rawPointerPress>k__BackingField;
            /*0x40*/ UnityEngine.GameObject <pointerDrag>k__BackingField;
            /*0x48*/ UnityEngine.GameObject <pointerClick>k__BackingField;
            /*0x50*/ UnityEngine.EventSystems.RaycastResult <pointerCurrentRaycast>k__BackingField;
            /*0xa0*/ UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField;
            /*0xf0*/ System.Collections.Generic.List<UnityEngine.GameObject> hovered;
            /*0xf8*/ bool <eligibleForClick>k__BackingField;
            /*0xfc*/ int <displayIndex>k__BackingField;
            /*0x100*/ int <pointerId>k__BackingField;
            /*0x104*/ UnityEngine.Vector2 <position>k__BackingField;
            /*0x10c*/ UnityEngine.Vector2 <delta>k__BackingField;
            /*0x114*/ UnityEngine.Vector2 <pressPosition>k__BackingField;
            /*0x11c*/ UnityEngine.Vector3 <worldPosition>k__BackingField;
            /*0x128*/ UnityEngine.Vector3 <worldNormal>k__BackingField;
            /*0x134*/ float <clickTime>k__BackingField;
            /*0x138*/ int <clickCount>k__BackingField;
            /*0x13c*/ UnityEngine.Vector2 <scrollDelta>k__BackingField;
            /*0x144*/ bool <useDragThreshold>k__BackingField;
            /*0x145*/ bool <dragging>k__BackingField;
            /*0x148*/ UnityEngine.EventSystems.PointerEventData.InputButton <button>k__BackingField;
            /*0x14c*/ float <pressure>k__BackingField;
            /*0x150*/ float <tangentialPressure>k__BackingField;
            /*0x154*/ float <altitudeAngle>k__BackingField;
            /*0x158*/ float <azimuthAngle>k__BackingField;
            /*0x15c*/ float <twist>k__BackingField;
            /*0x160*/ UnityEngine.Vector2 <tilt>k__BackingField;
            /*0x168*/ UnityEngine.PenStatus <penStatus>k__BackingField;
            /*0x16c*/ UnityEngine.Vector2 <radius>k__BackingField;
            /*0x174*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
            /*0x17c*/ bool <fullyExited>k__BackingField;
            /*0x17d*/ bool <reentered>k__BackingField;

            /*0x18614e0*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x61a260*/ UnityEngine.GameObject get_pointerEnter();
            /*0x7965a0*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x997630*/ UnityEngine.GameObject get_lastPress();
            /*0x997640*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x995140*/ UnityEngine.GameObject get_rawPointerPress();
            /*0xe5a080*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0xb61870*/ UnityEngine.GameObject get_pointerDrag();
            /*0xcf6cd0*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x4e40d0*/ UnityEngine.GameObject get_pointerClick();
            /*0x4e4360*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x1861870*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x1861b50*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x18618b0*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x1861ba0*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x137cf40*/ bool get_eligibleForClick();
            /*0x135cb90*/ void set_eligibleForClick(bool value);
            /*0x137ce60*/ int get_displayIndex();
            /*0x137d9b0*/ void set_displayIndex(int value);
            /*0x137ce50*/ int get_pointerId();
            /*0x1861b90*/ void set_pointerId(int value);
            /*0x18618f0*/ UnityEngine.Vector2 get_position();
            /*0x1861c80*/ void set_position(UnityEngine.Vector2 value);
            /*0x1861790*/ UnityEngine.Vector2 get_delta();
            /*0x1861b10*/ void set_delta(UnityEngine.Vector2 value);
            /*0x18619b0*/ UnityEngine.Vector2 get_pressPosition();
            /*0x1861c90*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x1861ab0*/ UnityEngine.Vector3 get_worldPosition();
            /*0x1861d50*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x1861a90*/ UnityEngine.Vector3 get_worldNormal();
            /*0x1861d30*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x10f4ef0*/ float get_clickTime();
            /*0x10f5030*/ void set_clickTime(float value);
            /*0x10f4aa0*/ int get_clickCount();
            /*0x1861b00*/ void set_clickCount(int value);
            /*0x1861a30*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x1861ce0*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x1861a80*/ bool get_useDragThreshold();
            /*0x1861d20*/ void set_useDragThreshold(bool value);
            /*0x18617b0*/ bool get_dragging();
            /*0x1861b20*/ void set_dragging(bool value);
            /*0x1861780*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x1861af0*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x18619d0*/ float get_pressure();
            /*0x1861ca0*/ void set_pressure(float value);
            /*0x1861a50*/ float get_tangentialPressure();
            /*0x1861cf0*/ void set_tangentialPressure(float value);
            /*0x1861760*/ float get_altitudeAngle();
            /*0x1861ad0*/ void set_altitudeAngle(float value);
            /*0x1861770*/ float get_azimuthAngle();
            /*0x1861ae0*/ void set_azimuthAngle(float value);
            /*0x1492a10*/ float get_twist();
            /*0x1861d10*/ void set_twist(float value);
            /*0x1861a60*/ UnityEngine.Vector2 get_tilt();
            /*0x1861d00*/ void set_tilt(UnityEngine.Vector2 value);
            /*0x12e7f90*/ UnityEngine.PenStatus get_penStatus();
            /*0x1861b40*/ void set_penStatus(UnityEngine.PenStatus value);
            /*0x1861a00*/ UnityEngine.Vector2 get_radius();
            /*0x1861cc0*/ void set_radius(UnityEngine.Vector2 value);
            /*0x18619e0*/ UnityEngine.Vector2 get_radiusVariance();
            /*0x1861cb0*/ void set_radiusVariance(UnityEngine.Vector2 value);
            /*0x1861860*/ bool get_fullyExited();
            /*0x1861b30*/ void set_fullyExited(bool value);
            /*0x1861a20*/ bool get_reentered();
            /*0x1861cd0*/ void set_reentered(bool value);
            /*0x1860d90*/ bool IsPointerMoving();
            /*0x1860dc0*/ bool IsScrolling();
            /*0x18617c0*/ UnityEngine.Camera get_enterEventCamera();
            /*0x1861910*/ UnityEngine.Camera get_pressEventCamera();
            /*0x79a150*/ UnityEngine.GameObject get_pointerPress();
            /*0x1861bf0*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x1860df0*/ string ToString();

            enum InputButton
            {
                Left = 0,
                Right = 1,
                Middle = 2,
            }

            enum FramePressState
            {
                Pressed = 0,
                Released = 1,
                PressedAndReleased = 2,
                NotChanged = 3,
            }
        }

        enum EventHandle
        {
            Unused = 0,
            Used = 1,
        }

        interface IEventSystemHandler
        {
        }

        interface IPointerMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x17aec0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class EventSystem : UnityEngine.EventSystems.UIBehaviour
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems;
            static /*0x8*/ System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer;
            static /*0x10*/ UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;
            /*0x28*/ UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;
            /*0x30*/ UnityEngine.GameObject m_FirstSelected;
            /*0x38*/ bool m_sendNavigationEvents;
            /*0x3c*/ int m_DragThreshold;
            /*0x40*/ UnityEngine.GameObject m_CurrentSelected;
            /*0x48*/ bool m_HasFocus;
            /*0x49*/ bool m_SelectionGuard;
            /*0x50*/ UnityEngine.EventSystems.BaseEventData m_DummyData;
            /*0x58*/ bool m_Started;
            /*0x59*/ bool m_IsTrackingUIToolkitPanels;

            static /*0x185a440*/ EventSystem();
            static /*0x185a700*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x185a910*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x1859210*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            static /*0x1859950*/ void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart);
            /*0x185a580*/ EventSystem();
            /*0xd180c0*/ bool get_sendNavigationEvents();
            /*0xd18610*/ void set_sendNavigationEvents(bool value);
            /*0xee1680*/ int get_pixelDragThreshold();
            /*0x136a430*/ void set_pixelDragThreshold(int value);
            /*0x79a150*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x997630*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x997640*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0xb61870*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x388e90*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0xe85db0*/ bool get_isFocused();
            /*0x185a090*/ void UpdateModules();
            /*0x10d9730*/ bool get_alreadySelecting();
            /*0x1859730*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x185a610*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x1859690*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x1859010*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x1858c60*/ bool IsPointerOverGameObject();
            /*0x1858bc0*/ bool IsPointerOverGameObject(int pointerId);
            /*0x185a7b0*/ bool get_isUIToolkitActiveEventSystem();
            /*0x185a8a0*/ bool get_sendUIToolkitEvents();
            /*0x185a690*/ bool get_createUIToolkitPanelGameObjectsOnStart();
            /*0x1859b10*/ void StartTrackingUIToolkitPanels();
            /*0x1859d90*/ void StopTrackingUIToolkitPanels();
            /*0x1858900*/ void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x1859d80*/ void Start();
            /*0x1858ea0*/ void OnEnable();
            /*0x1858d00*/ void OnDisable();
            /*0x1859e30*/ void TickModules();
            /*0x1858cf0*/ void OnApplicationFocus(bool hasFocus);
            /*0x185a1d0*/ void Update();
            /*0x18587f0*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x1859f30*/ string ToString();

            struct UIToolkitOverrideConfig
            {
                /*0x10*/ UnityEngine.EventSystems.EventSystem activeEventSystem;
                /*0x18*/ bool sendEvents;
                /*0x19*/ bool createPanelGameObjectsOnStart;
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.GameObject go;

                /*0x32f970*/ <>c__DisplayClass56_0();
                /*0x1869460*/ void <CreateUIToolkitPanelGameObject>b__0();
            }
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x31c640*/ EventTrigger();
            /*0x185ad50*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x7965a0*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x185ad60*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x7965a0*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x185aaa0*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185ace0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185acf0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ac70*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ac80*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185acd0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ad00*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185acc0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ad20*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185ac60*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185ad10*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185acb0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x185ad40*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185aca0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ac40*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ac90*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x185ad30*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x185ac50*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x1869420*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x1858760*/ Entry();
            }
        }

        enum EventTriggerType
        {
            PointerEnter = 0,
            PointerExit = 1,
            PointerDown = 2,
            PointerUp = 3,
            PointerClick = 4,
            Drag = 5,
            Drop = 6,
            Scroll = 7,
            UpdateSelected = 8,
            Select = 9,
            Deselect = 10,
            Move = 11,
            InitializePotentialDrag = 12,
            BeginDrag = 13,
            EndDrag = 14,
            Submit = 15,
            Cancel = 16,
        }

        class ExecuteEvents
        {
            static /*0x0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler;
            static /*0x8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler;
            static /*0x10*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler;
            static /*0x18*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler;
            static /*0x20*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler;
            static /*0x28*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler;
            static /*0x30*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler;
            static /*0x38*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler;
            static /*0x40*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler;
            static /*0x48*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler;
            static /*0x50*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler;
            static /*0x58*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler;
            static /*0x60*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler;
            static /*0x68*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler;
            static /*0x70*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler;
            static /*0x78*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler;
            static /*0x80*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler;
            static /*0x88*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler;
            static /*0x90*/ System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList;

            static /*0x185b9a0*/ ExecuteEvents();
            static /*0x2a5510*/ T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x185afe0*/ void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b300*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b120*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b080*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b730*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b260*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b690*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b1c0*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b5f0*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185aee0*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b400*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185ae40*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b7d0*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b590*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185ade0*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b4a0*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185b3a0*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185af80*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x185c550*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler();
            static /*0x185c4b0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x185c500*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x185c460*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x185c5a0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x185c410*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x185c370*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x185c180*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x185c280*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x185c320*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x185c2d0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x185c5f0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x185c6f0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x185c640*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x185c230*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x185c3c0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x185c690*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x185c1d0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x185b830*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
            static /*0x17f7b0*/ bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor);
            static /*0x177ba0*/ UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction);
            static /*0x177700*/ bool ShouldSendToComponent<T>(UnityEngine.Component component);
            static /*0x177670*/ void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results);
            static /*0x177700*/ bool CanHandleEvent<T>(UnityEngine.GameObject go);
            static /*0x17e030*/ UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root);

            class EventFunction<T1> : System.MulticastDelegate
            {
                EventFunction(object object, nint method);
                /*0x2a5510*/ void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData);
                /*0x2a5510*/ System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object);
                /*0x17aec0*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x31c640*/ BaseInput();
            /*0x1857f50*/ string get_compositionString();
            /*0x1857f60*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x1857fb0*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x1857f40*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x1857f90*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x17a4430*/ bool get_mousePresent();
            /*0x17a4360*/ bool GetMouseButtonDown(int button);
            /*0x17a4370*/ bool GetMouseButtonUp(int button);
            /*0x1857f30*/ bool GetMouseButton(int button);
            /*0x12d4a20*/ UnityEngine.Vector2 get_mousePosition();
            /*0x1857f70*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x1857f80*/ bool get_touchSupported();
            /*0x17a4440*/ int get_touchCount();
            /*0x17a4380*/ UnityEngine.Touch GetTouch(int index);
            /*0x1857f20*/ float GetAxisRaw(string axisName);
            /*0x17a4310*/ bool GetButtonDown(string buttonName);
        }

        class BaseInputModule : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;
            /*0x28*/ bool m_SendPointerHoverToParent;
            /*0x30*/ UnityEngine.EventSystems.AxisEventData m_AxisEventData;
            /*0x38*/ UnityEngine.EventSystems.EventSystem m_EventSystem;
            /*0x40*/ UnityEngine.EventSystems.BaseEventData m_BaseEventData;
            /*0x48*/ UnityEngine.EventSystems.BaseInput m_InputOverride;
            /*0x50*/ UnityEngine.EventSystems.BaseInput m_DefaultInput;

            static /*0x1856d40*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x1856b40*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x1856ac0*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x1856bb0*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x1857c70*/ BaseInputModule();
            /*0x4ba480*/ bool get_sendPointerHoverToParent();
            /*0xd18990*/ void set_sendPointerHoverToParent(bool value);
            /*0x1857cf0*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x4e40d0*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x4e4360*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x995140*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x1857bd0*/ void OnEnable();
            /*0x1857bb0*/ void OnDisable();
            /*0x180fc0*/ void Process();
            /*0x1857080*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x1856e80*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x1856fd0*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x348b00*/ bool IsPointerOverGameObject(int pointerId);
            /*0x1857c30*/ bool ShouldActivateModule();
            /*0x32d010*/ void DeactivateModule();
            /*0x32d010*/ void ActivateModule();
            /*0x32d010*/ void UpdateModule();
            /*0x3ce290*/ bool IsModuleSupported();
            /*0x1856a20*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x58*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x60*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x1863a70*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x1863e00*/ PointerInputModule();
            /*0x1863110*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x1863a10*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x1863210*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x1862730*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x1863ac0*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x18629a0*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x18629c0*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x1862970*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x18639c0*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x1863700*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x1863670*/ bool IsPointerOverGameObject(int pointerId);
            /*0x1862590*/ void ClearSelection();
            /*0x1863b80*/ string ToString();
            /*0x1862890*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x32f970*/ ButtonState();
                /*0x32f410*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x7963c0*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x417e30*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0xdcd9c0*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x185ccb0*/ MouseState();
                /*0x185c920*/ bool AnyPressesThisFrame();
                /*0x185c9e0*/ bool AnyReleasesThisFrame();
                /*0x185caa0*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x185cc50*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x32f970*/ MouseButtonEventData();
                /*0x185c8e0*/ bool PressedThisFrame();
                /*0x185c900*/ bool ReleasedThisFrame();
            }
        }

        class StandaloneInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            static float doubleClickTime = 0.30000001192092896;
            /*0x68*/ float m_PrevActionTime;
            /*0x6c*/ UnityEngine.Vector2 m_LastMoveVector;
            /*0x74*/ int m_ConsecutiveMoveCount;
            /*0x78*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x80*/ UnityEngine.Vector2 m_MousePosition;
            /*0x88*/ UnityEngine.GameObject m_CurrentFocusedGameObject;
            /*0x90*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x98*/ string m_HorizontalAxis;
            /*0xa0*/ string m_VerticalAxis;
            /*0xa8*/ string m_SubmitButton;
            /*0xb0*/ string m_CancelButton;
            /*0xb8*/ float m_InputActionsPerSecond;
            /*0xbc*/ float m_RepeatDelay;
            /*0xc0*/ bool m_ForceModuleActive;

            /*0x1867b70*/ StandaloneInputModule();
            /*0x388e90*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x183ec60*/ bool get_allowActivationOnMobileDevice();
            /*0x1867c80*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x183ec60*/ bool get_forceModuleActive();
            /*0x1867c80*/ void set_forceModuleActive(bool value);
            /*0x1867c60*/ float get_inputActionsPerSecond();
            /*0x1867c90*/ void set_inputActionsPerSecond(float value);
            /*0x1867c70*/ float get_repeatDelay();
            /*0x1867ca0*/ void set_repeatDelay(float value);
            /*0x9c7a50*/ string get_horizontalAxis();
            /*0x9c7a70*/ void set_horizontalAxis(string value);
            /*0xec32e0*/ string get_verticalAxis();
            /*0x13553e0*/ void set_verticalAxis(string value);
            /*0xbf2ca0*/ string get_submitButton();
            /*0xbf30d0*/ void set_submitButton(string value);
            /*0x136fc00*/ string get_cancelButton();
            /*0x1465d00*/ void set_cancelButton(string value);
            /*0x3ce290*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x1867a20*/ void UpdateModule();
            /*0x1866d10*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x18677e0*/ bool ShouldActivateModule();
            /*0x1865240*/ void ActivateModule();
            /*0x18653a0*/ void DeactivateModule();
            /*0x1866b30*/ void Process();
            /*0x1865c40*/ bool ProcessTouchEvents();
            /*0x1866410*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x1867440*/ bool SendSubmitEventToSelectedObject();
            /*0x18653b0*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x18670d0*/ bool SendMoveEventToSelectedObject();
            /*0x18657e0*/ void ProcessMouseEvent();
            /*0x348b00*/ bool ForceAutoSelect();
            /*0x1865520*/ void ProcessMouseEvent(int id);
            /*0x1867690*/ bool SendUpdateEventToSelectedObject();
            /*0x18657f0*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x7379f0*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

            enum InputMode
            {
                Mouse = 0,
                Buttons = 1,
            }
        }

        class TouchInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x68*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x70*/ UnityEngine.Vector2 m_MousePosition;
            /*0x78*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x80*/ bool m_ForceModuleActive;

            /*0x1869410*/ TouchInputModule();
            /*0x12c45f0*/ bool get_allowActivationOnStandalone();
            /*0x137dec0*/ void set_allowActivationOnStandalone(bool value);
            /*0x12c45f0*/ bool get_forceModuleActive();
            /*0x137dec0*/ void set_forceModuleActive(bool value);
            /*0x1869260*/ void UpdateModule();
            /*0x1867e20*/ bool IsModuleSupported();
            /*0x1868e90*/ bool ShouldActivateModule();
            /*0x18693d0*/ bool UseFakeInput();
            /*0x1868cd0*/ void Process();
            /*0x1867cb0*/ void FakeTouches();
            /*0x1867e70*/ void ProcessTouchEvents();
            /*0x18685f0*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x18653a0*/ void DeactivateModule();
            /*0x1868fb0*/ string ToString();
        }

        enum MoveDirection
        {
            Left = 0,
            Up = 1,
            Right = 2,
            Down = 3,
            None = 4,
        }

        class RaycasterManager
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters;

            static /*0x1864a70*/ RaycasterManager();
            static /*0x1864820*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x1864950*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x18649a0*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x31c640*/ BaseRaycaster();
            /*0x183150*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x1803b0*/ UnityEngine.Camera get_eventCamera();
            /*0x388e90*/ int get_priority();
            /*0x1858460*/ int get_sortOrderPriority();
            /*0x1858460*/ int get_renderOrderPriority();
            /*0x1858470*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x1858230*/ string ToString();
            /*0x18580e0*/ void OnEnable();
            /*0x1857fe0*/ void OnDisable();
            /*0x1857fc0*/ void OnCanvasHierarchyChanged();
            /*0x1857fc0*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x48*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x1860270*/ Physics2DRaycaster();
            /*0x185fa30*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x28*/ UnityEngine.Camera m_EventCamera;
            /*0x30*/ UnityEngine.LayerMask m_EventMask;
            /*0x34*/ int m_MaxRayIntersections;
            /*0x38*/ int m_LastMaxRayIntersections;
            /*0x40*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x1860270*/ PhysicsRaycaster();
            /*0x1860c00*/ UnityEngine.Camera get_eventCamera();
            /*0x1860b40*/ int get_depth();
            /*0x1860cd0*/ int get_finalEventMask();
            /*0xa79cc0*/ UnityEngine.LayerMask get_eventMask();
            /*0xa79cd0*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x995160*/ int get_maxRayIntersections();
            /*0x9952f0*/ void set_maxRayIntersections(int value);
            /*0x18602a0*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x1860630*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x18640d0*/ RaycastHitComparer();
                /*0x32f970*/ RaycastHitComparer();
                /*0x1864090*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
            }
        }

        struct RaycastResult
        {
            /*0x10*/ UnityEngine.GameObject m_GameObject;
            /*0x18*/ UnityEngine.EventSystems.BaseRaycaster module;
            /*0x20*/ float distance;
            /*0x24*/ float index;
            /*0x28*/ int depth;
            /*0x2c*/ int sortingGroupID;
            /*0x30*/ int sortingGroupOrder;
            /*0x34*/ int sortingLayer;
            /*0x38*/ int sortingOrder;
            /*0x3c*/ UnityEngine.Vector3 worldPosition;
            /*0x48*/ UnityEngine.Vector3 worldNormal;
            /*0x54*/ UnityEngine.Vector2 screenPosition;
            /*0x5c*/ int displayIndex;

            /*0x6937d0*/ UnityEngine.GameObject get_gameObject();
            /*0x792990*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x1864790*/ bool get_isValid();
            /*0x1864140*/ void Clear();
            /*0x1864230*/ string ToString();
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x31c640*/ UIBehaviour();
            /*0x32d010*/ void Awake();
            /*0x32d010*/ void OnEnable();
            /*0x32d010*/ void Start();
            /*0x32d010*/ void OnDisable();
            /*0x32d010*/ void OnDestroy();
            /*0x18694b0*/ bool IsActive();
            /*0x32d010*/ void OnRectTransformDimensionsChange();
            /*0x32d010*/ void OnBeforeTransformParentChanged();
            /*0x32d010*/ void OnTransformParentChanged();
            /*0x32d010*/ void OnDidApplyAnimationProperties();
            /*0x32d010*/ void OnCanvasGroupChanged();
            /*0x32d010*/ void OnCanvasHierarchyChanged();
            /*0x18694c0*/ bool IsDestroyed();
        }
    }
}

namespace UnityEditor
{
    namespace Rendering
    {
        namespace BuiltIn
        {
            namespace ShaderGraph
            {
                class MaterialAccess
                {
                    static /*0x185c8c0*/ int ReadMaterialRawRenderQueue(UnityEngine.Material mat);
                }
            }
        }

        namespace Universal
        {
            class MaterialAccess
            {
                static /*0x185c8c0*/ int ReadMaterialRawRenderQueue(UnityEngine.Material mat);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;
    static /*0xc*/ <PrivateImplementationDetails> 42A8A9AC3B7BF2FCFFA78CC56C2AEB497A48B76A4FD29A458053C90A20F4B4DC;
    static /*0x1613*/ <PrivateImplementationDetails> 565DF53BC65A11A162AE93A718C05D66754F9F116199DD29CED33BB2E7684475;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=5639
    {
    }

    struct __StaticArrayInitTypeSize=7430
    {
    }
}
