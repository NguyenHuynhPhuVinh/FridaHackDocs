class <Module>
{
}

namespace UnityEngine
{
    class Physics2D
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x147c8b4*/ Physics2D();
    }

    struct RaycastHit2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Centroid;
        /*0x18*/ UnityEngine.Vector2 m_Point;
        /*0x20*/ UnityEngine.Vector2 m_Normal;
        /*0x28*/ float m_Distance;
        /*0x2c*/ float m_Fraction;
        /*0x30*/ int m_Collider;

        /*0x147c940*/ UnityEngine.Vector2 get_point();
        /*0x147c948*/ UnityEngine.Vector2 get_normal();
        /*0x147c950*/ float get_distance();
        /*0x147c958*/ UnityEngine.Collider2D get_collider();
    }

    class Rigidbody2D : UnityEngine.Component
    {
    }

    class Collider2D : UnityEngine.Behaviour
    {
    }
}
