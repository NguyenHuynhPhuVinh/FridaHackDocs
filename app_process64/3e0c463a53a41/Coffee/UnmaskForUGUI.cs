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

            static /*0x3d2f2b0*/ Unmask();
            static /*0x3d2f0d0*/ void Smoothing(UnityEngine.UI.MaskableGraphic graphic, float smooth);
            /*0x3d2f2a8*/ Unmask();
            /*0x3d2e93c*/ UnityEngine.UI.MaskableGraphic get_graphic();
            /*0x3d2e9ac*/ UnityEngine.RectTransform get_fitTarget();
            /*0x3d2e9b4*/ void set_fitTarget(UnityEngine.RectTransform value);
            /*0x3d2eb7c*/ bool get_fitOnLateUpdate();
            /*0x3d2eb84*/ void set_fitOnLateUpdate(bool value);
            /*0x3d2eb90*/ bool get_showUnmaskGraphic();
            /*0x3d2eb98*/ void set_showUnmaskGraphic(bool value);
            /*0x3d2ec3c*/ bool get_onlyForChildren();
            /*0x3d2ec44*/ void set_onlyForChildren(bool value);
            /*0x3d2ec50*/ float get_edgeSmoothing();
            /*0x3d2ec58*/ void set_edgeSmoothing(float value);
            /*0x3d2ec60*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x3d2e9e4*/ void FitTo(UnityEngine.RectTransform target);
            /*0x3d2ee60*/ void OnEnable();
            /*0x3d2eed4*/ void OnDisable();
            /*0x3d2f010*/ void LateUpdate();
            /*0x3d2eba4*/ void SetDirty();
        }

        class UnmaskRaycastFilter : UnityEngine.MonoBehaviour, UnityEngine.ICanvasRaycastFilter
        {
            /*0x20*/ Coffee.UIExtensions.Unmask m_TargetUnmask;

            /*0x3d2f47c*/ UnmaskRaycastFilter();
            /*0x3d2f2fc*/ Coffee.UIExtensions.Unmask get_targetUnmask();
            /*0x3d2f304*/ void set_targetUnmask(Coffee.UIExtensions.Unmask value);
            /*0x3d2f30c*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x3d2f478*/ void OnEnable();
        }
    }
}
