class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x6fa3e60*/ EmbeddedAttribute();
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

                /*0x6fa3e68*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x6fa3ef0*/ NullableContextAttribute(byte );
            }

            class RefSafetyRulesAttribute : System.Attribute
            {
                /*0x10*/ int Version;

                /*0x6fa3f18*/ RefSafetyRulesAttribute(int );
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

        /*0x6fa3f48*/ MessagePackObjectAttribute(bool keyAsPropertyName);
        /*0x6fa3f40*/ bool get_KeyAsPropertyName();
        /*0x6fa3f70*/ bool get_AllowPrivate();
        /*0x6fa3f78*/ void set_AllowPrivate(bool value);
    }

    class KeyAttribute : System.Attribute
    {
        /*0x10*/ System.Nullable<int> <IntKey>k__BackingField;
        /*0x18*/ string <StringKey>k__BackingField;

        /*0x6fa3f94*/ KeyAttribute(int x);
        /*0x6fa4008*/ KeyAttribute(string x);
        /*0x6fa3f84*/ System.Nullable<int> get_IntKey();
        /*0x6fa3f8c*/ string get_StringKey();
    }

    class IgnoreMemberAttribute : System.Attribute
    {
        /*0x6fa4090*/ IgnoreMemberAttribute();
    }

    class UnionAttribute : System.Attribute
    {
        /*0x10*/ int <Key>k__BackingField;
        /*0x18*/ System.Type <SubType>k__BackingField;

        /*0x6fa40a8*/ UnionAttribute(int key, System.Type subType);
        /*0x6fa4098*/ int get_Key();
        /*0x6fa40a0*/ System.Type get_SubType();
    }

    class SerializationConstructorAttribute : System.Attribute
    {
    }

    class MessagePackFormatterAttribute : System.Attribute
    {
        /*0x10*/ System.Type <FormatterType>k__BackingField;
        /*0x18*/ object[] <Arguments>k__BackingField;

        /*0x6fa4138*/ System.Type get_FormatterType();
        /*0x6fa4140*/ object[] get_Arguments();
    }

    interface IMessagePackSerializationCallbackReceiver
    {
        /*0x38159dc*/ void OnBeforeSerialize();
        /*0x38159dc*/ void OnAfterDeserialize();
    }
}
