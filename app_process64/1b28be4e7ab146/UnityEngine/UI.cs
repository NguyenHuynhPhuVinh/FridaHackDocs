class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7fcd7b4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7fcd8a8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            /*0x7fcd900*/ AnimationTriggers();
            /*0x7fcd8b0*/ string get_normalTrigger();
            /*0x7fcd8b8*/ void set_normalTrigger(string value);
            /*0x7fcd8c0*/ string get_highlightedTrigger();
            /*0x7fcd8c8*/ void set_highlightedTrigger(string value);
            /*0x7fcd8d0*/ string get_pressedTrigger();
            /*0x7fcd8d8*/ void set_pressedTrigger(string value);
            /*0x7fcd8e0*/ string get_selectedTrigger();
            /*0x7fcd8e8*/ void set_selectedTrigger(string value);
            /*0x7fcd8f0*/ string get_disabledTrigger();
            /*0x7fcd8f8*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0x100*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x7fcd9f8*/ Button();
            /*0x7fcda98*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x7fcdaa0*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x7fcdab0*/ void Press();
            /*0x7fcdb48*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x7fcdb6c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x7fcdbe4*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x7fcda90*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x7fcdc50*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x7fcdc78*/ void System.IDisposable.Dispose();
                /*0x7fcdc7c*/ bool MoveNext();
                /*0x7fcdd7c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7fcdd84*/ void System.Collections.IEnumerator.Reset();
                /*0x7fcddbc*/ object System.Collections.IEnumerator.get_Current();
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
            /*0x3815ed0*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x38148bc*/ UnityEngine.Transform get_transform();
            /*0x38159dc*/ void LayoutComplete();
            /*0x38159dc*/ void GraphicUpdateComplete();
            /*0x3813ffc*/ bool IsDestroyed();
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

            static /*0x7fcf854*/ CanvasUpdateRegistry();
            static /*0x7fce004*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x7fcec38*/ int ParentCount(UnityEngine.Transform child);
            static /*0x7fcecf4*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x7fcee44*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fcef3c*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fcef9c*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fcf0cc*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fcf12c*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fcf464*/ void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x7fcf79c*/ bool IsRebuildingLayout();
            static /*0x7fcf7f8*/ bool IsRebuildingGraphics();
            /*0x7fcddc4*/ CanvasUpdateRegistry();
            /*0x7fce0b4*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x7fce184*/ void CleanInvalidItems();
            /*0x7fce468*/ void PerformUpdate();
            /*0x7fceea4*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fceffc*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fcf19c*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fcf300*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fcf4d4*/ void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x7fcf638*/ void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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

            static /*0x7fcf984*/ ColorBlock();
            static /*0x7fcfcb4*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x7fcfd48*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0x7fcf8ec*/ UnityEngine.Color get_normalColor();
            /*0x7fcf8f8*/ void set_normalColor(UnityEngine.Color value);
            /*0x7fcf904*/ UnityEngine.Color get_highlightedColor();
            /*0x7fcf910*/ void set_highlightedColor(UnityEngine.Color value);
            /*0x7fcf91c*/ UnityEngine.Color get_pressedColor();
            /*0x7fcf928*/ void set_pressedColor(UnityEngine.Color value);
            /*0x7fcf934*/ UnityEngine.Color get_selectedColor();
            /*0x7fcf940*/ void set_selectedColor(UnityEngine.Color value);
            /*0x7fcf94c*/ UnityEngine.Color get_disabledColor();
            /*0x7fcf958*/ void set_disabledColor(UnityEngine.Color value);
            /*0x7fcf964*/ float get_colorMultiplier();
            /*0x7fcf96c*/ void set_colorMultiplier(float value);
            /*0x7fcf974*/ float get_fadeDuration();
            /*0x7fcf97c*/ void set_fadeDuration(float value);
            /*0x7fcf9fc*/ bool Equals(object obj);
            /*0x7fcfabc*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0x7fcfde0*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x7fceaa8*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x7fcfed4*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x7fcff44*/ void Unregister(UnityEngine.UI.IClipper c);
            static /*0x7fcffa0*/ void Disable(UnityEngine.UI.IClipper c);
            /*0x7fcfe4c*/ ClipperRegistry();
            /*0x7fceb2c*/ void Cull();
        }

        class Clipping
        {
            static /*0x7fcfffc*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
        }

        interface IClipper
        {
            /*0x38159dc*/ void PerformClipping();
        }

        interface IClippable
        {
            /*0x38148bc*/ UnityEngine.GameObject get_gameObject();
            /*0x38159dc*/ void RecalculateClipping();
            /*0x38148bc*/ UnityEngine.RectTransform get_rectTransform();
            void Cull(UnityEngine.Rect clipRect, bool validRect);
            void SetClipRect(UnityEngine.Rect value, bool validRect);
            /*0x38171d8*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
        }

        class RectangularVertexClipper
        {
            /*0x10*/ UnityEngine.Vector3[] m_WorldCorners;
            /*0x18*/ UnityEngine.Vector3[] m_CanvasCorners;

            /*0x7fd032c*/ RectangularVertexClipper();
            /*0x7fd01d4*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
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

            static /*0x7fd4dec*/ DefaultControls();
            static /*0x7fd03ac*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x7fd0404*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x7fd0564*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x7fd078c*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x7fd0868*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x7fd068c*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x7fd08c8*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x7fd09ac*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd0fb0*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd13bc*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd1554*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd1688*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd17bc*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd1eb4*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd235c*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd2900*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd2f48*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x7fd44d0*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                /*0x3814b90*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x7fd4f44*/ DefaultRuntimeFactory();
                /*0x7fd4f3c*/ DefaultRuntimeFactory();
                /*0x7fd4ed0*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
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

            static /*0x7fd7d98*/ Dropdown();
            static /*0x3910ae8*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x7fd51b0*/ Dropdown();
            /*0x7fd4fac*/ UnityEngine.RectTransform get_template();
            /*0x7fd4270*/ void set_template(UnityEngine.RectTransform value);
            /*0x7fd4fb4*/ UnityEngine.UI.Text get_captionText();
            /*0x7fd4290*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x7fd4fbc*/ UnityEngine.UI.Image get_captionImage();
            /*0x7fd4fc4*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x7fd4fe4*/ UnityEngine.UI.Text get_itemText();
            /*0x7fd42b0*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x7fd4fec*/ UnityEngine.UI.Image get_itemImage();
            /*0x7fd4ff4*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x7fd42d0*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x7fd5014*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x7fd503c*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x7fd5044*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x7fd5054*/ float get_alphaFadeSpeed();
            /*0x7fd505c*/ void set_alphaFadeSpeed(float value);
            /*0x7fd5064*/ int get_value();
            /*0x7fd506c*/ void set_value(int value);
            /*0x7fd51a8*/ void SetValueWithoutNotify(int input);
            /*0x7fd5074*/ void Set(int value, bool sendCallback);
            /*0x7fd53a8*/ void Awake();
            /*0x7fd54a4*/ void Start();
            /*0x7fd5558*/ void OnDisable();
            /*0x7fd42f4*/ void RefreshShownValue();
            /*0x7fd577c*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x7fd57e4*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x7fd597c*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x7fd5b14*/ void ClearOptions();
            /*0x7fd5b8c*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x7fd6250*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x7fd6e90*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x7fd6e94*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x7fd6254*/ void Show();
            /*0x7fd73bc*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x7fd7900*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x7fd7958*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x7fd79c4*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x7fd7a1c*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x7fd7a88*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x7fd6fac*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x7fd7a8c*/ void AlphaFadeList(float duration, float alpha);
            /*0x7fd729c*/ void AlphaFadeList(float duration, float start, float end);
            /*0x7fd7b0c*/ void SetAlpha(float alpha);
            /*0x7fd6e98*/ void Hide();
            /*0x7fd7bc0*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x7fd55fc*/ void ImmediateDestroyDropdownList();
            /*0x7fd7c64*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x20*/ UnityEngine.UI.Text m_Text;
                /*0x28*/ UnityEngine.UI.Image m_Image;
                /*0x30*/ UnityEngine.RectTransform m_RectTransform;
                /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x7fd7f7c*/ DropdownItem();
                /*0x7fd7e14*/ UnityEngine.UI.Text get_text();
                /*0x7fd7e1c*/ void set_text(UnityEngine.UI.Text value);
                /*0x7fd7e24*/ UnityEngine.UI.Image get_image();
                /*0x7fd7e2c*/ void set_image(UnityEngine.UI.Image value);
                /*0x7fd7e34*/ UnityEngine.RectTransform get_rectTransform();
                /*0x7fd7e3c*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x7fd7e44*/ UnityEngine.UI.Toggle get_toggle();
                /*0x7fd7e4c*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x7fd7e54*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7fd7ed0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x7fd42ec*/ OptionData();
                /*0x7fd594c*/ OptionData(string text);
                /*0x7fd5ae4*/ OptionData(UnityEngine.Sprite image);
                /*0x7fd7fa4*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x7fd7f84*/ string get_text();
                /*0x7fd7f8c*/ void set_text(string value);
                /*0x7fd7f94*/ UnityEngine.Sprite get_image();
                /*0x7fd7f9c*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x7fd52d8*/ OptionDataList();
                /*0x7fd7fe8*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x7fd7ff0*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x7fd5360*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x7fd6fa4*/ <>c__DisplayClass63_0();
                /*0x7fd7ff8*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x7fd7c3c*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x7fd801c*/ void System.IDisposable.Dispose();
                /*0x7fd8020*/ bool MoveNext();
                /*0x7fd80d4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7fd80dc*/ void System.Collections.IEnumerator.Reset();
                /*0x7fd8114*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x7fd811c*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x7fd81ac*/ FontData();
            /*0x7fd81b4*/ UnityEngine.Font get_font();
            /*0x7fd81bc*/ void set_font(UnityEngine.Font value);
            /*0x7fd81c4*/ int get_fontSize();
            /*0x7fd81cc*/ void set_fontSize(int value);
            /*0x7fd81d4*/ UnityEngine.FontStyle get_fontStyle();
            /*0x7fd81dc*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x7fd81e4*/ bool get_bestFit();
            /*0x7fd81ec*/ void set_bestFit(bool value);
            /*0x7fd81f8*/ int get_minSize();
            /*0x7fd8200*/ void set_minSize(int value);
            /*0x7fd8208*/ int get_maxSize();
            /*0x7fd8210*/ void set_maxSize(int value);
            /*0x7fd8218*/ UnityEngine.TextAnchor get_alignment();
            /*0x7fd8220*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x7fd8228*/ bool get_alignByGeometry();
            /*0x7fd8230*/ void set_alignByGeometry(bool value);
            /*0x7fd823c*/ bool get_richText();
            /*0x7fd8244*/ void set_richText(bool value);
            /*0x7fd8250*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x7fd8258*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x7fd8260*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x7fd8268*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x7fd8270*/ float get_lineSpacing();
            /*0x7fd8278*/ void set_lineSpacing(float value);
            /*0x7fd8280*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7fd8284*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x7fd88bc*/ FontUpdateTracker();
            static /*0x7fd82c8*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x7fd8510*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x7fd86b4*/ void UntrackText(UnityEngine.UI.Text t);
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

            static /*0x7fdbfd0*/ Graphic();
            static /*0x7fd8954*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x7fdaee0*/ UnityEngine.Mesh get_workerMesh();
            static /*0x7fdbbc0*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x7fd8f70*/ Graphic();
            /*0x7fd8a40*/ UnityEngine.Color get_color();
            /*0x7fd8a4c*/ void set_color(UnityEngine.Color value);
            /*0x7fd8a84*/ bool get_raycastTarget();
            /*0x7fd8a8c*/ void set_raycastTarget(bool value);
            /*0x7fd8f44*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x7fd8f50*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x7fd8f5c*/ bool get_useLegacyMeshGeneration();
            /*0x7fd8f64*/ void set_useLegacyMeshGeneration(bool value);
            /*0x7fd903c*/ void SetAllDirty();
            /*0x7fd9184*/ void SetLayoutDirty();
            /*0x7fd9290*/ void SetVerticesDirty();
            /*0x7fd9324*/ void SetMaterialDirty();
            /*0x7fd90ac*/ void SetRaycastDirty();
            /*0x7fd93b8*/ void OnRectTransformDimensionsChange();
            /*0x7fd9464*/ void OnBeforeTransformParentChanged();
            /*0x7fd96b0*/ void OnTransformParentChanged();
            /*0x7fd9af4*/ int get_depth();
            /*0x7fd9224*/ UnityEngine.RectTransform get_rectTransform();
            /*0x7fd8b68*/ UnityEngine.Canvas get_canvas();
            /*0x7fd9770*/ void CacheCanvas();
            /*0x7fd9b10*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x7fd9bc4*/ UnityEngine.Material get_defaultMaterial();
            /*0x7fd9c10*/ UnityEngine.Material get_material();
            /*0x7fd9c98*/ void set_material(UnityEngine.Material value);
            /*0x7fd9d40*/ UnityEngine.Material get_materialForRendering();
            /*0x7fd9f04*/ UnityEngine.Texture get_mainTexture();
            /*0x7fd9f5c*/ void OnEnable();
            /*0x7fda094*/ void OnDisable();
            /*0x7fda35c*/ void OnDestroy();
            /*0x7fda470*/ void OnCanvasHierarchyChanged();
            /*0x7fda5b4*/ void OnCullingChanged();
            /*0x7fda640*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x7fda724*/ void LayoutComplete();
            /*0x7fda728*/ void GraphicUpdateComplete();
            /*0x7fda72c*/ void UpdateMaterial();
            /*0x7fda7e4*/ void UpdateGeometry();
            /*0x7fdab50*/ void DoMeshGeneration();
            /*0x7fda7f4*/ void DoLegacyMeshGeneration();
            /*0x7fdb010*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x7fdb014*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x7fdb0ac*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x7fdb334*/ void OnDidApplyAnimationProperties();
            /*0x7fdb344*/ void SetNativeSize();
            /*0x7fdb348*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x7fdb7d4*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x7fdb208*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x7fdb914*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x7fdb930*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x7fdbbd4*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x7fdbc70*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x7fdbd00*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x7fdbd90*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x7fdbe20*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x7fdbeb0*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x7fdbf40*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x7fdc074*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
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

            static /*0x7fdd5e0*/ GraphicRaycaster();
            static /*0x7fdcf98*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x7fdc1f4*/ GraphicRaycaster();
            /*0x7fdc07c*/ int get_sortOrderPriority();
            /*0x7fdc16c*/ int get_renderOrderPriority();
            /*0x7fdc1c0*/ bool get_ignoreReversedGraphics();
            /*0x7fdc1c8*/ void set_ignoreReversedGraphics(bool value);
            /*0x7fdc1d4*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0x7fdc1dc*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0x7fdc1e4*/ UnityEngine.LayerMask get_blockingMask();
            /*0x7fdc1ec*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x7fdc0c4*/ UnityEngine.Canvas get_canvas();
            /*0x7fdc294*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x7fdd518*/ UnityEngine.Camera get_eventCamera();

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

                static /*0x7fdd678*/ <>c();
                /*0x7fdd6e0*/ <>c();
                /*0x7fdd6e8*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x7fddbe0*/ GraphicRegistry();
            static /*0x7fdd8f4*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x7fd9908*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fd8d58*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fd950c*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fd8bdc*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fda1dc*/ void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fdd9a4*/ void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x7fddb24*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x7fdcedc*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x7fdd734*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            /*0x38159dc*/ void OnSiblingGraphicEnabledDisabled();
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

            static /*0x7fe28ec*/ Image();
            static /*0x7fde46c*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x7fe1934*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x7fe17e0*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x7fe1a18*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x7fe1b38*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x7fe270c*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x7fe12b4*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x7fe14a4*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x7fde42c*/ Image();
            /*0x7fddc70*/ UnityEngine.Sprite get_sprite();
            /*0x7fd0c68*/ void set_sprite(UnityEngine.Sprite value);
            /*0x7fdddf4*/ void DisableSpriteOptimizations();
            /*0x7fdddfc*/ UnityEngine.Sprite get_overrideSprite();
            /*0x7fdde78*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x7fdde00*/ UnityEngine.Sprite get_activeSprite();
            /*0x7fddf00*/ UnityEngine.UI.Image.Type get_type();
            /*0x7fd0f30*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x7fddf08*/ bool get_preserveAspect();
            /*0x7fddf10*/ void set_preserveAspect(bool value);
            /*0x7fddf90*/ bool get_fillCenter();
            /*0x7fddf98*/ void set_fillCenter(bool value);
            /*0x7fde018*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x7fde020*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x7fde098*/ float get_fillAmount();
            /*0x7fde0a0*/ void set_fillAmount(float value);
            /*0x7fde130*/ bool get_fillClockwise();
            /*0x7fde138*/ void set_fillClockwise(bool value);
            /*0x7fde1b8*/ int get_fillOrigin();
            /*0x7fde1c0*/ void set_fillOrigin(int value);
            /*0x7fde240*/ float get_eventAlphaThreshold();
            /*0x7fde250*/ void set_eventAlphaThreshold(float value);
            /*0x7fde39c*/ float get_alphaHitTestMinimumThreshold();
            /*0x7fde25c*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0x7fde3a4*/ bool get_useSpriteMesh();
            /*0x7fde3ac*/ void set_useSpriteMesh(bool value);
            /*0x7fde558*/ UnityEngine.Texture get_mainTexture();
            /*0x7fde6d0*/ bool get_hasBorder();
            /*0x7fde788*/ float get_pixelsPerUnitMultiplier();
            /*0x7fde790*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x7fde7b0*/ float get_pixelsPerUnit();
            /*0x7fde8a4*/ float get_multipliedPixelsPerUnit();
            /*0x7fde8c0*/ UnityEngine.Material get_material();
            /*0x7fde9ec*/ void set_material(UnityEngine.Material value);
            /*0x7fde9f0*/ void OnBeforeSerialize();
            /*0x7fde9f4*/ void OnAfterDeserialize();
            /*0x7fdea44*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x7fdead8*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x7fdee88*/ void SetNativeSize();
            /*0x7fdefc8*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x7fddd08*/ void TrackSprite();
            /*0x7fe1414*/ void OnEnable();
            /*0x7fe1430*/ void OnDisable();
            /*0x7fe1524*/ void UpdateMaterial();
            /*0x7fe1618*/ void OnCanvasHierarchyChanged();
            /*0x7fdf10c*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x7fdf3d0*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x7fdf6b4*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x7fdfc74*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x7fe1720*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x7fe09cc*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x7fe1f64*/ void CalculateLayoutInputHorizontal();
            /*0x7fe1f68*/ void CalculateLayoutInputVertical();
            /*0x7fe1f6c*/ float get_minWidth();
            /*0x7fe1f74*/ float get_preferredWidth();
            /*0x7fe203c*/ float get_flexibleWidth();
            /*0x7fe2044*/ float get_minHeight();
            /*0x7fe204c*/ float get_preferredHeight();
            /*0x7fe2114*/ float get_flexibleHeight();
            /*0x7fe211c*/ int get_layoutPriority();
            /*0x7fe2124*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x7fe24b4*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x7fe28b4*/ void OnDidApplyAnimationProperties();
            /*0x7fddc78*/ void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0();
            /*0x7fe2a58*/ bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1();

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
            /*0x3813ffc*/ bool Enabled();
            /*0x38148bc*/ UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            /*0x38159dc*/ void RecalculateMasking();
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

            static /*0x81aed58*/ InputField();
            static /*0x81a7e1c*/ string get_clipboard();
            static /*0x81a7e6c*/ void set_clipboard(string value);
            static /*0x81ad020*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x81aa0d8*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x81a5674*/ InputField();
            /*0x81a54d0*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x81a55e0*/ string get_compositionString();
            /*0x81a59ac*/ UnityEngine.Mesh get_mesh();
            /*0x81a5a54*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x81a5ac8*/ void set_shouldHideMobileInput(bool value);
            /*0x81a5b20*/ bool get_shouldHideMobileInput();
            /*0x81a5ba8*/ void set_shouldActivateOnSelect(bool value);
            /*0x81a5bb4*/ bool get_shouldActivateOnSelect();
            /*0x81a5c24*/ string get_text();
            /*0x81a5c2c*/ void set_text(string value);
            /*0x81a5f60*/ void SetTextWithoutNotify(string input);
            /*0x81a5c34*/ void SetText(string value, bool sendCallback);
            /*0x81a64b8*/ bool get_isFocused();
            /*0x81a64c0*/ float get_caretBlinkRate();
            /*0x81a64c8*/ void set_caretBlinkRate(float value);
            /*0x81a65b4*/ int get_caretWidth();
            /*0x81a65bc*/ void set_caretWidth(int value);
            /*0x81a6688*/ UnityEngine.UI.Text get_textComponent();
            /*0x81a6690*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x81a6910*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x81a6918*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x81a6970*/ UnityEngine.Color get_caretColor();
            /*0x81a69b4*/ void set_caretColor(UnityEngine.Color value);
            /*0x81a69e0*/ bool get_customCaretColor();
            /*0x81a69e8*/ void set_customCaretColor(bool value);
            /*0x81a6a04*/ UnityEngine.Color get_selectionColor();
            /*0x81a6a18*/ void set_selectionColor(UnityEngine.Color value);
            /*0x81a6a44*/ UnityEngine.UI.InputField.EndEditEvent get_onEndEdit();
            /*0x81a6a4c*/ void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value);
            /*0x81a6aa4*/ UnityEngine.UI.InputField.SubmitEvent get_onSubmit();
            /*0x81a6aac*/ void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x81a6b04*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x81a6b0c*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x81a6b68*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x81a6b10*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x81a6b70*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x81a6b78*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x81a6bd0*/ int get_characterLimit();
            /*0x81a6bd8*/ void set_characterLimit(int value);
            /*0x81a6c98*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x81a6ca0*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x81a6dd0*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x81a6dd8*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x81a6efc*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x81a6f04*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x81a6fa0*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x81a6fa8*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x81a6fb0*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x81a7034*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x81a703c*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x81a70c0*/ bool get_readOnly();
            /*0x81a70c8*/ void set_readOnly(bool value);
            /*0x81a70d4*/ bool get_multiLine();
            /*0x81a70e8*/ char get_asteriskChar();
            /*0x81a70f0*/ void set_asteriskChar(char value);
            /*0x81a7164*/ bool get_wasCanceled();
            /*0x81a716c*/ void ClampPos(ref int pos);
            /*0x81a71a4*/ int get_caretPositionInternal();
            /*0x81a71c8*/ void set_caretPositionInternal(int value);
            /*0x81a7200*/ int get_caretSelectPositionInternal();
            /*0x81a7224*/ void set_caretSelectPositionInternal(int value);
            /*0x81a725c*/ bool get_hasSelection();
            /*0x81a728c*/ int get_caretPosition();
            /*0x81a72b0*/ void set_caretPosition(int value);
            /*0x81a7390*/ int get_selectionAnchorPosition();
            /*0x81a72d8*/ void set_selectionAnchorPosition(int value);
            /*0x81a73b4*/ int get_selectionFocusPosition();
            /*0x81a7334*/ void set_selectionFocusPosition(int value);
            /*0x81a73d8*/ void Awake();
            /*0x81a7498*/ void OnEnable();
            /*0x81a76f8*/ void OnDisable();
            /*0x81a7ac8*/ void OnDestroy();
            /*0x81a7b2c*/ System.Collections.IEnumerator CaretBlink();
            /*0x81a7bc0*/ void SetCaretVisible();
            /*0x81a6544*/ void SetCaretActive();
            /*0x81a7bf8*/ void UpdateCaretMaterial();
            /*0x81a7d08*/ void OnFocus();
            /*0x81a7d0c*/ void SelectAll();
            /*0x81a7d40*/ void MoveTextEnd(bool shift);
            /*0x81a7da0*/ void MoveTextStart(bool shift);
            /*0x81a7ec4*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x81a7f7c*/ bool InPlaceEditing();
            /*0x81a7fac*/ bool InPlaceEditingChanged();
            /*0x81a802c*/ UnityEngine.RangeInt GetInternalSelection();
            /*0x81a80e0*/ void UpdateKeyboardCaret();
            /*0x81a81a8*/ void UpdateCaretFromKeyboard();
            /*0x81a8290*/ void LateUpdate();
            /*0x81a989c*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x81a9c34*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x81a9e44*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x81aa23c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81aa314*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81aa334*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81aa538*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81aa5e8*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81aa604*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81aa7f4*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x81ab2d8*/ bool IsValidChar(char c);
            /*0x81ab348*/ void ProcessEvent(UnityEngine.Event e);
            /*0x81ab34c*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81aada4*/ string GetSelectedString();
            /*0x81ab4d4*/ int FindtNextWordBegin();
            /*0x81ab194*/ void MoveRight(bool shift, bool ctrl);
            /*0x81ab590*/ int FindtPrevWordBegin();
            /*0x81ab068*/ void MoveLeft(bool shift, bool ctrl);
            /*0x81ab630*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x81ab740*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x81aba98*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x81ab2cc*/ void MoveDown(bool shift);
            /*0x81abd4c*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x81ab2c0*/ void MoveUp(bool shift);
            /*0x81abe70*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x81aae4c*/ void Delete();
            /*0x81aacf0*/ void ForwardSpace();
            /*0x81aabdc*/ void Backspace();
            /*0x81abfc8*/ void Insert(char c);
            /*0x81ab020*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x81a9884*/ void SendOnValueChangedAndUpdateLabel();
            /*0x81a601c*/ void SendOnValueChanged();
            /*0x81ac0d8*/ void SendOnEndEdit();
            /*0x81a910c*/ void SendOnSubmit();
            /*0x81ac158*/ void Append(string input);
            /*0x81ac214*/ void Append(char input);
            /*0x81a609c*/ void UpdateLabel();
            /*0x81acfb4*/ bool IsSelectionVisible();
            /*0x81ac478*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x81ad170*/ void ForceLabelUpdate();
            /*0x81a6630*/ void MarkGeometryAsDirty();
            /*0x81ad174*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x81ad5d8*/ void LayoutComplete();
            /*0x81ad5dc*/ void GraphicUpdateComplete();
            /*0x81ad184*/ void UpdateGeometry();
            /*0x81a8c0c*/ void AssignPositioningIfNeeded();
            /*0x81ad5e0*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x81ad868*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x81ae704*/ void CreateCursorVerts();
            /*0x81adf80*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x81a918c*/ char Validate(string text, int pos, char ch);
            /*0x81ae864*/ void ActivateInputField();
            /*0x81a88cc*/ void ActivateInputFieldInternal();
            /*0x81ae984*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81ae9c0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81a793c*/ void DeactivateInputField();
            /*0x81ae9e4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81aea10*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81a6d14*/ void EnforceContentType();
            /*0x81a5918*/ void EnforceTextHOverflow();
            /*0x81a6e98*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x81a6f88*/ void SetToCustom();
            /*0x81aea58*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x81aea84*/ void CalculateLayoutInputHorizontal();
            /*0x81aea88*/ void CalculateLayoutInputVertical();
            /*0x81aea8c*/ float get_minWidth();
            /*0x81aea94*/ float get_preferredWidth();
            /*0x81aebf0*/ float get_flexibleWidth();
            /*0x81aebf8*/ float get_minHeight();
            /*0x81aec00*/ float get_preferredHeight();
            /*0x81aed48*/ float get_flexibleHeight();
            /*0x81aed50*/ int get_layoutPriority();
            /*0x81aee08*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x81a5f68*/ OnValidateInput(object object, nint method);
                /*0x81aee10*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x81aee24*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x81aeea8*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x81a5840*/ SubmitEvent();
            }

            class EndEditEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x81a5888*/ EndEditEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x81a58d0*/ OnChangeEvent();
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

                /*0x81a7b98*/ <CaretBlink>d__172(int <>1__state);
                /*0x81aeed0*/ void System.IDisposable.Dispose();
                /*0x81aeed4*/ bool MoveNext();
                /*0x81aeff8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x81af000*/ void System.Collections.IEnumerator.Reset();
                /*0x81af038*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__196 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x81aa5c0*/ <MouseDragOutsideRect>d__196(int <>1__state);
                /*0x81af040*/ void System.IDisposable.Dispose();
                /*0x81af044*/ bool MoveNext();
                /*0x81af2cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x81af2d4*/ void System.Collections.IEnumerator.Reset();
                /*0x81af30c*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x81af4b8*/ AspectRatioFitter();
            /*0x81af314*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x81af31c*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x81af394*/ float get_aspectRatio();
            /*0x81af39c*/ void set_aspectRatio(float value);
            /*0x81af410*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81af4c8*/ void OnEnable();
            /*0x81af560*/ void Start();
            /*0x81af6a4*/ void OnDisable();
            /*0x81afb14*/ void OnTransformParentChanged();
            /*0x81afbac*/ void Update();
            /*0x81afbc0*/ void OnRectTransformDimensionsChange();
            /*0x81afbc4*/ void UpdateRect();
            /*0x81affa8*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x81afeb0*/ UnityEngine.Vector2 GetParentSize();
            /*0x81b009c*/ void SetLayoutHorizontal();
            /*0x81b00a0*/ void SetLayoutVertical();
            /*0x81af390*/ void SetDirty();
            /*0x81af5b0*/ bool IsComponentValidOnObject();
            /*0x81af67c*/ bool IsAspectModeValid();
            /*0x81b00a4*/ bool DoesParentExists();

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

            /*0x81b01bc*/ CanvasScaler();
            /*0x81b00ac*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x81b00b4*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x81b00bc*/ float get_referencePixelsPerUnit();
            /*0x81b00c4*/ void set_referencePixelsPerUnit(float value);
            /*0x81b00cc*/ float get_scaleFactor();
            /*0x81b00d4*/ void set_scaleFactor(float value);
            /*0x81b00e8*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x81b00f0*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x81b0154*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x81b015c*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x81b0164*/ float get_matchWidthOrHeight();
            /*0x81b016c*/ void set_matchWidthOrHeight(float value);
            /*0x81b0174*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x81b017c*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0x81b0184*/ float get_fallbackScreenDPI();
            /*0x81b018c*/ void set_fallbackScreenDPI(float value);
            /*0x81b0194*/ float get_defaultSpriteDPI();
            /*0x81b019c*/ void set_defaultSpriteDPI(float value);
            /*0x81b01ac*/ float get_dynamicPixelsPerUnit();
            /*0x81b01b4*/ void set_dynamicPixelsPerUnit(float value);
            /*0x81b0204*/ void OnEnable();
            /*0x81b02d4*/ void Canvas_preWillRenderCanvases();
            /*0x81b02e4*/ void OnDisable();
            /*0x81b040c*/ void Handle();
            /*0x81b0508*/ void HandleWorldCanvas();
            /*0x81b0528*/ void HandleConstantPixelSize();
            /*0x81b0548*/ void HandleScaleWithScreenSize();
            /*0x81b077c*/ void HandleConstantPhysicalSize();
            /*0x81b038c*/ void SetScaleFactor(float scaleFactor);
            /*0x81b03cc*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

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

            /*0x81b0a08*/ ContentSizeFitter();
            /*0x81b07e4*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x81b07ec*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x81b08e4*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x81b08ec*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x81b0960*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81b0a10*/ void OnEnable();
            /*0x81b0a2c*/ void OnDisable();
            /*0x81b0aa8*/ void OnRectTransformDimensionsChange();
            /*0x81b0aac*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x81b0ba8*/ void SetLayoutHorizontal();
            /*0x81b0bcc*/ void SetLayoutVertical();
            /*0x81b0860*/ void SetDirty();

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

            /*0x81b0e40*/ GridLayoutGroup();
            /*0x81b0bd4*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x81b0bdc*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x81b0c38*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x81b0c40*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x81b0c9c*/ UnityEngine.Vector2 get_cellSize();
            /*0x81b0ca4*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x81b0d08*/ UnityEngine.Vector2 get_spacing();
            /*0x81b0d10*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x81b0d74*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x81b0d7c*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x81b0dd8*/ int get_constraintCount();
            /*0x81b0de0*/ void set_constraintCount(int value);
            /*0x81b1004*/ void CalculateLayoutInputHorizontal();
            /*0x81b1608*/ void CalculateLayoutInputVertical();
            /*0x81b18b8*/ void SetLayoutHorizontal();
            /*0x81b204c*/ void SetLayoutVertical();
            /*0x81b18c0*/ void SetCellsAlongAxis(int axis);

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
            /*0x81b224c*/ HorizontalLayoutGroup();
            /*0x81b2264*/ void CalculateLayoutInputHorizontal();
            /*0x81b2524*/ void CalculateLayoutInputVertical();
            /*0x81b2530*/ void SetLayoutHorizontal();
            /*0x81b2b8c*/ void SetLayoutVertical();
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

            /*0x81b2258*/ HorizontalOrVerticalLayoutGroup();
            /*0x81b2b98*/ float get_spacing();
            /*0x81b2ba0*/ void set_spacing(float value);
            /*0x81b2bfc*/ bool get_childForceExpandWidth();
            /*0x81b2c04*/ void set_childForceExpandWidth(bool value);
            /*0x81b2c60*/ bool get_childForceExpandHeight();
            /*0x81b2c68*/ void set_childForceExpandHeight(bool value);
            /*0x81b2cc4*/ bool get_childControlWidth();
            /*0x81b2ccc*/ void set_childControlWidth(bool value);
            /*0x81b2d28*/ bool get_childControlHeight();
            /*0x81b2d30*/ void set_childControlHeight(bool value);
            /*0x81b2d8c*/ bool get_childScaleWidth();
            /*0x81b2d94*/ void set_childScaleWidth(bool value);
            /*0x81b2df0*/ bool get_childScaleHeight();
            /*0x81b2df8*/ void set_childScaleHeight(bool value);
            /*0x81b2e54*/ bool get_reverseArrangement();
            /*0x81b2e5c*/ void set_reverseArrangement(bool value);
            /*0x81b2284*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x81b253c*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x81b2eb8*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
        }

        interface ILayoutElement
        {
            /*0x38159dc*/ void CalculateLayoutInputHorizontal();
            /*0x38159dc*/ void CalculateLayoutInputVertical();
            /*0x38151b8*/ float get_minWidth();
            /*0x38151b8*/ float get_preferredWidth();
            /*0x38151b8*/ float get_flexibleWidth();
            /*0x38151b8*/ float get_minHeight();
            /*0x38151b8*/ float get_preferredHeight();
            /*0x38151b8*/ float get_flexibleHeight();
            /*0x3814574*/ int get_layoutPriority();
        }

        interface ILayoutController
        {
            /*0x38159dc*/ void SetLayoutHorizontal();
            /*0x38159dc*/ void SetLayoutVertical();
        }

        interface ILayoutGroup : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutSelfController : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutIgnorer
        {
            /*0x3813ffc*/ bool get_ignoreLayout();
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

            /*0x81b3ab4*/ LayoutElement();
            /*0x81b3614*/ bool get_ignoreLayout();
            /*0x81b361c*/ void set_ignoreLayout(bool value);
            /*0x81b3748*/ void CalculateLayoutInputHorizontal();
            /*0x81b374c*/ void CalculateLayoutInputVertical();
            /*0x81b3750*/ float get_minWidth();
            /*0x81b3758*/ void set_minWidth(float value);
            /*0x81b37cc*/ float get_minHeight();
            /*0x81b37d4*/ void set_minHeight(float value);
            /*0x81b3848*/ float get_preferredWidth();
            /*0x81b3850*/ void set_preferredWidth(float value);
            /*0x81b38c4*/ float get_preferredHeight();
            /*0x81b38cc*/ void set_preferredHeight(float value);
            /*0x81b3940*/ float get_flexibleWidth();
            /*0x81b3948*/ void set_flexibleWidth(float value);
            /*0x81b39bc*/ float get_flexibleHeight();
            /*0x81b39c4*/ void set_flexibleHeight(float value);
            /*0x81b3a38*/ int get_layoutPriority();
            /*0x81b3a40*/ void set_layoutPriority(int value);
            /*0x81b3ad4*/ void OnEnable();
            /*0x81b3af0*/ void OnTransformParentChanged();
            /*0x81b3af4*/ void OnDisable();
            /*0x81b3b10*/ void OnDidApplyAnimationProperties();
            /*0x81b3b14*/ void OnBeforeTransformParentChanged();
            /*0x81b3690*/ void SetDirty();
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

            /*0x81b0ea8*/ LayoutGroup();
            /*0x81b3b18*/ UnityEngine.RectOffset get_padding();
            /*0x81b3b20*/ void set_padding(UnityEngine.RectOffset value);
            /*0x81b3b7c*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x81b3b84*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x81b1810*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81b3be0*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x81b11d0*/ void CalculateLayoutInputHorizontal();
            /*0x38159dc*/ void CalculateLayoutInputVertical();
            /*0x81b3be8*/ float get_minWidth();
            /*0x81b3bf0*/ float get_preferredWidth();
            /*0x81b3bf8*/ float get_flexibleWidth();
            /*0x81b3c00*/ float get_minHeight();
            /*0x81b3c08*/ float get_preferredHeight();
            /*0x81b3c10*/ float get_flexibleHeight();
            /*0x81b3c18*/ int get_layoutPriority();
            /*0x38159dc*/ void SetLayoutHorizontal();
            /*0x38159dc*/ void SetLayoutVertical();
            /*0x81b3c20*/ void OnEnable();
            /*0x81b3d10*/ void OnDisable();
            /*0x81b3d8c*/ void OnDidApplyAnimationProperties();
            /*0x81b3598*/ float GetTotalMinSize(int axis);
            /*0x81b34b8*/ float GetTotalPreferredSize(int axis);
            /*0x81b3528*/ float GetTotalFlexibleSize(int axis);
            /*0x81b2054*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x81b2fcc*/ float GetAlignmentOnAxis(int axis);
            /*0x81b1588*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x81b3d90*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x81b328c*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x81b219c*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x81b3018*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x81b3e38*/ bool get_isRootLayoutGroup();
            /*0x81b3f64*/ void OnRectTransformDimensionsChange();
            /*0x81b3f94*/ void OnTransformChildrenChanged();
            /*0x3910ae8*/ void SetProperty<T>(ref T currentValue, T newValue);
            /*0x81b3c3c*/ void SetDirty();
            /*0x81b3f98*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x81b4004*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x81b402c*/ void System.IDisposable.Dispose();
                /*0x81b4030*/ bool MoveNext();
                /*0x81b40cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x81b40d4*/ void System.Collections.IEnumerator.Reset();
                /*0x81b410c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x81b4178*/ LayoutRebuilder();
            static /*0x81b4364*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x81b4420*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x81b4520*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x81af720*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x81b4f34*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x81b511c*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x81b53a8*/ LayoutRebuilder();
            /*0x81b4114*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x81b4154*/ void Clear();
            /*0x81b43b8*/ UnityEngine.Transform get_transform();
            /*0x81b43c0*/ bool IsDestroyed();
            /*0x81b45e8*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81b4b78*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x81b48b4*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x81b5260*/ void LayoutComplete();
            /*0x81b52e0*/ void GraphicUpdateComplete();
            /*0x81b52e4*/ int GetHashCode();
            /*0x81b52ec*/ bool Equals(object obj);
            /*0x81b533c*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x81b53b0*/ <>c();
                /*0x81b5418*/ <>c();
                /*0x81b5420*/ UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0();
                /*0x81b5474*/ void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x);
                /*0x81b54a0*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x81b552c*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x81b55e8*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x81b56a4*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x81b5764*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x81b0b90*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x81b0b9c*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x81b3608*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x81b5914*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x81b5bac*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x81b5e44*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x81b5824*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x81b5a04*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x81b5d54*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x81b5f34*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x81b5f4c*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

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

                static /*0x81b6274*/ <>c();
                /*0x81b62dc*/ <>c();
                /*0x81b62e4*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x81b6384*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x81b6424*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x81b64c4*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x81b6564*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x81b6604*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x81b66a4*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x81b6744*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x81b67e4*/ VerticalLayoutGroup();
            /*0x81b67f0*/ void CalculateLayoutInputHorizontal();
            /*0x81b6810*/ void CalculateLayoutInputVertical();
            /*0x81b681c*/ void SetLayoutHorizontal();
            /*0x81b6828*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x20*/ UnityEngine.RectTransform m_RectTransform;
            /*0x28*/ bool m_ShowMaskGraphic;
            /*0x30*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x38*/ UnityEngine.Material m_MaskMaterial;
            /*0x40*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x81b69cc*/ Mask();
            /*0x81b6834*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81b68a4*/ bool get_showMaskGraphic();
            /*0x81b68ac*/ void set_showMaskGraphic(bool value);
            /*0x81b695c*/ UnityEngine.UI.Graphic get_graphic();
            /*0x81b69dc*/ bool MaskEnabled();
            /*0x81b6a6c*/ void OnSiblingGraphicEnabledDisabled();
            /*0x81b6a70*/ void OnEnable();
            /*0x81b6e40*/ void OnDisable();
            /*0x81b7024*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x81b70d0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
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

            /*0x81b84fc*/ MaskableGraphic();
            /*0x81b77c4*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x81b77cc*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x81b77d4*/ bool get_maskable();
            /*0x81b77dc*/ void set_maskable(bool value);
            /*0x81b780c*/ bool get_isMaskingGraphic();
            /*0x81b6bd0*/ void set_isMaskingGraphic(bool value);
            /*0x81b7814*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x81b7924*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x81b7bac*/ void UpdateCull(bool cull);
            /*0x81b7c90*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x81b7cfc*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x81b7d34*/ void OnEnable();
            /*0x81b7ee4*/ void OnDisable();
            /*0x81b7fac*/ void OnTransformParentChanged();
            /*0x81b7ffc*/ void ParentMaskStateChanged();
            /*0x81b8000*/ void OnCanvasHierarchyChanged();
            /*0x81b79f4*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x81b7d84*/ void UpdateClipParent();
            /*0x81b8464*/ void RecalculateClipping();
            /*0x81b8468*/ void RecalculateMasking();
            /*0x81b8618*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x81b85d0*/ CullStateChangedEvent();
            }
        }

        class MaskUtilities
        {
            static /*0x81b8620*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x81b6be8*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x81b739c*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x81b753c*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x81b887c*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x81b8050*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x81b89d4*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x81b8d38*/ MaskUtilities();
        }

        interface IMaterialModifier
        {
            /*0x3814a3c*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x81b8d40*/ void Destroy(UnityEngine.Object obj);
            static /*0x81b8e64*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x81b8f30*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x81b9408*/ UnityEngine.Vector3 GetRelativeMousePositionForRaycast(UnityEngine.EventSystems.PointerEventData eventData);
            static /*0x81b8f9c*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position, int displayIndex);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x81b9540*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0x81b94dc*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0x81b94e4*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0x81b94ec*/ bool get_wrapAround();
            /*0x81b94f4*/ void set_wrapAround(bool value);
            /*0x81b9500*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0x81b9508*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0x81b9510*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0x81b9518*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0x81b9520*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0x81b9528*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0x81b9530*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0x81b9538*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0x81b9560*/ bool Equals(UnityEngine.UI.Navigation other);

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

            /*0x81b9678*/ RawImage();
            /*0x81b96a0*/ UnityEngine.Texture get_mainTexture();
            /*0x81b97f8*/ UnityEngine.Texture get_texture();
            /*0x81b9800*/ void set_texture(UnityEngine.Texture value);
            /*0x81b98bc*/ UnityEngine.Rect get_uvRect();
            /*0x81b98c8*/ void set_uvRect(UnityEngine.Rect value);
            /*0x81b9914*/ void SetNativeSize();
            /*0x81b9bc8*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x81ba24c*/ void OnDidApplyAnimationProperties();
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

            /*0x81ba4f8*/ RectMask2D();
            /*0x81ba288*/ UnityEngine.Vector4 get_padding();
            /*0x81ba294*/ void set_padding(UnityEngine.Vector4 value);
            /*0x81ba2a4*/ UnityEngine.Vector2Int get_softness();
            /*0x81ba2ac*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x81ba2c4*/ UnityEngine.Canvas get_Canvas();
            /*0x81ba444*/ UnityEngine.Rect get_canvasRect();
            /*0x81ba488*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81ba698*/ void OnEnable();
            /*0x81ba6cc*/ void OnDisable();
            /*0x81ba79c*/ void OnDestroy();
            /*0x81ba7bc*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x81ba898*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x81ba994*/ void PerformClipping();
            /*0x81bb1b4*/ void UpdateClipSoftness();
            /*0x81bb4ac*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x81bb5c0*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x81bb760*/ void OnTransformParentChanged();
            /*0x81bb790*/ void OnCanvasHierarchyChanged();
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

            /*0x81bbb68*/ Scrollbar();
            /*0x81bb7c0*/ UnityEngine.RectTransform get_handleRect();
            /*0x81bb7c8*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x81bbaec*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x81bbaf4*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x81bbdbc*/ float get_value();
            /*0x81bbe74*/ void set_value(float value);
            /*0x81bbf40*/ void SetValueWithoutNotify(float input);
            /*0x81bbf48*/ float get_size();
            /*0x81bbf50*/ void set_size(float value);
            /*0x81bbfd4*/ int get_numberOfSteps();
            /*0x81bbfdc*/ void set_numberOfSteps(int value);
            /*0x81bc060*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x81bc068*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x81bc078*/ float get_stepSize();
            /*0x81bc0a4*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81bc0a8*/ void LayoutComplete();
            /*0x81bc0ac*/ void GraphicUpdateComplete();
            /*0x81bc0b0*/ void OnEnable();
            /*0x81bc3b0*/ void OnDisable();
            /*0x81bc508*/ void Update();
            /*0x81bb844*/ void UpdateCachedReferences();
            /*0x81bbe7c*/ void Set(float input, bool sendCallback);
            /*0x81bc51c*/ void OnRectTransformDimensionsChange();
            /*0x81bc554*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x81bc564*/ bool get_reverseValue();
            /*0x81bb934*/ void UpdateVisuals();
            /*0x81bc578*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bc67c*/ void UpdateDrag(UnityEngine.RectTransform containerRect, UnityEngine.Vector2 position, UnityEngine.Camera camera);
            /*0x81bc7f4*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x81bc85c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bc8c0*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bca74*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bcb04*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bcd68*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bcccc*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x81bcdd0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bce10*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81bd0e4*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x81bd1e0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x81bd2dc*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x81bd3d8*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x81bd4d4*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bd4ec*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x81bd674*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x81bbc34*/ ScrollEvent();
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

                /*0x81bcda8*/ <ClickRepeat>d__59(int <>1__state);
                /*0x81bd67c*/ void System.IDisposable.Dispose();
                /*0x81bd680*/ bool MoveNext();
                /*0x81bd79c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x81bd7a4*/ void System.Collections.IEnumerator.Reset();
                /*0x81bd7dc*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x81bf4c0*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x81c0b5c*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x81c0c60*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x81c0cdc*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x81c0e6c*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x81bdf34*/ ScrollRect();
            /*0x81bd7e4*/ UnityEngine.RectTransform get_content();
            /*0x81bd7ec*/ void set_content(UnityEngine.RectTransform value);
            /*0x81bd7f4*/ bool get_horizontal();
            /*0x81bd7fc*/ void set_horizontal(bool value);
            /*0x81bd808*/ bool get_vertical();
            /*0x81bd810*/ void set_vertical(bool value);
            /*0x81bd81c*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0x81bd824*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x81bd82c*/ float get_elasticity();
            /*0x81bd834*/ void set_elasticity(float value);
            /*0x81bd83c*/ bool get_inertia();
            /*0x81bd844*/ void set_inertia(bool value);
            /*0x81bd850*/ float get_decelerationRate();
            /*0x81bd858*/ void set_decelerationRate(float value);
            /*0x81bd860*/ float get_scrollSensitivity();
            /*0x81bd868*/ void set_scrollSensitivity(float value);
            /*0x81bd870*/ UnityEngine.RectTransform get_viewport();
            /*0x81bd878*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x81bd95c*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x81bd964*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x81bdafc*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x81bdb04*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x81bdc9c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x81bdca4*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x81bdcac*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x81bdcb4*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x81bdcbc*/ float get_horizontalScrollbarSpacing();
            /*0x81bdcc4*/ void set_horizontalScrollbarSpacing(float value);
            /*0x81bdd54*/ float get_verticalScrollbarSpacing();
            /*0x81bdd5c*/ void set_verticalScrollbarSpacing(float value);
            /*0x81bdd64*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0x81bdd6c*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x81bdd74*/ UnityEngine.RectTransform get_viewRect();
            /*0x81bde84*/ UnityEngine.Vector2 get_velocity();
            /*0x81bde8c*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x81bde94*/ UnityEngine.RectTransform get_rectTransform();
            /*0x81be094*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81bea44*/ void LayoutComplete();
            /*0x81bea48*/ void GraphicUpdateComplete();
            /*0x81be11c*/ void UpdateCachedData();
            /*0x81bea4c*/ void OnEnable();
            /*0x81bec08*/ void OnDisable();
            /*0x81bee38*/ bool IsActive();
            /*0x81beeb8*/ void EnsureLayoutHasRebuilt();
            /*0x81bef2c*/ void StopMovement();
            /*0x81bef7c*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x81bf118*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bf178*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bf2a4*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bf2c4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bf4f8*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x81bf5ac*/ void LateUpdate();
            /*0x81be96c*/ void UpdatePrevData();
            /*0x81be7ec*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x81bfb84*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x81bfdf4*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x81bfbf4*/ float get_horizontalNormalizedPosition();
            /*0x81bfe3c*/ void set_horizontalNormalizedPosition(float value);
            /*0x81bfcf4*/ float get_verticalNormalizedPosition();
            /*0x81bfe50*/ void set_verticalNormalizedPosition(float value);
            /*0x81bfe64*/ void SetHorizontalNormalizedPosition(float value);
            /*0x81bfe78*/ void SetVerticalNormalizedPosition(float value);
            /*0x81bfe8c*/ void SetNormalizedPosition(float value, int axis);
            /*0x81c0124*/ void OnRectTransformDimensionsChange();
            /*0x81c0128*/ bool get_hScrollingNeeded();
            /*0x81c01b0*/ bool get_vScrollingNeeded();
            /*0x81c0238*/ void CalculateLayoutInputHorizontal();
            /*0x81c023c*/ void CalculateLayoutInputVertical();
            /*0x81c0240*/ float get_minWidth();
            /*0x81c0248*/ float get_preferredWidth();
            /*0x81c0250*/ float get_flexibleWidth();
            /*0x81c0258*/ float get_minHeight();
            /*0x81c0260*/ float get_preferredHeight();
            /*0x81c0268*/ float get_flexibleHeight();
            /*0x81c0270*/ int get_layoutPriority();
            /*0x81c0278*/ void SetLayoutHorizontal();
            /*0x81c0850*/ void SetLayoutVertical();
            /*0x81bfbb4*/ void UpdateScrollbarVisibility();
            /*0x81c0908*/ void UpdateScrollbarLayout();
            /*0x81be494*/ void UpdateBounds();
            /*0x81c075c*/ UnityEngine.Bounds GetBounds();
            /*0x81bf0e8*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x81bdccc*/ void SetDirty();
            /*0x81bd894*/ void SetDirtyCaching();
            /*0x81c0fb0*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x81be04c*/ ScrollRectEvent();
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

            static /*0x81c2af0*/ Selectable();
            static /*0x81c0fb8*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x81c1054*/ int get_allSelectableCount();
            static /*0x81c10ac*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x81c1148*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x81c2698*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x81bbc7c*/ Selectable();
            /*0x81c1204*/ UnityEngine.UI.Navigation get_navigation();
            /*0x81c121c*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0x81c1308*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x81c1310*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x81c1384*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x81c1394*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x81c142c*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x81c1438*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x81c14b4*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x81c14bc*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x81c1530*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x81c1538*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x81c15ac*/ bool get_interactable();
            /*0x81c15b4*/ void set_interactable(bool value);
            /*0x81c1724*/ bool get_isPointerInside();
            /*0x81c172c*/ void set_isPointerInside(bool value);
            /*0x81c1738*/ bool get_isPointerDown();
            /*0x81c1740*/ void set_isPointerDown(bool value);
            /*0x81c174c*/ bool get_hasSelection();
            /*0x81c1754*/ void set_hasSelection(bool value);
            /*0x81c1760*/ UnityEngine.UI.Image get_image();
            /*0x81c17dc*/ void set_image(UnityEngine.UI.Image value);
            /*0x81c17e4*/ UnityEngine.Animator get_animator();
            /*0x81c182c*/ void Awake();
            /*0x81c18dc*/ void OnCanvasGroupChanged();
            /*0x81c1910*/ bool ParentGroupAllowsInteraction();
            /*0x81c1a88*/ bool IsInteractable();
            /*0x81c1aa8*/ void OnDidApplyAnimationProperties();
            /*0x81bc0e0*/ void OnEnable();
            /*0x81c1afc*/ void OnTransformParentChanged();
            /*0x81c12a4*/ void OnSetProperty();
            /*0x81bc3d0*/ void OnDisable();
            /*0x81c1b24*/ void OnApplicationFocus(bool hasFocus);
            /*0x81c1aac*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x81c1bcc*/ void InstantClearState();
            /*0x81c1f7c*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x81c21e4*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x81c2818*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x81bd108*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x81bd204*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x81bd300*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x81bd3fc*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x81bd058*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81c1c3c*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x81c1d4c*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x81c1df4*/ void TriggerAnimation(string triggername);
            /*0x81c28d0*/ bool IsHighlighted();
            /*0x81c1b80*/ bool IsPressed();
            /*0x81c292c*/ void EvaluateAndTransitionToSelectionState();
            /*0x81bcb9c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81bcde8*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c29c4*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c29d0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c29d8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81c29e4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81c29ec*/ void Select();

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
            static /*0x81c2b74*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
            static /*0x3910ae8*/ bool SetStruct<T>(ref T currentValue, T newValue);
            static /*0x3910ae8*/ bool SetClass<T>(ref T currentValue, T newValue);
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

            /*0x81c374c*/ Slider();
            /*0x81c2bbc*/ UnityEngine.RectTransform get_fillRect();
            /*0x81c2bc4*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x81c325c*/ UnityEngine.RectTransform get_handleRect();
            /*0x81c3264*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x81c32e0*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x81c32e8*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x81c335c*/ float get_minValue();
            /*0x81c3364*/ void set_minValue(float value);
            /*0x81c33f4*/ float get_maxValue();
            /*0x81c33fc*/ void set_maxValue(float value);
            /*0x81c348c*/ bool get_wholeNumbers();
            /*0x81c3494*/ void set_wholeNumbers(bool value);
            /*0x81c3524*/ float get_value();
            /*0x81c35c4*/ void set_value(float value);
            /*0x81c35d8*/ void SetValueWithoutNotify(float input);
            /*0x81c35ec*/ float get_normalizedValue();
            /*0x81c36d0*/ void set_normalizedValue(float value);
            /*0x81c3708*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x81c3710*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x81c3720*/ float get_stepSize();
            /*0x81c385c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81c3860*/ void LayoutComplete();
            /*0x81c3864*/ void GraphicUpdateComplete();
            /*0x81c3868*/ void OnEnable();
            /*0x81c38a4*/ void OnDisable();
            /*0x81c38c4*/ void Update();
            /*0x81c3904*/ void OnDidApplyAnimationProperties();
            /*0x81c2c40*/ void UpdateCachedReferences();
            /*0x81c3aec*/ float ClampValue(float input);
            /*0x81c3bc4*/ void Set(float input, bool sendCallback);
            /*0x81c3c88*/ void OnRectTransformDimensionsChange();
            /*0x81c3bb4*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x81c3ba0*/ bool get_reverseValue();
            /*0x81c2f78*/ void UpdateVisuals();
            /*0x81c3cc0*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x81c3eb8*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c3f1c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c40d4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c4124*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81c4370*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x81c4394*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x81c43b8*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x81c43dc*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x81c4400*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c4418*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x81c45a0*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x81c3814*/ SliderEvent();
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

            /*0x81c45a8*/ UnityEngine.Sprite get_highlightedSprite();
            /*0x81c45b0*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0x81c45b8*/ UnityEngine.Sprite get_pressedSprite();
            /*0x81c45c0*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0x81c45c8*/ UnityEngine.Sprite get_selectedSprite();
            /*0x81c45d0*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0x81c45d8*/ UnityEngine.Sprite get_disabledSprite();
            /*0x81c45e0*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0x81c45e8*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x81c550c*/ StencilMaterial();
            static /*0x81c46f0*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x81c46f8*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x81c515c*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x81c4784*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x81c5214*/ void Remove(UnityEngine.Material customMat);
            static /*0x81c53e0*/ void ClearAll();

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

                /*0x81c5204*/ MatEntry();
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

            static /*0x81c6670*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x81c55a4*/ Text();
            /*0x81c5648*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x81c56e0*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x81c5750*/ UnityEngine.Texture get_mainTexture();
            /*0x81c5914*/ void FontTextureChanged();
            /*0x81c58f8*/ UnityEngine.Font get_font();
            /*0x81c5a20*/ void set_font(UnityEngine.Font value);
            /*0x81c5b3c*/ string get_text();
            /*0x81c5b44*/ void set_text(string value);
            /*0x81c5c24*/ bool get_supportRichText();
            /*0x81c5c40*/ void set_supportRichText(bool value);
            /*0x81c5ca0*/ bool get_resizeTextForBestFit();
            /*0x81c5cbc*/ void set_resizeTextForBestFit(bool value);
            /*0x81c5d1c*/ int get_resizeTextMinSize();
            /*0x81c5d38*/ void set_resizeTextMinSize(int value);
            /*0x81c5d8c*/ int get_resizeTextMaxSize();
            /*0x81c5da8*/ void set_resizeTextMaxSize(int value);
            /*0x81c5dfc*/ UnityEngine.TextAnchor get_alignment();
            /*0x81c5e18*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x81c5e6c*/ bool get_alignByGeometry();
            /*0x81c5e88*/ void set_alignByGeometry(bool value);
            /*0x81c5ed0*/ int get_fontSize();
            /*0x81c5eec*/ void set_fontSize(int value);
            /*0x81c5f40*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x81c5f5c*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x81c5fb0*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x81c5fcc*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x81c6020*/ float get_lineSpacing();
            /*0x81c603c*/ void set_lineSpacing(float value);
            /*0x81c6090*/ UnityEngine.FontStyle get_fontStyle();
            /*0x81c60ac*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x81c6100*/ float get_pixelsPerUnit();
            /*0x81c6248*/ void OnEnable();
            /*0x81c62c4*/ void OnDisable();
            /*0x81c6328*/ void UpdateGeometry();
            /*0x81c63b0*/ void AssignDefaultFont();
            /*0x81c6420*/ void AssignDefaultFontIfNecessary();
            /*0x81c64dc*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x81c66dc*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x81c6dc8*/ void CalculateLayoutInputHorizontal();
            /*0x81c6dcc*/ void CalculateLayoutInputVertical();
            /*0x81c6dd0*/ float get_minWidth();
            /*0x81c6dd8*/ float get_preferredWidth();
            /*0x81c6eb4*/ float get_flexibleWidth();
            /*0x81c6ebc*/ float get_minHeight();
            /*0x81c6ec4*/ float get_preferredHeight();
            /*0x81c6f7c*/ float get_flexibleHeight();
            /*0x81c6f84*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0x100*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x108*/ UnityEngine.UI.Graphic graphic;
            /*0x110*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x118*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x120*/ bool m_IsOn;

            /*0x81c71d0*/ Toggle();
            /*0x81c6f8c*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x81c6f94*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x81c72b0*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x81c72b4*/ void LayoutComplete();
            /*0x81c72b8*/ void GraphicUpdateComplete();
            /*0x81c72bc*/ void OnDestroy();
            /*0x81c772c*/ void OnEnable();
            /*0x81c7758*/ void OnDisable();
            /*0x81c7778*/ void OnDidApplyAnimationProperties();
            /*0x81c6fb4*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x81c7c90*/ bool get_isOn();
            /*0x81c7c98*/ void set_isOn(bool value);
            /*0x81c7ca4*/ void SetIsOnWithoutNotify(bool value);
            /*0x81c789c*/ void Set(bool value, bool sendCallback);
            /*0x81c710c*/ void PlayEffect(bool instant);
            /*0x81c7df0*/ void Start();
            /*0x81c7df8*/ void InternalToggle();
            /*0x81c7e4c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81c7e70*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81c7e74*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x81c7268*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ bool m_AllowSwitchOff;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x81c7e90*/ ToggleGroup();
            /*0x81c7e7c*/ bool get_allowSwitchOff();
            /*0x81c7e84*/ void set_allowSwitchOff(bool value);
            /*0x81c7f18*/ void Start();
            /*0x81c7f34*/ void OnEnable();
            /*0x81c7f50*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x81c7b84*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x81c7a10*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x81c7aa0*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x81c733c*/ void EnsureValidState();
            /*0x81c7cb0*/ bool AnyTogglesOn();
            /*0x81c80a0*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x81c819c*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x81c8224*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x81c831c*/ <>c();
                /*0x81c8384*/ <>c();
                /*0x81c838c*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x81c83a4*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
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

            static /*0x81c9150*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x81c83bc*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x81c91d4*/ Raycast3DCallback(object object, nint method);
                /*0x81c9274*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x81c92b4*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x81c93b4*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x81c93e0*/ RaycastAllCallback(object object, nint method);
                /*0x81c9480*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x81c94bc*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x81c9584*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x81c9590*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x81c9630*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x81c966c*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x81c973c*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x81c9764*/ Raycast2DCallback(object object, nint method);
                /*0x81c9804*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x81c9818*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x81c98f4*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x81c992c*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x81c99cc*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x81c9a08*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x81c9ad0*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x81c9adc*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x81c9b7c*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x81c9bb8*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x81c9c88*/ int EndInvoke(System.IAsyncResult result);
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

            static /*0x81caf78*/ VertexHelper();
            /*0x81c9cb0*/ VertexHelper();
            /*0x81c9cb8*/ VertexHelper(UnityEngine.Mesh m);
            /*0x81c9ef4*/ void InitializeListIfRequired();
            /*0x81ca0e8*/ void Dispose();
            /*0x81b9e90*/ void Clear();
            /*0x81ca350*/ int get_currentVertCount();
            /*0x81ca39c*/ int get_currentIndexCount();
            /*0x81ca3e8*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x81ca548*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x81ca6a4*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x81ca804*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x81caca0*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x81b9fac*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x81cad98*/ void AddVert(UnityEngine.UIVertex v);
            /*0x81ba0dc*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x81c6cb8*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x81cae2c*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x81caed8*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x81caf28*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x81cb010*/ BaseVertexEffect();
            /*0x3816710*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x20*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x81cb450*/ BaseMeshEffect();
            /*0x81cb018*/ UnityEngine.UI.Graphic get_graphic();
            /*0x81cb0c0*/ void OnEnable();
            /*0x81cb168*/ void OnDisable();
            /*0x81cb204*/ void OnDidApplyAnimationProperties();
            /*0x81cb2a0*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x3816710*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        interface IVertexModifier
        {
            /*0x3816710*/ void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
        }

        interface IMeshModifier
        {
            /*0x3816710*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x3816710*/ void ModifyMesh(UnityEngine.UI.VertexHelper verts);
        }

        class Outline : UnityEngine.UI.Shadow
        {
            /*0x81cb458*/ Outline();
            /*0x81cb460*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x81cb6a0*/ PositionAsUV1();
            /*0x81cb6a8*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x28*/ UnityEngine.Color m_EffectColor;
            /*0x38*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x40*/ bool m_UseGraphicAlpha;

            /*0x81cb764*/ Shadow();
            /*0x81cb78c*/ UnityEngine.Color get_effectColor();
            /*0x81cb798*/ void set_effectColor(UnityEngine.Color value);
            /*0x81cb86c*/ UnityEngine.Vector2 get_effectDistance();
            /*0x81cb874*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x81cb978*/ bool get_useGraphicAlpha();
            /*0x81cb980*/ void set_useGraphicAlpha(bool value);
            /*0x81cba38*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x81cbd48*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x81cbd50*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;
                /*0x0*/ int m_EnabledObjectCount;

                /*0x38159dc*/ IndexedSet();
                /*0x3910ae8*/ void Add(T item);
                /*0x3910ae8*/ void Add(T item, bool isActive);
                /*0x3910ae8*/ bool AddUnique(T item, bool isActive);
                /*0x3910ae8*/ bool EnableItem(T item);
                /*0x3910ae8*/ bool DisableItem(T item);
                /*0x3910ae8*/ bool Remove(T item);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ bool Contains(T item);
                /*0x381678c*/ void CopyTo(T[] array, int arrayIndex);
                /*0x3814574*/ int get_Count();
                /*0x3814574*/ int get_Capacity();
                /*0x3813ffc*/ bool get_IsReadOnly();
                /*0x3910ae8*/ int IndexOf(T item);
                /*0x3910ae8*/ void Insert(int index, T item);
                /*0x3815ed0*/ void RemoveAt(int index);
                /*0x3815fb8*/ void Swap(int index1, int index2);
                /*0x3910ae8*/ T get_Item(int index);
                /*0x3910ae8*/ void set_Item(int index, T value);
                /*0x3816710*/ void RemoveAll(System.Predicate<T> match);
                /*0x3816710*/ void Sort(System.Comparison<T> sortLayoutFunction);
            }
        }

        namespace CoroutineTween
        {
            interface ITweenValue
            {
                /*0x3816f24*/ void TweenValue(float floatPercentage);
                /*0x3813ffc*/ bool get_ignoreTimeScale();
                /*0x38151b8*/ float get_duration();
                /*0x3813ffc*/ bool ValidTarget();
            }

            struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;
                /*0x18*/ UnityEngine.Color m_StartColor;
                /*0x28*/ UnityEngine.Color m_TargetColor;
                /*0x38*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;
                /*0x3c*/ float m_Duration;
                /*0x40*/ bool m_IgnoreTimeScale;

                /*0x81cbe70*/ UnityEngine.Color get_startColor();
                /*0x81cbe7c*/ void set_startColor(UnityEngine.Color value);
                /*0x81cbe88*/ UnityEngine.Color get_targetColor();
                /*0x81cbe94*/ void set_targetColor(UnityEngine.Color value);
                /*0x81cbea0*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0x81cbea8*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0x81cbeb0*/ float get_duration();
                /*0x81cbeb8*/ void set_duration(float value);
                /*0x81cbec0*/ bool get_ignoreTimeScale();
                /*0x81cbec8*/ void set_ignoreTimeScale(bool value);
                /*0x81cbed4*/ void TweenValue(float floatPercentage);
                /*0x81cbfc0*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0x81cc09c*/ bool GetIgnoreTimescale();
                /*0x81cc0a4*/ float GetDuration();
                /*0x81cbfb0*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x81cc054*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0x81cc0ac*/ float get_startValue();
                /*0x81cc0b4*/ void set_startValue(float value);
                /*0x81cc0bc*/ float get_targetValue();
                /*0x81cc0c4*/ void set_targetValue(float value);
                /*0x81cc0cc*/ float get_duration();
                /*0x81cc0d4*/ void set_duration(float value);
                /*0x81cc0dc*/ bool get_ignoreTimeScale();
                /*0x81cc0e4*/ void set_ignoreTimeScale(bool value);
                /*0x81cc0f0*/ void TweenValue(float floatPercentage);
                /*0x81cc18c*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0x81cc268*/ bool GetIgnoreTimescale();
                /*0x81cc270*/ float GetDuration();
                /*0x81cc17c*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x81cc220*/ FloatTweenCallback();
                }
            }

            class TweenRunner<T>
            {
                /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
                /*0x0*/ System.Collections.IEnumerator m_Tween;

                static /*0x3910ae8*/ System.Collections.IEnumerator Start(T tweenInfo);
                /*0x38159dc*/ TweenRunner();
                /*0x3816710*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
                /*0x3910ae8*/ void StartTween(T info);
                /*0x38159dc*/ void StopTween();

                class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ T tweenInfo;
                    /*0x0*/ float <elapsedTime>5__2;

                    /*0x3815ed0*/ <Start>d__2(int <>1__state);
                    /*0x38159dc*/ void System.IDisposable.Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38148bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x81cebcc*/ PanelEventHandler();
            /*0x81cc278*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x81cc280*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x81cc69c*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x81cc6b4*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x81cc788*/ bool get_isCurrentFocusedPanel();
            /*0x81cc850*/ UnityEngine.UIElements.Focusable get_currentFocusedElement();
            /*0x81cc888*/ void OnEnable();
            /*0x81cc890*/ void OnDisable();
            /*0x81cc4e8*/ void RegisterCallbacks();
            /*0x81cc334*/ void UnregisterCallbacks();
            /*0x81cc898*/ void OnPanelDestroyed();
            /*0x81cc8a0*/ void OnElementFocus(UnityEngine.UIElements.FocusEvent e);
            /*0x81cc988*/ void OnElementBlur(UnityEngine.UIElements.BlurEvent e);
            /*0x81cc98c*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81cca04*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81cca18*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81ccd68*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81ccf84*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81cd210*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81cd538*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81cd58c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81cd5a8*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81cd900*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81cdb10*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81cdd44*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81ccd04*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData);
            /*0x81cdf60*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent);
            /*0x81cdf80*/ void Update();
            /*0x81cdfdc*/ void LateUpdate();
            /*0x81cd7b8*/ void ProcessImguiEvents(UnityEngine.UIElements.Focusable target);
            /*0x81cdfe4*/ void ProcessKeyboardEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81ce064*/ void ProcessTabEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81ce4ec*/ void SendTabEvent(UnityEngine.Event e, UnityEngine.UIElements.NavigationMoveEvent.Direction direction, UnityEngine.UIElements.Focusable target);
            /*0x81ce0cc*/ void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81ce2dc*/ void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target);
            /*0x81ccbc4*/ bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);

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

                static /*0x81ceea8*/ bool <Read>g__InRange|90_0(int i, int start, int count);
                /*0x81cec78*/ PointerEvent();
                /*0x81cec88*/ int get_pointerId();
                /*0x81cec90*/ void set_pointerId(int value);
                /*0x81cec98*/ string get_pointerType();
                /*0x81ceca0*/ void set_pointerType(string value);
                /*0x81ceca8*/ bool get_isPrimary();
                /*0x81cecb0*/ void set_isPrimary(bool value);
                /*0x81cecbc*/ int get_button();
                /*0x81cecc4*/ void set_button(int value);
                /*0x81ceccc*/ int get_pressedButtons();
                /*0x81cecd4*/ void set_pressedButtons(int value);
                /*0x81cecdc*/ UnityEngine.Vector3 get_position();
                /*0x81cece8*/ void set_position(UnityEngine.Vector3 value);
                /*0x81cecf4*/ UnityEngine.Vector3 get_localPosition();
                /*0x81ced00*/ void set_localPosition(UnityEngine.Vector3 value);
                /*0x81ced0c*/ UnityEngine.Vector3 get_deltaPosition();
                /*0x81ced18*/ void set_deltaPosition(UnityEngine.Vector3 value);
                /*0x81ced24*/ float get_deltaTime();
                /*0x81ced2c*/ void set_deltaTime(float value);
                /*0x81ced34*/ int get_clickCount();
                /*0x81ced3c*/ void set_clickCount(int value);
                /*0x81ced44*/ float get_pressure();
                /*0x81ced4c*/ void set_pressure(float value);
                /*0x81ced54*/ float get_tangentialPressure();
                /*0x81ced5c*/ void set_tangentialPressure(float value);
                /*0x81ced64*/ float get_altitudeAngle();
                /*0x81ced6c*/ void set_altitudeAngle(float value);
                /*0x81ced74*/ float get_azimuthAngle();
                /*0x81ced7c*/ void set_azimuthAngle(float value);
                /*0x81ced84*/ float get_twist();
                /*0x81ced8c*/ void set_twist(float value);
                /*0x81ced94*/ UnityEngine.Vector2 get_tilt();
                /*0x81ced9c*/ void set_tilt(UnityEngine.Vector2 value);
                /*0x81ceda4*/ UnityEngine.PenStatus get_penStatus();
                /*0x81cedac*/ void set_penStatus(UnityEngine.PenStatus value);
                /*0x81cedb4*/ UnityEngine.Vector2 get_radius();
                /*0x81cedbc*/ void set_radius(UnityEngine.Vector2 value);
                /*0x81cedc4*/ UnityEngine.Vector2 get_radiusVariance();
                /*0x81cedcc*/ void set_radiusVariance(UnityEngine.Vector2 value);
                /*0x81cedd4*/ UnityEngine.EventModifiers get_modifiers();
                /*0x81ceddc*/ void set_modifiers(UnityEngine.EventModifiers value);
                /*0x81cede4*/ bool get_shiftKey();
                /*0x81cedf0*/ bool get_ctrlKey();
                /*0x81cedfc*/ bool get_commandKey();
                /*0x81cee08*/ bool get_altKey();
                /*0x81cee14*/ bool get_actionKey();
                /*0x81ce6e0*/ void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);
                /*0x81cebb4*/ void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride);
            }
        }

        class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
        {
            /*0x28*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;

            /*0x81cf670*/ PanelRaycaster();
            /*0x81ceec4*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x81ceecc*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x81cf010*/ void RegisterCallbacks();
            /*0x81cef80*/ void UnregisterCallbacks();
            /*0x81cf0a0*/ void OnPanelDestroyed();
            /*0x81cf0a8*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x81cf0c0*/ int get_sortOrderPriority();
            /*0x81cf13c*/ int get_renderOrderPriority();
            /*0x81cf1b0*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x81cf668*/ UnityEngine.Camera get_eventCamera();
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x81cf6a0*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x81cf680*/ UnityEngine.Vector2 get_moveVector();
            /*0x81cf688*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x81cf690*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0x81cf698*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x81cf760*/ AbstractEventData();
            /*0x81cf744*/ void Reset();
            /*0x81cf74c*/ void Use();
            /*0x81cf758*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0x81cf714*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x81cf768*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x81cf784*/ UnityEngine.GameObject get_selectedObject();
            /*0x81cf7a0*/ void set_selectedObject(UnityEngine.GameObject value);
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

            /*0x81cfca8*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x81cf9f4*/ UnityEngine.GameObject get_pointerEnter();
            /*0x81cf9fc*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x81cfa04*/ UnityEngine.GameObject get_lastPress();
            /*0x81cfa0c*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x81cfa14*/ UnityEngine.GameObject get_rawPointerPress();
            /*0x81cfa1c*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0x81cfa24*/ UnityEngine.GameObject get_pointerDrag();
            /*0x81cfa2c*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x81cfa34*/ UnityEngine.GameObject get_pointerClick();
            /*0x81cfa3c*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x81cfa44*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x81cfa54*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x81cfa78*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x81cfa88*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x81cfaac*/ bool get_eligibleForClick();
            /*0x81cfab4*/ void set_eligibleForClick(bool value);
            /*0x81cfac0*/ int get_displayIndex();
            /*0x81cfac8*/ void set_displayIndex(int value);
            /*0x81cfad0*/ int get_pointerId();
            /*0x81cfad8*/ void set_pointerId(int value);
            /*0x81cfae0*/ UnityEngine.Vector2 get_position();
            /*0x81cfaec*/ void set_position(UnityEngine.Vector2 value);
            /*0x81cfaf8*/ UnityEngine.Vector2 get_delta();
            /*0x81cfb04*/ void set_delta(UnityEngine.Vector2 value);
            /*0x81cfb10*/ UnityEngine.Vector2 get_pressPosition();
            /*0x81cfb1c*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x81cfb28*/ UnityEngine.Vector3 get_worldPosition();
            /*0x81cfb38*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x81cfb48*/ UnityEngine.Vector3 get_worldNormal();
            /*0x81cfb58*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x81cfb68*/ float get_clickTime();
            /*0x81cfb70*/ void set_clickTime(float value);
            /*0x81cfb78*/ int get_clickCount();
            /*0x81cfb80*/ void set_clickCount(int value);
            /*0x81cfb88*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x81cfb94*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x81cfba0*/ bool get_useDragThreshold();
            /*0x81cfba8*/ void set_useDragThreshold(bool value);
            /*0x81cfbb4*/ bool get_dragging();
            /*0x81cfbbc*/ void set_dragging(bool value);
            /*0x81cfbc8*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x81cfbd0*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x81cfbd8*/ float get_pressure();
            /*0x81cfbe0*/ void set_pressure(float value);
            /*0x81cfbe8*/ float get_tangentialPressure();
            /*0x81cfbf0*/ void set_tangentialPressure(float value);
            /*0x81cfbf8*/ float get_altitudeAngle();
            /*0x81cfc00*/ void set_altitudeAngle(float value);
            /*0x81cfc08*/ float get_azimuthAngle();
            /*0x81cfc10*/ void set_azimuthAngle(float value);
            /*0x81cfc18*/ float get_twist();
            /*0x81cfc20*/ void set_twist(float value);
            /*0x81cfc28*/ UnityEngine.Vector2 get_tilt();
            /*0x81cfc34*/ void set_tilt(UnityEngine.Vector2 value);
            /*0x81cfc40*/ UnityEngine.PenStatus get_penStatus();
            /*0x81cfc48*/ void set_penStatus(UnityEngine.PenStatus value);
            /*0x81cfc50*/ UnityEngine.Vector2 get_radius();
            /*0x81cfc5c*/ void set_radius(UnityEngine.Vector2 value);
            /*0x81cfc68*/ UnityEngine.Vector2 get_radiusVariance();
            /*0x81cfc74*/ void set_radiusVariance(UnityEngine.Vector2 value);
            /*0x81cfc80*/ bool get_fullyExited();
            /*0x81cfc88*/ void set_fullyExited(bool value);
            /*0x81cfc94*/ bool get_reentered();
            /*0x81cfc9c*/ void set_reentered(bool value);
            /*0x81cfdf0*/ bool IsPointerMoving();
            /*0x81cfe10*/ bool IsScrolling();
            /*0x81cfe30*/ UnityEngine.Camera get_enterEventCamera();
            /*0x81cfec0*/ UnityEngine.Camera get_pressEventCamera();
            /*0x81cff50*/ UnityEngine.GameObject get_pointerPress();
            /*0x81cff58*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x81cfffc*/ string ToString();

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
            /*0x3816710*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x3816710*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
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

            static /*0x81d2a74*/ EventSystem();
            static /*0x81d0cd0*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x81d0d94*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x81d11e4*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            static /*0x81d1adc*/ void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart);
            /*0x81d0f7c*/ EventSystem();
            /*0x81d0f28*/ bool get_sendNavigationEvents();
            /*0x81d0f30*/ void set_sendNavigationEvents(bool value);
            /*0x81d0f3c*/ int get_pixelDragThreshold();
            /*0x81d0f44*/ void set_pixelDragThreshold(int value);
            /*0x81d0f4c*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x81d0f54*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x81d0f5c*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0x81d0f64*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x81d0f6c*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0x81d0f74*/ bool get_isFocused();
            /*0x81d1018*/ void UpdateModules();
            /*0x81d1158*/ bool get_alreadySelecting();
            /*0x81cf7bc*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x81d1160*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x81cc95c*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x81d1668*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x81d1858*/ bool IsPointerOverGameObject();
            /*0x81d1860*/ bool IsPointerOverGameObject(int pointerId);
            /*0x81d1904*/ bool get_isUIToolkitActiveEventSystem();
            /*0x81d19f4*/ bool get_sendUIToolkitEvents();
            /*0x81d1a68*/ bool get_createUIToolkitPanelGameObjectsOnStart();
            /*0x81d1c88*/ void StartTrackingUIToolkitPanels();
            /*0x81d2174*/ void StopTrackingUIToolkitPanels();
            /*0x81d1ec0*/ void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x81d2228*/ void Start();
            /*0x81d2238*/ void OnEnable();
            /*0x81d2368*/ void OnDisable();
            /*0x81d2490*/ void TickModules();
            /*0x81d2590*/ void OnApplicationFocus(bool hasFocus);
            /*0x81d25a4*/ void Update();
            /*0x81d280c*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x81d291c*/ string ToString();

            struct UIToolkitOverrideConfig
            {
                /*0x10*/ UnityEngine.EventSystems.EventSystem activeEventSystem;
                /*0x18*/ bool sendEvents;
                /*0x19*/ bool createPanelGameObjectsOnStart;
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.GameObject go;

                /*0x81d2220*/ <>c__DisplayClass56_0();
                /*0x81d2bb4*/ void <CreateUIToolkitPanelGameObject>b__0();
            }
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x81d2ca0*/ EventTrigger();
            /*0x81d2c10*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x81d2c98*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x81d2c14*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x81d2ca8*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x81d2cb0*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81d2d94*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2da0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2dac*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2db8*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2dc4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2dd0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2ddc*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2de8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81d2df4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81d2e00*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2e0c*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x81d2e18*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81d2e24*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2e30*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2e3c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x81d2e48*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x81d2e54*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x81d2e60*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x81d2ea8*/ Entry();
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

            static /*0x81d4674*/ ExecuteEvents();
            static /*0x3910ae8*/ T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x81d2f18*/ void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d300c*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3100*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d31f4*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d32e8*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d33dc*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d34d0*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d35c4*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d36b8*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d37ac*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d38a0*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3994*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3a88*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3b2c*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3bd0*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3c74*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3d68*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3e0c*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x81d3eb0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler();
            static /*0x81d3f08*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x81d3f60*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x81d3fb8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x81d4010*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x81d4068*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x81d40c0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x81d4118*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x81d4170*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x81d41c8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x81d4220*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x81d4278*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x81d42d0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x81d4328*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x81d4380*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x81d43d8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x81d4430*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x81d4488*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x81d44e0*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
            static /*0x3825c3c*/ bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor);
            static /*0x3839970*/ UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction);
            static /*0x3823ae0*/ bool ShouldSendToComponent<T>(UnityEngine.Component component);
            static /*0x3843dfc*/ void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results);
            static /*0x3823ae0*/ bool CanHandleEvent<T>(UnityEngine.GameObject go);
            static /*0x38379c4*/ UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root);

            class EventFunction<T1> : System.MulticastDelegate
            {
                EventFunction(object object, nint method);
                /*0x3910ae8*/ void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData);
                /*0x3910ae8*/ System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object);
                /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x81d4e28*/ BaseInput();
            /*0x81d4d58*/ string get_compositionString();
            /*0x81d4d60*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x81d4d68*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x81d4d74*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x81d4d7c*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x81d4d84*/ bool get_mousePresent();
            /*0x81d4d8c*/ bool GetMouseButtonDown(int button);
            /*0x81d4d98*/ bool GetMouseButtonUp(int button);
            /*0x81d4da4*/ bool GetMouseButton(int button);
            /*0x81d4db0*/ UnityEngine.Vector2 get_mousePosition();
            /*0x81d4db8*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x81d4dc0*/ float get_mouseScrollDeltaPerTick();
            /*0x81d4dc8*/ bool get_touchSupported();
            /*0x81d4dd0*/ int get_touchCount();
            /*0x81d4dd8*/ UnityEngine.Touch GetTouch(int index);
            /*0x81d4e10*/ float GetAxisRaw(string axisName);
            /*0x81d4e1c*/ bool GetButtonDown(string buttonName);
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

            static /*0x81d5100*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x81d5214*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x81d5268*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x81d52b8*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x81d61c4*/ BaseInputModule();
            /*0x81d4e30*/ bool get_sendPointerHoverToParent();
            /*0x81d4e38*/ void set_sendPointerHoverToParent(bool value);
            /*0x81d4e44*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x81d5068*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x81d5070*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x81d5078*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x81d5080*/ void OnEnable();
            /*0x81d50e8*/ void OnDisable();
            /*0x38159dc*/ void Process();
            /*0x81d542c*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x81d5ee8*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x81d6000*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x81d60a8*/ bool IsPointerOverGameObject(int pointerId);
            /*0x81d60b0*/ bool ShouldActivateModule();
            /*0x81d60f0*/ void DeactivateModule();
            /*0x81d60f4*/ void ActivateModule();
            /*0x81d60f8*/ void UpdateModule();
            /*0x81d60fc*/ bool IsModuleSupported();
            /*0x81d6104*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
            /*0x81d6180*/ UnityEngine.Vector2 ConvertPointerEventScrollDeltaToTicks(UnityEngine.Vector2 scrollDelta);
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x58*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x60*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x81d6bec*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x81d74dc*/ PointerInputModule();
            /*0x81d6254*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x81d634c*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x81d63a8*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x81d6738*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x81d67d8*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x81d6854*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x81d6868*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x81d6bcc*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x81d6c1c*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x81d6c60*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x81d6f2c*/ bool IsPointerOverGameObject(int pointerId);
            /*0x81d6fc8*/ void ClearSelection();
            /*0x81d7188*/ string ToString();
            /*0x81d73f0*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x81d763c*/ ButtonState();
                /*0x81d761c*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x81d7624*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x81d762c*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0x81d7634*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x81d7594*/ MouseState();
                /*0x81d7644*/ bool AnyPressesThisFrame();
                /*0x81d7710*/ bool AnyReleasesThisFrame();
                /*0x81d77e4*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x81d6b90*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x81d798c*/ MouseButtonEventData();
                /*0x81d7700*/ bool PressedThisFrame();
                /*0x81d77d0*/ bool ReleasedThisFrame();
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

            /*0x81d7994*/ StandaloneInputModule();
            /*0x81d7a70*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x81d7a78*/ bool get_allowActivationOnMobileDevice();
            /*0x81d7a80*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x81d7a8c*/ bool get_forceModuleActive();
            /*0x81d7a94*/ void set_forceModuleActive(bool value);
            /*0x81d7aa0*/ float get_inputActionsPerSecond();
            /*0x81d7aa8*/ void set_inputActionsPerSecond(float value);
            /*0x81d7ab0*/ float get_repeatDelay();
            /*0x81d7ab8*/ void set_repeatDelay(float value);
            /*0x81d7ac0*/ string get_horizontalAxis();
            /*0x81d7ac8*/ void set_horizontalAxis(string value);
            /*0x81d7ad0*/ string get_verticalAxis();
            /*0x81d7ad8*/ void set_verticalAxis(string value);
            /*0x81d7ae0*/ string get_submitButton();
            /*0x81d7ae8*/ void set_submitButton(string value);
            /*0x81d7af0*/ string get_cancelButton();
            /*0x81d7af8*/ void set_cancelButton(string value);
            /*0x81d7b00*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x81d7b08*/ void UpdateModule();
            /*0x81d7bec*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x81d7f90*/ bool ShouldActivateModule();
            /*0x81d81c8*/ void ActivateModule();
            /*0x81d82c8*/ void DeactivateModule();
            /*0x81d82cc*/ void Process();
            /*0x81d84b8*/ bool ProcessTouchEvents();
            /*0x81d8a9c*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x81d8888*/ bool SendSubmitEventToSelectedObject();
            /*0x81d91c4*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x81d8624*/ bool SendMoveEventToSelectedObject();
            /*0x81d861c*/ void ProcessMouseEvent();
            /*0x81d9580*/ bool ForceAutoSelect();
            /*0x81d92d0*/ void ProcessMouseEvent(int id);
            /*0x81d8370*/ bool SendUpdateEventToSelectedObject();
            /*0x81d9588*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x81d9944*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

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

            /*0x81d994c*/ TouchInputModule();
            /*0x81d9950*/ bool get_allowActivationOnStandalone();
            /*0x81d9958*/ void set_allowActivationOnStandalone(bool value);
            /*0x81d9964*/ bool get_forceModuleActive();
            /*0x81d996c*/ void set_forceModuleActive(bool value);
            /*0x81d9978*/ void UpdateModule();
            /*0x81d9ae0*/ bool IsModuleSupported();
            /*0x81d9b18*/ bool ShouldActivateModule();
            /*0x81d9bbc*/ bool UseFakeInput();
            /*0x81d9bec*/ void Process();
            /*0x81d9c14*/ void FakeTouches();
            /*0x81d9d3c*/ void ProcessTouchEvents();
            /*0x81d9e84*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x81da5a4*/ void DeactivateModule();
            /*0x81da5a8*/ string ToString();
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

            static /*0x81daa3c*/ RaycasterManager();
            static /*0x81da7f0*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x81da914*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x81da96c*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x81cf678*/ BaseRaycaster();
            /*0x3816810*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x38148bc*/ UnityEngine.Camera get_eventCamera();
            /*0x81daad4*/ int get_priority();
            /*0x81daadc*/ int get_sortOrderPriority();
            /*0x81daae4*/ int get_renderOrderPriority();
            /*0x81d159c*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x81daaec*/ string ToString();
            /*0x81dad38*/ void OnEnable();
            /*0x81dad8c*/ void OnDisable();
            /*0x81dade0*/ void OnCanvasHierarchyChanged();
            /*0x81dadf0*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x48*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x81dae00*/ Physics2DRaycaster();
            /*0x81dae50*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x28*/ UnityEngine.Camera m_EventCamera;
            /*0x30*/ UnityEngine.LayerMask m_EventMask;
            /*0x34*/ int m_MaxRayIntersections;
            /*0x38*/ int m_LastMaxRayIntersections;
            /*0x40*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x81dae28*/ PhysicsRaycaster();
            /*0x81db968*/ UnityEngine.Camera get_eventCamera();
            /*0x81dba4c*/ int get_depth();
            /*0x81db8a4*/ int get_finalEventMask();
            /*0x81dbb10*/ UnityEngine.LayerMask get_eventMask();
            /*0x81dbb18*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x81dbb20*/ int get_maxRayIntersections();
            /*0x81dbb28*/ void set_maxRayIntersections(int value);
            /*0x81db5a8*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x81dbb30*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x81dbfbc*/ RaycastHitComparer();
                /*0x81dbfb4*/ RaycastHitComparer();
                /*0x81dbf70*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
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

            /*0x81dc024*/ UnityEngine.GameObject get_gameObject();
            /*0x81dc02c*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x81dc034*/ bool get_isValid();
            /*0x81dc0cc*/ void Clear();
            /*0x81d072c*/ string ToString();
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x81cec80*/ UIBehaviour();
            /*0x81dc190*/ void Awake();
            /*0x81cc88c*/ void OnEnable();
            /*0x81d2234*/ void Start();
            /*0x81cc894*/ void OnDisable();
            /*0x81dc194*/ void OnDestroy();
            /*0x81dc198*/ bool IsActive();
            /*0x81dc1a0*/ void OnRectTransformDimensionsChange();
            /*0x81dc1a4*/ void OnBeforeTransformParentChanged();
            /*0x81dadfc*/ void OnTransformParentChanged();
            /*0x81dc1a8*/ void OnDidApplyAnimationProperties();
            /*0x81dc1ac*/ void OnCanvasGroupChanged();
            /*0x81dadec*/ void OnCanvasHierarchyChanged();
            /*0x81dc1b0*/ bool IsDestroyed();
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
