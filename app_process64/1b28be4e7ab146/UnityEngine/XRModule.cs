class <Module>
{
}

namespace UnityEngine
{
    namespace XR
    {
        class InputTracking
        {
            static /*0x0*/ System.Action<UnityEngine.XR.XRNodeState> trackingAcquired;
            static /*0x8*/ System.Action<UnityEngine.XR.XRNodeState> trackingLost;
            static /*0x10*/ System.Action<UnityEngine.XR.XRNodeState> nodeAdded;
            static /*0x18*/ System.Action<UnityEngine.XR.XRNodeState> nodeRemoved;

            static /*0x81f223c*/ void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, long uniqueID, bool tracked);

            enum TrackingStateEventType
            {
                NodeAdded = 0,
                NodeRemoved = 1,
                TrackingAcquired = 2,
                TrackingLost = 3,
            }
        }

        enum XRNode
        {
            LeftEye = 0,
            RightEye = 1,
            CenterEye = 2,
            Head = 3,
            LeftHand = 4,
            RightHand = 5,
            GameController = 6,
            TrackingReference = 7,
            HardwareTracker = 8,
        }

        enum AvailableTrackingData
        {
            None = 0,
            PositionAvailable = 1,
            RotationAvailable = 2,
            VelocityAvailable = 4,
            AngularVelocityAvailable = 8,
            AccelerationAvailable = 16,
            AngularAccelerationAvailable = 32,
        }

        struct XRNodeState
        {
            /*0x10*/ UnityEngine.XR.XRNode m_Type;
            /*0x14*/ UnityEngine.XR.AvailableTrackingData m_AvailableFields;
            /*0x18*/ UnityEngine.Vector3 m_Position;
            /*0x24*/ UnityEngine.Quaternion m_Rotation;
            /*0x34*/ UnityEngine.Vector3 m_Velocity;
            /*0x40*/ UnityEngine.Vector3 m_AngularVelocity;
            /*0x4c*/ UnityEngine.Vector3 m_Acceleration;
            /*0x58*/ UnityEngine.Vector3 m_AngularAcceleration;
            /*0x64*/ int m_Tracked;
            /*0x68*/ ulong m_UniqueID;

            /*0x81f23e4*/ void set_uniqueID(ulong value);
            /*0x81f23ec*/ void set_nodeType(UnityEngine.XR.XRNode value);
            /*0x81f23f4*/ void set_tracked(bool value);
        }

        enum InputFeatureType
        {
            Custom = 0,
            Binary = 1,
            DiscreteStates = 2,
            Axis1D = 3,
            Axis2D = 4,
            Axis3D = 5,
            Rotation = 6,
            Hand = 7,
            Bone = 8,
            Eyes = 9,
            kUnityXRInputFeatureTypeInvalid = 4294967295,
        }

        enum ConnectionChangeType
        {
            Connected = 0,
            Disconnected = 1,
            ConfigChange = 2,
        }

        enum InputDeviceCharacteristics
        {
            None = 0,
            HeadMounted = 1,
            Camera = 2,
            HeldInHand = 4,
            HandTracking = 8,
            EyeTracking = 16,
            TrackedDevice = 32,
            Controller = 64,
            TrackingReference = 128,
            Left = 256,
            Right = 512,
            Simulated6DOF = 1024,
        }

        enum InputTrackingState
        {
            None = 0,
            Position = 1,
            Rotation = 2,
            Velocity = 4,
            AngularVelocity = 8,
            Acceleration = 16,
            AngularAcceleration = 32,
            All = 63,
        }

        struct InputFeatureUsage : System.IEquatable<UnityEngine.XR.InputFeatureUsage>
        {
            /*0x10*/ string m_Name;
            /*0x18*/ UnityEngine.XR.InputFeatureType m_InternalType;

            /*0x81f2400*/ string get_name();
            /*0x81f2408*/ UnityEngine.XR.InputFeatureType get_internalType();
            /*0x81f2410*/ bool Equals(object obj);
            /*0x81f2498*/ bool Equals(UnityEngine.XR.InputFeatureUsage other);
            /*0x81f24d8*/ int GetHashCode();
        }

        struct InputDevice : System.IEquatable<UnityEngine.XR.InputDevice>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ bool m_Initialized;

            /*0x81f2528*/ InputDevice(ulong deviceId);
            /*0x81f2538*/ ulong get_deviceId();
            /*0x81f2550*/ bool Equals(object obj);
            /*0x81f25e0*/ bool Equals(UnityEngine.XR.InputDevice other);
            /*0x81f2608*/ int GetHashCode();
        }

        struct Hand : System.IEquatable<UnityEngine.XR.Hand>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x81f263c*/ ulong get_deviceId();
            /*0x81f2644*/ uint get_featureIndex();
            /*0x81f264c*/ bool Equals(object obj);
            /*0x81f26d4*/ bool Equals(UnityEngine.XR.Hand other);
            /*0x81f26f8*/ int GetHashCode();
        }

        struct Eyes : System.IEquatable<UnityEngine.XR.Eyes>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x81f274c*/ ulong get_deviceId();
            /*0x81f2754*/ uint get_featureIndex();
            /*0x81f275c*/ bool Equals(object obj);
            /*0x81f27e4*/ bool Equals(UnityEngine.XR.Eyes other);
            /*0x81f2808*/ int GetHashCode();
        }

        struct Bone : System.IEquatable<UnityEngine.XR.Bone>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x81f285c*/ ulong get_deviceId();
            /*0x81f2864*/ uint get_featureIndex();
            /*0x81f286c*/ bool Equals(object obj);
            /*0x81f28f4*/ bool Equals(UnityEngine.XR.Bone other);
            /*0x81f2918*/ int GetHashCode();
        }

        class InputDevices
        {
            static /*0x0*/ System.Action<UnityEngine.XR.InputDevice> deviceConnected;
            static /*0x8*/ System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;
            static /*0x10*/ System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;

            static /*0x81f296c*/ void InvokeConnectionEvent(ulong deviceId, UnityEngine.XR.ConnectionChangeType change);
        }

        class XRDisplaySubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRDisplaySubsystemDescriptor>
        {
            /*0x20*/ System.Action<bool> displayFocusChanged;
            /*0x28*/ UnityEngine.HDROutputSettings m_HDROutputSettings;

            static /*0x81f2a98*/ float get_scaleOfAllViewports_Injected(nint _unity_self);
            static /*0x81f2b34*/ void set_scaleOfAllRenderTargets_Injected(nint _unity_self, float value);
            static /*0x81f2be0*/ void set_zNear_Injected(nint _unity_self, float value);
            static /*0x81f2c8c*/ void set_zFar_Injected(nint _unity_self, float value);
            static /*0x81f2d30*/ void set_sRGB_Injected(nint _unity_self, bool value);
            static /*0x81f2dcc*/ void set_textureLayout_Injected(nint _unity_self, UnityEngine.XR.XRDisplaySubsystem.TextureLayout value);
            static /*0x81f2e68*/ void SetMSAALevel_Injected(nint _unity_self, int level);
            static /*0x81f2f04*/ void set_disableLegacyRenderer_Injected(nint _unity_self, bool value);
            static /*0x81f2f98*/ int GetRenderPassCount_Injected(nint _unity_self);
            static /*0x81f3098*/ bool Internal_TryGetRenderPass_Injected(nint _unity_self, int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            static /*0x81f3254*/ bool Internal_TryEndRecordingIfLateLatched_Injected(nint _unity_self, nint camera);
            static /*0x81f3400*/ bool Internal_TryBeginRecordingIfLateLatched_Injected(nint _unity_self, nint camera);
            static /*0x81f35c4*/ bool Internal_TryGetCullingParams_Injected(nint _unity_self, nint camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            static /*0x81f3670*/ int GetPreferredMirrorBlitMode_Injected(nint _unity_self);
            static /*0x81f3704*/ void SetPreferredMirrorBlitMode_Injected(nint _unity_self, int blitMode);
            static /*0x81f3808*/ bool GetMirrorViewBlitDesc_Injected(nint _unity_self, nint mirrorRt, ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode);
            static /*0x81f38dc*/ bool AddGraphicsThreadMirrorViewBlit_Injected(nint _unity_self, nint cmd, bool allowGraphicsStateInvalidate, int mode);
            /*0x81f39ac*/ XRDisplaySubsystem();
            /*0x81f2a28*/ void InvokeDisplayFocusChanged(bool focus);
            /*0x81f2a48*/ float get_scaleOfAllViewports();
            /*0x81f2ad4*/ void set_scaleOfAllRenderTargets(float value);
            /*0x81f2b80*/ void set_zNear(float value);
            /*0x81f2c2c*/ void set_zFar(float value);
            /*0x81f2cd8*/ void set_sRGB(bool value);
            /*0x81f2d74*/ void set_textureLayout(UnityEngine.XR.XRDisplaySubsystem.TextureLayout value);
            /*0x81f2e10*/ void SetMSAALevel(int level);
            /*0x81f2eac*/ void set_disableLegacyRenderer(bool value);
            /*0x81f2f48*/ int GetRenderPassCount();
            /*0x81f2fd4*/ void GetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x81f3030*/ bool Internal_TryGetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x81f30ec*/ void EndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81f31ac*/ bool Internal_TryEndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81f3298*/ void BeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81f3358*/ bool Internal_TryBeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81f3444*/ void GetCullingParameters(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x81f3504*/ bool Internal_TryGetCullingParams(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x81f3620*/ int GetPreferredMirrorBlitMode();
            /*0x81f36ac*/ void SetPreferredMirrorBlitMode(int blitMode);
            /*0x81f3748*/ bool GetMirrorViewBlitDesc(UnityEngine.RenderTexture mirrorRt, ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode);
            /*0x81f3864*/ bool AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);
            /*0x81f3938*/ UnityEngine.HDROutputSettings get_hdrOutputSettings();

            enum TextureLayout
            {
                Texture2DArray = 1,
                SingleTexture2D = 2,
                SeparateTexture2Ds = 4,
            }

            struct XRRenderParameter
            {
                /*0x10*/ UnityEngine.Matrix4x4 view;
                /*0x50*/ UnityEngine.Matrix4x4 projection;
                /*0x90*/ UnityEngine.Rect viewport;
                /*0xa0*/ UnityEngine.Mesh occlusionMesh;
                /*0xa8*/ int textureArraySlice;
                /*0xac*/ UnityEngine.Matrix4x4 previousView;
                /*0xec*/ bool isPreviousViewValid;
            }

            struct XRRenderPass
            {
                /*0x10*/ nint displaySubsystemInstance;
                /*0x18*/ int renderPassIndex;
                /*0x20*/ UnityEngine.Rendering.RenderTargetIdentifier renderTarget;
                /*0x48*/ UnityEngine.RenderTextureDescriptor renderTargetDesc;
                /*0x7c*/ bool hasMotionVectorPass;
                /*0x80*/ UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget;
                /*0xa8*/ UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc;
                /*0xdc*/ bool shouldFillOutDepth;
                /*0xe0*/ int cullingPassIndex;
                /*0xe8*/ nint foveatedRenderingInfo;

                static /*0x81f3aa0*/ void GetRenderParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self, nint camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                /*0x81f39f4*/ void GetRenderParameter(UnityEngine.Camera camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                /*0x81f3afc*/ int GetRenderParameterCount();
            }

            struct XRBlitParams
            {
                /*0x10*/ UnityEngine.RenderTexture srcTex;
                /*0x18*/ int srcTexArraySlice;
                /*0x1c*/ UnityEngine.Rect srcRect;
                /*0x2c*/ UnityEngine.Rect destRect;
                /*0x40*/ nint foveatedRenderingInfo;
                /*0x48*/ bool srcHdrEncoded;
                /*0x4c*/ UnityEngine.ColorGamut srcHdrColorGamut;
                /*0x50*/ int srcHdrMaxLuminance;
            }

            struct XRMirrorViewBlitDesc
            {
                /*0x10*/ nint displaySubsystemInstance;
                /*0x18*/ bool nativeBlitAvailable;
                /*0x19*/ bool nativeBlitInvalidStates;
                /*0x1c*/ int blitParamsCount;

                /*0x81f3b38*/ void GetBlitParameter(int blitParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter);
            }

            class BindingsMarshaller
            {
                static /*0x81f3b8c*/ nint ConvertToNative(UnityEngine.XR.XRDisplaySubsystem xrDisplaySubsystem);
            }
        }

        class XRDisplaySubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRDisplaySubsystem>
        {
            /*0x81f3ba4*/ XRDisplaySubsystemDescriptor();
        }

        class XRInputSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRInputSubsystemDescriptor>
        {
            /*0x20*/ System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;
            /*0x28*/ System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;

            static /*0x81f3bec*/ void InvokeTrackingOriginUpdatedEvent(nint internalPtr);
            static /*0x81f3cb0*/ void InvokeBoundaryChangedEvent(nint internalPtr);
            /*0x81f3d74*/ XRInputSubsystem();
        }

        class XRInputSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRInputSubsystem>
        {
            /*0x81f3dbc*/ XRInputSubsystemDescriptor();
        }

        struct MeshId : System.IEquatable<UnityEngine.XR.MeshId>
        {
            static /*0x0*/ UnityEngine.XR.MeshId s_InvalidId;
            /*0x10*/ ulong m_SubId1;
            /*0x18*/ ulong m_SubId2;

            static /*0x81f3fa8*/ MeshId();
            /*0x81f3e04*/ string ToString();
            /*0x81f3e98*/ int GetHashCode();
            /*0x81f3ecc*/ bool Equals(object obj);
            /*0x81f3f84*/ bool Equals(UnityEngine.XR.MeshId other);
        }

        enum MeshGenerationStatus
        {
            Success = 0,
            InvalidMeshId = 1,
            GenerationAlreadyInProgress = 2,
            Canceled = 3,
            UnknownError = 4,
        }

        class HashCodeHelper
        {
            static /*0x81f3ff0*/ int Combine(int hash1, int hash2);
            static /*0x81f4000*/ int Combine(int hash1, int hash2, int hash3);
            static /*0x81f4014*/ int Combine(int hash1, int hash2, int hash3, int hash4);
            static /*0x81f402c*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5);
            static /*0x81f4048*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6);
            static /*0x81f4068*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7);
            static /*0x81f408c*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8);
        }

        struct MeshGenerationResult : System.IEquatable<UnityEngine.XR.MeshGenerationResult>
        {
            /*0x10*/ UnityEngine.XR.MeshId <MeshId>k__BackingField;
            /*0x20*/ UnityEngine.Mesh <Mesh>k__BackingField;
            /*0x28*/ UnityEngine.MeshCollider <MeshCollider>k__BackingField;
            /*0x30*/ UnityEngine.XR.MeshGenerationStatus <Status>k__BackingField;
            /*0x34*/ UnityEngine.XR.MeshVertexAttributes <Attributes>k__BackingField;
            /*0x38*/ ulong <Timestamp>k__BackingField;
            /*0x40*/ UnityEngine.Vector3 <Position>k__BackingField;
            /*0x4c*/ UnityEngine.Quaternion <Rotation>k__BackingField;
            /*0x5c*/ UnityEngine.Vector3 <Scale>k__BackingField;

            /*0x81f40b4*/ UnityEngine.XR.MeshId get_MeshId();
            /*0x81f40c0*/ UnityEngine.Mesh get_Mesh();
            /*0x81f40c8*/ UnityEngine.MeshCollider get_MeshCollider();
            /*0x81f40d0*/ UnityEngine.XR.MeshGenerationStatus get_Status();
            /*0x81f40d8*/ UnityEngine.XR.MeshVertexAttributes get_Attributes();
            /*0x81f40e0*/ UnityEngine.Vector3 get_Position();
            /*0x81f40ec*/ UnityEngine.Quaternion get_Rotation();
            /*0x81f40f8*/ UnityEngine.Vector3 get_Scale();
            /*0x81f4104*/ bool Equals(object obj);
            /*0x81f4194*/ bool Equals(UnityEngine.XR.MeshGenerationResult other);
            /*0x81f4358*/ int GetHashCode();
        }

        enum MeshVertexAttributes
        {
            None = 0,
            Normals = 1,
            Tangents = 2,
            UVs = 4,
            Colors = 8,
        }

        class XRMeshSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRMeshSubsystemDescriptor>
        {
            /*0x81f45f4*/ XRMeshSubsystem();
            /*0x81f459c*/ void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete);

            struct MeshTransformList : System.IDisposable
            {
                /*0x10*/ nint m_Self;

                static /*0x81f4678*/ void Dispose(nint self);
                /*0x81f463c*/ void Dispose();
            }
        }

        class XRMeshSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRMeshSubsystem>
        {
            /*0x81f46b4*/ XRMeshSubsystemDescriptor();
        }
    }
}
