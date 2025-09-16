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

        /*0x7fc8cd0*/ bool CompareColors(UnityEngine.Color left, UnityEngine.Color right);
        /*0x7fc8e08*/ bool CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right);
        /*0x7fc8ed0*/ bool Equals(UnityEngine.TextGenerationSettings other);
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

        static /*0x7fc9264*/ nint Internal_Create();
        static /*0x7fc93e8*/ void Internal_Destroy(nint ptr);
        static /*0x7fca00c*/ void get_rectExtents_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7fca050*/ int get_characterCount_Injected(nint _unity_self);
        static /*0x7fca0dc*/ int get_lineCount_Injected(nint _unity_self);
        static /*0x7fca3c8*/ bool Populate_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper str, nint font, ref UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        static /*0x7fca4f8*/ void GetVerticesInternal_Injected(nint _unity_self, object vertices);
        static /*0x7fca53c*/ void GetCharactersInternal_Injected(nint _unity_self, object characters);
        static /*0x7fca580*/ void GetLinesInternal_Injected(nint _unity_self, object lines);
        /*0x7fc90f0*/ TextGenerator();
        /*0x7fc90f8*/ TextGenerator(int initialCapacity);
        /*0x7fc928c*/ void Finalize();
        /*0x7fc939c*/ void System.IDisposable.Dispose();
        /*0x7fc9424*/ int get_characterCountVisible();
        /*0x7fc9488*/ UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings);
        /*0x7fc97b4*/ void Invalidate();
        /*0x7fc97bc*/ void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters);
        /*0x7fc9818*/ void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines);
        /*0x7fc9874*/ void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x7fc98d0*/ float GetPreferredWidth(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fc99f0*/ float GetPreferredHeight(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fc9a50*/ bool PopulateWithErrors(string str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context);
        /*0x7fc9934*/ bool Populate(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fc9c20*/ UnityEngine.TextGenerationError PopulateWithError(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fc9cb0*/ UnityEngine.TextGenerationError PopulateAlways(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fc9f7c*/ System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts();
        /*0x7fc9fac*/ System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters();
        /*0x7fc9fdc*/ System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines();
        /*0x7fc9984*/ UnityEngine.Rect get_rectExtents();
        /*0x7fc9438*/ int get_characterCount();
        /*0x7fca08c*/ int get_lineCount();
        /*0x7fca118*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        /*0x7fc9dd0*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, ref UnityEngine.TextGenerationError error);
        /*0x7fc9878*/ void GetVerticesInternal(object vertices);
        /*0x7fc97c0*/ void GetCharactersInternal(object characters);
        /*0x7fc981c*/ void GetLinesInternal(object lines);

        class BindingsMarshaller
        {
            static /*0x7fca5c4*/ nint ConvertToNative(UnityEngine.TextGenerator textGenerator);
        }
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

    struct CharacterInfo
    {
        /*0x10*/ int index;
        /*0x14*/ UnityEngine.Rect uv;
        /*0x24*/ UnityEngine.Rect vert;
        /*0x34*/ float width;
        /*0x38*/ int size;
        /*0x3c*/ UnityEngine.FontStyle style;
        /*0x40*/ bool flipped;
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

        static /*0x7fca5dc*/ UIVertex();
    }

    class Font : UnityEngine.Object
    {
        static /*0x0*/ System.Action<UnityEngine.Font> textureRebuilt;
        /*0x18*/ UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

        static /*0x7fca750*/ void add_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x7fca81c*/ void remove_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x7fcb77c*/ UnityEngine.Font CreateDynamicFontFromOSFont(string fontname, int size);
        static /*0x7fcb82c*/ UnityEngine.Font CreateDynamicFontFromOSFont(string[] fontnames, int size);
        static /*0x7fcb894*/ void InvokeTextureRebuilt_Internal(UnityEngine.Font font);
        static /*0x7fcb920*/ int GetMaxVertsForString(string str);
        static /*0x7fcb940*/ UnityEngine.Font GetDefault();
        static /*0x7fcba98*/ string[] GetOSInstalledFontNames();
        static /*0x7fcbac0*/ string[] GetPathsToOSFonts();
        static /*0x7fcbae8*/ string[] GetOSFallbacks();
        static /*0x7fcb2d8*/ void Internal_CreateFont(UnityEngine.Font self, string name);
        static /*0x7fcb520*/ void Internal_CreateFontFromPath(UnityEngine.Font self, string fontPath);
        static /*0x7fcb728*/ void Internal_CreateDynamicFont(UnityEngine.Font self, string[] _names, int size);
        static /*0x7fcaab4*/ nint get_material_Injected(nint _unity_self);
        static /*0x7fcaba4*/ void set_material_Injected(nint _unity_self, nint value);
        static /*0x7fcac60*/ string[] get_fontNames_Injected(nint _unity_self);
        static /*0x7fcad1c*/ void set_fontNames_Injected(nint _unity_self, string[] value);
        static /*0x7fcad60*/ bool get_dynamic_Injected(nint _unity_self);
        static /*0x7fcae14*/ int get_ascent_Injected(nint _unity_self);
        static /*0x7fcaec8*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x7fcb02c*/ void get_characterInfo_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7fcb16c*/ void set_characterInfo_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7fcb228*/ int get_lineHeight_Injected(nint _unity_self);
        static /*0x7fcb9a4*/ nint GetDefault_Injected();
        static /*0x7fcba54*/ bool HasCharacter_Injected(nint _unity_self, int c);
        static /*0x7fcbb10*/ void Internal_CreateFont_Injected(UnityEngine.Font self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7fcbb54*/ void Internal_CreateFontFromPath_Injected(UnityEngine.Font self, ref UnityEngine.Bindings.ManagedSpanWrapper fontPath);
        static /*0x7fcbc40*/ bool GetCharacterInfo_Injected(nint _unity_self, char ch, ref UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style);
        static /*0x7fcbe78*/ void RequestCharactersInTexture_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper characters, int size, UnityEngine.FontStyle style);
        /*0x7fcb274*/ Font();
        /*0x7fcb448*/ Font(string name);
        /*0x7fcb690*/ Font(string[] names, int size);
        /*0x7fca8e8*/ void add_m_FontTextureRebuildCallback(UnityEngine.Font.FontTextureRebuildCallback value);
        /*0x7fca984*/ void remove_m_FontTextureRebuildCallback(UnityEngine.Font.FontTextureRebuildCallback value);
        /*0x7fcaa20*/ UnityEngine.Material get_material();
        /*0x7fcaaf0*/ void set_material(UnityEngine.Material value);
        /*0x7fcabe8*/ string[] get_fontNames();
        /*0x7fcac9c*/ void set_fontNames(string[] value);
        /*0x7fc973c*/ bool get_dynamic();
        /*0x7fcad9c*/ int get_ascent();
        /*0x7fcae50*/ int get_fontSize();
        /*0x7fcaf04*/ UnityEngine.CharacterInfo[] get_characterInfo();
        /*0x7fcb070*/ void set_characterInfo(UnityEngine.CharacterInfo[] value);
        /*0x7fcb1b0*/ int get_lineHeight();
        /*0x7fcb264*/ UnityEngine.Font.FontTextureRebuildCallback get_textureRebuildCallback();
        /*0x7fcb26c*/ void set_textureRebuildCallback(UnityEngine.Font.FontTextureRebuildCallback value);
        /*0x7fcb9cc*/ bool HasCharacter(char c);
        /*0x7fcb9d4*/ bool HasCharacter(int c);
        /*0x7fcbb98*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style);
        /*0x7fcbcac*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info, int size);
        /*0x7fcbcb4*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info);
        /*0x7fcbcc0*/ void RequestCharactersInTexture(string characters, int size, UnityEngine.FontStyle style);
        /*0x7fcbed4*/ void RequestCharactersInTexture(string characters, int size);
        /*0x7fcbedc*/ void RequestCharactersInTexture(string characters);

        class FontTextureRebuildCallback : System.MulticastDelegate
        {
            /*0x7fcbee8*/ FontTextureRebuildCallback(object object, nint method);
            /*0x7fcbf84*/ void Invoke();
        }
    }
}
