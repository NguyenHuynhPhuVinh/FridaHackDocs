class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7f6121c*/ EmbeddedAttribute();
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

                /*0x7f61224*/ NullableAttribute(byte );
                /*0x7f612ac*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7f612dc*/ NullableContextAttribute(byte );
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
            /*0x18*/ nint[] globalFontAssetFallbacks;
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

            static /*0x7f6143c*/ UnityEngine.TextCore.NativeTextGenerationSettings get_Default();
            /*0x7f61304*/ bool get_hasLink();
            /*0x7f61418*/ UnityEngine.TextCore.TextSpan CreateTextSpan();
            /*0x7f61488*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.TextCore.NativeTextGenerationSettings.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.TextCore.TextSpan> <>9__20_0;

                static /*0x7f62280*/ <>c();
                /*0x7f622e8*/ <>c();
                /*0x7f622f0*/ bool <get_hasLink>b__20_0(UnityEngine.TextCore.TextSpan span);
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

            /*0x7f61e9c*/ string ToString();
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

            static /*0x7f649b4*/ RichTextTagParser();
            static /*0x7f62300*/ bool tagMatch(System.ReadOnlySpan<char> tagCandidate, string tagName);
            static /*0x7f62428*/ bool SpanToEnum(System.ReadOnlySpan<char> tagCandidate, ref UnityEngine.TextCore.RichTextTagParser.TagType tagType, ref string error, ref System.ReadOnlySpan<char> attribute);
            static /*0x7f626a4*/ System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> FindTags(string inputStr, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.ParseError> errors);
            static /*0x7f632a4*/ System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> PickResultingTags(System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> allTags, string input, int atPosition, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> applicableTags);
            static /*0x7f63bd0*/ UnityEngine.TextCore.RichTextTagParser.Segment[] GenerateSegments(string input, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags);
            static /*0x7f63e7c*/ void ApplyStateToSegment(string input, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags, UnityEngine.TextCore.RichTextTagParser.Segment[] segments);
            static /*0x7f63f5c*/ int AddLink(UnityEngine.TextCore.RichTextTagParser.TagType type, string value, System.Collections.Generic.List<System.ValueTuple<int, UnityEngine.TextCore.RichTextTagParser.TagType, string>> links);
            static /*0x7f64198*/ UnityEngine.TextCore.TextSpan CreateTextSpan(UnityEngine.TextCore.RichTextTagParser.Segment segment, ref UnityEngine.TextCore.NativeTextGenerationSettings tgs, System.Collections.Generic.List<System.ValueTuple<int, UnityEngine.TextCore.RichTextTagParser.TagType, string>> links, UnityEngine.Color hyperlinkColor);
            static /*0x7f646c4*/ void CreateTextGenerationSettingsArray(ref UnityEngine.TextCore.NativeTextGenerationSettings tgs, System.Collections.Generic.List<System.ValueTuple<int, UnityEngine.TextCore.RichTextTagParser.TagType, string>> links, UnityEngine.Color hyperlinkColor);

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

                /*0x7f65878*/ TagTypeInfo(UnityEngine.TextCore.RichTextTagParser.TagType tagType, string name, UnityEngine.TextCore.RichTextTagParser.TagValueType valueType, UnityEngine.TextCore.RichTextTagParser.TagUnitType unitType);
                /*0x7f658c8*/ System.Type get_EqualityContract();
                /*0x7f65928*/ string ToString();
                /*0x7f65a10*/ bool PrintMembers(System.Text.StringBuilder builder);
                /*0x7f65bd8*/ int GetHashCode();
                /*0x7f65d50*/ bool Equals(object obj);
                /*0x7f65dd8*/ bool Equals(UnityEngine.TextCore.RichTextTagParser.TagTypeInfo other);
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

                /*0x7f63224*/ TagValue(UnityEngine.Color value);
                /*0x7f6326c*/ TagValue(string value);
                /*0x7f65f6c*/ System.Type get_EqualityContract();
                /*0x7f645fc*/ string get_StringValue();
                /*0x7f64660*/ float get_NumericalValue();
                /*0x7f64594*/ UnityEngine.Color get_ColorValue();
                /*0x7f65fcc*/ string ToString();
                /*0x7f660b4*/ bool PrintMembers(System.Text.StringBuilder builder);
                /*0x7f660bc*/ int GetHashCode();
                /*0x7f66238*/ bool Equals(object obj);
                /*0x7f662c0*/ bool Equals(UnityEngine.TextCore.RichTextTagParser.TagValue other);
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

                /*0x7f631e8*/ ParseError(string message, int position);
                /*0x7f6645c*/ System.Type get_EqualityContract();
                /*0x7f664bc*/ string ToString();
                /*0x7f665a4*/ bool PrintMembers(System.Text.StringBuilder builder);
                /*0x7f6665c*/ int GetHashCode();
                /*0x7f66754*/ bool Equals(object obj);
                /*0x7f667dc*/ bool Equals(UnityEngine.TextCore.RichTextTagParser.ParseError other);
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
            }

            class Character : UnityEngine.TextCore.Text.TextElement
            {
                /*0x7f66900*/ Character();
                /*0x7f6692c*/ Character(uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
                /*0x7f669c8*/ Character(uint unicode, uint glyphIndex);
            }

            class ColorUtilities
            {
                static /*0x7f66a44*/ bool CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b);
                static /*0x7f66a54*/ UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
            }

            class FastAction
            {
                /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

                /*0x7f66b0c*/ FastAction();
            }

            class FastAction<A>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
                /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

                /*0x380cb08*/ FastAction();
            }

            class FastAction<A, B>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
                /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

                /*0x380cb08*/ FastAction();
                /*0x3907c14*/ void Call(A a, B b);
            }

            class FastAction<A, B, C>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
                /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

                /*0x380cb08*/ FastAction();
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

                /*0x7f66c00*/ FontFeatureTable();
                /*0x7f66be8*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
                /*0x7f66bf0*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords();
                /*0x7f66bf8*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords();
                /*0x7f66eb4*/ void SortGlyphPairAdjustmentRecords();
                /*0x7f670c0*/ void SortMarkToBaseAdjustmentRecords();
                /*0x7f672d8*/ void SortMarkToMarkAdjustmentRecords();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontFeatureTable.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__24_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__24_1;
                    static /*0x18*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__25_0;
                    static /*0x20*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__25_1;
                    static /*0x28*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__26_0;
                    static /*0x30*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__26_1;

                    static /*0x7f674f0*/ <>c();
                    /*0x7f67558*/ <>c();
                    /*0x7f67560*/ uint <SortGlyphPairAdjustmentRecords>b__24_0(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x7f675a8*/ uint <SortGlyphPairAdjustmentRecords>b__24_1(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x7f675f0*/ uint <SortMarkToBaseAdjustmentRecords>b__25_0(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s);
                    /*0x7f675fc*/ uint <SortMarkToBaseAdjustmentRecords>b__25_1(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s);
                    /*0x7f67608*/ uint <SortMarkToMarkAdjustmentRecords>b__26_0(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s);
                    /*0x7f67614*/ uint <SortMarkToMarkAdjustmentRecords>b__26_1(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s);
                }
            }

            struct Extents
            {
                /*0x10*/ UnityEngine.Vector2 min;
                /*0x18*/ UnityEngine.Vector2 max;

                /*0x7f67620*/ string ToString();
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

                /*0x7f67848*/ void SetLinkId(char[] text, int startIndex, int length);
                /*0x7f67950*/ string GetLinkText(UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f67a48*/ string GetLinkId();
            }

            class MaterialManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<long, UnityEngine.Material> s_FallbackMaterials;

                static /*0x7f68390*/ MaterialManager();
                static /*0x7f67aa0*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
                static /*0x7f68158*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
                static /*0x7f67ed0*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);
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

                static /*0x7f684a0*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                static /*0x7f6869c*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                /*0x7f68428*/ MaterialReference(int index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
            }

            class MaterialReferenceManager
            {
                static /*0x0*/ UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance;
                /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup;
                /*0x28*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup;

                static /*0x7f68898*/ UnityEngine.TextCore.Text.MaterialReferenceManager get_instance();
                static /*0x7f68a9c*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7f68bb0*/ void AddSpriteAsset(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x7f68cbc*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
                static /*0x7f68d54*/ void AddColorGradientPreset(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                static /*0x7f68e28*/ bool TryGetFontAsset(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7f68ed0*/ bool TryGetSpriteAsset(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x7f68f78*/ bool TryGetColorGradientPreset(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                static /*0x7f69020*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
                /*0x7f68918*/ MaterialReferenceManager();
                /*0x7f68abc*/ void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x7f68be0*/ void AddSpriteAssetInternal(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x7f68cec*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
                /*0x7f68d84*/ void AddColorGradientPreset_Internal(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                /*0x7f68e58*/ bool TryGetFontAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x7f68f00*/ bool TryGetSpriteAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x7f68fa8*/ bool TryGetColorGradientPresetInternal(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                /*0x7f69050*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
            }

            struct MeshInfoBindings
            {
                /*0x10*/ UnityEngine.TextCore.Text.TextCoreVertex[] vertexData;
                /*0x18*/ UnityEngine.Material material;
                /*0x20*/ int vertexCount;
            }

            enum VertexSortingOrder
            {
                Normal = 0,
                Reverse = 1,
            }

            enum VertexDataLayout
            {
                Mesh = 0,
                VBO = 1,
            }

            struct MeshInfo
            {
                static /*0x0*/ UnityEngine.Color32 k_DefaultColor;
                static /*0x4*/ UnityEngine.Vector3 k_DefaultNormal;
                static /*0x10*/ UnityEngine.Vector4 k_DefaultTangent;
                /*0x10*/ int vertexCount;
                /*0x18*/ UnityEngine.TextCore.Text.TextCoreVertex[] vertexData;
                /*0x20*/ UnityEngine.Material material;
                /*0x28*/ UnityEngine.Vector3[] vertices;
                /*0x30*/ UnityEngine.Vector3[] normals;
                /*0x38*/ UnityEngine.Vector4[] tangents;
                /*0x40*/ int vertexBufferSize;
                /*0x48*/ UnityEngine.Vector4[] uvs0;
                /*0x50*/ UnityEngine.Vector2[] uvs2;
                /*0x58*/ UnityEngine.Color32[] colors32;
                /*0x60*/ int[] triangles;
                /*0x68*/ UnityEngine.TextCore.Text.VertexDataLayout vertexDataLayout;
                /*0x6c*/ bool applySDF;
                /*0x70*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode;

                static /*0x7f6a164*/ MeshInfo();
                /*0x7f690c8*/ MeshInfo(int size, UnityEngine.TextCore.Text.VertexDataLayout layout, bool isIMGUI);
                /*0x7f695fc*/ void ResizeMeshInfo(int size, bool isIMGUI);
                /*0x7f6982c*/ void Clear(bool uploadChanges);
                /*0x7f6989c*/ void ClearUnusedVertices();
                /*0x7f69924*/ void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder order);
                /*0x7f699d8*/ void SwapVertexData(int src, int dst);
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

                static /*0x7f76630*/ FontAsset();
                static /*0x3839e58*/ void EnsureAdditionalCapacity<T>(System.Collections.Generic.List<T> container, int additionalCapacity);
                static /*0x3839e58*/ void EnsureAdditionalCapacity<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> container, int additionalCapacity);
                static /*0x7f6a978*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, int pointSize);
                static /*0x7f6ab78*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize);
                static /*0x7f6ade8*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, float pointSize, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode);
                static /*0x7f6aee4*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> CreateFontAssetOSFallbackList(string[] fallbacksFamilyNames, UnityEngine.Shader shader, float pointSize);
                static /*0x7f6b228*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetWithOSFallbackList(string[] fallbacksFamilyNames, UnityEngine.Shader shader, float pointSize);
                static /*0x7f6b0a0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetFromFamilyName(string familyName, UnityEngine.Shader shader, float pointSize);
                static /*0x7f6b444*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight);
                static /*0x7f6ac5c*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, float samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x7f6b9f8*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font);
                static /*0x7f6bb38*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.Shader shader, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x7f6ba74*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x7f6bf60*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, float samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x7f6bbf4*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int faceIndex, float samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.Shader shader, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x7f6b4f4*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x7f6c024*/ UnityEngine.TextCore.Text.FontAsset GetFontAssetByID(int id);
                static /*0x383b458*/ void InitializeLookup<T>(System.Collections.ICollection source, ref System.Collections.Generic.Dictionary<uint, T> lookup, int defaultCapacity);
                static /*0x383b458*/ void InitializeList<T>(System.Collections.ICollection source, ref System.Collections.Generic.List<T> list, int defaultCapacity);
                static /*0x7f6fe30*/ string GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7f6ff24*/ int[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7f70a8c*/ void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7f70bc8*/ void RegisterFontAssetForKerningUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7f70d04*/ void UpdateFontFeaturesForFontAssetsInQueue();
                static /*0x7f71008*/ void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture);
                static /*0x7f71144*/ void UpdateAtlasTexturesInQueue();
                static /*0x7f712bc*/ void UpdateFontAssetsInUpdateQueue();
                static /*0x7f758b8*/ void UpdateFallbacks(nint ptr, nint[] fallbacks);
                static /*0x7f75a34*/ void UpdateWeightFallbacks(nint ptr, nint[] regularFallbacks, nint[] italicFallbacks);
                static /*0x7f754fc*/ nint Create(UnityEngine.TextCore.FaceInfo faceInfo, UnityEngine.Font sourceFontFile, UnityEngine.Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, nint[] fallbacks, nint[] weightFallbacks, nint[] italicFallbacks);
                static /*0x7f75c10*/ void UpdateFaceInfo(nint ptr, UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x7f6c600*/ void Destroy(nint ptr);
                static /*0x7f7607c*/ void UpdateFallbacks_Injected(nint ptr, ref UnityEngine.Bindings.ManagedSpanWrapper fallbacks);
                static /*0x7f760c0*/ void UpdateWeightFallbacks_Injected(nint ptr, ref UnityEngine.Bindings.ManagedSpanWrapper regularFallbacks, ref UnityEngine.Bindings.ManagedSpanWrapper italicFallbacks);
                static /*0x7f76114*/ nint Create_Injected(ref UnityEngine.TextCore.FaceInfo faceInfo, nint sourceFontFile, nint sourceFont_EditorRef, ref UnityEngine.Bindings.ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref UnityEngine.Bindings.ManagedSpanWrapper fallbacks, ref UnityEngine.Bindings.ManagedSpanWrapper weightFallbacks, ref UnityEngine.Bindings.ManagedSpanWrapper italicFallbacks);
                static /*0x7f761a0*/ void UpdateFaceInfo_Injected(nint ptr, ref UnityEngine.TextCore.FaceInfo faceInfo);
                /*0x7f762b8*/ FontAsset();
                /*0x7f6a1d8*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings();
                /*0x7f6a1f4*/ void set_fontAssetCreationEditorSettings(UnityEngine.TextCore.Text.FontAssetCreationEditorSettings value);
                /*0x7f6a218*/ UnityEngine.Font get_sourceFontFile();
                /*0x7f6a220*/ void set_sourceFontFile(UnityEngine.Font value);
                /*0x7f6a228*/ UnityEngine.TextCore.Text.AtlasPopulationMode get_atlasPopulationMode();
                /*0x7f6a230*/ void set_atlasPopulationMode(UnityEngine.TextCore.Text.AtlasPopulationMode value);
                /*0x7f6a238*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x7f6a254*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x7f6a278*/ int get_familyNameHashCode();
                /*0x7f6a2a8*/ void set_familyNameHashCode(int value);
                /*0x7f6a2b0*/ int get_styleNameHashCode();
                /*0x7f6a2e0*/ void set_styleNameHashCode(int value);
                /*0x7f6a2e8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
                /*0x7f6a2f0*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
                /*0x7f6a300*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
                /*0x7f6a72c*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable();
                /*0x7f6a734*/ void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value);
                /*0x7f6a744*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> get_characterLookupTable();
                /*0x7f6a768*/ UnityEngine.Texture2D get_atlasTexture();
                /*0x7f6a800*/ UnityEngine.Texture2D[] get_atlasTextures();
                /*0x7f6a808*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
                /*0x7f6a818*/ int get_atlasTextureCount();
                /*0x7f6a824*/ bool get_isMultiAtlasTexturesEnabled();
                /*0x7f6a82c*/ void set_isMultiAtlasTexturesEnabled(bool value);
                /*0x7f6a838*/ bool get_getFontFeatures();
                /*0x7f6a840*/ void set_getFontFeatures(bool value);
                /*0x7f6a84c*/ bool get_clearDynamicDataOnBuild();
                /*0x7f6a854*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x7f6a860*/ int get_atlasWidth();
                /*0x7f6a868*/ void set_atlasWidth(int value);
                /*0x7f6a870*/ int get_atlasHeight();
                /*0x7f6a878*/ void set_atlasHeight(int value);
                /*0x7f6a880*/ int get_atlasPadding();
                /*0x7f6a888*/ void set_atlasPadding(int value);
                /*0x7f6a890*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
                /*0x7f6a898*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
                /*0x7f6a8a0*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
                /*0x7f6a8a8*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x7f6a8b8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
                /*0x7f6a8c0*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x7f6a8d0*/ UnityEngine.TextCore.Text.FontFeatureTable get_fontFeatureTable();
                /*0x7f6a8d8*/ void set_fontFeatureTable(UnityEngine.TextCore.Text.FontFeatureTable value);
                /*0x7f6a8e8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable();
                /*0x7f6a8f0*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x7f6a900*/ UnityEngine.TextCore.Text.FontWeightPair[] get_fontWeightTable();
                /*0x7f6a908*/ void set_fontWeightTable(UnityEngine.TextCore.Text.FontWeightPair[] value);
                /*0x7f6a918*/ float get_regularStyleWeight();
                /*0x7f6a920*/ void set_regularStyleWeight(float value);
                /*0x7f6a928*/ float get_regularStyleSpacing();
                /*0x7f6a930*/ void set_regularStyleSpacing(float value);
                /*0x7f6a938*/ float get_boldStyleWeight();
                /*0x7f6a940*/ void set_boldStyleWeight(float value);
                /*0x7f6a948*/ float get_boldStyleSpacing();
                /*0x7f6a950*/ void set_boldStyleSpacing(float value);
                /*0x7f6a958*/ byte get_italicStyleSlant();
                /*0x7f6a960*/ void set_italicStyleSlant(byte value);
                /*0x7f6a968*/ byte get_tabMultiple();
                /*0x7f6a970*/ void set_tabMultiple(byte value);
                /*0x7f6c0a4*/ void RegisterCallbackInstance(UnityEngine.TextCore.Text.FontAsset instance);
                /*0x7f6c39c*/ void OnDestroy();
                /*0x7f6a324*/ void ReadFontAssetDefinition();
                /*0x7f6c63c*/ void InitializeDictionaryLookupTables();
                /*0x7f6c864*/ void InitializeGlyphLookupDictionary();
                /*0x7f6cb1c*/ void InitializeCharacterLookupDictionary();
                /*0x7f6d9e4*/ void ClearFallbackCharacterTable();
                /*0x7f6cea0*/ void InitializeLigatureSubstitutionLookupDictionary();
                /*0x7f6d298*/ void InitializeGlyphPairAdjustmentRecordsLookupDictionary();
                /*0x7f6d544*/ void InitializeMarkToBaseAdjustmentRecordsLookupDictionary();
                /*0x7f6d794*/ void InitializeMarkToMarkAdjustmentRecordsLookupDictionary();
                /*0x7f6c694*/ void AddSynthesizedCharactersAndFaceMetrics();
                /*0x7f6df20*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
                /*0x7f6e858*/ void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character);
                /*0x7f6e864*/ void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x7f6e900*/ bool GetCharacterInLookupCache(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref UnityEngine.TextCore.Text.Character character);
                /*0x7f6e99c*/ void RemoveCharacterInLookupCache(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x7f6ea28*/ bool ContainsCharacterInLookupCache(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x7f6e7fc*/ uint CreateCompositeKey(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x7f6dd98*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace();
                /*0x7f6eab4*/ void SortCharacterTable();
                /*0x7f6ec0c*/ void SortGlyphTable();
                /*0x7f6ed64*/ void SortFontFeatureTable();
                /*0x7f6ed98*/ void SortAllTables();
                /*0x7f6edb8*/ bool HasCharacter(int character);
                /*0x7f6ee2c*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
                /*0x7f6ee3c*/ bool HasCharacter(uint character, bool searchFallbacks, bool tryAddCharacter);
                /*0x7f6f718*/ bool HasCharacterWithStyle_Internal(uint character, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, bool searchFallbacks, bool tryAddCharacter);
                /*0x7f6f4e0*/ bool HasCharacter_Internal(uint character, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, bool searchFallbacks, bool tryAddCharacter);
                /*0x7f6f724*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
                /*0x7f6f8f0*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
                /*0x7f6fd54*/ bool HasCharacters(string text);
                /*0x7f7000c*/ uint GetGlyphIndex(uint unicode);
                /*0x7f70024*/ uint GetGlyphIndex(uint unicode, ref bool success);
                /*0x7f7014c*/ uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode);
                /*0x7f701d8*/ void UpdateFontAssetData();
                /*0x7f707cc*/ void ClearFontAssetData(bool setAtlasSizeToZero);
                /*0x7f70a68*/ void ClearCharacterAndGlyphTablesInternal();
                /*0x7f70308*/ void ClearCharacterAndGlyphTables();
                /*0x7f704d8*/ void ClearFontFeaturesTables();
                /*0x7f705ac*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
                /*0x7f6c4f8*/ void DestroyAtlasTextures();
                /*0x7f707ac*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
                /*0x7f7130c*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
                /*0x7f72af0*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
                /*0x7f72b10*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
                /*0x7f72cb8*/ bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex);
                /*0x7f72d64*/ bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, ref uint variantGlyphIndex);
                /*0x7f72e10*/ bool TryAddGlyphInternal(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph);
                /*0x7f73374*/ bool TryAddCharacterInternal(uint unicode, ref UnityEngine.TextCore.Text.Character character);
                /*0x7f6f178*/ bool TryAddCharacterInternal(uint unicode, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref UnityEngine.TextCore.Text.Character character, bool populateLigatures);
                /*0x7f72fb0*/ bool TryAddGlyphToAtlas(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph, bool populateLigatures);
                /*0x7f734f8*/ bool TryAddGlyphToTexture(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph, bool populateLigatures);
                /*0x7f725b4*/ bool TryAddGlyphsToNewAtlasTexture();
                /*0x7f73820*/ void SetupNewAtlasTexture();
                /*0x7f73388*/ UnityEngine.TextCore.Text.Character CreateCharacterAndAddToCache(uint unicode, UnityEngine.TextCore.Glyph glyph, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight);
                /*0x7f72a88*/ void UpdateFontFeaturesForNewlyAddedGlyphs();
                /*0x7f70fb0*/ void UpdateGlyphAdjustmentRecordsForNewGlyphs();
                /*0x7f70f50*/ void UpdateGPOSFontFeaturesForNewlyAddedGlyphs();
                /*0x7f6cdb0*/ void ImportFontFeatures();
                /*0x7f73a88*/ void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex);
                /*0x7f73b0c*/ void UpdateLigatureSubstitutionRecords();
                /*0x7f7482c*/ void AddLigatureSubstitutionRecords(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] records);
                /*0x7f73b84*/ void UpdateGlyphAdjustmentRecords();
                /*0x7f73d6c*/ void AddPairAdjustmentRecords(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] records);
                /*0x7f73bfc*/ void UpdateDiacriticalMarkAdjustmentRecords();
                /*0x7f740d8*/ void AddMarkToBaseAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] records);
                /*0x7f7447c*/ void AddMarkToMarkAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] records);
                /*0x7f74d10*/ nint get_nativeFontAsset();
                /*0x7f75844*/ void UpdateFallbacks();
                /*0x7f759b0*/ void UpdateWeightFallbacks();
                /*0x7f75b80*/ void UpdateFaceInfo();
                /*0x7f74e2c*/ nint[] GetFallbacks();
                /*0x7f75c94*/ bool HasRecursion(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x7f75d28*/ bool HasRecursionInternal(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x7f75214*/ System.ValueTuple<System.IntPtr[], System.IntPtr[]> GetWeightFallbacks();
                /*0x7f761e4*/ void Finalize();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.Character, uint> <>9__191_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__192_0;

                    static /*0x7f9a4a0*/ <>c();
                    /*0x7f9a508*/ <>c();
                    /*0x7f9a510*/ uint <SortCharacterTable>b__191_0(UnityEngine.TextCore.Text.Character c);
                    /*0x7f9a530*/ uint <SortGlyphTable>b__192_0(UnityEngine.TextCore.Glyph c);
                }
            }

            class FontAssetFactory
            {
                static /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.TextCore.Text.FontAsset> visitedFontAssets;
                static /*0x8*/ string k_SystemFontName;

                static /*0x7f9af94*/ FontAssetFactory();
                static /*0x7f9a548*/ UnityEngine.TextCore.Text.FontAsset CreateDefaultEditorFontAsset(UnityEngine.Font font, UnityEngine.Shader shader);
                static /*0x7f9ae0c*/ void SetupFontAssetSettings(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Shader shader);
                static /*0x7f9aed8*/ void SetHideFlags(UnityEngine.TextCore.Text.FontAsset fontAsset);
            }

            class FontAssetUtilities
            {
                static /*0x0*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;

                static /*0x7f9b054*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x7f9b16c*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x7f9b6e8*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAssetsInternal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> OSFallbackList, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x7f9b858*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAssetsInternal(uint unicode, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x7f9ba2c*/ UnityEngine.TextCore.Text.TextElement GetTextElementFromTextAssets(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> textAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface, bool populateLigatures);
                static /*0x7f9bec4*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
                static /*0x7f9bd08*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
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

                static /*0x7f9c98c*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x7f9caf8*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                static /*0x7f9cc80*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                static /*0x7f9cd44*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings);
                static /*0x7f9d034*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                static /*0x7f9d1c0*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, System.Collections.Generic.HashSet<int> searchedSpriteAssets, ref int spriteIndex);
                /*0x7f9d540*/ SpriteAsset();
                /*0x7f9c1a8*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x7f9c1c4*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x7f9c1e8*/ UnityEngine.Texture get_spriteSheet();
                /*0x7f9c1f0*/ void set_spriteSheet(UnityEngine.Texture value);
                /*0x7f9c258*/ float get_width();
                /*0x7f9c260*/ void set_width(float value);
                /*0x7f9c268*/ float get_height();
                /*0x7f9c270*/ void set_height(float value);
                /*0x7f9c278*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable();
                /*0x7f9c7ec*/ void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x7f9c184*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable();
                /*0x7f9c7f4*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x7f9c7fc*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable();
                /*0x7f9c804*/ void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value);
                /*0x7f9c80c*/ void Awake();
                /*0x7f9c29c*/ void UpdateLookupTables();
                /*0x7f9c830*/ int GetSpriteIndexFromHashcode(int hashCode);
                /*0x7f9c8b8*/ int GetSpriteIndexFromUnicode(uint unicode);
                /*0x7f9c94c*/ int GetSpriteIndexFromName(string name);
                /*0x7f9d284*/ void SortGlyphTable();
                /*0x7f9d3d4*/ void SortCharacterTable();
                /*0x7f9d528*/ void SortGlyphAndCharacterTables();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.SpriteAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.SpriteGlyph, uint> <>9__44_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Text.SpriteCharacter, uint> <>9__45_0;

                    static /*0x7f9d628*/ <>c();
                    /*0x7f9d690*/ <>c();
                    /*0x7f9d698*/ uint <SortGlyphTable>b__44_0(UnityEngine.TextCore.Text.SpriteGlyph item);
                    /*0x7f9d6b0*/ uint <SortCharacterTable>b__45_0(UnityEngine.TextCore.Text.SpriteCharacter c);
                }
            }

            class SpriteCharacter : UnityEngine.TextCore.Text.TextElement
            {
                /*0x30*/ string m_Name;

                /*0x7f9d6c8*/ SpriteCharacter();
                /*0x7f9c828*/ string get_name();
            }

            class SpriteGlyph : UnityEngine.TextCore.Glyph
            {
                /*0x48*/ UnityEngine.Sprite sprite;

                /*0x7f9d6f0*/ SpriteGlyph();
            }

            class TextAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ string m_Version;
                /*0x20*/ int m_InstanceID;
                /*0x24*/ int m_HashCode;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ int m_MaterialHashCode;

                /*0x7f9d620*/ TextAsset();
                /*0x7f9d6f8*/ string get_version();
                /*0x7f9d700*/ void set_version(string value);
                /*0x7f9d708*/ int get_instanceID();
                /*0x7f9d730*/ int get_hashCode();
                /*0x7f9d760*/ void set_hashCode(int value);
                /*0x7f9d768*/ UnityEngine.Material get_material();
                /*0x7f9d770*/ void set_material(UnityEngine.Material value);
                /*0x7f9d778*/ int get_materialHashCode();
                /*0x7f9d810*/ void set_materialHashCode(int value);
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

                static /*0x7f9d9c4*/ TextColorGradient();
                /*0x7f9d818*/ TextColorGradient();
                /*0x7f9d8b4*/ TextColorGradient(UnityEngine.Color color);
                /*0x7f9d920*/ TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
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

                static /*0x7f9dc54*/ void set_s_GlobalSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value);
                static /*0x7f9dca4*/ UnityEngine.TextCore.Text.SpriteAsset get_s_GlobalSpriteAsset();
                /*0x7f9e584*/ TextSettings();
                /*0x7f9da10*/ string get_version();
                /*0x7f9da18*/ void set_version(string value);
                /*0x7f9da20*/ UnityEngine.TextCore.Text.FontAsset get_defaultFontAsset();
                /*0x7f9da28*/ void set_defaultFontAsset(UnityEngine.TextCore.Text.FontAsset value);
                /*0x7f9da30*/ string get_defaultFontAssetPath();
                /*0x7f9da38*/ void set_defaultFontAssetPath(string value);
                /*0x7f9da40*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets();
                /*0x7f9da48*/ void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x7f9da50*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackOSFontAssets();
                /*0x7f9db20*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset();
                /*0x7f9db68*/ void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets);
                /*0x7f9dbc0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetFallbackFontAssets(int textPixelSize);
                /*0x7f9dbc8*/ bool get_matchMaterialPreset();
                /*0x7f9dbd0*/ void set_matchMaterialPreset(bool value);
                /*0x7f9dbdc*/ int get_missingCharacterUnicode();
                /*0x7f9dbe4*/ void set_missingCharacterUnicode(int value);
                /*0x7f9dbec*/ bool get_clearDynamicDataOnBuild();
                /*0x7f9dbf4*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x7f9dc00*/ bool get_enableEmojiSupport();
                /*0x7f9dc08*/ void set_enableEmojiSupport(bool value);
                /*0x7f9dc14*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> get_emojiFallbackTextAssets();
                /*0x7f9dc1c*/ void set_emojiFallbackTextAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> value);
                /*0x7f9dc24*/ UnityEngine.TextCore.Text.SpriteAsset get_defaultSpriteAsset();
                /*0x7f9dc2c*/ void set_defaultSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value);
                /*0x7f9dc34*/ string get_defaultSpriteAssetPath();
                /*0x7f9dc3c*/ void set_defaultSpriteAssetPath(string value);
                /*0x7f9dc44*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets();
                /*0x7f9dc4c*/ void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value);
                /*0x7f9dcec*/ uint get_missingSpriteCharacterUnicode();
                /*0x7f9dcf4*/ void set_missingSpriteCharacterUnicode(uint value);
                /*0x7f9dcfc*/ UnityEngine.TextCore.Text.TextStyleSheet get_defaultStyleSheet();
                /*0x7f9dd04*/ void set_defaultStyleSheet(UnityEngine.TextCore.Text.TextStyleSheet value);
                /*0x7f9dd0c*/ string get_styleSheetsResourcePath();
                /*0x7f9dd14*/ void set_styleSheetsResourcePath(string value);
                /*0x7f9dd1c*/ string get_defaultColorGradientPresetsPath();
                /*0x7f9dd24*/ void set_defaultColorGradientPresetsPath(string value);
                /*0x7f9dd2c*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules get_lineBreakingRules();
                /*0x7f9ddb0*/ void set_lineBreakingRules(UnityEngine.TextCore.Text.UnicodeLineBreakingRules value);
                /*0x7f9ddb8*/ bool get_displayWarnings();
                /*0x7f9ddc0*/ void set_displayWarnings(bool value);
                /*0x7f9ddcc*/ void OnEnable();
                /*0x7f9df04*/ void InitializeFontReferenceLookup();
                /*0x7f9e174*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font font);
                /*0x7f9e1e4*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font, UnityEngine.Shader shader);
                /*0x7f9e534*/ UnityEngine.Shader GetFontShader();
                /*0x7f9da98*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetOSFontAssetList();

                struct FontReferenceMap
                {
                    /*0x10*/ UnityEngine.Font font;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x7f9e504*/ FontReferenceMap(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset);
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

                /*0x7f9e6d0*/ TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
                /*0x7f9e6b8*/ int get_hashCode();
                /*0x7f9e6c0*/ uint[] get_styleOpeningTagArray();
                /*0x7f9e6c8*/ uint[] get_styleClosingTagArray();
                /*0x7f9e748*/ void RefreshStyle();
            }

            class TextStyleSheet : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary;
                /*0x28*/ object styleLookupLock;

                /*0x7f9edd4*/ TextStyleSheet();
                /*0x7f9e930*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles();
                /*0x7f9e938*/ void Reset();
                /*0x7f9ec04*/ UnityEngine.TextCore.Text.TextStyle GetStyle(int hashCode);
                /*0x7f9ed38*/ UnityEngine.TextCore.Text.TextStyle GetStyle(string name);
                /*0x7f9edd0*/ void RefreshStyles();
                /*0x7f9e93c*/ void LoadStyleDictionaryInternal();
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

                /*0x7f9d6e8*/ TextElement();
                /*0x7f9ee98*/ UnityEngine.TextCore.Text.TextElementType get_elementType();
                /*0x7f9a528*/ uint get_unicode();
                /*0x7f9eea0*/ void set_unicode(uint value);
                /*0x7f9b6e0*/ UnityEngine.TextCore.Text.TextAsset get_textAsset();
                /*0x7f9c820*/ void set_textAsset(UnityEngine.TextCore.Text.TextAsset value);
                /*0x7f9eea8*/ UnityEngine.TextCore.Glyph get_glyph();
                /*0x7f9c818*/ void set_glyph(UnityEngine.TextCore.Glyph value);
                /*0x7f9c810*/ uint get_glyphIndex();
                /*0x7f9eeb0*/ void set_glyphIndex(uint value);
                /*0x7f9eeb8*/ float get_scale();
                /*0x7f9eec0*/ void set_scale(float value);
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
                /*0x40*/ int spriteIndex;
                /*0x48*/ UnityEngine.Material material;
                /*0x50*/ int materialReferenceIndex;
                /*0x54*/ bool isUsingAlternateTypeface;
                /*0x58*/ float pointSize;
                /*0x5c*/ int lineNumber;
                /*0x60*/ int pageNumber;
                /*0x64*/ int vertexIndex;
                /*0x68*/ UnityEngine.TextCore.Text.TextVertex vertexTopLeft;
                /*0x90*/ UnityEngine.TextCore.Text.TextVertex vertexBottomLeft;
                /*0xb8*/ UnityEngine.TextCore.Text.TextVertex vertexTopRight;
                /*0xe0*/ UnityEngine.TextCore.Text.TextVertex vertexBottomRight;
                /*0x108*/ UnityEngine.Vector3 topLeft;
                /*0x114*/ UnityEngine.Vector3 bottomLeft;
                /*0x120*/ UnityEngine.Vector3 topRight;
                /*0x12c*/ UnityEngine.Vector3 bottomRight;
                /*0x138*/ float origin;
                /*0x13c*/ float ascender;
                /*0x140*/ float baseLine;
                /*0x144*/ float descender;
                /*0x148*/ float adjustedAscender;
                /*0x14c*/ float adjustedDescender;
                /*0x150*/ float adjustedHorizontalAdvance;
                /*0x154*/ float xAdvance;
                /*0x158*/ float aspectRatio;
                /*0x15c*/ float scale;
                /*0x160*/ UnityEngine.Color32 color;
                /*0x164*/ UnityEngine.Color32 underlineColor;
                /*0x168*/ int underlineVertexIndex;
                /*0x16c*/ UnityEngine.Color32 strikethroughColor;
                /*0x170*/ int strikethroughVertexIndex;
                /*0x174*/ UnityEngine.Color32 highlightColor;
                /*0x178*/ UnityEngine.TextCore.Text.HighlightState highlightState;
                /*0x18c*/ UnityEngine.TextCore.Text.FontStyles style;
                /*0x190*/ bool isVisible;

                /*0x7f9eec8*/ string ToString();
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

                static /*0x7fa0ab4*/ TextEventManager();
                static /*0x7fa0a24*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object font);
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
                /*0x358*/ int m_PageNumber;
                /*0x35c*/ float m_MarginLeft;
                /*0x360*/ float m_MarginRight;
                /*0x364*/ float m_Width;
                /*0x368*/ UnityEngine.TextCore.Text.Extents m_MeshExtents;
                /*0x378*/ float m_MaxCapHeight;
                /*0x37c*/ float m_MaxAscender;
                /*0x380*/ float m_MaxDescender;
                /*0x384*/ bool m_IsNewPage;
                /*0x385*/ bool m_IsNonBreakingSpace;
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

                static /*0x7f76c34*/ bool get_IsExecutingJob();
                static /*0x7f76c7c*/ void set_IsExecutingJob(bool value);
                static /*0x7f77338*/ void ClearMesh(bool updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f8e3ec*/ TextGenerator();
                /*0x7f76ccc*/ void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f77330*/ bool get_isTextTruncated();
                /*0x7f76f88*/ void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f7eb24*/ bool ValidateHtmlTag(UnityEngine.TextCore.Text.TextProcessingElement[] chars, int startIndex, ref int endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo, ref bool isThreadSuccess);
                /*0x7f83790*/ void ClearMarkupTagAttributes();
                /*0x7f837f4*/ void SaveWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, int index, int count, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f83b58*/ int RestoreWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f83ec8*/ void SaveGlyphVertexInfo(float padding, float stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f84b04*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f852b0*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f86450*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f7c000*/ void LayoutPhase(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, float maxVisibleDescender);
                /*0x7f77358*/ void ParsingPhase(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, ref uint charCode, ref float maxVisibleDescender);
                /*0x7f86c74*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f871cc*/ UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f87310*/ UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f87434*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f76e80*/ void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f8c9f0*/ bool PrepareFontAsset(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x7f8b118*/ int SetArraySizes(UnityEngine.TextCore.Text.TextProcessingElement[] textProcessingArray, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x7f8dee8*/ UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isUsingAlternativeTypeface, bool populateLigatures);
                /*0x7f8a2ac*/ void PopulateTextBackingArray(ref UnityEngine.TextCore.Text.RenderedText sourceText);
                /*0x7f8a394*/ void PopulateTextProcessingArray(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x7f8caa0*/ bool PopulateFontAsset(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextProcessingElement[] textProcessingArray);
                /*0x7f8a244*/ void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins);
                /*0x7f8a208*/ bool GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x7f8dc38*/ bool GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x7f8631c*/ bool GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x7f8e350*/ void DoMissingGlyphCallback(uint unicode, int stringIndex, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.TextInfo textInfo);

                class MissingCharacterEventCallback : System.MulticastDelegate
                {
                    /*0x7fa0dd0*/ MissingCharacterEventCallback(object object, nint method);
                    /*0x7fa0e70*/ void Invoke(uint unicode, int stringIndex, UnityEngine.TextCore.Text.TextInfo text, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }

                struct SpecialCharacter
                {
                    /*0x10*/ UnityEngine.TextCore.Text.Character character;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                    /*0x20*/ UnityEngine.Material material;
                    /*0x28*/ int materialIndex;

                    /*0x7fa0e84*/ SpecialCharacter(UnityEngine.TextCore.Text.Character character, int materialIndex);
                }
            }

            class TextGenerationSettings : System.IEquatable<UnityEngine.TextCore.Text.TextGenerationSettings>
            {
                static /*0x0*/ System.Func<bool> IsEditorTextRenderingModeBitmap;
                /*0x10*/ UnityEngine.TextCore.Text.RenderedText m_RenderedText;
                /*0x30*/ string m_CachedRenderedText;
                /*0x38*/ UnityEngine.Rect screenRect;
                /*0x48*/ UnityEngine.Vector4 margins;
                /*0x58*/ float pixelsPerPoint;
                /*0x5c*/ bool isEditorRenderingModeBitmap;
                /*0x60*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x68*/ UnityEngine.Material material;
                /*0x70*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x78*/ UnityEngine.TextCore.Text.TextStyleSheet styleSheet;
                /*0x80*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
                /*0x88*/ UnityEngine.TextCore.Text.TextSettings textSettings;
                /*0x90*/ UnityEngine.TextCore.Text.TextAlignment textAlignment;
                /*0x94*/ UnityEngine.TextCore.Text.TextOverflowMode overflowMode;
                /*0x98*/ float wordWrappingRatio;
                /*0x9c*/ UnityEngine.Color color;
                /*0xb0*/ UnityEngine.TextCore.Text.TextColorGradient fontColorGradient;
                /*0xb8*/ UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset;
                /*0xc0*/ bool tintSprites;
                /*0xc1*/ bool overrideRichTextColors;
                /*0xc2*/ bool shouldConvertToLinearSpace;
                /*0xc4*/ float fontSize;
                /*0xc8*/ bool autoSize;
                /*0xcc*/ float fontSizeMin;
                /*0xd0*/ float fontSizeMax;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.OTL_FeatureTag> fontFeatures;
                /*0xe0*/ bool emojiFallbackSupport;
                /*0xe1*/ bool richText;
                /*0xe2*/ bool isRightToLeft;
                /*0xe4*/ float extraPadding;
                /*0xe8*/ bool parseControlCharacters;
                /*0xe9*/ bool isOrthographic;
                /*0xea*/ bool isPlaceholder;
                /*0xeb*/ bool tagNoParsing;
                /*0xec*/ float characterSpacing;
                /*0xf0*/ float wordSpacing;
                /*0xf4*/ float lineSpacing;
                /*0xf8*/ float paragraphSpacing;
                /*0xfc*/ float lineSpacingMax;
                /*0x100*/ UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode;
                /*0x104*/ int maxVisibleCharacters;
                /*0x108*/ int maxVisibleWords;
                /*0x10c*/ int maxVisibleLines;
                /*0x110*/ int firstVisibleCharacter;
                /*0x114*/ bool useMaxVisibleDescender;
                /*0x118*/ UnityEngine.TextCore.Text.TextFontWeight fontWeight;
                /*0x11c*/ int pageToDisplay;
                /*0x120*/ UnityEngine.TextCore.Text.TextureMapping horizontalMapping;
                /*0x124*/ UnityEngine.TextCore.Text.TextureMapping verticalMapping;
                /*0x128*/ float uvLineOffset;
                /*0x12c*/ UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder;
                /*0x130*/ bool inverseYAxis;
                /*0x131*/ bool isIMGUI;
                /*0x134*/ float charWidthMaxAdj;
                /*0x138*/ UnityEngine.TextCore.Text.TextInputSource inputSource;

                static /*0x7fa1df0*/ bool op_Inequality(UnityEngine.TextCore.Text.TextGenerationSettings left, UnityEngine.TextCore.Text.TextGenerationSettings right);
                /*0x7fa11ec*/ TextGenerationSettings();
                /*0x7fa0fd0*/ UnityEngine.TextCore.Text.RenderedText get_renderedText();
                /*0x7fa0fdc*/ void set_renderedText(UnityEngine.TextCore.Text.RenderedText value);
                /*0x7fa100c*/ string get_text();
                /*0x7fa116c*/ void set_text(string value);
                /*0x7fa12e4*/ bool Equals(UnityEngine.TextCore.Text.TextGenerationSettings other);
                /*0x7fa1810*/ bool Equals(object obj);
                /*0x7fa1910*/ int GetHashCode();
                /*0x7fa1e0c*/ string ToString();
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
                Page = 5,
                Linked = 6,
            }

            enum TextureMapping
            {
                Character = 0,
                Line = 1,
                Paragraph = 2,
                MatchAspect = 3,
            }

            enum TextWrappingMode
            {
                NoWrap = 0,
                Normal = 1,
                PreserveWhitespace = 2,
                PreserveWhitespaceNoWrap = 3,
            }

            enum TextInputSource
            {
                TextInputBox = 0,
                SetText = 1,
                SetTextArray = 2,
                TextString = 3,
            }

            struct RenderedText : System.IEquatable<UnityEngine.TextCore.Text.RenderedText>, System.IEquatable<string>
            {
                /*0x10*/ string value;
                /*0x18*/ int valueStart;
                /*0x1c*/ int valueLength;
                /*0x20*/ string suffix;
                /*0x28*/ char repeat;
                /*0x2c*/ int repeatCount;

                /*0x7fa11d0*/ RenderedText(string value);
                /*0x7fa3ed0*/ RenderedText(string value, string suffix);
                /*0x7fa3e10*/ RenderedText(string value, int start, int length, string suffix);
                /*0x7fa3eec*/ RenderedText(char repeat, int repeatCount, string suffix);
                /*0x7fa3f40*/ int get_CharacterCount();
                /*0x7fa3f60*/ UnityEngine.TextCore.Text.RenderedText.Enumerator GetEnumerator();
                /*0x7fa1068*/ string CreateString();
                /*0x7fa1784*/ bool Equals(UnityEngine.TextCore.Text.RenderedText other);
                /*0x7fa40a4*/ bool Equals(string other);
                /*0x7fa4198*/ bool Equals(object obj);
                /*0x7fa4250*/ int GetHashCode();

                struct Enumerator
                {
                    /*0x10*/ UnityEngine.TextCore.Text.RenderedText m_Source;
                    /*0x30*/ int m_Stage;
                    /*0x34*/ int m_StageIndex;
                    /*0x38*/ char m_Current;

                    /*0x7fa3f90*/ Enumerator(ref UnityEngine.TextCore.Text.RenderedText source);
                    /*0x7fa42f4*/ char get_Current();
                    /*0x7fa3fb8*/ bool MoveNext();
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

                /*0x7fa4424*/ TextBackingContainer(int size);
                /*0x7fa42fc*/ int get_Capacity();
                /*0x7fa4318*/ int get_Count();
                /*0x7fa4320*/ void set_Count(int value);
                /*0x7fa4328*/ uint get_Item(int index);
                /*0x7fa4358*/ void set_Item(int index, uint value);
                /*0x7fa43b8*/ void Resize(int size);
            }

            struct CharacterSubstitution
            {
                /*0x10*/ int index;
                /*0x14*/ uint unicode;

                /*0x7fa4490*/ CharacterSubstitution(int index, uint unicode);
            }

            struct Offset
            {
                static /*0x0*/ UnityEngine.TextCore.Text.Offset k_ZeroOffset;
                /*0x10*/ float m_Left;
                /*0x14*/ float m_Right;
                /*0x18*/ float m_Top;
                /*0x1c*/ float m_Bottom;

                static /*0x7fa4640*/ Offset();
                static /*0x7fa44b8*/ UnityEngine.TextCore.Text.Offset get_zero();
                static /*0x7fa4520*/ bool op_Equality(UnityEngine.TextCore.Text.Offset lhs, UnityEngine.TextCore.Text.Offset rhs);
                static /*0x7fa4550*/ UnityEngine.TextCore.Text.Offset op_Multiply(UnityEngine.TextCore.Text.Offset a, float b);
                /*0x7fa4514*/ Offset(float left, float right, float top, float bottom);
                /*0x7fa4498*/ float get_left();
                /*0x7fa44a0*/ float get_right();
                /*0x7fa44a8*/ float get_top();
                /*0x7fa44b0*/ float get_bottom();
                /*0x7fa4564*/ int GetHashCode();
                /*0x7fa45c8*/ bool Equals(object obj);
            }

            struct HighlightState
            {
                /*0x10*/ UnityEngine.Color32 color;
                /*0x14*/ UnityEngine.TextCore.Text.Offset padding;

                static /*0x7fa4698*/ bool op_Equality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs);
                static /*0x7fa478c*/ bool op_Inequality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs);
                /*0x7fa4688*/ HighlightState(UnityEngine.Color32 color, UnityEngine.TextCore.Text.Offset padding);
                /*0x7fa47d4*/ int GetHashCode();
                /*0x7fa4840*/ bool Equals(object obj);
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

                static /*0x7f8eb8c*/ TextGeneratorUtilities();
                static /*0x7fa48c0*/ bool Approximately(float a, float b);
                static /*0x7fa48f0*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int tagCount);
                static /*0x7fa4d0c*/ uint HexToInt(char hex);
                static /*0x7fa4d38*/ float ConvertToFloat(char[] chars, int startIndex, int length);
                static /*0x7fa4db8*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
                static /*0x3837da0*/ void ResizeInternalArray<T>(ref T[] array);
                static /*0x3839e58*/ void ResizeInternalArray<T>(ref T[] array, int size);
                static /*0x7fa4f18*/ void InsertOpeningTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa54a4*/ void InsertClosingTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa559c*/ bool ReplaceOpeningStyleTag(ref UnityEngine.TextCore.Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa58c4*/ bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, ref int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa5af4*/ void ReplaceClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa5c20*/ void InsertOpeningStyleTag(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa5cf8*/ void InsertClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa5010*/ void InsertTextStyleInTextProcessingArray(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x7fa57e0*/ UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, int hashCode);
                static /*0x7fa5a1c*/ int GetStyleHashCode(ref uint[] text, int index, ref int closeIndex);
                static /*0x7fa56f4*/ int GetStyleHashCode(ref UnityEngine.TextCore.Text.TextBackingContainer text, int index, ref int closeIndex);
                static /*0x7fa5ddc*/ uint GetUTF16(uint[] text, int i);
                static /*0x7fa61d0*/ uint GetUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int i);
                static /*0x7fa5ec4*/ uint GetUTF32(uint[] text, int i);
                static /*0x7fa628c*/ uint GetUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int i);
                static /*0x7fa6398*/ void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x7fa7580*/ void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x7fa85f4*/ void AdjustLineOffset(int startIndex, int endIndex, float offset, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x7fa8774*/ void ResizeLineExtents(int size, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x7fa8934*/ UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle);
                static /*0x7fa8944*/ UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor);
                static /*0x7fa8968*/ UnityEngine.TextCore.HorizontalAlignment GetHorizontalAlignment(UnityEngine.TextAnchor anchor);
                static /*0x7fa898c*/ UnityEngine.TextCore.VerticalAlignment GetVerticalAlignment(UnityEngine.TextAnchor anchor);
                static /*0x7fa89b0*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
                static /*0x7fa89c4*/ int GetMarkupTagHashCode(UnityEngine.TextCore.Text.TextBackingContainer styleDefinition, int readIndex);
                static /*0x7fa6044*/ int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex);
                static /*0x7fa615c*/ char ToUpperASCIIFast(char c);
                static /*0x7fa8ac8*/ uint ToUpperASCIIFast(uint c);
                static /*0x7fa8b3c*/ char ToUpperFast(char c);
                static /*0x7fa8bb0*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
                static /*0x7fa8c94*/ bool IsBitmapRendering(UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode);
                static /*0x7fa8cd4*/ bool IsBaseGlyph(uint c);
                static /*0x7fa8dfc*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
                static /*0x7fa74e4*/ UnityEngine.Color32 GammaToLinear(UnityEngine.Color32 c);
                static /*0x7fa8e08*/ byte GammaToLinear(byte value);
                static /*0x7fa8eb8*/ bool IsValidUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int index);
                static /*0x7fa8f54*/ bool IsValidUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int index);
                static /*0x7fa8ff0*/ bool IsEmoji(uint c);
                static /*0x7fa9070*/ bool IsEmojiPresentationForm(uint c);
                static /*0x7fa90f0*/ bool IsHangul(uint c);
                static /*0x7fa9160*/ bool IsCJK(uint c);
            }

            class TextLib
            {
                static /*0x0*/ System.Func<UnityEngine.TextAsset> GetICUAssetEditorDelegate;
                /*0x10*/ nint m_Ptr;

                static /*0x7fa9348*/ nint GetInstance(byte[] icuData);
                static /*0x7fa99c0*/ int FindIntersectingLink(UnityEngine.Vector2 point, nint textGenerationInfo);
                static /*0x7fa9414*/ nint GetInstance_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper icuData);
                static /*0x7fa9890*/ void GenerateTextInternal_Injected(nint _unity_self, ref UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo, ref UnityEngine.TextCore.Text.NativeTextInfo ret);
                static /*0x7fa9964*/ void MeasureText_Injected(nint _unity_self, ref UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo, ref UnityEngine.Vector2 ret);
                static /*0x7fa9a08*/ int FindIntersectingLink_Injected(ref UnityEngine.Vector2 point, nint textGenerationInfo);
                /*0x7fa9318*/ TextLib(byte[] icuData);
                /*0x7fa9450*/ UnityEngine.TextCore.Text.NativeTextInfo GenerateText(UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo);
                /*0x7fa9818*/ UnityEngine.TextCore.Text.NativeTextInfo GenerateTextInternal(UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo);
                /*0x7fa98ec*/ UnityEngine.Vector2 MeasureText(UnityEngine.TextCore.NativeTextGenerationSettings settings, nint textGenerationInfo);

                class BindingsMarshaller
                {
                    static /*0x7fa9a4c*/ nint ConvertToNative(UnityEngine.TextCore.Text.TextLib textLib);
                }
            }

            class TextGenerationInfo
            {
                static /*0x7fa9a64*/ nint Create();
                static /*0x7fa9a8c*/ void Destroy(nint ptr);
            }

            class TextSelectionService
            {
                static /*0x7fa9ac8*/ string Substring(nint textGenerationInfo, int startIndex, int endIndex);
                static /*0x7fa9bf8*/ void SelectCurrentWord(nint textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex);
                static /*0x7fa9c54*/ int PreviousCodePointIndex(nint textGenerationInfo, int currentIndex);
                static /*0x7fa9c98*/ int NextCodePointIndex(nint textGenerationInfo, int currentIndex);
                static /*0x7fa9cdc*/ int GetCursorLogicalIndexFromPosition(nint textGenerationInfo, UnityEngine.Vector2 position);
                static /*0x7fa9d68*/ UnityEngine.Vector2 GetCursorPositionFromLogicalIndex(nint textGenerationInfo, int logicalIndex);
                static /*0x7fa9e18*/ int LineUpCharacterPosition(nint textGenerationInfo, int originalPos);
                static /*0x7fa9e5c*/ int LineDownCharacterPosition(nint textGenerationInfo, int originalPos);
                static /*0x7fa9ea0*/ UnityEngine.Rect[] GetHighlightRectangles(nint textGenerationInfo, int cursorIndex, int selectIndex);
                static /*0x7faa010*/ float GetCharacterHeightFromIndex(nint textGenerationInfo, int index);
                static /*0x7faa054*/ int GetStartOfNextWord(nint textGenerationInfo, int currentIndex);
                static /*0x7faa098*/ int GetEndOfPreviousWord(nint textGenerationInfo, int currentIndex);
                static /*0x7faa0dc*/ int GetFirstCharacterIndexOnLine(nint textGenerationInfo, int currentIndex);
                static /*0x7faa120*/ int GetLastCharacterIndexOnLine(nint textGenerationInfo, int currentIndex);
                static /*0x7faa164*/ float GetLineHeight(nint textGenerationInfo, int lineIndex);
                static /*0x7faa1a8*/ int GetLineNumber(nint textGenerationInfo, int logicalIndex);
                static /*0x7faa1ec*/ void SelectToPreviousParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x7faa230*/ void SelectToStartOfParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x7faa274*/ void SelectToEndOfParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x7faa2b8*/ void SelectToNextParagraph(nint textGenerationInfo, ref int cursorIndex);
                static /*0x7faa2fc*/ void SelectCurrentParagraph(nint textGenerationInfo, ref int cursorIndex, ref int selectIndex);
                static /*0x7fa9b9c*/ void Substring_Injected(nint textGenerationInfo, int startIndex, int endIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
                static /*0x7fa9d24*/ int GetCursorLogicalIndexFromPosition_Injected(nint textGenerationInfo, ref UnityEngine.Vector2 position);
                static /*0x7fa9dc4*/ void GetCursorPositionFromLogicalIndex_Injected(nint textGenerationInfo, int logicalIndex, ref UnityEngine.Vector2 ret);
                static /*0x7fa9fb4*/ void GetHighlightRectangles_Injected(nint textGenerationInfo, int cursorIndex, int selectIndex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            }

            class TextHandle
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextHandleTemporaryCache s_TemporaryCache;
                static /*0x8*/ UnityEngine.TextCore.Text.TextHandlePermanentCache s_PermanentCache;
                static /*0x10*/ UnityEngine.TextCore.Text.TextGenerationSettings[] s_Settings;
                static /*0x18*/ UnityEngine.TextCore.Text.TextGenerator[] s_Generators;
                static /*0x20*/ UnityEngine.TextCore.Text.TextInfo[] s_TextInfosCommon;
                static /*0x28*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.OTL_FeatureTag> m_ActiveFontFeatures;
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

                static /*0x7facd94*/ TextHandle();
                static /*0x7faa568*/ void InitThreadArrays();
                static /*0x7faa8ac*/ UnityEngine.TextCore.Text.TextGenerationSettings[] get_settingsArray();
                static /*0x7faaa20*/ UnityEngine.TextCore.Text.TextGenerator[] get_generators();
                static /*0x7faab94*/ UnityEngine.TextCore.Text.TextInfo[] get_textInfosCommon();
                static /*0x383af28*/ void InitArray<T>(ref T[] array, System.Func<T> createInstance);
                static /*0x7faad08*/ UnityEngine.TextCore.Text.TextInfo get_textInfoCommon();
                static /*0x7faad84*/ UnityEngine.TextCore.Text.TextGenerator get_generator();
                static /*0x7faae00*/ UnityEngine.TextCore.Text.TextGenerationSettings get_settings();
                static /*0x7fab0ec*/ void UpdateCurrentFrame();
                static /*0x7faba44*/ float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x7fab4c0*/ float GetLineHeightDefault(UnityEngine.TextCore.Text.TextGenerationSettings settings);
                /*0x7faa350*/ TextHandle();
                /*0x7faa3b0*/ void Finalize();
                /*0x7faae7c*/ UnityEngine.Vector2 get_preferredSize();
                /*0x7faae84*/ void set_preferredSize(UnityEngine.Vector2 value);
                /*0x7faae8c*/ System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> get_TextInfoNode();
                /*0x7faae94*/ void set_TextInfoNode(System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> value);
                /*0x7faae9c*/ bool get_IsCachedPermanent();
                /*0x7faaea4*/ void set_IsCachedPermanent(bool value);
                /*0x7faaeb0*/ bool get_IsCachedTemporary();
                /*0x7faaeb8*/ void set_IsCachedTemporary(bool value);
                /*0x7faaec4*/ bool get_useAdvancedText();
                /*0x7faaed0*/ int get_characterCount();
                /*0x7faaf8c*/ void AddTextInfoToPermanentCache();
                /*0x7fab058*/ void AddTextInfoToTemporaryCache(int hashCode);
                /*0x7faa44c*/ void RemoveTextInfoFromTemporaryCache();
                /*0x7faa4bc*/ void RemoveTextInfoFromPermanentCache();
                /*0x7faaf18*/ UnityEngine.TextCore.Text.TextInfo get_textInfo();
                /*0x7fab150*/ void SetDirty();
                /*0x7fab15c*/ bool IsDirty(int hashCode);
                /*0x7fab198*/ bool get_IsPlaceholder();
                /*0x7fab1a0*/ bool IsElided();
                /*0x7fab1e4*/ void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings tgs);
                /*0x7fab26c*/ UnityEngine.TextCore.Text.TextInfo Update();
                /*0x7fab2dc*/ UnityEngine.TextCore.Text.TextInfo UpdateWithHash(int hashCode);
                /*0x7fab5dc*/ bool PrepareFontAsset();
                /*0x7fab704*/ void UpdatePreferredSize();
                /*0x7fabac8*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis);
                /*0x7fabb4c*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance, bool inverseYAxis);
                /*0x7fabbe0*/ UnityEngine.Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex);
                /*0x7fabcac*/ int GetCursorIndexFromPosition(UnityEngine.Vector2 position, bool inverseYAxis);
                /*0x7fabd2c*/ int LineDownCharacterPosition(int originalLogicalPos);
                /*0x7fabdac*/ int LineUpCharacterPosition(int originalLogicalPos);
                /*0x7fabe2c*/ int FindIntersectingLink(UnityEngine.Vector3 position, bool inverseYAxis);
                /*0x7fabf14*/ int GetCorrespondingStringIndex(int index);
                /*0x7fabf6c*/ UnityEngine.TextCore.Text.LineInfo GetLineInfoFromCharacterIndex(int index);
                /*0x7fac06c*/ int GetLineNumber(int index);
                /*0x7fac0ec*/ float GetLineHeight(int lineNumber);
                /*0x7fac16c*/ float GetLineHeightFromCharacterIndex(int index);
                /*0x7fac1ec*/ float GetCharacterHeightFromIndex(int index);
                /*0x7fac26c*/ string Substring(int startIndex, int length);
                /*0x7fac2d4*/ int PreviousCodePointIndex(int currentIndex);
                /*0x7fac398*/ int NextCodePointIndex(int currentIndex);
                /*0x7fac45c*/ int GetStartOfNextWord(int currentIndex);
                /*0x7fac520*/ int GetEndOfPreviousWord(int currentIndex);
                /*0x7fac5e4*/ int GetFirstCharacterIndexOnLine(int currentIndex);
                /*0x7fac6a8*/ int GetLastCharacterIndexOnLine(int currentIndex);
                /*0x7fac76c*/ int IndexOf(char value, int startIndex);
                /*0x7fac830*/ int LastIndexOf(char value, int startIndex);
                /*0x7fac8f4*/ void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex);
                /*0x7fac9cc*/ void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex);
                /*0x7faca9c*/ void SelectToPreviousParagraph(ref int cursorIndex);
                /*0x7facb58*/ void SelectToNextParagraph(ref int cursorIndex);
                /*0x7facc14*/ void SelectToStartOfParagraph(ref int cursorIndex);
                /*0x7faccd0*/ void SelectToEndOfParagraph(ref int cursorIndex);
                /*0x7facd8c*/ bool IsAdvancedTextEnabledForElement();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.TextHandle.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.TextGenerationSettings> <>9__4_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Text.TextGenerator> <>9__4_1;
                    static /*0x18*/ System.Func<UnityEngine.TextCore.Text.TextInfo> <>9__4_2;
                    static /*0x20*/ System.Func<UnityEngine.TextCore.Text.TextGenerationSettings> <>9__7_0;
                    static /*0x28*/ System.Func<UnityEngine.TextCore.Text.TextGenerator> <>9__10_0;
                    static /*0x30*/ System.Func<UnityEngine.TextCore.Text.TextInfo> <>9__13_0;

                    static /*0x7facf28*/ <>c();
                    /*0x7facf90*/ <>c();
                    /*0x7facf98*/ UnityEngine.TextCore.Text.TextGenerationSettings <InitThreadArrays>b__4_0();
                    /*0x7facfec*/ UnityEngine.TextCore.Text.TextGenerator <InitThreadArrays>b__4_1();
                    /*0x7fad040*/ UnityEngine.TextCore.Text.TextInfo <InitThreadArrays>b__4_2();
                    /*0x7fad294*/ UnityEngine.TextCore.Text.TextGenerationSettings <get_settingsArray>b__7_0();
                    /*0x7fad2e8*/ UnityEngine.TextCore.Text.TextGenerator <get_generators>b__10_0();
                    /*0x7fad33c*/ UnityEngine.TextCore.Text.TextInfo <get_textInfosCommon>b__13_0();
                }
            }

            class TextHandlePermanentCache
            {
                /*0x10*/ System.Collections.Generic.LinkedList<UnityEngine.TextCore.Text.TextInfo> s_TextInfoPool;
                /*0x18*/ object syncRoot;

                /*0x7fad718*/ TextHandlePermanentCache();
                /*0x7fad390*/ void AddTextInfoToCache(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x7fad5e0*/ void RemoveTextInfoFromCache(UnityEngine.TextCore.Text.TextHandle textHandle);
            }

            class TextHandleTemporaryCache
            {
                static int s_MinFramesInCache = 2;
                /*0x10*/ System.Collections.Generic.LinkedList<UnityEngine.TextCore.Text.TextInfo> s_TextInfoPool;
                /*0x18*/ int currentFrame;
                /*0x20*/ object syncRoot;

                /*0x7fae1dc*/ TextHandleTemporaryCache();
                /*0x7fad7d8*/ void ClearTemporaryCache();
                /*0x7fad8b0*/ void AddTextInfoToCache(UnityEngine.TextCore.Text.TextHandle textHandle, int hashCode);
                /*0x7fae018*/ void RemoveTextInfoFromCache(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x7fadd30*/ void RefreshCaching(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x7fade1c*/ void RecycleTextInfoFromCache(UnityEngine.TextCore.Text.TextHandle textHandle);
                /*0x7fae1c0*/ void UpdateCurrentFrame();
            }

            struct PageInfo
            {
                /*0x10*/ int firstCharacterIndex;
                /*0x14*/ int lastCharacterIndex;
                /*0x18*/ float ascender;
                /*0x1c*/ float baseLine;
                /*0x20*/ float descender;
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
                /*0x28*/ int pageCount;
                /*0x2c*/ int materialCount;
                /*0x30*/ UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo;
                /*0x38*/ UnityEngine.TextCore.Text.WordInfo[] wordInfo;
                /*0x40*/ UnityEngine.TextCore.Text.LinkInfo[] linkInfo;
                /*0x48*/ UnityEngine.TextCore.Text.LineInfo[] lineInfo;
                /*0x50*/ UnityEngine.TextCore.Text.PageInfo[] pageInfo;
                /*0x58*/ UnityEngine.TextCore.Text.MeshInfo[] meshInfo;
                /*0x60*/ double lastTimeInCache;
                /*0x68*/ System.Action removedFromCache;
                /*0x70*/ UnityEngine.TextCore.Text.VertexDataLayout <vertexDataLayout>k__BackingField;
                /*0x74*/ bool hasMultipleColors;

                static /*0x7faf5f4*/ TextInfo();
                static /*0x3839e58*/ void Resize<T>(ref T[] array, int size);
                static /*0x3839e94*/ void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
                static /*0x7faed7c*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
                static /*0x7faee3c*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
                /*0x7fad094*/ TextInfo(UnityEngine.TextCore.Text.VertexDataLayout vertexDataLayout);
                /*0x7fae29c*/ UnityEngine.TextCore.Text.VertexDataLayout get_vertexDataLayout();
                /*0x7fae2a4*/ void set_vertexDataLayout(UnityEngine.TextCore.Text.VertexDataLayout value);
                /*0x7fad87c*/ void RemoveFromCache();
                /*0x7fae2ac*/ void Clear();
                /*0x7fae30c*/ void ClearMeshInfo(bool updateMesh);
                /*0x7fae3c8*/ void ClearLineInfo();
                /*0x7fae548*/ void ClearPageInfo();
                /*0x7fae5f0*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, UnityEngine.Rect screenRect, float lineHeight, bool inverseYAxis);
                /*0x7fae674*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, UnityEngine.Rect screenRect, float lineHeight, bool useXAdvance, bool inverseYAxis);
                /*0x7fae724*/ int GetCursorIndexFromPosition(UnityEngine.Vector2 position, UnityEngine.Rect screenRect, bool inverseYAxis);
                /*0x7faeb0c*/ int LineDownCharacterPosition(int originalPos);
                /*0x7faec3c*/ int LineUpCharacterPosition(int originalPos);
                /*0x7fae7e8*/ int FindNearestLine(UnityEngine.Vector2 position);
                /*0x7fae884*/ int FindNearestCharacterOnLine(UnityEngine.Vector2 position, int line, bool visibleOnly);
                /*0x7faef04*/ int FindIntersectingLink(UnityEngine.Vector3 position, UnityEngine.Rect screenRect, bool inverseYAxis);
                /*0x7faf17c*/ int GetCorrespondingStringIndex(int index);
                /*0x7faf1c8*/ UnityEngine.TextCore.Text.LineInfo GetLineInfoFromCharacterIndex(int index);
                /*0x7faf218*/ int GetLineNumber(int index);
                /*0x7faf264*/ float GetLineHeight(int lineNumber);
                /*0x7faf2b0*/ float GetLineHeightFromCharacterIndex(int index);
                /*0x7faf2fc*/ float GetCharacterHeightFromIndex(int index);
                /*0x7faf350*/ string Substring(int startIndex, int length);
                /*0x7faf4bc*/ int IndexOf(char value, int startIndex);
                /*0x7faf554*/ int LastIndexOf(char value, int startIndex);
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

                /*0x7faf660*/ void Clear();
                /*0x7faf66c*/ byte Add(UnityEngine.TextCore.Text.FontStyles style);
                /*0x7faf768*/ byte Remove(UnityEngine.TextCore.Text.FontStyles style);
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

                static /*0x3907c14*/ void SetDefault(UnityEngine.TextCore.Text.TextProcessingStack<T> stack, T item);
                /*0x380d83c*/ TextProcessingStack(T[] stack);
                /*0x380cffc*/ TextProcessingStack(int capacity);
                /*0x380d0e4*/ TextProcessingStack(int capacity, int rolloverSize);
                /*0x380b6a0*/ int get_Count();
                /*0x3907c14*/ T get_current();
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ void SetDefault(T item);
                /*0x3907c14*/ void Add(T item);
                /*0x3907c14*/ T Remove();
                /*0x3907c14*/ void Push(T item);
                /*0x3907c14*/ T Pop();
                /*0x3907c14*/ T Peek();
                /*0x3907c14*/ T CurrentItem();
            }

            class TextResourceManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup;
                static /*0x10*/ System.Collections.Generic.Dictionary<long, UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;
                static /*0x18*/ System.Collections.Generic.List<int> s_FontAssetRemovalList;
                static /*0x20*/ int k_RegularStyleHashCode;

                static /*0x7fafe08*/ TextResourceManager();
                static /*0x7faf8ac*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);

                struct FontAssetRef
                {
                    /*0x10*/ int nameHashCode;
                    /*0x14*/ int familyNameHashCode;
                    /*0x18*/ int styleNameHashCode;
                    /*0x20*/ long familyNameAndStyleHashCode;
                    /*0x28*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x7fafde0*/ FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset);
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
                static /*0x148*/ UnityEngine.Shader k_ShaderRef_MobileSDF;
                static /*0x150*/ UnityEngine.Shader k_ShaderRef_MobileSDF_IMGUI;
                static /*0x158*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;
                static /*0x160*/ UnityEngine.Shader k_ShaderRef_Sprite;

                static /*0x7fb074c*/ TextShaderUtilities();
                static /*0x7fb0048*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
                static /*0x7fb01e0*/ UnityEngine.Shader get_ShaderRef_MobileSDF_IMGUI();
                static /*0x7fb0360*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
                static /*0x7fb0538*/ UnityEngine.Shader get_ShaderRef_Sprite();
                static /*0x7fb096c*/ void GetShaderPropertyIDs();
            }

            class TextUtilities
            {
                static /*0x7fb1434*/ char ToUpperFast(char c);
                static /*0x7faffd8*/ int GetHashCodeCaseInSensitive(string s);
                static /*0x7fb14a8*/ int GetTextFontWeightIndex(UnityEngine.TextCore.Text.TextFontWeight fontWeight);
            }

            class UnicodeLineBreakingRules
            {
                /*0x10*/ UnityEngine.TextAsset m_UnicodeLineBreakingRules;
                /*0x18*/ UnityEngine.TextAsset m_LeadingCharacters;
                /*0x20*/ UnityEngine.TextAsset m_FollowingCharacters;
                /*0x28*/ bool m_UseModernHangulLineBreakingRules;
                /*0x30*/ System.Collections.Generic.HashSet<uint> m_LeadingCharactersLookup;
                /*0x38*/ System.Collections.Generic.HashSet<uint> m_FollowingCharactersLookup;

                static /*0x7fb17b0*/ System.Collections.Generic.HashSet<uint> GetCharacters(UnityEngine.TextAsset file);
                /*0x7fb1898*/ UnicodeLineBreakingRules();
                /*0x7fb153c*/ System.Collections.Generic.HashSet<uint> get_leadingCharactersLookup();
                /*0x7fb1784*/ System.Collections.Generic.HashSet<uint> get_followingCharactersLookup();
                /*0x7fb17a8*/ bool get_useModernHangulLineBreakingRules();
                /*0x7fb1560*/ void LoadLineBreakingRules();
            }
        }
    }
}
