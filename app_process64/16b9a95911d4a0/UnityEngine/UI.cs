class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3ee77ac*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3ee78a0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            /*0x3ee78f8*/ AnimationTriggers();
            /*0x3ee78a8*/ string get_normalTrigger();
            /*0x3ee78b0*/ void set_normalTrigger(string value);
            /*0x3ee78b8*/ string get_highlightedTrigger();
            /*0x3ee78c0*/ void set_highlightedTrigger(string value);
            /*0x3ee78c8*/ string get_pressedTrigger();
            /*0x3ee78d0*/ void set_pressedTrigger(string value);
            /*0x3ee78d8*/ string get_selectedTrigger();
            /*0x3ee78e0*/ void set_selectedTrigger(string value);
            /*0x3ee78e8*/ string get_disabledTrigger();
            /*0x3ee78f0*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0x100*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x3ee79f0*/ Button();
            /*0x3ee7a90*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x3ee7a98*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x3ee7aa8*/ void Press();
            /*0x3ee7b40*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x3ee7b5c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x3ee7bd4*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x3ee7a88*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x3ee7c40*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x3ee7c68*/ void System.IDisposable.Dispose();
                /*0x3ee7c6c*/ bool MoveNext();
                /*0x3ee7d6c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x3ee7d74*/ void System.Collections.IEnumerator.Reset();
                /*0x3ee7dac*/ object System.Collections.IEnumerator.get_Current();
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
            /*0x1f30b78*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x1f30214*/ UnityEngine.Transform get_transform();
            /*0x1f309e4*/ void LayoutComplete();
            /*0x1f309e4*/ void GraphicUpdateComplete();
            /*0x1f2fe14*/ bool IsDestroyed();
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

            static /*0x3ee9808*/ CanvasUpdateRegistry();
            static /*0x3ee7ff4*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x3ee8be4*/ int ParentCount(UnityEngine.Transform child);
            static /*0x3ee8ca0*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x3ee8df8*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x3ee8ef0*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x3ee8f50*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x3ee9080*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x3ee90e0*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x3ee9418*/ void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x3ee9750*/ bool IsRebuildingLayout();
            static /*0x3ee97ac*/ bool IsRebuildingGraphics();
            /*0x3ee7db4*/ CanvasUpdateRegistry();
            /*0x3ee80a4*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x3ee8174*/ void CleanInvalidItems();
            /*0x3ee844c*/ void PerformUpdate();
            /*0x3ee8e58*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x3ee8fb0*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x3ee9150*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x3ee92b4*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x3ee9488*/ void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x3ee95ec*/ void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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

            static /*0x3ee9938*/ ColorBlock();
            static /*0x3ee9c68*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x3ee9cec*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0x3ee98a0*/ UnityEngine.Color get_normalColor();
            /*0x3ee98ac*/ void set_normalColor(UnityEngine.Color value);
            /*0x3ee98b8*/ UnityEngine.Color get_highlightedColor();
            /*0x3ee98c4*/ void set_highlightedColor(UnityEngine.Color value);
            /*0x3ee98d0*/ UnityEngine.Color get_pressedColor();
            /*0x3ee98dc*/ void set_pressedColor(UnityEngine.Color value);
            /*0x3ee98e8*/ UnityEngine.Color get_selectedColor();
            /*0x3ee98f4*/ void set_selectedColor(UnityEngine.Color value);
            /*0x3ee9900*/ UnityEngine.Color get_disabledColor();
            /*0x3ee990c*/ void set_disabledColor(UnityEngine.Color value);
            /*0x3ee9918*/ float get_colorMultiplier();
            /*0x3ee9920*/ void set_colorMultiplier(float value);
            /*0x3ee9928*/ float get_fadeDuration();
            /*0x3ee9930*/ void set_fadeDuration(float value);
            /*0x3ee99b0*/ bool Equals(object obj);
            /*0x3ee9a70*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0x3ee9d74*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x3ee8a50*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x3ee9e68*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x3ee9ed8*/ void Unregister(UnityEngine.UI.IClipper c);
            static /*0x3ee9f34*/ void Disable(UnityEngine.UI.IClipper c);
            /*0x3ee9de0*/ ClipperRegistry();
            /*0x3ee8ad4*/ void Cull();
        }

        class Clipping
        {
            static /*0x3ee9f90*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
        }

        interface IClipper
        {
            /*0x1f309e4*/ void PerformClipping();
        }

        interface IClippable
        {
            /*0x1f30214*/ UnityEngine.GameObject get_gameObject();
            /*0x1f309e4*/ void RecalculateClipping();
            /*0x1f30214*/ UnityEngine.RectTransform get_rectTransform();
            void Cull(UnityEngine.Rect clipRect, bool validRect);
            void SetClipRect(UnityEngine.Rect value, bool validRect);
            void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
        }

        class RectangularVertexClipper
        {
            /*0x10*/ UnityEngine.Vector3[] m_WorldCorners;
            /*0x18*/ UnityEngine.Vector3[] m_CanvasCorners;

            /*0x3eea2c8*/ RectangularVertexClipper();
            /*0x3eea164*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
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

            static /*0x3eeeed4*/ DefaultControls();
            static /*0x3eea348*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x3eea3a0*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x3eea508*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x3eea730*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x3eea80c*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x3eea630*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x3eea86c*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x3eea950*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eeaf64*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eeb394*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eeb53c*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eeb670*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eeb7a4*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eebef0*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eec3c0*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eec99c*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eed00c*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x3eee578*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                /*0x1f30394*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x3eef02c*/ DefaultRuntimeFactory();
                /*0x3eef024*/ DefaultRuntimeFactory();
                /*0x3eeefb8*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
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

            static /*0x3ef1e38*/ Dropdown();
            static /*0x1ffc854*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x3eef29c*/ Dropdown();
            /*0x3eef094*/ UnityEngine.RectTransform get_template();
            /*0x3eee318*/ void set_template(UnityEngine.RectTransform value);
            /*0x3eef09c*/ UnityEngine.UI.Text get_captionText();
            /*0x3eee338*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x3eef0a4*/ UnityEngine.UI.Image get_captionImage();
            /*0x3eef0ac*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x3eef0cc*/ UnityEngine.UI.Text get_itemText();
            /*0x3eee358*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x3eef0d4*/ UnityEngine.UI.Image get_itemImage();
            /*0x3eef0dc*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x3eee378*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x3eef0fc*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x3eef124*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x3eef12c*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x3eef13c*/ float get_alphaFadeSpeed();
            /*0x3eef144*/ void set_alphaFadeSpeed(float value);
            /*0x3eef14c*/ int get_value();
            /*0x3eef154*/ void set_value(int value);
            /*0x3eef294*/ void SetValueWithoutNotify(int input);
            /*0x3eef15c*/ void Set(int value, bool sendCallback);
            /*0x3eef494*/ void Awake();
            /*0x3eef590*/ void Start();
            /*0x3eef644*/ void OnDisable();
            /*0x3eee398*/ void RefreshShownValue();
            /*0x3eef8a4*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x3eef90c*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x3eefa5c*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x3eefbac*/ void ClearOptions();
            /*0x3eefc54*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x3ef0330*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x3ef0f94*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x3ef0f98*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x3ef0334*/ void Show();
            /*0x3ef1460*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x3ef1998*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x3ef19f0*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x3ef1a5c*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x3ef1ab4*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x3ef1b20*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x3ef10ac*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x3ef1b24*/ void AlphaFadeList(float duration, float alpha);
            /*0x3ef1350*/ void AlphaFadeList(float duration, float start, float end);
            /*0x3ef1bb0*/ void SetAlpha(float alpha);
            /*0x3ef0f9c*/ void Hide();
            /*0x3ef1c60*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x3eef6e4*/ void ImmediateDestroyDropdownList();
            /*0x3ef1d04*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x20*/ UnityEngine.UI.Text m_Text;
                /*0x28*/ UnityEngine.UI.Image m_Image;
                /*0x30*/ UnityEngine.RectTransform m_RectTransform;
                /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x3ef2010*/ DropdownItem();
                /*0x3ef1eb4*/ UnityEngine.UI.Text get_text();
                /*0x3ef1ebc*/ void set_text(UnityEngine.UI.Text value);
                /*0x3ef1ec4*/ UnityEngine.UI.Image get_image();
                /*0x3ef1ecc*/ void set_image(UnityEngine.UI.Image value);
                /*0x3ef1ed4*/ UnityEngine.RectTransform get_rectTransform();
                /*0x3ef1edc*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x3ef1ee4*/ UnityEngine.UI.Toggle get_toggle();
                /*0x3ef1eec*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x3ef1ef4*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x3ef1f70*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x3eee390*/ OptionData();
                /*0x3eefa2c*/ OptionData(string text);
                /*0x3eefb7c*/ OptionData(UnityEngine.Sprite image);
                /*0x3ef2038*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x3ef2018*/ string get_text();
                /*0x3ef2020*/ void set_text(string value);
                /*0x3ef2028*/ UnityEngine.Sprite get_image();
                /*0x3ef2030*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x3eef3c4*/ OptionDataList();
                /*0x3ef207c*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x3ef2084*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x3eef44c*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x3ef10a4*/ <>c__DisplayClass63_0();
                /*0x3ef208c*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x3ef1cdc*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x3ef20b0*/ void System.IDisposable.Dispose();
                /*0x3ef20b4*/ bool MoveNext();
                /*0x3ef216c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x3ef2174*/ void System.Collections.IEnumerator.Reset();
                /*0x3ef21ac*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x3ef21b4*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x3ef2244*/ FontData();
            /*0x3ef224c*/ UnityEngine.Font get_font();
            /*0x3ef2254*/ void set_font(UnityEngine.Font value);
            /*0x3ef225c*/ int get_fontSize();
            /*0x3ef2264*/ void set_fontSize(int value);
            /*0x3ef226c*/ UnityEngine.FontStyle get_fontStyle();
            /*0x3ef2274*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x3ef227c*/ bool get_bestFit();
            /*0x3ef2284*/ void set_bestFit(bool value);
            /*0x3ef228c*/ int get_minSize();
            /*0x3ef2294*/ void set_minSize(int value);
            /*0x3ef229c*/ int get_maxSize();
            /*0x3ef22a4*/ void set_maxSize(int value);
            /*0x3ef22ac*/ UnityEngine.TextAnchor get_alignment();
            /*0x3ef22b4*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x3ef22bc*/ bool get_alignByGeometry();
            /*0x3ef22c4*/ void set_alignByGeometry(bool value);
            /*0x3ef22cc*/ bool get_richText();
            /*0x3ef22d4*/ void set_richText(bool value);
            /*0x3ef22dc*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x3ef22e4*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x3ef22ec*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x3ef22f4*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x3ef22fc*/ float get_lineSpacing();
            /*0x3ef2304*/ void set_lineSpacing(float value);
            /*0x3ef230c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3ef2310*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x3ef29a4*/ FontUpdateTracker();
            static /*0x3ef2350*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x3ef2598*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x3ef279c*/ void UntrackText(UnityEngine.UI.Text t);
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

            static /*0x3ef60f0*/ Graphic();
            static /*0x3ef2a3c*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x3ef5004*/ UnityEngine.Mesh get_workerMesh();
            static /*0x3ef5ce0*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x3ef3054*/ Graphic();
            /*0x3ef2b28*/ UnityEngine.Color get_color();
            /*0x3ef2b34*/ void set_color(UnityEngine.Color value);
            /*0x3ef2b6c*/ bool get_raycastTarget();
            /*0x3ef2b74*/ void set_raycastTarget(bool value);
            /*0x3ef302c*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x3ef3038*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x3ef3044*/ bool get_useLegacyMeshGeneration();
            /*0x3ef304c*/ void set_useLegacyMeshGeneration(bool value);
            /*0x3ef3120*/ void SetAllDirty();
            /*0x3ef3268*/ void SetLayoutDirty();
            /*0x3ef3378*/ void SetVerticesDirty();
            /*0x3ef340c*/ void SetMaterialDirty();
            /*0x3ef3190*/ void SetRaycastDirty();
            /*0x3ef34a0*/ void OnRectTransformDimensionsChange();
            /*0x3ef354c*/ void OnBeforeTransformParentChanged();
            /*0x3ef3798*/ void OnTransformParentChanged();
            /*0x3ef3bf0*/ int get_depth();
            /*0x3ef3308*/ UnityEngine.RectTransform get_rectTransform();
            /*0x3ef2c50*/ UnityEngine.Canvas get_canvas();
            /*0x3ef3858*/ void CacheCanvas();
            /*0x3ef3c0c*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x3ef3cc4*/ UnityEngine.Material get_defaultMaterial();
            /*0x3ef3d10*/ UnityEngine.Material get_material();
            /*0x3ef3d98*/ void set_material(UnityEngine.Material value);
            /*0x3ef3e40*/ UnityEngine.Material get_materialForRendering();
            /*0x3ef4010*/ UnityEngine.Texture get_mainTexture();
            /*0x3ef4068*/ void OnEnable();
            /*0x3ef41a0*/ void OnDisable();
            /*0x3ef4468*/ void OnDestroy();
            /*0x3ef457c*/ void OnCanvasHierarchyChanged();
            /*0x3ef46c0*/ void OnCullingChanged();
            /*0x3ef474c*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x3ef4830*/ void LayoutComplete();
            /*0x3ef4834*/ void GraphicUpdateComplete();
            /*0x3ef4838*/ void UpdateMaterial();
            /*0x3ef48f0*/ void UpdateGeometry();
            /*0x3ef4c68*/ void DoMeshGeneration();
            /*0x3ef4900*/ void DoLegacyMeshGeneration();
            /*0x3ef5134*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x3ef5138*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x3ef51d0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x3ef5458*/ void OnDidApplyAnimationProperties();
            /*0x3ef5468*/ void SetNativeSize();
            /*0x3ef546c*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x3ef5918*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x3ef532c*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x3ef5a58*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x3ef5a6c*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x3ef5cf4*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x3ef5d90*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x3ef5e20*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x3ef5eb0*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x3ef5f40*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x3ef5fd0*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x3ef6060*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x3ef6194*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
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

            static /*0x3ef7584*/ GraphicRaycaster();
            static /*0x3ef6f9c*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x3ef6314*/ GraphicRaycaster();
            /*0x3ef619c*/ int get_sortOrderPriority();
            /*0x3ef6290*/ int get_renderOrderPriority();
            /*0x3ef62e4*/ bool get_ignoreReversedGraphics();
            /*0x3ef62ec*/ void set_ignoreReversedGraphics(bool value);
            /*0x3ef62f4*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0x3ef62fc*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0x3ef6304*/ UnityEngine.LayerMask get_blockingMask();
            /*0x3ef630c*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x3ef61e4*/ UnityEngine.Canvas get_canvas();
            /*0x3ef63b8*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x3ef74bc*/ UnityEngine.Camera get_eventCamera();

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

                static /*0x3ef761c*/ <>c();
                /*0x3ef7684*/ <>c();
                /*0x3ef768c*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x3ef7b84*/ GraphicRegistry();
            static /*0x3ef7898*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x3ef3a04*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x3ef2e40*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x3ef35f4*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x3ef2cc4*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x3ef42e8*/ void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x3ef7948*/ void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x3ef7ac8*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x3ef6ee0*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x3ef76d8*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            /*0x1f309e4*/ void OnSiblingGraphicEnabledDisabled();
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
            /*0xd8*/ UnityEngine.Sprite m_Sprite;
            /*0xe0*/ UnityEngine.Sprite m_OverrideSprite;
            /*0xe8*/ UnityEngine.UI.Image.Type m_Type;
            /*0xec*/ bool m_PreserveAspect;
            /*0xed*/ bool m_FillCenter;
            /*0xf0*/ UnityEngine.UI.Image.FillMethod m_FillMethod;
            /*0xf4*/ float m_FillAmount;
            /*0xf8*/ bool m_FillClockwise;
            /*0xfc*/ int m_FillOrigin;
            /*0x100*/ float m_AlphaHitTestMinimumThreshold;
            /*0x104*/ bool m_Tracked;
            /*0x105*/ bool m_UseSpriteMesh;
            /*0x108*/ float m_PixelsPerUnitMultiplier;
            /*0x10c*/ float m_CachedReferencePixelsPerUnit;

            static /*0x3efc8fc*/ Image();
            static /*0x3ef83fc*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x3efb924*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x3efb7d8*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x3efba00*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x3efbb30*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x3efc71c*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x3efb23c*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x3efb3d8*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x3ef83bc*/ Image();
            /*0x3ef7c14*/ UnityEngine.Sprite get_sprite();
            /*0x3eeac20*/ void set_sprite(UnityEngine.Sprite value);
            /*0x3ef7d98*/ void DisableSpriteOptimizations();
            /*0x3ef7da0*/ UnityEngine.Sprite get_overrideSprite();
            /*0x3ef7e1c*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x3ef7da4*/ UnityEngine.Sprite get_activeSprite();
            /*0x3ef7ea4*/ UnityEngine.UI.Image.Type get_type();
            /*0x3eeaeec*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x3ef7eac*/ bool get_preserveAspect();
            /*0x3ef7eb4*/ void set_preserveAspect(bool value);
            /*0x3ef7f30*/ bool get_fillCenter();
            /*0x3ef7f38*/ void set_fillCenter(bool value);
            /*0x3ef7fb4*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x3ef7fbc*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x3ef8038*/ float get_fillAmount();
            /*0x3ef8040*/ void set_fillAmount(float value);
            /*0x3ef80d0*/ bool get_fillClockwise();
            /*0x3ef80d8*/ void set_fillClockwise(bool value);
            /*0x3ef8154*/ int get_fillOrigin();
            /*0x3ef815c*/ void set_fillOrigin(int value);
            /*0x3ef81d4*/ float get_eventAlphaThreshold();
            /*0x3ef81e4*/ void set_eventAlphaThreshold(float value);
            /*0x3ef8330*/ float get_alphaHitTestMinimumThreshold();
            /*0x3ef81f0*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0x3ef8338*/ bool get_useSpriteMesh();
            /*0x3ef8340*/ void set_useSpriteMesh(bool value);
            /*0x3ef84e8*/ UnityEngine.Texture get_mainTexture();
            /*0x3ef8660*/ bool get_hasBorder();
            /*0x3ef8718*/ float get_pixelsPerUnitMultiplier();
            /*0x3ef8720*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x3ef8744*/ float get_pixelsPerUnit();
            /*0x3ef8838*/ float get_multipliedPixelsPerUnit();
            /*0x3ef8854*/ UnityEngine.Material get_material();
            /*0x3ef8980*/ void set_material(UnityEngine.Material value);
            /*0x3ef8984*/ void OnBeforeSerialize();
            /*0x3ef8988*/ void OnAfterDeserialize();
            /*0x3ef89dc*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x3ef8a78*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x3ef8e30*/ void SetNativeSize();
            /*0x3ef8f70*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x3ef7cac*/ void TrackSprite();
            /*0x3efb348*/ void OnEnable();
            /*0x3efb364*/ void OnDisable();
            /*0x3efb458*/ void UpdateMaterial();
            /*0x3efb54c*/ void OnCanvasHierarchyChanged();
            /*0x3ef90b8*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x3ef9364*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x3ef964c*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x3ef9c00*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x3efb654*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x3efa954*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x3efbf20*/ void CalculateLayoutInputHorizontal();
            /*0x3efbf24*/ void CalculateLayoutInputVertical();
            /*0x3efbf28*/ float get_minWidth();
            /*0x3efbf30*/ float get_preferredWidth();
            /*0x3efbff8*/ float get_flexibleWidth();
            /*0x3efc000*/ float get_minHeight();
            /*0x3efc008*/ float get_preferredHeight();
            /*0x3efc0d0*/ float get_flexibleHeight();
            /*0x3efc0d8*/ int get_layoutPriority();
            /*0x3efc0e0*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x3efc48c*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x3efc8c4*/ void OnDidApplyAnimationProperties();
            /*0x3ef7c1c*/ void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0();
            /*0x3efca68*/ bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1();

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
            /*0x1f2fe14*/ bool Enabled();
            /*0x1f30214*/ UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            /*0x1f309e4*/ void RecalculateMasking();
        }

        class InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement
        {
            static float kHScrollSpeed = 0.05000000074505806;
            static float kVScrollSpeed = 0.10000000149011612;
            static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
            static string kOculusQuestDeviceModel = "Oculus Quest";
            static int k_MaxTextLength = 16382;
            static /*0x0*/ char[] kSeparators;
            static /*0x8*/ bool s_IsQuestDeviceEvaluated;
            static /*0x9*/ bool s_IsQuestDevice;
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

            static /*0x40cd904*/ InputField();
            static /*0x40c6a78*/ string get_clipboard();
            static /*0x40c6ac8*/ void set_clipboard(string value);
            static /*0x40cbcc0*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x40c8cb4*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x40c4308*/ InputField();
            /*0x40c4164*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x40c4274*/ string get_compositionString();
            /*0x40c4650*/ UnityEngine.Mesh get_mesh();
            /*0x40c46f4*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x40c4764*/ void set_shouldHideMobileInput(bool value);
            /*0x40c47c8*/ bool get_shouldHideMobileInput();
            /*0x40c4850*/ void set_shouldActivateOnSelect(bool value);
            /*0x40c4858*/ bool get_shouldActivateOnSelect();
            /*0x40c48c8*/ string get_text();
            /*0x40c48d0*/ void set_text(string value);
            /*0x40c4c00*/ void SetTextWithoutNotify(string input);
            /*0x40c48d8*/ void SetText(string value, bool sendCallback);
            /*0x40c5140*/ bool get_isFocused();
            /*0x40c5148*/ float get_caretBlinkRate();
            /*0x40c5150*/ void set_caretBlinkRate(float value);
            /*0x40c5224*/ int get_caretWidth();
            /*0x40c522c*/ void set_caretWidth(int value);
            /*0x40c52f0*/ UnityEngine.UI.Text get_textComponent();
            /*0x40c52f8*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x40c5578*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x40c5580*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x40c55d8*/ UnityEngine.Color get_caretColor();
            /*0x40c561c*/ void set_caretColor(UnityEngine.Color value);
            /*0x40c5648*/ bool get_customCaretColor();
            /*0x40c5650*/ void set_customCaretColor(bool value);
            /*0x40c566c*/ UnityEngine.Color get_selectionColor();
            /*0x40c5680*/ void set_selectionColor(UnityEngine.Color value);
            /*0x40c56ac*/ UnityEngine.UI.InputField.EndEditEvent get_onEndEdit();
            /*0x40c56b4*/ void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value);
            /*0x40c570c*/ UnityEngine.UI.InputField.SubmitEvent get_onSubmit();
            /*0x40c5714*/ void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x40c576c*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x40c5774*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x40c57d0*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x40c5778*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x40c57d8*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x40c57e0*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x40c5838*/ int get_characterLimit();
            /*0x40c5840*/ void set_characterLimit(int value);
            /*0x40c58f4*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x40c58fc*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x40c5a70*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x40c5a78*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x40c5b98*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x40c5ba0*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x40c5c34*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x40c5c3c*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x40c5c44*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x40c5cc0*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x40c5cc8*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x40c5d44*/ bool get_readOnly();
            /*0x40c5d4c*/ void set_readOnly(bool value);
            /*0x40c5d54*/ bool get_multiLine();
            /*0x40c5d68*/ char get_asteriskChar();
            /*0x40c5d70*/ void set_asteriskChar(char value);
            /*0x40c5ddc*/ bool get_wasCanceled();
            /*0x40c5de4*/ void ClampPos(ref int pos);
            /*0x40c5e18*/ int get_caretPositionInternal();
            /*0x40c5e3c*/ void set_caretPositionInternal(int value);
            /*0x40c5e70*/ int get_caretSelectPositionInternal();
            /*0x40c5e94*/ void set_caretSelectPositionInternal(int value);
            /*0x40c5ec8*/ bool get_hasSelection();
            /*0x40c5ef8*/ int get_caretPosition();
            /*0x40c5f1c*/ void set_caretPosition(int value);
            /*0x40c5ff4*/ int get_selectionAnchorPosition();
            /*0x40c5f44*/ void set_selectionAnchorPosition(int value);
            /*0x40c6018*/ int get_selectionFocusPosition();
            /*0x40c5f9c*/ void set_selectionFocusPosition(int value);
            /*0x40c603c*/ void Awake();
            /*0x40c60fc*/ void OnEnable();
            /*0x40c635c*/ void OnDisable();
            /*0x40c6724*/ void OnDestroy();
            /*0x40c6788*/ System.Collections.IEnumerator CaretBlink();
            /*0x40c681c*/ void SetCaretVisible();
            /*0x40c51c4*/ void SetCaretActive();
            /*0x40c6850*/ void UpdateCaretMaterial();
            /*0x40c6960*/ void OnFocus();
            /*0x40c6964*/ void SelectAll();
            /*0x40c699c*/ void MoveTextEnd(bool shift);
            /*0x40c69fc*/ void MoveTextStart(bool shift);
            /*0x40c6b20*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x40c6bd8*/ bool InPlaceEditing();
            /*0x40c6c08*/ bool InPlaceEditingChanged();
            /*0x40c6c88*/ UnityEngine.RangeInt GetInternalSelection();
            /*0x40c6d3c*/ void UpdateKeyboardCaret();
            /*0x40c6e04*/ void UpdateCaretFromKeyboard();
            /*0x40c6efc*/ void LateUpdate();
            /*0x40c846c*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x40c8810*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x40c8a20*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x40c8e18*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c8ef0*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c8f10*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c9110*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c91c0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c91dc*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c93e4*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x40c9f14*/ bool IsValidChar(char c);
            /*0x40c9f84*/ void ProcessEvent(UnityEngine.Event e);
            /*0x40c9f88*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40c99c0*/ string GetSelectedString();
            /*0x40ca110*/ int FindtNextWordBegin();
            /*0x40c9dbc*/ void MoveRight(bool shift, bool ctrl);
            /*0x40ca1cc*/ int FindtPrevWordBegin();
            /*0x40c9c74*/ void MoveLeft(bool shift, bool ctrl);
            /*0x40ca26c*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x40ca37c*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x40ca6d4*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x40c9f0c*/ void MoveDown(bool shift);
            /*0x40ca988*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x40c9f04*/ void MoveUp(bool shift);
            /*0x40caae8*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x40c9a64*/ void Delete();
            /*0x40c9910*/ void ForwardSpace();
            /*0x40c97f4*/ void Backspace();
            /*0x40cac60*/ void Insert(char c);
            /*0x40c9c2c*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x40c8454*/ void SendOnValueChangedAndUpdateLabel();
            /*0x40c4cbc*/ void SendOnValueChanged();
            /*0x40cad70*/ void SendOnEndEdit();
            /*0x40c7d10*/ void SendOnSubmit();
            /*0x40cadf0*/ void Append(string input);
            /*0x40caeac*/ void Append(char input);
            /*0x40c4d3c*/ void UpdateLabel();
            /*0x40cbc54*/ bool IsSelectionVisible();
            /*0x40cb110*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x40cbe10*/ void ForceLabelUpdate();
            /*0x40c5298*/ void MarkGeometryAsDirty();
            /*0x40cbe14*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x40cc26c*/ void LayoutComplete();
            /*0x40cc270*/ void GraphicUpdateComplete();
            /*0x40cbe24*/ void UpdateGeometry();
            /*0x40c7810*/ void AssignPositioningIfNeeded();
            /*0x40cc274*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x40cc4ac*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x40cd2f4*/ void CreateCursorVerts();
            /*0x40ccbc0*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x40c7d90*/ char Validate(string text, int pos, char ch);
            /*0x40cd438*/ void ActivateInputField();
            /*0x40c74d4*/ void ActivateInputFieldInternal();
            /*0x40cd558*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40cd594*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40c659c*/ void DeactivateInputField();
            /*0x40cd5b0*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40cd5dc*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40c5968*/ void EnforceContentType();
            /*0x40c45ac*/ void EnforceTextHOverflow();
            /*0x40c5b30*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x40c5c1c*/ void SetToCustom();
            /*0x40cd624*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x40cd650*/ void CalculateLayoutInputHorizontal();
            /*0x40cd654*/ void CalculateLayoutInputVertical();
            /*0x40cd658*/ float get_minWidth();
            /*0x40cd660*/ float get_preferredWidth();
            /*0x40cd7ac*/ float get_flexibleWidth();
            /*0x40cd7b4*/ float get_minHeight();
            /*0x40cd7bc*/ float get_preferredHeight();
            /*0x40cd8f4*/ float get_flexibleHeight();
            /*0x40cd8fc*/ int get_layoutPriority();
            /*0x40cd9b4*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x40c4c08*/ OnValidateInput(object object, nint method);
                /*0x40cd9bc*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x40cd9d0*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x40cda54*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x40c44d4*/ SubmitEvent();
            }

            class EndEditEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x40c451c*/ EndEditEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x40c4564*/ OnChangeEvent();
            }

            enum EditState
            {
                Continue = 0,
                Finish = 1,
            }

            class <CaretBlink>d__172 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.InputField <>4__this;

                /*0x40c67f4*/ <CaretBlink>d__172(int <>1__state);
                /*0x40cda7c*/ void System.IDisposable.Dispose();
                /*0x40cda80*/ bool MoveNext();
                /*0x40cdba4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x40cdbac*/ void System.Collections.IEnumerator.Reset();
                /*0x40cdbe4*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__196 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x40c9198*/ <MouseDragOutsideRect>d__196(int <>1__state);
                /*0x40cdbec*/ void System.IDisposable.Dispose();
                /*0x40cdbf0*/ bool MoveNext();
                /*0x40cde78*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x40cde80*/ void System.Collections.IEnumerator.Reset();
                /*0x40cdeb8*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x40ce058*/ AspectRatioFitter();
            /*0x40cdec0*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x40cdec8*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x40cdf38*/ float get_aspectRatio();
            /*0x40cdf40*/ void set_aspectRatio(float value);
            /*0x40cdfac*/ UnityEngine.RectTransform get_rectTransform();
            /*0x40ce068*/ void OnEnable();
            /*0x40ce100*/ void Start();
            /*0x40ce244*/ void OnDisable();
            /*0x40ce698*/ void OnTransformParentChanged();
            /*0x40ce730*/ void Update();
            /*0x40ce744*/ void OnRectTransformDimensionsChange();
            /*0x40ce748*/ void UpdateRect();
            /*0x40cea90*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x40ce998*/ UnityEngine.Vector2 GetParentSize();
            /*0x40ceb84*/ void SetLayoutHorizontal();
            /*0x40ceb88*/ void SetLayoutVertical();
            /*0x40cdf34*/ void SetDirty();
            /*0x40ce150*/ bool IsComponentValidOnObject();
            /*0x40ce21c*/ bool IsAspectModeValid();
            /*0x40ceb8c*/ bool DoesParentExists();

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

            /*0x40cecb4*/ CanvasScaler();
            /*0x40ceb94*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x40ceb9c*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x40ceba4*/ float get_referencePixelsPerUnit();
            /*0x40cebac*/ void set_referencePixelsPerUnit(float value);
            /*0x40cebb4*/ float get_scaleFactor();
            /*0x40cebbc*/ void set_scaleFactor(float value);
            /*0x40cebd4*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x40cebdc*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x40cec48*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x40cec50*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x40cec58*/ float get_matchWidthOrHeight();
            /*0x40cec60*/ void set_matchWidthOrHeight(float value);
            /*0x40cec68*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x40cec70*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0x40cec78*/ float get_fallbackScreenDPI();
            /*0x40cec80*/ void set_fallbackScreenDPI(float value);
            /*0x40cec88*/ float get_defaultSpriteDPI();
            /*0x40cec90*/ void set_defaultSpriteDPI(float value);
            /*0x40ceca4*/ float get_dynamicPixelsPerUnit();
            /*0x40cecac*/ void set_dynamicPixelsPerUnit(float value);
            /*0x40cecfc*/ void OnEnable();
            /*0x40ceddc*/ void Canvas_preWillRenderCanvases();
            /*0x40cedec*/ void OnDisable();
            /*0x40cef14*/ void Handle();
            /*0x40cf018*/ void HandleWorldCanvas();
            /*0x40cf038*/ void HandleConstantPixelSize();
            /*0x40cf058*/ void HandleScaleWithScreenSize();
            /*0x40cf290*/ void HandleConstantPhysicalSize();
            /*0x40cee94*/ void SetScaleFactor(float scaleFactor);
            /*0x40ceed4*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

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

            /*0x40cf510*/ ContentSizeFitter();
            /*0x40cf2f8*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x40cf300*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x40cf3f0*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x40cf3f8*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x40cf464*/ UnityEngine.RectTransform get_rectTransform();
            /*0x40cf518*/ void OnEnable();
            /*0x40cf534*/ void OnDisable();
            /*0x40cf5b0*/ void OnRectTransformDimensionsChange();
            /*0x40cf5b4*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x40cf6a0*/ void SetLayoutHorizontal();
            /*0x40cf6c4*/ void SetLayoutVertical();
            /*0x40cf36c*/ void SetDirty();

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

            /*0x40cf974*/ GridLayoutGroup();
            /*0x40cf6cc*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x40cf6d4*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x40cf738*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x40cf740*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x40cf7a4*/ UnityEngine.Vector2 get_cellSize();
            /*0x40cf7ac*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x40cf81c*/ UnityEngine.Vector2 get_spacing();
            /*0x40cf824*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x40cf894*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x40cf89c*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x40cf900*/ int get_constraintCount();
            /*0x40cf908*/ void set_constraintCount(int value);
            /*0x40cfb38*/ void CalculateLayoutInputHorizontal();
            /*0x40d0120*/ void CalculateLayoutInputVertical();
            /*0x40d03e0*/ void SetLayoutHorizontal();
            /*0x40d0b48*/ void SetLayoutVertical();
            /*0x40d03e8*/ void SetCellsAlongAxis(int axis);

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
            /*0x40d0d50*/ HorizontalLayoutGroup();
            /*0x40d0d68*/ void CalculateLayoutInputHorizontal();
            /*0x40d1030*/ void CalculateLayoutInputVertical();
            /*0x40d103c*/ void SetLayoutHorizontal();
            /*0x40d169c*/ void SetLayoutVertical();
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

            /*0x40d0d5c*/ HorizontalOrVerticalLayoutGroup();
            /*0x40d16a8*/ float get_spacing();
            /*0x40d16b0*/ void set_spacing(float value);
            /*0x40d1714*/ bool get_childForceExpandWidth();
            /*0x40d171c*/ void set_childForceExpandWidth(bool value);
            /*0x40d1784*/ bool get_childForceExpandHeight();
            /*0x40d178c*/ void set_childForceExpandHeight(bool value);
            /*0x40d17f4*/ bool get_childControlWidth();
            /*0x40d17fc*/ void set_childControlWidth(bool value);
            /*0x40d1864*/ bool get_childControlHeight();
            /*0x40d186c*/ void set_childControlHeight(bool value);
            /*0x40d18d4*/ bool get_childScaleWidth();
            /*0x40d18dc*/ void set_childScaleWidth(bool value);
            /*0x40d1944*/ bool get_childScaleHeight();
            /*0x40d194c*/ void set_childScaleHeight(bool value);
            /*0x40d19b4*/ bool get_reverseArrangement();
            /*0x40d19bc*/ void set_reverseArrangement(bool value);
            /*0x40d0d88*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x40d1048*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x40d1a24*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
        }

        interface ILayoutElement
        {
            /*0x1f309e4*/ void CalculateLayoutInputHorizontal();
            /*0x1f309e4*/ void CalculateLayoutInputVertical();
            /*0x1f30804*/ float get_minWidth();
            /*0x1f30804*/ float get_preferredWidth();
            /*0x1f30804*/ float get_flexibleWidth();
            /*0x1f30804*/ float get_minHeight();
            /*0x1f30804*/ float get_preferredHeight();
            /*0x1f30804*/ float get_flexibleHeight();
            /*0x1f2ffc8*/ int get_layoutPriority();
        }

        interface ILayoutController
        {
            /*0x1f309e4*/ void SetLayoutHorizontal();
            /*0x1f309e4*/ void SetLayoutVertical();
        }

        interface ILayoutGroup : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutSelfController : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutIgnorer
        {
            /*0x1f2fe14*/ bool get_ignoreLayout();
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

            /*0x40d2590*/ LayoutElement();
            /*0x40d212c*/ bool get_ignoreLayout();
            /*0x40d2134*/ void set_ignoreLayout(bool value);
            /*0x40d225c*/ void CalculateLayoutInputHorizontal();
            /*0x40d2260*/ void CalculateLayoutInputVertical();
            /*0x40d2264*/ float get_minWidth();
            /*0x40d226c*/ void set_minWidth(float value);
            /*0x40d22d8*/ float get_minHeight();
            /*0x40d22e0*/ void set_minHeight(float value);
            /*0x40d234c*/ float get_preferredWidth();
            /*0x40d2354*/ void set_preferredWidth(float value);
            /*0x40d23c0*/ float get_preferredHeight();
            /*0x40d23c8*/ void set_preferredHeight(float value);
            /*0x40d2434*/ float get_flexibleWidth();
            /*0x40d243c*/ void set_flexibleWidth(float value);
            /*0x40d24a8*/ float get_flexibleHeight();
            /*0x40d24b0*/ void set_flexibleHeight(float value);
            /*0x40d251c*/ int get_layoutPriority();
            /*0x40d2524*/ void set_layoutPriority(int value);
            /*0x40d25b0*/ void OnEnable();
            /*0x40d25cc*/ void OnTransformParentChanged();
            /*0x40d25d0*/ void OnDisable();
            /*0x40d25ec*/ void OnDidApplyAnimationProperties();
            /*0x40d25f0*/ void OnBeforeTransformParentChanged();
            /*0x40d21a4*/ void SetDirty();
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

            /*0x40cf9dc*/ LayoutGroup();
            /*0x40d25f4*/ UnityEngine.RectOffset get_padding();
            /*0x40d25fc*/ void set_padding(UnityEngine.RectOffset value);
            /*0x40d2658*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x40d2660*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x40d0334*/ UnityEngine.RectTransform get_rectTransform();
            /*0x40d26c4*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x40cfcf8*/ void CalculateLayoutInputHorizontal();
            /*0x1f309e4*/ void CalculateLayoutInputVertical();
            /*0x40d26cc*/ float get_minWidth();
            /*0x40d26d4*/ float get_preferredWidth();
            /*0x40d26dc*/ float get_flexibleWidth();
            /*0x40d26e4*/ float get_minHeight();
            /*0x40d26ec*/ float get_preferredHeight();
            /*0x40d26f4*/ float get_flexibleHeight();
            /*0x40d26fc*/ int get_layoutPriority();
            /*0x1f309e4*/ void SetLayoutHorizontal();
            /*0x1f309e4*/ void SetLayoutVertical();
            /*0x40d2704*/ void OnEnable();
            /*0x40d27f4*/ void OnDisable();
            /*0x40d2870*/ void OnDidApplyAnimationProperties();
            /*0x40d20b4*/ float GetTotalMinSize(int axis);
            /*0x40d1fdc*/ float GetTotalPreferredSize(int axis);
            /*0x40d2048*/ float GetTotalFlexibleSize(int axis);
            /*0x40d0b50*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x40d1b40*/ float GetAlignmentOnAxis(int axis);
            /*0x40d00a4*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x40d2874*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x40d1db8*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x40d0ca0*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x40d1b78*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x40d291c*/ bool get_isRootLayoutGroup();
            /*0x40d2a48*/ void OnRectTransformDimensionsChange();
            /*0x40d2a78*/ void OnTransformChildrenChanged();
            /*0x1ffc854*/ void SetProperty<T>(ref T currentValue, T newValue);
            /*0x40d2720*/ void SetDirty();
            /*0x40d2a7c*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x40d2ae8*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x40d2b10*/ void System.IDisposable.Dispose();
                /*0x40d2b14*/ bool MoveNext();
                /*0x40d2bb4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x40d2bbc*/ void System.Collections.IEnumerator.Reset();
                /*0x40d2bf4*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x40d2c60*/ LayoutRebuilder();
            static /*0x40d2e4c*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x40d2f08*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x40d3008*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x40ce2c0*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x40d3ad4*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x40d3cbc*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x40d4094*/ LayoutRebuilder();
            /*0x40d2bfc*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x40d2c3c*/ void Clear();
            /*0x40d2ea0*/ UnityEngine.Transform get_transform();
            /*0x40d2ea8*/ bool IsDestroyed();
            /*0x40d317c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x40d3710*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x40d3448*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x40d3ea0*/ void LayoutComplete();
            /*0x40d3fcc*/ void GraphicUpdateComplete();
            /*0x40d3fd0*/ int GetHashCode();
            /*0x40d3fd8*/ bool Equals(object obj);
            /*0x40d4028*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x40d409c*/ <>c();
                /*0x40d4104*/ <>c();
                /*0x40d410c*/ UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0();
                /*0x40d4160*/ void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x);
                /*0x40d418c*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x40d4218*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x40d42d4*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x40d4390*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x40d4450*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x40cf688*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x40cf694*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x40d2120*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x40d4600*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x40d4898*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x40d4b30*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x40d4510*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x40d46f0*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x40d4a40*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x40d4c20*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x40d4c34*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

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

                static /*0x40d4f5c*/ <>c();
                /*0x40d4fc4*/ <>c();
                /*0x40d4fcc*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x40d506c*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x40d510c*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x40d51ac*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x40d524c*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x40d52ec*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x40d538c*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x40d542c*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x40d54cc*/ VerticalLayoutGroup();
            /*0x40d54d8*/ void CalculateLayoutInputHorizontal();
            /*0x40d54f8*/ void CalculateLayoutInputVertical();
            /*0x40d5504*/ void SetLayoutHorizontal();
            /*0x40d5510*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x20*/ UnityEngine.RectTransform m_RectTransform;
            /*0x28*/ bool m_ShowMaskGraphic;
            /*0x30*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x38*/ UnityEngine.Material m_MaskMaterial;
            /*0x40*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x40d56cc*/ Mask();
            /*0x40d551c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x40d5598*/ bool get_showMaskGraphic();
            /*0x40d55a0*/ void set_showMaskGraphic(bool value);
            /*0x40d5650*/ UnityEngine.UI.Graphic get_graphic();
            /*0x40d56dc*/ bool MaskEnabled();
            /*0x40d576c*/ void OnSiblingGraphicEnabledDisabled();
            /*0x40d5770*/ void OnEnable();
            /*0x40d5b58*/ void OnDisable();
            /*0x40d5d3c*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x40d5de8*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class MaskableGraphic : UnityEngine.UI.Graphic, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier
        {
            /*0xa1*/ bool m_ShouldRecalculateStencil;
            /*0xa8*/ UnityEngine.Material m_MaskMaterial;
            /*0xb0*/ UnityEngine.UI.RectMask2D m_ParentMask;
            /*0xb8*/ bool m_Maskable;
            /*0xb9*/ bool m_IsMaskingGraphic;
            /*0xba*/ bool m_IncludeForMasking;
            /*0xc0*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;
            /*0xc8*/ bool m_ShouldRecalculate;
            /*0xcc*/ int m_StencilValue;
            /*0xd0*/ UnityEngine.Vector3[] m_Corners;

            /*0x40d7234*/ MaskableGraphic();
            /*0x40d64fc*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x40d6504*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x40d650c*/ bool get_maskable();
            /*0x40d6514*/ void set_maskable(bool value);
            /*0x40d6544*/ bool get_isMaskingGraphic();
            /*0x40d58cc*/ void set_isMaskingGraphic(bool value);
            /*0x40d654c*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x40d665c*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x40d68c4*/ void UpdateCull(bool cull);
            /*0x40d69ac*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x40d6a1c*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x40d6a54*/ void OnEnable();
            /*0x40d6c04*/ void OnDisable();
            /*0x40d6cc0*/ void OnTransformParentChanged();
            /*0x40d6d10*/ void ParentMaskStateChanged();
            /*0x40d6d14*/ void OnCanvasHierarchyChanged();
            /*0x40d6720*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x40d6aa4*/ void UpdateClipParent();
            /*0x40d71a4*/ void RecalculateClipping();
            /*0x40d71a8*/ void RecalculateMasking();
            /*0x40d7350*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x40d7308*/ CullStateChangedEvent();
            }
        }

        class MaskUtilities
        {
            static /*0x40d7358*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x40d58e4*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x40d60bc*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x40d6264*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x40d75d0*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x40d6d64*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x40d7728*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x40d7aac*/ MaskUtilities();
        }

        interface IMaterialModifier
        {
            /*0x1f302cc*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x40d7af4*/ void Destroy(UnityEngine.Object obj);
            static /*0x40d7c18*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x40d7cf0*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x40d81d8*/ UnityEngine.Vector3 GetRelativeMousePositionForRaycast(UnityEngine.EventSystems.PointerEventData eventData);
            static /*0x40d7d5c*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position, int displayIndex);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x40d8300*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0x40d82a0*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0x40d82a8*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0x40d82b0*/ bool get_wrapAround();
            /*0x40d82b8*/ void set_wrapAround(bool value);
            /*0x40d82c0*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0x40d82c8*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0x40d82d0*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0x40d82d8*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0x40d82e0*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0x40d82e8*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0x40d82f0*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0x40d82f8*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0x40d831c*/ bool Equals(UnityEngine.UI.Navigation other);

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
            /*0xd8*/ UnityEngine.Texture m_Texture;
            /*0xe0*/ UnityEngine.Rect m_UVRect;

            /*0x40d8434*/ RawImage();
            /*0x40d845c*/ UnityEngine.Texture get_mainTexture();
            /*0x40d85b4*/ UnityEngine.Texture get_texture();
            /*0x40d85bc*/ void set_texture(UnityEngine.Texture value);
            /*0x40d8678*/ UnityEngine.Rect get_uvRect();
            /*0x40d8684*/ void set_uvRect(UnityEngine.Rect value);
            /*0x40d86d0*/ void SetNativeSize();
            /*0x40d8980*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x40d91b4*/ void OnDidApplyAnimationProperties();
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

            /*0x40d9478*/ RectMask2D();
            /*0x40d91f0*/ UnityEngine.Vector4 get_padding();
            /*0x40d91fc*/ void set_padding(UnityEngine.Vector4 value);
            /*0x40d920c*/ UnityEngine.Vector2Int get_softness();
            /*0x40d9214*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x40d9234*/ UnityEngine.Canvas get_Canvas();
            /*0x40d93b8*/ UnityEngine.Rect get_canvasRect();
            /*0x40d93fc*/ UnityEngine.RectTransform get_rectTransform();
            /*0x40d9618*/ void OnEnable();
            /*0x40d964c*/ void OnDisable();
            /*0x40d974c*/ void OnDestroy();
            /*0x40d976c*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x40d9848*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x40d9944*/ void PerformClipping();
            /*0x40da35c*/ void UpdateClipSoftness();
            /*0x40da738*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x40da84c*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x40da9ec*/ void OnTransformParentChanged();
            /*0x40daa1c*/ void OnCanvasHierarchyChanged();
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

            /*0x40dae0c*/ Scrollbar();
            /*0x40daa4c*/ UnityEngine.RectTransform get_handleRect();
            /*0x40daa54*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x40dad98*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x40dada0*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x40db05c*/ float get_value();
            /*0x40db104*/ void set_value(float value);
            /*0x40db1d4*/ void SetValueWithoutNotify(float input);
            /*0x40db1dc*/ float get_size();
            /*0x40db1e4*/ void set_size(float value);
            /*0x40db268*/ int get_numberOfSteps();
            /*0x40db270*/ void set_numberOfSteps(int value);
            /*0x40db2ec*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x40db2f4*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x40db304*/ float get_stepSize();
            /*0x40db330*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x40db334*/ void LayoutComplete();
            /*0x40db338*/ void GraphicUpdateComplete();
            /*0x40db33c*/ void OnEnable();
            /*0x40db63c*/ void OnDisable();
            /*0x40db790*/ void Update();
            /*0x40daad0*/ void UpdateCachedReferences();
            /*0x40db10c*/ void Set(float input, bool sendCallback);
            /*0x40db7a4*/ void OnRectTransformDimensionsChange();
            /*0x40db7dc*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x40db7ec*/ bool get_reverseValue();
            /*0x40dabdc*/ void UpdateVisuals();
            /*0x40db800*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40db914*/ void UpdateDrag(UnityEngine.RectTransform containerRect, UnityEngine.Vector2 position, UnityEngine.Camera camera);
            /*0x40dba9c*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x40dbb0c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dbb70*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dbd24*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dbdb4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dc018*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dbf7c*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x40dc080*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dc0b8*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x40dc394*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x40dc490*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x40dc58c*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x40dc688*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x40dc784*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dc798*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x40dc920*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x40daed8*/ ScrollEvent();
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }

            class <ClickRepeat>d__59 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Scrollbar <>4__this;
                /*0x28*/ UnityEngine.Vector2 screenPosition;
                /*0x30*/ UnityEngine.Camera camera;

                /*0x40dc058*/ <ClickRepeat>d__59(int <>1__state);
                /*0x40dc928*/ void System.IDisposable.Dispose();
                /*0x40dc92c*/ bool MoveNext();
                /*0x40dca48*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x40dca50*/ void System.Collections.IEnumerator.Reset();
                /*0x40dca88*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x40de760*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x40dfde4*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x40dff04*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x40dff80*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x40e00d4*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x40dd1dc*/ ScrollRect();
            /*0x40dca90*/ UnityEngine.RectTransform get_content();
            /*0x40dca98*/ void set_content(UnityEngine.RectTransform value);
            /*0x40dcaa0*/ bool get_horizontal();
            /*0x40dcaa8*/ void set_horizontal(bool value);
            /*0x40dcab0*/ bool get_vertical();
            /*0x40dcab8*/ void set_vertical(bool value);
            /*0x40dcac0*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0x40dcac8*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x40dcad0*/ float get_elasticity();
            /*0x40dcad8*/ void set_elasticity(float value);
            /*0x40dcae0*/ bool get_inertia();
            /*0x40dcae8*/ void set_inertia(bool value);
            /*0x40dcaf0*/ float get_decelerationRate();
            /*0x40dcaf8*/ void set_decelerationRate(float value);
            /*0x40dcb00*/ float get_scrollSensitivity();
            /*0x40dcb08*/ void set_scrollSensitivity(float value);
            /*0x40dcb10*/ UnityEngine.RectTransform get_viewport();
            /*0x40dcb18*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x40dcbfc*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x40dcc04*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x40dcd9c*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x40dcda4*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x40dcf3c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x40dcf44*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x40dcf4c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x40dcf54*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x40dcf5c*/ float get_horizontalScrollbarSpacing();
            /*0x40dcf64*/ void set_horizontalScrollbarSpacing(float value);
            /*0x40dcff4*/ float get_verticalScrollbarSpacing();
            /*0x40dcffc*/ void set_verticalScrollbarSpacing(float value);
            /*0x40dd004*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0x40dd00c*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x40dd014*/ UnityEngine.RectTransform get_viewRect();
            /*0x40dd124*/ UnityEngine.Vector2 get_velocity();
            /*0x40dd12c*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x40dd134*/ UnityEngine.RectTransform get_rectTransform();
            /*0x40dd33c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x40ddce0*/ void LayoutComplete();
            /*0x40ddce4*/ void GraphicUpdateComplete();
            /*0x40dd3c4*/ void UpdateCachedData();
            /*0x40ddce8*/ void OnEnable();
            /*0x40ddea4*/ void OnDisable();
            /*0x40de0d4*/ bool IsActive();
            /*0x40de154*/ void EnsureLayoutHasRebuilt();
            /*0x40de1c8*/ void StopMovement();
            /*0x40de218*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x40de3b8*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40de418*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40de544*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40de564*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40de798*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x40de84c*/ void LateUpdate();
            /*0x40ddc08*/ void UpdatePrevData();
            /*0x40dda80*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x40dedfc*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x40df05c*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x40dee6c*/ float get_horizontalNormalizedPosition();
            /*0x40df0a4*/ void set_horizontalNormalizedPosition(float value);
            /*0x40def64*/ float get_verticalNormalizedPosition();
            /*0x40df0b8*/ void set_verticalNormalizedPosition(float value);
            /*0x40df0cc*/ void SetHorizontalNormalizedPosition(float value);
            /*0x40df0e0*/ void SetVerticalNormalizedPosition(float value);
            /*0x40df0f4*/ void SetNormalizedPosition(float value, int axis);
            /*0x40df39c*/ void OnRectTransformDimensionsChange();
            /*0x40df3a0*/ bool get_hScrollingNeeded();
            /*0x40df428*/ bool get_vScrollingNeeded();
            /*0x40df4b0*/ void CalculateLayoutInputHorizontal();
            /*0x40df4b4*/ void CalculateLayoutInputVertical();
            /*0x40df4b8*/ float get_minWidth();
            /*0x40df4c0*/ float get_preferredWidth();
            /*0x40df4c8*/ float get_flexibleWidth();
            /*0x40df4d0*/ float get_minHeight();
            /*0x40df4d8*/ float get_preferredHeight();
            /*0x40df4e0*/ float get_flexibleHeight();
            /*0x40df4e8*/ int get_layoutPriority();
            /*0x40df4f0*/ void SetLayoutHorizontal();
            /*0x40dfad0*/ void SetLayoutVertical();
            /*0x40dee2c*/ void UpdateScrollbarVisibility();
            /*0x40dfb84*/ void UpdateScrollbarLayout();
            /*0x40dd71c*/ void UpdateBounds();
            /*0x40df9d0*/ UnityEngine.Bounds GetBounds();
            /*0x40de388*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x40dcf6c*/ void SetDirty();
            /*0x40dcb34*/ void SetDirtyCaching();
            /*0x40e0218*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x40dd2f4*/ ScrollRectEvent();
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

            static /*0x40e1d1c*/ Selectable();
            static /*0x40e0220*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x40e02bc*/ int get_allSelectableCount();
            static /*0x40e0314*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x40e03b0*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x40e18c4*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x40daf20*/ Selectable();
            /*0x40e046c*/ UnityEngine.UI.Navigation get_navigation();
            /*0x40e0484*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0x40e0568*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x40e0570*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x40e05dc*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x40e05ec*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x40e066c*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x40e0678*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x40e06f0*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x40e06f8*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x40e076c*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x40e0774*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x40e07e8*/ bool get_interactable();
            /*0x40e07f0*/ void set_interactable(bool value);
            /*0x40e0958*/ bool get_isPointerInside();
            /*0x40e0960*/ void set_isPointerInside(bool value);
            /*0x40e0968*/ bool get_isPointerDown();
            /*0x40e0970*/ void set_isPointerDown(bool value);
            /*0x40e0978*/ bool get_hasSelection();
            /*0x40e0980*/ void set_hasSelection(bool value);
            /*0x40e0988*/ UnityEngine.UI.Image get_image();
            /*0x40e0a04*/ void set_image(UnityEngine.UI.Image value);
            /*0x40e0a0c*/ UnityEngine.Animator get_animator();
            /*0x40e0a68*/ void Awake();
            /*0x40e0b10*/ void OnCanvasGroupChanged();
            /*0x40e0b44*/ bool ParentGroupAllowsInteraction();
            /*0x40e0cd4*/ bool IsInteractable();
            /*0x40e0cf4*/ void OnDidApplyAnimationProperties();
            /*0x40db36c*/ void OnEnable();
            /*0x40e0d48*/ void OnTransformParentChanged();
            /*0x40e0504*/ void OnSetProperty();
            /*0x40db65c*/ void OnDisable();
            /*0x40e0d70*/ void OnApplicationFocus(bool hasFocus);
            /*0x40e0cf8*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x40e0e18*/ void InstantClearState();
            /*0x40e11b8*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x40e1428*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x40e1a44*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x40dc3b8*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x40dc4b4*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x40dc5b0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x40dc6ac*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x40dc2fc*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x40e0e78*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x40e0f88*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x40e1030*/ void TriggerAnimation(string triggername);
            /*0x40e1afc*/ bool IsHighlighted();
            /*0x40e0dcc*/ bool IsPressed();
            /*0x40e1b58*/ void EvaluateAndTransitionToSelectionState();
            /*0x40dbe4c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40dc098*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e1bf0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e1bfc*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e1c04*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40e1c10*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40e1c18*/ void Select();

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
            static /*0x40e1da0*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
            static /*0x1ffc854*/ bool SetStruct<T>(ref T currentValue, T newValue);
            static /*0x1ffc854*/ bool SetClass<T>(ref T currentValue, T newValue);
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

            /*0x40e2954*/ Slider();
            /*0x40e1dec*/ UnityEngine.RectTransform get_fillRect();
            /*0x40e1df4*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x40e2474*/ UnityEngine.RectTransform get_handleRect();
            /*0x40e247c*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x40e24f8*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x40e2500*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x40e256c*/ float get_minValue();
            /*0x40e2574*/ void set_minValue(float value);
            /*0x40e25fc*/ float get_maxValue();
            /*0x40e2604*/ void set_maxValue(float value);
            /*0x40e268c*/ bool get_wholeNumbers();
            /*0x40e2694*/ void set_wholeNumbers(bool value);
            /*0x40e2720*/ float get_value();
            /*0x40e27c0*/ void set_value(float value);
            /*0x40e27d4*/ void SetValueWithoutNotify(float input);
            /*0x40e27e8*/ float get_normalizedValue();
            /*0x40e28d4*/ void set_normalizedValue(float value);
            /*0x40e2910*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x40e2918*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x40e2928*/ float get_stepSize();
            /*0x40e2a64*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x40e2a68*/ void LayoutComplete();
            /*0x40e2a6c*/ void GraphicUpdateComplete();
            /*0x40e2a70*/ void OnEnable();
            /*0x40e2aac*/ void OnDisable();
            /*0x40e2acc*/ void Update();
            /*0x40e2b08*/ void OnDidApplyAnimationProperties();
            /*0x40e1e70*/ void UpdateCachedReferences();
            /*0x40e2ce8*/ float ClampValue(float input);
            /*0x40e2dc0*/ void Set(float input, bool sendCallback);
            /*0x40e2e7c*/ void OnRectTransformDimensionsChange();
            /*0x40e2db0*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x40e2d9c*/ bool get_reverseValue();
            /*0x40e2194*/ void UpdateVisuals();
            /*0x40e2eb4*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x40e30b4*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e3118*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e32e0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e3330*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x40e3578*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x40e359c*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x40e35c0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x40e35e4*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x40e3608*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e361c*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x40e37a4*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x40e2a1c*/ SliderEvent();
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

            /*0x40e37ac*/ UnityEngine.Sprite get_highlightedSprite();
            /*0x40e37b4*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0x40e37bc*/ UnityEngine.Sprite get_pressedSprite();
            /*0x40e37c4*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0x40e37cc*/ UnityEngine.Sprite get_selectedSprite();
            /*0x40e37d4*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0x40e37dc*/ UnityEngine.Sprite get_disabledSprite();
            /*0x40e37e4*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0x40e37ec*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x40e4660*/ StencilMaterial();
            static /*0x40e38f4*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x40e38fc*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x40e4270*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x40e3988*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x40e4328*/ void Remove(UnityEngine.Material customMat);
            static /*0x40e44e4*/ void ClearAll();

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

                /*0x40e4318*/ MatEntry();
            }
        }

        class Text : UnityEngine.UI.MaskableGraphic, UnityEngine.UI.ILayoutElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultText;
            /*0xd8*/ UnityEngine.UI.FontData m_FontData;
            /*0xe0*/ string m_Text;
            /*0xe8*/ UnityEngine.TextGenerator m_TextCache;
            /*0xf0*/ UnityEngine.TextGenerator m_TextCacheForLayout;
            /*0xf8*/ bool m_DisableFontTextureRebuiltCallback;
            /*0x100*/ UnityEngine.UIVertex[] m_TempVerts;

            static /*0x40e5798*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x40e46f8*/ Text();
            /*0x40e479c*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x40e4834*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x40e48a4*/ UnityEngine.Texture get_mainTexture();
            /*0x40e4a64*/ void FontTextureChanged();
            /*0x40e4a4c*/ UnityEngine.Font get_font();
            /*0x40e4b78*/ void set_font(UnityEngine.Font value);
            /*0x40e4c94*/ string get_text();
            /*0x40e4c9c*/ void set_text(string value);
            /*0x40e4d80*/ bool get_supportRichText();
            /*0x40e4d98*/ void set_supportRichText(bool value);
            /*0x40e4df8*/ bool get_resizeTextForBestFit();
            /*0x40e4e10*/ void set_resizeTextForBestFit(bool value);
            /*0x40e4e70*/ int get_resizeTextMinSize();
            /*0x40e4e88*/ void set_resizeTextMinSize(int value);
            /*0x40e4edc*/ int get_resizeTextMaxSize();
            /*0x40e4ef4*/ void set_resizeTextMaxSize(int value);
            /*0x40e4f48*/ UnityEngine.TextAnchor get_alignment();
            /*0x40e4f60*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x40e4fb4*/ bool get_alignByGeometry();
            /*0x40e4fcc*/ void set_alignByGeometry(bool value);
            /*0x40e500c*/ int get_fontSize();
            /*0x40e5024*/ void set_fontSize(int value);
            /*0x40e5078*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x40e5090*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x40e50e4*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x40e50fc*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x40e5150*/ float get_lineSpacing();
            /*0x40e5168*/ void set_lineSpacing(float value);
            /*0x40e51bc*/ UnityEngine.FontStyle get_fontStyle();
            /*0x40e51d4*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x40e5228*/ float get_pixelsPerUnit();
            /*0x40e5370*/ void OnEnable();
            /*0x40e53ec*/ void OnDisable();
            /*0x40e5450*/ void UpdateGeometry();
            /*0x40e54d8*/ void AssignDefaultFont();
            /*0x40e5548*/ void AssignDefaultFontIfNecessary();
            /*0x40e5604*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x40e5804*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x40e5e84*/ void CalculateLayoutInputHorizontal();
            /*0x40e5e88*/ void CalculateLayoutInputVertical();
            /*0x40e5e8c*/ float get_minWidth();
            /*0x40e5e94*/ float get_preferredWidth();
            /*0x40e5f58*/ float get_flexibleWidth();
            /*0x40e5f60*/ float get_minHeight();
            /*0x40e5f68*/ float get_preferredHeight();
            /*0x40e5ff8*/ float get_flexibleHeight();
            /*0x40e6000*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0x100*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x108*/ UnityEngine.UI.Graphic graphic;
            /*0x110*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x118*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x120*/ bool m_IsOn;

            /*0x40e623c*/ Toggle();
            /*0x40e6008*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x40e6010*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x40e631c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x40e6320*/ void LayoutComplete();
            /*0x40e6324*/ void GraphicUpdateComplete();
            /*0x40e6328*/ void OnDestroy();
            /*0x40e6768*/ void OnEnable();
            /*0x40e6794*/ void OnDisable();
            /*0x40e67b4*/ void OnDidApplyAnimationProperties();
            /*0x40e6030*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x40e6cac*/ bool get_isOn();
            /*0x40e6cb4*/ void set_isOn(bool value);
            /*0x40e6cbc*/ void SetIsOnWithoutNotify(bool value);
            /*0x40e68d8*/ void Set(bool value, bool sendCallback);
            /*0x40e6178*/ void PlayEffect(bool instant);
            /*0x40e6e0c*/ void Start();
            /*0x40e6e14*/ void InternalToggle();
            /*0x40e6e68*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40e6e84*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40e6e88*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x40e62d4*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ bool m_AllowSwitchOff;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x40e6ea0*/ ToggleGroup();
            /*0x40e6e90*/ bool get_allowSwitchOff();
            /*0x40e6e98*/ void set_allowSwitchOff(bool value);
            /*0x40e6f28*/ void Start();
            /*0x40e6f44*/ void OnEnable();
            /*0x40e6f60*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x40e6b68*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x40e6a48*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x40e6ad8*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x40e63a8*/ void EnsureValidState();
            /*0x40e6cc4*/ bool AnyTogglesOn();
            /*0x40e70a8*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x40e71a4*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x40e7238*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x40e7340*/ <>c();
                /*0x40e73a8*/ <>c();
                /*0x40e73b0*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x40e73c4*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
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

            static /*0x40e816c*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x40e73d8*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x40e81f0*/ Raycast3DCallback(object object, nint method);
                /*0x40e8290*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x40e82d0*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x40e83d0*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x40e83f8*/ RaycastAllCallback(object object, nint method);
                /*0x40e8498*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x40e84d4*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x40e859c*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x40e85a8*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x40e8648*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x40e8684*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x40e8750*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x40e8778*/ Raycast2DCallback(object object, nint method);
                /*0x40e8818*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x40e882c*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x40e8908*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x40e8940*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x40e89e0*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x40e8a1c*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x40e8ae4*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x40e8af0*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x40e8b90*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x40e8bcc*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x40e8c98*/ int EndInvoke(System.IAsyncResult result);
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

            static /*0x40e9d48*/ VertexHelper();
            /*0x40e8cc0*/ VertexHelper();
            /*0x40e8cc8*/ VertexHelper(UnityEngine.Mesh m);
            /*0x40e8f04*/ void InitializeListIfRequired();
            /*0x40e90f8*/ void Dispose();
            /*0x40d8c48*/ void Clear();
            /*0x40e9360*/ int get_currentVertCount();
            /*0x40e93ac*/ int get_currentIndexCount();
            /*0x40e93f8*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x40e9594*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x40e9730*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x40e9890*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x40e9a50*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x40d8fd4*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x40e9b68*/ void AddVert(UnityEngine.UIVertex v);
            /*0x40d9104*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x40e5d78*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x40e9bfc*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x40e9ca8*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x40e9cf8*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x40e9de0*/ BaseVertexEffect();
            /*0x1f30ebc*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x20*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x40ea1e4*/ BaseMeshEffect();
            /*0x40e9de8*/ UnityEngine.UI.Graphic get_graphic();
            /*0x40e9e94*/ void OnEnable();
            /*0x40e9f3c*/ void OnDisable();
            /*0x40e9fd8*/ void OnDidApplyAnimationProperties();
            /*0x40ea074*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x1f30ebc*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        interface IVertexModifier
        {
            /*0x1f30ebc*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
        }

        interface IMeshModifier
        {
            /*0x1f30ebc*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x1f30ebc*/ void ModifyMesh(UnityEngine.UI.VertexHelper verts);
        }

        class Outline : UnityEngine.UI.Shadow
        {
            /*0x40ea1ec*/ Outline();
            /*0x40ea1f4*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x40ea434*/ PositionAsUV1();
            /*0x40ea43c*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x28*/ UnityEngine.Color m_EffectColor;
            /*0x38*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x40*/ bool m_UseGraphicAlpha;

            /*0x40ea50c*/ Shadow();
            /*0x40ea534*/ UnityEngine.Color get_effectColor();
            /*0x40ea540*/ void set_effectColor(UnityEngine.Color value);
            /*0x40ea614*/ UnityEngine.Vector2 get_effectDistance();
            /*0x40ea61c*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x40ea71c*/ bool get_useGraphicAlpha();
            /*0x40ea724*/ void set_useGraphicAlpha(bool value);
            /*0x40ea7dc*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x40eaa6c*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x40eaa74*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;
                /*0x0*/ int m_EnabledObjectCount;

                /*0x1f309e4*/ IndexedSet();
                /*0x1ffc854*/ void Add(T item);
                /*0x1ffc854*/ void Add(T item, bool isActive);
                /*0x1ffc854*/ bool AddUnique(T item, bool isActive);
                /*0x1ffc854*/ bool EnableItem(T item);
                /*0x1ffc854*/ bool DisableItem(T item);
                /*0x1ffc854*/ bool Remove(T item);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(T item);
                /*0x1f30ee8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2ffc8*/ int get_Capacity();
                /*0x1f2fe14*/ bool get_IsReadOnly();
                /*0x1ffc854*/ int IndexOf(T item);
                /*0x1ffc854*/ void Insert(int index, T item);
                /*0x1f30b78*/ void RemoveAt(int index);
                /*0x1f30bb4*/ void Swap(int index1, int index2);
                /*0x1ffc854*/ T get_Item(int index);
                /*0x1ffc854*/ void set_Item(int index, T value);
                /*0x1f30ebc*/ void RemoveAll(System.Predicate<T> match);
                /*0x1f30ebc*/ void Sort(System.Comparison<T> sortLayoutFunction);
            }
        }

        namespace CoroutineTween
        {
            interface ITweenValue
            {
                void TweenValue(float floatPercentage);
                /*0x1f2fe14*/ bool get_ignoreTimeScale();
                /*0x1f30804*/ float get_duration();
                /*0x1f2fe14*/ bool ValidTarget();
            }

            struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;
                /*0x18*/ UnityEngine.Color m_StartColor;
                /*0x28*/ UnityEngine.Color m_TargetColor;
                /*0x38*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;
                /*0x3c*/ float m_Duration;
                /*0x40*/ bool m_IgnoreTimeScale;

                /*0x40eab94*/ UnityEngine.Color get_startColor();
                /*0x40eaba0*/ void set_startColor(UnityEngine.Color value);
                /*0x40eabac*/ UnityEngine.Color get_targetColor();
                /*0x40eabb8*/ void set_targetColor(UnityEngine.Color value);
                /*0x40eabc4*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0x40eabcc*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0x40eabd4*/ float get_duration();
                /*0x40eabdc*/ void set_duration(float value);
                /*0x40eabe4*/ bool get_ignoreTimeScale();
                /*0x40eabec*/ void set_ignoreTimeScale(bool value);
                /*0x40eabf4*/ void TweenValue(float floatPercentage);
                /*0x40eacc0*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0x40ead9c*/ bool GetIgnoreTimescale();
                /*0x40eada4*/ float GetDuration();
                /*0x40eacb0*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x40ead54*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0x40eadac*/ float get_startValue();
                /*0x40eadb4*/ void set_startValue(float value);
                /*0x40eadbc*/ float get_targetValue();
                /*0x40eadc4*/ void set_targetValue(float value);
                /*0x40eadcc*/ float get_duration();
                /*0x40eadd4*/ void set_duration(float value);
                /*0x40eaddc*/ bool get_ignoreTimeScale();
                /*0x40eade4*/ void set_ignoreTimeScale(bool value);
                /*0x40eadec*/ void TweenValue(float floatPercentage);
                /*0x40eae90*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0x40eaf6c*/ bool GetIgnoreTimescale();
                /*0x40eaf74*/ float GetDuration();
                /*0x40eae80*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x40eaf24*/ FloatTweenCallback();
                }
            }

            class TweenRunner<T>
            {
                /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
                /*0x0*/ System.Collections.IEnumerator m_Tween;

                static /*0x1ffc854*/ System.Collections.IEnumerator Start(T tweenInfo);
                /*0x1f309e4*/ TweenRunner();
                /*0x1f30ebc*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
                /*0x1ffc854*/ void StartTween(T info);
                /*0x1f309e4*/ void StopTween();

                class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ T tweenInfo;
                    /*0x0*/ float <elapsedTime>5__2;

                    /*0x1f30b78*/ <Start>d__2(int <>1__state);
                    /*0x1f309e4*/ void System.IDisposable.Dispose();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f30214*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x40ed580*/ PanelEventHandler();
            /*0x40eaf7c*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x40eaf84*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x40eb3a0*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x40eb3b8*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x40eb48c*/ bool get_isCurrentFocusedPanel();
            /*0x40eb554*/ UnityEngine.UIElements.Focusable get_currentFocusedElement();
            /*0x40eb58c*/ void OnEnable();
            /*0x40eb594*/ void OnDisable();
            /*0x40eb1ec*/ void RegisterCallbacks();
            /*0x40eb038*/ void UnregisterCallbacks();
            /*0x40eb59c*/ void OnPanelDestroyed();
            /*0x40eb5a4*/ void OnElementFocus(UnityEngine.UIElements.FocusEvent e);
            /*0x40eb68c*/ void OnElementBlur(UnityEngine.UIElements.BlurEvent e);
            /*0x40eb690*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40eb708*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40eb71c*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40eba1c*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40ebbe8*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40ebe2c*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40ec0f8*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40ec14c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40ec168*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40ec470*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40ec630*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x40ec81c*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40eb9b8*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData);
            /*0x40ec9e8*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent);
            /*0x40eca04*/ void Update();
            /*0x40eca60*/ void LateUpdate();
            /*0x40ec328*/ void ProcessImguiEvents(UnityEngine.UIElements.Focusable target);
            /*0x40eca68*/ void ProcessKeyboardEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x40ecae8*/ void ProcessTabEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x40ecef0*/ void SendTabEvent(UnityEngine.Event e, UnityEngine.UIElements.NavigationMoveEvent.Direction direction, UnityEngine.UIElements.Focusable target);
            /*0x40ecb50*/ void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x40ecd20*/ void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x40eb878*/ bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);

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

                static /*0x40ed858*/ bool <Read>g__InRange|90_0(int i, int start, int count);
                /*0x40ed62c*/ PointerEvent();
                /*0x40ed63c*/ int get_pointerId();
                /*0x40ed644*/ void set_pointerId(int value);
                /*0x40ed64c*/ string get_pointerType();
                /*0x40ed654*/ void set_pointerType(string value);
                /*0x40ed65c*/ bool get_isPrimary();
                /*0x40ed664*/ void set_isPrimary(bool value);
                /*0x40ed66c*/ int get_button();
                /*0x40ed674*/ void set_button(int value);
                /*0x40ed67c*/ int get_pressedButtons();
                /*0x40ed684*/ void set_pressedButtons(int value);
                /*0x40ed68c*/ UnityEngine.Vector3 get_position();
                /*0x40ed698*/ void set_position(UnityEngine.Vector3 value);
                /*0x40ed6a4*/ UnityEngine.Vector3 get_localPosition();
                /*0x40ed6b0*/ void set_localPosition(UnityEngine.Vector3 value);
                /*0x40ed6bc*/ UnityEngine.Vector3 get_deltaPosition();
                /*0x40ed6c8*/ void set_deltaPosition(UnityEngine.Vector3 value);
                /*0x40ed6d4*/ float get_deltaTime();
                /*0x40ed6dc*/ void set_deltaTime(float value);
                /*0x40ed6e4*/ int get_clickCount();
                /*0x40ed6ec*/ void set_clickCount(int value);
                /*0x40ed6f4*/ float get_pressure();
                /*0x40ed6fc*/ void set_pressure(float value);
                /*0x40ed704*/ float get_tangentialPressure();
                /*0x40ed70c*/ void set_tangentialPressure(float value);
                /*0x40ed714*/ float get_altitudeAngle();
                /*0x40ed71c*/ void set_altitudeAngle(float value);
                /*0x40ed724*/ float get_azimuthAngle();
                /*0x40ed72c*/ void set_azimuthAngle(float value);
                /*0x40ed734*/ float get_twist();
                /*0x40ed73c*/ void set_twist(float value);
                /*0x40ed744*/ UnityEngine.Vector2 get_tilt();
                /*0x40ed74c*/ void set_tilt(UnityEngine.Vector2 value);
                /*0x40ed754*/ UnityEngine.PenStatus get_penStatus();
                /*0x40ed75c*/ void set_penStatus(UnityEngine.PenStatus value);
                /*0x40ed764*/ UnityEngine.Vector2 get_radius();
                /*0x40ed76c*/ void set_radius(UnityEngine.Vector2 value);
                /*0x40ed774*/ UnityEngine.Vector2 get_radiusVariance();
                /*0x40ed77c*/ void set_radiusVariance(UnityEngine.Vector2 value);
                /*0x40ed784*/ UnityEngine.EventModifiers get_modifiers();
                /*0x40ed78c*/ void set_modifiers(UnityEngine.EventModifiers value);
                /*0x40ed794*/ bool get_shiftKey();
                /*0x40ed7a0*/ bool get_ctrlKey();
                /*0x40ed7ac*/ bool get_commandKey();
                /*0x40ed7b8*/ bool get_altKey();
                /*0x40ed7c4*/ bool get_actionKey();
                /*0x40ed09c*/ void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);
                /*0x40ed568*/ void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride);
            }
        }

        class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
        {
            /*0x28*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;

            /*0x40edfa0*/ PanelRaycaster();
            /*0x40ed86c*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x40ed874*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x40ed9b8*/ void RegisterCallbacks();
            /*0x40ed928*/ void UnregisterCallbacks();
            /*0x40eda48*/ void OnPanelDestroyed();
            /*0x40eda50*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x40eda68*/ int get_sortOrderPriority();
            /*0x40edae4*/ int get_renderOrderPriority();
            /*0x40edb58*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x40edf98*/ UnityEngine.Camera get_eventCamera();
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x40edfd0*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x40edfb0*/ UnityEngine.Vector2 get_moveVector();
            /*0x40edfb8*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x40edfc0*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0x40edfc8*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x40ee090*/ AbstractEventData();
            /*0x40ee074*/ void Reset();
            /*0x40ee07c*/ void Use();
            /*0x40ee088*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0x40ee044*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x40ee098*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x40ee0b0*/ UnityEngine.GameObject get_selectedObject();
            /*0x40ee0c8*/ void set_selectedObject(UnityEngine.GameObject value);
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

            /*0x40ee5b8*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x40ee318*/ UnityEngine.GameObject get_pointerEnter();
            /*0x40ee320*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x40ee328*/ UnityEngine.GameObject get_lastPress();
            /*0x40ee330*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x40ee338*/ UnityEngine.GameObject get_rawPointerPress();
            /*0x40ee340*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0x40ee348*/ UnityEngine.GameObject get_pointerDrag();
            /*0x40ee350*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x40ee358*/ UnityEngine.GameObject get_pointerClick();
            /*0x40ee360*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x40ee368*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x40ee378*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x40ee39c*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x40ee3ac*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x40ee3d0*/ bool get_eligibleForClick();
            /*0x40ee3d8*/ void set_eligibleForClick(bool value);
            /*0x40ee3e0*/ int get_displayIndex();
            /*0x40ee3e8*/ void set_displayIndex(int value);
            /*0x40ee3f0*/ int get_pointerId();
            /*0x40ee3f8*/ void set_pointerId(int value);
            /*0x40ee400*/ UnityEngine.Vector2 get_position();
            /*0x40ee40c*/ void set_position(UnityEngine.Vector2 value);
            /*0x40ee418*/ UnityEngine.Vector2 get_delta();
            /*0x40ee424*/ void set_delta(UnityEngine.Vector2 value);
            /*0x40ee430*/ UnityEngine.Vector2 get_pressPosition();
            /*0x40ee43c*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x40ee448*/ UnityEngine.Vector3 get_worldPosition();
            /*0x40ee458*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x40ee468*/ UnityEngine.Vector3 get_worldNormal();
            /*0x40ee478*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x40ee488*/ float get_clickTime();
            /*0x40ee490*/ void set_clickTime(float value);
            /*0x40ee498*/ int get_clickCount();
            /*0x40ee4a0*/ void set_clickCount(int value);
            /*0x40ee4a8*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x40ee4b4*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x40ee4c0*/ bool get_useDragThreshold();
            /*0x40ee4c8*/ void set_useDragThreshold(bool value);
            /*0x40ee4d0*/ bool get_dragging();
            /*0x40ee4d8*/ void set_dragging(bool value);
            /*0x40ee4e0*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x40ee4e8*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x40ee4f0*/ float get_pressure();
            /*0x40ee4f8*/ void set_pressure(float value);
            /*0x40ee500*/ float get_tangentialPressure();
            /*0x40ee508*/ void set_tangentialPressure(float value);
            /*0x40ee510*/ float get_altitudeAngle();
            /*0x40ee518*/ void set_altitudeAngle(float value);
            /*0x40ee520*/ float get_azimuthAngle();
            /*0x40ee528*/ void set_azimuthAngle(float value);
            /*0x40ee530*/ float get_twist();
            /*0x40ee538*/ void set_twist(float value);
            /*0x40ee540*/ UnityEngine.Vector2 get_tilt();
            /*0x40ee54c*/ void set_tilt(UnityEngine.Vector2 value);
            /*0x40ee558*/ UnityEngine.PenStatus get_penStatus();
            /*0x40ee560*/ void set_penStatus(UnityEngine.PenStatus value);
            /*0x40ee568*/ UnityEngine.Vector2 get_radius();
            /*0x40ee574*/ void set_radius(UnityEngine.Vector2 value);
            /*0x40ee580*/ UnityEngine.Vector2 get_radiusVariance();
            /*0x40ee58c*/ void set_radiusVariance(UnityEngine.Vector2 value);
            /*0x40ee598*/ bool get_fullyExited();
            /*0x40ee5a0*/ void set_fullyExited(bool value);
            /*0x40ee5a8*/ bool get_reentered();
            /*0x40ee5b0*/ void set_reentered(bool value);
            /*0x40ee700*/ bool IsPointerMoving();
            /*0x40ee720*/ bool IsScrolling();
            /*0x40ee740*/ UnityEngine.Camera get_enterEventCamera();
            /*0x40ee7d0*/ UnityEngine.Camera get_pressEventCamera();
            /*0x40ee860*/ UnityEngine.GameObject get_pointerPress();
            /*0x40ee868*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x40ee90c*/ string ToString();

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
            /*0x1f30ebc*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x1f30ebc*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
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

            static /*0x40f1404*/ EventSystem();
            static /*0x40ef5e0*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x40ef6a8*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x40efb00*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            static /*0x40f0458*/ void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart);
            /*0x40ef88c*/ EventSystem();
            /*0x40ef83c*/ bool get_sendNavigationEvents();
            /*0x40ef844*/ void set_sendNavigationEvents(bool value);
            /*0x40ef84c*/ int get_pixelDragThreshold();
            /*0x40ef854*/ void set_pixelDragThreshold(int value);
            /*0x40ef85c*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x40ef864*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x40ef86c*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0x40ef874*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x40ef87c*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0x40ef884*/ bool get_isFocused();
            /*0x40ef928*/ void UpdateModules();
            /*0x40efa74*/ bool get_alreadySelecting();
            /*0x40ee0e0*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x40efa7c*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x40eb660*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x40effb0*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x40f01d4*/ bool IsPointerOverGameObject();
            /*0x40f01dc*/ bool IsPointerOverGameObject(int pointerId);
            /*0x40f0280*/ bool get_isUIToolkitActiveEventSystem();
            /*0x40f0370*/ bool get_sendUIToolkitEvents();
            /*0x40f03e4*/ bool get_createUIToolkitPanelGameObjectsOnStart();
            /*0x40f0604*/ void StartTrackingUIToolkitPanels();
            /*0x40f0b5c*/ void StopTrackingUIToolkitPanels();
            /*0x40f08a8*/ void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x40f0c10*/ void Start();
            /*0x40f0c20*/ void OnEnable();
            /*0x40f0d00*/ void OnDisable();
            /*0x40f0e20*/ void TickModules();
            /*0x40f0f28*/ void OnApplicationFocus(bool hasFocus);
            /*0x40f0f38*/ void Update();
            /*0x40f119c*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x40f12ac*/ string ToString();

            struct UIToolkitOverrideConfig
            {
                /*0x10*/ UnityEngine.EventSystems.EventSystem activeEventSystem;
                /*0x18*/ bool sendEvents;
                /*0x19*/ bool createPanelGameObjectsOnStart;
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.GameObject go;

                /*0x40f0c08*/ <>c__DisplayClass56_0();
                /*0x40f1544*/ void <CreateUIToolkitPanelGameObject>b__0();
            }
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x40f1630*/ EventTrigger();
            /*0x40f15a0*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x40f1628*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x40f15a4*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x40f1638*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x40f1640*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40f172c*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f1738*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f1744*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f1750*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f175c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f1768*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f1774*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f1780*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40f178c*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40f1798*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f17a4*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x40f17b0*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40f17bc*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f17c8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f17d4*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x40f17e0*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x40f17ec*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x40f17f8*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x40f1840*/ Entry();
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

            static /*0x40f300c*/ ExecuteEvents();
            static /*0x1ffc854*/ T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x40f18b0*/ void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f19a4*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f1a98*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f1b8c*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f1c80*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f1d74*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f1e68*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f1f5c*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2050*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2144*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2238*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f232c*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2420*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f24c4*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2568*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f260c*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2700*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f27a4*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x40f2848*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler();
            static /*0x40f28a0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x40f28f8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x40f2950*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x40f29a8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x40f2a00*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x40f2a58*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x40f2ab0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x40f2b08*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x40f2b60*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x40f2bb8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x40f2c10*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x40f2c68*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x40f2cc0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x40f2d18*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x40f2d70*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x40f2dc8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x40f2e20*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x40f2e78*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
            static /*0x1f319c4*/ bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor);
            static /*0x1f3299c*/ UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction);
            static /*0x1f31840*/ bool ShouldSendToComponent<T>(UnityEngine.Component component);
            static /*0x1f36f18*/ void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results);
            static /*0x1f31840*/ bool CanHandleEvent<T>(UnityEngine.GameObject go);
            static /*0x1f327cc*/ UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root);

            class EventFunction<T1> : System.MulticastDelegate
            {
                EventFunction(object object, nint method);
                /*0x1ffc854*/ void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData);
                /*0x1ffc854*/ System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object);
                /*0x1f30ebc*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x40f37c0*/ BaseInput();
            /*0x40f36f0*/ string get_compositionString();
            /*0x40f36f8*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x40f3700*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x40f370c*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x40f3714*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x40f371c*/ bool get_mousePresent();
            /*0x40f3724*/ bool GetMouseButtonDown(int button);
            /*0x40f3730*/ bool GetMouseButtonUp(int button);
            /*0x40f373c*/ bool GetMouseButton(int button);
            /*0x40f3748*/ UnityEngine.Vector2 get_mousePosition();
            /*0x40f3750*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x40f3758*/ float get_mouseScrollDeltaPerTick();
            /*0x40f3760*/ bool get_touchSupported();
            /*0x40f3768*/ int get_touchCount();
            /*0x40f3770*/ UnityEngine.Touch GetTouch(int index);
            /*0x40f37a8*/ float GetAxisRaw(string axisName);
            /*0x40f37b4*/ bool GetButtonDown(string buttonName);
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

            static /*0x40f3aa0*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x40f3bb4*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x40f3c08*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x40f3c58*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x40f4b60*/ BaseInputModule();
            /*0x40f37c8*/ bool get_sendPointerHoverToParent();
            /*0x40f37d0*/ void set_sendPointerHoverToParent(bool value);
            /*0x40f37d8*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x40f39fc*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x40f3a04*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x40f3a0c*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x40f3a14*/ void OnEnable();
            /*0x40f3a8c*/ void OnDisable();
            /*0x1f309e4*/ void Process();
            /*0x40f3dcc*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x40f4878*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x40f498c*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x40f4a34*/ bool IsPointerOverGameObject(int pointerId);
            /*0x40f4a3c*/ bool ShouldActivateModule();
            /*0x40f4a7c*/ void DeactivateModule();
            /*0x40f4a80*/ void ActivateModule();
            /*0x40f4a84*/ void UpdateModule();
            /*0x40f4a88*/ bool IsModuleSupported();
            /*0x40f4a90*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
            /*0x40f4b1c*/ UnityEngine.Vector2 ConvertPointerEventScrollDeltaToTicks(UnityEngine.Vector2 scrollDelta);
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x58*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x60*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x40f55ec*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x40f6148*/ PointerInputModule();
            /*0x40f4bf0*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x40f4cf0*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x40f4d60*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x40f50f4*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x40f51b0*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x40f522c*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x40f5240*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x40f55d0*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x40f561c*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x40f5660*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x40f592c*/ bool IsPointerOverGameObject(int pointerId);
            /*0x40f59c8*/ void ClearSelection();
            /*0x40f5bec*/ string ToString();
            /*0x40f605c*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x40f62a8*/ ButtonState();
                /*0x40f6288*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x40f6290*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x40f6298*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0x40f62a0*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x40f6200*/ MouseState();
                /*0x40f62b0*/ bool AnyPressesThisFrame();
                /*0x40f6390*/ bool AnyReleasesThisFrame();
                /*0x40f6478*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x40f5594*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x40f65e4*/ MouseButtonEventData();
                /*0x40f6380*/ bool PressedThisFrame();
                /*0x40f6464*/ bool ReleasedThisFrame();
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

            /*0x40f65ec*/ StandaloneInputModule();
            /*0x40f66c8*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x40f66d0*/ bool get_allowActivationOnMobileDevice();
            /*0x40f66d8*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x40f66e0*/ bool get_forceModuleActive();
            /*0x40f66e8*/ void set_forceModuleActive(bool value);
            /*0x40f66f0*/ float get_inputActionsPerSecond();
            /*0x40f66f8*/ void set_inputActionsPerSecond(float value);
            /*0x40f6700*/ float get_repeatDelay();
            /*0x40f6708*/ void set_repeatDelay(float value);
            /*0x40f6710*/ string get_horizontalAxis();
            /*0x40f6718*/ void set_horizontalAxis(string value);
            /*0x40f6720*/ string get_verticalAxis();
            /*0x40f6728*/ void set_verticalAxis(string value);
            /*0x40f6730*/ string get_submitButton();
            /*0x40f6738*/ void set_submitButton(string value);
            /*0x40f6740*/ string get_cancelButton();
            /*0x40f6748*/ void set_cancelButton(string value);
            /*0x40f6750*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x40f6758*/ void UpdateModule();
            /*0x40f683c*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x40f6be0*/ bool ShouldActivateModule();
            /*0x40f6e0c*/ void ActivateModule();
            /*0x40f6f0c*/ void DeactivateModule();
            /*0x40f6f10*/ void Process();
            /*0x40f70fc*/ bool ProcessTouchEvents();
            /*0x40f76e0*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x40f74cc*/ bool SendSubmitEventToSelectedObject();
            /*0x40f7e0c*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x40f7268*/ bool SendMoveEventToSelectedObject();
            /*0x40f7260*/ void ProcessMouseEvent();
            /*0x40f81c8*/ bool ForceAutoSelect();
            /*0x40f7f18*/ void ProcessMouseEvent(int id);
            /*0x40f6fb4*/ bool SendUpdateEventToSelectedObject();
            /*0x40f81d0*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x40f8590*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

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

            /*0x40f8598*/ TouchInputModule();
            /*0x40f859c*/ bool get_allowActivationOnStandalone();
            /*0x40f85a4*/ void set_allowActivationOnStandalone(bool value);
            /*0x40f85ac*/ bool get_forceModuleActive();
            /*0x40f85b4*/ void set_forceModuleActive(bool value);
            /*0x40f85bc*/ void UpdateModule();
            /*0x40f8724*/ bool IsModuleSupported();
            /*0x40f875c*/ bool ShouldActivateModule();
            /*0x40f8808*/ bool UseFakeInput();
            /*0x40f8838*/ void Process();
            /*0x40f8860*/ void FakeTouches();
            /*0x40f898c*/ void ProcessTouchEvents();
            /*0x40f8ad0*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x40f91f4*/ void DeactivateModule();
            /*0x40f91f8*/ string ToString();
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

            static /*0x40f96a4*/ RaycasterManager();
            static /*0x40f94ac*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x40f957c*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x40f95d4*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x40edfa8*/ BaseRaycaster();
            /*0x1f30ff0*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x1f30214*/ UnityEngine.Camera get_eventCamera();
            /*0x40f973c*/ int get_priority();
            /*0x40f9744*/ int get_sortOrderPriority();
            /*0x40f974c*/ int get_renderOrderPriority();
            /*0x40efeec*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x40f9754*/ string ToString();
            /*0x40f99a0*/ void OnEnable();
            /*0x40f99f4*/ void OnDisable();
            /*0x40f9a48*/ void OnCanvasHierarchyChanged();
            /*0x40f9a58*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x48*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x40f9a68*/ Physics2DRaycaster();
            /*0x40f9ac0*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x28*/ UnityEngine.Camera m_EventCamera;
            /*0x30*/ UnityEngine.LayerMask m_EventMask;
            /*0x34*/ int m_MaxRayIntersections;
            /*0x38*/ int m_LastMaxRayIntersections;
            /*0x40*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x40f9a94*/ PhysicsRaycaster();
            /*0x40fa50c*/ UnityEngine.Camera get_eventCamera();
            /*0x40fa5ec*/ int get_depth();
            /*0x40fa448*/ int get_finalEventMask();
            /*0x40fa6b0*/ UnityEngine.LayerMask get_eventMask();
            /*0x40fa6b8*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x40fa6c0*/ int get_maxRayIntersections();
            /*0x40fa6c8*/ void set_maxRayIntersections(int value);
            /*0x40fa154*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x40fa6d0*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x40faacc*/ RaycastHitComparer();
                /*0x40faac4*/ RaycastHitComparer();
                /*0x40faa80*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
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

            /*0x40fab34*/ UnityEngine.GameObject get_gameObject();
            /*0x40fab3c*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x40fab44*/ bool get_isValid();
            /*0x40fabdc*/ void Clear();
            /*0x40ef03c*/ string ToString();
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x40ed634*/ UIBehaviour();
            /*0x40faca0*/ void Awake();
            /*0x40eb590*/ void OnEnable();
            /*0x40f0c1c*/ void Start();
            /*0x40eb598*/ void OnDisable();
            /*0x40faca4*/ void OnDestroy();
            /*0x40faca8*/ bool IsActive();
            /*0x40facb0*/ void OnRectTransformDimensionsChange();
            /*0x40facb4*/ void OnBeforeTransformParentChanged();
            /*0x40f9a64*/ void OnTransformParentChanged();
            /*0x40facb8*/ void OnDidApplyAnimationProperties();
            /*0x40facbc*/ void OnCanvasGroupChanged();
            /*0x40f9a54*/ void OnCanvasHierarchyChanged();
            /*0x40facc0*/ bool IsDestroyed();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;
    static /*0xc*/ <PrivateImplementationDetails> 77C1B0B9A716E0F240D6721DDD28F7A068986974CB7978C5086BCE9812E2EBF3;
    static /*0x17e1*/ <PrivateImplementationDetails> 7C777EEED2359F9E03B1E9BA3FE7218E75A8BA42A33894ABBE8BB2022DDED720;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=5527
    {
    }

    struct __StaticArrayInitTypeSize=6101
    {
    }
}
