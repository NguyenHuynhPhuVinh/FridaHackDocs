class <Module>
{
}

namespace System
{
    namespace Runtime
    {
        namespace Serialization
        {
            class DataContractAttribute : System.Attribute
            {
                /*0x10*/ bool isReference;

                /*0x2b3a074*/ bool get_IsReference();
            }

            class DataMemberAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ int order;
                /*0x1c*/ bool isRequired;
                /*0x1d*/ bool emitDefaultValue;

                /*0x2b3a07c*/ string get_Name();
                /*0x2b3a084*/ int get_Order();
                /*0x2b3a08c*/ bool get_IsRequired();
                /*0x2b3a094*/ bool get_EmitDefaultValue();
            }

            class EnumMemberAttribute : System.Attribute
            {
                /*0x10*/ string value;
                /*0x18*/ bool isValueSetExplicitly;

                /*0x2b3a09c*/ EnumMemberAttribute();
                /*0x2b3a0a4*/ string get_Value();
                /*0x2b3a0ac*/ void set_Value(string value);
                /*0x2b3a0bc*/ bool get_IsValueSetExplicitly();
            }

            class IgnoreDataMemberAttribute : System.Attribute
            {
            }

            class KnownTypeAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x2b3a0c4*/ KnownTypeAttribute(System.Type type);
            }
        }
    }
}
