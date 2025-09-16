class <Module>
{
}

namespace UnityEngine
{
    namespace Splines
    {
        class ArrayUtility
        {
            static /*0x3842d2c*/ void RemoveAt<T>(ref T[] array, int index);
            static /*0x3910ae8*/ void Remove<T>(ref T[] array, T element);
        }

        struct BezierCurve : System.IEquatable<UnityEngine.Splines.BezierCurve>
        {
            /*0x10*/ Unity.Mathematics.float3 P0;
            /*0x1c*/ Unity.Mathematics.float3 P1;
            /*0x28*/ Unity.Mathematics.float3 P2;
            /*0x34*/ Unity.Mathematics.float3 P3;

            /*0x7d1a480*/ BezierCurve(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3);
            /*0x7d1a4b0*/ BezierCurve(UnityEngine.Splines.BezierKnot a, UnityEngine.Splines.BezierKnot b);
            /*0x7d1a5f8*/ bool Equals(UnityEngine.Splines.BezierCurve other);
            /*0x7d1a6c4*/ bool Equals(object obj);
            /*0x7d1a754*/ int GetHashCode();
        }

        struct BezierKnot : UnityEngine.ISerializationCallbackReceiver, System.IEquatable<UnityEngine.Splines.BezierKnot>
        {
            /*0x10*/ Unity.Mathematics.float3 Position;
            /*0x1c*/ Unity.Mathematics.float3 TangentIn;
            /*0x28*/ Unity.Mathematics.float3 TangentOut;
            /*0x34*/ Unity.Mathematics.quaternion Rotation;

            /*0x7d1a80c*/ BezierKnot(Unity.Mathematics.float3 position);
            /*0x7d1a88c*/ BezierKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 tangentIn, Unity.Mathematics.float3 tangentOut, Unity.Mathematics.quaternion rotation);
            /*0x7d1a8b4*/ UnityEngine.Splines.BezierKnot Transform(Unity.Mathematics.float4x4 matrix);
            /*0x7d1ac40*/ UnityEngine.Splines.BezierKnot BakeTangentDirectionToRotation(bool mirrored, UnityEngine.Splines.BezierTangent main);
            /*0x7d1b538*/ void OnBeforeSerialize();
            /*0x7d1b53c*/ void OnAfterDeserialize();
            /*0x7d1b5b8*/ string ToString();
            /*0x7d1b7c0*/ bool Equals(UnityEngine.Splines.BezierKnot other);
            /*0x7d1b89c*/ bool Equals(object obj);
            /*0x7d1b934*/ int GetHashCode();
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

            static /*0x7d1d25c*/ CurveUtility();
            static /*0x7d1ba10*/ Unity.Mathematics.float3 EvaluatePosition(UnityEngine.Splines.BezierCurve curve, float t);
            static /*0x7d1badc*/ Unity.Mathematics.float3 EvaluateTangent(UnityEngine.Splines.BezierCurve curve, float t);
            static /*0x7d1bbac*/ Unity.Mathematics.float3 EvaluateAcceleration(UnityEngine.Splines.BezierCurve curve, float t);
            static /*0x7d1bc60*/ void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.DistanceToInterpolation[] lookupTable);
            static /*0x7d1bd48*/ void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, Unity.Collections.NativeArray<UnityEngine.Splines.DistanceToInterpolation> lookupTable);
            static /*0x7d1bf14*/ bool Approximately(float a, float b);
            static /*0x7d1bf5c*/ void EvaluateUpVectors(UnityEngine.Splines.BezierCurve curve, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp, Unity.Collections.NativeArray<Unity.Mathematics.float3> upVectors);
            static /*0x7d1c0a0*/ Unity.Mathematics.float3 EvaluateUpVector(UnityEngine.Splines.BezierCurve curve, float t, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp, bool fixEndUpMismatch);
            static /*0x7d1cf2c*/ UnityEngine.Splines.CurveUtility.FrenetFrame GetNextRotationMinimizingFrame(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.CurveUtility.FrenetFrame previousRMFrame, float nextRMFrameT);
            static /*0x3910ae8*/ float GetDistanceToInterpolation<T>(T lut, float distance);

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
            /*0x38151b8*/ float get_Index();
        }

        struct DataPoint<TDataType> : System.IComparable<UnityEngine.Splines.DataPoint<TDataType>>, System.IComparable<float>, UnityEngine.Splines.IDataPoint
        {
            /*0x0*/ float m_Index;
            /*0x0*/ TDataType m_Value;

            /*0x3910ae8*/ DataPoint(float index, TDataType value);
            /*0x38151b8*/ float get_Index();
            /*0x3816f24*/ void set_Index(float value);
            /*0x3910ae8*/ TDataType get_Value();
            /*0x3910ae8*/ void set_Value(TDataType value);
            /*0x3910ae8*/ int CompareTo(UnityEngine.Splines.DataPoint<TDataType> other);
            int CompareTo(float other);
            /*0x38148bc*/ string ToString();
        }

        class DataPointComparer<T> : System.Collections.Generic.IComparer<T>
        {
            /*0x38159dc*/ DataPointComparer();
            /*0x3910ae8*/ int Compare(T x, T y);
        }

        struct DistanceToInterpolation
        {
            static /*0x0*/ UnityEngine.Splines.DistanceToInterpolation Invalid;
            /*0x10*/ float Distance;
            /*0x14*/ float T;

            static /*0x7d1d2d0*/ DistanceToInterpolation();
        }

        interface IHasEmptyCurves
        {
            /*0x38148bc*/ System.Collections.Generic.IReadOnlyList<int> get_EmptyCurves();
        }

        interface ISpline : System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.BezierKnot>
        {
            /*0x3813ffc*/ bool get_Closed();
            /*0x38151b8*/ float GetLength();
            UnityEngine.Splines.BezierCurve GetCurve(int index);
            float GetCurveLength(int index);
            Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            float GetCurveInterpolation(int curveIndex, float curveDistance);
        }

        interface ISplineContainer
        {
            /*0x38148bc*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines();
            /*0x38148bc*/ UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection();
        }

        class KnotLinkCollection
        {
            /*0x10*/ UnityEngine.Splines.KnotLinkCollection.KnotLink[] m_KnotsLink;

            /*0x7d1d5f0*/ KnotLinkCollection();
            /*0x7d1d31c*/ UnityEngine.Splines.KnotLinkCollection.KnotLink GetKnotLinksInternal(UnityEngine.Splines.SplineKnotIndex index);
            /*0x7d1d3c8*/ bool TryGetKnotLinks(UnityEngine.Splines.SplineKnotIndex knotIndex, ref System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex> linkedKnots);
            /*0x7d1d3f8*/ void Unlink(UnityEngine.Splines.SplineKnotIndex knot);
            /*0x7d1d4c4*/ void KnotRemoved(int splineIndex, int knotIndex);
            /*0x7d1d500*/ void KnotRemoved(UnityEngine.Splines.SplineKnotIndex index);
            /*0x7d1d5d8*/ void KnotInserted(int splineIndex, int knotIndex);
            /*0x7d1d5e8*/ void KnotInserted(UnityEngine.Splines.SplineKnotIndex index);
            /*0x7d1d52c*/ void ShiftKnotIndices(UnityEngine.Splines.SplineKnotIndex index, int offset);

            class KnotLink : System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>, System.Collections.Generic.IEnumerable<UnityEngine.Splines.SplineKnotIndex>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Splines.SplineKnotIndex>
            {
                /*0x10*/ UnityEngine.Splines.SplineKnotIndex[] Knots;

                /*0x7d1d75c*/ KnotLink();
                /*0x7d1d654*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineKnotIndex> GetEnumerator();
                /*0x7d1d6f4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7d1d710*/ int get_Count();
                /*0x7d1d72c*/ UnityEngine.Splines.SplineKnotIndex get_Item(int index);
            }
        }

        class MathUtility
        {
            static /*0x7d1d764*/ bool All(Unity.Mathematics.float4x4 matrixA, Unity.Mathematics.float4x4 matrixB);
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

            /*0x7d1d974*/ NativeSpline(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator);
            /*0x7d1e4fc*/ NativeSpline(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, bool cacheUpVectors, Unity.Collections.Allocator allocator);
            /*0x7d1db0c*/ NativeSpline(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot> knots, System.Collections.Generic.IReadOnlyList<int> splits, bool closed, Unity.Mathematics.float4x4 transform, bool cacheUpVectors, Unity.Collections.Allocator allocator);
            /*0x7d1d890*/ bool get_Closed();
            /*0x7d1d898*/ int get_Count();
            /*0x7d1d8a0*/ float GetLength();
            /*0x7d1d8a8*/ UnityEngine.Splines.BezierKnot get_Item(int index);
            /*0x7d1d8d0*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator();
            /*0x7d1d970*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7d1e698*/ UnityEngine.Splines.BezierCurve GetCurve(int index);
            /*0x7d1e6b8*/ float GetCurveLength(int curveIndex);
            /*0x7d1e6d4*/ Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            /*0x7d1e810*/ void Dispose();
            /*0x7d1e8c8*/ float GetCurveInterpolation(int curveIndex, float curveDistance);

            struct Slice<T> : System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Slice;

                /*0x3910ae8*/ Slice(Unity.Collections.NativeArray<T> array, int start, int count);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3814574*/ int get_Count();
                /*0x3910ae8*/ T get_Item(int index);
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

            static /*0x7d1eac0*/ void add_Changed(System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification> value);
            static /*0x7d1eb8c*/ void remove_Changed(System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification> value);
            /*0x7d208ec*/ Spline();
            /*0x7d1e9c0*/ System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler> get_embeddedSplineData();
            /*0x7d1ea70*/ int get_Count();
            /*0x7d1eab8*/ bool get_IsReadOnly();
            /*0x7d1ec58*/ void SetDirtyNoNotify();
            /*0x7d1eef0*/ void SetDirty(UnityEngine.Splines.SplineModification modificationEvent, int knotIndex);
            /*0x7d1f370*/ void OnSplineChanged();
            /*0x7d1ed00*/ void EnsureMetaDataValid();
            /*0x7d1f424*/ UnityEngine.Splines.TangentMode GetTangentMode(int index);
            /*0x7d1f4b0*/ void SetTangentMode(int index, UnityEngine.Splines.TangentMode mode, UnityEngine.Splines.BezierTangent main);
            /*0x7d1f54c*/ void SetTangentMode(UnityEngine.Splines.SplineRange range, UnityEngine.Splines.TangentMode mode, UnityEngine.Splines.BezierTangent main);
            /*0x7d1f928*/ void SetTangentModeNoNotify(int index, UnityEngine.Splines.TangentMode mode, UnityEngine.Splines.BezierTangent main);
            /*0x7d1fcd0*/ void ApplyTangentModeNoNotify(int index, UnityEngine.Splines.BezierTangent main);
            /*0x7d201e4*/ bool get_Closed();
            /*0x7d201ec*/ int IndexOf(UnityEngine.Splines.BezierKnot item);
            /*0x7d20280*/ void Insert(int index, UnityEngine.Splines.BezierKnot knot);
            /*0x7d2033c*/ void Insert(int index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode);
            /*0x7d202bc*/ void Insert(int index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, float tension);
            /*0x7d20374*/ void InsertNoNotify(int index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, float tension);
            /*0x7d20520*/ void RemoveAt(int index);
            /*0x7d20634*/ UnityEngine.Splines.BezierKnot get_Item(int index);
            /*0x7d206c4*/ void set_Item(int index, UnityEngine.Splines.BezierKnot value);
            /*0x7d206fc*/ void SetKnot(int index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main);
            /*0x7d2076c*/ void SetKnotNoNotify(int index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main);
            /*0x7d20b18*/ UnityEngine.Splines.BezierCurve GetCurve(int index);
            /*0x7d20c48*/ float GetCurveLength(int index);
            /*0x7d20dd0*/ float GetLength();
            /*0x7d20e44*/ UnityEngine.Splines.DistanceToInterpolation[] GetCurveDistanceLut(int index);
            /*0x7d20f60*/ float GetCurveInterpolation(int curveIndex, float curveDistance);
            /*0x7d20ffc*/ void WarmUpCurveUps();
            /*0x7d21140*/ Unity.Mathematics.float3 GetCurveUpVector(int index, float t);
            /*0x7d21358*/ void Warmup();
            /*0x7d21370*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator();
            /*0x7d21410*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7d214b0*/ void Add(UnityEngine.Splines.BezierKnot item);
            /*0x7d21514*/ void Add(UnityEngine.Splines.BezierKnot item, UnityEngine.Splines.TangentMode mode);
            /*0x7d21570*/ void Clear();
            /*0x7d21604*/ bool Contains(UnityEngine.Splines.BezierKnot item);
            /*0x7d2169c*/ void CopyTo(UnityEngine.Splines.BezierKnot[] array, int arrayIndex);
            /*0x7d21704*/ bool Remove(UnityEngine.Splines.BezierKnot item);
            /*0x7d1f894*/ void CacheKnotOperationCurves(int index);

            class MetaData
            {
                /*0x10*/ UnityEngine.Splines.TangentMode Mode;
                /*0x14*/ float Tension;
                /*0x18*/ UnityEngine.Splines.DistanceToInterpolation[] m_DistanceToInterpolation;
                /*0x20*/ Unity.Mathematics.float3[] m_UpVectors;

                /*0x7d1f374*/ MetaData();
                /*0x7d20d50*/ UnityEngine.Splines.DistanceToInterpolation[] get_DistanceToInterpolation();
                /*0x7d210c0*/ Unity.Mathematics.float3[] get_UpVectors();
                /*0x7d1ee0c*/ void InvalidateCache();
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

                /*0x7d1ea3c*/ <get_embeddedSplineData>d__15(int <>1__state);
                /*0x7d217b4*/ void System.IDisposable.Dispose();
                /*0x7d217f0*/ bool MoveNext();
                /*0x7d21f28*/ void <>m__Finally1();
                /*0x7d21fd8*/ void <>m__Finally2();
                /*0x7d22088*/ void <>m__Finally3();
                /*0x7d22138*/ void <>m__Finally4();
                /*0x7d221e8*/ UnityEngine.Splines.ISplineModificationHandler System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.get_Current();
                /*0x7d221f0*/ void System.Collections.IEnumerator.Reset();
                /*0x7d22228*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d22230*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler> System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler>.GetEnumerator();
                /*0x7d222d4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7d243f8*/ SplineContainer();
            static /*0x7d222d8*/ void add_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d223c8*/ void remove_SplineAdded(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d224b8*/ void add_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d225ac*/ void remove_SplineRemoved(System.Action<UnityEngine.Splines.SplineContainer, int> value);
            static /*0x7d226a0*/ void add_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer, int, int> value);
            static /*0x7d22794*/ void remove_SplineReordered(System.Action<UnityEngine.Splines.SplineContainer, int, int> value);
            static /*0x7d23554*/ int IndexOf(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> self, UnityEngine.Splines.Spline elementToFind);
            /*0x7d24198*/ SplineContainer();
            /*0x7d22888*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> get_Splines();
            /*0x7d22920*/ void set_Splines(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> value);
            /*0x7d236f4*/ UnityEngine.Splines.KnotLinkCollection get_KnotLinkCollection();
            /*0x7d236fc*/ UnityEngine.Splines.Spline get_Item(int index);
            /*0x7d2372c*/ void OnEnable();
            /*0x7d237a8*/ void OnDisable();
            /*0x7d23824*/ void OnDestroy();
            /*0x7d23828*/ void Warmup();
            /*0x7d23304*/ void ClearCaches();
            /*0x7d23394*/ void DisposeNativeSplinesCache();
            /*0x7d239c8*/ void OnSplineChanged(UnityEngine.Splines.Spline spline, int index, UnityEngine.Splines.SplineModification modificationType);
            /*0x7d23b10*/ void OnKnotModified(UnityEngine.Splines.Spline spline, int index);
            /*0x7d23694*/ bool get_IsNonUniformlyScaled();
            /*0x7d23ba8*/ UnityEngine.Splines.Spline get_Spline();
            /*0x7d23bdc*/ void set_Spline(UnityEngine.Splines.Spline value);
            /*0x7d23c50*/ bool Evaluate(float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            /*0x7d23c64*/ bool Evaluate(int splineIndex, float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            /*0x3910ae8*/ bool Evaluate<T>(T spline, float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            /*0x7d23d0c*/ Unity.Mathematics.float3 EvaluatePosition(float t);
            /*0x7d23d14*/ Unity.Mathematics.float3 EvaluatePosition(int splineIndex, float t);
            /*0x3910ae8*/ Unity.Mathematics.float3 EvaluatePosition<T>(T spline, float t);
            /*0x7d23d94*/ Unity.Mathematics.float3 EvaluateTangent(float t);
            /*0x7d23d9c*/ Unity.Mathematics.float3 EvaluateTangent(int splineIndex, float t);
            /*0x3910ae8*/ Unity.Mathematics.float3 EvaluateTangent<T>(T spline, float t);
            /*0x7d23e1c*/ Unity.Mathematics.float3 EvaluateUpVector(float t);
            /*0x7d23e24*/ Unity.Mathematics.float3 EvaluateUpVector(int splineIndex, float t);
            /*0x3910ae8*/ Unity.Mathematics.float3 EvaluateUpVector<T>(T spline, float t);
            /*0x7d23ea4*/ Unity.Mathematics.float3 EvaluateAcceleration(float t);
            /*0x7d23eac*/ Unity.Mathematics.float3 EvaluateAcceleration(int splineIndex, float t);
            /*0x3910ae8*/ Unity.Mathematics.float3 EvaluateAcceleration<T>(T spline, float t);
            /*0x7d23f2c*/ float CalculateLength();
            /*0x7d23f34*/ float CalculateLength(int splineIndex);
            /*0x7d24008*/ void OnBeforeSerialize();
            /*0x7d2400c*/ void OnAfterDeserialize();
            /*0x3910ae8*/ UnityEngine.Splines.NativeSpline GetOrBakeNativeSpline<T>(T spline);

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

                /*0x7d232fc*/ <>c__DisplayClass21_0();
                /*0x7d2448c*/ bool <set_Splines>b__0(UnityEngine.Splines.Spline spline);
            }
        }

        interface IInterpolator<T>
        {
            /*0x3910ae8*/ T Interpolate(T from, T to, float t);
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

            static /*0x383e7a0*/ SplineData();
            static int Wrap(int value, int lowerBound, int upperBound);
            /*0x38159dc*/ SplineData();
            /*0x3910ae8*/ UnityEngine.Splines.DataPoint<T> get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, UnityEngine.Splines.DataPoint<T> value);
            /*0x3910ae8*/ void set_DefaultValue(T value);
            /*0x3814574*/ int get_Count();
            /*0x38159dc*/ void SetDirty();
            /*0x3910ae8*/ int Add(UnityEngine.Splines.DataPoint<T> dataPoint);
            /*0x3815ed0*/ void RemoveAt(int index);
            /*0x38159dc*/ void Clear();
            /*0x3910ae8*/ int ResolveBinaryIndex(int index, bool wrap);
            /*0x3910ae8*/ System.ValueTuple<int, int, float> GetIndex(float t, float splineLength, int knotCount, bool closed);
            /*0x3910ae8*/ T Evaluate<TSpline, TInterpolator>(TSpline spline, float t, UnityEngine.Splines.PathIndexUnit indexUnit, TInterpolator interpolator);
            /*0x3910ae8*/ T Evaluate<TSpline, TInterpolator>(TSpline spline, float t, TInterpolator interpolator);
            /*0x3910ae8*/ void SetDataPoint(int index, UnityEngine.Splines.DataPoint<T> value);
            /*0x38159dc*/ void SortIfNecessary();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>> GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(UnityEngine.Splines.SplineModificationData data);

            class <GetEnumerator>d__46<T> : System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ UnityEngine.Splines.DataPoint<T> <>2__current;
                /*0x0*/ UnityEngine.Splines.SplineData<T> <>4__this;
                /*0x0*/ int <i>5__2;
                /*0x0*/ int <c>5__3;

                /*0x3815ed0*/ <GetEnumerator>d__46(int <>1__state);
                /*0x38159dc*/ void System.IDisposable.Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x3910ae8*/ UnityEngine.Splines.DataPoint<T> System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>.get_Current();
                /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class SplineDataKeyValuePair<T>
        {
            /*0x0*/ string Key;
            /*0x0*/ UnityEngine.Splines.SplineData<T> Value;

            /*0x38159dc*/ SplineDataKeyValuePair();
        }

        class SplineDataDictionary<T> : System.Collections.Generic.IEnumerable<UnityEngine.Splines.SplineDataKeyValuePair<T>>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Splines.SplineDataKeyValuePair<T>> m_Data;

            /*0x38159dc*/ SplineDataDictionary();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<T>> GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        struct SplineKnotIndex : System.IEquatable<UnityEngine.Splines.SplineKnotIndex>
        {
            static /*0x0*/ UnityEngine.Splines.SplineKnotIndex Invalid;
            /*0x10*/ int Spline;
            /*0x14*/ int Knot;

            static /*0x7d246b0*/ SplineKnotIndex();
            /*0x7d1d4f8*/ SplineKnotIndex(int spline, int knot);
            /*0x7d24544*/ bool Equals(UnityEngine.Splines.SplineKnotIndex otherIndex);
            /*0x7d2456c*/ bool Equals(object obj);
            /*0x7d24608*/ int GetHashCode();
            /*0x7d2461c*/ string ToString();
        }

        class SplineMath
        {
            static /*0x7d246fc*/ Unity.Mathematics.float3 PointLineNearestPoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, ref float lineParam);
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

            /*0x7d1f330*/ SplineModificationData(UnityEngine.Splines.Spline spline, UnityEngine.Splines.SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength);
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

            /*0x7d1f530*/ SplineRange(int start, int count);
            /*0x7d248a8*/ SplineRange(int start, int count, UnityEngine.Splines.SliceDirection direction);
            /*0x7d24854*/ int get_Start();
            /*0x7d2485c*/ int get_End();
            /*0x7d24898*/ int get_Count();
            /*0x7d248a0*/ UnityEngine.Splines.SliceDirection get_Direction();
            /*0x7d24880*/ int get_Item(int index);
            /*0x7d1f804*/ System.Collections.Generic.IEnumerator<int> GetEnumerator();
            /*0x7d248f4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7d248f8*/ string ToString();

            struct SplineRangeEnumerator : System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int m_Index;
                /*0x14*/ int m_Start;
                /*0x18*/ int m_End;
                /*0x1c*/ int m_Count;
                /*0x20*/ bool m_Reverse;

                /*0x7d248c0*/ SplineRangeEnumerator(UnityEngine.Splines.SplineRange range);
                /*0x7d249a8*/ bool MoveNext();
                /*0x7d249c8*/ void Reset();
                /*0x7d249d4*/ int get_Current();
                /*0x7d249f8*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d24a3c*/ void Dispose();
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
            static /*0x3910ae8*/ bool Evaluate<T>(T spline, float t, ref Unity.Mathematics.float3 position, ref Unity.Mathematics.float3 tangent, ref Unity.Mathematics.float3 upVector);
            static /*0x3910ae8*/ Unity.Mathematics.float3 EvaluatePosition<T>(T spline, float t);
            static /*0x3910ae8*/ Unity.Mathematics.float3 EvaluateTangent<T>(T spline, float t);
            static /*0x3910ae8*/ Unity.Mathematics.float3 EvaluateUpVector<T>(T spline, float t);
            static /*0x3910ae8*/ Unity.Mathematics.float3 CalculateUpVector<T>(T spline, int curveIndex, float curveT);
            static /*0x3910ae8*/ void EvaluateUpVectorsForCurve<T>(T spline, int curveIndex, Unity.Collections.NativeArray<Unity.Mathematics.float3> upVectors);
            static /*0x3910ae8*/ void EvaluateUpVectorsForCurve<T>(T spline, int curveIndex, Unity.Mathematics.float3[] upVectors);
            static /*0x3910ae8*/ Unity.Mathematics.float3 EvaluateAcceleration<T>(T spline, float t);
            static /*0x3910ae8*/ int SplineToCurveT<T>(T spline, float splineT, ref float curveT);
            static /*0x3910ae8*/ int SplineToCurveT<T>(T spline, float splineT, ref float curveT, bool useLUT);
            static /*0x3910ae8*/ float CurveToSplineT<T>(T spline, float curve);
            static /*0x3910ae8*/ float CalculateLength<T>(T spline, Unity.Mathematics.float4x4 transform);
            static /*0x7d24a40*/ int GetSubdivisionCount(float length, int resolution);
            static /*0x3910ae8*/ UnityEngine.Splines.SplineUtility.Segment GetNearestPoint<T>(T spline, Unity.Mathematics.float3 point, UnityEngine.Splines.SplineUtility.Segment range, ref float distance, ref Unity.Mathematics.float3 nearest, ref float time, int segments);
            static /*0x3910ae8*/ float GetNearestPoint<T>(T spline, Unity.Mathematics.float3 point, ref Unity.Mathematics.float3 nearest, ref float t, int resolution, int iterations);
            static /*0x3910ae8*/ float ConvertIndexUnit<T>(T spline, float value, UnityEngine.Splines.PathIndexUnit fromPathUnit, UnityEngine.Splines.PathIndexUnit targetPathUnit);
            static /*0x3910ae8*/ float ConvertNormalizedIndexUnit<T>(T spline, float t, UnityEngine.Splines.PathIndexUnit targetPathUnit);
            static /*0x7d24b00*/ float WrapInterpolation(float t, bool closed);
            static /*0x3910ae8*/ float GetNormalizedInterpolation<T>(T spline, float t, UnityEngine.Splines.PathIndexUnit originalPathUnit);
            static /*0x3910ae8*/ int PreviousIndex<T>(T spline, int index);
            static /*0x3910ae8*/ int NextIndex<T>(T spline, int index);
            static /*0x3910ae8*/ UnityEngine.Splines.BezierKnot Previous<T>(T spline, int index);
            static /*0x3910ae8*/ UnityEngine.Splines.BezierKnot Next<T>(T spline, int index);
            static /*0x7d24bc8*/ int PreviousIndex(int index, int count, bool wrap);
            static /*0x7d24be8*/ int NextIndex(int index, int count, bool wrap);
            static /*0x7d1cf0c*/ Unity.Mathematics.float3 GetExplicitLinearTangent(Unity.Mathematics.float3 point, Unity.Mathematics.float3 to);
            static /*0x7d1fbe0*/ Unity.Mathematics.float3 GetExplicitLinearTangent(UnityEngine.Splines.BezierKnot from, UnityEngine.Splines.BezierKnot to);
            static /*0x7d24c0c*/ Unity.Mathematics.float3 GetAutoSmoothTangent(Unity.Mathematics.float3 previous, Unity.Mathematics.float3 current, Unity.Mathematics.float3 next, float tension);
            static /*0x7d1fff0*/ UnityEngine.Splines.BezierKnot GetAutoSmoothKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 previous, Unity.Mathematics.float3 next, Unity.Mathematics.float3 normal, float tension);
            static /*0x7d1b04c*/ Unity.Mathematics.quaternion GetKnotRotation(Unity.Mathematics.float3 tangent, Unity.Mathematics.float3 normal);
            static /*0x3910ae8*/ bool IsIndexValid<T>(T container, UnityEngine.Splines.SplineKnotIndex index);
            static /*0x3910ae8*/ void SetLinkedKnotPosition<T>(T container, UnityEngine.Splines.SplineKnotIndex index);

            struct Segment
            {
                /*0x10*/ float start;
                /*0x14*/ float length;

                /*0x7d24f4c*/ Segment(float start, float length);
            }
        }
    }
}
