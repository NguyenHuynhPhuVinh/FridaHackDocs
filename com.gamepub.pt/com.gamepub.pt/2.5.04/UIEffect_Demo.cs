class <Module>
{
}

class UIEffect_Demo_ColorControl : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Color m_Color;
    /*0x28*/ UIEffect_Demo_ColorControl.ColorEvent m_ColorEvent;

    /*0x2b2290c*/ UIEffect_Demo_ColorControl();
    /*0x2b225ac*/ void Start();
    /*0x2b227b8*/ void ChangeColor(int channel, float value);

    class ColorEvent : UnityEngine.Events.UnityEvent<UnityEngine.Color>
    {
        /*0x2b2296c*/ ColorEvent();
    }

    class <>c__DisplayClass3_0
    {
        /*0x10*/ int channel;
        /*0x18*/ UIEffect_Demo_ColorControl <>4__this;

        /*0x2b227b0*/ <>c__DisplayClass3_0();
        /*0x2b22c4c*/ void <Start>b__0(float value);
    }
}

class UIEffect_Demo_PropertyControl : UnityEngine.MonoBehaviour
{
    /*0x18*/ string m_PropertyName;
    /*0x20*/ UnityEngine.Object[] m_Objects;

    /*0x2b22c44*/ UIEffect_Demo_PropertyControl();
    /*0x2b229b8*/ void ChangeValue(int value);
}

namespace Coffee
{
    namespace UIEffects
    {
        class UIEffect_Demo : UnityEngine.MonoBehaviour
        {
            /*0x2b225a4*/ UIEffect_Demo();
            /*0x2b2227c*/ void Start();
            /*0x2b222dc*/ void SetTimeScale(float scale);
            /*0x2b222e4*/ void Open(UnityEngine.Animator anim);
            /*0x2b22358*/ void Close(UnityEngine.Animator anim);
            /*0x2b223b0*/ void Capture(UnityEngine.Animator anim);
            /*0x2b22408*/ void SetCanvasOverlay(bool isOverlay);
            /*0x2b22478*/ void SetRenderMode(int mode);
        }
    }
}
