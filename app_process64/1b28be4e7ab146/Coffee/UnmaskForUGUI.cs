class <Module>
{
}

namespace Coffee
{
    namespace UIExtensions
    {
        class Unmask : UnityEngine.MonoBehaviour, UnityEngine.UI.IMaterialModifier
        {
            static /*0x0*/ UnityEngine.Vector2 s_Center;
            /*0x20*/ UnityEngine.RectTransform m_FitTarget;
            /*0x28*/ bool m_FitOnLateUpdate;
            /*0x29*/ bool m_OnlyForChildren;
            /*0x2a*/ bool m_ShowUnmaskGraphic;
            /*0x2c*/ float m_EdgeSmoothing;
            /*0x30*/ UnityEngine.Material _unmaskMaterial;
            /*0x38*/ UnityEngine.Material _revertUnmaskMaterial;
            /*0x40*/ UnityEngine.UI.MaskableGraphic _graphic;

            static /*0x3d3af84*/ Unmask();
            static /*0x3d3ada4*/ void Smoothing(UnityEngine.UI.MaskableGraphic graphic, float smooth);
            /*0x3d3af7c*/ Unmask();
            /*0x3d3a610*/ UnityEngine.UI.MaskableGraphic get_graphic();
            /*0x3d3a680*/ UnityEngine.RectTransform get_fitTarget();
            /*0x3d3a688*/ void set_fitTarget(UnityEngine.RectTransform value);
            /*0x3d3a850*/ bool get_fitOnLateUpdate();
            /*0x3d3a858*/ void set_fitOnLateUpdate(bool value);
            /*0x3d3a864*/ bool get_showUnmaskGraphic();
            /*0x3d3a86c*/ void set_showUnmaskGraphic(bool value);
            /*0x3d3a910*/ bool get_onlyForChildren();
            /*0x3d3a918*/ void set_onlyForChildren(bool value);
            /*0x3d3a924*/ float get_edgeSmoothing();
            /*0x3d3a92c*/ void set_edgeSmoothing(float value);
            /*0x3d3a934*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x3d3a6b8*/ void FitTo(UnityEngine.RectTransform target);
            /*0x3d3ab34*/ void OnEnable();
            /*0x3d3aba8*/ void OnDisable();
            /*0x3d3ace4*/ void LateUpdate();
            /*0x3d3a878*/ void SetDirty();
        }

        class UnmaskRaycastFilter : UnityEngine.MonoBehaviour, UnityEngine.ICanvasRaycastFilter
        {
            /*0x20*/ Coffee.UIExtensions.Unmask m_TargetUnmask;

            /*0x3d3b150*/ UnmaskRaycastFilter();
            /*0x3d3afd0*/ Coffee.UIExtensions.Unmask get_targetUnmask();
            /*0x3d3afd8*/ void set_targetUnmask(Coffee.UIExtensions.Unmask value);
            /*0x3d3afe0*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x3d3b14c*/ void OnEnable();
        }
    }
}
