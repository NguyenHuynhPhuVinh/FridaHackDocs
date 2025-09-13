class <Module>
{
}

namespace Microsoft
{
    namespace CSharp
    {
        namespace RuntimeBinder
        {
            class Binder
            {
            }

            class CSharpArgumentInfo
            {
                static /*0x0*/ Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo None;
                /*0x10*/ Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags <Flags>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;

                static /*0x2b3a818*/ CSharpArgumentInfo();
                /*0x2b3a7dc*/ CSharpArgumentInfo(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags flags, string name);
            }

            enum CSharpArgumentInfoFlags
            {
                None = 0,
                UseCompileTimeType = 1,
                Constant = 2,
                NamedArgument = 4,
                IsRef = 8,
                IsOut = 16,
                IsStaticType = 32,
            }

            enum CSharpBinderFlags
            {
                None = 0,
                CheckedContext = 1,
                InvokeSimpleName = 2,
                InvokeSpecialName = 4,
                BinaryOperationLogical = 8,
                ConvertExplicit = 16,
                ConvertArrayIndex = 32,
                ResultIndexed = 64,
                ValueFromCompoundAssignment = 128,
                ResultDiscarded = 256,
            }
        }
    }
}
