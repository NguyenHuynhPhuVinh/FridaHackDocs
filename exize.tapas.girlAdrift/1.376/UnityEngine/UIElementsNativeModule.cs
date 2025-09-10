class <Module>
{
}

namespace UnityEngine
{
    namespace Yoga
    {
        enum YogaPositionType
        {
            Relative = 0,
            Absolute = 1,
        }

        class YogaNode : System.Collections.Generic.IEnumerable<UnityEngine.Yoga.YogaNode>, System.Collections.IEnumerable
        {
            /*0x10*/ nint _ygNode;
            /*0x18*/ UnityEngine.Yoga.YogaConfig _config;
            /*0x20*/ System.WeakReference _parent;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Yoga.YogaNode> _children;
            /*0x30*/ UnityEngine.Yoga.MeasureFunction _measureFunction;
            /*0x38*/ UnityEngine.Yoga.BaselineFunction _baselineFunction;
            /*0x40*/ object _data;

            static /*0x166c290*/ UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
            static /*0x166c30c*/ float BaselineInternal(UnityEngine.Yoga.YogaNode node, float width, float height);
            /*0x166a424*/ YogaNode(UnityEngine.Yoga.YogaConfig config);
            /*0x1669a18*/ void set_Left(UnityEngine.Yoga.YogaValue value);
            /*0x1669aa8*/ void set_Top(UnityEngine.Yoga.YogaValue value);
            /*0x1669ab4*/ void set_Right(UnityEngine.Yoga.YogaValue value);
            /*0x1669ac0*/ void set_Bottom(UnityEngine.Yoga.YogaValue value);
            /*0x1669a24*/ void SetStylePosition(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value);
            /*0x1669b84*/ void set_MarginLeft(UnityEngine.Yoga.YogaValue value);
            /*0x1669c58*/ void set_MarginTop(UnityEngine.Yoga.YogaValue value);
            /*0x1669c64*/ void set_MarginRight(UnityEngine.Yoga.YogaValue value);
            /*0x1669c70*/ void set_MarginBottom(UnityEngine.Yoga.YogaValue value);
            /*0x1669b90*/ void SetStyleMargin(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value);
            /*0x1669d68*/ void set_PaddingLeft(UnityEngine.Yoga.YogaValue value);
            /*0x1669df8*/ void set_PaddingTop(UnityEngine.Yoga.YogaValue value);
            /*0x1669e04*/ void set_PaddingRight(UnityEngine.Yoga.YogaValue value);
            /*0x1669e10*/ void set_PaddingBottom(UnityEngine.Yoga.YogaValue value);
            /*0x1669d74*/ void SetStylePadding(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value);
            /*0x1669ec4*/ void set_BorderLeftWidth(float value);
            /*0x1669f68*/ void set_BorderTopWidth(float value);
            /*0x1669fb8*/ void set_BorderRightWidth(float value);
            /*0x166a008*/ void set_BorderBottomWidth(float value);
            /*0x166a058*/ float get_LayoutMarginLeft();
            /*0x166a0dc*/ float get_LayoutMarginTop();
            /*0x166a11c*/ float get_LayoutMarginRight();
            /*0x166a15c*/ float get_LayoutMarginBottom();
            /*0x166a19c*/ float get_LayoutPaddingLeft();
            /*0x166a220*/ float get_LayoutPaddingTop();
            /*0x166a260*/ float get_LayoutPaddingRight();
            /*0x166a2a0*/ float get_LayoutPaddingBottom();
            /*0x166a2e0*/ float get_LayoutBorderLeft();
            /*0x166a364*/ float get_LayoutBorderTop();
            /*0x166a3a4*/ float get_LayoutBorderRight();
            /*0x166a3e4*/ float get_LayoutBorderBottom();
            /*0x166a598*/ void Finalize();
            /*0x166a6bc*/ void set_Config(UnityEngine.Yoga.YogaConfig value);
            /*0x166a7b0*/ bool get_IsDirty();
            /*0x166a828*/ void MarkDirty();
            /*0x166a8a0*/ bool get_HasNewLayout();
            /*0x166a918*/ bool get_IsMeasureDefined();
            /*0x166a928*/ bool get_IsBaselineDefined();
            /*0x166a938*/ void CopyStyle(UnityEngine.Yoga.YogaNode srcNode);
            /*0x166a9c8*/ void set_FlexDirection(UnityEngine.Yoga.YogaFlexDirection value);
            /*0x166aa50*/ void set_JustifyContent(UnityEngine.Yoga.YogaJustify value);
            /*0x166aad8*/ void set_Display(UnityEngine.Yoga.YogaDisplay value);
            /*0x166ab60*/ void set_AlignItems(UnityEngine.Yoga.YogaAlign value);
            /*0x166abe8*/ void set_AlignSelf(UnityEngine.Yoga.YogaAlign value);
            /*0x166ac70*/ void set_AlignContent(UnityEngine.Yoga.YogaAlign value);
            /*0x166acf8*/ void set_PositionType(UnityEngine.Yoga.YogaPositionType value);
            /*0x166ad80*/ void set_Wrap(UnityEngine.Yoga.YogaWrap value);
            /*0x166ae08*/ void set_Flex(float value);
            /*0x166aea0*/ void set_FlexGrow(float value);
            /*0x166af38*/ void set_FlexShrink(float value);
            /*0x166afd0*/ void set_FlexBasis(UnityEngine.Yoga.YogaValue value);
            /*0x166b160*/ void set_Width(UnityEngine.Yoga.YogaValue value);
            /*0x166b2f0*/ void set_Height(UnityEngine.Yoga.YogaValue value);
            /*0x166b480*/ void set_MaxWidth(UnityEngine.Yoga.YogaValue value);
            /*0x166b594*/ void set_MaxHeight(UnityEngine.Yoga.YogaValue value);
            /*0x166b6a8*/ void set_MinWidth(UnityEngine.Yoga.YogaValue value);
            /*0x166b7bc*/ void set_MinHeight(UnityEngine.Yoga.YogaValue value);
            /*0x166b8d0*/ float get_LayoutX();
            /*0x166b948*/ float get_LayoutY();
            /*0x166b9c0*/ float get_LayoutRight();
            /*0x166ba38*/ float get_LayoutBottom();
            /*0x166bab0*/ float get_LayoutWidth();
            /*0x166bb28*/ float get_LayoutHeight();
            /*0x166bba0*/ void set_Overflow(UnityEngine.Yoga.YogaOverflow value);
            /*0x166bc28*/ int get_Count();
            /*0x166bc74*/ void MarkLayoutSeen();
            /*0x166bcf8*/ void Insert(int index, UnityEngine.Yoga.YogaNode node);
            /*0x166be70*/ void RemoveAt(int index);
            /*0x166bf7c*/ void Clear();
            /*0x166bfe0*/ void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction measureFunction);
            /*0x166c174*/ void CalculateLayout(float width, float height);
            /*0x166c380*/ System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator();
            /*0x166c4ac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        enum YogaDirection
        {
            Inherit = 0,
            LTR = 1,
            RTL = 2,
        }

        enum YogaAlign
        {
            Auto = 0,
            FlexStart = 1,
            Center = 2,
            FlexEnd = 3,
            Stretch = 4,
            Baseline = 5,
            SpaceBetween = 6,
            SpaceAround = 7,
        }

        enum YogaFlexDirection
        {
            Column = 0,
            ColumnReverse = 1,
            Row = 2,
            RowReverse = 3,
        }

        class Native
        {
            static /*0x166a55c*/ nint YGNodeNewWithConfig(nint config);
            static /*0x166a630*/ void YGNodeFree(nint ygNode);
            static /*0x166c5d8*/ void YGNodeFreeInternal(nint ygNode);
            static /*0x166c0b8*/ void YGSetManagedObject(nint ygNode, UnityEngine.Yoga.YogaNode node);
            static /*0x166a76c*/ void YGNodeSetConfig(nint ygNode, nint config);
            static /*0x166c614*/ nint YGConfigGetDefault();
            static /*0x166c63c*/ nint YGConfigNew();
            static /*0x166c664*/ void YGConfigFree(nint config);
            static /*0x166c6f0*/ void YGConfigFreeInternal(nint config);
            static /*0x166c72c*/ void YGConfigSetUseWebDefaults(nint config, bool useWebDefaults);
            static /*0x166c770*/ bool YGConfigGetUseWebDefaults(nint config);
            static /*0x166c7ac*/ void YGConfigSetPointScaleFactor(nint config, float pixelsInPoint);
            static /*0x166be1c*/ void YGNodeInsertChild(nint node, nint child, uint index);
            static /*0x166bf38*/ void YGNodeRemoveChild(nint node, nint child);
            static /*0x166c234*/ void YGNodeCalculateLayout(nint node, float availableWidth, float availableHeight, UnityEngine.Yoga.YogaDirection parentDirection);
            static /*0x166a864*/ void YGNodeMarkDirty(nint node);
            static /*0x166a7ec*/ bool YGNodeIsDirty(nint node);
            static /*0x166a984*/ void YGNodeCopyStyle(nint dstNode, nint srcNode);
            static /*0x166c138*/ void YGNodeSetMeasureFunc(nint node);
            static /*0x166c0fc*/ void YGNodeRemoveMeasureFunc(nint node);
            static /*0x166c7f8*/ void YGNodeMeasureInvoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode, nint returnValueAddress);
            static /*0x166c85c*/ void YGNodeBaselineInvoke(UnityEngine.Yoga.YogaNode node, float width, float height, nint returnValueAddress);
            static /*0x166bcb4*/ void YGNodeSetHasNewLayout(nint node, bool hasNewLayout);
            static /*0x166a8dc*/ bool YGNodeGetHasNewLayout(nint node);
            static /*0x166c1f8*/ UnityEngine.Yoga.YogaDirection YGNodeStyleGetDirection(nint node);
            static /*0x166aa0c*/ void YGNodeStyleSetFlexDirection(nint node, UnityEngine.Yoga.YogaFlexDirection flexDirection);
            static /*0x166aa94*/ void YGNodeStyleSetJustifyContent(nint node, UnityEngine.Yoga.YogaJustify justifyContent);
            static /*0x166acb4*/ void YGNodeStyleSetAlignContent(nint node, UnityEngine.Yoga.YogaAlign alignContent);
            static /*0x166aba4*/ void YGNodeStyleSetAlignItems(nint node, UnityEngine.Yoga.YogaAlign alignItems);
            static /*0x166ac2c*/ void YGNodeStyleSetAlignSelf(nint node, UnityEngine.Yoga.YogaAlign alignSelf);
            static /*0x166ad3c*/ void YGNodeStyleSetPositionType(nint node, UnityEngine.Yoga.YogaPositionType positionType);
            static /*0x166adc4*/ void YGNodeStyleSetFlexWrap(nint node, UnityEngine.Yoga.YogaWrap flexWrap);
            static /*0x166bbe4*/ void YGNodeStyleSetOverflow(nint node, UnityEngine.Yoga.YogaOverflow flexWrap);
            static /*0x166ab1c*/ void YGNodeStyleSetDisplay(nint node, UnityEngine.Yoga.YogaDisplay display);
            static /*0x166ae54*/ void YGNodeStyleSetFlex(nint node, float flex);
            static /*0x166aeec*/ void YGNodeStyleSetFlexGrow(nint node, float flexGrow);
            static /*0x166af84*/ void YGNodeStyleSetFlexShrink(nint node, float flexShrink);
            static /*0x166b114*/ void YGNodeStyleSetFlexBasis(nint node, float flexBasis);
            static /*0x166b08c*/ void YGNodeStyleSetFlexBasisPercent(nint node, float flexBasis);
            static /*0x166b0d8*/ void YGNodeStyleSetFlexBasisAuto(nint node);
            static /*0x166b2a4*/ void YGNodeStyleSetWidth(nint node, float width);
            static /*0x166b21c*/ void YGNodeStyleSetWidthPercent(nint node, float width);
            static /*0x166b268*/ void YGNodeStyleSetWidthAuto(nint node);
            static /*0x166b434*/ void YGNodeStyleSetHeight(nint node, float height);
            static /*0x166b3ac*/ void YGNodeStyleSetHeightPercent(nint node, float height);
            static /*0x166b3f8*/ void YGNodeStyleSetHeightAuto(nint node);
            static /*0x166b770*/ void YGNodeStyleSetMinWidth(nint node, float minWidth);
            static /*0x166b724*/ void YGNodeStyleSetMinWidthPercent(nint node, float minWidth);
            static /*0x166b884*/ void YGNodeStyleSetMinHeight(nint node, float minHeight);
            static /*0x166b838*/ void YGNodeStyleSetMinHeightPercent(nint node, float minHeight);
            static /*0x166b548*/ void YGNodeStyleSetMaxWidth(nint node, float maxWidth);
            static /*0x166b4fc*/ void YGNodeStyleSetMaxWidthPercent(nint node, float maxWidth);
            static /*0x166b65c*/ void YGNodeStyleSetMaxHeight(nint node, float maxHeight);
            static /*0x166b610*/ void YGNodeStyleSetMaxHeightPercent(nint node, float maxHeight);
            static /*0x1669b30*/ void YGNodeStyleSetPosition(nint node, UnityEngine.Yoga.YogaEdge edge, float position);
            static /*0x1669adc*/ void YGNodeStyleSetPositionPercent(nint node, UnityEngine.Yoga.YogaEdge edge, float position);
            static /*0x1669d14*/ void YGNodeStyleSetMargin(nint node, UnityEngine.Yoga.YogaEdge edge, float margin);
            static /*0x1669c7c*/ void YGNodeStyleSetMarginPercent(nint node, UnityEngine.Yoga.YogaEdge edge, float margin);
            static /*0x1669cd0*/ void YGNodeStyleSetMarginAuto(nint node, UnityEngine.Yoga.YogaEdge edge);
            static /*0x1669e70*/ void YGNodeStyleSetPadding(nint node, UnityEngine.Yoga.YogaEdge edge, float padding);
            static /*0x1669e1c*/ void YGNodeStyleSetPaddingPercent(nint node, UnityEngine.Yoga.YogaEdge edge, float padding);
            static /*0x1669f14*/ void YGNodeStyleSetBorder(nint node, UnityEngine.Yoga.YogaEdge edge, float border);
            static /*0x166b90c*/ float YGNodeLayoutGetLeft(nint node);
            static /*0x166b984*/ float YGNodeLayoutGetTop(nint node);
            static /*0x166b9fc*/ float YGNodeLayoutGetRight(nint node);
            static /*0x166ba74*/ float YGNodeLayoutGetBottom(nint node);
            static /*0x166baec*/ float YGNodeLayoutGetWidth(nint node);
            static /*0x166bb64*/ float YGNodeLayoutGetHeight(nint node);
            static /*0x166a098*/ float YGNodeLayoutGetMargin(nint node, UnityEngine.Yoga.YogaEdge edge);
            static /*0x166a1dc*/ float YGNodeLayoutGetPadding(nint node, UnityEngine.Yoga.YogaEdge edge);
            static /*0x166a320*/ float YGNodeLayoutGetBorder(nint node, UnityEngine.Yoga.YogaEdge edge);
        }

        class YogaConstants
        {
            static /*0x166c8a8*/ bool IsUndefined(float value);
        }

        enum YogaWrap
        {
            NoWrap = 0,
            Wrap = 1,
            WrapReverse = 2,
        }

        class MeasureOutput
        {
            static /*0x166c90c*/ UnityEngine.Yoga.YogaSize Make(float width, float height);
        }

        class YogaConfig
        {
            static /*0x0*/ UnityEngine.Yoga.YogaConfig Default;
            /*0x10*/ nint _ygConfig;
            /*0x18*/ UnityEngine.Yoga.Logger _logger;

            static /*0x166cbec*/ YogaConfig();
            /*0x166c910*/ YogaConfig(nint ygConfig);
            /*0x166c9d4*/ YogaConfig();
            /*0x166ca18*/ void Finalize();
            /*0x166a554*/ nint get_Handle();
            /*0x166cb20*/ bool get_UseWebDefaults();
            /*0x166cb5c*/ void set_UseWebDefaults(bool value);
            /*0x166cba0*/ void set_PointScaleFactor(float value);
        }

        enum YogaUnit
        {
            Undefined = 0,
            Point = 1,
            Percent = 2,
            Auto = 3,
        }

        struct YogaValue
        {
            /*0x10*/ float value;
            /*0x14*/ UnityEngine.Yoga.YogaUnit unit;

            static /*0x166cc7c*/ UnityEngine.Yoga.YogaValue Point(float value);
            static /*0x166cdb4*/ UnityEngine.Yoga.YogaValue Auto();
            static /*0x166cdc0*/ UnityEngine.Yoga.YogaValue Percent(float value);
            static /*0x166cde8*/ UnityEngine.Yoga.YogaValue op_Implicit(float pointValue);
            /*0x1669acc*/ UnityEngine.Yoga.YogaUnit get_Unit();
            /*0x1669ad4*/ float get_Value();
            /*0x166cca0*/ bool Equals(UnityEngine.Yoga.YogaValue other);
            /*0x166cd00*/ bool Equals(object obj);
            /*0x166cd78*/ int GetHashCode();
        }

        enum YogaEdge
        {
            Left = 0,
            Top = 1,
            Right = 2,
            Bottom = 3,
            Start = 4,
            End = 5,
            Horizontal = 6,
            Vertical = 7,
            All = 8,
        }

        struct YogaSize
        {
            /*0x10*/ float width;
            /*0x14*/ float height;
        }

        class MeasureFunction : System.MulticastDelegate
        {
            /*0x166ce14*/ MeasureFunction(object object, nint method);
            /*0x166cf44*/ UnityEngine.Yoga.YogaSize Invoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
        }

        enum YogaLogLevel
        {
            Error = 0,
            Warn = 1,
            Info = 2,
            Debug = 3,
            Verbose = 4,
            Fatal = 5,
        }

        enum YogaDisplay
        {
            Flex = 0,
            None = 1,
        }

        enum YogaMeasureMode
        {
            Undefined = 0,
            Exactly = 1,
            AtMost = 2,
        }

        enum YogaJustify
        {
            FlexStart = 0,
            Center = 1,
            FlexEnd = 2,
            SpaceBetween = 3,
            SpaceAround = 4,
        }

        class BaselineFunction : System.MulticastDelegate
        {
            /*0x166cf58*/ BaselineFunction(object object, nint method);
            /*0x166d088*/ float Invoke(UnityEngine.Yoga.YogaNode node, float width, float height);
        }

        enum YogaOverflow
        {
            Visible = 0,
            Hidden = 1,
            Scroll = 2,
        }

        class Logger : System.MulticastDelegate
        {
            /*0x166d09c*/ Logger(object object, nint method);
            /*0x166d1cc*/ void Invoke(UnityEngine.Yoga.YogaConfig config, UnityEngine.Yoga.YogaNode node, UnityEngine.Yoga.YogaLogLevel level, string message);
        }
    }

    namespace UIElements
    {
        class UIElementsRuntimeUtilityNative
        {
            static /*0x0*/ System.Action RepaintOverlayPanelsCallback;
            static /*0x8*/ System.Action UpdateRuntimePanelsCallback;

            static /*0x166d1e0*/ void RepaintOverlayPanels();
            static /*0x166d244*/ void UpdateRuntimePanels();
            static /*0x166d2a8*/ void RegisterPlayerloopCallback();
            static /*0x166d2d0*/ void UnregisterPlayerloopCallback();
            static /*0x166d2f8*/ void VisualElementCreation();
        }

        struct TextNativeSettings
        {
            /*0x10*/ string text;
            /*0x18*/ UnityEngine.Font font;
            /*0x20*/ int size;
            /*0x24*/ float scaling;
            /*0x28*/ UnityEngine.FontStyle style;
            /*0x2c*/ UnityEngine.Color color;
            /*0x3c*/ UnityEngine.TextAnchor anchor;
            /*0x40*/ bool wordWrap;
            /*0x44*/ float wordWrapWidth;
            /*0x48*/ bool richText;
        }

        struct TextVertex
        {
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Color32 color;
            /*0x20*/ UnityEngine.Vector2 uv0;
        }

        class TextNative
        {
            static /*0x166d320*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, int cursorIndex);
            static /*0x166d4cc*/ float ComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166d610*/ float ComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166d754*/ Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166d9a0*/ UnityEngine.Vector2 GetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect screenRect);
            static /*0x166db2c*/ float ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, float pixelsPerPoint);
            static /*0x166d5d4*/ float DoComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166d718*/ float DoComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166d464*/ UnityEngine.Vector2 DoGetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, int cursorPosition);
            static /*0x166d944*/ void GetVertices(UnityEngine.UIElements.TextNativeSettings settings, nint buffer, int vertexSize, ref int vertexCount);
            static /*0x166dad0*/ UnityEngine.Vector2 DoGetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect);
            static /*0x166dc28*/ float DoComputeTextWidth_Injected(ref UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166dc64*/ float DoComputeTextHeight_Injected(ref UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x166dca0*/ void DoGetCursorPosition_Injected(ref UnityEngine.UIElements.TextNativeSettings settings, ref UnityEngine.Rect rect, int cursorPosition, ref UnityEngine.Vector2 ret);
            static /*0x166dcfc*/ void GetVertices_Injected(ref UnityEngine.UIElements.TextNativeSettings settings, nint buffer, int vertexSize, ref int vertexCount);
            static /*0x166dd58*/ void DoGetOffset_Injected(ref UnityEngine.UIElements.TextNativeSettings settings, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 ret);
        }

        namespace UIR
        {
            struct GfxUpdateBufferRange
            {
                /*0x10*/ uint offsetFromWriteStart;
                /*0x14*/ uint size;
                /*0x18*/ nuint source;
            }

            struct DrawBufferRange
            {
                /*0x10*/ int firstIndex;
                /*0x14*/ int indexCount;
                /*0x18*/ int minIndexVal;
                /*0x1c*/ int vertsReferenced;
            }

            class Utility
            {
                static /*0x0*/ System.Action<bool> GraphicsResourcesRecreate;
                static /*0x8*/ System.Action EngineUpdate;
                static /*0x10*/ System.Action FlushPendingResources;
                static /*0x18*/ System.Action<UnityEngine.Camera> RegisterIntermediateRenderers;
                static /*0x20*/ System.Action<nint> RenderNodeAdd;
                static /*0x28*/ System.Action<nint> RenderNodeExecute;
                static /*0x30*/ System.Action<nint> RenderNodeCleanup;
                static /*0x38*/ Unity.Profiling.ProfilerMarker s_MarkerRaiseEngineUpdate;

                static /*0x166f32c*/ Utility();
                static void SetVectorArray<T>(UnityEngine.MaterialPropertyBlock props, int name, Unity.Collections.NativeSlice<T> vector4s);
                static /*0x166ddac*/ void add_GraphicsResourcesRecreate(System.Action<bool> value);
                static /*0x166de9c*/ void remove_GraphicsResourcesRecreate(System.Action<bool> value);
                static /*0x166df8c*/ void add_EngineUpdate(System.Action value);
                static /*0x166e068*/ void remove_EngineUpdate(System.Action value);
                static /*0x166e144*/ void add_FlushPendingResources(System.Action value);
                static /*0x166e220*/ void remove_FlushPendingResources(System.Action value);
                static /*0x166e2fc*/ void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value);
                static /*0x166e3f0*/ void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value);
                static /*0x166e4e4*/ void add_RenderNodeExecute(System.Action<nint> value);
                static /*0x166e5d8*/ void remove_RenderNodeExecute(System.Action<nint> value);
                static /*0x166e6cc*/ void RaiseGraphicsResourcesRecreate(bool recreate);
                static /*0x166e748*/ void RaiseEngineUpdate();
                static /*0x166e7dc*/ void RaiseFlushPendingResources();
                static /*0x166e850*/ void RaiseRegisterIntermediateRenderers(UnityEngine.Camera camera);
                static /*0x166e8cc*/ void RaiseRenderNodeAdd(nint userData);
                static /*0x166e948*/ void RaiseRenderNodeExecute(nint userData);
                static /*0x166e9c4*/ void RaiseRenderNodeCleanup(nint userData);
                static /*0x166ea40*/ nint AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer);
                static /*0x166ea94*/ void FreeBuffer(nint buffer);
                static /*0x166ead0*/ void UpdateBufferRanges(nint buffer, nint ranges, int rangeCount, int writeRangeStart, int writeRangeEnd);
                static /*0x166eb3c*/ void SetVectorArray(UnityEngine.MaterialPropertyBlock props, int name, nint vector4s, int count);
                static /*0x166eb98*/ nint GetVertexDeclaration(UnityEngine.Rendering.VertexAttributeDescriptor[] vertexAttributes);
                static /*0x166ebd4*/ void RegisterIntermediateRenderer(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4 transform, UnityEngine.Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, nint userData, int userDataSize);
                static /*0x166ed80*/ void DrawRanges(nint ib, nint* vertexStreams, int streamCount, nint ranges, int rangeCount, nint vertexDecl);
                static /*0x166edf4*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock props);
                static /*0x166ee30*/ void SetScissorRect(UnityEngine.RectInt scissorRect);
                static /*0x166eeec*/ void DisableScissor();
                static /*0x166ef14*/ nint CreateStencilState(UnityEngine.Rendering.StencilState stencilState);
                static /*0x166efd4*/ void SetStencilState(nint stencilState, int stencilRef);
                static /*0x166f018*/ bool HasMappedBufferRange();
                static /*0x166f040*/ uint InsertCPUFence();
                static /*0x166f068*/ bool CPUFencePassed(uint fence);
                static /*0x166f0a4*/ void WaitForCPUFencePassed(uint fence);
                static /*0x166f0e0*/ void SyncRenderThread();
                static /*0x166f108*/ UnityEngine.RectInt GetActiveViewport();
                static /*0x166f1c8*/ void ProfileDrawChainBegin();
                static /*0x166f1f0*/ void ProfileDrawChainEnd();
                static /*0x166f218*/ void NotifyOfUIREvents(bool subscribe);
                static /*0x166f254*/ UnityEngine.Matrix4x4 GetUnityProjectionMatrix();
                static /*0x166ecc0*/ void RegisterIntermediateRenderer_Injected(UnityEngine.Camera camera, UnityEngine.Material material, ref UnityEngine.Matrix4x4 transform, ref UnityEngine.Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, nint userData, int userDataSize);
                static /*0x166eeb0*/ void SetScissorRect_Injected(ref UnityEngine.RectInt scissorRect);
                static /*0x166ef98*/ nint CreateStencilState_Injected(ref UnityEngine.Rendering.StencilState stencilState);
                static /*0x166f18c*/ void GetActiveViewport_Injected(ref UnityEngine.RectInt ret);
                static /*0x166f2f0*/ void GetUnityProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 ret);

                enum GPUBufferType
                {
                    Vertex = 0,
                    Index = 1,
                }

                class GPUBuffer<T> : System.IDisposable
                {
                    /*0x0*/ nint buffer;
                    /*0x0*/ int elemCount;
                    /*0x0*/ int elemStride;

                    GPUBuffer(int elementCount, UnityEngine.UIElements.UIR.Utility.GPUBufferType type);
                    void Dispose();
                    void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax);
                    int get_ElementStride();
                    nint get_BufferPointer();
                }
            }
        }
    }
}
