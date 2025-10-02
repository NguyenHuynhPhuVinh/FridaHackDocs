class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x1116e50*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    class HexagonalRuleTile<T> : UnityEngine.HexagonalRuleTile
    {
        /*0x180fc0*/ HexagonalRuleTile();
        /*0x1803b0*/ System.Type get_m_NeighborType();
    }

    class HexagonalRuleTile : UnityEngine.RuleTile
    {
        static /*0x0*/ float[] m_CosAngleArr1;
        static /*0x8*/ float[] m_SinAngleArr1;
        static /*0x10*/ float[] m_CosAngleArr2;
        static /*0x18*/ float[] m_SinAngleArr2;
        static /*0x20*/ float m_TilemapToWorldYScale;
        /*0x40*/ bool m_FlatTop;

        static /*0x110ece0*/ HexagonalRuleTile();
        static /*0x110eb80*/ UnityEngine.Vector3 TilemapPositionToWorldPosition(UnityEngine.Vector3Int tilemapPosition);
        static /*0x110ec30*/ UnityEngine.Vector3Int WorldPositionToTilemapPosition(UnityEngine.Vector3 worldPosition);
        /*0x110f120*/ HexagonalRuleTile();
        /*0x3d7dd0*/ int get_m_RotationAngle();
        /*0x110e7e0*/ UnityEngine.Vector3Int GetOffsetPosition(UnityEngine.Vector3Int position, UnityEngine.Vector3Int offset);
        /*0x110e710*/ UnityEngine.Vector3Int GetOffsetPositionReverse(UnityEngine.Vector3Int position, UnityEngine.Vector3Int offset);
        /*0x110e860*/ UnityEngine.Vector3Int GetRotatedPosition(UnityEngine.Vector3Int position, int rotation);
        /*0x110e4c0*/ UnityEngine.Vector3Int GetMirroredPosition(UnityEngine.Vector3Int position, bool mirrorX, bool mirrorY);
    }

    class IsometricRuleTile<T> : UnityEngine.IsometricRuleTile
    {
        /*0x180fc0*/ IsometricRuleTile();
        /*0x1803b0*/ System.Type get_m_NeighborType();
    }

    class IsometricRuleTile : UnityEngine.RuleTile
    {
        /*0x110f170*/ IsometricRuleTile();
    }

    class RuleTile<T> : UnityEngine.RuleTile
    {
        /*0x180fc0*/ RuleTile();
        /*0x1803b0*/ System.Type get_m_NeighborType();
    }

    class RuleTile : UnityEngine.Tilemaps.TileBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Tilemaps.Tilemap, System.Collections.Generic.KeyValuePair<System.Collections.Generic.HashSet<UnityEngine.Tilemaps.TileBase>, System.Collections.Generic.HashSet<UnityEngine.Vector3Int>>> m_CacheTilemapsNeighborPositions;
        static /*0x8*/ UnityEngine.Tilemaps.TileBase[] m_AllocatedUsedTileArr;
        /*0x18*/ UnityEngine.Sprite m_DefaultSprite;
        /*0x20*/ UnityEngine.GameObject m_DefaultGameObject;
        /*0x28*/ UnityEngine.Tilemaps.Tile.ColliderType m_DefaultColliderType;
        /*0x30*/ System.Collections.Generic.List<UnityEngine.RuleTile.TilingRule> m_TilingRules;
        /*0x38*/ System.Collections.Generic.HashSet<UnityEngine.Vector3Int> m_NeighborPositions;

        static /*0x11158a0*/ RuleTile();
        static /*0x11129b0*/ float GetPerlinValue(UnityEngine.Vector3Int position, float scale, float offset);
        static /*0x1113220*/ bool IsTilemapUsedTilesChange(UnityEngine.Tilemaps.Tilemap tilemap, ref System.Collections.Generic.KeyValuePair<System.Collections.Generic.HashSet<UnityEngine.Tilemaps.TileBase>, System.Collections.Generic.HashSet<UnityEngine.Vector3Int>> hashSet);
        static /*0x1112080*/ System.Collections.Generic.KeyValuePair<System.Collections.Generic.HashSet<UnityEngine.Tilemaps.TileBase>, System.Collections.Generic.HashSet<UnityEngine.Vector3Int>> CachingTilemapNeighborPositions(UnityEngine.Tilemaps.Tilemap tilemap);
        static /*0x1113450*/ bool NeedRelease();
        static /*0x1113a10*/ void ReleaseDestroyedTilemapCacheData();
        /*0x11159c0*/ RuleTile();
        /*0x1115a90*/ System.Type get_m_NeighborType();
        /*0x1115af0*/ int get_m_RotationAngle();
        /*0x1115b00*/ int get_m_RotationCount();
        /*0x1115b30*/ System.Collections.Generic.HashSet<UnityEngine.Vector3Int> get_neighborPositions();
        /*0x1115040*/ void UpdateNeighborPositions();
        /*0x1114930*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject instantiatedGameObject);
        /*0x1112ca0*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
        /*0x1112a70*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
        /*0x11135f0*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
        /*0x1114290*/ bool RuleMatches(UnityEngine.RuleTile.TilingRule rule, UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Matrix4x4 transform);
        /*0x1111960*/ UnityEngine.Matrix4x4 ApplyRandomTransform(UnityEngine.RuleTile.TilingRuleOutput.Transform type, UnityEngine.Matrix4x4 original, float perlinScale, UnityEngine.Vector3Int position);
        /*0x1112530*/ System.Reflection.FieldInfo[] GetCustomFields(bool isOverrideInstance);
        /*0x1113c60*/ bool RuleMatch(int neighbor, UnityEngine.Tilemaps.TileBase other);
        /*0x1113fd0*/ bool RuleMatches(UnityEngine.RuleTile.TilingRule rule, UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, int angle, bool mirrorX);
        /*0x1113d60*/ bool RuleMatches(UnityEngine.RuleTile.TilingRule rule, UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, bool mirrorX, bool mirrorY);
        /*0x11129e0*/ UnityEngine.Vector3Int GetRotatedPosition(UnityEngine.Vector3Int position, int rotation);
        /*0x11128a0*/ UnityEngine.Vector3Int GetMirroredPosition(UnityEngine.Vector3Int position, bool mirrorX, bool mirrorY);
        /*0x1112940*/ UnityEngine.Vector3Int GetOffsetPosition(UnityEngine.Vector3Int position, UnityEngine.Vector3Int offset);
        /*0x11128e0*/ UnityEngine.Vector3Int GetOffsetPositionReverse(UnityEngine.Vector3Int position, UnityEngine.Vector3Int offset);

        class TilingRuleOutput
        {
            /*0x10*/ int m_Id;
            /*0x18*/ UnityEngine.Sprite[] m_Sprites;
            /*0x20*/ UnityEngine.GameObject m_GameObject;
            /*0x28*/ float m_MinAnimationSpeed;
            /*0x2c*/ float m_MaxAnimationSpeed;
            /*0x30*/ float m_PerlinScale;
            /*0x34*/ UnityEngine.RuleTile.TilingRuleOutput.OutputSprite m_Output;
            /*0x38*/ UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;
            /*0x3c*/ UnityEngine.RuleTile.TilingRuleOutput.Transform m_RandomTransform;

            /*0x1115b80*/ TilingRuleOutput();

            class Neighbor
            {
                static int This = 1;
                static int NotThis = 2;

                /*0x32f970*/ Neighbor();
            }

            enum Transform
            {
                Fixed = 0,
                Rotated = 1,
                MirrorX = 2,
                MirrorY = 3,
                MirrorXY = 4,
                RotatedMirror = 5,
            }

            enum OutputSprite
            {
                Single = 0,
                Random = 1,
                Animation = 2,
            }
        }

        class TilingRule : UnityEngine.RuleTile.TilingRuleOutput
        {
            /*0x40*/ System.Collections.Generic.List<int> m_Neighbors;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector3Int> m_NeighborPositions;
            /*0x50*/ UnityEngine.RuleTile.TilingRuleOutput.Transform m_RuleTransform;

            /*0x11163a0*/ TilingRule();
            /*0x1115cd0*/ UnityEngine.RuleTile.TilingRule Clone();
            /*0x1116250*/ System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, int> GetNeighbors();
            /*0x1115c00*/ void ApplyNeighbors(System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, int> dict);
            /*0x1115e70*/ UnityEngine.BoundsInt GetBounds();
        }

        class DontOverride : System.Attribute
        {
            /*0x534220*/ DontOverride();
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.RuleTile.<> <>9;
            static /*0x8*/ System.Func<System.Reflection.FieldInfo, bool> <>9__30_0;
            static /*0x10*/ System.Func<System.Reflection.FieldInfo, bool> <>9__30_1;
            static /*0x18*/ System.Func<System.Reflection.FieldInfo, bool> <>9__30_2;

            static /*0x1116d70*/ <>c();
            /*0x32f970*/ <>c();
            /*0x1116900*/ bool <GetCustomFields>b__30_0(System.Reflection.FieldInfo field);
            /*0x11169b0*/ bool <GetCustomFields>b__30_1(System.Reflection.FieldInfo field);
            /*0x1116a50*/ bool <GetCustomFields>b__30_2(System.Reflection.FieldInfo field);
        }

        class <>c__DisplayClass30_0
        {
            /*0x10*/ bool isOverrideInstance;

            /*0x32f970*/ <>c__DisplayClass30_0();
            /*0x1116b10*/ bool <GetCustomFields>b__3(System.Reflection.FieldInfo field);
        }
    }

    namespace Tilemaps
    {
        enum GridInformationType
        {
            Integer = 0,
            String = 1,
            Float = 2,
            Double = 3,
            UnityObject = 4,
            Color = 5,
        }

        class GridInformation : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.Tilemaps.GridInformation.GridInformationKey, UnityEngine.Tilemaps.GridInformation.GridInformationValue> m_PositionProperties;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Tilemaps.GridInformation.GridInformationKey> m_PositionIntKeys;
            /*0x30*/ System.Collections.Generic.List<int> m_PositionIntValues;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Tilemaps.GridInformation.GridInformationKey> m_PositionStringKeys;
            /*0x40*/ System.Collections.Generic.List<string> m_PositionStringValues;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Tilemaps.GridInformation.GridInformationKey> m_PositionFloatKeys;
            /*0x50*/ System.Collections.Generic.List<float> m_PositionFloatValues;
            /*0x58*/ System.Collections.Generic.List<UnityEngine.Tilemaps.GridInformation.GridInformationKey> m_PositionDoubleKeys;
            /*0x60*/ System.Collections.Generic.List<double> m_PositionDoubleValues;
            /*0x68*/ System.Collections.Generic.List<UnityEngine.Tilemaps.GridInformation.GridInformationKey> m_PositionObjectKeys;
            /*0x70*/ System.Collections.Generic.List<UnityEngine.Object> m_PositionObjectValues;
            /*0x78*/ System.Collections.Generic.List<UnityEngine.Tilemaps.GridInformation.GridInformationKey> m_PositionColorKeys;
            /*0x80*/ System.Collections.Generic.List<UnityEngine.Color> m_PositionColorValues;

            /*0x110e160*/ GridInformation();
            /*0x61a260*/ System.Collections.Generic.Dictionary<UnityEngine.Tilemaps.GridInformation.GridInformationKey, UnityEngine.Tilemaps.GridInformation.GridInformationValue> get_PositionProperties();
            /*0x110d940*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x110d0e0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x2a5510*/ bool SetPositionProperty<T>(UnityEngine.Vector3Int position, string name, T positionProperty);
            /*0x110cdf0*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, int positionProperty);
            /*0x110cf30*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, string positionProperty);
            /*0x110ccb0*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, float positionProperty);
            /*0x110ce90*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, double positionProperty);
            /*0x110cc70*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, UnityEngine.Object positionProperty);
            /*0x110cd50*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, UnityEngine.Color positionProperty);
            /*0x110cf70*/ bool SetPositionProperty(UnityEngine.Vector3Int position, string name, UnityEngine.Tilemaps.GridInformationType dataType, object positionProperty);
            /*0x2a5510*/ T GetPositionProperty<T>(UnityEngine.Vector3Int position, string name, T defaultValue);
            /*0x110c7b0*/ int GetPositionProperty(UnityEngine.Vector3Int position, string name, int defaultValue);
            /*0x110c640*/ string GetPositionProperty(UnityEngine.Vector3Int position, string name, string defaultValue);
            /*0x110caa0*/ float GetPositionProperty(UnityEngine.Vector3Int position, string name, float defaultValue);
            /*0x110c920*/ double GetPositionProperty(UnityEngine.Vector3Int position, string name, double defaultValue);
            /*0x110c4c0*/ UnityEngine.Color GetPositionProperty(UnityEngine.Vector3Int position, string name, UnityEngine.Color defaultValue);
            /*0x110c1d0*/ bool ErasePositionProperty(UnityEngine.Vector3Int position, string name);
            /*0x110cc20*/ void Reset();
            /*0x110c290*/ UnityEngine.Vector3Int[] GetAllPositions(string propertyName);

            struct GridInformationValue
            {
                /*0x10*/ UnityEngine.Tilemaps.GridInformationType type;
                /*0x18*/ object data;
            }

            struct GridInformationKey : System.IEquatable<UnityEngine.Tilemaps.GridInformation.GridInformationKey>
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x20*/ string name;

                /*0x110c070*/ bool Equals(UnityEngine.Tilemaps.GridInformation.GridInformationKey key);
                /*0x110c0e0*/ int GetHashCode();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Tilemaps.GridInformation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Tilemaps.GridInformation.GridInformationKey, UnityEngine.Vector3Int> <>9__35_1;

                static /*0x1116d00*/ <>c();
                /*0x32f970*/ <>c();
                /*0x9970f0*/ UnityEngine.Vector3Int <GetAllPositions>b__35_1(UnityEngine.Tilemaps.GridInformation.GridInformationKey x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ string propertyName;

                /*0x32f970*/ <>c__DisplayClass35_0();
                /*0x1116ba0*/ bool <GetAllPositions>b__0(UnityEngine.Tilemaps.GridInformation.GridInformationKey x);
            }
        }

        class AnimatedTile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.Sprite[] m_AnimatedSprites;
            /*0x20*/ float m_MinSpeed;
            /*0x24*/ float m_MaxSpeed;
            /*0x28*/ float m_AnimationStartTime;
            /*0x2c*/ int m_AnimationStartFrame;
            /*0x30*/ UnityEngine.Tilemaps.Tile.ColliderType m_TileColliderType;
            /*0x34*/ UnityEngine.Tilemaps.TileAnimationFlags m_TileAnimationFlags;

            /*0x110c050*/ AnimatedTile();
            /*0x110bed0*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x110bd60*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
        }

        class AdvancedRuleOverrideTile : UnityEngine.Tilemaps.RuleOverrideTile
        {
            /*0x38*/ UnityEngine.Sprite m_DefaultSprite;
            /*0x40*/ UnityEngine.GameObject m_DefaultGameObject;
            /*0x48*/ UnityEngine.Tilemaps.Tile.ColliderType m_DefaultColliderType;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.RuleTile.TilingRuleOutput> m_OverrideTilingRules;

            /*0x110b970*/ AdvancedRuleOverrideTile();
            /*0x110ba90*/ UnityEngine.RuleTile.TilingRuleOutput get_Item(UnityEngine.RuleTile.TilingRule originalRule);
            /*0x110bbe0*/ void set_Item(UnityEngine.RuleTile.TilingRule originalRule, UnityEngine.RuleTile.TilingRuleOutput value);
            /*0x110b010*/ void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.RuleTile.TilingRule, UnityEngine.RuleTile.TilingRuleOutput>> overrides);
            /*0x110b290*/ void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.RuleTile.TilingRule, UnityEngine.RuleTile.TilingRuleOutput>> overrides, ref int validCount);
            /*0x110b7a0*/ void Override();

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.RuleTile.TilingRuleOutput overrideRule;

                /*0x32f970*/ <>c__DisplayClass8_0();
                /*0x1116ca0*/ bool <GetOverrides>b__0(System.Collections.Generic.KeyValuePair<UnityEngine.RuleTile.TilingRule, UnityEngine.RuleTile.TilingRuleOutput> o);
            }
        }

        class RuleOverrideTile : UnityEngine.Tilemaps.TileBase
        {
            /*0x18*/ UnityEngine.RuleTile m_Tile;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Tilemaps.RuleOverrideTile.TileSpritePair> m_Sprites;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Tilemaps.RuleOverrideTile.TileGameObjectPair> m_GameObjects;
            /*0x30*/ UnityEngine.RuleTile m_InstanceTile;

            /*0x1110ee0*/ RuleOverrideTile();
            /*0x1111110*/ UnityEngine.Sprite get_Item(UnityEngine.Sprite originalSprite);
            /*0x11115f0*/ void set_Item(UnityEngine.Sprite originalSprite, UnityEngine.Sprite value);
            /*0x1110fa0*/ UnityEngine.GameObject get_Item(UnityEngine.GameObject originalGameObject);
            /*0x1111280*/ void set_Item(UnityEngine.GameObject originalGameObject, UnityEngine.GameObject value);
            /*0x110f6c0*/ void CreateInstanceTile();
            /*0x110f1c0*/ void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.Sprite, UnityEngine.Sprite>> overrides);
            /*0x110f440*/ void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, UnityEngine.GameObject>> overrides);
            /*0x110f7b0*/ void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Sprite, UnityEngine.Sprite>> overrides, ref int validCount);
            /*0x110fe20*/ void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, UnityEngine.GameObject>> overrides, ref int validCount);
            /*0x11106a0*/ void Override();
            /*0x1110a20*/ void PrepareOverride();
            /*0x1110460*/ bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData);
            /*0x1110530*/ void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData);
            /*0x1110d60*/ void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap);
            /*0x1110e10*/ bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go);
            /*0x1110600*/ void OnEnable();

            class TileSpritePair
            {
                /*0x10*/ UnityEngine.Sprite m_OriginalSprite;
                /*0x18*/ UnityEngine.Sprite m_OverrideSprite;

                /*0x32f970*/ TileSpritePair();
            }

            class TileGameObjectPair
            {
                /*0x10*/ UnityEngine.GameObject m_OriginalGameObject;
                /*0x18*/ UnityEngine.GameObject m_OverrideGameObject;

                /*0x32f970*/ TileGameObjectPair();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Tilemaps.RuleOverrideTile.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, System.Reflection.FieldInfo> <>9__18_0;

                static /*0x1116de0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x718e40*/ System.Reflection.FieldInfo <PrepareOverride>b__18_0(System.Reflection.FieldInfo field);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.RuleTile tempTile;

                /*0x32f970*/ <>c__DisplayClass18_0();
                /*0x1116ad0*/ object <PrepareOverride>b__1(System.Reflection.FieldInfo field);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Sprite originalSprite;

                /*0x32f970*/ <>c__DisplayClass4_0();
                /*0x1116bc0*/ bool <set_Item>b__0(UnityEngine.Tilemaps.RuleOverrideTile.TileSpritePair spritePair);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.GameObject originalGameObject;

                /*0x32f970*/ <>c__DisplayClass7_0();
                /*0x1116c30*/ bool <set_Item>b__0(UnityEngine.Tilemaps.RuleOverrideTile.TileGameObjectPair gameObjectPair);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 08D3A694AF11DD92BAB03BA6846ACA5201BFFAC728BA2C4B8A80D8E3F60A81E9;
    static /*0x2fc*/ <PrivateImplementationDetails> B8796AE0C7C95839AC6CA14EAA7C612637C77C18D6DB8A3A523A9AC324AD493C;

    struct __StaticArrayInitTypeSize=764
    {
    }

    struct __StaticArrayInitTypeSize=778
    {
    }
}
