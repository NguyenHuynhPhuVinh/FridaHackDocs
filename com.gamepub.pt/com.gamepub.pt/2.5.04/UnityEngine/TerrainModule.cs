class <Module>
{
}

namespace UnityEngine
{
    class Terrain : UnityEngine.Behaviour
    {
        static /*0x2b028e8*/ UnityEngine.Terrain[] get_activeTerrains();
        /*0x2b0291c*/ Terrain();
        /*0x2b027b8*/ UnityEngine.TerrainData get_terrainData();
        /*0x2b027f8*/ bool get_allowAutoConnect();
        /*0x2b02838*/ int get_groupingID();
        /*0x2b02878*/ void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom);
    }

    class TerrainData : UnityEngine.Object
    {
        static /*0x0*/ int k_MaximumResolution;
        static /*0x4*/ int k_MinimumDetailResolutionPerPatch;
        static /*0x8*/ int k_MaximumDetailResolutionPerPatch;
        static /*0xc*/ int k_MaximumDetailPatchCount;
        static /*0x10*/ int k_MaximumDetailsPerRes;
        static /*0x14*/ int k_MinimumAlphamapResolution;
        static /*0x18*/ int k_MaximumAlphamapResolution;
        static /*0x1c*/ int k_MinimumBaseMapResolution;
        static /*0x20*/ int k_MaximumBaseMapResolution;

        static /*0x2b035a4*/ TerrainData();
        static /*0x2b0337c*/ int GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type);
        static /*0x2b03474*/ void Internal_Create(UnityEngine.TerrainData terrainData);
        /*0x2b033bc*/ TerrainData();
        /*0x2b034b4*/ UnityEngine.Vector3 get_size();
        /*0x2b03564*/ float GetAlphamapResolutionInternal();
        /*0x2b02a38*/ UnityEngine.Terrain[] get_users();
        /*0x2b03514*/ void get_size_Injected(ref UnityEngine.Vector3 ret);

        enum BoundaryValueType
        {
            MaxHeightmapRes = 0,
            MinDetailResPerPatch = 1,
            MaxDetailResPerPatch = 2,
            MaxDetailPatchCount = 3,
            MaxDetailsPerRes = 4,
            MinAlphamapRes = 5,
            MaxAlphamapRes = 6,
            MinBaseMapRes = 7,
            MaxBaseMapRes = 8,
        }
    }

    namespace Experimental
    {
        namespace TerrainAPI
        {
            class TerrainCallbacks
            {
                static /*0x0*/ UnityEngine.Experimental.TerrainAPI.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;
                static /*0x8*/ UnityEngine.Experimental.TerrainAPI.TerrainCallbacks.TextureChangedCallback textureChanged;

                static /*0x2b02924*/ void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, bool synched);
                static /*0x2b02e50*/ void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, string textureName, UnityEngine.RectInt texelRegion, bool synched);

                class HeightmapChangedCallback : System.MulticastDelegate
                {
                    /*0x2b043dc*/ HeightmapChangedCallback(object object, nint method);
                    /*0x2b02a78*/ void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched);
                    /*0x2b0443c*/ System.IAsyncResult BeginInvoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched, System.AsyncCallback callback, object object);
                    /*0x2b04504*/ void EndInvoke(System.IAsyncResult result);
                }

                class TextureChangedCallback : System.MulticastDelegate
                {
                    /*0x2b04510*/ TextureChangedCallback(object object, nint method);
                    /*0x2b02f6c*/ void Invoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched);
                    /*0x2b04570*/ System.IAsyncResult BeginInvoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched, System.AsyncCallback callback, object object);
                    /*0x2b0463c*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class TerrainUtility
            {
                static /*0x2b03798*/ bool HasValidTerrains();
                static /*0x2b0380c*/ void ClearConnectivity();
                static /*0x2b03918*/ UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains);
                static /*0x2b03fa4*/ void AutoConnect();

                class TerrainMap
                {
                    /*0x10*/ UnityEngine.Vector3 m_patchSize;
                    /*0x1c*/ UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.ErrorCode m_errorCode;
                    /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TileCoord, UnityEngine.Terrain> m_terrainTiles;

                    static /*0x2b03ce8*/ UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation);
                    static /*0x2b04744*/ UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation);
                    /*0x2b049dc*/ TerrainMap();
                    /*0x2b04358*/ UnityEngine.Terrain GetTerrain(int tileX, int tileZ);
                    /*0x2b05040*/ void AddTerrainInternal(int x, int z, UnityEngine.Terrain terrain);
                    /*0x2b04de0*/ bool TryToAddTerrain(int tileX, int tileZ, UnityEngine.Terrain terrain);
                    /*0x2b05148*/ void ValidateTerrain(int tileX, int tileZ);
                    /*0x2b04f10*/ UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.ErrorCode Validate();

                    class TerrainFilter : System.MulticastDelegate
                    {
                        /*0x2b03c88*/ TerrainFilter(object object, nint method);
                        /*0x2b04a5c*/ bool Invoke(UnityEngine.Terrain terrain);
                        /*0x2b056b4*/ System.IAsyncResult BeginInvoke(UnityEngine.Terrain terrain, System.AsyncCallback callback, object object);
                        /*0x2b056d8*/ bool EndInvoke(System.IAsyncResult result);
                    }

                    struct TileCoord
                    {
                        /*0x10*/ int tileX;
                        /*0x14*/ int tileZ;

                        /*0xb39e7c*/ TileCoord(int tileX, int tileZ);
                    }

                    enum ErrorCode
                    {
                        OK = 0,
                        Overlapping = 1,
                        SizeMismatch = 4,
                        EdgeAlignmentMismatch = 8,
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ int groupID;

                        /*0x2b0473c*/ <>c__DisplayClass4_0();
                        /*0x2b05650*/ bool <CreateFromPlacement>b__0(UnityEngine.Terrain x);
                    }
                }

                class TerrainGroups : System.Collections.Generic.Dictionary<int, UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap>
                {
                    /*0x2b03c34*/ TerrainGroups();
                }

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ bool onlyAutoConnectedTerrains;

                    /*0x2b03c2c*/ <>c__DisplayClass4_0();
                }

                class <>c__DisplayClass4_1
                {
                    /*0x10*/ UnityEngine.Terrain t;
                    /*0x18*/ UnityEngine.Experimental.TerrainAPI.TerrainUtility.<> CS$<>8__locals1;

                    /*0x2b03c80*/ <>c__DisplayClass4_1();
                    /*0x2b04648*/ bool <CollectTerrains>b__0(UnityEngine.Terrain x);
                }
            }
        }
    }
}
