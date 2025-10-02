class <Module>
{
}

struct SpriteShapeGeometryInfo
{
    /*0x10*/ int geomIndex;
    /*0x14*/ int indexCount;
    /*0x18*/ int vertexCount;
    /*0x1c*/ int spriteIndex;
}

class SpriteShapeGeometryCache : UnityEngine.MonoBehaviour
{
    /*0x20*/ int m_MaxArrayCount;
    /*0x28*/ UnityEngine.Vector3[] m_PosArray;
    /*0x30*/ UnityEngine.Vector2[] m_Uv0Array;
    /*0x38*/ UnityEngine.Vector4[] m_TanArray;
    /*0x40*/ ushort[] m_IndexArray;
    /*0x48*/ SpriteShapeGeometryInfo[] m_GeomArray;
    /*0x50*/ bool m_RequiresUpdate;
    /*0x51*/ bool m_RequiresUpload;
    /*0x58*/ Unity.Collections.NativeSlice<UnityEngine.Vector3> m_PosArrayCache;
    /*0x68*/ Unity.Collections.NativeSlice<UnityEngine.Vector2> m_Uv0ArrayCache;
    /*0x78*/ Unity.Collections.NativeSlice<UnityEngine.Vector4> m_TanArrayCache;
    /*0x88*/ Unity.Collections.NativeArray<ushort> m_IndexArrayCache;
    /*0x98*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> m_GeomArrayCache;

    /*0x31c640*/ SpriteShapeGeometryCache();
    /*0xb61870*/ ushort[] get_indexArray();
    /*0x79a150*/ UnityEngine.Vector3[] get_posArray();
    /*0x995140*/ UnityEngine.Vector4[] get_tanArray();
    /*0x3e3af0*/ int get_maxArrayCount();
    /*0x9ef740*/ bool get_requiresUpdate();
    /*0xe86030*/ bool get_requiresUpload();
    /*0x1101d80*/ void OnEnable();
    /*0x1101d90*/ void SetGeometryCache(int _maxArrayCount, Unity.Collections.NativeSlice<UnityEngine.Vector3> _posArray, Unity.Collections.NativeSlice<UnityEngine.Vector2> _uv0Array, Unity.Collections.NativeSlice<UnityEngine.Vector4> _tanArray, Unity.Collections.NativeArray<ushort> _indexArray, Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> _geomArray);
    /*0x1101de0*/ void UpdateGeometryCache();
    /*0x1102170*/ Unity.Jobs.JobHandle Upload(UnityEngine.U2D.SpriteShapeRenderer sr, UnityEngine.U2D.SpriteShapeController sc);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x1109e40*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
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

namespace Unity
{
    namespace SpriteShape
    {
        namespace External
        {
            namespace LibTessDotNet
            {
                class Dict<TValue>
                {
                    /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.LessOrEqual<TValue> _leq;
                    /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> _head;

                    /*0x17aec0*/ Dict(Unity.SpriteShape.External.LibTessDotNet.Dict.LessOrEqual<TValue> leq);
                    /*0x2a5510*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> Insert(TValue key);
                    /*0x2a5510*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> InsertBefore(Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> node, TValue key);
                    /*0x2a5510*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> Find(TValue key);
                    /*0x1803b0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> Min();
                    /*0x17aec0*/ void Remove(Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> node);

                    class Node<TValue>
                    {
                        /*0x0*/ TValue _key;
                        /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> _prev;
                        /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> _next;

                        /*0x180fc0*/ Node();
                        /*0x2a5510*/ TValue get_Key();
                        /*0x1803b0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> get_Prev();
                        /*0x1803b0*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<TValue> get_Next();
                    }

                    class LessOrEqual<TValue> : System.MulticastDelegate
                    {
                        LessOrEqual(object object, nint method);
                        /*0x2a5510*/ bool Invoke(TValue lhs, TValue rhs);
                        /*0x2a5510*/ System.IAsyncResult BeginInvoke(TValue lhs, TValue rhs, System.AsyncCallback callback, object object);
                        /*0x17e620*/ bool EndInvoke(System.IAsyncResult result);
                    }
                }

                class Geom
                {
                    static /*0x10ec950*/ bool IsWindingInside(Unity.SpriteShape.External.LibTessDotNet.WindingRule rule, int n);
                    static /*0x10ecb70*/ bool VertCCW(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex u, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ecbd0*/ bool VertEq(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex lhs, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x10eccb0*/ bool VertLeq(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex lhs, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x10ebe20*/ float EdgeEval(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex u, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ec880*/ float EdgeSign(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex u, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ecab0*/ bool TransLeq(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex lhs, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x10eca00*/ float TransEval(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex u, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ecb00*/ float TransSign(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex u, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ebed0*/ bool EdgeGoesLeft(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge e);
                    static /*0x10ebf40*/ bool EdgeGoesRight(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge e);
                    static /*0x10ecc10*/ float VertL1dist(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex u, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v);
                    static /*0x10ebde0*/ void AddWinding(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eDst, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eSrc);
                    static /*0x10ec8f0*/ float Interpolate(float a, float x, float b, float y);
                    static /*0x62e230*/ void Swap(ref Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex a, ref Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex b);
                    static /*0x10ebfb0*/ void EdgeIntersect(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex o1, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex d1, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex o2, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex d2, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex v);
                }

                class Mesh : Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Pooled<Unity.SpriteShape.External.LibTessDotNet.Mesh>
                {
                    /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex _vHead;
                    /*0x18*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face _fHead;
                    /*0x20*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _eHead;
                    /*0x28*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _eHeadSym;

                    /*0x10ee840*/ Mesh();
                    /*0x10edf90*/ void Reset();
                    /*0x10ede90*/ void OnFree();
                    /*0x10edb80*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge MakeEdge();
                    /*0x10edff0*/ void Splice(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eOrg, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eDst);
                    /*0x10ed900*/ void Delete(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eDel);
                    /*0x10ed4f0*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge AddEdgeVertex(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eOrg);
                    /*0x10ee160*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge SplitEdge(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eOrg);
                    /*0x10ed6e0*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge Connect(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eOrg, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eDst);
                    /*0x10ee450*/ void ZapFace(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face fZap);
                    /*0x10edbf0*/ void MergeConvexFaces(int maxVertsPerFace);
                    /*0x10ed630*/ void Check();
                }

                struct Vec3
                {
                    static /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 Zero;
                    /*0x10*/ float X;
                    /*0x14*/ float Y;
                    /*0x18*/ float Z;

                    static /*0x32d010*/ Vec3();
                    static /*0x110a120*/ void Sub(ref Unity.SpriteShape.External.LibTessDotNet.Vec3 lhs, ref Unity.SpriteShape.External.LibTessDotNet.Vec3 rhs, ref Unity.SpriteShape.External.LibTessDotNet.Vec3 result);
                    static /*0x110a030*/ void Neg(ref Unity.SpriteShape.External.LibTessDotNet.Vec3 v);
                    static /*0x1109f20*/ void Dot(ref Unity.SpriteShape.External.LibTessDotNet.Vec3 u, ref Unity.SpriteShape.External.LibTessDotNet.Vec3 v, ref float dot);
                    static /*0x110a060*/ void Normalize(ref Unity.SpriteShape.External.LibTessDotNet.Vec3 v);
                    static /*0x1109f50*/ int LongAxis(ref Unity.SpriteShape.External.LibTessDotNet.Vec3 v);
                    /*0x110a210*/ float get_Item(int index);
                    /*0x110a290*/ void set_Item(int index, float value);
                    /*0x110a150*/ string ToString();
                }

                class MeshUtils
                {
                    static int Undef = -1;

                    static /*0x10ecfd0*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge MakeEdge(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eNext);
                    static /*0x10ed450*/ void Splice(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge a, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge b);
                    static /*0x10ed360*/ void MakeVertex(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eOrig, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex vNext);
                    static /*0x10ed250*/ void MakeFace(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eOrig, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face fNext);
                    static /*0x10ecd70*/ void KillEdge(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eDel);
                    static /*0x10ecf10*/ void KillVertex(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex vDel, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex newOrg);
                    static /*0x10ece50*/ void KillFace(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face fDel, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face newLFace);
                    static /*0x10ecd00*/ float FaceArea(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face f);

                    class Pooled<T>
                    {
                        static /*0x0*/ System.Collections.Generic.Stack<T> _stack;

                        static /*0x2a5510*/ T Create();
                        /*0x180fc0*/ Pooled();
                        /*0x180fc0*/ void Reset();
                        /*0x180fc0*/ void OnFree();
                        /*0x180fc0*/ void Free();
                    }

                    class Vertex : Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Pooled<Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex>
                    {
                        /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex _prev;
                        /*0x18*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex _next;
                        /*0x20*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _anEdge;
                        /*0x28*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 _coords;
                        /*0x34*/ float _s;
                        /*0x38*/ float _t;
                        /*0x3c*/ Unity.SpriteShape.External.LibTessDotNet.PQHandle _pqHandle;
                        /*0x40*/ int _n;
                        /*0x48*/ object _data;

                        /*0x110a3c0*/ Vertex();
                        /*0x110a310*/ void Reset();
                    }

                    class Face : Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Pooled<Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face>
                    {
                        /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face _prev;
                        /*0x18*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face _next;
                        /*0x20*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _anEdge;
                        /*0x28*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face _trail;
                        /*0x30*/ int _n;
                        /*0x34*/ bool _marked;
                        /*0x35*/ bool _inside;

                        /*0x10ebd70*/ Face();
                        /*0x10ebdb0*/ int get_VertsCount();
                        /*0x10ebd10*/ void Reset();
                    }

                    struct EdgePair
                    {
                        /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _e;
                        /*0x18*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _eSym;

                        static /*0x10eb850*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.EdgePair Create();
                        /*0x10eb900*/ void Reset();
                    }

                    class Edge : Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Pooled<Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge>
                    {
                        /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.EdgePair _pair;
                        /*0x20*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _next;
                        /*0x28*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _Sym;
                        /*0x30*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _Onext;
                        /*0x38*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _Lnext;
                        /*0x40*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex _Org;
                        /*0x48*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face _Lface;
                        /*0x50*/ Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion _activeRegion;
                        /*0x58*/ int _winding;

                        static /*0x10eb940*/ void EnsureFirst(ref Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge e);
                        /*0x10eba30*/ Edge();
                        /*0x10ebb20*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face get__Rface();
                        /*0x10ebc80*/ void set__Rface(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face value);
                        /*0x10ebac0*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex get__Dst();
                        /*0x10ebbf0*/ void set__Dst(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex value);
                        /*0x10ebb00*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge get__Oprev();
                        /*0x10ebc50*/ void set__Oprev(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebae0*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge get__Lprev();
                        /*0x10ebc20*/ void set__Lprev(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebaa0*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge get__Dprev();
                        /*0x10ebbc0*/ void set__Dprev(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebb70*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge get__Rprev();
                        /*0x10ebce0*/ void set__Rprev(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10eba70*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge get__Dnext();
                        /*0x10ebb90*/ void set__Dnext(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebb40*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge get__Rnext();
                        /*0x10ebcb0*/ void set__Rnext(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10eb980*/ void Reset();
                    }
                }

                struct PQHandle
                {
                    static /*0x0*/ int Invalid;
                    /*0x10*/ int _handle;

                    static /*0x10eeb50*/ PQHandle();
                }

                class PriorityHeap<TValue>
                {
                    /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> _leq;
                    /*0x0*/ int[] _nodes;
                    /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.PriorityHeap.HandleElem<TValue> _handles;
                    /*0x0*/ int _size;
                    /*0x0*/ int _max;
                    /*0x0*/ int _freeList;
                    /*0x0*/ bool _initialized;

                    PriorityHeap(int initialSize, Unity.SpriteShape.External.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> leq);
                    /*0x17cb40*/ bool get_Empty();
                    /*0x17aa40*/ void FloatDown(int curr);
                    /*0x17aa40*/ void FloatUp(int curr);
                    /*0x180fc0*/ void Init();
                    /*0x2a5510*/ Unity.SpriteShape.External.LibTessDotNet.PQHandle Insert(TValue value);
                    /*0x2a5510*/ TValue ExtractMin();
                    /*0x2a5510*/ TValue Minimum();
                    /*0x2a5510*/ void Remove(Unity.SpriteShape.External.LibTessDotNet.PQHandle handle);

                    class LessOrEqual<TValue> : System.MulticastDelegate
                    {
                        LessOrEqual(object object, nint method);
                        /*0x2a5510*/ bool Invoke(TValue lhs, TValue rhs);
                        /*0x2a5510*/ System.IAsyncResult BeginInvoke(TValue lhs, TValue rhs, System.AsyncCallback callback, object object);
                        /*0x17e620*/ bool EndInvoke(System.IAsyncResult result);
                    }

                    class HandleElem<TValue>
                    {
                        /*0x0*/ TValue _key;
                        /*0x0*/ int _node;

                        /*0x180fc0*/ HandleElem();
                    }
                }

                class PriorityQueue<TValue>
                {
                    /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> _leq;
                    /*0x0*/ Unity.SpriteShape.External.LibTessDotNet.PriorityHeap<TValue> _heap;
                    /*0x0*/ TValue[] _keys;
                    /*0x0*/ int[] _order;
                    /*0x0*/ int _size;
                    /*0x0*/ int _max;
                    /*0x0*/ bool _initialized;

                    static /*0x177670*/ void Swap(ref int a, ref int b);
                    PriorityQueue(int initialSize, Unity.SpriteShape.External.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> leq);
                    /*0x17cb40*/ bool get_Empty();
                    /*0x180fc0*/ void Init();
                    /*0x2a5510*/ Unity.SpriteShape.External.LibTessDotNet.PQHandle Insert(TValue value);
                    /*0x2a5510*/ TValue ExtractMin();
                    /*0x2a5510*/ TValue Minimum();
                    /*0x2a5510*/ void Remove(Unity.SpriteShape.External.LibTessDotNet.PQHandle handle);

                    class StackItem<TValue>
                    {
                        /*0x0*/ int p;
                        /*0x0*/ int r;

                        /*0x180fc0*/ StackItem();
                    }
                }

                class Tess
                {
                    /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.Mesh _mesh;
                    /*0x18*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 _normal;
                    /*0x24*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 _sUnit;
                    /*0x30*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 _tUnit;
                    /*0x3c*/ float _bminX;
                    /*0x40*/ float _bminY;
                    /*0x44*/ float _bmaxX;
                    /*0x48*/ float _bmaxY;
                    /*0x4c*/ Unity.SpriteShape.External.LibTessDotNet.WindingRule _windingRule;
                    /*0x50*/ Unity.SpriteShape.External.LibTessDotNet.Dict<Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion> _dict;
                    /*0x58*/ Unity.SpriteShape.External.LibTessDotNet.PriorityQueue<Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex> _pq;
                    /*0x60*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex _event;
                    /*0x68*/ Unity.SpriteShape.External.LibTessDotNet.CombineCallback _combineCallback;
                    /*0x70*/ Unity.SpriteShape.External.LibTessDotNet.ContourVertex[] _vertices;
                    /*0x78*/ int _vertexCount;
                    /*0x80*/ int[] _elements;
                    /*0x88*/ int _elementCount;
                    /*0x8c*/ float SUnitX;
                    /*0x90*/ float SUnitY;
                    /*0x94*/ float SentinelCoord;
                    /*0x98*/ bool NoEmptyPolygons;
                    /*0x99*/ bool UsePooling;

                    /*0x1109cc0*/ Tess();
                    /*0x11088f0*/ Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion RegionBelow(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x11088c0*/ Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion RegionAbove(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1106c80*/ bool EdgeLeq(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg1, Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg2);
                    /*0x1106a80*/ void DeleteRegion(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1107290*/ void FixUpperEdge(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge newEdge);
                    /*0x1109550*/ Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion TopLeftRegion(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1109690*/ Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion TopRightRegion(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1102d00*/ Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion AddRegionBelow(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regAbove, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eNewUp);
                    /*0x1106090*/ void ComputeWinding(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x11071f0*/ void FinishRegion(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1107050*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge FinishLeftRegions(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regFirst, Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regLast);
                    /*0x1102df0*/ void AddRightEdges(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eFirst, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eLast, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eTopLeft, bool cleanUp);
                    /*0x1108ce0*/ void SpliceMergeVertices(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge e1, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge e2);
                    /*0x1109700*/ void VertexWeights(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex isect, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex org, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex dst, ref float w0, ref float w1);
                    /*0x1107300*/ void GetIntersectData(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex isect, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex orgUp, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex dstUp, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex orgLo, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex dstLo);
                    /*0x1103f70*/ bool CheckForRightSplice(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x1103cc0*/ bool CheckForLeftSplice(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x11032c0*/ bool CheckForIntersect(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x11098d0*/ void WalkDirtyRegions(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x1106760*/ void ConnectRightVertex(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge eBottomLeft);
                    /*0x11060f0*/ void ConnectLeftDegenerate(Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion regUp, Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x11062a0*/ void ConnectLeftVertex(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x1108d00*/ void SweepEvent(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x1103120*/ void AddSentinel(float smin, float smax, float t);
                    /*0x11076e0*/ void InitEdgeDict();
                    /*0x1106b70*/ void DoneEdgeDict();
                    /*0x1108920*/ void RemoveDegenerateEdges();
                    /*0x11077e0*/ void InitPriorityQ();
                    /*0x1106c60*/ void DonePriorityQ();
                    /*0x1108aa0*/ void RemoveDegenerateFaces();
                    /*0x11043b0*/ void ComputeInterior();
                    /*0xa3cae0*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 get_Normal();
                    /*0xdd5210*/ void set_Normal(Unity.SpriteShape.External.LibTessDotNet.Vec3 value);
                    /*0xd184b0*/ Unity.SpriteShape.External.LibTessDotNet.ContourVertex[] get_Vertices();
                    /*0x1101d10*/ int get_VertexCount();
                    /*0xeeac90*/ int[] get_Elements();
                    /*0x737a20*/ int get_ElementCount();
                    /*0x1105780*/ void ComputeNormal(ref Unity.SpriteShape.External.LibTessDotNet.Vec3 norm);
                    /*0x1104260*/ void CheckOrientation();
                    /*0x11081b0*/ void ProjectPolygon();
                    /*0x1108e90*/ void TessellateMonoRegion(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Face face);
                    /*0x1108e20*/ void TessellateInterior();
                    /*0x1106b00*/ void DiscardExterior();
                    /*0x1108b60*/ void SetWindingNumber(int value, bool keepOnlyBoundary);
                    /*0x11076a0*/ int GetNeighbourFace(Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge edge);
                    /*0x1107ca0*/ void OutputPolymesh(Unity.SpriteShape.External.LibTessDotNet.ElementType elementType, int polySize);
                    /*0x11079e0*/ void OutputContours();
                    /*0x1108c50*/ float SignedArea(Unity.SpriteShape.External.LibTessDotNet.ContourVertex[] vertices);
                    /*0x1102a90*/ void AddContour(Unity.SpriteShape.External.LibTessDotNet.ContourVertex[] vertices);
                    /*0x1102aa0*/ void AddContour(Unity.SpriteShape.External.LibTessDotNet.ContourVertex[] vertices, Unity.SpriteShape.External.LibTessDotNet.ContourOrientation forceOrientation);
                    /*0x1109530*/ void Tessellate(Unity.SpriteShape.External.LibTessDotNet.WindingRule windingRule, Unity.SpriteShape.External.LibTessDotNet.ElementType elementType, int polySize);
                    /*0x11092d0*/ void Tessellate(Unity.SpriteShape.External.LibTessDotNet.WindingRule windingRule, Unity.SpriteShape.External.LibTessDotNet.ElementType elementType, int polySize, Unity.SpriteShape.External.LibTessDotNet.CombineCallback combineCallback);

                    class ActiveRegion
                    {
                        /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.MeshUtils.Edge _eUp;
                        /*0x18*/ Unity.SpriteShape.External.LibTessDotNet.Dict.Node<Unity.SpriteShape.External.LibTessDotNet.Tess.ActiveRegion> _nodeUp;
                        /*0x20*/ int _windingNumber;
                        /*0x24*/ bool _inside;
                        /*0x25*/ bool _sentinel;
                        /*0x26*/ bool _dirty;
                        /*0x27*/ bool _fixUpperEdge;

                        /*0x32f970*/ ActiveRegion();
                    }
                }

                enum WindingRule
                {
                    EvenOdd = 0,
                    NonZero = 1,
                    Positive = 2,
                    Negative = 3,
                    AbsGeqTwo = 4,
                }

                enum ElementType
                {
                    Polygons = 0,
                    ConnectedPolygons = 1,
                    BoundaryContours = 2,
                }

                enum ContourOrientation
                {
                    Original = 0,
                    Clockwise = 1,
                    CounterClockwise = 2,
                }

                struct ContourVertex
                {
                    /*0x10*/ Unity.SpriteShape.External.LibTessDotNet.Vec3 Position;
                    /*0x20*/ object Data;

                    /*0x10eb430*/ string ToString();
                }

                class CombineCallback : System.MulticastDelegate
                {
                    /*0x10eb380*/ CombineCallback(object object, nint method);
                    /*0x10eb340*/ object Invoke(Unity.SpriteShape.External.LibTessDotNet.Vec3 position, object[] data, float[] weights);
                    /*0x10eb2b0*/ System.IAsyncResult BeginInvoke(Unity.SpriteShape.External.LibTessDotNet.Vec3 position, object[] data, float[] weights, System.AsyncCallback callback, object object);
                    /*0x723cb0*/ object EndInvoke(System.IAsyncResult result);
                }
            }
        }
    }
}

namespace UnityEngine
{
    namespace U2D
    {
        class BezierUtility
        {
            static /*0x0*/ UnityEngine.Vector3[] s_TempPoints;

            static /*0x10eb240*/ BezierUtility();
            static /*0x10e9620*/ UnityEngine.Vector3 BezierPoint(UnityEngine.Vector3 startRightTangent, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 endLeftTangent, float t);
            static /*0x10eaaf0*/ float GetSpritePixelWidth(UnityEngine.Sprite sprite);
            static /*0x10e91b0*/ float BezierLength(Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> shapePoints, int splineDetail, ref float smallestSegment);
            static /*0x10ea1d0*/ UnityEngine.Vector3 ClosestPointOnCurve(UnityEngine.Vector3 point, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 startTangent, UnityEngine.Vector3 endTangent, ref float t);
            static /*0x10e9780*/ UnityEngine.Vector3 ClosestPointOnCurveFast(UnityEngine.Vector3 point, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 startTangent, UnityEngine.Vector3 endTangent, ref float t);
            static /*0x10e9900*/ UnityEngine.Vector3 ClosestPointOnCurveIterative(UnityEngine.Vector3 point, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 startTangent, UnityEngine.Vector3 endTangent, float sqrError, ref float startT, ref float endT);
            static /*0x10eac00*/ void SplitBezier(float t, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 startRightTangent, UnityEngine.Vector3 endLeftTangent, ref UnityEngine.Vector3 leftStartPosition, ref UnityEngine.Vector3 leftEndPosition, ref UnityEngine.Vector3 leftStartTangent, ref UnityEngine.Vector3 leftEndTangent, ref UnityEngine.Vector3 rightStartPosition, ref UnityEngine.Vector3 rightEndPosition, ref UnityEngine.Vector3 rightStartTangent, ref UnityEngine.Vector3 rightEndTangent);
            static /*0x10ea8f0*/ UnityEngine.Vector3 ClosestPointToSegment(UnityEngine.Vector3 point, UnityEngine.Vector3 segmentStart, UnityEngine.Vector3 segmentEnd, ref float t);
            static /*0x10eaf00*/ float SqrDistanceToPolyLine(UnityEngine.Vector3 point, UnityEngine.Vector3[] points);
            static /*0x10eb050*/ float SqrDistanceToSegment(UnityEngine.Vector3 point, UnityEngine.Vector3 segmentStart, UnityEngine.Vector3 segmentEnd);
            static /*0x10eaa90*/ bool Colinear(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float error);
        }

        struct SplinePointMetaData
        {
            /*0x10*/ float height;
            /*0x14*/ uint spriteIndex;
            /*0x18*/ int cornerMode;
        }

        class Spline
        {
            static /*0x0*/ string KErrorMessage;
            static /*0x8*/ float KEpsilon;
            /*0x10*/ bool m_IsOpenEnded;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.SplineControlPoint> m_ControlPoints;

            static /*0x10f0300*/ Spline();
            /*0x10f0380*/ Spline();
            /*0x10f0400*/ bool get_isOpenEnded();
            /*0x793ec0*/ void set_isOpenEnded(bool value);
            /*0x10efaa0*/ bool IsPositionValid(int index, int next, UnityEngine.Vector3 point);
            /*0x10ef310*/ void Clear();
            /*0x10ef6c0*/ int GetPointCount();
            /*0x10ef940*/ void InsertPointAt(int index, UnityEngine.Vector3 point);
            /*0x10efd00*/ void RemovePointAt(int index);
            /*0x10ef700*/ UnityEngine.Vector3 GetPosition(int index);
            /*0x10effe0*/ void SetPosition(int index, UnityEngine.Vector3 point);
            /*0x10ef5c0*/ UnityEngine.Vector3 GetLeftTangent(int index);
            /*0x10eff00*/ void SetLeftTangent(int index, UnityEngine.Vector3 tangent);
            /*0x10ef780*/ UnityEngine.Vector3 GetRightTangent(int index);
            /*0x10f0120*/ void SetRightTangent(int index, UnityEngine.Vector3 tangent);
            /*0x10ef8e0*/ UnityEngine.U2D.ShapeTangentMode GetTangentMode(int index);
            /*0x10f0270*/ void SetTangentMode(int index, UnityEngine.U2D.ShapeTangentMode mode);
            /*0x10ef560*/ float GetHeight(int index);
            /*0x10efe90*/ void SetHeight(int index, float value);
            /*0x10ef880*/ int GetSpriteIndex(int index);
            /*0x10f0200*/ void SetSpriteIndex(int index, int value);
            /*0x10ef450*/ bool GetCorner(int index);
            /*0x10efe00*/ void SetCorner(int index, bool value);
            /*0x10efd70*/ void SetCornerMode(int index, UnityEngine.U2D.Corner value);
            /*0x10ef370*/ UnityEngine.U2D.Corner GetCornerMode(int index);
            /*0x10ef470*/ int GetHashCode();
        }

        class SplineUtility
        {
            static /*0x10ef190*/ float SlopeAngle(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
            static /*0x10eed70*/ void CalculateTangents(UnityEngine.Vector3 point, UnityEngine.Vector3 prevPoint, UnityEngine.Vector3 nextPoint, UnityEngine.Vector3 forward, float scale, ref UnityEngine.Vector3 rightTangent, ref UnityEngine.Vector3 leftTangent);
            static /*0x10ef150*/ int NextIndex(int index, int pointCount);
            static /*0x10ef170*/ int PreviousIndex(int index, int pointCount);
            static /*0x10ef130*/ int Mod(int x, int m);
            /*0x32f970*/ SplineUtility();
        }

        class SpriteShapeCopyUtility<T>
        {
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeSlice<T> dst, T[] src, int length);
            static /*0x2a5510*/ void Copy(T[] dst, Unity.Collections.NativeSlice<T> src, int length);
            /*0x180fc0*/ SpriteShapeCopyUtility();
        }

        enum ShapeTangentMode
        {
            Linear = 0,
            Continuous = 1,
            Broken = 2,
        }

        enum CornerType
        {
            OuterTopLeft = 0,
            OuterTopRight = 1,
            OuterBottomLeft = 2,
            OuterBottomRight = 3,
            InnerTopLeft = 4,
            InnerTopRight = 5,
            InnerBottomLeft = 6,
            InnerBottomRight = 7,
        }

        enum QualityDetail
        {
            High = 16,
            Mid = 8,
            Low = 4,
        }

        enum Corner
        {
            Disable = 0,
            Automatic = 1,
            Stretched = 2,
        }

        class SplineControlPoint
        {
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Vector3 leftTangent;
            /*0x28*/ UnityEngine.Vector3 rightTangent;
            /*0x34*/ UnityEngine.U2D.ShapeTangentMode mode;
            /*0x38*/ float height;
            /*0x3c*/ int spriteIndex;
            /*0x40*/ bool corner;
            /*0x44*/ UnityEngine.U2D.Corner m_CornerMode;

            /*0x10eed40*/ SplineControlPoint();
            /*0x10eed50*/ UnityEngine.U2D.Corner get_cornerMode();
            /*0x10eed60*/ void set_cornerMode(UnityEngine.U2D.Corner value);
            /*0x10eeb90*/ int GetHashCode();
        }

        class AngleRange : System.ICloneable
        {
            /*0x10*/ float m_Start;
            /*0x14*/ float m_End;
            /*0x18*/ int m_Order;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Sprite> m_Sprites;

            /*0x10e9110*/ AngleRange();
            /*0x8c2b50*/ float get_start();
            /*0x10e91a0*/ void set_start(float value);
            /*0x8c1b90*/ float get_end();
            /*0x10e9190*/ void set_end(float value);
            /*0x8a5c20*/ int get_order();
            /*0x8a5c50*/ void set_order(int value);
            /*0x61a260*/ System.Collections.Generic.List<UnityEngine.Sprite> get_sprites();
            /*0x7965a0*/ void set_sprites(System.Collections.Generic.List<UnityEngine.Sprite> value);
            /*0x10e8d20*/ object Clone();
            /*0x10e8e00*/ bool Equals(object obj);
            /*0x10e8fe0*/ int GetHashCode();
        }

        class CornerSprite : System.ICloneable
        {
            /*0x10*/ UnityEngine.U2D.CornerType m_CornerType;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Sprite> m_Sprites;

            /*0x32f970*/ CornerSprite();
            /*0x417e30*/ UnityEngine.U2D.CornerType get_cornerType();
            /*0xdcd9c0*/ void set_cornerType(UnityEngine.U2D.CornerType value);
            /*0x32f410*/ System.Collections.Generic.List<UnityEngine.Sprite> get_sprites();
            /*0x7963c0*/ void set_sprites(System.Collections.Generic.List<UnityEngine.Sprite> value);
            /*0x10eb4a0*/ object Clone();
            /*0x10eb580*/ bool Equals(object obj);
            /*0x10eb750*/ int GetHashCode();
        }

        class SpriteShape : UnityEngine.ScriptableObject
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.AngleRange> m_Angles;
            /*0x20*/ UnityEngine.Texture2D m_FillTexture;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.U2D.CornerSprite> m_CornerSprites;
            /*0x30*/ float m_FillOffset;
            /*0x34*/ bool m_UseSpriteBorders;

            static /*0x1102560*/ int GetSpriteShapeHashCode(UnityEngine.U2D.SpriteShape spriteShape);
            /*0x1102990*/ SpriteShape();
            /*0x32f410*/ System.Collections.Generic.List<UnityEngine.U2D.AngleRange> get_angleRanges();
            /*0x7963c0*/ void set_angleRanges(System.Collections.Generic.List<UnityEngine.U2D.AngleRange> value);
            /*0x61a260*/ UnityEngine.Texture2D get_fillTexture();
            /*0x7965a0*/ void set_fillTexture(UnityEngine.Texture2D value);
            /*0x79a150*/ System.Collections.Generic.List<UnityEngine.U2D.CornerSprite> get_cornerSprites();
            /*0x98b030*/ void set_cornerSprites(System.Collections.Generic.List<UnityEngine.U2D.CornerSprite> value);
            /*0x1101d20*/ float get_fillOffset();
            /*0x1102a70*/ void set_fillOffset(float value);
            /*0x1102a60*/ bool get_useSpriteBorders();
            /*0x1102a80*/ void set_useSpriteBorders(bool value);
            /*0x1102490*/ UnityEngine.U2D.CornerSprite GetCornerSprite(UnityEngine.U2D.CornerType cornerType);
            /*0x1102710*/ void ResetCornerList();
            /*0x11026c0*/ void OnValidate();
            /*0x1102920*/ void Reset();
        }

        class SpriteShapeController : UnityEngine.MonoBehaviour
        {
            static float s_DistanceTolerance = 0.0010000000474974513;
            static /*0x0*/ Unity.Profiling.ProfilerMarker generateGeometry;
            static /*0x8*/ Unity.Profiling.ProfilerMarker generateCollider;
            /*0x20*/ UnityEngine.U2D.SpriteShape m_ActiveSpriteShape;
            /*0x28*/ UnityEngine.EdgeCollider2D m_EdgeCollider2D;
            /*0x30*/ UnityEngine.PolygonCollider2D m_PolygonCollider2D;
            /*0x38*/ UnityEngine.U2D.SpriteShapeRenderer m_SpriteShapeRenderer;
            /*0x40*/ SpriteShapeGeometryCache m_SpriteShapeGeometryCache;
            /*0x48*/ UnityEngine.Sprite[] m_SpriteArray;
            /*0x50*/ UnityEngine.Sprite[] m_EdgeSpriteArray;
            /*0x58*/ UnityEngine.Sprite[] m_CornerSpriteArray;
            /*0x60*/ UnityEngine.U2D.AngleRangeInfo[] m_AngleRangeInfoArray;
            /*0x68*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> m_ColliderData;
            /*0x78*/ Unity.Collections.NativeArray<UnityEngine.Vector4> m_TangentData;
            /*0x88*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGeneratorStats> m_Statistics;
            /*0x98*/ bool m_DynamicOcclusionLocal;
            /*0x99*/ bool m_DynamicOcclusionOverriden;
            /*0x9a*/ bool m_ForceColliderShapeUpdate;
            /*0x9c*/ int m_ActiveSplineHash;
            /*0xa0*/ int m_ActiveSpriteShapeHash;
            /*0xa4*/ int m_MaxArrayCount;
            /*0xa8*/ Unity.Jobs.JobHandle m_JobHandle;
            /*0xb8*/ UnityEngine.U2D.SpriteShapeParameters m_ActiveShapeParameters;
            /*0x120*/ UnityEngine.U2D.Spline m_Spline;
            /*0x128*/ UnityEngine.U2D.SpriteShape m_SpriteShape;
            /*0x130*/ float m_FillPixelPerUnit;
            /*0x134*/ float m_StretchTiling;
            /*0x138*/ int m_SplineDetail;
            /*0x13c*/ bool m_AdaptiveUV;
            /*0x13d*/ bool m_StretchUV;
            /*0x13e*/ bool m_WorldSpaceUV;
            /*0x140*/ float m_CornerAngleThreshold;
            /*0x144*/ int m_ColliderDetail;
            /*0x148*/ float m_ColliderOffset;
            /*0x14c*/ bool m_UpdateCollider;
            /*0x14d*/ bool m_EnableTangents;
            /*0x14e*/ bool m_GeometryCached;
            /*0x14f*/ bool m_UTess2D;
            /*0x150*/ UnityEngine.U2D.SpriteShapeGeometryCreator m_Creator;
            /*0x158*/ System.Collections.Generic.List<UnityEngine.U2D.SpriteShapeGeometryModifier> m_Modifiers;
            /*0x160*/ System.Collections.Generic.List<UnityEngine.Vector2> m_ColliderSegment;

            static /*0x10f44a0*/ SpriteShapeController();
            static /*0x10f2e10*/ void SmartDestroy(UnityEngine.Object o);
            /*0x10f4540*/ SpriteShapeController();
            /*0xb69a70*/ int get_maxArrayCount();
            /*0xb69b20*/ void set_maxArrayCount(int value);
            /*0x10f48d0*/ bool get_geometryCached();
            /*0x10f4f70*/ void set_geometryCached(bool value);
            /*0x10f4ab0*/ int get_splineHashCode();
            /*0x4e40d0*/ UnityEngine.Sprite[] get_spriteArray();
            /*0x10f4d60*/ UnityEngine.U2D.SpriteShapeParameters get_spriteShapeParameters();
            /*0x10f4c30*/ SpriteShapeGeometryCache get_spriteShapeGeometryCache();
            /*0xb61940*/ UnityEngine.Sprite[] get_cornerSpriteArray();
            /*0x4e40e0*/ UnityEngine.Sprite[] get_edgeSpriteArray();
            /*0xe643b0*/ UnityEngine.U2D.AngleRangeInfo[] get_angleRangeInfoArray();
            /*0x10f4ad0*/ UnityEngine.U2D.SpriteShapeGeometryCreator get_spriteShapeCreator();
            /*0x10f4f90*/ void set_spriteShapeCreator(UnityEngine.U2D.SpriteShapeGeometryCreator value);
            /*0x10f4990*/ System.Collections.Generic.List<UnityEngine.U2D.SpriteShapeGeometryModifier> get_modifiers();
            /*0xbf2c90*/ int get_spriteShapeHashCode();
            /*0x10f4f00*/ bool get_worldSpaceUVs();
            /*0x10f5040*/ void set_worldSpaceUVs(bool value);
            /*0x10f48b0*/ float get_fillPixelsPerUnit();
            /*0x10f4f60*/ void set_fillPixelsPerUnit(float value);
            /*0x10f48a0*/ bool get_enableTangents();
            /*0x10f4f50*/ void set_enableTangents(bool value);
            /*0x10f4ef0*/ float get_stretchTiling();
            /*0x10f5030*/ void set_stretchTiling(float value);
            /*0x10f4aa0*/ int get_splineDetail();
            /*0x10f4f80*/ void set_splineDetail(int value);
            /*0x10f4770*/ int get_colliderDetail();
            /*0x10f4f20*/ void set_colliderDetail(int value);
            /*0x10f4780*/ float get_colliderOffset();
            /*0x10f4f30*/ void set_colliderOffset(float value);
            /*0x10f4790*/ float get_cornerAngleThreshold();
            /*0x10f4f40*/ void set_cornerAngleThreshold(float value);
            /*0x10f4760*/ bool get_autoUpdateCollider();
            /*0x10f4f10*/ void set_autoUpdateCollider(bool value);
            /*0x3ce290*/ bool get_optimizeCollider();
            /*0x3ce290*/ bool get_optimizeGeometry();
            /*0x10f48e0*/ bool get_hasCollider();
            /*0x10f4ac0*/ UnityEngine.U2D.Spline get_spline();
            /*0x10d2010*/ UnityEngine.U2D.SpriteShape get_spriteShape();
            /*0x10f5010*/ void set_spriteShape(UnityEngine.U2D.SpriteShape value);
            /*0x10f47a0*/ UnityEngine.EdgeCollider2D get_edgeCollider();
            /*0x10f49a0*/ UnityEngine.PolygonCollider2D get_polygonCollider();
            /*0x10f4dc0*/ UnityEngine.U2D.SpriteShapeRenderer get_spriteShapeRenderer();
            /*0x10f48c0*/ bool get_forceColliderShapeUpdate();
            /*0x10f4e50*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGeneratorStats> get_stats();
            /*0x10f0d90*/ void DisposeInternal();
            /*0x10f2170*/ void OnApplicationQuit();
            /*0x10f2230*/ void OnEnable();
            /*0x10f2180*/ void OnDisable();
            /*0x32d010*/ void OnDestroy();
            /*0x10f22d0*/ void Reset();
            /*0x10f1b90*/ UnityEngine.Bounds InitBounds();
            /*0x10f22c0*/ void RefreshSpriteShape();
            /*0x10f3e90*/ bool ValidateSpline();
            /*0x10f4200*/ bool ValidateSpriteShapeTexture();
            /*0x10f43e0*/ bool ValidateUTess2D();
            /*0x10f18c0*/ bool HasSpriteShapeChanged();
            /*0x10f1960*/ bool HasSpriteShapeDataChanged();
            /*0x10f0fc0*/ int GetCustomScriptHashCode();
            /*0x10f16e0*/ bool HasSplineDataChanged();
            /*0x10f2160*/ void LateUpdate();
            /*0x10f22a0*/ void OnWillRenderObject();
            /*0x10f0ac0*/ Unity.Jobs.JobHandle BakeMesh();
            /*0x10f2e90*/ void UpdateGeometryCache();
            /*0x10f39e0*/ bool UpdateSpriteShapeParameters();
            /*0x10f2f30*/ void UpdateSpriteData();
            /*0x10f1170*/ Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> GetShapeControlPoints();
            /*0x10f1510*/ Unity.Collections.NativeArray<UnityEngine.U2D.SplinePointMetaData> GetSplinePointMetaData();
            /*0x10f0bd0*/ int CalculateMaxArrayCount(Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> shapePoints);
            /*0x10f2650*/ Unity.Jobs.JobHandle ScheduleBake();
            /*0x10f0450*/ void BakeCollider();
            /*0x10f0910*/ void BakeMeshForced();
            /*0x10f0e60*/ void ForceColliderShapeUpdate(bool forceUpdate);
            /*0x10f0e70*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> GetColliderShapeData();

            class <>c
            {
                static /*0x0*/ UnityEngine.U2D.SpriteShapeController.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.U2D.AngleRange> <>9__137_0;

                static /*0x1109dd0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1109d90*/ int <UpdateSpriteData>b__137_0(UnityEngine.U2D.AngleRange a, UnityEngine.U2D.AngleRange b);
            }
        }

        class SpriteShapeDefaultCreator : UnityEngine.U2D.SpriteShapeGeometryCreator
        {
            static /*0x0*/ UnityEngine.U2D.SpriteShapeDefaultCreator creator;

            static /*0x10f55b0*/ UnityEngine.U2D.SpriteShapeDefaultCreator get_defaultInstance();
            /*0x4239f0*/ SpriteShapeDefaultCreator();
            /*0x10f5070*/ int GetVertexArrayCount(UnityEngine.U2D.SpriteShapeController sc);
            /*0x10f5100*/ Unity.Jobs.JobHandle MakeCreatorJob(UnityEngine.U2D.SpriteShapeController sc, Unity.Collections.NativeArray<ushort> indices, Unity.Collections.NativeSlice<UnityEngine.Vector3> positions, Unity.Collections.NativeSlice<UnityEngine.Vector2> texCoords, Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> segments, Unity.Collections.NativeArray<Unity.Mathematics.float2> colliderData);
            /*0x10f5050*/ int GetVersion();
        }

        enum SpriteShapeGeneratorResult
        {
            ErrorDefaultQuadCreated = -5,
            ErrorNativeDataOverflow = -4,
            ErrorSpritesWrongBorder = -3,
            ErrorSpritesTightPacked = -2,
            ErrorVertexLimitReached = -1,
            Success = 0,
        }

        struct SpriteShapeGeneratorStats
        {
            /*0x10*/ UnityEngine.U2D.SpriteShapeGeneratorResult status;
        }

        struct SpriteShapeGenerator : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Profiling.ProfilerMarker generateGeometry;
            /*0x18*/ Unity.Profiling.ProfilerMarker generateCollider;
            /*0x20*/ UnityEngine.U2D.SpriteShapeGenerator.JobParameters m_ShapeParams;
            /*0x60*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo> m_SpriteInfos;
            /*0x70*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo> m_CornerSpriteInfos;
            /*0x80*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobAngleRange> m_AngleRanges;
            /*0x90*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo> m_Segments;
            /*0xa0*/ int m_SegmentCount;
            /*0xa8*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobContourPoint> m_ContourPoints;
            /*0xb8*/ int m_ContourPointCount;
            /*0xc0*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobCornerInfo> m_Corners;
            /*0xd0*/ int m_CornerCount;
            /*0xd8*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> m_TessPoints;
            /*0xe8*/ int m_TessPointCount;
            /*0xf0*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobControlPoint> m_ControlPoints;
            /*0x100*/ int m_ControlPointCount;
            /*0x108*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> m_CornerCoordinates;
            /*0x118*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobControlPoint> m_GeneratedControlPoints;
            /*0x128*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_SpriteIndices;
            /*0x138*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobIntersectPoint> m_Intersectors;
            /*0x148*/ int m_IndexArrayCount;
            /*0x150*/ Unity.Collections.NativeArray<ushort> m_IndexArray;
            /*0x160*/ int m_VertexArrayCount;
            /*0x168*/ Unity.Collections.NativeSlice<UnityEngine.Vector3> m_PosArray;
            /*0x178*/ Unity.Collections.NativeSlice<UnityEngine.Vector2> m_Uv0Array;
            /*0x188*/ Unity.Collections.NativeSlice<UnityEngine.Vector4> m_TanArray;
            /*0x198*/ int m_GeomArrayCount;
            /*0x1a0*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> m_GeomArray;
            /*0x1b0*/ int m_ColliderPointCount;
            /*0x1b8*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> m_ColliderPoints;
            /*0x1c8*/ Unity.Collections.NativeArray<UnityEngine.Bounds> m_Bounds;
            /*0x1d8*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGeneratorStats> m_Stats;
            /*0x1e8*/ int m_IndexDataCount;
            /*0x1ec*/ int m_VertexDataCount;
            /*0x1f0*/ int m_ColliderDataCount;
            /*0x1f4*/ int m_ActiveIndexCount;
            /*0x1f8*/ int m_ActiveVertexCount;
            /*0x1fc*/ Unity.Mathematics.float2 m_FirstLT;
            /*0x204*/ Unity.Mathematics.float2 m_FirstLB;
            /*0x20c*/ Unity.Mathematics.float4x4 m_Transform;
            /*0x24c*/ int kModeLinear;
            /*0x250*/ int kModeContinous;
            /*0x254*/ int kModeBroken;
            /*0x258*/ int kModeUTess;
            /*0x25c*/ int kCornerTypeOuterTopLeft;
            /*0x260*/ int kCornerTypeOuterTopRight;
            /*0x264*/ int kCornerTypeOuterBottomLeft;
            /*0x268*/ int kCornerTypeOuterBottomRight;
            /*0x26c*/ int kCornerTypeInnerTopLeft;
            /*0x270*/ int kCornerTypeInnerTopRight;
            /*0x274*/ int kCornerTypeInnerBottomLeft;
            /*0x278*/ int kCornerTypeInnerBottomRight;
            /*0x27c*/ int kControlPointCount;
            /*0x280*/ int kMaxArrayCount;
            /*0x284*/ float kEpsilon;
            /*0x288*/ float kEpsilonOrder;
            /*0x28c*/ float kEpsilonRelaxed;
            /*0x290*/ float kExtendSegment;
            /*0x294*/ float kRenderQuality;
            /*0x298*/ float kOptimizeRender;
            /*0x29c*/ float kColliderQuality;
            /*0x2a0*/ float kOptimizeCollider;
            /*0x2a4*/ float kLowestQualityTolerance;
            /*0x2a8*/ float kHighestQualityTolerance;

            static /*0x2a5510*/ void CopyToNativeArray<T>(Unity.Collections.NativeArray<T> from, int length, ref Unity.Collections.NativeArray<T> to);
            static /*0x2a5510*/ void SafeDispose<T>(Unity.Collections.NativeArray<T> na);
            static /*0x10fa6f0*/ bool IsPointOnLine(float epsilon, Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c);
            static /*0x10fa800*/ bool IsPointOnLines(float epsilon, Unity.Mathematics.float2 p1, Unity.Mathematics.float2 p2, Unity.Mathematics.float2 p3, Unity.Mathematics.float2 p4, Unity.Mathematics.float2 r);
            static /*0x10f6bf0*/ bool Colinear(Unity.Mathematics.float2 p, Unity.Mathematics.float2 q, Unity.Mathematics.float2 r);
            static /*0x10f7430*/ int Det(float epsilon, Unity.Mathematics.float2 p, Unity.Mathematics.float2 q, Unity.Mathematics.float2 r);
            static /*0x10fa880*/ bool LineIntersectionTest(float epsilon, Unity.Mathematics.float2 p1, Unity.Mathematics.float2 q1, Unity.Mathematics.float2 p2, Unity.Mathematics.float2 q2);
            static /*0x10faa00*/ bool LineIntersection(float epsilon, Unity.Mathematics.float2 p1, Unity.Mathematics.float2 p2, Unity.Mathematics.float2 p3, Unity.Mathematics.float2 p4, ref Unity.Mathematics.float2 result);
            static /*0x10f5750*/ float AngleBetweenVector(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b);
            static /*0x10f7fe0*/ bool GenerateColumnsBi(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 whsize, bool flip, ref Unity.Mathematics.float2 rt, ref Unity.Mathematics.float2 rb, float cph, float pivot);
            static /*0x10f81a0*/ bool GenerateColumnsTri(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c, Unity.Mathematics.float2 whsize, bool flip, ref Unity.Mathematics.float2 rt, ref Unity.Mathematics.float2 rb, float cph, float pivot);
            static /*0x10f61f0*/ Unity.Mathematics.float2 BezierPoint(Unity.Mathematics.float2 st, Unity.Mathematics.float2 sp, Unity.Mathematics.float2 ep, Unity.Mathematics.float2 et, float t);
            static /*0x10fc9d0*/ float SlopeAngle(Unity.Mathematics.float2 dirNormalized);
            static /*0x10fc950*/ float SlopeAngle(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end);
            static /*0x1101830*/ void UTessellator(ref UnityEngine.U2D.SpriteShapeSegment geom, int maxCount, Unity.Mathematics.float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Unity.Collections.Allocator label);
            static /*0x11014d0*/ void UTessellator$BurstManaged(ref UnityEngine.U2D.SpriteShapeSegment geom, int maxCount, Unity.Mathematics.float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Unity.Collections.Allocator label);
            /*0x10e8c10*/ int get_vertexDataCount();
            /*0x10e8c00*/ int get_vertexArrayCount();
            /*0x10e8bf0*/ int get_indexDataCount();
            /*0x104a520*/ int get_spriteCount();
            /*0x1101d30*/ int get_cornerSpriteCount();
            /*0x1101d10*/ int get_angleRangeCount();
            /*0x10e8be0*/ int get_controlPointCount();
            /*0xb69a60*/ int get_contourPointCount();
            /*0xa5b590*/ int get_segmentCount();
            /*0x1101d40*/ bool get_hasCollider();
            /*0x1101d20*/ float get_colliderPivot();
            /*0x995150*/ float get_borderPivot();
            /*0x3e3ad0*/ int get_splineDetail();
            /*0x1101d70*/ bool get_isCarpet();
            /*0x1101d60*/ bool get_isAdaptive();
            /*0x1101d50*/ bool get_hasSpriteBorder();
            /*0x10fa0f0*/ UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo GetSpriteInfo(int index);
            /*0x10f9590*/ UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo GetCornerSpriteInfo(int index);
            /*0x10f94f0*/ UnityEngine.U2D.SpriteShapeGenerator.JobAngleRange GetAngleRange(int index);
            /*0x10f9550*/ UnityEngine.U2D.SpriteShapeGenerator.JobControlPoint GetControlPoint(int index);
            /*0x10f9530*/ UnityEngine.U2D.SpriteShapeGenerator.JobContourPoint GetContourPoint(int index);
            /*0x10f9fa0*/ UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo GetSegmentInfo(int index);
            /*0x10f9520*/ int GetContourIndex(int index);
            /*0x10f95e0*/ int GetEndContourIndexOfSegment(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo isi);
            /*0x10fc7a0*/ void SetResult(UnityEngine.U2D.SpriteShapeGeneratorResult result);
            /*0x10f5820*/ void AppendCornerCoordinates(ref Unity.Collections.NativeArray<Unity.Mathematics.float2> corners, ref int cornerCount, Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c, Unity.Mathematics.float2 d);
            /*0x10fb5d0*/ void PrepareInput(UnityEngine.U2D.SpriteShapeParameters shapeParams, int maxArrayCount, Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> shapePoints, bool optimizeGeometry, bool updateCollider, bool optimizeCollider, float colliderOffset, float colliderDetail);
            /*0x1100a00*/ void TransferSprites(ref Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo> spriteInfos, UnityEngine.Sprite[] sprites, int maxCount);
            /*0x10fc0a0*/ void PrepareSprites(UnityEngine.Sprite[] edgeSprites, UnityEngine.Sprite[] cornerSprites);
            /*0x10fb0d0*/ void PrepareAngleRanges(UnityEngine.U2D.AngleRangeInfo[] angleRanges);
            /*0x10fb330*/ void PrepareControlPoints(Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> shapePoints, Unity.Collections.NativeArray<UnityEngine.U2D.SplinePointMetaData> metaData);
            /*0x1101c90*/ bool WithinRange(UnityEngine.U2D.SpriteShapeGenerator.JobAngleRange angleRange, float inputAngle);
            /*0x10f5800*/ bool AngleWithinRange(float t, float a, float b);
            /*0x10fc590*/ bool ResolveAngle(float angle, int activeIndex, ref float renderOrder, ref int spriteIndex, ref int firstSpriteIndex);
            /*0x10f9fd0*/ int GetSpriteIndex(int index, int previousIndex, ref int resolved);
            /*0x10f8ed0*/ void GenerateSegments();
            /*0x1101b90*/ void UpdateSegments();
            /*0x10f9e30*/ bool GetSegmentBoundaryColumn(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo segment, UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo sprInfo, Unity.Mathematics.float2 whsize, Unity.Mathematics.float2 startPos, Unity.Mathematics.float2 endPos, bool end, ref Unity.Mathematics.float2 top, ref Unity.Mathematics.float2 bottom);
            /*0x10f8b30*/ void GenerateControlPoints();
            /*0x10fc6b0*/ float SegmentDistance(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo isi);
            /*0x10f8400*/ void GenerateContour();
            /*0x10fb240*/ bool PrepareContour();
            /*0x10fdf20*/ bool TessellateContour(Unity.Collections.Allocator label);
            /*0x10fd3f0*/ void TessellateContourMainThread();
            /*0x10f62f0*/ void CalculateBoundingBox();
            /*0x10f66b0*/ void CalculateTexCoords();
            /*0x10f6e30*/ void CopyVertexData(ref Unity.Collections.NativeSlice<UnityEngine.Vector3> outPos, ref Unity.Collections.NativeSlice<UnityEngine.Vector2> outUV0, ref Unity.Collections.NativeSlice<UnityEngine.Vector4> outTan, int outIndex, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> inVertices, int inIndex, float sOrder);
            /*0x10f6cb0*/ int CopySegmentRenderData(UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo ispr, ref Unity.Collections.NativeSlice<UnityEngine.Vector3> outPos, ref Unity.Collections.NativeSlice<UnityEngine.Vector2> outUV0, ref Unity.Collections.NativeSlice<UnityEngine.Vector4> outTan, ref int outCount, ref Unity.Collections.NativeArray<ushort> indexData, ref int indexCount, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> inVertices, int inCount, float sOrder);
            /*0x10f9be0*/ void GetLineSegments(UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo sprInfo, UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo segment, Unity.Mathematics.float2 whsize, ref Unity.Mathematics.float2 vlt, ref Unity.Mathematics.float2 vlb, ref Unity.Mathematics.float2 vrt, ref Unity.Mathematics.float2 vrb);
            /*0x10fe920*/ void TessellateSegment(int segmentIndex, UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo sprInfo, UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo segment, Unity.Mathematics.float2 whsize, Unity.Mathematics.float4 border, float pxlWidth, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> vertices, int vertexCount, bool useClosure, bool validHead, bool validTail, bool firstSegment, bool finalSegment, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> outputVertices, ref int outputCount);
            /*0x10fc7f0*/ bool SkipSegment(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo isi);
            /*0x10fa630*/ float InterpolateLinear(float a, float b, float t);
            /*0x10fa640*/ float InterpolateSmooth(float a, float b, float t);
            /*0x10f56a0*/ bool AddVertex(ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> array, ref int indexCount, UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex vertex);
            /*0x10ff820*/ void TessellateSegments();
            /*0x10f7630*/ bool FetchStretcher(int segmentIndex, UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo sprInfo, UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo segment, Unity.Mathematics.float2 whsize, bool validHead, bool validTail, ref Unity.Mathematics.float4 stretcher);
            /*0x10fcab0*/ void StretchCorners(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo segment, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> vertices, int vertexCount, bool validHead, bool validTail, Unity.Mathematics.float4 stretcher);
            /*0x10f7520*/ void ExtendSegment(ref Unity.Mathematics.float2 l0, ref Unity.Mathematics.float2 r0);
            /*0x10f9600*/ bool GetIntersection(int cp, int ct, UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo ispr, ref Unity.Mathematics.float2 lt0, ref Unity.Mathematics.float2 lb0, ref Unity.Mathematics.float2 rt0, ref Unity.Mathematics.float2 rb0, ref Unity.Mathematics.float2 lt1, ref Unity.Mathematics.float2 lb1, ref Unity.Mathematics.float2 rt1, ref Unity.Mathematics.float2 rb1, ref Unity.Mathematics.float2 tp, ref Unity.Mathematics.float2 bt);
            /*0x10f5a20*/ bool AttachCorner(int cp, int ct, UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo ispr, ref Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobControlPoint> newPoints, ref int activePoint);
            /*0x10f7400*/ Unity.Mathematics.float2 CornerTextureCoordinate(int cornerType, int index);
            /*0x10f65f0*/ int CalculateCorner(int index, float angle, Unity.Mathematics.float2 lt, Unity.Mathematics.float2 rt);
            /*0x10fa140*/ bool InsertCorner(int index, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> cpSpriteIndices, ref Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeGenerator.JobControlPoint> newPoints, ref int activePoint, ref bool cornerConsidered);
            /*0x10fe1d0*/ void TessellateCorners();
            /*0x10f5880*/ bool AreCollinear(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c, float t);
            /*0x10fac80*/ void OptimizePoints(float tolerance, bool tess, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pointSet, ref int pointCount);
            /*0x10f58f0*/ void AttachCornerToCollider(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo isi, float pivot, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> colliderPoints, ref int colliderPointCount);
            /*0x11018c0*/ Unity.Mathematics.float2 UpdateCollider(UnityEngine.U2D.SpriteShapeGenerator.JobSegmentInfo isi, UnityEngine.U2D.SpriteShapeGenerator.JobSpriteInfo ispr, ref UnityEngine.U2D.Common.UTess.Array<UnityEngine.U2D.SpriteShapeGenerator.JobShapeVertex> vertices, int count, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> colliderPoints, ref int colliderPointCount);
            /*0x1100ec0*/ void TrimOverlaps(int cpCount);
            /*0x10fab50*/ void OptimizeCollider();
            /*0x10fc350*/ void Prepare(UnityEngine.U2D.SpriteShapeController controller, UnityEngine.U2D.SpriteShapeParameters shapeParams, int maxArrayCount, Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> shapePoints, Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeMetaData> metaData, UnityEngine.U2D.AngleRangeInfo[] angleRanges, UnityEngine.Sprite[] segmentSprites, UnityEngine.Sprite[] cornerSprites);
            /*0x10fc1a0*/ void Prepare(UnityEngine.U2D.SpriteShapeController controller, UnityEngine.U2D.SpriteShapeParameters shapeParams, int maxArrayCount, Unity.Collections.NativeArray<UnityEngine.U2D.ShapeControlPoint> shapePoints, Unity.Collections.NativeArray<UnityEngine.U2D.SplinePointMetaData> metaData, UnityEngine.U2D.AngleRangeInfo[] angleRanges, UnityEngine.Sprite[] segmentSprites, UnityEngine.Sprite[] cornerSprites, bool UseUTess);
            /*0x10f74b0*/ void Execute();
            /*0x10f6a10*/ void Cleanup();

            struct JobParameters
            {
                /*0x10*/ Unity.Mathematics.int4 shapeData;
                /*0x20*/ Unity.Mathematics.int4 splineData;
                /*0x30*/ Unity.Mathematics.float4 curveData;
                /*0x40*/ Unity.Mathematics.float4 fillData;
            }

            struct JobSpriteInfo
            {
                /*0x10*/ Unity.Mathematics.float4 texRect;
                /*0x20*/ Unity.Mathematics.float4 texData;
                /*0x30*/ Unity.Mathematics.float4 uvInfo;
                /*0x40*/ Unity.Mathematics.float4 metaInfo;
                /*0x50*/ Unity.Mathematics.float4 border;
            }

            struct JobAngleRange
            {
                /*0x10*/ Unity.Mathematics.float4 spriteAngles;
                /*0x20*/ Unity.Mathematics.int4 spriteData;
            }

            struct JobControlPoint
            {
                /*0x10*/ Unity.Mathematics.int4 cpData;
                /*0x20*/ Unity.Mathematics.int4 exData;
                /*0x30*/ Unity.Mathematics.float2 cpInfo;
                /*0x38*/ Unity.Mathematics.float2 position;
                /*0x40*/ Unity.Mathematics.float2 tangentLt;
                /*0x48*/ Unity.Mathematics.float2 tangentRt;
            }

            struct JobContourPoint
            {
                /*0x10*/ Unity.Mathematics.float2 position;
                /*0x18*/ Unity.Mathematics.float2 ptData;
            }

            struct JobIntersectPoint
            {
                /*0x10*/ Unity.Mathematics.float2 top;
                /*0x18*/ Unity.Mathematics.float2 bottom;
            }

            struct JobSegmentInfo
            {
                /*0x10*/ Unity.Mathematics.int4 sgInfo;
                /*0x20*/ Unity.Mathematics.float4 spriteInfo;
            }

            struct JobCornerInfo
            {
                /*0x10*/ Unity.Mathematics.float2 bottom;
                /*0x18*/ Unity.Mathematics.float2 top;
                /*0x20*/ Unity.Mathematics.float2 left;
                /*0x28*/ Unity.Mathematics.float2 right;
                /*0x30*/ Unity.Mathematics.int2 cornerData;
            }

            struct JobShapeVertex
            {
                /*0x10*/ Unity.Mathematics.float2 pos;
                /*0x18*/ Unity.Mathematics.float2 uv;
                /*0x20*/ Unity.Mathematics.float4 tan;
                /*0x30*/ Unity.Mathematics.float2 meta;
                /*0x38*/ Unity.Mathematics.int4 sprite;
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.U2D.SpriteShapeGenerator.<> <>9;
                static /*0x8*/ System.Func<int, ushort> <>9__147_0;
                static /*0x10*/ System.Func<Unity.SpriteShape.External.LibTessDotNet.ContourVertex, UnityEngine.Vector2> <>9__147_1;

                static /*0x110a7e0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x110a7b0*/ ushort <TessellateContourMainThread>b__147_0(int i);
                /*0x110a7c0*/ UnityEngine.Vector2 <TessellateContourMainThread>b__147_1(Unity.SpriteShape.External.LibTessDotNet.ContourVertex v);
            }

            class UTessellator_0000016D$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x110af50*/ UTessellator_0000016D$PostfixBurstDelegate(object , nint );
                /*0x110af30*/ void Invoke(ref UnityEngine.U2D.SpriteShapeSegment geom, int maxCount, Unity.Mathematics.float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Unity.Collections.Allocator label);
                /*0x110add0*/ System.IAsyncResult BeginInvoke(ref UnityEngine.U2D.SpriteShapeSegment geom, int maxCount, Unity.Mathematics.float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Unity.Collections.Allocator label, System.AsyncCallback , object );
                /*0x723cb0*/ void EndInvoke(System.IAsyncResult );
            }

            class UTessellator_0000016D$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;
                static /*0x8*/ nint DeferredCompilation;

                static /*0x110a850*/ UTessellator_0000016D$BurstDirectCall();
                static /*0x110a900*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x110aa30*/ nint GetFunctionPointer();
                static /*0x110a850*/ void Constructor();
                static /*0x32d010*/ void Initialize();
                static /*0x110aba0*/ void Invoke(ref UnityEngine.U2D.SpriteShapeSegment geom, int maxCount, Unity.Mathematics.float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Unity.Collections.Allocator label);
            }
        }

        class SpriteShapeGeometryCreator : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ SpriteShapeGeometryCreator();
            /*0x17b580*/ int GetVertexArrayCount(UnityEngine.U2D.SpriteShapeController spriteShapeController);
            Unity.Jobs.JobHandle MakeCreatorJob(UnityEngine.U2D.SpriteShapeController spriteShapeController, Unity.Collections.NativeArray<ushort> indices, Unity.Collections.NativeSlice<UnityEngine.Vector3> positions, Unity.Collections.NativeSlice<UnityEngine.Vector2> texCoords, Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> segments, Unity.Collections.NativeArray<Unity.Mathematics.float2> colliderData);
            /*0x110a760*/ int GetVersion();
        }

        class SpriteShapeGeometryModifier : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ SpriteShapeGeometryModifier();
            Unity.Jobs.JobHandle MakeModifierJob(Unity.Jobs.JobHandle generator, UnityEngine.U2D.SpriteShapeController spriteShapeController, Unity.Collections.NativeArray<ushort> indices, Unity.Collections.NativeSlice<UnityEngine.Vector3> positions, Unity.Collections.NativeSlice<UnityEngine.Vector2> texCoords, Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> segments, Unity.Collections.NativeArray<Unity.Mathematics.float2> colliderData);
            /*0x110a760*/ int GetVersion();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2F4C1C29229A1503E03C5C309BFEB225317CAEC2C06ABC3024D3CBDB6B3024E8;
    static /*0x6b9*/ <PrivateImplementationDetails> F00A4F1FEB6762FBF8E564BC28B022EA1EEC2FCF00FFCA53BC7C93899379D138;

    struct __StaticArrayInitTypeSize=1721
    {
    }

    struct __StaticArrayInitTypeSize=2116
    {
    }
}

class $BurstDirectCallInitializer
{
    static /*0x110a770*/ void Initialize();
}
