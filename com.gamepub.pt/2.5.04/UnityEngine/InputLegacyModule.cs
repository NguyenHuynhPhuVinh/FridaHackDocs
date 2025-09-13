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

        /*0xb587c8*/ int get_fingerId();
        /*0xb587d0*/ UnityEngine.Vector2 get_position();
        /*0xb587d8*/ UnityEngine.Vector2 get_deltaPosition();
        /*0xb587e0*/ UnityEngine.TouchPhase get_phase();
        /*0xb587e8*/ UnityEngine.TouchType get_type();
    }

    class CameraRaycastHelper
    {
        static /*0x2b27abc*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x2b27b8c*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x2b27b24*/ UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x2b27bf4*/ UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x2b27c5c*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x2b27c9c*/ bool GetKeyUpInt(UnityEngine.KeyCode key);
        static /*0x2b27cdc*/ bool GetKeyDownInt(UnityEngine.KeyCode key);
        static /*0x2b27d1c*/ float GetAxisRaw(string axisName);
        static /*0x2b27d5c*/ bool GetButtonDown(string buttonName);
        static /*0x2b27d9c*/ bool GetButtonUp(string buttonName);
        static /*0x2b27ddc*/ bool GetMouseButton(int button);
        static /*0x2b27e1c*/ bool GetMouseButtonDown(int button);
        static /*0x2b27e5c*/ bool GetMouseButtonUp(int button);
        static /*0x2b27e9c*/ UnityEngine.Touch GetTouch(int index);
        static /*0x2b27f68*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x2b27fa8*/ bool GetKeyUp(UnityEngine.KeyCode key);
        static /*0x2b27fe8*/ bool GetKeyDown(UnityEngine.KeyCode key);
        static /*0x2b28028*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x2b280c0*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x2b28148*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x2b2817c*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x2b281bc*/ string get_compositionString();
        static /*0x2b281f0*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x2b28278*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x2b282fc*/ bool get_mousePresent();
        static /*0x2b28330*/ int get_touchCount();
        static /*0x2b28364*/ bool get_touchSupported();
        static /*0x2b28398*/ void set_multiTouchEnabled(bool value);
        static /*0x2b283d8*/ UnityEngine.Touch[] get_touches();
        static /*0x2b27f18*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x2b28080*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x2b28108*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x2b28238*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x2b282bc*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class SendMouseEvents
    {
        static /*0x0*/ bool s_MouseUsed;
        static /*0x8*/ UnityEngine.SendMouseEvents.HitInfo[] m_LastHit;
        static /*0x10*/ UnityEngine.SendMouseEvents.HitInfo[] m_MouseDownHit;
        static /*0x18*/ UnityEngine.SendMouseEvents.HitInfo[] m_CurrentHit;
        static /*0x20*/ UnityEngine.Camera[] m_Cameras;

        static /*0x2b295c8*/ SendMouseEvents();
        static /*0x2b2852c*/ void SetMouseMoved();
        static /*0x2b28594*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x2b28f24*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x2b29428*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x2b29500*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0xb5882c*/ void SendMessage(string name);
        }
    }
}
