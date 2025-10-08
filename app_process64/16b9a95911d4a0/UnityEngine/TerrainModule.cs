class <Module>
{
}

namespace UnityEngine
{
    class Terrain : UnityEngine.Behaviour
    {
        static /*0x3e96fa8*/ UnityEngine.Terrain[] get_activeTerrains();
        static /*0x3e96c7c*/ nint get_terrainData_Injected(nint _unity_self);
        static /*0x3e96d30*/ bool get_allowAutoConnect_Injected(nint _unity_self);
        static /*0x3e96de4*/ int get_groupingID_Injected(nint _unity_self);
        static /*0x3e96f3c*/ void SetNeighbors_Injected(nint _unity_self, nint left, nint top, nint right, nint bottom);
        /*0x3e96fd0*/ Terrain();
        /*0x3e96be8*/ UnityEngine.TerrainData get_terrainData();
        /*0x3e96cb8*/ bool get_allowAutoConnect();
        /*0x3e96d6c*/ int get_groupingID();
        /*0x3e96e20*/ void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom);
    }

    class TerrainCallbacks
    {
        static /*0x0*/ UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;
        static /*0x8*/ UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged;

        static /*0x3e96fd8*/ void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, bool synched);
        static /*0x3e9715c*/ void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, string textureName, UnityEngine.RectInt texelRegion, bool synched);

        class HeightmapChangedCallback : System.MulticastDelegate
        {
            /*0x3e97254*/ HeightmapChangedCallback(object object, nint method);
            /*0x3e97308*/ void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched);
        }

        class TextureChangedCallback : System.MulticastDelegate
        {
            /*0x3e9731c*/ TextureChangedCallback(object object, nint method);
            /*0x3e973d0*/ void Invoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched);
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

        static /*0x3e97634*/ TerrainData();
        static /*0x3e973e4*/ int GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type);
        static /*0x3e974dc*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e975bc*/ float GetAlphamapResolutionInternal_Injected(nint _unity_self);
        static /*0x3e975f8*/ UnityEngine.Terrain[] get_users_Injected(nint _unity_self);
        /*0x3e97420*/ UnityEngine.Vector3 get_size();
        /*0x3e97520*/ float GetAlphamapResolutionInternal();
        /*0x3e970c0*/ UnityEngine.Terrain[] get_users();

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

            /*0x3e977f4*/ TerrainTileCoord(int tileX, int tileZ);
        }

        class TerrainMap
        {
            /*0x10*/ UnityEngine.Vector3 m_patchSize;
            /*0x1c*/ UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode;
            /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> m_terrainTiles;

            static /*0x3e97880*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            static /*0x3e97aa8*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            /*0x3e97e60*/ TerrainMap();
            /*0x3e977fc*/ UnityEngine.Terrain GetTerrain(int tileX, int tileZ);
            /*0x3e981c8*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> get_terrainTiles();
            /*0x3e981d0*/ void AddTerrainInternal(int x, int z, UnityEngine.Terrain terrain);
            /*0x3e97eec*/ bool TryToAddTerrain(int tileX, int tileZ, UnityEngine.Terrain terrain);
            /*0x3e982f4*/ void ValidateTerrain(int tileX, int tileZ);
            /*0x3e98000*/ UnityEngine.TerrainUtils.TerrainMapStatusCode Validate();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ int groupID;

                /*0x3e97aa0*/ <>c__DisplayClass3_0();
                /*0x3e989f0*/ bool <CreateFromPlacement>b__0(UnityEngine.Terrain x);
            }
        }

        class TerrainUtility
        {
            static /*0x3e98a1c*/ bool ValidTerrainsExist();
            static /*0x3e98a7c*/ void ClearConnectivity();
            static /*0x3e98b18*/ System.Collections.Generic.Dictionary<int, UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains);
            static /*0x3e98dcc*/ void AutoConnect();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ bool onlyAutoConnectedTerrains;

                /*0x3e98dbc*/ <>c__DisplayClass2_0();
            }

            class <>c__DisplayClass2_1
            {
                /*0x10*/ UnityEngine.Terrain t;
                /*0x18*/ UnityEngine.TerrainUtils.TerrainUtility.<> CS$<>8__locals1;

                /*0x3e98dc4*/ <>c__DisplayClass2_1();
                /*0x3e992f4*/ bool <CollectTerrains>b__0(UnityEngine.Terrain x);
            }
        }
    }

    namespace Rendering
    {
        class SpeedTreeWindManager
        {
            static /*0x3e99368*/ void UpdateWindAndWriteBufferWindParams(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator windParams, bool history);
            static /*0x3e99434*/ void UpdateWindAndWriteBufferWindParams_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper renderersID, ref UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator windParams, bool history);
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
