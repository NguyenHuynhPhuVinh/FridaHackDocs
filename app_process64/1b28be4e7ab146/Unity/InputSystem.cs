class <Module>
{
}

class UISupport
{
    static /*0x79ec044*/ void Initialize();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x79ec0b8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x79ec1ac*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Unity
{
    namespace XR
    {
        namespace OpenVR
        {
            class OpenVRHMD : UnityEngine.InputSystem.XR.XRHMD
            {
                /*0x1d8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1e0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;
                /*0x1e8*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyeVelocity>k__BackingField;
                /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAngularVelocity>k__BackingField;
                /*0x1f8*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyeVelocity>k__BackingField;
                /*0x200*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAngularVelocity>k__BackingField;
                /*0x208*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyeVelocity>k__BackingField;
                /*0x210*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAngularVelocity>k__BackingField;

                /*0x79ec47c*/ OpenVRHMD();
                /*0x79ec1b4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79ec1bc*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec1cc*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79ec1d4*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec1e4*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeVelocity();
                /*0x79ec1ec*/ void set_leftEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec1fc*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity();
                /*0x79ec204*/ void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec214*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeVelocity();
                /*0x79ec21c*/ void set_rightEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec22c*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity();
                /*0x79ec234*/ void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec244*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeVelocity();
                /*0x79ec24c*/ void set_centerEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec25c*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity();
                /*0x79ec264*/ void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec274*/ void FinishSetup();
            }

            class OpenVRControllerWMR : UnityEngine.InputSystem.XR.XRController
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadClick>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouch>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;
                /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField;
                /*0x1e0*/ UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;
                /*0x1e8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;
                /*0x1f8*/ UnityEngine.InputSystem.Controls.Vector2Control <joystick>k__BackingField;

                /*0x79ec86c*/ OpenVRControllerWMR();
                /*0x79ec484*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79ec48c*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec49c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79ec4a4*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec4b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClick();
                /*0x79ec4bc*/ void set_touchpadClick(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec4cc*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouch();
                /*0x79ec4d4*/ void set_touchpadTouch(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec4e4*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79ec4ec*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec4fc*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79ec504*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec514*/ UnityEngine.InputSystem.Controls.ButtonControl get_menu();
                /*0x79ec51c*/ void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec52c*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                /*0x79ec534*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ec544*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79ec54c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ec55c*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                /*0x79ec564*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79ec574*/ UnityEngine.InputSystem.Controls.Vector2Control get_joystick();
                /*0x79ec57c*/ void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79ec58c*/ void FinishSetup();
            }

            class ViveWand : UnityEngine.InputSystem.XR.XRControllerWithRumble
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <primary>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <trackpadPressed>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <trackpadTouched>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.Vector2Control <trackpad>k__BackingField;
                /*0x1d8*/ UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;
                /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;
                /*0x1e8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;

                /*0x79ecc10*/ ViveWand();
                /*0x79ec874*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79ec87c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ec88c*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79ec894*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec8a4*/ UnityEngine.InputSystem.Controls.ButtonControl get_primary();
                /*0x79ec8ac*/ void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec8bc*/ UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed();
                /*0x79ec8c4*/ void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec8d4*/ UnityEngine.InputSystem.Controls.ButtonControl get_trackpadTouched();
                /*0x79ec8dc*/ void set_trackpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec8ec*/ UnityEngine.InputSystem.Controls.Vector2Control get_trackpad();
                /*0x79ec8f4*/ void set_trackpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79ec904*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                /*0x79ec90c*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ec91c*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79ec924*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ec934*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79ec93c*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec94c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79ec954*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ec964*/ void FinishSetup();
            }

            class ViveLighthouse : UnityEngine.InputSystem.TrackedDevice
            {
                /*0x79ecc18*/ ViveLighthouse();
            }

            class ViveTracker : UnityEngine.InputSystem.TrackedDevice
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;

                /*0x79ecd08*/ ViveTracker();
                /*0x79ecc20*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79ecc28*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ecc38*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79ecc40*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ecc50*/ void FinishSetup();
            }

            class HandedViveTracker : Unity.XR.OpenVR.ViveTracker
            {
                /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <primary>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <trackpadPressed>k__BackingField;
                /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;

                /*0x79ecefc*/ HandedViveTracker();
                /*0x79ecd10*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79ecd18*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ecd28*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79ecd30*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecd40*/ UnityEngine.InputSystem.Controls.ButtonControl get_primary();
                /*0x79ecd48*/ void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecd58*/ UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed();
                /*0x79ecd60*/ void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecd70*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79ecd78*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecd88*/ void FinishSetup();
            }

            class OpenVROculusTouchController : UnityEngine.InputSystem.XR.XRControllerWithRumble
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector2Control <thumbstick>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <primaryButton>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <secondaryButton>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;
                /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <thumbstickClicked>k__BackingField;
                /*0x1e8*/ UnityEngine.InputSystem.Controls.ButtonControl <thumbstickTouched>k__BackingField;
                /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1f8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;

                /*0x79ed2ec*/ OpenVROculusTouchController();
                /*0x79ecf04*/ UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick();
                /*0x79ecf0c*/ void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79ecf1c*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                /*0x79ecf24*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ecf34*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79ecf3c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79ecf4c*/ UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton();
                /*0x79ecf54*/ void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecf64*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton();
                /*0x79ecf6c*/ void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecf7c*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79ecf84*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecf94*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79ecf9c*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecfac*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked();
                /*0x79ecfb4*/ void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecfc4*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched();
                /*0x79ecfcc*/ void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ecfdc*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79ecfe4*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ecff4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79ecffc*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ed00c*/ void FinishSetup();
            }
        }

        namespace Oculus
        {
            namespace Input
            {
                class OculusHMD : UnityEngine.InputSystem.XR.XRHMD
                {
                    /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <userPresence>k__BackingField;
                    /*0x1e0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;
                    /*0x1e8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;
                    /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularAcceleration>k__BackingField;
                    /*0x1f8*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAngularVelocity>k__BackingField;
                    /*0x200*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAcceleration>k__BackingField;
                    /*0x208*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAngularAcceleration>k__BackingField;
                    /*0x210*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAngularVelocity>k__BackingField;
                    /*0x218*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAcceleration>k__BackingField;
                    /*0x220*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAngularAcceleration>k__BackingField;
                    /*0x228*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAngularVelocity>k__BackingField;
                    /*0x230*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAcceleration>k__BackingField;
                    /*0x238*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAngularAcceleration>k__BackingField;

                    /*0x79ed74c*/ OculusHMD();
                    /*0x79ed2f4*/ UnityEngine.InputSystem.Controls.ButtonControl get_userPresence();
                    /*0x79ed2fc*/ void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed30c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79ed314*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed324*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                    /*0x79ed32c*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed33c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration();
                    /*0x79ed344*/ void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed354*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity();
                    /*0x79ed35c*/ void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed36c*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAcceleration();
                    /*0x79ed374*/ void set_leftEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed384*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularAcceleration();
                    /*0x79ed38c*/ void set_leftEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed39c*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity();
                    /*0x79ed3a4*/ void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed3b4*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAcceleration();
                    /*0x79ed3bc*/ void set_rightEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed3cc*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularAcceleration();
                    /*0x79ed3d4*/ void set_rightEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed3e4*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity();
                    /*0x79ed3ec*/ void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed3fc*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAcceleration();
                    /*0x79ed404*/ void set_centerEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed414*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularAcceleration();
                    /*0x79ed41c*/ void set_centerEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed42c*/ void FinishSetup();
                }

                class OculusTouchController : UnityEngine.InputSystem.XR.XRControllerWithRumble
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector2Control <thumbstick>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;
                    /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                    /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <primaryButton>k__BackingField;
                    /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <secondaryButton>k__BackingField;
                    /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                    /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <start>k__BackingField;
                    /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <thumbstickClicked>k__BackingField;
                    /*0x1e8*/ UnityEngine.InputSystem.Controls.ButtonControl <primaryTouched>k__BackingField;
                    /*0x1f0*/ UnityEngine.InputSystem.Controls.ButtonControl <secondaryTouched>k__BackingField;
                    /*0x1f8*/ UnityEngine.InputSystem.Controls.AxisControl <triggerTouched>k__BackingField;
                    /*0x200*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;
                    /*0x208*/ UnityEngine.InputSystem.Controls.ButtonControl <thumbstickTouched>k__BackingField;
                    /*0x210*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                    /*0x218*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;
                    /*0x220*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;
                    /*0x228*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularAcceleration>k__BackingField;

                    /*0x79edd04*/ OculusTouchController();
                    /*0x79ed754*/ UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick();
                    /*0x79ed75c*/ void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79ed76c*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                    /*0x79ed774*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79ed784*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                    /*0x79ed78c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79ed79c*/ UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton();
                    /*0x79ed7a4*/ void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed7b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton();
                    /*0x79ed7bc*/ void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed7cc*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                    /*0x79ed7d4*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed7e4*/ UnityEngine.InputSystem.Controls.ButtonControl get_start();
                    /*0x79ed7ec*/ void set_start(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed7fc*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked();
                    /*0x79ed804*/ void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed814*/ UnityEngine.InputSystem.Controls.ButtonControl get_primaryTouched();
                    /*0x79ed81c*/ void set_primaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed82c*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondaryTouched();
                    /*0x79ed834*/ void set_secondaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed844*/ UnityEngine.InputSystem.Controls.AxisControl get_triggerTouched();
                    /*0x79ed84c*/ void set_triggerTouched(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79ed85c*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                    /*0x79ed864*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed874*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched();
                    /*0x79ed87c*/ void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ed88c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                    /*0x79ed894*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed8a4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79ed8ac*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed8bc*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                    /*0x79ed8c4*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed8d4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration();
                    /*0x79ed8dc*/ void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ed8ec*/ void FinishSetup();
                }

                class OculusTrackingReference : UnityEngine.InputSystem.TrackedDevice
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;

                    /*0x79ede10*/ OculusTrackingReference();
                    /*0x79edd0c*/ UnityEngine.InputSystem.Controls.IntegerControl get_trackingState();
                    /*0x79edd14*/ void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value);
                    /*0x79edd24*/ UnityEngine.InputSystem.Controls.ButtonControl get_isTracked();
                    /*0x79edd2c*/ void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79edd3c*/ void FinishSetup();
                }

                class OculusRemote : UnityEngine.InputSystem.InputDevice
                {
                    /*0x188*/ UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;
                    /*0x190*/ UnityEngine.InputSystem.Controls.ButtonControl <start>k__BackingField;
                    /*0x198*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;

                    /*0x79edf68*/ OculusRemote();
                    /*0x79ede18*/ UnityEngine.InputSystem.Controls.ButtonControl get_back();
                    /*0x79ede20*/ void set_back(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ede30*/ UnityEngine.InputSystem.Controls.ButtonControl get_start();
                    /*0x79ede38*/ void set_start(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ede48*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79ede50*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79ede60*/ void FinishSetup();
                }

                class OculusHMDExtended : Unity.XR.Oculus.Input.OculusHMD
                {
                    /*0x240*/ UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;
                    /*0x248*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;

                    /*0x79ee070*/ OculusHMDExtended();
                    /*0x79edf70*/ UnityEngine.InputSystem.Controls.ButtonControl get_back();
                    /*0x79edf78*/ void set_back(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79edf88*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79edf90*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79edfa0*/ void FinishSetup();
                }

                class GearVRTrackedController : UnityEngine.InputSystem.XR.XRController
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;
                    /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;
                    /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;
                    /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField;
                    /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField;
                    /*0x1d8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;
                    /*0x1e0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;
                    /*0x1e8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularAcceleration>k__BackingField;

                    /*0x79ee3c8*/ GearVRTrackedController();
                    /*0x79ee078*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79ee080*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79ee090*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                    /*0x79ee098*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79ee0a8*/ UnityEngine.InputSystem.Controls.ButtonControl get_back();
                    /*0x79ee0b0*/ void set_back(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ee0c0*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                    /*0x79ee0c8*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ee0d8*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked();
                    /*0x79ee0e0*/ void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ee0f0*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched();
                    /*0x79ee0f8*/ void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ee108*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79ee110*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ee120*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                    /*0x79ee128*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ee138*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration();
                    /*0x79ee140*/ void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ee150*/ void FinishSetup();
                }
            }
        }

        namespace GoogleVr
        {
            class DaydreamHMD : UnityEngine.InputSystem.XR.XRHMD
            {
                /*0x79ee3d0*/ DaydreamHMD();
            }

            class DaydreamController : UnityEngine.InputSystem.XR.XRController
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <volumeUp>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <recentered>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <volumeDown>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <recentering>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <app>k__BackingField;
                /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <home>k__BackingField;
                /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField;
                /*0x1e8*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField;
                /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1f8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;

                /*0x79ee7ac*/ DaydreamController();
                /*0x79ee3d8*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                /*0x79ee3e0*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79ee3f0*/ UnityEngine.InputSystem.Controls.ButtonControl get_volumeUp();
                /*0x79ee3f8*/ void set_volumeUp(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee408*/ UnityEngine.InputSystem.Controls.ButtonControl get_recentered();
                /*0x79ee410*/ void set_recentered(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee420*/ UnityEngine.InputSystem.Controls.ButtonControl get_volumeDown();
                /*0x79ee428*/ void set_volumeDown(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee438*/ UnityEngine.InputSystem.Controls.ButtonControl get_recentering();
                /*0x79ee440*/ void set_recentering(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee450*/ UnityEngine.InputSystem.Controls.ButtonControl get_app();
                /*0x79ee458*/ void set_app(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee468*/ UnityEngine.InputSystem.Controls.ButtonControl get_home();
                /*0x79ee470*/ void set_home(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee480*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked();
                /*0x79ee488*/ void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee498*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched();
                /*0x79ee4a0*/ void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79ee4b0*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79ee4b8*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ee4c8*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                /*0x79ee4d0*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79ee4e0*/ void FinishSetup();
            }
        }
    }
}

namespace UnityEngine
{
    namespace XR
    {
        namespace WindowsMR
        {
            namespace Input
            {
                class WMRHMD : UnityEngine.InputSystem.XR.XRHMD
                {
                    /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <userPresence>k__BackingField;

                    /*0x79ee850*/ WMRHMD();
                    /*0x79ee7b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_userPresence();
                    /*0x79ee7bc*/ void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ee7cc*/ void FinishSetup();
                }

                class HololensHand : UnityEngine.InputSystem.XR.XRController
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <airTap>k__BackingField;
                    /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField;
                    /*0x1c0*/ UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField;

                    /*0x79eea10*/ HololensHand();
                    /*0x79ee858*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                    /*0x79ee860*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ee870*/ UnityEngine.InputSystem.Controls.ButtonControl get_airTap();
                    /*0x79ee878*/ void set_airTap(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79ee888*/ UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk();
                    /*0x79ee890*/ void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79ee8a0*/ UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection();
                    /*0x79ee8a8*/ void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79ee8b8*/ void FinishSetup();
                }

                class WMRSpatialController : UnityEngine.InputSystem.XR.XRControllerWithRumble
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector2Control <joystick>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;
                    /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                    /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                    /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField;
                    /*0x1d0*/ UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;
                    /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;
                    /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <joystickClicked>k__BackingField;
                    /*0x1e8*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField;
                    /*0x1f0*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField;
                    /*0x1f8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                    /*0x200*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;
                    /*0x208*/ UnityEngine.InputSystem.Controls.AxisControl <batteryLevel>k__BackingField;
                    /*0x210*/ UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField;
                    /*0x218*/ UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField;
                    /*0x220*/ UnityEngine.InputSystem.Controls.Vector3Control <pointerPosition>k__BackingField;
                    /*0x228*/ UnityEngine.InputSystem.Controls.QuaternionControl <pointerRotation>k__BackingField;

                    /*0x79eefdc*/ WMRSpatialController();
                    /*0x79eea18*/ UnityEngine.InputSystem.Controls.Vector2Control get_joystick();
                    /*0x79eea20*/ void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79eea30*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79eea38*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79eea48*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                    /*0x79eea50*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79eea60*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                    /*0x79eea68*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79eea78*/ UnityEngine.InputSystem.Controls.ButtonControl get_menu();
                    /*0x79eea80*/ void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79eea90*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                    /*0x79eea98*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79eeaa8*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                    /*0x79eeab0*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79eeac0*/ UnityEngine.InputSystem.Controls.ButtonControl get_joystickClicked();
                    /*0x79eeac8*/ void set_joystickClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79eead8*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked();
                    /*0x79eeae0*/ void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79eeaf0*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched();
                    /*0x79eeaf8*/ void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79eeb08*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                    /*0x79eeb10*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79eeb20*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79eeb28*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79eeb38*/ UnityEngine.InputSystem.Controls.AxisControl get_batteryLevel();
                    /*0x79eeb40*/ void set_batteryLevel(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79eeb50*/ UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk();
                    /*0x79eeb58*/ void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79eeb68*/ UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection();
                    /*0x79eeb70*/ void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79eeb80*/ UnityEngine.InputSystem.Controls.Vector3Control get_pointerPosition();
                    /*0x79eeb88*/ void set_pointerPosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79eeb98*/ UnityEngine.InputSystem.Controls.QuaternionControl get_pointerRotation();
                    /*0x79eeba0*/ void set_pointerRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                    /*0x79eebb0*/ void FinishSetup();
                }
            }
        }
    }

    namespace InputSystem
    {
        interface IInputActionCollection : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable
        {
            /*0x3910ae8*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x3910ae8*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x38141c4*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x38159dc*/ void Enable();
            /*0x38159dc*/ void Disable();
        }

        interface IInputActionCollection2 : UnityEngine.InputSystem.IInputActionCollection, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable
        {
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x3814a74*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            int FindBinding(UnityEngine.InputSystem.InputBinding mask, ref UnityEngine.InputSystem.InputAction action);
        }

        interface IInputInteraction
        {
            /*0x3816710*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
            /*0x38159dc*/ void Reset();
        }

        interface IInputInteraction<TValue> : UnityEngine.InputSystem.IInputInteraction
        {
        }

        class InputInteraction
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable s_Interactions;

            static /*0x79eefe4*/ System.Type GetValueType(System.Type interactionType);
            static /*0x79ef0c8*/ string GetDisplayName(string interaction);
            static /*0x79ef1bc*/ string GetDisplayName(System.Type interactionType);
        }

        class InputAction : System.ICloneable, System.IDisposable
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_InputActionEnableProfilerMarker;
            static /*0x8*/ Unity.Profiling.ProfilerMarker k_InputActionDisableProfilerMarker;
            /*0x10*/ string m_Name;
            /*0x18*/ UnityEngine.InputSystem.InputActionType m_Type;
            /*0x20*/ string m_ExpectedControlType;
            /*0x28*/ string m_Id;
            /*0x30*/ string m_Processors;
            /*0x38*/ string m_Interactions;
            /*0x40*/ UnityEngine.InputSystem.InputBinding[] m_SingletonActionBindings;
            /*0x48*/ UnityEngine.InputSystem.InputAction.ActionFlags m_Flags;
            /*0x50*/ System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;
            /*0xb0*/ int m_BindingsStartIndex;
            /*0xb4*/ int m_BindingsCount;
            /*0xb8*/ int m_ControlStartIndex;
            /*0xbc*/ int m_ControlCount;
            /*0xc0*/ int m_ActionIndexInState;
            /*0xc8*/ UnityEngine.InputSystem.InputActionMap m_ActionMap;
            /*0xd0*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnStarted;
            /*0x120*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnCanceled;
            /*0x170*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnPerformed;

            static /*0x79f1440*/ InputAction();
            /*0x79efe68*/ InputAction();
            /*0x79efebc*/ InputAction(string name, UnityEngine.InputSystem.InputActionType type, string binding, string interactions, string processors, string expectedControlType);
            /*0x79ef344*/ string get_name();
            /*0x79ef34c*/ UnityEngine.InputSystem.InputActionType get_type();
            /*0x79ef354*/ System.Guid get_id();
            /*0x79ef3b4*/ System.Guid get_idDontGenerate();
            /*0x79ef3fc*/ string get_expectedControlType();
            /*0x79ef404*/ void set_expectedControlType(string value);
            /*0x79ef40c*/ string get_processors();
            /*0x79ef414*/ string get_interactions();
            /*0x79ef41c*/ UnityEngine.InputSystem.InputActionMap get_actionMap();
            /*0x79ef45c*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x79ef46c*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x79ef784*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x79ef834*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls();
            /*0x79ef92c*/ UnityEngine.InputSystem.InputActionPhase get_phase();
            /*0x79ef9d4*/ bool get_inProgress();
            /*0x79efa20*/ bool get_enabled();
            /*0x79efa68*/ void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79efac0*/ void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79efb18*/ void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79efb70*/ void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79efbc8*/ void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79efc20*/ void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79efc78*/ bool get_triggered();
            /*0x79efd28*/ UnityEngine.InputSystem.InputControl get_activeControl();
            /*0x79efdb4*/ System.Type get_activeValueType();
            /*0x79efe3c*/ bool get_wantsInitialStateCheck();
            /*0x79efe58*/ void set_wantsInitialStateCheck(bool value);
            /*0x79f00f4*/ void Dispose();
            /*0x79f0110*/ string ToString();
            /*0x79f03dc*/ void Enable();
            /*0x79f0554*/ void Disable();
            /*0x79f06ac*/ UnityEngine.InputSystem.InputAction Clone();
            /*0x79f07bc*/ object System.ICloneable.Clone();
            /*0x3910ae8*/ TValue ReadValue<TValue>();
            /*0x79f07c0*/ object ReadValueAsObject();
            /*0x79f085c*/ float GetControlMagnitude();
            /*0x79f08c8*/ void Reset();
            /*0x79f0964*/ bool IsPressed();
            /*0x79f09b8*/ bool IsInProgress();
            /*0x79f0a10*/ int ExpectedFrame();
            /*0x79f0a84*/ bool WasPressedThisFrame();
            /*0x79f0b30*/ bool WasReleasedThisFrame();
            /*0x79efc7c*/ bool WasPerformedThisFrame();
            /*0x79f0bdc*/ bool WasCompletedThisFrame();
            /*0x79f0c88*/ float GetTimeoutCompletionPercentage();
            /*0x79ef43c*/ bool get_isSingletonAction();
            /*0x79ef96c*/ UnityEngine.InputSystem.InputActionState.TriggerState get_currentState();
            /*0x79ef388*/ string MakeSureIdIsInPlace();
            /*0x79f0db4*/ void GenerateId();
            /*0x79ef670*/ UnityEngine.InputSystem.InputActionMap GetOrCreateActionMap();
            /*0x79f0df8*/ void CreateInternalActionMapForSingletonAction();
            /*0x79f0f4c*/ void RequestInitialStateCheckOnEnabledAction();
            /*0x79f0f8c*/ bool ActiveControlIsValid(UnityEngine.InputSystem.InputControl control);
            /*0x79f1160*/ System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask();
            /*0x79f11f0*/ int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction);
            /*0x79f1384*/ int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap);

            enum ActionFlags
            {
                WantsInitialStateCheck = 1,
            }

            struct CallbackContext
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
                /*0x18*/ int m_ActionIndex;

                /*0x79f14f4*/ int get_actionIndex();
                /*0x79f14fc*/ int get_bindingIndex();
                /*0x79f1530*/ int get_controlIndex();
                /*0x79f1564*/ int get_interactionIndex();
                /*0x79f1598*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x79f15c8*/ bool get_started();
                /*0x79f1600*/ bool get_performed();
                /*0x79f1638*/ bool get_canceled();
                /*0x79f1670*/ UnityEngine.InputSystem.InputAction get_action();
                /*0x79f16a0*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x79f16e4*/ UnityEngine.InputSystem.IInputInteraction get_interaction();
                /*0x79f173c*/ double get_time();
                /*0x79f1774*/ double get_startTime();
                /*0x79f17ac*/ double get_duration();
                /*0x79f1814*/ System.Type get_valueType();
                /*0x79f1864*/ int get_valueSizeInBytes();
                /*0x79f18b4*/ void ReadValue(void* buffer, int bufferSize);
                /*0x3910ae8*/ TValue ReadValue<TValue>();
                /*0x79f1a70*/ bool ReadValueAsButton();
                /*0x79f1af4*/ object ReadValueAsObject();
                /*0x79f1b7c*/ string ToString();
            }
        }

        class InputActionAsset : UnityEngine.ScriptableObject, UnityEngine.InputSystem.IInputActionCollection2, UnityEngine.InputSystem.IInputActionCollection, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable
        {
            static string Extension = "inputactions";
            static string kDefaultAssetLayoutJson = "{}";
            /*0x18*/ UnityEngine.InputSystem.InputActionMap[] m_ActionMaps;
            /*0x20*/ UnityEngine.InputSystem.InputControlScheme[] m_ControlSchemes;
            /*0x28*/ bool m_IsProjectWide;
            /*0x30*/ UnityEngine.InputSystem.InputActionState m_SharedStateForAllMaps;
            /*0x38*/ System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;
            /*0x98*/ int m_ParameterOverridesCount;
            /*0xa0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;
            /*0xa8*/ UnityEngine.InputSystem.InputActionMap.DeviceArray m_Devices;

            static /*0x79f2f44*/ UnityEngine.InputSystem.InputActionAsset FromJson(string json);
            /*0x79f4600*/ InputActionAsset();
            /*0x79f1e10*/ bool get_enabled();
            /*0x79f1fa8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps();
            /*0x79f2018*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x79f2078*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x79f2128*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x79f2138*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x79f22c0*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            /*0x79f239c*/ void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            /*0x79f255c*/ UnityEngine.InputSystem.InputAction get_Item(string actionNameOrId);
            /*0x79f2900*/ string ToJson();
            /*0x79f2d88*/ void LoadFromJson(string json);
            /*0x79f25dc*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            /*0x79f3110*/ int FindBinding(UnityEngine.InputSystem.InputBinding mask, ref UnityEngine.InputSystem.InputAction action);
            /*0x79f3300*/ UnityEngine.InputSystem.InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound);
            /*0x79f3508*/ UnityEngine.InputSystem.InputActionMap FindActionMap(System.Guid id);
            /*0x79f3594*/ UnityEngine.InputSystem.InputAction FindAction(System.Guid guid);
            /*0x79f3658*/ int FindControlSchemeIndex(string name);
            /*0x79f3730*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(string name);
            /*0x79f385c*/ bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x79f3ae0*/ void Enable();
            /*0x79f3c90*/ void Disable();
            /*0x79f3e28*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x79f3eb4*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator();
            /*0x79f3f48*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x79f3f4c*/ void MarkAsDirty();
            /*0x79f3f50*/ bool IsEmpty();
            /*0x79f3fc0*/ void OnWantToChangeSetup();
            /*0x79f42c0*/ void OnSetupChanged();
            /*0x79f2280*/ void ReResolveIfNecessary(bool fullResolve);
            /*0x79f4528*/ void ResolveBindingsIfNecessary();
            /*0x79f45c8*/ void OnDestroy();

            struct WriteFileJson
            {
                /*0x10*/ string name;
                /*0x18*/ UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;
                /*0x20*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;
            }

            struct WriteFileJsonNoName
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;
                /*0x18*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;
            }

            struct ReadFileJson
            {
                /*0x10*/ string name;
                /*0x18*/ UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;
                /*0x20*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;

                /*0x79f2e60*/ void ToAsset(UnityEngine.InputSystem.InputActionAsset asset);
            }

            class <GetEnumerator>d__32 : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.InputSystem.InputAction <>2__current;
                /*0x20*/ UnityEngine.InputSystem.InputActionAsset <>4__this;
                /*0x28*/ int <i>5__2;
                /*0x30*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> <actions>5__3;
                /*0x40*/ int <actionCount>5__4;
                /*0x44*/ int <n>5__5;

                /*0x79f3f20*/ <GetEnumerator>d__32(int <>1__state);
                /*0x79f5630*/ void System.IDisposable.Dispose();
                /*0x79f5634*/ bool MoveNext();
                /*0x79f57c8*/ UnityEngine.InputSystem.InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current();
                /*0x79f57d0*/ void System.Collections.IEnumerator.Reset();
                /*0x79f5808*/ object System.Collections.IEnumerator.get_Current();
            }

            class <get_bindings>d__9 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.InputSystem.InputBinding <>2__current;
                /*0x70*/ int <>l__initialThreadId;
                /*0x78*/ UnityEngine.InputSystem.InputActionAsset <>4__this;
                /*0x80*/ int <numActionMaps>5__2;
                /*0x84*/ int <i>5__3;
                /*0x88*/ UnityEngine.InputSystem.InputBinding[] <bindings>5__4;
                /*0x90*/ int <numBindings>5__5;
                /*0x94*/ int <n>5__6;

                /*0x79f20f4*/ <get_bindings>d__9(int <>1__state);
                /*0x79f5810*/ void System.IDisposable.Dispose();
                /*0x79f5814*/ bool MoveNext();
                /*0x79f5994*/ UnityEngine.InputSystem.InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current();
                /*0x79f59a4*/ void System.Collections.IEnumerator.Reset();
                /*0x79f59dc*/ object System.Collections.IEnumerator.get_Current();
                /*0x79f5a40*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator();
                /*0x79f5ae4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        enum InputActionChange
        {
            ActionEnabled = 0,
            ActionDisabled = 1,
            ActionMapEnabled = 2,
            ActionMapDisabled = 3,
            ActionStarted = 4,
            ActionPerformed = 5,
            ActionCanceled = 6,
            BoundControlsAboutToChange = 7,
            BoundControlsChanged = 8,
        }

        class InputActionMap : System.ICloneable, UnityEngine.ISerializationCallbackReceiver, UnityEngine.InputSystem.IInputActionCollection2, UnityEngine.InputSystem.IInputActionCollection, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable, System.IDisposable
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_ResolveBindingsProfilerMarker;
            static /*0x8*/ int s_DeferBindingResolution;
            static /*0xc*/ bool s_NeedToResolveBindings;
            /*0x10*/ string m_Name;
            /*0x18*/ string m_Id;
            /*0x20*/ UnityEngine.InputSystem.InputActionAsset m_Asset;
            /*0x28*/ UnityEngine.InputSystem.InputAction[] m_Actions;
            /*0x30*/ UnityEngine.InputSystem.InputBinding[] m_Bindings;
            /*0x38*/ UnityEngine.InputSystem.InputBinding[] m_BindingsForEachAction;
            /*0x40*/ UnityEngine.InputSystem.InputControl[] m_ControlsForEachAction;
            /*0x48*/ int m_EnabledActionsCount;
            /*0x50*/ UnityEngine.InputSystem.InputAction m_SingletonAction;
            /*0x58*/ int m_MapIndexInState;
            /*0x60*/ UnityEngine.InputSystem.InputActionState m_State;
            /*0x68*/ System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;
            /*0xc8*/ UnityEngine.InputSystem.InputActionMap.Flags m_Flags;
            /*0xcc*/ int m_ParameterOverridesCount;
            /*0xd0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;
            /*0xd8*/ UnityEngine.InputSystem.InputActionMap.DeviceArray m_Devices;
            /*0xe8*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionCallbacks;
            /*0x138*/ System.Collections.Generic.Dictionary<string, int> m_ActionIndexByNameOrId;

            static /*0x79f823c*/ InputActionMap();
            static /*0x79f7ecc*/ UnityEngine.InputSystem.InputActionMap[] FromJson(string json);
            static /*0x79f7f7c*/ string ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps);
            /*0x79f0ed8*/ InputActionMap();
            /*0x79f5ff4*/ InputActionMap(string name);
            /*0x79f5ae8*/ string get_name();
            /*0x79f5af0*/ UnityEngine.InputSystem.InputActionAsset get_asset();
            /*0x79f5af8*/ System.Guid get_id();
            /*0x79f34c0*/ System.Guid get_idDontGenerate();
            /*0x79f2008*/ bool get_enabled();
            /*0x79f5768*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions();
            /*0x79f5b84*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x79f5be4*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings();
            /*0x79f5c48*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x79f5ccc*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x79f5cdc*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x79f1080*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            /*0x79f5e24*/ void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            /*0x79f5e68*/ UnityEngine.InputSystem.InputAction get_Item(string actionNameOrId);
            /*0x79f5f44*/ void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79f5f9c*/ void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79f6020*/ void Dispose();
            /*0x79f6034*/ int FindActionIndex(string nameOrId);
            /*0x79f6238*/ void SetUpActionLookupTable();
            /*0x79f636c*/ void ClearActionLookupTable();
            /*0x79f63c4*/ int FindActionIndex(System.Guid id);
            /*0x79f2ffc*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            /*0x79f3610*/ UnityEngine.InputSystem.InputAction FindAction(System.Guid id);
            /*0x79f39cc*/ bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x79f3c44*/ void Enable();
            /*0x79f3df4*/ void Disable();
            /*0x79f6458*/ UnityEngine.InputSystem.InputActionMap Clone();
            /*0x79f66b4*/ object System.ICloneable.Clone();
            /*0x79f66b8*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x79f66e4*/ string ToString();
            /*0x79f67ac*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator();
            /*0x79f6850*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x79f6854*/ bool get_needToResolveBindings();
            /*0x79f6860*/ void set_needToResolveBindings(bool value);
            /*0x79f6870*/ bool get_bindingResolutionNeedsFullReResolve();
            /*0x79f687c*/ void set_bindingResolutionNeedsFullReResolve(bool value);
            /*0x79f689c*/ bool get_controlsForEachActionInitialized();
            /*0x79f68a8*/ void set_controlsForEachActionInitialized(bool value);
            /*0x79f68c8*/ bool get_bindingsForEachActionInitialized();
            /*0x79f68d4*/ void set_bindingsForEachActionInitialized(bool value);
            /*0x79ef7b4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x79ef8ac*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x79f68f4*/ void SetUpPerActionControlAndBindingArrays();
            /*0x79f4040*/ void OnWantToChangeSetup();
            /*0x79f434c*/ void OnSetupChanged();
            /*0x79f6ff8*/ void OnBindingModified();
            /*0x79f6f94*/ void ClearCachedActionData(bool onlyControls);
            /*0x79f5b40*/ void GenerateId();
            /*0x79ef694*/ bool LazyResolveBindings(bool fullResolve);
            /*0x79ef878*/ bool ResolveBindingsIfNecessary();
            /*0x79f7018*/ void ResolveBindings();
            /*0x79f3208*/ int FindBinding(UnityEngine.InputSystem.InputBinding mask, ref UnityEngine.InputSystem.InputAction action);
            /*0x79f7e14*/ int FindBindingRelativeToMap(UnityEngine.InputSystem.InputBinding mask);
            /*0x79f8030*/ string ToJson();
            /*0x79f8150*/ void OnBeforeSerialize();
            /*0x79f8154*/ void OnAfterDeserialize();

            enum Flags
            {
                NeedToResolveBindings = 1,
                BindingResolutionNeedsFullReResolve = 2,
                ControlsForEachActionInitialized = 4,
                BindingsForEachActionInitialized = 8,
            }

            struct DeviceArray
            {
                /*0x10*/ bool m_HaveValue;
                /*0x14*/ int m_DeviceCount;
                /*0x18*/ UnityEngine.InputSystem.InputDevice[] m_DeviceArray;

                /*0x79f82b0*/ int IndexOf(UnityEngine.InputSystem.InputDevice device);
                /*0x79f830c*/ bool Remove(UnityEngine.InputSystem.InputDevice device);
                /*0x79f22f4*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get();
                /*0x79f23e0*/ bool Set(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> devices);
            }

            struct BindingOverrideListJson
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> bindings;
            }

            struct BindingOverrideJson
            {
                /*0x10*/ string action;
                /*0x18*/ string id;
                /*0x20*/ string path;
                /*0x28*/ string interactions;
                /*0x30*/ string processors;

                static /*0x79f8380*/ UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding, string actionName);
                static /*0x79f849c*/ UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding);
                static /*0x79f84f0*/ UnityEngine.InputSystem.InputBinding ToBinding(UnityEngine.InputSystem.InputActionMap.BindingOverrideJson bindingOverride);
            }

            struct BindingJson
            {
                /*0x10*/ string name;
                /*0x18*/ string id;
                /*0x20*/ string path;
                /*0x28*/ string interactions;
                /*0x30*/ string processors;
                /*0x38*/ string groups;
                /*0x40*/ string action;
                /*0x48*/ bool isComposite;
                /*0x49*/ bool isPartOfComposite;

                static /*0x79f8754*/ UnityEngine.InputSystem.InputActionMap.BindingJson FromBinding(ref UnityEngine.InputSystem.InputBinding binding);
                /*0x79f85e8*/ UnityEngine.InputSystem.InputBinding ToBinding();
            }

            struct ReadActionJson
            {
                /*0x10*/ string name;
                /*0x18*/ string type;
                /*0x20*/ string id;
                /*0x28*/ string expectedControlType;
                /*0x30*/ string expectedControlLayout;
                /*0x38*/ string processors;
                /*0x40*/ string interactions;
                /*0x48*/ bool passThrough;
                /*0x49*/ bool initialStateCheck;
                /*0x50*/ UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;

                /*0x79f884c*/ UnityEngine.InputSystem.InputAction ToAction(string actionName);
            }

            struct WriteActionJson
            {
                /*0x10*/ string name;
                /*0x18*/ string type;
                /*0x20*/ string id;
                /*0x28*/ string expectedControlType;
                /*0x30*/ string processors;
                /*0x38*/ string interactions;
                /*0x40*/ bool initialStateCheck;

                static /*0x79f8ab0*/ UnityEngine.InputSystem.InputActionMap.WriteActionJson FromAction(UnityEngine.InputSystem.InputAction action);
            }

            struct ReadMapJson
            {
                /*0x10*/ string name;
                /*0x18*/ string id;
                /*0x20*/ UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;
                /*0x28*/ UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;
            }

            struct WriteMapJson
            {
                /*0x10*/ string name;
                /*0x18*/ string id;
                /*0x20*/ UnityEngine.InputSystem.InputActionMap.WriteActionJson[] actions;
                /*0x28*/ UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;

                static /*0x79f8bd4*/ UnityEngine.InputSystem.InputActionMap.WriteMapJson FromMap(UnityEngine.InputSystem.InputActionMap map);
            }

            struct WriteFileJson
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;

                static /*0x79f80a0*/ UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMap(UnityEngine.InputSystem.InputActionMap map);
                static /*0x79f29dc*/ UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMaps(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps);
            }

            struct ReadFileJson
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;
                /*0x18*/ UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;

                /*0x79f4608*/ UnityEngine.InputSystem.InputActionMap[] ToMaps();
            }
        }

        class InputActionRebindingExtensions
        {
            static /*0x0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;

            static /*0x79f8e30*/ System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, string name, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79f903c*/ System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride);
            static /*0x79f944c*/ System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, string name, int bindingIndex);
            static /*0x3910ae8*/ System.Nullable<TValue> GetParameterValue<TObject, TValue>(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3910ae8*/ void ApplyParameterOverride<TObject, TValue>(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3910ae8*/ void ApplyParameterOverride<TObject, TValue>(UnityEngine.InputSystem.InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3910ae8*/ void ApplyParameterOverride<TObject, TValue>(UnityEngine.InputSystem.InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3910ae8*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride<TObject, TValue>(System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
            static /*0x79f9658*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputActionMap actionMap, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79f9bf8*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputActionAsset asset, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79f9d88*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79f9eec*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, int bindingIndex);
            static /*0x79f979c*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputActionState state, int mapIndex, ref UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride);
            static /*0x79fa298*/ int GetBindingIndex(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79fa3ac*/ int GetBindingIndex(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79fa4c0*/ int GetBindingIndex(UnityEngine.InputSystem.InputAction action, string group, string path);
            static /*0x79fa57c*/ System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79fa6ec*/ int GetBindingIndexForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79fa890*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, string group);
            static /*0x79fa9f0*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options);
            static /*0x79fabf0*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, int bindingIndex, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options);
            static /*0x79fac64*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, int bindingIndex, ref string deviceLayoutName, ref string controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options);
            static /*0x79fb224*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, string newPath, string group, string path);
            static /*0x79fb314*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79fb590*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, int bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79fb814*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, int bindingIndex, string path);
            static /*0x79fb418*/ int ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79fb654*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, int bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79fb8f0*/ void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, int bindingIndex);
            static /*0x79fb96c*/ void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79fba28*/ void RemoveBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79fbae4*/ void RemoveAllBindingOverrides(UnityEngine.InputSystem.IInputActionCollection2 actions);
            static /*0x79fc014*/ void RemoveAllBindingOverrides(UnityEngine.InputSystem.InputAction action);
            static /*0x79fc184*/ void ApplyBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides);
            static /*0x79fc500*/ void RemoveBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides);
            static /*0x79fc87c*/ int ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79fc9d0*/ int ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputControl control);
            static /*0x79fcaec*/ string SaveBindingOverridesAsJson(UnityEngine.InputSystem.IInputActionCollection2 actions);
            static /*0x79fd1bc*/ string SaveBindingOverridesAsJson(UnityEngine.InputSystem.InputAction action);
            static /*0x79fcf8c*/ void AddBindingOverrideJsonTo(UnityEngine.InputSystem.IInputActionCollection2 actions, UnityEngine.InputSystem.InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, UnityEngine.InputSystem.InputAction action);
            static /*0x79fd4ec*/ void LoadBindingOverridesFromJson(UnityEngine.InputSystem.IInputActionCollection2 actions, string json, bool removeExisting);
            static /*0x79fda58*/ void LoadBindingOverridesFromJson(UnityEngine.InputSystem.InputAction action, string json, bool removeExisting);
            static /*0x79fd6b8*/ void LoadBindingOverridesFromJsonInternal(UnityEngine.InputSystem.IInputActionCollection2 actions, string json);
            static /*0x79fdc38*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(UnityEngine.InputSystem.InputAction action, int bindingIndex);
            static /*0x79f7d5c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution();

            struct Parameter
            {
                /*0x10*/ object instance;
                /*0x18*/ System.Reflection.FieldInfo field;
                /*0x20*/ int bindingIndex;
            }

            struct ParameterEnumerable : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>, System.Collections.IEnumerable
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
                /*0x18*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride m_Parameter;
                /*0x90*/ int m_MapIndex;

                /*0x79f9278*/ ParameterEnumerable(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex);
                /*0x79f92cc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterEnumerator GetEnumerator();
                /*0x79feb48*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator();
                /*0x79fec00*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            struct ParameterEnumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
                /*0x18*/ int m_MapIndex;
                /*0x1c*/ int m_BindingCurrentIndex;
                /*0x20*/ int m_BindingEndIndex;
                /*0x24*/ int m_InteractionCurrentIndex;
                /*0x28*/ int m_InteractionEndIndex;
                /*0x2c*/ int m_ProcessorCurrentIndex;
                /*0x30*/ int m_ProcessorEndIndex;
                /*0x38*/ UnityEngine.InputSystem.InputBinding m_BindingMask;
                /*0x90*/ System.Type m_ObjectType;
                /*0x98*/ string m_ParameterName;
                /*0xa0*/ bool m_MayBeInteraction;
                /*0xa1*/ bool m_MayBeProcessor;
                /*0xa2*/ bool m_MayBeComposite;
                /*0xa3*/ bool m_CurrentBindingIsComposite;
                /*0xa8*/ object m_CurrentObject;
                /*0xb0*/ System.Reflection.FieldInfo m_CurrentParameter;

                /*0x79fe8e0*/ ParameterEnumerator(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex);
                /*0x79fee54*/ bool MoveToNextBinding();
                /*0x79ff010*/ bool MoveToNextInteraction();
                /*0x79ff15c*/ bool MoveToNextProcessor();
                /*0x79ff080*/ bool FindParameter(object instance);
                /*0x79f9398*/ bool MoveNext();
                /*0x79fed6c*/ void Reset();
                /*0x79f932c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter get_Current();
                /*0x79ff1cc*/ object System.Collections.IEnumerator.get_Current();
                /*0x79ff23c*/ void Dispose();
            }

            struct ParameterOverride
            {
                /*0x10*/ string objectRegistrationName;
                /*0x18*/ string parameter;
                /*0x20*/ UnityEngine.InputSystem.InputBinding bindingMask;
                /*0x78*/ UnityEngine.InputSystem.Utilities.PrimitiveValue value;

                static /*0x79fa0f0*/ System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionMap actionMap, ref UnityEngine.InputSystem.InputBinding binding, string parameterName, string objectRegistrationName);
                static /*0x79ff2ac*/ System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] overrides, int overrideCount, ref UnityEngine.InputSystem.InputBinding binding, string parameterName, string objectRegistrationName);
                static /*0x79ff4c8*/ System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> PickMoreSpecificOne(System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> first, System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> second);
                /*0x79f8f5c*/ ParameterOverride(string parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x79ff240*/ ParameterOverride(string objectRegistrationName, string parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x79fecb8*/ System.Type get_objectType();
            }

            class RebindingOperation : System.IDisposable
            {
                static float kDefaultMagnitudeThreshold = 0.20000000298023224;
                /*0x10*/ UnityEngine.InputSystem.InputAction m_ActionToRebind;
                /*0x18*/ System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;
                /*0x78*/ System.Type m_ControlType;
                /*0x80*/ UnityEngine.InputSystem.Utilities.InternedString m_ExpectedLayout;
                /*0x90*/ int m_IncludePathCount;
                /*0x98*/ string[] m_IncludePaths;
                /*0xa0*/ int m_ExcludePathCount;
                /*0xa8*/ string[] m_ExcludePaths;
                /*0xb0*/ int m_TargetBindingIndex;
                /*0xb8*/ string m_BindingGroupForNewBinding;
                /*0xc0*/ string m_CancelBinding;
                /*0xc8*/ float m_MagnitudeThreshold;
                /*0xd0*/ float[] m_Scores;
                /*0xd8*/ float[] m_Magnitudes;
                /*0xe0*/ double m_LastMatchTime;
                /*0xe8*/ double m_StartTime;
                /*0xf0*/ float m_Timeout;
                /*0xf4*/ float m_WaitSecondsAfterMatch;
                /*0xf8*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Candidates;
                /*0x118*/ System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnComplete;
                /*0x120*/ System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnCancel;
                /*0x128*/ System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnPotentialMatch;
                /*0x130*/ System.Func<UnityEngine.InputSystem.InputControl, string> m_OnGeneratePath;
                /*0x138*/ System.Func<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr, float> m_OnComputeScore;
                /*0x140*/ System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation, string> m_OnApplyBinding;
                /*0x148*/ System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> m_OnEventDelegate;
                /*0x150*/ System.Action m_OnAfterUpdateDelegate;
                /*0x158*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Cache m_LayoutCache;
                /*0x160*/ System.Text.StringBuilder m_PathBuilder;
                /*0x168*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags m_Flags;
                /*0x170*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputControl, float> m_StartingActuations;

                static /*0x7a013ec*/ bool HavePathMatch(UnityEngine.InputSystem.InputControl control, string[] paths, int pathCount);
                /*0x79fe000*/ RebindingOperation();
                /*0x79ff748*/ UnityEngine.InputSystem.InputAction get_action();
                /*0x79ff750*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
                /*0x79ff760*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates();
                /*0x79ff774*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<float> get_scores();
                /*0x79ff7e8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<float> get_magnitudes();
                /*0x79ff85c*/ UnityEngine.InputSystem.InputControl get_selectedControl();
                /*0x79ff8cc*/ bool get_started();
                /*0x79ff8d8*/ bool get_completed();
                /*0x79ff8e4*/ bool get_canceled();
                /*0x79ff8f0*/ double get_startTime();
                /*0x79ff8f8*/ float get_timeout();
                /*0x79fe37c*/ string get_expectedControlType();
                /*0x79fe09c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithAction(UnityEngine.InputSystem.InputAction action);
                /*0x79fe33c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMatchingEventsBeingSuppressed(bool value);
                /*0x79fe38c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(string binding);
                /*0x79ff9b0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(UnityEngine.InputSystem.InputControl control);
                /*0x79ff95c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(string layoutName);
                /*0x79ffa48*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(System.Type type);
                /*0x38148bc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType<TControl>();
                /*0x79fe3c0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTargetBinding(int bindingIndex);
                /*0x79ffcd8*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask);
                /*0x79ffd04*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingGroup(string group);
                /*0x79ffdd4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutGeneralizingPathOfSelectedControl();
                /*0x79ffde4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithRebindAddingNewBinding(string group);
                /*0x79ffe0c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude);
                /*0x79ffed0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutIgnoringNoisyControls();
                /*0x79ffbb0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsHavingToMatchPath(string path);
                /*0x79fe214*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsExcluding(string path);
                /*0x79ffef4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTimeout(float timeInSeconds);
                /*0x79ffefc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback);
                /*0x79fff1c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback);
                /*0x79fff3c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback);
                /*0x79fff5c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl, string> callback);
                /*0x79fff7c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr, float> callback);
                /*0x79fff9c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation, string> callback);
                /*0x79fe20c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnMatchWaitForAnother(float seconds);
                /*0x79fffbc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Start();
                /*0x7a002e4*/ void Cancel();
                /*0x7a00330*/ void Complete();
                /*0x7a00644*/ void AddCandidate(UnityEngine.InputSystem.InputControl control, float score, float magnitude);
                /*0x7a008e8*/ void RemoveCandidate(UnityEngine.InputSystem.InputControl control);
                /*0x7a00a04*/ void Dispose();
                /*0x7a00b64*/ void Finalize();
                /*0x7a00bf8*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Reset();
                /*0x7a001f4*/ void HookOnEvent();
                /*0x7a00a68*/ void UnhookOnEvent();
                /*0x7a00ce4*/ void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                /*0x7a007b8*/ void SortCandidatesByScore();
                /*0x7a00118*/ void HookOnAfterUpdate();
                /*0x7a00af0*/ void UnhookOnAfterUpdate();
                /*0x7a0147c*/ void OnAfterUpdate();
                /*0x7a00340*/ void OnComplete();
                /*0x7a002f4*/ void OnCancel();
                /*0x7a01634*/ void ResetAfterMatchCompleted();
                /*0x79ff900*/ void ThrowIfRebindInProgress();
                /*0x7a01524*/ string GeneratePathForControl(UnityEngine.InputSystem.InputControl control);

                enum Flags
                {
                    Started = 1,
                    Completed = 2,
                    Canceled = 4,
                    OnEventHooked = 8,
                    OnAfterUpdateHooked = 16,
                    DontIgnoreNoisyControls = 64,
                    DontGeneralizePathOfSelectedControl = 128,
                    AddNewBinding = 256,
                    SuppressMatchingEvents = 512,
                }

                class <>c__DisplayClass32_0
                {
                    /*0x10*/ string group;

                    /*0x7a05154*/ <>c__DisplayClass32_0();
                    /*0x7a0515c*/ bool <WithTargetBinding>b__0(UnityEngine.InputSystem.InputControlScheme x);
                }
            }

            class DeferBindingResolutionWrapper : System.IDisposable
            {
                /*0x7a055e0*/ DeferBindingResolutionWrapper();
                /*0x7a05180*/ void Acquire();
                /*0x7a051e0*/ void Dispose();
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> bindings;
                /*0x20*/ int firstPartIndex;
                /*0x28*/ string[] partStrings;
                /*0x30*/ int partCount;

                /*0x7a055e8*/ <>c__DisplayClass25_0();
                /*0x7a055f0*/ string <GetBindingDisplayString>b__0(string fragment);
            }
        }

        enum InputActionPhase
        {
            Disabled = 0,
            Waiting = 1,
            Started = 2,
            Performed = 3,
            Canceled = 4,
        }

        struct InputActionProperty : System.IEquatable<UnityEngine.InputSystem.InputActionProperty>, System.IEquatable<UnityEngine.InputSystem.InputAction>, System.IEquatable<UnityEngine.InputSystem.InputActionReference>
        {
            /*0x10*/ bool m_UseReference;
            /*0x18*/ UnityEngine.InputSystem.InputAction m_Action;
            /*0x20*/ UnityEngine.InputSystem.InputActionReference m_Reference;

            static /*0x7a05bbc*/ bool op_Equality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right);
            static /*0x7a05bec*/ bool op_Inequality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right);
            /*0x7a058c4*/ InputActionProperty(UnityEngine.InputSystem.InputAction action);
            /*0x7a058ec*/ InputActionProperty(UnityEngine.InputSystem.InputActionReference reference);
            /*0x7a05744*/ UnityEngine.InputSystem.InputAction get_action();
            /*0x7a0589c*/ UnityEngine.InputSystem.InputActionReference get_reference();
            /*0x7a058b4*/ UnityEngine.InputSystem.InputAction get_serializedAction();
            /*0x7a058bc*/ UnityEngine.InputSystem.InputActionReference get_serializedReference();
            /*0x7a05928*/ bool Equals(UnityEngine.InputSystem.InputActionProperty other);
            /*0x7a059cc*/ bool Equals(UnityEngine.InputSystem.InputAction other);
            /*0x7a059e8*/ bool Equals(UnityEngine.InputSystem.InputActionReference other);
            /*0x7a05a54*/ bool Equals(object obj);
            /*0x7a05b20*/ int GetHashCode();
        }

        class InputActionReference : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.InputSystem.InputActionAsset m_Asset;
            /*0x20*/ string m_ActionId;
            /*0x28*/ UnityEngine.InputSystem.InputAction m_Action;

            static /*0x7a060dc*/ string GetDisplayName(UnityEngine.InputSystem.InputAction action);
            static /*0x7a0645c*/ UnityEngine.InputSystem.InputAction op_Implicit(UnityEngine.InputSystem.InputActionReference reference);
            static /*0x7a06468*/ UnityEngine.InputSystem.InputActionReference Create(UnityEngine.InputSystem.InputAction action);
            static /*0x7a064d4*/ void ResetCachedAction();
            /*0x7a065ec*/ InputActionReference();
            /*0x7a05c20*/ UnityEngine.InputSystem.InputActionAsset get_asset();
            /*0x7a057d8*/ UnityEngine.InputSystem.InputAction get_action();
            /*0x7a05c28*/ void Set(UnityEngine.InputSystem.InputAction action);
            /*0x7a05ec4*/ void Set(UnityEngine.InputSystem.InputActionAsset asset, string mapName, string actionName);
            /*0x7a05d40*/ void SetInternal(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputAction action);
            /*0x7a061a0*/ string ToString();
            /*0x7a06420*/ string ToDisplayName();
            /*0x7a065e8*/ UnityEngine.InputSystem.InputAction ToInputAction();
        }

        class InputActionSetupExtensions
        {
            static /*0x7a065f4*/ UnityEngine.InputSystem.InputActionMap AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, string name);
            static /*0x7a067b4*/ void AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map);
            static /*0x7a06a0c*/ void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map);
            static /*0x7a06b80*/ void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, string nameOrId);
            static /*0x7a06c94*/ UnityEngine.InputSystem.InputAction AddAction(UnityEngine.InputSystem.InputActionMap map, string name, UnityEngine.InputSystem.InputActionType type, string binding, string interactions, string processors, string groups, string expectedControlLayout);
            static /*0x7a070f8*/ void RemoveAction(UnityEngine.InputSystem.InputAction action);
            static /*0x7a074c8*/ void RemoveAction(UnityEngine.InputSystem.InputActionAsset asset, string nameOrId);
            static /*0x7a07028*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, string path, string interactions, string processors, string groups);
            static /*0x7a076c4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x7a075d4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding binding);
            static /*0x7a07920*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, string path, string interactions, string groups, string action, string processors);
            static /*0x7a07b98*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, string path, UnityEngine.InputSystem.InputAction action, string interactions, string groups);
            static /*0x7a07cbc*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, string path, System.Guid action, string interactions, string groups);
            static /*0x7a07a80*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding binding);
            static /*0x7a07db0*/ UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(UnityEngine.InputSystem.InputAction action, string composite, string interactions, string processors);
            static /*0x7a07768*/ int AddBindingInternal(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputBinding binding, int bindingIndex);
            static /*0x7a08050*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, int index);
            static /*0x7a08104*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, string name);
            static /*0x7a08304*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputActionMap actionMap, int index);
            static /*0x7a08418*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, string id);
            static /*0x7a084ec*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, System.Guid id);
            static /*0x7a0860c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(UnityEngine.InputSystem.InputAction action, string group);
            static /*0x7a086e0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(UnityEngine.InputSystem.InputAction action, string path);
            static /*0x7a08178*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding match);
            static /*0x7a087b4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(UnityEngine.InputSystem.InputAction action, string compositeName);
            static /*0x7a089f8*/ void Rename(UnityEngine.InputSystem.InputAction action, string newName);
            static /*0x7a08c84*/ void AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputControlScheme controlScheme);
            static /*0x7a08f4c*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, string name);
            static /*0x7a090f8*/ void RemoveControlScheme(UnityEngine.InputSystem.InputActionAsset asset, string name);
            static /*0x7a0922c*/ UnityEngine.InputSystem.InputControlScheme WithBindingGroup(UnityEngine.InputSystem.InputControlScheme scheme, string bindingGroup);
            static /*0x7a0952c*/ UnityEngine.InputSystem.InputControlScheme WithDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath, bool required);
            static /*0x7a096c4*/ UnityEngine.InputSystem.InputControlScheme WithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);
            static /*0x7a09780*/ UnityEngine.InputSystem.InputControlScheme WithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);
            static /*0x7a0983c*/ UnityEngine.InputSystem.InputControlScheme OrWithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);
            static /*0x7a0992c*/ UnityEngine.InputSystem.InputControlScheme OrWithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);

            struct BindingSyntax
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap m_ActionMap;
                /*0x18*/ UnityEngine.InputSystem.InputAction m_Action;
                /*0x20*/ int m_BindingIndexInMap;

                /*0x7a078e8*/ BindingSyntax(UnityEngine.InputSystem.InputActionMap map, int bindingIndexInMap, UnityEngine.InputSystem.InputAction action);
                /*0x7a09a1c*/ bool get_valid();
                /*0x7a09a88*/ int get_bindingIndex();
                /*0x7a09ac0*/ UnityEngine.InputSystem.InputBinding get_binding();
                /*0x7a09b68*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithName(string name);
                /*0x7a09c34*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithPath(string path);
                /*0x7a09d00*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroup(string group);
                /*0x7a09e9c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroups(string groups);
                /*0x7a0a064*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction(string interaction);
                /*0x7a0a200*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteractions(string interactions);
                /*0x3910ae8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction<TInteraction>();
                /*0x7a0a3c8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor(string processor);
                /*0x7a0a564*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessors(string processors);
                /*0x3910ae8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor<TProcessor>();
                /*0x7a0a72c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Triggering(UnityEngine.InputSystem.InputAction action);
                /*0x7a0a8a8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax To(UnityEngine.InputSystem.InputBinding binding);
                /*0x7a0a9f4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextBinding();
                /*0x7a0ab0c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousBinding();
                /*0x7a0ab40*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextPartBinding(string partName);
                /*0x7a0acf0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousPartBinding(string partName);
                /*0x7a0ad94*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextCompositeBinding(string compositeName);
                /*0x7a0aeb8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousCompositeBinding(string compositeName);
                /*0x7a0aa28*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Iterate(bool next);
                /*0x7a0adcc*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IterateCompositeBinding(bool next, string compositeName);
                /*0x7a0abe4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IteratePartBinding(bool next, string partName);
                /*0x7a0aefc*/ void Erase();
                /*0x7a0b0a4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax InsertPartBinding(string partName, string path);
            }

            struct CompositeSyntax
            {
                /*0x10*/ UnityEngine.InputSystem.InputAction m_Action;
                /*0x18*/ UnityEngine.InputSystem.InputActionMap m_ActionMap;
                /*0x20*/ int m_BindingIndexInMap;

                /*0x7a07fcc*/ CompositeSyntax(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputAction action, int compositeIndex);
                /*0x7a0b2a8*/ int get_bindingIndex();
                /*0x7a0b2d4*/ UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax With(string name, string binding, string groups, string processors);
            }

            struct ControlSchemeSyntax
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionAsset m_Asset;
                /*0x18*/ int m_ControlSchemeIndex;
                /*0x20*/ UnityEngine.InputSystem.InputControlScheme m_ControlScheme;

                /*0x7a090c8*/ ControlSchemeSyntax(UnityEngine.InputSystem.InputActionAsset asset, int index);
                /*0x7a092fc*/ ControlSchemeSyntax(UnityEngine.InputSystem.InputControlScheme controlScheme);
                /*0x7a09344*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithBindingGroup(string bindingGroup);
                /*0x3910ae8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice<TDevice>();
                /*0x3910ae8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice<TDevice>();
                /*0x3910ae8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice<TDevice>();
                /*0x3910ae8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice<TDevice>();
                /*0x7a0965c*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice(string controlPath);
                /*0x7a09690*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice(string controlPath);
                /*0x7a098f8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice(string controlPath);
                /*0x7a099e8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice(string controlPath);
                /*0x38148bc*/ string DeviceTypeToControlPath<TDevice>();
                /*0x7a0946c*/ UnityEngine.InputSystem.InputControlScheme Done();
                /*0x7a0b550*/ void AddDeviceEntry(string controlPath, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags flags);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.InputSystem.InputBinding binding;

                /*0x7a074c0*/ <>c__DisplayClass5_0();
                /*0x7a0b77c*/ bool <RemoveAction>b__0(UnityEngine.InputSystem.InputBinding b);
            }
        }

        class InputActionState : UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor, System.ICloneable, System.IDisposable
        {
            static int kInvalidIndex = -1;
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_InputInitialActionStateCheckMarker;
            static /*0x8*/ Unity.Profiling.ProfilerMarker k_InputActionResolveConflictMarker;
            static /*0x10*/ Unity.Profiling.ProfilerMarker k_InputActionCallbackMarker;
            static /*0x18*/ Unity.Profiling.ProfilerMarker k_InputOnActionChangeMarker;
            static /*0x20*/ Unity.Profiling.ProfilerMarker k_InputOnDeviceChangeMarker;
            static /*0x28*/ UnityEngine.InputSystem.InputActionState.GlobalState s_GlobalState;
            /*0x10*/ UnityEngine.InputSystem.InputActionMap[] maps;
            /*0x18*/ UnityEngine.InputSystem.InputControl[] controls;
            /*0x20*/ UnityEngine.InputSystem.IInputInteraction[] interactions;
            /*0x28*/ UnityEngine.InputSystem.InputProcessor[] processors;
            /*0x30*/ UnityEngine.InputSystem.InputBindingComposite[] composites;
            /*0x38*/ int totalProcessorCount;
            /*0x40*/ UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory;
            /*0xc0*/ bool m_OnBeforeUpdateHooked;
            /*0xc1*/ bool m_OnAfterUpdateHooked;
            /*0xc2*/ bool m_InProcessControlStateChange;
            /*0xc8*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_CurrentlyProcessingThisEvent;
            /*0xd0*/ System.Action m_OnBeforeUpdateDelegate;
            /*0xd8*/ System.Action m_OnAfterUpdateDelegate;

            static /*0x7a12cc0*/ InputActionState();
            static /*0x7a0fa28*/ int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex);
            static /*0x7a0fa7c*/ bool ShouldIgnoreInputOnCompositeBinding(UnityEngine.InputSystem.InputActionState.BindingState* binding, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
            static /*0x7a1065c*/ bool IsActuated(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, float threshold);
            static /*0x7a11e08*/ UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState();
            static /*0x7a12020*/ void CompactGlobalList();
            static /*0x7a0e1b8*/ void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change, object actionOrMapOrAsset);
            static /*0x7a121d8*/ void ResetGlobals();
            static /*0x7a12508*/ int FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result);
            static /*0x7a127d4*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
            static /*0x7a052ac*/ void DeferredResolutionOfBindings();
            static /*0x7a12b3c*/ void DisableAllActions();
            static /*0x7a12348*/ void DestroyAllActionMapStates();
            /*0x7a0c2f0*/ InputActionState();
            /*0x7a0b7f4*/ int get_totalCompositeCount();
            /*0x7a0b7fc*/ int get_totalMapCount();
            /*0x7a0b804*/ int get_totalActionCount();
            /*0x7a0b80c*/ int get_totalBindingCount();
            /*0x7a0b814*/ int get_totalInteractionCount();
            /*0x7a0b81c*/ int get_totalControlCount();
            /*0x7a0b824*/ UnityEngine.InputSystem.InputActionState.ActionMapIndices* get_mapIndices();
            /*0x7a0b82c*/ UnityEngine.InputSystem.InputActionState.TriggerState* get_actionStates();
            /*0x7a0b834*/ UnityEngine.InputSystem.InputActionState.BindingState* get_bindingStates();
            /*0x7a0b83c*/ UnityEngine.InputSystem.InputActionState.InteractionState* get_interactionStates();
            /*0x7a0b844*/ int* get_controlIndexToBindingIndex();
            /*0x7a0b84c*/ ushort* get_controlGroupingAndComplexity();
            /*0x7a0b854*/ float* get_controlMagnitudes();
            /*0x7a0b85c*/ uint* get_enabledControls();
            /*0x7a0b864*/ bool get_isProcessingControlStateChange();
            /*0x7a0b86c*/ void Initialize(UnityEngine.InputSystem.InputBindingResolver resolver);
            /*0x7a0b9f8*/ void ComputeControlGroupingIfNecessary();
            /*0x7a0b8a8*/ void ClaimDataFrom(UnityEngine.InputSystem.InputBindingResolver resolver);
            /*0x7a0bbc4*/ void Finalize();
            /*0x7a0be00*/ void Dispose();
            /*0x7a0bc5c*/ void Destroy(bool isFinalizing);
            /*0x7a0c164*/ UnityEngine.InputSystem.InputActionState Clone();
            /*0x7a0c39c*/ object System.ICloneable.Clone();
            /*0x7a0c3a0*/ bool IsUsingDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a0c558*/ bool CanUseDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a0c770*/ bool HasEnabledActions();
            /*0x7a0c7e8*/ void FinishBindingCompositeSetups();
            /*0x7a0c8d0*/ void PrepareForBindingReResolution(bool needFullResolve, ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, ref bool hasEnabledActions);
            /*0x7a0d37c*/ void FinishBindingResolution(bool hasEnabledActions, UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve);
            /*0x7a0d404*/ void RestoreActionStatesAfterReResolvingBindings(UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve);
            /*0x7a0e2d0*/ bool IsActiveControl(int bindingIndex, int controlIndex);
            /*0x7a0dd34*/ int FindControlIndexOnBinding(int bindingIndex, UnityEngine.InputSystem.InputControl control);
            /*0x7a0e384*/ void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device);
            /*0x7a0e5c4*/ bool IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, int actionIndex);
            /*0x7a0d0d4*/ void ResetActionState(int actionIndex, UnityEngine.InputSystem.InputActionPhase toPhase, bool hardReset);
            /*0x7a0e9c0*/ ref UnityEngine.InputSystem.InputActionState.TriggerState FetchActionState(UnityEngine.InputSystem.InputAction action);
            /*0x7a0e9e4*/ UnityEngine.InputSystem.InputActionState.ActionMapIndices FetchMapIndices(UnityEngine.InputSystem.InputActionMap map);
            /*0x7a0ea18*/ void EnableAllActions(UnityEngine.InputSystem.InputActionMap map);
            /*0x7a0eb10*/ void EnableControls(UnityEngine.InputSystem.InputActionMap map);
            /*0x7a0eb50*/ void EnableSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x7a0ebf4*/ void EnableControls(UnityEngine.InputSystem.InputAction action);
            /*0x7a0cdcc*/ void DisableAllActions(UnityEngine.InputSystem.InputActionMap map);
            /*0x7a0d1f8*/ void DisableControls(UnityEngine.InputSystem.InputActionMap map);
            /*0x7a0eca4*/ void DisableSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x7a0ed3c*/ void DisableControls(UnityEngine.InputSystem.InputAction action);
            /*0x7a0dbac*/ void EnableControls(int mapIndex, int controlStartIndex, int numControls);
            /*0x7a0be08*/ void DisableControls(int mapIndex, int controlStartIndex, int numControls);
            /*0x7a0eebc*/ void SetInitialStateCheckPending(int actionIndex, bool value);
            /*0x7a0ee38*/ void SetInitialStateCheckPending(UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr, bool value);
            /*0x7a0edec*/ bool IsControlEnabled(int controlIndex);
            /*0x7a0ee84*/ void SetControlEnabled(int controlIndex, bool state);
            /*0x7a0e0d8*/ void HookOnBeforeUpdate();
            /*0x7a0ef50*/ void UnhookOnBeforeUpdate();
            /*0x7a0efcc*/ void OnBeforeInitialUpdate();
            /*0x7a0f1c8*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long mapControlAndBindingIndex);
            /*0x7a0f7e0*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex);
            /*0x7a0ee10*/ long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex);
            /*0x7a0f1e0*/ void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, ref int mapIndex, ref int controlIndex, ref int bindingIndex);
            /*0x7a0f1fc*/ void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a10090*/ void ProcessButtonState(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex, UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr);
            /*0x7a0fc80*/ bool IsConflictingInput(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex);
            /*0x7a0e674*/ ushort GetActionBindingStartIndexAndCount(int actionIndex, ref ushort bindingCount);
            /*0x7a10254*/ void ProcessDefaultInteraction(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex);
            /*0x7a0fac8*/ void ProcessInteractions(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int interactionStartIndex, int interactionCount);
            /*0x7a0f7f8*/ void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex);
            /*0x7a10714*/ void SetTotalTimeoutCompletionTime(float seconds, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x7a0df80*/ void StartTimeout(float seconds, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x7a10744*/ void StopTimeout(int interactionIndex);
            /*0x7a10808*/ void ChangePhaseOfInteraction(UnityEngine.InputSystem.InputActionPhase newPhase, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformed, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled, bool processNextInteractionOnCancel);
            /*0x7a0e738*/ bool ChangePhaseOfAction(UnityEngine.InputSystem.InputActionPhase newPhase, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformedOrCanceled);
            /*0x7a10cd4*/ void ChangePhaseOfActionInternal(int actionIndex, UnityEngine.InputSystem.InputActionState.TriggerState* actionState, UnityEngine.InputSystem.InputActionPhase newPhase, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, bool isDisablingAction);
            /*0x7a10fb0*/ void CallActionListeners(int actionIndex, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputActionPhase phase, ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> listeners, string callbackName);
            /*0x7a111d4*/ object GetActionOrNoneString(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x7a112cc*/ UnityEngine.InputSystem.InputAction GetActionOrNull(int bindingIndex);
            /*0x7a11238*/ UnityEngine.InputSystem.InputAction GetActionOrNull(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x7a11360*/ UnityEngine.InputSystem.InputControl GetControl(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x7a113a0*/ UnityEngine.InputSystem.IInputInteraction GetInteractionOrNull(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x7a113e8*/ int GetBindingIndexInMap(int bindingIndex);
            /*0x7a11424*/ int GetBindingIndexInState(int mapIndex, int bindingIndexInMap);
            /*0x7a1144c*/ ref UnityEngine.InputSystem.InputActionState.BindingState GetBindingState(int bindingIndex);
            /*0x7a1145c*/ ref UnityEngine.InputSystem.InputBinding GetBinding(int bindingIndex);
            /*0x7a114dc*/ UnityEngine.InputSystem.InputActionMap GetActionMap(int bindingIndex);
            /*0x7a0e694*/ void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled);
            /*0x7a0cf7c*/ void ResetInteractionState(int interactionIndex);
            /*0x7a1151c*/ int GetValueSizeInBytes(int bindingIndex, int controlIndex);
            /*0x7a115b0*/ System.Type GetValueType(int bindingIndex, int controlIndex);
            /*0x7a11644*/ void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites);
            /*0x3910ae8*/ TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites);
            /*0x3910ae8*/ TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType);
            /*0x7a117e8*/ float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber);
            /*0x7a118bc*/ double GetCompositePartPressTime(int bindingIndex, int partNumber);
            /*0x3910ae8*/ TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, ref int controlIndex, TComparer comparer);
            /*0x7a1193c*/ bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize);
            /*0x7a11a50*/ object ReadCompositePartValueAsObject(int bindingIndex, int partNumber);
            /*0x7a11b4c*/ object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites);
            /*0x7a11cd8*/ bool ReadValueAsButton(int bindingIndex, int controlIndex);
            /*0x7a0b964*/ void AddToGlobalList();
            /*0x7a0bf8c*/ void RemoveMapFromGlobalList();
            /*0x7a0d238*/ void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change);

            struct InteractionState
            {
                /*0x10*/ ushort m_TriggerControlIndex;
                /*0x12*/ byte m_Phase;
                /*0x13*/ byte m_Flags;
                /*0x14*/ float m_TimerDuration;
                /*0x18*/ double m_StartTime;
                /*0x20*/ double m_TimerStartTime;
                /*0x28*/ double m_PerformedTime;
                /*0x30*/ float m_TotalTimeoutCompletionTimeDone;
                /*0x34*/ float m_TotalTimeoutCompletionTimeRemaining;
                /*0x38*/ long m_TimerMonitorIndex;

                /*0x7a0cf68*/ int get_triggerControlIndex();
                /*0x7a0dea4*/ void set_triggerControlIndex(int value);
                /*0x7a12e24*/ double get_startTime();
                /*0x7a12e2c*/ void set_startTime(double value);
                /*0x7a12e34*/ double get_performedTime();
                /*0x7a12e3c*/ void set_performedTime(double value);
                /*0x7a12e44*/ double get_timerStartTime();
                /*0x7a12e4c*/ void set_timerStartTime(double value);
                /*0x7a12e54*/ float get_timerDuration();
                /*0x7a12e5c*/ void set_timerDuration(float value);
                /*0x7a12e64*/ float get_totalTimeoutCompletionDone();
                /*0x7a12e6c*/ void set_totalTimeoutCompletionDone(float value);
                /*0x7a12e74*/ float get_totalTimeoutCompletionTimeRemaining();
                /*0x7a12e7c*/ void set_totalTimeoutCompletionTimeRemaining(float value);
                /*0x7a12e84*/ long get_timerMonitorIndex();
                /*0x7a12e8c*/ void set_timerMonitorIndex(long value);
                /*0x7a0df14*/ bool get_isTimerRunning();
                /*0x7a10704*/ void set_isTimerRunning(bool value);
                /*0x7a12e94*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x7a0de9c*/ void set_phase(UnityEngine.InputSystem.InputActionPhase value);

                enum Flags
                {
                    TimerRunning = 1,
                }
            }

            struct BindingState
            {
                /*0x10*/ byte m_ControlCount;
                /*0x11*/ byte m_InteractionCount;
                /*0x12*/ byte m_ProcessorCount;
                /*0x13*/ byte m_MapIndex;
                /*0x14*/ byte m_Flags;
                /*0x15*/ byte m_PartIndex;
                /*0x16*/ ushort m_ActionIndex;
                /*0x18*/ ushort m_CompositeOrCompositeBindingIndex;
                /*0x1a*/ ushort m_ProcessorStartIndex;
                /*0x1c*/ ushort m_InteractionStartIndex;
                /*0x1e*/ ushort m_ControlStartIndex;
                /*0x20*/ double m_PressTime;
                /*0x28*/ int m_TriggerEventIdForComposite;
                /*0x2c*/ int __padding;

                /*0x7a12e9c*/ int get_controlStartIndex();
                /*0x7a12ea4*/ void set_controlStartIndex(int value);
                /*0x7a12f34*/ int get_controlCount();
                /*0x7a12f3c*/ void set_controlCount(int value);
                /*0x7a0cf54*/ int get_interactionStartIndex();
                /*0x7a12fcc*/ void set_interactionStartIndex(int value);
                /*0x7a1306c*/ int get_interactionCount();
                /*0x7a13074*/ void set_interactionCount(int value);
                /*0x7a117d4*/ int get_processorStartIndex();
                /*0x7a13104*/ void set_processorStartIndex(int value);
                /*0x7a131a4*/ int get_processorCount();
                /*0x7a131ac*/ void set_processorCount(int value);
                /*0x7a0db5c*/ int get_actionIndex();
                /*0x7a1323c*/ void set_actionIndex(int value);
                /*0x7a132dc*/ int get_mapIndex();
                /*0x7a132e4*/ void set_mapIndex(int value);
                /*0x7a0bbb0*/ int get_compositeOrCompositeBindingIndex();
                /*0x7a13374*/ void set_compositeOrCompositeBindingIndex(int value);
                /*0x7a13414*/ int get_triggerEventIdForComposite();
                /*0x7a1341c*/ void set_triggerEventIdForComposite(int value);
                /*0x7a13424*/ double get_pressTime();
                /*0x7a1342c*/ void set_pressTime(double value);
                /*0x7a13434*/ UnityEngine.InputSystem.InputActionState.BindingState.Flags get_flags();
                /*0x7a1343c*/ void set_flags(UnityEngine.InputSystem.InputActionState.BindingState.Flags value);
                /*0x7a13444*/ bool get_chainsWithNext();
                /*0x7a13450*/ void set_chainsWithNext(bool value);
                /*0x7a13460*/ bool get_isEndOfChain();
                /*0x7a1346c*/ void set_isEndOfChain(bool value);
                /*0x7a1348c*/ bool get_isPartOfChain();
                /*0x7a0c8b8*/ bool get_isComposite();
                /*0x7a1349c*/ void set_isComposite(bool value);
                /*0x7a0bba4*/ bool get_isPartOfComposite();
                /*0x7a134bc*/ void set_isPartOfComposite(bool value);
                /*0x7a0f1bc*/ bool get_initialStateCheckPending();
                /*0x7a0db8c*/ void set_initialStateCheckPending(bool value);
                /*0x7a0db80*/ bool get_wantsInitialStateCheck();
                /*0x7a134dc*/ void set_wantsInitialStateCheck(bool value);
                /*0x7a134fc*/ int get_partIndex();
                /*0x7a13504*/ void set_partIndex(int value);

                enum Flags
                {
                    ChainsWithNext = 1,
                    EndOfChain = 2,
                    Composite = 4,
                    PartOfComposite = 8,
                    InitialStateCheckPending = 16,
                    WantsInitialStateCheck = 32,
                }
            }

            struct TriggerState
            {
                static int kMaxNumMaps = 255;
                static int kMaxNumControls = 65535;
                static int kMaxNumBindings = 65535;
                /*0x10*/ byte m_Phase;
                /*0x11*/ byte m_Flags;
                /*0x12*/ byte m_MapIndex;
                /*0x14*/ ushort m_ControlIndex;
                /*0x18*/ double m_Time;
                /*0x20*/ double m_StartTime;
                /*0x28*/ ushort m_BindingIndex;
                /*0x2a*/ ushort m_InteractionIndex;
                /*0x2c*/ float m_Magnitude;
                /*0x30*/ uint m_LastPerformedInUpdate;
                /*0x34*/ uint m_LastCanceledInUpdate;
                /*0x38*/ uint m_PressedInUpdate;
                /*0x3c*/ uint m_ReleasedInUpdate;
                /*0x40*/ uint m_LastCompletedInUpdate;
                /*0x44*/ int m_Frame;

                /*0x7a1350c*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x7a0db54*/ void set_phase(UnityEngine.InputSystem.InputActionPhase value);
                /*0x7a0db70*/ bool get_isDisabled();
                /*0x7a13514*/ bool get_isWaiting();
                /*0x7a13524*/ bool get_isStarted();
                /*0x7a10cc4*/ bool get_isPerformed();
                /*0x7a13534*/ bool get_isCanceled();
                /*0x7a13544*/ double get_time();
                /*0x7a1354c*/ void set_time(double value);
                /*0x7a13554*/ double get_startTime();
                /*0x7a1355c*/ void set_startTime(double value);
                /*0x7a13564*/ float get_magnitude();
                /*0x7a0de04*/ void set_magnitude(float value);
                /*0x7a1356c*/ bool get_haveMagnitude();
                /*0x7a13578*/ int get_mapIndex();
                /*0x7a0df20*/ void set_mapIndex(int value);
                /*0x7a0cf40*/ int get_controlIndex();
                /*0x7a0dd94*/ void set_controlIndex(int value);
                /*0x7a13580*/ int get_bindingIndex();
                /*0x7a0daf4*/ void set_bindingIndex(int value);
                /*0x7a0de18*/ int get_interactionIndex();
                /*0x7a0de2c*/ void set_interactionIndex(int value);
                /*0x7a13588*/ uint get_lastPerformedInUpdate();
                /*0x7a13590*/ void set_lastPerformedInUpdate(uint value);
                /*0x7a13598*/ int get_frame();
                /*0x7a135a0*/ void set_frame(int value);
                /*0x7a135a8*/ uint get_lastCompletedInUpdate();
                /*0x7a135b0*/ void set_lastCompletedInUpdate(uint value);
                /*0x7a135b8*/ uint get_lastCanceledInUpdate();
                /*0x7a135c0*/ void set_lastCanceledInUpdate(uint value);
                /*0x7a135c8*/ uint get_pressedInUpdate();
                /*0x7a135d0*/ void set_pressedInUpdate(uint value);
                /*0x7a135d8*/ uint get_releasedInUpdate();
                /*0x7a135e0*/ void set_releasedInUpdate(uint value);
                /*0x7a0e5b8*/ bool get_isPassThrough();
                /*0x7a0fa30*/ void set_isPassThrough(bool value);
                /*0x7a0fa50*/ bool get_isButton();
                /*0x7a0fa5c*/ void set_isButton(bool value);
                /*0x7a10638*/ bool get_isPressed();
                /*0x7a0e9a0*/ void set_isPressed(bool value);
                /*0x7a10644*/ bool get_mayNeedConflictResolution();
                /*0x7a135e8*/ void set_mayNeedConflictResolution(bool value);
                /*0x7a10650*/ bool get_hasMultipleConcurrentActuations();
                /*0x7a0e960*/ void set_hasMultipleConcurrentActuations(bool value);
                /*0x7a10f9c*/ bool get_inProcessing();
                /*0x7a0e980*/ void set_inProcessing(bool value);
                /*0x7a13608*/ UnityEngine.InputSystem.InputActionState.TriggerState.Flags get_flags();
                /*0x7a10fa8*/ void set_flags(UnityEngine.InputSystem.InputActionState.TriggerState.Flags value);

                enum Flags
                {
                    HaveMagnitude = 1,
                    PassThrough = 2,
                    MayNeedConflictResolution = 4,
                    HasMultipleConcurrentActuations = 8,
                    InProcessing = 16,
                    Button = 32,
                    Pressed = 64,
                }
            }

            struct ActionMapIndices
            {
                /*0x10*/ int actionStartIndex;
                /*0x14*/ int actionCount;
                /*0x18*/ int controlStartIndex;
                /*0x1c*/ int controlCount;
                /*0x20*/ int bindingStartIndex;
                /*0x24*/ int bindingCount;
                /*0x28*/ int interactionStartIndex;
                /*0x2c*/ int interactionCount;
                /*0x30*/ int processorStartIndex;
                /*0x34*/ int processorCount;
                /*0x38*/ int compositeStartIndex;
                /*0x3c*/ int compositeCount;
            }

            struct UnmanagedMemory : System.IDisposable
            {
                /*0x10*/ void* basePtr;
                /*0x18*/ int mapCount;
                /*0x1c*/ int actionCount;
                /*0x20*/ int interactionCount;
                /*0x24*/ int bindingCount;
                /*0x28*/ int controlCount;
                /*0x2c*/ int compositeCount;
                /*0x30*/ UnityEngine.InputSystem.InputActionState.TriggerState* actionStates;
                /*0x38*/ UnityEngine.InputSystem.InputActionState.BindingState* bindingStates;
                /*0x40*/ UnityEngine.InputSystem.InputActionState.InteractionState* interactionStates;
                /*0x48*/ float* controlMagnitudes;
                /*0x50*/ float* compositeMagnitudes;
                /*0x58*/ int* enabledControls;
                /*0x60*/ ushort* actionBindingIndicesAndCounts;
                /*0x68*/ ushort* actionBindingIndices;
                /*0x70*/ int* controlIndexToBindingIndex;
                /*0x78*/ ushort* controlGroupingAndComplexity;
                /*0x80*/ bool controlGroupingInitialized;
                /*0x88*/ UnityEngine.InputSystem.InputActionState.ActionMapIndices* mapIndices;

                /*0x7a13610*/ bool get_isAllocated();
                /*0x7a13620*/ int get_sizeInBytes();
                /*0x7a13670*/ void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount);
                /*0x7a0c128*/ void Dispose();
                /*0x7a1379c*/ void CopyDataFrom(UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory);
                /*0x7a0c2f8*/ UnityEngine.InputSystem.InputActionState.UnmanagedMemory Clone();
            }

            struct GlobalState
            {
                /*0x10*/ UnityEngine.InputSystem.Utilities.InlinedArray<System.Runtime.InteropServices.GCHandle> globalList;
                /*0x28*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<object, UnityEngine.InputSystem.InputActionChange>> onActionChange;
                /*0x78*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<object>> onActionControlsChanged;
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputActionState.<> <>9;
                static /*0x8*/ UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<UnityEngine.InputSystem.InputActionState.GlobalState> <>9__140_0;
                static /*0x10*/ System.Action <>9__140_1;

                static /*0x7a13908*/ <>c();
                /*0x7a13970*/ <>c();
                /*0x7a13978*/ void <SaveAndResetState>b__140_0(ref UnityEngine.InputSystem.InputActionState.GlobalState state);
                /*0x7a13a08*/ void <SaveAndResetState>b__140_1();
            }
        }

        enum InputActionType
        {
            Value = 0,
            Button = 1,
            PassThrough = 2,
        }

        struct InputBinding : System.IEquatable<UnityEngine.InputSystem.InputBinding>
        {
            static char Separator = 59;
            static string kSeparatorString = ";";
            /*0x10*/ string m_Name;
            /*0x18*/ string m_Id;
            /*0x20*/ string m_Path;
            /*0x28*/ string m_Interactions;
            /*0x30*/ string m_Processors;
            /*0x38*/ string m_Groups;
            /*0x40*/ string m_Action;
            /*0x48*/ UnityEngine.InputSystem.InputBinding.Flags m_Flags;
            /*0x50*/ string m_OverridePath;
            /*0x58*/ string m_OverrideInteractions;
            /*0x60*/ string m_OverrideProcessors;

            static /*0x7a13ca4*/ UnityEngine.InputSystem.InputBinding MaskByGroup(string group);
            static /*0x7a13cf4*/ UnityEngine.InputSystem.InputBinding MaskByGroups(string[] groups);
            static /*0x7a0b7c0*/ bool op_Equality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right);
            static /*0x7a14040*/ bool op_Inequality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right);
            /*0x7a13b54*/ InputBinding(string path, string action, string groups, string processors, string interactions, string name);
            /*0x7a13a54*/ string get_name();
            /*0x7a13a5c*/ void set_name(string value);
            /*0x7a13a64*/ System.Guid get_id();
            /*0x7a085d4*/ void set_id(System.Guid value);
            /*0x7a13aac*/ string get_path();
            /*0x7a13ab4*/ void set_path(string value);
            /*0x7a13abc*/ string get_overridePath();
            /*0x7a13ac4*/ void set_overridePath(string value);
            /*0x7a13acc*/ string get_interactions();
            /*0x7a13ad4*/ void set_interactions(string value);
            /*0x7a13adc*/ string get_overrideInteractions();
            /*0x7a13ae4*/ void set_overrideInteractions(string value);
            /*0x7a13aec*/ string get_processors();
            /*0x7a13af4*/ void set_processors(string value);
            /*0x7a13afc*/ string get_overrideProcessors();
            /*0x7a13b04*/ void set_overrideProcessors(string value);
            /*0x7a13b0c*/ string get_groups();
            /*0x7a13b14*/ void set_groups(string value);
            /*0x7a13b1c*/ string get_action();
            /*0x7a13b24*/ void set_action(string value);
            /*0x7a08994*/ bool get_isComposite();
            /*0x7a07fac*/ void set_isComposite(bool value);
            /*0x7a0aef0*/ bool get_isPartOfComposite();
            /*0x7a0b288*/ void set_isPartOfComposite(bool value);
            /*0x7a13b2c*/ bool get_hasOverrides();
            /*0x7a13c28*/ string GetNameOfComposite();
            /*0x7a0800c*/ void GenerateId();
            /*0x7a13c6c*/ void RemoveOverrides();
            /*0x7a0c758*/ string get_effectivePath();
            /*0x7a13e68*/ string get_effectiveInteractions();
            /*0x7a13e80*/ string get_effectiveProcessors();
            /*0x7a13e98*/ bool get_isEmpty();
            /*0x7a13ee4*/ bool Equals(UnityEngine.InputSystem.InputBinding other);
            /*0x7a13fb0*/ bool Equals(object obj);
            /*0x7a1408c*/ int GetHashCode();
            /*0x7a14190*/ string ToString();
            /*0x7a142a4*/ string ToDisplayString(UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control);
            /*0x7a142d0*/ string ToDisplayString(ref string deviceLayoutName, ref string controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control);
            /*0x7a089a0*/ bool TriggersAction(UnityEngine.InputSystem.InputAction action);
            /*0x7a1474c*/ bool Matches(UnityEngine.InputSystem.InputBinding binding);
            /*0x7a14754*/ bool Matches(ref UnityEngine.InputSystem.InputBinding binding, UnityEngine.InputSystem.InputBinding.MatchOptions options);

            enum DisplayStringOptions
            {
                DontUseShortDisplayNames = 1,
                DontOmitDevice = 2,
                DontIncludeInteractions = 4,
                IgnoreBindingOverrides = 8,
            }

            enum MatchOptions
            {
                EmptyGroupMatchesAny = 1,
            }

            enum Flags
            {
                None = 0,
                Composite = 4,
                PartOfComposite = 8,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputBinding.<> <>9;
                static /*0x8*/ System.Func<string, bool> <>9__45_0;

                static /*0x7a1485c*/ <>c();
                /*0x7a148c4*/ <>c();
                /*0x7a148cc*/ bool <MaskByGroups>b__45_0(string x);
            }
        }

        class InputBindingComposite
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable s_Composites;

            static /*0x7a148f8*/ System.Type GetValueType(string composite);
            static /*0x7a14a2c*/ string GetExpectedControlLayoutName(string composite, string part);
            static /*0x7a14bb4*/ System.Collections.Generic.IEnumerable<string> GetPartNames(string composite);
            static /*0x7a14c28*/ string GetDisplayFormatString(string composite);
            /*0x7a14d38*/ InputBindingComposite();
            /*0x38148bc*/ System.Type get_valueType();
            /*0x3814574*/ int get_valueSizeInBytes();
            /*0x3910ae8*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
            /*0x3814a3c*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x7a148ec*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x7a148f4*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x7a0c8c4*/ void CallFinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

            class <GetPartNames>d__12 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ string composite;
                /*0x30*/ string <>3__composite;
                /*0x38*/ System.Reflection.FieldInfo[] <>7__wrap1;
                /*0x40*/ int <>7__wrap2;

                /*0x7a2b4b4*/ <GetPartNames>d__12(int <>1__state);
                /*0x7a2b4e8*/ void System.IDisposable.Dispose();
                /*0x7a2b4ec*/ bool MoveNext();
                /*0x7a2b6c8*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x7a2b6d0*/ void System.Collections.IEnumerator.Reset();
                /*0x7a2b708*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a2b710*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x7a2b7b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class InputBindingComposite<TValue> : UnityEngine.InputSystem.InputBindingComposite
        {
            /*0x38159dc*/ InputBindingComposite();
            /*0x38148bc*/ System.Type get_valueType();
            /*0x3814574*/ int get_valueSizeInBytes();
            /*0x3910ae8*/ TValue ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x3910ae8*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
            /*0x3814a3c*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
        }

        struct InputBindingCompositeContext
        {
            /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
            /*0x18*/ int m_BindingIndex;

            /*0x7a2b7b8*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls();
            /*0x7a2b86c*/ float EvaluateMagnitude(int partNumber);
            /*0x3910ae8*/ TValue ReadValue<TValue>(int partNumber);
            /*0x3910ae8*/ TValue ReadValue<TValue>(int partNumber, ref UnityEngine.InputSystem.InputControl sourceControl);
            /*0x3910ae8*/ TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer);
            /*0x3910ae8*/ TValue ReadValue<TValue, TComparer>(int partNumber, ref UnityEngine.InputSystem.InputControl sourceControl, TComparer comparer);
            /*0x7a2b894*/ bool ReadValueAsButton(int partNumber);
            /*0x7a2b91c*/ void ReadValue(int partNumber, void* buffer, int bufferSize);
            /*0x7a2b944*/ object ReadValueAsObject(int partNumber);
            /*0x7a2b96c*/ double GetPressTime(int partNumber);

            struct PartBinding
            {
                /*0x10*/ int <part>k__BackingField;
                /*0x18*/ UnityEngine.InputSystem.InputControl <control>k__BackingField;

                /*0x7a2b994*/ int get_part();
                /*0x7a2b99c*/ void set_part(int value);
                /*0x7a2b9a4*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x7a2b9ac*/ void set_control(UnityEngine.InputSystem.InputControl value);
            }

            struct DefaultComparer<TValue> : System.Collections.Generic.IComparer<TValue>
            {
                /*0x3910ae8*/ int Compare(TValue x, TValue y);
            }

            class <get_controls>d__2 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding <>2__current;
                /*0x28*/ int <>l__initialThreadId;
                /*0x30*/ UnityEngine.InputSystem.InputBindingCompositeContext <>4__this;
                /*0x40*/ UnityEngine.InputSystem.InputBindingCompositeContext <>3__<>4__this;
                /*0x50*/ int <totalBindingCount>5__2;
                /*0x54*/ int <bindingIndex>5__3;
                /*0x58*/ UnityEngine.InputSystem.InputActionState.BindingState <bindingState>5__4;
                /*0x78*/ int <controlStartIndex>5__5;
                /*0x7c*/ int <i>5__6;

                /*0x7a2b838*/ <get_controls>d__2(int <>1__state);
                /*0x7a2b9b4*/ void System.IDisposable.Dispose();
                /*0x7a2b9b8*/ bool MoveNext();
                /*0x7a2baec*/ UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current();
                /*0x7a2baf8*/ void System.Collections.IEnumerator.Reset();
                /*0x7a2bb30*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a2bb8c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator();
                /*0x7a2bc40*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        struct InputBindingResolver : System.IDisposable
        {
            /*0x10*/ int totalProcessorCount;
            /*0x14*/ int totalCompositeCount;
            /*0x18*/ int totalInteractionCount;
            /*0x20*/ UnityEngine.InputSystem.InputActionMap[] maps;
            /*0x28*/ UnityEngine.InputSystem.InputControl[] controls;
            /*0x30*/ UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory;
            /*0xb0*/ UnityEngine.InputSystem.IInputInteraction[] interactions;
            /*0xb8*/ UnityEngine.InputSystem.InputProcessor[] processors;
            /*0xc0*/ UnityEngine.InputSystem.InputBindingComposite[] composites;
            /*0xc8*/ System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask;
            /*0x128*/ bool m_IsControlOnlyResolve;
            /*0x130*/ System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters> m_Parameters;

            static /*0x7a2d478*/ UnityEngine.InputSystem.InputBindingComposite InstantiateBindingComposite(ref UnityEngine.InputSystem.InputBinding binding, UnityEngine.InputSystem.InputActionMap actionMap);
            static /*0x7a2d8e0*/ void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, UnityEngine.InputSystem.InputActionMap actionMap, ref UnityEngine.InputSystem.InputBinding binding, string objectRegistrationName, string namesAndParameters);
            static /*0x7a2d6fc*/ int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount);
            /*0x7a2bc44*/ int get_totalMapCount();
            /*0x7a2bc4c*/ int get_totalActionCount();
            /*0x7a2bc54*/ int get_totalBindingCount();
            /*0x7a2bc5c*/ int get_totalControlCount();
            /*0x7a2bc64*/ void Dispose();
            /*0x7a2bc70*/ void StartWithPreviousResolve(UnityEngine.InputSystem.InputActionState state, bool isFullResolve);
            /*0x7a2be4c*/ void AddActionMap(UnityEngine.InputSystem.InputActionMap actionMap);
            /*0x3910ae8*/ int InstantiateWithParameters<TType>(UnityEngine.InputSystem.Utilities.TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, UnityEngine.InputSystem.InputActionMap actionMap, ref UnityEngine.InputSystem.InputBinding binding);
        }

        struct InputControlScheme : System.IEquatable<UnityEngine.InputSystem.InputControlScheme>
        {
            /*0x10*/ string m_Name;
            /*0x18*/ string m_BindingGroup;
            /*0x20*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_DeviceRequirements;

            static /*0x3910ae8*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch);
            static /*0x3910ae8*/ bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, ref UnityEngine.InputSystem.InputControlScheme controlScheme, ref UnityEngine.InputSystem.InputControlScheme.MatchResult matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch);
            static /*0x3910ae8*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice<TSchemes>(UnityEngine.InputSystem.InputDevice device, TSchemes schemes);
            static /*0x7a2e5f8*/ bool op_Equality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right);
            static /*0x7a2e628*/ bool op_Inequality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right);
            /*0x7a2decc*/ InputControlScheme(string name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, string bindingGroup);
            /*0x7a2de54*/ string get_name();
            /*0x7a2de5c*/ string get_bindingGroup();
            /*0x7a2de64*/ void set_bindingGroup(string value);
            /*0x7a2de6c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements();
            /*0x7a2dff0*/ void SetNameAndBindingGroup(string name, string bindingGroup);
            /*0x7a2e0c4*/ bool SupportsDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x3910ae8*/ UnityEngine.InputSystem.InputControlScheme.MatchResult PickDevicesFrom<TDevices>(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice);
            /*0x7a2e1f0*/ bool Equals(UnityEngine.InputSystem.InputControlScheme other);
            /*0x7a2e364*/ bool Equals(object obj);
            /*0x7a2e3f4*/ int GetHashCode();
            /*0x7a2e474*/ string ToString();

            struct MatchResult : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match>, System.Collections.IEnumerable, System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.InputControlScheme.MatchResult.Result m_Result;
                /*0x14*/ float m_Score;
                /*0x18*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices;
                /*0x38*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;
                /*0x58*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;

                /*0x7a2e65c*/ float get_score();
                /*0x7a2e664*/ bool get_isSuccessfulMatch();
                /*0x7a2e674*/ bool get_hasMissingRequiredDevices();
                /*0x7a2e684*/ bool get_hasMissingOptionalDevices();
                /*0x7a2e694*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices();
                /*0x7a2e7d0*/ UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Item(int index);
                /*0x7a2e8a0*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator();
                /*0x7a2e938*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7a2e93c*/ void Dispose();

                enum Result
                {
                    AllSatisfied = 0,
                    MissingRequired = 1,
                    MissingOptional = 2,
                }

                struct Match
                {
                    /*0x10*/ int m_RequirementIndex;
                    /*0x18*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;
                    /*0x20*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;

                    /*0x7a2e9ac*/ UnityEngine.InputSystem.InputControl get_control();
                    /*0x7a2e9f8*/ UnityEngine.InputSystem.InputDevice get_device();
                    /*0x7a2ea10*/ int get_requirementIndex();
                    /*0x7a2ea18*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement get_requirement();
                    /*0x7a2ea4c*/ bool get_isOptional();
                }

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int m_Index;
                    /*0x18*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;
                    /*0x20*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;

                    /*0x7a2ea6c*/ bool MoveNext();
                    /*0x7a2ea98*/ void Reset();
                    /*0x7a2eaa4*/ UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Current();
                    /*0x7a2eb70*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a2ebe0*/ void Dispose();
                }
            }

            struct DeviceRequirement : System.IEquatable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement>
            {
                /*0x10*/ string m_ControlPath;
                /*0x18*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags m_Flags;

                static /*0x7a2e338*/ bool op_Equality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right);
                static /*0x7a2eed0*/ bool op_Inequality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right);
                /*0x7a2ebe4*/ string get_controlPath();
                /*0x7a2ebec*/ void set_controlPath(string value);
                /*0x7a2ea60*/ bool get_isOptional();
                /*0x7a2ebf4*/ void set_isOptional(bool value);
                /*0x7a2ec04*/ bool get_isAND();
                /*0x7a2ec20*/ void set_isAND(bool value);
                /*0x7a2ec14*/ bool get_isOR();
                /*0x7a2ec40*/ void set_isOR(bool value);
                /*0x7a2ec60*/ string ToString();
                /*0x7a2ed24*/ bool Equals(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement other);
                /*0x7a2ed90*/ bool Equals(object obj);
                /*0x7a2ee08*/ int GetHashCode();

                enum Flags
                {
                    None = 0,
                    Optional = 1,
                    Or = 2,
                }
            }

            struct SchemeJson
            {
                /*0x10*/ string name;
                /*0x18*/ string bindingGroup;
                /*0x20*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson[] devices;

                static /*0x7a2f0bc*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson ToJson(UnityEngine.InputSystem.InputControlScheme scheme);
                static /*0x7a2f264*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson[] ToJson(UnityEngine.InputSystem.InputControlScheme[] schemes);
                static /*0x7a2f37c*/ UnityEngine.InputSystem.InputControlScheme[] ToSchemes(UnityEngine.InputSystem.InputControlScheme.SchemeJson[] schemes);
                /*0x7a2ef00*/ UnityEngine.InputSystem.InputControlScheme ToScheme();

                struct DeviceJson
                {
                    /*0x10*/ string devicePath;
                    /*0x18*/ bool isOptional;
                    /*0x19*/ bool isOR;

                    static /*0x7a2f228*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson From(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement requirement);
                    /*0x7a2f068*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement ToDeviceEntry();
                }
            }
        }

        struct InputInteractionContext
        {
            /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
            /*0x18*/ UnityEngine.InputSystem.InputInteractionContext.Flags m_Flags;
            /*0x1c*/ UnityEngine.InputSystem.InputActionState.TriggerState m_TriggerState;

            /*0x7a2f484*/ UnityEngine.InputSystem.InputAction get_action();
            /*0x7a2f4a8*/ UnityEngine.InputSystem.InputControl get_control();
            /*0x7a2f4cc*/ UnityEngine.InputSystem.InputActionPhase get_phase();
            /*0x7a2f4d4*/ double get_time();
            /*0x7a2f4dc*/ double get_startTime();
            /*0x7a2f4e4*/ bool get_timerHasExpired();
            /*0x7a2f4f0*/ void set_timerHasExpired(bool value);
            /*0x7a2f510*/ bool get_isWaiting();
            /*0x7a2f520*/ bool get_isStarted();
            /*0x7a2f530*/ float ComputeMagnitude();
            /*0x7a2f538*/ bool ControlIsActuated(float threshold);
            /*0x7a2f5a0*/ void Started();
            /*0x7a2f5dc*/ void Performed();
            /*0x7a2f620*/ void PerformedAndStayStarted();
            /*0x7a2f664*/ void PerformedAndStayPerformed();
            /*0x7a2f6a8*/ void Canceled();
            /*0x7a2f6ec*/ void Waiting();
            /*0x7a2f730*/ void SetTimeout(float seconds);
            /*0x7a2f754*/ void SetTotalTimeoutCompletionTime(float seconds);
            /*0x3910ae8*/ TValue ReadValue<TValue>();
            /*0x7a2f7e4*/ int get_mapIndex();
            /*0x7a2f7ec*/ int get_controlIndex();
            /*0x7a2f7f8*/ int get_bindingIndex();
            /*0x7a2f800*/ int get_interactionIndex();

            enum Flags
            {
                TimerHasExpired = 2,
            }
        }

        class InputSystem
        {
            static string kAssemblyVersion = "1.12.0";
            static string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.12";
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_InputResetMarker;
            static /*0x8*/ UnityEngine.InputSystem.InputManager s_Manager;
            static /*0x10*/ UnityEngine.InputSystem.InputRemoting s_Remote;

            static /*0x7a34820*/ InputSystem();
            static /*0x7a2f80c*/ void add_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            static /*0x7a2f938*/ void remove_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            static /*0x7a2fa64*/ void RegisterLayout(System.Type type, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x3910ae8*/ void RegisterLayout<T>(string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x7a2fbf8*/ void RegisterLayout(string json, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x7a2fcf4*/ void RegisterLayoutOverride(string json, string name);
            static /*0x7a2fd74*/ void RegisterLayoutMatcher(string layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            static /*0x3910ae8*/ void RegisterLayoutMatcher<TDevice>(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            static /*0x7a2fdf0*/ void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x3840c74*/ void RegisterPrecompiledLayout<TDevice>(string metadata);
            static /*0x7a2ff6c*/ void RemoveLayout(string name);
            static /*0x7a2ffd8*/ string TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
            static /*0x7a30050*/ System.Collections.Generic.IEnumerable<string> ListLayouts();
            static /*0x7a300b8*/ System.Collections.Generic.IEnumerable<string> ListLayoutsBasedOn(string baseLayout);
            static /*0x7a3017c*/ UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout(string name);
            static /*0x3836db8*/ UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout<TControl>();
            static /*0x7a30264*/ string GetNameOfBaseLayout(string layoutName);
            static /*0x7a3037c*/ bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName);
            static /*0x7a304c4*/ void RegisterProcessor(System.Type type, string name);
            static /*0x3840c74*/ void RegisterProcessor<T>(string name);
            static /*0x7a30890*/ System.Type TryGetProcessor(string name);
            static /*0x7a30968*/ System.Collections.Generic.IEnumerable<string> ListProcessors();
            static /*0x7a309e0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices();
            static /*0x7a30a44*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices();
            static /*0x7a30ae0*/ void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            static /*0x7a30c58*/ void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            static /*0x7a30dd0*/ void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            static /*0x7a30f48*/ void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            static /*0x7a310c0*/ void add_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            static /*0x7a311ec*/ void remove_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            static /*0x7a31318*/ float get_pollingFrequency();
            static /*0x7a3137c*/ void set_pollingFrequency(float value);
            static /*0x7a313f0*/ UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name, string variants);
            static /*0x3910ae8*/ TDevice AddDevice<TDevice>(string name);
            static /*0x7a314f0*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description);
            static /*0x7a31604*/ void AddDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a316bc*/ void RemoveDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a3172c*/ void FlushDisconnectedDevices();
            static /*0x7a31790*/ UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout);
            static /*0x3910ae8*/ TDevice GetDevice<TDevice>();
            static /*0x7a317fc*/ UnityEngine.InputSystem.InputDevice GetDevice(System.Type type);
            static /*0x3910ae8*/ TDevice GetDevice<TDevice>(UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x3910ae8*/ TDevice GetDevice<TDevice>(string usage);
            static /*0x7a319f8*/ UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId);
            static /*0x7a31a64*/ System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices();
            static /*0x7a31b00*/ int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions);
            static /*0x7a31b6c*/ void EnableDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a31be0*/ void DisableDevice(UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents);
            static /*0x7a31c60*/ bool TrySyncDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a31da4*/ void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls);
            static /*0x7a31e24*/ bool TryResetDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a31ef4*/ void PauseHaptics();
            static /*0x7a32024*/ void ResumeHaptics();
            static /*0x7a32158*/ void ResetHaptics();
            static /*0x7a3228c*/ void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage);
            static /*0x7a32310*/ void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x7a32394*/ void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage);
            static /*0x7a32434*/ void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x7a324b8*/ void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage);
            static /*0x7a32558*/ void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x7a325dc*/ UnityEngine.InputSystem.InputControl FindControl(string path);
            static /*0x7a32718*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(string path);
            static /*0x3910ae8*/ UnityEngine.InputSystem.InputControlList<TControl> FindControls<TControl>(string path);
            static /*0x3830044*/ int FindControls<TControl>(string path, ref UnityEngine.InputSystem.InputControlList<TControl> controls);
            static /*0x7a327a8*/ bool get_isProcessingEvents();
            static /*0x7a3280c*/ UnityEngine.InputSystem.LowLevel.InputEventListener get_onEvent();
            static /*0x7a32814*/ void set_onEvent(UnityEngine.InputSystem.LowLevel.InputEventListener value);
            static /*0x7a32818*/ System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress();
            static /*0x7a32a2c*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x3840c74*/ void QueueEvent<TEvent>(ref TEvent inputEvent);
            static /*0x3910ae8*/ void QueueStateEvent<TState>(UnityEngine.InputSystem.InputDevice device, TState state, double time);
            static /*0x3910ae8*/ void QueueDeltaStateEvent<TDelta>(UnityEngine.InputSystem.InputControl control, TDelta delta, double time);
            static /*0x7a32b08*/ void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, double time);
            static /*0x7a32d18*/ void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, char character, double time);
            static /*0x7a32f38*/ void Update();
            static /*0x7a32f9c*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            static /*0x7a33150*/ void add_onBeforeUpdate(System.Action value);
            static /*0x7a3327c*/ void remove_onBeforeUpdate(System.Action value);
            static /*0x7a333a8*/ void add_onAfterUpdate(System.Action value);
            static /*0x7a334d4*/ void remove_onAfterUpdate(System.Action value);
            static /*0x7a330ec*/ UnityEngine.InputSystem.InputSettings get_settings();
            static /*0x7a33600*/ void set_settings(UnityEngine.InputSystem.InputSettings value);
            static /*0x7a33740*/ void add_onSettingsChange(System.Action value);
            static /*0x7a337ac*/ void remove_onSettingsChange(System.Action value);
            static /*0x7a33818*/ void EnableActions();
            static /*0x7a3393c*/ void DisableActions(bool triggerSetupChanged);
            static /*0x7a338d4*/ UnityEngine.InputSystem.InputActionAsset get_actions();
            static /*0x7a339fc*/ void set_actions(UnityEngine.InputSystem.InputActionAsset value);
            static /*0x7a33b4c*/ void add_onActionsChange(System.Action value);
            static /*0x7a33bb8*/ void remove_onActionsChange(System.Action value);
            static /*0x7a33c24*/ void add_onActionChange(System.Action<object, UnityEngine.InputSystem.InputActionChange> value);
            static /*0x7a33ce8*/ void remove_onActionChange(System.Action<object, UnityEngine.InputSystem.InputActionChange> value);
            static /*0x7a33dac*/ void RegisterInteraction(System.Type type, string name);
            static /*0x3840c74*/ void RegisterInteraction<T>(string name);
            static /*0x7a33f28*/ System.Type TryGetInteraction(string name);
            static /*0x7a34000*/ System.Collections.Generic.IEnumerable<string> ListInteractions();
            static /*0x7a34078*/ void RegisterBindingComposite(System.Type type, string name);
            static /*0x3840c74*/ void RegisterBindingComposite<T>(string name);
            static /*0x7a341f4*/ System.Type TryGetBindingComposite(string name);
            static /*0x7a342cc*/ void DisableAllEnabledActions();
            static /*0x7a3431c*/ System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions();
            static /*0x7a343b8*/ int ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions);
            static /*0x7a3445c*/ UnityEngine.InputSystem.InputRemoting get_remoting();
            static /*0x7a344b4*/ System.Version get_version();
            static /*0x7a34520*/ bool get_runInBackground();
            static /*0x7a345f4*/ void set_runInBackground(bool value);
            static /*0x7a346d0*/ float get_scrollWheelDeltaPerTick();
            static /*0x7a3478c*/ UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics();
            static /*0x7a34a3c*/ void RunInitializeInPlayer();
            static /*0x7a2d464*/ void EnsureInitialized();
            static /*0x7a3489c*/ void InitializeInPlayer(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings);
            static /*0x7a34af0*/ void RunInitialUpdate();
            static /*0x7a34ab8*/ void PerformDefaultPluginInitialization();

            struct StateEventBuffer
            {
                static int kMaxSize = 512;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.StateEvent stateEvent;
                /*0x29*/ UnityEngine.InputSystem.InputSystem.StateEventBuffer.<data> data;

                struct <data>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct DeltaStateEventBuffer
            {
                static int kMaxSize = 512;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.DeltaStateEvent stateEvent;
                /*0x2d*/ UnityEngine.InputSystem.InputSystem.DeltaStateEventBuffer.<data> data;

                struct <data>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputSystem.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputControl> <>9__80_0;
                static /*0x10*/ System.Func<UnityEngine.InputSystem.InputControl, bool> <>9__80_1;

                static /*0x7a34b40*/ <>c();
                /*0x7a34ba8*/ <>c();
                /*0x7a34bb0*/ UnityEngine.InputSystem.InputControl <get_onAnyButtonPress>b__80_0(UnityEngine.InputSystem.LowLevel.InputEventPtr e);
                /*0x7a34d60*/ bool <get_onAnyButtonPress>b__80_1(UnityEngine.InputSystem.InputControl c);
            }
        }

        class CommonUsages
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.InternedString Primary2DMotion;
            static /*0x10*/ UnityEngine.InputSystem.Utilities.InternedString Secondary2DMotion;
            static /*0x20*/ UnityEngine.InputSystem.Utilities.InternedString PrimaryAction;
            static /*0x30*/ UnityEngine.InputSystem.Utilities.InternedString SecondaryAction;
            static /*0x40*/ UnityEngine.InputSystem.Utilities.InternedString PrimaryTrigger;
            static /*0x50*/ UnityEngine.InputSystem.Utilities.InternedString SecondaryTrigger;
            static /*0x60*/ UnityEngine.InputSystem.Utilities.InternedString Modifier;
            static /*0x70*/ UnityEngine.InputSystem.Utilities.InternedString Position;
            static /*0x80*/ UnityEngine.InputSystem.Utilities.InternedString Orientation;
            static /*0x90*/ UnityEngine.InputSystem.Utilities.InternedString Hatswitch;
            static /*0xa0*/ UnityEngine.InputSystem.Utilities.InternedString Back;
            static /*0xb0*/ UnityEngine.InputSystem.Utilities.InternedString Forward;
            static /*0xc0*/ UnityEngine.InputSystem.Utilities.InternedString Menu;
            static /*0xd0*/ UnityEngine.InputSystem.Utilities.InternedString Submit;
            static /*0xe0*/ UnityEngine.InputSystem.Utilities.InternedString Cancel;
            static /*0xf0*/ UnityEngine.InputSystem.Utilities.InternedString Horizontal;
            static /*0x100*/ UnityEngine.InputSystem.Utilities.InternedString Vertical;
            static /*0x110*/ UnityEngine.InputSystem.Utilities.InternedString Twist;
            static /*0x120*/ UnityEngine.InputSystem.Utilities.InternedString Pressure;
            static /*0x130*/ UnityEngine.InputSystem.Utilities.InternedString ScrollHorizontal;
            static /*0x140*/ UnityEngine.InputSystem.Utilities.InternedString ScrollVertical;
            static /*0x150*/ UnityEngine.InputSystem.Utilities.InternedString Point;
            static /*0x160*/ UnityEngine.InputSystem.Utilities.InternedString LowFreqMotor;
            static /*0x170*/ UnityEngine.InputSystem.Utilities.InternedString HighFreqMotor;
            static /*0x180*/ UnityEngine.InputSystem.Utilities.InternedString LeftHand;
            static /*0x190*/ UnityEngine.InputSystem.Utilities.InternedString RightHand;
            static /*0x1a0*/ UnityEngine.InputSystem.Utilities.InternedString BatteryStrength;

            static /*0x7a34d6c*/ CommonUsages();
        }

        class InputControl
        {
            /*0x10*/ UnityEngine.InputSystem.LowLevel.InputStateBlock m_StateBlock;
            /*0x20*/ UnityEngine.InputSystem.Utilities.InternedString m_Name;
            /*0x30*/ string m_Path;
            /*0x38*/ string m_DisplayName;
            /*0x40*/ string m_DisplayNameFromLayout;
            /*0x48*/ string m_ShortDisplayName;
            /*0x50*/ string m_ShortDisplayNameFromLayout;
            /*0x58*/ UnityEngine.InputSystem.Utilities.InternedString m_Layout;
            /*0x68*/ UnityEngine.InputSystem.Utilities.InternedString m_Variants;
            /*0x78*/ UnityEngine.InputSystem.InputDevice m_Device;
            /*0x80*/ UnityEngine.InputSystem.InputControl m_Parent;
            /*0x88*/ int m_UsageCount;
            /*0x8c*/ int m_UsageStartIndex;
            /*0x90*/ int m_AliasCount;
            /*0x94*/ int m_AliasStartIndex;
            /*0x98*/ int m_ChildCount;
            /*0x9c*/ int m_ChildStartIndex;
            /*0xa0*/ UnityEngine.InputSystem.InputControl.ControlFlags m_ControlFlags;
            /*0xa4*/ bool m_CachedValueIsStale;
            /*0xa5*/ bool m_UnprocessedCachedValueIsStale;
            /*0xa8*/ UnityEngine.InputSystem.Utilities.PrimitiveValue m_DefaultState;
            /*0xb8*/ UnityEngine.InputSystem.Utilities.PrimitiveValue m_MinValue;
            /*0xc8*/ UnityEngine.InputSystem.Utilities.PrimitiveValue m_MaxValue;
            /*0xd8*/ UnityEngine.InputSystem.Utilities.FourCC m_OptimizedControlDataType;

            /*0x7a36058*/ InputControl();
            /*0x7a35568*/ string get_name();
            /*0x7a35578*/ string get_displayName();
            /*0x7a35604*/ void set_displayName(string value);
            /*0x7a3560c*/ string get_shortDisplayName();
            /*0x7a35650*/ void set_shortDisplayName(string value);
            /*0x7a35658*/ string get_path();
            /*0x7a3578c*/ string get_layout();
            /*0x7a3579c*/ string get_variants();
            /*0x7a357ac*/ UnityEngine.InputSystem.InputDevice get_device();
            /*0x7a357b4*/ UnityEngine.InputSystem.InputControl get_parent();
            /*0x7a357bc*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children();
            /*0x7a3582c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages();
            /*0x7a3589c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases();
            /*0x7a3590c*/ UnityEngine.InputSystem.LowLevel.InputStateBlock get_stateBlock();
            /*0x7a35918*/ bool get_noisy();
            /*0x7a35924*/ void set_noisy(bool value);
            /*0x7a359fc*/ bool get_synthetic();
            /*0x7a35a08*/ void set_synthetic(bool value);
            /*0x7a35a28*/ UnityEngine.InputSystem.InputControl get_Item(string path);
            /*0x38148bc*/ System.Type get_valueType();
            /*0x3814574*/ int get_valueSizeInBytes();
            /*0x7a35b08*/ float get_magnitude();
            /*0x7a35b38*/ string ToString();
            /*0x7a35ba0*/ string DebuggerDisplay();
            /*0x7a35b0c*/ float EvaluateMagnitude();
            /*0x7a35d50*/ float EvaluateMagnitude(void* statePtr);
            /*0x3910ae8*/ object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
            /*0x3910ae8*/ object ReadValueFromStateAsObject(void* statePtr);
            /*0x3910ae8*/ void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
            /*0x7a35d58*/ void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr);
            /*0x7a35db8*/ void WriteValueFromObjectIntoState(object value, void* statePtr);
            /*0x3910ae8*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
            /*0x7a35e18*/ UnityEngine.InputSystem.InputControl TryGetChildControl(string path);
            /*0x3910ae8*/ TControl TryGetChildControl<TControl>(string path);
            /*0x7a35e98*/ UnityEngine.InputSystem.InputControl GetChildControl(string path);
            /*0x3910ae8*/ TControl GetChildControl<TControl>(string path);
            /*0x7a360c4*/ void FinishSetup();
            /*0x7a355d0*/ void RefreshConfigurationIfNeeded();
            /*0x7a360e4*/ void RefreshConfiguration();
            /*0x7a35d3c*/ void* get_currentStatePtr();
            /*0x7a3623c*/ void* get_previousFrameStatePtr();
            /*0x7a36250*/ void* get_defaultStatePtr();
            /*0x7a36298*/ void* get_noiseMaskPtr();
            /*0x7a362e0*/ uint get_stateOffsetRelativeToDeviceRoot();
            /*0x7a36348*/ UnityEngine.InputSystem.Utilities.FourCC get_optimizedControlDataType();
            /*0x7a36350*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            /*0x7a36358*/ void ApplyParameterChanges();
            /*0x7a365cc*/ void SetOptimizedControlDataType();
            /*0x7a3665c*/ void SetOptimizedControlDataTypeRecursively();
            /*0x7a36858*/ void EnsureOptimizationTypeHasNotChanged();
            /*0x7a36c44*/ bool get_isSetupFinished();
            /*0x7a36c50*/ void set_isSetupFinished(bool value);
            /*0x7a36c70*/ bool get_isButton();
            /*0x7a36c7c*/ void set_isButton(bool value);
            /*0x7a360c8*/ bool get_isConfigUpToDate();
            /*0x7a360d4*/ void set_isConfigUpToDate(bool value);
            /*0x7a36c9c*/ bool get_dontReset();
            /*0x7a36ca8*/ void set_dontReset(bool value);
            /*0x7a36cc8*/ bool get_usesStateFromOtherControl();
            /*0x7a36cd4*/ void set_usesStateFromOtherControl(bool value);
            /*0x7a36cf4*/ bool get_hasDefaultState();
            /*0x7a36d14*/ void CallFinishSetupRecursive();
            /*0x7a35fac*/ string MakeChildPath(string path);
            /*0x7a36dd4*/ void BakeOffsetIntoStateBlockRecursive(uint offset);
            /*0x7a360e8*/ int GetDeviceIndex();
            /*0x7a36eb4*/ bool IsValueConsideredPressed(float value);
            /*0x7a36f5c*/ void AddProcessor(object first);
            /*0x7a36f60*/ void MarkAsStale();
            /*0x7a36404*/ void MarkAsStaleRecursively();

            enum ControlFlags
            {
                ConfigUpToDate = 1,
                IsNoisy = 2,
                IsSynthetic = 4,
                IsButton = 8,
                DontReset = 16,
                SetupFinished = 32,
                UsesStateFromOtherControl = 64,
            }
        }

        class InputControl<TValue> : UnityEngine.InputSystem.InputControl
        {
            /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputProcessor<TValue>> m_ProcessorStack;
            /*0x0*/ TValue m_CachedValue;
            /*0x0*/ TValue m_UnprocessedCachedValue;
            /*0x0*/ bool evaluateProcessorsEveryRead;

            static /*0x3825b78*/ bool CompareValue(ref TValue firstValue, ref TValue secondValue);
            /*0x38159dc*/ InputControl();
            /*0x38148bc*/ System.Type get_valueType();
            /*0x3814574*/ int get_valueSizeInBytes();
            /*0x38148bc*/ ref TValue get_value();
            /*0x38148bc*/ ref TValue get_unprocessedValue();
            /*0x3910ae8*/ TValue ReadValue();
            /*0x3910ae8*/ TValue ReadValueFromPreviousFrame();
            /*0x3910ae8*/ TValue ReadDefaultValue();
            /*0x3910ae8*/ TValue ReadValueFromState(void* statePtr);
            /*0x3910ae8*/ TValue ReadValueFromStateWithCaching(void* statePtr);
            /*0x3910ae8*/ TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr);
            /*0x3910ae8*/ TValue ReadUnprocessedValue();
            /*0x3910ae8*/ TValue ReadUnprocessedValueFromState(void* statePtr);
            /*0x3910ae8*/ object ReadValueFromStateAsObject(void* statePtr);
            /*0x3910ae8*/ void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
            /*0x3910ae8*/ void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr);
            /*0x3910ae8*/ void WriteValueFromObjectIntoState(object value, void* statePtr);
            /*0x3910ae8*/ void WriteValueIntoState(TValue value, void* statePtr);
            /*0x3910ae8*/ object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
            /*0x3910ae8*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
            /*0x3910ae8*/ TValue ProcessValue(TValue value);
            /*0x3816710*/ void ProcessValue(ref TValue value);
            /*0x3910ae8*/ TProcessor TryGetProcessor<TProcessor>();
            /*0x3816710*/ void AddProcessor(object processor);
            /*0x38159dc*/ void FinishSetup();
            /*0x38148bc*/ UnityEngine.InputSystem.InputProcessor<TValue> get_processors();
        }

        class InputControlExtensions
        {
            static /*0x3910ae8*/ TControl FindInParentChain<TControl>(UnityEngine.InputSystem.InputControl control);
            static /*0x7a36f6c*/ bool IsPressed(UnityEngine.InputSystem.InputControl control, float buttonPressPoint);
            static /*0x7a370b0*/ bool IsActuated(UnityEngine.InputSystem.InputControl control, float threshold);
            static /*0x7a35cc4*/ object ReadValueAsObject(UnityEngine.InputSystem.InputControl control);
            static /*0x7a371f0*/ void ReadValueIntoBuffer(UnityEngine.InputSystem.InputControl control, void* buffer, int bufferSize);
            static /*0x7a372a4*/ object ReadDefaultValueAsObject(UnityEngine.InputSystem.InputControl control);
            static /*0x3910ae8*/ TValue ReadValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent);
            static bool ReadValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, ref TValue value);
            static /*0x7a37348*/ object ReadValueFromEventAsObject(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent);
            static /*0x3910ae8*/ TValue ReadUnprocessedValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static bool ReadUnprocessedValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, ref TValue value);
            static /*0x7a37480*/ void WriteValueFromObjectIntoEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, object value);
            static /*0x7a37510*/ void WriteValueIntoState(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x3910ae8*/ void WriteValueIntoState<TValue>(UnityEngine.InputSystem.InputControl control, TValue value, void* statePtr);
            static /*0x3910ae8*/ void WriteValueIntoState<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, void* statePtr);
            static /*0x3910ae8*/ void WriteValueIntoState<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, void* statePtr);
            static /*0x3910ae8*/ void WriteValueIntoState<TValue, TState>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, ref TState state);
            static /*0x3910ae8*/ void WriteValueIntoEvent<TValue>(UnityEngine.InputSystem.InputControl control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x3910ae8*/ void WriteValueIntoEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x7a376a4*/ void CopyState(UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes);
            static /*0x3843dfc*/ void CopyState<TState>(UnityEngine.InputSystem.InputDevice device, ref TState state);
            static /*0x7a3717c*/ bool CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control);
            static /*0x7a37828*/ bool CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control, void* statePtr, void* maskPtr);
            static /*0x7a37a68*/ bool CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control);
            static /*0x7a37ad8*/ bool CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x7a37ba0*/ bool CompareStateIgnoringNoise(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x7a37900*/ bool CompareState(UnityEngine.InputSystem.InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr);
            static /*0x7a37c84*/ bool CompareState(UnityEngine.InputSystem.InputControl control, void* statePtr, void* maskPtr);
            static /*0x7a37d30*/ bool HasValueChangeInState(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x7a37ddc*/ bool HasValueChangeInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x7a373c8*/ void* GetStatePtrFromStateEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x7a37eb4*/ void* GetStatePtrFromStateEventUnchecked(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.Utilities.FourCC eventType);
            static /*0x7a381b8*/ bool ResetToDefaultStateInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x3910ae8*/ void QueueValueChange<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, double time);
            static /*0x7a3836c*/ void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<float> control, void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState);
            static /*0x7a38468*/ void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState);
            static /*0x3844b58*/ void FindControlsRecursive<TControl>(UnityEngine.InputSystem.InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl, bool> predicate);
            static /*0x7a38568*/ string BuildPath(UnityEngine.InputSystem.InputControl control, string deviceLayout, System.Text.StringBuilder builder);
            static /*0x7a3883c*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, UnityEngine.InputSystem.InputDevice device, float magnitudeThreshold);
            static /*0x7a38a5c*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateChangedControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, float magnitudeThreshold);
            static /*0x7a38a94*/ bool HasButtonPress(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly);
            static /*0x7a34bc0*/ UnityEngine.InputSystem.InputControl GetFirstButtonPressOrNull(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly);
            static /*0x7a38e98*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly);
            static /*0x7a38f60*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder Setup(UnityEngine.InputSystem.InputControl control);
            static /*0x7a39038*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder Setup(UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount);

            enum Enumerate
            {
                IgnoreControlsInDefaultState = 1,
                IgnoreControlsInCurrentState = 2,
                IncludeSyntheticControls = 4,
                IncludeNoisyControls = 8,
                IncludeNonLeafControls = 16,
            }

            struct InputEventControlCollection : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>, System.Collections.IEnumerable
            {
                /*0x10*/ UnityEngine.InputSystem.InputDevice m_Device;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr;
                /*0x20*/ UnityEngine.InputSystem.InputControlExtensions.Enumerate m_Flags;
                /*0x24*/ float m_MagnitudeThreshold;

                /*0x7a3927c*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_eventPtr();
                /*0x7a38ab0*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlEnumerator GetEnumerator();
                /*0x7a3947c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator();
                /*0x7a39520*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            struct InputEventControlEnumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.InputControlExtensions.Enumerate m_Flags;
                /*0x18*/ UnityEngine.InputSystem.InputDevice m_Device;
                /*0x20*/ uint[] m_StateOffsetToControlIndex;
                /*0x28*/ int m_StateOffsetToControlIndexLength;
                /*0x30*/ UnityEngine.InputSystem.InputControl[] m_AllControls;
                /*0x38*/ byte* m_DefaultState;
                /*0x40*/ byte* m_CurrentState;
                /*0x48*/ byte* m_NoiseMask;
                /*0x50*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr;
                /*0x58*/ UnityEngine.InputSystem.InputControl m_CurrentControl;
                /*0x60*/ int m_CurrentIndexInStateOffsetToControlIndexMap;
                /*0x64*/ uint m_CurrentControlStateBitOffset;
                /*0x68*/ byte* m_EventState;
                /*0x70*/ uint m_CurrentBitOffset;
                /*0x74*/ uint m_EndBitOffset;
                /*0x78*/ float m_MagnitudeThreshold;

                /*0x7a39284*/ InputEventControlEnumerator(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, float magnitudeThreshold);
                /*0x7a39a20*/ bool CheckDefault(uint numBits);
                /*0x7a39a44*/ bool CheckCurrent(uint numBits);
                /*0x7a38ad8*/ bool MoveNext();
                /*0x7a395c4*/ void Reset();
                /*0x7a39a80*/ void Dispose();
                /*0x7a39a88*/ UnityEngine.InputSystem.InputControl get_Current();
                /*0x7a39a90*/ object System.Collections.IEnumerator.get_Current();
            }

            struct ControlBuilder
            {
                /*0x10*/ UnityEngine.InputSystem.InputControl <control>k__BackingField;

                /*0x7a39a98*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x7a39aa0*/ void set_control(UnityEngine.InputSystem.InputControl value);
                /*0x7a39aa8*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder At(UnityEngine.InputSystem.InputDevice device, int index);
                /*0x7a39b40*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithParent(UnityEngine.InputSystem.InputControl parent);
                /*0x7a39b68*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithName(string name);
                /*0x7a39bbc*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDisplayName(string displayName);
                /*0x7a39c18*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithShortDisplayName(string shortDisplayName);
                /*0x7a39c74*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout);
                /*0x7a39ca4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithUsages(int startIndex, int count);
                /*0x7a39cc4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithAliases(int startIndex, int count);
                /*0x7a39ce4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithChildren(int startIndex, int count);
                /*0x7a39d04*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock);
                /*0x7a39d24*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x7a39d80*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithMinAndMax(UnityEngine.InputSystem.Utilities.PrimitiveValue min, UnityEngine.InputSystem.Utilities.PrimitiveValue max);
                /*0x3910ae8*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor);
                /*0x7a39dac*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsNoisy(bool value);
                /*0x7a39dd4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsSynthetic(bool value);
                /*0x7a39e0c*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder DontReset(bool value);
                /*0x7a39e7c*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsButton(bool value);
                /*0x7a39eb4*/ void Finish();
            }

            struct DeviceBuilder
            {
                /*0x10*/ UnityEngine.InputSystem.InputDevice <device>k__BackingField;

                /*0x7a39ed8*/ UnityEngine.InputSystem.InputDevice get_device();
                /*0x7a39ee0*/ void set_device(UnityEngine.InputSystem.InputDevice value);
                /*0x7a39ee8*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithName(string name);
                /*0x7a39f3c*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithDisplayName(string displayName);
                /*0x7a39f98*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithShortDisplayName(string shortDisplayName);
                /*0x7a39ff4*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout);
                /*0x7a3a024*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithChildren(int startIndex, int count);
                /*0x7a3a044*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock);
                /*0x7a3a064*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder IsNoisy(bool value);
                /*0x7a3a08c*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlUsage(int controlIndex, UnityEngine.InputSystem.Utilities.InternedString usage, UnityEngine.InputSystem.InputControl control);
                /*0x7a3a144*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlAlias(int controlIndex, UnityEngine.InputSystem.Utilities.InternedString alias);
                /*0x7a3a194*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map);
                /*0x7a3a1c0*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies);
                /*0x7a3a2fc*/ void Finish();
            }

            class <GetAllButtonPresses>d__43 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.InputSystem.InputControl <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr;
                /*0x30*/ UnityEngine.InputSystem.LowLevel.InputEventPtr <>3__eventPtr;
                /*0x38*/ float magnitude;
                /*0x3c*/ float <>3__magnitude;
                /*0x40*/ bool buttonControlsOnly;
                /*0x41*/ bool <>3__buttonControlsOnly;
                /*0x48*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlEnumerator <>7__wrap1;

                /*0x7a38f2c*/ <GetAllButtonPresses>d__43(int <>1__state);
                /*0x7a3a5d8*/ void System.IDisposable.Dispose();
                /*0x7a3a5fc*/ bool MoveNext();
                /*0x7a3a860*/ void <>m__Finally1();
                /*0x7a3a870*/ UnityEngine.InputSystem.InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current();
                /*0x7a3a878*/ void System.Collections.IEnumerator.Reset();
                /*0x7a3a8b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a3a8b8*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator();
                /*0x7a3a964*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        enum InputControlLayoutChange
        {
            Added = 0,
            Removed = 1,
            Replaced = 2,
        }

        struct InputControlList<TControl> : System.Collections.Generic.IList<TControl>, System.Collections.Generic.ICollection<TControl>, System.Collections.Generic.IEnumerable<TControl>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<TControl>, System.Collections.Generic.IReadOnlyCollection<TControl>, System.IDisposable
        {
            static ulong kInvalidIndex = 18446744073709551615;
            /*0x0*/ int m_Count;
            /*0x0*/ Unity.Collections.NativeArray<ulong> m_Indices;
            /*0x0*/ Unity.Collections.Allocator m_Allocator;

            static /*0x3910ae8*/ ulong ToIndex(TControl control);
            static /*0x3910ae8*/ TControl FromIndex(ulong index);
            /*0x3815fb8*/ InputControlList(Unity.Collections.Allocator allocator, int initialCapacity);
            /*0x381678c*/ InputControlList(System.Collections.Generic.IEnumerable<TControl> values, Unity.Collections.Allocator allocator);
            /*0x3816710*/ InputControlList(TControl[] values);
            /*0x3814574*/ int get_Count();
            /*0x3814574*/ int get_Capacity();
            /*0x3815ed0*/ void set_Capacity(int value);
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x3910ae8*/ TControl get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, TControl value);
            /*0x3815ed0*/ void Resize(int size);
            /*0x3910ae8*/ void Add(TControl item);
            /*0x3910ae8*/ void AddSlice<TList>(TList list, int count, int destinationIndex, int sourceIndex);
            void AddRange(System.Collections.Generic.IEnumerable<TControl> list, int count, int destinationIndex);
            /*0x3910ae8*/ bool Remove(TControl item);
            /*0x3815ed0*/ void RemoveAt(int index);
            /*0x381678c*/ void CopyTo(TControl[] array, int arrayIndex);
            /*0x3910ae8*/ int IndexOf(TControl item);
            /*0x3910ae8*/ int IndexOf(TControl item, int startIndex, int count);
            /*0x3910ae8*/ void Insert(int index, TControl item);
            /*0x38159dc*/ void Clear();
            /*0x3910ae8*/ bool Contains(TControl item);
            /*0x3910ae8*/ bool Contains(TControl item, int startIndex, int count);
            /*0x3815fb8*/ void SwapElements(int index1, int index2);
            /*0x3910ae8*/ void Sort<TCompare>(int startIndex, int count, TCompare comparer);
            TControl[] ToArray(bool dispose);
            /*0x3816810*/ void AppendTo(ref TControl[] array, ref int count);
            /*0x38159dc*/ void Dispose();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<TControl> GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ string ToString();

            struct Enumerator<TControl> : System.Collections.Generic.IEnumerator<TControl>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ ulong* m_Indices;
                /*0x0*/ int m_Count;
                /*0x0*/ int m_Current;

                /*0x3910ae8*/ Enumerator(UnityEngine.InputSystem.InputControlList<TControl> list);
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void Reset();
                /*0x3910ae8*/ TControl get_Current();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                /*0x38159dc*/ void Dispose();
            }
        }

        class InputControlPath
        {
            static string Wildcard = "*";
            static string DoubleWildcard = "**";
            static char Separator = 47;
            static char SeparatorReplacement = 32;

            static /*0x7a3a968*/ string CleanSlashes(string pathComponent);
            static /*0x7a356ac*/ string Combine(UnityEngine.InputSystem.InputControl parent, string path);
            static /*0x7a3a984*/ string ToHumanReadableString(string path, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control);
            static /*0x7a3a9b0*/ string ToHumanReadableString(string path, ref string deviceLayoutName, ref string controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control);
            static /*0x7a3b9e8*/ string[] TryGetDeviceUsages(string path);
            static /*0x7a3bb80*/ string TryGetDeviceLayout(string path);
            static /*0x7a3bd14*/ string TryGetControlLayout(string path);
            static /*0x7a3bf28*/ string FindControlLayoutRecursive(ref UnityEngine.InputSystem.InputControlPath.PathParser parser, string layoutName);
            static /*0x7a3c098*/ string FindControlLayoutRecursive(ref UnityEngine.InputSystem.InputControlPath.PathParser parser, UnityEngine.InputSystem.Layouts.InputControlLayout layout);
            static /*0x7a3c230*/ bool ControlLayoutMatchesPathComponent(ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, ref UnityEngine.InputSystem.InputControlPath.PathParser parser);
            static /*0x7a3c3e8*/ bool StringMatches(UnityEngine.InputSystem.Utilities.Substring str, UnityEngine.InputSystem.Utilities.InternedString matchTo);
            static /*0x7a2e190*/ UnityEngine.InputSystem.InputControl TryFindControl(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x7a3c644*/ UnityEngine.InputSystem.InputControl[] TryFindControls(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x7a3c7a0*/ int TryFindControls(UnityEngine.InputSystem.InputControl control, string path, ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> matches, int indexInPath);
            static /*0x3910ae8*/ TControl TryFindControl<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x3910ae8*/ int TryFindControls<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches);
            static /*0x7a35aa8*/ UnityEngine.InputSystem.InputControl TryFindChild(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x3910ae8*/ TControl TryFindChild<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x7a3ae20*/ bool Matches(string expected, UnityEngine.InputSystem.InputControl control);
            static /*0x7a3c878*/ bool MatchControlComponent(ref UnityEngine.InputSystem.InputControlPath.ParsedPathComponent expectedControlComponent, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, bool matchAlias);
            static /*0x7a3cc88*/ bool MatchesPrefix(string expected, UnityEngine.InputSystem.InputControl control);
            static /*0x7a3c810*/ bool MatchesRecursive(ref UnityEngine.InputSystem.InputControlPath.PathParser parser, UnityEngine.InputSystem.InputControl currentControl, bool prefixOnly);
            static /*0x3910ae8*/ TControl MatchControlsRecursive<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple);
            static /*0x3910ae8*/ TControl MatchByUsageAtDeviceRootRecursive<TControl>(UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple);
            static /*0x3910ae8*/ TControl MatchChildrenRecursive<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple);
            static /*0x7a3d024*/ bool MatchPathComponent(string component, string path, ref int indexInPath, UnityEngine.InputSystem.InputControlPath.PathComponentType componentType, int startIndexInComponent);
            static /*0x7a3d2ac*/ bool PathComponentCanYieldMultipleMatches(string path, int indexInPath);
            static /*0x7a3d368*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(string path);

            enum HumanReadableStringOptions
            {
                None = 0,
                OmitDevice = 2,
                UseShortNames = 4,
            }

            enum PathComponentType
            {
                Name = 0,
                DisplayName = 1,
                Usage = 2,
                Layout = 3,
            }

            struct ParsedPathComponent
            {
                /*0x10*/ UnityEngine.InputSystem.Utilities.Substring m_Layout;
                /*0x20*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.Substring> m_Usages;
                /*0x40*/ UnityEngine.InputSystem.Utilities.Substring m_Name;
                /*0x50*/ UnityEngine.InputSystem.Utilities.Substring m_DisplayName;

                static /*0x7a3d5d4*/ string ToHumanReadableString(UnityEngine.InputSystem.Utilities.Substring substring);
                static /*0x7a3d638*/ bool ComparePathElementToString(UnityEngine.InputSystem.Utilities.Substring pathElement, string element);
                /*0x7a3d418*/ string get_layout();
                /*0x7a3d420*/ System.Collections.Generic.IEnumerable<string> get_usages();
                /*0x7a3d558*/ string get_name();
                /*0x7a3d564*/ string get_displayName();
                /*0x7a3bcb0*/ bool get_isWildcard();
                /*0x7a3d570*/ bool get_isDoubleWildcard();
                /*0x7a3b244*/ string ToHumanReadableString(string parentLayoutName, string parentControlPath, ref string referencedLayoutName, ref string controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options);
                /*0x7a3cd74*/ bool Matches(UnityEngine.InputSystem.InputControl control);

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.Substring, string> <>9__7_0;

                    static /*0x7a3d774*/ <>c();
                    /*0x7a3d7dc*/ <>c();
                    /*0x7a3d7e4*/ string <get_usages>b__7_0(UnityEngine.InputSystem.Utilities.Substring x);
                }
            }

            struct PathParser
            {
                /*0x10*/ string path;
                /*0x18*/ int length;
                /*0x1c*/ int leftIndexInPath;
                /*0x20*/ int rightIndexInPath;
                /*0x28*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent current;

                /*0x7a3aef0*/ PathParser(string path);
                /*0x7a3c3d4*/ bool get_isAtEnd();
                /*0x7a3af40*/ bool MoveToNextComponent();
                /*0x7a3d808*/ UnityEngine.InputSystem.Utilities.Substring ParseComponentPart(char terminator);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputControlPath.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.Substring, string> <>9__9_0;

                static /*0x7a3d910*/ <>c();
                /*0x7a3d978*/ <>c();
                /*0x7a3d980*/ string <TryGetDeviceUsages>b__9_0(UnityEngine.InputSystem.Utilities.Substring x);
            }

            class <Parse>d__34 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent <>2__current;
                /*0x68*/ int <>l__initialThreadId;
                /*0x70*/ string path;
                /*0x78*/ string <>3__path;
                /*0x80*/ UnityEngine.InputSystem.InputControlPath.PathParser <parser>5__2;

                /*0x7a3d3e4*/ <Parse>d__34(int <>1__state);
                /*0x7a3d9a4*/ void System.IDisposable.Dispose();
                /*0x7a3d9a8*/ bool MoveNext();
                /*0x7a3dac0*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current();
                /*0x7a3dad0*/ void System.Collections.IEnumerator.Reset();
                /*0x7a3db08*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a3db6c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator();
                /*0x7a3dc10*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class InputProcessor
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable s_Processors;

            static /*0x7a3dc14*/ System.Type GetValueTypeFromType(System.Type processorType);
            /*0x7a3dd00*/ InputProcessor();
            /*0x3814b90*/ object ProcessAsObject(object value, UnityEngine.InputSystem.InputControl control);
            /*0x3910ae8*/ void Process(void* buffer, int bufferSize, UnityEngine.InputSystem.InputControl control);
            /*0x7a3dcf8*/ UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy();

            enum CachingPolicy
            {
                CacheResult = 0,
                EvaluateOnEveryRead = 1,
            }
        }

        class InputProcessor<TValue> : UnityEngine.InputSystem.InputProcessor
        {
            /*0x38159dc*/ InputProcessor();
            /*0x3910ae8*/ TValue Process(TValue value, UnityEngine.InputSystem.InputControl control);
            /*0x3814b90*/ object ProcessAsObject(object value, UnityEngine.InputSystem.InputControl control);
            /*0x3910ae8*/ void Process(void* buffer, int bufferSize, UnityEngine.InputSystem.InputControl control);
        }

        class Gamepad : UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.Haptics.IDualMotorRumble, UnityEngine.InputSystem.Haptics.IHaptics
        {
            static /*0x0*/ UnityEngine.InputSystem.Gamepad <current>k__BackingField;
            static /*0x8*/ int s_GamepadCount;
            static /*0x10*/ UnityEngine.InputSystem.Gamepad[] s_Gamepads;
            /*0x188*/ UnityEngine.InputSystem.Controls.ButtonControl <buttonWest>k__BackingField;
            /*0x190*/ UnityEngine.InputSystem.Controls.ButtonControl <buttonNorth>k__BackingField;
            /*0x198*/ UnityEngine.InputSystem.Controls.ButtonControl <buttonSouth>k__BackingField;
            /*0x1a0*/ UnityEngine.InputSystem.Controls.ButtonControl <buttonEast>k__BackingField;
            /*0x1a8*/ UnityEngine.InputSystem.Controls.ButtonControl <leftStickButton>k__BackingField;
            /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <rightStickButton>k__BackingField;
            /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <startButton>k__BackingField;
            /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <selectButton>k__BackingField;
            /*0x1c8*/ UnityEngine.InputSystem.Controls.DpadControl <dpad>k__BackingField;
            /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <leftShoulder>k__BackingField;
            /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <rightShoulder>k__BackingField;
            /*0x1e0*/ UnityEngine.InputSystem.Controls.StickControl <leftStick>k__BackingField;
            /*0x1e8*/ UnityEngine.InputSystem.Controls.StickControl <rightStick>k__BackingField;
            /*0x1f0*/ UnityEngine.InputSystem.Controls.ButtonControl <leftTrigger>k__BackingField;
            /*0x1f8*/ UnityEngine.InputSystem.Controls.ButtonControl <rightTrigger>k__BackingField;
            /*0x200*/ UnityEngine.InputSystem.Haptics.DualMotorRumble m_Rumble;

            static /*0x7a3e014*/ UnityEngine.InputSystem.Gamepad get_current();
            static /*0x7a3e05c*/ void set_current(UnityEngine.InputSystem.Gamepad value);
            static /*0x7a3e0b4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all();
            /*0x7a3e700*/ Gamepad();
            /*0x7a3dd08*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonWest();
            /*0x7a3dd10*/ void set_buttonWest(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3dd20*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonNorth();
            /*0x7a3dd28*/ void set_buttonNorth(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3dd38*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonSouth();
            /*0x7a3dd40*/ void set_buttonSouth(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3dd50*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonEast();
            /*0x7a3dd58*/ void set_buttonEast(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3dd68*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftStickButton();
            /*0x7a3dd70*/ void set_leftStickButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3dd80*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightStickButton();
            /*0x7a3dd88*/ void set_rightStickButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3dd98*/ UnityEngine.InputSystem.Controls.ButtonControl get_startButton();
            /*0x7a3dda0*/ void set_startButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3ddb0*/ UnityEngine.InputSystem.Controls.ButtonControl get_selectButton();
            /*0x7a3ddb8*/ void set_selectButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3ddc8*/ UnityEngine.InputSystem.Controls.DpadControl get_dpad();
            /*0x7a3ddd0*/ void set_dpad(UnityEngine.InputSystem.Controls.DpadControl value);
            /*0x7a3dde0*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftShoulder();
            /*0x7a3dde8*/ void set_leftShoulder(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3ddf8*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightShoulder();
            /*0x7a3de00*/ void set_rightShoulder(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3de10*/ UnityEngine.InputSystem.Controls.StickControl get_leftStick();
            /*0x7a3de18*/ void set_leftStick(UnityEngine.InputSystem.Controls.StickControl value);
            /*0x7a3de28*/ UnityEngine.InputSystem.Controls.StickControl get_rightStick();
            /*0x7a3de30*/ void set_rightStick(UnityEngine.InputSystem.Controls.StickControl value);
            /*0x7a3de40*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftTrigger();
            /*0x7a3de48*/ void set_leftTrigger(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3de58*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightTrigger();
            /*0x7a3de60*/ void set_rightTrigger(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a3de70*/ UnityEngine.InputSystem.Controls.ButtonControl get_aButton();
            /*0x7a3de78*/ UnityEngine.InputSystem.Controls.ButtonControl get_bButton();
            /*0x7a3de80*/ UnityEngine.InputSystem.Controls.ButtonControl get_xButton();
            /*0x7a3de88*/ UnityEngine.InputSystem.Controls.ButtonControl get_yButton();
            /*0x7a3de90*/ UnityEngine.InputSystem.Controls.ButtonControl get_triangleButton();
            /*0x7a3de98*/ UnityEngine.InputSystem.Controls.ButtonControl get_squareButton();
            /*0x7a3dea0*/ UnityEngine.InputSystem.Controls.ButtonControl get_circleButton();
            /*0x7a3dea8*/ UnityEngine.InputSystem.Controls.ButtonControl get_crossButton();
            /*0x7a3deb0*/ UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.LowLevel.GamepadButton button);
            /*0x7a3e134*/ void FinishSetup();
            /*0x7a3e4c4*/ void MakeCurrent();
            /*0x7a3e520*/ void OnAdded();
            /*0x7a3e598*/ void OnRemoved();
            /*0x7a3e6c0*/ void PauseHaptics();
            /*0x7a3e6d0*/ void ResumeHaptics();
            /*0x7a3e6e0*/ void ResetHaptics();
            /*0x7a3e6f0*/ void SetMotorSpeeds(float lowFrequency, float highFrequency);
        }

        class InputDevice : UnityEngine.InputSystem.InputControl
        {
            static int InvalidDeviceId = 0;
            static int kLocalParticipantId = 0;
            static int kInvalidDeviceIndex = -1;
            static int kControlIndexBits = 10;
            static int kStateOffsetBits = 13;
            static int kStateSizeBits = 9;
            /*0xdc*/ UnityEngine.InputSystem.InputDevice.DeviceFlags m_DeviceFlags;
            /*0xe0*/ int m_DeviceId;
            /*0xe4*/ int m_ParticipantId;
            /*0xe8*/ int m_DeviceIndex;
            /*0xec*/ uint m_CurrentProcessedEventBytesOnUpdate;
            /*0xf0*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription m_Description;
            /*0x128*/ double m_LastUpdateTimeInternal;
            /*0x130*/ uint m_CurrentUpdateStepCount;
            /*0x138*/ UnityEngine.InputSystem.Utilities.InternedString[] m_AliasesForEachControl;
            /*0x140*/ UnityEngine.InputSystem.Utilities.InternedString[] m_UsagesForEachControl;
            /*0x148*/ UnityEngine.InputSystem.InputControl[] m_UsageToControl;
            /*0x150*/ UnityEngine.InputSystem.InputControl[] m_ChildrenForEachControl;
            /*0x158*/ System.Collections.Generic.HashSet<int> m_UpdatedButtons;
            /*0x160*/ System.Collections.Generic.List<UnityEngine.InputSystem.Controls.ButtonControl> m_ButtonControlsCheckingPressState;
            /*0x168*/ bool m_UseCachePathForButtonPresses;
            /*0x170*/ uint[] m_StateOffsetToControlMap;
            /*0x178*/ UnityEngine.InputSystem.InputDevice.ControlBitRangeNode[] m_ControlTreeNodes;
            /*0x180*/ ushort[] m_ControlTreeIndices;

            static /*0x7a3ea6c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all();
            static /*0x7a3f090*/ uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits);
            static /*0x7a39a64*/ void DecodeStateOffsetToControlMapEntry(uint entry, ref uint controlIndex, ref uint stateOffset, ref uint stateSize);
            static /*0x3910ae8*/ TDevice Build<TDevice>(string layoutName, string layoutVariants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, bool noPrecompiledLayouts);
            static /*0x7a40244*/ bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits);
            /*0x7a3e720*/ InputDevice();
            /*0x7a3e740*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription get_description();
            /*0x7a3e75c*/ bool get_enabled();
            /*0x7a3e820*/ bool get_canRunInBackground();
            /*0x7a3e824*/ bool get_canDeviceRunInBackground();
            /*0x7a2d468*/ bool get_added();
            /*0x7a3e8dc*/ bool get_remote();
            /*0x7a3e8e8*/ bool get_native();
            /*0x7a3e8f4*/ bool get_updateBeforeRender();
            /*0x7a3e900*/ int get_deviceId();
            /*0x7a3e908*/ double get_lastUpdateTime();
            /*0x7a3e95c*/ bool get_wasUpdatedThisFrame();
            /*0x7a3a578*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls();
            /*0x7a3e9b4*/ System.Type get_valueType();
            /*0x7a3ea14*/ int get_valueSizeInBytes();
            /*0x7a3eab8*/ object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
            /*0x7a3eaf0*/ object ReadValueFromStateAsObject(void* statePtr);
            /*0x7a3ebf8*/ void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
            /*0x7a3edac*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
            /*0x7a3eeac*/ void NotifyConfigurationChanged();
            /*0x7a3e51c*/ void MakeCurrent();
            /*0x7a3ef28*/ void OnAdded();
            /*0x7a3ef2c*/ void OnRemoved();
            /*0x7a3ef30*/ void OnConfigurationChanged();
            long ExecuteCommand<TCommand>(ref TCommand command);
            /*0x7a3ef34*/ long ExecuteCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr);
            /*0x7a3e778*/ bool QueryEnabledStateFromRuntime();
            /*0x7a3f00c*/ bool get_disabledInFrontend();
            /*0x7a3f018*/ void set_disabledInFrontend(bool value);
            /*0x7a3f038*/ bool get_disabledInRuntime();
            /*0x7a3f044*/ void set_disabledInRuntime(bool value);
            /*0x7a3f064*/ bool get_disabledWhileInBackground();
            /*0x7a3f070*/ void set_disabledWhileInBackground(bool value);
            /*0x7a3f09c*/ bool get_hasControlsWithDefaultState();
            /*0x7a39d60*/ void set_hasControlsWithDefaultState(bool value);
            /*0x7a3f0a8*/ bool get_hasDontResetControls();
            /*0x7a39e5c*/ void set_hasDontResetControls(bool value);
            /*0x7a381ac*/ bool get_hasStateCallbacks();
            /*0x7a3f0b4*/ void set_hasStateCallbacks(bool value);
            /*0x7a3f0d4*/ bool get_hasEventMerger();
            /*0x7a3f0e0*/ void set_hasEventMerger(bool value);
            /*0x7a3f100*/ bool get_hasEventPreProcessor();
            /*0x7a3f10c*/ void set_hasEventPreProcessor(bool value);
            /*0x7a3f12c*/ void AddDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a3f1e4*/ void RemoveDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a3f2c4*/ void ClearDeviceUsages();
            /*0x7a31d28*/ bool RequestSync();
            /*0x7a31e78*/ bool RequestReset();
            /*0x7a3f324*/ bool ExecuteEnableCommand();
            /*0x7a3f3a0*/ bool ExecuteDisableCommand();
            /*0x7a3f410*/ void NotifyAdded();
            /*0x7a3f420*/ void NotifyRemoved();
            /*0x7a3f430*/ void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice);
            /*0x7a3f584*/ void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset);
            /*0x7a3fc2c*/ void DumpControlBitRangeNode(int nodeIndex, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode node, uint startOffset, uint sizeInBits, System.Collections.Generic.List<string> output);
            /*0x7a40054*/ void DumpControlTree(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset, System.Collections.Generic.List<string> output);
            /*0x7a40178*/ string DumpControlTree();
            /*0x7a3f8b8*/ void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset);

            enum DeviceFlags
            {
                UpdateBeforeRender = 1,
                HasStateCallbacks = 2,
                HasControlsWithDefaultState = 4,
                HasDontResetControls = 1024,
                HasEventMerger = 8192,
                HasEventPreProcessor = 16384,
                Remote = 8,
                Native = 16,
                DisabledInFrontend = 32,
                DisabledInRuntime = 128,
                DisabledWhileInBackground = 256,
                DisabledStateHasBeenQueriedFromRuntime = 64,
                CanRunInBackground = 2048,
                CanRunInBackgroundHasBeenQueried = 4096,
            }

            struct ControlBitRangeNode
            {
                /*0x10*/ ushort endBitOffset;
                /*0x12*/ short leftChildIndex;
                /*0x14*/ ushort controlStartIndex;
                /*0x16*/ byte controlCount;

                /*0x7a409a8*/ ControlBitRangeNode(ushort endOffset);
            }
        }

        enum InputDeviceChange
        {
            Added = 0,
            Removed = 1,
            Disconnected = 2,
            Reconnected = 3,
            Enabled = 4,
            Disabled = 5,
            UsageChanged = 6,
            ConfigurationChanged = 7,
            SoftReset = 8,
            HardReset = 9,
            Destroyed = 10,
        }

        class Joystick : UnityEngine.InputSystem.InputDevice
        {
            static /*0x0*/ UnityEngine.InputSystem.Joystick <current>k__BackingField;
            static /*0x8*/ int s_JoystickCount;
            static /*0x10*/ UnityEngine.InputSystem.Joystick[] s_Joysticks;
            /*0x188*/ UnityEngine.InputSystem.Controls.ButtonControl <trigger>k__BackingField;
            /*0x190*/ UnityEngine.InputSystem.Controls.StickControl <stick>k__BackingField;
            /*0x198*/ UnityEngine.InputSystem.Controls.AxisControl <twist>k__BackingField;
            /*0x1a0*/ UnityEngine.InputSystem.Controls.Vector2Control <hatswitch>k__BackingField;

            static /*0x7a40a1c*/ UnityEngine.InputSystem.Joystick get_current();
            static /*0x7a40a64*/ void set_current(UnityEngine.InputSystem.Joystick value);
            static /*0x7a40abc*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all();
            /*0x7a40ebc*/ Joystick();
            /*0x7a409bc*/ UnityEngine.InputSystem.Controls.ButtonControl get_trigger();
            /*0x7a409c4*/ void set_trigger(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a409d4*/ UnityEngine.InputSystem.Controls.StickControl get_stick();
            /*0x7a409dc*/ void set_stick(UnityEngine.InputSystem.Controls.StickControl value);
            /*0x7a409ec*/ UnityEngine.InputSystem.Controls.AxisControl get_twist();
            /*0x7a409f4*/ void set_twist(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a40a04*/ UnityEngine.InputSystem.Controls.Vector2Control get_hatswitch();
            /*0x7a40a0c*/ void set_hatswitch(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a40b3c*/ void FinishSetup();
            /*0x7a40cb0*/ void MakeCurrent();
            /*0x7a40d10*/ void OnAdded();
            /*0x7a40d88*/ void OnRemoved();
        }

        enum Key
        {
            None = 0,
            Space = 1,
            Enter = 2,
            Tab = 3,
            Backquote = 4,
            Quote = 5,
            Semicolon = 6,
            Comma = 7,
            Period = 8,
            Slash = 9,
            Backslash = 10,
            LeftBracket = 11,
            RightBracket = 12,
            Minus = 13,
            Equals = 14,
            A = 15,
            B = 16,
            C = 17,
            D = 18,
            E = 19,
            F = 20,
            G = 21,
            H = 22,
            I = 23,
            J = 24,
            K = 25,
            L = 26,
            M = 27,
            N = 28,
            O = 29,
            P = 30,
            Q = 31,
            R = 32,
            S = 33,
            T = 34,
            U = 35,
            V = 36,
            W = 37,
            X = 38,
            Y = 39,
            Z = 40,
            Digit1 = 41,
            Digit2 = 42,
            Digit3 = 43,
            Digit4 = 44,
            Digit5 = 45,
            Digit6 = 46,
            Digit7 = 47,
            Digit8 = 48,
            Digit9 = 49,
            Digit0 = 50,
            LeftShift = 51,
            RightShift = 52,
            LeftAlt = 53,
            RightAlt = 54,
            AltGr = 54,
            LeftCtrl = 55,
            RightCtrl = 56,
            LeftMeta = 57,
            RightMeta = 58,
            LeftWindows = 57,
            RightWindows = 58,
            LeftApple = 57,
            RightApple = 58,
            LeftCommand = 57,
            RightCommand = 58,
            ContextMenu = 59,
            Escape = 60,
            LeftArrow = 61,
            RightArrow = 62,
            UpArrow = 63,
            DownArrow = 64,
            Backspace = 65,
            PageDown = 66,
            PageUp = 67,
            Home = 68,
            End = 69,
            Insert = 70,
            Delete = 71,
            CapsLock = 72,
            NumLock = 73,
            PrintScreen = 74,
            ScrollLock = 75,
            Pause = 76,
            NumpadEnter = 77,
            NumpadDivide = 78,
            NumpadMultiply = 79,
            NumpadPlus = 80,
            NumpadMinus = 81,
            NumpadPeriod = 82,
            NumpadEquals = 83,
            Numpad0 = 84,
            Numpad1 = 85,
            Numpad2 = 86,
            Numpad3 = 87,
            Numpad4 = 88,
            Numpad5 = 89,
            Numpad6 = 90,
            Numpad7 = 91,
            Numpad8 = 92,
            Numpad9 = 93,
            F1 = 94,
            F2 = 95,
            F3 = 96,
            F4 = 97,
            F5 = 98,
            F6 = 99,
            F7 = 100,
            F8 = 101,
            F9 = 102,
            F10 = 103,
            F11 = 104,
            F12 = 105,
            OEM1 = 106,
            OEM2 = 107,
            OEM3 = 108,
            OEM4 = 109,
            OEM5 = 110,
            IMESelected = 111,
        }

        class Keyboard : UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.ITextInputReceiver
        {
            static int KeyCount = 110;
            static /*0x0*/ UnityEngine.InputSystem.Keyboard <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AnyKeyControl <anyKey>k__BackingField;
            /*0x190*/ UnityEngine.InputSystem.Controls.ButtonControl <shiftKey>k__BackingField;
            /*0x198*/ UnityEngine.InputSystem.Controls.ButtonControl <ctrlKey>k__BackingField;
            /*0x1a0*/ UnityEngine.InputSystem.Controls.ButtonControl <altKey>k__BackingField;
            /*0x1a8*/ UnityEngine.InputSystem.Controls.ButtonControl <imeSelected>k__BackingField;
            /*0x1b0*/ UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<char>> m_TextInputListeners;
            /*0x1c8*/ string m_KeyboardLayoutName;
            /*0x1d0*/ UnityEngine.InputSystem.Controls.KeyControl[] m_Keys;
            /*0x1d8*/ UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString>> m_ImeCompositionListeners;

            static /*0x7a41788*/ UnityEngine.InputSystem.Keyboard get_current();
            static /*0x7a417d0*/ void set_current(UnityEngine.InputSystem.Keyboard value);
            /*0x7a43434*/ Keyboard();
            /*0x7a40ec4*/ void add_onTextInput(System.Action<char> value);
            /*0x7a40fa4*/ void remove_onTextInput(System.Action<char> value);
            /*0x7a40ffc*/ void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value);
            /*0x7a410e0*/ void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value);
            /*0x7a41138*/ void SetIMEEnabled(bool enabled);
            /*0x7a411b8*/ void SetIMECursorPosition(UnityEngine.Vector2 position);
            /*0x7a41260*/ string get_keyboardLayout();
            /*0x7a4127c*/ void set_keyboardLayout(string value);
            /*0x7a4128c*/ UnityEngine.InputSystem.Controls.AnyKeyControl get_anyKey();
            /*0x7a41294*/ void set_anyKey(UnityEngine.InputSystem.Controls.AnyKeyControl value);
            /*0x7a412a4*/ UnityEngine.InputSystem.Controls.KeyControl get_spaceKey();
            /*0x7a41330*/ UnityEngine.InputSystem.Controls.KeyControl get_enterKey();
            /*0x7a41338*/ UnityEngine.InputSystem.Controls.KeyControl get_tabKey();
            /*0x7a41340*/ UnityEngine.InputSystem.Controls.KeyControl get_backquoteKey();
            /*0x7a41348*/ UnityEngine.InputSystem.Controls.KeyControl get_quoteKey();
            /*0x7a41350*/ UnityEngine.InputSystem.Controls.KeyControl get_semicolonKey();
            /*0x7a41358*/ UnityEngine.InputSystem.Controls.KeyControl get_commaKey();
            /*0x7a41360*/ UnityEngine.InputSystem.Controls.KeyControl get_periodKey();
            /*0x7a41368*/ UnityEngine.InputSystem.Controls.KeyControl get_slashKey();
            /*0x7a41370*/ UnityEngine.InputSystem.Controls.KeyControl get_backslashKey();
            /*0x7a41378*/ UnityEngine.InputSystem.Controls.KeyControl get_leftBracketKey();
            /*0x7a41380*/ UnityEngine.InputSystem.Controls.KeyControl get_rightBracketKey();
            /*0x7a41388*/ UnityEngine.InputSystem.Controls.KeyControl get_minusKey();
            /*0x7a41390*/ UnityEngine.InputSystem.Controls.KeyControl get_equalsKey();
            /*0x7a41398*/ UnityEngine.InputSystem.Controls.KeyControl get_aKey();
            /*0x7a413a0*/ UnityEngine.InputSystem.Controls.KeyControl get_bKey();
            /*0x7a413a8*/ UnityEngine.InputSystem.Controls.KeyControl get_cKey();
            /*0x7a413b0*/ UnityEngine.InputSystem.Controls.KeyControl get_dKey();
            /*0x7a413b8*/ UnityEngine.InputSystem.Controls.KeyControl get_eKey();
            /*0x7a413c0*/ UnityEngine.InputSystem.Controls.KeyControl get_fKey();
            /*0x7a413c8*/ UnityEngine.InputSystem.Controls.KeyControl get_gKey();
            /*0x7a413d0*/ UnityEngine.InputSystem.Controls.KeyControl get_hKey();
            /*0x7a413d8*/ UnityEngine.InputSystem.Controls.KeyControl get_iKey();
            /*0x7a413e0*/ UnityEngine.InputSystem.Controls.KeyControl get_jKey();
            /*0x7a413e8*/ UnityEngine.InputSystem.Controls.KeyControl get_kKey();
            /*0x7a413f0*/ UnityEngine.InputSystem.Controls.KeyControl get_lKey();
            /*0x7a413f8*/ UnityEngine.InputSystem.Controls.KeyControl get_mKey();
            /*0x7a41400*/ UnityEngine.InputSystem.Controls.KeyControl get_nKey();
            /*0x7a41408*/ UnityEngine.InputSystem.Controls.KeyControl get_oKey();
            /*0x7a41410*/ UnityEngine.InputSystem.Controls.KeyControl get_pKey();
            /*0x7a41418*/ UnityEngine.InputSystem.Controls.KeyControl get_qKey();
            /*0x7a41420*/ UnityEngine.InputSystem.Controls.KeyControl get_rKey();
            /*0x7a41428*/ UnityEngine.InputSystem.Controls.KeyControl get_sKey();
            /*0x7a41430*/ UnityEngine.InputSystem.Controls.KeyControl get_tKey();
            /*0x7a41438*/ UnityEngine.InputSystem.Controls.KeyControl get_uKey();
            /*0x7a41440*/ UnityEngine.InputSystem.Controls.KeyControl get_vKey();
            /*0x7a41448*/ UnityEngine.InputSystem.Controls.KeyControl get_wKey();
            /*0x7a41450*/ UnityEngine.InputSystem.Controls.KeyControl get_xKey();
            /*0x7a41458*/ UnityEngine.InputSystem.Controls.KeyControl get_yKey();
            /*0x7a41460*/ UnityEngine.InputSystem.Controls.KeyControl get_zKey();
            /*0x7a41468*/ UnityEngine.InputSystem.Controls.KeyControl get_digit1Key();
            /*0x7a41470*/ UnityEngine.InputSystem.Controls.KeyControl get_digit2Key();
            /*0x7a41478*/ UnityEngine.InputSystem.Controls.KeyControl get_digit3Key();
            /*0x7a41480*/ UnityEngine.InputSystem.Controls.KeyControl get_digit4Key();
            /*0x7a41488*/ UnityEngine.InputSystem.Controls.KeyControl get_digit5Key();
            /*0x7a41490*/ UnityEngine.InputSystem.Controls.KeyControl get_digit6Key();
            /*0x7a41498*/ UnityEngine.InputSystem.Controls.KeyControl get_digit7Key();
            /*0x7a414a0*/ UnityEngine.InputSystem.Controls.KeyControl get_digit8Key();
            /*0x7a414a8*/ UnityEngine.InputSystem.Controls.KeyControl get_digit9Key();
            /*0x7a414b0*/ UnityEngine.InputSystem.Controls.KeyControl get_digit0Key();
            /*0x7a414b8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftShiftKey();
            /*0x7a414c0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightShiftKey();
            /*0x7a414c8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftAltKey();
            /*0x7a414d0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightAltKey();
            /*0x7a414d8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftCtrlKey();
            /*0x7a414e0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightCtrlKey();
            /*0x7a414e8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftMetaKey();
            /*0x7a414f0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightMetaKey();
            /*0x7a414f8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftWindowsKey();
            /*0x7a41500*/ UnityEngine.InputSystem.Controls.KeyControl get_rightWindowsKey();
            /*0x7a41508*/ UnityEngine.InputSystem.Controls.KeyControl get_leftAppleKey();
            /*0x7a41510*/ UnityEngine.InputSystem.Controls.KeyControl get_rightAppleKey();
            /*0x7a41518*/ UnityEngine.InputSystem.Controls.KeyControl get_leftCommandKey();
            /*0x7a41520*/ UnityEngine.InputSystem.Controls.KeyControl get_rightCommandKey();
            /*0x7a41528*/ UnityEngine.InputSystem.Controls.KeyControl get_contextMenuKey();
            /*0x7a41530*/ UnityEngine.InputSystem.Controls.KeyControl get_escapeKey();
            /*0x7a41538*/ UnityEngine.InputSystem.Controls.KeyControl get_leftArrowKey();
            /*0x7a41540*/ UnityEngine.InputSystem.Controls.KeyControl get_rightArrowKey();
            /*0x7a41548*/ UnityEngine.InputSystem.Controls.KeyControl get_upArrowKey();
            /*0x7a41550*/ UnityEngine.InputSystem.Controls.KeyControl get_downArrowKey();
            /*0x7a41558*/ UnityEngine.InputSystem.Controls.KeyControl get_backspaceKey();
            /*0x7a41560*/ UnityEngine.InputSystem.Controls.KeyControl get_pageDownKey();
            /*0x7a41568*/ UnityEngine.InputSystem.Controls.KeyControl get_pageUpKey();
            /*0x7a41570*/ UnityEngine.InputSystem.Controls.KeyControl get_homeKey();
            /*0x7a41578*/ UnityEngine.InputSystem.Controls.KeyControl get_endKey();
            /*0x7a41580*/ UnityEngine.InputSystem.Controls.KeyControl get_insertKey();
            /*0x7a41588*/ UnityEngine.InputSystem.Controls.KeyControl get_deleteKey();
            /*0x7a41590*/ UnityEngine.InputSystem.Controls.KeyControl get_capsLockKey();
            /*0x7a41598*/ UnityEngine.InputSystem.Controls.KeyControl get_scrollLockKey();
            /*0x7a415a0*/ UnityEngine.InputSystem.Controls.KeyControl get_numLockKey();
            /*0x7a415a8*/ UnityEngine.InputSystem.Controls.KeyControl get_printScreenKey();
            /*0x7a415b0*/ UnityEngine.InputSystem.Controls.KeyControl get_pauseKey();
            /*0x7a415b8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadEnterKey();
            /*0x7a415c0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadDivideKey();
            /*0x7a415c8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadMultiplyKey();
            /*0x7a415d0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadMinusKey();
            /*0x7a415d8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadPlusKey();
            /*0x7a415e0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadPeriodKey();
            /*0x7a415e8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadEqualsKey();
            /*0x7a415f0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad0Key();
            /*0x7a415f8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad1Key();
            /*0x7a41600*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad2Key();
            /*0x7a41608*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad3Key();
            /*0x7a41610*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad4Key();
            /*0x7a41618*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad5Key();
            /*0x7a41620*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad6Key();
            /*0x7a41628*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad7Key();
            /*0x7a41630*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad8Key();
            /*0x7a41638*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad9Key();
            /*0x7a41640*/ UnityEngine.InputSystem.Controls.KeyControl get_f1Key();
            /*0x7a41648*/ UnityEngine.InputSystem.Controls.KeyControl get_f2Key();
            /*0x7a41650*/ UnityEngine.InputSystem.Controls.KeyControl get_f3Key();
            /*0x7a41658*/ UnityEngine.InputSystem.Controls.KeyControl get_f4Key();
            /*0x7a41660*/ UnityEngine.InputSystem.Controls.KeyControl get_f5Key();
            /*0x7a41668*/ UnityEngine.InputSystem.Controls.KeyControl get_f6Key();
            /*0x7a41670*/ UnityEngine.InputSystem.Controls.KeyControl get_f7Key();
            /*0x7a41678*/ UnityEngine.InputSystem.Controls.KeyControl get_f8Key();
            /*0x7a41680*/ UnityEngine.InputSystem.Controls.KeyControl get_f9Key();
            /*0x7a41688*/ UnityEngine.InputSystem.Controls.KeyControl get_f10Key();
            /*0x7a41690*/ UnityEngine.InputSystem.Controls.KeyControl get_f11Key();
            /*0x7a41698*/ UnityEngine.InputSystem.Controls.KeyControl get_f12Key();
            /*0x7a416a0*/ UnityEngine.InputSystem.Controls.KeyControl get_oem1Key();
            /*0x7a416a8*/ UnityEngine.InputSystem.Controls.KeyControl get_oem2Key();
            /*0x7a416b0*/ UnityEngine.InputSystem.Controls.KeyControl get_oem3Key();
            /*0x7a416b8*/ UnityEngine.InputSystem.Controls.KeyControl get_oem4Key();
            /*0x7a416c0*/ UnityEngine.InputSystem.Controls.KeyControl get_oem5Key();
            /*0x7a416c8*/ UnityEngine.InputSystem.Controls.ButtonControl get_shiftKey();
            /*0x7a416d0*/ void set_shiftKey(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a416e0*/ UnityEngine.InputSystem.Controls.ButtonControl get_ctrlKey();
            /*0x7a416e8*/ void set_ctrlKey(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a416f8*/ UnityEngine.InputSystem.Controls.ButtonControl get_altKey();
            /*0x7a41700*/ void set_altKey(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a41710*/ UnityEngine.InputSystem.Controls.ButtonControl get_imeSelected();
            /*0x7a41718*/ void set_imeSelected(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a412ac*/ UnityEngine.InputSystem.Controls.KeyControl get_Item(UnityEngine.InputSystem.Key key);
            /*0x7a41728*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys();
            /*0x7a41828*/ void MakeCurrent();
            /*0x7a41888*/ void OnRemoved();
            /*0x7a41924*/ void FinishSetup();
            /*0x7a430cc*/ void RefreshConfiguration();
            /*0x7a431ac*/ void OnTextInput(char character);
            /*0x7a4324c*/ UnityEngine.InputSystem.Controls.KeyControl FindKeyOnCurrentKeyboardLayout(string displayName);
            /*0x7a43320*/ void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString);
            /*0x7a4341c*/ UnityEngine.InputSystem.Controls.KeyControl[] get_keys();
            /*0x7a43424*/ void set_keys(UnityEngine.InputSystem.Controls.KeyControl[] value);
        }

        class Mouse : UnityEngine.InputSystem.Pointer, UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver
        {
            static /*0x0*/ UnityEngine.InputSystem.Mouse <current>k__BackingField;
            static /*0x8*/ UnityEngine.InputSystem.Mouse s_PlatformMouseDevice;
            /*0x1b8*/ UnityEngine.InputSystem.Controls.DeltaControl <scroll>k__BackingField;
            /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <leftButton>k__BackingField;
            /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <middleButton>k__BackingField;
            /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <rightButton>k__BackingField;
            /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <backButton>k__BackingField;
            /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <forwardButton>k__BackingField;
            /*0x1e8*/ UnityEngine.InputSystem.Controls.IntegerControl <clickCount>k__BackingField;

            static /*0x7a434e4*/ UnityEngine.InputSystem.Mouse get_current();
            static /*0x7a4352c*/ void set_current(UnityEngine.InputSystem.Mouse value);
            /*0x7a43e68*/ Mouse();
            /*0x7a4343c*/ UnityEngine.InputSystem.Controls.DeltaControl get_scroll();
            /*0x7a43444*/ void set_scroll(UnityEngine.InputSystem.Controls.DeltaControl value);
            /*0x7a43454*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftButton();
            /*0x7a4345c*/ void set_leftButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a4346c*/ UnityEngine.InputSystem.Controls.ButtonControl get_middleButton();
            /*0x7a43474*/ void set_middleButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43484*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightButton();
            /*0x7a4348c*/ void set_rightButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a4349c*/ UnityEngine.InputSystem.Controls.ButtonControl get_backButton();
            /*0x7a434a4*/ void set_backButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a434b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_forwardButton();
            /*0x7a434bc*/ void set_forwardButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a434cc*/ UnityEngine.InputSystem.Controls.IntegerControl get_clickCount();
            /*0x7a434d4*/ void set_clickCount(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a43584*/ void MakeCurrent();
            /*0x7a43640*/ void OnAdded();
            /*0x7a436c0*/ void OnRemoved();
            /*0x7a437f4*/ void WarpCursorPosition(UnityEngine.Vector2 position);
            /*0x7a4389c*/ void FinishSetup();
            /*0x7a43cb8*/ void OnNextUpdate();
            /*0x7a43dd0*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a43e60*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a43e64*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
        }

        enum PenButton
        {
            Tip = 0,
            Eraser = 1,
            BarrelFirst = 2,
            BarrelSecond = 3,
            InRange = 4,
            BarrelThird = 5,
            BarrelFourth = 6,
            Barrel1 = 2,
            Barrel2 = 3,
            Barrel3 = 5,
            Barrel4 = 6,
        }

        class Pen : UnityEngine.InputSystem.Pointer
        {
            static /*0x0*/ UnityEngine.InputSystem.Pen <current>k__BackingField;
            /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <tip>k__BackingField;
            /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <eraser>k__BackingField;
            /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <firstBarrelButton>k__BackingField;
            /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <secondBarrelButton>k__BackingField;
            /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <thirdBarrelButton>k__BackingField;
            /*0x1e0*/ UnityEngine.InputSystem.Controls.ButtonControl <fourthBarrelButton>k__BackingField;
            /*0x1e8*/ UnityEngine.InputSystem.Controls.ButtonControl <inRange>k__BackingField;
            /*0x1f0*/ UnityEngine.InputSystem.Controls.Vector2Control <tilt>k__BackingField;
            /*0x1f8*/ UnityEngine.InputSystem.Controls.AxisControl <twist>k__BackingField;

            static /*0x7a43f50*/ UnityEngine.InputSystem.Pen get_current();
            static /*0x7a43f98*/ void set_current(UnityEngine.InputSystem.Pen value);
            /*0x7a44484*/ Pen();
            /*0x7a43e78*/ UnityEngine.InputSystem.Controls.ButtonControl get_tip();
            /*0x7a43e80*/ void set_tip(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43e90*/ UnityEngine.InputSystem.Controls.ButtonControl get_eraser();
            /*0x7a43e98*/ void set_eraser(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43ea8*/ UnityEngine.InputSystem.Controls.ButtonControl get_firstBarrelButton();
            /*0x7a43eb0*/ void set_firstBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43ec0*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondBarrelButton();
            /*0x7a43ec8*/ void set_secondBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43ed8*/ UnityEngine.InputSystem.Controls.ButtonControl get_thirdBarrelButton();
            /*0x7a43ee0*/ void set_thirdBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43ef0*/ UnityEngine.InputSystem.Controls.ButtonControl get_fourthBarrelButton();
            /*0x7a43ef8*/ void set_fourthBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43f08*/ UnityEngine.InputSystem.Controls.ButtonControl get_inRange();
            /*0x7a43f10*/ void set_inRange(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a43f20*/ UnityEngine.InputSystem.Controls.Vector2Control get_tilt();
            /*0x7a43f28*/ void set_tilt(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a43f38*/ UnityEngine.InputSystem.Controls.AxisControl get_twist();
            /*0x7a43f40*/ void set_twist(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a43ff0*/ UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.PenButton button);
            /*0x7a440e8*/ void MakeCurrent();
            /*0x7a44144*/ void OnRemoved();
            /*0x7a441dc*/ void FinishSetup();
        }

        class Pointer : UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver
        {
            static /*0x0*/ UnityEngine.InputSystem.Pointer <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector2Control <position>k__BackingField;
            /*0x190*/ UnityEngine.InputSystem.Controls.DeltaControl <delta>k__BackingField;
            /*0x198*/ UnityEngine.InputSystem.Controls.Vector2Control <radius>k__BackingField;
            /*0x1a0*/ UnityEngine.InputSystem.Controls.AxisControl <pressure>k__BackingField;
            /*0x1a8*/ UnityEngine.InputSystem.Controls.ButtonControl <press>k__BackingField;
            /*0x1b0*/ UnityEngine.InputSystem.Controls.IntegerControl <displayIndex>k__BackingField;

            static /*0x7a4451c*/ UnityEngine.InputSystem.Pointer get_current();
            static /*0x7a44564*/ void set_current(UnityEngine.InputSystem.Pointer value);
            /*0x7a43e70*/ Pointer();
            /*0x7a4448c*/ UnityEngine.InputSystem.Controls.Vector2Control get_position();
            /*0x7a44494*/ void set_position(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a444a4*/ UnityEngine.InputSystem.Controls.DeltaControl get_delta();
            /*0x7a444ac*/ void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value);
            /*0x7a444bc*/ UnityEngine.InputSystem.Controls.Vector2Control get_radius();
            /*0x7a444c4*/ void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a444d4*/ UnityEngine.InputSystem.Controls.AxisControl get_pressure();
            /*0x7a444dc*/ void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a444ec*/ UnityEngine.InputSystem.Controls.ButtonControl get_press();
            /*0x7a444f4*/ void set_press(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a44504*/ UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex();
            /*0x7a4450c*/ void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a435e0*/ void MakeCurrent();
            /*0x7a43758*/ void OnRemoved();
            /*0x7a43ac8*/ void FinishSetup();
            /*0x7a43d48*/ void OnNextUpdate();
            /*0x7a43e14*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a445bc*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a445c0*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a445c4*/ bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, ref uint offset);
        }

        class FastKeyboard : UnityEngine.InputSystem.Keyboard
        {
            static string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard";

            /*0x7a445cc*/ FastKeyboard();
            /*0x7a4771c*/ UnityEngine.InputSystem.Controls.AnyKeyControl Initialize_ctrlKeyboardanyKey(UnityEngine.InputSystem.Utilities.InternedString kAnyKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47920*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardescape(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47b28*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47d24*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardenter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47f2c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardtab(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48128*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48324*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48520*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardsemicolon(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4871c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcomma(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48918*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardperiod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48b14*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48d10*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48f0c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49108*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49304*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardminus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49500*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardequals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a496fc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardupArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a498f8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddownArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49af4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49cf0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49eec*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarda(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a0e8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardb(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a2e4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardc(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a4e0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardd(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a6dc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarde(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a8d8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4aad4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardg(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4acd0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardh(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4aecc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardi(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b0c8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardj(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b2c4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardk(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b4c0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b6bc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardm(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b8b8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardn(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4bab4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardo(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4bcb0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4beac*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardq(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c0a8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardr(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c2a4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboards(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c4a0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c69c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c898*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardv(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ca94*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardw(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4cc90*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardx(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ce8c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardy(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d088*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardz(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d284*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d46c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d654*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d83c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4da24*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4dc0c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ddf4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4dfdc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e1c4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e3ac*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e594*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e79c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e9a4*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardshift(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ebcc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4edd4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4efdc*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardalt(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f204*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f40c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f614*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardctrl(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f83c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4fa44*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4fc4c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcontextMenu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4fe54*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50050*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageDown(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5024c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageUp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50448*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardhome(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50644*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardend(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50840*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardinsert(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50a3c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddelete(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50c38*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcapsLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50e34*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51030*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardprintScreen(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5122c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardscrollLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51428*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpause(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51624*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEnter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51820*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadDivide(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51a1c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMultiply(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51c18*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPlus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51e14*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMinus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52010*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPeriod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5220c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEquals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52408*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52604*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52800*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a529fc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52bf8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52df4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52ff0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a531ec*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a533e8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a535e4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a537e0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a539dc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53bd8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53dd4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53fd0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a541cc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a543c8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a545c4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a547c0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a549bc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf10(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54bb8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf11(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54db4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf12(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54fb0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55198*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55380*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55568*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55750*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55938*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlKeyboardIMESelected(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
        }

        class FastMouse : UnityEngine.InputSystem.Mouse, UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver, UnityEngine.InputSystem.LowLevel.IEventMerger
        {
            static string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";

            static /*0x7a833cc*/ bool MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
            /*0x7a7eafc*/ FastMouse();
            /*0x7a7f5c4*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7f7b4*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousedelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7f97c*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousescroll(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7fb30*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousepress(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7fd34*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseleftButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7ff7c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouserightButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a801c4*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousemiddleButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a80400*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseforwardButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a805fc*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousebackButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a807f8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a809ec*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a80bb8*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousepointerId(UnityEngine.InputSystem.Utilities.InternedString kDigitalLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a80d4c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousedisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a80ef4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMouseclickCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a810b0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a812c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a814d0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a816dc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a818f0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a81b04*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a81d10*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a81ef0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a820d0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a822dc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolldown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a824f0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a82704*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a82910*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a82b08*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolly(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a82d14*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a82ef4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a830d4*/ void OnNextUpdate();
            /*0x7a83218*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a833c4*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a833c8*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a834e0*/ bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
        }

        class FastTouchscreen : UnityEngine.InputSystem.Touchscreen
        {
            static string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer";

            /*0x7a55b28*/ FastTouchscreen();
            /*0x7a59558*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreenprimaryTouch(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59720*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5990c*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreendelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59ad8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpressure(UnityEngine.InputSystem.Utilities.InternedString kAnalogLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59ccc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59e98*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a09c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreendisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a244*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch0(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a3f8*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch1(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a5ac*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch2(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a760*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch3(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a914*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch4(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5aac8*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch5(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ac7c*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch6(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ae30*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch7(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5afe4*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch8(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b198*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch9(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b34c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b570*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b78c*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b978*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5bb58*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5bd44*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5bf38*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c160*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c340*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c520*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c75c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c990*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5cb84*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5cd84*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5cf94*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d1a4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d3b0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d5c4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d7d8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d9e4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5dbc4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5dda4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5df84*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e164*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e344*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e524*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e734*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e944*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5eb50*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ed64*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ef78*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f184*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f364*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f544*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f724*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f904*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5fb28*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5fd44*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch0delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ff30*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60110*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a602fc*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a604f0*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch0press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60718*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a608f8*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60ad8*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60d14*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60f3c*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch0startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61130*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61330*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61540*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61750*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6195c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61b70*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61d84*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61f90*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62170*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62350*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62530*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62710*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a628f0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62ad0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62cf4*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62f10*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch1delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a630fc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a632dc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a634c8*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a636bc*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch1press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a638e4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63ac4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63ca4*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63ee0*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64108*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch1startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a642fc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a644fc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6470c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6491c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64b28*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64d3c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64f50*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6515c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6533c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6551c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a656fc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a658dc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65abc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65c9c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65ec0*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a660dc*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch2delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a662c8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a664a8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66694*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66888*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch2press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66ab0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66c90*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66e70*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a670ac*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a672d4*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch2startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a674c8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a676c8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a678d8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a67ae8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a67cf4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a67f08*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6811c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68328*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68508*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a686e8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a688c8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68aa8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68c88*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68e68*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6908c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a692a8*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch3delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69494*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69674*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69860*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69a54*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch3press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69c7c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69e5c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a03c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a278*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a4a0*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch3startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a694*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a894*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6aaa4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6acb4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6aec0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b0d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b2e8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b4f4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b6d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b8b4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6ba94*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6bc74*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6be54*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6c034*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6c258*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6c474*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch4delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6c660*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6c840*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6ca2c*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6cc20*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch4press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6ce48*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6d028*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6d208*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6d444*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6d66c*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch4startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6d860*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6da60*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6dc70*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6de80*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6e08c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6e2a0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6e4b4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6e6c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6e8a0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6ea80*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6ec60*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6ee40*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6f020*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6f200*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6f424*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6f640*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch5delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6f82c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6fa0c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6fbf8*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6fdec*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch5press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a70014*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a701f4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a703d4*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a70610*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a70838*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch5startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a70a2c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a70c2c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a70e3c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7104c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a71258*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7146c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a71680*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7188c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a71a6c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a71c4c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a71e2c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7200c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a721ec*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a723cc*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a725f0*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7280c*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch6delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a729f8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a72bd8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a72dc4*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a72fb8*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch6press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a731e0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a733c0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a735a0*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a737dc*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a73a04*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch6startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a73bf8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a73df8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74008*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74218*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74424*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74638*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7484c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74a58*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74c38*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74e18*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a74ff8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a751d8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a753b8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a75598*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a757bc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a759d8*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch7delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a75bc4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a75da4*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a75f90*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a76184*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch7press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a763ac*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7658c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7676c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a769a8*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a76bd0*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch7startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a76dc4*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a76fc4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a771d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a773e4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a775f0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a77804*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a77a18*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a77c24*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a77e04*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a77fe4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a781c4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a783a4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a78584*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a78764*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a78988*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a78ba4*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch8delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a78d90*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a78f70*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7915c*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79350*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch8press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79578*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79758*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79938*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79b74*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79d9c*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch8startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a79f90*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7a190*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7a3a0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7a5b0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7a7bc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7a9d0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7abe4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7adf0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7afd0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7b1b0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7b390*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7b570*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7b750*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7b930*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7bb54*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7bd70*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch9delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7bf5c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7c13c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7c328*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7c51c*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch9press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7c744*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7c924*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7cb04*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7cd40*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7cf68*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch9startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7d15c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7d35c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7d56c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7d77c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7d988*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7db9c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7ddb0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7dfbc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7e19c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7e37c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7e55c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7e73c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a7e91c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
        }

        class InputRemoting : System.IObservable<UnityEngine.InputSystem.InputRemoting.Message>, System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>
        {
            /*0x10*/ UnityEngine.InputSystem.InputRemoting.Flags m_Flags;
            /*0x18*/ UnityEngine.InputSystem.InputManager m_LocalManager;
            /*0x20*/ UnityEngine.InputSystem.InputRemoting.Subscriber[] m_Subscribers;
            /*0x28*/ UnityEngine.InputSystem.InputRemoting.RemoteSender[] m_Senders;

            static /*0x7a85998*/ UnityEngine.InputSystem.Utilities.InternedString BuildLayoutNamespace(int senderId);
            static /*0x3910ae8*/ byte[] SerializeData<TData>(TData data);
            static /*0x3910ae8*/ TData DeserializeData<TData>(byte[] data);
            /*0x7a83508*/ InputRemoting(UnityEngine.InputSystem.InputManager manager, bool startSendingOnConnect);
            /*0x7a834ec*/ bool get_sending();
            /*0x7a834f8*/ void set_sending(bool value);
            /*0x7a8359c*/ void StartSending();
            /*0x7a83820*/ void StopSending();
            /*0x7a83a74*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg);
            /*0x7a846a4*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error);
            /*0x7a846a8*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted();
            /*0x7a846ac*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer);
            /*0x7a83808*/ void SendInitialMessages();
            /*0x7a847b0*/ void SendAllGeneratedLayouts();
            /*0x7a84a6c*/ void SendLayout(string layoutName);
            /*0x7a84904*/ void SendAllDevices();
            /*0x7a84f38*/ void SendDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a85328*/ void SendEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
            /*0x7a85488*/ void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
            /*0x7a857f0*/ void SendLayoutChange(string layout, UnityEngine.InputSystem.InputControlLayoutChange change);
            /*0x7a84dcc*/ void Send(UnityEngine.InputSystem.InputRemoting.Message msg);
            /*0x7a858f4*/ int FindOrCreateSenderRecord(int senderId);
            /*0x7a85a24*/ int FindLocalDeviceId(int remoteDeviceId, int senderIndex);
            /*0x7a85a98*/ UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex);
            /*0x7a85b38*/ UnityEngine.InputSystem.InputManager get_manager();
            /*0x7a85b40*/ void RemoveRemoteDevices(int participantId);

            enum MessageType
            {
                Connect = 0,
                Disconnect = 1,
                NewLayout = 2,
                NewDevice = 3,
                NewEvents = 4,
                RemoveDevice = 5,
                RemoveLayout = 6,
                ChangeUsages = 7,
                StartSending = 8,
                StopSending = 9,
            }

            struct Message
            {
                /*0x10*/ int participantId;
                /*0x14*/ UnityEngine.InputSystem.InputRemoting.MessageType type;
                /*0x18*/ byte[] data;
            }

            enum Flags
            {
                Sending = 1,
                StartSendingOnConnect = 2,
            }

            struct RemoteSender
            {
                /*0x10*/ int senderId;
                /*0x18*/ UnityEngine.InputSystem.Utilities.InternedString[] layouts;
                /*0x20*/ UnityEngine.InputSystem.InputRemoting.RemoteInputDevice[] devices;
            }

            struct RemoteInputDevice
            {
                /*0x10*/ int remoteId;
                /*0x14*/ int localId;
                /*0x18*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription description;
            }

            class Subscriber : System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.InputRemoting owner;
                /*0x18*/ System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer;

                /*0x7a847a8*/ Subscriber();
                /*0x7a86114*/ void Dispose();
            }

            class ConnectMsg
            {
                static /*0x7a83af8*/ void Process(UnityEngine.InputSystem.InputRemoting receiver);
            }

            class StartSendingMsg
            {
                static /*0x7a84684*/ void Process(UnityEngine.InputSystem.InputRemoting receiver);
            }

            class StopSendingMsg
            {
                static /*0x7a84694*/ void Process(UnityEngine.InputSystem.InputRemoting receiver);
            }

            class DisconnectMsg
            {
                static /*0x7a83b3c*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);
            }

            class NewLayoutMsg
            {
                static /*0x7a84b20*/ System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(UnityEngine.InputSystem.InputRemoting sender, string layoutName);
                static /*0x7a83bd0*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);

                struct Data
                {
                    /*0x10*/ string name;
                    /*0x18*/ string layoutJson;
                    /*0x20*/ bool isOverride;
                }
            }

            class NewDeviceMsg
            {
                static /*0x7a84fbc*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a83cc8*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);

                struct Data
                {
                    /*0x10*/ string name;
                    /*0x18*/ string layout;
                    /*0x20*/ int deviceId;
                    /*0x28*/ string[] usages;
                    /*0x30*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription description;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.InputRemoting.NewDeviceMsg.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__1_0;

                    static /*0x7a868c0*/ <>c();
                    /*0x7a86928*/ <>c();
                    /*0x7a86930*/ string <Create>b__1_0(UnityEngine.InputSystem.Utilities.InternedString x);
                }
            }

            class NewEventsMsg
            {
                static /*0x7a85778*/ UnityEngine.InputSystem.InputRemoting.Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, bool isHardReset);
                static /*0x7a85228*/ UnityEngine.InputSystem.InputRemoting.Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a8538c*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.LowLevel.InputEvent* events, int eventCount);
                static /*0x7a8424c*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);
            }

            class ChangeUsageMsg
            {
                static /*0x7a85590*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a8430c*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);

                struct Data
                {
                    /*0x10*/ int deviceId;
                    /*0x18*/ string[] usages;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.InputRemoting.ChangeUsageMsg.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__1_0;

                    static /*0x7a86a84*/ <>c();
                    /*0x7a86aec*/ <>c();
                    /*0x7a86af4*/ string <Create>b__1_0(UnityEngine.InputSystem.Utilities.InternedString x);
                }
            }

            class RemoveDeviceMsg
            {
                static /*0x7a85544*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a84618*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);
            }
        }

        class RemoteInputPlayerConnection : UnityEngine.ScriptableObject, System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>, System.IObservable<UnityEngine.InputSystem.InputRemoting.Message>
        {
            static /*0x0*/ System.Guid kNewDeviceMsg;
            static /*0x10*/ System.Guid kNewLayoutMsg;
            static /*0x20*/ System.Guid kNewEventsMsg;
            static /*0x30*/ System.Guid kRemoveDeviceMsg;
            static /*0x40*/ System.Guid kChangeUsagesMsg;
            static /*0x50*/ System.Guid kStartSendingMsg;
            static /*0x60*/ System.Guid kStopSendingMsg;
            /*0x18*/ UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection m_Connection;
            /*0x20*/ UnityEngine.InputSystem.RemoteInputPlayerConnection.Subscriber[] m_Subscribers;
            /*0x28*/ int[] m_ConnectedIds;

            static /*0x7a87994*/ RemoteInputPlayerConnection();
            /*0x7a8798c*/ RemoteInputPlayerConnection();
            /*0x7a86b18*/ void Bind(UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection connection, bool isConnected);
            /*0x7a872c4*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer);
            /*0x7a871e8*/ void OnConnected(int id);
            /*0x7a875bc*/ void OnDisconnected(int id);
            /*0x7a8768c*/ void OnNewDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a87698*/ void OnNewLayout(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a876a4*/ void OnNewEvents(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a876b0*/ void OnRemoveDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a876bc*/ void OnChangeUsages(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a876c8*/ void OnStartSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a876d4*/ void OnStopSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a87484*/ void SendToSubscribers(UnityEngine.InputSystem.InputRemoting.MessageType type, UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a876e0*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg);
            /*0x7a87984*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error);
            /*0x7a87988*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted();

            class Subscriber : System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.RemoteInputPlayerConnection owner;
                /*0x18*/ System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer;

                /*0x7a8747c*/ Subscriber();
                /*0x7a87b78*/ void Dispose();
            }
        }

        class Sensor : UnityEngine.InputSystem.InputDevice
        {
            /*0x7a87d6c*/ Sensor();
            /*0x7a87bd0*/ float get_samplingFrequency();
            /*0x7a87cc4*/ void set_samplingFrequency(float value);
        }

        class Accelerometer : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.Accelerometer <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <acceleration>k__BackingField;

            static /*0x7a87d8c*/ UnityEngine.InputSystem.Accelerometer get_current();
            static /*0x7a87dd4*/ void set_current(UnityEngine.InputSystem.Accelerometer value);
            /*0x7a87fac*/ Accelerometer();
            /*0x7a87d74*/ UnityEngine.InputSystem.Controls.Vector3Control get_acceleration();
            /*0x7a87d7c*/ void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a87e2c*/ void MakeCurrent();
            /*0x7a87e8c*/ void OnRemoved();
            /*0x7a87f28*/ void FinishSetup();
        }

        class Gyroscope : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.Gyroscope <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField;

            static /*0x7a87fcc*/ UnityEngine.InputSystem.Gyroscope get_current();
            static /*0x7a88014*/ void set_current(UnityEngine.InputSystem.Gyroscope value);
            /*0x7a881ec*/ Gyroscope();
            /*0x7a87fb4*/ UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity();
            /*0x7a87fbc*/ void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a8806c*/ void MakeCurrent();
            /*0x7a880cc*/ void OnRemoved();
            /*0x7a88168*/ void FinishSetup();
        }

        class GravitySensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.GravitySensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <gravity>k__BackingField;

            static /*0x7a8820c*/ UnityEngine.InputSystem.GravitySensor get_current();
            static /*0x7a88254*/ void set_current(UnityEngine.InputSystem.GravitySensor value);
            /*0x7a8842c*/ GravitySensor();
            /*0x7a881f4*/ UnityEngine.InputSystem.Controls.Vector3Control get_gravity();
            /*0x7a881fc*/ void set_gravity(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a882ac*/ void FinishSetup();
            /*0x7a88330*/ void MakeCurrent();
            /*0x7a88390*/ void OnRemoved();
        }

        class AttitudeSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.AttitudeSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.QuaternionControl <attitude>k__BackingField;

            static /*0x7a8844c*/ UnityEngine.InputSystem.AttitudeSensor get_current();
            static /*0x7a88494*/ void set_current(UnityEngine.InputSystem.AttitudeSensor value);
            /*0x7a8866c*/ AttitudeSensor();
            /*0x7a88434*/ UnityEngine.InputSystem.Controls.QuaternionControl get_attitude();
            /*0x7a8843c*/ void set_attitude(UnityEngine.InputSystem.Controls.QuaternionControl value);
            /*0x7a884ec*/ void MakeCurrent();
            /*0x7a8854c*/ void OnRemoved();
            /*0x7a885e8*/ void FinishSetup();
        }

        class LinearAccelerationSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.LinearAccelerationSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <acceleration>k__BackingField;

            static /*0x7a8868c*/ UnityEngine.InputSystem.LinearAccelerationSensor get_current();
            static /*0x7a886d4*/ void set_current(UnityEngine.InputSystem.LinearAccelerationSensor value);
            /*0x7a888ac*/ LinearAccelerationSensor();
            /*0x7a88674*/ UnityEngine.InputSystem.Controls.Vector3Control get_acceleration();
            /*0x7a8867c*/ void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a8872c*/ void MakeCurrent();
            /*0x7a8878c*/ void OnRemoved();
            /*0x7a88828*/ void FinishSetup();
        }

        class MagneticFieldSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.MagneticFieldSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <magneticField>k__BackingField;

            static /*0x7a888cc*/ UnityEngine.InputSystem.MagneticFieldSensor get_current();
            static /*0x7a88914*/ void set_current(UnityEngine.InputSystem.MagneticFieldSensor value);
            /*0x7a88aec*/ MagneticFieldSensor();
            /*0x7a888b4*/ UnityEngine.InputSystem.Controls.Vector3Control get_magneticField();
            /*0x7a888bc*/ void set_magneticField(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a8896c*/ void MakeCurrent();
            /*0x7a889cc*/ void OnRemoved();
            /*0x7a88a68*/ void FinishSetup();
        }

        class LightSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.LightSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <lightLevel>k__BackingField;

            static /*0x7a88b0c*/ UnityEngine.InputSystem.LightSensor get_current();
            static /*0x7a88b54*/ void set_current(UnityEngine.InputSystem.LightSensor value);
            /*0x7a88d2c*/ LightSensor();
            /*0x7a88af4*/ UnityEngine.InputSystem.Controls.AxisControl get_lightLevel();
            /*0x7a88afc*/ void set_lightLevel(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a88bac*/ void MakeCurrent();
            /*0x7a88c0c*/ void OnRemoved();
            /*0x7a88ca8*/ void FinishSetup();
        }

        class PressureSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.PressureSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <atmosphericPressure>k__BackingField;

            static /*0x7a88d4c*/ UnityEngine.InputSystem.PressureSensor get_current();
            static /*0x7a88d94*/ void set_current(UnityEngine.InputSystem.PressureSensor value);
            /*0x7a88f6c*/ PressureSensor();
            /*0x7a88d34*/ UnityEngine.InputSystem.Controls.AxisControl get_atmosphericPressure();
            /*0x7a88d3c*/ void set_atmosphericPressure(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a88dec*/ void MakeCurrent();
            /*0x7a88e4c*/ void OnRemoved();
            /*0x7a88ee8*/ void FinishSetup();
        }

        class ProximitySensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.ProximitySensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <distance>k__BackingField;

            static /*0x7a88f8c*/ UnityEngine.InputSystem.ProximitySensor get_current();
            static /*0x7a88fd4*/ void set_current(UnityEngine.InputSystem.ProximitySensor value);
            /*0x7a891ac*/ ProximitySensor();
            /*0x7a88f74*/ UnityEngine.InputSystem.Controls.AxisControl get_distance();
            /*0x7a88f7c*/ void set_distance(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a8902c*/ void MakeCurrent();
            /*0x7a8908c*/ void OnRemoved();
            /*0x7a89128*/ void FinishSetup();
        }

        class HumiditySensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.HumiditySensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <relativeHumidity>k__BackingField;

            static /*0x7a891cc*/ UnityEngine.InputSystem.HumiditySensor get_current();
            static /*0x7a89214*/ void set_current(UnityEngine.InputSystem.HumiditySensor value);
            /*0x7a893ec*/ HumiditySensor();
            /*0x7a891b4*/ UnityEngine.InputSystem.Controls.AxisControl get_relativeHumidity();
            /*0x7a891bc*/ void set_relativeHumidity(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a8926c*/ void MakeCurrent();
            /*0x7a892cc*/ void OnRemoved();
            /*0x7a89368*/ void FinishSetup();
        }

        class AmbientTemperatureSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.AmbientTemperatureSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <ambientTemperature>k__BackingField;

            static /*0x7a8940c*/ UnityEngine.InputSystem.AmbientTemperatureSensor get_current();
            static /*0x7a89454*/ void set_current(UnityEngine.InputSystem.AmbientTemperatureSensor value);
            /*0x7a8962c*/ AmbientTemperatureSensor();
            /*0x7a893f4*/ UnityEngine.InputSystem.Controls.AxisControl get_ambientTemperature();
            /*0x7a893fc*/ void set_ambientTemperature(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a894ac*/ void MakeCurrent();
            /*0x7a8950c*/ void OnRemoved();
            /*0x7a895a8*/ void FinishSetup();
        }

        class StepCounter : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.StepCounter <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.IntegerControl <stepCounter>k__BackingField;

            static /*0x7a8964c*/ UnityEngine.InputSystem.StepCounter get_current();
            static /*0x7a89694*/ void set_current(UnityEngine.InputSystem.StepCounter value);
            /*0x7a8986c*/ StepCounter();
            /*0x7a89634*/ UnityEngine.InputSystem.Controls.IntegerControl get_stepCounter();
            /*0x7a8963c*/ void set_stepCounter(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a896ec*/ void MakeCurrent();
            /*0x7a8974c*/ void OnRemoved();
            /*0x7a897e8*/ void FinishSetup();
        }

        class HingeAngle : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.HingeAngle <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <angle>k__BackingField;

            static /*0x7a8988c*/ UnityEngine.InputSystem.HingeAngle get_current();
            static /*0x7a898d4*/ void set_current(UnityEngine.InputSystem.HingeAngle value);
            /*0x7a89aac*/ HingeAngle();
            /*0x7a89874*/ UnityEngine.InputSystem.Controls.AxisControl get_angle();
            /*0x7a8987c*/ void set_angle(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a8992c*/ void MakeCurrent();
            /*0x7a8998c*/ void OnRemoved();
            /*0x7a89a28*/ void FinishSetup();
        }

        enum TouchPhase
        {
            None = 0,
            Began = 1,
            Moved = 2,
            Ended = 3,
            Canceled = 4,
            Stationary = 5,
        }

        class Touchscreen : UnityEngine.InputSystem.Pointer, UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver, UnityEngine.InputSystem.LowLevel.IEventMerger, UnityEngine.InputSystem.LowLevel.ICustomDeviceReset
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_TouchscreenUpdateMarker;
            static /*0x8*/ Unity.Profiling.ProfilerMarker k_TouchAllocateMarker;
            static /*0x10*/ UnityEngine.InputSystem.Touchscreen <current>k__BackingField;
            static /*0x18*/ float s_TapTime;
            static /*0x1c*/ float s_TapDelayTime;
            static /*0x20*/ float s_TapRadiusSquared;
            /*0x1b8*/ UnityEngine.InputSystem.Controls.TouchControl <primaryTouch>k__BackingField;
            /*0x1c0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> <touches>k__BackingField;

            static /*0x7a8b4c0*/ Touchscreen();
            static /*0x7a89b70*/ UnityEngine.InputSystem.Touchscreen get_current();
            static /*0x7a89bc8*/ void set_current(UnityEngine.InputSystem.Touchscreen value);
            static /*0x7a8b33c*/ bool MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
            static /*0x7a8abf0*/ void TriggerTap(UnityEngine.InputSystem.Controls.TouchControl control, ref UnityEngine.InputSystem.LowLevel.TouchState state, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a8b4b8*/ Touchscreen();
            /*0x7a89ab4*/ UnityEngine.InputSystem.Controls.TouchControl get_primaryTouch();
            /*0x7a89abc*/ void set_primaryTouch(UnityEngine.InputSystem.Controls.TouchControl value);
            /*0x7a89acc*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches();
            /*0x7a89ad8*/ void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value);
            /*0x7a89aec*/ UnityEngine.InputSystem.Controls.TouchControl[] get_touchControlArray();
            /*0x7a89af4*/ void set_touchControlArray(UnityEngine.InputSystem.Controls.TouchControl[] value);
            /*0x7a89c28*/ void MakeCurrent();
            /*0x7a89cc4*/ void OnRemoved();
            /*0x7a89dbc*/ void FinishSetup();
            /*0x7a8a1a4*/ void OnNextUpdate();
            /*0x7a8a4e8*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a8acbc*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a8acc0*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a8acc4*/ bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, ref uint offset);
            /*0x7a8af5c*/ void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset();
            /*0x7a8b454*/ bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
        }

        class TrackedDevice : UnityEngine.InputSystem.InputDevice
        {
            /*0x188*/ UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;
            /*0x190*/ UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;
            /*0x198*/ UnityEngine.InputSystem.Controls.Vector3Control <devicePosition>k__BackingField;
            /*0x1a0*/ UnityEngine.InputSystem.Controls.QuaternionControl <deviceRotation>k__BackingField;

            /*0x7a8b748*/ TrackedDevice();
            /*0x7a8b574*/ UnityEngine.InputSystem.Controls.IntegerControl get_trackingState();
            /*0x7a8b57c*/ void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a8b58c*/ UnityEngine.InputSystem.Controls.ButtonControl get_isTracked();
            /*0x7a8b594*/ void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a8b5a4*/ UnityEngine.InputSystem.Controls.Vector3Control get_devicePosition();
            /*0x7a8b5ac*/ void set_devicePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a8b5bc*/ UnityEngine.InputSystem.Controls.QuaternionControl get_deviceRotation();
            /*0x7a8b5c4*/ void set_deviceRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
            /*0x7a8b5d4*/ void FinishSetup();
        }

        class InputExtensions
        {
            static /*0x7a8b750*/ bool IsInProgress(UnityEngine.InputSystem.InputActionPhase phase);
            static /*0x7a8b760*/ bool IsEndedOrCanceled(UnityEngine.InputSystem.TouchPhase phase);
            static /*0x7a8af40*/ bool IsActive(UnityEngine.InputSystem.TouchPhase phase);
            static /*0x7a8b770*/ bool IsModifierKey(UnityEngine.InputSystem.Key key);
            static /*0x7a8b780*/ bool IsTextInputKey(UnityEngine.InputSystem.Key key);
        }

        class InputFeatureNames
        {
            static string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE";
            static string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT";
            static string kUseOptimizedControls = "USE_OPTIMIZED_CONTROLS";
            static string kUseReadValueCaching = "USE_READ_VALUE_CACHING";
            static string kParanoidReadValueCachingChecks = "PARANOID_READ_VALUE_CACHING_CHECKS";
            static string kUseIMGUIEditorForAssets = "USE_IMGUI_EDITOR_FOR_ASSETS";
        }

        class InputManager
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_InputUpdateProfilerMarker;
            static /*0x8*/ Unity.Profiling.ProfilerMarker k_InputTryFindMatchingControllerMarker;
            static /*0x10*/ Unity.Profiling.ProfilerMarker k_InputAddDeviceMarker;
            static /*0x18*/ Unity.Profiling.ProfilerMarker k_InputRestoreDevicesAfterReloadMarker;
            static /*0x20*/ Unity.Profiling.ProfilerMarker k_InputRegisterCustomTypesMarker;
            static /*0x28*/ Unity.Profiling.ProfilerMarker k_InputOnBeforeUpdateMarker;
            static /*0x30*/ Unity.Profiling.ProfilerMarker k_InputOnAfterUpdateMarker;
            static /*0x38*/ Unity.Profiling.ProfilerMarker k_InputOnSettingsChangeMarker;
            static /*0x40*/ Unity.Profiling.ProfilerMarker k_InputOnDeviceSettingsChangeMarker;
            static /*0x48*/ Unity.Profiling.ProfilerMarker k_InputOnEventMarker;
            static /*0x50*/ Unity.Profiling.ProfilerMarker k_InputOnLayoutChangeMarker;
            static /*0x58*/ Unity.Profiling.ProfilerMarker k_InputOnDeviceChangeMarker;
            static /*0x60*/ Unity.Profiling.ProfilerMarker k_InputOnActionsChangeMarker;
            /*0x10*/ int m_LayoutRegistrationVersion;
            /*0x14*/ float m_PollingFrequency;
            /*0x18*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Collection m_Layouts;
            /*0x58*/ UnityEngine.InputSystem.Utilities.TypeTable m_Processors;
            /*0x60*/ UnityEngine.InputSystem.Utilities.TypeTable m_Interactions;
            /*0x68*/ UnityEngine.InputSystem.Utilities.TypeTable m_Composites;
            /*0x70*/ int m_DevicesCount;
            /*0x78*/ UnityEngine.InputSystem.InputDevice[] m_Devices;
            /*0x80*/ System.Collections.Generic.Dictionary<int, UnityEngine.InputSystem.InputDevice> m_DevicesById;
            /*0x88*/ int m_AvailableDeviceCount;
            /*0x90*/ UnityEngine.InputSystem.InputManager.AvailableDevice[] m_AvailableDevices;
            /*0x98*/ int m_DisconnectedDevicesCount;
            /*0xa0*/ UnityEngine.InputSystem.InputDevice[] m_DisconnectedDevices;
            /*0xa8*/ UnityEngine.InputSystem.LowLevel.InputUpdateType m_UpdateMask;
            /*0xac*/ UnityEngine.InputSystem.LowLevel.InputUpdateType m_CurrentUpdate;
            /*0xb0*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers m_StateBuffers;
            /*0xe8*/ UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior;
            /*0xf0*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>> m_DeviceChangeListeners;
            /*0x140*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_DeviceStateChangeListeners;
            /*0x190*/ UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks;
            /*0x1e0*/ UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate> m_DeviceCommandCallbacks;
            /*0x230*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange>> m_LayoutChangeListeners;
            /*0x280*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>> m_EventListeners;
            /*0x2d0*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_BeforeUpdateListeners;
            /*0x320*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_AfterUpdateListeners;
            /*0x370*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_SettingsChangedListeners;
            /*0x3c0*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_ActionsChangedListeners;
            /*0x410*/ bool m_NativeBeforeUpdateHooked;
            /*0x411*/ bool m_HaveDevicesWithStateCallbackReceivers;
            /*0x412*/ bool m_HasFocus;
            /*0x418*/ UnityEngine.InputSystem.LowLevel.InputEventStream m_InputEventStream;
            /*0x490*/ UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate;
            /*0x498*/ int m_DeviceFindExecuteCommandDeviceId;
            /*0x4a0*/ UnityEngine.InputSystem.LowLevel.IInputRuntime m_Runtime;
            /*0x4a8*/ UnityEngine.InputSystem.LowLevel.InputMetrics m_Metrics;
            /*0x4e0*/ UnityEngine.InputSystem.InputSettings m_Settings;
            /*0x4e8*/ bool m_OptimizedControlsFeatureEnabled;
            /*0x4e9*/ bool m_ReadValueCachingFeatureEnabled;
            /*0x4ea*/ bool m_ParanoidReadValueCachingChecksEnabled;
            /*0x4f0*/ UnityEngine.InputSystem.InputActionAsset m_Actions;
            /*0x4f8*/ bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent;
            /*0x500*/ UnityEngine.InputSystem.InputManager.StateChangeMonitorsForDevice[] m_StateChangeMonitors;
            /*0x508*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts;

            static /*0x7a984b4*/ InputManager();
            static /*0x7a94774*/ void ResetControlPathsRecursive(UnityEngine.InputSystem.InputControl control);
            /*0x7a984ac*/ InputManager();
            /*0x7a84ed0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices();
            /*0x7a8b7ac*/ UnityEngine.InputSystem.Utilities.TypeTable get_processors();
            /*0x7a8b7b4*/ UnityEngine.InputSystem.Utilities.TypeTable get_interactions();
            /*0x7a8b7bc*/ UnityEngine.InputSystem.Utilities.TypeTable get_composites();
            /*0x7a8b7c4*/ UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics();
            /*0x7a8b960*/ UnityEngine.InputSystem.InputSettings get_settings();
            /*0x7a8b968*/ void set_settings(UnityEngine.InputSystem.InputSettings value);
            /*0x7a8c05c*/ UnityEngine.InputSystem.InputActionAsset get_actions();
            /*0x7a8c064*/ void set_actions(UnityEngine.InputSystem.InputActionAsset value);
            /*0x7a8c104*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask();
            /*0x7a8c10c*/ void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value);
            /*0x7a8c330*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_defaultUpdateType();
            /*0x7a8c34c*/ UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior();
            /*0x7a8c354*/ void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value);
            /*0x7a8c43c*/ float get_pollingFrequency();
            /*0x7a8c444*/ void set_pollingFrequency(float value);
            /*0x7a83758*/ void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            /*0x7a839c4*/ void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            /*0x7a8c56c*/ void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
            /*0x7a8c5c4*/ void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
            /*0x7a8c61c*/ void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            /*0x7a8c674*/ void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            /*0x7a8c6cc*/ void add_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            /*0x7a8c9d4*/ void remove_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            /*0x7a837b0*/ void add_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            /*0x7a83a1c*/ void remove_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            /*0x7a83700*/ void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> value);
            /*0x7a8396c*/ void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> value);
            /*0x7a8ca2c*/ void add_onBeforeUpdate(System.Action value);
            /*0x7a8cb88*/ void remove_onBeforeUpdate(System.Action value);
            /*0x7a8cbe0*/ void add_onAfterUpdate(System.Action value);
            /*0x7a8cc38*/ void remove_onAfterUpdate(System.Action value);
            /*0x7a8cc90*/ void add_onSettingsChange(System.Action value);
            /*0x7a8cce8*/ void remove_onSettingsChange(System.Action value);
            /*0x7a8cd40*/ void add_onActionsChange(System.Action value);
            /*0x7a8cd98*/ void remove_onActionsChange(System.Action value);
            /*0x7a8cdf0*/ bool get_isProcessingEvents();
            /*0x7a8cdf8*/ bool get_gameIsPlaying();
            /*0x7a8ce00*/ bool get_gameHasFocus();
            /*0x7a8ce34*/ bool get_gameShouldGetInputRegardlessOfFocus();
            /*0x7a8ce58*/ void RegisterControlLayout(string name, System.Type type);
            /*0x7a8617c*/ void RegisterControlLayout(string json, string name, bool isOverride);
            /*0x7a8d9e0*/ void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout);
            /*0x7a8d3f8*/ void PerformLayoutPostRegistration(UnityEngine.InputSystem.Utilities.InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout, bool isOverride);
            /*0x3816710*/ void RegisterPrecompiledLayout<TDevice>(string metadata);
            /*0x7a8db6c*/ void RecreateDevicesUsingLayout(UnityEngine.InputSystem.Utilities.InternedString layout, bool isKnownToBeDeviceLayout);
            /*0x7a8deb0*/ bool IsControlOrChildUsingLayoutRecursive(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout);
            /*0x7a8dddc*/ bool IsControlUsingLayout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout);
            /*0x7a8d88c*/ void RegisterControlLayoutMatcher(string layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            /*0x7a8e710*/ void RegisterControlLayoutMatcher(System.Type type, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            /*0x7a8e104*/ void RecreateDevicesUsingLayoutWithInferiorMatch(UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher);
            /*0x7a8dfa8*/ void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, UnityEngine.InputSystem.Utilities.InternedString newLayout);
            /*0x7a8e350*/ void AddAvailableDevicesMatchingDescription(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher, UnityEngine.InputSystem.Utilities.InternedString layout);
            /*0x7a8f53c*/ void RemoveControlLayout(string name);
            /*0x7a8f77c*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(System.Type type);
            /*0x7a8616c*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(UnityEngine.InputSystem.Utilities.InternedString name);
            /*0x7a8e91c*/ UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingControlLayout(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, int deviceId);
            /*0x7a8f990*/ UnityEngine.InputSystem.Utilities.InternedString FindOrRegisterDeviceLayoutForType(System.Type type);
            /*0x7a8fa34*/ bool IsDeviceLayoutMarkedAsSupportedInSettings(UnityEngine.InputSystem.Utilities.InternedString layoutName);
            /*0x7a8fb40*/ System.Collections.Generic.IEnumerable<string> ListControlLayouts(string basedOn);
            int GetControls<TControl>(string path, ref UnityEngine.InputSystem.InputControlList<TControl> controls);
            /*0x7a8fbd0*/ void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a86794*/ void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a86958*/ void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a8fd28*/ void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device);
            /*0x7a8fe24*/ UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, string name);
            /*0x7a86648*/ UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name, UnityEngine.InputSystem.Utilities.InternedString variants);
            /*0x7a8f374*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Utilities.InternedString layout, int deviceId, string deviceName, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags, UnityEngine.InputSystem.Utilities.InternedString variants);
            /*0x7a8ede8*/ void AddDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a90988*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description);
            /*0x7a909cc*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags);
            /*0x7a90bb0*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, UnityEngine.InputSystem.Utilities.InternedString layout, string deviceName, int deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags);
            /*0x7a85c3c*/ void RemoveDevice(UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices);
            /*0x7a90db4*/ void FlushDisconnectedDevices();
            /*0x7a90e08*/ void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls, System.Nullable<bool> issueResetCommand);
            /*0x7a9195c*/ UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout);
            /*0x7a91a80*/ UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout);
            /*0x7a91b20*/ UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType);
            /*0x7a85ac0*/ UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id);
            /*0x7a91b7c*/ int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions);
            /*0x7a9050c*/ void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, bool enable, UnityEngine.InputSystem.InputManager.DeviceDisableScope scope);
            /*0x7a91d68*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
            /*0x7a86954*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
            /*0x3816710*/ void QueueEvent<TEvent>(ref TEvent inputEvent);
            /*0x7a91e34*/ void Update();
            /*0x7a91e60*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a91f0c*/ void Initialize(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings);
            /*0x7a93e00*/ void Destroy();
            /*0x7a91f68*/ void InitializeActions();
            /*0x7a9201c*/ void InitializeData();
            /*0x7a94508*/ void RegisterCustomTypes(System.Type[] types);
            /*0x7a942b0*/ void RegisterCustomTypes();
            /*0x7a934b0*/ void InstallRuntime(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime);
            /*0x7a93b98*/ void InstallGlobals();
            /*0x7a93f0c*/ void UninstallGlobals();
            /*0x7a94738*/ bool get_optimizedControlsFeatureEnabled();
            /*0x7a94740*/ void set_optimizedControlsFeatureEnabled(bool value);
            /*0x7a9474c*/ bool get_readValueCachingFeatureEnabled();
            /*0x7a94754*/ void set_readValueCachingFeatureEnabled(bool value);
            /*0x7a94760*/ bool get_paranoidReadValueCachingChecksEnabled();
            /*0x7a94768*/ void set_paranoidReadValueCachingChecksEnabled(bool value);
            /*0x7a8fee4*/ void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device);
            /*0x7a9009c*/ void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device);
            /*0x7a8c130*/ void ReallocateStateBuffers();
            /*0x7a9485c*/ void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device);
            /*0x7a90220*/ void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device);
            /*0x7a94a10*/ void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor);
            /*0x7a95128*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonString MakeEscapedJsonString(string theString);
            /*0x7a94e7c*/ UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor);
            /*0x7a8ca8c*/ void InstallBeforeUpdateHookIfNecessary();
            /*0x7a94e78*/ void RestoreDevicesAfterDomainReloadIfNecessary();
            /*0x7a952c8*/ void WarnAboutDevicesFailingToRecreateAfterDomainReload();
            /*0x7a952cc*/ void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a8ba6c*/ void ApplySettings();
            /*0x7a8c084*/ void ApplyActions();
            long ExecuteGlobalCommand<TCommand>(ref TCommand command);
            /*0x7a8c72c*/ void AddAvailableDevicesThatAreNowRecognized();
            /*0x7a904d0*/ bool ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device);
            /*0x7a954c8*/ void OnFocusChanged(bool focus);
            /*0x7a95708*/ bool ShouldRunUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a95724*/ void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer);
            /*0x7a96f08*/ bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed);
            /*0x7a970e0*/ string MakeStringWithEventsProcessedByDevice();
            /*0x7a97034*/ void ResetCurrentProcessedEventBytesForDevices();
            /*0x7a97220*/ void CheckAllDevicesOptimizedControlsHaveValidState();
            /*0x7a96cfc*/ void InvokeAfterUpdateCallback(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a973ac*/ void DontMakeCurrentlyUpdatingDeviceCurrent();
            /*0x7a96d98*/ bool UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a91424*/ bool UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a97734*/ void WriteStateChange(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref UnityEngine.InputSystem.LowLevel.InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers);
            /*0x7a97690*/ bool FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a97dc4*/ void AddStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex);
            /*0x7a90c88*/ void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device);
            /*0x7a97f24*/ void RemoveStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex);
            /*0x7a9807c*/ void AddStateChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex);
            /*0x7a98154*/ void RemoveStateChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex);
            /*0x7a973b4*/ void SortStateChangeMonitorsIfNecessary(int deviceIndex);
            /*0x7a98270*/ void SignalStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor);
            /*0x7a98360*/ void FireStateChangeNotifications();
            /*0x7a97408*/ bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes);
            /*0x7a97950*/ void FireStateChangeNotifications(int deviceIndex, double internalTime, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
            /*0x7a96a48*/ void ProcessStateChangeMonitorTimeouts();
            /*0x7a987e8*/ long <TryFindMatchingControlLayout>b__94_0(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand commandRef);

            enum DeviceDisableScope
            {
                Everywhere = 0,
                InFrontendOnly = 1,
                TemporaryWhilePlayerIsInBackground = 2,
            }

            struct AvailableDevice
            {
                /*0x10*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription description;
                /*0x48*/ int deviceId;
                /*0x4c*/ bool isNative;
                /*0x4d*/ bool isRemoved;
            }

            struct StateChangeMonitorTimeout
            {
                /*0x10*/ UnityEngine.InputSystem.InputControl control;
                /*0x18*/ double time;
                /*0x20*/ UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor;
                /*0x28*/ long monitorIndex;
                /*0x30*/ int timerIndex;
            }

            struct StateChangeMonitorListener
            {
                /*0x10*/ UnityEngine.InputSystem.InputControl control;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor;
                /*0x20*/ long monitorIndex;
                /*0x28*/ uint groupIndex;
            }

            struct StateChangeMonitorsForDevice
            {
                /*0x10*/ UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion[] memoryRegions;
                /*0x18*/ UnityEngine.InputSystem.InputManager.StateChangeMonitorListener[] listeners;
                /*0x20*/ UnityEngine.InputSystem.DynamicBitfield signalled;
                /*0x40*/ bool needToUpdateOrderingOfMonitors;
                /*0x41*/ bool needToCompactArrays;

                /*0x7a98850*/ int get_count();
                /*0x7a98858*/ void Add(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex);
                /*0x7a98a40*/ void Remove(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval);
                /*0x7a98c3c*/ void Clear();
                /*0x7a98ca0*/ void CompactArrays();
                /*0x7a98b8c*/ void RemoveAt(int i);
                /*0x7a98d04*/ void SortMonitorsByIndex();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputManager.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.InputSystem.InputDevice, string> <>9__184_0;

                static /*0x7a98e70*/ <>c();
                /*0x7a98ed8*/ <>c();
                /*0x7a98ee0*/ string <MakeDeviceNameUnique>b__184_0(UnityEngine.InputSystem.InputDevice x);
            }

            class <>c__82<TDevice>
            {
                static /*0x0*/ UnityEngine.InputSystem.InputManager.<>c__82<TDevice> <>9;
                static /*0x0*/ System.Func<UnityEngine.InputSystem.InputDevice> <>9__82_0;

                static /*0x383e7a0*/ <>c__82();
                /*0x38159dc*/ <>c__82();
                /*0x38148bc*/ UnityEngine.InputSystem.InputDevice <RegisterPrecompiledLayout>b__82_0();
            }

            class <ListControlLayouts>d__97 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ string basedOn;
                /*0x30*/ string <>3__basedOn;
                /*0x38*/ UnityEngine.InputSystem.InputManager <>4__this;
                /*0x40*/ UnityEngine.InputSystem.Utilities.InternedString <internedBasedOn>5__2;
                /*0x50*/ System.Collections.Generic.Dictionary.Enumerator<UnityEngine.InputSystem.Utilities.InternedString, System.Type> <>7__wrap2;
                /*0x80*/ System.Collections.Generic.Dictionary.Enumerator<UnityEngine.InputSystem.Utilities.InternedString, string> <>7__wrap3;
                /*0xb0*/ System.Collections.Generic.Dictionary.Enumerator<UnityEngine.InputSystem.Utilities.InternedString, System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>> <>7__wrap4;

                /*0x7a98f08*/ <ListControlLayouts>d__97(int <>1__state);
                /*0x7a98f3c*/ void System.IDisposable.Dispose();
                /*0x7a98f80*/ bool MoveNext();
                /*0x7a996ec*/ void <>m__Finally1();
                /*0x7a9973c*/ void <>m__Finally2();
                /*0x7a9978c*/ void <>m__Finally3();
                /*0x7a997dc*/ void <>m__Finally4();
                /*0x7a9982c*/ void <>m__Finally5();
                /*0x7a9987c*/ void <>m__Finally6();
                /*0x7a998cc*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x7a998d4*/ void System.Collections.IEnumerator.Reset();
                /*0x7a9990c*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a99914*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x7a999c8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class InputSettings : UnityEngine.ScriptableObject
        {
            static int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;
            /*0x18*/ string[] m_SupportedDevices;
            /*0x20*/ UnityEngine.InputSystem.InputSettings.UpdateMode m_UpdateMode;
            /*0x24*/ UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior;
            /*0x28*/ int m_MaxEventBytesPerUpdate;
            /*0x2c*/ int m_MaxQueuedEventsPerUpdate;
            /*0x30*/ bool m_CompensateForScreenOrientation;
            /*0x34*/ UnityEngine.InputSystem.InputSettings.BackgroundBehavior m_BackgroundBehavior;
            /*0x38*/ UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode;
            /*0x3c*/ UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode;
            /*0x40*/ float m_DefaultDeadzoneMin;
            /*0x44*/ float m_DefaultDeadzoneMax;
            /*0x48*/ float m_DefaultButtonPressPoint;
            /*0x4c*/ float m_ButtonReleaseThreshold;
            /*0x50*/ float m_DefaultTapTime;
            /*0x54*/ float m_DefaultSlowTapTime;
            /*0x58*/ float m_DefaultHoldTime;
            /*0x5c*/ float m_TapRadius;
            /*0x60*/ float m_MultiTapDelayTime;
            /*0x64*/ bool m_DisableRedundantEventsMerging;
            /*0x65*/ bool m_ShortcutKeysConsumeInputs;
            /*0x68*/ System.Collections.Generic.HashSet<string> m_FeatureFlags;

            static /*0x7a9a090*/ bool CompareFloats(float a, float b);
            static /*0x3910ae8*/ bool CompareSets<T>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> a, UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> b);
            static /*0x7a9a0a8*/ bool CompareFeatureFlag(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b, string featureName);
            static /*0x7a9a0f0*/ bool AreEqual(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b);
            /*0x7a9a44c*/ InputSettings();
            /*0x7a999cc*/ UnityEngine.InputSystem.InputSettings.UpdateMode get_updateMode();
            /*0x7a999d4*/ void set_updateMode(UnityEngine.InputSystem.InputSettings.UpdateMode value);
            /*0x7a99ab8*/ UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior();
            /*0x7a99ac0*/ void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value);
            /*0x7a99ad8*/ bool get_compensateForScreenOrientation();
            /*0x7a99ae0*/ void set_compensateForScreenOrientation(bool value);
            /*0x7a99afc*/ bool get_filterNoiseOnCurrent();
            /*0x7a99b04*/ void set_filterNoiseOnCurrent(bool value);
            /*0x7a99b08*/ float get_defaultDeadzoneMin();
            /*0x7a99b10*/ void set_defaultDeadzoneMin(float value);
            /*0x7a99b28*/ float get_defaultDeadzoneMax();
            /*0x7a99b30*/ void set_defaultDeadzoneMax(float value);
            /*0x7a99b48*/ float get_defaultButtonPressPoint();
            /*0x7a99b50*/ void set_defaultButtonPressPoint(float value);
            /*0x7a99b84*/ float get_buttonReleaseThreshold();
            /*0x7a99b8c*/ void set_buttonReleaseThreshold(float value);
            /*0x7a99ba4*/ float get_defaultTapTime();
            /*0x7a99bac*/ void set_defaultTapTime(float value);
            /*0x7a99bc4*/ float get_defaultSlowTapTime();
            /*0x7a99bcc*/ void set_defaultSlowTapTime(float value);
            /*0x7a99be4*/ float get_defaultHoldTime();
            /*0x7a99bec*/ void set_defaultHoldTime(float value);
            /*0x7a99c04*/ float get_tapRadius();
            /*0x7a99c0c*/ void set_tapRadius(float value);
            /*0x7a99c24*/ float get_multiTapDelayTime();
            /*0x7a99c2c*/ void set_multiTapDelayTime(float value);
            /*0x7a99c44*/ UnityEngine.InputSystem.InputSettings.BackgroundBehavior get_backgroundBehavior();
            /*0x7a99c4c*/ void set_backgroundBehavior(UnityEngine.InputSystem.InputSettings.BackgroundBehavior value);
            /*0x7a99c64*/ UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode();
            /*0x7a99c6c*/ void set_editorInputBehaviorInPlayMode(UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode value);
            /*0x7a99c84*/ UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode();
            /*0x7a99c8c*/ void set_inputActionPropertyDrawerMode(UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode value);
            /*0x7a99ca4*/ int get_maxEventBytesPerUpdate();
            /*0x7a99cac*/ void set_maxEventBytesPerUpdate(int value);
            /*0x7a99cc4*/ int get_maxQueuedEventsPerUpdate();
            /*0x7a99ccc*/ void set_maxQueuedEventsPerUpdate(int value);
            /*0x7a99ce4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<string> get_supportedDevices();
            /*0x7a99d44*/ void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<string> value);
            /*0x7a99e74*/ bool get_disableRedundantEventsMerging();
            /*0x7a99e7c*/ void set_disableRedundantEventsMerging(bool value);
            /*0x7a99e98*/ bool get_shortcutKeysConsumeInput();
            /*0x7a99ea0*/ void set_shortcutKeysConsumeInput(bool value);
            /*0x7a99ebc*/ void SetInternalFeatureFlag(string featureName, bool enabled);
            /*0x7a9a014*/ bool IsFeatureEnabled(string featureName);
            /*0x7a999ec*/ void OnChange();

            enum UpdateMode
            {
                ProcessEventsInDynamicUpdate = 1,
                ProcessEventsInFixedUpdate = 2,
                ProcessEventsManually = 3,
            }

            enum ScrollDeltaBehavior
            {
                UniformAcrossAllPlatforms = 0,
                KeepPlatformSpecificInputRange = 1,
            }

            enum BackgroundBehavior
            {
                ResetAndDisableNonBackgroundDevices = 0,
                ResetAndDisableAllDevices = 1,
                IgnoreFocus = 2,
            }

            enum EditorInputBehaviorInPlayMode
            {
                PointersAndKeyboardsRespectGameViewFocus = 0,
                AllDevicesRespectGameViewFocus = 1,
                AllDeviceInputAlwaysGoesToGameView = 2,
            }

            enum InputActionPropertyDrawerMode
            {
                Compact = 0,
                MultilineEffective = 1,
                MultilineBoth = 2,
            }
        }

        class DefaultInputActions : UnityEngine.InputSystem.IInputActionCollection2, UnityEngine.InputSystem.IInputActionCollection, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable, System.IDisposable
        {
            /*0x10*/ UnityEngine.InputSystem.InputActionAsset <asset>k__BackingField;
            /*0x18*/ UnityEngine.InputSystem.InputActionMap m_Player;
            /*0x20*/ UnityEngine.InputSystem.DefaultInputActions.IPlayerActions m_PlayerActionsCallbackInterface;
            /*0x28*/ UnityEngine.InputSystem.InputAction m_Player_Move;
            /*0x30*/ UnityEngine.InputSystem.InputAction m_Player_Look;
            /*0x38*/ UnityEngine.InputSystem.InputAction m_Player_Fire;
            /*0x40*/ UnityEngine.InputSystem.InputActionMap m_UI;
            /*0x48*/ UnityEngine.InputSystem.DefaultInputActions.IUIActions m_UIActionsCallbackInterface;
            /*0x50*/ UnityEngine.InputSystem.InputAction m_UI_Navigate;
            /*0x58*/ UnityEngine.InputSystem.InputAction m_UI_Submit;
            /*0x60*/ UnityEngine.InputSystem.InputAction m_UI_Cancel;
            /*0x68*/ UnityEngine.InputSystem.InputAction m_UI_Point;
            /*0x70*/ UnityEngine.InputSystem.InputAction m_UI_Click;
            /*0x78*/ UnityEngine.InputSystem.InputAction m_UI_ScrollWheel;
            /*0x80*/ UnityEngine.InputSystem.InputAction m_UI_MiddleClick;
            /*0x88*/ UnityEngine.InputSystem.InputAction m_UI_RightClick;
            /*0x90*/ UnityEngine.InputSystem.InputAction m_UI_TrackedDevicePosition;
            /*0x98*/ UnityEngine.InputSystem.InputAction m_UI_TrackedDeviceOrientation;
            /*0xa0*/ int m_KeyboardMouseSchemeIndex;
            /*0xa4*/ int m_GamepadSchemeIndex;
            /*0xa8*/ int m_TouchSchemeIndex;
            /*0xac*/ int m_JoystickSchemeIndex;
            /*0xb0*/ int m_XRSchemeIndex;

            /*0x7a9a490*/ DefaultInputActions();
            /*0x7a9a488*/ UnityEngine.InputSystem.InputActionAsset get_asset();
            /*0x7a9a8c4*/ void Dispose();
            /*0x7a9a920*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x7a9a948*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x7a9a994*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            /*0x7a9a9d4*/ void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            /*0x7a9aa20*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x7a9aa3c*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x7a9aa58*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator();
            /*0x7a9aa74*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7a9aa90*/ void Enable();
            /*0x7a9aaac*/ void Disable();
            /*0x7a9aac8*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x7a9aae4*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            /*0x7a9ab04*/ int FindBinding(UnityEngine.InputSystem.InputBinding bindingMask, ref UnityEngine.InputSystem.InputAction action);
            /*0x7a9ab60*/ UnityEngine.InputSystem.DefaultInputActions.PlayerActions get_Player();
            /*0x7a9ab80*/ UnityEngine.InputSystem.DefaultInputActions.UIActions get_UI();
            /*0x7a9aba0*/ UnityEngine.InputSystem.InputControlScheme get_KeyboardMouseScheme();
            /*0x7a9ac64*/ UnityEngine.InputSystem.InputControlScheme get_GamepadScheme();
            /*0x7a9ad28*/ UnityEngine.InputSystem.InputControlScheme get_TouchScheme();
            /*0x7a9adec*/ UnityEngine.InputSystem.InputControlScheme get_JoystickScheme();
            /*0x7a9aeb0*/ UnityEngine.InputSystem.InputControlScheme get_XRScheme();

            struct PlayerActions
            {
                /*0x10*/ UnityEngine.InputSystem.DefaultInputActions m_Wrapper;

                static /*0x7a9b058*/ UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.PlayerActions set);
                /*0x7a9af74*/ PlayerActions(UnityEngine.InputSystem.DefaultInputActions wrapper);
                /*0x7a9af7c*/ UnityEngine.InputSystem.InputAction get_Move();
                /*0x7a9af98*/ UnityEngine.InputSystem.InputAction get_Look();
                /*0x7a9afb4*/ UnityEngine.InputSystem.InputAction get_Fire();
                /*0x7a9afd0*/ UnityEngine.InputSystem.InputActionMap Get();
                /*0x7a9afec*/ void Enable();
                /*0x7a9b010*/ void Disable();
                /*0x7a9b034*/ bool get_enabled();
                /*0x7a9b070*/ void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IPlayerActions instance);
            }

            struct UIActions
            {
                /*0x10*/ UnityEngine.InputSystem.DefaultInputActions m_Wrapper;

                static /*0x7a9bcf4*/ UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.UIActions set);
                /*0x7a9bb4c*/ UIActions(UnityEngine.InputSystem.DefaultInputActions wrapper);
                /*0x7a9bb54*/ UnityEngine.InputSystem.InputAction get_Navigate();
                /*0x7a9bb70*/ UnityEngine.InputSystem.InputAction get_Submit();
                /*0x7a9bb8c*/ UnityEngine.InputSystem.InputAction get_Cancel();
                /*0x7a9bba8*/ UnityEngine.InputSystem.InputAction get_Point();
                /*0x7a9bbc4*/ UnityEngine.InputSystem.InputAction get_Click();
                /*0x7a9bbe0*/ UnityEngine.InputSystem.InputAction get_ScrollWheel();
                /*0x7a9bbfc*/ UnityEngine.InputSystem.InputAction get_MiddleClick();
                /*0x7a9bc18*/ UnityEngine.InputSystem.InputAction get_RightClick();
                /*0x7a9bc34*/ UnityEngine.InputSystem.InputAction get_TrackedDevicePosition();
                /*0x7a9bc50*/ UnityEngine.InputSystem.InputAction get_TrackedDeviceOrientation();
                /*0x7a9bc6c*/ UnityEngine.InputSystem.InputActionMap Get();
                /*0x7a9bc88*/ void Enable();
                /*0x7a9bcac*/ void Disable();
                /*0x7a9bcd0*/ bool get_enabled();
                /*0x7a9bd0c*/ void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IUIActions instance);
            }

            interface IPlayerActions
            {
                void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnLook(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnFire(UnityEngine.InputSystem.InputAction.CallbackContext context);
            }

            interface IUIActions
            {
                void OnNavigate(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnSubmit(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnCancel(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnPoint(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnClick(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnScrollWheel(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnMiddleClick(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnRightClick(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnTrackedDevicePosition(UnityEngine.InputSystem.InputAction.CallbackContext context);
                void OnTrackedDeviceOrientation(UnityEngine.InputSystem.InputAction.CallbackContext context);
            }
        }

        class InputValue
        {
            /*0x10*/ System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext> m_Context;

            /*0x7a9e114*/ InputValue();
            /*0x7a9e030*/ object Get();
            /*0x3910ae8*/ TValue Get<TValue>();
            /*0x7a9e098*/ bool get_isPressed();
        }

        class PlayerInput : UnityEngine.MonoBehaviour
        {
            static string DeviceLostMessage = "OnDeviceLost";
            static string DeviceRegainedMessage = "OnDeviceRegained";
            static string ControlsChangedMessage = "OnControlsChanged";
            static /*0x0*/ int s_AllActivePlayersCount;
            static /*0x8*/ UnityEngine.InputSystem.PlayerInput[] s_AllActivePlayers;
            static /*0x10*/ System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> s_UserChangeDelegate;
            static /*0x18*/ int s_InitPairWithDevicesCount;
            static /*0x20*/ UnityEngine.InputSystem.InputDevice[] s_InitPairWithDevices;
            static /*0x28*/ int s_InitPlayerIndex;
            static /*0x2c*/ int s_InitSplitScreenIndex;
            static /*0x30*/ string s_InitControlScheme;
            static /*0x38*/ bool s_DestroyIfDeviceSetupUnsuccessful;
            /*0x20*/ int m_AllMapsHashCode;
            /*0x28*/ UnityEngine.InputSystem.InputActionAsset m_Actions;
            /*0x30*/ UnityEngine.InputSystem.PlayerNotifications m_NotificationBehavior;
            /*0x38*/ UnityEngine.InputSystem.UI.InputSystemUIInputModule m_UIInputModule;
            /*0x40*/ UnityEngine.InputSystem.PlayerInput.DeviceLostEvent m_DeviceLostEvent;
            /*0x48*/ UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent m_DeviceRegainedEvent;
            /*0x50*/ UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent m_ControlsChangedEvent;
            /*0x58*/ UnityEngine.InputSystem.PlayerInput.ActionEvent[] m_ActionEvents;
            /*0x60*/ bool m_NeverAutoSwitchControlSchemes;
            /*0x68*/ string m_DefaultControlScheme;
            /*0x70*/ string m_DefaultActionMap;
            /*0x78*/ int m_SplitScreenIndex;
            /*0x80*/ UnityEngine.Camera m_Camera;
            /*0x88*/ UnityEngine.InputSystem.InputValue m_InputValueObject;
            /*0x90*/ UnityEngine.InputSystem.InputActionMap m_CurrentActionMap;
            /*0x98*/ int m_PlayerIndex;
            /*0x9c*/ bool m_InputActive;
            /*0x9d*/ bool m_Enabled;
            /*0x9e*/ bool m_ActionsInitialized;
            /*0xa0*/ System.Collections.Generic.Dictionary<string, string> m_ActionMessageNames;
            /*0xa8*/ UnityEngine.InputSystem.Users.InputUser m_InputUser;
            /*0xb0*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ActionTriggeredDelegate;
            /*0xb8*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceLostCallbacks;
            /*0x108*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceRegainedCallbacks;
            /*0x158*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_ControlsChangedCallbacks;
            /*0x1a8*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionTriggeredCallbacks;
            /*0x1f8*/ System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate;
            /*0x200*/ System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate;
            /*0x208*/ bool m_OnUnpairedDeviceUsedHooked;
            /*0x210*/ System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> m_DeviceChangeDelegate;
            /*0x218*/ bool m_OnDeviceChangeHooked;

            static /*0x7aa5a74*/ PlayerInput();
            static /*0x7aa0510*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all();
            static /*0x7aa05a0*/ bool get_isSinglePlayer();
            static /*0x7aa18c8*/ UnityEngine.InputSystem.PlayerInput GetPlayerByIndex(int playerIndex);
            static /*0x7aa19c4*/ UnityEngine.InputSystem.PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7aa1b2c*/ UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, UnityEngine.InputSystem.InputDevice pairWithDevice);
            static /*0x7aa1ee4*/ UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, UnityEngine.InputSystem.InputDevice[] pairWithDevices);
            static /*0x7aa1c90*/ UnityEngine.InputSystem.PlayerInput DoInstantiate(UnityEngine.GameObject prefab);
            static /*0x7aa4e4c*/ void OnUserChange(UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device);
            static /*0x7aa5018*/ bool OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7aa5a60*/ PlayerInput();
            /*0x7a9e11c*/ bool get_inputIsActive();
            /*0x7a9e124*/ bool get_active();
            /*0x7a9e12c*/ int get_playerIndex();
            /*0x7a9e134*/ int get_splitScreenIndex();
            /*0x7a9e13c*/ UnityEngine.InputSystem.InputActionAsset get_actions();
            /*0x7a9e690*/ void set_actions(UnityEngine.InputSystem.InputActionAsset value);
            /*0x7a9f42c*/ string get_currentControlScheme();
            /*0x7a9f64c*/ string get_defaultControlScheme();
            /*0x7a9f654*/ void set_defaultControlScheme(string value);
            /*0x7a9f65c*/ bool get_neverAutoSwitchControlSchemes();
            /*0x7a9f664*/ void set_neverAutoSwitchControlSchemes(bool value);
            /*0x7a9f860*/ UnityEngine.InputSystem.InputActionMap get_currentActionMap();
            /*0x7a9f868*/ void set_currentActionMap(UnityEngine.InputSystem.InputActionMap value);
            /*0x7a9f8d0*/ string get_defaultActionMap();
            /*0x7a9f8d8*/ void set_defaultActionMap(string value);
            /*0x7a9f8e0*/ UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior();
            /*0x7a9f8e8*/ void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value);
            /*0x7a9f940*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents();
            /*0x7a9f988*/ void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value);
            /*0x7a9fa14*/ UnityEngine.InputSystem.PlayerInput.DeviceLostEvent get_deviceLostEvent();
            /*0x7a9fac8*/ UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent get_deviceRegainedEvent();
            /*0x7a9fb7c*/ UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent get_controlsChangedEvent();
            /*0x7a9fc30*/ void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x7a9fccc*/ void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x7a9fd68*/ void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a9fe04*/ void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a9fea0*/ void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a9ff3c*/ void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a9ffd8*/ void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7aa0074*/ void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7aa0110*/ UnityEngine.Camera get_camera();
            /*0x7aa0118*/ void set_camera(UnityEngine.Camera value);
            /*0x7aa0120*/ UnityEngine.InputSystem.UI.InputSystemUIInputModule get_uiInputModule();
            /*0x7aa0128*/ void set_uiInputModule(UnityEngine.InputSystem.UI.InputSystemUIInputModule value);
            /*0x7aa02a0*/ UnityEngine.InputSystem.Users.InputUser get_user();
            /*0x7aa02a8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices();
            /*0x7aa03e8*/ bool get_hasMissingRequiredDevices();
            /*0x3910ae8*/ TDevice GetDevice<TDevice>();
            /*0x7a9f370*/ void ActivateInput();
            /*0x7aa06b8*/ void UpdateDelegates();
            /*0x7aa0fc8*/ void DeactivateInput();
            /*0x7aa0fec*/ void PassivateInput();
            /*0x7aa1010*/ bool SwitchCurrentControlScheme(UnityEngine.InputSystem.InputDevice[] devices);
            /*0x7aa169c*/ void SwitchCurrentControlScheme(string controlScheme, UnityEngine.InputSystem.InputDevice[] devices);
            /*0x7aa08b4*/ void SwitchCurrentActionMap(string mapNameOrId);
            /*0x7a9e180*/ void InitializeActions();
            /*0x7a9e7a0*/ void UninitializeActions();
            /*0x7aa0a1c*/ void InstallOnActionTriggeredHook();
            /*0x7aa2080*/ void UninstallOnActionTriggeredHook();
            /*0x7aa220c*/ void OnActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7aa0bf0*/ void CacheMessageNames();
            /*0x7a9e974*/ void ClearCaches();
            /*0x7a9e9cc*/ void AssignUserAndDevices();
            /*0x7aa2c7c*/ bool HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7aa3164*/ void UnassignUserAndDevices();
            /*0x7aa2978*/ bool TryToActivateControlScheme(UnityEngine.InputSystem.InputControlScheme controlScheme);
            /*0x7aa3630*/ void AssignPlayerIndex();
            /*0x7aa382c*/ void OnEnable();
            /*0x7a9f69c*/ void StartListeningForUnpairedDeviceActivity();
            /*0x7a9f7e4*/ void StopListeningForUnpairedDeviceActivity();
            /*0x7aa3ddc*/ void StartListeningForDeviceChanges();
            /*0x7aa4614*/ void StopListeningForDeviceChanges();
            /*0x7aa4680*/ void OnDisable();
            /*0x7aa4b8c*/ void DebugLogAction(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7aa4c04*/ void HandleDeviceLost();
            /*0x7aa4d28*/ void HandleDeviceRegained();
            /*0x7aa3eac*/ void HandleControlsChanged();
            /*0x7aa515c*/ void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7aa5810*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
            /*0x7aa11dc*/ void SwitchControlSchemeInternal(ref UnityEngine.InputSystem.InputControlScheme controlScheme, UnityEngine.InputSystem.InputDevice[] devices);

            class ActionEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.InputAction.CallbackContext>
            {
                /*0x30*/ string m_ActionId;
                /*0x38*/ string m_ActionName;

                /*0x7aa5ad0*/ ActionEvent();
                /*0x7aa5b18*/ ActionEvent(UnityEngine.InputSystem.InputAction action);
                /*0x7aa5d00*/ ActionEvent(System.Guid actionGUID, string name);
                /*0x7aa5ac0*/ string get_actionId();
                /*0x7aa5ac8*/ string get_actionName();
            }

            class DeviceLostEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a9fa80*/ DeviceLostEvent();
            }

            class DeviceRegainedEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a9fb34*/ DeviceRegainedEvent();
            }

            class ControlsChangedEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a9fbe8*/ ControlsChangedEvent();
            }
        }

        class PlayerInputManager : UnityEngine.MonoBehaviour
        {
            static string PlayerJoinedMessage = "OnPlayerJoined";
            static string PlayerLeftMessage = "OnPlayerLeft";
            static /*0x0*/ UnityEngine.InputSystem.PlayerInputManager <instance>k__BackingField;
            /*0x20*/ UnityEngine.InputSystem.PlayerNotifications m_NotificationBehavior;
            /*0x24*/ int m_MaxPlayerCount;
            /*0x28*/ bool m_AllowJoining;
            /*0x2c*/ UnityEngine.InputSystem.PlayerJoinBehavior m_JoinBehavior;
            /*0x30*/ UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent m_PlayerJoinedEvent;
            /*0x38*/ UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent m_PlayerLeftEvent;
            /*0x40*/ UnityEngine.InputSystem.InputActionProperty m_JoinAction;
            /*0x58*/ UnityEngine.GameObject m_PlayerPrefab;
            /*0x60*/ bool m_SplitScreen;
            /*0x61*/ bool m_MaintainAspectRatioInSplitScreen;
            /*0x64*/ int m_FixedNumberOfSplitScreens;
            /*0x68*/ UnityEngine.Rect m_SplitScreenRect;
            /*0x78*/ bool m_JoinActionDelegateHooked;
            /*0x79*/ bool m_UnpairedDeviceUsedDelegateHooked;
            /*0x80*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_JoinActionDelegate;
            /*0x88*/ System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate;
            /*0x90*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_PlayerJoinedCallbacks;
            /*0xe0*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_PlayerLeftCallbacks;

            static /*0x7aa6db4*/ UnityEngine.InputSystem.PlayerInputManager get_instance();
            static /*0x7aa6dfc*/ void set_instance(UnityEngine.InputSystem.PlayerInputManager value);
            static /*0x7aa7438*/ string[] get_messages();
            /*0x7aa7da8*/ PlayerInputManager();
            /*0x7aa5d90*/ bool get_splitScreen();
            /*0x7aa5d98*/ void set_splitScreen(bool value);
            /*0x7aa6528*/ bool get_maintainAspectRatioInSplitScreen();
            /*0x7aa6530*/ int get_fixedNumberOfSplitScreens();
            /*0x7aa6538*/ UnityEngine.Rect get_splitScreenArea();
            /*0x7aa6544*/ int get_playerCount();
            /*0x7aa659c*/ int get_maxPlayerCount();
            /*0x7aa65a4*/ bool get_joiningEnabled();
            /*0x7aa65ac*/ UnityEngine.InputSystem.PlayerJoinBehavior get_joinBehavior();
            /*0x7aa65b4*/ void set_joinBehavior(UnityEngine.InputSystem.PlayerJoinBehavior value);
            /*0x7aa68ec*/ UnityEngine.InputSystem.InputActionProperty get_joinAction();
            /*0x7aa6900*/ void set_joinAction(UnityEngine.InputSystem.InputActionProperty value);
            /*0x7aa69bc*/ UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior();
            /*0x7aa69c4*/ void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value);
            /*0x7aa69cc*/ UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent get_playerJoinedEvent();
            /*0x7aa6a80*/ UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent get_playerLeftEvent();
            /*0x7aa6b34*/ void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7aa6bd0*/ void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7aa6c6c*/ void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7aa6d08*/ void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7aa6da4*/ UnityEngine.GameObject get_playerPrefab();
            /*0x7aa6dac*/ void set_playerPrefab(UnityEngine.GameObject value);
            /*0x7aa66e8*/ void EnableJoining();
            /*0x7aa6604*/ void DisableJoining();
            /*0x7aa6e58*/ void JoinPlayerFromUI();
            /*0x7aa7184*/ void JoinPlayerFromAction(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7aa7294*/ void JoinPlayerFromActionIfNotAlreadyJoined(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7aa71d8*/ UnityEngine.InputSystem.PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, UnityEngine.InputSystem.InputDevice pairWithDevice);
            /*0x7aa737c*/ UnityEngine.InputSystem.PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, UnityEngine.InputSystem.InputDevice[] pairWithDevices);
            /*0x7aa6ea4*/ bool CheckIfPlayerCanJoin(int playerIndex);
            /*0x7aa74f4*/ void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7aa796c*/ void OnEnable();
            /*0x7aa7cbc*/ void OnDisable();
            /*0x7aa5fcc*/ void UpdateSplitScreen();
            /*0x7aa75a8*/ bool IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device);
            /*0x7aa6e54*/ void ValidateInputActionAsset();
            /*0x7aa3fd0*/ void NotifyPlayerJoined(UnityEngine.InputSystem.PlayerInput player);
            /*0x7aa4a5c*/ void NotifyPlayerLeft(UnityEngine.InputSystem.PlayerInput player);

            class PlayerJoinedEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7aa6a38*/ PlayerJoinedEvent();
            }

            class PlayerLeftEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7aa6aec*/ PlayerLeftEvent();
            }
        }

        enum PlayerJoinBehavior
        {
            JoinPlayersWhenButtonIsPressed = 0,
            JoinPlayersWhenJoinActionIsTriggered = 1,
            JoinPlayersManually = 2,
        }

        enum PlayerNotifications
        {
            SendMessages = 0,
            BroadcastMessages = 1,
            InvokeUnityEvents = 2,
            InvokeCSharpEvents = 3,
        }

        struct DynamicBitfield
        {
            /*0x10*/ UnityEngine.InputSystem.Utilities.InlinedArray<ulong> array;
            /*0x28*/ int length;

            static /*0x7aa7dd0*/ int BitCountToULongCount(int bitCount);
            /*0x7a989cc*/ void SetLength(int newLength);
            /*0x7aa7de8*/ void SetBit(int bitIndex);
            /*0x7aa7e80*/ bool TestBit(int bitIndex);
            /*0x7a98af4*/ void ClearBit(int bitIndex);
            /*0x7aa7ef0*/ bool AnyBitIsSet();
        }

        namespace XR
        {
            struct PoseState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                static int kSizeInBytes = 60;
                static /*0x0*/ UnityEngine.InputSystem.Utilities.FourCC s_Format;
                /*0x10*/ bool isTracked;
                /*0x14*/ UnityEngine.XR.InputTrackingState trackingState;
                /*0x18*/ UnityEngine.Vector3 position;
                /*0x24*/ UnityEngine.Quaternion rotation;
                /*0x34*/ UnityEngine.Vector3 velocity;
                /*0x40*/ UnityEngine.Vector3 angularVelocity;

                static /*0x7aa800c*/ PoseState();
                /*0x7aa7fcc*/ PoseState(bool isTracked, UnityEngine.XR.InputTrackingState trackingState, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 velocity, UnityEngine.Vector3 angularVelocity);
                /*0x7aa7f74*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            class PoseControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.XR.PoseState>
            {
                /*0x178*/ UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;
                /*0x180*/ UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;
                /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField;
                /*0x190*/ UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField;
                /*0x198*/ UnityEngine.InputSystem.Controls.Vector3Control <velocity>k__BackingField;
                /*0x1a0*/ UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField;

                /*0x7aa8108*/ PoseControl();
                /*0x7aa8078*/ UnityEngine.InputSystem.Controls.ButtonControl get_isTracked();
                /*0x7aa8080*/ void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7aa8090*/ UnityEngine.InputSystem.Controls.IntegerControl get_trackingState();
                /*0x7aa8098*/ void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7aa80a8*/ UnityEngine.InputSystem.Controls.Vector3Control get_position();
                /*0x7aa80b0*/ void set_position(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aa80c0*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rotation();
                /*0x7aa80c8*/ void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aa80d8*/ UnityEngine.InputSystem.Controls.Vector3Control get_velocity();
                /*0x7aa80e0*/ void set_velocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aa80f0*/ UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity();
                /*0x7aa80f8*/ void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aa81b8*/ void FinishSetup();
                /*0x7aa83a8*/ UnityEngine.InputSystem.XR.PoseState ReadUnprocessedValueFromState(void* statePtr);
                /*0x7aa85c4*/ void WriteValueIntoState(UnityEngine.InputSystem.XR.PoseState value, void* statePtr);
                /*0x7aa8740*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class XRHMD : UnityEngine.InputSystem.TrackedDevice
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyePosition>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.QuaternionControl <centerEyeRotation>k__BackingField;

                /*0x7aa8ba0*/ XRHMD();
                /*0x7aa895c*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition();
                /*0x7aa8964*/ void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aa8974*/ UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation();
                /*0x7aa897c*/ void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aa898c*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition();
                /*0x7aa8994*/ void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aa89a4*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation();
                /*0x7aa89ac*/ void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aa89bc*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyePosition();
                /*0x7aa89c4*/ void set_centerEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aa89d4*/ UnityEngine.InputSystem.Controls.QuaternionControl get_centerEyeRotation();
                /*0x7aa89dc*/ void set_centerEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aa89ec*/ void FinishSetup();
            }

            class XRController : UnityEngine.InputSystem.TrackedDevice
            {
                static /*0x7aa8ba8*/ UnityEngine.InputSystem.XR.XRController get_leftHand();
                static /*0x7aa8c48*/ UnityEngine.InputSystem.XR.XRController get_rightHand();
                /*0x7aa8e28*/ XRController();
                /*0x7aa8ce8*/ void FinishSetup();
            }

            class XRControllerWithRumble : UnityEngine.InputSystem.XR.XRController
            {
                /*0x7aa8f58*/ XRControllerWithRumble();
                /*0x7aa8e30*/ void SendImpulse(float amplitude, float duration);
            }

            class TrackedPoseDriver : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x20*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType m_TrackingType;
                /*0x24*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType m_UpdateType;
                /*0x28*/ bool m_IgnoreTrackingState;
                /*0x30*/ UnityEngine.InputSystem.InputActionProperty m_PositionInput;
                /*0x48*/ UnityEngine.InputSystem.InputActionProperty m_RotationInput;
                /*0x60*/ UnityEngine.InputSystem.InputActionProperty m_TrackingStateInput;
                /*0x78*/ UnityEngine.Vector3 m_CurrentPosition;
                /*0x84*/ UnityEngine.Quaternion m_CurrentRotation;
                /*0x94*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStates m_CurrentTrackingState;
                /*0x98*/ bool m_RotationBound;
                /*0x99*/ bool m_PositionBound;
                /*0x9a*/ bool m_TrackingStateBound;
                /*0x9b*/ bool m_IsFirstUpdate;
                /*0xa0*/ UnityEngine.InputSystem.InputAction m_PositionAction;
                /*0xa8*/ UnityEngine.InputSystem.InputAction m_RotationAction;

                /*0x7aaa6a4*/ TrackedPoseDriver();
                /*0x7aa8f60*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType get_trackingType();
                /*0x7aa8f68*/ void set_trackingType(UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType value);
                /*0x7aa8f70*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType get_updateType();
                /*0x7aa8f78*/ void set_updateType(UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType value);
                /*0x7aa8f80*/ bool get_ignoreTrackingState();
                /*0x7aa8f88*/ void set_ignoreTrackingState(bool value);
                /*0x7aa8f94*/ UnityEngine.InputSystem.InputActionProperty get_positionInput();
                /*0x7aa8fa8*/ void set_positionInput(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa9348*/ UnityEngine.InputSystem.InputActionProperty get_rotationInput();
                /*0x7aa935c*/ void set_rotationInput(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa96fc*/ UnityEngine.InputSystem.InputActionProperty get_trackingStateInput();
                /*0x7aa9710*/ void set_trackingStateInput(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa9ab0*/ void BindActions();
                /*0x7aa9ad0*/ void UnbindActions();
                /*0x7aa91b8*/ void BindPosition();
                /*0x7aa956c*/ void BindRotation();
                /*0x7aa9920*/ void BindTrackingState();
                /*0x7aa9af0*/ void RenameAndEnable(UnityEngine.InputSystem.InputAction action, string name);
                /*0x7aa9074*/ void UnbindPosition();
                /*0x7aa9428*/ void UnbindRotation();
                /*0x7aa97dc*/ void UnbindTrackingState();
                /*0x7aa9b20*/ void OnPositionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa9b80*/ void OnPositionCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa9bd8*/ void OnRotationPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa9c38*/ void OnRotationCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa9c88*/ void OnTrackingStatePerformed(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa9ce4*/ void OnTrackingStateCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa9cec*/ void Reset();
                /*0x7aa9ee4*/ void Awake();
                /*0x7aa9f94*/ void OnEnable();
                /*0x7aaa04c*/ void OnDisable();
                /*0x7aaa0f8*/ void OnDestroy();
                /*0x7aaa124*/ void UpdateCallback();
                /*0x7aaa248*/ void ReadTrackingState();
                /*0x7aaa37c*/ void OnUpdate();
                /*0x7aaa398*/ void OnBeforeRender();
                /*0x7aaa3b8*/ void PerformUpdate();
                /*0x7aaa3d4*/ void SetLocalTransform(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation);
                /*0x7aa9f10*/ bool HasStereoCamera(ref UnityEngine.Camera cameraComponent);
                /*0x7aaa540*/ UnityEngine.InputSystem.InputAction get_positionAction();
                /*0x7aaa54c*/ void set_positionAction(UnityEngine.InputSystem.InputAction value);
                /*0x7aaa594*/ UnityEngine.InputSystem.InputAction get_rotationAction();
                /*0x7aaa5a0*/ void set_rotationAction(UnityEngine.InputSystem.InputAction value);
                /*0x7aaa5e8*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x7aaa5ec*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

                enum TrackingType
                {
                    RotationAndPosition = 0,
                    RotationOnly = 1,
                    PositionOnly = 2,
                }

                enum TrackingStates
                {
                    None = 0,
                    Position = 1,
                    Rotation = 2,
                }

                enum UpdateType
                {
                    UpdateAndBeforeRender = 0,
                    Update = 1,
                    BeforeRender = 2,
                }
            }

            class XRLayoutBuilder
            {
                static /*0x0*/ string[] poseSubControlNames;
                static /*0x8*/ UnityEngine.InputSystem.XR.FeatureType[] poseSubControlTypes;
                /*0x10*/ string parentLayout;
                /*0x18*/ string interfaceName;
                /*0x20*/ UnityEngine.InputSystem.XR.XRDeviceDescriptor descriptor;

                static /*0x7aabb6c*/ XRLayoutBuilder();
                static /*0x7aaa74c*/ uint GetSizeOfFeature(UnityEngine.InputSystem.XR.XRFeatureDescriptor featureDescriptor);
                static /*0x7aaa7c4*/ string SanitizeString(string original, bool allowPaths);
                static /*0x7aaa914*/ string OnFindLayoutForDevice(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate);
                static /*0x7aaad64*/ string ConvertPotentialAliasToName(UnityEngine.InputSystem.Layouts.InputControlLayout layout, string nameOrAlias);
                /*0x7aaad5c*/ XRLayoutBuilder();
                /*0x7aaaee0*/ bool IsSubControl(string name);
                /*0x7aaaefc*/ string GetParentControlName(string name);
                /*0x7aaaf34*/ bool IsPoseControl(System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor> features, int startIndex);
                /*0x7aab088*/ UnityEngine.InputSystem.Layouts.InputControlLayout Build();

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.InputSystem.XR.XRLayoutBuilder layout;

                    /*0x7aaad54*/ <>c__DisplayClass5_0();
                    /*0x7aabd80*/ UnityEngine.InputSystem.Layouts.InputControlLayout <OnFindLayoutForDevice>b__0();
                }
            }

            class XRUtilities
            {
                static string InterfaceMatchAnyVersion = "^(XRInput)";
                static string InterfaceV1 = "XRInput";
                static string InterfaceCurrent = "XRInputV1";
            }

            enum FeatureType
            {
                Custom = 0,
                Binary = 1,
                DiscreteStates = 2,
                Axis1D = 3,
                Axis2D = 4,
                Axis3D = 5,
                Rotation = 6,
                Hand = 7,
                Bone = 8,
                Eyes = 9,
            }

            struct UsageHint
            {
                /*0x10*/ string content;
            }

            struct XRFeatureDescriptor
            {
                /*0x10*/ string name;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.InputSystem.XR.UsageHint> usageHints;
                /*0x20*/ UnityEngine.InputSystem.XR.FeatureType featureType;
                /*0x24*/ uint customSize;
            }

            class XRDeviceDescriptor
            {
                /*0x10*/ string deviceName;
                /*0x18*/ string manufacturer;
                /*0x20*/ string serialNumber;
                /*0x28*/ UnityEngine.XR.InputDeviceCharacteristics characteristics;
                /*0x2c*/ int deviceId;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor> inputFeatures;

                static /*0x7aa8de0*/ UnityEngine.InputSystem.XR.XRDeviceDescriptor FromJson(string json);
                /*0x7aabda0*/ XRDeviceDescriptor();
                /*0x7aabd98*/ string ToJson();
            }

            struct Bone
            {
                /*0x10*/ uint m_ParentBoneIndex;
                /*0x14*/ UnityEngine.Vector3 m_Position;
                /*0x20*/ UnityEngine.Quaternion m_Rotation;

                /*0x7aabda8*/ uint get_parentBoneIndex();
                /*0x7aabdb0*/ void set_parentBoneIndex(uint value);
                /*0x7aabdb8*/ UnityEngine.Vector3 get_position();
                /*0x7aabdc4*/ void set_position(UnityEngine.Vector3 value);
                /*0x7aabdd0*/ UnityEngine.Quaternion get_rotation();
                /*0x7aabddc*/ void set_rotation(UnityEngine.Quaternion value);
            }

            struct Eyes
            {
                /*0x10*/ UnityEngine.Vector3 m_LeftEyePosition;
                /*0x1c*/ UnityEngine.Quaternion m_LeftEyeRotation;
                /*0x2c*/ UnityEngine.Vector3 m_RightEyePosition;
                /*0x38*/ UnityEngine.Quaternion m_RightEyeRotation;
                /*0x48*/ UnityEngine.Vector3 m_FixationPoint;
                /*0x54*/ float m_LeftEyeOpenAmount;
                /*0x58*/ float m_RightEyeOpenAmount;

                /*0x7aabde8*/ UnityEngine.Vector3 get_leftEyePosition();
                /*0x7aabdf4*/ void set_leftEyePosition(UnityEngine.Vector3 value);
                /*0x7aabe00*/ UnityEngine.Quaternion get_leftEyeRotation();
                /*0x7aabe0c*/ void set_leftEyeRotation(UnityEngine.Quaternion value);
                /*0x7aabe18*/ UnityEngine.Vector3 get_rightEyePosition();
                /*0x7aabe24*/ void set_rightEyePosition(UnityEngine.Vector3 value);
                /*0x7aabe30*/ UnityEngine.Quaternion get_rightEyeRotation();
                /*0x7aabe3c*/ void set_rightEyeRotation(UnityEngine.Quaternion value);
                /*0x7aabe48*/ UnityEngine.Vector3 get_fixationPoint();
                /*0x7aabe54*/ void set_fixationPoint(UnityEngine.Vector3 value);
                /*0x7aabe60*/ float get_leftEyeOpenAmount();
                /*0x7aabe68*/ void set_leftEyeOpenAmount(float value);
                /*0x7aabe70*/ float get_rightEyeOpenAmount();
                /*0x7aabe78*/ void set_rightEyeOpenAmount(float value);
            }

            class BoneControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.XR.Bone>
            {
                /*0x140*/ UnityEngine.InputSystem.Controls.IntegerControl <parentBoneIndex>k__BackingField;
                /*0x148*/ UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField;
                /*0x150*/ UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField;

                /*0x7aac174*/ BoneControl();
                /*0x7aabe80*/ UnityEngine.InputSystem.Controls.IntegerControl get_parentBoneIndex();
                /*0x7aabe88*/ void set_parentBoneIndex(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7aabe98*/ UnityEngine.InputSystem.Controls.Vector3Control get_position();
                /*0x7aabea0*/ void set_position(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aabeb0*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rotation();
                /*0x7aabeb8*/ void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aabec8*/ void FinishSetup();
                /*0x7aac000*/ UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(void* statePtr);
                /*0x7aac0f0*/ void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, void* statePtr);
            }

            class EyesControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.XR.Eyes>
            {
                /*0x198*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField;
                /*0x1a0*/ UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField;
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.Vector3Control <fixationPoint>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.AxisControl <leftEyeOpenAmount>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.AxisControl <rightEyeOpenAmount>k__BackingField;

                /*0x7aac754*/ EyesControl();
                /*0x7aac1bc*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition();
                /*0x7aac1c4*/ void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aac1d4*/ UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation();
                /*0x7aac1dc*/ void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aac1ec*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition();
                /*0x7aac1f4*/ void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aac204*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation();
                /*0x7aac20c*/ void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7aac21c*/ UnityEngine.InputSystem.Controls.Vector3Control get_fixationPoint();
                /*0x7aac224*/ void set_fixationPoint(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7aac234*/ UnityEngine.InputSystem.Controls.AxisControl get_leftEyeOpenAmount();
                /*0x7aac23c*/ void set_leftEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7aac24c*/ UnityEngine.InputSystem.Controls.AxisControl get_rightEyeOpenAmount();
                /*0x7aac254*/ void set_rightEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7aac264*/ void FinishSetup();
                /*0x7aac474*/ UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(void* statePtr);
                /*0x7aac640*/ void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, void* statePtr);
            }

            class XRSupport
            {
                static /*0x7aac79c*/ void Initialize();
            }

            namespace Haptics
            {
                struct BufferedRumble
                {
                    /*0x10*/ UnityEngine.InputSystem.XR.Haptics.HapticCapabilities <capabilities>k__BackingField;
                    /*0x28*/ UnityEngine.InputSystem.InputDevice <device>k__BackingField;

                    /*0x7aad32c*/ BufferedRumble(UnityEngine.InputSystem.InputDevice device);
                    /*0x7aad2f4*/ UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities();
                    /*0x7aad308*/ void set_capabilities(UnityEngine.InputSystem.XR.Haptics.HapticCapabilities value);
                    /*0x7aad31c*/ UnityEngine.InputSystem.InputDevice get_device();
                    /*0x7aad324*/ void set_device(UnityEngine.InputSystem.InputDevice value);
                    /*0x7aad4cc*/ void EnqueueRumble(byte[] samples);
                }

                struct HapticState
                {
                    /*0x10*/ uint <samplesQueued>k__BackingField;
                    /*0x14*/ uint <samplesAvailable>k__BackingField;

                    /*0x7aad6d8*/ HapticState(uint samplesQueued, uint samplesAvailable);
                    /*0x7aad6e0*/ uint get_samplesQueued();
                    /*0x7aad6e8*/ void set_samplesQueued(uint value);
                    /*0x7aad6f0*/ uint get_samplesAvailable();
                    /*0x7aad6f8*/ void set_samplesAvailable(uint value);
                }

                struct GetCurrentHapticStateCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
                {
                    static int kSize = 16;
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                    /*0x18*/ uint samplesQueued;
                    /*0x1c*/ uint samplesAvailable;

                    static /*0x7aad700*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7aad768*/ UnityEngine.InputSystem.XR.Haptics.GetCurrentHapticStateCommand Create();
                    /*0x7aad730*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                    /*0x7aad760*/ UnityEngine.InputSystem.XR.Haptics.HapticState get_currentState();
                }

                struct HapticCapabilities
                {
                    /*0x10*/ uint <numChannels>k__BackingField;
                    /*0x14*/ bool <supportsImpulse>k__BackingField;
                    /*0x15*/ bool <supportsBuffer>k__BackingField;
                    /*0x18*/ uint <frequencyHz>k__BackingField;
                    /*0x1c*/ uint <maxBufferSize>k__BackingField;
                    /*0x20*/ uint <optimalBufferSize>k__BackingField;

                    /*0x7aad7b8*/ HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize);
                    /*0x7aad7d8*/ HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize);
                    /*0x7aad7ec*/ uint get_numChannels();
                    /*0x7aad7f4*/ bool get_supportsImpulse();
                    /*0x7aad7fc*/ bool get_supportsBuffer();
                    /*0x7aad804*/ uint get_frequencyHz();
                    /*0x7aad80c*/ uint get_maxBufferSize();
                    /*0x7aad814*/ uint get_optimalBufferSize();
                }

                struct GetHapticCapabilitiesCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
                {
                    static int kSize = 28;
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                    /*0x18*/ uint numChannels;
                    /*0x1c*/ bool supportsImpulse;
                    /*0x1d*/ bool supportsBuffer;
                    /*0x20*/ uint frequencyHz;
                    /*0x24*/ uint maxBufferSize;
                    /*0x28*/ uint optimalBufferSize;

                    static /*0x7aad81c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7aad444*/ UnityEngine.InputSystem.XR.Haptics.GetHapticCapabilitiesCommand Create();
                    /*0x7aad84c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                    /*0x7aad4a4*/ UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities();
                }

                struct SendBufferedHapticCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
                {
                    static int kMaxHapticBufferSize = 1024;
                    static int kSize = 1040;
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                    /*0x18*/ int channel;
                    /*0x1c*/ int bufferSize;
                    /*0x20*/ UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand.<buffer> buffer;

                    static /*0x7aad87c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7aad574*/ UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand Create(byte[] rumbleBuffer);
                    /*0x7aad8ac*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                    struct <buffer>e__FixedBuffer
                    {
                        /*0x10*/ byte FixedElementField;
                    }
                }

                struct SendHapticImpulseCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
                {
                    static int kSize = 20;
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                    /*0x18*/ int channel;
                    /*0x1c*/ float amplitude;
                    /*0x20*/ float duration;

                    static /*0x7aad8dc*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7aa8edc*/ UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration);
                    /*0x7aad90c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                }
            }
        }

        namespace XInput
        {
            interface IXboxOneRumble : UnityEngine.InputSystem.Haptics.IDualMotorRumble, UnityEngine.InputSystem.Haptics.IHaptics
            {
                void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger);
            }

            class XInputController : UnityEngine.InputSystem.Gamepad
            {
                /*0x208*/ UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField;
                /*0x210*/ UnityEngine.InputSystem.Controls.ButtonControl <view>k__BackingField;
                /*0x218*/ bool m_HaveParsedCapabilities;
                /*0x21c*/ UnityEngine.InputSystem.XInput.XInputController.DeviceSubType m_SubType;
                /*0x220*/ UnityEngine.InputSystem.XInput.XInputController.DeviceFlags m_Flags;

                /*0x7aada58*/ XInputController();
                /*0x7aad93c*/ UnityEngine.InputSystem.Controls.ButtonControl get_menu();
                /*0x7aad944*/ void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7aad954*/ UnityEngine.InputSystem.Controls.ButtonControl get_view();
                /*0x7aad95c*/ void set_view(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7aad96c*/ UnityEngine.InputSystem.XInput.XInputController.DeviceSubType get_subType();
                /*0x7aada00*/ UnityEngine.InputSystem.XInput.XInputController.DeviceFlags get_flags();
                /*0x7aada24*/ void FinishSetup();
                /*0x7aad990*/ void ParseCapabilities();

                enum DeviceType
                {
                    Gamepad = 0,
                }

                enum DeviceSubType
                {
                    Unknown = 0,
                    Gamepad = 1,
                    Wheel = 2,
                    ArcadeStick = 3,
                    FlightStick = 4,
                    DancePad = 5,
                    Guitar = 6,
                    GuitarAlternate = 7,
                    DrumKit = 8,
                    GuitarBass = 11,
                    ArcadePad = 19,
                }

                enum DeviceFlags
                {
                    ForceFeedbackSupported = 1,
                    Wireless = 2,
                    VoiceSupported = 4,
                    PluginModulesSupported = 8,
                    NoNavigation = 16,
                }

                struct Capabilities
                {
                    /*0x10*/ UnityEngine.InputSystem.XInput.XInputController.DeviceType type;
                    /*0x14*/ UnityEngine.InputSystem.XInput.XInputController.DeviceSubType subType;
                    /*0x18*/ UnityEngine.InputSystem.XInput.XInputController.DeviceFlags flags;
                }
            }

            class XInputSupport
            {
                static /*0x7aada60*/ void Initialize();
            }
        }

        namespace Users
        {
            struct InputUser : System.IEquatable<UnityEngine.InputSystem.Users.InputUser>
            {
                static uint InvalidId = 0;
                static /*0x0*/ Unity.Profiling.ProfilerMarker k_InputUserOnChangeMarker;
                static /*0x8*/ Unity.Profiling.ProfilerMarker k_InputCheckForUnpairMarker;
                static /*0x10*/ UnityEngine.InputSystem.Users.InputUser.GlobalState s_GlobalState;
                /*0x10*/ uint m_Id;

                static /*0x7ab2fc0*/ InputUser();
                static /*0x7aae044*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all();
                static /*0x7aa3d18*/ void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> value);
                static /*0x7aa4998*/ void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> value);
                static /*0x7aa4100*/ void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7aa4434*/ void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7aa41f4*/ void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> value);
                static /*0x7aa4550*/ void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> value);
                static /*0x7aa42b8*/ int get_listenForUnpairedDeviceActivity();
                static /*0x7aa4310*/ void set_listenForUnpairedDeviceActivity(int value);
                static /*0x7aafa98*/ void RemoveLostDevicesForUser(int userIndex);
                static /*0x7aa2bdc*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices();
                static /*0x7ab0548*/ int GetUnpairedInputDevices(ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> list);
                static /*0x7ab076c*/ System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device);
                static /*0x7ab09dc*/ System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle);
                static /*0x7aa32c0*/ UnityEngine.InputSystem.Users.InputUser CreateUserWithoutPairedDevices();
                static /*0x7aa270c*/ UnityEngine.InputSystem.Users.InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserPairingOptions options);
                static /*0x7ab0d38*/ bool InitiateUserAccountSelection(int userIndex, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUserPairingOptions options);
                static /*0x7aa500c*/ bool op_Equality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right);
                static /*0x7ab0d2c*/ bool op_Inequality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right);
                static /*0x7ab0c30*/ int AddUser();
                static /*0x7ab01a0*/ void RemoveUser(int userIndex);
                static /*0x7aaee1c*/ void Notify(int userIndex, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device);
                static /*0x7aadbf4*/ int TryFindUserIndex(uint userId);
                static /*0x7ab0b38*/ int TryFindUserIndex(UnityEngine.InputSystem.Users.InputUserAccountHandle platformHandle);
                static /*0x7ab088c*/ int TryFindUserIndex(UnityEngine.InputSystem.InputDevice device);
                static /*0x7ab0ea8*/ void AddDeviceToUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice, bool dontUpdateControlScheme);
                static /*0x7aafc50*/ void RemoveDeviceFromUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice);
                static /*0x7aaf164*/ void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing);
                static /*0x7ab1404*/ long UpdatePlatformUserAccount(int userIndex, UnityEngine.InputSystem.InputDevice device);
                static /*0x7ab1ce0*/ long QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, ref System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> platformAccountHandle, ref string platformAccountName, ref string platformAccountId);
                static /*0x7ab1884*/ bool InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device);
                static /*0x7ab1e9c*/ void OnActionChange(object obj, UnityEngine.InputSystem.InputActionChange change);
                static /*0x7ab1f88*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
                static /*0x7ab25e8*/ int FindLostDevice(UnityEngine.InputSystem.InputDevice device, int startIndex);
                static /*0x7ab26c0*/ void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                static /*0x7ab2c74*/ UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState();
                static /*0x7aae5ac*/ void HookIntoActionChange();
                static /*0x7ab1bf4*/ void UnhookFromActionChange();
                static /*0x7ab1944*/ void HookIntoDeviceChange();
                static /*0x7ab1b44*/ void UnhookFromDeviceChange();
                static /*0x7aae0d4*/ void HookIntoEvents();
                static /*0x7aae22c*/ void UnhookFromDeviceStateChange();
                static /*0x7ab2e8c*/ void DisposeAndResetGlobalState();
                static /*0x7ab2f68*/ void ResetGlobals();
                /*0x7a9f4e0*/ bool get_valid();
                /*0x7aadad0*/ int get_index();
                /*0x7aadcac*/ uint get_id();
                /*0x7aadcb4*/ System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle();
                /*0x7aadd54*/ string get_platformUserAccountName();
                /*0x7aadddc*/ string get_platformUserAccountId();
                /*0x7aa032c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices();
                /*0x7aade64*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices();
                /*0x7aadf20*/ UnityEngine.InputSystem.IInputActionCollection get_actions();
                /*0x7a9f5b0*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme();
                /*0x7aadfa8*/ UnityEngine.InputSystem.InputControlScheme.MatchResult get_controlSchemeMatch();
                /*0x7aa0484*/ bool get_hasMissingRequiredDevices();
                /*0x7aae2fc*/ string ToString();
                /*0x7aa2d84*/ void AssociateActionsWithUser(UnityEngine.InputSystem.IInputActionCollection actions);
                /*0x7aa355c*/ UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(string schemeName);
                /*0x7aaeb64*/ bool TryFindControlScheme(string schemeName, ref UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7aa17b4*/ void FindControlScheme(string schemeName, ref UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7aa333c*/ UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7aae708*/ void ActivateControlSchemeInternal(int userIndex, UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7aa5954*/ void UnpairDevice(UnityEngine.InputSystem.InputDevice device);
                /*0x7aa241c*/ void UnpairDevices();
                /*0x7aa3258*/ void UnpairDevicesAndRemoveUser();
                /*0x7ab1a84*/ bool Equals(UnityEngine.InputSystem.Users.InputUser other);
                /*0x7ab1a94*/ bool Equals(object obj);
                /*0x7ab1b3c*/ int GetHashCode();

                struct ControlSchemeChangeSyntax
                {
                    /*0x10*/ int m_UserIndex;

                    /*0x7ab3074*/ UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax AndPairRemainingDevices();
                }

                enum UserFlags
                {
                    BindToAllDevices = 1,
                    UserAccountSelectionInProgress = 2,
                }

                struct UserData
                {
                    /*0x10*/ System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> platformUserAccountHandle;
                    /*0x28*/ string platformUserAccountName;
                    /*0x30*/ string platformUserAccountId;
                    /*0x38*/ int deviceCount;
                    /*0x3c*/ int deviceStartIndex;
                    /*0x40*/ UnityEngine.InputSystem.IInputActionCollection actions;
                    /*0x48*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> controlScheme;
                    /*0x68*/ UnityEngine.InputSystem.InputControlScheme.MatchResult controlSchemeMatch;
                    /*0xb8*/ int lostDeviceCount;
                    /*0xbc*/ int lostDeviceStartIndex;
                    /*0xc0*/ UnityEngine.InputSystem.Users.InputUser.UserFlags flags;
                }

                struct CompareDevicesByUserAccount : System.Collections.Generic.IComparer<UnityEngine.InputSystem.InputDevice>
                {
                    /*0x10*/ UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle;

                    static /*0x7ab3118*/ System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device);
                    /*0x7ab30dc*/ int Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y);
                }

                struct OngoingAccountSelection
                {
                    /*0x10*/ UnityEngine.InputSystem.InputDevice device;
                    /*0x18*/ uint userId;
                }

                struct GlobalState
                {
                    /*0x10*/ int pairingStateVersion;
                    /*0x14*/ uint lastUserId;
                    /*0x18*/ int allUserCount;
                    /*0x1c*/ int allPairedDeviceCount;
                    /*0x20*/ int allLostDeviceCount;
                    /*0x28*/ UnityEngine.InputSystem.Users.InputUser[] allUsers;
                    /*0x30*/ UnityEngine.InputSystem.Users.InputUser.UserData[] allUserData;
                    /*0x38*/ UnityEngine.InputSystem.InputDevice[] allPairedDevices;
                    /*0x40*/ UnityEngine.InputSystem.InputDevice[] allLostDevices;
                    /*0x48*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Users.InputUser.OngoingAccountSelection> ongoingAccountSelections;
                    /*0x68*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>> onChange;
                    /*0xb8*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>> onUnpairedDeviceUsed;
                    /*0x108*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool>> onPreFilterUnpairedDeviceUsed;
                    /*0x158*/ System.Action<object, UnityEngine.InputSystem.InputActionChange> actionChangeDelegate;
                    /*0x160*/ System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> onDeviceChangeDelegate;
                    /*0x168*/ System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate;
                    /*0x170*/ bool onActionChangeHooked;
                    /*0x171*/ bool onDeviceChangeHooked;
                    /*0x172*/ bool onEventHooked;
                    /*0x174*/ int listenForUnpairedDeviceActivity;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Users.InputUser.<> <>9;
                    static /*0x8*/ UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<UnityEngine.InputSystem.Users.InputUser.GlobalState> <>9__88_0;
                    static /*0x10*/ System.Action <>9__88_1;

                    static /*0x7ab3150*/ <>c();
                    /*0x7ab31b8*/ <>c();
                    /*0x7ab31c0*/ void <SaveAndResetState>b__88_0(ref UnityEngine.InputSystem.Users.InputUser.GlobalState state);
                    /*0x7ab3258*/ void <SaveAndResetState>b__88_1();
                }
            }

            struct InputUserAccountHandle : System.IEquatable<UnityEngine.InputSystem.Users.InputUserAccountHandle>
            {
                /*0x10*/ string m_ApiName;
                /*0x18*/ ulong m_Handle;

                static /*0x7ab3124*/ bool op_Equality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right);
                static /*0x7ab34f4*/ bool op_Inequality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right);
                /*0x7ab32b8*/ InputUserAccountHandle(string apiName, ulong handle);
                /*0x7ab32a8*/ string get_apiName();
                /*0x7ab32b0*/ ulong get_handle();
                /*0x7ab3344*/ string ToString();
                /*0x7ab33fc*/ bool Equals(UnityEngine.InputSystem.Users.InputUserAccountHandle other);
                /*0x7ab347c*/ bool Equals(object obj);
                /*0x7ab3524*/ int GetHashCode();
            }

            enum InputUserChange
            {
                Added = 0,
                Removed = 1,
                DevicePaired = 2,
                DeviceUnpaired = 3,
                DeviceLost = 4,
                DeviceRegained = 5,
                AccountChanged = 6,
                AccountNameChanged = 7,
                AccountSelectionInProgress = 8,
                AccountSelectionCanceled = 9,
                AccountSelectionComplete = 10,
                ControlSchemeChanged = 11,
                ControlsChanged = 12,
            }

            enum InputUserPairingOptions
            {
                None = 0,
                ForcePlatformUserAccountSelection = 1,
                ForceNoPlatformUserAccountSelection = 2,
                UnpairCurrentDevicesFromUser = 8,
            }

            class InputUserSettings
            {
                /*0x10*/ string <customBindings>k__BackingField;
                /*0x18*/ bool <invertMouseX>k__BackingField;
                /*0x19*/ bool <invertMouseY>k__BackingField;
                /*0x1c*/ System.Nullable<float> <mouseSmoothing>k__BackingField;
                /*0x24*/ System.Nullable<float> <mouseSensitivity>k__BackingField;
                /*0x2c*/ bool <invertStickX>k__BackingField;
                /*0x2d*/ bool <invertStickY>k__BackingField;
                /*0x2e*/ bool <swapSticks>k__BackingField;
                /*0x2f*/ bool <swapBumpers>k__BackingField;
                /*0x30*/ bool <swapTriggers>k__BackingField;
                /*0x31*/ bool <swapDpadAndLeftStick>k__BackingField;
                /*0x34*/ float <vibrationStrength>k__BackingField;
                /*0x38*/ string m_CustomBindings;

                /*0x7ab3660*/ InputUserSettings();
                /*0x7ab357c*/ string get_customBindings();
                /*0x7ab3584*/ void set_customBindings(string value);
                /*0x7ab358c*/ bool get_invertMouseX();
                /*0x7ab3594*/ void set_invertMouseX(bool value);
                /*0x7ab35a0*/ bool get_invertMouseY();
                /*0x7ab35a8*/ void set_invertMouseY(bool value);
                /*0x7ab35b4*/ System.Nullable<float> get_mouseSmoothing();
                /*0x7ab35bc*/ void set_mouseSmoothing(System.Nullable<float> value);
                /*0x7ab35c4*/ System.Nullable<float> get_mouseSensitivity();
                /*0x7ab35cc*/ void set_mouseSensitivity(System.Nullable<float> value);
                /*0x7ab35d4*/ bool get_invertStickX();
                /*0x7ab35dc*/ void set_invertStickX(bool value);
                /*0x7ab35e8*/ bool get_invertStickY();
                /*0x7ab35f0*/ void set_invertStickY(bool value);
                /*0x7ab35fc*/ bool get_swapSticks();
                /*0x7ab3604*/ void set_swapSticks(bool value);
                /*0x7ab3610*/ bool get_swapBumpers();
                /*0x7ab3618*/ void set_swapBumpers(bool value);
                /*0x7ab3624*/ bool get_swapTriggers();
                /*0x7ab362c*/ void set_swapTriggers(bool value);
                /*0x7ab3638*/ bool get_swapDpadAndLeftStick();
                /*0x7ab3640*/ void set_swapDpadAndLeftStick(bool value);
                /*0x7ab364c*/ float get_vibrationStrength();
                /*0x7ab3654*/ void set_vibrationStrength(float value);
                /*0x7ab365c*/ void Apply(UnityEngine.InputSystem.IInputActionCollection actions);
            }
        }

        namespace UI
        {
            class BaseInputOverride : UnityEngine.EventSystems.BaseInput
            {
                /*0x20*/ string <compositionString>k__BackingField;

                /*0x7ab3670*/ BaseInputOverride();
                /*0x7ab3668*/ string get_compositionString();
            }

            class ExtendedAxisEventData : UnityEngine.EventSystems.AxisEventData
            {
                /*0x7ab3678*/ ExtendedAxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
                /*0x7ab3680*/ string ToString();
            }

            class ExtendedPointerEventData : UnityEngine.EventSystems.PointerEventData
            {
                /*0x180*/ UnityEngine.InputSystem.InputControl <control>k__BackingField;
                /*0x188*/ UnityEngine.InputSystem.InputDevice <device>k__BackingField;
                /*0x190*/ int <touchId>k__BackingField;
                /*0x194*/ UnityEngine.InputSystem.UI.UIPointerType <pointerType>k__BackingField;
                /*0x198*/ int <uiToolkitPointerId>k__BackingField;
                /*0x19c*/ UnityEngine.Vector3 <trackedDevicePosition>k__BackingField;
                /*0x1a8*/ UnityEngine.Quaternion <trackedDeviceOrientation>k__BackingField;

                static /*0x7ab3d90*/ int MakePointerIdForTouch(int deviceId, int touchId);
                static /*0x7ab3d98*/ int TouchIdFromPointerId(int pointerId);
                static /*0x7ab4058*/ int GetPenPointerId(UnityEngine.InputSystem.Pen pen);
                static /*0x7ab42ac*/ int GetTouchPointerId(UnityEngine.InputSystem.Controls.TouchControl touchControl);
                /*0x7ab373c*/ ExtendedPointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
                /*0x7ab3744*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x7ab374c*/ void set_control(UnityEngine.InputSystem.InputControl value);
                /*0x7ab375c*/ UnityEngine.InputSystem.InputDevice get_device();
                /*0x7ab3764*/ void set_device(UnityEngine.InputSystem.InputDevice value);
                /*0x7ab3774*/ int get_touchId();
                /*0x7ab377c*/ void set_touchId(int value);
                /*0x7ab3784*/ UnityEngine.InputSystem.UI.UIPointerType get_pointerType();
                /*0x7ab378c*/ void set_pointerType(UnityEngine.InputSystem.UI.UIPointerType value);
                /*0x7ab3794*/ int get_uiToolkitPointerId();
                /*0x7ab379c*/ void set_uiToolkitPointerId(int value);
                /*0x7ab37a4*/ UnityEngine.Vector3 get_trackedDevicePosition();
                /*0x7ab37b4*/ void set_trackedDevicePosition(UnityEngine.Vector3 value);
                /*0x7ab37c4*/ UnityEngine.Quaternion get_trackedDeviceOrientation();
                /*0x7ab37d8*/ void set_trackedDeviceOrientation(UnityEngine.Quaternion value);
                /*0x7ab37ec*/ string ToString();
                /*0x7ab3da0*/ void ReadDeviceState();
            }

            enum UIPointerType
            {
                None = 0,
                MouseOrPen = 1,
                Touch = 2,
                Tracked = 3,
            }

            enum UIPointerBehavior
            {
                SingleMouseOrPenButMultiTouchAndTrack = 0,
                SingleUnifiedPointer = 1,
                AllPointersAsIs = 2,
            }

            class InputSystemUIInputModule : UnityEngine.EventSystems.BaseInputModule
            {
                static float kClickSpeed = 0.30000001192092896;
                static float kSmallestScrollDeltaPerTick = 0.000009999999747378752;
                static /*0x0*/ UnityEngine.InputSystem.DefaultInputActions defaultActions;
                static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputAction, UnityEngine.InputSystem.UI.InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts;
                /*0x58*/ float m_MoveRepeatDelay;
                /*0x5c*/ float m_MoveRepeatRate;
                /*0x60*/ float m_TrackedDeviceDragThresholdMultiplier;
                /*0x68*/ UnityEngine.Transform m_XRTrackingOrigin;
                /*0x70*/ UnityEngine.InputSystem.InputActionAsset m_ActionsAsset;
                /*0x78*/ UnityEngine.InputSystem.InputActionReference m_PointAction;
                /*0x80*/ UnityEngine.InputSystem.InputActionReference m_MoveAction;
                /*0x88*/ UnityEngine.InputSystem.InputActionReference m_SubmitAction;
                /*0x90*/ UnityEngine.InputSystem.InputActionReference m_CancelAction;
                /*0x98*/ UnityEngine.InputSystem.InputActionReference m_LeftClickAction;
                /*0xa0*/ UnityEngine.InputSystem.InputActionReference m_MiddleClickAction;
                /*0xa8*/ UnityEngine.InputSystem.InputActionReference m_RightClickAction;
                /*0xb0*/ UnityEngine.InputSystem.InputActionReference m_ScrollWheelAction;
                /*0xb8*/ UnityEngine.InputSystem.InputActionReference m_TrackedDevicePositionAction;
                /*0xc0*/ UnityEngine.InputSystem.InputActionReference m_TrackedDeviceOrientationAction;
                /*0xc8*/ bool m_DeselectOnBackgroundClick;
                /*0xcc*/ UnityEngine.InputSystem.UI.UIPointerBehavior m_PointerBehavior;
                /*0xd0*/ UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior m_CursorLockBehavior;
                /*0xd4*/ float m_ScrollDeltaPerTick;
                /*0xd8*/ bool m_ActionsHooked;
                /*0xd9*/ bool m_NeedToPurgeStalePointers;
                /*0xe0*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnPointDelegate;
                /*0xe8*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMoveDelegate;
                /*0xf0*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnLeftClickDelegate;
                /*0xf8*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnRightClickDelegate;
                /*0x100*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMiddleClickDelegate;
                /*0x108*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnScrollWheelDelegate;
                /*0x110*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate;
                /*0x118*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate;
                /*0x120*/ System.Action<object> m_OnControlsChangedDelegate;
                /*0x128*/ int m_CurrentPointerId;
                /*0x12c*/ int m_CurrentPointerIndex;
                /*0x130*/ UnityEngine.InputSystem.UI.UIPointerType m_CurrentPointerType;
                /*0x138*/ UnityEngine.InputSystem.Utilities.InlinedArray<int> m_PointerIds;
                /*0x148*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.PointerModel> m_PointerStates;
                /*0x378*/ UnityEngine.InputSystem.UI.NavigationModel m_NavigationState;
                /*0x398*/ UnityEngine.GameObject m_LocalMultiPlayerRoot;

                static /*0x7abb204*/ InputSystemUIInputModule();
                static /*0x7ab6190*/ void ProcessPointerScroll(ref UnityEngine.InputSystem.UI.PointerModel pointer, UnityEngine.EventSystems.PointerEventData eventData);
                static /*0x7ab98f0*/ bool HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputActionReference actionReference);
                static /*0x7abb050*/ void SetActionCallback(UnityEngine.InputSystem.InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install);
                /*0x7abb1d0*/ InputSystemUIInputModule();
                /*0x7ab43a4*/ bool get_deselectOnBackgroundClick();
                /*0x7ab43ac*/ void set_deselectOnBackgroundClick(bool value);
                /*0x7ab43b8*/ UnityEngine.InputSystem.UI.UIPointerBehavior get_pointerBehavior();
                /*0x7ab43c0*/ void set_pointerBehavior(UnityEngine.InputSystem.UI.UIPointerBehavior value);
                /*0x7ab43c8*/ UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior get_cursorLockBehavior();
                /*0x7ab43d0*/ void set_cursorLockBehavior(UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior value);
                /*0x7ab43d8*/ UnityEngine.GameObject get_localMultiPlayerRoot();
                /*0x7ab43e0*/ void set_localMultiPlayerRoot(UnityEngine.GameObject value);
                /*0x7ab43f0*/ float get_scrollDeltaPerTick();
                /*0x7ab43f8*/ void set_scrollDeltaPerTick(float value);
                /*0x7ab4400*/ void ActivateModule();
                /*0x7ab44b4*/ bool IsPointerOverGameObject(int pointerOrTouchId);
                /*0x7ab474c*/ UnityEngine.EventSystems.RaycastResult GetLastRaycastResult(int pointerOrTouchId);
                /*0x7ab47fc*/ UnityEngine.EventSystems.RaycastResult PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7ab50bc*/ void ProcessPointer(ref UnityEngine.InputSystem.UI.PointerModel state);
                /*0x7ab6324*/ bool PointerShouldIgnoreTransform(UnityEngine.Transform t);
                /*0x7ab5568*/ void ProcessPointerMovement(ref UnityEngine.InputSystem.UI.PointerModel pointer, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7ab6424*/ void ProcessPointerMovement(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, UnityEngine.GameObject currentPointerTarget);
                /*0x7ab55d0*/ void ProcessPointerButton(ref UnityEngine.InputSystem.UI.PointerModel.ButtonState button, UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7ab5e78*/ void ProcessPointerButtonDrag(ref UnityEngine.InputSystem.UI.PointerModel.ButtonState button, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7ab6de8*/ void ProcessNavigation(ref UnityEngine.InputSystem.UI.NavigationModel navigationState);
                /*0x7ab7430*/ bool IsMoveAllowed(UnityEngine.EventSystems.AxisEventData eventData);
                /*0x7ab7628*/ float get_moveRepeatDelay();
                /*0x7ab7630*/ void set_moveRepeatDelay(float value);
                /*0x7ab7638*/ float get_moveRepeatRate();
                /*0x7ab7640*/ void set_moveRepeatRate(float value);
                /*0x7ab7648*/ bool get_explictlyIgnoreFocus();
                /*0x7ab76b0*/ bool get_shouldIgnoreFocus();
                /*0x7ab7778*/ float get_repeatRate();
                /*0x7ab7780*/ void set_repeatRate(float value);
                /*0x7ab7788*/ float get_repeatDelay();
                /*0x7ab7790*/ void set_repeatDelay(float value);
                /*0x7ab7798*/ UnityEngine.Transform get_xrTrackingOrigin();
                /*0x7ab77a0*/ void set_xrTrackingOrigin(UnityEngine.Transform value);
                /*0x7ab77a8*/ float get_trackedDeviceDragThresholdMultiplier();
                /*0x7ab77b0*/ void set_trackedDeviceDragThresholdMultiplier(float value);
                /*0x7ab77b8*/ void SwapAction(ref UnityEngine.InputSystem.InputActionReference property, UnityEngine.InputSystem.InputActionReference newValue, bool actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback);
                /*0x7ab7d5c*/ UnityEngine.InputSystem.InputActionReference get_point();
                /*0x7ab7d64*/ void set_point(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7d7c*/ UnityEngine.InputSystem.InputActionReference get_scrollWheel();
                /*0x7ab7d84*/ void set_scrollWheel(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7d9c*/ UnityEngine.InputSystem.InputActionReference get_leftClick();
                /*0x7ab7da4*/ void set_leftClick(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7dbc*/ UnityEngine.InputSystem.InputActionReference get_middleClick();
                /*0x7ab7dc4*/ void set_middleClick(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7ddc*/ UnityEngine.InputSystem.InputActionReference get_rightClick();
                /*0x7ab7de4*/ void set_rightClick(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7dfc*/ UnityEngine.InputSystem.InputActionReference get_move();
                /*0x7ab7e04*/ void set_move(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7e1c*/ UnityEngine.InputSystem.InputActionReference get_submit();
                /*0x7ab7e24*/ void set_submit(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7e3c*/ UnityEngine.InputSystem.InputActionReference get_cancel();
                /*0x7ab7e44*/ void set_cancel(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7e5c*/ UnityEngine.InputSystem.InputActionReference get_trackedDeviceOrientation();
                /*0x7ab7e64*/ void set_trackedDeviceOrientation(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7e7c*/ UnityEngine.InputSystem.InputActionReference get_trackedDevicePosition();
                /*0x7ab7e84*/ void set_trackedDevicePosition(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab7e9c*/ void AssignDefaultActions();
                /*0x7ab849c*/ void UnassignActions();
                /*0x7ab862c*/ UnityEngine.InputSystem.InputActionReference get_trackedDeviceSelect();
                /*0x7ab8664*/ void set_trackedDeviceSelect(UnityEngine.InputSystem.InputActionReference value);
                /*0x7ab869c*/ void Awake();
                /*0x7ab8744*/ void OnDestroy();
                /*0x7ab8788*/ void OnEnable();
                /*0x7ab8d78*/ void OnDisable();
                /*0x7ab89d0*/ void ResetPointers();
                /*0x7ab88a0*/ bool HasNoActions();
                /*0x7ab8d1c*/ void EnableAllActions();
                /*0x7ab8e20*/ void DisableAllActions();
                /*0x7ab7bf4*/ void EnableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference);
                /*0x7ab7a7c*/ void TryDisableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference, bool isComponentDisabling);
                /*0x7ab461c*/ int GetPointerStateIndexFor(int pointerOrTouchId);
                /*0x7ab8f98*/ ref UnityEngine.InputSystem.UI.PointerModel GetPointerStateForIndex(int index);
                /*0x7ab8fdc*/ int GetDisplayIndexFor(UnityEngine.InputSystem.InputControl control);
                /*0x7ab9088*/ int GetPointerStateIndexFor(ref UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7ab914c*/ int GetPointerStateIndexFor(UnityEngine.InputSystem.InputControl control, bool createIfNotExists);
                /*0x7ab99c0*/ int AllocatePointer(int pointerId, int displayIndex, int touchId, UnityEngine.InputSystem.UI.UIPointerType pointerType, UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControl touchControl);
                /*0x7ab8ec8*/ bool SendPointerExitEventsAndRemovePointer(int index);
                /*0x7ab9c98*/ bool RemovePointerAtIndex(int index);
                /*0x7ab9ef0*/ void PurgeStalePointers();
                /*0x7aba00c*/ void OnPointCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba118*/ bool IgnoreNextClick(ref UnityEngine.InputSystem.InputAction.CallbackContext context, bool wasPressed);
                /*0x7aba23c*/ void OnLeftClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba378*/ void OnRightClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba460*/ void OnMiddleClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7ab90e8*/ bool CheckForRemovedDevice(ref UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba548*/ void OnScrollCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba6b4*/ void OnMoveCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba714*/ void OnTrackedDeviceOrientationCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba814*/ void OnTrackedDevicePositionCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aba910*/ void OnControlsChanged(object obj);
                /*0x7aba91c*/ void FilterPointerStatesByType();
                /*0x7abac50*/ void Process();
                /*0x7abae34*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
                /*0x7abaf04*/ UnityEngine.Vector2 ConvertPointerEventScrollDeltaToTicks(UnityEngine.Vector2 scrollDelta);
                /*0x7ab8a28*/ void HookActions();
                /*0x7ab8774*/ void UnhookActions();
                /*0x7abaf68*/ void SetActionCallbacks(bool install);
                /*0x7abb134*/ UnityEngine.InputSystem.InputActionReference UpdateReferenceForNewAsset(UnityEngine.InputSystem.InputActionReference actionReference);
                /*0x7abb1bc*/ UnityEngine.InputSystem.InputActionAsset get_actionsAsset();
                /*0x7ab825c*/ void set_actionsAsset(UnityEngine.InputSystem.InputActionAsset value);
                /*0x7ab6d28*/ bool get_sendPointerHoverToParent();
                /*0x7abb1c4*/ void set_sendPointerHoverToParent(bool value);

                struct InputActionReferenceState
                {
                    /*0x10*/ int refCount;
                    /*0x14*/ bool enabledByInputModule;
                }

                enum CursorLockBehavior
                {
                    OutsideScreen = 0,
                    ScreenCenter = 1,
                }
            }

            class MultiplayerEventSystem : UnityEngine.EventSystems.EventSystem
            {
                /*0x60*/ UnityEngine.GameObject m_PlayerRoot;

                /*0x7abb4b8*/ MultiplayerEventSystem();
                /*0x7abb294*/ UnityEngine.GameObject get_playerRoot();
                /*0x7abb29c*/ void set_playerRoot(UnityEngine.GameObject value);
                /*0x7abb38c*/ void OnEnable();
                /*0x7abb3a8*/ void OnDisable();
                /*0x7abb2b8*/ void InitializePlayerRoot();
                /*0x7abb3b0*/ void Update();
            }

            struct NavigationModel
            {
                /*0x10*/ UnityEngine.Vector2 move;
                /*0x18*/ int consecutiveMoveCount;
                /*0x1c*/ UnityEngine.EventSystems.MoveDirection lastMoveDirection;
                /*0x20*/ float lastMoveTime;
                /*0x28*/ UnityEngine.EventSystems.AxisEventData eventData;

                /*0x7ab86f4*/ void Reset();
            }

            struct PointerModel
            {
                /*0x10*/ bool changedThisFrame;
                /*0x18*/ UnityEngine.InputSystem.UI.PointerModel.ButtonState leftButton;
                /*0xb0*/ UnityEngine.InputSystem.UI.PointerModel.ButtonState rightButton;
                /*0x148*/ UnityEngine.InputSystem.UI.PointerModel.ButtonState middleButton;
                /*0x1e0*/ UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData;
                /*0x1e8*/ UnityEngine.Vector2 m_ScreenPosition;
                /*0x1f0*/ UnityEngine.Vector2 m_ScrollDelta;
                /*0x1f8*/ UnityEngine.Vector3 m_WorldPosition;
                /*0x204*/ UnityEngine.Quaternion m_WorldOrientation;
                /*0x214*/ float m_Pressure;
                /*0x218*/ float m_AzimuthAngle;
                /*0x21c*/ float m_AltitudeAngle;
                /*0x220*/ float m_Twist;
                /*0x224*/ UnityEngine.Vector2 m_Radius;

                /*0x7ab9c1c*/ PointerModel(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7ab55b4*/ UnityEngine.InputSystem.UI.UIPointerType get_pointerType();
                /*0x7abb510*/ UnityEngine.Vector2 get_screenPosition();
                /*0x7ab9bdc*/ void set_screenPosition(UnityEngine.Vector2 value);
                /*0x7abb51c*/ UnityEngine.Vector3 get_worldPosition();
                /*0x7aba8bc*/ void set_worldPosition(UnityEngine.Vector3 value);
                /*0x7abb52c*/ UnityEngine.Quaternion get_worldOrientation();
                /*0x7aba7bc*/ void set_worldOrientation(UnityEngine.Quaternion value);
                /*0x7abb540*/ UnityEngine.Vector2 get_scrollDelta();
                /*0x7aba674*/ void set_scrollDelta(UnityEngine.Vector2 value);
                /*0x7abb54c*/ float get_pressure();
                /*0x7abb554*/ void set_pressure(float value);
                /*0x7abb574*/ float get_azimuthAngle();
                /*0x7abb57c*/ void set_azimuthAngle(float value);
                /*0x7abb59c*/ float get_altitudeAngle();
                /*0x7abb5a4*/ void set_altitudeAngle(float value);
                /*0x7abb5c4*/ float get_twist();
                /*0x7abb5cc*/ void set_twist(float value);
                /*0x7abb5ec*/ UnityEngine.Vector2 get_radius();
                /*0x7abb5f8*/ void set_radius(UnityEngine.Vector2 value);
                /*0x7abadec*/ void OnFrameFinished();
                /*0x7abab88*/ void CopyTouchOrPenStateFrom(UnityEngine.EventSystems.PointerEventData eventData);

                struct ButtonState
                {
                    /*0x10*/ bool m_IsPressed;
                    /*0x14*/ UnityEngine.EventSystems.PointerEventData.FramePressState m_FramePressState;
                    /*0x18*/ float m_PressTime;
                    /*0x20*/ UnityEngine.EventSystems.RaycastResult m_PressRaycast;
                    /*0x70*/ UnityEngine.GameObject m_PressObject;
                    /*0x78*/ UnityEngine.GameObject m_RawPressObject;
                    /*0x80*/ UnityEngine.GameObject m_LastPressObject;
                    /*0x88*/ UnityEngine.GameObject m_DragObject;
                    /*0x90*/ UnityEngine.Vector2 m_PressPosition;
                    /*0x98*/ float m_ClickTime;
                    /*0x9c*/ int m_ClickCount;
                    /*0xa0*/ bool m_Dragging;
                    /*0xa1*/ bool m_ClickedOnSameGameObject;
                    /*0xa2*/ bool m_IgnoreNextClick;

                    /*0x7abb644*/ bool get_isPressed();
                    /*0x7aba324*/ void set_isPressed(bool value);
                    /*0x7abb64c*/ bool get_ignoreNextClick();
                    /*0x7abb654*/ void set_ignoreNextClick(bool value);
                    /*0x7abb660*/ float get_pressTime();
                    /*0x7abb668*/ void set_pressTime(float value);
                    /*0x7abb670*/ bool get_clickedOnSameGameObject();
                    /*0x7abb678*/ void set_clickedOnSameGameObject(bool value);
                    /*0x7ab6d30*/ bool get_wasPressedThisFrame();
                    /*0x7ab6410*/ bool get_wasReleasedThisFrame();
                    /*0x7ab5498*/ void CopyPressStateTo(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7ab6d40*/ void CopyPressStateFrom(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7abb638*/ void OnEndFrame();
                }
            }

            class TrackedDeviceRaycaster : UnityEngine.EventSystems.BaseRaycaster
            {
                static /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> s_Instances;
                static /*0x18*/ System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> s_SortedGraphics;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> m_RaycastResultsCache;
                /*0x30*/ bool m_IgnoreReversedGraphics;
                /*0x31*/ bool m_CheckFor2DOcclusion;
                /*0x32*/ bool m_CheckFor3DOcclusion;
                /*0x34*/ float m_MaxDistance;
                /*0x38*/ UnityEngine.LayerMask m_BlockingMask;
                /*0x40*/ UnityEngine.Canvas m_Canvas;

                static /*0x7abc314*/ TrackedDeviceRaycaster();
                static /*0x7abbf38*/ bool RayIntersectsRectTransform(UnityEngine.RectTransform transform, UnityEngine.Ray ray, ref UnityEngine.Vector3 worldPosition, ref float distance);
                /*0x7abc284*/ TrackedDeviceRaycaster();
                /*0x7abb684*/ UnityEngine.Camera get_eventCamera();
                /*0x7abb7c0*/ UnityEngine.LayerMask get_blockingMask();
                /*0x7abb7c8*/ void set_blockingMask(UnityEngine.LayerMask value);
                /*0x7abb7d0*/ bool get_checkFor3DOcclusion();
                /*0x7abb7d8*/ void set_checkFor3DOcclusion(bool value);
                /*0x7abb7e4*/ bool get_checkFor2DOcclusion();
                /*0x7abb7ec*/ void set_checkFor2DOcclusion(bool value);
                /*0x7abb7f8*/ bool get_ignoreReversedGraphics();
                /*0x7abb800*/ void set_ignoreReversedGraphics(bool value);
                /*0x7abb80c*/ float get_maxDistance();
                /*0x7abb814*/ void set_maxDistance(float value);
                /*0x7abb81c*/ void OnEnable();
                /*0x7abb8a0*/ void OnDisable();
                /*0x7abb994*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
                /*0x7ab4a50*/ void PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
                /*0x7abba3c*/ void SortedRaycastGraphics(UnityEngine.Canvas canvas, UnityEngine.Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results);
                /*0x7abb718*/ UnityEngine.Canvas get_canvas();

                struct RaycastHitData
                {
                    /*0x10*/ UnityEngine.UI.Graphic <graphic>k__BackingField;
                    /*0x18*/ UnityEngine.Vector3 <worldHitPosition>k__BackingField;
                    /*0x24*/ UnityEngine.Vector2 <screenPosition>k__BackingField;
                    /*0x2c*/ float <distance>k__BackingField;

                    /*0x7abc230*/ RaycastHitData(UnityEngine.UI.Graphic graphic, UnityEngine.Vector3 worldHitPosition, UnityEngine.Vector2 screenPosition, float distance);
                    /*0x7abc3a4*/ UnityEngine.UI.Graphic get_graphic();
                    /*0x7abc3ac*/ UnityEngine.Vector3 get_worldHitPosition();
                    /*0x7abc3b8*/ UnityEngine.Vector2 get_screenPosition();
                    /*0x7abc3c0*/ float get_distance();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> <>9__25_0;

                    static /*0x7abc3c8*/ <>c();
                    /*0x7abc430*/ <>c();
                    /*0x7abc438*/ int <SortedRaycastGraphics>b__25_0(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData g1, UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData g2);
                }
            }

            class VirtualMouseInput : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode m_CursorMode;
                /*0x28*/ UnityEngine.UI.Graphic m_CursorGraphic;
                /*0x30*/ UnityEngine.RectTransform m_CursorTransform;
                /*0x38*/ float m_CursorSpeed;
                /*0x3c*/ float m_ScrollSpeed;
                /*0x40*/ UnityEngine.InputSystem.InputActionProperty m_StickAction;
                /*0x58*/ UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;
                /*0x70*/ UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;
                /*0x88*/ UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;
                /*0xa0*/ UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;
                /*0xb8*/ UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;
                /*0xd0*/ UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;
                /*0xe8*/ UnityEngine.Canvas m_Canvas;
                /*0xf0*/ UnityEngine.InputSystem.Mouse m_VirtualMouse;
                /*0xf8*/ UnityEngine.InputSystem.Mouse m_SystemMouse;
                /*0x100*/ System.Action m_AfterInputUpdateDelegate;
                /*0x108*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;
                /*0x110*/ double m_LastTime;
                /*0x118*/ UnityEngine.Vector2 m_LastStickValue;

                static /*0x7abcab0*/ void SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install);
                static /*0x7abc8d8*/ void SetAction(ref UnityEngine.InputSystem.InputActionProperty field, UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abda18*/ VirtualMouseInput();
                /*0x7abc48c*/ UnityEngine.RectTransform get_cursorTransform();
                /*0x7abc494*/ void set_cursorTransform(UnityEngine.RectTransform value);
                /*0x7abc49c*/ float get_cursorSpeed();
                /*0x7abc4a4*/ void set_cursorSpeed(float value);
                /*0x7abc4ac*/ UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode get_cursorMode();
                /*0x7abc4b4*/ void set_cursorMode(UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode value);
                /*0x7abc7f4*/ UnityEngine.UI.Graphic get_cursorGraphic();
                /*0x7abc7fc*/ void set_cursorGraphic(UnityEngine.UI.Graphic value);
                /*0x7abc87c*/ float get_scrollSpeed();
                /*0x7abc884*/ void set_scrollSpeed(float value);
                /*0x7abc88c*/ UnityEngine.InputSystem.Mouse get_virtualMouse();
                /*0x7abc894*/ UnityEngine.InputSystem.InputActionProperty get_stickAction();
                /*0x7abc8a8*/ void set_stickAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abca0c*/ UnityEngine.InputSystem.InputActionProperty get_leftButtonAction();
                /*0x7abca20*/ void set_leftButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abcb20*/ UnityEngine.InputSystem.InputActionProperty get_rightButtonAction();
                /*0x7abcb34*/ void set_rightButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abcbc4*/ UnityEngine.InputSystem.InputActionProperty get_middleButtonAction();
                /*0x7abcbd8*/ void set_middleButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abcc68*/ UnityEngine.InputSystem.InputActionProperty get_forwardButtonAction();
                /*0x7abcc7c*/ void set_forwardButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abcd0c*/ UnityEngine.InputSystem.InputActionProperty get_backButtonAction();
                /*0x7abcd20*/ void set_backButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abcdb0*/ UnityEngine.InputSystem.InputActionProperty get_scrollWheelAction();
                /*0x7abcdc4*/ void set_scrollWheelAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7abcdf4*/ void OnEnable();
                /*0x7abd234*/ void OnDisable();
                /*0x7abc818*/ void TryFindCanvas();
                /*0x7abc5cc*/ void TryEnableHardwareCursor();
                /*0x7abd480*/ void UpdateMotion();
                /*0x7abd81c*/ void OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7abda14*/ void OnAfterInputUpdate();

                enum CursorMode
                {
                    SoftwareCursor = 0,
                    HardwareCursorIfAvailable = 1,
                }
            }
        }

        namespace OnScreen
        {
            class OnScreenButton : UnityEngine.InputSystem.OnScreen.OnScreenControl, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler
            {
                /*0x38*/ string m_ControlPath;

                /*0x7abdad4*/ OnScreenButton();
                /*0x7abda2c*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7abda78*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7abdac4*/ string get_controlPathInternal();
                /*0x7abdacc*/ void set_controlPathInternal(string value);
            }

            class OnScreenControl : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ int s_nbActiveInstances;
                static /*0x8*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices;
                /*0x20*/ UnityEngine.InputSystem.InputControl m_Control;
                /*0x28*/ UnityEngine.InputSystem.OnScreen.OnScreenControl m_NextControlOnDevice;
                /*0x30*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_InputEventPtr;

                static /*0x7abe5f0*/ bool get_HasAnyActive();
                /*0x7abdadc*/ OnScreenControl();
                /*0x7abdae4*/ string get_controlPath();
                /*0x7abdaf0*/ void set_controlPath(string value);
                /*0x7abe3a0*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x38148bc*/ string get_controlPathInternal();
                /*0x3816710*/ void set_controlPathInternal(string value);
                /*0x7abdb28*/ void SetupInputControl();
                /*0x3910ae8*/ void SendValueToControl<TValue>(TValue value);
                /*0x7abe4bc*/ void SentDefaultValueToControl();
                /*0x7abe640*/ void OnEnable();
                /*0x7abe930*/ void OnDisable();
                /*0x7abec94*/ string GetWarningMessage();

                struct OnScreenDeviceInfo
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr;
                    /*0x18*/ Unity.Collections.NativeArray<byte> buffer;
                    /*0x28*/ UnityEngine.InputSystem.InputDevice device;
                    /*0x30*/ UnityEngine.InputSystem.OnScreen.OnScreenControl firstControl;

                    /*0x7abe458*/ UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo AddControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control);
                    /*0x7abeb64*/ UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo RemoveControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control);
                    /*0x7abe3a8*/ void Destroy();
                }
            }

            class UGUIOnScreenControlUtils
            {
                static /*0x7abecf0*/ UnityEngine.RectTransform GetCanvasRectTransform(UnityEngine.Transform transform);
            }

            class OnScreenStick : UnityEngine.InputSystem.OnScreen.OnScreenControl, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IDragHandler
            {
                static string kDynamicOriginClickable = "DynamicOriginClickable";
                /*0x38*/ float m_MovementRange;
                /*0x3c*/ float m_DynamicOriginRange;
                /*0x40*/ string m_ControlPath;
                /*0x48*/ UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour m_Behaviour;
                /*0x4c*/ bool m_UseIsolatedInputActions;
                /*0x50*/ UnityEngine.InputSystem.InputAction m_PointerDownAction;
                /*0x58*/ UnityEngine.InputSystem.InputAction m_PointerMoveAction;
                /*0x60*/ UnityEngine.Vector3 m_StartPos;
                /*0x6c*/ UnityEngine.Vector2 m_PointerDownPos;
                /*0x78*/ System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResults;
                /*0x80*/ UnityEngine.EventSystems.PointerEventData m_PointerEventData;
                /*0x88*/ UnityEngine.InputSystem.Controls.TouchControl m_TouchControl;
                /*0x90*/ bool m_IsIsolationActive;

                /*0x7ac08bc*/ OnScreenStick();
                /*0x7abeda8*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7abf05c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7abf4b0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7abf588*/ void Start();
                /*0x7abfc18*/ void OnDestroy();
                /*0x7abee44*/ void BeginInteraction(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera);
                /*0x7abf0f8*/ void MoveStick(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera);
                /*0x7abf4c0*/ void EndInteraction();
                /*0x7abfcb4*/ void OnPointerDown(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7ac024c*/ void OnPointerChanged(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7ac0390*/ void OnPointerMove(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7ac029c*/ void OnPointerUp(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7ac0118*/ UnityEngine.Camera GetCameraFromCanvas();
                /*0x7ac04a0*/ void OnDrawGizmosSelected();
                /*0x7ac0688*/ void DrawGizmoCircle(UnityEngine.Vector2 center, float radius);
                /*0x7ac076c*/ void UpdateDynamicOriginClickableArea();
                /*0x7ac0858*/ float get_movementRange();
                /*0x7ac0860*/ void set_movementRange(float value);
                /*0x7ac0868*/ float get_dynamicOriginRange();
                /*0x7ac0870*/ void set_dynamicOriginRange(float value);
                /*0x7ac0888*/ bool get_useIsolatedInputActions();
                /*0x7ac0890*/ void set_useIsolatedInputActions(bool value);
                /*0x7ac089c*/ string get_controlPathInternal();
                /*0x7ac08a4*/ void set_controlPathInternal(string value);
                /*0x7ac08ac*/ UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour get_behaviour();
                /*0x7ac08b4*/ void set_behaviour(UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour value);

                enum Behaviour
                {
                    RelativePositionWithStaticOrigin = 0,
                    ExactPositionWithStaticOrigin = 1,
                    ExactPositionWithDynamicOrigin = 2,
                }
            }

            class OnScreenSupport
            {
                static /*0x7ac08d0*/ void Initialize();
            }
        }

        namespace HID
        {
            class HID : UnityEngine.InputSystem.InputDevice
            {
                static string kHIDInterface = "HID";
                static string kHIDNamespace = "HID";
                static /*0x0*/ Unity.Profiling.ProfilerMarker k_HIDParseDescriptorFallback;
                /*0x188*/ bool m_HaveParsedHIDDescriptor;
                /*0x190*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor m_HIDDescriptor;

                static /*0x7ac2be4*/ HID();
                static /*0x7ac08d4*/ UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorDeviceCommandType();
                static /*0x7ac0904*/ UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType();
                static /*0x7ac0934*/ UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType();
                static /*0x7ac0a14*/ string OnFindLayoutForDevice(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand);
                static /*0x7ac13d8*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate);
                static /*0x7ac2ab8*/ string UsagePageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage);
                static /*0x7ac2b44*/ string UsageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage);
                /*0x7ac2bdc*/ HID();
                /*0x7ac0964*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor();

                class HIDLayoutBuilder
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor hidDescriptor;
                    /*0x48*/ string parentLayout;
                    /*0x50*/ System.Type deviceType;

                    /*0x7ac1b94*/ HIDLayoutBuilder();
                    /*0x7ac2c58*/ UnityEngine.InputSystem.Layouts.InputControlLayout Build();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.HID.HID.HIDLayoutBuilder.<> <>9;
                        static /*0x8*/ System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_0;
                        static /*0x10*/ System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_1;
                        static /*0x18*/ System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem, string> <>9__4_2;

                        static /*0x7ac48e8*/ <>c();
                        /*0x7ac4950*/ <>c();
                        /*0x7ac4958*/ bool <Build>b__4_0(UnityEngine.InputSystem.HID.HID.HIDElementDescriptor element);
                        /*0x7ac497c*/ bool <Build>b__4_1(UnityEngine.InputSystem.HID.HID.HIDElementDescriptor element);
                        /*0x7ac49a0*/ string <Build>b__4_2(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem x);
                    }
                }

                enum HIDReportType
                {
                    Unknown = 0,
                    Input = 1,
                    Output = 2,
                    Feature = 3,
                }

                enum HIDCollectionType
                {
                    Physical = 0,
                    Application = 1,
                    Logical = 2,
                    Report = 3,
                    NamedArray = 4,
                    UsageSwitch = 5,
                    UsageModifier = 6,
                }

                enum HIDElementFlags
                {
                    Constant = 1,
                    Variable = 2,
                    Relative = 4,
                    Wrap = 8,
                    NonLinear = 16,
                    NoPreferred = 32,
                    NullState = 64,
                    Volatile = 128,
                    BufferedBytes = 256,
                }

                struct HIDElementDescriptor
                {
                    /*0x10*/ int usage;
                    /*0x14*/ UnityEngine.InputSystem.HID.HID.UsagePage usagePage;
                    /*0x18*/ int unit;
                    /*0x1c*/ int unitExponent;
                    /*0x20*/ int logicalMin;
                    /*0x24*/ int logicalMax;
                    /*0x28*/ int physicalMin;
                    /*0x2c*/ int physicalMax;
                    /*0x30*/ UnityEngine.InputSystem.HID.HID.HIDReportType reportType;
                    /*0x34*/ int collectionIndex;
                    /*0x38*/ int reportId;
                    /*0x3c*/ int reportSizeInBits;
                    /*0x40*/ int reportOffsetInBits;
                    /*0x44*/ UnityEngine.InputSystem.HID.HID.HIDElementFlags flags;
                    /*0x48*/ System.Nullable<int> usageMin;
                    /*0x50*/ System.Nullable<int> usageMax;

                    /*0x7ac49ac*/ bool get_hasNullState();
                    /*0x7ac49b8*/ bool get_hasPreferredState();
                    /*0x7ac49c8*/ bool get_isArray();
                    /*0x7ac49d8*/ bool get_isNonLinear();
                    /*0x7ac49e4*/ bool get_isRelative();
                    /*0x7ac49f0*/ bool get_isConstant();
                    /*0x7ac49fc*/ bool get_isWrapping();
                    /*0x7ac3a14*/ bool get_isSigned();
                    /*0x7ac4a08*/ float get_minFloatValue();
                    /*0x7ac4aa0*/ float get_maxFloatValue();
                    /*0x7ac3b58*/ bool Is(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage);
                    /*0x7ac3c74*/ string DetermineName();
                    /*0x7ac3e6c*/ string DetermineDisplayName();
                    /*0x7ac1b5c*/ bool IsUsableElement();
                    /*0x7ac3b7c*/ string DetermineLayout();
                    /*0x7ac3f5c*/ UnityEngine.InputSystem.Utilities.FourCC DetermineFormat();
                    /*0x7ac4080*/ UnityEngine.InputSystem.Utilities.InternedString[] DetermineUsages();
                    /*0x7ac38cc*/ string DetermineParameters();
                    /*0x7ac4b40*/ string DetermineAxisNormalizationParameters();
                    /*0x7ac3ae8*/ string DetermineProcessors();
                    /*0x7ac3a20*/ UnityEngine.InputSystem.Utilities.PrimitiveValue DetermineDefaultState();
                    /*0x7ac4268*/ void AddChildControls(ref UnityEngine.InputSystem.HID.HID.HIDElementDescriptor element, string controlName, ref UnityEngine.InputSystem.Layouts.InputControlLayout.Builder builder);
                }

                struct HIDCollectionDescriptor
                {
                    /*0x10*/ UnityEngine.InputSystem.HID.HID.HIDCollectionType type;
                    /*0x14*/ int usage;
                    /*0x18*/ UnityEngine.InputSystem.HID.HID.UsagePage usagePage;
                    /*0x1c*/ int parent;
                    /*0x20*/ int childCount;
                    /*0x24*/ int firstChild;
                }

                struct HIDDeviceDescriptor
                {
                    /*0x10*/ int vendorId;
                    /*0x14*/ int productId;
                    /*0x18*/ int usage;
                    /*0x1c*/ UnityEngine.InputSystem.HID.HID.UsagePage usagePage;
                    /*0x20*/ int inputReportSize;
                    /*0x24*/ int outputReportSize;
                    /*0x28*/ int featureReportSize;
                    /*0x30*/ UnityEngine.InputSystem.HID.HID.HIDElementDescriptor[] elements;
                    /*0x38*/ UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor[] collections;

                    static /*0x7ac1b9c*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor FromJson(string json);
                    /*0x7ac2a48*/ string ToJson();
                }

                struct HIDDeviceDescriptorBuilder
                {
                    /*0x10*/ UnityEngine.InputSystem.HID.HID.UsagePage usagePage;
                    /*0x14*/ int usage;
                    /*0x18*/ int m_CurrentReportId;
                    /*0x1c*/ UnityEngine.InputSystem.HID.HID.HIDReportType m_CurrentReportType;
                    /*0x20*/ int m_CurrentReportOffsetInBits;
                    /*0x28*/ System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> m_Elements;
                    /*0x30*/ System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor> m_Collections;
                    /*0x38*/ int m_InputReportSize;
                    /*0x3c*/ int m_OutputReportSize;
                    /*0x40*/ int m_FeatureReportSize;

                    /*0x7ac4e74*/ HIDDeviceDescriptorBuilder(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage);
                    /*0x7ac4e8c*/ HIDDeviceDescriptorBuilder(UnityEngine.InputSystem.HID.HID.GenericDesktop usage);
                    /*0x7ac4ea8*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder StartReport(UnityEngine.InputSystem.HID.HID.HIDReportType reportType, int reportId);
                    /*0x7ac4ed0*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage, int sizeInBits);
                    /*0x7ac5298*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.GenericDesktop usage, int sizeInBits);
                    /*0x7ac52e0*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max);
                    /*0x7ac5470*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max);
                    /*0x7ac55e4*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor Finish();
                }

                enum UsagePage
                {
                    Undefined = 0,
                    GenericDesktop = 1,
                    Simulation = 2,
                    VRControls = 3,
                    SportControls = 4,
                    GameControls = 5,
                    GenericDeviceControls = 6,
                    Keyboard = 7,
                    LEDs = 8,
                    Button = 9,
                    Ordinal = 10,
                    Telephony = 11,
                    Consumer = 12,
                    Digitizer = 13,
                    PID = 15,
                    Unicode = 16,
                    AlphanumericDisplay = 20,
                    MedicalInstruments = 64,
                    Monitor = 128,
                    Power = 132,
                    BarCodeScanner = 140,
                    MagneticStripeReader = 142,
                    Camera = 144,
                    Arcade = 145,
                    VendorDefined = 65280,
                }

                enum GenericDesktop
                {
                    Undefined = 0,
                    Pointer = 1,
                    Mouse = 2,
                    Joystick = 4,
                    Gamepad = 5,
                    Keyboard = 6,
                    Keypad = 7,
                    MultiAxisController = 8,
                    TabletPCControls = 9,
                    AssistiveControl = 10,
                    X = 48,
                    Y = 49,
                    Z = 50,
                    Rx = 51,
                    Ry = 52,
                    Rz = 53,
                    Slider = 54,
                    Dial = 55,
                    Wheel = 56,
                    HatSwitch = 57,
                    CountedBuffer = 58,
                    ByteCount = 59,
                    MotionWakeup = 60,
                    Start = 61,
                    Select = 62,
                    Vx = 64,
                    Vy = 65,
                    Vz = 66,
                    Vbrx = 67,
                    Vbry = 68,
                    Vbrz = 69,
                    Vno = 70,
                    FeatureNotification = 71,
                    ResolutionMultiplier = 72,
                    SystemControl = 128,
                    SystemPowerDown = 129,
                    SystemSleep = 130,
                    SystemWakeUp = 131,
                    SystemContextMenu = 132,
                    SystemMainMenu = 133,
                    SystemAppMenu = 134,
                    SystemMenuHelp = 135,
                    SystemMenuExit = 136,
                    SystemMenuSelect = 137,
                    SystemMenuRight = 138,
                    SystemMenuLeft = 139,
                    SystemMenuUp = 140,
                    SystemMenuDown = 141,
                    SystemColdRestart = 142,
                    SystemWarmRestart = 143,
                    DpadUp = 144,
                    DpadDown = 145,
                    DpadRight = 146,
                    DpadLeft = 147,
                    SystemDock = 160,
                    SystemUndock = 161,
                    SystemSetup = 162,
                    SystemBreak = 163,
                    SystemDebuggerBreak = 164,
                    ApplicationBreak = 165,
                    ApplicationDebuggerBreak = 166,
                    SystemSpeakerMute = 167,
                    SystemHibernate = 168,
                    SystemDisplayInvert = 176,
                    SystemDisplayInternal = 177,
                    SystemDisplayExternal = 178,
                    SystemDisplayBoth = 179,
                    SystemDisplayDual = 180,
                    SystemDisplayToggleIntExt = 181,
                    SystemDisplaySwapPrimarySecondary = 182,
                    SystemDisplayLCDAutoScale = 183,
                }

                enum Simulation
                {
                    Undefined = 0,
                    FlightSimulationDevice = 1,
                    AutomobileSimulationDevice = 2,
                    TankSimulationDevice = 3,
                    SpaceshipSimulationDevice = 4,
                    SubmarineSimulationDevice = 5,
                    SailingSimulationDevice = 6,
                    MotorcycleSimulationDevice = 7,
                    SportsSimulationDevice = 8,
                    AirplaneSimulationDevice = 9,
                    HelicopterSimulationDevice = 10,
                    MagicCarpetSimulationDevice = 11,
                    BicylcleSimulationDevice = 12,
                    FlightControlStick = 32,
                    FlightStick = 33,
                    CyclicControl = 34,
                    CyclicTrim = 35,
                    FlightYoke = 36,
                    TrackControl = 37,
                    Aileron = 176,
                    AileronTrim = 177,
                    AntiTorqueControl = 178,
                    AutopilotEnable = 179,
                    ChaffRelease = 180,
                    CollectiveControl = 181,
                    DiveBreak = 182,
                    ElectronicCountermeasures = 183,
                    Elevator = 184,
                    ElevatorTrim = 185,
                    Rudder = 186,
                    Throttle = 187,
                    FlightCommunications = 188,
                    FlareRelease = 189,
                    LandingGear = 190,
                    ToeBreak = 191,
                    Trigger = 192,
                    WeaponsArm = 193,
                    WeaponsSelect = 194,
                    WingFlaps = 195,
                    Accelerator = 196,
                    Brake = 197,
                    Clutch = 198,
                    Shifter = 199,
                    Steering = 200,
                    TurretDirection = 201,
                    BarrelElevation = 202,
                    DivePlane = 203,
                    Ballast = 204,
                    BicycleCrank = 205,
                    HandleBars = 206,
                    FrontBrake = 207,
                    RearBrake = 208,
                }

                enum Button
                {
                    Undefined = 0,
                    Primary = 1,
                    Secondary = 2,
                    Tertiary = 3,
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ UnityEngine.InputSystem.HID.HID.HIDLayoutBuilder layout;

                    /*0x7ac56c0*/ <>c__DisplayClass13_0();
                    /*0x7ac56c8*/ UnityEngine.InputSystem.Layouts.InputControlLayout <OnFindLayoutForDevice>b__0();
                }
            }

            class HIDParser
            {
                static /*0x7ac56e4*/ bool ParseReportDescriptor(byte[] buffer, ref UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor deviceDescriptor);
                static /*0x7ac5750*/ bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor deviceDescriptor);
                static /*0x7ac62f4*/ int ReadData(int itemSize, byte* currentPtr, byte* endPtr);

                struct HIDReportData
                {
                    /*0x10*/ int reportId;
                    /*0x14*/ UnityEngine.InputSystem.HID.HID.HIDReportType reportType;
                    /*0x18*/ int currentBitOffset;

                    static /*0x7ac66e8*/ int FindOrAddReport(System.Nullable<int> reportId, UnityEngine.InputSystem.HID.HID.HIDReportType reportType, System.Collections.Generic.List<UnityEngine.InputSystem.HID.HIDParser.HIDReportData> reports);
                }

                enum HIDItemTypeAndTag
                {
                    Input = 128,
                    Output = 144,
                    Feature = 176,
                    Collection = 160,
                    EndCollection = 192,
                    UsagePage = 4,
                    LogicalMinimum = 20,
                    LogicalMaximum = 36,
                    PhysicalMinimum = 52,
                    PhysicalMaximum = 68,
                    UnitExponent = 84,
                    Unit = 100,
                    ReportSize = 116,
                    ReportID = 132,
                    ReportCount = 148,
                    Push = 164,
                    Pop = 180,
                    Usage = 8,
                    UsageMinimum = 24,
                    UsageMaximum = 40,
                    DesignatorIndex = 56,
                    DesignatorMinimum = 72,
                    DesignatorMaximum = 88,
                    StringIndex = 120,
                    StringMinimum = 136,
                    StringMaximum = 152,
                    Delimiter = 168,
                }

                struct HIDItemStateLocal
                {
                    /*0x10*/ System.Nullable<int> usage;
                    /*0x18*/ System.Nullable<int> usageMinimum;
                    /*0x20*/ System.Nullable<int> usageMaximum;
                    /*0x28*/ System.Nullable<int> designatorIndex;
                    /*0x30*/ System.Nullable<int> designatorMinimum;
                    /*0x38*/ System.Nullable<int> designatorMaximum;
                    /*0x40*/ System.Nullable<int> stringIndex;
                    /*0x48*/ System.Nullable<int> stringMinimum;
                    /*0x50*/ System.Nullable<int> stringMaximum;
                    /*0x58*/ System.Collections.Generic.List<int> usageList;

                    static /*0x7ac6678*/ void Reset(ref UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal state);
                    /*0x7ac635c*/ void SetUsage(int value);
                    /*0x7ac6568*/ int GetUsage(int index);
                }

                struct HIDItemStateGlobal
                {
                    /*0x10*/ System.Nullable<int> usagePage;
                    /*0x18*/ System.Nullable<int> logicalMinimum;
                    /*0x20*/ System.Nullable<int> logicalMaximum;
                    /*0x28*/ System.Nullable<int> physicalMinimum;
                    /*0x30*/ System.Nullable<int> physicalMaximum;
                    /*0x38*/ System.Nullable<int> unitExponent;
                    /*0x40*/ System.Nullable<int> unit;
                    /*0x48*/ System.Nullable<int> reportSize;
                    /*0x50*/ System.Nullable<int> reportCount;
                    /*0x58*/ System.Nullable<int> reportId;

                    /*0x7ac64dc*/ UnityEngine.InputSystem.HID.HID.UsagePage GetUsagePage(int index, ref UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal localItemState);
                    /*0x7ac6870*/ int GetPhysicalMin();
                    /*0x7ac6934*/ int GetPhysicalMax();
                }
            }

            class HIDSupport
            {
                static /*0x0*/ UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage[] s_SupportedHIDUsages;

                static /*0x7ac69e8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages();
                static /*0x7ac6a48*/ void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value);
                static /*0x7ac6c8c*/ void Initialize();

                struct HIDPageUsage
                {
                    /*0x10*/ UnityEngine.InputSystem.HID.HID.UsagePage page;
                    /*0x14*/ int usage;

                    /*0x7ac6c84*/ HIDPageUsage(UnityEngine.InputSystem.HID.HID.UsagePage page, int usage);
                    /*0x7ac6dec*/ HIDPageUsage(UnityEngine.InputSystem.HID.HID.GenericDesktop usage);
                }
            }
        }

        namespace EnhancedTouch
        {
            class EnhancedTouchSupport
            {
                static /*0x0*/ int s_Enabled;
                static /*0x4*/ UnityEngine.InputSystem.InputSettings.UpdateMode s_UpdateMode;

                static /*0x7ac6df8*/ bool get_enabled();
                static /*0x7ac6e48*/ void Enable();
                static /*0x7ac7198*/ void Disable();
                static /*0x7ac74dc*/ void Reset();
                static /*0x7ac6fb8*/ void SetUpState();
                static /*0x7ac731c*/ void TearDownState();
                static /*0x7ac7608*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
                static /*0x7ac7894*/ void OnSettingsChange();
                static /*0x7ac792c*/ void CheckEnabled();
            }

            class Finger
            {
                /*0x10*/ UnityEngine.InputSystem.Touchscreen <screen>k__BackingField;
                /*0x18*/ int <index>k__BackingField;
                /*0x20*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory;

                static /*0x7ac8290*/ bool ShouldRecordTouch(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7ac7f04*/ Finger(UnityEngine.InputSystem.Touchscreen screen, int index, UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask);
                /*0x7ac79c4*/ UnityEngine.InputSystem.Touchscreen get_screen();
                /*0x7ac79cc*/ int get_index();
                /*0x7ac79d4*/ bool get_isActive();
                /*0x7ac7ba0*/ UnityEngine.Vector2 get_screenPosition();
                /*0x7ac7c48*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_lastTouch();
                /*0x7ac7a4c*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_currentTouch();
                /*0x7ac7e64*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_touchHistory();
                /*0x7ac8378*/ void OnTouchRecorded(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record);
                /*0x7ac862c*/ UnityEngine.InputSystem.EnhancedTouch.Touch FindTouch(uint uniqueId);
                /*0x7ac8994*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory GetTouchHistory(UnityEngine.InputSystem.EnhancedTouch.Touch touch);
            }

            struct Touch : System.IEquatable<UnityEngine.InputSystem.EnhancedTouch.Touch>
            {
                static /*0x0*/ UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState s_GlobalState;
                /*0x10*/ UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> m_TouchRecord;

                static /*0x7acab20*/ Touch();
                static /*0x7ac9378*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches();
                static /*0x7ac99d8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers();
                static /*0x7ac9a68*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers();
                static /*0x7ac9c20*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens();
                static /*0x7ac9cac*/ void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ac9d70*/ void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ac9e34*/ void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ac9ef8*/ void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ac9fbc*/ void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7aca080*/ void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ac8238*/ int get_maxHistoryLengthPerFinger();
                static /*0x7ac7724*/ void AddTouchscreen(UnityEngine.InputSystem.Touchscreen screen);
                static /*0x7ac77b0*/ void RemoveTouchscreen(UnityEngine.InputSystem.Touchscreen screen);
                static /*0x7aca848*/ void BeginUpdate();
                static /*0x7aca8bc*/ UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState CreateGlobalState();
                static /*0x7aca8e8*/ UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState();
                /*0x7ac7d5c*/ Touch(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> touchRecord);
                /*0x7ac7b58*/ bool get_valid();
                /*0x7ac8cb0*/ UnityEngine.InputSystem.EnhancedTouch.Finger get_finger();
                /*0x7ac8c54*/ UnityEngine.InputSystem.TouchPhase get_phase();
                /*0x7ac8d00*/ bool get_began();
                /*0x7ac8d60*/ bool get_inProgress();
                /*0x7ac8e08*/ bool get_ended();
                /*0x7ac8bf8*/ int get_touchId();
                /*0x7ac8e90*/ float get_pressure();
                /*0x7ac8eec*/ UnityEngine.Vector2 get_radius();
                /*0x7ac8f48*/ double get_startTime();
                /*0x7ac8fa4*/ double get_time();
                /*0x7ac8fec*/ UnityEngine.InputSystem.Touchscreen get_screen();
                /*0x7ac7d00*/ UnityEngine.Vector2 get_screenPosition();
                /*0x7ac904c*/ UnityEngine.Vector2 get_startScreenPosition();
                /*0x7ac90a8*/ UnityEngine.Vector2 get_delta();
                /*0x7ac9104*/ int get_tapCount();
                /*0x7ac9160*/ bool get_isTap();
                /*0x7ac91cc*/ int get_displayIndex();
                /*0x7ac7d94*/ bool get_isInProgress();
                /*0x7ac7e08*/ uint get_updateStepCount();
                /*0x7ac8b9c*/ uint get_uniqueId();
                /*0x7ac8cb8*/ ref UnityEngine.InputSystem.LowLevel.TouchState get_state();
                /*0x7ac9228*/ ref UnityEngine.InputSystem.EnhancedTouch.Touch.ExtraDataPerTouchState get_extraData();
                /*0x7ac9270*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_history();
                /*0x7aca144*/ string ToString();
                /*0x7aca458*/ bool Equals(UnityEngine.InputSystem.EnhancedTouch.Touch other);
                /*0x7aca4cc*/ bool Equals(object obj);
                /*0x7aca57c*/ int GetHashCode();

                struct GlobalState
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Touchscreen> touchscreens;
                    /*0x28*/ int historyLengthPerFinger;
                    /*0x30*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerDown;
                    /*0x80*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerMove;
                    /*0xd0*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerUp;
                    /*0x120*/ UnityEngine.InputSystem.EnhancedTouch.Touch.FingerAndTouchState playerState;
                }

                struct FingerAndTouchState
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask;
                    /*0x18*/ UnityEngine.InputSystem.EnhancedTouch.Finger[] fingers;
                    /*0x20*/ UnityEngine.InputSystem.EnhancedTouch.Finger[] activeFingers;
                    /*0x28*/ UnityEngine.InputSystem.EnhancedTouch.Touch[] activeTouches;
                    /*0x30*/ int activeFingerCount;
                    /*0x34*/ int activeTouchCount;
                    /*0x38*/ int totalFingerCount;
                    /*0x3c*/ uint lastId;
                    /*0x40*/ bool haveBuiltActiveTouches;
                    /*0x41*/ bool haveActiveTouchesNeedingRefreshNextUpdate;
                    /*0x48*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> activeTouchState;

                    /*0x7aca5f0*/ void AddFingers(UnityEngine.InputSystem.Touchscreen screen);
                    /*0x7aca704*/ void RemoveFingers(UnityEngine.InputSystem.Touchscreen screen);
                    /*0x7ac757c*/ void Destroy();
                    /*0x7ac9b08*/ void UpdateActiveFingers();
                    /*0x7ac9418*/ void UpdateActiveTouches();
                }

                struct ExtraDataPerTouchState
                {
                    /*0x10*/ UnityEngine.Vector2 accumulatedDelta;
                    /*0x18*/ uint uniqueId;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.EnhancedTouch.Touch.<> <>9;
                    static /*0x8*/ UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState> <>9__80_0;
                    static /*0x10*/ System.Action <>9__80_1;

                    static /*0x7acab9c*/ <>c();
                    /*0x7acac04*/ <>c();
                    /*0x7acac0c*/ void <SaveAndResetState>b__80_0(ref UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState state);
                    /*0x7acaca0*/ void <SaveAndResetState>b__80_1();
                }
            }

            struct TouchHistory : System.Collections.Generic.IReadOnlyList<UnityEngine.InputSystem.EnhancedTouch.Touch>, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.EnhancedTouch.Touch>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.InputSystem.EnhancedTouch.Touch>
            {
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_History;
                /*0x18*/ UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;
                /*0x20*/ int m_Count;
                /*0x24*/ int m_StartIndex;
                /*0x28*/ uint m_Version;

                /*0x7ac7e84*/ TouchHistory(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex, int count);
                /*0x7acaca4*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator();
                /*0x7acad68*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7acad6c*/ int get_Count();
                /*0x7acad74*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_Item(int index);
                /*0x7acaed8*/ void CheckValid();

                class Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory m_Owner;
                    /*0x30*/ int m_Index;

                    /*0x7acad28*/ Enumerator(UnityEngine.InputSystem.EnhancedTouch.TouchHistory owner);
                    /*0x7acaf6c*/ bool MoveNext();
                    /*0x7acaf94*/ void Reset();
                    /*0x7acafa0*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_Current();
                    /*0x7acafe0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7acb064*/ void Dispose();
                }
            }

            class TouchSimulation : UnityEngine.MonoBehaviour, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
            {
                static /*0x0*/ UnityEngine.InputSystem.EnhancedTouch.TouchSimulation s_Instance;
                /*0x20*/ UnityEngine.InputSystem.Touchscreen <simulatedTouchscreen>k__BackingField;
                /*0x28*/ int m_NumPointers;
                /*0x30*/ UnityEngine.InputSystem.Pointer[] m_Pointers;
                /*0x38*/ UnityEngine.Vector2[] m_CurrentPositions;
                /*0x40*/ int[] m_CurrentDisplayIndices;
                /*0x48*/ UnityEngine.InputSystem.Controls.ButtonControl[] m_Touches;
                /*0x50*/ int[] m_TouchIds;
                /*0x58*/ int m_LastTouchId;
                /*0x60*/ System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> m_OnDeviceChange;
                /*0x68*/ System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> m_OnEvent;

                static /*0x7acb078*/ UnityEngine.InputSystem.EnhancedTouch.TouchSimulation get_instance();
                static /*0x7acb0c0*/ void Enable();
                static /*0x7acb264*/ void Disable();
                static /*0x7acb33c*/ void Destroy();
                /*0x7acca24*/ TouchSimulation();
                /*0x7acb068*/ UnityEngine.InputSystem.Touchscreen get_simulatedTouchscreen();
                /*0x7acb070*/ void set_simulatedTouchscreen(UnityEngine.InputSystem.Touchscreen value);
                /*0x7acb424*/ void AddPointer(UnityEngine.InputSystem.Pointer pointer);
                /*0x7acb594*/ void RemovePointer(UnityEngine.InputSystem.Pointer pointer);
                /*0x7acba14*/ void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                /*0x7acbfe0*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
                /*0x7acc12c*/ void OnEnable();
                /*0x7acc6d4*/ void OnDisable();
                /*0x7acb788*/ void UpdateTouch(int touchIndex, int pointerIndex, UnityEngine.InputSystem.TouchPhase phase, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7acca10*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                /*0x7acca14*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
                /*0x7acca18*/ void InstallStateChangeMonitors(int startIndex);
                /*0x7acca1c*/ void OnSourceControlChangedValue(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long sourceDeviceAndButtonIndex);
                /*0x7acca20*/ void UninstallStateChangeMonitors(int startIndex);
            }
        }

        namespace DualShock
        {
            class DualShockGamepad : UnityEngine.InputSystem.Gamepad, UnityEngine.InputSystem.DualShock.IDualShockHaptics, UnityEngine.InputSystem.Haptics.IDualMotorRumble, UnityEngine.InputSystem.Haptics.IHaptics
            {
                static /*0x0*/ UnityEngine.InputSystem.DualShock.DualShockGamepad <current>k__BackingField;
                /*0x208*/ UnityEngine.InputSystem.Controls.ButtonControl <touchpadButton>k__BackingField;
                /*0x210*/ UnityEngine.InputSystem.Controls.ButtonControl <optionsButton>k__BackingField;
                /*0x218*/ UnityEngine.InputSystem.Controls.ButtonControl <shareButton>k__BackingField;
                /*0x220*/ UnityEngine.InputSystem.Controls.ButtonControl <L1>k__BackingField;
                /*0x228*/ UnityEngine.InputSystem.Controls.ButtonControl <R1>k__BackingField;
                /*0x230*/ UnityEngine.InputSystem.Controls.ButtonControl <L2>k__BackingField;
                /*0x238*/ UnityEngine.InputSystem.Controls.ButtonControl <R2>k__BackingField;
                /*0x240*/ UnityEngine.InputSystem.Controls.ButtonControl <L3>k__BackingField;
                /*0x248*/ UnityEngine.InputSystem.Controls.ButtonControl <R3>k__BackingField;
                /*0x250*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor <hidDescriptor>k__BackingField;

                static /*0x7accb04*/ UnityEngine.InputSystem.DualShock.DualShockGamepad get_current();
                static /*0x7accb4c*/ void set_current(UnityEngine.InputSystem.DualShock.DualShockGamepad value);
                /*0x7acce4c*/ DualShockGamepad();
                /*0x7acca2c*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadButton();
                /*0x7acca34*/ void set_touchpadButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7acca44*/ UnityEngine.InputSystem.Controls.ButtonControl get_optionsButton();
                /*0x7acca4c*/ void set_optionsButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7acca5c*/ UnityEngine.InputSystem.Controls.ButtonControl get_shareButton();
                /*0x7acca64*/ void set_shareButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7acca74*/ UnityEngine.InputSystem.Controls.ButtonControl get_L1();
                /*0x7acca7c*/ void set_L1(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7acca8c*/ UnityEngine.InputSystem.Controls.ButtonControl get_R1();
                /*0x7acca94*/ void set_R1(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7accaa4*/ UnityEngine.InputSystem.Controls.ButtonControl get_L2();
                /*0x7accaac*/ void set_L2(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7accabc*/ UnityEngine.InputSystem.Controls.ButtonControl get_R2();
                /*0x7accac4*/ void set_R2(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7accad4*/ UnityEngine.InputSystem.Controls.ButtonControl get_L3();
                /*0x7accadc*/ void set_L3(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7accaec*/ UnityEngine.InputSystem.Controls.ButtonControl get_R3();
                /*0x7accaf4*/ void set_R3(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7accba4*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor();
                /*0x7accbb8*/ void set_hidDescriptor(UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor value);
                /*0x7accbd8*/ void MakeCurrent();
                /*0x7accc38*/ void OnRemoved();
                /*0x7acccd4*/ void FinishSetup();
                /*0x7acce48*/ void SetLightBarColor(UnityEngine.Color color);
            }

            class DualShockSupport
            {
                static /*0x7acce54*/ void Initialize();
            }

            interface IDualShockHaptics : UnityEngine.InputSystem.Haptics.IDualMotorRumble, UnityEngine.InputSystem.Haptics.IHaptics
            {
                /*0x3815d48*/ void SetLightBarColor(UnityEngine.Color color);
            }
        }

        namespace Android
        {
            class AndroidGamepad : UnityEngine.InputSystem.Gamepad
            {
                /*0x7accec4*/ AndroidGamepad();
            }

            class AndroidGamepadWithDpadAxes : UnityEngine.InputSystem.Android.AndroidGamepad
            {
                /*0x7accecc*/ AndroidGamepadWithDpadAxes();
            }

            class AndroidGamepadWithDpadButtons : UnityEngine.InputSystem.Android.AndroidGamepad
            {
                /*0x7acced4*/ AndroidGamepadWithDpadButtons();
            }

            class AndroidJoystick : UnityEngine.InputSystem.Joystick
            {
                /*0x7accedc*/ AndroidJoystick();
            }

            class DualShock4GamepadAndroid : UnityEngine.InputSystem.DualShock.DualShockGamepad
            {
                /*0x7accee4*/ DualShock4GamepadAndroid();
            }

            class XboxOneGamepadAndroid : UnityEngine.InputSystem.XInput.XInputController
            {
                /*0x7acceec*/ XboxOneGamepadAndroid();
            }

            class AndroidAccelerometer : UnityEngine.InputSystem.Accelerometer
            {
                /*0x7accef4*/ AndroidAccelerometer();
            }

            class AndroidMagneticFieldSensor : UnityEngine.InputSystem.MagneticFieldSensor
            {
                /*0x7accefc*/ AndroidMagneticFieldSensor();
            }

            class AndroidGyroscope : UnityEngine.InputSystem.Gyroscope
            {
                /*0x7accf04*/ AndroidGyroscope();
            }

            class AndroidLightSensor : UnityEngine.InputSystem.LightSensor
            {
                /*0x7accf0c*/ AndroidLightSensor();
            }

            class AndroidPressureSensor : UnityEngine.InputSystem.PressureSensor
            {
                /*0x7accf14*/ AndroidPressureSensor();
            }

            class AndroidProximity : UnityEngine.InputSystem.ProximitySensor
            {
                /*0x7accf1c*/ AndroidProximity();
            }

            class AndroidGravitySensor : UnityEngine.InputSystem.GravitySensor
            {
                /*0x7accf24*/ AndroidGravitySensor();
            }

            class AndroidLinearAccelerationSensor : UnityEngine.InputSystem.LinearAccelerationSensor
            {
                /*0x7accf2c*/ AndroidLinearAccelerationSensor();
            }

            class AndroidRotationVector : UnityEngine.InputSystem.AttitudeSensor
            {
                /*0x7accf34*/ AndroidRotationVector();
            }

            class AndroidRelativeHumidity : UnityEngine.InputSystem.HumiditySensor
            {
                /*0x7accf3c*/ AndroidRelativeHumidity();
            }

            class AndroidAmbientTemperature : UnityEngine.InputSystem.AmbientTemperatureSensor
            {
                /*0x7accf44*/ AndroidAmbientTemperature();
            }

            class AndroidGameRotationVector : UnityEngine.InputSystem.AttitudeSensor
            {
                /*0x7accf4c*/ AndroidGameRotationVector();
            }

            class AndroidStepCounter : UnityEngine.InputSystem.StepCounter
            {
                /*0x7accf54*/ AndroidStepCounter();
            }

            class AndroidHingeAngle : UnityEngine.InputSystem.HingeAngle
            {
                /*0x7accf5c*/ AndroidHingeAngle();
            }

            class AndroidSupport
            {
                static string kAndroidInterface = "Android";

                static /*0x7accf64*/ void Initialize();
                static /*0x7acd974*/ string OnFindLayoutForDevice(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate);
                /*0x7acdc7c*/ AndroidSupport();
            }

            namespace LowLevel
            {
                enum AndroidAxis
                {
                    X = 0,
                    Y = 1,
                    Pressure = 2,
                    Size = 3,
                    TouchMajor = 4,
                    TouchMinor = 5,
                    ToolMajor = 6,
                    ToolMinor = 7,
                    Orientation = 8,
                    Vscroll = 9,
                    Hscroll = 10,
                    Z = 11,
                    Rx = 12,
                    Ry = 13,
                    Rz = 14,
                    HatX = 15,
                    HatY = 16,
                    Ltrigger = 17,
                    Rtrigger = 18,
                    Throttle = 19,
                    Rudder = 20,
                    Wheel = 21,
                    Gas = 22,
                    Brake = 23,
                    Distance = 24,
                    Tilt = 25,
                    Generic1 = 32,
                    Generic2 = 33,
                    Generic3 = 34,
                    Generic4 = 35,
                    Generic5 = 36,
                    Generic6 = 37,
                    Generic7 = 38,
                    Generic8 = 39,
                    Generic9 = 40,
                    Generic10 = 41,
                    Generic11 = 42,
                    Generic12 = 43,
                    Generic13 = 44,
                    Generic14 = 45,
                    Generic15 = 46,
                    Generic16 = 47,
                }

                struct AndroidGameControllerState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
                {
                    static int MaxAxes = 48;
                    static int MaxButtons = 220;
                    static uint kAxisOffset = 28;
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.FourCC kFormat;
                    /*0x10*/ UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState.<buttons> buttons;
                    /*0x2c*/ UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState.<axis> axis;

                    static /*0x7acdd3c*/ AndroidGameControllerState();
                    /*0x7acdc84*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                    /*0x7acdcdc*/ UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState WithButton(UnityEngine.InputSystem.Android.LowLevel.AndroidKeyCode code, bool value);
                    /*0x7acdd20*/ UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState WithAxis(UnityEngine.InputSystem.Android.LowLevel.AndroidAxis axis, float value);

                    class Variants
                    {
                        static string Gamepad = "Gamepad";
                        static string Joystick = "Joystick";
                        static string DPadAxes = "DpadAxes";
                        static string DPadButtons = "DpadButtons";

                        /*0x7acdda8*/ Variants();
                    }

                    struct <axis>e__FixedBuffer
                    {
                        /*0x10*/ float FixedElementField;
                    }

                    struct <buttons>e__FixedBuffer
                    {
                        /*0x10*/ uint FixedElementField;
                    }
                }

                enum AndroidInputSource
                {
                    Keyboard = 257,
                    Dpad = 513,
                    Gamepad = 1025,
                    Touchscreen = 4098,
                    Mouse = 8194,
                    Stylus = 16386,
                    Trackball = 65540,
                    Touchpad = 1048584,
                    Joystick = 16777232,
                }

                struct AndroidDeviceCapabilities
                {
                    /*0x10*/ string deviceDescriptor;
                    /*0x18*/ int productId;
                    /*0x1c*/ int vendorId;
                    /*0x20*/ bool isVirtual;
                    /*0x28*/ UnityEngine.InputSystem.Android.LowLevel.AndroidAxis[] motionAxes;
                    /*0x30*/ UnityEngine.InputSystem.Android.LowLevel.AndroidInputSource inputSources;

                    static /*0x7acdbc0*/ UnityEngine.InputSystem.Android.LowLevel.AndroidDeviceCapabilities FromJson(string json);
                    /*0x7acddb0*/ string ToJson();
                    /*0x7acde1c*/ string ToString();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Android.LowLevel.AndroidDeviceCapabilities.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.InputSystem.Android.LowLevel.AndroidAxis, string> <>9__8_0;

                        static /*0x7ace1c4*/ <>c();
                        /*0x7ace22c*/ <>c();
                        /*0x7ace234*/ string <ToString>b__8_0(UnityEngine.InputSystem.Android.LowLevel.AndroidAxis i);
                    }
                }

                enum AndroidKeyCode
                {
                    Unknown = 0,
                    SoftLeft = 1,
                    SoftRight = 2,
                    Home = 3,
                    Back = 4,
                    Call = 5,
                    Endcall = 6,
                    Alpha0 = 7,
                    Alpha1 = 8,
                    Alpha2 = 9,
                    Alpha3 = 10,
                    Alpha4 = 11,
                    Alpha5 = 12,
                    Alpha6 = 13,
                    Alpha7 = 14,
                    Alpha8 = 15,
                    Alpha9 = 16,
                    Star = 17,
                    Pound = 18,
                    DpadUp = 19,
                    DpadDown = 20,
                    DpadLeft = 21,
                    DpadRight = 22,
                    DpadCenter = 23,
                    VolumeUp = 24,
                    VolumeDown = 25,
                    Power = 26,
                    Camera = 27,
                    Clear = 28,
                    A = 29,
                    B = 30,
                    C = 31,
                    D = 32,
                    E = 33,
                    F = 34,
                    G = 35,
                    H = 36,
                    I = 37,
                    J = 38,
                    K = 39,
                    L = 40,
                    M = 41,
                    N = 42,
                    O = 43,
                    P = 44,
                    Q = 45,
                    R = 46,
                    S = 47,
                    T = 48,
                    U = 49,
                    V = 50,
                    W = 51,
                    X = 52,
                    Y = 53,
                    Z = 54,
                    Comma = 55,
                    Period = 56,
                    AltLeft = 57,
                    AltRight = 58,
                    ShiftLeft = 59,
                    ShiftRight = 60,
                    Tab = 61,
                    Space = 62,
                    Sym = 63,
                    Explorer = 64,
                    Envelope = 65,
                    Enter = 66,
                    Del = 67,
                    Grave = 68,
                    Minus = 69,
                    Equals = 70,
                    LeftBracket = 71,
                    RightBracket = 72,
                    Backslash = 73,
                    Semicolon = 74,
                    Apostrophe = 75,
                    Slash = 76,
                    At = 77,
                    Num = 78,
                    Headsethook = 79,
                    Focus = 80,
                    Plus = 81,
                    Menu = 82,
                    Notification = 83,
                    Search = 84,
                    MediaPlayPause = 85,
                    MediaStop = 86,
                    MediaNext = 87,
                    MediaPrevious = 88,
                    MediaRewind = 89,
                    MediaFastForward = 90,
                    Mute = 91,
                    PageUp = 92,
                    PageDown = 93,
                    Pictsymbols = 94,
                    SwitchCharset = 95,
                    ButtonA = 96,
                    ButtonB = 97,
                    ButtonC = 98,
                    ButtonX = 99,
                    ButtonY = 100,
                    ButtonZ = 101,
                    ButtonL1 = 102,
                    ButtonR1 = 103,
                    ButtonL2 = 104,
                    ButtonR2 = 105,
                    ButtonThumbl = 106,
                    ButtonThumbr = 107,
                    ButtonStart = 108,
                    ButtonSelect = 109,
                    ButtonMode = 110,
                    Escape = 111,
                    ForwardDel = 112,
                    CtrlLeft = 113,
                    CtrlRight = 114,
                    CapsLock = 115,
                    ScrollLock = 116,
                    MetaLeft = 117,
                    MetaRight = 118,
                    Function = 119,
                    Sysrq = 120,
                    Break = 121,
                    MoveHome = 122,
                    MoveEnd = 123,
                    Insert = 124,
                    Forward = 125,
                    MediaPlay = 126,
                    MediaPause = 127,
                    MediaClose = 128,
                    MediaEject = 129,
                    MediaRecord = 130,
                    F1 = 131,
                    F2 = 132,
                    F3 = 133,
                    F4 = 134,
                    F5 = 135,
                    F6 = 136,
                    F7 = 137,
                    F8 = 138,
                    F9 = 139,
                    F10 = 140,
                    F11 = 141,
                    F12 = 142,
                    NumLock = 143,
                    Numpad0 = 144,
                    Numpad1 = 145,
                    Numpad2 = 146,
                    Numpad3 = 147,
                    Numpad4 = 148,
                    Numpad5 = 149,
                    Numpad6 = 150,
                    Numpad7 = 151,
                    Numpad8 = 152,
                    Numpad9 = 153,
                    NumpadDivide = 154,
                    NumpadMultiply = 155,
                    NumpadSubtract = 156,
                    NumpadAdd = 157,
                    NumpadDot = 158,
                    NumpadComma = 159,
                    NumpadEnter = 160,
                    NumpadEquals = 161,
                    NumpadLeftParen = 162,
                    NumpadRightParen = 163,
                    VolumeMute = 164,
                    Info = 165,
                    ChannelUp = 166,
                    ChannelDown = 167,
                    ZoomIn = 168,
                    ZoomOut = 169,
                    Tv = 170,
                    Window = 171,
                    Guide = 172,
                    Dvr = 173,
                    Bookmark = 174,
                    Captions = 175,
                    Settings = 176,
                    TvPower = 177,
                    TvInput = 178,
                    StbPower = 179,
                    StbInput = 180,
                    AvrPower = 181,
                    AvrInput = 182,
                    ProgRed = 183,
                    ProgGreen = 184,
                    ProgYellow = 185,
                    ProgBlue = 186,
                    AppSwitch = 187,
                    Button1 = 188,
                    Button2 = 189,
                    Button3 = 190,
                    Button4 = 191,
                    Button5 = 192,
                    Button6 = 193,
                    Button7 = 194,
                    Button8 = 195,
                    Button9 = 196,
                    Button10 = 197,
                    Button11 = 198,
                    Button12 = 199,
                    Button13 = 200,
                    Button14 = 201,
                    Button15 = 202,
                    Button16 = 203,
                    LanguageSwitch = 204,
                    MannerMode = 205,
                    Mode3D = 206,
                    Contacts = 207,
                    Calendar = 208,
                    Music = 209,
                    Calculator = 210,
                    ZenkakuHankaku = 211,
                    Eisu = 212,
                    Muhenkan = 213,
                    Henkan = 214,
                    KatakanaHiragana = 215,
                    Yen = 216,
                    Ro = 217,
                    Kana = 218,
                    Assist = 219,
                }

                enum AndroidSensorType
                {
                    None = 0,
                    Accelerometer = 1,
                    MagneticField = 2,
                    Orientation = 3,
                    Gyroscope = 4,
                    Light = 5,
                    Pressure = 6,
                    Temperature = 7,
                    Proximity = 8,
                    Gravity = 9,
                    LinearAcceleration = 10,
                    RotationVector = 11,
                    RelativeHumidity = 12,
                    AmbientTemperature = 13,
                    MagneticFieldUncalibrated = 14,
                    GameRotationVector = 15,
                    GyroscopeUncalibrated = 16,
                    SignificantMotion = 17,
                    StepDetector = 18,
                    StepCounter = 19,
                    GeomagneticRotationVector = 20,
                    HeartRate = 21,
                    Pose6DOF = 28,
                    StationaryDetect = 29,
                    MotionDetect = 30,
                    HeartBeat = 31,
                    LowLatencyOffBodyDetect = 34,
                    AccelerometerUncalibrated = 35,
                    HingeAngle = 36,
                }

                struct AndroidSensorCapabilities
                {
                    /*0x10*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorType sensorType;

                    static /*0x7ace2fc*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorCapabilities FromJson(string json);
                    /*0x7ace298*/ string ToJson();
                    /*0x7ace398*/ string ToString();
                }

                struct AndroidSensorState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
                {
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.FourCC kFormat;
                    /*0x10*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorState.<data> data;

                    static /*0x7ace5a4*/ AndroidSensorState();
                    /*0x7ace430*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorState WithData(float[] data);
                    /*0x7ace54c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

                    struct <data>e__FixedBuffer
                    {
                        /*0x10*/ float FixedElementField;
                    }
                }

                class AndroidCompensateDirectionProcessor : UnityEngine.InputSystem.Processors.CompensateDirectionProcessor
                {
                    static float kSensorStandardGravity = 9.806650161743164;
                    static float kAccelerationMultiplier = -0.10197161883115768;

                    /*0x7ace62c*/ AndroidCompensateDirectionProcessor();
                    /*0x7ace610*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 vector, UnityEngine.InputSystem.InputControl control);
                }

                class AndroidCompensateRotationProcessor : UnityEngine.InputSystem.Processors.CompensateRotationProcessor
                {
                    /*0x7ace668*/ AndroidCompensateRotationProcessor();
                    /*0x7ace634*/ UnityEngine.Quaternion Process(UnityEngine.Quaternion value, UnityEngine.InputSystem.InputControl control);
                }
            }
        }

        namespace Haptics
        {
            struct DualMotorRumble
            {
                /*0x10*/ float <lowFrequencyMotorSpeed>k__BackingField;
                /*0x14*/ float <highFrequencyMotorSpeed>k__BackingField;

                /*0x7ace670*/ float get_lowFrequencyMotorSpeed();
                /*0x7ace678*/ void set_lowFrequencyMotorSpeed(float value);
                /*0x7ace680*/ float get_highFrequencyMotorSpeed();
                /*0x7ace688*/ void set_highFrequencyMotorSpeed(float value);
                /*0x7ace690*/ bool get_isRumbling();
                /*0x7ace748*/ void PauseHaptics(UnityEngine.InputSystem.InputDevice device);
                /*0x7ace8a4*/ void ResumeHaptics(UnityEngine.InputSystem.InputDevice device);
                /*0x7acea6c*/ void ResetHaptics(UnityEngine.InputSystem.InputDevice device);
                /*0x7ace92c*/ void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency);
            }

            interface IDualMotorRumble : UnityEngine.InputSystem.Haptics.IHaptics
            {
                void SetMotorSpeeds(float lowFrequency, float highFrequency);
            }

            interface IHaptics
            {
                /*0x38159dc*/ void PauseHaptics();
                /*0x38159dc*/ void ResumeHaptics();
                /*0x38159dc*/ void ResetHaptics();
            }
        }

        namespace LowLevel
        {
            struct DisableDeviceCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7aceaf8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7aceb58*/ UnityEngine.InputSystem.LowLevel.DisableDeviceCommand Create();
                /*0x7aceb28*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct EnableDeviceCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7aceb94*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acebf4*/ UnityEngine.InputSystem.LowLevel.EnableDeviceCommand Create();
                /*0x7acebc4*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct EnableIMECompositionCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 12;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ byte m_ImeEnabled;

                static /*0x7acec28*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acec98*/ UnityEngine.InputSystem.LowLevel.EnableIMECompositionCommand Create(bool enabled);
                /*0x7acec58*/ bool get_imeEnabled();
                /*0x7acec68*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            interface IInputDeviceCommandInfo
            {
                UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct InitiateUserAccountPairingCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7acece8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7aced48*/ UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand Create();
                /*0x7aced18*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                enum Result
                {
                    SuccessfullyInitiated = 1,
                    ErrorNotSupported = -1,
                    ErrorAlreadyInProgress = -2,
                }
            }

            class InputDeviceCommandDelegate : System.MulticastDelegate
            {
                /*0x7aced7c*/ InputDeviceCommandDelegate(object object, nint method);
                /*0x7acee88*/ System.Nullable<long> Invoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command);
                /*0x7acee9c*/ System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command, System.AsyncCallback callback, object object);
                /*0x7aceec4*/ System.Nullable<long> EndInvoke(System.IAsyncResult result);
            }

            class InputDeviceExecuteCommandDelegate : System.MulticastDelegate
            {
                /*0x7aceef0*/ InputDeviceExecuteCommandDelegate(object object, nint method);
                /*0x7acefa0*/ long Invoke(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand command);
                /*0x7acefb4*/ System.IAsyncResult BeginInvoke(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand command, System.AsyncCallback callback, object object);
                /*0x7acf040*/ long EndInvoke(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand command, System.IAsyncResult result);
            }

            struct InputDeviceCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kBaseCommandSize = 8;
                static int BaseCommandSize = 8;
                static long GenericFailure = -1;
                static long GenericSuccess = 1;
                /*0x10*/ UnityEngine.InputSystem.Utilities.FourCC type;
                /*0x14*/ int sizeInBytes;

                static /*0x7acf080*/ Unity.Collections.NativeArray<byte> AllocateNative(UnityEngine.InputSystem.Utilities.FourCC type, int payloadSize);
                /*0x7aceb8c*/ InputDeviceCommand(UnityEngine.InputSystem.Utilities.FourCC type, int sizeInBytes);
                /*0x7acf06c*/ int get_payloadSizeInBytes();
                /*0x7acf078*/ void* get_payloadPtr();
                /*0x7acf130*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryCanRunInBackground : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 9;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ bool canRunInBackground;

                static /*0x7acf138*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf198*/ UnityEngine.InputSystem.LowLevel.QueryCanRunInBackground Create();
                /*0x7acf168*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryDimensionsCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.Vector2 outDimensions;

                static /*0x7acf1d4*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf234*/ UnityEngine.InputSystem.LowLevel.QueryDimensionsCommand Create();
                /*0x7acf204*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryEnabledStateCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 9;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ bool isEnabled;

                static /*0x7acf26c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf2cc*/ UnityEngine.InputSystem.LowLevel.QueryEnabledStateCommand Create();
                /*0x7acf29c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryKeyboardLayoutCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kMaxNameLength = 256;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand.<nameBuffer> nameBuffer;

                static /*0x7acf308*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf39c*/ UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand Create();
                /*0x7acf338*/ string ReadLayoutName();
                /*0x7acf348*/ void WriteLayoutName(string name);
                /*0x7acf36c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                struct <nameBuffer>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct QueryKeyNameCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kMaxNameLength = 256;
                static int kSize = 268;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ int scanOrKeyCode;
                /*0x1c*/ UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand.<nameBuffer> nameBuffer;

                static /*0x7acf3f4*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf464*/ UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key);
                /*0x7acf424*/ string ReadKeyName();
                /*0x7acf434*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                struct <nameBuffer>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct QueryPairedUserAccountCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kMaxNameLength = 256;
                static int kMaxIdLength = 256;
                static int kSize = 1040;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ ulong handle;
                /*0x20*/ UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<nameBuffer> nameBuffer;
                /*0x220*/ UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<idBuffer> idBuffer;

                static /*0x7acf4c4*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf764*/ UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand Create();
                /*0x7acf4f4*/ string get_id();
                /*0x7acf504*/ void set_id(string value);
                /*0x7acf614*/ string get_name();
                /*0x7acf624*/ void set_name(string value);
                /*0x7acf734*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                enum Result
                {
                    DevicePairedToUserAccount = 2,
                    UserAccountSelectionInProgress = 4,
                    UserAccountSelectionComplete = 8,
                    UserAccountSelectionCanceled = 16,
                }

                struct <idBuffer>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }

                struct <nameBuffer>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct QuerySamplingFrequencyCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 12;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ float frequency;

                static /*0x7acf7bc*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf81c*/ UnityEngine.InputSystem.LowLevel.QuerySamplingFrequencyCommand Create();
                /*0x7acf7ec*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryUserIdCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kMaxIdLength = 256;
                static int kSize = 520;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.QueryUserIdCommand.<idBuffer> idBuffer;

                static /*0x7acf854*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf8c4*/ UnityEngine.InputSystem.LowLevel.QueryUserIdCommand Create();
                /*0x7acf884*/ string ReadId();
                /*0x7acf894*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                struct <idBuffer>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct RequestResetCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7acf91c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acf97c*/ UnityEngine.InputSystem.LowLevel.RequestResetCommand Create();
                /*0x7acf94c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct RequestSyncCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7acf9b0*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acfa10*/ UnityEngine.InputSystem.LowLevel.RequestSyncCommand Create();
                /*0x7acf9e0*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct SetIMECursorPositionCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.Vector2 m_Position;

                static /*0x7acfa44*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acfaac*/ UnityEngine.InputSystem.LowLevel.SetIMECursorPositionCommand Create(UnityEngine.Vector2 cursorPosition);
                /*0x7acfa74*/ UnityEngine.Vector2 get_position();
                /*0x7acfa7c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct SetSamplingFrequencyCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 12;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ float frequency;

                static /*0x7acfafc*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acfb5c*/ UnityEngine.InputSystem.LowLevel.SetSamplingFrequencyCommand Create(float frequency);
                /*0x7acfb2c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct WarpMousePositionCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.Vector2 warpPositionInPlayerDisplaySpace;

                static /*0x7acfba8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7acfc08*/ UnityEngine.InputSystem.LowLevel.WarpMousePositionCommand Create(UnityEngine.Vector2 position);
                /*0x7acfbd8*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct GamepadState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                static string ButtonSouthShortDisplayName = "A";
                static string ButtonNorthShortDisplayName = "Y";
                static string ButtonWestShortDisplayName = "X";
                static string ButtonEastShortDisplayName = "B";
                /*0x10*/ uint buttons;
                /*0x14*/ UnityEngine.Vector2 leftStick;
                /*0x1c*/ UnityEngine.Vector2 rightStick;
                /*0x24*/ float leftTrigger;
                /*0x28*/ float rightTrigger;

                static /*0x7acfc58*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7acfcb8*/ GamepadState(UnityEngine.InputSystem.LowLevel.GamepadButton[] buttons);
                /*0x7acfc88*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                /*0x7acfd68*/ UnityEngine.InputSystem.LowLevel.GamepadState WithButton(UnityEngine.InputSystem.LowLevel.GamepadButton button, bool value);
            }

            enum GamepadButton
            {
                DpadUp = 0,
                DpadDown = 1,
                DpadLeft = 2,
                DpadRight = 3,
                North = 4,
                East = 5,
                South = 6,
                West = 7,
                LeftStick = 8,
                RightStick = 9,
                LeftShoulder = 10,
                RightShoulder = 11,
                Start = 12,
                Select = 13,
                LeftTrigger = 32,
                RightTrigger = 33,
                X = 7,
                Y = 4,
                A = 6,
                B = 5,
                Cross = 6,
                Square = 7,
                Triangle = 4,
                Circle = 5,
            }

            struct DualMotorRumbleCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ float lowFrequencyMotorSpeed;
                /*0x1c*/ float highFrequencyMotorSpeed;

                static /*0x7acfd9c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ace854*/ UnityEngine.InputSystem.LowLevel.DualMotorRumbleCommand Create(float lowFrequency, float highFrequency);
                /*0x7acfdcc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            interface ICustomDeviceReset
            {
                /*0x38159dc*/ void Reset();
            }

            interface IEventMerger
            {
                bool MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
            }

            interface IEventPreProcessor
            {
                /*0x38140b8*/ bool PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr);
            }

            interface IInputUpdateCallbackReceiver
            {
                /*0x38159dc*/ void OnUpdate();
            }

            interface ITextInputReceiver
            {
                void OnTextInput(char character);
                void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString);
            }

            struct JoystickState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ int buttons;
                /*0x14*/ UnityEngine.Vector2 stick;

                static /*0x7acfdfc*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7acfe2c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

                enum Button
                {
                    HatSwitchUp = 0,
                    HatSwitchDown = 1,
                    HatSwitchLeft = 2,
                    HatSwitchRight = 3,
                    Trigger = 4,
                }
            }

            struct KeyboardState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                static int kSizeInBits = 110;
                static int kSizeInBytes = 14;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.KeyboardState.<keys> keys;

                static /*0x7acfe5c*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7acfe8c*/ KeyboardState(UnityEngine.InputSystem.Key[] pressedKeys);
                /*0x7acff50*/ void Set(UnityEngine.InputSystem.Key key, bool state);
                /*0x7acff5c*/ void Press(UnityEngine.InputSystem.Key key);
                /*0x7acff68*/ void Release(UnityEngine.InputSystem.Key key);
                /*0x7acff74*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

                struct <keys>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct MouseState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector2 position;
                /*0x18*/ UnityEngine.Vector2 delta;
                /*0x20*/ UnityEngine.Vector2 scroll;
                /*0x28*/ ushort buttons;
                /*0x2a*/ ushort displayIndex;
                /*0x2c*/ ushort clickCount;

                static /*0x7acffa4*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7acffd4*/ UnityEngine.InputSystem.LowLevel.MouseState WithButton(UnityEngine.InputSystem.LowLevel.MouseButton button, bool state);
                /*0x7ad0008*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            enum MouseButton
            {
                Left = 0,
                Right = 1,
                Middle = 2,
                Forward = 3,
                Back = 4,
            }

            struct PenState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector2 position;
                /*0x18*/ UnityEngine.Vector2 delta;
                /*0x20*/ UnityEngine.Vector2 tilt;
                /*0x28*/ float pressure;
                /*0x2c*/ float twist;
                /*0x30*/ ushort buttons;
                /*0x32*/ ushort displayIndex;

                static /*0x7ad0038*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ad0068*/ UnityEngine.InputSystem.LowLevel.PenState WithButton(UnityEngine.InputSystem.PenButton button, bool state);
                /*0x7ad009c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct PointerState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ uint pointerId;
                /*0x14*/ UnityEngine.Vector2 position;
                /*0x1c*/ UnityEngine.Vector2 delta;
                /*0x24*/ float pressure;
                /*0x28*/ UnityEngine.Vector2 radius;
                /*0x30*/ ushort buttons;
                /*0x32*/ ushort displayIndex;

                static /*0x7ad00cc*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ad00fc*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct AccelerometerState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 acceleration;

                static /*0x7ad012c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ad015c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct GyroscopeState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 angularVelocity;

                static /*0x7ad018c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ad01bc*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct GravityState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 gravity;

                static /*0x7ad01ec*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ad021c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct AttitudeState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Quaternion attitude;

                static /*0x7ad024c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ad027c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct LinearAccelerationState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 acceleration;

                static /*0x7ad02ac*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ad02dc*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            enum TouchFlags
            {
                IndirectTouch = 1,
                PrimaryTouch = 8,
                TapPress = 16,
                TapRelease = 32,
                OrphanedPrimaryTouch = 64,
                BeganInSameFrame = 128,
            }

            struct TouchState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                static int kSizeInBytes = 56;
                /*0x10*/ int touchId;
                /*0x14*/ UnityEngine.Vector2 position;
                /*0x1c*/ UnityEngine.Vector2 delta;
                /*0x24*/ float pressure;
                /*0x28*/ UnityEngine.Vector2 radius;
                /*0x30*/ byte phaseId;
                /*0x31*/ byte tapCount;
                /*0x32*/ byte displayIndex;
                /*0x33*/ byte flags;
                /*0x34*/ uint updateStepCount;
                /*0x38*/ double startTime;
                /*0x40*/ UnityEngine.Vector2 startPosition;

                static /*0x7ad030c*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ad033c*/ UnityEngine.InputSystem.TouchPhase get_phase();
                /*0x7acab94*/ void set_phase(UnityEngine.InputSystem.TouchPhase value);
                /*0x7ad0344*/ bool get_isNoneEndedOrCanceled();
                /*0x7ad0368*/ bool get_isInProgress();
                /*0x7ad0390*/ bool get_isPrimaryTouch();
                /*0x7ad039c*/ void set_isPrimaryTouch(bool value);
                /*0x7ad03bc*/ bool get_isOrphanedPrimaryTouch();
                /*0x7ad03c8*/ void set_isOrphanedPrimaryTouch(bool value);
                /*0x7ad03e8*/ bool get_isIndirectTouch();
                /*0x7ad03f4*/ void set_isIndirectTouch(bool value);
                /*0x7ac91c0*/ bool get_isTap();
                /*0x7ad0410*/ void set_isTap(bool value);
                /*0x7ad0404*/ bool get_isTapPress();
                /*0x7ad0430*/ void set_isTapPress(bool value);
                /*0x7ac836c*/ bool get_isTapRelease();
                /*0x7ad0450*/ void set_isTapRelease(bool value);
                /*0x7ac8604*/ bool get_beganInSameFrame();
                /*0x7ac8610*/ void set_beganInSameFrame(bool value);
                /*0x7ad0470*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                /*0x7ad04a0*/ string ToString();
            }

            struct TouchscreenState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                static int MaxTouches = 10;
                static int kTouchDataOffset = 56;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.TouchscreenState.<primaryTouchData> primaryTouchData;
                /*0x48*/ UnityEngine.InputSystem.LowLevel.TouchscreenState.<touchData> touchData;

                static /*0x7ad0780*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ad07b0*/ UnityEngine.InputSystem.LowLevel.TouchState* get_primaryTouch();
                /*0x7ad07b4*/ UnityEngine.InputSystem.LowLevel.TouchState* get_touches();
                /*0x7ad07bc*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

                struct <primaryTouchData>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }

                struct <touchData>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct ActionEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x24*/ ushort m_ControlIndex;
                /*0x26*/ ushort m_BindingIndex;
                /*0x28*/ ushort m_InteractionIndex;
                /*0x2a*/ byte m_StateIndex;
                /*0x2b*/ byte m_Phase;
                /*0x2c*/ double m_StartTime;
                /*0x34*/ UnityEngine.InputSystem.LowLevel.ActionEvent.<m_ValueData> m_ValueData;

                static /*0x7ad07ec*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ad0a48*/ int GetEventSizeWithValueSize(int valueSizeInBytes);
                static /*0x7ad0a50*/ UnityEngine.InputSystem.LowLevel.ActionEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                /*0x7ad081c*/ double get_startTime();
                /*0x7ad0824*/ void set_startTime(double value);
                /*0x7ad082c*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x7ad0834*/ void set_phase(UnityEngine.InputSystem.InputActionPhase value);
                /*0x7ad083c*/ byte* get_valueData();
                /*0x7ad0844*/ int get_valueSizeInBytes();
                /*0x7ad0858*/ int get_stateIndex();
                /*0x7ad0860*/ void set_stateIndex(int value);
                /*0x7ad08c0*/ int get_controlIndex();
                /*0x7ad08c8*/ void set_controlIndex(int value);
                /*0x7ad0928*/ int get_bindingIndex();
                /*0x7ad0930*/ void set_bindingIndex(int value);
                /*0x7ad0990*/ int get_interactionIndex();
                /*0x7ad09a4*/ void set_interactionIndex(int value);
                /*0x7ad0a14*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
                /*0x7ad0a18*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                struct <m_ValueData>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct DeltaStateEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1145852993;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x24*/ UnityEngine.InputSystem.Utilities.FourCC stateFormat;
                /*0x28*/ uint stateOffset;
                /*0x2c*/ UnityEngine.InputSystem.LowLevel.DeltaStateEvent.<stateData> stateData;

                static /*0x7ad0b98*/ UnityEngine.InputSystem.LowLevel.DeltaStateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ad0cbc*/ UnityEngine.InputSystem.LowLevel.DeltaStateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ad0cc0*/ Unity.Collections.NativeArray<byte> From(UnityEngine.InputSystem.InputControl control, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator);
                /*0x7ad0b74*/ uint get_deltaStateSizeInBytes();
                /*0x7ad0b80*/ void* get_deltaState();
                /*0x7ad0b88*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x7ad0b94*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();

                struct <stateData>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct DeviceConfigurationEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1145259591;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;

                static /*0x7ad113c*/ UnityEngine.InputSystem.LowLevel.DeviceConfigurationEvent Create(int deviceId, double time);
                /*0x7ad112c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x7ad1138*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
            }

            struct DeviceRemoveEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1146242381;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;

                static /*0x7ad11bc*/ UnityEngine.InputSystem.LowLevel.DeviceRemoveEvent Create(int deviceId, double time);
                /*0x7ad11ac*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x7ad11b8*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
            }

            struct DeviceResetEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1146245972;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x18*/ bool hardReset;

                static /*0x7ad1238*/ UnityEngine.InputSystem.LowLevel.DeviceResetEvent Create(int deviceId, bool hardReset, double time);
                /*0x7ad122c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            interface IInputEventTypeInfo
            {
                UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct IMECompositionEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int kIMECharBufferSize = 64;
                static int Type = 1229800787;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x24*/ UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString;

                static /*0x7ad12d8*/ UnityEngine.InputSystem.LowLevel.IMECompositionEvent Create(int deviceId, string compositionString, double time);
                /*0x7ad12cc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct IMECompositionString : System.Collections.Generic.IEnumerable<char>, System.Collections.IEnumerable
            {
                /*0x10*/ int size;
                /*0x14*/ UnityEngine.InputSystem.LowLevel.IMECompositionString.<buffer> buffer;

                /*0x7ad13c0*/ IMECompositionString(string characters);
                /*0x7ad1440*/ int get_Count();
                /*0x7ad1448*/ char get_Item(int index);
                /*0x7ad14b4*/ string ToString();
                /*0x7ad14cc*/ System.Collections.Generic.IEnumerator<char> GetEnumerator();
                /*0x7ad1584*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator : System.Collections.Generic.IEnumerator<char>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.IMECompositionString m_CompositionString;
                    /*0x94*/ char m_CurrentCharacter;
                    /*0x98*/ int m_CurrentIndex;

                    /*0x7ad1560*/ Enumerator(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString);
                    /*0x7ad1588*/ bool MoveNext();
                    /*0x7ad15b8*/ void Reset();
                    /*0x7ad15c4*/ void Dispose();
                    /*0x7ad15c8*/ char get_Current();
                    /*0x7ad15d0*/ object System.Collections.IEnumerator.get_Current();
                }

                struct <buffer>e__FixedBuffer
                {
                    /*0x10*/ char FixedElementField;
                }
            }

            struct InputEvent
            {
                static uint kHandledMask = 2147483648;
                static uint kIdMask = 2147483647;
                static int kBaseEventSize = 20;
                static int InvalidEventId = 0;
                static int kAlignment = 4;
                /*0x10*/ UnityEngineInternal.Input.NativeInputEvent m_Event;

                static /*0x7ad1a34*/ UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemory(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr);
                static /*0x7ad1a50*/ UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemoryChecked(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer);
                static /*0x7ad1bbc*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputEvent* first, UnityEngine.InputSystem.LowLevel.InputEvent* second);
                /*0x7ad1028*/ InputEvent(UnityEngine.InputSystem.Utilities.FourCC type, int sizeInBytes, int deviceId, double time);
                /*0x7ad15f8*/ UnityEngine.InputSystem.Utilities.FourCC get_type();
                /*0x7ad1600*/ void set_type(UnityEngine.InputSystem.Utilities.FourCC value);
                /*0x7ad0850*/ uint get_sizeInBytes();
                /*0x7ad1608*/ void set_sizeInBytes(uint value);
                /*0x7ad16ac*/ int get_eventId();
                /*0x7ad16b8*/ void set_eventId(int value);
                /*0x7ad16cc*/ int get_deviceId();
                /*0x7ad16d4*/ void set_deviceId(int value);
                /*0x7ad16dc*/ double get_time();
                /*0x7ad1730*/ void set_time(double value);
                /*0x7ad1790*/ double get_internalTime();
                /*0x7ad1798*/ void set_internalTime(double value);
                /*0x7ad17a0*/ bool get_handled();
                /*0x7ad17ac*/ void set_handled(bool value);
                /*0x7ad17c8*/ string ToString();
            }

            struct InputEventBuffer : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerable, System.IDisposable, System.ICloneable
            {
                static long BufferSizeUnknown = -1;
                /*0x10*/ Unity.Collections.NativeArray<byte> m_Buffer;
                /*0x20*/ long m_SizeInBytes;
                /*0x28*/ int m_EventCount;
                /*0x2c*/ bool m_WeOwnTheBuffer;

                /*0x7ad1cc4*/ InputEventBuffer(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, int eventCount, int sizeInBytes, int capacityInBytes);
                /*0x7ad1e74*/ InputEventBuffer(Unity.Collections.NativeArray<byte> buffer, int eventCount, int sizeInBytes, bool transferNativeArrayOwnership);
                /*0x7ad1c10*/ int get_eventCount();
                /*0x7ad1c18*/ long get_sizeInBytes();
                /*0x7ad1c20*/ long get_capacityInBytes();
                /*0x7ad1c6c*/ Unity.Collections.NativeArray<byte> get_data();
                /*0x7ad1c78*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_bufferPtr();
                /*0x7ad1f94*/ void AppendEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, int capacityIncrementInBytes, Unity.Collections.Allocator allocator);
                /*0x7ad2010*/ UnityEngine.InputSystem.LowLevel.InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes, Unity.Collections.Allocator allocator);
                /*0x7ad1b34*/ bool Contains(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                /*0x7ad22e4*/ void Reset();
                /*0x7ad22fc*/ void AdvanceToNextEvent(ref UnityEngine.InputSystem.LowLevel.InputEvent* currentReadPos, ref UnityEngine.InputSystem.LowLevel.InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer);
                /*0x7ad23b4*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator();
                /*0x7ad2460*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7ad2464*/ void Dispose();
                /*0x7ad24c4*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer Clone();
                /*0x7ad259c*/ object System.ICloneable.Clone();

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_Buffer;
                    /*0x18*/ int m_EventCount;
                    /*0x20*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentEvent;
                    /*0x28*/ int m_CurrentIndex;

                    /*0x7ad2428*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer);
                    /*0x7ad2608*/ bool MoveNext();
                    /*0x7ad2670*/ void Reset();
                    /*0x7ad267c*/ void Dispose();
                    /*0x7ad2680*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current();
                    /*0x7ad2688*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            struct InputEventListener : System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr>
            {
                static /*0x0*/ UnityEngine.InputSystem.LowLevel.InputEventListener.ObserverState s_ObserverState;

                static /*0x7acc558*/ UnityEngine.InputSystem.LowLevel.InputEventListener op_Addition(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> callback);
                static /*0x7acc834*/ UnityEngine.InputSystem.LowLevel.InputEventListener op_Subtraction(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> callback);
                /*0x7ad26e4*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer);

                class ObserverState
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers;
                    /*0x28*/ System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate;

                    /*0x7ad2858*/ ObserverState();
                    /*0x7ad28f0*/ void <.ctor>b__2_0(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                }

                class DisposableObserver : System.IDisposable
                {
                    /*0x10*/ System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer;

                    /*0x7ad28e8*/ DisposableObserver();
                    /*0x7ad29e4*/ void Dispose();
                }
            }

            struct InputEventPtr : System.IEquatable<UnityEngine.InputSystem.LowLevel.InputEventPtr>
            {
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_EventPtr;

                static /*0x7ad32c4*/ bool op_Equality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right);
                static /*0x7ad32d0*/ bool op_Inequality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right);
                static /*0x7ad1cc0*/ UnityEngine.InputSystem.LowLevel.InputEventPtr op_Implicit(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                static /*0x7ad32dc*/ UnityEngine.InputSystem.LowLevel.InputEventPtr From(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                static /*0x7ad2604*/ UnityEngine.InputSystem.LowLevel.InputEvent* op_Implicit(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x7ad32e0*/ UnityEngine.InputSystem.LowLevel.InputEvent* FromInputEventPtr(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7ad2b1c*/ InputEventPtr(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                /*0x7ac8344*/ bool get_valid();
                /*0x7ad2b24*/ bool get_handled();
                /*0x7acbf6c*/ void set_handled(bool value);
                /*0x7ad2b40*/ int get_id();
                /*0x7ad2b5c*/ void set_id(int value);
                /*0x7ac8354*/ UnityEngine.InputSystem.Utilities.FourCC get_type();
                /*0x7ad2bc8*/ uint get_sizeInBytes();
                /*0x7ad2be0*/ int get_deviceId();
                /*0x7ad2bf8*/ void set_deviceId(int value);
                /*0x7acc9b0*/ double get_time();
                /*0x7ad2c58*/ void set_time(double value);
                /*0x7ad2d04*/ double get_internalTime();
                /*0x7ad2d1c*/ void set_internalTime(double value);
                /*0x7ad2d7c*/ UnityEngine.InputSystem.LowLevel.InputEvent* get_data();
                /*0x7ad2d84*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                /*0x7ad2ecc*/ uint get_stateSizeInBytes();
                /*0x7ad3110*/ uint get_stateOffset();
                /*0x3813ffc*/ bool IsA<TOtherEvent>();
                /*0x7ad31e8*/ UnityEngine.InputSystem.LowLevel.InputEventPtr Next();
                /*0x7ad2e34*/ string ToString();
                /*0x7ad3214*/ UnityEngine.InputSystem.LowLevel.InputEvent* ToPointer();
                /*0x7ad321c*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputEventPtr other);
                /*0x7ad3234*/ bool Equals(object obj);
                /*0x7ad32bc*/ int GetHashCode();
            }

            struct InputEventStream
            {
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer m_NativeBuffer;
                /*0x30*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventReadPtr;
                /*0x38*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventWritePtr;
                /*0x40*/ int m_RemainingNativeEventCount;
                /*0x44*/ int m_MaxAppendedEvents;
                /*0x48*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer m_AppendBuffer;
                /*0x68*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventReadPtr;
                /*0x70*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventWritePtr;
                /*0x78*/ int m_RemainingAppendEventCount;
                /*0x7c*/ int m_NumEventsRetainedInBuffer;
                /*0x80*/ bool m_IsOpen;

                /*0x7ad338c*/ InputEventStream(ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, int maxAppendedEvents);
                /*0x7ad32e4*/ bool get_isOpen();
                /*0x7ad32ec*/ int get_remainingEventCount();
                /*0x7ad32fc*/ int get_numEventsRetainedInBuffer();
                /*0x7ad3304*/ UnityEngine.InputSystem.LowLevel.InputEvent* get_currentEventPtr();
                /*0x7ad3338*/ uint get_numBytesRetainedInBuffer();
                /*0x7ad3418*/ void Close(ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer);
                /*0x7ad3534*/ void CleanUpAfterException();
                /*0x7ad359c*/ void Write(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                /*0x7ad3720*/ UnityEngine.InputSystem.LowLevel.InputEvent* Advance(bool leaveEventInBuffer);
                /*0x7ad37c4*/ UnityEngine.InputSystem.LowLevel.InputEvent* Peek();
            }

            class InputEventTrace : System.IDisposable, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerable
            {
                static int kDefaultBufferSize = 1048576;
                static /*0x0*/ Unity.Profiling.ProfilerMarker k_InputEvenTraceMarker;
                static /*0x8*/ int kFileVersion;
                /*0x10*/ int m_ChangeCounter;
                /*0x14*/ bool m_Enabled;
                /*0x18*/ System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> m_OnFilterEvent;
                /*0x20*/ int m_DeviceId;
                /*0x28*/ UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_EventListeners;
                /*0x78*/ long m_EventBufferSize;
                /*0x80*/ long m_MaxEventBufferSize;
                /*0x88*/ long m_GrowIncrementSize;
                /*0x90*/ long m_EventCount;
                /*0x98*/ long m_EventSizeInBytes;
                /*0xa0*/ ulong m_EventBufferStorage;
                /*0xa8*/ ulong m_EventBufferHeadStorage;
                /*0xb0*/ ulong m_EventBufferTailStorage;
                /*0xb8*/ bool m_HasWrapped;
                /*0xb9*/ bool m_RecordFrameMarkers;
                /*0xc0*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo[] m_DeviceInfos;

                static /*0x7ad5e78*/ InputEventTrace();
                static /*0x7ad3824*/ UnityEngine.InputSystem.Utilities.FourCC get_FrameMarkerEvent();
                static /*0x7ad4e18*/ UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(string filePath);
                static /*0x7ad5018*/ UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(System.IO.Stream stream);
                static /*0x7ad447c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFileFormat();
                /*0x7ad3a9c*/ InputEventTrace(UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes, bool growBuffer, long maxBufferSizeInBytes, long growIncrementSizeInBytes);
                /*0x7ad3b70*/ InputEventTrace(long bufferSizeInBytes, bool growBuffer, long maxBufferSizeInBytes, long growIncrementSizeInBytes);
                /*0x7ad3854*/ int get_deviceId();
                /*0x7ad385c*/ void set_deviceId(int value);
                /*0x7ad3864*/ bool get_enabled();
                /*0x7ad386c*/ bool get_recordFrameMarkers();
                /*0x7ad3874*/ void set_recordFrameMarkers(bool value);
                /*0x7ad395c*/ long get_eventCount();
                /*0x7ad3964*/ long get_totalEventSizeInBytes();
                /*0x7ad396c*/ long get_allocatedSizeInBytes();
                /*0x7ad398c*/ long get_maxSizeInBytes();
                /*0x7ad3994*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos();
                /*0x7ad39dc*/ System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> get_onFilterEvent();
                /*0x7ad39e4*/ void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> value);
                /*0x7ad39ec*/ void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                /*0x7ad3a44*/ void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                /*0x7ad3be0*/ void WriteTo(string filePath);
                /*0x7ad3dac*/ void WriteTo(System.IO.Stream stream);
                /*0x7ad4504*/ void ReadFrom(string filePath);
                /*0x7ad46d0*/ void ReadFrom(System.IO.Stream stream);
                /*0x7ad5130*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Replay();
                /*0x7ad5320*/ bool Resize(long newBufferSize, long newMaxBufferSize);
                /*0x7ad5598*/ void Clear();
                /*0x7ad55b8*/ void Enable();
                /*0x7ad5190*/ void Disable();
                /*0x7ad5520*/ bool GetNextEvent(ref UnityEngine.InputSystem.LowLevel.InputEventPtr current);
                /*0x7ad44ac*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator();
                /*0x7ad5774*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7ad5778*/ void Dispose();
                /*0x7ad3984*/ byte* get_m_EventBuffer();
                /*0x7ad4e00*/ void set_m_EventBuffer(byte* value);
                /*0x7ad5518*/ byte* get_m_EventBufferHead();
                /*0x7ad4e08*/ void set_m_EventBufferHead(byte* value);
                /*0x7ad5728*/ byte* get_m_EventBufferTail();
                /*0x7ad4e10*/ void set_m_EventBufferTail(byte* value);
                /*0x7ad5700*/ void Allocate();
                /*0x7ad5790*/ void Release();
                /*0x7ad57e8*/ void OnBeforeUpdate();
                /*0x7ad5960*/ void OnInputEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device);

                class Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEventTrace m_Trace;
                    /*0x18*/ int m_ChangeCounter;
                    /*0x20*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_Current;

                    /*0x7ad5730*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputEventTrace trace);
                    /*0x7ad5ef4*/ void Dispose();
                    /*0x7ad5f18*/ bool MoveNext();
                    /*0x7ad5fdc*/ void Reset();
                    /*0x7ad6000*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current();
                    /*0x7ad6008*/ object System.Collections.IEnumerator.get_Current();
                }

                enum FileFlags
                {
                    FixedUpdate = 1,
                }

                class ReplayController : System.IDisposable
                {
                    /*0x10*/ bool <finished>k__BackingField;
                    /*0x11*/ bool <paused>k__BackingField;
                    /*0x14*/ int <position>k__BackingField;
                    /*0x18*/ UnityEngine.InputSystem.LowLevel.InputEventTrace m_EventTrace;
                    /*0x20*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.Enumerator m_Enumerator;
                    /*0x28*/ UnityEngine.InputSystem.Utilities.InlinedArray<System.Collections.Generic.KeyValuePair<int, int>> m_DeviceIDMappings;
                    /*0x40*/ bool m_CreateNewDevices;
                    /*0x48*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputDevice> m_CreatedDevices;
                    /*0x60*/ System.Action m_OnFinished;
                    /*0x68*/ System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_OnEvent;
                    /*0x70*/ double m_StartTimeAsPerFirstEvent;
                    /*0x78*/ double m_StartTimeAsPerRuntime;
                    /*0x80*/ int m_AllEventsByTimeIndex;
                    /*0x88*/ System.Collections.Generic.List<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_AllEventsByTime;

                    /*0x7ad52a4*/ ReplayController(UnityEngine.InputSystem.LowLevel.InputEventTrace trace);
                    /*0x7ad6064*/ UnityEngine.InputSystem.LowLevel.InputEventTrace get_trace();
                    /*0x7ad606c*/ bool get_finished();
                    /*0x7ad6074*/ void set_finished(bool value);
                    /*0x7ad6080*/ bool get_paused();
                    /*0x7ad6088*/ void set_paused(bool value);
                    /*0x7ad6094*/ int get_position();
                    /*0x7ad609c*/ void set_position(int value);
                    /*0x7ad60a4*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices();
                    /*0x7ad6108*/ void Dispose();
                    /*0x7ad641c*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice);
                    /*0x7ad64a0*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId);
                    /*0x7ad661c*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithAllDevicesMappedToNewInstances();
                    /*0x7ad6628*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnFinished(System.Action action);
                    /*0x7ad6644*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action);
                    /*0x7ad6660*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayOneEvent();
                    /*0x7ad6c4c*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Rewind();
                    /*0x7ad6c88*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllFramesOneByOne();
                    /*0x7ad6d38*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEvents();
                    /*0x7ad6df0*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEventsAccordingToTimestamps();
                    /*0x7ad70a8*/ void OnBeginFrame();
                    /*0x7ad72e0*/ void Finished();
                    /*0x7ad6a20*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                    /*0x7ad66e4*/ bool MoveNext(bool skipFrameEvents, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                    /*0x7ad73b4*/ int ApplyDeviceMapping(int originalDeviceId);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController.<> <>9;
                        static /*0x8*/ System.Comparison<UnityEngine.InputSystem.LowLevel.InputEventPtr> <>9__38_0;

                        static /*0x7ad7754*/ <>c();
                        /*0x7ad77bc*/ <>c();
                        /*0x7ad77c4*/ int <PlayAllEventsAccordingToTimestamps>b__38_0(UnityEngine.InputSystem.LowLevel.InputEventPtr a, UnityEngine.InputSystem.LowLevel.InputEventPtr b);
                    }

                    class <>c__DisplayClass43_0
                    {
                        /*0x10*/ int originalDeviceId;

                        /*0x7ad774c*/ <>c__DisplayClass43_0();
                        /*0x7ad788c*/ bool <ApplyDeviceMapping>b__0(UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo x);
                    }
                }

                struct DeviceInfo
                {
                    /*0x10*/ int m_DeviceId;
                    /*0x18*/ string m_Layout;
                    /*0x20*/ UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;
                    /*0x24*/ int m_StateSizeInBytes;
                    /*0x28*/ string m_FullLayoutJson;

                    /*0x7ad78a0*/ int get_deviceId();
                    /*0x7ad78a8*/ void set_deviceId(int value);
                    /*0x7ad78b0*/ string get_layout();
                    /*0x7ad78b8*/ void set_layout(string value);
                    /*0x7ad78c0*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                    /*0x7ad78c8*/ void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value);
                    /*0x7ad78d0*/ int get_stateSizeInBytes();
                    /*0x7ad78d8*/ void set_stateSizeInBytes(int value);
                }
            }

            struct StateEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1398030676;
                static int kStateDataSizeToSubtract = 1;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x24*/ UnityEngine.InputSystem.Utilities.FourCC stateFormat;
                /*0x28*/ UnityEngine.InputSystem.LowLevel.StateEvent.<stateData> stateData;

                static /*0x3910ae8*/ TState GetState<TState>(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x382ad0c*/ int GetEventSizeWithPayload<TState>();
                static /*0x7ad2fe0*/ UnityEngine.InputSystem.LowLevel.StateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ad2e30*/ UnityEngine.InputSystem.LowLevel.StateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ad78f8*/ Unity.Collections.NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator);
                static /*0x7ad7c34*/ Unity.Collections.NativeArray<byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator);
                static /*0x7ad7900*/ Unity.Collections.NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator, bool useDefaultState);
                /*0x7ad3104*/ uint get_stateSizeInBytes();
                /*0x7ad78e0*/ void* get_state();
                /*0x7ad78e8*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
                /*0x7ad78ec*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x3910ae8*/ TState GetState<TState>();

                struct <stateData>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct TextEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1413830740;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x24*/ int character;

                static /*0x7ad7c48*/ UnityEngine.InputSystem.LowLevel.TextEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x7ad7d6c*/ UnityEngine.InputSystem.LowLevel.TextEvent Create(int deviceId, char character, double time);
                static /*0x7ad7de4*/ UnityEngine.InputSystem.LowLevel.TextEvent Create(int deviceId, int character, double time);
                /*0x7ad7c3c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            class InputUpdateDelegate : System.MulticastDelegate
            {
                /*0x7ad7e58*/ InputUpdateDelegate(object object, nint method);
                /*0x7ad7ef8*/ void Invoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer);
                /*0x7ad7f0c*/ System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, System.AsyncCallback callback, object object);
                /*0x7ad7fc8*/ void EndInvoke(ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, System.IAsyncResult result);
            }

            interface IInputRuntime
            {
                /*0x3814574*/ int AllocateDeviceId();
                /*0x3815ed0*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType type);
                /*0x3910ae8*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr);
                /*0x3910ae8*/ long DeviceCommand(int deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr);
                /*0x38148bc*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate();
                /*0x3816710*/ void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value);
                /*0x38148bc*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate();
                /*0x3816710*/ void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value);
                /*0x38148bc*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> get_onShouldRunUpdate();
                /*0x3816710*/ void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> value);
                /*0x38148bc*/ System.Action<int, string> get_onDeviceDiscovered();
                /*0x3816710*/ void set_onDeviceDiscovered(System.Action<int, string> value);
                /*0x38148bc*/ System.Action<bool> get_onPlayerFocusChanged();
                /*0x3816710*/ void set_onPlayerFocusChanged(System.Action<bool> value);
                /*0x3813ffc*/ bool get_isPlayerFocused();
                /*0x38148bc*/ System.Action get_onShutdown();
                /*0x3816710*/ void set_onShutdown(System.Action value);
                /*0x38151b8*/ float get_pollingFrequency();
                /*0x3816f24*/ void set_pollingFrequency(float value);
                /*0x3814438*/ double get_currentTime();
                /*0x3814438*/ double get_currentTimeForFixedUpdate();
                /*0x38151b8*/ float get_unscaledGameTime();
                /*0x3814438*/ double get_currentTimeOffsetToRealtimeSinceStartup();
                /*0x3813ffc*/ bool get_runInBackground();
                /*0x3815cc4*/ void set_runInBackground(bool value);
                UnityEngine.Vector2 get_screenSize();
                /*0x3814574*/ UnityEngine.ScreenOrientation get_screenOrientation();
                /*0x3813ffc*/ bool get_normalizeScrollWheelDelta();
                /*0x3815cc4*/ void set_normalizeScrollWheelDelta(bool value);
                /*0x38151b8*/ float get_scrollWheelDeltaPerTick();
                /*0x3813ffc*/ bool get_isInBatchMode();
            }

            class InputRuntime
            {
                static /*0x0*/ UnityEngine.InputSystem.LowLevel.IInputRuntime s_Instance;
                static /*0x8*/ double s_CurrentTimeOffsetToRealtimeSinceStartup;
            }

            class InputRuntimeExtensions
            {
                static /*0x3910ae8*/ long DeviceCommand<TCommand>(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, int deviceId, ref TCommand command);
            }

            struct InputMetrics
            {
                /*0x10*/ int <maxNumDevices>k__BackingField;
                /*0x14*/ int <currentNumDevices>k__BackingField;
                /*0x18*/ int <maxStateSizeInBytes>k__BackingField;
                /*0x1c*/ int <currentStateSizeInBytes>k__BackingField;
                /*0x20*/ int <currentControlCount>k__BackingField;
                /*0x24*/ int <currentLayoutCount>k__BackingField;
                /*0x28*/ int <totalEventBytes>k__BackingField;
                /*0x2c*/ int <totalEventCount>k__BackingField;
                /*0x30*/ int <totalUpdateCount>k__BackingField;
                /*0x38*/ double <totalEventProcessingTime>k__BackingField;
                /*0x40*/ double <totalEventLagTime>k__BackingField;

                /*0x7ad7fe4*/ int get_maxNumDevices();
                /*0x7ad7fec*/ void set_maxNumDevices(int value);
                /*0x7ad7ff4*/ int get_currentNumDevices();
                /*0x7ad7ffc*/ void set_currentNumDevices(int value);
                /*0x7ad8004*/ int get_maxStateSizeInBytes();
                /*0x7ad800c*/ void set_maxStateSizeInBytes(int value);
                /*0x7ad8014*/ int get_currentStateSizeInBytes();
                /*0x7ad801c*/ void set_currentStateSizeInBytes(int value);
                /*0x7ad8024*/ int get_currentControlCount();
                /*0x7ad802c*/ void set_currentControlCount(int value);
                /*0x7ad8034*/ int get_currentLayoutCount();
                /*0x7ad803c*/ void set_currentLayoutCount(int value);
                /*0x7ad8044*/ int get_totalEventBytes();
                /*0x7ad804c*/ void set_totalEventBytes(int value);
                /*0x7ad8054*/ int get_totalEventCount();
                /*0x7ad805c*/ void set_totalEventCount(int value);
                /*0x7ad8064*/ int get_totalUpdateCount();
                /*0x7ad806c*/ void set_totalUpdateCount(int value);
                /*0x7ad8074*/ double get_totalEventProcessingTime();
                /*0x7ad807c*/ void set_totalEventProcessingTime(double value);
                /*0x7ad8084*/ double get_totalEventLagTime();
                /*0x7ad808c*/ void set_totalEventLagTime(double value);
                /*0x7ad8094*/ float get_averageEventBytesPerFrame();
                /*0x7ad80ac*/ double get_averageProcessingTimePerEvent();
                /*0x7ad80c0*/ double get_averageLagTimePerEvent();
            }

            enum InputUpdateType
            {
                None = 0,
                Dynamic = 1,
                Fixed = 2,
                BeforeRender = 4,
                Editor = 8,
                Manual = 16,
                Default = 11,
            }

            class InputUpdate
            {
                static /*0x0*/ uint s_UpdateStepCount;
                static /*0x4*/ UnityEngine.InputSystem.LowLevel.InputUpdateType s_LatestUpdateType;
                static /*0x8*/ UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCount s_PlayerUpdateStepCount;

                static /*0x7ad80d4*/ void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type);
                static /*0x7ad815c*/ void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type);
                static /*0x7ad81e4*/ UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState Save();
                static /*0x7ad8250*/ void Restore(UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState state);
                static /*0x7ad82e4*/ UnityEngine.InputSystem.LowLevel.InputUpdateType GetUpdateTypeForPlayer(UnityEngine.InputSystem.LowLevel.InputUpdateType mask);
                static /*0x7ad8304*/ bool IsPlayerUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);

                struct UpdateStepCount
                {
                    /*0x10*/ bool m_WasUpdated;
                    /*0x14*/ uint <value>k__BackingField;

                    /*0x7ad8310*/ uint get_value();
                    /*0x7ad8318*/ void set_value(uint value);
                    /*0x7ad8320*/ void OnBeforeUpdate();
                    /*0x7ad8338*/ void OnUpdate();
                }

                struct SerializedState
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputUpdateType lastUpdateType;
                    /*0x14*/ UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCount playerUpdateStepCount;
                }
            }

            class NativeInputRuntime : UnityEngine.InputSystem.LowLevel.IInputRuntime
            {
                static /*0x0*/ UnityEngine.InputSystem.LowLevel.NativeInputRuntime instance;
                /*0x10*/ bool m_RunInBackground;
                /*0x18*/ System.Action m_ShutdownMethod;
                /*0x20*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate m_OnUpdate;
                /*0x28*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> m_OnBeforeUpdate;
                /*0x30*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> m_OnShouldRunUpdate;
                /*0x38*/ float m_PollingFrequency;
                /*0x3c*/ bool m_DidCallOnShutdown;
                /*0x40*/ System.Action<bool> m_FocusChangedMethod;

                static /*0x7ad9010*/ NativeInputRuntime();
                /*0x7ad9000*/ NativeInputRuntime();
                /*0x7ad8354*/ int AllocateDeviceId();
                /*0x7ad83a4*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
                /*0x7ad83fc*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr);
                /*0x7ad8468*/ long DeviceCommand(int deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr);
                /*0x7ad854c*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate();
                /*0x7ad8554*/ void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value);
                /*0x7ad8694*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate();
                /*0x7ad869c*/ void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value);
                /*0x7ad87d4*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> get_onShouldRunUpdate();
                /*0x7ad87dc*/ void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> value);
                /*0x7ad8914*/ System.Action<int, string> get_onDeviceDiscovered();
                /*0x7ad8964*/ void set_onDeviceDiscovered(System.Action<int, string> value);
                /*0x7ad89bc*/ System.Action get_onShutdown();
                /*0x7ad89c4*/ void set_onShutdown(System.Action value);
                /*0x7ad8ad4*/ System.Action<bool> get_onPlayerFocusChanged();
                /*0x7ad8adc*/ void set_onPlayerFocusChanged(System.Action<bool> value);
                /*0x7ad8bec*/ bool get_isPlayerFocused();
                /*0x7ad8c3c*/ float get_pollingFrequency();
                /*0x7ad8c44*/ void set_pollingFrequency(float value);
                /*0x7ad8cac*/ double get_currentTime();
                /*0x7ad8cfc*/ double get_currentTimeForFixedUpdate();
                /*0x7ad8d28*/ double get_currentTimeOffsetToRealtimeSinceStartup();
                /*0x7ad8d78*/ float get_unscaledGameTime();
                /*0x7ad8d80*/ bool get_runInBackground();
                /*0x7ad8df0*/ void set_runInBackground(bool value);
                /*0x7ad8dfc*/ void OnShutdown();
                /*0x7ad8e20*/ bool OnWantsToShutdown();
                /*0x7ad8e60*/ void OnFocusChanged(bool focus);
                /*0x7ad8e88*/ UnityEngine.Vector2 get_screenSize();
                /*0x7ad8eb0*/ UnityEngine.ScreenOrientation get_screenOrientation();
                /*0x7ad8eb8*/ bool get_normalizeScrollWheelDelta();
                /*0x7ad8f08*/ void set_normalizeScrollWheelDelta(bool value);
                /*0x7ad8f60*/ float get_scrollWheelDeltaPerTick();
                /*0x7ad8fb0*/ bool get_isInBatchMode();

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value;

                    /*0x7ad87cc*/ <>c__DisplayClass10_0();
                    /*0x7ad9080*/ void <set_onBeforeUpdate>b__0(UnityEngineInternal.Input.NativeInputUpdateType updateType);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> value;

                    /*0x7ad890c*/ <>c__DisplayClass13_0();
                    /*0x7ad90a4*/ bool <set_onShouldRunUpdate>b__0(UnityEngineInternal.Input.NativeInputUpdateType updateType);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value;

                    /*0x7ad868c*/ <>c__DisplayClass7_0();
                    /*0x7ad90c8*/ void <set_onUpdate>b__0(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* eventBufferPtr);
                }
            }

            interface IInputStateCallbackReceiver
            {
                /*0x38159dc*/ void OnNextUpdate();
                /*0x3815e90*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                bool GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, ref uint offset);
            }

            interface IInputStateChangeMonitor
            {
                void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
            }

            interface IInputStateTypeInfo
            {
                UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            class InputState
            {
                static /*0x7ad92b4*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_currentUpdateType();
                static /*0x7ad92fc*/ uint get_updateCount();
                static /*0x7ad9344*/ double get_currentTime();
                static /*0x7ad9414*/ void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7ad9480*/ void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7ad94ec*/ void Change(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
                static /*0x3910ae8*/ void Change<TState>(UnityEngine.InputSystem.InputControl control, TState state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x3910ae8*/ void Change<TState>(UnityEngine.InputSystem.InputControl control, ref TState state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x7ad9788*/ bool IsIntegerFormat(UnityEngine.InputSystem.Utilities.FourCC format);
                static /*0x7ad98f4*/ void AddChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex);
                static /*0x7ad9a58*/ UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor AddChangeMonitor(UnityEngine.InputSystem.InputControl control, System.Action<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, long> valueChangeCallback, int monitorIndex, System.Action<UnityEngine.InputSystem.InputControl, double, long, int> timerExpiredCallback);
                static /*0x7ad9b54*/ void RemoveChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex);
                static /*0x7ad9c48*/ void AddChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex);
                static /*0x7ad9d30*/ void RemoveChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex);

                class StateChangeMonitorDelegate : UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
                {
                    /*0x10*/ System.Action<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, long> valueChangeCallback;
                    /*0x18*/ System.Action<UnityEngine.InputSystem.InputControl, double, long, int> timerExpiredCallback;

                    /*0x7ad9b4c*/ StateChangeMonitorDelegate();
                    /*0x7ad9e00*/ void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                    /*0x7ad9e24*/ void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
                }
            }

            struct InputStateBlock
            {
                static uint InvalidOffset = 4294967295;
                static uint AutomaticOffset = 4294967294;
                static int kFormatInvalid = 0;
                static int kFormatBit = 1112101920;
                static int kFormatSBit = 1396853076;
                static int kFormatInt = 1229870112;
                static int kFormatUInt = 1430867540;
                static int kFormatShort = 1397248596;
                static int kFormatUShort = 1431521364;
                static int kFormatByte = 1113150533;
                static int kFormatSByte = 1396857172;
                static int kFormatLong = 1280198432;
                static int kFormatULong = 1431064135;
                static int kFormatFloat = 1179407392;
                static int kFormatDouble = 1145195552;
                static int kFormatVector2 = 1447379762;
                static int kFormatVector3 = 1447379763;
                static int kFormatQuaternion = 1364541780;
                static int kFormatPose = 1349481317;
                static /*0x0*/ UnityEngine.InputSystem.Utilities.FourCC FormatInvalid;
                static /*0x4*/ UnityEngine.InputSystem.Utilities.FourCC FormatBit;
                static /*0x8*/ UnityEngine.InputSystem.Utilities.FourCC FormatSBit;
                static /*0xc*/ UnityEngine.InputSystem.Utilities.FourCC FormatInt;
                static /*0x10*/ UnityEngine.InputSystem.Utilities.FourCC FormatUInt;
                static /*0x14*/ UnityEngine.InputSystem.Utilities.FourCC FormatShort;
                static /*0x18*/ UnityEngine.InputSystem.Utilities.FourCC FormatUShort;
                static /*0x1c*/ UnityEngine.InputSystem.Utilities.FourCC FormatByte;
                static /*0x20*/ UnityEngine.InputSystem.Utilities.FourCC FormatSByte;
                static /*0x24*/ UnityEngine.InputSystem.Utilities.FourCC FormatLong;
                static /*0x28*/ UnityEngine.InputSystem.Utilities.FourCC FormatULong;
                static /*0x2c*/ UnityEngine.InputSystem.Utilities.FourCC FormatFloat;
                static /*0x30*/ UnityEngine.InputSystem.Utilities.FourCC FormatDouble;
                static /*0x34*/ UnityEngine.InputSystem.Utilities.FourCC FormatVector2;
                static /*0x38*/ UnityEngine.InputSystem.Utilities.FourCC FormatVector3;
                static /*0x3c*/ UnityEngine.InputSystem.Utilities.FourCC FormatQuaternion;
                static /*0x40*/ UnityEngine.InputSystem.Utilities.FourCC FormatVector2Short;
                static /*0x44*/ UnityEngine.InputSystem.Utilities.FourCC FormatVector3Short;
                static /*0x48*/ UnityEngine.InputSystem.Utilities.FourCC FormatVector2Byte;
                static /*0x4c*/ UnityEngine.InputSystem.Utilities.FourCC FormatVector3Byte;
                static /*0x50*/ UnityEngine.InputSystem.Utilities.FourCC FormatPose;
                /*0x10*/ UnityEngine.InputSystem.Utilities.FourCC <format>k__BackingField;
                /*0x14*/ uint m_ByteOffset;
                /*0x18*/ uint <bitOffset>k__BackingField;
                /*0x1c*/ uint <sizeInBits>k__BackingField;

                static /*0x7adc86c*/ InputStateBlock();
                static /*0x7ad9e40*/ int GetSizeOfPrimitiveFormatInBits(UnityEngine.InputSystem.Utilities.FourCC type);
                static /*0x7ada128*/ UnityEngine.InputSystem.Utilities.FourCC GetPrimitiveFormatFromType(System.Type type);
                /*0x7ada5b0*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                /*0x7ada5b8*/ void set_format(UnityEngine.InputSystem.Utilities.FourCC value);
                /*0x7ada5c0*/ uint get_byteOffset();
                /*0x7ada5c8*/ void set_byteOffset(uint value);
                /*0x7ada5d0*/ uint get_bitOffset();
                /*0x7ada5d8*/ void set_bitOffset(uint value);
                /*0x7ada5e0*/ uint get_sizeInBits();
                /*0x7ada5e8*/ void set_sizeInBits(uint value);
                /*0x7ada5f0*/ uint get_alignedSizeInBytes();
                /*0x7ada64c*/ uint get_effectiveByteOffset();
                /*0x7ada6a4*/ uint get_effectiveBitOffset();
                /*0x7ada6fc*/ int ReadInt(void* statePtr);
                /*0x7ada9b4*/ void WriteInt(void* statePtr, int value);
                /*0x7adac74*/ float ReadFloat(void* statePtr);
                /*0x7adb05c*/ void WriteFloat(void* statePtr, float value);
                /*0x7adb56c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FloatToPrimitiveValue(float value);
                /*0x7adbacc*/ double ReadDouble(void* statePtr);
                /*0x7adbeb0*/ void WriteDouble(void* statePtr, double value);
                /*0x7adc3d8*/ void Write(void* statePtr, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x7adc76c*/ void CopyToFrom(void* toStatePtr, void* fromStatePtr);
            }

            struct InputStateBuffers
            {
                static /*0x0*/ void* s_DefaultStateBuffer;
                static /*0x8*/ void* s_NoiseMaskBuffer;
                static /*0x10*/ void* s_ResetMaskBuffer;
                static /*0x18*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers s_CurrentBuffers;
                /*0x10*/ uint sizePerBuffer;
                /*0x14*/ uint totalSize;
                /*0x18*/ void* defaultStateBuffer;
                /*0x20*/ void* noiseMaskBuffer;
                /*0x28*/ void* resetMaskBuffer;
                /*0x30*/ void* m_AllBuffers;
                /*0x38*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers m_PlayerStateBuffers;

                static /*0x7adcd54*/ void* GetFrontBufferForDevice(int deviceIndex);
                static /*0x7adcde0*/ void* GetBackBufferForDevice(int deviceIndex);
                static /*0x7adce74*/ void SwitchTo(UnityEngine.InputSystem.LowLevel.InputStateBuffers buffers, UnityEngine.InputSystem.LowLevel.InputUpdateType update);
                static /*0x7adcffc*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer);
                static /*0x7add2b0*/ void MigrateDoubleBuffer(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers oldBuffer);
                static /*0x7add468*/ void MigrateSingleBuffer(void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer);
                static /*0x7adcf90*/ uint ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount);
                static /*0x7add56c*/ uint NextDeviceOffset(uint currentOffset, UnityEngine.InputSystem.InputDevice device);
                /*0x7adcc7c*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
                /*0x7adced8*/ void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount);
                /*0x7add098*/ void FreeAll();
                /*0x7add158*/ void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers oldBuffers);

                struct DoubleBuffers
                {
                    /*0x10*/ void** deviceToBufferMapping;
                    /*0x18*/ int deviceCount;

                    /*0x7add654*/ bool get_valid();
                    /*0x7add05c*/ void SetFrontBuffer(int deviceIndex, void* ptr);
                    /*0x7add078*/ void SetBackBuffer(int deviceIndex, void* ptr);
                    /*0x7adcdbc*/ void* GetFrontBuffer(int deviceIndex);
                    /*0x7adce4c*/ void* GetBackBuffer(int deviceIndex);
                    /*0x7add664*/ void SwapBuffers(int deviceIndex);
                }
            }

            class InputStateHistory : System.IDisposable, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>, System.Collections.IEnumerable, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
            {
                static int kDefaultHistorySize = 128;
                /*0x10*/ System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> <onRecordAdded>k__BackingField;
                /*0x18*/ System.Func<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> <onShouldRecordStateChange>k__BackingField;
                /*0x20*/ UnityEngine.InputSystem.InputControl[] m_Controls;
                /*0x28*/ int m_ControlCount;
                /*0x30*/ Unity.Collections.NativeArray<byte> m_RecordBuffer;
                /*0x40*/ int m_StateSizeInBytes;
                /*0x44*/ int m_RecordCount;
                /*0x48*/ int m_HistoryDepth;
                /*0x4c*/ int m_ExtraMemoryPerRecord;
                /*0x50*/ int m_HeadIndex;
                /*0x54*/ uint m_CurrentVersion;
                /*0x58*/ System.Nullable<UnityEngine.InputSystem.LowLevel.InputUpdateType> m_UpdateMask;
                /*0x60*/ bool m_AddNewControls;

                /*0x7ade108*/ InputStateHistory(int maxStateSizeInBytes);
                /*0x7ade1b4*/ InputStateHistory(string path);
                /*0x7ade320*/ InputStateHistory(UnityEngine.InputSystem.InputControl control);
                /*0x7ade430*/ InputStateHistory(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls);
                /*0x7add698*/ int get_Count();
                /*0x7add6a0*/ uint get_version();
                /*0x7add6a8*/ int get_historyDepth();
                /*0x7add6b0*/ void set_historyDepth(int value);
                /*0x7add778*/ int get_extraMemoryPerRecord();
                /*0x7add780*/ void set_extraMemoryPerRecord(int value);
                /*0x7add848*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask();
                /*0x7add8dc*/ void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value);
                /*0x7add9a4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls();
                /*0x7adda0c*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Item(int index);
                /*0x7addc48*/ void set_Item(int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record value);
                /*0x7ade0e8*/ System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded();
                /*0x7ade0f0*/ void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value);
                /*0x7ade0f8*/ System.Func<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> get_onShouldRecordStateChange();
                /*0x7ade100*/ void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> value);
                /*0x7ade4c0*/ void Finalize();
                /*0x7ade5bc*/ void Clear();
                /*0x7ade5d0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record);
                /*0x7ade738*/ void StartRecording();
                /*0x7ade894*/ void StopRecording();
                /*0x7ade9ec*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7adeba0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, void* statePtr, double time);
                /*0x7adee60*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator();
                /*0x7adeef4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7ade554*/ void Dispose();
                /*0x7adeef8*/ void Destroy();
                /*0x7adef5c*/ void Allocate();
                /*0x7adf244*/ int RecordIndexToUserIndex(int index);
                /*0x7addb18*/ int UserIndexToRecordIndex(int index);
                /*0x7addb30*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecord(int index);
                /*0x7adf268*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecordUnchecked(int index);
                /*0x7ade630*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* AllocateRecord(ref int index);
                /*0x3910ae8*/ TValue ReadValue<TValue>(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data);
                /*0x7adf314*/ object ReadValueAsObject(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data);
                /*0x7adf40c*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                /*0x7adf4e4*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
                /*0x7adf1f4*/ int get_bytesPerRecord();

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputStateHistory m_History;
                    /*0x18*/ int m_Index;

                    /*0x7adeed4*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputStateHistory history);
                    /*0x7adf4e8*/ bool MoveNext();
                    /*0x7adf520*/ void Reset();
                    /*0x7adf52c*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Current();
                    /*0x7adf54c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7adf5b0*/ void Dispose();
                }

                struct RecordHeader
                {
                    static int kSizeWithControlIndex = 16;
                    static int kSizeWithoutControlIndex = 12;
                    /*0x10*/ double time;
                    /*0x18*/ uint version;
                    /*0x1c*/ int controlIndex;
                    /*0x1c*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithoutControlIndex> m_StateWithoutControlIndex;
                    /*0x20*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithControlIndex> m_StateWithControlIndex;

                    /*0x7adee58*/ byte* get_statePtrWithControlIndex();
                    /*0x7adee50*/ byte* get_statePtrWithoutControlIndex();

                    struct <m_StateWithControlIndex>e__FixedBuffer
                    {
                        /*0x10*/ byte FixedElementField;
                    }

                    struct <m_StateWithoutControlIndex>e__FixedBuffer
                    {
                        /*0x10*/ byte FixedElementField;
                    }
                }

                struct Record : System.IEquatable<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputStateHistory m_Owner;
                    /*0x18*/ int m_IndexPlusOne;
                    /*0x1c*/ uint m_Version;

                    /*0x7addc08*/ Record(UnityEngine.InputSystem.LowLevel.InputStateHistory owner, int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header);
                    /*0x7adf5b4*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header();
                    /*0x7adf5d8*/ int get_recordIndex();
                    /*0x7adf5e4*/ uint get_version();
                    /*0x7adf5ec*/ bool get_valid();
                    /*0x7adf634*/ UnityEngine.InputSystem.LowLevel.InputStateHistory get_owner();
                    /*0x7adf63c*/ int get_index();
                    /*0x7adf720*/ double get_time();
                    /*0x7adf748*/ UnityEngine.InputSystem.InputControl get_control();
                    /*0x7adf7fc*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_next();
                    /*0x7adf898*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_previous();
                    /*0x3910ae8*/ TValue ReadValue<TValue>();
                    /*0x7adf92c*/ object ReadValueAsObject();
                    /*0x7adf964*/ void* GetUnsafeMemoryPtr();
                    /*0x7adf97c*/ void* GetUnsafeMemoryPtrUnchecked();
                    /*0x7adf9fc*/ void* GetUnsafeExtraMemoryPtr();
                    /*0x7adfa14*/ void* GetUnsafeExtraMemoryPtrUnchecked();
                    /*0x7addd7c*/ void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record);
                    /*0x7adf678*/ void CheckValid();
                    /*0x7adfae0*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record other);
                    /*0x7adfb14*/ bool Equals(object obj);
                    /*0x7adfbac*/ int GetHashCode();
                    /*0x7adfbf4*/ string ToString();
                }
            }

            class InputStateHistory<TValue> : UnityEngine.InputSystem.LowLevel.InputStateHistory, System.Collections.Generic.IReadOnlyList<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>
            {
                /*0x3815ac4*/ InputStateHistory(System.Nullable<int> maxStateSizeInBytes);
                /*0x3816710*/ InputStateHistory(UnityEngine.InputSystem.InputControl<TValue> control);
                /*0x3816710*/ InputStateHistory(string path);
                /*0x38159dc*/ void Finalize();
                /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record);
                /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, double time);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Item(int index);
                /*0x3910ae8*/ void set_Item(int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> value);

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History;
                    /*0x0*/ int m_Index;

                    /*0x3816710*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history);
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                    /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void Dispose();
                }

                struct Record<TValue> : System.IEquatable<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>
                {
                    /*0x0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_Owner;
                    /*0x0*/ int m_IndexPlusOne;
                    /*0x0*/ uint m_Version;

                    /*0x3910ae8*/ Record(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header);
                    /*0x381678c*/ Record(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index);
                    /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header();
                    /*0x3814574*/ int get_recordIndex();
                    /*0x3813ffc*/ bool get_valid();
                    /*0x38148bc*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner();
                    /*0x3814574*/ int get_index();
                    /*0x3814438*/ double get_time();
                    /*0x38148bc*/ UnityEngine.InputSystem.InputControl<TValue> get_control();
                    /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_next();
                    /*0x3910ae8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_previous();
                    /*0x3910ae8*/ TValue ReadValue();
                    /*0x3910ae8*/ void* GetUnsafeMemoryPtr();
                    /*0x3910ae8*/ void* GetUnsafeMemoryPtrUnchecked();
                    /*0x3910ae8*/ void* GetUnsafeExtraMemoryPtr();
                    /*0x3910ae8*/ void* GetUnsafeExtraMemoryPtrUnchecked();
                    /*0x3910ae8*/ void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record);
                    /*0x38159dc*/ void CheckValid();
                    /*0x3910ae8*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> other);
                    /*0x38141c4*/ bool Equals(object obj);
                    /*0x3814574*/ int GetHashCode();
                    /*0x38148bc*/ string ToString();
                }
            }

            class SelectObservable<TSource, TResult> : System.IObservable<TResult>
            {
                /*0x0*/ System.IObservable<TSource> m_Source;
                /*0x0*/ System.Func<TSource, TResult> m_Filter;

                /*0x3816810*/ SelectObservable(System.IObservable<TSource> source, System.Func<TSource, TResult> filter);
                /*0x3814a3c*/ System.IDisposable Subscribe(System.IObserver<TResult> observer);

                class Select<TSource, TResult> : System.IObserver<TSource>
                {
                    /*0x0*/ UnityEngine.InputSystem.LowLevel.SelectObservable<TSource, TResult> m_Observable;
                    /*0x0*/ System.IObserver<TResult> m_Observer;

                    /*0x3816810*/ Select(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource, TResult> observable, System.IObserver<TResult> observer);
                    /*0x38159dc*/ void OnCompleted();
                    /*0x3816710*/ void OnError(System.Exception error);
                    /*0x3910ae8*/ void OnNext(TSource evt);
                }
            }
        }

        namespace Processors
        {
            class AxisDeadzoneProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7adfe9c*/ AxisDeadzoneProcessor();
                /*0x7adfcb8*/ float get_minOrDefault();
                /*0x7adfd28*/ float get_maxOrDefault();
                /*0x7adfd98*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7adfe00*/ string ToString();
            }

            class ClampProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7adff90*/ ClampProcessor();
                /*0x7adfee4*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7adfefc*/ string ToString();
            }

            class CompensateDirectionProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x7ae0210*/ CompensateDirectionProcessor();
                /*0x7adffd8*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae01c8*/ string ToString();
                /*0x7ae0208*/ UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy();
            }

            class CompensateRotationProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Quaternion>
            {
                /*0x7ae04b0*/ CompensateRotationProcessor();
                /*0x7ae0258*/ UnityEngine.Quaternion Process(UnityEngine.Quaternion value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0468*/ string ToString();
                /*0x7ae04a8*/ UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy();
            }

            class InvertProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x7ae0540*/ InvertProcessor();
                /*0x7ae04f8*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0500*/ string ToString();
            }

            class InvertVector2Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x10*/ bool invertX;
                /*0x11*/ bool invertY;

                /*0x7ae0640*/ InvertVector2Processor();
                /*0x7ae0588*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae05ac*/ string ToString();
            }

            class InvertVector3Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x10*/ bool invertX;
                /*0x11*/ bool invertY;
                /*0x12*/ bool invertZ;

                /*0x7ae077c*/ InvertVector3Processor();
                /*0x7ae0690*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae06c4*/ string ToString();
            }

            class NormalizeProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;
                /*0x18*/ float zero;

                static /*0x7ae07e0*/ float Normalize(float value, float min, float max, float zero);
                static /*0x7ae08b0*/ float Denormalize(float value, float min, float max, float zero);
                /*0x7ae09b0*/ NormalizeProcessor();
                /*0x7ae07d4*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae08f8*/ string ToString();
            }

            class NormalizeVector2Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x7ae0aec*/ NormalizeVector2Processor();
                /*0x7ae09f8*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0aac*/ string ToString();
            }

            class NormalizeVector3Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x7ae0c44*/ NormalizeVector3Processor();
                /*0x7ae0b34*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0c04*/ string ToString();
            }

            class ScaleProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float factor;

                /*0x7ae0d10*/ ScaleProcessor();
                /*0x7ae0c8c*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0c98*/ string ToString();
            }

            class ScaleVector2Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x10*/ float x;
                /*0x14*/ float y;

                /*0x7ae0e04*/ ScaleVector2Processor();
                /*0x7ae0d60*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0d70*/ string ToString();
            }

            class ScaleVector3Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float z;

                /*0x7ae0f24*/ ScaleVector3Processor();
                /*0x7ae0e54*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae0e6c*/ string ToString();
            }

            class StickDeadzoneProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7ae1230*/ StickDeadzoneProcessor();
                /*0x7ae0f7c*/ float get_minOrDefault();
                /*0x7ae0fec*/ float get_maxOrDefault();
                /*0x7ae105c*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ae112c*/ float GetDeadZoneAdjustedValue(float value);
                /*0x7ae1194*/ string ToString();
            }
        }

        namespace Layouts
        {
            class InputControlAttribute : UnityEngine.PropertyAttribute
            {
                /*0x18*/ string <layout>k__BackingField;
                /*0x20*/ string <variants>k__BackingField;
                /*0x28*/ string <name>k__BackingField;
                /*0x30*/ string <format>k__BackingField;
                /*0x38*/ string <usage>k__BackingField;
                /*0x40*/ string[] <usages>k__BackingField;
                /*0x48*/ string <parameters>k__BackingField;
                /*0x50*/ string <processors>k__BackingField;
                /*0x58*/ string <alias>k__BackingField;
                /*0x60*/ string[] <aliases>k__BackingField;
                /*0x68*/ string <useStateFrom>k__BackingField;
                /*0x70*/ uint <bit>k__BackingField;
                /*0x74*/ uint <offset>k__BackingField;
                /*0x78*/ uint <sizeInBits>k__BackingField;
                /*0x7c*/ int <arraySize>k__BackingField;
                /*0x80*/ string <displayName>k__BackingField;
                /*0x88*/ string <shortDisplayName>k__BackingField;
                /*0x90*/ bool <noisy>k__BackingField;
                /*0x91*/ bool <synthetic>k__BackingField;
                /*0x92*/ bool <dontReset>k__BackingField;
                /*0x98*/ object <defaultState>k__BackingField;
                /*0xa0*/ object <minValue>k__BackingField;
                /*0xa8*/ object <maxValue>k__BackingField;

                /*0x7ae13f4*/ InputControlAttribute();
                /*0x7ae1278*/ string get_layout();
                /*0x7ae1280*/ void set_layout(string value);
                /*0x7ae1288*/ string get_variants();
                /*0x7ae1290*/ void set_variants(string value);
                /*0x7ae1298*/ string get_name();
                /*0x7ae12a0*/ void set_name(string value);
                /*0x7ae12a8*/ string get_format();
                /*0x7ae12b0*/ void set_format(string value);
                /*0x7ae12b8*/ string get_usage();
                /*0x7ae12c0*/ void set_usage(string value);
                /*0x7ae12c8*/ string[] get_usages();
                /*0x7ae12d0*/ void set_usages(string[] value);
                /*0x7ae12d8*/ string get_parameters();
                /*0x7ae12e0*/ void set_parameters(string value);
                /*0x7ae12e8*/ string get_processors();
                /*0x7ae12f0*/ void set_processors(string value);
                /*0x7ae12f8*/ string get_alias();
                /*0x7ae1300*/ void set_alias(string value);
                /*0x7ae1308*/ string[] get_aliases();
                /*0x7ae1310*/ void set_aliases(string[] value);
                /*0x7ae1318*/ string get_useStateFrom();
                /*0x7ae1320*/ void set_useStateFrom(string value);
                /*0x7ae1328*/ uint get_bit();
                /*0x7ae1330*/ void set_bit(uint value);
                /*0x7ae1338*/ uint get_offset();
                /*0x7ae1340*/ void set_offset(uint value);
                /*0x7ae1348*/ uint get_sizeInBits();
                /*0x7ae1350*/ void set_sizeInBits(uint value);
                /*0x7ae1358*/ int get_arraySize();
                /*0x7ae1360*/ void set_arraySize(int value);
                /*0x7ae1368*/ string get_displayName();
                /*0x7ae1370*/ void set_displayName(string value);
                /*0x7ae1378*/ string get_shortDisplayName();
                /*0x7ae1380*/ void set_shortDisplayName(string value);
                /*0x7ae1388*/ bool get_noisy();
                /*0x7ae1390*/ void set_noisy(bool value);
                /*0x7ae139c*/ bool get_synthetic();
                /*0x7ae13a4*/ void set_synthetic(bool value);
                /*0x7ae13b0*/ bool get_dontReset();
                /*0x7ae13b8*/ void set_dontReset(bool value);
                /*0x7ae13c4*/ object get_defaultState();
                /*0x7ae13cc*/ void set_defaultState(object value);
                /*0x7ae13d4*/ object get_minValue();
                /*0x7ae13dc*/ void set_minValue(object value);
                /*0x7ae13e4*/ object get_maxValue();
                /*0x7ae13ec*/ void set_maxValue(object value);
            }

            class InputDeviceFindControlLayoutDelegate : System.MulticastDelegate
            {
                /*0x7ae1404*/ InputDeviceFindControlLayoutDelegate(object object, nint method);
                /*0x7ae14b8*/ string Invoke(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand);
                /*0x7ae14cc*/ System.IAsyncResult BeginInvoke(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand, System.AsyncCallback callback, object object);
                /*0x7ae1570*/ string EndInvoke(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, System.IAsyncResult result);
            }

            class InputControlLayout
            {
                static string VariantSeparator = ";";
                static /*0x0*/ UnityEngine.InputSystem.Utilities.InternedString s_DefaultVariant;
                static /*0x10*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Collection s_Layouts;
                static /*0x50*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Cache s_CacheInstance;
                static /*0x58*/ int s_CacheInstanceRef;
                /*0x10*/ UnityEngine.InputSystem.Utilities.InternedString m_Name;
                /*0x20*/ System.Type m_Type;
                /*0x28*/ UnityEngine.InputSystem.Utilities.InternedString m_Variants;
                /*0x38*/ UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;
                /*0x3c*/ int m_StateSizeInBytes;
                /*0x40*/ System.Nullable<bool> m_UpdateBeforeRender;
                /*0x48*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> m_BaseLayouts;
                /*0x68*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> m_AppliedOverrides;
                /*0x88*/ UnityEngine.InputSystem.Utilities.InternedString[] m_CommonUsages;
                /*0x90*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] m_Controls;
                /*0x98*/ string m_DisplayName;
                /*0xa0*/ string m_Description;
                /*0xa8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Flags m_Flags;

                static /*0x7ae6a08*/ InputControlLayout();
                static /*0x7ae158c*/ UnityEngine.InputSystem.Utilities.InternedString get_DefaultVariant();
                static /*0x7ae209c*/ UnityEngine.InputSystem.Layouts.InputControlLayout FromType(string name, System.Type type);
                static /*0x7ae2aa4*/ UnityEngine.InputSystem.Layouts.InputControlLayout FromJson(string json);
                static /*0x7ae2564*/ void AddControlItems(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName);
                static /*0x7ae3508*/ void AddControlItemsFromFields(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName);
                static /*0x7ae359c*/ void AddControlItemsFromProperties(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName);
                static /*0x7ae3630*/ void AddControlItemsFromMembers(System.Reflection.MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName);
                static /*0x7ae3b58*/ void AddControlItemsFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems);
                static /*0x7ae3de8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem CreateControlItemFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute attribute);
                static /*0x7ae4658*/ string InferLayoutFromValueType(System.Type type);
                static /*0x7ae5dc0*/ System.Collections.Generic.Dictionary<string, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] controlItems, System.Collections.Generic.List<string> variants);
                static /*0x7ae673c*/ bool VariantsMatch(UnityEngine.InputSystem.Utilities.InternedString expected, UnityEngine.InputSystem.Utilities.InternedString actual);
                static /*0x7ae6610*/ bool VariantsMatch(string expected, string actual);
                static /*0x7ae67a0*/ void ParseHeaderFieldsFromJson(string json, ref UnityEngine.InputSystem.Utilities.InternedString name, ref UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, ref UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher);
                static /*0x7ae694c*/ ref UnityEngine.InputSystem.Layouts.InputControlLayout.Cache get_cache();
                static /*0x7ae69a4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance CacheRef();
                /*0x7ae25e0*/ InputControlLayout(string name, System.Type type);
                /*0x7ae15e4*/ UnityEngine.InputSystem.Utilities.InternedString get_name();
                /*0x7ae15f0*/ string get_displayName();
                /*0x7ae1610*/ System.Type get_type();
                /*0x7ae1618*/ UnityEngine.InputSystem.Utilities.InternedString get_variants();
                /*0x7ae1624*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                /*0x7ae162c*/ int get_stateSizeInBytes();
                /*0x7ae1634*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts();
                /*0x7ae1694*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides();
                /*0x7ae16f4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages();
                /*0x7ae1754*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls();
                /*0x7ae17b4*/ bool get_updateBeforeRender();
                /*0x7ae17f0*/ bool get_isDeviceLayout();
                /*0x7ae1870*/ bool get_isControlLayout();
                /*0x7ae1888*/ bool get_isOverride();
                /*0x7ae1894*/ void set_isOverride(bool value);
                /*0x7ae18b4*/ bool get_isGenericTypeOfDevice();
                /*0x7ae18c0*/ void set_isGenericTypeOfDevice(bool value);
                /*0x7ae18d0*/ bool get_hideInUI();
                /*0x7ae18dc*/ void set_hideInUI(bool value);
                /*0x7ae18fc*/ bool get_isNoisy();
                /*0x7ae1908*/ void set_isNoisy(bool value);
                /*0x7ae1928*/ System.Nullable<bool> get_canRunInBackground();
                /*0x7ae1990*/ void set_canRunInBackground(System.Nullable<bool> value);
                /*0x7ae1a2c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem get_Item(string path);
                /*0x7ae1ba4*/ System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(UnityEngine.InputSystem.Utilities.InternedString path);
                /*0x7ae1d34*/ System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, ref int arrayIndex);
                /*0x7ae2020*/ System.Type GetValueType();
                /*0x7ae2648*/ string ToJson();
                /*0x7ae4b20*/ void MergeLayout(UnityEngine.InputSystem.Layouts.InputControlLayout other);
                /*0x7ae6a94*/ bool <MergeLayout>b__77_0(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem x);

                struct ControlItem
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.InternedString <name>k__BackingField;
                    /*0x20*/ UnityEngine.InputSystem.Utilities.InternedString <layout>k__BackingField;
                    /*0x30*/ UnityEngine.InputSystem.Utilities.InternedString <variants>k__BackingField;
                    /*0x40*/ string <useStateFrom>k__BackingField;
                    /*0x48*/ string <displayName>k__BackingField;
                    /*0x50*/ string <shortDisplayName>k__BackingField;
                    /*0x58*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> <usages>k__BackingField;
                    /*0x68*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> <aliases>k__BackingField;
                    /*0x78*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField;
                    /*0x88*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> <processors>k__BackingField;
                    /*0x98*/ uint <offset>k__BackingField;
                    /*0x9c*/ uint <bit>k__BackingField;
                    /*0xa0*/ uint <sizeInBits>k__BackingField;
                    /*0xa4*/ UnityEngine.InputSystem.Utilities.FourCC <format>k__BackingField;
                    /*0xa8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags <flags>k__BackingField;
                    /*0xac*/ int <arraySize>k__BackingField;
                    /*0xb0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue <defaultState>k__BackingField;
                    /*0xc0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue <minValue>k__BackingField;
                    /*0xd0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue <maxValue>k__BackingField;

                    /*0x7ae6b08*/ UnityEngine.InputSystem.Utilities.InternedString get_name();
                    /*0x7ae6b14*/ void set_name(UnityEngine.InputSystem.Utilities.InternedString value);
                    /*0x7ae6b20*/ UnityEngine.InputSystem.Utilities.InternedString get_layout();
                    /*0x7ae6b2c*/ void set_layout(UnityEngine.InputSystem.Utilities.InternedString value);
                    /*0x7ae6b3c*/ UnityEngine.InputSystem.Utilities.InternedString get_variants();
                    /*0x7ae6b48*/ void set_variants(UnityEngine.InputSystem.Utilities.InternedString value);
                    /*0x7ae6b58*/ string get_useStateFrom();
                    /*0x7ae6b60*/ void set_useStateFrom(string value);
                    /*0x7ae6b68*/ string get_displayName();
                    /*0x7ae6b70*/ void set_displayName(string value);
                    /*0x7ae6b78*/ string get_shortDisplayName();
                    /*0x7ae6b80*/ void set_shortDisplayName(string value);
                    /*0x7ae6b88*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages();
                    /*0x7ae6b94*/ void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value);
                    /*0x7ae6ba4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases();
                    /*0x7ae6bb0*/ void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value);
                    /*0x7ae6bc0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters();
                    /*0x7ae6bcc*/ void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value);
                    /*0x7ae6bdc*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors();
                    /*0x7ae6be8*/ void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value);
                    /*0x7ae6bf8*/ uint get_offset();
                    /*0x7ae6c00*/ void set_offset(uint value);
                    /*0x7ae6c08*/ uint get_bit();
                    /*0x7ae6c10*/ void set_bit(uint value);
                    /*0x7ae6c18*/ uint get_sizeInBits();
                    /*0x7ae6c20*/ void set_sizeInBits(uint value);
                    /*0x7ae6c28*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                    /*0x7ae6c30*/ void set_format(UnityEngine.InputSystem.Utilities.FourCC value);
                    /*0x7ae6c38*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags get_flags();
                    /*0x7ae6c40*/ void set_flags(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags value);
                    /*0x7ae6c48*/ int get_arraySize();
                    /*0x7ae6c50*/ void set_arraySize(int value);
                    /*0x7ae6c58*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_defaultState();
                    /*0x7ae6c64*/ void set_defaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                    /*0x7ae6c6c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_minValue();
                    /*0x7ae6c78*/ void set_minValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                    /*0x7ae6c80*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_maxValue();
                    /*0x7ae6c8c*/ void set_maxValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                    /*0x7ae6c94*/ bool get_isModifyingExistingControl();
                    /*0x7ae4810*/ void set_isModifyingExistingControl(bool value);
                    /*0x7ae6ca0*/ bool get_isNoisy();
                    /*0x7ae4840*/ void set_isNoisy(bool value);
                    /*0x7ae6cac*/ bool get_isSynthetic();
                    /*0x7ae4880*/ void set_isSynthetic(bool value);
                    /*0x7ae6cb8*/ bool get_dontReset();
                    /*0x7ae4860*/ void set_dontReset(bool value);
                    /*0x7ae6cc4*/ bool get_isFirstDefinedInThisLayout();
                    /*0x7ae4820*/ void set_isFirstDefinedInThisLayout(bool value);
                    /*0x7ae2010*/ bool get_isArray();
                    /*0x7ae61d4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem Merge(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem other);

                    enum Flags
                    {
                        isModifyingExistingControl = 1,
                        IsNoisy = 2,
                        IsSynthetic = 4,
                        IsFirstDefinedInThisLayout = 8,
                        DontReset = 16,
                    }
                }

                class Builder
                {
                    /*0x10*/ string <name>k__BackingField;
                    /*0x18*/ string <displayName>k__BackingField;
                    /*0x20*/ System.Type <type>k__BackingField;
                    /*0x28*/ UnityEngine.InputSystem.Utilities.FourCC <stateFormat>k__BackingField;
                    /*0x2c*/ int <stateSizeInBytes>k__BackingField;
                    /*0x30*/ string m_ExtendsLayout;
                    /*0x38*/ System.Nullable<bool> <updateBeforeRender>k__BackingField;
                    /*0x3c*/ int m_ControlCount;
                    /*0x40*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] m_Controls;

                    /*0x7ae7224*/ Builder();
                    /*0x7ae6cd0*/ string get_name();
                    /*0x7ae6cd8*/ void set_name(string value);
                    /*0x7ae6ce0*/ string get_displayName();
                    /*0x7ae6ce8*/ void set_displayName(string value);
                    /*0x7ae6cf0*/ System.Type get_type();
                    /*0x7ae6cf8*/ void set_type(System.Type value);
                    /*0x7ae6d00*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                    /*0x7ae6d08*/ void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value);
                    /*0x7ae6d10*/ int get_stateSizeInBytes();
                    /*0x7ae6d18*/ void set_stateSizeInBytes(int value);
                    /*0x7ae6d20*/ string get_extendsLayout();
                    /*0x7ae6d28*/ void set_extendsLayout(string value);
                    /*0x7ae6d70*/ System.Nullable<bool> get_updateBeforeRender();
                    /*0x7ae6d78*/ void set_updateBeforeRender(System.Nullable<bool> value);
                    /*0x7ae6d80*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls();
                    /*0x7ae6de8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AddControl(string name);
                    /*0x7ae6f60*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithName(string name);
                    /*0x7ae6f7c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithDisplayName(string displayName);
                    /*0x38148bc*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithType<T>();
                    /*0x7ae6f98*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format);
                    /*0x7ae6fa0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(string format);
                    /*0x7ae6fd4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithSizeInBytes(int sizeInBytes);
                    /*0x7ae6fdc*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder Extend(string baseLayoutName);
                    /*0x7ae6ff4*/ UnityEngine.InputSystem.Layouts.InputControlLayout Build();

                    struct ControlBuilder
                    {
                        /*0x10*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder builder;
                        /*0x18*/ int index;

                        /*0x7ae722c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDisplayName(string displayName);
                        /*0x7ae7278*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithLayout(string layout);
                        /*0x7ae7368*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format);
                        /*0x7ae73b0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(string format);
                        /*0x7ae73e4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithByteOffset(uint offset);
                        /*0x7ae742c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithBitOffset(uint bit);
                        /*0x7ae7474*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsSynthetic(bool value);
                        /*0x7ae74d4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsNoisy(bool value);
                        /*0x7ae7534*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder DontReset(bool value);
                        /*0x7ae7594*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithSizeInBits(uint sizeInBits);
                        /*0x7ae75dc*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithRange(float minValue, float maxValue);
                        /*0x7ae7678*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(UnityEngine.InputSystem.Utilities.InternedString[] usages);
                        /*0x7ae7850*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<string> usages);
                        /*0x7ae797c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(string[] usages);
                        /*0x7ae7980*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithParameters(string parameters);
                        /*0x7ae7a40*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithProcessors(string processors);
                        /*0x7ae7b1c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                        /*0x7ae7b64*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder UsingStateFrom(string path);
                        /*0x7ae7bd0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AsArrayOfControlsWithSize(int arraySize);

                        class <>c
                        {
                            static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder.<> <>9;
                            static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0;

                            static /*0x7ae7c18*/ <>c();
                            /*0x7ae7c80*/ <>c();
                            /*0x7ae7c88*/ UnityEngine.InputSystem.Utilities.InternedString <WithUsages>b__14_0(string x);
                        }
                    }
                }

                enum Flags
                {
                    IsGenericTypeOfDevice = 1,
                    HideInUI = 2,
                    IsOverride = 4,
                    CanRunInBackground = 8,
                    CanRunInBackgroundIsSet = 16,
                    IsNoisy = 32,
                }

                struct LayoutJsonNameAndDescriptorOnly
                {
                    /*0x10*/ string name;
                    /*0x18*/ string extend;
                    /*0x20*/ string[] extendMultiple;
                    /*0x28*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson device;
                }

                struct LayoutJson
                {
                    /*0x10*/ string name;
                    /*0x18*/ string extend;
                    /*0x20*/ string[] extendMultiple;
                    /*0x28*/ string format;
                    /*0x30*/ string beforeRender;
                    /*0x38*/ string runInBackground;
                    /*0x40*/ string[] commonUsages;
                    /*0x48*/ string displayName;
                    /*0x50*/ string description;
                    /*0x58*/ string type;
                    /*0x60*/ string variant;
                    /*0x68*/ bool isGenericTypeOfDevice;
                    /*0x69*/ bool hideInUI;
                    /*0x70*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] controls;

                    static /*0x7ae26c4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson FromLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout);
                    /*0x7ae2b34*/ UnityEngine.InputSystem.Layouts.InputControlLayout ToLayout();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson.<> <>9;
                        static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0;
                        static /*0x10*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__15_0;
                        static /*0x18*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__15_1;

                        static /*0x7ae8b08*/ <>c();
                        /*0x7ae8b70*/ <>c();
                        /*0x7ae8b78*/ UnityEngine.InputSystem.Utilities.InternedString <ToLayout>b__14_0(string x);
                        /*0x7ae8ba0*/ string <FromLayout>b__15_0(UnityEngine.InputSystem.Utilities.InternedString x);
                        /*0x7ae8bc4*/ string <FromLayout>b__15_1(UnityEngine.InputSystem.Utilities.InternedString x);
                    }
                }

                class ControlItemJson
                {
                    /*0x10*/ string name;
                    /*0x18*/ string layout;
                    /*0x20*/ string variants;
                    /*0x28*/ string usage;
                    /*0x30*/ string alias;
                    /*0x38*/ string useStateFrom;
                    /*0x40*/ uint offset;
                    /*0x44*/ uint bit;
                    /*0x48*/ uint sizeInBits;
                    /*0x50*/ string format;
                    /*0x58*/ int arraySize;
                    /*0x60*/ string[] usages;
                    /*0x68*/ string[] aliases;
                    /*0x70*/ string parameters;
                    /*0x78*/ string processors;
                    /*0x80*/ string displayName;
                    /*0x88*/ string shortDisplayName;
                    /*0x90*/ bool noisy;
                    /*0x91*/ bool dontReset;
                    /*0x92*/ bool synthetic;
                    /*0x98*/ string defaultState;
                    /*0xa0*/ string minValue;
                    /*0xa8*/ string maxValue;

                    static /*0x7ae8378*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] FromControlItems(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] items);
                    /*0x7ae8be8*/ ControlItemJson();
                    /*0x7ae7cb0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem ToLayout();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson.<> <>9;
                        static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__24_0;
                        static /*0x10*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__24_1;
                        static /*0x18*/ System.Func<UnityEngine.InputSystem.Utilities.NamedValue, string> <>9__25_0;
                        static /*0x20*/ System.Func<UnityEngine.InputSystem.Utilities.NameAndParameters, string> <>9__25_1;
                        static /*0x28*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__25_2;
                        static /*0x30*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__25_3;

                        static /*0x7ae8c08*/ <>c();
                        /*0x7ae8c70*/ <>c();
                        /*0x7ae8c78*/ UnityEngine.InputSystem.Utilities.InternedString <ToLayout>b__24_0(string x);
                        /*0x7ae8ca0*/ UnityEngine.InputSystem.Utilities.InternedString <ToLayout>b__24_1(string x);
                        /*0x7ae8cc8*/ string <FromControlItems>b__25_0(UnityEngine.InputSystem.Utilities.NamedValue x);
                        /*0x7ae8cd4*/ string <FromControlItems>b__25_1(UnityEngine.InputSystem.Utilities.NameAndParameters x);
                        /*0x7ae8ce0*/ string <FromControlItems>b__25_2(UnityEngine.InputSystem.Utilities.InternedString x);
                        /*0x7ae8d04*/ string <FromControlItems>b__25_3(UnityEngine.InputSystem.Utilities.InternedString x);
                    }
                }

                struct Collection
                {
                    static float kBaseScoreForNonGeneratedLayouts = 1;
                    /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, System.Type> layoutTypes;
                    /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, string> layoutStrings;
                    /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>> layoutBuilders;
                    /*0x28*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Utilities.InternedString> baseLayoutTable;
                    /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Utilities.InternedString[]> layoutOverrides;
                    /*0x38*/ System.Collections.Generic.HashSet<UnityEngine.InputSystem.Utilities.InternedString> layoutOverrideNames;
                    /*0x40*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.PrecompiledLayout> precompiledLayouts;
                    /*0x48*/ System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.LayoutMatcher> layoutMatchers;

                    /*0x7ae8d28*/ void Allocate();
                    /*0x7ae48a0*/ UnityEngine.InputSystem.Utilities.InternedString TryFindLayoutForType(System.Type layoutType);
                    /*0x7ae8fd0*/ UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                    /*0x7ae4a44*/ bool HasLayout(UnityEngine.InputSystem.Utilities.InternedString name);
                    /*0x7ae91a0*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayoutInternal(UnityEngine.InputSystem.Utilities.InternedString name);
                    /*0x7ae9394*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayout(UnityEngine.InputSystem.Utilities.InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout> table);
                    /*0x7ae9808*/ UnityEngine.InputSystem.Utilities.InternedString GetBaseLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName);
                    /*0x7ae9894*/ UnityEngine.InputSystem.Utilities.InternedString GetRootLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName);
                    /*0x7ae9928*/ bool ComputeDistanceInInheritanceHierarchy(UnityEngine.InputSystem.Utilities.InternedString firstLayout, UnityEngine.InputSystem.Utilities.InternedString secondLayout, ref int distance);
                    /*0x7ae9a60*/ UnityEngine.InputSystem.Utilities.InternedString FindLayoutThatIntroducesControl(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache);
                    /*0x7ae9c80*/ System.Type GetControlTypeForLayout(UnityEngine.InputSystem.Utilities.InternedString layoutName);
                    /*0x7ae9dc0*/ bool ValueTypeIsAssignableFrom(UnityEngine.InputSystem.Utilities.InternedString layoutName, System.Type valueType);
                    /*0x7ae9ed0*/ bool IsGeneratedLayout(UnityEngine.InputSystem.Utilities.InternedString layout);
                    /*0x7ae9f38*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(UnityEngine.InputSystem.Utilities.InternedString layout, bool includeSelf);
                    /*0x7aea02c*/ bool IsBasedOn(UnityEngine.InputSystem.Utilities.InternedString parentLayout, UnityEngine.InputSystem.Utilities.InternedString childLayout);
                    /*0x7aea0d8*/ void AddMatcher(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);

                    struct LayoutMatcher
                    {
                        /*0x10*/ UnityEngine.InputSystem.Utilities.InternedString layoutName;
                        /*0x20*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher;
                    }

                    struct PrecompiledLayout
                    {
                        /*0x10*/ System.Func<UnityEngine.InputSystem.InputDevice> factoryMethod;
                        /*0x18*/ string metadata;
                    }

                    class <GetBaseLayouts>d__24 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ UnityEngine.InputSystem.Utilities.InternedString <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x2c*/ bool includeSelf;
                        /*0x2d*/ bool <>3__includeSelf;
                        /*0x30*/ UnityEngine.InputSystem.Utilities.InternedString layout;
                        /*0x40*/ UnityEngine.InputSystem.Utilities.InternedString <>3__layout;
                        /*0x50*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Collection <>4__this;
                        /*0x90*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Collection <>3__<>4__this;

                        /*0x7ae9ff8*/ <GetBaseLayouts>d__24(int <>1__state);
                        /*0x7aea2bc*/ void System.IDisposable.Dispose();
                        /*0x7aea2c0*/ bool MoveNext();
                        /*0x7aea398*/ UnityEngine.InputSystem.Utilities.InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current();
                        /*0x7aea3a4*/ void System.Collections.IEnumerator.Reset();
                        /*0x7aea3dc*/ object System.Collections.IEnumerator.get_Current();
                        /*0x7aea438*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator();
                        /*0x7aea514*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class LayoutNotFoundException : System.Exception
                {
                    /*0x90*/ string <layout>k__BackingField;

                    /*0x7aea520*/ LayoutNotFoundException();
                    /*0x7aea578*/ LayoutNotFoundException(string name, string message);
                    /*0x7ae9744*/ LayoutNotFoundException(string name);
                    /*0x7aea5f4*/ LayoutNotFoundException(string message, System.Exception innerException);
                    /*0x7aea664*/ LayoutNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x7aea518*/ string get_layout();
                }

                struct Cache
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout> table;

                    /*0x7aea6e4*/ void Clear();
                    /*0x7ae9b5c*/ UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound);
                }

                struct CacheRefInstance : System.IDisposable
                {
                    /*0x10*/ bool valid;

                    /*0x7aea6f0*/ void Dispose();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.<> <>9;
                    static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__52_0;
                    static /*0x10*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__75_0;
                    static /*0x18*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__75_1;

                    static /*0x7aea788*/ <>c();
                    /*0x7aea7f0*/ <>c();
                    /*0x7aea7f8*/ UnityEngine.InputSystem.Utilities.InternedString <FromType>b__52_0(string x);
                    /*0x7aea820*/ UnityEngine.InputSystem.Utilities.InternedString <CreateControlItemFromMember>b__75_0(string x);
                    /*0x7aea848*/ UnityEngine.InputSystem.Utilities.InternedString <CreateControlItemFromMember>b__75_1(string x);
                }
            }

            class InputControlLayoutAttribute : System.Attribute
            {
                /*0x10*/ System.Type <stateType>k__BackingField;
                /*0x18*/ string <stateFormat>k__BackingField;
                /*0x20*/ string[] <commonUsages>k__BackingField;
                /*0x28*/ string <variants>k__BackingField;
                /*0x30*/ bool <isNoisy>k__BackingField;
                /*0x31*/ System.Nullable<bool> canRunInBackgroundInternal;
                /*0x33*/ System.Nullable<bool> updateBeforeRenderInternal;
                /*0x35*/ bool <isGenericTypeOfDevice>k__BackingField;
                /*0x38*/ string <displayName>k__BackingField;
                /*0x40*/ string <description>k__BackingField;
                /*0x48*/ bool <hideInUI>k__BackingField;

                /*0x7aeaa6c*/ InputControlLayoutAttribute();
                /*0x7aea870*/ System.Type get_stateType();
                /*0x7aea878*/ void set_stateType(System.Type value);
                /*0x7aea880*/ string get_stateFormat();
                /*0x7aea888*/ void set_stateFormat(string value);
                /*0x7aea890*/ string[] get_commonUsages();
                /*0x7aea898*/ void set_commonUsages(string[] value);
                /*0x7aea8a0*/ string get_variants();
                /*0x7aea8a8*/ void set_variants(string value);
                /*0x7aea8b0*/ bool get_isNoisy();
                /*0x7aea8b8*/ void set_isNoisy(bool value);
                /*0x7aea8c4*/ bool get_canRunInBackground();
                /*0x7aea90c*/ void set_canRunInBackground(bool value);
                /*0x7aea974*/ bool get_updateBeforeRender();
                /*0x7aea9bc*/ void set_updateBeforeRender(bool value);
                /*0x7aeaa24*/ bool get_isGenericTypeOfDevice();
                /*0x7aeaa2c*/ void set_isGenericTypeOfDevice(bool value);
                /*0x7aeaa38*/ string get_displayName();
                /*0x7aeaa40*/ void set_displayName(string value);
                /*0x7aeaa48*/ string get_description();
                /*0x7aeaa50*/ void set_description(string value);
                /*0x7aeaa58*/ bool get_hideInUI();
                /*0x7aeaa60*/ void set_hideInUI(bool value);
            }

            struct InputDeviceBuilder : System.IDisposable
            {
                static uint kSizeForControlUsingStateFromOtherControl = 4294967295;
                static /*0x0*/ UnityEngine.InputSystem.Layouts.InputDeviceBuilder s_Instance;
                static /*0x28*/ int s_InstanceRef;
                /*0x10*/ UnityEngine.InputSystem.InputDevice m_Device;
                /*0x18*/ UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance m_LayoutCacheRef;
                /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> m_ChildControlOverrides;
                /*0x28*/ System.Collections.Generic.List<uint> m_StateOffsetToControlMap;
                /*0x30*/ System.Text.StringBuilder m_StringBuilder;

                static /*0x7aec8ac*/ void ApplyUseStateFrom(UnityEngine.InputSystem.InputControl parent, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, UnityEngine.InputSystem.Layouts.InputControlLayout layout);
                static /*0x7aedaf0*/ void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, int startIndex, UnityEngine.InputSystem.InputControl exceptControl);
                static /*0x7aedd88*/ void AddParentDisplayNameRecursive(UnityEngine.InputSystem.InputControl control, System.Text.StringBuilder stringBuilder, bool shortName);
                static /*0x7aed5a4*/ void AddProcessors(UnityEngine.InputSystem.InputControl control, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, string layoutName);
                static /*0x7aed4f4*/ void SetFormat(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                static /*0x7aeb190*/ UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(string name);
                static /*0x7aebf68*/ void ComputeStateLayout(UnityEngine.InputSystem.InputControl control);
                static /*0x7aeed7c*/ ref UnityEngine.InputSystem.Layouts.InputDeviceBuilder get_instance();
                static /*0x7aeedc0*/ UnityEngine.InputSystem.Layouts.InputDeviceBuilder.RefInstance Ref();
                /*0x7aeaa74*/ void Setup(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                /*0x7aeaebc*/ UnityEngine.InputSystem.InputDevice Finish();
                /*0x7aeb188*/ void Dispose();
                /*0x7aeb108*/ void Reset();
                /*0x7aeabe0*/ UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent);
                /*0x7aeb1ec*/ UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent);
                /*0x7aeb880*/ void AddChildControls(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls);
                /*0x7aecc44*/ UnityEngine.InputSystem.InputControl AddChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride);
                /*0x7aeca78*/ void InsertChildControlOverride(UnityEngine.InputSystem.InputControl parent, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                /*0x7aed464*/ string ChildControlOverridePath(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Utilities.InternedString controlName);
                /*0x7aed3b4*/ void AddChildControlIfMissing(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                /*0x7aed7d0*/ UnityEngine.InputSystem.InputControl InsertChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variant, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                /*0x7aedb50*/ void SetDisplayName(UnityEngine.InputSystem.InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName);
                /*0x7aeac4c*/ void FinalizeControlHierarchy();
                /*0x7aede38*/ void FinalizeControlHierarchyRecursive(UnityEngine.InputSystem.InputControl control, int controlIndex, UnityEngine.InputSystem.InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex);
                /*0x7aee248*/ void InsertControlBitRangeNode(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset);
                /*0x7aee598*/ ushort GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset);
                /*0x7aeeb8c*/ void AddControlToNode(UnityEngine.InputSystem.InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex);
                /*0x7aeea7c*/ void AddChildren(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right);
                /*0x7aeeccc*/ ushort GetControlIndex(UnityEngine.InputSystem.InputControl control);

                struct RefInstance : System.IDisposable
                {
                    /*0x7a14d40*/ void Dispose();
                }
            }

            struct InputDeviceDescription : System.IEquatable<UnityEngine.InputSystem.Layouts.InputDeviceDescription>
            {
                /*0x10*/ string m_InterfaceName;
                /*0x18*/ string m_DeviceClass;
                /*0x20*/ string m_Manufacturer;
                /*0x28*/ string m_Product;
                /*0x30*/ string m_Serial;
                /*0x38*/ string m_Version;
                /*0x40*/ string m_Capabilities;

                static /*0x7a153e4*/ bool op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right);
                static /*0x7a1541c*/ bool op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right);
                static /*0x7a15570*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription FromJson(string json);
                static /*0x7a156fc*/ bool ComparePropertyToDeviceDescriptor(string propertyName, UnityEngine.InputSystem.Utilities.JsonParser.JsonString propertyValue, string deviceDescriptor);
                /*0x7a14dcc*/ string get_interfaceName();
                /*0x7a14dd4*/ void set_interfaceName(string value);
                /*0x7a14ddc*/ string get_deviceClass();
                /*0x7a14de4*/ void set_deviceClass(string value);
                /*0x7a14dec*/ string get_manufacturer();
                /*0x7a14df4*/ void set_manufacturer(string value);
                /*0x7a14dfc*/ string get_product();
                /*0x7a14e04*/ void set_product(string value);
                /*0x7a14e0c*/ string get_serial();
                /*0x7a14e14*/ void set_serial(string value);
                /*0x7a14e1c*/ string get_version();
                /*0x7a14e24*/ void set_version(string value);
                /*0x7a14e2c*/ string get_capabilities();
                /*0x7a14e34*/ void set_capabilities(string value);
                /*0x7a14e3c*/ bool get_empty();
                /*0x7a14ec0*/ string ToString();
                /*0x7a1516c*/ bool Equals(UnityEngine.InputSystem.Layouts.InputDeviceDescription other);
                /*0x7a1521c*/ bool Equals(object obj);
                /*0x7a152b4*/ int GetHashCode();
                /*0x7a15458*/ string ToJson();

                struct DeviceDescriptionJson
                {
                    /*0x10*/ string interface;
                    /*0x18*/ string type;
                    /*0x20*/ string product;
                    /*0x28*/ string serial;
                    /*0x30*/ string version;
                    /*0x38*/ string manufacturer;
                    /*0x40*/ string capabilities;
                }
            }

            struct InputDeviceMatcher : System.IEquatable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>
            {
                static /*0x0*/ UnityEngine.InputSystem.Utilities.InternedString kInterfaceKey;
                static /*0x10*/ UnityEngine.InputSystem.Utilities.InternedString kDeviceClassKey;
                static /*0x20*/ UnityEngine.InputSystem.Utilities.InternedString kManufacturerKey;
                static /*0x30*/ UnityEngine.InputSystem.Utilities.InternedString kManufacturerContainsKey;
                static /*0x40*/ UnityEngine.InputSystem.Utilities.InternedString kProductKey;
                static /*0x50*/ UnityEngine.InputSystem.Utilities.InternedString kVersionKey;
                /*0x10*/ System.Collections.Generic.KeyValuePair<UnityEngine.InputSystem.Utilities.InternedString, object> m_Patterns;

                static /*0x7a16f8c*/ InputDeviceMatcher();
                static /*0x7a167a0*/ bool MatchSingleProperty(object pattern, string value);
                static /*0x7a1686c*/ bool MatchSinglePropertyContains(object pattern, string value);
                static /*0x7a168e0*/ int GetNumPropertiesIn(UnityEngine.InputSystem.Layouts.InputDeviceDescription description);
                static /*0x7a169a4*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher FromDeviceDescription(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                static /*0x7a16e98*/ bool op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right);
                static /*0x7a16f04*/ bool op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right);
                /*0x7a15e58*/ bool get_empty();
                /*0x7a15e68*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> get_patterns();
                /*0x7a15f1c*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithInterface(string pattern, bool supportRegex);
                /*0x7a1619c*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex);
                /*0x7a16214*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex);
                /*0x7a1628c*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturerContains(string noRegExPattern);
                /*0x7a16300*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithProduct(string pattern, bool supportRegex);
                /*0x7a16378*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithVersion(string pattern, bool supportRegex);
                /*0x3910ae8*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithCapability<TValue>(string path, TValue value);
                /*0x7a15f94*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher With(UnityEngine.InputSystem.Utilities.InternedString key, object value, bool supportRegex);
                /*0x7a163f0*/ float MatchPercentage(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                /*0x7a16b24*/ string ToString();
                /*0x7a16ccc*/ bool Equals(UnityEngine.InputSystem.Layouts.InputDeviceMatcher other);
                /*0x7a16e08*/ bool Equals(object obj);
                /*0x7a16f74*/ int GetHashCode();

                struct MatcherJson
                {
                    /*0x10*/ string interface;
                    /*0x18*/ string[] interfaces;
                    /*0x20*/ string deviceClass;
                    /*0x28*/ string[] deviceClasses;
                    /*0x30*/ string manufacturer;
                    /*0x38*/ string manufacturerContains;
                    /*0x40*/ string[] manufacturers;
                    /*0x48*/ string product;
                    /*0x50*/ string[] products;
                    /*0x58*/ string version;
                    /*0x60*/ string[] versions;
                    /*0x68*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson.Capability[] capabilities;

                    static /*0x7a17254*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson FromMatcher(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
                    /*0x7a175c8*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher ToMatcher();

                    struct Capability
                    {
                        /*0x10*/ string path;
                        /*0x18*/ string value;
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher.<> <>9;
                    static /*0x8*/ System.Func<char, bool> <>9__12_0;

                    static /*0x7a17a60*/ <>c();
                    /*0x7a17ac8*/ <>c();
                    /*0x7a17ad0*/ bool <With>b__12_0(char ch);
                }

                class <get_patterns>d__4 : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, object> <>2__current;
                    /*0x28*/ int <>l__initialThreadId;
                    /*0x30*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher <>4__this;
                    /*0x38*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher <>3__<>4__this;
                    /*0x40*/ int <count>5__2;
                    /*0x44*/ int <i>5__3;

                    /*0x7a15ee8*/ <get_patterns>d__4(int <>1__state);
                    /*0x7a17b38*/ void System.IDisposable.Dispose();
                    /*0x7a17b3c*/ bool MoveNext();
                    /*0x7a17c6c*/ System.Collections.Generic.KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current();
                    /*0x7a17c78*/ void System.Collections.IEnumerator.Reset();
                    /*0x7a17cb0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a17d0c*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
                    /*0x7a17db4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }
        }

        namespace Controls
        {
            class AnyKeyControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x7a17db8*/ AnyKeyControl();
                /*0x7a17eb8*/ float ReadUnprocessedValueFromState(void* statePtr);
            }

            class AxisControl : UnityEngine.InputSystem.InputControl<float>
            {
                /*0x104*/ UnityEngine.InputSystem.Controls.AxisControl.Clamp clamp;
                /*0x108*/ float clampMin;
                /*0x10c*/ float clampMax;
                /*0x110*/ float clampConstant;
                /*0x114*/ bool invert;
                /*0x115*/ bool normalize;
                /*0x118*/ float normalizeMin;
                /*0x11c*/ float normalizeMax;
                /*0x120*/ float normalizeZero;
                /*0x124*/ bool scale;
                /*0x128*/ float scaleFactor;

                /*0x7a18000*/ AxisControl();
                /*0x7a17ee0*/ float Preprocess(float value);
                /*0x7a17fb4*/ float Unpreprocess(float value);
                /*0x7a18088*/ void FinishSetup();
                /*0x7a18170*/ float ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a182f0*/ void WriteValueIntoState(float value, void* statePtr);
                /*0x7a183d0*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
                /*0x7a184bc*/ float EvaluateMagnitude(void* statePtr);
                /*0x7a1851c*/ float EvaluateMagnitude(float value);
                /*0x7a185d0*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();

                enum Clamp
                {
                    None = 0,
                    BeforeNormalize = 1,
                    AfterNormalize = 2,
                    ToConstantBeforeNormalize = 3,
                }
            }

            class ButtonControl : UnityEngine.InputSystem.Controls.AxisControl
            {
                static float kMinButtonPressPoint = 0.00009999999747378752;
                static /*0x0*/ float s_GlobalDefaultButtonPressPoint;
                static /*0x4*/ float s_GlobalDefaultButtonReleaseThreshold;
                /*0x12c*/ bool m_NeedsToCheckFramePress;
                /*0x130*/ uint m_UpdateCountLastPressed;
                /*0x134*/ uint m_UpdateCountLastReleased;
                /*0x138*/ bool m_LastUpdateWasPress;
                /*0x139*/ bool <needsToCheckFramePress>k__BackingField;
                /*0x13c*/ float pressPoint;

                /*0x7a17e28*/ ButtonControl();
                /*0x7a18740*/ bool get_needsToCheckFramePress();
                /*0x7a18748*/ void set_needsToCheckFramePress(bool value);
                /*0x7a18754*/ float get_pressPointOrDefault();
                /*0x7a187c0*/ bool IsValueConsideredPressed(float value);
                /*0x7a1882c*/ bool get_isPressed();
                /*0x7a188e4*/ void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame);
                /*0x7a189e8*/ bool get_wasPressedThisFrame();
                /*0x7a18b64*/ bool get_wasReleasedThisFrame();
                /*0x7a18ce0*/ void UpdateWasPressed();
            }

            class DeltaControl : UnityEngine.InputSystem.Controls.Vector2Control
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.AxisControl <up>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.AxisControl <down>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.AxisControl <left>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.AxisControl <right>k__BackingField;

                /*0x7a1900c*/ DeltaControl();
                /*0x7a18db4*/ UnityEngine.InputSystem.Controls.AxisControl get_up();
                /*0x7a18dbc*/ void set_up(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a18dcc*/ UnityEngine.InputSystem.Controls.AxisControl get_down();
                /*0x7a18dd4*/ void set_down(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a18de4*/ UnityEngine.InputSystem.Controls.AxisControl get_left();
                /*0x7a18dec*/ void set_left(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a18dfc*/ UnityEngine.InputSystem.Controls.AxisControl get_right();
                /*0x7a18e04*/ void set_right(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a18e14*/ void FinishSetup();
            }

            class DiscreteButtonControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x140*/ int minValue;
                /*0x144*/ int maxValue;
                /*0x148*/ int wrapAtValue;
                /*0x14c*/ int nullValue;
                /*0x150*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteMode writeMode;

                /*0x7a1946c*/ DiscreteButtonControl();
                /*0x7a19098*/ void FinishSetup();
                /*0x7a19194*/ float ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a19338*/ void WriteValueIntoState(float value, void* statePtr);

                enum WriteMode
                {
                    WriteDisabled = 0,
                    WriteNullAndMaxValue = 1,
                }
            }

            class DoubleControl : UnityEngine.InputSystem.InputControl<double>
            {
                /*0x7a19470*/ DoubleControl();
                /*0x7a194f8*/ double ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a19560*/ void WriteValueIntoState(double value, void* statePtr);
            }

            class DpadControl : UnityEngine.InputSystem.Controls.Vector2Control
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField;

                static /*0x7a19a04*/ UnityEngine.Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize);
                static /*0x7a19c0c*/ UnityEngine.Vector2 MakeDpadVector(float up, float down, float left, float right);
                /*0x7a19638*/ DpadControl();
                /*0x7a195d8*/ UnityEngine.InputSystem.Controls.ButtonControl get_up();
                /*0x7a195e0*/ void set_up(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a195f0*/ UnityEngine.InputSystem.Controls.ButtonControl get_down();
                /*0x7a195f8*/ void set_down(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a19608*/ UnityEngine.InputSystem.Controls.ButtonControl get_left();
                /*0x7a19610*/ void set_left(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a19620*/ UnityEngine.InputSystem.Controls.ButtonControl get_right();
                /*0x7a19628*/ void set_right(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a196a8*/ void FinishSetup();
                /*0x7a197cc*/ UnityEngine.Vector2 ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a19a60*/ void WriteValueIntoState(UnityEngine.Vector2 value, void* statePtr);

                class DpadAxisControl : UnityEngine.InputSystem.Controls.AxisControl
                {
                    /*0x12c*/ int <component>k__BackingField;

                    /*0x7a19d9c*/ DpadAxisControl();
                    /*0x7a19c1c*/ int get_component();
                    /*0x7a19c24*/ void set_component(int value);
                    /*0x7a19c2c*/ void FinishSetup();
                    /*0x7a19cb0*/ float ReadUnprocessedValueFromState(void* statePtr);
                }

                enum ButtonBits
                {
                    Up = 0,
                    Down = 1,
                    Left = 2,
                    Right = 3,
                }
            }

            class IntegerControl : UnityEngine.InputSystem.InputControl<int>
            {
                /*0x7a19da0*/ IntegerControl();
                /*0x7a19e28*/ int ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a19ebc*/ void WriteValueIntoState(int value, void* statePtr);
                /*0x7a19f58*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class KeyControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x140*/ UnityEngine.InputSystem.Key <keyCode>k__BackingField;
                /*0x144*/ int m_ScanCode;

                /*0x7a1a1e4*/ KeyControl();
                /*0x7a1a02c*/ UnityEngine.InputSystem.Key get_keyCode();
                /*0x7a1a034*/ void set_keyCode(UnityEngine.InputSystem.Key value);
                /*0x7a1a03c*/ int get_scanCode();
                /*0x7a1a058*/ void RefreshConfiguration();
            }

            class QuaternionControl : UnityEngine.InputSystem.InputControl<UnityEngine.Quaternion>
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.AxisControl <w>k__BackingField;

                /*0x7a1a248*/ QuaternionControl();
                /*0x7a1a1e8*/ UnityEngine.InputSystem.Controls.AxisControl get_x();
                /*0x7a1a1f0*/ void set_x(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1a200*/ UnityEngine.InputSystem.Controls.AxisControl get_y();
                /*0x7a1a208*/ void set_y(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1a218*/ UnityEngine.InputSystem.Controls.AxisControl get_z();
                /*0x7a1a220*/ void set_z(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1a230*/ UnityEngine.InputSystem.Controls.AxisControl get_w();
                /*0x7a1a238*/ void set_w(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1a2d8*/ void FinishSetup();
                /*0x7a1a41c*/ UnityEngine.Quaternion ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a1a540*/ void WriteValueIntoState(UnityEngine.Quaternion value, void* statePtr);
                /*0x7a1a66c*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class StickControl : UnityEngine.InputSystem.Controls.Vector2Control
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField;

                /*0x7a1aa20*/ StickControl();
                /*0x7a1a89c*/ UnityEngine.InputSystem.Controls.ButtonControl get_up();
                /*0x7a1a8a4*/ void set_up(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a1a8b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_down();
                /*0x7a1a8bc*/ void set_down(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a1a8cc*/ UnityEngine.InputSystem.Controls.ButtonControl get_left();
                /*0x7a1a8d4*/ void set_left(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a1a8e4*/ UnityEngine.InputSystem.Controls.ButtonControl get_right();
                /*0x7a1a8ec*/ void set_right(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a1a8fc*/ void FinishSetup();
            }

            class TouchControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.LowLevel.TouchState>
            {
                /*0x170*/ UnityEngine.InputSystem.Controls.TouchPressControl <press>k__BackingField;
                /*0x178*/ UnityEngine.InputSystem.Controls.IntegerControl <displayIndex>k__BackingField;
                /*0x180*/ UnityEngine.InputSystem.Controls.IntegerControl <touchId>k__BackingField;
                /*0x188*/ UnityEngine.InputSystem.Controls.Vector2Control <position>k__BackingField;
                /*0x190*/ UnityEngine.InputSystem.Controls.DeltaControl <delta>k__BackingField;
                /*0x198*/ UnityEngine.InputSystem.Controls.AxisControl <pressure>k__BackingField;
                /*0x1a0*/ UnityEngine.InputSystem.Controls.Vector2Control <radius>k__BackingField;
                /*0x1a8*/ UnityEngine.InputSystem.Controls.TouchPhaseControl <phase>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <indirectTouch>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.ButtonControl <tap>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.IntegerControl <tapCount>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.DoubleControl <startTime>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.Vector2Control <startPosition>k__BackingField;

                /*0x7a1abd0*/ TouchControl();
                /*0x7a1aa24*/ UnityEngine.InputSystem.Controls.TouchPressControl get_press();
                /*0x7a1aa2c*/ void set_press(UnityEngine.InputSystem.Controls.TouchPressControl value);
                /*0x7a1aa3c*/ UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex();
                /*0x7a1aa44*/ void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a1aa54*/ UnityEngine.InputSystem.Controls.IntegerControl get_touchId();
                /*0x7a1aa5c*/ void set_touchId(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a1aa6c*/ UnityEngine.InputSystem.Controls.Vector2Control get_position();
                /*0x7a1aa74*/ void set_position(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x7a1aa84*/ UnityEngine.InputSystem.Controls.DeltaControl get_delta();
                /*0x7a1aa8c*/ void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value);
                /*0x7a1aa9c*/ UnityEngine.InputSystem.Controls.AxisControl get_pressure();
                /*0x7a1aaa4*/ void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1aab4*/ UnityEngine.InputSystem.Controls.Vector2Control get_radius();
                /*0x7a1aabc*/ void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x7a1aacc*/ UnityEngine.InputSystem.Controls.TouchPhaseControl get_phase();
                /*0x7a1aad4*/ void set_phase(UnityEngine.InputSystem.Controls.TouchPhaseControl value);
                /*0x7a1aae4*/ UnityEngine.InputSystem.Controls.ButtonControl get_indirectTouch();
                /*0x7a1aaec*/ void set_indirectTouch(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a1aafc*/ UnityEngine.InputSystem.Controls.ButtonControl get_tap();
                /*0x7a1ab04*/ void set_tap(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a1ab14*/ UnityEngine.InputSystem.Controls.IntegerControl get_tapCount();
                /*0x7a1ab1c*/ void set_tapCount(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a1ab2c*/ UnityEngine.InputSystem.Controls.DoubleControl get_startTime();
                /*0x7a1ab34*/ void set_startTime(UnityEngine.InputSystem.Controls.DoubleControl value);
                /*0x7a1ab44*/ UnityEngine.InputSystem.Controls.Vector2Control get_startPosition();
                /*0x7a1ab4c*/ void set_startPosition(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x7a1ab5c*/ bool get_isInProgress();
                /*0x7a1ac74*/ void FinishSetup();
                /*0x7a1b020*/ UnityEngine.InputSystem.LowLevel.TouchState ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a1b0a0*/ void WriteValueIntoState(UnityEngine.InputSystem.LowLevel.TouchState value, void* statePtr);
            }

            class TouchPhaseControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.TouchPhase>
            {
                /*0x7a1b120*/ TouchPhaseControl();
                /*0x7a1b1a8*/ UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a1b228*/ void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, void* statePtr);
            }

            class TouchPressControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x7a1b674*/ TouchPressControl();
                /*0x7a1b290*/ void FinishSetup();
                /*0x7a1b38c*/ float ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a1b63c*/ void WriteValueIntoState(float value, void* statePtr);
            }

            class Vector2Control : UnityEngine.InputSystem.InputControl<UnityEngine.Vector2>
            {
                /*0x110*/ UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;
                /*0x118*/ UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;

                /*0x7a19010*/ Vector2Control();
                /*0x7a1b678*/ UnityEngine.InputSystem.Controls.AxisControl get_x();
                /*0x7a1b680*/ void set_x(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1b690*/ UnityEngine.InputSystem.Controls.AxisControl get_y();
                /*0x7a1b698*/ void set_y(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a18f38*/ void FinishSetup();
                /*0x7a1b6a8*/ UnityEngine.Vector2 ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a1b774*/ void WriteValueIntoState(UnityEngine.Vector2 value, void* statePtr);
                /*0x7a1b848*/ float EvaluateMagnitude(void* statePtr);
                /*0x7a1b8fc*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class Vector3Control : UnityEngine.InputSystem.InputControl<UnityEngine.Vector3>
            {
                /*0x118*/ UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;
                /*0x120*/ UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField;

                /*0x7a1ba8c*/ Vector3Control();
                /*0x7a1ba44*/ UnityEngine.InputSystem.Controls.AxisControl get_x();
                /*0x7a1ba4c*/ void set_x(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1ba5c*/ UnityEngine.InputSystem.Controls.AxisControl get_y();
                /*0x7a1ba64*/ void set_y(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1ba74*/ UnityEngine.InputSystem.Controls.AxisControl get_z();
                /*0x7a1ba7c*/ void set_z(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a1bb14*/ void FinishSetup();
                /*0x7a1bc1c*/ UnityEngine.Vector3 ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a1bd08*/ void WriteValueIntoState(UnityEngine.Vector3 value, void* statePtr);
                /*0x7a1be10*/ float EvaluateMagnitude(void* statePtr);
                /*0x7a1bed8*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }
        }

        namespace Interactions
        {
            class HoldInteraction : UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float duration;
                /*0x14*/ float pressPoint;
                /*0x18*/ double m_TimePressed;

                /*0x7a1c2f4*/ HoldInteraction();
                /*0x7a1c080*/ float get_durationOrDefault();
                /*0x7a1c0f0*/ float get_pressPointOrDefault();
                /*0x7a1c148*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a1c2ec*/ void Reset();
            }

            class MultiTapInteraction : UnityEngine.InputSystem.IInputInteraction<float>, UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float tapTime;
                /*0x14*/ float tapDelay;
                /*0x18*/ int tapCount;
                /*0x1c*/ float pressPoint;
                /*0x20*/ UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhase m_CurrentTapPhase;
                /*0x24*/ int m_CurrentTapCount;
                /*0x28*/ double m_CurrentTapStartTime;
                /*0x30*/ double m_LastTapReleaseTime;

                /*0x7a1c748*/ MultiTapInteraction();
                /*0x7a1c2fc*/ float get_tapTimeOrDefault();
                /*0x7a1c36c*/ float get_tapDelayOrDefault();
                /*0x7a1c3dc*/ float get_pressPointOrDefault();
                /*0x7a1c434*/ float get_releasePointOrDefault();
                /*0x7a1c4bc*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a1c73c*/ void Reset();

                enum TapPhase
                {
                    None = 0,
                    WaitingForNextRelease = 1,
                    WaitingForNextPress = 2,
                }
            }

            class PressInteraction : UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float pressPoint;
                /*0x14*/ UnityEngine.InputSystem.Interactions.PressBehavior behavior;
                /*0x18*/ bool m_WaitingForRelease;

                /*0x7a1cc04*/ PressInteraction();
                /*0x7a1c758*/ float get_pressPointOrDefault();
                /*0x7a1c7b0*/ float get_releasePointOrDefault();
                /*0x7a1c838*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a1cbfc*/ void Reset();
            }

            enum PressBehavior
            {
                PressOnly = 0,
                ReleaseOnly = 1,
                PressAndRelease = 2,
            }

            class SlowTapInteraction : UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float duration;
                /*0x14*/ float pressPoint;
                /*0x18*/ double m_SlowTapStartTime;

                /*0x7a1ce3c*/ SlowTapInteraction();
                /*0x7a1cc0c*/ float get_durationOrDefault();
                /*0x7a1cc7c*/ float get_pressPointOrDefault();
                /*0x7a1ccd4*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a1ce34*/ void Reset();
            }

            class TapInteraction : UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float duration;
                /*0x14*/ float pressPoint;
                /*0x18*/ double m_TapStartTime;

                /*0x7a1d0fc*/ TapInteraction();
                /*0x7a1ce44*/ float get_durationOrDefault();
                /*0x7a1ceb4*/ float get_pressPointOrDefault();
                /*0x7a1cf0c*/ float get_releasePointOrDefault();
                /*0x7a1cf94*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a1d0f4*/ void Reset();
            }
        }

        namespace Utilities
        {
            class InputActionTrace : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr>, System.Collections.IEnumerable, System.IDisposable
            {
                /*0x10*/ bool m_SubscribedToAll;
                /*0x11*/ bool m_OnActionChangeHooked;
                /*0x18*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputAction> m_SubscribedActions;
                /*0x30*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionMap> m_SubscribedActionMaps;
                /*0x48*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer m_EventBuffer;
                /*0x68*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState> m_ActionMapStates;
                /*0x80*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState> m_ActionMapStateClones;
                /*0x98*/ System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_CallbackDelegate;
                /*0xa0*/ System.Action<object, UnityEngine.InputSystem.InputActionChange> m_ActionChangeDelegate;

                /*0x7a1d11c*/ InputActionTrace();
                /*0x7a1d124*/ InputActionTrace(UnityEngine.InputSystem.InputAction action);
                /*0x7a1d2d4*/ InputActionTrace(UnityEngine.InputSystem.InputActionMap actionMap);
                /*0x7a1d104*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer get_buffer();
                /*0x7a1d114*/ int get_count();
                /*0x7a1d464*/ void SubscribeToAll();
                /*0x7a1d820*/ void UnsubscribeFromAll();
                /*0x7a1d19c*/ void SubscribeTo(UnityEngine.InputSystem.InputAction action);
                /*0x7a1d34c*/ void SubscribeTo(UnityEngine.InputSystem.InputActionMap actionMap);
                /*0x7a1d610*/ void UnsubscribeFrom(UnityEngine.InputSystem.InputAction action);
                /*0x7a1d728*/ void UnsubscribeFrom(UnityEngine.InputSystem.InputActionMap actionMap);
                /*0x7a1d964*/ void RecordAction(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a1db34*/ void Clear();
                /*0x7a1db88*/ void Finalize();
                /*0x7a1dd34*/ string ToString();
                /*0x7a1e44c*/ void Dispose();
                /*0x7a1dc1c*/ void DisposeInternal();
                /*0x7a1e094*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator();
                /*0x7a1e4b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7a1d540*/ void HookOnActionChange();
                /*0x7a1d8f8*/ void UnhookOnActionChange();
                /*0x7a1e4b4*/ void OnActionChange(object actionOrMapOrAsset, UnityEngine.InputSystem.InputActionChange change);
                /*0x7a1e748*/ void CloneActionStateBeforeBindingsChange(UnityEngine.InputSystem.InputActionMap actionMap);

                struct ActionEventPtr
                {
                    /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
                    /*0x18*/ UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr;

                    /*0x7a1e838*/ UnityEngine.InputSystem.InputAction get_action();
                    /*0x7a1e860*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                    /*0x7a1e86c*/ UnityEngine.InputSystem.InputControl get_control();
                    /*0x7a1e8ac*/ UnityEngine.InputSystem.IInputInteraction get_interaction();
                    /*0x7a1e904*/ double get_time();
                    /*0x7a1e920*/ double get_startTime();
                    /*0x7a1e92c*/ double get_duration();
                    /*0x7a1e95c*/ int get_valueSizeInBytes();
                    /*0x7a1e968*/ object ReadValueAsObject();
                    /*0x7a1eb94*/ void ReadValue(void* buffer, int bufferSize);
                    /*0x3910ae8*/ TValue ReadValue<TValue>();
                    /*0x7a1e110*/ string ToString();
                }

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.InputActionTrace m_Trace;
                    /*0x18*/ UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer;
                    /*0x20*/ int m_EventCount;
                    /*0x28*/ UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent;
                    /*0x30*/ int m_CurrentIndex;

                    /*0x7a1e464*/ Enumerator(UnityEngine.InputSystem.Utilities.InputActionTrace trace);
                    /*0x7a1ec8c*/ bool MoveNext();
                    /*0x7a1ecf0*/ void Reset();
                    /*0x7a1ecfc*/ void Dispose();
                    /*0x7a1ed00*/ UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr get_Current();
                    /*0x7a1ed84*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class ArrayHelpers
            {
                static /*0x382da78*/ int LengthSafe<TValue>(TValue[] array);
                static /*0x3840c74*/ void Clear<TValue>(TValue[] array);
                static /*0x3842d2c*/ void Clear<TValue>(TValue[] array, int count);
                static /*0x3843dfc*/ void Clear<TValue>(TValue[] array, ref int count);
                static /*0x3842e94*/ void EnsureCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement);
                static /*0x3842e94*/ void DuplicateWithCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement);
                static /*0x3910ae8*/ bool Contains<TValue>(TValue[] array, TValue value);
                static /*0x3910ae8*/ bool ContainsReference<TValue>(TValue[] array, TValue value);
                static /*0x3910ae8*/ bool ContainsReference<TFirst, TSecond>(TFirst[] array, int count, TSecond value);
                static /*0x3910ae8*/ bool ContainsReference<TFirst, TSecond>(TFirst[] array, int startIndex, int count, TSecond value);
                static bool HaveDuplicateReferences<TFirst>(TFirst[] first, int index, int count);
                static /*0x3825bb0*/ bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count);
                static /*0x3910ae8*/ int IndexOf<TValue>(TValue[] array, TValue value, int startIndex, int count);
                static /*0x3830044*/ int IndexOf<TValue>(TValue[] array, System.Predicate<TValue> predicate);
                static /*0x383007c*/ int IndexOf<TValue>(TValue[] array, System.Predicate<TValue> predicate, int startIndex, int count);
                static /*0x3910ae8*/ int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int count);
                static /*0x3910ae8*/ int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int startIndex, int count);
                static /*0x3910ae8*/ int IndexOfValue<TValue>(TValue[] array, TValue value, int startIndex, int count);
                static /*0x3842e50*/ void Resize<TValue>(ref Unity.Collections.NativeArray<TValue> array, int newSize, Unity.Collections.Allocator allocator);
                static /*0x3910ae8*/ int Append<TValue>(ref TValue[] array, TValue value);
                static /*0x3830044*/ int Append<TValue>(ref TValue[] array, System.Collections.Generic.IEnumerable<TValue> values);
                static /*0x3830044*/ int AppendToImmutable<TValue>(ref TValue[] array, TValue[] values);
                static /*0x3910ae8*/ int AppendWithCapacity<TValue>(ref TValue[] array, ref int count, TValue value, int capacityIncrement);
                static /*0x3910ae8*/ int AppendListWithCapacity<TValue, TValues>(ref TValue[] array, ref int length, TValues values, int capacityIncrement);
                static /*0x3910ae8*/ int AppendWithCapacity<TValue>(ref Unity.Collections.NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement, Unity.Collections.Allocator allocator);
                static /*0x3910ae8*/ void InsertAt<TValue>(ref TValue[] array, int index, TValue value);
                static /*0x3910ae8*/ void InsertAtWithCapacity<TValue>(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement);
                static /*0x3843070*/ void PutAtIfNotSet<TValue>(ref TValue[] array, int index, System.Func<TValue> valueFn);
                static /*0x382f8e8*/ int GrowBy<TValue>(ref TValue[] array, int count);
                static /*0x382f928*/ int GrowBy<TValue>(ref Unity.Collections.NativeArray<TValue> array, int count, Unity.Collections.Allocator allocator);
                static /*0x383007c*/ int GrowWithCapacity<TValue>(ref TValue[] array, ref int count, int growBy, int capacityIncrement);
                static int GrowWithCapacity<TValue>(ref Unity.Collections.NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement, Unity.Collections.Allocator allocator);
                static /*0x3910ae8*/ TValue[] Join<TValue>(TValue value, TValue[] values);
                static /*0x38395d4*/ TValue[] Merge<TValue>(TValue[] first, TValue[] second);
                static /*0x3839970*/ TValue[] Merge<TValue>(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer);
                static /*0x3842d2c*/ void EraseAt<TValue>(ref TValue[] array, int index);
                static /*0x384432c*/ void EraseAtWithCapacity<TValue>(TValue[] array, ref int count, int index);
                static /*0x3910ae8*/ void EraseAtWithCapacity<TValue>(Unity.Collections.NativeArray<TValue> array, ref int count, int index);
                static /*0x3910ae8*/ bool Erase<TValue>(ref TValue[] array, TValue value);
                static /*0x384432c*/ void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index);
                static /*0x38379c4*/ TValue[] Copy<TValue>(TValue[] array);
                static /*0x38379c4*/ TValue[] Clone<TValue>(TValue[] array);
                static /*0x38395d4*/ TNew[] Select<TOld, TNew>(TOld[] array, System.Func<TOld, TNew> converter);
                static /*0x3843dfc*/ void Swap<TValue>(ref TValue first, ref TValue second);
                static /*0x3842e94*/ void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count);
                static /*0x3844414*/ void EraseSliceWithCapacity<TValue>(ref TValue[] array, ref int length, int index, int count);
                static /*0x3842e50*/ void SwapElements<TValue>(TValue[] array, int index1, int index2);
                static /*0x3910ae8*/ void SwapElements<TValue>(Unity.Collections.NativeArray<TValue> array, int index1, int index2);

                class <>c__DisplayClass33_0<TValue>
                {
                    /*0x0*/ TValue secondValue;

                    /*0x38159dc*/ <>c__DisplayClass33_0();
                    /*0x3910ae8*/ bool <Merge>b__0(TValue x);
                }

                class <>c__DisplayClass34_0<TValue>
                {
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<TValue> comparer;

                    /*0x38159dc*/ <>c__DisplayClass34_0();
                }

                class <>c__DisplayClass34_<TValue>
                {
                    /*0x0*/ TValue secondValue;
                    /*0x0*/ UnityEngine.InputSystem.Utilities.ArrayHelpers.<>c__DisplayClass34_0<TValue> CS$<>8__locals1;

                    /*0x38159dc*/ <>c__DisplayClass34_();
                    /*0x3910ae8*/ bool <Merge>b__0(TValue x);
                }
            }

            struct CallbackArray<TDelegate>
            {
                /*0x0*/ bool m_CannotMutateCallbacksArray;
                /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_Callbacks;
                /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToAdd;
                /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToRemove;

                /*0x3814574*/ int get_length();
                /*0x3910ae8*/ TDelegate get_Item(int index);
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ void AddCallback(TDelegate dlg);
                /*0x3910ae8*/ void RemoveCallback(TDelegate dlg);
                /*0x38159dc*/ void LockForChanges();
                /*0x38159dc*/ void UnlockForChanges();
            }

            struct Vector2MagnitudeComparer : System.Collections.Generic.IComparer<UnityEngine.Vector2>
            {
                /*0x7a1ede8*/ int Compare(UnityEngine.Vector2 x, UnityEngine.Vector2 y);
            }

            struct Vector3MagnitudeComparer : System.Collections.Generic.IComparer<UnityEngine.Vector3>
            {
                /*0x7a1ee18*/ int Compare(UnityEngine.Vector3 x, UnityEngine.Vector3 y);
            }

            class CSharpCodeHelpers
            {
                static /*0x7a1ee58*/ bool IsProperIdentifier(string name);
                static /*0x7a1ef48*/ bool IsEmptyOrProperIdentifier(string name);
                static /*0x7a1ef74*/ bool IsEmptyOrProperNamespaceName(string name);
                static /*0x7a1f048*/ string MakeIdentifier(string name, string suffix);
                static /*0x7a1f280*/ string MakeTypeName(string name, string suffix);
            }

            class DelegateHelpers
            {
                static /*0x7a1f35c*/ void InvokeCallbacksSafe(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> callbacks, Unity.Profiling.ProfilerMarker marker, string callbackName, object context);
                static /*0x3910ae8*/ void InvokeCallbacksSafe<TValue>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>> callbacks, TValue argument, string callbackName, object context);
                static /*0x3910ae8*/ void InvokeCallbacksSafe<TValue1, TValue2>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, Unity.Profiling.ProfilerMarker marker, string callbackName, object context);
                static /*0x3910ae8*/ bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context);
                static /*0x3910ae8*/ void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue, System.Action>> callbacks, TValue argument, string callbackName, object context);
                static /*0x3910ae8*/ bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context);
            }

            class DisplayStringFormatAttribute : System.Attribute
            {
                /*0x10*/ string <formatString>k__BackingField;

                /*0x7a1f628*/ DisplayStringFormatAttribute(string formatString);
                /*0x7a1f618*/ string get_formatString();
                /*0x7a1f620*/ void set_formatString(string value);
            }

            class ExceptionHelpers
            {
                static /*0x7a1f658*/ bool IsExceptionIndicatingBugInCode(System.Exception exception);
            }

            struct FourCC : System.IEquatable<UnityEngine.InputSystem.Utilities.FourCC>
            {
                /*0x10*/ int m_Code;

                static /*0x7a1f8a0*/ int op_Implicit(UnityEngine.InputSystem.Utilities.FourCC fourCC);
                static /*0x7a1f8a4*/ UnityEngine.InputSystem.Utilities.FourCC op_Implicit(int i);
                static /*0x7a1fb10*/ bool op_Equality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right);
                static /*0x7a1fb1c*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right);
                static /*0x7a1fb28*/ UnityEngine.InputSystem.Utilities.FourCC FromInt32(int i);
                static /*0x7a1fb30*/ int ToInt32(UnityEngine.InputSystem.Utilities.FourCC fourCC);
                /*0x7a1f730*/ FourCC(int code);
                /*0x7a1ac54*/ FourCC(char a, char b, char c, char d);
                /*0x7a1f738*/ FourCC(string str);
                /*0x7a1f8ac*/ string ToString();
                /*0x7a1fa80*/ bool Equals(UnityEngine.InputSystem.Utilities.FourCC other);
                /*0x7a1fa90*/ bool Equals(object obj);
                /*0x7a1fb08*/ int GetHashCode();
            }

            struct InlinedArray<TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
            {
                /*0x0*/ int length;
                /*0x0*/ TValue firstValue;
                /*0x0*/ TValue[] additionalValues;

                /*0x3910ae8*/ InlinedArray(TValue value);
                /*0x3910ae8*/ InlinedArray(TValue firstValue, TValue[] additionalValues);
                /*0x3816710*/ InlinedArray(System.Collections.Generic.IEnumerable<TValue> values);
                /*0x3814574*/ int get_Capacity();
                /*0x3910ae8*/ TValue get_Item(int index);
                /*0x3910ae8*/ void set_Item(int index, TValue value);
                /*0x38159dc*/ void Clear();
                /*0x38159dc*/ void ClearWithCapacity();
                /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone();
                /*0x3815ed0*/ void SetLength(int size);
                /*0x38148bc*/ TValue[] ToArray();
                /*0x3814a3c*/ TOther[] ToArray<TOther>(System.Func<TValue, TOther> mapFunction);
                /*0x3910ae8*/ int IndexOf(TValue value);
                /*0x3910ae8*/ int Append(TValue value);
                /*0x3910ae8*/ int AppendWithCapacity(TValue value, int capacityIncrement);
                /*0x3910ae8*/ void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values);
                /*0x3816710*/ void Append(System.Collections.Generic.IEnumerable<TValue> values);
                /*0x3910ae8*/ void Remove(TValue value);
                /*0x3815ed0*/ void RemoveAtWithCapacity(int index);
                /*0x3815ed0*/ void RemoveAt(int index);
                /*0x3815ed0*/ void RemoveAtByMovingTailWithCapacity(int index);
                /*0x3910ae8*/ bool RemoveByMovingTailWithCapacity(TValue value);
                /*0x3910ae8*/ bool Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer);
                /*0x3910ae8*/ void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array;
                    /*0x0*/ int index;

                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                    /*0x3910ae8*/ TValue get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void Dispose();
                }
            }

            class InputArrayExtensions
            {
                static /*0x3910ae8*/ int IndexOfReference<TValue>(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value);
                static /*0x3910ae8*/ bool Contains<TValue>(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value);
                static /*0x3910ae8*/ bool ContainsReference<TValue>(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value);
            }

            struct InternedString : System.IEquatable<UnityEngine.InputSystem.Utilities.InternedString>, System.IComparable<UnityEngine.InputSystem.Utilities.InternedString>
            {
                /*0x10*/ string m_StringOriginalCase;
                /*0x18*/ string m_StringLowerCase;

                static /*0x7a16794*/ bool op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a16dfc*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a1fca8*/ bool op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, string b);
                static /*0x7a1fd40*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, string b);
                static /*0x7a1fdd8*/ bool op_Equality(string a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a1fe6c*/ bool op_Inequality(string a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a1ff00*/ bool op_LessThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right);
                static /*0x7a1ff24*/ bool op_GreaterThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right);
                static /*0x7a175a8*/ string op_Implicit(UnityEngine.InputSystem.Utilities.InternedString str);
                /*0x7a17180*/ InternedString(string text);
                /*0x7a1fb34*/ int get_length();
                /*0x7a1fb4c*/ bool IsEmpty();
                /*0x7a1fb5c*/ string ToLower();
                /*0x7a1fb64*/ bool Equals(object obj);
                /*0x7a1fc6c*/ bool Equals(UnityEngine.InputSystem.Utilities.InternedString other);
                /*0x7a1fc7c*/ int CompareTo(UnityEngine.InputSystem.Utilities.InternedString other);
                /*0x7a1fc90*/ int GetHashCode();
                /*0x7a168bc*/ string ToString();
            }

            struct JsonParser
            {
                /*0x10*/ string m_Text;
                /*0x18*/ int m_Length;
                /*0x1c*/ int m_Position;
                /*0x20*/ bool m_MatchAnyElementInArray;
                /*0x21*/ bool m_DryRun;

                /*0x7a157ac*/ JsonParser(string json);
                /*0x7a1ff4c*/ void Reset();
                /*0x7a1ff58*/ string ToString();
                /*0x7a1582c*/ bool NavigateToProperty(string path);
                /*0x7a15d0c*/ bool CurrentPropertyHasValueEqualTo(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue expectedValue);
                /*0x7a20038*/ bool ParseToken(char token);
                /*0x7a20188*/ bool ParseValue();
                /*0x7a201b8*/ bool ParseValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a202fc*/ bool ParseStringValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a204b0*/ bool ParseArrayValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a207c4*/ bool ParseObjectValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a20a84*/ bool ParseNumber(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a20938*/ bool ParseBooleanValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a20a20*/ bool ParseNullValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a20128*/ bool SkipToValue();
                /*0x7a20fa0*/ bool SkipString(string text);
                /*0x7a200ac*/ void SkipWhitespace();
                /*0x7a21074*/ bool get_isAtEnd();

                enum JsonValueType
                {
                    None = 0,
                    Bool = 1,
                    Real = 2,
                    Integer = 3,
                    String = 4,
                    Array = 5,
                    Object = 6,
                    Any = 7,
                }

                struct JsonString : System.IEquatable<UnityEngine.InputSystem.Utilities.JsonParser.JsonString>
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.Substring text;
                    /*0x20*/ bool hasEscapes;

                    static /*0x7a213f0*/ bool op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right);
                    static /*0x7a21420*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right);
                    static /*0x7a21454*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonString op_Implicit(string str);
                    /*0x7a21084*/ string ToString();
                    /*0x7a21180*/ bool Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonString other);
                    /*0x7a21308*/ bool Equals(object obj);
                    /*0x7a21398*/ int GetHashCode();
                }

                struct JsonValue : System.IEquatable<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType type;
                    /*0x14*/ bool boolValue;
                    /*0x18*/ double realValue;
                    /*0x20*/ long integerValue;
                    /*0x28*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonString stringValue;
                    /*0x40*/ System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> arrayValue;
                    /*0x48*/ System.Collections.Generic.Dictionary<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> objectValue;
                    /*0x50*/ object anyValue;

                    static /*0x7a21048*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(bool val);
                    static /*0x7a20f58*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(long val);
                    static /*0x7a20f80*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(double val);
                    static /*0x7a21bec*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(string str);
                    static /*0x7a15cac*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(UnityEngine.InputSystem.Utilities.JsonParser.JsonString str);
                    static /*0x7a20f04*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array);
                    static /*0x7a21c6c*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.Dictionary<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj);
                    static /*0x7a21cbc*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Enum val);
                    static /*0x7a21f08*/ bool Equals(object obj, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue value);
                    static /*0x7a202c8*/ bool op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right);
                    static /*0x7a22a58*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right);
                    /*0x7a2149c*/ bool ToBoolean();
                    /*0x7a21a50*/ long ToInteger();
                    /*0x7a21b20*/ double ToDouble();
                    /*0x7a215dc*/ string ToString();
                    /*0x7a21d0c*/ bool Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue other);
                    /*0x7a2289c*/ bool Equals(object obj);
                    /*0x7a2292c*/ int GetHashCode();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue, string> <>9__11_0;
                        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>, string> <>9__11_1;

                        static /*0x7a22a90*/ <>c();
                        /*0x7a22af8*/ <>c();
                        /*0x7a22b00*/ string <ToString>b__11_0(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue x);
                        /*0x7a22b08*/ string <ToString>b__11_1(System.Collections.Generic.KeyValuePair<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> pair);
                    }
                }
            }

            class MemoryHelpers
            {
                static /*0x7a22bbc*/ bool Compare(void* ptr1, void* ptr2, UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion region);
                static /*0x7a22d64*/ uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits);
                static /*0x7a22d74*/ void WriteSingleBit(void* ptr, uint bitOffset, bool value);
                static /*0x7a22c00*/ bool ReadSingleBit(void* ptr, uint bitOffset);
                static /*0x7a22da4*/ void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount);
                static /*0x7a22c1c*/ bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask);
                static /*0x7a22e94*/ void MemSet(void* destination, int numBytes, byte value);
                static /*0x7a22f30*/ void MemCpyMasked(void* destination, void* source, int numBytes, void* mask);
                static /*0x7a1b4d8*/ uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a22fb4*/ void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value);
                static /*0x7a19334*/ int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a19468*/ void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value);
                static /*0x7a23160*/ int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a23184*/ void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value);
                static /*0x7a23198*/ float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a231e0*/ void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value);
                static /*0x7a23230*/ void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value);
                static /*0x3843dfc*/ void Swap<TValue>(ref TValue a, ref TValue b);
                static /*0x7a233f4*/ uint AlignNatural(uint offset, uint sizeInBytes);

                struct BitRegion
                {
                    /*0x10*/ uint bitOffset;
                    /*0x14*/ uint sizeInBits;

                    /*0x7a23488*/ BitRegion(uint bitOffset, uint sizeInBits);
                    /*0x7a23490*/ BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits);
                    /*0x7a23478*/ bool get_isEmpty();
                    /*0x7a2349c*/ UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion Overlap(UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion other);
                }
            }

            class MiscHelpers
            {
                static /*0x3910ae8*/ TValue GetValueOrDefault<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key);
                static /*0x383914c*/ System.Collections.Generic.IEnumerable<TValue> EveryNth<TValue>(System.Collections.Generic.IEnumerable<TValue> enumerable, int n, int start);
                static /*0x3910ae8*/ int IndexOf<TValue>(System.Collections.Generic.IEnumerable<TValue> enumerable, TValue value);

                class <EveryNth>d__<TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ TValue <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Collections.Generic.IEnumerable<TValue> enumerable;
                    /*0x0*/ System.Collections.Generic.IEnumerable<TValue> <>3__enumerable;
                    /*0x0*/ int start;
                    /*0x0*/ int <>3__start;
                    /*0x0*/ int n;
                    /*0x0*/ int <>3__n;
                    /*0x0*/ int <index>5__2;
                    /*0x0*/ System.Collections.Generic.IEnumerator<TValue> <>7__wrap2;

                    /*0x3815ed0*/ <EveryNth>d__(int <>1__state);
                    /*0x38159dc*/ void System.IDisposable.Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void <>m__Finally1();
                    /*0x3910ae8*/ TValue System.Collections.Generic.IEnumerator<TValue>.get_Current();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct NameAndParameters
            {
                /*0x10*/ string <name>k__BackingField;
                /*0x18*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField;

                static /*0x7a23778*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text);
                static /*0x7a23824*/ bool ParseMultiple(string text, ref System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters> list);
                static /*0x7a23ddc*/ string ParseName(string text);
                static /*0x7a23e58*/ UnityEngine.InputSystem.Utilities.NameAndParameters Parse(string text);
                static /*0x7a23a0c*/ UnityEngine.InputSystem.Utilities.NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly);
                /*0x7a23564*/ string get_name();
                /*0x7a2356c*/ void set_name(string value);
                /*0x7a23574*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters();
                /*0x7a23580*/ void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value);
                /*0x7a23590*/ string ToString();

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.NameAndParameters.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.NamedValue, string> <>9__8_0;

                    static /*0x7a2408c*/ <>c();
                    /*0x7a240f4*/ <>c();
                    /*0x7a240fc*/ string <ToString>b__8_0(UnityEngine.InputSystem.Utilities.NamedValue x);
                }
            }

            struct NamedValue : System.IEquatable<UnityEngine.InputSystem.Utilities.NamedValue>
            {
                static string Separator = ",";
                /*0x10*/ string <name>k__BackingField;
                /*0x18*/ UnityEngine.InputSystem.Utilities.PrimitiveValue <value>k__BackingField;

                static /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.NamedValue From<TValue>(string name, TValue value);
                static /*0x7a24608*/ bool op_Equality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right);
                static /*0x7a24638*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right);
                static /*0x7a23ee4*/ UnityEngine.InputSystem.Utilities.NamedValue[] ParseMultiple(string parameterString);
                static /*0x7a249fc*/ UnityEngine.InputSystem.Utilities.NamedValue Parse(string str);
                static /*0x7a2466c*/ UnityEngine.InputSystem.Utilities.NamedValue ParseParameter(string parameterString, ref int index);
                static /*0x3910ae8*/ void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters);
                /*0x7a24198*/ string get_name();
                /*0x7a241a0*/ void set_name(string value);
                /*0x7a241a8*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_value();
                /*0x7a241b4*/ void set_value(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x7a241bc*/ System.TypeCode get_type();
                /*0x7a241c4*/ UnityEngine.InputSystem.Utilities.NamedValue ConvertTo(System.TypeCode type);
                /*0x7a24104*/ string ToString();
                /*0x7a24428*/ bool Equals(UnityEngine.InputSystem.Utilities.NamedValue other);
                /*0x7a244b0*/ bool Equals(object obj);
                /*0x7a24540*/ int GetHashCode();
                /*0x7a24d4c*/ void ApplyToObject(object instance);
            }

            class NumberHelpers
            {
                static /*0x7a250f4*/ int AlignToMultipleOf(int number, int alignment);
                static /*0x7a25110*/ long AlignToMultipleOf(long number, long alignment);
                static /*0x7a2512c*/ uint AlignToMultipleOf(uint number, uint alignment);
                static /*0x7a25148*/ bool Approximately(double a, double b);
                static /*0x7a251e4*/ float IntToNormalizedFloat(int value, int minValue, int maxValue);
                static /*0x7a2521c*/ int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue);
                static /*0x7a2526c*/ float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue);
                static /*0x7a252a4*/ uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue);
                static /*0x7a252ec*/ uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize);
            }

            class ForDeviceEventObservable : System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr>
            {
                /*0x10*/ System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source;
                /*0x18*/ UnityEngine.InputSystem.InputDevice m_Device;
                /*0x20*/ System.Type m_DeviceType;

                /*0x7a25358*/ ForDeviceEventObservable(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device);
                /*0x7a253b8*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer);

                class ForDevice : System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>
                {
                    /*0x10*/ System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer;
                    /*0x18*/ UnityEngine.InputSystem.InputDevice m_Device;
                    /*0x20*/ System.Type m_DeviceType;

                    /*0x7a254a4*/ ForDevice(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer);
                    /*0x7a25504*/ void OnCompleted();
                    /*0x7a25508*/ void OnError(System.Exception error);
                    /*0x7a25560*/ void OnNext(UnityEngine.InputSystem.LowLevel.InputEventPtr value);
                }
            }

            class Observable
            {
                static /*0x38395d4*/ System.IObservable<TValue> Where<TValue>(System.IObservable<TValue> source, System.Func<TValue, bool> predicate);
                static /*0x38395d4*/ System.IObservable<TResult> Select<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, TResult> filter);
                static /*0x38395d4*/ System.IObservable<TResult> SelectMany<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> filter);
                static /*0x38390c0*/ System.IObservable<TValue> Take<TValue>(System.IObservable<TValue> source, int count);
                static /*0x7a256d0*/ System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, UnityEngine.InputSystem.InputDevice device);
                static /*0x38379c4*/ System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice<TDevice>(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source);
                static /*0x38395d4*/ System.IDisposable CallOnce<TValue>(System.IObservable<TValue> source, System.Action<TValue> action);
                static /*0x38395d4*/ System.IDisposable Call<TValue>(System.IObservable<TValue> source, System.Action<TValue> action);

                class <>c__DisplayClass6_0<TValue>
                {
                    /*0x0*/ System.IDisposable subscription;

                    /*0x38159dc*/ <>c__DisplayClass6_0();
                    /*0x38159dc*/ void <CallOnce>b__0();
                }
            }

            class Observer<TValue> : System.IObserver<TValue>
            {
                /*0x0*/ System.Action<TValue> m_OnNext;
                /*0x0*/ System.Action m_OnCompleted;

                /*0x3816810*/ Observer(System.Action<TValue> onNext, System.Action onCompleted);
                /*0x38159dc*/ void OnCompleted();
                /*0x3816710*/ void OnError(System.Exception error);
                /*0x3910ae8*/ void OnNext(TValue evt);
            }

            class SelectManyObservable<TSource, TResult> : System.IObservable<TResult>
            {
                /*0x0*/ System.IObservable<TSource> m_Source;
                /*0x0*/ System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> m_Filter;

                /*0x3816810*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> filter);
                /*0x3814a3c*/ System.IDisposable Subscribe(System.IObserver<TResult> observer);

                class Select<TSource, TResult> : System.IObserver<TSource>
                {
                    /*0x0*/ UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource, TResult> m_Observable;
                    /*0x0*/ System.IObserver<TResult> m_Observer;

                    /*0x3816810*/ Select(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource, TResult> observable, System.IObserver<TResult> observer);
                    /*0x38159dc*/ void OnCompleted();
                    /*0x3816710*/ void OnError(System.Exception error);
                    /*0x3910ae8*/ void OnNext(TSource evt);
                }
            }

            class TakeNObservable<TValue> : System.IObservable<TValue>
            {
                /*0x0*/ System.IObservable<TValue> m_Source;
                /*0x0*/ int m_Count;

                /*0x381678c*/ TakeNObservable(System.IObservable<TValue> source, int count);
                /*0x3814a3c*/ System.IDisposable Subscribe(System.IObserver<TValue> observer);

                class Take<TValue> : System.IObserver<TValue>
                {
                    /*0x0*/ System.IObserver<TValue> m_Observer;
                    /*0x0*/ int m_Remaining;

                    /*0x3816810*/ Take(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer);
                    /*0x38159dc*/ void OnCompleted();
                    /*0x3816710*/ void OnError(System.Exception error);
                    /*0x3910ae8*/ void OnNext(TValue evt);
                }
            }

            class WhereObservable<TValue> : System.IObservable<TValue>
            {
                /*0x0*/ System.IObservable<TValue> m_Source;
                /*0x0*/ System.Func<TValue, bool> m_Predicate;

                /*0x3816810*/ WhereObservable(System.IObservable<TValue> source, System.Func<TValue, bool> predicate);
                /*0x3814a3c*/ System.IDisposable Subscribe(System.IObserver<TValue> observer);

                class Where<TValue> : System.IObserver<TValue>
                {
                    /*0x0*/ UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable;
                    /*0x0*/ System.IObserver<TValue> m_Observer;

                    /*0x3816810*/ Where(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer);
                    /*0x38159dc*/ void OnCompleted();
                    /*0x3816710*/ void OnError(System.Exception error);
                    /*0x3910ae8*/ void OnNext(TValue evt);
                }
            }

            struct OneOrMore<TValue, TList> : System.Collections.Generic.IReadOnlyList<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<TValue>
            {
                /*0x0*/ bool m_IsSingle;
                /*0x0*/ TValue m_Single;
                /*0x0*/ TList m_Multiple;

                static /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> op_Implicit(TValue single);
                static /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> op_Implicit(TList multiple);
                /*0x3910ae8*/ OneOrMore(TValue single);
                /*0x3910ae8*/ OneOrMore(TList multiple);
                /*0x3814574*/ int get_Count();
                /*0x3910ae8*/ TValue get_Item(int index);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                class Enumerator<TValue, TList> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int m_Index;
                    /*0x0*/ UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> m_List;

                    /*0x38159dc*/ Enumerator();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                    /*0x3910ae8*/ TValue get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void Dispose();
                }
            }

            struct PredictiveParser
            {
                /*0x10*/ int m_Position;

                /*0x7a25780*/ void ExpectSingleChar(System.ReadOnlySpan<char> str, char c);
                /*0x7a25878*/ int ExpectInt(System.ReadOnlySpan<char> str);
                /*0x7a2599c*/ System.ReadOnlySpan<char> ExpectString(System.ReadOnlySpan<char> str);
                /*0x7a25bc4*/ bool AcceptSingleChar(System.ReadOnlySpan<char> str, char c);
                /*0x7a25bfc*/ bool AcceptString(System.ReadOnlySpan<char> input, ref System.ReadOnlySpan<char> output);
                /*0x7a25d2c*/ void AcceptInt(System.ReadOnlySpan<char> str);
            }

            struct PrimitiveValue : System.IEquatable<UnityEngine.InputSystem.Utilities.PrimitiveValue>, System.IConvertible
            {
                /*0x10*/ System.TypeCode m_Type;
                /*0x14*/ bool m_BoolValue;
                /*0x14*/ char m_CharValue;
                /*0x14*/ byte m_ByteValue;
                /*0x14*/ sbyte m_SByteValue;
                /*0x14*/ short m_ShortValue;
                /*0x14*/ ushort m_UShortValue;
                /*0x14*/ int m_IntValue;
                /*0x14*/ uint m_UIntValue;
                /*0x14*/ long m_LongValue;
                /*0x14*/ ulong m_ULongValue;
                /*0x14*/ float m_FloatValue;
                /*0x14*/ double m_DoubleValue;

                static /*0x7a24484*/ bool op_Equality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right);
                static /*0x7a26868*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right);
                static /*0x7a24a50*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromString(string value);
                static /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.PrimitiveValue From<TValue>(TValue value);
                static /*0x7a26454*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromObject(object value);
                static /*0x7a24a34*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(bool value);
                static /*0x7a26010*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(char value);
                static /*0x7a26034*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(byte value);
                static /*0x7a26058*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(sbyte value);
                static /*0x7a2607c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(short value);
                static /*0x7a26dbc*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(ushort value);
                static /*0x7a260a0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(int value);
                static /*0x7a26dd0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(uint value);
                static /*0x7a26154*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(long value);
                static /*0x7a26200*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(ulong value);
                static /*0x7a187ac*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(float value);
                static /*0x7a262c0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(double value);
                static /*0x7a26de4*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromBoolean(bool value);
                static /*0x7a26e00*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromChar(char value);
                static /*0x7a26e14*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromByte(byte value);
                static /*0x7a26e28*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromSByte(sbyte value);
                static /*0x7a26e3c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt16(short value);
                static /*0x7a26e50*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt16(ushort value);
                static /*0x7a26e64*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt32(int value);
                static /*0x7a26e78*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt32(uint value);
                static /*0x7a26e8c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt64(long value);
                static /*0x7a26ea4*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt64(ulong value);
                static /*0x7a26ebc*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromSingle(float value);
                static /*0x7a26ed0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromDouble(double value);
                /*0x7a25d98*/ PrimitiveValue(bool value);
                /*0x7a25db0*/ PrimitiveValue(char value);
                /*0x7a25dc4*/ PrimitiveValue(byte value);
                /*0x7a25dd8*/ PrimitiveValue(sbyte value);
                /*0x7a25dec*/ PrimitiveValue(short value);
                /*0x7a25e00*/ PrimitiveValue(ushort value);
                /*0x7a25e14*/ PrimitiveValue(int value);
                /*0x7a25e24*/ PrimitiveValue(uint value);
                /*0x7a25e34*/ PrimitiveValue(long value);
                /*0x7a25e48*/ PrimitiveValue(ulong value);
                /*0x7a25e5c*/ PrimitiveValue(float value);
                /*0x7a25e70*/ PrimitiveValue(double value);
                /*0x7a25d88*/ byte* get_valuePtr();
                /*0x7a25d90*/ System.TypeCode get_type();
                /*0x7a185ac*/ bool get_isEmpty();
                /*0x7a2422c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue ConvertTo(System.TypeCode type);
                /*0x7a262d8*/ bool Equals(UnityEngine.InputSystem.Utilities.PrimitiveValue other);
                /*0x7a26324*/ bool Equals(object obj);
                /*0x7a245c8*/ int GetHashCode();
                /*0x7a26898*/ string ToString();
                /*0x7a26cc0*/ System.TypeCode GetTypeCode();
                /*0x7a25e84*/ bool ToBoolean(System.IFormatProvider provider);
                /*0x7a26024*/ byte ToByte(System.IFormatProvider provider);
                /*0x7a25fd8*/ char ToChar(System.IFormatProvider provider);
                /*0x7a26cc8*/ System.DateTime ToDateTime(System.IFormatProvider provider);
                /*0x7a26d14*/ decimal ToDecimal(System.IFormatProvider provider);
                /*0x7a26218*/ double ToDouble(System.IFormatProvider provider);
                /*0x7a2606c*/ short ToInt16(System.IFormatProvider provider);
                /*0x7a26090*/ int ToInt32(System.IFormatProvider provider);
                /*0x7a260b4*/ long ToInt64(System.IFormatProvider provider);
                /*0x7a26048*/ sbyte ToSByte(System.IFormatProvider provider);
                /*0x7a185bc*/ float ToSingle(System.IFormatProvider provider);
                /*0x7a26d60*/ string ToString(System.IFormatProvider provider);
                /*0x7a26d64*/ object ToType(System.Type conversionType, System.IFormatProvider provider);
                /*0x7a26d9c*/ ushort ToUInt16(System.IFormatProvider provider);
                /*0x7a26dac*/ uint ToUInt32(System.IFormatProvider provider);
                /*0x7a2616c*/ ulong ToUInt64(System.IFormatProvider provider);
                /*0x7a24fac*/ object ToObject();
            }

            struct ReadOnlyArray<TValue> : System.Collections.Generic.IReadOnlyList<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<TValue>
            {
                /*0x0*/ TValue[] m_Array;
                /*0x0*/ int m_StartIndex;
                /*0x0*/ int m_Length;

                static /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array);
                /*0x3816710*/ ReadOnlyArray(TValue[] array);
                ReadOnlyArray(TValue[] array, int index, int length);
                /*0x38148bc*/ TValue[] ToArray();
                /*0x381467c*/ int IndexOf(System.Predicate<TValue> predicate);
                /*0x3910ae8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray.Enumerator<TValue> GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3814574*/ int get_Count();
                /*0x3910ae8*/ TValue get_Item(int index);

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ TValue[] m_Array;
                    /*0x0*/ int m_IndexStart;
                    /*0x0*/ int m_IndexEnd;
                    /*0x0*/ int m_Index;

                    Enumerator(TValue[] array, int index, int length);
                    /*0x38159dc*/ void Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                    /*0x3910ae8*/ TValue get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class ReadOnlyArrayExtensions
            {
                static /*0x3910ae8*/ bool Contains<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value);
                static /*0x3910ae8*/ bool ContainsReference<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value);
                static /*0x3910ae8*/ int IndexOfReference<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value);
                static /*0x3910ae8*/ bool HaveEqualReferences<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, System.Collections.Generic.IReadOnlyList<TValue> array2, int count);
            }

            interface ISavedState
            {
                /*0x38159dc*/ void StaticDisposeCurrentState();
                /*0x38159dc*/ void RestoreSavedState();
            }

            class SavedStructState<T> : UnityEngine.InputSystem.Utilities.ISavedState
            {
                /*0x0*/ T m_State;
                /*0x0*/ UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> m_RestoreAction;
                /*0x0*/ System.Action m_StaticDisposeCurrentState;

                /*0x3816920*/ SavedStructState(ref T state, UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> restoreAction, System.Action staticDisposeCurrentState);
                /*0x38159dc*/ void StaticDisposeCurrentState();
                /*0x38159dc*/ void RestoreSavedState();

                class TypedRestore<T> : System.MulticastDelegate
                {
                    TypedRestore(object object, nint method);
                    /*0x3816710*/ void Invoke(ref T state);
                    /*0x3814c14*/ System.IAsyncResult BeginInvoke(ref T state, System.AsyncCallback callback, object object);
                    /*0x3816810*/ void EndInvoke(ref T state, System.IAsyncResult result);
                }
            }

            class SpriteUtilities
            {
                static /*0x7a26ee8*/ UnityEngine.Sprite CreateCircleSprite(int radius, UnityEngine.Color32 colour);
            }

            class StringHelpers
            {
                static /*0x7a270d0*/ string Escape(string str, string chars, string replacements);
                static /*0x7a27244*/ string Unescape(string str, string chars, string replacements);
                static /*0x7a273b0*/ bool Contains(string str, char ch);
                static /*0x7a273d0*/ bool Contains(string str, string text, System.StringComparison comparison);
                static /*0x7a273f0*/ string GetPlural(string str);
                static /*0x7a27594*/ string NicifyMemorySize(long numBytes);
                static /*0x7a276ec*/ bool FromNicifiedMemorySize(string text, ref long result, long defaultMultiplier);
                static /*0x7a2786c*/ int CountOccurrences(string str, char ch);
                static /*0x7a278dc*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(string str);
                static /*0x7a2798c*/ System.Collections.Generic.IEnumerable<string> Split(string str, System.Func<char, bool> predicate);
                static /*0x38395d4*/ string Join<TValue>(string separator, TValue[] values);
                static /*0x38395d4*/ string Join<TValue>(System.Collections.Generic.IEnumerable<TValue> values, string separator);
                static /*0x3839970*/ string MakeUniqueName<TExisting>(string baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting, string> getNameFunc);
                static /*0x7a27a58*/ bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator);
                static /*0x7a27ccc*/ int ParseInt(string str, int pos);
                static /*0x7a27d58*/ bool WriteStringToBuffer(string text, nint buffer, int bufferSizeInCharacters);
                static /*0x7a27d74*/ bool WriteStringToBuffer(string text, nint buffer, int bufferSizeInCharacters, ref uint offset);
                static /*0x7a27f20*/ string ReadStringFromBuffer(nint buffer, int bufferSize);
                static /*0x7a27f38*/ string ReadStringFromBuffer(nint buffer, int bufferSize, ref uint offset);
                static /*0x7a28044*/ bool IsPrintable(char ch);
                static /*0x7a280b4*/ string WithAllWhitespaceStripped(string str);
                static /*0x7a2819c*/ bool InvariantEqualsIgnoreCase(string left, string right);
                static /*0x7a281e8*/ string ExpandTemplateString(string template, System.Func<string, string> mapFunc);

                class <Split>d__9 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ string <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ string str;
                    /*0x30*/ string <>3__str;
                    /*0x38*/ System.Func<char, bool> predicate;
                    /*0x40*/ System.Func<char, bool> <>3__predicate;
                    /*0x48*/ int <length>5__2;
                    /*0x4c*/ int <position>5__3;

                    /*0x7a27a24*/ <Split>d__9(int <>1__state);
                    /*0x7a283b4*/ void System.IDisposable.Dispose();
                    /*0x7a283b8*/ bool MoveNext();
                    /*0x7a284ec*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                    /*0x7a284f4*/ void System.Collections.IEnumerator.Reset();
                    /*0x7a2852c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a28534*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                    /*0x7a285e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <Tokenize>d__8 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ UnityEngine.InputSystem.Utilities.Substring <>2__current;
                    /*0x28*/ int <>l__initialThreadId;
                    /*0x30*/ string str;
                    /*0x38*/ string <>3__str;
                    /*0x40*/ int <length>5__2;
                    /*0x44*/ int <endPos>5__3;

                    /*0x7a27958*/ <Tokenize>d__8(int <>1__state);
                    /*0x7a285ec*/ void System.IDisposable.Dispose();
                    /*0x7a285f0*/ bool MoveNext();
                    /*0x7a288a0*/ UnityEngine.InputSystem.Utilities.Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current();
                    /*0x7a288ac*/ void System.Collections.IEnumerator.Reset();
                    /*0x7a288e4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a28940*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator();
                    /*0x7a289e4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct Substring : System.IComparable<UnityEngine.InputSystem.Utilities.Substring>, System.IEquatable<UnityEngine.InputSystem.Utilities.Substring>
            {
                /*0x10*/ string m_String;
                /*0x18*/ int m_Index;
                /*0x1c*/ int m_Length;

                static /*0x7a28cb0*/ int Compare(UnityEngine.InputSystem.Utilities.Substring left, UnityEngine.InputSystem.Utilities.Substring right, System.StringComparison comparison);
                static /*0x7a28e2c*/ bool op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a28e48*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a28e64*/ bool op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a28e90*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a28ec0*/ bool op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a28ef0*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a28f24*/ UnityEngine.InputSystem.Utilities.Substring op_Implicit(string s);
                /*0x7a289f8*/ Substring(string str);
                /*0x7a28874*/ Substring(string str, int index, int length);
                /*0x7a28a34*/ Substring(string str, int index);
                /*0x7a289e8*/ bool get_isEmpty();
                /*0x7a28a74*/ bool Equals(object obj);
                /*0x7a28b4c*/ bool Equals(string other);
                /*0x7a28b1c*/ bool Equals(UnityEngine.InputSystem.Utilities.Substring other);
                /*0x7a28c30*/ bool Equals(UnityEngine.InputSystem.Utilities.InternedString other);
                /*0x7a28c14*/ int CompareTo(UnityEngine.InputSystem.Utilities.Substring other);
                /*0x7a28cd8*/ bool StartsWith(string str);
                /*0x7a28d78*/ string Substr(int index, int length);
                /*0x7a28dac*/ string ToString();
                /*0x7a28ddc*/ int GetHashCode();
                /*0x7a28f68*/ int get_length();
                /*0x7a28f70*/ int get_index();
                /*0x7a28f78*/ char get_Item(int index);
            }

            class TypeHelpers
            {
                static /*0x3910ae8*/ TObject As<TObject>(object obj);
                static /*0x7a28ff8*/ bool IsInt(System.TypeCode type);
                static /*0x7a29008*/ System.Type GetValueType(System.Reflection.MemberInfo member);
                static /*0x7a291d4*/ string GetNiceTypeName(System.Type type);
                static /*0x7a295a8*/ System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, int argumentIndex);
            }

            struct TypeTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, System.Type> table;

                /*0x7a29938*/ System.Collections.Generic.IEnumerable<string> get_names();
                /*0x7a29a64*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames();
                /*0x7a29ab4*/ void Initialize();
                /*0x7a29b30*/ UnityEngine.InputSystem.Utilities.InternedString FindNameForType(System.Type type);
                /*0x7a29d40*/ void AddTypeRegistration(string name, System.Type type);
                /*0x7a29e94*/ System.Type LookupTypeRegistration(string name);

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__2_0;

                    static /*0x7a29f88*/ <>c();
                    /*0x7a29ff0*/ <>c();
                    /*0x7a29ff8*/ string <get_names>b__2_0(UnityEngine.InputSystem.Utilities.InternedString x);
                }
            }
        }

        namespace Composites
        {
            class AxisComposite : UnityEngine.InputSystem.InputBindingComposite<float>
            {
                /*0x10*/ int negative;
                /*0x14*/ int positive;
                /*0x18*/ float minValue;
                /*0x1c*/ float maxValue;
                /*0x20*/ UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWins whichSideWins;

                /*0x7a2a19c*/ AxisComposite();
                /*0x7a2a01c*/ float get_midPoint();
                /*0x7a2a030*/ float ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a150*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum WhichSideWins
                {
                    Neither = 0,
                    Positive = 1,
                    Negative = 2,
                }
            }

            class ButtonWithOneModifier : UnityEngine.InputSystem.InputBindingComposite<float>
            {
                /*0x10*/ int modifier;
                /*0x14*/ int button;
                /*0x18*/ bool overrideModifiersNeedToBePressedFirst;
                /*0x1c*/ UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrder modifiersOrder;

                /*0x7a2a37c*/ ButtonWithOneModifier();
                /*0x7a2a1f0*/ float ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a260*/ bool ModifierIsPressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a2e4*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a2f0*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum ModifiersOrder
                {
                    Default = 0,
                    Ordered = 1,
                    Unordered = 2,
                }
            }

            class ButtonWithTwoModifiers : UnityEngine.InputSystem.InputBindingComposite<float>
            {
                /*0x10*/ int modifier1;
                /*0x14*/ int modifier2;
                /*0x18*/ int button;
                /*0x1c*/ bool overrideModifiersNeedToBePressedFirst;
                /*0x20*/ UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrder modifiersOrder;

                /*0x7a2a584*/ ButtonWithTwoModifiers();
                /*0x7a2a3c4*/ float ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a434*/ bool ModifiersArePressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a4ec*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a4f8*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum ModifiersOrder
                {
                    Default = 0,
                    Ordered = 1,
                    Unordered = 2,
                }
            }

            class OneModifierComposite : UnityEngine.InputSystem.InputBindingComposite
            {
                /*0x10*/ int modifier;
                /*0x14*/ int binding;
                /*0x18*/ bool overrideModifiersNeedToBePressedFirst;
                /*0x1c*/ UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrder modifiersOrder;
                /*0x20*/ int m_ValueSizeInBytes;
                /*0x28*/ System.Type m_ValueType;
                /*0x30*/ bool m_BindingIsButton;

                static /*0x7a2a7b4*/ void DetermineValueTypeAndSize(ref UnityEngine.InputSystem.InputBindingCompositeContext context, int part, ref System.Type valueType, ref int valueSizeInBytes, ref bool isButton);
                /*0x7a2ace0*/ OneModifierComposite();
                /*0x7a2a5cc*/ System.Type get_valueType();
                /*0x7a2a5d4*/ int get_valueSizeInBytes();
                /*0x7a2a5dc*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a6a8*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
                /*0x7a2a61c*/ bool ModifierIsPressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2a70c*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2ac90*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum ModifiersOrder
                {
                    Default = 0,
                    Ordered = 1,
                    Unordered = 2,
                }
            }

            class TwoModifiersComposite : UnityEngine.InputSystem.InputBindingComposite
            {
                /*0x10*/ int modifier1;
                /*0x14*/ int modifier2;
                /*0x18*/ int binding;
                /*0x1c*/ bool overrideModifiersNeedToBePressedFirst;
                /*0x20*/ UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrder modifiersOrder;
                /*0x24*/ int m_ValueSizeInBytes;
                /*0x28*/ System.Type m_ValueType;
                /*0x30*/ bool m_BindingIsButton;

                /*0x7a2af68*/ TwoModifiersComposite();
                /*0x7a2ace8*/ System.Type get_valueType();
                /*0x7a2acf0*/ int get_valueSizeInBytes();
                /*0x7a2acf8*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2adf8*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
                /*0x7a2ad38*/ bool ModifiersArePressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2ae5c*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2af04*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum ModifiersOrder
                {
                    Default = 0,
                    Ordered = 1,
                    Unordered = 2,
                }
            }

            class Vector2Composite : UnityEngine.InputSystem.InputBindingComposite<UnityEngine.Vector2>
            {
                /*0x10*/ int up;
                /*0x14*/ int down;
                /*0x18*/ int left;
                /*0x1c*/ int right;
                /*0x20*/ bool normalize;
                /*0x24*/ UnityEngine.InputSystem.Composites.Vector2Composite.Mode mode;

                /*0x7a2b144*/ Vector2Composite();
                /*0x7a2af70*/ UnityEngine.Vector2 ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2b0d4*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum Mode
                {
                    Analog = 2,
                    DigitalNormalized = 0,
                    Digital = 1,
                }
            }

            class Vector3Composite : UnityEngine.InputSystem.InputBindingComposite<UnityEngine.Vector3>
            {
                /*0x10*/ int up;
                /*0x14*/ int down;
                /*0x18*/ int left;
                /*0x1c*/ int right;
                /*0x20*/ int forward;
                /*0x24*/ int backward;
                /*0x28*/ UnityEngine.InputSystem.Composites.Vector3Composite.Mode mode;

                /*0x7a2b46c*/ Vector3Composite();
                /*0x7a2b194*/ UnityEngine.Vector3 ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a2b3e8*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

                enum Mode
                {
                    Analog = 0,
                    DigitalNormalized = 1,
                    Digital = 2,
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 187AFA8E5A9F17C91073C0FEE9EE881EC0E12FF27125249A352E7F0027DA47FA;
    static /*0x6529*/ <PrivateImplementationDetails> 20D6FD557BDCEEB113CF0C3EFEF501EB9D7AC4BA787A6A8C0EE057D8A217C869;
    static /*0x6b50*/ <PrivateImplementationDetails> 286DD866DF46AD63DA3C6198BE2F9CDB96A5223055FDC3E0287B7CCA9F45AFB4;
    static /*0x6f20*/ <PrivateImplementationDetails> 754FF720715FE60E11AD0300104CDEEB8E30183CF25B417CB06EEF78356058EB;
    static /*0x700a*/ <PrivateImplementationDetails> 9FDF136B22441FAA2292D2361FF2818DE2C9DF5F55B2F618330512B6A9C37F77;
    static /*0xd3db*/ <PrivateImplementationDetails> A9936AC77D07F78E7B0473F80D59F6E15FD898CEF491CA47D4EB1BA2AA6A4E66;
    static /*0xd5a7*/ <PrivateImplementationDetails> BD3331923AE2D87F6296377CB80C86CE12BF445ED38D4485D28FACFEC06BFF5B;
    static /*0xd71a*/ <PrivateImplementationDetails> CB22D97D4BE9F7A4259E5E355F9F66F2C2D11559A9EA0634CFF23EAA93DA62AE;
    static /*0xe6a9*/ <PrivateImplementationDetails> D4ADEDA8D4E42C7133AFF7B673F4893FEA7C6A101764B0179449453A7E7F516F;
    static /*0xeab5*/ <PrivateImplementationDetails> D9D05356900CBD90C107CDBD184BC94526EC3F9228772F900FC7C60E3FE82B5A;
    static /*0xeb09*/ <PrivateImplementationDetails> EEAB0A49E323B940CB01CCD3E80D47F1566617F04466CD5D6190ACDBC495CB2A;
    static /*0xeb21*/ <PrivateImplementationDetails> FFCB0A1E90587D61767DBCE765CBEC8743DC4A67B865900B464ED065E4625BD5;

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=84
    {
    }

    struct __StaticArrayInitTypeSize=104
    {
    }

    struct __StaticArrayInitTypeSize=234
    {
    }

    struct __StaticArrayInitTypeSize=371
    {
    }

    struct __StaticArrayInitTypeSize=460
    {
    }

    struct __StaticArrayInitTypeSize=976
    {
    }

    struct __StaticArrayInitTypeSize=1036
    {
    }

    struct __StaticArrayInitTypeSize=1575
    {
    }

    struct __StaticArrayInitTypeSize=3983
    {
    }

    struct __StaticArrayInitTypeSize=25553
    {
    }

    struct __StaticArrayInitTypeSize=25897
    {
    }
}
