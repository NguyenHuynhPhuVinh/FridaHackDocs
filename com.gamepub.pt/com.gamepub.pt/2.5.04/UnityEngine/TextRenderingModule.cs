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

        /*0xb4b00c*/ bool CompareColors(UnityEngine.Color left, UnityEngine.Color right);
        /*0xb4b010*/ bool CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right);
        /*0xb4b014*/ bool Equals(UnityEngine.TextGenerationSettings other);
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

        static /*0x2b18c20*/ nint Internal_Create();
        static /*0x2b18dc8*/ void Internal_Destroy(nint ptr);
        /*0x2b18ad8*/ TextGenerator();
        /*0x2b18ae0*/ TextGenerator(int initialCapacity);
        /*0x2b18c54*/ void Finalize();
        /*0x2b18d40*/ void System.IDisposable.Dispose();
        /*0x2b18e08*/ int get_characterCountVisible();
        /*0x2b18e90*/ UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings);
        /*0x2b19184*/ void Invalidate();
        /*0x2b1918c*/ void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters);
        /*0x2b1922c*/ void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines);
        /*0x2b192cc*/ void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x2b1936c*/ float GetPreferredWidth(string str, UnityEngine.TextGenerationSettings settings);
        /*0x2b19494*/ float GetPreferredHeight(string str, UnityEngine.TextGenerationSettings settings);
        /*0x2b19508*/ bool PopulateWithErrors(string str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context);
        /*0x2b193e4*/ bool Populate(string str, UnityEngine.TextGenerationSettings settings);
        /*0x2b196e4*/ UnityEngine.TextGenerationError PopulateWithError(string str, UnityEngine.TextGenerationSettings settings);
        /*0x2b19780*/ UnityEngine.TextGenerationError PopulateAlways(string str, UnityEngine.TextGenerationSettings settings);
        /*0x2b19a50*/ System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts();
        /*0x2b19ab8*/ System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters();
        /*0x2b19b20*/ System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines();
        /*0x2b19438*/ UnityEngine.Rect get_rectExtents();
        /*0x2b18e50*/ int get_characterCount();
        /*0x2b19bd8*/ int get_lineCount();
        /*0x2b19c18*/ int get_fontSizeUsedForBestFit();
        /*0x2b19c58*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        /*0x2b1989c*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, ref UnityEngine.TextGenerationError error);
        /*0x2b1931c*/ void GetVerticesInternal(object vertices);
        /*0x2b191dc*/ void GetCharactersInternal(object characters);
        /*0x2b1927c*/ void GetLinesInternal(object lines);
        /*0x2b19b88*/ void get_rectExtents_Injected(ref UnityEngine.Rect ret);
        /*0x2b19da8*/ bool Populate_Internal_Injected(string str, UnityEngine.Font font, ref UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
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

        static /*0x2b19ee0*/ UIVertex();
    }

    class Font : UnityEngine.Object
    {
        static /*0x0*/ System.Action<UnityEngine.Font> textureRebuilt;
        /*0x18*/ UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

        static /*0x2b181bc*/ void add_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x2b18278*/ void remove_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x2b184d4*/ void InvokeTextureRebuilt_Internal(UnityEngine.Font font);
        static /*0x2b18484*/ void Internal_CreateFont(UnityEngine.Font self, string name);
        /*0x2b183f4*/ Font();
        /*0x2b18334*/ UnityEngine.Material get_material();
        /*0x2b18374*/ bool get_dynamic();
        /*0x2b183b4*/ int get_fontSize();
        /*0x2b18770*/ bool HasCharacter(char c);
        /*0x2b187c0*/ bool HasCharacter(int c);

        class FontTextureRebuildCallback : System.MulticastDelegate
        {
            /*0x2b1a0a8*/ FontTextureRebuildCallback(object object, nint method);
            /*0x2b18564*/ void Invoke();
            /*0x2b1a108*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2b1a134*/ void EndInvoke(System.IAsyncResult result);
        }
    }
}
