class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7fb6384*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7fb6478*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            /*0x7fb64d0*/ AnimationTriggers();
            /*0x7fb6480*/ string get_normalTrigger();
            /*0x7fb6488*/ void set_normalTrigger(string value);
            /*0x7fb6490*/ string get_highlightedTrigger();
            /*0x7fb6498*/ void set_highlightedTrigger(string value);
            /*0x7fb64a0*/ string get_pressedTrigger();
            /*0x7fb64a8*/ void set_pressedTrigger(string value);
            /*0x7fb64b0*/ string get_selectedTrigger();
            /*0x7fb64b8*/ void set_selectedTrigger(string value);
            /*0x7fb64c0*/ string get_disabledTrigger();
            /*0x7fb64c8*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0x100*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x7fb65c8*/ Button();
            /*0x7fb6668*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x7fb6670*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x7fb6680*/ void Press();
            /*0x7fb6718*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x7fb673c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x7fb67b4*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x7fb6660*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x7fb6820*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x7fb6848*/ void System.IDisposable.Dispose();
                /*0x7fb684c*/ bool MoveNext();
                /*0x7fb694c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7fb6954*/ void System.Collections.IEnumerator.Reset();
                /*0x7fb698c*/ object System.Collections.IEnumerator.get_Current();
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
            /*0x380cffc*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x380b9e8*/ UnityEngine.Transform get_transform();
            /*0x380cb08*/ void LayoutComplete();
            /*0x380cb08*/ void GraphicUpdateComplete();
            /*0x380b128*/ bool IsDestroyed();
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

            static /*0x7fb8424*/ CanvasUpdateRegistry();
            static /*0x7fb6bd4*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x7fb7808*/ int ParentCount(UnityEngine.Transform child);
            static /*0x7fb78c4*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x7fb7a14*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fb7b0c*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fb7b6c*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fb7c9c*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fb7cfc*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fb8034*/ void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fb836c*/ bool IsRebuildingLayout();
            static /*0x7fb83c8*/ bool IsRebuildingGraphics();
            /*0x7fb6994*/ CanvasUpdateRegistry();
            /*0x7fb6c84*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x7fb6d54*/ void CleanInvalidItems();
            /*0x7fb7038*/ void PerformUpdate();
            /*0x7fb7a74*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fb7bcc*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fb7d6c*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fb7ed0*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fb80a4*/ void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fb8208*/ void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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

            static /*0x7fb8554*/ ColorBlock();
            static /*0x7fb8884*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x7fb8918*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0x7fb84bc*/ UnityEngine.Color get_normalColor();
            /*0x7fb84c8*/ void set_normalColor(UnityEngine.Color value);
            /*0x7fb84d4*/ UnityEngine.Color get_highlightedColor();
            /*0x7fb84e0*/ void set_highlightedColor(UnityEngine.Color value);
            /*0x7fb84ec*/ UnityEngine.Color get_pressedColor();
            /*0x7fb84f8*/ void set_pressedColor(UnityEngine.Color value);
            /*0x7fb8504*/ UnityEngine.Color get_selectedColor();
            /*0x7fb8510*/ void set_selectedColor(UnityEngine.Color value);
            /*0x7fb851c*/ UnityEngine.Color get_disabledColor();
            /*0x7fb8528*/ void set_disabledColor(UnityEngine.Color value);
            /*0x7fb8534*/ float get_colorMultiplier();
            /*0x7fb853c*/ void set_colorMultiplier(float value);
            /*0x7fb8544*/ float get_fadeDuration();
            /*0x7fb854c*/ void set_fadeDuration(float value);
            /*0x7fb85cc*/ bool Equals(object obj);
            /*0x7fb868c*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0x7fb89b0*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x7fb7678*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x7fb8aa4*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x7fb8b14*/ void Unregister(UnityEngine.UI.IClipper c);
            static /*0x7fb8b70*/ void Disable(UnityEngine.UI.IClipper c);
            /*0x7fb8a1c*/ ClipperRegistry();
            /*0x7fb76fc*/ void Cull();
        }

        class Clipping
        {
            static /*0x7fb8bcc*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
        }

        interface IClipper
        {
            /*0x380cb08*/ void PerformClipping();
        }

        interface IClippable
        {
            /*0x380b9e8*/ UnityEngine.GameObject get_gameObject();
            /*0x380cb08*/ void RecalculateClipping();
            /*0x380b9e8*/ UnityEngine.RectTransform get_rectTransform();
            void Cull(UnityEngine.Rect clipRect, bool validRect);
            void SetClipRect(UnityEngine.Rect value, bool validRect);
            /*0x380e304*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
        }

        class RectangularVertexClipper
        {
            /*0x10*/ UnityEngine.Vector3[] m_WorldCorners;
            /*0x18*/ UnityEngine.Vector3[] m_CanvasCorners;

            /*0x7fb8efc*/ RectangularVertexClipper();
            /*0x7fb8da4*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
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

            static /*0x7fbd9bc*/ DefaultControls();
            static /*0x7fb8f7c*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x7fb8fd4*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x7fb9134*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x7fb935c*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x7fb9438*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x7fb925c*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x7fb9498*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x7fb957c*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fb9b80*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fb9f8c*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fba124*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fba258*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fba38c*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fbaa84*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fbaf2c*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fbb4d0*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fbbb18*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fbd0a0*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                /*0x380bcbc*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x7fbdb14*/ DefaultRuntimeFactory();
                /*0x7fbdb0c*/ DefaultRuntimeFactory();
                /*0x7fbdaa0*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
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

            static /*0x7fc0968*/ Dropdown();
            static /*0x3907c14*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x7fbdd80*/ Dropdown();
            /*0x7fbdb7c*/ UnityEngine.RectTransform get_template();
            /*0x7fbce40*/ void set_template(UnityEngine.RectTransform value);
            /*0x7fbdb84*/ UnityEngine.UI.Text get_captionText();
            /*0x7fbce60*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x7fbdb8c*/ UnityEngine.UI.Image get_captionImage();
            /*0x7fbdb94*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x7fbdbb4*/ UnityEngine.UI.Text get_itemText();
            /*0x7fbce80*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x7fbdbbc*/ UnityEngine.UI.Image get_itemImage();
            /*0x7fbdbc4*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x7fbcea0*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x7fbdbe4*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x7fbdc0c*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x7fbdc14*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x7fbdc24*/ float get_alphaFadeSpeed();
            /*0x7fbdc2c*/ void set_alphaFadeSpeed(float value);
            /*0x7fbdc34*/ int get_value();
            /*0x7fbdc3c*/ void set_value(int value);
            /*0x7fbdd78*/ void SetValueWithoutNotify(int input);
            /*0x7fbdc44*/ void Set(int value, bool sendCallback);
            /*0x7fbdf78*/ void Awake();
            /*0x7fbe074*/ void Start();
            /*0x7fbe128*/ void OnDisable();
            /*0x7fbcec4*/ void RefreshShownValue();
            /*0x7fbe34c*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x7fbe3b4*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x7fbe54c*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x7fbe6e4*/ void ClearOptions();
            /*0x7fbe75c*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x7fbee20*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x7fbfa60*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x7fbfa64*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x7fbee24*/ void Show();
            /*0x7fbff8c*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x7fc04d0*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x7fc0528*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x7fc0594*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x7fc05ec*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x7fc0658*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x7fbfb7c*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x7fc065c*/ void AlphaFadeList(float duration, float alpha);
            /*0x7fbfe6c*/ void AlphaFadeList(float duration, float start, float end);
            /*0x7fc06dc*/ void SetAlpha(float alpha);
            /*0x7fbfa68*/ void Hide();
            /*0x7fc0790*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x7fbe1cc*/ void ImmediateDestroyDropdownList();
            /*0x7fc0834*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x20*/ UnityEngine.UI.Text m_Text;
                /*0x28*/ UnityEngine.UI.Image m_Image;
                /*0x30*/ UnityEngine.RectTransform m_RectTransform;
                /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x7fc0b4c*/ DropdownItem();
                /*0x7fc09e4*/ UnityEngine.UI.Text get_text();
                /*0x7fc09ec*/ void set_text(UnityEngine.UI.Text value);
                /*0x7fc09f4*/ UnityEngine.UI.Image get_image();
                /*0x7fc09fc*/ void set_image(UnityEngine.UI.Image value);
                /*0x7fc0a04*/ UnityEngine.RectTransform get_rectTransform();
                /*0x7fc0a0c*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x7fc0a14*/ UnityEngine.UI.Toggle get_toggle();
                /*0x7fc0a1c*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x7fc0a24*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7fc0aa0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x7fbcebc*/ OptionData();
                /*0x7fbe51c*/ OptionData(string text);
                /*0x7fbe6b4*/ OptionData(UnityEngine.Sprite image);
                /*0x7fc0b74*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x7fc0b54*/ string get_text();
                /*0x7fc0b5c*/ void set_text(string value);
                /*0x7fc0b64*/ UnityEngine.Sprite get_image();
                /*0x7fc0b6c*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x7fbdea8*/ OptionDataList();
                /*0x7fc0bb8*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x7fc0bc0*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x7fbdf30*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x7fbfb74*/ <>c__DisplayClass63_0();
                /*0x7fc0bc8*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x7fc080c*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x7fc0bec*/ void System.IDisposable.Dispose();
                /*0x7fc0bf0*/ bool MoveNext();
                /*0x7fc0ca4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7fc0cac*/ void System.Collections.IEnumerator.Reset();
                /*0x7fc0ce4*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x7fc0cec*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x7fc0d7c*/ FontData();
            /*0x7fc0d84*/ UnityEngine.Font get_font();
            /*0x7fc0d8c*/ void set_font(UnityEngine.Font value);
            /*0x7fc0d94*/ int get_fontSize();
            /*0x7fc0d9c*/ void set_fontSize(int value);
            /*0x7fc0da4*/ UnityEngine.FontStyle get_fontStyle();
            /*0x7fc0dac*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x7fc0db4*/ bool get_bestFit();
            /*0x7fc0dbc*/ void set_bestFit(bool value);
            /*0x7fc0dc8*/ int get_minSize();
            /*0x7fc0dd0*/ void set_minSize(int value);
            /*0x7fc0dd8*/ int get_maxSize();
            /*0x7fc0de0*/ void set_maxSize(int value);
            /*0x7fc0de8*/ UnityEngine.TextAnchor get_alignment();
            /*0x7fc0df0*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x7fc0df8*/ bool get_alignByGeometry();
            /*0x7fc0e00*/ void set_alignByGeometry(bool value);
            /*0x7fc0e0c*/ bool get_richText();
            /*0x7fc0e14*/ void set_richText(bool value);
            /*0x7fc0e20*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x7fc0e28*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x7fc0e30*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x7fc0e38*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x7fc0e40*/ float get_lineSpacing();
            /*0x7fc0e48*/ void set_lineSpacing(float value);
            /*0x7fc0e50*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7fc0e54*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x7fc148c*/ FontUpdateTracker();
            static /*0x7fc0e98*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x7fc10e0*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x7fc1284*/ void UntrackText(UnityEngine.UI.Text t);
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

            static /*0x7fc4ba0*/ Graphic();
            static /*0x7fc1524*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x7fc3ab0*/ UnityEngine.Mesh get_workerMesh();
            static /*0x7fc4790*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x7fc1b40*/ Graphic();
            /*0x7fc1610*/ UnityEngine.Color get_color();
            /*0x7fc161c*/ void set_color(UnityEngine.Color value);
            /*0x7fc1654*/ bool get_raycastTarget();
            /*0x7fc165c*/ void set_raycastTarget(bool value);
            /*0x7fc1b14*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x7fc1b20*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x7fc1b2c*/ bool get_useLegacyMeshGeneration();
            /*0x7fc1b34*/ void set_useLegacyMeshGeneration(bool value);
            /*0x7fc1c0c*/ void SetAllDirty();
            /*0x7fc1d54*/ void SetLayoutDirty();
            /*0x7fc1e60*/ void SetVerticesDirty();
            /*0x7fc1ef4*/ void SetMaterialDirty();
            /*0x7fc1c7c*/ void SetRaycastDirty();
            /*0x7fc1f88*/ void OnRectTransformDimensionsChange();
            /*0x7fc2034*/ void OnBeforeTransformParentChanged();
            /*0x7fc2280*/ void OnTransformParentChanged();
            /*0x7fc26c4*/ int get_depth();
            /*0x7fc1df4*/ UnityEngine.RectTransform get_rectTransform();
            /*0x7fc1738*/ UnityEngine.Canvas get_canvas();
            /*0x7fc2340*/ void CacheCanvas();
            /*0x7fc26e0*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x7fc2794*/ UnityEngine.Material get_defaultMaterial();
            /*0x7fc27e0*/ UnityEngine.Material get_material();
            /*0x7fc2868*/ void set_material(UnityEngine.Material value);
            /*0x7fc2910*/ UnityEngine.Material get_materialForRendering();
            /*0x7fc2ad4*/ UnityEngine.Texture get_mainTexture();
            /*0x7fc2b2c*/ void OnEnable();
            /*0x7fc2c64*/ void OnDisable();
            /*0x7fc2f2c*/ void OnDestroy();
            /*0x7fc3040*/ void OnCanvasHierarchyChanged();
            /*0x7fc3184*/ void OnCullingChanged();
            /*0x7fc3210*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x7fc32f4*/ void LayoutComplete();
            /*0x7fc32f8*/ void GraphicUpdateComplete();
            /*0x7fc32fc*/ void UpdateMaterial();
            /*0x7fc33b4*/ void UpdateGeometry();
            /*0x7fc3720*/ void DoMeshGeneration();
            /*0x7fc33c4*/ void DoLegacyMeshGeneration();
            /*0x7fc3be0*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x7fc3be4*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x7fc3c7c*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x7fc3f04*/ void OnDidApplyAnimationProperties();
            /*0x7fc3f14*/ void SetNativeSize();
            /*0x7fc3f18*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x7fc43a4*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x7fc3dd8*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x7fc44e4*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x7fc4500*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x7fc47a4*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x7fc4840*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x7fc48d0*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x7fc4960*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x7fc49f0*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x7fc4a80*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x7fc4b10*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x7fc4c44*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
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

            static /*0x7fc61b0*/ GraphicRaycaster();
            static /*0x7fc5b68*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x7fc4dc4*/ GraphicRaycaster();
            /*0x7fc4c4c*/ int get_sortOrderPriority();
            /*0x7fc4d3c*/ int get_renderOrderPriority();
            /*0x7fc4d90*/ bool get_ignoreReversedGraphics();
            /*0x7fc4d98*/ void set_ignoreReversedGraphics(bool value);
            /*0x7fc4da4*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0x7fc4dac*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0x7fc4db4*/ UnityEngine.LayerMask get_blockingMask();
            /*0x7fc4dbc*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x7fc4c94*/ UnityEngine.Canvas get_canvas();
            /*0x7fc4e64*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x7fc60e8*/ UnityEngine.Camera get_eventCamera();

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

                static /*0x7fc6248*/ <>c();
                /*0x7fc62b0*/ <>c();
                /*0x7fc62b8*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x7fc67b0*/ GraphicRegistry();
            static /*0x7fc64c4*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x7fc24d8*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fc1928*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fc20dc*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fc17ac*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fc2dac*/ void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fc6574*/ void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fc66f4*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x7fc5aac*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x7fc6304*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            /*0x380cb08*/ void OnSiblingGraphicEnabledDisabled();
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

            static /*0x7fcb4bc*/ Image();
            static /*0x7fc703c*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x7fca504*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x7fca3b0*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x7fca5e8*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x7fca708*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x7fcb2dc*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x7fc9e84*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x7fca074*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x7fc6ffc*/ Image();
            /*0x7fc6840*/ UnityEngine.Sprite get_sprite();
            /*0x7fb9838*/ void set_sprite(UnityEngine.Sprite value);
            /*0x7fc69c4*/ void DisableSpriteOptimizations();
            /*0x7fc69cc*/ UnityEngine.Sprite get_overrideSprite();
            /*0x7fc6a48*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x7fc69d0*/ UnityEngine.Sprite get_activeSprite();
            /*0x7fc6ad0*/ UnityEngine.UI.Image.Type get_type();
            /*0x7fb9b00*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x7fc6ad8*/ bool get_preserveAspect();
            /*0x7fc6ae0*/ void set_preserveAspect(bool value);
            /*0x7fc6b60*/ bool get_fillCenter();
            /*0x7fc6b68*/ void set_fillCenter(bool value);
            /*0x7fc6be8*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x7fc6bf0*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x7fc6c68*/ float get_fillAmount();
            /*0x7fc6c70*/ void set_fillAmount(float value);
            /*0x7fc6d00*/ bool get_fillClockwise();
            /*0x7fc6d08*/ void set_fillClockwise(bool value);
            /*0x7fc6d88*/ int get_fillOrigin();
            /*0x7fc6d90*/ void set_fillOrigin(int value);
            /*0x7fc6e10*/ float get_eventAlphaThreshold();
            /*0x7fc6e20*/ void set_eventAlphaThreshold(float value);
            /*0x7fc6f6c*/ float get_alphaHitTestMinimumThreshold();
            /*0x7fc6e2c*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0x7fc6f74*/ bool get_useSpriteMesh();
            /*0x7fc6f7c*/ void set_useSpriteMesh(bool value);
            /*0x7fc7128*/ UnityEngine.Texture get_mainTexture();
            /*0x7fc72a0*/ bool get_hasBorder();
            /*0x7fc7358*/ float get_pixelsPerUnitMultiplier();
            /*0x7fc7360*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x7fc7380*/ float get_pixelsPerUnit();
            /*0x7fc7474*/ float get_multipliedPixelsPerUnit();
            /*0x7fc7490*/ UnityEngine.Material get_material();
            /*0x7fc75bc*/ void set_material(UnityEngine.Material value);
            /*0x7fc75c0*/ void OnBeforeSerialize();
            /*0x7fc75c4*/ void OnAfterDeserialize();
            /*0x7fc7614*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x7fc76a8*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x7fc7a58*/ void SetNativeSize();
            /*0x7fc7b98*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x7fc68d8*/ void TrackSprite();
            /*0x7fc9fe4*/ void OnEnable();
            /*0x7fca000*/ void OnDisable();
            /*0x7fca0f4*/ void UpdateMaterial();
            /*0x7fca1e8*/ void OnCanvasHierarchyChanged();
            /*0x7fc7cdc*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x7fc7fa0*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x7fc8284*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x7fc8844*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x7fca2f0*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x7fc959c*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x7fcab34*/ void CalculateLayoutInputHorizontal();
            /*0x7fcab38*/ void CalculateLayoutInputVertical();
            /*0x7fcab3c*/ float get_minWidth();
            /*0x7fcab44*/ float get_preferredWidth();
            /*0x7fcac0c*/ float get_flexibleWidth();
            /*0x7fcac14*/ float get_minHeight();
            /*0x7fcac1c*/ float get_preferredHeight();
            /*0x7fcace4*/ float get_flexibleHeight();
            /*0x7fcacec*/ int get_layoutPriority();
            /*0x7fcacf4*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x7fcb084*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x7fcb484*/ void OnDidApplyAnimationProperties();
            /*0x7fc6848*/ void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0();
            /*0x7fcb628*/ bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1();

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
            /*0x380b128*/ bool Enabled();
            /*0x380b9e8*/ UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            /*0x380cb08*/ void RecalculateMasking();
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

            static /*0x8197928*/ InputField();
            static /*0x81909ec*/ string get_clipboard();
            static /*0x8190a3c*/ void set_clipboard(string value);
            static /*0x8195bf0*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x8192ca8*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x818e244*/ InputField();
            /*0x818e0a0*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x818e1b0*/ string get_compositionString();
            /*0x818e57c*/ UnityEngine.Mesh get_mesh();
            /*0x818e624*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x818e698*/ void set_shouldHideMobileInput(bool value);
            /*0x818e6f0*/ bool get_shouldHideMobileInput();
            /*0x818e778*/ void set_shouldActivateOnSelect(bool value);
            /*0x818e784*/ bool get_shouldActivateOnSelect();
            /*0x818e7f4*/ string get_text();
            /*0x818e7fc*/ void set_text(string value);
            /*0x818eb30*/ void SetTextWithoutNotify(string input);
            /*0x818e804*/ void SetText(string value, bool sendCallback);
            /*0x818f088*/ bool get_isFocused();
            /*0x818f090*/ float get_caretBlinkRate();
            /*0x818f098*/ void set_caretBlinkRate(float value);
            /*0x818f184*/ int get_caretWidth();
            /*0x818f18c*/ void set_caretWidth(int value);
            /*0x818f258*/ UnityEngine.UI.Text get_textComponent();
            /*0x818f260*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x818f4e0*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x818f4e8*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x818f540*/ UnityEngine.Color get_caretColor();
            /*0x818f584*/ void set_caretColor(UnityEngine.Color value);
            /*0x818f5b0*/ bool get_customCaretColor();
            /*0x818f5b8*/ void set_customCaretColor(bool value);
            /*0x818f5d4*/ UnityEngine.Color get_selectionColor();
            /*0x818f5e8*/ void set_selectionColor(UnityEngine.Color value);
            /*0x818f614*/ UnityEngine.UI.InputField.EndEditEvent get_onEndEdit();
            /*0x818f61c*/ void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value);
            /*0x818f674*/ UnityEngine.UI.InputField.SubmitEvent get_onSubmit();
            /*0x818f67c*/ void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x818f6d4*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x818f6dc*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x818f738*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x818f6e0*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x818f740*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x818f748*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x818f7a0*/ int get_characterLimit();
            /*0x818f7a8*/ void set_characterLimit(int value);
            /*0x818f868*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x818f870*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x818f9a0*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x818f9a8*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x818facc*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x818fad4*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x818fb70*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x818fb78*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x818fb80*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x818fc04*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x818fc0c*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x818fc90*/ bool get_readOnly();
            /*0x818fc98*/ void set_readOnly(bool value);
            /*0x818fca4*/ bool get_multiLine();
            /*0x818fcb8*/ char get_asteriskChar();
            /*0x818fcc0*/ void set_asteriskChar(char value);
            /*0x818fd34*/ bool get_wasCanceled();
            /*0x818fd3c*/ void ClampPos(ref int pos);
            /*0x818fd74*/ int get_caretPositionInternal();
            /*0x818fd98*/ void set_caretPositionInternal(int value);
            /*0x818fdd0*/ int get_caretSelectPositionInternal();
            /*0x818fdf4*/ void set_caretSelectPositionInternal(int value);
            /*0x818fe2c*/ bool get_hasSelection();
            /*0x818fe5c*/ int get_caretPosition();
            /*0x818fe80*/ void set_caretPosition(int value);
            /*0x818ff60*/ int get_selectionAnchorPosition();
            /*0x818fea8*/ void set_selectionAnchorPosition(int value);
            /*0x818ff84*/ int get_selectionFocusPosition();
            /*0x818ff04*/ void set_selectionFocusPosition(int value);
            /*0x818ffa8*/ void Awake();
            /*0x8190068*/ void OnEnable();
            /*0x81902c8*/ void OnDisable();
            /*0x8190698*/ void OnDestroy();
            /*0x81906fc*/ System.Collections.IEnumerator CaretBlink();
            /*0x8190790*/ void SetCaretVisible();
            /*0x818f114*/ void SetCaretActive();
            /*0x81907c8*/ void UpdateCaretMaterial();
            /*0x81908d8*/ void OnFocus();
            /*0x81908dc*/ void SelectAll();
            /*0x8190910*/ void MoveTextEnd(bool shift);
            /*0x8190970*/ void MoveTextStart(bool shift);
            /*0x8190a94*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x8190b4c*/ bool InPlaceEditing();
            /*0x8190b7c*/ bool InPlaceEditingChanged();
            /*0x8190bfc*/ UnityEngine.RangeInt GetInternalSelection();
            /*0x8190cb0*/ void UpdateKeyboardCaret();
            /*0x8190d78*/ void UpdateCaretFromKeyboard();
            /*0x8190e60*/ void LateUpdate();
            /*0x819246c*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x8192804*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x8192a14*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x8192e0c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x8192ee4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x8192f04*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x8193108*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81931b8*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81931d4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81933c4*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x8193ea8*/ bool IsValidChar(char c);
            /*0x8193f18*/ void ProcessEvent(UnityEngine.Event e);
            /*0x8193f1c*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x8193974*/ string GetSelectedString();
            /*0x81940a4*/ int FindtNextWordBegin();
            /*0x8193d64*/ void MoveRight(bool shift, bool ctrl);
            /*0x8194160*/ int FindtPrevWordBegin();
            /*0x8193c38*/ void MoveLeft(bool shift, bool ctrl);
            /*0x8194200*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x8194310*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x8194668*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x8193e9c*/ void MoveDown(bool shift);
            /*0x819491c*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x8193e90*/ void MoveUp(bool shift);
            /*0x8194a40*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x8193a1c*/ void Delete();
            /*0x81938c0*/ void ForwardSpace();
            /*0x81937ac*/ void Backspace();
            /*0x8194b98*/ void Insert(char c);
            /*0x8193bf0*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x8192454*/ void SendOnValueChangedAndUpdateLabel();
            /*0x818ebec*/ void SendOnValueChanged();
            /*0x8194ca8*/ void SendOnEndEdit();
            /*0x8191cdc*/ void SendOnSubmit();
            /*0x8194d28*/ void Append(string input);
            /*0x8194de4*/ void Append(char input);
            /*0x818ec6c*/ void UpdateLabel();
            /*0x8195b84*/ bool IsSelectionVisible();
            /*0x8195048*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x8195d40*/ void ForceLabelUpdate();
            /*0x818f200*/ void MarkGeometryAsDirty();
            /*0x8195d44*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x81961a8*/ void LayoutComplete();
            /*0x81961ac*/ void GraphicUpdateComplete();
            /*0x8195d54*/ void UpdateGeometry();
            /*0x81917dc*/ void AssignPositioningIfNeeded();
            /*0x81961b0*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x8196438*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x81972d4*/ void CreateCursorVerts();
            /*0x8196b50*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x8191d5c*/ char Validate(string text, int pos, char ch);
            /*0x8197434*/ void ActivateInputField();
            /*0x819149c*/ void ActivateInputFieldInternal();
            /*0x8197554*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x8197590*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x819050c*/ void DeactivateInputField();
            /*0x81975b4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81975e0*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x818f8e4*/ void EnforceContentType();
            /*0x818e4e8*/ void EnforceTextHOverflow();
            /*0x818fa68*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x818fb58*/ void SetToCustom();
            /*0x8197628*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x8197654*/ void CalculateLayoutInputHorizontal();
            /*0x8197658*/ void CalculateLayoutInputVertical();
            /*0x819765c*/ float get_minWidth();
            /*0x8197664*/ float get_preferredWidth();
            /*0x81977c0*/ float get_flexibleWidth();
            /*0x81977c8*/ float get_minHeight();
            /*0x81977d0*/ float get_preferredHeight();
            /*0x8197918*/ float get_flexibleHeight();
            /*0x8197920*/ int get_layoutPriority();
            /*0x81979d8*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x818eb38*/ OnValidateInput(object object, nint method);
                /*0x81979e0*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x81979f4*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x8197a78*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x818e410*/ SubmitEvent();
            }

            class EndEditEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x818e458*/ EndEditEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x818e4a0*/ OnChangeEvent();
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

                /*0x8190768*/ <CaretBlink>d__172(int <>1__state);
                /*0x8197aa0*/ void System.IDisposable.Dispose();
                /*0x8197aa4*/ bool MoveNext();
                /*0x8197bc8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x8197bd0*/ void System.Collections.IEnumerator.Reset();
                /*0x8197c08*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__196 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x8193190*/ <MouseDragOutsideRect>d__196(int <>1__state);
                /*0x8197c10*/ void System.IDisposable.Dispose();
                /*0x8197c14*/ bool MoveNext();
                /*0x8197e9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x8197ea4*/ void System.Collections.IEnumerator.Reset();
                /*0x8197edc*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x8198088*/ AspectRatioFitter();
            /*0x8197ee4*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x8197eec*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x8197f64*/ float get_aspectRatio();
            /*0x8197f6c*/ void set_aspectRatio(float value);
            /*0x8197fe0*/ UnityEngine.RectTransform get_rectTransform();
            /*0x8198098*/ void OnEnable();
            /*0x8198130*/ void Start();
            /*0x8198274*/ void OnDisable();
            /*0x81986e4*/ void OnTransformParentChanged();
            /*0x819877c*/ void Update();
            /*0x8198790*/ void OnRectTransformDimensionsChange();
            /*0x8198794*/ void UpdateRect();
            /*0x8198b78*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x8198a80*/ UnityEngine.Vector2 GetParentSize();
            /*0x8198c6c*/ void SetLayoutHorizontal();
            /*0x8198c70*/ void SetLayoutVertical();
            /*0x8197f60*/ void SetDirty();
            /*0x8198180*/ bool IsComponentValidOnObject();
            /*0x819824c*/ bool IsAspectModeValid();
            /*0x8198c74*/ bool DoesParentExists();

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

            /*0x8198d8c*/ CanvasScaler();
            /*0x8198c7c*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x8198c84*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x8198c8c*/ float get_referencePixelsPerUnit();
            /*0x8198c94*/ void set_referencePixelsPerUnit(float value);
            /*0x8198c9c*/ float get_scaleFactor();
            /*0x8198ca4*/ void set_scaleFactor(float value);
            /*0x8198cb8*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x8198cc0*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x8198d24*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x8198d2c*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x8198d34*/ float get_matchWidthOrHeight();
            /*0x8198d3c*/ void set_matchWidthOrHeight(float value);
            /*0x8198d44*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x8198d4c*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0x8198d54*/ float get_fallbackScreenDPI();
            /*0x8198d5c*/ void set_fallbackScreenDPI(float value);
            /*0x8198d64*/ float get_defaultSpriteDPI();
            /*0x8198d6c*/ void set_defaultSpriteDPI(float value);
            /*0x8198d7c*/ float get_dynamicPixelsPerUnit();
            /*0x8198d84*/ void set_dynamicPixelsPerUnit(float value);
            /*0x8198dd4*/ void OnEnable();
            /*0x8198ea4*/ void Canvas_preWillRenderCanvases();
            /*0x8198eb4*/ void OnDisable();
            /*0x8198fdc*/ void Handle();
            /*0x81990d8*/ void HandleWorldCanvas();
            /*0x81990f8*/ void HandleConstantPixelSize();
            /*0x8199118*/ void HandleScaleWithScreenSize();
            /*0x819934c*/ void HandleConstantPhysicalSize();
            /*0x8198f5c*/ void SetScaleFactor(float scaleFactor);
            /*0x8198f9c*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

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

            /*0x81995d8*/ ContentSizeFitter();
            /*0x81993b4*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x81993bc*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x81994b4*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x81994bc*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x8199530*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81995e0*/ void OnEnable();
            /*0x81995fc*/ void OnDisable();
            /*0x8199678*/ void OnRectTransformDimensionsChange();
            /*0x819967c*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x8199778*/ void SetLayoutHorizontal();
            /*0x819979c*/ void SetLayoutVertical();
            /*0x8199430*/ void SetDirty();

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

            /*0x8199a10*/ GridLayoutGroup();
            /*0x81997a4*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x81997ac*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x8199808*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x8199810*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x819986c*/ UnityEngine.Vector2 get_cellSize();
            /*0x8199874*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x81998d8*/ UnityEngine.Vector2 get_spacing();
            /*0x81998e0*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x8199944*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x819994c*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x81999a8*/ int get_constraintCount();
            /*0x81999b0*/ void set_constraintCount(int value);
            /*0x8199bd4*/ void CalculateLayoutInputHorizontal();
            /*0x819a1d8*/ void CalculateLayoutInputVertical();
            /*0x819a488*/ void SetLayoutHorizontal();
            /*0x819ac1c*/ void SetLayoutVertical();
            /*0x819a490*/ void SetCellsAlongAxis(int axis);

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
            /*0x819ae1c*/ HorizontalLayoutGroup();
            /*0x819ae34*/ void CalculateLayoutInputHorizontal();
            /*0x819b0f4*/ void CalculateLayoutInputVertical();
            /*0x819b100*/ void SetLayoutHorizontal();
            /*0x819b75c*/ void SetLayoutVertical();
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

            /*0x819ae28*/ HorizontalOrVerticalLayoutGroup();
            /*0x819b768*/ float get_spacing();
            /*0x819b770*/ void set_spacing(float value);
            /*0x819b7cc*/ bool get_childForceExpandWidth();
            /*0x819b7d4*/ void set_childForceExpandWidth(bool value);
            /*0x819b830*/ bool get_childForceExpandHeight();
            /*0x819b838*/ void set_childForceExpandHeight(bool value);
            /*0x819b894*/ bool get_childControlWidth();
            /*0x819b89c*/ void set_childControlWidth(bool value);
            /*0x819b8f8*/ bool get_childControlHeight();
            /*0x819b900*/ void set_childControlHeight(bool value);
            /*0x819b95c*/ bool get_childScaleWidth();
            /*0x819b964*/ void set_childScaleWidth(bool value);
            /*0x819b9c0*/ bool get_childScaleHeight();
            /*0x819b9c8*/ void set_childScaleHeight(bool value);
            /*0x819ba24*/ bool get_reverseArrangement();
            /*0x819ba2c*/ void set_reverseArrangement(bool value);
            /*0x819ae54*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x819b10c*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x819ba88*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
        }

        interface ILayoutElement
        {
            /*0x380cb08*/ void CalculateLayoutInputHorizontal();
            /*0x380cb08*/ void CalculateLayoutInputVertical();
            /*0x380c2e4*/ float get_minWidth();
            /*0x380c2e4*/ float get_preferredWidth();
            /*0x380c2e4*/ float get_flexibleWidth();
            /*0x380c2e4*/ float get_minHeight();
            /*0x380c2e4*/ float get_preferredHeight();
            /*0x380c2e4*/ float get_flexibleHeight();
            /*0x380b6a0*/ int get_layoutPriority();
        }

        interface ILayoutController
        {
            /*0x380cb08*/ void SetLayoutHorizontal();
            /*0x380cb08*/ void SetLayoutVertical();
        }

        interface ILayoutGroup : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutSelfController : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutIgnorer
        {
            /*0x380b128*/ bool get_ignoreLayout();
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

            /*0x819c684*/ LayoutElement();
            /*0x819c1e4*/ bool get_ignoreLayout();
            /*0x819c1ec*/ void set_ignoreLayout(bool value);
            /*0x819c318*/ void CalculateLayoutInputHorizontal();
            /*0x819c31c*/ void CalculateLayoutInputVertical();
            /*0x819c320*/ float get_minWidth();
            /*0x819c328*/ void set_minWidth(float value);
            /*0x819c39c*/ float get_minHeight();
            /*0x819c3a4*/ void set_minHeight(float value);
            /*0x819c418*/ float get_preferredWidth();
            /*0x819c420*/ void set_preferredWidth(float value);
            /*0x819c494*/ float get_preferredHeight();
            /*0x819c49c*/ void set_preferredHeight(float value);
            /*0x819c510*/ float get_flexibleWidth();
            /*0x819c518*/ void set_flexibleWidth(float value);
            /*0x819c58c*/ float get_flexibleHeight();
            /*0x819c594*/ void set_flexibleHeight(float value);
            /*0x819c608*/ int get_layoutPriority();
            /*0x819c610*/ void set_layoutPriority(int value);
            /*0x819c6a4*/ void OnEnable();
            /*0x819c6c0*/ void OnTransformParentChanged();
            /*0x819c6c4*/ void OnDisable();
            /*0x819c6e0*/ void OnDidApplyAnimationProperties();
            /*0x819c6e4*/ void OnBeforeTransformParentChanged();
            /*0x819c260*/ void SetDirty();
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

            /*0x8199a78*/ LayoutGroup();
            /*0x819c6e8*/ UnityEngine.RectOffset get_padding();
            /*0x819c6f0*/ void set_padding(UnityEngine.RectOffset value);
            /*0x819c74c*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x819c754*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x819a3e0*/ UnityEngine.RectTransform get_rectTransform();
            /*0x819c7b0*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x8199da0*/ void CalculateLayoutInputHorizontal();
            /*0x380cb08*/ void CalculateLayoutInputVertical();
            /*0x819c7b8*/ float get_minWidth();
            /*0x819c7c0*/ float get_preferredWidth();
            /*0x819c7c8*/ float get_flexibleWidth();
            /*0x819c7d0*/ float get_minHeight();
            /*0x819c7d8*/ float get_preferredHeight();
            /*0x819c7e0*/ float get_flexibleHeight();
            /*0x819c7e8*/ int get_layoutPriority();
            /*0x380cb08*/ void SetLayoutHorizontal();
            /*0x380cb08*/ void SetLayoutVertical();
            /*0x819c7f0*/ void OnEnable();
            /*0x819c8e0*/ void OnDisable();
            /*0x819c95c*/ void OnDidApplyAnimationProperties();
            /*0x819c168*/ float GetTotalMinSize(int axis);
            /*0x819c088*/ float GetTotalPreferredSize(int axis);
            /*0x819c0f8*/ float GetTotalFlexibleSize(int axis);
            /*0x819ac24*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x819bb9c*/ float GetAlignmentOnAxis(int axis);
            /*0x819a158*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x819c960*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x819be5c*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x819ad6c*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x819bbe8*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x819ca08*/ bool get_isRootLayoutGroup();
            /*0x819cb34*/ void OnRectTransformDimensionsChange();
            /*0x819cb64*/ void OnTransformChildrenChanged();
            /*0x3907c14*/ void SetProperty<T>(ref T currentValue, T newValue);
            /*0x819c80c*/ void SetDirty();
            /*0x819cb68*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x819cbd4*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x819cbfc*/ void System.IDisposable.Dispose();
                /*0x819cc00*/ bool MoveNext();
                /*0x819cc9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x819cca4*/ void System.Collections.IEnumerator.Reset();
                /*0x819ccdc*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x819cd48*/ LayoutRebuilder();
            static /*0x819cf34*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x819cff0*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x819d0f0*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x81982f0*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x819db04*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x819dcec*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x819df78*/ LayoutRebuilder();
            /*0x819cce4*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x819cd24*/ void Clear();
            /*0x819cf88*/ UnityEngine.Transform get_transform();
            /*0x819cf90*/ bool IsDestroyed();
            /*0x819d1b8*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x819d748*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x819d484*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x819de30*/ void LayoutComplete();
            /*0x819deb0*/ void GraphicUpdateComplete();
            /*0x819deb4*/ int GetHashCode();
            /*0x819debc*/ bool Equals(object obj);
            /*0x819df0c*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x819df80*/ <>c();
                /*0x819dfe8*/ <>c();
                /*0x819dff0*/ UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0();
                /*0x819e044*/ void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x);
                /*0x819e070*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x819e0fc*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x819e1b8*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x819e274*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x819e334*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x8199760*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x819976c*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x819c1d8*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x819e4e4*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x819e77c*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x819ea14*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x819e3f4*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x819e5d4*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x819e924*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x819eb04*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x819eb1c*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

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

                static /*0x819ee44*/ <>c();
                /*0x819eeac*/ <>c();
                /*0x819eeb4*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x819ef54*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x819eff4*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x819f094*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x819f134*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x819f1d4*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x819f274*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x819f314*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x819f3b4*/ VerticalLayoutGroup();
            /*0x819f3c0*/ void CalculateLayoutInputHorizontal();
            /*0x819f3e0*/ void CalculateLayoutInputVertical();
            /*0x819f3ec*/ void SetLayoutHorizontal();
            /*0x819f3f8*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x20*/ UnityEngine.RectTransform m_RectTransform;
            /*0x28*/ bool m_ShowMaskGraphic;
            /*0x30*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x38*/ UnityEngine.Material m_MaskMaterial;
            /*0x40*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x819f59c*/ Mask();
            /*0x819f404*/ UnityEngine.RectTransform get_rectTransform();
            /*0x819f474*/ bool get_showMaskGraphic();
            /*0x819f47c*/ void set_showMaskGraphic(bool value);
            /*0x819f52c*/ UnityEngine.UI.Graphic get_graphic();
            /*0x819f5ac*/ bool MaskEnabled();
            /*0x819f63c*/ void OnSiblingGraphicEnabledDisabled();
            /*0x819f640*/ void OnEnable();
            /*0x819fa10*/ void OnDisable();
            /*0x819fbf4*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x819fca0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
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

            /*0x81a10cc*/ MaskableGraphic();
            /*0x81a0394*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x81a039c*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x81a03a4*/ bool get_maskable();
            /*0x81a03ac*/ void set_maskable(bool value);
            /*0x81a03dc*/ bool get_isMaskingGraphic();
            /*0x819f7a0*/ void set_isMaskingGraphic(bool value);
            /*0x81a03e4*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x81a04f4*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x81a077c*/ void UpdateCull(bool cull);
            /*0x81a0860*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x81a08cc*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x81a0904*/ void OnEnable();
            /*0x81a0ab4*/ void OnDisable();
            /*0x81a0b7c*/ void OnTransformParentChanged();
            /*0x81a0bcc*/ void ParentMaskStateChanged();
            /*0x81a0bd0*/ void OnCanvasHierarchyChanged();
            /*0x81a05c4*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x81a0954*/ void UpdateClipParent();
            /*0x81a1034*/ void RecalculateClipping();
            /*0x81a1038*/ void RecalculateMasking();
            /*0x81a11e8*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x81a11a0*/ CullStateChangedEvent();
            }
        }

        class MaskUtilities
        {
            static /*0x81a11f0*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x819f7b8*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x819ff6c*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x81a010c*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x81a144c*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x81a0c20*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x81a15a4*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x81a1908*/ MaskUtilities();
        }

        interface IMaterialModifier
        {
            /*0x380bb68*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x81a1910*/ void Destroy(UnityEngine.Object obj);
            static /*0x81a1a34*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x81a1b00*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x81a1fd8*/ UnityEngine.Vector3 GetRelativeMousePositionForRaycast(UnityEngine.EventSystems.PointerEventData eventData);
            static /*0x81a1b6c*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position, int displayIndex);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x81a2110*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0x81a20ac*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0x81a20b4*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0x81a20bc*/ bool get_wrapAround();
            /*0x81a20c4*/ void set_wrapAround(bool value);
            /*0x81a20d0*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0x81a20d8*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0x81a20e0*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0x81a20e8*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0x81a20f0*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0x81a20f8*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0x81a2100*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0x81a2108*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0x81a2130*/ bool Equals(UnityEngine.UI.Navigation other);

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

            /*0x81a2248*/ RawImage();
            /*0x81a2270*/ UnityEngine.Texture get_mainTexture();
            /*0x81a23c8*/ UnityEngine.Texture get_texture();
            /*0x81a23d0*/ void set_texture(UnityEngine.Texture value);
            /*0x81a248c*/ UnityEngine.Rect get_uvRect();
            /*0x81a2498*/ void set_uvRect(UnityEngine.Rect value);
            /*0x81a24e4*/ void SetNativeSize();
            /*0x81a2798*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x81a2e1c*/ void OnDidApplyAnimationProperties();
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

            /*0x81a30c8*/ RectMask2D();
            /*0x81a2e58*/ UnityEngine.Vector4 get_padding();
            /*0x81a2e64*/ void set_padding(UnityEngine.Vector4 value);
            /*0x81a2e74*/ UnityEngine.Vector2Int get_softness();
            /*0x81a2e7c*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x81a2e94*/ UnityEngine.Canvas get_Canvas();
            /*0x81a3014*/ UnityEngine.Rect get_canvasRect();
            /*0x81a3058*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81a3268*/ void OnEnable();
            /*0x81a329c*/ void OnDisable();
            /*0x81a336c*/ void OnDestroy();
            /*0x81a338c*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x81a3468*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x81a3564*/ void PerformClipping();
            /*0x81a3d84*/ void UpdateClipSoftness();
            /*0x81a407c*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x81a4190*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x81a4330*/ void OnTransformParentChanged();
            /*0x81a4360*/ void OnCanvasHierarchyChanged();
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

            /*0x81a4738*/ Scrollbar();
            /*0x81a4390*/ UnityEngine.RectTransform get_handleRect();
            /*0x81a4398*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x81a46bc*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x81a46c4*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x81a498c*/ float get_value();
            /*0x81a4a44*/ void set_value(float value);
            /*0x81a4b10*/ void SetValueWithoutNotify(float input);
            /*0x81a4b18*/ float get_size();
            /*0x81a4b20*/ void set_size(float value);
            /*0x81a4ba4*/ int get_numberOfSteps();
            /*0x81a4bac*/ void set_numberOfSteps(int value);
            /*0x81a4c30*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x81a4c38*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x81a4c48*/ float get_stepSize();
            /*0x81a4c74*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81a4c78*/ void LayoutComplete();
            /*0x81a4c7c*/ void GraphicUpdateComplete();
            /*0x81a4c80*/ void OnEnable();
            /*0x81a4f80*/ void OnDisable();
            /*0x81a50d8*/ void Update();
            /*0x81a4414*/ void UpdateCachedReferences();
            /*0x81a4a4c*/ void Set(float input, bool sendCallback);
            /*0x81a50ec*/ void OnRectTransformDimensionsChange();
            /*0x81a5124*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x81a5134*/ bool get_reverseValue();
            /*0x81a4504*/ void UpdateVisuals();
            /*0x81a5148*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a524c*/ void UpdateDrag(UnityEngine.RectTransform containerRect, UnityEngine.Vector2 position, UnityEngine.Camera camera);
            /*0x81a53c4*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x81a542c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a5490*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a5644*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a56d4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a5938*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a589c*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x81a59a0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a59e0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81a5cb4*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x81a5db0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x81a5eac*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x81a5fa8*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x81a60a4*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a60bc*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x81a6244*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x81a4804*/ ScrollEvent();
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

                /*0x81a5978*/ <ClickRepeat>d__59(int <>1__state);
                /*0x81a624c*/ void System.IDisposable.Dispose();
                /*0x81a6250*/ bool MoveNext();
                /*0x81a636c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x81a6374*/ void System.Collections.IEnumerator.Reset();
                /*0x81a63ac*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x81a8090*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x81a972c*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x81a9830*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x81a98ac*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x81a9a3c*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x81a6b04*/ ScrollRect();
            /*0x81a63b4*/ UnityEngine.RectTransform get_content();
            /*0x81a63bc*/ void set_content(UnityEngine.RectTransform value);
            /*0x81a63c4*/ bool get_horizontal();
            /*0x81a63cc*/ void set_horizontal(bool value);
            /*0x81a63d8*/ bool get_vertical();
            /*0x81a63e0*/ void set_vertical(bool value);
            /*0x81a63ec*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0x81a63f4*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x81a63fc*/ float get_elasticity();
            /*0x81a6404*/ void set_elasticity(float value);
            /*0x81a640c*/ bool get_inertia();
            /*0x81a6414*/ void set_inertia(bool value);
            /*0x81a6420*/ float get_decelerationRate();
            /*0x81a6428*/ void set_decelerationRate(float value);
            /*0x81a6430*/ float get_scrollSensitivity();
            /*0x81a6438*/ void set_scrollSensitivity(float value);
            /*0x81a6440*/ UnityEngine.RectTransform get_viewport();
            /*0x81a6448*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x81a652c*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x81a6534*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x81a66cc*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x81a66d4*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x81a686c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x81a6874*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x81a687c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x81a6884*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x81a688c*/ float get_horizontalScrollbarSpacing();
            /*0x81a6894*/ void set_horizontalScrollbarSpacing(float value);
            /*0x81a6924*/ float get_verticalScrollbarSpacing();
            /*0x81a692c*/ void set_verticalScrollbarSpacing(float value);
            /*0x81a6934*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0x81a693c*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x81a6944*/ UnityEngine.RectTransform get_viewRect();
            /*0x81a6a54*/ UnityEngine.Vector2 get_velocity();
            /*0x81a6a5c*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x81a6a64*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81a6c64*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81a7614*/ void LayoutComplete();
            /*0x81a7618*/ void GraphicUpdateComplete();
            /*0x81a6cec*/ void UpdateCachedData();
            /*0x81a761c*/ void OnEnable();
            /*0x81a77d8*/ void OnDisable();
            /*0x81a7a08*/ bool IsActive();
            /*0x81a7a88*/ void EnsureLayoutHasRebuilt();
            /*0x81a7afc*/ void StopMovement();
            /*0x81a7b4c*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x81a7ce8*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a7d48*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a7e74*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a7e94*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a80c8*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x81a817c*/ void LateUpdate();
            /*0x81a753c*/ void UpdatePrevData();
            /*0x81a73bc*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x81a8754*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x81a89c4*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x81a87c4*/ float get_horizontalNormalizedPosition();
            /*0x81a8a0c*/ void set_horizontalNormalizedPosition(float value);
            /*0x81a88c4*/ float get_verticalNormalizedPosition();
            /*0x81a8a20*/ void set_verticalNormalizedPosition(float value);
            /*0x81a8a34*/ void SetHorizontalNormalizedPosition(float value);
            /*0x81a8a48*/ void SetVerticalNormalizedPosition(float value);
            /*0x81a8a5c*/ void SetNormalizedPosition(float value, int axis);
            /*0x81a8cf4*/ void OnRectTransformDimensionsChange();
            /*0x81a8cf8*/ bool get_hScrollingNeeded();
            /*0x81a8d80*/ bool get_vScrollingNeeded();
            /*0x81a8e08*/ void CalculateLayoutInputHorizontal();
            /*0x81a8e0c*/ void CalculateLayoutInputVertical();
            /*0x81a8e10*/ float get_minWidth();
            /*0x81a8e18*/ float get_preferredWidth();
            /*0x81a8e20*/ float get_flexibleWidth();
            /*0x81a8e28*/ float get_minHeight();
            /*0x81a8e30*/ float get_preferredHeight();
            /*0x81a8e38*/ float get_flexibleHeight();
            /*0x81a8e40*/ int get_layoutPriority();
            /*0x81a8e48*/ void SetLayoutHorizontal();
            /*0x81a9420*/ void SetLayoutVertical();
            /*0x81a8784*/ void UpdateScrollbarVisibility();
            /*0x81a94d8*/ void UpdateScrollbarLayout();
            /*0x81a7064*/ void UpdateBounds();
            /*0x81a932c*/ UnityEngine.Bounds GetBounds();
            /*0x81a7cb8*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x81a689c*/ void SetDirty();
            /*0x81a6464*/ void SetDirtyCaching();
            /*0x81a9b80*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x81a6c1c*/ ScrollRectEvent();
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

            static /*0x81ab6c0*/ Selectable();
            static /*0x81a9b88*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x81a9c24*/ int get_allSelectableCount();
            static /*0x81a9c7c*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x81a9d18*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x81ab268*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x81a484c*/ Selectable();
            /*0x81a9dd4*/ UnityEngine.UI.Navigation get_navigation();
            /*0x81a9dec*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0x81a9ed8*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x81a9ee0*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x81a9f54*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x81a9f64*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x81a9ffc*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x81aa008*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x81aa084*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x81aa08c*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x81aa100*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x81aa108*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x81aa17c*/ bool get_interactable();
            /*0x81aa184*/ void set_interactable(bool value);
            /*0x81aa2f4*/ bool get_isPointerInside();
            /*0x81aa2fc*/ void set_isPointerInside(bool value);
            /*0x81aa308*/ bool get_isPointerDown();
            /*0x81aa310*/ void set_isPointerDown(bool value);
            /*0x81aa31c*/ bool get_hasSelection();
            /*0x81aa324*/ void set_hasSelection(bool value);
            /*0x81aa330*/ UnityEngine.UI.Image get_image();
            /*0x81aa3ac*/ void set_image(UnityEngine.UI.Image value);
            /*0x81aa3b4*/ UnityEngine.Animator get_animator();
            /*0x81aa3fc*/ void Awake();
            /*0x81aa4ac*/ void OnCanvasGroupChanged();
            /*0x81aa4e0*/ bool ParentGroupAllowsInteraction();
            /*0x81aa658*/ bool IsInteractable();
            /*0x81aa678*/ void OnDidApplyAnimationProperties();
            /*0x81a4cb0*/ void OnEnable();
            /*0x81aa6cc*/ void OnTransformParentChanged();
            /*0x81a9e74*/ void OnSetProperty();
            /*0x81a4fa0*/ void OnDisable();
            /*0x81aa6f4*/ void OnApplicationFocus(bool hasFocus);
            /*0x81aa67c*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x81aa79c*/ void InstantClearState();
            /*0x81aab4c*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x81aadb4*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x81ab3e8*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x81a5cd8*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x81a5dd4*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x81a5ed0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x81a5fcc*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x81a5c28*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81aa80c*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x81aa91c*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x81aa9c4*/ void TriggerAnimation(string triggername);
            /*0x81ab4a0*/ bool IsHighlighted();
            /*0x81aa750*/ bool IsPressed();
            /*0x81ab4fc*/ void EvaluateAndTransitionToSelectionState();
            /*0x81a576c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a59b8*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81ab594*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81ab5a0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81ab5a8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81ab5b4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81ab5bc*/ void Select();

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
            static /*0x81ab744*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
            static /*0x3907c14*/ bool SetStruct<T>(ref T currentValue, T newValue);
            static /*0x3907c14*/ bool SetClass<T>(ref T currentValue, T newValue);
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

            /*0x81ac31c*/ Slider();
            /*0x81ab78c*/ UnityEngine.RectTransform get_fillRect();
            /*0x81ab794*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x81abe2c*/ UnityEngine.RectTransform get_handleRect();
            /*0x81abe34*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x81abeb0*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x81abeb8*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x81abf2c*/ float get_minValue();
            /*0x81abf34*/ void set_minValue(float value);
            /*0x81abfc4*/ float get_maxValue();
            /*0x81abfcc*/ void set_maxValue(float value);
            /*0x81ac05c*/ bool get_wholeNumbers();
            /*0x81ac064*/ void set_wholeNumbers(bool value);
            /*0x81ac0f4*/ float get_value();
            /*0x81ac194*/ void set_value(float value);
            /*0x81ac1a8*/ void SetValueWithoutNotify(float input);
            /*0x81ac1bc*/ float get_normalizedValue();
            /*0x81ac2a0*/ void set_normalizedValue(float value);
            /*0x81ac2d8*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x81ac2e0*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x81ac2f0*/ float get_stepSize();
            /*0x81ac42c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81ac430*/ void LayoutComplete();
            /*0x81ac434*/ void GraphicUpdateComplete();
            /*0x81ac438*/ void OnEnable();
            /*0x81ac474*/ void OnDisable();
            /*0x81ac494*/ void Update();
            /*0x81ac4d4*/ void OnDidApplyAnimationProperties();
            /*0x81ab810*/ void UpdateCachedReferences();
            /*0x81ac6bc*/ float ClampValue(float input);
            /*0x81ac794*/ void Set(float input, bool sendCallback);
            /*0x81ac858*/ void OnRectTransformDimensionsChange();
            /*0x81ac784*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x81ac770*/ bool get_reverseValue();
            /*0x81abb48*/ void UpdateVisuals();
            /*0x81ac890*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x81aca88*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81acaec*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81acca4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81accf4*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81acf40*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x81acf64*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x81acf88*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x81acfac*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x81acfd0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81acfe8*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x81ad170*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x81ac3e4*/ SliderEvent();
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

            /*0x81ad178*/ UnityEngine.Sprite get_highlightedSprite();
            /*0x81ad180*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0x81ad188*/ UnityEngine.Sprite get_pressedSprite();
            /*0x81ad190*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0x81ad198*/ UnityEngine.Sprite get_selectedSprite();
            /*0x81ad1a0*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0x81ad1a8*/ UnityEngine.Sprite get_disabledSprite();
            /*0x81ad1b0*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0x81ad1b8*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x81ae0dc*/ StencilMaterial();
            static /*0x81ad2c0*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x81ad2c8*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x81add2c*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x81ad354*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x81adde4*/ void Remove(UnityEngine.Material customMat);
            static /*0x81adfb0*/ void ClearAll();

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

                /*0x81addd4*/ MatEntry();
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

            static /*0x81af240*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x81ae174*/ Text();
            /*0x81ae218*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x81ae2b0*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x81ae320*/ UnityEngine.Texture get_mainTexture();
            /*0x81ae4e4*/ void FontTextureChanged();
            /*0x81ae4c8*/ UnityEngine.Font get_font();
            /*0x81ae5f0*/ void set_font(UnityEngine.Font value);
            /*0x81ae70c*/ string get_text();
            /*0x81ae714*/ void set_text(string value);
            /*0x81ae7f4*/ bool get_supportRichText();
            /*0x81ae810*/ void set_supportRichText(bool value);
            /*0x81ae870*/ bool get_resizeTextForBestFit();
            /*0x81ae88c*/ void set_resizeTextForBestFit(bool value);
            /*0x81ae8ec*/ int get_resizeTextMinSize();
            /*0x81ae908*/ void set_resizeTextMinSize(int value);
            /*0x81ae95c*/ int get_resizeTextMaxSize();
            /*0x81ae978*/ void set_resizeTextMaxSize(int value);
            /*0x81ae9cc*/ UnityEngine.TextAnchor get_alignment();
            /*0x81ae9e8*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x81aea3c*/ bool get_alignByGeometry();
            /*0x81aea58*/ void set_alignByGeometry(bool value);
            /*0x81aeaa0*/ int get_fontSize();
            /*0x81aeabc*/ void set_fontSize(int value);
            /*0x81aeb10*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x81aeb2c*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x81aeb80*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x81aeb9c*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x81aebf0*/ float get_lineSpacing();
            /*0x81aec0c*/ void set_lineSpacing(float value);
            /*0x81aec60*/ UnityEngine.FontStyle get_fontStyle();
            /*0x81aec7c*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x81aecd0*/ float get_pixelsPerUnit();
            /*0x81aee18*/ void OnEnable();
            /*0x81aee94*/ void OnDisable();
            /*0x81aeef8*/ void UpdateGeometry();
            /*0x81aef80*/ void AssignDefaultFont();
            /*0x81aeff0*/ void AssignDefaultFontIfNecessary();
            /*0x81af0ac*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x81af2ac*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x81af998*/ void CalculateLayoutInputHorizontal();
            /*0x81af99c*/ void CalculateLayoutInputVertical();
            /*0x81af9a0*/ float get_minWidth();
            /*0x81af9a8*/ float get_preferredWidth();
            /*0x81afa84*/ float get_flexibleWidth();
            /*0x81afa8c*/ float get_minHeight();
            /*0x81afa94*/ float get_preferredHeight();
            /*0x81afb4c*/ float get_flexibleHeight();
            /*0x81afb54*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0x100*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x108*/ UnityEngine.UI.Graphic graphic;
            /*0x110*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x118*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x120*/ bool m_IsOn;

            /*0x81afda0*/ Toggle();
            /*0x81afb5c*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x81afb64*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x81afe80*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81afe84*/ void LayoutComplete();
            /*0x81afe88*/ void GraphicUpdateComplete();
            /*0x81afe8c*/ void OnDestroy();
            /*0x81b02fc*/ void OnEnable();
            /*0x81b0328*/ void OnDisable();
            /*0x81b0348*/ void OnDidApplyAnimationProperties();
            /*0x81afb84*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x81b0860*/ bool get_isOn();
            /*0x81b0868*/ void set_isOn(bool value);
            /*0x81b0874*/ void SetIsOnWithoutNotify(bool value);
            /*0x81b046c*/ void Set(bool value, bool sendCallback);
            /*0x81afcdc*/ void PlayEffect(bool instant);
            /*0x81b09c0*/ void Start();
            /*0x81b09c8*/ void InternalToggle();
            /*0x81b0a1c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b0a40*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81b0a44*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x81afe38*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ bool m_AllowSwitchOff;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x81b0a60*/ ToggleGroup();
            /*0x81b0a4c*/ bool get_allowSwitchOff();
            /*0x81b0a54*/ void set_allowSwitchOff(bool value);
            /*0x81b0ae8*/ void Start();
            /*0x81b0b04*/ void OnEnable();
            /*0x81b0b20*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x81b0754*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x81b05e0*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x81b0670*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x81aff0c*/ void EnsureValidState();
            /*0x81b0880*/ bool AnyTogglesOn();
            /*0x81b0c70*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x81b0d6c*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x81b0df4*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x81b0eec*/ <>c();
                /*0x81b0f54*/ <>c();
                /*0x81b0f5c*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x81b0f74*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
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

            static /*0x81b1d20*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x81b0f8c*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x81b1da4*/ Raycast3DCallback(object object, nint method);
                /*0x81b1e44*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x81b1e84*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x81b1f84*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x81b1fb0*/ RaycastAllCallback(object object, nint method);
                /*0x81b2050*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x81b208c*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x81b2154*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x81b2160*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x81b2200*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x81b223c*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x81b230c*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x81b2334*/ Raycast2DCallback(object object, nint method);
                /*0x81b23d4*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x81b23e8*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x81b24c4*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x81b24fc*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x81b259c*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x81b25d8*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x81b26a0*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x81b26ac*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x81b274c*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x81b2788*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x81b2858*/ int EndInvoke(System.IAsyncResult result);
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

            static /*0x81b3b48*/ VertexHelper();
            /*0x81b2880*/ VertexHelper();
            /*0x81b2888*/ VertexHelper(UnityEngine.Mesh m);
            /*0x81b2ac4*/ void InitializeListIfRequired();
            /*0x81b2cb8*/ void Dispose();
            /*0x81a2a60*/ void Clear();
            /*0x81b2f20*/ int get_currentVertCount();
            /*0x81b2f6c*/ int get_currentIndexCount();
            /*0x81b2fb8*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x81b3118*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x81b3274*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x81b33d4*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x81b3870*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x81a2b7c*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x81b3968*/ void AddVert(UnityEngine.UIVertex v);
            /*0x81a2cac*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x81af888*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x81b39fc*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x81b3aa8*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x81b3af8*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x81b3be0*/ BaseVertexEffect();
            /*0x380d83c*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x20*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x81b4020*/ BaseMeshEffect();
            /*0x81b3be8*/ UnityEngine.UI.Graphic get_graphic();
            /*0x81b3c90*/ void OnEnable();
            /*0x81b3d38*/ void OnDisable();
            /*0x81b3dd4*/ void OnDidApplyAnimationProperties();
            /*0x81b3e70*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x380d83c*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        interface IVertexModifier
        {
            /*0x380d83c*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
        }

        interface IMeshModifier
        {
            /*0x380d83c*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x380d83c*/ void ModifyMesh(UnityEngine.UI.VertexHelper verts);
        }

        class Outline : UnityEngine.UI.Shadow
        {
            /*0x81b4028*/ Outline();
            /*0x81b4030*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x81b4270*/ PositionAsUV1();
            /*0x81b4278*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x28*/ UnityEngine.Color m_EffectColor;
            /*0x38*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x40*/ bool m_UseGraphicAlpha;

            /*0x81b4334*/ Shadow();
            /*0x81b435c*/ UnityEngine.Color get_effectColor();
            /*0x81b4368*/ void set_effectColor(UnityEngine.Color value);
            /*0x81b443c*/ UnityEngine.Vector2 get_effectDistance();
            /*0x81b4444*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x81b4548*/ bool get_useGraphicAlpha();
            /*0x81b4550*/ void set_useGraphicAlpha(bool value);
            /*0x81b4608*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x81b4918*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x81b4920*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;
                /*0x0*/ int m_EnabledObjectCount;

                /*0x380cb08*/ IndexedSet();
                /*0x3907c14*/ void Add(T item);
                /*0x3907c14*/ void Add(T item, bool isActive);
                /*0x3907c14*/ bool AddUnique(T item, bool isActive);
                /*0x3907c14*/ bool EnableItem(T item);
                /*0x3907c14*/ bool DisableItem(T item);
                /*0x3907c14*/ bool Remove(T item);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool Contains(T item);
                /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x380b6a0*/ int get_Count();
                /*0x380b6a0*/ int get_Capacity();
                /*0x380b128*/ bool get_IsReadOnly();
                /*0x3907c14*/ int IndexOf(T item);
                /*0x3907c14*/ void Insert(int index, T item);
                /*0x380cffc*/ void RemoveAt(int index);
                /*0x380d0e4*/ void Swap(int index1, int index2);
                /*0x3907c14*/ T get_Item(int index);
                /*0x3907c14*/ void set_Item(int index, T value);
                /*0x380d83c*/ void RemoveAll(System.Predicate<T> match);
                /*0x380d83c*/ void Sort(System.Comparison<T> sortLayoutFunction);
            }
        }

        namespace CoroutineTween
        {
            interface ITweenValue
            {
                /*0x380e050*/ void TweenValue(float floatPercentage);
                /*0x380b128*/ bool get_ignoreTimeScale();
                /*0x380c2e4*/ float get_duration();
                /*0x380b128*/ bool ValidTarget();
            }

            struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;
                /*0x18*/ UnityEngine.Color m_StartColor;
                /*0x28*/ UnityEngine.Color m_TargetColor;
                /*0x38*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;
                /*0x3c*/ float m_Duration;
                /*0x40*/ bool m_IgnoreTimeScale;

                /*0x81b4a40*/ UnityEngine.Color get_startColor();
                /*0x81b4a4c*/ void set_startColor(UnityEngine.Color value);
                /*0x81b4a58*/ UnityEngine.Color get_targetColor();
                /*0x81b4a64*/ void set_targetColor(UnityEngine.Color value);
                /*0x81b4a70*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0x81b4a78*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0x81b4a80*/ float get_duration();
                /*0x81b4a88*/ void set_duration(float value);
                /*0x81b4a90*/ bool get_ignoreTimeScale();
                /*0x81b4a98*/ void set_ignoreTimeScale(bool value);
                /*0x81b4aa4*/ void TweenValue(float floatPercentage);
                /*0x81b4b90*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0x81b4c6c*/ bool GetIgnoreTimescale();
                /*0x81b4c74*/ float GetDuration();
                /*0x81b4b80*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x81b4c24*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0x81b4c7c*/ float get_startValue();
                /*0x81b4c84*/ void set_startValue(float value);
                /*0x81b4c8c*/ float get_targetValue();
                /*0x81b4c94*/ void set_targetValue(float value);
                /*0x81b4c9c*/ float get_duration();
                /*0x81b4ca4*/ void set_duration(float value);
                /*0x81b4cac*/ bool get_ignoreTimeScale();
                /*0x81b4cb4*/ void set_ignoreTimeScale(bool value);
                /*0x81b4cc0*/ void TweenValue(float floatPercentage);
                /*0x81b4d5c*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0x81b4e38*/ bool GetIgnoreTimescale();
                /*0x81b4e40*/ float GetDuration();
                /*0x81b4d4c*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x81b4df0*/ FloatTweenCallback();
                }
            }

            class TweenRunner<T>
            {
                /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
                /*0x0*/ System.Collections.IEnumerator m_Tween;

                static /*0x3907c14*/ System.Collections.IEnumerator Start(T tweenInfo);
                /*0x380cb08*/ TweenRunner();
                /*0x380d83c*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
                /*0x3907c14*/ void StartTween(T info);
                /*0x380cb08*/ void StopTween();

                class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ T tweenInfo;
                    /*0x0*/ float <elapsedTime>5__2;

                    /*0x380cffc*/ <Start>d__2(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x81b779c*/ PanelEventHandler();
            /*0x81b4e48*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x81b4e50*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x81b526c*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x81b5284*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x81b5358*/ bool get_isCurrentFocusedPanel();
            /*0x81b5420*/ UnityEngine.UIElements.Focusable get_currentFocusedElement();
            /*0x81b5458*/ void OnEnable();
            /*0x81b5460*/ void OnDisable();
            /*0x81b50b8*/ void RegisterCallbacks();
            /*0x81b4f04*/ void UnregisterCallbacks();
            /*0x81b5468*/ void OnPanelDestroyed();
            /*0x81b5470*/ void OnElementFocus(UnityEngine.UIElements.FocusEvent e);
            /*0x81b5558*/ void OnElementBlur(UnityEngine.UIElements.BlurEvent e);
            /*0x81b555c*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81b55d4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81b55e8*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b5938*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b5b54*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b5de0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b6108*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b615c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b6178*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81b64d0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81b66e0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81b6914*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81b58d4*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData);
            /*0x81b6b30*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent);
            /*0x81b6b50*/ void Update();
            /*0x81b6bac*/ void LateUpdate();
            /*0x81b6388*/ void ProcessImguiEvents(UnityEngine.UIElements.Focusable target);
            /*0x81b6bb4*/ void ProcessKeyboardEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81b6c34*/ void ProcessTabEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81b70bc*/ void SendTabEvent(UnityEngine.Event e, UnityEngine.UIElements.NavigationMoveEvent.Direction direction, UnityEngine.UIElements.Focusable target);
            /*0x81b6c9c*/ void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81b6eac*/ void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81b5794*/ bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);

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

                static /*0x81b7a78*/ bool <Read>g__InRange|90_0(int i, int start, int count);
                /*0x81b7848*/ PointerEvent();
                /*0x81b7858*/ int get_pointerId();
                /*0x81b7860*/ void set_pointerId(int value);
                /*0x81b7868*/ string get_pointerType();
                /*0x81b7870*/ void set_pointerType(string value);
                /*0x81b7878*/ bool get_isPrimary();
                /*0x81b7880*/ void set_isPrimary(bool value);
                /*0x81b788c*/ int get_button();
                /*0x81b7894*/ void set_button(int value);
                /*0x81b789c*/ int get_pressedButtons();
                /*0x81b78a4*/ void set_pressedButtons(int value);
                /*0x81b78ac*/ UnityEngine.Vector3 get_position();
                /*0x81b78b8*/ void set_position(UnityEngine.Vector3 value);
                /*0x81b78c4*/ UnityEngine.Vector3 get_localPosition();
                /*0x81b78d0*/ void set_localPosition(UnityEngine.Vector3 value);
                /*0x81b78dc*/ UnityEngine.Vector3 get_deltaPosition();
                /*0x81b78e8*/ void set_deltaPosition(UnityEngine.Vector3 value);
                /*0x81b78f4*/ float get_deltaTime();
                /*0x81b78fc*/ void set_deltaTime(float value);
                /*0x81b7904*/ int get_clickCount();
                /*0x81b790c*/ void set_clickCount(int value);
                /*0x81b7914*/ float get_pressure();
                /*0x81b791c*/ void set_pressure(float value);
                /*0x81b7924*/ float get_tangentialPressure();
                /*0x81b792c*/ void set_tangentialPressure(float value);
                /*0x81b7934*/ float get_altitudeAngle();
                /*0x81b793c*/ void set_altitudeAngle(float value);
                /*0x81b7944*/ float get_azimuthAngle();
                /*0x81b794c*/ void set_azimuthAngle(float value);
                /*0x81b7954*/ float get_twist();
                /*0x81b795c*/ void set_twist(float value);
                /*0x81b7964*/ UnityEngine.Vector2 get_tilt();
                /*0x81b796c*/ void set_tilt(UnityEngine.Vector2 value);
                /*0x81b7974*/ UnityEngine.PenStatus get_penStatus();
                /*0x81b797c*/ void set_penStatus(UnityEngine.PenStatus value);
                /*0x81b7984*/ UnityEngine.Vector2 get_radius();
                /*0x81b798c*/ void set_radius(UnityEngine.Vector2 value);
                /*0x81b7994*/ UnityEngine.Vector2 get_radiusVariance();
                /*0x81b799c*/ void set_radiusVariance(UnityEngine.Vector2 value);
                /*0x81b79a4*/ UnityEngine.EventModifiers get_modifiers();
                /*0x81b79ac*/ void set_modifiers(UnityEngine.EventModifiers value);
                /*0x81b79b4*/ bool get_shiftKey();
                /*0x81b79c0*/ bool get_ctrlKey();
                /*0x81b79cc*/ bool get_commandKey();
                /*0x81b79d8*/ bool get_altKey();
                /*0x81b79e4*/ bool get_actionKey();
                /*0x81b72b0*/ void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);
                /*0x81b7784*/ void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride);
            }
        }

        class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
        {
            /*0x28*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;

            /*0x81b8240*/ PanelRaycaster();
            /*0x81b7a94*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x81b7a9c*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x81b7be0*/ void RegisterCallbacks();
            /*0x81b7b50*/ void UnregisterCallbacks();
            /*0x81b7c70*/ void OnPanelDestroyed();
            /*0x81b7c78*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x81b7c90*/ int get_sortOrderPriority();
            /*0x81b7d0c*/ int get_renderOrderPriority();
            /*0x81b7d80*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x81b8238*/ UnityEngine.Camera get_eventCamera();
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x81b8270*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x81b8250*/ UnityEngine.Vector2 get_moveVector();
            /*0x81b8258*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x81b8260*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0x81b8268*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x81b8330*/ AbstractEventData();
            /*0x81b8314*/ void Reset();
            /*0x81b831c*/ void Use();
            /*0x81b8328*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0x81b82e4*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x81b8338*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x81b8354*/ UnityEngine.GameObject get_selectedObject();
            /*0x81b8370*/ void set_selectedObject(UnityEngine.GameObject value);
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

            /*0x81b8878*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x81b85c4*/ UnityEngine.GameObject get_pointerEnter();
            /*0x81b85cc*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x81b85d4*/ UnityEngine.GameObject get_lastPress();
            /*0x81b85dc*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x81b85e4*/ UnityEngine.GameObject get_rawPointerPress();
            /*0x81b85ec*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0x81b85f4*/ UnityEngine.GameObject get_pointerDrag();
            /*0x81b85fc*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x81b8604*/ UnityEngine.GameObject get_pointerClick();
            /*0x81b860c*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x81b8614*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x81b8624*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x81b8648*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x81b8658*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x81b867c*/ bool get_eligibleForClick();
            /*0x81b8684*/ void set_eligibleForClick(bool value);
            /*0x81b8690*/ int get_displayIndex();
            /*0x81b8698*/ void set_displayIndex(int value);
            /*0x81b86a0*/ int get_pointerId();
            /*0x81b86a8*/ void set_pointerId(int value);
            /*0x81b86b0*/ UnityEngine.Vector2 get_position();
            /*0x81b86bc*/ void set_position(UnityEngine.Vector2 value);
            /*0x81b86c8*/ UnityEngine.Vector2 get_delta();
            /*0x81b86d4*/ void set_delta(UnityEngine.Vector2 value);
            /*0x81b86e0*/ UnityEngine.Vector2 get_pressPosition();
            /*0x81b86ec*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x81b86f8*/ UnityEngine.Vector3 get_worldPosition();
            /*0x81b8708*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x81b8718*/ UnityEngine.Vector3 get_worldNormal();
            /*0x81b8728*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x81b8738*/ float get_clickTime();
            /*0x81b8740*/ void set_clickTime(float value);
            /*0x81b8748*/ int get_clickCount();
            /*0x81b8750*/ void set_clickCount(int value);
            /*0x81b8758*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x81b8764*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x81b8770*/ bool get_useDragThreshold();
            /*0x81b8778*/ void set_useDragThreshold(bool value);
            /*0x81b8784*/ bool get_dragging();
            /*0x81b878c*/ void set_dragging(bool value);
            /*0x81b8798*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x81b87a0*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x81b87a8*/ float get_pressure();
            /*0x81b87b0*/ void set_pressure(float value);
            /*0x81b87b8*/ float get_tangentialPressure();
            /*0x81b87c0*/ void set_tangentialPressure(float value);
            /*0x81b87c8*/ float get_altitudeAngle();
            /*0x81b87d0*/ void set_altitudeAngle(float value);
            /*0x81b87d8*/ float get_azimuthAngle();
            /*0x81b87e0*/ void set_azimuthAngle(float value);
            /*0x81b87e8*/ float get_twist();
            /*0x81b87f0*/ void set_twist(float value);
            /*0x81b87f8*/ UnityEngine.Vector2 get_tilt();
            /*0x81b8804*/ void set_tilt(UnityEngine.Vector2 value);
            /*0x81b8810*/ UnityEngine.PenStatus get_penStatus();
            /*0x81b8818*/ void set_penStatus(UnityEngine.PenStatus value);
            /*0x81b8820*/ UnityEngine.Vector2 get_radius();
            /*0x81b882c*/ void set_radius(UnityEngine.Vector2 value);
            /*0x81b8838*/ UnityEngine.Vector2 get_radiusVariance();
            /*0x81b8844*/ void set_radiusVariance(UnityEngine.Vector2 value);
            /*0x81b8850*/ bool get_fullyExited();
            /*0x81b8858*/ void set_fullyExited(bool value);
            /*0x81b8864*/ bool get_reentered();
            /*0x81b886c*/ void set_reentered(bool value);
            /*0x81b89c0*/ bool IsPointerMoving();
            /*0x81b89e0*/ bool IsScrolling();
            /*0x81b8a00*/ UnityEngine.Camera get_enterEventCamera();
            /*0x81b8a90*/ UnityEngine.Camera get_pressEventCamera();
            /*0x81b8b20*/ UnityEngine.GameObject get_pointerPress();
            /*0x81b8b28*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x81b8bcc*/ string ToString();

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
            /*0x380d83c*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x380d83c*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
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

            static /*0x81bb644*/ EventSystem();
            static /*0x81b98a0*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x81b9964*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x81b9db4*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            static /*0x81ba6ac*/ void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart);
            /*0x81b9b4c*/ EventSystem();
            /*0x81b9af8*/ bool get_sendNavigationEvents();
            /*0x81b9b00*/ void set_sendNavigationEvents(bool value);
            /*0x81b9b0c*/ int get_pixelDragThreshold();
            /*0x81b9b14*/ void set_pixelDragThreshold(int value);
            /*0x81b9b1c*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x81b9b24*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x81b9b2c*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0x81b9b34*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x81b9b3c*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0x81b9b44*/ bool get_isFocused();
            /*0x81b9be8*/ void UpdateModules();
            /*0x81b9d28*/ bool get_alreadySelecting();
            /*0x81b838c*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x81b9d30*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x81b552c*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x81ba238*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x81ba428*/ bool IsPointerOverGameObject();
            /*0x81ba430*/ bool IsPointerOverGameObject(int pointerId);
            /*0x81ba4d4*/ bool get_isUIToolkitActiveEventSystem();
            /*0x81ba5c4*/ bool get_sendUIToolkitEvents();
            /*0x81ba638*/ bool get_createUIToolkitPanelGameObjectsOnStart();
            /*0x81ba858*/ void StartTrackingUIToolkitPanels();
            /*0x81bad44*/ void StopTrackingUIToolkitPanels();
            /*0x81baa90*/ void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x81badf8*/ void Start();
            /*0x81bae08*/ void OnEnable();
            /*0x81baf38*/ void OnDisable();
            /*0x81bb060*/ void TickModules();
            /*0x81bb160*/ void OnApplicationFocus(bool hasFocus);
            /*0x81bb174*/ void Update();
            /*0x81bb3dc*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x81bb4ec*/ string ToString();

            struct UIToolkitOverrideConfig
            {
                /*0x10*/ UnityEngine.EventSystems.EventSystem activeEventSystem;
                /*0x18*/ bool sendEvents;
                /*0x19*/ bool createPanelGameObjectsOnStart;
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.GameObject go;

                /*0x81badf0*/ <>c__DisplayClass56_0();
                /*0x81bb784*/ void <CreateUIToolkitPanelGameObject>b__0();
            }
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x81bb870*/ EventTrigger();
            /*0x81bb7e0*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x81bb868*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x81bb7e4*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x81bb878*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x81bb880*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81bb964*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb970*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb97c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb988*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb994*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb9a0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb9ac*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb9b8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81bb9c4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81bb9d0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bb9dc*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81bb9e8*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81bb9f4*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bba00*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bba0c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bba18*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81bba24*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x81bba30*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x81bba78*/ Entry();
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

            static /*0x81bd244*/ ExecuteEvents();
            static /*0x3907c14*/ T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x81bbae8*/ void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bbbdc*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bbcd0*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bbdc4*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bbeb8*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bbfac*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc0a0*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc194*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc288*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc37c*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc470*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc564*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc658*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc6fc*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc7a0*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc844*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc938*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bc9dc*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81bca80*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler();
            static /*0x81bcad8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x81bcb30*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x81bcb88*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x81bcbe0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x81bcc38*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x81bcc90*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x81bcce8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x81bcd40*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x81bcd98*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x81bcdf0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x81bce48*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x81bcea0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x81bcef8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x81bcf50*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x81bcfa8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x81bd000*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x81bd058*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x81bd0b0*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
            static /*0x381cd68*/ bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor);
            static /*0x3830a9c*/ UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction);
            static /*0x381ac0c*/ bool ShouldSendToComponent<T>(UnityEngine.Component component);
            static /*0x383af28*/ void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results);
            static /*0x381ac0c*/ bool CanHandleEvent<T>(UnityEngine.GameObject go);
            static /*0x382eaf0*/ UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root);

            class EventFunction<T1> : System.MulticastDelegate
            {
                EventFunction(object object, nint method);
                /*0x3907c14*/ void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData);
                /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object);
                /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x81bd9f8*/ BaseInput();
            /*0x81bd928*/ string get_compositionString();
            /*0x81bd930*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x81bd938*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x81bd944*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x81bd94c*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x81bd954*/ bool get_mousePresent();
            /*0x81bd95c*/ bool GetMouseButtonDown(int button);
            /*0x81bd968*/ bool GetMouseButtonUp(int button);
            /*0x81bd974*/ bool GetMouseButton(int button);
            /*0x81bd980*/ UnityEngine.Vector2 get_mousePosition();
            /*0x81bd988*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x81bd990*/ float get_mouseScrollDeltaPerTick();
            /*0x81bd998*/ bool get_touchSupported();
            /*0x81bd9a0*/ int get_touchCount();
            /*0x81bd9a8*/ UnityEngine.Touch GetTouch(int index);
            /*0x81bd9e0*/ float GetAxisRaw(string axisName);
            /*0x81bd9ec*/ bool GetButtonDown(string buttonName);
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

            static /*0x81bdcd0*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x81bdde4*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x81bde38*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x81bde88*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x81bed94*/ BaseInputModule();
            /*0x81bda00*/ bool get_sendPointerHoverToParent();
            /*0x81bda08*/ void set_sendPointerHoverToParent(bool value);
            /*0x81bda14*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x81bdc38*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x81bdc40*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x81bdc48*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x81bdc50*/ void OnEnable();
            /*0x81bdcb8*/ void OnDisable();
            /*0x380cb08*/ void Process();
            /*0x81bdffc*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x81beab8*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x81bebd0*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x81bec78*/ bool IsPointerOverGameObject(int pointerId);
            /*0x81bec80*/ bool ShouldActivateModule();
            /*0x81becc0*/ void DeactivateModule();
            /*0x81becc4*/ void ActivateModule();
            /*0x81becc8*/ void UpdateModule();
            /*0x81beccc*/ bool IsModuleSupported();
            /*0x81becd4*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
            /*0x81bed50*/ UnityEngine.Vector2 ConvertPointerEventScrollDeltaToTicks(UnityEngine.Vector2 scrollDelta);
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x58*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x60*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x81bf7bc*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x81c00ac*/ PointerInputModule();
            /*0x81bee24*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x81bef1c*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x81bef78*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x81bf308*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x81bf3a8*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x81bf424*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x81bf438*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x81bf79c*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x81bf7ec*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x81bf830*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x81bfafc*/ bool IsPointerOverGameObject(int pointerId);
            /*0x81bfb98*/ void ClearSelection();
            /*0x81bfd58*/ string ToString();
            /*0x81bffc0*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x81c020c*/ ButtonState();
                /*0x81c01ec*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x81c01f4*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x81c01fc*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0x81c0204*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x81c0164*/ MouseState();
                /*0x81c0214*/ bool AnyPressesThisFrame();
                /*0x81c02e0*/ bool AnyReleasesThisFrame();
                /*0x81c03b4*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x81bf760*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x81c055c*/ MouseButtonEventData();
                /*0x81c02d0*/ bool PressedThisFrame();
                /*0x81c03a0*/ bool ReleasedThisFrame();
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

            /*0x81c0564*/ StandaloneInputModule();
            /*0x81c0640*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x81c0648*/ bool get_allowActivationOnMobileDevice();
            /*0x81c0650*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x81c065c*/ bool get_forceModuleActive();
            /*0x81c0664*/ void set_forceModuleActive(bool value);
            /*0x81c0670*/ float get_inputActionsPerSecond();
            /*0x81c0678*/ void set_inputActionsPerSecond(float value);
            /*0x81c0680*/ float get_repeatDelay();
            /*0x81c0688*/ void set_repeatDelay(float value);
            /*0x81c0690*/ string get_horizontalAxis();
            /*0x81c0698*/ void set_horizontalAxis(string value);
            /*0x81c06a0*/ string get_verticalAxis();
            /*0x81c06a8*/ void set_verticalAxis(string value);
            /*0x81c06b0*/ string get_submitButton();
            /*0x81c06b8*/ void set_submitButton(string value);
            /*0x81c06c0*/ string get_cancelButton();
            /*0x81c06c8*/ void set_cancelButton(string value);
            /*0x81c06d0*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x81c06d8*/ void UpdateModule();
            /*0x81c07bc*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x81c0b60*/ bool ShouldActivateModule();
            /*0x81c0d98*/ void ActivateModule();
            /*0x81c0e98*/ void DeactivateModule();
            /*0x81c0e9c*/ void Process();
            /*0x81c1088*/ bool ProcessTouchEvents();
            /*0x81c166c*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x81c1458*/ bool SendSubmitEventToSelectedObject();
            /*0x81c1d94*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x81c11f4*/ bool SendMoveEventToSelectedObject();
            /*0x81c11ec*/ void ProcessMouseEvent();
            /*0x81c2150*/ bool ForceAutoSelect();
            /*0x81c1ea0*/ void ProcessMouseEvent(int id);
            /*0x81c0f40*/ bool SendUpdateEventToSelectedObject();
            /*0x81c2158*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x81c2514*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

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

            /*0x81c251c*/ TouchInputModule();
            /*0x81c2520*/ bool get_allowActivationOnStandalone();
            /*0x81c2528*/ void set_allowActivationOnStandalone(bool value);
            /*0x81c2534*/ bool get_forceModuleActive();
            /*0x81c253c*/ void set_forceModuleActive(bool value);
            /*0x81c2548*/ void UpdateModule();
            /*0x81c26b0*/ bool IsModuleSupported();
            /*0x81c26e8*/ bool ShouldActivateModule();
            /*0x81c278c*/ bool UseFakeInput();
            /*0x81c27bc*/ void Process();
            /*0x81c27e4*/ void FakeTouches();
            /*0x81c290c*/ void ProcessTouchEvents();
            /*0x81c2a54*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x81c3174*/ void DeactivateModule();
            /*0x81c3178*/ string ToString();
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

            static /*0x81c360c*/ RaycasterManager();
            static /*0x81c33c0*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x81c34e4*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x81c353c*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x81b8248*/ BaseRaycaster();
            /*0x380d93c*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x380b9e8*/ UnityEngine.Camera get_eventCamera();
            /*0x81c36a4*/ int get_priority();
            /*0x81c36ac*/ int get_sortOrderPriority();
            /*0x81c36b4*/ int get_renderOrderPriority();
            /*0x81ba16c*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x81c36bc*/ string ToString();
            /*0x81c3908*/ void OnEnable();
            /*0x81c395c*/ void OnDisable();
            /*0x81c39b0*/ void OnCanvasHierarchyChanged();
            /*0x81c39c0*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x48*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x81c39d0*/ Physics2DRaycaster();
            /*0x81c3a20*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x28*/ UnityEngine.Camera m_EventCamera;
            /*0x30*/ UnityEngine.LayerMask m_EventMask;
            /*0x34*/ int m_MaxRayIntersections;
            /*0x38*/ int m_LastMaxRayIntersections;
            /*0x40*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x81c39f8*/ PhysicsRaycaster();
            /*0x81c4538*/ UnityEngine.Camera get_eventCamera();
            /*0x81c461c*/ int get_depth();
            /*0x81c4474*/ int get_finalEventMask();
            /*0x81c46e0*/ UnityEngine.LayerMask get_eventMask();
            /*0x81c46e8*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x81c46f0*/ int get_maxRayIntersections();
            /*0x81c46f8*/ void set_maxRayIntersections(int value);
            /*0x81c4178*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x81c4700*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x81c4b8c*/ RaycastHitComparer();
                /*0x81c4b84*/ RaycastHitComparer();
                /*0x81c4b40*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
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

            /*0x81c4bf4*/ UnityEngine.GameObject get_gameObject();
            /*0x81c4bfc*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x81c4c04*/ bool get_isValid();
            /*0x81c4c9c*/ void Clear();
            /*0x81b92fc*/ string ToString();
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x81b7850*/ UIBehaviour();
            /*0x81c4d60*/ void Awake();
            /*0x81b545c*/ void OnEnable();
            /*0x81bae04*/ void Start();
            /*0x81b5464*/ void OnDisable();
            /*0x81c4d64*/ void OnDestroy();
            /*0x81c4d68*/ bool IsActive();
            /*0x81c4d70*/ void OnRectTransformDimensionsChange();
            /*0x81c4d74*/ void OnBeforeTransformParentChanged();
            /*0x81c39cc*/ void OnTransformParentChanged();
            /*0x81c4d78*/ void OnDidApplyAnimationProperties();
            /*0x81c4d7c*/ void OnCanvasGroupChanged();
            /*0x81c39bc*/ void OnCanvasHierarchyChanged();
            /*0x81c4d80*/ bool IsDestroyed();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;
    static /*0xc*/ <PrivateImplementationDetails> 25A2C70167B31FFF394DF1A97A5FAB177D08EC0C818887154CFDE60AA923B688;
    static /*0x1fb1*/ <PrivateImplementationDetails> 7C777EEED2359F9E03B1E9BA3FE7218E75A8BA42A33894ABBE8BB2022DDED720;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=5527
    {
    }

    struct __StaticArrayInitTypeSize=8101
    {
    }
}
