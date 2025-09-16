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

        /*0x7f005d8*/ int get_fingerId();
        /*0x7f005e0*/ UnityEngine.Vector2 get_position();
        /*0x7f005e8*/ void set_position(UnityEngine.Vector2 value);
        /*0x7f005f0*/ UnityEngine.Vector2 get_rawPosition();
        /*0x7f005f8*/ void set_rawPosition(UnityEngine.Vector2 value);
        /*0x7f00600*/ UnityEngine.Vector2 get_deltaPosition();
        /*0x7f00608*/ void set_deltaPosition(UnityEngine.Vector2 value);
        /*0x7f00610*/ float get_deltaTime();
        /*0x7f00618*/ int get_tapCount();
        /*0x7f00620*/ UnityEngine.TouchPhase get_phase();
        /*0x7f00628*/ float get_pressure();
        /*0x7f00630*/ float get_maximumPossiblePressure();
        /*0x7f00638*/ UnityEngine.TouchType get_type();
        /*0x7f00640*/ float get_altitudeAngle();
        /*0x7f00648*/ float get_azimuthAngle();
        /*0x7f00650*/ float get_radius();
        /*0x7f00658*/ float get_radiusVariance();
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

    enum DeviceOrientation
    {
        Unknown = 0,
        Portrait = 1,
        PortraitUpsideDown = 2,
        LandscapeLeft = 3,
        LandscapeRight = 4,
        FaceUp = 5,
        FaceDown = 6,
    }

    class CameraRaycastHelper
    {
        static /*0x7f00660*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7f0078c*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7f00728*/ nint RaycastTry_Injected(nint cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7f00854*/ nint RaycastTry2D_Injected(nint cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x0*/ bool <simulateTouchEnabled>k__BackingField;

        static /*0x7f008b8*/ float GetAxis(string axisName);
        static /*0x7f00a28*/ float GetAxisRaw(string axisName);
        static /*0x7f00b98*/ bool GetButtonDown(string buttonName);
        static /*0x7f00d10*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x7f00d4c*/ bool GetMouseButton(int button);
        static /*0x7f00d88*/ bool GetMouseButtonDown(int button);
        static /*0x7f00dc4*/ bool GetMouseButtonUp(int button);
        static /*0x7f00e00*/ UnityEngine.Touch GetTouch(int index);
        static /*0x7f00eb4*/ UnityEngine.PenData GetLastPenContactEvent();
        static /*0x7f00f54*/ void ClearLastPenContactEvent();
        static /*0x7f00f7c*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x7f00fb8*/ bool get_anyKey();
        static /*0x7f00fe0*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x7f01068*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x7f010e8*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x7f01110*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x7f0114c*/ string get_compositionString();
        static /*0x7f0123c*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x7f012bc*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x7f01338*/ bool get_simulateTouchEnabled();
        static /*0x7f01380*/ bool GetMousePresentInternal();
        static /*0x7f013a8*/ bool GetTouchSupportedInternal();
        static /*0x7f013d0*/ bool get_mousePresent();
        static /*0x7f0143c*/ bool get_touchSupported();
        static /*0x7f014a8*/ int get_touchCount();
        static /*0x7f014d0*/ UnityEngine.Touch[] get_touches();
        static /*0x7f01610*/ bool CheckDisabled();
        static /*0x7f00e70*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x7f00f18*/ void GetLastPenContactEvent_Injected(ref UnityEngine.PenData ret);
        static /*0x7f0102c*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x7f010ac*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x7f01200*/ void get_compositionString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7f01280*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x7f012fc*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
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

        static /*0x7f0275c*/ SendMouseEvents();
        static /*0x7f01638*/ void UpdateMouse();
        static /*0x7f017fc*/ void SetMouseMoved();
        static /*0x7f01858*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x7f021b0*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x7f025e4*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x7f026a8*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0x7f02684*/ void SendMessage(string name);
        }
    }

    namespace Internal
    {
        class InputUnsafeUtility
        {
            static /*0x7f02820*/ bool GetKeyString__Unmanaged(byte* name, int nameLen);
            static /*0x7f02864*/ bool GetKeyUpString__Unmanaged(byte* name, int nameLen);
            static /*0x7f028a8*/ bool GetKeyDownString__Unmanaged(byte* name, int nameLen);
            static /*0x7f008bc*/ float GetAxis(string axisName);
            static /*0x7f02928*/ float GetAxis__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x7f00a2c*/ float GetAxisRaw(string axisName);
            static /*0x7f029a8*/ float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x7f029ec*/ bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x7f00b9c*/ bool GetButtonDown(string buttonName);
            static /*0x7f02a6c*/ byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x7f02ab0*/ bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x7f028ec*/ float GetAxis_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper axisName);
            static /*0x7f0296c*/ float GetAxisRaw_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper axisName);
            static /*0x7f02a30*/ bool GetButtonDown_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper buttonName);
        }
    }
}
