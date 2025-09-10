class <Module>
{
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        /*0x1896fcc*/ bool get_isPlaying();
        /*0x1897008*/ bool get_isStopped();
        /*0x1897044*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x18970a0*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x18970f8*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x1897154*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x18971ac*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x18971f8*/ void Play(bool withChildren);
        /*0x189723c*/ void Play();
        /*0x189727c*/ void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        /*0x18972d0*/ void Stop(bool withChildren);
        /*0x1897318*/ void Stop();
        /*0x189735c*/ void Clear(bool withChildren);
        /*0x18973a0*/ void Clear();
        /*0x18973e0*/ bool IsAlive(bool withChildren);
        /*0x1897424*/ bool IsAlive();
        /*0x1897464*/ void Emit(int count);
        /*0x18974a8*/ void Emit_Internal(int count);
        /*0x18974ec*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x1897594*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x18975d8*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x18975e4*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x1897784*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x18977c8*/ void set_playbackSpeed(float value);
        /*0x189785c*/ int get_maxParticles();
        /*0x1897540*/ void Emit_Injected(ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x18978d8*/ void set_simulationSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x1897924*/ int get_maxParticles_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            /*0x18975dc*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0x1897810*/ void set_simulationSpeed(float value);
            /*0x189789c*/ int get_maxParticles();
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

            /*0x18976e8*/ void set_position(UnityEngine.Vector3 value);
            /*0x18976f4*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x1897960*/ float get_remainingLifetime();
            /*0x1897968*/ void set_remainingLifetime(float value);
            /*0x1897708*/ void set_startLifetime(float value);
            /*0x1897774*/ void set_startColor(UnityEngine.Color32 value);
            /*0x189777c*/ void set_randomSeed(uint value);
            /*0x1897710*/ void set_startSize(float value);
            /*0x189771c*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0x1897748*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
            /*0x1897700*/ void set_lifetime(float value);
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
    }

    class ParticleSystemRenderer : UnityEngine.Renderer
    {
        /*0x1897970*/ int GetMeshes(UnityEngine.Mesh[] meshes);
    }

    enum ParticleSystemStopBehavior
    {
        StopEmittingAndClear = 0,
        StopEmitting = 1,
    }
}
