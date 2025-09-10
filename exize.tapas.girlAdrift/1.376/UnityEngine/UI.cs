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

            /*0x1358154*/ AnimationTriggers();
            /*0x1358104*/ string get_normalTrigger();
            /*0x135810c*/ void set_normalTrigger(string value);
            /*0x1358114*/ string get_highlightedTrigger();
            /*0x135811c*/ void set_highlightedTrigger(string value);
            /*0x1358124*/ string get_pressedTrigger();
            /*0x135812c*/ void set_pressedTrigger(string value);
            /*0x1358134*/ string get_selectedTrigger();
            /*0x135813c*/ void set_selectedTrigger(string value);
            /*0x1358144*/ string get_disabledTrigger();
            /*0x135814c*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0xf8*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x1358224*/ Button();
            /*0x13582b8*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x13582c0*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x13582c8*/ void Press();
            /*0x1358360*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1358384*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x13583fc*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x13582b0*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x1358464*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x135848c*/ void System.IDisposable.Dispose();
                /*0x1358490*/ bool MoveNext();
                /*0x135854c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x1358554*/ void System.Collections.IEnumerator.Reset();
                /*0x1358594*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x135a04c*/ CanvasUpdateRegistry();
            static /*0x1358808*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x135942c*/ int ParentCount(UnityEngine.Transform child);
            static /*0x13594ec*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x135963c*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1359734*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1359794*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x13598c4*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1359924*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1359c5c*/ void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x1359f94*/ bool IsRebuildingLayout();
            static /*0x1359ff0*/ bool IsRebuildingGraphics();
            /*0x135859c*/ CanvasUpdateRegistry();
            /*0x13588b0*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x1358980*/ void CleanInvalidItems();
            /*0x1358c64*/ void PerformUpdate();
            /*0x135969c*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x13597f4*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1359994*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1359af8*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1359ccc*/ void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x1359e30*/ void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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

            static /*0x135a178*/ ColorBlock();
            static /*0x135a3a8*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x135a3dc*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0x135a0e0*/ UnityEngine.Color get_normalColor();
            /*0x135a0ec*/ void set_normalColor(UnityEngine.Color value);
            /*0x135a0f8*/ UnityEngine.Color get_highlightedColor();
            /*0x135a104*/ void set_highlightedColor(UnityEngine.Color value);
            /*0x135a110*/ UnityEngine.Color get_pressedColor();
            /*0x135a11c*/ void set_pressedColor(UnityEngine.Color value);
            /*0x135a128*/ UnityEngine.Color get_selectedColor();
            /*0x135a134*/ void set_selectedColor(UnityEngine.Color value);
            /*0x135a140*/ UnityEngine.Color get_disabledColor();
            /*0x135a14c*/ void set_disabledColor(UnityEngine.Color value);
            /*0x135a158*/ float get_colorMultiplier();
            /*0x135a160*/ void set_colorMultiplier(float value);
            /*0x135a168*/ float get_fadeDuration();
            /*0x135a170*/ void set_fadeDuration(float value);
            /*0x135a1f4*/ bool Equals(object obj);
            /*0x135a284*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0x135a414*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x13592a4*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x135a4fc*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x135a56c*/ void Unregister(UnityEngine.UI.IClipper c);
            static /*0x135a5c8*/ void Disable(UnityEngine.UI.IClipper c);
            /*0x135a480*/ ClipperRegistry();
            /*0x1359320*/ void Cull();
        }

        class Clipping
        {
            static /*0x135a624*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
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

            /*0x135a9f4*/ RectangularVertexClipper();
            /*0x135a884*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
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

            static /*0x135f24c*/ DefaultControls();
            static /*0x135aa5c*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x135aab4*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x135ac14*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x135ae3c*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x135af18*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x135ad3c*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x135af28*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x135b00c*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135b630*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135ba1c*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135bbbc*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135bcf8*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135be34*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135c4e8*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135c95c*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135ced4*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135d4f4*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x135e964*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x135f3a0*/ DefaultRuntimeFactory();
                /*0x135f398*/ DefaultRuntimeFactory();
                /*0x135f324*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
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

            static /*0x1361ffc*/ Dropdown();
            static T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x135f5a0*/ Dropdown();
            /*0x135f404*/ UnityEngine.RectTransform get_template();
            /*0x135e74c*/ void set_template(UnityEngine.RectTransform value);
            /*0x135f40c*/ UnityEngine.UI.Text get_captionText();
            /*0x135e754*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x135f414*/ UnityEngine.UI.Image get_captionImage();
            /*0x135f41c*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x135f424*/ UnityEngine.UI.Text get_itemText();
            /*0x135e75c*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x135f42c*/ UnityEngine.UI.Image get_itemImage();
            /*0x135f434*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x135e764*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x135f43c*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x135f458*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x135f460*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x135f468*/ float get_alphaFadeSpeed();
            /*0x135f470*/ void set_alphaFadeSpeed(float value);
            /*0x135f478*/ int get_value();
            /*0x135f480*/ void set_value(int value);
            /*0x135f598*/ void SetValueWithoutNotify(int input);
            /*0x135f488*/ void Set(int value, bool sendCallback);
            /*0x135f76c*/ void Awake();
            /*0x135f868*/ void Start();
            /*0x135f8fc*/ void OnDisable();
            /*0x135e788*/ void RefreshShownValue();
            /*0x135fb00*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x135fb68*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x135fcec*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x135fe70*/ void ClearOptions();
            /*0x135fee8*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x1360560*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x136117c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1361180*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1360564*/ void Show();
            /*0x136169c*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x1361b68*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x1361bc0*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x1361c2c*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x1361c84*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x1361cf0*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x1361288*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x1361cf4*/ void AlphaFadeList(float duration, float alpha);
            /*0x1361574*/ void AlphaFadeList(float duration, float start, float end);
            /*0x1361d74*/ void SetAlpha(float alpha);
            /*0x1361184*/ void Hide();
            /*0x1361e28*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x135f990*/ void ImmediateDestroyDropdownList();
            /*0x1361ec8*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x18*/ UnityEngine.UI.Text m_Text;
                /*0x20*/ UnityEngine.UI.Image m_Image;
                /*0x28*/ UnityEngine.RectTransform m_RectTransform;
                /*0x30*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x13621dc*/ DropdownItem();
                /*0x1362074*/ UnityEngine.UI.Text get_text();
                /*0x136207c*/ void set_text(UnityEngine.UI.Text value);
                /*0x1362084*/ UnityEngine.UI.Image get_image();
                /*0x136208c*/ void set_image(UnityEngine.UI.Image value);
                /*0x1362094*/ UnityEngine.RectTransform get_rectTransform();
                /*0x136209c*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x13620a4*/ UnityEngine.UI.Toggle get_toggle();
                /*0x13620ac*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x13620b4*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x1362130*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x135e780*/ OptionData();
                /*0x135fcc4*/ OptionData(string text);
                /*0x135fe48*/ OptionData(UnityEngine.Sprite image);
                /*0x1362204*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x13621e4*/ string get_text();
                /*0x13621ec*/ void set_text(string value);
                /*0x13621f4*/ UnityEngine.Sprite get_image();
                /*0x13621fc*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x135f6a4*/ OptionDataList();
                /*0x1362230*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x1362238*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x135f724*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x1361280*/ <>c__DisplayClass63_0();
                /*0x1362240*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x1361ea0*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x1362264*/ void System.IDisposable.Dispose();
                /*0x1362268*/ bool MoveNext();
                /*0x1362314*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x136231c*/ void System.Collections.IEnumerator.Reset();
                /*0x136235c*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x1362364*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x13623f4*/ FontData();
            /*0x13623fc*/ UnityEngine.Font get_font();
            /*0x1362404*/ void set_font(UnityEngine.Font value);
            /*0x136240c*/ int get_fontSize();
            /*0x1362414*/ void set_fontSize(int value);
            /*0x136241c*/ UnityEngine.FontStyle get_fontStyle();
            /*0x1362424*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x136242c*/ bool get_bestFit();
            /*0x1362434*/ void set_bestFit(bool value);
            /*0x1362440*/ int get_minSize();
            /*0x1362448*/ void set_minSize(int value);
            /*0x1362450*/ int get_maxSize();
            /*0x1362458*/ void set_maxSize(int value);
            /*0x1362460*/ UnityEngine.TextAnchor get_alignment();
            /*0x1362468*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x1362470*/ bool get_alignByGeometry();
            /*0x1362478*/ void set_alignByGeometry(bool value);
            /*0x1362484*/ bool get_richText();
            /*0x136248c*/ void set_richText(bool value);
            /*0x1362498*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x13624a0*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x13624a8*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x13624b0*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x13624b8*/ float get_lineSpacing();
            /*0x13624c0*/ void set_lineSpacing(float value);
            /*0x13624c8*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x13624cc*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x1362b10*/ FontUpdateTracker();
            static /*0x1362510*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x1362760*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x1362904*/ void UntrackText(UnityEngine.UI.Text t);
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

            static /*0x1366414*/ Graphic();
            static /*0x1362b9c*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x1365044*/ UnityEngine.Mesh get_workerMesh();
            static /*0x1366064*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x13631a8*/ Graphic();
            /*0x1362c78*/ UnityEngine.Color get_color();
            /*0x1362c84*/ void set_color(UnityEngine.Color value);
            /*0x1362cbc*/ bool get_raycastTarget();
            /*0x1362cc4*/ void set_raycastTarget(bool value);
            /*0x136317c*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x1363188*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x1363194*/ bool get_useLegacyMeshGeneration();
            /*0x136319c*/ void set_useLegacyMeshGeneration(bool value);
            /*0x1363254*/ void SetAllDirty();
            /*0x13632bc*/ void SetLayoutDirty();
            /*0x13633b4*/ void SetVerticesDirty();
            /*0x1363448*/ void SetMaterialDirty();
            /*0x13634dc*/ void OnRectTransformDimensionsChange();
            /*0x1363588*/ void OnBeforeTransformParentChanged();
            /*0x13637b0*/ void OnTransformParentChanged();
            /*0x1363bc8*/ int get_depth();
            /*0x136335c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1362da0*/ UnityEngine.Canvas get_canvas();
            /*0x1363864*/ void CacheCanvas();
            /*0x1363be4*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x1363c74*/ UnityEngine.Material get_defaultMaterial();
            /*0x1363cc0*/ UnityEngine.Material get_material();
            /*0x1363d48*/ void set_material(UnityEngine.Material value);
            /*0x1363de0*/ UnityEngine.Material get_materialForRendering();
            /*0x1364004*/ UnityEngine.Texture get_mainTexture();
            /*0x136405c*/ void OnEnable();
            /*0x136418c*/ void OnDisable();
            /*0x13642d4*/ void OnDestroy();
            /*0x1364558*/ void OnCanvasHierarchyChanged();
            /*0x1364690*/ void OnCullingChanged();
            /*0x136471c*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x1364800*/ void LayoutComplete();
            /*0x1364804*/ void GraphicUpdateComplete();
            /*0x1364808*/ void UpdateMaterial();
            /*0x13648c0*/ void UpdateGeometry();
            /*0x1364c70*/ void DoMeshGeneration();
            /*0x13648d0*/ void DoLegacyMeshGeneration();
            /*0x1365180*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x1365184*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x136521c*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x13657d4*/ void OnDidApplyAnimationProperties();
            /*0x13657e4*/ void SetNativeSize();
            /*0x13657e8*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x1365c74*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x13656a8*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x1365db4*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x1365dd0*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x1366078*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x1366114*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x1366194*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x1366214*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x1366294*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x1366314*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x1366394*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x13664a4*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
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

            static /*0x1367a14*/ GraphicRaycaster();
            static /*0x13673dc*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x1366610*/ GraphicRaycaster();
            /*0x13664ac*/ int get_sortOrderPriority();
            /*0x1366588*/ int get_renderOrderPriority();
            /*0x13665dc*/ bool get_ignoreReversedGraphics();
            /*0x13665e4*/ void set_ignoreReversedGraphics(bool value);
            /*0x13665f0*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0x13665f8*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0x1366600*/ UnityEngine.LayerMask get_blockingMask();
            /*0x1366608*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x13664f4*/ UnityEngine.Canvas get_canvas();
            /*0x13666a4*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x136794c*/ UnityEngine.Camera get_eventCamera();

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

                static /*0x1367aa0*/ <>c();
                /*0x1367b04*/ <>c();
                /*0x1367b0c*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x1367fe4*/ GraphicRegistry();
            static /*0x1367d00*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x13639d4*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1362f88*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x13643d8*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1362e14*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1363630*/ void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1367da8*/ void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x1367f28*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x1367320*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x1367b58*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            void OnSiblingGraphicEnabledDisabled();
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

            static /*0x1370404*/ Image();
            static /*0x13686a8*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x136f378*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x136f224*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x136f45c*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x136f57c*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x137022c*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x136ec58*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x136ee48*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x1368668*/ Image();
            /*0x1368070*/ UnityEngine.Sprite get_sprite();
            /*0x135b2c8*/ void set_sprite(UnityEngine.Sprite value);
            /*0x1368164*/ void DisableSpriteOptimizations();
            /*0x136816c*/ UnityEngine.Sprite get_overrideSprite();
            /*0x13681e8*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x1368170*/ UnityEngine.Sprite get_activeSprite();
            /*0x1368270*/ UnityEngine.UI.Image.Type get_type();
            /*0x135b5b0*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x1368278*/ bool get_preserveAspect();
            /*0x1368280*/ void set_preserveAspect(bool value);
            /*0x1368300*/ bool get_fillCenter();
            /*0x1368308*/ void set_fillCenter(bool value);
            /*0x1368388*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x1368390*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x1368408*/ float get_fillAmount();
            /*0x1368410*/ void set_fillAmount(float value);
            /*0x13684a0*/ bool get_fillClockwise();
            /*0x13684a8*/ void set_fillClockwise(bool value);
            /*0x1368528*/ int get_fillOrigin();
            /*0x1368530*/ void set_fillOrigin(int value);
            /*0x13685b0*/ float get_eventAlphaThreshold();
            /*0x13685c0*/ void set_eventAlphaThreshold(float value);
            /*0x13685d0*/ float get_alphaHitTestMinimumThreshold();
            /*0x13685d8*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0x13685e0*/ bool get_useSpriteMesh();
            /*0x13685e8*/ void set_useSpriteMesh(bool value);
            /*0x1368784*/ UnityEngine.Texture get_mainTexture();
            /*0x13688fc*/ bool get_hasBorder();
            /*0x13689b4*/ float get_pixelsPerUnitMultiplier();
            /*0x13689bc*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x13689dc*/ float get_pixelsPerUnit();
            /*0x1368ad0*/ float get_multipliedPixelsPerUnit();
            /*0x1368aec*/ UnityEngine.Material get_material();
            /*0x1368c18*/ void set_material(UnityEngine.Material value);
            /*0x1368c1c*/ void OnBeforeSerialize();
            /*0x1368c20*/ void OnAfterDeserialize();
            /*0x1368c70*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x1368dc8*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x136924c*/ void SetNativeSize();
            /*0x13693b0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x1368078*/ void TrackSprite();
            /*0x136edb8*/ void OnEnable();
            /*0x136edd4*/ void OnDisable();
            /*0x136eec8*/ void UpdateMaterial();
            /*0x136efbc*/ void OnCanvasHierarchyChanged();
            /*0x13694f4*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x136a018*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x136a608*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x136ae58*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x136f0c4*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x136d830*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x136f968*/ void CalculateLayoutInputHorizontal();
            /*0x136f96c*/ void CalculateLayoutInputVertical();
            /*0x136f970*/ float get_minWidth();
            /*0x136f978*/ float get_preferredWidth();
            /*0x136fa5c*/ float get_flexibleWidth();
            /*0x136fa64*/ float get_minHeight();
            /*0x136fa6c*/ float get_preferredHeight();
            /*0x136fb50*/ float get_flexibleHeight();
            /*0x136fb58*/ int get_layoutPriority();
            /*0x136fb60*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x136feec*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x13703d4*/ void OnDidApplyAnimationProperties();

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
            bool Enabled();
            UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            void RecalculateMasking();
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
            /*0x130*/ UnityEngine.UI.InputField.SubmitEvent m_OnSubmit;
            /*0x138*/ UnityEngine.UI.InputField.EndEditEvent m_OnDidEndEdit;
            /*0x140*/ UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;
            /*0x148*/ UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;
            /*0x150*/ UnityEngine.Color m_CaretColor;
            /*0x160*/ bool m_CustomCaretColor;
            /*0x164*/ UnityEngine.Color m_SelectionColor;
            /*0x178*/ string m_Text;
            /*0x180*/ float m_CaretBlinkRate;
            /*0x184*/ int m_CaretWidth;
            /*0x188*/ bool m_ReadOnly;
            /*0x189*/ bool m_ShouldActivateOnSelect;
            /*0x18c*/ int m_CaretPosition;
            /*0x190*/ int m_CaretSelectPosition;
            /*0x198*/ UnityEngine.RectTransform caretRectTrans;
            /*0x1a0*/ UnityEngine.UIVertex[] m_CursorVerts;
            /*0x1a8*/ UnityEngine.TextGenerator m_InputTextCache;
            /*0x1b0*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
            /*0x1b8*/ bool m_PreventFontCallback;
            /*0x1c0*/ UnityEngine.Mesh m_Mesh;
            /*0x1c8*/ bool m_AllowInput;
            /*0x1c9*/ bool m_ShouldActivateNextUpdate;
            /*0x1ca*/ bool m_UpdateDrag;
            /*0x1cb*/ bool m_DragPositionOutOfBounds;
            /*0x1cc*/ bool m_CaretVisible;
            /*0x1d0*/ UnityEngine.Coroutine m_BlinkCoroutine;
            /*0x1d8*/ float m_BlinkStartTime;
            /*0x1dc*/ int m_DrawStart;
            /*0x1e0*/ int m_DrawEnd;
            /*0x1e8*/ UnityEngine.Coroutine m_DragCoroutine;
            /*0x1f0*/ string m_OriginalText;
            /*0x1f8*/ bool m_WasCanceled;
            /*0x1f9*/ bool m_HasDoneFocusTransition;
            /*0x200*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
            /*0x208*/ bool m_TouchKeyboardAllowsInPlaceEditing;
            /*0x209*/ bool m_IsCompositionActive;
            /*0x210*/ UnityEngine.Event m_ProcessingEvent;

            static /*0x16bc4e8*/ InputField();
            static /*0x16b548c*/ string get_clipboard();
            static /*0x16b5494*/ void set_clipboard(string value);
            static /*0x16ba22c*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x16b73b0*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x16b2dbc*/ InputField();
            /*0x16b2c18*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x16b2d28*/ string get_compositionString();
            /*0x16b30c0*/ UnityEngine.Mesh get_mesh();
            /*0x16b3168*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x16b31d4*/ void set_shouldHideMobileInput(bool value);
            /*0x16b322c*/ bool get_shouldHideMobileInput();
            /*0x16b3274*/ void set_shouldActivateOnSelect(bool value);
            /*0x16b3280*/ bool get_shouldActivateOnSelect();
            /*0x16b32ac*/ string get_text();
            /*0x16b32b4*/ void set_text(string value);
            /*0x16b35c8*/ void SetTextWithoutNotify(string input);
            /*0x16b32bc*/ void SetText(string value, bool sendCallback);
            /*0x16b3b44*/ bool get_isFocused();
            /*0x16b3b4c*/ float get_caretBlinkRate();
            /*0x16b3b54*/ void set_caretBlinkRate(float value);
            /*0x16b3c24*/ int get_caretWidth();
            /*0x16b3c2c*/ void set_caretWidth(int value);
            /*0x16b3cf8*/ UnityEngine.UI.Text get_textComponent();
            /*0x16b3d00*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x16b3fa4*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x16b3fac*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x16b4004*/ UnityEngine.Color get_caretColor();
            /*0x16b4048*/ void set_caretColor(UnityEngine.Color value);
            /*0x16b4074*/ bool get_customCaretColor();
            /*0x16b407c*/ void set_customCaretColor(bool value);
            /*0x16b4098*/ UnityEngine.Color get_selectionColor();
            /*0x16b40ac*/ void set_selectionColor(UnityEngine.Color value);
            /*0x16b40d8*/ UnityEngine.UI.InputField.EndEditEvent get_onEndEdit();
            /*0x16b40e0*/ void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value);
            /*0x16b4138*/ UnityEngine.UI.InputField.SubmitEvent get_onSubmit();
            /*0x16b4140*/ void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x16b4198*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x16b41a0*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x16b41fc*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x16b41a4*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x16b4204*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x16b420c*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x16b4264*/ int get_characterLimit();
            /*0x16b426c*/ void set_characterLimit(int value);
            /*0x16b432c*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x16b4334*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x16b4464*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x16b446c*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x16b4584*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x16b458c*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x16b4628*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x16b4630*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x16b4638*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x16b46bc*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x16b46c4*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x16b4748*/ bool get_readOnly();
            /*0x16b4750*/ void set_readOnly(bool value);
            /*0x16b475c*/ bool get_multiLine();
            /*0x16b4770*/ char get_asteriskChar();
            /*0x16b4778*/ void set_asteriskChar(char value);
            /*0x16b47ec*/ bool get_wasCanceled();
            /*0x16b47f4*/ void ClampPos(ref int pos);
            /*0x16b482c*/ int get_caretPositionInternal();
            /*0x16b4850*/ void set_caretPositionInternal(int value);
            /*0x16b4888*/ int get_caretSelectPositionInternal();
            /*0x16b48ac*/ void set_caretSelectPositionInternal(int value);
            /*0x16b48e4*/ bool get_hasSelection();
            /*0x16b4914*/ int get_caretPosition();
            /*0x16b4938*/ void set_caretPosition(int value);
            /*0x16b4a18*/ int get_selectionAnchorPosition();
            /*0x16b4960*/ void set_selectionAnchorPosition(int value);
            /*0x16b4a3c*/ int get_selectionFocusPosition();
            /*0x16b49bc*/ void set_selectionFocusPosition(int value);
            /*0x16b4a60*/ void Awake();
            /*0x16b4b20*/ void OnEnable();
            /*0x16b4d8c*/ void OnDisable();
            /*0x16b513c*/ void OnDestroy();
            /*0x16b51a0*/ System.Collections.IEnumerator CaretBlink();
            /*0x16b5230*/ void SetCaretVisible();
            /*0x16b3bd0*/ void SetCaretActive();
            /*0x16b5268*/ void UpdateCaretMaterial();
            /*0x16b5378*/ void OnFocus();
            /*0x16b537c*/ void SelectAll();
            /*0x16b53b0*/ void MoveTextEnd(bool shift);
            /*0x16b5410*/ void MoveTextStart(bool shift);
            /*0x16b549c*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x16b551c*/ bool InPlaceEditing();
            /*0x16b554c*/ bool InPlaceEditingChanged();
            /*0x16b55d0*/ void UpdateCaretFromKeyboard();
            /*0x16b56b8*/ void LateUpdate();
            /*0x16b6c9c*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x16b6f0c*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x16b711c*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x16b7514*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b75ec*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b760c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b77f4*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b7890*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b78ac*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b7a9c*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x16b8530*/ bool IsValidChar(char c);
            /*0x16b85a0*/ void ProcessEvent(UnityEngine.Event e);
            /*0x16b85a4*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x16b801c*/ string GetSelectedString();
            /*0x16b872c*/ int FindtNextWordBegin();
            /*0x16b83ec*/ void MoveRight(bool shift, bool ctrl);
            /*0x16b87e8*/ int FindtPrevWordBegin();
            /*0x16b82c0*/ void MoveLeft(bool shift, bool ctrl);
            /*0x16b8888*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x16b8998*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x16b8cf0*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x16b8524*/ void MoveDown(bool shift);
            /*0x16b8fa4*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x16b8518*/ void MoveUp(bool shift);
            /*0x16b90d8*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x16b80c4*/ void Delete();
            /*0x16b7f78*/ void ForwardSpace();
            /*0x16b7e74*/ void Backspace();
            /*0x16b9218*/ void Insert(char c);
            /*0x16b8278*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x16b6c84*/ void SendOnValueChangedAndUpdateLabel();
            /*0x16b36a8*/ void SendOnValueChanged();
            /*0x16b92f8*/ void SendOnEndEdit();
            /*0x16b6530*/ void SendOnSubmit();
            /*0x16b9378*/ void Append(string input);
            /*0x16b9434*/ void Append(char input);
            /*0x16b3728*/ void UpdateLabel();
            /*0x16ba1c0*/ bool IsSelectionVisible();
            /*0x16b96a4*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x16ba37c*/ void ForceLabelUpdate();
            /*0x16b3ca0*/ void MarkGeometryAsDirty();
            /*0x16ba380*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x16ba7e0*/ void LayoutComplete();
            /*0x16ba7e4*/ void GraphicUpdateComplete();
            /*0x16ba390*/ void UpdateGeometry();
            /*0x16b6030*/ void AssignPositioningIfNeeded();
            /*0x16ba7e8*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x16baa60*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x16bbe90*/ void CreateCursorVerts();
            /*0x16bb434*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x16b65b0*/ char Validate(string text, int pos, char ch);
            /*0x16bbfe0*/ void ActivateInputField();
            /*0x16b5ce0*/ void ActivateInputFieldInternal();
            /*0x16bc100*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x16bc13c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x16b4fc0*/ void DeactivateInputField();
            /*0x16bc160*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x16bc18c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x16b43a8*/ void EnforceContentType();
            /*0x16b302c*/ void EnforceTextHOverflow();
            /*0x16b452c*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x16b4610*/ void SetToCustom();
            /*0x16bc1d4*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x16bc200*/ void CalculateLayoutInputHorizontal();
            /*0x16bc204*/ void CalculateLayoutInputVertical();
            /*0x16bc208*/ float get_minWidth();
            /*0x16bc210*/ float get_preferredWidth();
            /*0x16bc36c*/ float get_flexibleWidth();
            /*0x16bc374*/ float get_minHeight();
            /*0x16bc37c*/ float get_preferredHeight();
            /*0x16bc4d8*/ float get_flexibleHeight();
            /*0x16bc4e0*/ int get_layoutPriority();
            /*0x16bc588*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x16b35d0*/ OnValidateInput(object object, nint method);
                /*0x16bc590*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x16bc5a4*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x16bc664*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x16b2f54*/ SubmitEvent();
            }

            class EndEditEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x16b2f9c*/ EndEditEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x16b2fe4*/ OnChangeEvent();
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

                /*0x16b5208*/ <CaretBlink>d__172(int <>1__state);
                /*0x16bc68c*/ void System.IDisposable.Dispose();
                /*0x16bc690*/ bool MoveNext();
                /*0x16bc79c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x16bc7a4*/ void System.Collections.IEnumerator.Reset();
                /*0x16bc7e4*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__194 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x16b7868*/ <MouseDragOutsideRect>d__194(int <>1__state);
                /*0x16bc7ec*/ void System.IDisposable.Dispose();
                /*0x16bc7f0*/ bool MoveNext();
                /*0x16bca98*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x16bcaa0*/ void System.Collections.IEnumerator.Reset();
                /*0x16bcae0*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x16bcc78*/ AspectRatioFitter();
            /*0x16bcae8*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x16bcaf0*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x16bcb68*/ float get_aspectRatio();
            /*0x16bcb70*/ void set_aspectRatio(float value);
            /*0x16bcbe4*/ UnityEngine.RectTransform get_rectTransform();
            /*0x16bcc88*/ void OnEnable();
            /*0x16bcd20*/ void Start();
            /*0x16bce64*/ void OnDisable();
            /*0x16bd2cc*/ void OnTransformParentChanged();
            /*0x16bd364*/ void Update();
            /*0x16bd378*/ void OnRectTransformDimensionsChange();
            /*0x16bd37c*/ void UpdateRect();
            /*0x16bd790*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x16bd680*/ UnityEngine.Vector2 GetParentSize();
            /*0x16bd888*/ void SetLayoutHorizontal();
            /*0x16bd88c*/ void SetLayoutVertical();
            /*0x16bcb64*/ void SetDirty();
            /*0x16bcd70*/ bool IsComponentValidOnObject();
            /*0x16bce3c*/ bool IsAspectModeValid();
            /*0x16bd890*/ bool DoesParentExists();

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

            /*0x16bd9a8*/ CanvasScaler();
            /*0x16bd898*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x16bd8a0*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x16bd8a8*/ float get_referencePixelsPerUnit();
            /*0x16bd8b0*/ void set_referencePixelsPerUnit(float value);
            /*0x16bd8b8*/ float get_scaleFactor();
            /*0x16bd8c0*/ void set_scaleFactor(float value);
            /*0x16bd8d4*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x16bd8dc*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x16bd940*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x16bd948*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x16bd950*/ float get_matchWidthOrHeight();
            /*0x16bd958*/ void set_matchWidthOrHeight(float value);
            /*0x16bd960*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x16bd968*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0x16bd970*/ float get_fallbackScreenDPI();
            /*0x16bd978*/ void set_fallbackScreenDPI(float value);
            /*0x16bd980*/ float get_defaultSpriteDPI();
            /*0x16bd988*/ void set_defaultSpriteDPI(float value);
            /*0x16bd998*/ float get_dynamicPixelsPerUnit();
            /*0x16bd9a0*/ void set_dynamicPixelsPerUnit(float value);
            /*0x16bd9f0*/ void OnEnable();
            /*0x16bdabc*/ void Canvas_preWillRenderCanvases();
            /*0x16bdacc*/ void OnDisable();
            /*0x16bdbf4*/ void Handle();
            /*0x16bdcf0*/ void HandleWorldCanvas();
            /*0x16bdd10*/ void HandleConstantPixelSize();
            /*0x16bdd30*/ void HandleScaleWithScreenSize();
            /*0x16bdf64*/ void HandleConstantPhysicalSize();
            /*0x16bdb74*/ void SetScaleFactor(float scaleFactor);
            /*0x16bdbb4*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

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

            /*0x16be1e0*/ ContentSizeFitter();
            /*0x16bdfd0*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x16bdfd8*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x16be0d0*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x16be0d8*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x16be14c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x16be1e8*/ void OnEnable();
            /*0x16be204*/ void OnDisable();
            /*0x16be280*/ void OnRectTransformDimensionsChange();
            /*0x16be284*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x16be380*/ void SetLayoutHorizontal();
            /*0x16be3a4*/ void SetLayoutVertical();
            /*0x16be04c*/ void SetDirty();

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

            /*0x16be618*/ GridLayoutGroup();
            /*0x16be3ac*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x16be3b4*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x16be410*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x16be418*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x16be474*/ UnityEngine.Vector2 get_cellSize();
            /*0x16be47c*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x16be4e0*/ UnityEngine.Vector2 get_spacing();
            /*0x16be4e8*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x16be54c*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x16be554*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x16be5b0*/ int get_constraintCount();
            /*0x16be5b8*/ void set_constraintCount(int value);
            /*0x16be7ac*/ void CalculateLayoutInputHorizontal();
            /*0x16bedb8*/ void CalculateLayoutInputVertical();
            /*0x16bf074*/ void SetLayoutHorizontal();
            /*0x16bf654*/ void SetLayoutVertical();
            /*0x16bf07c*/ void SetCellsAlongAxis(int axis);

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
            /*0x16bf870*/ HorizontalLayoutGroup();
            /*0x16bf888*/ void CalculateLayoutInputHorizontal();
            /*0x16bfb4c*/ void CalculateLayoutInputVertical();
            /*0x16bfb58*/ void SetLayoutHorizontal();
            /*0x16c01d0*/ void SetLayoutVertical();
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

            /*0x16bf87c*/ HorizontalOrVerticalLayoutGroup();
            /*0x16c01dc*/ float get_spacing();
            /*0x16c01e4*/ void set_spacing(float value);
            /*0x16c0240*/ bool get_childForceExpandWidth();
            /*0x16c0248*/ void set_childForceExpandWidth(bool value);
            /*0x16c02a4*/ bool get_childForceExpandHeight();
            /*0x16c02ac*/ void set_childForceExpandHeight(bool value);
            /*0x16c0308*/ bool get_childControlWidth();
            /*0x16c0310*/ void set_childControlWidth(bool value);
            /*0x16c036c*/ bool get_childControlHeight();
            /*0x16c0374*/ void set_childControlHeight(bool value);
            /*0x16c03d0*/ bool get_childScaleWidth();
            /*0x16c03d8*/ void set_childScaleWidth(bool value);
            /*0x16c0434*/ bool get_childScaleHeight();
            /*0x16c043c*/ void set_childScaleHeight(bool value);
            /*0x16c0498*/ bool get_reverseArrangement();
            /*0x16c04a0*/ void set_reverseArrangement(bool value);
            /*0x16bf8a8*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x16bfb64*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x16c04fc*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
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

            /*0x16c112c*/ LayoutElement();
            /*0x16c0c8c*/ bool get_ignoreLayout();
            /*0x16c0c94*/ void set_ignoreLayout(bool value);
            /*0x16c0dc0*/ void CalculateLayoutInputHorizontal();
            /*0x16c0dc4*/ void CalculateLayoutInputVertical();
            /*0x16c0dc8*/ float get_minWidth();
            /*0x16c0dd0*/ void set_minWidth(float value);
            /*0x16c0e44*/ float get_minHeight();
            /*0x16c0e4c*/ void set_minHeight(float value);
            /*0x16c0ec0*/ float get_preferredWidth();
            /*0x16c0ec8*/ void set_preferredWidth(float value);
            /*0x16c0f3c*/ float get_preferredHeight();
            /*0x16c0f44*/ void set_preferredHeight(float value);
            /*0x16c0fb8*/ float get_flexibleWidth();
            /*0x16c0fc0*/ void set_flexibleWidth(float value);
            /*0x16c1034*/ float get_flexibleHeight();
            /*0x16c103c*/ void set_flexibleHeight(float value);
            /*0x16c10b0*/ int get_layoutPriority();
            /*0x16c10b8*/ void set_layoutPriority(int value);
            /*0x16c1150*/ void OnEnable();
            /*0x16c116c*/ void OnTransformParentChanged();
            /*0x16c1170*/ void OnDisable();
            /*0x16c118c*/ void OnDidApplyAnimationProperties();
            /*0x16c1190*/ void OnBeforeTransformParentChanged();
            /*0x16c0d08*/ void SetDirty();
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

            /*0x16be680*/ LayoutGroup();
            /*0x16c1194*/ UnityEngine.RectOffset get_padding();
            /*0x16c119c*/ void set_padding(UnityEngine.RectOffset value);
            /*0x16c11f8*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x16c1200*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x16befe0*/ UnityEngine.RectTransform get_rectTransform();
            /*0x16c125c*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x16be978*/ void CalculateLayoutInputHorizontal();
            void CalculateLayoutInputVertical();
            /*0x16c1264*/ float get_minWidth();
            /*0x16c126c*/ float get_preferredWidth();
            /*0x16c1274*/ float get_flexibleWidth();
            /*0x16c127c*/ float get_minHeight();
            /*0x16c1284*/ float get_preferredHeight();
            /*0x16c128c*/ float get_flexibleHeight();
            /*0x16c1294*/ int get_layoutPriority();
            void SetLayoutHorizontal();
            void SetLayoutVertical();
            /*0x16c129c*/ void OnEnable();
            /*0x16c138c*/ void OnDisable();
            /*0x16c1408*/ void OnDidApplyAnimationProperties();
            /*0x16c0c0c*/ float GetTotalMinSize(int axis);
            /*0x16c0b24*/ float GetTotalPreferredSize(int axis);
            /*0x16c0b98*/ float GetTotalFlexibleSize(int axis);
            /*0x16bf65c*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x16c0614*/ float GetAlignmentOnAxis(int axis);
            /*0x16bed34*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x16c140c*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x16c08e4*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x16bf7c0*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x16c0660*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x16c14b4*/ bool get_isRootLayoutGroup();
            /*0x16c15ec*/ void OnRectTransformDimensionsChange();
            /*0x16c161c*/ void OnTransformChildrenChanged();
            void SetProperty<T>(ref T currentValue, T newValue);
            /*0x16c12b8*/ void SetDirty();
            /*0x16c1620*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x16c1688*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x16c16b0*/ void System.IDisposable.Dispose();
                /*0x16c16b4*/ bool MoveNext();
                /*0x16c173c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x16c1744*/ void System.Collections.IEnumerator.Reset();
                /*0x16c1784*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x16c17cc*/ LayoutRebuilder();
            static /*0x16c19a4*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x16c1a60*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x16c1b5c*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x16bcee0*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x16c25bc*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x16c27b0*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x16c2a5c*/ LayoutRebuilder();
            /*0x16c178c*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x16c17c0*/ void Clear();
            /*0x16c19f8*/ UnityEngine.Transform get_transform();
            /*0x16c1a00*/ bool IsDestroyed();
            /*0x16c1c38*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x16c21ec*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x16c1eec*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x16c2914*/ void LayoutComplete();
            /*0x16c2994*/ void GraphicUpdateComplete();
            /*0x16c2998*/ int GetHashCode();
            /*0x16c29a0*/ bool Equals(object obj);
            /*0x16c29f0*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x16c2a64*/ <>c();
                /*0x16c2ac8*/ <>c();
                /*0x16c2ad0*/ UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0();
                /*0x16c2b2c*/ void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x);
                /*0x16c2b48*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x16c2bd4*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x16c2c90*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x16c2d4c*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x16c2e0c*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x16be368*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x16be374*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x16c0c80*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x16c2fbc*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x16c3240*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x16c34c4*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x16c2ecc*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x16c30ac*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x16c33d4*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x16c35b4*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x16c35cc*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

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

                static /*0x16c38dc*/ <>c();
                /*0x16c3940*/ <>c();
                /*0x16c3948*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x16c39e8*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x16c3a88*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x16c3b28*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x16c3bc8*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x16c3c68*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x16c3d08*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x16c3da8*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x16c3e48*/ VerticalLayoutGroup();
            /*0x16c3e54*/ void CalculateLayoutInputHorizontal();
            /*0x16c3e74*/ void CalculateLayoutInputVertical();
            /*0x16c3e80*/ void SetLayoutHorizontal();
            /*0x16c3e8c*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x18*/ UnityEngine.RectTransform m_RectTransform;
            /*0x20*/ bool m_ShowMaskGraphic;
            /*0x28*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x30*/ UnityEngine.Material m_MaskMaterial;
            /*0x38*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x16c4000*/ Mask();
            /*0x16c3e98*/ UnityEngine.RectTransform get_rectTransform();
            /*0x16c3ef0*/ bool get_showMaskGraphic();
            /*0x16c3ef8*/ void set_showMaskGraphic(bool value);
            /*0x16c3fa8*/ UnityEngine.UI.Graphic get_graphic();
            /*0x16c4010*/ bool MaskEnabled();
            /*0x16c40a0*/ void OnSiblingGraphicEnabledDisabled();
            /*0x16c40a4*/ void OnEnable();
            /*0x16c4474*/ void OnDisable();
            /*0x16c4638*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x16c46e4*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
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

            /*0x16c5a38*/ MaskableGraphic();
            /*0x16c4da0*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x16c4da8*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x16c4db0*/ bool get_maskable();
            /*0x16c4db8*/ void set_maskable(bool value);
            /*0x16c4de8*/ bool get_isMaskingGraphic();
            /*0x16c4204*/ void set_isMaskingGraphic(bool value);
            /*0x16c4df0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x16c4ef0*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x16c5128*/ void UpdateCull(bool cull);
            /*0x16c5204*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x16c5270*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x16c52a8*/ void OnEnable();
            /*0x16c544c*/ void OnDisable();
            /*0x16c54f8*/ void OnTransformParentChanged();
            /*0x16c5548*/ void ParentMaskStateChanged();
            /*0x16c554c*/ void OnCanvasHierarchyChanged();
            /*0x16c4f44*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x16c52f8*/ void UpdateClipParent();
            /*0x16c59b8*/ void RecalculateClipping();
            /*0x16c59bc*/ void RecalculateMasking();
            /*0x16c5b44*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x16c5afc*/ CullStateChangedEvent();
            }
        }

        class MaskUtilities
        {
            static /*0x16c5b4c*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x16c421c*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x16c4978*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x16c4b18*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x16c5da8*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x16c559c*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x16c5ef8*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x16c625c*/ MaskUtilities();
        }

        interface IMaterialModifier
        {
            UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x1815658*/ void Destroy(UnityEngine.Object obj);
            static /*0x1815758*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x1815800*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x1815868*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x1815d34*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0x1815cd0*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0x1815cd8*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0x1815ce0*/ bool get_wrapAround();
            /*0x1815ce8*/ void set_wrapAround(bool value);
            /*0x1815cf4*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0x1815cfc*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0x1815d04*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0x1815d0c*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0x1815d14*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0x1815d1c*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0x1815d24*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0x1815d2c*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0x1815d54*/ bool Equals(UnityEngine.UI.Navigation other);

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

            /*0x1815e6c*/ RawImage();
            /*0x1815ebc*/ UnityEngine.Texture get_mainTexture();
            /*0x1816014*/ UnityEngine.Texture get_texture();
            /*0x181601c*/ void set_texture(UnityEngine.Texture value);
            /*0x18160c8*/ UnityEngine.Rect get_uvRect();
            /*0x18160d4*/ void set_uvRect(UnityEngine.Rect value);
            /*0x1816154*/ void SetNativeSize();
            /*0x1816434*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x1817514*/ void OnDidApplyAnimationProperties();
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

            /*0x1817780*/ RectMask2D();
            /*0x1817544*/ UnityEngine.Vector4 get_padding();
            /*0x1817550*/ void set_padding(UnityEngine.Vector4 value);
            /*0x1817560*/ UnityEngine.Vector2Int get_softness();
            /*0x1817568*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x1817584*/ UnityEngine.Canvas get_Canvas();
            /*0x18176e4*/ UnityEngine.Rect get_canvasRect();
            /*0x1817728*/ UnityEngine.RectTransform get_rectTransform();
            /*0x18178d8*/ void OnEnable();
            /*0x181790c*/ void OnDisable();
            /*0x18179dc*/ void OnDestroy();
            /*0x18179fc*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x1817ad8*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x1817bf4*/ void PerformClipping();
            /*0x1818318*/ void UpdateClipSoftness();
            /*0x181860c*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x1818720*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x18188c0*/ void OnTransformParentChanged();
            /*0x18188e4*/ void OnCanvasHierarchyChanged();
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

            /*0x1818c80*/ Scrollbar();
            /*0x1818908*/ UnityEngine.RectTransform get_handleRect();
            /*0x1818910*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x1818c04*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x1818c0c*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x1818ea8*/ float get_value();
            /*0x1818f60*/ void set_value(float value);
            /*0x181902c*/ void SetValueWithoutNotify(float input);
            /*0x1819034*/ float get_size();
            /*0x181903c*/ void set_size(float value);
            /*0x18190c0*/ int get_numberOfSteps();
            /*0x18190c8*/ void set_numberOfSteps(int value);
            /*0x181914c*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x1819154*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x181915c*/ float get_stepSize();
            /*0x1819188*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x181918c*/ void LayoutComplete();
            /*0x1819190*/ void GraphicUpdateComplete();
            /*0x1819194*/ void OnEnable();
            /*0x181946c*/ void OnDisable();
            /*0x18195b4*/ void Update();
            /*0x181898c*/ void UpdateCachedReferences();
            /*0x1818f68*/ void Set(float input, bool sendCallback);
            /*0x18195c8*/ void OnRectTransformDimensionsChange();
            /*0x1819600*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x1819610*/ bool get_reverseValue();
            /*0x1818a6c*/ void UpdateVisuals();
            /*0x1819624*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819888*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x18198ec*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819950*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819b0c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819b9c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819dd8*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819d4c*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x1819e40*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819e80*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x181a1d0*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x181a2cc*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x181a3c8*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x181a4c4*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x181a5c0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181a5d8*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x181a750*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x1818d48*/ ScrollEvent();
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

                /*0x1819e18*/ <ClickRepeat>d__58(int <>1__state);
                /*0x181a758*/ void System.IDisposable.Dispose();
                /*0x181a75c*/ bool MoveNext();
                /*0x181a9d0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x181a9d8*/ void System.Collections.IEnumerator.Reset();
                /*0x181aa18*/ object System.Collections.IEnumerator.get_Current();
            }
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

            static /*0x181c820*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x181dfdc*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x181e0d0*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x181e17c*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x181e2d4*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x181b0d4*/ ScrollRect();
            /*0x181aa20*/ UnityEngine.RectTransform get_content();
            /*0x181aa28*/ void set_content(UnityEngine.RectTransform value);
            /*0x181aa30*/ bool get_horizontal();
            /*0x181aa38*/ void set_horizontal(bool value);
            /*0x181aa44*/ bool get_vertical();
            /*0x181aa4c*/ void set_vertical(bool value);
            /*0x181aa58*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0x181aa60*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x181aa68*/ float get_elasticity();
            /*0x181aa70*/ void set_elasticity(float value);
            /*0x181aa78*/ bool get_inertia();
            /*0x181aa80*/ void set_inertia(bool value);
            /*0x181aa8c*/ float get_decelerationRate();
            /*0x181aa94*/ void set_decelerationRate(float value);
            /*0x181aa9c*/ float get_scrollSensitivity();
            /*0x181aaa4*/ void set_scrollSensitivity(float value);
            /*0x181aaac*/ UnityEngine.RectTransform get_viewport();
            /*0x181aab4*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x181ab70*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x181ab78*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x181acec*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x181acf4*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x181ae68*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x181ae70*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x181ae78*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x181ae80*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x181ae88*/ float get_horizontalScrollbarSpacing();
            /*0x181ae90*/ void set_horizontalScrollbarSpacing(float value);
            /*0x181af20*/ float get_verticalScrollbarSpacing();
            /*0x181af28*/ void set_verticalScrollbarSpacing(float value);
            /*0x181af30*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0x181af38*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x181af40*/ UnityEngine.RectTransform get_viewRect();
            /*0x181b030*/ UnityEngine.Vector2 get_velocity();
            /*0x181b038*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x181b040*/ UnityEngine.RectTransform get_rectTransform();
            /*0x181b220*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x181bd88*/ void LayoutComplete();
            /*0x181bd8c*/ void GraphicUpdateComplete();
            /*0x181b2a8*/ void UpdateCachedData();
            /*0x181bd90*/ void OnEnable();
            /*0x181bf3c*/ void OnDisable();
            /*0x181c16c*/ bool IsActive();
            /*0x181c1ec*/ void EnsureLayoutHasRebuilt();
            /*0x181c260*/ void StopMovement();
            /*0x181c2b0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x181c458*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181c4b8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181c5e0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181c600*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181c85c*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x181c910*/ void LateUpdate();
            /*0x181bcac*/ void UpdatePrevData();
            /*0x181bad4*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x181cea4*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x181d1cc*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x181cf14*/ float get_horizontalNormalizedPosition();
            /*0x181d214*/ void set_horizontalNormalizedPosition(float value);
            /*0x181d070*/ float get_verticalNormalizedPosition();
            /*0x181d228*/ void set_verticalNormalizedPosition(float value);
            /*0x181d23c*/ void SetHorizontalNormalizedPosition(float value);
            /*0x181d250*/ void SetVerticalNormalizedPosition(float value);
            /*0x181d264*/ void SetNormalizedPosition(float value, int axis);
            /*0x181d55c*/ void OnRectTransformDimensionsChange();
            /*0x181d560*/ bool get_hScrollingNeeded();
            /*0x181d5bc*/ bool get_vScrollingNeeded();
            /*0x181d618*/ void CalculateLayoutInputHorizontal();
            /*0x181d61c*/ void CalculateLayoutInputVertical();
            /*0x181d620*/ float get_minWidth();
            /*0x181d628*/ float get_preferredWidth();
            /*0x181d630*/ float get_flexibleWidth();
            /*0x181d638*/ float get_minHeight();
            /*0x181d640*/ float get_preferredHeight();
            /*0x181d648*/ float get_flexibleHeight();
            /*0x181d650*/ int get_layoutPriority();
            /*0x181d658*/ void SetLayoutHorizontal();
            /*0x181dcac*/ void SetLayoutVertical();
            /*0x181ced4*/ void UpdateScrollbarVisibility();
            /*0x181dd88*/ void UpdateScrollbarLayout();
            /*0x181b620*/ void UpdateBounds();
            /*0x181dbb0*/ UnityEngine.Bounds GetBounds();
            /*0x181c428*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x181ae98*/ void SetDirty();
            /*0x181aabc*/ void SetDirtyCaching();
            /*0x181e458*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x181b1d8*/ ScrollRectEvent();
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

            static /*0x181feb0*/ Selectable();
            static /*0x181e460*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x181e4fc*/ int get_allSelectableCount();
            static /*0x181e554*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x181e5f8*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x181fa34*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x1818d90*/ Selectable();
            /*0x181e6b4*/ UnityEngine.UI.Navigation get_navigation();
            /*0x181e6c8*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0x181e7b4*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x181e7bc*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x181e830*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x181e840*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x181e8d8*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x181e8e8*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x181e964*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x181e96c*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x181e9e0*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x181e9e8*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x181ea5c*/ bool get_interactable();
            /*0x181ea64*/ void set_interactable(bool value);
            /*0x181ebd4*/ bool get_isPointerInside();
            /*0x181ebdc*/ void set_isPointerInside(bool value);
            /*0x181ebe8*/ bool get_isPointerDown();
            /*0x181ebf0*/ void set_isPointerDown(bool value);
            /*0x181ebfc*/ bool get_hasSelection();
            /*0x181ec04*/ void set_hasSelection(bool value);
            /*0x181ec10*/ UnityEngine.UI.Image get_image();
            /*0x181ec8c*/ void set_image(UnityEngine.UI.Image value);
            /*0x181ec94*/ UnityEngine.Animator get_animator();
            /*0x181ecdc*/ void Awake();
            /*0x181ed68*/ void OnCanvasGroupChanged();
            /*0x181ef28*/ bool IsInteractable();
            /*0x181ef48*/ void OnDidApplyAnimationProperties();
            /*0x18191c4*/ void OnEnable();
            /*0x181ef9c*/ void OnTransformParentChanged();
            /*0x181e750*/ void OnSetProperty();
            /*0x181948c*/ void OnDisable();
            /*0x181efc4*/ void OnApplicationFocus(bool hasFocus);
            /*0x181ef4c*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x181f06c*/ void InstantClearState();
            /*0x181f3f4*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x181f588*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x181fbd8*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x181a1f4*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x181a2f0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x181a3ec*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x181a4e8*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x181a144*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x181f0dc*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x181f1c4*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x181f26c*/ void TriggerAnimation(string triggername);
            /*0x181fc90*/ bool IsHighlighted();
            /*0x181f020*/ bool IsPressed();
            /*0x181fcec*/ void EvaluateAndTransitionToSelectionState();
            /*0x1819c1c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1819e58*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181fd84*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181fd90*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x181fd98*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x181fda4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x181fdac*/ void Select();

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
            static /*0x181ff24*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
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

            /*0x1820a64*/ Slider();
            /*0x181ff6c*/ UnityEngine.RectTransform get_fillRect();
            /*0x181ff74*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x182057c*/ UnityEngine.RectTransform get_handleRect();
            /*0x1820584*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x1820600*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x1820608*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x182067c*/ float get_minValue();
            /*0x1820684*/ void set_minValue(float value);
            /*0x1820714*/ float get_maxValue();
            /*0x182071c*/ void set_maxValue(float value);
            /*0x18207ac*/ bool get_wholeNumbers();
            /*0x18207b4*/ void set_wholeNumbers(bool value);
            /*0x1820844*/ float get_value();
            /*0x18208e4*/ void set_value(float value);
            /*0x18208f8*/ void SetValueWithoutNotify(float input);
            /*0x182090c*/ float get_normalizedValue();
            /*0x18209f0*/ void set_normalizedValue(float value);
            /*0x1820a28*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x1820a30*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x1820a38*/ float get_stepSize();
            /*0x1820b70*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x1820b74*/ void LayoutComplete();
            /*0x1820b78*/ void GraphicUpdateComplete();
            /*0x1820b7c*/ void OnEnable();
            /*0x1820bb8*/ void OnDisable();
            /*0x1820bd8*/ void Update();
            /*0x1820c18*/ void OnDidApplyAnimationProperties();
            /*0x181fff0*/ void UpdateCachedReferences();
            /*0x1820e08*/ float ClampValue(float input);
            /*0x1820ee0*/ void Set(float input, bool sendCallback);
            /*0x1820fa4*/ void OnRectTransformDimensionsChange();
            /*0x1820ed0*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x1820ebc*/ bool get_reverseValue();
            /*0x1820294*/ void UpdateVisuals();
            /*0x1820fdc*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x1821214*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1821278*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1821430*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1821480*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x18216cc*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x18216f0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x1821714*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x1821738*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x182175c*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1821774*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x18218ec*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x1820b28*/ SliderEvent();
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

            /*0x18218f4*/ UnityEngine.Sprite get_highlightedSprite();
            /*0x18218fc*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0x1821904*/ UnityEngine.Sprite get_pressedSprite();
            /*0x182190c*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0x1821914*/ UnityEngine.Sprite get_selectedSprite();
            /*0x182191c*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0x1821924*/ UnityEngine.Sprite get_disabledSprite();
            /*0x182192c*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0x1821934*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x182274c*/ StencilMaterial();
            static /*0x1821a3c*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x1821a44*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x18223e8*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x1821ad0*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x1822470*/ void Remove(UnityEngine.Material customMat);
            static /*0x1822630*/ void ClearAll();

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

                /*0x1822460*/ MatEntry();
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

            static /*0x18238c4*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x18227d8*/ Text();
            /*0x1822870*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x1822908*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x1822974*/ UnityEngine.Texture get_mainTexture();
            /*0x1822b38*/ void FontTextureChanged();
            /*0x1822b1c*/ UnityEngine.Font get_font();
            /*0x1822c44*/ void set_font(UnityEngine.Font value);
            /*0x1822d50*/ string get_text();
            /*0x1822d58*/ void set_text(string value);
            /*0x1822e20*/ bool get_supportRichText();
            /*0x1822e3c*/ void set_supportRichText(bool value);
            /*0x1822e9c*/ bool get_resizeTextForBestFit();
            /*0x1822eb8*/ void set_resizeTextForBestFit(bool value);
            /*0x1822f18*/ int get_resizeTextMinSize();
            /*0x1822f34*/ void set_resizeTextMinSize(int value);
            /*0x1822f88*/ int get_resizeTextMaxSize();
            /*0x1822fa4*/ void set_resizeTextMaxSize(int value);
            /*0x1822ff8*/ UnityEngine.TextAnchor get_alignment();
            /*0x1823014*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x1823068*/ bool get_alignByGeometry();
            /*0x1823084*/ void set_alignByGeometry(bool value);
            /*0x18230cc*/ int get_fontSize();
            /*0x18230e8*/ void set_fontSize(int value);
            /*0x182313c*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x1823158*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x18231ac*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x18231c8*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x182321c*/ float get_lineSpacing();
            /*0x1823238*/ void set_lineSpacing(float value);
            /*0x182328c*/ UnityEngine.FontStyle get_fontStyle();
            /*0x18232a8*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x18232fc*/ float get_pixelsPerUnit();
            /*0x1823444*/ void OnEnable();
            /*0x18234c0*/ void OnDisable();
            /*0x1823524*/ void UpdateGeometry();
            /*0x18235ac*/ void AssignDefaultFont();
            /*0x182361c*/ void AssignDefaultFontIfNecessary();
            /*0x18236d8*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x1823930*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x1824030*/ void CalculateLayoutInputHorizontal();
            /*0x1824034*/ void CalculateLayoutInputVertical();
            /*0x1824038*/ float get_minWidth();
            /*0x1824040*/ float get_preferredWidth();
            /*0x182411c*/ float get_flexibleWidth();
            /*0x1824124*/ float get_minHeight();
            /*0x182412c*/ float get_preferredHeight();
            /*0x18241f4*/ float get_flexibleHeight();
            /*0x18241fc*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x100*/ UnityEngine.UI.Graphic graphic;
            /*0x108*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x110*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x118*/ bool m_IsOn;

            /*0x182442c*/ Toggle();
            /*0x1824204*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x182420c*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x1824500*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x1824504*/ void LayoutComplete();
            /*0x1824508*/ void GraphicUpdateComplete();
            /*0x182450c*/ void OnDestroy();
            /*0x1824978*/ void OnEnable();
            /*0x18249a4*/ void OnDisable();
            /*0x18249c4*/ void OnDidApplyAnimationProperties();
            /*0x182422c*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x1824ecc*/ bool get_isOn();
            /*0x1824ed4*/ void set_isOn(bool value);
            /*0x1824ee0*/ void SetIsOnWithoutNotify(bool value);
            /*0x1824ae8*/ void Set(bool value, bool sendCallback);
            /*0x1824368*/ void PlayEffect(bool instant);
            /*0x1825028*/ void Start();
            /*0x1825030*/ void InternalToggle();
            /*0x1825084*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x18250a8*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x18250ac*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x18244b8*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ bool m_AllowSwitchOff;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x18250c8*/ ToggleGroup();
            /*0x18250b4*/ bool get_allowSwitchOff();
            /*0x18250bc*/ void set_allowSwitchOff(bool value);
            /*0x1825144*/ void Start();
            /*0x1825160*/ void OnEnable();
            /*0x182517c*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x1824dc0*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x1824c5c*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x1824cec*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x182458c*/ void EnsureValidState();
            /*0x1824eec*/ bool AnyTogglesOn();
            /*0x18252d4*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x18253d0*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x1825458*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x1825548*/ <>c();
                /*0x18255ac*/ <>c();
                /*0x18255b4*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x18255cc*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
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

            static /*0x18261f8*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x18255e4*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x1826274*/ Raycast3DCallback(object object, nint method);
                /*0x1826338*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x1826378*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x1826498*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x18264c4*/ RaycastAllCallback(object object, nint method);
                /*0x1826588*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x18265c4*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x18266b0*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x18266bc*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x1826780*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x18267bc*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x18268ac*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x18268d4*/ Raycast2DCallback(object object, nint method);
                /*0x1826998*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x18269ac*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x1826aa8*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x1826ae0*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x1826ba4*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x1826be0*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x1826ccc*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x1826cd8*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x1826d9c*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x1826dd8*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x1826ec8*/ int EndInvoke(System.IAsyncResult result);
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

            static /*0x1828118*/ VertexHelper();
            /*0x1826ef0*/ VertexHelper();
            /*0x1826ef8*/ VertexHelper(UnityEngine.Mesh m);
            /*0x1827130*/ void InitializeListIfRequired();
            /*0x18272c0*/ void Dispose();
            /*0x181714c*/ void Clear();
            /*0x1827474*/ int get_currentVertCount();
            /*0x18274c0*/ int get_currentIndexCount();
            /*0x182750c*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x182766c*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x18277c8*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x182792c*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x1827e28*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x1817268*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x1827f38*/ void AddVert(UnityEngine.UIVertex v);
            /*0x1817398*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x1823f20*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x1827fcc*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x1828078*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x18280c8*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x18281b0*/ BaseVertexEffect();
            void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x18*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x18285d4*/ BaseMeshEffect();
            /*0x18281b8*/ UnityEngine.UI.Graphic get_graphic();
            /*0x182824c*/ void OnEnable();
            /*0x18282f4*/ void OnDisable();
            /*0x1828390*/ void OnDidApplyAnimationProperties();
            /*0x182842c*/ void ModifyMesh(UnityEngine.Mesh mesh);
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
            /*0x18285dc*/ Outline();
            /*0x18285e4*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x19303b8*/ PositionAsUV1();
            /*0x19303c0*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x20*/ UnityEngine.Color m_EffectColor;
            /*0x30*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x38*/ bool m_UseGraphicAlpha;

            /*0x193047c*/ Shadow();
            /*0x19304a4*/ UnityEngine.Color get_effectColor();
            /*0x19304b0*/ void set_effectColor(UnityEngine.Color value);
            /*0x1930584*/ UnityEngine.Vector2 get_effectDistance();
            /*0x193058c*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x1930690*/ bool get_useGraphicAlpha();
            /*0x1930698*/ void set_useGraphicAlpha(bool value);
            /*0x1930750*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x1930a5c*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x1930a64*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;
                /*0x0*/ int m_EnabledObjectCount;

                IndexedSet();
                void Add(T item);
                void Add(T item, bool isActive);
                bool AddUnique(T item, bool isActive);
                bool EnableItem(T item);
                bool DisableItem(T item);
                bool Remove(T item);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int arrayIndex);
                int get_Count();
                int get_Capacity();
                bool get_IsReadOnly();
                int IndexOf(T item);
                void Insert(int index, T item);
                void RemoveAt(int index);
                void Swap(int index1, int index2);
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

                /*0x1930e44*/ UnityEngine.Color get_startColor();
                /*0x1930e50*/ void set_startColor(UnityEngine.Color value);
                /*0x1930e5c*/ UnityEngine.Color get_targetColor();
                /*0x1930e68*/ void set_targetColor(UnityEngine.Color value);
                /*0x1930e74*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0x1930e7c*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0x1930e84*/ float get_duration();
                /*0x1930e8c*/ void set_duration(float value);
                /*0x1930e94*/ bool get_ignoreTimeScale();
                /*0x1930e9c*/ void set_ignoreTimeScale(bool value);
                /*0x1930ea8*/ void TweenValue(float floatPercentage);
                /*0x1930f94*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0x1931064*/ bool GetIgnoreTimescale();
                /*0x193106c*/ float GetDuration();
                /*0x1930f84*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x193101c*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0x1931074*/ float get_startValue();
                /*0x193107c*/ void set_startValue(float value);
                /*0x1931084*/ float get_targetValue();
                /*0x193108c*/ void set_targetValue(float value);
                /*0x1931094*/ float get_duration();
                /*0x193109c*/ void set_duration(float value);
                /*0x19310a4*/ bool get_ignoreTimeScale();
                /*0x19310ac*/ void set_ignoreTimeScale(bool value);
                /*0x19310b8*/ void TweenValue(float floatPercentage);
                /*0x1931154*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0x1931224*/ bool GetIgnoreTimescale();
                /*0x193122c*/ float GetDuration();
                /*0x1931144*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x19311dc*/ FloatTweenCallback();
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

    namespace UIElements
    {
        class PanelEventHandler : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.UIElements.IRuntimePanelComponent
        {
            static /*0x0*/ UnityEngine.EventModifiers s_Modifiers;
            /*0x18*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;
            /*0x20*/ UnityEngine.UIElements.PanelEventHandler.PointerEvent m_PointerEvent;
            /*0x28*/ bool m_Selecting;
            /*0x30*/ UnityEngine.Event m_Event;

            /*0x19337d4*/ PanelEventHandler();
            /*0x1931234*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x193123c*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x1931660*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x1931678*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x193174c*/ void OnEnable();
            /*0x1931754*/ void OnDisable();
            /*0x19314a0*/ void RegisterCallbacks();
            /*0x19312e0*/ void UnregisterCallbacks();
            /*0x193175c*/ void OnPanelDestroyed();
            /*0x1931764*/ void OnElementFocus(UnityEngine.UIElements.FocusEvent e);
            /*0x193184c*/ void OnElementBlur(UnityEngine.UIElements.BlurEvent e);
            /*0x1931850*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x19318c8*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x19318dc*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1931c2c*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1931e4c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x19320d4*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1932388*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x19323dc*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1932594*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x193274c*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x19328d8*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1931bc8*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData);
            /*0x1932a98*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent);
            /*0x1932af8*/ void Update();
            /*0x1932d20*/ void LateUpdate();
            /*0x1932bd8*/ void ProcessImguiEvents(bool isSelected);
            /*0x1932d28*/ void ProcessKeyboardEvent(UnityEngine.Event e);
            /*0x1932d9c*/ void ProcessTabEvent(UnityEngine.Event e);
            /*0x19331ac*/ void SendTabEvent(UnityEngine.Event e, int direction);
            /*0x1932e1c*/ void SendKeyUpEvent(UnityEngine.Event e);
            /*0x1932fd8*/ void SendKeyDownEvent(UnityEngine.Event e);
            /*0x1931a8c*/ bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);

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
                /*0x6c*/ UnityEngine.Vector2 <radius>k__BackingField;
                /*0x74*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
                /*0x7c*/ UnityEngine.EventModifiers <modifiers>k__BackingField;

                static /*0x1933a2c*/ bool <Read>g__InRange|82_0(int i, int start, int count);
                /*0x193386c*/ PointerEvent();
                /*0x193387c*/ int get_pointerId();
                /*0x1933884*/ void set_pointerId(int value);
                /*0x193388c*/ string get_pointerType();
                /*0x1933894*/ void set_pointerType(string value);
                /*0x193389c*/ bool get_isPrimary();
                /*0x19338a4*/ void set_isPrimary(bool value);
                /*0x19338b0*/ int get_button();
                /*0x19338b8*/ void set_button(int value);
                /*0x19338c0*/ int get_pressedButtons();
                /*0x19338c8*/ void set_pressedButtons(int value);
                /*0x19338d0*/ UnityEngine.Vector3 get_position();
                /*0x19338dc*/ void set_position(UnityEngine.Vector3 value);
                /*0x19338e8*/ UnityEngine.Vector3 get_localPosition();
                /*0x19338f4*/ void set_localPosition(UnityEngine.Vector3 value);
                /*0x1933900*/ UnityEngine.Vector3 get_deltaPosition();
                /*0x193390c*/ void set_deltaPosition(UnityEngine.Vector3 value);
                /*0x1933918*/ float get_deltaTime();
                /*0x1933920*/ void set_deltaTime(float value);
                /*0x1933928*/ int get_clickCount();
                /*0x1933930*/ void set_clickCount(int value);
                /*0x1933938*/ float get_pressure();
                /*0x1933940*/ void set_pressure(float value);
                /*0x1933948*/ float get_tangentialPressure();
                /*0x1933950*/ void set_tangentialPressure(float value);
                /*0x1933958*/ float get_altitudeAngle();
                /*0x1933960*/ void set_altitudeAngle(float value);
                /*0x1933968*/ float get_azimuthAngle();
                /*0x1933970*/ void set_azimuthAngle(float value);
                /*0x1933978*/ float get_twist();
                /*0x1933980*/ void set_twist(float value);
                /*0x1933988*/ UnityEngine.Vector2 get_radius();
                /*0x1933990*/ void set_radius(UnityEngine.Vector2 value);
                /*0x1933998*/ UnityEngine.Vector2 get_radiusVariance();
                /*0x19339a0*/ void set_radiusVariance(UnityEngine.Vector2 value);
                /*0x19339a8*/ UnityEngine.EventModifiers get_modifiers();
                /*0x19339b0*/ void set_modifiers(UnityEngine.EventModifiers value);
                /*0x19339b8*/ bool get_shiftKey();
                /*0x19339c4*/ bool get_ctrlKey();
                /*0x19339d0*/ bool get_commandKey();
                /*0x19339dc*/ bool get_altKey();
                /*0x19339e8*/ bool get_actionKey();
                /*0x193332c*/ void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);
                /*0x19337bc*/ void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride);
            }
        }

        class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
        {
            /*0x20*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;

            static /*0x1933c90*/ int ConvertFloatBitsToInt(float f);
            /*0x1934194*/ PanelRaycaster();
            /*0x1933a48*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x1933a50*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x1933b8c*/ void RegisterCallbacks();
            /*0x1933af4*/ void UnregisterCallbacks();
            /*0x1933c24*/ void OnPanelDestroyed();
            /*0x1933c2c*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x1933c44*/ int get_sortOrderPriority();
            /*0x1933c78*/ int get_renderOrderPriority();
            /*0x1933c98*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x193418c*/ UnityEngine.Camera get_eventCamera();

            struct FloatIntBits
            {
                /*0x10*/ float f;
                /*0x10*/ int i;
            }
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x19341c4*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x19341a4*/ UnityEngine.Vector2 get_moveVector();
            /*0x19341ac*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x19341b4*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0x19341bc*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x1934270*/ AbstractEventData();
            /*0x1934254*/ void Reset();
            /*0x193425c*/ void Use();
            /*0x1934268*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0x193422c*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x1934278*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x1934294*/ UnityEngine.GameObject get_selectedObject();
            /*0x19342b0*/ void set_selectedObject(UnityEngine.GameObject value);
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
            /*0x138*/ float <pressure>k__BackingField;
            /*0x13c*/ float <tangentialPressure>k__BackingField;
            /*0x140*/ float <altitudeAngle>k__BackingField;
            /*0x144*/ float <azimuthAngle>k__BackingField;
            /*0x148*/ float <twist>k__BackingField;
            /*0x14c*/ UnityEngine.Vector2 <radius>k__BackingField;
            /*0x154*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
            /*0x15c*/ bool <fullyExited>k__BackingField;
            /*0x15d*/ bool <reentered>k__BackingField;

            /*0x1934744*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x19344f0*/ UnityEngine.GameObject get_pointerEnter();
            /*0x19344f8*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x1934500*/ UnityEngine.GameObject get_lastPress();
            /*0x1934508*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x1934510*/ UnityEngine.GameObject get_rawPointerPress();
            /*0x1934518*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0x1934520*/ UnityEngine.GameObject get_pointerDrag();
            /*0x1934528*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x1934530*/ UnityEngine.GameObject get_pointerClick();
            /*0x1934538*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x1934540*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x1934550*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x1934568*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x1934578*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x1934590*/ bool get_eligibleForClick();
            /*0x1934598*/ void set_eligibleForClick(bool value);
            /*0x19345a4*/ int get_pointerId();
            /*0x19345ac*/ void set_pointerId(int value);
            /*0x19345b4*/ UnityEngine.Vector2 get_position();
            /*0x19345bc*/ void set_position(UnityEngine.Vector2 value);
            /*0x19345c4*/ UnityEngine.Vector2 get_delta();
            /*0x19345cc*/ void set_delta(UnityEngine.Vector2 value);
            /*0x19345d4*/ UnityEngine.Vector2 get_pressPosition();
            /*0x19345e0*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x19345ec*/ UnityEngine.Vector3 get_worldPosition();
            /*0x19345fc*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x193460c*/ UnityEngine.Vector3 get_worldNormal();
            /*0x193461c*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x193462c*/ float get_clickTime();
            /*0x1934634*/ void set_clickTime(float value);
            /*0x193463c*/ int get_clickCount();
            /*0x1934644*/ void set_clickCount(int value);
            /*0x193464c*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x1934658*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x1934664*/ bool get_useDragThreshold();
            /*0x193466c*/ void set_useDragThreshold(bool value);
            /*0x1934678*/ bool get_dragging();
            /*0x1934680*/ void set_dragging(bool value);
            /*0x193468c*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x1934694*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x193469c*/ float get_pressure();
            /*0x19346a4*/ void set_pressure(float value);
            /*0x19346ac*/ float get_tangentialPressure();
            /*0x19346b4*/ void set_tangentialPressure(float value);
            /*0x19346bc*/ float get_altitudeAngle();
            /*0x19346c4*/ void set_altitudeAngle(float value);
            /*0x19346cc*/ float get_azimuthAngle();
            /*0x19346d4*/ void set_azimuthAngle(float value);
            /*0x19346dc*/ float get_twist();
            /*0x19346e4*/ void set_twist(float value);
            /*0x19346ec*/ UnityEngine.Vector2 get_radius();
            /*0x19346f8*/ void set_radius(UnityEngine.Vector2 value);
            /*0x1934704*/ UnityEngine.Vector2 get_radiusVariance();
            /*0x1934710*/ void set_radiusVariance(UnityEngine.Vector2 value);
            /*0x193471c*/ bool get_fullyExited();
            /*0x1934724*/ void set_fullyExited(bool value);
            /*0x1934730*/ bool get_reentered();
            /*0x1934738*/ void set_reentered(bool value);
            /*0x1934870*/ bool IsPointerMoving();
            /*0x193488c*/ bool IsScrolling();
            /*0x19348ac*/ UnityEngine.Camera get_enterEventCamera();
            /*0x193493c*/ UnityEngine.Camera get_pressEventCamera();
            /*0x19349cc*/ UnityEngine.GameObject get_pointerPress();
            /*0x19349d4*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x1934a50*/ string ToString();

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
            void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
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
            static /*0x10*/ UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;
            /*0x20*/ UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;
            /*0x28*/ UnityEngine.GameObject m_FirstSelected;
            /*0x30*/ bool m_sendNavigationEvents;
            /*0x34*/ int m_DragThreshold;
            /*0x38*/ UnityEngine.GameObject m_CurrentSelected;
            /*0x40*/ bool m_HasFocus;
            /*0x41*/ bool m_SelectionGuard;
            /*0x48*/ UnityEngine.EventSystems.BaseEventData m_DummyData;

            static /*0x1937390*/ EventSystem();
            static /*0x1935708*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x19357cc*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x1935bfc*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            static /*0x193648c*/ void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart);
            /*0x19359b4*/ EventSystem();
            /*0x1935960*/ bool get_sendNavigationEvents();
            /*0x1935968*/ void set_sendNavigationEvents(bool value);
            /*0x1935974*/ int get_pixelDragThreshold();
            /*0x193597c*/ void set_pixelDragThreshold(int value);
            /*0x1935984*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x193598c*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x1935994*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0x193599c*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x19359a4*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0x19359ac*/ bool get_isFocused();
            /*0x1935a44*/ void UpdateModules();
            /*0x1935b84*/ bool get_alreadySelecting();
            /*0x19342cc*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x1935b8c*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x1931820*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x1936018*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x1936208*/ bool IsPointerOverGameObject();
            /*0x1936210*/ bool IsPointerOverGameObject(int pointerId);
            /*0x19362b4*/ bool get_isUIToolkitActiveEventSystem();
            /*0x19363a4*/ bool get_sendUIToolkitEvents();
            /*0x1936418*/ bool get_createUIToolkitPanelGameObjectsOnStart();
            /*0x1936628*/ void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x19368cc*/ void Start();
            /*0x1936b0c*/ void OnDestroy();
            /*0x1936bb4*/ void OnEnable();
            /*0x1936cc4*/ void OnDisable();
            /*0x1936dcc*/ void TickModules();
            /*0x1936ecc*/ void OnApplicationFocus(bool hasFocus);
            /*0x1936ee0*/ void Update();
            /*0x1937140*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x1937238*/ string ToString();

            struct UIToolkitOverrideConfig
            {
                /*0x10*/ UnityEngine.EventSystems.EventSystem activeEventSystem;
                /*0x18*/ bool sendEvents;
                /*0x19*/ bool createPanelGameObjectsOnStart;
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.GameObject go;

                /*0x19368c4*/ <>c__DisplayClass52_0();
                /*0x1937480*/ void <CreateUIToolkitPanelGameObject>b__0();
            }
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x1937568*/ EventTrigger();
            /*0x19374dc*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x1937560*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x19374e0*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x1937570*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x1937578*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1937664*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1937670*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x193767c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1937688*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1937694*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x19376a0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x19376ac*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x19376b8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x19376c4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x19376d0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x19376dc*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x19376e8*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x19376f4*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1937700*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x193770c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1937718*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x1937724*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x1937730*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x1937778*/ Entry();
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

            static /*0x1938f40*/ ExecuteEvents();
            static T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x19377e4*/ void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x19378d8*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x19379cc*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1937ac0*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1937bb4*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1937ca8*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1937d9c*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1937e90*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1937f84*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1938078*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x193816c*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1938260*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1938354*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x19383f8*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x193849c*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1938540*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x1938634*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x19386d8*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x193877c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler();
            static /*0x19387d4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x193882c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x1938884*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x19388dc*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x1938934*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x193898c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x19389e4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x1938a3c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x1938a94*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x1938aec*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x1938b44*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x1938b9c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x1938bf4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x1938c4c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x1938ca4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x1938cfc*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x1938d54*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x1938dac*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
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
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x1939680*/ BaseInput();
            /*0x19395b8*/ string get_compositionString();
            /*0x19395c0*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x19395c8*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x19395d4*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x19395dc*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x19395e4*/ bool get_mousePresent();
            /*0x19395ec*/ bool GetMouseButtonDown(int button);
            /*0x19395f8*/ bool GetMouseButtonUp(int button);
            /*0x1939604*/ bool GetMouseButton(int button);
            /*0x1939610*/ UnityEngine.Vector2 get_mousePosition();
            /*0x1939618*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x1939620*/ bool get_touchSupported();
            /*0x1939628*/ int get_touchCount();
            /*0x1939630*/ UnityEngine.Touch GetTouch(int index);
            /*0x1939668*/ float GetAxisRaw(string axisName);
            /*0x1939674*/ bool GetButtonDown(string buttonName);
        }

        class BaseInputModule : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;
            /*0x20*/ bool m_SendPointerHoverToParent;
            /*0x28*/ UnityEngine.EventSystems.AxisEventData m_AxisEventData;
            /*0x30*/ UnityEngine.EventSystems.EventSystem m_EventSystem;
            /*0x38*/ UnityEngine.EventSystems.BaseEventData m_BaseEventData;
            /*0x40*/ UnityEngine.EventSystems.BaseInput m_InputOverride;
            /*0x48*/ UnityEngine.EventSystems.BaseInput m_DefaultInput;

            static /*0x193993c*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x1939a50*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x1939aa4*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x1939af4*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x193a90c*/ BaseInputModule();
            /*0x1939688*/ bool get_sendPointerHoverToParent();
            /*0x1939690*/ void set_sendPointerHoverToParent(bool value);
            /*0x193969c*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x19398b4*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x19398bc*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x19398c4*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x19398cc*/ void OnEnable();
            /*0x1939924*/ void OnDisable();
            void Process();
            /*0x1939c68*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x193a6b0*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x193a7b0*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x193a834*/ bool IsPointerOverGameObject(int pointerId);
            /*0x193a83c*/ bool ShouldActivateModule();
            /*0x193a87c*/ void DeactivateModule();
            /*0x193a880*/ void ActivateModule();
            /*0x193a884*/ void UpdateModule();
            /*0x193a888*/ bool IsModuleSupported();
            /*0x193a890*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x58*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x193b2bc*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x193bb90*/ PointerInputModule();
            /*0x193a990*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x193aa78*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x193aad4*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x193ae3c*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x193aecc*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x193af48*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x193af5c*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x193b29c*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x193b2ec*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x193b330*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x193b5d8*/ bool IsPointerOverGameObject(int pointerId);
            /*0x193b674*/ void ClearSelection();
            /*0x193b834*/ string ToString();
            /*0x193baa4*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x193bcd0*/ ButtonState();
                /*0x193bcb0*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x193bcb8*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x193bcc0*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0x193bcc8*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x193bc34*/ MouseState();
                /*0x193bcd8*/ bool AnyPressesThisFrame();
                /*0x193bd9c*/ bool AnyReleasesThisFrame();
                /*0x193be68*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x193b264*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x193c000*/ MouseButtonEventData();
                /*0x193bd8c*/ bool PressedThisFrame();
                /*0x193be54*/ bool ReleasedThisFrame();
            }
        }

        class StandaloneInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x60*/ float m_PrevActionTime;
            /*0x64*/ UnityEngine.Vector2 m_LastMoveVector;
            /*0x6c*/ int m_ConsecutiveMoveCount;
            /*0x70*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x78*/ UnityEngine.Vector2 m_MousePosition;
            /*0x80*/ UnityEngine.GameObject m_CurrentFocusedGameObject;
            /*0x88*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x90*/ string m_HorizontalAxis;
            /*0x98*/ string m_VerticalAxis;
            /*0xa0*/ string m_SubmitButton;
            /*0xa8*/ string m_CancelButton;
            /*0xb0*/ float m_InputActionsPerSecond;
            /*0xb4*/ float m_RepeatDelay;
            /*0xb8*/ bool m_ForceModuleActive;

            /*0x193c008*/ StandaloneInputModule();
            /*0x193c0c4*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x193c0cc*/ bool get_allowActivationOnMobileDevice();
            /*0x193c0d4*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x193c0e0*/ bool get_forceModuleActive();
            /*0x193c0e8*/ void set_forceModuleActive(bool value);
            /*0x193c0f4*/ float get_inputActionsPerSecond();
            /*0x193c0fc*/ void set_inputActionsPerSecond(float value);
            /*0x193c104*/ float get_repeatDelay();
            /*0x193c10c*/ void set_repeatDelay(float value);
            /*0x193c114*/ string get_horizontalAxis();
            /*0x193c11c*/ void set_horizontalAxis(string value);
            /*0x193c124*/ string get_verticalAxis();
            /*0x193c12c*/ void set_verticalAxis(string value);
            /*0x193c134*/ string get_submitButton();
            /*0x193c13c*/ void set_submitButton(string value);
            /*0x193c144*/ string get_cancelButton();
            /*0x193c14c*/ void set_cancelButton(string value);
            /*0x193c154*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x193c15c*/ void UpdateModule();
            /*0x193c22c*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x193c598*/ bool ShouldActivateModule();
            /*0x193c7cc*/ void ActivateModule();
            /*0x193c8cc*/ void DeactivateModule();
            /*0x193c8d0*/ void Process();
            /*0x193cabc*/ bool ProcessTouchEvents();
            /*0x193d098*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x193ce8c*/ bool SendSubmitEventToSelectedObject();
            /*0x193d6fc*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x193cc28*/ bool SendMoveEventToSelectedObject();
            /*0x193cc20*/ void ProcessMouseEvent();
            /*0x193dab4*/ bool ForceAutoSelect();
            /*0x193d80c*/ void ProcessMouseEvent(int id);
            /*0x193c974*/ bool SendUpdateEventToSelectedObject();
            /*0x193dabc*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x193de10*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

            enum InputMode
            {
                Mouse = 0,
                Buttons = 1,
            }
        }

        class TouchInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x60*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x68*/ UnityEngine.Vector2 m_MousePosition;
            /*0x70*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x78*/ bool m_ForceModuleActive;

            /*0x193de18*/ TouchInputModule();
            /*0x193de1c*/ bool get_allowActivationOnStandalone();
            /*0x193de24*/ void set_allowActivationOnStandalone(bool value);
            /*0x193de30*/ bool get_forceModuleActive();
            /*0x193de38*/ void set_forceModuleActive(bool value);
            /*0x193de44*/ void UpdateModule();
            /*0x193df94*/ bool IsModuleSupported();
            /*0x193dfcc*/ bool ShouldActivateModule();
            /*0x193e070*/ bool UseFakeInput();
            /*0x193e0a0*/ void Process();
            /*0x193e0c8*/ void FakeTouches();
            /*0x193e1ec*/ void ProcessTouchEvents();
            /*0x193e334*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x193e99c*/ void DeactivateModule();
            /*0x193e9a0*/ string ToString();
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

            static /*0x193ee2c*/ RaycasterManager();
            static /*0x193ebf0*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x193ed04*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x193ed5c*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x193419c*/ BaseRaycaster();
            void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            UnityEngine.Camera get_eventCamera();
            /*0x193eeb8*/ int get_priority();
            /*0x193eec0*/ int get_sortOrderPriority();
            /*0x193eec8*/ int get_renderOrderPriority();
            /*0x1935f60*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x193eed0*/ string ToString();
            /*0x193f194*/ void OnEnable();
            /*0x193f1e8*/ void OnDisable();
            /*0x193f23c*/ void OnCanvasHierarchyChanged();
            /*0x193f248*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x40*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x193f254*/ Physics2DRaycaster();
            /*0x193f2a4*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x20*/ UnityEngine.Camera m_EventCamera;
            /*0x28*/ UnityEngine.LayerMask m_EventMask;
            /*0x2c*/ int m_MaxRayIntersections;
            /*0x30*/ int m_LastMaxRayIntersections;
            /*0x38*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x193f27c*/ PhysicsRaycaster();
            /*0x193fc20*/ UnityEngine.Camera get_eventCamera();
            /*0x193fcc4*/ int get_depth();
            /*0x193fb5c*/ int get_finalEventMask();
            /*0x193fd88*/ UnityEngine.LayerMask get_eventMask();
            /*0x193fd90*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x193fd98*/ int get_maxRayIntersections();
            /*0x193fda0*/ void set_maxRayIntersections(int value);
            /*0x193f864*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x193fda8*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x19401c4*/ RaycastHitComparer();
                /*0x19401bc*/ RaycastHitComparer();
                /*0x194017c*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
            }
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

            /*0x1940228*/ UnityEngine.GameObject get_gameObject();
            /*0x1940230*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x1940238*/ bool get_isValid();
            /*0x19402d0*/ void Clear();
            /*0x1935030*/ string ToString();
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x1933874*/ UIBehaviour();
            /*0x1940374*/ void Awake();
            /*0x1931750*/ void OnEnable();
            /*0x1936b08*/ void Start();
            /*0x1931758*/ void OnDisable();
            /*0x1936bb0*/ void OnDestroy();
            /*0x1940378*/ bool IsActive();
            /*0x1940380*/ void OnRectTransformDimensionsChange();
            /*0x1940384*/ void OnBeforeTransformParentChanged();
            /*0x193f250*/ void OnTransformParentChanged();
            /*0x1940388*/ void OnDidApplyAnimationProperties();
            /*0x194038c*/ void OnCanvasGroupChanged();
            /*0x193f244*/ void OnCanvasHierarchyChanged();
            /*0x1940390*/ bool IsDestroyed();
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
