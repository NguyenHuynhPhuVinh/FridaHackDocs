class <Module>
{
}

namespace UnityEngine
{
    class Terrain : UnityEngine.Behaviour
    {
        static /*0x7f70b20*/ UnityEngine.Terrain[] get_activeTerrains();
        static /*0x7f707f4*/ nint get_terrainData_Injected(nint _unity_self);
        static /*0x7f708a8*/ bool get_allowAutoConnect_Injected(nint _unity_self);
        static /*0x7f7095c*/ int get_groupingID_Injected(nint _unity_self);
        static /*0x7f70ab4*/ void SetNeighbors_Injected(nint _unity_self, nint left, nint top, nint right, nint bottom);
        /*0x7f70b48*/ Terrain();
        /*0x7f70760*/ UnityEngine.TerrainData get_terrainData();
        /*0x7f70830*/ bool get_allowAutoConnect();
        /*0x7f708e4*/ int get_groupingID();
        /*0x7f70998*/ void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom);
    }

    class TerrainCallbacks
    {
        static /*0x0*/ UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;
        static /*0x8*/ UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged;

        static /*0x7f70b50*/ void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, bool synched);
        static /*0x7f70cd8*/ void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, string textureName, UnityEngine.RectInt texelRegion, bool synched);

        class HeightmapChangedCallback : System.MulticastDelegate
        {
            /*0x7f70dd4*/ HeightmapChangedCallback(object object, nint method);
            /*0x7f70e88*/ void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched);
        }

        class TextureChangedCallback : System.MulticastDelegate
        {
            /*0x7f70ea0*/ TextureChangedCallback(object object, nint method);
            /*0x7f70f54*/ void Invoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched);
        }
    }

    class TerrainData : UnityEngine.Object
    {
        static /*0x0*/ int k_MaximumResolution;
        static /*0x4*/ int k_MinimumDetailResolutionPerPatch;
        static /*0x8*/ int k_MaximumDetailResolutionPerPatch;
        static /*0xc*/ int k_MaximumDetailPatchCount;
        static /*0x10*/ int k_MinimumAlphamapResolution;
        static /*0x14*/ int k_MaximumAlphamapResolution;
        static /*0x18*/ int k_MinimumBaseMapResolution;
        static /*0x1c*/ int k_MaximumBaseMapResolution;

        static /*0x7f714c0*/ TerrainData();
        static /*0x7f70f6c*/ int GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type);
        static /*0x7f71060*/ nint get_heightmapTexture_Injected(nint _unity_self);
        static /*0x7f71158*/ void get_heightmapScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f71258*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f71368*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7f71448*/ float GetAlphamapResolutionInternal_Injected(nint _unity_self);
        static /*0x7f71484*/ UnityEngine.Terrain[] get_users_Injected(nint _unity_self);
        /*0x7f70fa8*/ UnityEngine.RenderTexture get_heightmapTexture();
        /*0x7f7109c*/ UnityEngine.Vector3 get_heightmapScale();
        /*0x7f7119c*/ UnityEngine.Vector3 get_size();
        /*0x7f7129c*/ UnityEngine.Bounds get_bounds();
        /*0x7f713ac*/ float GetAlphamapResolutionInternal();
        /*0x7f70c3c*/ UnityEngine.Terrain[] get_users();

        enum BoundaryValueType
        {
            MaxHeightmapRes = 0,
            MinDetailResPerPatch = 1,
            MaxDetailResPerPatch = 2,
            MaxDetailPatchCount = 3,
            MaxCoveragePerRes = 4,
            MinAlphamapRes = 5,
            MaxAlphamapRes = 6,
            MinBaseMapRes = 7,
            MaxBaseMapRes = 8,
        }
    }

    namespace TerrainUtils
    {
        enum TerrainMapStatusCode
        {
            OK = 0,
            Overlapping = 1,
            SizeMismatch = 4,
            EdgeAlignmentMismatch = 8,
        }

        struct TerrainTileCoord
        {
            /*0x10*/ int tileX;
            /*0x14*/ int tileZ;

            /*0x7f71680*/ TerrainTileCoord(int tileX, int tileZ);
        }

        class TerrainMap
        {
            /*0x10*/ UnityEngine.Vector3 m_patchSize;
            /*0x1c*/ UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode;
            /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> m_terrainTiles;

            static /*0x7f71700*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            static /*0x7f71930*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            /*0x7f71cf4*/ TerrainMap();
            /*0x7f71688*/ UnityEngine.Terrain GetTerrain(int tileX, int tileZ);
            /*0x7f71ff8*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> get_terrainTiles();
            /*0x7f72000*/ void AddTerrainInternal(int x, int z, UnityEngine.Terrain terrain);
            /*0x7f71d80*/ bool TryToAddTerrain(int tileX, int tileZ, UnityEngine.Terrain terrain);
            /*0x7f72100*/ void ValidateTerrain(int tileX, int tileZ);
            /*0x7f71e94*/ UnityEngine.TerrainUtils.TerrainMapStatusCode Validate();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ int groupID;

                /*0x7f71928*/ <>c__DisplayClass3_0();
                /*0x7f727fc*/ bool <CreateFromPlacement>b__0(UnityEngine.Terrain x);
            }
        }

        class TerrainUtility
        {
            static /*0x7f72828*/ bool ValidTerrainsExist();
            static /*0x7f72890*/ void ClearConnectivity();
            static /*0x7f72930*/ System.Collections.Generic.Dictionary<int, UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains);
            static /*0x7f72bd8*/ void AutoConnect();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ bool onlyAutoConnectedTerrains;

                /*0x7f72bc8*/ <>c__DisplayClass2_0();
            }

            class <>c__DisplayClass2_1
            {
                /*0x10*/ UnityEngine.Terrain t;
                /*0x18*/ UnityEngine.TerrainUtils.TerrainUtility.<> CS$<>8__locals1;

                /*0x7f72bd0*/ <>c__DisplayClass2_1();
                /*0x7f72f30*/ bool <CollectTerrains>b__0(UnityEngine.Terrain x);
            }
        }
    }

    namespace Rendering
    {
        class SpeedTreeWindManager
        {
            static /*0x7f72fa4*/ void UpdateWindAndWriteBufferWindParams(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator windParams, bool history);
            static /*0x7f73070*/ void UpdateWindAndWriteBufferWindParams_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper renderersID, ref UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator windParams, bool history);
        }

        struct SpeedTreeWindParamsBufferIterator
        {
            /*0x10*/ nint bufferPtr;
            /*0x18*/ UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator.<uintParamOffsets> uintParamOffsets;
            /*0x58*/ int uintStride;
            /*0x5c*/ int elementOffset;
            /*0x60*/ int elementsCount;

            struct <uintParamOffsets>e__FixedBuffer
            {
                /*0x10*/ int FixedElementField;
            }
        }
    }
}
