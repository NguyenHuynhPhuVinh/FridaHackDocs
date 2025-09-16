class <Module>
{
}

namespace UnityEngine
{
    struct PhysicsScene2D : System.IEquatable<UnityEngine.PhysicsScene2D>
    {
        /*0x10*/ int m_Handle;

        static /*0x7ef6f34*/ UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x7ef704c*/ int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x7ef719c*/ int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x7ef755c*/ UnityEngine.RaycastHit2D GetRayIntersection_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x7ef761c*/ int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x7ef7394*/ void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x7ef7410*/ int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.Bindings.ManagedSpanWrapper results);
        static /*0x7ef748c*/ int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.Bindings.BlittableListWrapper results);
        static /*0x7ef7744*/ void GetRayIntersection_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.RaycastHit2D ret);
        static /*0x7ef77c0*/ int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.Bindings.ManagedSpanWrapper results);
        /*0x7ef6bf8*/ string ToString();
        /*0x7ef6cdc*/ int GetHashCode();
        /*0x7ef6ce4*/ bool Equals(object other);
        /*0x7ef6d5c*/ bool Equals(UnityEngine.PhysicsScene2D other);
        /*0x7ef6d6c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x7ef6fc8*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x7ef701c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x7ef716c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x7ef7508*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask);
        /*0x7ef75f8*/ int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
    }

    class Physics2D
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x7ef85cc*/ Physics2D();
        static /*0x7ef783c*/ UnityEngine.PhysicsScene2D get_defaultPhysicsScene();
        static /*0x7ef7844*/ UnityEngine.Vector2 get_gravity();
        static /*0x7ef78fc*/ bool get_queriesHitTriggers();
        static /*0x7ef7924*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x7ef79e8*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x7ef7ab4*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x7ef7bd0*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x7ef7cec*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x7ef7e10*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x7ef7ecc*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x7ef7f90*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x7ef8054*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7ef8118*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray);
        static /*0x7ef82d4*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance);
        static /*0x7ef8348*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7ef8184*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x7ef8444*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x7ef84cc*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results);
        static /*0x7ef8548*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x7ef78c0*/ void get_gravity_Injected(ref UnityEngine.Vector2 ret);
        static /*0x7ef83c8*/ void GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
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

        static /*0x7ef6e34*/ UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth);
        /*0x7ef8664*/ void CheckConsistency();
        /*0x7ef86a0*/ void SetLayerMask(UnityEngine.LayerMask layerMask);
        /*0x7ef86b0*/ void SetDepth(float minDepth, float maxDepth);
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

        /*0x7ef88c8*/ Collision2D();
        /*0x7ef86f8*/ UnityEngine.Collider2D get_collider();
        /*0x7ef87a4*/ UnityEngine.Rigidbody2D get_rigidbody();
        /*0x7ef882c*/ UnityEngine.GameObject get_gameObject();
        /*0x7ef88c0*/ UnityEngine.Vector2 get_relativeVelocity();
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

        /*0x7ef88d0*/ UnityEngine.Vector2 get_point();
        /*0x7ef88d8*/ UnityEngine.Vector2 get_normal();
        /*0x7ef88e0*/ float get_distance();
        /*0x7ef88e8*/ UnityEngine.Collider2D get_collider();
    }

    class Rigidbody2D : UnityEngine.Component
    {
        static /*0x7ef8a1c*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ef8ae4*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7ef8ba0*/ float get_rotation_Injected(nint _unity_self);
        static /*0x7ef8c64*/ void set_rotation_Injected(nint _unity_self, float value);
        static /*0x7ef8d34*/ void MovePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 position);
        static /*0x7ef8e04*/ void MoveRotation_Angle_Injected(nint _unity_self, float angle);
        static /*0x7ef8ed8*/ void get_linearVelocity_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ef8fa0*/ void set_linearVelocity_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7ef905c*/ float get_mass_Injected(nint _unity_self);
        static /*0x7ef9110*/ float get_gravityScale_Injected(nint _unity_self);
        static /*0x7ef91d4*/ void set_gravityScale_Injected(nint _unity_self, float value);
        static /*0x7ef92a0*/ void set_bodyType_Injected(nint _unity_self, UnityEngine.RigidbodyType2D value);
        /*0x7ef9300*/ Rigidbody2D();
        /*0x7ef8994*/ UnityEngine.Vector2 get_position();
        /*0x7ef8a60*/ void set_position(UnityEngine.Vector2 value);
        /*0x7ef8b28*/ float get_rotation();
        /*0x7ef8bdc*/ void set_rotation(float value);
        /*0x7ef8cb0*/ void MovePosition(UnityEngine.Vector2 position);
        /*0x7ef8d78*/ void MoveRotation(float angle);
        /*0x7ef8d7c*/ void MoveRotation_Angle(float angle);
        /*0x7ef8e50*/ UnityEngine.Vector2 get_linearVelocity();
        /*0x7ef8f1c*/ void set_linearVelocity(UnityEngine.Vector2 value);
        /*0x7ef8fe4*/ float get_mass();
        /*0x7ef9098*/ float get_gravityScale();
        /*0x7ef914c*/ void set_gravityScale(float value);
        /*0x7ef9220*/ void set_bodyType(UnityEngine.RigidbodyType2D value);
        /*0x7ef92e4*/ void set_isKinematic(bool value);
        /*0x7ef92f8*/ UnityEngine.Vector2 get_velocity();
        /*0x7ef92fc*/ void set_velocity(UnityEngine.Vector2 value);
    }

    class Collider2D : UnityEngine.Behaviour
    {
        static /*0x7ef9388*/ void set_isTrigger_Injected(nint _unity_self, bool value);
        static /*0x7ef944c*/ void set_usedByEffector_Injected(nint _unity_self, bool value);
        static /*0x7ef9510*/ void set_compositeOperation_Injected(nint _unity_self, UnityEngine.Collider2D.CompositeOperation value);
        static /*0x7ef95dc*/ void get_offset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ef96b4*/ nint get_attachedRigidbody_Injected(nint _unity_self);
        static /*0x7ef9778*/ bool OverlapPoint_Injected(nint _unity_self, ref UnityEngine.Vector2 point);
        /*0x7ef97d0*/ Collider2D();
        /*0x7ef9308*/ void set_isTrigger(bool value);
        /*0x7ef93cc*/ void set_usedByEffector(bool value);
        /*0x7ef9490*/ void set_compositeOperation(UnityEngine.Collider2D.CompositeOperation value);
        /*0x7ef9554*/ UnityEngine.Vector2 get_offset();
        /*0x7ef9620*/ UnityEngine.Rigidbody2D get_attachedRigidbody();
        /*0x7ef96f0*/ bool OverlapPoint(UnityEngine.Vector2 point);
        /*0x7ef97bc*/ void set_usedByComposite(bool value);

        enum CompositeOperation
        {
            None = 0,
            Merge = 1,
            Intersect = 2,
            Difference = 3,
            Flip = 4,
        }
    }

    class CircleCollider2D : UnityEngine.Collider2D
    {
        static /*0x7ef9850*/ float get_radius_Injected(nint _unity_self);
        static /*0x7ef9914*/ void set_radius_Injected(nint _unity_self, float value);
        /*0x7ef99a4*/ CircleCollider2D();
        /*0x7ef97d8*/ float get_radius();
        /*0x7ef988c*/ void set_radius(float value);
        /*0x7ef9960*/ UnityEngine.Vector2 get_center();
        /*0x7ef99a0*/ void set_center(UnityEngine.Vector2 value);
    }

    class BoxCollider2D : UnityEngine.Collider2D
    {
        static /*0x7ef9a34*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        /*0x7ef99ac*/ UnityEngine.Vector2 get_size();
    }

    class PolygonCollider2D : UnityEngine.Collider2D
    {
        static /*0x7ef9af0*/ int GetTotalPointCount_Injected(nint _unity_self);
        static /*0x7ef9ba4*/ int get_pathCount_Injected(nint _unity_self);
        static /*0x7ef9de4*/ void GetPath_Internal_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7ef9fec*/ void SetPath_Internal_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper points);
        /*0x7efa040*/ PolygonCollider2D();
        /*0x7ef9a78*/ int GetTotalPointCount();
        /*0x7ef9b2c*/ int get_pathCount();
        /*0x7ef9be0*/ UnityEngine.Vector2[] GetPath(int index);
        /*0x7ef9cac*/ UnityEngine.Vector2[] GetPath_Internal(int index);
        /*0x7ef9e38*/ void SetPath(int index, UnityEngine.Vector2[] points);
        /*0x7ef9eb8*/ void SetPath_Internal(int index, UnityEngine.Vector2[] points);
    }

    class CompositeCollider2D : UnityEngine.Collider2D
    {
        static /*0x7efa0c0*/ int get_pathCount_Injected(nint _unity_self);
        static /*0x7efa174*/ int get_pointCount_Injected(nint _unity_self);
        static /*0x7efa424*/ int GetPathArray_Internal_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper points);
        /*0x7efa048*/ int get_pathCount();
        /*0x7efa0fc*/ int get_pointCount();
        /*0x7efa1b0*/ int GetPath(int index, UnityEngine.Vector2[] points);
        /*0x7efa2f0*/ int GetPathArray_Internal(int index, UnityEngine.Vector2[] points);
    }

    class Joint2D : UnityEngine.Behaviour
    {
        static /*0x7efa50c*/ nint get_connectedBody_Injected(nint _unity_self);
        /*0x7efa548*/ Joint2D();
        /*0x7efa478*/ UnityEngine.Rigidbody2D get_connectedBody();
    }

    class AnchoredJoint2D : UnityEngine.Joint2D
    {
        static /*0x7efa5d8*/ void get_connectedAnchor_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        /*0x7efa61c*/ AnchoredJoint2D();
        /*0x7efa550*/ UnityEngine.Vector2 get_connectedAnchor();
    }

    class HingeJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x7efa624*/ HingeJoint2D();
    }
}
