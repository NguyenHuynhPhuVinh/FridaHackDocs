class <Module>
{
}

namespace UnityEngine
{
    namespace U2D
    {
        struct SpriteShapeParameters
        {
            /*0x10*/ UnityEngine.Matrix4x4 transform;
            /*0x50*/ UnityEngine.Texture2D fillTexture;
            /*0x58*/ uint fillScale;
            /*0x5c*/ uint splineDetail;
            /*0x60*/ float angleThreshold;
            /*0x64*/ float borderPivot;
            /*0x68*/ float bevelCutoff;
            /*0x6c*/ float bevelSize;
            /*0x70*/ bool carpet;
            /*0x71*/ bool smartSprite;
            /*0x72*/ bool adaptiveUV;
            /*0x73*/ bool spriteBorders;
            /*0x74*/ bool stretchUV;
        }

        struct SpriteShapeSegment
        {
            /*0x10*/ int m_GeomIndex;
            /*0x14*/ int m_IndexCount;
            /*0x18*/ int m_VertexCount;
            /*0x1c*/ int m_SpriteIndex;

            /*0x6bbd40*/ void set_geomIndex(int value);
            /*0xc6bf90*/ int get_indexCount();
            /*0xfc2c10*/ void set_indexCount(int value);
            /*0xb73eb0*/ int get_vertexCount();
            /*0xf0fbd0*/ void set_vertexCount(int value);
            /*0xf0fbc0*/ void set_spriteIndex(int value);
        }

        enum SpriteShapeDataType
        {
            Index = 0,
            Segment = 1,
            BoundingBox = 2,
            ChannelVertex = 3,
            ChannelTexCoord0 = 4,
            ChannelNormal = 5,
            ChannelTangent = 6,
            ChannelColor = 7,
            DataCount = 8,
        }

        class SpriteShapeRenderer : UnityEngine.Renderer
        {
            /*0x31c640*/ SpriteShapeRenderer();
            /*0x1655e20*/ void Prepare(Unity.Jobs.JobHandle handle, UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.Sprite[] sprites);
            /*0x2a5510*/ Unity.Collections.NativeArray<T> GetNativeDataArray<T>(UnityEngine.U2D.SpriteShapeDataType dataType);
            /*0x2a5510*/ Unity.Collections.NativeSlice<T> GetChannelDataArray<T>(UnityEngine.U2D.SpriteShapeDataType dataType, UnityEngine.Rendering.VertexAttribute channel);
            /*0x1655fe0*/ void SetSegmentCount(int geomCount);
            /*0x1655f90*/ void SetMeshDataCount(int vertexCount, int indexCount);
            /*0x1655f30*/ void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask);
            /*0x1655cb0*/ UnityEngine.U2D.SpriteChannelInfo GetDataInfo(UnityEngine.U2D.SpriteShapeDataType arrayType);
            /*0x16559a0*/ UnityEngine.U2D.SpriteChannelInfo GetChannelInfo(UnityEngine.Rendering.VertexAttribute channel);
            /*0x1655ee0*/ void SetLocalAABB(UnityEngine.Bounds bounds);
            /*0x16558e0*/ Unity.Collections.NativeArray<UnityEngine.Bounds> GetBounds();
            /*0x1655d10*/ Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> GetSegments(int dataSize);
            /*0x1655b50*/ void GetChannels(int dataSize, ref Unity.Collections.NativeArray<ushort> indices, ref Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, ref Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords);
            /*0x1655a00*/ void GetChannels(int dataSize, ref Unity.Collections.NativeArray<ushort> indices, ref Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, ref Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords, ref Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents);
            /*0x1655db0*/ void Prepare_Injected(ref Unity.Jobs.JobHandle handle, ref UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.Sprite[] sprites);
            /*0x1655c60*/ void GetDataInfo_Injected(UnityEngine.U2D.SpriteShapeDataType arrayType, ref UnityEngine.U2D.SpriteChannelInfo ret);
            /*0x1655950*/ void GetChannelInfo_Injected(UnityEngine.Rendering.VertexAttribute channel, ref UnityEngine.U2D.SpriteChannelInfo ret);
            /*0x1655e90*/ void SetLocalAABB_Injected(ref UnityEngine.Bounds bounds);
        }

        struct SpriteShapeMetaData
        {
            /*0x10*/ float height;
            /*0x14*/ float bevelCutoff;
            /*0x18*/ float bevelSize;
            /*0x1c*/ uint spriteIndex;
            /*0x20*/ bool corner;
        }

        struct ShapeControlPoint
        {
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Vector3 leftTangent;
            /*0x28*/ UnityEngine.Vector3 rightTangent;
            /*0x34*/ int mode;
        }

        struct AngleRangeInfo
        {
            /*0x10*/ float start;
            /*0x14*/ float end;
            /*0x18*/ uint order;
            /*0x20*/ int[] sprites;
        }
    }
}
