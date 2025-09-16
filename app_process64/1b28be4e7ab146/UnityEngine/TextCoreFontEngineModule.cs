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

            /*0x7f730c4*/ int get_faceIndex();
            /*0x7f730cc*/ string get_familyName();
            /*0x7f730d4*/ string get_styleName();
            /*0x7f730dc*/ float get_pointSize();
            /*0x7f730e4*/ float get_scale();
            /*0x7f730ec*/ void set_scale(float value);
            /*0x7f730f4*/ int get_unitsPerEM();
            /*0x7f730fc*/ void set_unitsPerEM(int value);
            /*0x7f73104*/ float get_lineHeight();
            /*0x7f7310c*/ float get_ascentLine();
            /*0x7f73114*/ float get_capLine();
            /*0x7f7311c*/ void set_capLine(float value);
            /*0x7f73124*/ float get_meanLine();
            /*0x7f7312c*/ void set_meanLine(float value);
            /*0x7f73134*/ float get_baseline();
            /*0x7f7313c*/ float get_descentLine();
            /*0x7f73144*/ float get_superscriptOffset();
            /*0x7f7314c*/ float get_superscriptSize();
            /*0x7f73154*/ float get_subscriptOffset();
            /*0x7f7315c*/ float get_subscriptSize();
            /*0x7f73164*/ float get_underlineOffset();
            /*0x7f7316c*/ float get_underlineThickness();
            /*0x7f73174*/ float get_strikethroughOffset();
            /*0x7f7317c*/ void set_strikethroughOffset(float value);
            /*0x7f73184*/ float get_tabWidth();
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

            static /*0x7f73380*/ GlyphRect();
            static /*0x7f731ac*/ UnityEngine.TextCore.GlyphRect get_zero();
            /*0x7f73204*/ GlyphRect(int x, int y, int width, int height);
            /*0x7f7318c*/ int get_x();
            /*0x7f73194*/ int get_y();
            /*0x7f7319c*/ int get_width();
            /*0x7f731a4*/ int get_height();
            /*0x7f73210*/ int GetHashCode();
            /*0x7f73274*/ bool Equals(object obj);
            /*0x7f732ec*/ bool Equals(UnityEngine.TextCore.GlyphRect other);
        }

        struct GlyphMetrics : System.IEquatable<UnityEngine.TextCore.GlyphMetrics>
        {
            /*0x10*/ float m_Width;
            /*0x14*/ float m_Height;
            /*0x18*/ float m_HorizontalBearingX;
            /*0x1c*/ float m_HorizontalBearingY;
            /*0x20*/ float m_HorizontalAdvance;

            /*0x7f733f0*/ GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);
            /*0x7f733c8*/ float get_width();
            /*0x7f733d0*/ float get_height();
            /*0x7f733d8*/ float get_horizontalBearingX();
            /*0x7f733e0*/ float get_horizontalBearingY();
            /*0x7f733e8*/ float get_horizontalAdvance();
            /*0x7f73400*/ int GetHashCode();
            /*0x7f7346c*/ bool Equals(object obj);
            /*0x7f734ec*/ bool Equals(UnityEngine.TextCore.GlyphMetrics other);
        }

        class Glyph
        {
            /*0x10*/ uint m_Index;
            /*0x14*/ UnityEngine.TextCore.GlyphMetrics m_Metrics;
            /*0x28*/ UnityEngine.TextCore.GlyphRect m_GlyphRect;
            /*0x38*/ float m_Scale;
            /*0x3c*/ int m_AtlasIndex;
            /*0x40*/ UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType;

            /*0x7f735fc*/ Glyph();
            /*0x7f73624*/ Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
            /*0x7f736b0*/ Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
            /*0x7f73590*/ uint get_index();
            /*0x7f73598*/ void set_index(uint value);
            /*0x7f735a0*/ UnityEngine.TextCore.GlyphMetrics get_metrics();
            /*0x7f735b4*/ void set_metrics(UnityEngine.TextCore.GlyphMetrics value);
            /*0x7f735c8*/ UnityEngine.TextCore.GlyphRect get_glyphRect();
            /*0x7f735d4*/ void set_glyphRect(UnityEngine.TextCore.GlyphRect value);
            /*0x7f735dc*/ float get_scale();
            /*0x7f735e4*/ void set_scale(float value);
            /*0x7f735ec*/ int get_atlasIndex();
            /*0x7f735f4*/ void set_atlasIndex(int value);
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
                static /*0x30*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray;
                static /*0x38*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;
                static /*0x40*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray;
                static /*0x48*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray;
                static /*0x50*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary;

                static /*0x7f77610*/ FontEngine();
                static /*0x7f73720*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath);
                static /*0x7f73774*/ int LoadFontFace_Internal(string filePath);
                static /*0x7f73948*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex);
                static /*0x7f739bc*/ int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, float pointSize, int faceIndex);
                static /*0x7f73bc0*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, float pointSize, int faceIndex);
                static /*0x7f73c34*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, float pointSize, int faceIndex);
                static /*0x7f73d48*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName, float pointSize);
                static /*0x7f73dbc*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, float pointSize);
                static /*0x7f74080*/ UnityEngine.TextCore.LowLevel.FontEngineError UnloadFontFace();
                static /*0x7f740e8*/ int UnloadFontFace_Internal();
                static /*0x7f74110*/ bool TryGetSystemFontReference(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x7f7417c*/ bool TryGetSystemFontReference_Internal(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x7f74444*/ UnityEngine.TextCore.FaceInfo GetFaceInfo();
                static /*0x7f744e4*/ int GetFaceInfo_Internal(ref UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x7f74520*/ string[] GetFontFaces();
                static /*0x7f745a0*/ string[] GetFontFaces_Internal();
                static /*0x7f745c8*/ uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode);
                static /*0x7f7460c*/ uint GetGlyphIndex(uint unicode);
                static /*0x7f74648*/ bool TryGetGlyphWithUnicodeValue(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x7f747a0*/ bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x7f747f4*/ bool TryGetGlyphWithIndexValue(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x7f7494c*/ bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x7f749a0*/ void SetTextureUploadMode(bool shouldUploadImmediately);
                static /*0x7f749dc*/ bool TryAddGlyphToTexture(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x7f74ef4*/ bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x7f751b8*/ bool TryAddGlyphsToTexture(System.Collections.Generic.List<uint> glyphIndexes, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph[] glyphs);
                static /*0x7f75aa0*/ bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount);
                static /*0x7f75e58*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords();
                static /*0x7f75e80*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex);
                static /*0x7f760b0*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x7f75f8c*/ UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes);
                static /*0x7f7613c*/ int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x7f76234*/ int GetLigatureSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] ligatureSubstitutionRecords);
                static /*0x7f762b4*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes);
                static /*0x7f763dc*/ int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, ref int recordCount);
                static /*0x7f765f0*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords();
                static /*0x7f76750*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x7f767dc*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes);
                static /*0x7f76904*/ int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x7f764d4*/ int GetPairAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords);
                static /*0x7f76a7c*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords();
                static /*0x7f76bdc*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x7f76c68*/ UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes);
                static /*0x7f76d8c*/ int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x7f76e84*/ int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> adjustmentRecords);
                static /*0x7f76fdc*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords();
                static /*0x7f7713c*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                static /*0x7f771bc*/ UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes);
                static /*0x7f772e4*/ int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, ref int recordCount);
                static /*0x7f773dc*/ int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> adjustmentRecords);
                static /*0x7f75ef0*/ void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray);
                static /*0x3843dfc*/ void GenericListToMarshallingArray<T>(ref System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                static /*0x3842d2c*/ void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount);
                static /*0x7f77534*/ void ResetAtlasTexture(UnityEngine.Texture2D texture);
                static /*0x7f7390c*/ int LoadFontFace_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper filePath);
                static /*0x7f73b6c*/ int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper filePath, float pointSize, int faceIndex);
                static /*0x7f73cf4*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(nint font, float pointSize, int faceIndex);
                static /*0x7f7402c*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper familyName, ref UnityEngine.Bindings.ManagedSpanWrapper styleName, float pointSize);
                static /*0x7f743f0*/ bool TryGetSystemFontReference_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper familyName, ref UnityEngine.Bindings.ManagedSpanWrapper styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x7f7511c*/ bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, ref UnityEngine.Bindings.BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, ref UnityEngine.Bindings.BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, nint texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x7f75db0*/ bool TryAddGlyphsToTexture_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, ref UnityEngine.Bindings.BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, ref UnityEngine.Bindings.BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, nint texture, ref UnityEngine.Bindings.BlittableArrayWrapper glyphs, ref int glyphCount);
                static /*0x7f76270*/ int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x7f765ac*/ int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x7f76714*/ void GetAllPairAdjustmentRecords_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper ret);
                static /*0x7f769fc*/ int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x7f76a40*/ int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphPairAdjustmentRecords);
                static /*0x7f76ba0*/ void GetAllMarkToBaseAdjustmentRecords_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper ret);
                static /*0x7f76f5c*/ int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x7f76fa0*/ int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper adjustmentRecords);
                static /*0x7f77100*/ void GetAllMarkToMarkAdjustmentRecords_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper ret);
                static /*0x7f774b4*/ int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper glyphIndexes, ref int recordCount);
                static /*0x7f774f8*/ int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper adjustmentRecords);
                static /*0x7f775d4*/ void ResetAtlasTexture_Injected(nint texture);
            }

            struct FontEngineUtilities
            {
                static /*0x7f75a80*/ int MaxValue(int a, int b, int c);
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

                static /*0x7f777e0*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b);
                /*0x7f777d4*/ GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);
                /*0x7f7779c*/ float get_xPlacement();
                /*0x7f777a4*/ void set_xPlacement(float value);
                /*0x7f777ac*/ float get_yPlacement();
                /*0x7f777b4*/ void set_yPlacement(float value);
                /*0x7f777bc*/ float get_xAdvance();
                /*0x7f777c4*/ void set_xAdvance(float value);
                /*0x7f777cc*/ float get_yAdvance();
                /*0x7f777f4*/ int GetHashCode();
                /*0x7f77858*/ bool Equals(object obj);
                /*0x7f778d0*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other);
            }

            struct GlyphAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord>
            {
                /*0x10*/ uint m_GlyphIndex;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;

                /*0x7f7798c*/ GlyphAdjustmentRecord(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord);
                /*0x7f77978*/ uint get_glyphIndex();
                /*0x7f77980*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord();
                /*0x7f7799c*/ int GetHashCode();
                /*0x7f77a08*/ bool Equals(object obj);
                /*0x7f77a88*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other);
            }

            struct GlyphPairAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>
            {
                /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;
                /*0x24*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;
                /*0x38*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;

                /*0x7f77b70*/ GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord);
                /*0x7f77b2c*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord();
                /*0x7f77b40*/ void set_firstAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord value);
                /*0x7f77b54*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord();
                /*0x7f77b68*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags get_featureLookupFlags();
                /*0x7f77b94*/ int GetHashCode();
                /*0x7f77c00*/ bool Equals(object obj);
                /*0x7f77c80*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other);
            }

            struct GlyphAnchorPoint
            {
                /*0x10*/ float m_XCoordinate;
                /*0x14*/ float m_YCoordinate;

                /*0x7f77d24*/ float get_xCoordinate();
                /*0x7f77d2c*/ void set_xCoordinate(float value);
                /*0x7f77d34*/ float get_yCoordinate();
                /*0x7f77d3c*/ void set_yCoordinate(float value);
            }

            struct MarkPositionAdjustment
            {
                /*0x10*/ float m_XPositionAdjustment;
                /*0x14*/ float m_YPositionAdjustment;

                /*0x7f77d44*/ float get_xPositionAdjustment();
                /*0x7f77d4c*/ void set_xPositionAdjustment(float value);
                /*0x7f77d54*/ float get_yPositionAdjustment();
                /*0x7f77d5c*/ void set_yPositionAdjustment(float value);
            }

            struct MarkToBaseAdjustmentRecord
            {
                /*0x10*/ uint m_BaseGlyphID;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint;
                /*0x1c*/ uint m_MarkGlyphID;
                /*0x20*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment;

                /*0x7f77d64*/ uint get_baseGlyphID();
                /*0x7f77d6c*/ void set_baseGlyphID(uint value);
                /*0x7f77d74*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint get_baseGlyphAnchorPoint();
                /*0x7f77d7c*/ void set_baseGlyphAnchorPoint(UnityEngine.TextCore.LowLevel.GlyphAnchorPoint value);
                /*0x7f77d84*/ uint get_markGlyphID();
                /*0x7f77d8c*/ void set_markGlyphID(uint value);
                /*0x7f77d94*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment get_markPositionAdjustment();
                /*0x7f77d9c*/ void set_markPositionAdjustment(UnityEngine.TextCore.LowLevel.MarkPositionAdjustment value);
            }

            struct MarkToMarkAdjustmentRecord
            {
                /*0x10*/ uint m_BaseMarkGlyphID;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;
                /*0x1c*/ uint m_CombiningMarkGlyphID;
                /*0x20*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

                /*0x7f77da4*/ uint get_baseMarkGlyphID();
                /*0x7f77dac*/ void set_baseMarkGlyphID(uint value);
                /*0x7f77db4*/ UnityEngine.TextCore.LowLevel.GlyphAnchorPoint get_baseMarkGlyphAnchorPoint();
                /*0x7f77dbc*/ void set_baseMarkGlyphAnchorPoint(UnityEngine.TextCore.LowLevel.GlyphAnchorPoint value);
                /*0x7f77dc4*/ uint get_combiningMarkGlyphID();
                /*0x7f77dcc*/ void set_combiningMarkGlyphID(uint value);
                /*0x7f77dd4*/ UnityEngine.TextCore.LowLevel.MarkPositionAdjustment get_combiningMarkPositionAdjustment();
                /*0x7f77ddc*/ void set_combiningMarkPositionAdjustment(UnityEngine.TextCore.LowLevel.MarkPositionAdjustment value);
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

                static /*0x7f77e1c*/ bool op_Equality(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord lhs, UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord rhs);
                /*0x7f77de4*/ uint[] get_componentGlyphIDs();
                /*0x7f77dec*/ void set_componentGlyphIDs(uint[] value);
                /*0x7f77df4*/ uint get_ligatureGlyphID();
                /*0x7f77dfc*/ void set_ligatureGlyphID(uint value);
                /*0x7f77e04*/ bool Equals(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord other);
                /*0x7f77e98*/ bool Equals(object obj);
                /*0x7f77f10*/ int GetHashCode();
            }
        }
    }
}
