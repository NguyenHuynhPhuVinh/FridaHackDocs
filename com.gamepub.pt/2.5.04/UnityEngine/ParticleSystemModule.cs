class <Module>
{
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        /*0x2b0a144*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x2b0a348*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x2b0a398*/ bool get_isPlaying();
        /*0x2b0a3d8*/ int get_particleCount();
        /*0x2b0a418*/ float GetParticleCurrentSize(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x2b0a468*/ UnityEngine.Color32 GetParticleCurrentColor(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x2b0a520*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x2b0a588*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x2b0a5e4*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x2b0a64c*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x2b0a6a8*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x2b0a700*/ void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep);
        /*0x2b0a778*/ void Play(bool withChildren);
        /*0x2b0a7c8*/ void Play();
        /*0x2b0a80c*/ void Pause(bool withChildren);
        /*0x2b0a85c*/ void Pause();
        /*0x2b0a8a0*/ void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        /*0x2b0a8f8*/ void Stop(bool withChildren);
        /*0x2b0a94c*/ void Stop();
        /*0x2b0a994*/ void Clear(bool withChildren);
        /*0x2b0a9e4*/ void Clear();
        /*0x2b0aa28*/ bool IsAlive(bool withChildren);
        /*0x2b0aa78*/ bool IsAlive();
        /*0x2b0aabc*/ void Emit(int count);
        /*0x2b0ab0c*/ void Emit_Internal(int count);
        /*0x2b0ab5c*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x2b0a2f8*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x2b0ac0c*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x2b0ac18*/ UnityEngine.ParticleSystem.SubEmittersModule get_subEmitters();
        /*0x2b0ac24*/ UnityEngine.ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation();
        /*0x2b0ac30*/ UnityEngine.ParticleSystem.TrailModule get_trails();
        /*0x2b0a4c8*/ void GetParticleCurrentColor_Injected(ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Color32 ret);
        /*0x2b0abb4*/ void Emit_Injected(ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x2b0ae9c*/ float get_duration_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2b0af2c*/ void set_loop_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x2b0afbc*/ bool get_prewarm_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2b0b03c*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2b0b0bc*/ UnityEngine.Transform get_customSimulationSpace_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2b0b14c*/ void set_simulationSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x2b0b1dc*/ UnityEngine.ParticleSystemScalingMode get_scalingMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2b0b26c*/ void set_scalingMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemScalingMode value);
            static /*0x2b0b2fc*/ int get_maxParticles_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2b0b38c*/ void set_maxParticles_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, int value);
            /*0xb45204*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0xb4520c*/ float get_duration();
            /*0xb4524c*/ void set_loop(bool value);
            /*0xb4529c*/ bool get_prewarm();
            /*0xb452dc*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
            /*0xb4531c*/ UnityEngine.Transform get_customSimulationSpace();
            /*0xb4535c*/ void set_simulationSpeed(float value);
            /*0xb453ac*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
            /*0xb453ec*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
            /*0xb4543c*/ int get_maxParticles();
            /*0xb4547c*/ void set_maxParticles(int value);
        }

        struct SubEmittersModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x2b0b54c*/ bool get_enabled_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self);
            /*0xb45638*/ SubEmittersModule(UnityEngine.ParticleSystem particleSystem);
            /*0xb45640*/ bool get_enabled();
        }

        struct TextureSheetAnimationModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x2b0b5cc*/ bool get_enabled_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0b64c*/ UnityEngine.ParticleSystemAnimationMode get_mode_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0b6cc*/ int get_numTilesX_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0b74c*/ int get_numTilesY_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0b7cc*/ UnityEngine.ParticleSystemAnimationType get_animation_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0b878*/ void get_frameOverTime_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x2b0b908*/ int get_cycleCount_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0b988*/ int get_rowIndex_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0ba08*/ UnityEngine.Rendering.UVChannelFlags get_uvChannelMask_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0ba98*/ void set_uvChannelMask_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, UnityEngine.Rendering.UVChannelFlags value);
            static /*0x2b0bb28*/ int get_spriteCount_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x2b0bbb8*/ UnityEngine.Sprite GetSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, int index);
            /*0xb456bc*/ TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem);
            /*0xb456c4*/ bool get_enabled();
            /*0xb45704*/ UnityEngine.ParticleSystemAnimationMode get_mode();
            /*0xb45744*/ int get_numTilesX();
            /*0xb45784*/ int get_numTilesY();
            /*0xb457c4*/ UnityEngine.ParticleSystemAnimationType get_animation();
            /*0xb45804*/ UnityEngine.ParticleSystem.MinMaxCurve get_frameOverTime();
            /*0xb45870*/ int get_cycleCount();
            /*0xb458b0*/ int get_rowIndex();
            /*0xb458f0*/ UnityEngine.Rendering.UVChannelFlags get_uvChannelMask();
            /*0xb45930*/ void set_uvChannelMask(UnityEngine.Rendering.UVChannelFlags value);
            /*0xb45980*/ int get_spriteCount();
            /*0xb459c0*/ UnityEngine.Sprite GetSprite(int index);
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

            /*0xb454e4*/ void set_lifetime(float value);
            /*0xb454ec*/ UnityEngine.Vector3 get_position();
            /*0xb454f8*/ void set_position(UnityEngine.Vector3 value);
            /*0xb45504*/ void set_velocity(UnityEngine.Vector3 value);
            /*0xb45510*/ float get_remainingLifetime();
            /*0xb45518*/ void set_remainingLifetime(float value);
            /*0xb45520*/ float get_startLifetime();
            /*0xb45528*/ void set_startLifetime(float value);
            /*0xb45530*/ void set_startColor(UnityEngine.Color32 value);
            /*0xb45538*/ void set_randomSeed(uint value);
            /*0xb45540*/ void set_startSize(float value);
            /*0xb4554c*/ float get_rotation();
            /*0xb45560*/ UnityEngine.Vector3 get_rotation3D();
            /*0xb45580*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0xb455ac*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
            /*0xb455d8*/ float GetCurrentSize(UnityEngine.ParticleSystem system);
            /*0xb455e0*/ UnityEngine.Color32 GetCurrentColor(UnityEngine.ParticleSystem system);
        }

        struct MinMaxCurve
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ UnityEngine.AnimationCurve m_CurveMin;
            /*0x20*/ UnityEngine.AnimationCurve m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            /*0xb454cc*/ UnityEngine.AnimationCurve get_curveMin();
            /*0xb454d4*/ float get_constant();
            /*0xb454dc*/ UnityEngine.AnimationCurve get_curve();
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

        struct TrailModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x2b0bc48*/ bool get_enabled_Injected(ref UnityEngine.ParticleSystem.TrailModule _unity_self);
            static /*0x2b0bcc8*/ bool get_worldSpace_Injected(ref UnityEngine.ParticleSystem.TrailModule _unity_self);
            /*0xb45a4c*/ TrailModule(UnityEngine.ParticleSystem particleSystem);
            /*0xb45a54*/ bool get_enabled();
            /*0xb45a94*/ bool get_worldSpace();
        }
    }

    enum ParticleSystemRenderMode
    {
        Billboard = 0,
        Stretch = 1,
        HorizontalBillboard = 2,
        VerticalBillboard = 3,
        Mesh = 4,
        None = 5,
    }

    enum ParticleSystemCurveMode
    {
        Constant = 0,
        Curve = 1,
        TwoCurves = 2,
        TwoConstants = 3,
    }

    enum ParticleSystemAnimationMode
    {
        Grid = 0,
        Sprites = 1,
    }

    enum ParticleSystemAnimationType
    {
        WholeSheet = 0,
        SingleRow = 1,
    }

    enum ParticleSystemSimulationSpace
    {
        Local = 0,
        World = 1,
        Custom = 2,
    }

    enum ParticleSystemStopBehavior
    {
        StopEmittingAndClear = 0,
        StopEmitting = 1,
    }

    enum ParticleSystemScalingMode
    {
        Hierarchy = 0,
        Local = 1,
        Shape = 2,
    }

    class ParticleSystemRenderer : UnityEngine.Renderer
    {
        /*0x2b0ac3c*/ UnityEngine.ParticleSystemRenderMode get_renderMode();
        /*0x2b0ac7c*/ float get_sortingFudge();
        /*0x2b0acbc*/ UnityEngine.Material get_trailMaterial();
        /*0x2b0acfc*/ UnityEngine.Mesh get_mesh();
        /*0x2b0ad3c*/ int GetMeshes(UnityEngine.Mesh[] meshes);
        /*0x2b0ad8c*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x2b0adf4*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
    }

    namespace Rendering
    {
        enum UVChannelFlags
        {
            UV0 = 1,
            UV1 = 2,
            UV2 = 4,
            UV3 = 8,
        }
    }
}
