class <Module>
{
}

class WwiseAcousticTextureReference : WwiseObjectReference
{
    /*0x2122638*/ WwiseAcousticTextureReference();
    /*0x2122630*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseAuxBusReference : WwiseObjectReference
{
    /*0x2122698*/ WwiseAuxBusReference();
    /*0x2122690*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseBankReference : WwiseObjectReference
{
    /*0x21226a4*/ WwiseBankReference();
    /*0x212269c*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseEventReference : WwiseObjectReference
{
    /*0x21226b0*/ WwiseEventReference();
    /*0x21226a8*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseObjectReference : UnityEngine.ScriptableObject
{
    /*0x18*/ string objectName;
    /*0x20*/ uint id;
    /*0x28*/ string guid;

    /*0x212263c*/ WwiseObjectReference();
    /*0x21226b4*/ System.Guid get_Guid();
    /*0x2122738*/ string get_ObjectName();
    /*0x2122740*/ string get_DisplayName();
    /*0x2122748*/ uint get_Id();
    /*0x1f2ffc8*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseGroupValueObjectReference : WwiseObjectReference
{
    /*0x2122804*/ WwiseGroupValueObjectReference();
    /*0x1f30214*/ WwiseObjectReference get_GroupObjectReference();
    /*0x1f30ebc*/ void set_GroupObjectReference(WwiseObjectReference value);
    /*0x1f2ffc8*/ WwiseObjectType get_GroupWwiseObjectType();
    /*0x2122750*/ string get_DisplayName();
}

enum WwiseObjectType
{
    None = 0,
    AuxBus = 1,
    Bus = 2,
    Event = 3,
    Folder = 4,
    PhysicalFolder = 5,
    Project = 6,
    Soundbank = 7,
    State = 8,
    StateGroup = 9,
    Switch = 10,
    SwitchGroup = 11,
    WorkUnit = 12,
    GameParameter = 13,
    Trigger = 14,
    AcousticTexture = 15,
}

class WwiseRtpcReference : WwiseObjectReference
{
    /*0x2122810*/ WwiseRtpcReference();
    /*0x2122808*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseStateGroupReference : WwiseObjectReference
{
    /*0x212281c*/ WwiseStateGroupReference();
    /*0x2122814*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseStateReference : WwiseGroupValueObjectReference
{
    /*0x30*/ WwiseStateGroupReference WwiseStateGroupReference;

    /*0x21228f4*/ WwiseStateReference();
    /*0x2122820*/ WwiseObjectType get_WwiseObjectType();
    /*0x2122828*/ WwiseObjectReference get_GroupObjectReference();
    /*0x2122830*/ void set_GroupObjectReference(WwiseObjectReference value);
    /*0x21228ec*/ WwiseObjectType get_GroupWwiseObjectType();
}

class WwiseSwitchGroupReference : WwiseObjectReference
{
    /*0x2122900*/ WwiseSwitchGroupReference();
    /*0x21228f8*/ WwiseObjectType get_WwiseObjectType();
}

class WwiseSwitchReference : WwiseGroupValueObjectReference
{
    /*0x30*/ WwiseSwitchGroupReference WwiseSwitchGroupReference;

    /*0x21229d8*/ WwiseSwitchReference();
    /*0x2122904*/ WwiseObjectType get_WwiseObjectType();
    /*0x212290c*/ WwiseObjectReference get_GroupObjectReference();
    /*0x2122914*/ void set_GroupObjectReference(WwiseObjectReference value);
    /*0x21229d0*/ WwiseObjectType get_GroupWwiseObjectType();
}

class WwiseTriggerReference : WwiseObjectReference
{
    /*0x21229e4*/ WwiseTriggerReference();
    /*0x21229dc*/ WwiseObjectType get_WwiseObjectType();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x21229e8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2122adc*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace AK
{
    namespace Wwise
    {
        class AcousticTexture : AK.Wwise.BaseType
        {
            /*0x20*/ WwiseAcousticTextureReference WwiseObjectReference;

            /*0x2122bb0*/ AcousticTexture();
            /*0x2122ae4*/ WwiseObjectReference get_ObjectReference();
            /*0x2122aec*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x2122ba8*/ WwiseObjectType get_WwiseObjectType();
        }

        class AuxBus : AK.Wwise.BaseType
        {
            /*0x20*/ WwiseAuxBusReference WwiseObjectReference;

            /*0x2122c8c*/ AuxBus();
            /*0x2122bc0*/ WwiseObjectReference get_ObjectReference();
            /*0x2122bc8*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x2122c84*/ WwiseObjectType get_WwiseObjectType();
        }

        class Bank : AK.Wwise.BaseType
        {
            /*0x20*/ WwiseBankReference WwiseObjectReference;

            /*0x2122f34*/ Bank();
            /*0x2122c94*/ WwiseObjectType get_WwiseObjectType();
            /*0x2122c9c*/ WwiseObjectReference get_ObjectReference();
            /*0x2122ca4*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x2122d60*/ void Load(bool decodeBank, bool saveDecodedBank);
            /*0x2122e0c*/ void LoadAsync(AkCallbackManager.BankCallback callback);
            /*0x2122ea4*/ void Unload();
        }

        class BaseGroupType : AK.Wwise.BaseType
        {
            /*0x20*/ int groupIdInternal;
            /*0x28*/ byte[] groupGuidInternal;

            /*0x2123254*/ BaseGroupType();
            /*0x2122f3c*/ WwiseObjectReference get_GroupWwiseObjectReference();
            /*0x1f2ffc8*/ WwiseObjectType get_WwiseObjectGroupType();
            /*0x212301c*/ uint get_GroupId();
            /*0x21230a8*/ bool IsValid();
            /*0x21231a4*/ int get_groupID();
            /*0x21231a8*/ byte[] get_groupGuid();
        }

        class BaseType
        {
            /*0x10*/ int idInternal;
            /*0x18*/ byte[] valueGuidInternal;

            static /*0x212325c*/ int CombineHashCodes(int[] hashCodes);
            static /*0x2123354*/ uint get_InvalidId();
            /*0x2122bb8*/ BaseType();
            /*0x1f30214*/ WwiseObjectReference get_ObjectReference();
            /*0x1f30ebc*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x1f2ffc8*/ WwiseObjectType get_WwiseObjectType();
            /*0x21232b4*/ string get_Name();
            /*0x2123310*/ uint get_Id();
            /*0x2123130*/ bool IsValid();
            /*0x212335c*/ bool Validate();
            /*0x212343c*/ void Verify(AKRESULT result);
            /*0x2123440*/ string ToString();
            /*0x21234e8*/ int GetHashCode();
            /*0x212360c*/ int get_ID();
            /*0x2123610*/ byte[] get_valueGuid();
        }

        class CallbackFlags
        {
            /*0x10*/ uint value;

            /*0x21236bc*/ CallbackFlags();
        }

        class Event : AK.Wwise.BaseType
        {
            /*0x20*/ WwiseEventReference WwiseObjectReference;
            /*0x28*/ uint m_playingId;

            /*0x2123d00*/ Event();
            /*0x21236c4*/ uint get_PlayingId();
            /*0x21236cc*/ WwiseObjectReference get_ObjectReference();
            /*0x21236d4*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x2123790*/ WwiseObjectType get_WwiseObjectType();
            /*0x2123798*/ void VerifyPlayingID(uint playingId);
            /*0x212379c*/ uint Post(UnityEngine.GameObject gameObject);
            /*0x2123830*/ uint Post(UnityEngine.GameObject gameObject, AK.Wwise.CallbackFlags flags, AkCallbackManager.EventCallback callback, object cookie);
            /*0x21238f4*/ uint Post(UnityEngine.GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie);
            /*0x21239b0*/ uint Post(ulong gameObjectId);
            /*0x2123a44*/ void Stop(UnityEngine.GameObject gameObject, int transitionDuration, AkCurveInterpolation curveInterpolation);
            /*0x2123a54*/ void ExecuteAction(UnityEngine.GameObject gameObject, AkActionOnEventType actionOnEventType, int transitionDuration, AkCurveInterpolation curveInterpolation);
            /*0x2123b14*/ void PostMIDI(UnityEngine.GameObject gameObject, AkMIDIPostArray array);
            /*0x2123b74*/ void PostMIDI(UnityEngine.GameObject gameObject, AkMIDIPostArray array, int count);
            /*0x2123be8*/ void StopMIDI(UnityEngine.GameObject gameObject);
            /*0x2123c78*/ void StopMIDI();
        }

        class RTPC : AK.Wwise.BaseType
        {
            /*0x20*/ WwiseRtpcReference WwiseObjectReference;

            /*0x2124004*/ RTPC();
            /*0x2123d08*/ WwiseObjectReference get_ObjectReference();
            /*0x2123d10*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x2123dcc*/ WwiseObjectType get_WwiseObjectType();
            /*0x2123dd4*/ void SetValue(UnityEngine.GameObject gameObject, float value);
            /*0x2123e78*/ float GetValue(UnityEngine.GameObject gameObject);
            /*0x2123f60*/ void SetGlobalValue(float value);
            /*0x2123ffc*/ float GetGlobalValue();
        }

        class State : AK.Wwise.BaseGroupType
        {
            /*0x30*/ WwiseStateReference WwiseObjectReference;

            /*0x2124178*/ State();
            /*0x212400c*/ WwiseObjectReference get_ObjectReference();
            /*0x2124014*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x21240d0*/ WwiseObjectType get_WwiseObjectType();
            /*0x21240d8*/ WwiseObjectType get_WwiseObjectGroupType();
            /*0x21240e0*/ void SetValue();
        }

        class Switch : AK.Wwise.BaseGroupType
        {
            /*0x30*/ WwiseSwitchReference WwiseObjectReference;

            /*0x2124300*/ Switch();
            /*0x2124180*/ WwiseObjectReference get_ObjectReference();
            /*0x2124188*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x2124244*/ WwiseObjectType get_WwiseObjectType();
            /*0x212424c*/ WwiseObjectType get_WwiseObjectGroupType();
            /*0x2124254*/ void SetValue(UnityEngine.GameObject gameObject);
        }

        class Trigger : AK.Wwise.BaseType
        {
            /*0x20*/ WwiseTriggerReference WwiseObjectReference;

            /*0x2124464*/ Trigger();
            /*0x2124308*/ WwiseObjectReference get_ObjectReference();
            /*0x2124310*/ void set_ObjectReference(WwiseObjectReference value);
            /*0x21243cc*/ WwiseObjectType get_WwiseObjectType();
            /*0x21243d4*/ void Post(UnityEngine.GameObject gameObject);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 56E7A1DA828186D68EF24B60DA6DAB9A1AC3204187B4464B58805BF3B9E19112;
    static /*0x6b4*/ <PrivateImplementationDetails> 6AB552EEAD15D07E0017C575436CDCE040141E43F3510F31A0AF55757B0596C6;

    struct __StaticArrayInitTypeSize=575
    {
    }

    struct __StaticArrayInitTypeSize=1716
    {
    }
}
