class <Module>
{
}

namespace UnityEngine
{
    namespace Tilemaps
    {
        class ITilemap
        {
            static /*0x0*/ UnityEngine.Tilemaps.ITilemap s_Instance;
            /*0x10*/ UnityEngine.Tilemaps.Tilemap m_Tilemap;
            /*0x18*/ bool m_AddToList;
            /*0x1c*/ int m_RefreshCount;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Vector3Int> m_RefreshPos;

            static /*0x3ee1e78*/ UnityEngine.Tilemaps.ITilemap CreateInstance();
            static /*0x3ee1ef0*/ void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint oldTilesIntPtr, nint newTilesIntPtr, nint positionsIntPtr);
            static /*0x3ee2250*/ void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint tilesIntPtr, nint positionsIntPtr, nint outTileDataIntPtr);
            /*0x3ee1c84*/ ITilemap();
            /*0x3ee1c8c*/ void RefreshTile(UnityEngine.Vector3Int position);
        }

        class Tile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x70*/ UnityEngine.GameObject m_InstancedGameObject;
            /*0x78*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x7c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            /*0x3ee26c0*/ Tile();
            /*0x3ee2448*/ UnityEngine.Sprite get_sprite();
            /*0x3ee2450*/ void set_sprite(UnityEngine.Sprite value);
            /*0x3ee2458*/ UnityEngine.Color get_color();
            /*0x3ee2464*/ void set_color(UnityEngine.Color value);
            /*0x3ee2470*/ UnityEngine.Matrix4x4 get_transform();
            /*0x3ee2484*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x3ee2498*/ UnityEngine.GameObject get_gameObject();
            /*0x3ee24a0*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x3ee24a8*/ UnityEngine.Tilemaps.TileFlags get_flags();
            /*0x3ee24b0*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x3ee24b8*/ UnityEngine.Tilemaps.Tile.ColliderType get_colliderType();
            /*0x3ee24c0*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
            /*0x3ee24c8*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);

            enum ColliderType
            {
                None = 0,
                Sprite = 1,
                Grid = 2,
            }
        }

        class TileBase : UnityEngine.ScriptableObject
        {
            /*0x3ee2730*/ TileBase();
            /*0x3ee2738*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x3ee2750*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x3ee2754*/ UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x3ee27a0*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
            /*0x3ee27a8*/ UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x3ee27ec*/ void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData, ref bool hasAnimation);
            /*0x3ee2814*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go);
            /*0x3ee281c*/ void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, ref bool startUpInvokedByUser);
        }

        class Tilemap : UnityEngine.GridLayout
        {
            static /*0x0*/ System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> tilemapTileChanged;
            static /*0x8*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> tilemapPositionsChanged;
            static /*0x10*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> loopEndedForTileAnimation;
            /*0x18*/ bool m_BufferSyncTile;

            static /*0x3ee2844*/ void add_tilemapTileChanged(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> value);
            static /*0x3ee2910*/ void remove_tilemapTileChanged(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> value);
            static /*0x3ee29dc*/ void add_tilemapPositionsChanged(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> value);
            static /*0x3ee2aac*/ void remove_tilemapPositionsChanged(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> value);
            static /*0x3ee2b7c*/ void add_loopEndedForTileAnimation(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> value);
            static /*0x3ee2c4c*/ void remove_loopEndedForTileAnimation(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> value);
            static /*0x3ee2e64*/ bool HasLoopEndedForTileAnimationCallback();
            static /*0x3ee2d9c*/ bool HasSyncTileCallback();
            static /*0x3ee30b4*/ bool HasPositionsChangedCallback();
            static /*0x3ee3494*/ void SetSyncTileCallback(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> callback);
            static /*0x3ee3498*/ void RemoveSyncTileCallback(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> callback);
            static /*0x3ee3530*/ nint get_layoutGrid_Injected(nint _unity_self);
            static /*0x3ee38f0*/ void get_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
            static /*0x3ee39d8*/ void get_localFrameBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
            static /*0x3ee3a94*/ float get_animationFrameRate_Injected(nint _unity_self);
            static /*0x3ee3b58*/ void set_animationFrameRate_Injected(nint _unity_self, float value);
            static /*0x3ee3c38*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
            static /*0x3ee3d0c*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
            static /*0x3ee3d50*/ void get_origin_Injected(nint _unity_self, ref UnityEngine.Vector3Int ret);
            static /*0x3ee3e24*/ void set_origin_Injected(nint _unity_self, ref UnityEngine.Vector3Int value);
            static /*0x3ee3e68*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector3Int ret);
            static /*0x3ee3f3c*/ void set_size_Injected(nint _unity_self, ref UnityEngine.Vector3Int value);
            static /*0x3ee3f80*/ void get_tileAnchor_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x3ee4054*/ void set_tileAnchor_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x3ee4110*/ UnityEngine.Tilemaps.Tilemap.Orientation get_orientation_Injected(nint _unity_self);
            static /*0x3ee41cc*/ void set_orientation_Injected(nint _unity_self, UnityEngine.Tilemaps.Tilemap.Orientation value);
            static /*0x3ee42b8*/ void get_orientationMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
            static /*0x3ee437c*/ void set_orientationMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
            static /*0x3ee446c*/ nint GetTileAsset_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee45e4*/ UnityEngine.Object[] GetTileAssetsBlock_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, ref UnityEngine.Vector3Int blockDimensions);
            static /*0x3ee486c*/ int GetTileAssetsBlockNonAlloc_Injected(nint _unity_self, ref UnityEngine.Vector3Int startPosition, ref UnityEngine.Vector3Int endPosition, UnityEngine.Object[] tiles);
            static /*0x3ee49ac*/ int GetTilesRangeCount_Injected(nint _unity_self, ref UnityEngine.Vector3Int startPosition, ref UnityEngine.Vector3Int endPosition);
            static /*0x3ee4b28*/ int GetTileAssetsRangeNonAlloc_Injected(nint _unity_self, ref UnityEngine.Vector3Int startPosition, ref UnityEngine.Vector3Int endPosition, ref UnityEngine.Bindings.ManagedSpanWrapper positions, UnityEngine.Object[] tiles);
            static /*0x3ee4c6c*/ void SetTileAsset_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, nint tile);
            static /*0x3ee4dd8*/ void SetTileAssets_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positionArray, UnityEngine.Object[] tileArray);
            static /*0x3ee4ed4*/ void INTERNAL_CALL_SetTileAssetsBlock_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, ref UnityEngine.Vector3Int blockDimensions, UnityEngine.Object[] tileArray);
            static /*0x3ee5008*/ void SetTile_Injected(nint _unity_self, ref UnityEngine.Tilemaps.TileChangeData tileChangeData, bool ignoreLockFlags);
            static /*0x3ee50ec*/ void SetTiles_Injected(nint _unity_self, UnityEngine.Tilemaps.TileChangeData[] tileChangeDataArray, bool ignoreLockFlags);
            static /*0x3ee51c4*/ void RefreshTile_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee5208*/ void RefreshTilesNative_Injected(nint _unity_self, void* positions, int count);
            static /*0x3ee52d4*/ void RefreshAllTiles_Injected(nint _unity_self);
            static /*0x3ee53e4*/ void SwapTileAsset_Injected(nint _unity_self, nint changeTile, nint newTile);
            static /*0x3ee54f0*/ bool ContainsTileAsset_Injected(nint _unity_self, nint tileAsset);
            static /*0x3ee55b0*/ int GetUsedTilesCount_Injected(nint _unity_self);
            static /*0x3ee5664*/ int GetUsedSpritesCount_Injected(nint _unity_self);
            static /*0x3ee57a8*/ int Internal_GetUsedTilesNonAlloc_Injected(nint _unity_self, UnityEngine.Object[] usedTiles);
            static /*0x3ee57ec*/ int Internal_GetUsedSpritesNonAlloc_Injected(nint _unity_self, UnityEngine.Object[] usedSprites);
            static /*0x3ee58dc*/ nint GetSprite_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee59d4*/ void GetTransformMatrix_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, ref UnityEngine.Matrix4x4 ret);
            static /*0x3ee5ac0*/ void SetTransformMatrix_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, ref UnityEngine.Matrix4x4 transform);
            static /*0x3ee5bb4*/ void GetColor_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, ref UnityEngine.Color ret);
            static /*0x3ee5ca4*/ void SetColor_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, ref UnityEngine.Color color);
            static /*0x3ee5d88*/ UnityEngine.Tilemaps.TileFlags GetTileFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee5e64*/ void SetTileFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags);
            static /*0x3ee5f50*/ void AddTileFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags);
            static /*0x3ee603c*/ void RemoveTileFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags);
            static /*0x3ee613c*/ nint GetInstantiatedObject_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee622c*/ nint GetObjectToInstantiate_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee6308*/ void SetColliderType_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.Tile.ColliderType colliderType);
            static /*0x3ee63ec*/ UnityEngine.Tilemaps.Tile.ColliderType GetColliderType_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee64c0*/ int GetAnimationFrameCount_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee6594*/ int GetAnimationFrame_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee6670*/ void SetAnimationFrame_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, int frame);
            static /*0x3ee6754*/ float GetAnimationTime_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee6838*/ void SetAnimationTime_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, float time);
            static /*0x3ee691c*/ UnityEngine.Tilemaps.TileAnimationFlags GetTileAnimationFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x3ee69f8*/ void SetTileAnimationFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags);
            static /*0x3ee6ae4*/ void AddTileAnimationFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags);
            static /*0x3ee6bd0*/ void RemoveTileAnimationFlags_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags);
            static /*0x3ee6cf8*/ void FloodFillTileAsset_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, nint tile);
            static /*0x3ee6e50*/ void BoxFillTileAsset_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, nint tile, int startX, int startY, int endX, int endY);
            static /*0x3ee6f94*/ void InsertCells_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers);
            static /*0x3ee70c0*/ void DeleteCells_Injected(nint _unity_self, ref UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers);
            static /*0x3ee71a4*/ void ClearAllTiles_Injected(nint _unity_self);
            static /*0x3ee7258*/ void ResizeBounds_Injected(nint _unity_self);
            static /*0x3ee7314*/ void CompressTilemapBounds_Injected(nint _unity_self, bool keepEditorPreview);
            static /*0x3ee745c*/ void SendAndClearSyncTileBuffer_Injected(nint _unity_self);
            /*0x3ee74a0*/ Tilemap();
            /*0x3ee2d1c*/ bool get_bufferSyncTile();
            /*0x3ee2d24*/ void set_bufferSyncTile(bool value);
            /*0x3ee2eb4*/ void HandleLoopEndedForTileAnimationCallback(int count, nint positionsIntPtr);
            /*0x3ee2f74*/ void SendLoopEndedForTileAnimationCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x3ee3104*/ void HandleSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x3ee3294*/ void HandlePositionsChangedCallback(int count, nint positionsIntPtr);
            /*0x3ee3178*/ void SendTilemapTileChangedCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x3ee3354*/ void SendTilemapPositionsChangedCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x3ee349c*/ UnityEngine.Grid get_layoutGrid();
            /*0x3ee356c*/ UnityEngine.Vector3 GetCellCenterLocal(UnityEngine.Vector3Int position);
            /*0x3ee3668*/ UnityEngine.Vector3 GetCellCenterWorld(UnityEngine.Vector3Int position);
            /*0x3ee36d4*/ UnityEngine.BoundsInt get_cellBounds();
            /*0x3ee384c*/ UnityEngine.Bounds get_localBounds();
            /*0x3ee3934*/ UnityEngine.Bounds get_localFrameBounds();
            /*0x3ee3a1c*/ float get_animationFrameRate();
            /*0x3ee3ad0*/ void set_animationFrameRate(float value);
            /*0x3ee3ba4*/ UnityEngine.Color get_color();
            /*0x3ee3c7c*/ void set_color(UnityEngine.Color value);
            /*0x3ee371c*/ UnityEngine.Vector3Int get_origin();
            /*0x3ee3d94*/ void set_origin(UnityEngine.Vector3Int value);
            /*0x3ee37b4*/ UnityEngine.Vector3Int get_size();
            /*0x3ee3eac*/ void set_size(UnityEngine.Vector3Int value);
            /*0x3ee35d0*/ UnityEngine.Vector3 get_tileAnchor();
            /*0x3ee3fc4*/ void set_tileAnchor(UnityEngine.Vector3 value);
            /*0x3ee4098*/ UnityEngine.Tilemaps.Tilemap.Orientation get_orientation();
            /*0x3ee414c*/ void set_orientation(UnityEngine.Tilemaps.Tilemap.Orientation value);
            /*0x3ee4210*/ UnityEngine.Matrix4x4 get_orientationMatrix();
            /*0x3ee42fc*/ void set_orientationMatrix(UnityEngine.Matrix4x4 value);
            /*0x3ee43c0*/ UnityEngine.Object GetTileAsset(UnityEngine.Vector3Int position);
            /*0x3ee44b0*/ UnityEngine.Tilemaps.TileBase GetTile(UnityEngine.Vector3Int position);
            /*0x1ffc854*/ T GetTile<T>(UnityEngine.Vector3Int position);
            /*0x3ee4548*/ UnityEngine.Object[] GetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions);
            /*0x3ee4638*/ UnityEngine.Tilemaps.TileBase[] GetTilesBlock(UnityEngine.BoundsInt bounds);
            /*0x3ee47c8*/ int GetTileAssetsBlockNonAlloc(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition, UnityEngine.Object[] tiles);
            /*0x3ee48c8*/ int GetTilesBlockNonAlloc(UnityEngine.BoundsInt bounds, UnityEngine.Tilemaps.TileBase[] tiles);
            /*0x3ee4910*/ int GetTilesRangeCount(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition);
            /*0x3ee4a00*/ int GetTileAssetsRangeNonAlloc(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition, UnityEngine.Vector3Int[] positions, UnityEngine.Object[] tiles);
            /*0x3ee4b94*/ int GetTilesRangeNonAlloc(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition, UnityEngine.Vector3Int[] positions, UnityEngine.Tilemaps.TileBase[] tiles);
            /*0x3ee4ba0*/ void SetTileAsset(UnityEngine.Vector3Int position, UnityEngine.Object tile);
            /*0x3ee4cc0*/ void SetTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile);
            /*0x3ee4cc8*/ void SetTileAssets(UnityEngine.Vector3Int[] positionArray, UnityEngine.Object[] tileArray);
            /*0x3ee4e2c*/ void SetTiles(UnityEngine.Vector3Int[] positionArray, UnityEngine.Tilemaps.TileBase[] tileArray);
            /*0x3ee4e30*/ void INTERNAL_CALL_SetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions, UnityEngine.Object[] tileArray);
            /*0x3ee4f30*/ void SetTilesBlock(UnityEngine.BoundsInt position, UnityEngine.Tilemaps.TileBase[] tileArray);
            /*0x3ee4f78*/ void SetTile(UnityEngine.Tilemaps.TileChangeData tileChangeData, bool ignoreLockFlags);
            /*0x3ee505c*/ void SetTiles(UnityEngine.Tilemaps.TileChangeData[] tileChangeDataArray, bool ignoreLockFlags);
            /*0x3ee5140*/ bool HasTile(UnityEngine.Vector3Int position);
            /*0x3ee1de8*/ void RefreshTile(UnityEngine.Vector3Int position);
            /*0x3ee21c0*/ void RefreshTilesNative(void* positions, int count);
            /*0x3ee525c*/ void RefreshAllTiles();
            /*0x3ee5310*/ void SwapTileAsset(UnityEngine.Object changeTile, UnityEngine.Object newTile);
            /*0x3ee5438*/ void SwapTile(UnityEngine.Tilemaps.TileBase changeTile, UnityEngine.Tilemaps.TileBase newTile);
            /*0x3ee543c*/ bool ContainsTileAsset(UnityEngine.Object tileAsset);
            /*0x3ee5534*/ bool ContainsTile(UnityEngine.Tilemaps.TileBase tileAsset);
            /*0x3ee5538*/ int GetUsedTilesCount();
            /*0x3ee55ec*/ int GetUsedSpritesCount();
            /*0x3ee56a0*/ int GetUsedTilesNonAlloc(UnityEngine.Tilemaps.TileBase[] usedTiles);
            /*0x3ee5724*/ int GetUsedSpritesNonAlloc(UnityEngine.Sprite[] usedSprites);
            /*0x3ee56a4*/ int Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles);
            /*0x3ee5728*/ int Internal_GetUsedSpritesNonAlloc(UnityEngine.Object[] usedSprites);
            /*0x3ee5830*/ UnityEngine.Sprite GetSprite(UnityEngine.Vector3Int position);
            /*0x3ee5920*/ UnityEngine.Matrix4x4 GetTransformMatrix(UnityEngine.Vector3Int position);
            /*0x3ee5a28*/ void SetTransformMatrix(UnityEngine.Vector3Int position, UnityEngine.Matrix4x4 transform);
            /*0x3ee5b14*/ UnityEngine.Color GetColor(UnityEngine.Vector3Int position);
            /*0x3ee5c08*/ void SetColor(UnityEngine.Vector3Int position, UnityEngine.Color color);
            /*0x3ee5cf8*/ UnityEngine.Tilemaps.TileFlags GetTileFlags(UnityEngine.Vector3Int position);
            /*0x3ee5dcc*/ void SetTileFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags);
            /*0x3ee5eb8*/ void AddTileFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags);
            /*0x3ee5fa4*/ void RemoveTileFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags);
            /*0x3ee6090*/ UnityEngine.GameObject GetInstantiatedObject(UnityEngine.Vector3Int position);
            /*0x3ee6180*/ UnityEngine.GameObject GetObjectToInstantiate(UnityEngine.Vector3Int position);
            /*0x3ee6270*/ void SetColliderType(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.Tile.ColliderType colliderType);
            /*0x3ee635c*/ UnityEngine.Tilemaps.Tile.ColliderType GetColliderType(UnityEngine.Vector3Int position);
            /*0x3ee6430*/ int GetAnimationFrameCount(UnityEngine.Vector3Int position);
            /*0x3ee6504*/ int GetAnimationFrame(UnityEngine.Vector3Int position);
            /*0x3ee65d8*/ void SetAnimationFrame(UnityEngine.Vector3Int position, int frame);
            /*0x3ee66c4*/ float GetAnimationTime(UnityEngine.Vector3Int position);
            /*0x3ee6798*/ void SetAnimationTime(UnityEngine.Vector3Int position, float time);
            /*0x3ee688c*/ UnityEngine.Tilemaps.TileAnimationFlags GetTileAnimationFlags(UnityEngine.Vector3Int position);
            /*0x3ee6960*/ void SetTileAnimationFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags);
            /*0x3ee6a4c*/ void AddTileAnimationFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags);
            /*0x3ee6b38*/ void RemoveTileAnimationFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags);
            /*0x3ee6c24*/ void FloodFill(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile);
            /*0x3ee6c2c*/ void FloodFillTileAsset(UnityEngine.Vector3Int position, UnityEngine.Object tile);
            /*0x3ee6d4c*/ void BoxFill(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile, int startX, int startY, int endX, int endY);
            /*0x3ee6d54*/ void BoxFillTileAsset(UnityEngine.Vector3Int position, UnityEngine.Object tile, int startX, int startY, int endX, int endY);
            /*0x3ee6ed4*/ void InsertCells(UnityEngine.Vector3Int position, UnityEngine.Vector3Int insertCells);
            /*0x3ee6ee4*/ void InsertCells(UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers);
            /*0x3ee7000*/ void DeleteCells(UnityEngine.Vector3Int position, UnityEngine.Vector3Int deleteCells);
            /*0x3ee7010*/ void DeleteCells(UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers);
            /*0x3ee712c*/ void ClearAllTiles();
            /*0x3ee71e0*/ void ResizeBounds();
            /*0x3ee7294*/ void CompressTilemapBounds(bool keepEditorPreview);
            /*0x3ee7358*/ void CompressBounds();
            /*0x3ee7360*/ void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback);
            /*0x3ee73b8*/ void DoLoopEndedForTileAnimationCallback(int count, nint positionsIntPtr);
            /*0x3ee73bc*/ void GetSyncTileCallbackSettings(ref UnityEngine.Tilemaps.Tilemap.SyncTileCallbackSettings settings);
            /*0x3ee2dec*/ void SendAndClearSyncTileBuffer();
            /*0x3ee7498*/ void DoSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x3ee749c*/ void DoPositionsChangedCallback(int count, nint positionsIntPtr);

            enum Orientation
            {
                XY = 0,
                XZ = 1,
                YX = 2,
                YZ = 3,
                ZX = 4,
                ZY = 5,
                Custom = 6,
            }

            struct SyncTile
            {
                /*0x10*/ UnityEngine.Vector3Int m_Position;
                /*0x20*/ UnityEngine.Tilemaps.TileBase m_Tile;
                /*0x28*/ UnityEngine.Tilemaps.TileData m_TileData;
            }

            struct SyncTileCallbackSettings
            {
                /*0x10*/ bool hasSyncTileCallback;
                /*0x11*/ bool hasPositionsChangedCallback;
                /*0x12*/ bool isBufferSyncTile;
            }
        }

        enum TileFlags
        {
            None = 0,
            LockColor = 1,
            LockTransform = 2,
            InstantiateGameObjectRuntimeOnly = 4,
            KeepGameObjectRuntimeOnly = 8,
            LockAll = 3,
        }

        enum TileAnimationFlags
        {
            None = 0,
            LoopOnce = 1,
            PauseAnimation = 2,
            UpdatePhysics = 4,
            UnscaledTime = 8,
            SyncAnimation = 16,
        }

        class TilemapRenderer : UnityEngine.Renderer
        {
            static /*0x3ee765c*/ void OnSpriteAtlasRegistered_Injected(nint _unity_self, nint atlas);
            /*0x3ee74a8*/ void RegisterSpriteAtlasRegistered();
            /*0x3ee7528*/ void UnregisterSpriteAtlasRegistered();
            /*0x3ee75a8*/ void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas);
        }

        struct TileData
        {
            static /*0x0*/ UnityEngine.Tilemaps.TileData Default;
            /*0x10*/ int m_Sprite;
            /*0x14*/ UnityEngine.Color m_Color;
            /*0x24*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x64*/ int m_GameObject;
            /*0x68*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x6c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            static /*0x3ee774c*/ TileData();
            static /*0x3ee76a0*/ UnityEngine.Tilemaps.TileData CreateDefault();
            /*0x3ee2568*/ void set_sprite(UnityEngine.Sprite value);
            /*0x3ee25f8*/ void set_color(UnityEngine.Color value);
            /*0x3ee2604*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x3ee2620*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x3ee26b0*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x3ee26b8*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
        }

        struct TileDataNative
        {
            /*0x10*/ int m_Sprite;
            /*0x14*/ UnityEngine.Color m_Color;
            /*0x24*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x64*/ int m_GameObject;
            /*0x68*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x6c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;
        }

        struct TileChangeData
        {
            /*0x10*/ UnityEngine.Vector3Int m_Position;
            /*0x20*/ UnityEngine.Object m_TileAsset;
            /*0x28*/ UnityEngine.Color m_Color;
            /*0x38*/ UnityEngine.Matrix4x4 m_Transform;
        }

        struct TileAnimationData
        {
            /*0x10*/ UnityEngine.Sprite[] m_AnimatedSprites;
            /*0x18*/ float m_AnimationSpeed;
            /*0x1c*/ float m_AnimationStartTime;
            /*0x20*/ UnityEngine.Tilemaps.TileAnimationFlags m_Flags;
        }
    }
}
