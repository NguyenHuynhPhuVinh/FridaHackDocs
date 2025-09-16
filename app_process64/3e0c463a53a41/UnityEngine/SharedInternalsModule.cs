class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0x7f56834*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x7f56878*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x7f56880*/ WritableAttribute();
    }

    class RejectDragAndDropMaterial : System.Attribute
    {
        /*0x7f56888*/ RejectDragAndDropMaterial();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x7f56890*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x7f568a8*/ NativeClassAttribute(string qualifiedCppName);
        /*0x7f5692c*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x7f56898*/ void set_QualifiedNativeName(string value);
        /*0x7f568a0*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x7f56970*/ string Format(string fmt, object[] args);
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x7f569f8*/ VisibleToOtherModulesAttribute();
            /*0x7f56a00*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ string <StubReturnStatement>k__BackingField;
            /*0x20*/ bool <Enabled>k__BackingField;

            /*0x7f56a24*/ NativeConditionalAttribute(string condition);
            /*0x7f56a60*/ NativeConditionalAttribute(string condition, string stubReturnStatement);
            /*0x7f56a08*/ void set_Condition(string value);
            /*0x7f56a10*/ void set_StubReturnStatement(string value);
            /*0x7f56a18*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x7f56ab4*/ NativeHeaderAttribute(string header);
            /*0x7f56aac*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x7f56bc0*/ NativeNameAttribute(string name);
            /*0x7f56bb8*/ void set_Name(string value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x7f56cfc*/ NativeMethodAttribute();
            /*0x7f56d04*/ NativeMethodAttribute(string name);
            /*0x7f56e08*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x7f56e30*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x7f56cc4*/ void set_Name(string value);
            /*0x7f56ccc*/ void set_IsThreadSafe(bool value);
            /*0x7f56cd8*/ void set_IsFreeFunction(bool value);
            /*0x7f56ce4*/ void set_ThrowsException(bool value);
            /*0x7f56cf0*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1c*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x7f56e6c*/ NativePropertyAttribute();
            /*0x7f56e74*/ NativePropertyAttribute(string name);
            /*0x7f56e78*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x7f56ea8*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe);
            /*0x7f56e64*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x7f56eec*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x7f56f0c*/ NativeTypeAttribute();
            /*0x7f56f28*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x7f56f50*/ NativeTypeAttribute(string header);
            /*0x7f57058*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x7f56ef4*/ void set_Header(string value);
            /*0x7f56efc*/ void set_IntermediateScriptingStructName(string value);
            /*0x7f56f04*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x7f57090*/ NotNullAttribute();
        }

        class UnmarshalledAttribute : System.Attribute
        {
            /*0x7f57098*/ UnmarshalledAttribute();
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x7f570a0*/ FreeFunctionAttribute();
            /*0x7f570c0*/ FreeFunctionAttribute(string name);
            /*0x7f570dc*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x7f5710c*/ ThreadSafeAttribute();
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

            /*0x7f5713c*/ StaticAccessorAttribute(string name);
            /*0x7f5716c*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x7f5712c*/ void set_Name(string value);
            /*0x7f57134*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x7f571b4*/ NativeThrowsAttribute();
            /*0x7f571a8*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x7f571e0*/ IgnoreAttribute();
            /*0x7f571d4*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x7f571e8*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x7f571f0*/ UsedByNativeCodeAttribute();
            /*0x7f571f8*/ UsedByNativeCodeAttribute(string name);
            /*0x7f57228*/ void set_Name(string value);
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x7f57230*/ RequiredByNativeCodeAttribute();
            /*0x7f57238*/ RequiredByNativeCodeAttribute(string name);
            /*0x7f57268*/ RequiredByNativeCodeAttribute(bool optional);
            /*0x7f57294*/ void set_Name(string value);
            /*0x7f5729c*/ void set_Optional(bool value);
            /*0x7f572a8*/ void set_GenerateProxy(bool value);
        }
    }
}
