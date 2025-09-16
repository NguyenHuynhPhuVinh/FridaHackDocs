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

            static /*0x7fb4ec0*/ UnityEngine.Tilemaps.ITilemap CreateInstance();
            static /*0x7fb4f38*/ void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint oldTilesIntPtr, nint newTilesIntPtr, nint positionsIntPtr);
            static /*0x7fb52a0*/ void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, int count, nint tilesIntPtr, nint positionsIntPtr, nint outTileDataIntPtr);
            /*0x7fb4cd4*/ ITilemap();
            /*0x7fb4cdc*/ void RefreshTile(UnityEngine.Vector3Int position);
        }

        class Tile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x70*/ UnityEngine.GameObject m_InstancedGameObject;
            /*0x78*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x7c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            /*0x7fb5710*/ Tile();
            /*0x7fb5498*/ UnityEngine.Sprite get_sprite();
            /*0x7fb54a0*/ void set_sprite(UnityEngine.Sprite value);
            /*0x7fb54a8*/ UnityEngine.Color get_color();
            /*0x7fb54b4*/ void set_color(UnityEngine.Color value);
            /*0x7fb54c0*/ UnityEngine.Matrix4x4 get_transform();
            /*0x7fb54d4*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x7fb54e8*/ UnityEngine.GameObject get_gameObject();
            /*0x7fb54f0*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x7fb54f8*/ UnityEngine.Tilemaps.TileFlags get_flags();
            /*0x7fb5500*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x7fb5508*/ UnityEngine.Tilemaps.Tile.ColliderType get_colliderType();
            /*0x7fb5510*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
            /*0x7fb5518*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);

            enum ColliderType
            {
                None = 0,
                Sprite = 1,
                Grid = 2,
            }
        }

        class TileBase : UnityEngine.ScriptableObject
        {
            /*0x7fb5780*/ TileBase();
            /*0x7fb5788*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x7fb57a0*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x7fb57a4*/ UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x7fb57f0*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
            /*0x7fb57f8*/ UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x7fb583c*/ void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData, ref bool hasAnimation);
            /*0x7fb5864*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go);
            /*0x7fb586c*/ void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, ref bool startUpInvokedByUser);
        }

        class Tilemap : UnityEngine.GridLayout
        {
            static /*0x0*/ System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> tilemapTileChanged;
            static /*0x8*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> tilemapPositionsChanged;
            static /*0x10*/ System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> loopEndedForTileAnimation;
            /*0x18*/ bool m_BufferSyncTile;

            static /*0x7fb589c*/ bool HasLoopEndedForTileAnimationCallback();
            static /*0x7fb5ad0*/ bool HasSyncTileCallback();
            static /*0x7fb5b20*/ bool HasPositionsChangedCallback();
            static /*0x7fb5ee4*/ void RefreshTile_Injected(nint _unity_self, ref UnityEngine.Vector3Int position);
            static /*0x7fb5f28*/ void RefreshTilesNative_Injected(nint _unity_self, void* positions, int count);
            /*0x7fb5894*/ bool get_bufferSyncTile();
            /*0x7fb58ec*/ void HandleLoopEndedForTileAnimationCallback(int count, nint positionsIntPtr);
            /*0x7fb59ac*/ void SendLoopEndedForTileAnimationCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x7fb5b70*/ void HandleSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x7fb5d00*/ void HandlePositionsChangedCallback(int count, nint positionsIntPtr);
            /*0x7fb5be4*/ void SendTilemapTileChangedCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x7fb5dc0*/ void SendTilemapPositionsChangedCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions);
            /*0x7fb4e30*/ void RefreshTile(UnityEngine.Vector3Int position);
            /*0x7fb5210*/ void RefreshTilesNative(void* positions, int count);
            /*0x7fb5f7c*/ void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback);
            /*0x7fb5fd4*/ void DoLoopEndedForTileAnimationCallback(int count, nint positionsIntPtr);
            /*0x7fb5fd8*/ void GetSyncTileCallbackSettings(ref UnityEngine.Tilemaps.Tilemap.SyncTileCallbackSettings settings);
            /*0x7fb6078*/ void DoSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles);
            /*0x7fb607c*/ void DoPositionsChangedCallback(int count, nint positionsIntPtr);

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
            static /*0x7fb6234*/ void OnSpriteAtlasRegistered_Injected(nint _unity_self, nint atlas);
            /*0x7fb6080*/ void RegisterSpriteAtlasRegistered();
            /*0x7fb6100*/ void UnregisterSpriteAtlasRegistered();
            /*0x7fb6180*/ void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas);
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

            static /*0x7fb6324*/ TileData();
            static /*0x7fb6278*/ UnityEngine.Tilemaps.TileData CreateDefault();
            /*0x7fb55b8*/ void set_sprite(UnityEngine.Sprite value);
            /*0x7fb5648*/ void set_color(UnityEngine.Color value);
            /*0x7fb5654*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x7fb5670*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x7fb5700*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x7fb5708*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
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
