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

                /*0x1049e78*/ bool get_IsReference();
            }

            class DataMemberAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ int order;
                /*0x1c*/ bool isRequired;
                /*0x1d*/ bool emitDefaultValue;

                /*0x1049e80*/ string get_Name();
                /*0x1049e88*/ int get_Order();
                /*0x1049e90*/ bool get_IsRequired();
                /*0x1049e98*/ bool get_EmitDefaultValue();
            }

            class EnumMemberAttribute : System.Attribute
            {
                /*0x10*/ string value;
                /*0x18*/ bool isValueSetExplicitly;

                /*0x1049ea0*/ EnumMemberAttribute();
                /*0x1049ea8*/ string get_Value();
                /*0x1049eb0*/ void set_Value(string value);
            }

            class IgnoreDataMemberAttribute : System.Attribute
            {
            }
        }
    }
}
