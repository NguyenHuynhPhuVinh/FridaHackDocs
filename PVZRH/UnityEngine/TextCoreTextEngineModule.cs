class <Module>
{
}

namespace UnityEngine
{
    namespace TextCore
    {
        namespace Text
        {
            class Character : UnityEngine.TextCore.Text.TextElement
            {
                /*0x165c070*/ Character();
                /*0x165c0a0*/ Character(uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
                /*0x165c010*/ Character(uint unicode, uint glyphIndex);
            }

            class ColorUtilities
            {
                static /*0x165c130*/ bool CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b);
                static /*0x165c170*/ UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
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
                /*0x20*/ int pointSize;
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
                static /*0x0*/ Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
                static /*0x8*/ Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
                static /*0x10*/ Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
                static /*0x18*/ Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
                static /*0x20*/ Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
                static /*0x28*/ Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;
                static /*0x30*/ Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
                static /*0x38*/ Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
                static /*0x40*/ Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker;
                static /*0x48*/ string s_DefaultMaterialSuffix;
                static /*0x50*/ System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
                static /*0x58*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
                static /*0x60*/ System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
                static /*0x68*/ System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;
                static /*0x70*/ System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
                static /*0x78*/ uint[] k_GlyphIndexArray;
                /*0x38*/ string m_SourceFontFileGUID;
                /*0x40*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;
                /*0x98*/ UnityEngine.Font m_SourceFontFile;
                /*0xa0*/ string m_SourceFontFilePath;
                /*0xa8*/ UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode;
                /*0xac*/ bool InternalDynamicOS;
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
                /*0x14d*/ bool m_ClearDynamicDataOnBuild;
                /*0x150*/ int m_AtlasWidth;
                /*0x154*/ int m_AtlasHeight;
                /*0x158*/ int m_AtlasPadding;
                /*0x15c*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
                /*0x160*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
                /*0x168*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
                /*0x170*/ UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable;
                /*0x178*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable;
                /*0x180*/ UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable;
                /*0x188*/ float m_RegularStyleWeight;
                /*0x18c*/ float m_RegularStyleSpacing;
                /*0x190*/ float m_BoldStyleWeight;
                /*0x194*/ float m_BoldStyleSpacing;
                /*0x198*/ byte m_ItalicStyleSlant;
                /*0x199*/ byte m_TabMultiple;
                /*0x19a*/ bool IsFontAssetLookupTablesDirty;
                /*0x1a0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
                /*0x1a8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
                /*0x1b0*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
                /*0x1b8*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
                /*0x1c0*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
                /*0x1c8*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
                /*0x1d0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd;
                /*0x1d8*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
                /*0x1e0*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
                /*0x1e8*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;

                static /*0x16662a0*/ FontAsset();
                static /*0x165e4d0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, int pointSize);
                static /*0x165e420*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight);
                static /*0x165e240*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x165e3a0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font);
                static /*0x165e6f0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x165e8f0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x165dc90*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x165eca0*/ string GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x165ebc0*/ int[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x16611d0*/ void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x1665810*/ void UpdateFontFeaturesForFontAssetsInQueue();
                static /*0x1661090*/ void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture);
                static /*0x1665120*/ void UpdateAtlasTexturesInQueue();
                static /*0x16654b0*/ void UpdateFontAssetsInUpdateQueue();
                /*0x1666690*/ FontAsset();
                /*0x1666c70*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings();
                /*0x1666e90*/ void set_fontAssetCreationEditorSettings(UnityEngine.TextCore.Text.FontAssetCreationEditorSettings value);
                /*0x1634590*/ UnityEngine.Font get_sourceFontFile();
                /*0x9c7a70*/ void set_sourceFontFile(UnityEngine.Font value);
                /*0x1666a50*/ UnityEngine.TextCore.Text.AtlasPopulationMode get_atlasPopulationMode();
                /*0xb69b10*/ void set_atlasPopulationMode(UnityEngine.TextCore.Text.AtlasPopulationMode value);
                /*0x1666bc0*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x1666e40*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x1666c20*/ int get_familyNameHashCode();
                /*0x1404ad0*/ void set_familyNameHashCode(int value);
                /*0x1666d70*/ int get_styleNameHashCode();
                /*0x1465bd0*/ void set_styleNameHashCode(int value);
                /*0x1666d20*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
                /*0x134cc40*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
                /*0x1666ce0*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
                /*0x1666ba0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable();
                /*0x10f5010*/ void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value);
                /*0x1666b60*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> get_characterLookupTable();
                /*0x1666a80*/ UnityEngine.Texture2D get_atlasTexture();
                /*0x1666b20*/ UnityEngine.Texture2D[] get_atlasTextures();
                /*0x13694a0*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
                /*0x1666a70*/ int get_atlasTextureCount();
                /*0x1666d30*/ bool get_isMultiAtlasTexturesEnabled();
                /*0x10f4f10*/ void set_isMultiAtlasTexturesEnabled(bool value);
                /*0x1666bb0*/ bool get_clearDynamicDataOnBuild();
                /*0x10f4f50*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x1666b30*/ int get_atlasWidth();
                /*0x1666e10*/ void set_atlasWidth(int value);
                /*0x1666a30*/ int get_atlasHeight();
                /*0x1666de0*/ void set_atlasHeight(int value);
                /*0x1666a40*/ int get_atlasPadding();
                /*0x1666df0*/ void set_atlasPadding(int value);
                /*0x1666a60*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
                /*0x1666e00*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
                /*0x1666dd0*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
                /*0x136fd00*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x1666cd0*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
                /*0x1666f20*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x1666cb0*/ UnityEngine.TextCore.Text.FontFeatureTable get_fontFeatureTable();
                /*0x1666ee0*/ void set_fontFeatureTable(UnityEngine.TextCore.Text.FontFeatureTable value);
                /*0x1666c10*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable();
                /*0x13e6220*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x1666cc0*/ UnityEngine.TextCore.Text.FontWeightPair[] get_fontWeightTable();
                /*0x1666f00*/ void set_fontWeightTable(UnityEngine.TextCore.Text.FontWeightPair[] value);
                /*0x1666d60*/ float get_regularStyleWeight();
                /*0x1666f60*/ void set_regularStyleWeight(float value);
                /*0x1666d50*/ float get_regularStyleSpacing();
                /*0x1666f50*/ void set_regularStyleSpacing(float value);
                /*0x1666b50*/ float get_boldStyleWeight();
                /*0x1666e30*/ void set_boldStyleWeight(float value);
                /*0x1666b40*/ float get_boldStyleSpacing();
                /*0x1666e20*/ void set_boldStyleSpacing(float value);
                /*0x1666d40*/ byte get_italicStyleSlant();
                /*0x1666f40*/ void set_italicStyleSlant(byte value);
                /*0x1666dc0*/ byte get_tabMultiple();
                /*0x1666f70*/ void set_tabMultiple(byte value);
                /*0x32d010*/ void Awake();
                /*0x1660b00*/ void OnDestroy();
                /*0x1660c30*/ void ReadFontAssetDefinition();
                /*0x165fd70*/ void InitializeDictionaryLookupTables();
                /*0x165fdc0*/ void InitializeGlyphLookupDictionary();
                /*0x165fb90*/ void InitializeCharacterLookupDictionary();
                /*0x16602b0*/ void InitializeLigatureSubstitutionLookupDictionary();
                /*0x1660040*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
                /*0x1660590*/ void InitializeMarkToBaseAdjustmentRecordsLookupDictionary();
                /*0x1660780*/ void InitializeMarkToMarkAdjustmentRecordsLookupDictionary();
                /*0x165d410*/ void AddSynthesizedCharactersAndFaceMetrics();
                /*0x165d0f0*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
                /*0x165d080*/ void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character);
                /*0x1660970*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace();
                /*0x16618c0*/ void SortCharacterTable();
                /*0x1661a90*/ void SortGlyphTable();
                /*0x1661a40*/ void SortFontFeatureTable();
                /*0x16615b0*/ void SortAllTables();
                /*0x165f450*/ bool HasCharacter(int character);
                /*0x165f4c0*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
                /*0x165f0d0*/ bool HasCharacter(uint character, bool searchFallbacks, bool tryAddCharacter);
                /*0x165ee80*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
                /*0x165fa30*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
                /*0x165f590*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
                /*0x165f4e0*/ bool HasCharacters(string text);
                /*0x165eda0*/ uint GetGlyphIndex(uint unicode);
                /*0x16626a0*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
                /*0x16626d0*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
                /*0x1662670*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
                /*0x1663300*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
                /*0x1663ef0*/ bool TryAddGlyphInternal(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph);
                /*0x1661c10*/ bool TryAddCharacterInternal(uint unicode, ref UnityEngine.TextCore.Text.Character character, bool shouldGetFontFeatures);
                /*0x1664c40*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref UnityEngine.TextCore.Text.Character character, bool shouldGetFontFeatures);
                /*0x32d010*/ void TryAddGlyphsToAtlasTextures();
                /*0x16647a0*/ bool TryAddGlyphsToNewAtlasTexture();
                /*0x1661320*/ void SetupNewAtlasTexture();
                /*0x16650c0*/ void UpdateAllFontFeatures();
                /*0x1665e10*/ void UpdateGlyphAdjustmentRecords();
                /*0x16659d0*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
                /*0x32d010*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                /*0x32d010*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes);
                /*0x183150*/ void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                /*0x165d880*/ void ClearFontAssetData(bool setAtlasSizeToZero);
                /*0x165d850*/ void ClearFontAssetDataInternal(bool clearFontFeatures);
                /*0x16652a0*/ void UpdateFontAssetData();
                /*0x165d9a0*/ void ClearFontAssetTables(bool clearFontFeatures);
                /*0x165d610*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
                /*0x165ead0*/ void DestroyAtlasTextures();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.Character, uint> <>9__151_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__152_0;

                    static /*0x1672350*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x4c9d10*/ uint <SortCharacterTable>b__151_0(UnityEngine.TextCore.Text.Character c);
                    /*0x1477600*/ uint <SortGlyphTable>b__152_0(UnityEngine.TextCore.Glyph c);
                }
            }

            class FontAssetUtilities
            {
                static /*0x0*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;

                static /*0x165c910*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface);
                static /*0x165c430*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface);
                static /*0x165ca20*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAssets(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface);
                static /*0x165cdc0*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
                static /*0x165cc00*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
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

                /*0x1667640*/ FontFeatureTable();
                /*0x1666f80*/ void SortGlyphPairAdjustmentRecords();
                /*0x16671c0*/ void SortMarkToBaseAdjustmentRecords();
                /*0x1667400*/ void SortMarkToMarkAdjustmentRecords();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontFeatureTable.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__25_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__25_1;
                    static /*0x18*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__26_0;
                    static /*0x20*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__26_1;
                    static /*0x28*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__27_0;
                    static /*0x30*/ System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__27_1;

                    static /*0x1672270*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x16721b0*/ uint <SortGlyphPairAdjustmentRecords>b__25_0(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x16721f0*/ uint <SortGlyphPairAdjustmentRecords>b__25_1(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x1672230*/ uint <SortMarkToBaseAdjustmentRecords>b__26_0(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s);
                    /*0x1672250*/ uint <SortMarkToBaseAdjustmentRecords>b__26_1(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s);
                    /*0x1672230*/ uint <SortMarkToMarkAdjustmentRecords>b__27_0(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s);
                    /*0x1672250*/ uint <SortMarkToMarkAdjustmentRecords>b__27_1(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s);
                }
            }

            struct Extents
            {
                /*0x10*/ UnityEngine.Vector2 min;
                /*0x18*/ UnityEngine.Vector2 max;

                /*0x165c250*/ string ToString();
            }

            struct LineInfo
            {
                /*0x10*/ int controlCharacterCount;
                /*0x14*/ int characterCount;
                /*0x18*/ int visibleCharacterCount;
                /*0x1c*/ int spaceCount;
                /*0x20*/ int visibleSpaceCount;
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

                /*0x1667a00*/ void SetLinkId(char[] text, int startIndex, int length);
                /*0x1667900*/ string GetLinkText(UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x16678b0*/ string GetLinkId();
            }

            class MaterialManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<long, UnityEngine.Material> s_FallbackMaterials;

                static /*0x1668740*/ MaterialManager();
                static /*0x1667df0*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
                static /*0x1668220*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
                static /*0x1667b00*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);
            }

            struct MaterialReference
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x20*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x28*/ UnityEngine.Material material;
                /*0x30*/ bool isDefaultMaterial;
                /*0x31*/ bool isFallbackMaterial;
                /*0x38*/ UnityEngine.Material fallbackMaterial;
                /*0x40*/ float padding;
                /*0x44*/ int referenceCount;

                static /*0x16695a0*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                static /*0x1669800*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                /*0x1669a40*/ MaterialReference(int index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
            }

            class MaterialReferenceManager
            {
                static /*0x0*/ UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance;
                /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup;
                /*0x28*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup;

                static /*0x16693d0*/ UnityEngine.TextCore.Text.MaterialReferenceManager get_instance();
                static /*0x1668a80*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x1668db0*/ void AddSpriteAsset(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x1668c80*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
                static /*0x1668860*/ void AddColorGradientPreset(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                static /*0x1669000*/ bool TryGetFontAsset(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x1669200*/ bool TryGetSpriteAsset(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x1668f00*/ bool TryGetColorGradientPreset(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                static /*0x1669100*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
                /*0x1669280*/ MaterialReferenceManager();
                /*0x1668900*/ void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x1668cf0*/ void AddSpriteAssetInternal(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x1668c10*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
                /*0x16687d0*/ void AddColorGradientPreset_Internal(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                /*0x1668f80*/ bool TryGetFontAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x1669180*/ bool TryGetSpriteAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x1668e80*/ bool TryGetColorGradientPresetInternal(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                /*0x1669080*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
            }

            enum VertexSortingOrder
            {
                Normal = 0,
                Reverse = 1,
            }

            struct MeshInfo
            {
                static /*0x0*/ UnityEngine.Color32 k_DefaultColor;
                static /*0x4*/ UnityEngine.Vector3 k_DefaultNormal;
                static /*0x10*/ UnityEngine.Vector4 k_DefaultTangent;
                /*0x10*/ int vertexCount;
                /*0x18*/ UnityEngine.Vector3[] vertices;
                /*0x20*/ UnityEngine.Vector3[] normals;
                /*0x28*/ UnityEngine.Vector4[] tangents;
                /*0x30*/ UnityEngine.Vector4[] uvs0;
                /*0x38*/ UnityEngine.Vector2[] uvs2;
                /*0x40*/ UnityEngine.Color32[] colors32;
                /*0x48*/ int[] triangles;
                /*0x50*/ UnityEngine.Material material;
                /*0x58*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode;

                static /*0x166a600*/ MeshInfo();
                /*0x166a690*/ MeshInfo(int size);
                /*0x1669b80*/ void ResizeMeshInfo(int size);
                /*0x1669b40*/ void Clear(bool uploadChanges);
                /*0x1669b00*/ void ClearUnusedVertices();
                /*0x1669d80*/ void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder order);
                /*0x1669e30*/ void SwapVertexData(int src, int dst);
            }

            class SpriteAsset : UnityEngine.TextCore.Text.TextAsset
            {
                static /*0x0*/ System.Collections.Generic.HashSet<int> k_searchedSpriteAssets;
                /*0x38*/ System.Collections.Generic.Dictionary<int, int> m_NameLookup;
                /*0x40*/ System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
                /*0x48*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
                /*0xa8*/ UnityEngine.Texture m_SpriteAtlasTexture;
                /*0xb0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable;
                /*0xb8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup;
                /*0xc0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable;
                /*0xc8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup;
                /*0xd0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets;
                /*0xd8*/ bool m_IsSpriteAssetLookupTablesDirty;

                static /*0x166b570*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x166b320*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x166b4b0*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x166afa0*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings);
                static /*0x166ad40*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
                static /*0x166aee0*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
                /*0x166c270*/ SpriteAsset();
                /*0x166c340*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x14a1e80*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x1634580*/ UnityEngine.Texture get_spriteSheet();
                /*0xbf30d0*/ void set_spriteSheet(UnityEngine.Texture value);
                /*0x166c3c0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable();
                /*0x1465d00*/ void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x166c380*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable();
                /*0xb699b0*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x1634650*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable();
                /*0x1465c00*/ void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value);
                /*0x32d010*/ void Awake();
                /*0x166bd20*/ void UpdateLookupTables();
                /*0x166abd0*/ int GetSpriteIndexFromHashcode(int hashCode);
                /*0x166aca0*/ int GetSpriteIndexFromUnicode(uint unicode);
                /*0x166ac60*/ int GetSpriteIndexFromName(string name);
                /*0x166bba0*/ void SortGlyphTable();
                /*0x166b750*/ void SortCharacterTable();
                /*0x166b8d0*/ void SortGlyphAndCharacterTables();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.SpriteAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.SpriteGlyph, uint> <>9__37_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Text.SpriteCharacter, uint> <>9__38_0;

                    static /*0x16722e0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1477600*/ uint <SortGlyphTable>b__37_0(UnityEngine.TextCore.Text.SpriteGlyph item);
                    /*0x4c9d10*/ uint <SortCharacterTable>b__38_0(UnityEngine.TextCore.Text.SpriteCharacter c);
                }
            }

            class SpriteCharacter : UnityEngine.TextCore.Text.TextElement
            {
                /*0x30*/ string m_Name;

                /*0x14a1f90*/ SpriteCharacter();
                /*0x15fe590*/ string get_name();
            }

            class SpriteGlyph : UnityEngine.TextCore.Glyph
            {
                /*0x48*/ UnityEngine.Sprite sprite;

                /*0x14a2260*/ SpriteGlyph();
            }

            class TextAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ string m_Version;
                /*0x20*/ int m_InstanceID;
                /*0x24*/ int m_HashCode;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ int m_MaterialHashCode;

                /*0x533ec0*/ TextAsset();
                /*0x8b8f40*/ string get_version();
                /*0x7963c0*/ void set_version(string value);
                /*0x166c440*/ int get_instanceID();
                /*0x166c400*/ int get_hashCode();
                /*0xc70b30*/ void set_hashCode(int value);
                /*0x79a150*/ UnityEngine.Material get_material();
                /*0x98b030*/ void set_material(UnityEngine.Material value);
                /*0x166c470*/ int get_materialHashCode();
                /*0xa79cd0*/ void set_materialHashCode(int value);
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

                static /*0x166c510*/ TextColorGradient();
                /*0x166c550*/ TextColorGradient();
                /*0x14558d0*/ TextColorGradient(UnityEngine.Color color);
                /*0x1455920*/ TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
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

                /*0x32f970*/ TextElement();
                /*0x166ea40*/ UnityEngine.TextCore.Text.TextElementType get_elementType();
                /*0x8b8c40*/ uint get_unicode();
                /*0xc70b20*/ void set_unicode(uint value);
                /*0x8b8f40*/ UnityEngine.TextCore.Text.TextAsset get_textAsset();
                /*0x7963c0*/ void set_textAsset(UnityEngine.TextCore.Text.TextAsset value);
                /*0x15fe5a0*/ UnityEngine.TextCore.Glyph get_glyph();
                /*0x7965a0*/ void set_glyph(UnityEngine.TextCore.Glyph value);
                /*0xca7c90*/ uint get_glyphIndex();
                /*0xc6dab0*/ void set_glyphIndex(uint value);
                /*0x1644f10*/ float get_scale();
                /*0x4ccc50*/ void set_scale(float value);
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
                /*0x10*/ char character;
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

                /*0x166c600*/ string ToString();
            }

            class TextGenerationSettings : System.IEquatable<UnityEngine.TextCore.Text.TextGenerationSettings>
            {
                /*0x10*/ string text;
                /*0x18*/ UnityEngine.Rect screenRect;
                /*0x28*/ UnityEngine.Vector4 margins;
                /*0x38*/ float scale;
                /*0x40*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x48*/ UnityEngine.Material material;
                /*0x50*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x58*/ UnityEngine.TextCore.Text.TextStyleSheet styleSheet;
                /*0x60*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
                /*0x68*/ UnityEngine.TextCore.Text.TextSettings textSettings;
                /*0x70*/ UnityEngine.TextCore.Text.TextAlignment textAlignment;
                /*0x74*/ UnityEngine.TextCore.Text.TextOverflowMode overflowMode;
                /*0x78*/ bool wordWrap;
                /*0x7c*/ float wordWrappingRatio;
                /*0x80*/ UnityEngine.Color color;
                /*0x90*/ UnityEngine.TextCore.Text.TextColorGradient fontColorGradient;
                /*0x98*/ UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset;
                /*0xa0*/ bool tintSprites;
                /*0xa1*/ bool overrideRichTextColors;
                /*0xa2*/ bool shouldConvertToLinearSpace;
                /*0xa4*/ float fontSize;
                /*0xa8*/ bool autoSize;
                /*0xac*/ float fontSizeMin;
                /*0xb0*/ float fontSizeMax;
                /*0xb4*/ bool enableKerning;
                /*0xb5*/ bool richText;
                /*0xb6*/ bool isRightToLeft;
                /*0xb8*/ float extraPadding;
                /*0xbc*/ bool parseControlCharacters;
                /*0xbd*/ bool isOrthographic;
                /*0xbe*/ bool tagNoParsing;
                /*0xc0*/ float characterSpacing;
                /*0xc4*/ float wordSpacing;
                /*0xc8*/ float lineSpacing;
                /*0xcc*/ float paragraphSpacing;
                /*0xd0*/ float lineSpacingMax;
                /*0xd4*/ UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode;
                /*0xd8*/ int maxVisibleCharacters;
                /*0xdc*/ int maxVisibleWords;
                /*0xe0*/ int maxVisibleLines;
                /*0xe4*/ int firstVisibleCharacter;
                /*0xe8*/ bool useMaxVisibleDescender;
                /*0xec*/ UnityEngine.TextCore.Text.TextFontWeight fontWeight;
                /*0xf0*/ int pageToDisplay;
                /*0xf4*/ UnityEngine.TextCore.Text.TextureMapping horizontalMapping;
                /*0xf8*/ UnityEngine.TextCore.Text.TextureMapping verticalMapping;
                /*0xfc*/ float uvLineOffset;
                /*0x100*/ UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder;
                /*0x104*/ bool inverseYAxis;
                /*0x108*/ float charWidthMaxAdj;
                /*0x10c*/ UnityEngine.TextCore.Text.TextInputSource inputSource;

                static /*0x16721a0*/ bool op_Equality(UnityEngine.TextCore.Text.TextGenerationSettings left, UnityEngine.TextCore.Text.TextGenerationSettings right);
                /*0x16720e0*/ TextGenerationSettings();
                /*0x166ea50*/ bool Equals(UnityEngine.TextCore.Text.TextGenerationSettings other);
                /*0x166f050*/ bool Equals(object obj);
                /*0x166f160*/ int GetHashCode();
                /*0x166f700*/ string ToString();
            }

            class TextGenerator
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextGenerator s_TextGenerator;
                static /*0x8*/ bool m_IsTextTruncated;
                static /*0x10*/ UnityEngine.TextCore.Text.TextGenerator.MissingCharacterEventCallback OnMissingCharacter;
                /*0x10*/ UnityEngine.TextCore.Text.TextBackingContainer m_TextBackingArray;
                /*0x20*/ UnityEngine.TextCore.Text.TextProcessingElement[] m_TextProcessingArray;
                /*0x28*/ int m_InternalTextProcessingArraySize;
                /*0x2c*/ bool m_VertexBufferAutoSizeReduction;
                /*0x30*/ char[] m_HtmlTag;
                /*0x38*/ UnityEngine.TextCore.Text.HighlightState m_HighlightState;
                /*0x4c*/ bool m_IsIgnoringAlignment;
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
                /*0x2f4*/ float m_XAdvance;
                /*0x2f8*/ float m_TagLineIndent;
                /*0x2fc*/ float m_TagIndent;
                /*0x300*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_IndentStack;
                /*0x320*/ bool m_TagNoParsing;
                /*0x324*/ int m_CharacterCount;
                /*0x328*/ int m_FirstCharacterOfLine;
                /*0x32c*/ int m_LastCharacterOfLine;
                /*0x330*/ int m_FirstVisibleCharacterOfLine;
                /*0x334*/ int m_LastVisibleCharacterOfLine;
                /*0x338*/ float m_MaxLineAscender;
                /*0x33c*/ float m_MaxLineDescender;
                /*0x340*/ int m_LineNumber;
                /*0x344*/ int m_LineVisibleCharacterCount;
                /*0x348*/ int m_LineVisibleSpaceCount;
                /*0x34c*/ int m_FirstOverflowCharacterIndex;
                /*0x350*/ int m_PageNumber;
                /*0x354*/ float m_MarginLeft;
                /*0x358*/ float m_MarginRight;
                /*0x35c*/ float m_Width;
                /*0x360*/ UnityEngine.TextCore.Text.Extents m_MeshExtents;
                /*0x370*/ float m_MaxCapHeight;
                /*0x374*/ float m_MaxAscender;
                /*0x378*/ float m_MaxDescender;
                /*0x37c*/ bool m_IsNewPage;
                /*0x37d*/ bool m_IsNonBreakingSpace;
                /*0x380*/ UnityEngine.TextCore.Text.WordWrapState m_SavedWordWrapState;
                /*0x718*/ UnityEngine.TextCore.Text.WordWrapState m_SavedLineState;
                /*0xab0*/ UnityEngine.TextCore.Text.WordWrapState m_SavedEllipsisState;
                /*0xe48*/ UnityEngine.TextCore.Text.WordWrapState m_SavedLastValidState;
                /*0x11e0*/ UnityEngine.TextCore.Text.WordWrapState m_SavedSoftLineBreakState;
                /*0x1578*/ UnityEngine.TextCore.Text.TextElementType m_TextElementType;
                /*0x1579*/ bool m_isTextLayoutPhase;
                /*0x157c*/ int m_SpriteIndex;
                /*0x1580*/ UnityEngine.Color32 m_SpriteColor;
                /*0x1588*/ UnityEngine.TextCore.Text.TextElement m_CachedTextElement;
                /*0x1590*/ UnityEngine.Color32 m_HighlightColor;
                /*0x1594*/ float m_CharWidthAdjDelta;
                /*0x1598*/ float m_MaxFontSize;
                /*0x159c*/ float m_MinFontSize;
                /*0x15a0*/ int m_AutoSizeIterationCount;
                /*0x15a4*/ int m_AutoSizeMaxIterationCount;
                /*0x15a8*/ bool m_IsAutoSizePointSizeSet;
                /*0x15ac*/ float m_StartOfLineAscender;
                /*0x15b0*/ float m_LineSpacingDelta;
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
                /*0x19f0*/ UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;
                /*0x19f8*/ bool m_TintSprite;
                /*0x1a00*/ UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Ellipsis;
                /*0x1a20*/ UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Underline;
                /*0x1a40*/ UnityEngine.TextCore.Text.TextElementInfo[] m_InternalTextElementInfo;

                static /*0x16826e0*/ UnityEngine.TextCore.Text.TextGenerator GetTextGenerator();
                static /*0x1681a50*/ void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x1681f90*/ UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x168e7d0*/ bool get_isTextTruncated();
                static /*0x1680080*/ void ClearMesh(bool updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x168ddd0*/ TextGenerator();
                /*0x1683fe0*/ void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x16723c0*/ void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1686750*/ void SaveWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, int index, int count, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1684350*/ int RestoreWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1688850*/ bool ValidateHtmlTag(UnityEngine.TextCore.Text.TextProcessingElement[] chars, int startIndex, ref int endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x16848e0*/ void SaveGlyphVertexInfo(float padding, float stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1685c90*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x16809e0*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1680230*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1686ce0*/ int SetArraySizes(UnityEngine.TextCore.Text.TextProcessingElement[] textProcessingArray, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1682360*/ UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isUsingAlternativeTypeface);
                /*0x16800b0*/ void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins);
                /*0x1682290*/ void GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x1681be0*/ void GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x1682770*/ void GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x1681e00*/ UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x167c800*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, UnityEngine.TextCore.Text.TextWrappingMode textWrapMode, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1683190*/ void PopulateTextBackingArray(string sourceText);
                /*0x16830a0*/ void PopulateTextBackingArray(string sourceText, int start, int length);
                /*0x1683260*/ void PopulateTextProcessingArray(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x1682830*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x16801b0*/ void DoMissingGlyphCallback(uint unicode, int stringIndex, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x1680020*/ void ClearMarkupTagAttributes();

                class MissingCharacterEventCallback : System.MulticastDelegate
                {
                    /*0x168eba0*/ MissingCharacterEventCallback(object object, nint method);
                    /*0x7239c0*/ void Invoke(uint unicode, int stringIndex, UnityEngine.TextCore.Text.TextInfo text, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }

                struct SpecialCharacter
                {
                    /*0x10*/ UnityEngine.TextCore.Text.Character character;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                    /*0x20*/ UnityEngine.Material material;
                    /*0x28*/ int materialIndex;

                    /*0x168eda0*/ SpecialCharacter(UnityEngine.TextCore.Text.Character character, int materialIndex);
                }
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

                /*0x168ef60*/ TextBackingContainer(int size);
                /*0x728950*/ int get_Capacity();
                /*0xb73eb0*/ int get_Count();
                /*0xf0fbd0*/ void set_Count(int value);
                /*0x14ac7a0*/ uint get_Item(int index);
                /*0x168efc0*/ void set_Item(int index, uint value);
                /*0x168ef10*/ void Resize(int size);
            }

            struct CharacterSubstitution
            {
                /*0x10*/ int index;
                /*0x14*/ uint unicode;

                /*0xa59f20*/ CharacterSubstitution(int index, uint unicode);
            }

            struct Offset
            {
                static /*0x0*/ UnityEngine.TextCore.Text.Offset k_ZeroOffset;
                /*0x10*/ float m_Left;
                /*0x14*/ float m_Right;
                /*0x18*/ float m_Top;
                /*0x1c*/ float m_Bottom;

                static /*0x168ed00*/ Offset();
                static /*0x168ed40*/ UnityEngine.TextCore.Text.Offset get_zero();
                static /*0x1245350*/ bool op_Equality(UnityEngine.TextCore.Text.Offset lhs, UnityEngine.TextCore.Text.Offset rhs);
                static /*0x15e10d0*/ UnityEngine.TextCore.Text.Offset op_Multiply(UnityEngine.TextCore.Text.Offset a, float b);
                /*0x11534a0*/ Offset(float left, float right, float top, float bottom);
                /*0x6ef1f0*/ float get_left();
                /*0x6ef200*/ float get_right();
                /*0x501230*/ float get_top();
                /*0x501220*/ float get_bottom();
                /*0x168ecb0*/ int GetHashCode();
                /*0x168ec50*/ bool Equals(object obj);
            }

            struct HighlightState
            {
                /*0x10*/ UnityEngine.Color32 color;
                /*0x14*/ UnityEngine.TextCore.Text.Offset padding;

                static /*0x168e920*/ bool op_Equality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs);
                static /*0x168ea60*/ bool op_Inequality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs);
                /*0xa5a210*/ HighlightState(UnityEngine.Color32 color, UnityEngine.TextCore.Text.Offset padding);
                /*0x168e8c0*/ int GetHashCode();
                /*0x168e850*/ bool Equals(object obj);
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

                static /*0x1693870*/ TextGeneratorUtilities();
                static /*0x168f3f0*/ bool Approximately(float a, float b);
                static /*0x16918a0*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
                static /*0x1691f60*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
                static /*0x16921e0*/ uint HexToInt(char hex);
                static /*0x168f5a0*/ float ConvertToFloat(char[] chars, int startIndex, int length);
                static /*0x168f420*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
                static /*0x1692ff0*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
                static /*0x177be0*/ void ResizeInternalArray<T>(ref T[] array);
                static /*0x1827f0*/ void ResizeInternalArray<T>(ref T[] array, int size);
                static /*0x16925e0*/ void InsertOpeningTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x1692400*/ void InsertClosingTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x1693160*/ bool ReplaceOpeningStyleTag(ref UnityEngine.TextCore.Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x1693350*/ bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, ref int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x1693030*/ void ReplaceClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x16924f0*/ void InsertOpeningStyleTag(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x1692300*/ void InsertClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x16926d0*/ void InsertTextStyleInTextProcessingArray(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int> textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x16912c0*/ UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, int hashCode);
                static /*0x16911d0*/ int GetStyleHashCode(ref uint[] text, int index, ref int closeIndex);
                static /*0x16910e0*/ int GetStyleHashCode(ref UnityEngine.TextCore.Text.TextBackingContainer text, int index, ref int closeIndex);
                static /*0x16914b0*/ uint GetUTF16(uint[] text, int i);
                static /*0x16913b0*/ uint GetUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int i);
                static /*0x1691590*/ uint GetUTF32(uint[] text, int i);
                static /*0x16916f0*/ uint GetUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int i);
                static /*0x168f630*/ void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x16901d0*/ void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x168f050*/ void AdjustLineOffset(int startIndex, int endIndex, float offset, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x1693540*/ void ResizeLineExtents(int size, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x1692f60*/ UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle);
                static /*0x1692ee0*/ UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor);
                static /*0x168f620*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
                static /*0x1690fe0*/ int GetMarkupTagHashCode(UnityEngine.TextCore.Text.TextBackingContainer styleDefinition, int readIndex);
                static /*0x1690ef0*/ int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex);
                static /*0x1693750*/ char ToUpperASCIIFast(char c);
                static /*0x16937b0*/ uint ToUpperASCIIFast(uint c);
                static /*0x1693810*/ char ToUpperFast(char c);
                static /*0x1690e00*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
                static /*0x1692cb0*/ bool IsBitmapRendering(UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode);
                static /*0x1692ba0*/ bool IsBaseGlyph(uint c);
                static /*0x1692f90*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
                static /*0x1690cd0*/ UnityEngine.Color32 GammaToLinear(UnityEngine.Color32 c);
                static /*0x1690d50*/ byte GammaToLinear(byte value);
                static /*0x1692e00*/ bool IsValidUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int index);
                static /*0x1692e70*/ bool IsValidUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int index);
                static /*0x1692da0*/ bool IsHangul(uint c);
                static /*0x1692ce0*/ bool IsCJK(uint c);
            }

            class TextHandle
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextInfo m_LayoutTextInfo;
                static /*0x8*/ UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings;
                /*0x10*/ UnityEngine.Vector2 m_PreferredSize;
                /*0x18*/ UnityEngine.TextCore.Text.TextInfo m_TextInfo;
                /*0x20*/ int m_PreviousGenerationSettingsHash;
                /*0x28*/ UnityEngine.TextCore.Text.TextGenerationSettings textGenerationSettings;
                /*0x30*/ bool isDirty;

                static /*0x1697010*/ TextHandle();
                static /*0x1697100*/ UnityEngine.TextCore.Text.TextInfo get_layoutTextInfo();
                static /*0x1696ae0*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
                static /*0x1693910*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
                /*0x1697090*/ TextHandle();
                /*0x16971f0*/ UnityEngine.TextCore.Text.TextInfo get_textInfo();
                /*0x1695d00*/ bool IsDirty();
                /*0x16952e0*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis);
                /*0x1695570*/ UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance, bool inverseYAxis);
                /*0x1694ec0*/ int GetCursorIndexFromPosition(UnityEngine.Vector2 position, bool inverseYAxis);
                /*0x1695f30*/ int LineDownCharacterPosition(int originalPos);
                /*0x16964f0*/ int LineUpCharacterPosition(int originalPos);
                /*0x1694b30*/ int FindNearestLine(UnityEngine.Vector2 position);
                /*0x1694130*/ int FindNearestCharacterOnLine(UnityEngine.Vector2 position, int line, bool visibleOnly);
                /*0x1693b00*/ int FindIntersectingLink(UnityEngine.Vector3 position, bool inverseYAxis);
                /*0x1695a80*/ int GetLineNumber(int index);
                /*0x16959a0*/ float GetLineHeight(int lineNumber);
                /*0x1695800*/ float GetLineHeightFromCharacterIndex(int index);
                /*0x1694ce0*/ float GetCharacterHeightFromIndex(int index);
                /*0x1695d50*/ bool IsElided();
                /*0x1696c60*/ string Substring(int startIndex, int length);
                /*0x1695b60*/ int IndexOf(char value, int startIndex);
                /*0x1695df0*/ int LastIndexOf(char value, int startIndex);
                /*0x16938f0*/ float ComputeTextWidth(UnityEngine.TextCore.Text.TextGenerationSettings tgs);
                /*0x16938d0*/ float ComputeTextHeight(UnityEngine.TextCore.Text.TextGenerationSettings tgs);
                /*0x1696e20*/ void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings tgs);
                /*0x1696f70*/ UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.TextCore.Text.TextGenerationSettings tgs);
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
                /*0x60*/ bool isDirty;
                /*0x61*/ bool hasMultipleColors;

                static /*0x1697720*/ TextInfo();
                static /*0x1827f0*/ void Resize<T>(ref T[] array, int size);
                static /*0x182ab0*/ void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
                /*0x1697780*/ TextInfo();
                /*0x16976b0*/ void Clear();
                /*0x16974f0*/ void ClearMeshInfo(bool updateMesh);
                /*0x1697260*/ void ClearLineInfo();
                /*0x16975b0*/ void ClearPageInfo();
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
                RED = 91635,
                GREEN = 87065851,
                BLUE = 2457214,
                YELLOW = -882444668,
                ORANGE = -1108587920,
                BLACK = 81074727,
                WHITE = 105680263,
                PURPLE = -1250222130,
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

                /*0x1498510*/ void Clear();
                /*0x1498460*/ byte Add(UnityEngine.TextCore.Text.FontStyles style);
                /*0x1498520*/ byte Remove(UnityEngine.TextCore.Text.FontStyles style);
            }

            struct TextProcessingStack<T>
            {
                /*0x0*/ T[] itemStack;
                /*0x0*/ int index;
                /*0x0*/ T m_DefaultItem;
                /*0x0*/ int m_Capacity;
                /*0x0*/ int m_RolloverSize;
                /*0x0*/ int m_Count;

                static /*0x2a5510*/ void SetDefault(UnityEngine.TextCore.Text.TextProcessingStack<T> stack, T item);
                /*0x17aec0*/ TextProcessingStack(T[] stack);
                /*0x17aa40*/ TextProcessingStack(int capacity);
                /*0x1817d0*/ TextProcessingStack(int capacity, int rolloverSize);
                /*0x180980*/ int get_Count();
                /*0x2a5510*/ T get_current();
                /*0x180fc0*/ void Clear();
                /*0x2a5510*/ void SetDefault(T item);
                /*0x2a5510*/ void Add(T item);
                /*0x2a5510*/ T Remove();
                /*0x2a5510*/ void Push(T item);
                /*0x2a5510*/ T Pop();
                /*0x2a5510*/ T Peek();
                /*0x2a5510*/ T CurrentItem();
            }

            class TextResourceManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup;
                static /*0x10*/ System.Collections.Generic.Dictionary<long, UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;
                static /*0x18*/ System.Collections.Generic.List<int> s_FontAssetRemovalList;
                static /*0x20*/ int k_RegularStyleHashCode;

                static /*0x1697f40*/ TextResourceManager();
                static /*0x16978d0*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);

                struct FontAssetRef
                {
                    /*0x10*/ int nameHashCode;
                    /*0x14*/ int familyNameHashCode;
                    /*0x18*/ int styleNameHashCode;
                    /*0x20*/ long familyNameAndStyleHashCode;
                    /*0x28*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x168e810*/ FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }
            }

            class TextSettings : UnityEngine.ScriptableObject
            {
                /*0x18*/ string m_Version;
                /*0x20*/ UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset;
                /*0x28*/ string m_DefaultFontAssetPath;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets;
                /*0x38*/ bool m_MatchMaterialPreset;
                /*0x3c*/ int m_MissingCharacterUnicode;
                /*0x40*/ bool m_ClearDynamicDataOnBuild;
                /*0x48*/ UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;
                /*0x50*/ string m_DefaultSpriteAssetPath;
                /*0x58*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets;
                /*0x60*/ uint m_MissingSpriteCharacterUnicode;
                /*0x68*/ UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet;
                /*0x70*/ string m_StyleSheetsResourcePath;
                /*0x78*/ string m_DefaultColorGradientPresetsPath;
                /*0x80*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules;
                /*0x88*/ bool m_UseModernHangulLineBreakingRules;
                /*0x89*/ bool m_DisplayWarnings;
                /*0x90*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontLookup;
                /*0x98*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences;

                /*0x16987c0*/ TextSettings();
                /*0x32f410*/ string get_version();
                /*0x7963c0*/ void set_version(string value);
                /*0x61a260*/ UnityEngine.TextCore.Text.FontAsset get_defaultFontAsset();
                /*0x7965a0*/ void set_defaultFontAsset(UnityEngine.TextCore.Text.FontAsset value);
                /*0x79a150*/ string get_defaultFontAssetPath();
                /*0x98b030*/ void set_defaultFontAssetPath(string value);
                /*0x997630*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets();
                /*0x997640*/ void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0xd180c0*/ bool get_matchMaterialPreset();
                /*0xd18610*/ void set_matchMaterialPreset(bool value);
                /*0xee1680*/ int get_missingCharacterUnicode();
                /*0x136a430*/ void set_missingCharacterUnicode(int value);
                /*0xb61dd0*/ bool get_clearDynamicDataOnBuild();
                /*0xb61de0*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x4e40d0*/ UnityEngine.TextCore.Text.SpriteAsset get_defaultSpriteAsset();
                /*0x4e4360*/ void set_defaultSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value);
                /*0x4e40e0*/ string get_defaultSpriteAssetPath();
                /*0x4e4370*/ void set_defaultSpriteAssetPath(string value);
                /*0xb61940*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets();
                /*0xb61a20*/ void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value);
                /*0xf91dd0*/ uint get_missingSpriteCharacterUnicode();
                /*0xf91480*/ void set_missingSpriteCharacterUnicode(uint value);
                /*0x8af030*/ UnityEngine.TextCore.Text.TextStyleSheet get_defaultStyleSheet();
                /*0xe69480*/ void set_defaultStyleSheet(UnityEngine.TextCore.Text.TextStyleSheet value);
                /*0xd184b0*/ string get_styleSheetsResourcePath();
                /*0xe49c60*/ void set_styleSheetsResourcePath(string value);
                /*0xecb7b0*/ string get_defaultColorGradientPresetsPath();
                /*0x1698990*/ void set_defaultColorGradientPresetsPath(string value);
                /*0x16988f0*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules get_lineBreakingRules();
                /*0x12cadc0*/ void set_lineBreakingRules(UnityEngine.TextCore.Text.UnicodeLineBreakingRules value);
                /*0x1698980*/ bool get_useModernHangulLineBreakingRules();
                /*0x737e10*/ void set_useModernHangulLineBreakingRules(bool value);
                /*0x737880*/ bool get_displayWarnings();
                /*0x737bb0*/ void set_displayWarnings(bool value);
                /*0x1698720*/ void OnEnable();
                /*0x16984e0*/ void InitializeFontReferenceLookup();
                /*0x1698120*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font font);

                struct FontReferenceMap
                {
                    /*0x10*/ UnityEngine.Font font;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0xa59de0*/ FontReferenceMap(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset);
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
                static /*0x150*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;

                static /*0x1699490*/ TextShaderUtilities();
                static /*0x1699a50*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
                static /*0x16997d0*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
                static /*0x16989a0*/ void GetShaderPropertyIDs();
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

                /*0x169a4e0*/ TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
                /*0xbe6cb0*/ int get_hashCode();
                /*0x15fe590*/ uint[] get_styleOpeningTagArray();
                /*0x16345e0*/ uint[] get_styleClosingTagArray();
                /*0x169a260*/ void RefreshStyle();
            }

            class TextStyleSheet : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary;

                /*0x169a1e0*/ TextStyleSheet();
                /*0x8b8f40*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles();
                /*0x169a1d0*/ void Reset();
                /*0x1699cd0*/ UnityEngine.TextCore.Text.TextStyle GetStyle(int hashCode);
                /*0x1699d60*/ UnityEngine.TextCore.Text.TextStyle GetStyle(string name);
                /*0x169a1d0*/ void RefreshStyles();
                /*0x1699e00*/ void LoadStyleDictionaryInternal();
            }

            class TextUtilities
            {
                static /*0x169a610*/ char ToUpperFast(char c);
                static /*0x169a570*/ int GetHashCodeCaseInSensitive(string s);
                static /*0x169a670*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
            }

            class UnicodeLineBreakingRules
            {
                /*0x10*/ UnityEngine.TextAsset m_UnicodeLineBreakingRules;
                /*0x18*/ UnityEngine.TextAsset m_LeadingCharacters;
                /*0x20*/ UnityEngine.TextAsset m_FollowingCharacters;
                /*0x28*/ bool m_UseModernHangulLineBreakingRules;
                /*0x30*/ System.Collections.Generic.HashSet<uint> m_LeadingCharactersLookup;
                /*0x38*/ System.Collections.Generic.HashSet<uint> m_FollowingCharactersLookup;

                static /*0x169a740*/ System.Collections.Generic.HashSet<uint> GetCharacters(UnityEngine.TextAsset file);
                /*0x32f970*/ UnicodeLineBreakingRules();
                /*0x32f410*/ UnityEngine.TextAsset get_leadingCharacters();
                /*0x61a260*/ UnityEngine.TextAsset get_followingCharacters();
                /*0x169ac10*/ System.Collections.Generic.HashSet<uint> get_leadingCharactersLookup();
                /*0x169abd0*/ System.Collections.Generic.HashSet<uint> get_followingCharactersLookup();
                /*0x4ba480*/ bool get_useModernHangulLineBreakingRules();
                /*0x169a810*/ void LoadLineBreakingRules();
                /*0x169aa00*/ void LoadLineBreakingRules(UnityEngine.TextAsset leadingRules, UnityEngine.TextAsset followingRules);
            }
        }
    }
}
