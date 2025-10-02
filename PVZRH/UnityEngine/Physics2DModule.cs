class <Module>
{
}

namespace UnityEngine
{
    struct PhysicsScene2D : System.IEquatable<UnityEngine.PhysicsScene2D>
    {
        /*0x10*/ int m_Handle;

        static /*0x1649730*/ UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x1649550*/ int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x1649640*/ int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x1649280*/ int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x16493e0*/ UnityEngine.Collider2D OverlapPoint_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter);
        static /*0x16496c0*/ void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x16494e0*/ int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x16495d0*/ int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x1649210*/ int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x1649380*/ UnityEngine.Collider2D OverlapPoint_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter);
        /*0x1649b10*/ string ToString();
        /*0x15d3b80*/ int GetHashCode();
        /*0x1649190*/ bool Equals(object other);
        /*0x15e9590*/ bool Equals(UnityEngine.PhysicsScene2D other);
        /*0x16498f0*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x1649a30*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x16497b0*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x1649850*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x16492f0*/ int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x1649430*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask);
    }

    class Physics2D
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x1649020*/ Physics2D();
        static /*0xbf9940*/ UnityEngine.PhysicsScene2D get_defaultPhysicsScene();
        static /*0x16490f0*/ UnityEngine.Vector2 get_gravity();
        static /*0x1649160*/ bool get_queriesHitTriggers();
        static /*0x1647840*/ void IgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2);
        static /*0x16477e0*/ void IgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, bool ignore);
        static /*0x1647010*/ UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position, UnityEngine.Collider2D collider);
        static /*0x1646f90*/ UnityEngine.Vector2 ClosestPoint_Collider(UnityEngine.Vector2 position, UnityEngine.Collider2D collider);
        static /*0x1648ec0*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x1648b40*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x16488b0*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x1648d20*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x1648610*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x16487b0*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x1648a40*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x1648c20*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x16484c0*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x1648360*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x1648200*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x1648160*/ UnityEngine.RaycastHit2D[] RaycastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x1647440*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray);
        static /*0x1647350*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance);
        static /*0x1647260*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x16471c0*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x1647700*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results);
        static /*0x1647520*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x1647610*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x1648010*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point);
        static /*0x1647d90*/ UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius);
        static /*0x1647ed0*/ UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask);
        static /*0x1647d00*/ UnityEngine.Collider2D[] OverlapCircleAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter);
        static /*0x16479d0*/ UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle);
        static /*0x1647b30*/ UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask);
        static /*0x1647930*/ UnityEngine.Collider2D[] OverlapBoxAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter);
        static /*0x16490b0*/ void get_gravity_Injected(ref UnityEngine.Vector2 ret);
        static /*0x1646f30*/ void ClosestPoint_Collider_Injected(ref UnityEngine.Vector2 position, UnityEngine.Collider2D collider, ref UnityEngine.Vector2 ret);
        static /*0x16480f0*/ UnityEngine.RaycastHit2D[] RaycastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x1647150*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x1647c90*/ UnityEngine.Collider2D[] OverlapCircleAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x16478c0*/ UnityEngine.Collider2D[] OverlapBoxAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter);
    }

    enum RigidbodyInterpolation2D
    {
        None = 0,
        Interpolate = 1,
        Extrapolate = 2,
    }

    enum CollisionDetectionMode2D
    {
        None = 0,
        Discrete = 0,
        Continuous = 1,
    }

    enum RigidbodyType2D
    {
        Dynamic = 0,
        Kinematic = 1,
        Static = 2,
    }

    enum ForceMode2D
    {
        Force = 0,
        Impulse = 1,
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

        static /*0x1646d70*/ UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth);
        static /*0x1646d30*/ void CheckConsistency_Injected(ref UnityEngine.ContactFilter2D _unity_self);
        /*0x1646d30*/ void CheckConsistency();
        /*0x1646ed0*/ void SetLayerMask(UnityEngine.LayerMask layerMask);
        /*0x1646e80*/ void SetDepth(float minDepth, float maxDepth);
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

        /*0x1646a90*/ UnityEngine.Collider2D get_collider();
        /*0x1646cb0*/ UnityEngine.Rigidbody2D get_rigidbody();
        /*0x1646ba0*/ UnityEngine.GameObject get_gameObject();
        /*0x1646b30*/ UnityEngine.ContactPoint2D[] get_contacts();
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

        /*0x15d34c0*/ UnityEngine.Vector2 get_point();
    }

    struct RaycastHit2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Centroid;
        /*0x18*/ UnityEngine.Vector2 m_Point;
        /*0x20*/ UnityEngine.Vector2 m_Normal;
        /*0x28*/ float m_Distance;
        /*0x2c*/ float m_Fraction;
        /*0x30*/ int m_Collider;

        /*0x15d34a0*/ UnityEngine.Vector2 get_point();
        /*0x1649ce0*/ UnityEngine.Vector2 get_normal();
        /*0x15ca850*/ float get_distance();
        /*0x1649c40*/ UnityEngine.Collider2D get_collider();
    }

    class Rigidbody2D : UnityEngine.Component
    {
        /*0x15b84e0*/ Rigidbody2D();
        /*0x1649f40*/ UnityEngine.Vector2 get_position();
        /*0x164a390*/ void set_position(UnityEngine.Vector2 value);
        /*0x1649f90*/ float get_rotation();
        /*0x164a3d0*/ void set_rotation(float value);
        /*0x1649eb0*/ void MovePosition(UnityEngine.Vector2 position);
        /*0x164a020*/ UnityEngine.Vector2 get_velocity();
        /*0x164a4c0*/ void set_velocity(UnityEngine.Vector2 value);
        /*0x164a070*/ void set_angularVelocity(float value);
        /*0x164a420*/ void set_sharedMaterial(UnityEngine.PhysicsMaterial2D value);
        /*0x164a1d0*/ void set_gravityScale(float value);
        /*0x164a0c0*/ void set_bodyType(UnityEngine.RigidbodyType2D value);
        /*0x164a2f0*/ void set_isKinematic(bool value);
        /*0x164a2b0*/ void set_interpolation(UnityEngine.RigidbodyInterpolation2D value);
        /*0x164a100*/ void set_collisionDetectionMode(UnityEngine.CollisionDetectionMode2D value);
        /*0x164a190*/ void set_excludeLayers(UnityEngine.LayerMask value);
        /*0x164a270*/ void set_includeLayers(UnityEngine.LayerMask value);
        /*0x1649d60*/ void AddForce(UnityEngine.Vector2 force, UnityEngine.ForceMode2D mode);
        /*0x1649e10*/ void AddTorque(float torque);
        /*0x1649db0*/ void AddTorque(float torque, UnityEngine.ForceMode2D mode);
        /*0x1649ef0*/ void get_position_Injected(ref UnityEngine.Vector2 ret);
        /*0x164a340*/ void set_position_Injected(ref UnityEngine.Vector2 value);
        /*0x1649e60*/ void MovePosition_Injected(ref UnityEngine.Vector2 position);
        /*0x1649fd0*/ void get_velocity_Injected(ref UnityEngine.Vector2 ret);
        /*0x164a470*/ void set_velocity_Injected(ref UnityEngine.Vector2 value);
        /*0x164a140*/ void set_excludeLayers_Injected(ref UnityEngine.LayerMask value);
        /*0x164a220*/ void set_includeLayers_Injected(ref UnityEngine.LayerMask value);
        /*0x1649d00*/ void AddForce_Injected(ref UnityEngine.Vector2 force, UnityEngine.ForceMode2D mode);
    }

    class Collider2D : UnityEngine.Behaviour
    {
        /*0x15b84e0*/ Collider2D();
        /*0x1646a40*/ void set_isTrigger(bool value);
        /*0x1646940*/ UnityEngine.Bounds get_bounds();
        /*0x16469f0*/ UnityEngine.LayerMask get_contactCaptureLayers();
        /*0x1646780*/ UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position);
        /*0x16468f0*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x16469a0*/ void get_contactCaptureLayers_Injected(ref UnityEngine.LayerMask ret);
    }

    class CircleCollider2D : UnityEngine.Collider2D
    {
    }

    class EdgeCollider2D : UnityEngine.Collider2D
    {
        /*0x15b84e0*/ EdgeCollider2D();
        /*0x1646ee0*/ void set_points(UnityEngine.Vector2[] value);
    }

    class BoxCollider2D : UnityEngine.Collider2D
    {
        /*0x15b84e0*/ BoxCollider2D();
        /*0x1646740*/ void set_size(UnityEngine.Vector2 value);
        /*0x16466f0*/ void set_size_Injected(ref UnityEngine.Vector2 value);
    }

    class PolygonCollider2D : UnityEngine.Collider2D
    {
        /*0x15b84e0*/ PolygonCollider2D();
        /*0x1649bf0*/ void set_points(UnityEngine.Vector2[] value);
    }

    class CompositeCollider2D : UnityEngine.Collider2D
    {
    }

    class Joint2D : UnityEngine.Behaviour
    {
    }

    class PhysicsMaterial2D : UnityEngine.Object
    {
    }
}
