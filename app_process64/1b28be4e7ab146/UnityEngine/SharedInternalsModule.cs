class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0x7f6dc64*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x7f6dca8*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x7f6dcb0*/ WritableAttribute();
    }

    class RejectDragAndDropMaterial : System.Attribute
    {
        /*0x7f6dcb8*/ RejectDragAndDropMaterial();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x7f6dcc0*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x7f6dcd8*/ NativeClassAttribute(string qualifiedCppName);
        /*0x7f6dd5c*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x7f6dcc8*/ void set_QualifiedNativeName(string value);
        /*0x7f6dcd0*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x7f6dda0*/ string Format(string fmt, object[] args);
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x7f6de28*/ VisibleToOtherModulesAttribute();
            /*0x7f6de30*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ string <StubReturnStatement>k__BackingField;
            /*0x20*/ bool <Enabled>k__BackingField;

            /*0x7f6de54*/ NativeConditionalAttribute(string condition);
            /*0x7f6de90*/ NativeConditionalAttribute(string condition, string stubReturnStatement);
            /*0x7f6de38*/ void set_Condition(string value);
            /*0x7f6de40*/ void set_StubReturnStatement(string value);
            /*0x7f6de48*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x7f6dee4*/ NativeHeaderAttribute(string header);
            /*0x7f6dedc*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x7f6dff0*/ NativeNameAttribute(string name);
            /*0x7f6dfe8*/ void set_Name(string value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x7f6e12c*/ NativeMethodAttribute();
            /*0x7f6e134*/ NativeMethodAttribute(string name);
            /*0x7f6e238*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x7f6e260*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x7f6e0f4*/ void set_Name(string value);
            /*0x7f6e0fc*/ void set_IsThreadSafe(bool value);
            /*0x7f6e108*/ void set_IsFreeFunction(bool value);
            /*0x7f6e114*/ void set_ThrowsException(bool value);
            /*0x7f6e120*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1c*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x7f6e29c*/ NativePropertyAttribute();
            /*0x7f6e2a4*/ NativePropertyAttribute(string name);
            /*0x7f6e2a8*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x7f6e2d8*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe);
            /*0x7f6e294*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x7f6e31c*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x7f6e33c*/ NativeTypeAttribute();
            /*0x7f6e358*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x7f6e380*/ NativeTypeAttribute(string header);
            /*0x7f6e488*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x7f6e324*/ void set_Header(string value);
            /*0x7f6e32c*/ void set_IntermediateScriptingStructName(string value);
            /*0x7f6e334*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x7f6e4c0*/ NotNullAttribute();
        }

        class UnmarshalledAttribute : System.Attribute
        {
            /*0x7f6e4c8*/ UnmarshalledAttribute();
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x7f6e4d0*/ FreeFunctionAttribute();
            /*0x7f6e4f0*/ FreeFunctionAttribute(string name);
            /*0x7f6e50c*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x7f6e53c*/ ThreadSafeAttribute();
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

            /*0x7f6e56c*/ StaticAccessorAttribute(string name);
            /*0x7f6e59c*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x7f6e55c*/ void set_Name(string value);
            /*0x7f6e564*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x7f6e5e4*/ NativeThrowsAttribute();
            /*0x7f6e5d8*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x7f6e610*/ IgnoreAttribute();
            /*0x7f6e604*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x7f6e618*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x7f6e620*/ UsedByNativeCodeAttribute();
            /*0x7f6e628*/ UsedByNativeCodeAttribute(string name);
            /*0x7f6e658*/ void set_Name(string value);
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x7f6e660*/ RequiredByNativeCodeAttribute();
            /*0x7f6e668*/ RequiredByNativeCodeAttribute(string name);
            /*0x7f6e698*/ RequiredByNativeCodeAttribute(bool optional);
            /*0x7f6e6c4*/ void set_Name(string value);
            /*0x7f6e6cc*/ void set_Optional(bool value);
            /*0x7f6e6d8*/ void set_GenerateProxy(bool value);
        }
    }
}
