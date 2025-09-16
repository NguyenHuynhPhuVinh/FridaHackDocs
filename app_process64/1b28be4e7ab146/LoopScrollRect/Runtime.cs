class <Module>
{
}

namespace UnityEngine
{
    namespace UI
    {
        class LoopHorizontalScrollRect : UnityEngine.UI.LoopScrollRect
        {
            /*0x6f9c0f4*/ LoopHorizontalScrollRect();
            /*0x6f9aa84*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6f9ada8*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6f9adb0*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6f9adb4*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6f9adc0*/ void Awake();
            /*0x6f9aee8*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        class LoopHorizontalScrollRectMulti : UnityEngine.UI.LoopScrollRectMulti
        {
            /*0x6f9cb00*/ LoopHorizontalScrollRectMulti();
            /*0x6f9c0fc*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6f9c1c8*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6f9c1d0*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6f9c1d4*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6f9c1e0*/ void Awake();
            /*0x6f9c308*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        interface LoopScrollDataSource
        {
            /*0x381678c*/ void ProvideData(UnityEngine.Transform transform, int idx);
        }

        interface LoopScrollMultiDataSource
        {
            /*0x381678c*/ void ProvideData(UnityEngine.Transform transform, int index);
        }

        interface LoopScrollPrefabSource
        {
            /*0x3814964*/ UnityEngine.GameObject GetObject(int index);
            /*0x3816710*/ void ReturnObject(UnityEngine.Transform trans);
        }

        class LoopScrollRect : UnityEngine.UI.LoopScrollRectBase
        {
            /*0x190*/ UnityEngine.UI.LoopScrollDataSource dataSource;

            /*0x6f9c0f8*/ LoopScrollRect();
            /*0x6f9cb08*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x6f9cbc0*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            /*0x6f9cd94*/ void ReturnToTempPool(bool fromStart, int count);
            /*0x6f9cdb8*/ void ClearTempPool();
        }

        class LoopScrollRectBase : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x20*/ UnityEngine.UI.LoopScrollPrefabSource prefabSource;
            /*0x28*/ int totalCount;
            /*0x30*/ UnityEngine.UI.LoopScrollSizeHelper sizeHelper;
            /*0x38*/ float threshold;
            /*0x3c*/ bool reverseDirection;
            /*0x40*/ int itemTypeStart;
            /*0x44*/ int itemTypeEnd;
            /*0x48*/ UnityEngine.UI.LoopScrollRectBase.LoopScrollRectDirection direction;
            /*0x4c*/ bool m_ContentSpaceInit;
            /*0x50*/ float m_ContentSpacing;
            /*0x54*/ float m_ContentLeftPadding;
            /*0x58*/ float m_ContentRightPadding;
            /*0x5c*/ float m_ContentTopPadding;
            /*0x60*/ float m_ContentBottomPadding;
            /*0x68*/ UnityEngine.UI.GridLayoutGroup m_GridLayout;
            /*0x70*/ bool m_ContentConstraintCountInit;
            /*0x74*/ int m_ContentConstraintCount;
            /*0x78*/ UnityEngine.RectTransform m_Content;
            /*0x80*/ bool m_Horizontal;
            /*0x81*/ bool m_Vertical;
            /*0x84*/ UnityEngine.UI.LoopScrollRectBase.MovementType m_MovementType;
            /*0x88*/ float m_Elasticity;
            /*0x8c*/ bool m_Inertia;
            /*0x90*/ float m_DecelerationRate;
            /*0x94*/ float m_ScrollSensitivity;
            /*0x98*/ UnityEngine.RectTransform m_Viewport;
            /*0xa0*/ UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
            /*0xa8*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
            /*0xb0*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility m_HorizontalScrollbarVisibility;
            /*0xb4*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility m_VerticalScrollbarVisibility;
            /*0xb8*/ float m_HorizontalScrollbarSpacing;
            /*0xbc*/ float m_VerticalScrollbarSpacing;
            /*0xc0*/ UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent m_OnValueChanged;
            /*0xc8*/ UnityEngine.Vector2 m_PointerStartLocalCursor;
            /*0xd0*/ UnityEngine.Vector2 m_ContentStartPosition;
            /*0xd8*/ UnityEngine.RectTransform m_ViewRect;
            /*0xe0*/ UnityEngine.Bounds m_ContentBounds;
            /*0xf8*/ UnityEngine.Bounds m_ViewBounds;
            /*0x110*/ UnityEngine.Vector2 m_Velocity;
            /*0x118*/ bool m_Dragging;
            /*0x119*/ bool m_Scrolling;
            /*0x11c*/ UnityEngine.Vector2 m_PrevPosition;
            /*0x124*/ UnityEngine.Bounds m_PrevContentBounds;
            /*0x13c*/ UnityEngine.Bounds m_PrevViewBounds;
            /*0x154*/ bool m_HasRebuiltLayout;
            /*0x155*/ bool m_HSliderExpand;
            /*0x156*/ bool m_VSliderExpand;
            /*0x158*/ float m_HSliderHeight;
            /*0x15c*/ float m_VSliderWidth;
            /*0x160*/ UnityEngine.RectTransform m_Rect;
            /*0x168*/ UnityEngine.RectTransform m_HorizontalScrollbarRect;
            /*0x170*/ UnityEngine.RectTransform m_VerticalScrollbarRect;
            /*0x178*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x17c*/ int deletedItemTypeStart;
            /*0x180*/ int deletedItemTypeEnd;
            /*0x188*/ UnityEngine.Vector3[] m_Corners;

            static /*0x6fa02b0*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x6fa1d18*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x6fa1e1c*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x6fa1e98*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x6fa21ac*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.LoopScrollRectBase.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x6f9cf74*/ LoopScrollRectBase();
            float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            float GetDimension(UnityEngine.Vector2 vector);
            float GetAbsDimension(UnityEngine.Vector2 vector);
            UnityEngine.Vector2 GetVector(float value);
            /*0x6f9ab50*/ float get_contentSpacing();
            /*0x6f9b76c*/ int get_contentConstraintCount();
            /*0x6f9d094*/ int get_StartLine();
            /*0x6f9b6e0*/ int get_CurrentLines();
            /*0x6f9d114*/ int get_TotalLines();
            /*0x6f9d194*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
            /*0x6f9d19c*/ UnityEngine.RectTransform get_content();
            /*0x6f9d1a4*/ void set_content(UnityEngine.RectTransform value);
            /*0x6f9d1ac*/ bool get_horizontal();
            /*0x6f9d1b4*/ void set_horizontal(bool value);
            /*0x6f9d1c0*/ bool get_vertical();
            /*0x6f9d1c8*/ void set_vertical(bool value);
            /*0x6f9d1d4*/ UnityEngine.UI.LoopScrollRectBase.MovementType get_movementType();
            /*0x6f9d1dc*/ void set_movementType(UnityEngine.UI.LoopScrollRectBase.MovementType value);
            /*0x6f9d1e4*/ float get_elasticity();
            /*0x6f9d1ec*/ void set_elasticity(float value);
            /*0x6f9d1f4*/ bool get_inertia();
            /*0x6f9d1fc*/ void set_inertia(bool value);
            /*0x6f9d208*/ float get_decelerationRate();
            /*0x6f9d210*/ void set_decelerationRate(float value);
            /*0x6f9d218*/ float get_scrollSensitivity();
            /*0x6f9d220*/ void set_scrollSensitivity(float value);
            /*0x6f9d228*/ UnityEngine.RectTransform get_viewport();
            /*0x6f9d230*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x6f9d304*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x6f9d30c*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x6f9d49c*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x6f9d4a4*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x6f9d634*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x6f9d63c*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility value);
            /*0x6f9d644*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x6f9d64c*/ void set_verticalScrollbarVisibility(UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility value);
            /*0x6f9d654*/ float get_horizontalScrollbarSpacing();
            /*0x6f9d65c*/ void set_horizontalScrollbarSpacing(float value);
            /*0x6f9d6ec*/ float get_verticalScrollbarSpacing();
            /*0x6f9d6f4*/ void set_verticalScrollbarSpacing(float value);
            /*0x6f9d6fc*/ UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent get_onValueChanged();
            /*0x6f9d704*/ void set_onValueChanged(UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent value);
            /*0x6f9d70c*/ UnityEngine.RectTransform get_viewRect();
            /*0x6f9d81c*/ UnityEngine.Vector2 get_velocity();
            /*0x6f9d828*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x6f9d834*/ UnityEngine.RectTransform get_rectTransform();
            /*0x6f9d91c*/ void ClearCells();
            /*0x6f9da40*/ int GetFirstItem(ref float offset);
            /*0x6f9dbfc*/ int GetLastItem(ref float offset);
            /*0x6f9dde4*/ void ScrollToCell(int index, float speed);
            /*0x6f9e2d4*/ void ScrollToCellWithinTime(int index, float time);
            /*0x6f9e248*/ System.Collections.IEnumerator ScrollToCellCoroutine(int index, float speed);
            /*0x381678c*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x6f9e690*/ void RefreshCells();
            /*0x6f9ee38*/ void RefillCellsFromEnd(int endItem, bool alignStart);
            /*0x6f9df60*/ void RefillCells(int startItem, float contentOffset);
            /*0x6f9baa4*/ float NewItemAtStart(bool includeSpacing);
            /*0x6f9bea8*/ float DeleteItemAtStart();
            /*0x6f9b8ac*/ float NewItemAtEnd(bool includeSpacing);
            /*0x6f9bc34*/ float DeleteItemAtEnd();
            /*0x3814964*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            void ReturnToTempPool(bool fromStart, int count);
            /*0x38159dc*/ void ClearTempPool();
            /*0x6f9f224*/ void SrollToCell(int index, float speed);
            /*0x6f9f228*/ void SrollToCellWithinTime(int index, float time);
            /*0x6f9f22c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x6f9f630*/ void LayoutComplete();
            /*0x6f9f634*/ void GraphicUpdateComplete();
            /*0x6f9f2b8*/ void UpdateCachedData();
            /*0x6f9f638*/ void OnEnable();
            /*0x6f9f7e4*/ void OnDisable();
            /*0x6f9fa14*/ bool IsActive();
            /*0x6f9fa94*/ void EnsureLayoutHasRebuilt();
            /*0x6f9fb08*/ void StopMovement();
            /*0x6f9fb58*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x6f9ff1c*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6f9ff7c*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6fa00ac*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6fa00cc*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6fa02e8*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x6fa03a0*/ void LateUpdate();
            /*0x6f9f13c*/ void UpdatePrevData();
            /*0x6fa09b4*/ void GetHorizonalOffsetAndSize(ref float totalSize, ref float offset);
            /*0x6fa0c1c*/ void GetVerticalOffsetAndSize(ref float totalSize, ref float offset);
            /*0x6f9ec68*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x6fa0944*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x6fa0f9c*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x6fa0e84*/ float get_horizontalNormalizedPosition();
            /*0x6fa0fe4*/ void set_horizontalNormalizedPosition(float value);
            /*0x6fa0f10*/ float get_verticalNormalizedPosition();
            /*0x6fa0ff8*/ void set_verticalNormalizedPosition(float value);
            /*0x6fa100c*/ void SetHorizontalNormalizedPosition(float value);
            /*0x6fa1020*/ void SetVerticalNormalizedPosition(float value);
            /*0x6fa1034*/ void SetNormalizedPosition(float value, int axis);
            /*0x6fa12d8*/ void OnRectTransformDimensionsChange();
            /*0x6fa12dc*/ bool get_hScrollingNeeded();
            /*0x6fa1364*/ bool get_vScrollingNeeded();
            /*0x6fa13ec*/ void CalculateLayoutInputHorizontal();
            /*0x6fa13f0*/ void CalculateLayoutInputVertical();
            /*0x6fa13f4*/ float get_minWidth();
            /*0x6fa13fc*/ float get_preferredWidth();
            /*0x6fa1404*/ float get_flexibleWidth();
            /*0x6fa140c*/ float get_minHeight();
            /*0x6fa1414*/ float get_preferredHeight();
            /*0x6fa141c*/ float get_flexibleHeight();
            /*0x6fa1424*/ int get_layoutPriority();
            /*0x6fa142c*/ void SetLayoutHorizontal();
            /*0x6fa1a08*/ void SetLayoutVertical();
            /*0x6fa0974*/ void UpdateScrollbarVisibility();
            /*0x6fa1ac4*/ void UpdateScrollbarLayout();
            /*0x6f9e874*/ void UpdateBounds(bool updateItems);
            /*0x6fa1914*/ UnityEngine.Bounds GetBounds();
            /*0x6fa2028*/ UnityEngine.Bounds GetBounds4Item(int index);
            /*0x6f9fcb4*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x6f9d664*/ void SetDirty();
            /*0x6f9d24c*/ void SetDirtyCaching();
            /*0x6fa22f0*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum LoopScrollRectDirection
            {
                Vertical = 0,
                Horizontal = 1,
            }

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
                /*0x6f9d8d4*/ ScrollRectEvent();
            }

            class <ScrollToCellCoroutine>d__133 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.LoopScrollRectBase <>4__this;
                /*0x28*/ int index;
                /*0x2c*/ float speed;
                /*0x30*/ bool <needMoving>5__2;

                /*0x6f9e668*/ <ScrollToCellCoroutine>d__133(int <>1__state);
                /*0x6fa22f8*/ void System.IDisposable.Dispose();
                /*0x6fa22fc*/ bool MoveNext();
                /*0x6fa2688*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x6fa2690*/ void System.Collections.IEnumerator.Reset();
                /*0x6fa26c8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LoopScrollRectMulti : UnityEngine.UI.LoopScrollRectBase
        {
            /*0x190*/ UnityEngine.UI.LoopScrollMultiDataSource dataSource;

            /*0x6f9cb04*/ LoopScrollRectMulti();
            /*0x6fa26d0*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x6fa2788*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            /*0x6fa28c8*/ void ReturnToTempPool(bool fromStart, int count);
            /*0x6fa2a84*/ void ClearTempPool();
        }

        interface LoopScrollSizeHelper
        {
            UnityEngine.Vector2 GetItemsSize(int itemsCount);
        }

        class LoopVerticalScrollRect : UnityEngine.UI.LoopScrollRect
        {
            /*0x6fa3470*/ LoopVerticalScrollRect();
            /*0x6fa2a88*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6fa2b54*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6fa2b5c*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6fa2b64*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6fa2b70*/ void Awake();
            /*0x6fa2c94*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        class LoopVerticalScrollRectMulti : UnityEngine.UI.LoopScrollRectMulti
        {
            /*0x6fa3e5c*/ LoopVerticalScrollRectMulti();
            /*0x6fa3474*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6fa3540*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6fa3548*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6fa3550*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6fa355c*/ void Awake();
            /*0x6fa3680*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }
    }
}
