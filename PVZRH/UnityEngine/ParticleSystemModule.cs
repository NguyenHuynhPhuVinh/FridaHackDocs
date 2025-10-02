class <Module>
{
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        /*0x15b84e0*/ ParticleSystem();
        /*0x1646280*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x1646430*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x1646240*/ void Emit(int count);
        /*0x1646240*/ void Emit_Internal(int count);
        /*0x1646480*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x1646190*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x16464e0*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x16464e0*/ UnityEngine.ParticleSystem.EmissionModule get_emission();
        /*0x16464e0*/ UnityEngine.ParticleSystem.ShapeModule get_shape();
        /*0x16464e0*/ UnityEngine.ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime();
        /*0x16464e0*/ UnityEngine.ParticleSystem.CollisionModule get_collision();
        /*0x16464e0*/ UnityEngine.ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation();
        /*0x16461e0*/ void Emit_Injected(ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x1645bd0*/ void get_startSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x1645e00*/ void set_startSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x1645d10*/ void set_startRotation3D_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x1645d60*/ void set_startRotation_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x1645c70*/ void set_startColor_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradient value);
            static /*0x1645ea0*/ void set_stopAction_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemStopAction value);
            /*0x792990*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0x1645c20*/ UnityEngine.ParticleSystem.MinMaxCurve get_startSpeed();
            /*0x1645e50*/ void set_startSpeed(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x1645d10*/ void set_startRotation3D(bool value);
            /*0x1645db0*/ void set_startRotation(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x1645cc0*/ void set_startColor(UnityEngine.ParticleSystem.MinMaxGradient value);
            /*0x1645ea0*/ void set_stopAction(UnityEngine.ParticleSystemStopAction value);
        }

        struct EmissionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x1645ae0*/ void set_enabled_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, bool value);
            static /*0x1645a40*/ void get_rateOverTime_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x1645b30*/ void set_rateOverTime_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x792990*/ EmissionModule(UnityEngine.ParticleSystem particleSystem);
            /*0x1645ae0*/ void set_enabled(bool value);
            /*0x1645a90*/ UnityEngine.ParticleSystem.MinMaxCurve get_rateOverTime();
            /*0x1645b80*/ void set_rateOverTime(UnityEngine.ParticleSystem.MinMaxCurve value);
        }

        struct ShapeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x1646600*/ void set_scale_Injected(ref UnityEngine.ParticleSystem.ShapeModule _unity_self, ref UnityEngine.Vector3 value);
            /*0x792990*/ ShapeModule(UnityEngine.ParticleSystem particleSystem);
            /*0x1646650*/ void set_scale(UnityEngine.Vector3 value);
        }

        struct CollisionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x16459a0*/ void set_bounce_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x1645950*/ void AddPlane_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, UnityEngine.Transform transform);
            /*0x792990*/ CollisionModule(UnityEngine.ParticleSystem particleSystem);
            /*0x16459f0*/ void set_bounce(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x1645950*/ void AddPlane(UnityEngine.Transform transform);
        }

        struct TextureSheetAnimationModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x16466a0*/ void SetSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, int index, UnityEngine.Sprite sprite);
            /*0x792990*/ TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem);
            /*0x16466a0*/ void SetSprite(int index, UnityEngine.Sprite sprite);
        }

        struct Particle
        {
            /*0x10*/ UnityEngine.Vector3 m_Position;
            /*0x1c*/ UnityEngine.Vector3 m_Velocity;
            /*0x28*/ UnityEngine.Vector3 m_AnimatedVelocity;
            /*0x34*/ UnityEngine.Vector3 m_InitialVelocity;
            /*0x40*/ UnityEngine.Vector3 m_AxisOfRotation;
            /*0x4c*/ UnityEngine.Vector3 m_Rotation;
            /*0x58*/ UnityEngine.Vector3 m_AngularVelocity;
            /*0x64*/ UnityEngine.Vector3 m_StartSize;
            /*0x70*/ UnityEngine.Color32 m_StartColor;
            /*0x74*/ uint m_RandomSeed;
            /*0x78*/ uint m_ParentRandomSeed;
            /*0x7c*/ float m_Lifetime;
            /*0x80*/ float m_StartLifetime;
            /*0x84*/ int m_MeshIndex;
            /*0x88*/ float m_EmitAccumulator0;
            /*0x8c*/ float m_EmitAccumulator1;
            /*0x90*/ uint m_Flags;

            /*0x137d9d0*/ void set_lifetime(float value);
            /*0x15bd5e0*/ void set_position(UnityEngine.Vector3 value);
            /*0x15bd5f0*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x137d9d0*/ void set_remainingLifetime(float value);
            /*0x1646580*/ void set_startLifetime(float value);
            /*0xf91480*/ void set_startColor(UnityEngine.Color32 value);
            /*0x137dee0*/ void set_randomSeed(uint value);
            /*0x1646590*/ void set_startSize(float value);
            /*0x1646540*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0x1646500*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
        }

        struct MinMaxCurve
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ UnityEngine.AnimationCurve m_CurveMin;
            /*0x20*/ UnityEngine.AnimationCurve m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x1645f90*/ UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(float constant);
            /*0x1645f40*/ MinMaxCurve(float constant);
            /*0x1645ee0*/ MinMaxCurve(float min, float max);
            /*0x1644ec0*/ float get_constantMax();
            /*0x1316920*/ void set_constantMax(float value);
            /*0x15ca850*/ float get_constantMin();
            /*0xdd5200*/ void set_constantMin(float value);
            /*0x1644ec0*/ float get_constant();
        }

        struct MinMaxGradient
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ UnityEngine.Gradient m_GradientMin;
            /*0x20*/ UnityEngine.Gradient m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x1646080*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color);
            /*0x1646020*/ MinMaxGradient(UnityEngine.Color color);
        }

        struct EmitParams
        {
            /*0x10*/ UnityEngine.ParticleSystem.Particle m_Particle;
            /*0x94*/ bool m_PositionSet;
            /*0x95*/ bool m_VelocitySet;
            /*0x96*/ bool m_AxisOfRotationSet;
            /*0x97*/ bool m_RotationSet;
            /*0x98*/ bool m_AngularVelocitySet;
            /*0x99*/ bool m_StartSizeSet;
            /*0x9a*/ bool m_StartColorSet;
            /*0x9b*/ bool m_RandomSeedSet;
            /*0x9c*/ bool m_StartLifetimeSet;
            /*0x9d*/ bool m_MeshIndexSet;
            /*0x9e*/ bool m_ApplyShapeToPosition;
        }

        struct RotationOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x16465b0*/ void set_enabled_Injected(ref UnityEngine.ParticleSystem.RotationOverLifetimeModule _unity_self, bool value);
            /*0x792990*/ RotationOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
            /*0x16465b0*/ void set_enabled(bool value);
        }
    }

    enum ParticleSystemCurveMode
    {
        Constant = 0,
        Curve = 1,
        TwoCurves = 2,
        TwoConstants = 3,
    }

    enum ParticleSystemGradientMode
    {
        Color = 0,
        Gradient = 1,
        TwoColors = 2,
        TwoGradients = 3,
        RandomColor = 4,
    }

    enum ParticleSystemStopAction
    {
        None = 0,
        Disable = 1,
        Destroy = 2,
        Callback = 3,
    }

    class ParticleSystemRenderer : UnityEngine.Renderer
    {
        /*0x1646140*/ int GetMeshes(UnityEngine.Mesh[] meshes);
    }
}
