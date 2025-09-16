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

            static /*0x81dae0c*/ void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, long uniqueID, bool tracked);

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

            /*0x81dafb4*/ void set_uniqueID(ulong value);
            /*0x81dafbc*/ void set_nodeType(UnityEngine.XR.XRNode value);
            /*0x81dafc4*/ void set_tracked(bool value);
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

            /*0x81dafd0*/ string get_name();
            /*0x81dafd8*/ UnityEngine.XR.InputFeatureType get_internalType();
            /*0x81dafe0*/ bool Equals(object obj);
            /*0x81db068*/ bool Equals(UnityEngine.XR.InputFeatureUsage other);
            /*0x81db0a8*/ int GetHashCode();
        }

        struct InputDevice : System.IEquatable<UnityEngine.XR.InputDevice>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ bool m_Initialized;

            /*0x81db0f8*/ InputDevice(ulong deviceId);
            /*0x81db108*/ ulong get_deviceId();
            /*0x81db120*/ bool Equals(object obj);
            /*0x81db1b0*/ bool Equals(UnityEngine.XR.InputDevice other);
            /*0x81db1d8*/ int GetHashCode();
        }

        struct Hand : System.IEquatable<UnityEngine.XR.Hand>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x81db20c*/ ulong get_deviceId();
            /*0x81db214*/ uint get_featureIndex();
            /*0x81db21c*/ bool Equals(object obj);
            /*0x81db2a4*/ bool Equals(UnityEngine.XR.Hand other);
            /*0x81db2c8*/ int GetHashCode();
        }

        struct Eyes : System.IEquatable<UnityEngine.XR.Eyes>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x81db31c*/ ulong get_deviceId();
            /*0x81db324*/ uint get_featureIndex();
            /*0x81db32c*/ bool Equals(object obj);
            /*0x81db3b4*/ bool Equals(UnityEngine.XR.Eyes other);
            /*0x81db3d8*/ int GetHashCode();
        }

        struct Bone : System.IEquatable<UnityEngine.XR.Bone>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x81db42c*/ ulong get_deviceId();
            /*0x81db434*/ uint get_featureIndex();
            /*0x81db43c*/ bool Equals(object obj);
            /*0x81db4c4*/ bool Equals(UnityEngine.XR.Bone other);
            /*0x81db4e8*/ int GetHashCode();
        }

        class InputDevices
        {
            static /*0x0*/ System.Action<UnityEngine.XR.InputDevice> deviceConnected;
            static /*0x8*/ System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;
            static /*0x10*/ System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;

            static /*0x81db53c*/ void InvokeConnectionEvent(ulong deviceId, UnityEngine.XR.ConnectionChangeType change);
        }

        class XRDisplaySubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRDisplaySubsystemDescriptor>
        {
            /*0x20*/ System.Action<bool> displayFocusChanged;
            /*0x28*/ UnityEngine.HDROutputSettings m_HDROutputSettings;

            static /*0x81db668*/ float get_scaleOfAllViewports_Injected(nint _unity_self);
            static /*0x81db704*/ void set_scaleOfAllRenderTargets_Injected(nint _unity_self, float value);
            static /*0x81db7b0*/ void set_zNear_Injected(nint _unity_self, float value);
            static /*0x81db85c*/ void set_zFar_Injected(nint _unity_self, float value);
            static /*0x81db900*/ void set_sRGB_Injected(nint _unity_self, bool value);
            static /*0x81db99c*/ void set_textureLayout_Injected(nint _unity_self, UnityEngine.XR.XRDisplaySubsystem.TextureLayout value);
            static /*0x81dba38*/ void SetMSAALevel_Injected(nint _unity_self, int level);
            static /*0x81dbad4*/ void set_disableLegacyRenderer_Injected(nint _unity_self, bool value);
            static /*0x81dbb68*/ int GetRenderPassCount_Injected(nint _unity_self);
            static /*0x81dbc68*/ bool Internal_TryGetRenderPass_Injected(nint _unity_self, int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            static /*0x81dbe24*/ bool Internal_TryEndRecordingIfLateLatched_Injected(nint _unity_self, nint camera);
            static /*0x81dbfd0*/ bool Internal_TryBeginRecordingIfLateLatched_Injected(nint _unity_self, nint camera);
            static /*0x81dc194*/ bool Internal_TryGetCullingParams_Injected(nint _unity_self, nint camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            static /*0x81dc240*/ int GetPreferredMirrorBlitMode_Injected(nint _unity_self);
            static /*0x81dc2d4*/ void SetPreferredMirrorBlitMode_Injected(nint _unity_self, int blitMode);
            static /*0x81dc3d8*/ bool GetMirrorViewBlitDesc_Injected(nint _unity_self, nint mirrorRt, ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode);
            static /*0x81dc4ac*/ bool AddGraphicsThreadMirrorViewBlit_Injected(nint _unity_self, nint cmd, bool allowGraphicsStateInvalidate, int mode);
            /*0x81dc57c*/ XRDisplaySubsystem();
            /*0x81db5f8*/ void InvokeDisplayFocusChanged(bool focus);
            /*0x81db618*/ float get_scaleOfAllViewports();
            /*0x81db6a4*/ void set_scaleOfAllRenderTargets(float value);
            /*0x81db750*/ void set_zNear(float value);
            /*0x81db7fc*/ void set_zFar(float value);
            /*0x81db8a8*/ void set_sRGB(bool value);
            /*0x81db944*/ void set_textureLayout(UnityEngine.XR.XRDisplaySubsystem.TextureLayout value);
            /*0x81db9e0*/ void SetMSAALevel(int level);
            /*0x81dba7c*/ void set_disableLegacyRenderer(bool value);
            /*0x81dbb18*/ int GetRenderPassCount();
            /*0x81dbba4*/ void GetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x81dbc00*/ bool Internal_TryGetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x81dbcbc*/ void EndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81dbd7c*/ bool Internal_TryEndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81dbe68*/ void BeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81dbf28*/ bool Internal_TryBeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x81dc014*/ void GetCullingParameters(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x81dc0d4*/ bool Internal_TryGetCullingParams(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x81dc1f0*/ int GetPreferredMirrorBlitMode();
            /*0x81dc27c*/ void SetPreferredMirrorBlitMode(int blitMode);
            /*0x81dc318*/ bool GetMirrorViewBlitDesc(UnityEngine.RenderTexture mirrorRt, ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode);
            /*0x81dc434*/ bool AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);
            /*0x81dc508*/ UnityEngine.HDROutputSettings get_hdrOutputSettings();

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

                static /*0x81dc670*/ void GetRenderParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self, nint camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                /*0x81dc5c4*/ void GetRenderParameter(UnityEngine.Camera camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                /*0x81dc6cc*/ int GetRenderParameterCount();
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

                /*0x81dc708*/ void GetBlitParameter(int blitParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter);
            }

            class BindingsMarshaller
            {
                static /*0x81dc75c*/ nint ConvertToNative(UnityEngine.XR.XRDisplaySubsystem xrDisplaySubsystem);
            }
        }

        class XRDisplaySubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRDisplaySubsystem>
        {
            /*0x81dc774*/ XRDisplaySubsystemDescriptor();
        }

        class XRInputSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRInputSubsystemDescriptor>
        {
            /*0x20*/ System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;
            /*0x28*/ System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;

            static /*0x81dc7bc*/ void InvokeTrackingOriginUpdatedEvent(nint internalPtr);
            static /*0x81dc880*/ void InvokeBoundaryChangedEvent(nint internalPtr);
            /*0x81dc944*/ XRInputSubsystem();
        }

        class XRInputSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRInputSubsystem>
        {
            /*0x81dc98c*/ XRInputSubsystemDescriptor();
        }

        struct MeshId : System.IEquatable<UnityEngine.XR.MeshId>
        {
            static /*0x0*/ UnityEngine.XR.MeshId s_InvalidId;
            /*0x10*/ ulong m_SubId1;
            /*0x18*/ ulong m_SubId2;

            static /*0x81dcb78*/ MeshId();
            /*0x81dc9d4*/ string ToString();
            /*0x81dca68*/ int GetHashCode();
            /*0x81dca9c*/ bool Equals(object obj);
            /*0x81dcb54*/ bool Equals(UnityEngine.XR.MeshId other);
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
            static /*0x81dcbc0*/ int Combine(int hash1, int hash2);
            static /*0x81dcbd0*/ int Combine(int hash1, int hash2, int hash3);
            static /*0x81dcbe4*/ int Combine(int hash1, int hash2, int hash3, int hash4);
            static /*0x81dcbfc*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5);
            static /*0x81dcc18*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6);
            static /*0x81dcc38*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7);
            static /*0x81dcc5c*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8);
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

            /*0x81dcc84*/ UnityEngine.XR.MeshId get_MeshId();
            /*0x81dcc90*/ UnityEngine.Mesh get_Mesh();
            /*0x81dcc98*/ UnityEngine.MeshCollider get_MeshCollider();
            /*0x81dcca0*/ UnityEngine.XR.MeshGenerationStatus get_Status();
            /*0x81dcca8*/ UnityEngine.XR.MeshVertexAttributes get_Attributes();
            /*0x81dccb0*/ UnityEngine.Vector3 get_Position();
            /*0x81dccbc*/ UnityEngine.Quaternion get_Rotation();
            /*0x81dccc8*/ UnityEngine.Vector3 get_Scale();
            /*0x81dccd4*/ bool Equals(object obj);
            /*0x81dcd64*/ bool Equals(UnityEngine.XR.MeshGenerationResult other);
            /*0x81dcf28*/ int GetHashCode();
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
            /*0x81dd1c4*/ XRMeshSubsystem();
            /*0x81dd16c*/ void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete);

            struct MeshTransformList : System.IDisposable
            {
                /*0x10*/ nint m_Self;

                static /*0x81dd248*/ void Dispose(nint self);
                /*0x81dd20c*/ void Dispose();
            }
        }

        class XRMeshSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRMeshSubsystem>
        {
            /*0x81dd284*/ XRMeshSubsystemDescriptor();
        }
    }
}
