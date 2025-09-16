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

            static /*0x81d16d0*/ UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper();
            static /*0x81d179c*/ nint Internal_Create();
            static /*0x81d17c4*/ UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            static /*0x81d19c4*/ void Internal_Destroy(nint ptr);
            static /*0x81d1918*/ void Internal_InitFromAsset_Injected(nint _unity_self, nint vfxAsset);
            static /*0x81d1b4c*/ bool HasBool_Injected(nint _unity_self, int nameID);
            static /*0x81d1be8*/ bool HasInt_Injected(nint _unity_self, int nameID);
            static /*0x81d1c84*/ bool HasUint_Injected(nint _unity_self, int nameID);
            static /*0x81d1d20*/ bool HasFloat_Injected(nint _unity_self, int nameID);
            static /*0x81d1dbc*/ bool HasVector2_Injected(nint _unity_self, int nameID);
            static /*0x81d1e58*/ bool HasVector3_Injected(nint _unity_self, int nameID);
            static /*0x81d1ef4*/ bool HasVector4_Injected(nint _unity_self, int nameID);
            static /*0x81d1fa0*/ void SetBool_Injected(nint _unity_self, int nameID, bool b);
            static /*0x81d205c*/ void SetInt_Injected(nint _unity_self, int nameID, int i);
            static /*0x81d2118*/ void SetUint_Injected(nint _unity_self, int nameID, uint i);
            static /*0x81d21d4*/ void SetFloat_Injected(nint _unity_self, int nameID, float f);
            static /*0x81d2294*/ void SetVector2_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector2 v);
            static /*0x81d2358*/ void SetVector3_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector3 v);
            static /*0x81d241c*/ void SetVector4_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 v);
            /*0x81d1634*/ VFXEventAttribute(nint ptr, bool owner, UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x81d167c*/ VFXEventAttribute(nint ptr);
            /*0x81d16a4*/ VFXEventAttribute();
            /*0x81d173c*/ void SetWrapValue(nint ptrToEventAttribute);
            /*0x81d1870*/ void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x81d195c*/ UnityEngine.VFX.VisualEffectAsset get_vfxAsset();
            /*0x81d1964*/ void Release();
            /*0x81d1a00*/ void Finalize();
            /*0x81d1a94*/ void Dispose();
            /*0x81d1af4*/ bool HasBool(int nameID);
            /*0x81d1b90*/ bool HasInt(int nameID);
            /*0x81d1c2c*/ bool HasUint(int nameID);
            /*0x81d1cc8*/ bool HasFloat(int nameID);
            /*0x81d1d64*/ bool HasVector2(int nameID);
            /*0x81d1e00*/ bool HasVector3(int nameID);
            /*0x81d1e9c*/ bool HasVector4(int nameID);
            /*0x81d1f38*/ void SetBool(int nameID, bool b);
            /*0x81d1ff4*/ void SetInt(int nameID, int i);
            /*0x81d20b0*/ void SetUint(int nameID, uint i);
            /*0x81d216c*/ void SetFloat(int nameID, float f);
            /*0x81d2228*/ void SetVector2(int nameID, UnityEngine.Vector2 v);
            /*0x81d22e8*/ void SetVector3(int nameID, UnityEngine.Vector3 v);
            /*0x81d23ac*/ void SetVector4(int nameID, UnityEngine.Vector4 v);

            class BindingsMarshaller
            {
                static /*0x81d2470*/ nint ConvertToNative(UnityEngine.VFX.VFXEventAttribute eventAttibute);
                static /*0x81d2488*/ UnityEngine.VFX.VFXEventAttribute ConvertToManaged(nint ptr);
            }
        }

        class VFXExpressionValues
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81d24ec*/ UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(nint ptr);
            static /*0x81d25a8*/ bool GetBool_Injected(nint _unity_self, int nameID);
            static /*0x81d2644*/ int GetInt_Injected(nint _unity_self, int nameID);
            static /*0x81d26e0*/ uint GetUInt_Injected(nint _unity_self, int nameID);
            static /*0x81d277c*/ float GetFloat_Injected(nint _unity_self, int nameID);
            static /*0x81d2838*/ void GetVector3_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector3 ret);
            /*0x81d24e4*/ VFXExpressionValues();
            /*0x81d2550*/ bool GetBool(int nameID);
            /*0x81d25ec*/ int GetInt(int nameID);
            /*0x81d2688*/ uint GetUInt(int nameID);
            /*0x81d2724*/ float GetFloat(int nameID);
            /*0x81d27c0*/ UnityEngine.Vector3 GetVector3(int nameID);

            class BindingsMarshaller
            {
                static /*0x81d288c*/ nint ConvertToNative(UnityEngine.VFX.VFXExpressionValues vFXExpressionValues);
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

            static /*0x81d3008*/ VFXManager();
            static /*0x81d28a4*/ UnityEngine.ScriptableObject get_runtimeResources();
            static /*0x81d2954*/ float get_fixedTimeStep();
            static /*0x81d297c*/ float get_maxDeltaTime();
            static /*0x81d29a4*/ float get_maxScrubTime();
            static /*0x81d29cc*/ void PrepareCamera(UnityEngine.Camera cam);
            static /*0x81d2a30*/ void PrepareCamera(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraXRSettings camXRSettings);
            static /*0x81d2b58*/ void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
            static /*0x81d2bdc*/ void Internal_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults);
            static /*0x81d2d3c*/ UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded(UnityEngine.Camera cam);
            static /*0x81d2e44*/ void SetCameraBuffer(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraBufferTypes type, UnityEngine.Texture buffer, int x, int y, int width, int height);
            static /*0x81d292c*/ nint get_runtimeResources_Injected();
            static /*0x81d2b14*/ void PrepareCamera_Injected(nint cam, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings);
            static /*0x81d2ce0*/ void Internal_ProcessCameraCommand_Injected(nint cam, nint cmd, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults);
            static /*0x81d2e08*/ UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded_Injected(nint cam);
            static /*0x81d2f84*/ void SetCameraBuffer_Injected(nint cam, UnityEngine.VFX.VFXCameraBufferTypes type, nint buffer, int x, int y, int width, int height);
        }

        class VFXSpawnerCallbacks : UnityEngine.ScriptableObject
        {
            /*0x81d3058*/ VFXSpawnerCallbacks();
            /*0x380da4c*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x380da4c*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x380da4c*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
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

            static /*0x81d3090*/ UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper();
            static /*0x81d327c*/ void Internal_Destroy(nint ptr);
            static /*0x81d3488*/ UnityEngine.VFX.VFXSpawnerLoopState get_loopState_Injected(nint _unity_self);
            static /*0x81d34c4*/ void set_loopState_Injected(nint _unity_self, UnityEngine.VFX.VFXSpawnerLoopState value);
            static /*0x81d3558*/ float get_spawnCount_Injected(nint _unity_self);
            static /*0x81d35f4*/ void set_spawnCount_Injected(nint _unity_self, float value);
            static /*0x81d3690*/ float get_deltaTime_Injected(nint _unity_self);
            static /*0x81d371c*/ float get_totalTime_Injected(nint _unity_self);
            static /*0x81d37b8*/ void set_totalTime_Injected(nint _unity_self, float value);
            static /*0x81d3868*/ nint Internal_GetVFXEventAttribute_Injected(nint _unity_self);
            /*0x81d3060*/ VFXSpawnerState(nint ptr, bool owner);
            /*0x81d30f4*/ void PrepareWrapper();
            /*0x81d318c*/ void SetWrapValue(nint ptrToSpawnerState, nint ptrToEventAttribute);
            /*0x81d321c*/ void Release();
            /*0x81d32b8*/ void Finalize();
            /*0x81d334c*/ void Dispose();
            /*0x81d33ac*/ bool get_playing();
            /*0x81d3414*/ void set_playing(bool value);
            /*0x81d33c4*/ UnityEngine.VFX.VFXSpawnerLoopState get_loopState();
            /*0x81d3430*/ void set_loopState(UnityEngine.VFX.VFXSpawnerLoopState value);
            /*0x81d3508*/ float get_spawnCount();
            /*0x81d3594*/ void set_spawnCount(float value);
            /*0x81d3640*/ float get_deltaTime();
            /*0x81d36cc*/ float get_totalTime();
            /*0x81d3758*/ void set_totalTime(float value);
            /*0x81d3804*/ UnityEngine.VFX.VFXEventAttribute Internal_GetVFXEventAttribute();
            /*0x81d38a4*/ UnityEngine.VFX.VFXEventAttribute get_vfxEventAttribute();

            class BindingsMarshaller
            {
                static /*0x81d38c0*/ nint ConvertToNative(UnityEngine.VFX.VFXSpawnerState vfxSpawnerState);
            }
        }

        class VisualEffectObject : UnityEngine.Object
        {
            /*0x81d38d8*/ VisualEffectObject();
        }

        class VisualEffectAsset : UnityEngine.VFX.VisualEffectObject
        {
            static string PlayEventName = "OnPlay";
            static string StopEventName = "OnStop";
            static /*0x0*/ int PlayEventID;
            static /*0x4*/ int StopEventID;

            static /*0x81d3a24*/ VisualEffectAsset();
            static /*0x81d39dc*/ UnityEngine.VFX.VFXSpace GetExposedSpace_Injected(nint _unity_self, int nameID);
            /*0x81d3a20*/ VisualEffectAsset();
            /*0x81d3930*/ UnityEngine.VFX.VFXSpace GetExposedSpace(int nameID);
        }

        struct VFXOutputEventArgs
        {
            /*0x10*/ int <nameId>k__BackingField;
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField;

            /*0x81d3ad0*/ VFXOutputEventArgs(int nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81d3ac0*/ int get_nameId();
            /*0x81d3ac8*/ UnityEngine.VFX.VFXEventAttribute get_eventAttribute();
        }

        class VisualEffect : UnityEngine.Behaviour
        {
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute;
            /*0x20*/ System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived;

            static /*0x81d53ec*/ UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source);
            static /*0x81d5444*/ void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, int eventNameId);
            static /*0x81d3b60*/ void set_pause_Injected(nint _unity_self, bool value);
            static /*0x81d3c1c*/ uint get_startSeed_Injected(nint _unity_self);
            static /*0x81d3cd8*/ void set_startSeed_Injected(nint _unity_self, uint value);
            static /*0x81d3d94*/ bool get_resetSeedOnPlay_Injected(nint _unity_self);
            static /*0x81d3e50*/ void set_resetSeedOnPlay_Injected(nint _unity_self, bool value);
            static /*0x81d3f28*/ nint get_visualEffectAsset_Injected(nint _unity_self);
            static /*0x81d4150*/ void SendEventFromScript_Injected(nint _unity_self, int eventNameID, nint eventAttribute);
            static /*0x81d42a4*/ void Reinit_Injected(nint _unity_self, bool sendInitialEventAndPrewarm);
            static /*0x81d4368*/ bool HasBool_Injected(nint _unity_self, int nameID);
            static /*0x81d442c*/ bool HasInt_Injected(nint _unity_self, int nameID);
            static /*0x81d44f0*/ bool HasUInt_Injected(nint _unity_self, int nameID);
            static /*0x81d45b4*/ bool HasFloat_Injected(nint _unity_self, int nameID);
            static /*0x81d4678*/ bool HasVector2_Injected(nint _unity_self, int nameID);
            static /*0x81d473c*/ bool HasVector3_Injected(nint _unity_self, int nameID);
            static /*0x81d4800*/ bool HasVector4_Injected(nint _unity_self, int nameID);
            static /*0x81d48c4*/ bool HasTexture_Injected(nint _unity_self, int nameID);
            static /*0x81d4998*/ void SetBool_Injected(nint _unity_self, int nameID, bool b);
            static /*0x81d4a7c*/ void SetInt_Injected(nint _unity_self, int nameID, int i);
            static /*0x81d4b60*/ void SetUInt_Injected(nint _unity_self, int nameID, uint i);
            static /*0x81d4c44*/ void SetFloat_Injected(nint _unity_self, int nameID, float f);
            static /*0x81d4d2c*/ void SetVector2_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector2 v);
            static /*0x81d4e18*/ void SetVector3_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector3 v);
            static /*0x81d4f04*/ void SetVector4_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 v);
            static /*0x81d504c*/ void SetTexture_Injected(nint _unity_self, int nameID, nint t);
            static /*0x81d52cc*/ float get_time_Injected(nint _unity_self);
            static /*0x81d5398*/ void Simulate_Injected(nint _unity_self, float stepDeltaTime, uint stepCount);
            /*0x81d54a0*/ VisualEffect();
            /*0x81d3ae0*/ void set_pause(bool value);
            /*0x81d3ba4*/ uint get_startSeed();
            /*0x81d3c58*/ void set_startSeed(uint value);
            /*0x81d3d1c*/ bool get_resetSeedOnPlay();
            /*0x81d3dd0*/ void set_resetSeedOnPlay(bool value);
            /*0x81d3e94*/ UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset();
            /*0x81d3f64*/ UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute();
            /*0x81d3ff0*/ void CheckValidVFXEventAttribute(UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81d40b8*/ void SendEventFromScript(int eventNameID, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81d41a4*/ void SendEvent(int eventNameID, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81d41d8*/ void SendEvent(string eventName, UnityEngine.VFX.VFXEventAttribute eventAttribute);
            /*0x81d421c*/ void SendEvent(int eventNameID);
            /*0x81d4224*/ void Reinit(bool sendInitialEventAndPrewarm);
            /*0x81d42e8*/ bool HasBool(int nameID);
            /*0x81d43ac*/ bool HasInt(int nameID);
            /*0x81d4470*/ bool HasUInt(int nameID);
            /*0x81d4534*/ bool HasFloat(int nameID);
            /*0x81d45f8*/ bool HasVector2(int nameID);
            /*0x81d46bc*/ bool HasVector3(int nameID);
            /*0x81d4780*/ bool HasVector4(int nameID);
            /*0x81d4844*/ bool HasTexture(int nameID);
            /*0x81d4908*/ void SetBool(int nameID, bool b);
            /*0x81d49ec*/ void SetInt(int nameID, int i);
            /*0x81d4ad0*/ void SetUInt(int nameID, uint i);
            /*0x81d4bb4*/ void SetFloat(int nameID, float f);
            /*0x81d4c98*/ void SetVector2(int nameID, UnityEngine.Vector2 v);
            /*0x81d4d80*/ void SetVector3(int nameID, UnityEngine.Vector3 v);
            /*0x81d4e6c*/ void SetVector4(int nameID, UnityEngine.Vector4 v);
            /*0x81d4f58*/ void SetTexture(int nameID, UnityEngine.Texture t);
            /*0x81d50a0*/ bool HasUInt(string name);
            /*0x81d50c4*/ bool HasFloat(string name);
            /*0x81d50e8*/ bool HasVector4(string name);
            /*0x81d510c*/ bool HasTexture(string name);
            /*0x81d5130*/ void SetUInt(string name, uint i);
            /*0x81d5164*/ void SetFloat(string name, float f);
            /*0x81d5198*/ void SetVector4(string name, UnityEngine.Vector4 v);
            /*0x81d51ec*/ void SetTexture(string name, UnityEngine.Texture t);
            /*0x81d5220*/ void SetBool(string name, bool b);
            /*0x81d5254*/ float get_time();
            /*0x81d5308*/ void Simulate(float stepDeltaTime, uint stepCount);
        }
    }
}
