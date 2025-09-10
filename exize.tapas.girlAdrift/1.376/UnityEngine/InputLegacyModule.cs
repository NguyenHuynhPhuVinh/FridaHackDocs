class <Module>
{
}

namespace UnityEngine
{
    enum TouchPhase
    {
        Began = 0,
        Moved = 1,
        Stationary = 2,
        Ended = 3,
        Canceled = 4,
    }

    enum IMECompositionMode
    {
        Auto = 0,
        On = 1,
        Off = 2,
    }

    enum TouchType
    {
        Direct = 0,
        Indirect = 1,
        Stylus = 2,
    }

    struct Touch
    {
        /*0x10*/ int m_FingerId;
        /*0x14*/ UnityEngine.Vector2 m_Position;
        /*0x1c*/ UnityEngine.Vector2 m_RawPosition;
        /*0x24*/ UnityEngine.Vector2 m_PositionDelta;
        /*0x2c*/ float m_TimeDelta;
        /*0x30*/ int m_TapCount;
        /*0x34*/ UnityEngine.TouchPhase m_Phase;
        /*0x38*/ UnityEngine.TouchType m_Type;
        /*0x3c*/ float m_Pressure;
        /*0x40*/ float m_maximumPossiblePressure;
        /*0x44*/ float m_Radius;
        /*0x48*/ float m_RadiusVariance;
        /*0x4c*/ float m_AltitudeAngle;
        /*0x50*/ float m_AzimuthAngle;

        /*0x12d33e8*/ int get_fingerId();
        /*0x12d33f0*/ UnityEngine.Vector2 get_position();
        /*0x12d33f8*/ void set_position(UnityEngine.Vector2 value);
        /*0x12d3400*/ UnityEngine.Vector2 get_rawPosition();
        /*0x12d3408*/ void set_rawPosition(UnityEngine.Vector2 value);
        /*0x12d3410*/ UnityEngine.Vector2 get_deltaPosition();
        /*0x12d3418*/ void set_deltaPosition(UnityEngine.Vector2 value);
        /*0x12d3420*/ float get_deltaTime();
        /*0x12d3428*/ int get_tapCount();
        /*0x12d3430*/ UnityEngine.TouchPhase get_phase();
        /*0x12d3438*/ float get_pressure();
        /*0x12d3440*/ float get_maximumPossiblePressure();
        /*0x12d3448*/ UnityEngine.TouchType get_type();
        /*0x12d3450*/ float get_altitudeAngle();
        /*0x12d3458*/ float get_azimuthAngle();
        /*0x12d3460*/ float get_radius();
        /*0x12d3468*/ float get_radiusVariance();
    }

    class CameraRaycastHelper
    {
        static /*0x12d3470*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x12d3538*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x12d34d4*/ UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x12d359c*/ UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x12d3600*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x12d363c*/ bool GetKeyDownInt(UnityEngine.KeyCode key);
        static /*0x12d3678*/ float GetAxis(string axisName);
        static /*0x12d36b4*/ float GetAxisRaw(string axisName);
        static /*0x12d36f0*/ bool GetButtonDown(string buttonName);
        static /*0x12d372c*/ bool GetMouseButton(int button);
        static /*0x12d3768*/ bool GetMouseButtonDown(int button);
        static /*0x12d37a4*/ bool GetMouseButtonUp(int button);
        static /*0x12d37e0*/ void ResetInputAxes();
        static /*0x12d3808*/ UnityEngine.Touch GetTouch(int index);
        static /*0x12d38bc*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x12d38f8*/ bool GetKeyDown(UnityEngine.KeyCode key);
        static /*0x12d3934*/ void set_simulateMouseWithTouches(bool value);
        static /*0x12d3970*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x12d39f8*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x12d3a78*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x12d3aa0*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x12d3adc*/ string get_compositionString();
        static /*0x12d3b04*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x12d3b84*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x12d3c00*/ bool get_mousePresent();
        static /*0x12d3c28*/ int get_touchCount();
        static /*0x12d3c50*/ bool get_touchSupported();
        static /*0x12d3c78*/ UnityEngine.Touch[] get_touches();
        static /*0x12d3db8*/ bool CheckDisabled();
        static /*0x12d3878*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x12d39bc*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x12d3a3c*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x12d3b48*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x12d3bc4*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class SendMouseEvents
    {
        static /*0x0*/ bool s_MouseUsed;
        static /*0x8*/ UnityEngine.SendMouseEvents.HitInfo[] m_LastHit;
        static /*0x10*/ UnityEngine.SendMouseEvents.HitInfo[] m_MouseDownHit;
        static /*0x18*/ UnityEngine.SendMouseEvents.HitInfo[] m_CurrentHit;
        static /*0x20*/ UnityEngine.Camera[] m_Cameras;
        static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<int, UnityEngine.Vector2>> s_GetMouseState;
        static /*0x30*/ UnityEngine.Vector2 s_MousePosition;
        static /*0x38*/ bool s_MouseButtonPressedThisFrame;
        static /*0x39*/ bool s_MouseButtonIsPressed;

        static /*0x12d4ee4*/ SendMouseEvents();
        static /*0x12d3de0*/ void UpdateMouse();
        static /*0x12d3fa4*/ void SetMouseMoved();
        static /*0x12d4000*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x12d494c*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x12d4d6c*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x12d4e30*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0x12d4e0c*/ void SendMessage(string name);
        }
    }
}
