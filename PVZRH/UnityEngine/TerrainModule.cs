class <Module>
{
}

namespace UnityEngine
{
    class Terrain : UnityEngine.Behaviour
    {
        static /*0x16591c0*/ UnityEngine.Terrain[] get_activeTerrains();
        /*0x15b84e0*/ Terrain();
        /*0x1659270*/ UnityEngine.TerrainData get_terrainData();
        /*0x16591f0*/ bool get_allowAutoConnect();
        /*0x1659230*/ int get_groupingID();
        /*0x1659150*/ void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom);
    }

    class TerrainCallbacks
    {
        static /*0x0*/ UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;
        static /*0x8*/ UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged;

        static /*0x1656fd0*/ void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, bool synched);
        static /*0x16570e0*/ void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, string textureName, UnityEngine.RectInt texelRegion, bool synched);

        class HeightmapChangedCallback : System.MulticastDelegate
        {
            /*0x1656f10*/ HeightmapChangedCallback(object object, nint method);
            /*0x1656ee0*/ void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched);
        }

        class TextureChangedCallback : System.MulticastDelegate
        {
            /*0x16592f0*/ TextureChangedCallback(object object, nint method);
            /*0x16592b0*/ void Invoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched);
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

        static /*0x16572c0*/ TerrainData();
        static /*0x1657240*/ int GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type);
        static /*0x1657280*/ void Internal_Create(UnityEngine.TerrainData terrainData);
        /*0x16574a0*/ TerrainData();
        /*0x1657580*/ UnityEngine.Vector3 get_size();
        /*0x1657200*/ float GetAlphamapResolutionInternal();
        /*0x16575d0*/ UnityEngine.Terrain[] get_users();
        /*0x1657530*/ void get_size_Injected(ref UnityEngine.Vector3 ret);

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

            /*0xa59f20*/ TerrainTileCoord(int tileX, int tileZ);
        }

        class TerrainMap
        {
            /*0x10*/ UnityEngine.Vector3 m_patchSize;
            /*0x1c*/ UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode;
            /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> m_terrainTiles;

            static /*0x1657b80*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            static /*0x16577f0*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            /*0x1658830*/ TerrainMap();
            /*0x1657ec0*/ UnityEngine.Terrain GetTerrain(int tileX, int tileZ);
            /*0x61a260*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> get_terrainTiles();
            /*0x1657610*/ void AddTerrainInternal(int x, int z, UnityEngine.Terrain terrain);
            /*0x1657f40*/ bool TryToAddTerrain(int tileX, int tileZ, UnityEngine.Terrain terrain);
            /*0x1658050*/ void ValidateTerrain(int tileX, int tileZ);
            /*0x16586f0*/ UnityEngine.TerrainUtils.TerrainMapStatusCode Validate();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ int groupID;

                /*0x32f970*/ <>c__DisplayClass3_0();
                /*0x1659490*/ bool <CreateFromPlacement>b__0(UnityEngine.Terrain x);
            }
        }

        class TerrainUtility
        {
            static /*0x16590e0*/ bool ValidTerrainsExist();
            static /*0x1658cc0*/ void ClearConnectivity();
            static /*0x1658dc0*/ System.Collections.Generic.Dictionary<int, UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains);
            static /*0x16588b0*/ void AutoConnect();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ bool onlyAutoConnectedTerrains;

                /*0x32f970*/ <>c__DisplayClass2_0();
            }

            class <>c__DisplayClass2_1
            {
                /*0x10*/ UnityEngine.Terrain t;
                /*0x18*/ UnityEngine.TerrainUtils.TerrainUtility.<> CS$<>8__locals1;

                /*0x32f970*/ <>c__DisplayClass2_1();
                /*0x16593b0*/ bool <CollectTerrains>b__0(UnityEngine.Terrain x);
            }
        }
    }
}
