class <Module>
{
}

namespace UnityEngine
{
    class Terrain : UnityEngine.Behaviour
    {
        static /*0x7f596f0*/ UnityEngine.Terrain[] get_activeTerrains();
        static /*0x7f593c4*/ nint get_terrainData_Injected(nint _unity_self);
        static /*0x7f59478*/ bool get_allowAutoConnect_Injected(nint _unity_self);
        static /*0x7f5952c*/ int get_groupingID_Injected(nint _unity_self);
        static /*0x7f59684*/ void SetNeighbors_Injected(nint _unity_self, nint left, nint top, nint right, nint bottom);
        /*0x7f59718*/ Terrain();
        /*0x7f59330*/ UnityEngine.TerrainData get_terrainData();
        /*0x7f59400*/ bool get_allowAutoConnect();
        /*0x7f594b4*/ int get_groupingID();
        /*0x7f59568*/ void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom);
    }

    class TerrainCallbacks
    {
        static /*0x0*/ UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;
        static /*0x8*/ UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged;

        static /*0x7f59720*/ void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, bool synched);
        static /*0x7f598a8*/ void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, string textureName, UnityEngine.RectInt texelRegion, bool synched);

        class HeightmapChangedCallback : System.MulticastDelegate
        {
            /*0x7f599a4*/ HeightmapChangedCallback(object object, nint method);
            /*0x7f59a58*/ void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched);
        }

        class TextureChangedCallback : System.MulticastDelegate
        {
            /*0x7f59a70*/ TextureChangedCallback(object object, nint method);
            /*0x7f59b24*/ void Invoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched);
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

        static /*0x7f5a090*/ TerrainData();
        static /*0x7f59b3c*/ int GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type);
        static /*0x7f59c30*/ nint get_heightmapTexture_Injected(nint _unity_self);
        static /*0x7f59d28*/ void get_heightmapScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f59e28*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7f59f38*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7f5a018*/ float GetAlphamapResolutionInternal_Injected(nint _unity_self);
        static /*0x7f5a054*/ UnityEngine.Terrain[] get_users_Injected(nint _unity_self);
        /*0x7f59b78*/ UnityEngine.RenderTexture get_heightmapTexture();
        /*0x7f59c6c*/ UnityEngine.Vector3 get_heightmapScale();
        /*0x7f59d6c*/ UnityEngine.Vector3 get_size();
        /*0x7f59e6c*/ UnityEngine.Bounds get_bounds();
        /*0x7f59f7c*/ float GetAlphamapResolutionInternal();
        /*0x7f5980c*/ UnityEngine.Terrain[] get_users();

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

            /*0x7f5a250*/ TerrainTileCoord(int tileX, int tileZ);
        }

        class TerrainMap
        {
            /*0x10*/ UnityEngine.Vector3 m_patchSize;
            /*0x1c*/ UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode;
            /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> m_terrainTiles;

            static /*0x7f5a2d0*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            static /*0x7f5a500*/ UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, bool fullValidation);
            /*0x7f5a8c4*/ TerrainMap();
            /*0x7f5a258*/ UnityEngine.Terrain GetTerrain(int tileX, int tileZ);
            /*0x7f5abc8*/ System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> get_terrainTiles();
            /*0x7f5abd0*/ void AddTerrainInternal(int x, int z, UnityEngine.Terrain terrain);
            /*0x7f5a950*/ bool TryToAddTerrain(int tileX, int tileZ, UnityEngine.Terrain terrain);
            /*0x7f5acd0*/ void ValidateTerrain(int tileX, int tileZ);
            /*0x7f5aa64*/ UnityEngine.TerrainUtils.TerrainMapStatusCode Validate();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ int groupID;

                /*0x7f5a4f8*/ <>c__DisplayClass3_0();
                /*0x7f5b3cc*/ bool <CreateFromPlacement>b__0(UnityEngine.Terrain x);
            }
        }

        class TerrainUtility
        {
            static /*0x7f5b3f8*/ bool ValidTerrainsExist();
            static /*0x7f5b460*/ void ClearConnectivity();
            static /*0x7f5b500*/ System.Collections.Generic.Dictionary<int, UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains);
            static /*0x7f5b7a8*/ void AutoConnect();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ bool onlyAutoConnectedTerrains;

                /*0x7f5b798*/ <>c__DisplayClass2_0();
            }

            class <>c__DisplayClass2_1
            {
                /*0x10*/ UnityEngine.Terrain t;
                /*0x18*/ UnityEngine.TerrainUtils.TerrainUtility.<> CS$<>8__locals1;

                /*0x7f5b7a0*/ <>c__DisplayClass2_1();
                /*0x7f5bb00*/ bool <CollectTerrains>b__0(UnityEngine.Terrain x);
            }
        }
    }

    namespace Rendering
    {
        class SpeedTreeWindManager
        {
            static /*0x7f5bb74*/ void UpdateWindAndWriteBufferWindParams(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator windParams, bool history);
            static /*0x7f5bc40*/ void UpdateWindAndWriteBufferWindParams_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper renderersID, ref UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator windParams, bool history);
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
