class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x6f8ca30*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x6f8ca38*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x6f8cac0*/ NullableContextAttribute(byte );
            }

            class RefSafetyRulesAttribute : System.Attribute
            {
                /*0x10*/ int Version;

                /*0x6f8cae8*/ RefSafetyRulesAttribute(int );
            }
        }
    }
}

namespace MessagePack
{
    class MessagePackObjectAttribute : System.Attribute
    {
        /*0x10*/ bool <KeyAsPropertyName>k__BackingField;
        /*0x11*/ bool <AllowPrivate>k__BackingField;

        /*0x6f8cb18*/ MessagePackObjectAttribute(bool keyAsPropertyName);
        /*0x6f8cb10*/ bool get_KeyAsPropertyName();
        /*0x6f8cb40*/ bool get_AllowPrivate();
        /*0x6f8cb48*/ void set_AllowPrivate(bool value);
    }

    class KeyAttribute : System.Attribute
    {
        /*0x10*/ System.Nullable<int> <IntKey>k__BackingField;
        /*0x18*/ string <StringKey>k__BackingField;

        /*0x6f8cb64*/ KeyAttribute(int x);
        /*0x6f8cbd8*/ KeyAttribute(string x);
        /*0x6f8cb54*/ System.Nullable<int> get_IntKey();
        /*0x6f8cb5c*/ string get_StringKey();
    }

    class IgnoreMemberAttribute : System.Attribute
    {
        /*0x6f8cc60*/ IgnoreMemberAttribute();
    }

    class UnionAttribute : System.Attribute
    {
        /*0x10*/ int <Key>k__BackingField;
        /*0x18*/ System.Type <SubType>k__BackingField;

        /*0x6f8cc78*/ UnionAttribute(int key, System.Type subType);
        /*0x6f8cc68*/ int get_Key();
        /*0x6f8cc70*/ System.Type get_SubType();
    }

    class SerializationConstructorAttribute : System.Attribute
    {
    }

    class MessagePackFormatterAttribute : System.Attribute
    {
        /*0x10*/ System.Type <FormatterType>k__BackingField;
        /*0x18*/ object[] <Arguments>k__BackingField;

        /*0x6f8cd08*/ System.Type get_FormatterType();
        /*0x6f8cd10*/ object[] get_Arguments();
    }

    interface IMessagePackSerializationCallbackReceiver
    {
        /*0x380cb08*/ void OnBeforeSerialize();
        /*0x380cb08*/ void OnAfterDeserialize();
    }
}
