class <Module>
{
}

namespace UnityEngineInternal
{
    namespace Input
    {
        class NativeUpdateCallback : System.MulticastDelegate
        {
            /*0x2b390b8*/ NativeUpdateCallback(object object, nint method);
            /*0x2b38cf0*/ void Invoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer);
            /*0x2b39118*/ System.IAsyncResult BeginInvoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer, System.AsyncCallback callback, object object);
            /*0x2b391ac*/ void EndInvoke(System.IAsyncResult result);
        }

        struct NativeInputEventBuffer
        {
            /*0x10*/ void* eventBuffer;
            /*0x18*/ int eventCount;
            /*0x1c*/ int sizeInBytes;
            /*0x20*/ int capacityInBytes;
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

            static /*0x2b38b44*/ NativeInputSystem();
            static /*0x2b38bc0*/ void NotifyBeforeUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType);
            static /*0x2b38c54*/ void NotifyUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, nint eventBuffer);
            static /*0x2b38f68*/ void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor);
            static /*0x2b39010*/ void ShouldRunUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, ref bool retval);
            static /*0x2b38b80*/ void set_hasDeviceDiscoveredCallback(bool value);
        }
    }
}
