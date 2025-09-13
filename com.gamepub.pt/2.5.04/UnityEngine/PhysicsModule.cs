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
        /*0x10*/ UnityEngine.Vector3 m_Impulse;
        /*0x1c*/ UnityEngine.Vector3 m_RelativeVelocity;
        /*0x28*/ UnityEngine.Component m_Body;
        /*0x30*/ UnityEngine.Collider m_Collider;
        /*0x38*/ int m_ContactCount;
        /*0x40*/ UnityEngine.ContactPoint[] m_ReusedContacts;
        /*0x48*/ UnityEngine.ContactPoint[] m_LegacyContacts;
    }

    enum QueryTriggerInteraction
    {
        UseGlobal = 0,
        Ignore = 1,
        Collide = 2,
    }

    struct RaycastHit
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ uint m_FaceID;
        /*0x2c*/ float m_Distance;
        /*0x30*/ UnityEngine.Vector2 m_UV;
        /*0x38*/ int m_Collider;

        /*0xb4f5cc*/ UnityEngine.Collider get_collider();
        /*0xb4f5d4*/ UnityEngine.Vector3 get_point();
        /*0xb4f5e0*/ UnityEngine.Vector3 get_normal();
        /*0xb4f5ec*/ float get_distance();
    }

    class Rigidbody : UnityEngine.Component
    {
        /*0x2b275c8*/ void set_velocity(UnityEngine.Vector3 value);
        /*0x2b27670*/ void set_useGravity(bool value);
        /*0x2b276c0*/ UnityEngine.Vector3 get_position();
        /*0x2b27770*/ void set_position(UnityEngine.Vector3 value);
        /*0x2b27818*/ UnityEngine.Quaternion get_rotation();
        /*0x2b278c4*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x2b2796c*/ void MovePosition(UnityEngine.Vector3 position);
        /*0x2b27a14*/ void MoveRotation(UnityEngine.Quaternion rot);
        /*0x2b27620*/ void set_velocity_Injected(ref UnityEngine.Vector3 value);
        /*0x2b27720*/ void get_position_Injected(ref UnityEngine.Vector3 ret);
        /*0x2b277c8*/ void set_position_Injected(ref UnityEngine.Vector3 value);
        /*0x2b27874*/ void get_rotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x2b2791c*/ void set_rotation_Injected(ref UnityEngine.Quaternion value);
        /*0x2b279c4*/ void MovePosition_Injected(ref UnityEngine.Vector3 position);
        /*0x2b27a6c*/ void MoveRotation_Injected(ref UnityEngine.Quaternion rot);
    }

    class Collider : UnityEngine.Component
    {
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
        /*0x28*/ int m_ThisColliderInstanceID;
        /*0x2c*/ int m_OtherColliderInstanceID;
        /*0x30*/ float m_Separation;
    }

    struct PhysicsScene : System.IEquatable<UnityEngine.PhysicsScene>
    {
        /*0x10*/ int m_Handle;

        static /*0x2b271e4*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b272d4*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b273e4*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b2725c*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b27364*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b27470*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0xb4f58c*/ string ToString();
        /*0xb4f594*/ int GetHashCode();
        /*0xb4f59c*/ bool Equals(object other);
        /*0xb4f5a4*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0xb4f5b4*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0xb4f5bc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0xb4f5c4*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    class Physics
    {
        static /*0x2b25520*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x2b255a8*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b25784*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x2b2584c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x2b25910*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x2b259cc*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b25bc4*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x2b25c9c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x2b25d68*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x2b25e2c*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b25f00*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x2b25fd0*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x2b26094*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x2b26158*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b2623c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x2b262c4*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x2b26398*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x2b2646c*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b26558*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b266b4*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x2b266bc*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x2b266c8*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x2b266dc*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b26760*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x2b267d8*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x2b2684c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x2b268c0*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b26ab0*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x2b26b84*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x2b26c54*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x2b26d24*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2b26dfc*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x2b26ed0*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x2b26f98*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x2b25568*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x2b264e0*/ UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }
}
