class <Module>
{
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

            /*0x1a36b30*/ AnimationTriggers();
            /*0x1a36ae0*/ string get_normalTrigger();
            /*0x1a36ae8*/ void set_normalTrigger(string value);
            /*0x1a36af0*/ string get_highlightedTrigger();
            /*0x1a36af8*/ void set_highlightedTrigger(string value);
            /*0x1a36b00*/ string get_pressedTrigger();
            /*0x1a36b08*/ void set_pressedTrigger(string value);
            /*0x1a36b10*/ string get_selectedTrigger();
            /*0x1a36b18*/ void set_selectedTrigger(string value);
            /*0x1a36b20*/ string get_disabledTrigger();
            /*0x1a36b28*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0xf8*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x1a3924c*/ Button();
            /*0x1a392dc*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x1a392e4*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x1a392ec*/ void Press();
            /*0x1a39388*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a393a8*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a39430*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x2607af4*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x26079b4*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x26079e0*/ void System.IDisposable.Dispose();
                /*0x26079e4*/ bool MoveNext();
                /*0x2607aa4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2607aac*/ void System.Collections.IEnumerator.Reset();
                /*0x2607aec*/ object System.Collections.IEnumerator.get_Current();
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
            void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            UnityEngine.Transform get_transform();
            void LayoutComplete();
            void GraphicUpdateComplete();
            bool IsDestroyed();
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

            static /*0x1a3b644*/ CanvasUpdateRegistry();
            static /*0x1a39e74*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x1a3ac58*/ int ParentCount(UnityEngine.Transform child);
            static /*0x1a3ad34*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x1a3aea8*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1a3afb8*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1a3b024*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1a3b174*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1a3b1e0*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1a3b574*/ bool IsRebuildingLayout();
            static /*0x1a3b5dc*/ bool IsRebuildingGraphics();
            /*0x1a39c08*/ CanvasUpdateRegistry();
            /*0x1a39f30*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x1a3a00c*/ void CleanInvalidItems();
            /*0x1a3a328*/ void PerformUpdate();
            /*0x1a3af14*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1a3b090*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1a3b25c*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1a3b3e8*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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

            static /*0x1a3bb58*/ ColorBlock();
            static /*0x1a3beac*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x1a3beec*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0xad0528*/ UnityEngine.Color get_normalColor();
            /*0xad0534*/ void set_normalColor(UnityEngine.Color value);
            /*0xad0540*/ UnityEngine.Color get_highlightedColor();
            /*0xad054c*/ void set_highlightedColor(UnityEngine.Color value);
            /*0xad0558*/ UnityEngine.Color get_pressedColor();
            /*0xad0564*/ void set_pressedColor(UnityEngine.Color value);
            /*0xad0570*/ UnityEngine.Color get_selectedColor();
            /*0xad057c*/ void set_selectedColor(UnityEngine.Color value);
            /*0xad0588*/ UnityEngine.Color get_disabledColor();
            /*0xad0594*/ void set_disabledColor(UnityEngine.Color value);
            /*0xad05a0*/ float get_colorMultiplier();
            /*0xad05a8*/ void set_colorMultiplier(float value);
            /*0xad05b0*/ float get_fadeDuration();
            /*0xad05b8*/ void set_fadeDuration(float value);
            /*0xad05c0*/ bool Equals(object obj);
            /*0xad05c8*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0xad0608*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x1a3aab8*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x1a3b760*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x1a3b7d0*/ void Unregister(UnityEngine.UI.IClipper c);
            /*0x1a3b6e8*/ ClipperRegistry();
            /*0x1a3ab30*/ void Cull();
        }

        class Clipping
        {
            static /*0x1a3b830*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
        }

        interface IClipper
        {
            void PerformClipping();
        }

        interface IClippable
        {
            UnityEngine.GameObject get_gameObject();
            void RecalculateClipping();
            UnityEngine.RectTransform get_rectTransform();
            void Cull(UnityEngine.Rect clipRect, bool validRect);
            void SetClipRect(UnityEngine.Rect value, bool validRect);
            void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
        }

        class RectangularVertexClipper
        {
            /*0x10*/ UnityEngine.Vector3[] m_WorldCorners;
            /*0x18*/ UnityEngine.Vector3[] m_CanvasCorners;

            /*0x2134304*/ RectangularVertexClipper();
            /*0x2134030*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
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

            static /*0x1a4060c*/ DefaultControls();
            static /*0x1a3c584*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x1a3c5e8*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x1a3c764*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x1a3c9c4*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x1a3ca54*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x1a3c8b0*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x1a3cad4*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x1a3cbcc*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3ce14*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3d1a8*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3d35c*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3d4ac*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3d5fc*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3dce8*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3e148*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3e6c4*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3ec34*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x1a3fed4*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x2607bc0*/ DefaultRuntimeFactory();
                /*0x2607bb8*/ DefaultRuntimeFactory();
                /*0x2607b48*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
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
            /*0xf8*/ UnityEngine.RectTransform m_Template;
            /*0x100*/ UnityEngine.UI.Text m_CaptionText;
            /*0x108*/ UnityEngine.UI.Image m_CaptionImage;
            /*0x110*/ UnityEngine.UI.Text m_ItemText;
            /*0x118*/ UnityEngine.UI.Image m_ItemImage;
            /*0x120*/ int m_Value;
            /*0x128*/ UnityEngine.UI.Dropdown.OptionDataList m_Options;
            /*0x130*/ UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged;
            /*0x138*/ float m_AlphaFadeSpeed;
            /*0x140*/ UnityEngine.GameObject m_Dropdown;
            /*0x148*/ UnityEngine.GameObject m_Blocker;
            /*0x150*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items;
            /*0x158*/ UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner;
            /*0x160*/ bool validTemplate;

            static /*0x1a4337c*/ Dropdown();
            static T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x1a40910*/ Dropdown();
            /*0x1a40770*/ UnityEngine.RectTransform get_template();
            /*0x1a3fc94*/ void set_template(UnityEngine.RectTransform value);
            /*0x1a40778*/ UnityEngine.UI.Text get_captionText();
            /*0x1a3fc9c*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x1a40780*/ UnityEngine.UI.Image get_captionImage();
            /*0x1a40788*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x1a40790*/ UnityEngine.UI.Text get_itemText();
            /*0x1a3fca4*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x1a40798*/ UnityEngine.UI.Image get_itemImage();
            /*0x1a407a0*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x1a3fcac*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x1a407a8*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x1a407c4*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x1a407cc*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x1a407d4*/ float get_alphaFadeSpeed();
            /*0x1a407dc*/ void set_alphaFadeSpeed(float value);
            /*0x1a407e4*/ int get_value();
            /*0x1a407ec*/ void set_value(int value);
            /*0x1a40908*/ void SetValueWithoutNotify(int input);
            /*0x1a407f4*/ void Set(int value, bool sendCallback);
            /*0x1a40a18*/ void Awake();
            /*0x1a40b30*/ void Start();
            /*0x1a40bc8*/ void OnDisable();
            /*0x1a3fcc8*/ void RefreshShownValue();
            /*0x1a40dec*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x1a40e60*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x1a40f74*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x1a41088*/ void ClearOptions();
            /*0x1a410f0*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x1a41828*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a42484*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a42488*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a4182c*/ void Show();
            /*0x1a429b0*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x1a42e28*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x1a42e8c*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x1a42f04*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x1a42f68*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x1a42fe0*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x1a425a4*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x1a42fe4*/ void AlphaFadeList(float duration, float alpha);
            /*0x1a42878*/ void AlphaFadeList(float duration, float start, float end);
            /*0x1a43100*/ void SetAlpha(float alpha);
            /*0x1a4248c*/ void Hide();
            /*0x1a431c0*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x1a40c68*/ void ImmediateDestroyDropdownList();
            /*0x1a4323c*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x18*/ UnityEngine.UI.Text m_Text;
                /*0x20*/ UnityEngine.UI.Image m_Image;
                /*0x28*/ UnityEngine.RectTransform m_RectTransform;
                /*0x30*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x2607f48*/ DropdownItem();
                /*0x2607dd0*/ UnityEngine.UI.Text get_text();
                /*0x2607dd8*/ void set_text(UnityEngine.UI.Text value);
                /*0x2607de0*/ UnityEngine.UI.Image get_image();
                /*0x2607de8*/ void set_image(UnityEngine.UI.Image value);
                /*0x2607df0*/ UnityEngine.RectTransform get_rectTransform();
                /*0x2607df8*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x2607e00*/ UnityEngine.UI.Toggle get_toggle();
                /*0x2607e08*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x2607e10*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x2607e98*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x2607f70*/ OptionData();
                /*0x2607f78*/ OptionData(string text);
                /*0x2607fa4*/ OptionData(UnityEngine.Sprite image);
                /*0x2607fd0*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x2607f50*/ string get_text();
                /*0x2607f58*/ void set_text(string value);
                /*0x2607f60*/ UnityEngine.Sprite get_image();
                /*0x2607f68*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x2608018*/ OptionDataList();
                /*0x2608008*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x2608010*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x2607d84*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x2607c20*/ <>c__DisplayClass63_0();
                /*0x2607c28*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x2607c54*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x2607c80*/ void System.IDisposable.Dispose();
                /*0x2607c84*/ bool MoveNext();
                /*0x2607d34*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2607d3c*/ void System.Collections.IEnumerator.Reset();
                /*0x2607d7c*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x1a46b00*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x1a46b94*/ FontData();
            /*0x1a46b9c*/ UnityEngine.Font get_font();
            /*0x1a46ba4*/ void set_font(UnityEngine.Font value);
            /*0x1a46bac*/ int get_fontSize();
            /*0x1a46bb4*/ void set_fontSize(int value);
            /*0x1a46bbc*/ UnityEngine.FontStyle get_fontStyle();
            /*0x1a46bc4*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x1a46bcc*/ bool get_bestFit();
            /*0x1a46bd4*/ void set_bestFit(bool value);
            /*0x1a46be0*/ int get_minSize();
            /*0x1a46be8*/ void set_minSize(int value);
            /*0x1a46bf0*/ int get_maxSize();
            /*0x1a46bf8*/ void set_maxSize(int value);
            /*0x1a46c00*/ UnityEngine.TextAnchor get_alignment();
            /*0x1a46c08*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x1a46c10*/ bool get_alignByGeometry();
            /*0x1a46c18*/ void set_alignByGeometry(bool value);
            /*0x1a46c24*/ bool get_richText();
            /*0x1a46c2c*/ void set_richText(bool value);
            /*0x1a46c38*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x1a46c40*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x1a46c48*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x1a46c50*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x1a46c58*/ float get_lineSpacing();
            /*0x1a46c60*/ void set_lineSpacing(float value);
            /*0x1a46c68*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x1a46c6c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x1a4730c*/ FontUpdateTracker();
            static /*0x1a46cd8*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x1a46f58*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x1a470d4*/ void UntrackText(UnityEngine.UI.Text t);
        }

        class Graphic : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultUI;
            static /*0x8*/ UnityEngine.Texture2D s_WhiteTexture;
            static /*0x10*/ UnityEngine.Mesh s_Mesh;
            static /*0x18*/ UnityEngine.UI.VertexHelper s_VertexHelper;
            /*0x18*/ UnityEngine.Material m_Material;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ bool m_SkipLayoutUpdate;
            /*0x31*/ bool m_SkipMaterialUpdate;
            /*0x32*/ bool m_RaycastTarget;
            /*0x34*/ UnityEngine.Vector4 m_RaycastPadding;
            /*0x48*/ UnityEngine.RectTransform m_RectTransform;
            /*0x50*/ UnityEngine.CanvasRenderer m_CanvasRenderer;
            /*0x58*/ UnityEngine.Canvas m_Canvas;
            /*0x60*/ bool m_VertsDirty;
            /*0x61*/ bool m_MaterialDirty;
            /*0x68*/ UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback;
            /*0x70*/ UnityEngine.Events.UnityAction m_OnDirtyVertsCallback;
            /*0x78*/ UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback;
            /*0x80*/ UnityEngine.Mesh m_CachedMesh;
            /*0x88*/ UnityEngine.Vector2[] m_CachedUvs;
            /*0x90*/ UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner;
            /*0x98*/ bool <useLegacyMeshGeneration>k__BackingField;

            static /*0x1a4abd4*/ Graphic();
            static /*0x1a47394*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x1a4995c*/ UnityEngine.Mesh get_workerMesh();
            static /*0x1a4a820*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x1a47a4c*/ Graphic();
            /*0x1a47494*/ UnityEngine.Color get_color();
            /*0x1a474a0*/ void set_color(UnityEngine.Color value);
            /*0x1a474e8*/ bool get_raycastTarget();
            /*0x1a474f0*/ void set_raycastTarget(bool value);
            /*0x1a47a20*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x1a47a2c*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x1a47a38*/ bool get_useLegacyMeshGeneration();
            /*0x1a47a40*/ void set_useLegacyMeshGeneration(bool value);
            /*0x1a47b0c*/ void SetAllDirty();
            /*0x1a47b80*/ void SetLayoutDirty();
            /*0x1a47c80*/ void SetVerticesDirty();
            /*0x1a47d18*/ void SetMaterialDirty();
            /*0x1a47db0*/ void OnRectTransformDimensionsChange();
            /*0x1a47e68*/ void OnBeforeTransformParentChanged();
            /*0x1a480c8*/ void OnTransformParentChanged();
            /*0x1a48548*/ int get_depth();
            /*0x1a47c24*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1a475f0*/ UnityEngine.Canvas get_canvas();
            /*0x1a48188*/ void CacheCanvas();
            /*0x1a48568*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x1a485fc*/ UnityEngine.Material get_defaultMaterial();
            /*0x1a48654*/ UnityEngine.Material get_material();
            /*0x1a486e8*/ void set_material(UnityEngine.Material value);
            /*0x1a4878c*/ UnityEngine.Material get_materialForRendering();
            /*0x1a489d8*/ UnityEngine.Texture get_mainTexture();
            /*0x1a48a3c*/ void OnEnable();
            /*0x1a48b90*/ void OnDisable();
            /*0x1a48cf4*/ void OnDestroy();
            /*0x1a48da0*/ void OnCanvasHierarchyChanged();
            /*0x1a48ecc*/ void OnCullingChanged();
            /*0x1a48f64*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x1a49054*/ void LayoutComplete();
            /*0x1a49058*/ void GraphicUpdateComplete();
            /*0x1a4905c*/ void UpdateMaterial();
            /*0x1a49118*/ void UpdateGeometry();
            /*0x1a49528*/ void DoMeshGeneration();
            /*0x1a49128*/ void DoLegacyMeshGeneration();
            /*0x1a49ac0*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x1a49ac4*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x1a49b68*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x1a49f20*/ void OnDidApplyAnimationProperties();
            /*0x1a49f30*/ void SetNativeSize();
            /*0x1a49f34*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x1a4a430*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x1a49de0*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x1a4a584*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x1a4a5a0*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x1a4a848*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x1a4a8ec*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x1a4a968*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x1a4a9e4*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x1a4aa60*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x1a4aadc*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x1a4ab58*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x1a4ac60*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
        }

        class GraphicRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics;
            /*0x20*/ bool m_IgnoreReversedGraphics;
            /*0x24*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects;
            /*0x28*/ UnityEngine.LayerMask m_BlockingMask;
            /*0x30*/ UnityEngine.Canvas m_Canvas;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults;

            static /*0x1a4c168*/ GraphicRaycaster();
            static /*0x1a4bb34*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x1a4adf0*/ GraphicRaycaster();
            /*0x1a4ac68*/ int get_sortOrderPriority();
            /*0x1a4ad5c*/ int get_renderOrderPriority();
            /*0x1a4adbc*/ bool get_ignoreReversedGraphics();
            /*0x1a4adc4*/ void set_ignoreReversedGraphics(bool value);
            /*0x1a4add0*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0x1a4add8*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0x1a4ade0*/ UnityEngine.LayerMask get_blockingMask();
            /*0x1a4ade8*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x1a4acbc*/ UnityEngine.Canvas get_canvas();
            /*0x1a4ae80*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x1a4c094*/ UnityEngine.Camera get_eventCamera();

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

                static /*0x2608250*/ <>c();
                /*0x26082b0*/ <>c();
                /*0x26082b8*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x1a4c518*/ GraphicRegistry();
            static /*0x1a4c38c*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x1a4832c*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1a4780c*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1a47f24*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1a47670*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1a4c448*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x1a4ba64*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x1a4c1f0*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            void OnSiblingGraphicEnabledDisabled();
        }

        interface IMask
        {
            bool Enabled();
            UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            void RecalculateMasking();
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
            /*0xd0*/ UnityEngine.Sprite m_Sprite;
            /*0xd8*/ UnityEngine.Sprite m_OverrideSprite;
            /*0xe0*/ UnityEngine.UI.Image.Type m_Type;
            /*0xe4*/ bool m_PreserveAspect;
            /*0xe5*/ bool m_FillCenter;
            /*0xe8*/ UnityEngine.UI.Image.FillMethod m_FillMethod;
            /*0xec*/ float m_FillAmount;
            /*0xf0*/ bool m_FillClockwise;
            /*0xf4*/ int m_FillOrigin;
            /*0xf8*/ float m_AlphaHitTestMinimumThreshold;
            /*0xfc*/ bool m_Tracked;
            /*0xfd*/ bool m_UseSpriteMesh;
            /*0x100*/ float m_PixelsPerUnitMultiplier;
            /*0x104*/ float m_CachedReferencePixelsPerUnit;

            static /*0x25b1148*/ Image();
            static /*0x25abf04*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x25afebc*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x25afcdc*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x25afff0*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x25b0128*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x25b0f34*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x25af5f8*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x25af810*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x25abeb8*/ Image();
            /*0x25ab51c*/ UnityEngine.Sprite get_sprite();
            /*0x25ab524*/ void set_sprite(UnityEngine.Sprite value);
            /*0x25ab908*/ void DisableSpriteOptimizations();
            /*0x25ab910*/ UnityEngine.Sprite get_overrideSprite();
            /*0x25ab998*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x25ab914*/ UnityEngine.Sprite get_activeSprite();
            /*0x25aba24*/ UnityEngine.UI.Image.Type get_type();
            /*0x25aba2c*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x25abab0*/ bool get_preserveAspect();
            /*0x25abab8*/ void set_preserveAspect(bool value);
            /*0x25abb3c*/ bool get_fillCenter();
            /*0x25abb44*/ void set_fillCenter(bool value);
            /*0x25abbc8*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x25abbd0*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x25abc4c*/ float get_fillAmount();
            /*0x25abc54*/ void set_fillAmount(float value);
            /*0x25abce4*/ bool get_fillClockwise();
            /*0x25abcec*/ void set_fillClockwise(bool value);
            /*0x25abd70*/ int get_fillOrigin();
            /*0x25abd78*/ void set_fillOrigin(int value);
            /*0x25abdfc*/ float get_eventAlphaThreshold();
            /*0x25abe0c*/ void set_eventAlphaThreshold(float value);
            /*0x25abe1c*/ float get_alphaHitTestMinimumThreshold();
            /*0x25abe24*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0x25abe2c*/ bool get_useSpriteMesh();
            /*0x25abe34*/ void set_useSpriteMesh(bool value);
            /*0x25ac004*/ UnityEngine.Texture get_mainTexture();
            /*0x25ac1a8*/ bool get_hasBorder();
            /*0x25ac270*/ float get_pixelsPerUnitMultiplier();
            /*0x25ac278*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x25ac2bc*/ float get_pixelsPerUnit();
            /*0x25ac3d4*/ float get_multipliedPixelsPerUnit();
            /*0x25ac3fc*/ UnityEngine.Material get_material();
            /*0x25ac55c*/ void set_material(UnityEngine.Material value);
            /*0x25ac564*/ void OnBeforeSerialize();
            /*0x25ac568*/ void OnAfterDeserialize();
            /*0x25ac5cc*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x25ac730*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x25aca20*/ void SetNativeSize();
            /*0x25acb9c*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x25ab7f8*/ void TrackSprite();
            /*0x25af768*/ void OnEnable();
            /*0x25af790*/ void OnDisable();
            /*0x25af89c*/ void UpdateMaterial();
            /*0x25af9bc*/ void OnCanvasHierarchyChanged();
            /*0x25accec*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x25ad000*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x25ad3a8*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x25ad9ec*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x25afadc*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x25ae944*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x25b0524*/ void CalculateLayoutInputHorizontal();
            /*0x25b0528*/ void CalculateLayoutInputVertical();
            /*0x25b052c*/ float get_minWidth();
            /*0x25b0534*/ float get_preferredWidth();
            /*0x25b0624*/ float get_flexibleWidth();
            /*0x25b062c*/ float get_minHeight();
            /*0x25b0634*/ float get_preferredHeight();
            /*0x25b0724*/ float get_flexibleHeight();
            /*0x25b072c*/ int get_layoutPriority();
            /*0x25b0734*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x25b0b08*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x25b110c*/ void OnDidApplyAnimationProperties();

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
            /*0xf8*/ UnityEngine.TouchScreenKeyboard m_Keyboard;
            /*0x100*/ UnityEngine.UI.Text m_TextComponent;
            /*0x108*/ UnityEngine.UI.Graphic m_Placeholder;
            /*0x110*/ UnityEngine.UI.InputField.ContentType m_ContentType;
            /*0x114*/ UnityEngine.UI.InputField.InputType m_InputType;
            /*0x118*/ char m_AsteriskChar;
            /*0x11c*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
            /*0x120*/ UnityEngine.UI.InputField.LineType m_LineType;
            /*0x124*/ bool m_HideMobileInput;
            /*0x128*/ UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation;
            /*0x12c*/ int m_CharacterLimit;
            /*0x130*/ UnityEngine.UI.InputField.SubmitEvent m_OnEndEdit;
            /*0x138*/ UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;
            /*0x140*/ UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;
            /*0x148*/ UnityEngine.Color m_CaretColor;
            /*0x158*/ bool m_CustomCaretColor;
            /*0x15c*/ UnityEngine.Color m_SelectionColor;
            /*0x170*/ string m_Text;
            /*0x178*/ float m_CaretBlinkRate;
            /*0x17c*/ int m_CaretWidth;
            /*0x180*/ bool m_ReadOnly;
            /*0x181*/ bool m_ShouldActivateOnSelect;
            /*0x184*/ int m_CaretPosition;
            /*0x188*/ int m_CaretSelectPosition;
            /*0x190*/ UnityEngine.RectTransform caretRectTrans;
            /*0x198*/ UnityEngine.UIVertex[] m_CursorVerts;
            /*0x1a0*/ UnityEngine.TextGenerator m_InputTextCache;
            /*0x1a8*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
            /*0x1b0*/ bool m_PreventFontCallback;
            /*0x1b8*/ UnityEngine.Mesh m_Mesh;
            /*0x1c0*/ bool m_AllowInput;
            /*0x1c1*/ bool m_ShouldActivateNextUpdate;
            /*0x1c2*/ bool m_UpdateDrag;
            /*0x1c3*/ bool m_DragPositionOutOfBounds;
            /*0x1c4*/ bool m_CaretVisible;
            /*0x1c8*/ UnityEngine.Coroutine m_BlinkCoroutine;
            /*0x1d0*/ float m_BlinkStartTime;
            /*0x1d4*/ int m_DrawStart;
            /*0x1d8*/ int m_DrawEnd;
            /*0x1e0*/ UnityEngine.Coroutine m_DragCoroutine;
            /*0x1e8*/ string m_OriginalText;
            /*0x1f0*/ bool m_WasCanceled;
            /*0x1f1*/ bool m_HasDoneFocusTransition;
            /*0x1f8*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
            /*0x200*/ bool m_TouchKeyboardAllowsInPlaceEditing;
            /*0x201*/ bool m_IsCompositionActive;
            /*0x208*/ UnityEngine.Event m_ProcessingEvent;

            static /*0x25ba920*/ InputField();
            static /*0x25b3b64*/ string get_clipboard();
            static /*0x25b3bc0*/ void set_clipboard(string value);
            static /*0x25b8b98*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x25b5a9c*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x25b144c*/ InputField();
            /*0x25b1264*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x25b13ac*/ string get_compositionString();
            /*0x25b16c4*/ UnityEngine.Mesh get_mesh();
            /*0x25b1770*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x25b17d8*/ void set_shouldHideMobileInput(bool value);
            /*0x25b1834*/ bool get_shouldHideMobileInput();
            /*0x25b1888*/ void set_shouldActivateOnSelect(bool value);
            /*0x25b1894*/ bool get_shouldActivateOnSelect();
            /*0x25b18c4*/ string get_text();
            /*0x25b18cc*/ void set_text(string value);
            /*0x25b1bf4*/ void SetTextWithoutNotify(string input);
            /*0x25b18d4*/ void SetText(string value, bool sendCallback);
            /*0x25b20f8*/ bool get_isFocused();
            /*0x25b2100*/ float get_caretBlinkRate();
            /*0x25b2108*/ void set_caretBlinkRate(float value);
            /*0x25b21e8*/ int get_caretWidth();
            /*0x25b21f0*/ void set_caretWidth(int value);
            /*0x25b22cc*/ UnityEngine.UI.Text get_textComponent();
            /*0x25b22d4*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x25b2578*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x25b2580*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x25b25dc*/ UnityEngine.Color get_caretColor();
            /*0x25b2624*/ void set_caretColor(UnityEngine.Color value);
            /*0x25b2660*/ bool get_customCaretColor();
            /*0x25b2668*/ void set_customCaretColor(bool value);
            /*0x25b268c*/ UnityEngine.Color get_selectionColor();
            /*0x25b26a0*/ void set_selectionColor(UnityEngine.Color value);
            /*0x25b26dc*/ UnityEngine.UI.InputField.SubmitEvent get_onEndEdit();
            /*0x25b26e4*/ void set_onEndEdit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x25b2740*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x25b2748*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x25b27a8*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x25b274c*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x25b27b0*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x25b27b8*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x25b2814*/ int get_characterLimit();
            /*0x25b281c*/ void set_characterLimit(int value);
            /*0x25b28e8*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x25b28f0*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x25b2a20*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x25b2a28*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x25b2b64*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x25b2b6c*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x25b2c0c*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x25b2c14*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x25b2c1c*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x25b2ca4*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x25b2cac*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x25b2d34*/ bool get_readOnly();
            /*0x25b2d3c*/ void set_readOnly(bool value);
            /*0x25b2d48*/ bool get_multiLine();
            /*0x25b2d5c*/ char get_asteriskChar();
            /*0x25b2d64*/ void set_asteriskChar(char value);
            /*0x25b2ddc*/ bool get_wasCanceled();
            /*0x25b2de4*/ void ClampPos(ref int pos);
            /*0x25b2e1c*/ int get_caretPositionInternal();
            /*0x25b2e4c*/ void set_caretPositionInternal(int value);
            /*0x25b2e84*/ int get_caretSelectPositionInternal();
            /*0x25b2eb4*/ void set_caretSelectPositionInternal(int value);
            /*0x25b2eec*/ bool get_hasSelection();
            /*0x25b2f20*/ int get_caretPosition();
            /*0x25b2f50*/ void set_caretPosition(int value);
            /*0x25b303c*/ int get_selectionAnchorPosition();
            /*0x25b2f7c*/ void set_selectionAnchorPosition(int value);
            /*0x25b306c*/ int get_selectionFocusPosition();
            /*0x25b2fdc*/ void set_selectionFocusPosition(int value);
            /*0x25b309c*/ void Awake();
            /*0x25b3178*/ void OnEnable();
            /*0x25b340c*/ void OnDisable();
            /*0x25b380c*/ System.Collections.IEnumerator CaretBlink();
            /*0x25b3878*/ void SetCaretVisible();
            /*0x25b2188*/ void SetCaretActive();
            /*0x25b38b8*/ void UpdateCaretMaterial();
            /*0x25b39f0*/ void OnFocus();
            /*0x25b39f4*/ void SelectAll();
            /*0x25b3a40*/ void MoveTextEnd(bool shift);
            /*0x25b3adc*/ void MoveTextStart(bool shift);
            /*0x25b3c24*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x25b3cbc*/ bool InPlaceEditing();
            /*0x25b3cf8*/ bool InPlaceEditingChanged();
            /*0x25b3d88*/ void UpdateCaretFromKeyboard();
            /*0x25b3e74*/ void LateUpdate();
            /*0x25b535c*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x25b55bc*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x25b57ec*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x25b5c30*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b5d1c*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b5d48*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b5f0c*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b5f84*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b5fac*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b61b8*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x25b6cb8*/ bool IsValidChar(char c);
            /*0x25b6d38*/ void ProcessEvent(UnityEngine.Event e);
            /*0x25b6d3c*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x25b676c*/ string GetSelectedString();
            /*0x25b6ebc*/ int FindtNextWordBegin();
            /*0x25b6b68*/ void MoveRight(bool shift, bool ctrl);
            /*0x25b6f8c*/ int FindtPrevWordBegin();
            /*0x25b6a30*/ void MoveLeft(bool shift, bool ctrl);
            /*0x25b7040*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x25b715c*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x25b74e0*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x25b6cac*/ void MoveDown(bool shift);
            /*0x25b77c0*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x25b6ca0*/ void MoveUp(bool shift);
            /*0x25b7900*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x25b6818*/ void Delete();
            /*0x25b66c4*/ void ForwardSpace();
            /*0x25b65d4*/ void Backspace();
            /*0x25b7a4c*/ void Insert(char c);
            /*0x25b69d8*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x25b5338*/ void SendOnValueChangedAndUpdateLabel();
            /*0x25b1bfc*/ void SendOnValueChanged();
            /*0x25b7b38*/ void SendOnSubmit();
            /*0x25b7bbc*/ void Append(string input);
            /*0x25b7c7c*/ void Append(char input);
            /*0x25b1c80*/ void UpdateLabel();
            /*0x25b8b28*/ bool IsSelectionVisible();
            /*0x25b7f04*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x25b8d08*/ void ForceLabelUpdate();
            /*0x25b2268*/ void MarkGeometryAsDirty();
            /*0x25b8d0c*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x25b91a0*/ void LayoutComplete();
            /*0x25b91a4*/ void GraphicUpdateComplete();
            /*0x25b8d1c*/ void UpdateGeometry();
            /*0x25b47d4*/ void AssignPositioningIfNeeded();
            /*0x25b91a8*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x25b93c0*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x25ba2b8*/ void CreateCursorVerts();
            /*0x25b9aec*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x25b4ce0*/ char Validate(string text, int pos, char ch);
            /*0x25ba3f4*/ void ActivateInputField();
            /*0x25b442c*/ void ActivateInputFieldInternal();
            /*0x25ba530*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x25ba57c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x25b3668*/ void DeactivateInputField();
            /*0x25ba59c*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x25ba5cc*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x25b2968*/ void EnforceContentType();
            /*0x25b1618*/ void EnforceTextHOverflow();
            /*0x25b2af4*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x25b2bf4*/ void SetToCustom();
            /*0x25ba620*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x25ba64c*/ void CalculateLayoutInputHorizontal();
            /*0x25ba650*/ void CalculateLayoutInputVertical();
            /*0x25ba654*/ float get_minWidth();
            /*0x25ba65c*/ float get_preferredWidth();
            /*0x25ba798*/ float get_flexibleWidth();
            /*0x25ba7a0*/ float get_minHeight();
            /*0x25ba7a8*/ float get_preferredHeight();
            /*0x25ba910*/ float get_flexibleHeight();
            /*0x25ba918*/ int get_layoutPriority();
            /*0x25ba9c4*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x260880c*/ OnValidateInput(object object, nint method);
                /*0x260886c*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x2608c2c*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x2608cf0*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x2608d1c*/ SubmitEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x26087c0*/ OnChangeEvent();
            }

            enum EditState
            {
                Continue = 0,
                Finish = 1,
            }

            class <CaretBlink>d__166 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.InputField <>4__this;

                /*0x2608310*/ <CaretBlink>d__166(int <>1__state);
                /*0x260833c*/ void System.IDisposable.Dispose();
                /*0x2608340*/ bool MoveNext();
                /*0x2608450*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2608458*/ void System.Collections.IEnumerator.Reset();
                /*0x2608498*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__188 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x26084a0*/ <MouseDragOutsideRect>d__188(int <>1__state);
                /*0x26084cc*/ void System.IDisposable.Dispose();
                /*0x26084d0*/ bool MoveNext();
                /*0x2608770*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2608778*/ void System.Collections.IEnumerator.Reset();
                /*0x26087b8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class AspectRatioFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode;
            /*0x1c*/ float m_AspectRatio;
            /*0x20*/ UnityEngine.RectTransform m_Rect;
            /*0x28*/ bool m_DelayedSetDirty;
            /*0x29*/ bool m_DoesParentExist;
            /*0x2a*/ UnityEngine.DrivenRectTransformTracker m_Tracker;

            /*0x1a36d98*/ AspectRatioFitter();
            /*0x1a36bf4*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x1a36bfc*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x1a36c78*/ float get_aspectRatio();
            /*0x1a36c80*/ void set_aspectRatio(float value);
            /*0x1a36cf8*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1a36da8*/ void OnEnable();
            /*0x1a36e4c*/ void Start();
            /*0x1a36fac*/ void OnDisable();
            /*0x1a37038*/ void OnTransformParentChanged();
            /*0x1a370dc*/ void Update();
            /*0x1a370f0*/ void OnRectTransformDimensionsChange();
            /*0x1a370f4*/ void UpdateRect();
            /*0x1a3745c*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x1a3736c*/ UnityEngine.Vector2 GetParentSize();
            /*0x1a37510*/ void SetLayoutHorizontal();
            /*0x1a37514*/ void SetLayoutVertical();
            /*0x1a36c74*/ void SetDirty();
            /*0x1a36eac*/ bool IsComponentValidOnObject();
            /*0x1a36f84*/ bool IsAspectModeValid();
            /*0x1a37518*/ bool DoesParentExists();

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
            /*0x18*/ UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode;
            /*0x1c*/ float m_ReferencePixelsPerUnit;
            /*0x20*/ float m_ScaleFactor;
            /*0x24*/ UnityEngine.Vector2 m_ReferenceResolution;
            /*0x2c*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode;
            /*0x30*/ float m_MatchWidthOrHeight;
            /*0x34*/ UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit;
            /*0x38*/ float m_FallbackScreenDPI;
            /*0x3c*/ float m_DefaultSpriteDPI;
            /*0x40*/ float m_DynamicPixelsPerUnit;
            /*0x48*/ UnityEngine.Canvas m_Canvas;
            /*0x50*/ float m_PrevScaleFactor;
            /*0x54*/ float m_PrevReferencePixelsPerUnit;
            /*0x58*/ bool m_PresetInfoIsWorld;

            /*0x1a39610*/ CanvasScaler();
            /*0x1a3949c*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x1a394a4*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x1a394ac*/ float get_referencePixelsPerUnit();
            /*0x1a394b4*/ void set_referencePixelsPerUnit(float value);
            /*0x1a394bc*/ float get_scaleFactor();
            /*0x1a394c4*/ void set_scaleFactor(float value);
            /*0x1a394f8*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x1a39500*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x1a39588*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x1a39590*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x1a39598*/ float get_matchWidthOrHeight();
            /*0x1a395a0*/ void set_matchWidthOrHeight(float value);
            /*0x1a395a8*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x1a395b0*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0x1a395b8*/ float get_fallbackScreenDPI();
            /*0x1a395c0*/ void set_fallbackScreenDPI(float value);
            /*0x1a395c8*/ float get_defaultSpriteDPI();
            /*0x1a395d0*/ void set_defaultSpriteDPI(float value);
            /*0x1a39600*/ float get_dynamicPixelsPerUnit();
            /*0x1a39608*/ void set_dynamicPixelsPerUnit(float value);
            /*0x1a3964c*/ void OnEnable();
            /*0x1a3970c*/ void Canvas_preWillRenderCanvases();
            /*0x1a3971c*/ void OnDisable();
            /*0x1a39858*/ void Handle();
            /*0x1a39960*/ void HandleWorldCanvas();
            /*0x1a3998c*/ void HandleConstantPixelSize();
            /*0x1a399b8*/ void HandleScaleWithScreenSize();
            /*0x1a39b90*/ void HandleConstantPhysicalSize();
            /*0x1a397c0*/ void SetScaleFactor(float scaleFactor);
            /*0x1a3980c*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

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
            /*0x18*/ UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit;
            /*0x1c*/ UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit;
            /*0x20*/ UnityEngine.RectTransform m_Rect;
            /*0x28*/ UnityEngine.DrivenRectTransformTracker m_Tracker;

            /*0x1a3c3bc*/ ContentSizeFitter();
            /*0x1a3c188*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x1a3c190*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x1a3c29c*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x1a3c2a4*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x1a3c31c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1a3c3c4*/ void OnEnable();
            /*0x1a3c3ec*/ void OnDisable();
            /*0x1a3c478*/ void OnRectTransformDimensionsChange();
            /*0x1a3c47c*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x1a3c54c*/ void SetLayoutHorizontal();
            /*0x1a3c57c*/ void SetLayoutVertical();
            /*0x1a3c208*/ void SetDirty();

            enum FitMode
            {
                Unconstrained = 0,
                MinSize = 1,
                PreferredSize = 2,
            }
        }

        class GridLayoutGroup : UnityEngine.UI.LayoutGroup
        {
            /*0x58*/ UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner;
            /*0x5c*/ UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis;
            /*0x60*/ UnityEngine.Vector2 m_CellSize;
            /*0x68*/ UnityEngine.Vector2 m_Spacing;
            /*0x70*/ UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint;
            /*0x74*/ int m_ConstraintCount;

            /*0x1a4c834*/ GridLayoutGroup();
            /*0x1a4c5a0*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x1a4c5a8*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x1a4c608*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x1a4c610*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x1a4c670*/ UnityEngine.Vector2 get_cellSize();
            /*0x1a4c678*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x1a4c6e0*/ UnityEngine.Vector2 get_spacing();
            /*0x1a4c6e8*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x1a4c750*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x1a4c758*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x1a4c7b8*/ int get_constraintCount();
            /*0x1a4c7c0*/ void set_constraintCount(int value);
            /*0x1a4c878*/ void CalculateLayoutInputHorizontal();
            /*0x1a4c9d0*/ void CalculateLayoutInputVertical();
            /*0x1a4cb58*/ void SetLayoutHorizontal();
            /*0x1a4d0fc*/ void SetLayoutVertical();
            /*0x1a4cb60*/ void SetCellsAlongAxis(int axis);

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
            /*0x1a4d104*/ HorizontalLayoutGroup();
            /*0x1a4d124*/ void CalculateLayoutInputHorizontal();
            /*0x1a4d3d8*/ void CalculateLayoutInputVertical();
            /*0x1a4d3e4*/ void SetLayoutHorizontal();
            /*0x1a4d9b0*/ void SetLayoutVertical();
        }

        class HorizontalOrVerticalLayoutGroup : UnityEngine.UI.LayoutGroup
        {
            /*0x58*/ float m_Spacing;
            /*0x5c*/ bool m_ChildForceExpandWidth;
            /*0x5d*/ bool m_ChildForceExpandHeight;
            /*0x5e*/ bool m_ChildControlWidth;
            /*0x5f*/ bool m_ChildControlHeight;
            /*0x60*/ bool m_ChildScaleWidth;
            /*0x61*/ bool m_ChildScaleHeight;
            /*0x62*/ bool m_ReverseArrangement;

            /*0x1a4d114*/ HorizontalOrVerticalLayoutGroup();
            /*0x1a4d9bc*/ float get_spacing();
            /*0x1a4d9c4*/ void set_spacing(float value);
            /*0x1a4da24*/ bool get_childForceExpandWidth();
            /*0x1a4da2c*/ void set_childForceExpandWidth(bool value);
            /*0x1a4da8c*/ bool get_childForceExpandHeight();
            /*0x1a4da94*/ void set_childForceExpandHeight(bool value);
            /*0x1a4daf4*/ bool get_childControlWidth();
            /*0x1a4dafc*/ void set_childControlWidth(bool value);
            /*0x1a4db5c*/ bool get_childControlHeight();
            /*0x1a4db64*/ void set_childControlHeight(bool value);
            /*0x1a4dbc4*/ bool get_childScaleWidth();
            /*0x1a4dbcc*/ void set_childScaleWidth(bool value);
            /*0x1a4dc2c*/ bool get_childScaleHeight();
            /*0x1a4dc34*/ void set_childScaleHeight(bool value);
            /*0x1a4dc94*/ bool get_reverseArrangement();
            /*0x1a4dc9c*/ void set_reverseArrangement(bool value);
            /*0x1a4d154*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x1a4d3f0*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x1a4dcfc*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
        }

        interface ILayoutElement
        {
            void CalculateLayoutInputHorizontal();
            void CalculateLayoutInputVertical();
            float get_minWidth();
            float get_preferredWidth();
            float get_flexibleWidth();
            float get_minHeight();
            float get_preferredHeight();
            float get_flexibleHeight();
            int get_layoutPriority();
        }

        interface ILayoutController
        {
            void SetLayoutHorizontal();
            void SetLayoutVertical();
        }

        interface ILayoutGroup : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutSelfController : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutIgnorer
        {
            bool get_ignoreLayout();
        }

        class LayoutElement : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutIgnorer
        {
            /*0x18*/ bool m_IgnoreLayout;
            /*0x1c*/ float m_MinWidth;
            /*0x20*/ float m_MinHeight;
            /*0x24*/ float m_PreferredWidth;
            /*0x28*/ float m_PreferredHeight;
            /*0x2c*/ float m_FlexibleWidth;
            /*0x30*/ float m_FlexibleHeight;
            /*0x34*/ int m_LayoutPriority;

            /*0x25bae98*/ LayoutElement();
            /*0x25ba9cc*/ bool get_ignoreLayout();
            /*0x25ba9d4*/ void set_ignoreLayout(bool value);
            /*0x25bab10*/ void CalculateLayoutInputHorizontal();
            /*0x25bab14*/ void CalculateLayoutInputVertical();
            /*0x25bab18*/ float get_minWidth();
            /*0x25bab20*/ void set_minWidth(float value);
            /*0x25bab98*/ float get_minHeight();
            /*0x25baba0*/ void set_minHeight(float value);
            /*0x25bac18*/ float get_preferredWidth();
            /*0x25bac20*/ void set_preferredWidth(float value);
            /*0x25bac98*/ float get_preferredHeight();
            /*0x25baca0*/ void set_preferredHeight(float value);
            /*0x25bad18*/ float get_flexibleWidth();
            /*0x25bad20*/ void set_flexibleWidth(float value);
            /*0x25bad98*/ float get_flexibleHeight();
            /*0x25bada0*/ void set_flexibleHeight(float value);
            /*0x25bae18*/ int get_layoutPriority();
            /*0x25bae20*/ void set_layoutPriority(int value);
            /*0x25baebc*/ void OnEnable();
            /*0x25baee4*/ void OnTransformParentChanged();
            /*0x25baee8*/ void OnDisable();
            /*0x25baf10*/ void OnDidApplyAnimationProperties();
            /*0x25baf14*/ void OnBeforeTransformParentChanged();
            /*0x25baa4c*/ void SetDirty();
        }

        class LayoutGroup : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.RectOffset m_Padding;
            /*0x20*/ UnityEngine.TextAnchor m_ChildAlignment;
            /*0x28*/ UnityEngine.RectTransform m_Rect;
            /*0x30*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x34*/ UnityEngine.Vector2 m_TotalMinSize;
            /*0x3c*/ UnityEngine.Vector2 m_TotalPreferredSize;
            /*0x44*/ UnityEngine.Vector2 m_TotalFlexibleSize;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren;

            /*0x25bb900*/ LayoutGroup();
            /*0x25bb36c*/ UnityEngine.RectOffset get_padding();
            /*0x25bb374*/ void set_padding(UnityEngine.RectOffset value);
            /*0x25bb3d4*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x25bb3dc*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x25bb43c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x25bb4dc*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x25bb4e4*/ void CalculateLayoutInputHorizontal();
            void CalculateLayoutInputVertical();
            /*0x25bb874*/ float get_minWidth();
            /*0x25bb890*/ float get_preferredWidth();
            /*0x25bb8ac*/ float get_flexibleWidth();
            /*0x25bb8c8*/ float get_minHeight();
            /*0x25bb8d8*/ float get_preferredHeight();
            /*0x25bb8e8*/ float get_flexibleHeight();
            /*0x25bb8f8*/ int get_layoutPriority();
            void SetLayoutHorizontal();
            void SetLayoutVertical();
            /*0x25bb9f4*/ void OnEnable();
            /*0x25bbb14*/ void OnDisable();
            /*0x25bbb9c*/ void OnDidApplyAnimationProperties();
            /*0x25bb884*/ float GetTotalMinSize(int axis);
            /*0x25bb8a0*/ float GetTotalPreferredSize(int axis);
            /*0x25bb8bc*/ float GetTotalFlexibleSize(int axis);
            /*0x25bbba0*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x25bbcc4*/ float GetAlignmentOnAxis(int axis);
            /*0x25bbd10*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x25bbd70*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x25bbe24*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x25bbfc0*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x25bc07c*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x25bc22c*/ bool get_isRootLayoutGroup();
            /*0x25bc38c*/ void OnRectTransformDimensionsChange();
            /*0x25bc3cc*/ void OnTransformChildrenChanged();
            void SetProperty<T>(ref T currentValue, T newValue);
            /*0x25bba1c*/ void SetDirty();
            /*0x25bc3d0*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x2608d68*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x2608d94*/ void System.IDisposable.Dispose();
                /*0x2608d98*/ bool MoveNext();
                /*0x2608e30*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2608e38*/ void System.Collections.IEnumerator.Reset();
                /*0x2608e78*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.UI.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x25bc488*/ LayoutRebuilder();
            static /*0x25bc5f4*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x25bc6c8*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x25bc7e8*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x25baf18*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x25bd3ac*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x25bd5c0*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x25bd8a4*/ LayoutRebuilder();
            /*0x25bc43c*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x25bc47c*/ void Clear();
            /*0x25bc654*/ UnityEngine.Transform get_transform();
            /*0x25bc65c*/ bool IsDestroyed();
            /*0x25bc8d8*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x25bcf4c*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x25bcc00*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x25bd748*/ void LayoutComplete();
            /*0x25bd7d4*/ void GraphicUpdateComplete();
            /*0x25bd7d8*/ int GetHashCode();
            /*0x25bd7e0*/ bool Equals(object obj);
            /*0x25bd834*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x2608e80*/ <>c();
                /*0x2608ee0*/ <>c();
                /*0x2608ee8*/ void <.cctor>b__5_0(UnityEngine.UI.LayoutRebuilder x);
                /*0x2608f04*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x2608f94*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x260905c*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x2609124*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x26091f0*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x212bb08*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x212bd44*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x212c0f8*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x212bc2c*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x212bf24*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x212c21c*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x212bb14*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x212bd50*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x212c104*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x212c334*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x212c358*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

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

                static /*0x26092bc*/ <>c();
                /*0x260931c*/ <>c();
                /*0x2609324*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x26093d0*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x260947c*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x2609528*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x26095d4*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x2609680*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x260972c*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x26097d8*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x2607948*/ VerticalLayoutGroup();
            /*0x2607950*/ void CalculateLayoutInputHorizontal();
            /*0x2607984*/ void CalculateLayoutInputVertical();
            /*0x2607994*/ void SetLayoutHorizontal();
            /*0x26079a4*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x18*/ UnityEngine.RectTransform m_RectTransform;
            /*0x20*/ bool m_ShowMaskGraphic;
            /*0x28*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x30*/ UnityEngine.Material m_MaskMaterial;
            /*0x38*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x212c858*/ Mask();
            /*0x212c6c4*/ UnityEngine.RectTransform get_rectTransform();
            /*0x212c720*/ bool get_showMaskGraphic();
            /*0x212c728*/ void set_showMaskGraphic(bool value);
            /*0x212c7fc*/ UnityEngine.UI.Graphic get_graphic();
            /*0x212c868*/ bool MaskEnabled();
            /*0x212c904*/ void OnSiblingGraphicEnabledDisabled();
            /*0x212c908*/ void OnEnable();
            /*0x212cd30*/ void OnDisable();
            /*0x212cf08*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x212cfcc*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class MaskUtilities
        {
            static /*0x212d71c*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x212ca90*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x212d288*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x212d448*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x212d9c0*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x212db3c*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x212dfb8*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x212e344*/ MaskUtilities();
        }

        class MaskableGraphic : UnityEngine.UI.Graphic, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier
        {
            /*0x99*/ bool m_ShouldRecalculateStencil;
            /*0xa0*/ UnityEngine.Material m_MaskMaterial;
            /*0xa8*/ UnityEngine.UI.RectMask2D m_ParentMask;
            /*0xb0*/ bool m_Maskable;
            /*0xb1*/ bool m_IsMaskingGraphic;
            /*0xb2*/ bool m_IncludeForMasking;
            /*0xb8*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;
            /*0xc0*/ bool m_ShouldRecalculate;
            /*0xc4*/ int m_StencilValue;
            /*0xc8*/ UnityEngine.Vector3[] m_Corners;

            /*0x212f000*/ MaskableGraphic();
            /*0x212e34c*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x212e354*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x212e35c*/ bool get_maskable();
            /*0x212e364*/ void set_maskable(bool value);
            /*0x212e39c*/ bool get_isMaskingGraphic();
            /*0x212ca70*/ void set_isMaskingGraphic(bool value);
            /*0x212e3a4*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x212e4b8*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x212e7b0*/ void UpdateCull(bool cull);
            /*0x212e89c*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x212e918*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x212e954*/ void OnEnable();
            /*0x212eb1c*/ void OnDisable();
            /*0x212ebd4*/ void OnTransformParentChanged();
            /*0x212ec34*/ void ParentMaskStateChanged();
            /*0x212ec38*/ void OnCanvasHierarchyChanged();
            /*0x212e518*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x212e9b4*/ void UpdateClipParent();
            /*0x212ef74*/ void RecalculateClipping();
            /*0x212ef78*/ void RecalculateMasking();
            /*0x212f0cc*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x2609884*/ CullStateChangedEvent();
            }
        }

        interface IMaterialModifier
        {
            UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x212f0d4*/ void Destroy(UnityEngine.Object obj);
            static /*0x212f1f0*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x212f2c4*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x212f33c*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x212f848*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0xae1b20*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0xae1b28*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0xae1b30*/ bool get_wrapAround();
            /*0xae1b38*/ void set_wrapAround(bool value);
            /*0xae1b44*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0xae1b4c*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0xae1b54*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0xae1b5c*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0xae1b64*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0xae1b6c*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0xae1b74*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0xae1b7c*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0xae1b84*/ bool Equals(UnityEngine.UI.Navigation other);

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
            /*0xd0*/ UnityEngine.Texture m_Texture;
            /*0xd8*/ UnityEngine.Rect m_UVRect;

            /*0x213309c*/ RawImage();
            /*0x21330f4*/ UnityEngine.Texture get_mainTexture();
            /*0x213327c*/ UnityEngine.Texture get_texture();
            /*0x2133284*/ void set_texture(UnityEngine.Texture value);
            /*0x213333c*/ UnityEngine.Rect get_uvRect();
            /*0x2133348*/ void set_uvRect(UnityEngine.Rect value);
            /*0x21333d8*/ void SetNativeSize();
            /*0x2133550*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x2133998*/ void OnDidApplyAnimationProperties();
        }

        class RectMask2D : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IClipper, UnityEngine.ICanvasRaycastFilter
        {
            /*0x18*/ UnityEngine.UI.RectangularVertexClipper m_VertexClipper;
            /*0x20*/ UnityEngine.RectTransform m_RectTransform;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets;
            /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets;
            /*0x38*/ bool m_ShouldRecalculateClipRects;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers;
            /*0x48*/ UnityEngine.Rect m_LastClipRectCanvasSpace;
            /*0x58*/ bool m_ForceClip;
            /*0x5c*/ UnityEngine.Vector4 m_Padding;
            /*0x6c*/ UnityEngine.Vector2Int m_Softness;
            /*0x78*/ UnityEngine.Canvas m_Canvas;
            /*0x80*/ UnityEngine.Vector3[] m_Corners;

            /*0x21341c0*/ RectMask2D();
            /*0x2133da4*/ UnityEngine.Vector4 get_padding();
            /*0x2133db0*/ void set_padding(UnityEngine.Vector4 value);
            /*0x2133dbc*/ UnityEngine.Vector2Int get_softness();
            /*0x2133dc4*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x2133e0c*/ UnityEngine.Canvas get_Canvas();
            /*0x2133f88*/ UnityEngine.Rect get_canvasRect();
            /*0x2133fd4*/ UnityEngine.RectTransform get_rectTransform();
            /*0x2134370*/ void OnEnable();
            /*0x21343ac*/ void OnDisable();
            /*0x2134468*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x213455c*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x2134690*/ void PerformClipping();
            /*0x2134ea0*/ void UpdateClipSoftness();
            /*0x212ee4c*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x212ec98*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x21351b0*/ void OnTransformParentChanged();
            /*0x21351e0*/ void OnCanvasHierarchyChanged();
        }

        class ScrollRect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.RectTransform m_Content;
            /*0x20*/ bool m_Horizontal;
            /*0x21*/ bool m_Vertical;
            /*0x24*/ UnityEngine.UI.ScrollRect.MovementType m_MovementType;
            /*0x28*/ float m_Elasticity;
            /*0x2c*/ bool m_Inertia;
            /*0x30*/ float m_DecelerationRate;
            /*0x34*/ float m_ScrollSensitivity;
            /*0x38*/ UnityEngine.RectTransform m_Viewport;
            /*0x40*/ UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
            /*0x48*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
            /*0x50*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;
            /*0x54*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;
            /*0x58*/ float m_HorizontalScrollbarSpacing;
            /*0x5c*/ float m_VerticalScrollbarSpacing;
            /*0x60*/ UnityEngine.UI.ScrollRect.ScrollRectEvent m_OnValueChanged;
            /*0x68*/ UnityEngine.Vector2 m_PointerStartLocalCursor;
            /*0x70*/ UnityEngine.Vector2 m_ContentStartPosition;
            /*0x78*/ UnityEngine.RectTransform m_ViewRect;
            /*0x80*/ UnityEngine.Bounds m_ContentBounds;
            /*0x98*/ UnityEngine.Bounds m_ViewBounds;
            /*0xb0*/ UnityEngine.Vector2 m_Velocity;
            /*0xb8*/ bool m_Dragging;
            /*0xb9*/ bool m_Scrolling;
            /*0xbc*/ UnityEngine.Vector2 m_PrevPosition;
            /*0xc4*/ UnityEngine.Bounds m_PrevContentBounds;
            /*0xdc*/ UnityEngine.Bounds m_PrevViewBounds;
            /*0xf4*/ bool m_HasRebuiltLayout;
            /*0xf5*/ bool m_HSliderExpand;
            /*0xf6*/ bool m_VSliderExpand;
            /*0xf8*/ float m_HSliderHeight;
            /*0xfc*/ float m_VSliderWidth;
            /*0x100*/ UnityEngine.RectTransform m_Rect;
            /*0x108*/ UnityEngine.RectTransform m_HorizontalScrollbarRect;
            /*0x110*/ UnityEngine.RectTransform m_VerticalScrollbarRect;
            /*0x118*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x120*/ UnityEngine.Vector3[] m_Corners;

            static /*0x2137cbc*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x21392f8*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x21393f8*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x21394ac*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x213964c*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x213659c*/ ScrollRect();
            /*0x2135e40*/ UnityEngine.RectTransform get_content();
            /*0x2135e48*/ void set_content(UnityEngine.RectTransform value);
            /*0x2135e50*/ bool get_horizontal();
            /*0x2135e58*/ void set_horizontal(bool value);
            /*0x2135e64*/ bool get_vertical();
            /*0x2135e6c*/ void set_vertical(bool value);
            /*0x2135e78*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0x2135e80*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x2135e88*/ float get_elasticity();
            /*0x2135e90*/ void set_elasticity(float value);
            /*0x2135e98*/ bool get_inertia();
            /*0x2135ea0*/ void set_inertia(bool value);
            /*0x2135eac*/ float get_decelerationRate();
            /*0x2135eb4*/ void set_decelerationRate(float value);
            /*0x2135ebc*/ float get_scrollSensitivity();
            /*0x2135ec4*/ void set_scrollSensitivity(float value);
            /*0x2135ecc*/ UnityEngine.RectTransform get_viewport();
            /*0x2135ed4*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x2135fa4*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x2135fac*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x2136158*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x2136160*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x213630c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x2136314*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x213631c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x2136324*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x213632c*/ float get_horizontalScrollbarSpacing();
            /*0x2136334*/ void set_horizontalScrollbarSpacing(float value);
            /*0x21363d0*/ float get_verticalScrollbarSpacing();
            /*0x21363d8*/ void set_verticalScrollbarSpacing(float value);
            /*0x21363e0*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0x21363e8*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x21363f0*/ UnityEngine.RectTransform get_viewRect();
            /*0x21364ec*/ UnityEngine.Vector2 get_velocity();
            /*0x21364f4*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x21364fc*/ UnityEngine.RectTransform get_rectTransform();
            /*0x2136674*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x2137204*/ void LayoutComplete();
            /*0x2137208*/ void GraphicUpdateComplete();
            /*0x21366d4*/ void UpdateCachedData();
            /*0x213720c*/ void OnEnable();
            /*0x21373f0*/ void OnDisable();
            /*0x2137634*/ bool IsActive();
            /*0x21376c0*/ void EnsureLayoutHasRebuilt();
            /*0x2137740*/ void StopMovement();
            /*0x2137768*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x2137920*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2137958*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2137a5c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2137a80*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2137d0c*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x2137dd0*/ void LateUpdate();
            /*0x213714c*/ void UpdatePrevData();
            /*0x2136f78*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x2138324*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x213863c*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x2138430*/ float get_horizontalNormalizedPosition();
            /*0x2138690*/ void set_horizontalNormalizedPosition(float value);
            /*0x213853c*/ float get_verticalNormalizedPosition();
            /*0x21386a4*/ void set_verticalNormalizedPosition(float value);
            /*0x21386b8*/ void SetHorizontalNormalizedPosition(float value);
            /*0x21386cc*/ void SetVerticalNormalizedPosition(float value);
            /*0x21386e0*/ void SetNormalizedPosition(float value, int axis);
            /*0x21388a8*/ void OnRectTransformDimensionsChange();
            /*0x21388ac*/ bool get_hScrollingNeeded();
            /*0x2138914*/ bool get_vScrollingNeeded();
            /*0x213897c*/ void CalculateLayoutInputHorizontal();
            /*0x2138980*/ void CalculateLayoutInputVertical();
            /*0x2138984*/ float get_minWidth();
            /*0x213898c*/ float get_preferredWidth();
            /*0x2138994*/ float get_flexibleWidth();
            /*0x213899c*/ float get_minHeight();
            /*0x21389a4*/ float get_preferredHeight();
            /*0x21389ac*/ float get_flexibleHeight();
            /*0x21389b4*/ int get_layoutPriority();
            /*0x21389bc*/ void SetLayoutHorizontal();
            /*0x2138f94*/ void SetLayoutVertical();
            /*0x2138360*/ void UpdateScrollbarVisibility();
            /*0x213907c*/ void UpdateScrollbarLayout();
            /*0x2136aa8*/ void UpdateBounds();
            /*0x2138e94*/ UnityEngine.Bounds GetBounds();
            /*0x21378e4*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x213633c*/ void SetDirty();
            /*0x2135edc*/ void SetDirtyCaching();
            /*0x21397b4*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x260b884*/ ScrollRectEvent();
            }
        }

        class Scrollbar : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.RectTransform m_HandleRect;
            /*0x100*/ UnityEngine.UI.Scrollbar.Direction m_Direction;
            /*0x104*/ float m_Value;
            /*0x108*/ float m_Size;
            /*0x10c*/ int m_NumberOfSteps;
            /*0x110*/ UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged;
            /*0x118*/ UnityEngine.RectTransform m_ContainerRect;
            /*0x120*/ UnityEngine.Vector2 m_Offset;
            /*0x128*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x130*/ UnityEngine.Coroutine m_PointerDownRepeat;
            /*0x138*/ bool isPointerDownAndNotDragging;
            /*0x139*/ bool m_DelayedUpdateVisuals;

            /*0x2139b50*/ Scrollbar();
            /*0x21397bc*/ UnityEngine.RectTransform get_handleRect();
            /*0x21397c4*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x2139ad0*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x2139ad8*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x2139d20*/ float get_value();
            /*0x2138534*/ void set_value(float value);
            /*0x2139ec0*/ void SetValueWithoutNotify(float input);
            /*0x2139ec8*/ float get_size();
            /*0x21383ac*/ void set_size(float value);
            /*0x2139ed0*/ int get_numberOfSteps();
            /*0x2139ed8*/ void set_numberOfSteps(int value);
            /*0x2139f60*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x2139f68*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x2139f70*/ float get_stepSize();
            /*0x2139f9c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x2139fa0*/ void LayoutComplete();
            /*0x2139fa4*/ void GraphicUpdateComplete();
            /*0x2139fa8*/ void OnEnable();
            /*0x213a2dc*/ void OnDisable();
            /*0x213a47c*/ void Update();
            /*0x2139844*/ void UpdateCachedReferences();
            /*0x2139dec*/ void Set(float input, bool sendCallback);
            /*0x213a490*/ void OnRectTransformDimensionsChange();
            /*0x213a4d8*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x213a4e8*/ bool get_reverseValue();
            /*0x2139940*/ void UpdateVisuals();
            /*0x213a4fc*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213a744*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x213a7c0*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213a828*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213a9d8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213aa80*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213acdc*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213ac4c*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x213ad24*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213ad6c*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x213b058*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x213b134*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x213b210*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x213b2ec*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x213b3c8*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213b3e0*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x213b57c*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x260bb10*/ ScrollEvent();
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

                /*0x260b8d0*/ <ClickRepeat>d__58(int <>1__state);
                /*0x260b8fc*/ void System.IDisposable.Dispose();
                /*0x260b900*/ bool MoveNext();
                /*0x260bac0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x260bac8*/ void System.Collections.IEnumerator.Reset();
                /*0x260bb08*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class Selectable : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler
        {
            static /*0x0*/ UnityEngine.UI.Selectable[] s_Selectables;
            static /*0x8*/ int s_SelectableCount;
            /*0x18*/ bool m_EnableCalled;
            /*0x20*/ UnityEngine.UI.Navigation m_Navigation;
            /*0x48*/ UnityEngine.UI.Selectable.Transition m_Transition;
            /*0x4c*/ UnityEngine.UI.ColorBlock m_Colors;
            /*0xa8*/ UnityEngine.UI.SpriteState m_SpriteState;
            /*0xc8*/ UnityEngine.UI.AnimationTriggers m_AnimationTriggers;
            /*0xd0*/ bool m_Interactable;
            /*0xd8*/ UnityEngine.UI.Graphic m_TargetGraphic;
            /*0xe0*/ bool m_GroupsAllowInteraction;
            /*0xe4*/ int m_CurrentIndex;
            /*0xe8*/ bool <isPointerInside>k__BackingField;
            /*0xe9*/ bool <isPointerDown>k__BackingField;
            /*0xea*/ bool <hasSelection>k__BackingField;
            /*0xf0*/ System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache;

            static /*0x213d04c*/ Selectable();
            static /*0x213b584*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x213b62c*/ int get_allSelectableCount();
            static /*0x213b690*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x213b738*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x213cb70*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x2139bf8*/ Selectable();
            /*0x213b818*/ UnityEngine.UI.Navigation get_navigation();
            /*0x213b82c*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0x213b92c*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x213b934*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x213b9ac*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x213b9bc*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x213ba58*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x213ba68*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x213baec*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x213baf4*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x213bb6c*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x213bb74*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x213bbec*/ bool get_interactable();
            /*0x213bbf4*/ void set_interactable(bool value);
            /*0x213bd90*/ bool get_isPointerInside();
            /*0x213bd98*/ void set_isPointerInside(bool value);
            /*0x213bda4*/ bool get_isPointerDown();
            /*0x213bdac*/ void set_isPointerDown(bool value);
            /*0x213bdb8*/ bool get_hasSelection();
            /*0x213bdc0*/ void set_hasSelection(bool value);
            /*0x213bdcc*/ UnityEngine.UI.Image get_image();
            /*0x213be4c*/ void set_image(UnityEngine.UI.Image value);
            /*0x213be54*/ UnityEngine.Animator get_animator();
            /*0x213bea0*/ void Awake();
            /*0x213bf38*/ void OnCanvasGroupChanged();
            /*0x213c10c*/ bool IsInteractable();
            /*0x213c12c*/ void OnDidApplyAnimationProperties();
            /*0x2139fe4*/ void OnEnable();
            /*0x213c18c*/ void OnTransformParentChanged();
            /*0x213b8bc*/ void OnSetProperty();
            /*0x213a308*/ void OnDisable();
            /*0x213c130*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x213c1c0*/ void InstantClearState();
            /*0x213c598*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x213c738*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x213ccc4*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x213b07c*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x213b158*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x213b234*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x213b310*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x213afc0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x213c250*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x213c344*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x213c3f8*/ void TriggerAnimation(string triggername);
            /*0x213cd88*/ bool IsHighlighted();
            /*0x213cdf0*/ bool IsPressed();
            /*0x213ce48*/ void EvaluateAndTransitionToSelectionState();
            /*0x213ab00*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213ad48*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213cef0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213cefc*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213cf04*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x213cf10*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x213cf18*/ void Select();

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
            static /*0x213d0c4*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
            static bool SetStruct<T>(ref T currentValue, T newValue);
            static bool SetClass<T>(ref T currentValue, T newValue);
        }

        class Slider : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.RectTransform m_FillRect;
            /*0x100*/ UnityEngine.RectTransform m_HandleRect;
            /*0x108*/ UnityEngine.UI.Slider.Direction m_Direction;
            /*0x10c*/ float m_MinValue;
            /*0x110*/ float m_MaxValue;
            /*0x114*/ bool m_WholeNumbers;
            /*0x118*/ float m_Value;
            /*0x120*/ UnityEngine.UI.Slider.SliderEvent m_OnValueChanged;
            /*0x128*/ UnityEngine.UI.Image m_FillImage;
            /*0x130*/ UnityEngine.Transform m_FillTransform;
            /*0x138*/ UnityEngine.RectTransform m_FillContainerRect;
            /*0x140*/ UnityEngine.Transform m_HandleTransform;
            /*0x148*/ UnityEngine.RectTransform m_HandleContainerRect;
            /*0x150*/ UnityEngine.Vector2 m_Offset;
            /*0x158*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x159*/ bool m_DelayedUpdateVisuals;

            /*0x213dfa8*/ Slider();
            /*0x213d528*/ UnityEngine.RectTransform get_fillRect();
            /*0x213d530*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x213db0c*/ UnityEngine.RectTransform get_handleRect();
            /*0x213db14*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x213db94*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x213db9c*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x213dc14*/ float get_minValue();
            /*0x213dc1c*/ void set_minValue(float value);
            /*0x213dcb0*/ float get_maxValue();
            /*0x213dcb8*/ void set_maxValue(float value);
            /*0x213dd4c*/ bool get_wholeNumbers();
            /*0x213dd54*/ void set_wholeNumbers(bool value);
            /*0x213dde8*/ float get_value();
            /*0x213de84*/ void set_value(float value);
            /*0x213de98*/ void SetValueWithoutNotify(float input);
            /*0x213deac*/ float get_normalizedValue();
            /*0x213df24*/ void set_normalizedValue(float value);
            /*0x213df6c*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x213df74*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x213df7c*/ float get_stepSize();
            /*0x213e04c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x213e050*/ void LayoutComplete();
            /*0x213e054*/ void GraphicUpdateComplete();
            /*0x213e058*/ void OnEnable();
            /*0x213e0a0*/ void OnDisable();
            /*0x213e0cc*/ void Update();
            /*0x213e114*/ void OnDidApplyAnimationProperties();
            /*0x213d5b0*/ void UpdateCachedReferences();
            /*0x213e35c*/ float ClampValue(float input);
            /*0x213e440*/ void Set(float input, bool sendCallback);
            /*0x213e514*/ void OnRectTransformDimensionsChange();
            /*0x213e430*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x213e41c*/ bool get_reverseValue();
            /*0x213d890*/ void UpdateVisuals();
            /*0x213e55c*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x213e79c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213e804*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213e9a4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213e9f4*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x213ec68*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x213ec8c*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x213ecb0*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x213ecd4*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x213ecf8*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x213ed10*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x213eeac*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x260bb5c*/ SliderEvent();
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

            /*0xaf1714*/ UnityEngine.Sprite get_highlightedSprite();
            /*0xaf171c*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0xaf1724*/ UnityEngine.Sprite get_pressedSprite();
            /*0xaf172c*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0xaf1734*/ UnityEngine.Sprite get_selectedSprite();
            /*0xaf173c*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0xaf1744*/ UnityEngine.Sprite get_disabledSprite();
            /*0xaf174c*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0xaf1754*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x2602700*/ StencilMaterial();
            static /*0x26018e4*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x26018ec*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x260231c*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x2601984*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x26023bc*/ void Remove(UnityEngine.Material customMat);
            static /*0x26025b8*/ void ClearAll();

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

                /*0x26023ac*/ MatEntry();
            }
        }

        class Text : UnityEngine.UI.MaskableGraphic, UnityEngine.UI.ILayoutElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultText;
            /*0xd0*/ UnityEngine.UI.FontData m_FontData;
            /*0xd8*/ string m_Text;
            /*0xe0*/ UnityEngine.TextGenerator m_TextCache;
            /*0xe8*/ UnityEngine.TextGenerator m_TextCacheForLayout;
            /*0xf0*/ bool m_DisableFontTextureRebuiltCallback;
            /*0xf8*/ UnityEngine.UIVertex[] m_TempVerts;

            static /*0x260437c*/ Text();
            static /*0x2603920*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x2602788*/ Text();
            /*0x260281c*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x26028b0*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x2602918*/ UnityEngine.Texture get_mainTexture();
            /*0x2602b14*/ void FontTextureChanged();
            /*0x2602af8*/ UnityEngine.Font get_font();
            /*0x2602c3c*/ void set_font(UnityEngine.Font value);
            /*0x2602d78*/ string get_text();
            /*0x2602d80*/ void set_text(string value);
            /*0x2602e58*/ bool get_supportRichText();
            /*0x2602e74*/ void set_supportRichText(bool value);
            /*0x2602ee4*/ bool get_resizeTextForBestFit();
            /*0x2602f00*/ void set_resizeTextForBestFit(bool value);
            /*0x2602f70*/ int get_resizeTextMinSize();
            /*0x2602f8c*/ void set_resizeTextMinSize(int value);
            /*0x2602ff0*/ int get_resizeTextMaxSize();
            /*0x260300c*/ void set_resizeTextMaxSize(int value);
            /*0x2603070*/ UnityEngine.TextAnchor get_alignment();
            /*0x260308c*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x26030f0*/ bool get_alignByGeometry();
            /*0x260310c*/ void set_alignByGeometry(bool value);
            /*0x2603150*/ int get_fontSize();
            /*0x260316c*/ void set_fontSize(int value);
            /*0x26031d0*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x26031ec*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x2603250*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x260326c*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x26032d0*/ float get_lineSpacing();
            /*0x26032ec*/ void set_lineSpacing(float value);
            /*0x2603350*/ UnityEngine.FontStyle get_fontStyle();
            /*0x260336c*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x26033d0*/ float get_pixelsPerUnit();
            /*0x2603538*/ void OnEnable();
            /*0x26035c0*/ void OnDisable();
            /*0x2603630*/ void UpdateGeometry();
            /*0x26036c4*/ void AssignDefaultFont();
            /*0x2603730*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x260395c*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x26041c8*/ void CalculateLayoutInputHorizontal();
            /*0x26041cc*/ void CalculateLayoutInputVertical();
            /*0x26041d0*/ float get_minWidth();
            /*0x26041d8*/ float get_preferredWidth();
            /*0x260428c*/ float get_flexibleWidth();
            /*0x2604294*/ float get_minHeight();
            /*0x260429c*/ float get_preferredHeight();
            /*0x260436c*/ float get_flexibleHeight();
            /*0x2604374*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x100*/ UnityEngine.UI.Graphic graphic;
            /*0x108*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x110*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x118*/ bool m_IsOn;

            /*0x26045e8*/ Toggle();
            /*0x2604380*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x2604388*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x26046c8*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x26046cc*/ void LayoutComplete();
            /*0x26046d0*/ void GraphicUpdateComplete();
            /*0x26046d4*/ void OnDestroy();
            /*0x2604b34*/ void OnEnable();
            /*0x2604b70*/ void OnDisable();
            /*0x2604ba0*/ void OnDidApplyAnimationProperties();
            /*0x26043b4*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x2605088*/ bool get_isOn();
            /*0x2605090*/ void set_isOn(bool value);
            /*0x260509c*/ void SetIsOnWithoutNotify(bool value);
            /*0x2604c7c*/ void Set(bool value, bool sendCallback);
            /*0x2604518*/ void PlayEffect(bool instant);
            /*0x2605210*/ void Start();
            /*0x2605218*/ void InternalToggle();
            /*0x260527c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x260529c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x26052a0*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x260467c*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ bool m_AllowSwitchOff;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x26052bc*/ ToggleGroup();
            /*0x26052a8*/ bool get_allowSwitchOff();
            /*0x26052b0*/ void set_allowSwitchOff(bool value);
            /*0x260533c*/ void Start();
            /*0x2605344*/ void OnEnable();
            /*0x260534c*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x2604f48*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x2604e08*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x2604ea8*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x2604760*/ void EnsureValidState();
            /*0x26050a8*/ bool AnyTogglesOn();
            /*0x26054a8*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x26055c4*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x260564c*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x260bba8*/ <>c();
                /*0x260bc08*/ <>c();
                /*0x260bc10*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x260bc28*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
            }
        }

        class ListPool<T>
        {
            static /*0x0*/ UnityEngine.UI.ObjectPool<System.Collections.Generic.List<T>> s_ListPool;

            static ListPool();
            static void Clear(System.Collections.Generic.List<T> l);
            static System.Collections.Generic.List<T> Get();
            static void Release(System.Collections.Generic.List<T> toRelease);
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
            /*0x0*/ int <countAll>k__BackingField;

            ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease);
            int get_countAll();
            void set_countAll(int value);
            int get_countActive();
            int get_countInactive();
            T Get();
            void Release(T element);
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

            static /*0x2135e3c*/ ReflectionMethodsCache();
            static /*0x21307cc*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x2135210*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x260aee8*/ Raycast3DCallback(object object, nint method);
                /*0x260af48*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x260b2a4*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x260b3b8*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x260b3f0*/ RaycastAllCallback(object object, nint method);
                /*0x260b450*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x260b790*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x260b878*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x260a55c*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x260a5bc*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x260a914*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x260aa00*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x260aa2c*/ Raycast2DCallback(object object, nint method);
                /*0x260aa8c*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x260adac*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x260aea4*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x2609bf8*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x2609c58*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x2609f98*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x260a080*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x260a08c*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x260a0ec*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x260a444*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x260a530*/ int EndInvoke(System.IAsyncResult result);
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

            static /*0x26078b8*/ VertexHelper();
            /*0x26066dc*/ VertexHelper();
            /*0x26066e4*/ VertexHelper(UnityEngine.Mesh m);
            /*0x2606924*/ void InitializeListIfRequired();
            /*0x2606ad8*/ void Dispose();
            /*0x2603f74*/ void Clear();
            /*0x2606cb0*/ int get_currentVertCount();
            /*0x2606d00*/ int get_currentIndexCount();
            /*0x2606d50*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x2606f44*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x26070ac*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x2607218*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x2607424*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x2607508*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x2607624*/ void AddVert(UnityEngine.UIVertex v);
            /*0x26076bc*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x26040a4*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x2607760*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x2607810*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x2607864*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x1a39244*/ BaseVertexEffect();
            void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x18*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x1a38d50*/ BaseMeshEffect();
            /*0x1a38934*/ UnityEngine.UI.Graphic get_graphic();
            /*0x1a389d4*/ void OnEnable();
            /*0x1a38a88*/ void OnDisable();
            /*0x1a38b30*/ void OnDidApplyAnimationProperties();
            /*0x1a38bd8*/ void ModifyMesh(UnityEngine.Mesh mesh);
            void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        interface IVertexModifier
        {
            void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
        }

        interface IMeshModifier
        {
            void ModifyMesh(UnityEngine.Mesh mesh);
            void ModifyMesh(UnityEngine.UI.VertexHelper verts);
        }

        class Outline : UnityEngine.UI.Shadow
        {
            /*0x212f9b8*/ Outline();
            /*0x212fa28*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x2132fd4*/ PositionAsUV1();
            /*0x2132fdc*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x20*/ UnityEngine.Color m_EffectColor;
            /*0x30*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x38*/ bool m_UseGraphicAlpha;

            /*0x212f9bc*/ Shadow();
            /*0x213d10c*/ UnityEngine.Color get_effectColor();
            /*0x213d118*/ void set_effectColor(UnityEngine.Color value);
            /*0x213d1f8*/ UnityEngine.Vector2 get_effectDistance();
            /*0x213d200*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x213d318*/ bool get_useGraphicAlpha();
            /*0x213d320*/ void set_useGraphicAlpha(bool value);
            /*0x212fc78*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x213d3e8*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x213d3f0*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;

                IndexedSet();
                void Add(T item);
                bool AddUnique(T item);
                bool Remove(T item);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int arrayIndex);
                int get_Count();
                bool get_IsReadOnly();
                int IndexOf(T item);
                void Insert(int index, T item);
                void RemoveAt(int index);
                T get_Item(int index);
                void set_Item(int index, T value);
                void RemoveAll(System.Predicate<T> match);
                void Sort(System.Comparison<T> sortLayoutFunction);
            }
        }

        namespace CoroutineTween
        {
            interface ITweenValue
            {
                void TweenValue(float floatPercentage);
                bool get_ignoreTimeScale();
                float get_duration();
                bool ValidTarget();
            }

            struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;
                /*0x18*/ UnityEngine.Color m_StartColor;
                /*0x28*/ UnityEngine.Color m_TargetColor;
                /*0x38*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;
                /*0x3c*/ float m_Duration;
                /*0x40*/ bool m_IgnoreTimeScale;

                /*0xad064c*/ UnityEngine.Color get_startColor();
                /*0xad0658*/ void set_startColor(UnityEngine.Color value);
                /*0xad0664*/ UnityEngine.Color get_targetColor();
                /*0xad0670*/ void set_targetColor(UnityEngine.Color value);
                /*0xad067c*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0xad0684*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0xad068c*/ float get_duration();
                /*0xad0694*/ void set_duration(float value);
                /*0xad069c*/ bool get_ignoreTimeScale();
                /*0xad06a4*/ void set_ignoreTimeScale(bool value);
                /*0xad06b0*/ void TweenValue(float floatPercentage);
                /*0xad06b8*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0xad06c0*/ bool GetIgnoreTimescale();
                /*0xad06c8*/ float GetDuration();
                /*0xad06d0*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x2607afc*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0xad071c*/ float get_startValue();
                /*0xad0724*/ void set_startValue(float value);
                /*0xad072c*/ float get_targetValue();
                /*0xad0734*/ void set_targetValue(float value);
                /*0xad073c*/ float get_duration();
                /*0xad0744*/ void set_duration(float value);
                /*0xad074c*/ bool get_ignoreTimeScale();
                /*0xad0754*/ void set_ignoreTimeScale(bool value);
                /*0xad0760*/ void TweenValue(float floatPercentage);
                /*0xad0768*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0xad0770*/ bool GetIgnoreTimescale();
                /*0xad0778*/ float GetDuration();
                /*0xad0780*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x2608204*/ FloatTweenCallback();
                }
            }

            class TweenRunner<T>
            {
                /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
                /*0x0*/ System.Collections.IEnumerator m_Tween;

                static System.Collections.IEnumerator Start(T tweenInfo);
                TweenRunner();
                void Init(UnityEngine.MonoBehaviour coroutineContainer);
                void StartTween(T info);
                void StopTween();

                class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ T tweenInfo;
                    /*0x0*/ float <elapsedTime>5__2;

                    <Start>d__2(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                }
            }
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x1a37540*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x1a37520*/ UnityEngine.Vector2 get_moveVector();
            /*0x1a37528*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x1a37530*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0x1a37538*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x1a36ad8*/ AbstractEventData();
            /*0x1a36abc*/ void Reset();
            /*0x1a36ac4*/ void Use();
            /*0x1a36ad0*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0x1a37580*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x1a375ac*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x1a375c8*/ UnityEngine.GameObject get_selectedObject();
            /*0x1a375e4*/ void set_selectedObject(UnityEngine.GameObject value);
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
            /*0x98*/ UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField;
            /*0xe0*/ System.Collections.Generic.List<UnityEngine.GameObject> hovered;
            /*0xe8*/ bool <eligibleForClick>k__BackingField;
            /*0xec*/ int <pointerId>k__BackingField;
            /*0xf0*/ UnityEngine.Vector2 <position>k__BackingField;
            /*0xf8*/ UnityEngine.Vector2 <delta>k__BackingField;
            /*0x100*/ UnityEngine.Vector2 <pressPosition>k__BackingField;
            /*0x108*/ UnityEngine.Vector3 <worldPosition>k__BackingField;
            /*0x114*/ UnityEngine.Vector3 <worldNormal>k__BackingField;
            /*0x120*/ float <clickTime>k__BackingField;
            /*0x124*/ int <clickCount>k__BackingField;
            /*0x128*/ UnityEngine.Vector2 <scrollDelta>k__BackingField;
            /*0x130*/ bool <useDragThreshold>k__BackingField;
            /*0x131*/ bool <dragging>k__BackingField;
            /*0x134*/ UnityEngine.EventSystems.PointerEventData.InputButton <button>k__BackingField;

            /*0x213108c*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x2130ed8*/ UnityEngine.GameObject get_pointerEnter();
            /*0x2130ee0*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x2130ee8*/ UnityEngine.GameObject get_lastPress();
            /*0x2130ef0*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x2130ef8*/ UnityEngine.GameObject get_rawPointerPress();
            /*0x2130f00*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0x2130f08*/ UnityEngine.GameObject get_pointerDrag();
            /*0x2130f10*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x2130f18*/ UnityEngine.GameObject get_pointerClick();
            /*0x2130f20*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x2130f28*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x2130f38*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x2130f54*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x2130f64*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x2130f80*/ bool get_eligibleForClick();
            /*0x2130f88*/ void set_eligibleForClick(bool value);
            /*0x2130f94*/ int get_pointerId();
            /*0x2130f9c*/ void set_pointerId(int value);
            /*0x2130fa4*/ UnityEngine.Vector2 get_position();
            /*0x2130fac*/ void set_position(UnityEngine.Vector2 value);
            /*0x2130fb4*/ UnityEngine.Vector2 get_delta();
            /*0x2130fbc*/ void set_delta(UnityEngine.Vector2 value);
            /*0x2130fc4*/ UnityEngine.Vector2 get_pressPosition();
            /*0x2130fd0*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x2130fdc*/ UnityEngine.Vector3 get_worldPosition();
            /*0x2130fec*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x2130ffc*/ UnityEngine.Vector3 get_worldNormal();
            /*0x213100c*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x213101c*/ float get_clickTime();
            /*0x2131024*/ void set_clickTime(float value);
            /*0x213102c*/ int get_clickCount();
            /*0x2131034*/ void set_clickCount(int value);
            /*0x213103c*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x2131048*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x2131054*/ bool get_useDragThreshold();
            /*0x213105c*/ void set_useDragThreshold(bool value);
            /*0x2131068*/ bool get_dragging();
            /*0x2131070*/ void set_dragging(bool value);
            /*0x213107c*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x2131084*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x213116c*/ bool IsPointerMoving();
            /*0x21311a0*/ bool IsScrolling();
            /*0x21311d4*/ UnityEngine.Camera get_enterEventCamera();
            /*0x2131270*/ UnityEngine.Camera get_pressEventCamera();
            /*0x213130c*/ UnityEngine.GameObject get_pointerPress();
            /*0x2131314*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x213139c*/ string ToString();

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

        interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class EventSystem : UnityEngine.EventSystems.UIBehaviour
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems;
            static /*0x8*/ System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;
            /*0x20*/ UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;
            /*0x28*/ UnityEngine.GameObject m_FirstSelected;
            /*0x30*/ bool m_sendNavigationEvents;
            /*0x34*/ int m_DragThreshold;
            /*0x38*/ UnityEngine.GameObject m_CurrentSelected;
            /*0x40*/ bool m_HasFocus;
            /*0x41*/ bool m_SelectionGuard;
            /*0x48*/ UnityEngine.EventSystems.BaseEventData m_DummyData;

            static /*0x1a44650*/ EventSystem();
            static /*0x1a433f0*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x1a434c4*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x1a43808*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            /*0x1a436d8*/ EventSystem();
            /*0x1a43684*/ bool get_sendNavigationEvents();
            /*0x1a4368c*/ void set_sendNavigationEvents(bool value);
            /*0x1a43698*/ int get_pixelDragThreshold();
            /*0x1a436a0*/ void set_pixelDragThreshold(int value);
            /*0x1a436a8*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x1a436b0*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x1a436b8*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0x1a436c0*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x1a436c8*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0x1a436d0*/ bool get_isFocused();
            /*0x1a37bf8*/ void UpdateModules();
            /*0x1a43764*/ bool get_alreadySelecting();
            /*0x1a37600*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x1a4376c*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x1a437d8*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x1a43ba0*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x1a43dac*/ bool IsPointerOverGameObject();
            /*0x1a43db4*/ bool IsPointerOverGameObject(int pointerId);
            /*0x1a43e64*/ void OnEnable();
            /*0x1a43efc*/ void OnDisable();
            /*0x1a43ff4*/ void TickModules();
            /*0x1a44118*/ void OnApplicationFocus(bool hasFocus);
            /*0x1a4412c*/ void Update();
            /*0x1a443d8*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x1a444ec*/ string ToString();
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x1a447c4*/ EventTrigger();
            /*0x1a4473c*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x1a447bc*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x1a44740*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x1a447cc*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x1a447d4*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a448dc*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a448e8*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a448f4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44900*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a4490c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44918*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44924*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44930*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a4493c*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a44948*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44954*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x1a44960*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a4496c*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44978*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44984*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1a44990*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1a4499c*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x26080fc*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x2608094*/ Entry();
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
            static /*0x0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler;
            static /*0x8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler;
            static /*0x10*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler;
            static /*0x18*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler;
            static /*0x20*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler;
            static /*0x28*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler;
            static /*0x30*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler;
            static /*0x38*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler;
            static /*0x40*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler;
            static /*0x48*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler;
            static /*0x50*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler;
            static /*0x58*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler;
            static /*0x60*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler;
            static /*0x68*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler;
            static /*0x70*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler;
            static /*0x78*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler;
            static /*0x80*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler;
            static /*0x88*/ UnityEngine.UI.ObjectPool<System.Collections.Generic.List<UnityEngine.EventSystems.IEventSystemHandler>> s_HandlerListPool;
            static /*0x90*/ System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList;

            static /*0x1a461fc*/ ExecuteEvents();
            static T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x1a449a8*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a44ab0*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a44bb8*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a44cc0*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a44dc8*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a44ed0*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a44fd8*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a450e0*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a451e8*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a452f0*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a453f8*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a45500*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a455b8*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a45670*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a45728*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a45830*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a458e8*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1a459a0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x1a45a04*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x1a45a68*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x1a45acc*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x1a45b30*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x1a45b94*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x1a45bf8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x1a45c5c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x1a45cc0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x1a45d24*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x1a45d88*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x1a45dec*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x1a45e50*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x1a45eb4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x1a45f18*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x1a45f7c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x1a45fe0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x1a46044*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
            static bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor);
            static UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction);
            static bool ShouldSendToComponent<T>(UnityEngine.Component component);
            static void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results);
            static bool CanHandleEvent<T>(UnityEngine.GameObject go);
            static UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root);

            class EventFunction<T1> : System.MulticastDelegate
            {
                EventFunction(object object, nint method);
                void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData);
                System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object);
                void EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.EventSystems.ExecuteEvents.<> <>9;

                static /*0x2608148*/ <>c();
                /*0x26081a8*/ <>c();
                /*0x26081b0*/ void <.cctor>b__79_0(System.Collections.Generic.List<UnityEngine.EventSystems.IEventSystemHandler> l);
            }
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x1a37924*/ BaseInput();
            /*0x1a37850*/ string get_compositionString();
            /*0x1a37858*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x1a37860*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x1a3786c*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x1a37874*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x1a3787c*/ bool get_mousePresent();
            /*0x1a37884*/ bool GetMouseButtonDown(int button);
            /*0x1a37890*/ bool GetMouseButtonUp(int button);
            /*0x1a3789c*/ bool GetMouseButton(int button);
            /*0x1a378a8*/ UnityEngine.Vector2 get_mousePosition();
            /*0x1a378b0*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x1a378b8*/ bool get_touchSupported();
            /*0x1a378c0*/ int get_touchCount();
            /*0x1a378c8*/ UnityEngine.Touch GetTouch(int index);
            /*0x1a3790c*/ float GetAxisRaw(string axisName);
            /*0x1a37918*/ bool GetButtonDown(string buttonName);
        }

        class BaseInputModule : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;
            /*0x20*/ UnityEngine.EventSystems.AxisEventData m_AxisEventData;
            /*0x28*/ UnityEngine.EventSystems.EventSystem m_EventSystem;
            /*0x30*/ UnityEngine.EventSystems.BaseEventData m_BaseEventData;
            /*0x38*/ UnityEngine.EventSystems.BaseInput m_InputOverride;
            /*0x40*/ UnityEngine.EventSystems.BaseInput m_DefaultInput;

            static /*0x1a37da4*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x1a37ed4*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x1a37ee0*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x1a37f5c*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x1a388bc*/ BaseInputModule();
            /*0x1a3792c*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x1a37b78*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x1a37b80*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x1a37b88*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x1a37b90*/ void OnEnable();
            /*0x1a37d70*/ void OnDisable();
            void Process();
            /*0x1a38100*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x1a386d8*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x1a387c0*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x1a38850*/ bool IsPointerOverGameObject(int pointerId);
            /*0x1a38858*/ bool ShouldActivateModule();
            /*0x1a388a8*/ void DeactivateModule();
            /*0x1a388ac*/ void ActivateModule();
            /*0x1a388b0*/ void UpdateModule();
            /*0x1a388b4*/ bool IsModuleSupported();
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x48*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x50*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x2132610*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x2132f30*/ PointerInputModule();
            /*0x2131e2c*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x2131f20*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x2131f88*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x21321e8*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x2132244*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x21322d4*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x21322e8*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x21325e4*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x2132660*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x21326ac*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x21329a4*/ bool IsPointerOverGameObject(int pointerId);
            /*0x2132a4c*/ void ClearSelection();
            /*0x2132be0*/ string ToString();
            /*0x2132e2c*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x260999c*/ ButtonState();
                /*0x260997c*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x2609984*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x260998c*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0x2609994*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x2609b80*/ MouseState();
                /*0x26099ac*/ bool AnyPressesThisFrame();
                /*0x2609a74*/ bool AnyReleasesThisFrame();
                /*0x26013b0*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x2609b3c*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x26099a4*/ MouseButtonEventData();
                /*0x26018b4*/ bool PressedThisFrame();
                /*0x26018c8*/ bool ReleasedThisFrame();
            }
        }

        class StandaloneInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x58*/ float m_PrevActionTime;
            /*0x5c*/ UnityEngine.Vector2 m_LastMoveVector;
            /*0x64*/ int m_ConsecutiveMoveCount;
            /*0x68*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x70*/ UnityEngine.Vector2 m_MousePosition;
            /*0x78*/ UnityEngine.GameObject m_CurrentFocusedGameObject;
            /*0x80*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x88*/ string m_HorizontalAxis;
            /*0x90*/ string m_VerticalAxis;
            /*0x98*/ string m_SubmitButton;
            /*0xa0*/ string m_CancelButton;
            /*0xa8*/ float m_InputActionsPerSecond;
            /*0xac*/ float m_RepeatDelay;
            /*0xb0*/ bool m_ForceModuleActive;

            /*0x25ff78c*/ StandaloneInputModule();
            /*0x25ff840*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x25ff848*/ bool get_allowActivationOnMobileDevice();
            /*0x25ff850*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x25ff85c*/ bool get_forceModuleActive();
            /*0x25ff864*/ void set_forceModuleActive(bool value);
            /*0x25ff870*/ float get_inputActionsPerSecond();
            /*0x25ff878*/ void set_inputActionsPerSecond(float value);
            /*0x25ff880*/ float get_repeatDelay();
            /*0x25ff888*/ void set_repeatDelay(float value);
            /*0x25ff890*/ string get_horizontalAxis();
            /*0x25ff898*/ void set_horizontalAxis(string value);
            /*0x25ff8a0*/ string get_verticalAxis();
            /*0x25ff8a8*/ void set_verticalAxis(string value);
            /*0x25ff8b0*/ string get_submitButton();
            /*0x25ff8b8*/ void set_submitButton(string value);
            /*0x25ff8c0*/ string get_cancelButton();
            /*0x25ff8c8*/ void set_cancelButton(string value);
            /*0x25ff8d0*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x25ff8d8*/ void UpdateModule();
            /*0x25ff9b8*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x25ffd94*/ bool IsModuleSupported();
            /*0x25ffe08*/ bool ShouldActivateModule();
            /*0x25fffc8*/ void ActivateModule();
            /*0x26000f8*/ void DeactivateModule();
            /*0x2600124*/ void Process();
            /*0x2600334*/ bool ProcessTouchEvents();
            /*0x260092c*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x26006d8*/ bool SendSubmitEventToSelectedObject();
            /*0x2601048*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x26004b8*/ bool SendMoveEventToSelectedObject();
            /*0x26004b0*/ void ProcessMouseEvent();
            /*0x26013a8*/ bool ForceAutoSelect();
            /*0x2601150*/ void ProcessMouseEvent(int id);
            /*0x26001d0*/ bool SendUpdateEventToSelectedObject();
            /*0x2601528*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x26018dc*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

            enum InputMode
            {
                Mouse = 0,
                Buttons = 1,
            }
        }

        class TouchInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x58*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x60*/ UnityEngine.Vector2 m_MousePosition;
            /*0x68*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x70*/ bool m_ForceModuleActive;

            /*0x2605758*/ TouchInputModule();
            /*0x2605760*/ bool get_allowActivationOnStandalone();
            /*0x2605768*/ void set_allowActivationOnStandalone(bool value);
            /*0x2605774*/ bool get_forceModuleActive();
            /*0x260577c*/ void set_forceModuleActive(bool value);
            /*0x2605788*/ void UpdateModule();
            /*0x2605900*/ bool IsModuleSupported();
            /*0x2605940*/ bool ShouldActivateModule();
            /*0x2605a08*/ bool UseFakeInput();
            /*0x2605a40*/ void Process();
            /*0x2605a78*/ void FakeTouches();
            /*0x2605b7c*/ void ProcessTouchEvents();
            /*0x2605cdc*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x260640c*/ void DeactivateModule();
            /*0x2606438*/ string ToString();
        }

        enum MoveDirection
        {
            Left = 0,
            Up = 1,
            Right = 2,
            Down = 3,
            None = 4,
        }

        struct RaycastResult
        {
            /*0x10*/ UnityEngine.GameObject m_GameObject;
            /*0x18*/ UnityEngine.EventSystems.BaseRaycaster module;
            /*0x20*/ float distance;
            /*0x24*/ float index;
            /*0x28*/ int depth;
            /*0x2c*/ int sortingLayer;
            /*0x30*/ int sortingOrder;
            /*0x34*/ UnityEngine.Vector3 worldPosition;
            /*0x40*/ UnityEngine.Vector3 worldNormal;
            /*0x4c*/ UnityEngine.Vector2 screenPosition;
            /*0x54*/ int displayIndex;

            /*0xae1bf8*/ UnityEngine.GameObject get_gameObject();
            /*0xae1c00*/ void set_gameObject(UnityEngine.GameObject value);
            /*0xae1c08*/ bool get_isValid();
            /*0xae1c10*/ void Clear();
            /*0xae1c18*/ string ToString();
        }

        class RaycasterManager
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters;

            static /*0x2133d1c*/ RaycasterManager();
            static /*0x2133af0*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x2133bd4*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x2133c38*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x1a3923c*/ BaseRaycaster();
            void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            UnityEngine.Camera get_eventCamera();
            /*0x1a38d58*/ int get_priority();
            /*0x1a38d60*/ int get_sortOrderPriority();
            /*0x1a38d68*/ int get_renderOrderPriority();
            /*0x1a38d70*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x1a38e3c*/ string ToString();
            /*0x1a3910c*/ void OnEnable();
            /*0x1a3917c*/ void OnDisable();
            /*0x1a391ec*/ void OnCanvasHierarchyChanged();
            /*0x1a39214*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x40*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x212ff48*/ Physics2DRaycaster();
            /*0x212ffb0*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x20*/ UnityEngine.Camera m_EventCamera;
            /*0x28*/ UnityEngine.LayerMask m_EventMask;
            /*0x2c*/ int m_MaxRayIntersections;
            /*0x30*/ int m_LastMaxRayIntersections;
            /*0x38*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x212ff7c*/ PhysicsRaycaster();
            /*0x2130958*/ UnityEngine.Camera get_eventCamera();
            /*0x2130a08*/ int get_depth();
            /*0x2130888*/ int get_finalEventMask();
            /*0x2130adc*/ UnityEngine.LayerMask get_eventMask();
            /*0x2130ae4*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x2130aec*/ int get_maxRayIntersections();
            /*0x2130af4*/ void set_maxRayIntersections(int value);
            /*0x2130548*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x2130afc*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x260991c*/ RaycastHitComparer();
                /*0x2609914*/ RaycastHitComparer();
                /*0x26098d0*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
            }
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x2605334*/ UIBehaviour();
            /*0x260664c*/ void Awake();
            /*0x2605348*/ void OnEnable();
            /*0x2605340*/ void Start();
            /*0x2606650*/ void OnDisable();
            /*0x2604b30*/ void OnDestroy();
            /*0x2606654*/ bool IsActive();
            /*0x260665c*/ void OnRectTransformDimensionsChange();
            /*0x2606660*/ void OnBeforeTransformParentChanged();
            /*0x2606664*/ void OnTransformParentChanged();
            /*0x2606668*/ void OnDidApplyAnimationProperties();
            /*0x260666c*/ void OnCanvasGroupChanged();
            /*0x2606670*/ void OnCanvasHierarchyChanged();
            /*0x2606674*/ bool IsDestroyed();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

    struct __StaticArrayInitTypeSize=12
    {
    }
}
