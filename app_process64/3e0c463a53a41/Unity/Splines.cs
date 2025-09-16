class <Module>
{
}

namespace UnityEngine
{
    namespace Splines
    {
        class ArrayUtility
        {
            static /*0x3839e58*/ void RemoveAt<T>(ref T[] array, int index);
            static /*0x3907c14*/ void Remove<T>(ref T[] array, T element);
        }

        struct BezierCurve : System.IEquatable<UnityEngine.Splines.BezierCurve>
        {
            /*0x10*/ Unity.Mathematics.float3 P0;
            /*0x1c*/ Unity.Mathematics.float3 P1;
            /*0x28*/ Unity.Mathematics.float3 P2;
            /*0x34*/ Unity.Mathematics.float3 P3;

            /*0x7d03050*/ BezierCurve(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3);
            /*0x7d03080*/ BezierCurve(UnityEngine.Splines.BezierKnot a, UnityEngine.Splines.BezierKnot b);
            /*0x7d031c8*/ bool Equals(UnityEngine.Splines.BezierCurve other);
            /*0x7d03294*/ bool Equals(object obj);
            /*0x7d03324*/ int GetHashCode();
        }

        struct BezierKnot : UnityEngine.ISerializationCallbackReceiver, System.IEquatable<UnityEngine.Splines.BezierKnot>
        {
            /*0x10*/ Unity.Mathematics.float3 Position;
            /*0x1c*/ Unity.Mathematics.float3 TangentIn;
            /*0x28*/ Unity.Mathematics.float3 TangentOut;
            /*0x34*/ Unity.Mathematics.quaternion Rotation;

            /*0x7d033dc*/ BezierKnot(Unity.Mathematics.float3 position);
            /*0x7d0345c*/ BezierKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 tangentIn, Unity.Mathematics.float3 tangentOut, Unity.Mathematics.quaternion rotation);
            /*0x7d03484*/ UnityEngine.Splines.BezierKnot Transform(Unity.Mathematics.float4x4 matrix);
            /*0x7d03810*/ UnityEngine.Splines.BezierKnot BakeTangentDirectionToRotation(bool mirrored, UnityEngine.Splines.BezierTangent main);
            /*0x7d04108*/ void OnBeforeSerialize();
            /*0x7d0410c*/ void OnAfterDeserialize();
            /*0x7d04188*/ string ToString();
            /*0x7d04390*/ bool Equals(UnityEngine.Splines.BezierKnot other);
            /*0x7d0446c*/ bool Equals(object obj);
            /*0x7d04504*/ int GetHashCode();
        }

        enum TangentMode
        {
            AutoSmooth = 0,
            Linear = 1,
            Mirrored = 2,
            Continuous = 3,
            Broken = 4,
        }

        enum BezierTangent
        {
            In = 0,
            Out = 1,
        }

        class CurveUtility
        {
            static /*0x0*/ UnityEngine.Splines.DistanceToInterpolation[] k_DistanceLUT;

            static /*0x7d05e2c*/ CurveUtility();
            static /*0x7d045e0*/ Unity.Mathematics.float3 EvaluatePosition(UnityEngine.Splines.BezierCurve curve, float t);
            static /*0x7d046ac*/ Unity.Mathematics.float3 EvaluateTangent(UnityEngine.Splines.BezierCurve curve, float t);
            static /*0x7d0477c*/ Unity.Mathematics.float3 EvaluateAcceleration(UnityEngine.Splines.BezierCurve curve, float t);
            static /*0x7d04830*/ void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.DistanceToInterpolation[] lookupTable);
            static /*0x7d04918*/ void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, Unity.Collections.NativeArray<UnityEngine.Splines.DistanceToInterpolation> lookupTable);
            static /*0x7d04ae4*/ bool Approximately(float a, float b);
            static /*0x7d04b2c*/ void EvaluateUpVectors(UnityEngine.Splines.BezierCurve curve, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp, Unity.Collections.NativeArray<Unity.Mathematics.float3> upVectors);
            static /*0x7d04c70*/ Unity.Mathematics.float3 EvaluateUpVector(UnityEngine.Splines.BezierCurve curve, float t, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp, bool fixEndUpMismatch);
            static /*0x7d05afc*/ UnityEngine.Splines.CurveUtility.FrenetFrame GetNextRotationMinimizingFrame(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.CurveUtility.FrenetFrame previousRMFrame, float nextRMFrameT);
            static /*0x3907c14*/ float GetDistanceToInterpolation<T>(T lut, float distance);

            struct FrenetFrame
            {
                /*0x10*/ Unity.Mathematics.float3 origin;
                /*0x1c*/ Unity.Mathematics.float3 tangent;
                /*0x28*/ Unity.Mathematics.float3 normal;
                /*0x34*/ Unity.Mathematics.float3 binormal;
            }
        }

        interface IDataPoint
        {
            /*0x380c2e4*/ float get_Index();
        }

        struct DataPoint<TDataType> : System.IComparable<UnityEngine.Splines.DataPoint<TDataType>>, System.IComparable<float>, UnityEngine.Splines.IDataPoint
        {
            /*0x0*/ float m_Index;
            /*0x0*/ TDataType m_Value;

            /*0x3907c14*/ DataPoint(float index, TDataType value);
            /*0x380c2e4*/ float get_Index();
            /*0x380e050*/ void set_Index(float value);
            /*0x3907c14*/ TDataType get_Value();
            /*0x3907c14*/ void set_Value(TDataType value);
            /*0x3907c14*/ int CompareTo(UnityEngine.Splines.DataPoint<TDataType> other);
            int CompareTo(float other);
            /*0x380b9e8*/ string ToString();
        }

        class DataPointComparer<T> : System.Collections.Generic.IComparer<T>
        {
            /*0x380cb08*/ DataPointComparer();
            /*0x3907c14*/ int Compare(T x, T y);
        }

        struct DistanceToInterpolation
        {
            static /*0x0*/ UnityEngine.Splines.DistanceToInterpolation Invalid;
            /*0x10*/ float Distance;
            /*0x14*/ float T;

            static /*0x7d05ea0*/ DistanceToInterpolation();
        }

        interface IHasEmptyCurves
        {
            /*0x380b9e8*/ System.Collections.Generic.IReadOnlyList<int> get_EmptyCurves();
        }

        interface ISpline : System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.BezierKnot>
        {
            /*0x380b128*/ bool get_Closed();
            /*0x380c2e4*/ float GetLength();
            UnityEngine.Splines.BezierCurve GetCurve(int index);
            float GetCurveLength(int index);
            Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            float GetCurveInterpolation(int curveIndex, float curveDistance);
        }

        interface ISplineContainer
        {
            /*0x380b9e8*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines();
            /*0x380b9e8*/ UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection();
        }

        class KnotLinkCollection
        {
            /*0x10*/ UnityEngine.Splines.KnotLinkCollection.KnotLink[] m_KnotsLink;

            /*0x7d061c0*/ KnotLinkCollection();
            /*0x7d05eec*/ UnityEngine.Splines.KnotLinkCollection.KnotLink GetKnotLinksInternal(UnityEngine.Splines.SplineKnotIndex index);
            /*0x7d05f98*/ bool TryGetKnotLinks(UnityEngine.Splines.SplineKnotIndex knotIndex, ref System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex> linkedKnots);
            /*0x7d05fc8*/ void Unlink(UnityEngine.Splines.SplineKnotIndex knot);
            /*0x7d06094*/ void KnotRemoved(int splineIndex, int knotIndex);
            /*0x7d060d0*/ void KnotRemoved(UnityEngine.Splines.SplineKnotIndex index);
            /*0x7d061a8*/ void KnotInserted(int splineIndex, int knotIndex);
            /*0x7d061b8*/ void KnotInserted(UnityEngine.Splines.SplineKnotIndex index);
            /*0x7d060fc*/ void ShiftKnotIndices(UnityEngine.Splines.SplineKnotIndex index, int offset);

            class KnotLink : System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.SplineKnotIndex>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.SplineKnotIndex>
            {
                /*0x10*/ UnityEngine.Splines.SplineKnotIndex[] Knots;

                /*0x7d0632c*/ KnotLink();
                /*0x7d06224*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineKnotIndex> GetEnumerator();
                /*0x7d062c4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7d062e0*/ int get_Count();
                /*0x7d062fc*/ UnityEngine.Splines.SplineKnotIndex get_Item(int index);
            }
        }

        class MathUtility
        {
            static /*0x7d06334*/ bool All(Unity.Mathematics.float4x4 matrixA, Unity.Mathematics.float4x4 matrixB);
        }

        struct NativeSpline : UnityEngine.Splines.ISpline, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.BezierKnot>, System.IDisposable
        {
            static int k_SegmentResolution = 30;
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Splines.BezierKnot> m_Knots;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Splines.BezierCurve> m_Curves;
            /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Splines.DistanceToInterpolation> m_SegmentLengthsLookupTable;
            /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> m_UpVectorsLookupTable;
            /*0x50*/ bool m_Closed;
            /*0x54*/ float m_Length;

            /*0x7d06544*/ NativeSpline(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator);
            /*0x7d070cc*/ NativeSpline(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, bool cacheUpVectors, Unity.Collections.Allocator allocator);
            /*0x7d066dc*/ NativeSpline(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot> knots, System.Collections.Generic.IReadOnlyList<int> splits, bool closed, Unity.Mathematics.float4x4 transform, bool cacheUpVectors, Unity.Collections.Allocator allocator);
            /*0x7d06460*/ bool get_Closed();
            /*0x7d06468*/ int get_Count();
            /*0x7d06470*/ float GetLength();
            /*0x7d06478*/ UnityEngine.Splines.BezierKnot get_Item(int index);
            /*0x7d064a0*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator();
            /*0x7d06540*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7d07268*/ UnityEngine.Splines.BezierCurve GetCurve(int index);
            /*0x7d07288*/ float GetCurveLength(int curveIndex);
            /*0x7d072a4*/ Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            /*0x7d073e0*/ void Dispose();
            /*0x7d07498*/ float GetCurveInterpolation(int curveIndex, float curveDistance);

            struct Slice<T> : System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Slice;

                /*0x3907c14*/ Slice(Unity.Collections.NativeArray<T> array, int start, int count);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380b6a0*/ int get_Count();
                /*0x3907c14*/ T get_Item(int index);
            }
        }

        class Spline : UnityEngine.Splines.ISpline, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.ICollection<UnityEngine.Splines.BezierKnot>
        {
            static UnityEngine.Splines.TangentMode k_DefaultTangentMode = 4;
            static UnityEngine.Splines.BezierTangent k_DefaultMainTangent = 1;
            static int k_BatchModification = -1;
            static int k_CurveDistanceLutResolution = 30;
            static /*0x0*/ System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification> Changed;
            /*0x10*/ UnityEngine.Splines.SplineType m_EditModeType;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Splines.BezierKnot> m_Knots;
            /*0x20*/ float m_Length;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Splines.Spline.MetaData> m_MetaData;
            /*0x30*/ bool m_Closed;
            /*0x38*/ UnityEngine.Splines.SplineDataDictionary<int> m_IntData;
            /*0x40*/ UnityEngine.Splines.SplineDataDictionary<float> m_FloatData;
            /*0x48*/ UnityEngine.Splines.SplineDataDictionary<Unity.Mathematics.float4> m_Float4Data;
            /*0x50*/ UnityEngine.Splines.SplineDataDictionary<UnityEngine.Object> m_ObjectData;
            /*0x58*/ System.Action changed;
            /*0x60*/ System.ValueTuple<float, float> m_LastKnotChangeCurveLengths;

            static /*0x7d07690*/ void add_Changed(System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification> value);
            static /*0x7d0775c*/ void remove_Changed(System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification> value);
            /*0x7d094bc*/ Spline();
            /*0x7d07590*/ System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler> get_embeddedSplineData();
            /*0x7d07640*/ int get_Count();
            /*0x7d07688*/ bool get_IsReadOnly();
            /*0x7d07828*/ void SetDirtyNoNotify();
            /*0x7d07ac0*/ void SetDirty(UnityEngine.Splines.SplineModification modificationEvent, int knotIndex);
            /*0x7d07f40*/ void OnSplineChanged();
            /*0x7d078d0*/ void EnsureMetaDataValid();
            /*0x7d07ff4*/ UnityEngine.Splines.TangentMode GetTangentMode(int index);
            /*0x7d08080*/ void SetTangentMode(int index, UnityEngine.Splines.TangentMode mode, UnityEngine.Splines.BezierTangent main);
            /*0x7d0811c*/ void SetTangentMode(UnityEngine.Splines.SplineRange range, UnityEngine.Splines.TangentMode mode, UnityEngine.Splines.BezierTangent main);
            /*0x7d084f8*/ void SetTangentModeNoNotify(int index, UnityEngine.Splines.TangentMode mode, UnityEngine.Splines.BezierTangent main);
            /*0x7d088a0*/ void ApplyTangentModeNoNotify(int index, UnityEngine.Splines.BezierTangent main);
            /*0x7d08db4*/ bool get_Closed();
            /*0x7d08dbc*/ int IndexOf(UnityEngine.Splines.BezierKnot item);
            /*0x7d08e50*/ void Insert(int index, UnityEngine.Splines.BezierKnot knot);
            /*0x7d08f0c*/ void Insert(int index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode);
            /*0x7d08e8c*/ void Insert(int index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, float tension);
            /*0x7d08f44*/ void InsertNoNotify(int index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, float tension);
            /*0x7d090f0*/ void RemoveAt(int index);
            /*0x7d09204*/ UnityEngine.Splines.BezierKnot get_Item(int index);
            /*0x7d09294*/ void set_Item(int index, UnityEngine.Splines.BezierKnot value);
            /*0x7d092cc*/ void SetKnot(int index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main);
            /*0x7d0933c*/ void SetKnotNoNotify(int index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main);
            /*0x7d096e8*/ UnityEngine.Splines.BezierCurve GetCurve(int index);
            /*0x7d09818*/ float GetCurveLength(int index);
            /*0x7d099a0*/ float GetLength();
            /*0x7d09a14*/ UnityEngine.Splines.DistanceToInterpolation[] GetCurveDistanceLut(int index);
            /*0x7d09b30*/ float GetCurveInterpolation(int curveIndex, float curveDistance);
            /*0x7d09bcc*/ void WarmUpCurveUps();
            /*0x7d09d10*/ Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            /*0x7d09f28*/ void Warmup();
            /*0x7d09f40*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator();
            /*0x7d09fe0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7d0a080*/ void Add(UnityEngine.Splines.BezierKnot item);
            /*0x7d0a0e4*/ void Add(UnityEngine.Splines.BezierKnot item, UnityEngine.Splines.TangentMode mode);
            /*0x7d0a140*/ void Clear();
            /*0x7d0a1d4*/ bool Contains(UnityEngine.Splines.BezierKnot item);
            /*0x7d0a26c*/ void CopyTo(UnityEngine.Splines.BezierKnot[] array, int arrayIndex);
            /*0x7d0a2d4*/ bool Remove(UnityEngine.Splines.BezierKnot item);
            /*0x7d08464*/ void CacheKnotOperationCurves(int index);

            class MetaData
            {
                /*0x10*/ UnityEngine.Splines.TangentMode Mode;
                /*0x14*/ float Tension;
                /*0x18*/ UnityEngine.Splines.DistanceToInterpolation[] m_DistanceToInterpolation;
                /*0x20*/ Unity.Mathematics.float3[] m_UpVectors;

                /*0x7d07f44*/ MetaData();
                /*0x7d09920*/ UnityEngine.Splines.DistanceToInterpolation[] get_DistanceToInterpolation();
                /*0x7d09c90*/ Unity.Mathematics.float3[] get_UpVectors();
                /*0x7d079dc*/ void InvalidateCache();
            }

            class <get_embeddedSplineData>d__15 : System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Splines.ISplineModificationHandler <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.Splines.Spline <>4__this;
                /*0x30*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<int>> <>7__wrap1;
                /*0x38*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<float>> <>7__wrap2;
                /*0x40*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<Unity.Mathematics.float4>> <>7__wrap3;
                /*0x48*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<UnityEngine.Object>> <>7__wrap4;

                /*0x7d0760c*/ <get_embeddedSplineData>d__15(int <>1__state);
                /*0x7d0a384*/ void System.IDisposable.Dispose();
                /*0x7d0a3c0*/ bool MoveNext();
                /*0x7d0aaf8*/ void <>m__Finally1();
                /*0x7d0aba8*/ void <>m__Finally2();
                /*0x7d0ac58*/ void <>m__Finally3();
                /*0x7d0ad08*/ void <>m__Finally4();
                /*0x7d0adb8*/ UnityEngine.Splines.ISplineModificationHandler System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.get_Current();
                /*0x7d0adc0*/ void System.Collections.IEnumerator.Reset();
                /*0x7d0adf8*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d0ae00*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler> System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler>.GetEnumerator();
                /*0x7d0aea4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class SplineContainer : UnityEngine.MonoBehaviour, UnityEngine.Splines.ISplineContainer, UnityEngine.ISerializationCallbackReceiver
        {
            static string k_IconPath = "Packages/com.unity.splines/Editor/Resources/Icons/SplineComponent.png";
            static /*0x0*/ System.Action<UnityEngine.Splines.SplineContainer, int> SplineAdded;
            static /*0x8*/ System.Action<UnityEngine.Splines.SplineContainer, int> SplineRemoved;
            static /*0x10*/ System.Action<UnityEngine.Splines.SplineContainer, int, int> SplineReordered;
            static /*0x18*/ System.Collections.Generic.List<UnityEngine.Splines.SplineContainer.SplineToNative> m_AllocPreventionHelperBuffer;
            /*0x20*/ UnityEngine.Splines.Spline m_Spline;
            /*0x28*/ UnityEngine.Splines.Spline[] m_Splines;
            /*0x30*/ UnityEngine.Splines.KnotLinkCollection m_Knots;
            /*0x38*/ System.Collections.Generic.List<System.ValueTuple<int, int>> m_ReorderedSplinesIndices;
            /*0x40*/ System.Collections.Generic.List<int> m_RemovedSplinesIndices;
            /*0x48*/ System.Collections.Generic.List<int> m_AddedSplinesIndices;
            /*0x50*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Splines.Spline> m_ReadOnlySplines;
            /*0x58*/ System.Collections.Generic.Dictionary<UnityEngine.Splines.ISpline, UnityEngine.Splines.NativeSpline> m_NativeSplinesCache;
            /*0x60*/ Unity.Mathematics.float4x4 m_NativeSplinesCacheTransform;

            static /*0x7d0cfc8*/ SplineContainer();
            static /*0x7d0aea8*/ void add_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d0af98*/ void remove_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d0b088*/ void add_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d0b17c*/ void remove_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d0b270*/ void add_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer, int, int> value);
            static /*0x7d0b364*/ void remove_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer, int, int> value);
            static /*0x7d0c124*/ int IndexOf(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> self, UnityEngine.Splines.Spline elementToFind);
            /*0x7d0cd68*/ SplineContainer();
            /*0x7d0b458*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines();
            /*0x7d0b4f0*/ void set_Splines(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> value);
            /*0x7d0c2c4*/ UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection();
            /*0x7d0c2cc*/ UnityEngine.Splines.Spline get_Item(int index);
            /*0x7d0c2fc*/ void OnEnable();
            /*0x7d0c378*/ void OnDisable();
            /*0x7d0c3f4*/ void OnDestroy();
            /*0x7d0c3f8*/ void Warmup();
            /*0x7d0bed4*/ void ClearCaches();
            /*0x7d0bf64*/ void DisposeNativeSplinesCache();
            /*0x7d0c598*/ void OnSplineChanged(UnityEngine.Splines.Spline spline, int index, UnityEngine.Splines.SplineModification modificationType);
            /*0x7d0c6e0*/ void OnKnotModified(UnityEngine.Splines.Spline spline, int index);
            /*0x7d0c264*/ bool get_IsNonUniformlyScaled();
            /*0x7d0c778*/ UnityEngine.Splines.Spline get_Spline();
            /*0x7d0c7ac*/ void set_Spline(UnityEngine.Splines.Spline value);
            /*0x7d0c820*/ bool Evaluate(float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            /*0x7d0c834*/ bool Evaluate(int splineIndex, float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            /*0x3907c14*/ bool Evaluate<T>(T spline, float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            /*0x7d0c8dc*/ Unity.Mathematics.float3 EvaluatePosition(float t);
            /*0x7d0c8e4*/ Unity.Mathematics.float3 EvaluatePosition(int splineIndex, float t);
            /*0x3907c14*/ Unity.Mathematics.float3 EvaluatePosition<T>(T spline, float t);
            /*0x7d0c964*/ Unity.Mathematics.float3 EvaluateTangent(float t);
            /*0x7d0c96c*/ Unity.Mathematics.float3 EvaluateTangent(int splineIndex, float t);
            /*0x3907c14*/ Unity.Mathematics.float3 EvaluateTangent<T>(T spline, float t);
            /*0x7d0c9ec*/ Unity.Mathematics.float3 EvaluateUpVector(float t);
            /*0x7d0c9f4*/ Unity.Mathematics.float3 EvaluateUpVector(int splineIndex, float t);
            /*0x3907c14*/ Unity.Mathematics.float3 EvaluateUpVector<T>(T spline, float t);
            /*0x7d0ca74*/ Unity.Mathematics.float3 EvaluateAcceleration(float t);
            /*0x7d0ca7c*/ Unity.Mathematics.float3 EvaluateAcceleration(int splineIndex, float t);
            /*0x3907c14*/ Unity.Mathematics.float3 EvaluateAcceleration<T>(T spline, float t);
            /*0x7d0cafc*/ float CalculateLength();
            /*0x7d0cb04*/ float CalculateLength(int splineIndex);
            /*0x7d0cbd8*/ void OnBeforeSerialize();
            /*0x7d0cbdc*/ void OnAfterDeserialize();
            /*0x3907c14*/ UnityEngine.Splines.NativeSpline GetOrBakeNativeSpline<T>(T spline);

            struct SplineToNative
            {
                /*0x10*/ UnityEngine.Splines.ISpline spline;
                /*0x18*/ UnityEngine.Splines.NativeSpline nativeSpline;
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> value;
                /*0x18*/ int i;
                /*0x20*/ System.Predicate<UnityEngine.Splines.Spline> <>9__0;

                /*0x7d0becc*/ <>c__DisplayClass21_0();
                /*0x7d0d05c*/ bool <set_Splines>b__0(UnityEngine.Splines.Spline spline);
            }
        }

        interface IInterpolator<T>
        {
            /*0x3907c14*/ T Interpolate(T from, T to, float t);
        }

        enum PathIndexUnit
        {
            Distance = 0,
            Normalized = 1,
            Knot = 2,
        }

        interface ISplineModificationHandler
        {
            void OnSplineModified(UnityEngine.Splines.SplineModificationData info);
        }

        class SplineData<T> : System.Collections.Generic.IEnumerable<UnityEngine.Splines.DataPoint<T>>, System.Collections.IEnumerable, UnityEngine.Splines.ISplineModificationHandler
        {
            static /*0x0*/ UnityEngine.Splines.DataPointComparer<UnityEngine.Splines.DataPoint<T>> k_DataPointComparer;
            /*0x0*/ UnityEngine.Splines.PathIndexUnit m_IndexUnit;
            /*0x0*/ T m_DefaultValue;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Splines.DataPoint<T>> m_DataPoints;
            /*0x0*/ bool m_NeedsSort;
            /*0x0*/ System.Action changed;
            /*0x0*/ System.Action Changed;

            static /*0x38358cc*/ SplineData();
            static int Wrap(int value, int lowerBound, int upperBound);
            /*0x380cb08*/ SplineData();
            /*0x3907c14*/ UnityEngine.Splines.DataPoint<T> get_Item(int index);
            /*0x3907c14*/ void set_Item(int index, UnityEngine.Splines.DataPoint<T> value);
            /*0x3907c14*/ void set_DefaultValue(T value);
            /*0x380b6a0*/ int get_Count();
            /*0x380cb08*/ void SetDirty();
            /*0x3907c14*/ int Add(UnityEngine.Splines.DataPoint<T> dataPoint);
            /*0x380cffc*/ void RemoveAt(int index);
            /*0x380cb08*/ void Clear();
            /*0x3907c14*/ int ResolveBinaryIndex(int index, bool wrap);
            /*0x3907c14*/ System.ValueTuple<int, int, float> GetIndex(float t, float splineLength, int knotCount, bool closed);
            /*0x3907c14*/ T Evaluate<TSpline, TInterpolator>(TSpline spline, float t, UnityEngine.Splines.PathIndexUnit indexUnit, TInterpolator interpolator);
            /*0x3907c14*/ T Evaluate<TSpline, TInterpolator>(TSpline spline, float t, TInterpolator interpolator);
            /*0x3907c14*/ void SetDataPoint(int index, UnityEngine.Splines.DataPoint<T> value);
            /*0x380cb08*/ void SortIfNecessary();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>> GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(UnityEngine.Splines.SplineModificationData data);

            class <GetEnumerator>d__46<T> : System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ UnityEngine.Splines.DataPoint<T> <>2__current;
                /*0x0*/ UnityEngine.Splines.SplineData<T> <>4__this;
                /*0x0*/ int <i>5__2;
                /*0x0*/ int <c>5__3;

                /*0x380cffc*/ <GetEnumerator>d__46(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x3907c14*/ UnityEngine.Splines.DataPoint<T> System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class SplineDataKeyValuePair<T>
        {
            /*0x0*/ string Key;
            /*0x0*/ UnityEngine.Splines.SplineData<T> Value;

            /*0x380cb08*/ SplineDataKeyValuePair();
        }

        class SplineDataDictionary<T> : System.Collections.Generic.IEnumerable<UnityEngine.Splines.SplineDataKeyValuePair<T>>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Splines.SplineDataKeyValuePair<T>> m_Data;

            /*0x380cb08*/ SplineDataDictionary();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<T>> GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        struct SplineKnotIndex : System.IEquatable<UnityEngine.Splines.SplineKnotIndex>
        {
            static /*0x0*/ UnityEngine.Splines.SplineKnotIndex Invalid;
            /*0x10*/ int Spline;
            /*0x14*/ int Knot;

            static /*0x7d0d280*/ SplineKnotIndex();
            /*0x7d060c8*/ SplineKnotIndex(int spline, int knot);
            /*0x7d0d114*/ bool Equals(UnityEngine.Splines.SplineKnotIndex otherIndex);
            /*0x7d0d13c*/ bool Equals(object obj);
            /*0x7d0d1d8*/ int GetHashCode();
            /*0x7d0d1ec*/ string ToString();
        }

        class SplineMath
        {
            static /*0x7d0d2cc*/ Unity.Mathematics.float3 PointLineNearestPoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, ref float lineParam);
        }

        enum SplineModification
        {
            Default = 0,
            ClosedModified = 1,
            KnotModified = 2,
            KnotInserted = 3,
            KnotRemoved = 4,
            KnotReordered = 5,
        }

        struct SplineModificationData
        {
            /*0x10*/ UnityEngine.Splines.Spline Spline;
            /*0x18*/ UnityEngine.Splines.SplineModification Modification;
            /*0x1c*/ int KnotIndex;
            /*0x20*/ float PrevCurveLength;
            /*0x24*/ float NextCurveLength;

            /*0x7d07f00*/ SplineModificationData(UnityEngine.Splines.Spline spline, UnityEngine.Splines.SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength);
        }

        enum SliceDirection
        {
            Forward = 0,
            Backward = 1,
        }

        struct SplineRange : System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable
        {
            /*0x10*/ int m_Start;
            /*0x14*/ int m_Count;
            /*0x18*/ UnityEngine.Splines.SliceDirection m_Direction;

            /*0x7d08100*/ SplineRange(int start, int count);
            /*0x7d0d478*/ SplineRange(int start, int count, UnityEngine.Splines.SliceDirection direction);
            /*0x7d0d424*/ int get_Start();
            /*0x7d0d42c*/ int get_End();
            /*0x7d0d468*/ int get_Count();
            /*0x7d0d470*/ UnityEngine.Splines.SliceDirection get_Direction();
            /*0x7d0d450*/ int get_Item(int index);
            /*0x7d083d4*/ System.Collections.Generic.IEnumerator<int> GetEnumerator();
            /*0x7d0d4c4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7d0d4c8*/ string ToString();

            struct SplineRangeEnumerator : System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int m_Index;
                /*0x14*/ int m_Start;
                /*0x18*/ int m_End;
                /*0x1c*/ int m_Count;
                /*0x20*/ bool m_Reverse;

                /*0x7d0d490*/ SplineRangeEnumerator(UnityEngine.Splines.SplineRange range);
                /*0x7d0d578*/ bool MoveNext();
                /*0x7d0d598*/ void Reset();
                /*0x7d0d5a4*/ int get_Current();
                /*0x7d0d5c8*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d0d60c*/ void Dispose();
            }
        }

        enum SplineType
        {
            CatmullRom = 0,
            Bezier = 1,
            Linear = 2,
        }

        class SplineUtility
        {
            static /*0x3907c14*/ bool Evaluate<T>(T spline, float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            static /*0x3907c14*/ Unity.Mathematics.float3 EvaluatePosition<T>(T spline, float t);
            static /*0x3907c14*/ Unity.Mathematics.float3 EvaluateTangent<T>(T spline, float t);
            static /*0x3907c14*/ Unity.Mathematics.float3 EvaluateUpVector<T>(T spline, float t);
            static /*0x3907c14*/ Unity.Mathematics.float3 CalculateUpVector<T>(T spline, int curveIndex, float curveT);
            static /*0x3907c14*/ void EvaluateUpVectorsForCurve<T>(T spline, int curveIndex, Unity.Collections.NativeArray<Unity.Mathematics.float3> upVectors);
            static /*0x3907c14*/ void EvaluateUpVectorsForCurve<T>(T spline, int curveIndex, Unity.Mathematics.float3[] upVectors);
            static /*0x3907c14*/ Unity.Mathematics.float3 EvaluateAcceleration<T>(T spline, float t);
            static /*0x3907c14*/ int SplineToCurveT<T>(T spline, float splineT, ref float curveT);
            static /*0x3907c14*/ int SplineToCurveT<T>(T spline, float splineT, ref float curveT, bool useLUT);
            static /*0x3907c14*/ float CurveToSplineT<T>(T spline, float curve);
            static /*0x3907c14*/ float CalculateLength<T>(T spline, Unity.Mathematics.float4x4 transform);
            static /*0x7d0d610*/ int GetSubdivisionCount(float length, int resolution);
            static /*0x3907c14*/ UnityEngine.Splines.SplineUtility.Segment GetNearestPoint<T>(T spline, Unity.Mathematics.float3 point, UnityEngine.Splines.SplineUtility.Segment range, ref float distance, ref Unity.Mathematics.float3 nearest, ref float time, int segments);
            static /*0x3907c14*/ float GetNearestPoint<T>(T spline, Unity.Mathematics.float3 point, ref Unity.Mathematics.float3 nearest, ref float t, int resolution, int iterations);
            static /*0x3907c14*/ float ConvertIndexUnit<T>(T spline, float value, UnityEngine.Splines.PathIndexUnit fromPathUnit, UnityEngine.Splines.PathIndexUnit targetPathUnit);
            static /*0x3907c14*/ float ConvertNormalizedIndexUnit<T>(T spline, float t, UnityEngine.Splines.PathIndexUnit targetPathUnit);
            static /*0x7d0d6d0*/ float WrapInterpolation(float t, bool closed);
            static /*0x3907c14*/ float GetNormalizedInterpolation<T>(T spline, float t, UnityEngine.Splines.PathIndexUnit originalPathUnit);
            static /*0x3907c14*/ int PreviousIndex<T>(T spline, int index);
            static /*0x3907c14*/ int NextIndex<T>(T spline, int index);
            static /*0x3907c14*/ UnityEngine.Splines.BezierKnot Previous<T>(T spline, int index);
            static /*0x3907c14*/ UnityEngine.Splines.BezierKnot Next<T>(T spline, int index);
            static /*0x7d0d798*/ int PreviousIndex(int index, int count, bool wrap);
            static /*0x7d0d7b8*/ int NextIndex(int index, int count, bool wrap);
            static /*0x7d05adc*/ Unity.Mathematics.float3 GetExplicitLinearTangent(Unity.Mathematics.float3 point, Unity.Mathematics.float3 to);
            static /*0x7d087b0*/ Unity.Mathematics.float3 GetExplicitLinearTangent(UnityEngine.Splines.BezierKnot from, UnityEngine.Splines.BezierKnot to);
            static /*0x7d0d7dc*/ Unity.Mathematics.float3 GetAutoSmoothTangent(Unity.Mathematics.float3 previous, Unity.Mathematics.float3 current, Unity.Mathematics.float3 next, float tension);
            static /*0x7d08bc0*/ UnityEngine.Splines.BezierKnot GetAutoSmoothKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 previous, Unity.Mathematics.float3 next, Unity.Mathematics.float3 normal, float tension);
            static /*0x7d03c1c*/ Unity.Mathematics.quaternion GetKnotRotation(Unity.Mathematics.float3 tangent, Unity.Mathematics.float3 normal);
            static /*0x3907c14*/ bool IsIndexValid<T>(T container, UnityEngine.Splines.SplineKnotIndex index);
            static /*0x3907c14*/ void SetLinkedKnotPosition<T>(T container, UnityEngine.Splines.SplineKnotIndex index);

            struct Segment
            {
                /*0x10*/ float start;
                /*0x14*/ float length;

                /*0x7d0db1c*/ Segment(float start, float length);
            }
        }
    }
}
