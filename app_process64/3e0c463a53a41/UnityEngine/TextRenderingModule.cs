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

        /*0x7fb18a0*/ bool CompareColors(UnityEngine.Color left, UnityEngine.Color right);
        /*0x7fb19d8*/ bool CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right);
        /*0x7fb1aa0*/ bool Equals(UnityEngine.TextGenerationSettings other);
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

        static /*0x7fb1e34*/ nint Internal_Create();
        static /*0x7fb1fb8*/ void Internal_Destroy(nint ptr);
        static /*0x7fb2bdc*/ void get_rectExtents_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7fb2c20*/ int get_characterCount_Injected(nint _unity_self);
        static /*0x7fb2cac*/ int get_lineCount_Injected(nint _unity_self);
        static /*0x7fb2f98*/ bool Populate_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper str, nint font, ref UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        static /*0x7fb30c8*/ void GetVerticesInternal_Injected(nint _unity_self, object vertices);
        static /*0x7fb310c*/ void GetCharactersInternal_Injected(nint _unity_self, object characters);
        static /*0x7fb3150*/ void GetLinesInternal_Injected(nint _unity_self, object lines);
        /*0x7fb1cc0*/ TextGenerator();
        /*0x7fb1cc8*/ TextGenerator(int initialCapacity);
        /*0x7fb1e5c*/ void Finalize();
        /*0x7fb1f6c*/ void System.IDisposable.Dispose();
        /*0x7fb1ff4*/ int get_characterCountVisible();
        /*0x7fb2058*/ UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings);
        /*0x7fb2384*/ void Invalidate();
        /*0x7fb238c*/ void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters);
        /*0x7fb23e8*/ void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines);
        /*0x7fb2444*/ void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x7fb24a0*/ float GetPreferredWidth(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fb25c0*/ float GetPreferredHeight(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fb2620*/ bool PopulateWithErrors(string str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context);
        /*0x7fb2504*/ bool Populate(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fb27f0*/ UnityEngine.TextGenerationError PopulateWithError(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fb2880*/ UnityEngine.TextGenerationError PopulateAlways(string str, UnityEngine.TextGenerationSettings settings);
        /*0x7fb2b4c*/ System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts();
        /*0x7fb2b7c*/ System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters();
        /*0x7fb2bac*/ System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines();
        /*0x7fb2554*/ UnityEngine.Rect get_rectExtents();
        /*0x7fb2008*/ int get_characterCount();
        /*0x7fb2c5c*/ int get_lineCount();
        /*0x7fb2ce8*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error);
        /*0x7fb29a0*/ bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, ref UnityEngine.TextGenerationError error);
        /*0x7fb2448*/ void GetVerticesInternal(object vertices);
        /*0x7fb2390*/ void GetCharactersInternal(object characters);
        /*0x7fb23ec*/ void GetLinesInternal(object lines);

        class BindingsMarshaller
        {
            static /*0x7fb3194*/ nint ConvertToNative(UnityEngine.TextGenerator textGenerator);
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

        static /*0x7fb31ac*/ UIVertex();
    }

    class Font : UnityEngine.Object
    {
        static /*0x0*/ System.Action<UnityEngine.Font> textureRebuilt;
        /*0x18*/ UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

        static /*0x7fb3320*/ void add_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x7fb33ec*/ void remove_textureRebuilt(System.Action<UnityEngine.Font> value);
        static /*0x7fb434c*/ UnityEngine.Font CreateDynamicFontFromOSFont(string fontname, int size);
        static /*0x7fb43fc*/ UnityEngine.Font CreateDynamicFontFromOSFont(string[] fontnames, int size);
        static /*0x7fb4464*/ void InvokeTextureRebuilt_Internal(UnityEngine.Font font);
        static /*0x7fb44f0*/ int GetMaxVertsForString(string str);
        static /*0x7fb4510*/ UnityEngine.Font GetDefault();
        static /*0x7fb4668*/ string[] GetOSInstalledFontNames();
        static /*0x7fb4690*/ string[] GetPathsToOSFonts();
        static /*0x7fb46b8*/ string[] GetOSFallbacks();
        static /*0x7fb3ea8*/ void Internal_CreateFont(UnityEngine.Font self, string name);
        static /*0x7fb40f0*/ void Internal_CreateFontFromPath(UnityEngine.Font self, string fontPath);
        static /*0x7fb42f8*/ void Internal_CreateDynamicFont(UnityEngine.Font self, string[] _names, int size);
        static /*0x7fb3684*/ nint get_material_Injected(nint _unity_self);
        static /*0x7fb3774*/ void set_material_Injected(nint _unity_self, nint value);
        static /*0x7fb3830*/ string[] get_fontNames_Injected(nint _unity_self);
        static /*0x7fb38ec*/ void set_fontNames_Injected(nint _unity_self, string[] value);
        static /*0x7fb3930*/ bool get_dynamic_Injected(nint _unity_self);
        static /*0x7fb39e4*/ int get_ascent_Injected(nint _unity_self);
        static /*0x7fb3a98*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x7fb3bfc*/ void get_characterInfo_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7fb3d3c*/ void set_characterInfo_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7fb3df8*/ int get_lineHeight_Injected(nint _unity_self);
        static /*0x7fb4574*/ nint GetDefault_Injected();
        static /*0x7fb4624*/ bool HasCharacter_Injected(nint _unity_self, int c);
        static /*0x7fb46e0*/ void Internal_CreateFont_Injected(UnityEngine.Font self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7fb4724*/ void Internal_CreateFontFromPath_Injected(UnityEngine.Font self, ref UnityEngine.Bindings.ManagedSpanWrapper fontPath);
        static /*0x7fb4810*/ bool GetCharacterInfo_Injected(nint _unity_self, char ch, ref UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style);
        static /*0x7fb4a48*/ void RequestCharactersInTexture_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper characters, int size, UnityEngine.FontStyle style);
        /*0x7fb3e44*/ Font();
        /*0x7fb4018*/ Font(string name);
        /*0x7fb4260*/ Font(string[] names, int size);
        /*0x7fb34b8*/ void add_m_FontTextureRebuildCallback(UnityEngine.Font.FontTextureRebuildCallback value);
        /*0x7fb3554*/ void remove_m_FontTextureRebuildCallback(UnityEngine.Font.FontTextureRebuildCallback value);
        /*0x7fb35f0*/ UnityEngine.Material get_material();
        /*0x7fb36c0*/ void set_material(UnityEngine.Material value);
        /*0x7fb37b8*/ string[] get_fontNames();
        /*0x7fb386c*/ void set_fontNames(string[] value);
        /*0x7fb230c*/ bool get_dynamic();
        /*0x7fb396c*/ int get_ascent();
        /*0x7fb3a20*/ int get_fontSize();
        /*0x7fb3ad4*/ UnityEngine.CharacterInfo[] get_characterInfo();
        /*0x7fb3c40*/ void set_characterInfo(UnityEngine.CharacterInfo[] value);
        /*0x7fb3d80*/ int get_lineHeight();
        /*0x7fb3e34*/ UnityEngine.Font.FontTextureRebuildCallback get_textureRebuildCallback();
        /*0x7fb3e3c*/ void set_textureRebuildCallback(UnityEngine.Font.FontTextureRebuildCallback value);
        /*0x7fb459c*/ bool HasCharacter(char c);
        /*0x7fb45a4*/ bool HasCharacter(int c);
        /*0x7fb4768*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style);
        /*0x7fb487c*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info, int size);
        /*0x7fb4884*/ bool GetCharacterInfo(char ch, ref UnityEngine.CharacterInfo info);
        /*0x7fb4890*/ void RequestCharactersInTexture(string characters, int size, UnityEngine.FontStyle style);
        /*0x7fb4aa4*/ void RequestCharactersInTexture(string characters, int size);
        /*0x7fb4aac*/ void RequestCharactersInTexture(string characters);

        class FontTextureRebuildCallback : System.MulticastDelegate
        {
            /*0x7fb4ab8*/ FontTextureRebuildCallback(object object, nint method);
            /*0x7fb4b54*/ void Invoke();
        }
    }
}
