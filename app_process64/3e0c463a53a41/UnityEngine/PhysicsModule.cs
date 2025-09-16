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

        /*0x7efaaac*/ UnityEngine.Vector3 get_point();
        /*0x7efaab8*/ UnityEngine.Vector3 get_normal();
    }

    class Collision
    {
        /*0x10*/ UnityEngine.ContactPairHeader m_Header;
        /*0x38*/ UnityEngine.ContactPair m_Pair;
        /*0x60*/ bool m_Flipped;
        /*0x68*/ UnityEngine.ContactPoint[] m_LegacyContacts;

        /*0x7efaf08*/ Collision();
        /*0x7efaf60*/ Collision(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        /*0x7efaac4*/ UnityEngine.Vector3 get_relativeVelocity();
        /*0x7efaaf0*/ UnityEngine.Component get_body();
        /*0x7efabb4*/ UnityEngine.Collider get_collider();
        /*0x7efaca0*/ UnityEngine.GameObject get_gameObject();
        /*0x7efad34*/ void set_Flipped(bool value);
        /*0x7efad40*/ UnityEngine.ContactPoint[] get_contacts();
        /*0x7efb034*/ void Reuse(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair);
    }

    class BoxCollider : UnityEngine.Collider
    {
        static /*0x7efb110*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7efb1ec*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        /*0x7efb078*/ UnityEngine.Vector3 get_center();
        /*0x7efb154*/ UnityEngine.Vector3 get_size();
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
        static /*0x7efb2a8*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x7efb378*/ nint get_attachedRigidbody_Injected(nint _unity_self);
        static /*0x7efb434*/ void set_isTrigger_Injected(nint _unity_self, bool value);
        static /*0x7efb51c*/ void ClosestPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7efb614*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7efb728*/ void Raycast_Injected(nint _unity_self, ref UnityEngine.Ray ray, float maxDistance, ref bool hasHit, ref UnityEngine.RaycastHit ret);
        /*0x7efb7e4*/ Collider();
        /*0x7efb230*/ bool get_enabled();
        /*0x7efb2e4*/ UnityEngine.Rigidbody get_attachedRigidbody();
        /*0x7efb3b4*/ void set_isTrigger(bool value);
        /*0x7efb478*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position);
        /*0x7efb570*/ UnityEngine.Bounds get_bounds();
        /*0x7efb658*/ UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, float maxDistance, ref bool hasHit);
        /*0x7efb794*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
    }

    class Physics
    {
        static /*0x0*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        static /*0x8*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;
        static /*0x10*/ System.Action<UnityEngine.PhysicsScene, nint, int, bool> GenericContactModifyEvent;
        static /*0x18*/ UnityEngine.Physics.ContactEventDelegate ContactEvent;
        static /*0x20*/ UnityEngine.Collision s_ReusableCollision;

        static /*0x7efec90*/ Physics();
        static /*0x7efb7ec*/ void OnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x7efb898*/ void PhysXOnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x7efb97c*/ bool get_invokeCollisionCallbacks();
        static /*0x7efb9a4*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x7efba5c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efbd08*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x7efbdd0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x7efbe9c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x7efbf58*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efc220*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x7efc300*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x7efc3cc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x7efc498*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efc534*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x7efc5d4*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x7efc660*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x7efc6ec*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efc7a0*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x7efc858*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x7efc8fc*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x7efc990*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efcb5c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efcd80*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x7efce30*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x7efcedc*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x7efcf80*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efd034*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x7efd0e4*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x7efd188*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x7efd224*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efd500*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x7efd59c*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x7efd63c*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x7efd6cc*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efd7a4*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x7efd880*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x7efd948*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x7efda10*/ bool get_reuseCollisionCallbacks();
        static /*0x7efda38*/ bool Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x7efdc60*/ bool ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x7efdd88*/ int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efde34*/ int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efe03c*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7efe110*/ UnityEngine.Collider GetColliderByInstanceID(int instanceID);
        static /*0x7efe1dc*/ UnityEngine.Component GetBodyByInstanceID(int instanceID);
        static /*0x7efe2a8*/ void SendOnCollisionEnter(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x7efe39c*/ void SendOnCollisionStay(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x7efe490*/ void SendOnCollisionExit(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x7efe584*/ void OnSceneContact(UnityEngine.PhysicsScene scene, nint buffer, int count);
        static /*0x7efe7e0*/ void ReportContacts(Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> array);
        static /*0x7efeb48*/ UnityEngine.Collision GetCollisionToReport(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        static /*0x7efba20*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x7efcae0*/ void Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7efdbd4*/ bool Query_ComputePenetration_Injected(nint colliderA, ref UnityEngine.Vector3 positionA, ref UnityEngine.Quaternion rotationA, nint colliderB, ref UnityEngine.Vector3 positionB, ref UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x7efe1a0*/ nint GetColliderByInstanceID_Injected(int instanceID);
        static /*0x7efe26c*/ nint GetBodyByInstanceID_Injected(int instanceID);
        static /*0x7efe358*/ void SendOnCollisionEnter_Injected(nint component, UnityEngine.Collision collision);
        static /*0x7efe44c*/ void SendOnCollisionStay_Injected(nint component, UnityEngine.Collision collision);
        static /*0x7efe540*/ void SendOnCollisionExit_Injected(nint component, UnityEngine.Collision collision);

        class ContactEventDelegate : System.MulticastDelegate
        {
            /*0x7efed60*/ ContactEventDelegate(object object, nint method);
            /*0x7efee00*/ void Invoke(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> headerArray);
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
        static /*0x7efeeac*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x7efef9c*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x7eff058*/ bool get_convex_Injected(nint _unity_self);
        static /*0x7eff114*/ void set_convex_Injected(nint _unity_self, bool value);
        static /*0x7eff1d0*/ UnityEngine.MeshColliderCookingOptions get_cookingOptions_Injected(nint _unity_self);
        static /*0x7eff28c*/ void set_cookingOptions_Injected(nint _unity_self, UnityEngine.MeshColliderCookingOptions value);
        /*0x7eff2f4*/ MeshCollider();
        /*0x7efee18*/ UnityEngine.Mesh get_sharedMesh();
        /*0x7efeee8*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x7efefe0*/ bool get_convex();
        /*0x7eff094*/ void set_convex(bool value);
        /*0x7eff158*/ UnityEngine.MeshColliderCookingOptions get_cookingOptions();
        /*0x7eff20c*/ void set_cookingOptions(UnityEngine.MeshColliderCookingOptions value);
        /*0x7eff2d0*/ bool get_smoothSphereCollisions();
        /*0x7eff2d8*/ void set_smoothSphereCollisions(bool value);
        /*0x7eff2dc*/ float get_skinWidth();
        /*0x7eff2e4*/ void set_skinWidth(float value);
        /*0x7eff2e8*/ bool get_inflateMesh();
        /*0x7eff2f0*/ void set_inflateMesh(bool value);
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

        /*0x7efab5c*/ UnityEngine.Component get_body();
        /*0x7efab04*/ UnityEngine.Component get_otherBody();
        /*0x7efeb18*/ bool get_hasRemovedBody();
        /*0x7efeb28*/ ref UnityEngine.ContactPair GetContactPair(int index);
        /*0x7eff2fc*/ UnityEngine.ContactPair* GetContactPair_Internal(int index);
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

        /*0x7efac34*/ UnityEngine.Collider get_collider();
        /*0x7efabc8*/ UnityEngine.Collider get_otherCollider();
        /*0x7efeb3c*/ bool get_isCollisionEnter();
        /*0x7efec84*/ bool get_isCollisionExit();
        /*0x7efec78*/ bool get_isCollisionStay();
        /*0x7efeb2c*/ bool get_hasRemovedCollider();
        /*0x7efadc0*/ int ExtractContactsArray(UnityEngine.ContactPoint[] managedContainer, bool flipped);
        /*0x7eff37c*/ ref UnityEngine.ContactPairPoint GetContactPoint(int index);
        /*0x7eff380*/ UnityEngine.ContactPairPoint* GetContactPoint_Internal(int index);
    }

    struct ContactPairPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Position;
        /*0x1c*/ float m_Separation;
        /*0x20*/ UnityEngine.Vector3 m_Normal;
        /*0x2c*/ uint m_InternalFaceIndex0;
        /*0x30*/ UnityEngine.Vector3 m_Impulse;
        /*0x3c*/ uint m_InternalFaceIndex1;

        /*0x7eff400*/ UnityEngine.Vector3 get_position();
        /*0x7eff40c*/ float get_separation();
        /*0x7eff414*/ UnityEngine.Vector3 get_normal();
        /*0x7eff420*/ UnityEngine.Vector3 get_impulse();
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

        static /*0x7eff5a0*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff688*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff780*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff900*/ int OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7effa14*/ int Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7effbbc*/ int OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff61c*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff704*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff884*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, ref UnityEngine.Bindings.ManagedSpanWrapper raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7eff990*/ int OverlapCapsuleNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point0, ref UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7effb30*/ int Internal_SphereCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, ref UnityEngine.Bindings.ManagedSpanWrapper raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x7effc40*/ int OverlapSphereNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7eff42c*/ string ToString();
        /*0x7eff510*/ int GetHashCode();
        /*0x7eff518*/ bool Equals(object other);
        /*0x7eff590*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0x7efbb38*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7efc034*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7efd2d4*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7efe108*/ int OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7efdf1c*/ int SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x7efde2c*/ int OverlapSphere(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    struct RaycastHit
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ uint m_FaceID;
        /*0x2c*/ float m_Distance;
        /*0x30*/ UnityEngine.Vector2 m_UV;
        /*0x38*/ int m_Collider;

        /*0x7effcbc*/ UnityEngine.Collider get_collider();
        /*0x7effd68*/ UnityEngine.Vector3 get_point();
        /*0x7effd74*/ void set_point(UnityEngine.Vector3 value);
        /*0x7effd80*/ UnityEngine.Vector3 get_normal();
        /*0x7effd8c*/ void set_normal(UnityEngine.Vector3 value);
        /*0x7effd98*/ float get_distance();
        /*0x7effda0*/ void set_distance(float value);
    }

    class Rigidbody : UnityEngine.Component
    {
        static /*0x7effe40*/ void get_linearVelocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7effefc*/ float get_mass_Injected(nint _unity_self);
        static /*0x7efffb8*/ void set_isKinematic_Injected(nint _unity_self, bool value);
        static /*0x7f0007c*/ void set_detectCollisions_Injected(nint _unity_self, bool value);
        static /*0x7f00158*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f0022c*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7f00304*/ void get_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7f003d8*/ void set_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7f004ac*/ void MovePosition_Injected(nint _unity_self, ref UnityEngine.Vector3 position);
        static /*0x7f00580*/ void MoveRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion rot);
        /*0x7f005c4*/ Rigidbody();
        /*0x7effda8*/ UnityEngine.Vector3 get_linearVelocity();
        /*0x7effe84*/ float get_mass();
        /*0x7efff38*/ void set_isKinematic(bool value);
        /*0x7effffc*/ void set_detectCollisions(bool value);
        /*0x7f000c0*/ UnityEngine.Vector3 get_position();
        /*0x7f0019c*/ void set_position(UnityEngine.Vector3 value);
        /*0x7f00270*/ UnityEngine.Quaternion get_rotation();
        /*0x7f00348*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x7f0041c*/ void MovePosition(UnityEngine.Vector3 position);
        /*0x7f004f0*/ void MoveRotation(UnityEngine.Quaternion rot);
    }

    class SphereCollider : UnityEngine.Collider
    {
        static /*0x7f00664*/ void get_center_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f00720*/ float get_radius_Injected(nint _unity_self);
        static /*0x7f007e4*/ void set_radius_Injected(nint _unity_self, float value);
        /*0x7f00830*/ SphereCollider();
        /*0x7f005cc*/ UnityEngine.Vector3 get_center();
        /*0x7f006a8*/ float get_radius();
        /*0x7f0075c*/ void set_radius(float value);
    }
}
