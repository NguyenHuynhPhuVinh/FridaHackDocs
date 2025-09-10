class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x13ea880*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x13ea888*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    namespace UIElements
    {
        class ProjectionUtils
        {
            static /*0x13ea890*/ UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far);
        }

        class VisualElement : UnityEngine.UIElements.Focusable, UnityEngine.UIElements.IVisualElementScheduler, UnityEngine.UIElements.IStylePropertyAnimations, UnityEngine.UIElements.ITransform, UnityEngine.UIElements.IExperimentalFeatures, UnityEngine.UIElements.Experimental.ITransitionAnimations, UnityEngine.UIElements.IResolvedStyle
        {
            static string k_RootVisualContainerName = "rootVisualContainer";
            static /*0x0*/ UnityEngine.PropertyName tooltipPropertyKey;
            static /*0x4*/ uint s_NextId;
            static /*0x8*/ System.Collections.Generic.List<string> s_EmptyClassList;
            static /*0x10*/ UnityEngine.PropertyName userDataPropertyKey;
            static /*0x18*/ string disabledUssClassName;
            static /*0x20*/ UnityEngine.Rect s_InfiniteRect;
            static /*0x30*/ UnityEngine.Material s_runtimeMaterial;
            static /*0x38*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.UIElements.VisualElement.TypeData> s_TypeData;
            static /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> s_EmptyList;
            static /*0x48*/ UnityEngine.UIElements.VisualElement.CustomStyleAccess s_CustomStyleAccess;
            static /*0x50*/ System.Text.RegularExpressions.Regex s_InternalStyleSheetPath;
            /*0x24*/ int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField;
            /*0x28*/ int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField;
            /*0x30*/ string m_Name;
            /*0x38*/ System.Collections.Generic.List<string> m_ClassList;
            /*0x40*/ System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.PropertyName, object>> m_PropertyBag;
            /*0x48*/ UnityEngine.UIElements.VisualElementFlags m_Flags;
            /*0x50*/ string m_ViewDataKey;
            /*0x58*/ UnityEngine.UIElements.RenderHints m_RenderHints;
            /*0x5c*/ UnityEngine.Rect lastLayout;
            /*0x6c*/ UnityEngine.Rect lastPseudoPadding;
            /*0x80*/ UnityEngine.UIElements.UIR.RenderChainVEData renderChainData;
            /*0x1d8*/ UnityEngine.Rect m_Layout;
            /*0x1e8*/ UnityEngine.Rect m_BoundingBox;
            /*0x1f8*/ UnityEngine.Rect m_WorldBoundingBox;
            /*0x208*/ UnityEngine.Matrix4x4 m_WorldTransformCache;
            /*0x248*/ UnityEngine.Matrix4x4 m_WorldTransformInverseCache;
            /*0x288*/ UnityEngine.Rect m_WorldClip;
            /*0x298*/ UnityEngine.Rect m_WorldClipMinusGroup;
            /*0x2a8*/ bool m_WorldClipIsInfinite;
            /*0x2ac*/ UnityEngine.UIElements.PseudoStates triggerPseudoMask;
            /*0x2b0*/ UnityEngine.UIElements.PseudoStates dependencyPseudoMask;
            /*0x2b4*/ UnityEngine.UIElements.PseudoStates m_PseudoStates;
            /*0x2b8*/ int <containedPointerIds>k__BackingField;
            /*0x2bc*/ UnityEngine.UIElements.PickingMode <pickingMode>k__BackingField;
            /*0x2c0*/ UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField;
            /*0x2c8*/ UnityEngine.UIElements.ComputedStyle m_Style;
            /*0x320*/ UnityEngine.UIElements.StyleVariableContext variableContext;
            /*0x328*/ int inheritedStylesHash;
            /*0x32c*/ uint controlid;
            /*0x330*/ int imguiContainerDescendantCount;
            /*0x334*/ bool <enabledSelf>k__BackingField;
            /*0x338*/ System.Action<UnityEngine.UIElements.MeshGenerationContext> <generateVisualContent>k__BackingField;
            /*0x340*/ Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker;
            /*0x348*/ UnityEngine.UIElements.VisualElement.RenderTargetMode m_SubRenderTargetMode;
            /*0x350*/ UnityEngine.Material m_defaultMaterial;
            /*0x358*/ UnityEngine.UIElements.VisualElement.TypeData m_TypeData;
            /*0x360*/ UnityEngine.UIElements.VisualElement.Hierarchy <hierarchy>k__BackingField;
            /*0x368*/ bool <isRootVisualContainer>k__BackingField;
            /*0x369*/ bool <cacheAsBitmap>k__BackingField;
            /*0x370*/ UnityEngine.UIElements.VisualElement m_PhysicalParent;
            /*0x378*/ UnityEngine.UIElements.VisualElement m_LogicalParent;
            /*0x380*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> m_Children;
            /*0x388*/ UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField;
            /*0x390*/ UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource;
            /*0x398*/ UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess;
            /*0x3a0*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> styleSheetList;
            /*0x3a8*/ System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_RunningAnimations;

            static /*0x13f9450*/ VisualElement();
            static /*0x13ecff0*/ float Min(float a, float b, float c, float d);
            static /*0x13ed00c*/ float Max(float a, float b, float c, float d);
            static /*0x13ed1ac*/ UnityEngine.Rect CalculateConservativeRect(ref UnityEngine.Matrix4x4 matrix, UnityEngine.Rect rect);
            static /*0x13ed654*/ void TransformAlignedRect(ref UnityEngine.Matrix4x4 matrix, ref UnityEngine.Rect rect);
            static /*0x13ed580*/ void OrderMinMaxRect(ref UnityEngine.Rect rect);
            static /*0x13ed6e8*/ UnityEngine.Vector2 MultiplyMatrix44Point2(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector2 point);
            static /*0x13ed70c*/ UnityEngine.Vector2 MultiplyVector2(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector2 vector);
            static /*0x13ed728*/ void MultiplyMatrix34(ref UnityEngine.Matrix4x4 lhs, ref UnityEngine.Matrix4x4 rhs, ref UnityEngine.Matrix4x4 res);
            static /*0x13ed900*/ void TranslateMatrix34(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector3 rhs, ref UnityEngine.Matrix4x4 res);
            static /*0x13ed9ec*/ void TranslateMatrix34InPlace(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector3 rhs);
            static /*0x13f0e44*/ UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect position, UnityEngine.Matrix4x4 mat);
            static /*0x13f4a20*/ void CheckUserKeyArgument(UnityEngine.PropertyName key);
            static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation<T>(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement, T> fromValueGetter, T to, int durationMs, System.Action<UnityEngine.UIElements.VisualElement, T> onValueChanged);
            static /*0x13f69a4*/ void AssignStyleValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues src);
            /*0x13f14b0*/ VisualElement();
            /*0x13ea900*/ string get_tooltip();
            /*0x13eaa14*/ void set_tooltip(string value);
            /*0x13eac18*/ UnityEngine.UIElements.IVisualElementScheduler get_schedule();
            /*0x13eac1c*/ UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
            /*0x13ead44*/ UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action updateEvent);
            /*0x13eae50*/ bool get_hasRunningAnimations();
            /*0x13eaf00*/ bool get_hasCompletedAnimations();
            /*0x13eafac*/ int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount();
            /*0x13eafb4*/ void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value);
            /*0x13eafbc*/ int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount();
            /*0x13eafc4*/ void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value);
            /*0x13eafcc*/ UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem();
            /*0x13eaefc*/ UnityEngine.UIElements.IStylePropertyAnimations get_styleAnimation();
            /*0x13eafe8*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb0ec*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb208*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb438*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb588*/ bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb6a4*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb7fc*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eb92c*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13eba48*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13ebbd4*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13ebd04*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13ebee0*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13ec068*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x13ec244*/ void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x13ec314*/ void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations();
            /*0x13ec3f4*/ void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x13ec4bc*/ void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
            /*0x13eb340*/ bool TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.Length from, ref UnityEngine.UIElements.Length to);
            /*0x13ec218*/ bool TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin from, ref UnityEngine.UIElements.TransformOrigin to);
            /*0x13ebeb4*/ bool TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate from, ref UnityEngine.UIElements.Translate to);
            /*0x13ec5a8*/ UnityEngine.Vector3 get_positionWithLayout();
            /*0x13ec8e8*/ UnityEngine.Matrix4x4 get_pivotedMatrixWithLayout();
            /*0x13ecf18*/ bool get_hasDefaultRotationAndScale();
            /*0x13ed028*/ void TransformAlignedRectToParentSpace(ref UnityEngine.Rect rect);
            /*0x13eda48*/ bool get_isCompositeRoot();
            /*0x13eda54*/ void set_isCompositeRoot(bool value);
            /*0x13eda80*/ bool get_isHierarchyDisplayed();
            /*0x13eda8c*/ void set_isHierarchyDisplayed(bool value);
            /*0x13edab8*/ string get_viewDataKey();
            /*0x13edac0*/ void set_viewDataKey(string value);
            /*0x13edb50*/ bool get_enableViewDataPersistence();
            /*0x13edb5c*/ void set_enableViewDataPersistence(bool value);
            /*0x13edb88*/ object get_userData();
            /*0x13edce8*/ void set_userData(object value);
            /*0x13edfac*/ bool get_canGrabFocus();
            /*0x13ee1a0*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x13ee258*/ UnityEngine.UIElements.UsageHints get_usageHints();
            /*0x13ee284*/ void set_usageHints(UnityEngine.UIElements.UsageHints value);
            /*0x13ee27c*/ UnityEngine.UIElements.RenderHints get_renderHints();
            /*0x13ee308*/ void set_renderHints(UnityEngine.UIElements.RenderHints value);
            /*0x13ee354*/ void MarkRenderHintsClean();
            /*0x13ee364*/ UnityEngine.UIElements.ITransform get_transform();
            /*0x13ee368*/ UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_position();
            /*0x13ee408*/ void UnityEngine.UIElements.ITransform.set_position(UnityEngine.Vector3 value);
            /*0x13ee5e4*/ UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_scale();
            /*0x13ee698*/ UnityEngine.Vector3 ComputeGlobalScale();
            /*0x13ee800*/ bool get_isLayoutManual();
            /*0x13ee80c*/ void set_isLayoutManual(bool value);
            /*0x13ee838*/ float get_scaledPixelsPerPoint();
            /*0x13ec840*/ UnityEngine.Rect get_layout();
            /*0x13ee84c*/ void set_layout(UnityEngine.Rect value);
            /*0x13ef11c*/ UnityEngine.Rect get_contentRect();
            /*0x13ef330*/ UnityEngine.Rect get_paddingRect();
            /*0x13ef5b0*/ bool get_isBoundingBoxDirty();
            /*0x13ef5bc*/ void set_isBoundingBoxDirty(bool value);
            /*0x13ef5e8*/ bool get_isWorldBoundingBoxDirty();
            /*0x13ef5f4*/ void set_isWorldBoundingBoxDirty(bool value);
            /*0x13ef620*/ UnityEngine.Rect get_boundingBox();
            /*0x13efa08*/ UnityEngine.Rect get_worldBoundingBox();
            /*0x13efb44*/ UnityEngine.Rect get_boundingBoxInParentSpace();
            /*0x13ef65c*/ void UpdateBoundingBox();
            /*0x13efa48*/ void UpdateWorldBoundingBox();
            /*0x13efd28*/ UnityEngine.Rect get_worldBound();
            /*0x13efdf8*/ UnityEngine.Rect get_localBound();
            /*0x13ef544*/ UnityEngine.Rect get_rect();
            /*0x13eff8c*/ bool get_isWorldTransformDirty();
            /*0x13eff98*/ void set_isWorldTransformDirty(bool value);
            /*0x13effc4*/ bool get_isWorldTransformInverseDirty();
            /*0x13effd0*/ void set_isWorldTransformInverseDirty(bool value);
            /*0x13efffc*/ UnityEngine.Matrix4x4 get_worldTransform();
            /*0x13efd04*/ ref UnityEngine.Matrix4x4 get_worldTransformRef();
            /*0x13f02f4*/ ref UnityEngine.Matrix4x4 get_worldTransformInverse();
            /*0x13f003c*/ void UpdateWorldTransform();
            /*0x13f031c*/ void UpdateWorldTransformInverse();
            /*0x13f0374*/ bool get_isWorldClipDirty();
            /*0x13f0380*/ void set_isWorldClipDirty(bool value);
            /*0x13f03ac*/ UnityEngine.Rect get_worldClip();
            /*0x13f0668*/ UnityEngine.Rect get_worldClipMinusGroup();
            /*0x13f06a4*/ bool get_worldClipIsInfinite();
            /*0x13f06d4*/ void EnsureWorldTransformAndClipUpToDate();
            /*0x13f03e8*/ void UpdateWorldClip();
            /*0x13f0d4c*/ UnityEngine.Rect CombineClipRects(UnityEngine.Rect rect, UnityEngine.Rect parentRect);
            /*0x13f0710*/ UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect worldRect);
            /*0x13f1014*/ UnityEngine.UIElements.PseudoStates get_pseudoStates();
            /*0x13f101c*/ void set_pseudoStates(UnityEngine.UIElements.PseudoStates value);
            /*0x13f10a0*/ int get_containedPointerIds();
            /*0x13f10a8*/ void set_containedPointerIds(int value);
            /*0x13f10b0*/ void UpdateHoverPseudoState();
            /*0x13f117c*/ UnityEngine.UIElements.PickingMode get_pickingMode();
            /*0x13f1184*/ void set_pickingMode(UnityEngine.UIElements.PickingMode value);
            /*0x13f118c*/ string get_name();
            /*0x13f1194*/ void set_name(string value);
            /*0x13f11ec*/ string get_fullTypeName();
            /*0x13f1378*/ string get_typeName();
            /*0x13f1428*/ UnityEngine.Yoga.YogaNode get_yogaNode();
            /*0x13f1430*/ void set_yogaNode(UnityEngine.Yoga.YogaNode value);
            /*0x13ecfe8*/ ref UnityEngine.UIElements.ComputedStyle get_computedStyle();
            /*0x13f1438*/ bool get_hasInlineStyle();
            /*0x13f1448*/ bool get_styleInitialized();
            /*0x13f1454*/ void set_styleInitialized(bool value);
            /*0x13f1480*/ void ChangeIMGUIContainerCount(int delta);
            /*0x13f1768*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x13f2174*/ UnityEngine.Rect GetTooltipRect();
            /*0x13f2098*/ void SetTooltip(UnityEngine.UIElements.TooltipEvent e);
            /*0x13f2178*/ void Focus();
            /*0x13f21cc*/ void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel p);
            /*0x13f2c38*/ void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel destinationPanel);
            /*0x13f2e14*/ void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel prevPanel);
            /*0x13f320c*/ void SendEvent(UnityEngine.UIElements.EventBase e);
            /*0x13f3224*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x13edb28*/ void IncrementVersion(UnityEngine.UIElements.VersionChangeType changeType);
            /*0x13f3238*/ void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType changeType);
            /*0x13f3258*/ bool SetEnabledFromHierarchyPrivate(bool state);
            /*0x13f35d4*/ bool get_isParentEnabledInHierarchy();
            /*0x13ee190*/ bool get_enabledInHierarchy();
            /*0x13f3944*/ bool get_enabledSelf();
            /*0x13f394c*/ void set_enabledSelf(bool value);
            /*0x13f1744*/ void SetEnabled(bool value);
            /*0x13f3958*/ void PropagateEnabledToChildren(bool value);
            /*0x13ee0e0*/ bool get_visible();
            /*0x13f3a08*/ void set_visible(bool value);
            /*0x13f3aec*/ void MarkDirtyRepaint();
            /*0x13f3b10*/ System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent();
            /*0x13f3b18*/ void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value);
            /*0x13f3b20*/ void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x13f3c98*/ void GetFullHierarchicalViewDataKey(System.Text.StringBuilder key);
            /*0x13f3d2c*/ string GetFullHierarchicalViewDataKey();
            /*0x13f3da0*/ void OverwriteFromViewData(object obj, string key);
            /*0x13f40c0*/ void SaveViewData();
            /*0x13f413c*/ bool IsViewDataPersitenceSupportedOnChildren(bool existingState);
            /*0x13f41b0*/ void OnViewDataReady(bool enablePersistence);
            /*0x13f41e8*/ void OnViewDataReady();
            /*0x13f41ec*/ bool ContainsPoint(UnityEngine.Vector2 localPoint);
            /*0x13f4234*/ bool get_requireMeasureFunction();
            /*0x13f4240*/ void set_requireMeasureFunction(bool value);
            /*0x13f42b0*/ void AssignMeasureFunction();
            /*0x13f433c*/ void RemoveMeasureFunction();
            /*0x13f435c*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x13f436c*/ UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
            /*0x13f4494*/ void FinalizeLayout();
            /*0x13f44e0*/ void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule);
            /*0x13f4570*/ void SetComputedStyle(ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x13f473c*/ string ToString();
            /*0x13f4970*/ System.Collections.Generic.List<string> GetClassesForIteration();
            /*0x13f3730*/ void AddToClassList(string className);
            /*0x13f3608*/ void RemoveFromClassList(string className);
            /*0x13f3938*/ void EnableInClassList(string className, bool enable);
            /*0x13f4978*/ bool ClassListContains(string cls);
            /*0x13ea994*/ object GetProperty(UnityEngine.PropertyName key);
            /*0x13eaba0*/ void SetProperty(UnityEngine.PropertyName key, object value);
            /*0x13eab20*/ bool HasProperty(UnityEngine.PropertyName key);
            /*0x13edc00*/ bool TryGetPropertyInternal(UnityEngine.PropertyName key, ref object value);
            /*0x13edd58*/ void SetPropertyInternal(UnityEngine.PropertyName key, object value);
            /*0x13f1e10*/ void UpdateCursorStyle(long eventType);
            /*0x13f4b88*/ UnityEngine.UIElements.VisualElement.RenderTargetMode get_subRenderTargetMode();
            /*0x13f4b90*/ UnityEngine.Material get_defaultMaterial();
            /*0x13f1204*/ UnityEngine.UIElements.VisualElement.TypeData get_typeData();
            /*0x13f4c04*/ UnityEngine.UIElements.IExperimentalFeatures get_experimental();
            /*0x13f4c08*/ UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation();
            /*0x13f4c0c*/ UnityEngine.UIElements.VisualElement.Hierarchy get_hierarchy();
            /*0x13f4c14*/ void set_hierarchy(UnityEngine.UIElements.VisualElement.Hierarchy value);
            /*0x13f4c1c*/ bool get_isRootVisualContainer();
            /*0x13f4c24*/ void set_isRootVisualContainer(bool value);
            /*0x13f4c30*/ bool get_disableClipping();
            /*0x13f4c3c*/ void set_disableClipping(bool value);
            /*0x13efcd8*/ bool ShouldClip();
            /*0x13ee0d8*/ UnityEngine.UIElements.VisualElement get_parent();
            /*0x13f4c68*/ UnityEngine.UIElements.BaseVisualElementPanel get_elementPanel();
            /*0x13f4c70*/ void set_elementPanel(UnityEngine.UIElements.BaseVisualElementPanel value);
            /*0x13ee250*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x13f4c78*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x13f4c7c*/ void set_visualTreeAssetSource(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x13f4c84*/ void Add(UnityEngine.UIElements.VisualElement child);
            /*0x13f4db0*/ void Insert(int index, UnityEngine.UIElements.VisualElement element);
            /*0x13f5158*/ void Clear();
            /*0x13f5500*/ UnityEngine.UIElements.VisualElement ElementAt(int index);
            /*0x13f5504*/ UnityEngine.UIElements.VisualElement get_Item(int key);
            /*0x13f55d8*/ int get_childCount();
            /*0x13f568c*/ int IndexOf(UnityEngine.UIElements.VisualElement element);
            /*0x13f5768*/ UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<int> childIndexes);
            /*0x13f5910*/ bool FindElementInTree(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<int> outChildIndexes);
            /*0x13f59f8*/ void BringToFront();
            /*0x13f5ae4*/ void SendToBack();
            /*0x13f5bb4*/ void PlaceBehind(UnityEngine.UIElements.VisualElement sibling);
            /*0x13f5d78*/ void RemoveFromHierarchy();
            /*0x13f5ea4*/ bool Contains(UnityEngine.UIElements.VisualElement child);
            /*0x13f2b60*/ void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements);
            /*0x13f5ed8*/ UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement other);
            /*0x13f5ff0*/ UnityEngine.UIElements.VisualElement GetRoot();
            /*0x13f60b0*/ UnityEngine.UIElements.VisualElement GetRootVisualContainer();
            /*0x13f60e8*/ UnityEngine.UIElements.VisualElement GetNextElementDepthFirst();
            /*0x13f61d8*/ UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst();
            /*0x13f62c0*/ UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement retargetAgainst);
            /*0x13ee574*/ UnityEngine.UIElements.IStyle get_style();
            /*0x13f6324*/ UnityEngine.UIElements.ICustomStyle get_customStyle();
            /*0x13f63a4*/ UnityEngine.UIElements.VisualElementStyleSheetSet get_styleSheets();
            /*0x13f63c8*/ void AddStyleSheetPath(string sheetPath);
            /*0x13f65fc*/ UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length length, bool isRow);
            /*0x13ec60c*/ UnityEngine.Vector3 ResolveTranslate();
            /*0x13ecae8*/ UnityEngine.Vector3 ResolveTransformOrigin();
            /*0x13ecea8*/ UnityEngine.Quaternion ResolveRotation();
            /*0x13ecef0*/ UnityEngine.Vector3 ResolveScale();
            /*0x13f678c*/ UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem();
            /*0x13f6820*/ void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x13f692c*/ void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x13f30d0*/ void UnregisterRunningAnimations();
            /*0x13f31a0*/ void RegisterRunningAnimations();
            /*0x13f7f84*/ UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues targetValuesToRead);
            /*0x13f8e68*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues to, int durationMs);
            /*0x13f8f38*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues to, int durationMs);
            /*0x13ee18c*/ UnityEngine.UIElements.IResolvedStyle get_resolvedStyle();
            /*0x13f90bc*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor();
            /*0x13f90c8*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor();
            /*0x13f90d4*/ float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius();
            /*0x13f90f0*/ float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius();
            /*0x13f910c*/ float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth();
            /*0x13f9128*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor();
            /*0x13f9134*/ float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth();
            /*0x13f9150*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor();
            /*0x13f915c*/ float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth();
            /*0x13f9178*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor();
            /*0x13f9184*/ float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius();
            /*0x13f91a0*/ float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius();
            /*0x13f91bc*/ float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth();
            /*0x13f91d8*/ float UnityEngine.UIElements.IResolvedStyle.get_bottom();
            /*0x13f91f4*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_color();
            /*0x13f9200*/ UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display();
            /*0x13f920c*/ float UnityEngine.UIElements.IResolvedStyle.get_flexGrow();
            /*0x13f9218*/ float UnityEngine.UIElements.IResolvedStyle.get_flexShrink();
            /*0x13f9224*/ float UnityEngine.UIElements.IResolvedStyle.get_height();
            /*0x13f9240*/ float UnityEngine.UIElements.IResolvedStyle.get_left();
            /*0x13f925c*/ float UnityEngine.UIElements.IResolvedStyle.get_marginBottom();
            /*0x13f9278*/ float UnityEngine.UIElements.IResolvedStyle.get_marginLeft();
            /*0x13f9294*/ float UnityEngine.UIElements.IResolvedStyle.get_marginRight();
            /*0x13f92b0*/ float UnityEngine.UIElements.IResolvedStyle.get_marginTop();
            /*0x13f92cc*/ UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight();
            /*0x13f92f4*/ UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth();
            /*0x13f931c*/ float UnityEngine.UIElements.IResolvedStyle.get_opacity();
            /*0x13f9328*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom();
            /*0x13f9344*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft();
            /*0x13f9360*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingRight();
            /*0x13f937c*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingTop();
            /*0x13f9398*/ float UnityEngine.UIElements.IResolvedStyle.get_right();
            /*0x13f93b4*/ UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.get_scale();
            /*0x13f93c0*/ float UnityEngine.UIElements.IResolvedStyle.get_top();
            /*0x13f93dc*/ UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate();
            /*0x13f93e0*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor();
            /*0x13f93ec*/ int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft();
            /*0x13f93f8*/ int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight();
            /*0x13f9404*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor();
            /*0x13f9410*/ float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth();
            /*0x13f941c*/ UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility();
            /*0x13f9428*/ UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace();
            /*0x13f9434*/ float UnityEngine.UIElements.IResolvedStyle.get_width();
            /*0x13f96e0*/ UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__283_0(UnityEngine.Yoga.YogaNode node, float f, UnityEngine.Yoga.YogaMeasureMode mode, float f1, UnityEngine.Yoga.YogaMeasureMode heightMode);

            class BaseVisualElementScheduledItem : UnityEngine.UIElements.ScheduledItem, UnityEngine.UIElements.IVisualElementScheduledItem, UnityEngine.UIElements.IVisualElementPanelActivatable
            {
                /*0x38*/ UnityEngine.UIElements.VisualElement <element>k__BackingField;
                /*0x40*/ bool isScheduled;
                /*0x48*/ UnityEngine.UIElements.VisualElementPanelActivator m_Activator;

                /*0x13f96f4*/ BaseVisualElementScheduledItem(UnityEngine.UIElements.VisualElement handler);
                /*0x13f96e4*/ UnityEngine.UIElements.VisualElement get_element();
                /*0x13f96ec*/ void set_element(UnityEngine.UIElements.VisualElement value);
                /*0x13f97c4*/ UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(long delayMs);
                /*0x13f97cc*/ UnityEngine.UIElements.IVisualElementScheduledItem Every(long intervalMs);
                /*0x13f9870*/ void OnItemUnscheduled();
                /*0x13ead28*/ void Resume();
                /*0x13f9be8*/ void Pause();
                /*0x13f9c04*/ void ExecuteLater(long delayMs);
                /*0x13f9c40*/ void OnPanelActivate();
                /*0x13f9d30*/ void OnPanelDeactivate();
                /*0x13f9e0c*/ bool CanBeActivated();
            }

            class VisualElementScheduledItem<ActionType> : UnityEngine.UIElements.VisualElement.BaseVisualElementScheduledItem
            {
                /*0x0*/ ActionType updateEvent;

                VisualElementScheduledItem(UnityEngine.UIElements.VisualElement handler, ActionType upEvent);
            }

            class TimerStateScheduledItem : UnityEngine.UIElements.VisualElement.VisualElementScheduledItem<System.Action<UnityEngine.UIElements.TimerState>>
            {
                /*0x13eacc8*/ TimerStateScheduledItem(UnityEngine.UIElements.VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent);
                /*0x13f9e48*/ void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
            }

            class SimpleScheduledItem : UnityEngine.UIElements.VisualElement.VisualElementScheduledItem<System.Action>
            {
                /*0x13eadf0*/ SimpleScheduledItem(UnityEngine.UIElements.VisualElement handler, System.Action updateEvent);
                /*0x13f9e7c*/ void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
            }

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement.UxmlTraits>
            {
                /*0x13f9eb0*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.UxmlTraits
            {
                /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
                /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_ViewDataKey;
                /*0x28*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.PickingMode> m_PickingMode;
                /*0x30*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Tooltip;
                /*0x38*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.UsageHints> m_UsageHints;
                /*0x40*/ UnityEngine.UIElements.UxmlIntAttributeDescription <focusIndex>k__BackingField;
                /*0x48*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_TabIndex;
                /*0x50*/ UnityEngine.UIElements.UxmlBoolAttributeDescription <focusable>k__BackingField;
                /*0x58*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Class;
                /*0x60*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_ContentContainer;
                /*0x68*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Style;

                /*0x13fa190*/ UxmlTraits();
                /*0x13f9ef8*/ UnityEngine.UIElements.UxmlIntAttributeDescription get_focusIndex();
                /*0x13f9f00*/ UnityEngine.UIElements.UxmlBoolAttributeDescription get_focusable();
                /*0x13f9f08*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            enum MeasureMode
            {
                Undefined = 0,
                Exactly = 1,
                AtMost = 2,
            }

            enum RenderTargetMode
            {
                None = 0,
                NoColorConversion = 1,
                LinearToGamma = 2,
                GammaToLinear = 3,
            }

            class TypeData
            {
                /*0x10*/ System.Type <type>k__BackingField;
                /*0x18*/ string m_FullTypeName;
                /*0x20*/ string m_TypeName;

                /*0x13f4b98*/ TypeData(System.Type type);
                /*0x13fa660*/ System.Type get_type();
                /*0x13f1330*/ string get_fullTypeName();
                /*0x13f1390*/ string get_typeName();
            }

            struct Hierarchy
            {
                static string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";
                /*0x10*/ UnityEngine.UIElements.VisualElement m_Owner;

                static /*0x13fac98*/ bool op_Equality(UnityEngine.UIElements.VisualElement.Hierarchy x, UnityEngine.UIElements.VisualElement.Hierarchy y);
                /*0x13f173c*/ Hierarchy(UnityEngine.UIElements.VisualElement element);
                /*0x13ee0bc*/ UnityEngine.UIElements.VisualElement get_parent();
                /*0x13f4d34*/ void Add(UnityEngine.UIElements.VisualElement child);
                /*0x13f4e3c*/ void Insert(int index, UnityEngine.UIElements.VisualElement child);
                /*0x13f5db0*/ void Remove(UnityEngine.UIElements.VisualElement child);
                /*0x13fa7d0*/ void RemoveAt(int index);
                /*0x13f51bc*/ void Clear();
                /*0x13f5a30*/ void BringToFront(UnityEngine.UIElements.VisualElement child);
                /*0x13f5b1c*/ void SendToBack(UnityEngine.UIElements.VisualElement child);
                /*0x13f5ca0*/ void PlaceBehind(UnityEngine.UIElements.VisualElement child, UnityEngine.UIElements.VisualElement over);
                /*0x13fab70*/ void MoveChildElement(UnityEngine.UIElements.VisualElement child, int currentIndex, int nextIndex);
                /*0x13f563c*/ int get_childCount();
                /*0x13f5578*/ UnityEngine.UIElements.VisualElement get_Item(int key);
                /*0x13f5708*/ int IndexOf(UnityEngine.UIElements.VisualElement element);
                /*0x13fac84*/ UnityEngine.UIElements.VisualElement ElementAt(int index);
                /*0x13fa7a8*/ void SetParent(UnityEngine.UIElements.VisualElement value);
                /*0x13fa668*/ void PutChildAtIndex(UnityEngine.UIElements.VisualElement child, int index);
                /*0x13faa14*/ void RemoveChildAtIndex(int index);
                /*0x13faa90*/ void ReleaseChildList();
                /*0x13fac88*/ bool Equals(UnityEngine.UIElements.VisualElement.Hierarchy other);
                /*0x13faca4*/ bool Equals(object obj);
                /*0x13fad1c*/ int GetHashCode();
            }

            class CustomStyleAccess : UnityEngine.UIElements.ICustomStyle
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties;
                /*0x18*/ float m_DpiScaling;

                static /*0x13fb094*/ void LogCustomPropertyWarning(string propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp);
                /*0x13f96d8*/ CustomStyleAccess();
                /*0x13f6398*/ void SetContext(System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, float dpiScaling);
                /*0x13fad34*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<float> property, ref float value);
                /*0x13fae88*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<int> property, ref int value);
                /*0x13faf48*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, ref UnityEngine.Color value);
                /*0x13fb198*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, ref UnityEngine.Texture2D value);
                /*0x13fb298*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, ref UnityEngine.Sprite value);
                /*0x13fb398*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, ref UnityEngine.UIElements.VectorImage value);
                /*0x13fb498*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<string> property, ref string value);
                /*0x13fadd0*/ bool TryGetValue(string propertyName, UnityEngine.UIElements.StyleValueType valueType, ref UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp);
            }

            class <>c__DisplayClass437_0
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement <>4__this;
                /*0x18*/ UnityEngine.UIElements.Experimental.StyleValues to;

                /*0x13f8f30*/ <>c__DisplayClass437_0();
                /*0x13fb55c*/ UnityEngine.UIElements.Experimental.StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(UnityEngine.UIElements.VisualElement e);
            }
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ int m_MaxSize;

            ObjectPool(int maxSize);
            int get_maxSize();
            void set_maxSize(int value);
            int Size();
            T Get();
            void Release(T element);
        }

        interface IVisualElementScheduledItem
        {
            void Resume();
            void Pause();
            void ExecuteLater(long delayMs);
            UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(long delayMs);
            UnityEngine.UIElements.IVisualElementScheduledItem Every(long intervalMs);
        }

        interface IVisualElementScheduler
        {
            UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
            UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action updateEvent);
        }

        interface IVisualElementPanelActivatable
        {
            UnityEngine.UIElements.VisualElement get_element();
            bool CanBeActivated();
            void OnPanelActivate();
            void OnPanelDeactivate();
        }

        class VisualElementPanelActivator
        {
            /*0x10*/ UnityEngine.UIElements.IVisualElementPanelActivatable m_Activatable;
            /*0x18*/ bool <isActive>k__BackingField;
            /*0x19*/ bool <isDetaching>k__BackingField;

            /*0x13f979c*/ VisualElementPanelActivator(UnityEngine.UIElements.IVisualElementPanelActivatable activatable);
            /*0x13fb578*/ bool get_isActive();
            /*0x13fb580*/ void set_isActive(bool value);
            /*0x13fb58c*/ bool get_isDetaching();
            /*0x13fb594*/ void set_isDetaching(bool value);
            /*0x13f98ac*/ void SetActive(bool action);
            /*0x13fb5a0*/ void SendActivation();
            /*0x13fb6b8*/ void SendDeactivation();
            /*0x13fb7d0*/ void OnEnter(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x13fb7e0*/ void OnLeave(UnityEngine.UIElements.DetachFromPanelEvent evt);
        }

        enum VisualTreeUpdatePhase
        {
            ViewData = 0,
            Bindings = 1,
            Animation = 2,
            Styles = 3,
            Layout = 4,
            TransformClip = 5,
            Repaint = 6,
            Count = 7,
        }

        class VisualTreeUpdater : System.IDisposable
        {
            /*0x10*/ UnityEngine.UIElements.BaseVisualElementPanel m_Panel;
            /*0x18*/ UnityEngine.UIElements.VisualTreeUpdater.UpdaterArray m_UpdaterArray;

            /*0x13fb854*/ VisualTreeUpdater(UnityEngine.UIElements.BaseVisualElementPanel panel);
            /*0x13fba68*/ void Dispose();
            /*0x13fbb64*/ void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x13fbd30*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            void SetUpdater<T>(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x13fbe18*/ UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x13fb92c*/ void SetDefaultUpdaters();

            class UpdaterArray
            {
                /*0x10*/ UnityEngine.UIElements.IVisualTreeUpdater[] m_VisualTreeUpdaters;

                /*0x13fb8d0*/ UpdaterArray();
                /*0x13fbe30*/ void set_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase, UnityEngine.UIElements.IVisualTreeUpdater value);
                /*0x13fbd00*/ UnityEngine.UIElements.IVisualTreeUpdater get_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
                /*0x13fbb34*/ UnityEngine.UIElements.IVisualTreeUpdater get_Item(int index);
            }
        }

        interface IVisualTreeUpdater : System.IDisposable
        {
            void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value);
            Unity.Profiling.ProfilerMarker get_profilerMarker();
            void Update();
            void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
        }

        class BaseVisualTreeUpdater : UnityEngine.UIElements.IVisualTreeUpdater, System.IDisposable
        {
            /*0x10*/ System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelChanged;
            /*0x18*/ UnityEngine.UIElements.BaseVisualElementPanel m_Panel;

            /*0x13fc0b0*/ BaseVisualTreeUpdater();
            /*0x13fbe94*/ void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x13fbf44*/ void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x13fbff4*/ UnityEngine.UIElements.BaseVisualElementPanel get_panel();
            /*0x13fbffc*/ void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value);
            /*0x13fc01c*/ UnityEngine.UIElements.VisualElement get_visualTree();
            Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x13fc040*/ void Dispose();
            /*0x13fc0ac*/ void Dispose(bool disposing);
            void Update();
            void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
        }

        class ClickDetector
        {
            static /*0x0*/ int <s_DoubleClickTime>k__BackingField;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus> m_ClickStatus;

            static /*0x13fd1bc*/ ClickDetector();
            static /*0x13fc0b8*/ int get_s_DoubleClickTime();
            static /*0x13fc110*/ void set_s_DoubleClickTime(int value);
            static /*0x13fca84*/ bool ContainsPointer(UnityEngine.UIElements.VisualElement element, UnityEngine.Vector2 position);
            /*0x13fc16c*/ ClickDetector();
            /*0x13fc3d4*/ void StartClickTracking(UnityEngine.UIElements.EventBase evt);
            /*0x13fc6a0*/ void SendClickEvent(UnityEngine.UIElements.EventBase evt);
            /*0x13fcba4*/ void CancelClickTracking(UnityEngine.UIElements.EventBase evt);
            /*0x13fcca0*/ void ProcessEvent(UnityEngine.UIElements.EventBase evt);

            class ButtonClickStatus
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement m_Target;
                /*0x18*/ UnityEngine.Vector3 m_PointerDownPosition;
                /*0x28*/ long m_LastPointerDownTime;
                /*0x30*/ int m_ClickCount;

                /*0x13fc3cc*/ ButtonClickStatus();
                /*0x13fc63c*/ void Reset();
            }
        }

        class DropdownUtility
        {
            static /*0x0*/ System.Func<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc;

            static /*0x13fd208*/ UnityEngine.UIElements.IGenericMenu CreateDropdown();
        }

        class AtlasBase
        {
            /*0x10*/ UnityEngine.UIElements.TextureRegistry textureRegistry;

            static /*0x13fd34c*/ void RepaintTexturedElements(UnityEngine.UIElements.IPanel panel);
            /*0x13fd458*/ AtlasBase();
            /*0x13fd2a0*/ bool TryGetAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, ref UnityEngine.UIElements.TextureId atlas, ref UnityEngine.RectInt atlasRect);
            /*0x13fd314*/ void ReturnAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas);
            /*0x13fd318*/ void Reset();
            /*0x13fd31c*/ void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel);
            /*0x13fd320*/ void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel);
            /*0x13fd324*/ void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel);
            /*0x13fd328*/ void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel panel);
            /*0x13fd334*/ void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel panel);
            /*0x13fd340*/ void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel);
            /*0x13fd438*/ void SetDynamicTexture(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture);
        }

        enum DynamicAtlasFilters
        {
            None = 0,
            Readability = 1,
            Size = 2,
            Format = 4,
            ColorSpace = 8,
            FilterMode = 16,
        }

        class DynamicAtlasCustomFilter : System.MulticastDelegate
        {
            /*0x13fd4f0*/ DynamicAtlasCustomFilter(object object, nint method);
            /*0x13fd5c8*/ bool Invoke(UnityEngine.Texture2D texture, ref UnityEngine.UIElements.DynamicAtlasFilters filtersToApply);
        }

        class DynamicAtlas : UnityEngine.UIElements.AtlasBase
        {
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.UIElements.DynamicAtlas.TextureInfo> m_Database;
            /*0x20*/ UnityEngine.UIElements.DynamicAtlasPage m_PointPage;
            /*0x28*/ UnityEngine.UIElements.DynamicAtlasPage m_BilinearPage;
            /*0x30*/ UnityEngine.ColorSpace m_ColorSpace;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.IPanel> m_Panels;
            /*0x40*/ int m_MinAtlasSize;
            /*0x44*/ int m_MaxAtlasSize;
            /*0x48*/ int m_MaxSubTextureSize;
            /*0x4c*/ UnityEngine.UIElements.DynamicAtlasFilters m_ActiveFilters;
            /*0x50*/ UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter;

            static /*0x13fde90*/ bool IsTextureFormatSupported(UnityEngine.TextureFormat format);
            static /*0x13fe02c*/ UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters();
            /*0x13fe0bc*/ DynamicAtlas();
            /*0x13fd5dc*/ bool get_isInitialized();
            /*0x13fd5fc*/ void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel);
            /*0x13fd6cc*/ void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel);
            /*0x13fd7dc*/ void Reset();
            /*0x13fd888*/ void InitPages();
            /*0x13fd764*/ void DestroyPages();
            /*0x13fd990*/ bool TryGetAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, ref UnityEngine.UIElements.TextureId atlas, ref UnityEngine.RectInt atlasRect);
            /*0x13fdcec*/ void ReturnAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas);
            /*0x13fde28*/ void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel);
            /*0x13fdec4*/ bool IsTextureValid(UnityEngine.Texture2D texture, UnityEngine.FilterMode atlasFilterMode);
            /*0x13fdfec*/ void set_minAtlasSize(int value);
            /*0x13fe00c*/ void set_maxAtlasSize(int value);
            /*0x13fe034*/ void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value);
            /*0x13fdfe4*/ int get_maxSubTextureSize();
            /*0x13fe054*/ void set_maxSubTextureSize(int value);
            /*0x13fe074*/ void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value);

            class TextureInfo : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.DynamicAtlas.TextureInfo>
            {
                static /*0x0*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.DynamicAtlas.TextureInfo> pool;
                /*0x18*/ UnityEngine.UIElements.DynamicAtlasPage page;
                /*0x20*/ int counter;
                /*0x28*/ UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc;
                /*0x58*/ UnityEngine.RectInt rect;

                static /*0x1897a84*/ TextureInfo();
                static /*0x18979b4*/ UnityEngine.UIElements.DynamicAtlas.TextureInfo Create();
                static /*0x1897a54*/ void Reset(UnityEngine.UIElements.DynamicAtlas.TextureInfo info);
                /*0x1897a0c*/ TextureInfo();
            }
        }

        class DefaultEventSystem
        {
            static /*0x0*/ System.Func<bool> IsEditorRemoteConnected;
            /*0x10*/ UnityEngine.UIElements.DefaultEventSystem.IInput m_Input;
            /*0x18*/ string m_HorizontalAxis;
            /*0x20*/ string m_VerticalAxis;
            /*0x28*/ string m_SubmitButton;
            /*0x30*/ string m_CancelButton;
            /*0x38*/ float m_InputActionsPerSecond;
            /*0x3c*/ float m_RepeatDelay;
            /*0x40*/ bool m_SendingTouchEvents;
            /*0x48*/ UnityEngine.Event m_Event;
            /*0x50*/ UnityEngine.UIElements.BaseRuntimePanel m_FocusedPanel;
            /*0x58*/ int m_ConsecutiveMoveCount;
            /*0x5c*/ UnityEngine.Vector2 m_LastMoveVector;
            /*0x64*/ float m_PrevActionTime;

            static /*0x189920c*/ DefaultEventSystem();
            static /*0x1898d00*/ UnityEngine.UIElements.EventBase MakeTouchEvent(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers);
            static /*0x18989d0*/ UnityEngine.Vector2 GetLocalScreenPosition(UnityEngine.Event evt, ref System.Nullable<int> targetDisplay);
            /*0x1899118*/ DefaultEventSystem();
            /*0x1897bb4*/ bool get_isAppFocused();
            /*0x1897bbc*/ UnityEngine.UIElements.DefaultEventSystem.IInput get_input();
            /*0x1897c30*/ bool ShouldIgnoreEventsOnAppNotFocused();
            /*0x1897c50*/ UnityEngine.UIElements.BaseRuntimePanel get_focusedPanel();
            /*0x1897c58*/ void set_focusedPanel(UnityEngine.UIElements.BaseRuntimePanel value);
            /*0x1897d28*/ void Update(UnityEngine.UIElements.DefaultEventSystem.UpdateMode updateMode);
            /*0x18981d8*/ void SendIMGUIEvents();
            /*0x189868c*/ void SendInputEvents();
            void SendFocusBasedEvent<TArg>(System.Func<TArg, UnityEngine.UIElements.EventBase> evtFactory, TArg arg);
            void SendPositionBasedEvent<TArg>(UnityEngine.Vector3 mousePosition, UnityEngine.Vector3 delta, int pointerId, System.Nullable<int> targetDisplay, System.Func<UnityEngine.Vector3, UnityEngine.Vector3, TArg, UnityEngine.UIElements.EventBase> evtFactory, TArg arg, bool deselectIfNoTarget);
            /*0x1898c8c*/ void UpdateFocusedPanel(UnityEngine.UIElements.BaseRuntimePanel runtimePanel);
            /*0x1897d94*/ bool ProcessTouchEvents();
            /*0x1898e90*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x18989ec*/ bool ShouldSendMoveFromInput();

            enum UpdateMode
            {
                Always = 0,
                IgnoreIfAppNotFocused = 1,
            }

            interface IInput
            {
                bool GetButtonDown(string button);
                float GetAxisRaw(string axis);
                int get_touchCount();
                UnityEngine.Touch GetTouch(int index);
                bool get_mousePresent();
            }

            class Input : UnityEngine.UIElements.DefaultEventSystem.IInput
            {
                /*0x1897c28*/ Input();
                /*0x18992d0*/ bool GetButtonDown(string button);
                /*0x18992dc*/ float GetAxisRaw(string axis);
                /*0x18992e8*/ int get_touchCount();
                /*0x18992f0*/ UnityEngine.Touch GetTouch(int index);
                /*0x1899328*/ bool get_mousePresent();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.DefaultEventSystem.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__22_0;
                static /*0x10*/ System.Func<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__22_1;
                static /*0x18*/ System.Func<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__22_2;
                static /*0x20*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__23_0;
                static /*0x28*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__23_1;
                static /*0x30*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__23_2;
                static /*0x38*/ System.Func<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Touch, UnityEngine.UIElements.EventBase> <>9__29_0;

                static /*0x1899330*/ <>c();
                /*0x1899394*/ <>c();
                /*0x189939c*/ UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__22_0(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x1899400*/ UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__22_1(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.UIElements.DefaultEventSystem self);
                /*0x189948c*/ UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__22_2(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.UIElements.DefaultEventSystem self);
                /*0x1899540*/ UnityEngine.UIElements.EventBase <SendInputEvents>b__23_0(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x1899560*/ UnityEngine.UIElements.EventBase <SendInputEvents>b__23_1(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x18995c4*/ UnityEngine.UIElements.EventBase <SendInputEvents>b__23_2(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x1899628*/ UnityEngine.UIElements.EventBase <ProcessTouchEvents>b__29_0(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.Touch _touch);
                /*0x18996f4*/ bool <.cctor>b__39_0();
            }
        }

        interface IStylePainter
        {
            void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
            void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
            void DrawImmediate(System.Action callback, bool cullingEnabled);
        }

        struct CursorPositionStylePainterParameters
        {
            /*0x10*/ UnityEngine.Rect rect;
            /*0x20*/ string text;
            /*0x28*/ UnityEngine.Font font;
            /*0x30*/ int fontSize;
            /*0x34*/ UnityEngine.FontStyle fontStyle;
            /*0x38*/ UnityEngine.TextAnchor anchor;
            /*0x3c*/ float wordWrapWidth;
            /*0x40*/ bool richText;
            /*0x44*/ int cursorIndex;

            static /*0x18996fc*/ UnityEngine.UIElements.CursorPositionStylePainterParameters GetDefault(UnityEngine.UIElements.VisualElement ve, string text);
            /*0x1899844*/ UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(float scaling);
        }

        class VisualElementAnimationSystem : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            static /*0x10*/ string s_StylePropertyAnimationDescription;
            static /*0x18*/ Unity.Profiling.ProfilerMarker s_StylePropertyAnimationProfilerMarker;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList;
            /*0x30*/ bool m_HasNewAnimations;
            /*0x31*/ bool m_IterationListDirty;
            /*0x38*/ long lastUpdate;

            static /*0x189a254*/ VisualElementAnimationSystem();
            static /*0x18998ec*/ Unity.Profiling.ProfilerMarker get_stylePropertyAnimationProfilerMarker();
            /*0x189a190*/ VisualElementAnimationSystem();
            /*0x1899894*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x1899944*/ void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x18999a8*/ void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims);
            /*0x1899b20*/ void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x1899b84*/ void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims);
            /*0x1899cfc*/ void Update();
            /*0x189a18c*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
        }

        class AlignmentUtils
        {
            static /*0x189a324*/ float RoundToPixelGrid(float v, float pixelsPerPoint, float offset);
            static /*0x189a340*/ float CeilToPixelGrid(float v, float pixelsPerPoint, float offset);
        }

        enum MouseButton
        {
            LeftMouse = 0,
            RightMouse = 1,
            MiddleMouse = 2,
        }

        class PointerCaptureHelper
        {
            static /*0x189a354*/ UnityEngine.UIElements.PointerDispatchState GetStateFor(UnityEngine.UIElements.IEventHandler handler);
            static /*0x189a46c*/ bool HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            static /*0x189a4dc*/ void CapturePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            static /*0x189a650*/ void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            static /*0x189a6c4*/ UnityEngine.UIElements.IEventHandler GetCapturingElement(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x189a7bc*/ void ReleasePointer(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x189a8b0*/ void ActivateCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x189a9a8*/ void PreventCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x189aa9c*/ bool ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.IPointerEvent evt);
            static /*0x189acf4*/ void ProcessPointerCapture(UnityEngine.UIElements.IPanel panel, int pointerId);
        }

        class PointerDispatchState
        {
            /*0x10*/ UnityEngine.UIElements.IEventHandler[] m_PendingPointerCapture;
            /*0x18*/ UnityEngine.UIElements.IEventHandler[] m_PointerCapture;
            /*0x20*/ bool[] m_ShouldSendCompatibilityMouseEvents;

            /*0x189b710*/ PointerDispatchState();
            /*0x189b7e8*/ void Reset();
            /*0x189a78c*/ UnityEngine.UIElements.IEventHandler GetCapturingElement(int pointerId);
            /*0x189a4a4*/ bool HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            /*0x189a514*/ void CapturePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            /*0x189a880*/ void ReleasePointer(int pointerId);
            /*0x189a688*/ void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            /*0x189adb8*/ void ProcessPointerCapture(int pointerId);
            /*0x189a974*/ void ActivateCompatibilityMouseEvents(int pointerId);
            /*0x189aa6c*/ void PreventCompatibilityMouseEvents(int pointerId);
            /*0x189abc0*/ bool ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent evt);
        }

        class ContextualMenuManager
        {
            /*0x10*/ bool <displayMenuHandledOSX>k__BackingField;

            void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IEventHandler eventHandler);
            void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.EventBase triggerEvent);
        }

        class TemplateContainer : UnityEngine.UIElements.BindableElement
        {
            /*0x3c0*/ string <templateId>k__BackingField;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_ContentContainer;
            /*0x3d0*/ UnityEngine.UIElements.VisualTreeAsset m_TemplateSource;

            /*0x189b890*/ TemplateContainer();
            /*0x189b8ac*/ TemplateContainer(string templateId);
            /*0x189b878*/ string get_templateId();
            /*0x189b880*/ void set_templateId(string value);
            /*0x189b888*/ void set_templateSource(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x189b92c*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x189b934*/ void SetContentContainer(UnityEngine.UIElements.VisualElement content);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TemplateContainer, UnityEngine.UIElements.TemplateContainer.UxmlTraits>
            {
                /*0x189b9f0*/ UxmlFactory();
                /*0x189b93c*/ string get_uxmlName();
                /*0x189b97c*/ string get_uxmlQualifiedName();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Template;

                /*0x189bf08*/ UxmlTraits();
                /*0x189ba38*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        interface ITransform
        {
            UnityEngine.Vector3 get_position();
            void set_position(UnityEngine.Vector3 value);
            UnityEngine.Vector3 get_scale();
        }

        interface IStylePropertyAnimations
        {
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            void UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
            void CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void CancelAllAnimations();
            int get_runningAnimationCount();
            void set_runningAnimationCount(int value);
            int get_completedAnimationCount();
            void set_completedAnimationCount(int value);
        }

        class UIElementsPackageUtility
        {
            static /*0x0*/ string EditorResourcesBasePath;
            static /*0x8*/ bool IsUIEPackageLoaded;

            static /*0x189c018*/ UIElementsPackageUtility();
        }

        struct ManipulatorActivationFilter : System.IEquatable<UnityEngine.UIElements.ManipulatorActivationFilter>
        {
            /*0x10*/ UnityEngine.UIElements.MouseButton <button>k__BackingField;
            /*0x14*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x18*/ int <clickCount>k__BackingField;

            /*0x189c084*/ UnityEngine.UIElements.MouseButton get_button();
            /*0x189c08c*/ void set_button(UnityEngine.UIElements.MouseButton value);
            /*0x189c094*/ UnityEngine.EventModifiers get_modifiers();
            /*0x189c09c*/ int get_clickCount();
            /*0x189c0a4*/ bool Equals(object obj);
            /*0x189c13c*/ bool Equals(UnityEngine.UIElements.ManipulatorActivationFilter other);
            /*0x189c170*/ int GetHashCode();
            /*0x189c1f0*/ bool Matches(UnityEngine.UIElements.IMouseEvent e);
            /*0x189c348*/ bool HasModifiers(UnityEngine.UIElements.IMouseEvent e);
            /*0x189c590*/ bool Matches(UnityEngine.UIElements.IPointerEvent e);
            /*0x189c6e8*/ bool HasModifiers(UnityEngine.UIElements.IPointerEvent e);
            /*0x189c53c*/ bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command);
        }

        class VisualTreeTransformClipUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ uint m_Version;
            /*0x24*/ uint m_LastVersion;

            static /*0x189ce94*/ VisualTreeTransformClipUpdater();
            static /*0x189ca28*/ void DirtyHierarchy(UnityEngine.UIElements.VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip);
            static /*0x189cb7c*/ void DirtyBoundingBoxHierarchy(UnityEngine.UIElements.VisualElement ve);
            /*0x189ce88*/ VisualTreeTransformClipUpdater();
            /*0x189c8dc*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x189c934*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x189cc24*/ void Update();
        }

        enum HierarchyChangeType
        {
            Add = 0,
            Remove = 1,
            Move = 2,
        }

        class BaseVisualTreeHierarchyTrackerUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            /*0x20*/ UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.State m_State;
            /*0x28*/ UnityEngine.UIElements.VisualElement m_CurrentChangeElement;
            /*0x30*/ UnityEngine.UIElements.VisualElement m_CurrentChangeParent;

            /*0x189d184*/ BaseVisualTreeHierarchyTrackerUpdater();
            void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type);
            /*0x189cf20*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x189d0f0*/ void Update();
            /*0x189cf4c*/ void ProcessNewChange(UnityEngine.UIElements.VisualElement ve);
            /*0x189d034*/ void ProcessAddOrMove(UnityEngine.UIElements.VisualElement ve);
            /*0x189cfd0*/ void ProcessRemove(UnityEngine.UIElements.VisualElement ve);

            enum State
            {
                Waiting = 0,
                TrackingAddOrMove = 1,
                TrackingRemove = 2,
            }
        }

        class ClampedDragger<T> : UnityEngine.UIElements.Clickable
        {
            /*0x0*/ System.Action dragging;
            /*0x0*/ UnityEngine.UIElements.ClampedDragger.DragDirection<T> <dragDirection>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.BaseSlider<T> <slider>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <startMousePosition>k__BackingField;

            ClampedDragger(UnityEngine.UIElements.BaseSlider<T> slider, System.Action clickHandler, System.Action dragHandler);
            void add_dragging(System.Action value);
            void remove_dragging(System.Action value);
            UnityEngine.UIElements.ClampedDragger.DragDirection<T> get_dragDirection();
            void set_dragDirection(UnityEngine.UIElements.ClampedDragger.DragDirection<T> value);
            void set_slider(UnityEngine.UIElements.BaseSlider<T> value);
            UnityEngine.Vector2 get_startMousePosition();
            void set_startMousePosition(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_delta();
            void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, int pointerId);
            void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition);

            enum DragDirection<T>
            {
                None = 0,
                LowToHigh = 1,
                HighToLow = 2,
                Free = 4,
            }
        }

        struct TextShadow : System.IEquatable<UnityEngine.UIElements.TextShadow>
        {
            /*0x10*/ UnityEngine.Vector2 offset;
            /*0x18*/ float blurRadius;
            /*0x1c*/ UnityEngine.Color color;

            static /*0x189d378*/ bool op_Equality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2);
            static /*0x189d3a8*/ bool op_Inequality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2);
            static /*0x189d4e4*/ UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, float t);
            /*0x189d190*/ bool Equals(object obj);
            /*0x189d220*/ bool Equals(UnityEngine.UIElements.TextShadow other);
            /*0x189d2a0*/ int GetHashCode();
            /*0x189d3f0*/ string ToString();
        }

        struct StylePropertyName : System.IEquatable<UnityEngine.UIElements.StylePropertyName>
        {
            /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId <id>k__BackingField;
            /*0x18*/ string <name>k__BackingField;

            static /*0x189d54c*/ UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(string name);
            static /*0x189d6cc*/ bool op_Equality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs);
            static /*0x189d6d8*/ bool op_Inequality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs);
            static /*0x189d6e4*/ UnityEngine.UIElements.StylePropertyName op_Implicit(string name);
            /*0x189d5ec*/ StylePropertyName(UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId);
            /*0x189d698*/ StylePropertyName(string name);
            /*0x189d53c*/ UnityEngine.UIElements.StyleSheets.StylePropertyId get_id();
            /*0x189d544*/ string get_name();
            /*0x189d704*/ int GetHashCode();
            /*0x189d70c*/ bool Equals(object other);
            /*0x189d784*/ bool Equals(UnityEngine.UIElements.StylePropertyName other);
            /*0x189d794*/ string ToString();
        }

        class MouseManipulator : UnityEngine.UIElements.Manipulator
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.ManipulatorActivationFilter m_currentActivator;

            /*0x189d7ac*/ MouseManipulator();
            /*0x189d79c*/ System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators();
            /*0x189d7a4*/ void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value);
            /*0x189d82c*/ bool CanStartManipulation(UnityEngine.UIElements.IMouseEvent e);
            /*0x189d9a8*/ bool CanStopManipulation(UnityEngine.UIElements.IMouseEvent e);
        }

        class VisualElementFocusChangeDirection : UnityEngine.UIElements.FocusChangeDirection
        {
            static /*0x0*/ UnityEngine.UIElements.VisualElementFocusChangeDirection s_Left;
            static /*0x8*/ UnityEngine.UIElements.VisualElementFocusChangeDirection s_Right;

            static /*0x189db78*/ VisualElementFocusChangeDirection();
            static /*0x189da60*/ UnityEngine.UIElements.FocusChangeDirection get_left();
            static /*0x189dab8*/ UnityEngine.UIElements.FocusChangeDirection get_right();
            /*0x189db10*/ VisualElementFocusChangeDirection(int value);
        }

        class VisualElementFocusChangeTarget : UnityEngine.UIElements.FocusChangeDirection
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool;
            /*0x18*/ UnityEngine.UIElements.Focusable <target>k__BackingField;

            static /*0x189dea0*/ VisualElementFocusChangeTarget();
            static /*0x189dcc0*/ UnityEngine.UIElements.VisualElementFocusChangeTarget GetPooled(UnityEngine.UIElements.Focusable target);
            /*0x189ddf0*/ VisualElementFocusChangeTarget();
            /*0x189dd48*/ void Dispose();
            /*0x189ddcc*/ void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f);
            /*0x189de90*/ UnityEngine.UIElements.Focusable get_target();
            /*0x189de98*/ void set_target(UnityEngine.UIElements.Focusable value);
        }

        class VisualElementFocusRing : UnityEngine.UIElements.IFocusRing
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement root;
            /*0x18*/ UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder <defaultFocusOrder>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_FocusRing;

            static /*0x189ef00*/ UnityEngine.UIElements.FocusChangeDirection GetKeyDownFocusChangeDirection(UnityEngine.UIElements.EventBase e);
            static /*0x189f4f4*/ UnityEngine.UIElements.Focusable GetNextFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable);
            static /*0x189f590*/ UnityEngine.UIElements.Focusable GetPreviousFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable);
            /*0x189df30*/ VisualElementFocusRing(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder dfo);
            /*0x189dfc8*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x189dfec*/ UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder get_defaultFocusOrder();
            /*0x189dff4*/ void set_defaultFocusOrder(UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder value);
            /*0x189dffc*/ int FocusRingAutoIndexSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b);
            /*0x189e44c*/ int FocusRingSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b);
            /*0x189e53c*/ void DoUpdate();
            /*0x189e614*/ void BuildRingForScopeRecursive(UnityEngine.UIElements.VisualElement ve, ref int scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList);
            /*0x189e90c*/ void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList);
            /*0x189ebdc*/ int GetFocusableInternalIndex(UnityEngine.UIElements.Focusable f);
            /*0x189ec84*/ UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e);
            /*0x189f104*/ UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction);

            enum DefaultFocusOrder
            {
                ChildOrder = 0,
                PositionXY = 1,
                PositionYX = 2,
            }

            class FocusRingRecord
            {
                /*0x10*/ int m_AutoIndex;
                /*0x18*/ UnityEngine.UIElements.Focusable m_Focusable;
                /*0x20*/ bool m_IsSlot;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder;

                /*0x189ebd4*/ FocusRingRecord();
            }
        }

        struct Spacing
        {
            /*0x10*/ float left;
            /*0x14*/ float top;
            /*0x18*/ float right;
            /*0x1c*/ float bottom;

            static /*0x189f69c*/ UnityEngine.Rect op_Subtraction(UnityEngine.Rect r, UnityEngine.UIElements.Spacing a);
            /*0x189f690*/ Spacing(float left, float top, float right, float bottom);
            /*0x189f670*/ float get_horizontal();
            /*0x189f680*/ float get_vertical();
        }

        class BindableElement : UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.IBindable
        {
            /*0x3b0*/ UnityEngine.UIElements.IBinding <binding>k__BackingField;
            /*0x3b8*/ string <bindingPath>k__BackingField;

            /*0x189b8d4*/ BindableElement();
            /*0x189f764*/ UnityEngine.UIElements.IBinding get_binding();
            /*0x189f76c*/ void set_bindingPath(string value);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.BindableElement.UxmlTraits>
            {
                /*0x189f774*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_PropertyPath;

                /*0x189bf90*/ UxmlTraits();
                /*0x189bdd4*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        enum GradientType
        {
            Linear = 0,
            Radial = 1,
        }

        enum AddressMode
        {
            Wrap = 0,
            Clamp = 1,
            Mirror = 2,
        }

        struct VectorImageVertex
        {
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Color32 tint;
            /*0x20*/ UnityEngine.Vector2 uv;
            /*0x28*/ uint settingIndex;
        }

        struct GradientSettings
        {
            /*0x10*/ UnityEngine.UIElements.GradientType gradientType;
            /*0x14*/ UnityEngine.UIElements.AddressMode addressMode;
            /*0x18*/ UnityEngine.Vector2 radialFocus;
            /*0x20*/ UnityEngine.RectInt location;
        }

        class VectorImage : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Texture2D atlas;
            /*0x20*/ UnityEngine.UIElements.VectorImageVertex[] vertices;
            /*0x28*/ ushort[] indices;
            /*0x30*/ UnityEngine.UIElements.GradientSettings[] settings;
            /*0x38*/ UnityEngine.Vector2 size;

            /*0x189f7bc*/ VectorImage();
        }

        class Clickable : UnityEngine.UIElements.PointerManipulator
        {
            /*0x30*/ System.Action<UnityEngine.UIElements.EventBase> clickedWithEventInfo;
            /*0x38*/ System.Action clicked;
            /*0x40*/ long m_Delay;
            /*0x48*/ long m_Interval;
            /*0x50*/ bool <active>k__BackingField;
            /*0x54*/ UnityEngine.Vector2 <lastMousePosition>k__BackingField;
            /*0x5c*/ int m_ActivePointerId;
            /*0x60*/ bool m_AcceptClicksIfDisabled;
            /*0x68*/ UnityEngine.UIElements.IVisualElementScheduledItem m_Repeater;

            static /*0x18a0ee0*/ bool IsNotMouseEvent(int pointerId);
            /*0x189f854*/ Clickable(System.Action handler, long delay, long interval);
            /*0x189f948*/ Clickable(System.Action<UnityEngine.UIElements.EventBase> handler);
            /*0x189f880*/ Clickable(System.Action handler);
            /*0x189f820*/ bool get_active();
            /*0x189f828*/ void set_active(bool value);
            /*0x189f834*/ UnityEngine.Vector2 get_lastMousePosition();
            /*0x189f83c*/ void set_lastMousePosition(UnityEngine.Vector2 value);
            /*0x189f844*/ bool get_acceptClicksIfDisabled();
            /*0x189f84c*/ UnityEngine.UIElements.InvokePolicy get_invokePolicy();
            /*0x189fa14*/ void OnTimer(UnityEngine.UIElements.TimerState timerState);
            /*0x189fac0*/ bool IsRepeatable();
            /*0x189fbc4*/ void RegisterCallbacksOnTarget();
            /*0x18a00e4*/ void UnregisterCallbacksFromTarget();
            /*0x18a05e0*/ void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt);
            /*0x18a0698*/ void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt);
            /*0x18a0704*/ void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x18a07c4*/ void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt);
            /*0x18a0848*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x18a0b60*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x18a0c78*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x18a0e58*/ void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x18a0f44*/ void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt);
            /*0x189fae4*/ bool ContainsPointer(int pointerId);
            /*0x189fb6c*/ void Invoke(UnityEngine.UIElements.EventBase evt);
            /*0x18a0fd8*/ void SimulateSingleClick(UnityEngine.UIElements.EventBase evt, int delayMs);
            /*0x18a11ac*/ void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, int pointerId);
            /*0x18a150c*/ void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition);
            /*0x18a1580*/ void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, int pointerId);
            /*0x18a170c*/ void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, int pointerId);
            /*0x18a1878*/ void <SimulateSingleClick>b__43_0();
        }

        struct Cursor : System.IEquatable<UnityEngine.UIElements.Cursor>
        {
            /*0x10*/ UnityEngine.Texture2D <texture>k__BackingField;
            /*0x18*/ UnityEngine.Vector2 <hotspot>k__BackingField;
            /*0x20*/ int <defaultCursorId>k__BackingField;

            static /*0x18a1af4*/ bool op_Equality(UnityEngine.UIElements.Cursor style1, UnityEngine.UIElements.Cursor style2);
            /*0x18a18ac*/ UnityEngine.Texture2D get_texture();
            /*0x18a18b4*/ void set_texture(UnityEngine.Texture2D value);
            /*0x18a18bc*/ UnityEngine.Vector2 get_hotspot();
            /*0x18a18c4*/ void set_hotspot(UnityEngine.Vector2 value);
            /*0x18a18cc*/ int get_defaultCursorId();
            /*0x18a18d4*/ void set_defaultCursorId(int value);
            /*0x18a18dc*/ bool Equals(object obj);
            /*0x18a196c*/ bool Equals(UnityEngine.UIElements.Cursor other);
            /*0x18a1a1c*/ int GetHashCode();
            /*0x18a1b24*/ string ToString();
        }

        interface ICursorManager
        {
            void SetCursor(UnityEngine.UIElements.Cursor cursor);
            void ResetCursor();
        }

        class CursorManager : UnityEngine.UIElements.ICursorManager
        {
            /*0x10*/ bool <isCursorOverriden>k__BackingField;

            /*0x18a1d18*/ CursorManager();
            /*0x18a1bac*/ bool get_isCursorOverriden();
            /*0x18a1bb4*/ void set_isCursorOverriden(bool value);
            /*0x18a1bc0*/ void SetCursor(UnityEngine.UIElements.Cursor cursor);
            /*0x18a1cb0*/ void ResetCursor();
        }

        interface ITextElement
        {
            string get_text();
        }

        class TextElement : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.ITextElement, UnityEngine.UIElements.INotifyValueChanged<string>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ int maxTextVertices;
            static /*0x10*/ string k_EllipsisText;
            /*0x3c0*/ UnityEngine.UIElements.ITextHandle m_TextHandle;
            /*0x3c8*/ string m_Text;
            /*0x3d0*/ bool m_EnableRichText;
            /*0x3d1*/ bool m_DisplayTooltipWhenElided;
            /*0x3d2*/ bool <isElided>k__BackingField;
            /*0x3d3*/ bool m_WasElided;
            /*0x3d4*/ bool m_UpdateTextParams;
            /*0x3d8*/ UnityEngine.UIElements.MeshGenerationContextUtils.TextParams m_TextParams;
            /*0x470*/ int m_PreviousTextParamsHashCode;

            static /*0x18a2f18*/ TextElement();
            /*0x18a1d20*/ TextElement();
            /*0x18a1ed8*/ UnityEngine.UIElements.ITextHandle get_textHandle();
            /*0x18a1ee0*/ void set_textHandle(UnityEngine.UIElements.ITextHandle value);
            /*0x18a1ee8*/ void HandleEvent(UnityEngine.UIElements.EventBase evt);
            /*0x18a2064*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e);
            /*0x18a21e4*/ string get_text();
            /*0x18a2278*/ void set_text(string value);
            /*0x18a2320*/ bool get_enableRichText();
            /*0x18a2328*/ void set_enableRichText(bool value);
            /*0x18a2348*/ bool get_displayTooltipWhenElided();
            /*0x18a2350*/ void set_displayTooltipWhenElided(bool value);
            /*0x18a238c*/ bool get_isElided();
            /*0x18a2394*/ void set_isElided(bool value);
            /*0x18a23a0*/ void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x18a2654*/ string ElideText(string drawText, string ellipsisText, float width, UnityEngine.UIElements.TextOverflowPosition textOverflowPosition);
            /*0x18a25e8*/ void UpdateTooltip();
            /*0x18a2068*/ void UpdateVisibleText();
            /*0x18a24c0*/ bool ShouldElide();
            /*0x18a2528*/ bool TextLibraryCanElide();
            /*0x18a2b20*/ UnityEngine.Vector2 MeasureTextSize(string textToMeasure, float width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x18a2b2c*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x18a2b8c*/ string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value();
            /*0x18a2be0*/ void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value);
            /*0x18a2eac*/ void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TextElement, UnityEngine.UIElements.TextElement.UxmlTraits>
            {
                /*0x18a2fd8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x80*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_EnableRichText;
                /*0x88*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;

                /*0x18a31ac*/ UxmlTraits();
                /*0x18a3020*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class StyleCache
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<long, UnityEngine.UIElements.ComputedStyle> s_ComputedStyleCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.UIElements.StyleVariableContext> s_StyleVariableContextCache;
            static /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.UIElements.ComputedTransitionProperty[]> s_ComputedTransitionsCache;

            static /*0x18a3660*/ StyleCache();
            static /*0x18a32cc*/ bool TryGetValue(long hash, ref UnityEngine.UIElements.ComputedStyle data);
            static /*0x18a335c*/ void SetValue(long hash, ref UnityEngine.UIElements.ComputedStyle data);
            static /*0x18a3420*/ bool TryGetValue(int hash, ref UnityEngine.UIElements.StyleVariableContext data);
            static /*0x18a34b0*/ void SetValue(int hash, UnityEngine.UIElements.StyleVariableContext data);
            static /*0x18a3540*/ bool TryGetValue(int hash, ref UnityEngine.UIElements.ComputedTransitionProperty[] data);
            static /*0x18a35d0*/ void SetValue(int hash, UnityEngine.UIElements.ComputedTransitionProperty[] data);
        }

        class VisualTreeStyleUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ApplyStyleUpdateList;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_TransitionPropertyUpdateList;
            /*0x30*/ bool m_IsApplyingStyles;
            /*0x34*/ uint m_Version;
            /*0x38*/ uint m_LastVersion;
            /*0x40*/ UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal;

            static /*0x18a4370*/ VisualTreeStyleUpdater();
            /*0x18a4094*/ VisualTreeStyleUpdater();
            /*0x18a3784*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x18a37dc*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x18a3924*/ void Update();
            /*0x18a3c30*/ void ApplyStyles();
        }

        class StyleMatchingContext
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_StyleSheetStack;
            /*0x18*/ UnityEngine.UIElements.StyleVariableContext variableContext;
            /*0x20*/ UnityEngine.UIElements.VisualElement currentElement;
            /*0x28*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult;

            /*0x18a4444*/ StyleMatchingContext(System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult);
            /*0x18a43fc*/ int get_styleSheetCount();
            /*0x18a4508*/ void AddStyleSheet(UnityEngine.UIElements.StyleSheet sheet);
            /*0x18a45f4*/ void RemoveStyleSheetRange(int index, int count);
            /*0x18a465c*/ UnityEngine.UIElements.StyleSheet GetStyleSheetAt(int index);
        }

        class VisualTreeStyleUpdaterTraversal : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
        {
            /*0x10*/ UnityEngine.UIElements.StyleVariableContext m_ProcessVarContext;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> m_TempMatchResults;
            /*0x30*/ float <currentPixelsPerPoint>k__BackingField;
            /*0x38*/ UnityEngine.UIElements.StyleMatchingContext m_StyleMatchingContext;
            /*0x40*/ UnityEngine.UIElements.StyleSheets.StylePropertyReader m_StylePropertyReader;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> m_AnimatedProperties;

            static /*0x18a4840*/ void OnProcessMatchResult(UnityEngine.UIElements.VisualElement current, UnityEngine.UIElements.StyleSheets.MatchResultInfo info);
            /*0x18a4168*/ VisualTreeStyleUpdaterTraversal();
            /*0x18a46b4*/ float get_currentPixelsPerPoint();
            /*0x18a46bc*/ void set_currentPixelsPerPoint(float value);
            /*0x18a408c*/ void PrepareTraversal(float pixelsPerPoint);
            /*0x18a38a4*/ void AddChangedElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x18a3d10*/ void Clear();
            /*0x18a46c4*/ void PropagateToChildren(UnityEngine.UIElements.VisualElement ve);
            /*0x18a4798*/ void PropagateToParents(UnityEngine.UIElements.VisualElement ve);
            /*0x18a4870*/ void TraverseRecursive(UnityEngine.UIElements.VisualElement element, int depth);
            /*0x18a56b0*/ void ProcessTransitions(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle oldStyle, ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x18a5794*/ void ForceUpdateTransitions(UnityEngine.UIElements.VisualElement element);
            /*0x18a3db4*/ void CancelAnimationsWithNoTransitionProperty(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x18a4e70*/ bool ShouldSkipElement(UnityEngine.UIElements.VisualElement element);
            /*0x18a4ef4*/ UnityEngine.UIElements.ComputedStyle ProcessMatchedRules(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors);
            /*0x18a5a28*/ void ProcessMatchedVariables(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> <>9__24_0;

                static /*0x18a5b24*/ <>c();
                /*0x18a5b88*/ <>c();
                /*0x18a5b90*/ int <ProcessMatchedRules>b__24_0(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b);
            }
        }

        class VisualElementExtensions
        {
            static /*0x18a5bd4*/ UnityEngine.Vector2 WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p);
            static /*0x18a5cc0*/ UnityEngine.Vector2 LocalToWorld(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p);
            static /*0x18a5dac*/ UnityEngine.Rect WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Rect r);
            static /*0x18a5e98*/ void AddManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator);
            static /*0x18a5f44*/ void RemoveManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator);
        }

        enum PseudoStates
        {
            Active = 1,
            Hover = 2,
            Checked = 8,
            Disabled = 32,
            Focus = 64,
            Root = 128,
        }

        enum VisualElementFlags
        {
            WorldTransformDirty = 1,
            WorldTransformInverseDirty = 2,
            WorldClipDirty = 4,
            BoundingBoxDirty = 8,
            WorldBoundingBoxDirty = 16,
            LayoutManual = 32,
            CompositeRoot = 64,
            RequireMeasureFunction = 128,
            EnableViewDataPersistence = 256,
            DisableClipping = 512,
            NeedsAttachToPanelEvent = 1024,
            HierarchyDisplayed = 2048,
            StyleInitialized = 4096,
            Init = 2079,
        }

        enum PickingMode
        {
            Position = 0,
            Ignore = 1,
        }

        class VisualElementListPool
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>> pool;

            static /*0x18a622c*/ VisualElementListPool();
            static /*0x18a5fec*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements);
            static /*0x18a6098*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(int initialCapacity);
            static /*0x18a6178*/ void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements);
        }

        class ObjectListPool<T>
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>> pool;

            static ObjectListPool();
            static System.Collections.Generic.List<T> Get();
            static void Release(System.Collections.Generic.List<T> elements);
        }

        class PointerManipulator : UnityEngine.UIElements.MouseManipulator
        {
            /*0x2c*/ int m_CurrentPointerId;

            /*0x189fa10*/ PointerManipulator();
            /*0x18a096c*/ bool CanStartManipulation(UnityEngine.UIElements.IPointerEvent e);
            /*0x18a0da4*/ bool CanStopManipulation(UnityEngine.UIElements.IPointerEvent e);
        }

        enum KeyboardNavigationOperation
        {
            None = 0,
            SelectAll = 1,
            Cancel = 2,
            Submit = 3,
            Previous = 4,
            Next = 5,
            PageUp = 6,
            PageDown = 7,
            Begin = 8,
            End = 9,
        }

        class KeyboardNavigationManipulator : UnityEngine.UIElements.Manipulator
        {
            /*0x18*/ System.Action<UnityEngine.UIElements.KeyboardNavigationOperation, UnityEngine.UIElements.EventBase> m_Action;

            static /*0x18a690c*/ UnityEngine.UIElements.KeyboardNavigationOperation <OnRuntimeKeyDown>g__GetOperation|5_0(ref UnityEngine.UIElements.KeyboardNavigationManipulator.<> );
            static /*0x18a69e8*/ UnityEngine.UIElements.KeyboardNavigationOperation <OnEditorKeyDown>g__GetOperation|6_0(ref UnityEngine.UIElements.KeyboardNavigationManipulator.<> );
            /*0x18a62bc*/ KeyboardNavigationManipulator(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation, UnityEngine.UIElements.EventBase> action);
            /*0x18a62e4*/ void RegisterCallbacksOnTarget();
            /*0x18a6538*/ void UnregisterCallbacksFromTarget();
            /*0x18a678c*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x18a68c0*/ void OnRuntimeKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x18a6874*/ void OnEditorKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x18a6adc*/ void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent evt);
            /*0x18a6b00*/ void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt);
            /*0x18a6b24*/ void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent evt);
            /*0x18a69c8*/ void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation operation, UnityEngine.UIElements.EventBase evt);

            struct <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UIElements.KeyDownEvent evt;
            }

            struct <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.UIElements.KeyDownEvent evt;
            }
        }

        interface IStylePropertyAnimationSystem
        {
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            void CancelAllAnimations();
            void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner);
            void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds);
            void Update();
        }

        class StylePropertyAnimationSystem : UnityEngine.UIElements.IStylePropertyAnimationSystem
        {
            /*0x10*/ long m_CurrentTimeMs;
            /*0x18*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFloat m_Floats;
            /*0x20*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesInt m_Ints;
            /*0x28*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesLength m_Lengths;
            /*0x30*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesColor m_Colors;
            /*0x38*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesBackground m_Backgrounds;
            /*0x40*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions;
            /*0x48*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFont m_Fonts;
            /*0x50*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows;
            /*0x58*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesScale m_Scale;
            /*0x60*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesRotate m_Rotate;
            /*0x68*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTranslate m_Translate;
            /*0x70*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin;
            /*0x78*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_AllValues;
            /*0x80*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_PropertyToValues;

            /*0x18a6b8c*/ StylePropertyAnimationSystem();
            T GetOrCreate<T>(ref T values);
            bool StartTransition<T>(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values);
            /*0x18a6c80*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a6d48*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a6e20*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a6ef8*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a7008*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a7100*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a71f0*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a72c8*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a73e0*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a74d0*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a75e8*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a7700*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x18a7818*/ void CancelAllAnimations();
            /*0x18a7968*/ void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner);
            /*0x18a7c1c*/ void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x18a7cac*/ void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x18a7d3c*/ void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds);
            void UpdateTracking<T>(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values);
            /*0x18a7e94*/ long CurrentTimeMs();
            /*0x18a7e9c*/ void Update();

            enum TransitionState
            {
                None = 0,
                Running = 1,
                Started = 2,
                Ended = 4,
                Canceled = 8,
            }

            struct AnimationDataSet<TTimingData, TStyleData>
            {
                /*0x0*/ UnityEngine.UIElements.VisualElement[] elements;
                /*0x0*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] properties;
                /*0x0*/ TTimingData[] timing;
                /*0x0*/ TStyleData[] style;
                /*0x0*/ int count;
                /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair, int> indices;

                static UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData> Create();
                int get_capacity();
                void set_capacity(int value);
                void LocalInit();
                bool IndexOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref int index);
                void Add(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TTimingData timingData, TStyleData styleData);
                void Remove(int cancelledIndex);
                void Replace(int index, TTimingData timingData, TStyleData styleData);
                void RemoveAll(UnityEngine.UIElements.VisualElement ve);
                void RemoveAll();
                void GetActivePropertiesForElement(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties);
            }

            struct ElementPropertyPair
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair> Comparer;
                /*0x10*/ UnityEngine.UIElements.VisualElement element;
                /*0x18*/ UnityEngine.UIElements.StyleSheets.StylePropertyId property;

                static /*0x18a7f7c*/ ElementPropertyPair();
                /*0x18a7f70*/ ElementPropertyPair(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId property);

                class EqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair>
                {
                    /*0x18a7ff4*/ EqualityComparer();
                    /*0x18a7ffc*/ bool Equals(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair x, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair y);
                    /*0x18a8014*/ int GetHashCode(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair obj);
                }
            }

            class Values
            {
                /*0x18a8048*/ Values();
                void CancelAllAnimations();
                void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve);
                void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
                void Update(long currentTimeMs);
                void UpdateValues();
                void UpdateComputedStyle();
                void UpdateComputedStyle(int i);
            }

            class Values<T> : UnityEngine.UIElements.StylePropertyAnimationSystem.Values
            {
                /*0x0*/ long m_CurrentTimeMs;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_CurrentFrameEventsState;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_NextFrameEventsState;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TimingData<T>, UnityEngine.UIElements.StylePropertyAnimationSystem.Values.StyleData<T>> running;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>, T> completed;

                Values();
                bool get_isEmpty();
                System.Func<T, T, bool> get_SameFunc();
                void SwapFrameStates();
                void QueueEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp);
                void ClearEventQueue(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp);
                void QueueTransitionRunEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex);
                void QueueTransitionStartEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex);
                void QueueTransitionEndEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex);
                void QueueTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex, long panelElapsedMs);
                void SendTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex, long panelElapsedMs);
                void CancelAllAnimations();
                void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve);
                void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
                float ComputeReversingShorteningFactor(int oldIndex);
                int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor);
                int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor);
                bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve, long currentTimeMs);
                void ForceComputedStyleEndValue(int runningIndex);
                void Update(long currentTimeMs);
                void ProcessEventQueue();
                void UpdateProgress(long currentTimeMs);

                class TransitionEventsFrameState<T>
                {
                    static /*0x0*/ UnityEngine.Pool.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> k_EventQueuePool;
                    /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair, UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta;
                    /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair, System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> elementPropertyQueuedEvents;
                    /*0x0*/ UnityEngine.UIElements.IPanel panel;
                    /*0x0*/ int m_ChangesCount;

                    static TransitionEventsFrameState();
                    static System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue();
                    TransitionEventsFrameState();
                    void RegisterChange();
                    void UnregisterChange();
                    bool StateChanged();
                    void Clear();

                    class <>c<T>
                    {
                        static /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> <>9;

                        static <>c();
                        <>c();
                        System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> <.cctor>b__11_0();
                    }
                }

                struct TimingData<T>
                {
                    /*0x0*/ long startTimeMs;
                    /*0x0*/ int durationMs;
                    /*0x0*/ System.Func<float, float> easingCurve;
                    /*0x0*/ float easedProgress;
                    /*0x0*/ float reversingShorteningFactor;
                    /*0x0*/ bool isStarted;
                    /*0x0*/ int delayMs;
                }

                struct StyleData<T>
                {
                    /*0x0*/ T startValue;
                    /*0x0*/ T endValue;
                    /*0x0*/ T reversingAdjustedStartValue;
                    /*0x0*/ T currentValue;
                }

                struct EmptyData<T>
                {
                    static /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T> Default;

                    static EmptyData();
                }
            }

            class ValuesFloat : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<float>
            {
                /*0x88*/ System.Func<float, float, bool> <SameFunc>k__BackingField;

                static /*0x18a8058*/ bool IsSame(float a, float b);
                static /*0x18a80e0*/ float Lerp(float a, float b, float t);
                /*0x18a82e4*/ ValuesFloat();
                /*0x18a8050*/ System.Func<float, float, bool> get_SameFunc();
                /*0x18a80f0*/ void UpdateValues();
                /*0x18a8170*/ void UpdateComputedStyle();
                /*0x18a823c*/ void UpdateComputedStyle(int i);
            }

            class ValuesInt : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<int>
            {
                /*0x88*/ System.Func<int, int, bool> <SameFunc>k__BackingField;

                static /*0x18a8384*/ bool IsSame(int a, int b);
                static /*0x18a8390*/ int Lerp(int a, int b, float t);
                /*0x18a8688*/ ValuesInt();
                /*0x18a837c*/ System.Func<int, int, bool> get_SameFunc();
                /*0x18a847c*/ void UpdateValues();
                /*0x18a8514*/ void UpdateComputedStyle();
                /*0x18a85e0*/ void UpdateComputedStyle(int i);
            }

            class ValuesLength : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Length>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, bool> <SameFunc>k__BackingField;

                static /*0x18a8728*/ bool IsSame(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b);
                static /*0x18a87c8*/ UnityEngine.UIElements.Length Lerp(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b, float t);
                /*0x18a8a34*/ ValuesLength();
                /*0x18a8720*/ System.Func<UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, bool> get_SameFunc();
                /*0x18a8804*/ void UpdateValues();
                /*0x18a88c0*/ void UpdateComputedStyle();
                /*0x18a898c*/ void UpdateComputedStyle(int i);
            }

            class ValuesColor : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.Color>
            {
                /*0x88*/ System.Func<UnityEngine.Color, UnityEngine.Color, bool> <SameFunc>k__BackingField;

                static /*0x18a8ad4*/ bool IsSame(UnityEngine.Color c, UnityEngine.Color d);
                static /*0x18a8c0c*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
                /*0x18a8e44*/ ValuesColor();
                /*0x18a8acc*/ System.Func<UnityEngine.Color, UnityEngine.Color, bool> get_SameFunc();
                /*0x18a8c44*/ void UpdateValues();
                /*0x18a8cc8*/ void UpdateComputedStyle();
                /*0x18a8d98*/ void UpdateComputedStyle(int i);
            }

            class ValuesDiscrete<T> : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T>
            {
                /*0x0*/ System.Func<T, T, bool> <SameFunc>k__BackingField;

                static bool IsSame(T a, T b);
                static T Lerp(T a, T b, float t);
                ValuesDiscrete();
                System.Func<T, T, bool> get_SameFunc();
                void UpdateValues();
            }

            class ValuesBackground : UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesDiscrete<UnityEngine.UIElements.Background>
            {
                /*0x18a9074*/ ValuesBackground();
                /*0x18a8edc*/ void UpdateComputedStyle();
                /*0x18a8fb8*/ void UpdateComputedStyle(int i);
            }

            class ValuesFontDefinition : UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesDiscrete<UnityEngine.UIElements.FontDefinition>
            {
                /*0x18a9230*/ ValuesFontDefinition();
                /*0x18a90bc*/ void UpdateComputedStyle();
                /*0x18a9188*/ void UpdateComputedStyle(int i);
            }

            class ValuesFont : UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesDiscrete<UnityEngine.Font>
            {
                /*0x18a93ec*/ ValuesFont();
                /*0x18a9278*/ void UpdateComputedStyle();
                /*0x18a9344*/ void UpdateComputedStyle(int i);
            }

            class ValuesTextShadow : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.TextShadow>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, bool> <SameFunc>k__BackingField;

                static /*0x18a943c*/ bool IsSame(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b);
                static /*0x18a9480*/ UnityEngine.UIElements.TextShadow Lerp(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, float t);
                /*0x18a9768*/ ValuesTextShadow();
                /*0x18a9434*/ System.Func<UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, bool> get_SameFunc();
                /*0x18a94d8*/ void UpdateValues();
                /*0x18a95a4*/ void UpdateComputedStyle();
                /*0x18a9694*/ void UpdateComputedStyle(int i);
            }

            class ValuesScale : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Scale>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, bool> <SameFunc>k__BackingField;

                static /*0x18a9808*/ bool IsSame(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b);
                static /*0x18a9984*/ UnityEngine.UIElements.Scale Lerp(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b, float t);
                /*0x18a9a90*/ ValuesScale();
                /*0x18a9800*/ System.Func<UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, bool> get_SameFunc();
                /*0x18a9810*/ void UpdateComputedStyle();
                /*0x18a98dc*/ void UpdateComputedStyle(int i);
                /*0x18a99f4*/ void UpdateValues();
            }

            class ValuesRotate : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Rotate>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, bool> <SameFunc>k__BackingField;

                static /*0x18a9b30*/ bool IsSame(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b);
                static /*0x18a9d2c*/ UnityEngine.UIElements.Rotate Lerp(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b, float t);
                /*0x18a9e88*/ ValuesRotate();
                /*0x18a9b28*/ System.Func<UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, bool> get_SameFunc();
                /*0x18a9b78*/ void UpdateComputedStyle();
                /*0x18a9c60*/ void UpdateComputedStyle(int i);
                /*0x18a9dac*/ void UpdateValues();
            }

            class ValuesTranslate : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Translate>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, bool> <SameFunc>k__BackingField;

                static /*0x18a9f28*/ bool IsSame(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b);
                static /*0x18aa124*/ UnityEngine.UIElements.Translate Lerp(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b, float t);
                /*0x18aa2d4*/ ValuesTranslate();
                /*0x18a9f20*/ System.Func<UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, bool> get_SameFunc();
                /*0x18a9f70*/ void UpdateComputedStyle();
                /*0x18aa058*/ void UpdateComputedStyle(int i);
                /*0x18aa1f8*/ void UpdateValues();
            }

            class ValuesTransformOrigin : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.TransformOrigin>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, bool> <SameFunc>k__BackingField;

                static /*0x18aa374*/ bool IsSame(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b);
                static /*0x18aa570*/ UnityEngine.UIElements.TransformOrigin Lerp(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b, float t);
                /*0x18aa720*/ ValuesTransformOrigin();
                /*0x18aa36c*/ System.Func<UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, bool> get_SameFunc();
                /*0x18aa3bc*/ void UpdateComputedStyle();
                /*0x18aa4a4*/ void UpdateComputedStyle(int i);
                /*0x18aa644*/ void UpdateValues();
            }
        }

        class ImmediateModeException : System.Exception
        {
            /*0x18aa7b8*/ ImmediateModeException(System.Exception inner);
        }

        interface IExperimentalFeatures
        {
            UnityEngine.UIElements.Experimental.ITransitionAnimations get_animation();
        }

        struct VisualElementStyleSheetSet : System.IEquatable<UnityEngine.UIElements.VisualElementStyleSheetSet>
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement m_Element;

            /*0x18aa838*/ VisualElementStyleSheetSet(UnityEngine.UIElements.VisualElement element);
            /*0x18aa840*/ void Add(UnityEngine.UIElements.StyleSheet styleSheet);
            /*0x18aaa10*/ bool Remove(UnityEngine.UIElements.StyleSheet styleSheet);
            /*0x18aab44*/ bool Equals(UnityEngine.UIElements.VisualElementStyleSheetSet other);
            /*0x18aab50*/ bool Equals(object obj);
            /*0x18aabcc*/ int GetHashCode();
        }

        interface IGroupManager
        {
            void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption);
            void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option);
            void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option);
        }

        class DefaultGroupManager : UnityEngine.UIElements.IGroupManager
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption> m_GroupOptions;
            /*0x18*/ UnityEngine.UIElements.IGroupBoxOption m_SelectedOption;

            /*0x18aaee0*/ DefaultGroupManager();
            /*0x18aabe4*/ void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption);
            /*0x18aadb4*/ void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option);
            /*0x18aae88*/ void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option);
        }

        enum ContextType
        {
            Player = 0,
            Editor = 1,
        }

        enum VersionChangeType
        {
            Bindings = 1,
            ViewData = 2,
            Hierarchy = 4,
            Layout = 8,
            StyleSheet = 16,
            Styles = 32,
            Overflow = 64,
            BorderRadius = 128,
            BorderWidth = 256,
            Transform = 512,
            Size = 1024,
            Repaint = 2048,
            Opacity = 4096,
            Color = 8192,
            RenderHints = 16384,
            TransitionProperty = 32768,
        }

        enum UsageHints
        {
            None = 0,
            DynamicTransform = 1,
            GroupTransform = 2,
            MaskContainer = 4,
            DynamicColor = 8,
        }

        enum RenderHints
        {
            None = 0,
            GroupTransform = 1,
            BoneTransform = 2,
            ClipWithScissors = 4,
            MaskContainer = 8,
            DynamicColor = 16,
            DirtyOffset = 5,
            DirtyGroupTransform = 32,
            DirtyBoneTransform = 64,
            DirtyClipWithScissors = 128,
            DirtyMaskContainer = 256,
            DirtyAll = 480,
        }

        struct PanelClearSettings
        {
            /*0x10*/ bool clearDepthStencil;
            /*0x11*/ bool clearColor;
            /*0x14*/ UnityEngine.Color color;
        }

        class RepaintData
        {
            /*0x10*/ UnityEngine.Matrix4x4 <currentOffset>k__BackingField;
            /*0x50*/ UnityEngine.Vector2 <mousePosition>k__BackingField;
            /*0x58*/ UnityEngine.Rect <currentWorldClip>k__BackingField;
            /*0x68*/ UnityEngine.Event <repaintEvent>k__BackingField;

            /*0x18aaf8c*/ RepaintData();
            /*0x18aaf5c*/ UnityEngine.Matrix4x4 get_currentOffset();
            /*0x18aaf70*/ UnityEngine.Rect get_currentWorldClip();
            /*0x18aaf7c*/ UnityEngine.Event get_repaintEvent();
            /*0x18aaf84*/ void set_repaintEvent(UnityEngine.Event value);
        }

        class HierarchyEvent : System.MulticastDelegate
        {
            /*0x18aafec*/ HierarchyEvent(object object, nint method);
            /*0x18ab11c*/ void Invoke(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType);
        }

        interface IPanel : System.IDisposable
        {
            UnityEngine.UIElements.VisualElement get_visualTree();
            UnityEngine.UIElements.EventDispatcher get_dispatcher();
            UnityEngine.UIElements.ContextType get_contextType();
            UnityEngine.UIElements.FocusController get_focusController();
            UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point);
        }

        class BaseVisualElementPanel : UnityEngine.UIElements.IPanel, System.IDisposable, UnityEngine.UIElements.IGroupBox
        {
            /*0x10*/ System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelDisposed;
            /*0x18*/ float m_Scale;
            /*0x20*/ UnityEngine.Yoga.YogaConfig yogaConfig;
            /*0x28*/ float m_PixelsPerPoint;
            /*0x2c*/ UnityEngine.UIElements.PanelClearSettings <clearSettings>k__BackingField;
            /*0x40*/ bool <duringLayoutPhase>k__BackingField;
            /*0x48*/ UnityEngine.UIElements.RepaintData <repaintData>k__BackingField;
            /*0x50*/ UnityEngine.UIElements.ICursorManager <cursorManager>k__BackingField;
            /*0x58*/ UnityEngine.UIElements.ContextualMenuManager <contextualMenuManager>k__BackingField;
            /*0x60*/ bool <disposed>k__BackingField;
            /*0x68*/ UnityEngine.UIElements.ElementUnderPointer m_TopElementUnderPointers;
            /*0x70*/ System.Action standardShaderChanged;
            /*0x78*/ System.Action standardWorldSpaceShaderChanged;
            /*0x80*/ System.Action atlasChanged;
            /*0x88*/ System.Action<UnityEngine.Material> updateMaterial;
            /*0x90*/ UnityEngine.UIElements.HierarchyEvent hierarchyChanged;
            /*0x98*/ System.Action<UnityEngine.UIElements.IPanel> beforeUpdate;

            /*0x18ab290*/ BaseVisualElementPanel();
            UnityEngine.EventInterests get_IMGUIEventInterests();
            void set_IMGUIEventInterests(UnityEngine.EventInterests value);
            UnityEngine.ScriptableObject get_ownerObject();
            void set_ownerObject(UnityEngine.ScriptableObject value);
            UnityEngine.UIElements.SavePersistentViewData get_saveViewData();
            UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary();
            int get_IMGUIContainersCount();
            void set_IMGUIContainersCount(int value);
            UnityEngine.UIElements.FocusController get_focusController();
            void set_focusController(UnityEngine.UIElements.FocusController value);
            UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer();
            /*0x18ab130*/ void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x18ab1e0*/ void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x18ab378*/ void Dispose();
            /*0x18ab3e8*/ void Dispose(bool disposing);
            void Repaint(UnityEngine.Event e);
            void ValidateLayout();
            void UpdateAnimations();
            void UpdateBindings();
            void ApplyStyles();
            /*0x18ab524*/ float get_scale();
            /*0x18ab52c*/ void set_scale(float value);
            /*0x18ab638*/ void set_pixelsPerPoint(float value);
            /*0x18a407c*/ float get_scaledPixelsPerPoint();
            /*0x18ab744*/ UnityEngine.UIElements.PanelClearSettings get_clearSettings();
            /*0x18ab758*/ void set_clearSettings(UnityEngine.UIElements.PanelClearSettings value);
            /*0x18ab76c*/ bool get_duringLayoutPhase();
            /*0x18ab774*/ void set_duringLayoutPhase(bool value);
            uint get_version();
            uint get_hierarchyVersion();
            void OnVersionChanged(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.VersionChangeType changeTypeFlag);
            /*0x18ab780*/ UnityEngine.UIElements.RepaintData get_repaintData();
            /*0x18ab788*/ void set_repaintData(UnityEngine.UIElements.RepaintData value);
            /*0x18ab790*/ UnityEngine.UIElements.ICursorManager get_cursorManager();
            /*0x18ab798*/ void set_cursorManager(UnityEngine.UIElements.ICursorManager value);
            /*0x18ab7a0*/ UnityEngine.UIElements.ContextualMenuManager get_contextualMenuManager();
            /*0x18ab7a8*/ void set_contextualMenuManager(UnityEngine.UIElements.ContextualMenuManager value);
            UnityEngine.UIElements.VisualElement get_visualTree();
            UnityEngine.UIElements.EventDispatcher get_dispatcher();
            void set_dispatcher(UnityEngine.UIElements.EventDispatcher value);
            /*0x18ab7b0*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode);
            UnityEngine.UIElements.IScheduler get_scheduler();
            UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem();
            void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value);
            UnityEngine.UIElements.ContextType get_contextType();
            void set_contextType(UnityEngine.UIElements.ContextType value);
            UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point);
            UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            /*0x18ab874*/ bool get_disposed();
            /*0x18ab87c*/ void set_disposed(bool value);
            UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x18a0fbc*/ UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(int pointerId);
            /*0x18ab888*/ UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(int pointerId, UnityEngine.Vector2 pointerPos, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x18ab9bc*/ void ClearCachedElementUnderPointer(int pointerId, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x18ab9e4*/ void CommitElementUnderPointers();
            UnityEngine.Shader get_standardShader();
            /*0x18aba40*/ UnityEngine.Shader get_standardWorldSpaceShader();
            /*0x18aba48*/ void add_standardShaderChanged(System.Action value);
            /*0x18abae4*/ void remove_standardShaderChanged(System.Action value);
            /*0x18abb80*/ void add_standardWorldSpaceShaderChanged(System.Action value);
            /*0x18abc1c*/ void remove_standardWorldSpaceShaderChanged(System.Action value);
            /*0x18abcb8*/ void add_atlasChanged(System.Action value);
            /*0x18abd54*/ void remove_atlasChanged(System.Action value);
            /*0x18abdf0*/ void InvokeAtlasChanged();
            UnityEngine.UIElements.AtlasBase get_atlas();
            void set_atlas(UnityEngine.UIElements.AtlasBase value);
            /*0x18abe0c*/ void InvokeUpdateMaterial(UnityEngine.Material mat);
            /*0x18abe28*/ void add_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value);
            /*0x18abec4*/ void remove_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value);
            /*0x18abf60*/ void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType);
            /*0x18abf7c*/ void InvokeBeforeUpdate();
            /*0x189cc88*/ void UpdateElementUnderPointers();
            /*0x18abf9c*/ void Update();
        }

        class LoadResourceFunction : System.MulticastDelegate
        {
            /*0x18ac090*/ LoadResourceFunction(object object, nint method);
            /*0x18ac168*/ UnityEngine.Object Invoke(string pathName, System.Type type, float dpiScaling);
        }

        class TimeMsFunction : System.MulticastDelegate
        {
            /*0x18ac17c*/ TimeMsFunction(object object, nint method);
            /*0x18ac238*/ long Invoke();
        }

        class GetViewDataDictionary : System.MulticastDelegate
        {
            /*0x18ac24c*/ GetViewDataDictionary(object object, nint method);
            /*0x18ac308*/ UnityEngine.UIElements.ISerializableJsonDictionary Invoke();
        }

        class SavePersistentViewData : System.MulticastDelegate
        {
            /*0x18ac31c*/ SavePersistentViewData(object object, nint method);
            /*0x18ac3d8*/ void Invoke();
        }

        class Panel : UnityEngine.UIElements.BaseVisualElementPanel
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerPickAll;
            static /*0x8*/ UnityEngine.UIElements.LoadResourceFunction <loadResourceFunc>k__BackingField;
            static /*0x10*/ UnityEngine.UIElements.TimeMsFunction <TimeSinceStartup>k__BackingField;
            static /*0x18*/ System.Action<UnityEngine.UIElements.Panel> beforeAnyRepaint;
            /*0xa0*/ UnityEngine.UIElements.VisualElement m_RootContainer;
            /*0xa8*/ UnityEngine.UIElements.VisualTreeUpdater m_VisualTreeUpdater;
            /*0xb0*/ UnityEngine.UIElements.IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;
            /*0xb8*/ string m_PanelName;
            /*0xc0*/ uint m_Version;
            /*0xc4*/ uint m_RepaintVersion;
            /*0xc8*/ uint m_HierarchyVersion;
            /*0xd0*/ Unity.Profiling.ProfilerMarker m_MarkerBeforeUpdate;
            /*0xd8*/ Unity.Profiling.ProfilerMarker m_MarkerUpdate;
            /*0xe0*/ Unity.Profiling.ProfilerMarker m_MarkerLayout;
            /*0xe8*/ Unity.Profiling.ProfilerMarker m_MarkerBindings;
            /*0xf0*/ Unity.Profiling.ProfilerMarker m_MarkerAnimations;
            /*0xf8*/ UnityEngine.UIElements.EventDispatcher <dispatcher>k__BackingField;
            /*0x100*/ UnityEngine.UIElements.TimerEventScheduler m_Scheduler;
            /*0x108*/ UnityEngine.ScriptableObject <ownerObject>k__BackingField;
            /*0x110*/ UnityEngine.UIElements.ContextType <contextType>k__BackingField;
            /*0x118*/ UnityEngine.UIElements.SavePersistentViewData <saveViewData>k__BackingField;
            /*0x120*/ UnityEngine.UIElements.GetViewDataDictionary <getViewDataDictionary>k__BackingField;
            /*0x128*/ UnityEngine.UIElements.FocusController <focusController>k__BackingField;
            /*0x130*/ UnityEngine.EventInterests <IMGUIEventInterests>k__BackingField;
            /*0x134*/ int <IMGUIContainersCount>k__BackingField;
            /*0x138*/ UnityEngine.UIElements.IMGUIContainer <rootIMGUIContainer>k__BackingField;
            /*0x140*/ UnityEngine.Shader m_StandardShader;
            /*0x148*/ UnityEngine.UIElements.AtlasBase m_Atlas;
            /*0x150*/ bool m_ValidatingLayout;

            static /*0x18ad8ec*/ Panel();
            static /*0x18ac590*/ UnityEngine.UIElements.LoadResourceFunction get_loadResourceFunc();
            static /*0x18ac5e8*/ UnityEngine.Object LoadResource(string pathName, System.Type type, float dpiScaling);
            static /*0x18ac970*/ UnityEngine.UIElements.TimeMsFunction get_TimeSinceStartup();
            static /*0x189a0b0*/ long TimeSinceStartupMs();
            static /*0x18ace68*/ long DefaultTimeSinceStartupMs();
            static /*0x18acea0*/ UnityEngine.UIElements.VisualElement PickAll(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            static /*0x18acf1c*/ UnityEngine.UIElements.VisualElement PerformPick(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            static /*0x18ad44c*/ UnityEngine.Vector2Int <Pick>g__PixelOf|99_0(UnityEngine.Vector2 p);
            /*0x18aca74*/ Panel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.EventDispatcher dispatcher);
            /*0x18ac3ec*/ UnityEngine.UIElements.VisualElement get_visualTree();
            /*0x18ac3f4*/ UnityEngine.UIElements.EventDispatcher get_dispatcher();
            /*0x18ac3fc*/ void set_dispatcher(UnityEngine.UIElements.EventDispatcher value);
            /*0x18ac404*/ UnityEngine.UIElements.TimerEventScheduler get_timerEventScheduler();
            /*0x18ac470*/ UnityEngine.UIElements.IScheduler get_scheduler();
            /*0x18ac474*/ UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem();
            /*0x18ac47c*/ void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value);
            /*0x18ac530*/ UnityEngine.ScriptableObject get_ownerObject();
            /*0x18ac538*/ void set_ownerObject(UnityEngine.ScriptableObject value);
            /*0x18ac540*/ UnityEngine.UIElements.ContextType get_contextType();
            /*0x18ac548*/ void set_contextType(UnityEngine.UIElements.ContextType value);
            /*0x18ac550*/ UnityEngine.UIElements.SavePersistentViewData get_saveViewData();
            /*0x18ac558*/ UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary();
            /*0x18ac560*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x18ac568*/ void set_focusController(UnityEngine.UIElements.FocusController value);
            /*0x18ac570*/ UnityEngine.EventInterests get_IMGUIEventInterests();
            /*0x18ac580*/ void set_IMGUIEventInterests(UnityEngine.EventInterests value);
            /*0x1897cfc*/ void Focus();
            /*0x1897cd0*/ void Blur();
            /*0x18ac714*/ string get_name();
            /*0x18ac71c*/ void set_name(string value);
            /*0x18ac724*/ void CreateMarkers();
            /*0x18ac9c8*/ int get_IMGUIContainersCount();
            /*0x18ac9d0*/ void set_IMGUIContainersCount(int value);
            /*0x18ac9d8*/ UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer();
            /*0x18ac9e0*/ uint get_version();
            /*0x18ac9e8*/ uint get_hierarchyVersion();
            /*0x18ac9f0*/ UnityEngine.Shader get_standardShader();
            /*0x18ac9f8*/ UnityEngine.UIElements.AtlasBase get_atlas();
            /*0x18aca00*/ void set_atlas(UnityEngine.UIElements.AtlasBase value);
            /*0x18ace00*/ void Dispose(bool disposing);
            /*0x18ad200*/ UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            /*0x18ad2d8*/ UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point);
            /*0x18ad544*/ void ValidateLayout();
            /*0x18ad5a8*/ void UpdateAnimations();
            /*0x18ad5c8*/ void UpdateBindings();
            /*0x18ad5e8*/ void ApplyStyles();
            /*0x18ad608*/ void UpdateForRepaint();
            /*0x18ad67c*/ void Repaint(UnityEngine.Event e);
            /*0x18ad884*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x18ad8d0*/ UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
        }

        class BaseRuntimePanel : UnityEngine.UIElements.Panel
        {
            static /*0x0*/ int s_CurrentRuntimePanelCounter;
            static /*0x8*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> DefaultScreenToPanelSpace;
            /*0x158*/ UnityEngine.GameObject m_SelectableGameObject;
            /*0x160*/ int m_RuntimePanelCreationIndex;
            /*0x164*/ float m_SortingPriority;
            /*0x168*/ System.Action destroyed;
            /*0x170*/ UnityEngine.Shader m_StandardWorldSpaceShader;
            /*0x178*/ bool m_DrawToCameras;
            /*0x180*/ UnityEngine.RenderTexture targetTexture;
            /*0x188*/ UnityEngine.Matrix4x4 panelToWorld;
            /*0x1c8*/ int <targetDisplay>k__BackingField;
            /*0x1d0*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> m_ScreenToPanelSpace;

            static /*0x174284c*/ BaseRuntimePanel();
            /*0x1741f5c*/ BaseRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.EventDispatcher dispatcher);
            /*0x17418f0*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x17418f8*/ void set_selectableGameObject(UnityEngine.GameObject value);
            /*0x1741cc0*/ float get_sortingPriority();
            /*0x1741cc8*/ void set_sortingPriority(float value);
            /*0x1741e1c*/ void add_destroyed(System.Action value);
            /*0x1741ebc*/ void remove_destroyed(System.Action value);
            /*0x174206c*/ void Dispose(bool disposing);
            /*0x17420c4*/ UnityEngine.Shader get_standardWorldSpaceShader();
            /*0x17420cc*/ bool get_drawToCameras();
            /*0x17420d4*/ void set_drawToCameras(bool value);
            /*0x1742184*/ int get_targetDisplay();
            /*0x174218c*/ void set_targetDisplay(int value);
            /*0x1742194*/ int get_screenRenderingWidth();
            /*0x1742260*/ int get_screenRenderingHeight();
            /*0x174232c*/ void Repaint(UnityEngine.Event e);
            /*0x1742514*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> get_screenToPanelSpace();
            /*0x174251c*/ void set_screenToPanelSpace(System.Func<UnityEngine.Vector2, UnityEngine.Vector2> value);
            /*0x1742594*/ UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2 screen);
            /*0x17425e8*/ bool ScreenToPanel(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenDelta, ref UnityEngine.Vector2 panelPosition, ref UnityEngine.Vector2 panelDelta, bool allowOutside);
            /*0x1741994*/ void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x17426ec*/ void PointerLeavesPanel(int pointerId, UnityEngine.Vector2 position);
            /*0x17427ac*/ void PointerEntersPanel(int pointerId, UnityEngine.Vector2 position);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.BaseRuntimePanel.<> <>9;

                static /*0x1742924*/ <>c();
                /*0x1742988*/ <>c();
                /*0x1742990*/ UnityEngine.Vector2 <.cctor>b__44_0(UnityEngine.Vector2 p);
            }
        }

        interface IRuntimePanelComponent
        {
            void set_panel(UnityEngine.UIElements.IPanel value);
        }

        class DisposeHelper
        {
            static /*0x1742994*/ void NotifyDisposedUsed(System.IDisposable disposable);
        }

        class Focusable : UnityEngine.UIElements.CallbackEventHandler
        {
            /*0x18*/ bool <focusable>k__BackingField;
            /*0x1c*/ int <tabIndex>k__BackingField;
            /*0x20*/ bool m_DelegatesFocus;
            /*0x21*/ bool m_ExcludeFromFocusRing;
            /*0x22*/ bool isIMGUIContainer;

            static /*0x1742f48*/ UnityEngine.UIElements.Focusable GetFirstFocusableChild(UnityEngine.UIElements.VisualElement ve);
            /*0x1742a5c*/ Focusable();
            UnityEngine.UIElements.FocusController get_focusController();
            /*0x1742a84*/ bool get_focusable();
            /*0x1742a8c*/ void set_focusable(bool value);
            /*0x1742a98*/ int get_tabIndex();
            /*0x1742aa0*/ void set_tabIndex(int value);
            /*0x1742aa8*/ bool get_delegatesFocus();
            /*0x1742ab0*/ void set_delegatesFocus(bool value);
            /*0x1742b94*/ bool get_excludeFromFocusRing();
            /*0x1742b9c*/ void set_excludeFromFocusRing(bool value);
            /*0x1742c80*/ bool get_canGrabFocus();
            /*0x1742c88*/ void Focus();
            /*0x1742e80*/ void Blur();
            /*0x1742f10*/ void BlurImmediately();
            /*0x1742d38*/ UnityEngine.UIElements.Focusable GetFocusDelegate();
            /*0x1743068*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x17430f4*/ void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt);
            /*0x1743094*/ void ProcessEvent(UnityEngine.UIElements.EventBase evt);
        }

        class FocusChangeDirection : System.IDisposable
        {
            static /*0x0*/ UnityEngine.UIElements.FocusChangeDirection <unspecified>k__BackingField;
            static /*0x8*/ UnityEngine.UIElements.FocusChangeDirection <none>k__BackingField;
            static /*0x10*/ UnityEngine.UIElements.FocusChangeDirection <lastValue>k__BackingField;
            /*0x10*/ int m_Value;

            static /*0x1743814*/ FocusChangeDirection();
            static /*0x174340c*/ UnityEngine.UIElements.FocusChangeDirection get_unspecified();
            static /*0x1743464*/ UnityEngine.UIElements.FocusChangeDirection get_none();
            static /*0x17434bc*/ UnityEngine.UIElements.FocusChangeDirection get_lastValue();
            static /*0x174353c*/ int op_Implicit(UnityEngine.UIElements.FocusChangeDirection fcd);
            /*0x1743514*/ FocusChangeDirection(int value);
            /*0x1743548*/ void System.IDisposable.Dispose();
            /*0x1743554*/ void Dispose();
            /*0x1743558*/ void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f);
        }

        interface IFocusRing
        {
            UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e);
            UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction);
        }

        class FocusController
        {
            /*0x10*/ UnityEngine.UIElements.IFocusRing <focusRing>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.FocusController.FocusedElement> m_FocusedElements;
            /*0x20*/ UnityEngine.UIElements.Focusable m_LastFocusedElement;
            /*0x28*/ UnityEngine.UIElements.Focusable m_LastPendingFocusedElement;
            /*0x30*/ int m_PendingFocusCount;
            /*0x34*/ int <imguiKeyboardControl>k__BackingField;

            /*0x17438e4*/ FocusController(UnityEngine.UIElements.IFocusRing focusRing);
            /*0x174397c*/ UnityEngine.UIElements.IFocusRing get_focusRing();
            /*0x1743984*/ UnityEngine.UIElements.Focusable get_focusedElement();
            /*0x1743c08*/ bool IsFocused(UnityEngine.UIElements.Focusable f);
            /*0x17439c8*/ UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement retargetAgainst);
            /*0x1743d7c*/ UnityEngine.UIElements.Focusable GetLeafFocusedElement();
            /*0x1743bcc*/ bool IsLocalElement(UnityEngine.UIElements.Focusable f);
            /*0x1743e20*/ bool IsPendingFocus(UnityEngine.UIElements.Focusable f);
            /*0x1743ed0*/ void SetFocusToLastFocusedElement();
            /*0x1743f58*/ void BlurLastFocusedElement();
            /*0x1743fe0*/ void DoFocusChange(UnityEngine.UIElements.Focusable f);
            /*0x1744170*/ UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection direction);
            /*0x174425c*/ void AboutToReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x1744420*/ void ReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x17445e4*/ void AboutToGrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x17447a8*/ void GrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x1742eb8*/ void Blur(UnityEngine.UIElements.Focusable focusable, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x1742dc8*/ void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x1743580*/ void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, UnityEngine.UIElements.FocusChangeDirection direction, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x1743120*/ UnityEngine.UIElements.Focusable SwitchFocusOnEvent(UnityEngine.UIElements.EventBase e);
            /*0x1744978*/ void ReevaluateFocus();
            /*0x1744a38*/ bool GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable target, ref UnityEngine.UIElements.Focusable effectiveTarget);
            /*0x1744b3c*/ int get_imguiKeyboardControl();
            /*0x1744b44*/ void set_imguiKeyboardControl(int value);
            /*0x1744b4c*/ void SyncIMGUIFocus(int imguiKeyboardControlID, UnityEngine.UIElements.Focusable imguiContainerHavingKeyboardControl, bool forceSwitch);

            struct FocusedElement
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement m_SubTreeRoot;
                /*0x18*/ UnityEngine.UIElements.Focusable m_FocusedElement;
            }
        }

        enum SelectionType
        {
            None = 0,
            Single = 1,
            Multiple = 2,
        }

        enum Position
        {
            Relative = 0,
            Absolute = 1,
        }

        enum OverflowInternal
        {
            Visible = 0,
            Hidden = 1,
            Scroll = 2,
        }

        enum OverflowClipBox
        {
            PaddingBox = 0,
            ContentBox = 1,
        }

        enum FlexDirection
        {
            Column = 0,
            ColumnReverse = 1,
            Row = 2,
            RowReverse = 3,
        }

        enum Wrap
        {
            NoWrap = 0,
            Wrap = 1,
            WrapReverse = 2,
        }

        enum Align
        {
            Auto = 0,
            FlexStart = 1,
            Center = 2,
            FlexEnd = 3,
            Stretch = 4,
        }

        enum Justify
        {
            FlexStart = 0,
            Center = 1,
            FlexEnd = 2,
            SpaceBetween = 3,
            SpaceAround = 4,
        }

        enum TextOverflowPosition
        {
            End = 0,
            Start = 1,
            Middle = 2,
        }

        enum TextOverflow
        {
            Clip = 0,
            Ellipsis = 1,
        }

        enum TransformOriginOffset
        {
            Left = 1,
            Right = 2,
            Top = 3,
            Bottom = 4,
            Center = 5,
        }

        enum Visibility
        {
            Visible = 0,
            Hidden = 1,
        }

        enum WhiteSpace
        {
            Normal = 0,
            NoWrap = 1,
        }

        enum DisplayStyle
        {
            Flex = 0,
            None = 1,
        }

        interface IUIElementsUtility
        {
            bool TakeCapture();
            bool ReleaseCapture();
            bool ProcessEvent(int instanceID, nint nativeEventPtr, ref bool eventHandled);
            bool CleanupRoots();
            bool EndContainerGUIFromException(System.Exception exception);
            bool MakeCurrentIMGUIContainerDirty();
        }

        class UIEventRegistration
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility> s_Utilities;

            static /*0x1744c18*/ UIEventRegistration();
            static /*0x17450c4*/ void RegisterUIElementSystem(UnityEngine.UIElements.IUIElementsUtility utility);
            static /*0x1745148*/ void TakeCapture();
            static /*0x1745320*/ void ReleaseCapture();
            static /*0x17454fc*/ bool EndContainerGUIFromException(System.Exception exception);
            static /*0x1745714*/ bool ProcessEvent(int instanceID, nint nativeEventPtr);
            static /*0x1745938*/ void CleanupRoots();
            static /*0x1745b14*/ void MakeCurrentIMGUIContainerDirty();

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UIEventRegistration.<> <>9;

                static /*0x1745cf0*/ <>c();
                /*0x1745d54*/ <>c();
                /*0x1745d5c*/ void <.cctor>b__1_0();
                /*0x1745da8*/ void <.cctor>b__1_1();
                /*0x1745df4*/ bool <.cctor>b__1_2(int i, nint ptr);
                /*0x1745e58*/ void <.cctor>b__1_3();
                /*0x1745ea4*/ bool <.cctor>b__1_4(System.Exception exception);
                /*0x1745ef8*/ void <.cctor>b__1_5();
            }
        }

        class UIElementsUtility : UnityEngine.UIElements.IUIElementsUtility
        {
            static /*0x0*/ System.Collections.Generic.Stack<UnityEngine.UIElements.IMGUIContainer> s_ContainerStack;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.UIElements.Panel> s_UIElementsCache;
            static /*0x10*/ UnityEngine.Event s_EventInstance;
            static /*0x18*/ UnityEngine.Color editorPlayModeTintColor;
            static /*0x28*/ float singleLineHeight;
            static /*0x30*/ UnityEngine.UIElements.UIElementsUtility s_Instance;
            static /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_PanelsIterationList;
            static /*0x40*/ string s_RepaintProfilerMarkerName;
            static /*0x48*/ string s_EventProfilerMarkerName;
            static /*0x50*/ Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker;
            static /*0x58*/ Unity.Profiling.ProfilerMarker s_EventProfilerMarker;

            static /*0x1747640*/ UIElementsUtility();
            static /*0x1746a54*/ void RegisterCachedPanel(int instanceID, UnityEngine.UIElements.Panel panel);
            static /*0x1746ae4*/ void RemoveCachedPanel(int instanceID);
            static /*0x1746b64*/ bool TryGetPanel(int instanceID, ref UnityEngine.UIElements.Panel panel);
            static /*0x1746bf4*/ void BeginContainerGUI(UnityEngine.GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, UnityEngine.UIElements.IMGUIContainer container);
            static /*0x1746e64*/ void EndContainerGUI(UnityEngine.Event evt, UnityEngine.Rect layoutSize);
            static /*0x1747088*/ UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent);
            static /*0x17470fc*/ UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType);
            static /*0x1746424*/ bool DoDispatch(UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x1747398*/ void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, UnityEngine.UIElements.ContextType contextType);
            static /*0x17474f0*/ System.Collections.Generic.Dictionary.Enumerator<int, UnityEngine.UIElements.Panel> GetPanelsIterator();
            static /*0x1747598*/ float PixelsPerUnitScaleForElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.Sprite sprite);
            /*0x1745f44*/ UIElementsUtility();
            /*0x1745fa4*/ bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty();
            /*0x1746090*/ bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture();
            /*0x17462dc*/ bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture();
            /*0x17462e4*/ bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, nint nativeEventPtr, ref bool eventHandled);
            /*0x1746934*/ bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots();
            /*0x1746994*/ bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(System.Exception exception);
        }

        class VisualTreeViewDataUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList;
            /*0x30*/ uint m_Version;
            /*0x34*/ uint m_LastVersion;

            static /*0x1747d14*/ VisualTreeViewDataUpdater();
            /*0x1747c74*/ VisualTreeViewDataUpdater();
            /*0x1747850*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x17478a8*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x17479e0*/ void Update();
            /*0x1747b24*/ void ValidateViewDataOnSubTree(UnityEngine.UIElements.VisualElement ve, bool enablePersistence);
            /*0x1747938*/ void PropagateToParents(UnityEngine.UIElements.VisualElement ve);
        }

        interface IManipulator
        {
            void set_target(UnityEngine.UIElements.VisualElement value);
        }

        class Manipulator : UnityEngine.UIElements.IManipulator
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement m_Target;

            /*0x1747dfc*/ Manipulator();
            void RegisterCallbacksOnTarget();
            void UnregisterCallbacksFromTarget();
            /*0x1747da0*/ UnityEngine.UIElements.VisualElement get_target();
            /*0x1747da8*/ void set_target(UnityEngine.UIElements.VisualElement value);
        }

        class IMGUIContainer : UnityEngine.UIElements.VisualElement, System.IDisposable
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string ussFoldoutChildDepthClassName;
            static /*0x10*/ System.Collections.Generic.List<string> ussFoldoutChildDepthClassNames;
            static /*0x18*/ Unity.Profiling.ProfilerMarker k_OnGUIMarker;
            static /*0x20*/ Unity.Profiling.ProfilerMarker k_ImmediateCallbackMarker;
            static /*0x28*/ UnityEngine.Event s_DefaultMeasureEvent;
            static /*0x30*/ UnityEngine.Event s_MeasureEvent;
            static /*0x38*/ UnityEngine.Event s_CurrentEvent;
            /*0x3b0*/ System.Action m_OnGUIHandler;
            /*0x3b8*/ UnityEngine.ObjectGUIState m_ObjectGUIState;
            /*0x3c0*/ bool useOwnerObjectGUIState;
            /*0x3c4*/ UnityEngine.Rect <lastWorldClip>k__BackingField;
            /*0x3d4*/ bool m_CullingEnabled;
            /*0x3d5*/ bool m_IsFocusDelegated;
            /*0x3d6*/ bool m_RefreshCachedLayout;
            /*0x3d8*/ UnityEngine.GUILayoutUtility.LayoutCache m_Cache;
            /*0x3e0*/ UnityEngine.Rect m_CachedClippingRect;
            /*0x3f0*/ UnityEngine.Matrix4x4 m_CachedTransform;
            /*0x430*/ UnityEngine.UIElements.ContextType <contextType>k__BackingField;
            /*0x434*/ bool lostFocus;
            /*0x435*/ bool receivedFocus;
            /*0x438*/ UnityEngine.UIElements.FocusChangeDirection focusChangeDirection;
            /*0x440*/ bool hasFocusableControls;
            /*0x444*/ int newKeyboardFocusControlID;
            /*0x448*/ bool <focusOnlyIfHasFocusableControls>k__BackingField;
            /*0x44c*/ UnityEngine.UIElements.IMGUIContainer.GUIGlobals m_GUIGlobals;

            static /*0x1747f8c*/ IMGUIContainer();
            static /*0x174a46c*/ bool IsDockAreaMouseUp(UnityEngine.UIElements.EventBase evt);
            static /*0x174a6c8*/ void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer container, UnityEngine.Event evt, ref UnityEngine.Matrix4x4 transform, ref UnityEngine.Rect clipRect);
            /*0x1748358*/ IMGUIContainer();
            /*0x1748360*/ IMGUIContainer(System.Action onGUIHandler);
            /*0x1747e04*/ System.Action get_onGUIHandler();
            /*0x1747e0c*/ void set_onGUIHandler(System.Action value);
            /*0x1746dc0*/ UnityEngine.ObjectGUIState get_guiState();
            /*0x1747e64*/ UnityEngine.Rect get_lastWorldClip();
            /*0x1747e78*/ void set_lastWorldClip(UnityEngine.Rect value);
            /*0x1747e8c*/ bool get_cullingEnabled();
            /*0x1747e94*/ UnityEngine.GUILayoutUtility.LayoutCache get_cache();
            /*0x1747f04*/ float get_layoutMeasuredWidth();
            /*0x1747f2c*/ float get_layoutMeasuredHeight();
            /*0x1747f54*/ UnityEngine.UIElements.ContextType get_contextType();
            /*0x1747f5c*/ void set_contextType(UnityEngine.UIElements.ContextType value);
            /*0x1747f64*/ bool get_focusOnlyIfHasFocusableControls();
            /*0x1747f6c*/ bool get_canGrabFocus();
            /*0x1748598*/ void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x17486c4*/ void SaveGlobals();
            /*0x17487d4*/ void RestoreGlobals();
            /*0x17488ec*/ void DoOnGUI(UnityEngine.Event evt, UnityEngine.Matrix4x4 parentTransform, UnityEngine.Rect clippingRect, bool isComputingLayout, UnityEngine.Rect layoutSize, System.Action onGUIHandler, bool canAffectFocus);
            /*0x174607c*/ void MarkDirtyLayout();
            /*0x1749540*/ void HandleEvent(UnityEngine.UIElements.EventBase evt);
            /*0x174986c*/ void DoIMGUIRepaint();
            /*0x17495d0*/ bool SendEventToIMGUI(UnityEngine.UIElements.EventBase evt, bool canAffectFocus, bool verifyBounds);
            /*0x1749e34*/ bool SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase evt, bool canAffectFocus, bool verifyBounds);
            /*0x1749f34*/ bool VerifyBounds(UnityEngine.UIElements.EventBase evt);
            /*0x1749fd4*/ bool IsContainerCapturingTheMouse();
            /*0x174a0e8*/ bool IsLocalEvent(UnityEngine.UIElements.EventBase evt);
            /*0x174a2ec*/ bool IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase evt);
            /*0x1749fc4*/ bool HandleIMGUIEvent(UnityEngine.Event e, bool canAffectFocus);
            /*0x174a5fc*/ bool HandleIMGUIEvent(UnityEngine.Event e, System.Action onGUIHandler, bool canAffectFocus);
            /*0x1749b3c*/ bool HandleIMGUIEvent(UnityEngine.Event e, UnityEngine.Matrix4x4 worldTransform, UnityEngine.Rect clippingRect, System.Action onGUIHandler, bool canAffectFocus);
            /*0x174a88c*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x174ab74*/ void SetFoldoutDepthClass();
            /*0x174adc0*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x174a590*/ UnityEngine.Rect GetCurrentClipRect();
            /*0x174b018*/ void Dispose();
            /*0x174b088*/ void Dispose(bool disposeManaged);
            /*0x174b0a0*/ void <DoOnGUI>b__56_0();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.IMGUIContainer, UnityEngine.UIElements.IMGUIContainer.UxmlTraits>
            {
                /*0x174b0ac*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x174b0f4*/ UxmlTraits();
            }

            struct GUIGlobals
            {
                /*0x10*/ UnityEngine.Matrix4x4 matrix;
                /*0x50*/ UnityEngine.Color color;
                /*0x60*/ UnityEngine.Color contentColor;
                /*0x70*/ UnityEngine.Color backgroundColor;
                /*0x80*/ bool enabled;
                /*0x81*/ bool changed;
                /*0x84*/ int displayIndex;
            }
        }

        class MouseCaptureController
        {
            static /*0x174a7dc*/ bool HasMouseCapture(UnityEngine.UIElements.IEventHandler handler);
            static /*0x17461fc*/ void CaptureMouse(UnityEngine.UIElements.IEventHandler handler);
            static /*0x174b164*/ void ReleaseMouse(UnityEngine.UIElements.IEventHandler handler);
        }

        enum DispatchMode
        {
            Default = 1,
            Queued = 1,
            Immediate = 2,
        }

        struct EventDispatcherGate : System.IDisposable, System.IEquatable<UnityEngine.UIElements.EventDispatcherGate>
        {
            /*0x10*/ UnityEngine.UIElements.EventDispatcher m_Dispatcher;

            /*0x174b244*/ EventDispatcherGate(UnityEngine.UIElements.EventDispatcher d);
            /*0x174b2c0*/ void Dispose();
            /*0x174b360*/ bool Equals(UnityEngine.UIElements.EventDispatcherGate other);
            /*0x174b36c*/ bool Equals(object obj);
            /*0x174b3e8*/ int GetHashCode();
        }

        class EventDispatcher
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>> k_EventQueuePool;
            static /*0x8*/ UnityEngine.UIElements.IEventDispatchingStrategy[] s_EditorStrategies;
            /*0x10*/ UnityEngine.UIElements.ClickDetector m_ClickDetector;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.IEventDispatchingStrategy> m_DispatchingStrategies;
            /*0x20*/ System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue;
            /*0x28*/ UnityEngine.UIElements.PointerDispatchState <pointerState>k__BackingField;
            /*0x30*/ uint m_GateCount;
            /*0x38*/ System.Collections.Generic.Stack<UnityEngine.UIElements.EventDispatcher.DispatchContext> m_DispatchContexts;
            /*0x40*/ bool m_Immediate;
            /*0x41*/ bool <processingEvents>k__BackingField;

            static /*0x174c26c*/ EventDispatcher();
            static /*0x174b408*/ UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies);
            /*0x174b468*/ EventDispatcher(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies);
            /*0x174b400*/ UnityEngine.UIElements.PointerDispatchState get_pointerState();
            /*0x174b614*/ bool get_dispatchImmediately();
            /*0x174b634*/ void set_processingEvents(bool value);
            /*0x174b640*/ void Dispatch(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x174b2b0*/ void CloseGate();
            /*0x174b2d8*/ void OpenGate();
            /*0x174bb74*/ void ProcessEventQueue();
            /*0x174b7a4*/ void ProcessEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
            /*0x174bf3c*/ void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, bool imguiEventIsInitiallyUsed);

            struct EventRecord
            {
                /*0x10*/ UnityEngine.UIElements.EventBase m_Event;
                /*0x18*/ UnityEngine.UIElements.IPanel m_Panel;
            }

            struct DispatchContext
            {
                /*0x10*/ uint m_GateCount;
                /*0x18*/ System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue;
            }
        }

        interface ISerializableJsonDictionary
        {
            void Set<T>(string key, T value);
            void Overwrite(object obj, string key);
            bool ContainsKey(string key);
        }

        class VisualElementUtils
        {
            static /*0x0*/ System.Collections.Generic.HashSet<string> s_usedNames;
            static /*0x8*/ System.Type s_FoldoutType;

            static /*0x174c7f0*/ VisualElementUtils();
            static /*0x174c5c8*/ string GetUniqueName(string nameBase);
            static /*0x174acdc*/ int GetFoldoutDepth(UnityEngine.UIElements.VisualElement element);
            static /*0x174c6dc*/ int GetListAndFoldoutDepth(UnityEngine.UIElements.VisualElement element);
        }

        class GroupBoxUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox, UnityEngine.UIElements.IGroupManager> s_GroupManagers;
            static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption, UnityEngine.UIElements.IGroupManager> s_GroupOptionManagerCache;
            static /*0x10*/ System.Type k_GenericGroupBoxType;

            static /*0x174d248*/ GroupBoxUtility();
            static void RegisterGroupBoxOptionCallbacks<T>(T option);
            static void OnOptionSelected<T>(T selectedOption);
            static /*0x174c8d8*/ void OnOptionAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            static /*0x174cf04*/ void OnOptionDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            static /*0x174cb24*/ UnityEngine.UIElements.IGroupManager FindOrCreateGroupManager(UnityEngine.UIElements.IGroupBox groupBox);
            static /*0x174d0b8*/ void OnGroupBoxDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            static /*0x174d16c*/ void OnPanelDestroyed(UnityEngine.UIElements.BaseVisualElementPanel panel);
        }

        struct RuleMatcher
        {
            /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
            /*0x18*/ UnityEngine.UIElements.StyleComplexSelector complexSelector;

            /*0x174d37c*/ string ToString();
        }

        class UQuery
        {
            interface IVisualPredicateWrapper
            {
                bool Predicate(object e);
            }

            class IsOfType<T> : UnityEngine.UIElements.UQuery.IVisualPredicateWrapper
            {
                static /*0x0*/ UnityEngine.UIElements.UQuery.IsOfType<T> s_Instance;

                static IsOfType();
                IsOfType();
                bool Predicate(object e);
            }

            class UQueryMatcher : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;

                static /*0x174d3b4*/ void NoProcessResult(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i);
                /*0x174d39c*/ UQueryMatcher();
                /*0x174d3a4*/ void Traverse(UnityEngine.UIElements.VisualElement element);
                /*0x174d3ac*/ bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
                /*0x174d3b8*/ void TraverseRecursive(UnityEngine.UIElements.VisualElement element, int depth);
                /*0x174d5b4*/ void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers);

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UQuery.UQueryMatcher.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> <>9__5_0;

                    static /*0x174d5c4*/ <>c();
                    /*0x174d628*/ <>c();
                    /*0x174d630*/ void <TraverseRecursive>b__5_0(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i);
                }
            }

            class SingleQueryMatcher : UnityEngine.UIElements.UQuery.UQueryMatcher
            {
                /*0x18*/ UnityEngine.UIElements.VisualElement <match>k__BackingField;

                /*0x174d678*/ SingleQueryMatcher();
                /*0x174d634*/ UnityEngine.UIElements.VisualElement get_match();
                /*0x174d63c*/ void set_match(UnityEngine.UIElements.VisualElement value);
                /*0x174d644*/ void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers);
                /*0x174d668*/ bool IsInUse();
                UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew();
            }

            class FirstQueryMatcher : UnityEngine.UIElements.UQuery.SingleQueryMatcher
            {
                static /*0x0*/ UnityEngine.UIElements.UQuery.FirstQueryMatcher Instance;

                static /*0x174d6f8*/ FirstQueryMatcher();
                /*0x174d6f0*/ FirstQueryMatcher();
                /*0x174d680*/ bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
                /*0x174d694*/ UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew();
            }
        }

        struct UQueryState<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<UnityEngine.UIElements.UQueryState<T>>
        {
            static /*0x0*/ UnityEngine.UIElements.UQueryState.ActionQueryMatcher<T> s_Action;
            static /*0x0*/ UnityEngine.UIElements.UQueryState.ListQueryMatcher<T, T> s_List;
            static /*0x0*/ UnityEngine.UIElements.UQueryState.ListQueryMatcher<T, UnityEngine.UIElements.VisualElement> s_EnumerationList;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_Element;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;

            static UQueryState();
            UQueryState(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers);
            UnityEngine.UIElements.UQueryState<T> RebuildOn(UnityEngine.UIElements.VisualElement element);
            T Single(UnityEngine.UIElements.UQuery.SingleQueryMatcher matcher);
            T First();
            void ToList(System.Collections.Generic.List<T> results);
            UnityEngine.UIElements.UQueryState.Enumerator<T> GetEnumerator();
            System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            bool Equals(UnityEngine.UIElements.UQueryState<T> other);
            bool Equals(object obj);
            int GetHashCode();

            class ListQueryMatcher`1<T, TElement> : UnityEngine.UIElements.UQuery.UQueryMatcher
            {
                /*0x0*/ System.Collections.Generic.List<TElement> <matches>k__BackingField;

                ListQueryMatcher`1();
                System.Collections.Generic.List<TElement> get_matches();
                void set_matches(System.Collections.Generic.List<TElement> value);
                bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
                void Reset();
            }

            class ActionQueryMatcher<T> : UnityEngine.UIElements.UQuery.UQueryMatcher
            {
                /*0x0*/ System.Action<T> <callBack>k__BackingField;

                ActionQueryMatcher();
                System.Action<T> get_callBack();
                bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
            }

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> iterationList;
                /*0x0*/ int currentIndex;

                Enumerator(UnityEngine.UIElements.UQueryState<T> queryState);
                T get_Current();
                object System.Collections.IEnumerator.get_Current();
                bool MoveNext();
                void Reset();
                void Dispose();
            }
        }

        struct UQueryBuilder<T> : System.IEquatable<UnityEngine.UIElements.UQueryBuilder<T>>
        {
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> m_StyleSelectors;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> m_Parts;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_Element;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;
            /*0x0*/ UnityEngine.UIElements.StyleSelectorRelationship m_Relationship;
            /*0x0*/ int pseudoStatesMask;
            /*0x0*/ int negatedPseudoStatesMask;

            UQueryBuilder(UnityEngine.UIElements.VisualElement visualElement);
            System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors();
            System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts();
            UnityEngine.UIElements.UQueryBuilder<T> Class(string classname);
            UnityEngine.UIElements.UQueryBuilder<T> Name(string id);
            UnityEngine.UIElements.UQueryBuilder<T2> OfType<T2>(string name, string className);
            UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType();
            void AddClass(string c);
            void AddName(string id);
            void AddType<T2>();
            UnityEngine.UIElements.UQueryBuilder<T2> AddRelationship<T2>(UnityEngine.UIElements.StyleSelectorRelationship relationship);
            void AddPseudoStatesRuleIfNecessasy();
            void FinishSelector();
            bool CurrentSelectorEmpty();
            void FinishCurrentSelector();
            UnityEngine.UIElements.UQueryState<T> Build();
            void ToList(System.Collections.Generic.List<T> results);
            bool Equals(UnityEngine.UIElements.UQueryBuilder<T> other);
            bool Equals(object obj);
            int GetHashCode();
        }

        class UQueryExtensions
        {
            static /*0x0*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementEmptyQuery;
            static /*0x10*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameQuery;
            static /*0x20*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementClassQuery;
            static /*0x30*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameAndClassQuery;
            static /*0x40*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeQuery;
            static /*0x50*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameQuery;
            static /*0x60*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndClassQuery;
            static /*0x70*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameAndClassQuery;

            static /*0x174db3c*/ UQueryExtensions();
            static T Q<T>(UnityEngine.UIElements.VisualElement e, string name, string className);
            static /*0x174d75c*/ UnityEngine.UIElements.VisualElement Q(UnityEngine.UIElements.VisualElement e, string name, string className);
            static UnityEngine.UIElements.UQueryBuilder<T> Query<T>(UnityEngine.UIElements.VisualElement e, string name, string className);
        }

        class UIElementsRuntimeUtility
        {
            static /*0x0*/ System.Action<UnityEngine.UIElements.BaseRuntimePanel> onCreatePanel;
            static /*0x8*/ bool s_RegisteredPlayerloopCallback;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels;
            static /*0x18*/ bool s_PanelOrderingDirty;
            static /*0x20*/ string s_RepaintProfilerMarkerName;
            static /*0x28*/ Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker;
            static /*0x30*/ int currentOverlayIndex;
            static /*0x38*/ UnityEngine.Object <activeEventSystem>k__BackingField;
            static /*0x40*/ UnityEngine.UIElements.DefaultEventSystem s_DefaultEventSystem;
            static /*0x48*/ System.Collections.Generic.List<UnityEngine.UIElements.PanelSettings> s_PotentiallyEmptyPanelSettings;

            static /*0x174e1f4*/ UIElementsRuntimeUtility();
            static /*0x174e014*/ void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value);
            static /*0x174e104*/ void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value);
            static /*0x174e528*/ UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent);
            static /*0x174e59c*/ UnityEngine.UIElements.BaseRuntimePanel FindOrCreateRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate);
            static /*0x174e98c*/ void DisposeRuntimePanel(UnityEngine.ScriptableObject ownerObject);
            static /*0x174e868*/ void RegisterCachedPanelInternal(int instanceID, UnityEngine.UIElements.IPanel panel);
            static /*0x174e738*/ void RemoveCachedPanelInternal(int instanceID);
            static /*0x174eb48*/ void RepaintOverlayPanel(UnityEngine.UIElements.BaseRuntimePanel panel);
            static /*0x174ec50*/ void BeginRenderOverlays(int displayIndex);
            static /*0x174eca8*/ void RenderOverlaysBeforePriority(int displayIndex, float maxPriority);
            static /*0x174eee0*/ void EndRenderOverlays(int displayIndex);
            static /*0x174ef50*/ UnityEngine.Object get_activeEventSystem();
            static /*0x174efa8*/ void set_activeEventSystem(UnityEngine.Object value);
            static /*0x174f004*/ bool get_useDefaultEventSystem();
            static /*0x174f0c0*/ void RegisterEventSystem(UnityEngine.Object eventSystem);
            static /*0x174f2d8*/ void UnregisterEventSystem(UnityEngine.Object eventSystem);
            static /*0x174f3ec*/ UnityEngine.UIElements.DefaultEventSystem get_defaultEventSystem();
            static /*0x174f498*/ void UpdateRuntimePanels();
            static /*0x174f8b8*/ void MarkPotentiallyEmpty(UnityEngine.UIElements.PanelSettings settings);
            static /*0x174f6b4*/ void RemoveUnusedPanels();
            static /*0x174ea5c*/ void RegisterPlayerloopCallback();
            static /*0x174eaf8*/ void UnregisterPlayerloopCallback();
            static /*0x1741dc0*/ void SetPanelOrderingDirty();
            static /*0x174ee58*/ System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels();
            static /*0x174f9cc*/ void SortPanels();
            static /*0x174fb90*/ UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x174fc10*/ UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x174fd64*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
            static /*0x174fe48*/ UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta);

            class CreateRuntimePanelDelegate : System.MulticastDelegate
            {
                /*0x174fe50*/ CreateRuntimePanelDelegate(object object, nint method);
                /*0x174ff7c*/ UnityEngine.UIElements.BaseRuntimePanel Invoke(UnityEngine.ScriptableObject ownerObject);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UIElementsRuntimeUtility.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.UIElements.Panel> <>9__46_0;

                static /*0x174ff90*/ <>c();
                /*0x174fff4*/ <>c();
                /*0x174fffc*/ void <.cctor>b__9_0();
                /*0x1750000*/ void <.cctor>b__9_1(int displayIndex, int sortOrder);
                /*0x1750064*/ int <SortPanels>b__46_0(UnityEngine.UIElements.Panel a, UnityEngine.UIElements.Panel b);
            }
        }

        interface IGroupBoxOption
        {
            void SetSelected(bool selected);
        }

        interface IGroupBox
        {
        }

        interface IGroupBox<T> : UnityEngine.UIElements.IGroupBox
        {
        }

        struct TimerState : System.IEquatable<UnityEngine.UIElements.TimerState>
        {
            /*0x10*/ long <start>k__BackingField;
            /*0x18*/ long <now>k__BackingField;

            /*0x17501d4*/ long get_start();
            /*0x17501dc*/ void set_start(long value);
            /*0x17501e4*/ long get_now();
            /*0x17501ec*/ void set_now(long value);
            /*0x17501f4*/ long get_deltaTime();
            /*0x1750200*/ bool Equals(object obj);
            /*0x1750288*/ bool Equals(UnityEngine.UIElements.TimerState other);
            /*0x17502ac*/ int GetHashCode();
        }

        interface IScheduler
        {
            void Unschedule(UnityEngine.UIElements.ScheduledItem item);
            void Schedule(UnityEngine.UIElements.ScheduledItem item);
            void UpdateScheduledEvents();
        }

        class ScheduledItem
        {
            static /*0x0*/ System.Func<bool> OnceCondition;
            static /*0x8*/ System.Func<bool> ForeverCondition;
            /*0x10*/ System.Func<bool> timerUpdateStopCondition;
            /*0x18*/ long <startMs>k__BackingField;
            /*0x20*/ long <delayMs>k__BackingField;
            /*0x28*/ long <intervalMs>k__BackingField;
            /*0x30*/ long <endTimeMs>k__BackingField;

            static /*0x1750454*/ ScheduledItem();
            /*0x1750360*/ ScheduledItem();
            /*0x1750328*/ long get_startMs();
            /*0x1750330*/ void set_startMs(long value);
            /*0x1750338*/ long get_delayMs();
            /*0x1750340*/ void set_delayMs(long value);
            /*0x1750348*/ long get_intervalMs();
            /*0x1750350*/ void set_intervalMs(long value);
            /*0x1750358*/ long get_endTimeMs();
            /*0x17503d4*/ void ResetStartTime();
            void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
            /*0x1750430*/ void OnItemUnscheduled();
            /*0x1750434*/ bool ShouldUnschedule();

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.ScheduledItem.<> <>9;

                static /*0x175056c*/ <>c();
                /*0x17505d0*/ <>c();
                /*0x17505d8*/ bool <.cctor>b__25_0();
                /*0x17505e0*/ bool <.cctor>b__25_1();
            }
        }

        class TimerEventScheduler : UnityEngine.UIElements.IScheduler
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduledItems;
            /*0x18*/ bool m_TransactionMode;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduleTransactions;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.ScheduledItem> m_UnscheduleTransactions;
            /*0x30*/ bool disableThrottling;
            /*0x34*/ int m_LastUpdatedIndex;

            /*0x1750d70*/ TimerEventScheduler();
            /*0x17505e8*/ void Schedule(UnityEngine.UIElements.ScheduledItem item);
            /*0x17507b0*/ bool RemovedScheduledItemAt(int index);
            /*0x175081c*/ void Unschedule(UnityEngine.UIElements.ScheduledItem item);
            /*0x17509c0*/ bool PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem sItem);
            /*0x1750a60*/ void UpdateScheduledEvents();
        }

        class DropdownMenuEventInfo
        {
            /*0x10*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x14*/ UnityEngine.Vector2 <mousePosition>k__BackingField;
            /*0x1c*/ UnityEngine.Vector2 <localMousePosition>k__BackingField;
            /*0x24*/ char <character>k__BackingField;
            /*0x28*/ UnityEngine.KeyCode <keyCode>k__BackingField;

            /*0x1750e60*/ DropdownMenuEventInfo(UnityEngine.UIElements.EventBase e);
        }

        class DropdownMenuItem
        {
            /*0x175117c*/ DropdownMenuItem();
        }

        class DropdownMenuSeparator : UnityEngine.UIElements.DropdownMenuItem
        {
            /*0x10*/ string <subMenuPath>k__BackingField;

            /*0x1751184*/ DropdownMenuSeparator(string subMenuPath);
        }

        class DropdownMenuAction : UnityEngine.UIElements.DropdownMenuItem
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.DropdownMenuAction.Status <status>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.DropdownMenuEventInfo <eventInfo>k__BackingField;
            /*0x28*/ object <userData>k__BackingField;
            /*0x30*/ System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback;
            /*0x38*/ System.Func<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback;

            /*0x17511c4*/ DropdownMenuAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData);
            /*0x17511ac*/ void set_status(UnityEngine.UIElements.DropdownMenuAction.Status value);
            /*0x17511b4*/ void set_eventInfo(UnityEngine.UIElements.DropdownMenuEventInfo value);
            /*0x17511bc*/ void set_userData(object value);
            /*0x1751208*/ void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo eventInfo);

            enum Status
            {
                None = 0,
                Normal = 1,
                Disabled = 2,
                Checked = 4,
                Hidden = 8,
            }
        }

        class DropdownMenu
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems;
            /*0x18*/ UnityEngine.UIElements.DropdownMenuEventInfo m_DropdownMenuEventInfo;

            /*0x1751244*/ System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems();
            /*0x175124c*/ void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData);
            /*0x1751350*/ void InsertSeparator(string subMenuPath, int atIndex);
            /*0x1751490*/ void PrepareForDisplay(UnityEngine.UIElements.EventBase e);
        }

        class ListViewReorderableDragAndDropController : UnityEngine.UIElements.BaseReorderableDragAndDropController
        {
            /*0x28*/ UnityEngine.UIElements.ListView m_ListView;

            /*0x175174c*/ ListViewReorderableDragAndDropController(UnityEngine.UIElements.ListView view);
            /*0x17517b0*/ UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
            /*0x175194c*/ void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
        }

        class BaseReorderableDragAndDropController : UnityEngine.UIElements.ICollectionDragAndDropController, UnityEngine.UIElements.IDragAndDropController<UnityEngine.UIElements.IListDragAndDropArgs>, UnityEngine.UIElements.IReorderable
        {
            /*0x10*/ UnityEngine.UIElements.BaseVerticalCollectionView m_View;
            /*0x18*/ System.Collections.Generic.List<int> m_SelectedIndices;
            /*0x20*/ bool <enableReordering>k__BackingField;

            /*0x1751780*/ BaseReorderableDragAndDropController(UnityEngine.UIElements.BaseVerticalCollectionView view);
            /*0x1751bd4*/ bool get_enableReordering();
            /*0x1751bdc*/ void set_enableReordering(bool value);
            /*0x1751be8*/ bool CanStartDrag(System.Collections.Generic.IEnumerable<int> itemIndices);
            /*0x1751bf0*/ UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<int> itemIndices, bool skipText);
            UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
            void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
        }

        interface IListDragAndDropArgs
        {
            int get_insertAtIndex();
            UnityEngine.UIElements.IDragAndDropData get_dragAndDropData();
            UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition();
        }

        struct ListDragAndDropArgs : UnityEngine.UIElements.IListDragAndDropArgs
        {
            /*0x10*/ object <target>k__BackingField;
            /*0x18*/ int <insertAtIndex>k__BackingField;
            /*0x1c*/ UnityEngine.UIElements.DragAndDropPosition <dragAndDropPosition>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.IDragAndDropData <dragAndDropData>k__BackingField;

            /*0x175258c*/ void set_target(object value);
            /*0x1752594*/ int get_insertAtIndex();
            /*0x175259c*/ void set_insertAtIndex(int value);
            /*0x17525a4*/ UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition();
            /*0x17525ac*/ void set_dragAndDropPosition(UnityEngine.UIElements.DragAndDropPosition value);
            /*0x17525b4*/ UnityEngine.UIElements.IDragAndDropData get_dragAndDropData();
            /*0x17525bc*/ void set_dragAndDropData(UnityEngine.UIElements.IDragAndDropData value);
        }

        enum DragAndDropPosition
        {
            OverItem = 0,
            BetweenItems = 1,
            OutsideItems = 2,
        }

        interface IDragAndDropController<TArgs>
        {
            bool CanStartDrag(System.Collections.Generic.IEnumerable<int> itemIndices);
            UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<int> itemIndices, bool skipText);
            UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(TArgs args);
            void OnDrop(TArgs args);
        }

        enum DragVisualMode
        {
            None = 0,
            Copy = 1,
            Move = 2,
            Rejected = 3,
        }

        class StartDragArgs
        {
            /*0x10*/ string <title>k__BackingField;
            /*0x18*/ object <userData>k__BackingField;
            /*0x20*/ System.Collections.Hashtable m_GenericData;
            /*0x28*/ System.Collections.Generic.IEnumerable<UnityEngine.Object> <unityObjectReferences>k__BackingField;

            /*0x175250c*/ StartDragArgs(string title, object userData);
            /*0x17525c4*/ object get_userData();
        }

        class ListViewDragger : UnityEngine.UIElements.DragEventsProcessor
        {
            /*0x38*/ UnityEngine.UIElements.ListViewDragger.DragPosition m_LastDragPosition;
            /*0x50*/ UnityEngine.UIElements.VisualElement m_DragHoverBar;
            /*0x58*/ UnityEngine.UIElements.ICollectionDragAndDropController <dragAndDropController>k__BackingField;

            /*0x1752674*/ ListViewDragger(UnityEngine.UIElements.BaseVerticalCollectionView listView);
            /*0x17525cc*/ UnityEngine.UIElements.BaseVerticalCollectionView get_targetListView();
            /*0x1752648*/ UnityEngine.UIElements.ScrollView get_targetScrollView();
            /*0x1752664*/ UnityEngine.UIElements.ICollectionDragAndDropController get_dragAndDropController();
            /*0x175266c*/ void set_dragAndDropController(UnityEngine.UIElements.ICollectionDragAndDropController value);
            /*0x17527b4*/ bool CanStartDrag(UnityEngine.Vector3 pointerPosition);
            /*0x1752d88*/ UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition);
            /*0x1752f44*/ UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3 pointerPosition);
            /*0x1752fb0*/ UnityEngine.UIElements.DragVisualMode GetVisualMode(UnityEngine.Vector3 pointerPosition, ref UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x1753a80*/ void OnDrop(UnityEngine.Vector3 pointerPosition);
            /*0x17536f4*/ void HandleDragAndScroll(UnityEngine.Vector2 pointerPosition);
            /*0x1753114*/ void ApplyDragAndDropUI(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x1753ef8*/ bool TryGetDragPosition(UnityEngine.Vector2 pointerPosition, ref UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x1753930*/ UnityEngine.UIElements.ListDragAndDropArgs MakeDragAndDropArgs(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x1753e3c*/ void PlaceHoverBarAtElement(UnityEngine.UIElements.VisualElement element);
            /*0x1753cb8*/ void PlaceHoverBarAt(float top);
            /*0x1754318*/ void ClearDragAndDropUI();
            /*0x17529f0*/ UnityEngine.UIElements.ReusableCollectionItem GetRecycledItem(UnityEngine.Vector3 pointerPosition);
            /*0x1754728*/ void <ApplyDragAndDropUI>b__22_0(UnityEngine.UIElements.GeometryChangedEvent e);

            struct DragPosition : System.IEquatable<UnityEngine.UIElements.ListViewDragger.DragPosition>
            {
                /*0x10*/ int insertAtIndex;
                /*0x18*/ UnityEngine.UIElements.ReusableCollectionItem recycledItem;
                /*0x20*/ UnityEngine.UIElements.DragAndDropPosition dragAndDropPosition;

                /*0x1753c60*/ bool Equals(UnityEngine.UIElements.ListViewDragger.DragPosition other);
                /*0x1754830*/ bool Equals(object obj);
                /*0x17548cc*/ int GetHashCode();
            }
        }

        class ListViewDraggerExtension
        {
            static /*0x17521c4*/ UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromIndex(UnityEngine.UIElements.BaseVerticalCollectionView listView, int index);
        }

        class ListViewDraggerAnimated : UnityEngine.UIElements.ListViewDragger
        {
            /*0x60*/ int m_DragStartIndex;
            /*0x64*/ int m_CurrentIndex;
            /*0x68*/ float m_SelectionHeight;
            /*0x6c*/ float m_LocalOffsetOnStart;
            /*0x70*/ UnityEngine.Vector3 m_CurrentPointerPosition;
            /*0x80*/ UnityEngine.UIElements.ReusableCollectionItem m_Item;
            /*0x88*/ UnityEngine.UIElements.ReusableCollectionItem m_OffsetItem;

            /*0x1754934*/ ListViewDraggerAnimated(UnityEngine.UIElements.BaseVerticalCollectionView listView);
            /*0x1754914*/ bool get_isDragging();
            /*0x1754924*/ UnityEngine.UIElements.ReusableCollectionItem get_draggedItem();
            /*0x175492c*/ bool get_supportsDragEvents();
            /*0x1754938*/ UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition);
            /*0x1755358*/ UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3 pointerPosition);
            /*0x1755018*/ void Animate(UnityEngine.UIElements.ReusableCollectionItem element, float paddingTop);
            /*0x1755bec*/ void OnDrop(UnityEngine.Vector3 pointerPosition);
            /*0x1755eec*/ void ClearDragAndDropUI();
            /*0x1755ef0*/ bool TryGetDragPosition(UnityEngine.Vector2 pointerPosition, ref UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
        }

        interface ICollectionDragAndDropController : UnityEngine.UIElements.IDragAndDropController<UnityEngine.UIElements.IListDragAndDropArgs>, UnityEngine.UIElements.IReorderable
        {
        }

        class DragAndDropUtility
        {
            static /*0x0*/ System.Func<UnityEngine.UIElements.IDragAndDrop> s_MakeClientFunc;
            static /*0x8*/ UnityEngine.UIElements.IDragAndDrop s_DragAndDrop;

            static /*0x175426c*/ UnityEngine.UIElements.IDragAndDrop get_dragAndDrop();
        }

        class DefaultDragAndDropClient : UnityEngine.UIElements.IDragAndDrop, UnityEngine.UIElements.IDragAndDropData
        {
            /*0x10*/ UnityEngine.UIElements.StartDragArgs m_StartDragArgs;

            /*0x1755f10*/ DefaultDragAndDropClient();
            /*0x1755f18*/ object get_userData();
            /*0x1755f30*/ void StartDrag(UnityEngine.UIElements.StartDragArgs args);
            /*0x1754268*/ UnityEngine.UIElements.IDragAndDropData get_data();
        }

        interface IDragAndDrop
        {
            void StartDrag(UnityEngine.UIElements.StartDragArgs args);
            UnityEngine.UIElements.IDragAndDropData get_data();
        }

        interface IDragAndDropData
        {
            object get_userData();
        }

        interface IReorderable
        {
            bool get_enableReordering();
            void set_enableReordering(bool value);
        }

        class DragEventsProcessor
        {
            /*0x10*/ bool m_IsRegistered;
            /*0x14*/ UnityEngine.UIElements.DragEventsProcessor.DragState m_DragState;
            /*0x18*/ UnityEngine.Vector3 m_Start;
            /*0x28*/ UnityEngine.UIElements.VisualElement m_Target;
            /*0x30*/ UnityEngine.UIElements.DefaultDragAndDropClient dragAndDropClient;

            /*0x1752678*/ DragEventsProcessor(UnityEngine.UIElements.VisualElement target);
            /*0x1755f38*/ bool get_supportsDragEvents();
            /*0x1754238*/ bool get_useDragEvents();
            /*0x1755f40*/ bool get_isEditorContext();
            /*0x175630c*/ void RegisterCallbacksFromTarget(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x1756060*/ void RegisterCallbacksFromTarget();
            /*0x1756310*/ void UnregisterCallbacksFromTarget(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x1756318*/ void UnregisterCallbacksFromTarget(bool unregisterPanelEvents);
            bool CanStartDrag(UnityEngine.Vector3 pointerPosition);
            UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition);
            UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3 pointerPosition);
            void OnDrop(UnityEngine.Vector3 pointerPosition);
            void ClearDragAndDropUI();
            /*0x17566b0*/ void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x1756744*/ void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x1756808*/ void OnPointerLeaveEvent(UnityEngine.UIElements.PointerLeaveEvent evt);
            /*0x175684c*/ void OnPointerCancelEvent(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x175688c*/ void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent evt);

            enum DragState
            {
                None = 0,
                CanStartDrag = 1,
                Dragging = 2,
            }
        }

        class UxmlRootElementFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlRootElementTraits>
        {
            /*0x1756b8c*/ UxmlRootElementFactory();
            /*0x1756ad0*/ string get_uxmlName();
            /*0x1756b10*/ string get_uxmlQualifiedName();
            /*0x1756b84*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlRootElementTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
            /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Class;

            /*0x1756bd4*/ UxmlRootElementTraits();
        }

        class UxmlStyleFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlStyleTraits>
        {
            /*0x1756e08*/ UxmlStyleFactory();
            /*0x1756d4c*/ string get_uxmlName();
            /*0x1756d8c*/ string get_uxmlQualifiedName();
            /*0x1756e00*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlStyleTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
            /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Path;
            /*0x28*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Src;

            /*0x1756e50*/ UxmlStyleTraits();
        }

        class UxmlTemplateFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlTemplateTraits>
        {
            /*0x1756ffc*/ UxmlTemplateFactory();
            /*0x1756f40*/ string get_uxmlName();
            /*0x1756f80*/ string get_uxmlQualifiedName();
            /*0x1756ff4*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlTemplateTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
            /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Path;
            /*0x28*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Src;

            /*0x1757044*/ UxmlTemplateTraits();
        }

        class UxmlAttributeOverridesFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlAttributeOverridesTraits>
        {
            /*0x17571f8*/ UxmlAttributeOverridesFactory();
            /*0x175713c*/ string get_uxmlName();
            /*0x175717c*/ string get_uxmlQualifiedName();
            /*0x17571f0*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlAttributeOverridesTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_ElementName;

            /*0x1757240*/ UxmlAttributeOverridesTraits();
        }

        class UxmlTypeRestriction : System.IEquatable<UnityEngine.UIElements.UxmlTypeRestriction>
        {
            /*0x17572d4*/ UxmlTypeRestriction();
            /*0x17572c8*/ bool Equals(UnityEngine.UIElements.UxmlTypeRestriction other);
        }

        class UxmlEnumeration : UnityEngine.UIElements.UxmlTypeRestriction
        {
            /*0x10*/ System.Collections.Generic.List<string> m_Values;

            /*0x175748c*/ UxmlEnumeration();
            /*0x17572dc*/ System.Collections.Generic.IEnumerable<string> get_values();
            /*0x17572e4*/ void set_values(System.Collections.Generic.IEnumerable<string> value);
            /*0x1757340*/ bool Equals(UnityEngine.UIElements.UxmlTypeRestriction other);
        }

        class UxmlAttributeDescription
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ string[] m_ObsoleteNames;
            /*0x20*/ string <type>k__BackingField;
            /*0x28*/ string <typeNamespace>k__BackingField;
            /*0x30*/ UnityEngine.UIElements.UxmlAttributeDescription.Use <use>k__BackingField;
            /*0x38*/ UnityEngine.UIElements.UxmlTypeRestriction <restriction>k__BackingField;

            /*0x1757508*/ UxmlAttributeDescription();
            /*0x175752c*/ string get_name();
            /*0x1757534*/ void set_name(string value);
            /*0x175753c*/ void set_obsoleteNames(System.Collections.Generic.IEnumerable<string> value);
            /*0x1757598*/ void set_type(string value);
            /*0x17575a0*/ void set_typeNamespace(string value);
            /*0x17575a8*/ void set_use(UnityEngine.UIElements.UxmlAttributeDescription.Use value);
            /*0x17575b0*/ void set_restriction(UnityEngine.UIElements.UxmlTypeRestriction value);
            /*0x17575b8*/ bool TryGetValueFromBagAsString(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref string value);
            bool TryGetValueFromBag<T>(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<string, T, T> converterFunc, T defaultValue, ref T value);
            T GetValueFromBag<T>(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<string, T, T> converterFunc, T defaultValue);

            enum Use
            {
                None = 0,
                Optional = 1,
                Prohibited = 2,
                Required = 3,
            }
        }

        class TypedUxmlAttributeDescription<T> : UnityEngine.UIElements.UxmlAttributeDescription
        {
            /*0x0*/ T <defaultValue>k__BackingField;

            TypedUxmlAttributeDescription();
            T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            T get_defaultValue();
            void set_defaultValue(T value);
        }

        class UxmlStringAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<string>
        {
            /*0x1756c90*/ UxmlStringAttributeDescription();
            /*0x1757a2c*/ string GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, string, string> <>9__3_0;

                static /*0x1757b90*/ <>c();
                /*0x1757bf4*/ <>c();
                /*0x1757bfc*/ string <GetValueFromBag>b__3_0(string s, string t);
            }
        }

        class UxmlFloatAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<float>
        {
            static /*0x1757e04*/ float ConvertValueToFloat(string v, float defaultValue);
            /*0x1757c04*/ UxmlFloatAttributeDescription();
            /*0x1757ca0*/ float GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlFloatAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, float, float> <>9__3_0;

                static /*0x1757ea0*/ <>c();
                /*0x1757f04*/ <>c();
                /*0x1757f0c*/ float <GetValueFromBag>b__3_0(string s, float f);
            }
        }

        class UxmlIntAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<int>
        {
            static /*0x175828c*/ int ConvertValueToInt(string v, int defaultValue);
            /*0x1757f14*/ UxmlIntAttributeDescription();
            /*0x1757fb0*/ int GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            /*0x1758114*/ bool TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref int value);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlIntAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, int, int> <>9__3_0;
                static /*0x10*/ System.Func<string, int, int> <>9__4_0;

                static /*0x17582c8*/ <>c();
                /*0x175832c*/ <>c();
                /*0x1758334*/ int <GetValueFromBag>b__3_0(string s, int i);
                /*0x1758374*/ int <TryGetValueFromBag>b__4_0(string s, int i);
            }
        }

        class UxmlLongAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<long>
        {
            static /*0x17585b4*/ long ConvertValueToLong(string v, long defaultValue);
            /*0x17583b4*/ UxmlLongAttributeDescription();
            /*0x1758450*/ long GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlLongAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, long, long> <>9__3_0;

                static /*0x17585f0*/ <>c();
                /*0x1758654*/ <>c();
                /*0x175865c*/ long <GetValueFromBag>b__3_0(string s, long l);
            }
        }

        class UxmlBoolAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<bool>
        {
            static /*0x172333c*/ bool ConvertValueToBool(string v, bool defaultValue);
            /*0x1722fc0*/ UxmlBoolAttributeDescription();
            /*0x172305c*/ bool GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            /*0x17231c4*/ bool TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref bool value);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, bool, bool> <>9__3_0;
                static /*0x10*/ System.Func<string, bool, bool> <>9__4_0;

                static /*0x17233c4*/ <>c();
                /*0x1723428*/ <>c();
                /*0x1723430*/ bool <GetValueFromBag>b__3_0(string s, bool b);
                /*0x1723440*/ bool <TryGetValueFromBag>b__4_0(string s, bool b);
            }
        }

        class UxmlEnumAttributeDescription<T> : UnityEngine.UIElements.TypedUxmlAttributeDescription<T>
        {
            static U ConvertValueToEnum<U>(string v, U defaultValue);
            UxmlEnumAttributeDescription();
            T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            bool TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref T value);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlEnumAttributeDescription.<>c<T> <>9;
                static /*0x0*/ System.Func<string, T, T> <>9__3_0;
                static /*0x0*/ System.Func<string, T, T> <>9__4_0;

                static <>c();
                <>c();
                T <GetValueFromBag>b__3_0(string s, T convertible);
                T <TryGetValueFromBag>b__4_0(string s, T convertible);
            }
        }

        class UxmlTraits
        {
            /*0x10*/ bool <canHaveAnyAttribute>k__BackingField;

            /*0x1723450*/ UxmlTraits();
            /*0x1723470*/ void set_canHaveAnyAttribute(bool value);
            /*0x172347c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        interface IUxmlFactory
        {
            string get_uxmlQualifiedName();
            bool AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlFactory<TCreatedType, TTraits> : UnityEngine.UIElements.IUxmlFactory
        {
            /*0x0*/ TTraits m_Traits;

            UxmlFactory();
            string get_uxmlName();
            string get_uxmlNamespace();
            string get_uxmlQualifiedName();
            bool AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlFactory<TCreatedType> : UnityEngine.UIElements.UxmlFactory<TCreatedType, UnityEngine.UIElements.VisualElement.UxmlTraits>
        {
            UxmlFactory();
        }

        interface IUxmlAttributes
        {
            bool TryGetAttributeValue(string attributeName, ref string value);
        }

        class TemplateAsset : UnityEngine.UIElements.VisualElementAsset
        {
            /*0x60*/ string m_TemplateAlias;
            /*0x68*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> m_AttributeOverrides;
            /*0x70*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> m_SlotUsages;

            /*0x1723480*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides();
            /*0x1723500*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> get_slotUsages();

            struct AttributeOverride
            {
                /*0x10*/ string m_ElementName;
                /*0x18*/ string m_AttributeName;
                /*0x20*/ string m_Value;
            }
        }

        class VisualElementFactoryRegistry
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_Factories;

            static /*0x1723508*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories();
            static /*0x17243b4*/ void RegisterFactory(UnityEngine.UIElements.IUxmlFactory factory);
            static /*0x1724824*/ bool TryGetValue(string fullTypeName, ref System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory> factoryList);
            static /*0x17235b8*/ void RegisterEngineFactories();
            static /*0x17240e4*/ void RegisterUserFactories();
        }

        class VisualTreeAsset : UnityEngine.ScriptableObject
        {
            static /*0x0*/ string LinkedVEAInTemplatePropertyName;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> s_TemporarySlotInsertionPoints;
            /*0x18*/ bool m_ImportedWithErrors;
            /*0x19*/ bool m_ImportedWithWarnings;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> m_Usings;
            /*0x28*/ UnityEngine.UIElements.StyleSheet inlineSheet;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> m_VisualElementAssets;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> m_TemplateAssets;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> m_Slots;
            /*0x48*/ int m_ContentContainerId;
            /*0x4c*/ int m_ContentHash;

            static /*0x1726cfc*/ VisualTreeAsset();
            static /*0x1726700*/ int CompareForOrder(UnityEngine.UIElements.VisualElementAsset a, UnityEngine.UIElements.VisualElementAsset b);
            static /*0x1726080*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.CreationContext ctx);
            static /*0x1725600*/ void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element);
            static /*0x172566c*/ void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element);
            static /*0x17269c0*/ UnityEngine.UIElements.VisualElement <Create>g__CreateError|49_0(ref UnityEngine.UIElements.VisualTreeAsset.<> );
            /*0x1726cf4*/ VisualTreeAsset();
            /*0x17249a4*/ bool get_importedWithErrors();
            /*0x17249ac*/ void set_importedWithErrors(bool value);
            /*0x17249b8*/ bool get_importedWithWarnings();
            /*0x17249c0*/ void set_importedWithWarnings(bool value);
            /*0x17249cc*/ int GetNextChildSerialNumber();
            /*0x1724a2c*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies();
            /*0x1724ad4*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets();
            /*0x1724b7c*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets();
            /*0x1724b84*/ void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value);
            /*0x1724b8c*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets();
            /*0x1724b94*/ void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value);
            /*0x1724b9c*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots();
            /*0x1724ba4*/ void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value);
            /*0x1724bac*/ int get_contentContainerId();
            /*0x1724bb4*/ void set_contentContainerId(int value);
            /*0x1724bbc*/ UnityEngine.UIElements.TemplateContainer Instantiate();
            /*0x17253bc*/ UnityEngine.UIElements.TemplateContainer Instantiate(string bindingPath);
            /*0x17253dc*/ UnityEngine.UIElements.TemplateContainer CloneTree();
            /*0x17253e0*/ UnityEngine.UIElements.TemplateContainer CloneTree(string bindingPath);
            /*0x1725400*/ void CloneTree(UnityEngine.UIElements.VisualElement target);
            /*0x172541c*/ void CloneTree(UnityEngine.UIElements.VisualElement target, ref int firstElementIndex, ref int elementAddedCount);
            /*0x1724d3c*/ void CloneTree(UnityEngine.UIElements.VisualElement target, System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides);
            /*0x1725838*/ UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset root, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, UnityEngine.UIElements.CreationContext context);
            /*0x1726640*/ bool TryGetSlotInsertionPoint(int insertionPointId, ref string slotName);
            /*0x172673c*/ UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(string templateName);
            /*0x1726ce4*/ int get_contentHash();
            /*0x1726cec*/ void set_contentHash(int value);

            struct UsingEntry
            {
                static /*0x0*/ System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> comparer;
                /*0x10*/ string alias;
                /*0x18*/ string path;
                /*0x20*/ UnityEngine.UIElements.VisualTreeAsset asset;

                static /*0x1726db4*/ UsingEntry();
                /*0x17269ac*/ UsingEntry(string alias, string path);
            }

            class UsingEntryComparer : System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry>
            {
                /*0x1726e2c*/ UsingEntryComparer();
                /*0x1726e34*/ int Compare(UnityEngine.UIElements.VisualTreeAsset.UsingEntry x, UnityEngine.UIElements.VisualTreeAsset.UsingEntry y);
            }

            struct SlotDefinition
            {
                /*0x10*/ string name;
                /*0x18*/ int insertionPointId;
            }

            struct SlotUsageEntry
            {
                /*0x10*/ string slotName;
                /*0x18*/ int assetId;
            }

            class <get_templateDependencies>d__17 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.VisualTreeAsset <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.UIElements.VisualTreeAsset <>4__this;
                /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualTreeAsset> <sent>5__1;
                /*0x38*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> <>s__2;
                /*0x60*/ UnityEngine.UIElements.VisualTreeAsset.UsingEntry <entry>5__3;
                /*0x78*/ UnityEngine.UIElements.VisualTreeAsset <vta>5__4;

                /*0x1724a90*/ <get_templateDependencies>d__17(int <>1__state);
                /*0x1726e44*/ void System.IDisposable.Dispose();
                /*0x1726e70*/ bool MoveNext();
                /*0x1727350*/ void <>m__Finally1();
                /*0x17273a0*/ UnityEngine.UIElements.VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current();
                /*0x17273a8*/ void System.Collections.IEnumerator.Reset();
                /*0x17273e8*/ object System.Collections.IEnumerator.get_Current();
                /*0x17273f0*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator();
                /*0x1727490*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <get_stylesheets>d__21 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.StyleSheet <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.UIElements.VisualTreeAsset <>4__this;
                /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheet> <sent>5__1;
                /*0x38*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.VisualElementAsset> <>s__2;
                /*0x50*/ UnityEngine.UIElements.VisualElementAsset <vea>5__3;
                /*0x58*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StyleSheet> <>s__4;
                /*0x70*/ UnityEngine.UIElements.StyleSheet <stylesheet>5__5;
                /*0x78*/ System.Collections.Generic.List.Enumerator<string> <>s__6;
                /*0x90*/ string <stylesheetPath>5__7;
                /*0x98*/ UnityEngine.UIElements.StyleSheet <stylesheet>5__8;

                /*0x1724b38*/ <get_stylesheets>d__21(int <>1__state);
                /*0x1727494*/ void System.IDisposable.Dispose();
                /*0x1727580*/ bool MoveNext();
                /*0x1727bdc*/ void <>m__Finally1();
                /*0x1727b3c*/ void <>m__Finally2();
                /*0x1727b8c*/ void <>m__Finally3();
                /*0x1727c2c*/ UnityEngine.UIElements.StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current();
                /*0x1727c34*/ void System.Collections.IEnumerator.Reset();
                /*0x1727c74*/ object System.Collections.IEnumerator.get_Current();
                /*0x1727c7c*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator();
                /*0x1727d1c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.UIElements.VisualElementAsset childVea;

                /*0x17266f8*/ <>c__DisplayClass45_0();
                /*0x1727d20*/ bool <CloneSetupRecursively>b__0(UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry u);
            }

            struct <>c__DisplayClass49_0
            {
                /*0x10*/ UnityEngine.UIElements.VisualElementAsset asset;
            }
        }

        struct CreationContext : System.IEquatable<UnityEngine.UIElements.CreationContext>
        {
            static /*0x0*/ UnityEngine.UIElements.CreationContext Default;
            /*0x10*/ UnityEngine.UIElements.VisualElement <target>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.VisualTreeAsset <visualTreeAsset>k__BackingField;
            /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> <slotInsertionPoints>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> <attributeOverrides>k__BackingField;

            static /*0x1727fec*/ CreationContext();
            /*0x172582c*/ CreationContext(System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target);
            /*0x1727d44*/ UnityEngine.UIElements.VisualElement get_target();
            /*0x1727d4c*/ void set_target(UnityEngine.UIElements.VisualElement value);
            /*0x1727d54*/ UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset();
            /*0x1727d5c*/ void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x1727d64*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> get_slotInsertionPoints();
            /*0x1727d6c*/ void set_slotInsertionPoints(System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> value);
            /*0x1727d74*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides();
            /*0x1727d7c*/ void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value);
            /*0x1727d84*/ bool Equals(object obj);
            /*0x1727e0c*/ bool Equals(UnityEngine.UIElements.CreationContext other);
            /*0x1727efc*/ int GetHashCode();
        }

        class VisualElementAsset : UnityEngine.UIElements.IUxmlAttributes, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ string m_Name;
            /*0x18*/ int m_Id;
            /*0x1c*/ int m_OrderInDocument;
            /*0x20*/ int m_ParentId;
            /*0x24*/ int m_RuleIndex;
            /*0x28*/ string m_Text;
            /*0x30*/ UnityEngine.UIElements.PickingMode m_PickingMode;
            /*0x38*/ string m_FullTypeName;
            /*0x40*/ string[] m_Classes;
            /*0x48*/ System.Collections.Generic.List<string> m_StylesheetPaths;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_Stylesheets;
            /*0x58*/ System.Collections.Generic.List<string> m_Properties;

            /*0x1725824*/ int get_id();
            /*0x1726734*/ int get_orderInDocument();
            /*0x17255f8*/ int get_parentId();
            /*0x17266f0*/ int get_ruleIndex();
            /*0x17269b8*/ string get_fullTypeName();
            /*0x1726bbc*/ string[] get_classes();
            /*0x1726bd4*/ System.Collections.Generic.List<string> get_stylesheetPaths();
            /*0x1726bc4*/ bool get_hasStylesheetPaths();
            /*0x1726c64*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets();
            /*0x1726c54*/ bool get_hasStylesheets();
            /*0x1728038*/ void OnBeforeSerialize();
            /*0x172803c*/ void OnAfterDeserialize();
            /*0x17281c4*/ void AddProperty(string propertyName, string propertyValue);
            /*0x17281c8*/ void SetOrAddProperty(string propertyName, string propertyValue);
            /*0x17283d8*/ bool TryGetAttributeValue(string propertyName, ref string value);
        }

        class UIDocumentList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments;

            /*0x172887c*/ UIDocumentList();
            /*0x17284a8*/ void RemoveFromListAndFromVisualTree(UnityEngine.UIElements.UIDocument uiDocument);
            /*0x1728528*/ void AddToListAndToVisualTree(UnityEngine.UIElements.UIDocument uiDocument, UnityEngine.UIElements.VisualElement visualTree, int firstInsertIndex);
        }

        class UIDocument : UnityEngine.MonoBehaviour
        {
            static string k_RootStyleClassName = "unity-ui-document__root";
            static string k_VisualElementNameSuffix = "-container";
            static int k_DefaultSortingOrder = 0;
            static /*0x0*/ int s_CurrentUIDocumentCounter;
            /*0x18*/ int m_UIDocumentCreationIndex;
            /*0x20*/ UnityEngine.UIElements.PanelSettings m_PanelSettings;
            /*0x28*/ UnityEngine.UIElements.PanelSettings m_PreviousPanelSettings;
            /*0x30*/ UnityEngine.UIElements.UIDocument m_ParentUI;
            /*0x38*/ UnityEngine.UIElements.UIDocumentList m_ChildrenContent;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_ChildrenContentCopy;
            /*0x48*/ UnityEngine.UIElements.VisualTreeAsset sourceAsset;
            /*0x50*/ UnityEngine.UIElements.VisualElement m_RootVisualElement;
            /*0x58*/ int m_FirstChildInsertIndex;
            /*0x5c*/ float m_SortingOrder;

            /*0x17291d0*/ UIDocument();
            /*0x17288f8*/ UnityEngine.UIElements.PanelSettings get_panelSettings();
            /*0x1728900*/ void set_panelSettings(UnityEngine.UIElements.PanelSettings value);
            /*0x1728cac*/ UnityEngine.UIElements.UIDocument get_parentUI();
            /*0x1728cb4*/ void set_parentUI(UnityEngine.UIElements.UIDocument value);
            /*0x1728cbc*/ UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset();
            /*0x1728cc4*/ void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x1728520*/ UnityEngine.UIElements.VisualElement get_rootVisualElement();
            /*0x17290d0*/ int get_firstChildInserIndex();
            /*0x17290d8*/ float get_sortingOrder();
            /*0x17290e0*/ void set_sortingOrder(float value);
            /*0x17290f8*/ void ApplySortingOrder();
            /*0x1729240*/ void Awake();
            /*0x17292d4*/ void OnEnable();
            /*0x1729244*/ void SetupFromHierarchy();
            /*0x17293a4*/ UnityEngine.UIElements.UIDocument FindUIDocumentParent();
            /*0x1729474*/ void Reset();
            /*0x1729578*/ void AddChildAndInsertContentToVisualTree(UnityEngine.UIElements.UIDocument child);
            /*0x1729394*/ void RemoveChild(UnityEngine.UIElements.UIDocument child);
            /*0x1728ccc*/ void RecreateUI();
            /*0x17296d4*/ void SetupRootClassList();
            /*0x17290fc*/ void AddRootVisualElementToTree();
            /*0x1729608*/ void RemoveFromHierarchy();
            /*0x1729770*/ void OnDisable();
            /*0x1729790*/ void OnTransformChildrenChanged();
            /*0x1729a44*/ void OnTransformParentChanged();
            /*0x17299a0*/ void ReactToHierarchyChanged();
        }

        enum DynamicAtlasFiltersInternal
        {
            None = 0,
            Readability = 1,
            Size = 2,
            Format = 4,
            ColorSpace = 8,
            FilterMode = 16,
        }

        class DynamicAtlasSettings
        {
            /*0x10*/ int m_MinAtlasSize;
            /*0x14*/ int m_MaxAtlasSize;
            /*0x18*/ int m_MaxSubTextureSize;
            /*0x1c*/ UnityEngine.UIElements.DynamicAtlasFiltersInternal m_ActiveFilters;
            /*0x20*/ UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter;

            static /*0x1729a88*/ UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters();
            static /*0x1729aa0*/ UnityEngine.UIElements.DynamicAtlasSettings get_defaults();
            /*0x1729b20*/ DynamicAtlasSettings();
            /*0x1729a48*/ int get_minAtlasSize();
            /*0x1729a50*/ void set_minAtlasSize(int value);
            /*0x1729a58*/ int get_maxAtlasSize();
            /*0x1729a60*/ void set_maxAtlasSize(int value);
            /*0x1729a68*/ int get_maxSubTextureSize();
            /*0x1729a70*/ void set_maxSubTextureSize(int value);
            /*0x1729a78*/ UnityEngine.UIElements.DynamicAtlasFilters get_activeFilters();
            /*0x1729a80*/ void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value);
            /*0x1729a90*/ UnityEngine.UIElements.DynamicAtlasCustomFilter get_customFilter();
            /*0x1729a98*/ void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value);
        }

        class RuntimePanel : UnityEngine.UIElements.BaseRuntimePanel
        {
            static /*0x0*/ UnityEngine.UIElements.EventDispatcher s_EventDispatcher;
            /*0x1d8*/ UnityEngine.UIElements.PanelSettings m_PanelSettings;

            static /*0x172a488*/ RuntimePanel();
            static /*0x1729b30*/ UnityEngine.UIElements.RuntimePanel Create(UnityEngine.ScriptableObject ownerObject);
            /*0x1729b90*/ RuntimePanel(UnityEngine.ScriptableObject ownerObject);
            /*0x1729b28*/ UnityEngine.UIElements.PanelSettings get_panelSettings();
            /*0x1729e0c*/ void Update();
        }

        class RuntimeEventDispatcher
        {
            static /*0x172a4d4*/ UnityEngine.UIElements.EventDispatcher Create();
        }

        class NavigateFocusRing : UnityEngine.UIElements.IFocusRing
        {
            static /*0x0*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Left;
            static /*0x8*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Right;
            static /*0x10*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Up;
            static /*0x18*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Down;
            static /*0x20*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Next;
            static /*0x28*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Previous;
            /*0x10*/ UnityEngine.UIElements.VisualElement m_Root;
            /*0x18*/ UnityEngine.UIElements.VisualElementFocusRing m_Ring;

            static /*0x172ba78*/ NavigateFocusRing();
            static /*0x172b764*/ bool IsActive(UnityEngine.UIElements.VisualElement v);
            static /*0x172b83c*/ bool IsFocusable(UnityEngine.UIElements.Focusable focusable);
            static /*0x172b87c*/ bool IsLeaf(UnityEngine.UIElements.Focusable focusable);
            static /*0x172b8bc*/ bool IsFocusRoot(UnityEngine.UIElements.VisualElement focusable);
            static /*0x172b704*/ UnityEngine.UIElements.VisualElement GetLeafFocusable(UnityEngine.UIElements.VisualElement v);
            static /*0x172b96c*/ UnityEngine.UIElements.VisualElement GetLeafFocusableRecursive(UnityEngine.UIElements.VisualElement v);
            static /*0x172b540*/ UnityEngine.UIElements.VisualElement GetRootFocusable(UnityEngine.UIElements.VisualElement v);
            /*0x1729d88*/ NavigateFocusRing(UnityEngine.UIElements.VisualElement root);
            /*0x172a8a0*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x172a8c4*/ UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e);
            /*0x172acfc*/ UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction);
            /*0x172afb0*/ UnityEngine.UIElements.Focusable GetNextFocusable2D(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction);

            class ChangeDirection : UnityEngine.UIElements.FocusChangeDirection
            {
                /*0x172bba4*/ ChangeDirection(int i);
            }

            struct FocusableHierarchyTraversal
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement currentFocusable;
                /*0x18*/ UnityEngine.Rect validRect;
                /*0x28*/ bool firstPass;
                /*0x30*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction;

                /*0x172bc0c*/ bool ValidateHierarchyTraversal(UnityEngine.UIElements.VisualElement v);
                /*0x172bcbc*/ bool ValidateElement(UnityEngine.UIElements.VisualElement v);
                /*0x172bd80*/ int Order(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b);
                /*0x172c194*/ int StrictOrder(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b);
                /*0x172be6c*/ int StrictOrder(UnityEngine.Rect ra, UnityEngine.Rect rb);
                /*0x172c060*/ int TieBreaker(UnityEngine.Rect ra, UnityEngine.Rect rb);
                /*0x172b5c8*/ UnityEngine.UIElements.VisualElement GetBestOverall(UnityEngine.UIElements.VisualElement candidate, UnityEngine.UIElements.VisualElement bestSoFar);
            }
        }

        enum PanelScaleMode
        {
            ConstantPixelSize = 0,
            ConstantPhysicalSize = 1,
            ScaleWithScreenSize = 2,
        }

        enum PanelScreenMatchMode
        {
            MatchWidthOrHeight = 0,
            Shrink = 1,
            Expand = 2,
        }

        class PanelSettings : UnityEngine.ScriptableObject
        {
            static int k_DefaultSortingOrder = 0;
            static float k_DefaultScaleValue = 1;
            static string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";
            static float DefaultDpi = 96;
            /*0x18*/ UnityEngine.UIElements.ThemeStyleSheet themeUss;
            /*0x20*/ UnityEngine.RenderTexture m_TargetTexture;
            /*0x28*/ UnityEngine.UIElements.PanelScaleMode m_ScaleMode;
            /*0x2c*/ float m_Scale;
            /*0x30*/ float m_ReferenceDpi;
            /*0x34*/ float m_FallbackDpi;
            /*0x38*/ UnityEngine.Vector2Int m_ReferenceResolution;
            /*0x40*/ UnityEngine.UIElements.PanelScreenMatchMode m_ScreenMatchMode;
            /*0x44*/ float m_Match;
            /*0x48*/ float m_SortingOrder;
            /*0x4c*/ int m_TargetDisplay;
            /*0x50*/ bool m_ClearDepthStencil;
            /*0x51*/ bool m_ClearColor;
            /*0x54*/ UnityEngine.Color m_ColorClearValue;
            /*0x68*/ UnityEngine.UIElements.PanelSettings.RuntimePanelAccess m_PanelAccess;
            /*0x70*/ UnityEngine.UIElements.UIDocumentList m_AttachedUIDocumentsList;
            /*0x78*/ UnityEngine.UIElements.DynamicAtlasSettings m_DynamicAtlasSettings;
            /*0x80*/ UnityEngine.Shader m_AtlasBlitShader;
            /*0x88*/ UnityEngine.Shader m_RuntimeShader;
            /*0x90*/ UnityEngine.Shader m_RuntimeWorldShader;
            /*0x98*/ UnityEngine.UIElements.PanelTextSettings textSettings;
            /*0xa0*/ UnityEngine.Rect m_TargetRect;
            /*0xb0*/ float m_ResolvedScale;
            /*0xb8*/ UnityEngine.UIElements.StyleSheet m_OldThemeUss;
            /*0xc0*/ int m_EmptyPanelCounter;
            /*0xc4*/ float <ScreenDPI>k__BackingField;
            /*0xc8*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> m_AssignedScreenToPanel;

            /*0x172c754*/ PanelSettings();
            /*0x172c218*/ UnityEngine.UIElements.ThemeStyleSheet get_themeStyleSheet();
            /*0x172c220*/ void set_themeStyleSheet(UnityEngine.UIElements.ThemeStyleSheet value);
            /*0x172c388*/ UnityEngine.RenderTexture get_targetTexture();
            /*0x172c390*/ void set_targetTexture(UnityEngine.RenderTexture value);
            /*0x172c3ec*/ UnityEngine.UIElements.PanelScaleMode get_scaleMode();
            /*0x172c3f4*/ void set_scaleMode(UnityEngine.UIElements.PanelScaleMode value);
            /*0x172c3fc*/ float get_scale();
            /*0x172c404*/ void set_scale(float value);
            /*0x172c40c*/ float get_referenceDpi();
            /*0x172c414*/ void set_referenceDpi(float value);
            /*0x172c440*/ float get_fallbackDpi();
            /*0x172c448*/ void set_fallbackDpi(float value);
            /*0x172c474*/ UnityEngine.Vector2Int get_referenceResolution();
            /*0x172c47c*/ void set_referenceResolution(UnityEngine.Vector2Int value);
            /*0x172c484*/ UnityEngine.UIElements.PanelScreenMatchMode get_screenMatchMode();
            /*0x172c48c*/ void set_screenMatchMode(UnityEngine.UIElements.PanelScreenMatchMode value);
            /*0x172c494*/ float get_match();
            /*0x172c49c*/ void set_match(float value);
            /*0x172c4a4*/ float get_sortingOrder();
            /*0x172c4ac*/ void set_sortingOrder(float value);
            /*0x172c4cc*/ void ApplySortingOrder();
            /*0x172c518*/ int get_targetDisplay();
            /*0x172c520*/ void set_targetDisplay(int value);
            /*0x172c57c*/ bool get_clearDepthStencil();
            /*0x172c584*/ void set_clearDepthStencil(bool value);
            /*0x172c590*/ float get_depthClearValue();
            /*0x172c59c*/ bool get_clearColor();
            /*0x172c5a4*/ void set_clearColor(bool value);
            /*0x172c5b0*/ UnityEngine.Color get_colorClearValue();
            /*0x172c5bc*/ void set_colorClearValue(UnityEngine.Color value);
            /*0x172c5c8*/ UnityEngine.UIElements.BaseRuntimePanel get_panel();
            /*0x172c718*/ UnityEngine.UIElements.VisualElement get_visualTree();
            /*0x172c744*/ UnityEngine.UIElements.DynamicAtlasSettings get_dynamicAtlasSettings();
            /*0x172c74c*/ void set_dynamicAtlasSettings(UnityEngine.UIElements.DynamicAtlasSettings value);
            /*0x172c830*/ void Reset();
            /*0x172c834*/ void OnEnable();
            /*0x172cac8*/ void OnDisable();
            /*0x172cb14*/ void DisposePanel();
            /*0x172cb40*/ float get_ScreenDPI();
            /*0x172cb48*/ void set_ScreenDPI(float value);
            /*0x172c93c*/ void UpdateScreenDPI();
            /*0x172c22c*/ void ApplyThemeStyleSheet(UnityEngine.UIElements.VisualElement root);
            /*0x172c958*/ void InitializeShaders();
            /*0x1729e8c*/ void ApplyPanelSettings();
            /*0x172ce34*/ void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2, UnityEngine.Vector2> screentoPanelSpaceFunction);
            /*0x172cd1c*/ float ResolveScale(UnityEngine.Rect targetRect, float screenDpi);
            /*0x172cb60*/ UnityEngine.Rect GetDisplayRect();
            /*0x1728c18*/ void AttachAndInsertUIDocumentToVisualTree(UnityEngine.UIElements.UIDocument uiDocument);
            /*0x1728b9c*/ void DetachUIDocument(UnityEngine.UIElements.UIDocument uiDocument);

            class RuntimePanelAccess
            {
                /*0x10*/ UnityEngine.UIElements.PanelSettings m_Settings;
                /*0x18*/ UnityEngine.UIElements.BaseRuntimePanel m_RuntimePanel;

                /*0x172c808*/ RuntimePanelAccess(UnityEngine.UIElements.PanelSettings settings);
                /*0x172cb50*/ bool get_isInitialized();
                /*0x172c5e0*/ UnityEngine.UIElements.BaseRuntimePanel get_panel();
                /*0x172caf4*/ void DisposePanel();
                /*0x172c3c4*/ void SetTargetTexture();
                /*0x172c4e4*/ void SetSortingPriority();
                /*0x172c554*/ void SetTargetDisplay();
                /*0x172cec0*/ UnityEngine.UIElements.BaseRuntimePanel CreateRelatedRuntimePanel();
                /*0x172cfb8*/ void DisposeRelatedPanel();
                /*0x172ce64*/ void MarkPotentiallyEmpty();
            }
        }

        class PopupWindow : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string contentUssClassName;
            /*0x478*/ UnityEngine.UIElements.VisualElement m_ContentContainer;

            static /*0x172d148*/ PopupWindow();
            /*0x172d014*/ PopupWindow();
            /*0x172d140*/ UnityEngine.UIElements.VisualElement get_contentContainer();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.PopupWindow, UnityEngine.UIElements.PopupWindow.UxmlTraits>
            {
                /*0x1724914*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x172d1e8*/ UxmlTraits();
            }
        }

        class TreeView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string s_ListViewName;
            static /*0x8*/ string s_ItemName;
            static /*0x10*/ string s_ItemToggleName;
            static /*0x18*/ string s_ItemIndentsContainerName;
            static /*0x20*/ string s_ItemIndentName;
            static /*0x28*/ string s_ItemContentContainerName;
            /*0x3b0*/ System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;
            /*0x3b8*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onItemsChosen;
            /*0x3c0*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onSelectionChange;
            /*0x3c8*/ System.Collections.Generic.List<UnityEngine.UIElements.ITreeViewItem> m_SelectedItems;
            /*0x3d0*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> m_BindItem;
            /*0x3d8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> <unbindItem>k__BackingField;
            /*0x3e0*/ System.Collections.Generic.IList<UnityEngine.UIElements.ITreeViewItem> m_RootItems;
            /*0x3e8*/ System.Collections.Generic.List<int> m_ExpandedItemIds;
            /*0x3f0*/ System.Collections.Generic.List<UnityEngine.UIElements.TreeView.TreeViewItemWrapper> m_ItemWrappers;
            /*0x3f8*/ UnityEngine.UIElements.ListView m_ListView;
            /*0x400*/ UnityEngine.UIElements.ScrollView m_ScrollView;

            static /*0x1730348*/ TreeView();
            static /*0x172d8ec*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> GetAllItems(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems);
            /*0x172d270*/ TreeView();
            /*0x172d1f0*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> get_unbindItem();
            /*0x172d1f8*/ void set_itemHeight(int value);
            /*0x172d218*/ void set_showBorder(bool value);
            /*0x172d238*/ void set_selectionType(UnityEngine.UIElements.SelectionType value);
            /*0x172d254*/ void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value);
            /*0x172d7c4*/ void RefreshItems();
            /*0x172d88c*/ void Rebuild();
            /*0x172d8b0*/ void OnViewDataReady();
            /*0x172d994*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x172d870*/ void ListViewRefresh();
            /*0x172e040*/ void OnItemsChosen(System.Collections.Generic.IEnumerable<object> chosenItems);
            /*0x172e460*/ void OnSelectionChange(System.Collections.Generic.IEnumerable<object> selectedListItems);
            /*0x172e8b4*/ void OnTreeViewMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x172e8ec*/ void OnItemMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x172f0e8*/ UnityEngine.UIElements.VisualElement MakeTreeItem();
            /*0x172f5c8*/ void UnbindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x172f6e4*/ void BindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x172fa40*/ int GetItemId(int index);
            /*0x172da50*/ bool IsExpandedByIndex(int index);
            /*0x172ddf4*/ void CollapseItemByIndex(int index);
            /*0x172daec*/ void ExpandItemByIndex(int index);
            /*0x1730074*/ void ToggleExpandedState(UnityEngine.UIElements.ChangeEvent<bool> evt);
            /*0x172fb54*/ void CreateWrappers(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> treeViewItems, int depth, ref System.Collections.Generic.List<UnityEngine.UIElements.TreeView.TreeViewItemWrapper> wrappers);
            /*0x172d7e8*/ void RegenerateWrappers();
            /*0x17301f8*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TreeView, UnityEngine.UIElements.TreeView.UxmlTraits>
            {
                /*0x172495c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_ItemHeight;
                /*0x78*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;
                /*0x88*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

                /*0x17306b4*/ UxmlTraits();
                /*0x1730454*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            struct TreeViewItemWrapper
            {
                /*0x10*/ int depth;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem item;

                /*0x172fab4*/ int get_id();
            }

            class <GetAllItems>d__64 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems;
                /*0x30*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> <>3__rootItems;
                /*0x38*/ System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>> <iteratorStack>5__1;
                /*0x40*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> <currentIterator>5__2;
                /*0x48*/ bool <hasNext>5__3;
                /*0x50*/ UnityEngine.UIElements.ITreeViewItem <currentItem>5__4;

                /*0x172d950*/ <GetAllItems>d__64(int <>1__state);
                /*0x17308bc*/ void System.IDisposable.Dispose();
                /*0x17308c0*/ bool MoveNext();
                /*0x1730cb8*/ UnityEngine.UIElements.ITreeViewItem System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>.get_Current();
                /*0x1730cc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1730d00*/ object System.Collections.IEnumerator.get_Current();
                /*0x1730d08*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>.GetEnumerator();
                /*0x1730da8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class Label : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;

            static /*0x1730dfc*/ Label();
            /*0x1730dac*/ Label();
            /*0x1726b04*/ Label(string text);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Label, UnityEngine.UIElements.Label.UxmlTraits>
            {
                /*0x1724884*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x1730e5c*/ UxmlTraits();
            }
        }

        class Slider : UnityEngine.UIElements.BaseSlider<float>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;

            static /*0x1731560*/ Slider();
            /*0x1730e64*/ Slider();
            /*0x1730fc8*/ Slider(float start, float end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            /*0x1730e7c*/ Slider(string label, float start, float end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            /*0x1730fd4*/ float SliderLerpUnclamped(float a, float b, float interpolant);
            /*0x1731284*/ float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue);
            /*0x1731294*/ float ParseStringToValue(string stringValue);
            /*0x1731364*/ void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<float> sliderKey, bool isShift);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Slider, UnityEngine.UIElements.Slider.UxmlTraits>
            {
                /*0x17248cc*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<float, UnityEngine.UIElements.UxmlFloatAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;
                /*0x90*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;
                /*0x98*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_PageSize;
                /*0xa0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowInputField;
                /*0xa8*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;
                /*0xb0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Inverted;

                /*0x17318e4*/ UxmlTraits();
                /*0x1731630*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class KeyboardTextEditorEventHandler : UnityEngine.UIElements.TextEditorEventHandler
        {
            /*0x20*/ bool m_Changed;
            /*0x21*/ bool m_Dragged;
            /*0x22*/ bool m_DragToPosition;
            /*0x23*/ bool m_SelectAllOnMouseUp;
            /*0x28*/ string m_PreDrawCursorText;
            /*0x30*/ bool m_IsClicking;
            /*0x34*/ UnityEngine.Vector2 m_ClickStartPosition;
            /*0x40*/ UnityEngine.Event m_ImguiEvent;

            /*0x1731b48*/ KeyboardTextEditorEventHandler(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField);
            /*0x1731b0c*/ bool get_isClicking();
            /*0x1731b14*/ void set_isClicking(bool value);
            /*0x1731bc8*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x1732184*/ void OnFocus(UnityEngine.UIElements.FocusEvent _);
            /*0x1732314*/ void OnBlur(UnityEngine.UIElements.BlurEvent _);
            /*0x1732320*/ void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt);
            /*0x1732714*/ void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x173287c*/ void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt);
            /*0x173394c*/ void ProcessDragMove(UnityEngine.UIElements.MouseMoveEvent evt);
            /*0x1733928*/ bool MoveDistanceQualifiesForDrag(UnityEngine.Vector2 start, UnityEngine.Vector2 current);
            /*0x17329c4*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x1732fcc*/ void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent evt);
            /*0x1733330*/ void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent evt);
            /*0x1733a80*/ void PreDrawCursor(string newText);
            /*0x1733dc0*/ void PostDrawCursor();
        }

        enum ScrollViewMode
        {
            Vertical = 0,
            Horizontal = 1,
            VerticalAndHorizontal = 2,
        }

        enum ScrollerVisibility
        {
            Auto = 0,
            AlwaysVisible = 1,
            Hidden = 2,
        }

        class ScrollView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ float k_DefaultScrollDecelerationRate;
            static /*0x4*/ float k_DefaultElasticity;
            static /*0x8*/ string ussClassName;
            static /*0x10*/ string viewportUssClassName;
            static /*0x18*/ string contentAndVerticalScrollUssClassName;
            static /*0x20*/ string contentUssClassName;
            static /*0x28*/ string hScrollerUssClassName;
            static /*0x30*/ string vScrollerUssClassName;
            static /*0x38*/ string horizontalVariantUssClassName;
            static /*0x40*/ string verticalVariantUssClassName;
            static /*0x48*/ string verticalHorizontalVariantUssClassName;
            static /*0x50*/ string scrollVariantUssClassName;
            /*0x3b0*/ UnityEngine.UIElements.ScrollerVisibility m_HorizontalScrollerVisibility;
            /*0x3b4*/ UnityEngine.UIElements.ScrollerVisibility m_VerticalScrollerVisibility;
            /*0x3b8*/ UnityEngine.UIElements.VisualElement m_AttachedRootVisualContainer;
            /*0x3c0*/ float m_SingleLineHeight;
            /*0x3c4*/ float m_HorizontalPageSize;
            /*0x3c8*/ float m_VerticalPageSize;
            /*0x3cc*/ float m_ScrollDecelerationRate;
            /*0x3d0*/ float m_Elasticity;
            /*0x3d4*/ UnityEngine.UIElements.ScrollView.TouchScrollBehavior m_TouchScrollBehavior;
            /*0x3d8*/ UnityEngine.UIElements.ScrollView.NestedInteractionKind m_NestedInteractionKind;
            /*0x3e0*/ UnityEngine.UIElements.VisualElement <contentViewport>k__BackingField;
            /*0x3e8*/ UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField;
            /*0x3f0*/ UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField;
            /*0x3f8*/ UnityEngine.UIElements.VisualElement m_ContentContainer;
            /*0x400*/ UnityEngine.UIElements.VisualElement m_ContentAndVerticalScrollContainer;
            /*0x408*/ UnityEngine.UIElements.ScrollViewMode m_Mode;
            /*0x40c*/ int m_ScrollingPointerId;
            /*0x410*/ UnityEngine.Vector2 m_StartPosition;
            /*0x418*/ UnityEngine.Vector2 m_PointerStartPosition;
            /*0x420*/ UnityEngine.Vector2 m_Velocity;
            /*0x428*/ UnityEngine.Vector2 m_SpringBackVelocity;
            /*0x430*/ UnityEngine.Vector2 m_LowBounds;
            /*0x438*/ UnityEngine.Vector2 m_HighBounds;
            /*0x440*/ float m_LastVelocityLerpTime;
            /*0x444*/ bool m_StartedMoving;
            /*0x445*/ bool m_TouchStoppedVelocity;
            /*0x448*/ UnityEngine.UIElements.VisualElement m_CapturedTarget;
            /*0x450*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerMoveEvent> m_CapturedTargetPointerMoveCallback;
            /*0x458*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent> m_CapturedTargetPointerUpCallback;
            /*0x460*/ UnityEngine.UIElements.IVisualElementScheduledItem m_PostPointerUpAnimation;

            static /*0x1738cec*/ ScrollView();
            static /*0x173731c*/ float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit);
            /*0x17357dc*/ ScrollView();
            /*0x17357e4*/ ScrollView(UnityEngine.UIElements.ScrollViewMode scrollViewMode);
            /*0x1733de4*/ UnityEngine.UIElements.ScrollerVisibility get_horizontalScrollerVisibility();
            /*0x1733dec*/ void set_horizontalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value);
            /*0x1734410*/ UnityEngine.UIElements.ScrollerVisibility get_verticalScrollerVisibility();
            /*0x1734418*/ void set_verticalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value);
            /*0x17344a8*/ void set_showHorizontal(bool value);
            /*0x17344c4*/ void set_showVertical(bool value);
            /*0x1733e78*/ bool get_needsHorizontal();
            /*0x1733eb8*/ bool get_needsVertical();
            /*0x17345e8*/ bool get_isVerticalScrollDisplayed();
            /*0x17346a8*/ bool get_isHorizontalScrollDisplayed();
            /*0x1734768*/ UnityEngine.Vector2 get_scrollOffset();
            /*0x17347b0*/ void set_scrollOffset(UnityEngine.Vector2 value);
            /*0x1734a9c*/ void set_horizontalPageSize(float value);
            /*0x1734cb0*/ void set_verticalPageSize(float value);
            /*0x17344e0*/ float get_scrollableWidth();
            /*0x1734564*/ float get_scrollableHeight();
            /*0x1734ec4*/ bool get_hasInertia();
            /*0x1734ed4*/ float get_scrollDecelerationRate();
            /*0x1734edc*/ void set_scrollDecelerationRate(float value);
            /*0x1734eec*/ float get_elasticity();
            /*0x1734ef4*/ void set_elasticity(float value);
            /*0x1734f04*/ UnityEngine.UIElements.ScrollView.TouchScrollBehavior get_touchScrollBehavior();
            /*0x1734f0c*/ void set_touchScrollBehavior(UnityEngine.UIElements.ScrollView.TouchScrollBehavior value);
            /*0x1734fa4*/ UnityEngine.UIElements.ScrollView.NestedInteractionKind get_nestedInteractionKind();
            /*0x1734fac*/ void set_nestedInteractionKind(UnityEngine.UIElements.ScrollView.NestedInteractionKind value);
            /*0x1734fb4*/ void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1735048*/ void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1734aa4*/ void UpdateHorizontalSliderPageSize();
            /*0x1734cb8*/ void UpdateVerticalSliderPageSize();
            /*0x1734834*/ void UpdateContentViewTransform();
            /*0x17350dc*/ void ScrollTo(UnityEngine.UIElements.VisualElement child);
            /*0x17354dc*/ float GetXDeltaOffset(UnityEngine.UIElements.VisualElement child);
            /*0x1735264*/ float GetYDeltaOffset(UnityEngine.UIElements.VisualElement child);
            /*0x1735754*/ float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax);
            /*0x17357a4*/ UnityEngine.UIElements.VisualElement get_contentViewport();
            /*0x17357ac*/ void set_contentViewport(UnityEngine.UIElements.VisualElement value);
            /*0x17357b4*/ UnityEngine.UIElements.Scroller get_horizontalScroller();
            /*0x17357bc*/ void set_horizontalScroller(UnityEngine.UIElements.Scroller value);
            /*0x17357c4*/ UnityEngine.UIElements.Scroller get_verticalScroller();
            /*0x17357cc*/ void set_verticalScroller(UnityEngine.UIElements.Scroller value);
            /*0x17357d4*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x173634c*/ UnityEngine.UIElements.ScrollViewMode get_mode();
            /*0x1736354*/ void set_mode(UnityEngine.UIElements.ScrollViewMode value);
            /*0x17361e4*/ void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode mode);
            /*0x1736368*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x17368e0*/ void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x1736d40*/ void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent evt);
            /*0x1736e3c*/ void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt);
            /*0x17371c8*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1737408*/ void ComputeInitialSpringBackVelocity();
            /*0x1737504*/ void SpringBack();
            /*0x1737690*/ void ApplyScrollInertia();
            /*0x1737848*/ void PostPointerUpAnimation();
            /*0x1737998*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x1737d0c*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x17382f4*/ void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x1738354*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x1737bd0*/ void InitTouchScrolling(UnityEngine.Vector2 position);
            /*0x1737f08*/ UnityEngine.UIElements.ScrollView.TouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2 position);
            /*0x17383fc*/ bool ApplyTouchScrolling(UnityEngine.Vector2 newScrollOffset);
            /*0x1736efc*/ bool ReleaseScrolling(int pointerId, UnityEngine.UIElements.IEventHandler target);
            /*0x1738610*/ void AdjustScrollers();
            /*0x1733ef8*/ void UpdateScrollers(bool displayHorizontal, bool displayVertical);
            /*0x17387ac*/ void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x173895c*/ void OnScrollWheel(UnityEngine.UIElements.WheelEvent evt);
            /*0x1738ce8*/ void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt);
            /*0x17367d4*/ void ReadSingleLineHeight();
            /*0x1738f24*/ void <.ctor>b__103_0(float value);
            /*0x1738f54*/ void <.ctor>b__103_1(float value);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ScrollView, UnityEngine.UIElements.ScrollView.UxmlTraits>
            {
                /*0x1a4d438*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollViewMode> m_ScrollViewMode;
                /*0x78*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.NestedInteractionKind> m_NestedInteractionKind;
                /*0x80*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowHorizontal;
                /*0x88*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowVertical;
                /*0x90*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_HorizontalScrollerVisibility;
                /*0x98*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_VerticalScrollerVisibility;
                /*0xa0*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HorizontalPageSize;
                /*0xa8*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_VerticalPageSize;
                /*0xb0*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.TouchScrollBehavior> m_TouchScrollBehavior;
                /*0xb8*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_ScrollDecelerationRate;
                /*0xc0*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_Elasticity;

                /*0x1a4d810*/ UxmlTraits();
                /*0x1a4d480*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            enum TouchScrollBehavior
            {
                Unrestricted = 0,
                Elastic = 1,
                Clamped = 2,
            }

            enum NestedInteractionKind
            {
                Default = 0,
                StopScrolling = 1,
                ForwardScrolling = 2,
            }

            enum TouchScrollingResult
            {
                Apply = 0,
                Forward = 1,
                Block = 2,
            }
        }

        class RepeatButton : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;
            /*0x478*/ UnityEngine.UIElements.Clickable m_Clickable;

            static /*0x1a4dd90*/ RepeatButton();
            /*0x1a4dc18*/ RepeatButton();
            /*0x1a4dcac*/ RepeatButton(System.Action clickEvent, long delay, long interval);
            /*0x1a4dcec*/ void SetAction(System.Action clickEvent, long delay, long interval);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.RepeatButton, UnityEngine.UIElements.RepeatButton.UxmlTraits>
            {
                /*0x1a4ddf0*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x90*/ UnityEngine.UIElements.UxmlLongAttributeDescription m_Delay;
                /*0x98*/ UnityEngine.UIElements.UxmlLongAttributeDescription m_Interval;

                /*0x1a4df6c*/ UxmlTraits();
                /*0x1a4de38*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class DropdownField : UnityEngine.UIElements.BaseField<string>
        {
            static /*0x0*/ string ussClassNameBasePopupField;
            static /*0x8*/ string textUssClassNameBasePopupField;
            static /*0x10*/ string arrowUssClassNameBasePopupField;
            static /*0x18*/ string labelUssClassNameBasePopupField;
            static /*0x20*/ string inputUssClassNameBasePopupField;
            static /*0x28*/ string ussClassNamePopupField;
            static /*0x30*/ string labelUssClassNamePopupField;
            static /*0x38*/ string inputUssClassNamePopupField;
            /*0x408*/ System.Collections.Generic.List<string> m_Choices;
            /*0x410*/ UnityEngine.UIElements.TextElement m_TextElement;
            /*0x418*/ UnityEngine.UIElements.VisualElement m_ArrowElement;
            /*0x420*/ System.Func<string, string> m_FormatSelectedValueCallback;
            /*0x428*/ System.Func<string, string> m_FormatListItemCallback;
            /*0x430*/ System.Func<UnityEngine.UIElements.IGenericMenu> createMenuCallback;
            /*0x438*/ int m_Index;

            static /*0x1a4f124*/ DropdownField();
            /*0x1a4e20c*/ DropdownField();
            /*0x1a4e214*/ DropdownField(string label);
            /*0x1a4e030*/ UnityEngine.UIElements.TextElement get_textElement();
            /*0x1a4e038*/ string GetValueToDisplay();
            /*0x1a4e0c4*/ string GetListItemToDisplay(string value);
            /*0x1a4e170*/ void set_index(int value);
            /*0x1a4e524*/ void AddMenuItems(UnityEngine.UIElements.IGenericMenu menu);
            /*0x1a4e834*/ void ChangeValueFromMenu(string menuItem);
            /*0x1a4e844*/ void set_choices(System.Collections.Generic.List<string> value);
            /*0x1a4e8b4*/ string get_value();
            /*0x1a4e8fc*/ void set_value(string value);
            /*0x1a4e980*/ void SetValueWithoutNotify(string newValue);
            /*0x1a4ea90*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x1a4ec10*/ void ShowMenu();
            /*0x1a4f064*/ void UpdateMixedValueContent();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.DropdownField, UnityEngine.UIElements.DropdownField.UxmlTraits>
            {
                /*0x1a4f2b4*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseField.UxmlTraits<string>
            {
                /*0x80*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_Index;
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Choices;

                /*0x1a4f478*/ UxmlTraits();
                /*0x1a4f2fc*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            class PopupTextElement : UnityEngine.UIElements.TextElement
            {
                /*0x1a4e4cc*/ PopupTextElement();
                /*0x1a4f564*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ string item;
                /*0x18*/ UnityEngine.UIElements.DropdownField <>4__this;

                /*0x1a4e82c*/ <>c__DisplayClass38_0();
                /*0x1a4f608*/ void <AddMenuItems>b__0();
            }
        }

        class TextField : UnityEngine.UIElements.TextInputBaseField<string>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;

            static /*0x1a4fc38*/ TextField();
            /*0x1a4f7a4*/ TextField();
            /*0x1a4f7bc*/ TextField(string label);
            /*0x1a4f7d0*/ TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar);
            /*0x1a4f634*/ UnityEngine.UIElements.TextField.TextInput get_textInput();
            /*0x1a4f6b8*/ void set_multiline(bool value);
            /*0x1a4f9f4*/ string get_value();
            /*0x1a4fa3c*/ void set_value(string value);
            /*0x1a4fae0*/ void SetValueWithoutNotify(string newValue);
            /*0x1a4fb84*/ void OnViewDataReady();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TextField, UnityEngine.UIElements.TextField.UxmlTraits>
            {
                /*0x1a4fd08*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextInputBaseField.UxmlTraits<string>
            {
                /*0xb8*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Multiline;

                /*0x1a4fe64*/ UxmlTraits();
                /*0x1a4fd50*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            class TextInput : UnityEngine.UIElements.TextInputBaseField.TextInputBase<string>
            {
                /*0x410*/ bool m_Multiline;

                /*0x1a4f9ac*/ TextInput();
                /*0x1a4ff04*/ UnityEngine.UIElements.TextField get_parentTextField();
                /*0x1a4ff84*/ bool get_multiline();
                /*0x1a4f6d8*/ void set_multiline(bool value);
                /*0x1a4ff8c*/ void SetTextAlign();
                /*0x1a5002c*/ void set_isPasswordField(bool value);
                /*0x1a50088*/ string StringToValue(string str);
                /*0x1a50090*/ void SyncTextEngine();
                /*0x1a50120*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
                /*0x1a50850*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            }
        }

        class Scroller : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string horizontalVariantUssClassName;
            static /*0x10*/ string verticalVariantUssClassName;
            static /*0x18*/ string sliderUssClassName;
            static /*0x20*/ string lowButtonUssClassName;
            static /*0x28*/ string highButtonUssClassName;
            /*0x3b0*/ System.Action<float> valueChanged;
            /*0x3b8*/ UnityEngine.UIElements.Slider <slider>k__BackingField;
            /*0x3c0*/ UnityEngine.UIElements.RepeatButton <lowButton>k__BackingField;
            /*0x3c8*/ UnityEngine.UIElements.RepeatButton <highButton>k__BackingField;

            static /*0x1a515e8*/ Scroller();
            /*0x1a50f18*/ Scroller();
            /*0x1a50f2c*/ Scroller(float lowValue, float highValue, System.Action<float> valueChanged, UnityEngine.UIElements.SliderDirection direction);
            /*0x1a509dc*/ void add_valueChanged(System.Action<float> value);
            /*0x1a50a90*/ void remove_valueChanged(System.Action<float> value);
            /*0x1a50b44*/ UnityEngine.UIElements.Slider get_slider();
            /*0x1a50b4c*/ void set_slider(UnityEngine.UIElements.Slider value);
            /*0x1a50b54*/ UnityEngine.UIElements.RepeatButton get_lowButton();
            /*0x1a50b5c*/ void set_lowButton(UnityEngine.UIElements.RepeatButton value);
            /*0x1a50b64*/ UnityEngine.UIElements.RepeatButton get_highButton();
            /*0x1a50b6c*/ void set_highButton(UnityEngine.UIElements.RepeatButton value);
            /*0x1a50b74*/ float get_value();
            /*0x1a50b98*/ void set_value(float value);
            /*0x1a50bbc*/ float get_lowValue();
            /*0x1a50c0c*/ void set_lowValue(float value);
            /*0x1a50c6c*/ float get_highValue();
            /*0x1a50cbc*/ void set_highValue(float value);
            /*0x1a50d1c*/ void set_direction(UnityEngine.UIElements.SliderDirection value);
            /*0x1a512d4*/ void Adjust(float factor);
            /*0x1a5134c*/ void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<float> evt);
            /*0x1a513e8*/ void ScrollPageUp();
            /*0x1a514e8*/ void ScrollPageDown();
            /*0x1a513f0*/ void ScrollPageUp(float factor);
            /*0x1a514f0*/ void ScrollPageDown(float factor);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Scroller, UnityEngine.UIElements.Scroller.UxmlTraits>
            {
                /*0x1a51758*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;
                /*0x78*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_Value;

                /*0x1a5198c*/ UxmlTraits();
                /*0x1a517a0*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class Box : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;

            static /*0x1a51c7c*/ Box();
            /*0x1a51be8*/ Box();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Box>
            {
                /*0x1a51cdc*/ UxmlFactory();
            }
        }

        class BaseBoolField : UnityEngine.UIElements.BaseField<bool>
        {
            /*0x408*/ UnityEngine.UIElements.Label m_Label;
            /*0x410*/ UnityEngine.UIElements.VisualElement m_CheckMark;
            /*0x418*/ UnityEngine.UIElements.Clickable m_Clickable;
            /*0x420*/ string m_OriginalText;

            /*0x1a51d24*/ BaseBoolField(string label);
            /*0x1a52048*/ void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt);
            /*0x1a5207c*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x1a52190*/ string get_text();
            /*0x1a51fc0*/ void set_text(string value);
            /*0x1a521ac*/ void InitLabel();
            /*0x1a52240*/ void SetValueWithoutNotify(bool newValue);
            /*0x1a52320*/ void OnClickEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a525a8*/ void ToggleValue();
            /*0x1a525e0*/ void UpdateMixedValueContent();
        }

        enum ListViewReorderMode
        {
            Simple = 0,
            Animated = 1,
        }

        class ListView : UnityEngine.UIElements.BaseVerticalCollectionView
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string itemUssClassName;
            static /*0x10*/ string emptyLabelUssClassName;
            static /*0x18*/ string reorderableUssClassName;
            static /*0x20*/ string reorderableItemUssClassName;
            static /*0x28*/ string reorderableItemContainerUssClassName;
            static /*0x30*/ string reorderableItemHandleUssClassName;
            static /*0x38*/ string reorderableItemHandleBarUssClassName;
            static /*0x40*/ string footerUssClassName;
            static /*0x48*/ string foldoutHeaderUssClassName;
            static /*0x50*/ string arraySizeFieldUssClassName;
            static /*0x58*/ string listViewWithHeaderUssClassName;
            static /*0x60*/ string listViewWithFooterUssClassName;
            static /*0x68*/ string scrollViewWithFooterUssClassName;
            static /*0x70*/ string footerAddButtonName;
            static /*0x78*/ string footerRemoveButtonName;
            /*0x494*/ bool m_ShowBoundCollectionSize;
            /*0x495*/ bool m_ShowFoldoutHeader;
            /*0x498*/ string m_HeaderTitle;
            /*0x4a0*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsAdded;
            /*0x4a8*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsRemoved;
            /*0x4b0*/ UnityEngine.UIElements.Label m_EmptyListLabel;
            /*0x4b8*/ UnityEngine.UIElements.Foldout m_Foldout;
            /*0x4c0*/ UnityEngine.UIElements.TextField m_ArraySizeField;
            /*0x4c8*/ UnityEngine.UIElements.VisualElement m_Footer;
            /*0x4d0*/ UnityEngine.UIElements.Button m_AddButton;
            /*0x4d8*/ UnityEngine.UIElements.Button m_RemoveButton;
            /*0x4e0*/ System.Action<System.Collections.Generic.IEnumerable<int>> m_ItemAddedCallback;
            /*0x4e8*/ System.Action<System.Collections.Generic.IEnumerable<int>> m_ItemRemovedCallback;
            /*0x4f0*/ System.Action m_ItemsSourceSizeChangedCallback;
            /*0x4f8*/ UnityEngine.UIElements.ListViewController m_ListViewController;
            /*0x500*/ UnityEngine.UIElements.ListViewReorderMode m_ReorderMode;

            static /*0x1a540cc*/ ListView();
            /*0x1a5400c*/ ListView();
            /*0x1a52764*/ bool get_showBoundCollectionSize();
            /*0x1a5276c*/ void set_showBoundCollectionSize(bool value);
            /*0x1a5295c*/ bool get_sourceIncludesArraySize();
            /*0x1a52984*/ bool get_showFoldoutHeader();
            /*0x1a5298c*/ void set_showFoldoutHeader(bool value);
            /*0x1a52788*/ void SetupArraySizeField();
            /*0x1a534ec*/ void set_headerTitle(string value);
            /*0x1a53140*/ bool get_showAddRemoveFooter();
            /*0x1a53504*/ void set_showAddRemoveFooter(bool value);
            /*0x1a53150*/ void EnableFooter(bool enabled);
            /*0x1a536d4*/ void AddItems(int itemCount);
            /*0x1a536f8*/ void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<string> evt);
            /*0x1a5347c*/ void UpdateArraySizeField();
            /*0x1a52f84*/ void UpdateEmpty();
            /*0x1a53800*/ void OnAddClicked();
            /*0x1a53a4c*/ void OnRemoveClicked();
            /*0x1a53c18*/ UnityEngine.UIElements.ListViewController get_viewController();
            /*0x1a53c20*/ void CreateVirtualizationController();
            /*0x1a53c68*/ void CreateViewController();
            /*0x1a53ccc*/ void SetViewController(UnityEngine.UIElements.ListViewController controller);
            /*0x1a53e88*/ void OnItemAdded(System.Collections.Generic.IEnumerable<int> indices);
            /*0x1a53ea4*/ void OnItemsRemoved(System.Collections.Generic.IEnumerable<int> indices);
            /*0x1a53ec0*/ void OnItemsSourceSizeChanged();
            /*0x1a53ec8*/ UnityEngine.UIElements.ListViewReorderMode get_reorderMode();
            /*0x1a53ed0*/ void set_reorderMode(UnityEngine.UIElements.ListViewReorderMode value);
            /*0x1a53f08*/ UnityEngine.UIElements.ListViewDragger CreateDragger();
            /*0x1a53fa8*/ UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController();
            /*0x1a540a8*/ void PostRefresh();
            /*0x1a54418*/ void <OnAddClicked>b__35_0();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ListView, UnityEngine.UIElements.ListView.UxmlTraits>
            {
                /*0x1a544e8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedItemHeight;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.CollectionVirtualizationMethod> m_VirtualizationMethod;
                /*0x88*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;
                /*0x90*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;
                /*0x98*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;
                /*0xa0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowFoldoutHeader;
                /*0xa8*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_HeaderTitle;
                /*0xb0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowAddRemoveFooter;
                /*0xb8*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Reorderable;
                /*0xc0*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ListViewReorderMode> m_ReorderMode;
                /*0xc8*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBoundCollectionSize;
                /*0xd0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;

                /*0x1a54904*/ UxmlTraits();
                /*0x1a54530*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        interface IGenericMenu
        {
            void AddItem(string itemName, bool isChecked, System.Action action);
            void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, bool anchored);
        }

        class GenericDropdownMenu : UnityEngine.UIElements.IGenericMenu
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string itemUssClassName;
            static /*0x10*/ string labelUssClassName;
            static /*0x18*/ string containerInnerUssClassName;
            static /*0x20*/ string containerOuterUssClassName;
            static /*0x28*/ string checkmarkUssClassName;
            static /*0x30*/ string separatorUssClassName;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.GenericDropdownMenu.MenuItem> m_Items;
            /*0x18*/ UnityEngine.UIElements.VisualElement m_MenuContainer;
            /*0x20*/ UnityEngine.UIElements.VisualElement m_OuterContainer;
            /*0x28*/ UnityEngine.UIElements.ScrollView m_ScrollView;
            /*0x30*/ UnityEngine.UIElements.VisualElement m_PanelRootVisualContainer;
            /*0x38*/ UnityEngine.UIElements.VisualElement m_TargetElement;
            /*0x40*/ UnityEngine.Rect m_DesiredRect;
            /*0x50*/ UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator;
            /*0x58*/ UnityEngine.Vector2 m_MousePosition;

            static /*0x1a57454*/ GenericDropdownMenu();
            /*0x1a4ed90*/ GenericDropdownMenu();
            /*0x1a54e20*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x1a54e44*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x1a5527c*/ void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x1a55710*/ void Hide();
            /*0x1a55764*/ void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent);
            /*0x1a557a0*/ bool Apply(UnityEngine.UIElements.KeyboardNavigationOperation op);
            /*0x1a55b28*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x1a55d7c*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x1a55ea8*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x1a55fe4*/ void OnFocusOut(UnityEngine.UIElements.FocusOutEvent evt);
            /*0x1a5612c*/ void OnParentResized(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1a55c54*/ void UpdateSelection(UnityEngine.UIElements.VisualElement target);
            /*0x1a56130*/ void ChangeSelectedIndex(int newIndex, int previousIndex);
            /*0x1a55924*/ int GetSelectedIndex();
            /*0x1a56264*/ void AddItem(string itemName, bool isChecked, System.Action action);
            /*0x1a565cc*/ void AddSeparator(string path);
            /*0x1a5628c*/ UnityEngine.UIElements.GenericDropdownMenu.MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data);
            /*0x1a56684*/ void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, bool anchored);
            /*0x1a57450*/ void OnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1a56d6c*/ void EnsureVisibilityInParent();
            /*0x1a55a6c*/ void <Apply>g__UpdateSelectionDown|25_0(int newIndex, ref UnityEngine.UIElements.GenericDropdownMenu.<> );
            /*0x1a559c4*/ void <Apply>g__UpdateSelectionUp|25_1(int newIndex, ref UnityEngine.UIElements.GenericDropdownMenu.<> );

            class MenuItem
            {
                /*0x10*/ string name;
                /*0x18*/ UnityEngine.UIElements.VisualElement element;
                /*0x20*/ System.Action action;
                /*0x28*/ System.Action<object> actionUserData;

                /*0x1a5667c*/ MenuItem();
            }

            struct <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.UIElements.GenericDropdownMenu <>4__this;
                /*0x18*/ int selectedIndex;
            }
        }

        class RadioButton : UnityEngine.UIElements.BaseBoolField, UnityEngine.UIElements.IGroupBoxOption
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;
            static /*0x18*/ string checkmarkBackgroundUssClassName;
            static /*0x20*/ string checkmarkUssClassName;
            static /*0x28*/ string textUssClassName;
            /*0x428*/ UnityEngine.UIElements.VisualElement m_CheckmarkBackground;

            static /*0x1a57b78*/ RadioButton();
            /*0x1a57810*/ RadioButton();
            /*0x1a57818*/ RadioButton(string label);
            /*0x1a575f4*/ bool get_value();
            /*0x1a5763c*/ void set_value(bool value);
            /*0x1a579f0*/ void InitLabel();
            /*0x1a57a68*/ void ToggleValue();
            /*0x1a57aa8*/ void SetSelected(bool selected);
            /*0x1a57abc*/ void SetValueWithoutNotify(bool newValue);
            /*0x1a5771c*/ void UpdateCheckmark();
            /*0x1a57ad8*/ void UpdateMixedValueContent();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.RadioButton, UnityEngine.UIElements.RadioButton.UxmlTraits>
            {
                /*0x1a57ce8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<bool, UnityEngine.UIElements.UxmlBoolAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;

                /*0x1a57e48*/ UxmlTraits();
                /*0x1a57d30*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class Image : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> s_ImageProperty;
            static /*0x10*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> s_SpriteProperty;
            static /*0x18*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> s_VectorImageProperty;
            static /*0x20*/ UnityEngine.UIElements.CustomStyleProperty<string> s_ScaleModeProperty;
            static /*0x28*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_TintColorProperty;
            /*0x3b0*/ UnityEngine.ScaleMode m_ScaleMode;
            /*0x3b8*/ UnityEngine.Texture m_Image;
            /*0x3c0*/ UnityEngine.Sprite m_Sprite;
            /*0x3c8*/ UnityEngine.UIElements.VectorImage m_VectorImage;
            /*0x3d0*/ UnityEngine.Rect m_UV;
            /*0x3e0*/ UnityEngine.Color m_TintColor;
            /*0x3f0*/ bool m_ImageIsInline;
            /*0x3f1*/ bool m_ScaleModeIsInline;
            /*0x3f2*/ bool m_TintColorIsInline;

            static /*0x1a59070*/ Image();
            /*0x1a58178*/ Image();
            /*0x1a57ee8*/ UnityEngine.Texture get_image();
            /*0x1a57ef0*/ UnityEngine.Sprite get_sprite();
            /*0x1a57ef8*/ UnityEngine.UIElements.VectorImage get_vectorImage();
            /*0x1a57f00*/ UnityEngine.Rect get_sourceRect();
            /*0x1a58148*/ UnityEngine.Rect get_uv();
            /*0x1a5815c*/ UnityEngine.ScaleMode get_scaleMode();
            /*0x1a58164*/ UnityEngine.Color get_tintColor();
            /*0x1a58360*/ UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Texture texture);
            /*0x1a5843c*/ UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Sprite sprite);
            /*0x1a58544*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x1a58788*/ void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x1a58c54*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
            /*0x1a5904c*/ void SetScaleMode(UnityEngine.ScaleMode mode);
            /*0x1a57f04*/ UnityEngine.Rect GetSourceRect();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Image, UnityEngine.UIElements.Image.UxmlTraits>
            {
                /*0x1a5924c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x1a59294*/ UxmlTraits();
            }
        }

        interface IBindable
        {
            UnityEngine.UIElements.IBinding get_binding();
            void set_bindingPath(string value);
        }

        interface IBinding
        {
            void PreUpdate();
            void Update();
            void Release();
        }

        interface IInternalListViewBinding
        {
        }

        class Foldout : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.INotifyValueChanged<bool>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string toggleUssClassName;
            static /*0x10*/ string contentUssClassName;
            static /*0x18*/ string inputUssClassName;
            static /*0x20*/ string checkmarkUssClassName;
            static /*0x28*/ string textUssClassName;
            static /*0x30*/ string ussFoldoutDepthClassName;
            static /*0x38*/ int ussFoldoutMaxDepth;
            /*0x3c0*/ UnityEngine.UIElements.Toggle m_Toggle;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_Container;
            /*0x3d0*/ bool m_Value;

            static /*0x1a597b4*/ Foldout();
            /*0x1a52b30*/ Foldout();
            /*0x1a5929c*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x1a52e60*/ void set_text(string value);
            /*0x1a592a4*/ bool get_value();
            /*0x1a592ac*/ void set_value(bool value);
            /*0x1a5948c*/ void SetValueWithoutNotify(bool newValue);
            /*0x1a595ac*/ void OnViewDataReady();
            /*0x1a595f4*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x1a5995c*/ void <.ctor>b__23_0(UnityEngine.UIElements.ChangeEvent<bool> evt);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Foldout, UnityEngine.UIElements.Foldout.UxmlTraits>
            {
                /*0x1a599ac*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x80*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Value;

                /*0x1a59b24*/ UxmlTraits();
                /*0x1a599f4*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class TextEditorEngine : UnityEngine.TextEditor
        {
            /*0x90*/ UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction m_DetectFocusChangeFunction;
            /*0x98*/ UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction m_IndexChangeFunction;

            /*0x1a59c10*/ TextEditorEngine(UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction detectFocusChange, UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction indexChangeFunction);
            /*0x1a59c3c*/ UnityEngine.Rect get_localPosition();
            /*0x1a59cc4*/ void OnDetectFocusChange();
            /*0x1a59ce8*/ void OnCursorIndexChange();
            /*0x1a59d0c*/ void OnSelectIndexChange();

            class OnDetectFocusChangeFunction : System.MulticastDelegate
            {
                /*0x1a59d30*/ OnDetectFocusChangeFunction(object object, nint method);
                /*0x1a59dec*/ void Invoke();
            }

            class OnIndexChangeFunction : System.MulticastDelegate
            {
                /*0x1a59e00*/ OnIndexChangeFunction(object object, nint method);
                /*0x1a59ebc*/ void Invoke();
            }
        }

        class Toggle : UnityEngine.UIElements.BaseBoolField
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;
            static /*0x18*/ string noTextVariantUssClassName;
            static /*0x20*/ string checkmarkUssClassName;
            static /*0x28*/ string textUssClassName;

            static /*0x1a5a044*/ Toggle();
            /*0x1a595ec*/ Toggle();
            /*0x1a59ed0*/ Toggle(string label);
            /*0x1a59fcc*/ void InitLabel();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Toggle, UnityEngine.UIElements.Toggle.UxmlTraits>
            {
                /*0x1a5a1b4*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<bool, UnityEngine.UIElements.UxmlBoolAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;

                /*0x1a5a314*/ UxmlTraits();
                /*0x1a5a1fc*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class TextEditorEventHandler
        {
            /*0x10*/ UnityEngine.UIElements.TextEditorEngine <editorEngine>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.ITextInputField <textInputField>k__BackingField;

            /*0x1a5a3d4*/ TextEditorEventHandler(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField);
            /*0x1a5a3b4*/ UnityEngine.UIElements.TextEditorEngine get_editorEngine();
            /*0x1a5a3bc*/ void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value);
            /*0x1a5a3c4*/ UnityEngine.UIElements.ITextInputField get_textInputField();
            /*0x1a5a3cc*/ void set_textInputField(UnityEngine.UIElements.ITextInputField value);
            /*0x1a5a494*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x1a5a498*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
        }

        interface ITextInputField : UnityEngine.UIElements.IEventHandler, UnityEngine.UIElements.ITextElement
        {
            bool get_hasFocus();
            bool get_doubleClickSelectsWord();
            bool get_tripleClickSelectsLine();
            bool get_isReadOnly();
            bool get_isDelayed();
            bool get_isPasswordField();
            UnityEngine.UIElements.TextEditorEngine get_editorEngine();
            void SyncTextEngine();
            bool AcceptCharacter(char c);
            string CullString(string s);
            void UpdateText(string value);
            void UpdateValueFromText();
        }

        class TextInputBaseField<TValueType> : UnityEngine.UIElements.BaseField<TValueType>
        {
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty;
            static /*0x0*/ string ussClassName;
            static /*0x0*/ string labelUssClassName;
            static /*0x0*/ string inputUssClassName;
            static /*0x0*/ string singleLineInputUssClassName;
            static /*0x0*/ string multilineInputUssClassName;
            static /*0x0*/ string textInputUssName;
            /*0x0*/ int m_VisualInputTabIndex;
            /*0x0*/ UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> m_TextInputBase;
            /*0x0*/ UnityEngine.UIElements.ITextHandle <iTextHandle>k__BackingField;
            /*0x0*/ System.Action<bool> onIsReadOnlyChanged;

            static TextInputBaseField();
            TextInputBaseField(string label, int maxLength, char maskChar, UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInputBase);
            UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> get_textInputBase();
            void set_iTextHandle(UnityEngine.UIElements.ITextHandle value);
            void set_text(string value);
            void set_isReadOnly(bool value);
            void set_isPasswordField(bool value);
            void set_maxLength(int value);
            bool get_isDelayed();
            void set_isDelayed(bool value);
            void set_maskChar(char value);
            void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e);
            void OnFieldCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
            void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            void UpdateMixedValueContent();

            class UxmlTraits<TValueType> : UnityEngine.UIElements.BaseFieldTraits<string, UnityEngine.UIElements.UxmlStringAttributeDescription>
            {
                /*0x0*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_MaxLength;
                /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Password;
                /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_MaskCharacter;
                /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsReadOnly;
                /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsDelayed;

                UxmlTraits();
                void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            class TextInputBase<TValueType> : UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITextInputField, UnityEngine.UIElements.IEventHandler, UnityEngine.UIElements.ITextElement
            {
                /*0x0*/ string m_OriginalText;
                /*0x0*/ bool <isReadOnly>k__BackingField;
                /*0x0*/ int <maxLength>k__BackingField;
                /*0x0*/ char <maskChar>k__BackingField;
                /*0x0*/ bool <isPasswordField>k__BackingField;
                /*0x0*/ bool <doubleClickSelectsWord>k__BackingField;
                /*0x0*/ bool <tripleClickSelectsLine>k__BackingField;
                /*0x0*/ bool <isDelayed>k__BackingField;
                /*0x0*/ bool <isDragging>k__BackingField;
                /*0x0*/ bool m_TouchScreenTextFieldInitialized;
                /*0x0*/ UnityEngine.UIElements.IVisualElementScheduledItem m_HardwareKeyboardPoller;
                /*0x0*/ UnityEngine.Color m_SelectionColor;
                /*0x0*/ UnityEngine.Color m_CursorColor;
                /*0x0*/ UnityEngine.UIElements.TextEditorEventHandler <editorEventHandler>k__BackingField;
                /*0x0*/ UnityEngine.UIElements.TextEditorEngine <editorEngine>k__BackingField;
                /*0x0*/ UnityEngine.UIElements.ITextHandle m_TextHandle;
                /*0x0*/ string m_Text;

                static void SyncGUIStyle(UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInput, UnityEngine.GUIStyle style);
                static bool IsLayoutUsingPercent(UnityEngine.UIElements.VisualElement ve);
                static void AssignRect(UnityEngine.RectOffset rect, int left, int top, int right, int bottom);
                TextInputBase();
                void ResetValueAndText();
                void SaveValueAndText();
                void RestoreValueAndText();
                void UpdateText(string value);
                TValueType StringToValue(string str);
                void UpdateValueFromText();
                bool UnityEngine.UIElements.ITextInputField.get_isReadOnly();
                bool get_isReadOnly();
                void set_isReadOnly(bool value);
                int get_maxLength();
                void set_maxLength(int value);
                char get_maskChar();
                void set_maskChar(char value);
                bool get_isPasswordField();
                void set_isPasswordField(bool value);
                bool get_doubleClickSelectsWord();
                void set_doubleClickSelectsWord(bool value);
                bool get_tripleClickSelectsLine();
                void set_tripleClickSelectsLine(bool value);
                bool get_isDelayed();
                void set_isDelayed(bool value);
                bool get_isDragging();
                bool get_touchScreenTextField();
                bool get_touchScreenTextFieldChanged();
                UnityEngine.Color get_selectionColor();
                UnityEngine.Color get_cursorColor();
                bool get_hasFocus();
                UnityEngine.UIElements.TextEditorEventHandler get_editorEventHandler();
                void set_editorEventHandler(UnityEngine.UIElements.TextEditorEventHandler value);
                UnityEngine.UIElements.TextEditorEngine get_editorEngine();
                void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value);
                string get_text();
                void set_text(string value);
                void InitTextEditorEventHandler();
                UnityEngine.UIElements.DropdownMenuAction.Status CutActionStatus(UnityEngine.UIElements.DropdownMenuAction a);
                UnityEngine.UIElements.DropdownMenuAction.Status CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction a);
                UnityEngine.UIElements.DropdownMenuAction.Status PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction a);
                void ProcessMenuCommand(string command);
                void Cut(UnityEngine.UIElements.DropdownMenuAction a);
                void Copy(UnityEngine.UIElements.DropdownMenuAction a);
                void Paste(UnityEngine.UIElements.DropdownMenuAction a);
                void OnInputCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
                void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent attachEvent);
                void SyncTextEngine();
                string CullString(string s);
                void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
                void DrawWithTextSelectionAndCursor(UnityEngine.UIElements.MeshGenerationContext mgc, string newText, float pixelsPerPoint);
                bool AcceptCharacter(char c);
                void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent evt);
                void OnDetectFocusChange();
                void OnCursorIndexChange();
                UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
                void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt);
                void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
                void ProcessEventAtTarget(UnityEngine.UIElements.EventBase evt);
                void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
                bool UnityEngine.UIElements.ITextInputField.get_hasFocus();
                void UnityEngine.UIElements.ITextInputField.SyncTextEngine();
                bool UnityEngine.UIElements.ITextInputField.AcceptCharacter(char c);
                string UnityEngine.UIElements.ITextInputField.CullString(string s);
                void UnityEngine.UIElements.ITextInputField.UpdateText(string value);
                UnityEngine.UIElements.TextEditorEngine UnityEngine.UIElements.ITextInputField.get_editorEngine();
                bool UnityEngine.UIElements.ITextInputField.get_isDelayed();
                void UnityEngine.UIElements.ITextInputField.UpdateValueFromText();
                void DeferGUIStyleRectSync();
                void OnPercentResolved(UnityEngine.UIElements.GeometryChangedEvent evt);
                void <ProcessEventAtTarget>b__96_0();
            }
        }

        enum SliderDirection
        {
            Horizontal = 0,
            Vertical = 1,
        }

        class BaseSlider<TValueType> : UnityEngine.UIElements.BaseField<TValueType>
        {
            static /*0x0*/ string ussClassName;
            static /*0x0*/ string labelUssClassName;
            static /*0x0*/ string inputUssClassName;
            static /*0x0*/ string horizontalVariantUssClassName;
            static /*0x0*/ string verticalVariantUssClassName;
            static /*0x0*/ string dragContainerUssClassName;
            static /*0x0*/ string trackerUssClassName;
            static /*0x0*/ string draggerUssClassName;
            static /*0x0*/ string draggerBorderUssClassName;
            static /*0x0*/ string textFieldClassName;
            /*0x0*/ UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.TextField <inputTextField>k__BackingField;
            /*0x0*/ TValueType m_LowValue;
            /*0x0*/ TValueType m_HighValue;
            /*0x0*/ float m_PageSize;
            /*0x0*/ bool m_ShowInputField;
            /*0x0*/ bool <clamped>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.ClampedDragger<TValueType> <clampedDragger>k__BackingField;
            /*0x0*/ UnityEngine.Rect m_DragElementStartPos;
            /*0x0*/ UnityEngine.UIElements.SliderDirection m_Direction;
            /*0x0*/ bool m_Inverted;

            static BaseSlider();
            static float GetClosestPowerOfTen(float positiveNumber);
            static float RoundToMultipleOf(float value, float roundingValue);
            BaseSlider(string label, TValueType start, TValueType end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            UnityEngine.UIElements.VisualElement get_dragContainer();
            void set_dragContainer(UnityEngine.UIElements.VisualElement value);
            UnityEngine.UIElements.VisualElement get_dragElement();
            void set_dragElement(UnityEngine.UIElements.VisualElement value);
            UnityEngine.UIElements.VisualElement get_dragBorderElement();
            void set_dragBorderElement(UnityEngine.UIElements.VisualElement value);
            UnityEngine.UIElements.TextField get_inputTextField();
            void set_inputTextField(UnityEngine.UIElements.TextField value);
            TValueType get_lowValue();
            void set_lowValue(TValueType value);
            TValueType get_highValue();
            void set_highValue(TValueType value);
            void SetHighValueWithoutNotify(TValueType newHighValue);
            float get_pageSize();
            void set_pageSize(float value);
            bool get_showInputField();
            void set_showInputField(bool value);
            bool get_clamped();
            void set_clamped(bool value);
            UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger();
            void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value);
            TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound);
            TValueType GetClampedValue(TValueType newValue);
            TValueType get_value();
            void set_value(TValueType value);
            void SetValueWithoutNotify(TValueType newValue);
            UnityEngine.UIElements.SliderDirection get_direction();
            void set_direction(UnityEngine.UIElements.SliderDirection value);
            bool get_inverted();
            void set_inverted(bool value);
            void ClampValue();
            TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);
            float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);
            TValueType ParseStringToValue(string stringValue);
            void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> sliderKey, bool isShift);
            TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant);
            void SetSliderValueFromDrag();
            void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos);
            void SetSliderValueFromClick();
            void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos);
            void AdjustDragElement(float factor);
            void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt);
            void OnViewDataReady();
            bool SameValues(float a, float b, float epsilon);
            void UpdateDragElementPosition();
            void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            void UpdateTextFieldVisibility();
            void UpdateTextFieldValue();
            void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent evt);
            void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<string> evt);
            void UpdateMixedValueContent();

            enum SliderKey<TValueType>
            {
                None = 0,
                Lowest = 1,
                LowerPage = 2,
                Lower = 3,
                Higher = 4,
                HigherPage = 5,
                Highest = 6,
            }
        }

        class ButtonStripField : UnityEngine.UIElements.BaseField<int>
        {
            /*0x408*/ System.Collections.Generic.List<UnityEngine.UIElements.Button> m_Buttons;

            /*0x1a5a6e4*/ ButtonStripField();
            /*0x1a5a5f0*/ System.Collections.Generic.List<UnityEngine.UIElements.Button> get_buttons();
            /*0x1a5a7a4*/ void SetValueWithoutNotify(int newValue);
            /*0x1a5a82c*/ void RefreshButtonsState();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ButtonStripField, UnityEngine.UIElements.ButtonStripField.UxmlTraits>
            {
                /*0x1a5a90c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseField.UxmlTraits<int>
            {
                /*0x1a5a954*/ UxmlTraits();
            }
        }

        class MinMaxSlider : UnityEngine.UIElements.BaseField<UnityEngine.Vector2>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;
            static /*0x18*/ string trackerUssClassName;
            static /*0x20*/ string draggerUssClassName;
            static /*0x28*/ string minThumbUssClassName;
            static /*0x30*/ string maxThumbUssClassName;
            /*0x408*/ UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;
            /*0x410*/ UnityEngine.UIElements.VisualElement <dragMinThumb>k__BackingField;
            /*0x418*/ UnityEngine.UIElements.VisualElement <dragMaxThumb>k__BackingField;
            /*0x420*/ UnityEngine.UIElements.ClampedDragger<float> <clampedDragger>k__BackingField;
            /*0x428*/ UnityEngine.Vector2 m_DragElementStartPos;
            /*0x430*/ UnityEngine.Vector2 m_ValueStartPos;
            /*0x438*/ UnityEngine.Rect m_DragMinThumbRect;
            /*0x448*/ UnityEngine.Rect m_DragMaxThumbRect;
            /*0x458*/ UnityEngine.UIElements.MinMaxSlider.DragState m_DragState;
            /*0x45c*/ float m_MinLimit;
            /*0x460*/ float m_MaxLimit;

            static /*0x1a5d3c0*/ MinMaxSlider();
            /*0x1a5c4c8*/ MinMaxSlider();
            /*0x1a5c4e8*/ MinMaxSlider(string label, float minValue, float maxValue, float minLimit, float maxLimit);
            /*0x1a5a99c*/ UnityEngine.UIElements.VisualElement get_dragElement();
            /*0x1a5a9a4*/ void set_dragElement(UnityEngine.UIElements.VisualElement value);
            /*0x1a5a9ac*/ UnityEngine.UIElements.VisualElement get_dragMinThumb();
            /*0x1a5a9b4*/ void set_dragMinThumb(UnityEngine.UIElements.VisualElement value);
            /*0x1a5a9bc*/ UnityEngine.UIElements.VisualElement get_dragMaxThumb();
            /*0x1a5a9c4*/ void set_dragMaxThumb(UnityEngine.UIElements.VisualElement value);
            /*0x1a5a9cc*/ UnityEngine.UIElements.ClampedDragger<float> get_clampedDragger();
            /*0x1a5a9d4*/ void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<float> value);
            /*0x1a5a9dc*/ float get_minValue();
            /*0x1a5a9ec*/ void set_minValue(float value);
            /*0x1a5aacc*/ float get_maxValue();
            /*0x1a5aaec*/ void set_maxValue(float value);
            /*0x1a5ab94*/ UnityEngine.Vector2 get_value();
            /*0x1a5abdc*/ void set_value(UnityEngine.Vector2 value);
            /*0x1a5ac68*/ void SetValueWithoutNotify(UnityEngine.Vector2 newValue);
            /*0x1a5c1d8*/ float get_lowLimit();
            /*0x1a5c1e0*/ void set_lowLimit(float value);
            /*0x1a5c350*/ float get_highLimit();
            /*0x1a5c358*/ void set_highLimit(float value);
            /*0x1a5aa94*/ UnityEngine.Vector2 ClampValues(UnityEngine.Vector2 valueToClamp);
            /*0x1a5ca10*/ void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1a5acfc*/ void UpdateDragElementPosition();
            /*0x1a5cab4*/ float SliderLerpUnclamped(float a, float b, float interpolant);
            /*0x1a5caa4*/ float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue);
            /*0x1a5cac4*/ float ComputeValueFromPosition(float positionToConvert);
            /*0x1a5cc84*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x1a5cd90*/ void SetSliderValueFromDrag();
            /*0x1a5cfc8*/ void SetSliderValueFromClick();
            /*0x1a5d31c*/ void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos);
            /*0x1a5ce24*/ void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos);
            /*0x1a5d3bc*/ void UpdateMixedValueContent();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.MinMaxSlider, UnityEngine.UIElements.MinMaxSlider.UxmlTraits>
            {
                /*0x1a5d560*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseField.UxmlTraits<UnityEngine.Vector2>
            {
                /*0x80*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_MinValue;
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_MaxValue;
                /*0x90*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowLimit;
                /*0x98*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighLimit;

                /*0x1a5d764*/ UxmlTraits();
                /*0x1a5d5a8*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            enum DragState
            {
                NoThumb = 0,
                MinThumb = 1,
                MiddleThumb = 2,
                MaxThumb = 3,
            }
        }

        enum HelpBoxMessageType
        {
            None = 0,
            Info = 1,
            Warning = 2,
            Error = 3,
        }

        class HelpBox : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string iconUssClassName;
            static /*0x18*/ string iconInfoUssClassName;
            static /*0x20*/ string iconwarningUssClassName;
            static /*0x28*/ string iconErrorUssClassName;
            /*0x3b0*/ UnityEngine.UIElements.HelpBoxMessageType m_HelpBoxMessageType;
            /*0x3b8*/ UnityEngine.UIElements.VisualElement m_Icon;
            /*0x3c0*/ string m_IconClass;
            /*0x3c8*/ UnityEngine.UIElements.Label m_Label;

            static /*0x1a5dc20*/ HelpBox();
            /*0x1a5d9c4*/ HelpBox();
            /*0x1a5da18*/ HelpBox(string text, UnityEngine.UIElements.HelpBoxMessageType messageType);
            /*0x1a5d8d4*/ void set_text(string value);
            /*0x1a5d8f8*/ void set_messageType(UnityEngine.UIElements.HelpBoxMessageType value);
            /*0x1a5db68*/ string GetIconClass(UnityEngine.UIElements.HelpBoxMessageType messageType);
            /*0x1a5d910*/ void UpdateIcon(UnityEngine.UIElements.HelpBoxMessageType messageType);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.HelpBox, UnityEngine.UIElements.HelpBox.UxmlTraits>
            {
                /*0x1a5dd8c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x78*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType> m_MessageType;

                /*0x1a5df28*/ UxmlTraits();
                /*0x1a5ddd4*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class GroupBox : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.IGroupBox
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            /*0x3c0*/ UnityEngine.UIElements.Label m_TitleLabel;

            static /*0x1a5e1cc*/ GroupBox();
            /*0x1a5e13c*/ GroupBox();
            /*0x1a5e144*/ GroupBox(string text);
            /*0x1a5e024*/ void set_text(string value);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.GroupBox, UnityEngine.UIElements.GroupBox.UxmlTraits>
            {
                /*0x1a5e26c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;

                /*0x1a5e3ac*/ UxmlTraits();
                /*0x1a5e2b4*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class AbstractProgressBar : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.INotifyValueChanged<float>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string containerUssClassName;
            static /*0x10*/ string titleUssClassName;
            static /*0x18*/ string titleContainerUssClassName;
            static /*0x20*/ string progressUssClassName;
            static /*0x28*/ string backgroundUssClassName;
            /*0x3c0*/ UnityEngine.UIElements.VisualElement m_Background;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_Progress;
            /*0x3d0*/ UnityEngine.UIElements.Label m_Title;
            /*0x3d8*/ float m_LowValue;
            /*0x3dc*/ float m_HighValue;
            /*0x3e0*/ float m_Value;

            static /*0x1a5ebfc*/ AbstractProgressBar();
            /*0x1a5e5a8*/ AbstractProgressBar();
            /*0x1a5e430*/ void set_title(string value);
            /*0x1a5e454*/ float get_lowValue();
            /*0x1a5e45c*/ void set_lowValue(float value);
            /*0x1a5e590*/ float get_highValue();
            /*0x1a5e598*/ void set_highValue(float value);
            /*0x1a5e848*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e);
            /*0x1a5e86c*/ float get_value();
            /*0x1a5e874*/ void set_value(float value);
            /*0x1a5ead0*/ void SetValueWithoutNotify(float newValue);
            /*0x1a5e46c*/ void SetProgress(float p);
            /*0x1a5eaf8*/ float CalculateProgressWidth(float width);

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;
                /*0x80*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Title;

                /*0x1a5ef0c*/ UxmlTraits();
                /*0x1a5ed6c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class ProgressBar : UnityEngine.UIElements.AbstractProgressBar
        {
            /*0x1a5f034*/ ProgressBar();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ProgressBar, UnityEngine.UIElements.AbstractProgressBar.UxmlTraits>
            {
                /*0x1a5f088*/ UxmlFactory();
            }
        }

        class SliderInt : UnityEngine.UIElements.BaseSlider<int>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;

            static /*0x1a5faf8*/ SliderInt();
            /*0x1a5f0d0*/ SliderInt();
            /*0x1a5f0e8*/ SliderInt(string label, int start, int end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            /*0x1a5f234*/ float get_pageSize();
            /*0x1a5f27c*/ void set_pageSize(float value);
            /*0x1a5f394*/ int SliderLerpUnclamped(int a, int b, float interpolant);
            /*0x1a5f480*/ float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue);
            /*0x1a5f49c*/ int ParseStringToValue(string stringValue);
            /*0x1a5f4c8*/ void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos);
            /*0x1a5f828*/ void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<int> sliderKey, bool isShift);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.SliderInt, UnityEngine.UIElements.SliderInt.UxmlTraits>
            {
                /*0x1a5fbc8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<int, UnityEngine.UIElements.UxmlIntAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_LowValue;
                /*0x90*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_HighValue;
                /*0x98*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_PageSize;
                /*0xa0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowInputField;
                /*0xa8*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;
                /*0xb0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Inverted;

                /*0x1a5fed0*/ UxmlTraits();
                /*0x1a5fc10*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class Button : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string NonEmptyString;
            /*0x478*/ UnityEngine.UIElements.Clickable m_Clickable;

            static /*0x1a60380*/ Button();
            /*0x1a6016c*/ Button();
            /*0x1a5350c*/ Button(System.Action clickEvent);
            /*0x1a60100*/ UnityEngine.UIElements.Clickable get_clickable();
            /*0x1a60108*/ void set_clickable(UnityEngine.UIElements.Clickable value);
            /*0x1a60174*/ void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt);
            /*0x1a601ac*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x1a602c4*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Button, UnityEngine.UIElements.Button.UxmlTraits>
            {
                /*0x1a6040c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x1a60454*/ UxmlTraits();
            }
        }

        class TwoPaneSplitViewResizer : UnityEngine.UIElements.PointerManipulator
        {
            /*0x30*/ UnityEngine.Vector3 m_Start;
            /*0x3c*/ bool m_Active;
            /*0x40*/ UnityEngine.UIElements.TwoPaneSplitView m_SplitView;
            /*0x48*/ int m_Direction;
            /*0x4c*/ UnityEngine.UIElements.TwoPaneSplitViewOrientation m_Orientation;

            /*0x1a6070c*/ TwoPaneSplitViewResizer(UnityEngine.UIElements.TwoPaneSplitView splitView, int dir, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation);
            /*0x1a604ac*/ UnityEngine.UIElements.VisualElement get_fixedPane();
            /*0x1a604c8*/ UnityEngine.UIElements.VisualElement get_flexedPane();
            /*0x1a604e4*/ float get_fixedPaneMinDimension();
            /*0x1a605f8*/ float get_flexedPaneMinDimension();
            /*0x1a607e4*/ void RegisterCallbacksOnTarget();
            /*0x1a609b0*/ void UnregisterCallbacksFromTarget();
            /*0x1a60b7c*/ void ApplyDelta(float delta);
            /*0x1a6117c*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e);
            /*0x1a61244*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e);
            /*0x1a612fc*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e);
        }

        interface INotifyValueChanged<T>
        {
            T get_value();
            void set_value(T value);
            void SetValueWithoutNotify(T newValue);
        }

        class INotifyValueChangedExtensions
        {
            static bool RegisterValueChangedCallback<T>(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback);
            static bool UnregisterValueChangedCallback<T>(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback);
        }

        class BaseField<TValueType> : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.INotifyValueChanged<TValueType>
        {
            static /*0x0*/ string ussClassName;
            static /*0x0*/ string labelUssClassName;
            static /*0x0*/ string inputUssClassName;
            static /*0x0*/ string noLabelVariantUssClassName;
            static /*0x0*/ string labelDraggerVariantUssClassName;
            static /*0x0*/ string mixedValueLabelUssClassName;
            static /*0x0*/ string alignedFieldUssClassName;
            static /*0x0*/ string inspectorFieldUssClassName;
            static /*0x0*/ string mixedValueString;
            static /*0x0*/ UnityEngine.PropertyName serializedPropertyCopyName;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<float> s_LabelWidthRatioProperty;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<float> s_LabelExtraPaddingProperty;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<float> s_LabelBaseMinWidthProperty;
            /*0x0*/ float m_LabelWidthRatio;
            /*0x0*/ float m_LabelExtraPadding;
            /*0x0*/ float m_LabelBaseMinWidth;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_VisualInput;
            /*0x0*/ TValueType m_Value;
            /*0x0*/ UnityEngine.UIElements.Label <labelElement>k__BackingField;
            /*0x0*/ bool m_ShowMixedValue;
            /*0x0*/ UnityEngine.UIElements.Label m_MixedValueLabel;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_CachedInspectorElement;
            /*0x0*/ int m_CachedListAndFoldoutDepth;

            static BaseField();
            BaseField(string label);
            BaseField(string label, UnityEngine.UIElements.VisualElement visualInput);
            UnityEngine.UIElements.VisualElement get_visualInput();
            void set_visualInput(UnityEngine.UIElements.VisualElement value);
            TValueType get_rawValue();
            void set_rawValue(TValueType value);
            TValueType get_value();
            void set_value(TValueType value);
            UnityEngine.UIElements.Label get_labelElement();
            void set_labelElement(UnityEngine.UIElements.Label value);
            string get_label();
            void set_label(string value);
            bool get_showMixedValue();
            UnityEngine.UIElements.Label get_mixedValueLabel();
            void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e);
            void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt);
            void OnInspectorFieldGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e);
            void AlignLabel();
            void UpdateMixedValueContent();
            void SetValueWithoutNotify(TValueType newValue);
            void OnViewDataReady();
            UnityEngine.Rect GetTooltipRect();

            class UxmlTraits<TValueType> : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Label;

                static System.Collections.Generic.List<string> ParseChoiceList(string choicesFromBag);
                UxmlTraits();
                void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : UnityEngine.UIElements.BaseField.UxmlTraits<TValueType>
        {
            /*0x0*/ TValueUxmlAttributeType m_Value;

            BaseFieldTraits();
            void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class TouchScreenTextEditorEventHandler : UnityEngine.UIElements.TextEditorEventHandler
        {
            static /*0x0*/ UnityEngine.TouchScreenKeyboard s_KeyboardOnScreen;
            /*0x20*/ UnityEngine.UIElements.IVisualElementScheduledItem m_TouchKeyboardPoller;
            /*0x28*/ UnityEngine.UIElements.VisualElement m_LastPointerDownTarget;

            /*0x1a613a8*/ TouchScreenTextEditorEventHandler(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField);
            /*0x1a613b0*/ void PollTouchScreenKeyboard();
            /*0x1a6160c*/ void DoPollTouchScreenKeyboard();
            /*0x1a61d34*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
        }

        class RadioButtonGroup : UnityEngine.UIElements.BaseField<int>, UnityEngine.UIElements.IGroupBox
        {
            static /*0x0*/ string ussClassName;
            /*0x408*/ System.Collections.Generic.IEnumerable<string> m_Choices;
            /*0x410*/ System.Collections.Generic.List<UnityEngine.UIElements.RadioButton> m_RadioButtons;
            /*0x418*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

            static /*0x1a62d24*/ RadioButtonGroup();
            /*0x1a62a08*/ RadioButtonGroup();
            /*0x1a62a14*/ RadioButtonGroup(string label, System.Collections.Generic.List<string> radioButtonChoices);
            /*0x1a62284*/ void set_choices(System.Collections.Generic.IEnumerable<string> value);
            /*0x1a62bcc*/ void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<bool> evt);
            /*0x1a62cc4*/ void SetValueWithoutNotify(int newValue);
            /*0x1a6281c*/ void UpdateRadioButtons();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.RadioButtonGroup, UnityEngine.UIElements.RadioButtonGroup.UxmlTraits>
            {
                /*0x1a35934*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<int, UnityEngine.UIElements.UxmlIntAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Choices;

                /*0x1a35ab4*/ UxmlTraits();
                /*0x1a3597c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class TwoPaneSplitView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string s_UssClassName;
            static /*0x8*/ string s_ContentContainerClassName;
            static /*0x10*/ string s_HandleDragLineClassName;
            static /*0x18*/ string s_HandleDragLineVerticalClassName;
            static /*0x20*/ string s_HandleDragLineHorizontalClassName;
            static /*0x28*/ string s_HandleDragLineAnchorClassName;
            static /*0x30*/ string s_HandleDragLineAnchorVerticalClassName;
            static /*0x38*/ string s_HandleDragLineAnchorHorizontalClassName;
            static /*0x40*/ string s_VerticalClassName;
            static /*0x48*/ string s_HorizontalClassName;
            /*0x3b0*/ UnityEngine.UIElements.VisualElement m_LeftPane;
            /*0x3b8*/ UnityEngine.UIElements.VisualElement m_RightPane;
            /*0x3c0*/ UnityEngine.UIElements.VisualElement m_FixedPane;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_FlexedPane;
            /*0x3d0*/ float m_FixedPaneDimension;
            /*0x3d8*/ UnityEngine.UIElements.VisualElement m_DragLine;
            /*0x3e0*/ UnityEngine.UIElements.VisualElement m_DragLineAnchor;
            /*0x3e8*/ bool m_CollapseMode;
            /*0x3f0*/ UnityEngine.UIElements.VisualElement m_Content;
            /*0x3f8*/ UnityEngine.UIElements.TwoPaneSplitViewOrientation m_Orientation;
            /*0x3fc*/ int m_FixedPaneIndex;
            /*0x400*/ float m_FixedPaneInitialDimension;
            /*0x408*/ UnityEngine.UIElements.TwoPaneSplitViewResizer m_Resizer;

            static /*0x1a37988*/ TwoPaneSplitView();
            /*0x1a35bbc*/ TwoPaneSplitView();
            /*0x1a35b54*/ UnityEngine.UIElements.VisualElement get_fixedPane();
            /*0x1a35b5c*/ UnityEngine.UIElements.VisualElement get_flexedPane();
            /*0x1a35b64*/ int get_fixedPaneIndex();
            /*0x1a35b6c*/ float get_fixedPaneDimension();
            /*0x1a35ba0*/ void set_fixedPaneDimension(float value);
            /*0x1a35dcc*/ void Init(int fixedPaneIndex, float fixedPaneInitialDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation);
            /*0x1a37018*/ void OnPostDisplaySetup(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1a360a8*/ void PostDisplaySetup();
            /*0x1a37120*/ void OnSizeChange(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1a37124*/ void OnSizeChange();
            /*0x1a37944*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x1a3794c*/ void OnViewDataReady();
            /*0x1a376f4*/ void SetDragLineOffset(float offset);
            /*0x1a3781c*/ void SetFixedPaneDimension(float dimension);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TwoPaneSplitView, UnityEngine.UIElements.TwoPaneSplitView.UxmlTraits>
            {
                /*0x1a37b24*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedPaneIndex;
                /*0x78*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedPaneInitialDimension;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation> m_Orientation;

                /*0x1a37cd8*/ UxmlTraits();
                /*0x1a37b6c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        enum TwoPaneSplitViewOrientation
        {
            Horizontal = 0,
            Vertical = 1,
        }

        enum AlternatingRowBackground
        {
            None = 0,
            ContentOnly = 1,
            All = 2,
        }

        enum CollectionVirtualizationMethod
        {
            FixedHeight = 0,
            DynamicHeight = 1,
        }

        class BaseVerticalCollectionView : UnityEngine.UIElements.BindableElement, UnityEngine.ISerializationCallbackReceiver
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.ReusableCollectionItem> k_EmptyItems;
            static /*0x8*/ int s_DefaultItemHeight;
            static /*0x10*/ UnityEngine.UIElements.CustomStyleProperty<int> s_ItemHeightProperty;
            static /*0x18*/ string ussClassName;
            static /*0x20*/ string borderUssClassName;
            static /*0x28*/ string itemUssClassName;
            static /*0x30*/ string dragHoverBarUssClassName;
            static /*0x38*/ string itemDragHoverUssClassName;
            static /*0x40*/ string itemSelectedVariantUssClassName;
            static /*0x48*/ string itemAlternativeBackgroundUssClassName;
            static /*0x50*/ string listScrollViewUssClassName;
            static /*0x58*/ string backgroundFillUssClassName;
            /*0x3c0*/ System.Action<System.Collections.Generic.IEnumerable<object>> onItemsChosen;
            /*0x3c8*/ System.Action<System.Collections.Generic.IEnumerable<object>> onSelectionChange;
            /*0x3d0*/ System.Action<System.Collections.Generic.IEnumerable<int>> onSelectedIndicesChange;
            /*0x3d8*/ System.Action<int, int> itemIndexChanged;
            /*0x3e0*/ System.Action itemsSourceChanged;
            /*0x3e8*/ System.Func<int, int> m_GetItemId;
            /*0x3f0*/ System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;
            /*0x3f8*/ System.Action<UnityEngine.UIElements.VisualElement, int> m_BindItem;
            /*0x400*/ System.Action<UnityEngine.UIElements.VisualElement, int> <unbindItem>k__BackingField;
            /*0x408*/ System.Action<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField;
            /*0x410*/ UnityEngine.UIElements.SelectionType m_SelectionType;
            /*0x414*/ bool m_HorizontalScrollingEnabled;
            /*0x418*/ UnityEngine.UIElements.AlternatingRowBackground m_ShowAlternatingRowBackgrounds;
            /*0x41c*/ float m_FixedItemHeight;
            /*0x420*/ bool m_ItemHeightIsInline;
            /*0x424*/ UnityEngine.UIElements.CollectionVirtualizationMethod m_VirtualizationMethod;
            /*0x428*/ UnityEngine.UIElements.ScrollView m_ScrollView;
            /*0x430*/ UnityEngine.UIElements.CollectionViewController m_ViewController;
            /*0x438*/ UnityEngine.UIElements.CollectionVirtualizationController m_VirtualizationController;
            /*0x440*/ UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator;
            /*0x448*/ UnityEngine.Vector2 m_ScrollOffset;
            /*0x450*/ System.Collections.Generic.List<int> m_SelectedIds;
            /*0x458*/ System.Collections.Generic.List<int> m_SelectedIndices;
            /*0x460*/ System.Collections.Generic.List<object> m_SelectedItems;
            /*0x468*/ float m_LastHeight;
            /*0x46c*/ bool m_IsRangeSelectionDirectionUp;
            /*0x470*/ UnityEngine.UIElements.ListViewDragger m_Dragger;
            /*0x478*/ System.Action<int, int> m_ItemIndexChangedCallback;
            /*0x480*/ System.Action m_ItemsSourceChangedCallback;
            /*0x488*/ UnityEngine.Vector3 m_TouchDownPosition;

            static /*0x1a3d97c*/ BaseVerticalCollectionView();
            /*0x1a38d38*/ BaseVerticalCollectionView();
            /*0x1a37e24*/ void add_onItemsChosen(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x1a37ed8*/ void remove_onItemsChosen(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x1a37f8c*/ void add_onSelectionChange(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x1a38040*/ void remove_onSelectionChange(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x1a380f4*/ System.Func<int, int> get_getItemId();
            /*0x1a380fc*/ void set_getItemId(System.Func<int, int> value);
            /*0x1a38170*/ System.Collections.IList get_itemsSource();
            /*0x1a38188*/ void set_itemsSource(System.Collections.IList value);
            /*0x1a38204*/ bool get_sourceIncludesArraySize();
            /*0x1a3820c*/ System.Func<UnityEngine.UIElements.VisualElement> get_makeItem();
            /*0x1a38214*/ void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value);
            /*0x1a38288*/ System.Action<UnityEngine.UIElements.VisualElement, int> get_bindItem();
            /*0x1a38290*/ void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement, int> value);
            /*0x1a38298*/ System.Action<UnityEngine.UIElements.VisualElement, int> get_unbindItem();
            /*0x1a382a0*/ void set_unbindItem(System.Action<UnityEngine.UIElements.VisualElement, int> value);
            /*0x1a382a8*/ System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem();
            /*0x1a382b0*/ void set_destroyItem(System.Action<UnityEngine.UIElements.VisualElement> value);
            /*0x1a382b8*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x1a382c0*/ UnityEngine.UIElements.SelectionType get_selectionType();
            /*0x1a382c8*/ void set_selectionType(UnityEngine.UIElements.SelectionType value);
            /*0x1a38488*/ int get_selectedIndex();
            /*0x1a384fc*/ void set_selectedIndex(int value);
            /*0x1a38500*/ System.Collections.Generic.IEnumerable<int> get_selectedIndices();
            /*0x1a38508*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems();
            /*0x1a38580*/ UnityEngine.UIElements.ScrollView get_scrollView();
            /*0x1a38588*/ UnityEngine.UIElements.ListViewDragger get_dragger();
            /*0x1a38590*/ UnityEngine.UIElements.CollectionViewController get_viewController();
            /*0x1a38598*/ UnityEngine.UIElements.CollectionVirtualizationController get_virtualizationController();
            /*0x1a385f8*/ float ResolveItemHeight(float height);
            /*0x1a386b0*/ void set_showBorder(bool value);
            /*0x1a38730*/ bool get_reorderable();
            /*0x1a38820*/ void set_reorderable(bool value);
            /*0x1a389e0*/ void set_horizontalScrollingEnabled(bool value);
            /*0x1a38a28*/ UnityEngine.UIElements.AlternatingRowBackground get_showAlternatingRowBackgrounds();
            /*0x1a38a30*/ void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value);
            /*0x1a38a48*/ UnityEngine.UIElements.CollectionVirtualizationMethod get_virtualizationMethod();
            /*0x1a38a50*/ void set_virtualizationMethod(UnityEngine.UIElements.CollectionVirtualizationMethod value);
            /*0x1a38a8c*/ float get_fixedItemHeight();
            /*0x1a38a94*/ void set_fixedItemHeight(float value);
            /*0x1a38b90*/ float get_lastHeight();
            /*0x1a38b98*/ void CreateVirtualizationController();
            /*0x1a385c8*/ UnityEngine.UIElements.CollectionVirtualizationController GetOrCreateVirtualizationController();
            void CreateVirtualizationController<T>();
            /*0x1a381d4*/ UnityEngine.UIElements.CollectionViewController GetOrCreateViewController();
            /*0x1a38be0*/ void CreateViewController();
            /*0x1a38c44*/ void SetViewController(UnityEngine.UIElements.CollectionViewController controller);
            /*0x1a38cd4*/ UnityEngine.UIElements.ListViewDragger CreateDragger();
            /*0x1a38968*/ void InitializeDragAndDropController();
            UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController();
            /*0x1a392d8*/ bool HasValidDataAndBindings();
            /*0x1a39310*/ void OnItemIndexChanged(int srcIndex, int dstIndex);
            /*0x1a394f4*/ void OnItemsSourceChanged();
            /*0x1a38104*/ void RefreshItems();
            /*0x1a3821c*/ void Rebuild();
            /*0x1a3956c*/ void RefreshSelection();
            /*0x1a39804*/ void PostRefresh();
            /*0x1a399d0*/ void ScrollToItem(int index);
            /*0x1a39a5c*/ void OnScroll(UnityEngine.Vector2 offset);
            /*0x1a39930*/ void Resize(UnityEngine.Vector2 size, int layoutPass);
            /*0x1a39af0*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x1a39e4c*/ void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x1a3a114*/ bool Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, bool shiftKey);
            /*0x1a3abe0*/ void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent);
            /*0x1a3acec*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x1a3b760*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x1a3b81c*/ void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x1a3b8a8*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x1a3b368*/ void ProcessPointerDown(UnityEngine.UIElements.IPointerEvent evt);
            /*0x1a3ad74*/ void ProcessPointerUp(UnityEngine.UIElements.IPointerEvent evt);
            /*0x1a3b964*/ void DoSelect(UnityEngine.Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey);
            /*0x1a3bcdc*/ void DoRangeSelection(int rangeSelectionFinalIndex);
            /*0x1a3bc00*/ void ProcessSingleClick(int clickedIndex);
            /*0x1a3a4c8*/ void SelectAll();
            /*0x1a3bc64*/ void AddToSelection(int index);
            /*0x1a3c1d8*/ void AddToSelection(System.Collections.Generic.IList<int> indexes);
            /*0x1a3c5e4*/ void AddToSelectionWithoutValidation(int index);
            /*0x1a3bc04*/ void RemoveFromSelection(int index);
            /*0x1a3cac4*/ void RemoveFromSelectionWithoutValidation(int index);
            /*0x1a38400*/ void SetSelection(int index);
            /*0x1a3ced0*/ void SetSelection(System.Collections.Generic.IEnumerable<int> indices);
            /*0x1a3d214*/ void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<int> indices);
            /*0x1a3ced8*/ void SetSelectionInternal(System.Collections.Generic.IEnumerable<int> indices, bool sendNotification);
            /*0x1a3c568*/ void NotifyOfSelectionChange();
            /*0x1a3836c*/ void ClearSelection();
            /*0x1a3be78*/ void ClearSelectionWithoutValidation();
            /*0x1a3d21c*/ void OnViewDataReady();
            /*0x1a3d250*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x1a3d5d0*/ void OnSizeChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x1a3d788*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
            /*0x1a3d974*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x1a3d978*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x1a3dc28*/ void <.ctor>b__143_0(float v);
            /*0x1a3aaac*/ void <Apply>g__HandleSelectionAndScroll|164_0(int index, ref UnityEngine.UIElements.BaseVerticalCollectionView.<> );

            struct <>c__DisplayClass164_0
            {
                /*0x10*/ UnityEngine.UIElements.BaseVerticalCollectionView <>4__this;
                /*0x18*/ bool shiftKey;
            }
        }

        interface ITextHandle
        {
            UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, float scaling);
            float ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            float ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            float GetLineHeight(int characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
            UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
            bool IsLegacy();
            bool IsElided();
            void set_MeasuredSizes(UnityEngine.Vector2 value);
            void set_RoundedSizes(UnityEngine.Vector2 value);
        }

        struct TextCoreHandle : UnityEngine.UIElements.ITextHandle
        {
            static /*0x0*/ UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings;
            static /*0x8*/ UnityEngine.TextCore.Text.TextInfo s_TextInfoLayout;
            /*0x10*/ UnityEngine.Vector2 <MeasuredSizes>k__BackingField;
            /*0x18*/ UnityEngine.Vector2 <RoundedSizes>k__BackingField;
            /*0x20*/ UnityEngine.Vector2 m_PreferredSize;
            /*0x28*/ int m_PreviousGenerationSettingsHash;
            /*0x30*/ UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings;
            /*0x38*/ UnityEngine.TextCore.Text.TextInfo m_TextInfoMesh;
            /*0x40*/ bool isDirty;

            static /*0x1a3e7e8*/ TextCoreHandle();
            static /*0x1a3dc54*/ UnityEngine.UIElements.ITextHandle New();
            static /*0x1a3dd80*/ UnityEngine.TextCore.Text.TextInfo get_textInfoLayout();
            static /*0x1a3e568*/ UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams);
            static /*0x1a3e2bc*/ void UpdateGenerationSettingsCommon(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings);
            /*0x1a3dc34*/ UnityEngine.Vector2 get_MeasuredSizes();
            /*0x1a3dc3c*/ void set_MeasuredSizes(UnityEngine.Vector2 value);
            /*0x1a3dc44*/ UnityEngine.Vector2 get_RoundedSizes();
            /*0x1a3dc4c*/ void set_RoundedSizes(UnityEngine.Vector2 value);
            /*0x1a3dd14*/ UnityEngine.TextCore.Text.TextInfo get_textInfoMesh();
            /*0x1a3de40*/ bool IsLegacy();
            /*0x1a3de48*/ bool IsDirty(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms);
            /*0x1a3de8c*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, float scaling);
            /*0x1a3deb4*/ float ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x1a3e018*/ float ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x1a3e04c*/ float GetLineHeight(int characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
            /*0x1a3e0b4*/ UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
            /*0x1a3dee8*/ void UpdatePreferredValues(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms);
            /*0x1a3e784*/ bool IsElided();
        }

        struct TextNativeHandle : UnityEngine.UIElements.ITextHandle
        {
            /*0x10*/ UnityEngine.Vector2 <MeasuredSizes>k__BackingField;
            /*0x18*/ UnityEngine.Vector2 <RoundedSizes>k__BackingField;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> textVertices;
            /*0x30*/ int m_PreviousTextParamsHash;

            static /*0x1a3e880*/ UnityEngine.UIElements.ITextHandle New();
            /*0x1a3e860*/ UnityEngine.Vector2 get_MeasuredSizes();
            /*0x1a3e868*/ void set_MeasuredSizes(UnityEngine.Vector2 value);
            /*0x1a3e870*/ UnityEngine.Vector2 get_RoundedSizes();
            /*0x1a3e878*/ void set_RoundedSizes(UnityEngine.Vector2 value);
            /*0x1a3e8dc*/ bool IsLegacy();
            /*0x1a3e8e4*/ float GetLineHeight(int characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
            /*0x1a3e9b8*/ UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
            /*0x1a3ea28*/ Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x1a3ec38*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, float scaling);
            /*0x1a3ec90*/ float ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x1a3e954*/ float ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x1a3ed10*/ bool IsElided();
        }

        class TextUtilities
        {
            static /*0x1a3ed18*/ float ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, float pixelsPerPoint);
            static /*0x1a3ee14*/ UnityEngine.Vector2 MeasureVisualElementTextSize(UnityEngine.UIElements.VisualElement ve, string textToMeasure, float width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode, UnityEngine.UIElements.ITextHandle textHandle);
            static /*0x1a3e65c*/ UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam);
            static /*0x1a3f3ac*/ UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.VisualElement ve);
            static /*0x1a3f5dc*/ UnityEngine.Font GetFont(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam);
            static /*0x1a3f6cc*/ UnityEngine.Font GetFont(UnityEngine.UIElements.VisualElement ve);
            static /*0x1a3f2dc*/ bool IsFontAssigned(UnityEngine.UIElements.VisualElement ve);
            static /*0x1a3f828*/ bool IsFontAssigned(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams);
            static /*0x1a3f518*/ UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.VisualElement ve);
            static /*0x1a3e5a4*/ UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam);
            static /*0x1a3f9e0*/ UnityEngine.UIElements.UIR.TextCoreSettings GetTextCoreSettingsForElement(UnityEngine.UIElements.VisualElement ve);
        }

        class PanelTextSettings : UnityEngine.TextCore.Text.TextSettings
        {
            static /*0x0*/ UnityEngine.UIElements.PanelTextSettings s_DefaultPanelTextSettings;
            static /*0x8*/ System.Func<string, UnityEngine.Object> EditorGUIUtilityLoad;
            static /*0x10*/ System.Func<UnityEngine.SystemLanguage> GetCurrentLanguage;
            static /*0x18*/ string s_DefaultEditorPanelTextSettingPath;

            static /*0x1a4025c*/ PanelTextSettings();
            static /*0x1a3f8ac*/ UnityEngine.UIElements.PanelTextSettings get_defaultPanelTextSettings();
            static /*0x1a3fd94*/ void UpdateLocalizationFontAsset();
            /*0x1a40254*/ PanelTextSettings();
            /*0x1a3f3a4*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font);
        }

        interface IPointerCaptureEventInternal
        {
            int get_pointerId();
        }

        class PointerCaptureEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IPointerCaptureEventInternal
        {
            /*0x0*/ UnityEngine.UIElements.IEventHandler <relatedTarget>k__BackingField;
            /*0x0*/ int <pointerId>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.IEventHandler relatedTarget, int pointerId);
            PointerCaptureEventBase();
            void set_relatedTarget(UnityEngine.UIElements.IEventHandler value);
            int get_pointerId();
            void set_pointerId(int value);
            void Init();
            void LocalInit();
        }

        class PointerCaptureOutEvent : UnityEngine.UIElements.PointerCaptureEventBase<UnityEngine.UIElements.PointerCaptureOutEvent>
        {
            /*0x1a402bc*/ PointerCaptureOutEvent();
        }

        class PointerCaptureEvent : UnityEngine.UIElements.PointerCaptureEventBase<UnityEngine.UIElements.PointerCaptureEvent>
        {
            /*0x1a40304*/ PointerCaptureEvent();
        }

        class MouseCaptureEventBase<T> : UnityEngine.UIElements.PointerCaptureEventBase<T>
        {
            MouseCaptureEventBase();
            void Init();
        }

        class MouseCaptureOutEvent : UnityEngine.UIElements.MouseCaptureEventBase<UnityEngine.UIElements.MouseCaptureOutEvent>
        {
            /*0x1a4034c*/ MouseCaptureOutEvent();
        }

        class MouseCaptureEvent : UnityEngine.UIElements.MouseCaptureEventBase<UnityEngine.UIElements.MouseCaptureEvent>
        {
            /*0x1a40394*/ MouseCaptureEvent();
        }

        class ElementUnderPointer
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement[] m_PendingTopElementUnderPointer;
            /*0x18*/ UnityEngine.UIElements.VisualElement[] m_TopElementUnderPointer;
            /*0x20*/ UnityEngine.UIElements.IPointerEvent[] m_TriggerPointerEvent;
            /*0x28*/ UnityEngine.UIElements.IMouseEvent[] m_TriggerMouseEvent;
            /*0x30*/ UnityEngine.Vector2[] m_PickingPointerPositions;
            /*0x38*/ bool[] m_IsPickingPointerTemporaries;

            /*0x1a41dbc*/ ElementUnderPointer();
            /*0x1a403dc*/ UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(int pointerId, ref UnityEngine.Vector2 pickPosition, ref bool isTemporary);
            /*0x1a40450*/ UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(int pointerId);
            /*0x1a40480*/ void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.Vector2 pointerPos);
            /*0x1a405e0*/ UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase triggerEvent);
            /*0x1a40798*/ void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x1a409ec*/ void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x1a407a0*/ void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.UIElements.EventBase triggerEvent, bool temporary);
            /*0x1a409f4*/ void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher dispatcher, UnityEngine.UIElements.ContextType contextType);
        }

        class IMGUIEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.IMGUIEvent>
        {
            static /*0x1a41f18*/ UnityEngine.UIElements.IMGUIEvent GetPooled(UnityEngine.Event systemEvent);
            /*0x1a420b0*/ IMGUIEvent();
            /*0x1a42050*/ void Init();
            /*0x1a420a4*/ void LocalInit();
        }

        class PointerDeviceState
        {
            static /*0x0*/ UnityEngine.UIElements.PointerDeviceState.PointerLocation[] s_PlayerPointerLocations;
            static /*0x8*/ int[] s_PressedButtons;
            static /*0x10*/ UnityEngine.UIElements.IPanel[] s_PlayerPanelWithSoftPointerCapture;

            static /*0x1a42a48*/ PointerDeviceState();
            static /*0x1a42128*/ void RemovePanelData(UnityEngine.UIElements.IPanel panel);
            static /*0x1a42410*/ void SavePointerPosition(int pointerId, UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.ContextType contextType);
            static /*0x1a424b8*/ void PressButton(int pointerId, int buttonId);
            static /*0x1a42594*/ void ReleaseButton(int pointerId, int buttonId);
            static /*0x1a42670*/ void ReleaseAllButtons(int pointerId);
            static /*0x1a41648*/ UnityEngine.Vector2 GetPointerPosition(int pointerId, UnityEngine.UIElements.ContextType contextType);
            static /*0x1a426ec*/ UnityEngine.UIElements.IPanel GetPanel(int pointerId, UnityEngine.UIElements.ContextType contextType);
            static /*0x1a4276c*/ bool HasFlagFast(UnityEngine.UIElements.PointerDeviceState.LocationFlag flagSet, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag);
            static /*0x1a42778*/ bool HasLocationFlag(int pointerId, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag);
            static /*0x1a4280c*/ int GetPressedButtons(int pointerId);
            static /*0x1a42888*/ bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId);
            static /*0x1a42920*/ void SetPlayerPanelWithSoftPointerCapture(int pointerId, UnityEngine.UIElements.IPanel panel);
            static /*0x1a429cc*/ UnityEngine.UIElements.IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId);

            enum LocationFlag
            {
                None = 0,
                OutsidePanel = 1,
            }

            struct PointerLocation
            {
                /*0x10*/ UnityEngine.Vector2 <Position>k__BackingField;
                /*0x18*/ UnityEngine.UIElements.IPanel <Panel>k__BackingField;
                /*0x20*/ UnityEngine.UIElements.PointerDeviceState.LocationFlag <Flags>k__BackingField;

                /*0x1a42b4c*/ UnityEngine.Vector2 get_Position();
                /*0x1a42b54*/ void set_Position(UnityEngine.Vector2 value);
                /*0x1a42b5c*/ UnityEngine.UIElements.IPanel get_Panel();
                /*0x1a42b64*/ void set_Panel(UnityEngine.UIElements.IPanel value);
                /*0x1a42b6c*/ UnityEngine.UIElements.PointerDeviceState.LocationFlag get_Flags();
                /*0x1a42b74*/ void set_Flags(UnityEngine.UIElements.PointerDeviceState.LocationFlag value);
                /*0x1a42304*/ void SetLocation(UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel);
            }
        }

        class PointerCaptureDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a4322c*/ PointerCaptureDispatchingStrategy();
            /*0x1a42b7c*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a42bd0*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        enum TrickleDown
        {
            NoTrickleDown = 0,
            TrickleDown = 1,
        }

        enum CallbackPhase
        {
            TargetAndBubbleUp = 1,
            TrickleDownAndTarget = 2,
        }

        enum InvokePolicy
        {
            Default = 0,
            IncludeDisabled = 1,
        }

        class EventCallbackListPool
        {
            /*0x10*/ System.Collections.Generic.Stack<UnityEngine.UIElements.EventCallbackList> m_Stack;

            /*0x1a43668*/ EventCallbackListPool();
            /*0x1a43234*/ UnityEngine.UIElements.EventCallbackList Get(UnityEngine.UIElements.EventCallbackList initializer);
            /*0x1a43598*/ void Release(UnityEngine.UIElements.EventCallbackList element);
        }

        class EventCallbackList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase> m_List;
            /*0x18*/ int <trickleDownCallbackCount>k__BackingField;
            /*0x1c*/ int <bubbleUpCallbackCount>k__BackingField;

            /*0x1a43388*/ EventCallbackList();
            /*0x1a432f8*/ EventCallbackList(UnityEngine.UIElements.EventCallbackList source);
            /*0x1a436e4*/ int get_trickleDownCallbackCount();
            /*0x1a436ec*/ void set_trickleDownCallbackCount(int value);
            /*0x1a436f4*/ int get_bubbleUpCallbackCount();
            /*0x1a436fc*/ void set_bubbleUpCallbackCount(int value);
            /*0x1a43704*/ bool Contains(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x1a4371c*/ UnityEngine.UIElements.EventCallbackFunctorBase Find(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x1a43804*/ bool Remove(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x1a43924*/ void Add(UnityEngine.UIElements.EventCallbackFunctorBase item);
            /*0x1a43408*/ void AddRange(UnityEngine.UIElements.EventCallbackList list);
            /*0x1a43a00*/ int get_Count();
            /*0x1a43a48*/ UnityEngine.UIElements.EventCallbackFunctorBase get_Item(int i);
            /*0x1a435fc*/ void Clear();
        }

        class EventCallbackRegistry
        {
            static /*0x0*/ UnityEngine.UIElements.EventCallbackListPool s_ListPool;
            /*0x10*/ UnityEngine.UIElements.EventCallbackList m_Callbacks;
            /*0x18*/ UnityEngine.UIElements.EventCallbackList m_TemporaryCallbacks;
            /*0x20*/ int m_IsInvoking;

            static /*0x1a43e9c*/ EventCallbackRegistry();
            static /*0x1a43aa0*/ UnityEngine.UIElements.EventCallbackList GetCallbackList(UnityEngine.UIElements.EventCallbackList initializer);
            static /*0x1a43b08*/ void ReleaseCallbackList(UnityEngine.UIElements.EventCallbackList toRelease);
            /*0x1a43b70*/ EventCallbackRegistry();
            /*0x1a43b8c*/ UnityEngine.UIElements.EventCallbackList GetCallbackListForWriting();
            /*0x1a43c3c*/ UnityEngine.UIElements.EventCallbackList GetCallbackListForReading();
            /*0x1a43c58*/ bool UnregisterCallback(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown, UnityEngine.UIElements.InvokePolicy invokePolicy);
            bool UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            /*0x1a43cac*/ void InvokeCallbacks(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase);
            /*0x1a43e5c*/ bool HasTrickleDownHandlers();
            /*0x1a43e7c*/ bool HasBubbleHandlers();
        }

        class KeyboardEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a44bb0*/ KeyboardEventDispatchingStrategy();
            /*0x1a43f10*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a43f64*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class MouseEventsHelper
        {
            static void SendEnterLeave<TLeaveEvent, TEnterEvent>(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition);
            static /*0x1a41a48*/ void SendMouseOverMouseOut(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition);
        }

        class PointerEventsHelper
        {
            static void SendEnterLeave<TLeaveEvent, TEnterEvent>(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, int pointerId);
            static /*0x1a416c8*/ void SendOverOut(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, int pointerId);
        }

        class PropagationPaths
        {
            static int k_DefaultPropagationDepth = 16;
            static int k_DefaultTargetCount = 4;
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.PropagationPaths> s_Pool;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> trickleDownPath;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> targetElements;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> bubbleUpPath;

            static /*0x1a4516c*/ PropagationPaths();
            static /*0x1a44c84*/ UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths paths);
            static /*0x1a44d64*/ UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement elem, UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths.Type pathTypesRequested);
            /*0x1a44bb8*/ PropagationPaths();
            /*0x1a4505c*/ void Release();

            enum Type
            {
                None = 0,
                TrickleDown = 1,
                BubbleUp = 2,
            }
        }

        class DefaultDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a45480*/ DefaultDispatchingStrategy();
            /*0x1a451fc*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a45274*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class TooltipEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.TooltipEvent>
        {
            /*0x80*/ string <tooltip>k__BackingField;
            /*0x88*/ UnityEngine.Rect <rect>k__BackingField;

            /*0x1a455a4*/ TooltipEvent();
            /*0x1a45488*/ void set_tooltip(string value);
            /*0x1a45490*/ void set_rect(UnityEngine.Rect value);
            /*0x1a4549c*/ void Init();
            /*0x1a4552c*/ void LocalInit();
        }

        class MouseCaptureDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a45de0*/ MouseCaptureDispatchingStrategy();
            /*0x1a45658*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a456ec*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);

            enum EventBehavior
            {
                None = 0,
                IsCapturable = 1,
                IsSentExclusivelyToCapturingElement = 2,
            }
        }

        class EventBase : System.IDisposable
        {
            static /*0x0*/ long s_LastTypeId;
            static /*0x8*/ ulong s_NextEventId;
            /*0x10*/ long <timestamp>k__BackingField;
            /*0x18*/ ulong <eventId>k__BackingField;
            /*0x20*/ ulong <triggerEventId>k__BackingField;
            /*0x28*/ UnityEngine.UIElements.EventBase.EventPropagation <propagation>k__BackingField;
            /*0x30*/ UnityEngine.UIElements.PropagationPaths m_Path;
            /*0x38*/ UnityEngine.UIElements.EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField;
            /*0x40*/ UnityEngine.UIElements.IEventHandler <leafTarget>k__BackingField;
            /*0x48*/ UnityEngine.UIElements.IEventHandler m_Target;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> <skipElements>k__BackingField;
            /*0x58*/ UnityEngine.UIElements.PropagationPhase <propagationPhase>k__BackingField;
            /*0x60*/ UnityEngine.UIElements.IEventHandler m_CurrentTarget;
            /*0x68*/ UnityEngine.Event m_ImguiEvent;
            /*0x70*/ UnityEngine.Vector2 <originalMousePosition>k__BackingField;

            static /*0x1a45de8*/ long RegisterEventType();
            /*0x1a4645c*/ EventBase();
            /*0x1a45e38*/ long get_eventTypeId();
            /*0x1a45e40*/ long get_timestamp();
            /*0x1a45e48*/ void set_timestamp(long value);
            /*0x1a45e50*/ ulong get_eventId();
            /*0x1a45e58*/ void set_eventId(ulong value);
            /*0x1a45e60*/ void set_triggerEventId(ulong value);
            /*0x1a45e68*/ void SetTriggerEventId(ulong id);
            /*0x1a45e70*/ UnityEngine.UIElements.EventBase.EventPropagation get_propagation();
            /*0x1a45e78*/ void set_propagation(UnityEngine.UIElements.EventBase.EventPropagation value);
            /*0x1a45e80*/ UnityEngine.UIElements.PropagationPaths get_path();
            /*0x1a45f78*/ void set_path(UnityEngine.UIElements.PropagationPaths value);
            /*0x1a45fdc*/ UnityEngine.UIElements.EventBase.LifeCycleStatus get_lifeCycleStatus();
            /*0x1a45fe4*/ void set_lifeCycleStatus(UnityEngine.UIElements.EventBase.LifeCycleStatus value);
            /*0x1a45fec*/ void PreDispatch();
            /*0x1a45ff0*/ void PreDispatch(UnityEngine.UIElements.IPanel panel);
            /*0x1a45ffc*/ void PostDispatch();
            /*0x1a46000*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
            /*0x1a45f6c*/ bool get_bubbles();
            /*0x1a45f60*/ bool get_tricklesDown();
            /*0x1a43e50*/ bool get_skipDisabledElements();
            /*0x1a431d8*/ void set_skipDisabledElements(bool value);
            /*0x1a45000*/ bool get_ignoreCompositeRoots();
            /*0x1a45588*/ void set_ignoreCompositeRoots(bool value);
            /*0x1a46044*/ UnityEngine.UIElements.IEventHandler get_leafTarget();
            /*0x1a4604c*/ void set_leafTarget(UnityEngine.UIElements.IEventHandler value);
            /*0x1a3d5c8*/ UnityEngine.UIElements.IEventHandler get_target();
            /*0x1a431c0*/ void set_target(UnityEngine.UIElements.IEventHandler value);
            /*0x1a46054*/ System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements();
            /*0x1a441dc*/ bool Skip(UnityEngine.UIElements.IEventHandler h);
            /*0x1a44980*/ bool get_isPropagationStopped();
            /*0x1a4605c*/ void set_isPropagationStopped(bool value);
            /*0x1a3acc4*/ void StopPropagation();
            /*0x1a43e44*/ bool get_isImmediatePropagationStopped();
            /*0x1a46078*/ void set_isImmediatePropagationStopped(bool value);
            /*0x1a46094*/ void StopImmediatePropagation();
            /*0x1a460a4*/ bool get_isDefaultPrevented();
            /*0x1a460b0*/ void set_isDefaultPrevented(bool value);
            /*0x1a3acd4*/ void PreventDefault();
            /*0x1a460cc*/ UnityEngine.UIElements.PropagationPhase get_propagationPhase();
            /*0x1a460d4*/ void set_propagationPhase(UnityEngine.UIElements.PropagationPhase value);
            /*0x1a460dc*/ UnityEngine.UIElements.IEventHandler get_currentTarget();
            /*0x1a460e4*/ void set_currentTarget(UnityEngine.UIElements.IEventHandler value);
            /*0x1a461c8*/ bool get_dispatch();
            /*0x1a431a0*/ void set_dispatch(bool value);
            /*0x1a461f0*/ void MarkReceivedByDispatcher();
            /*0x1a46278*/ bool get_dispatched();
            /*0x1a461d4*/ void set_dispatched(bool value);
            /*0x1a46284*/ bool get_processed();
            /*0x1a46028*/ void set_processed(bool value);
            /*0x1a46290*/ bool get_processedByFocusController();
            /*0x1a4629c*/ void set_processedByFocusController(bool value);
            /*0x1a462b8*/ bool get_stopDispatch();
            /*0x1a431f4*/ void set_stopDispatch(bool value);
            /*0x1a45474*/ bool get_propagateToIMGUI();
            /*0x1a43210*/ void set_propagateToIMGUI(bool value);
            /*0x1a462c4*/ bool get_imguiEventIsValid();
            /*0x1a462d0*/ void set_imguiEventIsValid(bool value);
            /*0x1a456d4*/ UnityEngine.Event get_imguiEvent();
            /*0x1a41f9c*/ void set_imguiEvent(UnityEngine.Event value);
            /*0x1a462ec*/ UnityEngine.Vector2 get_originalMousePosition();
            /*0x1a462f4*/ void set_originalMousePosition(UnityEngine.Vector2 value);
            /*0x1a462fc*/ void Init();
            /*0x1a46300*/ void LocalInit();
            /*0x1a464e4*/ bool get_pooled();
            /*0x1a46440*/ void set_pooled(bool value);
            void Acquire();
            void Dispose();

            enum EventPropagation
            {
                None = 0,
                Bubbles = 1,
                TricklesDown = 2,
                Cancellable = 4,
                SkipDisabledElements = 8,
                IgnoreCompositeRoots = 16,
            }

            enum LifeCycleStatus
            {
                None = 0,
                PropagationStopped = 1,
                ImmediatePropagationStopped = 2,
                DefaultPrevented = 4,
                Dispatching = 8,
                Pooled = 16,
                IMGUIEventIsValid = 32,
                StopDispatch = 64,
                PropagateToIMGUI = 128,
                Dispatched = 512,
                Processed = 1024,
                ProcessedByFocusController = 2048,
            }
        }

        class EventBase<T> : UnityEngine.UIElements.EventBase
        {
            static /*0x0*/ long s_TypeId;
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<T> s_Pool;
            /*0x0*/ int m_RefCount;

            static EventBase();
            static long TypeId();
            static T GetPooled();
            static T GetPooled(UnityEngine.UIElements.EventBase e);
            static void ReleasePooled(T evt);
            EventBase();
            void Init();
            void Acquire();
            void Dispose();
            long get_eventTypeId();
        }

        class ChangeEvent<T> : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.ChangeEvent<T>>
        {
            /*0x0*/ T <previousValue>k__BackingField;
            /*0x0*/ T <newValue>k__BackingField;

            static UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue);
            ChangeEvent();
            T get_previousValue();
            void set_previousValue(T value);
            T get_newValue();
            void set_newValue(T value);
            void Init();
            void LocalInit();
        }

        class EventCallback<TEventType> : System.MulticastDelegate
        {
            EventCallback(object object, nint method);
            void Invoke(TEventType evt);
        }

        class EventCallbackFunctorBase
        {
            /*0x10*/ UnityEngine.UIElements.CallbackPhase <phase>k__BackingField;
            /*0x14*/ UnityEngine.UIElements.InvokePolicy <invokePolicy>k__BackingField;

            /*0x1a46500*/ EventCallbackFunctorBase(UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy);
            /*0x1a464f0*/ UnityEngine.UIElements.CallbackPhase get_phase();
            /*0x1a464f8*/ UnityEngine.UIElements.InvokePolicy get_invokePolicy();
            void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase);
            bool IsEquivalentTo(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x1a4652c*/ bool PhaseMatches(UnityEngine.UIElements.PropagationPhase propagationPhase);
        }

        class EventCallbackFunctor<TEventType> : UnityEngine.UIElements.EventCallbackFunctorBase
        {
            /*0x0*/ UnityEngine.UIElements.EventCallback<TEventType> m_Callback;
            /*0x0*/ long m_EventTypeId;

            EventCallbackFunctor(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy);
            void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase);
            bool IsEquivalentTo(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
        }

        class PointerEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            static /*0x1a46830*/ void SendEventToTarget(UnityEngine.UIElements.EventBase evt);
            static /*0x1a465f4*/ void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
            static /*0x1a46854*/ void UpdateElementUnderPointer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, ref UnityEngine.UIElements.VisualElement elementUnderPointer);
            /*0x1a46b00*/ PointerEventDispatchingStrategy();
            /*0x1a46568*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a465bc*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        struct StylePropertyNameCollection : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> propertiesList;

            /*0x1a46b08*/ StylePropertyNameCollection(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list);
            /*0x1a46b10*/ UnityEngine.UIElements.StylePropertyNameCollection.Enumerator GetEnumerator();
            /*0x1a46b8c*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator();
            /*0x1a46bf4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> m_Enumerator;

                /*0x1a46b80*/ Enumerator(System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> enumerator);
                /*0x1a46c5c*/ bool MoveNext();
                /*0x1a46ca4*/ UnityEngine.UIElements.StylePropertyName get_Current();
                /*0x1a46ce0*/ object System.Collections.IEnumerator.get_Current();
                /*0x1a46d5c*/ void Reset();
                /*0x1a46d60*/ void Dispose();
            }
        }

        class TransitionEventBase<T> : UnityEngine.UIElements.EventBase<T>
        {
            /*0x0*/ UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField;
            /*0x0*/ double <elapsedTime>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.StylePropertyName stylePropertyName, double elapsedTime);
            TransitionEventBase();
            UnityEngine.UIElements.StylePropertyNameCollection get_stylePropertyNames();
            void set_elapsedTime(double value);
            void Init();
            void LocalInit();
        }

        class TransitionRunEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionRunEvent>
        {
            /*0x1a46da8*/ TransitionRunEvent();
        }

        class TransitionStartEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionStartEvent>
        {
            /*0x1a46df0*/ TransitionStartEvent();
        }

        class TransitionEndEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionEndEvent>
        {
            /*0x1a46e38*/ TransitionEndEvent();
        }

        class TransitionCancelEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionCancelEvent>
        {
            /*0x1a46e80*/ TransitionCancelEvent();
        }

        class NavigationEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a47060*/ NavigationEventDispatchingStrategy();
            /*0x1a46ec8*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a46f1c*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class PointerType
        {
            static /*0x0*/ string mouse;
            static /*0x8*/ string touch;
            static /*0x10*/ string pen;
            static /*0x18*/ string unknown;

            static /*0x1a47190*/ PointerType();
            static /*0x1a47068*/ string GetPointerType(int pointerId);
            static /*0x1a47104*/ bool IsDirectManipulationDevice(string pointerType);
        }

        class PointerId
        {
            static /*0x0*/ int maxPointers;
            static /*0x4*/ int invalidPointerId;
            static /*0x8*/ int mousePointerId;
            static /*0xc*/ int touchPointerIdBase;
            static /*0x10*/ int touchPointerCount;
            static /*0x14*/ int penPointerIdBase;
            static /*0x18*/ int penPointerCount;
            static /*0x20*/ int[] hoveringPointers;

            static /*0x1a4725c*/ PointerId();
        }

        interface IPointerEvent
        {
            int get_pointerId();
            string get_pointerType();
            bool get_isPrimary();
            int get_button();
            int get_pressedButtons();
            UnityEngine.Vector3 get_position();
            UnityEngine.Vector3 get_localPosition();
            UnityEngine.Vector3 get_deltaPosition();
            float get_deltaTime();
            int get_clickCount();
            float get_pressure();
            float get_tangentialPressure();
            float get_altitudeAngle();
            float get_azimuthAngle();
            float get_twist();
            UnityEngine.Vector2 get_radius();
            UnityEngine.Vector2 get_radiusVariance();
            UnityEngine.EventModifiers get_modifiers();
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool get_actionKey();
        }

        interface IPointerEventInternal
        {
            bool get_triggeredByOS();
            void set_triggeredByOS(bool value);
            bool get_recomputeTopElementUnderPointer();
            void set_recomputeTopElementUnderPointer(bool value);
        }

        class PointerEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IPointerEvent, UnityEngine.UIElements.IPointerEventInternal
        {
            /*0x0*/ int <pointerId>k__BackingField;
            /*0x0*/ string <pointerType>k__BackingField;
            /*0x0*/ bool <isPrimary>k__BackingField;
            /*0x0*/ int <button>k__BackingField;
            /*0x0*/ int <pressedButtons>k__BackingField;
            /*0x0*/ UnityEngine.Vector3 <position>k__BackingField;
            /*0x0*/ UnityEngine.Vector3 <localPosition>k__BackingField;
            /*0x0*/ UnityEngine.Vector3 <deltaPosition>k__BackingField;
            /*0x0*/ float <deltaTime>k__BackingField;
            /*0x0*/ int <clickCount>k__BackingField;
            /*0x0*/ float <pressure>k__BackingField;
            /*0x0*/ float <tangentialPressure>k__BackingField;
            /*0x0*/ float <altitudeAngle>k__BackingField;
            /*0x0*/ float <azimuthAngle>k__BackingField;
            /*0x0*/ float <twist>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <radius>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
            /*0x0*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField;

            static bool IsMouse(UnityEngine.Event systemEvent);
            static T GetPooled(UnityEngine.Event systemEvent);
            static T GetPooled(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers);
            static T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, int pointerId);
            static T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent);
            PointerEventBase();
            int get_pointerId();
            void set_pointerId(int value);
            string get_pointerType();
            void set_pointerType(string value);
            bool get_isPrimary();
            void set_isPrimary(bool value);
            int get_button();
            void set_button(int value);
            int get_pressedButtons();
            void set_pressedButtons(int value);
            UnityEngine.Vector3 get_position();
            void set_position(UnityEngine.Vector3 value);
            UnityEngine.Vector3 get_localPosition();
            void set_localPosition(UnityEngine.Vector3 value);
            UnityEngine.Vector3 get_deltaPosition();
            void set_deltaPosition(UnityEngine.Vector3 value);
            float get_deltaTime();
            void set_deltaTime(float value);
            int get_clickCount();
            void set_clickCount(int value);
            float get_pressure();
            void set_pressure(float value);
            float get_tangentialPressure();
            void set_tangentialPressure(float value);
            float get_altitudeAngle();
            void set_altitudeAngle(float value);
            float get_azimuthAngle();
            void set_azimuthAngle(float value);
            float get_twist();
            void set_twist(float value);
            UnityEngine.Vector2 get_radius();
            void set_radius(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_radiusVariance();
            void set_radiusVariance(UnityEngine.Vector2 value);
            UnityEngine.EventModifiers get_modifiers();
            void set_modifiers(UnityEngine.EventModifiers value);
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool get_actionKey();
            bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS();
            void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value);
            bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer();
            void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value);
            void Init();
            void LocalInit();
            UnityEngine.UIElements.IEventHandler get_currentTarget();
            void set_currentTarget(UnityEngine.UIElements.IEventHandler value);
            void PreDispatch(UnityEngine.UIElements.IPanel panel);
            void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerDownEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerDownEvent>
        {
            /*0x1a4745c*/ PointerDownEvent();
            /*0x1a47308*/ void Init();
            /*0x1a47358*/ void LocalInit();
            /*0x1a474ac*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerMoveEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerMoveEvent>
        {
            /*0xea*/ bool <isHandledByDraggable>k__BackingField;

            /*0x1a47884*/ PointerMoveEvent();
            /*0x1a47714*/ bool get_isHandledByDraggable();
            /*0x1a4771c*/ void set_isHandledByDraggable(bool value);
            /*0x1a47728*/ void Init();
            /*0x1a47778*/ void LocalInit();
            /*0x1a478d4*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerStationaryEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerStationaryEvent>
        {
            /*0x1a48080*/ PointerStationaryEvent();
            /*0x1a47f2c*/ void Init();
            /*0x1a47f7c*/ void LocalInit();
        }

        class PointerUpEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerUpEvent>
        {
            /*0x1a48224*/ PointerUpEvent();
            /*0x1a480d0*/ void Init();
            /*0x1a48120*/ void LocalInit();
            /*0x1a48274*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerCancelEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerCancelEvent>
        {
            /*0x1a486f8*/ PointerCancelEvent();
            /*0x1a485a4*/ void Init();
            /*0x1a485f4*/ void LocalInit();
            /*0x1a48748*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class ClickEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.ClickEvent>
        {
            static /*0x1a48b30*/ UnityEngine.UIElements.ClickEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent, int clickCount);
            /*0x1a48adc*/ ClickEvent();
            /*0x1a48a7c*/ void Init();
            /*0x1a48ad0*/ void LocalInit();
        }

        class PointerEnterEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerEnterEvent>
        {
            /*0x1a48c00*/ PointerEnterEvent();
            /*0x1a48ba0*/ void Init();
            /*0x1a48bf4*/ void LocalInit();
        }

        class PointerLeaveEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerLeaveEvent>
        {
            /*0x1a48cb4*/ PointerLeaveEvent();
            /*0x1a48c54*/ void Init();
            /*0x1a48ca8*/ void LocalInit();
        }

        class PointerOverEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerOverEvent>
        {
            /*0x1a48d08*/ PointerOverEvent();
        }

        class PointerOutEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerOutEvent>
        {
            /*0x1a48d50*/ PointerOutEvent();
        }

        class CustomStyleResolvedEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.CustomStyleResolvedEvent>
        {
            /*0x1a48d98*/ CustomStyleResolvedEvent();
            /*0x1a3d8ec*/ UnityEngine.UIElements.ICustomStyle get_customStyle();
        }

        interface IEventHandler
        {
            void SendEvent(UnityEngine.UIElements.EventBase e);
            void HandleEvent(UnityEngine.UIElements.EventBase evt);
        }

        class CallbackEventHandler : UnityEngine.UIElements.IEventHandler
        {
            /*0x10*/ UnityEngine.UIElements.EventCallbackRegistry m_CallbackRegistry;

            /*0x1a490d4*/ CallbackEventHandler();
            void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.InvokePolicy invokePolicy, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void SendEvent(UnityEngine.UIElements.EventBase e);
            void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x1a45d74*/ void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase evt);
            /*0x1a48e04*/ void HandleEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a4500c*/ bool HasTrickleDownHandlers();
            /*0x1a45034*/ bool HasBubbleUpHandlers();
            /*0x1a490c4*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x1a490c8*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x1a490cc*/ void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x1a490d0*/ void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt);
        }

        class GeometryChangedEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.GeometryChangedEvent>
        {
            /*0x7c*/ UnityEngine.Rect <oldRect>k__BackingField;
            /*0x8c*/ UnityEngine.Rect <newRect>k__BackingField;
            /*0x9c*/ int <layoutPass>k__BackingField;

            static /*0x1a490dc*/ UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect oldRect, UnityEngine.Rect newRect);
            /*0x1a49260*/ GeometryChangedEvent();
            /*0x1a4919c*/ void Init();
            /*0x1a491ec*/ void LocalInit();
            /*0x1a49220*/ UnityEngine.Rect get_oldRect();
            /*0x1a4922c*/ void set_oldRect(UnityEngine.Rect value);
            /*0x1a49238*/ UnityEngine.Rect get_newRect();
            /*0x1a49244*/ void set_newRect(UnityEngine.Rect value);
            /*0x1a49250*/ int get_layoutPass();
            /*0x1a49258*/ void set_layoutPass(int value);
        }

        interface IMouseEvent
        {
            UnityEngine.EventModifiers get_modifiers();
            UnityEngine.Vector2 get_mousePosition();
            UnityEngine.Vector2 get_localMousePosition();
            UnityEngine.Vector2 get_mouseDelta();
            int get_clickCount();
            int get_button();
            int get_pressedButtons();
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
        }

        interface IMouseEventInternal
        {
            bool get_triggeredByOS();
            void set_triggeredByOS(bool value);
            bool get_recomputeTopElementUnderMouse();
            void set_recomputeTopElementUnderMouse(bool value);
            UnityEngine.UIElements.IPointerEvent get_sourcePointerEvent();
            void set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value);
        }

        class MouseEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IMouseEvent, UnityEngine.UIElements.IMouseEventInternal
        {
            /*0x0*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <mousePosition>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <localMousePosition>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <mouseDelta>k__BackingField;
            /*0x0*/ int <clickCount>k__BackingField;
            /*0x0*/ int <button>k__BackingField;
            /*0x0*/ int <pressedButtons>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField;

            static T GetPooled(UnityEngine.Event systemEvent);
            static T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition, bool recomputeTopElementUnderMouse);
            static T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent);
            static T GetPooled(UnityEngine.UIElements.IPointerEvent pointerEvent);
            MouseEventBase();
            UnityEngine.EventModifiers get_modifiers();
            void set_modifiers(UnityEngine.EventModifiers value);
            UnityEngine.Vector2 get_mousePosition();
            void set_mousePosition(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_localMousePosition();
            void set_localMousePosition(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_mouseDelta();
            void set_mouseDelta(UnityEngine.Vector2 value);
            int get_clickCount();
            void set_clickCount(int value);
            int get_button();
            void set_button(int value);
            int get_pressedButtons();
            void set_pressedButtons(int value);
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS();
            void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value);
            bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse();
            void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value);
            UnityEngine.UIElements.IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent();
            void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value);
            void Init();
            void LocalInit();
            UnityEngine.UIElements.IEventHandler get_currentTarget();
            void set_currentTarget(UnityEngine.UIElements.IEventHandler value);
            void PreDispatch(UnityEngine.UIElements.IPanel panel);
            void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseDownEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseDownEvent>
        {
            static /*0x1a49388*/ UnityEngine.UIElements.MouseDownEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent);
            static /*0x1a47710*/ UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerDownEvent pointerEvent);
            static /*0x1a47edc*/ UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent);
            /*0x1a49334*/ MouseDownEvent();
            /*0x1a492d4*/ void Init();
            /*0x1a49328*/ void LocalInit();
        }

        class MouseUpEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseUpEvent>
        {
            static /*0x1a495c8*/ UnityEngine.UIElements.MouseUpEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent);
            static /*0x1a485a0*/ UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent);
            static /*0x1a47ee0*/ UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent);
            static /*0x1a48a78*/ UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerCancelEvent pointerEvent);
            /*0x1a49574*/ MouseUpEvent();
            /*0x1a49514*/ void Init();
            /*0x1a49568*/ void LocalInit();
        }

        class MouseMoveEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseMoveEvent>
        {
            static /*0x1a47ee4*/ UnityEngine.UIElements.MouseMoveEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent);
            /*0x1a497b4*/ MouseMoveEvent();
            /*0x1a49754*/ void Init();
            /*0x1a497a8*/ void LocalInit();
        }

        class ContextClickEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.ContextClickEvent>
        {
            /*0x1a49808*/ ContextClickEvent();
        }

        class WheelEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.WheelEvent>
        {
            /*0xb0*/ UnityEngine.Vector3 <delta>k__BackingField;

            static /*0x1a49868*/ UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Event systemEvent);
            static /*0x1a498e4*/ UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Vector3 delta, UnityEngine.UIElements.IPointerEvent pointerEvent);
            /*0x1a49a0c*/ WheelEvent();
            /*0x1a49850*/ UnityEngine.Vector3 get_delta();
            /*0x1a4985c*/ void set_delta(UnityEngine.Vector3 value);
            /*0x1a4995c*/ void Init();
            /*0x1a499ac*/ void LocalInit();
        }

        class MouseEnterEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseEnterEvent>
        {
            /*0x1a49abc*/ MouseEnterEvent();
            /*0x1a49a5c*/ void Init();
            /*0x1a49ab0*/ void LocalInit();
        }

        class MouseLeaveEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseLeaveEvent>
        {
            /*0x1a49b70*/ MouseLeaveEvent();
            /*0x1a49b10*/ void Init();
            /*0x1a49b64*/ void LocalInit();
        }

        class MouseEnterWindowEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseEnterWindowEvent>
        {
            /*0x1a49c24*/ MouseEnterWindowEvent();
            /*0x1a49bc4*/ void Init();
            /*0x1a49c18*/ void LocalInit();
            /*0x1a49c78*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseLeaveWindowEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseLeaveWindowEvent>
        {
            static /*0x1a49f18*/ UnityEngine.UIElements.MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent);
            /*0x1a49ec8*/ MouseLeaveWindowEvent();
            /*0x1a49dd4*/ void Init();
            /*0x1a49e24*/ void LocalInit();
            /*0x1a49fcc*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseOverEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseOverEvent>
        {
            /*0x1a4a128*/ MouseOverEvent();
        }

        class MouseOutEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseOutEvent>
        {
            /*0x1a4a170*/ MouseOutEvent();
        }

        class ContextualMenuPopulateEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.ContextualMenuPopulateEvent>
        {
            /*0xb0*/ UnityEngine.UIElements.DropdownMenu <menu>k__BackingField;
            /*0xb8*/ UnityEngine.UIElements.EventBase <triggerEvent>k__BackingField;
            /*0xc0*/ UnityEngine.UIElements.ContextualMenuManager m_ContextualMenuManager;

            /*0x1a4a27c*/ ContextualMenuPopulateEvent();
            /*0x1a4a1b8*/ UnityEngine.UIElements.DropdownMenu get_menu();
            /*0x1a4a1c0*/ void set_menu(UnityEngine.UIElements.DropdownMenu value);
            /*0x1a4a1c8*/ UnityEngine.UIElements.EventBase get_triggerEvent();
            /*0x1a4a1d0*/ void set_triggerEvent(UnityEngine.UIElements.EventBase value);
            /*0x1a4a1d8*/ void Init();
            /*0x1a4a248*/ void LocalInit();
            /*0x1a4a2ec*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        interface ICommandEvent
        {
        }

        class CommandEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.ICommandEvent
        {
            /*0x0*/ string m_CommandName;

            static T GetPooled(UnityEngine.Event systemEvent);
            static T GetPooled(string commandName);
            CommandEventBase();
            string get_commandName();
            void set_commandName(string value);
            void Init();
            void LocalInit();
        }

        class ValidateCommandEvent : UnityEngine.UIElements.CommandEventBase<UnityEngine.UIElements.ValidateCommandEvent>
        {
            /*0x1a4a37c*/ ValidateCommandEvent();
        }

        class ExecuteCommandEvent : UnityEngine.UIElements.CommandEventBase<UnityEngine.UIElements.ExecuteCommandEvent>
        {
            /*0x1a4a3c4*/ ExecuteCommandEvent();
        }

        class FocusEventBase<T> : UnityEngine.UIElements.EventBase<T>
        {
            /*0x0*/ UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.FocusController <focusController>k__BackingField;
            /*0x0*/ bool <IsFocusDelegated>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.Focusable relatedTarget, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.FocusController focusController, bool bIsFocusDelegated);
            FocusEventBase();
            UnityEngine.UIElements.Focusable get_relatedTarget();
            void set_relatedTarget(UnityEngine.UIElements.Focusable value);
            UnityEngine.UIElements.FocusChangeDirection get_direction();
            void set_direction(UnityEngine.UIElements.FocusChangeDirection value);
            UnityEngine.UIElements.FocusController get_focusController();
            void set_focusController(UnityEngine.UIElements.FocusController value);
            bool get_IsFocusDelegated();
            void set_IsFocusDelegated(bool value);
            void Init();
            void LocalInit();
        }

        class FocusOutEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.FocusOutEvent>
        {
            /*0x1a4a46c*/ FocusOutEvent();
            /*0x1a4a40c*/ void Init();
            /*0x1a4a460*/ void LocalInit();
        }

        class BlurEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.BlurEvent>
        {
            /*0x1a4a53c*/ BlurEvent();
            /*0x1a4a4c0*/ void PreDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class FocusInEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.FocusInEvent>
        {
            /*0x1a4a5e4*/ FocusInEvent();
            /*0x1a4a584*/ void Init();
            /*0x1a4a5d8*/ void LocalInit();
        }

        class FocusEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.FocusEvent>
        {
            /*0x1a4a6e0*/ FocusEvent();
            /*0x1a4a638*/ void PreDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            static /*0x1a4a924*/ bool SendEventToTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x1a4a960*/ bool SendEventToRegularTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x1a4a998*/ bool SendEventToIMGUIContainer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x1a4a884*/ void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x1a4abb8*/ void UpdateElementUnderMouse(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel, ref UnityEngine.UIElements.VisualElement elementUnderMouse);
            static /*0x1a4ab70*/ bool IsDone(UnityEngine.UIElements.EventBase evt);
            /*0x1a4aeb4*/ MouseEventDispatchingStrategy();
            /*0x1a4a728*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a4a77c*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel iPanel);
        }

        class IMGUIEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a4aff4*/ IMGUIEventDispatchingStrategy();
            /*0x1a4aebc*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a4af34*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        interface IKeyboardEvent
        {
            UnityEngine.EventModifiers get_modifiers();
            char get_character();
            UnityEngine.KeyCode get_keyCode();
        }

        class KeyboardEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IKeyboardEvent
        {
            /*0x0*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x0*/ char <character>k__BackingField;
            /*0x0*/ UnityEngine.KeyCode <keyCode>k__BackingField;

            static T GetPooled(char c, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers);
            static T GetPooled(UnityEngine.Event systemEvent);
            KeyboardEventBase();
            UnityEngine.EventModifiers get_modifiers();
            void set_modifiers(UnityEngine.EventModifiers value);
            char get_character();
            void set_character(char value);
            UnityEngine.KeyCode get_keyCode();
            void set_keyCode(UnityEngine.KeyCode value);
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool get_actionKey();
            void Init();
            void LocalInit();
        }

        class KeyDownEvent : UnityEngine.UIElements.KeyboardEventBase<UnityEngine.UIElements.KeyDownEvent>
        {
            /*0x1a4b0bc*/ KeyDownEvent();
            /*0x1a4affc*/ void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent);
        }

        class KeyUpEvent : UnityEngine.UIElements.KeyboardEventBase<UnityEngine.UIElements.KeyUpEvent>
        {
            /*0x1a4b104*/ KeyUpEvent();
        }

        class PanelChangedEventBase<T> : UnityEngine.UIElements.EventBase<T>
        {
            /*0x0*/ UnityEngine.UIElements.IPanel <originPanel>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.IPanel <destinationPanel>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.IPanel originPanel, UnityEngine.UIElements.IPanel destinationPanel);
            PanelChangedEventBase();
            UnityEngine.UIElements.IPanel get_originPanel();
            void set_originPanel(UnityEngine.UIElements.IPanel value);
            UnityEngine.UIElements.IPanel get_destinationPanel();
            void set_destinationPanel(UnityEngine.UIElements.IPanel value);
            void Init();
            void LocalInit();
        }

        class AttachToPanelEvent : UnityEngine.UIElements.PanelChangedEventBase<UnityEngine.UIElements.AttachToPanelEvent>
        {
            /*0x1a4b14c*/ AttachToPanelEvent();
        }

        class DetachFromPanelEvent : UnityEngine.UIElements.PanelChangedEventBase<UnityEngine.UIElements.DetachFromPanelEvent>
        {
            /*0x1a4b194*/ DetachFromPanelEvent();
        }

        class InputEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.InputEvent>
        {
            /*0x80*/ string <previousData>k__BackingField;
            /*0x88*/ string <newData>k__BackingField;

            static /*0x1a4b254*/ UnityEngine.UIElements.InputEvent GetPooled(string previousData, string newData);
            /*0x1a4b2d8*/ InputEvent();
            /*0x1a4b1dc*/ void set_previousData(string value);
            /*0x1a4b1e4*/ void set_newData(string value);
            /*0x1a4b1ec*/ void Init();
            /*0x1a4b244*/ void LocalInit();
        }

        interface INavigationEvent
        {
        }

        class NavigationEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.INavigationEvent
        {
            NavigationEventBase();
            void Init();
            void LocalInit();
        }

        class NavigationMoveEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationMoveEvent>
        {
            /*0x7c*/ UnityEngine.UIElements.NavigationMoveEvent.Direction <direction>k__BackingField;
            /*0x80*/ UnityEngine.Vector2 <move>k__BackingField;

            static /*0x1a4b354*/ UnityEngine.UIElements.NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x1a4b3c0*/ UnityEngine.UIElements.NavigationMoveEvent GetPooled(UnityEngine.Vector2 moveVector);
            /*0x1a4b528*/ NavigationMoveEvent();
            /*0x1a4b3a8*/ UnityEngine.UIElements.NavigationMoveEvent.Direction get_direction();
            /*0x1a4b3b0*/ void set_direction(UnityEngine.UIElements.NavigationMoveEvent.Direction value);
            /*0x1a4b3b8*/ void set_move(UnityEngine.Vector2 value);
            /*0x1a4b4a0*/ void Init();

            enum Direction
            {
                None = 0,
                Left = 1,
                Up = 2,
                Right = 3,
                Down = 4,
            }
        }

        class NavigationTabEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationTabEvent>
        {
            /*0x7c*/ UnityEngine.UIElements.NavigationTabEvent.Direction <direction>k__BackingField;

            static /*0x1a4b588*/ UnityEngine.UIElements.NavigationTabEvent.Direction DetermineMoveDirection(int moveValue);
            static /*0x1a4b5a4*/ UnityEngine.UIElements.NavigationTabEvent GetPooled(int moveValue);
            /*0x1a4b680*/ NavigationTabEvent();
            /*0x1a4b580*/ void set_direction(UnityEngine.UIElements.NavigationTabEvent.Direction value);
            /*0x1a4b630*/ void Init();

            enum Direction
            {
                None = 0,
                Next = 1,
                Previous = 2,
            }
        }

        class NavigationCancelEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationCancelEvent>
        {
            /*0x1a4b6d8*/ NavigationCancelEvent();
        }

        class NavigationSubmitEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationSubmitEvent>
        {
            /*0x1a4b720*/ NavigationSubmitEvent();
        }

        class CommandEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x1a4bb18*/ CommandEventDispatchingStrategy();
            /*0x1a4b768*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x1a4b7bc*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        enum PropagationPhase
        {
            None = 0,
            TrickleDown = 1,
            AtTarget = 2,
            DefaultActionAtTarget = 5,
            BubbleUp = 3,
            DefaultAction = 4,
        }

        interface IEventDispatchingStrategy
        {
            bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class EventDispatchUtilities
        {
            static /*0x1a44234*/ void PropagateEvent(UnityEngine.UIElements.EventBase evt);
            static /*0x1a4498c*/ void PropagateToIMGUIContainer(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.EventBase evt);
            static /*0x1a4bb20*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class StyleComplexSelector
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector.PseudoStateData> s_PseudoStates;
            /*0x10*/ int m_Specificity;
            /*0x18*/ UnityEngine.UIElements.StyleRule <rule>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.StyleSelector[] m_Selectors;
            /*0x28*/ int ruleIndex;
            /*0x30*/ UnityEngine.UIElements.StyleComplexSelector nextInTable;
            /*0x38*/ int orderInStyleSheet;

            /*0x1a4c430*/ StyleComplexSelector();
            /*0x1a4bcc8*/ int get_specificity();
            /*0x1a4bcd0*/ UnityEngine.UIElements.StyleRule get_rule();
            /*0x1a4bcd8*/ void set_rule(UnityEngine.UIElements.StyleRule value);
            /*0x1a4bce0*/ UnityEngine.UIElements.StyleSelector[] get_selectors();
            /*0x1a4bce8*/ void set_selectors(UnityEngine.UIElements.StyleSelector[] value);
            /*0x1a4bcf0*/ void CachePseudoStateMasks();
            /*0x1a4c2c0*/ string ToString();

            struct PseudoStateData
            {
                /*0x10*/ UnityEngine.UIElements.PseudoStates state;
                /*0x14*/ bool negate;

                /*0x1c100d0*/ PseudoStateData(UnityEngine.UIElements.PseudoStates state, bool negate);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.StyleComplexSelector.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UIElements.StyleSelector, string> <>9__20_0;

                static /*0x1c100e0*/ <>c();
                /*0x1c10144*/ <>c();
                /*0x1c1014c*/ string <ToString>b__20_0(UnityEngine.UIElements.StyleSelector x);
            }
        }

        class StyleProperty
        {
            /*0x10*/ string m_Name;
            /*0x18*/ int m_Line;
            /*0x20*/ UnityEngine.UIElements.StyleValueHandle[] m_Values;
            /*0x28*/ bool isCustomProperty;
            /*0x29*/ bool requireVariableResolve;

            /*0x1c1017c*/ StyleProperty();
            /*0x1c1016c*/ string get_name();
            /*0x1c10174*/ UnityEngine.UIElements.StyleValueHandle[] get_values();
        }

        enum StyleValueType
        {
            Invalid = 0,
            Keyword = 1,
            Float = 2,
            Dimension = 3,
            Color = 4,
            ResourcePath = 5,
            AssetReference = 6,
            Enum = 7,
            Variable = 8,
            String = 9,
            Function = 10,
            CommaSeparator = 11,
            ScalableImage = 12,
            MissingAssetReference = 13,
        }

        struct StyleSelectorPart
        {
            /*0x10*/ string m_Value;
            /*0x18*/ UnityEngine.UIElements.StyleSelectorType m_Type;
            /*0x20*/ object tempData;

            static /*0x1c102ac*/ UnityEngine.UIElements.StyleSelectorPart CreateClass(string className);
            static /*0x1c102c4*/ UnityEngine.UIElements.StyleSelectorPart CreateId(string Id);
            static /*0x1c102dc*/ UnityEngine.UIElements.StyleSelectorPart CreatePredicate(object predicate);
            /*0x1c10184*/ string get_value();
            /*0x1c1018c*/ UnityEngine.UIElements.StyleSelectorType get_type();
            /*0x1c10194*/ void set_type(UnityEngine.UIElements.StyleSelectorType value);
            /*0x1c1019c*/ string ToString();
        }

        struct StyleVariable
        {
            /*0x10*/ string name;
            /*0x18*/ UnityEngine.UIElements.StyleSheet sheet;
            /*0x20*/ UnityEngine.UIElements.StyleValueHandle[] handles;

            /*0x1c102f4*/ StyleVariable(string name, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles);
            /*0x1c10300*/ int GetHashCode();
        }

        class StyleVariableContext
        {
            static /*0x0*/ UnityEngine.UIElements.StyleVariableContext none;
            /*0x10*/ int m_VariableHash;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleVariable> m_Variables;
            /*0x20*/ System.Collections.Generic.List<int> m_SortedHash;

            static /*0x1c10954*/ StyleVariableContext();
            /*0x1c106ac*/ StyleVariableContext();
            /*0x1c10774*/ StyleVariableContext(UnityEngine.UIElements.StyleVariableContext other);
            /*0x1c10378*/ void Add(UnityEngine.UIElements.StyleVariable sv);
            /*0x1c10518*/ void AddInitialRange(UnityEngine.UIElements.StyleVariableContext other);
            /*0x1c10610*/ void Clear();
            /*0x1c10860*/ bool TryFindVariable(string name, ref UnityEngine.UIElements.StyleVariable v);
            /*0x1c1094c*/ int GetVariableHash();
        }

        class StyleVariableResolver
        {
            static int kMaxResolves = 100;
            static /*0x0*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser;
            /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues;
            /*0x20*/ System.Collections.Generic.Stack<string> m_ResolvedVarStack;
            /*0x28*/ UnityEngine.UIElements.StyleProperty m_Property;
            /*0x30*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleVariableResolver.ResolveContext> m_ContextStack;
            /*0x38*/ UnityEngine.UIElements.StyleVariableResolver.ResolveContext m_CurrentContext;
            /*0x48*/ UnityEngine.UIElements.StyleVariableContext <variableContext>k__BackingField;

            static /*0x1c117f8*/ StyleVariableResolver();
            static /*0x1c10cec*/ void ParseVarFunction(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles, ref int index, ref int argCount, ref string variableName);
            /*0x1c116c4*/ StyleVariableResolver();
            /*0x1c109b4*/ UnityEngine.UIElements.StyleSheet get_currentSheet();
            /*0x1c109bc*/ UnityEngine.UIElements.StyleValueHandle[] get_currentHandles();
            /*0x1c109c4*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues();
            /*0x1c109cc*/ UnityEngine.UIElements.StyleVariableContext get_variableContext();
            /*0x1c109d4*/ void set_variableContext(UnityEngine.UIElements.StyleVariableContext value);
            /*0x1c109dc*/ void Init(UnityEngine.UIElements.StyleProperty property, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles);
            /*0x1c10a8c*/ void PushContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles);
            /*0x1c10af8*/ void PopContext();
            /*0x1c10b74*/ void AddValue(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c10c20*/ bool ResolveVarFunction(ref int index);
            /*0x1c10d9c*/ UnityEngine.UIElements.StyleVariableResolver.Result ResolveVarFunction(ref int index, int argc, string varName);
            /*0x1c113fc*/ bool ValidateResolvedValues();
            /*0x1c10ef8*/ UnityEngine.UIElements.StyleVariableResolver.Result ResolveVariable(string variableName);
            /*0x1c11178*/ UnityEngine.UIElements.StyleVariableResolver.Result ResolveFallback(ref int index);

            enum Result
            {
                Valid = 0,
                Invalid = 1,
                NotFound = 2,
            }

            struct ResolveContext
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ UnityEngine.UIElements.StyleValueHandle[] handles;
            }
        }

        enum StyleSelectorRelationship
        {
            None = 0,
            Child = 1,
            Descendent = 2,
        }

        class StyleSelector
        {
            /*0x10*/ UnityEngine.UIElements.StyleSelectorPart[] m_Parts;
            /*0x18*/ UnityEngine.UIElements.StyleSelectorRelationship m_PreviousRelationship;
            /*0x1c*/ int pseudoStateMask;
            /*0x20*/ int negatedPseudoStateMask;

            /*0x1c119d0*/ StyleSelector();
            /*0x1c11870*/ UnityEngine.UIElements.StyleSelectorPart[] get_parts();
            /*0x1c11878*/ void set_parts(UnityEngine.UIElements.StyleSelectorPart[] value);
            /*0x1c11880*/ UnityEngine.UIElements.StyleSelectorRelationship get_previousRelationship();
            /*0x1c11888*/ void set_previousRelationship(UnityEngine.UIElements.StyleSelectorRelationship value);
            /*0x1c11890*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.StyleSelector.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UIElements.StyleSelectorPart, string> <>9__10_0;

                static /*0x1c119e0*/ <>c();
                /*0x1c11a44*/ <>c();
                /*0x1c11a4c*/ string <ToString>b__10_0(UnityEngine.UIElements.StyleSelectorPart p);
            }
        }

        class ThemeStyleSheet : UnityEngine.UIElements.StyleSheet
        {
            /*0x1c11bd4*/ ThemeStyleSheet();
            /*0x1c11a54*/ void OnEnable();
        }

        enum StyleValueFunction
        {
            Unknown = 0,
            Var = 1,
            Env = 2,
            LinearGradient = 3,
        }

        class StyleValueFunctionExtension
        {
            static /*0x1c11c34*/ string ToUssString(UnityEngine.UIElements.StyleValueFunction svf);
        }

        class StyleRule
        {
            /*0x10*/ UnityEngine.UIElements.StyleProperty[] m_Properties;
            /*0x18*/ int line;
            /*0x1c*/ int customPropertiesCount;

            /*0x1c11d30*/ StyleRule();
            /*0x1c11d28*/ UnityEngine.UIElements.StyleProperty[] get_properties();
        }

        struct StyleValueHandle
        {
            /*0x10*/ UnityEngine.UIElements.StyleValueType m_ValueType;
            /*0x14*/ int valueIndex;

            /*0x1c11170*/ UnityEngine.UIElements.StyleValueType get_valueType();
            /*0x1c11d38*/ void set_valueType(UnityEngine.UIElements.StyleValueType value);
        }

        class StyleSheet : UnityEngine.ScriptableObject
        {
            static /*0x0*/ string kCustomPropertyMarker;
            /*0x18*/ bool m_ImportedWithErrors;
            /*0x19*/ bool m_ImportedWithWarnings;
            /*0x20*/ UnityEngine.UIElements.StyleRule[] m_Rules;
            /*0x28*/ UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors;
            /*0x30*/ float[] floats;
            /*0x38*/ UnityEngine.UIElements.StyleSheets.Dimension[] dimensions;
            /*0x40*/ UnityEngine.Color[] colors;
            /*0x48*/ string[] strings;
            /*0x50*/ UnityEngine.Object[] assets;
            /*0x58*/ UnityEngine.UIElements.StyleSheet.ImportStruct[] imports;
            /*0x60*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_FlattenedImportedStyleSheets;
            /*0x68*/ int m_ContentHash;
            /*0x70*/ UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages;
            /*0x78*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector> orderedNameSelectors;
            /*0x80*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector> orderedTypeSelectors;
            /*0x88*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector> orderedClassSelectors;
            /*0x90*/ bool m_IsDefaultStyleSheet;

            static /*0x1c130d4*/ StyleSheet();
            static bool TryCheckAccess<T>(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle, ref T value);
            static T CheckAccess<T>(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle);
            static /*0x1c124c8*/ bool CustomStartsWith(string originalString, string pattern);
            /*0x1c11c2c*/ StyleSheet();
            /*0x1c11d40*/ bool get_importedWithErrors();
            /*0x1c11d48*/ void set_importedWithErrors(bool value);
            /*0x1c11d54*/ bool get_importedWithWarnings();
            /*0x1c11d5c*/ void set_importedWithWarnings(bool value);
            /*0x1c11d68*/ UnityEngine.UIElements.StyleRule[] get_rules();
            /*0x1c11d70*/ void set_rules(UnityEngine.UIElements.StyleRule[] value);
            /*0x1c122d4*/ UnityEngine.UIElements.StyleComplexSelector[] get_complexSelectors();
            /*0x1c122dc*/ void set_complexSelectors(UnityEngine.UIElements.StyleComplexSelector[] value);
            /*0x1c122e4*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports();
            /*0x1c122ec*/ int get_contentHash();
            /*0x1c122f4*/ void set_contentHash(int value);
            /*0x1c122fc*/ bool get_isDefaultStyleSheet();
            /*0x1c11a70*/ void set_isDefaultStyleSheet(bool value);
            /*0x1c11bd0*/ void OnEnable();
            /*0x1c12304*/ void FlattenImportedStyleSheetsRecursive();
            /*0x1c12380*/ void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet sheet);
            /*0x1c11d78*/ void SetupReferences();
            /*0x1c1258c*/ UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c1156c*/ float ReadFloat(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12594*/ bool TryReadFloat(UnityEngine.UIElements.StyleValueHandle handle, ref float value);
            /*0x1c12688*/ UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12778*/ bool TryReadDimension(UnityEngine.UIElements.StyleValueHandle handle, ref UnityEngine.UIElements.StyleSheets.Dimension value);
            /*0x1c12894*/ UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12918*/ bool TryReadColor(UnityEngine.UIElements.StyleValueHandle handle, ref UnityEngine.Color value);
            /*0x1c129a4*/ string ReadString(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12a28*/ bool TryReadString(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x1c12ab4*/ string ReadEnum(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12b38*/ bool TryReadEnum(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x1c11640*/ string ReadVariable(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12bc4*/ bool TryReadVariable(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x1c12c50*/ string ReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12cd4*/ bool TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x1c12d60*/ UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12de4*/ string ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12e68*/ bool TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle, ref UnityEngine.Object value);
            /*0x1c12ef4*/ UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c12efc*/ string ReadFunctionName(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x1c13050*/ UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle handle);

            struct ImportStruct
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet styleSheet;
                /*0x18*/ string[] mediaQueries;
            }
        }

        enum StyleValueKeyword
        {
            Inherit = 0,
            Initial = 1,
            Auto = 2,
            Unset = 3,
            True = 4,
            False = 5,
            None = 6,
        }

        class StyleValueKeywordExtension
        {
            static /*0x1c13134*/ string ToUssString(UnityEngine.UIElements.StyleValueKeyword svk);
        }

        enum StyleSelectorType
        {
            Unknown = 0,
            Wildcard = 1,
            Type = 2,
            Class = 3,
            PseudoClass = 4,
            RecursivePseudoClass = 5,
            ID = 6,
            Predicate = 7,
        }

        struct StyleScale : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Scale>, System.IEquatable<UnityEngine.UIElements.StyleScale>
        {
            /*0x10*/ UnityEngine.UIElements.Scale m_Value;
            /*0x20*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c132a8*/ bool op_Equality(UnityEngine.UIElements.StyleScale lhs, UnityEngine.UIElements.StyleScale rhs);
            static /*0x1c1336c*/ UnityEngine.UIElements.StyleScale op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c13290*/ StyleScale(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1329c*/ StyleScale(UnityEngine.UIElements.Scale v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c13254*/ UnityEngine.UIElements.Scale get_value();
            /*0x1c13288*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c13378*/ bool Equals(UnityEngine.UIElements.StyleScale other);
            /*0x1c133ec*/ bool Equals(object obj);
            /*0x1c134bc*/ int GetHashCode();
            /*0x1c13530*/ string ToString();
        }

        struct FontDefinition : System.IEquatable<UnityEngine.UIElements.FontDefinition>
        {
            /*0x10*/ UnityEngine.Font m_Font;
            /*0x18*/ UnityEngine.TextCore.Text.FontAsset m_FontAsset;

            static /*0x1c135c8*/ UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font f);
            static /*0x1c135d0*/ UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset f);
            static /*0x1c135dc*/ UnityEngine.UIElements.FontDefinition FromObject(object obj);
            static /*0x1c139bc*/ bool op_Equality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right);
            static /*0x1c139e8*/ bool op_Inequality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right);
            /*0x1c135b8*/ UnityEngine.Font get_font();
            /*0x1c135c0*/ UnityEngine.TextCore.Text.FontAsset get_fontAsset();
            /*0x1c136f4*/ bool IsEmpty();
            /*0x1c1378c*/ string ToString();
            /*0x1c1381c*/ bool Equals(UnityEngine.UIElements.FontDefinition other);
            /*0x1c13864*/ bool Equals(object obj);
            /*0x1c138dc*/ int GetHashCode();
        }

        enum EasingMode
        {
            Ease = 0,
            EaseIn = 1,
            EaseOut = 2,
            EaseInOut = 3,
            Linear = 4,
            EaseInSine = 5,
            EaseOutSine = 6,
            EaseInOutSine = 7,
            EaseInCubic = 8,
            EaseOutCubic = 9,
            EaseInOutCubic = 10,
            EaseInCirc = 11,
            EaseOutCirc = 12,
            EaseInOutCirc = 13,
            EaseInElastic = 14,
            EaseOutElastic = 15,
            EaseInOutElastic = 16,
            EaseInBack = 17,
            EaseOutBack = 18,
            EaseInOutBack = 19,
            EaseInBounce = 20,
            EaseOutBounce = 21,
            EaseInOutBounce = 22,
        }

        struct EasingFunction : System.IEquatable<UnityEngine.UIElements.EasingFunction>
        {
            /*0x10*/ UnityEngine.UIElements.EasingMode m_Mode;

            static /*0x1c13a28*/ UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode easingMode);
            static /*0x1c13a30*/ bool op_Equality(UnityEngine.UIElements.EasingFunction lhs, UnityEngine.UIElements.EasingFunction rhs);
            /*0x1c13a20*/ EasingFunction(UnityEngine.UIElements.EasingMode mode);
            /*0x1c13a18*/ UnityEngine.UIElements.EasingMode get_mode();
            /*0x1c13a3c*/ bool Equals(UnityEngine.UIElements.EasingFunction other);
            /*0x1c13a4c*/ bool Equals(object obj);
            /*0x1c13ac4*/ string ToString();
            /*0x1c13b2c*/ int GetHashCode();
        }

        struct ComputedTransitionProperty
        {
            /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId id;
            /*0x14*/ int durationMs;
            /*0x18*/ int delayMs;
            /*0x20*/ System.Func<float, float> easingCurve;
        }

        class ComputedTransitionUtils
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer;

            static /*0x1c15678*/ ComputedTransitionUtils();
            static /*0x1c13b34*/ void UpdateComputedTransitions(ref UnityEngine.UIElements.ComputedStyle computedStyle);
            static /*0x1c13d3c*/ bool HasTransitionProperty(ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            static /*0x1c13e08*/ bool GetTransitionProperty(ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedTransitionProperty result);
            static /*0x1c13b98*/ UnityEngine.UIElements.ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref UnityEngine.UIElements.ComputedStyle computedStyle);
            static /*0x1c13f44*/ int GetTransitionHashCode(ref UnityEngine.UIElements.ComputedStyle cs);
            static /*0x1c14688*/ bool SameTransitionProperty(ref UnityEngine.UIElements.ComputedStyle x, ref UnityEngine.UIElements.ComputedStyle y);
            static /*0x1c147c8*/ bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b);
            static /*0x1c148b4*/ bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b);
            static /*0x1c143e0*/ void ComputeTransitionPropertyData(ref UnityEngine.UIElements.ComputedStyle computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData);
            static T GetWrappingTransitionData<T>(System.Collections.Generic.List<T> list, int i, T defaultValue);
            static /*0x1c149dc*/ int ConvertTransitionTime(UnityEngine.UIElements.TimeValue time);
            static /*0x1c14ad0*/ System.Func<float, float> ConvertTransitionFunction(UnityEngine.UIElements.EasingMode mode);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.ComputedTransitionUtils.<> <>9;
                static /*0x8*/ System.Func<float, float> <>9__12_0;
                static /*0x10*/ System.Func<float, float> <>9__12_1;
                static /*0x18*/ System.Func<float, float> <>9__12_2;
                static /*0x20*/ System.Func<float, float> <>9__12_3;
                static /*0x28*/ System.Func<float, float> <>9__12_4;
                static /*0x30*/ System.Func<float, float> <>9__12_5;
                static /*0x38*/ System.Func<float, float> <>9__12_6;
                static /*0x40*/ System.Func<float, float> <>9__12_7;
                static /*0x48*/ System.Func<float, float> <>9__12_8;
                static /*0x50*/ System.Func<float, float> <>9__12_9;
                static /*0x58*/ System.Func<float, float> <>9__12_10;
                static /*0x60*/ System.Func<float, float> <>9__12_11;
                static /*0x68*/ System.Func<float, float> <>9__12_12;
                static /*0x70*/ System.Func<float, float> <>9__12_13;
                static /*0x78*/ System.Func<float, float> <>9__12_14;
                static /*0x80*/ System.Func<float, float> <>9__12_15;
                static /*0x88*/ System.Func<float, float> <>9__12_16;
                static /*0x90*/ System.Func<float, float> <>9__12_17;
                static /*0x98*/ System.Func<float, float> <>9__12_18;
                static /*0xa0*/ System.Func<float, float> <>9__12_19;
                static /*0xa8*/ System.Func<float, float> <>9__12_20;
                static /*0xb0*/ System.Func<float, float> <>9__12_21;
                static /*0xb8*/ System.Func<float, float> <>9__12_22;

                static /*0x1c15704*/ <>c();
                /*0x1c15768*/ <>c();
                /*0x1c15770*/ float <ConvertTransitionFunction>b__12_0(float t);
                /*0x1c157a0*/ float <ConvertTransitionFunction>b__12_1(float t);
                /*0x1c157a8*/ float <ConvertTransitionFunction>b__12_2(float t);
                /*0x1c157b0*/ float <ConvertTransitionFunction>b__12_3(float t);
                /*0x1c157b8*/ float <ConvertTransitionFunction>b__12_4(float t);
                /*0x1c157c0*/ float <ConvertTransitionFunction>b__12_5(float t);
                /*0x1c157c8*/ float <ConvertTransitionFunction>b__12_6(float t);
                /*0x1c157d0*/ float <ConvertTransitionFunction>b__12_7(float t);
                /*0x1c157d8*/ float <ConvertTransitionFunction>b__12_8(float t);
                /*0x1c157e0*/ float <ConvertTransitionFunction>b__12_9(float t);
                /*0x1c157e8*/ float <ConvertTransitionFunction>b__12_10(float t);
                /*0x1c157f0*/ float <ConvertTransitionFunction>b__12_11(float t);
                /*0x1c157f8*/ float <ConvertTransitionFunction>b__12_12(float t);
                /*0x1c15800*/ float <ConvertTransitionFunction>b__12_13(float t);
                /*0x1c15808*/ float <ConvertTransitionFunction>b__12_14(float t);
                /*0x1c15810*/ float <ConvertTransitionFunction>b__12_15(float t);
                /*0x1c15818*/ float <ConvertTransitionFunction>b__12_16(float t);
                /*0x1c15820*/ float <ConvertTransitionFunction>b__12_17(float t);
                /*0x1c15828*/ float <ConvertTransitionFunction>b__12_18(float t);
                /*0x1c15830*/ float <ConvertTransitionFunction>b__12_19(float t);
                /*0x1c15838*/ float <ConvertTransitionFunction>b__12_20(float t);
                /*0x1c15840*/ float <ConvertTransitionFunction>b__12_21(float t);
                /*0x1c15848*/ float <ConvertTransitionFunction>b__12_22(float t);
            }
        }

        struct StyleColor : UnityEngine.UIElements.IStyleValue<UnityEngine.Color>, System.IEquatable<UnityEngine.UIElements.StyleColor>
        {
            /*0x10*/ UnityEngine.Color m_Value;
            /*0x20*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c158a0*/ bool op_Equality(UnityEngine.UIElements.StyleColor lhs, UnityEngine.UIElements.StyleColor rhs);
            static /*0x1c15904*/ UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color v);
            /*0x1c15880*/ StyleColor(UnityEngine.Color v);
            /*0x1c15890*/ StyleColor(UnityEngine.Color v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c15850*/ UnityEngine.Color get_value();
            /*0x1c15878*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c15914*/ bool Equals(UnityEngine.UIElements.StyleColor other);
            /*0x1c15978*/ bool Equals(object obj);
            /*0x1c15a08*/ int GetHashCode();
            /*0x1c15aa0*/ string ToString();
        }

        struct StyleTranslate : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Translate>, System.IEquatable<UnityEngine.UIElements.StyleTranslate>
        {
            /*0x10*/ UnityEngine.UIElements.Translate m_Value;
            /*0x28*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c15bc4*/ bool op_Equality(UnityEngine.UIElements.StyleTranslate lhs, UnityEngine.UIElements.StyleTranslate rhs);
            static /*0x1c15cd4*/ UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c15ce4*/ UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.Translate v);
            /*0x1c15b74*/ StyleTranslate(UnityEngine.UIElements.Translate v);
            /*0x1c15bb4*/ StyleTranslate(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c15b9c*/ StyleTranslate(UnityEngine.UIElements.Translate v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c15b28*/ UnityEngine.UIElements.Translate get_value();
            /*0x1c15b6c*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c15cfc*/ bool Equals(UnityEngine.UIElements.StyleTranslate other);
            /*0x1c15d40*/ bool Equals(object obj);
            /*0x1c15de0*/ int GetHashCode();
            /*0x1c15e78*/ string ToString();
        }

        struct StyleCursor : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Cursor>, System.IEquatable<UnityEngine.UIElements.StyleCursor>
        {
            /*0x10*/ UnityEngine.UIElements.Cursor m_Value;
            /*0x28*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c15f74*/ bool op_Equality(UnityEngine.UIElements.StyleCursor lhs, UnityEngine.UIElements.StyleCursor rhs);
            static /*0x1c15fd4*/ UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c15f4c*/ StyleCursor(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c15f5c*/ StyleCursor(UnityEngine.UIElements.Cursor v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c15f00*/ UnityEngine.UIElements.Cursor get_value();
            /*0x1c15f44*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c15fe4*/ bool Equals(UnityEngine.UIElements.StyleCursor other);
            /*0x1c16064*/ bool Equals(object obj);
            /*0x1c160ec*/ int GetHashCode();
            /*0x1c16114*/ string ToString();
        }

        struct Background : System.IEquatable<UnityEngine.UIElements.Background>
        {
            /*0x10*/ UnityEngine.Texture2D m_Texture;
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.RenderTexture m_RenderTexture;
            /*0x28*/ UnityEngine.UIElements.VectorImage m_VectorImage;

            static /*0x1c163a4*/ UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D t);
            static /*0x1c163d8*/ UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture rt);
            static /*0x1c1640c*/ UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite s);
            static /*0x1c16440*/ UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage vi);
            static /*0x1c16474*/ UnityEngine.UIElements.Background FromObject(object obj);
            static /*0x1c166cc*/ bool op_Equality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs);
            static /*0x1c167d4*/ bool op_Inequality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs);
            /*0x1c16194*/ UnityEngine.Texture2D get_texture();
            /*0x1c1619c*/ void set_texture(UnityEngine.Texture2D value);
            /*0x1c16218*/ UnityEngine.Sprite get_sprite();
            /*0x1c16220*/ void set_sprite(UnityEngine.Sprite value);
            /*0x1c1629c*/ UnityEngine.RenderTexture get_renderTexture();
            /*0x1c162a4*/ void set_renderTexture(UnityEngine.RenderTexture value);
            /*0x1c16320*/ UnityEngine.UIElements.VectorImage get_vectorImage();
            /*0x1c16328*/ void set_vectorImage(UnityEngine.UIElements.VectorImage value);
            /*0x1c1680c*/ bool Equals(UnityEngine.UIElements.Background other);
            /*0x1c16840*/ bool Equals(object obj);
            /*0x1c168d0*/ int GetHashCode();
            /*0x1c16968*/ string ToString();
        }

        struct StyleEnum<T> : UnityEngine.UIElements.IStyleValue<T>, System.IEquatable<UnityEngine.UIElements.StyleEnum<T>>
        {
            /*0x0*/ T m_Value;
            /*0x0*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static bool op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs);
            static bool op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs);
            static UnityEngine.UIElements.StyleEnum<T> op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v);
            StyleEnum(T v);
            StyleEnum(UnityEngine.UIElements.StyleKeyword keyword);
            StyleEnum(T v, UnityEngine.UIElements.StyleKeyword keyword);
            T get_value();
            UnityEngine.UIElements.StyleKeyword get_keyword();
            bool Equals(UnityEngine.UIElements.StyleEnum<T> other);
            bool Equals(object obj);
            int GetHashCode();
            string ToString();
        }

        struct Rotate : System.IEquatable<UnityEngine.UIElements.Rotate>
        {
            /*0x10*/ UnityEngine.UIElements.Angle m_Angle;
            /*0x18*/ UnityEngine.Vector3 m_Axis;
            /*0x24*/ bool m_IsNone;

            static /*0x1c16b00*/ UnityEngine.UIElements.Rotate Initial();
            static /*0x1c16b94*/ UnityEngine.UIElements.Rotate None();
            static /*0x1c16c14*/ bool op_Equality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs);
            static /*0x1c16cc0*/ bool op_Inequality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs);
            /*0x1c16aa0*/ Rotate(UnityEngine.UIElements.Angle angle);
            /*0x1c16c04*/ UnityEngine.UIElements.Angle get_angle();
            /*0x1c16c0c*/ void set_angle(UnityEngine.UIElements.Angle value);
            /*0x1c16d08*/ bool Equals(UnityEngine.UIElements.Rotate other);
            /*0x1c16d4c*/ bool Equals(object obj);
            /*0x1c16dec*/ int GetHashCode();
            /*0x1c16eac*/ string ToString();
            /*0x1c170ec*/ UnityEngine.Quaternion ToQuaternion();
        }

        struct ComputedStyle
        {
            /*0x10*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.InheritedData> inheritedData;
            /*0x18*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.LayoutData> layoutData;
            /*0x20*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.RareData> rareData;
            /*0x28*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransformData> transformData;
            /*0x30*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransitionData> transitionData;
            /*0x38*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.VisualData> visualData;
            /*0x40*/ UnityEngine.Yoga.YogaNode yogaNode;
            /*0x48*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties;
            /*0x50*/ long matchingRulesHash;
            /*0x58*/ float dpiScaling;
            /*0x60*/ UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions;

            static /*0x1bfe328*/ UnityEngine.UIElements.VersionChangeType CompareChanges(ref UnityEngine.UIElements.ComputedStyle x, ref UnityEngine.UIElements.ComputedStyle y);
            static /*0x1bfe92c*/ bool StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleTranslate translate, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            static /*0x1bff5f8*/ UnityEngine.UIElements.ComputedStyle Create(ref UnityEngine.UIElements.ComputedStyle parentStyle);
            static /*0x1bff768*/ UnityEngine.UIElements.ComputedStyle CreateInitial();
            static /*0x1c04724*/ bool StartAnimation(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle oldStyle, ref UnityEngine.UIElements.ComputedStyle newStyle, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            static /*0x1c08b68*/ bool StartAnimationAllProperty(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle oldStyle, ref UnityEngine.UIElements.ComputedStyle newStyle, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            static /*0x1c0c5d4*/ bool StartAnimationInline(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StyleValue sv, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x1bfb794*/ int get_customPropertiesCount();
            /*0x1bfb7ec*/ bool get_hasTransition();
            /*0x1bfb80c*/ void FinalizeApply(ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1bfb95c*/ void SyncWithLayout(UnityEngine.Yoga.YogaNode targetNode);
            /*0x1bfc7e0*/ bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1bfc8e8*/ bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleKeyword keyword, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1bfdfe4*/ void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader);
            /*0x1bfe090*/ void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader);
            /*0x1bfe180*/ void ApplyAllPropertyInitial();
            /*0x1bfe320*/ void ResetComputedTransitions();
            /*0x1bfc650*/ UnityEngine.UIElements.Align get_alignContent();
            /*0x1bfc6a0*/ UnityEngine.UIElements.Align get_alignItems();
            /*0x1bfc470*/ UnityEngine.UIElements.Align get_alignSelf();
            /*0x1bfeb44*/ UnityEngine.Color get_backgroundColor();
            /*0x1bfeb98*/ UnityEngine.UIElements.Background get_backgroundImage();
            /*0x1bfebf8*/ UnityEngine.Color get_borderBottomColor();
            /*0x1bfe610*/ UnityEngine.UIElements.Length get_borderBottomLeftRadius();
            /*0x1bfe660*/ UnityEngine.UIElements.Length get_borderBottomRightRadius();
            /*0x1bfc2e0*/ float get_borderBottomWidth();
            /*0x1bfec4c*/ UnityEngine.Color get_borderLeftColor();
            /*0x1bfc1f0*/ float get_borderLeftWidth();
            /*0x1bfeca0*/ UnityEngine.Color get_borderRightColor();
            /*0x1bfc290*/ float get_borderRightWidth();
            /*0x1bfecf4*/ UnityEngine.Color get_borderTopColor();
            /*0x1bfe6b0*/ UnityEngine.UIElements.Length get_borderTopLeftRadius();
            /*0x1bfe700*/ UnityEngine.UIElements.Length get_borderTopRightRadius();
            /*0x1bfc240*/ float get_borderTopWidth();
            /*0x1bfbf20*/ UnityEngine.UIElements.Length get_bottom();
            /*0x1bfed48*/ UnityEngine.Color get_color();
            /*0x1bfed9c*/ UnityEngine.UIElements.Cursor get_cursor();
            /*0x1bfc790*/ UnityEngine.UIElements.DisplayStyle get_display();
            /*0x1bfbde0*/ UnityEngine.UIElements.Length get_flexBasis();
            /*0x1bfc600*/ UnityEngine.UIElements.FlexDirection get_flexDirection();
            /*0x1bfbd40*/ float get_flexGrow();
            /*0x1bfbd90*/ float get_flexShrink();
            /*0x1bfc740*/ UnityEngine.UIElements.Wrap get_flexWrap();
            /*0x1bfb90c*/ UnityEngine.UIElements.Length get_fontSize();
            /*0x1bfc380*/ UnityEngine.UIElements.Length get_height();
            /*0x1bfc6f0*/ UnityEngine.UIElements.Justify get_justifyContent();
            /*0x1bfbe30*/ UnityEngine.UIElements.Length get_left();
            /*0x1bfee04*/ UnityEngine.UIElements.Length get_letterSpacing();
            /*0x1bfc060*/ UnityEngine.UIElements.Length get_marginBottom();
            /*0x1bfbf70*/ UnityEngine.UIElements.Length get_marginLeft();
            /*0x1bfc010*/ UnityEngine.UIElements.Length get_marginRight();
            /*0x1bfbfc0*/ UnityEngine.UIElements.Length get_marginTop();
            /*0x1bfc510*/ UnityEngine.UIElements.Length get_maxHeight();
            /*0x1bfc4c0*/ UnityEngine.UIElements.Length get_maxWidth();
            /*0x1bfc5b0*/ UnityEngine.UIElements.Length get_minHeight();
            /*0x1bfc560*/ UnityEngine.UIElements.Length get_minWidth();
            /*0x1bfe750*/ float get_opacity();
            /*0x1bfc420*/ UnityEngine.UIElements.OverflowInternal get_overflow();
            /*0x1bfc1a0*/ UnityEngine.UIElements.Length get_paddingBottom();
            /*0x1bfc0b0*/ UnityEngine.UIElements.Length get_paddingLeft();
            /*0x1bfc150*/ UnityEngine.UIElements.Length get_paddingRight();
            /*0x1bfc100*/ UnityEngine.UIElements.Length get_paddingTop();
            /*0x1bfc3d0*/ UnityEngine.UIElements.Position get_position();
            /*0x1bfbed0*/ UnityEngine.UIElements.Length get_right();
            /*0x1bfe8c4*/ UnityEngine.UIElements.Rotate get_rotate();
            /*0x1bfe870*/ UnityEngine.UIElements.Scale get_scale();
            /*0x1bfee54*/ UnityEngine.UIElements.TextOverflow get_textOverflow();
            /*0x1bfeea4*/ UnityEngine.UIElements.TextShadow get_textShadow();
            /*0x1bfbe80*/ UnityEngine.UIElements.Length get_top();
            /*0x1bfe7a0*/ UnityEngine.UIElements.TransformOrigin get_transformOrigin();
            /*0x1bfef0c*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay();
            /*0x1bfef5c*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration();
            /*0x1bfefac*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty();
            /*0x1bfeffc*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction();
            /*0x1bfe808*/ UnityEngine.UIElements.Translate get_translate();
            /*0x1bff04c*/ UnityEngine.Color get_unityBackgroundImageTintColor();
            /*0x1bff0a0*/ UnityEngine.ScaleMode get_unityBackgroundScaleMode();
            /*0x1bff0f0*/ UnityEngine.Font get_unityFont();
            /*0x1bff140*/ UnityEngine.UIElements.FontDefinition get_unityFontDefinition();
            /*0x1bff194*/ UnityEngine.FontStyle get_unityFontStyleAndWeight();
            /*0x1bff1e4*/ UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox();
            /*0x1bff234*/ UnityEngine.UIElements.Length get_unityParagraphSpacing();
            /*0x1bff284*/ int get_unitySliceBottom();
            /*0x1bff2d4*/ int get_unitySliceLeft();
            /*0x1bff324*/ int get_unitySliceRight();
            /*0x1bff374*/ int get_unitySliceTop();
            /*0x1bff3c4*/ UnityEngine.TextAnchor get_unityTextAlign();
            /*0x1bff414*/ UnityEngine.Color get_unityTextOutlineColor();
            /*0x1bff468*/ float get_unityTextOutlineWidth();
            /*0x1bff4b8*/ UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition();
            /*0x1bff508*/ UnityEngine.UIElements.Visibility get_visibility();
            /*0x1bff558*/ UnityEngine.UIElements.WhiteSpace get_whiteSpace();
            /*0x1bfc330*/ UnityEngine.UIElements.Length get_width();
            /*0x1bff5a8*/ UnityEngine.UIElements.Length get_wordSpacing();
            /*0x1bff8a0*/ UnityEngine.UIElements.ComputedStyle Acquire();
            /*0x1bff9b8*/ void Release();
            /*0x1bfe1e0*/ void CopyFrom(ref UnityEngine.UIElements.ComputedStyle other);
            /*0x1bffab8*/ void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1c00c9c*/ void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1c01820*/ void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged sv, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1c01bc8*/ void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor);
            /*0x1c01c30*/ void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow st);
            /*0x1c01ca0*/ void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle other);
            /*0x1c02b60*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length newValue);
            /*0x1c03280*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, float newValue);
            /*0x1c03550*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, int newValue);
            /*0x1c03a64*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color newValue);
            /*0x1c03cf8*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background newValue);
            /*0x1c03e38*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font newValue);
            /*0x1c03f74*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition newValue);
            /*0x1c040bc*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow newValue);
            /*0x1c0420c*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate newValue);
            /*0x1c04354*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin newValue);
            /*0x1c0449c*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate newValue);
            /*0x1c045dc*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale newValue);
            /*0x1c0fccc*/ void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin st);
            /*0x1c0fd34*/ void ApplyStyleTranslate(UnityEngine.UIElements.Translate translateValue);
            /*0x1c0fd9c*/ void ApplyStyleRotate(UnityEngine.UIElements.Rotate rotateValue);
            /*0x1c0fe04*/ void ApplyStyleScale(UnityEngine.UIElements.Scale scaleValue);
            /*0x1bfc880*/ void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader);
            /*0x1bfc90c*/ void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x1bfc8bc*/ void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x1c0fe64*/ void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle parentStyle);
        }

        struct StyleFloat : UnityEngine.UIElements.IStyleValue<float>, System.IEquatable<UnityEngine.UIElements.StyleFloat>
        {
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c171d0*/ bool op_Equality(UnityEngine.UIElements.StyleFloat lhs, UnityEngine.UIElements.StyleFloat rhs);
            static /*0x1c171f8*/ UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c17200*/ UnityEngine.UIElements.StyleFloat op_Implicit(float v);
            /*0x1c171b0*/ StyleFloat(float v);
            /*0x1c171c8*/ StyleFloat(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c171bc*/ StyleFloat(float v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c17190*/ float get_value();
            /*0x1c171a8*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c17208*/ bool Equals(UnityEngine.UIElements.StyleFloat other);
            /*0x1c17230*/ bool Equals(object obj);
            /*0x1c172bc*/ int GetHashCode();
            /*0x1c172e4*/ string ToString();
        }

        struct StyleLength : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Length>, System.IEquatable<UnityEngine.UIElements.StyleLength>
        {
            /*0x10*/ UnityEngine.UIElements.Length m_Value;
            /*0x18*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c1741c*/ bool op_Equality(UnityEngine.UIElements.StyleLength lhs, UnityEngine.UIElements.StyleLength rhs);
            static /*0x1c1747c*/ UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c17488*/ UnityEngine.UIElements.StyleLength op_Implicit(float v);
            /*0x1c1737c*/ StyleLength(float v);
            /*0x1c173f0*/ StyleLength(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c173d0*/ StyleLength(UnityEngine.UIElements.Length v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1735c*/ UnityEngine.UIElements.Length get_value();
            /*0x1c17374*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c174b0*/ bool Equals(UnityEngine.UIElements.StyleLength other);
            /*0x1c174f0*/ bool Equals(object obj);
            /*0x1c17594*/ int GetHashCode();
            /*0x1c175ec*/ string ToString();
        }

        interface IStyleValue<T>
        {
            T get_value();
            UnityEngine.UIElements.StyleKeyword get_keyword();
        }

        enum StyleKeyword
        {
            Undefined = 0,
            Null = 1,
            Auto = 2,
            None = 3,
            Initial = 4,
        }

        class StyleValueExtensions
        {
            static string DebugString<T>(UnityEngine.UIElements.IStyleValue<T> styleValue);
            static /*0x1c17674*/ UnityEngine.Yoga.YogaValue ToYogaValue(UnityEngine.UIElements.Length length);
            static /*0x1c177c0*/ UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c178d8*/ UnityEngine.UIElements.Rotate ToRotate(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c17a54*/ UnityEngine.UIElements.Scale ToScale(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c17b70*/ UnityEngine.UIElements.Translate ToTranslate(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x1c17cdc*/ UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleLength styleLength);
            static void CopyFrom<T>(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other);
        }

        struct Translate : System.IEquatable<UnityEngine.UIElements.Translate>
        {
            /*0x10*/ UnityEngine.UIElements.Length m_X;
            /*0x18*/ UnityEngine.UIElements.Length m_Y;
            /*0x20*/ float m_Z;
            /*0x24*/ bool m_isNone;

            static /*0x1c17cc0*/ UnityEngine.UIElements.Translate None();
            static /*0x1c15c58*/ bool op_Equality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs);
            static /*0x1c17d24*/ bool op_Inequality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs);
            /*0x1c17cfc*/ Translate(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, float z);
            /*0x1c17d0c*/ UnityEngine.UIElements.Length get_x();
            /*0x1c17d14*/ UnityEngine.UIElements.Length get_y();
            /*0x1c17d1c*/ float get_z();
            /*0x1c17d9c*/ bool Equals(UnityEngine.UIElements.Translate other);
            /*0x1c17e18*/ bool Equals(object obj);
            /*0x1c15e04*/ int GetHashCode();
            /*0x1c17ea8*/ string ToString();
        }

        enum AngleUnit
        {
            Degree = 0,
            Gradian = 1,
            Radian = 2,
            Turn = 3,
        }

        struct Angle : System.IEquatable<UnityEngine.UIElements.Angle>
        {
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.Angle.Unit m_Unit;

            static /*0x1c18234*/ UnityEngine.UIElements.Angle None();
            static /*0x1c16b8c*/ UnityEngine.UIElements.Angle op_Implicit(float value);
            static /*0x1c16c98*/ bool op_Equality(UnityEngine.UIElements.Angle lhs, UnityEngine.UIElements.Angle rhs);
            /*0x1c18250*/ Angle(float value, UnityEngine.UIElements.AngleUnit unit);
            /*0x1c1823c*/ Angle(float value, UnityEngine.UIElements.Angle.Unit unit);
            /*0x1c18248*/ float get_value();
            /*0x1c1710c*/ float ToDegrees();
            /*0x1c1825c*/ bool Equals(UnityEngine.UIElements.Angle other);
            /*0x1c18284*/ bool Equals(object obj);
            /*0x1c16e84*/ int GetHashCode();
            /*0x1c16f14*/ string ToString();

            enum Unit
            {
                Degree = 0,
                Gradian = 1,
                Radian = 2,
                Turn = 3,
                None = 4,
            }
        }

        struct CustomStyleProperty<T> : System.IEquatable<UnityEngine.UIElements.CustomStyleProperty<T>>
        {
            /*0x0*/ string <name>k__BackingField;

            CustomStyleProperty(string propertyName);
            string get_name();
            void set_name(string value);
            bool Equals(object obj);
            bool Equals(UnityEngine.UIElements.CustomStyleProperty<T> other);
            int GetHashCode();
        }

        interface ICustomStyle
        {
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<float> property, ref float value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<int> property, ref int value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, ref UnityEngine.Color value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, ref UnityEngine.Texture2D value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, ref UnityEngine.Sprite value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, ref UnityEngine.UIElements.VectorImage value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<string> property, ref string value);
        }

        class StyleValueCollection
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values;

            /*0x1c1881c*/ StyleValueCollection();
            /*0x1c18310*/ UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x1c18544*/ UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x1c1859c*/ UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x1c18384*/ bool TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.StyleSheets.StyleValue value);
            /*0x1c18620*/ void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value);
        }

        class InlineStyleAccess : UnityEngine.UIElements.StyleValueCollection, UnityEngine.UIElements.IStyle
        {
            static /*0x0*/ UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged;
            /*0x20*/ UnityEngine.UIElements.VisualElement <ve>k__BackingField;
            /*0x28*/ bool m_HasInlineCursor;
            /*0x30*/ UnityEngine.UIElements.StyleCursor m_InlineCursor;
            /*0x50*/ bool m_HasInlineTextShadow;
            /*0x54*/ UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow;
            /*0x74*/ bool m_HasInlineTransformOrigin;
            /*0x78*/ UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin;
            /*0x90*/ bool m_HasInlineTranslate;
            /*0x94*/ UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation;
            /*0xb0*/ bool m_HasInlineRotate;
            /*0xb4*/ UnityEngine.UIElements.StyleRotate m_InlineRotateOperation;
            /*0xd0*/ bool m_HasInlineScale;
            /*0xd4*/ UnityEngine.UIElements.StyleScale m_InlineScale;
            /*0xe8*/ UnityEngine.UIElements.InlineStyleAccess.InlineRule m_InlineRule;

            static /*0x1c1bad0*/ InlineStyleAccess();
            /*0x1c188a8*/ InlineStyleAccess(UnityEngine.UIElements.VisualElement ve);
            /*0x1c18898*/ UnityEngine.UIElements.VisualElement get_ve();
            /*0x1c188a0*/ void set_ve(UnityEngine.UIElements.VisualElement value);
            /*0x1c188cc*/ void Finalize();
            /*0x1c18a14*/ void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule);
            /*0x1c194bc*/ bool IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x1c18ab4*/ void ApplyInlineStyles(ref UnityEngine.UIElements.ComputedStyle computedStyle);
            /*0x1c198a4*/ UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.get_cursor();
            /*0x1c19918*/ UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow();
            /*0x1c199ac*/ UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin();
            /*0x1c19a28*/ UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.get_translate();
            /*0x1c19aa8*/ void UnityEngine.UIElements.IStyle.set_translate(UnityEngine.UIElements.StyleTranslate value);
            /*0x1c19c38*/ UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.get_rotate();
            /*0x1c19cc8*/ UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.get_scale();
            /*0x1c19d24*/ bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleLength inlineValue);
            /*0x1c1a220*/ bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleFloat inlineValue);
            /*0x1c1a330*/ bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleColor inlineValue);
            bool SetStyleValue<T>(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue);
            /*0x1c19afc*/ bool SetInlineTranslate(UnityEngine.UIElements.StyleTranslate inlineValue);
            /*0x1c1a46c*/ void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate translate);
            /*0x1c19f40*/ void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value);
            /*0x1c19e50*/ bool RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x1c1a6a0*/ void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x1c198f8*/ bool TryGetInlineCursor(ref UnityEngine.UIElements.StyleCursor value);
            /*0x1c19970*/ bool TryGetInlineTextShadow(ref UnityEngine.UIElements.StyleTextShadow value);
            /*0x1c199f4*/ bool TryGetInlineTransformOrigin(ref UnityEngine.UIElements.StyleTransformOrigin value);
            /*0x1c19a78*/ bool TryGetInlineTranslate(ref UnityEngine.UIElements.StyleTranslate value);
            /*0x1c19c88*/ bool TryGetInlineRotate(ref UnityEngine.UIElements.StyleRotate value);
            /*0x1c19cfc*/ bool TryGetInlineScale(ref UnityEngine.UIElements.StyleScale value);
            /*0x1c1a8c0*/ void UnityEngine.UIElements.IStyle.set_backgroundColor(UnityEngine.UIElements.StyleColor value);
            /*0x1c1a918*/ void UnityEngine.UIElements.IStyle.set_borderBottomColor(UnityEngine.UIElements.StyleColor value);
            /*0x1c1a974*/ void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value);
            /*0x1c1a9bc*/ void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value);
            /*0x1c1aa04*/ void UnityEngine.UIElements.IStyle.set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1aa70*/ void UnityEngine.UIElements.IStyle.set_borderLeftColor(UnityEngine.UIElements.StyleColor value);
            /*0x1c1aacc*/ void UnityEngine.UIElements.IStyle.set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1ab38*/ void UnityEngine.UIElements.IStyle.set_borderRightColor(UnityEngine.UIElements.StyleColor value);
            /*0x1c1ab94*/ void UnityEngine.UIElements.IStyle.set_borderRightWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1ac00*/ void UnityEngine.UIElements.IStyle.set_borderTopColor(UnityEngine.UIElements.StyleColor value);
            /*0x1c1ac58*/ void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value);
            /*0x1c1aca0*/ void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value);
            /*0x1c1ace8*/ void UnityEngine.UIElements.IStyle.set_borderTopWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1ad54*/ void UnityEngine.UIElements.IStyle.set_bottom(UnityEngine.UIElements.StyleLength value);
            /*0x1c1add0*/ void UnityEngine.UIElements.IStyle.set_color(UnityEngine.UIElements.StyleColor value);
            /*0x1c1ae28*/ UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display();
            /*0x1c1aec0*/ void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value);
            /*0x1c1af7c*/ void UnityEngine.UIElements.IStyle.set_flexBasis(UnityEngine.UIElements.StyleLength value);
            /*0x1c1aff8*/ void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value);
            /*0x1c1b0b4*/ void UnityEngine.UIElements.IStyle.set_flexGrow(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1b120*/ void UnityEngine.UIElements.IStyle.set_flexShrink(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1b18c*/ void UnityEngine.UIElements.IStyle.set_fontSize(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b1d0*/ UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_height();
            /*0x1c1b1ec*/ void UnityEngine.UIElements.IStyle.set_height(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b268*/ void UnityEngine.UIElements.IStyle.set_left(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b2e4*/ void UnityEngine.UIElements.IStyle.set_marginBottom(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b360*/ void UnityEngine.UIElements.IStyle.set_marginLeft(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b3dc*/ void UnityEngine.UIElements.IStyle.set_marginRight(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b458*/ void UnityEngine.UIElements.IStyle.set_marginTop(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b4d4*/ void UnityEngine.UIElements.IStyle.set_minWidth(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b550*/ void UnityEngine.UIElements.IStyle.set_opacity(UnityEngine.UIElements.StyleFloat value);
            /*0x1c1b590*/ void UnityEngine.UIElements.IStyle.set_paddingBottom(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b60c*/ void UnityEngine.UIElements.IStyle.set_paddingLeft(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b688*/ void UnityEngine.UIElements.IStyle.set_paddingRight(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b704*/ UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_paddingTop();
            /*0x1c1b720*/ void UnityEngine.UIElements.IStyle.set_paddingTop(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b79c*/ void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value);
            /*0x1c1b858*/ void UnityEngine.UIElements.IStyle.set_right(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b8d4*/ void UnityEngine.UIElements.IStyle.set_top(UnityEngine.UIElements.StyleLength value);
            /*0x1c1b950*/ void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value);
            /*0x1c1b9ac*/ void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value);
            /*0x1c1ba38*/ UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_width();
            /*0x1c1ba54*/ void UnityEngine.UIElements.IStyle.set_width(UnityEngine.UIElements.StyleLength value);

            struct InlineRule
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ UnityEngine.UIElements.StyleProperty[] properties;
                /*0x20*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds;
            }
        }

        enum LengthUnit
        {
            Pixel = 0,
            Percent = 1,
        }

        struct Length : System.IEquatable<UnityEngine.UIElements.Length>
        {
            static float k_MaxValue = 8388608;
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.Length.Unit m_Unit;

            static /*0x1c1bb48*/ UnityEngine.UIElements.Length Percent(float value);
            static /*0x1c178c8*/ UnityEngine.UIElements.Length Auto();
            static /*0x1c178d0*/ UnityEngine.UIElements.Length None();
            static /*0x1c1bbfc*/ UnityEngine.UIElements.Length op_Implicit(float value);
            static /*0x1c17454*/ bool op_Equality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs);
            static /*0x1c1bc20*/ bool op_Inequality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs);
            /*0x1c1bbd4*/ Length(float value);
            /*0x1c173a8*/ Length(float value, UnityEngine.UIElements.LengthUnit unit);
            /*0x1c1bb70*/ Length(float value, UnityEngine.UIElements.Length.Unit unit);
            /*0x1c1bb98*/ float get_value();
            /*0x1c1bba0*/ void set_value(float value);
            /*0x1c1bbc4*/ UnityEngine.UIElements.LengthUnit get_unit();
            /*0x1c1bbcc*/ void set_unit(UnityEngine.UIElements.LengthUnit value);
            /*0x1c173fc*/ bool IsAuto();
            /*0x1c1740c*/ bool IsNone();
            /*0x1c1bc48*/ bool Equals(UnityEngine.UIElements.Length other);
            /*0x1c1bc70*/ bool Equals(object obj);
            /*0x1c175c4*/ int GetHashCode();
            /*0x1c18074*/ string ToString();

            enum Unit
            {
                Pixel = 0,
                Percent = 1,
                Auto = 2,
                None = 3,
            }
        }

        struct StyleDataRef<T> : System.IEquatable<UnityEngine.UIElements.StyleDataRef<T>>
        {
            /*0x0*/ UnityEngine.UIElements.StyleDataRef.RefCounted<T> m_Ref;

            static UnityEngine.UIElements.StyleDataRef<T> Create();
            static bool op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs);
            UnityEngine.UIElements.StyleDataRef<T> Acquire();
            void Release();
            void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other);
            ref T Read();
            ref T Write();
            int GetHashCode();
            bool Equals(UnityEngine.UIElements.StyleDataRef<T> other);
            bool Equals(object obj);

            class RefCounted<T>
            {
                static /*0x0*/ uint m_NextId;
                /*0x0*/ int m_RefCount;
                /*0x0*/ uint m_Id;
                /*0x0*/ T value;

                static RefCounted();
                RefCounted();
                int get_refCount();
                void Acquire();
                void Release();
                UnityEngine.UIElements.StyleDataRef.RefCounted<T> Copy();
            }
        }

        struct StyleTransformOrigin : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.TransformOrigin>, System.IEquatable<UnityEngine.UIElements.StyleTransformOrigin>
        {
            /*0x10*/ UnityEngine.UIElements.TransformOrigin m_Value;
            /*0x24*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c1bd28*/ bool op_Equality(UnityEngine.UIElements.StyleTransformOrigin lhs, UnityEngine.UIElements.StyleTransformOrigin rhs);
            static /*0x1c19a1c*/ UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1bd04*/ StyleTransformOrigin(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1bd10*/ StyleTransformOrigin(UnityEngine.UIElements.TransformOrigin v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c19820*/ UnityEngine.UIElements.TransformOrigin get_value();
            /*0x1c1bcfc*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c1be04*/ bool Equals(UnityEngine.UIElements.StyleTransformOrigin other);
            /*0x1c1be90*/ bool Equals(object obj);
            /*0x1c1bf20*/ int GetHashCode();
            /*0x1c1bfb8*/ string ToString();
        }

        struct TransformOrigin : System.IEquatable<UnityEngine.UIElements.TransformOrigin>
        {
            /*0x10*/ UnityEngine.UIElements.Length m_X;
            /*0x18*/ UnityEngine.UIElements.Length m_Y;
            /*0x20*/ float m_Z;

            static /*0x1c1c04c*/ UnityEngine.UIElements.TransformOrigin Initial();
            static /*0x1c1bda4*/ bool op_Equality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs);
            static /*0x1c1c07c*/ bool op_Inequality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs);
            /*0x1c1c040*/ TransformOrigin(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, float z);
            /*0x1c1c064*/ UnityEngine.UIElements.Length get_x();
            /*0x1c1c06c*/ UnityEngine.UIElements.Length get_y();
            /*0x1c1c074*/ float get_z();
            /*0x1c1c0e8*/ bool Equals(UnityEngine.UIElements.TransformOrigin other);
            /*0x1c1c154*/ bool Equals(object obj);
            /*0x1c1bf44*/ int GetHashCode();
            /*0x1c1c224*/ string ToString();
        }

        struct Scale : System.IEquatable<UnityEngine.UIElements.Scale>
        {
            /*0x10*/ UnityEngine.Vector3 m_Scale;
            /*0x1c*/ bool m_IsNone;

            static /*0x1c1c400*/ UnityEngine.UIElements.Scale Initial();
            static /*0x1c17b58*/ UnityEngine.UIElements.Scale None();
            static /*0x1c13318*/ bool op_Equality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs);
            static /*0x1c1c450*/ bool op_Inequality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs);
            /*0x1c1c3f0*/ Scale(UnityEngine.Vector3 scale);
            /*0x1c1c444*/ UnityEngine.Vector3 get_value();
            /*0x1c1c4a4*/ bool Equals(UnityEngine.UIElements.Scale other);
            /*0x1c1c4f0*/ bool Equals(object obj);
            /*0x1c134e0*/ int GetHashCode();
            /*0x1c1c5ac*/ string ToString();
        }

        struct StyleTextShadow : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.TextShadow>, System.IEquatable<UnityEngine.UIElements.StyleTextShadow>
        {
            /*0x10*/ UnityEngine.UIElements.StyleKeyword m_Keyword;
            /*0x14*/ UnityEngine.UIElements.TextShadow m_Value;

            static /*0x1c1c5ec*/ bool op_Equality(UnityEngine.UIElements.StyleTextShadow lhs, UnityEngine.UIElements.StyleTextShadow rhs);
            static /*0x1c19994*/ UnityEngine.UIElements.StyleTextShadow op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1c5b4*/ StyleTextShadow(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1c5cc*/ StyleTextShadow(UnityEngine.UIElements.TextShadow v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c197d4*/ UnityEngine.UIElements.TextShadow get_value();
            /*0x1c197cc*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c1c654*/ bool Equals(UnityEngine.UIElements.StyleTextShadow other);
            /*0x1c1c688*/ bool Equals(object obj);
            /*0x1c1c718*/ int GetHashCode();
            /*0x1c1c760*/ string ToString();
        }

        struct StyleRotate : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Rotate>, System.IEquatable<UnityEngine.UIElements.StyleRotate>
        {
            /*0x10*/ UnityEngine.UIElements.Rotate m_Value;
            /*0x28*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c1c810*/ bool op_Equality(UnityEngine.UIElements.StyleRotate lhs, UnityEngine.UIElements.StyleRotate rhs);
            static /*0x1c19cb8*/ UnityEngine.UIElements.StyleRotate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1c7e8*/ StyleRotate(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1c7f8*/ StyleRotate(UnityEngine.UIElements.Rotate v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c19860*/ UnityEngine.UIElements.Rotate get_value();
            /*0x1c1c7e0*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c1c86c*/ bool Equals(UnityEngine.UIElements.StyleRotate other);
            /*0x1c1c8e8*/ bool Equals(object obj);
            /*0x1c1c978*/ int GetHashCode();
            /*0x1c1c99c*/ string ToString();
        }

        enum TimeUnit
        {
            Second = 0,
            Millisecond = 1,
        }

        struct TimeValue : System.IEquatable<UnityEngine.UIElements.TimeValue>
        {
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.TimeUnit m_Unit;

            static /*0x1c1ca40*/ UnityEngine.UIElements.TimeValue op_Implicit(float value);
            static /*0x1c1ca48*/ bool op_Equality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs);
            static /*0x1c149a8*/ bool op_Inequality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs);
            /*0x1c149d0*/ TimeValue(float value);
            /*0x1c1ca34*/ TimeValue(float value, UnityEngine.UIElements.TimeUnit unit);
            /*0x1c1ca24*/ float get_value();
            /*0x1c1ca2c*/ UnityEngine.UIElements.TimeUnit get_unit();
            /*0x1c1ca70*/ bool Equals(UnityEngine.UIElements.TimeValue other);
            /*0x1c1ca98*/ bool Equals(object obj);
            /*0x1c14660*/ int GetHashCode();
            /*0x1c1cb24*/ string ToString();
        }

        struct StyleInt : UnityEngine.UIElements.IStyleValue<int>, System.IEquatable<UnityEngine.UIElements.StyleInt>
        {
            /*0x10*/ int m_Value;
            /*0x14*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x1c1cc24*/ bool op_Equality(UnityEngine.UIElements.StyleInt lhs, UnityEngine.UIElements.StyleInt rhs);
            static /*0x1c18618*/ UnityEngine.UIElements.StyleInt op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1cc1c*/ StyleInt(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c18610*/ StyleInt(int v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x1c1aea0*/ int get_value();
            /*0x1c1aeb8*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x1c1cc44*/ bool Equals(UnityEngine.UIElements.StyleInt other);
            /*0x1c1cc64*/ bool Equals(object obj);
            /*0x1c1cce8*/ int GetHashCode();
            /*0x1c1ccfc*/ string ToString();
        }

        class UIRAtlasAllocator : System.IDisposable
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerTryAllocate;
            /*0x10*/ int <maxAtlasSize>k__BackingField;
            /*0x14*/ int <maxImageWidth>k__BackingField;
            /*0x18*/ int <maxImageHeight>k__BackingField;
            /*0x1c*/ int <virtualWidth>k__BackingField;
            /*0x20*/ int <virtualHeight>k__BackingField;
            /*0x24*/ int <physicalWidth>k__BackingField;
            /*0x28*/ int <physicalHeight>k__BackingField;
            /*0x30*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode m_FirstUnpartitionedArea;
            /*0x38*/ UnityEngine.UIElements.UIRAtlasAllocator.Row[] m_OpenRows;
            /*0x40*/ int m_1SidePadding;
            /*0x44*/ int m_2SidePadding;
            /*0x48*/ bool <disposed>k__BackingField;

            static /*0x1c1db40*/ UIRAtlasAllocator();
            static /*0x1c1cfec*/ int GetLog2OfNextPower(int n);
            /*0x1c1d11c*/ UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding);
            /*0x1c1cd74*/ int get_maxAtlasSize();
            /*0x1c1cd7c*/ int get_maxImageWidth();
            /*0x1c1cd84*/ int get_maxImageHeight();
            /*0x1c1cd8c*/ int get_virtualWidth();
            /*0x1c1cd94*/ void set_virtualWidth(int value);
            /*0x1c1cd9c*/ int get_virtualHeight();
            /*0x1c1cda4*/ void set_virtualHeight(int value);
            /*0x1c1cdac*/ int get_physicalWidth();
            /*0x1c1cdb4*/ void set_physicalWidth(int value);
            /*0x1c1cdbc*/ int get_physicalHeight();
            /*0x1c1cdc4*/ void set_physicalHeight(int value);
            /*0x1c1cdcc*/ bool get_disposed();
            /*0x1c1cdd4*/ void set_disposed(bool value);
            /*0x1c1cde0*/ void Dispose();
            /*0x1c1ce4c*/ void Dispose(bool disposing);
            /*0x1c1d48c*/ bool TryAllocate(int width, int height, ref UnityEngine.RectInt location);
            /*0x1c1d7a8*/ bool TryPartitionArea(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth);
            /*0x1c1d380*/ void BuildAreas();

            class Row
            {
                static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.Row> s_Pool;
                /*0x10*/ int <offsetX>k__BackingField;
                /*0x14*/ int <offsetY>k__BackingField;
                /*0x18*/ int <width>k__BackingField;
                /*0x1c*/ int <height>k__BackingField;
                /*0x20*/ int Cursor;

                static /*0x1c1dbf4*/ Row();
                static /*0x1c1d9c0*/ UnityEngine.UIElements.UIRAtlasAllocator.Row Acquire(int offsetX, int offsetY, int width, int height);
                /*0x1c1dbec*/ Row();
                /*0x1c1dbb4*/ int get_offsetX();
                /*0x1c1dbbc*/ void set_offsetX(int value);
                /*0x1c1dbc4*/ int get_offsetY();
                /*0x1c1dbcc*/ void set_offsetY(int value);
                /*0x1c1dbd4*/ int get_width();
                /*0x1c1dbdc*/ void set_width(int value);
                /*0x1c1dbe4*/ void set_height(int value);
                /*0x1c1cedc*/ void Release();
            }

            class AreaNode
            {
                static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.AreaNode> s_Pool;
                /*0x10*/ UnityEngine.RectInt rect;
                /*0x20*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous;
                /*0x28*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode next;

                static /*0x1c1dc8c*/ AreaNode();
                static /*0x1c1d2e8*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode Acquire(UnityEngine.RectInt rect);
                /*0x1c1dc84*/ AreaNode();
                /*0x1c1cf6c*/ void Release();
                /*0x1c1da6c*/ void RemoveFromChain();
                /*0x1c1da94*/ void AddAfter(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous);
            }
        }

        class UIRRepaintUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ UnityEngine.UIElements.BaseVisualElementPanel attachedPanel;
            /*0x28*/ UnityEngine.UIElements.UIR.RenderChain renderChain;
            /*0x30*/ bool <drawStats>k__BackingField;
            /*0x31*/ bool <breakBatches>k__BackingField;
            /*0x32*/ bool <disposed>k__BackingField;

            static /*0x1c1e0fc*/ UIRRepaintUpdater();
            static /*0x1c1e208*/ void OnGraphicsResourcesRecreate(bool recreate);
            /*0x1c1dd1c*/ UIRRepaintUpdater();
            /*0x1c1ddac*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x1c1de04*/ bool get_drawStats();
            /*0x1c1de0c*/ bool get_breakBatches();
            /*0x1c1de14*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x1c1df0c*/ void Update();
            /*0x1c1e084*/ UnityEngine.UIElements.UIR.RenderChain CreateRenderChain();
            /*0x1c1e428*/ void OnPanelChanged(UnityEngine.UIElements.BaseVisualElementPanel obj);
            /*0x1c1e5e4*/ void AttachToPanel();
            /*0x1c1e440*/ void DetachFromPanel();
            /*0x1c1dfc8*/ void InitRenderChain();
            /*0x1c1e3d8*/ void DestroyRenderChain();
            /*0x1c1ebb0*/ void OnPanelAtlasChanged();
            /*0x1c1ebb4*/ void OnPanelHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType);
            /*0x1c1e7d8*/ void OnPanelStandardShaderChanged();
            /*0x1c1e97c*/ void OnPanelStandardWorldSpaceShaderChanged();
            /*0x1c1eb20*/ void ResetAllElementsDataRecursive(UnityEngine.UIElements.VisualElement ve);
            /*0x1c1ebec*/ bool get_disposed();
            /*0x1c1ebf4*/ void set_disposed(bool value);
            /*0x1c1ec00*/ void Dispose(bool disposing);
        }

        class UIRUtility
        {
            static /*0x0*/ string k_DefaultShaderName;
            static /*0x8*/ string k_DefaultWorldSpaceShaderName;

            static /*0x1c1f134*/ UIRUtility();
            static /*0x1c1ec2c*/ bool ShapeWindingIsClockwise(int maskDepth, int stencilRef);
            static /*0x1c1ecb8*/ bool IsRoundRect(UnityEngine.UIElements.VisualElement ve);
            static /*0x1c1eebc*/ bool IsVectorImageBackground(UnityEngine.UIElements.VisualElement ve);
            static /*0x1c1ef4c*/ bool IsElementSelfHidden(UnityEngine.UIElements.VisualElement ve);
            static /*0x1c1f00c*/ void Destroy(UnityEngine.Object obj);
            static /*0x1c1f0b4*/ int GetPrevPow2(int n);
            static /*0x1c1f0e8*/ int GetNextPow2(int n);
            static /*0x1c1f104*/ int GetNextPow2Exp(int n);
        }

        class UIRLayoutUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;

            static /*0x1c1fb18*/ UIRLayoutUpdater();
            /*0x1c1fb10*/ UIRLayoutUpdater();
            /*0x1c1f1c4*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x1c1f21c*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x1c1f264*/ void Update();
            /*0x1c1f550*/ void UpdateSubTree(UnityEngine.UIElements.VisualElement ve, int currentLayoutPass, bool isDisplayed);
        }

        struct Vertex
        {
            static /*0x0*/ float nearZ;
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Color32 tint;
            /*0x20*/ UnityEngine.Vector2 uv;
            /*0x28*/ UnityEngine.Color32 xformClipPages;
            /*0x2c*/ UnityEngine.Color32 ids;
            /*0x30*/ UnityEngine.Color32 flags;
            /*0x34*/ UnityEngine.Color32 opacityColorPages;
            /*0x38*/ UnityEngine.Vector4 circle;
            /*0x48*/ float textureId;
        }

        class MeshWriteData
        {
            /*0x10*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices;
            /*0x20*/ Unity.Collections.NativeSlice<ushort> m_Indices;
            /*0x30*/ UnityEngine.Rect m_UVRegion;
            /*0x40*/ int currentIndex;
            /*0x44*/ int currentVertex;

            /*0x1c1fba4*/ MeshWriteData();
            /*0x1c1fbac*/ int get_vertexCount();
            /*0x1c1fbf4*/ int get_indexCount();
            /*0x1c1fc3c*/ UnityEngine.Rect get_uvRegion();
            /*0x1c1fc48*/ void SetNextVertex(UnityEngine.UIElements.Vertex vertex);
            /*0x1c1fce4*/ void SetNextIndex(ushort index);
            /*0x1c1fd48*/ void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices);
            /*0x1c1fe20*/ void SetAllIndices(ushort[] indices);
            /*0x1c1fef8*/ void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<ushort> indices);
            /*0x1c1ff44*/ void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<ushort> indices, UnityEngine.Rect uvRegion);
        }

        struct ColorPage
        {
            /*0x10*/ bool isValid;
            /*0x14*/ UnityEngine.Color32 pageAndID;

            static /*0x1c1ff5c*/ UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.BMPAlloc alloc);
        }

        class MeshGenerationContextUtils
        {
            static /*0x1c1ffbc*/ void Rectangle(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
            static /*0x1c200bc*/ void Text(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
            static /*0x1c201f0*/ UnityEngine.Vector2 ConvertBorderRadiusPercentToPoints(UnityEngine.Vector2 borderRectSize, UnityEngine.UIElements.Length length);
            static /*0x1c2022c*/ void GetVisualElementRadii(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.Vector2 topLeft, ref UnityEngine.Vector2 bottomLeft, ref UnityEngine.Vector2 topRight, ref UnityEngine.Vector2 bottomRight);
            static /*0x1c204c8*/ void AdjustBackgroundSizeForBorders(UnityEngine.UIElements.VisualElement visualElement, ref UnityEngine.Rect rect);

            struct BorderParams
            {
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ UnityEngine.Color playmodeTintColor;
                /*0x30*/ UnityEngine.Color leftColor;
                /*0x40*/ UnityEngine.Color topColor;
                /*0x50*/ UnityEngine.Color rightColor;
                /*0x60*/ UnityEngine.Color bottomColor;
                /*0x70*/ float leftWidth;
                /*0x74*/ float topWidth;
                /*0x78*/ float rightWidth;
                /*0x7c*/ float bottomWidth;
                /*0x80*/ UnityEngine.Vector2 topLeftRadius;
                /*0x88*/ UnityEngine.Vector2 topRightRadius;
                /*0x90*/ UnityEngine.Vector2 bottomRightRadius;
                /*0x98*/ UnityEngine.Vector2 bottomLeftRadius;
                /*0xa0*/ UnityEngine.Material material;
                /*0xa8*/ UnityEngine.UIElements.ColorPage leftColorPage;
                /*0xb0*/ UnityEngine.UIElements.ColorPage topColorPage;
                /*0xb8*/ UnityEngine.UIElements.ColorPage rightColorPage;
                /*0xc0*/ UnityEngine.UIElements.ColorPage bottomColorPage;
            }

            struct RectangleParams
            {
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ UnityEngine.Rect uv;
                /*0x30*/ UnityEngine.Color color;
                /*0x40*/ UnityEngine.Texture texture;
                /*0x48*/ UnityEngine.Sprite sprite;
                /*0x50*/ UnityEngine.UIElements.VectorImage vectorImage;
                /*0x58*/ UnityEngine.Material material;
                /*0x60*/ UnityEngine.ScaleMode scaleMode;
                /*0x64*/ UnityEngine.Color playmodeTintColor;
                /*0x74*/ UnityEngine.Vector2 topLeftRadius;
                /*0x7c*/ UnityEngine.Vector2 topRightRadius;
                /*0x84*/ UnityEngine.Vector2 bottomRightRadius;
                /*0x8c*/ UnityEngine.Vector2 bottomLeftRadius;
                /*0x94*/ int leftSlice;
                /*0x98*/ int topSlice;
                /*0x9c*/ int rightSlice;
                /*0xa0*/ int bottomSlice;
                /*0xa4*/ float sliceScale;
                /*0xa8*/ UnityEngine.Rect spriteGeomRect;
                /*0xb8*/ UnityEngine.UIElements.ColorPage colorPage;
                /*0xc0*/ UnityEngine.UIElements.MeshGenerationContext.MeshFlags meshFlags;

                static /*0x1c2091c*/ void AdjustUVsForScaleMode(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, ref UnityEngine.Rect rectOut, ref UnityEngine.Rect uvOut);
                static /*0x1c20c3c*/ void AdjustSpriteUVsForScaleMode(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Rect geomRect, UnityEngine.Texture texture, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, ref UnityEngine.Rect rectOut, ref UnityEngine.Rect uvOut);
                static /*0x1c2139c*/ UnityEngine.Rect RectIntersection(UnityEngine.Rect a, UnityEngine.Rect b);
                static /*0x1c214bc*/ UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite sprite);
                static /*0x1c21594*/ UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite sprite);
                static /*0x1c2166c*/ UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect uv, UnityEngine.SpritePackingRotation rotation);
                static /*0x1c21798*/ UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext);
                static /*0x1c21904*/ UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeSprite(UnityEngine.Rect rect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext, bool hasRadius, ref UnityEngine.Vector4 slices);
                static /*0x1c21fc8*/ UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeVectorTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.UIElements.VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext);
                /*0x1c220e4*/ bool HasRadius(float epsilon);
            }

            struct TextParams
            {
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ string text;
                /*0x28*/ UnityEngine.Font font;
                /*0x30*/ UnityEngine.UIElements.FontDefinition fontDefinition;
                /*0x40*/ int fontSize;
                /*0x44*/ UnityEngine.UIElements.Length letterSpacing;
                /*0x4c*/ UnityEngine.UIElements.Length wordSpacing;
                /*0x54*/ UnityEngine.UIElements.Length paragraphSpacing;
                /*0x5c*/ UnityEngine.FontStyle fontStyle;
                /*0x60*/ UnityEngine.Color fontColor;
                /*0x70*/ UnityEngine.TextAnchor anchor;
                /*0x74*/ bool wordWrap;
                /*0x78*/ float wordWrapWidth;
                /*0x7c*/ bool richText;
                /*0x80*/ UnityEngine.Color playmodeTintColor;
                /*0x90*/ UnityEngine.UIElements.TextOverflow textOverflow;
                /*0x94*/ UnityEngine.UIElements.TextOverflowPosition textOverflowPosition;
                /*0x98*/ UnityEngine.UIElements.OverflowInternal overflow;
                /*0xa0*/ UnityEngine.UIElements.IPanel panel;

                static /*0xb8af68*/ UnityEngine.UIElements.MeshGenerationContextUtils.TextParams MakeStyleBased(UnityEngine.UIElements.VisualElement ve, string text);
                static /*0xb8b310*/ UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float scaling);
                /*0xb8acc8*/ int GetHashCode();
            }
        }

        class MeshGenerationContext
        {
            /*0x10*/ UnityEngine.UIElements.IStylePainter painter;

            /*0xb8b3e4*/ MeshGenerationContext(UnityEngine.UIElements.IStylePainter painter);

            enum MeshFlags
            {
                None = 0,
                UVisDisplacement = 1,
                SkipDynamicAtlas = 2,
            }
        }

        struct TextureId
        {
            static /*0x0*/ UnityEngine.UIElements.TextureId invalid;
            /*0x10*/ int m_Index;

            static /*0xb8b56c*/ TextureId();
            static /*0xb8b4fc*/ bool op_Equality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right);
            static /*0xb8b508*/ bool op_Inequality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right);
            /*0xb8b40c*/ TextureId(int index);
            /*0xb8b418*/ int get_index();
            /*0xb8b424*/ float ConvertToGpu();
            /*0xb8b434*/ bool Equals(object obj);
            /*0xb8b4dc*/ int GetHashCode();
        }

        class TextureRegistry
        {
            static int maxTextures = 2048;
            static /*0x0*/ UnityEngine.UIElements.TextureRegistry <instance>k__BackingField;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.TextureRegistry.TextureInfo> m_Textures;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.UIElements.TextureId> m_TextureToId;
            /*0x20*/ System.Collections.Generic.Stack<UnityEngine.UIElements.TextureId> m_FreeIds;

            static /*0xb8bfac*/ TextureRegistry();
            static /*0xb8b5b4*/ UnityEngine.UIElements.TextureRegistry get_instance();
            /*0xb8bea0*/ TextureRegistry();
            /*0xb8b60c*/ UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId id);
            /*0xb8b748*/ UnityEngine.UIElements.TextureId AllocAndAcquireDynamic();
            /*0xb8b9c4*/ void UpdateDynamic(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture);
            /*0xb8b764*/ UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture texture, bool dynamic);
            /*0xb8bb70*/ UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture tex);
            /*0xb8bcb0*/ void Release(UnityEngine.UIElements.TextureId id);

            struct TextureInfo
            {
                /*0x10*/ UnityEngine.Texture texture;
                /*0x18*/ bool dynamic;
                /*0x1c*/ int refCount;
            }
        }

        class DynamicAtlasPage : System.IDisposable
        {
            static /*0x0*/ int s_TextureCounter;
            /*0x10*/ UnityEngine.UIElements.TextureId <textureId>k__BackingField;
            /*0x18*/ UnityEngine.RenderTexture <atlas>k__BackingField;
            /*0x20*/ UnityEngine.RenderTextureFormat <format>k__BackingField;
            /*0x24*/ UnityEngine.FilterMode <filterMode>k__BackingField;
            /*0x28*/ UnityEngine.Vector2Int <minSize>k__BackingField;
            /*0x30*/ UnityEngine.Vector2Int <maxSize>k__BackingField;
            /*0x38*/ int m_1Padding;
            /*0x3c*/ int m_2Padding;
            /*0x40*/ UnityEngine.UIElements.UIR.Allocator2D m_Allocator;
            /*0x48*/ UnityEngine.UIElements.UIR.TextureBlitter m_Blitter;
            /*0x50*/ UnityEngine.Vector2Int m_CurrentSize;
            /*0x58*/ bool <disposed>k__BackingField;

            /*0xb8c03c*/ DynamicAtlasPage(UnityEngine.RenderTextureFormat format, UnityEngine.FilterMode filterMode, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize);
            /*0xb8c00c*/ UnityEngine.UIElements.TextureId get_textureId();
            /*0xb8c014*/ void set_textureId(UnityEngine.UIElements.TextureId value);
            /*0xb8c01c*/ UnityEngine.RenderTexture get_atlas();
            /*0xb8c024*/ void set_atlas(UnityEngine.RenderTexture value);
            /*0xb8c02c*/ UnityEngine.RenderTextureFormat get_format();
            /*0xb8c034*/ UnityEngine.FilterMode get_filterMode();
            /*0xb8c244*/ bool get_disposed();
            /*0xb8c24c*/ void set_disposed(bool value);
            /*0xb8c258*/ void Dispose();
            /*0xb8c2c4*/ void Dispose(bool disposing);
            /*0xb8c504*/ bool TryAdd(UnityEngine.Texture2D image, ref UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc, ref UnityEngine.RectInt rect);
            /*0xb8c6e8*/ void Update(UnityEngine.Texture2D image, UnityEngine.RectInt rect);
            /*0xb8ca28*/ void Remove(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc);
            /*0xb8cb24*/ void Commit();
            /*0xb8cb64*/ void UpdateAtlasTexture();
            /*0xb8cfd0*/ UnityEngine.RenderTexture CreateAtlasTexture();
        }

        interface IBindingRequest
        {
            void Bind(UnityEngine.UIElements.VisualElement element);
        }

        class VisualTreeBindingsUpdater : UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater
        {
            static /*0x0*/ UnityEngine.PropertyName s_BindingRequestObjectVEPropertyName;
            static /*0x4*/ UnityEngine.PropertyName s_AdditionalBindingObjectVEPropertyName;
            static /*0x8*/ string s_Description;
            static /*0x10*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            static /*0x18*/ Unity.Profiling.ProfilerMarker s_ProfilerBindingRequestsMarker;
            static /*0x20*/ Unity.Profiling.ProfilerMarker s_MarkerUpdate;
            static /*0x28*/ Unity.Profiling.ProfilerMarker s_MarkerPoll;
            static /*0x30*/ bool <disableBindingsThrottling>k__BackingField;
            /*0x38*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsWithBindings;
            /*0x40*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToAdd;
            /*0x48*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToRemove;
            /*0x50*/ long m_LastUpdateTime;
            /*0x58*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToBind;
            /*0x60*/ System.Collections.Generic.Dictionary<object, object> <temporaryObjectCache>k__BackingField;
            /*0x68*/ System.Collections.Generic.List<UnityEngine.UIElements.IBinding> updatedBindings;

            static /*0xb8e6cc*/ VisualTreeBindingsUpdater();
            static /*0xb8d37c*/ UnityEngine.UIElements.IBinding GetAdditionalBinding(UnityEngine.UIElements.VisualElement ve);
            static /*0xb8d840*/ long CurrentTime();
            /*0xb8e56c*/ VisualTreeBindingsUpdater();
            /*0xb8d1ec*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0xb8d244*/ UnityEngine.UIElements.IBinding GetBindingObjectFromElement(UnityEngine.UIElements.VisualElement ve);
            /*0xb8d404*/ void StartTracking(UnityEngine.UIElements.VisualElement ve);
            /*0xb8d484*/ void StopTracking(UnityEngine.UIElements.VisualElement ve);
            /*0xb8d504*/ System.Collections.Generic.Dictionary<object, object> get_temporaryObjectCache();
            /*0xb8d50c*/ void StartTrackingRecursive(UnityEngine.UIElements.VisualElement ve);
            /*0xb8d624*/ void StopTrackingRecursive(UnityEngine.UIElements.VisualElement ve);
            /*0xb8d730*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0xb8d828*/ void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type);
            /*0xb8d890*/ void PerformTrackingOperations();
            /*0xb8db14*/ void Update();
            /*0xb8e038*/ void UpdateBindings();
        }

        interface ITreeViewItem
        {
            int get_id();
            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> get_children();
            bool get_hasChildren();
        }

        class InternalTreeView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string s_ListViewName;
            static /*0x8*/ string s_ItemName;
            static /*0x10*/ string s_ItemToggleName;
            static /*0x18*/ string s_ItemIndentsContainerName;
            static /*0x20*/ string s_ItemIndentName;
            static /*0x28*/ string s_ItemContentContainerName;
            /*0x3b0*/ System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;
            /*0x3b8*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onItemsChosen;
            /*0x3c0*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onSelectionChange;
            /*0x3c8*/ System.Collections.Generic.List<UnityEngine.UIElements.ITreeViewItem> m_SelectedItems;
            /*0x3d0*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> m_BindItem;
            /*0x3d8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> <unbindItem>k__BackingField;
            /*0x3e0*/ System.Collections.Generic.IList<UnityEngine.UIElements.ITreeViewItem> m_RootItems;
            /*0x3e8*/ System.Collections.Generic.List<int> m_ExpandedItemIds;
            /*0x3f0*/ System.Collections.Generic.List<UnityEngine.UIElements.InternalTreeView.TreeViewItemWrapper> m_ItemWrappers;
            /*0x3f8*/ UnityEngine.UIElements.ListView m_ListView;
            /*0x400*/ UnityEngine.UIElements.ScrollView m_ScrollView;

            static /*0xb919c0*/ InternalTreeView();
            static /*0xb8ef64*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> GetAllItems(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems);
            /*0xb8e8e8*/ InternalTreeView();
            /*0xb8e868*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> get_unbindItem();
            /*0xb8e870*/ void set_itemHeight(int value);
            /*0xb8e890*/ void set_showBorder(bool value);
            /*0xb8e8b0*/ void set_selectionType(UnityEngine.UIElements.SelectionType value);
            /*0xb8e8cc*/ void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value);
            /*0xb8ee3c*/ void RefreshItems();
            /*0xb8ef04*/ void Rebuild();
            /*0xb8ef28*/ void OnViewDataReady();
            /*0xb8f00c*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0xb8eee8*/ void ListViewRefresh();
            /*0xb8f6b8*/ void OnItemsChosen(System.Collections.Generic.IEnumerable<object> chosenItems);
            /*0xb8fad8*/ void OnSelectionChange(System.Collections.Generic.IEnumerable<object> selectedListItems);
            /*0xb8ff2c*/ void OnTreeViewMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0xb8ff64*/ void OnItemMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0xb90760*/ UnityEngine.UIElements.VisualElement MakeTreeItem();
            /*0xb90c40*/ void UnbindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0xb90d5c*/ void BindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0xb910b8*/ int GetItemId(int index);
            /*0xb8f0c8*/ bool IsExpandedByIndex(int index);
            /*0xb8f46c*/ void CollapseItemByIndex(int index);
            /*0xb8f164*/ void ExpandItemByIndex(int index);
            /*0xb916ec*/ void ToggleExpandedState(UnityEngine.UIElements.ChangeEvent<bool> evt);
            /*0xb911cc*/ void CreateWrappers(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> treeViewItems, int depth, ref System.Collections.Generic.List<UnityEngine.UIElements.InternalTreeView.TreeViewItemWrapper> wrappers);
            /*0xb8ee60*/ void RegenerateWrappers();
            /*0xb91870*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.InternalTreeView, UnityEngine.UIElements.InternalTreeView.UxmlTraits>
            {
                /*0xb91acc*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_ItemHeight;
                /*0x78*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;
                /*0x88*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

                /*0xb91d74*/ UxmlTraits();
                /*0xb91b14*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            struct TreeViewItemWrapper
            {
                /*0x10*/ int depth;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem item;

                /*0xb9112c*/ int get_id();
            }

            class <GetAllItems>d__64 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems;
                /*0x30*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> <>3__rootItems;
                /*0x38*/ System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>> <iteratorStack>5__1;
                /*0x40*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> <currentIterator>5__2;
                /*0x48*/ bool <hasNext>5__3;
                /*0x50*/ UnityEngine.UIElements.ITreeViewItem <currentItem>5__4;

                /*0xb8efc8*/ <GetAllItems>d__64(int <>1__state);
                /*0xb91f80*/ void System.IDisposable.Dispose();
                /*0xb91f84*/ bool MoveNext();
                /*0xb9237c*/ UnityEngine.UIElements.ITreeViewItem System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>.get_Current();
                /*0xb92384*/ void System.Collections.IEnumerator.Reset();
                /*0xb923c4*/ object System.Collections.IEnumerator.get_Current();
                /*0xb923cc*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>.GetEnumerator();
                /*0xb9246c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        struct EventDebuggerLogCall : System.IDisposable
        {
            /*0xb92470*/ EventDebuggerLogCall(System.Delegate callback, UnityEngine.UIElements.EventBase evt);
            /*0xb92474*/ void Dispose();
        }

        struct EventDebuggerLogIMGUICall : System.IDisposable
        {
            /*0xb92478*/ EventDebuggerLogIMGUICall(UnityEngine.UIElements.EventBase evt);
            /*0xb9247c*/ void Dispose();
        }

        struct EventDebuggerLogExecuteDefaultAction : System.IDisposable
        {
            /*0xb92480*/ EventDebuggerLogExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0xb92484*/ void Dispose();
        }

        class EventDebugger
        {
            static /*0xb92488*/ void LogPropagationPaths(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths paths);
        }

        interface IStyleDataGroup<T>
        {
            T Copy();
            void CopyFrom(ref T other);
        }

        struct InheritedData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.InheritedData>, System.IEquatable<UnityEngine.UIElements.InheritedData>
        {
            /*0x10*/ UnityEngine.Color color;
            /*0x20*/ UnityEngine.UIElements.Length fontSize;
            /*0x28*/ UnityEngine.UIElements.Length letterSpacing;
            /*0x30*/ UnityEngine.UIElements.TextShadow textShadow;
            /*0x50*/ UnityEngine.Font unityFont;
            /*0x58*/ UnityEngine.UIElements.FontDefinition unityFontDefinition;
            /*0x68*/ UnityEngine.FontStyle unityFontStyleAndWeight;
            /*0x6c*/ UnityEngine.UIElements.Length unityParagraphSpacing;
            /*0x74*/ UnityEngine.TextAnchor unityTextAlign;
            /*0x78*/ UnityEngine.Color unityTextOutlineColor;
            /*0x88*/ float unityTextOutlineWidth;
            /*0x8c*/ UnityEngine.UIElements.Visibility visibility;
            /*0x90*/ UnityEngine.UIElements.WhiteSpace whiteSpace;
            /*0x94*/ UnityEngine.UIElements.Length wordSpacing;

            static /*0xb924bc*/ bool op_Equality(UnityEngine.UIElements.InheritedData lhs, UnityEngine.UIElements.InheritedData rhs);
            /*0xb9248c*/ UnityEngine.UIElements.InheritedData Copy();
            /*0xb924a8*/ void CopyFrom(ref UnityEngine.UIElements.InheritedData other);
            /*0xb926bc*/ bool Equals(UnityEngine.UIElements.InheritedData other);
            /*0xb92708*/ bool Equals(object obj);
            /*0xb927b0*/ int GetHashCode();
        }

        struct LayoutData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.LayoutData>, System.IEquatable<UnityEngine.UIElements.LayoutData>
        {
            /*0x10*/ UnityEngine.UIElements.Align alignContent;
            /*0x14*/ UnityEngine.UIElements.Align alignItems;
            /*0x18*/ UnityEngine.UIElements.Align alignSelf;
            /*0x1c*/ float borderBottomWidth;
            /*0x20*/ float borderLeftWidth;
            /*0x24*/ float borderRightWidth;
            /*0x28*/ float borderTopWidth;
            /*0x2c*/ UnityEngine.UIElements.Length bottom;
            /*0x34*/ UnityEngine.UIElements.DisplayStyle display;
            /*0x38*/ UnityEngine.UIElements.Length flexBasis;
            /*0x40*/ UnityEngine.UIElements.FlexDirection flexDirection;
            /*0x44*/ float flexGrow;
            /*0x48*/ float flexShrink;
            /*0x4c*/ UnityEngine.UIElements.Wrap flexWrap;
            /*0x50*/ UnityEngine.UIElements.Length height;
            /*0x58*/ UnityEngine.UIElements.Justify justifyContent;
            /*0x5c*/ UnityEngine.UIElements.Length left;
            /*0x64*/ UnityEngine.UIElements.Length marginBottom;
            /*0x6c*/ UnityEngine.UIElements.Length marginLeft;
            /*0x74*/ UnityEngine.UIElements.Length marginRight;
            /*0x7c*/ UnityEngine.UIElements.Length marginTop;
            /*0x84*/ UnityEngine.UIElements.Length maxHeight;
            /*0x8c*/ UnityEngine.UIElements.Length maxWidth;
            /*0x94*/ UnityEngine.UIElements.Length minHeight;
            /*0x9c*/ UnityEngine.UIElements.Length minWidth;
            /*0xa4*/ UnityEngine.UIElements.Length paddingBottom;
            /*0xac*/ UnityEngine.UIElements.Length paddingLeft;
            /*0xb4*/ UnityEngine.UIElements.Length paddingRight;
            /*0xbc*/ UnityEngine.UIElements.Length paddingTop;
            /*0xc4*/ UnityEngine.UIElements.Position position;
            /*0xc8*/ UnityEngine.UIElements.Length right;
            /*0xd0*/ UnityEngine.UIElements.Length top;
            /*0xd8*/ UnityEngine.UIElements.Length width;

            static /*0xb92a2c*/ bool op_Equality(UnityEngine.UIElements.LayoutData lhs, UnityEngine.UIElements.LayoutData rhs);
            /*0xb929fc*/ UnityEngine.UIElements.LayoutData Copy();
            /*0xb92a18*/ void CopyFrom(ref UnityEngine.UIElements.LayoutData other);
            /*0xb92cac*/ bool Equals(UnityEngine.UIElements.LayoutData other);
            /*0xb92cf8*/ bool Equals(object obj);
            /*0xb92da0*/ int GetHashCode();
        }

        struct RareData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.RareData>, System.IEquatable<UnityEngine.UIElements.RareData>
        {
            /*0x10*/ UnityEngine.UIElements.Cursor cursor;
            /*0x28*/ UnityEngine.UIElements.TextOverflow textOverflow;
            /*0x2c*/ UnityEngine.Color unityBackgroundImageTintColor;
            /*0x3c*/ UnityEngine.ScaleMode unityBackgroundScaleMode;
            /*0x40*/ UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox;
            /*0x44*/ int unitySliceBottom;
            /*0x48*/ int unitySliceLeft;
            /*0x4c*/ int unitySliceRight;
            /*0x50*/ int unitySliceTop;
            /*0x54*/ UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition;

            static /*0xb93034*/ bool op_Equality(UnityEngine.UIElements.RareData lhs, UnityEngine.UIElements.RareData rhs);
            /*0xb93004*/ UnityEngine.UIElements.RareData Copy();
            /*0xb93020*/ void CopyFrom(ref UnityEngine.UIElements.RareData other);
            /*0xb93154*/ bool Equals(UnityEngine.UIElements.RareData other);
            /*0xb93198*/ bool Equals(object obj);
            /*0xb93238*/ int GetHashCode();
        }

        struct TransformData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.TransformData>, System.IEquatable<UnityEngine.UIElements.TransformData>
        {
            /*0x10*/ UnityEngine.UIElements.Rotate rotate;
            /*0x28*/ UnityEngine.UIElements.Scale scale;
            /*0x38*/ UnityEngine.UIElements.TransformOrigin transformOrigin;
            /*0x4c*/ UnityEngine.UIElements.Translate translate;

            static /*0xb93360*/ bool op_Equality(UnityEngine.UIElements.TransformData lhs, UnityEngine.UIElements.TransformData rhs);
            /*0xb93330*/ UnityEngine.UIElements.TransformData Copy();
            /*0xb9334c*/ void CopyFrom(ref UnityEngine.UIElements.TransformData other);
            /*0xb93488*/ bool Equals(UnityEngine.UIElements.TransformData other);
            /*0xb934cc*/ bool Equals(object obj);
            /*0xb9356c*/ int GetHashCode();
        }

        struct TransitionData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.TransitionData>, System.IEquatable<UnityEngine.UIElements.TransitionData>
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDelay;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDuration;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> transitionProperty;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction;

            static /*0xb93874*/ bool op_Equality(UnityEngine.UIElements.TransitionData lhs, UnityEngine.UIElements.TransitionData rhs);
            /*0xb935d0*/ UnityEngine.UIElements.TransitionData Copy();
            /*0xb93714*/ void CopyFrom(ref UnityEngine.UIElements.TransitionData other);
            /*0xb938c0*/ bool Equals(UnityEngine.UIElements.TransitionData other);
            /*0xb9390c*/ bool Equals(object obj);
            /*0xb939bc*/ int GetHashCode();
        }

        struct VisualData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.VisualData>, System.IEquatable<UnityEngine.UIElements.VisualData>
        {
            /*0x10*/ UnityEngine.Color backgroundColor;
            /*0x20*/ UnityEngine.UIElements.Background backgroundImage;
            /*0x40*/ UnityEngine.Color borderBottomColor;
            /*0x50*/ UnityEngine.UIElements.Length borderBottomLeftRadius;
            /*0x58*/ UnityEngine.UIElements.Length borderBottomRightRadius;
            /*0x60*/ UnityEngine.Color borderLeftColor;
            /*0x70*/ UnityEngine.Color borderRightColor;
            /*0x80*/ UnityEngine.Color borderTopColor;
            /*0x90*/ UnityEngine.UIElements.Length borderTopLeftRadius;
            /*0x98*/ UnityEngine.UIElements.Length borderTopRightRadius;
            /*0xa0*/ float opacity;
            /*0xa4*/ UnityEngine.UIElements.OverflowInternal overflow;

            static /*0xb93a88*/ bool op_Equality(UnityEngine.UIElements.VisualData lhs, UnityEngine.UIElements.VisualData rhs);
            /*0xb93a58*/ UnityEngine.UIElements.VisualData Copy();
            /*0xb93a74*/ void CopyFrom(ref UnityEngine.UIElements.VisualData other);
            /*0xb93c74*/ bool Equals(UnityEngine.UIElements.VisualData other);
            /*0xb93cc0*/ bool Equals(object obj);
            /*0xb93d68*/ int GetHashCode();
        }

        interface IStyle
        {
            void set_backgroundColor(UnityEngine.UIElements.StyleColor value);
            void set_borderBottomColor(UnityEngine.UIElements.StyleColor value);
            void set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value);
            void set_borderLeftColor(UnityEngine.UIElements.StyleColor value);
            void set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value);
            void set_borderRightColor(UnityEngine.UIElements.StyleColor value);
            void set_borderRightWidth(UnityEngine.UIElements.StyleFloat value);
            void set_borderTopColor(UnityEngine.UIElements.StyleColor value);
            void set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderTopWidth(UnityEngine.UIElements.StyleFloat value);
            void set_bottom(UnityEngine.UIElements.StyleLength value);
            void set_color(UnityEngine.UIElements.StyleColor value);
            UnityEngine.UIElements.StyleCursor get_cursor();
            UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> get_display();
            void set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value);
            void set_flexBasis(UnityEngine.UIElements.StyleLength value);
            void set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value);
            void set_flexGrow(UnityEngine.UIElements.StyleFloat value);
            void set_flexShrink(UnityEngine.UIElements.StyleFloat value);
            void set_fontSize(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleLength get_height();
            void set_height(UnityEngine.UIElements.StyleLength value);
            void set_left(UnityEngine.UIElements.StyleLength value);
            void set_marginBottom(UnityEngine.UIElements.StyleLength value);
            void set_marginLeft(UnityEngine.UIElements.StyleLength value);
            void set_marginRight(UnityEngine.UIElements.StyleLength value);
            void set_marginTop(UnityEngine.UIElements.StyleLength value);
            void set_minWidth(UnityEngine.UIElements.StyleLength value);
            void set_opacity(UnityEngine.UIElements.StyleFloat value);
            void set_paddingBottom(UnityEngine.UIElements.StyleLength value);
            void set_paddingLeft(UnityEngine.UIElements.StyleLength value);
            void set_paddingRight(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleLength get_paddingTop();
            void set_paddingTop(UnityEngine.UIElements.StyleLength value);
            void set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value);
            void set_right(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleRotate get_rotate();
            UnityEngine.UIElements.StyleScale get_scale();
            UnityEngine.UIElements.StyleTextShadow get_textShadow();
            void set_top(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleTransformOrigin get_transformOrigin();
            UnityEngine.UIElements.StyleTranslate get_translate();
            void set_translate(UnityEngine.UIElements.StyleTranslate value);
            void set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value);
            void set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value);
            UnityEngine.UIElements.StyleLength get_width();
            void set_width(UnityEngine.UIElements.StyleLength value);
        }

        interface IResolvedStyle
        {
            UnityEngine.Color get_backgroundColor();
            UnityEngine.Color get_borderBottomColor();
            float get_borderBottomLeftRadius();
            float get_borderBottomRightRadius();
            float get_borderBottomWidth();
            UnityEngine.Color get_borderLeftColor();
            float get_borderLeftWidth();
            UnityEngine.Color get_borderRightColor();
            float get_borderRightWidth();
            UnityEngine.Color get_borderTopColor();
            float get_borderTopLeftRadius();
            float get_borderTopRightRadius();
            float get_borderTopWidth();
            float get_bottom();
            UnityEngine.Color get_color();
            UnityEngine.UIElements.DisplayStyle get_display();
            float get_flexGrow();
            float get_flexShrink();
            float get_height();
            float get_left();
            float get_marginBottom();
            float get_marginLeft();
            float get_marginRight();
            float get_marginTop();
            UnityEngine.UIElements.StyleFloat get_minHeight();
            UnityEngine.UIElements.StyleFloat get_minWidth();
            float get_opacity();
            float get_paddingBottom();
            float get_paddingLeft();
            float get_paddingRight();
            float get_paddingTop();
            float get_right();
            UnityEngine.UIElements.Scale get_scale();
            float get_top();
            UnityEngine.Vector3 get_translate();
            UnityEngine.Color get_unityBackgroundImageTintColor();
            int get_unitySliceLeft();
            int get_unitySliceRight();
            UnityEngine.Color get_unityTextOutlineColor();
            float get_unityTextOutlineWidth();
            UnityEngine.UIElements.Visibility get_visibility();
            UnityEngine.UIElements.WhiteSpace get_whiteSpace();
            float get_width();
        }

        class ListViewController : UnityEngine.UIElements.CollectionViewController
        {
            /*0x30*/ System.Action itemsSourceSizeChanged;
            /*0x38*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsAdded;
            /*0x40*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsRemoved;

            static /*0xb9523c*/ System.Array AddToArray(System.Array source, int itemCount);
            static /*0xb95a38*/ System.Array RemoveFromArray(System.Array source, System.Collections.Generic.List<int> indicesToRemove);
            /*0xb95c08*/ ListViewController();
            /*0xb93fe8*/ void add_itemsSourceSizeChanged(System.Action value);
            /*0xb94084*/ void remove_itemsSourceSizeChanged(System.Action value);
            /*0xb94120*/ void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0xb941d0*/ void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0xb94280*/ void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0xb94330*/ void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0xb943e0*/ UnityEngine.UIElements.ListView get_listView();
            /*0xb9445c*/ void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem);
            /*0xb948d8*/ void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, int index);
            /*0xb94bc8*/ bool NeedsDragHandle(int index);
            /*0xb94c04*/ void AddItems(int itemCount);
            /*0xb95378*/ void Move(int index, int newIndex);
            /*0xb95628*/ void RemoveItem(int index);
            /*0xb957d8*/ void RemoveItems(System.Collections.Generic.List<int> indices);
            /*0xb9535c*/ void RaiseOnSizeChanged();
            /*0xb95340*/ void RaiseItemsAdded(System.Collections.Generic.IEnumerable<int> indices);
            /*0xb95bec*/ void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<int> indices);
            /*0xb95414*/ void Swap(int lhs, int rhs);
            /*0xb95124*/ void EnsureItemSourceCanBeResized();
        }

        class CollectionViewController
        {
            /*0x10*/ UnityEngine.UIElements.BaseVerticalCollectionView m_View;
            /*0x18*/ System.Collections.IList m_ItemsSource;
            /*0x20*/ System.Action itemsSourceChanged;
            /*0x28*/ System.Action<int, int> itemIndexChanged;

            /*0xb95c10*/ CollectionViewController();
            /*0xb95c18*/ void add_itemsSourceChanged(System.Action value);
            /*0xb95cb4*/ void remove_itemsSourceChanged(System.Action value);
            /*0xb95d50*/ void add_itemIndexChanged(System.Action<int, int> value);
            /*0xb95e00*/ void remove_itemIndexChanged(System.Action<int, int> value);
            /*0xb95eb0*/ System.Collections.IList get_itemsSource();
            /*0xb95314*/ void set_itemsSource(System.Collections.IList value);
            /*0xb95ed4*/ UnityEngine.UIElements.BaseVerticalCollectionView get_view();
            /*0xb95edc*/ void SetView(UnityEngine.UIElements.BaseVerticalCollectionView view);
            /*0xb95f70*/ int GetItemCount();
            /*0xb96020*/ int GetIdForIndex(int index);
            /*0xb96058*/ object GetItemForIndex(int index);
            /*0xb96194*/ void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem);
            /*0xb94b00*/ void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, int index);
            /*0xb961cc*/ void InvokeUnbindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, int index);
            /*0xb961f0*/ void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem);
            /*0xb96214*/ UnityEngine.UIElements.VisualElement MakeItem();
            /*0xb962f0*/ void BindItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0xb964c0*/ void UnbindItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0xb964f4*/ void DestroyItem(UnityEngine.UIElements.VisualElement element);
            /*0xb95eb8*/ void RaiseItemsSourceChanged();
            /*0xb9560c*/ void RaiseItemIndexChanged(int srcIndex, int dstIndex);
        }

        class DynamicHeightVirtualizationController<T> : UnityEngine.UIElements.VerticalVirtualizationController<T>
        {
            static /*0x0*/ int InitialAverageHeight;
            /*0x0*/ System.Collections.Generic.Dictionary<int, float> m_ItemHeightCache;
            /*0x0*/ System.Collections.Generic.HashSet<int> m_WaitingCache;
            /*0x0*/ int m_ForcedFirstVisibleItem;
            /*0x0*/ int m_ForcedLastVisibleItem;
            /*0x0*/ bool m_StickToBottom;
            /*0x0*/ float m_AverageHeight;
            /*0x0*/ float m_AccumulatedHeight;
            /*0x0*/ float m_StoredPadding;
            /*0x0*/ System.Action m_FillCallback;
            /*0x0*/ System.Action<UnityEngine.UIElements.ReusableCollectionItem> m_GeometryChangedCallback;
            /*0x0*/ UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledItem;
            /*0x0*/ System.Predicate<int> m_IndexOutOfBoundsPredicate;

            static DynamicHeightVirtualizationController();
            DynamicHeightVirtualizationController(UnityEngine.UIElements.BaseVerticalCollectionView collectionView);
            void Refresh(bool rebuild);
            void ScrollToItem(int index);
            void Resize(UnityEngine.Vector2 size, int layoutPass);
            void OnScroll(UnityEngine.Vector2 scrollOffset);
            bool NeedsFill();
            void Fill();
            int GetIndexFromPosition(UnityEngine.Vector2 position);
            float GetItemHeight(int index);
            int GetFirstVisibleItem(float offset);
            void UpdateScrollViewContainer(int index, float previousHeight, float newHeight);
            void ApplyScrollViewUpdate();
            void OnViewportGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            float GetContentHeight();
            float GetContentHeightForIndex(int lastIndex);
            void RegisterItemHeight(int index, float height);
            void UnregisterItemHeight(int index, float height);
            void OnRecycledItemGeometryChanged(UnityEngine.UIElements.ReusableCollectionItem item);
            T GetOrMakeItem();
            void ReplaceActiveItem(int index);
            void ReleaseItem(int activeItemsIndex);
            bool IsIndexOutOfBounds(int i);
            void <.ctor>b__13_0(UnityEngine.UIElements.VisualElement element);
        }

        class FixedHeightVirtualizationController<T> : UnityEngine.UIElements.VerticalVirtualizationController<T>
        {
            FixedHeightVirtualizationController(UnityEngine.UIElements.BaseVerticalCollectionView collectionView);
            float get_resolvedItemHeight();
            bool VisibleItemPredicate(T i);
            int GetIndexFromPosition(UnityEngine.Vector2 position);
            float GetItemHeight(int index);
            void ScrollToItem(int index);
            void Resize(UnityEngine.Vector2 size, int layoutPass);
            void OnScroll(UnityEngine.Vector2 scrollOffset);
            T GetOrMakeItem();
        }

        class ReusableListViewItem : UnityEngine.UIElements.ReusableCollectionItem
        {
            /*0x38*/ UnityEngine.UIElements.VisualElement m_Container;
            /*0x40*/ UnityEngine.UIElements.VisualElement m_DragHandle;
            /*0x48*/ UnityEngine.UIElements.VisualElement m_ItemContainer;

            /*0xb96a88*/ ReusableListViewItem();
            /*0xb96528*/ UnityEngine.UIElements.VisualElement get_rootElement();
            /*0xb948c8*/ void Init(UnityEngine.UIElements.VisualElement item, bool usesAnimatedDragger);
            /*0xb96548*/ void UpdateHierarchy(bool usesAnimatedDragger);
            /*0xb949c4*/ void UpdateDragHandle(bool needsDragHandle);
            /*0xb967bc*/ void PreAttachElement();
            /*0xb96904*/ void DetachElement();
        }

        class VerticalVirtualizationController<T> : UnityEngine.UIElements.CollectionVirtualizationController
        {
            /*0x0*/ UnityEngine.UIElements.BaseVerticalCollectionView m_ListView;
            /*0x0*/ UnityEngine.Pool.ObjectPool<T> m_Pool;
            /*0x0*/ System.Collections.Generic.List<T> m_ActiveItems;
            /*0x0*/ int m_LastFocusedElementIndex;
            /*0x0*/ System.Collections.Generic.List<int> m_LastFocusedElementTreeChildIndexes;
            /*0x0*/ int m_FirstVisibleIndex;
            /*0x0*/ System.Func<T, bool> m_VisibleItemPredicateDelegate;
            /*0x0*/ System.Collections.Generic.List<T> m_ScrollInsertionList;
            /*0x0*/ UnityEngine.UIElements.VisualElement k_EmptyRows;

            VerticalVirtualizationController(UnityEngine.UIElements.BaseVerticalCollectionView collectionView);
            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems();
            bool VisibleItemPredicate(T i);
            T get_firstVisibleItem();
            T get_lastVisibleItem();
            int get_visibleItemCount();
            int get_lastVisibleIndex();
            float get_lastHeight();
            void Refresh(bool rebuild);
            void Setup(T recycledItem, int newIndex);
            void OnFocus(UnityEngine.UIElements.VisualElement leafTarget);
            void OnBlur(UnityEngine.UIElements.VisualElement willFocus);
            void HandleFocus(UnityEngine.UIElements.ReusableCollectionItem recycledItem, int previousIndex);
            void UpdateBackground();
            void ReplaceActiveItem(int index);
            T GetOrMakeItem();
            void ReleaseItem(int activeItemsIndex);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.UIElements.VerticalVirtualizationController.<>c<T> <>9;
                static /*0x0*/ System.Func<T> <>9__25_0;
                static /*0x0*/ System.Action<T> <>9__25_1;

                static <>c();
                <>c();
                T <.ctor>b__25_0();
                void <.ctor>b__25_1(T i);
            }
        }

        class CollectionVirtualizationController
        {
            /*0x10*/ UnityEngine.UIElements.ScrollView m_ScrollView;

            /*0xb96b1c*/ CollectionVirtualizationController(UnityEngine.UIElements.ScrollView scrollView);
            int get_lastVisibleIndex();
            int get_visibleItemCount();
            void Refresh(bool rebuild);
            void ScrollToItem(int id);
            void Resize(UnityEngine.Vector2 size, int layoutPass);
            void OnScroll(UnityEngine.Vector2 offset);
            int GetIndexFromPosition(UnityEngine.Vector2 position);
            float GetItemHeight(int index);
            void OnFocus(UnityEngine.UIElements.VisualElement leafTarget);
            void OnBlur(UnityEngine.UIElements.VisualElement willFocus);
            void UpdateBackground();
            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems();
            void ReplaceActiveItem(int index);
        }

        class ReusableCollectionItem
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement <bindableElement>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> <animator>k__BackingField;
            /*0x20*/ int <index>k__BackingField;
            /*0x24*/ int <id>k__BackingField;
            /*0x28*/ System.Action<UnityEngine.UIElements.ReusableCollectionItem> onGeometryChanged;
            /*0x30*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent> m_GeometryChangedEventCallback;

            /*0xb96a8c*/ ReusableCollectionItem();
            /*0xb96b44*/ UnityEngine.UIElements.VisualElement get_rootElement();
            /*0xb96b4c*/ UnityEngine.UIElements.VisualElement get_bindableElement();
            /*0xb96b54*/ void set_bindableElement(UnityEngine.UIElements.VisualElement value);
            /*0xb96b5c*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator();
            /*0xb96b64*/ void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value);
            /*0xb96b6c*/ int get_index();
            /*0xb96b74*/ void set_index(int value);
            /*0xb96b7c*/ int get_id();
            /*0xb96b84*/ void set_id(int value);
            /*0xb96b8c*/ void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value);
            /*0xb96c3c*/ void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value);
            /*0xb96540*/ void Init(UnityEngine.UIElements.VisualElement item);
            /*0xb96848*/ void PreAttachElement();
            /*0xb96990*/ void DetachElement();
            /*0xb96cec*/ void SetSelected(bool selected);
            /*0xb96ddc*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
        }

        namespace UIR
        {
            enum OwnedState
            {
                Inherited = 0,
                Owned = 1,
            }

            struct BMPAlloc
            {
                static /*0x0*/ UnityEngine.UIElements.UIR.BMPAlloc Invalid;
                /*0x10*/ int page;
                /*0x14*/ ushort pageLine;
                /*0x16*/ byte bitIndex;
                /*0x17*/ UnityEngine.UIElements.UIR.OwnedState ownedState;

                static /*0xb96f38*/ BMPAlloc();
                /*0xb96dfc*/ bool Equals(UnityEngine.UIElements.UIR.BMPAlloc other);
                /*0xb96e34*/ bool IsValid();
                /*0xb96e44*/ string ToString();
            }

            struct BitmapAllocator32
            {
                /*0x10*/ int m_PageHeight;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.BitmapAllocator32.Page> m_Pages;
                /*0x20*/ System.Collections.Generic.List<uint> m_AllocMap;
                /*0x28*/ int m_EntryWidth;
                /*0x2c*/ int m_EntryHeight;

                static /*0xb9767c*/ byte CountTrailingZeroes(uint val);
                /*0xb96f84*/ void Construct(int pageHeight, int entryWidth, int entryHeight);
                /*0xb97094*/ void ForceFirstAlloc(ushort firstPageX, ushort firstPageY);
                /*0xb97260*/ UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage storage);
                /*0xb976e0*/ void Free(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb97824*/ int get_entryWidth();
                /*0xb9782c*/ int get_entryHeight();
                /*0xb97834*/ void GetAllocPageAtlasLocation(int page, ref ushort x, ref ushort y);

                struct Page
                {
                    /*0x10*/ ushort x;
                    /*0x12*/ ushort y;
                    /*0x14*/ int freeSlots;
                }
            }

            struct UIRVEShaderInfoAllocator
            {
                static /*0x0*/ UnityEngine.Vector2Int identityTransformTexel;
                static /*0x8*/ UnityEngine.Vector2Int infiniteClipRectTexel;
                static /*0x10*/ UnityEngine.Vector2Int fullOpacityTexel;
                static /*0x18*/ UnityEngine.Vector2Int clearColorTexel;
                static /*0x20*/ UnityEngine.Vector2Int defaultTextCoreSettingsTexel;
                static /*0x28*/ UnityEngine.Matrix4x4 identityTransformValue;
                static /*0x68*/ UnityEngine.Vector4 identityTransformRow0Value;
                static /*0x78*/ UnityEngine.Vector4 identityTransformRow1Value;
                static /*0x88*/ UnityEngine.Vector4 identityTransformRow2Value;
                static /*0x98*/ UnityEngine.Vector4 infiniteClipRectValue;
                static /*0xa8*/ UnityEngine.Vector4 fullOpacityValue;
                static /*0xb8*/ UnityEngine.Vector4 clearColorValue;
                static /*0xc8*/ UnityEngine.UIElements.UIR.TextCoreSettings defaultTextCoreSettingsValue;
                static /*0x108*/ UnityEngine.UIElements.UIR.BMPAlloc identityTransform;
                static /*0x110*/ UnityEngine.UIElements.UIR.BMPAlloc infiniteClipRect;
                static /*0x118*/ UnityEngine.UIElements.UIR.BMPAlloc fullOpacity;
                static /*0x120*/ UnityEngine.UIElements.UIR.BMPAlloc clearColor;
                static /*0x128*/ UnityEngine.UIElements.UIR.BMPAlloc defaultTextCoreSettings;
                /*0x10*/ UnityEngine.UIElements.UIR.BaseShaderInfoStorage m_Storage;
                /*0x18*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator;
                /*0x38*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator;
                /*0x58*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator;
                /*0x78*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator;
                /*0x98*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_TextSettingsAllocator;
                /*0xb8*/ bool m_StorageReallyCreated;
                /*0xb9*/ bool m_VertexTexturingEnabled;
                /*0xc0*/ Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.Transform3x4> m_Transforms;
                /*0xd0*/ Unity.Collections.NativeArray<UnityEngine.Vector4> m_ClipRects;

                static /*0xb994f8*/ UIRVEShaderInfoAllocator();
                static /*0xb978ac*/ int get_pageWidth();
                static /*0xb978b4*/ int get_pageHeight();
                static /*0xb978bc*/ UnityEngine.Vector2Int AllocToTexelCoord(ref UnityEngine.UIElements.UIR.BitmapAllocator32 allocator, UnityEngine.UIElements.UIR.BMPAlloc alloc);
                static /*0xb9790c*/ int AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                static /*0xb97974*/ bool AtlasRectMatchesPage(ref UnityEngine.UIElements.UIR.BitmapAllocator32 allocator, UnityEngine.UIElements.UIR.BMPAlloc defAlloc, UnityEngine.RectInt atlasRect);
                /*0xb97a6c*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants();
                /*0xb97ab4*/ Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants();
                /*0xb97afc*/ UnityEngine.Texture get_atlas();
                /*0xb97b8c*/ void Construct();
                /*0xb97e14*/ void ReallyCreateStorage();
                /*0xb989e4*/ void Dispose();
                /*0xb98b20*/ void IssuePendingStorageChanges();
                /*0xb98b38*/ UnityEngine.UIElements.UIR.BMPAlloc AllocTransform();
                /*0xb98c20*/ UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect();
                /*0xb98d08*/ UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity();
                /*0xb98d30*/ UnityEngine.UIElements.UIR.BMPAlloc AllocColor();
                /*0xb98d58*/ UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings settings);
                /*0xb98368*/ void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Matrix4x4 xform);
                /*0xb9857c*/ void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Vector4 clipRect);
                /*0xb986b4*/ void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, float opacity);
                /*0xb98790*/ void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Color color);
                /*0xb98880*/ void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.UIElements.UIR.TextCoreSettings settings);
                /*0xb98d80*/ void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb98df4*/ void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb98e68*/ void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb98edc*/ void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb98f50*/ void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb98fc4*/ UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb990e4*/ UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb99204*/ UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb99300*/ UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb993fc*/ UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
            }

            class GradientSettingsAtlas : System.IDisposable
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerWrite;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerCommit;
                static /*0x10*/ int s_TextureCounter;
                /*0x10*/ int m_Length;
                /*0x14*/ int m_ElemWidth;
                /*0x18*/ UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator;
                /*0x20*/ UnityEngine.Texture2D m_Atlas;
                /*0x28*/ UnityEngine.UIElements.UIR.GradientSettingsAtlas.RawTexture m_RawAtlas;
                /*0x38*/ bool <disposed>k__BackingField;
                /*0x39*/ bool <MustCommit>k__BackingField;

                static /*0xb9a15c*/ GradientSettingsAtlas();
                /*0xb997bc*/ GradientSettingsAtlas(int length);
                /*0xb996bc*/ int get_length();
                /*0xb996c4*/ bool get_disposed();
                /*0xb996cc*/ void set_disposed(bool value);
                /*0xb996d8*/ void Dispose();
                /*0xb99744*/ void Dispose(bool disposing);
                /*0xb997ec*/ void Reset();
                /*0xb998b8*/ UnityEngine.Texture2D get_atlas();
                /*0xb998c0*/ UnityEngine.UIElements.UIR.Alloc Add(int count);
                /*0xb999ac*/ void Write(UnityEngine.UIElements.UIR.Alloc alloc, UnityEngine.UIElements.GradientSettings[] settings, UnityEngine.UIElements.UIR.GradientRemap remap);
                /*0xb99f7c*/ bool get_MustCommit();
                /*0xb99f84*/ void set_MustCommit(bool value);
                /*0xb99f90*/ void Commit();
                /*0xb99ff4*/ void PrepareAtlas();

                struct RawTexture
                {
                    /*0x10*/ UnityEngine.Color32[] rgba;
                    /*0x18*/ int width;
                    /*0x1c*/ int height;

                    /*0xb99ef4*/ void WriteRawInt2Packed(int v0, int v1, int destX, int destY);
                    /*0xb99e4c*/ void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY);
                }
            }

            class BaseShaderInfoStorage : System.IDisposable
            {
                static /*0x0*/ int s_TextureCounter;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerCopyTexture;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerGetTextureData;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_MarkerUpdateTexture;
                /*0x10*/ bool <disposed>k__BackingField;

                static /*0xb9a244*/ BaseShaderInfoStorage();
                /*0xb9a23c*/ BaseShaderInfoStorage();
                UnityEngine.Texture2D get_texture();
                bool AllocateRect(int width, int height, ref UnityEngine.RectInt uvs);
                void SetTexel(int x, int y, UnityEngine.Color color);
                void UpdateTexture();
                /*0xb9a210*/ bool get_disposed();
                /*0xb9a218*/ void set_disposed(bool value);
                /*0xb98ab4*/ void Dispose();
                /*0xb9a224*/ void Dispose(bool disposing);
            }

            class ShaderInfoStorage<T> : UnityEngine.UIElements.UIR.BaseShaderInfoStorage
            {
                /*0x0*/ int m_InitialSize;
                /*0x0*/ int m_MaxSize;
                /*0x0*/ UnityEngine.TextureFormat m_Format;
                /*0x0*/ System.Func<UnityEngine.Color, T> m_Convert;
                /*0x0*/ UnityEngine.UIElements.UIRAtlasAllocator m_Allocator;
                /*0x0*/ UnityEngine.Texture2D m_Texture;
                /*0x0*/ Unity.Collections.NativeArray<T> m_Texels;

                static void CpuBlit(Unity.Collections.NativeArray<T> src, int srcWidth, int srcHeight, Unity.Collections.NativeArray<T> dst, int dstWidth, int dstHeight);
                ShaderInfoStorage(UnityEngine.TextureFormat format, System.Func<UnityEngine.Color, T> convert, int initialSize, int maxSize);
                void Dispose(bool disposing);
                UnityEngine.Texture2D get_texture();
                bool AllocateRect(int width, int height, ref UnityEngine.RectInt uvs);
                void SetTexel(int x, int y, UnityEngine.Color color);
                void UpdateTexture();
                void CreateOrExpandTexture();
            }

            class ShaderInfoStorageRGBA32 : UnityEngine.UIElements.UIR.ShaderInfoStorage<UnityEngine.Color32>
            {
                static /*0x0*/ System.Func<UnityEngine.Color, UnityEngine.Color32> s_Convert;

                static /*0xb9a330*/ ShaderInfoStorageRGBA32();
                /*0xb982d4*/ ShaderInfoStorageRGBA32(int initialSize, int maxSize);

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32.<> <>9;

                    static /*0xb9a3f4*/ <>c();
                    /*0xb9a458*/ <>c();
                    /*0xb9a460*/ UnityEngine.Color32 <.cctor>b__2_0(UnityEngine.Color c);
                }
            }

            class ShaderInfoStorageRGBAFloat : UnityEngine.UIElements.UIR.ShaderInfoStorage<UnityEngine.Color>
            {
                static /*0x0*/ System.Func<UnityEngine.Color, UnityEngine.Color> s_Convert;

                static /*0xb9a724*/ ShaderInfoStorageRGBAFloat();
                /*0xb98240*/ ShaderInfoStorageRGBAFloat(int initialSize, int maxSize);

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat.<> <>9;

                    static /*0xb9a7e8*/ <>c();
                    /*0xb9a84c*/ <>c();
                    /*0xb9a854*/ UnityEngine.Color <.cctor>b__2_0(UnityEngine.Color c);
                }
            }

            class TextureBlitter : System.IDisposable
            {
                static /*0x0*/ int[] k_TextureIds;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_CommitSampler;
                /*0x10*/ UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo[] m_SingleBlit;
                /*0x18*/ UnityEngine.Material m_BlitMaterial;
                /*0x20*/ UnityEngine.MaterialPropertyBlock m_Properties;
                /*0x28*/ UnityEngine.RectInt m_Viewport;
                /*0x38*/ UnityEngine.RenderTexture m_PrevRT;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> m_PendingBlits;
                /*0x48*/ bool <disposed>k__BackingField;

                static /*0xb9a8e8*/ TextureBlitter();
                /*0xb8c190*/ TextureBlitter(int capacity);
                /*0xb9a858*/ bool get_disposed();
                /*0xb9a860*/ void set_disposed(bool value);
                /*0xb8c498*/ void Dispose();
                /*0xb9a86c*/ void Dispose(bool disposing);
                /*0xb8c884*/ void QueueBlit(UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, bool addBorder, UnityEngine.Color tint);
                /*0xb8d108*/ void BlitOneNow(UnityEngine.RenderTexture dst, UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, bool addBorder, UnityEngine.Color tint);
                /*0xb8cee4*/ void Commit(UnityEngine.RenderTexture dst);
                /*0xb9aa14*/ void BeginBlit(UnityEngine.RenderTexture dst);
                /*0xb9ac10*/ void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, int startIndex);
                /*0xb9b12c*/ void EndBlit();

                struct BlitInfo
                {
                    /*0x10*/ UnityEngine.Texture src;
                    /*0x18*/ UnityEngine.RectInt srcRect;
                    /*0x28*/ UnityEngine.Vector2Int dstPos;
                    /*0x30*/ int border;
                    /*0x34*/ UnityEngine.Color tint;
                }
            }

            struct ChainBuilderStats
            {
                /*0x10*/ uint elementsAdded;
                /*0x14*/ uint elementsRemoved;
                /*0x18*/ uint recursiveClipUpdates;
                /*0x1c*/ uint recursiveClipUpdatesExpanded;
                /*0x20*/ uint nonRecursiveClipUpdates;
                /*0x24*/ uint recursiveTransformUpdates;
                /*0x28*/ uint recursiveTransformUpdatesExpanded;
                /*0x2c*/ uint recursiveOpacityUpdates;
                /*0x30*/ uint recursiveOpacityUpdatesExpanded;
                /*0x34*/ uint colorUpdates;
                /*0x38*/ uint colorUpdatesExpanded;
                /*0x3c*/ uint recursiveVisualUpdates;
                /*0x40*/ uint recursiveVisualUpdatesExpanded;
                /*0x44*/ uint nonRecursiveVisualUpdates;
                /*0x48*/ uint dirtyProcessed;
                /*0x4c*/ uint nudgeTransformed;
                /*0x50*/ uint boneTransformed;
                /*0x54*/ uint skipTransformed;
                /*0x58*/ uint visualUpdateTransformed;
                /*0x5c*/ uint updatedMeshAllocations;
                /*0x60*/ uint newMeshAllocations;
                /*0x64*/ uint groupTransformElementsChanged;
                /*0x68*/ uint immedateRenderersActive;
                /*0x6c*/ uint textUpdates;
            }

            class RenderChain : System.IDisposable
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerProcess;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerClipProcessing;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerOpacityProcessing;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_MarkerColorsProcessing;
                static /*0x20*/ Unity.Profiling.ProfilerMarker s_MarkerTransformProcessing;
                static /*0x28*/ Unity.Profiling.ProfilerMarker s_MarkerVisualsProcessing;
                static /*0x30*/ Unity.Profiling.ProfilerMarker s_MarkerTextRegen;
                static /*0x38*/ System.Action OnPreRender;
                /*0x10*/ UnityEngine.UIElements.UIR.RenderChainCommand m_FirstCommand;
                /*0x18*/ UnityEngine.UIElements.UIR.RenderChain.DepthOrderedDirtyTracking m_DirtyTracker;
                /*0x40*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.RenderChainCommand> m_CommandPool;
                /*0x48*/ UnityEngine.UIElements.UIR.BasicNodePool<UnityEngine.UIElements.UIR.TextureEntry> m_TexturePool;
                /*0x50*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain.RenderNodeData> m_RenderNodesData;
                /*0x58*/ UnityEngine.Shader m_DefaultShader;
                /*0x60*/ UnityEngine.Shader m_DefaultWorldSpaceShader;
                /*0x68*/ UnityEngine.Material m_DefaultMat;
                /*0x70*/ UnityEngine.Material m_DefaultWorldSpaceMat;
                /*0x78*/ bool m_BlockDirtyRegistration;
                /*0x7c*/ int m_StaticIndex;
                /*0x80*/ int m_ActiveRenderNodes;
                /*0x84*/ int m_CustomMaterialCommands;
                /*0x88*/ UnityEngine.UIElements.UIR.ChainBuilderStats m_Stats;
                /*0xe8*/ uint m_StatsElementsAdded;
                /*0xec*/ uint m_StatsElementsRemoved;
                /*0xf0*/ UnityEngine.UIElements.VisualElement m_FirstTextElement;
                /*0xf8*/ UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter m_TextUpdatePainter;
                /*0x100*/ int m_TextElementCount;
                /*0x104*/ int m_DirtyTextStartIndex;
                /*0x108*/ int m_DirtyTextRemaining;
                /*0x10c*/ bool m_FontWasReset;
                /*0x110*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> m_LastGroupTransformElementScale;
                /*0x118*/ UnityEngine.UIElements.TextureRegistry m_TextureRegistry;
                /*0x120*/ bool <disposed>k__BackingField;
                /*0x128*/ UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField;
                /*0x130*/ UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField;
                /*0x138*/ UnityEngine.UIElements.AtlasBase <atlas>k__BackingField;
                /*0x140*/ UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField;
                /*0x148*/ UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator shaderInfoAllocator;
                /*0x218*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter <painter>k__BackingField;
                /*0x220*/ bool <drawStats>k__BackingField;
                /*0x221*/ bool <drawInCameras>k__BackingField;

                static /*0xb9b20c*/ RenderChain();
                static /*0xb9ea38*/ UnityEngine.UIElements.UIR.RenderChain.RenderNodeData AccessRenderNodeData(nint obj);
                static /*0xb9eb10*/ void OnRenderNodeExecute(nint obj);
                static /*0xb9ebb8*/ void OnRegisterIntermediateRenderers(UnityEngine.Camera camera);
                static /*0xb9f018*/ void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel rtp, UnityEngine.UIElements.UIR.RenderChain renderChain, ref UnityEngine.UIElements.UIR.RenderChain.RenderNodeData rnd, UnityEngine.Camera camera, int sameDistanceSortPriority);
                static /*0xb9be40*/ UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement ve);
                /*0xb9b4bc*/ RenderChain(UnityEngine.UIElements.BaseVisualElementPanel panel);
                /*0xb9b874*/ void Constructor(UnityEngine.UIElements.BaseVisualElementPanel panelObj, UnityEngine.UIElements.UIR.UIRenderDevice deviceObj, UnityEngine.UIElements.AtlasBase atlas, UnityEngine.UIElements.UIR.VectorImageManager vectorImageMan);
                /*0xb9bbfc*/ void Destructor();
                /*0xb9bf94*/ bool get_disposed();
                /*0xb9bf9c*/ void set_disposed(bool value);
                /*0xb9bfa8*/ void Dispose();
                /*0xb9c018*/ void Dispose(bool disposing);
                /*0xb9c044*/ void ProcessChanges();
                /*0xb9c840*/ void Render();
                /*0xb9c610*/ void ProcessTextRegen(bool timeSliced);
                /*0xb9dad8*/ void UIEOnChildAdded(UnityEngine.UIElements.VisualElement ve);
                /*0xb9de60*/ void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e018*/ void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e118*/ void StopTrackingGroupTransformElement(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e170*/ void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement ve);
                /*0xb9dca4*/ void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement ve, bool hierarchical);
                /*0xb9dd38*/ void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement ve, bool hierarchical);
                /*0xb9e210*/ void UIEOnColorChanged(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e298*/ void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement ve, bool transformChanged, bool clipRectSizeChanged);
                /*0xb9ddcc*/ void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement ve, bool hierarchical);
                /*0xb9e330*/ UnityEngine.UIElements.BaseVisualElementPanel get_panel();
                /*0xb9e338*/ void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value);
                /*0xb9e340*/ UnityEngine.UIElements.UIR.UIRenderDevice get_device();
                /*0xb9e348*/ void set_device(UnityEngine.UIElements.UIR.UIRenderDevice value);
                /*0xb9e350*/ UnityEngine.UIElements.AtlasBase get_atlas();
                /*0xb9e358*/ void set_atlas(UnityEngine.UIElements.AtlasBase value);
                /*0xb9e360*/ UnityEngine.UIElements.UIR.VectorImageManager get_vectorImageManager();
                /*0xb9e368*/ void set_vectorImageManager(UnityEngine.UIElements.UIR.VectorImageManager value);
                /*0xb9e370*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter get_painter();
                /*0xb9e378*/ void set_painter(UnityEngine.UIElements.UIR.Implementation.UIRStylePainter value);
                /*0xb9e380*/ bool get_drawStats();
                /*0xb9e388*/ void set_drawStats(bool value);
                /*0xb9e394*/ bool get_drawInCameras();
                /*0xb9e39c*/ void set_drawInCameras(bool value);
                /*0xb9e3a8*/ void set_defaultShader(UnityEngine.Shader value);
                /*0xb9e458*/ void set_defaultWorldSpaceShader(UnityEngine.Shader value);
                /*0xb9cb78*/ UnityEngine.Material GetStandardMaterial();
                /*0xb9e508*/ UnityEngine.Material GetStandardWorldSpaceMaterial();
                /*0xb9e5f4*/ void EnsureFitsDepth(int depth);
                /*0xb9e600*/ void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e6b8*/ UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand();
                /*0xb9e720*/ void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd);
                /*0xb9e7d0*/ void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand command);
                /*0xb9e85c*/ void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand firstCommand, UnityEngine.UIElements.UIR.RenderChainCommand lastCommand);
                /*0xb9e884*/ void AddTextElement(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e8b8*/ void RemoveTextElement(UnityEngine.UIElements.VisualElement ve);
                /*0xb9e90c*/ void OnGroupTransformElementChangedTransform(UnityEngine.UIElements.VisualElement ve);
                /*0xb9f36c*/ void RepaintTexturedElements();
                /*0xb9f44c*/ void OnFontReset(UnityEngine.Font font);
                /*0xb9f458*/ void AppendTexture(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture src, UnityEngine.UIElements.TextureId id, bool isAtlas);
                /*0xb9be88*/ void ResetTextures(UnityEngine.UIElements.VisualElement ve);
                /*0xb9cc64*/ void DrawStats();

                struct DepthOrderedDirtyTracking
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> heads;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> tails;
                    /*0x20*/ int[] minDepths;
                    /*0x28*/ int[] maxDepths;
                    /*0x30*/ uint dirtyID;

                    /*0xb7a838*/ void EnsureFits(int maxDepth);
                    /*0xb7a954*/ void RegisterDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses dirtyTypeClass);
                    /*0xb7ab10*/ void ClearDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypesInverse);
                    /*0xb7aca0*/ void Reset();
                }

                struct RenderChainStaticIndexAllocator
                {
                    static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain> renderChains;

                    static /*0xb7af6c*/ RenderChainStaticIndexAllocator();
                    static /*0xb7ad18*/ int AllocateIndex(UnityEngine.UIElements.UIR.RenderChain renderChain);
                    static /*0xb7ae68*/ void FreeIndex(int index);
                    static /*0xb7aeec*/ UnityEngine.UIElements.UIR.RenderChain AccessIndex(int index);
                }

                struct RenderNodeData
                {
                    /*0x10*/ UnityEngine.Material standardMaterial;
                    /*0x18*/ UnityEngine.Material initialMaterial;
                    /*0x20*/ UnityEngine.MaterialPropertyBlock matPropBlock;
                    /*0x28*/ UnityEngine.UIElements.UIR.RenderChainCommand firstCommand;
                    /*0x30*/ UnityEngine.UIElements.UIR.UIRenderDevice device;
                    /*0x38*/ UnityEngine.Texture vectorAtlas;
                    /*0x40*/ UnityEngine.Texture shaderInfoAtlas;
                    /*0x48*/ float dpiScale;
                    /*0x50*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transformConstants;
                    /*0x60*/ Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRectConstants;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.RenderChain.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__37_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__37_1;

                    static /*0xb7affc*/ <>c();
                    /*0xb7b060*/ <>c();
                    /*0xb7b068*/ UnityEngine.UIElements.UIR.RenderChainCommand <.ctor>b__37_0();
                    /*0xb7b0c4*/ void <.ctor>b__37_1(UnityEngine.UIElements.UIR.RenderChainCommand cmd);
                }
            }

            enum RenderDataDirtyTypes
            {
                None = 0,
                Transform = 1,
                ClipRectSize = 2,
                Clipping = 4,
                ClippingHierarchy = 8,
                Visuals = 16,
                VisualsHierarchy = 32,
                Opacity = 64,
                OpacityHierarchy = 128,
                Color = 256,
            }

            enum RenderDataDirtyTypeClasses
            {
                Clipping = 0,
                Opacity = 1,
                Color = 2,
                TransformSize = 3,
                Visuals = 4,
                Count = 5,
            }

            struct RenderChainVEData
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement prev;
                /*0x18*/ UnityEngine.UIElements.VisualElement next;
                /*0x20*/ UnityEngine.UIElements.VisualElement groupTransformAncestor;
                /*0x28*/ UnityEngine.UIElements.VisualElement boneTransformAncestor;
                /*0x30*/ UnityEngine.UIElements.VisualElement prevDirty;
                /*0x38*/ UnityEngine.UIElements.VisualElement nextDirty;
                /*0x40*/ int hierarchyDepth;
                /*0x44*/ UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtiedValues;
                /*0x48*/ uint dirtyID;
                /*0x50*/ UnityEngine.UIElements.UIR.RenderChainCommand firstCommand;
                /*0x58*/ UnityEngine.UIElements.UIR.RenderChainCommand lastCommand;
                /*0x60*/ UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand;
                /*0x68*/ UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand;
                /*0x70*/ bool isInChain;
                /*0x71*/ bool isHierarchyHidden;
                /*0x72*/ bool localFlipsWinding;
                /*0x73*/ bool worldFlipsWinding;
                /*0x74*/ UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod;
                /*0x78*/ int childrenStencilRef;
                /*0x7c*/ int childrenMaskDepth;
                /*0x80*/ bool disableNudging;
                /*0x81*/ bool usesLegacyText;
                /*0x88*/ UnityEngine.UIElements.UIR.MeshHandle data;
                /*0x90*/ UnityEngine.UIElements.UIR.MeshHandle closingData;
                /*0x98*/ UnityEngine.Matrix4x4 verticesSpace;
                /*0xd8*/ int displacementUVStart;
                /*0xdc*/ int displacementUVEnd;
                /*0xe0*/ UnityEngine.UIElements.UIR.BMPAlloc transformID;
                /*0xe8*/ UnityEngine.UIElements.UIR.BMPAlloc clipRectID;
                /*0xf0*/ UnityEngine.UIElements.UIR.BMPAlloc opacityID;
                /*0xf8*/ UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID;
                /*0x100*/ UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID;
                /*0x108*/ UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID;
                /*0x110*/ UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID;
                /*0x118*/ UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID;
                /*0x120*/ UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID;
                /*0x128*/ UnityEngine.UIElements.UIR.BMPAlloc tintColorID;
                /*0x130*/ float compositeOpacity;
                /*0x134*/ UnityEngine.Color backgroundColor;
                /*0x148*/ UnityEngine.UIElements.VisualElement prevText;
                /*0x150*/ UnityEngine.UIElements.VisualElement nextText;
                /*0x158*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChainTextEntry> textEntries;
                /*0x160*/ UnityEngine.UIElements.UIR.BasicNode<UnityEngine.UIElements.UIR.TextureEntry> textures;

                static /*0xb7b0e0*/ bool AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                static /*0xb7b114*/ bool InheritsID(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0xb7b0c8*/ UnityEngine.UIElements.UIR.RenderChainCommand get_lastClosingOrLastCommand();
            }

            struct RenderChainTextEntry
            {
                /*0x10*/ UnityEngine.UIElements.UIR.RenderChainCommand command;
                /*0x18*/ int firstVertex;
                /*0x1c*/ int vertexCount;
            }

            struct TextureEntry
            {
                /*0x10*/ UnityEngine.Texture source;
                /*0x18*/ UnityEngine.UIElements.TextureId actual;
                /*0x1c*/ bool replaced;
            }

            class LinkedPoolItem<T>
            {
                /*0x0*/ T poolNext;

                LinkedPoolItem();
            }

            class LinkedPool<T>
            {
                /*0x0*/ System.Func<T> m_CreateFunc;
                /*0x0*/ System.Action<T> m_ResetAction;
                /*0x0*/ int m_Limit;
                /*0x0*/ T m_PoolFirst;
                /*0x0*/ int <Count>k__BackingField;

                LinkedPool(System.Func<T> createFunc, System.Action<T> resetAction, int limit);
                int get_Count();
                void set_Count(int value);
                void Clear();
                T Get();
                void Return(T item);
            }

            class BasicNode<T> : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.BasicNode<T>>
            {
                /*0x0*/ UnityEngine.UIElements.UIR.BasicNode<T> next;
                /*0x0*/ T data;

                BasicNode();
                void AppendTo(ref UnityEngine.UIElements.UIR.BasicNode<T> first);
            }

            class BasicNodePool<T> : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.BasicNode<T>>
            {
                static void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node);
                static UnityEngine.UIElements.UIR.BasicNode<T> Create();
                BasicNodePool();
            }

            class MeshBuilder
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker s_VectorGraphics9Slice;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_VectorGraphicsSplitTriangle;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_VectorGraphicsScaleTriangle;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_VectorGraphicsStretch;
                static /*0x20*/ int s_MaxTextMeshVertices;
                static /*0x28*/ ushort[] slicedQuadIndices;
                static /*0x30*/ float[] k_TexCoordSlicesX;
                static /*0x38*/ float[] k_TexCoordSlicesY;
                static /*0x40*/ float[] k_PositionSlicesX;
                static /*0x48*/ float[] k_PositionSlicesY;
                static /*0x50*/ UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge[] s_AllClipEdges;

                static /*0xb82a88*/ MeshBuilder();
                static /*0xb7b144*/ void MakeBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb7b480*/ void MakeSolidRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb7c068*/ void MakeTexturedRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage);
                static /*0xb7da7c*/ UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, int index, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.VertexFlags flags, bool isDynamicColor);
                static /*0xb7db8c*/ UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, UnityEngine.Vector2 offset);
                static /*0xb7dbc4*/ int LimitTextVertices(int vertexCount, bool logTruncation);
                static /*0xb7dcf4*/ void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.UIR.VertexFlags flags, bool isDynamicColor);
                static /*0xb7e050*/ void MakeText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb7e314*/ void UpdateText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.Matrix4x4 transform, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 flags, UnityEngine.Color32 opacityPageSettingIndex, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices);
                static /*0xb7c37c*/ void MakeQuad(UnityEngine.Rect rcPosition, UnityEngine.Rect rcTexCoord, UnityEngine.Color color, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage);
                static /*0xb7d0d4*/ void MakeSlicedQuad(ref UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb7e4cc*/ void MakeVectorGraphics(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, ref int finalVertexCount, ref int finalIndexCount);
                static /*0xb7e874*/ void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, UnityEngine.Rect targetRect, UnityEngine.Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, int settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, ref int finalVertexCount, ref int finalIndexCount);
                static /*0xb80674*/ void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, UnityEngine.Vector4 sliceLTRB, int sliceIndex);
                static /*0xb812bc*/ void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB);
                static /*0xb7f860*/ void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB, bool stretch, UnityEngine.Color tint, int settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb8008c*/ UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, UnityEngine.Vector4 clipRectMinMax);
                static /*0xb80238*/ void RectClip(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts cc, ref int newVertexCount);
                static /*0xb81540*/ void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, ushort* it, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, ref ushort nextNewVertex);
                static /*0xb8209c*/ UnityEngine.Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, float x, float y);
                static /*0xb82158*/ UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, float x, float y, UnityEngine.Vector3 uvw);
                static /*0xb82670*/ UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, int e0, int e1, float t);
                static /*0xb825d4*/ float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy);

                struct AllocMeshData
                {
                    /*0x10*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator alloc;
                    /*0x18*/ UnityEngine.Texture texture;
                    /*0x20*/ UnityEngine.UIElements.TextureId svgTexture;
                    /*0x28*/ UnityEngine.Material material;
                    /*0x30*/ UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags;
                    /*0x34*/ UnityEngine.UIElements.UIR.BMPAlloc colorAlloc;

                    /*0xb7e028*/ UnityEngine.UIElements.MeshWriteData Allocate(uint vertexCount, uint indexCount);

                    class Allocator : System.MulticastDelegate
                    {
                        /*0xb82d08*/ Allocator(object object, nint method);
                        /*0xb82dcc*/ UnityEngine.UIElements.MeshWriteData Invoke(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    }
                }

                struct ClipCounts
                {
                    /*0x10*/ int firstClippedIndex;
                    /*0x14*/ int firstDegenerateIndex;
                    /*0x18*/ int lastClippedIndex;
                    /*0x1c*/ int clippedTriangles;
                    /*0x20*/ int addedTriangles;
                    /*0x24*/ int degenerateTriangles;
                }

                enum VertexClipEdge
                {
                    None = 0,
                    Left = 1,
                    Top = 2,
                    Right = 4,
                    Bottom = 8,
                }
            }

            class TextureSlotManager
            {
                static /*0x0*/ int k_SlotCount;
                static /*0x8*/ int[] slotIds;
                static /*0x10*/ int textureTableId;
                /*0x10*/ UnityEngine.UIElements.TextureId[] m_Textures;
                /*0x18*/ int[] m_Tickets;
                /*0x20*/ int m_CurrentTicket;
                /*0x24*/ int m_FirstUsedTicket;
                /*0x28*/ UnityEngine.Vector4[] m_GpuTextures;
                /*0x30*/ int <FreeSlots>k__BackingField;
                /*0x38*/ UnityEngine.UIElements.TextureRegistry textureRegistry;

                static /*0xb82de0*/ TextureSlotManager();
                /*0xb82f68*/ TextureSlotManager();
                /*0xb830d0*/ void Reset();
                /*0xb831fc*/ void StartNewBatch();
                /*0xb83268*/ int IndexOf(UnityEngine.UIElements.TextureId id);
                /*0xb8333c*/ void MarkUsed(int slotIndex);
                /*0xb83394*/ int get_FreeSlots();
                /*0xb8339c*/ void set_FreeSlots(int value);
                /*0xb833a4*/ int FindOldestSlot();
                /*0xb83474*/ void Bind(UnityEngine.UIElements.TextureId id, int slot, UnityEngine.MaterialPropertyBlock mat);
            }

            class Tessellation
            {
                static /*0x0*/ float kEpsilon;
                static /*0x4*/ float kUnusedArc;
                static /*0x8*/ ushort kSubdivisions;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerTessellateRect;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_MarkerTessellateBorder;
                static /*0x20*/ UnityEngine.UIElements.UIR.Tessellation.Edges[] s_AllEdges;

                static /*0xb8ab80*/ Tessellation();
                static /*0xb7bd60*/ void TessellateRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, bool computeUVs);
                static /*0xb7b5d4*/ void TessellateQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb7b204*/ void TessellateBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0xb8368c*/ void TessellateRoundedCorners(ref UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb84838*/ void TessellateRoundedBorders(ref UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams border, float posZ, UnityEngine.UIElements.MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb85700*/ void TessellateRoundedCorner(UnityEngine.Rect rect, UnityEngine.Color32 color, float posZ, UnityEngine.Vector2 radius, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb85d50*/ void TessellateRoundedBorder(UnityEngine.Rect rect, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.Vector2 radius, float leftWidth, float topWidth, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb894dc*/ UnityEngine.Vector2 IntersectLines(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3);
                static /*0xb88a08*/ int LooseCompare(float a, float b);
                static /*0xb88e28*/ void TessellateComplexBorderCorner(UnityEngine.Rect rect, UnityEngine.Vector2 radius, float leftWidth, float topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb89dd0*/ void TessellateQuad(UnityEngine.Rect rect, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb8474c*/ void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb8a10c*/ int EdgesCount(UnityEngine.UIElements.UIR.Tessellation.Edges edges);
                static /*0xb895e0*/ void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Vector2* offsets, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb8a654*/ void EncodeStraightArc(ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex center, float radius);
                static /*0xb8a7dc*/ void ExpandTriangle(ref UnityEngine.Vector3 v0, ref UnityEngine.Vector3 v1, UnityEngine.Vector3 center, float factor);
                static /*0xb8a130*/ void TessellateQuadSingleEdge(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb86b14*/ void TessellateStraightBorder(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, float miterOffset, UnityEngine.Color color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb8a9c8*/ UnityEngine.Vector4 GetInterpolatedCircle(UnityEngine.Vector2 p, ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex v2);
                static /*0xb8aae0*/ void ComputeBarycentricCoordinates(UnityEngine.Vector2 p, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, ref float u, ref float v, ref float w);
                static /*0xb864d4*/ void TessellateFilledFan(UnityEngine.Vector2 center, UnityEngine.Vector2 radius, UnityEngine.Vector2 miterOffset, float leftWidth, float topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb88aa8*/ void TessellateBorderedFan(UnityEngine.Vector2 center, UnityEngine.Vector2 outerRadius, float leftWidth, float topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0xb85a44*/ void MirrorVertices(UnityEngine.Rect rect, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal);
                static /*0xb85c68*/ void FlipWinding(Unity.Collections.NativeSlice<ushort> indices, int indexStart, int indexCount);
                static /*0xb844f0*/ void ComputeUVs(UnityEngine.Rect tessellatedRect, UnityEngine.Rect textureRect, UnityEngine.Rect uvRegion, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices);

                enum Edges
                {
                    None = 0,
                    Left = 1,
                    Top = 2,
                    Right = 4,
                    Bottom = 8,
                    All = 15,
                }
            }

            class Allocator2D
            {
                /*0x10*/ UnityEngine.Vector2Int m_MinSize;
                /*0x18*/ UnityEngine.Vector2Int m_MaxSize;
                /*0x20*/ UnityEngine.Vector2Int m_MaxAllocSize;
                /*0x28*/ int m_RowHeightBias;
                /*0x30*/ UnityEngine.UIElements.UIR.Allocator2D.Row[] m_Rows;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> m_Areas;

                static /*0x13fe3a0*/ void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize);
                static /*0x13fe610*/ UnityEngine.Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, int rowHeightBias);
                static /*0x13fe72c*/ UnityEngine.UIElements.UIR.Allocator2D.Row[] BuildRowArray(int maxRowHeight, int rowHeightBias);
                /*0x13fe188*/ Allocator2D(UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize, int rowHeightBias);
                /*0x13fe7b4*/ bool TryAllocate(int width, int height, ref UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D);
                /*0x13fef2c*/ void Free(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D);

                class Area
                {
                    /*0x10*/ UnityEngine.RectInt rect;
                    /*0x20*/ UnityEngine.UIElements.UIR.BestFitAllocator allocator;

                    /*0x13ff3a0*/ Area(UnityEngine.RectInt rect);
                }

                class Row : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.Allocator2D.Row>
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.Allocator2D.Row> pool;
                    /*0x18*/ UnityEngine.RectInt rect;
                    /*0x28*/ UnityEngine.UIElements.UIR.Allocator2D.Area area;
                    /*0x30*/ UnityEngine.UIElements.UIR.BestFitAllocator allocator;
                    /*0x38*/ UnityEngine.UIElements.UIR.Alloc alloc;
                    /*0x50*/ UnityEngine.UIElements.UIR.Allocator2D.Row next;

                    static /*0x13ff4fc*/ Row();
                    static /*0x13ff434*/ UnityEngine.UIElements.UIR.Allocator2D.Row Create();
                    static /*0x13ff4d4*/ void Reset(UnityEngine.UIElements.UIR.Allocator2D.Row row);
                    /*0x13ff48c*/ Row();
                }

                struct Alloc2D
                {
                    /*0x10*/ UnityEngine.RectInt rect;
                    /*0x20*/ UnityEngine.UIElements.UIR.Allocator2D.Row row;
                    /*0x28*/ UnityEngine.UIElements.UIR.Alloc alloc;

                    /*0x13fede0*/ Alloc2D(UnityEngine.UIElements.UIR.Allocator2D.Row row, UnityEngine.UIElements.UIR.Alloc alloc, int width, int height);
                }
            }

            struct TextCoreSettings : System.IEquatable<UnityEngine.UIElements.UIR.TextCoreSettings>
            {
                /*0x10*/ UnityEngine.Color faceColor;
                /*0x20*/ UnityEngine.Color outlineColor;
                /*0x30*/ float outlineWidth;
                /*0x34*/ UnityEngine.Color underlayColor;
                /*0x44*/ UnityEngine.Vector2 underlayOffset;
                /*0x4c*/ float underlaySoftness;

                /*0x13ff62c*/ bool Equals(object obj);
                /*0x13ff6bc*/ bool Equals(UnityEngine.UIElements.UIR.TextCoreSettings other);
                /*0x13ff7a4*/ int GetHashCode();
            }

            class Shaders
            {
                static /*0x0*/ string k_AtlasBlit;
                static /*0x8*/ string k_Editor;
                static /*0x10*/ string k_Runtime;
                static /*0x18*/ string k_RuntimeWorld;
                static /*0x20*/ string k_GraphView;

                static /*0x13ff93c*/ Shaders();
            }

            class VectorImageRenderInfoPool : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.VectorImageRenderInfo>
            {
                /*0x13ffae8*/ VectorImageRenderInfoPool();

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.VectorImageRenderInfoPool.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_1;

                    static /*0x13ffc70*/ <>c();
                    /*0x13ffcd4*/ <>c();
                    /*0x13ffcdc*/ UnityEngine.UIElements.UIR.VectorImageRenderInfo <.ctor>b__0_0();
                    /*0x13ffd7c*/ void <.ctor>b__0_1(UnityEngine.UIElements.UIR.VectorImageRenderInfo vectorImageInfo);
                }
            }

            class VectorImageRenderInfo : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.VectorImageRenderInfo>
            {
                /*0x18*/ int useCount;
                /*0x20*/ UnityEngine.UIElements.UIR.GradientRemap firstGradientRemap;
                /*0x28*/ UnityEngine.UIElements.UIR.Alloc gradientSettingsAlloc;

                /*0x13ffd34*/ VectorImageRenderInfo();
                /*0x13ffd9c*/ void Reset();
            }

            class GradientRemapPool : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.GradientRemap>
            {
                /*0x13ffdac*/ GradientRemapPool();

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.GradientRemapPool.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_1;

                    static /*0x13fff34*/ <>c();
                    /*0x13fff98*/ <>c();
                    /*0x13fffa0*/ UnityEngine.UIElements.UIR.GradientRemap <.ctor>b__0_0();
                    /*0x1400040*/ void <.ctor>b__0_1(UnityEngine.UIElements.UIR.GradientRemap gradientRemap);
                }
            }

            class GradientRemap : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.GradientRemap>
            {
                /*0x18*/ int origIndex;
                /*0x1c*/ int destIndex;
                /*0x20*/ UnityEngine.RectInt location;
                /*0x30*/ UnityEngine.UIElements.UIR.GradientRemap next;
                /*0x38*/ UnityEngine.UIElements.TextureId atlas;

                /*0x13ffff8*/ GradientRemap();
                /*0x1400054*/ void Reset();
            }

            class VectorImageManager : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.VectorImageManager> instances;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerRegister;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerUnregister;
                /*0x10*/ UnityEngine.UIElements.AtlasBase m_Atlas;
                /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.UIR.VectorImageRenderInfo> m_Registered;
                /*0x20*/ UnityEngine.UIElements.UIR.VectorImageRenderInfoPool m_RenderInfoPool;
                /*0x28*/ UnityEngine.UIElements.UIR.GradientRemapPool m_GradientRemapPool;
                /*0x30*/ UnityEngine.UIElements.UIR.GradientSettingsAtlas m_GradientSettingsAtlas;
                /*0x38*/ bool m_LoggedExhaustedSettingsAtlas;
                /*0x39*/ bool <disposed>k__BackingField;

                static /*0x140098c*/ VectorImageManager();
                /*0x14000d0*/ VectorImageManager(UnityEngine.UIElements.AtlasBase atlas);
                /*0x14000bc*/ UnityEngine.Texture2D get_atlas();
                /*0x140028c*/ bool get_disposed();
                /*0x1400294*/ void set_disposed(bool value);
                /*0x14002a0*/ void Dispose();
                /*0x140030c*/ void Dispose(bool disposing);
                /*0x1400424*/ void Commit();
                /*0x1400454*/ UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context);
                /*0x1400558*/ UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context);
            }

            struct Transform3x4
            {
                /*0x10*/ UnityEngine.Vector4 v0;
                /*0x20*/ UnityEngine.Vector4 v1;
                /*0x30*/ UnityEngine.Vector4 v2;
            }

            class MeshHandle : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.MeshHandle>
            {
                /*0x18*/ UnityEngine.UIElements.UIR.Alloc allocVerts;
                /*0x30*/ UnityEngine.UIElements.UIR.Alloc allocIndices;
                /*0x48*/ uint triangleCount;
                /*0x50*/ UnityEngine.UIElements.UIR.Page allocPage;
                /*0x58*/ uint allocTime;
                /*0x5c*/ uint updateAllocID;

                /*0x1400a94*/ MeshHandle();
            }

            class UIRenderDevice : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.LinkedList<UnityEngine.UIElements.UIR.UIRenderDevice.DeviceToFree> m_DeviceFreeQueue;
                static /*0x8*/ int m_ActiveDeviceCount;
                static /*0xc*/ bool m_SubscribedToNotifications;
                static /*0xd*/ bool m_SynchronousFree;
                static /*0x10*/ int s_FontTexPropID;
                static /*0x14*/ int s_FontTexSDFScaleID;
                static /*0x18*/ int s_GradientSettingsTexID;
                static /*0x1c*/ int s_ShaderInfoTexID;
                static /*0x20*/ int s_TransformsPropID;
                static /*0x24*/ int s_ClipRectsPropID;
                static /*0x28*/ int s_ClipSpaceParamsID;
                static /*0x30*/ Unity.Profiling.ProfilerMarker s_MarkerAllocate;
                static /*0x38*/ Unity.Profiling.ProfilerMarker s_MarkerFree;
                static /*0x40*/ Unity.Profiling.ProfilerMarker s_MarkerAdvanceFrame;
                static /*0x48*/ Unity.Profiling.ProfilerMarker s_MarkerFence;
                static /*0x50*/ Unity.Profiling.ProfilerMarker s_MarkerBeforeDraw;
                static /*0x58*/ System.Nullable<bool> s_VertexTexturingIsAvailable;
                static /*0x5a*/ System.Nullable<bool> s_ShaderModelIs35;
                static /*0x60*/ UnityEngine.Texture2D s_DefaultShaderInfoTexFloat;
                static /*0x68*/ UnityEngine.Texture2D s_DefaultShaderInfoTexARGB8;
                /*0x10*/ bool m_MockDevice;
                /*0x18*/ nint m_DefaultStencilState;
                /*0x20*/ nint m_VertexDecl;
                /*0x28*/ UnityEngine.UIElements.UIR.Page m_FirstPage;
                /*0x30*/ uint m_NextPageVertexCount;
                /*0x34*/ uint m_LargeMeshVertexCount;
                /*0x38*/ float m_IndexToVertexCountRatio;
                /*0x40*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToFree>> m_DeferredFrees;
                /*0x48*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate>> m_Updates;
                /*0x50*/ uint[] m_Fences;
                /*0x58*/ UnityEngine.MaterialPropertyBlock m_StandardMatProps;
                /*0x60*/ uint m_FrameIndex;
                /*0x64*/ uint m_NextUpdateID;
                /*0x68*/ UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics m_DrawStats;
                /*0x90*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.MeshHandle> m_MeshHandles;
                /*0x98*/ UnityEngine.UIElements.UIR.DrawParams m_DrawParams;
                /*0xa0*/ UnityEngine.UIElements.UIR.TextureSlotManager m_TextureSlotManager;
                /*0xa8*/ uint <maxVerticesPerPage>k__BackingField;
                /*0xac*/ bool <breakBatches>k__BackingField;
                /*0xad*/ bool <disposed>k__BackingField;

                static /*0x1400af8*/ UIRenderDevice();
                static /*0x14015c0*/ UnityEngine.Texture2D get_defaultShaderInfoTexFloat();
                static /*0x1401954*/ UnityEngine.Texture2D get_defaultShaderInfoTexARGB8();
                static /*0x1401c20*/ bool get_vertexTexturingIsAvailable();
                static /*0x1401e04*/ bool get_shaderModelIs35();
                static /*0x1404784*/ UnityEngine.Vector4 GetClipSpaceParams();
                static Unity.Collections.NativeSlice<T> PtrToSlice<T>(void* p, int count);
                static /*0x1407a0c*/ void PrepareForGfxDeviceRecreate();
                static /*0x1407b94*/ void WrapUpGfxDeviceRecreate();
                static /*0x1407bf4*/ void FlushAllPendingDeviceDisposes();
                static /*0x14025fc*/ void ProcessDeviceFreeQueue();
                static /*0x1407c84*/ void OnEngineUpdateGlobal();
                static /*0x1407cd0*/ void OnFlushPendingResources();
                /*0x1400eb0*/ UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity);
                /*0x1400eb8*/ UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice);
                /*0x1400adc*/ uint get_maxVerticesPerPage();
                /*0x1400ae4*/ bool get_breakBatches();
                /*0x1400aec*/ void set_breakBatches(bool value);
                /*0x1401fe8*/ void InitVertexDeclaration();
                /*0x1402250*/ void CompleteCreation();
                /*0x14023f4*/ bool get_fullyCreated();
                /*0x1402404*/ bool get_disposed();
                /*0x140240c*/ void set_disposed(bool value);
                /*0x1402418*/ void Dispose();
                /*0x1402484*/ void Dispose(bool disposing);
                /*0x1402998*/ UnityEngine.UIElements.UIR.MeshHandle Allocate(uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, ref ushort indexOffset);
                /*0x140308c*/ void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, uint vertexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData);
                /*0x1403958*/ void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, ref ushort indexOffset);
                /*0x1403ae0*/ bool TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.Alloc va, ref UnityEngine.UIElements.UIR.Alloc ia, bool shortLived);
                /*0x1402a58*/ void Allocate(UnityEngine.UIElements.UIR.MeshHandle meshHandle, uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, bool shortLived);
                /*0x1403254*/ void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle mesh, uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, ref ushort indexOffset, ref UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices);
                /*0x1403f38*/ void Free(UnityEngine.UIElements.UIR.MeshHandle mesh);
                /*0x140484c*/ void OnFrameRenderingBegin();
                /*0x14052a4*/ void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand cmd, int textureSlot, UnityEngine.Material newMat, bool newMatDiffers, bool newFontDiffers, ref UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState st);
                /*0x14054c8*/ void ApplyBatchState(ref UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState st, bool allowMaterialChange);
                /*0x140564c*/ void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand head, UnityEngine.Material initialMat, UnityEngine.Material defaultMat, UnityEngine.Texture gradientSettings, UnityEngine.Texture shaderInfo, float pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, UnityEngine.MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref System.Exception immediateException);
                /*0x1407770*/ void UpdateFenceValue();
                /*0x140696c*/ void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, UnityEngine.UIElements.UIR.Page curPage);
                void DrawRanges<I, T>(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges);
                /*0x140783c*/ void WaitOnCpuFence(uint fence);
                /*0x14048f0*/ void AdvanceFrame();
                /*0x14078c4*/ void PruneUnusedPages();
                /*0x1407c6c*/ UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics GatherDrawStatistics();

                struct AllocToUpdate
                {
                    /*0x10*/ uint id;
                    /*0x14*/ uint allocTime;
                    /*0x18*/ UnityEngine.UIElements.UIR.MeshHandle meshHandle;
                    /*0x20*/ UnityEngine.UIElements.UIR.Alloc permAllocVerts;
                    /*0x38*/ UnityEngine.UIElements.UIR.Alloc permAllocIndices;
                    /*0x50*/ UnityEngine.UIElements.UIR.Page permPage;
                    /*0x58*/ bool copyBackIndices;
                }

                struct AllocToFree
                {
                    /*0x10*/ UnityEngine.UIElements.UIR.Alloc alloc;
                    /*0x28*/ UnityEngine.UIElements.UIR.Page page;
                    /*0x30*/ bool vertices;
                }

                struct DeviceToFree
                {
                    /*0x10*/ uint handle;
                    /*0x18*/ UnityEngine.UIElements.UIR.Page page;

                    /*0x14025d0*/ void Dispose();
                }

                struct EvaluationState
                {
                    /*0x10*/ UnityEngine.MaterialPropertyBlock stateMatProps;
                    /*0x18*/ UnityEngine.Material defaultMat;
                    /*0x20*/ UnityEngine.UIElements.UIR.State curState;
                    /*0x40*/ UnityEngine.UIElements.UIR.Page curPage;
                    /*0x48*/ bool mustApplyMaterial;
                    /*0x49*/ bool mustApplyCommonBlock;
                    /*0x4a*/ bool mustApplyStateBlock;
                    /*0x4b*/ bool mustApplyStencil;
                }

                struct DrawStatistics
                {
                    /*0x10*/ int currentFrameIndex;
                    /*0x14*/ uint totalIndices;
                    /*0x18*/ uint commandCount;
                    /*0x1c*/ uint drawCommandCount;
                    /*0x20*/ uint materialSetCount;
                    /*0x24*/ uint drawRangeCount;
                    /*0x28*/ uint drawRangeCallCount;
                    /*0x2c*/ uint immediateDraws;
                    /*0x30*/ uint stencilRefChanges;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.UIRenderDevice.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.MeshHandle> <>9__53_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.MeshHandle> <>9__53_1;

                    static /*0x1407d2c*/ <>c();
                    /*0x1407d90*/ <>c();
                    /*0x1407d98*/ UnityEngine.UIElements.UIR.MeshHandle <.ctor>b__53_0();
                    /*0x1407df0*/ void <.ctor>b__53_1(UnityEngine.UIElements.UIR.MeshHandle mh);
                }
            }

            struct Alloc
            {
                /*0x10*/ uint start;
                /*0x14*/ uint size;
                /*0x18*/ object handle;
                /*0x20*/ bool shortLived;
            }

            class BestFitAllocator
            {
                /*0x10*/ uint <totalSize>k__BackingField;
                /*0x18*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block m_FirstBlock;
                /*0x20*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block m_FirstAvailableBlock;
                /*0x28*/ UnityEngine.UIElements.UIR.BestFitAllocator.BlockPool m_BlockPool;
                /*0x30*/ uint m_HighWatermark;

                /*0x13fee84*/ BestFitAllocator(uint size);
                /*0x1407ee4*/ uint get_totalSize();
                /*0x13ff398*/ uint get_highWatermark();
                /*0x13fec4c*/ UnityEngine.UIElements.UIR.Alloc Allocate(uint size);
                /*0x13ff13c*/ void Free(UnityEngine.UIElements.UIR.Alloc alloc);
                /*0x1408024*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block CoalesceBlockWithPrevious(UnityEngine.UIElements.UIR.BestFitAllocator.Block block);
                /*0x1407eec*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block BestFitFindAvailableBlock(uint size);
                /*0x1407f38*/ void SplitBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block, uint size);

                class BlockPool : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.BestFitAllocator.Block>
                {
                    static /*0x140812c*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block CreateBlock();
                    static /*0x14081cc*/ void ResetBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block);
                    /*0x1407df4*/ BlockPool();
                }

                class Block : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.BestFitAllocator.Block>
                {
                    /*0x18*/ uint start;
                    /*0x1c*/ uint end;
                    /*0x20*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block prev;
                    /*0x28*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block next;
                    /*0x30*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block prevAvailable;
                    /*0x38*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block nextAvailable;
                    /*0x40*/ bool allocated;

                    /*0x1408184*/ Block();
                    /*0x1407f2c*/ uint get_size();
                }
            }

            class GPUBufferAllocator
            {
                /*0x10*/ UnityEngine.UIElements.UIR.BestFitAllocator m_Low;
                /*0x18*/ UnityEngine.UIElements.UIR.BestFitAllocator m_High;

                /*0x14081d0*/ GPUBufferAllocator(uint maxSize);
                /*0x1403be4*/ UnityEngine.UIElements.UIR.Alloc Allocate(uint size, bool shortLived);
                /*0x1403d20*/ void Free(UnityEngine.UIElements.UIR.Alloc alloc);
                /*0x140829c*/ bool get_isEmpty();
                /*0x1408264*/ bool HighLowCollide();
            }

            class Page : System.IDisposable
            {
                /*0x10*/ bool <disposed>k__BackingField;
                /*0x18*/ UnityEngine.UIElements.UIR.Page.DataSet<UnityEngine.UIElements.Vertex> vertices;
                /*0x20*/ UnityEngine.UIElements.UIR.Page.DataSet<ushort> indices;
                /*0x28*/ UnityEngine.UIElements.UIR.Page next;
                /*0x30*/ int framesEmpty;

                /*0x1403da4*/ Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage);
                /*0x14082d8*/ bool get_disposed();
                /*0x14082e0*/ void set_disposed(bool value);
                /*0x14079a0*/ void Dispose();
                /*0x14082ec*/ void Dispose(bool disposing);
                /*0x1403ef0*/ bool get_isEmpty();

                class DataSet<T> : System.IDisposable
                {
                    /*0x0*/ bool <disposed>k__BackingField;
                    /*0x0*/ UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> gpuData;
                    /*0x0*/ Unity.Collections.NativeArray<T> cpuData;
                    /*0x0*/ Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> updateRanges;
                    /*0x0*/ UnityEngine.UIElements.UIR.GPUBufferAllocator allocator;
                    /*0x0*/ uint m_UpdateRangePoolSize;
                    /*0x0*/ uint m_ElemStride;
                    /*0x0*/ uint m_UpdateRangeMin;
                    /*0x0*/ uint m_UpdateRangeMax;
                    /*0x0*/ uint m_UpdateRangesEnqueued;
                    /*0x0*/ uint m_UpdateRangesBatchStart;
                    /*0x0*/ bool m_UpdateRangesSaturated;

                    DataSet(UnityEngine.UIElements.UIR.Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer);
                    bool get_disposed();
                    void set_disposed(bool value);
                    void Dispose();
                    void Dispose(bool disposing);
                    void RegisterUpdate(uint start, uint size);
                    bool HasMappedBufferRange();
                    void SendUpdates();
                    void SendFullRange();
                    void SendPartialRanges();
                    void ResetUpdateState();
                }
            }

            enum VertexFlags
            {
                IsSolid = 0,
                IsText = 1,
                IsTextured = 2,
                IsDynamic = 3,
                IsSvgGradients = 4,
                LastType = 10,
                IsGraphViewEdge = 10,
            }

            struct State
            {
                /*0x10*/ UnityEngine.Material material;
                /*0x18*/ UnityEngine.Texture font;
                /*0x20*/ float fontTexSDFScale;
                /*0x24*/ UnityEngine.UIElements.TextureId texture;
                /*0x28*/ int stencilRef;
            }

            enum CommandType
            {
                Draw = 0,
                ImmediateCull = 1,
                Immediate = 2,
                PushView = 3,
                PopView = 4,
                PushScissor = 5,
                PopScissor = 6,
                PushRenderTexture = 7,
                PopRenderTexture = 8,
                BlitToPreviousRT = 9,
                PushDefaultMaterial = 10,
                PopDefaultMaterial = 11,
            }

            class DrawParams
            {
                static /*0x0*/ UnityEngine.Rect k_UnlimitedRect;
                static /*0x10*/ UnityEngine.Rect k_FullNormalizedRect;
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.Matrix4x4> view;
                /*0x18*/ System.Collections.Generic.Stack<UnityEngine.Rect> scissor;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.RenderTexture> renderTexture;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Material> defaultMaterial;

                static /*0x140837c*/ DrawParams();
                /*0x1401468*/ DrawParams();
                /*0x14067a0*/ void Reset();
            }

            class RenderChainCommand : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.RenderChainCommand>
            {
                static /*0x0*/ int k_ID_MainTex;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_ImmediateOverheadMarker;
                /*0x18*/ UnityEngine.UIElements.VisualElement owner;
                /*0x20*/ UnityEngine.UIElements.UIR.RenderChainCommand prev;
                /*0x28*/ UnityEngine.UIElements.UIR.RenderChainCommand next;
                /*0x30*/ bool closing;
                /*0x34*/ UnityEngine.UIElements.UIR.CommandType type;
                /*0x38*/ UnityEngine.UIElements.UIR.State state;
                /*0x58*/ UnityEngine.UIElements.UIR.MeshHandle mesh;
                /*0x60*/ int indexOffset;
                /*0x64*/ int indexCount;
                /*0x68*/ System.Action callback;

                static /*0x1408bc0*/ RenderChainCommand();
                static /*0x1408850*/ UnityEngine.Rect CombineScissorRects(UnityEngine.Rect r0, UnityEngine.Rect r1);
                static /*0x140844c*/ UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect rect, float pixelsPerPoint);
                /*0x1408b78*/ RenderChainCommand();
                /*0x1408428*/ void Reset();
                /*0x1406bb4*/ void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams drawParams, float pixelsPerPoint, ref System.Exception immediateException);
                /*0x1408a08*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture destination, float depth);
            }

            namespace Implementation
            {
                enum ClipMethod
                {
                    Undetermined = 0,
                    NotClipped = 1,
                    Scissor = 2,
                    ShaderDiscard = 3,
                    Stencil = 4,
                }

                class RenderEvents
                {
                    static /*0x0*/ float VisibilityTreshold;

                    static /*0x140bd34*/ RenderEvents();
                    static /*0x1408c68*/ void ProcessOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x1409230*/ void ProcessOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x1409698*/ void ProcessOnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x14098ec*/ void ProcessOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x1409d18*/ void ProcessOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x140a23c*/ void ProcessRegenText(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter painter, UnityEngine.UIElements.UIR.UIRenderDevice device, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x140a298*/ UnityEngine.Matrix4x4 GetTransformIDTransformInfo(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140a3e8*/ UnityEngine.Vector4 GetClipRectIDClipInfo(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140a5a4*/ uint DepthFirstOnChildAdded(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, int index, bool resetState);
                    static /*0x140b4f8*/ uint DepthFirstOnChildRemoving(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x1408d54*/ void DepthFirstOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UnityEngine.UIElements.UIR.UIRenderDevice device, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x1409314*/ void DepthFirstOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, float parentCompositeOpacity, UnityEngine.UIElements.VisualElement ve, uint dirtyID, bool hierarchical, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats, bool isDoingFullVertexRegeneration);
                    static /*0x1409720*/ void OnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x14099ac*/ void DepthFirstOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, uint dirtyID, UnityEngine.UIElements.UIR.UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x1409edc*/ void DepthFirstOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x140ba60*/ bool UpdateTextCoreSettings(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x1409e1c*/ bool IsElementHierarchyHidden(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140ac00*/ UnityEngine.UIElements.VisualElement GetLastDeepestChild(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140b954*/ UnityEngine.UIElements.UIR.Implementation.ClipMethod DetermineSelfClipMethod(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x140aacc*/ bool UpdateLocalFlipsWinding(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140bcdc*/ void UpdateWorldFlipsWinding(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140ac80*/ bool NeedsTransformID(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140acbc*/ bool NeedsColorID(UnityEngine.UIElements.VisualElement ve);
                    static /*0x140acdc*/ bool InitColorIDs(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x140b120*/ void SetColorValues(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                }

                class UIRStylePainter : UnityEngine.UIElements.IStylePainter, System.IDisposable
                {
                    /*0x10*/ UnityEngine.UIElements.UIR.RenderChain m_Owner;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> m_Entries;
                    /*0x20*/ UnityEngine.UIElements.AtlasBase m_Atlas;
                    /*0x28*/ UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager;
                    /*0x30*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry m_CurrentEntry;
                    /*0x90*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo m_ClosingInfo;
                    /*0xc8*/ int m_MaskDepth;
                    /*0xcc*/ int m_StencilRef;
                    /*0xd0*/ UnityEngine.UIElements.UIR.BMPAlloc m_ClipRectID;
                    /*0xd8*/ int m_SVGBackgroundEntryIndex;
                    /*0xe0*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<UnityEngine.UIElements.Vertex> m_VertsPool;
                    /*0x108*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<ushort> m_IndicesPool;
                    /*0x130*/ System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool;
                    /*0x138*/ int m_NextMeshWriteDataPoolItem;
                    /*0x140*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate;
                    /*0x148*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate;
                    /*0x150*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate;
                    /*0x158*/ UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField;
                    /*0x160*/ UnityEngine.UIElements.VisualElement <currentElement>k__BackingField;
                    /*0x168*/ int <totalVertices>k__BackingField;
                    /*0x16c*/ int <totalIndices>k__BackingField;
                    /*0x170*/ bool <disposed>k__BackingField;

                    /*0x140c758*/ UIRStylePainter(UnityEngine.UIElements.UIR.RenderChain renderChain);
                    /*0x140bd84*/ UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData();
                    /*0x140bea4*/ UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    /*0x140bf60*/ UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    /*0x140c444*/ UnityEngine.UIElements.MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    /*0x140cac0*/ UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext();
                    /*0x140cac8*/ UnityEngine.UIElements.VisualElement get_currentElement();
                    /*0x140cad0*/ void set_currentElement(UnityEngine.UIElements.VisualElement value);
                    /*0x140cad8*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries();
                    /*0x140cae0*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo get_closingInfo();
                    /*0x140cafc*/ int get_totalVertices();
                    /*0x140cb04*/ void set_totalVertices(int value);
                    /*0x140cb0c*/ int get_totalIndices();
                    /*0x140cb14*/ void set_totalIndices(int value);
                    /*0x140cb1c*/ bool get_disposed();
                    /*0x140cb24*/ void set_disposed(bool value);
                    /*0x140cb30*/ void Dispose();
                    /*0x140cb94*/ void Dispose(bool disposing);
                    /*0x140cc18*/ void Begin(UnityEngine.UIElements.VisualElement ve);
                    /*0x140d128*/ void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd);
                    /*0x140d19c*/ void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<ushort> indices, int indexOffset);
                    /*0x140c454*/ UnityEngine.UIElements.MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, UnityEngine.UIElements.TextureId texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags);
                    /*0x140bf74*/ UnityEngine.UIElements.MeshWriteData DrawMesh(int vertexCount, int indexCount, UnityEngine.Texture texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags);
                    /*0x140d238*/ void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                    /*0x140d370*/ void DrawTextNative(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                    /*0x140d7a8*/ void DrawTextCore(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                    /*0x140ddd0*/ void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x140eb28*/ void DrawBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams);
                    /*0x140ec08*/ void DrawImmediate(System.Action callback, bool cullingEnabled);
                    /*0x140ed84*/ UnityEngine.UIElements.VisualElement get_visualElement();
                    /*0x140ed8c*/ void DrawVisualElementBackground();
                    /*0x140fbbc*/ void DrawVisualElementBorder();
                    /*0x1410538*/ void ApplyVisualElementClipping();
                    /*0x141151c*/ ushort[] AdjustSpriteWinding(UnityEngine.Vector2[] vertices, ushort[] indices);
                    /*0x140e4d0*/ void DrawSprite(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x140e06c*/ void DrawVectorImage(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x141183c*/ void Reset();
                    /*0x1411920*/ void ValidateMeshWriteData();
                    /*0x1410af8*/ void GenerateStencilClipEntryForRoundedRectBackground();
                    /*0x1410784*/ void GenerateStencilClipEntryForSVGBackground();

                    struct Entry
                    {
                        /*0x10*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices;
                        /*0x20*/ Unity.Collections.NativeSlice<ushort> indices;
                        /*0x30*/ UnityEngine.Material material;
                        /*0x38*/ UnityEngine.Texture custom;
                        /*0x40*/ UnityEngine.Texture font;
                        /*0x48*/ float fontTexSDFScale;
                        /*0x4c*/ UnityEngine.UIElements.TextureId texture;
                        /*0x50*/ UnityEngine.UIElements.UIR.RenderChainCommand customCommand;
                        /*0x58*/ UnityEngine.UIElements.UIR.BMPAlloc clipRectID;
                        /*0x60*/ UnityEngine.UIElements.UIR.VertexFlags addFlags;
                        /*0x64*/ bool uvIsDisplacement;
                        /*0x65*/ bool isTextEntry;
                        /*0x66*/ bool isClipRegisterEntry;
                        /*0x68*/ int stencilRef;
                        /*0x6c*/ int maskDepth;
                    }

                    struct ClosingInfo
                    {
                        /*0x10*/ bool needsClosing;
                        /*0x11*/ bool popViewMatrix;
                        /*0x12*/ bool popScissorClip;
                        /*0x13*/ bool blitAndPopRenderTexture;
                        /*0x14*/ bool PopDefaultMaterial;
                        /*0x18*/ UnityEngine.UIElements.UIR.RenderChainCommand clipUnregisterDrawCommand;
                        /*0x20*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> clipperRegisterVertices;
                        /*0x30*/ Unity.Collections.NativeSlice<ushort> clipperRegisterIndices;
                        /*0x40*/ int clipperRegisterIndexOffset;
                        /*0x44*/ int maskStencilRef;
                    }

                    struct TempDataAlloc<T> : System.IDisposable
                    {
                        /*0x0*/ int maxPoolElemCount;
                        /*0x0*/ Unity.Collections.NativeArray<T> pool;
                        /*0x0*/ System.Collections.Generic.List<Unity.Collections.NativeArray<T>> excess;
                        /*0x0*/ uint takenFromPool;

                        TempDataAlloc(int maxPoolElems);
                        void Dispose();
                        Unity.Collections.NativeSlice<T> Alloc(uint count);
                        void SessionDone();
                    }
                }

                class UIRTextUpdatePainter : UnityEngine.UIElements.IStylePainter, System.IDisposable
                {
                    /*0x10*/ UnityEngine.UIElements.VisualElement m_CurrentElement;
                    /*0x18*/ int m_TextEntryIndex;
                    /*0x20*/ Unity.Collections.NativeArray<UnityEngine.UIElements.Vertex> m_DudVerts;
                    /*0x30*/ Unity.Collections.NativeArray<ushort> m_DudIndices;
                    /*0x40*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_MeshDataVerts;
                    /*0x50*/ UnityEngine.Color32 m_XFormClipPages;
                    /*0x54*/ UnityEngine.Color32 m_IDs;
                    /*0x58*/ UnityEngine.Color32 m_Flags;
                    /*0x5c*/ UnityEngine.Color32 m_OpacityColorPages;
                    /*0x60*/ UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField;

                    /*0x12f7c70*/ UIRTextUpdatePainter();
                    /*0x12f7c68*/ UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext();
                    /*0x12f7ce0*/ void Begin(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device);
                    /*0x12f7f24*/ void End();
                    /*0x12f7fb0*/ void Dispose();
                    /*0x12f8074*/ void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x12f8078*/ void DrawImmediate(System.Action callback, bool cullingEnabled);
                    /*0x12f807c*/ void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                }

                class CommandGenerator
                {
                    static /*0x0*/ Unity.Profiling.ProfilerMarker k_ConvertEntriesToCommandsMarker;
                    static /*0x8*/ Unity.Profiling.ProfilerMarker k_NudgeVerticesMarker;
                    static /*0x10*/ UnityEngine.Material s_blitMaterial_LinearToGamma;
                    static /*0x18*/ UnityEngine.Material s_blitMaterial_GammaToLinear;
                    static /*0x20*/ UnityEngine.Material s_blitMaterial_NoChange;
                    static /*0x28*/ UnityEngine.Shader s_blitShader;

                    static /*0x12fb840*/ CommandGenerator();
                    static /*0x12f83e4*/ void GetVerticesTransformInfo(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.Matrix4x4 transform);
                    static /*0x12f852c*/ bool IsParentOrAncestorOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement child);
                    static /*0x12f85a8*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo PaintElement(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x12faf10*/ UnityEngine.Material CreateBlitShader(float colorConversion);
                    static /*0x12fab88*/ UnityEngine.Material GetBlitMaterial(UnityEngine.UIElements.VisualElement.RenderTargetMode mode);
                    static /*0x12fb118*/ void ClosePaintElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo closingInfo, UnityEngine.UIElements.UIR.RenderChain renderChain, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x12f9dd8*/ void UpdateOrAllocate(ref UnityEngine.UIElements.UIR.MeshHandle data, int vertexCount, int indexCount, UnityEngine.UIElements.UIR.UIRenderDevice device, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> verts, ref Unity.Collections.NativeSlice<ushort> indices, ref ushort indexOffset, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x12fa304*/ void CopyTransformVertsPos(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, bool isText, float textureId);
                    static /*0x12fa094*/ void CopyTransformVertsPosAndVec(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, bool isText, float textureId);
                    static /*0x12fa618*/ void CopyTriangleIndicesFlipWindingOrder(Unity.Collections.NativeSlice<ushort> source, Unity.Collections.NativeSlice<ushort> target, int indexOffset);
                    static /*0x12fa54c*/ void CopyTriangleIndices(Unity.Collections.NativeSlice<ushort> source, Unity.Collections.NativeSlice<ushort> target, int indexOffset);
                    static /*0x12fb2a8*/ bool NudgeVerticesToNewSpace(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device);
                    static /*0x12fb560*/ void DoNudgeVertices(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.MeshHandle mesh, ref UnityEngine.Matrix4x4 nudgeTransform);
                    static /*0x12fa7bc*/ UnityEngine.UIElements.UIR.RenderChainCommand InjectMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdPrev, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, int indexCount, int indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, int stencilRef);
                    static /*0x12fae28*/ UnityEngine.UIElements.UIR.RenderChainCommand InjectClosingMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdPrev, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, int indexCount, int indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, int stencilRef);
                    static /*0x12f9ed4*/ void FindCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x12fa934*/ void FindClosingCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x12fa89c*/ void InjectCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x12faaa0*/ void InjectClosingCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x12f9aa0*/ void ResetCommands(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                }
            }
        }

        namespace Experimental
        {
            class Easing
            {
                static /*0x12fb8f4*/ float Linear(float t);
                static /*0x12fb8f8*/ float InSine(float t);
                static /*0x12fb924*/ float OutSine(float t);
                static /*0x12fb934*/ float InOutSine(float t);
                static /*0x12fb968*/ float InQuad(float t);
                static /*0x12fb970*/ float OutQuad(float t);
                static /*0x12fb980*/ float InOutQuad(float t);
                static /*0x12fb9c0*/ float InCubic(float t);
                static /*0x12fb9d0*/ float OutCubic(float t);
                static /*0x12fba2c*/ float InOutCubic(float t);
                static /*0x12fb9c8*/ float InPower(float t, int power);
                static /*0x12fb9f4*/ float OutPower(float t, int power);
                static /*0x12fba74*/ float InOutPower(float t, int power);
                static /*0x12fbadc*/ float InBounce(float t);
                static /*0x12fbb00*/ float OutBounce(float t);
                static /*0x12fbbb8*/ float InOutBounce(float t);
                static /*0x12fbc0c*/ float InElastic(float t);
                static /*0x12fbc84*/ float OutElastic(float t);
                static /*0x12fbcfc*/ float InOutElastic(float t);
                static /*0x12fbe00*/ float InBack(float t);
                static /*0x12fbe24*/ float OutBack(float t);
                static /*0x12fbe54*/ float InOutBack(float t);
                static /*0x12fbed0*/ float InCirc(float t);
                static /*0x12fbef0*/ float OutCirc(float t);
                static /*0x12fbf0c*/ float InOutCirc(float t);
            }

            struct StyleValues
            {
                /*0x10*/ UnityEngine.UIElements.StyleValueCollection m_StyleValues;

                /*0x12fbf54*/ void set_top(float value);
                /*0x12fbfe4*/ void set_left(float value);
                /*0x12fbff0*/ void set_width(float value);
                /*0x12fbffc*/ void set_height(float value);
                /*0x12fc008*/ void set_right(float value);
                /*0x12fc014*/ void set_bottom(float value);
                /*0x12fc020*/ void set_color(UnityEngine.Color value);
                /*0x12fc0ac*/ void set_backgroundColor(UnityEngine.Color value);
                /*0x12fc0b4*/ void set_unityBackgroundImageTintColor(UnityEngine.Color value);
                /*0x12fc0c0*/ void set_borderColor(UnityEngine.Color value);
                /*0x12fc0cc*/ void set_marginLeft(float value);
                /*0x12fc0d8*/ void set_marginTop(float value);
                /*0x12fc0e4*/ void set_marginRight(float value);
                /*0x12fc0f0*/ void set_marginBottom(float value);
                /*0x12fc0fc*/ void set_paddingLeft(float value);
                /*0x12fc108*/ float get_paddingTop();
                /*0x12fc1b0*/ void set_paddingTop(float value);
                /*0x12fc1bc*/ void set_paddingRight(float value);
                /*0x12fc1c8*/ void set_paddingBottom(float value);
                /*0x12fc1d4*/ void set_borderLeftWidth(float value);
                /*0x12fc1e0*/ void set_borderRightWidth(float value);
                /*0x12fc1ec*/ void set_borderTopWidth(float value);
                /*0x12fc1f8*/ void set_borderBottomWidth(float value);
                /*0x12fc204*/ void set_borderTopLeftRadius(float value);
                /*0x12fc210*/ void set_borderTopRightRadius(float value);
                /*0x12fc21c*/ void set_borderBottomLeftRadius(float value);
                /*0x12fc228*/ void set_borderBottomRightRadius(float value);
                /*0x12fc234*/ void set_opacity(float value);
                /*0x12fc240*/ void set_flexGrow(float value);
                /*0x12fc24c*/ void set_flexShrink(float value);
                /*0x12fbf60*/ void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float value);
                /*0x12fc028*/ void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color value);
                /*0x12fc144*/ UnityEngine.UIElements.StyleValueCollection Values();
            }

            interface ITransitionAnimations
            {
                UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues to, int durationMs);
            }

            class Lerp
            {
                static /*0x12fc258*/ float Interpolate(float start, float end, float ratio);
                static /*0x12fc268*/ UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, float ratio);
                static /*0x12fc2a0*/ UnityEngine.UIElements.Experimental.StyleValues Interpolate(UnityEngine.UIElements.Experimental.StyleValues start, UnityEngine.UIElements.Experimental.StyleValues end, float ratio);
            }

            interface IValueAnimationUpdate
            {
                void Tick(long currentTimeMs);
            }

            class ValueAnimation<T> : UnityEngine.UIElements.Experimental.IValueAnimationUpdate
            {
                static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.Experimental.ValueAnimation<T>> sObjectPool;
                /*0x0*/ long m_StartTimeMs;
                /*0x0*/ int m_DurationMs;
                /*0x0*/ System.Func<float, float> <easingCurve>k__BackingField;
                /*0x0*/ bool <isRunning>k__BackingField;
                /*0x0*/ System.Action <onAnimationCompleted>k__BackingField;
                /*0x0*/ bool <autoRecycle>k__BackingField;
                /*0x0*/ bool <recycled>k__BackingField;
                /*0x0*/ UnityEngine.UIElements.VisualElement <owner>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.UIElements.VisualElement, T> <valueUpdated>k__BackingField;
                /*0x0*/ System.Func<UnityEngine.UIElements.VisualElement, T> <initialValue>k__BackingField;
                /*0x0*/ System.Func<T, T, float, T> <interpolator>k__BackingField;
                /*0x0*/ T _from;
                /*0x0*/ bool fromValueSet;
                /*0x0*/ T <to>k__BackingField;

                static ValueAnimation();
                static UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement e, System.Func<T, T, float, T> interpolator);
                ValueAnimation();
                int get_durationMs();
                void set_durationMs(int value);
                System.Func<float, float> get_easingCurve();
                void set_easingCurve(System.Func<float, float> value);
                bool get_isRunning();
                void set_isRunning(bool value);
                System.Action get_onAnimationCompleted();
                void set_onAnimationCompleted(System.Action value);
                bool get_autoRecycle();
                void set_autoRecycle(bool value);
                bool get_recycled();
                void set_recycled(bool value);
                UnityEngine.UIElements.VisualElement get_owner();
                void set_owner(UnityEngine.UIElements.VisualElement value);
                System.Action<UnityEngine.UIElements.VisualElement, T> get_valueUpdated();
                void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement, T> value);
                System.Func<UnityEngine.UIElements.VisualElement, T> get_initialValue();
                void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement, T> value);
                System.Func<T, T, float, T> get_interpolator();
                void set_interpolator(System.Func<T, T, float, T> value);
                T get_from();
                void set_from(T value);
                T get_to();
                void set_to(T value);
                void Start();
                void Stop();
                void Recycle();
                void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs);
                void SetDefaultValues();
                void Unregister();
                void Register();
                void SetOwner(UnityEngine.UIElements.VisualElement e);
                void CheckNotRecycled();
                UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive();
            }
        }

        namespace StyleSheets
        {
            class HierarchyTraversal
            {
                /*0x12fc770*/ HierarchyTraversal();
                /*0x12fc690*/ void Traverse(UnityEngine.UIElements.VisualElement element);
                void TraverseRecursive(UnityEngine.UIElements.VisualElement element, int depth);
                /*0x12fc6a0*/ void Recurse(UnityEngine.UIElements.VisualElement element, int depth);
            }

            class ShorthandApplicator
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDelayList;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDurationList;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> s_TransitionPropertyList;
                static /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList;

                static /*0x12fef84*/ ShorthandApplicator();
                static /*0x12fc778*/ bool CompileFlexShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref float grow, ref float shrink, ref UnityEngine.UIElements.Length basis);
                static /*0x12fcc74*/ void CompileBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.Length top, ref UnityEngine.UIElements.Length right, ref UnityEngine.UIElements.Length bottom, ref UnityEngine.UIElements.Length left);
                static /*0x12fcdbc*/ void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.Length top, ref UnityEngine.UIElements.Length right, ref UnityEngine.UIElements.Length bottom, ref UnityEngine.UIElements.Length left);
                static /*0x12fcf18*/ void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref float top, ref float right, ref float bottom, ref float left);
                static /*0x12fcfd0*/ void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.Color top, ref UnityEngine.Color right, ref UnityEngine.Color bottom, ref UnityEngine.Color left);
                static /*0x12fd23c*/ void CompileTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.Color outlineColor, ref float outlineWidth);
                static /*0x12fd2dc*/ void CompileTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> outDelay, ref System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> outDuration, ref System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> outProperty, ref System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> outTimingFunction);
                static /*0x12fe7fc*/ void ApplyBorderColor(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12fe8f0*/ void ApplyBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12fe9e0*/ void ApplyBorderWidth(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12feacc*/ void ApplyFlex(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12feb9c*/ void ApplyMargin(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12fec8c*/ void ApplyPadding(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12fed7c*/ void ApplyTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x12feecc*/ void ApplyUnityTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
            }

            class StyleSheetExtensions
            {
                static /*0x12ff0d4*/ string ReadAsString(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle);
                static /*0x12ff644*/ bool IsVarFunction(UnityEngine.UIElements.StyleValueHandle handle);
            }

            struct StylePropertyValue
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ UnityEngine.UIElements.StyleValueHandle handle;
            }

            struct ImageSource
            {
                /*0x10*/ UnityEngine.Texture2D texture;
                /*0x18*/ UnityEngine.Sprite sprite;
                /*0x20*/ UnityEngine.UIElements.VectorImage vectorImage;
                /*0x28*/ UnityEngine.RenderTexture renderTexture;

                /*0x12ff678*/ bool IsNull();
            }

            class StylePropertyReader
            {
                static /*0x0*/ UnityEngine.UIElements.StyleSheets.StylePropertyReader.GetCursorIdFunction getCursorIdFunc;
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values;
                /*0x18*/ System.Collections.Generic.List<int> m_ValueCount;
                /*0x20*/ UnityEngine.UIElements.StyleVariableResolver m_Resolver;
                /*0x28*/ UnityEngine.UIElements.StyleSheet m_Sheet;
                /*0x30*/ UnityEngine.UIElements.StyleProperty[] m_Properties;
                /*0x38*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] m_PropertyIds;
                /*0x40*/ int m_CurrentValueIndex;
                /*0x44*/ int m_CurrentPropertyIndex;
                /*0x48*/ UnityEngine.UIElements.StyleProperty <property>k__BackingField;
                /*0x50*/ UnityEngine.UIElements.StyleSheets.StylePropertyId <propertyId>k__BackingField;
                /*0x54*/ int <valueCount>k__BackingField;
                /*0x58*/ float <dpiScaling>k__BackingField;

                static /*0x13004dc*/ UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue zVvalue);
                static /*0x13029c4*/ UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue value, ref bool isVertical, ref bool isHorizontal);
                static /*0x1300120*/ UnityEngine.UIElements.Translate ReadTranslate(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3);
                static /*0x1300990*/ UnityEngine.UIElements.Scale ReadScale(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3);
                static /*0x13007c4*/ UnityEngine.UIElements.Rotate ReadRotate(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3, UnityEngine.UIElements.StyleSheets.StylePropertyValue val4);
                static /*0x1302b1c*/ int ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue value);
                static /*0x1302be0*/ UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue value);
                static /*0x13018d8*/ bool TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue propertyValue, float dpiScaling, ref UnityEngine.UIElements.StyleSheets.ImageSource source);
                /*0x1302cfc*/ StylePropertyReader();
                /*0x12ff760*/ UnityEngine.UIElements.StyleProperty get_property();
                /*0x12ff768*/ void set_property(UnityEngine.UIElements.StyleProperty value);
                /*0x12ff770*/ UnityEngine.UIElements.StyleSheets.StylePropertyId get_propertyId();
                /*0x12ff778*/ void set_propertyId(UnityEngine.UIElements.StyleSheets.StylePropertyId value);
                /*0x12ff780*/ int get_valueCount();
                /*0x12ff788*/ void set_valueCount(int value);
                /*0x12ff790*/ float get_dpiScaling();
                /*0x12ff798*/ void set_dpiScaling(float value);
                /*0x12ff7a0*/ void SetContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleComplexSelector selector, UnityEngine.UIElements.StyleVariableContext varContext, float dpiScaling);
                /*0x12ffe48*/ void SetInlineContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleProperty[] properties, UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds, float dpiScaling);
                /*0x12ffe58*/ UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty();
                /*0x12fff34*/ UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(int index);
                /*0x12fca98*/ UnityEngine.UIElements.StyleValueType GetValueType(int index);
                /*0x12fc960*/ bool IsValueType(int index, UnityEngine.UIElements.StyleValueType type);
                /*0x12fc9f4*/ bool IsKeyword(int index, UnityEngine.UIElements.StyleValueKeyword keyword);
                /*0x12fda04*/ string ReadAsString(int index);
                /*0x12fcb18*/ UnityEngine.UIElements.Length ReadLength(int index);
                /*0x12fd96c*/ UnityEngine.UIElements.TimeValue ReadTimeValue(int index);
                /*0x12ffff0*/ UnityEngine.UIElements.Translate ReadTranslate(int index);
                /*0x13003a8*/ UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(int index);
                /*0x13006a0*/ UnityEngine.UIElements.Rotate ReadRotate(int index);
                /*0x1300890*/ UnityEngine.UIElements.Scale ReadScale(int index);
                /*0x12fcc0c*/ float ReadFloat(int index);
                /*0x1300b8c*/ int ReadInt(int index);
                /*0x12fd138*/ UnityEngine.Color ReadColor(int index);
                /*0x1300d04*/ int ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, int index);
                /*0x1300dfc*/ UnityEngine.UIElements.FontDefinition ReadFontDefinition(int index);
                /*0x1301324*/ UnityEngine.Font ReadFont(int index);
                /*0x1301668*/ UnityEngine.UIElements.Background ReadBackground(int index);
                /*0x1301f8c*/ UnityEngine.UIElements.Cursor ReadCursor(int index);
                /*0x1302238*/ UnityEngine.UIElements.TextShadow ReadTextShadow(int index);
                /*0x13024ac*/ void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, int index);
                /*0x1302698*/ void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, int index);
                /*0x130282c*/ void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, int index);
                /*0x12ffa14*/ void LoadProperties();
                /*0x12ffe84*/ void SetCurrentProperty();

                class GetCursorIdFunction : System.MulticastDelegate
                {
                    /*0x1302dec*/ GetCursorIdFunction(object object, nint method);
                    /*0x1302f1c*/ int Invoke(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle);
                }
            }

            struct StyleValue
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId id;
                /*0x14*/ UnityEngine.UIElements.StyleKeyword keyword;
                /*0x18*/ float number;
                /*0x18*/ UnityEngine.UIElements.Length length;
                /*0x18*/ UnityEngine.Color color;
                /*0x18*/ System.Runtime.InteropServices.GCHandle resource;
            }

            struct StyleValueManaged
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId id;
                /*0x14*/ UnityEngine.UIElements.StyleKeyword keyword;
                /*0x18*/ object value;
            }

            struct MatchResultInfo
            {
                /*0x10*/ bool success;
                /*0x14*/ UnityEngine.UIElements.PseudoStates triggerPseudoMask;
                /*0x18*/ UnityEngine.UIElements.PseudoStates dependencyPseudoMask;

                /*0x1302f30*/ MatchResultInfo(bool success, UnityEngine.UIElements.PseudoStates triggerPseudoMask, UnityEngine.UIElements.PseudoStates dependencyPseudoMask);
            }

            struct SelectorMatchRecord
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ int styleSheetIndexInStack;
                /*0x20*/ UnityEngine.UIElements.StyleComplexSelector complexSelector;

                static /*0x1302f54*/ int Compare(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b);
                /*0x1302f40*/ SelectorMatchRecord(UnityEngine.UIElements.StyleSheet sheet, int styleSheetIndexInStack);
            }

            class StyleSelectorHelper
            {
                static /*0x130303c*/ UnityEngine.UIElements.StyleSheets.MatchResultInfo MatchesSelector(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSelector selector);
                static /*0x13032f8*/ bool MatchRightToLeft(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult);
                static /*0x13034c0*/ void FastLookup(System.Collections.Generic.IDictionary<string, UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, UnityEngine.UIElements.StyleMatchingContext context, string input, ref UnityEngine.UIElements.StyleSheets.SelectorMatchRecord record);
                static /*0x1303684*/ void FindMatches(UnityEngine.UIElements.StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, int parentSheetIndex);
            }

            struct Dimension : System.IEquatable<UnityEngine.UIElements.StyleSheets.Dimension>
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.Dimension.Unit unit;
                /*0x14*/ float value;

                static /*0x13039e8*/ bool op_Equality(UnityEngine.UIElements.StyleSheets.Dimension lhs, UnityEngine.UIElements.StyleSheets.Dimension rhs);
                /*0x13039dc*/ Dimension(float value, UnityEngine.UIElements.StyleSheets.Dimension.Unit unit);
                /*0x12fff90*/ UnityEngine.UIElements.Length ToLength();
                /*0x12fffc0*/ UnityEngine.UIElements.TimeValue ToTime();
                /*0x1302c58*/ UnityEngine.UIElements.Angle ToAngle();
                /*0x1303a10*/ bool Equals(UnityEngine.UIElements.StyleSheets.Dimension other);
                /*0x1303a38*/ bool Equals(object obj);
                /*0x1303ac4*/ int GetHashCode();
                /*0x12ff3b0*/ string ToString();

                enum Unit
                {
                    Unitless = 0,
                    Pixel = 1,
                    Percent = 2,
                    Second = 3,
                    Millisecond = 4,
                    Degree = 5,
                    Gradian = 6,
                    Radian = 7,
                    Turn = 8,
                }
            }

            struct ScalableImage
            {
                /*0x10*/ UnityEngine.Texture2D normalImage;
                /*0x18*/ UnityEngine.Texture2D highResolutionImage;

                /*0x12ff4e0*/ string ToString();
            }

            class StyleSheetColor
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, UnityEngine.Color32> s_NameToColor;

                static /*0x1303b20*/ StyleSheetColor();
                static /*0x1300c10*/ bool TryGetColor(string name, ref UnityEngine.Color color);
                static /*0x1303b0c*/ UnityEngine.Color32 HexToColor32(uint color);
            }

            class StyleSheetCache
            {
                static /*0x0*/ UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKeyComparer s_Comparer;
                static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey, UnityEngine.UIElements.StyleSheets.StylePropertyId[]> s_RulePropertyIdsCache;

                static /*0x130577c*/ StyleSheetCache();
                static /*0x12ff858*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleSheet sheet, int ruleIndex);
                static /*0x130569c*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleRule rule);
                static /*0x13055a8*/ UnityEngine.UIElements.StyleSheets.StylePropertyId GetPropertyId(UnityEngine.UIElements.StyleRule rule, int index);

                struct SheetHandleKey
                {
                    /*0x10*/ int sheetInstanceID;
                    /*0x14*/ int index;

                    /*0x1305574*/ SheetHandleKey(UnityEngine.UIElements.StyleSheet sheet, int index);
                }

                class SheetHandleKeyComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey>
                {
                    /*0x1305850*/ SheetHandleKeyComparer();
                    /*0x1305858*/ bool Equals(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey x, UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey y);
                    /*0x1305878*/ int GetHashCode(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey key);
                }
            }

            class StylePropertyUtil
            {
                static /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheets.StylePropertyId> s_AnimatablePropertiesHash;
                static /*0x8*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyId> s_NameToId;
                static /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, string> s_IdToName;
                static /*0x18*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] s_AnimatableProperties;

                static /*0x13058b8*/ StylePropertyUtil();
                static /*0x1307770*/ bool IsAnimatable(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                static /*0x12fda64*/ bool TryGetEnumIntValue(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, string value, ref int intValue);
                static /*0x13077f0*/ bool IsMatchingShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyId shorthand, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            }

            class StylePropertyCache
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_PropertySyntaxCache;
                static /*0x8*/ System.Collections.Generic.Dictionary<string, string> s_NonTerminalValues;

                static /*0x1412f34*/ StylePropertyCache();
                static /*0x1412e14*/ bool TryGetSyntax(string name, ref string syntax);
                static /*0x1412ea4*/ bool TryGetNonTerminalValue(string name, ref string syntax);
            }

            enum MatchResultErrorCode
            {
                None = 0,
                Syntax = 1,
                EmptyValue = 2,
                ExpectedEndOfValue = 3,
            }

            struct MatchResult
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.MatchResultErrorCode errorCode;
                /*0x18*/ string errorValue;

                /*0x1414218*/ bool get_success();
            }

            class BaseStyleMatcher
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex s_CustomIdentRegex;
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext> m_ContextStack;
                /*0x18*/ UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext m_CurrentContext;

                static /*0x1414e8c*/ BaseStyleMatcher();
                /*0x1414e10*/ BaseStyleMatcher();
                bool MatchKeyword(string keyword);
                bool MatchNumber();
                bool MatchInteger();
                bool MatchLength();
                bool MatchPercentage();
                bool MatchColor();
                bool MatchResource();
                bool MatchUrl();
                bool MatchTime();
                bool MatchAngle();
                bool MatchCustomIdent();
                int get_valueCount();
                bool get_isCurrentVariable();
                bool get_isCurrentComma();
                /*0x1414228*/ bool get_hasCurrent();
                /*0x1414250*/ int get_currentIndex();
                /*0x1414258*/ void set_currentIndex(int value);
                /*0x1414260*/ int get_matchedVariableCount();
                /*0x1414268*/ void set_matchedVariableCount(int value);
                /*0x1414270*/ void Initialize();
                /*0x14142c4*/ void MoveNext();
                /*0x1414308*/ void SaveContext();
                /*0x141435c*/ void RestoreContext();
                /*0x14143b4*/ void DropContext();
                /*0x1414404*/ bool Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x14144c0*/ bool MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x14145d4*/ bool MatchExpressionWithMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x14148e8*/ bool MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x1414720*/ bool MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x141499c*/ bool MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x1414a6c*/ bool MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x1414a84*/ bool MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x1414b20*/ int MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x1414c90*/ int MatchManyByOrder(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, int* matchOrder);
                /*0x1414ab4*/ bool MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x14147ec*/ bool MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);

                struct MatchContext
                {
                    /*0x10*/ int valueIndex;
                    /*0x14*/ int matchedVariableCount;
                }
            }

            class StylePropertyValueMatcher : UnityEngine.UIElements.StyleSheets.BaseStyleMatcher
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values;

                /*0x14158ac*/ StylePropertyValueMatcher();
                /*0x1414f20*/ UnityEngine.UIElements.StyleSheets.StylePropertyValue get_current();
                /*0x1414fa4*/ int get_valueCount();
                /*0x1414fec*/ bool get_isCurrentVariable();
                /*0x1414ff4*/ bool get_isCurrentComma();
                /*0x141509c*/ UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values);
                /*0x1415218*/ bool MatchKeyword(string keyword);
                /*0x14152cc*/ bool MatchNumber();
                /*0x1415300*/ bool MatchInteger();
                /*0x1415334*/ bool MatchLength();
                /*0x1415428*/ bool MatchPercentage();
                /*0x141551c*/ bool MatchColor();
                /*0x14155fc*/ bool MatchResource();
                /*0x1415630*/ bool MatchUrl();
                /*0x1415670*/ bool MatchTime();
                /*0x14156d0*/ bool MatchCustomIdent();
                /*0x14157b0*/ bool MatchAngle();
            }

            class InitialStyle
            {
                static /*0x0*/ UnityEngine.UIElements.ComputedStyle s_InitialStyle;

                static /*0x1415a00*/ InitialStyle();
                static /*0x1415900*/ ref UnityEngine.UIElements.ComputedStyle Get();
                static /*0x1415954*/ UnityEngine.UIElements.ComputedStyle Acquire();
                static /*0x141674c*/ UnityEngine.UIElements.Align get_alignContent();
                static /*0x14167c4*/ UnityEngine.UIElements.Align get_alignItems();
                static /*0x141683c*/ UnityEngine.UIElements.Align get_alignSelf();
                static /*0x14168b4*/ UnityEngine.Color get_backgroundColor();
                static /*0x1416930*/ UnityEngine.UIElements.Background get_backgroundImage();
                static /*0x14169b0*/ UnityEngine.Color get_borderBottomColor();
                static /*0x1416a2c*/ UnityEngine.UIElements.Length get_borderBottomLeftRadius();
                static /*0x1416aa4*/ UnityEngine.UIElements.Length get_borderBottomRightRadius();
                static /*0x1416b1c*/ float get_borderBottomWidth();
                static /*0x1416b94*/ UnityEngine.Color get_borderLeftColor();
                static /*0x1416c10*/ float get_borderLeftWidth();
                static /*0x1416c88*/ UnityEngine.Color get_borderRightColor();
                static /*0x1416d04*/ float get_borderRightWidth();
                static /*0x1416d7c*/ UnityEngine.Color get_borderTopColor();
                static /*0x1416df8*/ UnityEngine.UIElements.Length get_borderTopLeftRadius();
                static /*0x1416e70*/ UnityEngine.UIElements.Length get_borderTopRightRadius();
                static /*0x1416ee8*/ float get_borderTopWidth();
                static /*0x1416f60*/ UnityEngine.UIElements.Length get_bottom();
                static /*0x1416fd8*/ UnityEngine.Color get_color();
                static /*0x1417050*/ UnityEngine.UIElements.Cursor get_cursor();
                static /*0x14170d8*/ UnityEngine.UIElements.DisplayStyle get_display();
                static /*0x1417150*/ UnityEngine.UIElements.Length get_flexBasis();
                static /*0x14171c8*/ UnityEngine.UIElements.FlexDirection get_flexDirection();
                static /*0x1417240*/ float get_flexGrow();
                static /*0x14172b8*/ float get_flexShrink();
                static /*0x1417330*/ UnityEngine.UIElements.Wrap get_flexWrap();
                static /*0x14173a8*/ UnityEngine.UIElements.Length get_fontSize();
                static /*0x141741c*/ UnityEngine.UIElements.Length get_height();
                static /*0x1417494*/ UnityEngine.UIElements.Justify get_justifyContent();
                static /*0x141750c*/ UnityEngine.UIElements.Length get_left();
                static /*0x1417584*/ UnityEngine.UIElements.Length get_letterSpacing();
                static /*0x14175f8*/ UnityEngine.UIElements.Length get_marginBottom();
                static /*0x1417670*/ UnityEngine.UIElements.Length get_marginLeft();
                static /*0x14176e8*/ UnityEngine.UIElements.Length get_marginRight();
                static /*0x1417760*/ UnityEngine.UIElements.Length get_marginTop();
                static /*0x14177d8*/ UnityEngine.UIElements.Length get_maxHeight();
                static /*0x1417850*/ UnityEngine.UIElements.Length get_maxWidth();
                static /*0x14178c8*/ UnityEngine.UIElements.Length get_minHeight();
                static /*0x1417940*/ UnityEngine.UIElements.Length get_minWidth();
                static /*0x14179b8*/ float get_opacity();
                static /*0x1417a30*/ UnityEngine.UIElements.OverflowInternal get_overflow();
                static /*0x1417aa8*/ UnityEngine.UIElements.Length get_paddingBottom();
                static /*0x1417b20*/ UnityEngine.UIElements.Length get_paddingLeft();
                static /*0x1417b98*/ UnityEngine.UIElements.Length get_paddingRight();
                static /*0x1417c10*/ UnityEngine.UIElements.Length get_paddingTop();
                static /*0x1417c88*/ UnityEngine.UIElements.Position get_position();
                static /*0x1417d00*/ UnityEngine.UIElements.Length get_right();
                static /*0x1417d78*/ UnityEngine.UIElements.Rotate get_rotate();
                static /*0x1417e00*/ UnityEngine.UIElements.Scale get_scale();
                static /*0x1417e7c*/ UnityEngine.UIElements.TextOverflow get_textOverflow();
                static /*0x1417ef4*/ UnityEngine.UIElements.TextShadow get_textShadow();
                static /*0x1417f78*/ UnityEngine.UIElements.Length get_top();
                static /*0x1417ff0*/ UnityEngine.UIElements.TransformOrigin get_transformOrigin();
                static /*0x1418078*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay();
                static /*0x14180f0*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration();
                static /*0x1418168*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty();
                static /*0x14181e0*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction();
                static /*0x1418258*/ UnityEngine.UIElements.Translate get_translate();
                static /*0x14182e0*/ UnityEngine.Color get_unityBackgroundImageTintColor();
                static /*0x141835c*/ UnityEngine.ScaleMode get_unityBackgroundScaleMode();
                static /*0x14183d4*/ UnityEngine.Font get_unityFont();
                static /*0x1418448*/ UnityEngine.UIElements.FontDefinition get_unityFontDefinition();
                static /*0x14184c0*/ UnityEngine.FontStyle get_unityFontStyleAndWeight();
                static /*0x1418534*/ UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox();
                static /*0x14185ac*/ UnityEngine.UIElements.Length get_unityParagraphSpacing();
                static /*0x1418620*/ int get_unitySliceBottom();
                static /*0x1418698*/ int get_unitySliceLeft();
                static /*0x1418710*/ int get_unitySliceRight();
                static /*0x1418788*/ int get_unitySliceTop();
                static /*0x1418800*/ UnityEngine.TextAnchor get_unityTextAlign();
                static /*0x1418874*/ UnityEngine.Color get_unityTextOutlineColor();
                static /*0x14188ec*/ float get_unityTextOutlineWidth();
                static /*0x1418960*/ UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition();
                static /*0x14189d8*/ UnityEngine.UIElements.Visibility get_visibility();
                static /*0x1418a4c*/ UnityEngine.UIElements.WhiteSpace get_whiteSpace();
                static /*0x1418ac0*/ UnityEngine.UIElements.Length get_width();
                static /*0x1418b38*/ UnityEngine.UIElements.Length get_wordSpacing();
            }

            enum StyleEnumType
            {
                Align = 0,
                DisplayStyle = 1,
                EasingMode = 2,
                FlexDirection = 3,
                FontStyle = 4,
                Justify = 5,
                Overflow = 6,
                OverflowClipBox = 7,
                OverflowInternal = 8,
                Position = 9,
                ScaleMode = 10,
                TextAnchor = 11,
                TextOverflow = 12,
                TextOverflowPosition = 13,
                TransformOriginOffset = 14,
                Visibility = 15,
                WhiteSpace = 16,
                Wrap = 17,
            }

            enum StylePropertyId
            {
                Unknown = 0,
                Custom = -1,
                AlignContent = 131072,
                AlignItems = 131073,
                AlignSelf = 131074,
                All = 262144,
                BackgroundColor = 458752,
                BackgroundImage = 458753,
                BorderBottomColor = 458754,
                BorderBottomLeftRadius = 458755,
                BorderBottomRightRadius = 458756,
                BorderBottomWidth = 131075,
                BorderColor = 262145,
                BorderLeftColor = 458757,
                BorderLeftWidth = 131076,
                BorderRadius = 262146,
                BorderRightColor = 458758,
                BorderRightWidth = 131077,
                BorderTopColor = 458759,
                BorderTopLeftRadius = 458760,
                BorderTopRightRadius = 458761,
                BorderTopWidth = 131078,
                BorderWidth = 262147,
                Bottom = 131079,
                Color = 65536,
                Cursor = 196608,
                Display = 131080,
                Flex = 262148,
                FlexBasis = 131081,
                FlexDirection = 131082,
                FlexGrow = 131083,
                FlexShrink = 131084,
                FlexWrap = 131085,
                FontSize = 65537,
                Height = 131086,
                JustifyContent = 131087,
                Left = 131088,
                LetterSpacing = 65538,
                Margin = 262149,
                MarginBottom = 131089,
                MarginLeft = 131090,
                MarginRight = 131091,
                MarginTop = 131092,
                MaxHeight = 131093,
                MaxWidth = 131094,
                MinHeight = 131095,
                MinWidth = 131096,
                Opacity = 458762,
                Overflow = 458763,
                Padding = 262150,
                PaddingBottom = 131097,
                PaddingLeft = 131098,
                PaddingRight = 131099,
                PaddingTop = 131100,
                Position = 131101,
                Right = 131102,
                Rotate = 327680,
                Scale = 327681,
                TextOverflow = 196609,
                TextShadow = 65539,
                Top = 131103,
                TransformOrigin = 327682,
                Transition = 262151,
                TransitionDelay = 393216,
                TransitionDuration = 393217,
                TransitionProperty = 393218,
                TransitionTimingFunction = 393219,
                Translate = 327683,
                UnityBackgroundImageTintColor = 196610,
                UnityBackgroundScaleMode = 196611,
                UnityFont = 65540,
                UnityFontDefinition = 65541,
                UnityFontStyleAndWeight = 65542,
                UnityOverflowClipBox = 196612,
                UnityParagraphSpacing = 65543,
                UnitySliceBottom = 196613,
                UnitySliceLeft = 196614,
                UnitySliceRight = 196615,
                UnitySliceTop = 196616,
                UnityTextAlign = 65544,
                UnityTextOutline = 262152,
                UnityTextOutlineColor = 65545,
                UnityTextOutlineWidth = 65546,
                UnityTextOverflowPosition = 196617,
                Visibility = 65547,
                WhiteSpace = 65548,
                Width = 131104,
                WordSpacing = 65549,
            }

            namespace Syntax
            {
                enum StyleSyntaxTokenType
                {
                    Unknown = 0,
                    String = 1,
                    Number = 2,
                    Space = 3,
                    SingleBar = 4,
                    DoubleBar = 5,
                    DoubleAmpersand = 6,
                    Comma = 7,
                    SingleQuote = 8,
                    Asterisk = 9,
                    Plus = 10,
                    QuestionMark = 11,
                    HashMark = 12,
                    ExclamationPoint = 13,
                    OpenBracket = 14,
                    CloseBracket = 15,
                    OpenBrace = 16,
                    CloseBrace = 17,
                    LessThan = 18,
                    GreaterThan = 19,
                    End = 20,
                }

                struct StyleSyntaxToken
                {
                    /*0x10*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type;
                    /*0x18*/ string text;
                    /*0x20*/ int number;

                    /*0x1418bac*/ StyleSyntaxToken(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType t);
                    /*0x1418bbc*/ StyleSyntaxToken(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, string text);
                    /*0x1418bcc*/ StyleSyntaxToken(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, int number);
                }

                class StyleSyntaxTokenizer
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens;
                    /*0x18*/ int m_CurrentTokenIndex;

                    static /*0x1419b80*/ bool IsNextCharacter(string s, int index, char c);
                    static /*0x1419c5c*/ bool IsNextLetterOrDash(string s, int index);
                    static /*0x1419bc4*/ bool IsNextNumber(string s, int index);
                    static /*0x1419b44*/ int GlobCharacter(string s, int index, char c);
                    /*0x1419d1c*/ StyleSyntaxTokenizer();
                    /*0x1418bdc*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken get_current();
                    /*0x1418c88*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext();
                    /*0x1418d9c*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext();
                    /*0x1418e4c*/ void Tokenize(string syntax);
                }

                class StyleSyntaxParser
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ProcessExpressionList;
                    /*0x18*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ExpressionStack;
                    /*0x20*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator> m_CombinatorStack;
                    /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ParsedExpressionCache;

                    static /*0x141af70*/ void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    static /*0x141a998*/ bool IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token);
                    static /*0x141af5c*/ bool IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token);
                    static /*0x141b3f0*/ bool IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token);
                    /*0x141b53c*/ StyleSyntaxParser();
                    /*0x1419da0*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(string syntax);
                    /*0x1419f38*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x141a6a8*/ void ProcessCombinatorStack();
                    /*0x141a1b8*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x141a550*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x141a328*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x141a9fc*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x141afb0*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(string syntax);
                    /*0x141b104*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x141ade0*/ void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, ref UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier);
                    /*0x141b418*/ void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, ref int min, ref int max);
                }

                class Expression
                {
                    /*0x10*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type;
                    /*0x14*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier;
                    /*0x20*/ UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType;
                    /*0x24*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator combinator;
                    /*0x28*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression[] subExpressions;
                    /*0x30*/ string keyword;

                    /*0x141a9b8*/ Expression(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type);
                }

                enum ExpressionType
                {
                    Unknown = 0,
                    Data = 1,
                    Keyword = 2,
                    Combinator = 3,
                }

                enum DataType
                {
                    None = 0,
                    Number = 1,
                    Integer = 2,
                    Length = 3,
                    Percentage = 4,
                    Color = 5,
                    Resource = 6,
                    Url = 7,
                    Time = 8,
                    Angle = 9,
                    CustomIdent = 10,
                }

                enum ExpressionCombinator
                {
                    None = 0,
                    Or = 1,
                    OrOr = 2,
                    AndAnd = 3,
                    Juxtaposition = 4,
                    Group = 5,
                }

                enum ExpressionMultiplierType
                {
                    None = 0,
                    ZeroOrMore = 1,
                    OneOrMore = 2,
                    ZeroOrOne = 3,
                    Ranges = 4,
                    OneOrMoreComma = 5,
                    GroupAtLeastOne = 6,
                }

                struct ExpressionMultiplier
                {
                    static int Infinity = 100;
                    /*0x10*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType m_Type;
                    /*0x14*/ int min;
                    /*0x18*/ int max;

                    /*0x141b684*/ ExpressionMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type);
                    /*0x14144b8*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType get_type();
                    /*0x141b414*/ void set_type(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value);
                    /*0x141b694*/ void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2658253827592C8000DF6C48FD5487B674D9E695DB670A56FDEAB2B7F291523E;

    struct __StaticArrayInitTypeSize=108
    {
    }
}
