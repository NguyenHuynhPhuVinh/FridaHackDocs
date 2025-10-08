class <Module>
{
}

namespace UnityEngine
{
    enum FontStyle
    {
        Normal = 0,
        Bold = 1,
        Italic = 2,
        BoldAndItalic = 3,
    }

    enum TextGenerationError
    {
        None = 0,
        CustomSizeOnNonDynamicFont = 1,
        CustomStyleOnNonDynamicFont = 2,
        NoFont = 4,
    }

    struct TextGenerationSettings
    {
        /*0x10*/ UnityEngine.Font font;
        /*0x18*/ UnityEngine.Color color;
        /*0x28*/ int fontSize;
        /*0x2c*/ float lineSpacing;
        /*0x30*/ bool richText;
        /*0x34*/ float scaleFactor;
        /*0x38*/ UnityEngine.FontStyle fontStyle;
        /*0x3c*/ UnityEngine.TextAnchor textAnchor;
        /*0x40*/ bool alignByGeometry;
        /*0x41*/ bool resizeTextForBestFit;
        /*0x44*/ int resizeTextMinSize;
        /*0x48*/ int resizeTextMaxSize;
        /*0x4c*/ bool updateBounds;
        /*0x50*/ UnityEngine.VerticalWrapMode verticalOverflow;
        /*0x54*/ UnityEngine.HorizontalWrapMode horizontalOverflow;
        /*0x58*/ UnityEngine.Vector2 generationExtents;
        /*0x60*/ UnityEngine.Vector2 pivot;
        /*0x68*/ bool generateOutOfBounds;

        /*0x3ede354*/ bool CompareColors(UnityEngine.Color left, UnityEngine.Color right);
        /*0x3ede48c*/ bool CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right);
        /*0x3ede554*/ bool Equals(UnityEngine.TextGenerationSettings other);
    }

    class TextGenerator : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ string m_LastString;
        /*0x20*/ UnityEngine.TextGenerationSettings m_LastSettings;
        /*0x80*/ bool m_HasGenerated;
        /*0x84*/ UnityEngine.TextGenerationError m_LastValid;
        /*0x88*/ System.Collections.Generic.List<UnityEngine.UIVertex> m_Verts;
        /*0x90*/ System.Collections.Generic.List<UnityEngine.UICharInfo> m_Characters;
        /*0x98*/ System.Collections.Generic.List<UnityEngine.UILineInfo> m_Lines;
        /*0xa0*/ bool m_CachedVerts;
        /*0xa1*/ bool m_CachedCharacters;
        /*0xa2*/ bool m_CachedLines;

        static /*0x3ede8cc*/ nint Internal_Create();
        static /*0x3edea4c*/ void Internal_Destroy(nint ptr);
        static /*0x3edf658*/ void get_rectExtents_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x3edf69c*/ int get_characterCount_Injected(nint _unity_self);
        static /*0x3edf728*/ int get_lineCount_Injected(nint _unity_self);
        static /*0x3edfa14*/ bool Populate_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper str, nint font, ref UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        static /*0x3edfb48*/ void GetVerticesInternal_Injected(nint _unity_self, object vertices);
        static /*0x3edfb8c*/ void GetCharactersInternal_Injected(nint _unity_self, object characters);
        static /*0x3edfbd0*/ void GetLinesInternal_Injected(nint _unity_self, object lines);
        /*0x3ede758*/ TextGenerator();
        /*0x3ede760*/ TextGenerator(int initialCapacity);
        /*0x3ede8f4*/ void Finalize();
        /*0x3edea00*/ void System.IDisposable.Dispose();
        /*0x3edea88*/ int get_characterCountVisible();
        /*0x3edeaec*/ UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings);
        /*0x3edee18*/ void Invalidate();
        /*0x3edee20*/ void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters);
        /*0x3edee7c*/ void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines);
        /*0x3edeed8*/ void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x3edef34*/ float GetPreferredWidth(string str, UnityEngine.TextGenerationSettings settings);
        /*0x3edf04c*/ float GetPreferredHeight(string str, UnityEngine.TextGenerationSettings settings);
        /*0x3edf0a8*/ bool PopulateWithErrors(string str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context);
        /*0x3edef94*/ bool Populate(string str, UnityEngine.TextGenerationSettings settings);
        /*0x3edf274*/ UnityEngine.TextGenerationError PopulateWithError(string str, UnityEngine.TextGenerationSettings settings);
        /*0x3edf304*/ UnityEngine.TextGenerationError PopulateAlways(string str, UnityEngine.TextGenerationSettings settings);
        /*0x3edf5c8*/ System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts();
        /*0x3edf5f8*/ System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters();
        /*0x3edf628*/ System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines();
        /*0x3edefe0*/ UnityEngine.Rect get_rectExtents();
        /*0x3edea9c*/ int get_characterCount();
        /*0x3edf6d8*/ int get_lineCount();
        /*0x3edf764*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        /*0x3edf41c*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, ref UnityEngine.TextGenerationError error);
        /*0x3edeedc*/ void GetVerticesInternal(object vertices);
        /*0x3edee24*/ void GetCharactersInternal(object characters);
        /*0x3edee80*/ void GetLinesInternal(object lines);

        class BindingsMarshaller
        {
            static /*0x3edfc14*/ nint ConvertToNative(UnityEngine.TextGenerator textGenerator);
        }
    }

    enum TextAlignment
    {
        Left = 0,
        Center = 1,
        Right = 2,
    }

    enum TextAnchor
    {
        UpperLeft = 0,
        UpperCenter = 1,
        UpperRight = 2,
        MiddleLeft = 3,
        MiddleCenter = 4,
        MiddleRight = 5,
        LowerLeft = 6,
        LowerCenter = 7,
        LowerRight = 8,
    }

    enum TextGeneratorType
    {
        Standard = 0,
        Advanced = 1,
    }

    enum HorizontalWrapMode
    {
        Wrap = 0,
        Overflow = 1,
    }

    enum VerticalWrapMode
    {
        Truncate = 0,
        Overflow = 1,
    }

    class TextMesh : UnityEngine.Component
    {
        static /*0x3edfd54*/ void get_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3edff34*/ void set_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3ee000c*/ nint get_font_Injected(nint _unity_self);
        static /*0x3ee00fc*/ void set_font_Injected(nint _unity_self, nint value);
        static /*0x3ee01b8*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x3ee0274*/ void set_fontSize_Injected(nint _unity_self, int value);
        static /*0x3ee0330*/ UnityEngine.FontStyle get_fontStyle_Injected(nint _unity_self);
        static /*0x3ee03ec*/ void set_fontStyle_Injected(nint _unity_self, UnityEngine.FontStyle value);
        static /*0x3ee04a8*/ float get_offsetZ_Injected(nint _unity_self);
        static /*0x3ee056c*/ void set_offsetZ_Injected(nint _unity_self, float value);
        static /*0x3ee0630*/ UnityEngine.TextAlignment get_alignment_Injected(nint _unity_self);
        static /*0x3ee06ec*/ void set_alignment_Injected(nint _unity_self, UnityEngine.TextAlignment value);
        static /*0x3ee07a8*/ UnityEngine.TextAnchor get_anchor_Injected(nint _unity_self);
        static /*0x3ee0864*/ void set_anchor_Injected(nint _unity_self, UnityEngine.TextAnchor value);
        static /*0x3ee0920*/ float get_characterSize_Injected(nint _unity_self);
        static /*0x3ee09e4*/ void set_characterSize_Injected(nint _unity_self, float value);
        static /*0x3ee0aa8*/ float get_lineSpacing_Injected(nint _unity_self);
        static /*0x3ee0b6c*/ void set_lineSpacing_Injected(nint _unity_self, float value);
        static /*0x3ee0c30*/ float get_tabSize_Injected(nint _unity_self);
        static /*0x3ee0cf4*/ void set_tabSize_Injected(nint _unity_self, float value);
        static /*0x3ee0db8*/ bool get_richText_Injected(nint _unity_self);
        static /*0x3ee0e74*/ void set_richText_Injected(nint _unity_self, bool value);
        static /*0x3ee0f4c*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3ee1020*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        /*0x3ee1064*/ TextMesh();
        /*0x3edfc28*/ string get_text();
        /*0x3edfd98*/ void set_text(string value);
        /*0x3edff78*/ UnityEngine.Font get_font();
        /*0x3ee0048*/ void set_font(UnityEngine.Font value);
        /*0x3ee0140*/ int get_fontSize();
        /*0x3ee01f4*/ void set_fontSize(int value);
        /*0x3ee02b8*/ UnityEngine.FontStyle get_fontStyle();
        /*0x3ee036c*/ void set_fontStyle(UnityEngine.FontStyle value);
        /*0x3ee0430*/ float get_offsetZ();
        /*0x3ee04e4*/ void set_offsetZ(float value);
        /*0x3ee05b8*/ UnityEngine.TextAlignment get_alignment();
        /*0x3ee066c*/ void set_alignment(UnityEngine.TextAlignment value);
        /*0x3ee0730*/ UnityEngine.TextAnchor get_anchor();
        /*0x3ee07e4*/ void set_anchor(UnityEngine.TextAnchor value);
        /*0x3ee08a8*/ float get_characterSize();
        /*0x3ee095c*/ void set_characterSize(float value);
        /*0x3ee0a30*/ float get_lineSpacing();
        /*0x3ee0ae4*/ void set_lineSpacing(float value);
        /*0x3ee0bb8*/ float get_tabSize();
        /*0x3ee0c6c*/ void set_tabSize(float value);
        /*0x3ee0d40*/ bool get_richText();
        /*0x3ee0df4*/ void set_richText(bool value);
        /*0x3ee0eb8*/ UnityEngine.Color get_color();
        /*0x3ee0f90*/ void set_color(UnityEngine.Color value);
    }

    struct CharacterInfo
    {
        /*0x10*/ int index;
        /*0x14*/ UnityEngine.Rect uv;
        /*0x24*/ UnityEngine.Rect vert;
        /*0x34*/ float width;
        /*0x38*/ int size;
        /*0x3c*/ UnityEngine.FontStyle style;
        /*0x40*/ bool flipped;

        /*0x3ee106c*/ int get_advance();
    }

    struct UICharInfo
    {
        /*0x10*/ UnityEngine.Vector2 cursorPos;
        /*0x18*/ float charWidth;
    }

    struct UILineInfo
    {
        /*0x10*/ int startCharIdx;
        /*0x14*/ int height;
        /*0x18*/ float topY;
        /*0x1c*/ float leading;
    }

    struct UIVertex
    {
        static /*0x0*/ UnityEngine.Color32 s_DefaultColor;
        static /*0x4*/ UnityEngine.Vector4 s_DefaultTangent;
        static /*0x14*/ UnityEngine.UIVertex simpleVert;
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ UnityEngine.Vector3 normal;
        /*0x28*/ UnityEngine.Vector4 tangent;
        /*0x38*/ UnityEngine.Color32 color;
        /*0x3c*/ UnityEngine.Vector4 uv0;
        /*0x4c*/ UnityEngine.Vector4 uv1;
        /*0x5c*/ UnityEngine.Vector4 uv2;
        /*0x6c*/ UnityEngine.Vector4 uv3;

        static /*0x3ee1124*/ UIVertex();
    }

    class Font : UnityEngine.Object
    {
        static /*0x0*/ System.Action<UnityEngine.Font> textureRebuilt;
        /*0x18*/ UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

        static /*0x3ee1294*/ void add_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x3ee1360*/ void remove_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x3ee1874*/ void InvokeTextureRebuilt_Internal(UnityEngine.Font font);
        static /*0x3ee19cc*/ string[] GetOSFallbacks();
        static /*0x3ee1704*/ void Internal_CreateFont(UnityEngine.Font self, string name);
        static /*0x3ee14c0*/ nint get_material_Injected(nint _unity_self);
        static /*0x3ee14fc*/ bool get_dynamic_Injected(nint _unity_self);
        static /*0x3ee15b0*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x3ee1664*/ int get_lineHeight_Injected(nint _unity_self);
        static /*0x3ee1988*/ bool HasCharacter_Injected(nint _unity_self, int c);
        static /*0x3ee19f4*/ void Internal_CreateFont_Injected(UnityEngine.Font self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3ee1ae0*/ bool GetCharacterInfo_Injected(nint _unity_self, char ch, ref UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style);
        /*0x3ee16a0*/ Font();
        /*0x3ee142c*/ UnityEngine.Material get_material();
        /*0x3ededa0*/ bool get_dynamic();
        /*0x3ee1538*/ int get_fontSize();
        /*0x3ee15ec*/ int get_lineHeight();
        /*0x3ee1900*/ bool HasCharacter(char c);
        /*0x3ee1908*/ bool HasCharacter(int c);
        /*0x3ee1a38*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style);

        class FontTextureRebuildCallback : System.MulticastDelegate
        {
            /*0x3ee1b4c*/ FontTextureRebuildCallback(object object, nint method);
            /*0x3ee1be8*/ void Invoke();
        }
    }
}
