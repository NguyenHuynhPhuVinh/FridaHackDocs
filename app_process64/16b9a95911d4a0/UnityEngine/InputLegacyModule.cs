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

        /*0x3e680f0*/ int get_fingerId();
        /*0x3e680f8*/ UnityEngine.Vector2 get_position();
        /*0x3e68100*/ void set_position(UnityEngine.Vector2 value);
        /*0x3e68108*/ UnityEngine.Vector2 get_rawPosition();
        /*0x3e68110*/ void set_rawPosition(UnityEngine.Vector2 value);
        /*0x3e68118*/ UnityEngine.Vector2 get_deltaPosition();
        /*0x3e68120*/ void set_deltaPosition(UnityEngine.Vector2 value);
        /*0x3e68128*/ float get_deltaTime();
        /*0x3e68130*/ int get_tapCount();
        /*0x3e68138*/ UnityEngine.TouchPhase get_phase();
        /*0x3e68140*/ float get_pressure();
        /*0x3e68148*/ float get_maximumPossiblePressure();
        /*0x3e68150*/ UnityEngine.TouchType get_type();
        /*0x3e68158*/ float get_altitudeAngle();
        /*0x3e68160*/ float get_azimuthAngle();
        /*0x3e68168*/ float get_radius();
        /*0x3e68170*/ float get_radiusVariance();
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
        static /*0x3e68178*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x3e6829c*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x3e68238*/ nint RaycastTry_Injected(nint cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x3e6835c*/ nint RaycastTry2D_Injected(nint cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x0*/ bool <simulateTouchEnabled>k__BackingField;

        static /*0x3e683c0*/ float GetAxis(string axisName);
        static /*0x3e68530*/ float GetAxisRaw(string axisName);
        static /*0x3e686a0*/ bool GetButton(string buttonName);
        static /*0x3e68818*/ bool GetButtonDown(string buttonName);
        static /*0x3e68990*/ bool GetButtonUp(string buttonName);
        static /*0x3e68b08*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x3e68b44*/ bool GetKeyUpInt(UnityEngine.KeyCode key);
        static /*0x3e68b80*/ bool GetKeyDownInt(UnityEngine.KeyCode key);
        static /*0x3e68bbc*/ bool GetMouseButton(int button);
        static /*0x3e68bf8*/ bool GetMouseButtonDown(int button);
        static /*0x3e68c34*/ bool GetMouseButtonUp(int button);
        static /*0x3e68c70*/ UnityEngine.Touch GetTouch(int index);
        static /*0x3e68d24*/ UnityEngine.PenData GetLastPenContactEvent();
        static /*0x3e68dc4*/ void ClearLastPenContactEvent();
        static /*0x3e68dec*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x3e68e28*/ bool GetKeyUp(UnityEngine.KeyCode key);
        static /*0x3e68e64*/ bool GetKeyDown(UnityEngine.KeyCode key);
        static /*0x3e68ea0*/ bool get_anyKey();
        static /*0x3e68ec8*/ string get_inputString();
        static /*0x3e68fc8*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x3e69050*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x3e690d0*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x3e690f8*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x3e69134*/ string get_compositionString();
        static /*0x3e69234*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x3e692b4*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x3e69330*/ bool get_simulateTouchEnabled();
        static /*0x3e69378*/ bool GetMousePresentInternal();
        static /*0x3e693a0*/ bool GetTouchSupportedInternal();
        static /*0x3e693c8*/ bool get_mousePresent();
        static /*0x3e69434*/ bool get_touchSupported();
        static /*0x3e694a0*/ int get_touchCount();
        static /*0x3e694c8*/ void set_multiTouchEnabled(bool value);
        static /*0x3e69504*/ UnityEngine.DeviceOrientation get_deviceOrientation();
        static /*0x3e6952c*/ UnityEngine.Touch[] get_touches();
        static /*0x3e69658*/ bool CheckDisabled();
        static /*0x3e68ce0*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x3e68d88*/ void GetLastPenContactEvent_Injected(ref UnityEngine.PenData ret);
        static /*0x3e68f8c*/ void get_inputString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e69014*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x3e69094*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x3e691f8*/ void get_compositionString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e69278*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x3e692f4*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
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

        static /*0x3e6a970*/ SendMouseEvents();
        static /*0x3e69680*/ void UpdateMouse();
        static /*0x3e699d8*/ void SetMouseMoved();
        static /*0x3e69a34*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x3e6a3a0*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x3e6a7fc*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x3e6a8bc*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0x3e6a89c*/ void SendMessage(string name);
        }
    }

    namespace Internal
    {
        class InputUnsafeUtility
        {
            static /*0x3e6aa34*/ bool GetKeyString__Unmanaged(byte* name, int nameLen);
            static /*0x3e6aa78*/ bool GetKeyUpString__Unmanaged(byte* name, int nameLen);
            static /*0x3e6aabc*/ bool GetKeyDownString__Unmanaged(byte* name, int nameLen);
            static /*0x3e683c4*/ float GetAxis(string axisName);
            static /*0x3e6ab3c*/ float GetAxis__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x3e68534*/ float GetAxisRaw(string axisName);
            static /*0x3e6abbc*/ float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x3e686a4*/ bool GetButton(string buttonName);
            static /*0x3e6ac3c*/ bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x3e6881c*/ bool GetButtonDown(string buttonName);
            static /*0x3e6acbc*/ byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x3e68994*/ bool GetButtonUp(string buttonName);
            static /*0x3e6ad3c*/ bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x3e6ab00*/ float GetAxis_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper axisName);
            static /*0x3e6ab80*/ float GetAxisRaw_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper axisName);
            static /*0x3e6ac00*/ bool GetButton_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper buttonName);
            static /*0x3e6ac80*/ bool GetButtonDown_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper buttonName);
            static /*0x3e6ad00*/ bool GetButtonUp_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper buttonName);
        }
    }
}
