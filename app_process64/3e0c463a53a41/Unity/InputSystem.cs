class <Module>
{
}

class UISupport
{
    static /*0x79d4c14*/ void Initialize();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x79d4c88*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x79d4d7c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

                /*0x79d504c*/ OpenVRHMD();
                /*0x79d4d84*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79d4d8c*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4d9c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79d4da4*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4db4*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeVelocity();
                /*0x79d4dbc*/ void set_leftEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4dcc*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity();
                /*0x79d4dd4*/ void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4de4*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeVelocity();
                /*0x79d4dec*/ void set_rightEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4dfc*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity();
                /*0x79d4e04*/ void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4e14*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeVelocity();
                /*0x79d4e1c*/ void set_centerEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4e2c*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity();
                /*0x79d4e34*/ void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d4e44*/ void FinishSetup();
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

                /*0x79d543c*/ OpenVRControllerWMR();
                /*0x79d5054*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79d505c*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d506c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79d5074*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d5084*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClick();
                /*0x79d508c*/ void set_touchpadClick(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d509c*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouch();
                /*0x79d50a4*/ void set_touchpadTouch(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d50b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79d50bc*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d50cc*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79d50d4*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d50e4*/ UnityEngine.InputSystem.Controls.ButtonControl get_menu();
                /*0x79d50ec*/ void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d50fc*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                /*0x79d5104*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d5114*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79d511c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d512c*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                /*0x79d5134*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79d5144*/ UnityEngine.InputSystem.Controls.Vector2Control get_joystick();
                /*0x79d514c*/ void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79d515c*/ void FinishSetup();
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

                /*0x79d57e0*/ ViveWand();
                /*0x79d5444*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79d544c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d545c*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79d5464*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5474*/ UnityEngine.InputSystem.Controls.ButtonControl get_primary();
                /*0x79d547c*/ void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d548c*/ UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed();
                /*0x79d5494*/ void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d54a4*/ UnityEngine.InputSystem.Controls.ButtonControl get_trackpadTouched();
                /*0x79d54ac*/ void set_trackpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d54bc*/ UnityEngine.InputSystem.Controls.Vector2Control get_trackpad();
                /*0x79d54c4*/ void set_trackpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79d54d4*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                /*0x79d54dc*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d54ec*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79d54f4*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5504*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79d550c*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d551c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79d5524*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d5534*/ void FinishSetup();
            }

            class ViveLighthouse : UnityEngine.InputSystem.TrackedDevice
            {
                /*0x79d57e8*/ ViveLighthouse();
            }

            class ViveTracker : UnityEngine.InputSystem.TrackedDevice
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;

                /*0x79d58d8*/ ViveTracker();
                /*0x79d57f0*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79d57f8*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d5808*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79d5810*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d5820*/ void FinishSetup();
            }

            class HandedViveTracker : Unity.XR.OpenVR.ViveTracker
            {
                /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.ButtonControl <primary>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.ButtonControl <trackpadPressed>k__BackingField;
                /*0x1d8*/ UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;

                /*0x79d5acc*/ HandedViveTracker();
                /*0x79d58e0*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79d58e8*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d58f8*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79d5900*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5910*/ UnityEngine.InputSystem.Controls.ButtonControl get_primary();
                /*0x79d5918*/ void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5928*/ UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed();
                /*0x79d5930*/ void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5940*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79d5948*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5958*/ void FinishSetup();
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

                /*0x79d5ebc*/ OpenVROculusTouchController();
                /*0x79d5ad4*/ UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick();
                /*0x79d5adc*/ void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79d5aec*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                /*0x79d5af4*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d5b04*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                /*0x79d5b0c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x79d5b1c*/ UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton();
                /*0x79d5b24*/ void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5b34*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton();
                /*0x79d5b3c*/ void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5b4c*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                /*0x79d5b54*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5b64*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                /*0x79d5b6c*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5b7c*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked();
                /*0x79d5b84*/ void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5b94*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched();
                /*0x79d5b9c*/ void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d5bac*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79d5bb4*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d5bc4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                /*0x79d5bcc*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d5bdc*/ void FinishSetup();
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

                    /*0x79d631c*/ OculusHMD();
                    /*0x79d5ec4*/ UnityEngine.InputSystem.Controls.ButtonControl get_userPresence();
                    /*0x79d5ecc*/ void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d5edc*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79d5ee4*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5ef4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                    /*0x79d5efc*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f0c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration();
                    /*0x79d5f14*/ void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f24*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity();
                    /*0x79d5f2c*/ void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f3c*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAcceleration();
                    /*0x79d5f44*/ void set_leftEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f54*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularAcceleration();
                    /*0x79d5f5c*/ void set_leftEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f6c*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity();
                    /*0x79d5f74*/ void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f84*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAcceleration();
                    /*0x79d5f8c*/ void set_rightEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5f9c*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularAcceleration();
                    /*0x79d5fa4*/ void set_rightEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5fb4*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity();
                    /*0x79d5fbc*/ void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5fcc*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAcceleration();
                    /*0x79d5fd4*/ void set_centerEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5fe4*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularAcceleration();
                    /*0x79d5fec*/ void set_centerEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d5ffc*/ void FinishSetup();
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

                    /*0x79d68d4*/ OculusTouchController();
                    /*0x79d6324*/ UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick();
                    /*0x79d632c*/ void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79d633c*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                    /*0x79d6344*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d6354*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                    /*0x79d635c*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d636c*/ UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton();
                    /*0x79d6374*/ void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6384*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton();
                    /*0x79d638c*/ void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d639c*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                    /*0x79d63a4*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d63b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_start();
                    /*0x79d63bc*/ void set_start(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d63cc*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked();
                    /*0x79d63d4*/ void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d63e4*/ UnityEngine.InputSystem.Controls.ButtonControl get_primaryTouched();
                    /*0x79d63ec*/ void set_primaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d63fc*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondaryTouched();
                    /*0x79d6404*/ void set_secondaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6414*/ UnityEngine.InputSystem.Controls.AxisControl get_triggerTouched();
                    /*0x79d641c*/ void set_triggerTouched(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d642c*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                    /*0x79d6434*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6444*/ UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched();
                    /*0x79d644c*/ void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d645c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                    /*0x79d6464*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d6474*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79d647c*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d648c*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                    /*0x79d6494*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d64a4*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration();
                    /*0x79d64ac*/ void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d64bc*/ void FinishSetup();
                }

                class OculusTrackingReference : UnityEngine.InputSystem.TrackedDevice
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;

                    /*0x79d69e0*/ OculusTrackingReference();
                    /*0x79d68dc*/ UnityEngine.InputSystem.Controls.IntegerControl get_trackingState();
                    /*0x79d68e4*/ void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value);
                    /*0x79d68f4*/ UnityEngine.InputSystem.Controls.ButtonControl get_isTracked();
                    /*0x79d68fc*/ void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d690c*/ void FinishSetup();
                }

                class OculusRemote : UnityEngine.InputSystem.InputDevice
                {
                    /*0x188*/ UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;
                    /*0x190*/ UnityEngine.InputSystem.Controls.ButtonControl <start>k__BackingField;
                    /*0x198*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;

                    /*0x79d6b38*/ OculusRemote();
                    /*0x79d69e8*/ UnityEngine.InputSystem.Controls.ButtonControl get_back();
                    /*0x79d69f0*/ void set_back(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6a00*/ UnityEngine.InputSystem.Controls.ButtonControl get_start();
                    /*0x79d6a08*/ void set_start(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6a18*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79d6a20*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79d6a30*/ void FinishSetup();
                }

                class OculusHMDExtended : Unity.XR.Oculus.Input.OculusHMD
                {
                    /*0x240*/ UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;
                    /*0x248*/ UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;

                    /*0x79d6c40*/ OculusHMDExtended();
                    /*0x79d6b40*/ UnityEngine.InputSystem.Controls.ButtonControl get_back();
                    /*0x79d6b48*/ void set_back(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6b58*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79d6b60*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79d6b70*/ void FinishSetup();
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

                    /*0x79d6f98*/ GearVRTrackedController();
                    /*0x79d6c48*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79d6c50*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79d6c60*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                    /*0x79d6c68*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d6c78*/ UnityEngine.InputSystem.Controls.ButtonControl get_back();
                    /*0x79d6c80*/ void set_back(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6c90*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                    /*0x79d6c98*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6ca8*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked();
                    /*0x79d6cb0*/ void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6cc0*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched();
                    /*0x79d6cc8*/ void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d6cd8*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79d6ce0*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d6cf0*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                    /*0x79d6cf8*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d6d08*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration();
                    /*0x79d6d10*/ void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d6d20*/ void FinishSetup();
                }
            }
        }

        namespace GoogleVr
        {
            class DaydreamHMD : UnityEngine.InputSystem.XR.XRHMD
            {
                /*0x79d6fa0*/ DaydreamHMD();
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

                /*0x79d737c*/ DaydreamController();
                /*0x79d6fa8*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                /*0x79d6fb0*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x79d6fc0*/ UnityEngine.InputSystem.Controls.ButtonControl get_volumeUp();
                /*0x79d6fc8*/ void set_volumeUp(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d6fd8*/ UnityEngine.InputSystem.Controls.ButtonControl get_recentered();
                /*0x79d6fe0*/ void set_recentered(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d6ff0*/ UnityEngine.InputSystem.Controls.ButtonControl get_volumeDown();
                /*0x79d6ff8*/ void set_volumeDown(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d7008*/ UnityEngine.InputSystem.Controls.ButtonControl get_recentering();
                /*0x79d7010*/ void set_recentering(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d7020*/ UnityEngine.InputSystem.Controls.ButtonControl get_app();
                /*0x79d7028*/ void set_app(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d7038*/ UnityEngine.InputSystem.Controls.ButtonControl get_home();
                /*0x79d7040*/ void set_home(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d7050*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked();
                /*0x79d7058*/ void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d7068*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched();
                /*0x79d7070*/ void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x79d7080*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                /*0x79d7088*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d7098*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration();
                /*0x79d70a0*/ void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x79d70b0*/ void FinishSetup();
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

                    /*0x79d7420*/ WMRHMD();
                    /*0x79d7384*/ UnityEngine.InputSystem.Controls.ButtonControl get_userPresence();
                    /*0x79d738c*/ void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d739c*/ void FinishSetup();
                }

                class HololensHand : UnityEngine.InputSystem.XR.XRController
                {
                    /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;
                    /*0x1b0*/ UnityEngine.InputSystem.Controls.ButtonControl <airTap>k__BackingField;
                    /*0x1b8*/ UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField;
                    /*0x1c0*/ UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField;

                    /*0x79d75e0*/ HololensHand();
                    /*0x79d7428*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                    /*0x79d7430*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d7440*/ UnityEngine.InputSystem.Controls.ButtonControl get_airTap();
                    /*0x79d7448*/ void set_airTap(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d7458*/ UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk();
                    /*0x79d7460*/ void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d7470*/ UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection();
                    /*0x79d7478*/ void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d7488*/ void FinishSetup();
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

                    /*0x79d7bac*/ WMRSpatialController();
                    /*0x79d75e8*/ UnityEngine.InputSystem.Controls.Vector2Control get_joystick();
                    /*0x79d75f0*/ void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79d7600*/ UnityEngine.InputSystem.Controls.Vector2Control get_touchpad();
                    /*0x79d7608*/ void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value);
                    /*0x79d7618*/ UnityEngine.InputSystem.Controls.AxisControl get_grip();
                    /*0x79d7620*/ void set_grip(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d7630*/ UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed();
                    /*0x79d7638*/ void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d7648*/ UnityEngine.InputSystem.Controls.ButtonControl get_menu();
                    /*0x79d7650*/ void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d7660*/ UnityEngine.InputSystem.Controls.AxisControl get_trigger();
                    /*0x79d7668*/ void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d7678*/ UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed();
                    /*0x79d7680*/ void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d7690*/ UnityEngine.InputSystem.Controls.ButtonControl get_joystickClicked();
                    /*0x79d7698*/ void set_joystickClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d76a8*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked();
                    /*0x79d76b0*/ void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d76c0*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched();
                    /*0x79d76c8*/ void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value);
                    /*0x79d76d8*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity();
                    /*0x79d76e0*/ void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d76f0*/ UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity();
                    /*0x79d76f8*/ void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d7708*/ UnityEngine.InputSystem.Controls.AxisControl get_batteryLevel();
                    /*0x79d7710*/ void set_batteryLevel(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d7720*/ UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk();
                    /*0x79d7728*/ void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value);
                    /*0x79d7738*/ UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection();
                    /*0x79d7740*/ void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d7750*/ UnityEngine.InputSystem.Controls.Vector3Control get_pointerPosition();
                    /*0x79d7758*/ void set_pointerPosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                    /*0x79d7768*/ UnityEngine.InputSystem.Controls.QuaternionControl get_pointerRotation();
                    /*0x79d7770*/ void set_pointerRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                    /*0x79d7780*/ void FinishSetup();
                }
            }
        }
    }

    namespace InputSystem
    {
        interface IInputActionCollection : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable
        {
            /*0x3907c14*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x3907c14*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x380b2f0*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x380cb08*/ void Enable();
            /*0x380cb08*/ void Disable();
        }

        interface IInputActionCollection2 : UnityEngine.InputSystem.IInputActionCollection, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable
        {
            /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x380bba0*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            int FindBinding(UnityEngine.InputSystem.InputBinding mask, ref UnityEngine.InputSystem.InputAction action);
        }

        interface IInputInteraction
        {
            /*0x380d83c*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
            /*0x380cb08*/ void Reset();
        }

        interface IInputInteraction<TValue> : UnityEngine.InputSystem.IInputInteraction
        {
        }

        class InputInteraction
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable s_Interactions;

            static /*0x79d7bb4*/ System.Type GetValueType(System.Type interactionType);
            static /*0x79d7c98*/ string GetDisplayName(string interaction);
            static /*0x79d7d8c*/ string GetDisplayName(System.Type interactionType);
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

            static /*0x79da010*/ InputAction();
            /*0x79d8a38*/ InputAction();
            /*0x79d8a8c*/ InputAction(string name, UnityEngine.InputSystem.InputActionType type, string binding, string interactions, string processors, string expectedControlType);
            /*0x79d7f14*/ string get_name();
            /*0x79d7f1c*/ UnityEngine.InputSystem.InputActionType get_type();
            /*0x79d7f24*/ System.Guid get_id();
            /*0x79d7f84*/ System.Guid get_idDontGenerate();
            /*0x79d7fcc*/ string get_expectedControlType();
            /*0x79d7fd4*/ void set_expectedControlType(string value);
            /*0x79d7fdc*/ string get_processors();
            /*0x79d7fe4*/ string get_interactions();
            /*0x79d7fec*/ UnityEngine.InputSystem.InputActionMap get_actionMap();
            /*0x79d802c*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x79d803c*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x79d8354*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x79d8404*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls();
            /*0x79d84fc*/ UnityEngine.InputSystem.InputActionPhase get_phase();
            /*0x79d85a4*/ bool get_inProgress();
            /*0x79d85f0*/ bool get_enabled();
            /*0x79d8638*/ void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79d8690*/ void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79d86e8*/ void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79d8740*/ void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79d8798*/ void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79d87f0*/ void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79d8848*/ bool get_triggered();
            /*0x79d88f8*/ UnityEngine.InputSystem.InputControl get_activeControl();
            /*0x79d8984*/ System.Type get_activeValueType();
            /*0x79d8a0c*/ bool get_wantsInitialStateCheck();
            /*0x79d8a28*/ void set_wantsInitialStateCheck(bool value);
            /*0x79d8cc4*/ void Dispose();
            /*0x79d8ce0*/ string ToString();
            /*0x79d8fac*/ void Enable();
            /*0x79d9124*/ void Disable();
            /*0x79d927c*/ UnityEngine.InputSystem.InputAction Clone();
            /*0x79d938c*/ object System.ICloneable.Clone();
            /*0x3907c14*/ TValue ReadValue<TValue>();
            /*0x79d9390*/ object ReadValueAsObject();
            /*0x79d942c*/ float GetControlMagnitude();
            /*0x79d9498*/ void Reset();
            /*0x79d9534*/ bool IsPressed();
            /*0x79d9588*/ bool IsInProgress();
            /*0x79d95e0*/ int ExpectedFrame();
            /*0x79d9654*/ bool WasPressedThisFrame();
            /*0x79d9700*/ bool WasReleasedThisFrame();
            /*0x79d884c*/ bool WasPerformedThisFrame();
            /*0x79d97ac*/ bool WasCompletedThisFrame();
            /*0x79d9858*/ float GetTimeoutCompletionPercentage();
            /*0x79d800c*/ bool get_isSingletonAction();
            /*0x79d853c*/ UnityEngine.InputSystem.InputActionState.TriggerState get_currentState();
            /*0x79d7f58*/ string MakeSureIdIsInPlace();
            /*0x79d9984*/ void GenerateId();
            /*0x79d8240*/ UnityEngine.InputSystem.InputActionMap GetOrCreateActionMap();
            /*0x79d99c8*/ void CreateInternalActionMapForSingletonAction();
            /*0x79d9b1c*/ void RequestInitialStateCheckOnEnabledAction();
            /*0x79d9b5c*/ bool ActiveControlIsValid(UnityEngine.InputSystem.InputControl control);
            /*0x79d9d30*/ System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask();
            /*0x79d9dc0*/ int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction);
            /*0x79d9f54*/ int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap);

            enum ActionFlags
            {
                WantsInitialStateCheck = 1,
            }

            struct CallbackContext
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
                /*0x18*/ int m_ActionIndex;

                /*0x79da0c4*/ int get_actionIndex();
                /*0x79da0cc*/ int get_bindingIndex();
                /*0x79da100*/ int get_controlIndex();
                /*0x79da134*/ int get_interactionIndex();
                /*0x79da168*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x79da198*/ bool get_started();
                /*0x79da1d0*/ bool get_performed();
                /*0x79da208*/ bool get_canceled();
                /*0x79da240*/ UnityEngine.InputSystem.InputAction get_action();
                /*0x79da270*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x79da2b4*/ UnityEngine.InputSystem.IInputInteraction get_interaction();
                /*0x79da30c*/ double get_time();
                /*0x79da344*/ double get_startTime();
                /*0x79da37c*/ double get_duration();
                /*0x79da3e4*/ System.Type get_valueType();
                /*0x79da434*/ int get_valueSizeInBytes();
                /*0x79da484*/ void ReadValue(void* buffer, int bufferSize);
                /*0x3907c14*/ TValue ReadValue<TValue>();
                /*0x79da640*/ bool ReadValueAsButton();
                /*0x79da6c4*/ object ReadValueAsObject();
                /*0x79da74c*/ string ToString();
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

            static /*0x79dbb14*/ UnityEngine.InputSystem.InputActionAsset FromJson(string json);
            /*0x79dd1d0*/ InputActionAsset();
            /*0x79da9e0*/ bool get_enabled();
            /*0x79dab78*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps();
            /*0x79dabe8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x79dac48*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x79dacf8*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x79dad08*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x79dae90*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            /*0x79daf6c*/ void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            /*0x79db12c*/ UnityEngine.InputSystem.InputAction get_Item(string actionNameOrId);
            /*0x79db4d0*/ string ToJson();
            /*0x79db958*/ void LoadFromJson(string json);
            /*0x79db1ac*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            /*0x79dbce0*/ int FindBinding(UnityEngine.InputSystem.InputBinding mask, ref UnityEngine.InputSystem.InputAction action);
            /*0x79dbed0*/ UnityEngine.InputSystem.InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound);
            /*0x79dc0d8*/ UnityEngine.InputSystem.InputActionMap FindActionMap(System.Guid id);
            /*0x79dc164*/ UnityEngine.InputSystem.InputAction FindAction(System.Guid guid);
            /*0x79dc228*/ int FindControlSchemeIndex(string name);
            /*0x79dc300*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(string name);
            /*0x79dc42c*/ bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x79dc6b0*/ void Enable();
            /*0x79dc860*/ void Disable();
            /*0x79dc9f8*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x79dca84*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator();
            /*0x79dcb18*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x79dcb1c*/ void MarkAsDirty();
            /*0x79dcb20*/ bool IsEmpty();
            /*0x79dcb90*/ void OnWantToChangeSetup();
            /*0x79dce90*/ void OnSetupChanged();
            /*0x79dae50*/ void ReResolveIfNecessary(bool fullResolve);
            /*0x79dd0f8*/ void ResolveBindingsIfNecessary();
            /*0x79dd198*/ void OnDestroy();

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

                /*0x79dba30*/ void ToAsset(UnityEngine.InputSystem.InputActionAsset asset);
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

                /*0x79dcaf0*/ <GetEnumerator>d__32(int <>1__state);
                /*0x79de200*/ void System.IDisposable.Dispose();
                /*0x79de204*/ bool MoveNext();
                /*0x79de398*/ UnityEngine.InputSystem.InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current();
                /*0x79de3a0*/ void System.Collections.IEnumerator.Reset();
                /*0x79de3d8*/ object System.Collections.IEnumerator.get_Current();
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

                /*0x79dacc4*/ <get_bindings>d__9(int <>1__state);
                /*0x79de3e0*/ void System.IDisposable.Dispose();
                /*0x79de3e4*/ bool MoveNext();
                /*0x79de564*/ UnityEngine.InputSystem.InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current();
                /*0x79de574*/ void System.Collections.IEnumerator.Reset();
                /*0x79de5ac*/ object System.Collections.IEnumerator.get_Current();
                /*0x79de610*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator();
                /*0x79de6b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x79e0e0c*/ InputActionMap();
            static /*0x79e0a9c*/ UnityEngine.InputSystem.InputActionMap[] FromJson(string json);
            static /*0x79e0b4c*/ string ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps);
            /*0x79d9aa8*/ InputActionMap();
            /*0x79debc4*/ InputActionMap(string name);
            /*0x79de6b8*/ string get_name();
            /*0x79de6c0*/ UnityEngine.InputSystem.InputActionAsset get_asset();
            /*0x79de6c8*/ System.Guid get_id();
            /*0x79dc090*/ System.Guid get_idDontGenerate();
            /*0x79dabd8*/ bool get_enabled();
            /*0x79de338*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions();
            /*0x79de754*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x79de7b4*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings();
            /*0x79de818*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x79de89c*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x79de8ac*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x79d9c50*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            /*0x79de9f4*/ void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            /*0x79dea38*/ UnityEngine.InputSystem.InputAction get_Item(string actionNameOrId);
            /*0x79deb14*/ void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79deb6c*/ void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x79debf0*/ void Dispose();
            /*0x79dec04*/ int FindActionIndex(string nameOrId);
            /*0x79dee08*/ void SetUpActionLookupTable();
            /*0x79def3c*/ void ClearActionLookupTable();
            /*0x79def94*/ int FindActionIndex(System.Guid id);
            /*0x79dbbcc*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            /*0x79dc1e0*/ UnityEngine.InputSystem.InputAction FindAction(System.Guid id);
            /*0x79dc59c*/ bool IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x79dc814*/ void Enable();
            /*0x79dc9c4*/ void Disable();
            /*0x79df028*/ UnityEngine.InputSystem.InputActionMap Clone();
            /*0x79df284*/ object System.ICloneable.Clone();
            /*0x79df288*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x79df2b4*/ string ToString();
            /*0x79df37c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator();
            /*0x79df420*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x79df424*/ bool get_needToResolveBindings();
            /*0x79df430*/ void set_needToResolveBindings(bool value);
            /*0x79df440*/ bool get_bindingResolutionNeedsFullReResolve();
            /*0x79df44c*/ void set_bindingResolutionNeedsFullReResolve(bool value);
            /*0x79df46c*/ bool get_controlsForEachActionInitialized();
            /*0x79df478*/ void set_controlsForEachActionInitialized(bool value);
            /*0x79df498*/ bool get_bindingsForEachActionInitialized();
            /*0x79df4a4*/ void set_bindingsForEachActionInitialized(bool value);
            /*0x79d8384*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x79d847c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x79df4c4*/ void SetUpPerActionControlAndBindingArrays();
            /*0x79dcc10*/ void OnWantToChangeSetup();
            /*0x79dcf1c*/ void OnSetupChanged();
            /*0x79dfbc8*/ void OnBindingModified();
            /*0x79dfb64*/ void ClearCachedActionData(bool onlyControls);
            /*0x79de710*/ void GenerateId();
            /*0x79d8264*/ bool LazyResolveBindings(bool fullResolve);
            /*0x79d8448*/ bool ResolveBindingsIfNecessary();
            /*0x79dfbe8*/ void ResolveBindings();
            /*0x79dbdd8*/ int FindBinding(UnityEngine.InputSystem.InputBinding mask, ref UnityEngine.InputSystem.InputAction action);
            /*0x79e09e4*/ int FindBindingRelativeToMap(UnityEngine.InputSystem.InputBinding mask);
            /*0x79e0c00*/ string ToJson();
            /*0x79e0d20*/ void OnBeforeSerialize();
            /*0x79e0d24*/ void OnAfterDeserialize();

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

                /*0x79e0e80*/ int IndexOf(UnityEngine.InputSystem.InputDevice device);
                /*0x79e0edc*/ bool Remove(UnityEngine.InputSystem.InputDevice device);
                /*0x79daec4*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get();
                /*0x79dafb0*/ bool Set(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> devices);
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

                static /*0x79e0f50*/ UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding, string actionName);
                static /*0x79e106c*/ UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding);
                static /*0x79e10c0*/ UnityEngine.InputSystem.InputBinding ToBinding(UnityEngine.InputSystem.InputActionMap.BindingOverrideJson bindingOverride);
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

                static /*0x79e1324*/ UnityEngine.InputSystem.InputActionMap.BindingJson FromBinding(ref UnityEngine.InputSystem.InputBinding binding);
                /*0x79e11b8*/ UnityEngine.InputSystem.InputBinding ToBinding();
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

                /*0x79e141c*/ UnityEngine.InputSystem.InputAction ToAction(string actionName);
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

                static /*0x79e1680*/ UnityEngine.InputSystem.InputActionMap.WriteActionJson FromAction(UnityEngine.InputSystem.InputAction action);
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

                static /*0x79e17a4*/ UnityEngine.InputSystem.InputActionMap.WriteMapJson FromMap(UnityEngine.InputSystem.InputActionMap map);
            }

            struct WriteFileJson
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;

                static /*0x79e0c70*/ UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMap(UnityEngine.InputSystem.InputActionMap map);
                static /*0x79db5ac*/ UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMaps(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps);
            }

            struct ReadFileJson
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;
                /*0x18*/ UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;

                /*0x79dd1d8*/ UnityEngine.InputSystem.InputActionMap[] ToMaps();
            }
        }

        class InputActionRebindingExtensions
        {
            static /*0x0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;

            static /*0x79e1a00*/ System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, string name, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e1c0c*/ System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride);
            static /*0x79e201c*/ System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, string name, int bindingIndex);
            static /*0x3907c14*/ System.Nullable<TValue> GetParameterValue<TObject, TValue>(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3907c14*/ void ApplyParameterOverride<TObject, TValue>(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3907c14*/ void ApplyParameterOverride<TObject, TValue>(UnityEngine.InputSystem.InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3907c14*/ void ApplyParameterOverride<TObject, TValue>(UnityEngine.InputSystem.InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x3907c14*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride<TObject, TValue>(System.Linq.Expressions.Expression<System.Func<TObject, TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
            static /*0x79e2228*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputActionMap actionMap, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e27c8*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputActionAsset asset, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e2958*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e2abc*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, string name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, int bindingIndex);
            static /*0x79e236c*/ void ApplyParameterOverride(UnityEngine.InputSystem.InputActionState state, int mapIndex, ref UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride);
            static /*0x79e2e68*/ int GetBindingIndex(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e2f7c*/ int GetBindingIndex(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e3090*/ int GetBindingIndex(UnityEngine.InputSystem.InputAction action, string group, string path);
            static /*0x79e314c*/ System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79e32bc*/ int GetBindingIndexForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79e3460*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, string group);
            static /*0x79e35c0*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options);
            static /*0x79e37c0*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, int bindingIndex, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options);
            static /*0x79e3834*/ string GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, int bindingIndex, ref string deviceLayoutName, ref string controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options);
            static /*0x79e3df4*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, string newPath, string group, string path);
            static /*0x79e3ee4*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79e4160*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, int bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79e43e4*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, int bindingIndex, string path);
            static /*0x79e3fe8*/ int ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79e4224*/ void ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, int bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride);
            static /*0x79e44c0*/ void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, int bindingIndex);
            static /*0x79e453c*/ void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e45f8*/ void RemoveBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask);
            static /*0x79e46b4*/ void RemoveAllBindingOverrides(UnityEngine.InputSystem.IInputActionCollection2 actions);
            static /*0x79e4be4*/ void RemoveAllBindingOverrides(UnityEngine.InputSystem.InputAction action);
            static /*0x79e4d54*/ void ApplyBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides);
            static /*0x79e50d0*/ void RemoveBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides);
            static /*0x79e544c*/ int ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79e55a0*/ int ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputControl control);
            static /*0x79e56bc*/ string SaveBindingOverridesAsJson(UnityEngine.InputSystem.IInputActionCollection2 actions);
            static /*0x79e5d8c*/ string SaveBindingOverridesAsJson(UnityEngine.InputSystem.InputAction action);
            static /*0x79e5b5c*/ void AddBindingOverrideJsonTo(UnityEngine.InputSystem.IInputActionCollection2 actions, UnityEngine.InputSystem.InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, UnityEngine.InputSystem.InputAction action);
            static /*0x79e60bc*/ void LoadBindingOverridesFromJson(UnityEngine.InputSystem.IInputActionCollection2 actions, string json, bool removeExisting);
            static /*0x79e6628*/ void LoadBindingOverridesFromJson(UnityEngine.InputSystem.InputAction action, string json, bool removeExisting);
            static /*0x79e6288*/ void LoadBindingOverridesFromJsonInternal(UnityEngine.InputSystem.IInputActionCollection2 actions, string json);
            static /*0x79e6808*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(UnityEngine.InputSystem.InputAction action, int bindingIndex);
            static /*0x79e092c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution();

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

                /*0x79e1e48*/ ParameterEnumerable(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex);
                /*0x79e1e9c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterEnumerator GetEnumerator();
                /*0x79e7718*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator();
                /*0x79e77d0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                /*0x79e74b0*/ ParameterEnumerator(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex);
                /*0x79e7a24*/ bool MoveToNextBinding();
                /*0x79e7be0*/ bool MoveToNextInteraction();
                /*0x79e7d2c*/ bool MoveToNextProcessor();
                /*0x79e7c50*/ bool FindParameter(object instance);
                /*0x79e1f68*/ bool MoveNext();
                /*0x79e793c*/ void Reset();
                /*0x79e1efc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter get_Current();
                /*0x79e7d9c*/ object System.Collections.IEnumerator.get_Current();
                /*0x79e7e0c*/ void Dispose();
            }

            struct ParameterOverride
            {
                /*0x10*/ string objectRegistrationName;
                /*0x18*/ string parameter;
                /*0x20*/ UnityEngine.InputSystem.InputBinding bindingMask;
                /*0x78*/ UnityEngine.InputSystem.Utilities.PrimitiveValue value;

                static /*0x79e2cc0*/ System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionMap actionMap, ref UnityEngine.InputSystem.InputBinding binding, string parameterName, string objectRegistrationName);
                static /*0x79e7e7c*/ System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] overrides, int overrideCount, ref UnityEngine.InputSystem.InputBinding binding, string parameterName, string objectRegistrationName);
                static /*0x79e8098*/ System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> PickMoreSpecificOne(System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> first, System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> second);
                /*0x79e1b2c*/ ParameterOverride(string parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x79e7e10*/ ParameterOverride(string objectRegistrationName, string parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x79e7888*/ System.Type get_objectType();
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

                static /*0x79e9fbc*/ bool HavePathMatch(UnityEngine.InputSystem.InputControl control, string[] paths, int pathCount);
                /*0x79e6bd0*/ RebindingOperation();
                /*0x79e8318*/ UnityEngine.InputSystem.InputAction get_action();
                /*0x79e8320*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
                /*0x79e8330*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates();
                /*0x79e8344*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<float> get_scores();
                /*0x79e83b8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<float> get_magnitudes();
                /*0x79e842c*/ UnityEngine.InputSystem.InputControl get_selectedControl();
                /*0x79e849c*/ bool get_started();
                /*0x79e84a8*/ bool get_completed();
                /*0x79e84b4*/ bool get_canceled();
                /*0x79e84c0*/ double get_startTime();
                /*0x79e84c8*/ float get_timeout();
                /*0x79e6f4c*/ string get_expectedControlType();
                /*0x79e6c6c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithAction(UnityEngine.InputSystem.InputAction action);
                /*0x79e6f0c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMatchingEventsBeingSuppressed(bool value);
                /*0x79e6f5c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(string binding);
                /*0x79e8580*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(UnityEngine.InputSystem.InputControl control);
                /*0x79e852c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(string layoutName);
                /*0x79e8618*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(System.Type type);
                /*0x380b9e8*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType<TControl>();
                /*0x79e6f90*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTargetBinding(int bindingIndex);
                /*0x79e88a8*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask);
                /*0x79e88d4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingGroup(string group);
                /*0x79e89a4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutGeneralizingPathOfSelectedControl();
                /*0x79e89b4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithRebindAddingNewBinding(string group);
                /*0x79e89dc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude);
                /*0x79e8aa0*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutIgnoringNoisyControls();
                /*0x79e8780*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsHavingToMatchPath(string path);
                /*0x79e6de4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsExcluding(string path);
                /*0x79e8ac4*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTimeout(float timeInSeconds);
                /*0x79e8acc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback);
                /*0x79e8aec*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback);
                /*0x79e8b0c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback);
                /*0x79e8b2c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl, string> callback);
                /*0x79e8b4c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr, float> callback);
                /*0x79e8b6c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation, string> callback);
                /*0x79e6ddc*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnMatchWaitForAnother(float seconds);
                /*0x79e8b8c*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Start();
                /*0x79e8eb4*/ void Cancel();
                /*0x79e8f00*/ void Complete();
                /*0x79e9214*/ void AddCandidate(UnityEngine.InputSystem.InputControl control, float score, float magnitude);
                /*0x79e94b8*/ void RemoveCandidate(UnityEngine.InputSystem.InputControl control);
                /*0x79e95d4*/ void Dispose();
                /*0x79e9734*/ void Finalize();
                /*0x79e97c8*/ UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Reset();
                /*0x79e8dc4*/ void HookOnEvent();
                /*0x79e9638*/ void UnhookOnEvent();
                /*0x79e98b4*/ void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                /*0x79e9388*/ void SortCandidatesByScore();
                /*0x79e8ce8*/ void HookOnAfterUpdate();
                /*0x79e96c0*/ void UnhookOnAfterUpdate();
                /*0x79ea04c*/ void OnAfterUpdate();
                /*0x79e8f10*/ void OnComplete();
                /*0x79e8ec4*/ void OnCancel();
                /*0x79ea204*/ void ResetAfterMatchCompleted();
                /*0x79e84d0*/ void ThrowIfRebindInProgress();
                /*0x79ea0f4*/ string GeneratePathForControl(UnityEngine.InputSystem.InputControl control);

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

                    /*0x79edd24*/ <>c__DisplayClass32_0();
                    /*0x79edd2c*/ bool <WithTargetBinding>b__0(UnityEngine.InputSystem.InputControlScheme x);
                }
            }

            class DeferBindingResolutionWrapper : System.IDisposable
            {
                /*0x79ee1b0*/ DeferBindingResolutionWrapper();
                /*0x79edd50*/ void Acquire();
                /*0x79eddb0*/ void Dispose();
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> bindings;
                /*0x20*/ int firstPartIndex;
                /*0x28*/ string[] partStrings;
                /*0x30*/ int partCount;

                /*0x79ee1b8*/ <>c__DisplayClass25_0();
                /*0x79ee1c0*/ string <GetBindingDisplayString>b__0(string fragment);
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

            static /*0x79ee78c*/ bool op_Equality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right);
            static /*0x79ee7bc*/ bool op_Inequality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right);
            /*0x79ee494*/ InputActionProperty(UnityEngine.InputSystem.InputAction action);
            /*0x79ee4bc*/ InputActionProperty(UnityEngine.InputSystem.InputActionReference reference);
            /*0x79ee314*/ UnityEngine.InputSystem.InputAction get_action();
            /*0x79ee46c*/ UnityEngine.InputSystem.InputActionReference get_reference();
            /*0x79ee484*/ UnityEngine.InputSystem.InputAction get_serializedAction();
            /*0x79ee48c*/ UnityEngine.InputSystem.InputActionReference get_serializedReference();
            /*0x79ee4f8*/ bool Equals(UnityEngine.InputSystem.InputActionProperty other);
            /*0x79ee59c*/ bool Equals(UnityEngine.InputSystem.InputAction other);
            /*0x79ee5b8*/ bool Equals(UnityEngine.InputSystem.InputActionReference other);
            /*0x79ee624*/ bool Equals(object obj);
            /*0x79ee6f0*/ int GetHashCode();
        }

        class InputActionReference : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.InputSystem.InputActionAsset m_Asset;
            /*0x20*/ string m_ActionId;
            /*0x28*/ UnityEngine.InputSystem.InputAction m_Action;

            static /*0x79eecac*/ string GetDisplayName(UnityEngine.InputSystem.InputAction action);
            static /*0x79ef02c*/ UnityEngine.InputSystem.InputAction op_Implicit(UnityEngine.InputSystem.InputActionReference reference);
            static /*0x79ef038*/ UnityEngine.InputSystem.InputActionReference Create(UnityEngine.InputSystem.InputAction action);
            static /*0x79ef0a4*/ void ResetCachedAction();
            /*0x79ef1bc*/ InputActionReference();
            /*0x79ee7f0*/ UnityEngine.InputSystem.InputActionAsset get_asset();
            /*0x79ee3a8*/ UnityEngine.InputSystem.InputAction get_action();
            /*0x79ee7f8*/ void Set(UnityEngine.InputSystem.InputAction action);
            /*0x79eea94*/ void Set(UnityEngine.InputSystem.InputActionAsset asset, string mapName, string actionName);
            /*0x79ee910*/ void SetInternal(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputAction action);
            /*0x79eed70*/ string ToString();
            /*0x79eeff0*/ string ToDisplayName();
            /*0x79ef1b8*/ UnityEngine.InputSystem.InputAction ToInputAction();
        }

        class InputActionSetupExtensions
        {
            static /*0x79ef1c4*/ UnityEngine.InputSystem.InputActionMap AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, string name);
            static /*0x79ef384*/ void AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map);
            static /*0x79ef5dc*/ void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map);
            static /*0x79ef750*/ void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, string nameOrId);
            static /*0x79ef864*/ UnityEngine.InputSystem.InputAction AddAction(UnityEngine.InputSystem.InputActionMap map, string name, UnityEngine.InputSystem.InputActionType type, string binding, string interactions, string processors, string groups, string expectedControlLayout);
            static /*0x79efcc8*/ void RemoveAction(UnityEngine.InputSystem.InputAction action);
            static /*0x79f0098*/ void RemoveAction(UnityEngine.InputSystem.InputActionAsset asset, string nameOrId);
            static /*0x79efbf8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, string path, string interactions, string processors, string groups);
            static /*0x79f0294*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control);
            static /*0x79f01a4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding binding);
            static /*0x79f04f0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, string path, string interactions, string groups, string action, string processors);
            static /*0x79f0768*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, string path, UnityEngine.InputSystem.InputAction action, string interactions, string groups);
            static /*0x79f088c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, string path, System.Guid action, string interactions, string groups);
            static /*0x79f0650*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding binding);
            static /*0x79f0980*/ UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(UnityEngine.InputSystem.InputAction action, string composite, string interactions, string processors);
            static /*0x79f0338*/ int AddBindingInternal(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputBinding binding, int bindingIndex);
            static /*0x79f0c20*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, int index);
            static /*0x79f0cd4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, string name);
            static /*0x79f0ed4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputActionMap actionMap, int index);
            static /*0x79f0fe8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, string id);
            static /*0x79f10bc*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, System.Guid id);
            static /*0x79f11dc*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(UnityEngine.InputSystem.InputAction action, string group);
            static /*0x79f12b0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(UnityEngine.InputSystem.InputAction action, string path);
            static /*0x79f0d48*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding match);
            static /*0x79f1384*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(UnityEngine.InputSystem.InputAction action, string compositeName);
            static /*0x79f15c8*/ void Rename(UnityEngine.InputSystem.InputAction action, string newName);
            static /*0x79f1854*/ void AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputControlScheme controlScheme);
            static /*0x79f1b1c*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, string name);
            static /*0x79f1cc8*/ void RemoveControlScheme(UnityEngine.InputSystem.InputActionAsset asset, string name);
            static /*0x79f1dfc*/ UnityEngine.InputSystem.InputControlScheme WithBindingGroup(UnityEngine.InputSystem.InputControlScheme scheme, string bindingGroup);
            static /*0x79f20fc*/ UnityEngine.InputSystem.InputControlScheme WithDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath, bool required);
            static /*0x79f2294*/ UnityEngine.InputSystem.InputControlScheme WithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);
            static /*0x79f2350*/ UnityEngine.InputSystem.InputControlScheme WithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);
            static /*0x79f240c*/ UnityEngine.InputSystem.InputControlScheme OrWithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);
            static /*0x79f24fc*/ UnityEngine.InputSystem.InputControlScheme OrWithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, string controlPath);

            struct BindingSyntax
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionMap m_ActionMap;
                /*0x18*/ UnityEngine.InputSystem.InputAction m_Action;
                /*0x20*/ int m_BindingIndexInMap;

                /*0x79f04b8*/ BindingSyntax(UnityEngine.InputSystem.InputActionMap map, int bindingIndexInMap, UnityEngine.InputSystem.InputAction action);
                /*0x79f25ec*/ bool get_valid();
                /*0x79f2658*/ int get_bindingIndex();
                /*0x79f2690*/ UnityEngine.InputSystem.InputBinding get_binding();
                /*0x79f2738*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithName(string name);
                /*0x79f2804*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithPath(string path);
                /*0x79f28d0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroup(string group);
                /*0x79f2a6c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroups(string groups);
                /*0x79f2c34*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction(string interaction);
                /*0x79f2dd0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteractions(string interactions);
                /*0x3907c14*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction<TInteraction>();
                /*0x79f2f98*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor(string processor);
                /*0x79f3134*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessors(string processors);
                /*0x3907c14*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor<TProcessor>();
                /*0x79f32fc*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Triggering(UnityEngine.InputSystem.InputAction action);
                /*0x79f3478*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax To(UnityEngine.InputSystem.InputBinding binding);
                /*0x79f35c4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextBinding();
                /*0x79f36dc*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousBinding();
                /*0x79f3710*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextPartBinding(string partName);
                /*0x79f38c0*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousPartBinding(string partName);
                /*0x79f3964*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextCompositeBinding(string compositeName);
                /*0x79f3a88*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousCompositeBinding(string compositeName);
                /*0x79f35f8*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Iterate(bool next);
                /*0x79f399c*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IterateCompositeBinding(bool next, string compositeName);
                /*0x79f37b4*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IteratePartBinding(bool next, string partName);
                /*0x79f3acc*/ void Erase();
                /*0x79f3c74*/ UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax InsertPartBinding(string partName, string path);
            }

            struct CompositeSyntax
            {
                /*0x10*/ UnityEngine.InputSystem.InputAction m_Action;
                /*0x18*/ UnityEngine.InputSystem.InputActionMap m_ActionMap;
                /*0x20*/ int m_BindingIndexInMap;

                /*0x79f0b9c*/ CompositeSyntax(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputAction action, int compositeIndex);
                /*0x79f3e78*/ int get_bindingIndex();
                /*0x79f3ea4*/ UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax With(string name, string binding, string groups, string processors);
            }

            struct ControlSchemeSyntax
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionAsset m_Asset;
                /*0x18*/ int m_ControlSchemeIndex;
                /*0x20*/ UnityEngine.InputSystem.InputControlScheme m_ControlScheme;

                /*0x79f1c98*/ ControlSchemeSyntax(UnityEngine.InputSystem.InputActionAsset asset, int index);
                /*0x79f1ecc*/ ControlSchemeSyntax(UnityEngine.InputSystem.InputControlScheme controlScheme);
                /*0x79f1f14*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithBindingGroup(string bindingGroup);
                /*0x3907c14*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice<TDevice>();
                /*0x3907c14*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice<TDevice>();
                /*0x3907c14*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice<TDevice>();
                /*0x3907c14*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice<TDevice>();
                /*0x79f222c*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice(string controlPath);
                /*0x79f2260*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice(string controlPath);
                /*0x79f24c8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice(string controlPath);
                /*0x79f25b8*/ UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice(string controlPath);
                /*0x380b9e8*/ string DeviceTypeToControlPath<TDevice>();
                /*0x79f203c*/ UnityEngine.InputSystem.InputControlScheme Done();
                /*0x79f4120*/ void AddDeviceEntry(string controlPath, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags flags);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.InputSystem.InputBinding binding;

                /*0x79f0090*/ <>c__DisplayClass5_0();
                /*0x79f434c*/ bool <RemoveAction>b__0(UnityEngine.InputSystem.InputBinding b);
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

            static /*0x79fb890*/ InputActionState();
            static /*0x79f85f8*/ int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex);
            static /*0x79f864c*/ bool ShouldIgnoreInputOnCompositeBinding(UnityEngine.InputSystem.InputActionState.BindingState* binding, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
            static /*0x79f922c*/ bool IsActuated(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, float threshold);
            static /*0x79fa9d8*/ UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState();
            static /*0x79fabf0*/ void CompactGlobalList();
            static /*0x79f6d88*/ void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change, object actionOrMapOrAsset);
            static /*0x79fada8*/ void ResetGlobals();
            static /*0x79fb0d8*/ int FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result);
            static /*0x79fb3a4*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
            static /*0x79ede7c*/ void DeferredResolutionOfBindings();
            static /*0x79fb70c*/ void DisableAllActions();
            static /*0x79faf18*/ void DestroyAllActionMapStates();
            /*0x79f4ec0*/ InputActionState();
            /*0x79f43c4*/ int get_totalCompositeCount();
            /*0x79f43cc*/ int get_totalMapCount();
            /*0x79f43d4*/ int get_totalActionCount();
            /*0x79f43dc*/ int get_totalBindingCount();
            /*0x79f43e4*/ int get_totalInteractionCount();
            /*0x79f43ec*/ int get_totalControlCount();
            /*0x79f43f4*/ UnityEngine.InputSystem.InputActionState.ActionMapIndices* get_mapIndices();
            /*0x79f43fc*/ UnityEngine.InputSystem.InputActionState.TriggerState* get_actionStates();
            /*0x79f4404*/ UnityEngine.InputSystem.InputActionState.BindingState* get_bindingStates();
            /*0x79f440c*/ UnityEngine.InputSystem.InputActionState.InteractionState* get_interactionStates();
            /*0x79f4414*/ int* get_controlIndexToBindingIndex();
            /*0x79f441c*/ ushort* get_controlGroupingAndComplexity();
            /*0x79f4424*/ float* get_controlMagnitudes();
            /*0x79f442c*/ uint* get_enabledControls();
            /*0x79f4434*/ bool get_isProcessingControlStateChange();
            /*0x79f443c*/ void Initialize(UnityEngine.InputSystem.InputBindingResolver resolver);
            /*0x79f45c8*/ void ComputeControlGroupingIfNecessary();
            /*0x79f4478*/ void ClaimDataFrom(UnityEngine.InputSystem.InputBindingResolver resolver);
            /*0x79f4794*/ void Finalize();
            /*0x79f49d0*/ void Dispose();
            /*0x79f482c*/ void Destroy(bool isFinalizing);
            /*0x79f4d34*/ UnityEngine.InputSystem.InputActionState Clone();
            /*0x79f4f6c*/ object System.ICloneable.Clone();
            /*0x79f4f70*/ bool IsUsingDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x79f5128*/ bool CanUseDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x79f5340*/ bool HasEnabledActions();
            /*0x79f53b8*/ void FinishBindingCompositeSetups();
            /*0x79f54a0*/ void PrepareForBindingReResolution(bool needFullResolve, ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, ref bool hasEnabledActions);
            /*0x79f5f4c*/ void FinishBindingResolution(bool hasEnabledActions, UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve);
            /*0x79f5fd4*/ void RestoreActionStatesAfterReResolvingBindings(UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve);
            /*0x79f6ea0*/ bool IsActiveControl(int bindingIndex, int controlIndex);
            /*0x79f6904*/ int FindControlIndexOnBinding(int bindingIndex, UnityEngine.InputSystem.InputControl control);
            /*0x79f6f54*/ void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device);
            /*0x79f7194*/ bool IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, int actionIndex);
            /*0x79f5ca4*/ void ResetActionState(int actionIndex, UnityEngine.InputSystem.InputActionPhase toPhase, bool hardReset);
            /*0x79f7590*/ ref UnityEngine.InputSystem.InputActionState.TriggerState FetchActionState(UnityEngine.InputSystem.InputAction action);
            /*0x79f75b4*/ UnityEngine.InputSystem.InputActionState.ActionMapIndices FetchMapIndices(UnityEngine.InputSystem.InputActionMap map);
            /*0x79f75e8*/ void EnableAllActions(UnityEngine.InputSystem.InputActionMap map);
            /*0x79f76e0*/ void EnableControls(UnityEngine.InputSystem.InputActionMap map);
            /*0x79f7720*/ void EnableSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x79f77c4*/ void EnableControls(UnityEngine.InputSystem.InputAction action);
            /*0x79f599c*/ void DisableAllActions(UnityEngine.InputSystem.InputActionMap map);
            /*0x79f5dc8*/ void DisableControls(UnityEngine.InputSystem.InputActionMap map);
            /*0x79f7874*/ void DisableSingleAction(UnityEngine.InputSystem.InputAction action);
            /*0x79f790c*/ void DisableControls(UnityEngine.InputSystem.InputAction action);
            /*0x79f677c*/ void EnableControls(int mapIndex, int controlStartIndex, int numControls);
            /*0x79f49d8*/ void DisableControls(int mapIndex, int controlStartIndex, int numControls);
            /*0x79f7a8c*/ void SetInitialStateCheckPending(int actionIndex, bool value);
            /*0x79f7a08*/ void SetInitialStateCheckPending(UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr, bool value);
            /*0x79f79bc*/ bool IsControlEnabled(int controlIndex);
            /*0x79f7a54*/ void SetControlEnabled(int controlIndex, bool state);
            /*0x79f6ca8*/ void HookOnBeforeUpdate();
            /*0x79f7b20*/ void UnhookOnBeforeUpdate();
            /*0x79f7b9c*/ void OnBeforeInitialUpdate();
            /*0x79f7d98*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long mapControlAndBindingIndex);
            /*0x79f83b0*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex);
            /*0x79f79e0*/ long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex);
            /*0x79f7db0*/ void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, ref int mapIndex, ref int controlIndex, ref int bindingIndex);
            /*0x79f7dcc*/ void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x79f8c60*/ void ProcessButtonState(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex, UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr);
            /*0x79f8850*/ bool IsConflictingInput(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex);
            /*0x79f7244*/ ushort GetActionBindingStartIndexAndCount(int actionIndex, ref ushort bindingCount);
            /*0x79f8e24*/ void ProcessDefaultInteraction(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex);
            /*0x79f8698*/ void ProcessInteractions(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, int interactionStartIndex, int interactionCount);
            /*0x79f83c8*/ void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex);
            /*0x79f92e4*/ void SetTotalTimeoutCompletionTime(float seconds, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x79f6b50*/ void StartTimeout(float seconds, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x79f9314*/ void StopTimeout(int interactionIndex);
            /*0x79f93d8*/ void ChangePhaseOfInteraction(UnityEngine.InputSystem.InputActionPhase newPhase, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformed, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled, bool processNextInteractionOnCancel);
            /*0x79f7308*/ bool ChangePhaseOfAction(UnityEngine.InputSystem.InputActionPhase newPhase, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformedOrCanceled);
            /*0x79f98a4*/ void ChangePhaseOfActionInternal(int actionIndex, UnityEngine.InputSystem.InputActionState.TriggerState* actionState, UnityEngine.InputSystem.InputActionPhase newPhase, ref UnityEngine.InputSystem.InputActionState.TriggerState trigger, bool isDisablingAction);
            /*0x79f9b80*/ void CallActionListeners(int actionIndex, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputActionPhase phase, ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> listeners, string callbackName);
            /*0x79f9da4*/ object GetActionOrNoneString(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x79f9e9c*/ UnityEngine.InputSystem.InputAction GetActionOrNull(int bindingIndex);
            /*0x79f9e08*/ UnityEngine.InputSystem.InputAction GetActionOrNull(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x79f9f30*/ UnityEngine.InputSystem.InputControl GetControl(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x79f9f70*/ UnityEngine.InputSystem.IInputInteraction GetInteractionOrNull(ref UnityEngine.InputSystem.InputActionState.TriggerState trigger);
            /*0x79f9fb8*/ int GetBindingIndexInMap(int bindingIndex);
            /*0x79f9ff4*/ int GetBindingIndexInState(int mapIndex, int bindingIndexInMap);
            /*0x79fa01c*/ ref UnityEngine.InputSystem.InputActionState.BindingState GetBindingState(int bindingIndex);
            /*0x79fa02c*/ ref UnityEngine.InputSystem.InputBinding GetBinding(int bindingIndex);
            /*0x79fa0ac*/ UnityEngine.InputSystem.InputActionMap GetActionMap(int bindingIndex);
            /*0x79f7264*/ void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled);
            /*0x79f5b4c*/ void ResetInteractionState(int interactionIndex);
            /*0x79fa0ec*/ int GetValueSizeInBytes(int bindingIndex, int controlIndex);
            /*0x79fa180*/ System.Type GetValueType(int bindingIndex, int controlIndex);
            /*0x79fa214*/ void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites);
            /*0x3907c14*/ TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites);
            /*0x3907c14*/ TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType);
            /*0x79fa3b8*/ float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber);
            /*0x79fa48c*/ double GetCompositePartPressTime(int bindingIndex, int partNumber);
            /*0x3907c14*/ TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, ref int controlIndex, TComparer comparer);
            /*0x79fa50c*/ bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize);
            /*0x79fa620*/ object ReadCompositePartValueAsObject(int bindingIndex, int partNumber);
            /*0x79fa71c*/ object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites);
            /*0x79fa8a8*/ bool ReadValueAsButton(int bindingIndex, int controlIndex);
            /*0x79f4534*/ void AddToGlobalList();
            /*0x79f4b5c*/ void RemoveMapFromGlobalList();
            /*0x79f5e08*/ void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change);

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

                /*0x79f5b38*/ int get_triggerControlIndex();
                /*0x79f6a74*/ void set_triggerControlIndex(int value);
                /*0x79fb9f4*/ double get_startTime();
                /*0x79fb9fc*/ void set_startTime(double value);
                /*0x79fba04*/ double get_performedTime();
                /*0x79fba0c*/ void set_performedTime(double value);
                /*0x79fba14*/ double get_timerStartTime();
                /*0x79fba1c*/ void set_timerStartTime(double value);
                /*0x79fba24*/ float get_timerDuration();
                /*0x79fba2c*/ void set_timerDuration(float value);
                /*0x79fba34*/ float get_totalTimeoutCompletionDone();
                /*0x79fba3c*/ void set_totalTimeoutCompletionDone(float value);
                /*0x79fba44*/ float get_totalTimeoutCompletionTimeRemaining();
                /*0x79fba4c*/ void set_totalTimeoutCompletionTimeRemaining(float value);
                /*0x79fba54*/ long get_timerMonitorIndex();
                /*0x79fba5c*/ void set_timerMonitorIndex(long value);
                /*0x79f6ae4*/ bool get_isTimerRunning();
                /*0x79f92d4*/ void set_isTimerRunning(bool value);
                /*0x79fba64*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x79f6a6c*/ void set_phase(UnityEngine.InputSystem.InputActionPhase value);

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

                /*0x79fba6c*/ int get_controlStartIndex();
                /*0x79fba74*/ void set_controlStartIndex(int value);
                /*0x79fbb04*/ int get_controlCount();
                /*0x79fbb0c*/ void set_controlCount(int value);
                /*0x79f5b24*/ int get_interactionStartIndex();
                /*0x79fbb9c*/ void set_interactionStartIndex(int value);
                /*0x79fbc3c*/ int get_interactionCount();
                /*0x79fbc44*/ void set_interactionCount(int value);
                /*0x79fa3a4*/ int get_processorStartIndex();
                /*0x79fbcd4*/ void set_processorStartIndex(int value);
                /*0x79fbd74*/ int get_processorCount();
                /*0x79fbd7c*/ void set_processorCount(int value);
                /*0x79f672c*/ int get_actionIndex();
                /*0x79fbe0c*/ void set_actionIndex(int value);
                /*0x79fbeac*/ int get_mapIndex();
                /*0x79fbeb4*/ void set_mapIndex(int value);
                /*0x79f4780*/ int get_compositeOrCompositeBindingIndex();
                /*0x79fbf44*/ void set_compositeOrCompositeBindingIndex(int value);
                /*0x79fbfe4*/ int get_triggerEventIdForComposite();
                /*0x79fbfec*/ void set_triggerEventIdForComposite(int value);
                /*0x79fbff4*/ double get_pressTime();
                /*0x79fbffc*/ void set_pressTime(double value);
                /*0x79fc004*/ UnityEngine.InputSystem.InputActionState.BindingState.Flags get_flags();
                /*0x79fc00c*/ void set_flags(UnityEngine.InputSystem.InputActionState.BindingState.Flags value);
                /*0x79fc014*/ bool get_chainsWithNext();
                /*0x79fc020*/ void set_chainsWithNext(bool value);
                /*0x79fc030*/ bool get_isEndOfChain();
                /*0x79fc03c*/ void set_isEndOfChain(bool value);
                /*0x79fc05c*/ bool get_isPartOfChain();
                /*0x79f5488*/ bool get_isComposite();
                /*0x79fc06c*/ void set_isComposite(bool value);
                /*0x79f4774*/ bool get_isPartOfComposite();
                /*0x79fc08c*/ void set_isPartOfComposite(bool value);
                /*0x79f7d8c*/ bool get_initialStateCheckPending();
                /*0x79f675c*/ void set_initialStateCheckPending(bool value);
                /*0x79f6750*/ bool get_wantsInitialStateCheck();
                /*0x79fc0ac*/ void set_wantsInitialStateCheck(bool value);
                /*0x79fc0cc*/ int get_partIndex();
                /*0x79fc0d4*/ void set_partIndex(int value);

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

                /*0x79fc0dc*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x79f6724*/ void set_phase(UnityEngine.InputSystem.InputActionPhase value);
                /*0x79f6740*/ bool get_isDisabled();
                /*0x79fc0e4*/ bool get_isWaiting();
                /*0x79fc0f4*/ bool get_isStarted();
                /*0x79f9894*/ bool get_isPerformed();
                /*0x79fc104*/ bool get_isCanceled();
                /*0x79fc114*/ double get_time();
                /*0x79fc11c*/ void set_time(double value);
                /*0x79fc124*/ double get_startTime();
                /*0x79fc12c*/ void set_startTime(double value);
                /*0x79fc134*/ float get_magnitude();
                /*0x79f69d4*/ void set_magnitude(float value);
                /*0x79fc13c*/ bool get_haveMagnitude();
                /*0x79fc148*/ int get_mapIndex();
                /*0x79f6af0*/ void set_mapIndex(int value);
                /*0x79f5b10*/ int get_controlIndex();
                /*0x79f6964*/ void set_controlIndex(int value);
                /*0x79fc150*/ int get_bindingIndex();
                /*0x79f66c4*/ void set_bindingIndex(int value);
                /*0x79f69e8*/ int get_interactionIndex();
                /*0x79f69fc*/ void set_interactionIndex(int value);
                /*0x79fc158*/ uint get_lastPerformedInUpdate();
                /*0x79fc160*/ void set_lastPerformedInUpdate(uint value);
                /*0x79fc168*/ int get_frame();
                /*0x79fc170*/ void set_frame(int value);
                /*0x79fc178*/ uint get_lastCompletedInUpdate();
                /*0x79fc180*/ void set_lastCompletedInUpdate(uint value);
                /*0x79fc188*/ uint get_lastCanceledInUpdate();
                /*0x79fc190*/ void set_lastCanceledInUpdate(uint value);
                /*0x79fc198*/ uint get_pressedInUpdate();
                /*0x79fc1a0*/ void set_pressedInUpdate(uint value);
                /*0x79fc1a8*/ uint get_releasedInUpdate();
                /*0x79fc1b0*/ void set_releasedInUpdate(uint value);
                /*0x79f7188*/ bool get_isPassThrough();
                /*0x79f8600*/ void set_isPassThrough(bool value);
                /*0x79f8620*/ bool get_isButton();
                /*0x79f862c*/ void set_isButton(bool value);
                /*0x79f9208*/ bool get_isPressed();
                /*0x79f7570*/ void set_isPressed(bool value);
                /*0x79f9214*/ bool get_mayNeedConflictResolution();
                /*0x79fc1b8*/ void set_mayNeedConflictResolution(bool value);
                /*0x79f9220*/ bool get_hasMultipleConcurrentActuations();
                /*0x79f7530*/ void set_hasMultipleConcurrentActuations(bool value);
                /*0x79f9b6c*/ bool get_inProcessing();
                /*0x79f7550*/ void set_inProcessing(bool value);
                /*0x79fc1d8*/ UnityEngine.InputSystem.InputActionState.TriggerState.Flags get_flags();
                /*0x79f9b78*/ void set_flags(UnityEngine.InputSystem.InputActionState.TriggerState.Flags value);

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

                /*0x79fc1e0*/ bool get_isAllocated();
                /*0x79fc1f0*/ int get_sizeInBytes();
                /*0x79fc240*/ void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount);
                /*0x79f4cf8*/ void Dispose();
                /*0x79fc36c*/ void CopyDataFrom(UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory);
                /*0x79f4ec8*/ UnityEngine.InputSystem.InputActionState.UnmanagedMemory Clone();
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

                static /*0x79fc4d8*/ <>c();
                /*0x79fc540*/ <>c();
                /*0x79fc548*/ void <SaveAndResetState>b__140_0(ref UnityEngine.InputSystem.InputActionState.GlobalState state);
                /*0x79fc5d8*/ void <SaveAndResetState>b__140_1();
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

            static /*0x79fc874*/ UnityEngine.InputSystem.InputBinding MaskByGroup(string group);
            static /*0x79fc8c4*/ UnityEngine.InputSystem.InputBinding MaskByGroups(string[] groups);
            static /*0x79f4390*/ bool op_Equality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right);
            static /*0x79fcc10*/ bool op_Inequality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right);
            /*0x79fc724*/ InputBinding(string path, string action, string groups, string processors, string interactions, string name);
            /*0x79fc624*/ string get_name();
            /*0x79fc62c*/ void set_name(string value);
            /*0x79fc634*/ System.Guid get_id();
            /*0x79f11a4*/ void set_id(System.Guid value);
            /*0x79fc67c*/ string get_path();
            /*0x79fc684*/ void set_path(string value);
            /*0x79fc68c*/ string get_overridePath();
            /*0x79fc694*/ void set_overridePath(string value);
            /*0x79fc69c*/ string get_interactions();
            /*0x79fc6a4*/ void set_interactions(string value);
            /*0x79fc6ac*/ string get_overrideInteractions();
            /*0x79fc6b4*/ void set_overrideInteractions(string value);
            /*0x79fc6bc*/ string get_processors();
            /*0x79fc6c4*/ void set_processors(string value);
            /*0x79fc6cc*/ string get_overrideProcessors();
            /*0x79fc6d4*/ void set_overrideProcessors(string value);
            /*0x79fc6dc*/ string get_groups();
            /*0x79fc6e4*/ void set_groups(string value);
            /*0x79fc6ec*/ string get_action();
            /*0x79fc6f4*/ void set_action(string value);
            /*0x79f1564*/ bool get_isComposite();
            /*0x79f0b7c*/ void set_isComposite(bool value);
            /*0x79f3ac0*/ bool get_isPartOfComposite();
            /*0x79f3e58*/ void set_isPartOfComposite(bool value);
            /*0x79fc6fc*/ bool get_hasOverrides();
            /*0x79fc7f8*/ string GetNameOfComposite();
            /*0x79f0bdc*/ void GenerateId();
            /*0x79fc83c*/ void RemoveOverrides();
            /*0x79f5328*/ string get_effectivePath();
            /*0x79fca38*/ string get_effectiveInteractions();
            /*0x79fca50*/ string get_effectiveProcessors();
            /*0x79fca68*/ bool get_isEmpty();
            /*0x79fcab4*/ bool Equals(UnityEngine.InputSystem.InputBinding other);
            /*0x79fcb80*/ bool Equals(object obj);
            /*0x79fcc5c*/ int GetHashCode();
            /*0x79fcd60*/ string ToString();
            /*0x79fce74*/ string ToDisplayString(UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control);
            /*0x79fcea0*/ string ToDisplayString(ref string deviceLayoutName, ref string controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control);
            /*0x79f1570*/ bool TriggersAction(UnityEngine.InputSystem.InputAction action);
            /*0x79fd31c*/ bool Matches(UnityEngine.InputSystem.InputBinding binding);
            /*0x79fd324*/ bool Matches(ref UnityEngine.InputSystem.InputBinding binding, UnityEngine.InputSystem.InputBinding.MatchOptions options);

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

                static /*0x79fd42c*/ <>c();
                /*0x79fd494*/ <>c();
                /*0x79fd49c*/ bool <MaskByGroups>b__45_0(string x);
            }
        }

        class InputBindingComposite
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable s_Composites;

            static /*0x79fd4c8*/ System.Type GetValueType(string composite);
            static /*0x79fd5fc*/ string GetExpectedControlLayoutName(string composite, string part);
            static /*0x79fd784*/ System.Collections.Generic.IEnumerable<string> GetPartNames(string composite);
            static /*0x79fd7f8*/ string GetDisplayFormatString(string composite);
            /*0x79fd908*/ InputBindingComposite();
            /*0x380b9e8*/ System.Type get_valueType();
            /*0x380b6a0*/ int get_valueSizeInBytes();
            /*0x3907c14*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
            /*0x380bb68*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x79fd4bc*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x79fd4c4*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x79f5494*/ void CallFinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

            class <GetPartNames>d__12 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ string composite;
                /*0x30*/ string <>3__composite;
                /*0x38*/ System.Reflection.FieldInfo[] <>7__wrap1;
                /*0x40*/ int <>7__wrap2;

                /*0x7a14084*/ <GetPartNames>d__12(int <>1__state);
                /*0x7a140b8*/ void System.IDisposable.Dispose();
                /*0x7a140bc*/ bool MoveNext();
                /*0x7a14298*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x7a142a0*/ void System.Collections.IEnumerator.Reset();
                /*0x7a142d8*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a142e0*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x7a14384*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class InputBindingComposite<TValue> : UnityEngine.InputSystem.InputBindingComposite
        {
            /*0x380cb08*/ InputBindingComposite();
            /*0x380b9e8*/ System.Type get_valueType();
            /*0x380b6a0*/ int get_valueSizeInBytes();
            /*0x3907c14*/ TValue ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
            /*0x3907c14*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
            /*0x380bb68*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
        }

        struct InputBindingCompositeContext
        {
            /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
            /*0x18*/ int m_BindingIndex;

            /*0x7a14388*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls();
            /*0x7a1443c*/ float EvaluateMagnitude(int partNumber);
            /*0x3907c14*/ TValue ReadValue<TValue>(int partNumber);
            /*0x3907c14*/ TValue ReadValue<TValue>(int partNumber, ref UnityEngine.InputSystem.InputControl sourceControl);
            /*0x3907c14*/ TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer);
            /*0x3907c14*/ TValue ReadValue<TValue, TComparer>(int partNumber, ref UnityEngine.InputSystem.InputControl sourceControl, TComparer comparer);
            /*0x7a14464*/ bool ReadValueAsButton(int partNumber);
            /*0x7a144ec*/ void ReadValue(int partNumber, void* buffer, int bufferSize);
            /*0x7a14514*/ object ReadValueAsObject(int partNumber);
            /*0x7a1453c*/ double GetPressTime(int partNumber);

            struct PartBinding
            {
                /*0x10*/ int <part>k__BackingField;
                /*0x18*/ UnityEngine.InputSystem.InputControl <control>k__BackingField;

                /*0x7a14564*/ int get_part();
                /*0x7a1456c*/ void set_part(int value);
                /*0x7a14574*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x7a1457c*/ void set_control(UnityEngine.InputSystem.InputControl value);
            }

            struct DefaultComparer<TValue> : System.Collections.Generic.IComparer<TValue>
            {
                /*0x3907c14*/ int Compare(TValue x, TValue y);
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

                /*0x7a14408*/ <get_controls>d__2(int <>1__state);
                /*0x7a14584*/ void System.IDisposable.Dispose();
                /*0x7a14588*/ bool MoveNext();
                /*0x7a146bc*/ UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current();
                /*0x7a146c8*/ void System.Collections.IEnumerator.Reset();
                /*0x7a14700*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a1475c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator();
                /*0x7a14810*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7a16048*/ UnityEngine.InputSystem.InputBindingComposite InstantiateBindingComposite(ref UnityEngine.InputSystem.InputBinding binding, UnityEngine.InputSystem.InputActionMap actionMap);
            static /*0x7a164b0*/ void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, UnityEngine.InputSystem.InputActionMap actionMap, ref UnityEngine.InputSystem.InputBinding binding, string objectRegistrationName, string namesAndParameters);
            static /*0x7a162cc*/ int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount);
            /*0x7a14814*/ int get_totalMapCount();
            /*0x7a1481c*/ int get_totalActionCount();
            /*0x7a14824*/ int get_totalBindingCount();
            /*0x7a1482c*/ int get_totalControlCount();
            /*0x7a14834*/ void Dispose();
            /*0x7a14840*/ void StartWithPreviousResolve(UnityEngine.InputSystem.InputActionState state, bool isFullResolve);
            /*0x7a14a1c*/ void AddActionMap(UnityEngine.InputSystem.InputActionMap actionMap);
            /*0x3907c14*/ int InstantiateWithParameters<TType>(UnityEngine.InputSystem.Utilities.TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, UnityEngine.InputSystem.InputActionMap actionMap, ref UnityEngine.InputSystem.InputBinding binding);
        }

        struct InputControlScheme : System.IEquatable<UnityEngine.InputSystem.InputControlScheme>
        {
            /*0x10*/ string m_Name;
            /*0x18*/ string m_BindingGroup;
            /*0x20*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_DeviceRequirements;

            static /*0x3907c14*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch);
            static /*0x3907c14*/ bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, ref UnityEngine.InputSystem.InputControlScheme controlScheme, ref UnityEngine.InputSystem.InputControlScheme.MatchResult matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch);
            static /*0x3907c14*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice<TSchemes>(UnityEngine.InputSystem.InputDevice device, TSchemes schemes);
            static /*0x7a171c8*/ bool op_Equality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right);
            static /*0x7a171f8*/ bool op_Inequality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right);
            /*0x7a16a9c*/ InputControlScheme(string name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, string bindingGroup);
            /*0x7a16a24*/ string get_name();
            /*0x7a16a2c*/ string get_bindingGroup();
            /*0x7a16a34*/ void set_bindingGroup(string value);
            /*0x7a16a3c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements();
            /*0x7a16bc0*/ void SetNameAndBindingGroup(string name, string bindingGroup);
            /*0x7a16c94*/ bool SupportsDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x3907c14*/ UnityEngine.InputSystem.InputControlScheme.MatchResult PickDevicesFrom<TDevices>(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice);
            /*0x7a16dc0*/ bool Equals(UnityEngine.InputSystem.InputControlScheme other);
            /*0x7a16f34*/ bool Equals(object obj);
            /*0x7a16fc4*/ int GetHashCode();
            /*0x7a17044*/ string ToString();

            struct MatchResult : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match>, System.Collections.IEnumerable, System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.InputControlScheme.MatchResult.Result m_Result;
                /*0x14*/ float m_Score;
                /*0x18*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices;
                /*0x38*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;
                /*0x58*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;

                /*0x7a1722c*/ float get_score();
                /*0x7a17234*/ bool get_isSuccessfulMatch();
                /*0x7a17244*/ bool get_hasMissingRequiredDevices();
                /*0x7a17254*/ bool get_hasMissingOptionalDevices();
                /*0x7a17264*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices();
                /*0x7a173a0*/ UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Item(int index);
                /*0x7a17470*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator();
                /*0x7a17508*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7a1750c*/ void Dispose();

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

                    /*0x7a1757c*/ UnityEngine.InputSystem.InputControl get_control();
                    /*0x7a175c8*/ UnityEngine.InputSystem.InputDevice get_device();
                    /*0x7a175e0*/ int get_requirementIndex();
                    /*0x7a175e8*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement get_requirement();
                    /*0x7a1761c*/ bool get_isOptional();
                }

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int m_Index;
                    /*0x18*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;
                    /*0x20*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;

                    /*0x7a1763c*/ bool MoveNext();
                    /*0x7a17668*/ void Reset();
                    /*0x7a17674*/ UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Current();
                    /*0x7a17740*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a177b0*/ void Dispose();
                }
            }

            struct DeviceRequirement : System.IEquatable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement>
            {
                /*0x10*/ string m_ControlPath;
                /*0x18*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags m_Flags;

                static /*0x7a16f08*/ bool op_Equality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right);
                static /*0x7a17aa0*/ bool op_Inequality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right);
                /*0x7a177b4*/ string get_controlPath();
                /*0x7a177bc*/ void set_controlPath(string value);
                /*0x7a17630*/ bool get_isOptional();
                /*0x7a177c4*/ void set_isOptional(bool value);
                /*0x7a177d4*/ bool get_isAND();
                /*0x7a177f0*/ void set_isAND(bool value);
                /*0x7a177e4*/ bool get_isOR();
                /*0x7a17810*/ void set_isOR(bool value);
                /*0x7a17830*/ string ToString();
                /*0x7a178f4*/ bool Equals(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement other);
                /*0x7a17960*/ bool Equals(object obj);
                /*0x7a179d8*/ int GetHashCode();

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

                static /*0x7a17c8c*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson ToJson(UnityEngine.InputSystem.InputControlScheme scheme);
                static /*0x7a17e34*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson[] ToJson(UnityEngine.InputSystem.InputControlScheme[] schemes);
                static /*0x7a17f4c*/ UnityEngine.InputSystem.InputControlScheme[] ToSchemes(UnityEngine.InputSystem.InputControlScheme.SchemeJson[] schemes);
                /*0x7a17ad0*/ UnityEngine.InputSystem.InputControlScheme ToScheme();

                struct DeviceJson
                {
                    /*0x10*/ string devicePath;
                    /*0x18*/ bool isOptional;
                    /*0x19*/ bool isOR;

                    static /*0x7a17df8*/ UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson From(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement requirement);
                    /*0x7a17c38*/ UnityEngine.InputSystem.InputControlScheme.DeviceRequirement ToDeviceEntry();
                }
            }
        }

        struct InputInteractionContext
        {
            /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
            /*0x18*/ UnityEngine.InputSystem.InputInteractionContext.Flags m_Flags;
            /*0x1c*/ UnityEngine.InputSystem.InputActionState.TriggerState m_TriggerState;

            /*0x7a18054*/ UnityEngine.InputSystem.InputAction get_action();
            /*0x7a18078*/ UnityEngine.InputSystem.InputControl get_control();
            /*0x7a1809c*/ UnityEngine.InputSystem.InputActionPhase get_phase();
            /*0x7a180a4*/ double get_time();
            /*0x7a180ac*/ double get_startTime();
            /*0x7a180b4*/ bool get_timerHasExpired();
            /*0x7a180c0*/ void set_timerHasExpired(bool value);
            /*0x7a180e0*/ bool get_isWaiting();
            /*0x7a180f0*/ bool get_isStarted();
            /*0x7a18100*/ float ComputeMagnitude();
            /*0x7a18108*/ bool ControlIsActuated(float threshold);
            /*0x7a18170*/ void Started();
            /*0x7a181ac*/ void Performed();
            /*0x7a181f0*/ void PerformedAndStayStarted();
            /*0x7a18234*/ void PerformedAndStayPerformed();
            /*0x7a18278*/ void Canceled();
            /*0x7a182bc*/ void Waiting();
            /*0x7a18300*/ void SetTimeout(float seconds);
            /*0x7a18324*/ void SetTotalTimeoutCompletionTime(float seconds);
            /*0x3907c14*/ TValue ReadValue<TValue>();
            /*0x7a183b4*/ int get_mapIndex();
            /*0x7a183bc*/ int get_controlIndex();
            /*0x7a183c8*/ int get_bindingIndex();
            /*0x7a183d0*/ int get_interactionIndex();

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

            static /*0x7a1d3f0*/ InputSystem();
            static /*0x7a183dc*/ void add_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            static /*0x7a18508*/ void remove_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            static /*0x7a18634*/ void RegisterLayout(System.Type type, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x3907c14*/ void RegisterLayout<T>(string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x7a187c8*/ void RegisterLayout(string json, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x7a188c4*/ void RegisterLayoutOverride(string json, string name);
            static /*0x7a18944*/ void RegisterLayoutMatcher(string layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            static /*0x3907c14*/ void RegisterLayoutMatcher<TDevice>(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            static /*0x7a189c0*/ void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches);
            static /*0x3837da0*/ void RegisterPrecompiledLayout<TDevice>(string metadata);
            static /*0x7a18b3c*/ void RemoveLayout(string name);
            static /*0x7a18ba8*/ string TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
            static /*0x7a18c20*/ System.Collections.Generic.IEnumerable<string> ListLayouts();
            static /*0x7a18c88*/ System.Collections.Generic.IEnumerable<string> ListLayoutsBasedOn(string baseLayout);
            static /*0x7a18d4c*/ UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout(string name);
            static /*0x382dee4*/ UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout<TControl>();
            static /*0x7a18e34*/ string GetNameOfBaseLayout(string layoutName);
            static /*0x7a18f4c*/ bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName);
            static /*0x7a19094*/ void RegisterProcessor(System.Type type, string name);
            static /*0x3837da0*/ void RegisterProcessor<T>(string name);
            static /*0x7a19460*/ System.Type TryGetProcessor(string name);
            static /*0x7a19538*/ System.Collections.Generic.IEnumerable<string> ListProcessors();
            static /*0x7a195b0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices();
            static /*0x7a19614*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices();
            static /*0x7a196b0*/ void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            static /*0x7a19828*/ void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            static /*0x7a199a0*/ void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            static /*0x7a19b18*/ void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            static /*0x7a19c90*/ void add_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            static /*0x7a19dbc*/ void remove_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            static /*0x7a19ee8*/ float get_pollingFrequency();
            static /*0x7a19f4c*/ void set_pollingFrequency(float value);
            static /*0x7a19fc0*/ UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name, string variants);
            static /*0x3907c14*/ TDevice AddDevice<TDevice>(string name);
            static /*0x7a1a0c0*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description);
            static /*0x7a1a1d4*/ void AddDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a1a28c*/ void RemoveDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a1a2fc*/ void FlushDisconnectedDevices();
            static /*0x7a1a360*/ UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout);
            static /*0x3907c14*/ TDevice GetDevice<TDevice>();
            static /*0x7a1a3cc*/ UnityEngine.InputSystem.InputDevice GetDevice(System.Type type);
            static /*0x3907c14*/ TDevice GetDevice<TDevice>(UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x3907c14*/ TDevice GetDevice<TDevice>(string usage);
            static /*0x7a1a5c8*/ UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId);
            static /*0x7a1a634*/ System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices();
            static /*0x7a1a6d0*/ int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions);
            static /*0x7a1a73c*/ void EnableDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a1a7b0*/ void DisableDevice(UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents);
            static /*0x7a1a830*/ bool TrySyncDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a1a974*/ void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls);
            static /*0x7a1a9f4*/ bool TryResetDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a1aac4*/ void PauseHaptics();
            static /*0x7a1abf4*/ void ResumeHaptics();
            static /*0x7a1ad28*/ void ResetHaptics();
            static /*0x7a1ae5c*/ void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage);
            static /*0x7a1aee0*/ void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x7a1af64*/ void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage);
            static /*0x7a1b004*/ void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x7a1b088*/ void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, string usage);
            static /*0x7a1b128*/ void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            static /*0x7a1b1ac*/ UnityEngine.InputSystem.InputControl FindControl(string path);
            static /*0x7a1b2e8*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(string path);
            static /*0x3907c14*/ UnityEngine.InputSystem.InputControlList<TControl> FindControls<TControl>(string path);
            static /*0x3827170*/ int FindControls<TControl>(string path, ref UnityEngine.InputSystem.InputControlList<TControl> controls);
            static /*0x7a1b378*/ bool get_isProcessingEvents();
            static /*0x7a1b3dc*/ UnityEngine.InputSystem.LowLevel.InputEventListener get_onEvent();
            static /*0x7a1b3e4*/ void set_onEvent(UnityEngine.InputSystem.LowLevel.InputEventListener value);
            static /*0x7a1b3e8*/ System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress();
            static /*0x7a1b5fc*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x3837da0*/ void QueueEvent<TEvent>(ref TEvent inputEvent);
            static /*0x3907c14*/ void QueueStateEvent<TState>(UnityEngine.InputSystem.InputDevice device, TState state, double time);
            static /*0x3907c14*/ void QueueDeltaStateEvent<TDelta>(UnityEngine.InputSystem.InputControl control, TDelta delta, double time);
            static /*0x7a1b6d8*/ void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, double time);
            static /*0x7a1b8e8*/ void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, char character, double time);
            static /*0x7a1bb08*/ void Update();
            static /*0x7a1bb6c*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            static /*0x7a1bd20*/ void add_onBeforeUpdate(System.Action value);
            static /*0x7a1be4c*/ void remove_onBeforeUpdate(System.Action value);
            static /*0x7a1bf78*/ void add_onAfterUpdate(System.Action value);
            static /*0x7a1c0a4*/ void remove_onAfterUpdate(System.Action value);
            static /*0x7a1bcbc*/ UnityEngine.InputSystem.InputSettings get_settings();
            static /*0x7a1c1d0*/ void set_settings(UnityEngine.InputSystem.InputSettings value);
            static /*0x7a1c310*/ void add_onSettingsChange(System.Action value);
            static /*0x7a1c37c*/ void remove_onSettingsChange(System.Action value);
            static /*0x7a1c3e8*/ void EnableActions();
            static /*0x7a1c50c*/ void DisableActions(bool triggerSetupChanged);
            static /*0x7a1c4a4*/ UnityEngine.InputSystem.InputActionAsset get_actions();
            static /*0x7a1c5cc*/ void set_actions(UnityEngine.InputSystem.InputActionAsset value);
            static /*0x7a1c71c*/ void add_onActionsChange(System.Action value);
            static /*0x7a1c788*/ void remove_onActionsChange(System.Action value);
            static /*0x7a1c7f4*/ void add_onActionChange(System.Action<object, UnityEngine.InputSystem.InputActionChange> value);
            static /*0x7a1c8b8*/ void remove_onActionChange(System.Action<object, UnityEngine.InputSystem.InputActionChange> value);
            static /*0x7a1c97c*/ void RegisterInteraction(System.Type type, string name);
            static /*0x3837da0*/ void RegisterInteraction<T>(string name);
            static /*0x7a1caf8*/ System.Type TryGetInteraction(string name);
            static /*0x7a1cbd0*/ System.Collections.Generic.IEnumerable<string> ListInteractions();
            static /*0x7a1cc48*/ void RegisterBindingComposite(System.Type type, string name);
            static /*0x3837da0*/ void RegisterBindingComposite<T>(string name);
            static /*0x7a1cdc4*/ System.Type TryGetBindingComposite(string name);
            static /*0x7a1ce9c*/ void DisableAllEnabledActions();
            static /*0x7a1ceec*/ System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions();
            static /*0x7a1cf88*/ int ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions);
            static /*0x7a1d02c*/ UnityEngine.InputSystem.InputRemoting get_remoting();
            static /*0x7a1d084*/ System.Version get_version();
            static /*0x7a1d0f0*/ bool get_runInBackground();
            static /*0x7a1d1c4*/ void set_runInBackground(bool value);
            static /*0x7a1d2a0*/ float get_scrollWheelDeltaPerTick();
            static /*0x7a1d35c*/ UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics();
            static /*0x7a1d60c*/ void RunInitializeInPlayer();
            static /*0x7a16034*/ void EnsureInitialized();
            static /*0x7a1d46c*/ void InitializeInPlayer(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings);
            static /*0x7a1d6c0*/ void RunInitialUpdate();
            static /*0x7a1d688*/ void PerformDefaultPluginInitialization();

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

                static /*0x7a1d710*/ <>c();
                /*0x7a1d778*/ <>c();
                /*0x7a1d780*/ UnityEngine.InputSystem.InputControl <get_onAnyButtonPress>b__80_0(UnityEngine.InputSystem.LowLevel.InputEventPtr e);
                /*0x7a1d930*/ bool <get_onAnyButtonPress>b__80_1(UnityEngine.InputSystem.InputControl c);
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

            static /*0x7a1d93c*/ CommonUsages();
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

            /*0x7a1ec28*/ InputControl();
            /*0x7a1e138*/ string get_name();
            /*0x7a1e148*/ string get_displayName();
            /*0x7a1e1d4*/ void set_displayName(string value);
            /*0x7a1e1dc*/ string get_shortDisplayName();
            /*0x7a1e220*/ void set_shortDisplayName(string value);
            /*0x7a1e228*/ string get_path();
            /*0x7a1e35c*/ string get_layout();
            /*0x7a1e36c*/ string get_variants();
            /*0x7a1e37c*/ UnityEngine.InputSystem.InputDevice get_device();
            /*0x7a1e384*/ UnityEngine.InputSystem.InputControl get_parent();
            /*0x7a1e38c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children();
            /*0x7a1e3fc*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages();
            /*0x7a1e46c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases();
            /*0x7a1e4dc*/ UnityEngine.InputSystem.LowLevel.InputStateBlock get_stateBlock();
            /*0x7a1e4e8*/ bool get_noisy();
            /*0x7a1e4f4*/ void set_noisy(bool value);
            /*0x7a1e5cc*/ bool get_synthetic();
            /*0x7a1e5d8*/ void set_synthetic(bool value);
            /*0x7a1e5f8*/ UnityEngine.InputSystem.InputControl get_Item(string path);
            /*0x380b9e8*/ System.Type get_valueType();
            /*0x380b6a0*/ int get_valueSizeInBytes();
            /*0x7a1e6d8*/ float get_magnitude();
            /*0x7a1e708*/ string ToString();
            /*0x7a1e770*/ string DebuggerDisplay();
            /*0x7a1e6dc*/ float EvaluateMagnitude();
            /*0x7a1e920*/ float EvaluateMagnitude(void* statePtr);
            /*0x3907c14*/ object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
            /*0x3907c14*/ object ReadValueFromStateAsObject(void* statePtr);
            /*0x3907c14*/ void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
            /*0x7a1e928*/ void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr);
            /*0x7a1e988*/ void WriteValueFromObjectIntoState(object value, void* statePtr);
            /*0x3907c14*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
            /*0x7a1e9e8*/ UnityEngine.InputSystem.InputControl TryGetChildControl(string path);
            /*0x3907c14*/ TControl TryGetChildControl<TControl>(string path);
            /*0x7a1ea68*/ UnityEngine.InputSystem.InputControl GetChildControl(string path);
            /*0x3907c14*/ TControl GetChildControl<TControl>(string path);
            /*0x7a1ec94*/ void FinishSetup();
            /*0x7a1e1a0*/ void RefreshConfigurationIfNeeded();
            /*0x7a1ecb4*/ void RefreshConfiguration();
            /*0x7a1e90c*/ void* get_currentStatePtr();
            /*0x7a1ee0c*/ void* get_previousFrameStatePtr();
            /*0x7a1ee20*/ void* get_defaultStatePtr();
            /*0x7a1ee68*/ void* get_noiseMaskPtr();
            /*0x7a1eeb0*/ uint get_stateOffsetRelativeToDeviceRoot();
            /*0x7a1ef18*/ UnityEngine.InputSystem.Utilities.FourCC get_optimizedControlDataType();
            /*0x7a1ef20*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            /*0x7a1ef28*/ void ApplyParameterChanges();
            /*0x7a1f19c*/ void SetOptimizedControlDataType();
            /*0x7a1f22c*/ void SetOptimizedControlDataTypeRecursively();
            /*0x7a1f428*/ void EnsureOptimizationTypeHasNotChanged();
            /*0x7a1f814*/ bool get_isSetupFinished();
            /*0x7a1f820*/ void set_isSetupFinished(bool value);
            /*0x7a1f840*/ bool get_isButton();
            /*0x7a1f84c*/ void set_isButton(bool value);
            /*0x7a1ec98*/ bool get_isConfigUpToDate();
            /*0x7a1eca4*/ void set_isConfigUpToDate(bool value);
            /*0x7a1f86c*/ bool get_dontReset();
            /*0x7a1f878*/ void set_dontReset(bool value);
            /*0x7a1f898*/ bool get_usesStateFromOtherControl();
            /*0x7a1f8a4*/ void set_usesStateFromOtherControl(bool value);
            /*0x7a1f8c4*/ bool get_hasDefaultState();
            /*0x7a1f8e4*/ void CallFinishSetupRecursive();
            /*0x7a1eb7c*/ string MakeChildPath(string path);
            /*0x7a1f9a4*/ void BakeOffsetIntoStateBlockRecursive(uint offset);
            /*0x7a1ecb8*/ int GetDeviceIndex();
            /*0x7a1fa84*/ bool IsValueConsideredPressed(float value);
            /*0x7a1fb2c*/ void AddProcessor(object first);
            /*0x7a1fb30*/ void MarkAsStale();
            /*0x7a1efd4*/ void MarkAsStaleRecursively();

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

            static /*0x381cca4*/ bool CompareValue(ref TValue firstValue, ref TValue secondValue);
            /*0x380cb08*/ InputControl();
            /*0x380b9e8*/ System.Type get_valueType();
            /*0x380b6a0*/ int get_valueSizeInBytes();
            /*0x380b9e8*/ ref TValue get_value();
            /*0x380b9e8*/ ref TValue get_unprocessedValue();
            /*0x3907c14*/ TValue ReadValue();
            /*0x3907c14*/ TValue ReadValueFromPreviousFrame();
            /*0x3907c14*/ TValue ReadDefaultValue();
            /*0x3907c14*/ TValue ReadValueFromState(void* statePtr);
            /*0x3907c14*/ TValue ReadValueFromStateWithCaching(void* statePtr);
            /*0x3907c14*/ TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr);
            /*0x3907c14*/ TValue ReadUnprocessedValue();
            /*0x3907c14*/ TValue ReadUnprocessedValueFromState(void* statePtr);
            /*0x3907c14*/ object ReadValueFromStateAsObject(void* statePtr);
            /*0x3907c14*/ void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
            /*0x3907c14*/ void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr);
            /*0x3907c14*/ void WriteValueFromObjectIntoState(object value, void* statePtr);
            /*0x3907c14*/ void WriteValueIntoState(TValue value, void* statePtr);
            /*0x3907c14*/ object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
            /*0x3907c14*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
            /*0x3907c14*/ TValue ProcessValue(TValue value);
            /*0x380d83c*/ void ProcessValue(ref TValue value);
            /*0x3907c14*/ TProcessor TryGetProcessor<TProcessor>();
            /*0x380d83c*/ void AddProcessor(object processor);
            /*0x380cb08*/ void FinishSetup();
            /*0x380b9e8*/ UnityEngine.InputSystem.InputProcessor<TValue> get_processors();
        }

        class InputControlExtensions
        {
            static /*0x3907c14*/ TControl FindInParentChain<TControl>(UnityEngine.InputSystem.InputControl control);
            static /*0x7a1fb3c*/ bool IsPressed(UnityEngine.InputSystem.InputControl control, float buttonPressPoint);
            static /*0x7a1fc80*/ bool IsActuated(UnityEngine.InputSystem.InputControl control, float threshold);
            static /*0x7a1e894*/ object ReadValueAsObject(UnityEngine.InputSystem.InputControl control);
            static /*0x7a1fdc0*/ void ReadValueIntoBuffer(UnityEngine.InputSystem.InputControl control, void* buffer, int bufferSize);
            static /*0x7a1fe74*/ object ReadDefaultValueAsObject(UnityEngine.InputSystem.InputControl control);
            static /*0x3907c14*/ TValue ReadValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent);
            static bool ReadValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, ref TValue value);
            static /*0x7a1ff18*/ object ReadValueFromEventAsObject(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent);
            static /*0x3907c14*/ TValue ReadUnprocessedValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static bool ReadUnprocessedValueFromEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, ref TValue value);
            static /*0x7a20050*/ void WriteValueFromObjectIntoEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, object value);
            static /*0x7a200e0*/ void WriteValueIntoState(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x3907c14*/ void WriteValueIntoState<TValue>(UnityEngine.InputSystem.InputControl control, TValue value, void* statePtr);
            static /*0x3907c14*/ void WriteValueIntoState<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, void* statePtr);
            static /*0x3907c14*/ void WriteValueIntoState<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, void* statePtr);
            static /*0x3907c14*/ void WriteValueIntoState<TValue, TState>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, ref TState state);
            static /*0x3907c14*/ void WriteValueIntoEvent<TValue>(UnityEngine.InputSystem.InputControl control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x3907c14*/ void WriteValueIntoEvent<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x7a20274*/ void CopyState(UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes);
            static /*0x383af28*/ void CopyState<TState>(UnityEngine.InputSystem.InputDevice device, ref TState state);
            static /*0x7a1fd4c*/ bool CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control);
            static /*0x7a203f8*/ bool CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control, void* statePtr, void* maskPtr);
            static /*0x7a20638*/ bool CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control);
            static /*0x7a206a8*/ bool CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x7a20770*/ bool CompareStateIgnoringNoise(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x7a204d0*/ bool CompareState(UnityEngine.InputSystem.InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr);
            static /*0x7a20854*/ bool CompareState(UnityEngine.InputSystem.InputControl control, void* statePtr, void* maskPtr);
            static /*0x7a20900*/ bool HasValueChangeInState(UnityEngine.InputSystem.InputControl control, void* statePtr);
            static /*0x7a209ac*/ bool HasValueChangeInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x7a1ff98*/ void* GetStatePtrFromStateEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x7a20a84*/ void* GetStatePtrFromStateEventUnchecked(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.Utilities.FourCC eventType);
            static /*0x7a20d88*/ bool ResetToDefaultStateInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            static /*0x3907c14*/ void QueueValueChange<TValue>(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, double time);
            static /*0x7a20f3c*/ void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<float> control, void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState);
            static /*0x7a21038*/ void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState);
            static /*0x383bc84*/ void FindControlsRecursive<TControl>(UnityEngine.InputSystem.InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl, bool> predicate);
            static /*0x7a21138*/ string BuildPath(UnityEngine.InputSystem.InputControl control, string deviceLayout, System.Text.StringBuilder builder);
            static /*0x7a2140c*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, UnityEngine.InputSystem.InputDevice device, float magnitudeThreshold);
            static /*0x7a2162c*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateChangedControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, float magnitudeThreshold);
            static /*0x7a21664*/ bool HasButtonPress(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly);
            static /*0x7a1d790*/ UnityEngine.InputSystem.InputControl GetFirstButtonPressOrNull(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly);
            static /*0x7a21a68*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly);
            static /*0x7a21b30*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder Setup(UnityEngine.InputSystem.InputControl control);
            static /*0x7a21c08*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder Setup(UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount);

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

                /*0x7a21e4c*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_eventPtr();
                /*0x7a21680*/ UnityEngine.InputSystem.InputControlExtensions.InputEventControlEnumerator GetEnumerator();
                /*0x7a2204c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator();
                /*0x7a220f0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                /*0x7a21e54*/ InputEventControlEnumerator(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, float magnitudeThreshold);
                /*0x7a225f0*/ bool CheckDefault(uint numBits);
                /*0x7a22614*/ bool CheckCurrent(uint numBits);
                /*0x7a216a8*/ bool MoveNext();
                /*0x7a22194*/ void Reset();
                /*0x7a22650*/ void Dispose();
                /*0x7a22658*/ UnityEngine.InputSystem.InputControl get_Current();
                /*0x7a22660*/ object System.Collections.IEnumerator.get_Current();
            }

            struct ControlBuilder
            {
                /*0x10*/ UnityEngine.InputSystem.InputControl <control>k__BackingField;

                /*0x7a22668*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x7a22670*/ void set_control(UnityEngine.InputSystem.InputControl value);
                /*0x7a22678*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder At(UnityEngine.InputSystem.InputDevice device, int index);
                /*0x7a22710*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithParent(UnityEngine.InputSystem.InputControl parent);
                /*0x7a22738*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithName(string name);
                /*0x7a2278c*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDisplayName(string displayName);
                /*0x7a227e8*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithShortDisplayName(string shortDisplayName);
                /*0x7a22844*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout);
                /*0x7a22874*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithUsages(int startIndex, int count);
                /*0x7a22894*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithAliases(int startIndex, int count);
                /*0x7a228b4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithChildren(int startIndex, int count);
                /*0x7a228d4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock);
                /*0x7a228f4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x7a22950*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithMinAndMax(UnityEngine.InputSystem.Utilities.PrimitiveValue min, UnityEngine.InputSystem.Utilities.PrimitiveValue max);
                /*0x3907c14*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor);
                /*0x7a2297c*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsNoisy(bool value);
                /*0x7a229a4*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsSynthetic(bool value);
                /*0x7a229dc*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder DontReset(bool value);
                /*0x7a22a4c*/ UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsButton(bool value);
                /*0x7a22a84*/ void Finish();
            }

            struct DeviceBuilder
            {
                /*0x10*/ UnityEngine.InputSystem.InputDevice <device>k__BackingField;

                /*0x7a22aa8*/ UnityEngine.InputSystem.InputDevice get_device();
                /*0x7a22ab0*/ void set_device(UnityEngine.InputSystem.InputDevice value);
                /*0x7a22ab8*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithName(string name);
                /*0x7a22b0c*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithDisplayName(string displayName);
                /*0x7a22b68*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithShortDisplayName(string shortDisplayName);
                /*0x7a22bc4*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout);
                /*0x7a22bf4*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithChildren(int startIndex, int count);
                /*0x7a22c14*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock);
                /*0x7a22c34*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder IsNoisy(bool value);
                /*0x7a22c5c*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlUsage(int controlIndex, UnityEngine.InputSystem.Utilities.InternedString usage, UnityEngine.InputSystem.InputControl control);
                /*0x7a22d14*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlAlias(int controlIndex, UnityEngine.InputSystem.Utilities.InternedString alias);
                /*0x7a22d64*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map);
                /*0x7a22d90*/ UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies);
                /*0x7a22ecc*/ void Finish();
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

                /*0x7a21afc*/ <GetAllButtonPresses>d__43(int <>1__state);
                /*0x7a231a8*/ void System.IDisposable.Dispose();
                /*0x7a231cc*/ bool MoveNext();
                /*0x7a23430*/ void <>m__Finally1();
                /*0x7a23440*/ UnityEngine.InputSystem.InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current();
                /*0x7a23448*/ void System.Collections.IEnumerator.Reset();
                /*0x7a23480*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a23488*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator();
                /*0x7a23534*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x3907c14*/ ulong ToIndex(TControl control);
            static /*0x3907c14*/ TControl FromIndex(ulong index);
            /*0x380d0e4*/ InputControlList(Unity.Collections.Allocator allocator, int initialCapacity);
            /*0x380d8b8*/ InputControlList(System.Collections.Generic.IEnumerable<TControl> values, Unity.Collections.Allocator allocator);
            /*0x380d83c*/ InputControlList(TControl[] values);
            /*0x380b6a0*/ int get_Count();
            /*0x380b6a0*/ int get_Capacity();
            /*0x380cffc*/ void set_Capacity(int value);
            /*0x380b128*/ bool get_IsReadOnly();
            /*0x3907c14*/ TControl get_Item(int index);
            /*0x3907c14*/ void set_Item(int index, TControl value);
            /*0x380cffc*/ void Resize(int size);
            /*0x3907c14*/ void Add(TControl item);
            /*0x3907c14*/ void AddSlice<TList>(TList list, int count, int destinationIndex, int sourceIndex);
            void AddRange(System.Collections.Generic.IEnumerable<TControl> list, int count, int destinationIndex);
            /*0x3907c14*/ bool Remove(TControl item);
            /*0x380cffc*/ void RemoveAt(int index);
            /*0x380d8b8*/ void CopyTo(TControl[] array, int arrayIndex);
            /*0x3907c14*/ int IndexOf(TControl item);
            /*0x3907c14*/ int IndexOf(TControl item, int startIndex, int count);
            /*0x3907c14*/ void Insert(int index, TControl item);
            /*0x380cb08*/ void Clear();
            /*0x3907c14*/ bool Contains(TControl item);
            /*0x3907c14*/ bool Contains(TControl item, int startIndex, int count);
            /*0x380d0e4*/ void SwapElements(int index1, int index2);
            /*0x3907c14*/ void Sort<TCompare>(int startIndex, int count, TCompare comparer);
            TControl[] ToArray(bool dispose);
            /*0x380d93c*/ void AppendTo(ref TControl[] array, ref int count);
            /*0x380cb08*/ void Dispose();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TControl> GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x380b9e8*/ string ToString();

            struct Enumerator<TControl> : System.Collections.Generic.IEnumerator<TControl>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ ulong* m_Indices;
                /*0x0*/ int m_Count;
                /*0x0*/ int m_Current;

                /*0x3907c14*/ Enumerator(UnityEngine.InputSystem.InputControlList<TControl> list);
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Reset();
                /*0x3907c14*/ TControl get_Current();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                /*0x380cb08*/ void Dispose();
            }
        }

        class InputControlPath
        {
            static string Wildcard = "*";
            static string DoubleWildcard = "**";
            static char Separator = 47;
            static char SeparatorReplacement = 32;

            static /*0x7a23538*/ string CleanSlashes(string pathComponent);
            static /*0x7a1e27c*/ string Combine(UnityEngine.InputSystem.InputControl parent, string path);
            static /*0x7a23554*/ string ToHumanReadableString(string path, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control);
            static /*0x7a23580*/ string ToHumanReadableString(string path, ref string deviceLayoutName, ref string controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control);
            static /*0x7a245b8*/ string[] TryGetDeviceUsages(string path);
            static /*0x7a24750*/ string TryGetDeviceLayout(string path);
            static /*0x7a248e4*/ string TryGetControlLayout(string path);
            static /*0x7a24af8*/ string FindControlLayoutRecursive(ref UnityEngine.InputSystem.InputControlPath.PathParser parser, string layoutName);
            static /*0x7a24c68*/ string FindControlLayoutRecursive(ref UnityEngine.InputSystem.InputControlPath.PathParser parser, UnityEngine.InputSystem.Layouts.InputControlLayout layout);
            static /*0x7a24e00*/ bool ControlLayoutMatchesPathComponent(ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, ref UnityEngine.InputSystem.InputControlPath.PathParser parser);
            static /*0x7a24fb8*/ bool StringMatches(UnityEngine.InputSystem.Utilities.Substring str, UnityEngine.InputSystem.Utilities.InternedString matchTo);
            static /*0x7a16d60*/ UnityEngine.InputSystem.InputControl TryFindControl(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x7a25214*/ UnityEngine.InputSystem.InputControl[] TryFindControls(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x7a25370*/ int TryFindControls(UnityEngine.InputSystem.InputControl control, string path, ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> matches, int indexInPath);
            static /*0x3907c14*/ TControl TryFindControl<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x3907c14*/ int TryFindControls<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches);
            static /*0x7a1e678*/ UnityEngine.InputSystem.InputControl TryFindChild(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x3907c14*/ TControl TryFindChild<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath);
            static /*0x7a239f0*/ bool Matches(string expected, UnityEngine.InputSystem.InputControl control);
            static /*0x7a25448*/ bool MatchControlComponent(ref UnityEngine.InputSystem.InputControlPath.ParsedPathComponent expectedControlComponent, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, bool matchAlias);
            static /*0x7a25858*/ bool MatchesPrefix(string expected, UnityEngine.InputSystem.InputControl control);
            static /*0x7a253e0*/ bool MatchesRecursive(ref UnityEngine.InputSystem.InputControlPath.PathParser parser, UnityEngine.InputSystem.InputControl currentControl, bool prefixOnly);
            static /*0x3907c14*/ TControl MatchControlsRecursive<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple);
            static /*0x3907c14*/ TControl MatchByUsageAtDeviceRootRecursive<TControl>(UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple);
            static /*0x3907c14*/ TControl MatchChildrenRecursive<TControl>(UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple);
            static /*0x7a25bf4*/ bool MatchPathComponent(string component, string path, ref int indexInPath, UnityEngine.InputSystem.InputControlPath.PathComponentType componentType, int startIndexInComponent);
            static /*0x7a25e7c*/ bool PathComponentCanYieldMultipleMatches(string path, int indexInPath);
            static /*0x7a25f38*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(string path);

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

                static /*0x7a261a4*/ string ToHumanReadableString(UnityEngine.InputSystem.Utilities.Substring substring);
                static /*0x7a26208*/ bool ComparePathElementToString(UnityEngine.InputSystem.Utilities.Substring pathElement, string element);
                /*0x7a25fe8*/ string get_layout();
                /*0x7a25ff0*/ System.Collections.Generic.IEnumerable<string> get_usages();
                /*0x7a26128*/ string get_name();
                /*0x7a26134*/ string get_displayName();
                /*0x7a24880*/ bool get_isWildcard();
                /*0x7a26140*/ bool get_isDoubleWildcard();
                /*0x7a23e14*/ string ToHumanReadableString(string parentLayoutName, string parentControlPath, ref string referencedLayoutName, ref string controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options);
                /*0x7a25944*/ bool Matches(UnityEngine.InputSystem.InputControl control);

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.Substring, string> <>9__7_0;

                    static /*0x7a26344*/ <>c();
                    /*0x7a263ac*/ <>c();
                    /*0x7a263b4*/ string <get_usages>b__7_0(UnityEngine.InputSystem.Utilities.Substring x);
                }
            }

            struct PathParser
            {
                /*0x10*/ string path;
                /*0x18*/ int length;
                /*0x1c*/ int leftIndexInPath;
                /*0x20*/ int rightIndexInPath;
                /*0x28*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent current;

                /*0x7a23ac0*/ PathParser(string path);
                /*0x7a24fa4*/ bool get_isAtEnd();
                /*0x7a23b10*/ bool MoveToNextComponent();
                /*0x7a263d8*/ UnityEngine.InputSystem.Utilities.Substring ParseComponentPart(char terminator);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputControlPath.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.Substring, string> <>9__9_0;

                static /*0x7a264e0*/ <>c();
                /*0x7a26548*/ <>c();
                /*0x7a26550*/ string <TryGetDeviceUsages>b__9_0(UnityEngine.InputSystem.Utilities.Substring x);
            }

            class <Parse>d__34 : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent <>2__current;
                /*0x68*/ int <>l__initialThreadId;
                /*0x70*/ string path;
                /*0x78*/ string <>3__path;
                /*0x80*/ UnityEngine.InputSystem.InputControlPath.PathParser <parser>5__2;

                /*0x7a25fb4*/ <Parse>d__34(int <>1__state);
                /*0x7a26574*/ void System.IDisposable.Dispose();
                /*0x7a26578*/ bool MoveNext();
                /*0x7a26690*/ UnityEngine.InputSystem.InputControlPath.ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current();
                /*0x7a266a0*/ void System.Collections.IEnumerator.Reset();
                /*0x7a266d8*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a2673c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator();
                /*0x7a267e0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class InputProcessor
        {
            static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable s_Processors;

            static /*0x7a267e4*/ System.Type GetValueTypeFromType(System.Type processorType);
            /*0x7a268d0*/ InputProcessor();
            /*0x380bcbc*/ object ProcessAsObject(object value, UnityEngine.InputSystem.InputControl control);
            /*0x3907c14*/ void Process(void* buffer, int bufferSize, UnityEngine.InputSystem.InputControl control);
            /*0x7a268c8*/ UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy();

            enum CachingPolicy
            {
                CacheResult = 0,
                EvaluateOnEveryRead = 1,
            }
        }

        class InputProcessor<TValue> : UnityEngine.InputSystem.InputProcessor
        {
            /*0x380cb08*/ InputProcessor();
            /*0x3907c14*/ TValue Process(TValue value, UnityEngine.InputSystem.InputControl control);
            /*0x380bcbc*/ object ProcessAsObject(object value, UnityEngine.InputSystem.InputControl control);
            /*0x3907c14*/ void Process(void* buffer, int bufferSize, UnityEngine.InputSystem.InputControl control);
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

            static /*0x7a26be4*/ UnityEngine.InputSystem.Gamepad get_current();
            static /*0x7a26c2c*/ void set_current(UnityEngine.InputSystem.Gamepad value);
            static /*0x7a26c84*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all();
            /*0x7a272d0*/ Gamepad();
            /*0x7a268d8*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonWest();
            /*0x7a268e0*/ void set_buttonWest(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a268f0*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonNorth();
            /*0x7a268f8*/ void set_buttonNorth(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26908*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonSouth();
            /*0x7a26910*/ void set_buttonSouth(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26920*/ UnityEngine.InputSystem.Controls.ButtonControl get_buttonEast();
            /*0x7a26928*/ void set_buttonEast(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26938*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftStickButton();
            /*0x7a26940*/ void set_leftStickButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26950*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightStickButton();
            /*0x7a26958*/ void set_rightStickButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26968*/ UnityEngine.InputSystem.Controls.ButtonControl get_startButton();
            /*0x7a26970*/ void set_startButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26980*/ UnityEngine.InputSystem.Controls.ButtonControl get_selectButton();
            /*0x7a26988*/ void set_selectButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26998*/ UnityEngine.InputSystem.Controls.DpadControl get_dpad();
            /*0x7a269a0*/ void set_dpad(UnityEngine.InputSystem.Controls.DpadControl value);
            /*0x7a269b0*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftShoulder();
            /*0x7a269b8*/ void set_leftShoulder(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a269c8*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightShoulder();
            /*0x7a269d0*/ void set_rightShoulder(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a269e0*/ UnityEngine.InputSystem.Controls.StickControl get_leftStick();
            /*0x7a269e8*/ void set_leftStick(UnityEngine.InputSystem.Controls.StickControl value);
            /*0x7a269f8*/ UnityEngine.InputSystem.Controls.StickControl get_rightStick();
            /*0x7a26a00*/ void set_rightStick(UnityEngine.InputSystem.Controls.StickControl value);
            /*0x7a26a10*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftTrigger();
            /*0x7a26a18*/ void set_leftTrigger(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26a28*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightTrigger();
            /*0x7a26a30*/ void set_rightTrigger(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a26a40*/ UnityEngine.InputSystem.Controls.ButtonControl get_aButton();
            /*0x7a26a48*/ UnityEngine.InputSystem.Controls.ButtonControl get_bButton();
            /*0x7a26a50*/ UnityEngine.InputSystem.Controls.ButtonControl get_xButton();
            /*0x7a26a58*/ UnityEngine.InputSystem.Controls.ButtonControl get_yButton();
            /*0x7a26a60*/ UnityEngine.InputSystem.Controls.ButtonControl get_triangleButton();
            /*0x7a26a68*/ UnityEngine.InputSystem.Controls.ButtonControl get_squareButton();
            /*0x7a26a70*/ UnityEngine.InputSystem.Controls.ButtonControl get_circleButton();
            /*0x7a26a78*/ UnityEngine.InputSystem.Controls.ButtonControl get_crossButton();
            /*0x7a26a80*/ UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.LowLevel.GamepadButton button);
            /*0x7a26d04*/ void FinishSetup();
            /*0x7a27094*/ void MakeCurrent();
            /*0x7a270f0*/ void OnAdded();
            /*0x7a27168*/ void OnRemoved();
            /*0x7a27290*/ void PauseHaptics();
            /*0x7a272a0*/ void ResumeHaptics();
            /*0x7a272b0*/ void ResetHaptics();
            /*0x7a272c0*/ void SetMotorSpeeds(float lowFrequency, float highFrequency);
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

            static /*0x7a2763c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all();
            static /*0x7a27c60*/ uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits);
            static /*0x7a22634*/ void DecodeStateOffsetToControlMapEntry(uint entry, ref uint controlIndex, ref uint stateOffset, ref uint stateSize);
            static /*0x3907c14*/ TDevice Build<TDevice>(string layoutName, string layoutVariants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, bool noPrecompiledLayouts);
            static /*0x7a28e14*/ bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits);
            /*0x7a272f0*/ InputDevice();
            /*0x7a27310*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription get_description();
            /*0x7a2732c*/ bool get_enabled();
            /*0x7a273f0*/ bool get_canRunInBackground();
            /*0x7a273f4*/ bool get_canDeviceRunInBackground();
            /*0x7a16038*/ bool get_added();
            /*0x7a274ac*/ bool get_remote();
            /*0x7a274b8*/ bool get_native();
            /*0x7a274c4*/ bool get_updateBeforeRender();
            /*0x7a274d0*/ int get_deviceId();
            /*0x7a274d8*/ double get_lastUpdateTime();
            /*0x7a2752c*/ bool get_wasUpdatedThisFrame();
            /*0x7a23148*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls();
            /*0x7a27584*/ System.Type get_valueType();
            /*0x7a275e4*/ int get_valueSizeInBytes();
            /*0x7a27688*/ object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
            /*0x7a276c0*/ object ReadValueFromStateAsObject(void* statePtr);
            /*0x7a277c8*/ void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
            /*0x7a2797c*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
            /*0x7a27a7c*/ void NotifyConfigurationChanged();
            /*0x7a270ec*/ void MakeCurrent();
            /*0x7a27af8*/ void OnAdded();
            /*0x7a27afc*/ void OnRemoved();
            /*0x7a27b00*/ void OnConfigurationChanged();
            long ExecuteCommand<TCommand>(ref TCommand command);
            /*0x7a27b04*/ long ExecuteCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr);
            /*0x7a27348*/ bool QueryEnabledStateFromRuntime();
            /*0x7a27bdc*/ bool get_disabledInFrontend();
            /*0x7a27be8*/ void set_disabledInFrontend(bool value);
            /*0x7a27c08*/ bool get_disabledInRuntime();
            /*0x7a27c14*/ void set_disabledInRuntime(bool value);
            /*0x7a27c34*/ bool get_disabledWhileInBackground();
            /*0x7a27c40*/ void set_disabledWhileInBackground(bool value);
            /*0x7a27c6c*/ bool get_hasControlsWithDefaultState();
            /*0x7a22930*/ void set_hasControlsWithDefaultState(bool value);
            /*0x7a27c78*/ bool get_hasDontResetControls();
            /*0x7a22a2c*/ void set_hasDontResetControls(bool value);
            /*0x7a20d7c*/ bool get_hasStateCallbacks();
            /*0x7a27c84*/ void set_hasStateCallbacks(bool value);
            /*0x7a27ca4*/ bool get_hasEventMerger();
            /*0x7a27cb0*/ void set_hasEventMerger(bool value);
            /*0x7a27cd0*/ bool get_hasEventPreProcessor();
            /*0x7a27cdc*/ void set_hasEventPreProcessor(bool value);
            /*0x7a27cfc*/ void AddDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a27db4*/ void RemoveDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a27e94*/ void ClearDeviceUsages();
            /*0x7a1a8f8*/ bool RequestSync();
            /*0x7a1aa48*/ bool RequestReset();
            /*0x7a27ef4*/ bool ExecuteEnableCommand();
            /*0x7a27f70*/ bool ExecuteDisableCommand();
            /*0x7a27fe0*/ void NotifyAdded();
            /*0x7a27ff0*/ void NotifyRemoved();
            /*0x7a28000*/ void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice);
            /*0x7a28154*/ void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset);
            /*0x7a287fc*/ void DumpControlBitRangeNode(int nodeIndex, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode node, uint startOffset, uint sizeInBits, System.Collections.Generic.List<string> output);
            /*0x7a28c24*/ void DumpControlTree(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset, System.Collections.Generic.List<string> output);
            /*0x7a28d48*/ string DumpControlTree();
            /*0x7a28488*/ void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset);

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

                /*0x7a29578*/ ControlBitRangeNode(ushort endOffset);
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

            static /*0x7a295ec*/ UnityEngine.InputSystem.Joystick get_current();
            static /*0x7a29634*/ void set_current(UnityEngine.InputSystem.Joystick value);
            static /*0x7a2968c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all();
            /*0x7a29a8c*/ Joystick();
            /*0x7a2958c*/ UnityEngine.InputSystem.Controls.ButtonControl get_trigger();
            /*0x7a29594*/ void set_trigger(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a295a4*/ UnityEngine.InputSystem.Controls.StickControl get_stick();
            /*0x7a295ac*/ void set_stick(UnityEngine.InputSystem.Controls.StickControl value);
            /*0x7a295bc*/ UnityEngine.InputSystem.Controls.AxisControl get_twist();
            /*0x7a295c4*/ void set_twist(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a295d4*/ UnityEngine.InputSystem.Controls.Vector2Control get_hatswitch();
            /*0x7a295dc*/ void set_hatswitch(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a2970c*/ void FinishSetup();
            /*0x7a29880*/ void MakeCurrent();
            /*0x7a298e0*/ void OnAdded();
            /*0x7a29958*/ void OnRemoved();
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

            static /*0x7a2a358*/ UnityEngine.InputSystem.Keyboard get_current();
            static /*0x7a2a3a0*/ void set_current(UnityEngine.InputSystem.Keyboard value);
            /*0x7a2c004*/ Keyboard();
            /*0x7a29a94*/ void add_onTextInput(System.Action<char> value);
            /*0x7a29b74*/ void remove_onTextInput(System.Action<char> value);
            /*0x7a29bcc*/ void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value);
            /*0x7a29cb0*/ void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value);
            /*0x7a29d08*/ void SetIMEEnabled(bool enabled);
            /*0x7a29d88*/ void SetIMECursorPosition(UnityEngine.Vector2 position);
            /*0x7a29e30*/ string get_keyboardLayout();
            /*0x7a29e4c*/ void set_keyboardLayout(string value);
            /*0x7a29e5c*/ UnityEngine.InputSystem.Controls.AnyKeyControl get_anyKey();
            /*0x7a29e64*/ void set_anyKey(UnityEngine.InputSystem.Controls.AnyKeyControl value);
            /*0x7a29e74*/ UnityEngine.InputSystem.Controls.KeyControl get_spaceKey();
            /*0x7a29f00*/ UnityEngine.InputSystem.Controls.KeyControl get_enterKey();
            /*0x7a29f08*/ UnityEngine.InputSystem.Controls.KeyControl get_tabKey();
            /*0x7a29f10*/ UnityEngine.InputSystem.Controls.KeyControl get_backquoteKey();
            /*0x7a29f18*/ UnityEngine.InputSystem.Controls.KeyControl get_quoteKey();
            /*0x7a29f20*/ UnityEngine.InputSystem.Controls.KeyControl get_semicolonKey();
            /*0x7a29f28*/ UnityEngine.InputSystem.Controls.KeyControl get_commaKey();
            /*0x7a29f30*/ UnityEngine.InputSystem.Controls.KeyControl get_periodKey();
            /*0x7a29f38*/ UnityEngine.InputSystem.Controls.KeyControl get_slashKey();
            /*0x7a29f40*/ UnityEngine.InputSystem.Controls.KeyControl get_backslashKey();
            /*0x7a29f48*/ UnityEngine.InputSystem.Controls.KeyControl get_leftBracketKey();
            /*0x7a29f50*/ UnityEngine.InputSystem.Controls.KeyControl get_rightBracketKey();
            /*0x7a29f58*/ UnityEngine.InputSystem.Controls.KeyControl get_minusKey();
            /*0x7a29f60*/ UnityEngine.InputSystem.Controls.KeyControl get_equalsKey();
            /*0x7a29f68*/ UnityEngine.InputSystem.Controls.KeyControl get_aKey();
            /*0x7a29f70*/ UnityEngine.InputSystem.Controls.KeyControl get_bKey();
            /*0x7a29f78*/ UnityEngine.InputSystem.Controls.KeyControl get_cKey();
            /*0x7a29f80*/ UnityEngine.InputSystem.Controls.KeyControl get_dKey();
            /*0x7a29f88*/ UnityEngine.InputSystem.Controls.KeyControl get_eKey();
            /*0x7a29f90*/ UnityEngine.InputSystem.Controls.KeyControl get_fKey();
            /*0x7a29f98*/ UnityEngine.InputSystem.Controls.KeyControl get_gKey();
            /*0x7a29fa0*/ UnityEngine.InputSystem.Controls.KeyControl get_hKey();
            /*0x7a29fa8*/ UnityEngine.InputSystem.Controls.KeyControl get_iKey();
            /*0x7a29fb0*/ UnityEngine.InputSystem.Controls.KeyControl get_jKey();
            /*0x7a29fb8*/ UnityEngine.InputSystem.Controls.KeyControl get_kKey();
            /*0x7a29fc0*/ UnityEngine.InputSystem.Controls.KeyControl get_lKey();
            /*0x7a29fc8*/ UnityEngine.InputSystem.Controls.KeyControl get_mKey();
            /*0x7a29fd0*/ UnityEngine.InputSystem.Controls.KeyControl get_nKey();
            /*0x7a29fd8*/ UnityEngine.InputSystem.Controls.KeyControl get_oKey();
            /*0x7a29fe0*/ UnityEngine.InputSystem.Controls.KeyControl get_pKey();
            /*0x7a29fe8*/ UnityEngine.InputSystem.Controls.KeyControl get_qKey();
            /*0x7a29ff0*/ UnityEngine.InputSystem.Controls.KeyControl get_rKey();
            /*0x7a29ff8*/ UnityEngine.InputSystem.Controls.KeyControl get_sKey();
            /*0x7a2a000*/ UnityEngine.InputSystem.Controls.KeyControl get_tKey();
            /*0x7a2a008*/ UnityEngine.InputSystem.Controls.KeyControl get_uKey();
            /*0x7a2a010*/ UnityEngine.InputSystem.Controls.KeyControl get_vKey();
            /*0x7a2a018*/ UnityEngine.InputSystem.Controls.KeyControl get_wKey();
            /*0x7a2a020*/ UnityEngine.InputSystem.Controls.KeyControl get_xKey();
            /*0x7a2a028*/ UnityEngine.InputSystem.Controls.KeyControl get_yKey();
            /*0x7a2a030*/ UnityEngine.InputSystem.Controls.KeyControl get_zKey();
            /*0x7a2a038*/ UnityEngine.InputSystem.Controls.KeyControl get_digit1Key();
            /*0x7a2a040*/ UnityEngine.InputSystem.Controls.KeyControl get_digit2Key();
            /*0x7a2a048*/ UnityEngine.InputSystem.Controls.KeyControl get_digit3Key();
            /*0x7a2a050*/ UnityEngine.InputSystem.Controls.KeyControl get_digit4Key();
            /*0x7a2a058*/ UnityEngine.InputSystem.Controls.KeyControl get_digit5Key();
            /*0x7a2a060*/ UnityEngine.InputSystem.Controls.KeyControl get_digit6Key();
            /*0x7a2a068*/ UnityEngine.InputSystem.Controls.KeyControl get_digit7Key();
            /*0x7a2a070*/ UnityEngine.InputSystem.Controls.KeyControl get_digit8Key();
            /*0x7a2a078*/ UnityEngine.InputSystem.Controls.KeyControl get_digit9Key();
            /*0x7a2a080*/ UnityEngine.InputSystem.Controls.KeyControl get_digit0Key();
            /*0x7a2a088*/ UnityEngine.InputSystem.Controls.KeyControl get_leftShiftKey();
            /*0x7a2a090*/ UnityEngine.InputSystem.Controls.KeyControl get_rightShiftKey();
            /*0x7a2a098*/ UnityEngine.InputSystem.Controls.KeyControl get_leftAltKey();
            /*0x7a2a0a0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightAltKey();
            /*0x7a2a0a8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftCtrlKey();
            /*0x7a2a0b0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightCtrlKey();
            /*0x7a2a0b8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftMetaKey();
            /*0x7a2a0c0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightMetaKey();
            /*0x7a2a0c8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftWindowsKey();
            /*0x7a2a0d0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightWindowsKey();
            /*0x7a2a0d8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftAppleKey();
            /*0x7a2a0e0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightAppleKey();
            /*0x7a2a0e8*/ UnityEngine.InputSystem.Controls.KeyControl get_leftCommandKey();
            /*0x7a2a0f0*/ UnityEngine.InputSystem.Controls.KeyControl get_rightCommandKey();
            /*0x7a2a0f8*/ UnityEngine.InputSystem.Controls.KeyControl get_contextMenuKey();
            /*0x7a2a100*/ UnityEngine.InputSystem.Controls.KeyControl get_escapeKey();
            /*0x7a2a108*/ UnityEngine.InputSystem.Controls.KeyControl get_leftArrowKey();
            /*0x7a2a110*/ UnityEngine.InputSystem.Controls.KeyControl get_rightArrowKey();
            /*0x7a2a118*/ UnityEngine.InputSystem.Controls.KeyControl get_upArrowKey();
            /*0x7a2a120*/ UnityEngine.InputSystem.Controls.KeyControl get_downArrowKey();
            /*0x7a2a128*/ UnityEngine.InputSystem.Controls.KeyControl get_backspaceKey();
            /*0x7a2a130*/ UnityEngine.InputSystem.Controls.KeyControl get_pageDownKey();
            /*0x7a2a138*/ UnityEngine.InputSystem.Controls.KeyControl get_pageUpKey();
            /*0x7a2a140*/ UnityEngine.InputSystem.Controls.KeyControl get_homeKey();
            /*0x7a2a148*/ UnityEngine.InputSystem.Controls.KeyControl get_endKey();
            /*0x7a2a150*/ UnityEngine.InputSystem.Controls.KeyControl get_insertKey();
            /*0x7a2a158*/ UnityEngine.InputSystem.Controls.KeyControl get_deleteKey();
            /*0x7a2a160*/ UnityEngine.InputSystem.Controls.KeyControl get_capsLockKey();
            /*0x7a2a168*/ UnityEngine.InputSystem.Controls.KeyControl get_scrollLockKey();
            /*0x7a2a170*/ UnityEngine.InputSystem.Controls.KeyControl get_numLockKey();
            /*0x7a2a178*/ UnityEngine.InputSystem.Controls.KeyControl get_printScreenKey();
            /*0x7a2a180*/ UnityEngine.InputSystem.Controls.KeyControl get_pauseKey();
            /*0x7a2a188*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadEnterKey();
            /*0x7a2a190*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadDivideKey();
            /*0x7a2a198*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadMultiplyKey();
            /*0x7a2a1a0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadMinusKey();
            /*0x7a2a1a8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadPlusKey();
            /*0x7a2a1b0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadPeriodKey();
            /*0x7a2a1b8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpadEqualsKey();
            /*0x7a2a1c0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad0Key();
            /*0x7a2a1c8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad1Key();
            /*0x7a2a1d0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad2Key();
            /*0x7a2a1d8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad3Key();
            /*0x7a2a1e0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad4Key();
            /*0x7a2a1e8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad5Key();
            /*0x7a2a1f0*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad6Key();
            /*0x7a2a1f8*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad7Key();
            /*0x7a2a200*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad8Key();
            /*0x7a2a208*/ UnityEngine.InputSystem.Controls.KeyControl get_numpad9Key();
            /*0x7a2a210*/ UnityEngine.InputSystem.Controls.KeyControl get_f1Key();
            /*0x7a2a218*/ UnityEngine.InputSystem.Controls.KeyControl get_f2Key();
            /*0x7a2a220*/ UnityEngine.InputSystem.Controls.KeyControl get_f3Key();
            /*0x7a2a228*/ UnityEngine.InputSystem.Controls.KeyControl get_f4Key();
            /*0x7a2a230*/ UnityEngine.InputSystem.Controls.KeyControl get_f5Key();
            /*0x7a2a238*/ UnityEngine.InputSystem.Controls.KeyControl get_f6Key();
            /*0x7a2a240*/ UnityEngine.InputSystem.Controls.KeyControl get_f7Key();
            /*0x7a2a248*/ UnityEngine.InputSystem.Controls.KeyControl get_f8Key();
            /*0x7a2a250*/ UnityEngine.InputSystem.Controls.KeyControl get_f9Key();
            /*0x7a2a258*/ UnityEngine.InputSystem.Controls.KeyControl get_f10Key();
            /*0x7a2a260*/ UnityEngine.InputSystem.Controls.KeyControl get_f11Key();
            /*0x7a2a268*/ UnityEngine.InputSystem.Controls.KeyControl get_f12Key();
            /*0x7a2a270*/ UnityEngine.InputSystem.Controls.KeyControl get_oem1Key();
            /*0x7a2a278*/ UnityEngine.InputSystem.Controls.KeyControl get_oem2Key();
            /*0x7a2a280*/ UnityEngine.InputSystem.Controls.KeyControl get_oem3Key();
            /*0x7a2a288*/ UnityEngine.InputSystem.Controls.KeyControl get_oem4Key();
            /*0x7a2a290*/ UnityEngine.InputSystem.Controls.KeyControl get_oem5Key();
            /*0x7a2a298*/ UnityEngine.InputSystem.Controls.ButtonControl get_shiftKey();
            /*0x7a2a2a0*/ void set_shiftKey(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2a2b0*/ UnityEngine.InputSystem.Controls.ButtonControl get_ctrlKey();
            /*0x7a2a2b8*/ void set_ctrlKey(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2a2c8*/ UnityEngine.InputSystem.Controls.ButtonControl get_altKey();
            /*0x7a2a2d0*/ void set_altKey(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2a2e0*/ UnityEngine.InputSystem.Controls.ButtonControl get_imeSelected();
            /*0x7a2a2e8*/ void set_imeSelected(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a29e7c*/ UnityEngine.InputSystem.Controls.KeyControl get_Item(UnityEngine.InputSystem.Key key);
            /*0x7a2a2f8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys();
            /*0x7a2a3f8*/ void MakeCurrent();
            /*0x7a2a458*/ void OnRemoved();
            /*0x7a2a4f4*/ void FinishSetup();
            /*0x7a2bc9c*/ void RefreshConfiguration();
            /*0x7a2bd7c*/ void OnTextInput(char character);
            /*0x7a2be1c*/ UnityEngine.InputSystem.Controls.KeyControl FindKeyOnCurrentKeyboardLayout(string displayName);
            /*0x7a2bef0*/ void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString);
            /*0x7a2bfec*/ UnityEngine.InputSystem.Controls.KeyControl[] get_keys();
            /*0x7a2bff4*/ void set_keys(UnityEngine.InputSystem.Controls.KeyControl[] value);
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

            static /*0x7a2c0b4*/ UnityEngine.InputSystem.Mouse get_current();
            static /*0x7a2c0fc*/ void set_current(UnityEngine.InputSystem.Mouse value);
            /*0x7a2ca38*/ Mouse();
            /*0x7a2c00c*/ UnityEngine.InputSystem.Controls.DeltaControl get_scroll();
            /*0x7a2c014*/ void set_scroll(UnityEngine.InputSystem.Controls.DeltaControl value);
            /*0x7a2c024*/ UnityEngine.InputSystem.Controls.ButtonControl get_leftButton();
            /*0x7a2c02c*/ void set_leftButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2c03c*/ UnityEngine.InputSystem.Controls.ButtonControl get_middleButton();
            /*0x7a2c044*/ void set_middleButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2c054*/ UnityEngine.InputSystem.Controls.ButtonControl get_rightButton();
            /*0x7a2c05c*/ void set_rightButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2c06c*/ UnityEngine.InputSystem.Controls.ButtonControl get_backButton();
            /*0x7a2c074*/ void set_backButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2c084*/ UnityEngine.InputSystem.Controls.ButtonControl get_forwardButton();
            /*0x7a2c08c*/ void set_forwardButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2c09c*/ UnityEngine.InputSystem.Controls.IntegerControl get_clickCount();
            /*0x7a2c0a4*/ void set_clickCount(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a2c154*/ void MakeCurrent();
            /*0x7a2c210*/ void OnAdded();
            /*0x7a2c290*/ void OnRemoved();
            /*0x7a2c3c4*/ void WarpCursorPosition(UnityEngine.Vector2 position);
            /*0x7a2c46c*/ void FinishSetup();
            /*0x7a2c888*/ void OnNextUpdate();
            /*0x7a2c9a0*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a2ca30*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a2ca34*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
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

            static /*0x7a2cb20*/ UnityEngine.InputSystem.Pen get_current();
            static /*0x7a2cb68*/ void set_current(UnityEngine.InputSystem.Pen value);
            /*0x7a2d054*/ Pen();
            /*0x7a2ca48*/ UnityEngine.InputSystem.Controls.ButtonControl get_tip();
            /*0x7a2ca50*/ void set_tip(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2ca60*/ UnityEngine.InputSystem.Controls.ButtonControl get_eraser();
            /*0x7a2ca68*/ void set_eraser(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2ca78*/ UnityEngine.InputSystem.Controls.ButtonControl get_firstBarrelButton();
            /*0x7a2ca80*/ void set_firstBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2ca90*/ UnityEngine.InputSystem.Controls.ButtonControl get_secondBarrelButton();
            /*0x7a2ca98*/ void set_secondBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2caa8*/ UnityEngine.InputSystem.Controls.ButtonControl get_thirdBarrelButton();
            /*0x7a2cab0*/ void set_thirdBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2cac0*/ UnityEngine.InputSystem.Controls.ButtonControl get_fourthBarrelButton();
            /*0x7a2cac8*/ void set_fourthBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2cad8*/ UnityEngine.InputSystem.Controls.ButtonControl get_inRange();
            /*0x7a2cae0*/ void set_inRange(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2caf0*/ UnityEngine.InputSystem.Controls.Vector2Control get_tilt();
            /*0x7a2caf8*/ void set_tilt(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a2cb08*/ UnityEngine.InputSystem.Controls.AxisControl get_twist();
            /*0x7a2cb10*/ void set_twist(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a2cbc0*/ UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.PenButton button);
            /*0x7a2ccb8*/ void MakeCurrent();
            /*0x7a2cd14*/ void OnRemoved();
            /*0x7a2cdac*/ void FinishSetup();
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

            static /*0x7a2d0ec*/ UnityEngine.InputSystem.Pointer get_current();
            static /*0x7a2d134*/ void set_current(UnityEngine.InputSystem.Pointer value);
            /*0x7a2ca40*/ Pointer();
            /*0x7a2d05c*/ UnityEngine.InputSystem.Controls.Vector2Control get_position();
            /*0x7a2d064*/ void set_position(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a2d074*/ UnityEngine.InputSystem.Controls.DeltaControl get_delta();
            /*0x7a2d07c*/ void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value);
            /*0x7a2d08c*/ UnityEngine.InputSystem.Controls.Vector2Control get_radius();
            /*0x7a2d094*/ void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value);
            /*0x7a2d0a4*/ UnityEngine.InputSystem.Controls.AxisControl get_pressure();
            /*0x7a2d0ac*/ void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a2d0bc*/ UnityEngine.InputSystem.Controls.ButtonControl get_press();
            /*0x7a2d0c4*/ void set_press(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a2d0d4*/ UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex();
            /*0x7a2d0dc*/ void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a2c1b0*/ void MakeCurrent();
            /*0x7a2c328*/ void OnRemoved();
            /*0x7a2c698*/ void FinishSetup();
            /*0x7a2c918*/ void OnNextUpdate();
            /*0x7a2c9e4*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a2d18c*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a2d190*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a2d194*/ bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, ref uint offset);
        }

        class FastKeyboard : UnityEngine.InputSystem.Keyboard
        {
            static string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard";

            /*0x7a2d19c*/ FastKeyboard();
            /*0x7a302ec*/ UnityEngine.InputSystem.Controls.AnyKeyControl Initialize_ctrlKeyboardanyKey(UnityEngine.InputSystem.Utilities.InternedString kAnyKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a304f0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardescape(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a306f8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a308f4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardenter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a30afc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardtab(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a30cf8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a30ef4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a310f0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardsemicolon(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a312ec*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcomma(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a314e8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardperiod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a316e4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a318e0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a31adc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a31cd8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a31ed4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardminus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a320d0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardequals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a322cc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardupArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a324c8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddownArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a326c4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a328c0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a32abc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarda(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a32cb8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardb(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a32eb4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardc(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a330b0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardd(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a332ac*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarde(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a334a8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a336a4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardg(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a338a0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardh(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a33a9c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardi(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a33c98*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardj(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a33e94*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardk(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34090*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3428c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardm(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34488*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardn(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34684*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardo(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34880*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34a7c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardq(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34c78*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardr(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a34e74*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboards(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35070*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3526c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35468*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardv(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35664*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardw(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35860*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardx(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35a5c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardy(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35c58*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardz(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a35e54*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3603c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a36224*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3640c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a365f4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a367dc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a369c4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a36bac*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a36d94*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a36f7c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a37164*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3736c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a37574*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardshift(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3779c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a379a4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a37bac*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardalt(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a37dd4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a37fdc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a381e4*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardctrl(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3840c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a38614*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3881c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcontextMenu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a38a24*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a38c20*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageDown(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a38e1c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageUp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39018*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardhome(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39214*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardend(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39410*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardinsert(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3960c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddelete(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39808*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcapsLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39a04*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39c00*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardprintScreen(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39dfc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardscrollLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a39ff8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpause(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3a1f4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEnter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3a3f0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadDivide(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3a5ec*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMultiply(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3a7e8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPlus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3a9e4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMinus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3abe0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPeriod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3addc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEquals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3afd8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3b1d4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3b3d0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3b5cc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3b7c8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3b9c4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3bbc0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3bdbc*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3bfb8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3c1b4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3c3b0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3c5ac*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3c7a8*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3c9a4*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3cba0*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3cd9c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3cf98*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3d194*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3d390*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3d58c*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf10(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3d788*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf11(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3d984*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf12(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3db80*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3dd68*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3df50*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3e138*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3e320*/ UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a3e508*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlKeyboardIMESelected(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
        }

        class FastMouse : UnityEngine.InputSystem.Mouse, UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver, UnityEngine.InputSystem.LowLevel.IEventMerger
        {
            static string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";

            static /*0x7a6bf9c*/ bool MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
            /*0x7a676cc*/ FastMouse();
            /*0x7a68194*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68384*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousedelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6854c*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousescroll(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68700*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousepress(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68904*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseleftButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68b4c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouserightButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68d94*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousemiddleButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a68fd0*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseforwardButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a691cc*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousebackButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a693c8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a695bc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69788*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousepointerId(UnityEngine.InputSystem.Utilities.InternedString kDigitalLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6991c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousedisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69ac4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMouseclickCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69c80*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a69e90*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a0a0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a2ac*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a4c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a6d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6a8e0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6aac0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6aca0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6aeac*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolldown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b0c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b2d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b4e0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b6d8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolly(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6b8e4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6bac4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6bca4*/ void OnNextUpdate();
            /*0x7a6bde8*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a6bf94*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a6bf98*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a6c0b0*/ bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
        }

        class FastTouchscreen : UnityEngine.InputSystem.Touchscreen
        {
            static string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer";

            /*0x7a3e6f8*/ FastTouchscreen();
            /*0x7a42128*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreenprimaryTouch(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a422f0*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a424dc*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreendelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a426a8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpressure(UnityEngine.InputSystem.Utilities.InternedString kAnalogLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4289c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a42a68*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a42c6c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreendisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a42e14*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch0(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a42fc8*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch1(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4317c*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch2(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a43330*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch3(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a434e4*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch4(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a43698*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch5(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4384c*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch6(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a43a00*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch7(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a43bb4*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch8(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a43d68*/ UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch9(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a43f1c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44140*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4435c*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44548*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44728*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44914*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44b08*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44d30*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a44f10*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a450f0*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4532c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a45560*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a45754*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a45954*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a45b64*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a45d74*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a45f80*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a46194*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a463a8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a465b4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a46794*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a46974*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a46b54*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a46d34*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a46f14*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a470f4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47304*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47514*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47720*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47934*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47b48*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47d54*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a47f34*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48114*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a482f4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a484d4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a486f8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48914*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch0delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48b00*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48ce0*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a48ecc*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a490c0*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch0press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a492e8*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a494c8*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a496a8*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a498e4*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49b0c*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch0startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49d00*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a49f00*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a110*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a320*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a52c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a740*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4a954*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ab60*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ad40*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4af20*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b100*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b2e0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b4c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b6a0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4b8c4*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4bae0*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch1delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4bccc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4beac*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c098*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c28c*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch1press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c4b4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c694*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4c874*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4cab0*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ccd8*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch1startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4cecc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d0cc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d2dc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d4ec*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d6f8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4d90c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4db20*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4dd2c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4df0c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e0ec*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e2cc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e4ac*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e68c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4e86c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ea90*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ecac*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch2delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4ee98*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f078*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f264*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f458*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch2press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f680*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4f860*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4fa40*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4fc7c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a4fea4*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch2startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50098*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50298*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a504a8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a506b8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a508c4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50ad8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50cec*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a50ef8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a510d8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a512b8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51498*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51678*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51858*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51a38*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51c5c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a51e78*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch3delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52064*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52244*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52430*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52624*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch3press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5284c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52a2c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52c0c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a52e48*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53070*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch3startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53264*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53464*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53674*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53884*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53a90*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53ca4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a53eb8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a540c4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a542a4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54484*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54664*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54844*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54a24*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54c04*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a54e28*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55044*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch4delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55230*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55410*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a555fc*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a557f0*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch4press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55a18*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55bf8*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a55dd8*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56014*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5623c*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch4startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56430*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56630*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56840*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56a50*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56c5c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a56e70*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57084*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57290*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57470*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57650*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57830*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57a10*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57bf0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57dd0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a57ff4*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a58210*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch5delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a583fc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a585dc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a587c8*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a589bc*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch5press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a58be4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a58dc4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a58fa4*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a591e0*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59408*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch5startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a595fc*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a597fc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59a0c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59c1c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a59e28*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a03c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a250*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a45c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a63c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a81c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5a9fc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5abdc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5adbc*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5af9c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b1c0*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b3dc*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch6delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b5c8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b7a8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5b994*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5bb88*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch6press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5bdb0*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5bf90*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c170*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c3ac*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c5d4*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch6startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c7c8*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5c9c8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5cbd8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5cde8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5cff4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d208*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d41c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d628*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d808*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5d9e8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5dbc8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5dda8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5df88*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e168*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e38c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e5a8*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch7delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e794*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5e974*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5eb60*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ed54*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch7press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ef7c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f15c*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f33c*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f578*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f7a0*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch7startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5f994*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5fb94*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5fda4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a5ffb4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a601c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a603d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a605e8*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a607f4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a609d4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60bb4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60d94*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a60f74*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61154*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61334*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61558*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61774*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch8delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61960*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61b40*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61d2c*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a61f20*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch8press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62148*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62328*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62508*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62744*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6296c*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch8startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62b60*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62d60*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a62f70*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63180*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6338c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a635a0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a637b4*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a639c0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63ba0*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63d80*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a63f60*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64140*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64320*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64500*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64724*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64940*/ UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch9delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64b2c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64d0c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a64ef8*/ UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a650ec*/ UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch9press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65314*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a654f4*/ UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a656d4*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65910*/ UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65b38*/ UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch9startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65d2c*/ UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a65f2c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6613c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6634c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66558*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6676c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66980*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66b8c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66d6c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a66f4c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6712c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a6730c*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
            /*0x7a674ec*/ UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent);
        }

        class InputRemoting : System.IObservable<UnityEngine.InputSystem.InputRemoting.Message>, System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>
        {
            /*0x10*/ UnityEngine.InputSystem.InputRemoting.Flags m_Flags;
            /*0x18*/ UnityEngine.InputSystem.InputManager m_LocalManager;
            /*0x20*/ UnityEngine.InputSystem.InputRemoting.Subscriber[] m_Subscribers;
            /*0x28*/ UnityEngine.InputSystem.InputRemoting.RemoteSender[] m_Senders;

            static /*0x7a6e568*/ UnityEngine.InputSystem.Utilities.InternedString BuildLayoutNamespace(int senderId);
            static /*0x3907c14*/ byte[] SerializeData<TData>(TData data);
            static /*0x3907c14*/ TData DeserializeData<TData>(byte[] data);
            /*0x7a6c0d8*/ InputRemoting(UnityEngine.InputSystem.InputManager manager, bool startSendingOnConnect);
            /*0x7a6c0bc*/ bool get_sending();
            /*0x7a6c0c8*/ void set_sending(bool value);
            /*0x7a6c16c*/ void StartSending();
            /*0x7a6c3f0*/ void StopSending();
            /*0x7a6c644*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg);
            /*0x7a6d274*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error);
            /*0x7a6d278*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted();
            /*0x7a6d27c*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer);
            /*0x7a6c3d8*/ void SendInitialMessages();
            /*0x7a6d380*/ void SendAllGeneratedLayouts();
            /*0x7a6d63c*/ void SendLayout(string layoutName);
            /*0x7a6d4d4*/ void SendAllDevices();
            /*0x7a6db08*/ void SendDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a6def8*/ void SendEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
            /*0x7a6e058*/ void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
            /*0x7a6e3c0*/ void SendLayoutChange(string layout, UnityEngine.InputSystem.InputControlLayoutChange change);
            /*0x7a6d99c*/ void Send(UnityEngine.InputSystem.InputRemoting.Message msg);
            /*0x7a6e4c4*/ int FindOrCreateSenderRecord(int senderId);
            /*0x7a6e5f4*/ int FindLocalDeviceId(int remoteDeviceId, int senderIndex);
            /*0x7a6e668*/ UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex);
            /*0x7a6e708*/ UnityEngine.InputSystem.InputManager get_manager();
            /*0x7a6e710*/ void RemoveRemoteDevices(int participantId);

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

                /*0x7a6d378*/ Subscriber();
                /*0x7a6ece4*/ void Dispose();
            }

            class ConnectMsg
            {
                static /*0x7a6c6c8*/ void Process(UnityEngine.InputSystem.InputRemoting receiver);
            }

            class StartSendingMsg
            {
                static /*0x7a6d254*/ void Process(UnityEngine.InputSystem.InputRemoting receiver);
            }

            class StopSendingMsg
            {
                static /*0x7a6d264*/ void Process(UnityEngine.InputSystem.InputRemoting receiver);
            }

            class DisconnectMsg
            {
                static /*0x7a6c70c*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);
            }

            class NewLayoutMsg
            {
                static /*0x7a6d6f0*/ System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(UnityEngine.InputSystem.InputRemoting sender, string layoutName);
                static /*0x7a6c7a0*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);

                struct Data
                {
                    /*0x10*/ string name;
                    /*0x18*/ string layoutJson;
                    /*0x20*/ bool isOverride;
                }
            }

            class NewDeviceMsg
            {
                static /*0x7a6db8c*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a6c898*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);

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

                    static /*0x7a6f490*/ <>c();
                    /*0x7a6f4f8*/ <>c();
                    /*0x7a6f500*/ string <Create>b__1_0(UnityEngine.InputSystem.Utilities.InternedString x);
                }
            }

            class NewEventsMsg
            {
                static /*0x7a6e348*/ UnityEngine.InputSystem.InputRemoting.Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, bool isHardReset);
                static /*0x7a6ddf8*/ UnityEngine.InputSystem.InputRemoting.Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a6df5c*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.LowLevel.InputEvent* events, int eventCount);
                static /*0x7a6ce1c*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);
            }

            class ChangeUsageMsg
            {
                static /*0x7a6e160*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a6cedc*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);

                struct Data
                {
                    /*0x10*/ int deviceId;
                    /*0x18*/ string[] usages;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.InputRemoting.ChangeUsageMsg.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__1_0;

                    static /*0x7a6f654*/ <>c();
                    /*0x7a6f6bc*/ <>c();
                    /*0x7a6f6c4*/ string <Create>b__1_0(UnityEngine.InputSystem.Utilities.InternedString x);
                }
            }

            class RemoveDeviceMsg
            {
                static /*0x7a6e114*/ UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a6d1e8*/ void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg);
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

            static /*0x7a70564*/ RemoteInputPlayerConnection();
            /*0x7a7055c*/ RemoteInputPlayerConnection();
            /*0x7a6f6e8*/ void Bind(UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection connection, bool isConnected);
            /*0x7a6fe94*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer);
            /*0x7a6fdb8*/ void OnConnected(int id);
            /*0x7a7018c*/ void OnDisconnected(int id);
            /*0x7a7025c*/ void OnNewDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a70268*/ void OnNewLayout(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a70274*/ void OnNewEvents(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a70280*/ void OnRemoveDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a7028c*/ void OnChangeUsages(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a70298*/ void OnStartSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a702a4*/ void OnStopSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a70054*/ void SendToSubscribers(UnityEngine.InputSystem.InputRemoting.MessageType type, UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
            /*0x7a702b0*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg);
            /*0x7a70554*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error);
            /*0x7a70558*/ void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted();

            class Subscriber : System.IDisposable
            {
                /*0x10*/ UnityEngine.InputSystem.RemoteInputPlayerConnection owner;
                /*0x18*/ System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer;

                /*0x7a7004c*/ Subscriber();
                /*0x7a70748*/ void Dispose();
            }
        }

        class Sensor : UnityEngine.InputSystem.InputDevice
        {
            /*0x7a7093c*/ Sensor();
            /*0x7a707a0*/ float get_samplingFrequency();
            /*0x7a70894*/ void set_samplingFrequency(float value);
        }

        class Accelerometer : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.Accelerometer <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <acceleration>k__BackingField;

            static /*0x7a7095c*/ UnityEngine.InputSystem.Accelerometer get_current();
            static /*0x7a709a4*/ void set_current(UnityEngine.InputSystem.Accelerometer value);
            /*0x7a70b7c*/ Accelerometer();
            /*0x7a70944*/ UnityEngine.InputSystem.Controls.Vector3Control get_acceleration();
            /*0x7a7094c*/ void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a709fc*/ void MakeCurrent();
            /*0x7a70a5c*/ void OnRemoved();
            /*0x7a70af8*/ void FinishSetup();
        }

        class Gyroscope : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.Gyroscope <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField;

            static /*0x7a70b9c*/ UnityEngine.InputSystem.Gyroscope get_current();
            static /*0x7a70be4*/ void set_current(UnityEngine.InputSystem.Gyroscope value);
            /*0x7a70dbc*/ Gyroscope();
            /*0x7a70b84*/ UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity();
            /*0x7a70b8c*/ void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a70c3c*/ void MakeCurrent();
            /*0x7a70c9c*/ void OnRemoved();
            /*0x7a70d38*/ void FinishSetup();
        }

        class GravitySensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.GravitySensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <gravity>k__BackingField;

            static /*0x7a70ddc*/ UnityEngine.InputSystem.GravitySensor get_current();
            static /*0x7a70e24*/ void set_current(UnityEngine.InputSystem.GravitySensor value);
            /*0x7a70ffc*/ GravitySensor();
            /*0x7a70dc4*/ UnityEngine.InputSystem.Controls.Vector3Control get_gravity();
            /*0x7a70dcc*/ void set_gravity(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a70e7c*/ void FinishSetup();
            /*0x7a70f00*/ void MakeCurrent();
            /*0x7a70f60*/ void OnRemoved();
        }

        class AttitudeSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.AttitudeSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.QuaternionControl <attitude>k__BackingField;

            static /*0x7a7101c*/ UnityEngine.InputSystem.AttitudeSensor get_current();
            static /*0x7a71064*/ void set_current(UnityEngine.InputSystem.AttitudeSensor value);
            /*0x7a7123c*/ AttitudeSensor();
            /*0x7a71004*/ UnityEngine.InputSystem.Controls.QuaternionControl get_attitude();
            /*0x7a7100c*/ void set_attitude(UnityEngine.InputSystem.Controls.QuaternionControl value);
            /*0x7a710bc*/ void MakeCurrent();
            /*0x7a7111c*/ void OnRemoved();
            /*0x7a711b8*/ void FinishSetup();
        }

        class LinearAccelerationSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.LinearAccelerationSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <acceleration>k__BackingField;

            static /*0x7a7125c*/ UnityEngine.InputSystem.LinearAccelerationSensor get_current();
            static /*0x7a712a4*/ void set_current(UnityEngine.InputSystem.LinearAccelerationSensor value);
            /*0x7a7147c*/ LinearAccelerationSensor();
            /*0x7a71244*/ UnityEngine.InputSystem.Controls.Vector3Control get_acceleration();
            /*0x7a7124c*/ void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a712fc*/ void MakeCurrent();
            /*0x7a7135c*/ void OnRemoved();
            /*0x7a713f8*/ void FinishSetup();
        }

        class MagneticFieldSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.MagneticFieldSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <magneticField>k__BackingField;

            static /*0x7a7149c*/ UnityEngine.InputSystem.MagneticFieldSensor get_current();
            static /*0x7a714e4*/ void set_current(UnityEngine.InputSystem.MagneticFieldSensor value);
            /*0x7a716bc*/ MagneticFieldSensor();
            /*0x7a71484*/ UnityEngine.InputSystem.Controls.Vector3Control get_magneticField();
            /*0x7a7148c*/ void set_magneticField(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a7153c*/ void MakeCurrent();
            /*0x7a7159c*/ void OnRemoved();
            /*0x7a71638*/ void FinishSetup();
        }

        class LightSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.LightSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <lightLevel>k__BackingField;

            static /*0x7a716dc*/ UnityEngine.InputSystem.LightSensor get_current();
            static /*0x7a71724*/ void set_current(UnityEngine.InputSystem.LightSensor value);
            /*0x7a718fc*/ LightSensor();
            /*0x7a716c4*/ UnityEngine.InputSystem.Controls.AxisControl get_lightLevel();
            /*0x7a716cc*/ void set_lightLevel(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a7177c*/ void MakeCurrent();
            /*0x7a717dc*/ void OnRemoved();
            /*0x7a71878*/ void FinishSetup();
        }

        class PressureSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.PressureSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <atmosphericPressure>k__BackingField;

            static /*0x7a7191c*/ UnityEngine.InputSystem.PressureSensor get_current();
            static /*0x7a71964*/ void set_current(UnityEngine.InputSystem.PressureSensor value);
            /*0x7a71b3c*/ PressureSensor();
            /*0x7a71904*/ UnityEngine.InputSystem.Controls.AxisControl get_atmosphericPressure();
            /*0x7a7190c*/ void set_atmosphericPressure(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a719bc*/ void MakeCurrent();
            /*0x7a71a1c*/ void OnRemoved();
            /*0x7a71ab8*/ void FinishSetup();
        }

        class ProximitySensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.ProximitySensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <distance>k__BackingField;

            static /*0x7a71b5c*/ UnityEngine.InputSystem.ProximitySensor get_current();
            static /*0x7a71ba4*/ void set_current(UnityEngine.InputSystem.ProximitySensor value);
            /*0x7a71d7c*/ ProximitySensor();
            /*0x7a71b44*/ UnityEngine.InputSystem.Controls.AxisControl get_distance();
            /*0x7a71b4c*/ void set_distance(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a71bfc*/ void MakeCurrent();
            /*0x7a71c5c*/ void OnRemoved();
            /*0x7a71cf8*/ void FinishSetup();
        }

        class HumiditySensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.HumiditySensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <relativeHumidity>k__BackingField;

            static /*0x7a71d9c*/ UnityEngine.InputSystem.HumiditySensor get_current();
            static /*0x7a71de4*/ void set_current(UnityEngine.InputSystem.HumiditySensor value);
            /*0x7a71fbc*/ HumiditySensor();
            /*0x7a71d84*/ UnityEngine.InputSystem.Controls.AxisControl get_relativeHumidity();
            /*0x7a71d8c*/ void set_relativeHumidity(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a71e3c*/ void MakeCurrent();
            /*0x7a71e9c*/ void OnRemoved();
            /*0x7a71f38*/ void FinishSetup();
        }

        class AmbientTemperatureSensor : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.AmbientTemperatureSensor <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <ambientTemperature>k__BackingField;

            static /*0x7a71fdc*/ UnityEngine.InputSystem.AmbientTemperatureSensor get_current();
            static /*0x7a72024*/ void set_current(UnityEngine.InputSystem.AmbientTemperatureSensor value);
            /*0x7a721fc*/ AmbientTemperatureSensor();
            /*0x7a71fc4*/ UnityEngine.InputSystem.Controls.AxisControl get_ambientTemperature();
            /*0x7a71fcc*/ void set_ambientTemperature(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a7207c*/ void MakeCurrent();
            /*0x7a720dc*/ void OnRemoved();
            /*0x7a72178*/ void FinishSetup();
        }

        class StepCounter : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.StepCounter <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.IntegerControl <stepCounter>k__BackingField;

            static /*0x7a7221c*/ UnityEngine.InputSystem.StepCounter get_current();
            static /*0x7a72264*/ void set_current(UnityEngine.InputSystem.StepCounter value);
            /*0x7a7243c*/ StepCounter();
            /*0x7a72204*/ UnityEngine.InputSystem.Controls.IntegerControl get_stepCounter();
            /*0x7a7220c*/ void set_stepCounter(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a722bc*/ void MakeCurrent();
            /*0x7a7231c*/ void OnRemoved();
            /*0x7a723b8*/ void FinishSetup();
        }

        class HingeAngle : UnityEngine.InputSystem.Sensor
        {
            static /*0x0*/ UnityEngine.InputSystem.HingeAngle <current>k__BackingField;
            /*0x188*/ UnityEngine.InputSystem.Controls.AxisControl <angle>k__BackingField;

            static /*0x7a7245c*/ UnityEngine.InputSystem.HingeAngle get_current();
            static /*0x7a724a4*/ void set_current(UnityEngine.InputSystem.HingeAngle value);
            /*0x7a7267c*/ HingeAngle();
            /*0x7a72444*/ UnityEngine.InputSystem.Controls.AxisControl get_angle();
            /*0x7a7244c*/ void set_angle(UnityEngine.InputSystem.Controls.AxisControl value);
            /*0x7a724fc*/ void MakeCurrent();
            /*0x7a7255c*/ void OnRemoved();
            /*0x7a725f8*/ void FinishSetup();
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

            static /*0x7a74090*/ Touchscreen();
            static /*0x7a72740*/ UnityEngine.InputSystem.Touchscreen get_current();
            static /*0x7a72798*/ void set_current(UnityEngine.InputSystem.Touchscreen value);
            static /*0x7a73f0c*/ bool MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
            static /*0x7a737c0*/ void TriggerTap(UnityEngine.InputSystem.Controls.TouchControl control, ref UnityEngine.InputSystem.LowLevel.TouchState state, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a74088*/ Touchscreen();
            /*0x7a72684*/ UnityEngine.InputSystem.Controls.TouchControl get_primaryTouch();
            /*0x7a7268c*/ void set_primaryTouch(UnityEngine.InputSystem.Controls.TouchControl value);
            /*0x7a7269c*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches();
            /*0x7a726a8*/ void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value);
            /*0x7a726bc*/ UnityEngine.InputSystem.Controls.TouchControl[] get_touchControlArray();
            /*0x7a726c4*/ void set_touchControlArray(UnityEngine.InputSystem.Controls.TouchControl[] value);
            /*0x7a727f8*/ void MakeCurrent();
            /*0x7a72894*/ void OnRemoved();
            /*0x7a7298c*/ void FinishSetup();
            /*0x7a72d74*/ void OnNextUpdate();
            /*0x7a730b8*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a7388c*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate();
            /*0x7a73890*/ void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a73894*/ bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, ref uint offset);
            /*0x7a73b2c*/ void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset();
            /*0x7a74024*/ bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
        }

        class TrackedDevice : UnityEngine.InputSystem.InputDevice
        {
            /*0x188*/ UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;
            /*0x190*/ UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;
            /*0x198*/ UnityEngine.InputSystem.Controls.Vector3Control <devicePosition>k__BackingField;
            /*0x1a0*/ UnityEngine.InputSystem.Controls.QuaternionControl <deviceRotation>k__BackingField;

            /*0x7a74318*/ TrackedDevice();
            /*0x7a74144*/ UnityEngine.InputSystem.Controls.IntegerControl get_trackingState();
            /*0x7a7414c*/ void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value);
            /*0x7a7415c*/ UnityEngine.InputSystem.Controls.ButtonControl get_isTracked();
            /*0x7a74164*/ void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value);
            /*0x7a74174*/ UnityEngine.InputSystem.Controls.Vector3Control get_devicePosition();
            /*0x7a7417c*/ void set_devicePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
            /*0x7a7418c*/ UnityEngine.InputSystem.Controls.QuaternionControl get_deviceRotation();
            /*0x7a74194*/ void set_deviceRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
            /*0x7a741a4*/ void FinishSetup();
        }

        class InputExtensions
        {
            static /*0x7a74320*/ bool IsInProgress(UnityEngine.InputSystem.InputActionPhase phase);
            static /*0x7a74330*/ bool IsEndedOrCanceled(UnityEngine.InputSystem.TouchPhase phase);
            static /*0x7a73b10*/ bool IsActive(UnityEngine.InputSystem.TouchPhase phase);
            static /*0x7a74340*/ bool IsModifierKey(UnityEngine.InputSystem.Key key);
            static /*0x7a74350*/ bool IsTextInputKey(UnityEngine.InputSystem.Key key);
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

            static /*0x7a81084*/ InputManager();
            static /*0x7a7d344*/ void ResetControlPathsRecursive(UnityEngine.InputSystem.InputControl control);
            /*0x7a8107c*/ InputManager();
            /*0x7a6daa0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices();
            /*0x7a7437c*/ UnityEngine.InputSystem.Utilities.TypeTable get_processors();
            /*0x7a74384*/ UnityEngine.InputSystem.Utilities.TypeTable get_interactions();
            /*0x7a7438c*/ UnityEngine.InputSystem.Utilities.TypeTable get_composites();
            /*0x7a74394*/ UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics();
            /*0x7a74530*/ UnityEngine.InputSystem.InputSettings get_settings();
            /*0x7a74538*/ void set_settings(UnityEngine.InputSystem.InputSettings value);
            /*0x7a74c2c*/ UnityEngine.InputSystem.InputActionAsset get_actions();
            /*0x7a74c34*/ void set_actions(UnityEngine.InputSystem.InputActionAsset value);
            /*0x7a74cd4*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask();
            /*0x7a74cdc*/ void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value);
            /*0x7a74f00*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_defaultUpdateType();
            /*0x7a74f1c*/ UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior();
            /*0x7a74f24*/ void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value);
            /*0x7a7500c*/ float get_pollingFrequency();
            /*0x7a75014*/ void set_pollingFrequency(float value);
            /*0x7a6c328*/ void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            /*0x7a6c594*/ void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange> value);
            /*0x7a7513c*/ void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
            /*0x7a75194*/ void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
            /*0x7a751ec*/ void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            /*0x7a75244*/ void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value);
            /*0x7a7529c*/ void add_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            /*0x7a755a4*/ void remove_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value);
            /*0x7a6c380*/ void add_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            /*0x7a6c5ec*/ void remove_onLayoutChange(System.Action<string, UnityEngine.InputSystem.InputControlLayoutChange> value);
            /*0x7a6c2d0*/ void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> value);
            /*0x7a6c53c*/ void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> value);
            /*0x7a755fc*/ void add_onBeforeUpdate(System.Action value);
            /*0x7a75758*/ void remove_onBeforeUpdate(System.Action value);
            /*0x7a757b0*/ void add_onAfterUpdate(System.Action value);
            /*0x7a75808*/ void remove_onAfterUpdate(System.Action value);
            /*0x7a75860*/ void add_onSettingsChange(System.Action value);
            /*0x7a758b8*/ void remove_onSettingsChange(System.Action value);
            /*0x7a75910*/ void add_onActionsChange(System.Action value);
            /*0x7a75968*/ void remove_onActionsChange(System.Action value);
            /*0x7a759c0*/ bool get_isProcessingEvents();
            /*0x7a759c8*/ bool get_gameIsPlaying();
            /*0x7a759d0*/ bool get_gameHasFocus();
            /*0x7a75a04*/ bool get_gameShouldGetInputRegardlessOfFocus();
            /*0x7a75a28*/ void RegisterControlLayout(string name, System.Type type);
            /*0x7a6ed4c*/ void RegisterControlLayout(string json, string name, bool isOverride);
            /*0x7a765b0*/ void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout);
            /*0x7a75fc8*/ void PerformLayoutPostRegistration(UnityEngine.InputSystem.Utilities.InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout, bool isOverride);
            /*0x380d83c*/ void RegisterPrecompiledLayout<TDevice>(string metadata);
            /*0x7a7673c*/ void RecreateDevicesUsingLayout(UnityEngine.InputSystem.Utilities.InternedString layout, bool isKnownToBeDeviceLayout);
            /*0x7a76a80*/ bool IsControlOrChildUsingLayoutRecursive(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout);
            /*0x7a769ac*/ bool IsControlUsingLayout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout);
            /*0x7a7645c*/ void RegisterControlLayoutMatcher(string layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            /*0x7a772e0*/ void RegisterControlLayoutMatcher(System.Type type, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
            /*0x7a76cd4*/ void RecreateDevicesUsingLayoutWithInferiorMatch(UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher);
            /*0x7a76b78*/ void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, UnityEngine.InputSystem.Utilities.InternedString newLayout);
            /*0x7a76f20*/ void AddAvailableDevicesMatchingDescription(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher, UnityEngine.InputSystem.Utilities.InternedString layout);
            /*0x7a7810c*/ void RemoveControlLayout(string name);
            /*0x7a7834c*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(System.Type type);
            /*0x7a6ed3c*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(UnityEngine.InputSystem.Utilities.InternedString name);
            /*0x7a774ec*/ UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingControlLayout(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, int deviceId);
            /*0x7a78560*/ UnityEngine.InputSystem.Utilities.InternedString FindOrRegisterDeviceLayoutForType(System.Type type);
            /*0x7a78604*/ bool IsDeviceLayoutMarkedAsSupportedInSettings(UnityEngine.InputSystem.Utilities.InternedString layoutName);
            /*0x7a78710*/ System.Collections.Generic.IEnumerable<string> ListControlLayouts(string basedOn);
            int GetControls<TControl>(string path, ref UnityEngine.InputSystem.InputControlList<TControl> controls);
            /*0x7a787a0*/ void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a6f364*/ void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a6f528*/ void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage);
            /*0x7a788f8*/ void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device);
            /*0x7a789f4*/ UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, string name);
            /*0x7a6f218*/ UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name, UnityEngine.InputSystem.Utilities.InternedString variants);
            /*0x7a77f44*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Utilities.InternedString layout, int deviceId, string deviceName, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags, UnityEngine.InputSystem.Utilities.InternedString variants);
            /*0x7a779b8*/ void AddDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a79558*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description);
            /*0x7a7959c*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags);
            /*0x7a79780*/ UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, UnityEngine.InputSystem.Utilities.InternedString layout, string deviceName, int deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags);
            /*0x7a6e80c*/ void RemoveDevice(UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices);
            /*0x7a79984*/ void FlushDisconnectedDevices();
            /*0x7a799d8*/ void ResetDevice(UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls, System.Nullable<bool> issueResetCommand);
            /*0x7a7a52c*/ UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout);
            /*0x7a7a650*/ UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout);
            /*0x7a7a6f0*/ UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType);
            /*0x7a6e690*/ UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id);
            /*0x7a7a74c*/ int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions);
            /*0x7a790dc*/ void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, bool enable, UnityEngine.InputSystem.InputManager.DeviceDisableScope scope);
            /*0x7a7a938*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
            /*0x7a6f524*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
            /*0x380d83c*/ void QueueEvent<TEvent>(ref TEvent inputEvent);
            /*0x7a7aa04*/ void Update();
            /*0x7a7aa30*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a7aadc*/ void Initialize(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings);
            /*0x7a7c9d0*/ void Destroy();
            /*0x7a7ab38*/ void InitializeActions();
            /*0x7a7abec*/ void InitializeData();
            /*0x7a7d0d8*/ void RegisterCustomTypes(System.Type[] types);
            /*0x7a7ce80*/ void RegisterCustomTypes();
            /*0x7a7c080*/ void InstallRuntime(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime);
            /*0x7a7c768*/ void InstallGlobals();
            /*0x7a7cadc*/ void UninstallGlobals();
            /*0x7a7d308*/ bool get_optimizedControlsFeatureEnabled();
            /*0x7a7d310*/ void set_optimizedControlsFeatureEnabled(bool value);
            /*0x7a7d31c*/ bool get_readValueCachingFeatureEnabled();
            /*0x7a7d324*/ void set_readValueCachingFeatureEnabled(bool value);
            /*0x7a7d330*/ bool get_paranoidReadValueCachingChecksEnabled();
            /*0x7a7d338*/ void set_paranoidReadValueCachingChecksEnabled(bool value);
            /*0x7a78ab4*/ void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device);
            /*0x7a78c6c*/ void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device);
            /*0x7a74d00*/ void ReallocateStateBuffers();
            /*0x7a7d42c*/ void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device);
            /*0x7a78df0*/ void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device);
            /*0x7a7d5e0*/ void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor);
            /*0x7a7dcf8*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonString MakeEscapedJsonString(string theString);
            /*0x7a7da4c*/ UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor);
            /*0x7a7565c*/ void InstallBeforeUpdateHookIfNecessary();
            /*0x7a7da48*/ void RestoreDevicesAfterDomainReloadIfNecessary();
            /*0x7a7de98*/ void WarnAboutDevicesFailingToRecreateAfterDomainReload();
            /*0x7a7de9c*/ void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a7463c*/ void ApplySettings();
            /*0x7a74c54*/ void ApplyActions();
            long ExecuteGlobalCommand<TCommand>(ref TCommand command);
            /*0x7a752fc*/ void AddAvailableDevicesThatAreNowRecognized();
            /*0x7a790a0*/ bool ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device);
            /*0x7a7e098*/ void OnFocusChanged(bool focus);
            /*0x7a7e2d8*/ bool ShouldRunUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a7e2f4*/ void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer);
            /*0x7a7fad8*/ bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed);
            /*0x7a7fcb0*/ string MakeStringWithEventsProcessedByDevice();
            /*0x7a7fc04*/ void ResetCurrentProcessedEventBytesForDevices();
            /*0x7a7fdf0*/ void CheckAllDevicesOptimizedControlsHaveValidState();
            /*0x7a7f8cc*/ void InvokeAfterUpdateCallback(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a7ff7c*/ void DontMakeCurrentlyUpdatingDeviceCurrent();
            /*0x7a7f968*/ bool UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a79ff4*/ bool UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a80304*/ void WriteStateChange(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref UnityEngine.InputSystem.LowLevel.InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers);
            /*0x7a80260*/ bool FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
            /*0x7a80994*/ void AddStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex);
            /*0x7a79858*/ void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device);
            /*0x7a80af4*/ void RemoveStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex);
            /*0x7a80c4c*/ void AddStateChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex);
            /*0x7a80d24*/ void RemoveStateChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex);
            /*0x7a7ff84*/ void SortStateChangeMonitorsIfNecessary(int deviceIndex);
            /*0x7a80e40*/ void SignalStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor);
            /*0x7a80f30*/ void FireStateChangeNotifications();
            /*0x7a7ffd8*/ bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes);
            /*0x7a80520*/ void FireStateChangeNotifications(int deviceIndex, double internalTime, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
            /*0x7a7f618*/ void ProcessStateChangeMonitorTimeouts();
            /*0x7a813b8*/ long <TryFindMatchingControlLayout>b__94_0(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand commandRef);

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

                /*0x7a81420*/ int get_count();
                /*0x7a81428*/ void Add(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex);
                /*0x7a81610*/ void Remove(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval);
                /*0x7a8180c*/ void Clear();
                /*0x7a81870*/ void CompactArrays();
                /*0x7a8175c*/ void RemoveAt(int i);
                /*0x7a818d4*/ void SortMonitorsByIndex();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputSystem.InputManager.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.InputSystem.InputDevice, string> <>9__184_0;

                static /*0x7a81a40*/ <>c();
                /*0x7a81aa8*/ <>c();
                /*0x7a81ab0*/ string <MakeDeviceNameUnique>b__184_0(UnityEngine.InputSystem.InputDevice x);
            }

            class <>c__82<TDevice>
            {
                static /*0x0*/ UnityEngine.InputSystem.InputManager.<>c__82<TDevice> <>9;
                static /*0x0*/ System.Func<UnityEngine.InputSystem.InputDevice> <>9__82_0;

                static /*0x38358cc*/ <>c__82();
                /*0x380cb08*/ <>c__82();
                /*0x380b9e8*/ UnityEngine.InputSystem.InputDevice <RegisterPrecompiledLayout>b__82_0();
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

                /*0x7a81ad8*/ <ListControlLayouts>d__97(int <>1__state);
                /*0x7a81b0c*/ void System.IDisposable.Dispose();
                /*0x7a81b50*/ bool MoveNext();
                /*0x7a822bc*/ void <>m__Finally1();
                /*0x7a8230c*/ void <>m__Finally2();
                /*0x7a8235c*/ void <>m__Finally3();
                /*0x7a823ac*/ void <>m__Finally4();
                /*0x7a823fc*/ void <>m__Finally5();
                /*0x7a8244c*/ void <>m__Finally6();
                /*0x7a8249c*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x7a824a4*/ void System.Collections.IEnumerator.Reset();
                /*0x7a824dc*/ object System.Collections.IEnumerator.get_Current();
                /*0x7a824e4*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x7a82598*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7a82c60*/ bool CompareFloats(float a, float b);
            static /*0x3907c14*/ bool CompareSets<T>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> a, UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> b);
            static /*0x7a82c78*/ bool CompareFeatureFlag(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b, string featureName);
            static /*0x7a82cc0*/ bool AreEqual(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b);
            /*0x7a8301c*/ InputSettings();
            /*0x7a8259c*/ UnityEngine.InputSystem.InputSettings.UpdateMode get_updateMode();
            /*0x7a825a4*/ void set_updateMode(UnityEngine.InputSystem.InputSettings.UpdateMode value);
            /*0x7a82688*/ UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior();
            /*0x7a82690*/ void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value);
            /*0x7a826a8*/ bool get_compensateForScreenOrientation();
            /*0x7a826b0*/ void set_compensateForScreenOrientation(bool value);
            /*0x7a826cc*/ bool get_filterNoiseOnCurrent();
            /*0x7a826d4*/ void set_filterNoiseOnCurrent(bool value);
            /*0x7a826d8*/ float get_defaultDeadzoneMin();
            /*0x7a826e0*/ void set_defaultDeadzoneMin(float value);
            /*0x7a826f8*/ float get_defaultDeadzoneMax();
            /*0x7a82700*/ void set_defaultDeadzoneMax(float value);
            /*0x7a82718*/ float get_defaultButtonPressPoint();
            /*0x7a82720*/ void set_defaultButtonPressPoint(float value);
            /*0x7a82754*/ float get_buttonReleaseThreshold();
            /*0x7a8275c*/ void set_buttonReleaseThreshold(float value);
            /*0x7a82774*/ float get_defaultTapTime();
            /*0x7a8277c*/ void set_defaultTapTime(float value);
            /*0x7a82794*/ float get_defaultSlowTapTime();
            /*0x7a8279c*/ void set_defaultSlowTapTime(float value);
            /*0x7a827b4*/ float get_defaultHoldTime();
            /*0x7a827bc*/ void set_defaultHoldTime(float value);
            /*0x7a827d4*/ float get_tapRadius();
            /*0x7a827dc*/ void set_tapRadius(float value);
            /*0x7a827f4*/ float get_multiTapDelayTime();
            /*0x7a827fc*/ void set_multiTapDelayTime(float value);
            /*0x7a82814*/ UnityEngine.InputSystem.InputSettings.BackgroundBehavior get_backgroundBehavior();
            /*0x7a8281c*/ void set_backgroundBehavior(UnityEngine.InputSystem.InputSettings.BackgroundBehavior value);
            /*0x7a82834*/ UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode();
            /*0x7a8283c*/ void set_editorInputBehaviorInPlayMode(UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode value);
            /*0x7a82854*/ UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode();
            /*0x7a8285c*/ void set_inputActionPropertyDrawerMode(UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode value);
            /*0x7a82874*/ int get_maxEventBytesPerUpdate();
            /*0x7a8287c*/ void set_maxEventBytesPerUpdate(int value);
            /*0x7a82894*/ int get_maxQueuedEventsPerUpdate();
            /*0x7a8289c*/ void set_maxQueuedEventsPerUpdate(int value);
            /*0x7a828b4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<string> get_supportedDevices();
            /*0x7a82914*/ void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<string> value);
            /*0x7a82a44*/ bool get_disableRedundantEventsMerging();
            /*0x7a82a4c*/ void set_disableRedundantEventsMerging(bool value);
            /*0x7a82a68*/ bool get_shortcutKeysConsumeInput();
            /*0x7a82a70*/ void set_shortcutKeysConsumeInput(bool value);
            /*0x7a82a8c*/ void SetInternalFeatureFlag(string featureName, bool enabled);
            /*0x7a82be4*/ bool IsFeatureEnabled(string featureName);
            /*0x7a825bc*/ void OnChange();

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

            /*0x7a83060*/ DefaultInputActions();
            /*0x7a83058*/ UnityEngine.InputSystem.InputActionAsset get_asset();
            /*0x7a83494*/ void Dispose();
            /*0x7a834f0*/ System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask();
            /*0x7a83518*/ void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value);
            /*0x7a83564*/ System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices();
            /*0x7a835a4*/ void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value);
            /*0x7a835f0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes();
            /*0x7a8360c*/ bool Contains(UnityEngine.InputSystem.InputAction action);
            /*0x7a83628*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator();
            /*0x7a83644*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7a83660*/ void Enable();
            /*0x7a8367c*/ void Disable();
            /*0x7a83698*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings();
            /*0x7a836b4*/ UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound);
            /*0x7a836d4*/ int FindBinding(UnityEngine.InputSystem.InputBinding bindingMask, ref UnityEngine.InputSystem.InputAction action);
            /*0x7a83730*/ UnityEngine.InputSystem.DefaultInputActions.PlayerActions get_Player();
            /*0x7a83750*/ UnityEngine.InputSystem.DefaultInputActions.UIActions get_UI();
            /*0x7a83770*/ UnityEngine.InputSystem.InputControlScheme get_KeyboardMouseScheme();
            /*0x7a83834*/ UnityEngine.InputSystem.InputControlScheme get_GamepadScheme();
            /*0x7a838f8*/ UnityEngine.InputSystem.InputControlScheme get_TouchScheme();
            /*0x7a839bc*/ UnityEngine.InputSystem.InputControlScheme get_JoystickScheme();
            /*0x7a83a80*/ UnityEngine.InputSystem.InputControlScheme get_XRScheme();

            struct PlayerActions
            {
                /*0x10*/ UnityEngine.InputSystem.DefaultInputActions m_Wrapper;

                static /*0x7a83c28*/ UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.PlayerActions set);
                /*0x7a83b44*/ PlayerActions(UnityEngine.InputSystem.DefaultInputActions wrapper);
                /*0x7a83b4c*/ UnityEngine.InputSystem.InputAction get_Move();
                /*0x7a83b68*/ UnityEngine.InputSystem.InputAction get_Look();
                /*0x7a83b84*/ UnityEngine.InputSystem.InputAction get_Fire();
                /*0x7a83ba0*/ UnityEngine.InputSystem.InputActionMap Get();
                /*0x7a83bbc*/ void Enable();
                /*0x7a83be0*/ void Disable();
                /*0x7a83c04*/ bool get_enabled();
                /*0x7a83c40*/ void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IPlayerActions instance);
            }

            struct UIActions
            {
                /*0x10*/ UnityEngine.InputSystem.DefaultInputActions m_Wrapper;

                static /*0x7a848c4*/ UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.UIActions set);
                /*0x7a8471c*/ UIActions(UnityEngine.InputSystem.DefaultInputActions wrapper);
                /*0x7a84724*/ UnityEngine.InputSystem.InputAction get_Navigate();
                /*0x7a84740*/ UnityEngine.InputSystem.InputAction get_Submit();
                /*0x7a8475c*/ UnityEngine.InputSystem.InputAction get_Cancel();
                /*0x7a84778*/ UnityEngine.InputSystem.InputAction get_Point();
                /*0x7a84794*/ UnityEngine.InputSystem.InputAction get_Click();
                /*0x7a847b0*/ UnityEngine.InputSystem.InputAction get_ScrollWheel();
                /*0x7a847cc*/ UnityEngine.InputSystem.InputAction get_MiddleClick();
                /*0x7a847e8*/ UnityEngine.InputSystem.InputAction get_RightClick();
                /*0x7a84804*/ UnityEngine.InputSystem.InputAction get_TrackedDevicePosition();
                /*0x7a84820*/ UnityEngine.InputSystem.InputAction get_TrackedDeviceOrientation();
                /*0x7a8483c*/ UnityEngine.InputSystem.InputActionMap Get();
                /*0x7a84858*/ void Enable();
                /*0x7a8487c*/ void Disable();
                /*0x7a848a0*/ bool get_enabled();
                /*0x7a848dc*/ void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IUIActions instance);
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

            /*0x7a86ce4*/ InputValue();
            /*0x7a86c00*/ object Get();
            /*0x3907c14*/ TValue Get<TValue>();
            /*0x7a86c68*/ bool get_isPressed();
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

            static /*0x7a8e644*/ PlayerInput();
            static /*0x7a890e0*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all();
            static /*0x7a89170*/ bool get_isSinglePlayer();
            static /*0x7a8a498*/ UnityEngine.InputSystem.PlayerInput GetPlayerByIndex(int playerIndex);
            static /*0x7a8a594*/ UnityEngine.InputSystem.PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device);
            static /*0x7a8a6fc*/ UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, UnityEngine.InputSystem.InputDevice pairWithDevice);
            static /*0x7a8aab4*/ UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, UnityEngine.InputSystem.InputDevice[] pairWithDevices);
            static /*0x7a8a860*/ UnityEngine.InputSystem.PlayerInput DoInstantiate(UnityEngine.GameObject prefab);
            static /*0x7a8da1c*/ void OnUserChange(UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device);
            static /*0x7a8dbe8*/ bool OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a8e630*/ PlayerInput();
            /*0x7a86cec*/ bool get_inputIsActive();
            /*0x7a86cf4*/ bool get_active();
            /*0x7a86cfc*/ int get_playerIndex();
            /*0x7a86d04*/ int get_splitScreenIndex();
            /*0x7a86d0c*/ UnityEngine.InputSystem.InputActionAsset get_actions();
            /*0x7a87260*/ void set_actions(UnityEngine.InputSystem.InputActionAsset value);
            /*0x7a87ffc*/ string get_currentControlScheme();
            /*0x7a8821c*/ string get_defaultControlScheme();
            /*0x7a88224*/ void set_defaultControlScheme(string value);
            /*0x7a8822c*/ bool get_neverAutoSwitchControlSchemes();
            /*0x7a88234*/ void set_neverAutoSwitchControlSchemes(bool value);
            /*0x7a88430*/ UnityEngine.InputSystem.InputActionMap get_currentActionMap();
            /*0x7a88438*/ void set_currentActionMap(UnityEngine.InputSystem.InputActionMap value);
            /*0x7a884a0*/ string get_defaultActionMap();
            /*0x7a884a8*/ void set_defaultActionMap(string value);
            /*0x7a884b0*/ UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior();
            /*0x7a884b8*/ void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value);
            /*0x7a88510*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents();
            /*0x7a88558*/ void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value);
            /*0x7a885e4*/ UnityEngine.InputSystem.PlayerInput.DeviceLostEvent get_deviceLostEvent();
            /*0x7a88698*/ UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent get_deviceRegainedEvent();
            /*0x7a8874c*/ UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent get_controlsChangedEvent();
            /*0x7a88800*/ void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x7a8889c*/ void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value);
            /*0x7a88938*/ void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a889d4*/ void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a88a70*/ void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a88b0c*/ void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a88ba8*/ void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a88c44*/ void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a88ce0*/ UnityEngine.Camera get_camera();
            /*0x7a88ce8*/ void set_camera(UnityEngine.Camera value);
            /*0x7a88cf0*/ UnityEngine.InputSystem.UI.InputSystemUIInputModule get_uiInputModule();
            /*0x7a88cf8*/ void set_uiInputModule(UnityEngine.InputSystem.UI.InputSystemUIInputModule value);
            /*0x7a88e70*/ UnityEngine.InputSystem.Users.InputUser get_user();
            /*0x7a88e78*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices();
            /*0x7a88fb8*/ bool get_hasMissingRequiredDevices();
            /*0x3907c14*/ TDevice GetDevice<TDevice>();
            /*0x7a87f40*/ void ActivateInput();
            /*0x7a89288*/ void UpdateDelegates();
            /*0x7a89b98*/ void DeactivateInput();
            /*0x7a89bbc*/ void PassivateInput();
            /*0x7a89be0*/ bool SwitchCurrentControlScheme(UnityEngine.InputSystem.InputDevice[] devices);
            /*0x7a8a26c*/ void SwitchCurrentControlScheme(string controlScheme, UnityEngine.InputSystem.InputDevice[] devices);
            /*0x7a89484*/ void SwitchCurrentActionMap(string mapNameOrId);
            /*0x7a86d50*/ void InitializeActions();
            /*0x7a87370*/ void UninitializeActions();
            /*0x7a895ec*/ void InstallOnActionTriggeredHook();
            /*0x7a8ac50*/ void UninstallOnActionTriggeredHook();
            /*0x7a8addc*/ void OnActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7a897c0*/ void CacheMessageNames();
            /*0x7a87544*/ void ClearCaches();
            /*0x7a8759c*/ void AssignUserAndDevices();
            /*0x7a8b84c*/ bool HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device);
            /*0x7a8bd34*/ void UnassignUserAndDevices();
            /*0x7a8b548*/ bool TryToActivateControlScheme(UnityEngine.InputSystem.InputControlScheme controlScheme);
            /*0x7a8c200*/ void AssignPlayerIndex();
            /*0x7a8c3fc*/ void OnEnable();
            /*0x7a8826c*/ void StartListeningForUnpairedDeviceActivity();
            /*0x7a883b4*/ void StopListeningForUnpairedDeviceActivity();
            /*0x7a8c9ac*/ void StartListeningForDeviceChanges();
            /*0x7a8d1e4*/ void StopListeningForDeviceChanges();
            /*0x7a8d250*/ void OnDisable();
            /*0x7a8d75c*/ void DebugLogAction(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7a8d7d4*/ void HandleDeviceLost();
            /*0x7a8d8f8*/ void HandleDeviceRegained();
            /*0x7a8ca7c*/ void HandleControlsChanged();
            /*0x7a8dd2c*/ void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a8e3e0*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
            /*0x7a89dac*/ void SwitchControlSchemeInternal(ref UnityEngine.InputSystem.InputControlScheme controlScheme, UnityEngine.InputSystem.InputDevice[] devices);

            class ActionEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.InputAction.CallbackContext>
            {
                /*0x30*/ string m_ActionId;
                /*0x38*/ string m_ActionName;

                /*0x7a8e6a0*/ ActionEvent();
                /*0x7a8e6e8*/ ActionEvent(UnityEngine.InputSystem.InputAction action);
                /*0x7a8e8d0*/ ActionEvent(System.Guid actionGUID, string name);
                /*0x7a8e690*/ string get_actionId();
                /*0x7a8e698*/ string get_actionName();
            }

            class DeviceLostEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a88650*/ DeviceLostEvent();
            }

            class DeviceRegainedEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a88704*/ DeviceRegainedEvent();
            }

            class ControlsChangedEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a887b8*/ ControlsChangedEvent();
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

            static /*0x7a8f984*/ UnityEngine.InputSystem.PlayerInputManager get_instance();
            static /*0x7a8f9cc*/ void set_instance(UnityEngine.InputSystem.PlayerInputManager value);
            static /*0x7a90008*/ string[] get_messages();
            /*0x7a90978*/ PlayerInputManager();
            /*0x7a8e960*/ bool get_splitScreen();
            /*0x7a8e968*/ void set_splitScreen(bool value);
            /*0x7a8f0f8*/ bool get_maintainAspectRatioInSplitScreen();
            /*0x7a8f100*/ int get_fixedNumberOfSplitScreens();
            /*0x7a8f108*/ UnityEngine.Rect get_splitScreenArea();
            /*0x7a8f114*/ int get_playerCount();
            /*0x7a8f16c*/ int get_maxPlayerCount();
            /*0x7a8f174*/ bool get_joiningEnabled();
            /*0x7a8f17c*/ UnityEngine.InputSystem.PlayerJoinBehavior get_joinBehavior();
            /*0x7a8f184*/ void set_joinBehavior(UnityEngine.InputSystem.PlayerJoinBehavior value);
            /*0x7a8f4bc*/ UnityEngine.InputSystem.InputActionProperty get_joinAction();
            /*0x7a8f4d0*/ void set_joinAction(UnityEngine.InputSystem.InputActionProperty value);
            /*0x7a8f58c*/ UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior();
            /*0x7a8f594*/ void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value);
            /*0x7a8f59c*/ UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent get_playerJoinedEvent();
            /*0x7a8f650*/ UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent get_playerLeftEvent();
            /*0x7a8f704*/ void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a8f7a0*/ void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a8f83c*/ void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a8f8d8*/ void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value);
            /*0x7a8f974*/ UnityEngine.GameObject get_playerPrefab();
            /*0x7a8f97c*/ void set_playerPrefab(UnityEngine.GameObject value);
            /*0x7a8f2b8*/ void EnableJoining();
            /*0x7a8f1d4*/ void DisableJoining();
            /*0x7a8fa28*/ void JoinPlayerFromUI();
            /*0x7a8fd54*/ void JoinPlayerFromAction(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7a8fe64*/ void JoinPlayerFromActionIfNotAlreadyJoined(UnityEngine.InputSystem.InputAction.CallbackContext context);
            /*0x7a8fda8*/ UnityEngine.InputSystem.PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, UnityEngine.InputSystem.InputDevice pairWithDevice);
            /*0x7a8ff4c*/ UnityEngine.InputSystem.PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, UnityEngine.InputSystem.InputDevice[] pairWithDevices);
            /*0x7a8fa74*/ bool CheckIfPlayerCanJoin(int playerIndex);
            /*0x7a900c4*/ void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
            /*0x7a9053c*/ void OnEnable();
            /*0x7a9088c*/ void OnDisable();
            /*0x7a8eb9c*/ void UpdateSplitScreen();
            /*0x7a90178*/ bool IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device);
            /*0x7a8fa24*/ void ValidateInputActionAsset();
            /*0x7a8cba0*/ void NotifyPlayerJoined(UnityEngine.InputSystem.PlayerInput player);
            /*0x7a8d62c*/ void NotifyPlayerLeft(UnityEngine.InputSystem.PlayerInput player);

            class PlayerJoinedEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a8f608*/ PlayerJoinedEvent();
            }

            class PlayerLeftEvent : UnityEngine.Events.UnityEvent<UnityEngine.InputSystem.PlayerInput>
            {
                /*0x7a8f6bc*/ PlayerLeftEvent();
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

            static /*0x7a909a0*/ int BitCountToULongCount(int bitCount);
            /*0x7a8159c*/ void SetLength(int newLength);
            /*0x7a909b8*/ void SetBit(int bitIndex);
            /*0x7a90a50*/ bool TestBit(int bitIndex);
            /*0x7a816c4*/ void ClearBit(int bitIndex);
            /*0x7a90ac0*/ bool AnyBitIsSet();
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

                static /*0x7a90bdc*/ PoseState();
                /*0x7a90b9c*/ PoseState(bool isTracked, UnityEngine.XR.InputTrackingState trackingState, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 velocity, UnityEngine.Vector3 angularVelocity);
                /*0x7a90b44*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            class PoseControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.XR.PoseState>
            {
                /*0x178*/ UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;
                /*0x180*/ UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;
                /*0x188*/ UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField;
                /*0x190*/ UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField;
                /*0x198*/ UnityEngine.InputSystem.Controls.Vector3Control <velocity>k__BackingField;
                /*0x1a0*/ UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField;

                /*0x7a90cd8*/ PoseControl();
                /*0x7a90c48*/ UnityEngine.InputSystem.Controls.ButtonControl get_isTracked();
                /*0x7a90c50*/ void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a90c60*/ UnityEngine.InputSystem.Controls.IntegerControl get_trackingState();
                /*0x7a90c68*/ void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a90c78*/ UnityEngine.InputSystem.Controls.Vector3Control get_position();
                /*0x7a90c80*/ void set_position(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a90c90*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rotation();
                /*0x7a90c98*/ void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a90ca8*/ UnityEngine.InputSystem.Controls.Vector3Control get_velocity();
                /*0x7a90cb0*/ void set_velocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a90cc0*/ UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity();
                /*0x7a90cc8*/ void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a90d88*/ void FinishSetup();
                /*0x7a90f78*/ UnityEngine.InputSystem.XR.PoseState ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a91194*/ void WriteValueIntoState(UnityEngine.InputSystem.XR.PoseState value, void* statePtr);
                /*0x7a91310*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class XRHMD : UnityEngine.InputSystem.TrackedDevice
            {
                /*0x1a8*/ UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField;
                /*0x1b0*/ UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField;
                /*0x1b8*/ UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField;
                /*0x1c0*/ UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField;
                /*0x1c8*/ UnityEngine.InputSystem.Controls.Vector3Control <centerEyePosition>k__BackingField;
                /*0x1d0*/ UnityEngine.InputSystem.Controls.QuaternionControl <centerEyeRotation>k__BackingField;

                /*0x7a91770*/ XRHMD();
                /*0x7a9152c*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition();
                /*0x7a91534*/ void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a91544*/ UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation();
                /*0x7a9154c*/ void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a9155c*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition();
                /*0x7a91564*/ void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a91574*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation();
                /*0x7a9157c*/ void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a9158c*/ UnityEngine.InputSystem.Controls.Vector3Control get_centerEyePosition();
                /*0x7a91594*/ void set_centerEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a915a4*/ UnityEngine.InputSystem.Controls.QuaternionControl get_centerEyeRotation();
                /*0x7a915ac*/ void set_centerEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a915bc*/ void FinishSetup();
            }

            class XRController : UnityEngine.InputSystem.TrackedDevice
            {
                static /*0x7a91778*/ UnityEngine.InputSystem.XR.XRController get_leftHand();
                static /*0x7a91818*/ UnityEngine.InputSystem.XR.XRController get_rightHand();
                /*0x7a919f8*/ XRController();
                /*0x7a918b8*/ void FinishSetup();
            }

            class XRControllerWithRumble : UnityEngine.InputSystem.XR.XRController
            {
                /*0x7a91b28*/ XRControllerWithRumble();
                /*0x7a91a00*/ void SendImpulse(float amplitude, float duration);
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

                /*0x7a93274*/ TrackedPoseDriver();
                /*0x7a91b30*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType get_trackingType();
                /*0x7a91b38*/ void set_trackingType(UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType value);
                /*0x7a91b40*/ UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType get_updateType();
                /*0x7a91b48*/ void set_updateType(UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType value);
                /*0x7a91b50*/ bool get_ignoreTrackingState();
                /*0x7a91b58*/ void set_ignoreTrackingState(bool value);
                /*0x7a91b64*/ UnityEngine.InputSystem.InputActionProperty get_positionInput();
                /*0x7a91b78*/ void set_positionInput(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7a91f18*/ UnityEngine.InputSystem.InputActionProperty get_rotationInput();
                /*0x7a91f2c*/ void set_rotationInput(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7a922cc*/ UnityEngine.InputSystem.InputActionProperty get_trackingStateInput();
                /*0x7a922e0*/ void set_trackingStateInput(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7a92680*/ void BindActions();
                /*0x7a926a0*/ void UnbindActions();
                /*0x7a91d88*/ void BindPosition();
                /*0x7a9213c*/ void BindRotation();
                /*0x7a924f0*/ void BindTrackingState();
                /*0x7a926c0*/ void RenameAndEnable(UnityEngine.InputSystem.InputAction action, string name);
                /*0x7a91c44*/ void UnbindPosition();
                /*0x7a91ff8*/ void UnbindRotation();
                /*0x7a923ac*/ void UnbindTrackingState();
                /*0x7a926f0*/ void OnPositionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a92750*/ void OnPositionCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a927a8*/ void OnRotationPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a92808*/ void OnRotationCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a92858*/ void OnTrackingStatePerformed(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a928b4*/ void OnTrackingStateCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a928bc*/ void Reset();
                /*0x7a92ab4*/ void Awake();
                /*0x7a92b64*/ void OnEnable();
                /*0x7a92c1c*/ void OnDisable();
                /*0x7a92cc8*/ void OnDestroy();
                /*0x7a92cf4*/ void UpdateCallback();
                /*0x7a92e18*/ void ReadTrackingState();
                /*0x7a92f4c*/ void OnUpdate();
                /*0x7a92f68*/ void OnBeforeRender();
                /*0x7a92f88*/ void PerformUpdate();
                /*0x7a92fa4*/ void SetLocalTransform(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation);
                /*0x7a92ae0*/ bool HasStereoCamera(ref UnityEngine.Camera cameraComponent);
                /*0x7a93110*/ UnityEngine.InputSystem.InputAction get_positionAction();
                /*0x7a9311c*/ void set_positionAction(UnityEngine.InputSystem.InputAction value);
                /*0x7a93164*/ UnityEngine.InputSystem.InputAction get_rotationAction();
                /*0x7a93170*/ void set_rotationAction(UnityEngine.InputSystem.InputAction value);
                /*0x7a931b8*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x7a931bc*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

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

                static /*0x7a9473c*/ XRLayoutBuilder();
                static /*0x7a9331c*/ uint GetSizeOfFeature(UnityEngine.InputSystem.XR.XRFeatureDescriptor featureDescriptor);
                static /*0x7a93394*/ string SanitizeString(string original, bool allowPaths);
                static /*0x7a934e4*/ string OnFindLayoutForDevice(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate);
                static /*0x7a93934*/ string ConvertPotentialAliasToName(UnityEngine.InputSystem.Layouts.InputControlLayout layout, string nameOrAlias);
                /*0x7a9392c*/ XRLayoutBuilder();
                /*0x7a93ab0*/ bool IsSubControl(string name);
                /*0x7a93acc*/ string GetParentControlName(string name);
                /*0x7a93b04*/ bool IsPoseControl(System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor> features, int startIndex);
                /*0x7a93c58*/ UnityEngine.InputSystem.Layouts.InputControlLayout Build();

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.InputSystem.XR.XRLayoutBuilder layout;

                    /*0x7a93924*/ <>c__DisplayClass5_0();
                    /*0x7a94950*/ UnityEngine.InputSystem.Layouts.InputControlLayout <OnFindLayoutForDevice>b__0();
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

                static /*0x7a919b0*/ UnityEngine.InputSystem.XR.XRDeviceDescriptor FromJson(string json);
                /*0x7a94970*/ XRDeviceDescriptor();
                /*0x7a94968*/ string ToJson();
            }

            struct Bone
            {
                /*0x10*/ uint m_ParentBoneIndex;
                /*0x14*/ UnityEngine.Vector3 m_Position;
                /*0x20*/ UnityEngine.Quaternion m_Rotation;

                /*0x7a94978*/ uint get_parentBoneIndex();
                /*0x7a94980*/ void set_parentBoneIndex(uint value);
                /*0x7a94988*/ UnityEngine.Vector3 get_position();
                /*0x7a94994*/ void set_position(UnityEngine.Vector3 value);
                /*0x7a949a0*/ UnityEngine.Quaternion get_rotation();
                /*0x7a949ac*/ void set_rotation(UnityEngine.Quaternion value);
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

                /*0x7a949b8*/ UnityEngine.Vector3 get_leftEyePosition();
                /*0x7a949c4*/ void set_leftEyePosition(UnityEngine.Vector3 value);
                /*0x7a949d0*/ UnityEngine.Quaternion get_leftEyeRotation();
                /*0x7a949dc*/ void set_leftEyeRotation(UnityEngine.Quaternion value);
                /*0x7a949e8*/ UnityEngine.Vector3 get_rightEyePosition();
                /*0x7a949f4*/ void set_rightEyePosition(UnityEngine.Vector3 value);
                /*0x7a94a00*/ UnityEngine.Quaternion get_rightEyeRotation();
                /*0x7a94a0c*/ void set_rightEyeRotation(UnityEngine.Quaternion value);
                /*0x7a94a18*/ UnityEngine.Vector3 get_fixationPoint();
                /*0x7a94a24*/ void set_fixationPoint(UnityEngine.Vector3 value);
                /*0x7a94a30*/ float get_leftEyeOpenAmount();
                /*0x7a94a38*/ void set_leftEyeOpenAmount(float value);
                /*0x7a94a40*/ float get_rightEyeOpenAmount();
                /*0x7a94a48*/ void set_rightEyeOpenAmount(float value);
            }

            class BoneControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.XR.Bone>
            {
                /*0x140*/ UnityEngine.InputSystem.Controls.IntegerControl <parentBoneIndex>k__BackingField;
                /*0x148*/ UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField;
                /*0x150*/ UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField;

                /*0x7a94d44*/ BoneControl();
                /*0x7a94a50*/ UnityEngine.InputSystem.Controls.IntegerControl get_parentBoneIndex();
                /*0x7a94a58*/ void set_parentBoneIndex(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a94a68*/ UnityEngine.InputSystem.Controls.Vector3Control get_position();
                /*0x7a94a70*/ void set_position(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a94a80*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rotation();
                /*0x7a94a88*/ void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a94a98*/ void FinishSetup();
                /*0x7a94bd0*/ UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a94cc0*/ void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, void* statePtr);
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

                /*0x7a95324*/ EyesControl();
                /*0x7a94d8c*/ UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition();
                /*0x7a94d94*/ void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a94da4*/ UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation();
                /*0x7a94dac*/ void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a94dbc*/ UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition();
                /*0x7a94dc4*/ void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a94dd4*/ UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation();
                /*0x7a94ddc*/ void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value);
                /*0x7a94dec*/ UnityEngine.InputSystem.Controls.Vector3Control get_fixationPoint();
                /*0x7a94df4*/ void set_fixationPoint(UnityEngine.InputSystem.Controls.Vector3Control value);
                /*0x7a94e04*/ UnityEngine.InputSystem.Controls.AxisControl get_leftEyeOpenAmount();
                /*0x7a94e0c*/ void set_leftEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a94e1c*/ UnityEngine.InputSystem.Controls.AxisControl get_rightEyeOpenAmount();
                /*0x7a94e24*/ void set_rightEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a94e34*/ void FinishSetup();
                /*0x7a95044*/ UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a95210*/ void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, void* statePtr);
            }

            class XRSupport
            {
                static /*0x7a9536c*/ void Initialize();
            }

            namespace Haptics
            {
                struct BufferedRumble
                {
                    /*0x10*/ UnityEngine.InputSystem.XR.Haptics.HapticCapabilities <capabilities>k__BackingField;
                    /*0x28*/ UnityEngine.InputSystem.InputDevice <device>k__BackingField;

                    /*0x7a95efc*/ BufferedRumble(UnityEngine.InputSystem.InputDevice device);
                    /*0x7a95ec4*/ UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities();
                    /*0x7a95ed8*/ void set_capabilities(UnityEngine.InputSystem.XR.Haptics.HapticCapabilities value);
                    /*0x7a95eec*/ UnityEngine.InputSystem.InputDevice get_device();
                    /*0x7a95ef4*/ void set_device(UnityEngine.InputSystem.InputDevice value);
                    /*0x7a9609c*/ void EnqueueRumble(byte[] samples);
                }

                struct HapticState
                {
                    /*0x10*/ uint <samplesQueued>k__BackingField;
                    /*0x14*/ uint <samplesAvailable>k__BackingField;

                    /*0x7a962a8*/ HapticState(uint samplesQueued, uint samplesAvailable);
                    /*0x7a962b0*/ uint get_samplesQueued();
                    /*0x7a962b8*/ void set_samplesQueued(uint value);
                    /*0x7a962c0*/ uint get_samplesAvailable();
                    /*0x7a962c8*/ void set_samplesAvailable(uint value);
                }

                struct GetCurrentHapticStateCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
                {
                    static int kSize = 16;
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                    /*0x18*/ uint samplesQueued;
                    /*0x1c*/ uint samplesAvailable;

                    static /*0x7a962d0*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7a96338*/ UnityEngine.InputSystem.XR.Haptics.GetCurrentHapticStateCommand Create();
                    /*0x7a96300*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                    /*0x7a96330*/ UnityEngine.InputSystem.XR.Haptics.HapticState get_currentState();
                }

                struct HapticCapabilities
                {
                    /*0x10*/ uint <numChannels>k__BackingField;
                    /*0x14*/ bool <supportsImpulse>k__BackingField;
                    /*0x15*/ bool <supportsBuffer>k__BackingField;
                    /*0x18*/ uint <frequencyHz>k__BackingField;
                    /*0x1c*/ uint <maxBufferSize>k__BackingField;
                    /*0x20*/ uint <optimalBufferSize>k__BackingField;

                    /*0x7a96388*/ HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize);
                    /*0x7a963a8*/ HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize);
                    /*0x7a963bc*/ uint get_numChannels();
                    /*0x7a963c4*/ bool get_supportsImpulse();
                    /*0x7a963cc*/ bool get_supportsBuffer();
                    /*0x7a963d4*/ uint get_frequencyHz();
                    /*0x7a963dc*/ uint get_maxBufferSize();
                    /*0x7a963e4*/ uint get_optimalBufferSize();
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

                    static /*0x7a963ec*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7a96014*/ UnityEngine.InputSystem.XR.Haptics.GetHapticCapabilitiesCommand Create();
                    /*0x7a9641c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                    /*0x7a96074*/ UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities();
                }

                struct SendBufferedHapticCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
                {
                    static int kMaxHapticBufferSize = 1024;
                    static int kSize = 1040;
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                    /*0x18*/ int channel;
                    /*0x1c*/ int bufferSize;
                    /*0x20*/ UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand.<buffer> buffer;

                    static /*0x7a9644c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7a96144*/ UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand Create(byte[] rumbleBuffer);
                    /*0x7a9647c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

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

                    static /*0x7a964ac*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                    static /*0x7a91aac*/ UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration);
                    /*0x7a964dc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
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

                /*0x7a96628*/ XInputController();
                /*0x7a9650c*/ UnityEngine.InputSystem.Controls.ButtonControl get_menu();
                /*0x7a96514*/ void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a96524*/ UnityEngine.InputSystem.Controls.ButtonControl get_view();
                /*0x7a9652c*/ void set_view(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a9653c*/ UnityEngine.InputSystem.XInput.XInputController.DeviceSubType get_subType();
                /*0x7a965d0*/ UnityEngine.InputSystem.XInput.XInputController.DeviceFlags get_flags();
                /*0x7a965f4*/ void FinishSetup();
                /*0x7a96560*/ void ParseCapabilities();

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
                static /*0x7a96630*/ void Initialize();
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

                static /*0x7a9bb90*/ InputUser();
                static /*0x7a96c14*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all();
                static /*0x7a8c8e8*/ void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> value);
                static /*0x7a8d568*/ void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> value);
                static /*0x7a8ccd0*/ void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7a8d004*/ void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7a8cdc4*/ void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> value);
                static /*0x7a8d120*/ void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> value);
                static /*0x7a8ce88*/ int get_listenForUnpairedDeviceActivity();
                static /*0x7a8cee0*/ void set_listenForUnpairedDeviceActivity(int value);
                static /*0x7a98668*/ void RemoveLostDevicesForUser(int userIndex);
                static /*0x7a8b7ac*/ UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices();
                static /*0x7a99118*/ int GetUnpairedInputDevices(ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> list);
                static /*0x7a9933c*/ System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a995ac*/ System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle);
                static /*0x7a8be90*/ UnityEngine.InputSystem.Users.InputUser CreateUserWithoutPairedDevices();
                static /*0x7a8b2dc*/ UnityEngine.InputSystem.Users.InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserPairingOptions options);
                static /*0x7a99908*/ bool InitiateUserAccountSelection(int userIndex, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUserPairingOptions options);
                static /*0x7a8dbdc*/ bool op_Equality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right);
                static /*0x7a998fc*/ bool op_Inequality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right);
                static /*0x7a99800*/ int AddUser();
                static /*0x7a98d70*/ void RemoveUser(int userIndex);
                static /*0x7a979ec*/ void Notify(int userIndex, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device);
                static /*0x7a967c4*/ int TryFindUserIndex(uint userId);
                static /*0x7a99708*/ int TryFindUserIndex(UnityEngine.InputSystem.Users.InputUserAccountHandle platformHandle);
                static /*0x7a9945c*/ int TryFindUserIndex(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a99a78*/ void AddDeviceToUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice, bool dontUpdateControlScheme);
                static /*0x7a98820*/ void RemoveDeviceFromUser(int userIndex, UnityEngine.InputSystem.InputDevice device, bool asLostDevice);
                static /*0x7a97d34*/ void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing);
                static /*0x7a99fd4*/ long UpdatePlatformUserAccount(int userIndex, UnityEngine.InputSystem.InputDevice device);
                static /*0x7a9a8b0*/ long QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, ref System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> platformAccountHandle, ref string platformAccountName, ref string platformAccountId);
                static /*0x7a9a454*/ bool InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device);
                static /*0x7a9aa6c*/ void OnActionChange(object obj, UnityEngine.InputSystem.InputActionChange change);
                static /*0x7a9ab58*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
                static /*0x7a9b1b8*/ int FindLostDevice(UnityEngine.InputSystem.InputDevice device, int startIndex);
                static /*0x7a9b290*/ void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                static /*0x7a9b844*/ UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState();
                static /*0x7a9717c*/ void HookIntoActionChange();
                static /*0x7a9a7c4*/ void UnhookFromActionChange();
                static /*0x7a9a514*/ void HookIntoDeviceChange();
                static /*0x7a9a714*/ void UnhookFromDeviceChange();
                static /*0x7a96ca4*/ void HookIntoEvents();
                static /*0x7a96dfc*/ void UnhookFromDeviceStateChange();
                static /*0x7a9ba5c*/ void DisposeAndResetGlobalState();
                static /*0x7a9bb38*/ void ResetGlobals();
                /*0x7a880b0*/ bool get_valid();
                /*0x7a966a0*/ int get_index();
                /*0x7a9687c*/ uint get_id();
                /*0x7a96884*/ System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle();
                /*0x7a96924*/ string get_platformUserAccountName();
                /*0x7a969ac*/ string get_platformUserAccountId();
                /*0x7a88efc*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices();
                /*0x7a96a34*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices();
                /*0x7a96af0*/ UnityEngine.InputSystem.IInputActionCollection get_actions();
                /*0x7a88180*/ System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme();
                /*0x7a96b78*/ UnityEngine.InputSystem.InputControlScheme.MatchResult get_controlSchemeMatch();
                /*0x7a89054*/ bool get_hasMissingRequiredDevices();
                /*0x7a96ecc*/ string ToString();
                /*0x7a8b954*/ void AssociateActionsWithUser(UnityEngine.InputSystem.IInputActionCollection actions);
                /*0x7a8c12c*/ UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(string schemeName);
                /*0x7a97734*/ bool TryFindControlScheme(string schemeName, ref UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7a8a384*/ void FindControlScheme(string schemeName, ref UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7a8bf0c*/ UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7a972d8*/ void ActivateControlSchemeInternal(int userIndex, UnityEngine.InputSystem.InputControlScheme scheme);
                /*0x7a8e524*/ void UnpairDevice(UnityEngine.InputSystem.InputDevice device);
                /*0x7a8afec*/ void UnpairDevices();
                /*0x7a8be28*/ void UnpairDevicesAndRemoveUser();
                /*0x7a9a654*/ bool Equals(UnityEngine.InputSystem.Users.InputUser other);
                /*0x7a9a664*/ bool Equals(object obj);
                /*0x7a9a70c*/ int GetHashCode();

                struct ControlSchemeChangeSyntax
                {
                    /*0x10*/ int m_UserIndex;

                    /*0x7a9bc44*/ UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax AndPairRemainingDevices();
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

                    static /*0x7a9bce8*/ System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device);
                    /*0x7a9bcac*/ int Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y);
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

                    static /*0x7a9bd20*/ <>c();
                    /*0x7a9bd88*/ <>c();
                    /*0x7a9bd90*/ void <SaveAndResetState>b__88_0(ref UnityEngine.InputSystem.Users.InputUser.GlobalState state);
                    /*0x7a9be28*/ void <SaveAndResetState>b__88_1();
                }
            }

            struct InputUserAccountHandle : System.IEquatable<UnityEngine.InputSystem.Users.InputUserAccountHandle>
            {
                /*0x10*/ string m_ApiName;
                /*0x18*/ ulong m_Handle;

                static /*0x7a9bcf4*/ bool op_Equality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right);
                static /*0x7a9c0c4*/ bool op_Inequality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right);
                /*0x7a9be88*/ InputUserAccountHandle(string apiName, ulong handle);
                /*0x7a9be78*/ string get_apiName();
                /*0x7a9be80*/ ulong get_handle();
                /*0x7a9bf14*/ string ToString();
                /*0x7a9bfcc*/ bool Equals(UnityEngine.InputSystem.Users.InputUserAccountHandle other);
                /*0x7a9c04c*/ bool Equals(object obj);
                /*0x7a9c0f4*/ int GetHashCode();
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

                /*0x7a9c230*/ InputUserSettings();
                /*0x7a9c14c*/ string get_customBindings();
                /*0x7a9c154*/ void set_customBindings(string value);
                /*0x7a9c15c*/ bool get_invertMouseX();
                /*0x7a9c164*/ void set_invertMouseX(bool value);
                /*0x7a9c170*/ bool get_invertMouseY();
                /*0x7a9c178*/ void set_invertMouseY(bool value);
                /*0x7a9c184*/ System.Nullable<float> get_mouseSmoothing();
                /*0x7a9c18c*/ void set_mouseSmoothing(System.Nullable<float> value);
                /*0x7a9c194*/ System.Nullable<float> get_mouseSensitivity();
                /*0x7a9c19c*/ void set_mouseSensitivity(System.Nullable<float> value);
                /*0x7a9c1a4*/ bool get_invertStickX();
                /*0x7a9c1ac*/ void set_invertStickX(bool value);
                /*0x7a9c1b8*/ bool get_invertStickY();
                /*0x7a9c1c0*/ void set_invertStickY(bool value);
                /*0x7a9c1cc*/ bool get_swapSticks();
                /*0x7a9c1d4*/ void set_swapSticks(bool value);
                /*0x7a9c1e0*/ bool get_swapBumpers();
                /*0x7a9c1e8*/ void set_swapBumpers(bool value);
                /*0x7a9c1f4*/ bool get_swapTriggers();
                /*0x7a9c1fc*/ void set_swapTriggers(bool value);
                /*0x7a9c208*/ bool get_swapDpadAndLeftStick();
                /*0x7a9c210*/ void set_swapDpadAndLeftStick(bool value);
                /*0x7a9c21c*/ float get_vibrationStrength();
                /*0x7a9c224*/ void set_vibrationStrength(float value);
                /*0x7a9c22c*/ void Apply(UnityEngine.InputSystem.IInputActionCollection actions);
            }
        }

        namespace UI
        {
            class BaseInputOverride : UnityEngine.EventSystems.BaseInput
            {
                /*0x20*/ string <compositionString>k__BackingField;

                /*0x7a9c240*/ BaseInputOverride();
                /*0x7a9c238*/ string get_compositionString();
            }

            class ExtendedAxisEventData : UnityEngine.EventSystems.AxisEventData
            {
                /*0x7a9c248*/ ExtendedAxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
                /*0x7a9c250*/ string ToString();
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

                static /*0x7a9c960*/ int MakePointerIdForTouch(int deviceId, int touchId);
                static /*0x7a9c968*/ int TouchIdFromPointerId(int pointerId);
                static /*0x7a9cc28*/ int GetPenPointerId(UnityEngine.InputSystem.Pen pen);
                static /*0x7a9ce7c*/ int GetTouchPointerId(UnityEngine.InputSystem.Controls.TouchControl touchControl);
                /*0x7a9c30c*/ ExtendedPointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
                /*0x7a9c314*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x7a9c31c*/ void set_control(UnityEngine.InputSystem.InputControl value);
                /*0x7a9c32c*/ UnityEngine.InputSystem.InputDevice get_device();
                /*0x7a9c334*/ void set_device(UnityEngine.InputSystem.InputDevice value);
                /*0x7a9c344*/ int get_touchId();
                /*0x7a9c34c*/ void set_touchId(int value);
                /*0x7a9c354*/ UnityEngine.InputSystem.UI.UIPointerType get_pointerType();
                /*0x7a9c35c*/ void set_pointerType(UnityEngine.InputSystem.UI.UIPointerType value);
                /*0x7a9c364*/ int get_uiToolkitPointerId();
                /*0x7a9c36c*/ void set_uiToolkitPointerId(int value);
                /*0x7a9c374*/ UnityEngine.Vector3 get_trackedDevicePosition();
                /*0x7a9c384*/ void set_trackedDevicePosition(UnityEngine.Vector3 value);
                /*0x7a9c394*/ UnityEngine.Quaternion get_trackedDeviceOrientation();
                /*0x7a9c3a8*/ void set_trackedDeviceOrientation(UnityEngine.Quaternion value);
                /*0x7a9c3bc*/ string ToString();
                /*0x7a9c970*/ void ReadDeviceState();
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

                static /*0x7aa3dd4*/ InputSystemUIInputModule();
                static /*0x7a9ed60*/ void ProcessPointerScroll(ref UnityEngine.InputSystem.UI.PointerModel pointer, UnityEngine.EventSystems.PointerEventData eventData);
                static /*0x7aa24c0*/ bool HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputActionReference actionReference);
                static /*0x7aa3c20*/ void SetActionCallback(UnityEngine.InputSystem.InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install);
                /*0x7aa3da0*/ InputSystemUIInputModule();
                /*0x7a9cf74*/ bool get_deselectOnBackgroundClick();
                /*0x7a9cf7c*/ void set_deselectOnBackgroundClick(bool value);
                /*0x7a9cf88*/ UnityEngine.InputSystem.UI.UIPointerBehavior get_pointerBehavior();
                /*0x7a9cf90*/ void set_pointerBehavior(UnityEngine.InputSystem.UI.UIPointerBehavior value);
                /*0x7a9cf98*/ UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior get_cursorLockBehavior();
                /*0x7a9cfa0*/ void set_cursorLockBehavior(UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior value);
                /*0x7a9cfa8*/ UnityEngine.GameObject get_localMultiPlayerRoot();
                /*0x7a9cfb0*/ void set_localMultiPlayerRoot(UnityEngine.GameObject value);
                /*0x7a9cfc0*/ float get_scrollDeltaPerTick();
                /*0x7a9cfc8*/ void set_scrollDeltaPerTick(float value);
                /*0x7a9cfd0*/ void ActivateModule();
                /*0x7a9d084*/ bool IsPointerOverGameObject(int pointerOrTouchId);
                /*0x7a9d31c*/ UnityEngine.EventSystems.RaycastResult GetLastRaycastResult(int pointerOrTouchId);
                /*0x7a9d3cc*/ UnityEngine.EventSystems.RaycastResult PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7a9dc8c*/ void ProcessPointer(ref UnityEngine.InputSystem.UI.PointerModel state);
                /*0x7a9eef4*/ bool PointerShouldIgnoreTransform(UnityEngine.Transform t);
                /*0x7a9e138*/ void ProcessPointerMovement(ref UnityEngine.InputSystem.UI.PointerModel pointer, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7a9eff4*/ void ProcessPointerMovement(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, UnityEngine.GameObject currentPointerTarget);
                /*0x7a9e1a0*/ void ProcessPointerButton(ref UnityEngine.InputSystem.UI.PointerModel.ButtonState button, UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7a9ea48*/ void ProcessPointerButtonDrag(ref UnityEngine.InputSystem.UI.PointerModel.ButtonState button, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7a9f9b8*/ void ProcessNavigation(ref UnityEngine.InputSystem.UI.NavigationModel navigationState);
                /*0x7aa0000*/ bool IsMoveAllowed(UnityEngine.EventSystems.AxisEventData eventData);
                /*0x7aa01f8*/ float get_moveRepeatDelay();
                /*0x7aa0200*/ void set_moveRepeatDelay(float value);
                /*0x7aa0208*/ float get_moveRepeatRate();
                /*0x7aa0210*/ void set_moveRepeatRate(float value);
                /*0x7aa0218*/ bool get_explictlyIgnoreFocus();
                /*0x7aa0280*/ bool get_shouldIgnoreFocus();
                /*0x7aa0348*/ float get_repeatRate();
                /*0x7aa0350*/ void set_repeatRate(float value);
                /*0x7aa0358*/ float get_repeatDelay();
                /*0x7aa0360*/ void set_repeatDelay(float value);
                /*0x7aa0368*/ UnityEngine.Transform get_xrTrackingOrigin();
                /*0x7aa0370*/ void set_xrTrackingOrigin(UnityEngine.Transform value);
                /*0x7aa0378*/ float get_trackedDeviceDragThresholdMultiplier();
                /*0x7aa0380*/ void set_trackedDeviceDragThresholdMultiplier(float value);
                /*0x7aa0388*/ void SwapAction(ref UnityEngine.InputSystem.InputActionReference property, UnityEngine.InputSystem.InputActionReference newValue, bool actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback);
                /*0x7aa092c*/ UnityEngine.InputSystem.InputActionReference get_point();
                /*0x7aa0934*/ void set_point(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa094c*/ UnityEngine.InputSystem.InputActionReference get_scrollWheel();
                /*0x7aa0954*/ void set_scrollWheel(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa096c*/ UnityEngine.InputSystem.InputActionReference get_leftClick();
                /*0x7aa0974*/ void set_leftClick(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa098c*/ UnityEngine.InputSystem.InputActionReference get_middleClick();
                /*0x7aa0994*/ void set_middleClick(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa09ac*/ UnityEngine.InputSystem.InputActionReference get_rightClick();
                /*0x7aa09b4*/ void set_rightClick(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa09cc*/ UnityEngine.InputSystem.InputActionReference get_move();
                /*0x7aa09d4*/ void set_move(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa09ec*/ UnityEngine.InputSystem.InputActionReference get_submit();
                /*0x7aa09f4*/ void set_submit(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa0a0c*/ UnityEngine.InputSystem.InputActionReference get_cancel();
                /*0x7aa0a14*/ void set_cancel(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa0a2c*/ UnityEngine.InputSystem.InputActionReference get_trackedDeviceOrientation();
                /*0x7aa0a34*/ void set_trackedDeviceOrientation(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa0a4c*/ UnityEngine.InputSystem.InputActionReference get_trackedDevicePosition();
                /*0x7aa0a54*/ void set_trackedDevicePosition(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa0a6c*/ void AssignDefaultActions();
                /*0x7aa106c*/ void UnassignActions();
                /*0x7aa11fc*/ UnityEngine.InputSystem.InputActionReference get_trackedDeviceSelect();
                /*0x7aa1234*/ void set_trackedDeviceSelect(UnityEngine.InputSystem.InputActionReference value);
                /*0x7aa126c*/ void Awake();
                /*0x7aa1314*/ void OnDestroy();
                /*0x7aa1358*/ void OnEnable();
                /*0x7aa1948*/ void OnDisable();
                /*0x7aa15a0*/ void ResetPointers();
                /*0x7aa1470*/ bool HasNoActions();
                /*0x7aa18ec*/ void EnableAllActions();
                /*0x7aa19f0*/ void DisableAllActions();
                /*0x7aa07c4*/ void EnableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference);
                /*0x7aa064c*/ void TryDisableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference, bool isComponentDisabling);
                /*0x7a9d1ec*/ int GetPointerStateIndexFor(int pointerOrTouchId);
                /*0x7aa1b68*/ ref UnityEngine.InputSystem.UI.PointerModel GetPointerStateForIndex(int index);
                /*0x7aa1bac*/ int GetDisplayIndexFor(UnityEngine.InputSystem.InputControl control);
                /*0x7aa1c58*/ int GetPointerStateIndexFor(ref UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa1d1c*/ int GetPointerStateIndexFor(UnityEngine.InputSystem.InputControl control, bool createIfNotExists);
                /*0x7aa2590*/ int AllocatePointer(int pointerId, int displayIndex, int touchId, UnityEngine.InputSystem.UI.UIPointerType pointerType, UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControl touchControl);
                /*0x7aa1a98*/ bool SendPointerExitEventsAndRemovePointer(int index);
                /*0x7aa2868*/ bool RemovePointerAtIndex(int index);
                /*0x7aa2ac0*/ void PurgeStalePointers();
                /*0x7aa2bdc*/ void OnPointCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa2ce8*/ bool IgnoreNextClick(ref UnityEngine.InputSystem.InputAction.CallbackContext context, bool wasPressed);
                /*0x7aa2e0c*/ void OnLeftClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa2f48*/ void OnRightClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa3030*/ void OnMiddleClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa1cb8*/ bool CheckForRemovedDevice(ref UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa3118*/ void OnScrollCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa3284*/ void OnMoveCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa32e4*/ void OnTrackedDeviceOrientationCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa33e4*/ void OnTrackedDevicePositionCallback(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa34e0*/ void OnControlsChanged(object obj);
                /*0x7aa34ec*/ void FilterPointerStatesByType();
                /*0x7aa3820*/ void Process();
                /*0x7aa3a04*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
                /*0x7aa3ad4*/ UnityEngine.Vector2 ConvertPointerEventScrollDeltaToTicks(UnityEngine.Vector2 scrollDelta);
                /*0x7aa15f8*/ void HookActions();
                /*0x7aa1344*/ void UnhookActions();
                /*0x7aa3b38*/ void SetActionCallbacks(bool install);
                /*0x7aa3d04*/ UnityEngine.InputSystem.InputActionReference UpdateReferenceForNewAsset(UnityEngine.InputSystem.InputActionReference actionReference);
                /*0x7aa3d8c*/ UnityEngine.InputSystem.InputActionAsset get_actionsAsset();
                /*0x7aa0e2c*/ void set_actionsAsset(UnityEngine.InputSystem.InputActionAsset value);
                /*0x7a9f8f8*/ bool get_sendPointerHoverToParent();
                /*0x7aa3d94*/ void set_sendPointerHoverToParent(bool value);

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

                /*0x7aa4088*/ MultiplayerEventSystem();
                /*0x7aa3e64*/ UnityEngine.GameObject get_playerRoot();
                /*0x7aa3e6c*/ void set_playerRoot(UnityEngine.GameObject value);
                /*0x7aa3f5c*/ void OnEnable();
                /*0x7aa3f78*/ void OnDisable();
                /*0x7aa3e88*/ void InitializePlayerRoot();
                /*0x7aa3f80*/ void Update();
            }

            struct NavigationModel
            {
                /*0x10*/ UnityEngine.Vector2 move;
                /*0x18*/ int consecutiveMoveCount;
                /*0x1c*/ UnityEngine.EventSystems.MoveDirection lastMoveDirection;
                /*0x20*/ float lastMoveTime;
                /*0x28*/ UnityEngine.EventSystems.AxisEventData eventData;

                /*0x7aa12c4*/ void Reset();
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

                /*0x7aa27ec*/ PointerModel(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData);
                /*0x7a9e184*/ UnityEngine.InputSystem.UI.UIPointerType get_pointerType();
                /*0x7aa40e0*/ UnityEngine.Vector2 get_screenPosition();
                /*0x7aa27ac*/ void set_screenPosition(UnityEngine.Vector2 value);
                /*0x7aa40ec*/ UnityEngine.Vector3 get_worldPosition();
                /*0x7aa348c*/ void set_worldPosition(UnityEngine.Vector3 value);
                /*0x7aa40fc*/ UnityEngine.Quaternion get_worldOrientation();
                /*0x7aa338c*/ void set_worldOrientation(UnityEngine.Quaternion value);
                /*0x7aa4110*/ UnityEngine.Vector2 get_scrollDelta();
                /*0x7aa3244*/ void set_scrollDelta(UnityEngine.Vector2 value);
                /*0x7aa411c*/ float get_pressure();
                /*0x7aa4124*/ void set_pressure(float value);
                /*0x7aa4144*/ float get_azimuthAngle();
                /*0x7aa414c*/ void set_azimuthAngle(float value);
                /*0x7aa416c*/ float get_altitudeAngle();
                /*0x7aa4174*/ void set_altitudeAngle(float value);
                /*0x7aa4194*/ float get_twist();
                /*0x7aa419c*/ void set_twist(float value);
                /*0x7aa41bc*/ UnityEngine.Vector2 get_radius();
                /*0x7aa41c8*/ void set_radius(UnityEngine.Vector2 value);
                /*0x7aa39bc*/ void OnFrameFinished();
                /*0x7aa3758*/ void CopyTouchOrPenStateFrom(UnityEngine.EventSystems.PointerEventData eventData);

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

                    /*0x7aa4214*/ bool get_isPressed();
                    /*0x7aa2ef4*/ void set_isPressed(bool value);
                    /*0x7aa421c*/ bool get_ignoreNextClick();
                    /*0x7aa4224*/ void set_ignoreNextClick(bool value);
                    /*0x7aa4230*/ float get_pressTime();
                    /*0x7aa4238*/ void set_pressTime(float value);
                    /*0x7aa4240*/ bool get_clickedOnSameGameObject();
                    /*0x7aa4248*/ void set_clickedOnSameGameObject(bool value);
                    /*0x7a9f900*/ bool get_wasPressedThisFrame();
                    /*0x7a9efe0*/ bool get_wasReleasedThisFrame();
                    /*0x7a9e068*/ void CopyPressStateTo(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7a9f910*/ void CopyPressStateFrom(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7aa4208*/ void OnEndFrame();
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

                static /*0x7aa4ee4*/ TrackedDeviceRaycaster();
                static /*0x7aa4b08*/ bool RayIntersectsRectTransform(UnityEngine.RectTransform transform, UnityEngine.Ray ray, ref UnityEngine.Vector3 worldPosition, ref float distance);
                /*0x7aa4e54*/ TrackedDeviceRaycaster();
                /*0x7aa4254*/ UnityEngine.Camera get_eventCamera();
                /*0x7aa4390*/ UnityEngine.LayerMask get_blockingMask();
                /*0x7aa4398*/ void set_blockingMask(UnityEngine.LayerMask value);
                /*0x7aa43a0*/ bool get_checkFor3DOcclusion();
                /*0x7aa43a8*/ void set_checkFor3DOcclusion(bool value);
                /*0x7aa43b4*/ bool get_checkFor2DOcclusion();
                /*0x7aa43bc*/ void set_checkFor2DOcclusion(bool value);
                /*0x7aa43c8*/ bool get_ignoreReversedGraphics();
                /*0x7aa43d0*/ void set_ignoreReversedGraphics(bool value);
                /*0x7aa43dc*/ float get_maxDistance();
                /*0x7aa43e4*/ void set_maxDistance(float value);
                /*0x7aa43ec*/ void OnEnable();
                /*0x7aa4470*/ void OnDisable();
                /*0x7aa4564*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
                /*0x7a9d620*/ void PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
                /*0x7aa460c*/ void SortedRaycastGraphics(UnityEngine.Canvas canvas, UnityEngine.Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results);
                /*0x7aa42e8*/ UnityEngine.Canvas get_canvas();

                struct RaycastHitData
                {
                    /*0x10*/ UnityEngine.UI.Graphic <graphic>k__BackingField;
                    /*0x18*/ UnityEngine.Vector3 <worldHitPosition>k__BackingField;
                    /*0x24*/ UnityEngine.Vector2 <screenPosition>k__BackingField;
                    /*0x2c*/ float <distance>k__BackingField;

                    /*0x7aa4e00*/ RaycastHitData(UnityEngine.UI.Graphic graphic, UnityEngine.Vector3 worldHitPosition, UnityEngine.Vector2 screenPosition, float distance);
                    /*0x7aa4f74*/ UnityEngine.UI.Graphic get_graphic();
                    /*0x7aa4f7c*/ UnityEngine.Vector3 get_worldHitPosition();
                    /*0x7aa4f88*/ UnityEngine.Vector2 get_screenPosition();
                    /*0x7aa4f90*/ float get_distance();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> <>9__25_0;

                    static /*0x7aa4f98*/ <>c();
                    /*0x7aa5000*/ <>c();
                    /*0x7aa5008*/ int <SortedRaycastGraphics>b__25_0(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData g1, UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData g2);
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

                static /*0x7aa5680*/ void SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install);
                static /*0x7aa54a8*/ void SetAction(ref UnityEngine.InputSystem.InputActionProperty field, UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa65e8*/ VirtualMouseInput();
                /*0x7aa505c*/ UnityEngine.RectTransform get_cursorTransform();
                /*0x7aa5064*/ void set_cursorTransform(UnityEngine.RectTransform value);
                /*0x7aa506c*/ float get_cursorSpeed();
                /*0x7aa5074*/ void set_cursorSpeed(float value);
                /*0x7aa507c*/ UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode get_cursorMode();
                /*0x7aa5084*/ void set_cursorMode(UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode value);
                /*0x7aa53c4*/ UnityEngine.UI.Graphic get_cursorGraphic();
                /*0x7aa53cc*/ void set_cursorGraphic(UnityEngine.UI.Graphic value);
                /*0x7aa544c*/ float get_scrollSpeed();
                /*0x7aa5454*/ void set_scrollSpeed(float value);
                /*0x7aa545c*/ UnityEngine.InputSystem.Mouse get_virtualMouse();
                /*0x7aa5464*/ UnityEngine.InputSystem.InputActionProperty get_stickAction();
                /*0x7aa5478*/ void set_stickAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa55dc*/ UnityEngine.InputSystem.InputActionProperty get_leftButtonAction();
                /*0x7aa55f0*/ void set_leftButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa56f0*/ UnityEngine.InputSystem.InputActionProperty get_rightButtonAction();
                /*0x7aa5704*/ void set_rightButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa5794*/ UnityEngine.InputSystem.InputActionProperty get_middleButtonAction();
                /*0x7aa57a8*/ void set_middleButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa5838*/ UnityEngine.InputSystem.InputActionProperty get_forwardButtonAction();
                /*0x7aa584c*/ void set_forwardButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa58dc*/ UnityEngine.InputSystem.InputActionProperty get_backButtonAction();
                /*0x7aa58f0*/ void set_backButtonAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa5980*/ UnityEngine.InputSystem.InputActionProperty get_scrollWheelAction();
                /*0x7aa5994*/ void set_scrollWheelAction(UnityEngine.InputSystem.InputActionProperty value);
                /*0x7aa59c4*/ void OnEnable();
                /*0x7aa5e04*/ void OnDisable();
                /*0x7aa53e8*/ void TryFindCanvas();
                /*0x7aa519c*/ void TryEnableHardwareCursor();
                /*0x7aa6050*/ void UpdateMotion();
                /*0x7aa63ec*/ void OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7aa65e4*/ void OnAfterInputUpdate();

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

                /*0x7aa66a4*/ OnScreenButton();
                /*0x7aa65fc*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7aa6648*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7aa6694*/ string get_controlPathInternal();
                /*0x7aa669c*/ void set_controlPathInternal(string value);
            }

            class OnScreenControl : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ int s_nbActiveInstances;
                static /*0x8*/ UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices;
                /*0x20*/ UnityEngine.InputSystem.InputControl m_Control;
                /*0x28*/ UnityEngine.InputSystem.OnScreen.OnScreenControl m_NextControlOnDevice;
                /*0x30*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_InputEventPtr;

                static /*0x7aa71c0*/ bool get_HasAnyActive();
                /*0x7aa66ac*/ OnScreenControl();
                /*0x7aa66b4*/ string get_controlPath();
                /*0x7aa66c0*/ void set_controlPath(string value);
                /*0x7aa6f70*/ UnityEngine.InputSystem.InputControl get_control();
                /*0x380b9e8*/ string get_controlPathInternal();
                /*0x380d83c*/ void set_controlPathInternal(string value);
                /*0x7aa66f8*/ void SetupInputControl();
                /*0x3907c14*/ void SendValueToControl<TValue>(TValue value);
                /*0x7aa708c*/ void SentDefaultValueToControl();
                /*0x7aa7210*/ void OnEnable();
                /*0x7aa7500*/ void OnDisable();
                /*0x7aa7864*/ string GetWarningMessage();

                struct OnScreenDeviceInfo
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr;
                    /*0x18*/ Unity.Collections.NativeArray<byte> buffer;
                    /*0x28*/ UnityEngine.InputSystem.InputDevice device;
                    /*0x30*/ UnityEngine.InputSystem.OnScreen.OnScreenControl firstControl;

                    /*0x7aa7028*/ UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo AddControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control);
                    /*0x7aa7734*/ UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo RemoveControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control);
                    /*0x7aa6f78*/ void Destroy();
                }
            }

            class UGUIOnScreenControlUtils
            {
                static /*0x7aa78c0*/ UnityEngine.RectTransform GetCanvasRectTransform(UnityEngine.Transform transform);
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

                /*0x7aa948c*/ OnScreenStick();
                /*0x7aa7978*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7aa7c2c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7aa8080*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x7aa8158*/ void Start();
                /*0x7aa87e8*/ void OnDestroy();
                /*0x7aa7a14*/ void BeginInteraction(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera);
                /*0x7aa7cc8*/ void MoveStick(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera);
                /*0x7aa8090*/ void EndInteraction();
                /*0x7aa8884*/ void OnPointerDown(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7aa8e1c*/ void OnPointerChanged(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7aa8f60*/ void OnPointerMove(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7aa8e6c*/ void OnPointerUp(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7aa8ce8*/ UnityEngine.Camera GetCameraFromCanvas();
                /*0x7aa9070*/ void OnDrawGizmosSelected();
                /*0x7aa9258*/ void DrawGizmoCircle(UnityEngine.Vector2 center, float radius);
                /*0x7aa933c*/ void UpdateDynamicOriginClickableArea();
                /*0x7aa9428*/ float get_movementRange();
                /*0x7aa9430*/ void set_movementRange(float value);
                /*0x7aa9438*/ float get_dynamicOriginRange();
                /*0x7aa9440*/ void set_dynamicOriginRange(float value);
                /*0x7aa9458*/ bool get_useIsolatedInputActions();
                /*0x7aa9460*/ void set_useIsolatedInputActions(bool value);
                /*0x7aa946c*/ string get_controlPathInternal();
                /*0x7aa9474*/ void set_controlPathInternal(string value);
                /*0x7aa947c*/ UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour get_behaviour();
                /*0x7aa9484*/ void set_behaviour(UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour value);

                enum Behaviour
                {
                    RelativePositionWithStaticOrigin = 0,
                    ExactPositionWithStaticOrigin = 1,
                    ExactPositionWithDynamicOrigin = 2,
                }
            }

            class OnScreenSupport
            {
                static /*0x7aa94a0*/ void Initialize();
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

                static /*0x7aab7b4*/ HID();
                static /*0x7aa94a4*/ UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorDeviceCommandType();
                static /*0x7aa94d4*/ UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType();
                static /*0x7aa9504*/ UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType();
                static /*0x7aa95e4*/ string OnFindLayoutForDevice(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand);
                static /*0x7aa9fa8*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate);
                static /*0x7aab688*/ string UsagePageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage);
                static /*0x7aab714*/ string UsageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage);
                /*0x7aab7ac*/ HID();
                /*0x7aa9534*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor();

                class HIDLayoutBuilder
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor hidDescriptor;
                    /*0x48*/ string parentLayout;
                    /*0x50*/ System.Type deviceType;

                    /*0x7aaa764*/ HIDLayoutBuilder();
                    /*0x7aab828*/ UnityEngine.InputSystem.Layouts.InputControlLayout Build();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.HID.HID.HIDLayoutBuilder.<> <>9;
                        static /*0x8*/ System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_0;
                        static /*0x10*/ System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_1;
                        static /*0x18*/ System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem, string> <>9__4_2;

                        static /*0x7aad4b8*/ <>c();
                        /*0x7aad520*/ <>c();
                        /*0x7aad528*/ bool <Build>b__4_0(UnityEngine.InputSystem.HID.HID.HIDElementDescriptor element);
                        /*0x7aad54c*/ bool <Build>b__4_1(UnityEngine.InputSystem.HID.HID.HIDElementDescriptor element);
                        /*0x7aad570*/ string <Build>b__4_2(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem x);
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

                    /*0x7aad57c*/ bool get_hasNullState();
                    /*0x7aad588*/ bool get_hasPreferredState();
                    /*0x7aad598*/ bool get_isArray();
                    /*0x7aad5a8*/ bool get_isNonLinear();
                    /*0x7aad5b4*/ bool get_isRelative();
                    /*0x7aad5c0*/ bool get_isConstant();
                    /*0x7aad5cc*/ bool get_isWrapping();
                    /*0x7aac5e4*/ bool get_isSigned();
                    /*0x7aad5d8*/ float get_minFloatValue();
                    /*0x7aad670*/ float get_maxFloatValue();
                    /*0x7aac728*/ bool Is(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage);
                    /*0x7aac844*/ string DetermineName();
                    /*0x7aaca3c*/ string DetermineDisplayName();
                    /*0x7aaa72c*/ bool IsUsableElement();
                    /*0x7aac74c*/ string DetermineLayout();
                    /*0x7aacb2c*/ UnityEngine.InputSystem.Utilities.FourCC DetermineFormat();
                    /*0x7aacc50*/ UnityEngine.InputSystem.Utilities.InternedString[] DetermineUsages();
                    /*0x7aac49c*/ string DetermineParameters();
                    /*0x7aad710*/ string DetermineAxisNormalizationParameters();
                    /*0x7aac6b8*/ string DetermineProcessors();
                    /*0x7aac5f0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue DetermineDefaultState();
                    /*0x7aace38*/ void AddChildControls(ref UnityEngine.InputSystem.HID.HID.HIDElementDescriptor element, string controlName, ref UnityEngine.InputSystem.Layouts.InputControlLayout.Builder builder);
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

                    static /*0x7aaa76c*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor FromJson(string json);
                    /*0x7aab618*/ string ToJson();
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

                    /*0x7aada44*/ HIDDeviceDescriptorBuilder(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage);
                    /*0x7aada5c*/ HIDDeviceDescriptorBuilder(UnityEngine.InputSystem.HID.HID.GenericDesktop usage);
                    /*0x7aada78*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder StartReport(UnityEngine.InputSystem.HID.HID.HIDReportType reportType, int reportId);
                    /*0x7aadaa0*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, int usage, int sizeInBits);
                    /*0x7aade68*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.GenericDesktop usage, int sizeInBits);
                    /*0x7aadeb0*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max);
                    /*0x7aae040*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max);
                    /*0x7aae1b4*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor Finish();
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

                    /*0x7aae290*/ <>c__DisplayClass13_0();
                    /*0x7aae298*/ UnityEngine.InputSystem.Layouts.InputControlLayout <OnFindLayoutForDevice>b__0();
                }
            }

            class HIDParser
            {
                static /*0x7aae2b4*/ bool ParseReportDescriptor(byte[] buffer, ref UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor deviceDescriptor);
                static /*0x7aae320*/ bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor deviceDescriptor);
                static /*0x7aaeec4*/ int ReadData(int itemSize, byte* currentPtr, byte* endPtr);

                struct HIDReportData
                {
                    /*0x10*/ int reportId;
                    /*0x14*/ UnityEngine.InputSystem.HID.HID.HIDReportType reportType;
                    /*0x18*/ int currentBitOffset;

                    static /*0x7aaf2b8*/ int FindOrAddReport(System.Nullable<int> reportId, UnityEngine.InputSystem.HID.HID.HIDReportType reportType, System.Collections.Generic.List<UnityEngine.InputSystem.HID.HIDParser.HIDReportData> reports);
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

                    static /*0x7aaf248*/ void Reset(ref UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal state);
                    /*0x7aaef2c*/ void SetUsage(int value);
                    /*0x7aaf138*/ int GetUsage(int index);
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

                    /*0x7aaf0ac*/ UnityEngine.InputSystem.HID.HID.UsagePage GetUsagePage(int index, ref UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal localItemState);
                    /*0x7aaf440*/ int GetPhysicalMin();
                    /*0x7aaf504*/ int GetPhysicalMax();
                }
            }

            class HIDSupport
            {
                static /*0x0*/ UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage[] s_SupportedHIDUsages;

                static /*0x7aaf5b8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages();
                static /*0x7aaf618*/ void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value);
                static /*0x7aaf85c*/ void Initialize();

                struct HIDPageUsage
                {
                    /*0x10*/ UnityEngine.InputSystem.HID.HID.UsagePage page;
                    /*0x14*/ int usage;

                    /*0x7aaf854*/ HIDPageUsage(UnityEngine.InputSystem.HID.HID.UsagePage page, int usage);
                    /*0x7aaf9bc*/ HIDPageUsage(UnityEngine.InputSystem.HID.HID.GenericDesktop usage);
                }
            }
        }

        namespace EnhancedTouch
        {
            class EnhancedTouchSupport
            {
                static /*0x0*/ int s_Enabled;
                static /*0x4*/ UnityEngine.InputSystem.InputSettings.UpdateMode s_UpdateMode;

                static /*0x7aaf9c8*/ bool get_enabled();
                static /*0x7aafa18*/ void Enable();
                static /*0x7aafd68*/ void Disable();
                static /*0x7ab00ac*/ void Reset();
                static /*0x7aafb88*/ void SetUpState();
                static /*0x7aafeec*/ void TearDownState();
                static /*0x7ab01d8*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
                static /*0x7ab0464*/ void OnSettingsChange();
                static /*0x7ab04fc*/ void CheckEnabled();
            }

            class Finger
            {
                /*0x10*/ UnityEngine.InputSystem.Touchscreen <screen>k__BackingField;
                /*0x18*/ int <index>k__BackingField;
                /*0x20*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory;

                static /*0x7ab0e60*/ bool ShouldRecordTouch(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7ab0ad4*/ Finger(UnityEngine.InputSystem.Touchscreen screen, int index, UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask);
                /*0x7ab0594*/ UnityEngine.InputSystem.Touchscreen get_screen();
                /*0x7ab059c*/ int get_index();
                /*0x7ab05a4*/ bool get_isActive();
                /*0x7ab0770*/ UnityEngine.Vector2 get_screenPosition();
                /*0x7ab0818*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_lastTouch();
                /*0x7ab061c*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_currentTouch();
                /*0x7ab0a34*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_touchHistory();
                /*0x7ab0f48*/ void OnTouchRecorded(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record);
                /*0x7ab11fc*/ UnityEngine.InputSystem.EnhancedTouch.Touch FindTouch(uint uniqueId);
                /*0x7ab1564*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory GetTouchHistory(UnityEngine.InputSystem.EnhancedTouch.Touch touch);
            }

            struct Touch : System.IEquatable<UnityEngine.InputSystem.EnhancedTouch.Touch>
            {
                static /*0x0*/ UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState s_GlobalState;
                /*0x10*/ UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> m_TouchRecord;

                static /*0x7ab36f0*/ Touch();
                static /*0x7ab1f48*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches();
                static /*0x7ab25a8*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers();
                static /*0x7ab2638*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers();
                static /*0x7ab27f0*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens();
                static /*0x7ab287c*/ void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ab2940*/ void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ab2a04*/ void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ab2ac8*/ void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ab2b8c*/ void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ab2c50*/ void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value);
                static /*0x7ab0e08*/ int get_maxHistoryLengthPerFinger();
                static /*0x7ab02f4*/ void AddTouchscreen(UnityEngine.InputSystem.Touchscreen screen);
                static /*0x7ab0380*/ void RemoveTouchscreen(UnityEngine.InputSystem.Touchscreen screen);
                static /*0x7ab3418*/ void BeginUpdate();
                static /*0x7ab348c*/ UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState CreateGlobalState();
                static /*0x7ab34b8*/ UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState();
                /*0x7ab092c*/ Touch(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> touchRecord);
                /*0x7ab0728*/ bool get_valid();
                /*0x7ab1880*/ UnityEngine.InputSystem.EnhancedTouch.Finger get_finger();
                /*0x7ab1824*/ UnityEngine.InputSystem.TouchPhase get_phase();
                /*0x7ab18d0*/ bool get_began();
                /*0x7ab1930*/ bool get_inProgress();
                /*0x7ab19d8*/ bool get_ended();
                /*0x7ab17c8*/ int get_touchId();
                /*0x7ab1a60*/ float get_pressure();
                /*0x7ab1abc*/ UnityEngine.Vector2 get_radius();
                /*0x7ab1b18*/ double get_startTime();
                /*0x7ab1b74*/ double get_time();
                /*0x7ab1bbc*/ UnityEngine.InputSystem.Touchscreen get_screen();
                /*0x7ab08d0*/ UnityEngine.Vector2 get_screenPosition();
                /*0x7ab1c1c*/ UnityEngine.Vector2 get_startScreenPosition();
                /*0x7ab1c78*/ UnityEngine.Vector2 get_delta();
                /*0x7ab1cd4*/ int get_tapCount();
                /*0x7ab1d30*/ bool get_isTap();
                /*0x7ab1d9c*/ int get_displayIndex();
                /*0x7ab0964*/ bool get_isInProgress();
                /*0x7ab09d8*/ uint get_updateStepCount();
                /*0x7ab176c*/ uint get_uniqueId();
                /*0x7ab1888*/ ref UnityEngine.InputSystem.LowLevel.TouchState get_state();
                /*0x7ab1df8*/ ref UnityEngine.InputSystem.EnhancedTouch.Touch.ExtraDataPerTouchState get_extraData();
                /*0x7ab1e40*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_history();
                /*0x7ab2d14*/ string ToString();
                /*0x7ab3028*/ bool Equals(UnityEngine.InputSystem.EnhancedTouch.Touch other);
                /*0x7ab309c*/ bool Equals(object obj);
                /*0x7ab314c*/ int GetHashCode();

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

                    /*0x7ab31c0*/ void AddFingers(UnityEngine.InputSystem.Touchscreen screen);
                    /*0x7ab32d4*/ void RemoveFingers(UnityEngine.InputSystem.Touchscreen screen);
                    /*0x7ab014c*/ void Destroy();
                    /*0x7ab26d8*/ void UpdateActiveFingers();
                    /*0x7ab1fe8*/ void UpdateActiveTouches();
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

                    static /*0x7ab376c*/ <>c();
                    /*0x7ab37d4*/ <>c();
                    /*0x7ab37dc*/ void <SaveAndResetState>b__80_0(ref UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState state);
                    /*0x7ab3870*/ void <SaveAndResetState>b__80_1();
                }
            }

            struct TouchHistory : System.Collections.Generic.IReadOnlyList<UnityEngine.InputSystem.EnhancedTouch.Touch>, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.EnhancedTouch.Touch>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.InputSystem.EnhancedTouch.Touch>
            {
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_History;
                /*0x18*/ UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;
                /*0x20*/ int m_Count;
                /*0x24*/ int m_StartIndex;
                /*0x28*/ uint m_Version;

                /*0x7ab0a54*/ TouchHistory(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex, int count);
                /*0x7ab3874*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator();
                /*0x7ab3938*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7ab393c*/ int get_Count();
                /*0x7ab3944*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_Item(int index);
                /*0x7ab3aa8*/ void CheckValid();

                class Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.EnhancedTouch.TouchHistory m_Owner;
                    /*0x30*/ int m_Index;

                    /*0x7ab38f8*/ Enumerator(UnityEngine.InputSystem.EnhancedTouch.TouchHistory owner);
                    /*0x7ab3b3c*/ bool MoveNext();
                    /*0x7ab3b64*/ void Reset();
                    /*0x7ab3b70*/ UnityEngine.InputSystem.EnhancedTouch.Touch get_Current();
                    /*0x7ab3bb0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7ab3c34*/ void Dispose();
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

                static /*0x7ab3c48*/ UnityEngine.InputSystem.EnhancedTouch.TouchSimulation get_instance();
                static /*0x7ab3c90*/ void Enable();
                static /*0x7ab3e34*/ void Disable();
                static /*0x7ab3f0c*/ void Destroy();
                /*0x7ab55f4*/ TouchSimulation();
                /*0x7ab3c38*/ UnityEngine.InputSystem.Touchscreen get_simulatedTouchscreen();
                /*0x7ab3c40*/ void set_simulatedTouchscreen(UnityEngine.InputSystem.Touchscreen value);
                /*0x7ab3ff4*/ void AddPointer(UnityEngine.InputSystem.Pointer pointer);
                /*0x7ab4164*/ void RemovePointer(UnityEngine.InputSystem.Pointer pointer);
                /*0x7ab45e4*/ void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                /*0x7ab4bb0*/ void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change);
                /*0x7ab4cfc*/ void OnEnable();
                /*0x7ab52a4*/ void OnDisable();
                /*0x7ab4358*/ void UpdateTouch(int touchIndex, int pointerIndex, UnityEngine.InputSystem.TouchPhase phase, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7ab55e0*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                /*0x7ab55e4*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
                /*0x7ab55e8*/ void InstallStateChangeMonitors(int startIndex);
                /*0x7ab55ec*/ void OnSourceControlChangedValue(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long sourceDeviceAndButtonIndex);
                /*0x7ab55f0*/ void UninstallStateChangeMonitors(int startIndex);
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

                static /*0x7ab56d4*/ UnityEngine.InputSystem.DualShock.DualShockGamepad get_current();
                static /*0x7ab571c*/ void set_current(UnityEngine.InputSystem.DualShock.DualShockGamepad value);
                /*0x7ab5a1c*/ DualShockGamepad();
                /*0x7ab55fc*/ UnityEngine.InputSystem.Controls.ButtonControl get_touchpadButton();
                /*0x7ab5604*/ void set_touchpadButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab5614*/ UnityEngine.InputSystem.Controls.ButtonControl get_optionsButton();
                /*0x7ab561c*/ void set_optionsButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab562c*/ UnityEngine.InputSystem.Controls.ButtonControl get_shareButton();
                /*0x7ab5634*/ void set_shareButton(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab5644*/ UnityEngine.InputSystem.Controls.ButtonControl get_L1();
                /*0x7ab564c*/ void set_L1(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab565c*/ UnityEngine.InputSystem.Controls.ButtonControl get_R1();
                /*0x7ab5664*/ void set_R1(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab5674*/ UnityEngine.InputSystem.Controls.ButtonControl get_L2();
                /*0x7ab567c*/ void set_L2(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab568c*/ UnityEngine.InputSystem.Controls.ButtonControl get_R2();
                /*0x7ab5694*/ void set_R2(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab56a4*/ UnityEngine.InputSystem.Controls.ButtonControl get_L3();
                /*0x7ab56ac*/ void set_L3(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab56bc*/ UnityEngine.InputSystem.Controls.ButtonControl get_R3();
                /*0x7ab56c4*/ void set_R3(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7ab5774*/ UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor();
                /*0x7ab5788*/ void set_hidDescriptor(UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor value);
                /*0x7ab57a8*/ void MakeCurrent();
                /*0x7ab5808*/ void OnRemoved();
                /*0x7ab58a4*/ void FinishSetup();
                /*0x7ab5a18*/ void SetLightBarColor(UnityEngine.Color color);
            }

            class DualShockSupport
            {
                static /*0x7ab5a24*/ void Initialize();
            }

            interface IDualShockHaptics : UnityEngine.InputSystem.Haptics.IDualMotorRumble, UnityEngine.InputSystem.Haptics.IHaptics
            {
                /*0x380ce74*/ void SetLightBarColor(UnityEngine.Color color);
            }
        }

        namespace Android
        {
            class AndroidGamepad : UnityEngine.InputSystem.Gamepad
            {
                /*0x7ab5a94*/ AndroidGamepad();
            }

            class AndroidGamepadWithDpadAxes : UnityEngine.InputSystem.Android.AndroidGamepad
            {
                /*0x7ab5a9c*/ AndroidGamepadWithDpadAxes();
            }

            class AndroidGamepadWithDpadButtons : UnityEngine.InputSystem.Android.AndroidGamepad
            {
                /*0x7ab5aa4*/ AndroidGamepadWithDpadButtons();
            }

            class AndroidJoystick : UnityEngine.InputSystem.Joystick
            {
                /*0x7ab5aac*/ AndroidJoystick();
            }

            class DualShock4GamepadAndroid : UnityEngine.InputSystem.DualShock.DualShockGamepad
            {
                /*0x7ab5ab4*/ DualShock4GamepadAndroid();
            }

            class XboxOneGamepadAndroid : UnityEngine.InputSystem.XInput.XInputController
            {
                /*0x7ab5abc*/ XboxOneGamepadAndroid();
            }

            class AndroidAccelerometer : UnityEngine.InputSystem.Accelerometer
            {
                /*0x7ab5ac4*/ AndroidAccelerometer();
            }

            class AndroidMagneticFieldSensor : UnityEngine.InputSystem.MagneticFieldSensor
            {
                /*0x7ab5acc*/ AndroidMagneticFieldSensor();
            }

            class AndroidGyroscope : UnityEngine.InputSystem.Gyroscope
            {
                /*0x7ab5ad4*/ AndroidGyroscope();
            }

            class AndroidLightSensor : UnityEngine.InputSystem.LightSensor
            {
                /*0x7ab5adc*/ AndroidLightSensor();
            }

            class AndroidPressureSensor : UnityEngine.InputSystem.PressureSensor
            {
                /*0x7ab5ae4*/ AndroidPressureSensor();
            }

            class AndroidProximity : UnityEngine.InputSystem.ProximitySensor
            {
                /*0x7ab5aec*/ AndroidProximity();
            }

            class AndroidGravitySensor : UnityEngine.InputSystem.GravitySensor
            {
                /*0x7ab5af4*/ AndroidGravitySensor();
            }

            class AndroidLinearAccelerationSensor : UnityEngine.InputSystem.LinearAccelerationSensor
            {
                /*0x7ab5afc*/ AndroidLinearAccelerationSensor();
            }

            class AndroidRotationVector : UnityEngine.InputSystem.AttitudeSensor
            {
                /*0x7ab5b04*/ AndroidRotationVector();
            }

            class AndroidRelativeHumidity : UnityEngine.InputSystem.HumiditySensor
            {
                /*0x7ab5b0c*/ AndroidRelativeHumidity();
            }

            class AndroidAmbientTemperature : UnityEngine.InputSystem.AmbientTemperatureSensor
            {
                /*0x7ab5b14*/ AndroidAmbientTemperature();
            }

            class AndroidGameRotationVector : UnityEngine.InputSystem.AttitudeSensor
            {
                /*0x7ab5b1c*/ AndroidGameRotationVector();
            }

            class AndroidStepCounter : UnityEngine.InputSystem.StepCounter
            {
                /*0x7ab5b24*/ AndroidStepCounter();
            }

            class AndroidHingeAngle : UnityEngine.InputSystem.HingeAngle
            {
                /*0x7ab5b2c*/ AndroidHingeAngle();
            }

            class AndroidSupport
            {
                static string kAndroidInterface = "Android";

                static /*0x7ab5b34*/ void Initialize();
                static /*0x7ab6544*/ string OnFindLayoutForDevice(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate);
                /*0x7ab684c*/ AndroidSupport();
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

                    static /*0x7ab690c*/ AndroidGameControllerState();
                    /*0x7ab6854*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                    /*0x7ab68ac*/ UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState WithButton(UnityEngine.InputSystem.Android.LowLevel.AndroidKeyCode code, bool value);
                    /*0x7ab68f0*/ UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState WithAxis(UnityEngine.InputSystem.Android.LowLevel.AndroidAxis axis, float value);

                    class Variants
                    {
                        static string Gamepad = "Gamepad";
                        static string Joystick = "Joystick";
                        static string DPadAxes = "DpadAxes";
                        static string DPadButtons = "DpadButtons";

                        /*0x7ab6978*/ Variants();
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

                    static /*0x7ab6790*/ UnityEngine.InputSystem.Android.LowLevel.AndroidDeviceCapabilities FromJson(string json);
                    /*0x7ab6980*/ string ToJson();
                    /*0x7ab69ec*/ string ToString();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Android.LowLevel.AndroidDeviceCapabilities.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.InputSystem.Android.LowLevel.AndroidAxis, string> <>9__8_0;

                        static /*0x7ab6d94*/ <>c();
                        /*0x7ab6dfc*/ <>c();
                        /*0x7ab6e04*/ string <ToString>b__8_0(UnityEngine.InputSystem.Android.LowLevel.AndroidAxis i);
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

                    static /*0x7ab6ecc*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorCapabilities FromJson(string json);
                    /*0x7ab6e68*/ string ToJson();
                    /*0x7ab6f68*/ string ToString();
                }

                struct AndroidSensorState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
                {
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.FourCC kFormat;
                    /*0x10*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorState.<data> data;

                    static /*0x7ab7174*/ AndroidSensorState();
                    /*0x7ab7000*/ UnityEngine.InputSystem.Android.LowLevel.AndroidSensorState WithData(float[] data);
                    /*0x7ab711c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

                    struct <data>e__FixedBuffer
                    {
                        /*0x10*/ float FixedElementField;
                    }
                }

                class AndroidCompensateDirectionProcessor : UnityEngine.InputSystem.Processors.CompensateDirectionProcessor
                {
                    static float kSensorStandardGravity = 9.806650161743164;
                    static float kAccelerationMultiplier = -0.10197161883115768;

                    /*0x7ab71fc*/ AndroidCompensateDirectionProcessor();
                    /*0x7ab71e0*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 vector, UnityEngine.InputSystem.InputControl control);
                }

                class AndroidCompensateRotationProcessor : UnityEngine.InputSystem.Processors.CompensateRotationProcessor
                {
                    /*0x7ab7238*/ AndroidCompensateRotationProcessor();
                    /*0x7ab7204*/ UnityEngine.Quaternion Process(UnityEngine.Quaternion value, UnityEngine.InputSystem.InputControl control);
                }
            }
        }

        namespace Haptics
        {
            struct DualMotorRumble
            {
                /*0x10*/ float <lowFrequencyMotorSpeed>k__BackingField;
                /*0x14*/ float <highFrequencyMotorSpeed>k__BackingField;

                /*0x7ab7240*/ float get_lowFrequencyMotorSpeed();
                /*0x7ab7248*/ void set_lowFrequencyMotorSpeed(float value);
                /*0x7ab7250*/ float get_highFrequencyMotorSpeed();
                /*0x7ab7258*/ void set_highFrequencyMotorSpeed(float value);
                /*0x7ab7260*/ bool get_isRumbling();
                /*0x7ab7318*/ void PauseHaptics(UnityEngine.InputSystem.InputDevice device);
                /*0x7ab7474*/ void ResumeHaptics(UnityEngine.InputSystem.InputDevice device);
                /*0x7ab763c*/ void ResetHaptics(UnityEngine.InputSystem.InputDevice device);
                /*0x7ab74fc*/ void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency);
            }

            interface IDualMotorRumble : UnityEngine.InputSystem.Haptics.IHaptics
            {
                void SetMotorSpeeds(float lowFrequency, float highFrequency);
            }

            interface IHaptics
            {
                /*0x380cb08*/ void PauseHaptics();
                /*0x380cb08*/ void ResumeHaptics();
                /*0x380cb08*/ void ResetHaptics();
            }
        }

        namespace LowLevel
        {
            struct DisableDeviceCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7ab76c8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7728*/ UnityEngine.InputSystem.LowLevel.DisableDeviceCommand Create();
                /*0x7ab76f8*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct EnableDeviceCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7ab7764*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab77c4*/ UnityEngine.InputSystem.LowLevel.EnableDeviceCommand Create();
                /*0x7ab7794*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct EnableIMECompositionCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 12;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ byte m_ImeEnabled;

                static /*0x7ab77f8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7868*/ UnityEngine.InputSystem.LowLevel.EnableIMECompositionCommand Create(bool enabled);
                /*0x7ab7828*/ bool get_imeEnabled();
                /*0x7ab7838*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            interface IInputDeviceCommandInfo
            {
                UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct InitiateUserAccountPairingCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7ab78b8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7918*/ UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand Create();
                /*0x7ab78e8*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                enum Result
                {
                    SuccessfullyInitiated = 1,
                    ErrorNotSupported = -1,
                    ErrorAlreadyInProgress = -2,
                }
            }

            class InputDeviceCommandDelegate : System.MulticastDelegate
            {
                /*0x7ab794c*/ InputDeviceCommandDelegate(object object, nint method);
                /*0x7ab7a58*/ System.Nullable<long> Invoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command);
                /*0x7ab7a6c*/ System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command, System.AsyncCallback callback, object object);
                /*0x7ab7a94*/ System.Nullable<long> EndInvoke(System.IAsyncResult result);
            }

            class InputDeviceExecuteCommandDelegate : System.MulticastDelegate
            {
                /*0x7ab7ac0*/ InputDeviceExecuteCommandDelegate(object object, nint method);
                /*0x7ab7b70*/ long Invoke(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand command);
                /*0x7ab7b84*/ System.IAsyncResult BeginInvoke(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand command, System.AsyncCallback callback, object object);
                /*0x7ab7c10*/ long EndInvoke(ref UnityEngine.InputSystem.LowLevel.InputDeviceCommand command, System.IAsyncResult result);
            }

            struct InputDeviceCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kBaseCommandSize = 8;
                static int BaseCommandSize = 8;
                static long GenericFailure = -1;
                static long GenericSuccess = 1;
                /*0x10*/ UnityEngine.InputSystem.Utilities.FourCC type;
                /*0x14*/ int sizeInBytes;

                static /*0x7ab7c50*/ Unity.Collections.NativeArray<byte> AllocateNative(UnityEngine.InputSystem.Utilities.FourCC type, int payloadSize);
                /*0x7ab775c*/ InputDeviceCommand(UnityEngine.InputSystem.Utilities.FourCC type, int sizeInBytes);
                /*0x7ab7c3c*/ int get_payloadSizeInBytes();
                /*0x7ab7c48*/ void* get_payloadPtr();
                /*0x7ab7d00*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryCanRunInBackground : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 9;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ bool canRunInBackground;

                static /*0x7ab7d08*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7d68*/ UnityEngine.InputSystem.LowLevel.QueryCanRunInBackground Create();
                /*0x7ab7d38*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryDimensionsCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.Vector2 outDimensions;

                static /*0x7ab7da4*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7e04*/ UnityEngine.InputSystem.LowLevel.QueryDimensionsCommand Create();
                /*0x7ab7dd4*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryEnabledStateCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 9;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ bool isEnabled;

                static /*0x7ab7e3c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7e9c*/ UnityEngine.InputSystem.LowLevel.QueryEnabledStateCommand Create();
                /*0x7ab7e6c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryKeyboardLayoutCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kMaxNameLength = 256;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand.<nameBuffer> nameBuffer;

                static /*0x7ab7ed8*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7f6c*/ UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand Create();
                /*0x7ab7f08*/ string ReadLayoutName();
                /*0x7ab7f18*/ void WriteLayoutName(string name);
                /*0x7ab7f3c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

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

                static /*0x7ab7fc4*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab8034*/ UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key);
                /*0x7ab7ff4*/ string ReadKeyName();
                /*0x7ab8004*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

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

                static /*0x7ab8094*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab8334*/ UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand Create();
                /*0x7ab80c4*/ string get_id();
                /*0x7ab80d4*/ void set_id(string value);
                /*0x7ab81e4*/ string get_name();
                /*0x7ab81f4*/ void set_name(string value);
                /*0x7ab8304*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

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

                static /*0x7ab838c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab83ec*/ UnityEngine.InputSystem.LowLevel.QuerySamplingFrequencyCommand Create();
                /*0x7ab83bc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct QueryUserIdCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kMaxIdLength = 256;
                static int kSize = 520;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.InputSystem.LowLevel.QueryUserIdCommand.<idBuffer> idBuffer;

                static /*0x7ab8424*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab8494*/ UnityEngine.InputSystem.LowLevel.QueryUserIdCommand Create();
                /*0x7ab8454*/ string ReadId();
                /*0x7ab8464*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

                struct <idBuffer>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct RequestResetCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7ab84ec*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab854c*/ UnityEngine.InputSystem.LowLevel.RequestResetCommand Create();
                /*0x7ab851c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct RequestSyncCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 8;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;

                static /*0x7ab8580*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab85e0*/ UnityEngine.InputSystem.LowLevel.RequestSyncCommand Create();
                /*0x7ab85b0*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct SetIMECursorPositionCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.Vector2 m_Position;

                static /*0x7ab8614*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab867c*/ UnityEngine.InputSystem.LowLevel.SetIMECursorPositionCommand Create(UnityEngine.Vector2 cursorPosition);
                /*0x7ab8644*/ UnityEngine.Vector2 get_position();
                /*0x7ab864c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct SetSamplingFrequencyCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 12;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ float frequency;

                static /*0x7ab86cc*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab872c*/ UnityEngine.InputSystem.LowLevel.SetSamplingFrequencyCommand Create(float frequency);
                /*0x7ab86fc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct WarpMousePositionCommand : UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
            {
                static int kSize = 16;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
                /*0x18*/ UnityEngine.Vector2 warpPositionInPlayerDisplaySpace;

                static /*0x7ab8778*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab87d8*/ UnityEngine.InputSystem.LowLevel.WarpMousePositionCommand Create(UnityEngine.Vector2 position);
                /*0x7ab87a8*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
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

                static /*0x7ab8828*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ab8888*/ GamepadState(UnityEngine.InputSystem.LowLevel.GamepadButton[] buttons);
                /*0x7ab8858*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                /*0x7ab8938*/ UnityEngine.InputSystem.LowLevel.GamepadState WithButton(UnityEngine.InputSystem.LowLevel.GamepadButton button, bool value);
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

                static /*0x7ab896c*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab7424*/ UnityEngine.InputSystem.LowLevel.DualMotorRumbleCommand Create(float lowFrequency, float highFrequency);
                /*0x7ab899c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            interface ICustomDeviceReset
            {
                /*0x380cb08*/ void Reset();
            }

            interface IEventMerger
            {
                bool MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr);
            }

            interface IEventPreProcessor
            {
                /*0x380b1e4*/ bool PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr);
            }

            interface IInputUpdateCallbackReceiver
            {
                /*0x380cb08*/ void OnUpdate();
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

                static /*0x7ab89cc*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab89fc*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

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

                static /*0x7ab8a2c*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ab8a5c*/ KeyboardState(UnityEngine.InputSystem.Key[] pressedKeys);
                /*0x7ab8b20*/ void Set(UnityEngine.InputSystem.Key key, bool state);
                /*0x7ab8b2c*/ void Press(UnityEngine.InputSystem.Key key);
                /*0x7ab8b38*/ void Release(UnityEngine.InputSystem.Key key);
                /*0x7ab8b44*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

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

                static /*0x7ab8b74*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ab8ba4*/ UnityEngine.InputSystem.LowLevel.MouseState WithButton(UnityEngine.InputSystem.LowLevel.MouseButton button, bool state);
                /*0x7ab8bd8*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
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

                static /*0x7ab8c08*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ab8c38*/ UnityEngine.InputSystem.LowLevel.PenState WithButton(UnityEngine.InputSystem.PenButton button, bool state);
                /*0x7ab8c6c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
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

                static /*0x7ab8c9c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab8ccc*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct AccelerometerState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 acceleration;

                static /*0x7ab8cfc*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab8d2c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct GyroscopeState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 angularVelocity;

                static /*0x7ab8d5c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab8d8c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct GravityState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 gravity;

                static /*0x7ab8dbc*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab8dec*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct AttitudeState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Quaternion attitude;

                static /*0x7ab8e1c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab8e4c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
            }

            struct LinearAccelerationState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                /*0x10*/ UnityEngine.Vector3 acceleration;

                static /*0x7ab8e7c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFormat();
                /*0x7ab8eac*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
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

                static /*0x7ab8edc*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ab8f0c*/ UnityEngine.InputSystem.TouchPhase get_phase();
                /*0x7ab3764*/ void set_phase(UnityEngine.InputSystem.TouchPhase value);
                /*0x7ab8f14*/ bool get_isNoneEndedOrCanceled();
                /*0x7ab8f38*/ bool get_isInProgress();
                /*0x7ab8f60*/ bool get_isPrimaryTouch();
                /*0x7ab8f6c*/ void set_isPrimaryTouch(bool value);
                /*0x7ab8f8c*/ bool get_isOrphanedPrimaryTouch();
                /*0x7ab8f98*/ void set_isOrphanedPrimaryTouch(bool value);
                /*0x7ab8fb8*/ bool get_isIndirectTouch();
                /*0x7ab8fc4*/ void set_isIndirectTouch(bool value);
                /*0x7ab1d90*/ bool get_isTap();
                /*0x7ab8fe0*/ void set_isTap(bool value);
                /*0x7ab8fd4*/ bool get_isTapPress();
                /*0x7ab9000*/ void set_isTapPress(bool value);
                /*0x7ab0f3c*/ bool get_isTapRelease();
                /*0x7ab9020*/ void set_isTapRelease(bool value);
                /*0x7ab11d4*/ bool get_beganInSameFrame();
                /*0x7ab11e0*/ void set_beganInSameFrame(bool value);
                /*0x7ab9040*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                /*0x7ab9070*/ string ToString();
            }

            struct TouchscreenState : UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
            {
                static int MaxTouches = 10;
                static int kTouchDataOffset = 56;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.TouchscreenState.<primaryTouchData> primaryTouchData;
                /*0x48*/ UnityEngine.InputSystem.LowLevel.TouchscreenState.<touchData> touchData;

                static /*0x7ab9350*/ UnityEngine.InputSystem.Utilities.FourCC get_Format();
                /*0x7ab9380*/ UnityEngine.InputSystem.LowLevel.TouchState* get_primaryTouch();
                /*0x7ab9384*/ UnityEngine.InputSystem.LowLevel.TouchState* get_touches();
                /*0x7ab938c*/ UnityEngine.InputSystem.Utilities.FourCC get_format();

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

                static /*0x7ab93bc*/ UnityEngine.InputSystem.Utilities.FourCC get_Type();
                static /*0x7ab9618*/ int GetEventSizeWithValueSize(int valueSizeInBytes);
                static /*0x7ab9620*/ UnityEngine.InputSystem.LowLevel.ActionEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                /*0x7ab93ec*/ double get_startTime();
                /*0x7ab93f4*/ void set_startTime(double value);
                /*0x7ab93fc*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                /*0x7ab9404*/ void set_phase(UnityEngine.InputSystem.InputActionPhase value);
                /*0x7ab940c*/ byte* get_valueData();
                /*0x7ab9414*/ int get_valueSizeInBytes();
                /*0x7ab9428*/ int get_stateIndex();
                /*0x7ab9430*/ void set_stateIndex(int value);
                /*0x7ab9490*/ int get_controlIndex();
                /*0x7ab9498*/ void set_controlIndex(int value);
                /*0x7ab94f8*/ int get_bindingIndex();
                /*0x7ab9500*/ void set_bindingIndex(int value);
                /*0x7ab9560*/ int get_interactionIndex();
                /*0x7ab9574*/ void set_interactionIndex(int value);
                /*0x7ab95e4*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
                /*0x7ab95e8*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();

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

                static /*0x7ab9768*/ UnityEngine.InputSystem.LowLevel.DeltaStateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ab988c*/ UnityEngine.InputSystem.LowLevel.DeltaStateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ab9890*/ Unity.Collections.NativeArray<byte> From(UnityEngine.InputSystem.InputControl control, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator);
                /*0x7ab9744*/ uint get_deltaStateSizeInBytes();
                /*0x7ab9750*/ void* get_deltaState();
                /*0x7ab9758*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x7ab9764*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();

                struct <stateData>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }

            struct DeviceConfigurationEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1145259591;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;

                static /*0x7ab9d0c*/ UnityEngine.InputSystem.LowLevel.DeviceConfigurationEvent Create(int deviceId, double time);
                /*0x7ab9cfc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x7ab9d08*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
            }

            struct DeviceRemoveEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1146242381;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;

                static /*0x7ab9d8c*/ UnityEngine.InputSystem.LowLevel.DeviceRemoveEvent Create(int deviceId, double time);
                /*0x7ab9d7c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x7ab9d88*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
            }

            struct DeviceResetEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1146245972;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x18*/ bool hardReset;

                static /*0x7ab9e08*/ UnityEngine.InputSystem.LowLevel.DeviceResetEvent Create(int deviceId, bool hardReset, double time);
                /*0x7ab9dfc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
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

                static /*0x7ab9ea8*/ UnityEngine.InputSystem.LowLevel.IMECompositionEvent Create(int deviceId, string compositionString, double time);
                /*0x7ab9e9c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            struct IMECompositionString : System.Collections.Generic.IEnumerable<char>, System.Collections.IEnumerable
            {
                /*0x10*/ int size;
                /*0x14*/ UnityEngine.InputSystem.LowLevel.IMECompositionString.<buffer> buffer;

                /*0x7ab9f90*/ IMECompositionString(string characters);
                /*0x7aba010*/ int get_Count();
                /*0x7aba018*/ char get_Item(int index);
                /*0x7aba084*/ string ToString();
                /*0x7aba09c*/ System.Collections.Generic.IEnumerator<char> GetEnumerator();
                /*0x7aba154*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator : System.Collections.Generic.IEnumerator<char>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.IMECompositionString m_CompositionString;
                    /*0x94*/ char m_CurrentCharacter;
                    /*0x98*/ int m_CurrentIndex;

                    /*0x7aba130*/ Enumerator(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString);
                    /*0x7aba158*/ bool MoveNext();
                    /*0x7aba188*/ void Reset();
                    /*0x7aba194*/ void Dispose();
                    /*0x7aba198*/ char get_Current();
                    /*0x7aba1a0*/ object System.Collections.IEnumerator.get_Current();
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

                static /*0x7aba604*/ UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemory(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr);
                static /*0x7aba620*/ UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemoryChecked(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer);
                static /*0x7aba78c*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputEvent* first, UnityEngine.InputSystem.LowLevel.InputEvent* second);
                /*0x7ab9bf8*/ InputEvent(UnityEngine.InputSystem.Utilities.FourCC type, int sizeInBytes, int deviceId, double time);
                /*0x7aba1c8*/ UnityEngine.InputSystem.Utilities.FourCC get_type();
                /*0x7aba1d0*/ void set_type(UnityEngine.InputSystem.Utilities.FourCC value);
                /*0x7ab9420*/ uint get_sizeInBytes();
                /*0x7aba1d8*/ void set_sizeInBytes(uint value);
                /*0x7aba27c*/ int get_eventId();
                /*0x7aba288*/ void set_eventId(int value);
                /*0x7aba29c*/ int get_deviceId();
                /*0x7aba2a4*/ void set_deviceId(int value);
                /*0x7aba2ac*/ double get_time();
                /*0x7aba300*/ void set_time(double value);
                /*0x7aba360*/ double get_internalTime();
                /*0x7aba368*/ void set_internalTime(double value);
                /*0x7aba370*/ bool get_handled();
                /*0x7aba37c*/ void set_handled(bool value);
                /*0x7aba398*/ string ToString();
            }

            struct InputEventBuffer : System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerable, System.IDisposable, System.ICloneable
            {
                static long BufferSizeUnknown = -1;
                /*0x10*/ Unity.Collections.NativeArray<byte> m_Buffer;
                /*0x20*/ long m_SizeInBytes;
                /*0x28*/ int m_EventCount;
                /*0x2c*/ bool m_WeOwnTheBuffer;

                /*0x7aba894*/ InputEventBuffer(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, int eventCount, int sizeInBytes, int capacityInBytes);
                /*0x7abaa44*/ InputEventBuffer(Unity.Collections.NativeArray<byte> buffer, int eventCount, int sizeInBytes, bool transferNativeArrayOwnership);
                /*0x7aba7e0*/ int get_eventCount();
                /*0x7aba7e8*/ long get_sizeInBytes();
                /*0x7aba7f0*/ long get_capacityInBytes();
                /*0x7aba83c*/ Unity.Collections.NativeArray<byte> get_data();
                /*0x7aba848*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_bufferPtr();
                /*0x7abab64*/ void AppendEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, int capacityIncrementInBytes, Unity.Collections.Allocator allocator);
                /*0x7ababe0*/ UnityEngine.InputSystem.LowLevel.InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes, Unity.Collections.Allocator allocator);
                /*0x7aba704*/ bool Contains(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                /*0x7abaeb4*/ void Reset();
                /*0x7abaecc*/ void AdvanceToNextEvent(ref UnityEngine.InputSystem.LowLevel.InputEvent* currentReadPos, ref UnityEngine.InputSystem.LowLevel.InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer);
                /*0x7abaf84*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator();
                /*0x7abb030*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7abb034*/ void Dispose();
                /*0x7abb094*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer Clone();
                /*0x7abb16c*/ object System.ICloneable.Clone();

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_Buffer;
                    /*0x18*/ int m_EventCount;
                    /*0x20*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentEvent;
                    /*0x28*/ int m_CurrentIndex;

                    /*0x7abaff8*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer);
                    /*0x7abb1d8*/ bool MoveNext();
                    /*0x7abb240*/ void Reset();
                    /*0x7abb24c*/ void Dispose();
                    /*0x7abb250*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current();
                    /*0x7abb258*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            struct InputEventListener : System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr>
            {
                static /*0x0*/ UnityEngine.InputSystem.LowLevel.InputEventListener.ObserverState s_ObserverState;

                static /*0x7ab5128*/ UnityEngine.InputSystem.LowLevel.InputEventListener op_Addition(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> callback);
                static /*0x7ab5404*/ UnityEngine.InputSystem.LowLevel.InputEventListener op_Subtraction(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> callback);
                /*0x7abb2b4*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer);

                class ObserverState
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers;
                    /*0x28*/ System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice> onEventDelegate;

                    /*0x7abb428*/ ObserverState();
                    /*0x7abb4c0*/ void <.ctor>b__2_0(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device);
                }

                class DisposableObserver : System.IDisposable
                {
                    /*0x10*/ System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer;

                    /*0x7abb4b8*/ DisposableObserver();
                    /*0x7abb5b4*/ void Dispose();
                }
            }

            struct InputEventPtr : System.IEquatable<UnityEngine.InputSystem.LowLevel.InputEventPtr>
            {
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent* m_EventPtr;

                static /*0x7abbe94*/ bool op_Equality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right);
                static /*0x7abbea0*/ bool op_Inequality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right);
                static /*0x7aba890*/ UnityEngine.InputSystem.LowLevel.InputEventPtr op_Implicit(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                static /*0x7abbeac*/ UnityEngine.InputSystem.LowLevel.InputEventPtr From(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                static /*0x7abb1d4*/ UnityEngine.InputSystem.LowLevel.InputEvent* op_Implicit(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x7abbeb0*/ UnityEngine.InputSystem.LowLevel.InputEvent* FromInputEventPtr(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7abb6ec*/ InputEventPtr(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                /*0x7ab0f14*/ bool get_valid();
                /*0x7abb6f4*/ bool get_handled();
                /*0x7ab4b3c*/ void set_handled(bool value);
                /*0x7abb710*/ int get_id();
                /*0x7abb72c*/ void set_id(int value);
                /*0x7ab0f24*/ UnityEngine.InputSystem.Utilities.FourCC get_type();
                /*0x7abb798*/ uint get_sizeInBytes();
                /*0x7abb7b0*/ int get_deviceId();
                /*0x7abb7c8*/ void set_deviceId(int value);
                /*0x7ab5580*/ double get_time();
                /*0x7abb828*/ void set_time(double value);
                /*0x7abb8d4*/ double get_internalTime();
                /*0x7abb8ec*/ void set_internalTime(double value);
                /*0x7abb94c*/ UnityEngine.InputSystem.LowLevel.InputEvent* get_data();
                /*0x7abb954*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                /*0x7abba9c*/ uint get_stateSizeInBytes();
                /*0x7abbce0*/ uint get_stateOffset();
                /*0x380b128*/ bool IsA<TOtherEvent>();
                /*0x7abbdb8*/ UnityEngine.InputSystem.LowLevel.InputEventPtr Next();
                /*0x7abba04*/ string ToString();
                /*0x7abbde4*/ UnityEngine.InputSystem.LowLevel.InputEvent* ToPointer();
                /*0x7abbdec*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputEventPtr other);
                /*0x7abbe04*/ bool Equals(object obj);
                /*0x7abbe8c*/ int GetHashCode();
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

                /*0x7abbf5c*/ InputEventStream(ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, int maxAppendedEvents);
                /*0x7abbeb4*/ bool get_isOpen();
                /*0x7abbebc*/ int get_remainingEventCount();
                /*0x7abbecc*/ int get_numEventsRetainedInBuffer();
                /*0x7abbed4*/ UnityEngine.InputSystem.LowLevel.InputEvent* get_currentEventPtr();
                /*0x7abbf08*/ uint get_numBytesRetainedInBuffer();
                /*0x7abbfe8*/ void Close(ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer);
                /*0x7abc104*/ void CleanUpAfterException();
                /*0x7abc16c*/ void Write(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr);
                /*0x7abc2f0*/ UnityEngine.InputSystem.LowLevel.InputEvent* Advance(bool leaveEventInBuffer);
                /*0x7abc394*/ UnityEngine.InputSystem.LowLevel.InputEvent* Peek();
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

                static /*0x7abea48*/ InputEventTrace();
                static /*0x7abc3f4*/ UnityEngine.InputSystem.Utilities.FourCC get_FrameMarkerEvent();
                static /*0x7abd9e8*/ UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(string filePath);
                static /*0x7abdbe8*/ UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(System.IO.Stream stream);
                static /*0x7abd04c*/ UnityEngine.InputSystem.Utilities.FourCC get_kFileFormat();
                /*0x7abc66c*/ InputEventTrace(UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes, bool growBuffer, long maxBufferSizeInBytes, long growIncrementSizeInBytes);
                /*0x7abc740*/ InputEventTrace(long bufferSizeInBytes, bool growBuffer, long maxBufferSizeInBytes, long growIncrementSizeInBytes);
                /*0x7abc424*/ int get_deviceId();
                /*0x7abc42c*/ void set_deviceId(int value);
                /*0x7abc434*/ bool get_enabled();
                /*0x7abc43c*/ bool get_recordFrameMarkers();
                /*0x7abc444*/ void set_recordFrameMarkers(bool value);
                /*0x7abc52c*/ long get_eventCount();
                /*0x7abc534*/ long get_totalEventSizeInBytes();
                /*0x7abc53c*/ long get_allocatedSizeInBytes();
                /*0x7abc55c*/ long get_maxSizeInBytes();
                /*0x7abc564*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos();
                /*0x7abc5ac*/ System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> get_onFilterEvent();
                /*0x7abc5b4*/ void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice, bool> value);
                /*0x7abc5bc*/ void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                /*0x7abc614*/ void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                /*0x7abc7b0*/ void WriteTo(string filePath);
                /*0x7abc97c*/ void WriteTo(System.IO.Stream stream);
                /*0x7abd0d4*/ void ReadFrom(string filePath);
                /*0x7abd2a0*/ void ReadFrom(System.IO.Stream stream);
                /*0x7abdd00*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Replay();
                /*0x7abdef0*/ bool Resize(long newBufferSize, long newMaxBufferSize);
                /*0x7abe168*/ void Clear();
                /*0x7abe188*/ void Enable();
                /*0x7abdd60*/ void Disable();
                /*0x7abe0f0*/ bool GetNextEvent(ref UnityEngine.InputSystem.LowLevel.InputEventPtr current);
                /*0x7abd07c*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator();
                /*0x7abe344*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7abe348*/ void Dispose();
                /*0x7abc554*/ byte* get_m_EventBuffer();
                /*0x7abd9d0*/ void set_m_EventBuffer(byte* value);
                /*0x7abe0e8*/ byte* get_m_EventBufferHead();
                /*0x7abd9d8*/ void set_m_EventBufferHead(byte* value);
                /*0x7abe2f8*/ byte* get_m_EventBufferTail();
                /*0x7abd9e0*/ void set_m_EventBufferTail(byte* value);
                /*0x7abe2d0*/ void Allocate();
                /*0x7abe360*/ void Release();
                /*0x7abe3b8*/ void OnBeforeUpdate();
                /*0x7abe530*/ void OnInputEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device);

                class Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEventTrace m_Trace;
                    /*0x18*/ int m_ChangeCounter;
                    /*0x20*/ UnityEngine.InputSystem.LowLevel.InputEventPtr m_Current;

                    /*0x7abe300*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputEventTrace trace);
                    /*0x7abeac4*/ void Dispose();
                    /*0x7abeae8*/ bool MoveNext();
                    /*0x7abebac*/ void Reset();
                    /*0x7abebd0*/ UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current();
                    /*0x7abebd8*/ object System.Collections.IEnumerator.get_Current();
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

                    /*0x7abde74*/ ReplayController(UnityEngine.InputSystem.LowLevel.InputEventTrace trace);
                    /*0x7abec34*/ UnityEngine.InputSystem.LowLevel.InputEventTrace get_trace();
                    /*0x7abec3c*/ bool get_finished();
                    /*0x7abec44*/ void set_finished(bool value);
                    /*0x7abec50*/ bool get_paused();
                    /*0x7abec58*/ void set_paused(bool value);
                    /*0x7abec64*/ int get_position();
                    /*0x7abec6c*/ void set_position(int value);
                    /*0x7abec74*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices();
                    /*0x7abecd8*/ void Dispose();
                    /*0x7abefec*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice);
                    /*0x7abf070*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId);
                    /*0x7abf1ec*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithAllDevicesMappedToNewInstances();
                    /*0x7abf1f8*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnFinished(System.Action action);
                    /*0x7abf214*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action);
                    /*0x7abf230*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayOneEvent();
                    /*0x7abf81c*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Rewind();
                    /*0x7abf858*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllFramesOneByOne();
                    /*0x7abf908*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEvents();
                    /*0x7abf9c0*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEventsAccordingToTimestamps();
                    /*0x7abfc78*/ void OnBeginFrame();
                    /*0x7abfeb0*/ void Finished();
                    /*0x7abf5f0*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                    /*0x7abf2b4*/ bool MoveNext(bool skipFrameEvents, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                    /*0x7abff84*/ int ApplyDeviceMapping(int originalDeviceId);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController.<> <>9;
                        static /*0x8*/ System.Comparison<UnityEngine.InputSystem.LowLevel.InputEventPtr> <>9__38_0;

                        static /*0x7ac0324*/ <>c();
                        /*0x7ac038c*/ <>c();
                        /*0x7ac0394*/ int <PlayAllEventsAccordingToTimestamps>b__38_0(UnityEngine.InputSystem.LowLevel.InputEventPtr a, UnityEngine.InputSystem.LowLevel.InputEventPtr b);
                    }

                    class <>c__DisplayClass43_0
                    {
                        /*0x10*/ int originalDeviceId;

                        /*0x7ac031c*/ <>c__DisplayClass43_0();
                        /*0x7ac045c*/ bool <ApplyDeviceMapping>b__0(UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo x);
                    }
                }

                struct DeviceInfo
                {
                    /*0x10*/ int m_DeviceId;
                    /*0x18*/ string m_Layout;
                    /*0x20*/ UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;
                    /*0x24*/ int m_StateSizeInBytes;
                    /*0x28*/ string m_FullLayoutJson;

                    /*0x7ac0470*/ int get_deviceId();
                    /*0x7ac0478*/ void set_deviceId(int value);
                    /*0x7ac0480*/ string get_layout();
                    /*0x7ac0488*/ void set_layout(string value);
                    /*0x7ac0490*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                    /*0x7ac0498*/ void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value);
                    /*0x7ac04a0*/ int get_stateSizeInBytes();
                    /*0x7ac04a8*/ void set_stateSizeInBytes(int value);
                }
            }

            struct StateEvent : UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
            {
                static int Type = 1398030676;
                static int kStateDataSizeToSubtract = 1;
                /*0x10*/ UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
                /*0x24*/ UnityEngine.InputSystem.Utilities.FourCC stateFormat;
                /*0x28*/ UnityEngine.InputSystem.LowLevel.StateEvent.<stateData> stateData;

                static /*0x3907c14*/ TState GetState<TState>(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x3821e38*/ int GetEventSizeWithPayload<TState>();
                static /*0x7abbbb0*/ UnityEngine.InputSystem.LowLevel.StateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7abba00*/ UnityEngine.InputSystem.LowLevel.StateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr);
                static /*0x7ac04c8*/ Unity.Collections.NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator);
                static /*0x7ac0804*/ Unity.Collections.NativeArray<byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator);
                static /*0x7ac04d0*/ Unity.Collections.NativeArray<byte> From(UnityEngine.InputSystem.InputDevice device, ref UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, Unity.Collections.Allocator allocator, bool useDefaultState);
                /*0x7abbcd4*/ uint get_stateSizeInBytes();
                /*0x7ac04b0*/ void* get_state();
                /*0x7ac04b8*/ UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr();
                /*0x7ac04bc*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
                /*0x3907c14*/ TState GetState<TState>();

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

                static /*0x7ac0818*/ UnityEngine.InputSystem.LowLevel.TextEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x7ac093c*/ UnityEngine.InputSystem.LowLevel.TextEvent Create(int deviceId, char character, double time);
                static /*0x7ac09b4*/ UnityEngine.InputSystem.LowLevel.TextEvent Create(int deviceId, int character, double time);
                /*0x7ac080c*/ UnityEngine.InputSystem.Utilities.FourCC get_typeStatic();
            }

            class InputUpdateDelegate : System.MulticastDelegate
            {
                /*0x7ac0a28*/ InputUpdateDelegate(object object, nint method);
                /*0x7ac0ac8*/ void Invoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer);
                /*0x7ac0adc*/ System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, System.AsyncCallback callback, object object);
                /*0x7ac0b98*/ void EndInvoke(ref UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, System.IAsyncResult result);
            }

            interface IInputRuntime
            {
                /*0x380b6a0*/ int AllocateDeviceId();
                /*0x380cffc*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType type);
                /*0x3907c14*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr);
                /*0x3907c14*/ long DeviceCommand(int deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr);
                /*0x380b9e8*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate();
                /*0x380d83c*/ void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value);
                /*0x380b9e8*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate();
                /*0x380d83c*/ void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value);
                /*0x380b9e8*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> get_onShouldRunUpdate();
                /*0x380d83c*/ void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> value);
                /*0x380b9e8*/ System.Action<int, string> get_onDeviceDiscovered();
                /*0x380d83c*/ void set_onDeviceDiscovered(System.Action<int, string> value);
                /*0x380b9e8*/ System.Action<bool> get_onPlayerFocusChanged();
                /*0x380d83c*/ void set_onPlayerFocusChanged(System.Action<bool> value);
                /*0x380b128*/ bool get_isPlayerFocused();
                /*0x380b9e8*/ System.Action get_onShutdown();
                /*0x380d83c*/ void set_onShutdown(System.Action value);
                /*0x380c2e4*/ float get_pollingFrequency();
                /*0x380e050*/ void set_pollingFrequency(float value);
                /*0x380b564*/ double get_currentTime();
                /*0x380b564*/ double get_currentTimeForFixedUpdate();
                /*0x380c2e4*/ float get_unscaledGameTime();
                /*0x380b564*/ double get_currentTimeOffsetToRealtimeSinceStartup();
                /*0x380b128*/ bool get_runInBackground();
                /*0x380cdf0*/ void set_runInBackground(bool value);
                UnityEngine.Vector2 get_screenSize();
                /*0x380b6a0*/ UnityEngine.ScreenOrientation get_screenOrientation();
                /*0x380b128*/ bool get_normalizeScrollWheelDelta();
                /*0x380cdf0*/ void set_normalizeScrollWheelDelta(bool value);
                /*0x380c2e4*/ float get_scrollWheelDeltaPerTick();
                /*0x380b128*/ bool get_isInBatchMode();
            }

            class InputRuntime
            {
                static /*0x0*/ UnityEngine.InputSystem.LowLevel.IInputRuntime s_Instance;
                static /*0x8*/ double s_CurrentTimeOffsetToRealtimeSinceStartup;
            }

            class InputRuntimeExtensions
            {
                static /*0x3907c14*/ long DeviceCommand<TCommand>(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, int deviceId, ref TCommand command);
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

                /*0x7ac0bb4*/ int get_maxNumDevices();
                /*0x7ac0bbc*/ void set_maxNumDevices(int value);
                /*0x7ac0bc4*/ int get_currentNumDevices();
                /*0x7ac0bcc*/ void set_currentNumDevices(int value);
                /*0x7ac0bd4*/ int get_maxStateSizeInBytes();
                /*0x7ac0bdc*/ void set_maxStateSizeInBytes(int value);
                /*0x7ac0be4*/ int get_currentStateSizeInBytes();
                /*0x7ac0bec*/ void set_currentStateSizeInBytes(int value);
                /*0x7ac0bf4*/ int get_currentControlCount();
                /*0x7ac0bfc*/ void set_currentControlCount(int value);
                /*0x7ac0c04*/ int get_currentLayoutCount();
                /*0x7ac0c0c*/ void set_currentLayoutCount(int value);
                /*0x7ac0c14*/ int get_totalEventBytes();
                /*0x7ac0c1c*/ void set_totalEventBytes(int value);
                /*0x7ac0c24*/ int get_totalEventCount();
                /*0x7ac0c2c*/ void set_totalEventCount(int value);
                /*0x7ac0c34*/ int get_totalUpdateCount();
                /*0x7ac0c3c*/ void set_totalUpdateCount(int value);
                /*0x7ac0c44*/ double get_totalEventProcessingTime();
                /*0x7ac0c4c*/ void set_totalEventProcessingTime(double value);
                /*0x7ac0c54*/ double get_totalEventLagTime();
                /*0x7ac0c5c*/ void set_totalEventLagTime(double value);
                /*0x7ac0c64*/ float get_averageEventBytesPerFrame();
                /*0x7ac0c7c*/ double get_averageProcessingTimePerEvent();
                /*0x7ac0c90*/ double get_averageLagTimePerEvent();
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

                static /*0x7ac0ca4*/ void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type);
                static /*0x7ac0d2c*/ void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type);
                static /*0x7ac0db4*/ UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState Save();
                static /*0x7ac0e20*/ void Restore(UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState state);
                static /*0x7ac0eb4*/ UnityEngine.InputSystem.LowLevel.InputUpdateType GetUpdateTypeForPlayer(UnityEngine.InputSystem.LowLevel.InputUpdateType mask);
                static /*0x7ac0ed4*/ bool IsPlayerUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);

                struct UpdateStepCount
                {
                    /*0x10*/ bool m_WasUpdated;
                    /*0x14*/ uint <value>k__BackingField;

                    /*0x7ac0ee0*/ uint get_value();
                    /*0x7ac0ee8*/ void set_value(uint value);
                    /*0x7ac0ef0*/ void OnBeforeUpdate();
                    /*0x7ac0f08*/ void OnUpdate();
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

                static /*0x7ac1be0*/ NativeInputRuntime();
                /*0x7ac1bd0*/ NativeInputRuntime();
                /*0x7ac0f24*/ int AllocateDeviceId();
                /*0x7ac0f74*/ void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
                /*0x7ac0fcc*/ void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr);
                /*0x7ac1038*/ long DeviceCommand(int deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr);
                /*0x7ac111c*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate();
                /*0x7ac1124*/ void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value);
                /*0x7ac1264*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate();
                /*0x7ac126c*/ void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value);
                /*0x7ac13a4*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> get_onShouldRunUpdate();
                /*0x7ac13ac*/ void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> value);
                /*0x7ac14e4*/ System.Action<int, string> get_onDeviceDiscovered();
                /*0x7ac1534*/ void set_onDeviceDiscovered(System.Action<int, string> value);
                /*0x7ac158c*/ System.Action get_onShutdown();
                /*0x7ac1594*/ void set_onShutdown(System.Action value);
                /*0x7ac16a4*/ System.Action<bool> get_onPlayerFocusChanged();
                /*0x7ac16ac*/ void set_onPlayerFocusChanged(System.Action<bool> value);
                /*0x7ac17bc*/ bool get_isPlayerFocused();
                /*0x7ac180c*/ float get_pollingFrequency();
                /*0x7ac1814*/ void set_pollingFrequency(float value);
                /*0x7ac187c*/ double get_currentTime();
                /*0x7ac18cc*/ double get_currentTimeForFixedUpdate();
                /*0x7ac18f8*/ double get_currentTimeOffsetToRealtimeSinceStartup();
                /*0x7ac1948*/ float get_unscaledGameTime();
                /*0x7ac1950*/ bool get_runInBackground();
                /*0x7ac19c0*/ void set_runInBackground(bool value);
                /*0x7ac19cc*/ void OnShutdown();
                /*0x7ac19f0*/ bool OnWantsToShutdown();
                /*0x7ac1a30*/ void OnFocusChanged(bool focus);
                /*0x7ac1a58*/ UnityEngine.Vector2 get_screenSize();
                /*0x7ac1a80*/ UnityEngine.ScreenOrientation get_screenOrientation();
                /*0x7ac1a88*/ bool get_normalizeScrollWheelDelta();
                /*0x7ac1ad8*/ void set_normalizeScrollWheelDelta(bool value);
                /*0x7ac1b30*/ float get_scrollWheelDeltaPerTick();
                /*0x7ac1b80*/ bool get_isInBatchMode();

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value;

                    /*0x7ac139c*/ <>c__DisplayClass10_0();
                    /*0x7ac1c50*/ void <set_onBeforeUpdate>b__0(UnityEngineInternal.Input.NativeInputUpdateType updateType);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> value;

                    /*0x7ac14dc*/ <>c__DisplayClass13_0();
                    /*0x7ac1c74*/ bool <set_onShouldRunUpdate>b__0(UnityEngineInternal.Input.NativeInputUpdateType updateType);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value;

                    /*0x7ac125c*/ <>c__DisplayClass7_0();
                    /*0x7ac1c98*/ void <set_onUpdate>b__0(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* eventBufferPtr);
                }
            }

            interface IInputStateCallbackReceiver
            {
                /*0x380cb08*/ void OnNextUpdate();
                /*0x380cfbc*/ void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
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
                static /*0x7ac1e84*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_currentUpdateType();
                static /*0x7ac1ecc*/ uint get_updateCount();
                static /*0x7ac1f14*/ double get_currentTime();
                static /*0x7ac1fe4*/ void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7ac2050*/ void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr> value);
                static /*0x7ac20bc*/ void Change(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
                static /*0x3907c14*/ void Change<TState>(UnityEngine.InputSystem.InputControl control, TState state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x3907c14*/ void Change<TState>(UnityEngine.InputSystem.InputControl control, ref TState state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                static /*0x7ac2358*/ bool IsIntegerFormat(UnityEngine.InputSystem.Utilities.FourCC format);
                static /*0x7ac24c4*/ void AddChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex);
                static /*0x7ac2628*/ UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor AddChangeMonitor(UnityEngine.InputSystem.InputControl control, System.Action<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, long> valueChangeCallback, int monitorIndex, System.Action<UnityEngine.InputSystem.InputControl, double, long, int> timerExpiredCallback);
                static /*0x7ac2724*/ void RemoveChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex);
                static /*0x7ac2818*/ void AddChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex);
                static /*0x7ac2900*/ void RemoveChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex);

                class StateChangeMonitorDelegate : UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
                {
                    /*0x10*/ System.Action<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, long> valueChangeCallback;
                    /*0x18*/ System.Action<UnityEngine.InputSystem.InputControl, double, long, int> timerExpiredCallback;

                    /*0x7ac271c*/ StateChangeMonitorDelegate();
                    /*0x7ac29d0*/ void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                    /*0x7ac29f4*/ void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
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

                static /*0x7ac543c*/ InputStateBlock();
                static /*0x7ac2a10*/ int GetSizeOfPrimitiveFormatInBits(UnityEngine.InputSystem.Utilities.FourCC type);
                static /*0x7ac2cf8*/ UnityEngine.InputSystem.Utilities.FourCC GetPrimitiveFormatFromType(System.Type type);
                /*0x7ac3180*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                /*0x7ac3188*/ void set_format(UnityEngine.InputSystem.Utilities.FourCC value);
                /*0x7ac3190*/ uint get_byteOffset();
                /*0x7ac3198*/ void set_byteOffset(uint value);
                /*0x7ac31a0*/ uint get_bitOffset();
                /*0x7ac31a8*/ void set_bitOffset(uint value);
                /*0x7ac31b0*/ uint get_sizeInBits();
                /*0x7ac31b8*/ void set_sizeInBits(uint value);
                /*0x7ac31c0*/ uint get_alignedSizeInBytes();
                /*0x7ac321c*/ uint get_effectiveByteOffset();
                /*0x7ac3274*/ uint get_effectiveBitOffset();
                /*0x7ac32cc*/ int ReadInt(void* statePtr);
                /*0x7ac3584*/ void WriteInt(void* statePtr, int value);
                /*0x7ac3844*/ float ReadFloat(void* statePtr);
                /*0x7ac3c2c*/ void WriteFloat(void* statePtr, float value);
                /*0x7ac413c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FloatToPrimitiveValue(float value);
                /*0x7ac469c*/ double ReadDouble(void* statePtr);
                /*0x7ac4a80*/ void WriteDouble(void* statePtr, double value);
                /*0x7ac4fa8*/ void Write(void* statePtr, UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x7ac533c*/ void CopyToFrom(void* toStatePtr, void* fromStatePtr);
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

                static /*0x7ac5924*/ void* GetFrontBufferForDevice(int deviceIndex);
                static /*0x7ac59b0*/ void* GetBackBufferForDevice(int deviceIndex);
                static /*0x7ac5a44*/ void SwitchTo(UnityEngine.InputSystem.LowLevel.InputStateBuffers buffers, UnityEngine.InputSystem.LowLevel.InputUpdateType update);
                static /*0x7ac5bcc*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer);
                static /*0x7ac5e80*/ void MigrateDoubleBuffer(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers oldBuffer);
                static /*0x7ac6038*/ void MigrateSingleBuffer(void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer);
                static /*0x7ac5b60*/ uint ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount);
                static /*0x7ac613c*/ uint NextDeviceOffset(uint currentOffset, UnityEngine.InputSystem.InputDevice device);
                /*0x7ac584c*/ UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType);
                /*0x7ac5aa8*/ void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount);
                /*0x7ac5c68*/ void FreeAll();
                /*0x7ac5d28*/ void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers oldBuffers);

                struct DoubleBuffers
                {
                    /*0x10*/ void** deviceToBufferMapping;
                    /*0x18*/ int deviceCount;

                    /*0x7ac6224*/ bool get_valid();
                    /*0x7ac5c2c*/ void SetFrontBuffer(int deviceIndex, void* ptr);
                    /*0x7ac5c48*/ void SetBackBuffer(int deviceIndex, void* ptr);
                    /*0x7ac598c*/ void* GetFrontBuffer(int deviceIndex);
                    /*0x7ac5a1c*/ void* GetBackBuffer(int deviceIndex);
                    /*0x7ac6234*/ void SwapBuffers(int deviceIndex);
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

                /*0x7ac6cd8*/ InputStateHistory(int maxStateSizeInBytes);
                /*0x7ac6d84*/ InputStateHistory(string path);
                /*0x7ac6ef0*/ InputStateHistory(UnityEngine.InputSystem.InputControl control);
                /*0x7ac7000*/ InputStateHistory(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls);
                /*0x7ac6268*/ int get_Count();
                /*0x7ac6270*/ uint get_version();
                /*0x7ac6278*/ int get_historyDepth();
                /*0x7ac6280*/ void set_historyDepth(int value);
                /*0x7ac6348*/ int get_extraMemoryPerRecord();
                /*0x7ac6350*/ void set_extraMemoryPerRecord(int value);
                /*0x7ac6418*/ UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask();
                /*0x7ac64ac*/ void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value);
                /*0x7ac6574*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls();
                /*0x7ac65dc*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Item(int index);
                /*0x7ac6818*/ void set_Item(int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record value);
                /*0x7ac6cb8*/ System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded();
                /*0x7ac6cc0*/ void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value);
                /*0x7ac6cc8*/ System.Func<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> get_onShouldRecordStateChange();
                /*0x7ac6cd0*/ void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl, double, UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> value);
                /*0x7ac7090*/ void Finalize();
                /*0x7ac718c*/ void Clear();
                /*0x7ac71a0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record);
                /*0x7ac7308*/ void StartRecording();
                /*0x7ac7464*/ void StopRecording();
                /*0x7ac75bc*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr);
                /*0x7ac7770*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, void* statePtr, double time);
                /*0x7ac7a30*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator();
                /*0x7ac7ac4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7ac7124*/ void Dispose();
                /*0x7ac7ac8*/ void Destroy();
                /*0x7ac7b2c*/ void Allocate();
                /*0x7ac7e14*/ int RecordIndexToUserIndex(int index);
                /*0x7ac66e8*/ int UserIndexToRecordIndex(int index);
                /*0x7ac6700*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecord(int index);
                /*0x7ac7e38*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecordUnchecked(int index);
                /*0x7ac7200*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* AllocateRecord(ref int index);
                /*0x3907c14*/ TValue ReadValue<TValue>(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data);
                /*0x7ac7ee4*/ object ReadValueAsObject(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data);
                /*0x7ac7fdc*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex);
                /*0x7ac80b4*/ void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex);
                /*0x7ac7dc4*/ int get_bytesPerRecord();

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.LowLevel.InputStateHistory m_History;
                    /*0x18*/ int m_Index;

                    /*0x7ac7aa4*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputStateHistory history);
                    /*0x7ac80b8*/ bool MoveNext();
                    /*0x7ac80f0*/ void Reset();
                    /*0x7ac80fc*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Current();
                    /*0x7ac811c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7ac8180*/ void Dispose();
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

                    /*0x7ac7a28*/ byte* get_statePtrWithControlIndex();
                    /*0x7ac7a20*/ byte* get_statePtrWithoutControlIndex();

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

                    /*0x7ac67d8*/ Record(UnityEngine.InputSystem.LowLevel.InputStateHistory owner, int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header);
                    /*0x7ac8184*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header();
                    /*0x7ac81a8*/ int get_recordIndex();
                    /*0x7ac81b4*/ uint get_version();
                    /*0x7ac81bc*/ bool get_valid();
                    /*0x7ac8204*/ UnityEngine.InputSystem.LowLevel.InputStateHistory get_owner();
                    /*0x7ac820c*/ int get_index();
                    /*0x7ac82f0*/ double get_time();
                    /*0x7ac8318*/ UnityEngine.InputSystem.InputControl get_control();
                    /*0x7ac83cc*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_next();
                    /*0x7ac8468*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_previous();
                    /*0x3907c14*/ TValue ReadValue<TValue>();
                    /*0x7ac84fc*/ object ReadValueAsObject();
                    /*0x7ac8534*/ void* GetUnsafeMemoryPtr();
                    /*0x7ac854c*/ void* GetUnsafeMemoryPtrUnchecked();
                    /*0x7ac85cc*/ void* GetUnsafeExtraMemoryPtr();
                    /*0x7ac85e4*/ void* GetUnsafeExtraMemoryPtrUnchecked();
                    /*0x7ac694c*/ void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record);
                    /*0x7ac8248*/ void CheckValid();
                    /*0x7ac86b0*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record other);
                    /*0x7ac86e4*/ bool Equals(object obj);
                    /*0x7ac877c*/ int GetHashCode();
                    /*0x7ac87c4*/ string ToString();
                }
            }

            class InputStateHistory<TValue> : UnityEngine.InputSystem.LowLevel.InputStateHistory, System.Collections.Generic.IReadOnlyList<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>
            {
                /*0x380cbf0*/ InputStateHistory(System.Nullable<int> maxStateSizeInBytes);
                /*0x380d83c*/ InputStateHistory(UnityEngine.InputSystem.InputControl<TValue> control);
                /*0x380d83c*/ InputStateHistory(string path);
                /*0x380cb08*/ void Finalize();
                /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record);
                /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, double time);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Item(int index);
                /*0x3907c14*/ void set_Item(int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> value);

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History;
                    /*0x0*/ int m_Index;

                    /*0x380d83c*/ Enumerator(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history);
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                }

                struct Record<TValue> : System.IEquatable<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>>
                {
                    /*0x0*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_Owner;
                    /*0x0*/ int m_IndexPlusOne;
                    /*0x0*/ uint m_Version;

                    /*0x3907c14*/ Record(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header);
                    /*0x380d8b8*/ Record(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index);
                    /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header();
                    /*0x380b6a0*/ int get_recordIndex();
                    /*0x380b128*/ bool get_valid();
                    /*0x380b9e8*/ UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner();
                    /*0x380b6a0*/ int get_index();
                    /*0x380b564*/ double get_time();
                    /*0x380b9e8*/ UnityEngine.InputSystem.InputControl<TValue> get_control();
                    /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_next();
                    /*0x3907c14*/ UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_previous();
                    /*0x3907c14*/ TValue ReadValue();
                    /*0x3907c14*/ void* GetUnsafeMemoryPtr();
                    /*0x3907c14*/ void* GetUnsafeMemoryPtrUnchecked();
                    /*0x3907c14*/ void* GetUnsafeExtraMemoryPtr();
                    /*0x3907c14*/ void* GetUnsafeExtraMemoryPtrUnchecked();
                    /*0x3907c14*/ void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record);
                    /*0x380cb08*/ void CheckValid();
                    /*0x3907c14*/ bool Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> other);
                    /*0x380b2f0*/ bool Equals(object obj);
                    /*0x380b6a0*/ int GetHashCode();
                    /*0x380b9e8*/ string ToString();
                }
            }

            class SelectObservable<TSource, TResult> : System.IObservable<TResult>
            {
                /*0x0*/ System.IObservable<TSource> m_Source;
                /*0x0*/ System.Func<TSource, TResult> m_Filter;

                /*0x380d93c*/ SelectObservable(System.IObservable<TSource> source, System.Func<TSource, TResult> filter);
                /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<TResult> observer);

                class Select<TSource, TResult> : System.IObserver<TSource>
                {
                    /*0x0*/ UnityEngine.InputSystem.LowLevel.SelectObservable<TSource, TResult> m_Observable;
                    /*0x0*/ System.IObserver<TResult> m_Observer;

                    /*0x380d93c*/ Select(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource, TResult> observable, System.IObserver<TResult> observer);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x3907c14*/ void OnNext(TSource evt);
                }
            }
        }

        namespace Processors
        {
            class AxisDeadzoneProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7ac8a6c*/ AxisDeadzoneProcessor();
                /*0x7ac8888*/ float get_minOrDefault();
                /*0x7ac88f8*/ float get_maxOrDefault();
                /*0x7ac8968*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac89d0*/ string ToString();
            }

            class ClampProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7ac8b60*/ ClampProcessor();
                /*0x7ac8ab4*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac8acc*/ string ToString();
            }

            class CompensateDirectionProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x7ac8de0*/ CompensateDirectionProcessor();
                /*0x7ac8ba8*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac8d98*/ string ToString();
                /*0x7ac8dd8*/ UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy();
            }

            class CompensateRotationProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Quaternion>
            {
                /*0x7ac9080*/ CompensateRotationProcessor();
                /*0x7ac8e28*/ UnityEngine.Quaternion Process(UnityEngine.Quaternion value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac9038*/ string ToString();
                /*0x7ac9078*/ UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy();
            }

            class InvertProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x7ac9110*/ InvertProcessor();
                /*0x7ac90c8*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac90d0*/ string ToString();
            }

            class InvertVector2Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x10*/ bool invertX;
                /*0x11*/ bool invertY;

                /*0x7ac9210*/ InvertVector2Processor();
                /*0x7ac9158*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac917c*/ string ToString();
            }

            class InvertVector3Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x10*/ bool invertX;
                /*0x11*/ bool invertY;
                /*0x12*/ bool invertZ;

                /*0x7ac934c*/ InvertVector3Processor();
                /*0x7ac9260*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac9294*/ string ToString();
            }

            class NormalizeProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;
                /*0x18*/ float zero;

                static /*0x7ac93b0*/ float Normalize(float value, float min, float max, float zero);
                static /*0x7ac9480*/ float Denormalize(float value, float min, float max, float zero);
                /*0x7ac9580*/ NormalizeProcessor();
                /*0x7ac93a4*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac94c8*/ string ToString();
            }

            class NormalizeVector2Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x7ac96bc*/ NormalizeVector2Processor();
                /*0x7ac95c8*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac967c*/ string ToString();
            }

            class NormalizeVector3Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x7ac9814*/ NormalizeVector3Processor();
                /*0x7ac9704*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac97d4*/ string ToString();
            }

            class ScaleProcessor : UnityEngine.InputSystem.InputProcessor<float>
            {
                /*0x10*/ float factor;

                /*0x7ac98e0*/ ScaleProcessor();
                /*0x7ac985c*/ float Process(float value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac9868*/ string ToString();
            }

            class ScaleVector2Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x10*/ float x;
                /*0x14*/ float y;

                /*0x7ac99d4*/ ScaleVector2Processor();
                /*0x7ac9930*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac9940*/ string ToString();
            }

            class ScaleVector3Processor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector3>
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float z;

                /*0x7ac9af4*/ ScaleVector3Processor();
                /*0x7ac9a24*/ UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac9a3c*/ string ToString();
            }

            class StickDeadzoneProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7ac9e00*/ StickDeadzoneProcessor();
                /*0x7ac9b4c*/ float get_minOrDefault();
                /*0x7ac9bbc*/ float get_maxOrDefault();
                /*0x7ac9c2c*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
                /*0x7ac9cfc*/ float GetDeadZoneAdjustedValue(float value);
                /*0x7ac9d64*/ string ToString();
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

                /*0x7ac9fc4*/ InputControlAttribute();
                /*0x7ac9e48*/ string get_layout();
                /*0x7ac9e50*/ void set_layout(string value);
                /*0x7ac9e58*/ string get_variants();
                /*0x7ac9e60*/ void set_variants(string value);
                /*0x7ac9e68*/ string get_name();
                /*0x7ac9e70*/ void set_name(string value);
                /*0x7ac9e78*/ string get_format();
                /*0x7ac9e80*/ void set_format(string value);
                /*0x7ac9e88*/ string get_usage();
                /*0x7ac9e90*/ void set_usage(string value);
                /*0x7ac9e98*/ string[] get_usages();
                /*0x7ac9ea0*/ void set_usages(string[] value);
                /*0x7ac9ea8*/ string get_parameters();
                /*0x7ac9eb0*/ void set_parameters(string value);
                /*0x7ac9eb8*/ string get_processors();
                /*0x7ac9ec0*/ void set_processors(string value);
                /*0x7ac9ec8*/ string get_alias();
                /*0x7ac9ed0*/ void set_alias(string value);
                /*0x7ac9ed8*/ string[] get_aliases();
                /*0x7ac9ee0*/ void set_aliases(string[] value);
                /*0x7ac9ee8*/ string get_useStateFrom();
                /*0x7ac9ef0*/ void set_useStateFrom(string value);
                /*0x7ac9ef8*/ uint get_bit();
                /*0x7ac9f00*/ void set_bit(uint value);
                /*0x7ac9f08*/ uint get_offset();
                /*0x7ac9f10*/ void set_offset(uint value);
                /*0x7ac9f18*/ uint get_sizeInBits();
                /*0x7ac9f20*/ void set_sizeInBits(uint value);
                /*0x7ac9f28*/ int get_arraySize();
                /*0x7ac9f30*/ void set_arraySize(int value);
                /*0x7ac9f38*/ string get_displayName();
                /*0x7ac9f40*/ void set_displayName(string value);
                /*0x7ac9f48*/ string get_shortDisplayName();
                /*0x7ac9f50*/ void set_shortDisplayName(string value);
                /*0x7ac9f58*/ bool get_noisy();
                /*0x7ac9f60*/ void set_noisy(bool value);
                /*0x7ac9f6c*/ bool get_synthetic();
                /*0x7ac9f74*/ void set_synthetic(bool value);
                /*0x7ac9f80*/ bool get_dontReset();
                /*0x7ac9f88*/ void set_dontReset(bool value);
                /*0x7ac9f94*/ object get_defaultState();
                /*0x7ac9f9c*/ void set_defaultState(object value);
                /*0x7ac9fa4*/ object get_minValue();
                /*0x7ac9fac*/ void set_minValue(object value);
                /*0x7ac9fb4*/ object get_maxValue();
                /*0x7ac9fbc*/ void set_maxValue(object value);
            }

            class InputDeviceFindControlLayoutDelegate : System.MulticastDelegate
            {
                /*0x7ac9fd4*/ InputDeviceFindControlLayoutDelegate(object object, nint method);
                /*0x7aca088*/ string Invoke(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand);
                /*0x7aca09c*/ System.IAsyncResult BeginInvoke(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, string matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand, System.AsyncCallback callback, object object);
                /*0x7aca140*/ string EndInvoke(ref UnityEngine.InputSystem.Layouts.InputDeviceDescription description, System.IAsyncResult result);
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

                static /*0x7acf5d8*/ InputControlLayout();
                static /*0x7aca15c*/ UnityEngine.InputSystem.Utilities.InternedString get_DefaultVariant();
                static /*0x7acac6c*/ UnityEngine.InputSystem.Layouts.InputControlLayout FromType(string name, System.Type type);
                static /*0x7acb674*/ UnityEngine.InputSystem.Layouts.InputControlLayout FromJson(string json);
                static /*0x7acb134*/ void AddControlItems(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName);
                static /*0x7acc0d8*/ void AddControlItemsFromFields(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName);
                static /*0x7acc16c*/ void AddControlItemsFromProperties(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName);
                static /*0x7acc200*/ void AddControlItemsFromMembers(System.Reflection.MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName);
                static /*0x7acc728*/ void AddControlItemsFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems);
                static /*0x7acc9b8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem CreateControlItemFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute attribute);
                static /*0x7acd228*/ string InferLayoutFromValueType(System.Type type);
                static /*0x7ace990*/ System.Collections.Generic.Dictionary<string, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] controlItems, System.Collections.Generic.List<string> variants);
                static /*0x7acf30c*/ bool VariantsMatch(UnityEngine.InputSystem.Utilities.InternedString expected, UnityEngine.InputSystem.Utilities.InternedString actual);
                static /*0x7acf1e0*/ bool VariantsMatch(string expected, string actual);
                static /*0x7acf370*/ void ParseHeaderFieldsFromJson(string json, ref UnityEngine.InputSystem.Utilities.InternedString name, ref UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, ref UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher);
                static /*0x7acf51c*/ ref UnityEngine.InputSystem.Layouts.InputControlLayout.Cache get_cache();
                static /*0x7acf574*/ UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance CacheRef();
                /*0x7acb1b0*/ InputControlLayout(string name, System.Type type);
                /*0x7aca1b4*/ UnityEngine.InputSystem.Utilities.InternedString get_name();
                /*0x7aca1c0*/ string get_displayName();
                /*0x7aca1e0*/ System.Type get_type();
                /*0x7aca1e8*/ UnityEngine.InputSystem.Utilities.InternedString get_variants();
                /*0x7aca1f4*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                /*0x7aca1fc*/ int get_stateSizeInBytes();
                /*0x7aca204*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts();
                /*0x7aca264*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides();
                /*0x7aca2c4*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages();
                /*0x7aca324*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls();
                /*0x7aca384*/ bool get_updateBeforeRender();
                /*0x7aca3c0*/ bool get_isDeviceLayout();
                /*0x7aca440*/ bool get_isControlLayout();
                /*0x7aca458*/ bool get_isOverride();
                /*0x7aca464*/ void set_isOverride(bool value);
                /*0x7aca484*/ bool get_isGenericTypeOfDevice();
                /*0x7aca490*/ void set_isGenericTypeOfDevice(bool value);
                /*0x7aca4a0*/ bool get_hideInUI();
                /*0x7aca4ac*/ void set_hideInUI(bool value);
                /*0x7aca4cc*/ bool get_isNoisy();
                /*0x7aca4d8*/ void set_isNoisy(bool value);
                /*0x7aca4f8*/ System.Nullable<bool> get_canRunInBackground();
                /*0x7aca560*/ void set_canRunInBackground(System.Nullable<bool> value);
                /*0x7aca5fc*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem get_Item(string path);
                /*0x7aca774*/ System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(UnityEngine.InputSystem.Utilities.InternedString path);
                /*0x7aca904*/ System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, ref int arrayIndex);
                /*0x7acabf0*/ System.Type GetValueType();
                /*0x7acb218*/ string ToJson();
                /*0x7acd6f0*/ void MergeLayout(UnityEngine.InputSystem.Layouts.InputControlLayout other);
                /*0x7acf664*/ bool <MergeLayout>b__77_0(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem x);

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

                    /*0x7acf6d8*/ UnityEngine.InputSystem.Utilities.InternedString get_name();
                    /*0x7acf6e4*/ void set_name(UnityEngine.InputSystem.Utilities.InternedString value);
                    /*0x7acf6f0*/ UnityEngine.InputSystem.Utilities.InternedString get_layout();
                    /*0x7acf6fc*/ void set_layout(UnityEngine.InputSystem.Utilities.InternedString value);
                    /*0x7acf70c*/ UnityEngine.InputSystem.Utilities.InternedString get_variants();
                    /*0x7acf718*/ void set_variants(UnityEngine.InputSystem.Utilities.InternedString value);
                    /*0x7acf728*/ string get_useStateFrom();
                    /*0x7acf730*/ void set_useStateFrom(string value);
                    /*0x7acf738*/ string get_displayName();
                    /*0x7acf740*/ void set_displayName(string value);
                    /*0x7acf748*/ string get_shortDisplayName();
                    /*0x7acf750*/ void set_shortDisplayName(string value);
                    /*0x7acf758*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages();
                    /*0x7acf764*/ void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value);
                    /*0x7acf774*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases();
                    /*0x7acf780*/ void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value);
                    /*0x7acf790*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters();
                    /*0x7acf79c*/ void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value);
                    /*0x7acf7ac*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors();
                    /*0x7acf7b8*/ void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value);
                    /*0x7acf7c8*/ uint get_offset();
                    /*0x7acf7d0*/ void set_offset(uint value);
                    /*0x7acf7d8*/ uint get_bit();
                    /*0x7acf7e0*/ void set_bit(uint value);
                    /*0x7acf7e8*/ uint get_sizeInBits();
                    /*0x7acf7f0*/ void set_sizeInBits(uint value);
                    /*0x7acf7f8*/ UnityEngine.InputSystem.Utilities.FourCC get_format();
                    /*0x7acf800*/ void set_format(UnityEngine.InputSystem.Utilities.FourCC value);
                    /*0x7acf808*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags get_flags();
                    /*0x7acf810*/ void set_flags(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags value);
                    /*0x7acf818*/ int get_arraySize();
                    /*0x7acf820*/ void set_arraySize(int value);
                    /*0x7acf828*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_defaultState();
                    /*0x7acf834*/ void set_defaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                    /*0x7acf83c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_minValue();
                    /*0x7acf848*/ void set_minValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                    /*0x7acf850*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_maxValue();
                    /*0x7acf85c*/ void set_maxValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                    /*0x7acf864*/ bool get_isModifyingExistingControl();
                    /*0x7acd3e0*/ void set_isModifyingExistingControl(bool value);
                    /*0x7acf870*/ bool get_isNoisy();
                    /*0x7acd410*/ void set_isNoisy(bool value);
                    /*0x7acf87c*/ bool get_isSynthetic();
                    /*0x7acd450*/ void set_isSynthetic(bool value);
                    /*0x7acf888*/ bool get_dontReset();
                    /*0x7acd430*/ void set_dontReset(bool value);
                    /*0x7acf894*/ bool get_isFirstDefinedInThisLayout();
                    /*0x7acd3f0*/ void set_isFirstDefinedInThisLayout(bool value);
                    /*0x7acabe0*/ bool get_isArray();
                    /*0x7aceda4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem Merge(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem other);

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

                    /*0x7acfdf4*/ Builder();
                    /*0x7acf8a0*/ string get_name();
                    /*0x7acf8a8*/ void set_name(string value);
                    /*0x7acf8b0*/ string get_displayName();
                    /*0x7acf8b8*/ void set_displayName(string value);
                    /*0x7acf8c0*/ System.Type get_type();
                    /*0x7acf8c8*/ void set_type(System.Type value);
                    /*0x7acf8d0*/ UnityEngine.InputSystem.Utilities.FourCC get_stateFormat();
                    /*0x7acf8d8*/ void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value);
                    /*0x7acf8e0*/ int get_stateSizeInBytes();
                    /*0x7acf8e8*/ void set_stateSizeInBytes(int value);
                    /*0x7acf8f0*/ string get_extendsLayout();
                    /*0x7acf8f8*/ void set_extendsLayout(string value);
                    /*0x7acf940*/ System.Nullable<bool> get_updateBeforeRender();
                    /*0x7acf948*/ void set_updateBeforeRender(System.Nullable<bool> value);
                    /*0x7acf950*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls();
                    /*0x7acf9b8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AddControl(string name);
                    /*0x7acfb30*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithName(string name);
                    /*0x7acfb4c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithDisplayName(string displayName);
                    /*0x380b9e8*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithType<T>();
                    /*0x7acfb68*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format);
                    /*0x7acfb70*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(string format);
                    /*0x7acfba4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithSizeInBytes(int sizeInBytes);
                    /*0x7acfbac*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder Extend(string baseLayoutName);
                    /*0x7acfbc4*/ UnityEngine.InputSystem.Layouts.InputControlLayout Build();

                    struct ControlBuilder
                    {
                        /*0x10*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder builder;
                        /*0x18*/ int index;

                        /*0x7acfdfc*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDisplayName(string displayName);
                        /*0x7acfe48*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithLayout(string layout);
                        /*0x7acff38*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format);
                        /*0x7acff80*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(string format);
                        /*0x7acffb4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithByteOffset(uint offset);
                        /*0x7acfffc*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithBitOffset(uint bit);
                        /*0x7ad0044*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsSynthetic(bool value);
                        /*0x7ad00a4*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsNoisy(bool value);
                        /*0x7ad0104*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder DontReset(bool value);
                        /*0x7ad0164*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithSizeInBits(uint sizeInBits);
                        /*0x7ad01ac*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithRange(float minValue, float maxValue);
                        /*0x7ad0248*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(UnityEngine.InputSystem.Utilities.InternedString[] usages);
                        /*0x7ad0420*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<string> usages);
                        /*0x7ad054c*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(string[] usages);
                        /*0x7ad0550*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithParameters(string parameters);
                        /*0x7ad0610*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithProcessors(string processors);
                        /*0x7ad06ec*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                        /*0x7ad0734*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder UsingStateFrom(string path);
                        /*0x7ad07a0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AsArrayOfControlsWithSize(int arraySize);

                        class <>c
                        {
                            static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder.<> <>9;
                            static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0;

                            static /*0x7ad07e8*/ <>c();
                            /*0x7ad0850*/ <>c();
                            /*0x7ad0858*/ UnityEngine.InputSystem.Utilities.InternedString <WithUsages>b__14_0(string x);
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

                    static /*0x7acb294*/ UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson FromLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout);
                    /*0x7acb704*/ UnityEngine.InputSystem.Layouts.InputControlLayout ToLayout();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson.<> <>9;
                        static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0;
                        static /*0x10*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__15_0;
                        static /*0x18*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__15_1;

                        static /*0x7ad16d8*/ <>c();
                        /*0x7ad1740*/ <>c();
                        /*0x7ad1748*/ UnityEngine.InputSystem.Utilities.InternedString <ToLayout>b__14_0(string x);
                        /*0x7ad1770*/ string <FromLayout>b__15_0(UnityEngine.InputSystem.Utilities.InternedString x);
                        /*0x7ad1794*/ string <FromLayout>b__15_1(UnityEngine.InputSystem.Utilities.InternedString x);
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

                    static /*0x7ad0f48*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] FromControlItems(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] items);
                    /*0x7ad17b8*/ ControlItemJson();
                    /*0x7ad0880*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem ToLayout();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson.<> <>9;
                        static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__24_0;
                        static /*0x10*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__24_1;
                        static /*0x18*/ System.Func<UnityEngine.InputSystem.Utilities.NamedValue, string> <>9__25_0;
                        static /*0x20*/ System.Func<UnityEngine.InputSystem.Utilities.NameAndParameters, string> <>9__25_1;
                        static /*0x28*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__25_2;
                        static /*0x30*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__25_3;

                        static /*0x7ad17d8*/ <>c();
                        /*0x7ad1840*/ <>c();
                        /*0x7ad1848*/ UnityEngine.InputSystem.Utilities.InternedString <ToLayout>b__24_0(string x);
                        /*0x7ad1870*/ UnityEngine.InputSystem.Utilities.InternedString <ToLayout>b__24_1(string x);
                        /*0x7ad1898*/ string <FromControlItems>b__25_0(UnityEngine.InputSystem.Utilities.NamedValue x);
                        /*0x7ad18a4*/ string <FromControlItems>b__25_1(UnityEngine.InputSystem.Utilities.NameAndParameters x);
                        /*0x7ad18b0*/ string <FromControlItems>b__25_2(UnityEngine.InputSystem.Utilities.InternedString x);
                        /*0x7ad18d4*/ string <FromControlItems>b__25_3(UnityEngine.InputSystem.Utilities.InternedString x);
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

                    /*0x7ad18f8*/ void Allocate();
                    /*0x7acd470*/ UnityEngine.InputSystem.Utilities.InternedString TryFindLayoutForType(System.Type layoutType);
                    /*0x7ad1ba0*/ UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                    /*0x7acd614*/ bool HasLayout(UnityEngine.InputSystem.Utilities.InternedString name);
                    /*0x7ad1d70*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayoutInternal(UnityEngine.InputSystem.Utilities.InternedString name);
                    /*0x7ad1f64*/ UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayout(UnityEngine.InputSystem.Utilities.InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout> table);
                    /*0x7ad23d8*/ UnityEngine.InputSystem.Utilities.InternedString GetBaseLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName);
                    /*0x7ad2464*/ UnityEngine.InputSystem.Utilities.InternedString GetRootLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName);
                    /*0x7ad24f8*/ bool ComputeDistanceInInheritanceHierarchy(UnityEngine.InputSystem.Utilities.InternedString firstLayout, UnityEngine.InputSystem.Utilities.InternedString secondLayout, ref int distance);
                    /*0x7ad2630*/ UnityEngine.InputSystem.Utilities.InternedString FindLayoutThatIntroducesControl(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache);
                    /*0x7ad2850*/ System.Type GetControlTypeForLayout(UnityEngine.InputSystem.Utilities.InternedString layoutName);
                    /*0x7ad2990*/ bool ValueTypeIsAssignableFrom(UnityEngine.InputSystem.Utilities.InternedString layoutName, System.Type valueType);
                    /*0x7ad2aa0*/ bool IsGeneratedLayout(UnityEngine.InputSystem.Utilities.InternedString layout);
                    /*0x7ad2b08*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(UnityEngine.InputSystem.Utilities.InternedString layout, bool includeSelf);
                    /*0x7ad2bfc*/ bool IsBasedOn(UnityEngine.InputSystem.Utilities.InternedString parentLayout, UnityEngine.InputSystem.Utilities.InternedString childLayout);
                    /*0x7ad2ca8*/ void AddMatcher(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);

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

                        /*0x7ad2bc8*/ <GetBaseLayouts>d__24(int <>1__state);
                        /*0x7ad2e8c*/ void System.IDisposable.Dispose();
                        /*0x7ad2e90*/ bool MoveNext();
                        /*0x7ad2f68*/ UnityEngine.InputSystem.Utilities.InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current();
                        /*0x7ad2f74*/ void System.Collections.IEnumerator.Reset();
                        /*0x7ad2fac*/ object System.Collections.IEnumerator.get_Current();
                        /*0x7ad3008*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator();
                        /*0x7ad30e4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class LayoutNotFoundException : System.Exception
                {
                    /*0x90*/ string <layout>k__BackingField;

                    /*0x7ad30f0*/ LayoutNotFoundException();
                    /*0x7ad3148*/ LayoutNotFoundException(string name, string message);
                    /*0x7ad2314*/ LayoutNotFoundException(string name);
                    /*0x7ad31c4*/ LayoutNotFoundException(string message, System.Exception innerException);
                    /*0x7ad3234*/ LayoutNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x7ad30e8*/ string get_layout();
                }

                struct Cache
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout> table;

                    /*0x7ad32b4*/ void Clear();
                    /*0x7ad272c*/ UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound);
                }

                struct CacheRefInstance : System.IDisposable
                {
                    /*0x10*/ bool valid;

                    /*0x7ad32c0*/ void Dispose();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Layouts.InputControlLayout.<> <>9;
                    static /*0x8*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__52_0;
                    static /*0x10*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__75_0;
                    static /*0x18*/ System.Func<string, UnityEngine.InputSystem.Utilities.InternedString> <>9__75_1;

                    static /*0x7ad3358*/ <>c();
                    /*0x7ad33c0*/ <>c();
                    /*0x7ad33c8*/ UnityEngine.InputSystem.Utilities.InternedString <FromType>b__52_0(string x);
                    /*0x7ad33f0*/ UnityEngine.InputSystem.Utilities.InternedString <CreateControlItemFromMember>b__75_0(string x);
                    /*0x7ad3418*/ UnityEngine.InputSystem.Utilities.InternedString <CreateControlItemFromMember>b__75_1(string x);
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

                /*0x7ad363c*/ InputControlLayoutAttribute();
                /*0x7ad3440*/ System.Type get_stateType();
                /*0x7ad3448*/ void set_stateType(System.Type value);
                /*0x7ad3450*/ string get_stateFormat();
                /*0x7ad3458*/ void set_stateFormat(string value);
                /*0x7ad3460*/ string[] get_commonUsages();
                /*0x7ad3468*/ void set_commonUsages(string[] value);
                /*0x7ad3470*/ string get_variants();
                /*0x7ad3478*/ void set_variants(string value);
                /*0x7ad3480*/ bool get_isNoisy();
                /*0x7ad3488*/ void set_isNoisy(bool value);
                /*0x7ad3494*/ bool get_canRunInBackground();
                /*0x7ad34dc*/ void set_canRunInBackground(bool value);
                /*0x7ad3544*/ bool get_updateBeforeRender();
                /*0x7ad358c*/ void set_updateBeforeRender(bool value);
                /*0x7ad35f4*/ bool get_isGenericTypeOfDevice();
                /*0x7ad35fc*/ void set_isGenericTypeOfDevice(bool value);
                /*0x7ad3608*/ string get_displayName();
                /*0x7ad3610*/ void set_displayName(string value);
                /*0x7ad3618*/ string get_description();
                /*0x7ad3620*/ void set_description(string value);
                /*0x7ad3628*/ bool get_hideInUI();
                /*0x7ad3630*/ void set_hideInUI(bool value);
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

                static /*0x7ad547c*/ void ApplyUseStateFrom(UnityEngine.InputSystem.InputControl parent, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, UnityEngine.InputSystem.Layouts.InputControlLayout layout);
                static /*0x7ad66c0*/ void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, int startIndex, UnityEngine.InputSystem.InputControl exceptControl);
                static /*0x7ad6958*/ void AddParentDisplayNameRecursive(UnityEngine.InputSystem.InputControl control, System.Text.StringBuilder stringBuilder, bool shortName);
                static /*0x7ad6174*/ void AddProcessors(UnityEngine.InputSystem.InputControl control, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, string layoutName);
                static /*0x7ad60c4*/ void SetFormat(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                static /*0x7ad3d60*/ UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(string name);
                static /*0x7ad4b38*/ void ComputeStateLayout(UnityEngine.InputSystem.InputControl control);
                static /*0x7ad794c*/ ref UnityEngine.InputSystem.Layouts.InputDeviceBuilder get_instance();
                static /*0x7ad7990*/ UnityEngine.InputSystem.Layouts.InputDeviceBuilder.RefInstance Ref();
                /*0x7ad3644*/ void Setup(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                /*0x7ad3a8c*/ UnityEngine.InputSystem.InputDevice Finish();
                /*0x7ad3d58*/ void Dispose();
                /*0x7ad3cd8*/ void Reset();
                /*0x7ad37b0*/ UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent);
                /*0x7ad3dbc*/ UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent);
                /*0x7ad4450*/ void AddChildControls(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls);
                /*0x7ad5814*/ UnityEngine.InputSystem.InputControl AddChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride);
                /*0x7ad5648*/ void InsertChildControlOverride(UnityEngine.InputSystem.InputControl parent, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                /*0x7ad6034*/ string ChildControlOverridePath(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Utilities.InternedString controlName);
                /*0x7ad5f84*/ void AddChildControlIfMissing(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                /*0x7ad63a0*/ UnityEngine.InputSystem.InputControl InsertChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variant, UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem);
                /*0x7ad6720*/ void SetDisplayName(UnityEngine.InputSystem.InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName);
                /*0x7ad381c*/ void FinalizeControlHierarchy();
                /*0x7ad6a08*/ void FinalizeControlHierarchyRecursive(UnityEngine.InputSystem.InputControl control, int controlIndex, UnityEngine.InputSystem.InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex);
                /*0x7ad6e18*/ void InsertControlBitRangeNode(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset);
                /*0x7ad7168*/ ushort GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset);
                /*0x7ad775c*/ void AddControlToNode(UnityEngine.InputSystem.InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex);
                /*0x7ad764c*/ void AddChildren(ref UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right);
                /*0x7ad789c*/ ushort GetControlIndex(UnityEngine.InputSystem.InputControl control);

                struct RefInstance : System.IDisposable
                {
                    /*0x79fd910*/ void Dispose();
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

                static /*0x79fdfb4*/ bool op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right);
                static /*0x79fdfec*/ bool op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right);
                static /*0x79fe140*/ UnityEngine.InputSystem.Layouts.InputDeviceDescription FromJson(string json);
                static /*0x79fe2cc*/ bool ComparePropertyToDeviceDescriptor(string propertyName, UnityEngine.InputSystem.Utilities.JsonParser.JsonString propertyValue, string deviceDescriptor);
                /*0x79fd99c*/ string get_interfaceName();
                /*0x79fd9a4*/ void set_interfaceName(string value);
                /*0x79fd9ac*/ string get_deviceClass();
                /*0x79fd9b4*/ void set_deviceClass(string value);
                /*0x79fd9bc*/ string get_manufacturer();
                /*0x79fd9c4*/ void set_manufacturer(string value);
                /*0x79fd9cc*/ string get_product();
                /*0x79fd9d4*/ void set_product(string value);
                /*0x79fd9dc*/ string get_serial();
                /*0x79fd9e4*/ void set_serial(string value);
                /*0x79fd9ec*/ string get_version();
                /*0x79fd9f4*/ void set_version(string value);
                /*0x79fd9fc*/ string get_capabilities();
                /*0x79fda04*/ void set_capabilities(string value);
                /*0x79fda0c*/ bool get_empty();
                /*0x79fda90*/ string ToString();
                /*0x79fdd3c*/ bool Equals(UnityEngine.InputSystem.Layouts.InputDeviceDescription other);
                /*0x79fddec*/ bool Equals(object obj);
                /*0x79fde84*/ int GetHashCode();
                /*0x79fe028*/ string ToJson();

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

                static /*0x79ffb5c*/ InputDeviceMatcher();
                static /*0x79ff370*/ bool MatchSingleProperty(object pattern, string value);
                static /*0x79ff43c*/ bool MatchSinglePropertyContains(object pattern, string value);
                static /*0x79ff4b0*/ int GetNumPropertiesIn(UnityEngine.InputSystem.Layouts.InputDeviceDescription description);
                static /*0x79ff574*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher FromDeviceDescription(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                static /*0x79ffa68*/ bool op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right);
                static /*0x79ffad4*/ bool op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right);
                /*0x79fea28*/ bool get_empty();
                /*0x79fea38*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> get_patterns();
                /*0x79feaec*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithInterface(string pattern, bool supportRegex);
                /*0x79fed6c*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex);
                /*0x79fede4*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex);
                /*0x79fee5c*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturerContains(string noRegExPattern);
                /*0x79feed0*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithProduct(string pattern, bool supportRegex);
                /*0x79fef48*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithVersion(string pattern, bool supportRegex);
                /*0x3907c14*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithCapability<TValue>(string path, TValue value);
                /*0x79feb64*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher With(UnityEngine.InputSystem.Utilities.InternedString key, object value, bool supportRegex);
                /*0x79fefc0*/ float MatchPercentage(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription);
                /*0x79ff6f4*/ string ToString();
                /*0x79ff89c*/ bool Equals(UnityEngine.InputSystem.Layouts.InputDeviceMatcher other);
                /*0x79ff9d8*/ bool Equals(object obj);
                /*0x79ffb44*/ int GetHashCode();

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

                    static /*0x79ffe24*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson FromMatcher(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher);
                    /*0x7a00198*/ UnityEngine.InputSystem.Layouts.InputDeviceMatcher ToMatcher();

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

                    static /*0x7a00630*/ <>c();
                    /*0x7a00698*/ <>c();
                    /*0x7a006a0*/ bool <With>b__12_0(char ch);
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

                    /*0x79feab8*/ <get_patterns>d__4(int <>1__state);
                    /*0x7a00708*/ void System.IDisposable.Dispose();
                    /*0x7a0070c*/ bool MoveNext();
                    /*0x7a0083c*/ System.Collections.Generic.KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current();
                    /*0x7a00848*/ void System.Collections.IEnumerator.Reset();
                    /*0x7a00880*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a008dc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
                    /*0x7a00984*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }
        }

        namespace Controls
        {
            class AnyKeyControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x7a00988*/ AnyKeyControl();
                /*0x7a00a88*/ float ReadUnprocessedValueFromState(void* statePtr);
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

                /*0x7a00bd0*/ AxisControl();
                /*0x7a00ab0*/ float Preprocess(float value);
                /*0x7a00b84*/ float Unpreprocess(float value);
                /*0x7a00c58*/ void FinishSetup();
                /*0x7a00d40*/ float ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a00ec0*/ void WriteValueIntoState(float value, void* statePtr);
                /*0x7a00fa0*/ bool CompareValue(void* firstStatePtr, void* secondStatePtr);
                /*0x7a0108c*/ float EvaluateMagnitude(void* statePtr);
                /*0x7a010ec*/ float EvaluateMagnitude(float value);
                /*0x7a011a0*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();

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

                /*0x7a009f8*/ ButtonControl();
                /*0x7a01310*/ bool get_needsToCheckFramePress();
                /*0x7a01318*/ void set_needsToCheckFramePress(bool value);
                /*0x7a01324*/ float get_pressPointOrDefault();
                /*0x7a01390*/ bool IsValueConsideredPressed(float value);
                /*0x7a013fc*/ bool get_isPressed();
                /*0x7a014b4*/ void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame);
                /*0x7a015b8*/ bool get_wasPressedThisFrame();
                /*0x7a01734*/ bool get_wasReleasedThisFrame();
                /*0x7a018b0*/ void UpdateWasPressed();
            }

            class DeltaControl : UnityEngine.InputSystem.Controls.Vector2Control
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.AxisControl <up>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.AxisControl <down>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.AxisControl <left>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.AxisControl <right>k__BackingField;

                /*0x7a01bdc*/ DeltaControl();
                /*0x7a01984*/ UnityEngine.InputSystem.Controls.AxisControl get_up();
                /*0x7a0198c*/ void set_up(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a0199c*/ UnityEngine.InputSystem.Controls.AxisControl get_down();
                /*0x7a019a4*/ void set_down(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a019b4*/ UnityEngine.InputSystem.Controls.AxisControl get_left();
                /*0x7a019bc*/ void set_left(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a019cc*/ UnityEngine.InputSystem.Controls.AxisControl get_right();
                /*0x7a019d4*/ void set_right(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a019e4*/ void FinishSetup();
            }

            class DiscreteButtonControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x140*/ int minValue;
                /*0x144*/ int maxValue;
                /*0x148*/ int wrapAtValue;
                /*0x14c*/ int nullValue;
                /*0x150*/ UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteMode writeMode;

                /*0x7a0203c*/ DiscreteButtonControl();
                /*0x7a01c68*/ void FinishSetup();
                /*0x7a01d64*/ float ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a01f08*/ void WriteValueIntoState(float value, void* statePtr);

                enum WriteMode
                {
                    WriteDisabled = 0,
                    WriteNullAndMaxValue = 1,
                }
            }

            class DoubleControl : UnityEngine.InputSystem.InputControl<double>
            {
                /*0x7a02040*/ DoubleControl();
                /*0x7a020c8*/ double ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a02130*/ void WriteValueIntoState(double value, void* statePtr);
            }

            class DpadControl : UnityEngine.InputSystem.Controls.Vector2Control
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField;

                static /*0x7a025d4*/ UnityEngine.Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize);
                static /*0x7a027dc*/ UnityEngine.Vector2 MakeDpadVector(float up, float down, float left, float right);
                /*0x7a02208*/ DpadControl();
                /*0x7a021a8*/ UnityEngine.InputSystem.Controls.ButtonControl get_up();
                /*0x7a021b0*/ void set_up(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a021c0*/ UnityEngine.InputSystem.Controls.ButtonControl get_down();
                /*0x7a021c8*/ void set_down(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a021d8*/ UnityEngine.InputSystem.Controls.ButtonControl get_left();
                /*0x7a021e0*/ void set_left(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a021f0*/ UnityEngine.InputSystem.Controls.ButtonControl get_right();
                /*0x7a021f8*/ void set_right(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a02278*/ void FinishSetup();
                /*0x7a0239c*/ UnityEngine.Vector2 ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a02630*/ void WriteValueIntoState(UnityEngine.Vector2 value, void* statePtr);

                class DpadAxisControl : UnityEngine.InputSystem.Controls.AxisControl
                {
                    /*0x12c*/ int <component>k__BackingField;

                    /*0x7a0296c*/ DpadAxisControl();
                    /*0x7a027ec*/ int get_component();
                    /*0x7a027f4*/ void set_component(int value);
                    /*0x7a027fc*/ void FinishSetup();
                    /*0x7a02880*/ float ReadUnprocessedValueFromState(void* statePtr);
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
                /*0x7a02970*/ IntegerControl();
                /*0x7a029f8*/ int ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a02a8c*/ void WriteValueIntoState(int value, void* statePtr);
                /*0x7a02b28*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class KeyControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x140*/ UnityEngine.InputSystem.Key <keyCode>k__BackingField;
                /*0x144*/ int m_ScanCode;

                /*0x7a02db4*/ KeyControl();
                /*0x7a02bfc*/ UnityEngine.InputSystem.Key get_keyCode();
                /*0x7a02c04*/ void set_keyCode(UnityEngine.InputSystem.Key value);
                /*0x7a02c0c*/ int get_scanCode();
                /*0x7a02c28*/ void RefreshConfiguration();
            }

            class QuaternionControl : UnityEngine.InputSystem.InputControl<UnityEngine.Quaternion>
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.AxisControl <w>k__BackingField;

                /*0x7a02e18*/ QuaternionControl();
                /*0x7a02db8*/ UnityEngine.InputSystem.Controls.AxisControl get_x();
                /*0x7a02dc0*/ void set_x(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a02dd0*/ UnityEngine.InputSystem.Controls.AxisControl get_y();
                /*0x7a02dd8*/ void set_y(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a02de8*/ UnityEngine.InputSystem.Controls.AxisControl get_z();
                /*0x7a02df0*/ void set_z(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a02e00*/ UnityEngine.InputSystem.Controls.AxisControl get_w();
                /*0x7a02e08*/ void set_w(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a02ea8*/ void FinishSetup();
                /*0x7a02fec*/ UnityEngine.Quaternion ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a03110*/ void WriteValueIntoState(UnityEngine.Quaternion value, void* statePtr);
                /*0x7a0323c*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class StickControl : UnityEngine.InputSystem.Controls.Vector2Control
            {
                /*0x120*/ UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField;
                /*0x130*/ UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField;
                /*0x138*/ UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField;

                /*0x7a035f0*/ StickControl();
                /*0x7a0346c*/ UnityEngine.InputSystem.Controls.ButtonControl get_up();
                /*0x7a03474*/ void set_up(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a03484*/ UnityEngine.InputSystem.Controls.ButtonControl get_down();
                /*0x7a0348c*/ void set_down(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a0349c*/ UnityEngine.InputSystem.Controls.ButtonControl get_left();
                /*0x7a034a4*/ void set_left(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a034b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_right();
                /*0x7a034bc*/ void set_right(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a034cc*/ void FinishSetup();
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

                /*0x7a037a0*/ TouchControl();
                /*0x7a035f4*/ UnityEngine.InputSystem.Controls.TouchPressControl get_press();
                /*0x7a035fc*/ void set_press(UnityEngine.InputSystem.Controls.TouchPressControl value);
                /*0x7a0360c*/ UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex();
                /*0x7a03614*/ void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a03624*/ UnityEngine.InputSystem.Controls.IntegerControl get_touchId();
                /*0x7a0362c*/ void set_touchId(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a0363c*/ UnityEngine.InputSystem.Controls.Vector2Control get_position();
                /*0x7a03644*/ void set_position(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x7a03654*/ UnityEngine.InputSystem.Controls.DeltaControl get_delta();
                /*0x7a0365c*/ void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value);
                /*0x7a0366c*/ UnityEngine.InputSystem.Controls.AxisControl get_pressure();
                /*0x7a03674*/ void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a03684*/ UnityEngine.InputSystem.Controls.Vector2Control get_radius();
                /*0x7a0368c*/ void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x7a0369c*/ UnityEngine.InputSystem.Controls.TouchPhaseControl get_phase();
                /*0x7a036a4*/ void set_phase(UnityEngine.InputSystem.Controls.TouchPhaseControl value);
                /*0x7a036b4*/ UnityEngine.InputSystem.Controls.ButtonControl get_indirectTouch();
                /*0x7a036bc*/ void set_indirectTouch(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a036cc*/ UnityEngine.InputSystem.Controls.ButtonControl get_tap();
                /*0x7a036d4*/ void set_tap(UnityEngine.InputSystem.Controls.ButtonControl value);
                /*0x7a036e4*/ UnityEngine.InputSystem.Controls.IntegerControl get_tapCount();
                /*0x7a036ec*/ void set_tapCount(UnityEngine.InputSystem.Controls.IntegerControl value);
                /*0x7a036fc*/ UnityEngine.InputSystem.Controls.DoubleControl get_startTime();
                /*0x7a03704*/ void set_startTime(UnityEngine.InputSystem.Controls.DoubleControl value);
                /*0x7a03714*/ UnityEngine.InputSystem.Controls.Vector2Control get_startPosition();
                /*0x7a0371c*/ void set_startPosition(UnityEngine.InputSystem.Controls.Vector2Control value);
                /*0x7a0372c*/ bool get_isInProgress();
                /*0x7a03844*/ void FinishSetup();
                /*0x7a03bf0*/ UnityEngine.InputSystem.LowLevel.TouchState ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a03c70*/ void WriteValueIntoState(UnityEngine.InputSystem.LowLevel.TouchState value, void* statePtr);
            }

            class TouchPhaseControl : UnityEngine.InputSystem.InputControl<UnityEngine.InputSystem.TouchPhase>
            {
                /*0x7a03cf0*/ TouchPhaseControl();
                /*0x7a03d78*/ UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a03df8*/ void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, void* statePtr);
            }

            class TouchPressControl : UnityEngine.InputSystem.Controls.ButtonControl
            {
                /*0x7a04244*/ TouchPressControl();
                /*0x7a03e60*/ void FinishSetup();
                /*0x7a03f5c*/ float ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a0420c*/ void WriteValueIntoState(float value, void* statePtr);
            }

            class Vector2Control : UnityEngine.InputSystem.InputControl<UnityEngine.Vector2>
            {
                /*0x110*/ UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;
                /*0x118*/ UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;

                /*0x7a01be0*/ Vector2Control();
                /*0x7a04248*/ UnityEngine.InputSystem.Controls.AxisControl get_x();
                /*0x7a04250*/ void set_x(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a04260*/ UnityEngine.InputSystem.Controls.AxisControl get_y();
                /*0x7a04268*/ void set_y(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a01b08*/ void FinishSetup();
                /*0x7a04278*/ UnityEngine.Vector2 ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a04344*/ void WriteValueIntoState(UnityEngine.Vector2 value, void* statePtr);
                /*0x7a04418*/ float EvaluateMagnitude(void* statePtr);
                /*0x7a044cc*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }

            class Vector3Control : UnityEngine.InputSystem.InputControl<UnityEngine.Vector3>
            {
                /*0x118*/ UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;
                /*0x120*/ UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;
                /*0x128*/ UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField;

                /*0x7a0465c*/ Vector3Control();
                /*0x7a04614*/ UnityEngine.InputSystem.Controls.AxisControl get_x();
                /*0x7a0461c*/ void set_x(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a0462c*/ UnityEngine.InputSystem.Controls.AxisControl get_y();
                /*0x7a04634*/ void set_y(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a04644*/ UnityEngine.InputSystem.Controls.AxisControl get_z();
                /*0x7a0464c*/ void set_z(UnityEngine.InputSystem.Controls.AxisControl value);
                /*0x7a046e4*/ void FinishSetup();
                /*0x7a047ec*/ UnityEngine.Vector3 ReadUnprocessedValueFromState(void* statePtr);
                /*0x7a048d8*/ void WriteValueIntoState(UnityEngine.Vector3 value, void* statePtr);
                /*0x7a049e0*/ float EvaluateMagnitude(void* statePtr);
                /*0x7a04aa8*/ UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType();
            }
        }

        namespace Interactions
        {
            class HoldInteraction : UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float duration;
                /*0x14*/ float pressPoint;
                /*0x18*/ double m_TimePressed;

                /*0x7a04ec4*/ HoldInteraction();
                /*0x7a04c50*/ float get_durationOrDefault();
                /*0x7a04cc0*/ float get_pressPointOrDefault();
                /*0x7a04d18*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a04ebc*/ void Reset();
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

                /*0x7a05318*/ MultiTapInteraction();
                /*0x7a04ecc*/ float get_tapTimeOrDefault();
                /*0x7a04f3c*/ float get_tapDelayOrDefault();
                /*0x7a04fac*/ float get_pressPointOrDefault();
                /*0x7a05004*/ float get_releasePointOrDefault();
                /*0x7a0508c*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a0530c*/ void Reset();

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

                /*0x7a057d4*/ PressInteraction();
                /*0x7a05328*/ float get_pressPointOrDefault();
                /*0x7a05380*/ float get_releasePointOrDefault();
                /*0x7a05408*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a057cc*/ void Reset();
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

                /*0x7a05a0c*/ SlowTapInteraction();
                /*0x7a057dc*/ float get_durationOrDefault();
                /*0x7a0584c*/ float get_pressPointOrDefault();
                /*0x7a058a4*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a05a04*/ void Reset();
            }

            class TapInteraction : UnityEngine.InputSystem.IInputInteraction
            {
                /*0x10*/ float duration;
                /*0x14*/ float pressPoint;
                /*0x18*/ double m_TapStartTime;

                /*0x7a05ccc*/ TapInteraction();
                /*0x7a05a14*/ float get_durationOrDefault();
                /*0x7a05a84*/ float get_pressPointOrDefault();
                /*0x7a05adc*/ float get_releasePointOrDefault();
                /*0x7a05b64*/ void Process(ref UnityEngine.InputSystem.InputInteractionContext context);
                /*0x7a05cc4*/ void Reset();
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

                /*0x7a05cec*/ InputActionTrace();
                /*0x7a05cf4*/ InputActionTrace(UnityEngine.InputSystem.InputAction action);
                /*0x7a05ea4*/ InputActionTrace(UnityEngine.InputSystem.InputActionMap actionMap);
                /*0x7a05cd4*/ UnityEngine.InputSystem.LowLevel.InputEventBuffer get_buffer();
                /*0x7a05ce4*/ int get_count();
                /*0x7a06034*/ void SubscribeToAll();
                /*0x7a063f0*/ void UnsubscribeFromAll();
                /*0x7a05d6c*/ void SubscribeTo(UnityEngine.InputSystem.InputAction action);
                /*0x7a05f1c*/ void SubscribeTo(UnityEngine.InputSystem.InputActionMap actionMap);
                /*0x7a061e0*/ void UnsubscribeFrom(UnityEngine.InputSystem.InputAction action);
                /*0x7a062f8*/ void UnsubscribeFrom(UnityEngine.InputSystem.InputActionMap actionMap);
                /*0x7a06534*/ void RecordAction(UnityEngine.InputSystem.InputAction.CallbackContext context);
                /*0x7a06704*/ void Clear();
                /*0x7a06758*/ void Finalize();
                /*0x7a06904*/ string ToString();
                /*0x7a0701c*/ void Dispose();
                /*0x7a067ec*/ void DisposeInternal();
                /*0x7a06c64*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator();
                /*0x7a07080*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7a06110*/ void HookOnActionChange();
                /*0x7a064c8*/ void UnhookOnActionChange();
                /*0x7a07084*/ void OnActionChange(object actionOrMapOrAsset, UnityEngine.InputSystem.InputActionChange change);
                /*0x7a07318*/ void CloneActionStateBeforeBindingsChange(UnityEngine.InputSystem.InputActionMap actionMap);

                struct ActionEventPtr
                {
                    /*0x10*/ UnityEngine.InputSystem.InputActionState m_State;
                    /*0x18*/ UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr;

                    /*0x7a07408*/ UnityEngine.InputSystem.InputAction get_action();
                    /*0x7a07430*/ UnityEngine.InputSystem.InputActionPhase get_phase();
                    /*0x7a0743c*/ UnityEngine.InputSystem.InputControl get_control();
                    /*0x7a0747c*/ UnityEngine.InputSystem.IInputInteraction get_interaction();
                    /*0x7a074d4*/ double get_time();
                    /*0x7a074f0*/ double get_startTime();
                    /*0x7a074fc*/ double get_duration();
                    /*0x7a0752c*/ int get_valueSizeInBytes();
                    /*0x7a07538*/ object ReadValueAsObject();
                    /*0x7a07764*/ void ReadValue(void* buffer, int bufferSize);
                    /*0x3907c14*/ TValue ReadValue<TValue>();
                    /*0x7a06ce0*/ string ToString();
                }

                struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.InputSystem.Utilities.InputActionTrace m_Trace;
                    /*0x18*/ UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer;
                    /*0x20*/ int m_EventCount;
                    /*0x28*/ UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent;
                    /*0x30*/ int m_CurrentIndex;

                    /*0x7a07034*/ Enumerator(UnityEngine.InputSystem.Utilities.InputActionTrace trace);
                    /*0x7a0785c*/ bool MoveNext();
                    /*0x7a078c0*/ void Reset();
                    /*0x7a078cc*/ void Dispose();
                    /*0x7a078d0*/ UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr get_Current();
                    /*0x7a07954*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class ArrayHelpers
            {
                static /*0x3824ba4*/ int LengthSafe<TValue>(TValue[] array);
                static /*0x3837da0*/ void Clear<TValue>(TValue[] array);
                static /*0x3839e58*/ void Clear<TValue>(TValue[] array, int count);
                static /*0x383af28*/ void Clear<TValue>(TValue[] array, ref int count);
                static /*0x3839fc0*/ void EnsureCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement);
                static /*0x3839fc0*/ void DuplicateWithCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement);
                static /*0x3907c14*/ bool Contains<TValue>(TValue[] array, TValue value);
                static /*0x3907c14*/ bool ContainsReference<TValue>(TValue[] array, TValue value);
                static /*0x3907c14*/ bool ContainsReference<TFirst, TSecond>(TFirst[] array, int count, TSecond value);
                static /*0x3907c14*/ bool ContainsReference<TFirst, TSecond>(TFirst[] array, int startIndex, int count, TSecond value);
                static bool HaveDuplicateReferences<TFirst>(TFirst[] first, int index, int count);
                static /*0x381ccdc*/ bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count);
                static /*0x3907c14*/ int IndexOf<TValue>(TValue[] array, TValue value, int startIndex, int count);
                static /*0x3827170*/ int IndexOf<TValue>(TValue[] array, System.Predicate<TValue> predicate);
                static /*0x38271a8*/ int IndexOf<TValue>(TValue[] array, System.Predicate<TValue> predicate, int startIndex, int count);
                static /*0x3907c14*/ int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int count);
                static /*0x3907c14*/ int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int startIndex, int count);
                static /*0x3907c14*/ int IndexOfValue<TValue>(TValue[] array, TValue value, int startIndex, int count);
                static /*0x3839f7c*/ void Resize<TValue>(ref Unity.Collections.NativeArray<TValue> array, int newSize, Unity.Collections.Allocator allocator);
                static /*0x3907c14*/ int Append<TValue>(ref TValue[] array, TValue value);
                static /*0x3827170*/ int Append<TValue>(ref TValue[] array, System.Collections.Generic.IEnumerable<TValue> values);
                static /*0x3827170*/ int AppendToImmutable<TValue>(ref TValue[] array, TValue[] values);
                static /*0x3907c14*/ int AppendWithCapacity<TValue>(ref TValue[] array, ref int count, TValue value, int capacityIncrement);
                static /*0x3907c14*/ int AppendListWithCapacity<TValue, TValues>(ref TValue[] array, ref int length, TValues values, int capacityIncrement);
                static /*0x3907c14*/ int AppendWithCapacity<TValue>(ref Unity.Collections.NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement, Unity.Collections.Allocator allocator);
                static /*0x3907c14*/ void InsertAt<TValue>(ref TValue[] array, int index, TValue value);
                static /*0x3907c14*/ void InsertAtWithCapacity<TValue>(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement);
                static /*0x383a19c*/ void PutAtIfNotSet<TValue>(ref TValue[] array, int index, System.Func<TValue> valueFn);
                static /*0x3826a14*/ int GrowBy<TValue>(ref TValue[] array, int count);
                static /*0x3826a54*/ int GrowBy<TValue>(ref Unity.Collections.NativeArray<TValue> array, int count, Unity.Collections.Allocator allocator);
                static /*0x38271a8*/ int GrowWithCapacity<TValue>(ref TValue[] array, ref int count, int growBy, int capacityIncrement);
                static int GrowWithCapacity<TValue>(ref Unity.Collections.NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement, Unity.Collections.Allocator allocator);
                static /*0x3907c14*/ TValue[] Join<TValue>(TValue value, TValue[] values);
                static /*0x3830700*/ TValue[] Merge<TValue>(TValue[] first, TValue[] second);
                static /*0x3830a9c*/ TValue[] Merge<TValue>(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer);
                static /*0x3839e58*/ void EraseAt<TValue>(ref TValue[] array, int index);
                static /*0x383b458*/ void EraseAtWithCapacity<TValue>(TValue[] array, ref int count, int index);
                static /*0x3907c14*/ void EraseAtWithCapacity<TValue>(Unity.Collections.NativeArray<TValue> array, ref int count, int index);
                static /*0x3907c14*/ bool Erase<TValue>(ref TValue[] array, TValue value);
                static /*0x383b458*/ void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index);
                static /*0x382eaf0*/ TValue[] Copy<TValue>(TValue[] array);
                static /*0x382eaf0*/ TValue[] Clone<TValue>(TValue[] array);
                static /*0x3830700*/ TNew[] Select<TOld, TNew>(TOld[] array, System.Func<TOld, TNew> converter);
                static /*0x383af28*/ void Swap<TValue>(ref TValue first, ref TValue second);
                static /*0x3839fc0*/ void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count);
                static /*0x383b540*/ void EraseSliceWithCapacity<TValue>(ref TValue[] array, ref int length, int index, int count);
                static /*0x3839f7c*/ void SwapElements<TValue>(TValue[] array, int index1, int index2);
                static /*0x3907c14*/ void SwapElements<TValue>(Unity.Collections.NativeArray<TValue> array, int index1, int index2);

                class <>c__DisplayClass33_0<TValue>
                {
                    /*0x0*/ TValue secondValue;

                    /*0x380cb08*/ <>c__DisplayClass33_0();
                    /*0x3907c14*/ bool <Merge>b__0(TValue x);
                }

                class <>c__DisplayClass34_0<TValue>
                {
                    /*0x0*/ System.Collections.Generic.IEqualityComparer<TValue> comparer;

                    /*0x380cb08*/ <>c__DisplayClass34_0();
                }

                class <>c__DisplayClass34_<TValue>
                {
                    /*0x0*/ TValue secondValue;
                    /*0x0*/ UnityEngine.InputSystem.Utilities.ArrayHelpers.<>c__DisplayClass34_0<TValue> CS$<>8__locals1;

                    /*0x380cb08*/ <>c__DisplayClass34_();
                    /*0x3907c14*/ bool <Merge>b__0(TValue x);
                }
            }

            struct CallbackArray<TDelegate>
            {
                /*0x0*/ bool m_CannotMutateCallbacksArray;
                /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_Callbacks;
                /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToAdd;
                /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToRemove;

                /*0x380b6a0*/ int get_length();
                /*0x3907c14*/ TDelegate get_Item(int index);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ void AddCallback(TDelegate dlg);
                /*0x3907c14*/ void RemoveCallback(TDelegate dlg);
                /*0x380cb08*/ void LockForChanges();
                /*0x380cb08*/ void UnlockForChanges();
            }

            struct Vector2MagnitudeComparer : System.Collections.Generic.IComparer<UnityEngine.Vector2>
            {
                /*0x7a079b8*/ int Compare(UnityEngine.Vector2 x, UnityEngine.Vector2 y);
            }

            struct Vector3MagnitudeComparer : System.Collections.Generic.IComparer<UnityEngine.Vector3>
            {
                /*0x7a079e8*/ int Compare(UnityEngine.Vector3 x, UnityEngine.Vector3 y);
            }

            class CSharpCodeHelpers
            {
                static /*0x7a07a28*/ bool IsProperIdentifier(string name);
                static /*0x7a07b18*/ bool IsEmptyOrProperIdentifier(string name);
                static /*0x7a07b44*/ bool IsEmptyOrProperNamespaceName(string name);
                static /*0x7a07c18*/ string MakeIdentifier(string name, string suffix);
                static /*0x7a07e50*/ string MakeTypeName(string name, string suffix);
            }

            class DelegateHelpers
            {
                static /*0x7a07f2c*/ void InvokeCallbacksSafe(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> callbacks, Unity.Profiling.ProfilerMarker marker, string callbackName, object context);
                static /*0x3907c14*/ void InvokeCallbacksSafe<TValue>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>> callbacks, TValue argument, string callbackName, object context);
                static /*0x3907c14*/ void InvokeCallbacksSafe<TValue1, TValue2>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, Unity.Profiling.ProfilerMarker marker, string callbackName, object context);
                static /*0x3907c14*/ bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context);
                static /*0x3907c14*/ void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue, System.Action>> callbacks, TValue argument, string callbackName, object context);
                static /*0x3907c14*/ bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context);
            }

            class DisplayStringFormatAttribute : System.Attribute
            {
                /*0x10*/ string <formatString>k__BackingField;

                /*0x7a081f8*/ DisplayStringFormatAttribute(string formatString);
                /*0x7a081e8*/ string get_formatString();
                /*0x7a081f0*/ void set_formatString(string value);
            }

            class ExceptionHelpers
            {
                static /*0x7a08228*/ bool IsExceptionIndicatingBugInCode(System.Exception exception);
            }

            struct FourCC : System.IEquatable<UnityEngine.InputSystem.Utilities.FourCC>
            {
                /*0x10*/ int m_Code;

                static /*0x7a08470*/ int op_Implicit(UnityEngine.InputSystem.Utilities.FourCC fourCC);
                static /*0x7a08474*/ UnityEngine.InputSystem.Utilities.FourCC op_Implicit(int i);
                static /*0x7a086e0*/ bool op_Equality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right);
                static /*0x7a086ec*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right);
                static /*0x7a086f8*/ UnityEngine.InputSystem.Utilities.FourCC FromInt32(int i);
                static /*0x7a08700*/ int ToInt32(UnityEngine.InputSystem.Utilities.FourCC fourCC);
                /*0x7a08300*/ FourCC(int code);
                /*0x7a03824*/ FourCC(char a, char b, char c, char d);
                /*0x7a08308*/ FourCC(string str);
                /*0x7a0847c*/ string ToString();
                /*0x7a08650*/ bool Equals(UnityEngine.InputSystem.Utilities.FourCC other);
                /*0x7a08660*/ bool Equals(object obj);
                /*0x7a086d8*/ int GetHashCode();
            }

            struct InlinedArray<TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
            {
                /*0x0*/ int length;
                /*0x0*/ TValue firstValue;
                /*0x0*/ TValue[] additionalValues;

                /*0x3907c14*/ InlinedArray(TValue value);
                /*0x3907c14*/ InlinedArray(TValue firstValue, TValue[] additionalValues);
                /*0x380d83c*/ InlinedArray(System.Collections.Generic.IEnumerable<TValue> values);
                /*0x380b6a0*/ int get_Capacity();
                /*0x3907c14*/ TValue get_Item(int index);
                /*0x3907c14*/ void set_Item(int index, TValue value);
                /*0x380cb08*/ void Clear();
                /*0x380cb08*/ void ClearWithCapacity();
                /*0x3907c14*/ UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone();
                /*0x380cffc*/ void SetLength(int size);
                /*0x380b9e8*/ TValue[] ToArray();
                /*0x380bb68*/ TOther[] ToArray<TOther>(System.Func<TValue, TOther> mapFunction);
                /*0x3907c14*/ int IndexOf(TValue value);
                /*0x3907c14*/ int Append(TValue value);
                /*0x3907c14*/ int AppendWithCapacity(TValue value, int capacityIncrement);
                /*0x3907c14*/ void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values);
                /*0x380d83c*/ void Append(System.Collections.Generic.IEnumerable<TValue> values);
                /*0x3907c14*/ void Remove(TValue value);
                /*0x380cffc*/ void RemoveAtWithCapacity(int index);
                /*0x380cffc*/ void RemoveAt(int index);
                /*0x380cffc*/ void RemoveAtByMovingTailWithCapacity(int index);
                /*0x3907c14*/ bool RemoveByMovingTailWithCapacity(TValue value);
                /*0x3907c14*/ bool Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer);
                /*0x3907c14*/ void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array;
                    /*0x0*/ int index;

                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x3907c14*/ TValue get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                }
            }

            class InputArrayExtensions
            {
                static /*0x3907c14*/ int IndexOfReference<TValue>(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value);
                static /*0x3907c14*/ bool Contains<TValue>(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value);
                static /*0x3907c14*/ bool ContainsReference<TValue>(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value);
            }

            struct InternedString : System.IEquatable<UnityEngine.InputSystem.Utilities.InternedString>, System.IComparable<UnityEngine.InputSystem.Utilities.InternedString>
            {
                /*0x10*/ string m_StringOriginalCase;
                /*0x18*/ string m_StringLowerCase;

                static /*0x79ff364*/ bool op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x79ff9cc*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a08878*/ bool op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, string b);
                static /*0x7a08910*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, string b);
                static /*0x7a089a8*/ bool op_Equality(string a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a08a3c*/ bool op_Inequality(string a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a08ad0*/ bool op_LessThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right);
                static /*0x7a08af4*/ bool op_GreaterThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right);
                static /*0x7a00178*/ string op_Implicit(UnityEngine.InputSystem.Utilities.InternedString str);
                /*0x79ffd50*/ InternedString(string text);
                /*0x7a08704*/ int get_length();
                /*0x7a0871c*/ bool IsEmpty();
                /*0x7a0872c*/ string ToLower();
                /*0x7a08734*/ bool Equals(object obj);
                /*0x7a0883c*/ bool Equals(UnityEngine.InputSystem.Utilities.InternedString other);
                /*0x7a0884c*/ int CompareTo(UnityEngine.InputSystem.Utilities.InternedString other);
                /*0x7a08860*/ int GetHashCode();
                /*0x79ff48c*/ string ToString();
            }

            struct JsonParser
            {
                /*0x10*/ string m_Text;
                /*0x18*/ int m_Length;
                /*0x1c*/ int m_Position;
                /*0x20*/ bool m_MatchAnyElementInArray;
                /*0x21*/ bool m_DryRun;

                /*0x79fe37c*/ JsonParser(string json);
                /*0x7a08b1c*/ void Reset();
                /*0x7a08b28*/ string ToString();
                /*0x79fe3fc*/ bool NavigateToProperty(string path);
                /*0x79fe8dc*/ bool CurrentPropertyHasValueEqualTo(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue expectedValue);
                /*0x7a08c08*/ bool ParseToken(char token);
                /*0x7a08d58*/ bool ParseValue();
                /*0x7a08d88*/ bool ParseValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a08ecc*/ bool ParseStringValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a09080*/ bool ParseArrayValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a09394*/ bool ParseObjectValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a09654*/ bool ParseNumber(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a09508*/ bool ParseBooleanValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a095f0*/ bool ParseNullValue(ref UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result);
                /*0x7a08cf8*/ bool SkipToValue();
                /*0x7a09b70*/ bool SkipString(string text);
                /*0x7a08c7c*/ void SkipWhitespace();
                /*0x7a09c44*/ bool get_isAtEnd();

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

                    static /*0x7a09fc0*/ bool op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right);
                    static /*0x7a09ff0*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right);
                    static /*0x7a0a024*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonString op_Implicit(string str);
                    /*0x7a09c54*/ string ToString();
                    /*0x7a09d50*/ bool Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonString other);
                    /*0x7a09ed8*/ bool Equals(object obj);
                    /*0x7a09f68*/ int GetHashCode();
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

                    static /*0x7a09c18*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(bool val);
                    static /*0x7a09b28*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(long val);
                    static /*0x7a09b50*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(double val);
                    static /*0x7a0a7bc*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(string str);
                    static /*0x79fe87c*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(UnityEngine.InputSystem.Utilities.JsonParser.JsonString str);
                    static /*0x7a09ad4*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array);
                    static /*0x7a0a83c*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.Dictionary<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj);
                    static /*0x7a0a88c*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Enum val);
                    static /*0x7a0aad8*/ bool Equals(object obj, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue value);
                    static /*0x7a08e98*/ bool op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right);
                    static /*0x7a0b628*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right);
                    /*0x7a0a06c*/ bool ToBoolean();
                    /*0x7a0a620*/ long ToInteger();
                    /*0x7a0a6f0*/ double ToDouble();
                    /*0x7a0a1ac*/ string ToString();
                    /*0x7a0a8dc*/ bool Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue other);
                    /*0x7a0b46c*/ bool Equals(object obj);
                    /*0x7a0b4fc*/ int GetHashCode();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Utilities.JsonParser.JsonValue.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue, string> <>9__11_0;
                        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>, string> <>9__11_1;

                        static /*0x7a0b660*/ <>c();
                        /*0x7a0b6c8*/ <>c();
                        /*0x7a0b6d0*/ string <ToString>b__11_0(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue x);
                        /*0x7a0b6d8*/ string <ToString>b__11_1(System.Collections.Generic.KeyValuePair<string, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> pair);
                    }
                }
            }

            class MemoryHelpers
            {
                static /*0x7a0b78c*/ bool Compare(void* ptr1, void* ptr2, UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion region);
                static /*0x7a0b934*/ uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits);
                static /*0x7a0b944*/ void WriteSingleBit(void* ptr, uint bitOffset, bool value);
                static /*0x7a0b7d0*/ bool ReadSingleBit(void* ptr, uint bitOffset);
                static /*0x7a0b974*/ void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount);
                static /*0x7a0b7ec*/ bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask);
                static /*0x7a0ba64*/ void MemSet(void* destination, int numBytes, byte value);
                static /*0x7a0bb00*/ void MemCpyMasked(void* destination, void* source, int numBytes, void* mask);
                static /*0x7a040a8*/ uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a0bb84*/ void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value);
                static /*0x7a01f04*/ int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a02038*/ void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value);
                static /*0x7a0bd30*/ int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a0bd54*/ void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value);
                static /*0x7a0bd68*/ float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount);
                static /*0x7a0bdb0*/ void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value);
                static /*0x7a0be00*/ void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value);
                static /*0x383af28*/ void Swap<TValue>(ref TValue a, ref TValue b);
                static /*0x7a0bfc4*/ uint AlignNatural(uint offset, uint sizeInBytes);

                struct BitRegion
                {
                    /*0x10*/ uint bitOffset;
                    /*0x14*/ uint sizeInBits;

                    /*0x7a0c058*/ BitRegion(uint bitOffset, uint sizeInBits);
                    /*0x7a0c060*/ BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits);
                    /*0x7a0c048*/ bool get_isEmpty();
                    /*0x7a0c06c*/ UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion Overlap(UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion other);
                }
            }

            class MiscHelpers
            {
                static /*0x3907c14*/ TValue GetValueOrDefault<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key);
                static /*0x3830278*/ System.Collections.Generic.IEnumerable<TValue> EveryNth<TValue>(System.Collections.Generic.IEnumerable<TValue> enumerable, int n, int start);
                static /*0x3907c14*/ int IndexOf<TValue>(System.Collections.Generic.IEnumerable<TValue> enumerable, TValue value);

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

                    /*0x380cffc*/ <EveryNth>d__(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void <>m__Finally1();
                    /*0x3907c14*/ TValue System.Collections.Generic.IEnumerator<TValue>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct NameAndParameters
            {
                /*0x10*/ string <name>k__BackingField;
                /*0x18*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField;

                static /*0x7a0c348*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text);
                static /*0x7a0c3f4*/ bool ParseMultiple(string text, ref System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters> list);
                static /*0x7a0c9ac*/ string ParseName(string text);
                static /*0x7a0ca28*/ UnityEngine.InputSystem.Utilities.NameAndParameters Parse(string text);
                static /*0x7a0c5dc*/ UnityEngine.InputSystem.Utilities.NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly);
                /*0x7a0c134*/ string get_name();
                /*0x7a0c13c*/ void set_name(string value);
                /*0x7a0c144*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters();
                /*0x7a0c150*/ void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value);
                /*0x7a0c160*/ string ToString();

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.NameAndParameters.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.NamedValue, string> <>9__8_0;

                    static /*0x7a0cc5c*/ <>c();
                    /*0x7a0ccc4*/ <>c();
                    /*0x7a0cccc*/ string <ToString>b__8_0(UnityEngine.InputSystem.Utilities.NamedValue x);
                }
            }

            struct NamedValue : System.IEquatable<UnityEngine.InputSystem.Utilities.NamedValue>
            {
                static string Separator = ",";
                /*0x10*/ string <name>k__BackingField;
                /*0x18*/ UnityEngine.InputSystem.Utilities.PrimitiveValue <value>k__BackingField;

                static /*0x3907c14*/ UnityEngine.InputSystem.Utilities.NamedValue From<TValue>(string name, TValue value);
                static /*0x7a0d1d8*/ bool op_Equality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right);
                static /*0x7a0d208*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right);
                static /*0x7a0cab4*/ UnityEngine.InputSystem.Utilities.NamedValue[] ParseMultiple(string parameterString);
                static /*0x7a0d5cc*/ UnityEngine.InputSystem.Utilities.NamedValue Parse(string str);
                static /*0x7a0d23c*/ UnityEngine.InputSystem.Utilities.NamedValue ParseParameter(string parameterString, ref int index);
                static /*0x3907c14*/ void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters);
                /*0x7a0cd68*/ string get_name();
                /*0x7a0cd70*/ void set_name(string value);
                /*0x7a0cd78*/ UnityEngine.InputSystem.Utilities.PrimitiveValue get_value();
                /*0x7a0cd84*/ void set_value(UnityEngine.InputSystem.Utilities.PrimitiveValue value);
                /*0x7a0cd8c*/ System.TypeCode get_type();
                /*0x7a0cd94*/ UnityEngine.InputSystem.Utilities.NamedValue ConvertTo(System.TypeCode type);
                /*0x7a0ccd4*/ string ToString();
                /*0x7a0cff8*/ bool Equals(UnityEngine.InputSystem.Utilities.NamedValue other);
                /*0x7a0d080*/ bool Equals(object obj);
                /*0x7a0d110*/ int GetHashCode();
                /*0x7a0d91c*/ void ApplyToObject(object instance);
            }

            class NumberHelpers
            {
                static /*0x7a0dcc4*/ int AlignToMultipleOf(int number, int alignment);
                static /*0x7a0dce0*/ long AlignToMultipleOf(long number, long alignment);
                static /*0x7a0dcfc*/ uint AlignToMultipleOf(uint number, uint alignment);
                static /*0x7a0dd18*/ bool Approximately(double a, double b);
                static /*0x7a0ddb4*/ float IntToNormalizedFloat(int value, int minValue, int maxValue);
                static /*0x7a0ddec*/ int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue);
                static /*0x7a0de3c*/ float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue);
                static /*0x7a0de74*/ uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue);
                static /*0x7a0debc*/ uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize);
            }

            class ForDeviceEventObservable : System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr>
            {
                /*0x10*/ System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source;
                /*0x18*/ UnityEngine.InputSystem.InputDevice m_Device;
                /*0x20*/ System.Type m_DeviceType;

                /*0x7a0df28*/ ForDeviceEventObservable(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device);
                /*0x7a0df88*/ System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer);

                class ForDevice : System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>
                {
                    /*0x10*/ System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer;
                    /*0x18*/ UnityEngine.InputSystem.InputDevice m_Device;
                    /*0x20*/ System.Type m_DeviceType;

                    /*0x7a0e074*/ ForDevice(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer);
                    /*0x7a0e0d4*/ void OnCompleted();
                    /*0x7a0e0d8*/ void OnError(System.Exception error);
                    /*0x7a0e130*/ void OnNext(UnityEngine.InputSystem.LowLevel.InputEventPtr value);
                }
            }

            class Observable
            {
                static /*0x3830700*/ System.IObservable<TValue> Where<TValue>(System.IObservable<TValue> source, System.Func<TValue, bool> predicate);
                static /*0x3830700*/ System.IObservable<TResult> Select<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, TResult> filter);
                static /*0x3830700*/ System.IObservable<TResult> SelectMany<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> filter);
                static /*0x38301ec*/ System.IObservable<TValue> Take<TValue>(System.IObservable<TValue> source, int count);
                static /*0x7a0e2a0*/ System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, UnityEngine.InputSystem.InputDevice device);
                static /*0x382eaf0*/ System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice<TDevice>(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source);
                static /*0x3830700*/ System.IDisposable CallOnce<TValue>(System.IObservable<TValue> source, System.Action<TValue> action);
                static /*0x3830700*/ System.IDisposable Call<TValue>(System.IObservable<TValue> source, System.Action<TValue> action);

                class <>c__DisplayClass6_0<TValue>
                {
                    /*0x0*/ System.IDisposable subscription;

                    /*0x380cb08*/ <>c__DisplayClass6_0();
                    /*0x380cb08*/ void <CallOnce>b__0();
                }
            }

            class Observer<TValue> : System.IObserver<TValue>
            {
                /*0x0*/ System.Action<TValue> m_OnNext;
                /*0x0*/ System.Action m_OnCompleted;

                /*0x380d93c*/ Observer(System.Action<TValue> onNext, System.Action onCompleted);
                /*0x380cb08*/ void OnCompleted();
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x3907c14*/ void OnNext(TValue evt);
            }

            class SelectManyObservable<TSource, TResult> : System.IObservable<TResult>
            {
                /*0x0*/ System.IObservable<TSource> m_Source;
                /*0x0*/ System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> m_Filter;

                /*0x380d93c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> filter);
                /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<TResult> observer);

                class Select<TSource, TResult> : System.IObserver<TSource>
                {
                    /*0x0*/ UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource, TResult> m_Observable;
                    /*0x0*/ System.IObserver<TResult> m_Observer;

                    /*0x380d93c*/ Select(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource, TResult> observable, System.IObserver<TResult> observer);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x3907c14*/ void OnNext(TSource evt);
                }
            }

            class TakeNObservable<TValue> : System.IObservable<TValue>
            {
                /*0x0*/ System.IObservable<TValue> m_Source;
                /*0x0*/ int m_Count;

                /*0x380d8b8*/ TakeNObservable(System.IObservable<TValue> source, int count);
                /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<TValue> observer);

                class Take<TValue> : System.IObserver<TValue>
                {
                    /*0x0*/ System.IObserver<TValue> m_Observer;
                    /*0x0*/ int m_Remaining;

                    /*0x380d93c*/ Take(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x3907c14*/ void OnNext(TValue evt);
                }
            }

            class WhereObservable<TValue> : System.IObservable<TValue>
            {
                /*0x0*/ System.IObservable<TValue> m_Source;
                /*0x0*/ System.Func<TValue, bool> m_Predicate;

                /*0x380d93c*/ WhereObservable(System.IObservable<TValue> source, System.Func<TValue, bool> predicate);
                /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<TValue> observer);

                class Where<TValue> : System.IObserver<TValue>
                {
                    /*0x0*/ UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable;
                    /*0x0*/ System.IObserver<TValue> m_Observer;

                    /*0x380d93c*/ Where(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x3907c14*/ void OnNext(TValue evt);
                }
            }

            struct OneOrMore<TValue, TList> : System.Collections.Generic.IReadOnlyList<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<TValue>
            {
                /*0x0*/ bool m_IsSingle;
                /*0x0*/ TValue m_Single;
                /*0x0*/ TList m_Multiple;

                static /*0x3907c14*/ UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> op_Implicit(TValue single);
                static /*0x3907c14*/ UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> op_Implicit(TList multiple);
                /*0x3907c14*/ OneOrMore(TValue single);
                /*0x3907c14*/ OneOrMore(TList multiple);
                /*0x380b6a0*/ int get_Count();
                /*0x3907c14*/ TValue get_Item(int index);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                class Enumerator<TValue, TList> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int m_Index;
                    /*0x0*/ UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> m_List;

                    /*0x380cb08*/ Enumerator();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x3907c14*/ TValue get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Dispose();
                }
            }

            struct PredictiveParser
            {
                /*0x10*/ int m_Position;

                /*0x7a0e350*/ void ExpectSingleChar(System.ReadOnlySpan<char> str, char c);
                /*0x7a0e448*/ int ExpectInt(System.ReadOnlySpan<char> str);
                /*0x7a0e56c*/ System.ReadOnlySpan<char> ExpectString(System.ReadOnlySpan<char> str);
                /*0x7a0e794*/ bool AcceptSingleChar(System.ReadOnlySpan<char> str, char c);
                /*0x7a0e7cc*/ bool AcceptString(System.ReadOnlySpan<char> input, ref System.ReadOnlySpan<char> output);
                /*0x7a0e8fc*/ void AcceptInt(System.ReadOnlySpan<char> str);
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

                static /*0x7a0d054*/ bool op_Equality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right);
                static /*0x7a0f438*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right);
                static /*0x7a0d620*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromString(string value);
                static /*0x3907c14*/ UnityEngine.InputSystem.Utilities.PrimitiveValue From<TValue>(TValue value);
                static /*0x7a0f024*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromObject(object value);
                static /*0x7a0d604*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(bool value);
                static /*0x7a0ebe0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(char value);
                static /*0x7a0ec04*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(byte value);
                static /*0x7a0ec28*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(sbyte value);
                static /*0x7a0ec4c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(short value);
                static /*0x7a0f98c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(ushort value);
                static /*0x7a0ec70*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(int value);
                static /*0x7a0f9a0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(uint value);
                static /*0x7a0ed24*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(long value);
                static /*0x7a0edd0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(ulong value);
                static /*0x7a0137c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(float value);
                static /*0x7a0ee90*/ UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(double value);
                static /*0x7a0f9b4*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromBoolean(bool value);
                static /*0x7a0f9d0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromChar(char value);
                static /*0x7a0f9e4*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromByte(byte value);
                static /*0x7a0f9f8*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromSByte(sbyte value);
                static /*0x7a0fa0c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt16(short value);
                static /*0x7a0fa20*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt16(ushort value);
                static /*0x7a0fa34*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt32(int value);
                static /*0x7a0fa48*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt32(uint value);
                static /*0x7a0fa5c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt64(long value);
                static /*0x7a0fa74*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt64(ulong value);
                static /*0x7a0fa8c*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromSingle(float value);
                static /*0x7a0faa0*/ UnityEngine.InputSystem.Utilities.PrimitiveValue FromDouble(double value);
                /*0x7a0e968*/ PrimitiveValue(bool value);
                /*0x7a0e980*/ PrimitiveValue(char value);
                /*0x7a0e994*/ PrimitiveValue(byte value);
                /*0x7a0e9a8*/ PrimitiveValue(sbyte value);
                /*0x7a0e9bc*/ PrimitiveValue(short value);
                /*0x7a0e9d0*/ PrimitiveValue(ushort value);
                /*0x7a0e9e4*/ PrimitiveValue(int value);
                /*0x7a0e9f4*/ PrimitiveValue(uint value);
                /*0x7a0ea04*/ PrimitiveValue(long value);
                /*0x7a0ea18*/ PrimitiveValue(ulong value);
                /*0x7a0ea2c*/ PrimitiveValue(float value);
                /*0x7a0ea40*/ PrimitiveValue(double value);
                /*0x7a0e958*/ byte* get_valuePtr();
                /*0x7a0e960*/ System.TypeCode get_type();
                /*0x7a0117c*/ bool get_isEmpty();
                /*0x7a0cdfc*/ UnityEngine.InputSystem.Utilities.PrimitiveValue ConvertTo(System.TypeCode type);
                /*0x7a0eea8*/ bool Equals(UnityEngine.InputSystem.Utilities.PrimitiveValue other);
                /*0x7a0eef4*/ bool Equals(object obj);
                /*0x7a0d198*/ int GetHashCode();
                /*0x7a0f468*/ string ToString();
                /*0x7a0f890*/ System.TypeCode GetTypeCode();
                /*0x7a0ea54*/ bool ToBoolean(System.IFormatProvider provider);
                /*0x7a0ebf4*/ byte ToByte(System.IFormatProvider provider);
                /*0x7a0eba8*/ char ToChar(System.IFormatProvider provider);
                /*0x7a0f898*/ System.DateTime ToDateTime(System.IFormatProvider provider);
                /*0x7a0f8e4*/ decimal ToDecimal(System.IFormatProvider provider);
                /*0x7a0ede8*/ double ToDouble(System.IFormatProvider provider);
                /*0x7a0ec3c*/ short ToInt16(System.IFormatProvider provider);
                /*0x7a0ec60*/ int ToInt32(System.IFormatProvider provider);
                /*0x7a0ec84*/ long ToInt64(System.IFormatProvider provider);
                /*0x7a0ec18*/ sbyte ToSByte(System.IFormatProvider provider);
                /*0x7a0118c*/ float ToSingle(System.IFormatProvider provider);
                /*0x7a0f930*/ string ToString(System.IFormatProvider provider);
                /*0x7a0f934*/ object ToType(System.Type conversionType, System.IFormatProvider provider);
                /*0x7a0f96c*/ ushort ToUInt16(System.IFormatProvider provider);
                /*0x7a0f97c*/ uint ToUInt32(System.IFormatProvider provider);
                /*0x7a0ed3c*/ ulong ToUInt64(System.IFormatProvider provider);
                /*0x7a0db7c*/ object ToObject();
            }

            struct ReadOnlyArray<TValue> : System.Collections.Generic.IReadOnlyList<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<TValue>
            {
                /*0x0*/ TValue[] m_Array;
                /*0x0*/ int m_StartIndex;
                /*0x0*/ int m_Length;

                static /*0x3907c14*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array);
                /*0x380d83c*/ ReadOnlyArray(TValue[] array);
                ReadOnlyArray(TValue[] array, int index, int length);
                /*0x380b9e8*/ TValue[] ToArray();
                /*0x380b7a8*/ int IndexOf(System.Predicate<TValue> predicate);
                /*0x3907c14*/ UnityEngine.InputSystem.Utilities.ReadOnlyArray.Enumerator<TValue> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380b6a0*/ int get_Count();
                /*0x3907c14*/ TValue get_Item(int index);

                struct Enumerator<TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ TValue[] m_Array;
                    /*0x0*/ int m_IndexStart;
                    /*0x0*/ int m_IndexEnd;
                    /*0x0*/ int m_Index;

                    Enumerator(TValue[] array, int index, int length);
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x3907c14*/ TValue get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class ReadOnlyArrayExtensions
            {
                static /*0x3907c14*/ bool Contains<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value);
                static /*0x3907c14*/ bool ContainsReference<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value);
                static /*0x3907c14*/ int IndexOfReference<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value);
                static /*0x3907c14*/ bool HaveEqualReferences<TValue>(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, System.Collections.Generic.IReadOnlyList<TValue> array2, int count);
            }

            interface ISavedState
            {
                /*0x380cb08*/ void StaticDisposeCurrentState();
                /*0x380cb08*/ void RestoreSavedState();
            }

            class SavedStructState<T> : UnityEngine.InputSystem.Utilities.ISavedState
            {
                /*0x0*/ T m_State;
                /*0x0*/ UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> m_RestoreAction;
                /*0x0*/ System.Action m_StaticDisposeCurrentState;

                /*0x380da4c*/ SavedStructState(ref T state, UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> restoreAction, System.Action staticDisposeCurrentState);
                /*0x380cb08*/ void StaticDisposeCurrentState();
                /*0x380cb08*/ void RestoreSavedState();

                class TypedRestore<T> : System.MulticastDelegate
                {
                    TypedRestore(object object, nint method);
                    /*0x380d83c*/ void Invoke(ref T state);
                    /*0x380bd40*/ System.IAsyncResult BeginInvoke(ref T state, System.AsyncCallback callback, object object);
                    /*0x380d93c*/ void EndInvoke(ref T state, System.IAsyncResult result);
                }
            }

            class SpriteUtilities
            {
                static /*0x7a0fab8*/ UnityEngine.Sprite CreateCircleSprite(int radius, UnityEngine.Color32 colour);
            }

            class StringHelpers
            {
                static /*0x7a0fca0*/ string Escape(string str, string chars, string replacements);
                static /*0x7a0fe14*/ string Unescape(string str, string chars, string replacements);
                static /*0x7a0ff80*/ bool Contains(string str, char ch);
                static /*0x7a0ffa0*/ bool Contains(string str, string text, System.StringComparison comparison);
                static /*0x7a0ffc0*/ string GetPlural(string str);
                static /*0x7a10164*/ string NicifyMemorySize(long numBytes);
                static /*0x7a102bc*/ bool FromNicifiedMemorySize(string text, ref long result, long defaultMultiplier);
                static /*0x7a1043c*/ int CountOccurrences(string str, char ch);
                static /*0x7a104ac*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(string str);
                static /*0x7a1055c*/ System.Collections.Generic.IEnumerable<string> Split(string str, System.Func<char, bool> predicate);
                static /*0x3830700*/ string Join<TValue>(string separator, TValue[] values);
                static /*0x3830700*/ string Join<TValue>(System.Collections.Generic.IEnumerable<TValue> values, string separator);
                static /*0x3830a9c*/ string MakeUniqueName<TExisting>(string baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting, string> getNameFunc);
                static /*0x7a10628*/ bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator);
                static /*0x7a1089c*/ int ParseInt(string str, int pos);
                static /*0x7a10928*/ bool WriteStringToBuffer(string text, nint buffer, int bufferSizeInCharacters);
                static /*0x7a10944*/ bool WriteStringToBuffer(string text, nint buffer, int bufferSizeInCharacters, ref uint offset);
                static /*0x7a10af0*/ string ReadStringFromBuffer(nint buffer, int bufferSize);
                static /*0x7a10b08*/ string ReadStringFromBuffer(nint buffer, int bufferSize, ref uint offset);
                static /*0x7a10c14*/ bool IsPrintable(char ch);
                static /*0x7a10c84*/ string WithAllWhitespaceStripped(string str);
                static /*0x7a10d6c*/ bool InvariantEqualsIgnoreCase(string left, string right);
                static /*0x7a10db8*/ string ExpandTemplateString(string template, System.Func<string, string> mapFunc);

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

                    /*0x7a105f4*/ <Split>d__9(int <>1__state);
                    /*0x7a10f84*/ void System.IDisposable.Dispose();
                    /*0x7a10f88*/ bool MoveNext();
                    /*0x7a110bc*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                    /*0x7a110c4*/ void System.Collections.IEnumerator.Reset();
                    /*0x7a110fc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a11104*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                    /*0x7a111b8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                    /*0x7a10528*/ <Tokenize>d__8(int <>1__state);
                    /*0x7a111bc*/ void System.IDisposable.Dispose();
                    /*0x7a111c0*/ bool MoveNext();
                    /*0x7a11470*/ UnityEngine.InputSystem.Utilities.Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current();
                    /*0x7a1147c*/ void System.Collections.IEnumerator.Reset();
                    /*0x7a114b4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7a11510*/ System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator();
                    /*0x7a115b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct Substring : System.IComparable<UnityEngine.InputSystem.Utilities.Substring>, System.IEquatable<UnityEngine.InputSystem.Utilities.Substring>
            {
                /*0x10*/ string m_String;
                /*0x18*/ int m_Index;
                /*0x1c*/ int m_Length;

                static /*0x7a11880*/ int Compare(UnityEngine.InputSystem.Utilities.Substring left, UnityEngine.InputSystem.Utilities.Substring right, System.StringComparison comparison);
                static /*0x7a119fc*/ bool op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a11a18*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a11a34*/ bool op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a11a60*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b);
                static /*0x7a11a90*/ bool op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a11ac0*/ bool op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b);
                static /*0x7a11af4*/ UnityEngine.InputSystem.Utilities.Substring op_Implicit(string s);
                /*0x7a115c8*/ Substring(string str);
                /*0x7a11444*/ Substring(string str, int index, int length);
                /*0x7a11604*/ Substring(string str, int index);
                /*0x7a115b8*/ bool get_isEmpty();
                /*0x7a11644*/ bool Equals(object obj);
                /*0x7a1171c*/ bool Equals(string other);
                /*0x7a116ec*/ bool Equals(UnityEngine.InputSystem.Utilities.Substring other);
                /*0x7a11800*/ bool Equals(UnityEngine.InputSystem.Utilities.InternedString other);
                /*0x7a117e4*/ int CompareTo(UnityEngine.InputSystem.Utilities.Substring other);
                /*0x7a118a8*/ bool StartsWith(string str);
                /*0x7a11948*/ string Substr(int index, int length);
                /*0x7a1197c*/ string ToString();
                /*0x7a119ac*/ int GetHashCode();
                /*0x7a11b38*/ int get_length();
                /*0x7a11b40*/ int get_index();
                /*0x7a11b48*/ char get_Item(int index);
            }

            class TypeHelpers
            {
                static /*0x3907c14*/ TObject As<TObject>(object obj);
                static /*0x7a11bc8*/ bool IsInt(System.TypeCode type);
                static /*0x7a11bd8*/ System.Type GetValueType(System.Reflection.MemberInfo member);
                static /*0x7a11da4*/ string GetNiceTypeName(System.Type type);
                static /*0x7a12178*/ System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, int argumentIndex);
            }

            struct TypeTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString, System.Type> table;

                /*0x7a12508*/ System.Collections.Generic.IEnumerable<string> get_names();
                /*0x7a12634*/ System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames();
                /*0x7a12684*/ void Initialize();
                /*0x7a12700*/ UnityEngine.InputSystem.Utilities.InternedString FindNameForType(System.Type type);
                /*0x7a12910*/ void AddTypeRegistration(string name, System.Type type);
                /*0x7a12a64*/ System.Type LookupTypeRegistration(string name);

                class <>c
                {
                    static /*0x0*/ UnityEngine.InputSystem.Utilities.TypeTable.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Utilities.InternedString, string> <>9__2_0;

                    static /*0x7a12b58*/ <>c();
                    /*0x7a12bc0*/ <>c();
                    /*0x7a12bc8*/ string <get_names>b__2_0(UnityEngine.InputSystem.Utilities.InternedString x);
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

                /*0x7a12d6c*/ AxisComposite();
                /*0x7a12bec*/ float get_midPoint();
                /*0x7a12c00*/ float ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a12d20*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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

                /*0x7a12f4c*/ ButtonWithOneModifier();
                /*0x7a12dc0*/ float ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a12e30*/ bool ModifierIsPressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a12eb4*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a12ec0*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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

                /*0x7a13154*/ ButtonWithTwoModifiers();
                /*0x7a12f94*/ float ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13004*/ bool ModifiersArePressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a130bc*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a130c8*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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

                static /*0x7a13384*/ void DetermineValueTypeAndSize(ref UnityEngine.InputSystem.InputBindingCompositeContext context, int part, ref System.Type valueType, ref int valueSizeInBytes, ref bool isButton);
                /*0x7a138b0*/ OneModifierComposite();
                /*0x7a1319c*/ System.Type get_valueType();
                /*0x7a131a4*/ int get_valueSizeInBytes();
                /*0x7a131ac*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13278*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
                /*0x7a131ec*/ bool ModifierIsPressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a132dc*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13860*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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

                /*0x7a13b38*/ TwoModifiersComposite();
                /*0x7a138b8*/ System.Type get_valueType();
                /*0x7a138c0*/ int get_valueSizeInBytes();
                /*0x7a138c8*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a139c8*/ void ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
                /*0x7a13908*/ bool ModifiersArePressed(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13a2c*/ void FinishSetup(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13ad4*/ object ReadValueAsObject(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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

                /*0x7a13d14*/ Vector2Composite();
                /*0x7a13b40*/ UnityEngine.Vector2 ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13ca4*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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

                /*0x7a1403c*/ Vector3Composite();
                /*0x7a13d64*/ UnityEngine.Vector3 ReadValue(ref UnityEngine.InputSystem.InputBindingCompositeContext context);
                /*0x7a13fb8*/ float EvaluateMagnitude(ref UnityEngine.InputSystem.InputBindingCompositeContext context);

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
