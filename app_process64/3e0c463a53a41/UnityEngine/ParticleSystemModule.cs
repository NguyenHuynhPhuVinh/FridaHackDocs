class <Module>
{
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        static /*0x7ef08a8*/ void ResetPreMappedBufferMemory();
        static /*0x7ef08d0*/ void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount);
        static /*0x7ef0f00*/ Unity.Jobs.JobHandle ScheduleManagedJob(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData);
        static /*0x7ef0fb0*/ void CopyManagedJobData(void* systemPtr, ref UnityEngine.ParticleSystemJobs.NativeParticleData particleData);
        static /*0x7ef0ff4*/ bool UserJobCanBeScheduled();
        static /*0x7eedf50*/ bool get_isPlaying_Injected(nint _unity_self);
        static /*0x7eee004*/ bool get_isEmitting_Injected(nint _unity_self);
        static /*0x7eee0b8*/ bool get_isStopped_Injected(nint _unity_self);
        static /*0x7eee16c*/ bool get_isPaused_Injected(nint _unity_self);
        static /*0x7eee220*/ int get_particleCount_Injected(nint _unity_self);
        static /*0x7eee2d4*/ float get_time_Injected(nint _unity_self);
        static /*0x7eee398*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x7eee45c*/ float get_totalTime_Injected(nint _unity_self);
        static /*0x7eee510*/ uint get_randomSeed_Injected(nint _unity_self);
        static /*0x7eee5cc*/ void set_randomSeed_Injected(nint _unity_self, uint value);
        static /*0x7eee688*/ bool get_useAutoRandomSeed_Injected(nint _unity_self);
        static /*0x7eee744*/ void set_useAutoRandomSeed_Injected(nint _unity_self, bool value);
        static /*0x7eee788*/ bool get_proceduralSimulationSupported_Injected(nint _unity_self);
        static /*0x7eee844*/ float GetParticleCurrentSize_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7eee928*/ void GetParticleCurrentSize3D_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Vector3 ret);
        static /*0x7eeea14*/ void GetParticleCurrentColor_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Color32 ret);
        static /*0x7eeeae8*/ int GetParticleMeshIndex_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7eeeca0*/ void SetParticles_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper particles, int size, int offset);
        static /*0x7eeedb8*/ void SetParticlesWithNativeArray_Injected(nint _unity_self, nint particles, int particlesLength, int size, int offset);
        static /*0x7eef078*/ int GetParticles_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper particles, int size, int offset);
        static /*0x7eef190*/ int GetParticlesWithNativeArray_Injected(nint _unity_self, nint particles, int particlesLength, int size, int offset);
        static /*0x7eef49c*/ void SetCustomParticleData_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper customData, UnityEngine.ParticleSystemCustomData streamIndex);
        static /*0x7eef700*/ int GetCustomParticleData_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper customData, UnityEngine.ParticleSystemCustomData streamIndex);
        static /*0x7eef808*/ void GetPlaybackState_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.PlaybackState ret);
        static /*0x7eef8cc*/ void SetPlaybackState_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.PlaybackState playbackState);
        static /*0x7eef990*/ void GetTrailDataInternal_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Trails trailData);
        static /*0x7eefcbc*/ void SetTrails_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Trails trailData);
        static /*0x7eefda8*/ void Simulate_Injected(nint _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep);
        static /*0x7eefec4*/ void Play_Injected(nint _unity_self, bool withChildren);
        static /*0x7eeff90*/ void Pause_Injected(nint _unity_self, bool withChildren);
        static /*0x7ef006c*/ void Stop_Injected(nint _unity_self, bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        static /*0x7ef0158*/ void Clear_Injected(nint _unity_self, bool withChildren);
        static /*0x7ef0224*/ bool IsAlive_Injected(nint _unity_self, bool withChildren);
        static /*0x7ef02f4*/ void Emit_Internal_Injected(nint _unity_self, int count);
        static /*0x7ef03c8*/ void Emit_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        static /*0x7ef041c*/ void EmitOld_Internal_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7ef07bc*/ void TriggerSubEmitterForParticle_Injected(nint _unity_self, int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x7ef0810*/ void TriggerSubEmitterForParticles_Injected(nint _unity_self, int subEmitterIndex, ref UnityEngine.Bindings.BlittableListWrapper particles);
        static /*0x7ef0864*/ void TriggerSubEmitterForAllParticles_Injected(nint _unity_self, int subEmitterIndex);
        static /*0x7ef098c*/ void AllocateAxisOfRotationAttribute_Injected(nint _unity_self);
        static /*0x7ef0a40*/ void AllocateMeshIndexAttribute_Injected(nint _unity_self);
        static /*0x7ef0afc*/ void AllocateCustomDataAttribute_Injected(nint _unity_self, UnityEngine.ParticleSystemCustomData stream);
        static /*0x7ef0bb8*/ bool get_has3DParticleRotations_Injected(nint _unity_self);
        static /*0x7ef0c6c*/ bool get_hasNonUniformParticleSizes_Injected(nint _unity_self);
        static /*0x7ef0d20*/ void* GetManagedJobData_Injected(nint _unity_self);
        static /*0x7ef0dec*/ void GetManagedJobHandle_Injected(nint _unity_self, ref Unity.Jobs.JobHandle ret);
        static /*0x7ef0ebc*/ void SetManagedJobHandle_Injected(nint _unity_self, ref Unity.Jobs.JobHandle handle);
        static /*0x7ef0f5c*/ void ScheduleManagedJob_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData, ref Unity.Jobs.JobHandle ret);
        /*0x7ef1374*/ ParticleSystem();
        /*0x7eec364*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x7eec5a0*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x7eec5a4*/ float get_startDelay();
        /*0x7eec654*/ void set_startDelay(float value);
        /*0x7eec708*/ bool get_loop();
        /*0x7eec79c*/ void set_loop(bool value);
        /*0x7eec844*/ bool get_playOnAwake();
        /*0x7eec8d8*/ void set_playOnAwake(bool value);
        /*0x7eec980*/ float get_duration();
        /*0x7eeca10*/ float get_playbackSpeed();
        /*0x7eecaa0*/ void set_playbackSpeed(float value);
        /*0x7eecb54*/ bool get_enableEmission();
        /*0x7eecc08*/ void set_enableEmission(bool value);
        /*0x7eeccb0*/ float get_emissionRate();
        /*0x7eecd40*/ void set_emissionRate(float value);
        /*0x7eece78*/ float get_startSpeed();
        /*0x7eecf08*/ void set_startSpeed(float value);
        /*0x7eecfbc*/ float get_startSize();
        /*0x7eed04c*/ void set_startSize(float value);
        /*0x7eed100*/ UnityEngine.Color get_startColor();
        /*0x7eed1e8*/ void set_startColor(UnityEngine.Color value);
        /*0x7eed384*/ float get_startRotation();
        /*0x7eed414*/ void set_startRotation(float value);
        /*0x7eed4c8*/ UnityEngine.Vector3 get_startRotation3D();
        /*0x7eed678*/ void set_startRotation3D(UnityEngine.Vector3 value);
        /*0x7eed82c*/ float get_startLifetime();
        /*0x7eed8bc*/ void set_startLifetime(float value);
        /*0x7eed970*/ float get_gravityModifier();
        /*0x7eeda00*/ void set_gravityModifier(float value);
        /*0x7eedab4*/ int get_maxParticles();
        /*0x7eedb44*/ void set_maxParticles(int value);
        /*0x7eedbec*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
        /*0x7eedc7c*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
        /*0x7eedd24*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
        /*0x7eeddb4*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
        /*0x7eede5c*/ bool get_automaticCullingEnabled();
        /*0x7eeded8*/ bool get_isPlaying();
        /*0x7eedf8c*/ bool get_isEmitting();
        /*0x7eee040*/ bool get_isStopped();
        /*0x7eee0f4*/ bool get_isPaused();
        /*0x7eee1a8*/ int get_particleCount();
        /*0x7eee25c*/ float get_time();
        /*0x7eee310*/ void set_time(float value);
        /*0x7eee3e4*/ float get_totalTime();
        /*0x7eee498*/ uint get_randomSeed();
        /*0x7eee54c*/ void set_randomSeed(uint value);
        /*0x7eee610*/ bool get_useAutoRandomSeed();
        /*0x7eee6c4*/ void set_useAutoRandomSeed(bool value);
        /*0x7eede60*/ bool get_proceduralSimulationSupported();
        /*0x7eee7c4*/ float GetParticleCurrentSize(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7eee888*/ UnityEngine.Vector3 GetParticleCurrentSize3D(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7eee97c*/ UnityEngine.Color32 GetParticleCurrentColor(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7eeea68*/ int GetParticleMeshIndex(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7eeeb2c*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x7eeecfc*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x7eeed04*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x7eeed10*/ void SetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x7eeee24*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x7eeeeb0*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x7eeeeb8*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7eeeec4*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x7eef0d4*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x7eef0dc*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x7eef0e8*/ int GetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x7eef1fc*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x7eef288*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x7eef290*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7eef29c*/ void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x7eef4f0*/ int GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x7eef754*/ UnityEngine.ParticleSystem.PlaybackState GetPlaybackState();
        /*0x7eef84c*/ void SetPlaybackState(UnityEngine.ParticleSystem.PlaybackState playbackState);
        /*0x7eef910*/ void GetTrailDataInternal(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x7eef9d4*/ UnityEngine.ParticleSystem.Trails GetTrails();
        /*0x7eefbdc*/ int GetTrails(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x7eefc3c*/ void SetTrails(UnityEngine.ParticleSystem.Trails trailData);
        /*0x7eefd00*/ void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep);
        /*0x7eefe14*/ void Simulate(float t, bool withChildren, bool restart);
        /*0x7eefe24*/ void Simulate(float t, bool withChildren);
        /*0x7eefe34*/ void Simulate(float t);
        /*0x7eefe44*/ void Play(bool withChildren);
        /*0x7eeff08*/ void Play();
        /*0x7eeff10*/ void Pause(bool withChildren);
        /*0x7eeffd4*/ void Pause();
        /*0x7eeffdc*/ void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        /*0x7ef00c0*/ void Stop(bool withChildren);
        /*0x7ef00cc*/ void Stop();
        /*0x7ef00d8*/ void Clear(bool withChildren);
        /*0x7ef019c*/ void Clear();
        /*0x7ef01a4*/ bool IsAlive(bool withChildren);
        /*0x7ef0268*/ bool IsAlive();
        /*0x7ef0270*/ void Emit(int count);
        /*0x7ef0274*/ void Emit_Internal(int count);
        /*0x7ef0338*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x7eec520*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7ef0460*/ void TriggerSubEmitter(int subEmitterIndex);
        /*0x7ef04e4*/ void TriggerSubEmitter(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        /*0x7ef05bc*/ void TriggerSubEmitter(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7ef052c*/ void TriggerSubEmitterForParticle(int subEmitterIndex, UnityEngine.ParticleSystem.Particle particle);
        /*0x7ef05c8*/ void TriggerSubEmitterForParticles(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x7ef0464*/ void TriggerSubEmitterForAllParticles(int subEmitterIndex);
        /*0x7ef0914*/ void AllocateAxisOfRotationAttribute();
        /*0x7ef09c8*/ void AllocateMeshIndexAttribute();
        /*0x7ef0a7c*/ void AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData stream);
        /*0x7ef0b40*/ bool get_has3DParticleRotations();
        /*0x7ef0bf4*/ bool get_hasNonUniformParticleSizes();
        /*0x7ef0ca8*/ void* GetManagedJobData();
        /*0x7ef0d5c*/ Unity.Jobs.JobHandle GetManagedJobHandle();
        /*0x7ef0e30*/ void SetManagedJobHandle(Unity.Jobs.JobHandle handle);
        /*0x7eec5f8*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x7eecbac*/ UnityEngine.ParticleSystem.EmissionModule get_emission();
        /*0x7ef102c*/ UnityEngine.ParticleSystem.ShapeModule get_shape();
        /*0x7ef1054*/ UnityEngine.ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime();
        /*0x7ef107c*/ UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime();
        /*0x7ef10a4*/ UnityEngine.ParticleSystem.InheritVelocityModule get_inheritVelocity();
        /*0x7ef10cc*/ UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed();
        /*0x7ef10f4*/ UnityEngine.ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime();
        /*0x7ef111c*/ UnityEngine.ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime();
        /*0x7ef1144*/ UnityEngine.ParticleSystem.ColorBySpeedModule get_colorBySpeed();
        /*0x7ef116c*/ UnityEngine.ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime();
        /*0x7ef1194*/ UnityEngine.ParticleSystem.SizeBySpeedModule get_sizeBySpeed();
        /*0x7ef11bc*/ UnityEngine.ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime();
        /*0x7ef11e4*/ UnityEngine.ParticleSystem.RotationBySpeedModule get_rotationBySpeed();
        /*0x7ef120c*/ UnityEngine.ParticleSystem.ExternalForcesModule get_externalForces();
        /*0x7ef1234*/ UnityEngine.ParticleSystem.NoiseModule get_noise();
        /*0x7ef125c*/ UnityEngine.ParticleSystem.CollisionModule get_collision();
        /*0x7ef1284*/ UnityEngine.ParticleSystem.TriggerModule get_trigger();
        /*0x7ef12ac*/ UnityEngine.ParticleSystem.SubEmittersModule get_subEmitters();
        /*0x7ef12d4*/ UnityEngine.ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation();
        /*0x7ef12fc*/ UnityEngine.ParticleSystem.LightsModule get_lights();
        /*0x7ef1324*/ UnityEngine.ParticleSystem.TrailModule get_trails();
        /*0x7ef134c*/ UnityEngine.ParticleSystem.CustomDataModule get_customData();

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x7ef14cc*/ void get_startColorBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradientBlittable ret);
            static /*0x7ef1510*/ void set_startColorBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradientBlittable value);
            /*0x7ef101c*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0x7eec9d4*/ float get_duration();
            /*0x7eec760*/ bool get_loop();
            /*0x7eec800*/ void set_loop(bool value);
            /*0x7eec618*/ float get_startDelayMultiplier();
            /*0x7eec6bc*/ void set_startDelayMultiplier(float value);
            /*0x7eed880*/ float get_startLifetimeMultiplier();
            /*0x7eed924*/ void set_startLifetimeMultiplier(float value);
            /*0x7eececc*/ float get_startSpeedMultiplier();
            /*0x7eecf70*/ void set_startSpeedMultiplier(float value);
            /*0x7eed010*/ float get_startSizeMultiplier();
            /*0x7eed0b4*/ void set_startSizeMultiplier(float value);
            /*0x7eed3d8*/ float get_startRotationMultiplier();
            /*0x7eed47c*/ void set_startRotationMultiplier(float value);
            /*0x7eed5c4*/ float get_startRotationXMultiplier();
            /*0x7eed748*/ void set_startRotationXMultiplier(float value);
            /*0x7eed600*/ float get_startRotationYMultiplier();
            /*0x7eed794*/ void set_startRotationYMultiplier(float value);
            /*0x7eed63c*/ float get_startRotationZMultiplier();
            /*0x7eed7e0*/ void set_startRotationZMultiplier(float value);
            /*0x7eed140*/ UnityEngine.ParticleSystem.MinMaxGradient get_startColor();
            /*0x7eed2f0*/ void set_startColor(UnityEngine.ParticleSystem.MinMaxGradient value);
            /*0x7ef137c*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable get_startColorBlittable();
            /*0x7ef1488*/ void set_startColorBlittable(UnityEngine.ParticleSystem.MinMaxGradientBlittable value);
            /*0x7eed9c4*/ float get_gravityModifierMultiplier();
            /*0x7eeda68*/ void set_gravityModifierMultiplier(float value);
            /*0x7eedc40*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
            /*0x7eedce0*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
            /*0x7eeca64*/ float get_simulationSpeed();
            /*0x7eecb08*/ void set_simulationSpeed(float value);
            /*0x7eedd78*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
            /*0x7eede18*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
            /*0x7eec89c*/ bool get_playOnAwake();
            /*0x7eec93c*/ void set_playOnAwake(bool value);
            /*0x7eedb08*/ int get_maxParticles();
            /*0x7eedba8*/ void set_maxParticles(int value);
        }

        struct EmissionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x7ef15cc*/ void set_rateOverTimeBlittable_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            /*0x7ef1024*/ EmissionModule(UnityEngine.ParticleSystem particleSystem);
            /*0x7eecbcc*/ bool get_enabled();
            /*0x7eecc6c*/ void set_enabled(bool value);
            /*0x7eece00*/ void set_rateOverTime(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x7ef1588*/ void set_rateOverTimeBlittable(UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            /*0x7eecd04*/ float get_rateOverTimeMultiplier();
        }

        struct ShapeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef104c*/ ShapeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CollisionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef127c*/ CollisionModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TriggerModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef12a4*/ TriggerModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SubEmittersModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef12cc*/ SubEmittersModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TextureSheetAnimationModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef12f4*/ TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem);
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

            /*0x7eec49c*/ void set_lifetime(float value);
            /*0x7eec484*/ void set_position(UnityEngine.Vector3 value);
            /*0x7eec490*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x7ef1610*/ void set_remainingLifetime(float value);
            /*0x7eec4a4*/ void set_startLifetime(float value);
            /*0x7eec510*/ void set_startColor(UnityEngine.Color32 value);
            /*0x7eec518*/ void set_randomSeed(uint value);
            /*0x7eec4ac*/ void set_startSize(float value);
            /*0x7eec4b8*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0x7eec4e4*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
        }

        struct MinMaxCurve
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ UnityEngine.AnimationCurve m_CurveMin;
            /*0x20*/ UnityEngine.AnimationCurve m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x7eecd90*/ UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(float constant);
            /*0x7ef1618*/ MinMaxCurve(float constant);
        }

        struct MinMaxCurveBlittable
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ nint m_CurveMin;
            /*0x20*/ nint m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x7ef1554*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable op_Implicit(UnityEngine.ParticleSystem.MinMaxCurve minMaxCurve);
            static /*0x7ef165c*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable FromMixMaxCurve(ref UnityEngine.ParticleSystem.MinMaxCurve minMaxCurve);
        }

        struct MinMaxGradient
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ UnityEngine.Gradient m_GradientMin;
            /*0x20*/ UnityEngine.Gradient m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x7eed290*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color);
            /*0x7ef1690*/ MinMaxGradient(UnityEngine.Color color);
            /*0x7eed1dc*/ UnityEngine.Color get_color();
        }

        struct MinMaxGradientBlittable
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ nint m_GradientMin;
            /*0x20*/ nint m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x7ef13f4*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable);
            static /*0x7ef1430*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable op_Implicit(UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient);
            static /*0x7ef17f0*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable FromMixMaxGradient(ref UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient);
            static /*0x7ef16f4*/ UnityEngine.ParticleSystem.MinMaxGradient ToMinMaxGradient(ref UnityEngine.ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable);
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

            /*0x7eefa28*/ void Allocate();
        }

        struct VelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef1074*/ VelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LimitVelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef109c*/ LimitVelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct InheritVelocityModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef10c4*/ InheritVelocityModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LifetimeByEmitterSpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef10ec*/ LifetimeByEmitterSpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ForceOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef1114*/ ForceOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef113c*/ ColorOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef1164*/ ColorBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef118c*/ SizeOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef11b4*/ SizeBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef11dc*/ RotationOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef1204*/ RotationBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ExternalForcesModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef122c*/ ExternalForcesModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct NoiseModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef1254*/ NoiseModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LightsModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef131c*/ LightsModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TrailModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef1344*/ TrailModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CustomDataModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x7ef136c*/ CustomDataModule(UnityEngine.ParticleSystem particleSystem);
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
        static /*0x7ef2f58*/ UnityEngine.ParticleSystemRenderSpace get_alignment_Injected(nint _unity_self);
        static /*0x7ef3014*/ void set_alignment_Injected(nint _unity_self, UnityEngine.ParticleSystemRenderSpace value);
        static /*0x7ef30d0*/ UnityEngine.ParticleSystemRenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x7ef318c*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.ParticleSystemRenderMode value);
        static /*0x7ef3248*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution_Injected(nint _unity_self);
        static /*0x7ef3304*/ void set_meshDistribution_Injected(nint _unity_self, UnityEngine.ParticleSystemMeshDistribution value);
        static /*0x7ef33c0*/ UnityEngine.ParticleSystemSortMode get_sortMode_Injected(nint _unity_self);
        static /*0x7ef347c*/ void set_sortMode_Injected(nint _unity_self, UnityEngine.ParticleSystemSortMode value);
        static /*0x7ef3538*/ float get_lengthScale_Injected(nint _unity_self);
        static /*0x7ef35fc*/ void set_lengthScale_Injected(nint _unity_self, float value);
        static /*0x7ef36c0*/ float get_velocityScale_Injected(nint _unity_self);
        static /*0x7ef3784*/ void set_velocityScale_Injected(nint _unity_self, float value);
        static /*0x7ef3848*/ float get_cameraVelocityScale_Injected(nint _unity_self);
        static /*0x7ef390c*/ void set_cameraVelocityScale_Injected(nint _unity_self, float value);
        static /*0x7ef39d0*/ float get_normalDirection_Injected(nint _unity_self);
        static /*0x7ef3a94*/ void set_normalDirection_Injected(nint _unity_self, float value);
        static /*0x7ef3b58*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x7ef3c1c*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x7ef3ce0*/ float get_sortingFudge_Injected(nint _unity_self);
        static /*0x7ef3da4*/ void set_sortingFudge_Injected(nint _unity_self, float value);
        static /*0x7ef3e68*/ float get_minParticleSize_Injected(nint _unity_self);
        static /*0x7ef3f2c*/ void set_minParticleSize_Injected(nint _unity_self, float value);
        static /*0x7ef3ff0*/ float get_maxParticleSize_Injected(nint _unity_self);
        static /*0x7ef40b4*/ void set_maxParticleSize_Injected(nint _unity_self, float value);
        static /*0x7ef4198*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ef426c*/ void set_pivot_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7ef4348*/ void get_flip_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ef441c*/ void set_flip_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7ef44d8*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x7ef4594*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x7ef466c*/ nint get_trailMaterial_Injected(nint _unity_self);
        static /*0x7ef475c*/ void set_trailMaterial_Injected(nint _unity_self, nint value);
        static /*0x7ef4854*/ void set_oldTrailMaterial_Injected(nint _unity_self, nint value);
        static /*0x7ef4910*/ bool get_enableGPUInstancing_Injected(nint _unity_self);
        static /*0x7ef49cc*/ void set_enableGPUInstancing_Injected(nint _unity_self, bool value);
        static /*0x7ef4a88*/ bool get_allowRoll_Injected(nint _unity_self);
        static /*0x7ef4b44*/ void set_allowRoll_Injected(nint _unity_self, bool value);
        static /*0x7ef4c00*/ bool get_freeformStretching_Injected(nint _unity_self);
        static /*0x7ef4cbc*/ void set_freeformStretching_Injected(nint _unity_self, bool value);
        static /*0x7ef4d78*/ bool get_rotateWithStretchDirection_Injected(nint _unity_self);
        static /*0x7ef4e34*/ void set_rotateWithStretchDirection_Injected(nint _unity_self, bool value);
        static /*0x7ef4f0c*/ nint get_mesh_Injected(nint _unity_self);
        static /*0x7ef4ffc*/ void set_mesh_Injected(nint _unity_self, nint value);
        static /*0x7ef50f0*/ int GetMeshes_Injected(nint _unity_self, UnityEngine.Mesh[] meshes);
        static /*0x7ef51f4*/ void SetMeshes_Injected(nint _unity_self, UnityEngine.Mesh[] meshes, int size);
        static /*0x7ef53fc*/ int GetMeshWeightings_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper weightings);
        static /*0x7ef5574*/ void SetMeshWeightings_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper weightings, int size);
        static /*0x7ef5658*/ int get_meshCount_Injected(nint _unity_self);
        static /*0x7ef56cc*/ void BakeMesh_Injected(nint _unity_self, nint mesh, nint camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        static /*0x7ef5760*/ void BakeTrailsMesh_Injected(nint _unity_self, nint mesh, nint camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        static /*0x7ef59f8*/ nint BakeTextureNoIndicesInternal_Injected(nint _unity_self, nint verticesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        static /*0x7ef5c7c*/ void BakeTextureInternal_Injected(nint _unity_self, nint verticesTexture, nint indicesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount, ref UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret);
        static /*0x7ef5f18*/ void BakeTrailsTextureInternal_Injected(nint _unity_self, nint verticesTexture, nint indicesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount, ref UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret);
        static /*0x7ef5f9c*/ int get_activeVertexStreamsCount_Injected(nint _unity_self);
        static /*0x7ef5fd8*/ void SetActiveVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x7ef601c*/ void GetActiveVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x7ef60d8*/ int get_activeTrailVertexStreamsCount_Injected(nint _unity_self);
        static /*0x7ef630c*/ void SetActiveTrailVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x7ef6548*/ void GetActiveTrailVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        /*0x7ef658c*/ ParticleSystemRenderer();
        /*0x7ef184c*/ void EnableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7ef24bc*/ void DisableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7ef24c4*/ bool AreVertexStreamsEnabled(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7ef271c*/ UnityEngine.ParticleSystemVertexStreams GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7ef1854*/ void Internal_SetVertexStreams(UnityEngine.ParticleSystemVertexStreams streams, bool enabled);
        /*0x7ef24e0*/ UnityEngine.ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x7ef2b88*/ void BakeMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x7ef2bc8*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x7ef2d34*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x7ef2d74*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x7ef2ee0*/ UnityEngine.ParticleSystemRenderSpace get_alignment();
        /*0x7ef2f94*/ void set_alignment(UnityEngine.ParticleSystemRenderSpace value);
        /*0x7ef3058*/ UnityEngine.ParticleSystemRenderMode get_renderMode();
        /*0x7ef310c*/ void set_renderMode(UnityEngine.ParticleSystemRenderMode value);
        /*0x7ef31d0*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution();
        /*0x7ef3284*/ void set_meshDistribution(UnityEngine.ParticleSystemMeshDistribution value);
        /*0x7ef3348*/ UnityEngine.ParticleSystemSortMode get_sortMode();
        /*0x7ef33fc*/ void set_sortMode(UnityEngine.ParticleSystemSortMode value);
        /*0x7ef34c0*/ float get_lengthScale();
        /*0x7ef3574*/ void set_lengthScale(float value);
        /*0x7ef3648*/ float get_velocityScale();
        /*0x7ef36fc*/ void set_velocityScale(float value);
        /*0x7ef37d0*/ float get_cameraVelocityScale();
        /*0x7ef3884*/ void set_cameraVelocityScale(float value);
        /*0x7ef3958*/ float get_normalDirection();
        /*0x7ef3a0c*/ void set_normalDirection(float value);
        /*0x7ef3ae0*/ float get_shadowBias();
        /*0x7ef3b94*/ void set_shadowBias(float value);
        /*0x7ef3c68*/ float get_sortingFudge();
        /*0x7ef3d1c*/ void set_sortingFudge(float value);
        /*0x7ef3df0*/ float get_minParticleSize();
        /*0x7ef3ea4*/ void set_minParticleSize(float value);
        /*0x7ef3f78*/ float get_maxParticleSize();
        /*0x7ef402c*/ void set_maxParticleSize(float value);
        /*0x7ef4100*/ UnityEngine.Vector3 get_pivot();
        /*0x7ef41dc*/ void set_pivot(UnityEngine.Vector3 value);
        /*0x7ef42b0*/ UnityEngine.Vector3 get_flip();
        /*0x7ef438c*/ void set_flip(UnityEngine.Vector3 value);
        /*0x7ef4460*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x7ef4514*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x7ef45d8*/ UnityEngine.Material get_trailMaterial();
        /*0x7ef46a8*/ void set_trailMaterial(UnityEngine.Material value);
        /*0x7ef47a0*/ void set_oldTrailMaterial(UnityEngine.Material value);
        /*0x7ef4898*/ bool get_enableGPUInstancing();
        /*0x7ef494c*/ void set_enableGPUInstancing(bool value);
        /*0x7ef4a10*/ bool get_allowRoll();
        /*0x7ef4ac4*/ void set_allowRoll(bool value);
        /*0x7ef4b88*/ bool get_freeformStretching();
        /*0x7ef4c3c*/ void set_freeformStretching(bool value);
        /*0x7ef4d00*/ bool get_rotateWithStretchDirection();
        /*0x7ef4db4*/ void set_rotateWithStretchDirection(bool value);
        /*0x7ef4e78*/ UnityEngine.Mesh get_mesh();
        /*0x7ef4f48*/ void set_mesh(UnityEngine.Mesh value);
        /*0x7ef5040*/ int GetMeshes(UnityEngine.Mesh[] meshes);
        /*0x7ef5134*/ void SetMeshes(UnityEngine.Mesh[] meshes, int size);
        /*0x7ef5248*/ void SetMeshes(UnityEngine.Mesh[] meshes);
        /*0x7ef5260*/ int GetMeshWeightings(float[] weightings);
        /*0x7ef5440*/ void SetMeshWeightings(float[] weightings, int size);
        /*0x7ef55c8*/ void SetMeshWeightings(float[] weightings);
        /*0x7ef55e0*/ int get_meshCount();
        /*0x7ef5694*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7ef2bdc*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7ef5728*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7ef2d88*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x7ef57bc*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7ef57f4*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7ef58a4*/ UnityEngine.Texture2D BakeTextureNoIndicesInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x7ef5a64*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7ef5aac*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7ef5b10*/ UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x7ef5d00*/ int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7ef5d48*/ int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x7ef5dac*/ UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x7ef2720*/ int get_activeVertexStreamsCount();
        /*0x7ef2990*/ void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x7ef2798*/ void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x7ef6060*/ int get_activeTrailVertexStreamsCount();
        /*0x7ef6114*/ void SetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x7ef6350*/ void GetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);

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
