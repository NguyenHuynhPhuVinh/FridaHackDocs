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

            static /*0x169d100*/ UnityEngine.Tilemaps.ITilemap CreateInstance();
            static /*0x169d180*/ void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint oldTilesIntPtr, nint newTilesIntPtr, nint positionsIntPtr);
            static /*0x169d510*/ void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint tilesIntPtr, nint positionsIntPtr, nint outTileDataIntPtr);
            /*0x32f970*/ ITilemap();
            /*0x169d7a0*/ UnityEngine.Tilemaps.TileBase GetTile(UnityEngine.Vector3Int position);
            /*0x169d870*/ void RefreshTile(UnityEngine.Vector3Int position);
            /*0x2a5510*/ T GetComponent<T>();
        }

        class Tile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x70*/ UnityEngine.GameObject m_InstancedGameObject;
            /*0x78*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x7c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            /*0x169e2a0*/ Tile();
            /*0x8b8f40*/ UnityEngine.Sprite get_sprite();
            /*0x7963c0*/ void set_sprite(UnityEngine.Sprite value);
            /*0x169e330*/ UnityEngine.Color get_color();
            /*0x12f4b90*/ void set_color(UnityEngine.Color value);
            /*0x169e340*/ UnityEngine.Matrix4x4 get_transform();
            /*0x169e370*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x1634690*/ UnityEngine.GameObject get_gameObject();
            /*0xe49c60*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x1628b80*/ UnityEngine.Tilemaps.TileFlags get_flags();
            /*0x12bba70*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x169e320*/ UnityEngine.Tilemaps.Tile.ColliderType get_colliderType();
            /*0x137d9f0*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
            /*0x169e140*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);

            enum ColliderType
            {
                None = 0,
                Sprite = 1,
                Grid = 2,
            }
        }

        class TileBase : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ TileBase();
            /*0x169dbb0*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x32d010*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x169dad0*/ UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x6a6020*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
            /*0x169da00*/ UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x169da90*/ void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData, ref bool hasAnimation);
            /*0x6a6020*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go);
            /*0x169dd50*/ void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, ref bool startUpInvokedByUser);
        }

        class Tilemap : UnityEngine.GridLayout
        {
            static /*0x0*/ System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> tilemapTileChanged;
            static /*0x8*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> tilemapPositionsChanged;
            /*0x18*/ bool m_BufferSyncTile;

            static /*0x169e9c0*/ bool HasSyncTileCallback();
            static /*0x169e980*/ bool HasPositionsChangedCallback();
            /*0x31c640*/ Tilemap();
            /*0x169ed30*/ bool get_bufferSyncTile();
            /*0x169e560*/ void HandleSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x169e4c0*/ void HandlePositionsChangedCallback(int count, nint positionsIntPtr);
            /*0x169ec50*/ void SendTilemapTileChangedCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x169eba0*/ void SendTilemapPositionsChangedCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x169e5c0*/ UnityEngine.Vector3 GetCellCenterWorld(UnityEngine.Vector3Int position);
            /*0x169ecf0*/ float get_animationFrameRate();
            /*0x169ed90*/ UnityEngine.Color get_color();
            /*0x169ef80*/ void set_color(UnityEngine.Color value);
            /*0x169eee0*/ UnityEngine.Vector3 get_tileAnchor();
            /*0x169ee30*/ UnityEngine.Matrix4x4 get_orientationMatrix();
            /*0x169e7e0*/ UnityEngine.Object GetTileAsset(UnityEngine.Vector3Int position);
            /*0x169e830*/ UnityEngine.Tilemaps.TileBase GetTile(UnityEngine.Vector3Int position);
            /*0x169ea00*/ bool HasTile(UnityEngine.Vector3Int position);
            /*0x169eaf0*/ void RefreshTile(UnityEngine.Vector3Int position);
            /*0x169eb40*/ void RefreshTilesNative(void* positions, int count);
            /*0x169e8f0*/ int GetUsedTilesCount();
            /*0x169e930*/ int GetUsedTilesNonAlloc(UnityEngine.Tilemaps.TileBase[] usedTiles);
            /*0x169e930*/ int Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles);
            /*0x169e700*/ void GetSyncTileCallbackSettings(ref UnityEngine.Tilemaps.Tilemap.SyncTileCallbackSettings settings);
            /*0x169e560*/ void DoSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x169e4c0*/ void DoPositionsChangedCallback(int count, nint positionsIntPtr);
            /*0x169ed40*/ void get_color_Injected(ref UnityEngine.Color ret);
            /*0x169ef30*/ void set_color_Injected(ref UnityEngine.Color value);
            /*0x169ee90*/ void get_tileAnchor_Injected(ref UnityEngine.Vector3 ret);
            /*0x169ede0*/ void get_orientationMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
            /*0x169e790*/ UnityEngine.Object GetTileAsset_Injected(ref UnityEngine.Vector3Int position);
            /*0x169eaa0*/ void RefreshTile_Injected(ref UnityEngine.Vector3Int position);

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
        }

        class TilemapRenderer : UnityEngine.Renderer
        {
            /*0x169e3e0*/ void RegisterSpriteAtlasRegistered();
            /*0x169e450*/ void UnregisterSpriteAtlasRegistered();
            /*0x169e390*/ void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas);
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

            static /*0x169dec0*/ TileData();
            static /*0x169dd90*/ UnityEngine.Tilemaps.TileData CreateDefault();
            /*0x169e090*/ void set_sprite(UnityEngine.Sprite value);
            /*0x1466650*/ void set_color(UnityEngine.Color value);
            /*0x169e120*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x169e000*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x137d9e0*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x137dab0*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
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

            /*0x792990*/ void set_animatedSprites(UnityEngine.Sprite[] value);
            /*0x14544b0*/ void set_animationSpeed(float value);
            /*0x1202470*/ void set_animationStartTime(float value);
            /*0xdcd9c0*/ void set_flags(UnityEngine.Tilemaps.TileAnimationFlags value);
        }

        class TilemapCollider2D : UnityEngine.Collider2D
        {
        }
    }
}
