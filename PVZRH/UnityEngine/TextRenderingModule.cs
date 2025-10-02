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

        /*0x169b0a0*/ bool CompareColors(UnityEngine.Color left, UnityEngine.Color right);
        /*0x169b120*/ bool CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right);
        /*0x169b170*/ bool Equals(UnityEngine.TextGenerationSettings other);
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

        static /*0x169b710*/ nint Internal_Create();
        static /*0x169b740*/ void Internal_Destroy(nint ptr);
        /*0x169cad0*/ TextGenerator();
        /*0x169c970*/ TextGenerator(int initialCapacity);
        /*0x169b3f0*/ void Finalize();
        /*0x169c5f0*/ void System.IDisposable.Dispose();
        /*0x169cc20*/ int get_characterCountVisible();
        /*0x169c650*/ UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings);
        /*0x169b780*/ void Invalidate();
        /*0x169b4d0*/ void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters);
        /*0x169b520*/ void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines);
        /*0x169b6c0*/ void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x169b610*/ float GetPreferredWidth(string str, UnityEngine.TextGenerationSettings settings);
        /*0x169b570*/ float GetPreferredHeight(string str, UnityEngine.TextGenerationSettings settings);
        /*0x169bf30*/ bool PopulateWithErrors(string str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context);
        /*0x169c590*/ bool Populate(string str, UnityEngine.TextGenerationSettings settings);
        /*0x169bb10*/ UnityEngine.TextGenerationError PopulateWithError(string str, UnityEngine.TextGenerationSettings settings);
        /*0x169b790*/ UnityEngine.TextGenerationError PopulateAlways(string str, UnityEngine.TextGenerationSettings settings);
        /*0x169ce60*/ System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts();
        /*0x169cca0*/ System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters();
        /*0x169cd50*/ System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines();
        /*0x169ce10*/ UnityEngine.Rect get_rectExtents();
        /*0x169cc60*/ int get_characterCount();
        /*0x169cd10*/ int get_lineCount();
        /*0x169c410*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        /*0x169c210*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, ref UnityEngine.TextGenerationError error);
        /*0x169b6c0*/ void GetVerticesInternal(object vertices);
        /*0x169b4d0*/ void GetCharactersInternal(object characters);
        /*0x169b520*/ void GetLinesInternal(object lines);
        /*0x169cdc0*/ void get_rectExtents_Injected(ref UnityEngine.Rect ret);
        /*0x169c150*/ bool Populate_Internal_Injected(string str, UnityEngine.Font font, ref UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
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

        static /*0x169ced0*/ UIVertex();
    }

    class Font : UnityEngine.Object
    {
        static /*0x0*/ System.Action<UnityEngine.Font> textureRebuilt;
        /*0x18*/ UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

        static /*0x169ae20*/ void add_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x169afc0*/ void remove_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x169ad30*/ void InvokeTextureRebuilt_Internal(UnityEngine.Font font);
        static /*0x169ace0*/ void Internal_CreateFont(UnityEngine.Font self, string name);
        /*0x169adb0*/ Font();
        /*0x169af80*/ UnityEngine.Material get_material();
        /*0x169af00*/ bool get_dynamic();
        /*0x169af40*/ int get_fontSize();
        /*0x169ac50*/ bool HasCharacter(char c);
        /*0x169aca0*/ bool HasCharacter(int c);

        class FontTextureRebuildCallback : System.MulticastDelegate
        {
            /*0xe25c50*/ FontTextureRebuildCallback(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }
    }
}
