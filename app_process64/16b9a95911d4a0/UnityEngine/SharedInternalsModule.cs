class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0x3e952a8*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x3e952ec*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x3e952f4*/ WritableAttribute();
    }

    class RejectDragAndDropMaterial : System.Attribute
    {
        /*0x3e952fc*/ RejectDragAndDropMaterial();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x3e95304*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x3e9531c*/ NativeClassAttribute(string qualifiedCppName);
        /*0x3e953a0*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x3e9530c*/ void set_QualifiedNativeName(string value);
        /*0x3e95314*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x3e953e4*/ string Format(string fmt, object[] args);
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x3e9546c*/ VisibleToOtherModulesAttribute();
            /*0x3e95474*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ bool <Enabled>k__BackingField;

            /*0x3e9548c*/ NativeConditionalAttribute(string condition);
            /*0x3e9547c*/ void set_Condition(string value);
            /*0x3e95484*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x3e954d0*/ NativeHeaderAttribute(string header);
            /*0x3e954c8*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x3e955dc*/ NativeNameAttribute(string name);
            /*0x3e955d4*/ void set_Name(string value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x3e95708*/ NativeMethodAttribute();
            /*0x3e95710*/ NativeMethodAttribute(string name);
            /*0x3e95814*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x3e95838*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x3e956e0*/ void set_Name(string value);
            /*0x3e956e8*/ void set_IsThreadSafe(bool value);
            /*0x3e956f0*/ void set_IsFreeFunction(bool value);
            /*0x3e956f8*/ void set_ThrowsException(bool value);
            /*0x3e95700*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1c*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x3e9586c*/ NativePropertyAttribute();
            /*0x3e95874*/ NativePropertyAttribute(string name);
            /*0x3e95878*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x3e958a4*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe);
            /*0x3e95864*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x3e958e0*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x3e95900*/ NativeTypeAttribute();
            /*0x3e9591c*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x3e95944*/ NativeTypeAttribute(string header);
            /*0x3e95a4c*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x3e958e8*/ void set_Header(string value);
            /*0x3e958f0*/ void set_IntermediateScriptingStructName(string value);
            /*0x3e958f8*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x3e95a84*/ NotNullAttribute();
        }

        class UnmarshalledAttribute : System.Attribute
        {
            /*0x3e95a8c*/ UnmarshalledAttribute();
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x3e95a94*/ FreeFunctionAttribute();
            /*0x3e95ab4*/ FreeFunctionAttribute(string name);
            /*0x3e95ad0*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x3e95afc*/ ThreadSafeAttribute();
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

            /*0x3e95b2c*/ StaticAccessorAttribute(string name);
            /*0x3e95b5c*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x3e95b1c*/ void set_Name(string value);
            /*0x3e95b24*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x3e95ba0*/ NativeThrowsAttribute();
            /*0x3e95b98*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x3e95bc8*/ IgnoreAttribute();
            /*0x3e95bc0*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x3e95bd0*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x3e95bd8*/ UsedByNativeCodeAttribute();
            /*0x3e95be0*/ UsedByNativeCodeAttribute(string name);
            /*0x3e95c10*/ void set_Name(string value);
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x3e95c18*/ RequiredByNativeCodeAttribute();
            /*0x3e95c20*/ RequiredByNativeCodeAttribute(string name);
            /*0x3e95c50*/ RequiredByNativeCodeAttribute(bool optional);
            /*0x3e95c78*/ void set_Name(string value);
            /*0x3e95c80*/ void set_Optional(bool value);
            /*0x3e95c88*/ void set_GenerateProxy(bool value);
        }
    }
}
