class <Module>
{
}

namespace UnityEngine
{
    class Physics
    {
        static /*0x0*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        static /*0x8*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;

        static /*0x18105ec*/ void OnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x18106b8*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x1810738*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1810954*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x1810a18*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x1810ad0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x1810b80*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1810dc0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x1810e8c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x1810f54*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x1811014*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x18110e4*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x18111a8*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x1811268*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x1811328*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1811400*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x181147c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x1811544*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x181160c*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x18116f0*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1811890*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x1811898*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x18118a4*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x18118b8*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1811930*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x18119a4*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x1811a0c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x1811a74*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1811d24*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x1811df4*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x1811eb8*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x1811f7c*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1812050*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x1812118*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x18121dc*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x18106fc*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x1811684*/ UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
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

        /*0x1812298*/ UnityEngine.Collider get_collider();
        /*0x1812344*/ UnityEngine.Vector3 get_point();
        /*0x1812350*/ UnityEngine.Vector3 get_normal();
        /*0x181235c*/ float get_distance();
    }

    class Rigidbody : UnityEngine.Component
    {
        /*0x1812364*/ UnityEngine.Vector3 get_velocity();
        /*0x1812404*/ void set_velocity(UnityEngine.Vector3 value);
        /*0x181249c*/ UnityEngine.Vector3 get_angularVelocity();
        /*0x181253c*/ void set_angularVelocity(UnityEngine.Vector3 value);
        /*0x18125d4*/ void set_useGravity(bool value);
        /*0x1812618*/ void set_isKinematic(bool value);
        /*0x181265c*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x18126f4*/ void MovePosition(UnityEngine.Vector3 position);
        /*0x181278c*/ void MoveRotation(UnityEngine.Quaternion rot);
        /*0x1812824*/ void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode);
        /*0x18128d4*/ void AddForce(UnityEngine.Vector3 force);
        /*0x18128dc*/ void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, UnityEngine.ForceMode mode);
        /*0x18129dc*/ void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius);
        /*0x18123c0*/ void get_velocity_Injected(ref UnityEngine.Vector3 ret);
        /*0x1812458*/ void set_velocity_Injected(ref UnityEngine.Vector3 value);
        /*0x18124f8*/ void get_angularVelocity_Injected(ref UnityEngine.Vector3 ret);
        /*0x1812590*/ void set_angularVelocity_Injected(ref UnityEngine.Vector3 value);
        /*0x18126b0*/ void set_rotation_Injected(ref UnityEngine.Quaternion value);
        /*0x1812748*/ void MovePosition_Injected(ref UnityEngine.Vector3 position);
        /*0x18127e0*/ void MoveRotation_Injected(ref UnityEngine.Quaternion rot);
        /*0x1812880*/ void AddForce_Injected(ref UnityEngine.Vector3 force, UnityEngine.ForceMode mode);
        /*0x1812960*/ void AddExplosionForce_Injected(float explosionForce, ref UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, UnityEngine.ForceMode mode);
    }

    class MeshCollider : UnityEngine.Collider
    {
    }

    class BoxCollider : UnityEngine.Collider
    {
    }

    class CharacterJoint : UnityEngine.Joint
    {
    }

    class Collision
    {
        /*0x10*/ UnityEngine.Vector3 m_Impulse;
        /*0x1c*/ UnityEngine.Vector3 m_RelativeVelocity;
        /*0x28*/ UnityEngine.Component m_Body;
        /*0x30*/ UnityEngine.Collider m_Collider;
        /*0x38*/ int m_ContactCount;
        /*0x40*/ UnityEngine.ContactPoint[] m_ReusedContacts;
        /*0x48*/ UnityEngine.ContactPoint[] m_LegacyContacts;
    }

    class Collider : UnityEngine.Component
    {
        /*0x18129e8*/ void set_enabled(bool value);
        /*0x1812a2c*/ UnityEngine.Bounds get_bounds();
        /*0x1812a94*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
    }

    class CharacterController : UnityEngine.Collider
    {
        /*0x1812ad8*/ UnityEngine.CollisionFlags Move(UnityEngine.Vector3 motion);
        /*0x1812b2c*/ UnityEngine.CollisionFlags Move_Injected(ref UnityEngine.Vector3 motion);
    }

    class CapsuleCollider : UnityEngine.Collider
    {
        /*0x1812b70*/ void set_height(float value);
    }

    class SphereCollider : UnityEngine.Collider
    {
    }

    class Joint : UnityEngine.Component
    {
    }

    struct ContactPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ int m_ThisColliderInstanceID;
        /*0x2c*/ int m_OtherColliderInstanceID;
        /*0x30*/ float m_Separation;
    }

    struct PhysicsScene : System.IEquatable<UnityEngine.PhysicsScene>
    {
        /*0x10*/ int m_Handle;

        static /*0x1812d30*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1812e18*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1812f10*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1812dac*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1812e94*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x1812f88*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x1812bbc*/ string ToString();
        /*0x1812ca0*/ int GetHashCode();
        /*0x1812ca8*/ bool Equals(object other);
        /*0x1812d20*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0x1810800*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x1810c58*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x1811b48*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    enum ForceMode
    {
        Force = 0,
        Acceleration = 5,
        Impulse = 1,
        VelocityChange = 2,
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

    enum CollisionFlags
    {
        None = 0,
        Sides = 1,
        Above = 2,
        Below = 4,
        CollidedSides = 1,
        CollidedAbove = 2,
        CollidedBelow = 4,
    }

    enum QueryTriggerInteraction
    {
        UseGlobal = 0,
        Ignore = 1,
        Collide = 2,
    }
}
