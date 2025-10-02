class <Module>
{
}

namespace UnityEngine
{
    namespace TextCore
    {
        struct FaceInfo
        {
            /*0x10*/ int m_FaceIndex;
            /*0x18*/ string m_FamilyName;
            /*0x20*/ string m_StyleName;
            /*0x28*/ int m_PointSize;
            /*0x2c*/ float m_Scale;
            /*0x30*/ int m_UnitsPerEM;
            /*0x34*/ float m_LineHeight;
            /*0x38*/ float m_AscentLine;
            /*0x3c*/ float m_CapLine;
            /*0x40*/ float m_MeanLine;
            /*0x44*/ float m_Baseline;
            /*0x48*/ float m_DescentLine;
            /*0x4c*/ float m_SuperscriptOffset;
            /*0x50*/ float m_SuperscriptSize;
            /*0x54*/ float m_SubscriptOffset;
            /*0x58*/ float m_SubscriptSize;
            /*0x5c*/ float m_UnderlineOffset;
            /*0x60*/ float m_UnderlineThickness;
            /*0x64*/ float m_StrikethroughOffset;
            /*0x68*/ float m_StrikethroughThickness;
            /*0x6c*/ float m_TabWidth;

            /*0x15d3b80*/ int get_faceIndex();
            /*0xfbbe70*/ string get_familyName();
            /*0x1659550*/ void set_familyName(string value);
            /*0x9e3110*/ string get_styleName();
            /*0x9f12f0*/ void set_styleName(string value);
            /*0xbe6cb0*/ int get_pointSize();
            /*0x8a5c50*/ void set_pointSize(int value);
            /*0x1644ec0*/ float get_scale();
            /*0x1316920*/ void set_scale(float value);
            /*0x15f1330*/ float get_lineHeight();
            /*0x136a070*/ void set_lineHeight(float value);
            /*0x16594e0*/ float get_ascentLine();
            /*0x136a090*/ void set_ascentLine(float value);
            /*0x1644f10*/ float get_capLine();
            /*0x4ccc50*/ void set_capLine(float value);
            /*0x1644ed0*/ float get_meanLine();
            /*0x1102a70*/ void set_meanLine(float value);
            /*0x1644f20*/ float get_baseline();
            /*0x995220*/ void set_baseline(float value);
            /*0x14417b0*/ float get_descentLine();
            /*0x14c88d0*/ void set_descentLine(float value);
            /*0x1441630*/ float get_superscriptOffset();
            /*0x136a120*/ void set_superscriptOffset(float value);
            /*0x1644eb0*/ float get_superscriptSize();
            /*0xcf6d00*/ void set_superscriptSize(float value);
            /*0x1659500*/ float get_subscriptOffset();
            /*0x1355540*/ void set_subscriptOffset(float value);
            /*0x1659510*/ float get_subscriptSize();
            /*0x136a440*/ void set_subscriptSize(float value);
            /*0x1659530*/ float get_underlineOffset();
            /*0x1659580*/ void set_underlineOffset(float value);
            /*0x1659540*/ float get_underlineThickness();
            /*0x1659590*/ void set_underlineThickness(float value);
            /*0x16594f0*/ float get_strikethroughOffset();
            /*0x14a59e0*/ void set_strikethroughOffset(float value);
            /*0x1659560*/ void set_strikethroughThickness(float value);
            /*0x1659520*/ float get_tabWidth();
            /*0x1659570*/ void set_tabWidth(float value);
        }

        enum GlyphClassDefinitionType
        {
            Undefined = 0,
            Base = 1,
            Ligature = 2,
            Mark = 3,
            Component = 4,
        }

        struct GlyphRect : System.IEquatable<UnityEngine.TextCore.GlyphRect>
        {
            static /*0x0*/ UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;
            /*0x10*/ int m_X;
            /*0x14*/ int m_Y;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;

            static /*0x165bcf0*/ GlyphRect();
            static /*0x165bd30*/ UnityEngine.TextCore.GlyphRect get_zero();
            /*0x1153590*/ GlyphRect(int x, int y, int width, int height);
            /*0x15d3b80*/ int get_x();
            /*0xc6bf90*/ int get_y();
            /*0xb73eb0*/ int get_width();
            /*0xba1820*/ int get_height();
            /*0x165bca0*/ int GetHashCode();
            /*0x165bc40*/ bool Equals(object obj);
            /*0x165bbc0*/ bool Equals(UnityEngine.TextCore.GlyphRect other);
        }

        struct GlyphMetrics : System.IEquatable<UnityEngine.TextCore.GlyphMetrics>
        {
            /*0x10*/ float m_Width;
            /*0x14*/ float m_Height;
            /*0x18*/ float m_HorizontalBearingX;
            /*0x1c*/ float m_HorizontalBearingY;
            /*0x20*/ float m_HorizontalAdvance;

            /*0x165b9d0*/ GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);
            /*0x6ef1f0*/ float get_width();
            /*0x6ef200*/ float get_height();
            /*0x501230*/ float get_horizontalBearingX();
            /*0x501220*/ float get_horizontalBearingY();
            /*0x15b7dc0*/ float get_horizontalAdvance();
            /*0x165b970*/ int GetHashCode();
            /*0x165b900*/ bool Equals(object obj);
            /*0x165b870*/ bool Equals(UnityEngine.TextCore.GlyphMetrics other);
        }

        class Glyph
        {
            /*0x10*/ uint m_Index;
            /*0x14*/ UnityEngine.TextCore.GlyphMetrics m_Metrics;
            /*0x28*/ UnityEngine.TextCore.GlyphRect m_GlyphRect;
            /*0x38*/ float m_Scale;
            /*0x3c*/ int m_AtlasIndex;
            /*0x40*/ UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType;

            /*0x165bfa0*/ Glyph();
            /*0x165bee0*/ Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
            /*0x165bf30*/ Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
            /*0x15bceb0*/ uint get_index();
            /*0xdcd9c0*/ void set_index(uint value);
            /*0x8b8950*/ UnityEngine.TextCore.GlyphMetrics get_metrics();
            /*0x165c000*/ void set_metrics(UnityEngine.TextCore.GlyphMetrics value);
            /*0x165bff0*/ UnityEngine.TextCore.GlyphRect get_glyphRect();
            /*0xf2b440*/ void set_glyphRect(UnityEngine.TextCore.GlyphRect value);
            /*0x14417b0*/ float get_scale();
            /*0x14c88d0*/ void set_scale(float value);
            /*0x165bfe0*/ int get_atlasIndex();
            /*0x136a430*/ void set_atlasIndex(int value);
        }

        namespace LowLevel
        {
            enum GlyphLoadFlags
            {
                LOAD_DEFAULT = 0,
                LOAD_NO_SCALE = 1,
                LOAD_NO_HINTING = 2,
                LOAD_RENDER = 4,
                LOAD_NO_BITMAP = 8,
                LOAD_FORCE_AUTOHINT = 32,
                LOAD_MONOCHROME = 4096,
                LOAD_NO_AUTOHINT = 32768,
                LOAD_COLOR = 1048576,
                LOAD_COMPUTE_METRICS = 2097152,
                LOAD_BITMAP_METRICS_ONLY = 4194304,
            }

            enum FontEngineError
            {
                Success = 0,
                Invalid_File_Path = 1,
                Invalid_File_Format = 2,
                Invalid_File_Structure = 3,
                Invalid_File = 4,
                Invalid_Table = 8,
                Invalid_Glyph_Index = 16,
                Invalid_Character_Code = 17,
                Invalid_Pixel_Size = 23,
                Invalid_Library = 33,
                Invalid_Face = 35,
                Invalid_Library_or_Face = 41,
                Atlas_Generation_Cancelled = 100,
                Invalid_SharedTextureData = 101,
                OpenTypeLayoutLookup_Mismatch = 116,
            }

            enum GlyphRenderMode
            {
                SMOOTH_HINTED = 4121,
                SMOOTH = 4117,
                COLOR_HINTED = 69656,
                COLOR = 69652,
                RASTER_HINTED = 4122,
                RASTER = 4118,
                SDF = 4134,
                SDF8 = 8230,
                SDF16 = 16422,
                SDF32 = 32806,
                SDFAA_HINTED = 4169,
                SDFAA = 4165,
            }

            enum GlyphPackingMode
            {
                BestShortSideFit = 0,
                BestLongSideFit = 1,
                BestAreaFit = 2,
                BottomLeftRule = 3,
                ContactPointRule = 4,
            }

            struct FontReference
            {
                /*0x10*/ string familyName;
                /*0x18*/ string styleName;
                /*0x20*/ int faceIndex;
                /*0x28*/ string filePath;
            }

            class FontEngine
            {
                static /*0x0*/ UnityEngine.TextCore.Glyph[] s_Glyphs;
                static /*0x8*/ uint[] s_GlyphIndexes_MarshallingArray_A;
                static /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;
                static /*0x18*/ UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;
                static /*0x20*/ UnityEngine.TextCore.GlyphRect[] s_FreeGlyphRects;
                static /*0x28*/ UnityEngine.TextCore.GlyphRect[] s_UsedGlyphRects;
                static /*0x30*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;
                static /*0x38*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary;

                static /*0x165b530*/ FontEngine();
                static /*0x1659a90*/ UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine();
                static /*0x1659a60*/ int InitializeFontEngine_Internal();
                static /*0x1659d40*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex);
                static /*0x1659af0*/ int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex);
                static /*0x1659cc0*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize);
                static /*0x1659b40*/ int LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, int pointSize);
                static /*0x1659c30*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x1659b80*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x1659dd0*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName, int pointSize);
                static /*0x1659bd0*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize);
                static /*0x165b4a0*/ bool TryGetSystemFontReference(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x165b440*/ bool TryGetSystemFontReference_Internal(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x1659600*/ UnityEngine.TextCore.FaceInfo GetFaceInfo();
                static /*0x16595c0*/ int GetFaceInfo_Internal(ref UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x16596e0*/ uint GetGlyphIndex(uint unicode);
                static /*0x165b2c0*/ bool TryGetGlyphWithUnicodeValue(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x165b270*/ bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x165b0f0*/ bool TryGetGlyphWithIndexValue(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x165b0a0*/ bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x1659ef0*/ void SetTextureUploadMode(bool shouldUploadImmediately);
                static /*0x1659fa0*/ bool TryAddGlyphToTexture(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x1659f30*/ bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x165a640*/ bool TryAddGlyphsToTexture(System.Collections.Generic.List<uint> glyphIndexes, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph[] glyphs);
                static /*0x165a5d0*/ bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount);
                static /*0x16598c0*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes);
                static /*0x1659720*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes, ref int recordCount);
                static /*0x1659e60*/ int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, ref int recordCount);
                static /*0x1659a20*/ int GetPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords);
                static /*0x177670*/ void GenericListToMarshallingArray<T>(ref System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                static /*0x1827f0*/ void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount);
                static /*0x1659eb0*/ void ResetAtlasTexture(UnityEngine.Texture2D texture);
            }

            struct FontEngineUtilities
            {
                static /*0x16595a0*/ int MaxValue(int a, int b, int c);
            }

            struct GlyphMarshallingStruct
            {
                /*0x10*/ uint index;
                /*0x14*/ UnityEngine.TextCore.GlyphMetrics metrics;
                /*0x28*/ UnityEngine.TextCore.GlyphRect glyphRect;
                /*0x38*/ float scale;
                /*0x3c*/ int atlasIndex;
                /*0x40*/ UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType;
            }

            enum FontFeatureLookupFlags
            {
                None = 0,
                IgnoreLigatures = 4,
                IgnoreSpacingAdjustments = 256,
            }

            struct GlyphValueRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphValueRecord>
            {
                /*0x10*/ float m_XPlacement;
                /*0x14*/ float m_YPlacement;
                /*0x18*/ float m_XAdvance;
                /*0x1c*/ float m_YAdvance;

                static /*0x165bec0*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b);
                /*0x6ef1f0*/ float get_xPlacement();
                /*0x14668c0*/ void set_xPlacement(float value);
                /*0x6ef200*/ float get_yPlacement();
                /*0x14668d0*/ void set_yPlacement(float value);
                /*0x501230*/ float get_xAdvance();
                /*0x501220*/ float get_yAdvance();
                /*0x165be70*/ int GetHashCode();
                /*0x165bd90*/ bool Equals(object obj);
                /*0x165bdf0*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other);
            }

            struct GlyphAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord>
            {
                /*0x10*/ uint m_GlyphIndex;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;

                /*0x15d3b80*/ uint get_glyphIndex();
                /*0x16284e0*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord();
                /*0x165b810*/ int GetHashCode();
                /*0x165b7a0*/ bool Equals(object obj);
                /*0x165b710*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other);
            }

            struct GlyphPairAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>
            {
                /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;
                /*0x24*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;
                /*0x38*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;

                /*0x165bbb0*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord();
                /*0x8b8950*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord();
                /*0xca7c90*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags get_featureLookupFlags();
                /*0x165bb40*/ int GetHashCode();
                /*0x165ba00*/ bool Equals(object obj);
                /*0x165ba80*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other);
            }

            struct GlyphAnchorPoint
            {
                /*0x10*/ float m_XCoordinate;
                /*0x14*/ float m_YCoordinate;

                /*0x6ef1f0*/ float get_xCoordinate();
                /*0x6ef200*/ float get_yCoordinate();
            }

            struct MarkPositionAdjustment
            {
                /*0x10*/ float m_XPositionAdjustment;
                /*0x14*/ float m_YPositionAdjustment;

                /*0x6ef1f0*/ float get_xPositionAdjustment();
                /*0x6ef200*/ float get_yPositionAdjustment();
            }

            struct MarkToBaseAdjustmentRecord
            {
                /*0x10*/ uint m_BaseGlyphID;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint;
                /*0x1c*/ uint m_MarkGlyphID;
                /*0x20*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment;

                /*0x15d3b80*/ uint get_baseGlyphID();
                /*0x1644ef0*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint get_baseGlyphAnchorPoint();
                /*0xba1820*/ uint get_markGlyphID();
                /*0x1649ce0*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment get_markPositionAdjustment();
            }

            struct MarkToMarkAdjustmentRecord
            {
                /*0x10*/ uint m_BaseMarkGlyphID;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;
                /*0x1c*/ uint m_CombiningMarkGlyphID;
                /*0x20*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

                /*0x15d3b80*/ uint get_baseMarkGlyphID();
                /*0x1644ef0*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint get_baseMarkGlyphAnchorPoint();
                /*0xba1820*/ uint get_combiningMarkGlyphID();
                /*0x1649ce0*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment get_combiningMarkPositionAdjustment();
            }

            struct MultipleSubstitutionRecord
            {
                /*0x10*/ uint m_TargetGlyphID;
                /*0x18*/ uint[] m_SubstituteGlyphIDs;
            }

            struct LigatureSubstitutionRecord
            {
                /*0x10*/ uint[] m_ComponentGlyphIDs;
                /*0x18*/ uint m_LigatureGlyphID;

                /*0x69af20*/ uint[] get_componentGlyphIDs();
                /*0xb73eb0*/ uint get_ligatureGlyphID();
            }
        }
    }
}
