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

        /*0x15d3b80*/ int get_fingerId();
        /*0x1644ef0*/ UnityEngine.Vector2 get_position();
        /*0xfbbe60*/ void set_position(UnityEngine.Vector2 value);
        /*0x1644f30*/ UnityEngine.Vector2 get_rawPosition();
        /*0x1644f60*/ void set_rawPosition(UnityEngine.Vector2 value);
        /*0x8c1de0*/ UnityEngine.Vector2 get_deltaPosition();
        /*0x1644f50*/ void set_deltaPosition(UnityEngine.Vector2 value);
        /*0x1644ec0*/ float get_deltaTime();
        /*0xca7c70*/ int get_tapCount();
        /*0x1644ee0*/ UnityEngine.TouchPhase get_phase();
        /*0x1644f10*/ float get_pressure();
        /*0x1644ed0*/ float get_maximumPossiblePressure();
        /*0xca7c90*/ UnityEngine.TouchType get_type();
        /*0x1441630*/ float get_altitudeAngle();
        /*0x1644eb0*/ float get_azimuthAngle();
        /*0x1644f20*/ float get_radius();
        /*0x14417b0*/ float get_radiusVariance();
    }

    enum PenStatus
    {
        None = 0,
        Contact = 1,
        Barrel = 2,
        Inverted = 4,
        Eraser = 8,
    }

    enum PenEventType
    {
        NoContact = 0,
        PenDown = 1,
        PenUp = 2,
    }

    struct PenData
    {
        /*0x10*/ UnityEngine.Vector2 position;
        /*0x18*/ UnityEngine.Vector2 tilt;
        /*0x20*/ UnityEngine.PenStatus penStatus;
        /*0x24*/ float twist;
        /*0x28*/ float pressure;
        /*0x2c*/ UnityEngine.PenEventType contactType;
        /*0x30*/ UnityEngine.Vector2 deltaPos;
    }

    class CameraRaycastHelper
    {
        static /*0x1642960*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x1642880*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x16428f0*/ UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x1642810*/ UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x1642bd0*/ float GetAxis(string axisName);
        static /*0x1642b50*/ float GetAxisRaw(string axisName);
        static /*0x1642d50*/ bool GetButton(string buttonName);
        static /*0x1642c50*/ bool GetButtonDown(string buttonName);
        static /*0x1642cd0*/ bool GetButtonUp(string buttonName);
        static /*0x1642ef0*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x1642f30*/ bool GetKeyUpInt(UnityEngine.KeyCode key);
        static /*0x1642eb0*/ bool GetKeyDownInt(UnityEngine.KeyCode key);
        static /*0x1643080*/ bool GetMouseButton(int button);
        static /*0x1643000*/ bool GetMouseButtonDown(int button);
        static /*0x1643040*/ bool GetMouseButtonUp(int button);
        static /*0x1643100*/ UnityEngine.Touch GetTouch(int index);
        static /*0x1642fb0*/ UnityEngine.PenData GetLastPenContactEvent();
        static /*0x1642e80*/ void ClearLastPenContactEvent();
        static /*0x1642ef0*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x1642f30*/ bool GetKeyUp(UnityEngine.KeyCode key);
        static /*0x1642eb0*/ bool GetKeyDown(UnityEngine.KeyCode key);
        static /*0x1643160*/ bool get_anyKey();
        static /*0x16432b0*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x1643360*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x1643240*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x16435d0*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x1643210*/ string get_compositionString();
        static /*0x16431d0*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x1643590*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x16432f0*/ bool get_mousePresent();
        static /*0x16433a0*/ int get_touchCount();
        static /*0x16433d0*/ bool get_touchSupported();
        static /*0x1643400*/ UnityEngine.Touch[] get_touches();
        static /*0x1642e50*/ bool CheckDisabled();
        static /*0x16430c0*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x1642f70*/ void GetLastPenContactEvent_Injected(ref UnityEngine.PenData ret);
        static /*0x1643270*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x1643320*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x1643190*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x1643550*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
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

        static /*0x1644db0*/ SendMouseEvents();
        static /*0x1644b40*/ void UpdateMouse();
        static /*0x1644af0*/ void SetMouseMoved();
        static /*0x1643610*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x1644150*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x1642a90*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x16429d0*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0x1642a60*/ void SendMessage(string name);
        }
    }

    namespace Internal
    {
        class InputUnsafeUtility
        {
            static /*0x1642dd0*/ bool GetKeyString__Unmanaged(byte* name, int nameLen);
            static /*0x1642e10*/ bool GetKeyUpString__Unmanaged(byte* name, int nameLen);
            static /*0x1642d90*/ bool GetKeyDownString__Unmanaged(byte* name, int nameLen);
            static /*0x1642bd0*/ float GetAxis(string axisName);
            static /*0x1642b90*/ float GetAxis__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x1642b50*/ float GetAxisRaw(string axisName);
            static /*0x1642b10*/ float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x1642d50*/ bool GetButton(string buttonName);
            static /*0x1642d10*/ bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x1642c50*/ bool GetButtonDown(string buttonName);
            static /*0x1642c10*/ byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x1642cd0*/ bool GetButtonUp(string buttonName);
            static /*0x1642c90*/ bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen);
        }
    }
}
