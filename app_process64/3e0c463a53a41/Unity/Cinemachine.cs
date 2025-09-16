class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x795294c*/ EmbeddedAttribute();
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

                /*0x7952954*/ NullableAttribute(byte );
                /*0x79529dc*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7952a0c*/ NullableContextAttribute(byte );
            }
        }
    }
}

class DeltaTimeScaleProcessor : UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
{
    static /*0x7952a64*/ void Initialize();
    /*0x7952acc*/ DeltaTimeScaleProcessor();
    /*0x7952a34*/ UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7952b14*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7952c08*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            static /*0x7954db0*/ CinemachineBrain();
            static /*0x7953e30*/ int get_ActiveBrainCount();
            static /*0x7953ea0*/ Unity.Cinemachine.CinemachineBrain GetActiveBrain(int index);
            /*0x7954cac*/ CinemachineBrain();
            /*0x7952c10*/ void OnValidate();
            /*0x7952c24*/ void Reset();
            /*0x7952cb8*/ void Awake();
            /*0x7952d90*/ void Start();
            /*0x7953018*/ void OnEnable();
            /*0x79532c0*/ void OnDisable();
            /*0x7953498*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x7953780*/ void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            /*0x79537c8*/ void LateUpdate();
            /*0x7953254*/ System.Collections.IEnumerator AfterPhysics();
            /*0x7953804*/ int SetCameraOverride(int overrideId, int priority, Unity.Cinemachine.ICinemachineCamera camA, Unity.Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime);
            /*0x7953820*/ void ReleaseCameraOverride(int overrideId);
            /*0x795383c*/ UnityEngine.Vector3 get_DefaultWorldUp();
            /*0x7953904*/ string get_Name();
            /*0x795390c*/ string get_Description();
            /*0x7953bec*/ Unity.Cinemachine.CameraState get_State();
            /*0x7953bfc*/ bool get_IsValid();
            /*0x7953c58*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            /*0x7953c60*/ void UpdateCameraState(UnityEngine.Vector3 up, float deltaTime);
            /*0x7953c64*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x7953c68*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera cam, bool dominantChildOnly);
            /*0x7952d10*/ UnityEngine.GameObject get_ControlledObject();
            /*0x7953f20*/ void set_ControlledObject(UnityEngine.GameObject value);
            /*0x7953fa4*/ UnityEngine.Camera get_OutputCamera();
            /*0x7953b08*/ Unity.Cinemachine.ICinemachineCamera get_ActiveVirtualCamera();
            /*0x795407c*/ void ResetState();
            /*0x7953bb4*/ bool get_IsBlending();
            /*0x7953bd0*/ Unity.Cinemachine.CinemachineBlend get_ActiveBlend();
            /*0x7954098*/ void set_ActiveBlend(Unity.Cinemachine.CinemachineBlend value);
            /*0x79540b4*/ bool IsValidChannel(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7954144*/ bool IsLiveInBlend(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x79534e0*/ void ManualUpdate();
            /*0x79546f8*/ void DoFixedUpdate();
            /*0x795429c*/ float GetEffectiveDeltaTime(bool fixedDelta);
            /*0x7952da4*/ void UpdateVirtualCameras(Unity.Cinemachine.CameraUpdateManager.UpdateFilter updateFilter, float deltaTime);
            /*0x7954828*/ Unity.Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue();
            /*0x79548dc*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera fromKey, Unity.Cinemachine.ICinemachineCamera toKey);
            /*0x795442c*/ void ProcessActiveCamera(float deltaTime);
            /*0x79548fc*/ void PushStateToUnityCamera(ref Unity.Cinemachine.CameraState state);

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

                /*0x79537dc*/ <AfterPhysics>d__30(int <>1__state);
                /*0x7954e48*/ void System.IDisposable.Dispose();
                /*0x7954e4c*/ bool MoveNext();
                /*0x7954ec0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7954ec8*/ void System.Collections.IEnumerator.Reset();
                /*0x7954f00*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class CinemachineCamera : Unity.Cinemachine.CinemachineVirtualCameraBase
        {
            /*0xa0*/ Unity.Cinemachine.CameraTarget Target;
            /*0xb8*/ Unity.Cinemachine.LensSettings Lens;
            /*0x110*/ Unity.Cinemachine.CinemachineCore.BlendHints BlendHint;
            /*0x118*/ Unity.Cinemachine.CameraState m_State;
            /*0x228*/ Unity.Cinemachine.CinemachineComponentBase[] m_Pipeline;

            /*0x7955f18*/ CinemachineCamera();
            /*0x7954f08*/ void Reset();
            /*0x7954f60*/ void OnValidate();
            /*0x7954f6c*/ Unity.Cinemachine.CameraState get_State();
            /*0x7954f7c*/ UnityEngine.Transform get_LookAt();
            /*0x7954fac*/ void set_LookAt(UnityEngine.Transform value);
            /*0x7954fbc*/ UnityEngine.Transform get_Follow();
            /*0x7954fc8*/ void set_Follow(UnityEngine.Transform value);
            /*0x7954fd0*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7955354*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7955510*/ float GetMaxDampTime();
            /*0x7955610*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x795596c*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7955b84*/ Unity.Cinemachine.CameraState InvokeComponentPipeline(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7955dd0*/ void InvalidatePipelineCache();
            /*0x7955de4*/ bool get_PipelineCacheInvalidated();
            /*0x7955df4*/ System.Type PeekPipelineCacheType(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x795518c*/ void UpdatePipelineCache();
            /*0x7955ec4*/ Unity.Cinemachine.CinemachineComponentBase GetCinemachineComponent(Unity.Cinemachine.CinemachineCore.Stage stage);
        }

        class CinemachineCameraOffset : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ UnityEngine.Vector3 Offset;
            /*0x3c*/ Unity.Cinemachine.CinemachineCore.Stage ApplyAfter;
            /*0x40*/ bool PreserveComposition;

            /*0x7956248*/ CinemachineCameraOffset();
            /*0x7955fe8*/ void Reset();
            /*0x795604c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
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

            static /*0x7956b10*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> Randomize(System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> src);
            /*0x7956e2c*/ CinemachineClearShot();
            /*0x79562b0*/ void Reset();
            /*0x7956314*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x79564ac*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x795652c*/ void ResetRandomization();
            /*0x7956554*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);

            struct Pair
            {
                /*0x10*/ int a;
                /*0x14*/ float b;
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineClearShot.<> <>9;
                static /*0x8*/ System.Comparison<Unity.Cinemachine.CinemachineClearShot.Pair> <>9__16_0;

                static /*0x7956e34*/ <>c();
                /*0x7956e9c*/ <>c();
                /*0x7956ea4*/ int <Randomize>b__16_0(Unity.Cinemachine.CinemachineClearShot.Pair p1, Unity.Cinemachine.CinemachineClearShot.Pair p2);
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

            static /*0x795848c*/ float CalculateHalfFrustumHeight(ref Unity.Cinemachine.LensSettings lens, ref float cameraPosLocalZ);
            /*0x79586a4*/ CinemachineConfiner2D();
            /*0x7956ee0*/ void OnValidate();
            /*0x7956f48*/ void Reset();
            /*0x7956f60*/ float GetMaxDampTime();
            /*0x7956f7c*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x795707c*/ void InvalidateLensCache();
            /*0x79571e0*/ void InvalidateBoundingShapeCache();
            /*0x79572c4*/ void InvalidateCache();
            /*0x79572e0*/ bool get_BoundingShapeIsBaked();
            /*0x7957300*/ bool BakeBoundingShape(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, float maxTimeInSeconds);
            /*0x7957e08*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7958508*/ UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 pos, Unity.Cinemachine.CinemachineConfiner2D.VcamExtraState extra, UnityEngine.Vector3 fwd);
            /*0x79585cc*/ float GetDistanceFromEdge(UnityEngine.Vector3 p, UnityEngine.Vector3 dirUnit, float max, Unity.Cinemachine.CinemachineConfiner2D.VcamExtraState extra, UnityEngine.Vector3 fwd);

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

                /*0x79586b4*/ VcamExtraState();
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

                static /*0x795895c*/ bool <ValidateCache>g__HasAnyPoints|10_0(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> originalPath);
                /*0x79571fc*/ void Invalidate();
                /*0x79573f4*/ bool ValidateCache(UnityEngine.Collider2D boundingShape2D, Unity.Cinemachine.CinemachineConfiner2D.OversizeWindowSettings oversize, float aspectRatio, ref bool confinerStateChanged);
                /*0x79586bc*/ bool IsValid(ref UnityEngine.Collider2D boundingShape2D, ref Unity.Cinemachine.CinemachineConfiner2D.OversizeWindowSettings oversize, float aspectRatio);
                /*0x795881c*/ void CalculateDeltaTransformationMatrix();
            }
        }

        class CinemachineConfiner3D : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ UnityEngine.Collider BoundingVolume;
            /*0x38*/ float SlowingDistance;

            /*0x7959154*/ CinemachineConfiner3D();
            /*0x7958a10*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7958a28*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7958af8*/ void Reset();
            /*0x7958b1c*/ void OnValidate();
            /*0x7958b30*/ bool get_IsValid();
            /*0x7958bd8*/ float GetMaxDampTime();
            /*0x7958bec*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7958cec*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7958f74*/ UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 p);
            /*0x7959090*/ float GetDistanceFromEdge(UnityEngine.Vector3 p, UnityEngine.Vector3 dirUnit, float max);

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 PreviousDisplacement;
                /*0x24*/ UnityEngine.Vector3 PreviousCameraPosition;

                /*0x795915c*/ VcamExtraState();
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

            static /*0x795a614*/ CinemachineDecollider();
            /*0x795a600*/ CinemachineDecollider();
            /*0x7959164*/ void OnValidate();
            /*0x795917c*/ void Reset();
            /*0x79591f8*/ void OnDestroy();
            /*0x7959258*/ float GetMaxDampTime();
            /*0x7959284*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7959794*/ UnityEngine.Vector3 GetAvoidanceResolutionTargetPoint(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state);
            /*0x795995c*/ float ResolveTerrain(Unity.Cinemachine.CinemachineDecollider.VcamExtraState extra, UnityEngine.Vector3 camPos, UnityEngine.Vector3 up, float deltaTime);
            /*0x7959bac*/ UnityEngine.Vector3 DecollideCamera(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPoint);
            /*0x795a288*/ UnityEngine.Vector3 ApplySmoothingAndDamping(UnityEngine.Vector3 displacement, UnityEngine.Vector3 lookAtPoint, UnityEngine.Vector3 oldCamPos, Unity.Cinemachine.CinemachineDecollider.VcamExtraState extra, float deltaTime);

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

                /*0x795a7b4*/ VcamExtraState();
                /*0x795a4f0*/ float UpdateDistanceSmoothing(float distance, float smoothingTime, bool haveDisplacement);
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineDecollider.<> <>9;

                static /*0x795a7bc*/ <>c();
                /*0x795a824*/ <>c();
                /*0x795a82c*/ int <.cctor>b__21_0(int a, int b);
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

            static /*0x795f320*/ CinemachineDeoccluder();
            static /*0x795e5ec*/ float ClampRayToBounds(UnityEngine.Ray ray, float distance, UnityEngine.Bounds bounds);
            /*0x795f264*/ CinemachineDeoccluder();
            /*0x795a928*/ bool IsTargetObscured(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x795a990*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x795a9a8*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x795aa78*/ void OnValidate();
            /*0x795aae4*/ void Reset();
            /*0x795abf0*/ void OnDestroy();
            /*0x795ac50*/ void OnEnable();
            /*0x795ad50*/ void DebugCollisionPaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> paths, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Collider>> obstacles);
            /*0x795afdc*/ float GetMaxDampTime();
            /*0x795b008*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x795b0a8*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x795bb6c*/ bool GetAvoidanceResolutionTargetPoint(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, ref UnityEngine.Vector3 resolutuionTargetPoint);
            /*0x795bd44*/ UnityEngine.Vector3 PreserveLineOfSight(ref Unity.Cinemachine.CameraState state, ref Unity.Cinemachine.CinemachineDeoccluder.VcamExtraState extra, UnityEngine.Vector3 lookAtPoint);
            /*0x795cffc*/ UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, int layerMask, ref UnityEngine.RaycastHit hitInfo);
            /*0x795d330*/ UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, float targetDistance, int iterations, ref Unity.Cinemachine.CinemachineDeoccluder.VcamExtraState extra);
            /*0x795dc34*/ bool GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, ref UnityEngine.Vector3 outDir);
            /*0x795e3f0*/ float GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, float targetDistance, UnityEngine.Vector3 lookAtPos);
            /*0x795c2a8*/ UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos);
            /*0x795cd18*/ bool IsTargetObscured(Unity.Cinemachine.CameraState state);

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

                static /*0x795ab94*/ Unity.Cinemachine.CinemachineDeoccluder.ObstacleAvoidance get_Default();

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

                static /*0x795abdc*/ Unity.Cinemachine.CinemachineDeoccluder.QualityEvaluation get_Default();
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

                /*0x795f394*/ VcamExtraState();
                /*0x795d32c*/ void AddPointToDebugPath(UnityEngine.Vector3 p, UnityEngine.Collider c);
                /*0x795c18c*/ float ApplyDistanceSmoothing(float distance, float smoothingTime);
                /*0x795c10c*/ void UpdateDistanceSmoothing(float distance);
                /*0x795c230*/ void ResetDistanceSmoothing(float smoothingTime);
            }
        }

        class CinemachineExternalCamera : Unity.Cinemachine.CinemachineVirtualCameraBase
        {
            /*0x9c*/ Unity.Cinemachine.CinemachineCore.BlendHints BlendHint;
            /*0xa0*/ UnityEngine.Transform LookAtTarget;
            /*0xa8*/ UnityEngine.Camera m_Camera;
            /*0xb0*/ Unity.Cinemachine.CameraState m_State;
            /*0x1c0*/ UnityEngine.Transform <Follow>k__BackingField;

            /*0x795f834*/ CinemachineExternalCamera();
            /*0x795f39c*/ Unity.Cinemachine.CameraState get_State();
            /*0x795f3ac*/ UnityEngine.Transform get_LookAt();
            /*0x795f3b4*/ void set_LookAt(UnityEngine.Transform value);
            /*0x795f3bc*/ UnityEngine.Transform get_Follow();
            /*0x795f3c4*/ void set_Follow(UnityEngine.Transform value);
            /*0x795f3d4*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
        }

        class CinemachineFollowZoom : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ float Width;
            /*0x34*/ float Damping;
            /*0x38*/ UnityEngine.Vector2 FovRange;

            /*0x795fbe4*/ CinemachineFollowZoom();
            /*0x795f8d8*/ void Reset();
            /*0x795f8f0*/ void OnValidate();
            /*0x795f934*/ float GetMaxDampTime();
            /*0x795f93c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ float m_PreviousFrameZoom;

                /*0x795fc00*/ VcamExtraState();
            }
        }

        class CinemachineFreeLookModifier : Unity.Cinemachine.CinemachineExtension
        {
            static /*0x0*/ UnityEngine.AnimationCurve s_EasingCurve;
            /*0x30*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineFreeLookModifier.Modifier> Modifiers;
            /*0x38*/ Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource m_ValueSource;
            /*0x40*/ float m_CurrentValue;

            static /*0x383af28*/ void TryGetVcamComponent<T>(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref T component);
            /*0x796014c*/ CinemachineFreeLookModifier();
            /*0x795fc08*/ void OnValidate();
            /*0x795fccc*/ void OnEnable();
            /*0x795fce8*/ void RefreshComponentCache();
            /*0x795fdc8*/ bool HasValueSource();
            /*0x795fde8*/ void PrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7960014*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

            interface IModifierValueSource
            {
                /*0x380c2e4*/ float get_NormalizedModifierValue();
            }

            interface IModifiablePositionDamping
            {
                /*0x380cad0*/ UnityEngine.Vector3 get_PositionDamping();
                /*0x380e380*/ void set_PositionDamping(UnityEngine.Vector3 value);
            }

            interface IModifiableComposition
            {
                Unity.Cinemachine.ScreenComposerSettings get_Composition();
                void set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            }

            interface IModifiableDistance
            {
                /*0x380c2e4*/ float get_Distance();
                /*0x380e050*/ void set_Distance(float value);
            }

            interface IModifiableNoise
            {
                System.ValueTuple<float, float> get_NoiseAmplitudeFrequency();
                void set_NoiseAmplitudeFrequency(System.ValueTuple<float, float> value);
            }

            class Modifier
            {
                /*0x79601f8*/ Modifier();
                /*0x79601d4*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79601d8*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79601dc*/ System.Type get_CachedComponentType();
                /*0x79601e4*/ bool get_HasRequiredComponent();
                /*0x79601ec*/ void RefreshCache(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79601f0*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x79601f4*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class ComponentModifier<T> : Unity.Cinemachine.CinemachineFreeLookModifier.Modifier
            {
                /*0x0*/ T CachedComponent;

                /*0x380cb08*/ ComponentModifier();
                /*0x380b128*/ bool get_HasRequiredComponent();
                /*0x380b9e8*/ System.Type get_CachedComponentType();
                /*0x380d83c*/ void RefreshCache(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            }

            class TiltModifier : Unity.Cinemachine.CinemachineFreeLookModifier.Modifier
            {
                /*0x10*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<float> Tilt;

                /*0x7960418*/ TiltModifier();
                /*0x7960200*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x796022c*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x796023c*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class LensModifier : Unity.Cinemachine.CinemachineFreeLookModifier.Modifier
            {
                /*0x10*/ Unity.Cinemachine.LensSettings Top;
                /*0x68*/ Unity.Cinemachine.LensSettings Bottom;

                /*0x796061c*/ LensModifier();
                /*0x7960420*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7960444*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79605a4*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class PositionDampingModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<UnityEngine.Vector3> Damping;
                /*0x30*/ UnityEngine.Vector3 m_CenterDamping;

                /*0x79609a4*/ PositionDampingModifier();
                /*0x7960624*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x796065c*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7960708*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x79608cc*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class CompositionModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<Unity.Cinemachine.ScreenComposerSettings> Composition;
                /*0x68*/ Unity.Cinemachine.ScreenComposerSettings m_SavedComposition;

                /*0x7960d84*/ CompositionModifier();
                /*0x79609ec*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7960a10*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7960aec*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x7960cac*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class DistanceModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<float> Distance;
                /*0x20*/ float m_CenterDistance;

                /*0x79610c4*/ DistanceModifier();
                /*0x7960dcc*/ void Validate(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7960de4*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x7960e88*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x7961004*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
            }

            class NoiseModifier : Unity.Cinemachine.CinemachineFreeLookModifier.ComponentModifier<Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise>
            {
                /*0x18*/ Unity.Cinemachine.CinemachineFreeLookModifier.TopBottomRigs<Unity.Cinemachine.CinemachineFreeLookModifier.NoiseModifier.NoiseSettings> Noise;
                /*0x28*/ System.ValueTuple<float, float> m_CenterNoise;

                /*0x7961484*/ NoiseModifier();
                /*0x796110c*/ void Reset(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
                /*0x79611b4*/ void BeforePipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);
                /*0x79613c0*/ void AfterPipeline(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState state, float deltaTime, float modifierValue);

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

            /*0x7963230*/ CinemachineGroupFraming();
            /*0x79614cc*/ void OnValidate();
            /*0x7961548*/ void Reset();
            /*0x79615d4*/ float GetMaxDampTime();
            /*0x79615dc*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7961960*/ void OrthoFraming(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.ICinemachineTargetGroup group, Unity.Cinemachine.CinemachineGroupFraming.VcamExtraState extra, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7961d58*/ void PerspectiveFraming(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.ICinemachineTargetGroup group, Unity.Cinemachine.CinemachineGroupFraming.VcamExtraState extra, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x796307c*/ void AdjustSize(Unity.Cinemachine.ICinemachineTargetGroup group, float aspect, ref UnityEngine.Vector3 camPos, ref UnityEngine.Quaternion camRot, ref float fov, ref float dollyAmount);
            /*0x796271c*/ void ComputeCameraViewGroupBounds(Unity.Cinemachine.ICinemachineTargetGroup group, ref UnityEngine.Vector3 camPos, ref UnityEngine.Quaternion camRot, bool moveCamera);
            /*0x79626bc*/ float GetFrameHeight(UnityEngine.Vector2 boundsSize, float aspect);

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

                /*0x79632bc*/ VcamExtraState();
                /*0x79618c8*/ void Reset();
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

            /*0x7964018*/ CinemachineMixingCamera();
            /*0x79632cc*/ void OnValidate();
            /*0x796353c*/ void Reset();
            /*0x7963598*/ Unity.Cinemachine.CameraState get_State();
            /*0x79635a8*/ string get_Description();
            /*0x796331c*/ float GetWeight(int index);
            /*0x796342c*/ void SetWeight(int index, float w);
            /*0x796380c*/ float GetWeight(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x79638a0*/ void SetWeight(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, float w);
            /*0x7963a00*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera vcam, bool dominantChildOnly);
            /*0x7963b10*/ bool UpdateCameraCache();
            /*0x7963c54*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7963d5c*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7964010*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
        }

        class CinemachinePixelPerfect : Unity.Cinemachine.CinemachineExtension
        {
            /*0x7964258*/ CinemachinePixelPerfect();
            /*0x79640c8*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
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

            /*0x7964588*/ CinemachineRecomposer();
            /*0x7964260*/ void Reset();
            /*0x7964280*/ void OnValidate();
            /*0x79642c0*/ void PrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79642dc*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
        }

        class CinemachineSequencerCamera : Unity.Cinemachine.CinemachineCameraManagerBase
        {
            /*0x208*/ bool Loop;
            /*0x210*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineSequencerCamera.Instruction> Instructions;
            /*0x218*/ UnityEngine.Transform m_LegacyLookAt;
            /*0x220*/ UnityEngine.Transform m_LegacyFollow;
            /*0x228*/ float m_ActivationTime;
            /*0x22c*/ int m_CurrentInstruction;

            /*0x7964c78*/ CinemachineSequencerCamera();
            /*0x7964590*/ void Reset();
            /*0x79645b8*/ void OnValidate();
            /*0x79646dc*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x7964874*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79648d4*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7964b84*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming);
            /*0x7964bec*/ bool UpdateCameraCache();
            /*0x7964998*/ void AdvanceCurrentInstruction(float deltaTime);

            struct Instruction
            {
                /*0x10*/ Unity.Cinemachine.CinemachineVirtualCameraBase Camera;
                /*0x18*/ Unity.Cinemachine.CinemachineBlendDefinition Blend;
                /*0x28*/ float Hold;

                /*0x79646c8*/ void Validate();
            }
        }

        class CinemachineShotQualityEvaluator : Unity.Cinemachine.CinemachineExtension, Unity.Cinemachine.IShotQualityEvaluator
        {
            /*0x30*/ UnityEngine.LayerMask OcclusionLayers;
            /*0x38*/ string IgnoreTag;
            /*0x40*/ float MinimumDistanceFromTarget;
            /*0x44*/ float CameraRadius;
            /*0x48*/ Unity.Cinemachine.CinemachineShotQualityEvaluator.DistanceEvaluationSettings DistanceEvaluation;

            /*0x7965244*/ CinemachineShotQualityEvaluator();
            /*0x7964d08*/ void OnValidate();
            /*0x7964d5c*/ void Reset();
            /*0x7964dcc*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7964f9c*/ bool IsTargetObscured(Unity.Cinemachine.CameraState state);

            struct DistanceEvaluationSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float OptimalDistance;
                /*0x18*/ float NearLimit;
                /*0x1c*/ float FarLimit;
                /*0x20*/ float MaxQualityBoost;

                static /*0x7964db8*/ Unity.Cinemachine.CinemachineShotQualityEvaluator.DistanceEvaluationSettings get_Default();
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

            /*0x7965918*/ CinemachineSplineCart();
            /*0x79652a8*/ ref Unity.Cinemachine.SplineSettings get_SplineSettings();
            /*0x79652b0*/ UnityEngine.Splines.SplineContainer get_Spline();
            /*0x79652b8*/ void set_Spline(UnityEngine.Splines.SplineContainer value);
            /*0x79652c0*/ float get_SplinePosition();
            /*0x79652c8*/ void set_SplinePosition(float value);
            /*0x79652d0*/ UnityEngine.Splines.PathIndexUnit get_PositionUnits();
            /*0x79652d8*/ void set_PositionUnits(UnityEngine.Splines.PathIndexUnit value);
            /*0x79652e4*/ void PerformLegacyUpgrade();
            /*0x796539c*/ void OnValidate();
            /*0x796544c*/ void Reset();
            /*0x7965494*/ void OnEnable();
            /*0x7965550*/ void OnDisable();
            /*0x796555c*/ void FixedUpdate();
            /*0x796566c*/ void Update();
            /*0x796588c*/ void LateUpdate();
            /*0x7965570*/ void UpdateCartPosition();
            /*0x79656f4*/ void SetCartPosition(float distanceAlongPath);

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

            /*0x7965b64*/ CinemachineSplineRoll();
            /*0x7965950*/ UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineRoll.RollData> GetInterpolator();
            /*0x79659d0*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x7965ac8*/ void Reset();
            /*0x7965b20*/ void OnEnable();
            /*0x7965b24*/ void OnBeforeSerialize();
            /*0x7965b28*/ void OnAfterDeserialize();

            struct RollData
            {
                /*0x10*/ float Value;

                static /*0x7965b74*/ float op_Implicit(Unity.Cinemachine.CinemachineSplineRoll.RollData roll);
                static /*0x7965ac4*/ Unity.Cinemachine.CinemachineSplineRoll.RollData op_Implicit(float roll);
            }

            struct LerpRollData : UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineRoll.RollData>
            {
                /*0x7965b78*/ Unity.Cinemachine.CinemachineSplineRoll.RollData Interpolate(Unity.Cinemachine.CinemachineSplineRoll.RollData a, Unity.Cinemachine.CinemachineSplineRoll.RollData b, float t);
            }

            struct LerpRollDataWithEasing : UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineRoll.RollData>
            {
                /*0x7965b9c*/ Unity.Cinemachine.CinemachineSplineRoll.RollData Interpolate(Unity.Cinemachine.CinemachineSplineRoll.RollData a, Unity.Cinemachine.CinemachineSplineRoll.RollData b, float t);
            }

            struct RollCache
            {
                /*0x10*/ Unity.Cinemachine.CinemachineSplineRoll m_RollCache;

                /*0x7965bdc*/ void Refresh(UnityEngine.MonoBehaviour owner);
                /*0x7965d34*/ Unity.Cinemachine.CinemachineSplineRoll GetSplineRoll(UnityEngine.MonoBehaviour owner);
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

            static /*0x7965fe0*/ int CreateFakeHash(int parentHash, UnityEngine.AnimationClip clip);
            /*0x7966e38*/ CinemachineStateDrivenCamera();
            /*0x7965d3c*/ void SetParentHash(System.Collections.Generic.List<Unity.Cinemachine.CinemachineStateDrivenCamera.ParentHash> list);
            /*0x7965dac*/ void Reset();
            /*0x7965e48*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x796606c*/ int LookupFakeHash(int parentHash, UnityEngine.AnimationClip clip);
            /*0x79662dc*/ void ValidateInstructions();
            /*0x7966664*/ Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7966c30*/ int GetClipHash(int hash, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
            /*0x7966da4*/ void CancelWait();

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

            static /*0x79685c4*/ void StaticBlendingHandler(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79687b4*/ void InitializeModule();
            /*0x79688d0*/ CinemachineStoryboard();
            /*0x7966f14*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7967034*/ void UpdateRenderCanvas();
            /*0x79671d8*/ void ConnectToVcam(bool connect);
            /*0x7967568*/ string get_CanvasName();
            /*0x79675ec*/ void CameraUpdatedCallback(Unity.Cinemachine.CinemachineBrain brain);
            /*0x796776c*/ Unity.Cinemachine.CinemachineStoryboard.CanvasInfo LocateMyCanvas(Unity.Cinemachine.CinemachineBrain parent, bool createIfNotFound);
            /*0x7967bf8*/ void CreateCanvas(Unity.Cinemachine.CinemachineStoryboard.CanvasInfo ci);
            /*0x7967340*/ void DestroyCanvas();
            /*0x7968090*/ void PlaceImage(Unity.Cinemachine.CinemachineStoryboard.CanvasInfo ci, float alpha);

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

                /*0x7967bf0*/ CanvasInfo();
            }

            enum StoryboardRenderMode
            {
                ScreenSpaceOverlay = 0,
                ScreenSpaceCamera = 1,
            }
        }

        interface ICinemachineTargetGroup
        {
            /*0x380b128*/ bool get_IsValid();
            /*0x380b9e8*/ UnityEngine.Transform get_Transform();
            UnityEngine.Bounds get_BoundingBox();
            UnityEngine.BoundingSphere get_Sphere();
            /*0x380b128*/ bool get_IsEmpty();
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

            static /*0x7969338*/ UnityEngine.BoundingSphere WeightedMemberBoundsForValidMember(Unity.Cinemachine.CinemachineTargetGroup.Target t, UnityEngine.Vector3 avgPos, float maxWeight);
            /*0x796ac0c*/ CinemachineTargetGroup();
            /*0x7968a18*/ void OnValidate();
            /*0x7968b28*/ void Reset();
            /*0x7968ba4*/ void Awake();
            /*0x7968c18*/ Unity.Cinemachine.CinemachineTargetGroup.Target[] get_m_Targets();
            /*0x7968c68*/ void set_m_Targets(Unity.Cinemachine.CinemachineTargetGroup.Target[] value);
            /*0x7968cf8*/ UnityEngine.Transform get_Transform();
            /*0x7968d00*/ bool get_IsValid();
            /*0x7968d5c*/ UnityEngine.Bounds get_BoundingBox();
            /*0x7968eb0*/ void set_BoundingBox(UnityEngine.Bounds value);
            /*0x7968ec4*/ UnityEngine.BoundingSphere get_Sphere();
            /*0x7968f00*/ void set_Sphere(UnityEngine.BoundingSphere value);
            /*0x7968f0c*/ bool get_IsEmpty();
            /*0x7968f78*/ void AddMember(UnityEngine.Transform t, float weight, float radius);
            /*0x79690a0*/ void RemoveMember(UnityEngine.Transform t);
            /*0x7969114*/ int FindMember(UnityEngine.Transform t);
            /*0x79691fc*/ UnityEngine.BoundingSphere GetWeightedBoundsForMember(int index);
            /*0x7969460*/ UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer, bool includeBehind);
            /*0x796981c*/ bool get_CachedCountIsValid();
            /*0x79692cc*/ bool IndexIsValid(int index);
            /*0x7968da4*/ void DoUpdate();
            /*0x7969884*/ void UpdateMemberValidity();
            /*0x7969c68*/ UnityEngine.Vector3 CalculateAveragePosition();
            /*0x7969e00*/ UnityEngine.Bounds CalculateBoundingBox();
            /*0x796a0f4*/ UnityEngine.BoundingSphere CalculateBoundingSphere();
            /*0x796a31c*/ UnityEngine.Quaternion CalculateAverageOrientation();
            /*0x796a65c*/ void FixedUpdate();
            /*0x796a670*/ void Update();
            /*0x796a6e4*/ void LateUpdate();
            /*0x796a6f8*/ void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, ref UnityEngine.Vector2 minAngles, ref UnityEngine.Vector2 maxAngles, ref UnityEngine.Vector2 zRange);

            class Target
            {
                /*0x10*/ UnityEngine.Transform Object;
                /*0x18*/ float Weight;
                /*0x1c*/ float Radius;

                /*0x796908c*/ Target();
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

            /*0x796b520*/ CinemachineThirdPersonAim();
            /*0x796ad4c*/ UnityEngine.Vector3 get_AimTarget();
            /*0x796ad58*/ void set_AimTarget(UnityEngine.Vector3 value);
            /*0x796ad64*/ void OnValidate();
            /*0x796ad78*/ void Reset();
            /*0x796add0*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x796b0cc*/ UnityEngine.Vector3 ComputeLookAtPoint(UnityEngine.Vector3 camPos, UnityEngine.Transform player, UnityEngine.Vector3 fwd);
            /*0x796b328*/ UnityEngine.Vector3 ComputeAimTarget(UnityEngine.Vector3 cameraLookAt, UnityEngine.Transform player);
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

            /*0x796bc4c*/ CinemachineBasicMultiChannelPerlin();
            /*0x796b55c*/ System.ValueTuple<float, float> Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.get_NoiseAmplitudeFrequency();
            /*0x796b5bc*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.set_NoiseAmplitudeFrequency(System.ValueTuple<float, float> value);
            /*0x796b5c4*/ bool get_IsValid();
            /*0x796b644*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x796b64c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x796bbdc*/ void ReSeed();
            /*0x796bae8*/ void Initialize();
        }

        class CinemachineFollow : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ Unity.Cinemachine.TargetTracking.TrackerSettings TrackerSettings;
            /*0x4c*/ UnityEngine.Vector3 FollowOffset;
            /*0x58*/ Unity.Cinemachine.TargetTracking.Tracker m_TargetTracker;

            /*0x796c384*/ CinemachineFollow();
            /*0x796bcc8*/ void OnValidate();
            /*0x796bd24*/ void Reset();
            /*0x796bcfc*/ UnityEngine.Vector3 get_EffectiveOffset();
            /*0x796bdc0*/ bool get_IsValid();
            /*0x796be50*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x796be58*/ float GetMaxDampTime();
            /*0x796be8c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x796c0e4*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x796c1cc*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x796c280*/ UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 up);
            /*0x796c294*/ UnityEngine.Vector3 GetDesiredCameraPosition(UnityEngine.Vector3 worldUp);
        }

        class CinemachineHardLockToTarget : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ float Damping;
            /*0x2c*/ UnityEngine.Vector3 m_PreviousTargetPosition;

            /*0x796c5bc*/ CinemachineHardLockToTarget();
            /*0x796c42c*/ bool get_IsValid();
            /*0x796c4bc*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x796c4c4*/ float GetMaxDampTime();
            /*0x796c4cc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
        }

        class CinemachineHardLookAt : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ UnityEngine.Vector3 LookAtOffset;

            /*0x796c984*/ CinemachineHardLookAt();
            /*0x796c5c4*/ bool get_IsValid();
            /*0x796c654*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x796c65c*/ bool get_CameraLooksAtTarget();
            /*0x796c664*/ void Reset();
            /*0x796c6bc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
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

            static /*0x796cbe0*/ Unity.Cinemachine.InputAxis get_DefaultHorizontal();
            static /*0x796cc28*/ Unity.Cinemachine.InputAxis get_DefaultVertical();
            static /*0x796cc70*/ Unity.Cinemachine.InputAxis get_DefaultRadial();
            static /*0x796f0ac*/ float <InferAxesFromPosition_ThreeRing>g__MapTo01|50_3(float valueToMap, float fMin, float fMax);
            /*0x796eeac*/ CinemachineOrbitalFollow();
            /*0x796c9e4*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x796c9f4*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x796ca04*/ void OnValidate();
            /*0x796ca60*/ void Reset();
            /*0x796ccac*/ bool get_IsValid();
            /*0x796cd3c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x796cd44*/ float GetMaxDampTime();
            /*0x796cd78*/ void Unity.Cinemachine.IInputAxisOwner.GetInputAxes(System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> axes);
            /*0x796d114*/ void Unity.Cinemachine.IInputAxisResetSource.RegisterResetHandler(System.Action handler);
            /*0x796d1a8*/ void Unity.Cinemachine.IInputAxisResetSource.UnregisterResetHandler(System.Action handler);
            /*0x796d23c*/ bool Unity.Cinemachine.IInputAxisResetSource.get_HasResetHandler();
            /*0x796d24c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x796d3e4*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x796d3f0*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x796d3fc*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x796d404*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x796d40c*/ UnityEngine.Vector3 GetCameraOffsetForNormalizedAxisValue(float t);
            /*0x796d260*/ UnityEngine.Vector4 GetCameraPoint();
            /*0x796d8b8*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x796dac0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x796de68*/ void InferAxesFromPosition_Sphere(UnityEngine.Vector3 dir, float distance);
            /*0x796dce4*/ void InferAxesFromPosition_ThreeRing(UnityEngine.Vector3 dir, float distance);
            /*0x796e408*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x796e4f0*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x796ead8*/ void UpdateHorizontalCenter(UnityEngine.Quaternion referenceOrientation);
            /*0x796edd8*/ UnityEngine.Quaternion GetReferenceOrientation();
            /*0x796efd4*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_0();
            /*0x796efdc*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_1();
            /*0x796efe4*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_2();
            /*0x796e014*/ float <InferAxesFromPosition_ThreeRing>g__GetHorizontalAxis|50_0(ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x796e114*/ float <InferAxesFromPosition_ThreeRing>g__GetVerticalAxisClosestValue|50_1(ref UnityEngine.Vector3 splinePoint, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x796efec*/ float <InferAxesFromPosition_ThreeRing>g__SteepestDescent|50_2(UnityEngine.Vector3 cameraOffset, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x796f19c*/ float <InferAxesFromPosition_ThreeRing>g__AngleFunction|50_4(float input, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x796f254*/ float <InferAxesFromPosition_ThreeRing>g__SlopeOfAngleFunction|50_5(float input, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x796f0bc*/ float <InferAxesFromPosition_ThreeRing>g__InitialGuess|50_6(ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );
            /*0x796f2b8*/ void <InferAxesFromPosition_ThreeRing>g__ChooseBestAngle|50_7(float x, ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> , ref Unity.Cinemachine.CinemachineOrbitalFollow.<> );

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

                static /*0x796cbbc*/ Unity.Cinemachine.Cinemachine3OrbitRig.Settings get_Default();
            }

            struct OrbitSplineCache
            {
                /*0x10*/ Unity.Cinemachine.Cinemachine3OrbitRig.Settings OrbitSettings;
                /*0x30*/ UnityEngine.Vector4[] CachedKnots;
                /*0x38*/ UnityEngine.Vector4[] CachedCtrl1;
                /*0x40*/ UnityEngine.Vector4[] CachedCtrl2;

                /*0x796d5e8*/ bool SettingsChanged(ref Unity.Cinemachine.Cinemachine3OrbitRig.Settings other);
                /*0x796d664*/ void UpdateOrbitCache(ref Unity.Cinemachine.Cinemachine3OrbitRig.Settings orbits);
                /*0x796d434*/ UnityEngine.Vector4 SplineValue(float t);
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

            static /*0x796f3c8*/ Unity.Cinemachine.InputAxis get_DefaultPan();
            static /*0x796f410*/ Unity.Cinemachine.InputAxis get_DefaultTilt();
            static /*0x7970450*/ float <GetRecenterTarget>g__NormalizeAngle|31_0(float angle);
            /*0x7970480*/ CinemachinePanTilt();
            /*0x796f2e8*/ void OnValidate();
            /*0x796f33c*/ void Reset();
            /*0x796f454*/ void Unity.Cinemachine.IInputAxisOwner.GetInputAxes(System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> axes);
            /*0x796f6ec*/ void Unity.Cinemachine.IInputAxisResetSource.RegisterResetHandler(System.Action handler);
            /*0x796f77c*/ void Unity.Cinemachine.IInputAxisResetSource.UnregisterResetHandler(System.Action handler);
            /*0x796f80c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x796f844*/ bool Unity.Cinemachine.IInputAxisResetSource.get_HasResetHandler();
            /*0x796f854*/ bool get_IsValid();
            /*0x796f85c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x796f864*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x796f868*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x797000c*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79702ec*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7970020*/ void SetAxesForRotation(UnityEngine.Quaternion targetRot);
            /*0x796fc80*/ UnityEngine.Quaternion GetReferenceFrame(UnityEngine.Vector3 up);
            /*0x796fdd4*/ UnityEngine.Vector2 GetRecenterTarget();
            /*0x7970510*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__14_0();
            /*0x7970518*/ ref Unity.Cinemachine.InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__14_1();

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

            /*0x79713ec*/ CinemachinePositionComposer();
            /*0x7970520*/ void Reset();
            /*0x79705f8*/ void OnValidate();
            /*0x7970640*/ Unity.Cinemachine.ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.get_Composition();
            /*0x7970654*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            /*0x7970668*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x7970674*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x7970680*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x7970688*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x7970690*/ bool get_IsValid();
            /*0x7970720*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7970728*/ bool get_BodyAppliesAfterAim();
            /*0x7970730*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x797073c*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x7970748*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7970844*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79708a8*/ float GetMaxDampTime();
            /*0x79708c4*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7970aa0*/ UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, float orthoSize, float aspect);
            /*0x7970af4*/ UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect);
            /*0x7970bb0*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
        }

        class CinemachineRotateWithFollowTarget : Unity.Cinemachine.CinemachineComponentBase
        {
            /*0x28*/ float Damping;
            /*0x2c*/ UnityEngine.Quaternion m_PreviousReferenceOrientation;

            /*0x7971678*/ CinemachineRotateWithFollowTarget();
            /*0x797148c*/ bool get_IsValid();
            /*0x797151c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7971524*/ float GetMaxDampTime();
            /*0x797152c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
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

            /*0x79729c8*/ CinemachineRotationComposer();
            /*0x79716d0*/ void Reset();
            /*0x7971770*/ void OnValidate();
            /*0x7971794*/ bool get_IsValid();
            /*0x7971824*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x797182c*/ bool get_CameraLooksAtTarget();
            /*0x7971834*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x7971840*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x797184c*/ UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, float deltaTime);
            /*0x7971a08*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7971b14*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7971b78*/ float GetMaxDampTime();
            /*0x7971b88*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7971c0c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x797268c*/ void RotateToScreenBounds(ref Unity.Cinemachine.CameraState state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, ref UnityEngine.Quaternion rigOrientation, float fov, float fovH, float deltaTime);
            /*0x79728b8*/ bool ClampVerticalBounds(ref UnityEngine.Rect r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, float fov);
            /*0x7972998*/ Unity.Cinemachine.ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.get_Composition();
            /*0x79729b0*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.set_Composition(Unity.Cinemachine.ScreenComposerSettings value);

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

                static /*0x7972ae8*/ UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, float fov, float fovH, float aspect);
                /*0x79723cc*/ void UpdateCache(Unity.Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, float targetDistance);
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

            /*0x7973b90*/ CinemachineSplineDolly();
            /*0x7972ef8*/ void PerformLegacyUpgrade();
            /*0x7972fb0*/ ref Unity.Cinemachine.SplineSettings get_SplineSettings();
            /*0x7972fb8*/ UnityEngine.Splines.SplineContainer get_Spline();
            /*0x7972fc0*/ void set_Spline(UnityEngine.Splines.SplineContainer value);
            /*0x7972fc8*/ float get_CameraPosition();
            /*0x7972fd0*/ void set_CameraPosition(float value);
            /*0x7972fd8*/ UnityEngine.Splines.PathIndexUnit get_PositionUnits();
            /*0x7972fe0*/ void set_PositionUnits(UnityEngine.Splines.PathIndexUnit value);
            /*0x7972fec*/ void OnValidate();
            /*0x79730e4*/ void Reset();
            /*0x797316c*/ void OnEnable();
            /*0x7973230*/ void OnDisable();
            /*0x7973254*/ bool get_IsValid();
            /*0x79732d4*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79732dc*/ float GetMaxDampTime();
            /*0x7973314*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7973978*/ UnityEngine.Quaternion GetCameraRotationAtSplinePoint(UnityEngine.Quaternion splineOrientation, UnityEngine.Vector3 up, ref bool isDefault);

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

            /*0x7974198*/ CinemachineSplineDollyLookAtTargets();
            /*0x7973c10*/ void Reset();
            /*0x7973cf4*/ bool get_IsValid();
            /*0x7973e60*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7973e68*/ void MutateCameraState(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7973d40*/ bool GetGetSplineAndDolly(ref UnityEngine.Splines.SplineContainer spline, ref Unity.Cinemachine.CinemachineSplineDolly dolly);

            struct Item
            {
                /*0x10*/ UnityEngine.Transform LookAt;
                /*0x18*/ UnityEngine.Vector3 Offset;
                /*0x24*/ float Easing;

                /*0x7974108*/ UnityEngine.Vector3 get_WorldLookAt();
                /*0x7974288*/ void set_WorldLookAt(UnityEngine.Vector3 value);
            }

            struct LerpItem : UnityEngine.Splines.IInterpolator<Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item>
            {
                /*0x7974340*/ Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item Interpolate(Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item a, Unity.Cinemachine.CinemachineSplineDollyLookAtTargets.Item b, float t);
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

            static /*0x7974d40*/ UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up);
            /*0x7975484*/ CinemachineThirdPersonFollow();
            /*0x7974450*/ UnityEngine.Collider get_CurrentObstacle();
            /*0x7974458*/ void set_CurrentObstacle(UnityEngine.Collider value);
            /*0x7974460*/ void OnValidate();
            /*0x79744c4*/ void Reset();
            /*0x7974584*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x79746fc*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x7974708*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x7974714*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x797471c*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x7974724*/ bool get_IsValid();
            /*0x79747b4*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79747bc*/ float GetMaxDampTime();
            /*0x79747fc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7974c6c*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7974880*/ void PositionCamera(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7975344*/ void GetRigPositions(ref UnityEngine.Vector3 root, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x7974edc*/ void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x7974fcc*/ UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection);

            struct ObstacleSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ UnityEngine.LayerMask CollisionFilter;
                /*0x18*/ string IgnoreTag;
                /*0x20*/ float CameraRadius;
                /*0x24*/ float DampingIntoCollision;
                /*0x28*/ float DampingFromCollision;

                static /*0x7974514*/ Unity.Cinemachine.CinemachineThirdPersonFollow.ObstacleSettings get_Default();
            }
        }

        class BlendManager : Unity.Cinemachine.CameraBlendStack
        {
            /*0x28*/ Unity.Cinemachine.CinemachineBlend m_CurrentLiveCameras;
            /*0x30*/ System.Collections.Generic.HashSet<Unity.Cinemachine.ICinemachineCamera> m_PreviousLiveCameras;
            /*0x38*/ Unity.Cinemachine.ICinemachineCamera m_PreviousActiveCamera;
            /*0x40*/ bool m_WasBlending;

            static /*0x7975640*/ Unity.Cinemachine.ICinemachineCamera DeepCamBFromBlend(Unity.Cinemachine.CinemachineBlend blend);
            static /*0x79765f8*/ void <ProcessActiveCamera>g__CollectLiveCameras|21_0(Unity.Cinemachine.CinemachineBlend blend, ref System.Collections.Generic.HashSet<Unity.Cinemachine.ICinemachineCamera> cams);
            /*0x7976718*/ BlendManager();
            /*0x79754c0*/ void OnEnable();
            /*0x7975638*/ Unity.Cinemachine.ICinemachineCamera get_ActiveVirtualCamera();
            /*0x7975748*/ Unity.Cinemachine.CinemachineBlend get_ActiveBlend();
            /*0x797578c*/ void set_ActiveBlend(Unity.Cinemachine.CinemachineBlend value);
            /*0x79758a0*/ bool get_IsBlending();
            /*0x79758b8*/ string get_Description();
            /*0x7975a40*/ bool IsLiveInBlend(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x7975af4*/ bool IsLive(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x7975b10*/ Unity.Cinemachine.CameraState get_CameraState();
            /*0x7975b58*/ void ComputeCurrentBlend();
            /*0x7975f08*/ void RefreshCurrentCameraState(UnityEngine.Vector3 up, float deltaTime);
            /*0x7975f24*/ Unity.Cinemachine.ICinemachineCamera ProcessActiveCamera(Unity.Cinemachine.ICinemachineMixer mixer, UnityEngine.Vector3 up, float deltaTime);
        }

        interface ICameraOverrideStack
        {
            int SetCameraOverride(int overrideId, int priority, Unity.Cinemachine.ICinemachineCamera camA, Unity.Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime);
            /*0x380cffc*/ void ReleaseCameraOverride(int overrideId);
            /*0x380cad0*/ UnityEngine.Vector3 get_DefaultWorldUp();
        }

        class CameraBlendStack : Unity.Cinemachine.ICameraOverrideStack
        {
            static float kEpsilon = 0.00009999999747378752;
            static /*0x0*/ UnityEngine.AnimationCurve s_DefaultLinearAnimationCurve;
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.CameraBlendStack.StackFrame> m_FrameStack;
            /*0x18*/ int m_NextFrameId;
            /*0x20*/ Unity.Cinemachine.CinemachineBlendDefinition.LookupBlendDelegate <LookupBlendDelegate>k__BackingField;

            static /*0x7977a68*/ CameraBlendStack();
            static /*0x7977898*/ bool <UpdateRootFrame>g__AdvanceBlend|18_0(Unity.Cinemachine.CinemachineBlend blend, float deltaTime);
            /*0x7976800*/ CameraBlendStack();
            /*0x7976888*/ UnityEngine.Vector3 get_DefaultWorldUp();
            /*0x79768cc*/ int SetCameraOverride(int overrideId, int priority, Unity.Cinemachine.ICinemachineCamera camA, Unity.Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime);
            /*0x7976d28*/ void ReleaseCameraOverride(int overrideId);
            /*0x7975530*/ void OnEnable();
            /*0x7976df4*/ void OnDisable();
            /*0x7976e60*/ bool get_IsInitialized();
            /*0x7976eb0*/ Unity.Cinemachine.CinemachineBlendDefinition.LookupBlendDelegate get_LookupBlendDelegate();
            /*0x7976eb8*/ void set_LookupBlendDelegate(Unity.Cinemachine.CinemachineBlendDefinition.LookupBlendDelegate value);
            /*0x7976ec0*/ void ResetRootFrame();
            /*0x7977018*/ void UpdateRootFrame(Unity.Cinemachine.ICinemachineMixer context, Unity.Cinemachine.ICinemachineCamera activeCamera, UnityEngine.Vector3 up, float deltaTime);
            /*0x7975b64*/ void ProcessOverrideFrames(ref Unity.Cinemachine.CinemachineBlend outputBlend, int numTopLayersToExclude);
            /*0x7975790*/ void SetRootBlend(Unity.Cinemachine.CinemachineBlend blend);
            /*0x79779c0*/ float GetDeltaTimeOverride();
            /*0x7976b84*/ int <SetCameraOverride>g__FindFrame|7_0(int withId, int priority);

            class StackFrame : Unity.Cinemachine.NestedBlendSource
            {
                /*0x130*/ int Id;
                /*0x134*/ int Priority;
                /*0x138*/ Unity.Cinemachine.CinemachineBlend Source;
                /*0x140*/ float DeltaTimeOverride;
                /*0x148*/ Unity.Cinemachine.CameraBlendStack.SnapshotBlendSource m_Snapshot;
                /*0x150*/ Unity.Cinemachine.ICinemachineCamera m_SnapshotSource;
                /*0x158*/ float m_SnapshotBlendWeight;

                /*0x7977c4c*/ StackFrame();
                /*0x7977da4*/ bool get_Active();
                /*0x7977edc*/ Unity.Cinemachine.ICinemachineCamera GetSnapshotIfAppropriate(Unity.Cinemachine.ICinemachineCamera cam, float weight);
            }

            class SnapshotBlendSource : Unity.Cinemachine.ICinemachineCamera
            {
                /*0x10*/ Unity.Cinemachine.CameraState m_State;
                /*0x120*/ string m_Name;
                /*0x128*/ float <RemainingTimeInBlend>k__BackingField;

                /*0x7977d34*/ SnapshotBlendSource(Unity.Cinemachine.ICinemachineCamera source, float remainingTimeInBlend);
                /*0x797822c*/ float get_RemainingTimeInBlend();
                /*0x7978234*/ void set_RemainingTimeInBlend(float value);
                /*0x797823c*/ string get_Name();
                /*0x7978244*/ string get_Description();
                /*0x797824c*/ Unity.Cinemachine.CameraState get_State();
                /*0x797825c*/ bool get_IsValid();
                /*0x7978264*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
                /*0x797826c*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
                /*0x7978270*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
                /*0x797801c*/ void TakeSnapshot(Unity.Cinemachine.ICinemachineCamera source);
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

            static /*0x7979ddc*/ CameraState();
            static /*0x7978274*/ Unity.Cinemachine.CameraState get_Default();
            static /*0x7978a84*/ Unity.Cinemachine.CameraState Lerp(ref Unity.Cinemachine.CameraState stateA, ref Unity.Cinemachine.CameraState stateB, float t);
            static /*0x7979a3c*/ float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t);
            static /*0x7979930*/ UnityEngine.Vector3 ApplyPosBlendHint(UnityEngine.Vector3 posA, Unity.Cinemachine.CameraState.BlendHints hintA, UnityEngine.Vector3 posB, Unity.Cinemachine.CameraState.BlendHints hintB, UnityEngine.Vector3 original, UnityEngine.Vector3 blended);
            static /*0x7979970*/ UnityEngine.Quaternion ApplyRotBlendHint(UnityEngine.Quaternion rotA, Unity.Cinemachine.CameraState.BlendHints hintA, UnityEngine.Quaternion rotB, Unity.Cinemachine.CameraState.BlendHints hintB, UnityEngine.Quaternion original, UnityEngine.Quaternion blended);
            static /*0x7979b30*/ UnityEngine.Vector3 InterpolatePosition(UnityEngine.Vector3 posA, UnityEngine.Vector3 pivotA, UnityEngine.Vector3 posB, UnityEngine.Vector3 pivotB, float t, Unity.Cinemachine.CameraState.BlendHints blendHint, UnityEngine.Vector3 up);
            /*0x79785d4*/ void AddCustomBlendable(Unity.Cinemachine.CameraState.CustomBlendableItems.Item b);

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
            static /*0x79799b4*/ bool HasLookAt(Unity.Cinemachine.CameraState s);
            static /*0x7979a1c*/ UnityEngine.Vector3 GetCorrectedPosition(Unity.Cinemachine.CameraState s);
            static /*0x7979e30*/ UnityEngine.Quaternion GetCorrectedOrientation(Unity.Cinemachine.CameraState s);
            static /*0x7979eb4*/ UnityEngine.Vector3 GetFinalPosition(Unity.Cinemachine.CameraState s);
            static /*0x7979ed4*/ UnityEngine.Quaternion GetFinalOrientation(Unity.Cinemachine.CameraState s);
            static /*0x797a014*/ int GetNumCustomBlendables(Unity.Cinemachine.CameraState s);
            static /*0x79789c4*/ Unity.Cinemachine.CameraState.CustomBlendableItems.Item GetCustomBlendable(Unity.Cinemachine.CameraState s, int index);
            static /*0x7978828*/ int FindCustomBlendable(Unity.Cinemachine.CameraState s, UnityEngine.Object custom);
            static /*0x797a01c*/ bool IsTargetOffscreen(Unity.Cinemachine.CameraState state);
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

            static /*0x797b38c*/ CameraUpdateManager();
            static /*0x797a31c*/ void InitializeModule();
            static /*0x797a3bc*/ int get_VirtualCameraCount();
            static /*0x797a420*/ Unity.Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(int index);
            static /*0x797a48c*/ void AddActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797a4f8*/ void RemoveActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797a564*/ void CameraDestroyed(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797a670*/ void CameraEnabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797a6dc*/ void CameraDisabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797a748*/ void ForgetContext(object context);
            static /*0x797a7d8*/ void UpdateAllActiveVirtualCameras(uint channelMask, UnityEngine.Vector3 worldUp, float deltaTime, object context);
            static /*0x797ada8*/ void UpdateVirtualCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Vector3 worldUp, float deltaTime);
            static /*0x797b174*/ UnityEngine.Transform GetUpdateTarget(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797b2c0*/ Unity.Cinemachine.UpdateTracker.UpdateClock GetVcamUpdateStatus(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);

            class UpdateStatus
            {
                /*0x10*/ int lastUpdateFrame;
                /*0x14*/ int lastUpdateFixedFrame;
                /*0x18*/ Unity.Cinemachine.UpdateTracker.UpdateClock lastUpdateMode;

                /*0x797b2b8*/ UpdateStatus();
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

            /*0x7977d2c*/ CinemachineBlend();
            /*0x797b41c*/ float get_BlendWeight();
            /*0x797b4d4*/ Unity.Cinemachine.CinemachineBlend.IBlender get_CustomBlender();
            /*0x797b4dc*/ void set_CustomBlender(Unity.Cinemachine.CinemachineBlend.IBlender value);
            /*0x7977dbc*/ bool get_IsValid();
            /*0x797b4a4*/ bool get_IsComplete();
            /*0x797b4e4*/ string get_Description();
            /*0x797b7b8*/ bool Uses(Unity.Cinemachine.ICinemachineCamera cam);
            /*0x797b8b4*/ void CopyFrom(Unity.Cinemachine.CinemachineBlend src);
            /*0x797b920*/ void ClearBlend();
            /*0x797b960*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797bb8c*/ Unity.Cinemachine.CameraState get_State();

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

            /*0x797c00c*/ CinemachineBlendDefinition(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float time);
            /*0x797bff4*/ float get_BlendTime();
            /*0x797c020*/ void CreateStandardCurves();
            /*0x797c57c*/ UnityEngine.AnimationCurve get_BlendCurve();

            class LookupBlendDelegate : System.MulticastDelegate
            {
                /*0x797c644*/ LookupBlendDelegate(object object, nint method);
                /*0x797c750*/ Unity.Cinemachine.CinemachineBlendDefinition Invoke(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming);
                /*0x797c764*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming, System.AsyncCallback callback, object object);
                /*0x797c78c*/ Unity.Cinemachine.CinemachineBlendDefinition EndInvoke(System.IAsyncResult result);
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

            /*0x7977d74*/ NestedBlendSource(Unity.Cinemachine.CinemachineBlend blend);
            /*0x797c7b8*/ Unity.Cinemachine.CinemachineBlend get_Blend();
            /*0x797c7c0*/ void set_Blend(Unity.Cinemachine.CinemachineBlend value);
            /*0x797c7c8*/ string get_Name();
            /*0x797c8e4*/ string get_Description();
            /*0x797c93c*/ Unity.Cinemachine.CameraState get_State();
            /*0x797c94c*/ void set_State(Unity.Cinemachine.CameraState value);
            /*0x797c970*/ bool get_IsValid();
            /*0x797c980*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            /*0x797c988*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797c9f0*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
        }

        class CinemachineBlenderSettings : UnityEngine.ScriptableObject
        {
            static string kBlendFromAnyCameraLabel = "**ANY CAMERA**";
            /*0x18*/ Unity.Cinemachine.CinemachineBlenderSettings.CustomBlend[] CustomBlends;

            static /*0x797cc18*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend, Unity.Cinemachine.CinemachineBlenderSettings customBlends, UnityEngine.Object owner);
            /*0x797ce68*/ CinemachineBlenderSettings();
            /*0x797c9f4*/ Unity.Cinemachine.CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend);

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

            /*0x797e6cc*/ CinemachineCameraManagerBase();
            /*0x797ce70*/ void Reset();
            /*0x797cee4*/ void OnEnable();
            /*0x797d20c*/ void OnDisable();
            /*0x797d294*/ string get_Description();
            /*0x797d2b0*/ Unity.Cinemachine.CameraState get_State();
            /*0x797d2c0*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera cam, bool dominantChildOnly);
            /*0x797d2dc*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> get_ChildCameras();
            /*0x797d300*/ bool get_PreviousStateIsValid();
            /*0x797d308*/ void set_PreviousStateIsValid(bool value);
            /*0x797d3b0*/ bool get_IsBlending();
            /*0x797d3cc*/ Unity.Cinemachine.CinemachineBlend get_ActiveBlend();
            /*0x797d40c*/ void set_ActiveBlend(Unity.Cinemachine.CinemachineBlend value);
            /*0x797d428*/ Unity.Cinemachine.ICinemachineCamera get_LiveChild();
            /*0x797d468*/ UnityEngine.Transform get_LookAt();
            /*0x797d57c*/ void set_LookAt(UnityEngine.Transform value);
            /*0x797d590*/ UnityEngine.Transform get_Follow();
            /*0x797d690*/ void set_Follow(UnityEngine.Transform value);
            /*0x797d6a0*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797dd90*/ Unity.Cinemachine.CinemachineBlendDefinition LookupBlend(Unity.Cinemachine.ICinemachineCamera outgoing, Unity.Cinemachine.ICinemachineCamera incoming);
            Unity.Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797ddac*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x797deb0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x797e0b8*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797ceb4*/ void InvalidateCameraCache();
            /*0x797e300*/ bool UpdateCameraCache();
            /*0x797e4f8*/ void OnTransformChildrenChanged();
            /*0x797dc88*/ void SetLiveChild(Unity.Cinemachine.ICinemachineCamera activeCamera, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797dbe8*/ void ResetLiveChild();
            /*0x797dd04*/ void FinalizeCameraState(float deltaTime);

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

            /*0x797f2b0*/ CinemachineComponentBase();
            /*0x797e7fc*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera();
            /*0x797e930*/ void OnEnable();
            /*0x797e9e8*/ void OnDisable();
            /*0x797eaa0*/ UnityEngine.Transform get_FollowTarget();
            /*0x797eb48*/ UnityEngine.Transform get_LookAtTarget();
            /*0x797ebf0*/ Unity.Cinemachine.ICinemachineTargetGroup get_FollowTargetAsGroup();
            /*0x797ec78*/ UnityEngine.Vector3 get_FollowTargetPosition();
            /*0x797edbc*/ UnityEngine.Quaternion get_FollowTargetRotation();
            /*0x797eefc*/ Unity.Cinemachine.ICinemachineTargetGroup get_LookAtTargetAsGroup();
            /*0x797ef18*/ UnityEngine.Vector3 get_LookAtTargetPosition();
            /*0x797f05c*/ UnityEngine.Quaternion get_LookAtTargetRotation();
            /*0x797f19c*/ Unity.Cinemachine.CameraState get_VcamState();
            /*0x380b128*/ bool get_IsValid();
            /*0x797f284*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x380b6a0*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x797f288*/ bool get_BodyAppliesAfterAim();
            void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x797f290*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x797f298*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x797f29c*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x797f2a0*/ float GetMaxDampTime();
            /*0x797f2a8*/ bool get_CameraLooksAtTarget();
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

            static /*0x797fbe8*/ CinemachineCore();
            static /*0x797f2b8*/ float get_CurrentUnscaledTime();
            static /*0x797f340*/ UnityEngine.Color SoloGUIColor();
            static /*0x797f35c*/ float get_DeltaTime();
            static /*0x797ac10*/ float get_CurrentTime();
            static /*0x797f3e4*/ int get_VirtualCameraCount();
            static /*0x797f430*/ Unity.Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(int index);
            static /*0x797f484*/ Unity.Cinemachine.ICinemachineCamera get_SoloCamera();
            static /*0x797f4dc*/ void set_SoloCamera(Unity.Cinemachine.ICinemachineCamera value);
            static /*0x797ac98*/ bool IsLive(Unity.Cinemachine.ICinemachineCamera vcam);
            static /*0x797f6b0*/ bool IsLiveInBlend(Unity.Cinemachine.ICinemachineCamera vcam);
            static /*0x797f7bc*/ Unity.Cinemachine.CinemachineBrain FindPotentialTargetBrain(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            static /*0x797f9dc*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            static /*0x797fac4*/ void ResetCameraState();

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
                /*0x797fde4*/ AxisInputDelegate(object object, nint method);
                /*0x797ffb4*/ float Invoke(string axisName);
                /*0x797ffc8*/ System.IAsyncResult BeginInvoke(string axisName, System.AsyncCallback callback, object object);
                /*0x797ffe8*/ float EndInvoke(System.IAsyncResult result);
            }

            class GetBlendOverrideDelegate : System.MulticastDelegate
            {
                /*0x7980010*/ GetBlendOverrideDelegate(object object, nint method);
                /*0x798011c*/ Unity.Cinemachine.CinemachineBlendDefinition Invoke(Unity.Cinemachine.ICinemachineCamera fromVcam, Unity.Cinemachine.ICinemachineCamera toVcam, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.Object owner);
                /*0x7980130*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.ICinemachineCamera fromVcam, Unity.Cinemachine.ICinemachineCamera toVcam, Unity.Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.Object owner, System.AsyncCallback callback, object object);
                /*0x79801dc*/ Unity.Cinemachine.CinemachineBlendDefinition EndInvoke(System.IAsyncResult result);
            }

            class GetCustomBlenderDelegate : System.MulticastDelegate
            {
                /*0x7980208*/ GetCustomBlenderDelegate(object object, nint method);
                /*0x7980314*/ Unity.Cinemachine.CinemachineBlend.IBlender Invoke(Unity.Cinemachine.ICinemachineCamera fromCam, Unity.Cinemachine.ICinemachineCamera toCam);
                /*0x7980328*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.ICinemachineCamera fromCam, Unity.Cinemachine.ICinemachineCamera toCam, System.AsyncCallback callback, object object);
                /*0x7980350*/ Unity.Cinemachine.CinemachineBlend.IBlender EndInvoke(System.IAsyncResult result);
            }

            class CameraEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.ICinemachineMixer, Unity.Cinemachine.ICinemachineCamera>
            {
                /*0x797ff24*/ CameraEvent();
            }

            class BrainEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.CinemachineBrain>
            {
                /*0x797fe94*/ BrainEvent();
            }

            struct BlendEventParams
            {
                /*0x10*/ Unity.Cinemachine.ICinemachineMixer Origin;
                /*0x18*/ Unity.Cinemachine.CinemachineBlend Blend;
            }

            class BlendEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.CinemachineCore.BlendEventParams>
            {
                /*0x797ff6c*/ BlendEvent();
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineCore.<> <>9;

                static /*0x798035c*/ <>c();
                /*0x79803c4*/ <>c();
                /*0x79803cc*/ float <.cctor>b__42_0(string <p0>);
            }
        }

        class CinemachineExtension : UnityEngine.MonoBehaviour
        {
            static float Epsilon = 0.00009999999747378752;
            /*0x20*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_VcamOwner;
            /*0x28*/ System.Collections.Generic.Dictionary<Unity.Cinemachine.CinemachineVirtualCameraBase, Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase> m_ExtraState;

            /*0x7980700*/ CinemachineExtension();
            /*0x79803d4*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_ComponentOwner();
            /*0x7980470*/ void Awake();
            /*0x7980480*/ void OnDestroy();
            /*0x7980490*/ void OnEnable();
            /*0x7980494*/ void EnsureStarted();
            /*0x79804a4*/ void ConnectToVcam(bool connect);
            /*0x79806d8*/ void PrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79806dc*/ void InvokePostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79806e8*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79806ec*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79806f0*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79806f8*/ float GetMaxDampTime();
            /*0x3907c14*/ T GetExtraState<T>(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x380d83c*/ void GetAllExtraStates<T>(System.Collections.Generic.List<T> list);

            class VcamExtraStateBase
            {
                /*0x10*/ Unity.Cinemachine.CinemachineVirtualCameraBase Vcam;

                /*0x7980708*/ VcamExtraStateBase();
            }
        }

        class InputAxisNamePropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7980710*/ InputAxisNamePropertyAttribute();
        }

        class HideFoldoutAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7980718*/ HideFoldoutAttribute();
        }

        class HideIfNoComponentAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ System.Type ComponentType;

            /*0x7980720*/ HideIfNoComponentAttribute(System.Type type);
        }

        class FoldoutWithEnabledButtonAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ string EnabledPropertyName;

            /*0x7980750*/ FoldoutWithEnabledButtonAttribute(string enabledProperty);
        }

        class EnabledPropertyAttribute : Unity.Cinemachine.FoldoutWithEnabledButtonAttribute
        {
            /*0x20*/ string ToggleDisabledText;

            /*0x7980780*/ EnabledPropertyAttribute(string enabledProperty, string toggleText);
        }

        class RangeSliderAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ float Min;
            /*0x1c*/ float Max;

            /*0x79807c4*/ RangeSliderAttribute(float min, float max);
        }

        class MinMaxRangeSliderAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ float Min;
            /*0x1c*/ float Max;

            /*0x79807f0*/ MinMaxRangeSliderAttribute(float min, float max);
        }

        class LensSettingsHideModeOverridePropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x798081c*/ LensSettingsHideModeOverridePropertyAttribute();
        }

        class SensorSizePropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7980824*/ SensorSizePropertyAttribute();
        }

        class TagFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x798082c*/ TagFieldAttribute();
        }

        class CinemachineEmbeddedAssetPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x15*/ bool WarnIfNull;

            /*0x7980834*/ CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull);
        }

        class Vector2AsRangeAttribute : UnityEngine.PropertyAttribute
        {
            /*0x798085c*/ Vector2AsRangeAttribute();
        }

        class DelayedVectorAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7980864*/ DelayedVectorAttribute();
        }

        class CameraPipelineAttribute : System.Attribute
        {
            /*0x10*/ Unity.Cinemachine.CinemachineCore.Stage <Stage>k__BackingField;

            /*0x798087c*/ CameraPipelineAttribute(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x798086c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7980874*/ void set_Stage(Unity.Cinemachine.CinemachineCore.Stage value);
        }

        class RequiredTargetAttribute : System.Attribute
        {
            /*0x10*/ Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets <RequiredTarget>k__BackingField;

            /*0x79808b4*/ RequiredTargetAttribute(Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets requiredTarget);
            /*0x79808a4*/ Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets get_RequiredTarget();
            /*0x79808ac*/ void set_RequiredTarget(Unity.Cinemachine.RequiredTargetAttribute.RequiredTargets value);

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
            /*0x79808dc*/ ChildCameraPropertyAttribute();
        }

        class EmbeddedBlenderSettingsPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79808e4*/ EmbeddedBlenderSettingsPropertyAttribute();
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

            /*0x797e7dc*/ CinemachineVirtualCameraBase();
            /*0x79808ec*/ bool get_IsDprecated();
            /*0x79808f4*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x7980930*/ float GetMaxDampTime();
            /*0x79809e0*/ float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime);
            /*0x7980ae0*/ UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime);
            /*0x7980d5c*/ UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, float dampTime, float deltaTime);
            /*0x7980f14*/ float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime);
            /*0x7980fac*/ UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime);
            /*0x79810a0*/ UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, float dampTime, float deltaTime);
            /*0x7980554*/ void AddExtension(Unity.Cinemachine.CinemachineExtension extension);
            /*0x7980678*/ void RemoveExtension(Unity.Cinemachine.CinemachineExtension extension);
            /*0x79810d4*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineExtension> get_Extensions();
            /*0x79810dc*/ void set_Extensions(System.Collections.Generic.List<Unity.Cinemachine.CinemachineExtension> value);
            /*0x797e528*/ void InvokePostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState newState, float deltaTime);
            /*0x798116c*/ void InvokePrePipelineMutateCameraStateCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, ref Unity.Cinemachine.CameraState newState, float deltaTime);
            /*0x797e18c*/ bool InvokeOnTransitionInExtensions(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x798130c*/ string get_Name();
            /*0x79813f4*/ string get_Description();
            /*0x798138c*/ bool get_IsValid();
            Unity.Cinemachine.CameraState get_State();
            /*0x79810e4*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
            /*0x380b9e8*/ UnityEngine.Transform get_LookAt();
            /*0x380d83c*/ void set_LookAt(UnityEngine.Transform value);
            /*0x380b9e8*/ UnityEngine.Transform get_Follow();
            /*0x380d83c*/ void set_Follow(UnityEngine.Transform value);
            /*0x7981508*/ bool get_PreviousStateIsValid();
            /*0x7981510*/ void set_PreviousStateIsValid(bool value);
            /*0x797dc04*/ void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x798151c*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x797e144*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x798154c*/ void EnsureStarted();
            /*0x7981628*/ void OnTransformParentChanged();
            /*0x7981760*/ void OnDestroy();
            /*0x79817b4*/ void Start();
            /*0x797cf9c*/ void OnEnable();
            /*0x797d238*/ void OnDisable();
            /*0x7981868*/ void Update();
            /*0x7981434*/ void UpdateStatusAsChild();
            /*0x797d494*/ UnityEngine.Transform ResolveLookAt(UnityEngine.Transform localLookAt);
            /*0x797d5a8*/ UnityEngine.Transform ResolveFollow(UnityEngine.Transform localFollow);
            /*0x7981694*/ void UpdateVcamPoolStatus();
            /*0x79818a0*/ void MoveToTopOfPrioritySubqueue();
            /*0x79818a4*/ void Prioritize();
            /*0x797dea4*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79818a8*/ void OnTargetObjectWarped(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x797dfd0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79819dc*/ Unity.Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp, ref Unity.Cinemachine.LensSettings lens);
            /*0x7981800*/ void InvalidateCachedTargets();
            /*0x7981ca4*/ bool get_FollowTargetChanged();
            /*0x7981cac*/ void set_FollowTargetChanged(bool value);
            /*0x7981cb8*/ bool get_LookAtTargetChanged();
            /*0x7981cc0*/ void set_LookAtTargetChanged(bool value);
            /*0x797d994*/ void UpdateTargetCache();
            /*0x7981ccc*/ Unity.Cinemachine.ICinemachineTargetGroup get_FollowTargetAsGroup();
            /*0x7981cd4*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_FollowTargetAsVcam();
            /*0x7981cdc*/ Unity.Cinemachine.ICinemachineTargetGroup get_LookAtTargetAsGroup();
            /*0x7981ce4*/ Unity.Cinemachine.CinemachineVirtualCameraBase get_LookAtTargetAsVcam();
            /*0x7981cec*/ Unity.Cinemachine.CinemachineComponentBase GetCinemachineComponent(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x7981cf4*/ bool get_IsLive();
            /*0x7981d48*/ bool IsParticipatingInBlend();
            /*0x7981ef0*/ void CancelDamping(bool updateNow);

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

            static /*0x7982c2c*/ UnityEngine.Rect <Initialize>g__GetPolygonBoundingBox|25_0(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> polygons);
            static /*0x7982d94*/ Unity.Cinemachine.Point64 <Initialize>g__MidPointOfIntRect|25_1(Unity.Cinemachine.Rect64 bounds);
            /*0x798202c*/ ConfinerOven(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> inputPath, ref float aspectRatio, float maxFrustumHeight, float skeletonPadding);
            /*0x79828d0*/ Unity.Cinemachine.ConfinerOven.BakedSolution GetBakedSolution(float frustumHeight);
            /*0x7982c1c*/ Unity.Cinemachine.ConfinerOven.BakingState get_State();
            /*0x7982c24*/ void set_State(Unity.Cinemachine.ConfinerOven.BakingState value);
            /*0x7982118*/ void Initialize(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> inputPath, ref float aspectRatio, float maxFrustumHeight, float skeletonPadding);
            /*0x7982de4*/ void BakeConfiner(float maxComputationTimePerFrameInSeconds);
            /*0x798339c*/ void <BakeConfiner>g__ComputeSkeleton|26_0(ref System.Collections.Generic.List<Unity.Cinemachine.ConfinerOven.PolygonSolution> solutions);

            class BakedSolution
            {
                static double k_ClipperEpsilon = 1000;
                /*0x10*/ float m_FrustumSizeIntSpace;
                /*0x14*/ Unity.Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;
                /*0x20*/ bool m_HasBones;
                /*0x28*/ double m_SqrPolygonDiagonal;
                /*0x30*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> m_OriginalPolygon;
                /*0x38*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> m_Solution;

                static /*0x7983ed0*/ int FindIntersection(ref Unity.Cinemachine.Point64 p1, ref Unity.Cinemachine.Point64 p2, ref Unity.Cinemachine.Point64 p3, ref Unity.Cinemachine.Point64 p4);
                static /*0x7983ba4*/ Unity.Cinemachine.Point64 <ConfinePoint>g__IntPointLerp|9_0(Unity.Cinemachine.Point64 a, Unity.Cinemachine.Point64 b, float lerp);
                static /*0x7983b3c*/ float <ConfinePoint>g__ClosestPointOnSegment|9_2(Unity.Cinemachine.Point64 point, Unity.Cinemachine.Point64 s0, Unity.Cinemachine.Point64 s1);
                static /*0x7984030*/ double <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(Unity.Cinemachine.Point64 point1, Unity.Cinemachine.Point64 point2);
                /*0x7982b50*/ BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, UnityEngine.Rect polygonBounds, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> originalPolygon, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solution);
                /*0x79836f0*/ bool IsValid();
                /*0x7983700*/ UnityEngine.Vector2 ConfinePoint(ref UnityEngine.Vector2 pointToConfine);
                /*0x7983a4c*/ bool <ConfinePoint>g__IsInsideOriginal|9_1(Unity.Cinemachine.Point64 point);
                /*0x7983d74*/ bool <ConfinePoint>g__DoesIntersectOriginal|9_3(Unity.Cinemachine.Point64 l1, Unity.Cinemachine.Point64 l2);
            }

            struct AspectStretcher
            {
                /*0x10*/ float <Aspect>k__BackingField;
                /*0x14*/ float m_InverseAspect;
                /*0x18*/ float m_CenterX;

                /*0x7982104*/ AspectStretcher(float aspect, float centerX);
                /*0x7984050*/ float get_Aspect();
                /*0x7982d80*/ UnityEngine.Vector2 Stretch(UnityEngine.Vector2 p);
                /*0x7983eb8*/ UnityEngine.Vector2 Unstretch(UnityEngine.Vector2 p);
            }

            struct PolygonSolution
            {
                /*0x10*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> polygons;
                /*0x18*/ float frustumHeight;

                /*0x798328c*/ bool StateChanged(ref System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
                /*0x798338c*/ bool get_IsNull();
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
            /*0x380c2e4*/ float get_Sigma();
            /*0x380e050*/ void set_Sigma(float value);
            /*0x380b6a0*/ int get_KernelSize();
            void GenerateKernel(float sigma, int maxKernelRadius);
            /*0x3907c14*/ T Compute(int windowPos);
            /*0x380cb08*/ void Reset();
            /*0x380b128*/ bool IsEmpty();
            /*0x3907c14*/ void AddValue(T v);
            /*0x3907c14*/ T Filter(T v);
            /*0x3907c14*/ T Value();
            /*0x380b6a0*/ int get_BufferLength();
            /*0x3907c14*/ void SetBufferValue(int index, T value);
            /*0x3907c14*/ T GetBufferValue(int index);
        }

        class GaussianWindow1D_Vector3 : Unity.Cinemachine.GaussianWindow1d<UnityEngine.Vector3>
        {
            /*0x7984058*/ GaussianWindow1D_Vector3(float sigma, int maxKernelRadius);
            /*0x79840c0*/ UnityEngine.Vector3 Compute(int windowPos);
        }

        class GaussianWindow1D_Quaternion : Unity.Cinemachine.GaussianWindow1d<UnityEngine.Quaternion>
        {
            /*0x7984218*/ GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius);
            /*0x7984280*/ UnityEngine.Quaternion Compute(int windowPos);
        }

        class GaussianWindow1D_CameraRotation : Unity.Cinemachine.GaussianWindow1d<UnityEngine.Vector2>
        {
            /*0x7984608*/ GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius);
            /*0x7984670*/ UnityEngine.Vector2 Compute(int windowPos);
        }

        interface ICinemachineCamera
        {
            /*0x380b9e8*/ string get_Name();
            /*0x380b9e8*/ string get_Description();
            Unity.Cinemachine.CameraState get_State();
            /*0x380b128*/ bool get_IsValid();
            /*0x380b9e8*/ Unity.Cinemachine.ICinemachineMixer get_ParentCamera();
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
                /*0x797fedc*/ ActivationEvent();
            }
        }

        interface ICinemachineMixer : Unity.Cinemachine.ICinemachineCamera
        {
            bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera child, bool dominantChildOnly);
        }

        interface IInputAxisOwner
        {
            /*0x380d83c*/ void GetInputAxes(System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> axes);

            struct AxisDescriptor
            {
                /*0x10*/ Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.AxisGetter DrivenAxis;
                /*0x18*/ string Name;
                /*0x20*/ Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints Hint;

                class AxisGetter : System.MulticastDelegate
                {
                    /*0x7984818*/ AxisGetter(object object, nint method);
                    /*0x79848b4*/ ref Unity.Cinemachine.InputAxis Invoke();
                    /*0x79848c8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0x79848e8*/ ref Unity.Cinemachine.InputAxis EndInvoke(System.IAsyncResult result);
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
            /*0x380d83c*/ void RegisterResetHandler(System.Action handler);
            /*0x380d83c*/ void UnregisterResetHandler(System.Action handler);
            /*0x380b128*/ bool get_HasResetHandler();
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

            static /*0x7984c54*/ Unity.Cinemachine.InputAxis get_DefaultMomentary();
            /*0x79848f4*/ float ClampValue(float v);
            /*0x7984960*/ float GetNormalizedValue();
            /*0x79849e8*/ float GetClampedValue();
            /*0x7984a58*/ void Validate();
            /*0x7984b48*/ void Reset();
            /*0x7984c7c*/ bool TrackValueChange();
            /*0x7984d54*/ void SetValueAndLastValue(float value);
            /*0x7984d60*/ void UpdateRecentering(float deltaTime, bool forceCancel);
            /*0x7984d6c*/ void UpdateRecentering(float deltaTime, bool forceCancel, float center);
            /*0x7984fa0*/ void TriggerRecentering();
            /*0x7984bd0*/ void CancelRecentering();

            struct RecenteringSettings
            {
                /*0x10*/ bool Enabled;
                /*0x14*/ float Wait;
                /*0x18*/ float Time;

                static /*0x7984fac*/ Unity.Cinemachine.InputAxis.RecenteringSettings get_Default();
                /*0x7984b30*/ void Validate();
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

                static /*0x7984d08*/ float get_CurrentTime();
            }
        }

        struct DefaultInputAxisDriver
        {
            /*0x10*/ float m_CurrentSpeed;
            /*0x14*/ float AccelTime;
            /*0x18*/ float DecelTime;

            static /*0x7984fd0*/ Unity.Cinemachine.DefaultInputAxisDriver get_Default();
            /*0x7984fb8*/ void Validate();
            /*0x7984fe4*/ void ProcessInput(ref Unity.Cinemachine.InputAxis axis, float inputValue, float deltaTime);
            /*0x7985274*/ void Reset(ref Unity.Cinemachine.InputAxis axis);
        }

        interface IInputAxisController
        {
            /*0x380cb08*/ void SynchronizeControllers();
        }

        class InputAxisControllerManagerAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7985280*/ InputAxisControllerManagerAttribute();
        }

        class InputAxisControllerManager<T>
        {
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.InputAxisControllerBase.Controller<T>> Controllers;
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner.AxisDescriptor> m_Axes;
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.IInputAxisOwner> m_AxisOwners;
            /*0x0*/ System.Collections.Generic.List<Unity.Cinemachine.IInputAxisResetSource> m_AxisResetters;

            static /*0x3827240*/ int <CreateControllers>g__GetControllerIndex|9_0(System.Collections.Generic.List<Unity.Cinemachine.InputAxisControllerBase.Controller<T>> list, Unity.Cinemachine.IInputAxisOwner owner, string axisName);
            /*0x380cb08*/ InputAxisControllerManager();
            /*0x380cb08*/ void Validate();
            /*0x380cb08*/ void OnDisable();
            /*0x380cb08*/ void Reset();
            /*0x380cb08*/ void OnResetInput();
            /*0x3907c14*/ void CreateControllers(UnityEngine.GameObject root, bool scanRecursively, bool enabled, Unity.Cinemachine.InputAxisControllerManager.DefaultInitializer<T> defaultInitializer);
            void RegisterResetHandlers(UnityEngine.GameObject root, bool scanRecursively);
            void UpdateControllers(UnityEngine.Object context, float deltaTime);

            class DefaultInitializer<T> : System.MulticastDelegate
            {
                DefaultInitializer(object object, nint method);
                /*0x380d93c*/ void Invoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<T> controller);
                /*0x380bd7c*/ System.IAsyncResult BeginInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<T> controller, System.AsyncCallback callback, object object);
                /*0x380d93c*/ void EndInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, System.IAsyncResult result);
            }
        }

        class InputAxisControllerBase<T> : UnityEngine.MonoBehaviour, Unity.Cinemachine.IInputAxisController
        {
            /*0x0*/ bool ScanRecursively;
            /*0x0*/ bool SuppressInputWhileBlending;
            /*0x0*/ bool IgnoreTimeScale;
            /*0x0*/ Unity.Cinemachine.InputAxisControllerManager<T> m_ControllerManager;

            /*0x380cb08*/ InputAxisControllerBase();
            /*0x380b9e8*/ System.Collections.Generic.List<Unity.Cinemachine.InputAxisControllerBase.Controller<T>> get_Controllers();
            /*0x380cb08*/ void OnValidate();
            /*0x380cb08*/ void Reset();
            /*0x380cb08*/ void OnEnable();
            /*0x380cb08*/ void OnDisable();
            /*0x380cb08*/ void SynchronizeControllers();
            /*0x380d93c*/ void InitializeControllerDefaultsForAxis(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<T> controller);
            /*0x380cb08*/ void UpdateControllers();
            /*0x380e050*/ void UpdateControllers(float deltaTime);

            class Controller<T>
            {
                /*0x0*/ string Name;
                /*0x0*/ UnityEngine.Object Owner;
                /*0x0*/ bool Enabled;
                /*0x0*/ T Input;
                /*0x0*/ float InputValue;
                /*0x0*/ Unity.Cinemachine.DefaultInputAxisDriver Driver;

                /*0x380cb08*/ Controller();
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

            static /*0x7978528*/ Unity.Cinemachine.LensSettings get_Default();
            static /*0x79852b8*/ Unity.Cinemachine.LensSettings FromCamera(UnityEngine.Camera fromCamera);
            static /*0x7979844*/ Unity.Cinemachine.LensSettings Lerp(Unity.Cinemachine.LensSettings lensA, Unity.Cinemachine.LensSettings lensB, float t);
            static /*0x7985978*/ bool AreEqual(ref Unity.Cinemachine.LensSettings a, ref Unity.Cinemachine.LensSettings b);
            /*0x79799ec*/ bool get_Orthographic();
            /*0x7985288*/ bool get_IsPhysicalCamera();
            /*0x797a2f0*/ float get_Aspect();
            /*0x7981c38*/ void PullInheritedPropertiesFromCamera(UnityEngine.Camera camera);
            /*0x7985540*/ void CopyCameraMode(ref Unity.Cinemachine.LensSettings fromLens);
            /*0x79855a4*/ void Lerp(ref Unity.Cinemachine.LensSettings lensB, float t);
            /*0x7985868*/ void Validate();

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

            static /*0x7985d40*/ UnityEngine.Vector3 GetCombinedFilterResults(Unity.Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, float time, UnityEngine.Vector3 timeOffsets);
            /*0x7985f84*/ NoiseSettings();
            /*0x7985e90*/ float get_SignalDuration();
            /*0x7985e98*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);

            struct NoiseParams
            {
                /*0x10*/ float Frequency;
                /*0x14*/ float Amplitude;
                /*0x18*/ bool Constant;

                /*0x798600c*/ float GetValueAt(float time, float timeOffset);
            }

            struct TransformNoiseParams
            {
                /*0x10*/ Unity.Cinemachine.NoiseSettings.NoiseParams X;
                /*0x1c*/ Unity.Cinemachine.NoiseSettings.NoiseParams Y;
                /*0x28*/ Unity.Cinemachine.NoiseSettings.NoiseParams Z;

                /*0x7985e2c*/ UnityEngine.Vector3 GetValueAt(float time, UnityEngine.Vector3 timeOffsets);
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

            /*0x7986070*/ bool get_IsEmpty();
            /*0x7986080*/ UnityEngine.Vector3 get_CurrentPosition();
            /*0x798608c*/ void ApplyTransformDelta(UnityEngine.Vector3 positionDelta);
            /*0x79860ac*/ void Reset();
            /*0x798611c*/ void AddPosition(UnityEngine.Vector3 pos, float deltaTime);
            /*0x7986214*/ UnityEngine.Vector3 PredictPositionDelta(float lookaheadTime);
        }

        class Damper
        {
            static float Epsilon = 0.00009999999747378752;
            static float kNegligibleResidual = 0.009999999776482582;
            static float kLogNegligibleResidual = -4.605170249938965;

            static /*0x7986230*/ float DecayConstant(float time, float residual);
            static /*0x7986258*/ float DecayedRemainder(float initial, float decayConstant, float deltaTime);
            static /*0x7980a78*/ float Damp(float initial, float dampTime, float deltaTime);
            static /*0x7980bd4*/ UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime);
            static /*0x7980d90*/ UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, float dampTime, float deltaTime);
            static /*0x798627c*/ float StandardDamp(float initial, float dampTime, float deltaTime);
            static /*0x79862e4*/ float StableDamp(float initial, float dampTime, float deltaTime);

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

                static /*0x7986a44*/ AverageFrameRateTracker();
                static /*0x79864cc*/ float get_FPS();
                static /*0x7986524*/ void set_FPS(float value);
                static /*0x7986588*/ float get_DampTimeScale();
                static /*0x79865e0*/ void set_DampTimeScale(float value);
                static /*0x7986644*/ void Initialize();
                static /*0x7986760*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                static /*0x7986690*/ void Reset();
                static /*0x7986868*/ void Append();
                static /*0x79867ac*/ void SetDampTimeScale(float fps);
            }
        }

        struct PrioritySettings
        {
            /*0x10*/ bool Enabled;
            /*0x14*/ int m_Value;

            static /*0x7986acc*/ int op_Implicit(Unity.Cinemachine.PrioritySettings prioritySettings);
            static /*0x7986adc*/ Unity.Cinemachine.PrioritySettings op_Implicit(int priority);
            /*0x7981888*/ int get_Value();
            /*0x7980920*/ void set_Value(int value);
        }

        class RuntimeUtility
        {
            static /*0x0*/ UnityEngine.RaycastHit[] s_HitBuffer;
            static /*0x8*/ int[] s_PenetrationIndexBuffer;
            static /*0x10*/ UnityEngine.SphereCollider s_ScratchCollider;
            static /*0x18*/ UnityEngine.GameObject s_ScratchColliderGameObject;
            static /*0x20*/ int s_ScratchColliderRefCount;

            static /*0x7987d6c*/ RuntimeUtility();
            static /*0x7986aec*/ void DestroyObject(UnityEngine.Object obj);
            static /*0x7986b74*/ bool IsPrefab(UnityEngine.GameObject gameObject);
            static /*0x7986b7c*/ bool RaycastIgnoreTag(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float rayLength, int layerMask, ref string ignoreTag);
            static /*0x7986eb0*/ bool SphereCastIgnoreTag(UnityEngine.Ray ray, float radius, ref UnityEngine.RaycastHit hitInfo, float rayLength, int layerMask, ref string ignoreTag);
            static /*0x798778c*/ UnityEngine.SphereCollider GetScratchCollider();
            static /*0x79879fc*/ void DestroyScratchCollider();
            static /*0x7987b0c*/ UnityEngine.AnimationCurve NormalizeCurve(UnityEngine.AnimationCurve curve, bool normalizeX, bool normalizeY);
        }

        struct ScreenComposerSettings
        {
            /*0x10*/ UnityEngine.Vector2 ScreenPosition;
            /*0x18*/ Unity.Cinemachine.ScreenComposerSettings.DeadZoneSettings DeadZone;
            /*0x24*/ Unity.Cinemachine.ScreenComposerSettings.HardLimitSettings HardLimits;

            static /*0x7988108*/ Unity.Cinemachine.ScreenComposerSettings Lerp(ref Unity.Cinemachine.ScreenComposerSettings a, ref Unity.Cinemachine.ScreenComposerSettings b, float t);
            static /*0x79882f4*/ bool Approximately(ref Unity.Cinemachine.ScreenComposerSettings a, ref Unity.Cinemachine.ScreenComposerSettings b);
            static /*0x7988648*/ Unity.Cinemachine.ScreenComposerSettings get_Default();
            /*0x7987e20*/ void Validate();
            /*0x7987ec0*/ UnityEngine.Vector2 get_EffectiveDeadZoneSize();
            /*0x7987f1c*/ UnityEngine.Vector2 get_EffectiveHardLimitSize();
            /*0x7987f38*/ UnityEngine.Rect get_DeadZoneRect();
            /*0x7987f78*/ void set_DeadZoneRect(UnityEngine.Rect value);
            /*0x7988040*/ UnityEngine.Rect get_HardLimitsRect();
            /*0x79880c8*/ void set_HardLimitsRect(UnityEngine.Rect value);

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
            /*0x380c2e4*/ float get_SignalDuration();
            void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        }

        class SignalSourceAsset : UnityEngine.ScriptableObject, Unity.Cinemachine.ISignalSource6D
        {
            /*0x7986004*/ SignalSourceAsset();
            /*0x380c2e4*/ float get_SignalDuration();
            void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        }

        struct SplineAutoDolly
        {
            /*0x10*/ bool Enabled;
            /*0x18*/ Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly Method;

            interface ISplineAutoDolly
            {
                /*0x380cb08*/ void Validate();
                /*0x380cb08*/ void Reset();
                /*0x380b128*/ bool get_RequiresTrackingTarget();
                float GetSplinePosition(UnityEngine.MonoBehaviour sender, UnityEngine.Transform target, UnityEngine.Splines.SplineContainer spline, float currentPosition, UnityEngine.Splines.PathIndexUnit positionUnits, float deltaTime);
            }

            class FixedSpeed : Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly
            {
                /*0x10*/ float Speed;

                /*0x79888b0*/ FixedSpeed();
                /*0x7988684*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Validate();
                /*0x7988688*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Reset();
                /*0x798868c*/ bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.get_RequiresTrackingTarget();
                /*0x7988694*/ float Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.GetSplinePosition(UnityEngine.MonoBehaviour sender, UnityEngine.Transform target, UnityEngine.Splines.SplineContainer spline, float currentPosition, UnityEngine.Splines.PathIndexUnit positionUnits, float deltaTime);
            }

            class NearestPointToTarget : Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly
            {
                /*0x10*/ float PositionOffset;
                /*0x14*/ int SearchResolution;
                /*0x18*/ int SearchIteration;

                /*0x7988a54*/ NearestPointToTarget();
                /*0x79888b8*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Validate();
                /*0x79888cc*/ void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Reset();
                /*0x79888d0*/ bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.get_RequiresTrackingTarget();
                /*0x79888d8*/ float Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.GetSplinePosition(UnityEngine.MonoBehaviour sender, UnityEngine.Transform target, UnityEngine.Splines.SplineContainer spline, float currentPosition, UnityEngine.Splines.PathIndexUnit positionUnits, float deltaTime);
            }
        }

        class SplineContainerExtensions
        {
            static /*0x7988730*/ bool IsValid(UnityEngine.Splines.ISplineContainer spline);
            static /*0x7988a68*/ bool LocalEvaluateSplineWithRoll(UnityEngine.Splines.ISpline spline, float tNormalized, Unity.Cinemachine.CinemachineSplineRoll roll, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            static /*0x7988ee4*/ bool EvaluateSplineWithRoll(UnityEngine.Splines.ISpline spline, UnityEngine.Transform transform, float tNormalized, Unity.Cinemachine.CinemachineSplineRoll roll, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            static /*0x79890b4*/ UnityEngine.Vector3 EvaluateSplinePosition(UnityEngine.Splines.ISpline spline, UnityEngine.Transform transform, float tNormalized);
            static /*0x798928c*/ float GetMaxPosition(UnityEngine.Splines.ISpline spline, UnityEngine.Splines.PathIndexUnit unit);
            static /*0x7989440*/ float StandardizePosition(UnityEngine.Splines.ISpline spline, float t, UnityEngine.Splines.PathIndexUnit unit, ref float maxPos);
            static /*0x7988eac*/ UnityEngine.Quaternion <LocalEvaluateSplineWithRoll>g__RollAroundForward|1_0(float angle);
        }

        class SplineHelpers
        {
            static /*0x798956c*/ UnityEngine.Vector3 Bezier3(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3);
            static /*0x7989614*/ UnityEngine.Vector3 BezierTangent3(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3);
            static /*0x798970c*/ void BezierTangentWeights3(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, ref UnityEngine.Vector3 w0, ref UnityEngine.Vector3 w1, ref UnityEngine.Vector3 w2);
            static /*0x79897f4*/ float Bezier1(float t, float p0, float p1, float p2, float p3);
            static /*0x7989854*/ float BezierTangent1(float t, float p0, float p1, float p2, float p3);
            static /*0x79898c8*/ void ComputeSmoothControlPoints(ref UnityEngine.Vector4[] knot, ref UnityEngine.Vector4[] ctrl1, ref UnityEngine.Vector4[] ctrl2);
            static /*0x798a3ec*/ void ComputeSmoothControlPointsLooped(ref UnityEngine.Vector4[] knot, ref UnityEngine.Vector4[] ctrl1, ref UnityEngine.Vector4[] ctrl2);
            static /*0x798a698*/ void ComputeSmoothControlPoints(ref Unity.Mathematics.float3[] knot, ref Unity.Mathematics.float3[] ctrl1, ref Unity.Mathematics.float3[] ctrl2);
            static /*0x798ae40*/ void ComputeSmoothControlPointsLooped(ref Unity.Mathematics.float3[] knot, ref Unity.Mathematics.float3[] ctrl1, ref Unity.Mathematics.float3[] ctrl2);
        }

        interface ISplineReferencer
        {
            /*0x380b9e8*/ ref Unity.Cinemachine.SplineSettings get_SplineSettings();
        }

        struct SplineSettings
        {
            /*0x10*/ UnityEngine.Splines.SplineContainer Spline;
            /*0x18*/ float Position;
            /*0x1c*/ UnityEngine.Splines.PathIndexUnit Units;
            /*0x20*/ Unity.Cinemachine.CachedScaledSpline m_CachedSpline;
            /*0x28*/ int m_CachedFrame;

            /*0x798b148*/ void ChangeUnitPreservePosition(UnityEngine.Splines.PathIndexUnit newUnits);
            /*0x798b1cc*/ Unity.Cinemachine.CachedScaledSpline GetCachedSpline();
            /*0x798b30c*/ void InvalidateCache();
        }

        class CachedScaledSpline : UnityEngine.Splines.ISpline, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.BezierKnot>, System.IDisposable
        {
            /*0x10*/ UnityEngine.Splines.NativeSpline m_NativeSpline;
            /*0x58*/ UnityEngine.Splines.Spline m_CachedSource;
            /*0x60*/ UnityEngine.Vector3 m_CachedScale;
            /*0x6c*/ bool m_IsAllocated;

            /*0x798b48c*/ CachedScaledSpline(UnityEngine.Splines.Spline spline, UnityEngine.Transform transform, Unity.Collections.Allocator allocator);
            /*0x798b62c*/ void Dispose();
            /*0x798b350*/ bool IsCrudelyValid(UnityEngine.Splines.Spline spline, UnityEngine.Transform transform);
            /*0x798b67c*/ bool KnotsAreValid(UnityEngine.Splines.Spline spline, UnityEngine.Transform transform);
            /*0x798ba2c*/ UnityEngine.Splines.BezierKnot get_Item(int index);
            /*0x798ba70*/ bool get_Closed();
            /*0x798ba78*/ int get_Count();
            /*0x798ba84*/ UnityEngine.Splines.BezierCurve GetCurve(int index);
            /*0x798babc*/ float GetCurveInterpolation(int curveIndex, float curveDistance);
            /*0x798bac8*/ float GetCurveLength(int index);
            /*0x798bad4*/ Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            /*0x798ba20*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator();
            /*0x798bae0*/ float GetLength();
            /*0x798bae8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x798baf4*/ Unity.Cinemachine.TargetPositionCache.Mode get_CacheMode();
            static /*0x798bb3c*/ void set_CacheMode(Unity.Cinemachine.TargetPositionCache.Mode value);
            static /*0x798bdf0*/ bool get_IsRecording();
            static /*0x798be50*/ bool get_CurrentPlaybackTimeValid();
            static /*0x798bf20*/ bool get_IsEmpty();
            static /*0x798bf78*/ Unity.Cinemachine.TargetPositionCache.TimeRange get_CacheTimeRange();
            static /*0x798beb8*/ bool get_HasCurrentTime();
            static /*0x798bbbc*/ void ClearCache();
            static /*0x798bca0*/ void CreatePlaybackCurves();
            static /*0x798c264*/ UnityEngine.Vector3 GetTargetPosition(UnityEngine.Transform target);
            static /*0x798ca18*/ UnityEngine.Quaternion GetTargetRotation(UnityEngine.Transform target);
            /*0x798cc80*/ TargetPositionCache();

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

                /*0x798ccd0*/ CacheCurve(float startTime, float endTime, float stepSize);
                /*0x798cc88*/ int get_Count();
                /*0x798cddc*/ void Add(Unity.Cinemachine.TargetPositionCache.CacheCurve.Item item);
                /*0x798cec4*/ void AddUntil(Unity.Cinemachine.TargetPositionCache.CacheCurve.Item item, float time, bool isCut);
                /*0x798c840*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item Evaluate(float time);

                struct Item
                {
                    /*0x10*/ UnityEngine.Vector3 Pos;
                    /*0x1c*/ UnityEngine.Quaternion Rot;

                    static /*0x798d014*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item Lerp(Unity.Cinemachine.TargetPositionCache.CacheCurve.Item a, Unity.Cinemachine.TargetPositionCache.CacheCurve.Item b, float t);
                    static /*0x798d08c*/ Unity.Cinemachine.TargetPositionCache.CacheCurve.Item get_Empty();
                }
            }

            class CacheEntry
            {
                /*0x10*/ Unity.Cinemachine.TargetPositionCache.CacheCurve Curve;
                /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.TargetPositionCache.CacheEntry.RecordingItem> RawItems;

                /*0x798c4cc*/ CacheEntry();
                /*0x798c554*/ void AddRawItem(float time, bool isCut, UnityEngine.Transform target);
                /*0x798bff8*/ void CreateCurves();

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

                static /*0x798bfe4*/ Unity.Cinemachine.TargetPositionCache.TimeRange get_Empty();
                /*0x798bf68*/ bool get_IsEmpty();
                /*0x798bfc0*/ bool Contains(float time);
                /*0x798c824*/ void Include(float time);
            }
        }

        class UnityVectorExtensions
        {
            static float Epsilon = 0.00009999999747378752;

            static /*0x798d0fc*/ bool IsNaN(UnityEngine.Vector2 v);
            static /*0x798d128*/ bool IsNaN(UnityEngine.Vector3 v);
            static /*0x798d16c*/ float ClosestPointOnSegment(UnityEngine.Vector3 p, UnityEngine.Vector3 s0, UnityEngine.Vector3 s1);
            static /*0x798d1e4*/ float ClosestPointOnSegment(UnityEngine.Vector2 p, UnityEngine.Vector2 s0, UnityEngine.Vector2 s1);
            static /*0x798d23c*/ UnityEngine.Vector3 ProjectOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal);
            static /*0x798d26c*/ UnityEngine.Vector2 SquareNormalize(UnityEngine.Vector2 v);
            static /*0x798d2d8*/ int FindIntersection(ref UnityEngine.Vector2 p1, ref UnityEngine.Vector2 p2, ref UnityEngine.Vector2 q1, ref UnityEngine.Vector2 q2, ref UnityEngine.Vector2 intersection);
            static /*0x798d570*/ float Cross(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2);
            static /*0x798d580*/ UnityEngine.Vector2 Abs(UnityEngine.Vector2 v);
            static /*0x798d58c*/ UnityEngine.Vector3 Abs(UnityEngine.Vector3 v);
            static /*0x798d59c*/ bool IsUniform(UnityEngine.Vector2 v);
            static /*0x798d60c*/ bool IsUniform(UnityEngine.Vector3 v);
            static /*0x798b654*/ bool AlmostZero(UnityEngine.Vector3 v);
            static /*0x798d6ac*/ void ConservativeSetPositionAndRotation(UnityEngine.Transform t, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            static /*0x798d7c4*/ float Angle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2);
            static /*0x798da04*/ float SignedAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up);
            static /*0x798dab4*/ UnityEngine.Quaternion SafeFromToRotation(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up);
            static /*0x798df4c*/ UnityEngine.Vector3 SlerpWithReferenceUp(UnityEngine.Vector3 vA, UnityEngine.Vector3 vB, float t, UnityEngine.Vector3 up);
            static /*0x798e674*/ float NormalizeAngle(float angle);
        }

        class UnityQuaternionExtensions
        {
            static /*0x798e1cc*/ UnityEngine.Quaternion SlerpWithReferenceUp(UnityEngine.Quaternion qA, UnityEngine.Quaternion qB, float t, UnityEngine.Vector3 up);
            static /*0x798e6a8*/ UnityEngine.Vector2 GetCameraRotationToTarget(UnityEngine.Quaternion orient, UnityEngine.Vector3 lookAtDir, UnityEngine.Vector3 worldUp);
            static /*0x798e9f4*/ UnityEngine.Quaternion ApplyCameraRotation(UnityEngine.Quaternion orient, UnityEngine.Vector2 rot, UnityEngine.Vector3 worldUp);
        }

        class UnityRectExtensions
        {
            static /*0x798ebd0*/ UnityEngine.Rect Inflated(UnityEngine.Rect r, UnityEngine.Vector2 delta);
        }

        class UpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Transform, Unity.Cinemachine.UpdateTracker.UpdateStatus> s_UpdateStatus;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Transform> s_ToDelete;
            static /*0x10*/ object s_LastUpdateContext;

            static /*0x798f4a4*/ UpdateTracker();
            static /*0x798ec18*/ void InitializeModule();
            static /*0x798ec90*/ void UpdateTargets(Unity.Cinemachine.UpdateTracker.UpdateClock currentClock);
            static /*0x798f108*/ Unity.Cinemachine.UpdateTracker.UpdateClock GetPreferredUpdate(UnityEngine.Transform target);
            static /*0x798f34c*/ void OnUpdate(Unity.Cinemachine.UpdateTracker.UpdateClock currentClock, object context);
            static /*0x798f40c*/ void ForgetContext(object context);
            /*0x798f49c*/ UpdateTracker();

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

                /*0x798f2f4*/ UpdateStatus(int currentFrame, UnityEngine.Matrix4x4 pos);
                /*0x798f594*/ Unity.Cinemachine.UpdateTracker.UpdateClock get_PreferredUpdate();
                /*0x798f59c*/ void set_PreferredUpdate(Unity.Cinemachine.UpdateTracker.UpdateClock value);
                /*0x798efd8*/ void OnUpdate(int currentFrame, Unity.Cinemachine.UpdateTracker.UpdateClock currentClock, UnityEngine.Matrix4x4 pos);
            }
        }

        class VirtualCameraRegistry
        {
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase> m_ActiveCameras;
            /*0x18*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase>> m_AllCameras;
            /*0x20*/ bool m_ActiveCamerasAreSorted;
            /*0x24*/ int m_ActivationSequence;

            /*0x798fc5c*/ VirtualCameraRegistry();
            /*0x798f5a4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCameraBase>> get_AllCamerasSortedByNestingLevel();
            /*0x798f5ac*/ int get_ActiveCameraCount();
            /*0x798f5f4*/ Unity.Cinemachine.CinemachineVirtualCameraBase GetActiveCamera(int index);
            /*0x798f754*/ void AddActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x798f818*/ void RemoveActiveCamera(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x798f8a8*/ void CameraDestroyed(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x798f938*/ void CameraEnabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x798fbac*/ void CameraDisabled(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.VirtualCameraRegistry.<> <>9;
                static /*0x8*/ System.Comparison<Unity.Cinemachine.CinemachineVirtualCameraBase> <>9__8_0;

                static /*0x798fd38*/ <>c();
                /*0x798fda0*/ <>c();
                /*0x798fda8*/ int <GetActiveCamera>b__8_0(Unity.Cinemachine.CinemachineVirtualCameraBase x, Unity.Cinemachine.CinemachineVirtualCameraBase y);
            }
        }

        class CinemachineDebug
        {
            static /*0x0*/ System.Collections.Generic.List<System.Text.StringBuilder> s_AvailableStringBuilders;
            static /*0x8*/ System.Action<Unity.Cinemachine.CinemachineBrain> OnGUIHandlers;
            static /*0x10*/ bool GameViewGuidesEnabled;

            static /*0x798fe48*/ System.Text.StringBuilder SBFromPool();
            static /*0x798ff4c*/ void ReturnToPool(System.Text.StringBuilder sb);
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

            /*0x7990078*/ AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert);
            /*0x799013c*/ void Validate();
            /*0x799017c*/ void Reset();
            /*0x799018c*/ void SetInputAxisProvider(int axis, Unity.Cinemachine.AxisState.IInputAxisProvider provider);
            /*0x799019c*/ bool get_HasInputProvider();
            /*0x79901ac*/ bool Update(float deltaTime);
            /*0x7990718*/ float ClampValue(float v);
            /*0x799057c*/ bool MaxSpeedUpdate(float input, float deltaTime);
            /*0x7990784*/ float GetMaxSpeed();
            /*0x7990810*/ bool get_ValueRangeLocked();
            /*0x7990818*/ void set_ValueRangeLocked(bool value);
            /*0x7990824*/ bool get_HasRecentering();
            /*0x799082c*/ void set_HasRecentering(bool value);

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
                /*0x380b128*/ bool RequiresInput();
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

                /*0x799011c*/ Recentering(bool enabled, float waitTime, float recenteringTime);
                /*0x7990838*/ void Validate();
                /*0x7990850*/ void CopyStateFrom(ref Unity.Cinemachine.AxisState.Recentering other);
                /*0x799086c*/ void CancelRecentering();
                /*0x799088c*/ void RecenterNow();
                /*0x7990898*/ void DoRecentering(ref Unity.Cinemachine.AxisState axis, float deltaTime, float recenterTarget);
                /*0x7990ac4*/ bool LegacyUpgrade(ref int heading, ref int velocityFilter);
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

            static /*0x7991298*/ UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up);
            /*0x7991a7c*/ Cinemachine3rdPersonFollow();
            /*0x7990b00*/ void OnValidate();
            /*0x7990b64*/ void Reset();
            /*0x7990bbc*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x7990d34*/ UnityEngine.Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping();
            /*0x7990d40*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(UnityEngine.Vector3 value);
            /*0x7990d4c*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance();
            /*0x7990d54*/ void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value);
            /*0x7990d5c*/ bool get_IsValid();
            /*0x7990dec*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x7990df4*/ float GetMaxDampTime();
            /*0x7990e24*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79911c4*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7990ea8*/ void PositionCamera(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7991884*/ void GetRigPositions(ref UnityEngine.Vector3 root, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x799144c*/ void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, ref UnityEngine.Vector3 shoulder, ref UnityEngine.Vector3 hand);
            /*0x799153c*/ UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection);
            /*0x79919bc*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineThirdPersonFollow c);
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

            static /*0x799629c*/ CinemachineCollider();
            static /*0x79954cc*/ float ClampRayToBounds(UnityEngine.Ray ray, float distance, UnityEngine.Bounds bounds);
            static /*0x7993988*/ bool IsTargetOffscreen(Unity.Cinemachine.CameraState state);
            /*0x79961d8*/ CinemachineCollider();
            /*0x7991ab0*/ bool IsTargetObscured(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7991b18*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7991b30*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7991c00*/ void OnValidate();
            /*0x7991c44*/ void OnDestroy();
            /*0x7991ca4*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> get_DebugPaths();
            /*0x7991f44*/ float GetMaxDampTime();
            /*0x7991f60*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7992994*/ UnityEngine.Vector3 PreserveLineOfSight(ref Unity.Cinemachine.CameraState state, ref Unity.Cinemachine.CinemachineCollider.VcamExtraState extra);
            /*0x7993f14*/ UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, int layerMask, ref UnityEngine.RaycastHit hitInfo);
            /*0x7994230*/ UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, float targetDistance, int iterations, ref Unity.Cinemachine.CinemachineCollider.VcamExtraState extra);
            /*0x7994aa8*/ bool GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, ref UnityEngine.Vector3 outDir);
            /*0x7995298*/ float GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, float targetDistance, UnityEngine.Vector3 lookAtPos);
            /*0x7992f20*/ UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos);
            /*0x7993c38*/ bool CheckForTargetObstructions(Unity.Cinemachine.CameraState state);
            /*0x7996144*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineDeoccluder c);

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

                /*0x7996310*/ VcamExtraState();
                /*0x799422c*/ void AddPointToDebugPath(UnityEngine.Vector3 p);
                /*0x7992e04*/ float ApplyDistanceSmoothing(float distance, float smoothingTime);
                /*0x7992d84*/ void UpdateDistanceSmoothing(float distance);
                /*0x7992ea8*/ void ResetDistanceSmoothing(float smoothingTime);
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

            /*0x7997720*/ CinemachineComposer();
            /*0x7996318*/ bool get_IsValid();
            /*0x79963a8*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79963b0*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x79963bc*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x79963c8*/ UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, float deltaTime);
            /*0x79965a0*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79966a4*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7996708*/ float GetMaxDampTime();
            /*0x7996718*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79967a8*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x7996f0c*/ UnityEngine.Rect get_SoftGuideRect();
            /*0x7997440*/ void set_SoftGuideRect(UnityEngine.Rect value);
            /*0x7996f2c*/ UnityEngine.Rect get_HardGuideRect();
            /*0x79974b8*/ void set_HardGuideRect(UnityEngine.Rect value);
            /*0x799721c*/ void RotateToScreenBounds(ref Unity.Cinemachine.CameraState state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, ref UnityEngine.Quaternion rigOrientation, float fov, float fovH, float deltaTime);
            /*0x79974f8*/ bool ClampVerticalBounds(ref UnityEngine.Rect r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, float fov);
            /*0x79975d4*/ Unity.Cinemachine.ScreenComposerSettings get_Composition();
            /*0x7997614*/ void set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            /*0x799766c*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineRotationComposer c);

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

                /*0x7996f5c*/ void UpdateCache(Unity.Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, float targetDistance);
                /*0x7997834*/ UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, float fov, float fovH, float aspect);
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

            /*0x7998fa4*/ CinemachineConfiner();
            /*0x7997c34*/ bool CameraWasDisplaced(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7997c4c*/ float GetCameraDisplacementDistance(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
            /*0x7997cb4*/ void Reset();
            /*0x7997cf8*/ void OnValidate();
            /*0x7997d0c*/ void ConnectToVcam(bool connect);
            /*0x7997d18*/ bool get_IsValid();
            /*0x7997e38*/ float GetMaxDampTime();
            /*0x7997e40*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x7998760*/ void InvalidatePathCache();
            /*0x7998764*/ void InvalidateCache();
            /*0x799878c*/ bool ValidatePathCache();
            /*0x7998428*/ UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 camPos);
            /*0x7998024*/ UnityEngine.Vector3 ConfineOrthoCameraToScreenEdges(ref Unity.Cinemachine.CameraState state);
            /*0x7998eb0*/ System.Type UpgradeToCm3_GetTargetType();
            /*0x7998f44*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineConfiner3D c);
            /*0x7998f68*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineConfiner2D c);

            enum Mode
            {
                Confine2D = 0,
                Confine3D = 1,
            }

            class VcamExtraState : Unity.Cinemachine.CinemachineExtension.VcamExtraStateBase
            {
                /*0x18*/ UnityEngine.Vector3 PreviousDisplacement;
                /*0x24*/ float ConfinerDisplacement;

                /*0x7998fb4*/ VcamExtraState();
            }
        }

        class CinemachineDollyCart : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachinePathBase m_Path;
            /*0x28*/ Unity.Cinemachine.CinemachineDollyCart.UpdateMethod m_UpdateMethod;
            /*0x2c*/ Unity.Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
            /*0x30*/ float m_Speed;
            /*0x34*/ float m_Position;

            /*0x79993a4*/ CinemachineDollyCart();
            /*0x7998fbc*/ void FixedUpdate();
            /*0x7999124*/ void Update();
            /*0x79991c0*/ void LateUpdate();
            /*0x7999004*/ void SetCartPosition(float distanceAlongPath);
            /*0x7999260*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineSplineCart c);

            enum UpdateMethod
            {
                Update = 0,
                FixedUpdate = 1,
                LateUpdate = 2,
            }
        }

        class CinemachineDoNotUpgrade : UnityEngine.MonoBehaviour
        {
            /*0x79993b4*/ CinemachineDoNotUpgrade();
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

            static /*0x799ac6c*/ UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Unity.Cinemachine.ICinemachineTargetGroup group, ref UnityEngine.Vector3 pos, UnityEngine.Quaternion orientation);
            /*0x799b2cc*/ CinemachineFramingTransposer();
            /*0x79993bc*/ UnityEngine.Rect get_SoftGuideRect();
            /*0x79993dc*/ void set_SoftGuideRect(UnityEngine.Rect value);
            /*0x7999454*/ UnityEngine.Rect get_HardGuideRect();
            /*0x7999488*/ void set_HardGuideRect(UnityEngine.Rect value);
            /*0x79994c8*/ void OnValidate();
            /*0x7999560*/ bool get_IsValid();
            /*0x79995f0*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79995f8*/ bool get_BodyAppliesAfterAim();
            /*0x7999600*/ UnityEngine.Vector3 get_TrackedPoint();
            /*0x799960c*/ void set_TrackedPoint(UnityEngine.Vector3 value);
            /*0x7999618*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x7999714*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x799977c*/ float GetMaxDampTime();
            /*0x7999798*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x7999974*/ UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, float orthoSize, float aspect);
            /*0x79999c8*/ UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect);
            /*0x7999a84*/ UnityEngine.Bounds get_LastBounds();
            /*0x7999a9c*/ void set_LastBounds(UnityEngine.Bounds value);
            /*0x7999ab4*/ UnityEngine.Matrix4x4 get_LastBoundsMatrix();
            /*0x7999ac8*/ void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value);
            /*0x7999adc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x799abac*/ float GetTargetHeight(UnityEngine.Vector2 boundsSize);
            /*0x799a780*/ UnityEngine.Vector3 ComputeGroupBounds(Unity.Cinemachine.ICinemachineTargetGroup group, ref Unity.Cinemachine.CameraState curState);
            /*0x799b0f0*/ Unity.Cinemachine.ScreenComposerSettings get_Composition();
            /*0x799b140*/ void set_Composition(Unity.Cinemachine.ScreenComposerSettings value);
            /*0x799b198*/ void UpgradeToCm3(Unity.Cinemachine.CinemachinePositionComposer c);
            /*0x799b274*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineGroupFraming c);

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

            static /*0x799bcc0*/ string[] get_RigNames();
            /*0x799f4f8*/ CinemachineFreeLook();
            /*0x799b390*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x799b478*/ bool get_IsDprecated();
            /*0x799b480*/ void OnValidate();
            /*0x799b500*/ Unity.Cinemachine.CinemachineVirtualCamera GetRig(int i);
            /*0x799bca0*/ bool get_RigsAreCreated();
            /*0x799bdb0*/ void OnEnable();
            /*0x799bde0*/ void UpdateInputAxisProvider();
            /*0x799bea4*/ void OnDestroy();
            /*0x799bfd4*/ void OnTransformChildrenChanged();
            /*0x799bfe8*/ void Reset();
            /*0x799c718*/ bool get_PreviousStateIsValid();
            /*0x799c720*/ void set_PreviousStateIsValid(bool value);
            /*0x799c810*/ Unity.Cinemachine.CameraState get_State();
            /*0x799c820*/ UnityEngine.Transform get_LookAt();
            /*0x799c82c*/ void set_LookAt(UnityEngine.Transform value);
            /*0x799c834*/ UnityEngine.Transform get_Follow();
            /*0x799c840*/ void set_Follow(UnityEngine.Transform value);
            /*0x799c848*/ bool IsLiveChild(Unity.Cinemachine.ICinemachineCamera vcam, bool dominantChildOnly);
            /*0x799c96c*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x799ca2c*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x799d43c*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x799d968*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x799dcd8*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();
            /*0x799cc4c*/ float GetYAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up);
            /*0x799dce0*/ float SteepestDescent(UnityEngine.Vector3 cameraOffset);
            /*0x799b4ec*/ void InvalidateRigCache();
            /*0x799c010*/ void DestroyRigs();
            /*0x799dfc0*/ Unity.Cinemachine.CinemachineVirtualCamera[] CreateRigs(Unity.Cinemachine.CinemachineVirtualCamera[] copyFrom);
            /*0x799b558*/ bool UpdateRigCache();
            /*0x799e8b0*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineVirtualCamera> LocateExistingRigs(bool forceOrbital);
            /*0x799ef04*/ float UpdateXAxisHeading(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
            /*0x799d01c*/ void PushSettingsToRigs();
            /*0x799c940*/ float GetYAxisValue();
            /*0x799d7c0*/ Unity.Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x799f070*/ UnityEngine.Vector3 GetLocalPositionForCameraFromInput(float t);
            /*0x799f198*/ void UpdateCachedSpline();
            /*0x799deac*/ float <SteepestDescent>g__AngleFunction|52_0(float input, ref Unity.Cinemachine.CinemachineFreeLook.<> );
            /*0x799df5c*/ float <SteepestDescent>g__SlopeOfAngleFunction|52_1(float input, ref Unity.Cinemachine.CinemachineFreeLook.<> );
            /*0x799ddf4*/ float <SteepestDescent>g__InitialGuess|52_2(ref Unity.Cinemachine.CinemachineFreeLook.<> );
            /*0x799f8b4*/ void <SteepestDescent>g__ChooseBestAngle|52_3(float x, ref Unity.Cinemachine.CinemachineFreeLook.<> , ref Unity.Cinemachine.CinemachineFreeLook.<> );

            struct Orbit
            {
                /*0x10*/ float m_Height;
                /*0x14*/ float m_Radius;

                /*0x799f8e4*/ Orbit(float h, float r);
            }

            struct LegacyTransitionParams
            {
                /*0x10*/ int m_BlendHint;
                /*0x14*/ bool m_InheritPosition;
                /*0x18*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent m_OnCameraLive;
            }

            class CreateRigDelegate : System.MulticastDelegate
            {
                /*0x799f8ec*/ CreateRigDelegate(object object, nint method);
                /*0x799f9f8*/ Unity.Cinemachine.CinemachineVirtualCamera Invoke(Unity.Cinemachine.CinemachineFreeLook vcam, string name, Unity.Cinemachine.CinemachineVirtualCamera copyFrom);
                /*0x799fa0c*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.CinemachineFreeLook vcam, string name, Unity.Cinemachine.CinemachineVirtualCamera copyFrom, System.AsyncCallback callback, object object);
                /*0x799fa40*/ Unity.Cinemachine.CinemachineVirtualCamera EndInvoke(System.IAsyncResult result);
            }

            class DestroyRigDelegate : System.MulticastDelegate
            {
                /*0x799fa4c*/ DestroyRigDelegate(object object, nint method);
                /*0x799fafc*/ void Invoke(UnityEngine.GameObject rig);
                /*0x799fb10*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject rig, System.AsyncCallback callback, object object);
                /*0x799fb30*/ void EndInvoke(System.IAsyncResult result);
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

            static /*0x79a0890*/ UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Unity.Cinemachine.ICinemachineTargetGroup group, UnityEngine.Matrix4x4 observer, ref UnityEngine.Vector3 newFwd);
            /*0x79a0cb8*/ CinemachineGroupComposer();
            /*0x799fb3c*/ void OnValidate();
            /*0x799fbdc*/ void Reset();
            /*0x799fc18*/ UnityEngine.Bounds get_LastBounds();
            /*0x799fc30*/ void set_LastBounds(UnityEngine.Bounds value);
            /*0x799fc48*/ UnityEngine.Matrix4x4 get_LastBoundsMatrix();
            /*0x799fc60*/ void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value);
            /*0x799fc78*/ float GetMaxDampTime();
            /*0x799fc9c*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a0b68*/ float GetTargetHeight(UnityEngine.Vector2 boundsSize);
            /*0x79a0c58*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineGroupFraming c);

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

            /*0x79a0cf4*/ void Validate();
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

            /*0x79a0d08*/ void Validate();
            /*0x79a0d20*/ bool Update(float deltaTime, ref Unity.Cinemachine.AxisBase axis);
            /*0x79a1008*/ bool Update(float deltaTime, ref Unity.Cinemachine.AxisState axis);
            /*0x79a0f9c*/ float ClampValue(ref Unity.Cinemachine.AxisBase axis, float v);
        }

        class CinemachineInputProvider : UnityEngine.MonoBehaviour, Unity.Cinemachine.AxisState.IInputAxisProvider
        {
            static int NUM_AXES = 3;
            /*0x20*/ int PlayerIndex;
            /*0x24*/ bool AutoEnableInputs;
            /*0x28*/ UnityEngine.InputSystem.InputActionReference XYAxis;
            /*0x30*/ UnityEngine.InputSystem.InputActionReference ZAxis;
            /*0x38*/ UnityEngine.InputSystem.InputAction[] m_cachedActions;

            static /*0x79a14fc*/ UnityEngine.InputSystem.InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(ref UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.InputActionReference aRef);
            /*0x79a163c*/ CinemachineInputProvider();
            /*0x79a1058*/ float GetAxisValue(int axis);
            /*0x79a1148*/ UnityEngine.InputSystem.InputAction ResolveForPlayer(int axis, UnityEngine.InputSystem.InputActionReference actionRef);
            /*0x79a1630*/ void OnDisable();

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionReference aRef;

                /*0x79a1654*/ <>c__DisplayClass7_0();
                /*0x79a165c*/ bool <ResolveForPlayer>b__1(UnityEngine.InputSystem.InputAction x);
            }
        }

        class CinemachineInputProviderExtensions
        {
            static /*0x79a16c0*/ Unity.Cinemachine.AxisState.IInputAxisProvider GetInputAxisProvider(Unity.Cinemachine.CinemachineVirtualCameraBase vcam);
        }

        class CinemachineLegacyCameraEvents : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent OnCameraLive;
            /*0x28*/ Unity.Cinemachine.CinemachineVirtualCameraBase m_Vcam;

            /*0x79a1a04*/ CinemachineLegacyCameraEvents();
            /*0x79a1780*/ void OnEnable();
            /*0x79a18c0*/ void OnDisable();
            /*0x79a1990*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);

            class OnCameraLiveEvent : UnityEngine.Events.UnityEvent<Unity.Cinemachine.ICinemachineCamera, Unity.Cinemachine.ICinemachineCamera>
            {
                /*0x79a1a6c*/ OnCameraLiveEvent();
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

            static /*0x79a1c24*/ float Decay(float time);
            /*0x79a1ab4*/ HeadingTracker(int filterSize);
            /*0x79a1c08*/ int get_FilterSize();
            /*0x79a1ba4*/ void ClearHistory();
            /*0x79a1c7c*/ void Add(UnityEngine.Vector3 velocity);
            /*0x79a1e94*/ void PopBottom();
            /*0x79a1fdc*/ void DecayHistory();
            /*0x79a20cc*/ UnityEngine.Vector3 GetReliableHeading();

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

            /*0x79a3b00*/ CinemachineOrbitalTransposer();
            /*0x79a2220*/ void OnValidate();
            /*0x79a2350*/ float UpdateHeading(float deltaTime, UnityEngine.Vector3 up, ref Unity.Cinemachine.AxisState axis);
            /*0x79a235c*/ float UpdateHeading(float deltaTime, UnityEngine.Vector3 up, ref Unity.Cinemachine.AxisState axis, ref Unity.Cinemachine.AxisState.Recentering recentering, bool isLive);
            /*0x79a287c*/ void OnEnable();
            /*0x79a29d8*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();
            /*0x79a28f0*/ void UpdateInputAxisProvider();
            /*0x79a29e0*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79a2bb0*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79a2fd4*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79a2cf8*/ float GetAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up);
            /*0x79a31a8*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a3830*/ UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp);
            /*0x79a24ac*/ float GetTargetHeading(float currentHeading, UnityEngine.Quaternion targetOrientation);
            /*0x79a3a00*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineOrbitalFollow c);

            struct Heading
            {
                /*0x10*/ Unity.Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition;
                /*0x14*/ int m_VelocityFilterStrength;
                /*0x18*/ float m_Bias;

                /*0x79a3d04*/ Heading(Unity.Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias);

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
                /*0x79a3d10*/ UpdateHeadingDelegate(object object, nint method);
                /*0x79a3ea0*/ float Invoke(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
                /*0x79a3eb4*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up, System.AsyncCallback callback, object object);
                /*0x79a3f70*/ float EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineOrbitalTransposer.<> <>9;
                static /*0x8*/ Unity.Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate <>9__31_0;

                static /*0x79a3f98*/ <>c();
                /*0x79a4000*/ <>c();
                /*0x79a4008*/ float <.ctor>b__31_0(Unity.Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
            }
        }

        class CinemachinePath : Unity.Cinemachine.CinemachinePathBase
        {
            /*0x50*/ bool m_Looped;
            /*0x58*/ Unity.Cinemachine.CinemachinePath.Waypoint[] m_Waypoints;

            static /*0x79a4980*/ UnityEngine.Quaternion RollAroundForward(float angle);
            /*0x79a49b8*/ CinemachinePath();
            /*0x79a40d0*/ float get_MinPos();
            /*0x79a40d8*/ float get_MaxPos();
            /*0x79a4118*/ bool get_Looped();
            /*0x79a4120*/ void Reset();
            /*0x79a4254*/ void OnValidate();
            /*0x79a4264*/ int get_DistanceCacheSampleStepsPerSegment();
            /*0x79a426c*/ float GetBoundingIndices(float pos, ref int indexA, ref int indexB);
            /*0x79a4494*/ UnityEngine.Vector3 EvaluateLocalPosition(float pos);
            /*0x79a45dc*/ UnityEngine.Vector3 EvaluateLocalTangent(float pos);
            /*0x79a4724*/ UnityEngine.Quaternion EvaluateLocalOrientation(float pos);
            /*0x79a48c0*/ float GetRoll(int indexA, int indexB, float standardizedPos);

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

            /*0x79a4a18*/ CinemachinePathBase();
            /*0x380c2e4*/ float get_MinPos();
            /*0x380c2e4*/ float get_MaxPos();
            /*0x380b128*/ bool get_Looped();
            /*0x79a4aac*/ float StandardizePos(float pos);
            /*0x79a4b58*/ UnityEngine.Vector3 EvaluatePosition(float pos);
            /*0x79a4bac*/ UnityEngine.Vector3 EvaluateTangent(float pos);
            /*0x79a4c00*/ UnityEngine.Quaternion EvaluateOrientation(float pos);
            UnityEngine.Vector3 EvaluateLocalPosition(float pos);
            UnityEngine.Vector3 EvaluateLocalTangent(float pos);
            UnityEngine.Quaternion EvaluateLocalOrientation(float pos);
            /*0x79a4cdc*/ float FindClosestPoint(UnityEngine.Vector3 p, int startSegment, int searchRadius, int stepsPerSegment);
            /*0x79a5090*/ float MinUnit(Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a50b0*/ float MaxUnit(Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a5138*/ float StandardizeUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a5244*/ UnityEngine.Vector3 EvaluatePositionAtUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a53f8*/ UnityEngine.Vector3 EvaluateTangentAtUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a5418*/ UnityEngine.Quaternion EvaluateOrientationAtUnit(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x380b6a0*/ int get_DistanceCacheSampleStepsPerSegment();
            /*0x79a5438*/ void InvalidateDistanceCache();
            /*0x79a5468*/ bool DistanceCacheIsValid();
            /*0x79a50d8*/ float get_PathLength();
            /*0x79a51c0*/ float StandardizePathDistance(float distance);
            /*0x79a5264*/ float ToNativePathUnits(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a58c0*/ float FromPathNativeUnits(float pos, Unity.Cinemachine.CinemachinePathBase.PositionUnits units);
            /*0x79a5a28*/ void OnEnable();
            /*0x79a54fc*/ void ResamplePath(int stepsPerSegment);

            class Appearance
            {
                /*0x10*/ UnityEngine.Color pathColor;
                /*0x20*/ UnityEngine.Color inactivePathColor;
                /*0x30*/ float width;

                /*0x79a422c*/ Appearance();
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
            /*0x79a5a2c*/ CinemachinePipeline();
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

            static /*0x79a62f8*/ float NormalizeAngle(float angle);
            /*0x79a6884*/ CinemachinePOV();
            /*0x79a5a34*/ float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue();
            /*0x79a5a6c*/ bool get_IsValid();
            /*0x79a5a74*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79a5a7c*/ void OnValidate();
            /*0x79a5ab8*/ void OnEnable();
            /*0x79a5bf0*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();
            /*0x79a5ad4*/ void UpdateInputAxisProvider();
            /*0x79a5bf8*/ void PrePipelineMutateCameraState(ref Unity.Cinemachine.CameraState state, float deltaTime);
            /*0x79a5bfc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a6094*/ UnityEngine.Vector2 GetRecenterTarget();
            /*0x79a6328*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79a667c*/ bool OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79a633c*/ void SetAxesForRotation(UnityEngine.Quaternion targetRot);
            /*0x79a6818*/ void UpgradeToCm3(Unity.Cinemachine.CinemachinePanTilt c);

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

            /*0x79a6c34*/ CinemachineSameAsFollowTarget();
            /*0x79a6a2c*/ bool get_IsValid();
            /*0x79a6abc*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79a6ac4*/ float GetMaxDampTime();
            /*0x79a6acc*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a6c18*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineRotateWithFollowTarget c);
        }

        class CinemachineSmoothPath : Unity.Cinemachine.CinemachinePathBase
        {
            /*0x50*/ bool m_Looped;
            /*0x58*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint[] m_Waypoints;
            /*0x60*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints1;
            /*0x68*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints2;
            /*0x70*/ bool m_IsLoopedCache;

            static /*0x79a770c*/ UnityEngine.Quaternion RollAroundForward(float angle);
            /*0x79a7744*/ CinemachineSmoothPath();
            /*0x79a6c8c*/ float get_MinPos();
            /*0x79a6c94*/ float get_MaxPos();
            /*0x79a6cd4*/ bool get_Looped();
            /*0x79a6cdc*/ int get_DistanceCacheSampleStepsPerSegment();
            /*0x79a6ce4*/ void OnValidate();
            /*0x79a6cf4*/ void Reset();
            /*0x79a6df0*/ void InvalidateDistanceCache();
            /*0x79a6e3c*/ void UpdateControlPoints();
            /*0x79a70c4*/ float GetBoundingIndices(float pos, ref int indexA, ref int indexB);
            /*0x79a71ec*/ UnityEngine.Vector3 EvaluateLocalPosition(float pos);
            /*0x79a734c*/ UnityEngine.Vector3 EvaluateLocalTangent(float pos);
            /*0x79a74c8*/ UnityEngine.Quaternion EvaluateLocalOrientation(float pos);

            struct Waypoint
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ float roll;

                static /*0x79a70c0*/ Unity.Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(UnityEngine.Vector4 v);
                /*0x79a70b4*/ UnityEngine.Vector4 get_AsVector4();
            }
        }

        class CinemachineTouchInputMapper : UnityEngine.MonoBehaviour
        {
            /*0x20*/ float TouchSensitivityX;
            /*0x24*/ float TouchSensitivityY;
            /*0x28*/ string TouchXInputMapTo;
            /*0x30*/ string TouchYInputMapTo;

            /*0x79a7914*/ CinemachineTouchInputMapper();
            /*0x79a77a4*/ void Start();
            /*0x79a7850*/ float GetInputAxis(string axisName);
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

            /*0x79a8698*/ CinemachineTrackedDolly();
            /*0x79a79a0*/ bool get_IsValid();
            /*0x79a7a20*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79a7a28*/ float GetMaxDampTime();
            /*0x79a7af0*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a830c*/ UnityEngine.Quaternion GetCameraOrientationAtPathPoint(UnityEngine.Quaternion pathOrientation, UnityEngine.Vector3 up);
            /*0x79a7a6c*/ UnityEngine.Vector3 get_AngularDamping();
            /*0x79a8514*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineSplineDolly c);

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

                /*0x79a87a4*/ AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment);
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

            /*0x79a3e1c*/ CinemachineTransposer();
            /*0x79a3804*/ Unity.Cinemachine.TargetTracking.TrackerSettings get_TrackerSettings();
            /*0x79a2320*/ void OnValidate();
            /*0x79a87b8*/ bool get_HideOffsetInInspector();
            /*0x79a87c0*/ void set_HideOffsetInInspector(bool value);
            /*0x79a3180*/ UnityEngine.Vector3 get_EffectiveOffset();
            /*0x79a87cc*/ bool get_IsValid();
            /*0x79a885c*/ Unity.Cinemachine.CinemachineCore.Stage get_Stage();
            /*0x79a8864*/ float GetMaxDampTime();
            /*0x79a88ac*/ void MutateCameraState(ref Unity.Cinemachine.CameraState curState, float deltaTime);
            /*0x79a2ac8*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79a2c44*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79a8b3c*/ UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 up);
            /*0x79a8b50*/ UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp);
            /*0x79a8c40*/ void UpgradeToCm3(Unity.Cinemachine.CinemachineFollow c);
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

            static /*0x79aab08*/ void SetFlagsForHiddenChild(UnityEngine.GameObject child);
            /*0x79ab2e8*/ CinemachineVirtualCamera();
            /*0x79a8ca4*/ void PerformLegacyUpgrade(int streamedVersion);
            /*0x79a8d3c*/ bool get_IsDprecated();
            /*0x79a8d44*/ Unity.Cinemachine.CameraState get_State();
            /*0x79a8d54*/ UnityEngine.Transform get_LookAt();
            /*0x79a8d60*/ void set_LookAt(UnityEngine.Transform value);
            /*0x79a8d68*/ UnityEngine.Transform get_Follow();
            /*0x79a8d74*/ void set_Follow(UnityEngine.Transform value);
            /*0x79a8d7c*/ float GetMaxDampTime();
            /*0x79a9504*/ void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79a9b80*/ void OnEnable();
            /*0x79a9d04*/ void OnDestroy();
            /*0x79aa08c*/ void OnValidate();
            /*0x79aa178*/ void OnTransformChildrenChanged();
            /*0x79aa18c*/ void Reset();
            /*0x79aa1b4*/ void DestroyPipeline();
            /*0x79aa868*/ UnityEngine.Transform CreatePipeline(Unity.Cinemachine.CinemachineVirtualCamera copyFrom);
            /*0x79a9cf0*/ void InvalidateComponentPipeline();
            /*0x79aaa64*/ UnityEngine.Transform GetComponentOwner();
            /*0x79aaa4c*/ Unity.Cinemachine.CinemachineComponentBase[] GetComponentPipeline();
            /*0x79aaa7c*/ Unity.Cinemachine.CinemachineComponentBase GetCinemachineComponent(Unity.Cinemachine.CinemachineCore.Stage stage);
            /*0x3907c14*/ T GetCinemachineComponent<T>();
            /*0x3907c14*/ T AddCinemachineComponent<T>();
            /*0x380cb08*/ void DestroyCinemachineComponent<T>();
            /*0x79a8e0c*/ void UpdateComponentPipeline();
            /*0x79a96fc*/ Unity.Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79aab98*/ void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta);
            /*0x79aad10*/ void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x79aae60*/ void SetStateRawPosition(UnityEngine.Vector3 pos);
            /*0x79aae70*/ void OnTransitionFromCamera(Unity.Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime);
            /*0x79ab1dc*/ bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput();

            struct LegacyTransitionParams
            {
                /*0x10*/ int m_BlendHint;
                /*0x14*/ bool m_InheritPosition;
                /*0x18*/ Unity.Cinemachine.CinemachineLegacyCameraEvents.OnCameraLiveEvent m_OnCameraLive;
            }

            class CreatePipelineDelegate : System.MulticastDelegate
            {
                /*0x79ab55c*/ CreatePipelineDelegate(object object, nint method);
                /*0x79ab668*/ UnityEngine.Transform Invoke(Unity.Cinemachine.CinemachineVirtualCamera vcam, string name, Unity.Cinemachine.CinemachineComponentBase[] copyFrom);
                /*0x79ab67c*/ System.IAsyncResult BeginInvoke(Unity.Cinemachine.CinemachineVirtualCamera vcam, string name, Unity.Cinemachine.CinemachineComponentBase[] copyFrom, System.AsyncCallback callback, object object);
                /*0x79ab6b0*/ UnityEngine.Transform EndInvoke(System.IAsyncResult result);
            }

            class DestroyPipelineDelegate : System.MulticastDelegate
            {
                /*0x79ab6bc*/ DestroyPipelineDelegate(object object, nint method);
                /*0x79ab76c*/ void Invoke(UnityEngine.GameObject pipeline);
                /*0x79ab780*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject pipeline, System.AsyncCallback callback, object object);
                /*0x79ab7a0*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachineVirtualCamera.<> <>9;
                static /*0x8*/ System.Comparison<Unity.Cinemachine.CinemachineComponentBase> <>9__44_0;

                static /*0x79ab7ac*/ <>c();
                /*0x79ab814*/ <>c();
                /*0x79ab81c*/ int <UpdateComponentPipeline>b__44_0(Unity.Cinemachine.CinemachineComponentBase c1, Unity.Cinemachine.CinemachineComponentBase c2);
            }
        }

        class VcamTargetPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79ab86c*/ VcamTargetPropertyAttribute();
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

            static /*0x79ab4b8*/ Unity.Cinemachine.LegacyLensSettings get_Default();
            /*0x79a9c58*/ Unity.Cinemachine.LensSettings ToLensSettings();
            /*0x79ab874*/ void SetFromLensSettings(Unity.Cinemachine.LensSettings src);
            /*0x79aa094*/ void Validate();
        }

        class CinemachineBrainEvents : Unity.Cinemachine.CinemachineMixerEventsBase
        {
            /*0x48*/ Unity.Cinemachine.CinemachineBrain Brain;
            /*0x50*/ Unity.Cinemachine.CinemachineCore.BrainEvent BrainUpdatedEvent;

            /*0x79ac064*/ CinemachineBrainEvents();
            /*0x79ab900*/ Unity.Cinemachine.ICinemachineMixer GetMixer();
            /*0x79ab908*/ void OnEnable();
            /*0x79abcc0*/ void OnDisable();
            /*0x79abfb8*/ void OnCameraUpdated(Unity.Cinemachine.CinemachineBrain brain);
        }

        class CinemachineCameraEvents : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Unity.Cinemachine.CinemachineVirtualCameraBase EventTarget;
            /*0x28*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraActivatedEvent;
            /*0x30*/ Unity.Cinemachine.CinemachineCore.CameraEvent CameraDeactivatedEvent;
            /*0x38*/ Unity.Cinemachine.CinemachineCore.BlendEvent BlendCreatedEvent;
            /*0x40*/ Unity.Cinemachine.CinemachineCore.CameraEvent BlendFinishedEvent;

            /*0x79ac8c4*/ CinemachineCameraEvents();
            /*0x79ac1e4*/ void OnEnable();
            /*0x79ac49c*/ void OnDisable();
            /*0x79ac6bc*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x79ac730*/ void OnBlendCreated(Unity.Cinemachine.CinemachineCore.BlendEventParams evt);
            /*0x79ac7bc*/ void OnBlendFinished(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
            /*0x79ac840*/ void OnCameraDeactivated(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
        }

        class CinemachineCameraManagerEvents : Unity.Cinemachine.CinemachineMixerEventsBase
        {
            /*0x48*/ Unity.Cinemachine.CinemachineCameraManagerBase CameraManager;

            /*0x79aca64*/ CinemachineCameraManagerEvents();
            /*0x79ac9b8*/ Unity.Cinemachine.ICinemachineMixer GetMixer();
            /*0x79ac9c0*/ void OnEnable();
            /*0x79aca60*/ void OnDisable();
        }

        class CinemachineInputAxisController : Unity.Cinemachine.InputAxisControllerBase<Unity.Cinemachine.CinemachineInputAxisController.Reader>
        {
            static /*0x0*/ Unity.Cinemachine.CinemachineInputAxisController.SetControlDefaultsForAxis SetControlDefaults;
            /*0x30*/ int PlayerIndex;
            /*0x34*/ bool AutoEnableInputs;
            /*0x38*/ Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader ReadControlValueOverride;

            /*0x79acbbc*/ CinemachineInputAxisController();
            /*0x79aca68*/ void Reset();
            /*0x79acac4*/ void InitializeControllerDefaultsForAxis(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller);
            /*0x79acb38*/ void Update();

            class SetControlDefaultsForAxis : System.MulticastDelegate
            {
                /*0x79acc14*/ SetControlDefaultsForAxis(object object, nint method);
                /*0x79accc8*/ void Invoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, ref Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller);
                /*0x79accdc*/ System.IAsyncResult BeginInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, ref Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller, System.AsyncCallback callback, object object);
                /*0x79acd74*/ void EndInvoke(ref Unity.Cinemachine.IInputAxisOwner.AxisDescriptor axis, ref Unity.Cinemachine.InputAxisControllerBase.Controller<Unity.Cinemachine.CinemachineInputAxisController.Reader> controller, System.IAsyncResult result);
            }

            class Reader : Unity.Cinemachine.IInputAxisReader
            {
                /*0x10*/ UnityEngine.InputSystem.InputActionReference InputAction;
                /*0x18*/ float Gain;
                /*0x20*/ UnityEngine.InputSystem.InputAction m_CachedAction;
                /*0x28*/ bool CancelDeltaTime;

                static /*0x79ad138*/ UnityEngine.InputSystem.InputAction <ResolveAndReadInputAction>g__GetFirstMatch|6_0(ref UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.InputActionReference aRef);
                /*0x79ad778*/ Reader();
                /*0x79acd90*/ float GetValue(UnityEngine.Object context, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint);
                /*0x79ace98*/ float ResolveAndReadInputAction(Unity.Cinemachine.CinemachineInputAxisController context, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint);
                /*0x79ad470*/ float ReadInput(UnityEngine.InputSystem.InputAction action, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint, UnityEngine.Object context, Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader defaultReader);

                class ControlValueReader : System.MulticastDelegate
                {
                    /*0x79ad3bc*/ ControlValueReader(object object, nint method);
                    /*0x79ad788*/ float Invoke(UnityEngine.InputSystem.InputAction action, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint, UnityEngine.Object context, Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader defaultReader);
                    /*0x79ad79c*/ System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.InputAction action, Unity.Cinemachine.IInputAxisOwner.AxisDescriptor.Hints hint, UnityEngine.Object context, Unity.Cinemachine.CinemachineInputAxisController.Reader.ControlValueReader defaultReader, System.AsyncCallback callback, object object);
                    /*0x79ad84c*/ float EndInvoke(System.IAsyncResult result);
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

            /*0x79ac0cc*/ CinemachineMixerEventsBase();
            /*0x380b9e8*/ Unity.Cinemachine.ICinemachineMixer GetMixer();
            /*0x79aba80*/ void InstallHandlers(Unity.Cinemachine.ICinemachineMixer mixer);
            /*0x79abd98*/ void UninstallHandlers();
            /*0x79ad874*/ void OnCameraActivated(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            /*0x79ad928*/ void OnCameraDeactivated(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
            /*0x79ad9b8*/ void OnBlendCreated(Unity.Cinemachine.CinemachineCore.BlendEventParams evt);
            /*0x79ada48*/ void OnBlendFinished(Unity.Cinemachine.ICinemachineMixer mixer, Unity.Cinemachine.ICinemachineCamera cam);
        }

        class CinemachineSplineSmoother : UnityEngine.MonoBehaviour
        {
            /*0x20*/ bool AutoSmooth;

            /*0x79adf90*/ CinemachineSplineSmoother();
            /*0x79adad8*/ void SmoothSplineNow();
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

            /*0x79ae73c*/ CinemachineTriggerAction();
            /*0x79adfa0*/ bool Filter(UnityEngine.GameObject other);
            /*0x79ae044*/ void InternalDoTriggerEnter(UnityEngine.GameObject other);
            /*0x79ae530*/ void InternalDoTriggerExit(UnityEngine.GameObject other);
            /*0x79ae5d8*/ void OnTriggerEnter(UnityEngine.Collider other);
            /*0x79ae604*/ void OnTriggerExit(UnityEngine.Collider other);
            /*0x79ae630*/ void OnCollisionEnter(UnityEngine.Collision other);
            /*0x79ae65c*/ void OnCollisionExit(UnityEngine.Collision other);
            /*0x79ae688*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
            /*0x79ae6b4*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
            /*0x79ae6e0*/ void OnCollisionEnter2D(UnityEngine.Collision2D other);
            /*0x79ae70c*/ void OnCollisionExit2D(UnityEngine.Collision2D other);
            /*0x79ae738*/ void OnEnable();

            struct ActionSettings
            {
                /*0x10*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.ActionModes Action;
                /*0x18*/ UnityEngine.Object Target;
                /*0x20*/ int BoostAmount;
                /*0x24*/ float StartTime;
                /*0x28*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModes Mode;
                /*0x30*/ Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.TriggerEvent Event;

                /*0x79ae88c*/ ActionSettings(Unity.Cinemachine.CinemachineTriggerAction.ActionSettings.ActionModes action);
                /*0x79ae0dc*/ void Invoke();

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
                    /*0x79ae914*/ TriggerEvent();
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

            /*0x79aebb4*/ GroupWeightManipulator();
            /*0x79ae91c*/ void Start();
            /*0x79ae968*/ void OnValidate();
            /*0x79ae9b0*/ void Update();
            /*0x79aea28*/ void UpdateWeights();
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

            /*0x79af7e4*/ CinemachineCollisionImpulseSource();
            /*0x79aebc4*/ void Reset();
            /*0x79aec0c*/ void Start();
            /*0x79aec84*/ void OnEnable();
            /*0x79aec88*/ void OnCollisionEnter(UnityEngine.Collision c);
            /*0x79aefbc*/ void OnTriggerEnter(UnityEngine.Collider c);
            /*0x79af018*/ float GetMassAndVelocity(UnityEngine.Collider other, ref UnityEngine.Vector3 vel);
            /*0x79aecd0*/ void GenerateImpactEvent(UnityEngine.Collider other, UnityEngine.Vector3 vel);
            /*0x79af238*/ void OnCollisionEnter2D(UnityEngine.Collision2D c);
            /*0x79af570*/ void OnTriggerEnter2D(UnityEngine.Collider2D c);
            /*0x79af5cc*/ float GetMassAndVelocity2D(UnityEngine.Collider2D other2d, ref UnityEngine.Vector3 vel);
            /*0x79af284*/ void GenerateImpactEvent2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3 vel);
        }

        class CinemachineFixedSignal : Unity.Cinemachine.SignalSourceAsset
        {
            /*0x18*/ UnityEngine.AnimationCurve XCurve;
            /*0x20*/ UnityEngine.AnimationCurve YCurve;
            /*0x28*/ UnityEngine.AnimationCurve ZCurve;

            /*0x79afa28*/ CinemachineFixedSignal();
            /*0x79af82c*/ float get_SignalDuration();
            /*0x79af874*/ float AxisDuration(UnityEngine.AnimationCurve axis);
            /*0x79af934*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            /*0x79af9dc*/ float AxisValue(UnityEngine.AnimationCurve axis, float time);
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

            static /*0x79afb04*/ void CreateStandardShapes();
            static /*0x79b076c*/ UnityEngine.AnimationCurve GetStandardCurve(Unity.Cinemachine.CinemachineImpulseDefinition.ImpulseShapes shape);
            /*0x79b101c*/ CinemachineImpulseDefinition();
            /*0x79afa30*/ void OnValidate();
            /*0x79b07ec*/ UnityEngine.AnimationCurve get_ImpulseCurve();
            /*0x79b083c*/ void CreateEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79b0840*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79b0a58*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);

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

                /*0x79b0de8*/ SignalSource(Unity.Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity);
                /*0x79b10fc*/ float get_SignalDuration();
                /*0x79b1118*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            }

            class LegacySignalSource : Unity.Cinemachine.ISignalSource6D
            {
                /*0x10*/ Unity.Cinemachine.CinemachineImpulseDefinition m_Def;
                /*0x18*/ UnityEngine.Vector3 m_Velocity;
                /*0x24*/ float m_StartTimeOffset;

                /*0x79b0f74*/ LegacySignalSource(Unity.Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity);
                /*0x79b11c8*/ float get_SignalDuration();
                /*0x79b11f0*/ void GetSignal(float timeSinceSignalStart, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
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

            /*0x79b1f2c*/ CinemachineImpulseListener();
            /*0x79b1420*/ void Reset();
            /*0x79b1464*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

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

                /*0x79b1f3c*/ void ReSeed();
                /*0x79b1b9c*/ bool GetReaction(float deltaTime, UnityEngine.Vector3 impulsePos, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            }
        }

        class CinemachineImpulseChannelPropertyAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79b1fac*/ CinemachineImpulseChannelPropertyAttribute();
        }

        class CinemachineImpulseManager
        {
            static float Epsilon = 0.00009999999747378752;
            static /*0x0*/ Unity.Cinemachine.CinemachineImpulseManager s_Instance;
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents;
            /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents;
            /*0x20*/ bool IgnoreTimeScale;

            static /*0x79b0c84*/ Unity.Cinemachine.CinemachineImpulseManager get_Instance();
            static /*0x79b1fbc*/ void InitializeModule();
            static /*0x79b20d8*/ float EvaluateDissipationScale(float spread, float normalizedDistance);
            /*0x79b1fb4*/ CinemachineImpulseManager();
            /*0x79b1788*/ bool GetImpulseAt(UnityEngine.Vector3 listenerLocation, bool distance2D, int channelMask, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
            /*0x79b2174*/ float get_CurrentTime();
            /*0x79b0d0c*/ Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent NewImpulseEvent();
            /*0x79b0e40*/ void AddImpulseEvent(Unity.Cinemachine.CinemachineImpulseManager.ImpulseEvent e);
            /*0x79b2014*/ void Clear();

            struct EnvelopeDefinition
            {
                /*0x10*/ UnityEngine.AnimationCurve AttackShape;
                /*0x18*/ UnityEngine.AnimationCurve DecayShape;
                /*0x20*/ float AttackTime;
                /*0x24*/ float SustainTime;
                /*0x28*/ float DecayTime;
                /*0x2c*/ bool ScaleWithImpact;
                /*0x2d*/ bool HoldForever;

                static /*0x79b21e0*/ Unity.Cinemachine.CinemachineImpulseManager.EnvelopeDefinition get_Default();
                /*0x79b2208*/ float get_Duration();
                /*0x79b222c*/ float GetValueAt(float offset);
                /*0x79b2350*/ void ChangeStopTime(float offset, bool forceNoDecay);
                /*0x79b2380*/ void Clear();
                /*0x79b23b4*/ void Validate();
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

                /*0x79b2a88*/ ImpulseEvent();
                /*0x79b23d8*/ bool get_Expired();
                /*0x79b246c*/ void Cancel(float time, bool forceNoDecay);
                /*0x79b24a8*/ float DistanceDecay(float distance);
                /*0x79b2578*/ bool GetDecayedSignal(UnityEngine.Vector3 listenerPosition, bool use2D, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
                /*0x79b29dc*/ void Clear();

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

            /*0x79b2cc4*/ CinemachineImpulseSource();
            /*0x79b2a90*/ void OnValidate();
            /*0x79b2aac*/ void Reset();
            /*0x79b2bbc*/ void GenerateImpulseAtPositionWithVelocity(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79b2bd0*/ void GenerateImpulseWithVelocity(UnityEngine.Vector3 velocity);
            /*0x79b2c3c*/ void GenerateImpulseWithForce(float force);
            /*0x79b2c9c*/ void GenerateImpulse();
            /*0x79b2ca8*/ void GenerateImpulseAt(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity);
            /*0x79b2cbc*/ void GenerateImpulse(UnityEngine.Vector3 velocity);
            /*0x79b2cc0*/ void GenerateImpulse(float force);
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

            /*0x79b3260*/ CinemachineExternalImpulseListener();
            /*0x79b2d70*/ void Reset();
            /*0x79b2db0*/ void OnEnable();
            /*0x79b2e40*/ void Update();
            /*0x79b2f6c*/ void LateUpdate();
        }

        class CinemachineAutoFocus : Unity.Cinemachine.CinemachineExtension
        {
            /*0x30*/ Unity.Cinemachine.CinemachineAutoFocus.FocusTrackingMode FocusTarget;
            /*0x38*/ UnityEngine.Transform CustomTarget;
            /*0x40*/ float FocusDepthOffset;
            /*0x44*/ float Damping;

            /*0x79b35b8*/ CinemachineAutoFocus();
            /*0x79b3268*/ void Reset();
            /*0x79b329c*/ void OnValidate();
            /*0x79b32b0*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

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

                /*0x79b35c0*/ VcamExtraState();
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

            static /*0x79b4ae8*/ CinemachinePostProcessing();
            static /*0x79b3dcc*/ void OnCameraCut(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            static /*0x79b40c4*/ void ApplyPostFX(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79b43f0*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume> GetDynamicBrainVolumes(Unity.Cinemachine.CinemachineBrain brain, UnityEngine.Rendering.PostProcessing.PostProcessLayer ppLayer, int minVolumes);
            static /*0x79b3efc*/ UnityEngine.Rendering.PostProcessing.PostProcessLayer GetPPLayer(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79b47a8*/ void CleanupLookupTable();
            static /*0x79b4820*/ void InitializeModule();
            /*0x79b4ad8*/ CinemachinePostProcessing();
            /*0x79b35c8*/ float get_CalculatedFocusDistance();
            /*0x79b35d0*/ void set_CalculatedFocusDistance(float value);
            /*0x79b35d8*/ bool get_IsValid();
            /*0x79b3674*/ void OnValidate();
            /*0x79b3688*/ void Reset();
            /*0x79b36bc*/ void OnEnable();
            /*0x79b37cc*/ void OnDestroy();
            /*0x79b36c0*/ void InvalidateCachedProfile();
            /*0x79b3890*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

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

                /*0x79b4c00*/ VcamExtraState();
                /*0x79b3c14*/ void CreateProfileCopy(UnityEngine.Rendering.PostProcessing.PostProcessProfile source);
                /*0x79b37e8*/ void DestroyProfileCopy();
            }

            class <>c
            {
                static /*0x0*/ Unity.Cinemachine.CinemachinePostProcessing.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> <>9__29_0;

                static /*0x79b4c08*/ <>c();
                /*0x79b4c70*/ <>c();
                /*0x79b4c78*/ void <InitializeModule>b__29_0(UnityEngine.SceneManagement.Scene scene);
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

            static /*0x79b5ef4*/ CinemachineVolumeSettings();
            static /*0x79b54ec*/ void OnCameraCut(Unity.Cinemachine.ICinemachineCamera.ActivationEventParams evt);
            static /*0x79b5634*/ void ApplyPostFX(Unity.Cinemachine.CinemachineBrain brain);
            static /*0x79b58ec*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GetDynamicBrainVolumes(Unity.Cinemachine.CinemachineBrain brain, int minVolumes);
            static /*0x79b5d00*/ void InitializeModule();
            /*0x79b5ee4*/ CinemachineVolumeSettings();
            /*0x79b4cc4*/ float get_CalculatedFocusDistance();
            /*0x79b4ccc*/ void set_CalculatedFocusDistance(float value);
            /*0x79b4cd4*/ bool get_IsValid();
            /*0x79b4d70*/ void InvalidateCachedProfile();
            /*0x79b4f24*/ void OnValidate();
            /*0x79b4f38*/ void Reset();
            /*0x79b4f6c*/ void OnEnable();
            /*0x79b4f70*/ void OnDestroy();
            /*0x79b4f8c*/ void PostPipelineStageCallback(Unity.Cinemachine.CinemachineVirtualCameraBase vcam, Unity.Cinemachine.CinemachineCore.Stage stage, ref Unity.Cinemachine.CameraState state, float deltaTime);

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

                /*0x79b5f94*/ VcamExtraState();
                /*0x79b5324*/ void CreateProfileCopy(UnityEngine.Rendering.VolumeProfile source);
                /*0x79b4e7c*/ void DestroyProfileCopy();
            }
        }

        class SaveDuringPlayAttribute : System.Attribute
        {
            /*0x79b5f9c*/ SaveDuringPlayAttribute();
        }

        class NoSaveDuringPlayAttribute : UnityEngine.PropertyAttribute
        {
            /*0x79b5fa4*/ NoSaveDuringPlayAttribute();
        }

        struct Point64
        {
            /*0x10*/ long X;
            /*0x18*/ long Y;

            static /*0x79b65a4*/ bool op_Equality(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            static /*0x79b65bc*/ bool op_Inequality(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            static /*0x79b65d4*/ Unity.Cinemachine.Point64 op_Addition(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            static /*0x79b65e0*/ Unity.Cinemachine.Point64 op_Subtraction(Unity.Cinemachine.Point64 lhs, Unity.Cinemachine.Point64 rhs);
            /*0x79b5fac*/ Point64(Unity.Cinemachine.Point64 pt);
            /*0x79b5fb4*/ Point64(long x, long y);
            /*0x79b5fbc*/ Point64(double x, double y);
            /*0x79b612c*/ Point64(Unity.Cinemachine.PointD pt);
            /*0x79b629c*/ Point64(Unity.Cinemachine.Point64 pt, double scale);
            /*0x79b6428*/ Point64(Unity.Cinemachine.PointD pt, double scale);
            /*0x79b65ec*/ string ToString();
            /*0x79b6688*/ bool Equals(object obj);
            /*0x79b670c*/ int GetHashCode();
        }

        struct PointD
        {
            /*0x10*/ double x;
            /*0x18*/ double y;

            static /*0x79b6808*/ bool IsAlmostZero(double value);
            static /*0x79b6874*/ bool op_Equality(Unity.Cinemachine.PointD lhs, Unity.Cinemachine.PointD rhs);
            static /*0x79b68b0*/ bool op_Inequality(Unity.Cinemachine.PointD lhs, Unity.Cinemachine.PointD rhs);
            /*0x79b6714*/ PointD(Unity.Cinemachine.PointD pt);
            /*0x79b671c*/ PointD(Unity.Cinemachine.Point64 pt);
            /*0x79b672c*/ PointD(Unity.Cinemachine.PointD pt, double scale);
            /*0x79b673c*/ PointD(Unity.Cinemachine.Point64 pt, double scale);
            /*0x79b6754*/ PointD(long x, long y);
            /*0x79b6764*/ PointD(double x, double y);
            /*0x79b676c*/ string ToString();
            /*0x79b68f0*/ bool Equals(object obj);
            /*0x79b6968*/ int GetHashCode();
        }

        struct Rect64
        {
            /*0x10*/ long left;
            /*0x18*/ long top;
            /*0x20*/ long right;
            /*0x28*/ long bottom;

            /*0x79b6970*/ Rect64(long l, long t, long r, long b);
            /*0x79b697c*/ Rect64(Unity.Cinemachine.Rect64 rec);
            /*0x79b69a0*/ long get_Width();
            /*0x79b69b0*/ void set_Width(long value);
            /*0x79b69c0*/ long get_Height();
            /*0x79b69d0*/ void set_Height(long value);
            /*0x79b69e0*/ bool IsEmpty();
            /*0x79b6a0c*/ Unity.Cinemachine.Point64 MidPoint();
            /*0x79b6a38*/ bool Contains(Unity.Cinemachine.Point64 pt);
            /*0x79b6a74*/ bool Contains(Unity.Cinemachine.Rect64 rec);
        }

        struct RectD
        {
            /*0x10*/ double left;
            /*0x18*/ double top;
            /*0x20*/ double right;
            /*0x28*/ double bottom;

            /*0x79b6ac0*/ RectD(double l, double t, double r, double b);
            /*0x79b6acc*/ RectD(Unity.Cinemachine.RectD rec);
            /*0x79b6ad8*/ double get_Width();
            /*0x79b6ae8*/ void set_Width(double value);
            /*0x79b6af8*/ double get_Height();
            /*0x79b6b08*/ void set_Height(double value);
            /*0x79b6b18*/ bool IsEmpty();
            /*0x79b6b44*/ Unity.Cinemachine.PointD MidPoint();
            /*0x79b6b5c*/ bool PtIsInside(Unity.Cinemachine.PointD pt);
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

            static /*0x79b6b98*/ double CrossProduct(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2, Unity.Cinemachine.Point64 pt3);
            static /*0x79b6bc8*/ double DotProduct(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2, Unity.Cinemachine.Point64 pt3);
            static /*0x79b6bf8*/ double DotProduct(Unity.Cinemachine.PointD vec1, Unity.Cinemachine.PointD vec2);
            static /*0x79b6c08*/ bool GetIntersectPoint(Unity.Cinemachine.Point64 ln1a, Unity.Cinemachine.Point64 ln1b, Unity.Cinemachine.Point64 ln2a, Unity.Cinemachine.Point64 ln2b, ref Unity.Cinemachine.PointD ip);
            static /*0x79b6dac*/ bool SegmentsIntersect(Unity.Cinemachine.Point64 seg1a, Unity.Cinemachine.Point64 seg1b, Unity.Cinemachine.Point64 seg2a, Unity.Cinemachine.Point64 seg2b);
            static /*0x79b6e60*/ Unity.Cinemachine.PointInPolygonResult PointInPolygon(Unity.Cinemachine.Point64 pt, System.Collections.Generic.List<Unity.Cinemachine.Point64> polygon);
        }

        class Clipper
        {
            static /*0x0*/ Unity.Cinemachine.Rect64 MaxInvalidRect64;
            static /*0x20*/ Unity.Cinemachine.RectD MaxInvalidRectD;

            static /*0x79be194*/ Clipper();
            static /*0x79b70b8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Intersect(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b7230*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Intersect(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b73a8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b7414*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b7484*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b74f4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Union(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b7568*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Difference(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b75d8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Difference(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b764c*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Xor(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b76bc*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Xor(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, Unity.Cinemachine.FillRule fillRule);
            static /*0x79b7128*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> BooleanOp(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> clip);
            static /*0x79b72a4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> BooleanOp(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> subject, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> clip, int roundingDecimalPrecision);
            static /*0x79b7730*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> InflatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double delta, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType, double miterLimit);
            static /*0x79b77e0*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> InflatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double delta, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType, double miterLimit, int precision);
            static /*0x79b7e34*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> MinkowskiSum(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79b7e40*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> MinkowskiDiff(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79b7e4c*/ double Area(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79b8008*/ double Area(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79b818c*/ double Area(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79b8344*/ double Area(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79b84c8*/ bool IsPositive(System.Collections.Generic.List<Unity.Cinemachine.Point64> poly);
            static /*0x79b8528*/ bool IsPositive(System.Collections.Generic.List<Unity.Cinemachine.PointD> poly);
            static /*0x79b8588*/ string Path64ToString(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79b872c*/ string Paths64ToString(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79b88c8*/ string PathDToString(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79b8a6c*/ string PathsDToString(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79b8c08*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> OffsetPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, long dx, long dy);
            static /*0x79b8e28*/ Unity.Cinemachine.Point64 ScalePoint64(Unity.Cinemachine.Point64 pt, double scale);
            static /*0x79b8e60*/ Unity.Cinemachine.PointD ScalePointD(Unity.Cinemachine.Point64 pt, double scale);
            static /*0x79b8e78*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> ScalePath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, double scale);
            static /*0x79b90c0*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> ScalePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double scale);
            static /*0x79b9334*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> ScalePath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double scale);
            static /*0x79b9564*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> ScalePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double scale);
            static /*0x79b97d8*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> ScalePath64(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double scale);
            static /*0x79b7974*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> ScalePaths64(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double scale);
            static /*0x79b99fc*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> ScalePathD(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, double scale);
            static /*0x79b7bd4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> ScalePathsD(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double scale);
            static /*0x79b9c24*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> Path64(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79b9e38*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Paths64(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79ba088*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> PathsD(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79ba2d8*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> PathD(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79ba4e8*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> TranslatePath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, long dx, long dy);
            static /*0x79ba708*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> TranslatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, long dx, long dy);
            static /*0x79ba970*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> TranslatePath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double dx, double dy);
            static /*0x79bab90*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> TranslatePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double dx, double dy);
            static /*0x79badf8*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> ReversePath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            static /*0x79bae98*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> ReversePath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            static /*0x79baf38*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79bb188*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79bb3d8*/ Unity.Cinemachine.Rect64 GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79bb698*/ Unity.Cinemachine.RectD GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79bb974*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> MakePath(int[] arr);
            static /*0x79bbab0*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> MakePath(long[] arr);
            static /*0x79bbbec*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> MakePath(double[] arr);
            static /*0x79bbd28*/ double Sqr(double value);
            static /*0x79bbd30*/ bool PointsNearEqual(Unity.Cinemachine.PointD pt1, Unity.Cinemachine.PointD pt2, double distanceSqrd);
            static /*0x79bbdc4*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> StripNearDuplicates(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double minEdgeLenSqrd, bool isClosedPath);
            static /*0x79bc0e0*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> StripDuplicates(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosedPath);
            static /*0x79bc318*/ void AddPolyNodeToPaths(Unity.Cinemachine.PolyPath64 polyPath, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            static /*0x79bc4d0*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> PolyTreeToPaths64(Unity.Cinemachine.PolyTree64 polyTree);
            static /*0x79bc638*/ void AddPolyNodeToPathsD(Unity.Cinemachine.PolyPathD polyPath, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            static /*0x79bc7f0*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> PolyTreeToPathsD(Unity.Cinemachine.PolyTreeD polyTree);
            static /*0x79bca78*/ double PerpendicDistFromLineSqrd(Unity.Cinemachine.PointD pt, Unity.Cinemachine.PointD line1, Unity.Cinemachine.PointD line2);
            static /*0x79bcb30*/ double PerpendicDistFromLineSqrd(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Point64 line1, Unity.Cinemachine.Point64 line2);
            static /*0x79bcc10*/ void RDP(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int begin, int end, double epsSqrd, System.Collections.Generic.List<bool> flags);
            static /*0x79bce84*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> RamerDouglasPeucker(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, double epsilon);
            static /*0x79bd0f4*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> RamerDouglasPeucker(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, double epsilon);
            static /*0x79bd354*/ void RDP(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, int begin, int end, double epsSqrd, System.Collections.Generic.List<bool> flags);
            static /*0x79bd5a8*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> RamerDouglasPeucker(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, double epsilon);
            static /*0x79bd80c*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> RamerDouglasPeucker(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, double epsilon);
            static /*0x79bda6c*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> TrimCollinear(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isOpen);
            static /*0x79be080*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> TrimCollinear(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, int precision, bool isOpen);
            static /*0x79be190*/ Unity.Cinemachine.PointInPolygonResult PointInPolygon(Unity.Cinemachine.Point64 pt, System.Collections.Generic.List<Unity.Cinemachine.Point64> polygon);
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

            /*0x79be208*/ Vertex(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.VertexFlags flags, Unity.Cinemachine.Vertex prev);
        }

        struct LocalMinima
        {
            /*0x10*/ Unity.Cinemachine.Vertex vertex;
            /*0x18*/ Unity.Cinemachine.PathType polytype;
            /*0x1c*/ bool isOpen;

            static /*0x79be294*/ bool op_Equality(Unity.Cinemachine.LocalMinima lm1, Unity.Cinemachine.LocalMinima lm2);
            static /*0x79be2a0*/ bool op_Inequality(Unity.Cinemachine.LocalMinima lm1, Unity.Cinemachine.LocalMinima lm2);
            /*0x79be264*/ LocalMinima(Unity.Cinemachine.Vertex vertex, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79be2ac*/ bool Equals(object obj);
            /*0x79be324*/ int GetHashCode();
        }

        struct IntersectNode
        {
            /*0x10*/ Unity.Cinemachine.Point64 pt;
            /*0x20*/ Unity.Cinemachine.Active edge1;
            /*0x28*/ Unity.Cinemachine.Active edge2;

            /*0x79be344*/ IntersectNode(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Active edge1, Unity.Cinemachine.Active edge2);
        }

        struct LocMinSorter : System.Collections.Generic.IComparer<Unity.Cinemachine.LocalMinima>
        {
            /*0x79be37c*/ int Compare(Unity.Cinemachine.LocalMinima locMin1, Unity.Cinemachine.LocalMinima locMin2);
        }

        class OutPt
        {
            /*0x10*/ Unity.Cinemachine.Point64 pt;
            /*0x20*/ Unity.Cinemachine.OutPt next;
            /*0x28*/ Unity.Cinemachine.OutPt prev;
            /*0x30*/ Unity.Cinemachine.OutRec outrec;
            /*0x38*/ Unity.Cinemachine.Joiner joiner;

            /*0x79be3a0*/ OutPt(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.OutRec outrec);
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

            /*0x79be414*/ OutRec();
        }

        class Joiner
        {
            /*0x10*/ int idx;
            /*0x18*/ Unity.Cinemachine.OutPt op1;
            /*0x20*/ Unity.Cinemachine.OutPt op2;
            /*0x28*/ Unity.Cinemachine.Joiner next1;
            /*0x30*/ Unity.Cinemachine.Joiner next2;
            /*0x38*/ Unity.Cinemachine.Joiner nextH;

            /*0x79be4a8*/ Joiner(System.Collections.Generic.List<Unity.Cinemachine.Joiner> joinerList, Unity.Cinemachine.OutPt op1, Unity.Cinemachine.OutPt op2, Unity.Cinemachine.Joiner nextH);
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

            /*0x79be618*/ Active();
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

            static /*0x79be870*/ bool IsOdd(int val);
            static /*0x79be878*/ bool IsHotEdge(Unity.Cinemachine.Active ae);
            static /*0x79be898*/ bool IsOpen(Unity.Cinemachine.Active ae);
            static /*0x79be8b0*/ bool IsOpenEnd(Unity.Cinemachine.Active ae);
            static /*0x79be8e8*/ bool IsOpenEnd(Unity.Cinemachine.Vertex v);
            static /*0x79be908*/ Unity.Cinemachine.Active GetPrevHotEdge(Unity.Cinemachine.Active ae);
            static /*0x79be934*/ bool IsFront(Unity.Cinemachine.Active ae);
            static /*0x79be95c*/ double GetDx(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            static /*0x79be994*/ long TopX(Unity.Cinemachine.Active ae, long currentY);
            static /*0x79beac4*/ bool IsHorizontal(Unity.Cinemachine.Active ae);
            static /*0x79beae8*/ bool IsHeadingRightHorz(Unity.Cinemachine.Active ae);
            static /*0x79beb10*/ bool IsHeadingLeftHorz(Unity.Cinemachine.Active ae);
            static /*0x79beb38*/ void SwapActives(ref Unity.Cinemachine.Active ae1, ref Unity.Cinemachine.Active ae2);
            static /*0x79beb74*/ Unity.Cinemachine.PathType GetPolyType(Unity.Cinemachine.Active ae);
            static /*0x79beb8c*/ bool IsSamePolyType(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            static /*0x79bebb4*/ Unity.Cinemachine.Point64 GetIntersectPoint(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            static /*0x79bef04*/ void SetDx(Unity.Cinemachine.Active ae);
            static /*0x79bef58*/ Unity.Cinemachine.Vertex NextVertex(Unity.Cinemachine.Active ae);
            static /*0x79befd4*/ bool IsMaxima(Unity.Cinemachine.Vertex vertex);
            static /*0x79beff0*/ bool IsMaxima(Unity.Cinemachine.Active ae);
            static /*0x79bf044*/ Unity.Cinemachine.Vertex GetCurrYMaximaVertex(Unity.Cinemachine.Active ae);
            static /*0x79bf0b8*/ Unity.Cinemachine.Active GetHorzMaximaPair(Unity.Cinemachine.Active horz, Unity.Cinemachine.Vertex maxVert);
            static /*0x79bf150*/ void SetSides(Unity.Cinemachine.OutRec outrec, Unity.Cinemachine.Active startEdge, Unity.Cinemachine.Active endEdge);
            static /*0x79bf188*/ void SwapOutrecs(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            static /*0x79bf280*/ double Area(Unity.Cinemachine.OutPt op);
            static /*0x79bf2d8*/ double AreaTriangle(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2, Unity.Cinemachine.Point64 pt3);
            static /*0x79bf320*/ Unity.Cinemachine.OutRec GetRealOutRec(Unity.Cinemachine.OutRec outRec);
            static /*0x79bf338*/ void UncoupleOutRec(Unity.Cinemachine.Active ae);
            static /*0x79bf3d8*/ void SwapFrontBackSides(Unity.Cinemachine.OutRec outrec);
            static /*0x79bf430*/ bool EdgesAdjacentInAEL(Unity.Cinemachine.IntersectNode inode);
            static /*0x79c5668*/ bool IsValidPath(Unity.Cinemachine.OutPt op);
            static /*0x79c5688*/ bool AreReallyClose(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            static /*0x79c572c*/ bool IsValidClosedPath(Unity.Cinemachine.OutPt op);
            static /*0x79c5870*/ bool ValueBetween(long val, long end1, long end2);
            static /*0x79c58a8*/ bool ValueEqualOrBetween(long val, long end1, long end2);
            static /*0x79c58d8*/ bool PointBetween(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Point64 corner1, Unity.Cinemachine.Point64 corner2);
            static /*0x79c5934*/ bool CollinearSegsOverlap(Unity.Cinemachine.Point64 seg1a, Unity.Cinemachine.Point64 seg1b, Unity.Cinemachine.Point64 seg2a, Unity.Cinemachine.Point64 seg2b);
            static /*0x79c5a60*/ bool HorzEdgesOverlap(long x1a, long x1b, long x2a, long x2b);
            static /*0x79c5c80*/ Unity.Cinemachine.OutPt InsertOp(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.OutPt insertAfter);
            static /*0x79c5d48*/ Unity.Cinemachine.OutPt DisposeOutPt(Unity.Cinemachine.OutPt op);
            static /*0x79c60ac*/ Unity.Cinemachine.Joiner FindTrialJoinParent(ref Unity.Cinemachine.Joiner joiner, Unity.Cinemachine.OutPt op);
            static /*0x79c6290*/ Unity.Cinemachine.Joiner FindJoinParent(Unity.Cinemachine.Joiner joiner, Unity.Cinemachine.OutPt op);
            static /*0x79c6e60*/ bool CheckDisposeAdjacent(ref Unity.Cinemachine.OutPt op, Unity.Cinemachine.OutPt guard, Unity.Cinemachine.OutRec outRec);
            static /*0x79c7048*/ double DistanceFromLineSqrd(Unity.Cinemachine.Point64 pt, Unity.Cinemachine.Point64 linePt1, Unity.Cinemachine.Point64 linePt2);
            static /*0x79c709c*/ double DistanceSqr(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            static /*0x79c7440*/ void UpdateOutrecOwner(Unity.Cinemachine.OutRec outrec);
            /*0x79be648*/ ClipperBase();
            /*0x79be620*/ bool get_PreserveCollinear();
            /*0x79be628*/ void set_PreserveCollinear(bool value);
            /*0x79be634*/ bool get_ReverseSolution();
            /*0x79be63c*/ void set_ReverseSolution(bool value);
            /*0x79bef8c*/ Unity.Cinemachine.Vertex PrevPrevVertex(Unity.Cinemachine.Active ae);
            /*0x79bf014*/ Unity.Cinemachine.Active GetMaximaPair(Unity.Cinemachine.Active ae);
            /*0x79bf3b0*/ bool OutrecIsAscending(Unity.Cinemachine.Active hotEdge);
            /*0x79bf46c*/ void ClearSolution();
            /*0x79bf60c*/ void Clear();
            /*0x79bf6bc*/ void Reset();
            /*0x79bf880*/ void InsertScanline(long y);
            /*0x79bf918*/ bool PopScanline(ref long y);
            /*0x79bfa20*/ bool HasLocMinAtY(long y);
            /*0x79bfaac*/ Unity.Cinemachine.LocalMinima PopLocalMinima();
            /*0x79bfb08*/ void AddLocMin(Unity.Cinemachine.Vertex vert, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79bfc04*/ void AddPathsToVertexList(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c039c*/ void AddSubject(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79c04cc*/ void AddOpenSubject(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79c04d8*/ void AddClip(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79c03a8*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c04e4*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c04fc*/ bool IsContributingClosed(Unity.Cinemachine.Active ae);
            /*0x79c06d4*/ bool IsContributingOpen(Unity.Cinemachine.Active ae);
            /*0x79c0758*/ void SetWindCountForClosedPathEdge(Unity.Cinemachine.Active ae);
            /*0x79c08f4*/ void SetWindCountForOpenPathEdge(Unity.Cinemachine.Active ae);
            /*0x79c09c4*/ bool IsValidAelOrder(Unity.Cinemachine.Active resident, Unity.Cinemachine.Active newcomer);
            /*0x79c0c58*/ void InsertLeftEdge(Unity.Cinemachine.Active ae);
            /*0x79c0d60*/ void InsertRightEdge(Unity.Cinemachine.Active ae, Unity.Cinemachine.Active ae2);
            /*0x79c0dcc*/ void InsertLocalMinimaIntoAEL(long botY);
            /*0x79c21f8*/ void PushHorz(Unity.Cinemachine.Active ae);
            /*0x79c223c*/ bool PopHorz(ref Unity.Cinemachine.Active ae);
            /*0x79c2288*/ bool TestJoinWithPrev1(Unity.Cinemachine.Active e, long currY);
            /*0x79c233c*/ bool TestJoinWithPrev2(Unity.Cinemachine.Active e, Unity.Cinemachine.Point64 currPt);
            /*0x79c244c*/ bool TestJoinWithNext1(Unity.Cinemachine.Active e, long currY);
            /*0x79c2500*/ bool TestJoinWithNext2(Unity.Cinemachine.Active e, Unity.Cinemachine.Point64 currPt);
            /*0x79c1510*/ Unity.Cinemachine.OutPt AddLocalMinPoly(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, Unity.Cinemachine.Point64 pt, bool isNew);
            /*0x79c2610*/ Unity.Cinemachine.OutPt AddLocalMaxPoly(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, Unity.Cinemachine.Point64 pt);
            /*0x79c2a54*/ void JoinOutrecPaths(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            /*0x79c2cdc*/ Unity.Cinemachine.OutPt AddOutPt(Unity.Cinemachine.Active ae, Unity.Cinemachine.Point64 pt);
            /*0x79c2010*/ Unity.Cinemachine.OutPt StartOpenPath(Unity.Cinemachine.Active ae, Unity.Cinemachine.Point64 pt);
            /*0x79c2e3c*/ void UpdateEdgeIntoAEL(Unity.Cinemachine.Active ae);
            /*0x79c3048*/ Unity.Cinemachine.Active FindEdgeWithMatchingLocMin(Unity.Cinemachine.Active e);
            /*0x79c185c*/ Unity.Cinemachine.OutPt IntersectEdges(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, Unity.Cinemachine.Point64 pt);
            /*0x79c3104*/ void DeleteFromAEL(Unity.Cinemachine.Active ae);
            /*0x79c3170*/ void AdjustCurrXAndCopyToSEL(long topY);
            /*0x79c3304*/ void ExecuteInternal(Unity.Cinemachine.ClipType ct, Unity.Cinemachine.FillRule fillRule);
            /*0x79c45e8*/ void DoIntersections(long topY);
            /*0x79bf59c*/ void DisposeIntersectNodes();
            /*0x79c4dd4*/ void AddNewIntersectNode(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2, long topY);
            /*0x79c4fe4*/ Unity.Cinemachine.Active ExtractFromSEL(Unity.Cinemachine.Active ae);
            /*0x79c5034*/ void Insert1Before2InSEL(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            /*0x79c48fc*/ bool BuildIntersectList(long topY);
            /*0x79c4aa0*/ void ProcessIntersectList();
            /*0x79c1f24*/ void SwapPositionsInAEL(Unity.Cinemachine.Active ae1, Unity.Cinemachine.Active ae2);
            /*0x79c50ac*/ bool ResetHorzDirection(Unity.Cinemachine.Active horz, Unity.Cinemachine.Active maxPair, ref long leftX, ref long rightX);
            /*0x79c5124*/ bool HorzIsSpike(Unity.Cinemachine.Active horz);
            /*0x79c517c*/ bool TrimHorz(Unity.Cinemachine.Active horzEdge, bool preserveCollinear);
            /*0x79c3428*/ void DoHorizontal(Unity.Cinemachine.Active horz);
            /*0x79c4614*/ void DoTopOfScanbeam(long y);
            /*0x79c5380*/ Unity.Cinemachine.Active DoMaxima(Unity.Cinemachine.Active ae);
            /*0x79c5ae8*/ Unity.Cinemachine.Joiner GetHorzTrialParent(Unity.Cinemachine.OutPt op);
            /*0x79c5b48*/ bool OutPtInTrialHorzList(Unity.Cinemachine.OutPt op);
            /*0x79c5b88*/ bool ValidateClosedPathEx(ref Unity.Cinemachine.OutPt op);
            /*0x79c5bd4*/ void SafeDisposeOutPts(ref Unity.Cinemachine.OutPt op);
            /*0x79c5da0*/ void SafeDeleteOutPtJoiners(Unity.Cinemachine.OutPt op);
            /*0x79c52c0*/ void AddTrialHorzJoin(Unity.Cinemachine.OutPt op);
            /*0x79c5e58*/ void DeleteTrialHorzJoin(Unity.Cinemachine.OutPt op);
            /*0x79c6104*/ bool GetHorzExtendedHorzSeg(ref Unity.Cinemachine.OutPt op, ref Unity.Cinemachine.OutPt op2);
            /*0x79c4218*/ void ConvertHorzTrialsToJoins();
            /*0x79c1780*/ void AddJoin(Unity.Cinemachine.OutPt op1, Unity.Cinemachine.OutPt op2);
            /*0x79c5f84*/ void DeleteJoin(Unity.Cinemachine.Joiner joiner);
            /*0x79c4828*/ void ProcessJoinList();
            /*0x79c62d8*/ Unity.Cinemachine.OutRec ProcessJoin(Unity.Cinemachine.Joiner j);
            /*0x79c70bc*/ void CompleteSplit(Unity.Cinemachine.OutPt op1, Unity.Cinemachine.OutPt op2, Unity.Cinemachine.OutRec outrec);
            /*0x79c28a0*/ void CleanCollinear(Unity.Cinemachine.OutRec outrec);
            /*0x79c7568*/ Unity.Cinemachine.OutPt DoSplitOp(ref Unity.Cinemachine.OutPt outRecOp, Unity.Cinemachine.OutPt splitOp);
            /*0x79c7488*/ void FixSelfIntersects(ref Unity.Cinemachine.OutPt op);
            /*0x79c7978*/ bool BuildPath(Unity.Cinemachine.OutPt op, bool reverse, bool isOpen, System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79c7b34*/ bool BuildPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionClosed, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionOpen);
            /*0x79c7ebc*/ bool Path1InsidePath2(Unity.Cinemachine.OutRec or1, Unity.Cinemachine.OutRec or2);
            /*0x79c7f14*/ Unity.Cinemachine.Rect64 GetBounds(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79c80a4*/ bool DeepCheckOwner(Unity.Cinemachine.OutRec outrec, Unity.Cinemachine.OutRec owner);
            /*0x79c844c*/ bool BuildTree(Unity.Cinemachine.PolyPathBase polytree, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionOpen);
            /*0x79c8844*/ Unity.Cinemachine.Rect64 GetBounds();

            struct IntersectListSort : System.Collections.Generic.IComparer<Unity.Cinemachine.IntersectNode>
            {
                /*0x79c9574*/ int Compare(Unity.Cinemachine.IntersectNode a, Unity.Cinemachine.IntersectNode b);
            }
        }

        class Clipper64 : Unity.Cinemachine.ClipperBase
        {
            /*0x79c95a8*/ Clipper64();
            /*0x79c95b0*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c95bc*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c95c8*/ void AddSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79c95d8*/ void AddOpenSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79c95e8*/ void AddClip(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79c95f8*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionClosed, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionOpen);
            /*0x79c9754*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> solutionClosed);
            /*0x79c97ec*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTree64 polytree, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> openPaths);
            /*0x79c99a4*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTree64 polytree);
        }

        class ClipperD : Unity.Cinemachine.ClipperBase
        {
            /*0x78*/ double _scale;
            /*0x80*/ double _invScale;

            /*0x79c9a3c*/ ClipperD(int roundingDecimalPrecision);
            /*0x79c9b70*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c9c0c*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, Unity.Cinemachine.PathType polytype, bool isOpen);
            /*0x79c9ca8*/ void AddSubject(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            /*0x79c9cb4*/ void AddOpenSubject(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            /*0x79c9cc0*/ void AddClip(System.Collections.Generic.List<Unity.Cinemachine.PointD> path);
            /*0x79c9ccc*/ void AddSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            /*0x79c9cd8*/ void AddOpenSubject(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            /*0x79c9ce4*/ void AddClip(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths);
            /*0x79c9cf0*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> solutionClosed, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> solutionOpen);
            /*0x79ca1fc*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> solutionClosed);
            /*0x79ca294*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTreeD polytree, System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> openPaths);
            /*0x79ca60c*/ bool Execute(Unity.Cinemachine.ClipType clipType, Unity.Cinemachine.FillRule fillRule, Unity.Cinemachine.PolyTreeD polytree);
        }

        class PolyPathBase : System.Collections.IEnumerable
        {
            /*0x10*/ Unity.Cinemachine.PolyPathBase _parent;
            /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.PolyPathBase> _childs;

            /*0x79ca78c*/ PolyPathBase(Unity.Cinemachine.PolyPathBase parent);
            /*0x79ca6a4*/ Unity.Cinemachine.PolyPathEnum GetEnumerator();
            /*0x79ca750*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x79ca754*/ bool get_IsHole();
            /*0x79ca770*/ bool GetIsHole();
            /*0x79ca828*/ int get_Count();
            /*0x380bb68*/ Unity.Cinemachine.PolyPathBase AddChild(System.Collections.Generic.List<Unity.Cinemachine.Point64> p);
            /*0x79c9934*/ void Clear();
        }

        class PolyPathEnum : System.Collections.IEnumerator
        {
            /*0x10*/ System.Collections.Generic.List<Unity.Cinemachine.PolyPathBase> _ppbList;
            /*0x18*/ int position;

            /*0x79ca718*/ PolyPathEnum(System.Collections.Generic.List<Unity.Cinemachine.PolyPathBase> childs);
            /*0x79ca870*/ bool MoveNext();
            /*0x79ca8cc*/ void Reset();
            /*0x79ca8d8*/ Unity.Cinemachine.PolyPathBase get_Current();
            /*0x79ca97c*/ object System.Collections.IEnumerator.get_Current();
        }

        class PolyPath64 : Unity.Cinemachine.PolyPathBase
        {
            /*0x20*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> <Polygon>k__BackingField;

            /*0x79ca990*/ PolyPath64(Unity.Cinemachine.PolyPathBase parent);
            /*0x79ca980*/ System.Collections.Generic.List<Unity.Cinemachine.Point64> get_Polygon();
            /*0x79ca988*/ void set_Polygon(System.Collections.Generic.List<Unity.Cinemachine.Point64> value);
            /*0x79ca994*/ Unity.Cinemachine.PolyPathBase AddChild(System.Collections.Generic.List<Unity.Cinemachine.Point64> p);
            /*0x79caab4*/ Unity.Cinemachine.PolyPath64 get_Child(int index);
            /*0x79caba8*/ double Area();
        }

        class PolyPathD : Unity.Cinemachine.PolyPathBase
        {
            /*0x20*/ double <Scale>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> <Polygon>k__BackingField;

            /*0x79cad98*/ PolyPathD(Unity.Cinemachine.PolyPathBase parent);
            /*0x79cad78*/ double get_Scale();
            /*0x79cad80*/ void set_Scale(double value);
            /*0x79cad88*/ System.Collections.Generic.List<Unity.Cinemachine.PointD> get_Polygon();
            /*0x79cad90*/ void set_Polygon(System.Collections.Generic.List<Unity.Cinemachine.PointD> value);
            /*0x79cad9c*/ Unity.Cinemachine.PolyPathBase AddChild(System.Collections.Generic.List<Unity.Cinemachine.Point64> p);
            /*0x79caf34*/ Unity.Cinemachine.PolyPathD get_Child(int index);
            /*0x79cb028*/ double Area();
        }

        class PolyTree64 : Unity.Cinemachine.PolyPath64
        {
            /*0x79cb1f8*/ PolyTree64();
        }

        class PolyTreeD : Unity.Cinemachine.PolyPathD
        {
            /*0x79cb208*/ PolyTreeD();
            /*0x79cb200*/ double get_Scale();
        }

        class ClipperLibException : System.Exception
        {
            /*0x79c9b08*/ ClipperLibException(string description);
        }

        class Minkowski
        {
            static /*0x79cb210*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> MinkowskiInternal(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isSum, bool isClosed);
            static /*0x79cbbbc*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Sum(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79cbc44*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Sum(System.Collections.Generic.List<Unity.Cinemachine.PointD> pattern, System.Collections.Generic.List<Unity.Cinemachine.PointD> path, bool isClosed, int decimalPlaces);
            static /*0x79cbd40*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Diff(System.Collections.Generic.List<Unity.Cinemachine.Point64> pattern, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, bool isClosed);
            static /*0x79cbdc8*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> Diff(System.Collections.Generic.List<Unity.Cinemachine.PointD> pattern, System.Collections.Generic.List<Unity.Cinemachine.PointD> path, bool isClosed, int decimalPlaces);
            /*0x79cbec4*/ Minkowski();
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

            /*0x79cbecc*/ PathGroup(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
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

            static /*0x79cd688*/ Unity.Cinemachine.PointD GetUnitNormal(Unity.Cinemachine.Point64 pt1, Unity.Cinemachine.Point64 pt2);
            /*0x79cc068*/ ClipperOffset(double miterLimit, double arcTolerance, bool preserveCollinear, bool reverseSolution);
            /*0x79cc00c*/ double get_ArcTolerance();
            /*0x79cc014*/ void set_ArcTolerance(double value);
            /*0x79cc01c*/ bool get_MergeGroups();
            /*0x79cc024*/ void set_MergeGroups(bool value);
            /*0x79cc030*/ double get_MiterLimit();
            /*0x79cc038*/ void set_MiterLimit(double value);
            /*0x79cc040*/ bool get_PreserveCollinear();
            /*0x79cc048*/ void set_PreserveCollinear(bool value);
            /*0x79cc054*/ bool get_ReverseSolution();
            /*0x79cc05c*/ void set_ReverseSolution(bool value);
            /*0x79cc1dc*/ void Clear();
            /*0x79cc24c*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79cc37c*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79cc494*/ void AddPath(System.Collections.Generic.List<Unity.Cinemachine.PointD> path, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79cc5c4*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.PointD>> paths, Unity.Cinemachine.JoinType joinType, Unity.Cinemachine.EndType endType);
            /*0x79cc714*/ System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> Execute(double delta);
            /*0x79cd754*/ int GetLowestPolygonIdx(System.Collections.Generic.List<System.Collections.Generic.List<Unity.Cinemachine.Point64>> paths);
            /*0x79cd8cc*/ Unity.Cinemachine.PointD TranslatePoint(Unity.Cinemachine.PointD pt, double dx, double dy);
            /*0x79cd8fc*/ Unity.Cinemachine.PointD ReflectPoint(Unity.Cinemachine.PointD pt, Unity.Cinemachine.PointD pivot);
            /*0x79cd934*/ bool AlmostZero(double value, double epsilon);
            /*0x79cd99c*/ double Hypotenuse(double x, double y);
            /*0x79cda24*/ Unity.Cinemachine.PointD NormalizeVector(Unity.Cinemachine.PointD vec);
            /*0x79cdb40*/ Unity.Cinemachine.PointD GetAvgUnitVector(Unity.Cinemachine.PointD vec1, Unity.Cinemachine.PointD vec2);
            /*0x79cdb80*/ Unity.Cinemachine.PointD IntersectPoint(Unity.Cinemachine.PointD pt1a, Unity.Cinemachine.PointD pt1b, Unity.Cinemachine.PointD pt2a, Unity.Cinemachine.PointD pt2b);
            /*0x79cdc58*/ void DoSquare(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int j, int k);
            /*0x79ce0bc*/ void DoMiter(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int j, int k, double cosA);
            /*0x79ce2a0*/ void DoRound(Unity.Cinemachine.PathGroup group, Unity.Cinemachine.Point64 pt, Unity.Cinemachine.PointD normal1, Unity.Cinemachine.PointD normal2, double angle);
            /*0x79ce5dc*/ void BuildNormals(System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79ce928*/ void OffsetPoint(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, int j, ref int k);
            /*0x79cee3c*/ void OffsetPolygon(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79cef94*/ void OffsetOpenJoined(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path);
            /*0x79cf02c*/ void OffsetOpenPath(Unity.Cinemachine.PathGroup group, System.Collections.Generic.List<Unity.Cinemachine.Point64> path, Unity.Cinemachine.EndType endType);
            /*0x79cf874*/ bool IsFullyOpenEndType(Unity.Cinemachine.EndType et);
            /*0x79cccc0*/ void DoGroupOffset(Unity.Cinemachine.PathGroup group, double delta);
        }

        class CinemachinePlayableMixer : UnityEngine.Playables.PlayableBehaviour
        {
            static /*0x0*/ Unity.Cinemachine.CinemachinePlayableMixer.MasterDirectorDelegate GetMasterPlayableDirector;
            /*0x10*/ int Priority;
            /*0x18*/ Unity.Cinemachine.ICameraOverrideStack m_BrainOverrideStack;
            /*0x20*/ int m_BrainOverrideId;
            /*0x24*/ bool m_PreviewPlay;

            /*0x79d0038*/ CinemachinePlayableMixer();
            /*0x79cf880*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x79cf934*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x79cf93c*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x79cff74*/ float GetDeltaTime(float deltaTime);

            class MasterDirectorDelegate : System.MulticastDelegate
            {
                /*0x79d0048*/ MasterDirectorDelegate(object object, nint method);
                /*0x79d00e4*/ UnityEngine.Playables.PlayableDirector Invoke();
                /*0x79d00f8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x79d0118*/ UnityEngine.Playables.PlayableDirector EndInvoke(System.IAsyncResult result);
            }
        }

        class CinemachineShot : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.IPropertyPreview
        {
            /*0x18*/ string DisplayName;
            /*0x20*/ UnityEngine.ExposedReference<Unity.Cinemachine.CinemachineVirtualCameraBase> VirtualCamera;

            /*0x79d083c*/ CinemachineShot();
            /*0x79d0124*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x79d025c*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
        }

        class CinemachineShotPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ Unity.Cinemachine.CinemachineVirtualCameraBase VirtualCamera;

            /*0x79d0844*/ CinemachineShotPlayable();
            /*0x79cff14*/ bool get_IsValid();
        }

        class CinemachineTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0xa0*/ int TrackPriority;

            /*0x79d0960*/ CinemachineTrack();
            /*0x79d084c*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
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

                static /*0x79d09b8*/ Unity.Cinemachine.TargetTracking.TrackerSettings get_Default();
                /*0x79d0a2c*/ void Validate();
            }

            class TrackerSettingsExtensions
            {
                static /*0x79d0a70*/ float GetMaxDampTime(Unity.Cinemachine.TargetTracking.TrackerSettings s);
                static /*0x79d0b00*/ UnityEngine.Vector3 GetEffectivePositionDamping(Unity.Cinemachine.TargetTracking.TrackerSettings s);
                static /*0x79d0b1c*/ UnityEngine.Vector3 GetEffectiveRotationDamping(Unity.Cinemachine.TargetTracking.TrackerSettings s);
            }

            struct Tracker
            {
                /*0x10*/ UnityEngine.Vector3 <PreviousTargetPosition>k__BackingField;
                /*0x1c*/ UnityEngine.Quaternion <PreviousReferenceOrientation>k__BackingField;
                /*0x2c*/ UnityEngine.Quaternion m_TargetOrientationOnAssign;
                /*0x3c*/ UnityEngine.Vector3 m_PreviousOffset;
                /*0x48*/ UnityEngine.Transform m_PreviousTarget;

                /*0x79d0bb4*/ UnityEngine.Vector3 get_PreviousTargetPosition();
                /*0x79d0bc0*/ void set_PreviousTargetPosition(UnityEngine.Vector3 value);
                /*0x79d0bcc*/ UnityEngine.Quaternion get_PreviousReferenceOrientation();
                /*0x79d0bd8*/ void set_PreviousReferenceOrientation(UnityEngine.Quaternion value);
                /*0x79d0be4*/ void InitStateInfo(Unity.Cinemachine.CinemachineComponentBase component, float deltaTime, Unity.Cinemachine.TargetTracking.BindingMode bindingMode, UnityEngine.Vector3 up);
                /*0x79d0d4c*/ UnityEngine.Quaternion GetReferenceOrientation(Unity.Cinemachine.CinemachineComponentBase component, Unity.Cinemachine.TargetTracking.BindingMode bindingMode, UnityEngine.Vector3 worldUp);
                /*0x79d10a4*/ void TrackTarget(Unity.Cinemachine.CinemachineComponentBase component, float deltaTime, UnityEngine.Vector3 up, UnityEngine.Vector3 desiredCameraOffset, ref Unity.Cinemachine.TargetTracking.TrackerSettings settings, ref UnityEngine.Vector3 outTargetPosition, ref UnityEngine.Quaternion outTargetOrient);
                /*0x79d1768*/ UnityEngine.Vector3 GetOffsetForMinimumTargetDistance(Unity.Cinemachine.CinemachineComponentBase component, UnityEngine.Vector3 dampedTargetPos, UnityEngine.Vector3 cameraOffset, UnityEngine.Vector3 cameraFwd, UnityEngine.Vector3 up, UnityEngine.Vector3 actualTargetPos);
                /*0x79d1b1c*/ void OnTargetObjectWarped(UnityEngine.Vector3 positionDelta);
                /*0x79d1b3c*/ void ForceCameraPosition(Unity.Cinemachine.CinemachineComponentBase component, Unity.Cinemachine.TargetTracking.BindingMode bindingMode, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 cameraOffsetLocalSpace);
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
