class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3e9e70c*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x3e9e714*/ NullableAttribute(byte );
                /*0x3e9e79c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3e9e7cc*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace UnityEngine
{
    namespace TextCore
    {
        struct NativeTextGenerationSettings
        {
            /*0x10*/ nint fontAsset;
            /*0x18*/ nint textSettings;
            /*0x20*/ string text;
            /*0x28*/ int screenWidth;
            /*0x2c*/ int screenHeight;
            /*0x30*/ UnityEngine.TextCore.WhiteSpace wordWrap;
            /*0x34*/ UnityEngine.TextCore.TextOverflow overflow;
            /*0x38*/ UnityEngine.TextCore.LanguageDirection languageDirection;
            /*0x3c*/ int vertexPadding;
            /*0x40*/ UnityEngine.TextCore.HorizontalAlignment horizontalAlignment;
            /*0x44*/ UnityEngine.TextCore.VerticalAlignment verticalAlignment;
            /*0x48*/ int fontSize;
            /*0x4c*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
            /*0x50*/ UnityEngine.TextCore.Text.TextFontWeight fontWeight;
            /*0x58*/ UnityEngine.TextCore.TextSpan[] textSpans;
            /*0x60*/ UnityEngine.Color32 color;
            /*0x64*/ int characterSpacing;
            /*0x68*/ int wordSpacing;
            /*0x6c*/ int paragraphSpacing;

            static /*0x3e9e92c*/ UnityEngine.TextCore.NativeTextGenerationSettings get_Default();
            /*0x3e9e7f4*/ bool get_hasLink();
            /*0x3e9e908*/ UnityEngine.TextCore.TextSpan CreateTextSpan();
            /*0x3e9e978*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.TextCore.NativeTextGenerationSettings.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.TextCore.TextSpan> <>9__20_0;

                static /*0x3e9f728*/ <>c();
                /*0x3e9f790*/ <>c();
                /*0x3e9f798*/ bool <get_hasLink>b__20_0(UnityEngine.TextCore.TextSpan span);
            }
        }

        struct TextSpan
        {
            /*0x10*/ int startIndex;
            /*0x14*/ int length;
            /*0x18*/ nint fontAsset;
            /*0x20*/ int fontSize;
            /*0x24*/ UnityEngine.Color32 color;
            /*0x28*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
            /*0x2c*/ UnityEngine.TextCore.Text.TextFontWeight fontWeight;
            /*0x30*/ int linkID;

            /*0x3e9f344*/ string ToString();
        }

        enum HorizontalAlignment
        {
            Left = 0,
            Center = 1,
            Right = 2,
            Justified = 3,
        }

        enum VerticalAlignment
        {
            Top = 0,
            Middle = 1,
            Bottom = 2,
        }

        enum LanguageDirection
        {
            LTR = 0,
            RTL = 1,
        }

        enum WhiteSpace
        {
            Normal = 0,
            NoWrap = 1,
            Pre = 2,
            PreWrap = 3,
        }

        enum TextOverflow
        {
            Clip = 0,
            Ellipsis = 1,
        }

        class RichTextTagParser
        {
            static /*0x0*/ UnityEngine.TextCore.RichTextTagParser.TagTypeInfo[] TagsInfo;

            static /*0x3ea202c*/ RichTextTagParser();
            static /*0x3e9f7a8*/ bool tagMatch(System.ReadOnlySpan<char> tagCandidate, string tagName);
            static /*0x3e9f8d0*/ bool SpanToEnum(System.ReadOnlySpan<char> tagCandidate, ref UnityEngine.TextCore.RichTextTagParser.TagType tagType, ref string error, ref System.ReadOnlySpan<char> attribute);
            static /*0x3e9fb78*/ System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> FindTags(string inputStr, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.ParseError> errors);
            static /*0x3ea06a0*/ System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> PickResultingTags(System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> allTags, string input, int atPosition, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> applicableTags);
            static /*0x3ea13a0*/ UnityEngine.TextCore.RichTextTagParser.Segment[] GenerateSegments(string input, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags);
            static /*0x3ea15b8*/ void ApplyStateToSegment(string input, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags, UnityEngine.TextCore.RichTextTagParser.Segment[] segments);
            static /*0x3ea1698*/ int AddLink(UnityEngine.TextCore.RichTextTagParser.TagType type, string value, System.Collections.Generic.List<System.ValueTuple<int, UnityEngine.TextCore.RichTextTagParser.TagType, string>> links);
            static /*0x3ea18fc*/ UnityEngine.TextCore.TextSpan CreateTextSpan(UnityEngine.TextCore.RichTextTagParser.Segment segment, ref UnityEngine.TextCore.NativeTextGenerationSettings tgs, System.Collections.Generic.List<System.ValueTuple<int, UnityEngine.TextCore.RichTextTagParser.TagType, string>> links, UnityEngine.Color hyperlinkColor);
            static /*0x3ea1d24*/ void CreateTextGenerationSettingsArray(ref UnityEngine.TextCore.NativeTextGenerationSettings tgs, System.Collections.Generic.List<System.ValueTuple<int, UnityEngine.TextCore.RichTextTagParser.TagType, string>> links, UnityEngine.Color hyperlinkColor);

            enum TagType
            {
                Hyperlink = 0,
                Align = 1,
                AllCaps = 2,
                Alpha = 3,
                Bold = 4,
                Br = 5,
                Color = 6,
                CSpace = 7,
                Font = 8,
                FontWeight = 9,
                Italic = 10,
                Indent = 11,
                LineHeight = 12,
                LineIndent = 13,
                Link = 14,
                Lowercase = 15,
                Mark = 16,
                Mspace = 17,
                NoBr = 18,
                NoParse = 19,
                Strikethrough = 20,
                Size = 21,
                SmallCaps = 22,
                Space = 23,
                Sprite = 24,
                Style = 25,
                Subscript = 26,
                Superscript = 27,
                Underline = 28,
                Uppercase = 29,
                Unknown = 30,
            }

            class TagTypeInfo : System.IEquatable<UnityEngine.TextCore.RichTextTagParser.TagTypeInfo>
            {
                /*0x10*/ UnityEngine.TextCore.RichTextTagParser.TagType TagType;
                /*0x18*/ string name;
                /*0x20*/ UnityEngine.TextCore.RichTextTagParser.TagValueType valueType;
                /*0x24*/ UnityEngine.TextCore.RichTextTagParser.TagUnitType unitType;

                /*0x3ea2eec*/ TagTypeInfo(UnityEngine.TextCore.RichTextTagParser.TagType tagType, string name, UnityEngine.TextCore.RichTextTagParser.TagValueType valueType, UnityEngine.TextCore.RichTextTagParser.TagUnitType unitType);
                /*0x3ea2f3c*/ System.Type get_EqualityContract();
                /*0x3ea2f9c*/ string ToString();
                /*0x3ea3084*/ bool PrintMembers(System.Text.StringBuilder builder);
                /*0x3ea324c*/ int GetHashCode();
                /*0x3ea33c4*/ bool Equals(object obj);
                /*0x3ea344c*/ bool Equals(UnityEngine.TextCore.RichTextTagParser.TagTypeInfo other);
            }

            enum TagValueType
            {
                None = 0,
                NumericalValue = 1,
                StringValue = 2,
                ColorValue = 4,
            }

            enum TagUnitType
            {
                Pixels = 0,
                FontUnits = 1,
                Percentage = 2,
            }

            class TagValue : System.IEquatable<UnityEngine.TextCore.RichTextTagParser.TagValue>
            {
                /*0x10*/ UnityEngine.TextCore.RichTextTagParser.TagValueType type;
                /*0x18*/ string m_stringValue;
                /*0x20*/ float m_numericalValue;
                /*0x24*/ UnityEngine.Color m_colorValue;

                /*0x3ea0620*/ TagValue(UnityEngine.Color value);
                /*0x3ea0668*/ TagValue(string value);
                /*0x3ea35e0*/ System.Type get_EqualityContract();
                /*0x3ea1cc4*/ string get_StringValue();
                /*0x3ea1c60*/ UnityEngine.Color get_ColorValue();
                /*0x3ea3640*/ string ToString();
                /*0x3ea3728*/ bool PrintMembers(System.Text.StringBuilder builder);
                /*0x3ea3730*/ int GetHashCode();
                /*0x3ea38ac*/ bool Equals(object obj);
                /*0x3ea3934*/ bool Equals(UnityEngine.TextCore.RichTextTagParser.TagValue other);
            }

            struct Tag
            {
                /*0x10*/ UnityEngine.TextCore.RichTextTagParser.TagType tagType;
                /*0x14*/ bool isClosing;
                /*0x18*/ int start;
                /*0x1c*/ int end;
                /*0x20*/ UnityEngine.TextCore.RichTextTagParser.TagValue value;
            }

            struct Segment
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags;
                /*0x18*/ int start;
                /*0x1c*/ int end;
            }

            class ParseError : System.IEquatable<UnityEngine.TextCore.RichTextTagParser.ParseError>
            {
                /*0x10*/ int position;
                /*0x18*/ string message;

                /*0x3ea05e4*/ ParseError(string message, int position);
                /*0x3ea3ad0*/ System.Type get_EqualityContract();
                /*0x3ea3b30*/ string ToString();
                /*0x3ea3c18*/ bool PrintMembers(System.Text.StringBuilder builder);
                /*0x3ea3cd0*/ int GetHashCode();
                /*0x3ea3dc8*/ bool Equals(object obj);
                /*0x3ea3e50*/ bool Equals(UnityEngine.TextCore.RichTextTagParser.ParseError other);
            }
        }

        namespace Text
        {
            struct ATGMeshInfo
            {
                /*0x10*/ UnityEngine.TextCore.Text.NativeTextElementInfo[] textElementInfos;
                /*0x18*/ int fontAssetId;
                /*0x1c*/ int textElementCount;
                /*0x20*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x28*/ System.Collections.Generic.List<System.Collections.Generic.List<int>> textElementInfoIndicesByAtlas;
                /*0x30*/ bool hasMultipleColors;
            }

            class Character : UnityEngine.TextCore.Text.TextElement
            {
                /*0x3ea3f74*/ Character();
                /*0x3ea3fa0*/ Character(uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
                /*0x3ea403c*/ Character(uint unicode, uint glyphIndex);
            }

            class ColorUtilities
            {
                static /*0x3ea40b8*/ bool CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b);
                static /*0x3ea40c8*/ UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
            }

            class FastAction
            {
                /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

                /*0x3ea41ac*/ FastAction();
            }

            class FastAction<A>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
                /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

                /*0x1f309e4*/ FastAction();
            }

            class FastAction<A, B>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
                /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

                /*0x1f309e4*/ FastAction();
                /*0x1ffc854*/ void Call(A a, B b);
            }

            class FastAction<A, B, C>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
                /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

                /*0x1f309e4*/ FastAction();
            }

            enum OTL_FeatureTag
            {
                kern = 1801810542,
                liga = 1818847073,
                mark = 1835102827,
                mkmk = 1835756907,
            }

            class FontFeatureTable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords;
                /*0x38*/ System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup;
                /*0x40*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;
                /*0x48*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup;
                /*0x50*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup;

                /*0x3ea42a0*/ FontFeatureTable();
                /*0x3ea4288*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
                /*0x3ea4290*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords();
                /*0x3ea4298*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords();
                /*0x3ea4554*/ void SortGlyphPairAdjustmentRecords();
                /*0x3ea4760*/ void SortMarkToBaseAdjustmentRecords();
                /*0x3ea4978*/ void SortMarkToMarkAdjustmentRecords();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontFeatureTable.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__24_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__24_1;
                    static /*0x18*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__25_0;
                    static /*0x20*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__25_1;
                    static /*0x28*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__26_0;
                    static /*0x30*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__26_1;

                    static /*0x3ea4b90*/ <>c();
                    /*0x3ea4bf8*/ <>c();
                    /*0x3ea4c00*/ uint <SortGlyphPairAdjustmentRecords>b__24_0(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x3ea4c48*/ uint <SortGlyphPairAdjustmentRecords>b__24_1(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x3ea4c90*/ uint <SortMarkToBaseAdjustmentRecords>b__25_0(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s);
                    /*0x3ea4c9c*/ uint <SortMarkToBaseAdjustmentRecords>b__25_1(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s);
                    /*0x3ea4ca8*/ uint <SortMarkToMarkAdjustmentRecords>b__26_0(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s);
                    /*0x3ea4cb4*/ uint <SortMarkToMarkAdjustmentRecords>b__26_1(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s);
                }
            }

            struct Extents
            {
                /*0x10*/ UnityEngine.Vector2 min;
                /*0x18*/ UnityEngine.Vector2 max;

                /*0x3ea4cc0*/ string ToString();
            }

            struct LineInfo
            {
                /*0x10*/ int controlCharacterCount;
                /*0x14*/ int characterCount;
                /*0x18*/ int visibleCharacterCount;
                /*0x1c*/ int visibleSpaceCount;
                /*0x20*/ int spaceCount;
                /*0x24*/ int wordCount;
                /*0x28*/ int firstCharacterIndex;
                /*0x2c*/ int firstVisibleCharacterIndex;
                /*0x30*/ int lastCharacterIndex;
                /*0x34*/ int lastVisibleCharacterIndex;
                /*0x38*/ float length;
                /*0x3c*/ float lineHeight;
                /*0x40*/ float ascender;
                /*0x44*/ float baseline;
                /*0x48*/ float descender;
                /*0x4c*/ float maxAdvance;
                /*0x50*/ float width;
                /*0x54*/ float marginLeft;
                /*0x58*/ float marginRight;
                /*0x5c*/ UnityEngine.TextCore.Text.TextAlignment alignment;
                /*0x60*/ UnityEngine.TextCore.Text.Extents lineExtents;
            }

            struct LinkInfo
            {
                /*0x10*/ int hashCode;
                /*0x14*/ int linkIdFirstCharacterIndex;
                /*0x18*/ int linkIdLength;
                /*0x1c*/ int linkTextfirstCharacterIndex;
                /*0x20*/ int linkTextLength;
                /*0x28*/ char[] linkId;
                /*0x30*/ string m_LinkIdString;
                /*0x38*/ string m_LinkTextString;

                /*0x3ea4ee8*/ void SetLinkId(char[] text, int startIndex, int length);
                /*0x3ea4ff8*/ string GetLinkText(UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ea50f0*/ string GetLinkId();
            }

            class MaterialManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<long, UnityEngine.Material> s_FallbackMaterials;

                static /*0x3ea5a50*/ MaterialManager();
                static /*0x3ea5148*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
                static /*0x3ea580c*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
                static /*0x3ea5584*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);
            }

            struct MaterialReference
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x20*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x28*/ UnityEngine.Material material;
                /*0x30*/ bool isFallbackMaterial;
                /*0x38*/ UnityEngine.Material fallbackMaterial;
                /*0x40*/ float padding;
                /*0x44*/ int referenceCount;

                static /*0x3ea5b60*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                static /*0x3ea5d68*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                /*0x3ea5ae8*/ MaterialReference(int index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
            }

            class MaterialReferenceManager
            {
                static /*0x0*/ UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance;
                /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup;
                /*0x28*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup;

                static /*0x3ea5f74*/ UnityEngine.TextCore.Text.MaterialReferenceManager get_instance();
                static /*0x3ea617c*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3ea629c*/ void AddSpriteAsset(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x3ea63bc*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
                static /*0x3ea645c*/ void AddColorGradientPreset(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                static /*0x3ea652c*/ bool TryGetFontAsset(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3ea65e0*/ bool TryGetSpriteAsset(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x3ea6694*/ bool TryGetColorGradientPreset(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                static /*0x3ea6748*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
                /*0x3ea5ff8*/ MaterialReferenceManager();
                /*0x3ea619c*/ void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x3ea62cc*/ void AddSpriteAssetInternal(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x3ea63ec*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
                /*0x3ea648c*/ void AddColorGradientPreset_Internal(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                /*0x3ea655c*/ bool TryGetFontAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x3ea6610*/ bool TryGetSpriteAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x3ea66c4*/ bool TryGetColorGradientPresetInternal(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                /*0x3ea6778*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
            }

            struct MeshInfoBindings
            {
                /*0x10*/ UnityEngine.TextCore.Text.TextCoreVertex[] vertexData;
                /*0x18*/ UnityEngine.Material material;
                /*0x20*/ int vertexCount;
            }

            struct MeshInfo
            {
                /*0x10*/ int vertexCount;
                /*0x18*/ UnityEngine.TextCore.Text.TextCoreVertex[] vertexData;
                /*0x20*/ UnityEngine.Material material;
                /*0x28*/ int vertexBufferSize;
                /*0x2c*/ bool applySDF;
                /*0x30*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode;

                /*0x3ea67fc*/ MeshInfo(int size, bool isIMGUI);
                /*0x3ea68c4*/ void ResizeMeshInfo(int size, bool isIMGUI);
                /*0x3ea6938*/ void Clear(bool uploadChanges);
                /*0x3ea6978*/ void ClearUnusedVertices();
            }

            struct NativeTextElementInfo
            {
                /*0x10*/ int glyphID;
                /*0x14*/ UnityEngine.TextCore.Text.TextCoreVertex bottomLeft;
                /*0x34*/ UnityEngine.TextCore.Text.TextCoreVertex topLeft;
                /*0x54*/ UnityEngine.TextCore.Text.TextCoreVertex topRight;
                /*0x74*/ UnityEngine.TextCore.Text.TextCoreVertex bottomRight;
            }

            struct NativeTextInfo
            {
                /*0x10*/ UnityEngine.TextCore.Text.ATGMeshInfo[] meshInfos;
            }

            enum TextFontWeight
            {
                Thin = 100,
                ExtraLight = 200,
                Light = 300,
                Regular = 400,
                Medium = 500,
                SemiBold = 600,
                Bold = 700,
                Heavy = 800,
                Black = 900,
            }

            struct FontWeightPair
            {
                /*0x10*/ UnityEngine.TextCore.Text.FontAsset regularTypeface;
                /*0x18*/ UnityEngine.TextCore.Text.FontAsset italicTypeface;
            }

            struct FontAssetCreationEditorSettings
            {
                /*0x10*/ string sourceFontFileGUID;
                /*0x18*/ int faceIndex;
                /*0x1c*/ int pointSizeSamplingMode;
                /*0x20*/ float pointSize;
                /*0x24*/ int padding;
                /*0x28*/ int paddingMode;
                /*0x2c*/ int packingMode;
                /*0x30*/ int atlasWidth;
                /*0x34*/ int atlasHeight;
                /*0x38*/ int characterSetSelectionMode;
                /*0x40*/ string characterSequence;
                /*0x48*/ string referencedFontAssetGUID;
                /*0x50*/ string referencedTextAssetGUID;
                /*0x58*/ int fontStyle;
                /*0x5c*/ float fontStyleModifier;
                /*0x60*/ int renderMode;
                /*0x64*/ bool includeFontFeatures;
            }

            enum AtlasPopulationMode
            {
                Static = 0,
                Dynamic = 1,
                DynamicOS = 2,
            }

            class FontAsset : UnityEngine.TextCore.Text.TextAsset
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> kFontAssetByInstanceId;
                static /*0x8*/ System.Collections.Generic.List<System.WeakReference<UnityEngine.TextCore.Text.FontAsset>> s_CallbackInstances;
                static /*0x10*/ Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
                static /*0x18*/ Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
                static /*0x20*/ Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker;
                static /*0x28*/ Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
                static /*0x30*/ Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
                static /*0x38*/ Unity.Profiling.ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker;
                static /*0x40*/ Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
                static /*0x48*/ Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;
                static /*0x50*/ Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
                static /*0x58*/ Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
                static /*0x60*/ string s_DefaultMaterialSuffix;
                static /*0x68*/ System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
                static /*0x70*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
                static /*0x78*/ System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
                static /*0x80*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_KerningUpdateQueue;
                static /*0x88*/ System.Collections.Generic.HashSet<int> k_FontAssets_KerningUpdateQueueLookup;
                static /*0x90*/ System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;
                static /*0x98*/ System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
                static /*0xa0*/ uint[] k_GlyphIndexArray;
                static /*0xa8*/ System.Collections.Generic.HashSet<int> visitedFontAssets;
                /*0x38*/ string m_SourceFontFileGUID;
                /*0x40*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;
                /*0x98*/ UnityEngine.Font m_SourceFontFile;
                /*0xa0*/ string m_SourceFontFilePath;
                /*0xa8*/ UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode;
                /*0xac*/ bool InternalDynamicOS;
                /*0xad*/ bool IsEditorFont;
                /*0xb0*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
                /*0x110*/ int m_FamilyNameHashCode;
                /*0x114*/ int m_StyleNameHashCode;
                /*0x118*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;
                /*0x120*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
                /*0x128*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharacterTable;
                /*0x130*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> m_CharacterLookupDictionary;
                /*0x138*/ UnityEngine.Texture2D m_AtlasTexture;
                /*0x140*/ UnityEngine.Texture2D[] m_AtlasTextures;
                /*0x148*/ int m_AtlasTextureIndex;
                /*0x14c*/ bool m_IsMultiAtlasTexturesEnabled;
                /*0x14d*/ bool m_GetFontFeatures;
                /*0x14e*/ bool m_ClearDynamicDataOnBuild;
                /*0x150*/ int m_AtlasWidth;
                /*0x154*/ int m_AtlasHeight;
                /*0x158*/ int m_AtlasPadding;
                /*0x15c*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
                /*0x160*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
                /*0x168*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
                /*0x170*/ UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable;
                /*0x178*/ bool m_ShouldReimportFontFeatures;
                /*0x180*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable;
                /*0x188*/ UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable;
                /*0x190*/ float m_RegularStyleWeight;
                /*0x194*/ float m_RegularStyleSpacing;
                /*0x198*/ float m_BoldStyleWeight;
                /*0x19c*/ float m_BoldStyleSpacing;
                /*0x1a0*/ byte m_ItalicStyleSlant;
                /*0x1a1*/ byte m_TabMultiple;
                /*0x1a2*/ bool IsFontAssetLookupTablesDirty;
                /*0x1a8*/ nint m_NativeFontAsset;
                /*0x1b0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
                /*0x1b8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
                /*0x1c0*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
                /*0x1c8*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
                /*0x1d0*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
                /*0x1d8*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
                /*0x1e0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd;
                /*0x1e8*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
                /*0x1f0*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
                /*0x1f8*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;
                /*0x200*/ System.Collections.Generic.Dictionary<System.ValueTuple<uint, uint>, uint> m_VariantGlyphIndexes;
                /*0x208*/ bool m_IsClone;

                static /*0x3eb324c*/ FontAsset();
                static /*0x1f36244*/ void EnsureAdditionalCapacity<T>(System.Collections.Generic.List<T> container, int additionalCapacity);
                static /*0x1f36244*/ void EnsureAdditionalCapacity<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> container, int additionalCapacity);
                static /*0x3ea7428*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, int pointSize);
                static /*0x3ea7628*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize);
                static /*0x3ea78d0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode);
                static /*0x3ea79c8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> CreateFontAssetOSFallbackList(string[] fallbacksFamilyNames, int pointSize);
                static /*0x3ea7c90*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetWithOSFallbackList(string[] fallbacksFamilyNames, int pointSize);
                static /*0x3ea7b28*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize);
                static /*0x3ea7f04*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight);
                static /*0x3ea7710*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x3ea8554*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font);
                static /*0x3ea85d0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x3ea8690*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x3ea7fb8*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x3ea89e4*/ UnityEngine.TextCore.Text.FontAsset GetFontAssetByID(int id);
                static /*0x1f370c8*/ void InitializeLookup<T>(System.Collections.ICollection source, ref System.Collections.Generic.Dictionary<uint, T> lookup, int defaultCapacity);
                static /*0x1f370c8*/ void InitializeList<T>(System.Collections.ICollection source, ref System.Collections.Generic.List<T> list, int defaultCapacity);
                static /*0x3eacbe4*/ string GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3eacce0*/ int[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3eada70*/ void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3eadb5c*/ void RegisterFontAssetForKerningUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3eadc48*/ void UpdateFontFeaturesForFontAssetsInQueue();
                static /*0x3eae040*/ void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture);
                static /*0x3eae12c*/ void UpdateAtlasTexturesInQueue();
                static /*0x3eae2cc*/ void UpdateFontAssetsInUpdateQueue();
                static /*0x3eb2d44*/ void CreateHbFaceIfNeeded();
                static /*0x3eb2510*/ void UpdateFallbacks(nint ptr, nint[] fallbacks);
                static /*0x3eb2694*/ void UpdateWeightFallbacks(nint ptr, nint[] regularFallbacks, nint[] italicFallbacks);
                static /*0x3eb2164*/ nint Create(UnityEngine.TextCore.FaceInfo faceInfo, UnityEngine.Font sourceFontFile, UnityEngine.Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, nint[] fallbacks, nint[] weightFallbacks, nint[] italicFallbacks);
                static /*0x3eb2868*/ void UpdateFaceInfo(nint ptr, UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x3ea8fb8*/ void Destroy(nint ptr);
                static /*0x3eb2d6c*/ void UpdateFallbacks_Injected(nint ptr, ref UnityEngine.Bindings.ManagedSpanWrapper fallbacks);
                static /*0x3eb2db0*/ void UpdateWeightFallbacks_Injected(nint ptr, ref UnityEngine.Bindings.ManagedSpanWrapper regularFallbacks, ref UnityEngine.Bindings.ManagedSpanWrapper italicFallbacks);
                static /*0x3eb2e04*/ nint Create_Injected(ref UnityEngine.TextCore.FaceInfo faceInfo, nint sourceFontFile, nint sourceFont_EditorRef, ref UnityEngine.Bindings.ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref UnityEngine.Bindings.ManagedSpanWrapper fallbacks, ref UnityEngine.Bindings.ManagedSpanWrapper weightFallbacks, ref UnityEngine.Bindings.ManagedSpanWrapper italicFallbacks);
                static /*0x3eb2e90*/ void UpdateFaceInfo_Injected(nint ptr, ref UnityEngine.TextCore.FaceInfo faceInfo);
                /*0x3eb2ed4*/ FontAsset();
                /*0x3ea69c0*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings();
                /*0x3ea69d0*/ void set_fontAssetCreationEditorSettings(UnityEngine.TextCore.Text.FontAssetCreationEditorSettings value);
                /*0x3ea69f4*/ UnityEngine.Font get_sourceFontFile();
                /*0x3ea69fc*/ void set_sourceFontFile(UnityEngine.Font value);
                /*0x3ea6a04*/ UnityEngine.TextCore.Text.AtlasPopulationMode get_atlasPopulationMode();
                /*0x3ea6a0c*/ void set_atlasPopulationMode(UnityEngine.TextCore.Text.AtlasPopulationMode value);
                /*0x3ea6a14*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x3ea6a24*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x3ea6a48*/ int get_familyNameHashCode();
                /*0x3ea6a78*/ void set_familyNameHashCode(int value);
                /*0x3ea6a80*/ int get_styleNameHashCode();
                /*0x3ea6ab0*/ void set_styleNameHashCode(int value);
                /*0x3ea6ab8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
                /*0x3ea6ac0*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
                /*0x3ea6ad0*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
                /*0x3ea71ec*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable();
                /*0x3ea71f4*/ void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value);
                /*0x3ea7204*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> get_characterLookupTable();
                /*0x3ea7228*/ UnityEngine.Texture2D get_atlasTexture();
                /*0x3ea72bc*/ UnityEngine.Texture2D[] get_atlasTextures();
                /*0x3ea72c4*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
                /*0x3ea72d4*/ int get_atlasTextureCount();
                /*0x3ea72e0*/ bool get_isMultiAtlasTexturesEnabled();
                /*0x3ea72e8*/ void set_isMultiAtlasTexturesEnabled(bool value);
                /*0x3ea72f0*/ bool get_getFontFeatures();
                /*0x3ea72f8*/ void set_getFontFeatures(bool value);
                /*0x3ea7300*/ bool get_clearDynamicDataOnBuild();
                /*0x3ea7308*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x3ea7310*/ int get_atlasWidth();
                /*0x3ea7318*/ void set_atlasWidth(int value);
                /*0x3ea7320*/ int get_atlasHeight();
                /*0x3ea7328*/ void set_atlasHeight(int value);
                /*0x3ea7330*/ int get_atlasPadding();
                /*0x3ea7338*/ void set_atlasPadding(int value);
                /*0x3ea7340*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
                /*0x3ea7348*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
                /*0x3ea7350*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
                /*0x3ea7358*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x3ea7368*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
                /*0x3ea7370*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x3ea7380*/ UnityEngine.TextCore.Text.FontFeatureTable get_fontFeatureTable();
                /*0x3ea7388*/ void set_fontFeatureTable(UnityEngine.TextCore.Text.FontFeatureTable value);
                /*0x3ea7398*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable();
                /*0x3ea73a0*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x3ea73b0*/ UnityEngine.TextCore.Text.FontWeightPair[] get_fontWeightTable();
                /*0x3ea73b8*/ void set_fontWeightTable(UnityEngine.TextCore.Text.FontWeightPair[] value);
                /*0x3ea73c8*/ float get_regularStyleWeight();
                /*0x3ea73d0*/ void set_regularStyleWeight(float value);
                /*0x3ea73d8*/ float get_regularStyleSpacing();
                /*0x3ea73e0*/ void set_regularStyleSpacing(float value);
                /*0x3ea73e8*/ float get_boldStyleWeight();
                /*0x3ea73f0*/ void set_boldStyleWeight(float value);
                /*0x3ea73f8*/ float get_boldStyleSpacing();
                /*0x3ea7400*/ void set_boldStyleSpacing(float value);
                /*0x3ea7408*/ byte get_italicStyleSlant();
                /*0x3ea7410*/ void set_italicStyleSlant(byte value);
                /*0x3ea7418*/ byte get_tabMultiple();
                /*0x3ea7420*/ void set_tabMultiple(byte value);
                /*0x3ea8a7c*/ void RegisterCallbackInstance(UnityEngine.TextCore.Text.FontAsset instance);
                /*0x3ea8d48*/ void OnDestroy();
                /*0x3ea6af4*/ void ReadFontAssetDefinition();
                /*0x3ea8ff4*/ void InitializeDictionaryLookupTables();
                /*0x3ea921c*/ void InitializeGlyphLookupDictionary();
                /*0x3ea94f8*/ void InitializeCharacterLookupDictionary();
                /*0x3eaa518*/ void ClearFallbackCharacterTable();
                /*0x3ea98f0*/ void InitializeLigatureSubstitutionLookupDictionary();
                /*0x3ea9cbc*/ void InitializeGlyphPairAdjustmentRecordsLookupDictionary();
                /*0x3ea9fc0*/ void InitializeMarkToBaseAdjustmentRecordsLookupDictionary();
                /*0x3eaa26c*/ void InitializeMarkToMarkAdjustmentRecordsLookupDictionary();
                /*0x3ea904c*/ void AddSynthesizedCharactersAndFaceMetrics();
                /*0x3eaabc0*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
                /*0x3eab490*/ void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character);
                /*0x3eab49c*/ void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x3eab554*/ bool GetCharacterInLookupCache(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref UnityEngine.TextCore.Text.Character character);
                /*0x3eab610*/ void RemoveCharacterInLookupCache(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x3eab6c0*/ bool ContainsCharacterInLookupCache(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x3eab434*/ uint CreateCompositeKey(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x3eaaa40*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace();
                /*0x3eab774*/ void SortCharacterTable();
                /*0x3eab8c8*/ void SortGlyphTable();
                /*0x3eaba1c*/ void SortFontFeatureTable();
                /*0x3eaba50*/ void SortAllTables();
                /*0x3eaba70*/ bool HasCharacter(int character);
                /*0x3eabae8*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
                /*0x3eabaf0*/ bool HasCharacter(uint character, bool searchFallbacks, bool tryAddCharacter);
                /*0x3eac3f4*/ bool HasCharacterWithStyle_Internal(uint character, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, bool searchFallbacks, bool tryAddCharacter);
                /*0x3eac1b4*/ bool HasCharacter_Internal(uint character, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, bool searchFallbacks, bool tryAddCharacter);
                /*0x3eac3f8*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
                /*0x3eac684*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
                /*0x3eacb0c*/ bool HasCharacters(string text);
                /*0x3eacdd0*/ uint GetGlyphIndex(uint unicode);
                /*0x3eacde8*/ uint GetGlyphIndex(uint unicode, ref bool success);
                /*0x3eacf1c*/ uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode);
                /*0x3eacfa8*/ void UpdateFontAssetData();
                /*0x3ead7b4*/ void ClearFontAssetData(bool setAtlasSizeToZero);
                /*0x3eada4c*/ void ClearCharacterAndGlyphTablesInternal();
                /*0x3ead0d8*/ void ClearCharacterAndGlyphTables();
                /*0x3ead3b4*/ void ClearFontFeaturesTables();
                /*0x3ead5a4*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
                /*0x3ea8eb0*/ void DestroyAtlasTextures();
                /*0x3ead798*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
                /*0x3eae31c*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
                /*0x3eaf988*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
                /*0x3eaf9a4*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
                /*0x3eafb44*/ bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex);
                /*0x3eafc0c*/ bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, ref uint variantGlyphIndex);
                /*0x3eafcd0*/ bool TryAddGlyphInternal(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph);
                /*0x3eb023c*/ bool TryAddCharacterInternal(uint unicode, ref UnityEngine.TextCore.Text.Character character);
                /*0x3eabe3c*/ bool TryAddCharacterInternal(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref UnityEngine.TextCore.Text.Character character, bool populateLigatures);
                /*0x3eafe78*/ bool TryAddGlyphToAtlas(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph, bool populateLigatures);
                /*0x3eb0378*/ bool TryAddGlyphToTexture(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph, bool populateLigatures);
                /*0x3eaf504*/ bool TryAddGlyphsToNewAtlasTexture();
                /*0x3eb05d8*/ void SetupNewAtlasTexture();
                /*0x3eb0250*/ UnityEngine.TextCore.Text.Character CreateCharacterAndAddToCache(uint unicode, UnityEngine.TextCore.Glyph glyph, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x3eaf8d4*/ void UpdateFontFeaturesForNewlyAddedGlyphs();
                /*0x3eadf9c*/ void UpdateGlyphAdjustmentRecordsForNewGlyphs();
                /*0x3eadef0*/ void UpdateGPOSFontFeaturesForNewlyAddedGlyphs();
                /*0x3ea9800*/ void ImportFontFeatures();
                /*0x3eb0894*/ void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex);
                /*0x3eb0918*/ void UpdateLigatureSubstitutionRecords();
                /*0x3eb1494*/ void AddLigatureSubstitutionRecords(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] records);
                /*0x3eb0990*/ void UpdateGlyphAdjustmentRecords();
                /*0x3eb0b78*/ void AddPairAdjustmentRecords(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] records);
                /*0x3eb0a08*/ void UpdateDiacriticalMarkAdjustmentRecords();
                /*0x3eb0e60*/ void AddMarkToBaseAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] records);
                /*0x3eb1174*/ void AddMarkToMarkAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] records);
                /*0x3eb18f8*/ nint get_nativeFontAsset();
                /*0x3eb1910*/ void EnsureNativeFontAssetIsCreated();
                /*0x3eb249c*/ void UpdateFallbacks();
                /*0x3eb2614*/ void UpdateWeightFallbacks();
                /*0x3eb27d8*/ void UpdateFaceInfo();
                /*0x3eb1a4c*/ nint[] GetFallbacks();
                /*0x3eb28ec*/ bool HasRecursion(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x3eb2980*/ bool HasRecursionInternal(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x3eb1e80*/ System.ValueTuple<System.IntPtr[], System.IntPtr[]> GetWeightFallbacks();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.Character, uint> <>9__189_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__190_0;

                    static /*0x3eb3754*/ <>c();
                    /*0x3eb37bc*/ <>c();
                    /*0x3eb37c4*/ uint <SortCharacterTable>b__189_0(UnityEngine.TextCore.Text.Character c);
                    /*0x3eb37dc*/ uint <SortGlyphTable>b__190_0(UnityEngine.TextCore.Glyph c);
                }
            }

            class FontAssetFactory
            {
                static /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.TextCore.Text.FontAsset> visitedFontAssets;

                static /*0x3eb39a8*/ FontAssetFactory();
                static /*0x3eb37f4*/ UnityEngine.TextCore.Text.FontAsset ConvertFontToFontAsset(UnityEngine.Font font);
                static /*0x3eb3908*/ void SetupFontAssetSettings(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3ea7e48*/ void SetHideFlags(UnityEngine.TextCore.Text.FontAsset fontAsset);
            }

            class FontAssetUtilities
            {
                static /*0x0*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;

                static /*0x3eb3a40*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x3eb3b58*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x3eb40c8*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAssetsInternal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> OSFallbackList, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x3eb4230*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAssetsInternal(uint unicode, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x3eb4404*/ UnityEngine.TextCore.Text.TextElement GetTextElementFromTextAssets(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> textAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x3eb4890*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
                static /*0x3eb46d4*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
                static /*0x3eac584*/ uint GetCodePoint(string text, ref int index);
                static /*0x3eaf404*/ uint GetCodePoint(uint[] codesPoints, ref int index);
            }

            class SpriteAsset : UnityEngine.TextCore.Text.TextAsset
            {
                /*0x38*/ System.Collections.Generic.Dictionary<int, int> m_NameLookup;
                /*0x40*/ System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
                /*0x48*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
                /*0xa8*/ UnityEngine.Texture m_SpriteAtlasTexture;
                /*0xb0*/ float <width>k__BackingField;
                /*0xb4*/ float <height>k__BackingField;
                /*0xb8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable;
                /*0xc0*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup;
                /*0xc8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable;
                /*0xd0*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets;
                /*0xe0*/ bool m_IsSpriteAssetLookupTablesDirty;

                static /*0x3ecb134*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x3ecb29c*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                static /*0x3ecb42c*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                static /*0x3ecb4f0*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings);
                static /*0x3ecb7e8*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                static /*0x3ecb97c*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                /*0x3ecbcfc*/ SpriteAsset();
                /*0x3eca8e4*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x3eca8f4*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x3eca918*/ UnityEngine.Texture get_spriteSheet();
                /*0x3eca920*/ void set_spriteSheet(UnityEngine.Texture value);
                /*0x3eca984*/ float get_width();
                /*0x3eca98c*/ void set_width(float value);
                /*0x3eca994*/ float get_height();
                /*0x3eca99c*/ void set_height(float value);
                /*0x3eca9a4*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable();
                /*0x3ecaf60*/ void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x3ecaf68*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable();
                /*0x3ecaf8c*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x3ecaf94*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable();
                /*0x3ecaf9c*/ void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value);
                /*0x3ecafa4*/ void Awake();
                /*0x3eca9c8*/ void UpdateLookupTables();
                /*0x3ecafd0*/ int GetSpriteIndexFromHashcode(int hashCode);
                /*0x3ecb05c*/ int GetSpriteIndexFromUnicode(uint unicode);
                /*0x3ecb0f4*/ int GetSpriteIndexFromName(string name);
                /*0x3ecba40*/ void SortGlyphTable();
                /*0x3ecbb90*/ void SortCharacterTable();
                /*0x3ecbce4*/ void SortGlyphAndCharacterTables();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.SpriteAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.SpriteGlyph, uint> <>9__44_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Text.SpriteCharacter, uint> <>9__45_0;

                    static /*0x3ecbde4*/ <>c();
                    /*0x3ecbe4c*/ <>c();
                    /*0x3ecbe54*/ uint <SortGlyphTable>b__44_0(UnityEngine.TextCore.Text.SpriteGlyph item);
                    /*0x3ecbe6c*/ uint <SortCharacterTable>b__45_0(UnityEngine.TextCore.Text.SpriteCharacter c);
                }
            }

            class SpriteCharacter : UnityEngine.TextCore.Text.TextElement
            {
                /*0x30*/ string m_Name;

                /*0x3ecbe80*/ SpriteCharacter();
                /*0x3ecafc0*/ string get_name();
            }

            class SpriteGlyph : UnityEngine.TextCore.Glyph
            {
                /*0x48*/ UnityEngine.Sprite sprite;

                /*0x3ecbea8*/ SpriteGlyph();
            }

            class TextAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ string m_Version;
                /*0x20*/ int m_InstanceID;
                /*0x24*/ int m_HashCode;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ int m_MaterialHashCode;

                /*0x3ecbddc*/ TextAsset();
                /*0x3ecbeb0*/ string get_version();
                /*0x3ecbeb8*/ void set_version(string value);
                /*0x3ecbec0*/ int get_instanceID();
                /*0x3ecbee8*/ int get_hashCode();
                /*0x3ecbf18*/ void set_hashCode(int value);
                /*0x3ecbf20*/ UnityEngine.Material get_material();
                /*0x3ecbf28*/ void set_material(UnityEngine.Material value);
                /*0x3ecbf30*/ int get_materialHashCode();
                /*0x3ecbfc8*/ void set_materialHashCode(int value);
            }

            enum ColorGradientMode
            {
                Single = 0,
                HorizontalGradient = 1,
                VerticalGradient = 2,
                FourCornersGradient = 3,
            }

            class TextColorGradient : UnityEngine.ScriptableObject
            {
                static UnityEngine.TextCore.Text.ColorGradientMode k_DefaultColorMode = 3;
                static /*0x0*/ UnityEngine.Color k_DefaultColor;
                /*0x18*/ UnityEngine.TextCore.Text.ColorGradientMode colorMode;
                /*0x1c*/ UnityEngine.Color topLeft;
                /*0x2c*/ UnityEngine.Color topRight;
                /*0x3c*/ UnityEngine.Color bottomLeft;
                /*0x4c*/ UnityEngine.Color bottomRight;

                static /*0x3ecc17c*/ TextColorGradient();
                /*0x3ecbfd0*/ TextColorGradient();
                /*0x3ecc06c*/ TextColorGradient(UnityEngine.Color color);
                /*0x3ecc0d8*/ TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
            }

            class TextSettings : UnityEngine.ScriptableObject
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> s_FallbackOSFontAssetInternal;
                static /*0x8*/ UnityEngine.TextCore.Text.SpriteAsset <s_GlobalSpriteAsset>k__BackingField;
                /*0x18*/ string m_Version;
                /*0x20*/ UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset;
                /*0x28*/ string m_DefaultFontAssetPath;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets;
                /*0x38*/ bool m_MatchMaterialPreset;
                /*0x3c*/ int m_MissingCharacterUnicode;
                /*0x40*/ bool m_ClearDynamicDataOnBuild;
                /*0x41*/ bool m_EnableEmojiSupport;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> m_EmojiFallbackTextAssets;
                /*0x50*/ UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;
                /*0x58*/ string m_DefaultSpriteAssetPath;
                /*0x60*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets;
                /*0x68*/ uint m_MissingSpriteCharacterUnicode;
                /*0x70*/ UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet;
                /*0x78*/ string m_StyleSheetsResourcePath;
                /*0x80*/ string m_DefaultColorGradientPresetsPath;
                /*0x88*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules;
                /*0x90*/ bool m_DisplayWarnings;
                /*0x98*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontLookup;
                /*0xa0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences;
                /*0xa8*/ nint m_NativeTextSettings;
                /*0xb0*/ bool m_IsNativeTextSettingsDirty;

                static /*0x3ecc414*/ void set_s_GlobalSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value);
                static /*0x3ecc464*/ UnityEngine.TextCore.Text.SpriteAsset get_s_GlobalSpriteAsset();
                static /*0x3eccc64*/ nint CreateNativeObject(nint[] fallbacks);
                static /*0x3ecc70c*/ void DestroyNativeObject(nint m_NativeTextSettings);
                static /*0x3eccd70*/ void UpdateFallbacks(nint ptr, nint[] fallbacks);
                static /*0x3eccd34*/ nint CreateNativeObject_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper fallbacks);
                static /*0x3ecce48*/ void UpdateFallbacks_Injected(nint ptr, ref UnityEngine.Bindings.ManagedSpanWrapper fallbacks);
                /*0x3ecd114*/ TextSettings();
                /*0x3ecc1c8*/ string get_version();
                /*0x3ecc1d0*/ void set_version(string value);
                /*0x3ecc1d8*/ UnityEngine.TextCore.Text.FontAsset get_defaultFontAsset();
                /*0x3ecc1e0*/ void set_defaultFontAsset(UnityEngine.TextCore.Text.FontAsset value);
                /*0x3ecc1e8*/ string get_defaultFontAssetPath();
                /*0x3ecc1f0*/ void set_defaultFontAssetPath(string value);
                /*0x3ecc1f8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets();
                /*0x3ecc200*/ void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x3ecc224*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackOSFontAssets();
                /*0x3ecc2d0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset();
                /*0x3ecc318*/ void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets);
                /*0x3ecc370*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetFallbackFontAssets(int textPixelSize);
                /*0x3ecc378*/ bool get_matchMaterialPreset();
                /*0x3ecc380*/ void set_matchMaterialPreset(bool value);
                /*0x3ecc388*/ int get_missingCharacterUnicode();
                /*0x3ecc390*/ void set_missingCharacterUnicode(int value);
                /*0x3ecc398*/ bool get_clearDynamicDataOnBuild();
                /*0x3ecc3a0*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x3ecc3a8*/ bool get_enableEmojiSupport();
                /*0x3ecc3b0*/ void set_enableEmojiSupport(bool value);
                /*0x3ecc3b8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> get_emojiFallbackTextAssets();
                /*0x3ecc3c0*/ void set_emojiFallbackTextAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> value);
                /*0x3ecc3e4*/ UnityEngine.TextCore.Text.SpriteAsset get_defaultSpriteAsset();
                /*0x3ecc3ec*/ void set_defaultSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value);
                /*0x3ecc3f4*/ string get_defaultSpriteAssetPath();
                /*0x3ecc3fc*/ void set_defaultSpriteAssetPath(string value);
                /*0x3ecc404*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets();
                /*0x3ecc40c*/ void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value);
                /*0x3ecc4ac*/ uint get_missingSpriteCharacterUnicode();
                /*0x3ecc4b4*/ void set_missingSpriteCharacterUnicode(uint value);
                /*0x3ecc4bc*/ UnityEngine.TextCore.Text.TextStyleSheet get_defaultStyleSheet();
                /*0x3ecc4c4*/ void set_defaultStyleSheet(UnityEngine.TextCore.Text.TextStyleSheet value);
                /*0x3ecc4cc*/ string get_styleSheetsResourcePath();
                /*0x3ecc4d4*/ void set_styleSheetsResourcePath(string value);
                /*0x3ecc4dc*/ string get_defaultColorGradientPresetsPath();
                /*0x3ecc4e4*/ void set_defaultColorGradientPresetsPath(string value);
                /*0x3ecc4ec*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules get_lineBreakingRules();
                /*0x3ecc570*/ void set_lineBreakingRules(UnityEngine.TextCore.Text.UnicodeLineBreakingRules value);
                /*0x3ecc578*/ bool get_displayWarnings();
                /*0x3ecc580*/ void set_displayWarnings(bool value);
                /*0x3ecc588*/ void OnEnable();
                /*0x3ecc6c0*/ void OnDestroy();
                /*0x3ecc748*/ void InitializeFontReferenceLookup();
                /*0x3ecc9a0*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font);
                /*0x3ecc268*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetOSFontAssetList();
                /*0x3ecce8c*/ nint get_nativeTextSettings();
                /*0x3eccf00*/ nint[] GetGlobalFallbacks();
                /*0x3eccea4*/ void UpdateNativeTextSettings();

                struct FontReferenceMap
                {
                    /*0x10*/ UnityEngine.Font font;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x3eccc34*/ FontReferenceMap(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }

                class <>c__DisplayClass96_0
                {
                    /*0x10*/ System.Collections.Generic.List<nint> globalFontAssetFallbacks;

                    /*0x3ecd10c*/ <>c__DisplayClass96_0();
                    /*0x3ecd250*/ void <GetGlobalFallbacks>b__0(UnityEngine.TextCore.Text.FontAsset fallback);
                    /*0x3ecd3cc*/ void <GetGlobalFallbacks>b__1(UnityEngine.TextCore.Text.FontAsset fallback);
                    /*0x3ecd548*/ void <GetGlobalFallbacks>b__2(UnityEngine.TextCore.Text.TextAsset fallback);
                }
            }

            class TextStyle
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextStyle k_NormalStyle;
                /*0x10*/ string m_Name;
                /*0x18*/ int m_HashCode;
                /*0x20*/ string m_OpeningDefinition;
                /*0x28*/ string m_ClosingDefinition;
                /*0x30*/ uint[] m_OpeningTagArray;
                /*0x38*/ uint[] m_ClosingTagArray;
                /*0x40*/ uint[] m_OpeningTagUnicodeArray;
                /*0x48*/ uint[] m_ClosingTagUnicodeArray;

                /*0x3ecd71c*/ TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
                /*0x3ecd704*/ int get_hashCode();
                /*0x3ecd70c*/ uint[] get_styleOpeningTagArray();
                /*0x3ecd714*/ uint[] get_styleClosingTagArray();
                /*0x3ecd798*/ void RefreshStyle();
            }

            class TextStyleSheet : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary;
                /*0x28*/ object styleLookupLock;

                /*0x3ecde10*/ TextStyleSheet();
                /*0x3ecd988*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles();
                /*0x3ecd990*/ void Reset();
                /*0x3ecdc40*/ UnityEngine.TextCore.Text.TextStyle GetStyle(int hashCode);
                /*0x3ecdd70*/ UnityEngine.TextCore.Text.TextStyle GetStyle(string name);
                /*0x3ecde0c*/ void RefreshStyles();
                /*0x3ecd994*/ void LoadStyleDictionaryInternal();
            }

            struct TextCoreVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Color32 color;
                /*0x20*/ UnityEngine.Vector2 uv0;
                /*0x28*/ UnityEngine.Vector2 uv2;
            }

            enum TextElementType
            {
                Character = 1,
                Sprite = 2,
            }

            class TextElement
            {
                /*0x10*/ UnityEngine.TextCore.Text.TextElementType m_ElementType;
                /*0x14*/ uint m_Unicode;
                /*0x18*/ UnityEngine.TextCore.Text.TextAsset m_TextAsset;
                /*0x20*/ UnityEngine.TextCore.Glyph m_Glyph;
                /*0x28*/ uint m_GlyphIndex;
                /*0x2c*/ float m_Scale;

                /*0x3ecbea0*/ TextElement();
                /*0x3ecded4*/ UnityEngine.TextCore.Text.TextElementType get_elementType();
                /*0x3ecafc8*/ uint get_unicode();
                /*0x3ecdedc*/ void set_unicode(uint value);
                /*0x3ecdee4*/ UnityEngine.TextCore.Text.TextAsset get_textAsset();
                /*0x3ecafb8*/ void set_textAsset(UnityEngine.TextCore.Text.TextAsset value);
                /*0x3ecdeec*/ UnityEngine.TextCore.Glyph get_glyph();
                /*0x3ecafb0*/ void set_glyph(UnityEngine.TextCore.Glyph value);
                /*0x3ecafa8*/ uint get_glyphIndex();
                /*0x3ecdef4*/ void set_glyphIndex(uint value);
                /*0x3ecdefc*/ float get_scale();
                /*0x3ecdf04*/ void set_scale(float value);
            }

            struct TextVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Vector4 uv;
                /*0x2c*/ UnityEngine.Vector2 uv2;
                /*0x34*/ UnityEngine.Color32 color;
            }

            struct TextElementInfo
            {
                /*0x10*/ uint character;
                /*0x14*/ int index;
                /*0x18*/ UnityEngine.TextCore.Text.TextElementType elementType;
                /*0x1c*/ int stringLength;
                /*0x20*/ UnityEngine.TextCore.Text.TextElement textElement;
                /*0x28*/ UnityEngine.TextCore.Glyph alternativeGlyph;
                /*0x30*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x38*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x40*/ UnityEngine.Material material;
                /*0x48*/ int materialReferenceIndex;
                /*0x4c*/ bool isUsingAlternateTypeface;
                /*0x50*/ float pointSize;
                /*0x54*/ int lineNumber;
                /*0x58*/ int vertexIndex;
                /*0x5c*/ UnityEngine.TextCore.Text.TextVertex vertexTopLeft;
                /*0x84*/ UnityEngine.TextCore.Text.TextVertex vertexBottomLeft;
                /*0xac*/ UnityEngine.TextCore.Text.TextVertex vertexTopRight;
                /*0xd4*/ UnityEngine.TextCore.Text.TextVertex vertexBottomRight;
                /*0xfc*/ UnityEngine.Vector3 topLeft;
                /*0x108*/ UnityEngine.Vector3 bottomLeft;
                /*0x114*/ UnityEngine.Vector3 topRight;
                /*0x120*/ UnityEngine.Vector3 bottomRight;
                /*0x12c*/ float origin;
                /*0x130*/ float ascender;
                /*0x134*/ float baseLine;
                /*0x138*/ float descender;
                /*0x13c*/ float adjustedAscender;
                /*0x140*/ float adjustedDescender;
                /*0x144*/ float adjustedHorizontalAdvance;
                /*0x148*/ float xAdvance;
                /*0x14c*/ float aspectRatio;
                /*0x150*/ float scale;
                /*0x154*/ UnityEngine.Color32 color;
                /*0x158*/ UnityEngine.Color32 underlineColor;
                /*0x15c*/ int underlineVertexIndex;
                /*0x160*/ UnityEngine.Color32 strikethroughColor;
                /*0x164*/ int strikethroughVertexIndex;
                /*0x168*/ UnityEngine.Color32 highlightColor;
                /*0x16c*/ UnityEngine.TextCore.Text.HighlightState highlightState;
                /*0x180*/ UnityEngine.TextCore.Text.FontStyles style;
                /*0x184*/ bool isVisible;

                /*0x3ecdf0c*/ string ToString();
            }

            class TextEventManager
            {
                static /*0x0*/ UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Material> MATERIAL_PROPERTY_EVENT;
                static /*0x8*/ UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT;
                static /*0x10*/ UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT;
                static /*0x18*/ UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT;
                static /*0x20*/ UnityEngine.TextCore.Text.FastAction<UnityEngine.GameObject, UnityEngine.Material, UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT;
                static /*0x28*/ UnityEngine.TextCore.Text.FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;
                static /*0x30*/ UnityEngine.TextCore.Text.FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT;
                static /*0x38*/ UnityEngine.TextCore.Text.FastAction TMP_SETTINGS_PROPERTY_EVENT;
                static /*0x40*/ UnityEngine.TextCore.Text.FastAction RESOURCE_LOAD_EVENT;
                static /*0x48*/ UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;
                static /*0x50*/ UnityEngine.TextCore.Text.FastAction OnPreRenderObject_Event;
                static /*0x58*/ UnityEngine.TextCore.Text.FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT;

                static /*0x3ecf75c*/ TextEventManager();
                static /*0x3ecf6c0*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object font);
            }

            class TextGenerator
            {
                static int k_Tab = 9;
                static int k_LineFeed = 10;
                static int k_VerticalTab = 11;
                static int k_CarriageReturn = 13;
                static int k_Space = 32;
                static int k_DoubleQuotes = 34;
                static int k_NumberSign = 35;
                static int k_PercentSign = 37;
                static int k_SingleQuote = 39;
                static int k_Plus = 43;
                static int k_Period = 46;
                static int k_LesserThan = 60;
                static int k_Equal = 61;
                static int k_GreaterThan = 62;
                static int k_Underline = 95;
                static int k_NoBreakSpace = 160;
                static int k_SoftHyphen = 173;
                static int k_HyphenMinus = 45;
                static int k_FigureSpace = 8199;
                static int k_Hyphen = 8208;
                static int k_NonBreakingHyphen = 8209;
                static int k_ZeroWidthSpace = 8203;
                static int k_NarrowNoBreakSpace = 8239;
                static int k_WordJoiner = 8288;
                static int k_HorizontalEllipsis = 8230;
                static int k_LineSeparator = 8232;
                static int k_ParagraphSeparator = 8233;
                static int k_RightSingleQuote = 8217;
                static int k_Square = 9633;
                static int k_HangulJamoStart = 4352;
                static int k_HangulJamoEnd = 4607;
                static int k_CjkStart = 11904;
                static int k_CjkEnd = 40959;
                static int k_HangulJameExtendedStart = 43360;
                static int k_HangulJameExtendedEnd = 43391;
                static int k_HangulSyllablesStart = 44032;
                static int k_HangulSyllablesEnd = 55295;
                static int k_CjkIdeographsStart = 63744;
                static int k_CjkIdeographsEnd = 64255;
                static int k_CjkFormsStart = 65072;
                static int k_CjkFormsEnd = 65103;
                static int k_CjkHalfwidthStart = 65280;
                static int k_CjkHalfwidthEnd = 65519;
                static int k_EndOfText = 3;
                static float k_FloatUnset = -32767;
                static int k_MaxCharacters = 8;
                static /*0x0*/ UnityEngine.TextCore.Text.TextGenerator s_TextGenerator;
                static /*0x8*/ bool <IsExecutingJob>k__BackingField;
                static /*0x10*/ UnityEngine.TextCore.Text.TextGenerator.MissingCharacterEventCallback OnMissingCharacter;
                /*0x10*/ UnityEngine.TextCore.Text.TextBackingContainer m_TextBackingArray;
                /*0x20*/ UnityEngine.TextCore.Text.TextProcessingElement[] m_TextProcessingArray;
                /*0x28*/ int m_InternalTextProcessingArraySize;
                /*0x2c*/ bool m_VertexBufferAutoSizeReduction;
                /*0x30*/ char[] m_HtmlTag;
                /*0x38*/ UnityEngine.TextCore.Text.HighlightState m_HighlightState;
                /*0x4c*/ bool m_IsIgnoringAlignment;
                /*0x4d*/ bool m_IsTextTruncated;
                /*0x50*/ UnityEngine.Vector3[] m_RectTransformCorners;
                /*0x58*/ float m_MarginWidth;
                /*0x5c*/ float m_MarginHeight;
                /*0x60*/ float m_PreferredWidth;
                /*0x64*/ float m_PreferredHeight;
                /*0x68*/ UnityEngine.TextCore.Text.FontAsset m_CurrentFontAsset;
                /*0x70*/ UnityEngine.Material m_CurrentMaterial;
                /*0x78*/ int m_CurrentMaterialIndex;
                /*0x80*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> m_MaterialReferenceStack;
                /*0xd8*/ float m_Padding;
                /*0xe0*/ UnityEngine.TextCore.Text.SpriteAsset m_CurrentSpriteAsset;
                /*0xe8*/ int m_TotalCharacterCount;
                /*0xec*/ float m_FontSize;
                /*0xf0*/ float m_FontScaleMultiplier;
                /*0xf4*/ float m_CurrentFontSize;
                /*0xf8*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_SizeStack;
                /*0x118*/ UnityEngine.TextCore.Text.TextProcessingStack<int> m_TextStyleStacks;
                /*0x120*/ int m_TextStyleStackDepth;
                /*0x124*/ UnityEngine.TextCore.Text.FontStyles m_FontStyleInternal;
                /*0x128*/ UnityEngine.TextCore.Text.FontStyleStack m_FontStyleStack;
                /*0x134*/ UnityEngine.TextCore.Text.TextFontWeight m_FontWeightInternal;
                /*0x138*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> m_FontWeightStack;
                /*0x158*/ UnityEngine.TextCore.Text.TextAlignment m_LineJustification;
                /*0x160*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> m_LineJustificationStack;
                /*0x180*/ float m_BaselineOffset;
                /*0x188*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_BaselineOffsetStack;
                /*0x1a8*/ UnityEngine.Color32 m_FontColor32;
                /*0x1ac*/ UnityEngine.Color32 m_HtmlColor;
                /*0x1b0*/ UnityEngine.Color32 m_UnderlineColor;
                /*0x1b4*/ UnityEngine.Color32 m_StrikethroughColor;
                /*0x1b8*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_ColorStack;
                /*0x1d8*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_UnderlineColorStack;
                /*0x1f8*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_StrikethroughColorStack;
                /*0x218*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_HighlightColorStack;
                /*0x238*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.HighlightState> m_HighlightStateStack;
                /*0x268*/ UnityEngine.TextCore.Text.TextProcessingStack<int> m_ItalicAngleStack;
                /*0x288*/ UnityEngine.TextCore.Text.TextColorGradient m_ColorGradientPreset;
                /*0x290*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientStack;
                /*0x2b8*/ bool m_ColorGradientPresetIsTinted;
                /*0x2c0*/ UnityEngine.TextCore.Text.TextProcessingStack<int> m_ActionStack;
                /*0x2e0*/ float m_LineOffset;
                /*0x2e4*/ float m_LineHeight;
                /*0x2e8*/ bool m_IsDrivenLineSpacing;
                /*0x2ec*/ float m_CSpacing;
                /*0x2f0*/ float m_MonoSpacing;
                /*0x2f4*/ bool m_DuoSpace;
                /*0x2f8*/ float m_XAdvance;
                /*0x2fc*/ float m_TagLineIndent;
                /*0x300*/ float m_TagIndent;
                /*0x308*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_IndentStack;
                /*0x328*/ bool m_TagNoParsing;
                /*0x32c*/ int m_CharacterCount;
                /*0x330*/ int m_FirstCharacterOfLine;
                /*0x334*/ int m_LastCharacterOfLine;
                /*0x338*/ int m_FirstVisibleCharacterOfLine;
                /*0x33c*/ int m_LastVisibleCharacterOfLine;
                /*0x340*/ float m_MaxLineAscender;
                /*0x344*/ float m_MaxLineDescender;
                /*0x348*/ int m_LineNumber;
                /*0x34c*/ int m_LineVisibleCharacterCount;
                /*0x350*/ int m_LineVisibleSpaceCount;
                /*0x354*/ int m_FirstOverflowCharacterIndex;
                /*0x358*/ float m_MarginLeft;
                /*0x35c*/ float m_MarginRight;
                /*0x360*/ float m_Width;
                /*0x364*/ UnityEngine.TextCore.Text.Extents m_MeshExtents;
                /*0x374*/ float m_MaxCapHeight;
                /*0x378*/ float m_MaxAscender;
                /*0x37c*/ float m_MaxDescender;
                /*0x380*/ bool m_IsNonBreakingSpace;
                /*0x388*/ UnityEngine.TextCore.Text.WordWrapState m_SavedWordWrapState;
                /*0x720*/ UnityEngine.TextCore.Text.WordWrapState m_SavedLineState;
                /*0xab8*/ UnityEngine.TextCore.Text.WordWrapState m_SavedEllipsisState;
                /*0xe50*/ UnityEngine.TextCore.Text.WordWrapState m_SavedLastValidState;
                /*0x11e8*/ UnityEngine.TextCore.Text.WordWrapState m_SavedSoftLineBreakState;
                /*0x1580*/ UnityEngine.TextCore.Text.TextElementType m_TextElementType;
                /*0x1581*/ bool m_isTextLayoutPhase;
                /*0x1584*/ int m_SpriteIndex;
                /*0x1588*/ UnityEngine.Color32 m_SpriteColor;
                /*0x1590*/ UnityEngine.TextCore.Text.TextElement m_CachedTextElement;
                /*0x1598*/ UnityEngine.Color32 m_HighlightColor;
                /*0x159c*/ float m_CharWidthAdjDelta;
                /*0x15a0*/ float m_MaxFontSize;
                /*0x15a4*/ float m_MinFontSize;
                /*0x15a8*/ int m_AutoSizeIterationCount;
                /*0x15ac*/ int m_AutoSizeMaxIterationCount;
                /*0x15b0*/ float m_StartOfLineAscender;
                /*0x15b4*/ float m_LineSpacingDelta;
                /*0x15b8*/ UnityEngine.TextCore.Text.MaterialReference[] m_MaterialReferences;
                /*0x15c0*/ int m_SpriteCount;
                /*0x15c8*/ UnityEngine.TextCore.Text.TextProcessingStack<int> m_StyleStack;
                /*0x15e8*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.WordWrapState> m_EllipsisInsertionCandidateStack;
                /*0x19a0*/ int m_SpriteAnimationId;
                /*0x19a4*/ int m_ItalicAngle;
                /*0x19a8*/ UnityEngine.Vector3 m_FXScale;
                /*0x19b4*/ UnityEngine.Quaternion m_FXRotation;
                /*0x19c4*/ int m_LastBaseGlyphIndex;
                /*0x19c8*/ float m_PageAscender;
                /*0x19d0*/ UnityEngine.TextCore.Text.RichTextTagAttribute[] m_XmlAttribute;
                /*0x19d8*/ float[] m_AttributeParameterValues;
                /*0x19e0*/ System.Collections.Generic.Dictionary<int, int> m_MaterialReferenceIndexLookup;
                /*0x19e8*/ bool m_IsCalculatingPreferredValues;
                /*0x19e9*/ bool m_TintSprite;
                /*0x19f0*/ UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Ellipsis;
                /*0x1a10*/ UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Underline;
                /*0x1a30*/ UnityEngine.TextCore.Text.TextElementInfo[] m_InternalTextElementInfo;

                static /*0x3eb4c5c*/ bool get_IsExecutingJob();
                static /*0x3eb4ca4*/ void set_IsExecutingJob(bool value);
                static /*0x3eb5278*/ void ClearMesh(bool updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3eca14c*/ TextGenerator();
                /*0x3eb4cf4*/ void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3eb5270*/ bool get_isTextTruncated();
                /*0x3eb4fe0*/ void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ebbaf8*/ bool ValidateHtmlTag(UnityEngine.TextCore.Text.TextProcessingElement[] chars, int startIndex, ref int endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo, ref bool isThreadSuccess);
                /*0x3ec028c*/ void CloseLastLinkTag(UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec0324*/ void CloseAllLinkTags(UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec02c4*/ void CloseLinkTag(UnityEngine.TextCore.Text.TextInfo textInfo, int index);
                /*0x3ec0228*/ void ClearMarkupTagAttributes();
                /*0x3ec0370*/ void SaveWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, int index, int count, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec06e8*/ int RestoreWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec0a38*/ void SaveGlyphVertexInfo(float padding, float stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec128c*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec1818*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec23a8*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3eb98f0*/ void LayoutPhase(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, float maxVisibleDescender);
                /*0x3eb5298*/ void ParsingPhase(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, ref uint charCode, ref float maxVisibleDescender);
                /*0x3ec283c*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec2d50*/ UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec2e94*/ UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec2fa4*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3eb4ea8*/ void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec8660*/ bool PrepareFontAsset(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x3ec6cac*/ int SetArraySizes(UnityEngine.TextCore.Text.TextProcessingElement[] textProcessingArray, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x3ec9c8c*/ UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isUsingAlternativeTypeface, bool populateLigatures);
                /*0x3ec5e80*/ void PopulateTextBackingArray(ref UnityEngine.TextCore.Text.RenderedText sourceText);
                /*0x3ec5f54*/ void PopulateTextProcessingArray(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x3ec8710*/ bool PopulateFontAsset(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextProcessingElement[] textProcessingArray);
                /*0x3ec5e18*/ void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins);
                /*0x3ec5dd0*/ bool GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x3ec99a8*/ bool GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x3ec2130*/ bool GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x3eca0b0*/ void DoMissingGlyphCallback(uint unicode, int stringIndex, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.TextInfo textInfo);

                class MissingCharacterEventCallback : System.MulticastDelegate
                {
                    /*0x3ecfa78*/ MissingCharacterEventCallback(object object, nint method);
                    /*0x3ecfb18*/ void Invoke(uint unicode, int stringIndex, UnityEngine.TextCore.Text.TextInfo text, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }

                struct SpecialCharacter
                {
                    /*0x10*/ UnityEngine.TextCore.Text.Character character;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                    /*0x20*/ UnityEngine.Material material;
                    /*0x28*/ int materialIndex;

                    /*0x3ecfb2c*/ SpecialCharacter(UnityEngine.TextCore.Text.Character character, int materialIndex);
                }
            }

            class TextGenerationSettings : System.IEquatable<UnityEngine.TextCore.Text.TextGenerationSettings>
            {
                static float wordWrappingRatio = 0.4000000059604645;
                static bool autoSize = false;
                static float fontSizeMin = 0;
                static float fontSizeMax = 0;
                static bool tagNoParsing = false;
                static float lineSpacing = 0;
                static float lineSpacingMax = 0;
                static int maxVisibleCharacters = 99999;
                static int maxVisibleWords = 99999;
                static int maxVisibleLines = 99999;
                static int firstVisibleCharacter = 0;
                static bool useMaxVisibleDescender = false;
                static float charWidthMaxAdj = 0;
                static /*0x0*/ System.Func<bool> IsEditorTextRenderingModeBitmap;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.OTL_FeatureTag> fontFeatures;
                /*0x10*/ UnityEngine.TextCore.Text.RenderedText m_RenderedText;
                /*0x30*/ string m_CachedRenderedText;
                /*0x38*/ UnityEngine.Rect screenRect;
                /*0x48*/ float pixelsPerPoint;
                /*0x4c*/ bool isEditorRenderingModeBitmap;
                /*0x50*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x58*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
                /*0x60*/ UnityEngine.TextCore.Text.TextSettings textSettings;
                /*0x68*/ UnityEngine.TextCore.Text.TextAlignment textAlignment;
                /*0x6c*/ UnityEngine.TextCore.Text.TextOverflowMode overflowMode;
                /*0x70*/ UnityEngine.Color color;
                /*0x80*/ bool shouldConvertToLinearSpace;
                /*0x84*/ float fontSize;
                /*0x88*/ bool emojiFallbackSupport;
                /*0x89*/ bool richText;
                /*0x8a*/ bool isRightToLeft;
                /*0x8c*/ float extraPadding;
                /*0x90*/ bool parseControlCharacters;
                /*0x91*/ bool isPlaceholder;
                /*0x94*/ float characterSpacing;
                /*0x98*/ float wordSpacing;
                /*0x9c*/ float paragraphSpacing;
                /*0xa0*/ UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode;
                /*0xa4*/ UnityEngine.TextCore.Text.TextFontWeight fontWeight;
                /*0xa8*/ bool isIMGUI;

                static /*0x3ed149c*/ TextGenerationSettings();
                static /*0x3ed05e4*/ bool op_Inequality(UnityEngine.TextCore.Text.TextGenerationSettings left, UnityEngine.TextCore.Text.TextGenerationSettings right);
                /*0x3ecfe90*/ TextGenerationSettings();
                /*0x3ecfc78*/ UnityEngine.TextCore.Text.RenderedText get_renderedText();
                /*0x3ecfc84*/ void set_renderedText(UnityEngine.TextCore.Text.RenderedText value);
                /*0x3ecfcb0*/ string get_text();
                /*0x3ecfe10*/ void set_text(string value);
                /*0x3ecfee8*/ bool Equals(UnityEngine.TextCore.Text.TextGenerationSettings other);
                /*0x3ed01b8*/ bool Equals(object obj);
                /*0x3ed02b8*/ int GetHashCode();
                /*0x3ed0600*/ string ToString();
            }

            enum TextAlignment
            {
                TopLeft = 257,
                TopCenter = 258,
                TopRight = 260,
                TopJustified = 264,
                TopFlush = 272,
                TopGeoAligned = 288,
                MiddleLeft = 513,
                MiddleCenter = 514,
                MiddleRight = 516,
                MiddleJustified = 520,
                MiddleFlush = 528,
                MiddleGeoAligned = 544,
                BottomLeft = 1025,
                BottomCenter = 1026,
                BottomRight = 1028,
                BottomJustified = 1032,
                BottomFlush = 1040,
                BottomGeoAligned = 1056,
                BaselineLeft = 2049,
                BaselineCenter = 2050,
                BaselineRight = 2052,
                BaselineJustified = 2056,
                BaselineFlush = 2064,
                BaselineGeoAligned = 2080,
                MidlineLeft = 4097,
                MidlineCenter = 4098,
                MidlineRight = 4100,
                MidlineJustified = 4104,
                MidlineFlush = 4112,
                MidlineGeoAligned = 4128,
                CaplineLeft = 8193,
                CaplineCenter = 8194,
                CaplineRight = 8196,
                CaplineJustified = 8200,
                CaplineFlush = 8208,
                CaplineGeoAligned = 8224,
            }

            enum FontStyles
            {
                Normal = 0,
                Bold = 1,
                Italic = 2,
                Underline = 4,
                LowerCase = 8,
                UpperCase = 16,
                SmallCaps = 32,
                Strikethrough = 64,
                Superscript = 128,
                Subscript = 256,
                Highlight = 512,
            }

            enum TextOverflowMode
            {
                Overflow = 0,
                Ellipsis = 1,
                Masking = 2,
                Truncate = 3,
                ScrollRect = 4,
                Linked = 6,
            }

            enum TextWrappingMode
            {
                NoWrap = 0,
                Normal = 1,
                PreserveWhitespace = 2,
                PreserveWhitespaceNoWrap = 3,
            }

            struct RenderedText : System.IEquatable<UnityEngine.TextCore.Text.RenderedText>, System.IEquatable<string>
            {
                /*0x10*/ string value;
                /*0x18*/ int valueStart;
                /*0x1c*/ int valueLength;
                /*0x20*/ string suffix;
                /*0x28*/ char repeat;
                /*0x2c*/ int repeatCount;

                /*0x3ecfe74*/ RenderedText(string value);
                /*0x3ed1628*/ RenderedText(string value, string suffix);
                /*0x3ed1568*/ RenderedText(string value, int start, int length, string suffix);
                /*0x3ed1644*/ RenderedText(char repeat, int repeatCount, string suffix);
                /*0x3ed1698*/ int get_CharacterCount();
                /*0x3ed16b8*/ UnityEngine.TextCore.Text.RenderedText.Enumerator GetEnumerator();
                /*0x3ecfd0c*/ string CreateString();
                /*0x3ed012c*/ bool Equals(UnityEngine.TextCore.Text.RenderedText other);
                /*0x3ed17f4*/ bool Equals(string other);
                /*0x3ed18e8*/ bool Equals(object obj);
                /*0x3ed19a0*/ int GetHashCode();

                struct Enumerator
                {
                    /*0x10*/ UnityEngine.TextCore.Text.RenderedText m_Source;
                    /*0x30*/ int m_Stage;
                    /*0x34*/ int m_StageIndex;
                    /*0x38*/ char m_Current;

                    /*0x3ed16e8*/ Enumerator(ref UnityEngine.TextCore.Text.RenderedText source);
                    /*0x3ed1a5c*/ char get_Current();
                    /*0x3ed1710*/ bool MoveNext();
                }
            }

            struct RichTextTagAttribute
            {
                /*0x10*/ int nameHashCode;
                /*0x14*/ int valueHashCode;
                /*0x18*/ UnityEngine.TextCore.Text.TagValueType valueType;
                /*0x1c*/ int valueStartIndex;
                /*0x20*/ int valueLength;
                /*0x24*/ UnityEngine.TextCore.Text.TagUnitType unitType;
            }

            struct TextProcessingElement
            {
                /*0x10*/ UnityEngine.TextCore.Text.TextProcessingElementType elementType;
                /*0x14*/ uint unicode;
                /*0x18*/ int stringIndex;
                /*0x1c*/ int length;
            }

            struct TextBackingContainer
            {
                /*0x10*/ uint[] m_Array;
                /*0x18*/ int m_Count;

                /*0x3ed1b88*/ TextBackingContainer(int size);
                /*0x3ed1a64*/ int get_Capacity();
                /*0x3ed1a7c*/ int get_Count();
                /*0x3ed1a84*/ void set_Count(int value);
                /*0x3ed1a8c*/ uint get_Item(int index);
                /*0x3ed1abc*/ void set_Item(int index, uint value);
                /*0x3ed1b1c*/ void Resize(int size);
            }

            struct CharacterSubstitution
            {
                /*0x10*/ int index;
                /*0x14*/ uint unicode;

                /*0x3ed1bf4*/ CharacterSubstitution(int index, uint unicode);
            }

            struct Offset
            {
                static /*0x0*/ UnityEngine.TextCore.Text.Offset k_ZeroOffset;
                /*0x10*/ float m_Left;
                /*0x14*/ float m_Right;
                /*0x18*/ float m_Top;
                /*0x1c*/ float m_Bottom;

                static /*0x3ed1d9c*/ Offset();
                static /*0x3ed1c1c*/ UnityEngine.TextCore.Text.Offset get_zero();
                static /*0x3ed1c84*/ bool op_Equality(UnityEngine.TextCore.Text.Offset lhs, UnityEngine.TextCore.Text.Offset rhs);
                static /*0x3ed1cac*/ UnityEngine.TextCore.Text.Offset op_Multiply(UnityEngine.TextCore.Text.Offset a, float b);
                /*0x3ed1c78*/ Offset(float left, float right, float top, float bottom);
                /*0x3ed1bfc*/ float get_left();
                /*0x3ed1c04*/ float get_right();
                /*0x3ed1c0c*/ float get_top();
                /*0x3ed1c14*/ float get_bottom();
                /*0x3ed1cc0*/ int GetHashCode();
                /*0x3ed1d24*/ bool Equals(object obj);
            }

            struct HighlightState
            {
                /*0x10*/ UnityEngine.Color32 color;
                /*0x14*/ UnityEngine.TextCore.Text.Offset padding;

                static /*0x3ed1df4*/ bool op_Equality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs);
                static /*0x3ed1ee4*/ bool op_Inequality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs);
                /*0x3ed1de4*/ HighlightState(UnityEngine.Color32 color, UnityEngine.TextCore.Text.Offset padding);
                /*0x3ed1f2c*/ int GetHashCode();
                /*0x3ed1f98*/ bool Equals(object obj);
            }

            struct WordWrapState
            {
                /*0x10*/ int previousWordBreak;
                /*0x14*/ int totalCharacterCount;
                /*0x18*/ int visibleCharacterCount;
                /*0x1c*/ int visibleSpaceCount;
                /*0x20*/ int visibleSpriteCount;
                /*0x24*/ int visibleLinkCount;
                /*0x28*/ int firstCharacterIndex;
                /*0x2c*/ int firstVisibleCharacterIndex;
                /*0x30*/ int lastCharacterIndex;
                /*0x34*/ int lastVisibleCharIndex;
                /*0x38*/ int lineNumber;
                /*0x3c*/ float maxCapHeight;
                /*0x40*/ float maxAscender;
                /*0x44*/ float maxDescender;
                /*0x48*/ float maxLineAscender;
                /*0x4c*/ float maxLineDescender;
                /*0x50*/ float startOfLineAscender;
                /*0x54*/ float xAdvance;
                /*0x58*/ float preferredWidth;
                /*0x5c*/ float preferredHeight;
                /*0x60*/ float previousLineScale;
                /*0x64*/ float pageAscender;
                /*0x68*/ int wordCount;
                /*0x6c*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
                /*0x70*/ float fontScale;
                /*0x74*/ float fontScaleMultiplier;
                /*0x78*/ int italicAngle;
                /*0x7c*/ float currentFontSize;
                /*0x80*/ float baselineOffset;
                /*0x84*/ float lineOffset;
                /*0x88*/ UnityEngine.TextCore.Text.TextInfo textInfo;
                /*0x90*/ UnityEngine.TextCore.Text.LineInfo lineInfo;
                /*0xf0*/ UnityEngine.Color32 vertexColor;
                /*0xf4*/ UnityEngine.Color32 underlineColor;
                /*0xf8*/ UnityEngine.Color32 strikethroughColor;
                /*0xfc*/ UnityEngine.Color32 highlightColor;
                /*0x100*/ UnityEngine.TextCore.Text.HighlightState highlightState;
                /*0x114*/ UnityEngine.TextCore.Text.FontStyleStack basicStyleStack;
                /*0x120*/ UnityEngine.TextCore.Text.TextProcessingStack<int> italicAngleStack;
                /*0x140*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> colorStack;
                /*0x160*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> underlineColorStack;
                /*0x180*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;
                /*0x1a0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> highlightColorStack;
                /*0x1c0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.HighlightState> highlightStateStack;
                /*0x1f0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> colorGradientStack;
                /*0x218*/ UnityEngine.TextCore.Text.TextProcessingStack<float> sizeStack;
                /*0x238*/ UnityEngine.TextCore.Text.TextProcessingStack<float> indentStack;
                /*0x258*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> fontWeightStack;
                /*0x278*/ UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack;
                /*0x298*/ UnityEngine.TextCore.Text.TextProcessingStack<float> baselineStack;
                /*0x2b8*/ UnityEngine.TextCore.Text.TextProcessingStack<int> actionStack;
                /*0x2d8*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> materialReferenceStack;
                /*0x330*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> lineJustificationStack;
                /*0x350*/ int lastBaseGlyphIndex;
                /*0x354*/ int spriteAnimationId;
                /*0x358*/ UnityEngine.TextCore.Text.FontAsset currentFontAsset;
                /*0x360*/ UnityEngine.TextCore.Text.SpriteAsset currentSpriteAsset;
                /*0x368*/ UnityEngine.Material currentMaterial;
                /*0x370*/ int currentMaterialIndex;
                /*0x374*/ UnityEngine.TextCore.Text.Extents meshExtents;
                /*0x384*/ bool tagNoParsing;
                /*0x385*/ bool isNonBreakingSpace;
                /*0x386*/ bool isDrivenLineSpacing;
                /*0x388*/ UnityEngine.Vector3 fxScale;
                /*0x394*/ UnityEngine.Quaternion fxRotation;
            }

            class TextGeneratorUtilities
            {
                static /*0x0*/ UnityEngine.Vector2 largePositiveVector2;
                static /*0x8*/ UnityEngine.Vector2 largeNegativeVector2;
                static /*0x10*/ System.Collections.Generic.HashSet<uint> k_EmojiLookup;
                static /*0x18*/ System.Collections.Generic.HashSet<uint> k_EmojiPresentationFormLookup;

                static /*0x3ed58e4*/ TextGeneratorUtilities();
                static /*0x3ed2018*/ bool Approximately(float a, float b);
                static /*0x3ed2040*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int tagCount);
                static /*0x3ed2468*/ uint HexToInt(char hex);
                static /*0x3ed2494*/ float ConvertToFloat(char[] chars, int startIndex, int length);
                static /*0x3ed2514*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
                static /*0x1f350f8*/ void ResizeInternalArray<T>(ref T[] array);
                static /*0x1f36244*/ void ResizeInternalArray<T>(ref T[] array, int size);
                static /*0x3ed2670*/ void InsertOpeningTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed2c34*/ void InsertClosingTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed2d3c*/ bool ReplaceOpeningStyleTag(ref UnityEngine.TextCore.Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed3050*/ bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, ref int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed3280*/ void ReplaceClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed33ac*/ void InsertOpeningStyleTag(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed3494*/ void InsertClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed2778*/ void InsertTextStyleInTextProcessingArray(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x3ed2f88*/ UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, int hashCode);
                static /*0x3ed31b0*/ int GetStyleHashCode(ref uint[] text, int index, ref int closeIndex);
                static /*0x3ed2e9c*/ int GetStyleHashCode(ref UnityEngine.TextCore.Text.TextBackingContainer text, int index, ref int closeIndex);
                static /*0x3ed3580*/ uint GetUTF16(uint[] text, int i);
                static /*0x3ed395c*/ uint GetUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int i);
                static /*0x3ed3668*/ uint GetUTF32(uint[] text, int i);
                static /*0x3ed3a18*/ uint GetUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int i);
                static /*0x3ed3b24*/ void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x3ed440c*/ void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x3ed4bbc*/ void AdjustLineOffset(int startIndex, int endIndex, float offset, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x3ed4d3c*/ void ResizeLineExtents(int size, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x3ed4ee8*/ UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle);
                static /*0x3ed4ef8*/ UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor);
                static /*0x3ed4f1c*/ UnityEngine.TextCore.HorizontalAlignment GetHorizontalAlignment(UnityEngine.TextAnchor anchor);
                static /*0x3ed4f40*/ UnityEngine.TextCore.VerticalAlignment GetVerticalAlignment(UnityEngine.TextAnchor anchor);
                static /*0x3ed4f64*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
                static /*0x3ed4f78*/ int GetMarkupTagHashCode(UnityEngine.TextCore.Text.TextBackingContainer styleDefinition, int readIndex);
                static /*0x3ed37e8*/ int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex);
                static /*0x3ed38e8*/ char ToUpperASCIIFast(char c);
                static /*0x3ed5068*/ uint ToUpperASCIIFast(uint c);
                static /*0x3ed50dc*/ char ToUpperFast(char c);
                static /*0x3ed5150*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
                static /*0x3ed523c*/ bool IsBitmapRendering(UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode);
                static /*0x3ed5270*/ bool IsBaseGlyph(uint c);
                static /*0x3ed53f0*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
                static /*0x3ed4378*/ UnityEngine.Color32 GammaToLinear(UnityEngine.Color32 c);
                static /*0x3ed53fc*/ byte GammaToLinear(byte value);
                static /*0x3ed549c*/ bool IsValidUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int index);
                static /*0x3ed5538*/ bool IsValidUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int index);
                static /*0x3ed55d4*/ bool IsEmoji(uint c);
                static /*0x3ed5668*/ bool IsEmojiPresentationForm(uint c);
                static /*0x3ed56fc*/ bool IsHangul(uint c);
                static /*0x3ed5790*/ bool IsCJK(uint c);
            }

            class TextLib
            {
                static /*0x0*/ System.Func<UnityEngine.TextAsset> GetICUAssetEditorDelegate;
                /*0x10*/ nint m_Ptr;

                static /*0x3ed5a78*/ nint GetInstance(byte[] icuData);
                static /*0x3ed66c8*/ int FindIntersectingLink(UnityEngine.Vector2 point, nint textGenerationInfo);
                static /*0x3ed5b48*/ nint GetInstance_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper icuData);
                static /*0x3ed6598*/ void GenerateTextInternal_Injected(nint _unity_self, ref UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo, ref UnityEngine.TextCore.Text.NativeTextInfo ret);
                static /*0x3ed666c*/ void MeasureText_Injected(nint _unity_self, ref UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo, ref UnityEngine.Vector2 ret);
                static /*0x3ed6710*/ int FindIntersectingLink_Injected(ref UnityEngine.Vector2 point, nint textGenerationInfo);
                /*0x3ed5a48*/ TextLib(byte[] icuData);
                /*0x3ed5b84*/ UnityEngine.TextCore.Text.NativeTextInfo GenerateText(UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo);
                /*0x3ed5c98*/ void ProcessMeshInfos(UnityEngine.TextCore.Text.NativeTextInfo textInfo, UnityEngine.TextCore.NativeTextGenerationSettings settings);
                /*0x3ed5c20*/ UnityEngine.TextCore.Text.NativeTextInfo GenerateTextInternal(UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo);
                /*0x3ed65f4*/ UnityEngine.Vector2 MeasureText(UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo);

                class BindingsMarshaller
                {
                    static /*0x3ed6754*/ nint ConvertToNative(UnityEngine.TextCore.Text.TextLib textLib);
                }
            }

            class TextGenerationInfo
            {
                static /*0x3ed6768*/ nint Create();
                static /*0x3ed6790*/ void Destroy(nint ptr);
            }

            class TextSelectionService
            {
                static /*0x3ed67cc*/ string Substring(nint textGenerationInfo, int startIndex, int endIndex);
                static /*0x3ed6908*/ void SelectCurrentWord(nint textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex);
                static /*0x3ed6964*/ int PreviousCodePointIndex(nint textGenerationInfo, int currentIndex);
                static /*0x3ed69a8*/ int NextCodePointIndex(nint textGenerationInfo, int currentIndex);
                static /*0x3ed69ec*/ int GetCursorLogicalIndexFromPosition(nint textGenerationInfo, UnityEngine.Vector2 position);
                static /*0x3ed6a78*/ UnityEngine.Vector2 GetCursorPositionFromLogicalIndex(nint textGenerationInfo, int logicalIndex);
                static /*0x3ed6b28*/ int LineUpCharacterPosition(nint textGenerationInfo, int originalPos);
                static /*0x3ed6b6c*/ int LineDownCharacterPosition(nint textGenerationInfo, int originalPos);
                static /*0x3ed6bb0*/ UnityEngine.Rect[] GetHighlightRectangles(nint textGenerationInfo, int cursorIndex, int selectIndex);
                static /*0x3ed6d34*/ float GetCharacterHeightFromIndex(nint textGenerationInfo, int index);
                static /*0x3ed6d78*/ int GetStartOfNextWord(nint textGenerationInfo, int currentIndex);
                static /*0x3ed6dbc*/ int GetEndOfPreviousWord(nint textGenerationInfo, int currentIndex);
                static /*0x3ed6e00*/ int GetFirstCharacterIndexOnLine(nint textGenerationInfo, int currentIndex);
                static /*0x3ed6e44*/ int GetLastCharacterIndexOnLine(nint textGenerationInfo, int currentIndex);
                static /*0x3ed6e88*/ float GetLineHeight(nint textGenerationInfo, int lineIndex);
                static /*0x3ed6ecc*/ int GetLineNumber(nint textGenerationInfo, int logicalIndex);
                static /*0x3ed6f10*/ void SelectToPreviousParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x3ed6f54*/ void SelectToStartOfParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x3ed6f98*/ void SelectToEndOfParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x3ed6fdc*/ void SelectToNextParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x3ed7020*/ void SelectCurrentParagraph(nint textGenerationInfo, ref int cursorIndex, ref int selectIndex);
                static /*0x3ed68ac*/ void Substring_Injected(nint textGenerationInfo, int startIndex, int endIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
                static /*0x3ed6a34*/ int GetCursorLogicalIndexFromPosition_Injected(nint textGenerationInfo, ref UnityEngine.Vector2 position);
                static /*0x3ed6ad4*/ void GetCursorPositionFromLogicalIndex_Injected(nint textGenerationInfo, int logicalIndex, ref UnityEngine.Vector2 ret);
                static /*0x3ed6cd8*/ void GetHighlightRectangles_Injected(nint textGenerationInfo, int cursorIndex, int selectIndex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            }

            class TextHandle
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextHandleTemporaryCache s_TemporaryCache;
                static /*0x8*/ UnityEngine.TextCore.Text.TextHandlePermanentCache s_PermanentCache;
                static /*0x10*/ UnityEngine.TextCore.Text.TextGenerationSettings[] s_Settings;
                static /*0x18*/ UnityEngine.TextCore.Text.TextGenerator[] s_Generators;
                static /*0x20*/ UnityEngine.TextCore.Text.TextInfo[] s_TextInfosCommon;
                /*0x10*/ UnityEngine.TextCore.NativeTextGenerationSettings nativeSettings;
                /*0x70*/ UnityEngine.Vector2 <preferredSize>k__BackingField;
                /*0x78*/ UnityEngine.Rect m_ScreenRect;
                /*0x88*/ float m_LineHeightDefault;
                /*0x8c*/ bool m_IsPlaceholder;
                /*0x8d*/ bool m_IsEllided;
                /*0x90*/ nint textGenerationInfo;
                /*0x98*/ System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> <TextInfoNode>k__BackingField;
                /*0xa0*/ bool <IsCachedPermanent>k__BackingField;
                /*0xa1*/ bool <IsCachedTemporary>k__BackingField;
                /*0xa4*/ int m_PreviousGenerationSettingsHash;
                /*0xa8*/ bool isDirty;

                static /*0x3edaaa4*/ TextHandle();
                static /*0x3ed7268*/ void InitThreadArrays();
                static /*0x3ed75a0*/ UnityEngine.TextCore.Text.TextGenerationSettings[] get_settingsArray();
                static /*0x3ed7710*/ UnityEngine.TextCore.Text.TextGenerator[] get_generators();
                static /*0x3ed7880*/ UnityEngine.TextCore.Text.TextInfo[] get_textInfosCommon();
                static /*0x1f36f18*/ void InitArray<T>(ref T[] array, System.Func<T> createInstance);
                static /*0x3ed79f0*/ UnityEngine.TextCore.Text.TextInfo get_textInfoCommon();
                static /*0x3ed7a6c*/ UnityEngine.TextCore.Text.TextGenerator get_generator();
                static /*0x3ed7ae8*/ UnityEngine.TextCore.Text.TextGenerationSettings get_settings();
                static /*0x3ed8434*/ void UpdateCurrentFrame();
                static /*0x3ed8c84*/ float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x3ed87e8*/ float GetLineHeightDefault(UnityEngine.TextCore.Text.TextGenerationSettings settings);
                /*0x3ed7074*/ TextHandle();
                /*0x3ed70c4*/ void Finalize();
                /*0x3ed7b64*/ UnityEngine.Vector2 get_preferredSize();
                /*0x3ed7b6c*/ void set_preferredSize(UnityEngine.Vector2 value);
                /*0x3ed7b74*/ System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> get_TextInfoNode();
                /*0x3ed7b7c*/ void set_TextInfoNode(System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> value);
                /*0x3ed7b84*/ bool get_IsCachedPermanent();
                /*0x3ed7b8c*/ void set_IsCachedPermanent(bool value);
                /*0x3ed7b94*/ bool get_IsCachedTemporary();
                /*0x3ed7b9c*/ void set_IsCachedTemporary(bool value);
                /*0x3ed7ba4*/ bool get_useAdvancedText();
                /*0x3ed7bb0*/ int get_characterCount();
                /*0x3ed7ca4*/ void AddTextInfoToPermanentCache();
                /*0x3ed7d70*/ void AddTextInfoToTemporaryCache(int hashCode);
                /*0x3ed7150*/ void RemoveTextInfoFromTemporaryCache();
                /*0x3ed71c0*/ void RemoveTextInfoFromPermanentCache();
                /*0x3ed7bf8*/ UnityEngine.TextCore.Text.TextInfo get_textInfo();
                /*0x3ed84bc*/ void SetDirty();
                /*0x3ed84c8*/ bool IsDirty(int hashCode);
                /*0x3ed8504*/ bool get_IsPlaceholder();
                /*0x3ed850c*/ void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings tgs);
                /*0x3ed8594*/ UnityEngine.TextCore.Text.TextInfo Update();
                /*0x3ed8604*/ UnityEngine.TextCore.Text.TextInfo UpdateWithHash(int hashCode);
                /*0x3ed8930*/ bool PrepareFontAsset();
                /*0x3ed8a58*/ void UpdatePreferredSize();
                /*0x3ed8d08*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis);
                /*0x3ed8d8c*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance, bool inverseYAxis);
                /*0x3ed8ed0*/ UnityEngine.Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex);
                /*0x3ed8f9c*/ int GetCursorIndexFromPosition(UnityEngine.Vector2 position, bool inverseYAxis);
                /*0x3ed9100*/ int LineDownCharacterPosition(int originalLogicalPos);
                /*0x3ed92a8*/ int LineUpCharacterPosition(int originalLogicalPos);
                /*0x3ed945c*/ int FindIntersectingLink(UnityEngine.Vector3 position, bool inverseYAxis);
                /*0x3ed97d4*/ int GetCorrespondingStringIndex(int index);
                /*0x3ed9874*/ UnityEngine.TextCore.Text.LineInfo GetLineInfoFromCharacterIndex(int index);
                /*0x3ed99ac*/ int GetLineNumber(int index);
                /*0x3ed9a74*/ float GetLineHeight(int lineNumber);
                /*0x3ed9b3c*/ float GetLineHeightFromCharacterIndex(int index);
                /*0x3ed9c04*/ float GetCharacterHeightFromIndex(int index);
                /*0x3ed9cd4*/ string Substring(int startIndex, int length);
                /*0x3ed9ea4*/ int PreviousCodePointIndex(int currentIndex);
                /*0x3ed9f68*/ int NextCodePointIndex(int currentIndex);
                /*0x3eda02c*/ int GetStartOfNextWord(int currentIndex);
                /*0x3eda0f0*/ int GetEndOfPreviousWord(int currentIndex);
                /*0x3eda1b4*/ int GetFirstCharacterIndexOnLine(int currentIndex);
                /*0x3eda278*/ int GetLastCharacterIndexOnLine(int currentIndex);
                /*0x3eda33c*/ int IndexOf(char value, int startIndex);
                /*0x3eda4a8*/ int LastIndexOf(char value, int startIndex);
                /*0x3eda604*/ void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex);
                /*0x3eda6dc*/ void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex);
                /*0x3eda7ac*/ void SelectToPreviousParagraph(ref int cursorIndex);
                /*0x3eda868*/ void SelectToNextParagraph(ref int cursorIndex);
                /*0x3eda924*/ void SelectToStartOfParagraph(ref int cursorIndex);
                /*0x3eda9e0*/ void SelectToEndOfParagraph(ref int cursorIndex);
                /*0x3edaa9c*/ bool IsAdvancedTextEnabledForElement();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.TextHandle.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.TextGenerationSettings> <>9__4_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Text.TextGenerator> <>9__4_1;
                    static /*0x18*/ System.Func<UnityEngine.TextCore.Text.TextInfo> <>9__4_2;
                    static /*0x20*/ System.Func<UnityEngine.TextCore.Text.TextGenerationSettings> <>9__7_0;
                    static /*0x28*/ System.Func<UnityEngine.TextCore.Text.TextGenerator> <>9__10_0;
                    static /*0x30*/ System.Func<UnityEngine.TextCore.Text.TextInfo> <>9__13_0;

                    static /*0x3edacdc*/ <>c();
                    /*0x3edad44*/ <>c();
                    /*0x3edad4c*/ UnityEngine.TextCore.Text.TextGenerationSettings <InitThreadArrays>b__4_0();
                    /*0x3edad9c*/ UnityEngine.TextCore.Text.TextGenerator <InitThreadArrays>b__4_1();
                    /*0x3edadf0*/ UnityEngine.TextCore.Text.TextInfo <InitThreadArrays>b__4_2();
                    /*0x3edb010*/ UnityEngine.TextCore.Text.TextGenerationSettings <get_settingsArray>b__7_0();
                    /*0x3edb060*/ UnityEngine.TextCore.Text.TextGenerator <get_generators>b__10_0();
                    /*0x3edb0b4*/ UnityEngine.TextCore.Text.TextInfo <get_textInfosCommon>b__13_0();
                }
            }

            class TextHandlePermanentCache
            {
                /*0x10*/ System.Collections.Generic.LinkedList<UnityEngine.TextCore.Text.TextInfo> s_TextInfoPool;
                /*0x18*/ object syncRoot;

                /*0x3edac1c*/ TextHandlePermanentCache();
                /*0x3edb104*/ void AddTextInfoToCache(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x3ed8300*/ void RemoveTextInfoFromCache(UnityEngine.TextCore.Text.TextHandle textHandle);
            }

            class TextHandleTemporaryCache
            {
                static int s_MinFramesInCache = 2;
                /*0x10*/ System.Collections.Generic.LinkedList<UnityEngine.TextCore.Text.TextInfo> s_TextInfoPool;
                /*0x18*/ int currentFrame;
                /*0x20*/ object syncRoot;

                /*0x3edab5c*/ TextHandleTemporaryCache();
                /*0x3edb33c*/ void ClearTemporaryCache();
                /*0x3ed7e00*/ void AddTextInfoToCache(UnityEngine.TextCore.Text.TextHandle textHandle, int hashCode);
                /*0x3edb828*/ void RemoveTextInfoFromCache(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x3edb45c*/ void RefreshCaching(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x3edb58c*/ void RecycleTextInfoFromCache(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x3ed84a0*/ void UpdateCurrentFrame();
            }

            struct WordInfo
            {
                /*0x10*/ int firstCharacterIndex;
                /*0x14*/ int lastCharacterIndex;
                /*0x18*/ int characterCount;
            }

            class TextInfo
            {
                static /*0x0*/ UnityEngine.Vector2 s_InfinityVectorPositive;
                static /*0x8*/ UnityEngine.Vector2 s_InfinityVectorNegative;
                /*0x10*/ int characterCount;
                /*0x14*/ int spriteCount;
                /*0x18*/ int spaceCount;
                /*0x1c*/ int wordCount;
                /*0x20*/ int linkCount;
                /*0x24*/ int lineCount;
                /*0x28*/ int materialCount;
                /*0x30*/ UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo;
                /*0x38*/ UnityEngine.TextCore.Text.WordInfo[] wordInfo;
                /*0x40*/ UnityEngine.TextCore.Text.LinkInfo[] linkInfo;
                /*0x48*/ UnityEngine.TextCore.Text.LineInfo[] lineInfo;
                /*0x50*/ UnityEngine.TextCore.Text.MeshInfo[] meshInfo;
                /*0x58*/ double lastTimeInCache;
                /*0x60*/ System.Action removedFromCache;
                /*0x68*/ bool hasMultipleColors;

                static /*0x3edc310*/ TextInfo();
                static /*0x1f36244*/ void Resize<T>(ref T[] array, int size);
                static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
                static /*0x3edc030*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
                static /*0x3edc1f4*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
                /*0x3edae40*/ TextInfo();
                /*0x3edb428*/ void RemoveFromCache();
                /*0x3edba54*/ void Clear();
                /*0x3edbaa8*/ void ClearMeshInfo(bool updateMesh);
                /*0x3edbb1c*/ void ClearLineInfo();
                /*0x3edbc9c*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, UnityEngine.Rect screenRect, float lineHeight, bool inverseYAxis);
                /*0x3ed8e1c*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, UnityEngine.Rect screenRect, float lineHeight, bool useXAdvance, bool inverseYAxis);
                /*0x3ed904c*/ int GetCursorIndexFromPosition(UnityEngine.Vector2 position, UnityEngine.Rect screenRect, bool inverseYAxis);
                /*0x3ed917c*/ int LineDownCharacterPosition(int originalPos);
                /*0x3ed9324*/ int LineUpCharacterPosition(int originalPos);
                /*0x3edbd20*/ int FindNearestLine(UnityEngine.Vector2 position);
                /*0x3edbdbc*/ int FindNearestCharacterOnLine(UnityEngine.Vector2 position, int line, bool visibleOnly);
                /*0x3ed9540*/ int FindIntersectingLink(UnityEngine.Vector3 position, UnityEngine.Rect screenRect, bool inverseYAxis);
                /*0x3ed9828*/ int GetCorrespondingStringIndex(int index);
                /*0x3ed9960*/ UnityEngine.TextCore.Text.LineInfo GetLineInfoFromCharacterIndex(int index);
                /*0x3ed9a28*/ int GetLineNumber(int index);
                /*0x3ed9af0*/ float GetLineHeight(int lineNumber);
                /*0x3ed9bb8*/ float GetLineHeightFromCharacterIndex(int index);
                /*0x3ed9c80*/ float GetCharacterHeightFromIndex(int index);
                /*0x3ed9d38*/ string Substring(int startIndex, int length);
                /*0x3eda3fc*/ int IndexOf(char value, int startIndex);
                /*0x3eda568*/ int LastIndexOf(char value, int startIndex);
            }

            enum MarkupTag
            {
                BOLD = 66,
                SLASH_BOLD = 1613,
                ITALIC = 73,
                SLASH_ITALIC = 1606,
                UNDERLINE = 85,
                SLASH_UNDERLINE = 1626,
                STRIKETHROUGH = 83,
                SLASH_STRIKETHROUGH = 1628,
                MARK = 2699125,
                SLASH_MARK = 57644506,
                SUBSCRIPT = 92132,
                SLASH_SUBSCRIPT = 1770219,
                SUPERSCRIPT = 92150,
                SLASH_SUPERSCRIPT = 1770233,
                COLOR = 81999901,
                SLASH_COLOR = 1909026194,
                ALPHA = 75165780,
                A = 65,
                SLASH_A = 1614,
                SIZE = 3061285,
                SLASH_SIZE = 58429962,
                SPRITE = -991527447,
                NO_BREAK = 2856657,
                SLASH_NO_BREAK = 57477502,
                STYLE = 100252951,
                SLASH_STYLE = 1927738392,
                FONT = 2586451,
                SLASH_FONT = 57747708,
                SLASH_MATERIAL = -1100708252,
                LINK = 2656128,
                SLASH_LINK = 57686191,
                FONT_WEIGHT = -1889896162,
                SLASH_FONT_WEIGHT = -757976431,
                NO_PARSE = -408011596,
                SLASH_NO_PARSE = -294095813,
                POSITION = 85420,
                SLASH_POSITION = 1777699,
                VERTICAL_OFFSET = 1952379995,
                SLASH_VERTICAL_OFFSET = -11107948,
                SPACE = 100083556,
                SLASH_SPACE = 1927873067,
                PAGE = 2808691,
                SLASH_PAGE = 58683868,
                ALIGN = 75138797,
                SLASH_ALIGN = 1916026786,
                WIDTH = 105793766,
                SLASH_WIDTH = 1923459625,
                GRADIENT = -1999759898,
                SLASH_GRADIENT = -1854491959,
                CHARACTER_SPACE = -1584382009,
                SLASH_CHARACTER_SPACE = -1394426712,
                MONOSPACE = -1340221943,
                SLASH_MONOSPACE = -1638865562,
                CLASS = 82115566,
                INDENT = -1514123076,
                SLASH_INDENT = -1496889389,
                LINE_INDENT = -844305121,
                SLASH_LINE_INDENT = 93886352,
                MARGIN = -1355614050,
                SLASH_MARGIN = -1649644303,
                MARGIN_LEFT = -272933656,
                MARGIN_RIGHT = -447416589,
                LINE_HEIGHT = -799081892,
                SLASH_LINE_HEIGHT = 200452819,
                ACTION = -1827519330,
                SLASH_ACTION = -1187217679,
                SCALE = 100553336,
                SLASH_SCALE = 1928413879,
                ROTATE = -1000007783,
                SLASH_ROTATE = -764695562,
                TABLE = 226476955,
                SLASH_TABLE = -979118220,
                TH = 5862489,
                SLASH_TH = 193346070,
                TR = 5862467,
                SLASH_TR = 193346060,
                TD = 5862485,
                SLASH_TD = 193346074,
                LOWERCASE = -1506899689,
                SLASH_LOWERCASE = -1451284584,
                ALLCAPS = 218273952,
                SLASH_ALLCAPS = -797437649,
                UPPERCASE = -305409418,
                SLASH_UPPERCASE = -582368199,
                SMALLCAPS = -766062114,
                SLASH_SMALLCAPS = 199921873,
                LIGA = 2655971,
                SLASH_LIGA = 57686604,
                FRAC = 2598518,
                SLASH_FRAC = 57774681,
                NAME = 2875623,
                INDEX = 84268030,
                TINT = 2960519,
                ANIM = 2283339,
                MATERIAL = 825491659,
                HREF = 2535353,
                ANGLE = 75347905,
                PADDING = -2144568463,
                FAMILYNAME = 704251153,
                STYLENAME = -1207081936,
                DUOSPACE = 582810522,
                RED = 91635,
                GREEN = 87065851,
                BLUE = 2457214,
                YELLOW = -882444668,
                ORANGE = -1108587920,
                BLACK = 81074727,
                WHITE = 105680263,
                PURPLE = -1250222130,
                GREY = 2638345,
                LIGHTBLUE = 341063360,
                TEAL = 2947772,
                CYAN = 2504597,
                DARKBLUE = -1960309918,
                FUCHSIA = -1002715645,
                SILVER = -960329321,
                BROWN = 81017702,
                MAROON = -1355621936,
                OLIVE = 95492953,
                NAVY = 2876352,
                AQUA = 2284356,
                MAGENTA = -1812576107,
                TRANSPARENT = -1014785338,
                LIME = 2656045,
                BR = 2256,
                CR = 2289,
                ZWSP = 3288238,
                ZWJ = 99623,
                NBSP = 2869039,
                SHY = 92674,
                LEFT = 2660507,
                RIGHT = 99937376,
                CENTER = -1591113269,
                JUSTIFIED = 817091359,
                FLUSH = 85552164,
                NONE = 2857034,
                PLUS = 43,
                MINUS = 45,
                PX = 2568,
                PLUS_PX = 49507,
                MINUS_PX = 47461,
                EM = 2216,
                PLUS_EM = 49091,
                MINUS_EM = 46789,
                PCT = 85031,
                PLUS_PCT = 1634348,
                MINUS_PCT = 1567082,
                PERCENTAGE = 37,
                PLUS_PERCENTAGE = 1454,
                MINUS_PERCENTAGE = 1512,
                TRUE = 2932022,
                FALSE = 85422813,
                INVALID = 1585415185,
                NOTDEF = 612146780,
                NORMAL = -1183493901,
                DEFAULT = -620974005,
                REGULAR = 1291372090,
            }

            enum TagValueType
            {
                None = 0,
                NumericalValue = 1,
                StringValue = 2,
                ColorValue = 4,
            }

            enum TagUnitType
            {
                Pixels = 0,
                FontUnits = 1,
                Percentage = 2,
            }

            enum TextProcessingElementType
            {
                Undefined = 0,
                TextCharacterElement = 1,
                TextMarkupElement = 2,
            }

            struct FontStyleStack
            {
                /*0x10*/ byte bold;
                /*0x11*/ byte italic;
                /*0x12*/ byte underline;
                /*0x13*/ byte strikethrough;
                /*0x14*/ byte highlight;
                /*0x15*/ byte superscript;
                /*0x16*/ byte subscript;
                /*0x17*/ byte uppercase;
                /*0x18*/ byte lowercase;
                /*0x19*/ byte smallcaps;

                /*0x3edc37c*/ void Clear();
                /*0x3edc388*/ byte Add(UnityEngine.TextCore.Text.FontStyles style);
                /*0x3edc48c*/ byte Remove(UnityEngine.TextCore.Text.FontStyles style);
            }

            struct TextProcessingStack<T>
            {
                static int k_DefaultCapacity = 4;
                /*0x0*/ T[] itemStack;
                /*0x0*/ int index;
                /*0x0*/ T m_DefaultItem;
                /*0x0*/ int m_Capacity;
                /*0x0*/ int m_RolloverSize;
                /*0x0*/ int m_Count;

                static /*0x1ffc854*/ void SetDefault(UnityEngine.TextCore.Text.TextProcessingStack<T> stack, T item);
                /*0x1f30ebc*/ TextProcessingStack(T[] stack);
                /*0x1f30b78*/ TextProcessingStack(int capacity);
                /*0x1f30bb4*/ TextProcessingStack(int capacity, int rolloverSize);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1ffc854*/ T get_current();
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ void SetDefault(T item);
                /*0x1ffc854*/ void Add(T item);
                /*0x1ffc854*/ T Remove();
                /*0x1ffc854*/ void Push(T item);
                /*0x1ffc854*/ T Pop();
                /*0x1ffc854*/ T Peek();
                /*0x1ffc854*/ T CurrentItem();
            }

            class TextResourceManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup;
                static /*0x10*/ System.Collections.Generic.Dictionary<long, UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;
                static /*0x18*/ System.Collections.Generic.List<int> s_FontAssetRemovalList;
                static /*0x20*/ int k_RegularStyleHashCode;

                static /*0x3edcb48*/ TextResourceManager();
                static /*0x3edc5b4*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);

                struct FontAssetRef
                {
                    /*0x10*/ int nameHashCode;
                    /*0x14*/ int familyNameHashCode;
                    /*0x18*/ int styleNameHashCode;
                    /*0x20*/ long familyNameAndStyleHashCode;
                    /*0x28*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x3edcb20*/ FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }
            }

            class TextShaderUtilities
            {
                static /*0x0*/ int ID_MainTex;
                static /*0x4*/ int ID_FaceTex;
                static /*0x8*/ int ID_FaceColor;
                static /*0xc*/ int ID_FaceDilate;
                static /*0x10*/ int ID_Shininess;
                static /*0x14*/ int ID_OutlineOffset1;
                static /*0x18*/ int ID_OutlineOffset2;
                static /*0x1c*/ int ID_OutlineOffset3;
                static /*0x20*/ int ID_OutlineMode;
                static /*0x24*/ int ID_IsoPerimeter;
                static /*0x28*/ int ID_Softness;
                static /*0x2c*/ int ID_UnderlayColor;
                static /*0x30*/ int ID_UnderlayOffsetX;
                static /*0x34*/ int ID_UnderlayOffsetY;
                static /*0x38*/ int ID_UnderlayDilate;
                static /*0x3c*/ int ID_UnderlaySoftness;
                static /*0x40*/ int ID_UnderlayOffset;
                static /*0x44*/ int ID_UnderlayIsoPerimeter;
                static /*0x48*/ int ID_WeightNormal;
                static /*0x4c*/ int ID_WeightBold;
                static /*0x50*/ int ID_OutlineTex;
                static /*0x54*/ int ID_OutlineWidth;
                static /*0x58*/ int ID_OutlineSoftness;
                static /*0x5c*/ int ID_OutlineColor;
                static /*0x60*/ int ID_Outline2Color;
                static /*0x64*/ int ID_Outline2Width;
                static /*0x68*/ int ID_Padding;
                static /*0x6c*/ int ID_GradientScale;
                static /*0x70*/ int ID_ScaleX;
                static /*0x74*/ int ID_ScaleY;
                static /*0x78*/ int ID_PerspectiveFilter;
                static /*0x7c*/ int ID_Sharpness;
                static /*0x80*/ int ID_TextureWidth;
                static /*0x84*/ int ID_TextureHeight;
                static /*0x88*/ int ID_BevelAmount;
                static /*0x8c*/ int ID_GlowColor;
                static /*0x90*/ int ID_GlowOffset;
                static /*0x94*/ int ID_GlowPower;
                static /*0x98*/ int ID_GlowOuter;
                static /*0x9c*/ int ID_GlowInner;
                static /*0xa0*/ int ID_LightAngle;
                static /*0xa4*/ int ID_EnvMap;
                static /*0xa8*/ int ID_EnvMatrix;
                static /*0xac*/ int ID_EnvMatrixRotation;
                static /*0xb0*/ int ID_MaskCoord;
                static /*0xb4*/ int ID_ClipRect;
                static /*0xb8*/ int ID_MaskSoftnessX;
                static /*0xbc*/ int ID_MaskSoftnessY;
                static /*0xc0*/ int ID_VertexOffsetX;
                static /*0xc4*/ int ID_VertexOffsetY;
                static /*0xc8*/ int ID_UseClipRect;
                static /*0xcc*/ int ID_StencilID;
                static /*0xd0*/ int ID_StencilOp;
                static /*0xd4*/ int ID_StencilComp;
                static /*0xd8*/ int ID_StencilReadMask;
                static /*0xdc*/ int ID_StencilWriteMask;
                static /*0xe0*/ int ID_ShaderFlags;
                static /*0xe4*/ int ID_ScaleRatio_A;
                static /*0xe8*/ int ID_ScaleRatio_B;
                static /*0xec*/ int ID_ScaleRatio_C;
                static /*0xf0*/ string Keyword_Bevel;
                static /*0xf8*/ string Keyword_Glow;
                static /*0x100*/ string Keyword_Underlay;
                static /*0x108*/ string Keyword_Ratios;
                static /*0x110*/ string Keyword_MASK_SOFT;
                static /*0x118*/ string Keyword_MASK_HARD;
                static /*0x120*/ string Keyword_MASK_TEX;
                static /*0x128*/ string Keyword_Outline;
                static /*0x130*/ string ShaderTag_ZTestMode;
                static /*0x138*/ string ShaderTag_CullMode;
                static /*0x140*/ float m_clamp;
                static /*0x144*/ bool isInitialized;
                static /*0x148*/ string k_SDFText;
                static /*0x150*/ string k_BitmapText;
                static /*0x158*/ string k_SpriteText;
                static /*0x160*/ UnityEngine.Shader k_ShaderRef_MobileSDF;
                static /*0x168*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;
                static /*0x170*/ UnityEngine.Shader k_ShaderRef_Sprite;

                static /*0x3edd090*/ TextShaderUtilities();
                static /*0x3edcd88*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
                static /*0x3edce38*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
                static /*0x3edcf24*/ UnityEngine.Shader get_ShaderRef_Sprite();
                static /*0x3edd32c*/ void GetShaderPropertyIDs();
            }

            class TextUtilities
            {
                static /*0x3eddee0*/ char ToUpperFast(char c);
                static /*0x3edcd18*/ int GetHashCodeCaseInSensitive(string s);
                static /*0x3eddf54*/ int GetTextFontWeightIndex(UnityEngine.TextCore.Text.TextFontWeight fontWeight);
            }

            class UnicodeLineBreakingRules
            {
                /*0x10*/ UnityEngine.TextAsset m_UnicodeLineBreakingRules;
                /*0x18*/ UnityEngine.TextAsset m_LeadingCharacters;
                /*0x20*/ UnityEngine.TextAsset m_FollowingCharacters;
                /*0x28*/ bool m_UseModernHangulLineBreakingRules;
                /*0x30*/ System.Collections.Generic.HashSet<uint> m_LeadingCharactersLookup;
                /*0x38*/ System.Collections.Generic.HashSet<uint> m_FollowingCharactersLookup;

                static /*0x3ede25c*/ System.Collections.Generic.HashSet<uint> GetCharacters(UnityEngine.TextAsset file);
                /*0x3ede34c*/ UnicodeLineBreakingRules();
                /*0x3eddfe8*/ System.Collections.Generic.HashSet<uint> get_leadingCharactersLookup();
                /*0x3ede230*/ System.Collections.Generic.HashSet<uint> get_followingCharactersLookup();
                /*0x3ede254*/ bool get_useModernHangulLineBreakingRules();
                /*0x3ede00c*/ void LoadLineBreakingRules();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 5E4436000B53AC505FD7CB9E80FF70C5BA5B44441C00C6F0B891C673FEE1E7D2;
    static /*0x12f0*/ <PrivateImplementationDetails> EC5D648DA3EF6677AD390F11A61371CC7A7A89F9355DDDACC33ADB5AE069596B;

    struct __StaticArrayInitTypeSize=4848
    {
    }

    struct __StaticArrayInitTypeSize=5724
    {
    }
}
