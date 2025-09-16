class <Module>
{
}

namespace UnityEngine
{
    namespace VFX
    {
        enum VFXSpace
        {
            None = -1,
            Local = 0,
            World = 1,
        }

        enum VFXCameraBufferTypes
        {
            None = 0,
            Depth = 1,
            Color = 2,
            Normal = 4,
        }

        class VFXEventAttribute : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;
            /*0x20*/ UnityEngine.VFX.VisualEffectAsset m_VfxAsset;

            static /*0x81e8b00*/ UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper();
            static /*0x81e8bcc*/ nint Internal_Create();
            static /*0x81e8bf4*/ UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            static /*0x81e8df4*/ void Internal_Destroy(nint ptr);
            static /*0x81e8d48*/ void Internal_InitFromAsset_Injected(nint _unity_self, nint vfxAsset);
            static /*0x81e8f7c*/ bool HasBool_Injected(nint _unity_self, int nameID);
            static /*0x81e9018*/ bool HasInt_Injected(nint _unity_self, int nameID);
            static /*0x81e90b4*/ bool HasUint_Injected(nint _unity_self, int nameID);
            static /*0x81e9150*/ bool HasFloat_Injected(nint _unity_self, int nameID);
            static /*0x81e91ec*/ bool HasVector2_Injected(nint _unity_self, int nameID);
            static /*0x81e9288*/ bool HasVector3_Injected(nint _unity_self, int nameID);
            static /*0x81e9324*/ bool HasVector4_Injected(nint _unity_self, int nameID);
            static /*0x81e93d0*/ void SetBool_Injected(nint _unity_self, int nameID, bool b);
            static /*0x81e948c*/ void SetInt_Injected(nint _unity_self, int nameID, int i);
            static /*0x81e9548*/ void SetUint_Injected(nint _unity_self, int nameID, uint i);
            static /*0x81e9604*/ void SetFloat_Injected(nint _unity_self, int nameID, float f);
            static /*0x81e96c4*/ void SetVector2_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector2 v);
            static /*0x81e9788*/ void SetVector3_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector3 v);
            static /*0x81e984c*/ void SetVector4_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 v);
            /*0x81e8a64*/ VFXEventAttribute(nint ptr, bool owner, UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x81e8aac*/ VFXEventAttribute(nint ptr);
            /*0x81e8ad4*/ VFXEventAttribute();
            /*0x81e8b6c*/ void SetWrapValue(nint ptrToEventAttribute);
            /*0x81e8ca0*/ void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x81e8d8c*/ UnityEngine.VFX.VisualEffectAsset get_vfxAsset();
            /*0x81e8d94*/ void Release();
            /*0x81e8e30*/ void Finalize();
            /*0x81e8ec4*/ void Dispose();
            /*0x81e8f24*/ bool HasBool(int nameID);
            /*0x81e8fc0*/ bool HasInt(int nameID);
            /*0x81e905c*/ bool HasUint(int nameID);
            /*0x81e90f8*/ bool HasFloat(int nameID);
            /*0x81e9194*/ bool HasVector2(int nameID);
            /*0x81e9230*/ bool HasVector3(int nameID);
            /*0x81e92cc*/ bool HasVector4(int nameID);
            /*0x81e9368*/ void SetBool(int nameID, bool b);
            /*0x81e9424*/ void SetInt(int nameID, int i);
            /*0x81e94e0*/ void SetUint(int nameID, uint i);
            /*0x81e959c*/ void SetFloat(int nameID, float f);
            /*0x81e9658*/ void SetVector2(int nameID, UnityEngine.Vector2 v);
            /*0x81e9718*/ void SetVector3(int nameID, UnityEngine.Vector3 v);
            /*0x81e97dc*/ void SetVector4(int nameID, UnityEngine.Vector4 v);

            class BindingsMarshaller
            {
                static /*0x81e98a0*/ nint ConvertToNative(UnityEngine.VFX.VFXEventAttribute eventAttibute);
                static /*0x81e98b8*/ UnityEngine.VFX.VFXEventAttribute ConvertToManaged(nint ptr);
            }
        }

        class VFXExpressionValues
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81e991c*/ UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(nint ptr);
            static /*0x81e99d8*/ bool GetBool_Injected(nint _unity_self, int nameID);
            static /*0x81e9a74*/ int GetInt_Injected(nint _unity_self, int nameID);
            static /*0x81e9b10*/ uint GetUInt_Injected(nint _unity_self, int nameID);
            static /*0x81e9bac*/ float GetFloat_Injected(nint _unity_self, int nameID);
            static /*0x81e9c68*/ void GetVector3_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector3 ret);
            /*0x81e9914*/ VFXExpressionValues();
            /*0x81e9980*/ bool GetBool(int nameID);
            /*0x81e9a1c*/ int GetInt(int nameID);
            /*0x81e9ab8*/ uint GetUInt(int nameID);
            /*0x81e9b54*/ float GetFloat(int nameID);
            /*0x81e9bf0*/ UnityEngine.Vector3 GetVector3(int nameID);

            class BindingsMarshaller
            {
                static /*0x81e9cbc*/ nint ConvertToNative(UnityEngine.VFX.VFXExpressionValues vFXExpressionValues);
            }
        }

        struct VFXCameraXRSettings
        {
            /*0x10*/ uint viewTotal;
            /*0x14*/ uint viewCount;
            /*0x18*/ uint viewOffset;
        }

        struct VFXBatchedEffectInfo
        {
            /*0x10*/ UnityEngine.VFX.VisualEffectAsset vfxAsset;
            /*0x18*/ uint activeBatchCount;
            /*0x1c*/ uint inactiveBatchCount;
            /*0x20*/ uint activeInstanceCount;
            /*0x24*/ uint unbatchedInstanceCount;
            /*0x28*/ uint totalInstanceCapacity;
            /*0x2c*/ uint maxInstancePerBatchCapacity;
            /*0x30*/ ulong totalGPUSizeInBytes;
            /*0x38*/ ulong totalCPUSizeInBytes;
        }

        struct VFXBatchInfo
        {
            /*0x10*/ uint capacity;
            /*0x14*/ uint activeInstanceCount;
        }

        class VFXManager
        {
            static /*0x0*/ UnityEngine.VFX.VFXCameraXRSettings kDefaultCameraXRSettings;

            static /*0x81ea438*/ VFXManager();
            static /*0x81e9cd4*/ UnityEngine.ScriptableObject get_runtimeResources();
            static /*0x81e9d84*/ float get_fixedTimeStep();
            static /*0x81e9dac*/ float get_maxDeltaTime();
            static /*0x81e9dd4*/ float get_maxScrubTime();
            static /*0x81e9dfc*/ void PrepareCamera(UnityEngine.Camera cam);
            static /*0x81e9e60*/ void PrepareCamera(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraXRSettings camXRSettings);
            static /*0x81e9f88*/ void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
            static /*0x81ea00c*/ void Internal_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults);
            static /*0x81ea16c*/ UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded(UnityEngine.Camera cam);
            static /*0x81ea274*/ void SetCameraBuffer(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraBufferTypes type, UnityEngine.Texture buffer, int x, int y, int width, int height);
            static /*0x81e9d5c*/ nint get_runtimeResources_Injected();
            static /*0x81e9f44*/ void PrepareCamera_Injected(nint cam, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings);
            static /*0x81ea110*/ void Internal_ProcessCameraCommand_Injected(nint cam, nint cmd, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults);
            static /*0x81ea238*/ UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded_Injected(nint cam);
            static /*0x81ea3b4*/ void SetCameraBuffer_Injected(nint cam, UnityEngine.VFX.VFXCameraBufferTypes type, nint buffer, int x, int y, int width, int height);
        }

        class VFXSpawnerCallbacks : UnityEngine.ScriptableObject
        {
            /*0x81ea488*/ VFXSpawnerCallbacks();
            /*0x3816920*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x3816920*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x3816920*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
        }

        enum VFXSpawnerLoopState
        {
            Finished = 0,
            DelayingBeforeLoop = 1,
            Looping = 2,
            DelayingAfterLoop = 3,
        }

        class VFXSpawnerState : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;
            /*0x20*/ UnityEngine.VFX.VFXEventAttribute m_WrapEventAttribute;

            static /*0x81ea4c0*/ UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper();
            static /*0x81ea6ac*/ void Internal_Destroy(nint ptr);
            static /*0x81ea8b8*/ UnityEngine.VFX.VFXSpawnerLoopState get_loopState_Injected(nint _unity_self);
            static /*0x81ea8f4*/ void set_loopState_Injected(nint _unity_self, UnityEngine.VFX.VFXSpawnerLoopState value);
            static /*0x81ea988*/ float get_spawnCount_Injected(nint _unity_self);
            static /*0x81eaa24*/ void set_spawnCount_Injected(nint _unity_self, float value);
            static /*0x81eaac0*/ float get_deltaTime_Injected(nint _unity_self);
            static /*0x81eab4c*/ float get_totalTime_Injected(nint _unity_self);
            static /*0x81eabe8*/ void set_totalTime_Injected(nint _unity_self, float value);
            static /*0x81eac98*/ nint Internal_GetVFXEventAttribute_Injected(nint _unity_self);
            /*0x81ea490*/ VFXSpawnerState(nint ptr, bool owner);
            /*0x81ea524*/ void PrepareWrapper();
            /*0x81ea5bc*/ void SetWrapValue(nint ptrToSpawnerState, nint ptrToEventAttribute);
            /*0x81ea64c*/ void Release();
            /*0x81ea6e8*/ void Finalize();
            /*0x81ea77c*/ void Dispose();
            /*0x81ea7dc*/ bool get_playing();
            /*0x81ea844*/ void set_playing(bool value);
            /*0x81ea7f4*/ UnityEngine.VFX.VFXSpawnerLoopState get_loopState();
            /*0x81ea860*/ void set_loopState(UnityEngine.VFX.VFXSpawnerLoopState value);
            /*0x81ea938*/ float get_spawnCount();
            /*0x81ea9c4*/ void set_spawnCount(float value);
            /*0x81eaa70*/ float get_deltaTime();
            /*0x81eaafc*/ float get_totalTime();
            /*0x81eab88*/ void set_totalTime(float value);
            /*0x81eac34*/ UnityEngine.VFX.VFXEventAttribute Internal_GetVFXEventAttribute();
            /*0x81eacd4*/ UnityEngine.VFX.VFXEventAttribute get_vfxEventAttribute();

            class BindingsMarshaller
            {
                static /*0x81eacf0*/ nint ConvertToNative(UnityEngine.VFX.VFXSpawnerState vfxSpawnerState);
            }
        }

        class VisualEffectObject : UnityEngine.Object
        {
            /*0x81ead08*/ VisualEffectObject();
        }

        class VisualEffectAsset : UnityEngine.VFX.VisualEffectObject
        {
            static string PlayEventName = "OnPlay";
            static string StopEventName = "OnStop";
            static /*0x0*/ int PlayEventID;
            static /*0x4*/ int StopEventID;

            static /*0x81eae54*/ VisualEffectAsset();
            static /*0x81eae0c*/ UnityEngine.VFX.VFXSpace GetExposedSpace_Injected(nint _unity_self, int nameID);
            /*0x81eae50*/ VisualEffectAsset();
            /*0x81ead60*/ UnityEngine.VFX.VFXSpace GetExposedSpace(int nameID);
        }

        struct VFXOutputEventArgs
        {
            /*0x10*/ int <nameId>k__BackingField;
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField;

            /*0x81eaf00*/ VFXOutputEventArgs(int nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81eaef0*/ int get_nameId();
            /*0x81eaef8*/ UnityEngine.VFX.VFXEventAttribute get_eventAttribute();
        }

        class VisualEffect : UnityEngine.Behaviour
        {
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute;
            /*0x20*/ System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived;

            static /*0x81ec81c*/ UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source);
            static /*0x81ec874*/ void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, int eventNameId);
            static /*0x81eaf90*/ void set_pause_Injected(nint _unity_self, bool value);
            static /*0x81eb04c*/ uint get_startSeed_Injected(nint _unity_self);
            static /*0x81eb108*/ void set_startSeed_Injected(nint _unity_self, uint value);
            static /*0x81eb1c4*/ bool get_resetSeedOnPlay_Injected(nint _unity_self);
            static /*0x81eb280*/ void set_resetSeedOnPlay_Injected(nint _unity_self, bool value);
            static /*0x81eb358*/ nint get_visualEffectAsset_Injected(nint _unity_self);
            static /*0x81eb580*/ void SendEventFromScript_Injected(nint _unity_self, int eventNameID, nint eventAttribute);
            static /*0x81eb6d4*/ void Reinit_Injected(nint _unity_self, bool sendInitialEventAndPrewarm);
            static /*0x81eb798*/ bool HasBool_Injected(nint _unity_self, int nameID);
            static /*0x81eb85c*/ bool HasInt_Injected(nint _unity_self, int nameID);
            static /*0x81eb920*/ bool HasUInt_Injected(nint _unity_self, int nameID);
            static /*0x81eb9e4*/ bool HasFloat_Injected(nint _unity_self, int nameID);
            static /*0x81ebaa8*/ bool HasVector2_Injected(nint _unity_self, int nameID);
            static /*0x81ebb6c*/ bool HasVector3_Injected(nint _unity_self, int nameID);
            static /*0x81ebc30*/ bool HasVector4_Injected(nint _unity_self, int nameID);
            static /*0x81ebcf4*/ bool HasTexture_Injected(nint _unity_self, int nameID);
            static /*0x81ebdc8*/ void SetBool_Injected(nint _unity_self, int nameID, bool b);
            static /*0x81ebeac*/ void SetInt_Injected(nint _unity_self, int nameID, int i);
            static /*0x81ebf90*/ void SetUInt_Injected(nint _unity_self, int nameID, uint i);
            static /*0x81ec074*/ void SetFloat_Injected(nint _unity_self, int nameID, float f);
            static /*0x81ec15c*/ void SetVector2_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector2 v);
            static /*0x81ec248*/ void SetVector3_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector3 v);
            static /*0x81ec334*/ void SetVector4_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 v);
            static /*0x81ec47c*/ void SetTexture_Injected(nint _unity_self, int nameID, nint t);
            static /*0x81ec6fc*/ float get_time_Injected(nint _unity_self);
            static /*0x81ec7c8*/ void Simulate_Injected(nint _unity_self, float stepDeltaTime, uint stepCount);
            /*0x81ec8d0*/ VisualEffect();
            /*0x81eaf10*/ void set_pause(bool value);
            /*0x81eafd4*/ uint get_startSeed();
            /*0x81eb088*/ void set_startSeed(uint value);
            /*0x81eb14c*/ bool get_resetSeedOnPlay();
            /*0x81eb200*/ void set_resetSeedOnPlay(bool value);
            /*0x81eb2c4*/ UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset();
            /*0x81eb394*/ UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute();
            /*0x81eb420*/ void CheckValidVFXEventAttribute(UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81eb4e8*/ void SendEventFromScript(int eventNameID, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81eb5d4*/ void SendEvent(int eventNameID, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81eb608*/ void SendEvent(string eventName, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81eb64c*/ void SendEvent(int eventNameID);
            /*0x81eb654*/ void Reinit(bool sendInitialEventAndPrewarm);
            /*0x81eb718*/ bool HasBool(int nameID);
            /*0x81eb7dc*/ bool HasInt(int nameID);
            /*0x81eb8a0*/ bool HasUInt(int nameID);
            /*0x81eb964*/ bool HasFloat(int nameID);
            /*0x81eba28*/ bool HasVector2(int nameID);
            /*0x81ebaec*/ bool HasVector3(int nameID);
            /*0x81ebbb0*/ bool HasVector4(int nameID);
            /*0x81ebc74*/ bool HasTexture(int nameID);
            /*0x81ebd38*/ void SetBool(int nameID, bool b);
            /*0x81ebe1c*/ void SetInt(int nameID, int i);
            /*0x81ebf00*/ void SetUInt(int nameID, uint i);
            /*0x81ebfe4*/ void SetFloat(int nameID, float f);
            /*0x81ec0c8*/ void SetVector2(int nameID, UnityEngine.Vector2 v);
            /*0x81ec1b0*/ void SetVector3(int nameID, UnityEngine.Vector3 v);
            /*0x81ec29c*/ void SetVector4(int nameID, UnityEngine.Vector4 v);
            /*0x81ec388*/ void SetTexture(int nameID, UnityEngine.Texture t);
            /*0x81ec4d0*/ bool HasUInt(string name);
            /*0x81ec4f4*/ bool HasFloat(string name);
            /*0x81ec518*/ bool HasVector4(string name);
            /*0x81ec53c*/ bool HasTexture(string name);
            /*0x81ec560*/ void SetUInt(string name, uint i);
            /*0x81ec594*/ void SetFloat(string name, float f);
            /*0x81ec5c8*/ void SetVector4(string name, UnityEngine.Vector4 v);
            /*0x81ec61c*/ void SetTexture(string name, UnityEngine.Texture t);
            /*0x81ec650*/ void SetBool(string name, bool b);
            /*0x81ec684*/ float get_time();
            /*0x81ec738*/ void Simulate(float stepDeltaTime, uint stepCount);
        }
    }
}
