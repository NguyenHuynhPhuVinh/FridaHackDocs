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

            static /*0x186b9a0*/ void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, long uniqueID, bool tracked);

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

            /*0x12a1070*/ void set_uniqueID(ulong value);
            /*0x6bbd40*/ void set_nodeType(UnityEngine.XR.XRNode value);
            /*0x186cf30*/ void set_tracked(bool value);
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

        struct InputFeatureUsage : System.IEquatable<UnityEngine.XR.InputFeatureUsage>
        {
            /*0x10*/ string m_Name;
            /*0x18*/ UnityEngine.XR.InputFeatureType m_InternalType;

            /*0x69af20*/ string get_name();
            /*0xb73eb0*/ UnityEngine.XR.InputFeatureType get_internalType();
            /*0x186b830*/ bool Equals(object obj);
            /*0x186b8f0*/ bool Equals(UnityEngine.XR.InputFeatureUsage other);
            /*0x186b940*/ int GetHashCode();
        }

        struct InputDevice : System.IEquatable<UnityEngine.XR.InputDevice>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ bool m_Initialized;

            /*0x186b730*/ InputDevice(ulong deviceId);
            /*0x186b740*/ ulong get_deviceId();
            /*0x186b620*/ bool Equals(object obj);
            /*0x186b6d0*/ bool Equals(UnityEngine.XR.InputDevice other);
            /*0x186b700*/ int GetHashCode();
        }

        struct Hand : System.IEquatable<UnityEngine.XR.Hand>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x69af20*/ ulong get_deviceId();
            /*0xb73eb0*/ uint get_featureIndex();
            /*0x186b420*/ bool Equals(object obj);
            /*0x186b250*/ bool Equals(UnityEngine.XR.Hand other);
            /*0x186b320*/ int GetHashCode();
        }

        struct Eyes : System.IEquatable<UnityEngine.XR.Eyes>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x69af20*/ ulong get_deviceId();
            /*0xb73eb0*/ uint get_featureIndex();
            /*0x186b370*/ bool Equals(object obj);
            /*0x186b250*/ bool Equals(UnityEngine.XR.Eyes other);
            /*0x186b320*/ int GetHashCode();
        }

        struct Bone : System.IEquatable<UnityEngine.XR.Bone>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x69af20*/ ulong get_deviceId();
            /*0xb73eb0*/ uint get_featureIndex();
            /*0x186b270*/ bool Equals(object obj);
            /*0x186b250*/ bool Equals(UnityEngine.XR.Bone other);
            /*0x186b320*/ int GetHashCode();
        }

        class InputDevices
        {
            static /*0x0*/ System.Action<UnityEngine.XR.InputDevice> deviceConnected;
            static /*0x8*/ System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;
            static /*0x10*/ System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;

            static /*0x186b760*/ void InvokeConnectionEvent(ulong deviceId, UnityEngine.XR.ConnectionChangeType change);
        }

        class XRDisplaySubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRDisplaySubsystemDescriptor>
        {
            /*0x20*/ System.Action<bool> displayFocusChanged;
            /*0x28*/ UnityEngine.HDROutputSettings m_HDROutputSettings;

            /*0x186c990*/ XRDisplaySubsystem();
            /*0x15b87f0*/ void InvokeDisplayFocusChanged(bool focus);
            /*0x186cae0*/ void set_scaleOfAllRenderTargets(float value);
            /*0x186cbc0*/ void set_zNear(float value);
            /*0x186cb70*/ void set_zFar(float value);
            /*0x186ca90*/ void set_sRGB(bool value);
            /*0x186cb30*/ void set_textureLayout(UnityEngine.XR.XRDisplaySubsystem.TextureLayout value);
            /*0x186c950*/ void SetMSAALevel(int level);
            /*0x186ca40*/ void set_disableLegacyRenderer(bool value);
            /*0x186c710*/ int GetRenderPassCount();
            /*0x186c750*/ void GetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x186c900*/ bool Internal_TryGetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x186c450*/ void EndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x186c840*/ bool Internal_TryEndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x186c370*/ void BeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x186c7f0*/ bool Internal_TryBeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x186c530*/ void GetCullingParameters(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x186c890*/ bool Internal_TryGetCullingParams(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x186c6d0*/ int GetPreferredMirrorBlitMode();
            /*0x186c660*/ bool GetMirrorViewBlitDesc(UnityEngine.RenderTexture mirrorRt, ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode);
            /*0x186c300*/ bool AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);
            /*0x186c9d0*/ UnityEngine.HDROutputSettings get_hdrOutputSettings();

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

                static /*0x186cf80*/ void GetRenderParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self, UnityEngine.Camera camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                static /*0x186cf40*/ int GetRenderParameterCount_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self);
                /*0x186cf80*/ void GetRenderParameter(UnityEngine.Camera camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                /*0x186cf40*/ int GetRenderParameterCount();
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

                static /*0x186cee0*/ void GetBlitParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter);
                /*0x186cee0*/ void GetBlitParameter(int blitParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter);
            }
        }

        class XRDisplaySubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRDisplaySubsystem>
        {
            /*0x186c2c0*/ XRDisplaySubsystemDescriptor();
        }

        class XRInputSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRInputSubsystemDescriptor>
        {
            /*0x20*/ System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;
            /*0x28*/ System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;

            static /*0x186cd00*/ void InvokeTrackingOriginUpdatedEvent(nint internalPtr);
            static /*0x186cc50*/ void InvokeBoundaryChangedEvent(nint internalPtr);
            /*0x186cdb0*/ XRInputSubsystem();
        }

        class XRInputSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRInputSubsystem>
        {
            /*0x186cc10*/ XRInputSubsystemDescriptor();
        }

        struct MeshId : System.IEquatable<UnityEngine.XR.MeshId>
        {
            static /*0x0*/ UnityEngine.XR.MeshId s_InvalidId;
            /*0x10*/ ulong m_SubId1;
            /*0x18*/ ulong m_SubId2;

            static /*0x186c200*/ MeshId();
            /*0x186c180*/ string ToString();
            /*0x15e4120*/ int GetHashCode();
            /*0x186c0d0*/ bool Equals(object obj);
            /*0x15e42e0*/ bool Equals(UnityEngine.XR.MeshId other);
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
            static /*0x186b510*/ int Combine(int hash1, int hash2);
            static /*0x186b5e0*/ int Combine(int hash1, int hash2, int hash3);
            static /*0x186b600*/ int Combine(int hash1, int hash2, int hash3, int hash4);
            static /*0x186b560*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5);
            static /*0x186b520*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6);
            static /*0x186b4d0*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7);
            static /*0x186b590*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8);
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

            /*0x6bba70*/ UnityEngine.XR.MeshId get_MeshId();
            /*0x73d3e0*/ UnityEngine.Mesh get_Mesh();
            /*0x32f410*/ UnityEngine.MeshCollider get_MeshCollider();
            /*0x3e3af0*/ UnityEngine.XR.MeshGenerationStatus get_Status();
            /*0x3e3ad0*/ UnityEngine.XR.MeshVertexAttributes get_Attributes();
            /*0x129f5c0*/ UnityEngine.Vector3 get_Position();
            /*0x16b12b0*/ UnityEngine.Quaternion get_Rotation();
            /*0x186c0b0*/ UnityEngine.Vector3 get_Scale();
            /*0x186bb60*/ bool Equals(object obj);
            /*0x186bc40*/ bool Equals(UnityEngine.XR.MeshGenerationResult other);
            /*0x186be50*/ int GetHashCode();
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
            /*0x186cea0*/ XRMeshSubsystem();
            /*0x186ce30*/ void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete);

            struct MeshTransformList : System.IDisposable
            {
                /*0x10*/ nint m_Self;

                static /*0x186c280*/ void Dispose(nint self);
                /*0x186c240*/ void Dispose();
            }
        }

        class XRMeshSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRMeshSubsystem>
        {
            /*0x186cdf0*/ XRMeshSubsystemDescriptor();
        }
    }
}
