class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7969d7c*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x7969d84*/ NullableAttribute(byte );
                /*0x7969e0c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7969e3c*/ NullableContextAttribute(byte );
            }
        }
    }
}

class DeltaTimeScaleProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
{
    static /*0x7969e94*/ void Initialize();
    /*0x7969efc*/ DeltaTimeScaleProcessor();
    /*0x7969e64*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7969f44*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x796a038*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Unity
{
    namespace Cinemachine
    {
        class CinemachineBrain : UnityEngine.MonoBehaviour, Unity.Cinemachine.ICameraOverrideStack, Unity.Cinemachine.ICinemachineMixer, Unity.Cinemachine.ICinemachineCamera
        {
            static /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineBrain> s_ActiveBrains;
            /*0x20*/ bool ShowDebugText;
            /*0x21*/ bool ShowCameraFrustum;
            /*0x22*/ bool IgnoreTimeScale;
            /*0x28*/ UnityEngine.Transform WorldUpOverride;
            /*0x30*/ Unity.Cinemachine.OutputChannels ChannelMask;
            /*0x34*/ Unity.Cinemachine.CinemachineBrain.UpdateMethods UpdateMethod;
            /*0x38*/ Unity.Cinemachine.CinemachineBrain.BrainUpdateMethods BlendUpdateMethod;
            /*0x3c*/ Unity.Cinemachine.CinemachineBrain.LensModeOverrideSettings LensModeOverride;
            /*0x48*/ Unity.Cinemachine.CinemachineBlendDefinition DefaultBlend;
            /*0x58*/ Unity.Cinemachine.CinemachineBlenderSettings CustomBlends;
            /*0x60*/ UnityEngine.Camera m_OutputCamera;
            /*0x68*/ UnityEngine.GameObject m_TargetOverride;
            /*0x70*/ int m_LastFrameUpdated;
            /*0x78*/ UnityEngine.Coroutine m_PhysicsCoroutine;
            /*0x80*/ UnityEngine.WaitForFixedUpdate m_WaitForFixedUpdate;
            /*0x88*/ Unity.Cinemachine.BlendManager m_BlendManager;
            /*0x90*/ Unity.Cinemachine.CameraState m_CameraState;

            static /*0x796c1e0*/ CinemachineBrain();
            static /*0x796b260*/ int get_ActiveBrainCount();
            static /*0x796b2d0*/ Unity.Cinemachine.CinemachineBrain GetActiveBrain(int index);
            /*0x796c0dc*/ CinemachineBrain();
            /*0x796a040*/ void OnValidate();
            /*0x796a054*/ void Reset();
            /*0x796a0e8*/ void Awake();
            /*0x796a1c0*/ void Start();
            /*0x796a448*/ void OnEnable();
            /*0x796a6f0*/ void OnDisable();
            /*0x796a8c8*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x796abb0*/ void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            /*0x796abf8*/ void LateUpdate();
            /*0x796a684*/ System.Collections.IEnumerator AfterPhysics();
            /*0x796ac34*/ int SetCameraOverride(int overrideId, int priority, Unity.Cinemachine.ICinemachineCamera camA, Unity.Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime);
            /*0x796ac50*/ void ReleaseCameraOverride(int overrideId);
            /*0x796ac6c*/ UnityEngine.Vector3 get_DefaultWorldUp();
            /*0x796ad34*/ string get_Name();
            /*0x796ad3c*/ string get_Description();
            /*0x796b01c*/ Unity.Cinemachine.CameraState get_State();
            /*0x796b02c*/ bool get_IsValid();
            /*0x796b088*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            /*0x796b090*/ void UpdateCameraState(UnityEngine.Vector3 up, float deltaTime);
            /*0x796b094*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x796b098*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera cam, bool dominantChildOnly);
            /*0x796a140*/ UnityEngine.GameObject get_ControlledObject();
            /*0x796b350*/ void set_ControlledObject(UnityEngine.GameObject value);
            /*0x796b3d4*/ UnityEngine.Camera get_OutputCamera();
            /*0x796af38*/ Unity.Cinemachine.ICinemachineCamera get_ActiveVirtualCamera();
            /*0x796b4ac*/ void ResetState();
            /*0x796afe4*/ bool get_IsBlending();
            /*0x796b000*/ Unity.Cinemachine.CinemachineBlend get_ActiveBlend();
            /*0x796b4c8*/ void set_ActiveBlend(Unity.Cinemachine.CinemachineBlend value);
            /*0x796b4e4*/ bool IsValidChannel(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x796b574*/ bool IsLiveInBlend(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x796a910*/ void ManualUpdate();
            /*0x796bb28*/ void DoFixedUpdate();
            /*0x796b6cc*/ float GetEffectiveDeltaTime(bool fixedDelta);
            /*0x796a1d4*/ void UpdateVirtualCameras(Unity.Cinemachine.CameraUpdateManager.UpdateFilter updateFilter, float deltaTime);
            /*0x796bc58*/ Unity.Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue();
            /*0x796bd0c*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera fromKey, Unity.Cinemachine.ICinemachineCamera toKey);
            /*0x796b85c*/ void ProcessActiveCamera(float deltaTime);
            /*0x796bd2c*/ void PushStateToUnityCamera(ref Unity.Cinemachine.CameraState state);

            enum UpdateMethods
            {
                FixedUpdate = 0,
                LateUpdate = 1,
                SmartUpdate = 2,
                ManualUpdate = 3,
            }

            enum BrainUpdateMethods
            {
                FixedUpdate = 0,
                LateUpdate = 1,
            }

            struct LensModeOverrideSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ Unity.Cinemachine.LensSettings.OverrideModes DefaultMode;
            }

            class <AfterPhysics>d__30 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ Unity.Cinemachine.CinemachineBrain <>4__this;

                /*0x796ac0c*/ <AfterPhysics>d__30(int <>1__state);
                /*0x796c278*/ void System.IDisposable.Dispose();
                /*0x796c27c*/ bool MoveNext();
                /*0x796c2f0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x796c2f8*/ void System.Collections.IEnumerator.Reset();
                /*0x796c330*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class CinemachineCamera : Unity.Cinemachine.CinemachineVirtualCameraBase
        {
            /*0xa0*/ Unity.Cinemachine.CameraTarget Target;
            /*0xb8*/ Unity.Cinemachine.LensSettings Lens;
            /*0x110*/ Unity.Cinemachine.CinemachineCore.BlendHints BlendHint;
            /*0x118*/ Unity.Cinemachine.CameraState m_State;
            /*0x228*/ Unity.Cinemachine.CinemachineComponentBase[] m_Pipeline;

            /*0x796d348*/ CinemachineCamera();
            /*0x796c338*/ void Reset();
            /*0x796c390*/ void OnValidate();
            /*0x796c39c*/ Unity.Cinemachine.CameraState get_State();
            /*0x796c3ac*/ UnityEngine.Transform get_LookAt();
            /*0x796c3dc*/ void set_LookAt(UnityEngine.Transform value);
            /*0x796c3ec*/ UnityEngine.Transform get_Follow();
            /*0x796c3f8*/ void set_Follow(UnityEngine.Transform value);
            /*0x796c400*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x796c784*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x796c940*/ float GetMaxDampTime();
            /*0x796ca40*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x796cd9c*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x796cfb4*/ Unity.Cinemachine.CameraState InvokeComponentPipeline(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x796d200*/ void InvalidatePipelineCache();
            /*0x796d214*/ bool get_PipelineCacheInvalidated();
            /*0x796d224*/ System.Type PeekPipelineCacheType(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x796c5bc*/ void UpdatePipelineCache();
            /*0x796d2f4*/ Unity.Cinemachine.CinemachineComponentBase GetCinemachineComponent(Unity.Cinemachine.CinemachineCore.Stage stage);
        }

        class CinemachineCameraOffset : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ UnityEngine.Vector3 Offset;
            /*0x3c*/ Unity.Cinemachine.CinemachineCore.Stage ApplyAfter;
            /*0x40*/ bool PreserveComposition;

            /*0x796d678*/ CinemachineCameraOffset();
            /*0x796d418*/ void Reset();
            /*0x796d47c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
        }

        class CinemachineClearShot : Unity.Cinemachine.CinemachineCameraManagerBase
        {
            /*0x208*/ float ActivateAfter;
            /*0x20c*/ float MinDuration;
            /*0x210*/ bool RandomizeChoice;
            /*0x218*/ UnityEngine.Transform m_LegacyLookAt;
            /*0x220*/ UnityEngine.Transform m_LegacyFollow;
            /*0x228*/ float m_ActivationTime;
            /*0x22c*/ float m_PendingActivationTime;
            /*0x230*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_PendingCamera;
            /*0x238*/ bool m_RandomizeNow;
            /*0x240*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> m_RandomizedChildren;

            static /*0x796df40*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> Randomize(System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> src);
            /*0x796e25c*/ CinemachineClearShot();
            /*0x796d6e0*/ void Reset();
            /*0x796d744*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x796d8dc*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x796d95c*/ void ResetRandomization();
            /*0x796d984*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);

            struct Pair
            {
                /*0x10*/ int a;
                /*0x14*/ float b;
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineClearShot.<> <>9;
                static /*0x8*/ System.Comparison<Unity.Cinemachine.CinemachineClearShot.Pair> <>9__16_0;

                static /*0x796e264*/ <>c();
                /*0x796e2cc*/ <>c();
                /*0x796e2d4*/ int <Randomize>b__16_0(Unity.Cinemachine.CinemachineClearShot.Pair p1, Unity.Cinemachine.CinemachineClearShot.Pair p2);
            }
        }

        class CinemachineConfiner2D : Unity.Cinemachine.CinemachineExtension
        {
            static float k_CornerAngleThreshold = 10;
            /*0x30*/ UnityEngine.Collider2D BoundingShape2D;
            /*0x38*/ float Damping;
            /*0x3c*/ float SlowingDistance;
            /*0x40*/ Unity.Cinemachine.CinemachineConfiner2D.OversizeWindowSettings OversizeWindow;
            /*0x50*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineConfiner2D.VcamExtraState> m_ExtraStateCache;
            /*0x58*/ Unity.Cinemachine.CinemachineConfiner2D.ShapeCache m_ShapeCache;
            /*0x148*/ float m_LegacyMaxWindowSize;

            static /*0x796f8bc*/ float CalculateHalfFrustumHeight(ref Unity.Cinemachine.LensSettings lens, ref float cameraPosLocalZ);
            /*0x796fad4*/ CinemachineConfiner2D();
            /*0x796e310*/ void OnValidate();
            /*0x796e378*/ void Reset();
            /*0x796e390*/ float GetMaxDampTime();
            /*0x796e3ac*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x796e4ac*/ void InvalidateLensCache();
            /*0x796e610*/ void InvalidateBoundingShapeCache();
            /*0x796e6f4*/ void InvalidateCache();
            /*0x796e710*/ bool get_BoundingShapeIsBaked();
            /*0x796e730*/ bool BakeBoundingShape(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, float maxTimeInSeconds);
            /*0x796f238*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x796f938*/ UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 pos, Unity.Cinemachine.CinemachineConfiner2D.VcamExtraState extra, UnityEngine.Vector3 fwd);
            /*0x796f9fc*/ float GetDistanceFromEdge(UnityEngine.Vector3 p, UnityEngine.Vector3 dirUnit, float max, Unity.Cinemachine.CinemachineConfiner2D.VcamExtraState extra, UnityEngine.Vector3 fwd);

            struct OversizeWindowSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float MaxWindowSize;
                /*0x18*/ float Padding;
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ Unity.Cinemachine.ConfinerOven.BakedSolution BakedSolution;
                /*0x20*/ UnityEngine.Vector3 PreviousDisplacement;
                /*0x2c*/ UnityEngine.Vector3 DampedDisplacement;
                /*0x38*/ UnityEngine.Vector3 PreviousCameraPosition;
                /*0x44*/ float FrustumHeight;

                /*0x796fae4*/ VcamExtraState();
            }

            struct ShapeCache
            {
                /*0x10*/ Unity.Cinemachine.ConfinerOven ConfinerOven;
                /*0x18*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> OriginalPath;
                /*0x20*/ UnityEngine.Matrix4x4 DeltaWorldToBaked;
                /*0x60*/ UnityEngine.Matrix4x4 DeltaBakedToWorld;
                /*0xa0*/ float AspectRatio;
                /*0xa4*/ Unity.Cinemachine.CinemachineConfiner2D.OversizeWindowSettings m_OversizeWindowSettings;
                /*0xb0*/ float MaxComputationTimePerFrameInSeconds;
                /*0xb4*/ UnityEngine.Matrix4x4 m_BakedToWorld;
                /*0xf8*/ UnityEngine.Collider2D m_BoundingShape2D;

                static /*0x796fd8c*/ bool <ValidateCache>g__HasAnyPoints|10_0(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> originalPath);
                /*0x796e62c*/ void Invalidate();
                /*0x796e824*/ bool ValidateCache(UnityEngine.Collider2D boundingShape2D, Unity.Cinemachine.CinemachineConfiner2D.OversizeWindowSettings oversize, float aspectRatio, ref bool confinerStateChanged);
                /*0x796faec*/ bool IsValid(ref UnityEngine.Collider2D boundingShape2D, ref Unity.Cinemachine.CinemachineConfiner2D.OversizeWindowSettings oversize, float aspectRatio);
                /*0x796fc4c*/ void CalculateDeltaTransformationMatrix();
            }
        }

        class CinemachineConfiner3D : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ UnityEngine.Collider BoundingVolume;
            /*0x38*/ float SlowingDistance;

            /*0x7970584*/ CinemachineConfiner3D();
            /*0x796fe40*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x796fe58*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x796ff28*/ void Reset();
            /*0x796ff4c*/ void OnValidate();
            /*0x796ff60*/ bool get_IsValid();
            /*0x7970008*/ float GetMaxDampTime();
            /*0x797001c*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x797011c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79703a4*/ UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 p);
            /*0x79704c0*/ float GetDistanceFromEdge(UnityEngine.Vector3 p, UnityEngine.Vector3 dirUnit, float max);

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 PreviousDisplacement;
                /*0x24*/ UnityEngine.Vector3 PreviousCameraPosition;

                /*0x797058c*/ VcamExtraState();
            }
        }

        class CinemachineDecollider : Unity.Cinemachine.CinemachineExtension
        {
            static int kColliderBufferSize = 10;
            static /*0x0*/ UnityEngine.Collider[] s_ColliderBuffer;
            static /*0x8*/ float[] s_ColliderDistanceBuffer;
            static /*0x10*/ int[] s_ColliderOrderBuffer;
            static /*0x18*/ System.Collections.Generic.IComparer<int> s_ColliderBufferSorter;
            /*0x30*/ float CameraRadius;
            /*0x34*/ Unity.Cinemachine.CinemachineDecollider.DecollisionSettings Decollision;
            /*0x4c*/ Unity.Cinemachine.CinemachineDecollider.TerrainSettings TerrainResolution;

            static /*0x7971a44*/ CinemachineDecollider();
            /*0x7971a30*/ CinemachineDecollider();
            /*0x7970594*/ void OnValidate();
            /*0x79705ac*/ void Reset();
            /*0x7970628*/ void OnDestroy();
            /*0x7970688*/ float GetMaxDampTime();
            /*0x79706b4*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7970bc4*/ UnityEngine.Vector3 GetAvoidanceResolutionTargetPoint(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state);
            /*0x7970d8c*/ float ResolveTerrain(Unity.Cinemachine.CinemachineDecollider.VcamExtraState extra, UnityEngine.Vector3 camPos, UnityEngine.Vector3 up, float deltaTime);
            /*0x7970fdc*/ UnityEngine.Vector3 DecollideCamera(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPoint);
            /*0x79716b8*/ UnityEngine.Vector3 ApplySmoothingAndDamping(UnityEngine.Vector3 displacement, UnityEngine.Vector3 lookAtPoint, UnityEngine.Vector3 oldCamPos, Unity.Cinemachine.CinemachineDecollider.VcamExtraState extra, float deltaTime);

            struct DecollisionSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.LayerMask ObstacleLayers;
                /*0x18*/ Unity.Cinemachine.CinemachineDecollider.DecollisionSettings.FollowTargetSettings UseFollowTarget;
                /*0x20*/ float Damping;
                /*0x24*/ float SmoothingTime;

                struct FollowTargetSettings
                {
                    /*0x10*/ bool Enabled;
                    /*0x14*/ float YOffset;
                }
            }

            struct TerrainSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.LayerMask TerrainLayers;
                /*0x18*/ float MaximumRaycast;
                /*0x1c*/ float Damping;
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ float PreviousTerrainDisplacement;
                /*0x1c*/ float PreviousObstacleDisplacement;
                /*0x20*/ UnityEngine.Vector3 PreviousCorrectedCameraPosition;
                /*0x2c*/ float m_SmoothedDistance;
                /*0x30*/ float m_SmoothingStartTime;

                /*0x7971be4*/ VcamExtraState();
                /*0x7971920*/ float UpdateDistanceSmoothing(float distance, float smoothingTime, bool haveDisplacement);
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineDecollider.<> <>9;

                static /*0x7971bec*/ <>c();
                /*0x7971c54*/ <>c();
                /*0x7971c5c*/ int <.cctor>b__21_0(int a, int b);
            }
        }

        class CinemachineDeoccluder : Unity.Cinemachine.CinemachineExtension, Unity.Cinemachine.IShotQualityEvaluator
        {
            static float k_PrecisionSlush = 0.0010000000474974513;
            static float k_AngleThreshold = 0.10000000149011612;
            static /*0x0*/ UnityEngine.Collider[] s_ColliderBuffer;
            /*0x30*/ UnityEngine.LayerMask CollideAgainst;
            /*0x38*/ string IgnoreTag;
            /*0x40*/ UnityEngine.LayerMask TransparentLayers;
            /*0x44*/ float MinimumDistanceFromTarget;
            /*0x48*/ Unity.Cinemachine.CinemachineDeoccluder.ObstacleAvoidance AvoidObstacles;
            /*0x74*/ Unity.Cinemachine.CinemachineDeoccluder.QualityEvaluation ShotQualityEvaluation;
            /*0x88*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineDeoccluder.VcamExtraState> m_extraStateCache;
            /*0x90*/ UnityEngine.RaycastHit[] m_CornerBuffer;

            static /*0x7976750*/ CinemachineDeoccluder();
            static /*0x7975a1c*/ float ClampRayToBounds(UnityEngine.Ray ray, float distance, UnityEngine.Bounds bounds);
            /*0x7976694*/ CinemachineDeoccluder();
            /*0x7971d58*/ bool IsTargetObscured(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7971dc0*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7971dd8*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7971ea8*/ void OnValidate();
            /*0x7971f14*/ void Reset();
            /*0x7972020*/ void OnDestroy();
            /*0x7972080*/ void OnEnable();
            /*0x7972180*/ void DebugCollisionPaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> paths, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Collider>> obstacles);
            /*0x797240c*/ float GetMaxDampTime();
            /*0x7972438*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79724d8*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7972f9c*/ bool GetAvoidanceResolutionTargetPoint(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, ref UnityEngine.Vector3 resolutuionTargetPoint);
            /*0x7973174*/ UnityEngine.Vector3 PreserveLineOfSight(ref Unity.Cinemachine.CameraState state, ref Unity.Cinemachine.CinemachineDeoccluder.VcamExtraState extra, UnityEngine.Vector3 lookAtPoint);
            /*0x797442c*/ UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, int layerMask, ref UnityEngine.RaycastHit hitInfo);
            /*0x7974760*/ UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, float targetDistance, int iterations, ref Unity.Cinemachine.CinemachineDeoccluder.VcamExtraState extra);
            /*0x7975064*/ bool GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, ref UnityEngine.Vector3 outDir);
            /*0x7975820*/ float GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, float targetDistance, UnityEngine.Vector3 lookAtPos);
            /*0x79736d8*/ UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos);
            /*0x7974148*/ bool IsTargetObscured(Unity.Cinemachine.CameraState state);

            struct ObstacleAvoidance
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float DistanceLimit;
                /*0x18*/ float MinimumOcclusionTime;
                /*0x1c*/ float CameraRadius;
                /*0x20*/ Unity.Cinemachine.CinemachineDeoccluder.ObstacleAvoidance.FollowTargetSettings UseFollowTarget;
                /*0x28*/ Unity.Cinemachine.CinemachineDeoccluder.ObstacleAvoidance.ResolutionStrategy Strategy;
                /*0x2c*/ int MaximumEffort;
                /*0x30*/ float SmoothingTime;
                /*0x34*/ float Damping;
                /*0x38*/ float DampingWhenOccluded;

                static /*0x7971fc4*/ Unity.Cinemachine.CinemachineDeoccluder.ObstacleAvoidance get_Default();

                struct FollowTargetSettings
                {
                    /*0x10*/ bool Enabled;
                    /*0x14*/ float YOffset;
                }

                enum ResolutionStrategy
                {
                    PullCameraForward = 0,
                    PreserveCameraHeight = 1,
                    PreserveCameraDistance = 2,
                }
            }

            struct QualityEvaluation
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float OptimalDistance;
                /*0x18*/ float NearLimit;
                /*0x1c*/ float FarLimit;
                /*0x20*/ float MaxQualityBoost;

                static /*0x797200c*/ Unity.Cinemachine.CinemachineDeoccluder.QualityEvaluation get_Default();
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 PreviousDisplacement;
                /*0x24*/ bool TargetObscured;
                /*0x28*/ float OcclusionStartTime;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Vector3> DebugResolutionPath;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Collider> OccludingObjects;
                /*0x40*/ UnityEngine.Vector3 PreviousCameraOffset;
                /*0x4c*/ UnityEngine.Vector3 PreviousCameraPosition;
                /*0x58*/ float PreviousDampTime;
                /*0x5c*/ bool StateIsValid;
                /*0x60*/ float m_SmoothedDistance;
                /*0x64*/ float m_SmoothedTime;

                /*0x79767c4*/ VcamExtraState();
                /*0x797475c*/ void AddPointToDebugPath(UnityEngine.Vector3 p, UnityEngine.Collider c);
                /*0x79735bc*/ float ApplyDistanceSmoothing(float distance, float smoothingTime);
                /*0x797353c*/ void UpdateDistanceSmoothing(float distance);
                /*0x7973660*/ void ResetDistanceSmoothing(float smoothingTime);
            }
        }

        class CinemachineExternalCamera : Unity.Cinemachine.CinemachineVirtualCameraBase
        {
            /*0x9c*/ Unity.Cinemachine.CinemachineCore.BlendHints BlendHint;
            /*0xa0*/ UnityEngine.Transform LookAtTarget;
            /*0xa8*/ UnityEngine.Camera m_Camera;
            /*0xb0*/ Unity.Cinemachine.CameraState m_State;
            /*0x1c0*/ UnityEngine.Transform <Follow>k__BackingField;

            /*0x7976c64*/ CinemachineExternalCamera();
            /*0x79767cc*/ Unity.Cinemachine.CameraState get_State();
            /*0x79767dc*/ UnityEngine.Transform get_LookAt();
            /*0x79767e4*/ void set_LookAt(UnityEngine.Transform value);
            /*0x79767ec*/ UnityEngine.Transform get_Follow();
            /*0x79767f4*/ void set_Follow(UnityEngine.Transform value);
            /*0x7976804*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
        }

        class CinemachineFollowZoom : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ float Width;
            /*0x34*/ float Damping;
            /*0x38*/ UnityEngine.Vector2 FovRange;

            /*0x7977014*/ CinemachineFollowZoom();
            /*0x7976d08*/ void Reset();
            /*0x7976d20*/ void OnValidate();
            /*0x7976d64*/ float GetMaxDampTime();
            /*0x7976d6c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ float m_PreviousFrameZoom;

                /*0x7977030*/ VcamExtraState();
            }
        }

        class CinemachineFreeLookModifier : Unity.Cinemachine.CinemachineExtension
        {
            static /*0x0*/ UnityEngine.AnimationCurve s_EasingCurve;
            /*0x30*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineFreeLookModifier.Modifier> Modifiers;
            /*0x38*/ Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource m_ValueSource;
            /*0x40*/ float m_CurrentValue;

            static /*0x3843dfc*/ void TryGetVcamComponent<T>(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref T component);
            /*0x797757c*/ CinemachineFreeLookModifier();
            /*0x7977038*/ void OnValidate();
            /*0x79770fc*/ void OnEnable();
            /*0x7977118*/ void RefreshComponentCache();
            /*0x79771f8*/ bool HasValueSource();
            /*0x7977218*/ void PrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7977444*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            interface IModifierValueSource
            {
                /*0x38151b8*/ float get_NormalizedModifierValue();
            }

            interface IModifiablePositionDamping
            {
                /*0x38159a4*/ UnityEngine.Vector3 get_PositionDamping();
                /*0x3817254*/ void set_PositionDamping(UnityEngine.Vector3 value);
            }

            interface IModifiableComposition
            {
                Unity.Cinemachine.ScreenComposerSettings get_Composition();
                void set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            }

            interface IModifiableDistance
            {
                /*0x38151b8*/ float get_Distance();
                /*0x3816f24*/ void set_Distance(float value);
            }

            interface IModifiableNoise
            {
                System.ValueTuple<float, float> get_NoiseAmplitudeFrequency();
                void set_NoiseAmplitudeFrequency(System.ValueTuple<float, float> value);
            }

            class Modifier
            {
                /*0x7977628*/ Modifier();
                /*0x7977604*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977608*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x797760c*/ System.Type get_CachedComponentType();
                /*0x7977614*/ bool get_HasRequiredComponent();
                /*0x797761c*/ void RefreshCache(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977620*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x7977624*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class ComponentModifier<T> : Unity.Cinemachine.CinemachineFreeLookModifier.Modifier
            {
                /*0x0*/ T CachedComponent;

                /*0x38159dc*/ ComponentModifier();
                /*0x3813ffc*/ bool get_HasRequiredComponent();
                /*0x38148bc*/ System.Type get_CachedComponentType();
                /*0x3816710*/ void RefreshCache(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            }

            class TiltModifier : Unity.Cinemachine.CinemachineFreeLookModifier.Modifier
            {
                /*0x10*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<float> Tilt;

                /*0x7977848*/ TiltModifier();
                /*0x7977630*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x797765c*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x797766c*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class LensModifier : Unity.Cinemachine.CinemachineFreeLookModifier.Modifier
            {
                /*0x10*/ Unity.Cinemachine.LensSettings Top;
                /*0x68*/ Unity.Cinemachine.LensSettings Bottom;

                /*0x7977a4c*/ LensModifier();
                /*0x7977850*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977874*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79779d4*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class PositionDampingModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<UnityEngine.Vector3> Damping;
                /*0x30*/ UnityEngine.Vector3 m_CenterDamping;

                /*0x7977dd4*/ PositionDampingModifier();
                /*0x7977a54*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977a8c*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977b38*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x7977cfc*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class CompositionModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<Unity.Cinemachine.ScreenComposerSettings> Composition;
                /*0x68*/ Unity.Cinemachine.ScreenComposerSettings m_SavedComposition;

                /*0x79781b4*/ CompositionModifier();
                /*0x7977e1c*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977e40*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7977f1c*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x79780dc*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class DistanceModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<float> Distance;
                /*0x20*/ float m_CenterDistance;

                /*0x79784f4*/ DistanceModifier();
                /*0x79781fc*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7978214*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79782b8*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x7978434*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class NoiseModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<Unity.Cinemachine.CinemachineFreeLookModifier.NoiseModifier.NoiseSettings> Noise;
                /*0x28*/ System.ValueTuple<float, float> m_CenterNoise;

                /*0x79788b4*/ NoiseModifier();
                /*0x797853c*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79785e4*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x79787f0*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);

                struct NoiseSettings
                {
                    /*0x10*/ float Amplitude;
                    /*0x14*/ float Frequency;
                }
            }

            struct TopBottomRigs<T>
            {
                /*0x0*/ T Top;
                /*0x0*/ T Bottom;
            }
        }

        class CinemachineGroupFraming : Unity.Cinemachine.CinemachineExtension
        {
            static float k_MinimumGroupSize = 0.009999999776482582;
            /*0x30*/ Unity.Cinemachine.CinemachineGroupFraming.FramingModes FramingMode;
            /*0x34*/ float FramingSize;
            /*0x38*/ UnityEngine.Vector2 CenterOffset;
            /*0x40*/ float Damping;
            /*0x44*/ Unity.Cinemachine.CinemachineGroupFraming.SizeAdjustmentModes SizeAdjustment;
            /*0x48*/ Unity.Cinemachine.CinemachineGroupFraming.LateralAdjustmentModes LateralAdjustment;
            /*0x4c*/ UnityEngine.Vector2 FovRange;
            /*0x54*/ UnityEngine.Vector2 DollyRange;
            /*0x5c*/ UnityEngine.Vector2 OrthoSizeRange;
            /*0x64*/ UnityEngine.Bounds GroupBounds;
            /*0x7c*/ UnityEngine.Matrix4x4 GroupBoundsMatrix;

            /*0x797a660*/ CinemachineGroupFraming();
            /*0x79788fc*/ void OnValidate();
            /*0x7978978*/ void Reset();
            /*0x7978a04*/ float GetMaxDampTime();
            /*0x7978a0c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7978d90*/ void OrthoFraming(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.ICinemachineTargetGroup group, Unity.Cinemachine.CinemachineGroupFraming.VcamExtraState extra, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7979188*/ void PerspectiveFraming(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.ICinemachineTargetGroup group, Unity.Cinemachine.CinemachineGroupFraming.VcamExtraState extra, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x797a4ac*/ void AdjustSize(Unity.Cinemachine.ICinemachineTargetGroup group, float aspect, ref UnityEngine.Vector3 camPos, ref UnityEngine.Quaternion camRot, ref float fov, ref float dollyAmount);
            /*0x7979b4c*/ void ComputeCameraViewGroupBounds(Unity.Cinemachine.ICinemachineTargetGroup group, ref UnityEngine.Vector3 camPos, ref UnityEngine.Quaternion camRot, bool moveCamera);
            /*0x7979aec*/ float GetFrameHeight(UnityEngine.Vector2 boundsSize, float aspect);

            enum FramingModes
            {
                Horizontal = 0,
                Vertical = 1,
                HorizontalAndVertical = 2,
            }

            enum SizeAdjustmentModes
            {
                ZoomOnly = 0,
                DollyOnly = 1,
                DollyThenZoom = 2,
            }

            enum LateralAdjustmentModes
            {
                ChangePosition = 0,
                ChangeRotation = 1,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 PosAdjustment;
                /*0x24*/ UnityEngine.Vector2 RotAdjustment;
                /*0x2c*/ float FovAdjustment;
                /*0x30*/ Unity.Cinemachine.CinemachineCore.Stage Stage;
                /*0x38*/ Unity.Cinemachine.CinemachineConfiner2D Confiner;
                /*0x40*/ float PreviousOrthoSize;

                /*0x797a6ec*/ VcamExtraState();
                /*0x7978cf8*/ void Reset();
            }
        }

        class CinemachineMixingCamera : Unity.Cinemachine.CinemachineCameraManagerBase
        {
            static int MaxCameras = 8;
            /*0x208*/ float Weight0;
            /*0x20c*/ float Weight1;
            /*0x210*/ float Weight2;
            /*0x214*/ float Weight3;
            /*0x218*/ float Weight4;
            /*0x21c*/ float Weight5;
            /*0x220*/ float Weight6;
            /*0x224*/ float Weight7;
            /*0x228*/ Unity.Cinemachine.CameraState m_CameraState;
            /*0x338*/ System.Collections.Generic.Dictionary<Unity.Cinemachine.CinemachineVirtualCameraBase, int> m_IndexMap;
            /*0x340*/ float m_LiveChildPercent;

            /*0x797b448*/ CinemachineMixingCamera();
            /*0x797a6fc*/ void OnValidate();
            /*0x797a96c*/ void Reset();
            /*0x797a9c8*/ Unity.Cinemachine.CameraState get_State();
            /*0x797a9d8*/ string get_Description();
            /*0x797a74c*/ float GetWeight(int index);
            /*0x797a85c*/ void SetWeight(int index, float w);
            /*0x797ac3c*/ float GetWeight(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x797acd0*/ void SetWeight(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, float w);
            /*0x797ae30*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera vcam, bool dominantChildOnly);
            /*0x797af40*/ bool UpdateCameraCache();
            /*0x797b084*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797b18c*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797b440*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
        }

        class CinemachinePixelPerfect : Unity.Cinemachine.CinemachineExtension
        {
            /*0x797b688*/ CinemachinePixelPerfect();
            /*0x797b4f8*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
        }

        class CinemachineRecomposer : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ Unity.Cinemachine.CinemachineCore.Stage ApplyAfter;
            /*0x34*/ float Tilt;
            /*0x38*/ float Pan;
            /*0x3c*/ float Dutch;
            /*0x40*/ float ZoomScale;
            /*0x44*/ float FollowAttachment;
            /*0x48*/ float LookAtAttachment;

            /*0x797b9b8*/ CinemachineRecomposer();
            /*0x797b690*/ void Reset();
            /*0x797b6b0*/ void OnValidate();
            /*0x797b6f0*/ void PrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x797b70c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
        }

        class CinemachineSequencerCamera : Unity.Cinemachine.CinemachineCameraManagerBase
        {
            /*0x208*/ bool Loop;
            /*0x210*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineSequencerCamera.Instruction> Instructions;
            /*0x218*/ UnityEngine.Transform m_LegacyLookAt;
            /*0x220*/ UnityEngine.Transform m_LegacyFollow;
            /*0x228*/ float m_ActivationTime;
            /*0x22c*/ int m_CurrentInstruction;

            /*0x797c0a8*/ CinemachineSequencerCamera();
            /*0x797b9c0*/ void Reset();
            /*0x797b9e8*/ void OnValidate();
            /*0x797bb0c*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x797bca4*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797bd04*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797bfb4*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming);
            /*0x797c01c*/ bool UpdateCameraCache();
            /*0x797bdc8*/ void AdvanceCurrentInstruction(float deltaTime);

            struct Instruction
            {
                /*0x10*/ Unity.Cinemachine.CinemachineVirtualCameraBase Camera;
                /*0x18*/ Unity.Cinemachine.CinemachineBlendDefinition Blend;
                /*0x28*/ float Hold;

                /*0x797baf8*/ void Validate();
            }
        }

        class CinemachineShotQualityEvaluator : Unity.Cinemachine.CinemachineExtension, Unity.Cinemachine.IShotQualityEvaluator
        {
            /*0x30*/ UnityEngine.LayerMask OcclusionLayers;
            /*0x38*/ string IgnoreTag;
            /*0x40*/ float MinimumDistanceFromTarget;
            /*0x44*/ float CameraRadius;
            /*0x48*/ Unity.Cinemachine.CinemachineShotQualityEvaluator.DistanceEvaluationSettings DistanceEvaluation;

            /*0x797c674*/ CinemachineShotQualityEvaluator();
            /*0x797c138*/ void OnValidate();
            /*0x797c18c*/ void Reset();
            /*0x797c1fc*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x797c3cc*/ bool IsTargetObscured(Unity.Cinemachine.CameraState state);

            struct DistanceEvaluationSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float OptimalDistance;
                /*0x18*/ float NearLimit;
                /*0x1c*/ float FarLimit;
                /*0x20*/ float MaxQualityBoost;

                static /*0x797c1e8*/ Unity.Cinemachine.CinemachineShotQualityEvaluator.DistanceEvaluationSettings get_Default();
            }
        }

        class CinemachineSplineCart : UnityEngine.MonoBehaviour, Unity.Cinemachine.ISplineReferencer
        {
            /*0x20*/ Unity.Cinemachine.SplineSettings m_SplineSettings;
            /*0x40*/ Unity.Cinemachine.CinemachineSplineCart.UpdateMethods UpdateMethod;
            /*0x48*/ Unity.Cinemachine.SplineAutoDolly AutomaticDolly;
            /*0x58*/ UnityEngine.Transform TrackingTarget;
            /*0x60*/ Unity.Cinemachine.CinemachineSplineRoll.RollCache m_RollCache;
            /*0x68*/ float m_LegacyPosition;
            /*0x6c*/ UnityEngine.Splines.PathIndexUnit m_LegacyUnits;
            /*0x70*/ UnityEngine.Splines.SplineContainer m_LegacySpline;

            /*0x797cd48*/ CinemachineSplineCart();
            /*0x797c6d8*/ ref Unity.Cinemachine.SplineSettings get_SplineSettings();
            /*0x797c6e0*/ UnityEngine.Splines.SplineContainer get_Spline();
            /*0x797c6e8*/ void set_Spline(UnityEngine.Splines.SplineContainer value);
            /*0x797c6f0*/ float get_SplinePosition();
            /*0x797c6f8*/ void set_SplinePosition(float value);
            /*0x797c700*/ UnityEngine.Splines.PathIndexUnit get_PositionUnits();
            /*0x797c708*/ void set_PositionUnits(UnityEngine.Splines.PathIndexUnit value);
            /*0x797c714*/ void PerformLegacyUpgrade();
            /*0x797c7cc*/ void OnValidate();
            /*0x797c87c*/ void Reset();
            /*0x797c8c4*/ void OnEnable();
            /*0x797c980*/ void OnDisable();
            /*0x797c98c*/ void FixedUpdate();
            /*0x797ca9c*/ void Update();
            /*0x797ccbc*/ void LateUpdate();
            /*0x797c9a0*/ void UpdateCartPosition();
            /*0x797cb24*/ void SetCartPosition(float distanceAlongPath);

            enum UpdateMethods
            {
                Update = 0,
                FixedUpdate = 1,
                LateUpdate = 2,
            }
        }

        class CinemachineSplineRoll : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x20*/ bool Easing;
            /*0x28*/ UnityEngine.Splines.SplineData<Unity.Cinemachine.CinemachineSplineRoll.RollData> Roll;
            /*0x30*/ int m_StreamingVersion;

            /*0x797cf94*/ CinemachineSplineRoll();
            /*0x797cd80*/ UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineRoll.RollData> GetInterpolator();
            /*0x797ce00*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x797cef8*/ void Reset();
            /*0x797cf50*/ void OnEnable();
            /*0x797cf54*/ void OnBeforeSerialize();
            /*0x797cf58*/ void OnAfterDeserialize();

            struct RollData
            {
                /*0x10*/ float Value;

                static /*0x797cfa4*/ float op_Implicit(Unity.Cinemachine.CinemachineSplineRoll.RollData roll);
                static /*0x797cef4*/ Unity.Cinemachine.CinemachineSplineRoll.RollData op_Implicit(float roll);
            }

            struct LerpRollData : UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineRoll.RollData>
            {
                /*0x797cfa8*/ Unity.Cinemachine.CinemachineSplineRoll.RollData Interpolate(Unity.Cinemachine.CinemachineSplineRoll.RollData a, Unity.Cinemachine.CinemachineSplineRoll.RollData b, float t);
            }

            struct LerpRollDataWithEasing : UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineRoll.RollData>
            {
                /*0x797cfcc*/ Unity.Cinemachine.CinemachineSplineRoll.RollData Interpolate(Unity.Cinemachine.CinemachineSplineRoll.RollData a, Unity.Cinemachine.CinemachineSplineRoll.RollData b, float t);
            }

            struct RollCache
            {
                /*0x10*/ Unity.Cinemachine.CinemachineSplineRoll m_RollCache;

                /*0x797d00c*/ void Refresh(UnityEngine.MonoBehaviour owner);
                /*0x797d164*/ Unity.Cinemachine.CinemachineSplineRoll GetSplineRoll(UnityEngine.MonoBehaviour owner);
            }
        }

        class CinemachineStateDrivenCamera : Unity.Cinemachine.CinemachineCameraManagerBase
        {
            /*0x208*/ UnityEngine.Animator AnimatedTarget;
            /*0x210*/ int LayerIndex;
            /*0x218*/ Unity.Cinemachine.CinemachineStateDrivenCamera.Instruction[] Instructions;
            /*0x220*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineStateDrivenCamera.ParentHash> HashOfParent;
            /*0x228*/ UnityEngine.Transform m_LegacyLookAt;
            /*0x230*/ UnityEngine.Transform m_LegacyFollow;
            /*0x238*/ float m_ActivationTime;
            /*0x23c*/ int m_ActiveInstructionIndex;
            /*0x240*/ float m_PendingActivationTime;
            /*0x244*/ int m_PendingInstructionIndex;
            /*0x248*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> m_InstructionDictionary;
            /*0x250*/ System.Collections.Generic.Dictionary<int, int> m_StateParentLookup;
            /*0x258*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> m_ClipInfoList;
            /*0x260*/ System.Collections.Generic.Dictionary<UnityEngine.AnimationClip, System.Collections.Generic.List<Unity.Cinemachine.CinemachineStateDrivenCamera.HashPair>> m_HashCache;

            static /*0x797d410*/ int CreateFakeHash(int parentHash, UnityEngine.AnimationClip clip);
            /*0x797e268*/ CinemachineStateDrivenCamera();
            /*0x797d16c*/ void SetParentHash(System.Collections.Generic.List<Unity.Cinemachine.CinemachineStateDrivenCamera.ParentHash> list);
            /*0x797d1dc*/ void Reset();
            /*0x797d278*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x797d49c*/ int LookupFakeHash(int parentHash, UnityEngine.AnimationClip clip);
            /*0x797d70c*/ void ValidateInstructions();
            /*0x797da94*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797e060*/ int GetClipHash(int hash, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
            /*0x797e1d4*/ void CancelWait();

            struct Instruction
            {
                /*0x10*/ int FullHash;
                /*0x18*/ Unity.Cinemachine.CinemachineVirtualCameraBase Camera;
                /*0x20*/ float ActivateAfter;
                /*0x24*/ float MinDuration;
            }

            struct ParentHash
            {
                /*0x10*/ int Hash;
                /*0x14*/ int HashOfParent;
            }

            struct HashPair
            {
                /*0x10*/ int parentHash;
                /*0x14*/ int hash;
            }
        }

        class CinemachineStoryboard : Unity.Cinemachine.CinemachineExtension
        {
            static /*0x0*/ bool s_StoryboardGlobalMute;
            /*0x30*/ bool ShowImage;
            /*0x38*/ UnityEngine.Texture Image;
            /*0x40*/ Unity.Cinemachine.CinemachineStoryboard.FillStrategy Aspect;
            /*0x44*/ float Alpha;
            /*0x48*/ UnityEngine.Vector2 Center;
            /*0x50*/ UnityEngine.Vector3 Rotation;
            /*0x5c*/ UnityEngine.Vector2 Scale;
            /*0x64*/ bool SyncScale;
            /*0x65*/ bool MuteCamera;
            /*0x68*/ float SplitView;
            /*0x6c*/ Unity.Cinemachine.CinemachineStoryboard.StoryboardRenderMode RenderMode;
            /*0x70*/ int SortingOrder;
            /*0x74*/ float PlaneDistance;
            /*0x78*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineStoryboard.CanvasInfo> m_CanvasInfo;

            static /*0x797f9f4*/ void StaticBlendingHandler(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x797fbe4*/ void InitializeModule();
            /*0x797fd00*/ CinemachineStoryboard();
            /*0x797e344*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x797e464*/ void UpdateRenderCanvas();
            /*0x797e608*/ void ConnectToVcam(bool connect);
            /*0x797e998*/ string get_CanvasName();
            /*0x797ea1c*/ void CameraUpdatedCallback(Unity.Cinemachine.CinemachineBrain brain);
            /*0x797eb9c*/ Unity.Cinemachine.CinemachineStoryboard.CanvasInfo LocateMyCanvas(Unity.Cinemachine.CinemachineBrain parent, bool createIfNotFound);
            /*0x797f028*/ void CreateCanvas(Unity.Cinemachine.CinemachineStoryboard.CanvasInfo ci);
            /*0x797e770*/ void DestroyCanvas();
            /*0x797f4c0*/ void PlaceImage(Unity.Cinemachine.CinemachineStoryboard.CanvasInfo ci, float alpha);

            enum FillStrategy
            {
                BestFit = 0,
                CropImageToFit = 1,
                StretchToFit = 2,
            }

            class CanvasInfo
            {
                /*0x10*/ UnityEngine.GameObject Canvas;
                /*0x18*/ UnityEngine.Canvas CanvasComponent;
                /*0x20*/ Unity.Cinemachine.CinemachineBrain CanvasParent;
                /*0x28*/ UnityEngine.RectTransform Viewport;
                /*0x30*/ UnityEngine.UI.RawImage RawImage;

                /*0x797f020*/ CanvasInfo();
            }

            enum StoryboardRenderMode
            {
                ScreenSpaceOverlay = 0,
                ScreenSpaceCamera = 1,
            }
        }

        interface ICinemachineTargetGroup
        {
            /*0x3813ffc*/ bool get_IsValid();
            /*0x38148bc*/ UnityEngine.Transform get_Transform();
            UnityEngine.Bounds get_BoundingBox();
            UnityEngine.BoundingSphere get_Sphere();
            /*0x3813ffc*/ bool get_IsEmpty();
            UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer, bool includeBehind);
            void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, ref UnityEngine.Vector2 minAngles, ref UnityEngine.Vector2 maxAngles, ref UnityEngine.Vector2 zRange);
        }

        class CinemachineTargetGroup : UnityEngine.MonoBehaviour, Unity.Cinemachine.ICinemachineTargetGroup
        {
            /*0x20*/ Unity.Cinemachine.CinemachineTargetGroup.PositionModes PositionMode;
            /*0x24*/ Unity.Cinemachine.CinemachineTargetGroup.RotationModes RotationMode;
            /*0x28*/ Unity.Cinemachine.CinemachineTargetGroup.UpdateMethods UpdateMethod;
            /*0x30*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineTargetGroup.Target> Targets;
            /*0x38*/ float m_MaxWeight;
            /*0x3c*/ float m_WeightSum;
            /*0x40*/ UnityEngine.Vector3 m_AveragePos;
            /*0x4c*/ UnityEngine.Bounds m_BoundingBox;
            /*0x64*/ UnityEngine.BoundingSphere m_BoundingSphere;
            /*0x74*/ int m_LastUpdateFrame;
            /*0x78*/ System.Collections.Generic.List<int> m_ValidMembers;
            /*0x80*/ System.Collections.Generic.List<bool> m_MemberValidity;
            /*0x88*/ Unity.Cinemachine.CinemachineTargetGroup.Target[] m_LegacyTargets;

            static /*0x7980768*/ UnityEngine.BoundingSphere WeightedMemberBoundsForValidMember(Unity.Cinemachine.CinemachineTargetGroup.Target t, UnityEngine.Vector3 avgPos, float maxWeight);
            /*0x798203c*/ CinemachineTargetGroup();
            /*0x797fe48*/ void OnValidate();
            /*0x797ff58*/ void Reset();
            /*0x797ffd4*/ void Awake();
            /*0x7980048*/ Unity.Cinemachine.CinemachineTargetGroup.Target[] get_m_Targets();
            /*0x7980098*/ void set_m_Targets(Unity.Cinemachine.CinemachineTargetGroup.Target[] value);
            /*0x7980128*/ UnityEngine.Transform get_Transform();
            /*0x7980130*/ bool get_IsValid();
            /*0x798018c*/ UnityEngine.Bounds get_BoundingBox();
            /*0x79802e0*/ void set_BoundingBox(UnityEngine.Bounds value);
            /*0x79802f4*/ UnityEngine.BoundingSphere get_Sphere();
            /*0x7980330*/ void set_Sphere(UnityEngine.BoundingSphere value);
            /*0x798033c*/ bool get_IsEmpty();
            /*0x79803a8*/ void AddMember(UnityEngine.Transform t, float weight, float radius);
            /*0x79804d0*/ void RemoveMember(UnityEngine.Transform t);
            /*0x7980544*/ int FindMember(UnityEngine.Transform t);
            /*0x798062c*/ UnityEngine.BoundingSphere GetWeightedBoundsForMember(int index);
            /*0x7980890*/ UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer, bool includeBehind);
            /*0x7980c4c*/ bool get_CachedCountIsValid();
            /*0x79806fc*/ bool IndexIsValid(int index);
            /*0x79801d4*/ void DoUpdate();
            /*0x7980cb4*/ void UpdateMemberValidity();
            /*0x7981098*/ UnityEngine.Vector3 CalculateAveragePosition();
            /*0x7981230*/ UnityEngine.Bounds CalculateBoundingBox();
            /*0x7981524*/ UnityEngine.BoundingSphere CalculateBoundingSphere();
            /*0x798174c*/ UnityEngine.Quaternion CalculateAverageOrientation();
            /*0x7981a8c*/ void FixedUpdate();
            /*0x7981aa0*/ void Update();
            /*0x7981b14*/ void LateUpdate();
            /*0x7981b28*/ void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, ref UnityEngine.Vector2 minAngles, ref UnityEngine.Vector2 maxAngles, ref UnityEngine.Vector2 zRange);

            class Target
            {
                /*0x10*/ UnityEngine.Transform Object;
                /*0x18*/ float Weight;
                /*0x1c*/ float Radius;

                /*0x79804bc*/ Target();
            }

            enum PositionModes
            {
                GroupCenter = 0,
                GroupAverage = 1,
            }

            enum RotationModes
            {
                Manual = 0,
                GroupAverage = 1,
            }

            enum UpdateMethods
            {
                Update = 0,
                FixedUpdate = 1,
                LateUpdate = 2,
            }
        }

        class CinemachineThirdPersonAim : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ UnityEngine.LayerMask AimCollisionFilter;
            /*0x38*/ string IgnoreTag;
            /*0x40*/ float AimDistance;
            /*0x44*/ bool NoiseCancellation;
            /*0x48*/ UnityEngine.Vector3 <AimTarget>k__BackingField;

            /*0x7982950*/ CinemachineThirdPersonAim();
            /*0x798217c*/ UnityEngine.Vector3 get_AimTarget();
            /*0x7982188*/ void set_AimTarget(UnityEngine.Vector3 value);
            /*0x7982194*/ void OnValidate();
            /*0x79821a8*/ void Reset();
            /*0x7982200*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79824fc*/ UnityEngine.Vector3 ComputeLookAtPoint(UnityEngine.Vector3 camPos, UnityEngine.Transform player, UnityEngine.Vector3 fwd);
            /*0x7982758*/ UnityEngine.Vector3 ComputeAimTarget(UnityEngine.Vector3 cameraLookAt, UnityEngine.Transform player);
        }

        class CinemachineBasicMultiChannelPerlin : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise
        {
            /*0x28*/ Unity.Cinemachine.NoiseSettings NoiseProfile;
            /*0x30*/ UnityEngine.Vector3 PivotOffset;
            /*0x3c*/ float AmplitudeGain;
            /*0x40*/ float FrequencyGain;
            /*0x44*/ bool m_Initialized;
            /*0x48*/ float m_NoiseTime;
            /*0x4c*/ UnityEngine.Vector3 m_NoiseOffsets;

            /*0x798307c*/ CinemachineBasicMultiChannelPerlin();
            /*0x798298c*/ System.ValueTuple<float, float> Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.get_NoiseAmplitudeFrequency();
            /*0x79829ec*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.set_NoiseAmplitudeFrequency(System.ValueTuple<float, float> value);
            /*0x79829f4*/ bool get_IsValid();
            /*0x7982a74*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7982a7c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x798300c*/ void ReSeed();
            /*0x7982f18*/ void Initialize();
        }

        class CinemachineFollow : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ Unity.Cinemachine.TargetTracking.TrackerSettings TrackerSettings;
            /*0x4c*/ UnityEngine.Vector3 FollowOffset;
            /*0x58*/ Unity.Cinemachine.TargetTracking.Tracker m_TargetTracker;

            /*0x79837b4*/ CinemachineFollow();
            /*0x79830f8*/ void OnValidate();
            /*0x7983154*/ void Reset();
            /*0x798312c*/ UnityEngine.Vector3 get_EffectiveOffset();
            /*0x79831f0*/ bool get_IsValid();
            /*0x7983280*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7983288*/ float GetMaxDampTime();
            /*0x79832bc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7983514*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79835fc*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79836b0*/ UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 up);
            /*0x79836c4*/ UnityEngine.Vector3 GetDesiredCameraPosition(UnityEngine.Vector3 worldUp);
        }

        class CinemachineHardLockToTarget : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ float Damping;
            /*0x2c*/ UnityEngine.Vector3 m_PreviousTargetPosition;

            /*0x79839ec*/ CinemachineHardLockToTarget();
            /*0x798385c*/ bool get_IsValid();
            /*0x79838ec*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79838f4*/ float GetMaxDampTime();
            /*0x79838fc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
        }

        class CinemachineHardLookAt : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ UnityEngine.Vector3 LookAtOffset;

            /*0x7983db4*/ CinemachineHardLookAt();
            /*0x79839f4*/ bool get_IsValid();
            /*0x7983a84*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7983a8c*/ bool get_CameraLooksAtTarget();
            /*0x7983a94*/ void Reset();
            /*0x7983aec*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
        }

        class CinemachineOrbitalFollow : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.IInputAxisOwner, Unity.Cinemachine.IInputAxisResetSource, Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance
        {
            /*0x28*/ UnityEngine.Vector3 TargetOffset;
            /*0x34*/ Unity.Cinemachine.TargetTracking.TrackerSettings TrackerSettings;
            /*0x58*/ Unity.Cinemachine.CinemachineOrbitalFollow.OrbitStyles OrbitStyle;
            /*0x5c*/ float Radius;
            /*0x60*/ Unity.Cinemachine.Cinemachine3OrbitRig.Settings Orbits;
            /*0x7c*/ Unity.Cinemachine.CinemachineOrbitalFollow.ReferenceFrames RecenteringTarget;
            /*0x80*/ Unity.Cinemachine.InputAxis HorizontalAxis;
            /*0xb4*/ Unity.Cinemachine.InputAxis VerticalAxis;
            /*0xe8*/ Unity.Cinemachine.InputAxis RadialAxis;
            /*0x11c*/ UnityEngine.Vector3 m_PreviousOffset;
            /*0x128*/ Unity.Cinemachine.TargetTracking.Tracker m_TargetTracker;
            /*0x168*/ Unity.Cinemachine.Cinemachine3OrbitRig.OrbitSplineCache m_OrbitCache;
            /*0x1a0*/ System.Action m_ResetHandler;
            /*0x1a8*/ UnityEngine.Vector3 <TrackedPoint>k__BackingField;

            static /*0x7984010*/ Unity.Cinemachine.InputAxis get_DefaultHorizontal();
            static /*0x7984058*/ Unity.Cinemachine.InputAxis get_DefaultVertical();
            static /*0x79840a0*/ Unity.Cinemachine.InputAxis get_DefaultRadial();
            static /*0x79864dc*/ float <InferAxesFromPosition_ThreeRing>g__MapTo01|50_3(float valueToMap, float fMin, float fMax);
            /*0x79862dc*/ CinemachineOrbitalFollow();
            /*0x7983e14*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x7983e24*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x7983e34*/ void OnValidate();
            /*0x7983e90*/ void Reset();
            /*0x79840dc*/ bool get_IsValid();
            /*0x798416c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7984174*/ float GetMaxDampTime();
            /*0x79841a8*/ void Unity.Cinemachine.IInputAxisOwner.GetInputAxes(System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> axes);
            /*0x7984544*/ void Unity.Cinemachine.IInputAxisResetSource.RegisterResetHandler(System.Action handler);
            /*0x79845d8*/ void Unity.Cinemachine.IInputAxisResetSource.UnregisterResetHandler(System.Action handler);
            /*0x798466c*/ bool Unity.Cinemachine.IInputAxisResetSource.get_HasResetHandler();
            /*0x798467c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x7984814*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x7984820*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x798482c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x7984834*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x798483c*/ UnityEngine.Vector3 GetCameraOffsetForNormalizedAxisValue(float t);
            /*0x7984690*/ UnityEngine.Vector4 GetCameraPoint();
            /*0x7984ce8*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7984ef0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7985298*/ void InferAxesFromPosition_Sphere(UnityEngine.Vector3 dir, float distance);
            /*0x7985114*/ void InferAxesFromPosition_ThreeRing(UnityEngine.Vector3 dir, float distance);
            /*0x7985838*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7985920*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7985f08*/ void UpdateHorizontalCenter(UnityEngine.Quaternion referenceOrientation);
            /*0x7986208*/ UnityEngine.Quaternion GetReferenceOrientation();
            /*0x7986404*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_0();
            /*0x798640c*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_1();
            /*0x7986414*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_2();
            /*0x7985444*/ float <InferAxesFromPosition_ThreeRing>g__GetHorizontalAxis|50_0(ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x7985544*/ float <InferAxesFromPosition_ThreeRing>g__GetVerticalAxisClosestValue|50_1(ref UnityEngine.Vector3 splinePoint, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x798641c*/ float <InferAxesFromPosition_ThreeRing>g__SteepestDescent|50_2(UnityEngine.Vector3 cameraOffset, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x79865cc*/ float <InferAxesFromPosition_ThreeRing>g__AngleFunction|50_4(float input, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x7986684*/ float <InferAxesFromPosition_ThreeRing>g__SlopeOfAngleFunction|50_5(float input, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x79864ec*/ float <InferAxesFromPosition_ThreeRing>g__InitialGuess|50_6(ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x79866e8*/ void <InferAxesFromPosition_ThreeRing>g__ChooseBestAngle|50_7(float x, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );

            enum OrbitStyles
            {
                Sphere = 0,
                ThreeRing = 1,
            }

            enum ReferenceFrames
            {
                AxisCenter = 0,
                ParentObject = 1,
                TrackingTarget = 2,
                LookAtTarget = 3,
            }

            struct <>c__DisplayClass50_0
            {
                /*0x10*/ UnityEngine.Quaternion orient;
                /*0x20*/ UnityEngine.Vector3 up;
                /*0x2c*/ UnityEngine.Vector3 dir;
                /*0x38*/ Unity.Cinemachine.CinemachineOrbitalFollow <>4__this;
                /*0x40*/ float distance;
            }

            struct <>c__DisplayClass50_1
            {
                /*0x10*/ UnityEngine.Vector3 cameraOffset;
            }

            struct <>c__DisplayClass50_2
            {
                /*0x10*/ float bestAngle;
                /*0x14*/ float best;
            }
        }

        class Cinemachine3OrbitRig
        {
            struct Orbit
            {
                /*0x10*/ float Radius;
                /*0x14*/ float Height;
            }

            struct Settings
            {
                /*0x10*/ Unity.Cinemachine.Cinemachine3OrbitRig.Orbit Top;
                /*0x18*/ Unity.Cinemachine.Cinemachine3OrbitRig.Orbit Center;
                /*0x20*/ Unity.Cinemachine.Cinemachine3OrbitRig.Orbit Bottom;
                /*0x28*/ float SplineCurvature;

                static /*0x7983fec*/ Unity.Cinemachine.Cinemachine3OrbitRig.Settings get_Default();
            }

            struct OrbitSplineCache
            {
                /*0x10*/ Unity.Cinemachine.Cinemachine3OrbitRig.Settings OrbitSettings;
                /*0x30*/ UnityEngine.Vector4[] CachedKnots;
                /*0x38*/ UnityEngine.Vector4[] CachedCtrl1;
                /*0x40*/ UnityEngine.Vector4[] CachedCtrl2;

                /*0x7984a18*/ bool SettingsChanged(ref Unity.Cinemachine.Cinemachine3OrbitRig.Settings other);
                /*0x7984a94*/ void UpdateOrbitCache(ref Unity.Cinemachine.Cinemachine3OrbitRig.Settings orbits);
                /*0x7984864*/ UnityEngine.Vector4 SplineValue(float t);
            }
        }

        class CinemachinePanTilt : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.IInputAxisOwner, Unity.Cinemachine.IInputAxisResetSource, Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource
        {
            /*0x28*/ Unity.Cinemachine.CinemachinePanTilt.ReferenceFrames ReferenceFrame;
            /*0x2c*/ Unity.Cinemachine.CinemachinePanTilt.RecenterTargetModes RecenterTarget;
            /*0x30*/ Unity.Cinemachine.InputAxis PanAxis;
            /*0x64*/ Unity.Cinemachine.InputAxis TiltAxis;
            /*0x98*/ UnityEngine.Quaternion m_PreviousCameraRotation;
            /*0xa8*/ System.Action m_ResetHandler;

            static /*0x79867f8*/ Unity.Cinemachine.InputAxis get_DefaultPan();
            static /*0x7986840*/ Unity.Cinemachine.InputAxis get_DefaultTilt();
            static /*0x7987880*/ float <GetRecenterTarget>g__NormalizeAngle|31_0(float angle);
            /*0x79878b0*/ CinemachinePanTilt();
            /*0x7986718*/ void OnValidate();
            /*0x798676c*/ void Reset();
            /*0x7986884*/ void Unity.Cinemachine.IInputAxisOwner.GetInputAxes(System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> axes);
            /*0x7986b1c*/ void Unity.Cinemachine.IInputAxisResetSource.RegisterResetHandler(System.Action handler);
            /*0x7986bac*/ void Unity.Cinemachine.IInputAxisResetSource.UnregisterResetHandler(System.Action handler);
            /*0x7986c3c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x7986c74*/ bool Unity.Cinemachine.IInputAxisResetSource.get_HasResetHandler();
            /*0x7986c84*/ bool get_IsValid();
            /*0x7986c8c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7986c94*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7986c98*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x798743c*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x798771c*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7987450*/ void SetAxesForRotation(UnityEngine.Quaternion targetRot);
            /*0x79870b0*/ UnityEngine.Quaternion GetReferenceFrame(UnityEngine.Vector3 up);
            /*0x7987204*/ UnityEngine.Vector2 GetRecenterTarget();
            /*0x7987940*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__14_0();
            /*0x7987948*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__14_1();

            enum ReferenceFrames
            {
                ParentObject = 0,
                World = 1,
                TrackingTarget = 2,
                LookAtTarget = 3,
            }

            enum RecenterTargetModes
            {
                AxisCenter = 0,
                TrackingTargetForward = 1,
                LookAtTargetForward = 2,
            }
        }

        class CinemachinePositionComposer : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition
        {
            static float kMinimumCameraDistance = 0.009999999776482582;
            /*0x28*/ float CameraDistance;
            /*0x2c*/ float DeadZoneDepth;
            /*0x30*/ Unity.Cinemachine.ScreenComposerSettings Composition;
            /*0x58*/ bool CenterOnActivate;
            /*0x5c*/ UnityEngine.Vector3 TargetOffset;
            /*0x68*/ UnityEngine.Vector3 Damping;
            /*0x74*/ Unity.Cinemachine.LookaheadSettings Lookahead;
            /*0x84*/ UnityEngine.Vector3 m_PreviousCameraPosition;
            /*0x90*/ Unity.Cinemachine.PositionPredictor m_Predictor;
            /*0xbc*/ UnityEngine.Quaternion m_prevRotation;
            /*0xcc*/ bool m_InheritingPosition;
            /*0xd0*/ UnityEngine.Vector3 <TrackedPoint>k__BackingField;

            /*0x798881c*/ CinemachinePositionComposer();
            /*0x7987950*/ void Reset();
            /*0x7987a28*/ void OnValidate();
            /*0x7987a70*/ Unity.Cinemachine.ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.get_Composition();
            /*0x7987a84*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            /*0x7987a98*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x7987aa4*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x7987ab0*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x7987ab8*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x7987ac0*/ bool get_IsValid();
            /*0x7987b50*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7987b58*/ bool get_BodyAppliesAfterAim();
            /*0x7987b60*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x7987b6c*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x7987b78*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7987c74*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7987cd8*/ float GetMaxDampTime();
            /*0x7987cf4*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7987ed0*/ UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, float orthoSize, float aspect);
            /*0x7987f24*/ UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect);
            /*0x7987fe0*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
        }

        class CinemachineRotateWithFollowTarget : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ float Damping;
            /*0x2c*/ UnityEngine.Quaternion m_PreviousReferenceOrientation;

            /*0x7988aa8*/ CinemachineRotateWithFollowTarget();
            /*0x79888bc*/ bool get_IsValid();
            /*0x798894c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7988954*/ float GetMaxDampTime();
            /*0x798895c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
        }

        class CinemachineRotationComposer : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition
        {
            /*0x28*/ Unity.Cinemachine.ScreenComposerSettings Composition;
            /*0x50*/ bool CenterOnActivate;
            /*0x54*/ UnityEngine.Vector3 TargetOffset;
            /*0x60*/ UnityEngine.Vector2 Damping;
            /*0x68*/ Unity.Cinemachine.LookaheadSettings Lookahead;
            /*0x78*/ UnityEngine.Vector3 <TrackedPoint>k__BackingField;
            /*0x84*/ UnityEngine.Vector3 m_CameraPosPrevFrame;
            /*0x90*/ UnityEngine.Vector3 m_LookAtPrevFrame;
            /*0x9c*/ UnityEngine.Vector2 m_ScreenOffsetPrevFrame;
            /*0xa4*/ UnityEngine.Quaternion m_CameraOrientationPrevFrame;
            /*0xb4*/ Unity.Cinemachine.PositionPredictor m_Predictor;
            /*0xe0*/ Unity.Cinemachine.CinemachineRotationComposer.FovCache m_Cache;

            /*0x7989df8*/ CinemachineRotationComposer();
            /*0x7988b00*/ void Reset();
            /*0x7988ba0*/ void OnValidate();
            /*0x7988bc4*/ bool get_IsValid();
            /*0x7988c54*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7988c5c*/ bool get_CameraLooksAtTarget();
            /*0x7988c64*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x7988c70*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x7988c7c*/ UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, float deltaTime);
            /*0x7988e38*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7988f44*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7988fa8*/ float GetMaxDampTime();
            /*0x7988fb8*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x798903c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7989abc*/ void RotateToScreenBounds(ref Unity.Cinemachine.CameraState state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, ref UnityEngine.Quaternion rigOrientation, float fov, float fovH, float deltaTime);
            /*0x7989ce8*/ bool ClampVerticalBounds(ref UnityEngine.Rect r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, float fov);
            /*0x7989dc8*/ Unity.Cinemachine.ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.get_Composition();
            /*0x7989de0*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.set_Composition(Unity.Cinemachine.ScreenComposerSettings value);

            struct FovCache
            {
                /*0x10*/ UnityEngine.Rect FovSoftGuideRect;
                /*0x20*/ UnityEngine.Rect FovHardGuideRect;
                /*0x30*/ float FovH;
                /*0x34*/ float Fov;
                /*0x38*/ float m_OrthoSizeOverDistance;
                /*0x3c*/ float m_Aspect;
                /*0x40*/ UnityEngine.Rect m_DeadZoneRect;
                /*0x50*/ UnityEngine.Rect m_HardLimitRect;

                static /*0x7989f18*/ UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, float fov, float fovH, float aspect);
                /*0x79897fc*/ void UpdateCache(Unity.Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, float targetDistance);
            }
        }

        class CinemachineSplineDolly : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.ISplineReferencer
        {
            /*0x28*/ Unity.Cinemachine.SplineSettings m_SplineSettings;
            /*0x48*/ UnityEngine.Vector3 SplineOffset;
            /*0x54*/ Unity.Cinemachine.CinemachineSplineDolly.RotationMode CameraRotation;
            /*0x58*/ Unity.Cinemachine.CinemachineSplineDolly.DampingSettings Damping;
            /*0x70*/ Unity.Cinemachine.SplineAutoDolly AutomaticDolly;
            /*0x80*/ float m_PreviousSplinePosition;
            /*0x84*/ UnityEngine.Quaternion m_PreviousRotation;
            /*0x94*/ UnityEngine.Vector3 m_PreviousPosition;
            /*0xa0*/ Unity.Cinemachine.CinemachineSplineRoll.RollCache m_RollCache;
            /*0xa8*/ float m_LegacyPosition;
            /*0xac*/ UnityEngine.Splines.PathIndexUnit m_LegacyUnits;
            /*0xb0*/ UnityEngine.Splines.SplineContainer m_LegacySpline;

            /*0x798afc0*/ CinemachineSplineDolly();
            /*0x798a328*/ void PerformLegacyUpgrade();
            /*0x798a3e0*/ ref Unity.Cinemachine.SplineSettings get_SplineSettings();
            /*0x798a3e8*/ UnityEngine.Splines.SplineContainer get_Spline();
            /*0x798a3f0*/ void set_Spline(UnityEngine.Splines.SplineContainer value);
            /*0x798a3f8*/ float get_CameraPosition();
            /*0x798a400*/ void set_CameraPosition(float value);
            /*0x798a408*/ UnityEngine.Splines.PathIndexUnit get_PositionUnits();
            /*0x798a410*/ void set_PositionUnits(UnityEngine.Splines.PathIndexUnit value);
            /*0x798a41c*/ void OnValidate();
            /*0x798a514*/ void Reset();
            /*0x798a59c*/ void OnEnable();
            /*0x798a660*/ void OnDisable();
            /*0x798a684*/ bool get_IsValid();
            /*0x798a704*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x798a70c*/ float GetMaxDampTime();
            /*0x798a744*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x798ada8*/ UnityEngine.Quaternion GetCameraRotationAtSplinePoint(UnityEngine.Quaternion splineOrientation, UnityEngine.Vector3 up, ref bool isDefault);

            enum RotationMode
            {
                Default = 0,
                Spline = 1,
                SplineNoRoll = 2,
                FollowTarget = 3,
                FollowTargetNoRoll = 4,
            }

            struct DampingSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.Vector3 Position;
                /*0x20*/ float Angular;
            }
        }

        class CinemachineSplineDollyLookAtTargets : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ UnityEngine.Splines.SplineData<Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item> Targets;

            /*0x798b5c8*/ CinemachineSplineDollyLookAtTargets();
            /*0x798b040*/ void Reset();
            /*0x798b124*/ bool get_IsValid();
            /*0x798b290*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x798b298*/ void MutateCameraState(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x798b170*/ bool GetGetSplineAndDolly(ref UnityEngine.Splines.SplineContainer spline, ref Unity.Cinemachine.CinemachineSplineDolly dolly);

            struct Item
            {
                /*0x10*/ UnityEngine.Transform LookAt;
                /*0x18*/ UnityEngine.Vector3 Offset;
                /*0x24*/ float Easing;

                /*0x798b538*/ UnityEngine.Vector3 get_WorldLookAt();
                /*0x798b6b8*/ void set_WorldLookAt(UnityEngine.Vector3 value);
            }

            struct LerpItem : UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item>
            {
                /*0x798b770*/ Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item Interpolate(Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item a, Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item b, float t);
            }
        }

        class CinemachineThirdPersonFollow : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance
        {
            /*0x28*/ UnityEngine.Vector3 Damping;
            /*0x34*/ UnityEngine.Vector3 ShoulderOffset;
            /*0x40*/ float VerticalArmLength;
            /*0x44*/ float CameraSide;
            /*0x48*/ float CameraDistance;
            /*0x50*/ Unity.Cinemachine.CinemachineThirdPersonFollow.ObstacleSettings AvoidObstacles;
            /*0x70*/ UnityEngine.Collider <CurrentObstacle>k__BackingField;
            /*0x78*/ UnityEngine.Vector3 m_PreviousFollowTargetPosition;
            /*0x84*/ UnityEngine.Vector3 m_DampingCorrection;
            /*0x90*/ float m_CamPosCollisionCorrection;

            static /*0x798c170*/ UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up);
            /*0x798c8b4*/ CinemachineThirdPersonFollow();
            /*0x798b880*/ UnityEngine.Collider get_CurrentObstacle();
            /*0x798b888*/ void set_CurrentObstacle(UnityEngine.Collider value);
            /*0x798b890*/ void OnValidate();
            /*0x798b8f4*/ void Reset();
            /*0x798b9b4*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x798bb2c*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x798bb38*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x798bb44*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x798bb4c*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x798bb54*/ bool get_IsValid();
            /*0x798bbe4*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x798bbec*/ float GetMaxDampTime();
            /*0x798bc2c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x798c09c*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x798bcb0*/ void PositionCamera(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x798c774*/ void GetRigPositions(ref UnityEngine.Vector3 root, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x798c30c*/ void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x798c3fc*/ UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection);

            struct ObstacleSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.LayerMask CollisionFilter;
                /*0x18*/ string IgnoreTag;
                /*0x20*/ float CameraRadius;
                /*0x24*/ float DampingIntoCollision;
                /*0x28*/ float DampingFromCollision;

                static /*0x798b944*/ Unity.Cinemachine.CinemachineThirdPersonFollow.ObstacleSettings get_Default();
            }
        }

        class BlendManager : Unity.Cinemachine.CameraBlendStack
        {
            /*0x28*/ Unity.Cinemachine.CinemachineBlend m_CurrentLiveCameras;
            /*0x30*/ System.Collections.Generic.HashSet<Unity.Cinemachine.ICinemachineCamera> m_PreviousLiveCameras;
            /*0x38*/ Unity.Cinemachine.ICinemachineCamera m_PreviousActiveCamera;
            /*0x40*/ bool m_WasBlending;

            static /*0x798ca70*/ Unity.Cinemachine.ICinemachineCamera DeepCamBFromBlend(Unity.Cinemachine.CinemachineBlend blend);
            static /*0x798da28*/ void <ProcessActiveCamera>g__CollectLiveCameras|21_0(Unity.Cinemachine.CinemachineBlend blend, ref System.Collections.Generic.HashSet<Unity.Cinemachine.ICinemachineCamera> cams);
            /*0x798db48*/ BlendManager();
            /*0x798c8f0*/ void OnEnable();
            /*0x798ca68*/ Unity.Cinemachine.ICinemachineCamera get_ActiveVirtualCamera();
            /*0x798cb78*/ Unity.Cinemachine.CinemachineBlend get_ActiveBlend();
            /*0x798cbbc*/ void set_ActiveBlend(Unity.Cinemachine.CinemachineBlend value);
            /*0x798ccd0*/ bool get_IsBlending();
            /*0x798cce8*/ string get_Description();
            /*0x798ce70*/ bool IsLiveInBlend(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x798cf24*/ bool IsLive(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x798cf40*/ Unity.Cinemachine.CameraState get_CameraState();
            /*0x798cf88*/ void ComputeCurrentBlend();
            /*0x798d338*/ void RefreshCurrentCameraState(UnityEngine.Vector3 up, float deltaTime);
            /*0x798d354*/ Unity.Cinemachine.ICinemachineCamera ProcessActiveCamera(Unity.Cinemachine.ICinemachineMixer mixer, UnityEngine.Vector3 up, float deltaTime);
        }

        interface ICameraOverrideStack
        {
            int SetCameraOverride(int overrideId, int priority, Unity.Cinemachine.ICinemachineCamera camA, Unity.Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime);
            /*0x3815ed0*/ void ReleaseCameraOverride(int overrideId);
            /*0x38159a4*/ UnityEngine.Vector3 get_DefaultWorldUp();
        }

        class CameraBlendStack : Unity.Cinemachine.ICameraOverrideStack
        {
            static float kEpsilon = 0.00009999999747378752;
            static /*0x0*/ UnityEngine.AnimationCurve s_DefaultLinearAnimationCurve;
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.CameraBlendStack.StackFrame> m_FrameStack;
            /*0x18*/ int m_NextFrameId;
            /*0x20*/ Unity.Cinemachine.CinemachineBlendDefinition.LookupBlendDelegate <LookupBlendDelegate>k__BackingField;

            static /*0x798ee98*/ CameraBlendStack();
            static /*0x798ecc8*/ bool <UpdateRootFrame>g__AdvanceBlend|18_0(Unity.Cinemachine.CinemachineBlend blend, float deltaTime);
            /*0x798dc30*/ CameraBlendStack();
            /*0x798dcb8*/ UnityEngine.Vector3 get_DefaultWorldUp();
            /*0x798dcfc*/ int SetCameraOverride(int overrideId, int priority, Unity.Cinemachine.ICinemachineCamera camA, Unity.Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime);
            /*0x798e158*/ void ReleaseCameraOverride(int overrideId);
            /*0x798c960*/ void OnEnable();
            /*0x798e224*/ void OnDisable();
            /*0x798e290*/ bool get_IsInitialized();
            /*0x798e2e0*/ Unity.Cinemachine.CinemachineBlendDefinition.LookupBlendDelegate get_LookupBlendDelegate();
            /*0x798e2e8*/ void set_LookupBlendDelegate(Unity.Cinemachine.CinemachineBlendDefinition.LookupBlendDelegate value);
            /*0x798e2f0*/ void ResetRootFrame();
            /*0x798e448*/ void UpdateRootFrame(Unity.Cinemachine.ICinemachineMixer context, Unity.Cinemachine.ICinemachineCamera activeCamera, UnityEngine.Vector3 up, float deltaTime);
            /*0x798cf94*/ void ProcessOverrideFrames(ref Unity.Cinemachine.CinemachineBlend outputBlend, int numTopLayersToExclude);
            /*0x798cbc0*/ void SetRootBlend(Unity.Cinemachine.CinemachineBlend blend);
            /*0x798edf0*/ float GetDeltaTimeOverride();
            /*0x798dfb4*/ int <SetCameraOverride>g__FindFrame|7_0(int withId, int priority);

            class StackFrame : Unity.Cinemachine.NestedBlendSource
            {
                /*0x130*/ int Id;
                /*0x134*/ int Priority;
                /*0x138*/ Unity.Cinemachine.CinemachineBlend Source;
                /*0x140*/ float DeltaTimeOverride;
                /*0x148*/ Unity.Cinemachine.CameraBlendStack.SnapshotBlendSource m_Snapshot;
                /*0x150*/ Unity.Cinemachine.ICinemachineCamera m_SnapshotSource;
                /*0x158*/ float m_SnapshotBlendWeight;

                /*0x798f07c*/ StackFrame();
                /*0x798f1d4*/ bool get_Active();
                /*0x798f30c*/ Unity.Cinemachine.ICinemachineCamera GetSnapshotIfAppropriate(Unity.Cinemachine.ICinemachineCamera cam, float weight);
            }

            class SnapshotBlendSource : Unity.Cinemachine.ICinemachineCamera
            {
                /*0x10*/ Unity.Cinemachine.CameraState m_State;
                /*0x120*/ string m_Name;
                /*0x128*/ float <RemainingTimeInBlend>k__BackingField;

                /*0x798f164*/ SnapshotBlendSource(Unity.Cinemachine.ICinemachineCamera source, float remainingTimeInBlend);
                /*0x798f65c*/ float get_RemainingTimeInBlend();
                /*0x798f664*/ void set_RemainingTimeInBlend(float value);
                /*0x798f66c*/ string get_Name();
                /*0x798f674*/ string get_Description();
                /*0x798f67c*/ Unity.Cinemachine.CameraState get_State();
                /*0x798f68c*/ bool get_IsValid();
                /*0x798f694*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
                /*0x798f69c*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
                /*0x798f6a0*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
                /*0x798f44c*/ void TakeSnapshot(Unity.Cinemachine.ICinemachineCamera source);
            }
        }

        struct CameraState
        {
            static /*0x0*/ UnityEngine.Vector3 kNoPoint;
            /*0x10*/ Unity.Cinemachine.LensSettings Lens;
            /*0x68*/ UnityEngine.Vector3 ReferenceUp;
            /*0x74*/ UnityEngine.Vector3 ReferenceLookAt;
            /*0x80*/ UnityEngine.Vector3 RawPosition;
            /*0x8c*/ UnityEngine.Quaternion RawOrientation;
            /*0x9c*/ UnityEngine.Quaternion RotationDampingBypass;
            /*0xac*/ float ShotQuality;
            /*0xb0*/ UnityEngine.Vector3 PositionCorrection;
            /*0xbc*/ UnityEngine.Quaternion OrientationCorrection;
            /*0xcc*/ Unity.Cinemachine.CameraState.BlendHints BlendHint;
            /*0xd0*/ Unity.Cinemachine.CameraState.CustomBlendableItems CustomBlendables;

            static /*0x799120c*/ CameraState();
            static /*0x798f6a4*/ Unity.Cinemachine.CameraState get_Default();
            static /*0x798feb4*/ Unity.Cinemachine.CameraState Lerp(ref Unity.Cinemachine.CameraState stateA, ref Unity.Cinemachine.CameraState stateB, float t);
            static /*0x7990e6c*/ float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t);
            static /*0x7990d60*/ UnityEngine.Vector3 ApplyPosBlendHint(UnityEngine.Vector3 posA, Unity.Cinemachine.CameraState.BlendHints hintA, UnityEngine.Vector3 posB, Unity.Cinemachine.CameraState.BlendHints hintB, UnityEngine.Vector3 original, UnityEngine.Vector3 blended);
            static /*0x7990da0*/ UnityEngine.Quaternion ApplyRotBlendHint(UnityEngine.Quaternion rotA, Unity.Cinemachine.CameraState.BlendHints hintA, UnityEngine.Quaternion rotB, Unity.Cinemachine.CameraState.BlendHints hintB, UnityEngine.Quaternion original, UnityEngine.Quaternion blended);
            static /*0x7990f60*/ UnityEngine.Vector3 InterpolatePosition(UnityEngine.Vector3 posA, UnityEngine.Vector3 pivotA, UnityEngine.Vector3 posB, UnityEngine.Vector3 pivotB, float t, Unity.Cinemachine.CameraState.BlendHints blendHint, UnityEngine.Vector3 up);
            /*0x798fa04*/ void AddCustomBlendable(Unity.Cinemachine.CameraState.CustomBlendableItems.Item b);

            enum BlendHints
            {
                Nothing = 0,
                SphericalPositionBlend = 1,
                CylindricalPositionBlend = 2,
                ScreenSpaceAimWhenTargetsDiffer = 4,
                InheritPosition = 8,
                IgnoreLookAtTarget = 16,
                FreezeWhenBlendingOut = 32,
                NoPosition = 65536,
                NoOrientation = 131072,
                NoTransform = 196608,
                NoLens = 262144,
            }

            struct CustomBlendableItems
            {
                /*0x10*/ Unity.Cinemachine.CameraState.CustomBlendableItems.Item m_Item0;
                /*0x20*/ Unity.Cinemachine.CameraState.CustomBlendableItems.Item m_Item1;
                /*0x30*/ Unity.Cinemachine.CameraState.CustomBlendableItems.Item m_Item2;
                /*0x40*/ Unity.Cinemachine.CameraState.CustomBlendableItems.Item m_Item3;
                /*0x50*/ System.Collections.Generic.List<Unity.Cinemachine.CameraState.CustomBlendableItems.Item> m_Overflow;
                /*0x58*/ int NumItems;

                struct Item
                {
                    /*0x10*/ UnityEngine.Object Custom;
                    /*0x18*/ float Weight;
                }
            }
        }

        class CameraStateExtensions
        {
            static /*0x7990de4*/ bool HasLookAt(Unity.Cinemachine.CameraState s);
            static /*0x7990e4c*/ UnityEngine.Vector3 GetCorrectedPosition(Unity.Cinemachine.CameraState s);
            static /*0x7991260*/ UnityEngine.Quaternion GetCorrectedOrientation(Unity.Cinemachine.CameraState s);
            static /*0x79912e4*/ UnityEngine.Vector3 GetFinalPosition(Unity.Cinemachine.CameraState s);
            static /*0x7991304*/ UnityEngine.Quaternion GetFinalOrientation(Unity.Cinemachine.CameraState s);
            static /*0x7991444*/ int GetNumCustomBlendables(Unity.Cinemachine.CameraState s);
            static /*0x798fdf4*/ Unity.Cinemachine.CameraState.CustomBlendableItems.Item GetCustomBlendable(Unity.Cinemachine.CameraState s, int index);
            static /*0x798fc58*/ int FindCustomBlendable(Unity.Cinemachine.CameraState s, UnityEngine.Object custom);
            static /*0x799144c*/ bool IsTargetOffscreen(Unity.Cinemachine.CameraState state);
        }

        struct CameraTarget
        {
            /*0x10*/ UnityEngine.Transform TrackingTarget;
            /*0x18*/ UnityEngine.Transform LookAtTarget;
            /*0x20*/ bool CustomLookAtTarget;
        }

        class CameraUpdateManager
        {
            static /*0x0*/ Unity.Cinemachine.VirtualCameraRegistry s_CameraRegistry;
            static /*0x8*/ int s_RoundRobinIndex;
            static /*0xc*/ int s_RoundRobinSubIndex;
            static /*0x10*/ object s_LastFixedUpdateContext;
            static /*0x18*/ float s_LastUpdateTime;
            static /*0x1c*/ int s_FixedFrameCount;
            static /*0x20*/ System.Collections.Generic.Dictionary<Unity.Cinemachine.CinemachineVirtualCameraBase, Unity.Cinemachine.CameraUpdateManager.UpdateStatus> s_UpdateStatus;
            static /*0x28*/ Unity.Cinemachine.CameraUpdateManager.UpdateFilter s_CurrentUpdateFilter;

            static /*0x79927bc*/ CameraUpdateManager();
            static /*0x799174c*/ void InitializeModule();
            static /*0x79917ec*/ int get_VirtualCameraCount();
            static /*0x7991850*/ Unity.Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(int index);
            static /*0x79918bc*/ void AddActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x7991928*/ void RemoveActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x7991994*/ void CameraDestroyed(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x7991aa0*/ void CameraEnabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x7991b0c*/ void CameraDisabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x7991b78*/ void ForgetContext(object context);
            static /*0x7991c08*/ void UpdateAllActiveVirtualCameras(uint channelMask, UnityEngine.Vector3 worldUp, float deltaTime, object context);
            static /*0x79921d8*/ void UpdateVirtualCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Vector3 worldUp, float deltaTime);
            static /*0x79925a4*/ UnityEngine.Transform GetUpdateTarget(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x79926f0*/ Unity.Cinemachine.UpdateTracker.UpdateClock GetVcamUpdateStatus(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);

            class UpdateStatus
            {
                /*0x10*/ int lastUpdateFrame;
                /*0x14*/ int lastUpdateFixedFrame;
                /*0x18*/ Unity.Cinemachine.UpdateTracker.UpdateClock lastUpdateMode;

                /*0x79926e8*/ UpdateStatus();
            }

            enum UpdateFilter
            {
                Fixed = 1,
                Late = 2,
                Smart = 8,
                SmartFixed = 9,
                SmartLate = 10,
            }
        }

        class CinemachineBlend
        {
            /*0x10*/ Unity.Cinemachine.ICinemachineCamera CamA;
            /*0x18*/ Unity.Cinemachine.ICinemachineCamera CamB;
            /*0x20*/ UnityEngine.AnimationCurve BlendCurve;
            /*0x28*/ float TimeInBlend;
            /*0x30*/ Unity.Cinemachine.CinemachineBlend.IBlender <CustomBlender>k__BackingField;
            /*0x38*/ float Duration;

            /*0x798f15c*/ CinemachineBlend();
            /*0x799284c*/ float get_BlendWeight();
            /*0x7992904*/ Unity.Cinemachine.CinemachineBlend.IBlender get_CustomBlender();
            /*0x799290c*/ void set_CustomBlender(Unity.Cinemachine.CinemachineBlend.IBlender value);
            /*0x798f1ec*/ bool get_IsValid();
            /*0x79928d4*/ bool get_IsComplete();
            /*0x7992914*/ string get_Description();
            /*0x7992be8*/ bool Uses(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x7992ce4*/ void CopyFrom(Unity.Cinemachine.CinemachineBlend src);
            /*0x7992d50*/ void ClearBlend();
            /*0x7992d90*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7992fbc*/ Unity.Cinemachine.CameraState get_State();

            interface IBlender
            {
                Unity.Cinemachine.CameraState GetIntermediateState(Unity.Cinemachine.ICinemachineCamera CamA, Unity.Cinemachine.ICinemachineCamera CamB, float t);
            }
        }

        struct CinemachineBlendDefinition
        {
            static /*0x0*/ UnityEngine.AnimationCurve[] s_StandardCurves;
            /*0x10*/ Unity.Cinemachine.CinemachineBlendDefinition.Styles Style;
            /*0x14*/ float Time;
            /*0x18*/ UnityEngine.AnimationCurve CustomCurve;

            /*0x799343c*/ CinemachineBlendDefinition(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float time);
            /*0x7993424*/ float get_BlendTime();
            /*0x7993450*/ void CreateStandardCurves();
            /*0x79939ac*/ UnityEngine.AnimationCurve get_BlendCurve();

            class LookupBlendDelegate : System.MulticastDelegate
            {
                /*0x7993a74*/ LookupBlendDelegate(object object, nint method);
                /*0x7993b80*/ Unity.Cinemachine.CinemachineBlendDefinition Invoke(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming);
                /*0x7993b94*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming, System.AsyncCallback callback, object object);
                /*0x7993bbc*/ Unity.Cinemachine.CinemachineBlendDefinition EndInvoke(System.IAsyncResult result);
            }

            enum Styles
            {
                Cut = 0,
                EaseInOut = 1,
                EaseIn = 2,
                EaseOut = 3,
                HardIn = 4,
                HardOut = 5,
                Linear = 6,
                Custom = 7,
            }
        }

        class NestedBlendSource : Unity.Cinemachine.ICinemachineCamera
        {
            /*0x10*/ string m_Name;
            /*0x18*/ Unity.Cinemachine.CinemachineBlend <Blend>k__BackingField;
            /*0x20*/ Unity.Cinemachine.CameraState <State>k__BackingField;

            /*0x798f1a4*/ NestedBlendSource(Unity.Cinemachine.CinemachineBlend blend);
            /*0x7993be8*/ Unity.Cinemachine.CinemachineBlend get_Blend();
            /*0x7993bf0*/ void set_Blend(Unity.Cinemachine.CinemachineBlend value);
            /*0x7993bf8*/ string get_Name();
            /*0x7993d14*/ string get_Description();
            /*0x7993d6c*/ Unity.Cinemachine.CameraState get_State();
            /*0x7993d7c*/ void set_State(Unity.Cinemachine.CameraState value);
            /*0x7993da0*/ bool get_IsValid();
            /*0x7993db0*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            /*0x7993db8*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7993e20*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
        }

        class CinemachineBlenderSettings : UnityEngine.ScriptableObject
        {
            static string kBlendFromAnyCameraLabel = "**ANY CAMERA**";
            /*0x18*/ Unity.Cinemachine.CinemachineBlenderSettings.CustomBlend[] CustomBlends;

            static /*0x7994048*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend, Unity.Cinemachine.CinemachineBlenderSettings customBlends, UnityEngine.Object owner);
            /*0x7994298*/ CinemachineBlenderSettings();
            /*0x7993e24*/ Unity.Cinemachine.CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend);

            struct CustomBlend
            {
                /*0x10*/ string From;
                /*0x18*/ string To;
                /*0x20*/ Unity.Cinemachine.CinemachineBlendDefinition Blend;
            }
        }

        class CinemachineCameraManagerBase : Unity.Cinemachine.CinemachineVirtualCameraBase, Unity.Cinemachine.ICinemachineMixer, Unity.Cinemachine.ICinemachineCamera
        {
            /*0xa0*/ Unity.Cinemachine.CinemachineCameraManagerBase.DefaultTargetSettings DefaultTarget;
            /*0xc0*/ Unity.Cinemachine.CinemachineBlendDefinition DefaultBlend;
            /*0xd0*/ Unity.Cinemachine.CinemachineBlenderSettings CustomBlends;
            /*0xd8*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> m_ChildCameras;
            /*0xe0*/ int m_ChildCountCache;
            /*0xe8*/ Unity.Cinemachine.BlendManager m_BlendManager;
            /*0xf0*/ Unity.Cinemachine.CameraState m_State;
            /*0x200*/ Unity.Cinemachine.ICinemachineCamera m_TransitioningFrom;

            /*0x7995afc*/ CinemachineCameraManagerBase();
            /*0x79942a0*/ void Reset();
            /*0x7994314*/ void OnEnable();
            /*0x799463c*/ void OnDisable();
            /*0x79946c4*/ string get_Description();
            /*0x79946e0*/ Unity.Cinemachine.CameraState get_State();
            /*0x79946f0*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera cam, bool dominantChildOnly);
            /*0x799470c*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> get_ChildCameras();
            /*0x7994730*/ bool get_PreviousStateIsValid();
            /*0x7994738*/ void set_PreviousStateIsValid(bool value);
            /*0x79947e0*/ bool get_IsBlending();
            /*0x79947fc*/ Unity.Cinemachine.CinemachineBlend get_ActiveBlend();
            /*0x799483c*/ void set_ActiveBlend(Unity.Cinemachine.CinemachineBlend value);
            /*0x7994858*/ Unity.Cinemachine.ICinemachineCamera get_LiveChild();
            /*0x7994898*/ UnityEngine.Transform get_LookAt();
            /*0x79949ac*/ void set_LookAt(UnityEngine.Transform value);
            /*0x79949c0*/ UnityEngine.Transform get_Follow();
            /*0x7994ac0*/ void set_Follow(UnityEngine.Transform value);
            /*0x7994ad0*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79951c0*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming);
            Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79951dc*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79952e0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79954e8*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79942e4*/ void InvalidateCameraCache();
            /*0x7995730*/ bool UpdateCameraCache();
            /*0x7995928*/ void OnTransformChildrenChanged();
            /*0x79950b8*/ void SetLiveChild(Unity.Cinemachine.ICinemachineCamera activeCamera, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7995018*/ void ResetLiveChild();
            /*0x7995134*/ void FinalizeCameraState(float deltaTime);

            struct DefaultTargetSettings
            {
                /*0x10*/ bool Enabled;
                /*0x18*/ Unity.Cinemachine.CameraTarget Target;
            }
        }

        class CinemachineComponentBase : UnityEngine.MonoBehaviour
        {
            static float Epsilon = 0.00009999999747378752;
            /*0x20*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_VcamOwner;

            /*0x79966e0*/ CinemachineComponentBase();
            /*0x7995c2c*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera();
            /*0x7995d60*/ void OnEnable();
            /*0x7995e18*/ void OnDisable();
            /*0x7995ed0*/ UnityEngine.Transform get_FollowTarget();
            /*0x7995f78*/ UnityEngine.Transform get_LookAtTarget();
            /*0x7996020*/ Unity.Cinemachine.ICinemachineTargetGroup get_FollowTargetAsGroup();
            /*0x79960a8*/ UnityEngine.Vector3 get_FollowTargetPosition();
            /*0x79961ec*/ UnityEngine.Quaternion get_FollowTargetRotation();
            /*0x799632c*/ Unity.Cinemachine.ICinemachineTargetGroup get_LookAtTargetAsGroup();
            /*0x7996348*/ UnityEngine.Vector3 get_LookAtTargetPosition();
            /*0x799648c*/ UnityEngine.Quaternion get_LookAtTargetRotation();
            /*0x79965cc*/ Unity.Cinemachine.CameraState get_VcamState();
            /*0x3813ffc*/ bool get_IsValid();
            /*0x79966b4*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x3814574*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79966b8*/ bool get_BodyAppliesAfterAim();
            void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79966c0*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79966c8*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79966cc*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79966d0*/ float GetMaxDampTime();
            /*0x79966d8*/ bool get_CameraLooksAtTarget();
        }

        class Documentation
        {
            static string BaseURL = "https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/";
        }

        class CinemachineCore
        {
            static int kStreamingVersion = 20241001;
            static string kPackageRoot = "Packages/com.unity.cinemachine";
            static /*0x0*/ float CurrentUnscaledTimeTimeOverride;
            static /*0x4*/ bool UnitTestMode;
            static /*0x8*/ Unity.Cinemachine.CinemachineCore.AxisInputDelegate GetInputAxis;
            static /*0x10*/ float UniformDeltaTimeOverride;
            static /*0x14*/ float CurrentTimeOverride;
            static /*0x18*/ Unity.Cinemachine.CinemachineCore.GetBlendOverrideDelegate GetBlendOverride;
            static /*0x20*/ Unity.Cinemachine.CinemachineCore.GetCustomBlenderDelegate GetCustomBlender;
            static /*0x28*/ Unity.Cinemachine.CinemachineCore.BrainEvent CameraUpdatedEvent;
            static /*0x30*/ Unity.Cinemachine.ICinemachineCamera.ActivationEvent CameraActivatedEvent;
            static /*0x38*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraDeactivatedEvent;
            static /*0x40*/ Unity.Cinemachine.CinemachineCore.BlendEvent BlendCreatedEvent;
            static /*0x48*/ Unity.Cinemachine.CinemachineCore.CameraEvent BlendFinishedEvent;
            static /*0x50*/ Unity.Cinemachine.ICinemachineCamera s_SoloCamera;

            static /*0x7997018*/ CinemachineCore();
            static /*0x79966e8*/ float get_CurrentUnscaledTime();
            static /*0x7996770*/ UnityEngine.Color SoloGUIColor();
            static /*0x799678c*/ float get_DeltaTime();
            static /*0x7992040*/ float get_CurrentTime();
            static /*0x7996814*/ int get_VirtualCameraCount();
            static /*0x7996860*/ Unity.Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(int index);
            static /*0x79968b4*/ Unity.Cinemachine.ICinemachineCamera get_SoloCamera();
            static /*0x799690c*/ void set_SoloCamera(Unity.Cinemachine.ICinemachineCamera value);
            static /*0x79920c8*/ bool IsLive(Unity.Cinemachine.ICinemachineCamera vcam);
            static /*0x7996ae0*/ bool IsLiveInBlend(Unity.Cinemachine.ICinemachineCamera vcam);
            static /*0x7996bec*/ Unity.Cinemachine.CinemachineBrain FindPotentialTargetBrain(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x7996e0c*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            static /*0x7996ef4*/ void ResetCameraState();

            enum Stage
            {
                Body = 0,
                Aim = 1,
                Noise = 2,
                Finalize = 3,
            }

            enum BlendHints
            {
                SphericalPosition = 1,
                CylindricalPosition = 2,
                ScreenSpaceAimWhenTargetsDiffer = 4,
                InheritPosition = 8,
                IgnoreTarget = 16,
                FreezeWhenBlendingOut = 32,
            }

            class AxisInputDelegate : System.MulticastDelegate
            {
                /*0x7997214*/ AxisInputDelegate(object object, nint method);
                /*0x79973e4*/ float Invoke(string axisName);
                /*0x79973f8*/ System.IAsyncResult BeginInvoke(string axisName, System.AsyncCallback callback, object object);
                /*0x7997418*/ float EndInvoke(System.IAsyncResult result);
            }

            class GetBlendOverrideDelegate : System.MulticastDelegate
            {
                /*0x7997440*/ GetBlendOverrideDelegate(object object, nint method);
                /*0x799754c*/ Unity.Cinemachine.CinemachineBlendDefinition Invoke(Unity.Cinemachine.ICinemachineCamera fromVcam, Unity.Cinemachine.ICinemachineCamera toVcam, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.Object owner);
                /*0x7997560*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.ICinemachineCamera fromVcam, Unity.Cinemachine.ICinemachineCamera toVcam, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.Object owner, System.AsyncCallback callback, object object);
                /*0x799760c*/ Unity.Cinemachine.CinemachineBlendDefinition EndInvoke(System.IAsyncResult result);
            }

            class GetCustomBlenderDelegate : System.MulticastDelegate
            {
                /*0x7997638*/ GetCustomBlenderDelegate(object object, nint method);
                /*0x7997744*/ Unity.Cinemachine.CinemachineBlend.IBlender Invoke(Unity.Cinemachine.ICinemachineCamera fromCam, Unity.Cinemachine.ICinemachineCamera toCam);
                /*0x7997758*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.ICinemachineCamera fromCam, Unity.Cinemachine.ICinemachineCamera toCam, System.AsyncCallback callback, object object);
                /*0x7997780*/ Unity.Cinemachine.CinemachineBlend.IBlender EndInvoke(System.IAsyncResult result);
            }

            class CameraEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.ICinemachineMixer, Unity.Cinemachine.ICinemachineCamera>
            {
                /*0x7997354*/ CameraEvent();
            }

            class BrainEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.CinemachineBrain>
            {
                /*0x79972c4*/ BrainEvent();
            }

            struct BlendEventParams
            {
                /*0x10*/ Unity.Cinemachine.ICinemachineMixer Origin;
                /*0x18*/ Unity.Cinemachine.CinemachineBlend Blend;
            }

            class BlendEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.CinemachineCore.BlendEventParams>
            {
                /*0x799739c*/ BlendEvent();
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineCore.<> <>9;

                static /*0x799778c*/ <>c();
                /*0x79977f4*/ <>c();
                /*0x79977fc*/ float <.cctor>b__42_0(string <p0>);
            }
        }

        class CinemachineExtension : UnityEngine.MonoBehaviour
        {
            static float Epsilon = 0.00009999999747378752;
            /*0x20*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_VcamOwner;
            /*0x28*/ System.Collections.Generic.Dictionary<Unity.Cinemachine.CinemachineVirtualCameraBase, Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase> m_ExtraState;

            /*0x7997b30*/ CinemachineExtension();
            /*0x7997804*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_ComponentOwner();
            /*0x79978a0*/ void Awake();
            /*0x79978b0*/ void OnDestroy();
            /*0x79978c0*/ void OnEnable();
            /*0x79978c4*/ void EnsureStarted();
            /*0x79978d4*/ void ConnectToVcam(bool connect);
            /*0x7997b08*/ void PrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7997b0c*/ void InvokePostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7997b18*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7997b1c*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7997b20*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7997b28*/ float GetMaxDampTime();
            /*0x3910ae8*/ T GetExtraState<T>(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x3816710*/ void GetAllExtraStates<T>(System.Collections.Generic.List<T> list);

            class VcamExtraStateBase
            {
                /*0x10*/ Unity.Cinemachine.CinemachineVirtualCameraBase Vcam;

                /*0x7997b38*/ VcamExtraStateBase();
            }
        }

        class InputAxisNamePropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997b40*/ InputAxisNamePropertyAttribute();
        }

        class HideFoldoutAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997b48*/ HideFoldoutAttribute();
        }

        class HideIfNoComponentAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ System.Type ComponentType;

            /*0x7997b50*/ HideIfNoComponentAttribute(System.Type type);
        }

        class FoldoutWithEnabledButtonAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ string EnabledPropertyName;

            /*0x7997b80*/ FoldoutWithEnabledButtonAttribute(string enabledProperty);
        }

        class EnabledPropertyAttribute : Unity.Cinemachine.FoldoutWithEnabledButtonAttribute
        {
            /*0x20*/ string ToggleDisabledText;

            /*0x7997bb0*/ EnabledPropertyAttribute(string enabledProperty, string toggleText);
        }

        class RangeSliderAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ float Min;
            /*0x1c*/ float Max;

            /*0x7997bf4*/ RangeSliderAttribute(float min, float max);
        }

        class MinMaxRangeSliderAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ float Min;
            /*0x1c*/ float Max;

            /*0x7997c20*/ MinMaxRangeSliderAttribute(float min, float max);
        }

        class LensSettingsHideModeOverridePropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997c4c*/ LensSettingsHideModeOverridePropertyAttribute();
        }

        class SensorSizePropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997c54*/ SensorSizePropertyAttribute();
        }

        class TagFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997c5c*/ TagFieldAttribute();
        }

        class CinemachineEmbeddedAssetPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x15*/ bool WarnIfNull;

            /*0x7997c64*/ CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull);
        }

        class Vector2AsRangeAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997c8c*/ Vector2AsRangeAttribute();
        }

        class DelayedVectorAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997c94*/ DelayedVectorAttribute();
        }

        class CameraPipelineAttribute : System.Attribute
        {
            /*0x10*/ Unity.Cinemachine.CinemachineCore.Stage <Stage>k__BackingField;

            /*0x7997cac*/ CameraPipelineAttribute(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x7997c9c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7997ca4*/ void set_Stage(Unity.Cinemachine.CinemachineCore.Stage value);
        }

        class RequiredTargetAttribute : System.Attribute
        {
            /*0x10*/ Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets <RequiredTarget>k__BackingField;

            /*0x7997ce4*/ RequiredTargetAttribute(Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets requiredTarget);
            /*0x7997cd4*/ Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets get_RequiredTarget();
            /*0x7997cdc*/ void set_RequiredTarget(Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets value);

            enum RequiredTargets
            {
                None = 0,
                Tracking = 1,
                LookAt = 2,
                GroupLookAt = 3,
            }
        }

        class ChildCameraPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997d0c*/ ChildCameraPropertyAttribute();
        }

        class EmbeddedBlenderSettingsPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7997d14*/ EmbeddedBlenderSettingsPropertyAttribute();
        }

        class CinemachineVirtualCameraBase : UnityEngine.MonoBehaviour, Unity.Cinemachine.ICinemachineCamera
        {
            /*0x20*/ Unity.Cinemachine.PrioritySettings Priority;
            /*0x28*/ Unity.Cinemachine.OutputChannels OutputChannel;
            /*0x2c*/ int ActivationId;
            /*0x30*/ int m_QueuePriority;
            /*0x34*/ float FollowTargetAttachment;
            /*0x38*/ float LookAtTargetAttachment;
            /*0x3c*/ Unity.Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode StandbyUpdate;
            /*0x40*/ string m_CachedName;
            /*0x48*/ bool m_WasStarted;
            /*0x49*/ bool m_ChildStatusUpdated;
            /*0x50*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_ParentVcam;
            /*0x58*/ UnityEngine.Transform m_CachedFollowTarget;
            /*0x60*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_CachedFollowTargetVcam;
            /*0x68*/ Unity.Cinemachine.ICinemachineTargetGroup m_CachedFollowTargetGroup;
            /*0x70*/ UnityEngine.Transform m_CachedLookAtTarget;
            /*0x78*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_CachedLookAtTargetVcam;
            /*0x80*/ Unity.Cinemachine.ICinemachineTargetGroup m_CachedLookAtTargetGroup;
            /*0x88*/ int m_StreamingVersion;
            /*0x8c*/ int m_LegacyPriority;
            /*0x90*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineExtension> <Extensions>k__BackingField;
            /*0x98*/ bool <PreviousStateIsValid>k__BackingField;
            /*0x99*/ bool <FollowTargetChanged>k__BackingField;
            /*0x9a*/ bool <LookAtTargetChanged>k__BackingField;

            /*0x7995c0c*/ CinemachineVirtualCameraBase();
            /*0x7997d1c*/ bool get_IsDprecated();
            /*0x7997d24*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x7997d60*/ float GetMaxDampTime();
            /*0x7997e10*/ float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime);
            /*0x7997f10*/ UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime);
            /*0x799818c*/ UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, float dampTime, float deltaTime);
            /*0x7998344*/ float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime);
            /*0x79983dc*/ UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime);
            /*0x79984d0*/ UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, float dampTime, float deltaTime);
            /*0x7997984*/ void AddExtension(Unity.Cinemachine.CinemachineExtension extension);
            /*0x7997aa8*/ void RemoveExtension(Unity.Cinemachine.CinemachineExtension extension);
            /*0x7998504*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineExtension> get_Extensions();
            /*0x799850c*/ void set_Extensions(System.Collections.Generic.List<Unity.Cinemachine.CinemachineExtension> value);
            /*0x7995958*/ void InvokePostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState newState, float deltaTime);
            /*0x799859c*/ void InvokePrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState newState, float deltaTime);
            /*0x79955bc*/ bool InvokeOnTransitionInExtensions(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x799873c*/ string get_Name();
            /*0x7998824*/ string get_Description();
            /*0x79987bc*/ bool get_IsValid();
            Unity.Cinemachine.CameraState get_State();
            /*0x7998514*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            /*0x38148bc*/ UnityEngine.Transform get_LookAt();
            /*0x3816710*/ void set_LookAt(UnityEngine.Transform value);
            /*0x38148bc*/ UnityEngine.Transform get_Follow();
            /*0x3816710*/ void set_Follow(UnityEngine.Transform value);
            /*0x7998938*/ bool get_PreviousStateIsValid();
            /*0x7998940*/ void set_PreviousStateIsValid(bool value);
            /*0x7995034*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x799894c*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x7995574*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x799897c*/ void EnsureStarted();
            /*0x7998a58*/ void OnTransformParentChanged();
            /*0x7998b90*/ void OnDestroy();
            /*0x7998be4*/ void Start();
            /*0x79943cc*/ void OnEnable();
            /*0x7994668*/ void OnDisable();
            /*0x7998c98*/ void Update();
            /*0x7998864*/ void UpdateStatusAsChild();
            /*0x79948c4*/ UnityEngine.Transform ResolveLookAt(UnityEngine.Transform localLookAt);
            /*0x79949d8*/ UnityEngine.Transform ResolveFollow(UnityEngine.Transform localFollow);
            /*0x7998ac4*/ void UpdateVcamPoolStatus();
            /*0x7998cd0*/ void MoveToTopOfPrioritySubqueue();
            /*0x7998cd4*/ void Prioritize();
            /*0x79952d4*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7998cd8*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7995400*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7998e0c*/ Unity.Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp, ref Unity.Cinemachine.LensSettings lens);
            /*0x7998c30*/ void InvalidateCachedTargets();
            /*0x79990d4*/ bool get_FollowTargetChanged();
            /*0x79990dc*/ void set_FollowTargetChanged(bool value);
            /*0x79990e8*/ bool get_LookAtTargetChanged();
            /*0x79990f0*/ void set_LookAtTargetChanged(bool value);
            /*0x7994dc4*/ void UpdateTargetCache();
            /*0x79990fc*/ Unity.Cinemachine.ICinemachineTargetGroup get_FollowTargetAsGroup();
            /*0x7999104*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_FollowTargetAsVcam();
            /*0x799910c*/ Unity.Cinemachine.ICinemachineTargetGroup get_LookAtTargetAsGroup();
            /*0x7999114*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_LookAtTargetAsVcam();
            /*0x799911c*/ Unity.Cinemachine.CinemachineComponentBase GetCinemachineComponent(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x7999124*/ bool get_IsLive();
            /*0x7999178*/ bool IsParticipatingInBlend();
            /*0x7999320*/ void CancelDamping(bool updateNow);

            enum StandbyUpdateMode
            {
                Never = 0,
                Always = 1,
                RoundRobin = 2,
            }
        }

        class ConfinerOven
        {
            static long k_FloatToIntScaler = 100000;
            static float k_IntToFloatScaler = 0.000009999999747378752;
            static float k_MinStepSize = 0.0005000000237487257;
            static int k_MiterLimit = 2;
            static float k_MaxComputationTimeForFullSkeletonBakeInSeconds = 5;
            /*0x10*/ float m_MinFrustumHeightWithBones;
            /*0x14*/ float m_SkeletonPadding;
            /*0x18*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> m_OriginalPolygon;
            /*0x20*/ Unity.Cinemachine.Point64 m_MidPoint;
            /*0x30*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> m_Skeleton;
            /*0x38*/ UnityEngine.Rect m_PolygonRect;
            /*0x48*/ Unity.Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;
            /*0x54*/ Unity.Cinemachine.ConfinerOven.BakingState <State>k__BackingField;
            /*0x58*/ float bakeProgress;
            /*0x60*/ Unity.Cinemachine.ConfinerOven.BakingStateCache m_Cache;

            static /*0x799a05c*/ UnityEngine.Rect <Initialize>g__GetPolygonBoundingBox|25_0(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> polygons);
            static /*0x799a1c4*/ Unity.Cinemachine.Point64 <Initialize>g__MidPointOfIntRect|25_1(Unity.Cinemachine.Rect64 bounds);
            /*0x799945c*/ ConfinerOven(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> inputPath, ref float aspectRatio, float maxFrustumHeight, float skeletonPadding);
            /*0x7999d00*/ Unity.Cinemachine.ConfinerOven.BakedSolution GetBakedSolution(float frustumHeight);
            /*0x799a04c*/ Unity.Cinemachine.ConfinerOven.BakingState get_State();
            /*0x799a054*/ void set_State(Unity.Cinemachine.ConfinerOven.BakingState value);
            /*0x7999548*/ void Initialize(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> inputPath, ref float aspectRatio, float maxFrustumHeight, float skeletonPadding);
            /*0x799a214*/ void BakeConfiner(float maxComputationTimePerFrameInSeconds);
            /*0x799a7cc*/ void <BakeConfiner>g__ComputeSkeleton|26_0(ref System.Collections.Generic.List<Unity.Cinemachine.ConfinerOven.PolygonSolution> solutions);

            class BakedSolution
            {
                static double k_ClipperEpsilon = 1000;
                /*0x10*/ float m_FrustumSizeIntSpace;
                /*0x14*/ Unity.Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;
                /*0x20*/ bool m_HasBones;
                /*0x28*/ double m_SqrPolygonDiagonal;
                /*0x30*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> m_OriginalPolygon;
                /*0x38*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> m_Solution;

                static /*0x799b300*/ int FindIntersection(ref Unity.Cinemachine.Point64 p1, ref Unity.Cinemachine.Point64 p2, ref Unity.Cinemachine.Point64 p3, ref Unity.Cinemachine.Point64 p4);
                static /*0x799afd4*/ Unity.Cinemachine.Point64 <ConfinePoint>g__IntPointLerp|9_0(Unity.Cinemachine.Point64 a, Unity.Cinemachine.Point64 b, float lerp);
                static /*0x799af6c*/ float <ConfinePoint>g__ClosestPointOnSegment|9_2(Unity.Cinemachine.Point64 point, Unity.Cinemachine.Point64 s0, Unity.Cinemachine.Point64 s1);
                static /*0x799b460*/ double <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(Unity.Cinemachine.Point64 point1, Unity.Cinemachine.Point64 point2);
                /*0x7999f80*/ BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, UnityEngine.Rect polygonBounds, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> originalPolygon, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solution);
                /*0x799ab20*/ bool IsValid();
                /*0x799ab30*/ UnityEngine.Vector2 ConfinePoint(ref UnityEngine.Vector2 pointToConfine);
                /*0x799ae7c*/ bool <ConfinePoint>g__IsInsideOriginal|9_1(Unity.Cinemachine.Point64 point);
                /*0x799b1a4*/ bool <ConfinePoint>g__DoesIntersectOriginal|9_3(Unity.Cinemachine.Point64 l1, Unity.Cinemachine.Point64 l2);
            }

            struct AspectStretcher
            {
                /*0x10*/ float <Aspect>k__BackingField;
                /*0x14*/ float m_InverseAspect;
                /*0x18*/ float m_CenterX;

                /*0x7999534*/ AspectStretcher(float aspect, float centerX);
                /*0x799b480*/ float get_Aspect();
                /*0x799a1b0*/ UnityEngine.Vector2 Stretch(UnityEngine.Vector2 p);
                /*0x799b2e8*/ UnityEngine.Vector2 Unstretch(UnityEngine.Vector2 p);
            }

            struct PolygonSolution
            {
                /*0x10*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> polygons;
                /*0x18*/ float frustumHeight;

                /*0x799a6bc*/ bool StateChanged(ref System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
                /*0x799a7bc*/ bool get_IsNull();
            }

            enum BakingState
            {
                BAKING = 0,
                BAKED = 1,
                TIMEOUT = 2,
            }

            struct BakingStateCache
            {
                /*0x10*/ Unity.Cinemachine.ClipperOffset offsetter;
                /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.ConfinerOven.PolygonSolution> solutions;
                /*0x20*/ Unity.Cinemachine.ConfinerOven.PolygonSolution rightCandidate;
                /*0x30*/ Unity.Cinemachine.ConfinerOven.PolygonSolution leftCandidate;
                /*0x40*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> userSetMaxCandidate;
                /*0x48*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> theoreticalMaxCandidate;
                /*0x50*/ float stepSize;
                /*0x54*/ float maxFrustumHeight;
                /*0x58*/ float userSetMaxFrustumHeight;
                /*0x5c*/ float theoreticalMaxFrustumHeight;
                /*0x60*/ float currentFrustumHeight;
                /*0x64*/ float bakeTime;
            }
        }

        class GaussianWindow1d<T>
        {
            /*0x0*/ T[] m_Data;
            /*0x0*/ float[] m_Kernel;
            /*0x0*/ int m_CurrentPos;
            /*0x0*/ float <Sigma>k__BackingField;

            GaussianWindow1d(float sigma, int maxKernelRadius);
            /*0x38151b8*/ float get_Sigma();
            /*0x3816f24*/ void set_Sigma(float value);
            /*0x3814574*/ int get_KernelSize();
            void GenerateKernel(float sigma, int maxKernelRadius);
            /*0x3910ae8*/ T Compute(int windowPos);
            /*0x38159dc*/ void Reset();
            /*0x3813ffc*/ bool IsEmpty();
            /*0x3910ae8*/ void AddValue(T v);
            /*0x3910ae8*/ T Filter(T v);
            /*0x3910ae8*/ T Value();
            /*0x3814574*/ int get_BufferLength();
            /*0x3910ae8*/ void SetBufferValue(int index, T value);
            /*0x3910ae8*/ T GetBufferValue(int index);
        }

        class GaussianWindow1D_Vector3 : Unity.Cinemachine.GaussianWindow1d<UnityEngine.Vector3>
        {
            /*0x799b488*/ GaussianWindow1D_Vector3(float sigma, int maxKernelRadius);
            /*0x799b4f0*/ UnityEngine.Vector3 Compute(int windowPos);
        }

        class GaussianWindow1D_Quaternion : Unity.Cinemachine.GaussianWindow1d<UnityEngine.Quaternion>
        {
            /*0x799b648*/ GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius);
            /*0x799b6b0*/ UnityEngine.Quaternion Compute(int windowPos);
        }

        class GaussianWindow1D_CameraRotation : Unity.Cinemachine.GaussianWindow1d<UnityEngine.Vector2>
        {
            /*0x799ba38*/ GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius);
            /*0x799baa0*/ UnityEngine.Vector2 Compute(int windowPos);
        }

        interface ICinemachineCamera
        {
            /*0x38148bc*/ string get_Name();
            /*0x38148bc*/ string get_Description();
            Unity.Cinemachine.CameraState get_State();
            /*0x3813ffc*/ bool get_IsValid();
            /*0x38148bc*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);

            struct ActivationEventParams
            {
                /*0x10*/ Unity.Cinemachine.ICinemachineMixer Origin;
                /*0x18*/ Unity.Cinemachine.ICinemachineCamera OutgoingCamera;
                /*0x20*/ Unity.Cinemachine.ICinemachineCamera IncomingCamera;
                /*0x28*/ bool IsCut;
                /*0x2c*/ UnityEngine.Vector3 WorldUp;
                /*0x38*/ float DeltaTime;
            }

            class ActivationEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.ICinemachineCamera.ActivationEventParams>
            {
                /*0x799730c*/ ActivationEvent();
            }
        }

        interface ICinemachineMixer : Unity.Cinemachine.ICinemachineCamera
        {
            bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera child, bool dominantChildOnly);
        }

        interface IInputAxisOwner
        {
            /*0x3816710*/ void GetInputAxes(System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> axes);

            struct AxisDescriptor
            {
                /*0x10*/ Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.AxisGetter DrivenAxis;
                /*0x18*/ string Name;
                /*0x20*/ Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints Hint;

                class AxisGetter : System.MulticastDelegate
                {
                    /*0x799bc48*/ AxisGetter(object object, nint method);
                    /*0x799bce4*/ ref Unity.Cinemachine.InputAxis Invoke();
                    /*0x799bcf8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0x799bd18*/ ref Unity.Cinemachine.InputAxis EndInvoke(System.IAsyncResult result);
                }

                enum Hints
                {
                    Default = 0,
                    X = 1,
                    Y = 2,
                }
            }
        }

        interface IInputAxisResetSource
        {
            /*0x3816710*/ void RegisterResetHandler(System.Action handler);
            /*0x3816710*/ void UnregisterResetHandler(System.Action handler);
            /*0x3813ffc*/ bool get_HasResetHandler();
        }

        interface IInputAxisReader
        {
            float GetValue(UnityEngine.Object context, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint);
        }

        struct InputAxis
        {
            /*0x10*/ float Value;
            /*0x14*/ float Center;
            /*0x18*/ UnityEngine.Vector2 Range;
            /*0x20*/ bool Wrap;
            /*0x24*/ Unity.Cinemachine.InputAxis.RecenteringSettings Recentering;
            /*0x30*/ Unity.Cinemachine.InputAxis.RestrictionFlags Restrictions;
            /*0x34*/ Unity.Cinemachine.InputAxis.RecenteringState m_RecenteringState;

            static /*0x799c084*/ Unity.Cinemachine.InputAxis get_DefaultMomentary();
            /*0x799bd24*/ float ClampValue(float v);
            /*0x799bd90*/ float GetNormalizedValue();
            /*0x799be18*/ float GetClampedValue();
            /*0x799be88*/ void Validate();
            /*0x799bf78*/ void Reset();
            /*0x799c0ac*/ bool TrackValueChange();
            /*0x799c184*/ void SetValueAndLastValue(float value);
            /*0x799c190*/ void UpdateRecentering(float deltaTime, bool forceCancel);
            /*0x799c19c*/ void UpdateRecentering(float deltaTime, bool forceCancel, float center);
            /*0x799c3d0*/ void TriggerRecentering();
            /*0x799c000*/ void CancelRecentering();

            struct RecenteringSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float Wait;
                /*0x18*/ float Time;

                static /*0x799c3dc*/ Unity.Cinemachine.InputAxis.RecenteringSettings get_Default();
                /*0x799bf60*/ void Validate();
            }

            enum RestrictionFlags
            {
                None = 0,
                RangeIsDriven = 1,
                NoRecentering = 2,
                Momentary = 4,
            }

            struct RecenteringState
            {
                static float k_Epsilon = 0.00009999999747378752;
                /*0x10*/ float m_RecenteringVelocity;
                /*0x14*/ bool m_ForceRecenter;
                /*0x18*/ float m_LastValueChangeTime;
                /*0x1c*/ float m_LastValue;

                static /*0x799c138*/ float get_CurrentTime();
            }
        }

        struct DefaultInputAxisDriver
        {
            /*0x10*/ float m_CurrentSpeed;
            /*0x14*/ float AccelTime;
            /*0x18*/ float DecelTime;

            static /*0x799c400*/ Unity.Cinemachine.DefaultInputAxisDriver get_Default();
            /*0x799c3e8*/ void Validate();
            /*0x799c414*/ void ProcessInput(ref Unity.Cinemachine.InputAxis axis, float inputValue, float deltaTime);
            /*0x799c6a4*/ void Reset(ref Unity.Cinemachine.InputAxis axis);
        }

        interface IInputAxisController
        {
            /*0x38159dc*/ void SynchronizeControllers();
        }

        class InputAxisControllerManagerAttribute : UnityEngine.PropertyAttribute
        {
            /*0x799c6b0*/ InputAxisControllerManagerAttribute();
        }

        class InputAxisControllerManager<T>
        {
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.InputAxisControllerBase.Controller<T>> Controllers;
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> m_Axes;
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner> m_AxisOwners;
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.IInputAxisResetSource> m_AxisResetters;

            static /*0x3830114*/ int <CreateControllers>g__GetControllerIndex|9_0(System.Collections.Generic.List<Unity.Cinemachine.InputAxisControllerBase.Controller<T>> list, Unity.Cinemachine.IInputAxisOwner owner, string axisName);
            /*0x38159dc*/ InputAxisControllerManager();
            /*0x38159dc*/ void Validate();
            /*0x38159dc*/ void OnDisable();
            /*0x38159dc*/ void Reset();
            /*0x38159dc*/ void OnResetInput();
            /*0x3910ae8*/ void CreateControllers(UnityEngine.GameObject root, bool scanRecursively, bool enabled, Unity.Cinemachine.InputAxisControllerManager.DefaultInitializer<T> defaultInitializer);
            void RegisterResetHandlers(UnityEngine.GameObject root, bool scanRecursively);
            void UpdateControllers(UnityEngine.Object context, float deltaTime);

            class DefaultInitializer<T> : System.MulticastDelegate
            {
                DefaultInitializer(object object, nint method);
                /*0x3816810*/ void Invoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<T> controller);
                /*0x3814c50*/ System.IAsyncResult BeginInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<T> controller, System.AsyncCallback callback, object object);
                /*0x3816810*/ void EndInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, System.IAsyncResult result);
            }
        }

        class InputAxisControllerBase<T> : UnityEngine.MonoBehaviour, Unity.Cinemachine.IInputAxisController
        {
            /*0x0*/ bool ScanRecursively;
            /*0x0*/ bool SuppressInputWhileBlending;
            /*0x0*/ bool IgnoreTimeScale;
            /*0x0*/ Unity.Cinemachine.InputAxisControllerManager<T> m_ControllerManager;

            /*0x38159dc*/ InputAxisControllerBase();
            /*0x38148bc*/ System.Collections.Generic.List<Unity.Cinemachine.InputAxisControllerBase.Controller<T>> get_Controllers();
            /*0x38159dc*/ void OnValidate();
            /*0x38159dc*/ void Reset();
            /*0x38159dc*/ void OnEnable();
            /*0x38159dc*/ void OnDisable();
            /*0x38159dc*/ void SynchronizeControllers();
            /*0x3816810*/ void InitializeControllerDefaultsForAxis(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<T> controller);
            /*0x38159dc*/ void UpdateControllers();
            /*0x3816f24*/ void UpdateControllers(float deltaTime);

            class Controller<T>
            {
                /*0x0*/ string Name;
                /*0x0*/ UnityEngine.Object Owner;
                /*0x0*/ bool Enabled;
                /*0x0*/ T Input;
                /*0x0*/ float InputValue;
                /*0x0*/ Unity.Cinemachine.DefaultInputAxisDriver Driver;

                /*0x38159dc*/ Controller();
            }
        }

        interface IShotQualityEvaluator
        {
        }

        struct LensSettings
        {
            /*0x10*/ float FieldOfView;
            /*0x14*/ float OrthographicSize;
            /*0x18*/ float NearClipPlane;
            /*0x1c*/ float FarClipPlane;
            /*0x20*/ float Dutch;
            /*0x24*/ Unity.Cinemachine.LensSettings.OverrideModes ModeOverride;
            /*0x28*/ Unity.Cinemachine.LensSettings.PhysicalSettings PhysicalProperties;
            /*0x60*/ bool m_OrthoFromCamera;
            /*0x61*/ bool m_PhysicalFromCamera;
            /*0x64*/ float m_AspectFromCamera;

            static /*0x798f958*/ Unity.Cinemachine.LensSettings get_Default();
            static /*0x799c6e8*/ Unity.Cinemachine.LensSettings FromCamera(UnityEngine.Camera fromCamera);
            static /*0x7990c74*/ Unity.Cinemachine.LensSettings Lerp(Unity.Cinemachine.LensSettings lensA, Unity.Cinemachine.LensSettings lensB, float t);
            static /*0x799cda8*/ bool AreEqual(ref Unity.Cinemachine.LensSettings a, ref Unity.Cinemachine.LensSettings b);
            /*0x7990e1c*/ bool get_Orthographic();
            /*0x799c6b8*/ bool get_IsPhysicalCamera();
            /*0x7991720*/ float get_Aspect();
            /*0x7999068*/ void PullInheritedPropertiesFromCamera(UnityEngine.Camera camera);
            /*0x799c970*/ void CopyCameraMode(ref Unity.Cinemachine.LensSettings fromLens);
            /*0x799c9d4*/ void Lerp(ref Unity.Cinemachine.LensSettings lensB, float t);
            /*0x799cc98*/ void Validate();

            enum OverrideModes
            {
                None = 0,
                Orthographic = 1,
                Perspective = 2,
                Physical = 3,
            }

            struct PhysicalSettings
            {
                /*0x10*/ UnityEngine.Camera.GateFitMode GateFit;
                /*0x14*/ UnityEngine.Vector2 SensorSize;
                /*0x1c*/ UnityEngine.Vector2 LensShift;
                /*0x24*/ float FocusDistance;
                /*0x28*/ int Iso;
                /*0x2c*/ float ShutterSpeed;
                /*0x30*/ float Aperture;
                /*0x34*/ int BladeCount;
                /*0x38*/ UnityEngine.Vector2 Curvature;
                /*0x40*/ float BarrelClipping;
                /*0x44*/ float Anamorphism;
            }
        }

        struct LookaheadSettings
        {
            /*0x10*/ bool Enabled;
            /*0x14*/ float Time;
            /*0x18*/ float Smoothing;
            /*0x1c*/ bool IgnoreY;
        }

        class NoiseSettings : Unity.Cinemachine.SignalSourceAsset
        {
            /*0x18*/ Unity.Cinemachine.NoiseSettings.TransformNoiseParams[] PositionNoise;
            /*0x20*/ Unity.Cinemachine.NoiseSettings.TransformNoiseParams[] OrientationNoise;

            static /*0x799d170*/ UnityEngine.Vector3 GetCombinedFilterResults(Unity.Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, float time, UnityEngine.Vector3 timeOffsets);
            /*0x799d3b4*/ NoiseSettings();
            /*0x799d2c0*/ float get_SignalDuration();
            /*0x799d2c8*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);

            struct NoiseParams
            {
                /*0x10*/ float Frequency;
                /*0x14*/ float Amplitude;
                /*0x18*/ bool Constant;

                /*0x799d43c*/ float GetValueAt(float time, float timeOffset);
            }

            struct TransformNoiseParams
            {
                /*0x10*/ Unity.Cinemachine.NoiseSettings.NoiseParams X;
                /*0x1c*/ Unity.Cinemachine.NoiseSettings.NoiseParams Y;
                /*0x28*/ Unity.Cinemachine.NoiseSettings.NoiseParams Z;

                /*0x799d25c*/ UnityEngine.Vector3 GetValueAt(float time, UnityEngine.Vector3 timeOffsets);
            }
        }

        enum OutputChannels
        {
            Default = 1,
            Channel01 = 2,
            Channel02 = 4,
            Channel03 = 8,
            Channel04 = 16,
            Channel05 = 32,
            Channel06 = 64,
            Channel07 = 128,
            Channel08 = 256,
            Channel09 = 512,
            Channel10 = 1024,
            Channel11 = 2048,
            Channel12 = 4096,
            Channel13 = 8192,
            Channel14 = 16384,
            Channel15 = 32768,
        }

        struct PositionPredictor
        {
            /*0x10*/ UnityEngine.Vector3 m_Velocity;
            /*0x1c*/ UnityEngine.Vector3 m_SmoothDampVelocity;
            /*0x28*/ UnityEngine.Vector3 m_Pos;
            /*0x34*/ bool m_HavePos;
            /*0x38*/ float Smoothing;

            /*0x799d4a0*/ bool get_IsEmpty();
            /*0x799d4b0*/ UnityEngine.Vector3 get_CurrentPosition();
            /*0x799d4bc*/ void ApplyTransformDelta(UnityEngine.Vector3 positionDelta);
            /*0x799d4dc*/ void Reset();
            /*0x799d54c*/ void AddPosition(UnityEngine.Vector3 pos, float deltaTime);
            /*0x799d644*/ UnityEngine.Vector3 PredictPositionDelta(float lookaheadTime);
        }

        class Damper
        {
            static float Epsilon = 0.00009999999747378752;
            static float kNegligibleResidual = 0.009999999776482582;
            static float kLogNegligibleResidual = -4.605170249938965;

            static /*0x799d660*/ float DecayConstant(float time, float residual);
            static /*0x799d688*/ float DecayedRemainder(float initial, float decayConstant, float deltaTime);
            static /*0x7997ea8*/ float Damp(float initial, float dampTime, float deltaTime);
            static /*0x7998004*/ UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime);
            static /*0x79981c0*/ UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, float dampTime, float deltaTime);
            static /*0x799d6ac*/ float StandardDamp(float initial, float dampTime, float deltaTime);
            static /*0x799d714*/ float StableDamp(float initial, float dampTime, float deltaTime);

            class AverageFrameRateTracker
            {
                static int kBufferSize = 100;
                static float kSubframeTime = 0.0009765625;
                static /*0x0*/ float[] s_Buffer;
                static /*0x8*/ int s_NumItems;
                static /*0xc*/ int s_Head;
                static /*0x10*/ float s_Sum;
                static /*0x14*/ float <FPS>k__BackingField;
                static /*0x18*/ float <DampTimeScale>k__BackingField;

                static /*0x799de74*/ AverageFrameRateTracker();
                static /*0x799d8fc*/ float get_FPS();
                static /*0x799d954*/ void set_FPS(float value);
                static /*0x799d9b8*/ float get_DampTimeScale();
                static /*0x799da10*/ void set_DampTimeScale(float value);
                static /*0x799da74*/ void Initialize();
                static /*0x799db90*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                static /*0x799dac0*/ void Reset();
                static /*0x799dc98*/ void Append();
                static /*0x799dbdc*/ void SetDampTimeScale(float fps);
            }
        }

        struct PrioritySettings
        {
            /*0x10*/ bool Enabled;
            /*0x14*/ int m_Value;

            static /*0x799defc*/ int op_Implicit(Unity.Cinemachine.PrioritySettings prioritySettings);
            static /*0x799df0c*/ Unity.Cinemachine.PrioritySettings op_Implicit(int priority);
            /*0x7998cb8*/ int get_Value();
            /*0x7997d50*/ void set_Value(int value);
        }

        class RuntimeUtility
        {
            static /*0x0*/ UnityEngine.RaycastHit[] s_HitBuffer;
            static /*0x8*/ int[] s_PenetrationIndexBuffer;
            static /*0x10*/ UnityEngine.SphereCollider s_ScratchCollider;
            static /*0x18*/ UnityEngine.GameObject s_ScratchColliderGameObject;
            static /*0x20*/ int s_ScratchColliderRefCount;

            static /*0x799f19c*/ RuntimeUtility();
            static /*0x799df1c*/ void DestroyObject(UnityEngine.Object obj);
            static /*0x799dfa4*/ bool IsPrefab(UnityEngine.GameObject gameObject);
            static /*0x799dfac*/ bool RaycastIgnoreTag(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float rayLength, int layerMask, ref string ignoreTag);
            static /*0x799e2e0*/ bool SphereCastIgnoreTag(UnityEngine.Ray ray, float radius, ref UnityEngine.RaycastHit hitInfo, float rayLength, int layerMask, ref string ignoreTag);
            static /*0x799ebbc*/ UnityEngine.SphereCollider GetScratchCollider();
            static /*0x799ee2c*/ void DestroyScratchCollider();
            static /*0x799ef3c*/ UnityEngine.AnimationCurve NormalizeCurve(UnityEngine.AnimationCurve curve, bool normalizeX, bool normalizeY);
        }

        struct ScreenComposerSettings
        {
            /*0x10*/ UnityEngine.Vector2 ScreenPosition;
            /*0x18*/ Unity.Cinemachine.ScreenComposerSettings.DeadZoneSettings DeadZone;
            /*0x24*/ Unity.Cinemachine.ScreenComposerSettings.HardLimitSettings HardLimits;

            static /*0x799f538*/ Unity.Cinemachine.ScreenComposerSettings Lerp(ref Unity.Cinemachine.ScreenComposerSettings a, ref Unity.Cinemachine.ScreenComposerSettings b, float t);
            static /*0x799f724*/ bool Approximately(ref Unity.Cinemachine.ScreenComposerSettings a, ref Unity.Cinemachine.ScreenComposerSettings b);
            static /*0x799fa78*/ Unity.Cinemachine.ScreenComposerSettings get_Default();
            /*0x799f250*/ void Validate();
            /*0x799f2f0*/ UnityEngine.Vector2 get_EffectiveDeadZoneSize();
            /*0x799f34c*/ UnityEngine.Vector2 get_EffectiveHardLimitSize();
            /*0x799f368*/ UnityEngine.Rect get_DeadZoneRect();
            /*0x799f3a8*/ void set_DeadZoneRect(UnityEngine.Rect value);
            /*0x799f470*/ UnityEngine.Rect get_HardLimitsRect();
            /*0x799f4f8*/ void set_HardLimitsRect(UnityEngine.Rect value);

            struct DeadZoneSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.Vector2 Size;
            }

            struct HardLimitSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.Vector2 Size;
                /*0x1c*/ UnityEngine.Vector2 Offset;
            }
        }

        interface ISignalSource6D
        {
            /*0x38151b8*/ float get_SignalDuration();
            void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        }

        class SignalSourceAsset : UnityEngine.ScriptableObject, Unity.Cinemachine.ISignalSource6D
        {
            /*0x799d434*/ SignalSourceAsset();
            /*0x38151b8*/ float get_SignalDuration();
            void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        }

        struct SplineAutoDolly
        {
            /*0x10*/ bool Enabled;
            /*0x18*/ Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly Method;

            interface ISplineAutoDolly
            {
                /*0x38159dc*/ void Validate();
                /*0x38159dc*/ void Reset();
                /*0x3813ffc*/ bool get_RequiresTrackingTarget();
                float GetSplinePosition(UnityEngine.MonoBehaviour sender, UnityEngine.Transform target, UnityEngine.Splines.SplineContainer spline, float currentPosition, UnityEngine.Splines.PathIndexUnit positionUnits, float deltaTime);
            }

            class FixedSpeed : Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly
            {
                /*0x10*/ float Speed;

                /*0x799fce0*/ FixedSpeed();
                /*0x799fab4*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Validate();
                /*0x799fab8*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Reset();
                /*0x799fabc*/ bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.get_RequiresTrackingTarget();
                /*0x799fac4*/ float Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.GetSplinePosition(UnityEngine.MonoBehaviour sender, UnityEngine.Transform target, UnityEngine.Splines.SplineContainer spline, float currentPosition, UnityEngine.Splines.PathIndexUnit positionUnits, float deltaTime);
            }

            class NearestPointToTarget : Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly
            {
                /*0x10*/ float PositionOffset;
                /*0x14*/ int SearchResolution;
                /*0x18*/ int SearchIteration;

                /*0x799fe84*/ NearestPointToTarget();
                /*0x799fce8*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Validate();
                /*0x799fcfc*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Reset();
                /*0x799fd00*/ bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.get_RequiresTrackingTarget();
                /*0x799fd08*/ float Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.GetSplinePosition(UnityEngine.MonoBehaviour sender, UnityEngine.Transform target, UnityEngine.Splines.SplineContainer spline, float currentPosition, UnityEngine.Splines.PathIndexUnit positionUnits, float deltaTime);
            }
        }

        class SplineContainerExtensions
        {
            static /*0x799fb60*/ bool IsValid(UnityEngine.Splines.ISplineContainer spline);
            static /*0x799fe98*/ bool LocalEvaluateSplineWithRoll(UnityEngine.Splines.ISpline spline, float tNormalized, Unity.Cinemachine.CinemachineSplineRoll roll, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            static /*0x79a0314*/ bool EvaluateSplineWithRoll(UnityEngine.Splines.ISpline spline, UnityEngine.Transform transform, float tNormalized, Unity.Cinemachine.CinemachineSplineRoll roll, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            static /*0x79a04e4*/ UnityEngine.Vector3 EvaluateSplinePosition(UnityEngine.Splines.ISpline spline, UnityEngine.Transform transform, float tNormalized);
            static /*0x79a06bc*/ float GetMaxPosition(UnityEngine.Splines.ISpline spline, UnityEngine.Splines.PathIndexUnit unit);
            static /*0x79a0870*/ float StandardizePosition(UnityEngine.Splines.ISpline spline, float t, UnityEngine.Splines.PathIndexUnit unit, ref float maxPos);
            static /*0x79a02dc*/ UnityEngine.Quaternion <LocalEvaluateSplineWithRoll>g__RollAroundForward|1_0(float angle);
        }

        class SplineHelpers
        {
            static /*0x79a099c*/ UnityEngine.Vector3 Bezier3(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3);
            static /*0x79a0a44*/ UnityEngine.Vector3 BezierTangent3(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3);
            static /*0x79a0b3c*/ void BezierTangentWeights3(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, ref UnityEngine.Vector3 w0, ref UnityEngine.Vector3 w1, ref UnityEngine.Vector3 w2);
            static /*0x79a0c24*/ float Bezier1(float t, float p0, float p1, float p2, float p3);
            static /*0x79a0c84*/ float BezierTangent1(float t, float p0, float p1, float p2, float p3);
            static /*0x79a0cf8*/ void ComputeSmoothControlPoints(ref UnityEngine.Vector4[] knot, ref UnityEngine.Vector4[] ctrl1, ref UnityEngine.Vector4[] ctrl2);
            static /*0x79a181c*/ void ComputeSmoothControlPointsLooped(ref UnityEngine.Vector4[] knot, ref UnityEngine.Vector4[] ctrl1, ref UnityEngine.Vector4[] ctrl2);
            static /*0x79a1ac8*/ void ComputeSmoothControlPoints(ref Unity.Mathematics.float3[] knot, ref Unity.Mathematics.float3[] ctrl1, ref Unity.Mathematics.float3[] ctrl2);
            static /*0x79a2270*/ void ComputeSmoothControlPointsLooped(ref Unity.Mathematics.float3[] knot, ref Unity.Mathematics.float3[] ctrl1, ref Unity.Mathematics.float3[] ctrl2);
        }

        interface ISplineReferencer
        {
            /*0x38148bc*/ ref Unity.Cinemachine.SplineSettings get_SplineSettings();
        }

        struct SplineSettings
        {
            /*0x10*/ UnityEngine.Splines.SplineContainer Spline;
            /*0x18*/ float Position;
            /*0x1c*/ UnityEngine.Splines.PathIndexUnit Units;
            /*0x20*/ Unity.Cinemachine.CachedScaledSpline m_CachedSpline;
            /*0x28*/ int m_CachedFrame;

            /*0x79a2578*/ void ChangeUnitPreservePosition(UnityEngine.Splines.PathIndexUnit newUnits);
            /*0x79a25fc*/ Unity.Cinemachine.CachedScaledSpline GetCachedSpline();
            /*0x79a273c*/ void InvalidateCache();
        }

        class CachedScaledSpline : UnityEngine.Splines.ISpline, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.BezierKnot>, System.IDisposable
        {
            /*0x10*/ UnityEngine.Splines.NativeSpline m_NativeSpline;
            /*0x58*/ UnityEngine.Splines.Spline m_CachedSource;
            /*0x60*/ UnityEngine.Vector3 m_CachedScale;
            /*0x6c*/ bool m_IsAllocated;

            /*0x79a28bc*/ CachedScaledSpline(UnityEngine.Splines.Spline spline, UnityEngine.Transform transform, Unity.Collections.Allocator allocator);
            /*0x79a2a5c*/ void Dispose();
            /*0x79a2780*/ bool IsCrudelyValid(UnityEngine.Splines.Spline spline, UnityEngine.Transform transform);
            /*0x79a2aac*/ bool KnotsAreValid(UnityEngine.Splines.Spline spline, UnityEngine.Transform transform);
            /*0x79a2e5c*/ UnityEngine.Splines.BezierKnot get_Item(int index);
            /*0x79a2ea0*/ bool get_Closed();
            /*0x79a2ea8*/ int get_Count();
            /*0x79a2eb4*/ UnityEngine.Splines.BezierCurve GetCurve(int index);
            /*0x79a2eec*/ float GetCurveInterpolation(int curveIndex, float curveDistance);
            /*0x79a2ef8*/ float GetCurveLength(int index);
            /*0x79a2f04*/ Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            /*0x79a2e50*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator();
            /*0x79a2f10*/ float GetLength();
            /*0x79a2f18*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class TargetPositionCache
        {
            static float CacheStepSize = 0.01666666753590107;
            static float kWraparoundSlush = 0.10000000149011612;
            static /*0x0*/ bool UseCache;
            static /*0x4*/ Unity.Cinemachine.TargetPositionCache.Mode m_CacheMode;
            static /*0x8*/ float CurrentTime;
            static /*0xc*/ int CurrentFrame;
            static /*0x10*/ bool IsCameraCut;
            static /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Transform, Unity.Cinemachine.TargetPositionCache.CacheEntry> m_Cache;
            static /*0x20*/ Unity.Cinemachine.TargetPositionCache.TimeRange m_CacheTimeRange;

            static /*0x79a2f24*/ Unity.Cinemachine.TargetPositionCache.Mode get_CacheMode();
            static /*0x79a2f6c*/ void set_CacheMode(Unity.Cinemachine.TargetPositionCache.Mode value);
            static /*0x79a3220*/ bool get_IsRecording();
            static /*0x79a3280*/ bool get_CurrentPlaybackTimeValid();
            static /*0x79a3350*/ bool get_IsEmpty();
            static /*0x79a33a8*/ Unity.Cinemachine.TargetPositionCache.TimeRange get_CacheTimeRange();
            static /*0x79a32e8*/ bool get_HasCurrentTime();
            static /*0x79a2fec*/ void ClearCache();
            static /*0x79a30d0*/ void CreatePlaybackCurves();
            static /*0x79a3694*/ UnityEngine.Vector3 GetTargetPosition(UnityEngine.Transform target);
            static /*0x79a3e48*/ UnityEngine.Quaternion GetTargetRotation(UnityEngine.Transform target);
            /*0x79a40b0*/ TargetPositionCache();

            enum Mode
            {
                Disabled = 0,
                Record = 1,
                Playback = 2,
            }

            class CacheCurve
            {
                /*0x10*/ float StartTime;
                /*0x14*/ float StepSize;
                /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.TargetPositionCache.CacheCurve.Item> m_Cache;

                /*0x79a4100*/ CacheCurve(float startTime, float endTime, float stepSize);
                /*0x79a40b8*/ int get_Count();
                /*0x79a420c*/ void Add(Unity.Cinemachine.TargetPositionCache.CacheCurve.Item item);
                /*0x79a42f4*/ void AddUntil(Unity.Cinemachine.TargetPositionCache.CacheCurve.Item item, float time, bool isCut);
                /*0x79a3c70*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item Evaluate(float time);

                struct Item
                {
                    /*0x10*/ UnityEngine.Vector3 Pos;
                    /*0x1c*/ UnityEngine.Quaternion Rot;

                    static /*0x79a4444*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item Lerp(Unity.Cinemachine.TargetPositionCache.CacheCurve.Item a, Unity.Cinemachine.TargetPositionCache.CacheCurve.Item b, float t);
                    static /*0x79a44bc*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item get_Empty();
                }
            }

            class CacheEntry
            {
                /*0x10*/ Unity.Cinemachine.TargetPositionCache.CacheCurve Curve;
                /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.TargetPositionCache.CacheEntry.RecordingItem> RawItems;

                /*0x79a38fc*/ CacheEntry();
                /*0x79a3984*/ void AddRawItem(float time, bool isCut, UnityEngine.Transform target);
                /*0x79a3428*/ void CreateCurves();

                struct RecordingItem
                {
                    /*0x10*/ float Time;
                    /*0x14*/ bool IsCut;
                    /*0x18*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item Item;
                }
            }

            struct TimeRange
            {
                /*0x10*/ float Start;
                /*0x14*/ float End;

                static /*0x79a3414*/ Unity.Cinemachine.TargetPositionCache.TimeRange get_Empty();
                /*0x79a3398*/ bool get_IsEmpty();
                /*0x79a33f0*/ bool Contains(float time);
                /*0x79a3c54*/ void Include(float time);
            }
        }

        class UnityVectorExtensions
        {
            static float Epsilon = 0.00009999999747378752;

            static /*0x79a452c*/ bool IsNaN(UnityEngine.Vector2 v);
            static /*0x79a4558*/ bool IsNaN(UnityEngine.Vector3 v);
            static /*0x79a459c*/ float ClosestPointOnSegment(UnityEngine.Vector3 p, UnityEngine.Vector3 s0, UnityEngine.Vector3 s1);
            static /*0x79a4614*/ float ClosestPointOnSegment(UnityEngine.Vector2 p, UnityEngine.Vector2 s0, UnityEngine.Vector2 s1);
            static /*0x79a466c*/ UnityEngine.Vector3 ProjectOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal);
            static /*0x79a469c*/ UnityEngine.Vector2 SquareNormalize(UnityEngine.Vector2 v);
            static /*0x79a4708*/ int FindIntersection(ref UnityEngine.Vector2 p1, ref UnityEngine.Vector2 p2, ref UnityEngine.Vector2 q1, ref UnityEngine.Vector2 q2, ref UnityEngine.Vector2 intersection);
            static /*0x79a49a0*/ float Cross(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2);
            static /*0x79a49b0*/ UnityEngine.Vector2 Abs(UnityEngine.Vector2 v);
            static /*0x79a49bc*/ UnityEngine.Vector3 Abs(UnityEngine.Vector3 v);
            static /*0x79a49cc*/ bool IsUniform(UnityEngine.Vector2 v);
            static /*0x79a4a3c*/ bool IsUniform(UnityEngine.Vector3 v);
            static /*0x79a2a84*/ bool AlmostZero(UnityEngine.Vector3 v);
            static /*0x79a4adc*/ void ConservativeSetPositionAndRotation(UnityEngine.Transform t, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            static /*0x79a4bf4*/ float Angle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2);
            static /*0x79a4e34*/ float SignedAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up);
            static /*0x79a4ee4*/ UnityEngine.Quaternion SafeFromToRotation(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up);
            static /*0x79a537c*/ UnityEngine.Vector3 SlerpWithReferenceUp(UnityEngine.Vector3 vA, UnityEngine.Vector3 vB, float t, UnityEngine.Vector3 up);
            static /*0x79a5aa4*/ float NormalizeAngle(float angle);
        }

        class UnityQuaternionExtensions
        {
            static /*0x79a55fc*/ UnityEngine.Quaternion SlerpWithReferenceUp(UnityEngine.Quaternion qA, UnityEngine.Quaternion qB, float t, UnityEngine.Vector3 up);
            static /*0x79a5ad8*/ UnityEngine.Vector2 GetCameraRotationToTarget(UnityEngine.Quaternion orient, UnityEngine.Vector3 lookAtDir, UnityEngine.Vector3 worldUp);
            static /*0x79a5e24*/ UnityEngine.Quaternion ApplyCameraRotation(UnityEngine.Quaternion orient, UnityEngine.Vector2 rot, UnityEngine.Vector3 worldUp);
        }

        class UnityRectExtensions
        {
            static /*0x79a6000*/ UnityEngine.Rect Inflated(UnityEngine.Rect r, UnityEngine.Vector2 delta);
        }

        class UpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Transform, Unity.Cinemachine.UpdateTracker.UpdateStatus> s_UpdateStatus;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Transform> s_ToDelete;
            static /*0x10*/ object s_LastUpdateContext;

            static /*0x79a68d4*/ UpdateTracker();
            static /*0x79a6048*/ void InitializeModule();
            static /*0x79a60c0*/ void UpdateTargets(Unity.Cinemachine.UpdateTracker.UpdateClock currentClock);
            static /*0x79a6538*/ Unity.Cinemachine.UpdateTracker.UpdateClock GetPreferredUpdate(UnityEngine.Transform target);
            static /*0x79a677c*/ void OnUpdate(Unity.Cinemachine.UpdateTracker.UpdateClock currentClock, object context);
            static /*0x79a683c*/ void ForgetContext(object context);
            /*0x79a68cc*/ UpdateTracker();

            enum UpdateClock
            {
                Fixed = 1,
                Late = 2,
            }

            class UpdateStatus
            {
                static int kWindowSize = 30;
                /*0x10*/ int m_WindowStart;
                /*0x14*/ int m_NumWindowLateUpdateMoves;
                /*0x18*/ int m_NumWindowFixedUpdateMoves;
                /*0x1c*/ int m_NumWindows;
                /*0x20*/ int m_LastFrameUpdated;
                /*0x24*/ UnityEngine.Matrix4x4 m_LastPos;
                /*0x64*/ Unity.Cinemachine.UpdateTracker.UpdateClock <PreferredUpdate>k__BackingField;

                /*0x79a6724*/ UpdateStatus(int currentFrame, UnityEngine.Matrix4x4 pos);
                /*0x79a69c4*/ Unity.Cinemachine.UpdateTracker.UpdateClock get_PreferredUpdate();
                /*0x79a69cc*/ void set_PreferredUpdate(Unity.Cinemachine.UpdateTracker.UpdateClock value);
                /*0x79a6408*/ void OnUpdate(int currentFrame, Unity.Cinemachine.UpdateTracker.UpdateClock currentClock, UnityEngine.Matrix4x4 pos);
            }
        }

        class VirtualCameraRegistry
        {
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> m_ActiveCameras;
            /*0x18*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase>> m_AllCameras;
            /*0x20*/ bool m_ActiveCamerasAreSorted;
            /*0x24*/ int m_ActivationSequence;

            /*0x79a708c*/ VirtualCameraRegistry();
            /*0x79a69d4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase>> get_AllCamerasSortedByNestingLevel();
            /*0x79a69dc*/ int get_ActiveCameraCount();
            /*0x79a6a24*/ Unity.Cinemachine.CinemachineVirtualCameraBase GetActiveCamera(int index);
            /*0x79a6b84*/ void AddActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a6c48*/ void RemoveActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a6cd8*/ void CameraDestroyed(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a6d68*/ void CameraEnabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a6fdc*/ void CameraDisabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.VirtualCameraRegistry.<> <>9;
                static /*0x8*/ System.Comparison<Unity.Cinemachine.CinemachineVirtualCameraBase> <>9__8_0;

                static /*0x79a7168*/ <>c();
                /*0x79a71d0*/ <>c();
                /*0x79a71d8*/ int <GetActiveCamera>b__8_0(Unity.Cinemachine.CinemachineVirtualCameraBase x, Unity.Cinemachine.CinemachineVirtualCameraBase y);
            }
        }

        class CinemachineDebug
        {
            static /*0x0*/ System.Collections.Generic.List<System.Text.StringBuilder> s_AvailableStringBuilders;
            static /*0x8*/ System.Action<Unity.Cinemachine.CinemachineBrain> OnGUIHandlers;
            static /*0x10*/ bool GameViewGuidesEnabled;

            static /*0x79a7278*/ System.Text.StringBuilder SBFromPool();
            static /*0x79a737c*/ void ReturnToPool(System.Text.StringBuilder sb);
        }

        struct AxisState
        {
            static float Epsilon = 0.00009999999747378752;
            /*0x10*/ float Value;
            /*0x14*/ Unity.Cinemachine.AxisState.SpeedMode m_SpeedMode;
            /*0x18*/ float m_MaxSpeed;
            /*0x1c*/ float m_AccelTime;
            /*0x20*/ float m_DecelTime;
            /*0x28*/ string m_InputAxisName;
            /*0x30*/ float m_InputAxisValue;
            /*0x34*/ bool m_InvertInput;
            /*0x38*/ float m_MinValue;
            /*0x3c*/ float m_MaxValue;
            /*0x40*/ bool m_Wrap;
            /*0x44*/ Unity.Cinemachine.AxisState.Recentering m_Recentering;
            /*0x64*/ float m_CurrentSpeed;
            /*0x68*/ float m_LastUpdateTime;
            /*0x6c*/ int m_LastUpdateFrame;
            /*0x70*/ Unity.Cinemachine.AxisState.IInputAxisProvider m_InputAxisProvider;
            /*0x78*/ int m_InputAxisIndex;
            /*0x7c*/ bool <ValueRangeLocked>k__BackingField;
            /*0x7d*/ bool <HasRecentering>k__BackingField;

            /*0x79a74a8*/ AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert);
            /*0x79a756c*/ void Validate();
            /*0x79a75ac*/ void Reset();
            /*0x79a75bc*/ void SetInputAxisProvider(int axis, Unity.Cinemachine.AxisState.IInputAxisProvider provider);
            /*0x79a75cc*/ bool get_HasInputProvider();
            /*0x79a75dc*/ bool Update(float deltaTime);
            /*0x79a7b48*/ float ClampValue(float v);
            /*0x79a79ac*/ bool MaxSpeedUpdate(float input, float deltaTime);
            /*0x79a7bb4*/ float GetMaxSpeed();
            /*0x79a7c40*/ bool get_ValueRangeLocked();
            /*0x79a7c48*/ void set_ValueRangeLocked(bool value);
            /*0x79a7c54*/ bool get_HasRecentering();
            /*0x79a7c5c*/ void set_HasRecentering(bool value);

            enum SpeedMode
            {
                MaxSpeed = 0,
                InputValueGain = 1,
            }

            interface IInputAxisProvider
            {
                float GetAxisValue(int axis);
            }

            interface IRequiresInput
            {
                /*0x3813ffc*/ bool RequiresInput();
            }

            struct Recentering
            {
                /*0x10*/ bool m_enabled;
                /*0x14*/ float m_WaitTime;
                /*0x18*/ float m_RecenteringTime;
                /*0x1c*/ float m_LastUpdateTime;
                /*0x20*/ float mLastAxisInputTime;
                /*0x24*/ float mRecenteringVelocity;
                /*0x28*/ int m_LegacyHeadingDefinition;
                /*0x2c*/ int m_LegacyVelocityFilterStrength;

                /*0x79a754c*/ Recentering(bool enabled, float waitTime, float recenteringTime);
                /*0x79a7c68*/ void Validate();
                /*0x79a7c80*/ void CopyStateFrom(ref Unity.Cinemachine.AxisState.Recentering other);
                /*0x79a7c9c*/ void CancelRecentering();
                /*0x79a7cbc*/ void RecenterNow();
                /*0x79a7cc8*/ void DoRecentering(ref Unity.Cinemachine.AxisState axis, float deltaTime, float recenterTarget);
                /*0x79a7ef4*/ bool LegacyUpgrade(ref int heading, ref int velocityFilter);
            }
        }

        class Cinemachine3rdPersonFollow : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping, Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance
        {
            /*0x28*/ UnityEngine.Vector3 Damping;
            /*0x34*/ UnityEngine.Vector3 ShoulderOffset;
            /*0x40*/ float VerticalArmLength;
            /*0x44*/ float CameraSide;
            /*0x48*/ float CameraDistance;
            /*0x4c*/ UnityEngine.LayerMask CameraCollisionFilter;
            /*0x50*/ string IgnoreTag;
            /*0x58*/ float CameraRadius;
            /*0x5c*/ float DampingIntoCollision;
            /*0x60*/ float DampingFromCollision;
            /*0x64*/ UnityEngine.Vector3 m_PreviousFollowTargetPosition;
            /*0x70*/ UnityEngine.Vector3 m_DampingCorrection;
            /*0x7c*/ float m_CamPosCollisionCorrection;

            static /*0x79a86c8*/ UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up);
            /*0x79a8eac*/ Cinemachine3rdPersonFollow();
            /*0x79a7f30*/ void OnValidate();
            /*0x79a7f94*/ void Reset();
            /*0x79a7fec*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x79a8164*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x79a8170*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x79a817c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x79a8184*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x79a818c*/ bool get_IsValid();
            /*0x79a821c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79a8224*/ float GetMaxDampTime();
            /*0x79a8254*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a85f4*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79a82d8*/ void PositionCamera(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a8cb4*/ void GetRigPositions(ref UnityEngine.Vector3 root, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x79a887c*/ void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x79a896c*/ UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection);
            /*0x79a8dec*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineThirdPersonFollow c);
        }

        class CinemachineCollider : Unity.Cinemachine.CinemachineExtension, Unity.Cinemachine.IShotQualityEvaluator
        {
            static float k_PrecisionSlush = 0.0010000000474974513;
            static float k_AngleThreshold = 0.10000000149011612;
            static /*0x0*/ UnityEngine.Collider[] s_ColliderBuffer;
            /*0x30*/ UnityEngine.LayerMask m_CollideAgainst;
            /*0x38*/ string m_IgnoreTag;
            /*0x40*/ UnityEngine.LayerMask m_TransparentLayers;
            /*0x44*/ float m_MinimumDistanceFromTarget;
            /*0x48*/ bool m_AvoidObstacles;
            /*0x4c*/ float m_DistanceLimit;
            /*0x50*/ float m_MinimumOcclusionTime;
            /*0x54*/ float m_CameraRadius;
            /*0x58*/ Unity.Cinemachine.CinemachineCollider.ResolutionStrategy m_Strategy;
            /*0x5c*/ int m_MaximumEffort;
            /*0x60*/ float m_SmoothingTime;
            /*0x64*/ float m_Damping;
            /*0x68*/ float m_DampingWhenOccluded;
            /*0x6c*/ float m_OptimalTargetDistance;
            /*0x70*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineCollider.VcamExtraState> m_extraStateCache;
            /*0x78*/ UnityEngine.RaycastHit[] m_CornerBuffer;

            static /*0x79ad6cc*/ CinemachineCollider();
            static /*0x79ac8fc*/ float ClampRayToBounds(UnityEngine.Ray ray, float distance, UnityEngine.Bounds bounds);
            static /*0x79aadb8*/ bool IsTargetOffscreen(Unity.Cinemachine.CameraState state);
            /*0x79ad608*/ CinemachineCollider();
            /*0x79a8ee0*/ bool IsTargetObscured(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a8f48*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a8f60*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79a9030*/ void OnValidate();
            /*0x79a9074*/ void OnDestroy();
            /*0x79a90d4*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> get_DebugPaths();
            /*0x79a9374*/ float GetMaxDampTime();
            /*0x79a9390*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79a9dc4*/ UnityEngine.Vector3 PreserveLineOfSight(ref Unity.Cinemachine.CameraState state, ref Unity.Cinemachine.CinemachineCollider.VcamExtraState extra);
            /*0x79ab344*/ UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, int layerMask, ref UnityEngine.RaycastHit hitInfo);
            /*0x79ab660*/ UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, float targetDistance, int iterations, ref Unity.Cinemachine.CinemachineCollider.VcamExtraState extra);
            /*0x79abed8*/ bool GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, ref UnityEngine.Vector3 outDir);
            /*0x79ac6c8*/ float GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, float targetDistance, UnityEngine.Vector3 lookAtPos);
            /*0x79aa350*/ UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos);
            /*0x79ab068*/ bool CheckForTargetObstructions(Unity.Cinemachine.CameraState state);
            /*0x79ad574*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineDeoccluder c);

            enum ResolutionStrategy
            {
                PullCameraForward = 0,
                PreserveCameraHeight = 1,
                PreserveCameraDistance = 2,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 previousDisplacement;
                /*0x24*/ UnityEngine.Vector3 previousCameraOffset;
                /*0x30*/ UnityEngine.Vector3 previousCameraPosition;
                /*0x3c*/ float previousDampTime;
                /*0x40*/ bool targetObscured;
                /*0x44*/ float occlusionStartTime;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector3> debugResolutionPath;
                /*0x50*/ float m_SmoothedDistance;
                /*0x54*/ float m_SmoothedTime;

                /*0x79ad740*/ VcamExtraState();
                /*0x79ab65c*/ void AddPointToDebugPath(UnityEngine.Vector3 p);
                /*0x79aa234*/ float ApplyDistanceSmoothing(float distance, float smoothingTime);
                /*0x79aa1b4*/ void UpdateDistanceSmoothing(float distance);
                /*0x79aa2d8*/ void ResetDistanceSmoothing(float smoothingTime);
            }
        }

        class CinemachineComposer : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ UnityEngine.Vector3 m_TrackedObjectOffset;
            /*0x34*/ float m_LookaheadTime;
            /*0x38*/ float m_LookaheadSmoothing;
            /*0x3c*/ bool m_LookaheadIgnoreY;
            /*0x40*/ float m_HorizontalDamping;
            /*0x44*/ float m_VerticalDamping;
            /*0x48*/ float m_ScreenX;
            /*0x4c*/ float m_ScreenY;
            /*0x50*/ float m_DeadZoneWidth;
            /*0x54*/ float m_DeadZoneHeight;
            /*0x58*/ float m_SoftZoneWidth;
            /*0x5c*/ float m_SoftZoneHeight;
            /*0x60*/ float m_BiasX;
            /*0x64*/ float m_BiasY;
            /*0x68*/ bool m_CenterOnActivate;
            /*0x6c*/ UnityEngine.Vector3 <TrackedPoint>k__BackingField;
            /*0x78*/ UnityEngine.Vector3 m_CameraPosPrevFrame;
            /*0x84*/ UnityEngine.Vector3 m_LookAtPrevFrame;
            /*0x90*/ UnityEngine.Vector2 m_ScreenOffsetPrevFrame;
            /*0x98*/ UnityEngine.Quaternion m_CameraOrientationPrevFrame;
            /*0xa8*/ Unity.Cinemachine.PositionPredictor m_Predictor;
            /*0xd4*/ Unity.Cinemachine.CinemachineComposer.FovCache mCache;

            /*0x79aeb50*/ CinemachineComposer();
            /*0x79ad748*/ bool get_IsValid();
            /*0x79ad7d8*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79ad7e0*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x79ad7ec*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x79ad7f8*/ UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, float deltaTime);
            /*0x79ad9d0*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79adad4*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79adb38*/ float GetMaxDampTime();
            /*0x79adb48*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79adbd8*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79ae33c*/ UnityEngine.Rect get_SoftGuideRect();
            /*0x79ae870*/ void set_SoftGuideRect(UnityEngine.Rect value);
            /*0x79ae35c*/ UnityEngine.Rect get_HardGuideRect();
            /*0x79ae8e8*/ void set_HardGuideRect(UnityEngine.Rect value);
            /*0x79ae64c*/ void RotateToScreenBounds(ref Unity.Cinemachine.CameraState state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, ref UnityEngine.Quaternion rigOrientation, float fov, float fovH, float deltaTime);
            /*0x79ae928*/ bool ClampVerticalBounds(ref UnityEngine.Rect r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, float fov);
            /*0x79aea04*/ Unity.Cinemachine.ScreenComposerSettings get_Composition();
            /*0x79aea44*/ void set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            /*0x79aea9c*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineRotationComposer c);

            struct FovCache
            {
                /*0x10*/ UnityEngine.Rect mFovSoftGuideRect;
                /*0x20*/ UnityEngine.Rect mFovHardGuideRect;
                /*0x30*/ float mFovH;
                /*0x34*/ float mFov;
                /*0x38*/ float mOrthoSizeOverDistance;
                /*0x3c*/ float mAspect;
                /*0x40*/ UnityEngine.Rect mSoftGuideRect;
                /*0x50*/ UnityEngine.Rect mHardGuideRect;

                /*0x79ae38c*/ void UpdateCache(Unity.Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, float targetDistance);
                /*0x79aec64*/ UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, float fov, float fovH, float aspect);
            }
        }

        class CinemachineConfiner : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ Unity.Cinemachine.CinemachineConfiner.Mode m_ConfineMode;
            /*0x38*/ UnityEngine.Collider m_BoundingVolume;
            /*0x40*/ UnityEngine.Collider2D m_BoundingShape2D;
            /*0x48*/ UnityEngine.Collider2D m_BoundingShape2DCache;
            /*0x50*/ bool m_ConfineScreenEdges;
            /*0x54*/ float m_Damping;
            /*0x58*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> m_PathCache;
            /*0x60*/ int m_PathTotalPointCount;

            /*0x79b03d4*/ CinemachineConfiner();
            /*0x79af064*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79af07c*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79af0e4*/ void Reset();
            /*0x79af128*/ void OnValidate();
            /*0x79af13c*/ void ConnectToVcam(bool connect);
            /*0x79af148*/ bool get_IsValid();
            /*0x79af268*/ float GetMaxDampTime();
            /*0x79af270*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79afb90*/ void InvalidatePathCache();
            /*0x79afb94*/ void InvalidateCache();
            /*0x79afbbc*/ bool ValidatePathCache();
            /*0x79af858*/ UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 camPos);
            /*0x79af454*/ UnityEngine.Vector3 ConfineOrthoCameraToScreenEdges(ref Unity.Cinemachine.CameraState state);
            /*0x79b02e0*/ System.Type UpgradeToCm3_GetTargetType();
            /*0x79b0374*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineConfiner3D c);
            /*0x79b0398*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineConfiner2D c);

            enum Mode
            {
                Confine2D = 0,
                Confine3D = 1,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 PreviousDisplacement;
                /*0x24*/ float ConfinerDisplacement;

                /*0x79b03e4*/ VcamExtraState();
            }
        }

        class CinemachineDollyCart : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachinePathBase m_Path;
            /*0x28*/ Unity.Cinemachine.CinemachineDollyCart.UpdateMethod m_UpdateMethod;
            /*0x2c*/ Unity.Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
            /*0x30*/ float m_Speed;
            /*0x34*/ float m_Position;

            /*0x79b07d4*/ CinemachineDollyCart();
            /*0x79b03ec*/ void FixedUpdate();
            /*0x79b0554*/ void Update();
            /*0x79b05f0*/ void LateUpdate();
            /*0x79b0434*/ void SetCartPosition(float distanceAlongPath);
            /*0x79b0690*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineSplineCart c);

            enum UpdateMethod
            {
                Update = 0,
                FixedUpdate = 1,
                LateUpdate = 2,
            }
        }

        class CinemachineDoNotUpgrade : UnityEngine.MonoBehaviour
        {
            /*0x79b07e4*/ CinemachineDoNotUpgrade();
        }

        class CinemachineFramingTransposer : Unity.Cinemachine.CinemachineComponentBase
        {
            static float kMinimumCameraDistance = 0.009999999776482582;
            static float kMinimumGroupSize = 0.009999999776482582;
            /*0x28*/ UnityEngine.Vector3 m_TrackedObjectOffset;
            /*0x34*/ float m_LookaheadTime;
            /*0x38*/ float m_LookaheadSmoothing;
            /*0x3c*/ bool m_LookaheadIgnoreY;
            /*0x40*/ float m_XDamping;
            /*0x44*/ float m_YDamping;
            /*0x48*/ float m_ZDamping;
            /*0x4c*/ bool m_TargetMovementOnly;
            /*0x50*/ float m_ScreenX;
            /*0x54*/ float m_ScreenY;
            /*0x58*/ float m_CameraDistance;
            /*0x5c*/ float m_DeadZoneWidth;
            /*0x60*/ float m_DeadZoneHeight;
            /*0x64*/ float m_DeadZoneDepth;
            /*0x68*/ bool m_UnlimitedSoftZone;
            /*0x6c*/ float m_SoftZoneWidth;
            /*0x70*/ float m_SoftZoneHeight;
            /*0x74*/ float m_BiasX;
            /*0x78*/ float m_BiasY;
            /*0x7c*/ bool m_CenterOnActivate;
            /*0x80*/ Unity.Cinemachine.CinemachineFramingTransposer.FramingMode m_GroupFramingMode;
            /*0x84*/ Unity.Cinemachine.CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode;
            /*0x88*/ float m_GroupFramingSize;
            /*0x8c*/ float m_MaxDollyIn;
            /*0x90*/ float m_MaxDollyOut;
            /*0x94*/ float m_MinimumDistance;
            /*0x98*/ float m_MaximumDistance;
            /*0x9c*/ float m_MinimumFOV;
            /*0xa0*/ float m_MaximumFOV;
            /*0xa4*/ float m_MinimumOrthoSize;
            /*0xa8*/ float m_MaximumOrthoSize;
            /*0xac*/ UnityEngine.Vector3 m_PreviousCameraPosition;
            /*0xb8*/ Unity.Cinemachine.PositionPredictor m_Predictor;
            /*0xe4*/ UnityEngine.Vector3 <TrackedPoint>k__BackingField;
            /*0xf0*/ bool m_InheritingPosition;
            /*0xf4*/ float m_prevFOV;
            /*0xf8*/ UnityEngine.Quaternion m_prevRotation;
            /*0x108*/ UnityEngine.Bounds <LastBounds>k__BackingField;
            /*0x120*/ UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField;

            static /*0x79b209c*/ UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Unity.Cinemachine.ICinemachineTargetGroup group, ref UnityEngine.Vector3 pos, UnityEngine.Quaternion orientation);
            /*0x79b26fc*/ CinemachineFramingTransposer();
            /*0x79b07ec*/ UnityEngine.Rect get_SoftGuideRect();
            /*0x79b080c*/ void set_SoftGuideRect(UnityEngine.Rect value);
            /*0x79b0884*/ UnityEngine.Rect get_HardGuideRect();
            /*0x79b08b8*/ void set_HardGuideRect(UnityEngine.Rect value);
            /*0x79b08f8*/ void OnValidate();
            /*0x79b0990*/ bool get_IsValid();
            /*0x79b0a20*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79b0a28*/ bool get_BodyAppliesAfterAim();
            /*0x79b0a30*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x79b0a3c*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x79b0a48*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79b0b44*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79b0bac*/ float GetMaxDampTime();
            /*0x79b0bc8*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79b0da4*/ UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, float orthoSize, float aspect);
            /*0x79b0df8*/ UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect);
            /*0x79b0eb4*/ UnityEngine.Bounds get_LastBounds();
            /*0x79b0ecc*/ void set_LastBounds(UnityEngine.Bounds value);
            /*0x79b0ee4*/ UnityEngine.Matrix4x4 get_LastBoundsMatrix();
            /*0x79b0ef8*/ void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value);
            /*0x79b0f0c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79b1fdc*/ float GetTargetHeight(UnityEngine.Vector2 boundsSize);
            /*0x79b1bb0*/ UnityEngine.Vector3 ComputeGroupBounds(Unity.Cinemachine.ICinemachineTargetGroup group, ref Unity.Cinemachine.CameraState curState);
            /*0x79b2520*/ Unity.Cinemachine.ScreenComposerSettings get_Composition();
            /*0x79b2570*/ void set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            /*0x79b25c8*/ void UpgradeToCm3(Unity.Cinemachine.CinemachinePositionComposer c);
            /*0x79b26a4*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineGroupFraming c);

            enum FramingMode
            {
                Horizontal = 0,
                Vertical = 1,
                HorizontalAndVertical = 2,
                None = 3,
            }

            enum AdjustmentMode
            {
                ZoomOnly = 0,
                DollyOnly = 1,
                DollyThenZoom = 2,
            }
        }

        class CinemachineFreeLook : Unity.Cinemachine.CinemachineVirtualCameraBase, Unity.Cinemachine.AxisState.IRequiresInput, Unity.Cinemachine.ICinemachineMixer, Unity.Cinemachine.ICinemachineCamera
        {
            static /*0x0*/ Unity.Cinemachine.CinemachineFreeLook.CreateRigDelegate CreateRigOverride;
            static /*0x8*/ Unity.Cinemachine.CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride;
            /*0xa0*/ UnityEngine.Transform m_LookAt;
            /*0xa8*/ UnityEngine.Transform m_Follow;
            /*0xb0*/ bool m_CommonLens;
            /*0xb4*/ Unity.Cinemachine.LegacyLensSettings m_Lens;
            /*0x104*/ Unity.Cinemachine.CinemachineCore.BlendHints BlendHint;
            /*0x108*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent m_OnCameraLiveEvent;
            /*0x110*/ Unity.Cinemachine.AxisState m_YAxis;
            /*0x180*/ Unity.Cinemachine.AxisState.Recentering m_YAxisRecentering;
            /*0x1a0*/ Unity.Cinemachine.AxisState m_XAxis;
            /*0x210*/ Unity.Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;
            /*0x21c*/ Unity.Cinemachine.AxisState.Recentering m_RecenterToTargetHeading;
            /*0x23c*/ Unity.Cinemachine.TargetTracking.BindingMode m_BindingMode;
            /*0x240*/ float m_SplineCurvature;
            /*0x248*/ Unity.Cinemachine.CinemachineFreeLook.Orbit[] m_Orbits;
            /*0x250*/ float m_LegacyHeadingBias;
            /*0x254*/ bool mUseLegacyRigDefinitions;
            /*0x258*/ Unity.Cinemachine.CinemachineFreeLook.LegacyTransitionParams m_LegacyTransitions;
            /*0x268*/ bool mIsDestroyed;
            /*0x270*/ Unity.Cinemachine.CameraState m_State;
            /*0x380*/ Unity.Cinemachine.CinemachineVirtualCamera[] m_Rigs;
            /*0x388*/ Unity.Cinemachine.CinemachineOrbitalTransposer[] mOrbitals;
            /*0x390*/ Unity.Cinemachine.CinemachineBlend mBlendA;
            /*0x398*/ Unity.Cinemachine.CinemachineBlend mBlendB;
            /*0x3a0*/ float m_CachedXAxisHeading;
            /*0x3a4*/ float m_LastHeadingUpdateFrame;
            /*0x3a8*/ Unity.Cinemachine.LensSettings m_LensSettings;
            /*0x400*/ Unity.Cinemachine.CinemachineFreeLook.Orbit[] m_CachedOrbits;
            /*0x408*/ float m_CachedTension;
            /*0x410*/ UnityEngine.Vector4[] m_CachedKnots;
            /*0x418*/ UnityEngine.Vector4[] m_CachedCtrl1;
            /*0x420*/ UnityEngine.Vector4[] m_CachedCtrl2;

            static /*0x79b30f0*/ string[] get_RigNames();
            /*0x79b6928*/ CinemachineFreeLook();
            /*0x79b27c0*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x79b28a8*/ bool get_IsDprecated();
            /*0x79b28b0*/ void OnValidate();
            /*0x79b2930*/ Unity.Cinemachine.CinemachineVirtualCamera GetRig(int i);
            /*0x79b30d0*/ bool get_RigsAreCreated();
            /*0x79b31e0*/ void OnEnable();
            /*0x79b3210*/ void UpdateInputAxisProvider();
            /*0x79b32d4*/ void OnDestroy();
            /*0x79b3404*/ void OnTransformChildrenChanged();
            /*0x79b3418*/ void Reset();
            /*0x79b3b48*/ bool get_PreviousStateIsValid();
            /*0x79b3b50*/ void set_PreviousStateIsValid(bool value);
            /*0x79b3c40*/ Unity.Cinemachine.CameraState get_State();
            /*0x79b3c50*/ UnityEngine.Transform get_LookAt();
            /*0x79b3c5c*/ void set_LookAt(UnityEngine.Transform value);
            /*0x79b3c64*/ UnityEngine.Transform get_Follow();
            /*0x79b3c70*/ void set_Follow(UnityEngine.Transform value);
            /*0x79b3c78*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera vcam, bool dominantChildOnly);
            /*0x79b3d9c*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79b3e5c*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79b486c*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79b4d98*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79b5108*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();
            /*0x79b407c*/ float GetYAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up);
            /*0x79b5110*/ float SteepestDescent(UnityEngine.Vector3 cameraOffset);
            /*0x79b291c*/ void InvalidateRigCache();
            /*0x79b3440*/ void DestroyRigs();
            /*0x79b53f0*/ Unity.Cinemachine.CinemachineVirtualCamera[] CreateRigs(Unity.Cinemachine.CinemachineVirtualCamera[] copyFrom);
            /*0x79b2988*/ bool UpdateRigCache();
            /*0x79b5ce0*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCamera> LocateExistingRigs(bool forceOrbital);
            /*0x79b6334*/ float UpdateXAxisHeading(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
            /*0x79b444c*/ void PushSettingsToRigs();
            /*0x79b3d70*/ float GetYAxisValue();
            /*0x79b4bf0*/ Unity.Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79b64a0*/ UnityEngine.Vector3 GetLocalPositionForCameraFromInput(float t);
            /*0x79b65c8*/ void UpdateCachedSpline();
            /*0x79b52dc*/ float <SteepestDescent>g__AngleFunction|52_0(float input, ref Unity.Cinemachine.CinemachineFreeLook.<> );
            /*0x79b538c*/ float <SteepestDescent>g__SlopeOfAngleFunction|52_1(float input, ref Unity.Cinemachine.CinemachineFreeLook.<> );
            /*0x79b5224*/ float <SteepestDescent>g__InitialGuess|52_2(ref Unity.Cinemachine.CinemachineFreeLook.<> );
            /*0x79b6ce4*/ void <SteepestDescent>g__ChooseBestAngle|52_3(float x, ref Unity.Cinemachine.CinemachineFreeLook.<> , ref Unity.Cinemachine.CinemachineFreeLook.<> );

            struct Orbit
            {
                /*0x10*/ float m_Height;
                /*0x14*/ float m_Radius;

                /*0x79b6d14*/ Orbit(float h, float r);
            }

            struct LegacyTransitionParams
            {
                /*0x10*/ int m_BlendHint;
                /*0x14*/ bool m_InheritPosition;
                /*0x18*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent m_OnCameraLive;
            }

            class CreateRigDelegate : System.MulticastDelegate
            {
                /*0x79b6d1c*/ CreateRigDelegate(object object, nint method);
                /*0x79b6e28*/ Unity.Cinemachine.CinemachineVirtualCamera Invoke(Unity.Cinemachine.CinemachineFreeLook vcam, string name, Unity.Cinemachine.CinemachineVirtualCamera copyFrom);
                /*0x79b6e3c*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.CinemachineFreeLook vcam, string name, Unity.Cinemachine.CinemachineVirtualCamera copyFrom, System.AsyncCallback callback, object object);
                /*0x79b6e70*/ Unity.Cinemachine.CinemachineVirtualCamera EndInvoke(System.IAsyncResult result);
            }

            class DestroyRigDelegate : System.MulticastDelegate
            {
                /*0x79b6e7c*/ DestroyRigDelegate(object object, nint method);
                /*0x79b6f2c*/ void Invoke(UnityEngine.GameObject rig);
                /*0x79b6f40*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject rig, System.AsyncCallback callback, object object);
                /*0x79b6f60*/ void EndInvoke(System.IAsyncResult result);
            }

            struct <>c__DisplayClass52_0
            {
                /*0x10*/ Unity.Cinemachine.CinemachineFreeLook <>4__this;
                /*0x18*/ UnityEngine.Vector3 cameraOffset;
            }

            struct <>c__DisplayClass52_1
            {
                /*0x10*/ float bestAngle;
                /*0x14*/ float best;
            }
        }

        class CinemachineGroupComposer : Unity.Cinemachine.CinemachineComposer
        {
            /*0x124*/ float m_GroupFramingSize;
            /*0x128*/ Unity.Cinemachine.CinemachineGroupComposer.FramingMode m_FramingMode;
            /*0x12c*/ float m_FrameDamping;
            /*0x130*/ Unity.Cinemachine.CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode;
            /*0x134*/ float m_MaxDollyIn;
            /*0x138*/ float m_MaxDollyOut;
            /*0x13c*/ float m_MinimumDistance;
            /*0x140*/ float m_MaximumDistance;
            /*0x144*/ float m_MinimumFOV;
            /*0x148*/ float m_MaximumFOV;
            /*0x14c*/ float m_MinimumOrthoSize;
            /*0x150*/ float m_MaximumOrthoSize;
            /*0x154*/ float m_prevFramingDistance;
            /*0x158*/ float m_prevFOV;
            /*0x15c*/ UnityEngine.Bounds <LastBounds>k__BackingField;
            /*0x174*/ UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField;

            static /*0x79b7cc0*/ UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Unity.Cinemachine.ICinemachineTargetGroup group, UnityEngine.Matrix4x4 observer, ref UnityEngine.Vector3 newFwd);
            /*0x79b80e8*/ CinemachineGroupComposer();
            /*0x79b6f6c*/ void OnValidate();
            /*0x79b700c*/ void Reset();
            /*0x79b7048*/ UnityEngine.Bounds get_LastBounds();
            /*0x79b7060*/ void set_LastBounds(UnityEngine.Bounds value);
            /*0x79b7078*/ UnityEngine.Matrix4x4 get_LastBoundsMatrix();
            /*0x79b7090*/ void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value);
            /*0x79b70a8*/ float GetMaxDampTime();
            /*0x79b70cc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79b7f98*/ float GetTargetHeight(UnityEngine.Vector2 boundsSize);
            /*0x79b8088*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineGroupFraming c);

            enum FramingMode
            {
                Horizontal = 0,
                Vertical = 1,
                HorizontalAndVertical = 2,
            }

            enum AdjustmentMode
            {
                ZoomOnly = 0,
                DollyOnly = 1,
                DollyThenZoom = 2,
            }
        }

        struct AxisBase
        {
            /*0x10*/ float m_Value;
            /*0x14*/ float m_MinValue;
            /*0x18*/ float m_MaxValue;
            /*0x1c*/ bool m_Wrap;

            /*0x79b8124*/ void Validate();
        }

        struct CinemachineInputAxisDriver
        {
            static float Epsilon = 0.00009999999747378752;
            /*0x10*/ float multiplier;
            /*0x14*/ float accelTime;
            /*0x18*/ float decelTime;
            /*0x20*/ string name;
            /*0x28*/ float inputValue;
            /*0x2c*/ float mCurrentSpeed;

            /*0x79b8138*/ void Validate();
            /*0x79b8150*/ bool Update(float deltaTime, ref Unity.Cinemachine.AxisBase axis);
            /*0x79b8438*/ bool Update(float deltaTime, ref Unity.Cinemachine.AxisState axis);
            /*0x79b83cc*/ float ClampValue(ref Unity.Cinemachine.AxisBase axis, float v);
        }

        class CinemachineInputProvider : UnityEngine.MonoBehaviour, Unity.Cinemachine.AxisState.IInputAxisProvider
        {
            static int NUM_AXES = 3;
            /*0x20*/ int PlayerIndex;
            /*0x24*/ bool AutoEnableInputs;
            /*0x28*/ UnityEngine.InputSystem.InputActionReference XYAxis;
            /*0x30*/ UnityEngine.InputSystem.InputActionReference ZAxis;
            /*0x38*/ UnityEngine.InputSystem.InputAction[] m_cachedActions;

            static /*0x79b892c*/ UnityEngine.InputSystem.InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(ref UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.InputActionReference aRef);
            /*0x79b8a6c*/ CinemachineInputProvider();
            /*0x79b8488*/ float GetAxisValue(int axis);
            /*0x79b8578*/ UnityEngine.InputSystem.InputAction ResolveForPlayer(int axis, UnityEngine.InputSystem.InputActionReference actionRef);
            /*0x79b8a60*/ void OnDisable();

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionReference aRef;

                /*0x79b8a84*/ <>c__DisplayClass7_0();
                /*0x79b8a8c*/ bool <ResolveForPlayer>b__1(UnityEngine.InputSystem.InputAction x);
            }
        }

        class CinemachineInputProviderExtensions
        {
            static /*0x79b8af0*/ Unity.Cinemachine.AxisState.IInputAxisProvider GetInputAxisProvider(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
        }

        class CinemachineLegacyCameraEvents : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent OnCameraLive;
            /*0x28*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_Vcam;

            /*0x79b8e34*/ CinemachineLegacyCameraEvents();
            /*0x79b8bb0*/ void OnEnable();
            /*0x79b8cf0*/ void OnDisable();
            /*0x79b8dc0*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);

            class OnCameraLiveEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.ICinemachineCamera, Unity.Cinemachine.ICinemachineCamera>
            {
                /*0x79b8e9c*/ OnCameraLiveEvent();
            }
        }

        class HeadingTracker
        {
            static /*0x0*/ float mDecayExponent;
            /*0x10*/ Unity.Cinemachine.HeadingTracker.Item[] mHistory;
            /*0x18*/ int mTop;
            /*0x1c*/ int mBottom;
            /*0x20*/ int mCount;
            /*0x24*/ UnityEngine.Vector3 mHeadingSum;
            /*0x30*/ float mWeightSum;
            /*0x34*/ float mWeightTime;
            /*0x38*/ UnityEngine.Vector3 mLastGoodHeading;

            static /*0x79b9054*/ float Decay(float time);
            /*0x79b8ee4*/ HeadingTracker(int filterSize);
            /*0x79b9038*/ int get_FilterSize();
            /*0x79b8fd4*/ void ClearHistory();
            /*0x79b90ac*/ void Add(UnityEngine.Vector3 velocity);
            /*0x79b92c4*/ void PopBottom();
            /*0x79b940c*/ void DecayHistory();
            /*0x79b94fc*/ UnityEngine.Vector3 GetReliableHeading();

            struct Item
            {
                /*0x10*/ UnityEngine.Vector3 velocity;
                /*0x1c*/ float weight;
                /*0x20*/ float time;
            }
        }

        class CinemachineOrbitalTransposer : Unity.Cinemachine.CinemachineTransposer, Unity.Cinemachine.AxisState.IRequiresInput
        {
            /*0x9c*/ Unity.Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;
            /*0xa8*/ Unity.Cinemachine.AxisState.Recentering m_RecenterToTargetHeading;
            /*0xc8*/ Unity.Cinemachine.AxisState m_XAxis;
            /*0x138*/ Unity.Cinemachine.TargetTracking.Tracker m_TargetTracker;
            /*0x178*/ float m_LegacyRadius;
            /*0x17c*/ float m_LegacyHeightOffset;
            /*0x180*/ float m_LegacyHeadingBias;
            /*0x184*/ bool m_HeadingIsDriven;
            /*0x188*/ Unity.Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater;
            /*0x190*/ UnityEngine.Vector3 m_LastTargetPosition;
            /*0x1a0*/ Unity.Cinemachine.HeadingTracker mHeadingTracker;
            /*0x1a8*/ UnityEngine.Rigidbody m_TargetRigidBody;
            /*0x1b0*/ UnityEngine.Transform m_PreviousTarget;
            /*0x1b8*/ UnityEngine.Vector3 m_LastCameraPosition;
            /*0x1c4*/ float m_LastHeading;

            /*0x79baf30*/ CinemachineOrbitalTransposer();
            /*0x79b9650*/ void OnValidate();
            /*0x79b9780*/ float UpdateHeading(float deltaTime, UnityEngine.Vector3 up, ref Unity.Cinemachine.AxisState axis);
            /*0x79b978c*/ float UpdateHeading(float deltaTime, UnityEngine.Vector3 up, ref Unity.Cinemachine.AxisState axis, ref Unity.Cinemachine.AxisState.Recentering recentering, bool isLive);
            /*0x79b9cac*/ void OnEnable();
            /*0x79b9e08*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();
            /*0x79b9d20*/ void UpdateInputAxisProvider();
            /*0x79b9e10*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79b9fe0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79ba404*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79ba128*/ float GetAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up);
            /*0x79ba5d8*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79bac60*/ UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp);
            /*0x79b98dc*/ float GetTargetHeading(float currentHeading, UnityEngine.Quaternion targetOrientation);
            /*0x79bae30*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineOrbitalFollow c);

            struct Heading
            {
                /*0x10*/ Unity.Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition;
                /*0x14*/ int m_VelocityFilterStrength;
                /*0x18*/ float m_Bias;

                /*0x79bb134*/ Heading(Unity.Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias);

                enum HeadingDefinition
                {
                    PositionDelta = 0,
                    Velocity = 1,
                    TargetForward = 2,
                    WorldForward = 3,
                }
            }

            class UpdateHeadingDelegate : System.MulticastDelegate
            {
                /*0x79bb140*/ UpdateHeadingDelegate(object object, nint method);
                /*0x79bb2d0*/ float Invoke(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
                /*0x79bb2e4*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up, System.AsyncCallback callback, object object);
                /*0x79bb3a0*/ float EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineOrbitalTransposer.<> <>9;
                static /*0x8*/ Unity.Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate <>9__31_0;

                static /*0x79bb3c8*/ <>c();
                /*0x79bb430*/ <>c();
                /*0x79bb438*/ float <.ctor>b__31_0(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
            }
        }

        class CinemachinePath : Unity.Cinemachine.CinemachinePathBase
        {
            /*0x50*/ bool m_Looped;
            /*0x58*/ Unity.Cinemachine.CinemachinePath.Waypoint[] m_Waypoints;

            static /*0x79bbdb0*/ UnityEngine.Quaternion RollAroundForward(float angle);
            /*0x79bbde8*/ CinemachinePath();
            /*0x79bb500*/ float get_MinPos();
            /*0x79bb508*/ float get_MaxPos();
            /*0x79bb548*/ bool get_Looped();
            /*0x79bb550*/ void Reset();
            /*0x79bb684*/ void OnValidate();
            /*0x79bb694*/ int get_DistanceCacheSampleStepsPerSegment();
            /*0x79bb69c*/ float GetBoundingIndices(float pos, ref int indexA, ref int indexB);
            /*0x79bb8c4*/ UnityEngine.Vector3 EvaluateLocalPosition(float pos);
            /*0x79bba0c*/ UnityEngine.Vector3 EvaluateLocalTangent(float pos);
            /*0x79bbb54*/ UnityEngine.Quaternion EvaluateLocalOrientation(float pos);
            /*0x79bbcf0*/ float GetRoll(int indexA, int indexB, float standardizedPos);

            struct Waypoint
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Vector3 tangent;
                /*0x28*/ float roll;
            }
        }

        class CinemachinePathBase : UnityEngine.MonoBehaviour
        {
            /*0x20*/ int m_Resolution;
            /*0x28*/ Unity.Cinemachine.CinemachinePathBase.Appearance m_Appearance;
            /*0x30*/ float[] m_DistanceToPos;
            /*0x38*/ float[] m_PosToDistance;
            /*0x40*/ int m_CachedSampleSteps;
            /*0x44*/ float m_PathLength;
            /*0x48*/ float m_cachedPosStepSize;
            /*0x4c*/ float m_cachedDistanceStepSize;

            /*0x79bbe48*/ CinemachinePathBase();
            /*0x38151b8*/ float get_MinPos();
            /*0x38151b8*/ float get_MaxPos();
            /*0x3813ffc*/ bool get_Looped();
            /*0x79bbedc*/ float StandardizePos(float pos);
            /*0x79bbf88*/ UnityEngine.Vector3 EvaluatePosition(float pos);
            /*0x79bbfdc*/ UnityEngine.Vector3 EvaluateTangent(float pos);
            /*0x79bc030*/ UnityEngine.Quaternion EvaluateOrientation(float pos);
            UnityEngine.Vector3 EvaluateLocalPosition(float pos);
            UnityEngine.Vector3 EvaluateLocalTangent(float pos);
            UnityEngine.Quaternion EvaluateLocalOrientation(float pos);
            /*0x79bc10c*/ float FindClosestPoint(UnityEngine.Vector3 p, int startSegment, int searchRadius, int stepsPerSegment);
            /*0x79bc4c0*/ float MinUnit(Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bc4e0*/ float MaxUnit(Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bc568*/ float StandardizeUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bc674*/ UnityEngine.Vector3 EvaluatePositionAtUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bc828*/ UnityEngine.Vector3 EvaluateTangentAtUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bc848*/ UnityEngine.Quaternion EvaluateOrientationAtUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x3814574*/ int get_DistanceCacheSampleStepsPerSegment();
            /*0x79bc868*/ void InvalidateDistanceCache();
            /*0x79bc898*/ bool DistanceCacheIsValid();
            /*0x79bc508*/ float get_PathLength();
            /*0x79bc5f0*/ float StandardizePathDistance(float distance);
            /*0x79bc694*/ float ToNativePathUnits(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bccf0*/ float FromPathNativeUnits(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79bce58*/ void OnEnable();
            /*0x79bc92c*/ void ResamplePath(int stepsPerSegment);

            class Appearance
            {
                /*0x10*/ UnityEngine.Color pathColor;
                /*0x20*/ UnityEngine.Color inactivePathColor;
                /*0x30*/ float width;

                /*0x79bb65c*/ Appearance();
            }

            enum PositionUnits
            {
                PathUnits = 0,
                Distance = 1,
                Normalized = 2,
            }
        }

        class CinemachinePipeline : UnityEngine.MonoBehaviour
        {
            /*0x79bce5c*/ CinemachinePipeline();
        }

        class CinemachinePOV : Unity.Cinemachine.CinemachineComponentBase, Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource, Unity.Cinemachine.AxisState.IRequiresInput
        {
            /*0x28*/ Unity.Cinemachine.CinemachinePOV.RecenterTargetMode m_RecenterTarget;
            /*0x30*/ Unity.Cinemachine.AxisState m_VerticalAxis;
            /*0xa0*/ Unity.Cinemachine.AxisState.Recentering m_VerticalRecentering;
            /*0xc0*/ Unity.Cinemachine.AxisState m_HorizontalAxis;
            /*0x130*/ Unity.Cinemachine.AxisState.Recentering m_HorizontalRecentering;
            /*0x150*/ bool m_ApplyBeforeBody;
            /*0x154*/ UnityEngine.Quaternion m_PreviousCameraRotation;

            static /*0x79bd728*/ float NormalizeAngle(float angle);
            /*0x79bdcb4*/ CinemachinePOV();
            /*0x79bce64*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x79bce9c*/ bool get_IsValid();
            /*0x79bcea4*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79bceac*/ void OnValidate();
            /*0x79bcee8*/ void OnEnable();
            /*0x79bd020*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();
            /*0x79bcf04*/ void UpdateInputAxisProvider();
            /*0x79bd028*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79bd02c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79bd4c4*/ UnityEngine.Vector2 GetRecenterTarget();
            /*0x79bd758*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79bdaac*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79bd76c*/ void SetAxesForRotation(UnityEngine.Quaternion targetRot);
            /*0x79bdc48*/ void UpgradeToCm3(Unity.Cinemachine.CinemachinePanTilt c);

            enum RecenterTargetMode
            {
                None = 0,
                FollowTargetForward = 1,
                LookAtTargetForward = 2,
            }
        }

        class CinemachineSameAsFollowTarget : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ float Damping;
            /*0x2c*/ UnityEngine.Quaternion m_PreviousReferenceOrientation;

            /*0x79be064*/ CinemachineSameAsFollowTarget();
            /*0x79bde5c*/ bool get_IsValid();
            /*0x79bdeec*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79bdef4*/ float GetMaxDampTime();
            /*0x79bdefc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79be048*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineRotateWithFollowTarget c);
        }

        class CinemachineSmoothPath : Unity.Cinemachine.CinemachinePathBase
        {
            /*0x50*/ bool m_Looped;
            /*0x58*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint[] m_Waypoints;
            /*0x60*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints1;
            /*0x68*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints2;
            /*0x70*/ bool m_IsLoopedCache;

            static /*0x79beb3c*/ UnityEngine.Quaternion RollAroundForward(float angle);
            /*0x79beb74*/ CinemachineSmoothPath();
            /*0x79be0bc*/ float get_MinPos();
            /*0x79be0c4*/ float get_MaxPos();
            /*0x79be104*/ bool get_Looped();
            /*0x79be10c*/ int get_DistanceCacheSampleStepsPerSegment();
            /*0x79be114*/ void OnValidate();
            /*0x79be124*/ void Reset();
            /*0x79be220*/ void InvalidateDistanceCache();
            /*0x79be26c*/ void UpdateControlPoints();
            /*0x79be4f4*/ float GetBoundingIndices(float pos, ref int indexA, ref int indexB);
            /*0x79be61c*/ UnityEngine.Vector3 EvaluateLocalPosition(float pos);
            /*0x79be77c*/ UnityEngine.Vector3 EvaluateLocalTangent(float pos);
            /*0x79be8f8*/ UnityEngine.Quaternion EvaluateLocalOrientation(float pos);

            struct Waypoint
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ float roll;

                static /*0x79be4f0*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(UnityEngine.Vector4 v);
                /*0x79be4e4*/ UnityEngine.Vector4 get_AsVector4();
            }
        }

        class CinemachineTouchInputMapper : UnityEngine.MonoBehaviour
        {
            /*0x20*/ float TouchSensitivityX;
            /*0x24*/ float TouchSensitivityY;
            /*0x28*/ string TouchXInputMapTo;
            /*0x30*/ string TouchYInputMapTo;

            /*0x79bed44*/ CinemachineTouchInputMapper();
            /*0x79bebd4*/ void Start();
            /*0x79bec80*/ float GetInputAxis(string axisName);
        }

        class CinemachineTrackedDolly : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ Unity.Cinemachine.CinemachinePathBase m_Path;
            /*0x30*/ float m_PathPosition;
            /*0x34*/ Unity.Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
            /*0x38*/ UnityEngine.Vector3 m_PathOffset;
            /*0x44*/ float m_XDamping;
            /*0x48*/ float m_YDamping;
            /*0x4c*/ float m_ZDamping;
            /*0x50*/ Unity.Cinemachine.CinemachineTrackedDolly.CameraUpMode m_CameraUp;
            /*0x54*/ float m_PitchDamping;
            /*0x58*/ float m_YawDamping;
            /*0x5c*/ float m_RollDamping;
            /*0x60*/ Unity.Cinemachine.CinemachineTrackedDolly.AutoDolly m_AutoDolly;
            /*0x70*/ float m_PreviousPathPosition;
            /*0x74*/ UnityEngine.Quaternion m_PreviousOrientation;
            /*0x84*/ UnityEngine.Vector3 m_PreviousCameraPosition;

            /*0x79bfac8*/ CinemachineTrackedDolly();
            /*0x79bedd0*/ bool get_IsValid();
            /*0x79bee50*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79bee58*/ float GetMaxDampTime();
            /*0x79bef20*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79bf73c*/ UnityEngine.Quaternion GetCameraOrientationAtPathPoint(UnityEngine.Quaternion pathOrientation, UnityEngine.Vector3 up);
            /*0x79bee9c*/ UnityEngine.Vector3 get_AngularDamping();
            /*0x79bf944*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineSplineDolly c);

            enum CameraUpMode
            {
                Default = 0,
                Path = 1,
                PathNoRoll = 2,
                FollowTarget = 3,
                FollowTargetNoRoll = 4,
            }

            struct AutoDolly
            {
                /*0x10*/ bool m_Enabled;
                /*0x14*/ float m_PositionOffset;
                /*0x18*/ int m_SearchRadius;
                /*0x1c*/ int m_SearchResolution;

                /*0x79bfbd4*/ AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment);
            }
        }

        class CinemachineTransposer : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ Unity.Cinemachine.TargetTracking.BindingMode m_BindingMode;
            /*0x2c*/ UnityEngine.Vector3 m_FollowOffset;
            /*0x38*/ float m_XDamping;
            /*0x3c*/ float m_YDamping;
            /*0x40*/ float m_ZDamping;
            /*0x44*/ Unity.Cinemachine.TargetTracking.AngularDampingMode m_AngularDampingMode;
            /*0x48*/ float m_PitchDamping;
            /*0x4c*/ float m_YawDamping;
            /*0x50*/ float m_RollDamping;
            /*0x54*/ float m_AngularDamping;
            /*0x58*/ Unity.Cinemachine.TargetTracking.Tracker m_TargetTracker;
            /*0x98*/ bool <HideOffsetInInspector>k__BackingField;

            /*0x79bb24c*/ CinemachineTransposer();
            /*0x79bac34*/ Unity.Cinemachine.TargetTracking.TrackerSettings get_TrackerSettings();
            /*0x79b9750*/ void OnValidate();
            /*0x79bfbe8*/ bool get_HideOffsetInInspector();
            /*0x79bfbf0*/ void set_HideOffsetInInspector(bool value);
            /*0x79ba5b0*/ UnityEngine.Vector3 get_EffectiveOffset();
            /*0x79bfbfc*/ bool get_IsValid();
            /*0x79bfc8c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79bfc94*/ float GetMaxDampTime();
            /*0x79bfcdc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79b9ef8*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79ba074*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79bff6c*/ UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 up);
            /*0x79bff80*/ UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp);
            /*0x79c0070*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineFollow c);
        }

        class CinemachineVirtualCamera : Unity.Cinemachine.CinemachineVirtualCameraBase, Unity.Cinemachine.AxisState.IRequiresInput
        {
            static string PipelineName = "cm";
            static /*0x0*/ Unity.Cinemachine.CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride;
            static /*0x8*/ Unity.Cinemachine.CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride;
            /*0xa0*/ UnityEngine.Transform m_LookAt;
            /*0xa8*/ UnityEngine.Transform m_Follow;
            /*0xb0*/ Unity.Cinemachine.LegacyLensSettings m_Lens;
            /*0x100*/ Unity.Cinemachine.CinemachineCore.BlendHints BlendHint;
            /*0x108*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent m_OnCameraLiveEvent;
            /*0x110*/ string[] m_ExcludedPropertiesInInspector;
            /*0x118*/ Unity.Cinemachine.CinemachineCore.Stage[] m_LockStageInInspector;
            /*0x120*/ Unity.Cinemachine.CinemachineVirtualCamera.LegacyTransitionParams m_LegacyTransitions;
            /*0x130*/ Unity.Cinemachine.CameraState m_State;
            /*0x240*/ Unity.Cinemachine.CinemachineComponentBase[] m_ComponentPipeline;
            /*0x248*/ UnityEngine.Transform m_ComponentOwner;
            /*0x250*/ Unity.Cinemachine.LensSettings m_LensSettings;
            /*0x2a8*/ UnityEngine.Transform mCachedLookAtTarget;
            /*0x2b0*/ Unity.Cinemachine.CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

            static /*0x79c1f38*/ void SetFlagsForHiddenChild(UnityEngine.GameObject child);
            /*0x79c2718*/ CinemachineVirtualCamera();
            /*0x79c00d4*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x79c016c*/ bool get_IsDprecated();
            /*0x79c0174*/ Unity.Cinemachine.CameraState get_State();
            /*0x79c0184*/ UnityEngine.Transform get_LookAt();
            /*0x79c0190*/ void set_LookAt(UnityEngine.Transform value);
            /*0x79c0198*/ UnityEngine.Transform get_Follow();
            /*0x79c01a4*/ void set_Follow(UnityEngine.Transform value);
            /*0x79c01ac*/ float GetMaxDampTime();
            /*0x79c0934*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79c0fb0*/ void OnEnable();
            /*0x79c1134*/ void OnDestroy();
            /*0x79c14bc*/ void OnValidate();
            /*0x79c15a8*/ void OnTransformChildrenChanged();
            /*0x79c15bc*/ void Reset();
            /*0x79c15e4*/ void DestroyPipeline();
            /*0x79c1c98*/ UnityEngine.Transform CreatePipeline(Unity.Cinemachine.CinemachineVirtualCamera copyFrom);
            /*0x79c1120*/ void InvalidateComponentPipeline();
            /*0x79c1e94*/ UnityEngine.Transform GetComponentOwner();
            /*0x79c1e7c*/ Unity.Cinemachine.CinemachineComponentBase[] GetComponentPipeline();
            /*0x79c1eac*/ Unity.Cinemachine.CinemachineComponentBase GetCinemachineComponent(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x3910ae8*/ T GetCinemachineComponent<T>();
            /*0x3910ae8*/ T AddCinemachineComponent<T>();
            /*0x38159dc*/ void DestroyCinemachineComponent<T>();
            /*0x79c023c*/ void UpdateComponentPipeline();
            /*0x79c0b2c*/ Unity.Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79c1fc8*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79c2140*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79c2290*/ void SetStateRawPosition(UnityEngine.Vector3 pos);
            /*0x79c22a0*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79c260c*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();

            struct LegacyTransitionParams
            {
                /*0x10*/ int m_BlendHint;
                /*0x14*/ bool m_InheritPosition;
                /*0x18*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent m_OnCameraLive;
            }

            class CreatePipelineDelegate : System.MulticastDelegate
            {
                /*0x79c298c*/ CreatePipelineDelegate(object object, nint method);
                /*0x79c2a98*/ UnityEngine.Transform Invoke(Unity.Cinemachine.CinemachineVirtualCamera vcam, string name, Unity.Cinemachine.CinemachineComponentBase[] copyFrom);
                /*0x79c2aac*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.CinemachineVirtualCamera vcam, string name, Unity.Cinemachine.CinemachineComponentBase[] copyFrom, System.AsyncCallback callback, object object);
                /*0x79c2ae0*/ UnityEngine.Transform EndInvoke(System.IAsyncResult result);
            }

            class DestroyPipelineDelegate : System.MulticastDelegate
            {
                /*0x79c2aec*/ DestroyPipelineDelegate(object object, nint method);
                /*0x79c2b9c*/ void Invoke(UnityEngine.GameObject pipeline);
                /*0x79c2bb0*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject pipeline, System.AsyncCallback callback, object object);
                /*0x79c2bd0*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineVirtualCamera.<> <>9;
                static /*0x8*/ System.Comparison<Unity.Cinemachine.CinemachineComponentBase> <>9__44_0;

                static /*0x79c2bdc*/ <>c();
                /*0x79c2c44*/ <>c();
                /*0x79c2c4c*/ int <UpdateComponentPipeline>b__44_0(Unity.Cinemachine.CinemachineComponentBase c1, Unity.Cinemachine.CinemachineComponentBase c2);
            }
        }

        class VcamTargetPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79c2c9c*/ VcamTargetPropertyAttribute();
        }

        struct LegacyLensSettings
        {
            /*0x10*/ float FieldOfView;
            /*0x14*/ float OrthographicSize;
            /*0x18*/ float NearClipPlane;
            /*0x1c*/ float FarClipPlane;
            /*0x20*/ float Dutch;
            /*0x24*/ Unity.Cinemachine.LensSettings.OverrideModes ModeOverride;
            /*0x28*/ UnityEngine.Camera.GateFitMode GateFit;
            /*0x2c*/ UnityEngine.Vector2 m_SensorSize;
            /*0x34*/ UnityEngine.Vector2 LensShift;
            /*0x3c*/ float FocusDistance;
            /*0x40*/ int Iso;
            /*0x44*/ float ShutterSpeed;
            /*0x48*/ float Aperture;
            /*0x4c*/ int BladeCount;
            /*0x50*/ UnityEngine.Vector2 Curvature;
            /*0x58*/ float BarrelClipping;
            /*0x5c*/ float Anamorphism;

            static /*0x79c28e8*/ Unity.Cinemachine.LegacyLensSettings get_Default();
            /*0x79c1088*/ Unity.Cinemachine.LensSettings ToLensSettings();
            /*0x79c2ca4*/ void SetFromLensSettings(Unity.Cinemachine.LensSettings src);
            /*0x79c14c4*/ void Validate();
        }

        class CinemachineBrainEvents : Unity.Cinemachine.CinemachineMixerEventsBase
        {
            /*0x48*/ Unity.Cinemachine.CinemachineBrain Brain;
            /*0x50*/ Unity.Cinemachine.CinemachineCore.BrainEvent BrainUpdatedEvent;

            /*0x79c3494*/ CinemachineBrainEvents();
            /*0x79c2d30*/ Unity.Cinemachine.ICinemachineMixer GetMixer();
            /*0x79c2d38*/ void OnEnable();
            /*0x79c30f0*/ void OnDisable();
            /*0x79c33e8*/ void OnCameraUpdated(Unity.Cinemachine.CinemachineBrain brain);
        }

        class CinemachineCameraEvents : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachineVirtualCameraBase EventTarget;
            /*0x28*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraActivatedEvent;
            /*0x30*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraDeactivatedEvent;
            /*0x38*/ Unity.Cinemachine.CinemachineCore.BlendEvent BlendCreatedEvent;
            /*0x40*/ Unity.Cinemachine.CinemachineCore.CameraEvent BlendFinishedEvent;

            /*0x79c3cf4*/ CinemachineCameraEvents();
            /*0x79c3614*/ void OnEnable();
            /*0x79c38cc*/ void OnDisable();
            /*0x79c3aec*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x79c3b60*/ void OnBlendCreated(Unity.Cinemachine.CinemachineCore.BlendEventParams evt);
            /*0x79c3bec*/ void OnBlendFinished(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
            /*0x79c3c70*/ void OnCameraDeactivated(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
        }

        class CinemachineCameraManagerEvents : Unity.Cinemachine.CinemachineMixerEventsBase
        {
            /*0x48*/ Unity.Cinemachine.CinemachineCameraManagerBase CameraManager;

            /*0x79c3e94*/ CinemachineCameraManagerEvents();
            /*0x79c3de8*/ Unity.Cinemachine.ICinemachineMixer GetMixer();
            /*0x79c3df0*/ void OnEnable();
            /*0x79c3e90*/ void OnDisable();
        }

        class CinemachineInputAxisController : Unity.Cinemachine.InputAxisControllerBase<Unity.Cinemachine.CinemachineInputAxisController.Reader>
        {
            static /*0x0*/ Unity.Cinemachine.CinemachineInputAxisController.SetControlDefaultsForAxis SetControlDefaults;
            /*0x30*/ int PlayerIndex;
            /*0x34*/ bool AutoEnableInputs;
            /*0x38*/ Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader ReadControlValueOverride;

            /*0x79c3fec*/ CinemachineInputAxisController();
            /*0x79c3e98*/ void Reset();
            /*0x79c3ef4*/ void InitializeControllerDefaultsForAxis(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller);
            /*0x79c3f68*/ void Update();

            class SetControlDefaultsForAxis : System.MulticastDelegate
            {
                /*0x79c4044*/ SetControlDefaultsForAxis(object object, nint method);
                /*0x79c40f8*/ void Invoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, ref Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller);
                /*0x79c410c*/ System.IAsyncResult BeginInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, ref Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller, System.AsyncCallback callback, object object);
                /*0x79c41a4*/ void EndInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, ref Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller, System.IAsyncResult result);
            }

            class Reader : Unity.Cinemachine.IInputAxisReader
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionReference InputAction;
                /*0x18*/ float Gain;
                /*0x20*/ UnityEngine.InputSystem.InputAction m_CachedAction;
                /*0x28*/ bool CancelDeltaTime;

                static /*0x79c4568*/ UnityEngine.InputSystem.InputAction <ResolveAndReadInputAction>g__GetFirstMatch|6_0(ref UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.InputActionReference aRef);
                /*0x79c4ba8*/ Reader();
                /*0x79c41c0*/ float GetValue(UnityEngine.Object context, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint);
                /*0x79c42c8*/ float ResolveAndReadInputAction(Unity.Cinemachine.CinemachineInputAxisController context, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint);
                /*0x79c48a0*/ float ReadInput(UnityEngine.InputSystem.InputAction action, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint, UnityEngine.Object context, Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader defaultReader);

                class ControlValueReader : System.MulticastDelegate
                {
                    /*0x79c47ec*/ ControlValueReader(object object, nint method);
                    /*0x79c4bb8*/ float Invoke(UnityEngine.InputSystem.InputAction action, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint, UnityEngine.Object context, Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader defaultReader);
                    /*0x79c4bcc*/ System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.InputAction action, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint, UnityEngine.Object context, Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader defaultReader, System.AsyncCallback callback, object object);
                    /*0x79c4c7c*/ float EndInvoke(System.IAsyncResult result);
                }
            }
        }

        class CinemachineMixerEventsBase : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraActivatedEvent;
            /*0x28*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraDeactivatedEvent;
            /*0x30*/ Unity.Cinemachine.CinemachineCore.BlendEvent BlendCreatedEvent;
            /*0x38*/ Unity.Cinemachine.CinemachineCore.CameraEvent BlendFinishedEvent;
            /*0x40*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraCutEvent;

            /*0x79c34fc*/ CinemachineMixerEventsBase();
            /*0x38148bc*/ Unity.Cinemachine.ICinemachineMixer GetMixer();
            /*0x79c2eb0*/ void InstallHandlers(Unity.Cinemachine.ICinemachineMixer mixer);
            /*0x79c31c8*/ void UninstallHandlers();
            /*0x79c4ca4*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x79c4d58*/ void OnCameraDeactivated(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
            /*0x79c4de8*/ void OnBlendCreated(Unity.Cinemachine.CinemachineCore.BlendEventParams evt);
            /*0x79c4e78*/ void OnBlendFinished(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
        }

        class CinemachineSplineSmoother : UnityEngine.MonoBehaviour
        {
            /*0x20*/ bool AutoSmooth;

            /*0x79c53c0*/ CinemachineSplineSmoother();
            /*0x79c4f08*/ void SmoothSplineNow();
        }

        class CinemachineTriggerAction : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.LayerMask LayerMask;
            /*0x28*/ string WithTag;
            /*0x30*/ string WithoutTag;
            /*0x38*/ int SkipFirst;
            /*0x3c*/ bool Repeating;
            /*0x40*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings OnObjectEnter;
            /*0x68*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings OnObjectExit;
            /*0x90*/ System.Collections.Generic.HashSet<UnityEngine.GameObject> m_ActiveTriggerObjects;

            /*0x79c5b6c*/ CinemachineTriggerAction();
            /*0x79c53d0*/ bool Filter(UnityEngine.GameObject other);
            /*0x79c5474*/ void InternalDoTriggerEnter(UnityEngine.GameObject other);
            /*0x79c5960*/ void InternalDoTriggerExit(UnityEngine.GameObject other);
            /*0x79c5a08*/ void OnTriggerEnter(UnityEngine.Collider other);
            /*0x79c5a34*/ void OnTriggerExit(UnityEngine.Collider other);
            /*0x79c5a60*/ void OnCollisionEnter(UnityEngine.Collision other);
            /*0x79c5a8c*/ void OnCollisionExit(UnityEngine.Collision other);
            /*0x79c5ab8*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
            /*0x79c5ae4*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
            /*0x79c5b10*/ void OnCollisionEnter2D(UnityEngine.Collision2D other);
            /*0x79c5b3c*/ void OnCollisionExit2D(UnityEngine.Collision2D other);
            /*0x79c5b68*/ void OnEnable();

            struct ActionSettings
            {
                /*0x10*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.ActionModes Action;
                /*0x18*/ UnityEngine.Object Target;
                /*0x20*/ int BoostAmount;
                /*0x24*/ float StartTime;
                /*0x28*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModes Mode;
                /*0x30*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.TriggerEvent Event;

                /*0x79c5cbc*/ ActionSettings(Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.ActionModes action);
                /*0x79c550c*/ void Invoke();

                enum ActionModes
                {
                    EventOnly = 0,
                    PriorityBoost = 1,
                    Activate = 2,
                    Deactivate = 3,
                    Enable = 4,
                    Disable = 5,
                    Play = 6,
                    Stop = 7,
                }

                class TriggerEvent : UnityEngine.Events.UnityEvent
                {
                    /*0x79c5d44*/ TriggerEvent();
                }

                enum TimeModes
                {
                    FromStart = 0,
                    FromEnd = 1,
                    BeforeNow = 2,
                    AfterNow = 3,
                }
            }
        }

        class GroupWeightManipulator : UnityEngine.MonoBehaviour
        {
            /*0x20*/ float Weight0;
            /*0x24*/ float Weight1;
            /*0x28*/ float Weight2;
            /*0x2c*/ float Weight3;
            /*0x30*/ float Weight4;
            /*0x34*/ float Weight5;
            /*0x38*/ float Weight6;
            /*0x3c*/ float Weight7;
            /*0x40*/ Unity.Cinemachine.CinemachineTargetGroup m_Group;

            /*0x79c5fe4*/ GroupWeightManipulator();
            /*0x79c5d4c*/ void Start();
            /*0x79c5d98*/ void OnValidate();
            /*0x79c5de0*/ void Update();
            /*0x79c5e58*/ void UpdateWeights();
        }

        class CinemachineCollisionImpulseSource : Unity.Cinemachine.CinemachineImpulseSource
        {
            /*0x34*/ UnityEngine.LayerMask LayerMask;
            /*0x38*/ string IgnoreTag;
            /*0x40*/ bool UseImpactDirection;
            /*0x41*/ bool ScaleImpactWithMass;
            /*0x42*/ bool ScaleImpactWithSpeed;
            /*0x48*/ UnityEngine.Rigidbody m_RigidBody;
            /*0x50*/ UnityEngine.Rigidbody2D m_RigidBody2D;

            /*0x79c6c14*/ CinemachineCollisionImpulseSource();
            /*0x79c5ff4*/ void Reset();
            /*0x79c603c*/ void Start();
            /*0x79c60b4*/ void OnEnable();
            /*0x79c60b8*/ void OnCollisionEnter(UnityEngine.Collision c);
            /*0x79c63ec*/ void OnTriggerEnter(UnityEngine.Collider c);
            /*0x79c6448*/ float GetMassAndVelocity(UnityEngine.Collider other, ref UnityEngine.Vector3 vel);
            /*0x79c6100*/ void GenerateImpactEvent(UnityEngine.Collider other, UnityEngine.Vector3 vel);
            /*0x79c6668*/ void OnCollisionEnter2D(UnityEngine.Collision2D c);
            /*0x79c69a0*/ void OnTriggerEnter2D(UnityEngine.Collider2D c);
            /*0x79c69fc*/ float GetMassAndVelocity2D(UnityEngine.Collider2D other2d, ref UnityEngine.Vector3 vel);
            /*0x79c66b4*/ void GenerateImpactEvent2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3 vel);
        }

        class CinemachineFixedSignal : Unity.Cinemachine.SignalSourceAsset
        {
            /*0x18*/ UnityEngine.AnimationCurve XCurve;
            /*0x20*/ UnityEngine.AnimationCurve YCurve;
            /*0x28*/ UnityEngine.AnimationCurve ZCurve;

            /*0x79c6e58*/ CinemachineFixedSignal();
            /*0x79c6c5c*/ float get_SignalDuration();
            /*0x79c6ca4*/ float AxisDuration(UnityEngine.AnimationCurve axis);
            /*0x79c6d64*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            /*0x79c6e0c*/ float AxisValue(UnityEngine.AnimationCurve axis, float time);
        }

        class CinemachineImpulseDefinition
        {
            static /*0x0*/ UnityEngine.AnimationCurve[] s_StandardShapes;
            /*0x10*/ int ImpulseChannel;
            /*0x14*/ Unity.Cinemachine.CinemachineImpulseDefinition.ImpulseShapes ImpulseShape;
            /*0x18*/ UnityEngine.AnimationCurve CustomImpulseShape;
            /*0x20*/ float ImpulseDuration;
            /*0x24*/ Unity.Cinemachine.CinemachineImpulseDefinition.ImpulseTypes ImpulseType;
            /*0x28*/ float DissipationRate;
            /*0x30*/ Unity.Cinemachine.SignalSourceAsset RawSignal;
            /*0x38*/ float AmplitudeGain;
            /*0x3c*/ float FrequencyGain;
            /*0x40*/ Unity.Cinemachine.CinemachineImpulseDefinition.RepeatModes RepeatMode;
            /*0x44*/ bool Randomize;
            /*0x48*/ Unity.Cinemachine.CinemachineImpulseManager.EnvelopeDefinition TimeEnvelope;
            /*0x68*/ float ImpactRadius;
            /*0x6c*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionModes DirectionMode;
            /*0x70*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModes DissipationMode;
            /*0x74*/ float DissipationDistance;
            /*0x78*/ float PropagationSpeed;

            static /*0x79c6f34*/ void CreateStandardShapes();
            static /*0x79c7b9c*/ UnityEngine.AnimationCurve GetStandardCurve(Unity.Cinemachine.CinemachineImpulseDefinition.ImpulseShapes shape);
            /*0x79c844c*/ CinemachineImpulseDefinition();
            /*0x79c6e60*/ void OnValidate();
            /*0x79c7c1c*/ UnityEngine.AnimationCurve get_ImpulseCurve();
            /*0x79c7c6c*/ void CreateEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79c7c70*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79c7e88*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);

            enum ImpulseShapes
            {
                Custom = 0,
                Recoil = 1,
                Bump = 2,
                Explosion = 3,
                Rumble = 4,
            }

            enum ImpulseTypes
            {
                Uniform = 0,
                Dissipating = 1,
                Propagating = 2,
                Legacy = 3,
            }

            enum RepeatModes
            {
                Stretch = 0,
                Loop = 1,
            }

            class SignalSource : Unity.Cinemachine.ISignalSource6D
            {
                /*0x10*/ Unity.Cinemachine.CinemachineImpulseDefinition m_Def;
                /*0x18*/ UnityEngine.Vector3 m_Velocity;

                /*0x79c8218*/ SignalSource(Unity.Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity);
                /*0x79c852c*/ float get_SignalDuration();
                /*0x79c8548*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            }

            class LegacySignalSource : Unity.Cinemachine.ISignalSource6D
            {
                /*0x10*/ Unity.Cinemachine.CinemachineImpulseDefinition m_Def;
                /*0x18*/ UnityEngine.Vector3 m_Velocity;
                /*0x24*/ float m_StartTimeOffset;

                /*0x79c83a4*/ LegacySignalSource(Unity.Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity);
                /*0x79c85f8*/ float get_SignalDuration();
                /*0x79c8620*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            }
        }

        class CinemachineImpulseListener : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ Unity.Cinemachine.CinemachineCore.Stage ApplyAfter;
            /*0x34*/ int ChannelMask;
            /*0x38*/ float Gain;
            /*0x3c*/ bool Use2DDistance;
            /*0x3d*/ bool UseCameraSpace;
            /*0x40*/ Unity.Cinemachine.CinemachineImpulseListener.ImpulseReaction ReactionSettings;

            /*0x79c935c*/ CinemachineImpulseListener();
            /*0x79c8850*/ void Reset();
            /*0x79c8894*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            struct ImpulseReaction
            {
                /*0x10*/ Unity.Cinemachine.NoiseSettings m_SecondaryNoise;
                /*0x18*/ float AmplitudeGain;
                /*0x1c*/ float FrequencyGain;
                /*0x20*/ float Duration;
                /*0x24*/ float m_CurrentAmount;
                /*0x28*/ float m_CurrentTime;
                /*0x2c*/ float m_CurrentDamping;
                /*0x30*/ bool m_Initialized;
                /*0x34*/ UnityEngine.Vector3 m_NoiseOffsets;

                /*0x79c936c*/ void ReSeed();
                /*0x79c8fcc*/ bool GetReaction(float deltaTime, UnityEngine.Vector3 impulsePos, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            }
        }

        class CinemachineImpulseChannelPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79c93dc*/ CinemachineImpulseChannelPropertyAttribute();
        }

        class CinemachineImpulseManager
        {
            static float Epsilon = 0.00009999999747378752;
            static /*0x0*/ Unity.Cinemachine.CinemachineImpulseManager s_Instance;
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents;
            /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents;
            /*0x20*/ bool IgnoreTimeScale;

            static /*0x79c80b4*/ Unity.Cinemachine.CinemachineImpulseManager get_Instance();
            static /*0x79c93ec*/ void InitializeModule();
            static /*0x79c9508*/ float EvaluateDissipationScale(float spread, float normalizedDistance);
            /*0x79c93e4*/ CinemachineImpulseManager();
            /*0x79c8bb8*/ bool GetImpulseAt(UnityEngine.Vector3 listenerLocation, bool distance2D, int channelMask, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            /*0x79c95a4*/ float get_CurrentTime();
            /*0x79c813c*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent NewImpulseEvent();
            /*0x79c8270*/ void AddImpulseEvent(Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent e);
            /*0x79c9444*/ void Clear();

            struct EnvelopeDefinition
            {
                /*0x10*/ UnityEngine.AnimationCurve AttackShape;
                /*0x18*/ UnityEngine.AnimationCurve DecayShape;
                /*0x20*/ float AttackTime;
                /*0x24*/ float SustainTime;
                /*0x28*/ float DecayTime;
                /*0x2c*/ bool ScaleWithImpact;
                /*0x2d*/ bool HoldForever;

                static /*0x79c9610*/ Unity.Cinemachine.CinemachineImpulseManager.EnvelopeDefinition get_Default();
                /*0x79c9638*/ float get_Duration();
                /*0x79c965c*/ float GetValueAt(float offset);
                /*0x79c9780*/ void ChangeStopTime(float offset, bool forceNoDecay);
                /*0x79c97b0*/ void Clear();
                /*0x79c97e4*/ void Validate();
            }

            class ImpulseEvent
            {
                /*0x10*/ float StartTime;
                /*0x18*/ Unity.Cinemachine.CinemachineImpulseManager.EnvelopeDefinition Envelope;
                /*0x38*/ Unity.Cinemachine.ISignalSource6D SignalSource;
                /*0x40*/ UnityEngine.Vector3 Position;
                /*0x4c*/ float Radius;
                /*0x50*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionModes DirectionMode;
                /*0x54*/ int Channel;
                /*0x58*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModes DissipationMode;
                /*0x5c*/ float DissipationDistance;
                /*0x60*/ float CustomDissipation;
                /*0x64*/ float PropagationSpeed;

                /*0x79c9eb8*/ ImpulseEvent();
                /*0x79c9808*/ bool get_Expired();
                /*0x79c989c*/ void Cancel(float time, bool forceNoDecay);
                /*0x79c98d8*/ float DistanceDecay(float distance);
                /*0x79c99a8*/ bool GetDecayedSignal(UnityEngine.Vector3 listenerPosition, bool use2D, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
                /*0x79c9e0c*/ void Clear();

                enum DirectionModes
                {
                    Fixed = 0,
                    RotateTowardSource = 1,
                }

                enum DissipationModes
                {
                    LinearDecay = 0,
                    SoftDecay = 1,
                    ExponentialDecay = 2,
                }
            }
        }

        class CinemachineImpulseSource : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachineImpulseDefinition ImpulseDefinition;
            /*0x28*/ UnityEngine.Vector3 DefaultVelocity;

            /*0x79ca0f4*/ CinemachineImpulseSource();
            /*0x79c9ec0*/ void OnValidate();
            /*0x79c9edc*/ void Reset();
            /*0x79c9fec*/ void GenerateImpulseAtPositionWithVelocity(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79ca000*/ void GenerateImpulseWithVelocity(UnityEngine.Vector3 velocity);
            /*0x79ca06c*/ void GenerateImpulseWithForce(float force);
            /*0x79ca0cc*/ void GenerateImpulse();
            /*0x79ca0d8*/ void GenerateImpulseAt(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79ca0ec*/ void GenerateImpulse(UnityEngine.Vector3 velocity);
            /*0x79ca0f0*/ void GenerateImpulse(float force);
        }

        class CinemachineExternalImpulseListener : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Vector3 m_ImpulsePosLastFrame;
            /*0x2c*/ UnityEngine.Quaternion m_ImpulseRotLastFrame;
            /*0x3c*/ int ChannelMask;
            /*0x40*/ float Gain;
            /*0x44*/ bool Use2DDistance;
            /*0x45*/ bool UseLocalSpace;
            /*0x48*/ Unity.Cinemachine.CinemachineImpulseListener.ImpulseReaction ReactionSettings;

            /*0x79ca690*/ CinemachineExternalImpulseListener();
            /*0x79ca1a0*/ void Reset();
            /*0x79ca1e0*/ void OnEnable();
            /*0x79ca270*/ void Update();
            /*0x79ca39c*/ void LateUpdate();
        }

        class CinemachineAutoFocus : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ Unity.Cinemachine.CinemachineAutoFocus.FocusTrackingMode FocusTarget;
            /*0x38*/ UnityEngine.Transform CustomTarget;
            /*0x40*/ float FocusDepthOffset;
            /*0x44*/ float Damping;

            /*0x79ca9e8*/ CinemachineAutoFocus();
            /*0x79ca698*/ void Reset();
            /*0x79ca6cc*/ void OnValidate();
            /*0x79ca6e0*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            enum FocusTrackingMode
            {
                None = 0,
                LookAtTarget = 1,
                FollowTarget = 2,
                CustomTarget = 3,
                Camera = 4,
                ScreenCenter = 5,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ float CurrentFocusDistance;

                /*0x79ca9f0*/ VcamExtraState();
            }
        }

        class CinemachinePostProcessing : Unity.Cinemachine.CinemachineExtension
        {
            static /*0x0*/ float s_VolumePriority;
            static /*0x8*/ string sVolumeOwnerName;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume> sVolumes;
            static /*0x18*/ System.Collections.Generic.Dictionary<Unity.Cinemachine.CinemachineBrain, UnityEngine.Rendering.PostProcessing.PostProcessLayer> s_BrainToLayer;
            /*0x30*/ float Weight;
            /*0x34*/ Unity.Cinemachine.CinemachinePostProcessing.FocusTrackingMode FocusTracking;
            /*0x38*/ UnityEngine.Transform FocusTarget;
            /*0x40*/ float FocusOffset;
            /*0x44*/ float <CalculatedFocusDistance>k__BackingField;
            /*0x48*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile Profile;
            /*0x50*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachinePostProcessing.VcamExtraState> m_extraStateCache;

            static /*0x79cbf18*/ CinemachinePostProcessing();
            static /*0x79cb1fc*/ void OnCameraCut(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            static /*0x79cb4f4*/ void ApplyPostFX(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79cb820*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume> GetDynamicBrainVolumes(Unity.Cinemachine.CinemachineBrain brain, UnityEngine.Rendering.PostProcessing.PostProcessLayer ppLayer, int minVolumes);
            static /*0x79cb32c*/ UnityEngine.Rendering.PostProcessing.PostProcessLayer GetPPLayer(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79cbbd8*/ void CleanupLookupTable();
            static /*0x79cbc50*/ void InitializeModule();
            /*0x79cbf08*/ CinemachinePostProcessing();
            /*0x79ca9f8*/ float get_CalculatedFocusDistance();
            /*0x79caa00*/ void set_CalculatedFocusDistance(float value);
            /*0x79caa08*/ bool get_IsValid();
            /*0x79caaa4*/ void OnValidate();
            /*0x79caab8*/ void Reset();
            /*0x79caaec*/ void OnEnable();
            /*0x79cabfc*/ void OnDestroy();
            /*0x79caaf0*/ void InvalidateCachedProfile();
            /*0x79cacc0*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            enum FocusTrackingMode
            {
                None = 0,
                LookAtTarget = 1,
                FollowTarget = 2,
                CustomTarget = 3,
                Camera = 4,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile ProfileCopy;

                /*0x79cc030*/ VcamExtraState();
                /*0x79cb044*/ void CreateProfileCopy(UnityEngine.Rendering.PostProcessing.PostProcessProfile source);
                /*0x79cac18*/ void DestroyProfileCopy();
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachinePostProcessing.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> <>9__29_0;

                static /*0x79cc038*/ <>c();
                /*0x79cc0a0*/ <>c();
                /*0x79cc0a8*/ void <InitializeModule>b__29_0(UnityEngine.SceneManagement.Scene scene);
            }
        }

        class CinemachineVolumeSettings : Unity.Cinemachine.CinemachineExtension
        {
            static string sVolumeOwnerName = "__CMVolumes";
            static /*0x0*/ float s_VolumePriority;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> sVolumes;
            /*0x30*/ float Weight;
            /*0x34*/ Unity.Cinemachine.CinemachineVolumeSettings.FocusTrackingMode FocusTracking;
            /*0x38*/ UnityEngine.Transform FocusTarget;
            /*0x40*/ float FocusOffset;
            /*0x44*/ float <CalculatedFocusDistance>k__BackingField;
            /*0x48*/ UnityEngine.Rendering.VolumeProfile Profile;
            /*0x50*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVolumeSettings.VcamExtraState> m_extraStateCache;

            static /*0x79cd324*/ CinemachineVolumeSettings();
            static /*0x79cc91c*/ void OnCameraCut(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            static /*0x79cca64*/ void ApplyPostFX(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79ccd1c*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GetDynamicBrainVolumes(Unity.Cinemachine.CinemachineBrain brain, int minVolumes);
            static /*0x79cd130*/ void InitializeModule();
            /*0x79cd314*/ CinemachineVolumeSettings();
            /*0x79cc0f4*/ float get_CalculatedFocusDistance();
            /*0x79cc0fc*/ void set_CalculatedFocusDistance(float value);
            /*0x79cc104*/ bool get_IsValid();
            /*0x79cc1a0*/ void InvalidateCachedProfile();
            /*0x79cc354*/ void OnValidate();
            /*0x79cc368*/ void Reset();
            /*0x79cc39c*/ void OnEnable();
            /*0x79cc3a0*/ void OnDestroy();
            /*0x79cc3bc*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            enum FocusTrackingMode
            {
                None = 0,
                LookAtTarget = 1,
                FollowTarget = 2,
                CustomTarget = 3,
                Camera = 4,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Rendering.VolumeProfile ProfileCopy;

                /*0x79cd3c4*/ VcamExtraState();
                /*0x79cc754*/ void CreateProfileCopy(UnityEngine.Rendering.VolumeProfile source);
                /*0x79cc2ac*/ void DestroyProfileCopy();
            }
        }

        class SaveDuringPlayAttribute : System.Attribute
        {
            /*0x79cd3cc*/ SaveDuringPlayAttribute();
        }

        class NoSaveDuringPlayAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79cd3d4*/ NoSaveDuringPlayAttribute();
        }

        struct Point64
        {
            /*0x10*/ long X;
            /*0x18*/ long Y;

            static /*0x79cd9d4*/ bool op_Equality(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            static /*0x79cd9ec*/ bool op_Inequality(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            static /*0x79cda04*/ Unity.Cinemachine.Point64 op_Addition(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            static /*0x79cda10*/ Unity.Cinemachine.Point64 op_Subtraction(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            /*0x79cd3dc*/ Point64(Unity.Cinemachine.Point64 pt);
            /*0x79cd3e4*/ Point64(long x, long y);
            /*0x79cd3ec*/ Point64(double x, double y);
            /*0x79cd55c*/ Point64(Unity.Cinemachine.PointD pt);
            /*0x79cd6cc*/ Point64(Unity.Cinemachine.Point64 pt, double scale);
            /*0x79cd858*/ Point64(Unity.Cinemachine.PointD pt, double scale);
            /*0x79cda1c*/ string ToString();
            /*0x79cdab8*/ bool Equals(object obj);
            /*0x79cdb3c*/ int GetHashCode();
        }

        struct PointD
        {
            /*0x10*/ double x;
            /*0x18*/ double y;

            static /*0x79cdc38*/ bool IsAlmostZero(double value);
            static /*0x79cdca4*/ bool op_Equality(Unity.Cinemachine.PointD lhs, Unity.Cinemachine.PointD rhs);
            static /*0x79cdce0*/ bool op_Inequality(Unity.Cinemachine.PointD lhs, Unity.Cinemachine.PointD rhs);
            /*0x79cdb44*/ PointD(Unity.Cinemachine.PointD pt);
            /*0x79cdb4c*/ PointD(Unity.Cinemachine.Point64 pt);
            /*0x79cdb5c*/ PointD(Unity.Cinemachine.PointD pt, double scale);
            /*0x79cdb6c*/ PointD(Unity.Cinemachine.Point64 pt, double scale);
            /*0x79cdb84*/ PointD(long x, long y);
            /*0x79cdb94*/ PointD(double x, double y);
            /*0x79cdb9c*/ string ToString();
            /*0x79cdd20*/ bool Equals(object obj);
            /*0x79cdd98*/ int GetHashCode();
        }

        struct Rect64
        {
            /*0x10*/ long left;
            /*0x18*/ long top;
            /*0x20*/ long right;
            /*0x28*/ long bottom;

            /*0x79cdda0*/ Rect64(long l, long t, long r, long b);
            /*0x79cddac*/ Rect64(Unity.Cinemachine.Rect64 rec);
            /*0x79cddd0*/ long get_Width();
            /*0x79cdde0*/ void set_Width(long value);
            /*0x79cddf0*/ long get_Height();
            /*0x79cde00*/ void set_Height(long value);
            /*0x79cde10*/ bool IsEmpty();
            /*0x79cde3c*/ Unity.Cinemachine.Point64 MidPoint();
            /*0x79cde68*/ bool Contains(Unity.Cinemachine.Point64 pt);
            /*0x79cdea4*/ bool Contains(Unity.Cinemachine.Rect64 rec);
        }

        struct RectD
        {
            /*0x10*/ double left;
            /*0x18*/ double top;
            /*0x20*/ double right;
            /*0x28*/ double bottom;

            /*0x79cdef0*/ RectD(double l, double t, double r, double b);
            /*0x79cdefc*/ RectD(Unity.Cinemachine.RectD rec);
            /*0x79cdf08*/ double get_Width();
            /*0x79cdf18*/ void set_Width(double value);
            /*0x79cdf28*/ double get_Height();
            /*0x79cdf38*/ void set_Height(double value);
            /*0x79cdf48*/ bool IsEmpty();
            /*0x79cdf74*/ Unity.Cinemachine.PointD MidPoint();
            /*0x79cdf8c*/ bool PtIsInside(Unity.Cinemachine.PointD pt);
        }

        enum ClipType
        {
            None = 0,
            Intersection = 1,
            Union = 2,
            Difference = 3,
            Xor = 4,
        }

        enum PathType
        {
            Subject = 0,
            Clip = 1,
        }

        enum FillRule
        {
            EvenOdd = 0,
            NonZero = 1,
            Positive = 2,
            Negative = 3,
        }

        enum PipResult
        {
            Inside = 0,
            Outside = 1,
            OnEdge = 2,
        }

        class InternalClipper
        {
            static double floatingPointTolerance = 1e-15;
            static double defaultMinimumEdgeLength = 0.1;

            static /*0x79cdfc8*/ double CrossProduct(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2, Unity.Cinemachine.Point64 pt3);
            static /*0x79cdff8*/ double DotProduct(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2, Unity.Cinemachine.Point64 pt3);
            static /*0x79ce028*/ double DotProduct(Unity.Cinemachine.PointD vec1, Unity.Cinemachine.PointD vec2);
            static /*0x79ce038*/ bool GetIntersectPoint(Unity.Cinemachine.Point64 ln1a, Unity.Cinemachine.Point64 ln1b, Unity.Cinemachine.Point64 ln2a, Unity.Cinemachine.Point64 ln2b, ref Unity.Cinemachine.PointD ip);
            static /*0x79ce1dc*/ bool SegmentsIntersect(Unity.Cinemachine.Point64 seg1a, Unity.Cinemachine.Point64 seg1b, Unity.Cinemachine.Point64 seg2a, Unity.Cinemachine.Point64 seg2b);
            static /*0x79ce290*/ Unity.Cinemachine.PointInPolygonResult PointInPolygon(Unity.Cinemachine.Point64 pt, System.Collections.Generic.List<Unity.Cinemachine.Point64> polygon);
        }

        class Clipper
        {
            static /*0x0*/ Unity.Cinemachine.Rect64 MaxInvalidRect64;
            static /*0x20*/ Unity.Cinemachine.RectD MaxInvalidRectD;

            static /*0x79d55c4*/ Clipper();
            static /*0x79ce4e8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Intersect(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce660*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Intersect(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce7d8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce844*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce8b4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce924*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce998*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Difference(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79cea08*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Difference(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79cea7c*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Xor(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ceaec*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Xor(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79ce558*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> BooleanOp(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip);
            static /*0x79ce6d4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> BooleanOp(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, int roundingDecimalPrecision);
            static /*0x79ceb60*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> InflatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double delta, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType, double miterLimit);
            static /*0x79cec10*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> InflatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double delta, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType, double miterLimit, int precision);
            static /*0x79cf264*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> MinkowskiSum(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79cf270*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> MinkowskiDiff(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79cf27c*/ double Area(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79cf438*/ double Area(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79cf5bc*/ double Area(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79cf774*/ double Area(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79cf8f8*/ bool IsPositive(System.Collections.Generic.List<Unity.Cinemachine.Point64> poly);
            static /*0x79cf958*/ bool IsPositive(System.Collections.Generic.List<Unity.Cinemachine.PointD> poly);
            static /*0x79cf9b8*/ string Path64ToString(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79cfb5c*/ string Paths64ToString(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79cfcf8*/ string PathDToString(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79cfe9c*/ string PathsDToString(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79d0038*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> OffsetPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, long dx, long dy);
            static /*0x79d0258*/ Unity.Cinemachine.Point64 ScalePoint64(Unity.Cinemachine.Point64 pt, double scale);
            static /*0x79d0290*/ Unity.Cinemachine.PointD ScalePointD(Unity.Cinemachine.Point64 pt, double scale);
            static /*0x79d02a8*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> ScalePath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, double scale);
            static /*0x79d04f0*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> ScalePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double scale);
            static /*0x79d0764*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> ScalePath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double scale);
            static /*0x79d0994*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> ScalePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double scale);
            static /*0x79d0c08*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> ScalePath64(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double scale);
            static /*0x79ceda4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> ScalePaths64(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double scale);
            static /*0x79d0e2c*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> ScalePathD(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, double scale);
            static /*0x79cf004*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> ScalePathsD(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double scale);
            static /*0x79d1054*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> Path64(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79d1268*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Paths64(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79d14b8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> PathsD(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79d1708*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> PathD(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79d1918*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> TranslatePath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, long dx, long dy);
            static /*0x79d1b38*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> TranslatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, long dx, long dy);
            static /*0x79d1da0*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> TranslatePath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double dx, double dy);
            static /*0x79d1fc0*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> TranslatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double dx, double dy);
            static /*0x79d2228*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> ReversePath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79d22c8*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> ReversePath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79d2368*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79d25b8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79d2808*/ Unity.Cinemachine.Rect64 GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79d2ac8*/ Unity.Cinemachine.RectD GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79d2da4*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> MakePath(int[] arr);
            static /*0x79d2ee0*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> MakePath(long[] arr);
            static /*0x79d301c*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> MakePath(double[] arr);
            static /*0x79d3158*/ double Sqr(double value);
            static /*0x79d3160*/ bool PointsNearEqual(Unity.Cinemachine.PointD pt1, Unity.Cinemachine.PointD pt2, double distanceSqrd);
            static /*0x79d31f4*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> StripNearDuplicates(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double minEdgeLenSqrd, bool isClosedPath);
            static /*0x79d3510*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> StripDuplicates(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosedPath);
            static /*0x79d3748*/ void AddPolyNodeToPaths(Unity.Cinemachine.PolyPath64 polyPath, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79d3900*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> PolyTreeToPaths64(Unity.Cinemachine.PolyTree64 polyTree);
            static /*0x79d3a68*/ void AddPolyNodeToPathsD(Unity.Cinemachine.PolyPathD polyPath, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79d3c20*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> PolyTreeToPathsD(Unity.Cinemachine.PolyTreeD polyTree);
            static /*0x79d3ea8*/ double PerpendicDistFromLineSqrd(Unity.Cinemachine.PointD pt, Unity.Cinemachine.PointD line1, Unity.Cinemachine.PointD line2);
            static /*0x79d3f60*/ double PerpendicDistFromLineSqrd(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Point64 line1, Unity.Cinemachine.Point64 line2);
            static /*0x79d4040*/ void RDP(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int begin, int end, double epsSqrd, System.Collections.Generic.List<bool> flags);
            static /*0x79d42b4*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> RamerDouglasPeucker(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, double epsilon);
            static /*0x79d4524*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> RamerDouglasPeucker(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double epsilon);
            static /*0x79d4784*/ void RDP(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, int begin, int end, double epsSqrd, System.Collections.Generic.List<bool> flags);
            static /*0x79d49d8*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> RamerDouglasPeucker(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double epsilon);
            static /*0x79d4c3c*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> RamerDouglasPeucker(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double epsilon);
            static /*0x79d4e9c*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> TrimCollinear(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isOpen);
            static /*0x79d54b0*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> TrimCollinear(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, int precision, bool isOpen);
            static /*0x79d55c0*/ Unity.Cinemachine.PointInPolygonResult PointInPolygon(Unity.Cinemachine.Point64 pt, System.Collections.Generic.List<Unity.Cinemachine.Point64> polygon);
        }

        enum PointInPolygonResult
        {
            IsOn = 0,
            IsInside = 1,
            IsOutside = 2,
        }

        enum VertexFlags
        {
            None = 0,
            OpenStart = 1,
            OpenEnd = 2,
            LocalMax = 4,
            LocalMin = 8,
        }

        class Vertex
        {
            /*0x10*/ Unity.Cinemachine.Point64 pt;
            /*0x20*/ Unity.Cinemachine.Vertex next;
            /*0x28*/ Unity.Cinemachine.Vertex prev;
            /*0x30*/ Unity.Cinemachine.VertexFlags flags;

            /*0x79d5638*/ Vertex(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.VertexFlags flags, Unity.Cinemachine.Vertex prev);
        }

        struct LocalMinima
        {
            /*0x10*/ Unity.Cinemachine.Vertex vertex;
            /*0x18*/ Unity.Cinemachine.PathType polytype;
            /*0x1c*/ bool isOpen;

            static /*0x79d56c4*/ bool op_Equality(Unity.Cinemachine.LocalMinima lm1, Unity.Cinemachine.LocalMinima lm2);
            static /*0x79d56d0*/ bool op_Inequality(Unity.Cinemachine.LocalMinima lm1, Unity.Cinemachine.LocalMinima lm2);
            /*0x79d5694*/ LocalMinima(Unity.Cinemachine.Vertex vertex, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79d56dc*/ bool Equals(object obj);
            /*0x79d5754*/ int GetHashCode();
        }

        struct IntersectNode
        {
            /*0x10*/ Unity.Cinemachine.Point64 pt;
            /*0x20*/ Unity.Cinemachine.Active edge1;
            /*0x28*/ Unity.Cinemachine.Active edge2;

            /*0x79d5774*/ IntersectNode(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Active edge1, Unity.Cinemachine.Active edge2);
        }

        struct LocMinSorter : System.Collections.Generic.IComparer<Unity.Cinemachine.LocalMinima>
        {
            /*0x79d57ac*/ int Compare(Unity.Cinemachine.LocalMinima locMin1, Unity.Cinemachine.LocalMinima locMin2);
        }

        class OutPt
        {
            /*0x10*/ Unity.Cinemachine.Point64 pt;
            /*0x20*/ Unity.Cinemachine.OutPt next;
            /*0x28*/ Unity.Cinemachine.OutPt prev;
            /*0x30*/ Unity.Cinemachine.OutRec outrec;
            /*0x38*/ Unity.Cinemachine.Joiner joiner;

            /*0x79d57d0*/ OutPt(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.OutRec outrec);
        }

        class OutRec
        {
            /*0x10*/ int idx;
            /*0x18*/ Unity.Cinemachine.OutRec owner;
            /*0x20*/ System.Collections.Generic.List<Unity.Cinemachine.OutRec> splits;
            /*0x28*/ Unity.Cinemachine.Active frontEdge;
            /*0x30*/ Unity.Cinemachine.Active backEdge;
            /*0x38*/ Unity.Cinemachine.OutPt pts;
            /*0x40*/ Unity.Cinemachine.PolyPathBase polypath;
            /*0x48*/ Unity.Cinemachine.Rect64 bounds;
            /*0x68*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> path;
            /*0x70*/ bool isOpen;

            /*0x79d5844*/ OutRec();
        }

        class Joiner
        {
            /*0x10*/ int idx;
            /*0x18*/ Unity.Cinemachine.OutPt op1;
            /*0x20*/ Unity.Cinemachine.OutPt op2;
            /*0x28*/ Unity.Cinemachine.Joiner next1;
            /*0x30*/ Unity.Cinemachine.Joiner next2;
            /*0x38*/ Unity.Cinemachine.Joiner nextH;

            /*0x79d58d8*/ Joiner(System.Collections.Generic.List<Unity.Cinemachine.Joiner> joinerList, Unity.Cinemachine.OutPt op1, Unity.Cinemachine.OutPt op2, Unity.Cinemachine.Joiner nextH);
        }

        class Active
        {
            /*0x10*/ Unity.Cinemachine.Point64 bot;
            /*0x20*/ Unity.Cinemachine.Point64 top;
            /*0x30*/ long curX;
            /*0x38*/ double dx;
            /*0x40*/ int windDx;
            /*0x44*/ int windCount;
            /*0x48*/ int windCount2;
            /*0x50*/ Unity.Cinemachine.OutRec outrec;
            /*0x58*/ Unity.Cinemachine.Active prevInAEL;
            /*0x60*/ Unity.Cinemachine.Active nextInAEL;
            /*0x68*/ Unity.Cinemachine.Active prevInSEL;
            /*0x70*/ Unity.Cinemachine.Active nextInSEL;
            /*0x78*/ Unity.Cinemachine.Active jump;
            /*0x80*/ Unity.Cinemachine.Vertex vertexTop;
            /*0x88*/ Unity.Cinemachine.LocalMinima localMin;
            /*0x98*/ bool isLeftBound;

            /*0x79d5a48*/ Active();
        }

        class ClipperBase
        {
            /*0x10*/ Unity.Cinemachine.ClipType _cliptype;
            /*0x14*/ Unity.Cinemachine.FillRule _fillrule;
            /*0x18*/ Unity.Cinemachine.Active _actives;
            /*0x20*/ Unity.Cinemachine.Active _sel;
            /*0x28*/ Unity.Cinemachine.Joiner _horzJoiners;
            /*0x30*/ System.Collections.Generic.List<Unity.Cinemachine.LocalMinima> _minimaList;
            /*0x38*/ System.Collections.Generic.List<Unity.Cinemachine.IntersectNode> _intersectList;
            /*0x40*/ System.Collections.Generic.List<Unity.Cinemachine.Vertex> _vertexList;
            /*0x48*/ System.Collections.Generic.List<Unity.Cinemachine.OutRec> _outrecList;
            /*0x50*/ System.Collections.Generic.List<Unity.Cinemachine.Joiner> _joinerList;
            /*0x58*/ System.Collections.Generic.List<long> _scanlineList;
            /*0x60*/ int _currentLocMin;
            /*0x68*/ long _currentBotY;
            /*0x70*/ bool _isSortedMinimaList;
            /*0x71*/ bool _hasOpenPaths;
            /*0x72*/ bool _using_polytree;
            /*0x73*/ bool _succeeded;
            /*0x74*/ bool <PreserveCollinear>k__BackingField;
            /*0x75*/ bool <ReverseSolution>k__BackingField;

            static /*0x79d5ca0*/ bool IsOdd(int val);
            static /*0x79d5ca8*/ bool IsHotEdge(Unity.Cinemachine.Active ae);
            static /*0x79d5cc8*/ bool IsOpen(Unity.Cinemachine.Active ae);
            static /*0x79d5ce0*/ bool IsOpenEnd(Unity.Cinemachine.Active ae);
            static /*0x79d5d18*/ bool IsOpenEnd(Unity.Cinemachine.Vertex v);
            static /*0x79d5d38*/ Unity.Cinemachine.Active GetPrevHotEdge(Unity.Cinemachine.Active ae);
            static /*0x79d5d64*/ bool IsFront(Unity.Cinemachine.Active ae);
            static /*0x79d5d8c*/ double GetDx(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            static /*0x79d5dc4*/ long TopX(Unity.Cinemachine.Active ae, long currentY);
            static /*0x79d5ef4*/ bool IsHorizontal(Unity.Cinemachine.Active ae);
            static /*0x79d5f18*/ bool IsHeadingRightHorz(Unity.Cinemachine.Active ae);
            static /*0x79d5f40*/ bool IsHeadingLeftHorz(Unity.Cinemachine.Active ae);
            static /*0x79d5f68*/ void SwapActives(ref Unity.Cinemachine.Active ae1, ref Unity.Cinemachine.Active ae2);
            static /*0x79d5fa4*/ Unity.Cinemachine.PathType GetPolyType(Unity.Cinemachine.Active ae);
            static /*0x79d5fbc*/ bool IsSamePolyType(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            static /*0x79d5fe4*/ Unity.Cinemachine.Point64 GetIntersectPoint(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            static /*0x79d6334*/ void SetDx(Unity.Cinemachine.Active ae);
            static /*0x79d6388*/ Unity.Cinemachine.Vertex NextVertex(Unity.Cinemachine.Active ae);
            static /*0x79d6404*/ bool IsMaxima(Unity.Cinemachine.Vertex vertex);
            static /*0x79d6420*/ bool IsMaxima(Unity.Cinemachine.Active ae);
            static /*0x79d6474*/ Unity.Cinemachine.Vertex GetCurrYMaximaVertex(Unity.Cinemachine.Active ae);
            static /*0x79d64e8*/ Unity.Cinemachine.Active GetHorzMaximaPair(Unity.Cinemachine.Active horz, Unity.Cinemachine.Vertex maxVert);
            static /*0x79d6580*/ void SetSides(Unity.Cinemachine.OutRec outrec, Unity.Cinemachine.Active startEdge, Unity.Cinemachine.Active endEdge);
            static /*0x79d65b8*/ void SwapOutrecs(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            static /*0x79d66b0*/ double Area(Unity.Cinemachine.OutPt op);
            static /*0x79d6708*/ double AreaTriangle(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2, Unity.Cinemachine.Point64 pt3);
            static /*0x79d6750*/ Unity.Cinemachine.OutRec GetRealOutRec(Unity.Cinemachine.OutRec outRec);
            static /*0x79d6768*/ void UncoupleOutRec(Unity.Cinemachine.Active ae);
            static /*0x79d6808*/ void SwapFrontBackSides(Unity.Cinemachine.OutRec outrec);
            static /*0x79d6860*/ bool EdgesAdjacentInAEL(Unity.Cinemachine.IntersectNode inode);
            static /*0x79dca98*/ bool IsValidPath(Unity.Cinemachine.OutPt op);
            static /*0x79dcab8*/ bool AreReallyClose(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            static /*0x79dcb5c*/ bool IsValidClosedPath(Unity.Cinemachine.OutPt op);
            static /*0x79dcca0*/ bool ValueBetween(long val, long end1, long end2);
            static /*0x79dccd8*/ bool ValueEqualOrBetween(long val, long end1, long end2);
            static /*0x79dcd08*/ bool PointBetween(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Point64 corner1, Unity.Cinemachine.Point64 corner2);
            static /*0x79dcd64*/ bool CollinearSegsOverlap(Unity.Cinemachine.Point64 seg1a, Unity.Cinemachine.Point64 seg1b, Unity.Cinemachine.Point64 seg2a, Unity.Cinemachine.Point64 seg2b);
            static /*0x79dce90*/ bool HorzEdgesOverlap(long x1a, long x1b, long x2a, long x2b);
            static /*0x79dd0b0*/ Unity.Cinemachine.OutPt InsertOp(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.OutPt insertAfter);
            static /*0x79dd178*/ Unity.Cinemachine.OutPt DisposeOutPt(Unity.Cinemachine.OutPt op);
            static /*0x79dd4dc*/ Unity.Cinemachine.Joiner FindTrialJoinParent(ref Unity.Cinemachine.Joiner joiner, Unity.Cinemachine.OutPt op);
            static /*0x79dd6c0*/ Unity.Cinemachine.Joiner FindJoinParent(Unity.Cinemachine.Joiner joiner, Unity.Cinemachine.OutPt op);
            static /*0x79de290*/ bool CheckDisposeAdjacent(ref Unity.Cinemachine.OutPt op, Unity.Cinemachine.OutPt guard, Unity.Cinemachine.OutRec outRec);
            static /*0x79de478*/ double DistanceFromLineSqrd(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Point64 linePt1, Unity.Cinemachine.Point64 linePt2);
            static /*0x79de4cc*/ double DistanceSqr(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            static /*0x79de870*/ void UpdateOutrecOwner(Unity.Cinemachine.OutRec outrec);
            /*0x79d5a78*/ ClipperBase();
            /*0x79d5a50*/ bool get_PreserveCollinear();
            /*0x79d5a58*/ void set_PreserveCollinear(bool value);
            /*0x79d5a64*/ bool get_ReverseSolution();
            /*0x79d5a6c*/ void set_ReverseSolution(bool value);
            /*0x79d63bc*/ Unity.Cinemachine.Vertex PrevPrevVertex(Unity.Cinemachine.Active ae);
            /*0x79d6444*/ Unity.Cinemachine.Active GetMaximaPair(Unity.Cinemachine.Active ae);
            /*0x79d67e0*/ bool OutrecIsAscending(Unity.Cinemachine.Active hotEdge);
            /*0x79d689c*/ void ClearSolution();
            /*0x79d6a3c*/ void Clear();
            /*0x79d6aec*/ void Reset();
            /*0x79d6cb0*/ void InsertScanline(long y);
            /*0x79d6d48*/ bool PopScanline(ref long y);
            /*0x79d6e50*/ bool HasLocMinAtY(long y);
            /*0x79d6edc*/ Unity.Cinemachine.LocalMinima PopLocalMinima();
            /*0x79d6f38*/ void AddLocMin(Unity.Cinemachine.Vertex vert, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79d7034*/ void AddPathsToVertexList(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79d77cc*/ void AddSubject(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79d78fc*/ void AddOpenSubject(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79d7908*/ void AddClip(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79d77d8*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79d7914*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79d792c*/ bool IsContributingClosed(Unity.Cinemachine.Active ae);
            /*0x79d7b04*/ bool IsContributingOpen(Unity.Cinemachine.Active ae);
            /*0x79d7b88*/ void SetWindCountForClosedPathEdge(Unity.Cinemachine.Active ae);
            /*0x79d7d24*/ void SetWindCountForOpenPathEdge(Unity.Cinemachine.Active ae);
            /*0x79d7df4*/ bool IsValidAelOrder(Unity.Cinemachine.Active resident, Unity.Cinemachine.Active newcomer);
            /*0x79d8088*/ void InsertLeftEdge(Unity.Cinemachine.Active ae);
            /*0x79d8190*/ void InsertRightEdge(Unity.Cinemachine.Active ae, Unity.Cinemachine.Active ae2);
            /*0x79d81fc*/ void InsertLocalMinimaIntoAEL(long botY);
            /*0x79d9628*/ void PushHorz(Unity.Cinemachine.Active ae);
            /*0x79d966c*/ bool PopHorz(ref Unity.Cinemachine.Active ae);
            /*0x79d96b8*/ bool TestJoinWithPrev1(Unity.Cinemachine.Active e, long currY);
            /*0x79d976c*/ bool TestJoinWithPrev2(Unity.Cinemachine.Active e, Unity.Cinemachine.Point64 currPt);
            /*0x79d987c*/ bool TestJoinWithNext1(Unity.Cinemachine.Active e, long currY);
            /*0x79d9930*/ bool TestJoinWithNext2(Unity.Cinemachine.Active e, Unity.Cinemachine.Point64 currPt);
            /*0x79d8940*/ Unity.Cinemachine.OutPt AddLocalMinPoly(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, Unity.Cinemachine.Point64 pt, bool isNew);
            /*0x79d9a40*/ Unity.Cinemachine.OutPt AddLocalMaxPoly(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, Unity.Cinemachine.Point64 pt);
            /*0x79d9e84*/ void JoinOutrecPaths(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            /*0x79da10c*/ Unity.Cinemachine.OutPt AddOutPt(Unity.Cinemachine.Active ae, Unity.Cinemachine.Point64 pt);
            /*0x79d9440*/ Unity.Cinemachine.OutPt StartOpenPath(Unity.Cinemachine.Active ae, Unity.Cinemachine.Point64 pt);
            /*0x79da26c*/ void UpdateEdgeIntoAEL(Unity.Cinemachine.Active ae);
            /*0x79da478*/ Unity.Cinemachine.Active FindEdgeWithMatchingLocMin(Unity.Cinemachine.Active e);
            /*0x79d8c8c*/ Unity.Cinemachine.OutPt IntersectEdges(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, Unity.Cinemachine.Point64 pt);
            /*0x79da534*/ void DeleteFromAEL(Unity.Cinemachine.Active ae);
            /*0x79da5a0*/ void AdjustCurrXAndCopyToSEL(long topY);
            /*0x79da734*/ void ExecuteInternal(Unity.Cinemachine.ClipType ct, Unity.Cinemachine.FillRule fillRule);
            /*0x79dba18*/ void DoIntersections(long topY);
            /*0x79d69cc*/ void DisposeIntersectNodes();
            /*0x79dc204*/ void AddNewIntersectNode(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, long topY);
            /*0x79dc414*/ Unity.Cinemachine.Active ExtractFromSEL(Unity.Cinemachine.Active ae);
            /*0x79dc464*/ void Insert1Before2InSEL(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            /*0x79dbd2c*/ bool BuildIntersectList(long topY);
            /*0x79dbed0*/ void ProcessIntersectList();
            /*0x79d9354*/ void SwapPositionsInAEL(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            /*0x79dc4dc*/ bool ResetHorzDirection(Unity.Cinemachine.Active horz, Unity.Cinemachine.Active maxPair, ref long leftX, ref long rightX);
            /*0x79dc554*/ bool HorzIsSpike(Unity.Cinemachine.Active horz);
            /*0x79dc5ac*/ bool TrimHorz(Unity.Cinemachine.Active horzEdge, bool preserveCollinear);
            /*0x79da858*/ void DoHorizontal(Unity.Cinemachine.Active horz);
            /*0x79dba44*/ void DoTopOfScanbeam(long y);
            /*0x79dc7b0*/ Unity.Cinemachine.Active DoMaxima(Unity.Cinemachine.Active ae);
            /*0x79dcf18*/ Unity.Cinemachine.Joiner GetHorzTrialParent(Unity.Cinemachine.OutPt op);
            /*0x79dcf78*/ bool OutPtInTrialHorzList(Unity.Cinemachine.OutPt op);
            /*0x79dcfb8*/ bool ValidateClosedPathEx(ref Unity.Cinemachine.OutPt op);
            /*0x79dd004*/ void SafeDisposeOutPts(ref Unity.Cinemachine.OutPt op);
            /*0x79dd1d0*/ void SafeDeleteOutPtJoiners(Unity.Cinemachine.OutPt op);
            /*0x79dc6f0*/ void AddTrialHorzJoin(Unity.Cinemachine.OutPt op);
            /*0x79dd288*/ void DeleteTrialHorzJoin(Unity.Cinemachine.OutPt op);
            /*0x79dd534*/ bool GetHorzExtendedHorzSeg(ref Unity.Cinemachine.OutPt op, ref Unity.Cinemachine.OutPt op2);
            /*0x79db648*/ void ConvertHorzTrialsToJoins();
            /*0x79d8bb0*/ void AddJoin(Unity.Cinemachine.OutPt op1, Unity.Cinemachine.OutPt op2);
            /*0x79dd3b4*/ void DeleteJoin(Unity.Cinemachine.Joiner joiner);
            /*0x79dbc58*/ void ProcessJoinList();
            /*0x79dd708*/ Unity.Cinemachine.OutRec ProcessJoin(Unity.Cinemachine.Joiner j);
            /*0x79de4ec*/ void CompleteSplit(Unity.Cinemachine.OutPt op1, Unity.Cinemachine.OutPt op2, Unity.Cinemachine.OutRec outrec);
            /*0x79d9cd0*/ void CleanCollinear(Unity.Cinemachine.OutRec outrec);
            /*0x79de998*/ Unity.Cinemachine.OutPt DoSplitOp(ref Unity.Cinemachine.OutPt outRecOp, Unity.Cinemachine.OutPt splitOp);
            /*0x79de8b8*/ void FixSelfIntersects(ref Unity.Cinemachine.OutPt op);
            /*0x79deda8*/ bool BuildPath(Unity.Cinemachine.OutPt op, bool reverse, bool isOpen, System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79def64*/ bool BuildPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionClosed, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionOpen);
            /*0x79df2ec*/ bool Path1InsidePath2(Unity.Cinemachine.OutRec or1, Unity.Cinemachine.OutRec or2);
            /*0x79df344*/ Unity.Cinemachine.Rect64 GetBounds(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79df4d4*/ bool DeepCheckOwner(Unity.Cinemachine.OutRec outrec, Unity.Cinemachine.OutRec owner);
            /*0x79df87c*/ bool BuildTree(Unity.Cinemachine.PolyPathBase polytree, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionOpen);
            /*0x79dfc74*/ Unity.Cinemachine.Rect64 GetBounds();

            struct IntersectListSort : System.Collections.Generic.IComparer<Unity.Cinemachine.IntersectNode>
            {
                /*0x79e09a4*/ int Compare(Unity.Cinemachine.IntersectNode a, Unity.Cinemachine.IntersectNode b);
            }
        }

        class Clipper64 : Unity.Cinemachine.ClipperBase
        {
            /*0x79e09d8*/ Clipper64();
            /*0x79e09e0*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79e09ec*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79e09f8*/ void AddSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79e0a08*/ void AddOpenSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79e0a18*/ void AddClip(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79e0a28*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionClosed, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionOpen);
            /*0x79e0b84*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionClosed);
            /*0x79e0c1c*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTree64 polytree, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> openPaths);
            /*0x79e0dd4*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTree64 polytree);
        }

        class ClipperD : Unity.Cinemachine.ClipperBase
        {
            /*0x78*/ double _scale;
            /*0x80*/ double _invScale;

            /*0x79e0e6c*/ ClipperD(int roundingDecimalPrecision);
            /*0x79e0fa0*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79e103c*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79e10d8*/ void AddSubject(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            /*0x79e10e4*/ void AddOpenSubject(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            /*0x79e10f0*/ void AddClip(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            /*0x79e10fc*/ void AddSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            /*0x79e1108*/ void AddOpenSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            /*0x79e1114*/ void AddClip(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            /*0x79e1120*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> solutionClosed, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> solutionOpen);
            /*0x79e162c*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> solutionClosed);
            /*0x79e16c4*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTreeD polytree, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> openPaths);
            /*0x79e1a3c*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTreeD polytree);
        }

        class PolyPathBase : System.Collections.IEnumerable
        {
            /*0x10*/ Unity.Cinemachine.PolyPathBase _parent;
            /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.PolyPathBase> _childs;

            /*0x79e1bbc*/ PolyPathBase(Unity.Cinemachine.PolyPathBase parent);
            /*0x79e1ad4*/ Unity.Cinemachine.PolyPathEnum GetEnumerator();
            /*0x79e1b80*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x79e1b84*/ bool get_IsHole();
            /*0x79e1ba0*/ bool GetIsHole();
            /*0x79e1c58*/ int get_Count();
            /*0x3814a3c*/ Unity.Cinemachine.PolyPathBase AddChild(System.Collections.Generic.List<Unity.Cinemachine.Point64> p);
            /*0x79e0d64*/ void Clear();
        }

        class PolyPathEnum : System.Collections.IEnumerator
        {
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.PolyPathBase> _ppbList;
            /*0x18*/ int position;

            /*0x79e1b48*/ PolyPathEnum(System.Collections.Generic.List<Unity.Cinemachine.PolyPathBase> childs);
            /*0x79e1ca0*/ bool MoveNext();
            /*0x79e1cfc*/ void Reset();
            /*0x79e1d08*/ Unity.Cinemachine.PolyPathBase get_Current();
            /*0x79e1dac*/ object System.Collections.IEnumerator.get_Current();
        }

        class PolyPath64 : Unity.Cinemachine.PolyPathBase
        {
            /*0x20*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> <Polygon>k__BackingField;

            /*0x79e1dc0*/ PolyPath64(Unity.Cinemachine.PolyPathBase parent);
            /*0x79e1db0*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> get_Polygon();
            /*0x79e1db8*/ void set_Polygon(System.Collections.Generic.List<Unity.Cinemachine.Point64> value);
            /*0x79e1dc4*/ Unity.Cinemachine.PolyPathBase AddChild(System.Collections.Generic.List<Unity.Cinemachine.Point64> p);
            /*0x79e1ee4*/ Unity.Cinemachine.PolyPath64 get_Child(int index);
            /*0x79e1fd8*/ double Area();
        }

        class PolyPathD : Unity.Cinemachine.PolyPathBase
        {
            /*0x20*/ double <Scale>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> <Polygon>k__BackingField;

            /*0x79e21c8*/ PolyPathD(Unity.Cinemachine.PolyPathBase parent);
            /*0x79e21a8*/ double get_Scale();
            /*0x79e21b0*/ void set_Scale(double value);
            /*0x79e21b8*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> get_Polygon();
            /*0x79e21c0*/ void set_Polygon(System.Collections.Generic.List<Unity.Cinemachine.PointD> value);
            /*0x79e21cc*/ Unity.Cinemachine.PolyPathBase AddChild(System.Collections.Generic.List<Unity.Cinemachine.Point64> p);
            /*0x79e2364*/ Unity.Cinemachine.PolyPathD get_Child(int index);
            /*0x79e2458*/ double Area();
        }

        class PolyTree64 : Unity.Cinemachine.PolyPath64
        {
            /*0x79e2628*/ PolyTree64();
        }

        class PolyTreeD : Unity.Cinemachine.PolyPathD
        {
            /*0x79e2638*/ PolyTreeD();
            /*0x79e2630*/ double get_Scale();
        }

        class ClipperLibException : System.Exception
        {
            /*0x79e0f38*/ ClipperLibException(string description);
        }

        class Minkowski
        {
            static /*0x79e2640*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> MinkowskiInternal(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isSum, bool isClosed);
            static /*0x79e2fec*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Sum(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79e3074*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Sum(System.Collections.Generic.List<Unity.Cinemachine.PointD> pattern, System.Collections.Generic.List<Unity.Cinemachine.PointD> path, bool isClosed, int decimalPlaces);
            static /*0x79e3170*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Diff(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79e31f8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Diff(System.Collections.Generic.List<Unity.Cinemachine.PointD> pattern, System.Collections.Generic.List<Unity.Cinemachine.PointD> path, bool isClosed, int decimalPlaces);
            /*0x79e32f4*/ Minkowski();
        }

        enum JoinType
        {
            Square = 0,
            Round = 1,
            Miter = 2,
        }

        enum EndType
        {
            Polygon = 0,
            Joined = 1,
            Butt = 2,
            Square = 3,
            Round = 4,
        }

        class PathGroup
        {
            /*0x10*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> _inPaths;
            /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> _outPath;
            /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> _outPaths;
            /*0x28*/ Unity.Cinemachine.JoinType _joinType;
            /*0x2c*/ Unity.Cinemachine.EndType _endType;
            /*0x30*/ bool _pathsReversed;

            /*0x79e32fc*/ PathGroup(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
        }

        class ClipperOffset
        {
            static double TwoPi = 6.283185307179586;
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.PathGroup> _pathGroups;
            /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> _normals;
            /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solution;
            /*0x28*/ double _delta;
            /*0x30*/ double _tmpLimit;
            /*0x38*/ double _stepsPerRad;
            /*0x40*/ Unity.Cinemachine.JoinType _joinType;
            /*0x48*/ double <ArcTolerance>k__BackingField;
            /*0x50*/ bool <MergeGroups>k__BackingField;
            /*0x58*/ double <MiterLimit>k__BackingField;
            /*0x60*/ bool <PreserveCollinear>k__BackingField;
            /*0x61*/ bool <ReverseSolution>k__BackingField;

            static /*0x79e4ab8*/ Unity.Cinemachine.PointD GetUnitNormal(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            /*0x79e3498*/ ClipperOffset(double miterLimit, double arcTolerance, bool preserveCollinear, bool reverseSolution);
            /*0x79e343c*/ double get_ArcTolerance();
            /*0x79e3444*/ void set_ArcTolerance(double value);
            /*0x79e344c*/ bool get_MergeGroups();
            /*0x79e3454*/ void set_MergeGroups(bool value);
            /*0x79e3460*/ double get_MiterLimit();
            /*0x79e3468*/ void set_MiterLimit(double value);
            /*0x79e3470*/ bool get_PreserveCollinear();
            /*0x79e3478*/ void set_PreserveCollinear(bool value);
            /*0x79e3484*/ bool get_ReverseSolution();
            /*0x79e348c*/ void set_ReverseSolution(bool value);
            /*0x79e360c*/ void Clear();
            /*0x79e367c*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79e37ac*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79e38c4*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79e39f4*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79e3b44*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Execute(double delta);
            /*0x79e4b84*/ int GetLowestPolygonIdx(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79e4cfc*/ Unity.Cinemachine.PointD TranslatePoint(Unity.Cinemachine.PointD pt, double dx, double dy);
            /*0x79e4d2c*/ Unity.Cinemachine.PointD ReflectPoint(Unity.Cinemachine.PointD pt, Unity.Cinemachine.PointD pivot);
            /*0x79e4d64*/ bool AlmostZero(double value, double epsilon);
            /*0x79e4dcc*/ double Hypotenuse(double x, double y);
            /*0x79e4e54*/ Unity.Cinemachine.PointD NormalizeVector(Unity.Cinemachine.PointD vec);
            /*0x79e4f70*/ Unity.Cinemachine.PointD GetAvgUnitVector(Unity.Cinemachine.PointD vec1, Unity.Cinemachine.PointD vec2);
            /*0x79e4fb0*/ Unity.Cinemachine.PointD IntersectPoint(Unity.Cinemachine.PointD pt1a, Unity.Cinemachine.PointD pt1b, Unity.Cinemachine.PointD pt2a, Unity.Cinemachine.PointD pt2b);
            /*0x79e5088*/ void DoSquare(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int j, int k);
            /*0x79e54ec*/ void DoMiter(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int j, int k, double cosA);
            /*0x79e56d0*/ void DoRound(Unity.Cinemachine.PathGroup group, Unity.Cinemachine.Point64 pt, Unity.Cinemachine.PointD normal1, Unity.Cinemachine.PointD normal2, double angle);
            /*0x79e5a0c*/ void BuildNormals(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79e5d58*/ void OffsetPoint(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int j, ref int k);
            /*0x79e626c*/ void OffsetPolygon(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79e63c4*/ void OffsetOpenJoined(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79e645c*/ void OffsetOpenPath(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.EndType endType);
            /*0x79e6ca4*/ bool IsFullyOpenEndType(Unity.Cinemachine.EndType et);
            /*0x79e40f0*/ void DoGroupOffset(Unity.Cinemachine.PathGroup group, double delta);
        }

        class CinemachinePlayableMixer : UnityEngine.Playables.PlayableBehaviour
        {
            static /*0x0*/ Unity.Cinemachine.CinemachinePlayableMixer.MasterDirectorDelegate GetMasterPlayableDirector;
            /*0x10*/ int Priority;
            /*0x18*/ Unity.Cinemachine.ICameraOverrideStack m_BrainOverrideStack;
            /*0x20*/ int m_BrainOverrideId;
            /*0x24*/ bool m_PreviewPlay;

            /*0x79e7468*/ CinemachinePlayableMixer();
            /*0x79e6cb0*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x79e6d64*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x79e6d6c*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x79e73a4*/ float GetDeltaTime(float deltaTime);

            class MasterDirectorDelegate : System.MulticastDelegate
            {
                /*0x79e7478*/ MasterDirectorDelegate(object object, nint method);
                /*0x79e7514*/ UnityEngine.Playables.PlayableDirector Invoke();
                /*0x79e7528*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x79e7548*/ UnityEngine.Playables.PlayableDirector EndInvoke(System.IAsyncResult result);
            }
        }

        class CinemachineShot : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.IPropertyPreview
        {
            /*0x18*/ string DisplayName;
            /*0x20*/ UnityEngine.ExposedReference<Unity.Cinemachine.CinemachineVirtualCameraBase> VirtualCamera;

            /*0x79e7c6c*/ CinemachineShot();
            /*0x79e7554*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x79e768c*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
        }

        class CinemachineShotPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ Unity.Cinemachine.CinemachineVirtualCameraBase VirtualCamera;

            /*0x79e7c74*/ CinemachineShotPlayable();
            /*0x79e7344*/ bool get_IsValid();
        }

        class CinemachineTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0xa0*/ int TrackPriority;

            /*0x79e7d90*/ CinemachineTrack();
            /*0x79e7c7c*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
        }

        namespace TargetTracking
        {
            enum BindingMode
            {
                LockToTargetOnAssign = 0,
                LockToTargetWithWorldUp = 1,
                LockToTargetNoRoll = 2,
                LockToTarget = 3,
                WorldSpace = 4,
                LazyFollow = 5,
            }

            enum AngularDampingMode
            {
                Euler = 0,
                Quaternion = 1,
            }

            struct TrackerSettings
            {
                /*0x10*/ Unity.Cinemachine.TargetTracking.BindingMode BindingMode;
                /*0x14*/ UnityEngine.Vector3 PositionDamping;
                /*0x20*/ Unity.Cinemachine.TargetTracking.AngularDampingMode AngularDampingMode;
                /*0x24*/ UnityEngine.Vector3 RotationDamping;
                /*0x30*/ float QuaternionDamping;

                static /*0x79e7de8*/ Unity.Cinemachine.TargetTracking.TrackerSettings get_Default();
                /*0x79e7e5c*/ void Validate();
            }

            class TrackerSettingsExtensions
            {
                static /*0x79e7ea0*/ float GetMaxDampTime(Unity.Cinemachine.TargetTracking.TrackerSettings s);
                static /*0x79e7f30*/ UnityEngine.Vector3 GetEffectivePositionDamping(Unity.Cinemachine.TargetTracking.TrackerSettings s);
                static /*0x79e7f4c*/ UnityEngine.Vector3 GetEffectiveRotationDamping(Unity.Cinemachine.TargetTracking.TrackerSettings s);
            }

            struct Tracker
            {
                /*0x10*/ UnityEngine.Vector3 <PreviousTargetPosition>k__BackingField;
                /*0x1c*/ UnityEngine.Quaternion <PreviousReferenceOrientation>k__BackingField;
                /*0x2c*/ UnityEngine.Quaternion m_TargetOrientationOnAssign;
                /*0x3c*/ UnityEngine.Vector3 m_PreviousOffset;
                /*0x48*/ UnityEngine.Transform m_PreviousTarget;

                /*0x79e7fe4*/ UnityEngine.Vector3 get_PreviousTargetPosition();
                /*0x79e7ff0*/ void set_PreviousTargetPosition(UnityEngine.Vector3 value);
                /*0x79e7ffc*/ UnityEngine.Quaternion get_PreviousReferenceOrientation();
                /*0x79e8008*/ void set_PreviousReferenceOrientation(UnityEngine.Quaternion value);
                /*0x79e8014*/ void InitStateInfo(Unity.Cinemachine.CinemachineComponentBase component, float deltaTime, Unity.Cinemachine.TargetTracking.BindingMode bindingMode, UnityEngine.Vector3 up);
                /*0x79e817c*/ UnityEngine.Quaternion GetReferenceOrientation(Unity.Cinemachine.CinemachineComponentBase component, Unity.Cinemachine.TargetTracking.BindingMode bindingMode, UnityEngine.Vector3 worldUp);
                /*0x79e84d4*/ void TrackTarget(Unity.Cinemachine.CinemachineComponentBase component, float deltaTime, UnityEngine.Vector3 up, UnityEngine.Vector3 desiredCameraOffset, ref Unity.Cinemachine.TargetTracking.TrackerSettings settings, ref UnityEngine.Vector3 outTargetPosition, ref UnityEngine.Quaternion outTargetOrient);
                /*0x79e8b98*/ UnityEngine.Vector3 GetOffsetForMinimumTargetDistance(Unity.Cinemachine.CinemachineComponentBase component, UnityEngine.Vector3 dampedTargetPos, UnityEngine.Vector3 cameraOffset, UnityEngine.Vector3 cameraFwd, UnityEngine.Vector3 up, UnityEngine.Vector3 actualTargetPos);
                /*0x79e8f4c*/ void OnTargetObjectWarped(UnityEngine.Vector3 positionDelta);
                /*0x79e8f6c*/ void ForceCameraPosition(Unity.Cinemachine.CinemachineComponentBase component, Unity.Cinemachine.TargetTracking.BindingMode bindingMode, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 cameraOffsetLocalSpace);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C4F7D202F308729E34BBB310F9AC21C4D8B00792BAE838EFBA55C4C6FB443AD;
    static /*0x3494*/ <PrivateImplementationDetails> 1C8C784AAB830B629491D071C7163FDBD48FBD1221C1F24179EE8B37493E9859;
    static /*0x6fac*/ <PrivateImplementationDetails> AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=13460
    {
    }

    struct __StaticArrayInitTypeSize=15128
    {
    }
}
