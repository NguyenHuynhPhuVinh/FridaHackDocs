class <Module>
{
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        static /*0x3e6fa50*/ void ResetPreMappedBufferMemory();
        static /*0x3e6fa78*/ void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount);
        static /*0x3e700a8*/ Unity.Jobs.JobHandle ScheduleManagedJob(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData);
        static /*0x3e70158*/ void CopyManagedJobData(void* systemPtr, ref UnityEngine.ParticleSystemJobs.NativeParticleData particleData);
        static /*0x3e7019c*/ bool UserJobCanBeScheduled();
        static /*0x3e6d12c*/ bool get_isPlaying_Injected(nint _unity_self);
        static /*0x3e6d1e0*/ bool get_isEmitting_Injected(nint _unity_self);
        static /*0x3e6d294*/ bool get_isStopped_Injected(nint _unity_self);
        static /*0x3e6d348*/ bool get_isPaused_Injected(nint _unity_self);
        static /*0x3e6d3fc*/ int get_particleCount_Injected(nint _unity_self);
        static /*0x3e6d4b0*/ float get_time_Injected(nint _unity_self);
        static /*0x3e6d574*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x3e6d638*/ float get_totalTime_Injected(nint _unity_self);
        static /*0x3e6d6ec*/ uint get_randomSeed_Injected(nint _unity_self);
        static /*0x3e6d7a8*/ void set_randomSeed_Injected(nint _unity_self, uint value);
        static /*0x3e6d864*/ bool get_useAutoRandomSeed_Injected(nint _unity_self);
        static /*0x3e6d920*/ void set_useAutoRandomSeed_Injected(nint _unity_self, bool value);
        static /*0x3e6d964*/ bool get_proceduralSimulationSupported_Injected(nint _unity_self);
        static /*0x3e6da20*/ float GetParticleCurrentSize_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x3e6db04*/ void GetParticleCurrentSize3D_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Vector3 ret);
        static /*0x3e6dbf0*/ void GetParticleCurrentColor_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Color32 ret);
        static /*0x3e6dcc4*/ int GetParticleMeshIndex_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x3e6de70*/ void SetParticles_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper particles, int size, int offset);
        static /*0x3e6df88*/ void SetParticlesWithNativeArray_Injected(nint _unity_self, nint particles, int particlesLength, int size, int offset);
        static /*0x3e6e234*/ int GetParticles_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper particles, int size, int offset);
        static /*0x3e6e34c*/ int GetParticlesWithNativeArray_Injected(nint _unity_self, nint particles, int particlesLength, int size, int offset);
        static /*0x3e6e664*/ void SetCustomParticleData_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper customData, UnityEngine.ParticleSystemCustomData streamIndex);
        static /*0x3e6e8d0*/ int GetCustomParticleData_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper customData, UnityEngine.ParticleSystemCustomData streamIndex);
        static /*0x3e6e9d8*/ void GetPlaybackState_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.PlaybackState ret);
        static /*0x3e6ea9c*/ void SetPlaybackState_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.PlaybackState playbackState);
        static /*0x3e6eb60*/ void GetTrailDataInternal_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Trails trailData);
        static /*0x3e6ee8c*/ void SetTrails_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Trails trailData);
        static /*0x3e6ef78*/ void Simulate_Injected(nint _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep);
        static /*0x3e6f088*/ void Play_Injected(nint _unity_self, bool withChildren);
        static /*0x3e6f154*/ void Pause_Injected(nint _unity_self, bool withChildren);
        static /*0x3e6f230*/ void Stop_Injected(nint _unity_self, bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        static /*0x3e6f318*/ void Clear_Injected(nint _unity_self, bool withChildren);
        static /*0x3e6f3e4*/ bool IsAlive_Injected(nint _unity_self, bool withChildren);
        static /*0x3e6f4b4*/ void Emit_Internal_Injected(nint _unity_self, int count);
        static /*0x3e6f588*/ void Emit_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        static /*0x3e6f5dc*/ void EmitOld_Internal_Injected(nint _unity_self, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x3e6f964*/ void TriggerSubEmitterForParticle_Injected(nint _unity_self, int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        static /*0x3e6f9b8*/ void TriggerSubEmitterForParticles_Injected(nint _unity_self, int subEmitterIndex, ref UnityEngine.Bindings.BlittableListWrapper particles);
        static /*0x3e6fa0c*/ void TriggerSubEmitterForAllParticles_Injected(nint _unity_self, int subEmitterIndex);
        static /*0x3e6fb34*/ void AllocateAxisOfRotationAttribute_Injected(nint _unity_self);
        static /*0x3e6fbe8*/ void AllocateMeshIndexAttribute_Injected(nint _unity_self);
        static /*0x3e6fca4*/ void AllocateCustomDataAttribute_Injected(nint _unity_self, UnityEngine.ParticleSystemCustomData stream);
        static /*0x3e6fd60*/ bool get_has3DParticleRotations_Injected(nint _unity_self);
        static /*0x3e6fe14*/ bool get_hasNonUniformParticleSizes_Injected(nint _unity_self);
        static /*0x3e6fec8*/ void* GetManagedJobData_Injected(nint _unity_self);
        static /*0x3e6ff94*/ void GetManagedJobHandle_Injected(nint _unity_self, ref Unity.Jobs.JobHandle ret);
        static /*0x3e70064*/ void SetManagedJobHandle_Injected(nint _unity_self, ref Unity.Jobs.JobHandle handle);
        static /*0x3e70104*/ void ScheduleManagedJob_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData, ref Unity.Jobs.JobHandle ret);
        /*0x3e704c8*/ ParticleSystem();
        /*0x3e6b584*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x3e6b7c4*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6b7c8*/ float get_startDelay();
        /*0x3e6b874*/ void set_startDelay(float value);
        /*0x3e6b928*/ bool get_loop();
        /*0x3e6b9bc*/ void set_loop(bool value);
        /*0x3e6ba64*/ bool get_playOnAwake();
        /*0x3e6baf8*/ void set_playOnAwake(bool value);
        /*0x3e6bba0*/ float get_duration();
        /*0x3e6bc30*/ float get_playbackSpeed();
        /*0x3e6bcc0*/ void set_playbackSpeed(float value);
        /*0x3e6bd74*/ bool get_enableEmission();
        /*0x3e6be24*/ void set_enableEmission(bool value);
        /*0x3e6becc*/ float get_emissionRate();
        /*0x3e6bf5c*/ void set_emissionRate(float value);
        /*0x3e6c084*/ float get_startSpeed();
        /*0x3e6c114*/ void set_startSpeed(float value);
        /*0x3e6c1c8*/ float get_startSize();
        /*0x3e6c258*/ void set_startSize(float value);
        /*0x3e6c30c*/ UnityEngine.Color get_startColor();
        /*0x3e6c3f4*/ void set_startColor(UnityEngine.Color value);
        /*0x3e6c560*/ float get_startRotation();
        /*0x3e6c5f0*/ void set_startRotation(float value);
        /*0x3e6c6a4*/ UnityEngine.Vector3 get_startRotation3D();
        /*0x3e6c854*/ void set_startRotation3D(UnityEngine.Vector3 value);
        /*0x3e6ca08*/ float get_startLifetime();
        /*0x3e6ca98*/ void set_startLifetime(float value);
        /*0x3e6cb4c*/ float get_gravityModifier();
        /*0x3e6cbdc*/ void set_gravityModifier(float value);
        /*0x3e6cc90*/ int get_maxParticles();
        /*0x3e6cd20*/ void set_maxParticles(int value);
        /*0x3e6cdc8*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
        /*0x3e6ce58*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
        /*0x3e6cf00*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
        /*0x3e6cf90*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
        /*0x3e6d038*/ bool get_automaticCullingEnabled();
        /*0x3e6d0b4*/ bool get_isPlaying();
        /*0x3e6d168*/ bool get_isEmitting();
        /*0x3e6d21c*/ bool get_isStopped();
        /*0x3e6d2d0*/ bool get_isPaused();
        /*0x3e6d384*/ int get_particleCount();
        /*0x3e6d438*/ float get_time();
        /*0x3e6d4ec*/ void set_time(float value);
        /*0x3e6d5c0*/ float get_totalTime();
        /*0x3e6d674*/ uint get_randomSeed();
        /*0x3e6d728*/ void set_randomSeed(uint value);
        /*0x3e6d7ec*/ bool get_useAutoRandomSeed();
        /*0x3e6d8a0*/ void set_useAutoRandomSeed(bool value);
        /*0x3e6d03c*/ bool get_proceduralSimulationSupported();
        /*0x3e6d9a0*/ float GetParticleCurrentSize(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6da64*/ UnityEngine.Vector3 GetParticleCurrentSize3D(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6db58*/ UnityEngine.Color32 GetParticleCurrentColor(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6dc44*/ int GetParticleMeshIndex(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6dd08*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x3e6decc*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x3e6ded4*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x3e6dee0*/ void SetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x3e6dff4*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x3e6e080*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x3e6e088*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x3e6e094*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x3e6e290*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x3e6e298*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x3e6e2a4*/ int GetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x3e6e3b8*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x3e6e444*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x3e6e44c*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x3e6e458*/ void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x3e6e6b8*/ int GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x3e6e924*/ UnityEngine.ParticleSystem.PlaybackState GetPlaybackState();
        /*0x3e6ea1c*/ void SetPlaybackState(UnityEngine.ParticleSystem.PlaybackState playbackState);
        /*0x3e6eae0*/ void GetTrailDataInternal(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x3e6eba4*/ UnityEngine.ParticleSystem.Trails GetTrails();
        /*0x3e6edac*/ int GetTrails(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x3e6ee0c*/ void SetTrails(UnityEngine.ParticleSystem.Trails trailData);
        /*0x3e6eed0*/ void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep);
        /*0x3e6efe4*/ void Simulate(float t, bool withChildren, bool restart);
        /*0x3e6efec*/ void Simulate(float t, bool withChildren);
        /*0x3e6eff8*/ void Simulate(float t);
        /*0x3e6f008*/ void Play(bool withChildren);
        /*0x3e6f0cc*/ void Play();
        /*0x3e6f0d4*/ void Pause(bool withChildren);
        /*0x3e6f198*/ void Pause();
        /*0x3e6f1a0*/ void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        /*0x3e6f284*/ void Stop(bool withChildren);
        /*0x3e6f28c*/ void Stop();
        /*0x3e6f298*/ void Clear(bool withChildren);
        /*0x3e6f35c*/ void Clear();
        /*0x3e6f364*/ bool IsAlive(bool withChildren);
        /*0x3e6f428*/ bool IsAlive();
        /*0x3e6f430*/ void Emit(int count);
        /*0x3e6f434*/ void Emit_Internal(int count);
        /*0x3e6f4f8*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x3e6b744*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6f620*/ void TriggerSubEmitter(int subEmitterIndex);
        /*0x3e6f6a4*/ void TriggerSubEmitter(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6f778*/ void TriggerSubEmitter(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x3e6f6e8*/ void TriggerSubEmitterForParticle(int subEmitterIndex, UnityEngine.ParticleSystem.Particle particle);
        /*0x3e6f784*/ void TriggerSubEmitterForParticles(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x3e6f624*/ void TriggerSubEmitterForAllParticles(int subEmitterIndex);
        /*0x3e6fabc*/ void AllocateAxisOfRotationAttribute();
        /*0x3e6fb70*/ void AllocateMeshIndexAttribute();
        /*0x3e6fc24*/ void AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData stream);
        /*0x3e6fce8*/ bool get_has3DParticleRotations();
        /*0x3e6fd9c*/ bool get_hasNonUniformParticleSizes();
        /*0x3e6fe50*/ void* GetManagedJobData();
        /*0x3e6ff04*/ Unity.Jobs.JobHandle GetManagedJobHandle();
        /*0x3e6ffd8*/ void SetManagedJobHandle(Unity.Jobs.JobHandle handle);
        /*0x3e6b81c*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x3e6bdcc*/ UnityEngine.ParticleSystem.EmissionModule get_emission();
        /*0x3e701d4*/ UnityEngine.ParticleSystem.ShapeModule get_shape();
        /*0x3e701f8*/ UnityEngine.ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime();
        /*0x3e7021c*/ UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime();
        /*0x3e70240*/ UnityEngine.ParticleSystem.InheritVelocityModule get_inheritVelocity();
        /*0x3e70264*/ UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed();
        /*0x3e70288*/ UnityEngine.ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime();
        /*0x3e702ac*/ UnityEngine.ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime();
        /*0x3e702d0*/ UnityEngine.ParticleSystem.ColorBySpeedModule get_colorBySpeed();
        /*0x3e702f4*/ UnityEngine.ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime();
        /*0x3e70318*/ UnityEngine.ParticleSystem.SizeBySpeedModule get_sizeBySpeed();
        /*0x3e7033c*/ UnityEngine.ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime();
        /*0x3e70360*/ UnityEngine.ParticleSystem.RotationBySpeedModule get_rotationBySpeed();
        /*0x3e70384*/ UnityEngine.ParticleSystem.ExternalForcesModule get_externalForces();
        /*0x3e703a8*/ UnityEngine.ParticleSystem.NoiseModule get_noise();
        /*0x3e703cc*/ UnityEngine.ParticleSystem.CollisionModule get_collision();
        /*0x3e703f0*/ UnityEngine.ParticleSystem.TriggerModule get_trigger();
        /*0x3e70414*/ UnityEngine.ParticleSystem.SubEmittersModule get_subEmitters();
        /*0x3e70438*/ UnityEngine.ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation();
        /*0x3e7045c*/ UnityEngine.ParticleSystem.LightsModule get_lights();
        /*0x3e70480*/ UnityEngine.ParticleSystem.TrailModule get_trails();
        /*0x3e704a4*/ UnityEngine.ParticleSystem.CustomDataModule get_customData();

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x3e706a8*/ void get_startDelayBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable ret);
            static /*0x3e706ec*/ void set_startDelayBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            static /*0x3e70804*/ void get_startLifetimeBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable ret);
            static /*0x3e70b1c*/ void get_startColorBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradientBlittable ret);
            static /*0x3e70b60*/ void set_startColorBlittable_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradientBlittable value);
            /*0x3e701c4*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0x3e6bbf4*/ float get_duration();
            /*0x3e6b980*/ bool get_loop();
            /*0x3e6ba20*/ void set_loop(bool value);
            /*0x3e704d0*/ UnityEngine.ParticleSystem.MinMaxCurve get_startDelay();
            /*0x3e705cc*/ void set_startDelay(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x3e70544*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable get_startDelayBlittable();
            /*0x3e70664*/ void set_startDelayBlittable(UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            /*0x3e6b838*/ float get_startDelayMultiplier();
            /*0x3e6b8dc*/ void set_startDelayMultiplier(float value);
            /*0x3e70730*/ UnityEngine.ParticleSystem.MinMaxCurve get_startLifetime();
            /*0x3e707a4*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable get_startLifetimeBlittable();
            /*0x3e6ca5c*/ float get_startLifetimeMultiplier();
            /*0x3e6cb00*/ void set_startLifetimeMultiplier(float value);
            /*0x3e6c0d8*/ float get_startSpeedMultiplier();
            /*0x3e6c17c*/ void set_startSpeedMultiplier(float value);
            /*0x3e6c21c*/ float get_startSizeMultiplier();
            /*0x3e6c2c0*/ void set_startSizeMultiplier(float value);
            /*0x3e70848*/ float get_startSizeXMultiplier();
            /*0x3e70884*/ void set_startSizeXMultiplier(float value);
            /*0x3e708d0*/ float get_startSizeYMultiplier();
            /*0x3e7090c*/ void set_startSizeYMultiplier(float value);
            /*0x3e70958*/ float get_startSizeZMultiplier();
            /*0x3e70994*/ void set_startSizeZMultiplier(float value);
            /*0x3e6c5b4*/ float get_startRotationMultiplier();
            /*0x3e6c658*/ void set_startRotationMultiplier(float value);
            /*0x3e6c7a0*/ float get_startRotationXMultiplier();
            /*0x3e6c924*/ void set_startRotationXMultiplier(float value);
            /*0x3e6c7dc*/ float get_startRotationYMultiplier();
            /*0x3e6c970*/ void set_startRotationYMultiplier(float value);
            /*0x3e6c818*/ float get_startRotationZMultiplier();
            /*0x3e6c9bc*/ void set_startRotationZMultiplier(float value);
            /*0x3e6c34c*/ UnityEngine.ParticleSystem.MinMaxGradient get_startColor();
            /*0x3e6c4e0*/ void set_startColor(UnityEngine.ParticleSystem.MinMaxGradient value);
            /*0x3e709e0*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable get_startColorBlittable();
            /*0x3e70ad8*/ void set_startColorBlittable(UnityEngine.ParticleSystem.MinMaxGradientBlittable value);
            /*0x3e6cba0*/ float get_gravityModifierMultiplier();
            /*0x3e6cc44*/ void set_gravityModifierMultiplier(float value);
            /*0x3e6ce1c*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
            /*0x3e6cebc*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
            /*0x3e6bc84*/ float get_simulationSpeed();
            /*0x3e6bd28*/ void set_simulationSpeed(float value);
            /*0x3e6cf54*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
            /*0x3e6cff4*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
            /*0x3e6babc*/ bool get_playOnAwake();
            /*0x3e6bb5c*/ void set_playOnAwake(bool value);
            /*0x3e6cce4*/ int get_maxParticles();
            /*0x3e6cd84*/ void set_maxParticles(int value);
        }

        struct EmissionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x3e70be8*/ void set_rateOverTimeBlittable_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            static /*0x3e70fa4*/ void SetBurst_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, int index, ref UnityEngine.ParticleSystem.Burst burst);
            static /*0x3e70ff8*/ void GetBurst_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, int index, ref UnityEngine.ParticleSystem.Burst ret);
            /*0x3e701cc*/ EmissionModule(UnityEngine.ParticleSystem particleSystem);
            /*0x3e6bde8*/ bool get_enabled();
            /*0x3e6be88*/ void set_enabled(bool value);
            /*0x3e6c014*/ void set_rateOverTime(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x3e70ba4*/ void set_rateOverTimeBlittable(UnityEngine.ParticleSystem.MinMaxCurveBlittable value);
            /*0x3e6bf20*/ float get_rateOverTimeMultiplier();
            /*0x3e70c2c*/ void SetBursts(UnityEngine.ParticleSystem.Burst[] bursts);
            /*0x3e70c40*/ void SetBursts(UnityEngine.ParticleSystem.Burst[] bursts, int size);
            /*0x3e70dc4*/ int GetBursts(UnityEngine.ParticleSystem.Burst[] bursts);
            /*0x3e70d70*/ void SetBurst(int index, UnityEngine.ParticleSystem.Burst burst);
            /*0x3e70f1c*/ UnityEngine.ParticleSystem.Burst GetBurst(int index);
            /*0x3e70ee0*/ int get_burstCount();
            /*0x3e70d2c*/ void set_burstCount(int value);
        }

        struct ShapeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e701f0*/ ShapeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CollisionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e703e8*/ CollisionModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TriggerModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e7040c*/ TriggerModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SubEmittersModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70430*/ SubEmittersModule(UnityEngine.ParticleSystem particleSystem);
            /*0x3e7104c*/ int get_subEmittersCount();
        }

        struct TextureSheetAnimationModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70454*/ TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem);
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

            /*0x3e6b6a8*/ void set_lifetime(float value);
            /*0x3e6b690*/ void set_position(UnityEngine.Vector3 value);
            /*0x3e6b69c*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x3e71088*/ void set_remainingLifetime(float value);
            /*0x3e6b6b0*/ void set_startLifetime(float value);
            /*0x3e6b734*/ void set_startColor(UnityEngine.Color32 value);
            /*0x3e6b73c*/ void set_randomSeed(uint value);
            /*0x3e6b6b8*/ void set_startSize(float value);
            /*0x3e6b6c4*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0x3e6b6fc*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
        }

        struct Burst
        {
            /*0x10*/ float m_Time;
            /*0x18*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable m_Count;
            /*0x38*/ int m_RepeatCount;
            /*0x3c*/ float m_RepeatInterval;
            /*0x40*/ float m_InvProbability;

            /*0x3e71090*/ Burst(float _time, short _count);
            /*0x3e71114*/ Burst(float _time, UnityEngine.ParticleSystem.MinMaxCurve _count);
            /*0x3e71148*/ float get_time();
            /*0x3e71150*/ int get_cycleCount();
            /*0x3e7115c*/ float get_repeatInterval();
            /*0x3e71164*/ float get_probability();
        }

        struct MinMaxCurve
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ UnityEngine.AnimationCurve m_CurveMin;
            /*0x20*/ UnityEngine.AnimationCurve m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x3e6bfac*/ UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(float constant);
            /*0x3e71174*/ MinMaxCurve(float constant);
            /*0x3e711b8*/ UnityEngine.ParticleSystemCurveMode get_mode();
            /*0x3e711c0*/ UnityEngine.AnimationCurve get_curveMax();
            /*0x3e711c8*/ float get_constantMax();
            /*0x3e711d0*/ float get_constant();
            /*0x3e711d8*/ void set_constant(float value);
            /*0x3e711e0*/ UnityEngine.AnimationCurve get_curve();
            /*0x3e711e8*/ float Evaluate(float time);
            /*0x3e711f0*/ float Evaluate(float time, float lerpFactor);
        }

        struct MinMaxCurveBlittable
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ nint m_CurveMin;
            /*0x20*/ nint m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x3e705a4*/ UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(UnityEngine.ParticleSystem.MinMaxCurveBlittable minMaxCurveBlittable);
            static /*0x3e7063c*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable op_Implicit(UnityEngine.ParticleSystem.MinMaxCurve minMaxCurve);
            static /*0x3e710ec*/ UnityEngine.ParticleSystem.MinMaxCurveBlittable FromMixMaxCurve(ref UnityEngine.ParticleSystem.MinMaxCurve minMaxCurve);
            static /*0x3e712e0*/ UnityEngine.ParticleSystem.MinMaxCurve ToMinMaxCurve(ref UnityEngine.ParticleSystem.MinMaxCurveBlittable minMaxCurveBlittable);
        }

        struct MinMaxGradient
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ UnityEngine.Gradient m_GradientMin;
            /*0x20*/ UnityEngine.Gradient m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x3e6c48c*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color);
            /*0x3e713cc*/ MinMaxGradient(UnityEngine.Color color);
            /*0x3e6c3e8*/ UnityEngine.Color get_color();
        }

        struct MinMaxGradientBlittable
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ nint m_GradientMin;
            /*0x20*/ nint m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x3e70a58*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable);
            static /*0x3e70a94*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable op_Implicit(UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient);
            static /*0x3e71530*/ UnityEngine.ParticleSystem.MinMaxGradientBlittable FromMixMaxGradient(ref UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient);
            static /*0x3e71430*/ UnityEngine.ParticleSystem.MinMaxGradient ToMinMaxGradient(ref UnityEngine.ParticleSystem.MinMaxGradientBlittable minMaxGradientBlittable);
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

            /*0x3e6ebf8*/ void Allocate();
        }

        struct VelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70214*/ VelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LimitVelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70238*/ LimitVelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct InheritVelocityModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e7025c*/ InheritVelocityModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LifetimeByEmitterSpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70280*/ LifetimeByEmitterSpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ForceOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e702a4*/ ForceOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e702c8*/ ColorOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e702ec*/ ColorBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70310*/ SizeOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70334*/ SizeBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70358*/ RotationOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e7037c*/ RotationBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ExternalForcesModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e703a0*/ ExternalForcesModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct NoiseModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e703c4*/ NoiseModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LightsModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e70478*/ LightsModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TrailModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x3e7049c*/ TrailModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CustomDataModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x3e71694*/ void SetVectorInternal_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, int component, ref UnityEngine.ParticleSystem.MinMaxCurveBlittable curve);
            /*0x3e704c0*/ CustomDataModule(UnityEngine.ParticleSystem particleSystem);
            /*0x3e71574*/ bool get_enabled();
            /*0x3e715b0*/ void SetVector(UnityEngine.ParticleSystemCustomData stream, int component, UnityEngine.ParticleSystem.MinMaxCurve curve);
            /*0x3e71638*/ void SetVectorInternal(UnityEngine.ParticleSystemCustomData stream, int component, UnityEngine.ParticleSystem.MinMaxCurveBlittable curve);
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
        static /*0x3e729ec*/ UnityEngine.ParticleSystemRenderSpace get_alignment_Injected(nint _unity_self);
        static /*0x3e72aa8*/ void set_alignment_Injected(nint _unity_self, UnityEngine.ParticleSystemRenderSpace value);
        static /*0x3e72b64*/ UnityEngine.ParticleSystemRenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x3e72c20*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.ParticleSystemRenderMode value);
        static /*0x3e72cdc*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution_Injected(nint _unity_self);
        static /*0x3e72d98*/ void set_meshDistribution_Injected(nint _unity_self, UnityEngine.ParticleSystemMeshDistribution value);
        static /*0x3e72e54*/ UnityEngine.ParticleSystemSortMode get_sortMode_Injected(nint _unity_self);
        static /*0x3e72f10*/ void set_sortMode_Injected(nint _unity_self, UnityEngine.ParticleSystemSortMode value);
        static /*0x3e72fcc*/ float get_lengthScale_Injected(nint _unity_self);
        static /*0x3e73090*/ void set_lengthScale_Injected(nint _unity_self, float value);
        static /*0x3e73154*/ float get_velocityScale_Injected(nint _unity_self);
        static /*0x3e73218*/ void set_velocityScale_Injected(nint _unity_self, float value);
        static /*0x3e732dc*/ float get_cameraVelocityScale_Injected(nint _unity_self);
        static /*0x3e733a0*/ void set_cameraVelocityScale_Injected(nint _unity_self, float value);
        static /*0x3e73464*/ float get_normalDirection_Injected(nint _unity_self);
        static /*0x3e73528*/ void set_normalDirection_Injected(nint _unity_self, float value);
        static /*0x3e735ec*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x3e736b0*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x3e73774*/ float get_sortingFudge_Injected(nint _unity_self);
        static /*0x3e73838*/ void set_sortingFudge_Injected(nint _unity_self, float value);
        static /*0x3e738fc*/ float get_minParticleSize_Injected(nint _unity_self);
        static /*0x3e739c0*/ void set_minParticleSize_Injected(nint _unity_self, float value);
        static /*0x3e73a84*/ float get_maxParticleSize_Injected(nint _unity_self);
        static /*0x3e73b48*/ void set_maxParticleSize_Injected(nint _unity_self, float value);
        static /*0x3e73c2c*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e73d00*/ void set_pivot_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e73ddc*/ void get_flip_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e73eb0*/ void set_flip_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e73f6c*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x3e74028*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x3e74100*/ nint get_trailMaterial_Injected(nint _unity_self);
        static /*0x3e741f0*/ void set_trailMaterial_Injected(nint _unity_self, nint value);
        static /*0x3e742e8*/ void set_oldTrailMaterial_Injected(nint _unity_self, nint value);
        static /*0x3e743a4*/ bool get_enableGPUInstancing_Injected(nint _unity_self);
        static /*0x3e74460*/ void set_enableGPUInstancing_Injected(nint _unity_self, bool value);
        static /*0x3e7451c*/ bool get_allowRoll_Injected(nint _unity_self);
        static /*0x3e745d8*/ void set_allowRoll_Injected(nint _unity_self, bool value);
        static /*0x3e74694*/ bool get_freeformStretching_Injected(nint _unity_self);
        static /*0x3e74750*/ void set_freeformStretching_Injected(nint _unity_self, bool value);
        static /*0x3e7480c*/ bool get_rotateWithStretchDirection_Injected(nint _unity_self);
        static /*0x3e748c8*/ void set_rotateWithStretchDirection_Injected(nint _unity_self, bool value);
        static /*0x3e749a0*/ nint get_mesh_Injected(nint _unity_self);
        static /*0x3e74a90*/ void set_mesh_Injected(nint _unity_self, nint value);
        static /*0x3e74b84*/ int GetMeshes_Injected(nint _unity_self, UnityEngine.Mesh[] meshes);
        static /*0x3e74c88*/ void SetMeshes_Injected(nint _unity_self, UnityEngine.Mesh[] meshes, int size);
        static /*0x3e74e78*/ int GetMeshWeightings_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper weightings);
        static /*0x3e74ff4*/ void SetMeshWeightings_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper weightings, int size);
        static /*0x3e750d4*/ int get_meshCount_Injected(nint _unity_self);
        static /*0x3e75148*/ void BakeMesh_Injected(nint _unity_self, nint mesh, nint camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        static /*0x3e751dc*/ void BakeTrailsMesh_Injected(nint _unity_self, nint mesh, nint camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        static /*0x3e75474*/ nint BakeTextureNoIndicesInternal_Injected(nint _unity_self, nint verticesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        static /*0x3e756f8*/ void BakeTextureInternal_Injected(nint _unity_self, nint verticesTexture, nint indicesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount, ref UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret);
        static /*0x3e75994*/ void BakeTrailsTextureInternal_Injected(nint _unity_self, nint verticesTexture, nint indicesTexture, nint camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount, ref UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret);
        static /*0x3e75a18*/ int get_activeVertexStreamsCount_Injected(nint _unity_self);
        static /*0x3e75a54*/ void SetActiveVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x3e75a98*/ void GetActiveVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x3e75b54*/ int get_activeTrailVertexStreamsCount_Injected(nint _unity_self);
        static /*0x3e75d88*/ void SetActiveTrailVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        static /*0x3e75fc4*/ void GetActiveTrailVertexStreams_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper streams);
        /*0x3e76008*/ ParticleSystemRenderer();
        /*0x3e716f0*/ void EnableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x3e71edc*/ void DisableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x3e71ee4*/ bool AreVertexStreamsEnabled(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x3e721b0*/ UnityEngine.ParticleSystemVertexStreams GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x3e716f8*/ void Internal_SetVertexStreams(UnityEngine.ParticleSystemVertexStreams streams, bool enabled);
        /*0x3e71f00*/ UnityEngine.ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x3e7261c*/ void BakeMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x3e7265c*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x3e727c8*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x3e72808*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x3e72974*/ UnityEngine.ParticleSystemRenderSpace get_alignment();
        /*0x3e72a28*/ void set_alignment(UnityEngine.ParticleSystemRenderSpace value);
        /*0x3e72aec*/ UnityEngine.ParticleSystemRenderMode get_renderMode();
        /*0x3e72ba0*/ void set_renderMode(UnityEngine.ParticleSystemRenderMode value);
        /*0x3e72c64*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution();
        /*0x3e72d18*/ void set_meshDistribution(UnityEngine.ParticleSystemMeshDistribution value);
        /*0x3e72ddc*/ UnityEngine.ParticleSystemSortMode get_sortMode();
        /*0x3e72e90*/ void set_sortMode(UnityEngine.ParticleSystemSortMode value);
        /*0x3e72f54*/ float get_lengthScale();
        /*0x3e73008*/ void set_lengthScale(float value);
        /*0x3e730dc*/ float get_velocityScale();
        /*0x3e73190*/ void set_velocityScale(float value);
        /*0x3e73264*/ float get_cameraVelocityScale();
        /*0x3e73318*/ void set_cameraVelocityScale(float value);
        /*0x3e733ec*/ float get_normalDirection();
        /*0x3e734a0*/ void set_normalDirection(float value);
        /*0x3e73574*/ float get_shadowBias();
        /*0x3e73628*/ void set_shadowBias(float value);
        /*0x3e736fc*/ float get_sortingFudge();
        /*0x3e737b0*/ void set_sortingFudge(float value);
        /*0x3e73884*/ float get_minParticleSize();
        /*0x3e73938*/ void set_minParticleSize(float value);
        /*0x3e73a0c*/ float get_maxParticleSize();
        /*0x3e73ac0*/ void set_maxParticleSize(float value);
        /*0x3e73b94*/ UnityEngine.Vector3 get_pivot();
        /*0x3e73c70*/ void set_pivot(UnityEngine.Vector3 value);
        /*0x3e73d44*/ UnityEngine.Vector3 get_flip();
        /*0x3e73e20*/ void set_flip(UnityEngine.Vector3 value);
        /*0x3e73ef4*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x3e73fa8*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x3e7406c*/ UnityEngine.Material get_trailMaterial();
        /*0x3e7413c*/ void set_trailMaterial(UnityEngine.Material value);
        /*0x3e74234*/ void set_oldTrailMaterial(UnityEngine.Material value);
        /*0x3e7432c*/ bool get_enableGPUInstancing();
        /*0x3e743e0*/ void set_enableGPUInstancing(bool value);
        /*0x3e744a4*/ bool get_allowRoll();
        /*0x3e74558*/ void set_allowRoll(bool value);
        /*0x3e7461c*/ bool get_freeformStretching();
        /*0x3e746d0*/ void set_freeformStretching(bool value);
        /*0x3e74794*/ bool get_rotateWithStretchDirection();
        /*0x3e74848*/ void set_rotateWithStretchDirection(bool value);
        /*0x3e7490c*/ UnityEngine.Mesh get_mesh();
        /*0x3e749dc*/ void set_mesh(UnityEngine.Mesh value);
        /*0x3e74ad4*/ int GetMeshes(UnityEngine.Mesh[] meshes);
        /*0x3e74bc8*/ void SetMeshes(UnityEngine.Mesh[] meshes, int size);
        /*0x3e74cdc*/ void SetMeshes(UnityEngine.Mesh[] meshes);
        /*0x3e74cf0*/ int GetMeshWeightings(float[] weightings);
        /*0x3e74ebc*/ void SetMeshWeightings(float[] weightings, int size);
        /*0x3e75048*/ void SetMeshWeightings(float[] weightings);
        /*0x3e7505c*/ int get_meshCount();
        /*0x3e75110*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x3e72670*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x3e751a4*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x3e7281c*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options);
        /*0x3e75238*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x3e75270*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x3e75320*/ UnityEngine.Texture2D BakeTextureNoIndicesInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x3e754e0*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x3e75528*/ int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x3e7558c*/ UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x3e7577c*/ int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x3e757c4*/ int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options);
        /*0x3e75828*/ UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, ref int indexCount);
        /*0x3e721b4*/ int get_activeVertexStreamsCount();
        /*0x3e72424*/ void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x3e7222c*/ void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x3e75adc*/ int get_activeTrailVertexStreamsCount();
        /*0x3e75b90*/ void SetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x3e75dcc*/ void GetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);

        struct BakeTextureOutput
        {
            /*0x10*/ UnityEngine.Texture2D vertices;
            /*0x18*/ UnityEngine.Texture2D indices;
        }
    }

    namespace ParticleSystemJobs
    {
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
