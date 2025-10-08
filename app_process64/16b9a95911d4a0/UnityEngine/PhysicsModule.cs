class <Module>
{
}

namespace UnityEngine
{
    struct ContactPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ UnityEngine.Vector3 m_Impulse;
        /*0x34*/ int m_ThisColliderInstanceID;
        /*0x38*/ int m_OtherColliderInstanceID;
        /*0x3c*/ float m_Separation;
    }

    class Collision
    {
        /*0x10*/ UnityEngine.ContactPairHeader m_Header;
        /*0x38*/ UnityEngine.ContactPair m_Pair;
        /*0x60*/ bool m_Flipped;
        /*0x68*/ UnityEngine.ContactPoint[] m_LegacyContacts;

        /*0x3e780b0*/ Collision();
        /*0x3e78108*/ Collision(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        /*0x3e77e5c*/ UnityEngine.Component get_body();
        /*0x3e77f24*/ UnityEngine.Collider get_collider();
        /*0x3e78014*/ UnityEngine.GameObject get_gameObject();
        /*0x3e780a8*/ void set_Flipped(bool value);
        /*0x3e78324*/ void Reuse(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair);
    }

    class BoxCollider : UnityEngine.Collider
    {
        static /*0x3e78400*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e784d4*/ void set_center_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e785b0*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e78684*/ void set_size_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        /*0x3e786f8*/ BoxCollider();
        /*0x3e78368*/ UnityEngine.Vector3 get_center();
        /*0x3e78444*/ void set_center(UnityEngine.Vector3 value);
        /*0x3e78518*/ UnityEngine.Vector3 get_size();
        /*0x3e785f4*/ void set_size(UnityEngine.Vector3 value);
        /*0x3e786c8*/ UnityEngine.Vector3 get_extents();
        /*0x3e786e8*/ void set_extents(UnityEngine.Vector3 value);
    }

    class CapsuleCollider : UnityEngine.Collider
    {
        static /*0x3e787a0*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e78874*/ void set_center_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e78930*/ float get_radius_Injected(nint _unity_self);
        static /*0x3e789f4*/ void set_radius_Injected(nint _unity_self, float value);
        static /*0x3e78ab8*/ float get_height_Injected(nint _unity_self);
        static /*0x3e78b7c*/ void set_height_Injected(nint _unity_self, float value);
        static /*0x3e78c40*/ int get_direction_Injected(nint _unity_self);
        static /*0x3e78cfc*/ void set_direction_Injected(nint _unity_self, int value);
        /*0x3e78d40*/ CapsuleCollider();
        /*0x3e78708*/ UnityEngine.Vector3 get_center();
        /*0x3e787e4*/ void set_center(UnityEngine.Vector3 value);
        /*0x3e788b8*/ float get_radius();
        /*0x3e7896c*/ void set_radius(float value);
        /*0x3e78a40*/ float get_height();
        /*0x3e78af4*/ void set_height(float value);
        /*0x3e78bc8*/ int get_direction();
        /*0x3e78c7c*/ void set_direction(int value);
    }

    class ControllerColliderHit
    {
        /*0x10*/ UnityEngine.CharacterController m_Controller;
        /*0x18*/ UnityEngine.Collider m_Collider;
        /*0x20*/ UnityEngine.Vector3 m_Point;
        /*0x2c*/ UnityEngine.Vector3 m_Normal;
        /*0x38*/ UnityEngine.Vector3 m_MoveDirection;
        /*0x44*/ float m_MoveLength;
        /*0x48*/ int m_Push;
    }

    class CharacterController : UnityEngine.Collider
    {
    }

    class Collider : UnityEngine.Component
    {
        static /*0x3e78dc0*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x3e78e7c*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x3e78f54*/ nint get_attachedRigidbody_Injected(nint _unity_self);
        static /*0x3e79010*/ void set_isTrigger_Injected(nint _unity_self, bool value);
        static /*0x3e790f8*/ void ClosestPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x3e791f0*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        /*0x3e78700*/ Collider();
        /*0x3e78d48*/ bool get_enabled();
        /*0x3e78dfc*/ void set_enabled(bool value);
        /*0x3e78ec0*/ UnityEngine.Rigidbody get_attachedRigidbody();
        /*0x3e78f90*/ void set_isTrigger(bool value);
        /*0x3e79054*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position);
        /*0x3e7914c*/ UnityEngine.Bounds get_bounds();
    }

    class Physics
    {
        static /*0x0*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        static /*0x8*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;
        static /*0x10*/ System.Action<UnityEngine.PhysicsScene, nint, int, bool> GenericContactModifyEvent;
        static /*0x18*/ UnityEngine.Physics.ContactEventDelegate ContactEvent;
        static /*0x20*/ UnityEngine.Collision s_ReusableCollision;

        static /*0x3e7c198*/ Physics();
        static /*0x3e79234*/ void OnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x3e792e8*/ void PhysXOnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x3e793dc*/ bool get_invokeCollisionCallbacks();
        static /*0x3e79404*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x3e794bc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e79768*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x3e79830*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x3e798fc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x3e799b8*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e79c80*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x3e79d60*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x3e79e2c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x3e79ef8*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e79f94*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x3e7a034*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x3e7a0c0*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x3e7a14c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7a200*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x3e7a2b8*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x3e7a35c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x3e7a3f0*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7a5cc*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7a7e0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x3e7a890*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x3e7a93c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x3e7a9e0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7aa94*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x3e7ab44*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x3e7abe8*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x3e7ac84*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7af6c*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x3e7b008*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x3e7b0a8*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x3e7b138*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7b210*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x3e7b2ec*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x3e7b3b4*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x3e7b47c*/ UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7b59c*/ UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7b638*/ bool get_reuseCollisionCallbacks();
        static /*0x3e7b660*/ UnityEngine.Collider GetColliderByInstanceID(int instanceID);
        static /*0x3e7b72c*/ UnityEngine.Component GetBodyByInstanceID(int instanceID);
        static /*0x3e7b7f8*/ void SendOnCollisionEnter(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x3e7b8ec*/ void SendOnCollisionStay(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x3e7b9e0*/ void SendOnCollisionExit(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x3e7bad4*/ void OnSceneContact(UnityEngine.PhysicsScene scene, nint buffer, int count);
        static /*0x3e7bd08*/ void ReportContacts(Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> array);
        static /*0x3e7c054*/ UnityEngine.Collision GetCollisionToReport(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        static /*0x3e79480*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x3e7a550*/ void Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3e7b530*/ UnityEngine.Collider[] OverlapSphere_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7b6f0*/ nint GetColliderByInstanceID_Injected(int instanceID);
        static /*0x3e7b7bc*/ nint GetBodyByInstanceID_Injected(int instanceID);
        static /*0x3e7b8a8*/ void SendOnCollisionEnter_Injected(nint component, UnityEngine.Collision collision);
        static /*0x3e7b99c*/ void SendOnCollisionStay_Injected(nint component, UnityEngine.Collision collision);
        static /*0x3e7ba90*/ void SendOnCollisionExit_Injected(nint component, UnityEngine.Collision collision);

        class ContactEventDelegate : System.MulticastDelegate
        {
            /*0x3e7c268*/ ContactEventDelegate(object object, nint method);
            /*0x3e7c308*/ void Invoke(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> headerArray);
        }
    }

    struct ModifiableContactPair
    {
        /*0x10*/ nint actor;
        /*0x18*/ nint otherActor;
        /*0x20*/ nint shape;
        /*0x28*/ nint otherShape;
        /*0x30*/ UnityEngine.Quaternion rotation;
        /*0x40*/ UnityEngine.Vector3 position;
        /*0x4c*/ UnityEngine.Quaternion otherRotation;
        /*0x5c*/ UnityEngine.Vector3 otherPosition;
        /*0x68*/ int numContacts;
        /*0x70*/ nint contacts;
    }

    enum MeshColliderCookingOptions
    {
        None = 0,
        InflateConvexMesh = 1,
        CookForFasterSimulation = 2,
        EnableMeshCleaning = 4,
        WeldColocatedVertices = 8,
        UseFastMidphase = 16,
    }

    class MeshCollider : UnityEngine.Collider
    {
        static /*0x3e7c3b4*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x3e7c4a4*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x3e7c560*/ bool get_convex_Injected(nint _unity_self);
        static /*0x3e7c61c*/ void set_convex_Injected(nint _unity_self, bool value);
        static /*0x3e7c6d8*/ UnityEngine.MeshColliderCookingOptions get_cookingOptions_Injected(nint _unity_self);
        static /*0x3e7c794*/ void set_cookingOptions_Injected(nint _unity_self, UnityEngine.MeshColliderCookingOptions value);
        /*0x3e7c7fc*/ MeshCollider();
        /*0x3e7c320*/ UnityEngine.Mesh get_sharedMesh();
        /*0x3e7c3f0*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x3e7c4e8*/ bool get_convex();
        /*0x3e7c59c*/ void set_convex(bool value);
        /*0x3e7c660*/ UnityEngine.MeshColliderCookingOptions get_cookingOptions();
        /*0x3e7c714*/ void set_cookingOptions(UnityEngine.MeshColliderCookingOptions value);
        /*0x3e7c7d8*/ bool get_smoothSphereCollisions();
        /*0x3e7c7e0*/ void set_smoothSphereCollisions(bool value);
        /*0x3e7c7e4*/ float get_skinWidth();
        /*0x3e7c7ec*/ void set_skinWidth(float value);
        /*0x3e7c7f0*/ bool get_inflateMesh();
        /*0x3e7c7f8*/ void set_inflateMesh(bool value);
    }

    enum QueryTriggerInteraction
    {
        UseGlobal = 0,
        Ignore = 1,
        Collide = 2,
    }

    struct ContactPairHeader
    {
        /*0x10*/ int m_BodyID;
        /*0x14*/ int m_OtherBodyID;
        /*0x18*/ nint m_StartPtr;
        /*0x20*/ uint m_NbPairs;
        /*0x24*/ UnityEngine.CollisionPairHeaderFlags m_Flags;
        /*0x28*/ UnityEngine.Vector3 m_RelativeVelocity;

        /*0x3e77ecc*/ UnityEngine.Component get_body();
        /*0x3e77e74*/ UnityEngine.Component get_otherBody();
        /*0x3e7c024*/ bool get_hasRemovedBody();
        /*0x3e7c034*/ ref UnityEngine.ContactPair GetContactPair(int index);
        /*0x3e7c804*/ UnityEngine.ContactPair* GetContactPair_Internal(int index);
    }

    struct ContactPair
    {
        /*0x10*/ int m_ColliderID;
        /*0x14*/ int m_OtherColliderID;
        /*0x18*/ nint m_StartPtr;
        /*0x20*/ uint m_NbPoints;
        /*0x24*/ UnityEngine.CollisionPairFlags m_Flags;
        /*0x26*/ UnityEngine.CollisionPairEventFlags m_Events;
        /*0x28*/ UnityEngine.Vector3 m_ImpulseSum;

        /*0x3e77fa8*/ UnityEngine.Collider get_collider();
        /*0x3e77f3c*/ UnityEngine.Collider get_otherCollider();
        /*0x3e7c048*/ bool get_isCollisionEnter();
        /*0x3e7c18c*/ bool get_isCollisionExit();
        /*0x3e7c180*/ bool get_isCollisionStay();
        /*0x3e7c038*/ bool get_hasRemovedCollider();
        /*0x3e781dc*/ int ExtractContactsArray(UnityEngine.ContactPoint[] managedContainer, bool flipped);
        /*0x3e7c884*/ ref UnityEngine.ContactPairPoint GetContactPoint(int index);
        /*0x3e7c888*/ UnityEngine.ContactPairPoint* GetContactPoint_Internal(int index);
    }

    struct ContactPairPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Position;
        /*0x1c*/ float m_Separation;
        /*0x20*/ UnityEngine.Vector3 m_Normal;
        /*0x2c*/ uint m_InternalFaceIndex0;
        /*0x30*/ UnityEngine.Vector3 m_Impulse;
        /*0x3c*/ uint m_InternalFaceIndex1;

        /*0x3e7c908*/ UnityEngine.Vector3 get_position();
        /*0x3e7c914*/ float get_separation();
        /*0x3e7c91c*/ UnityEngine.Vector3 get_normal();
        /*0x3e7c928*/ UnityEngine.Vector3 get_impulse();
    }

    enum CollisionPairHeaderFlags
    {
        RemovedActor = 1,
        RemovedOtherActor = 2,
    }

    enum CollisionPairFlags
    {
        RemovedShape = 1,
        RemovedOtherShape = 2,
        ActorPairHasFirstTouch = 4,
        ActorPairLostTouch = 8,
        InternalHasImpulses = 16,
        InternalContactsAreFlipped = 32,
    }

    enum CollisionPairEventFlags
    {
        SolveContacts = 1,
        ModifyContacts = 2,
        NotifyTouchFound = 4,
        NotifyTouchPersists = 8,
        NotifyTouchLost = 16,
        NotifyTouchCCD = 32,
        NotifyThresholdForceFound = 64,
        NotifyThresholdForcePersists = 128,
        NotifyThresholdForceLost = 256,
        NotifyContactPoint = 512,
        DetectDiscreteContact = 1024,
        DetectCCDContact = 2048,
        PreSolverVelocity = 4096,
        PostSolverVelocity = 8192,
        ContactEventPose = 16384,
        NextFree = 32768,
        ContactDefault = 1025,
        TriggerDefault = 1044,
    }

    struct PhysicsScene : System.IEquatable<UnityEngine.PhysicsScene>
    {
        /*0x10*/ int m_Handle;

        static /*0x3e7caa8*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7cb90*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7cc88*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7cb24*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7cc0c*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x3e7cd90*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, ref UnityEngine.Bindings.ManagedSpanWrapper raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x3e7c934*/ string ToString();
        /*0x3e7ca18*/ int GetHashCode();
        /*0x3e7ca20*/ bool Equals(object other);
        /*0x3e7ca98*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0x3e79598*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x3e79a94*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x3e7ad34*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    struct RaycastHit
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ uint m_FaceID;
        /*0x2c*/ float m_Distance;
        /*0x30*/ UnityEngine.Vector2 m_UV;
        /*0x38*/ int m_Collider;

        /*0x3e7ce0c*/ UnityEngine.Collider get_collider();
        /*0x3e7ceb8*/ UnityEngine.Vector3 get_point();
        /*0x3e7cec4*/ UnityEngine.Vector3 get_normal();
        /*0x3e7ced0*/ float get_distance();
        /*0x3e7ced8*/ UnityEngine.Transform get_transform();
        /*0x3e7cfb0*/ UnityEngine.Rigidbody get_rigidbody();
    }

    class Rigidbody : UnityEngine.Component
    {
        static /*0x3e7d0dc*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e7d1b4*/ void get_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3e7d288*/ void set_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x3e7d35c*/ void MovePosition_Injected(nint _unity_self, ref UnityEngine.Vector3 position);
        static /*0x3e7d430*/ void MoveRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion rot);
        /*0x3e7d044*/ UnityEngine.Vector3 get_position();
        /*0x3e7d120*/ UnityEngine.Quaternion get_rotation();
        /*0x3e7d1f8*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x3e7d2cc*/ void MovePosition(UnityEngine.Vector3 position);
        /*0x3e7d3a0*/ void MoveRotation(UnityEngine.Quaternion rot);
    }

    class SphereCollider : UnityEngine.Collider
    {
        static /*0x3e7d50c*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e7d5e0*/ void set_center_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e7d69c*/ float get_radius_Injected(nint _unity_self);
        static /*0x3e7d760*/ void set_radius_Injected(nint _unity_self, float value);
        /*0x3e7d7ac*/ SphereCollider();
        /*0x3e7d474*/ UnityEngine.Vector3 get_center();
        /*0x3e7d550*/ void set_center(UnityEngine.Vector3 value);
        /*0x3e7d624*/ float get_radius();
        /*0x3e7d6d8*/ void set_radius(float value);
    }
}
