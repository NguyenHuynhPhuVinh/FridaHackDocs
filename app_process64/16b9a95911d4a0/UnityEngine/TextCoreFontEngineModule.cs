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
            /*0x28*/ float m_PointSize;
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

            /*0x3e99488*/ int get_faceIndex();
            /*0x3e99490*/ string get_familyName();
            /*0x3e99498*/ void set_familyName(string value);
            /*0x3e994a0*/ string get_styleName();
            /*0x3e994a8*/ void set_styleName(string value);
            /*0x3e994b0*/ float get_pointSize();
            /*0x3e994b8*/ void set_pointSize(float value);
            /*0x3e994c0*/ float get_scale();
            /*0x3e994c8*/ void set_scale(float value);
            /*0x3e994d0*/ int get_unitsPerEM();
            /*0x3e994d8*/ void set_unitsPerEM(int value);
            /*0x3e994e0*/ float get_lineHeight();
            /*0x3e994e8*/ void set_lineHeight(float value);
            /*0x3e994f0*/ float get_ascentLine();
            /*0x3e994f8*/ void set_ascentLine(float value);
            /*0x3e99500*/ float get_capLine();
            /*0x3e99508*/ void set_capLine(float value);
            /*0x3e99510*/ float get_meanLine();
            /*0x3e99518*/ void set_meanLine(float value);
            /*0x3e99520*/ float get_baseline();
            /*0x3e99528*/ void set_baseline(float value);
            /*0x3e99530*/ float get_descentLine();
            /*0x3e99538*/ void set_descentLine(float value);
            /*0x3e99540*/ float get_superscriptOffset();
            /*0x3e99548*/ void set_superscriptOffset(float value);
            /*0x3e99550*/ float get_superscriptSize();
            /*0x3e99558*/ void set_superscriptSize(float value);
            /*0x3e99560*/ float get_subscriptOffset();
            /*0x3e99568*/ void set_subscriptOffset(float value);
            /*0x3e99570*/ float get_subscriptSize();
            /*0x3e99578*/ void set_subscriptSize(float value);
            /*0x3e99580*/ float get_underlineOffset();
            /*0x3e99588*/ void set_underlineOffset(float value);
            /*0x3e99590*/ float get_underlineThickness();
            /*0x3e99598*/ void set_underlineThickness(float value);
            /*0x3e995a0*/ float get_strikethroughOffset();
            /*0x3e995a8*/ void set_strikethroughOffset(float value);
            /*0x3e995b0*/ void set_strikethroughThickness(float value);
            /*0x3e995b8*/ float get_tabWidth();
            /*0x3e995c0*/ void set_tabWidth(float value);
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

            static /*0x3e997bc*/ GlyphRect();
            static /*0x3e995e8*/ UnityEngine.TextCore.GlyphRect get_zero();
            /*0x3e99640*/ GlyphRect(int x, int y, int width, int height);
            /*0x3e995c8*/ int get_x();
            /*0x3e995d0*/ int get_y();
            /*0x3e995d8*/ int get_width();
            /*0x3e995e0*/ int get_height();
            /*0x3e9964c*/ int GetHashCode();
            /*0x3e996b0*/ bool Equals(object obj);
            /*0x3e99728*/ bool Equals(UnityEngine.TextCore.GlyphRect other);
        }

        struct GlyphMetrics : System.IEquatable<UnityEngine.TextCore.GlyphMetrics>
        {
            /*0x10*/ float m_Width;
            /*0x14*/ float m_Height;
            /*0x18*/ float m_HorizontalBearingX;
            /*0x1c*/ float m_HorizontalBearingY;
            /*0x20*/ float m_HorizontalAdvance;

            /*0x3e9982c*/ GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);
            /*0x3e99804*/ float get_width();
            /*0x3e9980c*/ float get_height();
            /*0x3e99814*/ float get_horizontalBearingX();
            /*0x3e9981c*/ float get_horizontalBearingY();
            /*0x3e99824*/ float get_horizontalAdvance();
            /*0x3e9983c*/ int GetHashCode();
            /*0x3e998a8*/ bool Equals(object obj);
            /*0x3e99928*/ bool Equals(UnityEngine.TextCore.GlyphMetrics other);
        }

        class Glyph
        {
            /*0x10*/ uint m_Index;
            /*0x14*/ UnityEngine.TextCore.GlyphMetrics m_Metrics;
            /*0x28*/ UnityEngine.TextCore.GlyphRect m_GlyphRect;
            /*0x38*/ float m_Scale;
            /*0x3c*/ int m_AtlasIndex;
            /*0x40*/ UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType;

            /*0x3e99a38*/ Glyph();
            /*0x3e99a60*/ Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
            /*0x3e99adc*/ Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
            /*0x3e999cc*/ uint get_index();
            /*0x3e999d4*/ void set_index(uint value);
            /*0x3e999dc*/ UnityEngine.TextCore.GlyphMetrics get_metrics();
            /*0x3e999f0*/ void set_metrics(UnityEngine.TextCore.GlyphMetrics value);
            /*0x3e99a04*/ UnityEngine.TextCore.GlyphRect get_glyphRect();
            /*0x3e99a10*/ void set_glyphRect(UnityEngine.TextCore.GlyphRect value);
            /*0x3e99a18*/ float get_scale();
            /*0x3e99a20*/ void set_scale(float value);
            /*0x3e99a28*/ int get_atlasIndex();
            /*0x3e99a30*/ void set_atlasIndex(int value);
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
                DEFAULT = 0,
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
                static /*0x30*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray;
                static /*0x38*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;
                static /*0x40*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray;
                static /*0x48*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray;
                static /*0x50*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary;

                static /*0x3e9de3c*/ FontEngine();
                static /*0x3e99b4c*/ UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine();
                static /*0x3e99bb4*/ int InitializeFontEngine_Internal();
                static /*0x3e99bdc*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex);
                static /*0x3e99cd4*/ int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex);
                static /*0x3e99ed8*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(byte[] sourceFontFile, int pointSize);
                static /*0x3e99f54*/ int LoadFontFace_With_Size_FromSourceFontFile_Internal(byte[] sourceFontFile, int pointSize);
                static /*0x3e9a09c*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize);
                static /*0x3e9a100*/ int LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, int pointSize);
                static /*0x3e9a1f4*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, float pointSize, int faceIndex);
                static /*0x3e9a2ec*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x3e9a3f8*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName, float pointSize);
                static /*0x3e9a4f0*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize);
                static /*0x3e9a7b4*/ UnityEngine.TextCore.LowLevel.FontEngineError UnloadAllFontFaces();
                static /*0x3e9a81c*/ int UnloadAllFontFaces_Internal();
                static /*0x3e9a844*/ bool IsColorFontFace();
                static /*0x3e9a86c*/ bool TryGetSystemFontReference(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x3e9a8d8*/ bool TryGetSystemFontReference_Internal(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x3e9aba0*/ UnityEngine.TextCore.FaceInfo GetFaceInfo();
                static /*0x3e9ac40*/ int GetFaceInfo_Internal(ref UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x3e9ac7c*/ uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode);
                static /*0x3e9acc0*/ uint GetGlyphIndex(uint unicode);
                static /*0x3e9acfc*/ bool TryGetGlyphWithUnicodeValue(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x3e9ae3c*/ bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x3e9ae90*/ bool TryGetGlyphWithIndexValue(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x3e9afd0*/ bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x3e9b024*/ void SetTextureUploadMode(bool shouldUploadImmediately);
                static /*0x3e9b060*/ bool TryAddGlyphToTexture(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x3e9b560*/ bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x3e9b82c*/ bool TryAddGlyphsToTexture(System.Collections.Generic.List<uint> glyphIndexes, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph[] glyphs);
                static /*0x3e9c0dc*/ bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount);
                static /*0x3e9c4bc*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords();
                static /*0x3e9c4e4*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex);
                static /*0x3e9c714*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x3e9c5f0*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes);
                static /*0x3e9c7a0*/ int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x3e9c8a4*/ int GetLigatureSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] ligatureSubstitutionRecords);
                static /*0x3e9c924*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes);
                static /*0x3e9cc28*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes, ref int recordCount);
                static /*0x3e9ca4c*/ int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, ref int recordCount);
                static /*0x3e9cdc8*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords();
                static /*0x3e9cf38*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x3e9cfc4*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes);
                static /*0x3e9d0ec*/ int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x3e9cb50*/ int GetPairAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords);
                static /*0x3e9d270*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords();
                static /*0x3e9d3e0*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x3e9d46c*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes);
                static /*0x3e9d590*/ int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x3e9d694*/ int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> adjustmentRecords);
                static /*0x3e9d7ec*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords();
                static /*0x3e9d95c*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x3e9d9dc*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes);
                static /*0x3e9db04*/ int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x3e9dc08*/ int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> adjustmentRecords);
                static /*0x3e9c554*/ void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray);
                static /*0x1f36f18*/ void GenericListToMarshallingArray<T>(ref System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                static /*0x1f36244*/ void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount);
                static /*0x3e9dd60*/ void ResetAtlasTexture(UnityEngine.Texture2D texture);
                static /*0x3e99e84*/ int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper filePath, int pointSize, int faceIndex);
                static /*0x3e9a058*/ int LoadFontFace_With_Size_FromSourceFontFile_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sourceFontFile, int pointSize);
                static /*0x3e9a1b0*/ int LoadFontFace_With_Size_FromFont_Internal_Injected(nint font, int pointSize);
                static /*0x3e9a3a4*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(nint font, int pointSize, int faceIndex);
                static /*0x3e9a760*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper familyName, ref UnityEngine.Bindings.ManagedSpanWrapper styleName, int pointSize);
                static /*0x3e9ab4c*/ bool TryGetSystemFontReference_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper familyName, ref UnityEngine.Bindings.ManagedSpanWrapper styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x3e9b790*/ bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, ref UnityEngine.Bindings.BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, ref UnityEngine.Bindings.BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, nint texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x3e9c414*/ bool TryAddGlyphsToTexture_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, ref UnityEngine.Bindings.BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, ref UnityEngine.Bindings.BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, nint texture, ref UnityEngine.Bindings.BlittableArrayWrapper glyphs, ref int glyphCount);
                static /*0x3e9c8e0*/ int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x3e9cd84*/ int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x3e9cefc*/ void GetAllPairAdjustmentRecords_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper ret);
                static /*0x3e9d1f0*/ int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x3e9d234*/ int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphPairAdjustmentRecords);
                static /*0x3e9d3a4*/ void GetAllMarkToBaseAdjustmentRecords_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper ret);
                static /*0x3e9d76c*/ int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x3e9d7b0*/ int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper adjustmentRecords);
                static /*0x3e9d920*/ void GetAllMarkToMarkAdjustmentRecords_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper ret);
                static /*0x3e9dce0*/ int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x3e9dd24*/ int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper adjustmentRecords);
                static /*0x3e9de00*/ void ResetAtlasTexture_Injected(nint texture);
            }

            struct FontEngineUtilities
            {
                static /*0x3e9c0c8*/ int MaxValue(int a, int b, int c);
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

                static /*0x3e9e000*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b);
                /*0x3e9dfc8*/ float get_xPlacement();
                /*0x3e9dfd0*/ void set_xPlacement(float value);
                /*0x3e9dfd8*/ float get_yPlacement();
                /*0x3e9dfe0*/ void set_yPlacement(float value);
                /*0x3e9dfe8*/ float get_xAdvance();
                /*0x3e9dff0*/ void set_xAdvance(float value);
                /*0x3e9dff8*/ float get_yAdvance();
                /*0x3e9e014*/ int GetHashCode();
                /*0x3e9e078*/ bool Equals(object obj);
                /*0x3e9e0f0*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other);
            }

            struct GlyphAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord>
            {
                /*0x10*/ uint m_GlyphIndex;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;

                /*0x3e9e1ac*/ GlyphAdjustmentRecord(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord);
                /*0x3e9e198*/ uint get_glyphIndex();
                /*0x3e9e1a0*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord();
                /*0x3e9e1bc*/ int GetHashCode();
                /*0x3e9e228*/ bool Equals(object obj);
                /*0x3e9e2a8*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other);
            }

            struct GlyphPairAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>
            {
                /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;
                /*0x24*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;
                /*0x38*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;

                /*0x3e9e34c*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord();
                /*0x3e9e360*/ void set_firstAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord value);
                /*0x3e9e374*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord();
                /*0x3e9e388*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags get_featureLookupFlags();
                /*0x3e9e390*/ int GetHashCode();
                /*0x3e9e3fc*/ bool Equals(object obj);
                /*0x3e9e47c*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other);
            }

            struct GlyphAnchorPoint
            {
                /*0x10*/ float m_XCoordinate;
                /*0x14*/ float m_YCoordinate;

                /*0x3e9e520*/ float get_xCoordinate();
                /*0x3e9e528*/ void set_xCoordinate(float value);
                /*0x3e9e530*/ float get_yCoordinate();
                /*0x3e9e538*/ void set_yCoordinate(float value);
            }

            struct MarkPositionAdjustment
            {
                /*0x10*/ float m_XPositionAdjustment;
                /*0x14*/ float m_YPositionAdjustment;

                /*0x3e9e540*/ float get_xPositionAdjustment();
                /*0x3e9e548*/ void set_xPositionAdjustment(float value);
                /*0x3e9e550*/ float get_yPositionAdjustment();
                /*0x3e9e558*/ void set_yPositionAdjustment(float value);
            }

            struct MarkToBaseAdjustmentRecord
            {
                /*0x10*/ uint m_BaseGlyphID;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint;
                /*0x1c*/ uint m_MarkGlyphID;
                /*0x20*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment;

                /*0x3e9e560*/ uint get_baseGlyphID();
                /*0x3e9e568*/ void set_baseGlyphID(uint value);
                /*0x3e9e570*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint get_baseGlyphAnchorPoint();
                /*0x3e9e578*/ void set_baseGlyphAnchorPoint(UnityEngine.TextCore.LowLevel.GlyphAnchorPoint value);
                /*0x3e9e580*/ uint get_markGlyphID();
                /*0x3e9e588*/ void set_markGlyphID(uint value);
                /*0x3e9e590*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment get_markPositionAdjustment();
                /*0x3e9e598*/ void set_markPositionAdjustment(UnityEngine.TextCore.LowLevel.MarkPositionAdjustment value);
            }

            struct MarkToMarkAdjustmentRecord
            {
                /*0x10*/ uint m_BaseMarkGlyphID;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;
                /*0x1c*/ uint m_CombiningMarkGlyphID;
                /*0x20*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

                /*0x3e9e5a0*/ uint get_baseMarkGlyphID();
                /*0x3e9e5a8*/ void set_baseMarkGlyphID(uint value);
                /*0x3e9e5b0*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint get_baseMarkGlyphAnchorPoint();
                /*0x3e9e5b8*/ void set_baseMarkGlyphAnchorPoint(UnityEngine.TextCore.LowLevel.GlyphAnchorPoint value);
                /*0x3e9e5c0*/ uint get_combiningMarkGlyphID();
                /*0x3e9e5c8*/ void set_combiningMarkGlyphID(uint value);
                /*0x3e9e5d0*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment get_combiningMarkPositionAdjustment();
                /*0x3e9e5d8*/ void set_combiningMarkPositionAdjustment(UnityEngine.TextCore.LowLevel.MarkPositionAdjustment value);
            }

            struct MultipleSubstitutionRecord
            {
                /*0x10*/ uint m_TargetGlyphID;
                /*0x18*/ uint[] m_SubstituteGlyphIDs;
            }

            struct LigatureSubstitutionRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>
            {
                /*0x10*/ uint[] m_ComponentGlyphIDs;
                /*0x18*/ uint m_LigatureGlyphID;

                static /*0x3e9e618*/ bool op_Equality(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord lhs, UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord rhs);
                /*0x3e9e5e0*/ uint[] get_componentGlyphIDs();
                /*0x3e9e5e8*/ void set_componentGlyphIDs(uint[] value);
                /*0x3e9e5f0*/ uint get_ligatureGlyphID();
                /*0x3e9e5f8*/ void set_ligatureGlyphID(uint value);
                /*0x3e9e600*/ bool Equals(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord other);
                /*0x3e9e674*/ bool Equals(object obj);
                /*0x3e9e6f0*/ int GetHashCode();
            }
        }
    }
}
