class <Module>
{
}

namespace UnityEngine
{
    namespace U2D
    {
        namespace IK
        {
            class CCDSolver2D : UnityEngine.U2D.IK.Solver2D
            {
                static int k_MinIterations = 1;
                static float k_MinTolerance = 0.0010000000474974513;
                static float k_MinVelocity = 0.009999999776482582;
                static float k_MaxVelocity = 1;
                /*0x48*/ UnityEngine.U2D.IK.IKChain2D m_Chain;
                /*0x50*/ int m_Iterations;
                /*0x54*/ float m_Tolerance;
                /*0x58*/ float m_Velocity;
                /*0x60*/ UnityEngine.Vector3[] m_Positions;

                /*0x3a907cc*/ CCDSolver2D();
                /*0x3a90054*/ int get_iterations();
                /*0x3a9005c*/ void set_iterations(int value);
                /*0x3a9006c*/ float get_tolerance();
                /*0x3a90074*/ void set_tolerance(float value);
                /*0x3a90088*/ float get_velocity();
                /*0x3a90090*/ void set_velocity(float value);
                /*0x3a900b0*/ int GetChainCount();
                /*0x3a900b8*/ UnityEngine.U2D.IK.IKChain2D GetChain(int index);
                /*0x3a900c0*/ void DoPrepare();
                /*0x3a9025c*/ void DoUpdateIK(System.Collections.Generic.List<UnityEngine.Vector3> targetPositions);
            }

            class AlwaysUpdateCullingStrategy : UnityEngine.U2D.IK.BaseCullingStrategy
            {
                /*0x3a908f0*/ AlwaysUpdateCullingStrategy();
                /*0x3a908e8*/ bool AreBonesVisible(System.Collections.Generic.IList<int> transformIds);
            }

            class BaseCullingStrategy
            {
                /*0x10*/ bool m_IsCullingEnabled;
                /*0x18*/ System.Collections.Generic.HashSet<object> m_RequestingManagers;

                /*0x3a908f8*/ BaseCullingStrategy();
                /*0x3a90900*/ bool get_enabled();
                /*0x1f2fec8*/ bool AreBonesVisible(System.Collections.Generic.IList<int> transformIds);
                /*0x3a90908*/ void AddRequestingObject(object requestingObject);
                /*0x3a90a04*/ void RemoveRequestingObject(object requestingObject);
                /*0x3a90978*/ void Initialize();
                /*0x3a90aa8*/ void Update();
                /*0x3a90a9c*/ void Disable();
                /*0x3a90ab4*/ void OnInitialize();
                /*0x3a90ab8*/ void OnUpdate();
                /*0x3a90abc*/ void OnDisable();
            }

            class CullingManager : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ UnityEngine.U2D.IK.CullingManager s_Instance;
                /*0x20*/ Unity.Profiling.ProfilerMarker m_ProfilerMarker;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.U2D.IK.BaseCullingStrategy> m_CullingStrategies;

                static /*0x3a90ac0*/ UnityEngine.U2D.IK.CullingManager get_instance();
                static /*0x3a90bd0*/ UnityEngine.U2D.IK.CullingManager CreateNewManager();
                /*0x3a91108*/ CullingManager();
                /*0x3a90c9c*/ void Initialize();
                /*0x3a90e48*/ void Update();
                /*0x3a90e4c*/ void OnUpdate();
                /*0x3a90d88*/ void AddCullingStrategy(UnityEngine.U2D.IK.BaseCullingStrategy newCullingStrategy);
                /*0x3a91028*/ void RemoveCullingStrategy(UnityEngine.U2D.IK.BaseCullingStrategy strategyToRemove);
                /*0x1ffc854*/ T GetCullingStrategy<T>();
            }

            class SpriteSkinVisibilityCullingStrategy : UnityEngine.U2D.IK.BaseCullingStrategy
            {
                /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.U2D.Animation.SpriteSkin, UnityEngine.U2D.IK.SpriteSkinVisibilityCullingStrategy.SpriteSkinRegistry> m_SpriteSkinRegistries;
                /*0x28*/ System.Collections.Generic.Dictionary<int, int> m_BoneVisibilityCount;

                /*0x3a90e40*/ SpriteSkinVisibilityCullingStrategy();
                /*0x3a91170*/ bool AreBonesVisible(System.Collections.Generic.IList<int> boneTransformIds);
                /*0x3a91328*/ void OnInitialize();
                /*0x3a91684*/ void OnDisable();
                /*0x3a91584*/ void AddListeners();
                /*0x3a91700*/ void RemoveListeners();
                /*0x3a91800*/ void OnUpdate();
                /*0x3a91be8*/ void OnBoneTransformChanged(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a91f14*/ bool IsSpriteSkinRegistered(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a91f6c*/ void UnregisterSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a91514*/ void UpdateSpriteSkinVisibility(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a91cd4*/ UnityEngine.U2D.IK.SpriteSkinVisibilityCullingStrategy.SpriteSkinRegistry RegisterSpriteSkinBonesMapping(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a91c1c*/ void UnregisterSpriteSkinBonesMapping(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a91a50*/ void RecalculateVisibility(UnityEngine.U2D.IK.SpriteSkinVisibilityCullingStrategy.SpriteSkinRegistry registry);

                class SpriteSkinRegistry
                {
                    /*0x10*/ int[] boneIds;
                    /*0x18*/ bool isVisible;

                    /*0x3a91f70*/ SpriteSkinRegistry(int[] boneIds, bool isSkinVisible);
                }
            }

            class IKChain2D
            {
                /*0x10*/ UnityEngine.Transform m_EffectorTransform;
                /*0x18*/ UnityEngine.Transform m_TargetTransform;
                /*0x20*/ int m_TransformCount;
                /*0x28*/ UnityEngine.Transform[] m_Transforms;
                /*0x30*/ UnityEngine.Quaternion[] m_DefaultLocalRotations;
                /*0x38*/ UnityEngine.Quaternion[] m_StoredLocalRotations;
                /*0x40*/ float[] m_Lengths;

                /*0x3a90848*/ IKChain2D();
                /*0x3a91fac*/ UnityEngine.Transform get_effector();
                /*0x3a91fb4*/ UnityEngine.Transform get_target();
                /*0x3a91fbc*/ UnityEngine.Transform[] get_transforms();
                /*0x3a9022c*/ UnityEngine.Transform get_rootTransform();
                /*0x3a91fc4*/ UnityEngine.Transform get_lastTransform();
                /*0x3a91ff8*/ int get_transformCount();
                /*0x3a92000*/ void set_transformCount(int value);
                /*0x3a9200c*/ bool get_isValid();
                /*0x3a921c4*/ float[] get_lengths();
                /*0x3a92010*/ bool Validate();
                /*0x3a92478*/ void Initialize();
                /*0x3a921f0*/ void PrepareLengths();
                /*0x3a92700*/ void RestoreDefaultPose(bool targetRotationIsConstrained);
                /*0x3a927a0*/ void StoreLocalRotations();
                /*0x3a92834*/ void BlendFkToIk(float finalWeight, bool targetRotationIsConstrained);
            }

            class IKManager2D : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.IK.Solver2D> m_Solvers;
                /*0x28*/ float m_Weight;
                /*0x2c*/ bool m_AlwaysUpdate;
                /*0x2d*/ bool m_CullingEnabled;
                /*0x30*/ UnityEngine.U2D.IK.BaseCullingStrategy m_CullingStrategy;
                /*0x38*/ int[] m_TransformIdCache;

                static /*0x3a933c0*/ bool IsInGUIUpdateLoop();
                /*0x3a933e0*/ IKManager2D();
                /*0x3a92934*/ UnityEngine.U2D.IK.BaseCullingStrategy GetCullingStrategy();
                /*0x3a9293c*/ float get_weight();
                /*0x3a92944*/ void set_weight(float value);
                /*0x3a92964*/ System.Collections.Generic.List<UnityEngine.U2D.IK.Solver2D> get_solvers();
                /*0x3a9296c*/ bool get_alwaysUpdate();
                /*0x3a92974*/ void set_alwaysUpdate(bool value);
                /*0x3a92a58*/ void OnEnable();
                /*0x3a92a68*/ void OnDisable();
                /*0x3a92988*/ void ToggleCulling(bool enableCulling);
                /*0x3a92a70*/ void OnValidate();
                /*0x3a92a98*/ void Reset();
                /*0x3a92a9c*/ void FindChildSolvers();
                /*0x3a92db0*/ void AddSolver(UnityEngine.U2D.IK.Solver2D solver);
                /*0x3a92e44*/ void RemoveSolver(UnityEngine.U2D.IK.Solver2D solver);
                /*0x3a92ea0*/ void UpdateManager();
                /*0x3a93188*/ void CacheSolversTransformIds();
                /*0x3a933bc*/ void OnPreviewUpdate();
                /*0x3a933dc*/ void LateUpdate();
                /*0x3a92a94*/ void OnEditorDataValidate();
                /*0x3a92e40*/ void AddSolverEditorData();
                /*0x3a92e9c*/ void RemoveSolverEditorData(UnityEngine.U2D.IK.Solver2D solver);
            }

            class IKUtility
            {
                static /*0x3a923c0*/ bool IsDescendentOf(UnityEngine.Transform transform, UnityEngine.Transform ancestor);
                static /*0x3a9265c*/ int GetAncestorCount(UnityEngine.Transform transform);
            }

            class LimbSolver2D : UnityEngine.U2D.IK.Solver2D
            {
                /*0x48*/ UnityEngine.U2D.IK.IKChain2D m_Chain;
                /*0x50*/ bool m_Flip;
                /*0x58*/ UnityEngine.Vector3[] m_Positions;
                /*0x60*/ float[] m_Lengths;
                /*0x68*/ float[] m_Angles;

                /*0x3a93f84*/ LimbSolver2D();
                /*0x3a93478*/ bool get_flip();
                /*0x3a93480*/ void set_flip(bool value);
                /*0x3a93488*/ void DoInitialize();
                /*0x3a93528*/ int GetChainCount();
                /*0x3a93530*/ UnityEngine.U2D.IK.IKChain2D GetChain(int index);
                /*0x3a93538*/ void DoPrepare();
                /*0x3a93674*/ void DoUpdateIK(System.Collections.Generic.List<UnityEngine.Vector3> targetPositions);
            }

            class Solver2D : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable
            {
                /*0x20*/ bool m_ConstrainRotation;
                /*0x21*/ bool m_SolveFromDefaultPose;
                /*0x24*/ float m_Weight;
                /*0x28*/ UnityEngine.Plane m_Plane;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Vector3> m_TargetPositions;
                /*0x40*/ float m_LastFinalWeight;

                /*0x3a90850*/ Solver2D();
                /*0x3a933b0*/ int get_chainCount();
                /*0x3a94070*/ bool get_constrainRotation();
                /*0x3a94078*/ void set_constrainRotation(bool value);
                /*0x3a94080*/ bool get_solveFromDefaultPose();
                /*0x3a94088*/ void set_solveFromDefaultPose(bool value);
                /*0x3a930c4*/ bool get_isValid();
                /*0x3a9411c*/ bool get_allChainsHaveTargets();
                /*0x3a941fc*/ float get_weight();
                /*0x3a94204*/ void set_weight(float value);
                /*0x3a94224*/ void OnValidate();
                /*0x3a94090*/ bool Validate();
                /*0x3a94120*/ bool HasTargets();
                /*0x3a930c8*/ void Initialize();
                /*0x3a94248*/ void Prepare();
                /*0x3a943d8*/ void PrepareEffectorPositions();
                /*0x3a93144*/ void UpdateIK(float globalWeight);
                /*0x3a94558*/ void UpdateIK(System.Collections.Generic.List<UnityEngine.Vector3> targetPositions, float globalWeight);
                /*0x3a94738*/ void StoreLocalRotations();
                /*0x3a947a4*/ void BlendFkToIk(float finalWeight);
                /*0x1f30240*/ UnityEngine.U2D.IK.IKChain2D GetChain(int index);
                /*0x1f2ffc8*/ int GetChainCount();
                /*0x1f30ebc*/ void DoUpdateIK(System.Collections.Generic.List<UnityEngine.Vector3> targetPositions);
                /*0x3a94898*/ bool DoValidate();
                /*0x3a93524*/ void DoInitialize();
                /*0x3a948a0*/ void DoPrepare();
                /*0x3a948a4*/ UnityEngine.Transform GetPlaneRootTransform();
                /*0x3a94910*/ UnityEngine.Vector3 GetPointOnSolverPlane(UnityEngine.Vector3 worldPosition);
                /*0x3a9498c*/ UnityEngine.Vector3 GetWorldPositionFromSolverPlanePoint(UnityEngine.Vector2 planePoint);
                /*0x3a949cc*/ void OnPreviewUpdate();
            }

            class Solver2DMenuAttribute : System.Attribute
            {
                /*0x10*/ string m_MenuPath;

                /*0x3a949d0*/ Solver2DMenuAttribute(string _menuPath);
            }

            class CCD2D
            {
                static /*0x3a90688*/ bool Solve(UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 forward, int solverLimit, float tolerance, float velocity, ref UnityEngine.Vector3[] positions);
                static /*0x3a94a00*/ void DoIteration(UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 forward, int last, float velocity, ref UnityEngine.Vector3[] positions);
                static /*0x3a94c00*/ UnityEngine.Vector3 RotatePositionFrom(UnityEngine.Vector3 position, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation);
            }

            class Limb
            {
                static /*0x3a93dd4*/ bool Solve(UnityEngine.Vector3 targetPosition, float[] lengths, UnityEngine.Vector3[] positions, ref float[] outAngles);
            }
        }
    }
}
