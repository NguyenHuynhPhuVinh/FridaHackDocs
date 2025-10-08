class <Module>
{
}

namespace System
{
    namespace Numerics
    {
        namespace Hashing
        {
            class HashHelpers
            {
                static /*0x0*/ int RandomSeed;

                static /*0x37d68d4*/ HashHelpers();
                static /*0x37d68c4*/ int Combine(int h1, int h2);
            }
        }
    }

    namespace Drawing
    {
        enum KnownColor
        {
            ActiveBorder = 1,
            ActiveCaption = 2,
            ActiveCaptionText = 3,
            AppWorkspace = 4,
            Control = 5,
            ControlDark = 6,
            ControlDarkDark = 7,
            ControlLight = 8,
            ControlLightLight = 9,
            ControlText = 10,
            Desktop = 11,
            GrayText = 12,
            Highlight = 13,
            HighlightText = 14,
            HotTrack = 15,
            InactiveBorder = 16,
            InactiveCaption = 17,
            InactiveCaptionText = 18,
            Info = 19,
            InfoText = 20,
            Menu = 21,
            MenuText = 22,
            ScrollBar = 23,
            Window = 24,
            WindowFrame = 25,
            WindowText = 26,
            Transparent = 27,
            AliceBlue = 28,
            AntiqueWhite = 29,
            Aqua = 30,
            Aquamarine = 31,
            Azure = 32,
            Beige = 33,
            Bisque = 34,
            Black = 35,
            BlanchedAlmond = 36,
            Blue = 37,
            BlueViolet = 38,
            Brown = 39,
            BurlyWood = 40,
            CadetBlue = 41,
            Chartreuse = 42,
            Chocolate = 43,
            Coral = 44,
            CornflowerBlue = 45,
            Cornsilk = 46,
            Crimson = 47,
            Cyan = 48,
            DarkBlue = 49,
            DarkCyan = 50,
            DarkGoldenrod = 51,
            DarkGray = 52,
            DarkGreen = 53,
            DarkKhaki = 54,
            DarkMagenta = 55,
            DarkOliveGreen = 56,
            DarkOrange = 57,
            DarkOrchid = 58,
            DarkRed = 59,
            DarkSalmon = 60,
            DarkSeaGreen = 61,
            DarkSlateBlue = 62,
            DarkSlateGray = 63,
            DarkTurquoise = 64,
            DarkViolet = 65,
            DeepPink = 66,
            DeepSkyBlue = 67,
            DimGray = 68,
            DodgerBlue = 69,
            Firebrick = 70,
            FloralWhite = 71,
            ForestGreen = 72,
            Fuchsia = 73,
            Gainsboro = 74,
            GhostWhite = 75,
            Gold = 76,
            Goldenrod = 77,
            Gray = 78,
            Green = 79,
            GreenYellow = 80,
            Honeydew = 81,
            HotPink = 82,
            IndianRed = 83,
            Indigo = 84,
            Ivory = 85,
            Khaki = 86,
            Lavender = 87,
            LavenderBlush = 88,
            LawnGreen = 89,
            LemonChiffon = 90,
            LightBlue = 91,
            LightCoral = 92,
            LightCyan = 93,
            LightGoldenrodYellow = 94,
            LightGray = 95,
            LightGreen = 96,
            LightPink = 97,
            LightSalmon = 98,
            LightSeaGreen = 99,
            LightSkyBlue = 100,
            LightSlateGray = 101,
            LightSteelBlue = 102,
            LightYellow = 103,
            Lime = 104,
            LimeGreen = 105,
            Linen = 106,
            Magenta = 107,
            Maroon = 108,
            MediumAquamarine = 109,
            MediumBlue = 110,
            MediumOrchid = 111,
            MediumPurple = 112,
            MediumSeaGreen = 113,
            MediumSlateBlue = 114,
            MediumSpringGreen = 115,
            MediumTurquoise = 116,
            MediumVioletRed = 117,
            MidnightBlue = 118,
            MintCream = 119,
            MistyRose = 120,
            Moccasin = 121,
            NavajoWhite = 122,
            Navy = 123,
            OldLace = 124,
            Olive = 125,
            OliveDrab = 126,
            Orange = 127,
            OrangeRed = 128,
            Orchid = 129,
            PaleGoldenrod = 130,
            PaleGreen = 131,
            PaleTurquoise = 132,
            PaleVioletRed = 133,
            PapayaWhip = 134,
            PeachPuff = 135,
            Peru = 136,
            Pink = 137,
            Plum = 138,
            PowderBlue = 139,
            Purple = 140,
            Red = 141,
            RosyBrown = 142,
            RoyalBlue = 143,
            SaddleBrown = 144,
            Salmon = 145,
            SandyBrown = 146,
            SeaGreen = 147,
            SeaShell = 148,
            Sienna = 149,
            Silver = 150,
            SkyBlue = 151,
            SlateBlue = 152,
            SlateGray = 153,
            Snow = 154,
            SpringGreen = 155,
            SteelBlue = 156,
            Tan = 157,
            Teal = 158,
            Thistle = 159,
            Tomato = 160,
            Turquoise = 161,
            Violet = 162,
            Wheat = 163,
            White = 164,
            WhiteSmoke = 165,
            Yellow = 166,
            YellowGreen = 167,
            ButtonFace = 168,
            ButtonHighlight = 169,
            ButtonShadow = 170,
            GradientActiveCaption = 171,
            GradientInactiveCaption = 172,
            MenuBar = 173,
            MenuHighlight = 174,
        }

        class KnownColorTable
        {
            static /*0x0*/ int[] s_colorTable;
            static /*0x8*/ string[] s_colorNameTable;

            static /*0x37d6940*/ void EnsureColorTable();
            static /*0x37d6998*/ void InitColorTable();
            static /*0x37d7588*/ void EnsureColorNameTable();
            static /*0x37d75e0*/ void InitColorNameTable();
            static /*0x37d9768*/ int KnownColorToArgb(System.Drawing.KnownColor color);
            static /*0x37d97d8*/ string KnownColorToName(System.Drawing.KnownColor color);
            static /*0x37d7454*/ void UpdateSystemColors(int[] colorTable);
        }

        struct Color : System.IEquatable<System.Drawing.Color>
        {
            /*0x10*/ string name;
            /*0x18*/ long value;
            /*0x20*/ short knownColor;
            /*0x22*/ short state;

            static /*0x37d9c2c*/ bool op_Equality(System.Drawing.Color left, System.Drawing.Color right);
            /*0x37d9848*/ byte get_R();
            /*0x37d9890*/ byte get_G();
            /*0x37d98a4*/ byte get_B();
            /*0x37d98b4*/ byte get_A();
            /*0x37d98c8*/ bool get_IsKnownColor();
            /*0x37d98d4*/ string get_Name();
            /*0x37d985c*/ long get_Value();
            /*0x37d9960*/ string ToString();
            /*0x37d9c74*/ bool Equals(object obj);
            /*0x37d9d04*/ bool Equals(System.Drawing.Color other);
            /*0x37d9d4c*/ int GetHashCode();
        }

        struct Point : System.IEquatable<System.Drawing.Point>
        {
            /*0x10*/ int x;
            /*0x14*/ int y;

            static /*0x37d9e28*/ bool op_Equality(System.Drawing.Point left, System.Drawing.Point right);
            /*0x37d9e18*/ int get_X();
            /*0x37d9e20*/ int get_Y();
            /*0x37d9e34*/ bool Equals(object obj);
            /*0x37d9eac*/ bool Equals(System.Drawing.Point other);
            /*0x37d9ebc*/ int GetHashCode();
            /*0x37d9f1c*/ string ToString();
        }

        struct PointF : System.IEquatable<System.Drawing.PointF>
        {
            /*0x10*/ float x;
            /*0x14*/ float y;

            static /*0x37da09c*/ bool op_Equality(System.Drawing.PointF left, System.Drawing.PointF right);
            /*0x37da08c*/ float get_X();
            /*0x37da094*/ float get_Y();
            /*0x37da0ac*/ bool Equals(object obj);
            /*0x37da134*/ bool Equals(System.Drawing.PointF other);
            /*0x37da14c*/ int GetHashCode();
            /*0x37da1e4*/ string ToString();
        }

        struct Rectangle : System.IEquatable<System.Drawing.Rectangle>
        {
            /*0x10*/ int x;
            /*0x14*/ int y;
            /*0x18*/ int width;
            /*0x1c*/ int height;

            static /*0x37da428*/ bool op_Equality(System.Drawing.Rectangle left, System.Drawing.Rectangle right);
            /*0x37da334*/ int get_X();
            /*0x37da33c*/ int get_Y();
            /*0x37da344*/ int get_Width();
            /*0x37da34c*/ int get_Height();
            /*0x37da354*/ bool Equals(object obj);
            /*0x37da3f4*/ bool Equals(System.Drawing.Rectangle other);
            /*0x37da450*/ int GetHashCode();
            /*0x37da4cc*/ string ToString();
        }

        struct RectangleF : System.IEquatable<System.Drawing.RectangleF>
        {
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float width;
            /*0x1c*/ float height;

            static /*0x37da80c*/ bool op_Equality(System.Drawing.RectangleF left, System.Drawing.RectangleF right);
            /*0x37da70c*/ float get_X();
            /*0x37da714*/ float get_Y();
            /*0x37da71c*/ float get_Width();
            /*0x37da724*/ float get_Height();
            /*0x37da72c*/ bool Equals(object obj);
            /*0x37da7dc*/ bool Equals(System.Drawing.RectangleF other);
            /*0x37da834*/ int GetHashCode();
            /*0x37da90c*/ string ToString();
        }

        struct Size : System.IEquatable<System.Drawing.Size>
        {
            /*0x10*/ int width;
            /*0x14*/ int height;

            static /*0x37dab4c*/ bool op_Equality(System.Drawing.Size sz1, System.Drawing.Size sz2);
            /*0x37dab58*/ int get_Width();
            /*0x37dab60*/ int get_Height();
            /*0x37dab68*/ bool Equals(object obj);
            /*0x37dabe0*/ bool Equals(System.Drawing.Size other);
            /*0x37dabf0*/ int GetHashCode();
            /*0x37dac50*/ string ToString();
        }

        struct SizeF : System.IEquatable<System.Drawing.SizeF>
        {
            /*0x10*/ float width;
            /*0x14*/ float height;

            static /*0x37dada0*/ bool op_Equality(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2);
            /*0x37dadb0*/ float get_Width();
            /*0x37dadb8*/ float get_Height();
            /*0x37dadc0*/ bool Equals(object obj);
            /*0x37dae48*/ bool Equals(System.Drawing.SizeF other);
            /*0x37dae60*/ int GetHashCode();
            /*0x37daef8*/ string ToString();
        }
    }
}
