class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0x2b24acc*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x2b253fc*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x2b25518*/ WritableAttribute();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x2b25430*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x2b24c2c*/ NativeClassAttribute(string qualifiedCppName);
        /*0x2b24ca0*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x2b24c1c*/ void set_QualifiedNativeName(string value);
        /*0x2b24c24*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x2b25438*/ string Format(string fmt, object[] args);
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x2b25508*/ VisibleToOtherModulesAttribute();
            /*0x2b25510*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ bool <Enabled>k__BackingField;

            /*0x2b24cec*/ NativeConditionalAttribute(string condition);
            /*0x2b24cd8*/ void set_Condition(string value);
            /*0x2b24ce0*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x2b24d28*/ NativeHeaderAttribute(string header);
            /*0x2b24d20*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x2b24f78*/ NativeNameAttribute(string name);
            /*0x2b24f70*/ void set_Name(string value);
        }

        class NativeWritableSelfAttribute : System.Attribute
        {
            /*0x10*/ bool <WritableSelf>k__BackingField;

            /*0x2b252c8*/ NativeWritableSelfAttribute();
            /*0x2b252bc*/ void set_WritableSelf(bool value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x2b24b30*/ NativeMethodAttribute();
            /*0x2b24e68*/ NativeMethodAttribute(string name);
            /*0x2b24b60*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x2b24bc0*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x2b24e30*/ void set_Name(string value);
            /*0x2b24e38*/ void set_IsThreadSafe(bool value);
            /*0x2b24e44*/ void set_IsFreeFunction(bool value);
            /*0x2b24e50*/ void set_ThrowsException(bool value);
            /*0x2b24e5c*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1c*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x2b25088*/ NativePropertyAttribute();
            /*0x2b25090*/ NativePropertyAttribute(string name);
            /*0x2b25094*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x2b25080*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x2b24c14*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x2b25120*/ NativeTypeAttribute();
            /*0x2b25148*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x2b25174*/ NativeTypeAttribute(string header);
            /*0x2b25280*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x2b25108*/ void set_Header(string value);
            /*0x2b25110*/ void set_IntermediateScriptingStructName(string value);
            /*0x2b25118*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x10*/ string <Exception>k__BackingField;

            /*0x2b252fc*/ NotNullAttribute(string exception);
            /*0x2b252f4*/ void set_Exception(string value);
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x2b24b04*/ FreeFunctionAttribute();
            /*0x2b24b38*/ FreeFunctionAttribute(string name);
            /*0x2b24b8c*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x2b25404*/ ThreadSafeAttribute();
        }

        enum StaticAccessorType
        {
            Dot = 0,
            Arrow = 1,
            DoubleColon = 2,
            ArrowWithDefaultReturnIfNull = 3,
        }

        class StaticAccessorAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ UnityEngine.Bindings.StaticAccessorType <Type>k__BackingField;

            /*0x2b25394*/ StaticAccessorAttribute(string name);
            /*0x2b253c0*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x2b25384*/ void set_Name(string value);
            /*0x2b2538c*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x2b250dc*/ NativeThrowsAttribute();
            /*0x2b250d0*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x2b24c0c*/ IgnoreAttribute();
            /*0x2b24c00*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x2b25328*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x2b254cc*/ UsedByNativeCodeAttribute();
            /*0x2b254d4*/ UsedByNativeCodeAttribute(string name);
            /*0x2b25500*/ void set_Name(string value);
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x2b25330*/ RequiredByNativeCodeAttribute();
            /*0x2b25338*/ RequiredByNativeCodeAttribute(string name);
            /*0x2b25364*/ void set_Name(string value);
            /*0x2b2536c*/ void set_Optional(bool value);
            /*0x2b25378*/ void set_GenerateProxy(bool value);
        }
    }
}
