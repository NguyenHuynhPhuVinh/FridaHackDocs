class <Module>
{
}

namespace UnityEngine
{
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

    class Collision
    {
        /*0x10*/ UnityEngine.ContactPairHeader m_Header;
        /*0x38*/ UnityEngine.ContactPair m_Pair;
        /*0x60*/ bool m_Flipped;
        /*0x68*/ UnityEngine.ContactPoint[] m_LegacyContacts;

        /*0x164a7b0*/ Collision();
        /*0x164a6b0*/ Collision(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        /*0x164a810*/ void set_Flipped(bool value);
        /*0x164a650*/ void Reuse(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair);
    }

    enum QueryTriggerInteraction
    {
        UseGlobal = 0,
        Ignore = 1,
        Collide = 2,
    }

    class Physics
    {
        static /*0x0*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        static /*0x8*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;
        static /*0x10*/ UnityEngine.Physics.ContactEventDelegate ContactEvent;
        static /*0x18*/ UnityEngine.Collision s_ReusableCollision;

        static /*0x164e2b0*/ Physics();
        static /*0x164b700*/ void OnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x164e420*/ bool get_invokeCollisionCallbacks();
        static /*0x164e3b0*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x164d070*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164cd00*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x164dac0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x164d7a0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x164d6c0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164d140*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x164cc30*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x164cea0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x164d5f0*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164d210*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x164d3a0*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x164dc50*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x164d9e0*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164cf70*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x164d530*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x164d920*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x164b660*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164bb90*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164bae0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x164be00*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x164bea0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x164bd50*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164ba40*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x164b9a0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x164bf40*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x164c780*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164c2d0*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x164bfd0*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x164c150*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x164c910*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164c5f0*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x164c460*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x164caa0*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x164e450*/ bool get_reuseCollisionCallbacks();
        static /*0x164b380*/ UnityEngine.Collider GetColliderByInstanceID(int instanceID);
        static /*0x164b340*/ UnityEngine.Component GetBodyByInstanceID(int instanceID);
        static /*0x164e1c0*/ void SendOnCollisionEnter(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x164e260*/ void SendOnCollisionStay(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x164e210*/ void SendOnCollisionExit(UnityEngine.Component component, UnityEngine.Collision collision);
        static /*0x164b800*/ void OnSceneContact(UnityEngine.PhysicsScene scene, nint buffer, int count);
        static /*0x164dde0*/ void ReportContacts(Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> array);
        static /*0x164b3c0*/ UnityEngine.Collision GetCollisionToReport(ref UnityEngine.ContactPairHeader header, ref UnityEngine.ContactPair pair, bool flipped);
        static /*0x164e370*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x164b5f0*/ UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);

        class ContactEventDelegate : System.MulticastDelegate
        {
            /*0x723170*/ ContactEventDelegate(object object, nint method);
            /*0x722210*/ void Invoke(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray.ReadOnly<UnityEngine.ContactPairHeader> headerArray);
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

    struct RaycastHit
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ uint m_FaceID;
        /*0x2c*/ float m_Distance;
        /*0x30*/ UnityEngine.Vector2 m_UV;
        /*0x38*/ int m_Collider;

        /*0x164e480*/ UnityEngine.Collider get_collider();
        /*0x15bd3e0*/ UnityEngine.Vector3 get_point();
        /*0x15bd400*/ UnityEngine.Vector3 get_normal();
        /*0x1644ec0*/ float get_distance();
    }

    class Collider : UnityEngine.Component
    {
        /*0x15b84e0*/ Collider();
        /*0x164a610*/ bool get_enabled();
        /*0x164a5b0*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position);
        /*0x164a550*/ void ClosestPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
    }

    class CharacterController : UnityEngine.Collider
    {
    }

    class MeshCollider : UnityEngine.Collider
    {
    }

    class CapsuleCollider : UnityEngine.Collider
    {
    }

    class BoxCollider : UnityEngine.Collider
    {
    }

    class SphereCollider : UnityEngine.Collider
    {
    }

    struct ContactPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ UnityEngine.Vector3 m_Impulse;
        /*0x34*/ int m_ThisColliderInstanceID;
        /*0x38*/ int m_OtherColliderInstanceID;
        /*0x3c*/ float m_Separation;
    }

    struct PhysicsScene : System.IEquatable<UnityEngine.PhysicsScene>
    {
        /*0x10*/ int m_Handle;

        static /*0x164ad10*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164adf0*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164ac30*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164aca0*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164ad80*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x164abc0*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x164b260*/ string ToString();
        /*0x15d3b80*/ int GetHashCode();
        /*0x164ab40*/ bool Equals(object other);
        /*0x15e9590*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0x164afa0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x164b0f0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x164ae60*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    struct ContactPairHeader
    {
        /*0x10*/ int m_BodyID;
        /*0x14*/ int m_OtherBodyID;
        /*0x18*/ nint m_StartPtr;
        /*0x20*/ uint m_NbPairs;
        /*0x24*/ UnityEngine.CollisionPairHeaderFlags m_Flags;
        /*0x28*/ UnityEngine.Vector3 m_RelativeVelocity;

        /*0x164a8b0*/ UnityEngine.Component get_Body();
        /*0x164a940*/ UnityEngine.Component get_OtherBody();
        /*0x164a920*/ bool get_HasRemovedBody();
        /*0x164a8a0*/ ref UnityEngine.ContactPair GetContactPair(int index);
        /*0x164a820*/ UnityEngine.ContactPair* GetContactPair_Internal(int index);
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

        static /*0x164a9b0*/ int ExtractContactsArray_Injected(ref UnityEngine.ContactPair _unity_self, UnityEngine.ContactPoint[] managedContainer, bool flipped);
        /*0x164aa10*/ UnityEngine.Collider get_Collider();
        /*0x164aac0*/ UnityEngine.Collider get_OtherCollider();
        /*0x164aa90*/ bool get_IsCollisionEnter();
        /*0x164aaa0*/ bool get_IsCollisionExit();
        /*0x164aab0*/ bool get_IsCollisionStay();
        /*0x164a920*/ bool get_HasRemovedCollider();
        /*0x164a9b0*/ int ExtractContactsArray(UnityEngine.ContactPoint[] managedContainer, bool flipped);
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
}
