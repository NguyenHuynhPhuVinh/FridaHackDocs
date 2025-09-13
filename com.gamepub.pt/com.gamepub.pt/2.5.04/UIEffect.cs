class <Module>
{
}

class Packer
{
    static /*0x2a18db8*/ float ToFloat(float x, float y, float z, float w);
    static /*0x2a18ec0*/ float ToFloat(UnityEngine.Vector4 factor);
    static /*0x2a18f34*/ float ToFloat(float x, float y, float z);
    static /*0x2a19000*/ float ToFloat(float x, float y);
}

namespace Coffee
{
    namespace UIEffects
    {
        class BaseMaterialEffect : Coffee.UIEffects.BaseMeshEffect, Coffee.UIEffects.IParameterTexture, UnityEngine.UI.IMaterialModifier
        {
            static /*0x0*/ UnityEngine.Hash128 k_InvalidHash;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.UIVertex> s_TempVerts;
            static /*0x18*/ System.Text.StringBuilder s_StringBuilder;
            /*0x38*/ UnityEngine.Hash128 _effectMaterialHash;
            /*0x48*/ int <parameterIndex>k__BackingField;

            static /*0x2a17378*/ BaseMaterialEffect();
            /*0x2a172f8*/ BaseMaterialEffect();
            /*0x2a160cc*/ int get_parameterIndex();
            /*0x2a160d4*/ void set_parameterIndex(int value);
            /*0x2a160dc*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a160e4*/ void SetMaterialDirty();
            /*0x2a16340*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material baseMaterial);
            /*0x2a163a4*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x2a163e0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a16838*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a16960*/ void SetShaderVariants(UnityEngine.Material newMaterial, object[] variants);
            /*0x2a16d9c*/ void OnEnable();
            /*0x2a16fe4*/ void OnDisable();

            class <>c
            {
                static /*0x0*/ Coffee.UIEffects.BaseMaterialEffect.<> <>9;
                static /*0x8*/ System.Func<object, bool> <>9__15_0;
                static /*0x10*/ System.Func<object, string> <>9__15_1;

                static /*0x2a206d8*/ <>c();
                /*0x2a20738*/ <>c();
                /*0x2a20740*/ bool <SetShaderVariants>b__15_0(object x);
                /*0x2a207bc*/ string <SetShaderVariants>b__15_1(object x);
            }
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x18*/ UnityEngine.RectTransform _rectTransform;
            /*0x20*/ UnityEngine.UI.Graphic _graphic;
            /*0x28*/ Coffee.UIEffects.GraphicConnector _connector;
            /*0x30*/ System.Collections.Generic.List<Coffee.UIEffects.UISyncEffect> syncEffects;

            /*0x2a172fc*/ BaseMeshEffect();
            /*0x2a16224*/ Coffee.UIEffects.GraphicConnector get_connector();
            /*0x2a162a4*/ UnityEngine.UI.Graphic get_graphic();
            /*0x2a1772c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x2a177c8*/ void ModifyMesh(UnityEngine.Mesh mesh);
            /*0x2a177cc*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
            /*0x2a17808*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a1780c*/ void SetVerticesDirty();
            /*0x2a16e10*/ void OnEnable();
            /*0x2a170e0*/ void OnDisable();
            /*0x2a17958*/ void SetEffectParamsDirty();
            /*0x2a1799c*/ void OnDidApplyAnimationProperties();
        }

        class EffectPlayer
        {
            static /*0x0*/ System.Collections.Generic.List<System.Action> s_UpdateActions;
            /*0x10*/ bool play;
            /*0x14*/ float initialPlayDelay;
            /*0x18*/ float duration;
            /*0x1c*/ bool loop;
            /*0x20*/ float loopDelay;
            /*0x24*/ UnityEngine.AnimatorUpdateMode updateMode;
            /*0x28*/ float _time;
            /*0x30*/ System.Action<float> _callback;

            /*0x2a184d8*/ EffectPlayer();
            /*0x2a1809c*/ void OnEnable(System.Action<float> callback);
            /*0x2a182a0*/ void OnDisable();
            /*0x2a18368*/ void Play(bool reset, System.Action<float> callback);
            /*0x2a18384*/ void Stop(bool reset);
            /*0x2a183f4*/ void OnWillRenderCanvases();

            class <>c
            {
                static /*0x0*/ Coffee.UIEffects.EffectPlayer.<> <>9;
                static /*0x8*/ UnityEngine.Canvas.WillRenderCanvases <>9__7_0;

                static /*0x2a207ec*/ <>c();
                /*0x2a2084c*/ <>c();
                /*0x2a20854*/ void <OnEnable>b__7_0();
            }
        }

        class GraphicConnector
        {
            static /*0x0*/ System.Collections.Generic.List<Coffee.UIEffects.GraphicConnector> s_Connectors;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, Coffee.UIEffects.GraphicConnector> s_ConnectorMap;
            static /*0x10*/ Coffee.UIEffects.GraphicConnector s_EmptyConnector;

            static /*0x2a18a7c*/ GraphicConnector();
            static /*0x2a184e8*/ void Init();
            static /*0x2a18560*/ void AddConnector(Coffee.UIEffects.GraphicConnector connector);
            static /*0x2a17440*/ Coffee.UIEffects.GraphicConnector FindConnector(UnityEngine.UI.Graphic graphic);
            /*0x2a18558*/ GraphicConnector();
            /*0x2a186e8*/ int get_priority();
            /*0x2a186f0*/ UnityEngine.AdditionalCanvasShaderChannels get_extraChannel();
            /*0x2a186f8*/ bool IsValid(UnityEngine.UI.Graphic graphic);
            /*0x2a18700*/ UnityEngine.Shader FindShader(string shaderName);
            /*0x2a18758*/ void OnEnable(UnityEngine.UI.Graphic graphic);
            /*0x2a1875c*/ void OnDisable(UnityEngine.UI.Graphic graphic);
            /*0x2a18760*/ void SetVerticesDirty(UnityEngine.UI.Graphic graphic);
            /*0x2a187f0*/ void SetMaterialDirty(UnityEngine.UI.Graphic graphic);
            /*0x2a18880*/ void GetPositionFactor(Coffee.UIEffects.EffectArea area, int index, UnityEngine.Rect rect, UnityEngine.Vector2 position, ref float x, ref float y);
            /*0x2a18964*/ bool IsText(UnityEngine.UI.Graphic graphic);
            /*0x2a18a1c*/ void SetExtraChannel(ref UnityEngine.UIVertex vertex, UnityEngine.Vector2 value);
            /*0x2a18a48*/ void GetNormalizedFactor(Coffee.UIEffects.EffectArea area, int index, Coffee.UIEffects.Matrix2x3 matrix, UnityEngine.Vector2 position, ref UnityEngine.Vector2 normalizedPos);

            class <>c
            {
                static /*0x0*/ Coffee.UIEffects.GraphicConnector.<> <>9;
                static /*0x8*/ System.Comparison<Coffee.UIEffects.GraphicConnector> <>9__4_0;

                static /*0x2a20920*/ <>c();
                /*0x2a20980*/ <>c();
                /*0x2a20988*/ int <AddConnector>b__4_0(Coffee.UIEffects.GraphicConnector x, Coffee.UIEffects.GraphicConnector y);
            }
        }

        class MaterialCache
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, Coffee.UIEffects.MaterialCache.MaterialEntry> materialMap;

            static /*0x2a18c20*/ MaterialCache();
            static /*0x2a16540*/ UnityEngine.Material Register(UnityEngine.Material baseMaterial, UnityEngine.Hash128 hash, System.Action<UnityEngine.Material, UnityEngine.UI.Graphic> onModifyMaterial, UnityEngine.UI.Graphic graphic);
            static /*0x2a1671c*/ void Unregister(UnityEngine.Hash128 hash);
            /*0x2a18c18*/ MaterialCache();

            class MaterialEntry
            {
                /*0x10*/ UnityEngine.Material material;
                /*0x18*/ int referenceCount;

                /*0x2a18b68*/ MaterialEntry();
                /*0x2a18b70*/ void Release();
            }
        }

        struct Matrix2x3
        {
            /*0x10*/ float m00;
            /*0x14*/ float m01;
            /*0x18*/ float m02;
            /*0x1c*/ float m10;
            /*0x20*/ float m11;
            /*0x24*/ float m12;

            static /*0x2a17f54*/ UnityEngine.Vector2 op_Multiply(Coffee.UIEffects.Matrix2x3 m, UnityEngine.Vector2 v);
            /*0xb1eeb8*/ Matrix2x3(UnityEngine.Rect rect, float cos, float sin);
        }

        interface IParameterTexture
        {
            int get_parameterIndex();
            void set_parameterIndex(int value);
            Coffee.UIEffects.ParameterTexture get_paramTex();
        }

        class ParameterTexture
        {
            static /*0x0*/ System.Collections.Generic.List<System.Action> updates;
            /*0x10*/ UnityEngine.Texture2D _texture;
            /*0x18*/ bool _needUpload;
            /*0x1c*/ int _propertyId;
            /*0x20*/ string _propertyName;
            /*0x28*/ int _channels;
            /*0x2c*/ int _instanceLimit;
            /*0x30*/ byte[] _data;
            /*0x38*/ System.Collections.Generic.Stack<int> _stack;

            /*0x2a1908c*/ ParameterTexture(int channels, int instanceLimit, string propertyName);
            /*0x2a16e68*/ void Register(Coffee.UIEffects.IParameterTexture target);
            /*0x2a17138*/ void Unregister(Coffee.UIEffects.IParameterTexture target);
            /*0x2a19494*/ void SetData(Coffee.UIEffects.IParameterTexture target, int channelId, byte value);
            /*0x2a19610*/ void SetData(Coffee.UIEffects.IParameterTexture target, int channelId, float value);
            /*0x2a168a8*/ void RegisterMaterial(UnityEngine.Material mat);
            /*0x2a19668*/ float GetNormalizedIndex(Coffee.UIEffects.IParameterTexture target);
            /*0x2a191e0*/ void Initialize();
            /*0x2a19738*/ void UpdateParameterTexture();

            class <>c
            {
                static /*0x0*/ Coffee.UIEffects.ParameterTexture.<> <>9;
                static /*0x8*/ UnityEngine.Canvas.WillRenderCanvases <>9__16_0;

                static /*0x2a209d8*/ <>c();
                /*0x2a20a38*/ <>c();
                /*0x2a20a40*/ void <Initialize>b__16_0();
            }
        }

        enum BlurMode
        {
            None = 0,
            FastBlur = 1,
            MediumBlur = 2,
            DetailBlur = 3,
        }

        enum ColorMode
        {
            Multiply = 0,
            Fill = 1,
            Add = 2,
            Subtract = 3,
        }

        enum EffectArea
        {
            RectTransform = 0,
            Fit = 1,
            Character = 2,
        }

        class EffectAreaExtensions
        {
            static /*0x0*/ UnityEngine.Rect rectForCharacter;
            static /*0x10*/ UnityEngine.Vector2[] splitedCharacterPosition;

            static /*0x2a17f84*/ EffectAreaExtensions();
            static /*0x2a179e0*/ UnityEngine.Rect GetEffectArea(Coffee.UIEffects.EffectArea area, UnityEngine.UI.VertexHelper vh, UnityEngine.Rect rectangle, float aspectRatio);
            static /*0x2a17c28*/ void GetPositionFactor(Coffee.UIEffects.EffectArea area, int index, UnityEngine.Rect rect, UnityEngine.Vector2 position, bool isText, bool isTMPro, ref float x, ref float y);
            static /*0x2a17e0c*/ void GetNormalizedFactor(Coffee.UIEffects.EffectArea area, int index, Coffee.UIEffects.Matrix2x3 matrix, UnityEngine.Vector2 position, bool isText, ref UnityEngine.Vector2 nomalizedPos);
        }

        enum EffectMode
        {
            None = 0,
            Grayscale = 1,
            Sepia = 2,
            Nega = 3,
            Pixel = 4,
        }

        enum ShadowStyle
        {
            None = 0,
            Shadow = 1,
            Outline = 2,
            Outline8 = 3,
            Shadow3 = 4,
        }

        class UIDissolve : Coffee.UIEffects.BaseMaterialEffect, UnityEngine.UI.IMaterialModifier
        {
            static uint k_ShaderId = 0;
            static /*0x0*/ Coffee.UIEffects.ParameterTexture s_ParamTex;
            static /*0x8*/ int k_TransitionTexId;
            static /*0x10*/ UnityEngine.Texture _defaultTransitionTexture;
            /*0x4c*/ bool _lastKeepAspectRatio;
            /*0x50*/ Coffee.UIEffects.EffectArea _lastEffectArea;
            /*0x54*/ float m_EffectFactor;
            /*0x58*/ float m_Width;
            /*0x5c*/ float m_Softness;
            /*0x60*/ UnityEngine.Color m_Color;
            /*0x70*/ Coffee.UIEffects.ColorMode m_ColorMode;
            /*0x78*/ UnityEngine.Texture m_TransitionTexture;
            /*0x80*/ Coffee.UIEffects.EffectArea m_EffectArea;
            /*0x84*/ bool m_KeepAspectRatio;
            /*0x88*/ Coffee.UIEffects.EffectPlayer m_Player;
            /*0x90*/ bool m_Reverse;

            static /*0x2a1a76c*/ UIDissolve();
            static /*0x2a19aa8*/ UnityEngine.Texture get_defaultTransitionTexture();
            /*0x2a1a6c4*/ UIDissolve();
            /*0x2a197ec*/ float get_effectFactor();
            /*0x2a197f4*/ void set_effectFactor(float value);
            /*0x2a19868*/ float get_width();
            /*0x2a19870*/ void set_width(float value);
            /*0x2a198e4*/ float get_softness();
            /*0x2a198ec*/ void set_softness(float value);
            /*0x2a19960*/ UnityEngine.Color get_color();
            /*0x2a1996c*/ void set_color(UnityEngine.Color value);
            /*0x2a199fc*/ UnityEngine.Texture get_transitionTexture();
            /*0x2a19bd8*/ void set_transitionTexture(UnityEngine.Texture value);
            /*0x2a19c70*/ Coffee.UIEffects.EffectArea get_effectArea();
            /*0x2a19c78*/ void set_effectArea(Coffee.UIEffects.EffectArea value);
            /*0x2a19c9c*/ bool get_keepAspectRatio();
            /*0x2a19ca4*/ void set_keepAspectRatio(bool value);
            /*0x2a19cd4*/ Coffee.UIEffects.ColorMode get_colorMode();
            /*0x2a19cdc*/ void set_colorMode(Coffee.UIEffects.ColorMode value);
            /*0x2a19cf4*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a19d58*/ Coffee.UIEffects.EffectPlayer get_effectPlayer();
            /*0x2a19dc8*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material material);
            /*0x2a19f2c*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a1a118*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a1a3b8*/ void SetEffectParamsDirty();
            /*0x2a1a4c0*/ void SetVerticesDirty();
            /*0x2a1a4f0*/ void OnDidApplyAnimationProperties();
            /*0x2a1a578*/ void Play(bool reset);
            /*0x2a1a5b0*/ void Stop(bool reset);
            /*0x2a1a5dc*/ void OnEnable();
            /*0x2a1a694*/ void OnDisable();
            /*0x2a1a828*/ void <OnEnable>b__54_0(float f);
        }

        class UIEffect : Coffee.UIEffects.BaseMaterialEffect, UnityEngine.UI.IMaterialModifier
        {
            static uint k_ShaderId = 16;
            static /*0x0*/ Coffee.UIEffects.ParameterTexture s_ParamTex;
            /*0x4c*/ float m_EffectFactor;
            /*0x50*/ float m_ColorFactor;
            /*0x54*/ float m_BlurFactor;
            /*0x58*/ Coffee.UIEffects.EffectMode m_EffectMode;
            /*0x5c*/ Coffee.UIEffects.ColorMode m_ColorMode;
            /*0x60*/ Coffee.UIEffects.BlurMode m_BlurMode;
            /*0x64*/ bool m_AdvancedBlur;

            static /*0x2a1bac4*/ UIEffect();
            static /*0x2a1b76c*/ void GetBounds(System.Collections.Generic.List<UnityEngine.UIVertex> verts, int start, int count, ref UnityEngine.Rect posBounds, ref UnityEngine.Rect uvBounds, bool global);
            /*0x2a1ba54*/ UIEffect();
            /*0x2a1a850*/ UnityEngine.AdditionalCanvasShaderChannels get_uvMaskChannel();
            /*0x2a1a874*/ float get_effectFactor();
            /*0x2a1a87c*/ void set_effectFactor(float value);
            /*0x2a1a8f0*/ float get_colorFactor();
            /*0x2a1a8f8*/ void set_colorFactor(float value);
            /*0x2a1a96c*/ float get_blurFactor();
            /*0x2a1a974*/ void set_blurFactor(float value);
            /*0x2a1a9e8*/ Coffee.UIEffects.EffectMode get_effectMode();
            /*0x2a1a9f0*/ void set_effectMode(Coffee.UIEffects.EffectMode value);
            /*0x2a1aa08*/ Coffee.UIEffects.ColorMode get_colorMode();
            /*0x2a1aa10*/ void set_colorMode(Coffee.UIEffects.ColorMode value);
            /*0x2a1aa28*/ Coffee.UIEffects.BlurMode get_blurMode();
            /*0x2a1aa30*/ void set_blurMode(Coffee.UIEffects.BlurMode value);
            /*0x2a1aa48*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a1aaac*/ bool get_advancedBlur();
            /*0x2a1aab4*/ void set_advancedBlur(bool value);
            /*0x2a1ab04*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material material);
            /*0x2a1ac70*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a1af04*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a1b9c4*/ void SetEffectParamsDirty();

            enum BlurEx
            {
                None = 0,
                Ex = 1,
            }
        }

        class UIFlip : Coffee.UIEffects.BaseMeshEffect
        {
            /*0x38*/ bool m_Horizontal;
            /*0x39*/ bool m_Veritical;

            /*0x2a1bcc0*/ UIFlip();
            /*0x2a1bb54*/ bool get_horizontal();
            /*0x2a1bb5c*/ void set_horizontal(bool value);
            /*0x2a1bb8c*/ bool get_vertical();
            /*0x2a1bb94*/ void set_vertical(bool value);
            /*0x2a1bbc4*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
        }

        class UIGradient : Coffee.UIEffects.BaseMeshEffect
        {
            static /*0x0*/ UnityEngine.Vector2[] s_SplitedCharacterPosition;
            /*0x38*/ Coffee.UIEffects.UIGradient.Direction m_Direction;
            /*0x3c*/ UnityEngine.Color m_Color1;
            /*0x4c*/ UnityEngine.Color m_Color2;
            /*0x5c*/ UnityEngine.Color m_Color3;
            /*0x6c*/ UnityEngine.Color m_Color4;
            /*0x7c*/ float m_Rotation;
            /*0x80*/ float m_Offset1;
            /*0x84*/ float m_Offset2;
            /*0x88*/ Coffee.UIEffects.UIGradient.GradientStyle m_GradientStyle;
            /*0x8c*/ UnityEngine.ColorSpace m_ColorSpace;
            /*0x90*/ bool m_IgnoreAspectRatio;

            static /*0x2a1c764*/ UIGradient();
            /*0x2a1c6f4*/ UIGradient();
            /*0x2a1bcc4*/ Coffee.UIEffects.UIGradient.Direction get_direction();
            /*0x2a1bccc*/ void set_direction(Coffee.UIEffects.UIGradient.Direction value);
            /*0x2a1bcf0*/ UnityEngine.Color get_color1();
            /*0x2a1bcfc*/ void set_color1(UnityEngine.Color value);
            /*0x2a1bd8c*/ UnityEngine.Color get_color2();
            /*0x2a1bd98*/ void set_color2(UnityEngine.Color value);
            /*0x2a1be28*/ UnityEngine.Color get_color3();
            /*0x2a1be34*/ void set_color3(UnityEngine.Color value);
            /*0x2a1bec4*/ UnityEngine.Color get_color4();
            /*0x2a1bed0*/ void set_color4(UnityEngine.Color value);
            /*0x2a1bf60*/ float get_rotation();
            /*0x2a1bf8c*/ void set_rotation(float value);
            /*0x2a1bff0*/ float get_offset();
            /*0x2a1bff8*/ void set_offset(float value);
            /*0x2a1c05c*/ UnityEngine.Vector2 get_offset2();
            /*0x2a1c064*/ void set_offset2(UnityEngine.Vector2 value);
            /*0x2a1c0e0*/ Coffee.UIEffects.UIGradient.GradientStyle get_gradientStyle();
            /*0x2a1c0e8*/ void set_gradientStyle(Coffee.UIEffects.UIGradient.GradientStyle value);
            /*0x2a1c10c*/ UnityEngine.ColorSpace get_colorSpace();
            /*0x2a1c114*/ void set_colorSpace(UnityEngine.ColorSpace value);
            /*0x2a1c138*/ bool get_ignoreAspectRatio();
            /*0x2a1c140*/ void set_ignoreAspectRatio(bool value);
            /*0x2a1c170*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);

            enum Direction
            {
                Horizontal = 0,
                Vertical = 1,
                Angle = 2,
                Diagonal = 3,
            }

            enum GradientStyle
            {
                Rect = 0,
                Fit = 1,
                Split = 2,
            }
        }

        class UIHsvModifier : Coffee.UIEffects.BaseMaterialEffect
        {
            static uint k_ShaderId = 48;
            static /*0x0*/ Coffee.UIEffects.ParameterTexture s_ParamTex;
            /*0x4c*/ UnityEngine.Color m_TargetColor;
            /*0x5c*/ float m_Range;
            /*0x60*/ float m_Hue;
            /*0x64*/ float m_Saturation;
            /*0x68*/ float m_Value;

            static /*0x2a1d070*/ UIHsvModifier();
            /*0x2a1cff4*/ UIHsvModifier();
            /*0x2a1c844*/ UnityEngine.Color get_targetColor();
            /*0x2a1c850*/ void set_targetColor(UnityEngine.Color value);
            /*0x2a1c8e0*/ float get_range();
            /*0x2a1c8e8*/ void set_range(float value);
            /*0x2a1c95c*/ float get_saturation();
            /*0x2a1c964*/ void set_saturation(float value);
            /*0x2a1c9d8*/ float get_value();
            /*0x2a1c9e0*/ void set_value(float value);
            /*0x2a1ca54*/ float get_hue();
            /*0x2a1ca5c*/ void set_hue(float value);
            /*0x2a1cad0*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a1cb34*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material material);
            /*0x2a1cc78*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a1cd68*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a1ce78*/ void SetEffectParamsDirty();
        }

        class UIShadow : Coffee.UIEffects.BaseMeshEffect, Coffee.UIEffects.IParameterTexture
        {
            static float kMaxEffectDistance = 600;
            static /*0x0*/ System.Collections.Generic.List<Coffee.UIEffects.UIShadow> tmpShadows;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UIVertex> s_Verts;
            /*0x38*/ int _graphicVertexCount;
            /*0x40*/ Coffee.UIEffects.UIEffect _uiEffect;
            /*0x48*/ float m_BlurFactor;
            /*0x4c*/ Coffee.UIEffects.ShadowStyle m_Style;
            /*0x50*/ UnityEngine.Color m_EffectColor;
            /*0x60*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x68*/ bool m_UseGraphicAlpha;
            /*0x6c*/ int <parameterIndex>k__BackingField;
            /*0x70*/ Coffee.UIEffects.ParameterTexture <paramTex>k__BackingField;

            static /*0x2a1e1bc*/ UIShadow();
            /*0x2a1e148*/ UIShadow();
            /*0x2a1d100*/ UnityEngine.Color get_effectColor();
            /*0x2a1d10c*/ void set_effectColor(UnityEngine.Color value);
            /*0x2a1d19c*/ UnityEngine.Vector2 get_effectDistance();
            /*0x2a1d1a4*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x2a1d20c*/ bool get_useGraphicAlpha();
            /*0x2a1d214*/ void set_useGraphicAlpha(bool value);
            /*0x2a1d244*/ float get_blurFactor();
            /*0x2a1d24c*/ void set_blurFactor(float value);
            /*0x2a1d2c0*/ Coffee.UIEffects.ShadowStyle get_style();
            /*0x2a1d2c8*/ void set_style(Coffee.UIEffects.ShadowStyle value);
            /*0x2a1d2ec*/ int get_parameterIndex();
            /*0x2a1d2f4*/ void set_parameterIndex(int value);
            /*0x2a1d2fc*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a1d304*/ void set_paramTex(Coffee.UIEffects.ParameterTexture value);
            /*0x2a1d30c*/ void OnEnable();
            /*0x2a1d3dc*/ void OnDisable();
            /*0x2a1d414*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a1da14*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color color, ref int start, ref int end, UnityEngine.Vector2 distance, Coffee.UIEffects.ShadowStyle style, bool alpha);
            /*0x2a1dce0*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color color, ref int start, ref int end, float x, float y, bool alpha);
        }

        class UIShiny : Coffee.UIEffects.BaseMaterialEffect
        {
            static uint k_ShaderId = 8;
            static /*0x0*/ Coffee.UIEffects.ParameterTexture s_ParamTex;
            /*0x4c*/ float _lastRotation;
            /*0x50*/ Coffee.UIEffects.EffectArea _lastEffectArea;
            /*0x54*/ float m_EffectFactor;
            /*0x58*/ float m_Width;
            /*0x5c*/ float m_Rotation;
            /*0x60*/ float m_Softness;
            /*0x64*/ float m_Brightness;
            /*0x68*/ float m_Gloss;
            /*0x6c*/ Coffee.UIEffects.EffectArea m_EffectArea;
            /*0x70*/ Coffee.UIEffects.EffectPlayer m_Player;

            static /*0x2a1ee9c*/ UIShiny();
            /*0x2a1ee28*/ UIShiny();
            /*0x2a1e290*/ float get_effectFactor();
            /*0x2a1e298*/ void set_effectFactor(float value);
            /*0x2a1e30c*/ float get_width();
            /*0x2a1e314*/ void set_width(float value);
            /*0x2a1e388*/ float get_softness();
            /*0x2a1e390*/ void set_softness(float value);
            /*0x2a1e408*/ float get_brightness();
            /*0x2a1e410*/ void set_brightness(float value);
            /*0x2a1e484*/ float get_gloss();
            /*0x2a1e48c*/ void set_gloss(float value);
            /*0x2a1e500*/ float get_rotation();
            /*0x2a1e508*/ void set_rotation(float value);
            /*0x2a1e56c*/ Coffee.UIEffects.EffectArea get_effectArea();
            /*0x2a1e574*/ void set_effectArea(Coffee.UIEffects.EffectArea value);
            /*0x2a1e598*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a1e5fc*/ Coffee.UIEffects.EffectPlayer get_effectPlayer();
            /*0x2a1e66c*/ void OnEnable();
            /*0x2a1e724*/ void OnDisable();
            /*0x2a1e754*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material material);
            /*0x2a1e898*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a1e988*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a1ec3c*/ void Play(bool reset);
            /*0x2a1ec74*/ void Stop(bool reset);
            /*0x2a1eca0*/ void SetEffectParamsDirty();
            /*0x2a1ed80*/ void SetVerticesDirty();
            /*0x2a1edac*/ void OnDidApplyAnimationProperties();
            /*0x2a1ef2c*/ void <OnEnable>b__37_0(float f);
        }

        class UISyncEffect : Coffee.UIEffects.BaseMaterialEffect
        {
            /*0x50*/ Coffee.UIEffects.BaseMeshEffect m_TargetEffect;

            /*0x2a1f544*/ UISyncEffect();
            /*0x2a1ef30*/ Coffee.UIEffects.BaseMeshEffect get_targetEffect();
            /*0x2a1efb0*/ void set_targetEffect(Coffee.UIEffects.BaseMeshEffect value);
            /*0x2a1f070*/ void OnEnable();
            /*0x2a1f128*/ void OnDisable();
            /*0x2a1f1e0*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material baseMaterial);
            /*0x2a1f33c*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a1f45c*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
        }

        class UITransitionEffect : Coffee.UIEffects.BaseMaterialEffect
        {
            static uint k_ShaderId = 40;
            static /*0x0*/ int k_TransitionTexId;
            static /*0x8*/ Coffee.UIEffects.ParameterTexture s_ParamTex;
            static /*0x10*/ UnityEngine.Texture _defaultTransitionTexture;
            /*0x4c*/ bool _lastKeepAspectRatio;
            /*0x50*/ Coffee.UIEffects.UITransitionEffect.EffectMode m_EffectMode;
            /*0x54*/ float m_EffectFactor;
            /*0x58*/ UnityEngine.Texture m_TransitionTexture;
            /*0x60*/ Coffee.UIEffects.EffectArea m_EffectArea;
            /*0x64*/ bool m_KeepAspectRatio;
            /*0x68*/ float m_DissolveWidth;
            /*0x6c*/ float m_DissolveSoftness;
            /*0x70*/ UnityEngine.Color m_DissolveColor;
            /*0x80*/ bool m_PassRayOnHidden;
            /*0x88*/ Coffee.UIEffects.EffectPlayer m_Player;

            static /*0x2a2060c*/ UITransitionEffect();
            static /*0x2a1f6cc*/ UnityEngine.Texture get_defaultTransitionTexture();
            /*0x2a20568*/ UITransitionEffect();
            /*0x2a1f5a4*/ float get_effectFactor();
            /*0x2a1f5ac*/ void set_effectFactor(float value);
            /*0x2a1f620*/ UnityEngine.Texture get_transitionTexture();
            /*0x2a1f7fc*/ void set_transitionTexture(UnityEngine.Texture value);
            /*0x2a1f894*/ Coffee.UIEffects.UITransitionEffect.EffectMode get_effectMode();
            /*0x2a1f89c*/ void set_effectMode(Coffee.UIEffects.UITransitionEffect.EffectMode value);
            /*0x2a1f8b4*/ bool get_keepAspectRatio();
            /*0x2a1f8bc*/ void set_keepAspectRatio(bool value);
            /*0x2a1f8ec*/ Coffee.UIEffects.ParameterTexture get_paramTex();
            /*0x2a1f950*/ float get_dissolveWidth();
            /*0x2a1f958*/ void set_dissolveWidth(float value);
            /*0x2a1f9cc*/ float get_dissolveSoftness();
            /*0x2a1f9d4*/ void set_dissolveSoftness(float value);
            /*0x2a1fa48*/ UnityEngine.Color get_dissolveColor();
            /*0x2a1fa54*/ void set_dissolveColor(UnityEngine.Color value);
            /*0x2a1fae4*/ bool get_passRayOnHidden();
            /*0x2a1faec*/ void set_passRayOnHidden(bool value);
            /*0x2a1faf8*/ Coffee.UIEffects.EffectPlayer get_effectPlayer();
            /*0x2a1fb68*/ void Show(bool reset);
            /*0x2a1fc3c*/ void Hide(bool reset);
            /*0x2a1fd10*/ UnityEngine.Hash128 GetMaterialHash(UnityEngine.Material material);
            /*0x2a1fe74*/ void ModifyMaterial(UnityEngine.Material newMaterial, UnityEngine.UI.Graphic graphic);
            /*0x2a20060*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh, UnityEngine.UI.Graphic graphic);
            /*0x2a20300*/ void OnEnable();
            /*0x2a20348*/ void OnDisable();
            /*0x2a20378*/ void SetEffectParamsDirty();
            /*0x2a204c8*/ void SetVerticesDirty();
            /*0x2a204f0*/ void OnDidApplyAnimationProperties();
            /*0x2a206c8*/ void <Show>b__46_0(float f);
            /*0x2a206cc*/ void <Hide>b__47_0(float f);

            enum EffectMode
            {
                Fade = 1,
                Cutoff = 2,
                Dissolve = 3,
            }
        }
    }
}
