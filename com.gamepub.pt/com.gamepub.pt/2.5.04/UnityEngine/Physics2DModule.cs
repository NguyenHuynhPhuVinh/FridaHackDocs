class <Module>
{
}

namespace UnityEngine
{
    struct PhysicsScene2D : System.IEquatable<UnityEngine.PhysicsScene2D>
    {
        /*0x10*/ int m_Handle;

        static /*0x2b1306c*/ UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2b1318c*/ int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2b13290*/ int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2b13394*/ int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x2b1310c*/ void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x2b13210*/ int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2b13314*/ int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2b13420*/ int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        /*0xb4a7f0*/ string ToString();
        /*0xb4a7f8*/ int GetHashCode();
        /*0xb4a800*/ bool Equals(object other);
        /*0xb4a808*/ bool Equals(UnityEngine.PhysicsScene2D other);
        /*0xb4a818*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0xb4a85c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0xb4a8d4*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0xb4a918*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0xb4a95c*/ int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
    }

    class Physics2D
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x2b12e58*/ Physics2D();
        static /*0x2b11ee0*/ UnityEngine.PhysicsScene2D get_defaultPhysicsScene();
        static /*0x2b11ddc*/ bool get_queriesHitTriggers();
        static /*0x2b11ee8*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x2b1208c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x2b1216c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x2b12310*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x2b1244c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x2b12590*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2b1268c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x2b1275c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x2b12860*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray);
        static /*0x2b129d4*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance);
        static /*0x2b12a8c*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x2b12918*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x2b12bc8*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results);
        static /*0x2b12cfc*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x2b12da8*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x2b12b50*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask);
    }

    enum RigidbodyType2D
    {
        Dynamic = 0,
        Kinematic = 1,
        Static = 2,
    }

    struct ContactFilter2D
    {
        /*0x10*/ bool useTriggers;
        /*0x11*/ bool useLayerMask;
        /*0x12*/ bool useDepth;
        /*0x13*/ bool useOutsideDepth;
        /*0x14*/ bool useNormalAngle;
        /*0x15*/ bool useOutsideNormalAngle;
        /*0x18*/ UnityEngine.LayerMask layerMask;
        /*0x1c*/ float minDepth;
        /*0x20*/ float maxDepth;
        /*0x24*/ float minNormalAngle;
        /*0x28*/ float maxNormalAngle;

        static /*0x2b11cd0*/ UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth);
        static /*0x2b11c34*/ void CheckConsistency_Injected(ref UnityEngine.ContactFilter2D _unity_self);
        /*0xb4a754*/ void CheckConsistency();
        /*0xb4a794*/ void SetLayerMask(UnityEngine.LayerMask layerMask);
        /*0xb4a7a4*/ void SetDepth(float minDepth, float maxDepth);
    }

    class Collision2D
    {
        /*0x10*/ int m_Collider;
        /*0x14*/ int m_OtherCollider;
        /*0x18*/ int m_Rigidbody;
        /*0x1c*/ int m_OtherRigidbody;
        /*0x20*/ UnityEngine.Vector2 m_RelativeVelocity;
        /*0x28*/ int m_Enabled;
        /*0x2c*/ int m_ContactCount;
        /*0x30*/ UnityEngine.ContactPoint2D[] m_ReusedContacts;
        /*0x38*/ UnityEngine.ContactPoint2D[] m_LegacyContacts;
    }

    struct ContactPoint2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Point;
        /*0x18*/ UnityEngine.Vector2 m_Normal;
        /*0x20*/ UnityEngine.Vector2 m_RelativeVelocity;
        /*0x28*/ float m_Separation;
        /*0x2c*/ float m_NormalImpulse;
        /*0x30*/ float m_TangentImpulse;
        /*0x34*/ int m_Collider;
        /*0x38*/ int m_OtherCollider;
        /*0x3c*/ int m_Rigidbody;
        /*0x40*/ int m_OtherRigidbody;
        /*0x44*/ int m_Enabled;
    }

    struct RaycastHit2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Centroid;
        /*0x18*/ UnityEngine.Vector2 m_Point;
        /*0x20*/ UnityEngine.Vector2 m_Normal;
        /*0x28*/ float m_Distance;
        /*0x2c*/ float m_Fraction;
        /*0x30*/ int m_Collider;

        /*0xb4a990*/ UnityEngine.Vector2 get_point();
        /*0xb4a998*/ UnityEngine.Vector2 get_normal();
        /*0xb4a9a0*/ float get_distance();
        /*0xb4a9a8*/ UnityEngine.Collider2D get_collider();
    }

    class Rigidbody2D : UnityEngine.Component
    {
        /*0x2b13ab4*/ Rigidbody2D();
        /*0x2b1369c*/ UnityEngine.Vector2 get_position();
        /*0x2b13744*/ void set_position(UnityEngine.Vector2 value);
        /*0x2b137e8*/ float get_rotation();
        /*0x2b13828*/ void set_rotation(float value);
        /*0x2b13878*/ void MovePosition(UnityEngine.Vector2 position);
        /*0x2b1391c*/ void MoveRotation(float angle);
        /*0x2b1396c*/ void MoveRotation_Angle(float angle);
        /*0x2b139bc*/ void set_gravityScale(float value);
        /*0x2b13a0c*/ void set_bodyType(UnityEngine.RigidbodyType2D value);
        /*0x2b13a5c*/ void set_isKinematic(bool value);
        /*0x2b136f4*/ void get_position_Injected(ref UnityEngine.Vector2 ret);
        /*0x2b13798*/ void set_position_Injected(ref UnityEngine.Vector2 value);
        /*0x2b138cc*/ void MovePosition_Injected(ref UnityEngine.Vector2 position);
    }

    class Collider2D : UnityEngine.Behaviour
    {
        /*0x2b11ba4*/ void set_isTrigger(bool value);
    }

    class EdgeCollider2D : UnityEngine.Collider2D
    {
        /*0x2b11e10*/ UnityEngine.Vector2[] get_points();
        /*0x2b11e50*/ void set_points(UnityEngine.Vector2[] value);
    }

    class PolygonCollider2D : UnityEngine.Collider2D
    {
        /*0x2b134a0*/ void SetPath(int index, UnityEngine.Vector2[] points);
        /*0x2b13574*/ void SetPath_Internal(int index, UnityEngine.Vector2[] points);
    }

    class Joint2D : UnityEngine.Behaviour
    {
        /*0x2b11ea0*/ UnityEngine.Rigidbody2D get_connectedBody();
    }

    class AnchoredJoint2D : UnityEngine.Joint2D
    {
        /*0x2b11afc*/ UnityEngine.Vector2 get_connectedAnchor();
        /*0x2b11b54*/ void get_connectedAnchor_Injected(ref UnityEngine.Vector2 ret);
    }

    class HingeJoint2D : UnityEngine.AnchoredJoint2D
    {
    }
}
