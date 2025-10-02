class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0xea2f90*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x534220*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x534220*/ WritableAttribute();
    }

    class RejectDragAndDropMaterial : System.Attribute
    {
        /*0x534220*/ RejectDragAndDropMaterial();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x534220*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x1654f20*/ NativeClassAttribute(string qualifiedCppName);
        /*0xea2f90*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x9f12f0*/ void set_QualifiedNativeName(string value);
        /*0x7963c0*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x1655660*/ string Format(string fmt, object[] args);
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x534220*/ VisibleToOtherModulesAttribute();
            /*0x534220*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ string <StubReturnStatement>k__BackingField;
            /*0x20*/ bool <Enabled>k__BackingField;

            /*0x1655000*/ NativeConditionalAttribute(string condition);
            /*0x1654fa0*/ NativeConditionalAttribute(string condition, string stubReturnStatement);
            /*0x9f12f0*/ void set_Condition(string value);
            /*0x7963c0*/ void set_StubReturnStatement(string value);
            /*0x7963b0*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x1655040*/ NativeHeaderAttribute(string header);
            /*0x9f12f0*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x16552d0*/ NativeNameAttribute(string name);
            /*0x9f12f0*/ void set_Name(string value);
        }

        class NativeWritableSelfAttribute : System.Attribute
        {
            /*0x10*/ bool <WritableSelf>k__BackingField;

            /*0x1655470*/ NativeWritableSelfAttribute();
            /*0x793ec0*/ void set_WritableSelf(bool value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x534220*/ NativeMethodAttribute();
            /*0x1655190*/ NativeMethodAttribute(string name);
            /*0x16552a0*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x1655150*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x9f12f0*/ void set_Name(string value);
            /*0xdd5230*/ void set_IsThreadSafe(bool value);
            /*0x10a6600*/ void set_IsFreeFunction(bool value);
            /*0x140b9c0*/ void set_ThrowsException(bool value);
            /*0x14efc20*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x20*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x534220*/ NativePropertyAttribute();
            /*0x16553e0*/ NativePropertyAttribute(string name);
            /*0x16553f0*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x1655430*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe);
            /*0x11172b0*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x534220*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x1655620*/ NativeTypeAttribute();
            /*0x16555b0*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x1655490*/ NativeTypeAttribute(string header);
            /*0x16555e0*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x9f12f0*/ void set_Header(string value);
            /*0x7963c0*/ void set_IntermediateScriptingStructName(string value);
            /*0x11172b0*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x10*/ string <Exception>k__BackingField;

            /*0xa32e30*/ NotNullAttribute(string exception);
            /*0x9f12f0*/ void set_Exception(string value);
        }

        class UnmarshalledAttribute : System.Attribute
        {
            /*0x534220*/ UnmarshalledAttribute();
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1654eb0*/ FreeFunctionAttribute();
            /*0x1654ed0*/ FreeFunctionAttribute(string name);
            /*0x1654ef0*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1655640*/ ThreadSafeAttribute();
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

            /*0xa32e30*/ StaticAccessorAttribute(string name);
            /*0xea64b0*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x9f12f0*/ void set_Name(string value);
            /*0x8a5c50*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x1655470*/ NativeThrowsAttribute();
            /*0x793ec0*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x534220*/ IgnoreAttribute();
            /*0x793ec0*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x534220*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x534220*/ UsedByNativeCodeAttribute();
            /*0xa32e30*/ UsedByNativeCodeAttribute(string name);
            /*0x9f12f0*/ void set_Name(string value);
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x534220*/ RequiredByNativeCodeAttribute();
            /*0xa32e30*/ RequiredByNativeCodeAttribute(string name);
            /*0x9f12f0*/ void set_Name(string value);
            /*0xdd5230*/ void set_Optional(bool value);
            /*0x10a6600*/ void set_GenerateProxy(bool value);
        }
    }
}
