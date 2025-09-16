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

            static /*0x7fcc2f0*/ UnityEngine.Tilemaps.ITilemap CreateInstance();
            static /*0x7fcc368*/ void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint oldTilesIntPtr, nint newTilesIntPtr, nint positionsIntPtr);
            static /*0x7fcc6d0*/ void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint tilesIntPtr, nint positionsIntPtr, nint outTileDataIntPtr);
            /*0x7fcc104*/ ITilemap();
            /*0x7fcc10c*/ void RefreshTile(UnityEngine.Vector3Int position);
        }

        class Tile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x70*/ UnityEngine.GameObject m_InstancedGameObject;
            /*0x78*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x7c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            /*0x7fccb40*/ Tile();
            /*0x7fcc8c8*/ UnityEngine.Sprite get_sprite();
            /*0x7fcc8d0*/ void set_sprite(UnityEngine.Sprite value);
            /*0x7fcc8d8*/ UnityEngine.Color get_color();
            /*0x7fcc8e4*/ void set_color(UnityEngine.Color value);
            /*0x7fcc8f0*/ UnityEngine.Matrix4x4 get_transform();
            /*0x7fcc904*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x7fcc918*/ UnityEngine.GameObject get_gameObject();
            /*0x7fcc920*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x7fcc928*/ UnityEngine.Tilemaps.TileFlags get_flags();
            /*0x7fcc930*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x7fcc938*/ UnityEngine.Tilemaps.Tile.ColliderType get_colliderType();
            /*0x7fcc940*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
            /*0x7fcc948*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);

            enum ColliderType
            {
                None = 0,
                Sprite = 1,
                Grid = 2,
            }
        }

        class TileBase : UnityEngine.ScriptableObject
        {
            /*0x7fccbb0*/ TileBase();
            /*0x7fccbb8*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x7fccbd0*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x7fccbd4*/ UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x7fccc20*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
            /*0x7fccc28*/ UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x7fccc6c*/ void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData, ref bool hasAnimation);
            /*0x7fccc94*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go);
            /*0x7fccc9c*/ void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, ref bool startUpInvokedByUser);
        }

        class Tilemap : UnityEngine.GridLayout
        {
            static /*0x0*/ System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> tilemapTileChanged;
            static /*0x8*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> tilemapPositionsChanged;
            static /*0x10*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> loopEndedForTileAnimation;
            /*0x18*/ bool m_BufferSyncTile;

            static /*0x7fccccc*/ bool HasLoopEndedForTileAnimationCallback();
            static /*0x7fccf00*/ bool HasSyncTileCallback();
            static /*0x7fccf50*/ bool HasPositionsChangedCallback();
            static /*0x7fcd314*/ void RefreshTile_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x7fcd358*/ void RefreshTilesNative_Injected(nint _unity_self, void* positions, int count);
            /*0x7fcccc4*/ bool get_bufferSyncTile();
            /*0x7fccd1c*/ void HandleLoopEndedForTileAnimationCallback(int count, nint positionsIntPtr);
            /*0x7fccddc*/ void SendLoopEndedForTileAnimationCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x7fccfa0*/ void HandleSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x7fcd130*/ void HandlePositionsChangedCallback(int count, nint positionsIntPtr);
            /*0x7fcd014*/ void SendTilemapTileChangedCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x7fcd1f0*/ void SendTilemapPositionsChangedCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x7fcc260*/ void RefreshTile(UnityEngine.Vector3Int position);
            /*0x7fcc640*/ void RefreshTilesNative(void* positions, int count);
            /*0x7fcd3ac*/ void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback);
            /*0x7fcd404*/ void DoLoopEndedForTileAnimationCallback(int count, nint positionsIntPtr);
            /*0x7fcd408*/ void GetSyncTileCallbackSettings(ref UnityEngine.Tilemaps.Tilemap.SyncTileCallbackSettings settings);
            /*0x7fcd4a8*/ void DoSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x7fcd4ac*/ void DoPositionsChangedCallback(int count, nint positionsIntPtr);

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
            static /*0x7fcd664*/ void OnSpriteAtlasRegistered_Injected(nint _unity_self, nint atlas);
            /*0x7fcd4b0*/ void RegisterSpriteAtlasRegistered();
            /*0x7fcd530*/ void UnregisterSpriteAtlasRegistered();
            /*0x7fcd5b0*/ void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas);
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

            static /*0x7fcd754*/ TileData();
            static /*0x7fcd6a8*/ UnityEngine.Tilemaps.TileData CreateDefault();
            /*0x7fcc9e8*/ void set_sprite(UnityEngine.Sprite value);
            /*0x7fcca78*/ void set_color(UnityEngine.Color value);
            /*0x7fcca84*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x7fccaa0*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x7fccb30*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x7fccb38*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
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
