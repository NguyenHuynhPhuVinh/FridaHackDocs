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

                /*0x37ec39c*/ bool get_IsReference();
            }

            class DataMemberAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ int order;
                /*0x1c*/ bool isRequired;
                /*0x1d*/ bool emitDefaultValue;

                /*0x37ec3a4*/ string get_Name();
                /*0x37ec3ac*/ int get_Order();
                /*0x37ec3b4*/ bool get_IsRequired();
                /*0x37ec3bc*/ bool get_EmitDefaultValue();
            }

            class EnumMemberAttribute : System.Attribute
            {
                /*0x10*/ string value;

                /*0x37ec3c4*/ string get_Value();
            }

            class IgnoreDataMemberAttribute : System.Attribute
            {
            }
        }
    }
}
