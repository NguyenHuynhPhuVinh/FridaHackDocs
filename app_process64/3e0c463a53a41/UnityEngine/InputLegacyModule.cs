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

        /*0x7ee91a8*/ int get_fingerId();
        /*0x7ee91b0*/ UnityEngine.Vector2 get_position();
        /*0x7ee91b8*/ void set_position(UnityEngine.Vector2 value);
        /*0x7ee91c0*/ UnityEngine.Vector2 get_rawPosition();
        /*0x7ee91c8*/ void set_rawPosition(UnityEngine.Vector2 value);
        /*0x7ee91d0*/ UnityEngine.Vector2 get_deltaPosition();
        /*0x7ee91d8*/ void set_deltaPosition(UnityEngine.Vector2 value);
        /*0x7ee91e0*/ float get_deltaTime();
        /*0x7ee91e8*/ int get_tapCount();
        /*0x7ee91f0*/ UnityEngine.TouchPhase get_phase();
        /*0x7ee91f8*/ float get_pressure();
        /*0x7ee9200*/ float get_maximumPossiblePressure();
        /*0x7ee9208*/ UnityEngine.TouchType get_type();
        /*0x7ee9210*/ float get_altitudeAngle();
        /*0x7ee9218*/ float get_azimuthAngle();
        /*0x7ee9220*/ float get_radius();
        /*0x7ee9228*/ float get_radiusVariance();
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
        static /*0x7ee9230*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7ee935c*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7ee92f8*/ nint RaycastTry_Injected(nint cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7ee9424*/ nint RaycastTry2D_Injected(nint cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x0*/ bool <simulateTouchEnabled>k__BackingField;

        static /*0x7ee9488*/ float GetAxis(string axisName);
        static /*0x7ee95f8*/ float GetAxisRaw(string axisName);
        static /*0x7ee9768*/ bool GetButtonDown(string buttonName);
        static /*0x7ee98e0*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x7ee991c*/ bool GetMouseButton(int button);
        static /*0x7ee9958*/ bool GetMouseButtonDown(int button);
        static /*0x7ee9994*/ bool GetMouseButtonUp(int button);
        static /*0x7ee99d0*/ UnityEngine.Touch GetTouch(int index);
        static /*0x7ee9a84*/ UnityEngine.PenData GetLastPenContactEvent();
        static /*0x7ee9b24*/ void ClearLastPenContactEvent();
        static /*0x7ee9b4c*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x7ee9b88*/ bool get_anyKey();
        static /*0x7ee9bb0*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x7ee9c38*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x7ee9cb8*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x7ee9ce0*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x7ee9d1c*/ string get_compositionString();
        static /*0x7ee9e0c*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x7ee9e8c*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x7ee9f08*/ bool get_simulateTouchEnabled();
        static /*0x7ee9f50*/ bool GetMousePresentInternal();
        static /*0x7ee9f78*/ bool GetTouchSupportedInternal();
        static /*0x7ee9fa0*/ bool get_mousePresent();
        static /*0x7eea00c*/ bool get_touchSupported();
        static /*0x7eea078*/ int get_touchCount();
        static /*0x7eea0a0*/ UnityEngine.Touch[] get_touches();
        static /*0x7eea1e0*/ bool CheckDisabled();
        static /*0x7ee9a40*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x7ee9ae8*/ void GetLastPenContactEvent_Injected(ref UnityEngine.PenData ret);
        static /*0x7ee9bfc*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x7ee9c7c*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x7ee9dd0*/ void get_compositionString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ee9e50*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x7ee9ecc*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
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

        static /*0x7eeb32c*/ SendMouseEvents();
        static /*0x7eea208*/ void UpdateMouse();
        static /*0x7eea3cc*/ void SetMouseMoved();
        static /*0x7eea428*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x7eead80*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x7eeb1b4*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x7eeb278*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0x7eeb254*/ void SendMessage(string name);
        }
    }

    namespace Internal
    {
        class InputUnsafeUtility
        {
            static /*0x7eeb3f0*/ bool GetKeyString__Unmanaged(byte* name, int nameLen);
            static /*0x7eeb434*/ bool GetKeyUpString__Unmanaged(byte* name, int nameLen);
            static /*0x7eeb478*/ bool GetKeyDownString__Unmanaged(byte* name, int nameLen);
            static /*0x7ee948c*/ float GetAxis(string axisName);
            static /*0x7eeb4f8*/ float GetAxis__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x7ee95fc*/ float GetAxisRaw(string axisName);
            static /*0x7eeb578*/ float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen);
            static /*0x7eeb5bc*/ bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x7ee976c*/ bool GetButtonDown(string buttonName);
            static /*0x7eeb63c*/ byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x7eeb680*/ bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen);
            static /*0x7eeb4bc*/ float GetAxis_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper axisName);
            static /*0x7eeb53c*/ float GetAxisRaw_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper axisName);
            static /*0x7eeb600*/ bool GetButtonDown_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper buttonName);
        }
    }
}
