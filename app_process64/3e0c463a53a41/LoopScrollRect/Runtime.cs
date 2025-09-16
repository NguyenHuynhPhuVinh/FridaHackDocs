class <Module>
{
}

namespace UnityEngine
{
    namespace UI
    {
        class LoopHorizontalScrollRect : UnityEngine.UI.LoopScrollRect
        {
            /*0x6f84cc4*/ LoopHorizontalScrollRect();
            /*0x6f83654*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6f83978*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6f83980*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6f83984*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6f83990*/ void Awake();
            /*0x6f83ab8*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        class LoopHorizontalScrollRectMulti : UnityEngine.UI.LoopScrollRectMulti
        {
            /*0x6f856d0*/ LoopHorizontalScrollRectMulti();
            /*0x6f84ccc*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6f84d98*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6f84da0*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6f84da4*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6f84db0*/ void Awake();
            /*0x6f84ed8*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        interface LoopScrollDataSource
        {
            /*0x380d8b8*/ void ProvideData(UnityEngine.Transform transform, int idx);
        }

        interface LoopScrollMultiDataSource
        {
            /*0x380d8b8*/ void ProvideData(UnityEngine.Transform transform, int index);
        }

        interface LoopScrollPrefabSource
        {
            /*0x380ba90*/ UnityEngine.GameObject GetObject(int index);
            /*0x380d83c*/ void ReturnObject(UnityEngine.Transform trans);
        }

        class LoopScrollRect : UnityEngine.UI.LoopScrollRectBase
        {
            /*0x190*/ UnityEngine.UI.LoopScrollDataSource dataSource;

            /*0x6f84cc8*/ LoopScrollRect();
            /*0x6f856d8*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x6f85790*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            /*0x6f85964*/ void ReturnToTempPool(bool fromStart, int count);
            /*0x6f85988*/ void ClearTempPool();
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

            static /*0x6f88e80*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x6f8a8e8*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x6f8a9ec*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x6f8aa68*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x6f8ad7c*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.LoopScrollRectBase.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x6f85b44*/ LoopScrollRectBase();
            float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            float GetDimension(UnityEngine.Vector2 vector);
            float GetAbsDimension(UnityEngine.Vector2 vector);
            UnityEngine.Vector2 GetVector(float value);
            /*0x6f83720*/ float get_contentSpacing();
            /*0x6f8433c*/ int get_contentConstraintCount();
            /*0x6f85c64*/ int get_StartLine();
            /*0x6f842b0*/ int get_CurrentLines();
            /*0x6f85ce4*/ int get_TotalLines();
            /*0x6f85d64*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
            /*0x6f85d6c*/ UnityEngine.RectTransform get_content();
            /*0x6f85d74*/ void set_content(UnityEngine.RectTransform value);
            /*0x6f85d7c*/ bool get_horizontal();
            /*0x6f85d84*/ void set_horizontal(bool value);
            /*0x6f85d90*/ bool get_vertical();
            /*0x6f85d98*/ void set_vertical(bool value);
            /*0x6f85da4*/ UnityEngine.UI.LoopScrollRectBase.MovementType get_movementType();
            /*0x6f85dac*/ void set_movementType(UnityEngine.UI.LoopScrollRectBase.MovementType value);
            /*0x6f85db4*/ float get_elasticity();
            /*0x6f85dbc*/ void set_elasticity(float value);
            /*0x6f85dc4*/ bool get_inertia();
            /*0x6f85dcc*/ void set_inertia(bool value);
            /*0x6f85dd8*/ float get_decelerationRate();
            /*0x6f85de0*/ void set_decelerationRate(float value);
            /*0x6f85de8*/ float get_scrollSensitivity();
            /*0x6f85df0*/ void set_scrollSensitivity(float value);
            /*0x6f85df8*/ UnityEngine.RectTransform get_viewport();
            /*0x6f85e00*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x6f85ed4*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x6f85edc*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x6f8606c*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x6f86074*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x6f86204*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x6f8620c*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility value);
            /*0x6f86214*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x6f8621c*/ void set_verticalScrollbarVisibility(UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility value);
            /*0x6f86224*/ float get_horizontalScrollbarSpacing();
            /*0x6f8622c*/ void set_horizontalScrollbarSpacing(float value);
            /*0x6f862bc*/ float get_verticalScrollbarSpacing();
            /*0x6f862c4*/ void set_verticalScrollbarSpacing(float value);
            /*0x6f862cc*/ UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent get_onValueChanged();
            /*0x6f862d4*/ void set_onValueChanged(UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent value);
            /*0x6f862dc*/ UnityEngine.RectTransform get_viewRect();
            /*0x6f863ec*/ UnityEngine.Vector2 get_velocity();
            /*0x6f863f8*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x6f86404*/ UnityEngine.RectTransform get_rectTransform();
            /*0x6f864ec*/ void ClearCells();
            /*0x6f86610*/ int GetFirstItem(ref float offset);
            /*0x6f867cc*/ int GetLastItem(ref float offset);
            /*0x6f869b4*/ void ScrollToCell(int index, float speed);
            /*0x6f86ea4*/ void ScrollToCellWithinTime(int index, float time);
            /*0x6f86e18*/ System.Collections.IEnumerator ScrollToCellCoroutine(int index, float speed);
            /*0x380d8b8*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x6f87260*/ void RefreshCells();
            /*0x6f87a08*/ void RefillCellsFromEnd(int endItem, bool alignStart);
            /*0x6f86b30*/ void RefillCells(int startItem, float contentOffset);
            /*0x6f84674*/ float NewItemAtStart(bool includeSpacing);
            /*0x6f84a78*/ float DeleteItemAtStart();
            /*0x6f8447c*/ float NewItemAtEnd(bool includeSpacing);
            /*0x6f84804*/ float DeleteItemAtEnd();
            /*0x380ba90*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            void ReturnToTempPool(bool fromStart, int count);
            /*0x380cb08*/ void ClearTempPool();
            /*0x6f87df4*/ void SrollToCell(int index, float speed);
            /*0x6f87df8*/ void SrollToCellWithinTime(int index, float time);
            /*0x6f87dfc*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x6f88200*/ void LayoutComplete();
            /*0x6f88204*/ void GraphicUpdateComplete();
            /*0x6f87e88*/ void UpdateCachedData();
            /*0x6f88208*/ void OnEnable();
            /*0x6f883b4*/ void OnDisable();
            /*0x6f885e4*/ bool IsActive();
            /*0x6f88664*/ void EnsureLayoutHasRebuilt();
            /*0x6f886d8*/ void StopMovement();
            /*0x6f88728*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x6f88aec*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6f88b4c*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6f88c7c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6f88c9c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x6f88eb8*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x6f88f70*/ void LateUpdate();
            /*0x6f87d0c*/ void UpdatePrevData();
            /*0x6f89584*/ void GetHorizonalOffsetAndSize(ref float totalSize, ref float offset);
            /*0x6f897ec*/ void GetVerticalOffsetAndSize(ref float totalSize, ref float offset);
            /*0x6f87838*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x6f89514*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x6f89b6c*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x6f89a54*/ float get_horizontalNormalizedPosition();
            /*0x6f89bb4*/ void set_horizontalNormalizedPosition(float value);
            /*0x6f89ae0*/ float get_verticalNormalizedPosition();
            /*0x6f89bc8*/ void set_verticalNormalizedPosition(float value);
            /*0x6f89bdc*/ void SetHorizontalNormalizedPosition(float value);
            /*0x6f89bf0*/ void SetVerticalNormalizedPosition(float value);
            /*0x6f89c04*/ void SetNormalizedPosition(float value, int axis);
            /*0x6f89ea8*/ void OnRectTransformDimensionsChange();
            /*0x6f89eac*/ bool get_hScrollingNeeded();
            /*0x6f89f34*/ bool get_vScrollingNeeded();
            /*0x6f89fbc*/ void CalculateLayoutInputHorizontal();
            /*0x6f89fc0*/ void CalculateLayoutInputVertical();
            /*0x6f89fc4*/ float get_minWidth();
            /*0x6f89fcc*/ float get_preferredWidth();
            /*0x6f89fd4*/ float get_flexibleWidth();
            /*0x6f89fdc*/ float get_minHeight();
            /*0x6f89fe4*/ float get_preferredHeight();
            /*0x6f89fec*/ float get_flexibleHeight();
            /*0x6f89ff4*/ int get_layoutPriority();
            /*0x6f89ffc*/ void SetLayoutHorizontal();
            /*0x6f8a5d8*/ void SetLayoutVertical();
            /*0x6f89544*/ void UpdateScrollbarVisibility();
            /*0x6f8a694*/ void UpdateScrollbarLayout();
            /*0x6f87444*/ void UpdateBounds(bool updateItems);
            /*0x6f8a4e4*/ UnityEngine.Bounds GetBounds();
            /*0x6f8abf8*/ UnityEngine.Bounds GetBounds4Item(int index);
            /*0x6f88884*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x6f86234*/ void SetDirty();
            /*0x6f85e1c*/ void SetDirtyCaching();
            /*0x6f8aec0*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
                /*0x6f864a4*/ ScrollRectEvent();
            }

            class <ScrollToCellCoroutine>d__133 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.LoopScrollRectBase <>4__this;
                /*0x28*/ int index;
                /*0x2c*/ float speed;
                /*0x30*/ bool <needMoving>5__2;

                /*0x6f87238*/ <ScrollToCellCoroutine>d__133(int <>1__state);
                /*0x6f8aec8*/ void System.IDisposable.Dispose();
                /*0x6f8aecc*/ bool MoveNext();
                /*0x6f8b258*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x6f8b260*/ void System.Collections.IEnumerator.Reset();
                /*0x6f8b298*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LoopScrollRectMulti : UnityEngine.UI.LoopScrollRectBase
        {
            /*0x190*/ UnityEngine.UI.LoopScrollMultiDataSource dataSource;

            /*0x6f856d4*/ LoopScrollRectMulti();
            /*0x6f8b2a0*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x6f8b358*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            /*0x6f8b498*/ void ReturnToTempPool(bool fromStart, int count);
            /*0x6f8b654*/ void ClearTempPool();
        }

        interface LoopScrollSizeHelper
        {
            UnityEngine.Vector2 GetItemsSize(int itemsCount);
        }

        class LoopVerticalScrollRect : UnityEngine.UI.LoopScrollRect
        {
            /*0x6f8c040*/ LoopVerticalScrollRect();
            /*0x6f8b658*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6f8b724*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6f8b72c*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6f8b734*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6f8b740*/ void Awake();
            /*0x6f8b864*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        class LoopVerticalScrollRectMulti : UnityEngine.UI.LoopScrollRectMulti
        {
            /*0x6f8ca2c*/ LoopVerticalScrollRectMulti();
            /*0x6f8c044*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x6f8c110*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x6f8c118*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x6f8c120*/ UnityEngine.Vector2 GetVector(float value);
            /*0x6f8c12c*/ void Awake();
            /*0x6f8c250*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }
    }
}
