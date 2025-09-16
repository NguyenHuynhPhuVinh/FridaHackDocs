class <Module>
{
}

namespace UnityEngineInternal
{
    namespace Input
    {
        class NativeUpdateCallback : System.MulticastDelegate
        {
            /*0x7f02af4*/ NativeUpdateCallback(object object, nint method);
            /*0x7f02b94*/ void Invoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer);
        }

        enum NativeInputEventType
        {
            DeviceRemoved = 1146242381,
            DeviceConfigChanged = 1145259591,
            Text = 1413830740,
            State = 1398030676,
            Delta = 1145852993,
        }

        struct NativeInputEventBuffer
        {
            /*0x10*/ void* eventBuffer;
            /*0x18*/ int eventCount;
            /*0x1c*/ int sizeInBytes;
            /*0x20*/ int capacityInBytes;
        }

        struct NativeInputEvent
        {
            static int structSize = 20;
            /*0x10*/ UnityEngineInternal.Input.NativeInputEventType type;
            /*0x14*/ ushort sizeInBytes;
            /*0x16*/ ushort deviceId;
            /*0x18*/ double time;
            /*0x20*/ int eventId;
        }

        enum NativeInputUpdateType
        {
            Dynamic = 1,
            Fixed = 2,
            BeforeRender = 4,
            Editor = 8,
            IgnoreFocus = -2147483648,
        }

        class NativeInputSystem
        {
            static /*0x0*/ UnityEngineInternal.Input.NativeUpdateCallback onUpdate;
            static /*0x8*/ System.Action<UnityEngineInternal.Input.NativeInputUpdateType> onBeforeUpdate;
            static /*0x10*/ System.Func<UnityEngineInternal.Input.NativeInputUpdateType, bool> onShouldRunUpdate;
            static /*0x18*/ System.Action<int, string> s_OnDeviceDiscoveredCallback;

            static /*0x7f02cd4*/ NativeInputSystem();
            static /*0x7f02ba8*/ System.Action<int, string> get_onDeviceDiscovered();
            static /*0x7f02c00*/ void set_onDeviceDiscovered(System.Action<int, string> value);
            static /*0x7f02d04*/ void NotifyBeforeUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType);
            static /*0x7f02d80*/ void NotifyUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, nint eventBuffer);
            static /*0x7f02e1c*/ void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor);
            static /*0x7f02eac*/ void ShouldRunUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, ref bool retval);
            static /*0x7f02c98*/ void set_hasDeviceDiscoveredCallback(bool value);
            static /*0x7f02f3c*/ double get_currentTime();
            static /*0x7f02f64*/ double get_currentTimeOffsetToRealtimeSinceStartup();
            static /*0x7f02f8c*/ int AllocateDeviceId();
            static /*0x7f02fb4*/ void QueueInputEvent(nint inputEvent);
            static /*0x7f02ff0*/ long IOCTL(int deviceId, int code, nint data, int sizeInBytes);
            static /*0x7f0304c*/ void SetPollingFrequency(float hertz);
            static /*0x7f03084*/ void Update(UnityEngineInternal.Input.NativeInputUpdateType updateType);
            static /*0x7f030c0*/ bool get_normalizeScrollWheelDelta();
            static /*0x7f030e8*/ void set_normalizeScrollWheelDelta(bool value);
            static /*0x7f03124*/ float GetScrollWheelDeltaPerTick();
        }
    }
}
