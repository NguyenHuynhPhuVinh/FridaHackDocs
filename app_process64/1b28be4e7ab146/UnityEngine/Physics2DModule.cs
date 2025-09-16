class <Module>
{
}

namespace UnityEngine
{
    struct PhysicsScene2D : System.IEquatable<UnityEngine.PhysicsScene2D>
    {
        /*0x10*/ int m_Handle;

        static /*0x7f0e364*/ UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x7f0e47c*/ int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x7f0e5cc*/ int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x7f0e98c*/ UnityEngine.RaycastHit2D GetRayIntersection_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x7f0ea4c*/ int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x7f0e7c4*/ void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x7f0e840*/ int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.Bindings.ManagedSpanWrapper results);
        static /*0x7f0e8bc*/ int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.Bindings.BlittableListWrapper results);
        static /*0x7f0eb74*/ void GetRayIntersection_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.RaycastHit2D ret);
        static /*0x7f0ebf0*/ int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.Bindings.ManagedSpanWrapper results);
        /*0x7f0e028*/ string ToString();
        /*0x7f0e10c*/ int GetHashCode();
        /*0x7f0e114*/ bool Equals(object other);
        /*0x7f0e18c*/ bool Equals(UnityEngine.PhysicsScene2D other);
        /*0x7f0e19c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x7f0e3f8*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x7f0e44c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x7f0e59c*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x7f0e938*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask);
        /*0x7f0ea28*/ int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
    }

    class Physics2D
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x7f0f9fc*/ Physics2D();
        static /*0x7f0ec6c*/ UnityEngine.PhysicsScene2D get_defaultPhysicsScene();
        static /*0x7f0ec74*/ UnityEngine.Vector2 get_gravity();
        static /*0x7f0ed2c*/ bool get_queriesHitTriggers();
        static /*0x7f0ed54*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x7f0ee18*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x7f0eee4*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x7f0f000*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x7f0f11c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x7f0f240*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x7f0f2fc*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x7f0f3c0*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x7f0f484*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7f0f548*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray);
        static /*0x7f0f704*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance);
        static /*0x7f0f778*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x7f0f5b4*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x7f0f874*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x7f0f8fc*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results);
        static /*0x7f0f978*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x7f0ecf0*/ void get_gravity_Injected(ref UnityEngine.Vector2 ret);
        static /*0x7f0f7f8*/ void GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
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

        static /*0x7f0e264*/ UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth);
        /*0x7f0fa94*/ void CheckConsistency();
        /*0x7f0fad0*/ void SetLayerMask(UnityEngine.LayerMask layerMask);
        /*0x7f0fae0*/ void SetDepth(float minDepth, float maxDepth);
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

        /*0x7f0fcf8*/ Collision2D();
        /*0x7f0fb28*/ UnityEngine.Collider2D get_collider();
        /*0x7f0fbd4*/ UnityEngine.Rigidbody2D get_rigidbody();
        /*0x7f0fc5c*/ UnityEngine.GameObject get_gameObject();
        /*0x7f0fcf0*/ UnityEngine.Vector2 get_relativeVelocity();
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

        /*0x7f0fd00*/ UnityEngine.Vector2 get_point();
        /*0x7f0fd08*/ UnityEngine.Vector2 get_normal();
        /*0x7f0fd10*/ float get_distance();
        /*0x7f0fd18*/ UnityEngine.Collider2D get_collider();
    }

    class Rigidbody2D : UnityEngine.Component
    {
        static /*0x7f0fe4c*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7f0ff14*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7f0ffd0*/ float get_rotation_Injected(nint _unity_self);
        static /*0x7f10094*/ void set_rotation_Injected(nint _unity_self, float value);
        static /*0x7f10164*/ void MovePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 position);
        static /*0x7f10234*/ void MoveRotation_Angle_Injected(nint _unity_self, float angle);
        static /*0x7f10308*/ void get_linearVelocity_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7f103d0*/ void set_linearVelocity_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7f1048c*/ float get_mass_Injected(nint _unity_self);
        static /*0x7f10540*/ float get_gravityScale_Injected(nint _unity_self);
        static /*0x7f10604*/ void set_gravityScale_Injected(nint _unity_self, float value);
        static /*0x7f106d0*/ void set_bodyType_Injected(nint _unity_self, UnityEngine.RigidbodyType2D value);
        /*0x7f10730*/ Rigidbody2D();
        /*0x7f0fdc4*/ UnityEngine.Vector2 get_position();
        /*0x7f0fe90*/ void set_position(UnityEngine.Vector2 value);
        /*0x7f0ff58*/ float get_rotation();
        /*0x7f1000c*/ void set_rotation(float value);
        /*0x7f100e0*/ void MovePosition(UnityEngine.Vector2 position);
        /*0x7f101a8*/ void MoveRotation(float angle);
        /*0x7f101ac*/ void MoveRotation_Angle(float angle);
        /*0x7f10280*/ UnityEngine.Vector2 get_linearVelocity();
        /*0x7f1034c*/ void set_linearVelocity(UnityEngine.Vector2 value);
        /*0x7f10414*/ float get_mass();
        /*0x7f104c8*/ float get_gravityScale();
        /*0x7f1057c*/ void set_gravityScale(float value);
        /*0x7f10650*/ void set_bodyType(UnityEngine.RigidbodyType2D value);
        /*0x7f10714*/ void set_isKinematic(bool value);
        /*0x7f10728*/ UnityEngine.Vector2 get_velocity();
        /*0x7f1072c*/ void set_velocity(UnityEngine.Vector2 value);
    }

    class Collider2D : UnityEngine.Behaviour
    {
        static /*0x7f107b8*/ void set_isTrigger_Injected(nint _unity_self, bool value);
        static /*0x7f1087c*/ void set_usedByEffector_Injected(nint _unity_self, bool value);
        static /*0x7f10940*/ void set_compositeOperation_Injected(nint _unity_self, UnityEngine.Collider2D.CompositeOperation value);
        static /*0x7f10a0c*/ void get_offset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7f10ae4*/ nint get_attachedRigidbody_Injected(nint _unity_self);
        static /*0x7f10ba8*/ bool OverlapPoint_Injected(nint _unity_self, ref UnityEngine.Vector2 point);
        /*0x7f10c00*/ Collider2D();
        /*0x7f10738*/ void set_isTrigger(bool value);
        /*0x7f107fc*/ void set_usedByEffector(bool value);
        /*0x7f108c0*/ void set_compositeOperation(UnityEngine.Collider2D.CompositeOperation value);
        /*0x7f10984*/ UnityEngine.Vector2 get_offset();
        /*0x7f10a50*/ UnityEngine.Rigidbody2D get_attachedRigidbody();
        /*0x7f10b20*/ bool OverlapPoint(UnityEngine.Vector2 point);
        /*0x7f10bec*/ void set_usedByComposite(bool value);

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
        static /*0x7f10c80*/ float get_radius_Injected(nint _unity_self);
        static /*0x7f10d44*/ void set_radius_Injected(nint _unity_self, float value);
        /*0x7f10dd4*/ CircleCollider2D();
        /*0x7f10c08*/ float get_radius();
        /*0x7f10cbc*/ void set_radius(float value);
        /*0x7f10d90*/ UnityEngine.Vector2 get_center();
        /*0x7f10dd0*/ void set_center(UnityEngine.Vector2 value);
    }

    class BoxCollider2D : UnityEngine.Collider2D
    {
        static /*0x7f10e64*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        /*0x7f10ddc*/ UnityEngine.Vector2 get_size();
    }

    class PolygonCollider2D : UnityEngine.Collider2D
    {
        static /*0x7f10f20*/ int GetTotalPointCount_Injected(nint _unity_self);
        static /*0x7f10fd4*/ int get_pathCount_Injected(nint _unity_self);
        static /*0x7f11214*/ void GetPath_Internal_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7f1141c*/ void SetPath_Internal_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper points);
        /*0x7f11470*/ PolygonCollider2D();
        /*0x7f10ea8*/ int GetTotalPointCount();
        /*0x7f10f5c*/ int get_pathCount();
        /*0x7f11010*/ UnityEngine.Vector2[] GetPath(int index);
        /*0x7f110dc*/ UnityEngine.Vector2[] GetPath_Internal(int index);
        /*0x7f11268*/ void SetPath(int index, UnityEngine.Vector2[] points);
        /*0x7f112e8*/ void SetPath_Internal(int index, UnityEngine.Vector2[] points);
    }

    class CompositeCollider2D : UnityEngine.Collider2D
    {
        static /*0x7f114f0*/ int get_pathCount_Injected(nint _unity_self);
        static /*0x7f115a4*/ int get_pointCount_Injected(nint _unity_self);
        static /*0x7f11854*/ int GetPathArray_Internal_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper points);
        /*0x7f11478*/ int get_pathCount();
        /*0x7f1152c*/ int get_pointCount();
        /*0x7f115e0*/ int GetPath(int index, UnityEngine.Vector2[] points);
        /*0x7f11720*/ int GetPathArray_Internal(int index, UnityEngine.Vector2[] points);
    }

    class Joint2D : UnityEngine.Behaviour
    {
        static /*0x7f1193c*/ nint get_connectedBody_Injected(nint _unity_self);
        /*0x7f11978*/ Joint2D();
        /*0x7f118a8*/ UnityEngine.Rigidbody2D get_connectedBody();
    }

    class AnchoredJoint2D : UnityEngine.Joint2D
    {
        static /*0x7f11a08*/ void get_connectedAnchor_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        /*0x7f11a4c*/ AnchoredJoint2D();
        /*0x7f11980*/ UnityEngine.Vector2 get_connectedAnchor();
    }

    class HingeJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x7f11a54*/ HingeJoint2D();
    }
}
