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
            /*0x30*/ float m_LineHeight;
            /*0x34*/ float m_AscentLine;
            /*0x38*/ float m_CapLine;
            /*0x3c*/ float m_MeanLine;
            /*0x40*/ float m_Baseline;
            /*0x44*/ float m_DescentLine;
            /*0x48*/ float m_SuperscriptOffset;
            /*0x4c*/ float m_SuperscriptSize;
            /*0x50*/ float m_SubscriptOffset;
            /*0x54*/ float m_SubscriptSize;
            /*0x58*/ float m_UnderlineOffset;
            /*0x5c*/ float m_UnderlineThickness;
            /*0x60*/ float m_StrikethroughOffset;
            /*0x64*/ float m_StrikethroughThickness;
            /*0x68*/ float m_TabWidth;

            /*0x181301c*/ int get_faceIndex();
            /*0x1813024*/ string get_familyName();
            /*0x181302c*/ void set_familyName(string value);
            /*0x1813034*/ string get_styleName();
            /*0x181303c*/ void set_styleName(string value);
            /*0x1813044*/ int get_pointSize();
            /*0x181304c*/ void set_pointSize(int value);
            /*0x1813054*/ float get_scale();
            /*0x181305c*/ void set_scale(float value);
            /*0x1813064*/ float get_lineHeight();
            /*0x181306c*/ void set_lineHeight(float value);
            /*0x1813074*/ float get_ascentLine();
            /*0x181307c*/ void set_ascentLine(float value);
            /*0x1813084*/ float get_capLine();
            /*0x181308c*/ void set_capLine(float value);
            /*0x1813094*/ float get_meanLine();
            /*0x181309c*/ void set_meanLine(float value);
            /*0x18130a4*/ float get_baseline();
            /*0x18130ac*/ void set_baseline(float value);
            /*0x18130b4*/ float get_descentLine();
            /*0x18130bc*/ void set_descentLine(float value);
            /*0x18130c4*/ float get_superscriptOffset();
            /*0x18130cc*/ void set_superscriptOffset(float value);
            /*0x18130d4*/ float get_superscriptSize();
            /*0x18130dc*/ void set_superscriptSize(float value);
            /*0x18130e4*/ float get_subscriptOffset();
            /*0x18130ec*/ void set_subscriptOffset(float value);
            /*0x18130f4*/ float get_subscriptSize();
            /*0x18130fc*/ void set_subscriptSize(float value);
            /*0x1813104*/ float get_underlineOffset();
            /*0x181310c*/ void set_underlineOffset(float value);
            /*0x1813114*/ float get_underlineThickness();
            /*0x181311c*/ void set_underlineThickness(float value);
            /*0x1813124*/ float get_strikethroughOffset();
            /*0x181312c*/ void set_strikethroughOffset(float value);
            /*0x1813134*/ void set_strikethroughThickness(float value);
            /*0x181313c*/ float get_tabWidth();
            /*0x1813144*/ void set_tabWidth(float value);
        }

        struct GlyphRect : System.IEquatable<UnityEngine.TextCore.GlyphRect>
        {
            static /*0x0*/ UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;
            /*0x10*/ int m_X;
            /*0x14*/ int m_Y;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;

            static /*0x1813340*/ GlyphRect();
            static /*0x181316c*/ UnityEngine.TextCore.GlyphRect get_zero();
            /*0x18131c4*/ GlyphRect(int x, int y, int width, int height);
            /*0x181314c*/ int get_x();
            /*0x1813154*/ int get_y();
            /*0x181315c*/ int get_width();
            /*0x1813164*/ int get_height();
            /*0x18131d0*/ int GetHashCode();
            /*0x1813234*/ bool Equals(object obj);
            /*0x18132ac*/ bool Equals(UnityEngine.TextCore.GlyphRect other);
        }

        struct GlyphMetrics : System.IEquatable<UnityEngine.TextCore.GlyphMetrics>
        {
            /*0x10*/ float m_Width;
            /*0x14*/ float m_Height;
            /*0x18*/ float m_HorizontalBearingX;
            /*0x1c*/ float m_HorizontalBearingY;
            /*0x20*/ float m_HorizontalAdvance;

            /*0x18133b0*/ GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);
            /*0x1813388*/ float get_width();
            /*0x1813390*/ float get_height();
            /*0x1813398*/ float get_horizontalBearingX();
            /*0x18133a0*/ float get_horizontalBearingY();
            /*0x18133a8*/ float get_horizontalAdvance();
            /*0x18133c0*/ int GetHashCode();
            /*0x181342c*/ bool Equals(object obj);
            /*0x18134ac*/ bool Equals(UnityEngine.TextCore.GlyphMetrics other);
        }

        class Glyph
        {
            /*0x10*/ uint m_Index;
            /*0x14*/ UnityEngine.TextCore.GlyphMetrics m_Metrics;
            /*0x28*/ UnityEngine.TextCore.GlyphRect m_GlyphRect;
            /*0x38*/ float m_Scale;
            /*0x3c*/ int m_AtlasIndex;

            /*0x18135bc*/ Glyph();
            /*0x18135e4*/ Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
            /*0x1813660*/ Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
            /*0x1813550*/ uint get_index();
            /*0x1813558*/ void set_index(uint value);
            /*0x1813560*/ UnityEngine.TextCore.GlyphMetrics get_metrics();
            /*0x1813574*/ void set_metrics(UnityEngine.TextCore.GlyphMetrics value);
            /*0x1813588*/ UnityEngine.TextCore.GlyphRect get_glyphRect();
            /*0x1813594*/ void set_glyphRect(UnityEngine.TextCore.GlyphRect value);
            /*0x181359c*/ float get_scale();
            /*0x18135a4*/ void set_scale(float value);
            /*0x18135ac*/ int get_atlasIndex();
            /*0x18135b4*/ void set_atlasIndex(int value);
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
            }

            enum GlyphRenderMode
            {
                SMOOTH_HINTED = 4121,
                SMOOTH = 4117,
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

                static /*0x1815314*/ FontEngine();
                static /*0x18136d0*/ UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine();
                static /*0x1813738*/ int InitializeFontEngine_Internal();
                static /*0x1813760*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex);
                static /*0x18137ec*/ int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex);
                static /*0x1813840*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize);
                static /*0x18138c4*/ int LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, int pointSize);
                static /*0x1813908*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x1813994*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x18139e8*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName, int pointSize);
                static /*0x1813a74*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize);
                static /*0x1813ac8*/ bool TryGetSystemFontReference(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x1813b54*/ bool TryGetSystemFontReference_Internal(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x1813ba8*/ UnityEngine.TextCore.FaceInfo GetFaceInfo();
                static /*0x1813c48*/ int GetFaceInfo_Internal(ref UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x1813c84*/ uint GetGlyphIndex(uint unicode);
                static /*0x1813cc0*/ bool TryGetGlyphWithUnicodeValue(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x1813e08*/ bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x1813e5c*/ bool TryGetGlyphWithIndexValue(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x1813fa4*/ bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x1813ff8*/ void SetTextureUploadMode(bool shouldUploadImmediately);
                static /*0x1814034*/ bool TryAddGlyphToTexture(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x1814560*/ bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x18145fc*/ bool TryAddGlyphsToTexture(System.Collections.Generic.List<uint> glyphIndexes, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph[] glyphs);
                static /*0x1814ed8*/ bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount);
                static /*0x1814f80*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes);
                static /*0x1815150*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes, ref int recordCount);
                static /*0x18150d0*/ int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, ref int recordCount);
                static /*0x1815114*/ int GetGlyphPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords);
                static void GenericListToMarshallingArray<T>(ref System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount);
                static /*0x18152d8*/ void ResetAtlasTexture(UnityEngine.Texture2D texture);
            }

            struct FontEngineUtilities
            {
                static /*0x1814eb8*/ int MaxValue(int a, int b, int c);
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

                static /*0x1815484*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b);
                /*0x1815464*/ float get_xPlacement();
                /*0x181546c*/ float get_yPlacement();
                /*0x1815474*/ float get_xAdvance();
                /*0x181547c*/ float get_yAdvance();
                /*0x1815498*/ int GetHashCode();
                /*0x18154fc*/ bool Equals(object obj);
                /*0x1815574*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other);
            }

            struct GlyphAdjustmentRecord
            {
                /*0x10*/ uint m_GlyphIndex;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;

                /*0x181561c*/ uint get_glyphIndex();
                /*0x1815624*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord();
            }

            struct GlyphPairAdjustmentRecord
            {
                /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;
                /*0x24*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;
                /*0x38*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;

                /*0x1815630*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord();
                /*0x1815644*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord();
            }

            struct GlyphMarshallingStruct
            {
                /*0x10*/ uint index;
                /*0x14*/ UnityEngine.TextCore.GlyphMetrics metrics;
                /*0x28*/ UnityEngine.TextCore.GlyphRect glyphRect;
                /*0x38*/ float scale;
                /*0x3c*/ int atlasIndex;
            }
        }
    }
}
