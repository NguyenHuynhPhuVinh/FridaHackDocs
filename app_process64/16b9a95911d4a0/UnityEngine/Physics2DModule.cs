class <Module>
{
}

namespace UnityEngine
{
    struct PhysicsScene2D : System.IEquatable<UnityEngine.PhysicsScene2D>
    {
        /*0x10*/ int m_Handle;

        static /*0x3e76324*/ UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x3e76434*/ int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x3e76590*/ int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x3e76924*/ int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x3e76794*/ void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x3e76810*/ int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.Bindings.ManagedSpanWrapper results);
        static /*0x3e7688c*/ int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.Bindings.BlittableListWrapper results);
        static /*0x3e76a58*/ int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.Bindings.ManagedSpanWrapper results);
        /*0x3e76010*/ string ToString();
        /*0x3e760f4*/ int GetHashCode();
        /*0x3e760fc*/ bool Equals(object other);
        /*0x3e76174*/ bool Equals(UnityEngine.PhysicsScene2D other);
        /*0x3e76184*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x3e763b8*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x3e76404*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x3e76560*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x3e76908*/ int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
    }

    class Physics2D
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x3e776d0*/ Physics2D();
        static /*0x3e76ad4*/ UnityEngine.PhysicsScene2D get_defaultPhysicsScene();
        static /*0x3e76adc*/ bool get_queriesHitTriggers();
        static /*0x3e76b04*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x3e76be4*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x3e76cc4*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x3e76dc0*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x3e76ebc*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x3e76fc0*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x3e7707c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x3e77140*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x3e77204*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray);
        static /*0x3e773d8*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance);
        static /*0x3e7744c*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x3e77270*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x3e77548*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x3e775d0*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results);
        static /*0x3e7764c*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x3e774cc*/ void GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
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

        static /*0x3e76228*/ UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth);
        /*0x3e77768*/ void CheckConsistency();
        /*0x3e777a4*/ void SetLayerMask(UnityEngine.LayerMask layerMask);
        /*0x3e777b4*/ void SetDepth(float minDepth, float maxDepth);
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
        /*0x28*/ float m_Friction;
        /*0x2c*/ float m_Bounciness;
        /*0x30*/ float m_Separation;
        /*0x34*/ float m_NormalImpulse;
        /*0x38*/ float m_TangentImpulse;
        /*0x3c*/ int m_Collider;
        /*0x40*/ int m_OtherCollider;
        /*0x44*/ int m_Rigidbody;
        /*0x48*/ int m_OtherRigidbody;
        /*0x4c*/ int m_Enabled;
    }

    struct RaycastHit2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Centroid;
        /*0x18*/ UnityEngine.Vector2 m_Point;
        /*0x20*/ UnityEngine.Vector2 m_Normal;
        /*0x28*/ float m_Distance;
        /*0x2c*/ float m_Fraction;
        /*0x30*/ int m_Collider;

        /*0x3e777fc*/ UnityEngine.Vector2 get_point();
        /*0x3e77804*/ UnityEngine.Vector2 get_normal();
        /*0x3e7780c*/ float get_distance();
        /*0x3e77814*/ UnityEngine.Collider2D get_collider();
    }

    class Rigidbody2D : UnityEngine.Component
    {
        static /*0x3e77948*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3e77a10*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3e77acc*/ float get_rotation_Injected(nint _unity_self);
        static /*0x3e77b8c*/ void MovePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 position);
        static /*0x3e77c5c*/ void MoveRotation_Angle_Injected(nint _unity_self, float angle);
        /*0x3e778c0*/ UnityEngine.Vector2 get_position();
        /*0x3e7798c*/ void set_position(UnityEngine.Vector2 value);
        /*0x3e77a54*/ float get_rotation();
        /*0x3e77b08*/ void MovePosition(UnityEngine.Vector2 position);
        /*0x3e77bd0*/ void MoveRotation(float angle);
        /*0x3e77bd4*/ void MoveRotation_Angle(float angle);
    }

    class Collider2D : UnityEngine.Behaviour
    {
        static /*0x3e77d4c*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x3e77e18*/ bool OverlapPoint_Injected(nint _unity_self, ref UnityEngine.Vector2 point);
        /*0x3e77ca8*/ UnityEngine.Bounds get_bounds();
        /*0x3e77d90*/ bool OverlapPoint(UnityEngine.Vector2 point);
    }
}
