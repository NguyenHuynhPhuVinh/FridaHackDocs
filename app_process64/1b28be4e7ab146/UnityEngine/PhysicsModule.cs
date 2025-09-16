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

        /*0x7f11edc*/ UnityEngine.Vector3 get_point();
        /*0x7f11ee8*/ UnityEngine.Vector3 get_normal();
    }

    class Collision
    {
        /*0x10*/ UnityEngine.ContactPairHeader m_Header;
        /*0x38*/ UnityEngine.ContactPair m_Pair;
        /*0x60*/ bool m_Flipped;
        /*0x68*/ UnityEngine.ContactPoint[] m_LegacyContacts;

        /*0x7f12338*/ Collision();
        /*0x7f12390*/ Collision(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        /*0x7f11ef4*/ UnityEngine.Vector3 get_relativeVelocity();
        /*0x7f11f20*/ UnityEngine.Component get_body();
        /*0x7f11fe4*/ UnityEngine.Collider get_collider();
        /*0x7f120d0*/ UnityEngine.GameObject get_gameObject();
        /*0x7f12164*/ void set_Flipped(bool value);
        /*0x7f12170*/ UnityEngine.ContactPoint[] get_contacts();
        /*0x7f12464*/ void Reuse(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair);
    }

    class BoxCollider : UnityEngine.Collider
    {
        static /*0x7f12540*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f1261c*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        /*0x7f124a8*/ UnityEngine.Vector3 get_center();
        /*0x7f12584*/ UnityEngine.Vector3 get_size();
    }

    class CapsuleCollider : UnityEngine.Collider
    {
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
        static /*0x7f126d8*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x7f127a8*/ nint get_attachedRigidbody_Injected(nint _unity_self);
        static /*0x7f12864*/ void set_isTrigger_Injected(nint _unity_self, bool value);
        static /*0x7f1294c*/ void ClosestPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7f12a44*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7f12b58*/ void Raycast_Injected(nint _unity_self, ref UnityEngine.Ray ray, float maxDistance, ref bool hasHit, ref UnityEngine.RaycastHit ret);
        /*0x7f12c14*/ Collider();
        /*0x7f12660*/ bool get_enabled();
        /*0x7f12714*/ UnityEngine.Rigidbody get_attachedRigidbody();
        /*0x7f127e4*/ void set_isTrigger(bool value);
        /*0x7f128a8*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position);
        /*0x7f129a0*/ UnityEngine.Bounds get_bounds();
        /*0x7f12a88*/ UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, float maxDistance, ref bool hasHit);
        /*0x7f12bc4*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
    }

    class Physics
    {
        static /*0x0*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        static /*0x8*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;
        static /*0x10*/ System.Action<UnityEngine.PhysicsScene, nint, int, bool> GenericContactModifyEvent;
        static /*0x18*/ UnityEngine.Physics.ContactEventDelegate ContactEvent;
        static /*0x20*/ UnityEngine.Collision s_ReusableCollision;

        static /*0x7f160c0*/ Physics();
        static /*0x7f12c1c*/ void OnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x7f12cc8*/ void PhysXOnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x7f12dac*/ bool get_invokeCollisionCallbacks();
        static /*0x7f12dd4*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x7f12e8c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f13138*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x7f13200*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x7f132cc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x7f13388*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f13650*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x7f13730*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x7f137fc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x7f138c8*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f13964*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x7f13a04*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x7f13a90*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x7f13b1c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f13bd0*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x7f13c88*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x7f13d2c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x7f13dc0*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f13f8c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f141b0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x7f14260*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x7f1430c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x7f143b0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f14464*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x7f14514*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x7f145b8*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x7f14654*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f14930*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x7f149cc*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x7f14a6c*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x7f14afc*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f14bd4*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x7f14cb0*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x7f14d78*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x7f14e40*/ bool get_reuseCollisionCallbacks();
        static /*0x7f14e68*/ bool Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x7f15090*/ bool ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x7f151b8*/ int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f15264*/ int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f1546c*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f15540*/ UnityEngine.Collider GetColliderByInstanceID(int instanceID);
        static /*0x7f1560c*/ UnityEngine.Component GetBodyByInstanceID(int instanceID);
        static /*0x7f156d8*/ void SendOnCollisionEnter(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x7f157cc*/ void SendOnCollisionStay(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x7f158c0*/ void SendOnCollisionExit(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x7f159b4*/ void OnSceneContact(UnityEngine.PhysicsScene scene, nint buffer, int count);
        static /*0x7f15c10*/ void ReportContacts(Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> array);
        static /*0x7f15f78*/ UnityEngine.Collision GetCollisionToReport(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        static /*0x7f12e50*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x7f13f10*/ void Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7f15004*/ bool Query_ComputePenetration_Injected(nint colliderA, ref UnityEngine.Vector3 positionA, ref UnityEngine.Quaternion rotationA, nint colliderB, ref UnityEngine.Vector3 positionB, ref UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x7f155d0*/ nint GetColliderByInstanceID_Injected(int instanceID);
        static /*0x7f1569c*/ nint GetBodyByInstanceID_Injected(int instanceID);
        static /*0x7f15788*/ void SendOnCollisionEnter_Injected(nint component, UnityEngine.Collision collision);
        static /*0x7f1587c*/ void SendOnCollisionStay_Injected(nint component, UnityEngine.Collision collision);
        static /*0x7f15970*/ void SendOnCollisionExit_Injected(nint component, UnityEngine.Collision collision);

        class ContactEventDelegate : System.MulticastDelegate
        {
            /*0x7f16190*/ ContactEventDelegate(object object, nint method);
            /*0x7f16230*/ void Invoke(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> headerArray);
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
        static /*0x7f162dc*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x7f163cc*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x7f16488*/ bool get_convex_Injected(nint _unity_self);
        static /*0x7f16544*/ void set_convex_Injected(nint _unity_self, bool value);
        static /*0x7f16600*/ UnityEngine.MeshColliderCookingOptions get_cookingOptions_Injected(nint _unity_self);
        static /*0x7f166bc*/ void set_cookingOptions_Injected(nint _unity_self, UnityEngine.MeshColliderCookingOptions value);
        /*0x7f16724*/ MeshCollider();
        /*0x7f16248*/ UnityEngine.Mesh get_sharedMesh();
        /*0x7f16318*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x7f16410*/ bool get_convex();
        /*0x7f164c4*/ void set_convex(bool value);
        /*0x7f16588*/ UnityEngine.MeshColliderCookingOptions get_cookingOptions();
        /*0x7f1663c*/ void set_cookingOptions(UnityEngine.MeshColliderCookingOptions value);
        /*0x7f16700*/ bool get_smoothSphereCollisions();
        /*0x7f16708*/ void set_smoothSphereCollisions(bool value);
        /*0x7f1670c*/ float get_skinWidth();
        /*0x7f16714*/ void set_skinWidth(float value);
        /*0x7f16718*/ bool get_inflateMesh();
        /*0x7f16720*/ void set_inflateMesh(bool value);
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

        /*0x7f11f8c*/ UnityEngine.Component get_body();
        /*0x7f11f34*/ UnityEngine.Component get_otherBody();
        /*0x7f15f48*/ bool get_hasRemovedBody();
        /*0x7f15f58*/ ref UnityEngine.ContactPair GetContactPair(int index);
        /*0x7f1672c*/ UnityEngine.ContactPair* GetContactPair_Internal(int index);
    }

    struct ContactPair
    {
        static uint c_InvalidFaceIndex = 4294967295;
        /*0x10*/ int m_ColliderID;
        /*0x14*/ int m_OtherColliderID;
        /*0x18*/ nint m_StartPtr;
        /*0x20*/ uint m_NbPoints;
        /*0x24*/ UnityEngine.CollisionPairFlags m_Flags;
        /*0x26*/ UnityEngine.CollisionPairEventFlags m_Events;
        /*0x28*/ UnityEngine.Vector3 m_ImpulseSum;

        /*0x7f12064*/ UnityEngine.Collider get_collider();
        /*0x7f11ff8*/ UnityEngine.Collider get_otherCollider();
        /*0x7f15f6c*/ bool get_isCollisionEnter();
        /*0x7f160b4*/ bool get_isCollisionExit();
        /*0x7f160a8*/ bool get_isCollisionStay();
        /*0x7f15f5c*/ bool get_hasRemovedCollider();
        /*0x7f121f0*/ int ExtractContactsArray(UnityEngine.ContactPoint[] managedContainer, bool flipped);
        /*0x7f167ac*/ ref UnityEngine.ContactPairPoint GetContactPoint(int index);
        /*0x7f167b0*/ UnityEngine.ContactPairPoint* GetContactPoint_Internal(int index);
    }

    struct ContactPairPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Position;
        /*0x1c*/ float m_Separation;
        /*0x20*/ UnityEngine.Vector3 m_Normal;
        /*0x2c*/ uint m_InternalFaceIndex0;
        /*0x30*/ UnityEngine.Vector3 m_Impulse;
        /*0x3c*/ uint m_InternalFaceIndex1;

        /*0x7f16830*/ UnityEngine.Vector3 get_position();
        /*0x7f1683c*/ float get_separation();
        /*0x7f16844*/ UnityEngine.Vector3 get_normal();
        /*0x7f16850*/ UnityEngine.Vector3 get_impulse();
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

        static /*0x7f169d0*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16ab8*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16bb0*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16d30*/ int OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16e44*/ int Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16fec*/ int OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16a4c*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16b34*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16cb4*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, ref UnityEngine.Bindings.ManagedSpanWrapper raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16dc0*/ int OverlapCapsuleNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point0, ref UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f16f60*/ int Internal_SphereCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, ref UnityEngine.Bindings.ManagedSpanWrapper raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7f17070*/ int OverlapSphereNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7f1685c*/ string ToString();
        /*0x7f16940*/ int GetHashCode();
        /*0x7f16948*/ bool Equals(object other);
        /*0x7f169c0*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0x7f12f68*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7f13464*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7f14704*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7f15538*/ int OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7f1534c*/ int SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7f1525c*/ int OverlapSphere(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    struct RaycastHit
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ uint m_FaceID;
        /*0x2c*/ float m_Distance;
        /*0x30*/ UnityEngine.Vector2 m_UV;
        /*0x38*/ int m_Collider;

        /*0x7f170ec*/ UnityEngine.Collider get_collider();
        /*0x7f17198*/ UnityEngine.Vector3 get_point();
        /*0x7f171a4*/ void set_point(UnityEngine.Vector3 value);
        /*0x7f171b0*/ UnityEngine.Vector3 get_normal();
        /*0x7f171bc*/ void set_normal(UnityEngine.Vector3 value);
        /*0x7f171c8*/ float get_distance();
        /*0x7f171d0*/ void set_distance(float value);
    }

    class Rigidbody : UnityEngine.Component
    {
        static /*0x7f17270*/ void get_linearVelocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f1732c*/ float get_mass_Injected(nint _unity_self);
        static /*0x7f173e8*/ void set_isKinematic_Injected(nint _unity_self, bool value);
        static /*0x7f174ac*/ void set_detectCollisions_Injected(nint _unity_self, bool value);
        static /*0x7f17588*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f1765c*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7f17734*/ void get_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7f17808*/ void set_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7f178dc*/ void MovePosition_Injected(nint _unity_self, ref UnityEngine.Vector3 position);
        static /*0x7f179b0*/ void MoveRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion rot);
        /*0x7f179f4*/ Rigidbody();
        /*0x7f171d8*/ UnityEngine.Vector3 get_linearVelocity();
        /*0x7f172b4*/ float get_mass();
        /*0x7f17368*/ void set_isKinematic(bool value);
        /*0x7f1742c*/ void set_detectCollisions(bool value);
        /*0x7f174f0*/ UnityEngine.Vector3 get_position();
        /*0x7f175cc*/ void set_position(UnityEngine.Vector3 value);
        /*0x7f176a0*/ UnityEngine.Quaternion get_rotation();
        /*0x7f17778*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x7f1784c*/ void MovePosition(UnityEngine.Vector3 position);
        /*0x7f17920*/ void MoveRotation(UnityEngine.Quaternion rot);
    }

    class SphereCollider : UnityEngine.Collider
    {
        static /*0x7f17a94*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f17b50*/ float get_radius_Injected(nint _unity_self);
        static /*0x7f17c14*/ void set_radius_Injected(nint _unity_self, float value);
        /*0x7f17c60*/ SphereCollider();
        /*0x7f179fc*/ UnityEngine.Vector3 get_center();
        /*0x7f17ad8*/ float get_radius();
        /*0x7f17b8c*/ void set_radius(float value);
    }
}
