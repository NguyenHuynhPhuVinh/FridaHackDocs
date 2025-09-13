class <Module>
{
}

namespace UnityEngine
{
    namespace Yoga
    {
        class BaselineFunction : System.MulticastDelegate
        {
            /*0x2b30790*/ BaselineFunction(object object, nint method);
            /*0x2b307f0*/ float Invoke(UnityEngine.Yoga.YogaNode node, float width, float height);
            /*0x2b30bb0*/ System.IAsyncResult BeginInvoke(UnityEngine.Yoga.YogaNode node, float width, float height, System.AsyncCallback callback, object object);
            /*0x2b30c60*/ float EndInvoke(System.IAsyncResult result);
        }

        class MeasureFunction : System.MulticastDelegate
        {
            /*0x2b30c8c*/ MeasureFunction(object object, nint method);
            /*0x2b30cec*/ UnityEngine.Yoga.YogaSize Invoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
            /*0x2b310f0*/ System.IAsyncResult BeginInvoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode, System.AsyncCallback callback, object object);
            /*0x2b311e4*/ UnityEngine.Yoga.YogaSize EndInvoke(System.IAsyncResult result);
        }

        enum YogaMeasureMode
        {
            Undefined = 0,
            Exactly = 1,
            AtMost = 2,
        }

        class Native
        {
            static /*0x2b31210*/ void YGNodeMeasureInvoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode, nint returnValueAddress);
            static /*0x2b312e8*/ void YGNodeBaselineInvoke(UnityEngine.Yoga.YogaNode node, float width, float height, nint returnValueAddress);
        }

        class YogaNode
        {
            /*0x10*/ nint _ygNode;
            /*0x18*/ UnityEngine.Yoga.MeasureFunction _measureFunction;
            /*0x20*/ UnityEngine.Yoga.BaselineFunction _baselineFunction;

            static /*0x2b31278*/ UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
            static /*0x2b31338*/ float BaselineInternal(UnityEngine.Yoga.YogaNode node, float width, float height);
        }

        struct YogaSize
        {
            /*0x10*/ float width;
            /*0x14*/ float height;
        }
    }

    namespace UIElements
    {
        class UIElementsRuntimeUtilityNative
        {
            static /*0x0*/ System.Action RepaintOverlayPanelsCallback;
            static /*0x8*/ System.Action UpdateRuntimePanelsCallback;

            static /*0x2b313a0*/ void RepaintOverlayPanels();
            static /*0x2b31400*/ void UpdateRuntimePanels();
        }

        namespace UIR
        {
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

                static /*0x2b31860*/ Utility();
                static /*0x2b31460*/ void RaiseGraphicsResourcesRecreate(bool recreate);
                static /*0x2b314f4*/ void RaiseEngineUpdate();
                static /*0x2b31598*/ void RaiseFlushPendingResources();
                static /*0x2b31610*/ void RaiseRegisterIntermediateRenderers(UnityEngine.Camera camera);
                static /*0x2b316a4*/ void RaiseRenderNodeAdd(nint userData);
                static /*0x2b31738*/ void RaiseRenderNodeExecute(nint userData);
                static /*0x2b317cc*/ void RaiseRenderNodeCleanup(nint userData);

                class GPUBuffer<T>
                {
                    /*0x0*/ nint buffer;
                }
            }
        }
    }
}
