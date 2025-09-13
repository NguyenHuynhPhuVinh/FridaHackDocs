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

            static /*0x2b349a0*/ UnityEngine.Tilemaps.ITilemap CreateInstance();
            /*0x2b34924*/ ITilemap();
            /*0x2b3492c*/ void RefreshTile(UnityEngine.Vector3Int position);
        }

        class Tile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x70*/ UnityEngine.GameObject m_InstancedGameObject;
            /*0x78*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x7c*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            /*0x2b34b18*/ Tile();
            /*0x2b34a0c*/ UnityEngine.Sprite get_sprite();
            /*0x2b34a14*/ void set_sprite(UnityEngine.Sprite value);
            /*0x2b34a1c*/ UnityEngine.Color get_color();
            /*0x2b34a28*/ void set_color(UnityEngine.Color value);
            /*0x2b34a34*/ UnityEngine.Matrix4x4 get_transform();
            /*0x2b34a48*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0x2b34a5c*/ UnityEngine.GameObject get_gameObject();
            /*0x2b34a64*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x2b34a6c*/ UnityEngine.Tilemaps.TileFlags get_flags();
            /*0x2b34a74*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0x2b34a7c*/ UnityEngine.Tilemaps.Tile.ColliderType get_colliderType();
            /*0x2b34a84*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
            /*0x2b34a8c*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);

            enum ColliderType
            {
                None = 0,
                Sprite = 1,
                Grid = 2,
            }
        }

        class TileBase : UnityEngine.ScriptableObject
        {
            /*0x2b34b8c*/ TileBase();
            /*0x2b34b94*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x2b34bb0*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x2b34bb4*/ UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x2b34c38*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
            /*0x2b34c40*/ UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x2b34c74*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go);
        }

        class Tilemap : UnityEngine.GridLayout
        {
            /*0x2b34948*/ void RefreshTile(UnityEngine.Vector3Int position);
            /*0x2b34c7c*/ void RefreshTile_Injected(ref UnityEngine.Vector3Int position);
        }

        enum TileFlags
        {
            None = 0,
            LockColor = 1,
            LockTransform = 2,
            InstantiateGameObjectRuntimeOnly = 4,
            LockAll = 3,
        }

        class TilemapRenderer : UnityEngine.Renderer
        {
            /*0x2b34ccc*/ void RegisterSpriteAtlasRegistered();
            /*0x2b34d88*/ void UnregisterSpriteAtlasRegistered();
            /*0x2b34e44*/ void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas);
        }

        struct TileData
        {
            /*0x10*/ UnityEngine.Sprite m_Sprite;
            /*0x18*/ UnityEngine.Color m_Color;
            /*0x28*/ UnityEngine.Matrix4x4 m_Transform;
            /*0x68*/ UnityEngine.GameObject m_GameObject;
            /*0x70*/ UnityEngine.Tilemaps.TileFlags m_Flags;
            /*0x74*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;

            /*0xb793a8*/ void set_sprite(UnityEngine.Sprite value);
            /*0xb793b0*/ void set_color(UnityEngine.Color value);
            /*0xb793bc*/ void set_transform(UnityEngine.Matrix4x4 value);
            /*0xb793d8*/ void set_gameObject(UnityEngine.GameObject value);
            /*0xb793e0*/ void set_flags(UnityEngine.Tilemaps.TileFlags value);
            /*0xb793e8*/ void set_colliderType(UnityEngine.Tilemaps.Tile.ColliderType value);
        }

        struct TileAnimationData
        {
            /*0x10*/ UnityEngine.Sprite[] m_AnimatedSprites;
            /*0x18*/ float m_AnimationSpeed;
            /*0x1c*/ float m_AnimationStartTime;
        }
    }
}
