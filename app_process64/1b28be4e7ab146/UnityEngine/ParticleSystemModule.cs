class <Module>
{
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        static /*0x7f07cd8*/ void ResetPreMappedBufferMemory();
        static /*0x7f07d00*/ void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount);
        static /*0x7f08330*/ Unity.Jobs.JobHandle ScheduleManagedJob(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData);
        static /*0x7f083e0*/ void CopyManagedJobData(void* systemPtr, ref UnityEngine.ParticleSystemJobs.NativeParticleData particleData);
        static /*0x7f08424*/ bool UserJobCanBeScheduled();
        static /*0x7f05380*/ bool get_isPlaying_Injected(nint _unity_self);
        static /*0x7f05434*/ bool get_isEmitting_Injected(nint _unity_self);
        static /*0x7f054e8*/ bool get_isStopped_Injected(nint _unity_self);
        static /*0x7f0559c*/ bool get_isPaused_Injected(nint _unity_self);
        static /*0x7f05650*/ int get_particleCount_Injected(nint _unity_self);
        static /*0x7f05704*/ float get_time_Injected(nint _unity_self);
        static /*0x7f057c8*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x7f0588c*/ float get_totalTime_Injected(nint _unity_self);
        static /*0x7f05940*/ uint get_randomSeed_Injected(nint _unity_self);
        static /*0x7f059fc*/ void set_randomSeed_Injected(nint _unity_self, uint value);
        static /*0x7f05ab8*/ bool get_useAutoRandomSeed_Injected(nint _unity_self);
        static /*0x7f05b74*/ void set_useAutoRandomSeed_Injected(nint _unity_self, bool value);
        static /*0x7f05bb8*/ bool get_proceduralSimulationSupported_Injected(nint _unity_self);
        static /*0x7f05c74*/ float GetParticleCurrentSize_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7f05d58*/ void GetParticleCurrentSize3D_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Vector3 ret);
        static /*0x7f05e44*/ void GetParticleCurrentColor_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Color32 ret);
        static /*0x7f05f18*/ int GetParticleMeshIndex_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7f060d0*/ void SetParticles_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper particles, int size, int offset);
        static /*0x7f061e8*/ void SetParticlesWithNativeArray_Injected(nint _unity_self, nint particles, int particlesLength, int size, int offset);
        static /*0x7f064a8*/ int GetParticles_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper particles, int size, int offset);
        static /*0x7f065c0*/ int GetParticlesWithNativeArray_Injected(nint _unity_self, nint particles, int particlesLength, int size, int offset);
        static /*0x7f068cc*/ void SetCustomParticleData_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper customData, UnityEngine.ParticleSystemCustomData streamIndex);
        static /*0x7f06b30*/ int GetCustomParticleData_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper customData, UnityEngine.ParticleSystemCustomData streamIndex);
        static /*0x7f06c38*/ void GetPlaybackState_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.PlaybackState ret);
        static /*0x7f06cfc*/ void SetPlaybackState_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.PlaybackState playbackState);
        static /*0x7f06dc0*/ void GetTrailDataInternal_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Trails trailData);
        static /*0x7f070ec*/ void SetTrails_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Trails trailData);
        static /*0x7f071d8*/ void Simulate_Injected(nint _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep);
        static /*0x7f072f4*/ void Play_Injected(nint _unity_self, bool withChildren);
        static /*0x7f073c0*/ void Pause_Injected(nint _unity_self, bool withChildren);
        static /*0x7f0749c*/ void Stop_Injected(nint _unity_self, bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        static /*0x7f07588*/ void Clear_Injected(nint _unity_self, bool withChildren);
        static /*0x7f07654*/ bool IsAlive_Injected(nint _unity_self, bool withChildren);
        static /*0x7f07724*/ void Emit_Internal_Injected(nint _unity_self, int count);
        static /*0x7f077f8*/ void Emit_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        static /*0x7f0784c*/ void EmitOld_Internal_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7f07bec*/ void TriggerSubEmitterForParticle_Injected(nint _unity_self, int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7f07c40*/ void TriggerSubEmitterForParticles_Injected(nint _unity_self, int subEmitterIndex, ref UnityEngine.Bindings.BlittableListWrapper particles);
        static /*0x7f07c94*/ void TriggerSubEmitterForAllParticles_Injected(nint _unity_self, int subEmitterIndex);
        static /*0x7f07dbc*/ void AllocateAxisOfRotationAttribute_Injected(nint _unity_self);
        static /*0x7f07e70*/ void AllocateMeshIndexAttribute_Injected(nint _unity_self);
        static /*0x7f07f2c*/ void AllocateCustomDataAttribute_Injected(nint _unity_self, UnityEngine.ParticleSystemCustomData stream);
        static /*0x7f07fe8*/ bool get_has3DParticleRotations_Injected(nint _unity_self);
        static /*0x7f0809c*/ bool get_hasNonUniformParticleSizes_Injected(nint _unity_self);
        static /*0x7f08150*/ void* GetManagedJobData_Injected(nint _unity_self);
        static /*0x7f0821c*/ void GetManagedJobHandle_Injected(nint _unity_self, ref Unity.Jobs.JobHandle ret);
        static /*0x7f082ec*/ void SetManagedJobHandle_Injected(nint _unity_self, ref Unity.Jobs.JobHandle handle);
        static /*0x7f0838c*/ void ScheduleManagedJob_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData, ref Unity.Jobs.JobHandle ret);
        /*0x7f087a4*/ ParticleSystem();
        /*0x7f03794*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x7f039d0*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x7f039d4*/ float get_startDelay();
        /*0x7f03a84*/ void set_startDelay(float value);
        /*0x7f03b38*/ bool get_loop();
        /*0x7f03bcc*/ void set_loop(bool value);
        /*0x7f03c74*/ bool get_playOnAwake();
        /*0x7f03d08*/ void set_playOnAwake(bool value);
        /*0x7f03db0*/ float get_duration();
        /*0x7f03e40*/ float get_playbackSpeed();
        /*0x7f03ed0*/ void set_playbackSpeed(float value);
        /*0x7f03f84*/ bool get_enableEmission();
        /*0x7f04038*/ void set_enableEmission(bool value);
        /*0x7f040e0*/ float get_emissionRate();
        /*0x7f04170*/ void set_emissionRate(float value);
        /*0x7f042a8*/ float get_startSpeed();
        /*0x7f04338*/ void set_startSpeed(float value);
        /*0x7f043ec*/ float get_startSize();
        /*0x7f0447c*/ void set_startSize(float value);
        /*0x7f04530*/ UnityEngine.Color get_startColor();
        /*0x7f04618*/ void set_startColor(UnityEngine.Color value);
        /*0x7f047b4*/ float get_startRotation();
        /*0x7f04844*/ void set_startRotation(float value);
        /*0x7f048f8*/ UnityEngine.Vector3 get_startRotation3D();
        /*0x7f04aa8*/ void set_startRotation3D(UnityEngine.Vector3 value);
        /*0x7f04c5c*/ float get_startLifetime();
        /*0x7f04cec*/ void set_startLifetime(float value);
        /*0x7f04da0*/ float get_gravityModifier();
        /*0x7f04e30*/ void set_gravityModifier(float value);
        /*0x7f04ee4*/ int get_maxParticles();
        /*0x7f04f74*/ void set_maxParticles(int value);
        /*0x7f0501c*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
        /*0x7f050ac*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
        /*0x7f05154*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
        /*0x7f051e4*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
        /*0x7f0528c*/ bool get_automaticCullingEnabled();
        /*0x7f05308*/ bool get_isPlaying();
        /*0x7f053bc*/ bool get_isEmitting();
        /*0x7f05470*/ bool get_isStopped();
        /*0x7f05524*/ bool get_isPaused();
        /*0x7f055d8*/ int get_particleCount();
        /*0x7f0568c*/ float get_time();
        /*0x7f05740*/ void set_time(float value);
        /*0x7f05814*/ float get_totalTime();
        /*0x7f058c8*/ uint get_randomSeed();
        /*0x7f0597c*/ void set_randomSeed(uint value);
        /*0x7f05a40*/ bool get_useAutoRandomSeed();
        /*0x7f05af4*/ void set_useAutoRandomSeed(bool value);
        /*0x7f05290*/ bool get_proceduralSimulationSupported();
        /*0x7f05bf4*/ float GetParticleCurrentSize(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7f05cb8*/ UnityEngine.Vector3 GetParticleCurrentSize3D(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7f05dac*/ UnityEngine.Color32 GetParticleCurrentColor(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7f05e98*/ int GetParticleMeshIndex(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7f05f5c*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x7f0612c*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x7f06134*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x7f06140*/ void SetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x7f06254*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x7f062e0*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x7f062e8*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7f062f4*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x7f06504*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x7f0650c*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x7f06518*/ int GetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x7f0662c*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x7f066b8*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x7f066c0*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7f066cc*/ void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x7f06920*/ int GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x7f06b84*/ UnityEngine.ParticleSystem.PlaybackState GetPlaybackState();
        /*0x7f06c7c*/ void SetPlaybackState(UnityEngine.ParticleSystem.PlaybackState playbackState);
        /*0x7f06d40*/ void GetTrailDataInternal(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x7f06e04*/ UnityEngine.ParticleSystem.Trails GetTrails();
        /*0x7f0700c*/ int GetTrails(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x7f0706c*/ void SetTrails(UnityEngine.ParticleSystem.Trails trailData);
        /*0x7f07130*/ void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep);
        /*0x7f07244*/ void Simulate(float t, bool withChildren, bool restart);
        /*0x7f07254*/ void Simulate(float t, bool withChildren);
        /*0x7f07264*/ void Simulate(float t);
        /*0x7f07274*/ void Play(bool withChildren);
        /*0x7f07338*/ void Play();
        /*0x7f07340*/ void Pause(bool withChildren);
        /*0x7f07404*/ void Pause();
        /*0x7f0740c*/ void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        /*0x7f074f0*/ void Stop(bool withChildren);
        /*0x7f074fc*/ void Stop();
        /*0x7f07508*/ void Clear(bool withChildren);
        /*0x7f075cc*/ void Clear();
        /*0x7f075d4*/ bool IsAlive(bool withChildren);
        /*0x7f07698*/ bool IsAlive();
        /*0x7f076a0*/ void Emit(int count);
        /*0x7f076a4*/ void Emit_Internal(int count);
        /*0x7f07768*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x7f03950*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7f07890*/ void TriggerSubEmitter(int subEmitterIndex);
        /*0x7f07914*/ void TriggerSubEmitter(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7f079ec*/ void TriggerSubEmitter(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7f0795c*/ void TriggerSubEmitterForParticle(int subEmitterIndex, UnityEngine.ParticleSystem.Particle particle);
        /*0x7f079f8*/ void TriggerSubEmitterForParticles(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7f07894*/ void TriggerSubEmitterForAllParticles(int subEmitterIndex);
        /*0x7f07d44*/ void AllocateAxisOfRotationAttribute();
        /*0x7f07df8*/ void AllocateMeshIndexAttribute();
        /*0x7f07eac*/ void AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData stream);
        /*0x7f07f70*/ bool get_has3DParticleRotations();
        /*0x7f08024*/ bool get_hasNonUniformParticleSizes();
        /*0x7f080d8*/ void* GetManagedJobData();
        /*0x7f0818c*/ Unity.Jobs.JobHandle GetManagedJobHandle();
        /*0x7f08260*/ void SetManagedJobHandle(Unity.Jobs.JobHandle handle);
        /*0x7f03a28*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x7f03fdc*/ UnityEngine.ParticleSystem.EmissionModule get_emission();
        /*0x7f0845c*/ UnityEngine.ParticleSystem.ShapeModule get_shape();
        /*0x7f08484*/ UnityEngine.ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime();
        /*0x7f084ac*/ UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime();
        /*0x7f084d4*/ UnityEngine.ParticleSystem.InheritVelocityModule get_inheritVelocity();
        /*0x7f084fc*/ UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed();
        /*0x7f08524*/ UnityEngine.ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime();
        /*0x7f0854c*/ UnityEngine.ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime();
        /*0x7f08574*/ UnityEngine.ParticleSystem.ColorBySpeedModule get_colorBySpeed();
        /*0x7f0859c*/ UnityEngine.ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime();
        /*0x7f085c4*/ UnityEngine.ParticleSystem.SizeBySpeedModule get_sizeBySpeed();
        /*0x7f085ec*/ UnityEngine.ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime();
        /*0x7f08614*/ UnityEngine.ParticleSystem.RotationBySpeedModule get_rotationBySpeed();
        /*0x7f0863c*/ UnityEngine.ParticleSystem.ExternalForcesModule get_externalForces();
        /*0x7f08664*/ UnityEngine.ParticleSystem.NoiseModule get_noise();
        /*0x7f0868c*/ UnityEngine.ParticleSystem.CollisionModule get_collision();
        /*0x7f086b4*/ UnityEngine.ParticleSystem.TriggerModule get_trigger();
        /*0x7f086dc*/ UnityEngine.ParticleSystem.SubEmittersModule get_subEmitters();
        /*0x7f08704*/ UnityEngine.ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation();
        /*0x7f0872c*/ UnityEngine.ParticleSystem.LightsModule get_lights();
        /*0x7f08754*/ UnityEngine.ParticleSystem.TrailModule get_trails();
        /*0x7f0877c*/ UnityEngine.ParticleSystem.CustomDataModule get_customData();

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x7f088fc*/ void get_startColorBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradientBlittable ret);
            static /*0x7f08940*/ void set_startColorBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradientBlittable value);
            /*0x7f0844c*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0x7f03e04*/ float get_duration();
            /*0x7f03b90*/ bool get_loop();
            /*0x7f03c30*/ void set_loop(bool value);
            /*0x7f03a48*/ float get_startDelayMultiplier();
            /*0x7f03aec*/ void set_startDelayMultiplier(float value);
            /*0x7f04cb0*/ float get_startLifetimeMultiplier();
            /*0x7f04d54*/ void set_startLifetimeMultiplier(float value);
            /*0x7f042fc*/ float get_startSpeedMultiplier();
            /*0x7f043a0*/ void set_startSpeedMultiplier(float value);
            /*0x7f04440*/ float get_startSizeMultiplier();
            /*0x7f044e4*/ void set_startSizeMultiplier(float value);
            /*0x7f04808*/ float get_startRotationMultiplier();
            /*0x7f048ac*/ void set_startRotationMultiplier(float value);
            /*0x7f049f4*/ float get_startRotationXMultiplier();
            /*0x7f04b78*/ void set_startRotationXMultiplier(float value);
            /*0x7f04a30*/ float get_startRotationYMultiplier();
            /*0x7f04bc4*/ void set_startRotationYMultiplier(float value);
            /*0x7f04a6c*/ float get_startRotationZMultiplier();
            /*0x7f04c10*/ void set_startRotationZMultiplier(float value);
            /*0x7f04570*/ UnityEngine.ParticleSystem.MinMaxGradient get_startColor();
            /*0x7f04720*/ void set_startColor(UnityEngine.ParticleSystem.MinMaxGradient value);
            /*0x7f087ac*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable get_startColorBlittable();
            /*0x7f088b8*/ void set_startColorBlittable(UnityEngine.ParticleSystem.MinMaxGradientBlittable value);
            /*0x7f04df4*/ float get_gravityModifierMultiplier();
            /*0x7f04e98*/ void set_gravityModifierMultiplier(float value);
            /*0x7f05070*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
            /*0x7f05110*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
            /*0x7f03e94*/ float get_simulationSpeed();
            /*0x7f03f38*/ void set_simulationSpeed(float value);
            /*0x7f051a8*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
            /*0x7f05248*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
            /*0x7f03ccc*/ bool get_playOnAwake();
            /*0x7f03d6c*/ void set_playOnAwake(bool value);
            /*0x7f04f38*/ int get_maxParticles();
            /*0x7f04fd8*/ void set_maxParticles(int value);
        }

        struct EmissionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x7f089fc*/ void set_rateOverTimeBlittable_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            /*0x7f08454*/ EmissionModule(UnityEngine.ParticleSystem particleSystem);
            /*0x7f03ffc*/ bool get_enabled();
            /*0x7f0409c*/ void set_enabled(bool value);
            /*0x7f04230*/ void set_rateOverTime(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x7f089b8*/ void set_rateOverTimeBlittable(UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            /*0x7f04134*/ float get_rateOverTimeMultiplier();
        }

        struct ShapeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0847c*/ ShapeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CollisionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f086ac*/ CollisionModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TriggerModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f086d4*/ TriggerModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SubEmittersModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f086fc*/ SubEmittersModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TextureSheetAnimationModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f08724*/ TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem);
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

            /*0x7f038cc*/ void set_lifetime(float value);
            /*0x7f038b4*/ void set_position(UnityEngine.Vector3 value);
            /*0x7f038c0*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x7f08a40*/ void set_remainingLifetime(float value);
            /*0x7f038d4*/ void set_startLifetime(float value);
            /*0x7f03940*/ void set_startColor(UnityEngine.Color32 value);
            /*0x7f03948*/ void set_randomSeed(uint value);
            /*0x7f038dc*/ void set_startSize(float value);
            /*0x7f038e8*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0x7f03914*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
        }

        struct MinMaxCurve
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ UnityEngine.AnimationCurve m_CurveMin;
            /*0x20*/ UnityEngine.AnimationCurve m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x7f041c0*/ UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(float constant);
            /*0x7f08a48*/ MinMaxCurve(float constant);
        }

        struct MinMaxCurveBlittable
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ nint m_CurveMin;
            /*0x20*/ nint m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x7f08984*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable op_Implicit(UnityEngine.ParticleSystem.MinMaxCurve minMaxCurve);
            static /*0x7f08a8c*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable FromMixMaxCurve(ref UnityEngine.ParticleSystem.MinMaxCurve minMaxCurve);
        }

        struct MinMaxGradient
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ UnityEngine.Gradient m_GradientMin;
            /*0x20*/ UnityEngine.Gradient m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x7f046c0*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color);
            /*0x7f08ac0*/ MinMaxGradient(UnityEngine.Color color);
            /*0x7f0460c*/ UnityEngine.Color get_color();
        }

        struct MinMaxGradientBlittable
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ nint m_GradientMin;
            /*0x20*/ nint m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x7f08824*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable);
            static /*0x7f08860*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable op_Implicit(UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient);
            static /*0x7f08c20*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable FromMixMaxGradient(ref UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient);
            static /*0x7f08b24*/ UnityEngine.ParticleSystem.MinMaxGradient ToMinMaxGradient(ref UnityEngine.ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable);
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

        struct PlaybackState
        {
            /*0x10*/ float m_AccumulatedDt;
            /*0x14*/ float m_StartDelay;
            /*0x18*/ float m_PlaybackTime;
            /*0x1c*/ int m_RingBufferIndex;
            /*0x20*/ UnityEngine.ParticleSystem.PlaybackState.Emission m_Emission;
            /*0x38*/ UnityEngine.ParticleSystem.PlaybackState.Initial m_Initial;
            /*0x78*/ UnityEngine.ParticleSystem.PlaybackState.Shape m_Shape;
            /*0xd4*/ UnityEngine.ParticleSystem.PlaybackState.Force m_Force;
            /*0x114*/ UnityEngine.ParticleSystem.PlaybackState.Collision m_Collision;
            /*0x154*/ UnityEngine.ParticleSystem.PlaybackState.Noise m_Noise;
            /*0x158*/ UnityEngine.ParticleSystem.PlaybackState.Lights m_Lights;
            /*0x16c*/ UnityEngine.ParticleSystem.PlaybackState.Trail m_Trail;

            struct Seed
            {
                /*0x10*/ uint x;
                /*0x14*/ uint y;
                /*0x18*/ uint z;
                /*0x1c*/ uint w;
            }

            struct Seed4
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed x;
                /*0x20*/ UnityEngine.ParticleSystem.PlaybackState.Seed y;
                /*0x30*/ UnityEngine.ParticleSystem.PlaybackState.Seed z;
                /*0x40*/ UnityEngine.ParticleSystem.PlaybackState.Seed w;
            }

            struct Emission
            {
                /*0x10*/ float m_ParticleSpacing;
                /*0x14*/ float m_ToEmitAccumulator;
                /*0x18*/ UnityEngine.ParticleSystem.PlaybackState.Seed m_Random;
            }

            struct Initial
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
            }

            struct Shape
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
                /*0x50*/ float m_RadiusTimer;
                /*0x54*/ float m_RadiusTimerPrev;
                /*0x58*/ float m_ArcTimer;
                /*0x5c*/ float m_ArcTimerPrev;
                /*0x60*/ float m_MeshSpawnTimer;
                /*0x64*/ float m_MeshSpawnTimerPrev;
                /*0x68*/ int m_OrderedMeshVertexIndex;
            }

            struct Force
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
            }

            struct Collision
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
            }

            struct Noise
            {
                /*0x10*/ float m_ScrollOffset;
            }

            struct Lights
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed m_Random;
                /*0x20*/ float m_ParticleEmissionCounter;
            }

            struct Trail
            {
                /*0x10*/ float m_Timer;
            }
        }

        struct Trails
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Vector4> positions;
            /*0x18*/ System.Collections.Generic.List<int> frontPositions;
            /*0x20*/ System.Collections.Generic.List<int> backPositions;
            /*0x28*/ System.Collections.Generic.List<int> positionCounts;
            /*0x30*/ System.Collections.Generic.List<float> textureOffsets;
            /*0x38*/ int maxTrailCount;
            /*0x3c*/ int maxPositionsPerTrailCount;

            /*0x7f06e58*/ void Allocate();
        }

        struct VelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f084a4*/ VelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LimitVelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f084cc*/ LimitVelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct InheritVelocityModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f084f4*/ InheritVelocityModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LifetimeByEmitterSpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0851c*/ LifetimeByEmitterSpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ForceOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f08544*/ ForceOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0856c*/ ColorOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f08594*/ ColorBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f085bc*/ SizeOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f085e4*/ SizeBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0860c*/ RotationOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f08634*/ RotationBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ExternalForcesModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0865c*/ ExternalForcesModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct NoiseModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f08684*/ NoiseModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LightsModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0874c*/ LightsModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TrailModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f08774*/ TrailModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CustomDataModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7f0879c*/ CustomDataModule(UnityEngine.ParticleSystem particleSystem);
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

    enum ParticleSystemMeshDistribution
    {
        UniformRandom = 0,
        NonUniformRandom = 1,
    }

    enum ParticleSystemSortMode
    {
        None = 0,
        Distance = 1,
        OldestInFront = 2,
        YoungestInFront = 3,
        Depth = 4,
        DistanceReverse = 5,
        DepthReverse = 6,
    }

    enum ParticleSystemRenderSpace
    {
        View = 0,
        World = 1,
        Local = 2,
        Facing = 3,
        Velocity = 4,
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

    enum ParticleSystemVertexStream
    {
        Position = 0,
        Normal = 1,
        Tangent = 2,
        Color = 3,
        UV = 4,
        UV2 = 5,
        UV3 = 6,
        UV4 = 7,
        AnimBlend = 8,
        AnimFrame = 9,
        Center = 10,
        VertexID = 11,
        SizeX = 12,
        SizeXY = 13,
        SizeXYZ = 14,
        Rotation = 15,
        Rotation3D = 16,
        RotationSpeed = 17,
        RotationSpeed3D = 18,
        Velocity = 19,
        Speed = 20,
        AgePercent = 21,
        InvStartLifetime = 22,
        StableRandomX = 23,
        StableRandomXY = 24,
        StableRandomXYZ = 25,
        StableRandomXYZW = 26,
        VaryingRandomX = 27,
        VaryingRandomXY = 28,
        VaryingRandomXYZ = 29,
        VaryingRandomXYZW = 30,
        Custom1X = 31,
        Custom1XY = 32,
        Custom1XYZ = 33,
        Custom1XYZW = 34,
        Custom2X = 35,
        Custom2XY = 36,
        Custom2XYZ = 37,
        Custom2XYZW = 38,
        NoiseSumX = 39,
        NoiseSumXY = 40,
        NoiseSumXYZ = 41,
        NoiseImpulseX = 42,
        NoiseImpulseXY = 43,
        NoiseImpulseXYZ = 44,
        MeshIndex = 45,
        ParticleIndex = 46,
        ColorPackedAsTwoFloats = 47,
        MeshAxisOfRotation = 48,
        NextTrailCenter = 49,
        PreviousTrailCenter = 50,
        PercentageAlongTrail = 51,
        TrailWidth = 52,
    }

    enum ParticleSystemCustomData
    {
        Custom1 = 0,
        Custom2 = 1,
    }

    enum ParticleSystemBakeMeshOptions
    {
        BakeRotationAndScale = 1,
        BakePosition = 2,
        Default = 0,
    }

    enum ParticleSystemBakeTextureOptions
    {
        BakeRotationAndScale = 1,
        BakePosition = 2,
        PerVertex = 4,
        PerParticle = 8,
        IncludeParticleIndices = 16,
        Default = 4,
    }

    enum ParticleSystemVertexStreams
    {
        Position = 1,
        Normal = 2,
        Tangent = 4,
        Color = 8,
        UV = 16,
        UV2BlendAndFrame = 32,
        CenterAndVertexID = 64,
        Size = 128,
        Rotation = 256,
        Velocity = 512,
        Lifetime = 1024,
        Custom1 = 2048,
        Custom2 = 4096,
        Random = 8192,
        None = 0,
        All = 2147483647,
    }

    class ParticleSystemRenderer : UnityEngine.Renderer
    {
        static /*0x7f0a388*/ UnityEngine.ParticleSystemRenderSpace get_alignment_Injected(nint _unity_self);
        static /*0x7f0a444*/ void set_alignment_Injected(nint _unity_self, UnityEngine.ParticleSystemRenderSpace value);
        static /*0x7f0a500*/ UnityEngine.ParticleSystemRenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x7f0a5bc*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.ParticleSystemRenderMode value);
        static /*0x7f0a678*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution_Injected(nint _unity_self);
        static /*0x7f0a734*/ void set_meshDistribution_Injected(nint _unity_self, UnityEngine.ParticleSystemMeshDistribution value);
        static /*0x7f0a7f0*/ UnityEngine.ParticleSystemSortMode get_sortMode_Injected(nint _unity_self);
        static /*0x7f0a8ac*/ void set_sortMode_Injected(nint _unity_self, UnityEngine.ParticleSystemSortMode value);
        static /*0x7f0a968*/ float get_lengthScale_Injected(nint _unity_self);
        static /*0x7f0aa2c*/ void set_lengthScale_Injected(nint _unity_self, float value);
        static /*0x7f0aaf0*/ float get_velocityScale_Injected(nint _unity_self);
        static /*0x7f0abb4*/ void set_velocityScale_Injected(nint _unity_self, float value);
        static /*0x7f0ac78*/ float get_cameraVelocityScale_Injected(nint _unity_self);
        static /*0x7f0ad3c*/ void set_cameraVelocityScale_Injected(nint _unity_self, float value);
        static /*0x7f0ae00*/ float get_normalDirection_Injected(nint _unity_self);
        static /*0x7f0aec4*/ void set_normalDirection_Injected(nint _unity_self, float value);
        static /*0x7f0af88*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x7f0b04c*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x7f0b110*/ float get_sortingFudge_Injected(nint _unity_self);
        static /*0x7f0b1d4*/ void set_sortingFudge_Injected(nint _unity_self, float value);
        static /*0x7f0b298*/ float get_minParticleSize_Injected(nint _unity_self);
        static /*0x7f0b35c*/ void set_minParticleSize_Injected(nint _unity_self, float value);
        static /*0x7f0b420*/ float get_maxParticleSize_Injected(nint _unity_self);
        static /*0x7f0b4e4*/ void set_maxParticleSize_Injected(nint _unity_self, float value);
        static /*0x7f0b5c8*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f0b69c*/ void set_pivot_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7f0b778*/ void get_flip_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f0b84c*/ void set_flip_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7f0b908*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x7f0b9c4*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x7f0ba9c*/ nint get_trailMaterial_Injected(nint _unity_self);
        static /*0x7f0bb8c*/ void set_trailMaterial_Injected(nint _unity_self, nint value);
        static /*0x7f0bc84*/ void set_oldTrailMaterial_Injected(nint _unity_self, nint value);
        static /*0x7f0bd40*/ bool get_enableGPUInstancing_Injected(nint _unity_self);
        static /*0x7f0bdfc*/ void set_enableGPUInstancing_Injected(nint _unity_self, bool value);
        static /*0x7f0beb8*/ bool get_allowRoll_Injected(nint _unity_self);
        static /*0x7f0bf74*/ void set_allowRoll_Injected(nint _unity_self, bool value);
        static /*0x7f0c030*/ bool get_freeformStretching_Injected(nint _unity_self);
        static /*0x7f0c0ec*/ void set_freeformStretching_Injected(nint _unity_self, bool value);
        static /*0x7f0c1a8*/ bool get_rotateWithStretchDirection_Injected(nint _unity_self);
        static /*0x7f0c264*/ void set_rotateWithStretchDirection_Injected(nint _unity_self, bool value);
        static /*0x7f0c33c*/ nint get_mesh_Injected(nint _unity_self);
        static /*0x7f0c42c*/ void set_mesh_Injected(nint _unity_self, nint value);
        static /*0x7f0c520*/ int GetMeshes_Injected(nint _unity_self, UnityEngine.Mesh[] meshes);
        static /*0x7f0c624*/ void SetMeshes_Injected(nint _unity_self, UnityEngine.Mesh[] meshes, int size);
        static /*0x7f0c82c*/ int GetMeshWeightings_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper weightings);
        static /*0x7f0c9a4*/ void SetMeshWeightings_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper weightings, int size);
        static /*0x7f0ca88*/ int get_meshCount_Injected(nint _unity_self);
        static /*0x7f0cafc*/ void BakeMesh_Injected(nint _unity_self, nint mesh, nint camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        static /*0x7f0cb90*/ void BakeTrailsMesh_Injected(nint _unity_self, nint mesh, nint camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        static /*0x7f0ce28*/ nint BakeTextureNoIndicesInternal_Injected(nint _unity_self, nint verticesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        static /*0x7f0d0ac*/ void BakeTextureInternal_Injected(nint _unity_self, nint verticesTexture, nint indicesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount, ref UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret);
        static /*0x7f0d348*/ void BakeTrailsTextureInternal_Injected(nint _unity_self, nint verticesTexture, nint indicesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount, ref UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret);
        static /*0x7f0d3cc*/ int get_activeVertexStreamsCount_Injected(nint _unity_self);
        static /*0x7f0d408*/ void SetActiveVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x7f0d44c*/ void GetActiveVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x7f0d508*/ int get_activeTrailVertexStreamsCount_Injected(nint _unity_self);
        static /*0x7f0d73c*/ void SetActiveTrailVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x7f0d978*/ void GetActiveTrailVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        /*0x7f0d9bc*/ ParticleSystemRenderer();
        /*0x7f08c7c*/ void EnableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7f098ec*/ void DisableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7f098f4*/ bool AreVertexStreamsEnabled(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7f09b4c*/ UnityEngine.ParticleSystemVertexStreams GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7f08c84*/ void Internal_SetVertexStreams(UnityEngine.ParticleSystemVertexStreams streams, bool enabled);
        /*0x7f09910*/ UnityEngine.ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7f09fb8*/ void BakeMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x7f09ff8*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x7f0a164*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x7f0a1a4*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x7f0a310*/ UnityEngine.ParticleSystemRenderSpace get_alignment();
        /*0x7f0a3c4*/ void set_alignment(UnityEngine.ParticleSystemRenderSpace value);
        /*0x7f0a488*/ UnityEngine.ParticleSystemRenderMode get_renderMode();
        /*0x7f0a53c*/ void set_renderMode(UnityEngine.ParticleSystemRenderMode value);
        /*0x7f0a600*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution();
        /*0x7f0a6b4*/ void set_meshDistribution(UnityEngine.ParticleSystemMeshDistribution value);
        /*0x7f0a778*/ UnityEngine.ParticleSystemSortMode get_sortMode();
        /*0x7f0a82c*/ void set_sortMode(UnityEngine.ParticleSystemSortMode value);
        /*0x7f0a8f0*/ float get_lengthScale();
        /*0x7f0a9a4*/ void set_lengthScale(float value);
        /*0x7f0aa78*/ float get_velocityScale();
        /*0x7f0ab2c*/ void set_velocityScale(float value);
        /*0x7f0ac00*/ float get_cameraVelocityScale();
        /*0x7f0acb4*/ void set_cameraVelocityScale(float value);
        /*0x7f0ad88*/ float get_normalDirection();
        /*0x7f0ae3c*/ void set_normalDirection(float value);
        /*0x7f0af10*/ float get_shadowBias();
        /*0x7f0afc4*/ void set_shadowBias(float value);
        /*0x7f0b098*/ float get_sortingFudge();
        /*0x7f0b14c*/ void set_sortingFudge(float value);
        /*0x7f0b220*/ float get_minParticleSize();
        /*0x7f0b2d4*/ void set_minParticleSize(float value);
        /*0x7f0b3a8*/ float get_maxParticleSize();
        /*0x7f0b45c*/ void set_maxParticleSize(float value);
        /*0x7f0b530*/ UnityEngine.Vector3 get_pivot();
        /*0x7f0b60c*/ void set_pivot(UnityEngine.Vector3 value);
        /*0x7f0b6e0*/ UnityEngine.Vector3 get_flip();
        /*0x7f0b7bc*/ void set_flip(UnityEngine.Vector3 value);
        /*0x7f0b890*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x7f0b944*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x7f0ba08*/ UnityEngine.Material get_trailMaterial();
        /*0x7f0bad8*/ void set_trailMaterial(UnityEngine.Material value);
        /*0x7f0bbd0*/ void set_oldTrailMaterial(UnityEngine.Material value);
        /*0x7f0bcc8*/ bool get_enableGPUInstancing();
        /*0x7f0bd7c*/ void set_enableGPUInstancing(bool value);
        /*0x7f0be40*/ bool get_allowRoll();
        /*0x7f0bef4*/ void set_allowRoll(bool value);
        /*0x7f0bfb8*/ bool get_freeformStretching();
        /*0x7f0c06c*/ void set_freeformStretching(bool value);
        /*0x7f0c130*/ bool get_rotateWithStretchDirection();
        /*0x7f0c1e4*/ void set_rotateWithStretchDirection(bool value);
        /*0x7f0c2a8*/ UnityEngine.Mesh get_mesh();
        /*0x7f0c378*/ void set_mesh(UnityEngine.Mesh value);
        /*0x7f0c470*/ int GetMeshes(UnityEngine.Mesh[] meshes);
        /*0x7f0c564*/ void SetMeshes(UnityEngine.Mesh[] meshes, int size);
        /*0x7f0c678*/ void SetMeshes(UnityEngine.Mesh[] meshes);
        /*0x7f0c690*/ int GetMeshWeightings(float[] weightings);
        /*0x7f0c870*/ void SetMeshWeightings(float[] weightings, int size);
        /*0x7f0c9f8*/ void SetMeshWeightings(float[] weightings);
        /*0x7f0ca10*/ int get_meshCount();
        /*0x7f0cac4*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7f0a00c*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7f0cb58*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7f0a1b8*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7f0cbec*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7f0cc24*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7f0ccd4*/ UnityEngine.Texture2D BakeTextureNoIndicesInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x7f0ce94*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7f0cedc*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7f0cf40*/ UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x7f0d130*/ int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7f0d178*/ int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7f0d1dc*/ UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x7f09b50*/ int get_activeVertexStreamsCount();
        /*0x7f09dc0*/ void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x7f09bc8*/ void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x7f0d490*/ int get_activeTrailVertexStreamsCount();
        /*0x7f0d544*/ void SetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x7f0d780*/ void GetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);

        struct BakeTextureOutput
        {
            /*0x10*/ UnityEngine.Texture2D vertices;
            /*0x18*/ UnityEngine.Texture2D indices;
        }
    }

    namespace ParticleSystemJobs
    {
        struct ParticleSystemNativeArray3
        {
            /*0x10*/ Unity.Collections.NativeArray<float> x;
            /*0x20*/ Unity.Collections.NativeArray<float> y;
            /*0x30*/ Unity.Collections.NativeArray<float> z;
        }

        struct ParticleSystemNativeArray4
        {
            /*0x10*/ Unity.Collections.NativeArray<float> x;
            /*0x20*/ Unity.Collections.NativeArray<float> y;
            /*0x30*/ Unity.Collections.NativeArray<float> z;
            /*0x40*/ Unity.Collections.NativeArray<float> w;
        }

        struct ParticleSystemJobData
        {
            /*0x10*/ int <count>k__BackingField;
            /*0x18*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <positions>k__BackingField;
            /*0x48*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <velocities>k__BackingField;
            /*0x78*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <axisOfRotations>k__BackingField;
            /*0xa8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotations>k__BackingField;
            /*0xd8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField;
            /*0x108*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <sizes>k__BackingField;
            /*0x138*/ Unity.Collections.NativeArray<UnityEngine.Color32> <startColors>k__BackingField;
            /*0x148*/ Unity.Collections.NativeArray<float> <aliveTimePercent>k__BackingField;
            /*0x158*/ Unity.Collections.NativeArray<float> <inverseStartLifetimes>k__BackingField;
            /*0x168*/ Unity.Collections.NativeArray<uint> <randomSeeds>k__BackingField;
            /*0x178*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData1>k__BackingField;
            /*0x1b8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData2>k__BackingField;
            /*0x1f8*/ Unity.Collections.NativeArray<int> <meshIndices>k__BackingField;
        }

        struct NativeParticleData
        {
            /*0x10*/ int count;
            /*0x18*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 positions;
            /*0x30*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 velocities;
            /*0x48*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 axisOfRotations;
            /*0x60*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 rotations;
            /*0x78*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 rotationalSpeeds;
            /*0x90*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 sizes;
            /*0xa8*/ void* startColors;
            /*0xb0*/ void* aliveTimePercent;
            /*0xb8*/ void* inverseStartLifetimes;
            /*0xc0*/ void* randomSeeds;
            /*0xc8*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 customData1;
            /*0xe8*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 customData2;
            /*0x108*/ void* meshIndices;

            struct Array3
            {
                /*0x10*/ float* x;
                /*0x18*/ float* y;
                /*0x20*/ float* z;
            }

            struct Array4
            {
                /*0x10*/ float* x;
                /*0x18*/ float* y;
                /*0x20*/ float* z;
                /*0x28*/ float* w;
            }
        }
    }
}
