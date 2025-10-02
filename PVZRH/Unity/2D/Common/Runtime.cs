class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x10e8910*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    namespace U2D
    {
        namespace Common
        {
            namespace UTess
            {
                struct Array<T> : System.IDisposable
                {
                    /*0x0*/ Unity.Collections.NativeArray<T> m_Array;
                    /*0x0*/ int m_MaxSize;
                    /*0x0*/ Unity.Collections.Allocator m_AllocLabel;
                    /*0x0*/ Unity.Collections.NativeArrayOptions m_Options;

                    Array(int length, int maxSize, Unity.Collections.Allocator allocMode, Unity.Collections.NativeArrayOptions options);
                    /*0x17aa40*/ void ResizeIfRequired(int index);
                    /*0x2a5510*/ T get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, T value);
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x180980*/ int get_Length();
                    /*0x180980*/ int get_MaxSize();
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ void* get_UnsafePtr();
                    /*0x2a5510*/ void* get_UnsafeReadOnlyPtr();
                    /*0x17aec0*/ void CopyTo(T[] array);
                }

                class ArrayDebugView<T>
                {
                    /*0x0*/ UnityEngine.U2D.Common.UTess.Array<T> array;

                    /*0x2a5510*/ ArrayDebugView(UnityEngine.U2D.Common.UTess.Array<T> array);
                    /*0x1803b0*/ T[] get_Items();
                }

                struct ArraySlice<T> : System.IEquatable<UnityEngine.U2D.Common.UTess.ArraySlice<T>>
                {
                    /*0x0*/ byte* m_Buffer;
                    /*0x0*/ int m_Stride;
                    /*0x0*/ int m_Length;

                    static /*0x2a5510*/ bool op_Equality(UnityEngine.U2D.Common.UTess.ArraySlice<T> left, UnityEngine.U2D.Common.UTess.ArraySlice<T> right);
                    static /*0x2a5510*/ bool op_Inequality(UnityEngine.U2D.Common.UTess.ArraySlice<T> left, UnityEngine.U2D.Common.UTess.ArraySlice<T> right);
                    static /*0x2a5510*/ UnityEngine.U2D.Common.UTess.ArraySlice<T> ConvertExistingDataToArraySlice(void* dataPointer, int stride, int length);
                    /*0x2a5510*/ ArraySlice(Unity.Collections.NativeArray<T> array, int start, int length);
                    /*0x2a5510*/ ArraySlice(UnityEngine.U2D.Common.UTess.Array<T> array, int start, int length);
                    /*0x2a5510*/ bool Equals(UnityEngine.U2D.Common.UTess.ArraySlice<T> other);
                    /*0x17e620*/ bool Equals(object obj);
                    /*0x180980*/ int GetHashCode();
                    /*0x2a5510*/ T get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, T value);
                    /*0x2a5510*/ void* GetUnsafeReadOnlyPtr();
                    /*0x17aec0*/ void CopyTo(T[] array);
                    /*0x1803b0*/ T[] ToArray();
                    /*0x180980*/ int get_Stride();
                    /*0x180980*/ int get_Length();
                }

                class ArraySliceDebugView<T>
                {
                    /*0x0*/ UnityEngine.U2D.Common.UTess.ArraySlice<T> m_Slice;

                    /*0x2a5510*/ ArraySliceDebugView(UnityEngine.U2D.Common.UTess.ArraySlice<T> slice);
                    /*0x1803b0*/ T[] get_Items();
                }

                struct PlanarGraph
                {
                    static /*0x0*/ double kEpsilon;
                    static /*0x8*/ int kMaxIntersectionTolerance;

                    static /*0x10e2840*/ PlanarGraph();
                    static /*0x10e1890*/ void RemoveDuplicateEdges(ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> edges, ref int edgeCount, UnityEngine.U2D.Common.UTess.Array<int> duplicates, int duplicateCount);
                    static /*0x10e0b90*/ bool CheckCollinear(Unity.Mathematics.double2 a0, Unity.Mathematics.double2 a1, Unity.Mathematics.double2 b0, Unity.Mathematics.double2 b1);
                    static /*0x10e12a0*/ bool LineLineIntersection(Unity.Mathematics.double2 a0, Unity.Mathematics.double2 a1, Unity.Mathematics.double2 b0, Unity.Mathematics.double2 b1);
                    static /*0x10e10c0*/ bool LineLineIntersection(Unity.Mathematics.double2 p1, Unity.Mathematics.double2 p2, Unity.Mathematics.double2 p3, Unity.Mathematics.double2 p4, ref Unity.Mathematics.double2 result);
                    static /*0x10e04d0*/ bool CalculateEdgeIntersections(UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> edges, int edgeCount, UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> points, int pointCount, ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> results, ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> intersects, ref int resultCount);
                    static /*0x10e0940*/ bool CalculateTJunctions(UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> edges, int edgeCount, UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> points, int pointCount, UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> results, ref int resultCount);
                    static /*0x10e0d10*/ bool CutEdges(ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> points, ref int pointCount, ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> edges, ref int edgeCount, ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> tJunctions, ref int tJunctionCount, UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> intersections, UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> intersects, int intersectionCount);
                    static /*0x10e1b10*/ void RemoveDuplicatePoints(ref UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> points, ref int pointCount, ref UnityEngine.U2D.Common.UTess.Array<int> duplicates, ref int duplicateCount, Unity.Collections.Allocator allocator);
                    static /*0x10e2080*/ bool Validate(Unity.Collections.Allocator allocator, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> inputPoints, int pointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> inputEdges, int edgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outputPoints, ref int outputPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outputEdges, ref int outputEdgeCount);
                }

                struct Refinery
                {
                    static /*0x0*/ float kMinAreaFactor;
                    static /*0x4*/ float kMaxAreaFactor;
                    static /*0x8*/ int kMaxSteinerCount;

                    static /*0x10e3330*/ Refinery();
                    static /*0x10e3130*/ bool RequiresRefining(UnityEngine.U2D.Common.UTess.UTriangle tri, float maxArea);
                    static /*0x10e2e70*/ void FetchEncroachedSegments(Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.Common.UTess.UEncroachingSegment> encroach, ref int encroachCount, UnityEngine.U2D.Common.UTess.UCircle c);
                    static /*0x10e3110*/ void InsertVertex(ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, Unity.Mathematics.float2 newVertex, ref int nid);
                    static /*0x10e3140*/ void SplitSegments(ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, ref int pgEdgeCount, UnityEngine.U2D.Common.UTess.UEncroachingSegment es);
                    static /*0x10e28a0*/ bool Condition(Unity.Collections.Allocator allocator, float factorArea, float targetArea, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, ref int pgEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount, ref Unity.Collections.NativeArray<int> indices, ref int indexCount, ref float maxArea);
                }

                struct Smoothen
                {
                    static /*0x0*/ float kMaxAreaTolerance;
                    static /*0x4*/ float kMaxEdgeTolerance;

                    static /*0x10e44d0*/ Smoothen();
                    static /*0x10e4320*/ void RefineEdges(ref Unity.Collections.NativeArray<Unity.Mathematics.int4> refinedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int4> delaEdges, ref int delaEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int4> voronoiEdges);
                    static /*0x10e42b0*/ void GetAffectingEdges(int pointIndex, Unity.Collections.NativeArray<Unity.Mathematics.int4> edges, int edgeCount, ref Unity.Collections.NativeArray<int> resultSet, ref Unity.Collections.NativeArray<int> checkSet, ref int resultCount);
                    static /*0x10e33a0*/ void CentroidByPoints(int triIndex, Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UTriangle> triangles, ref Unity.Collections.NativeArray<int> centroidTris, ref int centroidCount, ref Unity.Mathematics.float2 aggregate, ref Unity.Mathematics.float2 point);
                    static /*0x10e3440*/ void CentroidByPolygon(Unity.Mathematics.int4 e, Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UTriangle> triangles, ref Unity.Mathematics.float2 centroid, ref float area, ref float distance);
                    static /*0x10e40b0*/ bool ConnectTriangles(ref Unity.Collections.NativeArray<Unity.Mathematics.int4> connectedTri, ref Unity.Collections.NativeArray<int> affectEdges, ref Unity.Collections.NativeArray<int> checkSet, Unity.Collections.NativeArray<Unity.Mathematics.int4> voronoiEdges, int triangleCount);
                    static /*0x10e3570*/ bool Condition(Unity.Collections.Allocator allocator, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount, ref Unity.Collections.NativeArray<int> indices, ref int indexCount);
                }

                struct Tessellator
                {
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_Edges;
                    /*0x20*/ Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UStar> m_Stars;
                    /*0x30*/ UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int3> m_Cells;
                    /*0x50*/ int m_CellCount;
                    /*0x58*/ Unity.Collections.NativeArray<int> m_ILArray;
                    /*0x68*/ Unity.Collections.NativeArray<int> m_IUArray;
                    /*0x78*/ Unity.Collections.NativeArray<int> m_SPArray;
                    /*0x88*/ int m_NumEdges;
                    /*0x8c*/ int m_NumHulls;
                    /*0x90*/ int m_NumPoints;
                    /*0x94*/ int m_StarCount;
                    /*0x98*/ Unity.Collections.NativeArray<int> m_Flags;
                    /*0xa8*/ Unity.Collections.NativeArray<int> m_Neighbors;
                    /*0xb8*/ Unity.Collections.NativeArray<int> m_Constraints;
                    /*0xc8*/ Unity.Collections.Allocator m_Allocator;

                    static /*0x10e6220*/ float FindSplit(UnityEngine.U2D.Common.UTess.UHull hull, UnityEngine.U2D.Common.UTess.UEvent edge);
                    static /*0x10e6910*/ void InsertHull(Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UHull> Hulls, int Pos, ref int Count, UnityEngine.U2D.Common.UTess.UHull Value);
                    static /*0x10e6000*/ void EraseHull(Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UHull> Hulls, int Pos, ref int Count);
                    static /*0x10e69d0*/ void InsertUniqueEdge(Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, Unity.Mathematics.int2 e, ref int edgeCount);
                    static /*0x10e7c20*/ bool Tessellate(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outputVertices, ref int vertexCount, ref Unity.Collections.NativeArray<int> outputIndices, ref int indexCount);
                    /*0xbf3110*/ void SetAllocator(Unity.Collections.Allocator allocator);
                    /*0x10e4a40*/ bool AddPoint(Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UHull> hulls, int hullCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Mathematics.float2 p, int idx);
                    /*0x10e7810*/ bool SplitHulls(Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UHull> hulls, ref int hullCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, UnityEngine.U2D.Common.UTess.UEvent evt);
                    /*0x10e6a60*/ bool MergeHulls(Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UHull> hulls, ref int hullCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, UnityEngine.U2D.Common.UTess.UEvent evt);
                    /*0x10e6dc0*/ void PrepareDelaunay(Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, int edgeCount);
                    /*0x10e6cf0*/ int OppositeOf(int a, int b);
                    /*0x10e6070*/ int FindConstraint(int a, int b);
                    /*0x10e4f20*/ void AddTriangle(int i, int j, int k);
                    /*0x10e7630*/ void RemovePair(int r, int j, int k);
                    /*0x10e7790*/ void RemoveTriangle(int i, int j, int k);
                    /*0x10e5ef0*/ void EdgeFlip(int i, int j);
                    /*0x10e64f0*/ bool Flip(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, ref UnityEngine.U2D.Common.UTess.Array<int> stack, ref int stackCount, int a, int b, int x);
                    /*0x10e6740*/ UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int3> GetCells(ref int count);
                    /*0x10e50f0*/ bool ApplyDelaunay(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges);
                    /*0x10e6120*/ int FindNeighbor(UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int3> cells, int count, int a, int b, int c);
                    /*0x10e5940*/ UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int3> Constrain(ref int count);
                    /*0x10e7340*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> RemoveExterior(ref int cellCount);
                    /*0x10e74b0*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> RemoveInterior(int cellCount);
                    /*0x10e7e70*/ bool Triangulate(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, int pointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, int edgeCount);
                    /*0x10e57d0*/ void Cleanup();

                    struct TestHullPointL : UnityEngine.U2D.Common.UTess.ICondition2<UnityEngine.U2D.Common.UTess.UHull, Unity.Mathematics.float2>
                    {
                        /*0x10e8730*/ bool Test(UnityEngine.U2D.Common.UTess.UHull h, Unity.Mathematics.float2 p, ref float t);
                    }

                    struct TestHullPointU : UnityEngine.U2D.Common.UTess.ICondition2<UnityEngine.U2D.Common.UTess.UHull, Unity.Mathematics.float2>
                    {
                        /*0x10e8820*/ bool Test(UnityEngine.U2D.Common.UTess.UHull h, Unity.Mathematics.float2 p, ref float t);
                    }

                    struct TestHullEventLe : UnityEngine.U2D.Common.UTess.ICondition2<UnityEngine.U2D.Common.UTess.UHull, UnityEngine.U2D.Common.UTess.UEvent>
                    {
                        /*0x10e86c0*/ bool Test(UnityEngine.U2D.Common.UTess.UHull h, UnityEngine.U2D.Common.UTess.UEvent p, ref float t);
                    }

                    struct TestHullEventE : UnityEngine.U2D.Common.UTess.ICondition2<UnityEngine.U2D.Common.UTess.UHull, UnityEngine.U2D.Common.UTess.UEvent>
                    {
                        /*0x10e8640*/ bool Test(UnityEngine.U2D.Common.UTess.UHull h, UnityEngine.U2D.Common.UTess.UEvent p, ref float t);
                    }

                    struct TestEdgePointE : UnityEngine.U2D.Common.UTess.ICondition2<Unity.Mathematics.int2, Unity.Mathematics.int2>
                    {
                        /*0x10e8600*/ bool Test(Unity.Mathematics.int2 h, Unity.Mathematics.int2 p, ref float t);
                    }

                    struct TestCellE : UnityEngine.U2D.Common.UTess.ICondition2<Unity.Mathematics.int3, Unity.Mathematics.int3>
                    {
                        /*0x10e8580*/ bool Test(Unity.Mathematics.int3 h, Unity.Mathematics.int3 p, ref float t);
                    }
                }

                enum UEventType
                {
                    EVENT_POINT = 0,
                    EVENT_END = 1,
                    EVENT_START = 2,
                }

                struct UEvent
                {
                    /*0x10*/ Unity.Mathematics.float2 a;
                    /*0x18*/ Unity.Mathematics.float2 b;
                    /*0x20*/ int idx;
                    /*0x24*/ int type;
                }

                struct UHull
                {
                    /*0x10*/ Unity.Mathematics.float2 a;
                    /*0x18*/ Unity.Mathematics.float2 b;
                    /*0x20*/ int idx;
                    /*0x28*/ UnityEngine.U2D.Common.UTess.ArraySlice<int> ilarray;
                    /*0x38*/ int ilcount;
                    /*0x40*/ UnityEngine.U2D.Common.UTess.ArraySlice<int> iuarray;
                    /*0x50*/ int iucount;
                }

                struct UStar
                {
                    /*0x10*/ UnityEngine.U2D.Common.UTess.ArraySlice<int> points;
                    /*0x20*/ int pointCount;
                }

                struct UBounds
                {
                    /*0x10*/ Unity.Mathematics.double2 min;
                    /*0x20*/ Unity.Mathematics.double2 max;
                }

                struct UCircle
                {
                    /*0x10*/ Unity.Mathematics.float2 center;
                    /*0x18*/ float radius;
                }

                struct UTriangle
                {
                    /*0x10*/ Unity.Mathematics.float2 va;
                    /*0x18*/ Unity.Mathematics.float2 vb;
                    /*0x20*/ Unity.Mathematics.float2 vc;
                    /*0x28*/ UnityEngine.U2D.Common.UTess.UCircle c;
                    /*0x34*/ float area;
                    /*0x38*/ Unity.Mathematics.int3 indices;
                }

                struct UEncroachingSegment
                {
                    /*0x10*/ Unity.Mathematics.float2 a;
                    /*0x18*/ Unity.Mathematics.float2 b;
                    /*0x20*/ int index;
                }

                interface ICondition<T, U>
                {
                    /*0x2a5510*/ bool Test(T x, U y, ref float t);
                }

                struct XCompare : System.Collections.Generic.IComparer<double>
                {
                    /*0x10e89f0*/ int Compare(double a, double b);
                }

                struct IntersectionCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int2>
                {
                    /*0x10*/ UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.double2> points;
                    /*0x30*/ UnityEngine.U2D.Common.UTess.Array<Unity.Mathematics.int2> edges;
                    /*0x50*/ UnityEngine.U2D.Common.UTess.IntersectionCompare.<xvasort> xvasort;
                    /*0x70*/ UnityEngine.U2D.Common.UTess.IntersectionCompare.<xvbsort> xvbsort;

                    /*0x10dc940*/ int Compare(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b);

                    struct <xvasort>e__FixedBuffer
                    {
                        /*0x10*/ double FixedElementField;
                    }

                    struct <xvbsort>e__FixedBuffer
                    {
                        /*0x10*/ double FixedElementField;
                    }
                }

                struct TessEventCompare : System.Collections.Generic.IComparer<UnityEngine.U2D.Common.UTess.UEvent>
                {
                    /*0x10e4560*/ int Compare(UnityEngine.U2D.Common.UTess.UEvent a, UnityEngine.U2D.Common.UTess.UEvent b);
                }

                struct TessEdgeCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int2>
                {
                    /*0x10e4540*/ int Compare(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b);
                }

                struct TessCellCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int3>
                {
                    /*0x10e4520*/ int Compare(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b);
                }

                struct TessJunctionCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int2>
                {
                    /*0x10e4540*/ int Compare(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b);
                }

                struct DelaEdgeCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int4>
                {
                    /*0x10dc910*/ int Compare(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b);
                }

                struct TessLink
                {
                    /*0x10*/ Unity.Collections.NativeArray<int> roots;
                    /*0x20*/ Unity.Collections.NativeArray<int> ranks;

                    static /*0x10e4790*/ UnityEngine.U2D.Common.UTess.TessLink CreateLink(int count, Unity.Collections.Allocator allocator);
                    static /*0x10e4870*/ void DestroyLink(UnityEngine.U2D.Common.UTess.TessLink link);
                    /*0x10e48c0*/ int Find(int x);
                    /*0x10e4920*/ void Link(int x, int y);
                }

                struct ModuleHandle
                {
                    static /*0x0*/ int kMaxArea;
                    static /*0x4*/ int kMaxEdgeCount;
                    static /*0x8*/ int kMaxIndexCount;
                    static /*0xc*/ int kMaxVertexCount;
                    static /*0x10*/ int kMaxTriangleCount;
                    static /*0x14*/ int kMaxRefineIterations;
                    static /*0x18*/ int kMaxSmoothenIterations;
                    static /*0x1c*/ float kIncrementAreaFactor;

                    static /*0x10e03f0*/ ModuleHandle();
                    static /*0x2a5510*/ void Copy<T>(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
                    static /*0x2a5510*/ void Copy<T>(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
                    static /*0x2a5510*/ void InsertionSort<T, U>(void* array, int lo, int hi, U comp);
                    static /*0x2a5510*/ int GetLower<T, U, X>(Unity.Collections.NativeArray<T> values, int count, U check, X condition);
                    static /*0x2a5510*/ int GetUpper<T, U, X>(Unity.Collections.NativeArray<T> values, int count, U check, X condition);
                    static /*0x2a5510*/ int GetEqual<T, U, X>(UnityEngine.U2D.Common.UTess.Array<T> values, int count, U check, X condition);
                    static /*0x2a5510*/ int GetEqual<T, U, X>(Unity.Collections.NativeArray<T> values, int count, U check, X condition);
                    static /*0x10deb20*/ float OrientFast(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c);
                    static /*0x10deac0*/ double OrientFastDouble(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b, Unity.Mathematics.double2 c);
                    static /*0x10ddb40*/ UnityEngine.U2D.Common.UTess.UCircle CircumCircle(UnityEngine.U2D.Common.UTess.UTriangle tri);
                    static /*0x10de770*/ bool IsInsideCircle(UnityEngine.U2D.Common.UTess.UCircle c, Unity.Mathematics.float2 v);
                    static /*0x10e0280*/ float TriangleArea(Unity.Mathematics.float2 va, Unity.Mathematics.float2 vb, Unity.Mathematics.float2 vc);
                    static /*0x10dec40*/ float Sign(Unity.Mathematics.float2 p1, Unity.Mathematics.float2 p2, Unity.Mathematics.float2 p3);
                    static /*0x10de970*/ bool IsInsideTriangle(Unity.Mathematics.float2 pt, Unity.Mathematics.float2 v1, Unity.Mathematics.float2 v2, Unity.Mathematics.float2 v3);
                    static /*0x10de7c0*/ bool IsInsideTriangleApproximate(Unity.Mathematics.float2 pt, Unity.Mathematics.float2 v1, Unity.Mathematics.float2 v2, Unity.Mathematics.float2 v3);
                    static /*0x10de540*/ bool IsInsideCircle(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c, Unity.Mathematics.float2 p);
                    static /*0x10dd360*/ void BuildTriangles(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea);
                    static /*0x10dd020*/ void BuildTriangles(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.Common.UTess.UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea);
                    static /*0x10dd6a0*/ void BuildTriangles(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge);
                    static /*0x10dcc20*/ void BuildTrianglesAndEdges(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref Unity.Collections.NativeArray<UnityEngine.U2D.Common.UTess.UTriangle> triangles, ref int triangleCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int4> delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea);
                    static /*0x10de0a0*/ void CopyGraph(Unity.Collections.NativeArray<Unity.Mathematics.float2> srcPoints, int srcPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> dstPoints, ref int dstPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> srcEdges, int srcEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> dstEdges, ref int dstEdgeCount);
                    static /*0x10ddfa0*/ void CopyGeometry(Unity.Collections.NativeArray<int> srcIndices, int srcIndexCount, ref Unity.Collections.NativeArray<int> dstIndices, ref int dstIndexCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> srcVertices, int srcVertexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> dstVertices, ref int dstVertexCount);
                    static /*0x10e0110*/ void TransferOutput(Unity.Collections.NativeArray<Unity.Mathematics.int2> srcEdges, int srcEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> dstEdges, ref int dstEdgeCount, Unity.Collections.NativeArray<int> srcIndices, int srcIndexCount, ref Unity.Collections.NativeArray<int> dstIndices, ref int dstIndexCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> srcVertices, int srcVertexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> dstVertices, ref int dstVertexCount);
                    static /*0x10de1b0*/ void GraphConditioner(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, ref int pgEdgeCount, bool resetTopology);
                    static /*0x10deba0*/ void Reorder(int startVertexCount, int index, ref Unity.Collections.NativeArray<int> indices, ref int indexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount);
                    static /*0x10e02e0*/ void VertexCleanupConditioner(int startVertexCount, ref Unity.Collections.NativeArray<int> indices, ref int indexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount);
                    static /*0x10ddd20*/ Unity.Mathematics.float4 ConvexQuad(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outVertices, ref int outVertexCount, ref Unity.Collections.NativeArray<int> outIndices, ref int outIndexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outEdges, ref int outEdgeCount);
                    static /*0x10dfbc0*/ Unity.Mathematics.float4 Tessellate(Unity.Collections.Allocator allocator, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> points, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outVertices, ref int outVertexCount, ref Unity.Collections.NativeArray<int> outIndices, ref int outIndexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outEdges, ref int outEdgeCount, bool runPlanarGraph);
                    static /*0x10deca0*/ Unity.Mathematics.float4 Subdivide(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outVertices, ref int outVertexCount, ref Unity.Collections.NativeArray<int> outIndices, ref int outIndexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 5B90B9C49B9AA3A8A7FD22D3ABE85E44D5F9D1902DFCBCF85E3CA1B06DEBA4CD;
    static /*0x58e*/ <PrivateImplementationDetails> DFFA79D36DA983EC5128DCFAF5029D38C713A44345A4EEAA3880F56ACAC63AD9;

    struct __StaticArrayInitTypeSize=583
    {
    }

    struct __StaticArrayInitTypeSize=1422
    {
    }
}
