class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0x14fa104*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x14fa130*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x14fa138*/ WritableAttribute();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x14fa140*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x14fa158*/ NativeClassAttribute(string qualifiedCppName);
        /*0x14fa1c8*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x14fa148*/ void set_QualifiedNativeName(string value);
        /*0x14fa150*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x14fa1f4*/ string Format(string fmt, object[] args);
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x14fa27c*/ UsedByNativeCodeAttribute();
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x14fa284*/ RequiredByNativeCodeAttribute();
            /*0x14fa28c*/ RequiredByNativeCodeAttribute(string name);
            /*0x14fa2b4*/ void set_Name(string value);
            /*0x14fa2bc*/ void set_Optional(bool value);
            /*0x14fa2c8*/ void set_GenerateProxy(bool value);
        }
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x14fa2d4*/ VisibleToOtherModulesAttribute();
            /*0x14fa2dc*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ bool <Enabled>k__BackingField;

            /*0x14fa2f8*/ NativeConditionalAttribute(string condition);
            /*0x14fa2e4*/ void set_Condition(string value);
            /*0x14fa2ec*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x14fa330*/ NativeHeaderAttribute(string header);
            /*0x14fa328*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x14fa43c*/ NativeNameAttribute(string name);
            /*0x14fa434*/ void set_Name(string value);
        }

        class NativeWritableSelfAttribute : System.Attribute
        {
            /*0x10*/ bool <WritableSelf>k__BackingField;

            /*0x14fa54c*/ NativeWritableSelfAttribute();
            /*0x14fa540*/ void set_WritableSelf(bool value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x14fa5a4*/ NativeMethodAttribute();
            /*0x14fa5ac*/ NativeMethodAttribute(string name);
            /*0x14fa6b0*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x14fa6d8*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x14fa56c*/ void set_Name(string value);
            /*0x14fa574*/ void set_IsThreadSafe(bool value);
            /*0x14fa580*/ void set_IsFreeFunction(bool value);
            /*0x14fa58c*/ void set_ThrowsException(bool value);
            /*0x14fa598*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1c*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x14fa714*/ NativePropertyAttribute();
            /*0x14fa71c*/ NativePropertyAttribute(string name);
            /*0x14fa720*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x14fa750*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe);
            /*0x14fa70c*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x14fa794*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x14fa7b4*/ NativeTypeAttribute();
            /*0x14fa7d0*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x14fa7f8*/ NativeTypeAttribute(string header);
            /*0x14fa900*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x14fa79c*/ void set_Header(string value);
            /*0x14fa7a4*/ void set_IntermediateScriptingStructName(string value);
            /*0x14fa7ac*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x10*/ string <Exception>k__BackingField;

            /*0x14fa938*/ NotNullAttribute(string exception);
            /*0x14fa930*/ void set_Exception(string value);
        }

        class UnmarshalledAttribute : System.Attribute
        {
            /*0x14fa960*/ UnmarshalledAttribute();
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x14fa968*/ FreeFunctionAttribute();
            /*0x14fa988*/ FreeFunctionAttribute(string name);
            /*0x14fa9a4*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x14fa9d4*/ ThreadSafeAttribute();
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

            /*0x14faa04*/ StaticAccessorAttribute(string name);
            /*0x14faa2c*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x14fa9f4*/ void set_Name(string value);
            /*0x14fa9fc*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x14faa68*/ NativeThrowsAttribute();
            /*0x14faa5c*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x14faa94*/ IgnoreAttribute();
            /*0x14faa88*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x14faa9c*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }
}
