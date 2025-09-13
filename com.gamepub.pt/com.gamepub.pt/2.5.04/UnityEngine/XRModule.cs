class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2b05820*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x2b06074*/ IsReadOnlyAttribute();
            }
        }
    }
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

            static /*0x2b0600c*/ InputTracking();
            static /*0x2b05dbc*/ void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, long uniqueID, bool tracked);

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

            /*0xb3a23c*/ void set_uniqueID(ulong value);
            /*0xb3a244*/ void set_nodeType(UnityEngine.XR.XRNode value);
            /*0xb3a24c*/ void set_tracked(bool value);
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

            /*0xb3a0b8*/ string get_name();
            /*0xb3a0c0*/ UnityEngine.XR.InputFeatureType get_internalType();
            /*0xb3a0c8*/ bool Equals(object obj);
            /*0xb3a0d0*/ bool Equals(UnityEngine.XR.InputFeatureUsage other);
            /*0xb3a114*/ int GetHashCode();
        }

        struct InputDevice : System.IEquatable<UnityEngine.XR.InputDevice>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ bool m_Initialized;

            /*0xb39f84*/ InputDevice(ulong deviceId);
            /*0xb39f94*/ ulong get_deviceId();
            /*0xb39fac*/ bool Equals(object obj);
            /*0xb39fb4*/ bool Equals(UnityEngine.XR.InputDevice other);
            /*0xb39fdc*/ int GetHashCode();
        }

        struct Hand : System.IEquatable<UnityEngine.XR.Hand>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0xb39f0c*/ ulong get_deviceId();
            /*0xb39f14*/ uint get_featureIndex();
            /*0xb39f1c*/ bool Equals(object obj);
            /*0xb39f24*/ bool Equals(UnityEngine.XR.Hand other);
            /*0xb39f48*/ int GetHashCode();
        }

        struct Eyes : System.IEquatable<UnityEngine.XR.Eyes>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0xb39ec8*/ ulong get_deviceId();
            /*0xb39ed0*/ uint get_featureIndex();
            /*0xb39ed8*/ bool Equals(object obj);
            /*0xb39ee0*/ bool Equals(UnityEngine.XR.Eyes other);
            /*0xb39f04*/ int GetHashCode();
        }

        struct Bone : System.IEquatable<UnityEngine.XR.Bone>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0xb39e84*/ ulong get_deviceId();
            /*0xb39e8c*/ uint get_featureIndex();
            /*0xb39e94*/ bool Equals(object obj);
            /*0xb39e9c*/ bool Equals(UnityEngine.XR.Bone other);
            /*0xb39ec0*/ int GetHashCode();
        }

        class InputDevices
        {
            static /*0x0*/ System.Action<UnityEngine.XR.InputDevice> deviceConnected;
            static /*0x8*/ System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;
            static /*0x10*/ System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;

            static /*0x2b05ba0*/ void InvokeConnectionEvent(ulong deviceId, UnityEngine.XR.ConnectionChangeType change);
        }

        class XRDisplaySubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRDisplaySubsystemDescriptor>
        {
            /*0x20*/ System.Action<bool> displayFocusChanged;

            /*0x2b065fc*/ XRDisplaySubsystem();
            /*0x2b0658c*/ void InvokeDisplayFocusChanged(bool focus);

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
            }

            struct XRMirrorViewBlitDesc
            {
                /*0x10*/ nint displaySubsystemInstance;
                /*0x18*/ bool nativeBlitAvailable;
                /*0x19*/ bool nativeBlitInvalidStates;
                /*0x1c*/ int blitParamsCount;
            }
        }

        class XRDisplaySubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRDisplaySubsystem>
        {
            /*0x2b06648*/ XRDisplaySubsystemDescriptor();
        }

        class XRInputSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRInputSubsystemDescriptor>
        {
            /*0x20*/ System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;
            /*0x28*/ System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;

            static /*0x2b06694*/ void InvokeTrackingOriginUpdatedEvent(nint internalPtr);
            static /*0x2b06770*/ void InvokeBoundaryChangedEvent(nint internalPtr);
            /*0x2b0684c*/ XRInputSubsystem();
        }

        class XRInputSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRInputSubsystem>
        {
            /*0x2b06898*/ XRInputSubsystemDescriptor();
        }

        struct MeshId : System.IEquatable<UnityEngine.XR.MeshId>
        {
            static /*0x0*/ UnityEngine.XR.MeshId s_InvalidId;
            /*0x10*/ ulong m_SubId1;
            /*0x18*/ ulong m_SubId2;

            static /*0x2b06540*/ MeshId();
            /*0xb3a1cc*/ string ToString();
            /*0xb3a1d4*/ int GetHashCode();
            /*0xb3a210*/ bool Equals(object obj);
            /*0xb3a218*/ bool Equals(UnityEngine.XR.MeshId other);
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
            static /*0x2b05a60*/ int Combine(int hash1, int hash2);
        }

        struct MeshGenerationResult : System.IEquatable<UnityEngine.XR.MeshGenerationResult>
        {
            /*0x10*/ UnityEngine.XR.MeshId <MeshId>k__BackingField;
            /*0x20*/ UnityEngine.Mesh <Mesh>k__BackingField;
            /*0x28*/ UnityEngine.MeshCollider <MeshCollider>k__BackingField;
            /*0x30*/ UnityEngine.XR.MeshGenerationStatus <Status>k__BackingField;
            /*0x34*/ UnityEngine.XR.MeshVertexAttributes <Attributes>k__BackingField;

            /*0xb3a158*/ UnityEngine.XR.MeshId get_MeshId();
            /*0xb3a164*/ UnityEngine.Mesh get_Mesh();
            /*0xb3a16c*/ UnityEngine.MeshCollider get_MeshCollider();
            /*0xb3a174*/ UnityEngine.XR.MeshGenerationStatus get_Status();
            /*0xb3a17c*/ UnityEngine.XR.MeshVertexAttributes get_Attributes();
            /*0xb3a184*/ bool Equals(object obj);
            /*0xb3a18c*/ bool Equals(UnityEngine.XR.MeshGenerationResult other);
            /*0xb3a1c4*/ int GetHashCode();
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
            /*0x2b0696c*/ XRMeshSubsystem();
            /*0x2b068e4*/ void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete);
        }

        class XRMeshSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRMeshSubsystem>
        {
            /*0x2b069b8*/ XRMeshSubsystemDescriptor();
        }
    }
}
