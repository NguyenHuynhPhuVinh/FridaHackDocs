class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x534220*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x534220*/ IsUnmanagedAttribute();
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x1142840*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Unity
{
    namespace Burst
    {
        enum OptimizeFor
        {
            Default = 0,
            Performance = 1,
            Size = 2,
            FastCompilation = 3,
            Balanced = 4,
        }

        enum FloatMode
        {
            Default = 0,
            Strict = 1,
            Deterministic = 2,
            Fast = 3,
        }

        enum FloatPrecision
        {
            Standard = 0,
            High = 1,
            Medium = 2,
            Low = 3,
        }

        class BurstCompileAttribute : System.Attribute
        {
            /*0x10*/ Unity.Burst.FloatMode <FloatMode>k__BackingField;
            /*0x14*/ Unity.Burst.FloatPrecision <FloatPrecision>k__BackingField;
            /*0x18*/ System.Nullable<bool> _compileSynchronously;
            /*0x1a*/ System.Nullable<bool> _debug;
            /*0x1c*/ System.Nullable<bool> _disableSafetyChecks;
            /*0x1e*/ System.Nullable<bool> _disableDirectCall;
            /*0x20*/ Unity.Burst.OptimizeFor <OptimizeFor>k__BackingField;
            /*0x28*/ string[] <Options>k__BackingField;

            /*0x534220*/ BurstCompileAttribute();
            /*0x1116f70*/ BurstCompileAttribute(Unity.Burst.FloatPrecision floatPrecision, Unity.Burst.FloatMode floatMode);
            /*0x1116f30*/ BurstCompileAttribute(string[] options);
            /*0x417e30*/ Unity.Burst.FloatMode get_FloatMode();
            /*0xdcd9c0*/ void set_FloatMode(Unity.Burst.FloatMode value);
            /*0x70a440*/ Unity.Burst.FloatPrecision get_FloatPrecision();
            /*0xc70b20*/ void set_FloatPrecision(Unity.Burst.FloatPrecision value);
            /*0x1116fb0*/ bool get_CompileSynchronously();
            /*0x1117130*/ void set_CompileSynchronously(bool value);
            /*0x1117010*/ bool get_Debug();
            /*0x1117190*/ void set_Debug(bool value);
            /*0x11170d0*/ bool get_DisableSafetyChecks();
            /*0x1117250*/ void set_DisableSafetyChecks(bool value);
            /*0x1117070*/ bool get_DisableDirectCall();
            /*0x11171f0*/ void set_DisableDirectCall(bool value);
            /*0x3e3af0*/ Unity.Burst.OptimizeFor get_OptimizeFor();
            /*0x11172b0*/ void set_OptimizeFor(Unity.Burst.OptimizeFor value);
            /*0x79a150*/ string[] get_Options();
            /*0x98b030*/ void set_Options(string[] value);
        }

        class BurstCompiler
        {
            static /*0x0*/ bool _IsEnabled;
            static /*0x8*/ Unity.Burst.BurstCompilerOptions Options;
            static /*0x10*/ System.Action OnCompileILPPMethod2;
            static /*0x18*/ System.Reflection.MethodInfo DummyMethodInfo;
            [ThreadStatic] static Unity.Burst.BurstCompiler.CommandBuilder _cmdBuilder;

            static /*0x111ba00*/ BurstCompiler();
            static /*0x111b060*/ bool IsLoadAdditionalLibrarySupported();
            static /*0x111a0d0*/ Unity.Burst.BurstCompiler.CommandBuilder BeginCompilerCommand(string cmd);
            static /*0x111bc20*/ bool get_IsEnabled();
            static /*0x111b570*/ void SetExecutionMode(Unity.Burst.BurstExecutionEnvironment mode);
            static /*0x111ac70*/ Unity.Burst.BurstExecutionEnvironment GetExecutionMode();
            static /*0x2a5510*/ T CompileDelegate<T>(T delegateMethod);
            static /*0x2a5510*/ void VerifyDelegateIsNotMulticast<T>(T delegateMethod);
            static /*0x2a5510*/ void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute<T>(T delegateMethod);
            static /*0x111a3e0*/ nint CompileILPPMethod(System.RuntimeMethodHandle burstMethodHandle, System.RuntimeMethodHandle managedMethodHandle, System.RuntimeTypeHandle delegateTypeHandle);
            static /*0x111a240*/ nint CompileILPPMethod2(System.RuntimeMethodHandle burstMethodHandle);
            static /*0x111adc0*/ void* GetILPPMethodFunctionPointer(nint ilppMethod);
            static /*0x111ac80*/ void* GetILPPMethodFunctionPointer2(nint ilppMethod, System.RuntimeMethodHandle managedMethodHandle, System.RuntimeTypeHandle delegateTypeHandle);
            static /*0x111a420*/ void* CompileUnsafeStaticMethod(System.RuntimeMethodHandle handle);
            static /*0x2a5510*/ Unity.Burst.FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod);
            static /*0x111ab20*/ void* Compile(object delegateObj, bool isFunctionPointer);
            static /*0x111a460*/ void* Compile(object delegateObj, System.Reflection.MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing);
            static /*0x32d010*/ void Shutdown();
            static /*0x32d010*/ void Cancel();
            static /*0x3ce290*/ bool IsCurrentCompilationDone();
            static /*0x32d010*/ void Enable();
            static /*0x32d010*/ void Disable();
            static /*0x348b00*/ bool IsHostEditorArm();
            static /*0x111b580*/ void TriggerUnsafeStaticMethodRecompilation();
            static /*0x32d010*/ void TriggerRecompilation();
            static /*0x111b920*/ void UnloadAdditionalLibraries();
            static /*0x111ae00*/ void InitialiseDebuggerHooks();
            static /*0x111afe0*/ bool IsApiAvailable(string apiName);
            static /*0x111b0c0*/ int RequestSetProtocolVersion(int version);
            static /*0x32d010*/ void Initialize(string[] assemblyFolders, string[] ignoreAssemblies);
            static /*0x32d010*/ void NotifyCompilationStarted(string[] assemblyFolders, string[] ignoreAssemblies);
            static /*0x32d010*/ void NotifyAssemblyCompilationNotRequired(string assemblyName);
            static /*0x32d010*/ void NotifyAssemblyCompilationFinished(string assemblyName, string[] defines);
            static /*0x32d010*/ void NotifyCompilationFinished();
            static /*0x111a0a0*/ string AotCompilation(string[] assemblyFolders, string[] assemblyRoots, string options);
            static /*0x32d010*/ void SetProfilerCallbacks();
            static /*0x111b4c0*/ string SendRawCommandToCompiler(string command);
            static /*0x111b200*/ string SendCommandToCompiler(string commandName, string commandArgs);
            static /*0x32d010*/ void DummyMethod();

            class CommandBuilder
            {
                /*0x10*/ System.Text.StringBuilder _builder;
                /*0x18*/ bool _hasArgs;

                /*0x11216d0*/ CommandBuilder();
                /*0x11214f0*/ Unity.Burst.BurstCompiler.CommandBuilder Begin(string cmd);
                /*0x1121670*/ Unity.Burst.BurstCompiler.CommandBuilder With(string arg);
                /*0x11215b0*/ Unity.Burst.BurstCompiler.CommandBuilder With(nint arg);
                /*0x11214c0*/ Unity.Burst.BurstCompiler.CommandBuilder And(char sep);
                /*0x1121540*/ string SendToCompiler();
            }

            class StaticTypeReinitAttribute : System.Attribute
            {
                /*0x10*/ System.Type reinitType;

                /*0xa32e30*/ StaticTypeReinitAttribute(System.Type toReinit);
            }

            class BurstCompilerHelper
            {
                static /*0x0*/ Unity.Burst.BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate IsBurstEnabledImpl;
                static /*0x8*/ bool IsBurstGenerated;

                static /*0x1117360*/ BurstCompilerHelper();
                static /*0x11172c0*/ bool IsBurstEnabled();
                static /*0xe24e60*/ void DiscardedMethod(ref bool value);
                static /*0x1117300*/ bool IsCompiledByBurst(System.Delegate del);

                class IsBurstEnabledDelegate : System.MulticastDelegate
                {
                    /*0x9dc0f0*/ IsBurstEnabledDelegate(object object, nint method);
                    /*0x9dbe20*/ bool Invoke();
                    /*0x1121b60*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0xa75650*/ bool EndInvoke(System.IAsyncResult result);
                }
            }

            class FakeDelegate
            {
                /*0x10*/ System.Reflection.MethodInfo <Method>k__BackingField;

                /*0x49b490*/ FakeDelegate(System.Reflection.MethodInfo method);
                /*0x73d3e0*/ System.Reflection.MethodInfo get_Method();
            }

            class <>c
            {
                static /*0x0*/ Unity.Burst.BurstCompiler.<> <>9;
                static /*0x8*/ System.Func<System.Attribute, bool> <>9__22_0;
                static /*0x10*/ System.Func<System.Attribute, bool> <>9__29_0;

                static /*0x11427d0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x11426f0*/ bool <Compile>b__22_0(System.Attribute s);
                /*0x1142760*/ bool <TriggerUnsafeStaticMethodRecompilation>b__29_0(System.Attribute x);
            }
        }

        enum GlobalSafetyChecksSettingKind
        {
            Off = 0,
            On = 1,
            ForceOn = 2,
        }

        class BurstCompilerOptions
        {
            static string DisableCompilationArg = "--burst-disable-compilation";
            static string ForceSynchronousCompilationArg = "--burst-force-sync-compilation";
            static string DefaultLibraryName = "lib_burst_generated";
            static string BurstInitializeName = "burst.initialize";
            static string BurstInitializeExternalsName = "burst.initialize.externals";
            static string BurstInitializeStaticsName = "burst.initialize.statics";
            static string OptionBurstcSwitch = "+burstc";
            static string OptionGroup = "group";
            static string OptionPlatform = "platform=";
            static string OptionBackend = "backend=";
            static string OptionGlobalSafetyChecksSetting = "global-safety-checks-setting=";
            static string OptionDisableSafetyChecks = "disable-safety-checks";
            static string OptionDisableOpt = "disable-opt";
            static string OptionFastMath = "fastmath";
            static string OptionTarget = "target=";
            static string OptionOptLevel = "opt-level=";
            static string OptionLogTimings = "log-timings";
            static string OptionOptForSize = "opt-for-size";
            static string OptionFloatPrecision = "float-precision=";
            static string OptionFloatMode = "float-mode=";
            static string OptionBranchProtection = "branch-protection=";
            static string OptionDisableWarnings = "disable-warnings=";
            static string OptionAssemblyDefines = "assembly-defines=";
            static string OptionDump = "dump=";
            static string OptionFormat = "format=";
            static string OptionDebugTrap = "debugtrap";
            static string OptionDisableVectors = "disable-vectors";
            static string OptionDebug = "debug=";
            static string OptionDebugMode = "debugMode";
            static string OptionStaticLinkage = "generate-static-linkage-methods";
            static string OptionJobMarshalling = "generate-job-marshalling-methods";
            static string OptionTempDirectory = "temp-folder=";
            static string OptionEnableDirectExternalLinking = "enable-direct-external-linking";
            static string OptionLinkerOptions = "linker-options=";
            static string OptionEnableAutoLayoutFallbackCheck = "enable-autolayout-fallback-check";
            static string OptionGenerateLinkXml = "generate-link-xml=";
            static string OptionMetaDataGeneration = "meta-data-generation=";
            static string OptionDisableStringInterpolationInExceptionMessages = "disable-string-interpolation-in-exception-messages";
            static string OptionPlatformConfiguration = "platform-configuration=";
            static string OptionStackProtector = "stack-protector=";
            static string OptionStackProtectorBufferSize = "stack-protector-buffer-size=";
            static string OptionCacheDirectory = "cache-directory=";
            static string OptionJitDisableFunctionCaching = "disable-function-caching";
            static string OptionJitDisableAssemblyCaching = "disable-assembly-caching";
            static string OptionJitEnableAssemblyCachingLogs = "enable-assembly-caching-logs";
            static string OptionJitEnableSynchronousCompilation = "enable-synchronous-compilation";
            static string OptionJitCompilationPriority = "compilation-priority=";
            static string OptionJitIsForFunctionPointer = "is-for-function-pointer";
            static string OptionJitManagedFunctionPointer = "managed-function-pointer=";
            static string OptionJitManagedDelegateHandle = "managed-delegate-handle=";
            static string OptionEnableInterpreter = "enable-interpreter";
            static string OptionAotAssemblyFolder = "assembly-folder=";
            static string OptionRootAssembly = "root-assembly=";
            static string OptionIncludeRootAssemblyReferences = "include-root-assembly-references=";
            static string OptionAotMethod = "method=";
            static string OptionAotType = "type=";
            static string OptionAotAssembly = "assembly=";
            static string OptionAotOutputPath = "output=";
            static string OptionAotKeepIntermediateFiles = "keep-intermediate-files";
            static string OptionAotNoLink = "nolink";
            static string OptionAotOnlyStaticMethods = "only-static-methods";
            static string OptionMethodPrefix = "method-prefix=";
            static string OptionAotNoNativeToolchain = "no-native-toolchain";
            static string OptionAotEmitLlvmObjects = "emit-llvm-objects";
            static string OptionAotKeyFolder = "key-folder=";
            static string OptionAotDecodeFolder = "decode-folder=";
            static string OptionVerbose = "verbose";
            static string OptionValidateExternalToolChain = "validate-external-tool-chain";
            static string OptionCompilerThreads = "threads=";
            static string OptionChunkSize = "chunk-size=";
            static string OptionPrintLogOnMissingPInvokeCallbackAttribute = "print-monopinvokecallbackmissing-message";
            static string OptionOutputMode = "output-mode=";
            static string OptionAlwaysCreateOutput = "always-create-output=";
            static string OptionAotPdbSearchPaths = "pdb-search-paths=";
            static string OptionSafetyChecks = "safety-checks";
            static string OptionLibraryOutputMode = "library-output-mode=";
            static string OptionCompilationId = "compilation-id=";
            static string OptionTargetFramework = "target-framework=";
            static string OptionDiscardAssemblies = "discard-assemblies=";
            static string OptionSaveExtraContext = "save-extra-context";
            static string CompilerCommandShutdown = "$shutdown";
            static string CompilerCommandCancel = "$cancel";
            static string CompilerCommandEnableCompiler = "$enable_compiler";
            static string CompilerCommandDisableCompiler = "$disable_compiler";
            static string CompilerCommandSetDefaultOptions = "$set_default_options";
            static string CompilerCommandTriggerSetupRecompilation = "$trigger_setup_recompilation";
            static string CompilerCommandIsCurrentCompilationDone = "$is_current_compilation_done";
            static string CompilerCommandTriggerRecompilation = "$trigger_recompilation";
            static string CompilerCommandInitialize = "$initialize";
            static string CompilerCommandDomainReload = "$domain_reload";
            static string CompilerCommandVersionNotification = "$version";
            static string CompilerCommandGetTargetCpuFromHost = "$get_target_cpu_from_host";
            static string CompilerCommandSetProfileCallbacks = "$set_profile_callbacks";
            static string CompilerCommandUnloadBurstNatives = "$unload_burst_natives";
            static string CompilerCommandIsNativeApiAvailable = "$is_native_api_available";
            static string CompilerCommandILPPCompilation = "$ilpp_compilation";
            static string CompilerCommandIsArmTestEnv = "$is_arm_test_env";
            static string CompilerCommandNotifyAssemblyCompilationNotRequired = "$notify_assembly_compilation_not_required";
            static string CompilerCommandNotifyAssemblyCompilationFinished = "$notify_assembly_compilation_finished";
            static string CompilerCommandNotifyCompilationStarted = "$notify_compilation_started";
            static string CompilerCommandNotifyCompilationFinished = "$notify_compilation_finished";
            static string CompilerCommandAotCompilation = "$aot_compilation";
            static string CompilerCommandRequestInitialiseDebuggerCommmand = "$request_debug_command";
            static string CompilerCommandInitialiseDebuggerCommmand = "$load_debugger_interface";
            static string CompilerCommandRequestSetProtocolVersionEditor = "$request_set_protocol_version_editor";
            static string CompilerCommandSetProtocolVersionBurst = "$set_protocol_version_burst";
            static /*0x0*/ bool ForceDisableBurstCompilation;
            static /*0x1*/ bool ForceBurstCompilationSynchronously;
            static /*0x2*/ bool IsSecondaryUnityProcess;
            /*0x10*/ bool _enableBurstCompilation;
            /*0x11*/ bool _enableBurstCompileSynchronously;
            /*0x12*/ bool _enableBurstSafetyChecks;
            /*0x13*/ bool _enableBurstTimings;
            /*0x14*/ bool _enableBurstDebug;
            /*0x15*/ bool _forceEnableBurstSafetyChecks;
            /*0x16*/ bool <IsGlobal>k__BackingField;
            /*0x18*/ System.Action <OptionsChanged>k__BackingField;

            static /*0x1119ad0*/ BurstCompilerOptions();
            static /*0x1119560*/ string SerialiseCompilationOptionsSafe(string[] roots, string[] folders, string options);
            static /*0x1117830*/ System.ValueTuple<System.String[], System.String[], string> DeserialiseCompilationOptionsSafe(string from);
            static /*0x1119640*/ bool TryGetAttribute(System.Reflection.MemberInfo member, ref Unity.Burst.BurstCompileAttribute attribute);
            static /*0x11196e0*/ bool TryGetAttribute(System.Reflection.Assembly assembly, ref Unity.Burst.BurstCompileAttribute attribute);
            static /*0x11178f0*/ Unity.Burst.BurstCompileAttribute GetBurstCompileAttribute(System.Reflection.MemberInfo memberInfo);
            static /*0x11192b0*/ bool HasBurstCompileAttribute(System.Reflection.MemberInfo member);
            static /*0x11193e0*/ void MergeAttributes(ref Unity.Burst.BurstCompileAttribute memberAttribute, ref Unity.Burst.BurstCompileAttribute assemblyAttribute);
            static /*0x11174e0*/ void AddOption(System.Text.StringBuilder builder, string option);
            static /*0x1117ba0*/ string GetOption(string optionName, object value);
            static /*0x348b00*/ bool CheckIsSecondaryUnityProcess();
            /*0x1119c30*/ BurstCompilerOptions();
            /*0x1119d50*/ BurstCompilerOptions(bool isGlobal);
            /*0x1119e40*/ bool get_IsGlobal();
            /*0x1119dd0*/ bool get_IsEnabled();
            /*0x793eb0*/ bool get_EnableBurstCompilation();
            /*0x1119ec0*/ void set_EnableBurstCompilation(bool value);
            /*0xf26f80*/ bool get_EnableBurstCompileSynchronously();
            /*0x1119fb0*/ void set_EnableBurstCompileSynchronously(bool value);
            /*0x1119db0*/ bool get_EnableBurstSafetyChecks();
            /*0x111a010*/ void set_EnableBurstSafetyChecks(bool value);
            /*0xe29370*/ bool get_ForceEnableBurstSafetyChecks();
            /*0x111a070*/ void set_ForceEnableBurstSafetyChecks(bool value);
            /*0x8b9820*/ bool get_EnableBurstDebug();
            /*0x1119fe0*/ void set_EnableBurstDebug(bool value);
            /*0x348b00*/ bool get_DisableOptimizations();
            /*0x32d010*/ void set_DisableOptimizations(bool value);
            /*0x3ce290*/ bool get_EnableFastMath();
            /*0x32d010*/ void set_EnableFastMath(bool value);
            /*0x1119dc0*/ bool get_EnableBurstTimings();
            /*0x111a040*/ void set_EnableBurstTimings(bool value);
            /*0x1119e50*/ bool get_RequiresSynchronousCompilation();
            /*0x32f410*/ System.Action get_OptionsChanged();
            /*0x7963c0*/ void set_OptionsChanged(System.Action value);
            /*0x1117530*/ Unity.Burst.BurstCompilerOptions Clone();
            /*0x1119770*/ bool TryGetOptions(System.Reflection.MemberInfo member, ref string flagsOut, bool isForILPostProcessing, bool isForCompilerClient);
            /*0x1117c90*/ string GetOptions(Unity.Burst.BurstCompileAttribute attr, bool isForILPostProcessing, bool isForCompilerClient);
            /*0x1119540*/ void OnOptionsChanged();
            /*0x32d010*/ void MaybeTriggerRecompilation();
        }

        enum BurstTargetCpu
        {
            Auto = 0,
            X86_SSE2 = 1,
            X86_SSE4 = 2,
            X64_SSE2 = 3,
            X64_SSE4 = 4,
            AVX = 5,
            AVX2 = 6,
            WASM32 = 7,
            ARMV7A_NEON32 = 8,
            ARMV8A_AARCH64 = 9,
            THUMB2_NEON32 = 10,
            ARMV8A_AARCH64_HALFFP = 11,
            ARMV9A = 12,
        }

        enum NativeDumpFlags
        {
            None = 0,
            IL = 1,
            Unused = 2,
            IR = 4,
            IROptimized = 8,
            Asm = 16,
            Function = 32,
            Analysis = 64,
            IRPassAnalysis = 128,
            ILPre = 256,
            IRPerEntryPoint = 512,
            All = 1021,
        }

        enum CompilationPriority
        {
            EagerCompilationSynchronous = 0,
            Asynchronous = 1,
            ILPP = 2,
            EagerCompilationAsynchronous = 3,
        }

        enum BurstExecutionEnvironment
        {
            Default = 0,
            NonDeterministic = 0,
            Deterministic = 1,
        }

        class BurstRuntime
        {
            static /*0x1809b0*/ int GetHashCode32<T>();
            static /*0x111bcb0*/ int GetHashCode32(System.Type type);
            static /*0x180cf0*/ long GetHashCode64<T>();
            static /*0x111bd40*/ long GetHashCode64(System.Type type);
            static /*0x111be30*/ int HashStringWithFNV1A32(string text);
            static /*0x111bea0*/ long HashStringWithFNV1A64(string text);
            static /*0x111c090*/ bool LoadAdditionalLibrary(string pathToLibBurstGenerated);
            static /*0x111bf30*/ bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated);
            static /*0x111c380*/ void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber);
            static /*0x32d010*/ void Initialize();
            static /*0x111c2a0*/ void PreventRequiredAttributeStrip();
            static /*0x111c270*/ void Log(byte* message, int logType, byte* fileName, int lineNumber);
            static /*0x111bde0*/ byte* GetUTF8LiteralPointer(string str, ref int byteCount);

            struct HashCode32<T>
            {
                static /*0x0*/ int Value;

                static /*0x180ff0*/ HashCode32();
            }

            struct HashCode64<T>
            {
                static /*0x0*/ long Value;

                static /*0x180ff0*/ HashCode64();
            }

            class PreserveAttribute : System.Attribute
            {
                /*0x534220*/ PreserveAttribute();
            }
        }

        class BurstString
        {
            static int SinglePrecision = 9;
            static int DoublePrecision = 17;
            static int SingleNumberBufferLength = 10;
            static int DoubleNumberBufferLength = 18;
            static int SinglePrecisionCustomFormat = 7;
            static int DoublePrecisionCustomFormat = 15;
            static /*0x0*/ char[] SplitByColon;
            static /*0x8*/ byte[] logTable;
            static /*0x10*/ uint[] g_PowerOf10_U32;
            static /*0x18*/ byte[] InfinityString;
            static /*0x20*/ byte[] NanString;

            static /*0x11210c0*/ BurstString();
            static /*0x111dba0*/ void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength);
            static /*0x11200a0*/ void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw);
            static /*0x11204f0*/ void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw);
            static /*0x1120220*/ void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw);
            static /*0x11202a0*/ void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw);
            static /*0x111fb10*/ void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw);
            static /*0x1120570*/ void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw);
            static /*0x111fd70*/ void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw);
            static /*0x11201a0*/ void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw);
            static /*0x111fcf0*/ void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw);
            static /*0x111fe30*/ void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw);
            static /*0x111ffd0*/ void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw);
            static /*0x111ff00*/ void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw);
            static /*0x1120420*/ void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw);
            static /*0x111d9f0*/ void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, Unity.Burst.BurstString.FormatOptions options);
            static /*0x1120770*/ int GetLengthIntegerToString(long value, int basis, int zeroPadding);
            static /*0x111d830*/ void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, Unity.Burst.BurstString.FormatOptions options);
            static /*0x111f330*/ void FormatNumber(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits, Unity.Burst.BurstString.FormatOptions options);
            static /*0x111ef00*/ void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int zeroPadding, bool outputPositiveSign);
            static /*0x1121090*/ byte ValueToIntegerChar(int value, bool uppercase);
            static /*0x1120910*/ void OptsSplit(string fullFormat, ref string padding, ref string format);
            static /*0x1120ae0*/ Unity.Burst.BurstString.FormatOptions ParseFormatToFormatOptions(string fullFormat);
            static /*0x111c3f0*/ bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length);
            static /*0x111c3b0*/ bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length);
            static /*0x1120630*/ int GetLengthForFormatGeneral(ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits);
            static /*0x111efb0*/ void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits, byte expChar);
            static /*0x1120f40*/ void RoundNumber(ref Unity.Burst.BurstString.NumberBuffer number, int pos, bool isCorrectlyRounded);
            static /*0x1121060*/ bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded);
            static /*0x11207a0*/ uint LogBase2(uint val);
            static /*0x111c5f0*/ int BigInt_Compare(ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x111c560*/ void BigInt_Add(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x111c490*/ void BigInt_Add_internal(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt pLarge, ref Unity.Burst.BurstString.tBigInt pSmall);
            static /*0x111cdd0*/ void BigInt_Multiply(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x111cc50*/ void BigInt_Multiply_internal(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt pLarge, ref Unity.Burst.BurstString.tBigInt pSmall);
            static /*0x111cd50*/ void BigInt_Multiply(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, uint rhs);
            static /*0x111c870*/ void BigInt_Multiply2(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt input);
            static /*0x111c8e0*/ void BigInt_Multiply2(ref Unity.Burst.BurstString.tBigInt pResult);
            static /*0x111c830*/ void BigInt_Multiply10(ref Unity.Burst.BurstString.tBigInt pResult);
            static /*0x11212f0*/ Unity.Burst.BurstString.tBigInt g_PowerOf10_Big(int i);
            static /*0x111ce60*/ void BigInt_Pow10(ref Unity.Burst.BurstString.tBigInt pResult, uint exponent);
            static /*0x111c930*/ void BigInt_MultiplyPow10(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt input, uint exponent);
            static /*0x111d0d0*/ void BigInt_Pow2(ref Unity.Burst.BurstString.tBigInt pResult, uint exponent);
            static /*0x111c650*/ uint BigInt_DivideWithRemainder_MaxQuotient9(ref Unity.Burst.BurstString.tBigInt pDividend, ref Unity.Burst.BurstString.tBigInt divisor);
            static /*0x111d130*/ void BigInt_ShiftLeft(ref Unity.Burst.BurstString.tBigInt pResult, uint shift);
            static /*0x111dbd0*/ uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, Unity.Burst.BurstString.CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, ref int pOutExponent);
            static /*0x111f6e0*/ int FormatPositional(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision);
            static /*0x111f8e0*/ int FormatScientific(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision);
            static /*0x111f140*/ void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, Unity.Burst.BurstString.FormatOptions formatOptions);
            static /*0x111d590*/ void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, Unity.Burst.BurstString.FormatOptions formatOptions);
            static /*0x111d2d0*/ void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, Unity.Burst.BurstString.FormatOptions formatOptions);

            class PreserveAttribute : System.Attribute
            {
                /*0x534220*/ PreserveAttribute();
            }

            enum NumberBufferKind
            {
                Integer = 0,
                Float = 1,
            }

            struct NumberBuffer
            {
                /*0x10*/ byte* _buffer;
                /*0x18*/ Unity.Burst.BurstString.NumberBufferKind Kind;
                /*0x1c*/ int DigitsCount;
                /*0x20*/ int Scale;
                /*0x24*/ bool IsNegative;

                /*0x11421c0*/ NumberBuffer(Unity.Burst.BurstString.NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative);
                /*0x6937d0*/ byte* GetDigitsPointer();
            }

            enum NumberFormatKind
            {
                General = 0,
                Decimal = 1,
                DecimalForceSigned = 2,
                Hexadecimal = 3,
            }

            struct FormatOptions
            {
                /*0x10*/ Unity.Burst.BurstString.NumberFormatKind Kind;
                /*0x11*/ sbyte AlignAndSize;
                /*0x12*/ byte Specifier;
                /*0x13*/ bool Lowercase;

                /*0x1121b30*/ FormatOptions(Unity.Burst.BurstString.NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase);
                /*0x1121b50*/ bool get_Uppercase();
                /*0x6bba50*/ int EncodeToRaw();
                /*0x1121740*/ int GetBase();
                /*0x1121760*/ string ToString();
            }

            struct tBigInt
            {
                static int c_BigInt_MaxBlocks = 35;
                /*0x10*/ int m_length;
                /*0x14*/ Unity.Burst.BurstString.tBigInt.<m_blocks> m_blocks;

                /*0x6bba50*/ int GetLength();
                /*0x1142920*/ uint GetBlock(int idx);
                /*0xe24e80*/ void SetZero();
                /*0x1142940*/ bool IsZero();
                /*0x1142970*/ void SetU64(ulong val);
                /*0x1142950*/ void SetU32(uint val);
                /*0x1142930*/ uint GetU32();

                struct <m_blocks>e__FixedBuffer
                {
                    /*0x10*/ uint FixedElementField;
                }
            }

            enum CutoffMode
            {
                Unique = 0,
                TotalLength = 1,
                FractionLength = 2,
            }

            enum PrintFloatFormat
            {
                Positional = 0,
                Scientific = 1,
            }

            struct tFloatUnion32
            {
                /*0x10*/ float m_floatingPoint;
                /*0x10*/ uint m_integer;

                /*0xfa5170*/ bool IsNegative();
                /*0x11429a0*/ uint GetExponent();
                /*0x11429b0*/ uint GetMantissa();
            }

            struct tFloatUnion64
            {
                /*0x10*/ double m_floatingPoint;
                /*0x10*/ ulong m_integer;

                /*0x11429f0*/ bool IsNegative();
                /*0x11429c0*/ uint GetExponent();
                /*0x11429d0*/ ulong GetMantissa();
            }
        }

        enum DiagnosticId
        {
            ERR_InternalCompilerErrorInBackend = 100,
            ERR_InternalCompilerErrorInFunction = 101,
            ERR_InternalCompilerErrorInInstruction = 102,
            ERR_OnlyStaticMethodsAllowed = 1000,
            ERR_UnableToAccessManagedMethod = 1001,
            ERR_UnableToFindInterfaceMethod = 1002,
            ERR_UnexpectedEmptyMethodBody = 1003,
            ERR_ManagedArgumentsNotSupported = 1004,
            ERR_CatchConstructionNotSupported = 1006,
            ERR_CatchAndFilterConstructionNotSupported = 1007,
            ERR_LdfldaWithFixedArrayExpected = 1008,
            ERR_PointerExpected = 1009,
            ERR_LoadingFieldFromManagedObjectNotSupported = 1010,
            ERR_LoadingFieldWithManagedTypeNotSupported = 1011,
            ERR_LoadingArgumentWithManagedTypeNotSupported = 1012,
            ERR_CallingBurstDiscardMethodWithReturnValueNotSupported = 1015,
            ERR_CallingManagedMethodNotSupported = 1016,
            ERR_InstructionUnboxNotSupported = 1019,
            ERR_InstructionBoxNotSupported = 1020,
            ERR_InstructionNewobjWithManagedTypeNotSupported = 1021,
            ERR_AccessingManagedArrayNotSupported = 1022,
            ERR_InstructionLdtokenFieldNotSupported = 1023,
            ERR_InstructionLdtokenMethodNotSupported = 1024,
            ERR_InstructionLdtokenTypeNotSupported = 1025,
            ERR_InstructionLdtokenNotSupported = 1026,
            ERR_InstructionLdvirtftnNotSupported = 1027,
            ERR_InstructionNewarrNotSupported = 1028,
            ERR_InstructionRethrowNotSupported = 1029,
            ERR_InstructionCastclassNotSupported = 1030,
            ERR_InstructionLdftnNotSupported = 1032,
            ERR_InstructionLdstrNotSupported = 1033,
            ERR_InstructionStsfldNotSupported = 1034,
            ERR_InstructionEndfilterNotSupported = 1035,
            ERR_InstructionEndfinallyNotSupported = 1036,
            ERR_InstructionLeaveNotSupported = 1037,
            ERR_InstructionNotSupported = 1038,
            ERR_LoadingFromStaticFieldNotSupported = 1039,
            ERR_LoadingFromNonReadonlyStaticFieldNotSupported = 1040,
            ERR_LoadingFromManagedStaticFieldNotSupported = 1041,
            ERR_LoadingFromManagedNonReadonlyStaticFieldNotSupported = 1042,
            ERR_InstructionStfldToManagedObjectNotSupported = 1043,
            ERR_InstructionLdlenNonConstantLengthNotSupported = 1044,
            ERR_StructWithAutoLayoutNotSupported = 1045,
            ERR_StructWithGenericParametersAndExplicitLayoutNotSupported = 1047,
            ERR_StructSizeNotSupported = 1048,
            ERR_StructZeroSizeNotSupported = 1049,
            ERR_MarshalAsOnFieldNotSupported = 1050,
            ERR_TypeNotSupported = 1051,
            ERR_RequiredTypeModifierNotSupported = 1052,
            ERR_ErrorWhileProcessingVariable = 1053,
            ERR_UnableToResolveType = 1054,
            ERR_UnableToResolveMethod = 1055,
            ERR_ConstructorNotSupported = 1056,
            ERR_FunctionPointerMethodMissingBurstCompileAttribute = 1057,
            ERR_FunctionPointerTypeMissingBurstCompileAttribute = 1058,
            ERR_FunctionPointerMethodAndTypeMissingBurstCompileAttribute = 1059,
            INF_FunctionPointerMethodAndTypeMissingMonoPInvokeCallbackAttribute = 10590,
            ERR_MarshalAsOnParameterNotSupported = 1061,
            ERR_MarshalAsOnReturnTypeNotSupported = 1062,
            ERR_TypeNotBlittableForFunctionPointer = 1063,
            ERR_StructByValueNotSupported = 1064,
            ERR_StructsWithNonUnicodeCharsNotSupported = 1066,
            ERR_VectorsByValueNotSupported = 1067,
            ERR_MissingExternBindings = 1068,
            ERR_MarshalAsNativeTypeOnReturnTypeNotSupported = 1069,
            ERR_AssertTypeNotSupported = 1071,
            ERR_StoringToReadOnlyFieldNotAllowed = 1072,
            ERR_StoringToFieldInReadOnlyParameterNotAllowed = 1073,
            ERR_StoringToReadOnlyParameterNotAllowed = 1074,
            ERR_TypeManagerStaticFieldNotCompatible = 1075,
            ERR_UnableToFindTypeIndexForTypeManagerType = 1076,
            ERR_UnableToFindFieldForTypeManager = 1077,
            ERR_CircularStaticConstructorUsage = 1090,
            ERR_ExternalInternalCallsInStaticConstructorsNotSupported = 1091,
            ERR_PlatformNotSupported = 1092,
            ERR_InitModuleVerificationError = 1093,
            ERR_ModuleVerificationError = 1094,
            ERR_UnableToFindTypeRequiredForTypeManager = 1095,
            ERR_UnexpectedIntegerTypesForBinaryOperation = 1096,
            ERR_BinaryOperationNotSupported = 1097,
            ERR_CalliWithThisNotSupported = 1098,
            ERR_CalliNonCCallingConventionNotSupported = 1099,
            ERR_StringLiteralTooBig = 1100,
            ERR_LdftnNonCCallingConventionNotSupported = 1101,
            ERR_UnableToCallMethodOnInterfaceObject = 1102,
            ERR_UnsupportedCpuDependentBranch = 1199,
            ERR_InstructionTargetCpuFeatureNotAllowedInThisBlock = 1200,
            ERR_AssumeRangeTypeMustBeInteger = 1201,
            ERR_AssumeRangeTypeMustBeSameSign = 1202,
            ERR_UnsupportedSpillTransform = 1300,
            ERR_UnsupportedSpillTransformTooManyUsers = 1301,
            ERR_MethodNotSupported = 1302,
            ERR_VectorsLoadFieldIsAddress = 1303,
            ERR_ConstantExpressionRequired = 1304,
            ERR_PointerArgumentsUnexpectedAliasing = 1310,
            ERR_LoopIntrinsicMustBeCalledInsideLoop = 1320,
            ERR_LoopUnexpectedAutoVectorization = 1321,
            WRN_LoopIntrinsicCalledButLoopOptimizedAway = 1322,
            ERR_AssertArgTypesDiffer = 1330,
            ERR_StringInternalCompilerFixedStringTooManyUsers = 1340,
            ERR_StringInvalidFormatMissingClosingBrace = 1341,
            ERR_StringInvalidIntegerForArgumentIndex = 1342,
            ERR_StringInvalidFormatForArgument = 1343,
            ERR_StringArgumentIndexOutOfRange = 1344,
            ERR_StringInvalidArgumentType = 1345,
            ERR_DebugLogNotSupported = 1346,
            ERR_StringInvalidNonLiteralFormat = 1347,
            ERR_StringInvalidStringFormatMethod = 1348,
            ERR_StringInvalidArgument = 1349,
            ERR_StringArrayInvalidArrayCreation = 1350,
            ERR_StringArrayInvalidArraySize = 1351,
            ERR_StringArrayInvalidControlFlow = 1352,
            ERR_StringArrayInvalidArrayIndex = 1353,
            ERR_StringArrayInvalidArrayIndexOutOfRange = 1354,
            ERR_UnmanagedStringMethodMissing = 1355,
            ERR_UnmanagedStringMethodInvalid = 1356,
            ERR_ManagedStaticConstructor = 1360,
            ERR_StaticConstantArrayInStaticConstructor = 1361,
            WRN_ExceptionThrownInNonSafetyCheckGuardedFunction = 1370,
            WRN_ACallToMethodHasBeenDiscarded = 1371,
            ERR_AccessingNestedManagedArrayNotSupported = 1380,
            ERR_LdobjFromANonPointerNonReference = 1381,
            ERR_StringLiteralRequired = 1382,
            ERR_MultiDimensionalArrayUnsupported = 1383,
            ERR_NonBlittableAndNonManagedSequentialStructNotSupported = 1384,
            ERR_VarArgFunctionNotSupported = 1385,
        }

        interface IFunctionPointer
        {
            /*0x2a5510*/ Unity.Burst.IFunctionPointer FromIntPtr(nint ptr);
        }

        struct FunctionPointer<T> : Unity.Burst.IFunctionPointer
        {
            /*0x0*/ nint _ptr;

            FunctionPointer(nint ptr);
            nint get_Value();
            /*0x180fc0*/ void CheckIsCreated();
            /*0x2a5510*/ T get_Invoke();
            /*0x17cb40*/ bool get_IsCreated();
            /*0x2a5510*/ Unity.Burst.IFunctionPointer Unity.Burst.IFunctionPointer.FromIntPtr(nint ptr);
        }

        class NoAliasAttribute : System.Attribute
        {
            /*0x534220*/ NoAliasAttribute();
        }

        class SafeStringArrayHelper
        {
            static /*0x1142470*/ string SerialiseStringArraySafe(string[] array);
            static /*0x11421e0*/ string[] DeserialiseStringArraySafe(string input);
        }

        struct SharedStatic<T>
        {
            static uint DefaultAlignment = 16;
            /*0x0*/ void* _buffer;

            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment);
            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode);
            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode<TSubContext>(uint alignment, long hashCode);
            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode<TContext>(uint alignment, long subHashCode);
            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreate(System.Type contextType, uint alignment);
            static /*0x2a5510*/ Unity.Burst.SharedStatic<T> GetOrCreate(System.Type contextType, System.Type subContextType, uint alignment);
            static /*0x180ff0*/ void CheckIf_T_IsUnmanagedOrThrow();
            /*0x2a5510*/ SharedStatic(void* buffer);
            /*0x1803b0*/ ref T get_Data();
            /*0x2a5510*/ void* get_UnsafeDataPointer();
        }

        class SharedStatic
        {
            static /*0x1142620*/ void CheckSizeOf(uint sizeOf);
            static /*0x11425c0*/ void CheckResult(void* result);
            static /*0x11426a0*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);

            class PreserveAttribute : System.Attribute
            {
                /*0x534220*/ PreserveAttribute();
            }
        }

        namespace Intrinsics
        {
            class Arm
            {
                class Neon
                {
                    static /*0x348b00*/ bool get_IsNeonSupported();
                    static /*0x1122f90*/ Unity.Burst.Intrinsics.v64 vadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123aa0*/ Unity.Burst.Intrinsics.v128 vaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122ed0*/ Unity.Burst.Intrinsics.v64 vadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11239e0*/ Unity.Burst.Intrinsics.v128 vaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122f10*/ Unity.Burst.Intrinsics.v64 vadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123a20*/ Unity.Burst.Intrinsics.v128 vaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122f50*/ Unity.Burst.Intrinsics.v64 vadd_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123a60*/ Unity.Burst.Intrinsics.v128 vaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123000*/ Unity.Burst.Intrinsics.v64 vadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123b70*/ Unity.Burst.Intrinsics.v128 vaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122fd0*/ Unity.Burst.Intrinsics.v64 vadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123ae0*/ Unity.Burst.Intrinsics.v128 vaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122fe0*/ Unity.Burst.Intrinsics.v64 vadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123b10*/ Unity.Burst.Intrinsics.v128 vaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122ff0*/ Unity.Burst.Intrinsics.v64 vadd_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123b40*/ Unity.Burst.Intrinsics.v128 vaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122e50*/ Unity.Burst.Intrinsics.v64 vadd_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123960*/ Unity.Burst.Intrinsics.v128 vaddq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123560*/ Unity.Burst.Intrinsics.v128 vaddl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11234e0*/ Unity.Burst.Intrinsics.v128 vaddl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123520*/ Unity.Burst.Intrinsics.v128 vaddl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1123620*/ Unity.Burst.Intrinsics.v128 vaddl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11235a0*/ Unity.Burst.Intrinsics.v128 vaddl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11235e0*/ Unity.Burst.Intrinsics.v128 vaddl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11241e0*/ Unity.Burst.Intrinsics.v128 vaddw_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124160*/ Unity.Burst.Intrinsics.v128 vaddw_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11241a0*/ Unity.Burst.Intrinsics.v128 vaddw_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11242a0*/ Unity.Burst.Intrinsics.v128 vaddw_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124220*/ Unity.Burst.Intrinsics.v128 vaddw_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124260*/ Unity.Burst.Intrinsics.v128 vaddw_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cae0*/ Unity.Burst.Intrinsics.v64 vhadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cc60*/ Unity.Burst.Intrinsics.v128 vhaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112ca60*/ Unity.Burst.Intrinsics.v64 vhadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cbe0*/ Unity.Burst.Intrinsics.v128 vhaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112caa0*/ Unity.Burst.Intrinsics.v64 vhadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cc20*/ Unity.Burst.Intrinsics.v128 vhaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112cba0*/ Unity.Burst.Intrinsics.v64 vhadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cd20*/ Unity.Burst.Intrinsics.v128 vhaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112cb20*/ Unity.Burst.Intrinsics.v64 vhadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cca0*/ Unity.Burst.Intrinsics.v128 vhaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112cb60*/ Unity.Burst.Intrinsics.v64 vhadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cce0*/ Unity.Burst.Intrinsics.v128 vhaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b2b0*/ Unity.Burst.Intrinsics.v64 vrhadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113b430*/ Unity.Burst.Intrinsics.v128 vrhaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b230*/ Unity.Burst.Intrinsics.v64 vrhadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113b3b0*/ Unity.Burst.Intrinsics.v128 vrhaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b270*/ Unity.Burst.Intrinsics.v64 vrhadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113b3f0*/ Unity.Burst.Intrinsics.v128 vrhaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b370*/ Unity.Burst.Intrinsics.v64 vrhadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113b4f0*/ Unity.Burst.Intrinsics.v128 vrhaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b2f0*/ Unity.Burst.Intrinsics.v64 vrhadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113b470*/ Unity.Burst.Intrinsics.v128 vrhaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b330*/ Unity.Burst.Intrinsics.v64 vrhadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113b4b0*/ Unity.Burst.Intrinsics.v128 vrhaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134940*/ Unity.Burst.Intrinsics.v64 vqadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134cc0*/ Unity.Burst.Intrinsics.v128 vqaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134880*/ Unity.Burst.Intrinsics.v64 vqadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134c00*/ Unity.Burst.Intrinsics.v128 vqaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11348c0*/ Unity.Burst.Intrinsics.v64 vqadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134c40*/ Unity.Burst.Intrinsics.v128 vqaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134900*/ Unity.Burst.Intrinsics.v64 vqadd_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134c80*/ Unity.Burst.Intrinsics.v128 vqaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134a40*/ Unity.Burst.Intrinsics.v64 vqadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134dc0*/ Unity.Burst.Intrinsics.v128 vqaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134980*/ Unity.Burst.Intrinsics.v64 vqadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134d00*/ Unity.Burst.Intrinsics.v128 vqaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11349c0*/ Unity.Burst.Intrinsics.v64 vqadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134d40*/ Unity.Burst.Intrinsics.v128 vqaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134a00*/ Unity.Burst.Intrinsics.v64 vqadd_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134d80*/ Unity.Burst.Intrinsics.v128 vqaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123210*/ Unity.Burst.Intrinsics.v64 vaddhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123250*/ Unity.Burst.Intrinsics.v64 vaddhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123290*/ Unity.Burst.Intrinsics.v64 vaddhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11232d0*/ Unity.Burst.Intrinsics.v64 vaddhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123300*/ Unity.Burst.Intrinsics.v64 vaddhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123330*/ Unity.Burst.Intrinsics.v64 vaddhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a810*/ Unity.Burst.Intrinsics.v64 vraddhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a850*/ Unity.Burst.Intrinsics.v64 vraddhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a890*/ Unity.Burst.Intrinsics.v64 vraddhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a8d0*/ Unity.Burst.Intrinsics.v64 vraddhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a900*/ Unity.Burst.Intrinsics.v64 vraddhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a930*/ Unity.Burst.Intrinsics.v64 vraddhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11315d0*/ Unity.Burst.Intrinsics.v64 vmul_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132520*/ Unity.Burst.Intrinsics.v128 vmulq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131550*/ Unity.Burst.Intrinsics.v64 vmul_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11324a0*/ Unity.Burst.Intrinsics.v128 vmulq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131590*/ Unity.Burst.Intrinsics.v64 vmul_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11324e0*/ Unity.Burst.Intrinsics.v128 vmulq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131630*/ Unity.Burst.Intrinsics.v64 vmul_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11325c0*/ Unity.Burst.Intrinsics.v128 vmulq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131610*/ Unity.Burst.Intrinsics.v64 vmul_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132560*/ Unity.Burst.Intrinsics.v128 vmulq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131620*/ Unity.Burst.Intrinsics.v64 vmul_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132590*/ Unity.Burst.Intrinsics.v128 vmulq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131080*/ Unity.Burst.Intrinsics.v64 vmul_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131fa0*/ Unity.Burst.Intrinsics.v128 vmulq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112e820*/ Unity.Burst.Intrinsics.v64 vmla_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f650*/ Unity.Burst.Intrinsics.v128 vmlaq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112e7a0*/ Unity.Burst.Intrinsics.v64 vmla_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f5d0*/ Unity.Burst.Intrinsics.v128 vmlaq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112e7e0*/ Unity.Burst.Intrinsics.v64 vmla_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f610*/ Unity.Burst.Intrinsics.v128 vmlaq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112e880*/ Unity.Burst.Intrinsics.v64 vmla_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f710*/ Unity.Burst.Intrinsics.v128 vmlaq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112e860*/ Unity.Burst.Intrinsics.v64 vmla_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f690*/ Unity.Burst.Intrinsics.v128 vmlaq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112e870*/ Unity.Burst.Intrinsics.v64 vmla_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f6d0*/ Unity.Burst.Intrinsics.v128 vmlaq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112e360*/ Unity.Burst.Intrinsics.v64 vmla_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f190*/ Unity.Burst.Intrinsics.v128 vmlaq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112f090*/ Unity.Burst.Intrinsics.v128 vmlal_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f010*/ Unity.Burst.Intrinsics.v128 vmlal_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f050*/ Unity.Burst.Intrinsics.v128 vmlal_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f150*/ Unity.Burst.Intrinsics.v128 vmlal_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f0d0*/ Unity.Burst.Intrinsics.v128 vmlal_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f110*/ Unity.Burst.Intrinsics.v128 vmlal_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112fc10*/ Unity.Burst.Intrinsics.v64 vmls_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130a40*/ Unity.Burst.Intrinsics.v128 vmlsq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112fb90*/ Unity.Burst.Intrinsics.v64 vmls_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11309c0*/ Unity.Burst.Intrinsics.v128 vmlsq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112fbd0*/ Unity.Burst.Intrinsics.v64 vmls_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130a00*/ Unity.Burst.Intrinsics.v128 vmlsq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112fc70*/ Unity.Burst.Intrinsics.v64 vmls_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130b00*/ Unity.Burst.Intrinsics.v128 vmlsq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112fc50*/ Unity.Burst.Intrinsics.v64 vmls_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130a80*/ Unity.Burst.Intrinsics.v128 vmlsq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112fc60*/ Unity.Burst.Intrinsics.v64 vmls_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130ac0*/ Unity.Burst.Intrinsics.v128 vmlsq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112f750*/ Unity.Burst.Intrinsics.v64 vmls_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130580*/ Unity.Burst.Intrinsics.v128 vmlsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1130480*/ Unity.Burst.Intrinsics.v128 vmlsl_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130400*/ Unity.Burst.Intrinsics.v128 vmlsl_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130440*/ Unity.Burst.Intrinsics.v128 vmlsl_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130540*/ Unity.Burst.Intrinsics.v128 vmlsl_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11304c0*/ Unity.Burst.Intrinsics.v128 vmlsl_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1130500*/ Unity.Burst.Intrinsics.v128 vmlsl_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112bc40*/ Unity.Burst.Intrinsics.v64 vfma_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112beb0*/ Unity.Burst.Intrinsics.v128 vfmaq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112c130*/ Unity.Burst.Intrinsics.v64 vfms_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112c3a0*/ Unity.Burst.Intrinsics.v128 vfmsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1135b00*/ Unity.Burst.Intrinsics.v64 vqdmulh_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1135dc0*/ Unity.Burst.Intrinsics.v128 vqdmulhq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1135b40*/ Unity.Burst.Intrinsics.v64 vqdmulh_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1135e00*/ Unity.Burst.Intrinsics.v128 vqdmulhq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137840*/ Unity.Burst.Intrinsics.v64 vqrdmulh_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1137b00*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137880*/ Unity.Burst.Intrinsics.v64 vqrdmulh_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1137b40*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1135200*/ Unity.Burst.Intrinsics.v128 vqdmlal_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1135240*/ Unity.Burst.Intrinsics.v128 vqdmlal_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1135780*/ Unity.Burst.Intrinsics.v128 vqdmlsl_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11357c0*/ Unity.Burst.Intrinsics.v128 vqdmlsl_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1131ea0*/ Unity.Burst.Intrinsics.v128 vmull_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131e20*/ Unity.Burst.Intrinsics.v128 vmull_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131e60*/ Unity.Burst.Intrinsics.v128 vmull_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131f60*/ Unity.Burst.Intrinsics.v128 vmull_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131ee0*/ Unity.Burst.Intrinsics.v128 vmull_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131f20*/ Unity.Burst.Intrinsics.v128 vmull_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1136280*/ Unity.Burst.Intrinsics.v128 vqdmull_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11362c0*/ Unity.Burst.Intrinsics.v128 vqdmull_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113fe70*/ Unity.Burst.Intrinsics.v64 vsub_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140680*/ Unity.Burst.Intrinsics.v128 vsubq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fdb0*/ Unity.Burst.Intrinsics.v64 vsub_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11405c0*/ Unity.Burst.Intrinsics.v128 vsubq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fdf0*/ Unity.Burst.Intrinsics.v64 vsub_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140600*/ Unity.Burst.Intrinsics.v128 vsubq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fe30*/ Unity.Burst.Intrinsics.v64 vsub_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140640*/ Unity.Burst.Intrinsics.v128 vsubq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fee0*/ Unity.Burst.Intrinsics.v64 vsub_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140750*/ Unity.Burst.Intrinsics.v128 vsubq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113feb0*/ Unity.Burst.Intrinsics.v64 vsub_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11406c0*/ Unity.Burst.Intrinsics.v128 vsubq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fec0*/ Unity.Burst.Intrinsics.v64 vsub_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11406f0*/ Unity.Burst.Intrinsics.v128 vsubq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fed0*/ Unity.Burst.Intrinsics.v64 vsub_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140720*/ Unity.Burst.Intrinsics.v128 vsubq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fd30*/ Unity.Burst.Intrinsics.v64 vsub_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140540*/ Unity.Burst.Intrinsics.v128 vsubq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140440*/ Unity.Burst.Intrinsics.v128 vsubl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11403c0*/ Unity.Burst.Intrinsics.v128 vsubl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140400*/ Unity.Burst.Intrinsics.v128 vsubl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140500*/ Unity.Burst.Intrinsics.v128 vsubl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140480*/ Unity.Burst.Intrinsics.v128 vsubl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11404c0*/ Unity.Burst.Intrinsics.v128 vsubl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140980*/ Unity.Burst.Intrinsics.v128 vsubw_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140900*/ Unity.Burst.Intrinsics.v128 vsubw_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140940*/ Unity.Burst.Intrinsics.v128 vsubw_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140a40*/ Unity.Burst.Intrinsics.v128 vsubw_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11409c0*/ Unity.Burst.Intrinsics.v128 vsubw_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140a00*/ Unity.Burst.Intrinsics.v128 vsubw_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cde0*/ Unity.Burst.Intrinsics.v64 vhsub_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cf60*/ Unity.Burst.Intrinsics.v128 vhsubq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112cd60*/ Unity.Burst.Intrinsics.v64 vhsub_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cee0*/ Unity.Burst.Intrinsics.v128 vhsubq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112cda0*/ Unity.Burst.Intrinsics.v64 vhsub_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cf20*/ Unity.Burst.Intrinsics.v128 vhsubq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112cea0*/ Unity.Burst.Intrinsics.v64 vhsub_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d020*/ Unity.Burst.Intrinsics.v128 vhsubq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112ce20*/ Unity.Burst.Intrinsics.v64 vhsub_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cfa0*/ Unity.Burst.Intrinsics.v128 vhsubq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112ce60*/ Unity.Burst.Intrinsics.v64 vhsub_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112cfe0*/ Unity.Burst.Intrinsics.v128 vhsubq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1139fa0*/ Unity.Burst.Intrinsics.v64 vqsub_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a320*/ Unity.Burst.Intrinsics.v128 vqsubq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1139ee0*/ Unity.Burst.Intrinsics.v64 vqsub_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a260*/ Unity.Burst.Intrinsics.v128 vqsubq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1139f20*/ Unity.Burst.Intrinsics.v64 vqsub_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a2a0*/ Unity.Burst.Intrinsics.v128 vqsubq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1139f60*/ Unity.Burst.Intrinsics.v64 vqsub_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a2e0*/ Unity.Burst.Intrinsics.v128 vqsubq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a0a0*/ Unity.Burst.Intrinsics.v64 vqsub_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a420*/ Unity.Burst.Intrinsics.v128 vqsubq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1139fe0*/ Unity.Burst.Intrinsics.v64 vqsub_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a360*/ Unity.Burst.Intrinsics.v128 vqsubq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a020*/ Unity.Burst.Intrinsics.v64 vqsub_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a3a0*/ Unity.Burst.Intrinsics.v128 vqsubq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a060*/ Unity.Burst.Intrinsics.v64 vqsub_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a3e0*/ Unity.Burst.Intrinsics.v128 vqsubq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11400f0*/ Unity.Burst.Intrinsics.v64 vsubhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140130*/ Unity.Burst.Intrinsics.v64 vsubhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140170*/ Unity.Burst.Intrinsics.v64 vsubhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11401b0*/ Unity.Burst.Intrinsics.v64 vsubhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11401e0*/ Unity.Burst.Intrinsics.v64 vsubhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140210*/ Unity.Burst.Intrinsics.v64 vsubhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d130*/ Unity.Burst.Intrinsics.v64 vrsubhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d170*/ Unity.Burst.Intrinsics.v64 vrsubhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d1b0*/ Unity.Burst.Intrinsics.v64 vrsubhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d1f0*/ Unity.Burst.Intrinsics.v64 vrsubhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d220*/ Unity.Burst.Intrinsics.v64 vrsubhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d250*/ Unity.Burst.Intrinsics.v64 vrsubhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124d70*/ Unity.Burst.Intrinsics.v64 vceq_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124ff0*/ Unity.Burst.Intrinsics.v128 vceqq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124cb0*/ Unity.Burst.Intrinsics.v64 vceq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124f30*/ Unity.Burst.Intrinsics.v128 vceqq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124cf0*/ Unity.Burst.Intrinsics.v64 vceq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124f70*/ Unity.Burst.Intrinsics.v128 vceqq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124de0*/ Unity.Burst.Intrinsics.v64 vceq_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11250c0*/ Unity.Burst.Intrinsics.v128 vceqq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124db0*/ Unity.Burst.Intrinsics.v64 vceq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125030*/ Unity.Burst.Intrinsics.v128 vceqq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124dc0*/ Unity.Burst.Intrinsics.v64 vceq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125060*/ Unity.Burst.Intrinsics.v128 vceqq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124c30*/ Unity.Burst.Intrinsics.v64 vceq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124eb0*/ Unity.Burst.Intrinsics.v128 vceqq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125730*/ Unity.Burst.Intrinsics.v64 vcge_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125a70*/ Unity.Burst.Intrinsics.v128 vcgeq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125670*/ Unity.Burst.Intrinsics.v64 vcge_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11259b0*/ Unity.Burst.Intrinsics.v128 vcgeq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11256b0*/ Unity.Burst.Intrinsics.v64 vcge_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11259f0*/ Unity.Burst.Intrinsics.v128 vcgeq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125830*/ Unity.Burst.Intrinsics.v64 vcge_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125b70*/ Unity.Burst.Intrinsics.v128 vcgeq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125770*/ Unity.Burst.Intrinsics.v64 vcge_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125ab0*/ Unity.Burst.Intrinsics.v128 vcgeq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11257b0*/ Unity.Burst.Intrinsics.v64 vcge_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125af0*/ Unity.Burst.Intrinsics.v128 vcgeq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11255f0*/ Unity.Burst.Intrinsics.v64 vcge_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125930*/ Unity.Burst.Intrinsics.v128 vcgeq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126ab0*/ Unity.Burst.Intrinsics.v64 vcle_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126df0*/ Unity.Burst.Intrinsics.v128 vcleq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11269f0*/ Unity.Burst.Intrinsics.v64 vcle_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126d30*/ Unity.Burst.Intrinsics.v128 vcleq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126a30*/ Unity.Burst.Intrinsics.v64 vcle_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126d70*/ Unity.Burst.Intrinsics.v128 vcleq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126bb0*/ Unity.Burst.Intrinsics.v64 vcle_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126ef0*/ Unity.Burst.Intrinsics.v128 vcleq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126af0*/ Unity.Burst.Intrinsics.v64 vcle_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126e30*/ Unity.Burst.Intrinsics.v128 vcleq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126b30*/ Unity.Burst.Intrinsics.v64 vcle_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126e70*/ Unity.Burst.Intrinsics.v128 vcleq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126970*/ Unity.Burst.Intrinsics.v64 vcle_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126cb0*/ Unity.Burst.Intrinsics.v128 vcleq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11260f0*/ Unity.Burst.Intrinsics.v64 vcgt_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126430*/ Unity.Burst.Intrinsics.v128 vcgtq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126030*/ Unity.Burst.Intrinsics.v64 vcgt_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126370*/ Unity.Burst.Intrinsics.v128 vcgtq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126070*/ Unity.Burst.Intrinsics.v64 vcgt_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11263b0*/ Unity.Burst.Intrinsics.v128 vcgtq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11261f0*/ Unity.Burst.Intrinsics.v64 vcgt_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126530*/ Unity.Burst.Intrinsics.v128 vcgtq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126130*/ Unity.Burst.Intrinsics.v64 vcgt_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126470*/ Unity.Burst.Intrinsics.v128 vcgtq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126170*/ Unity.Burst.Intrinsics.v64 vcgt_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11264b0*/ Unity.Burst.Intrinsics.v128 vcgtq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125fb0*/ Unity.Burst.Intrinsics.v64 vcgt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11262f0*/ Unity.Burst.Intrinsics.v128 vcgtq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11275f0*/ Unity.Burst.Intrinsics.v64 vclt_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1127930*/ Unity.Burst.Intrinsics.v128 vcltq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1127530*/ Unity.Burst.Intrinsics.v64 vclt_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1127870*/ Unity.Burst.Intrinsics.v128 vcltq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1127570*/ Unity.Burst.Intrinsics.v64 vclt_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11278b0*/ Unity.Burst.Intrinsics.v128 vcltq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11276f0*/ Unity.Burst.Intrinsics.v64 vclt_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1127a30*/ Unity.Burst.Intrinsics.v128 vcltq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1127630*/ Unity.Burst.Intrinsics.v64 vclt_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1127970*/ Unity.Burst.Intrinsics.v128 vcltq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1127670*/ Unity.Burst.Intrinsics.v64 vclt_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11279b0*/ Unity.Burst.Intrinsics.v128 vcltq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11274b0*/ Unity.Burst.Intrinsics.v64 vclt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11277f0*/ Unity.Burst.Intrinsics.v128 vcltq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124630*/ Unity.Burst.Intrinsics.v64 vcage_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11246f0*/ Unity.Burst.Intrinsics.v128 vcageq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124930*/ Unity.Burst.Intrinsics.v64 vcale_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11249f0*/ Unity.Burst.Intrinsics.v128 vcaleq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11247b0*/ Unity.Burst.Intrinsics.v64 vcagt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124870*/ Unity.Burst.Intrinsics.v128 vcagtq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124ab0*/ Unity.Burst.Intrinsics.v64 vcalt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124b70*/ Unity.Burst.Intrinsics.v128 vcaltq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141140*/ Unity.Burst.Intrinsics.v64 vtst_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141300*/ Unity.Burst.Intrinsics.v128 vtstq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141080*/ Unity.Burst.Intrinsics.v64 vtst_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141240*/ Unity.Burst.Intrinsics.v128 vtstq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11410c0*/ Unity.Burst.Intrinsics.v64 vtst_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141280*/ Unity.Burst.Intrinsics.v128 vtstq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11411b0*/ Unity.Burst.Intrinsics.v64 vtst_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11413d0*/ Unity.Burst.Intrinsics.v128 vtstq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141180*/ Unity.Burst.Intrinsics.v64 vtst_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141340*/ Unity.Burst.Intrinsics.v128 vtstq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141190*/ Unity.Burst.Intrinsics.v64 vtst_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141370*/ Unity.Burst.Intrinsics.v128 vtstq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122490*/ Unity.Burst.Intrinsics.v64 vabd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11229d0*/ Unity.Burst.Intrinsics.v128 vabdq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122410*/ Unity.Burst.Intrinsics.v64 vabd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122950*/ Unity.Burst.Intrinsics.v128 vabdq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122450*/ Unity.Burst.Intrinsics.v64 vabd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122990*/ Unity.Burst.Intrinsics.v128 vabdq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122550*/ Unity.Burst.Intrinsics.v64 vabd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122a90*/ Unity.Burst.Intrinsics.v128 vabdq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11224d0*/ Unity.Burst.Intrinsics.v64 vabd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122a10*/ Unity.Burst.Intrinsics.v128 vabdq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122510*/ Unity.Burst.Intrinsics.v64 vabd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122a50*/ Unity.Burst.Intrinsics.v128 vabdq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122390*/ Unity.Burst.Intrinsics.v64 vabd_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11228d0*/ Unity.Burst.Intrinsics.v128 vabdq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11227d0*/ Unity.Burst.Intrinsics.v128 vabdl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122750*/ Unity.Burst.Intrinsics.v128 vabdl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122790*/ Unity.Burst.Intrinsics.v128 vabdl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122890*/ Unity.Burst.Intrinsics.v128 vabdl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122810*/ Unity.Burst.Intrinsics.v128 vabdl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122850*/ Unity.Burst.Intrinsics.v128 vabdl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1121e10*/ Unity.Burst.Intrinsics.v64 vaba_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122290*/ Unity.Burst.Intrinsics.v128 vabaq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121d90*/ Unity.Burst.Intrinsics.v64 vaba_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122210*/ Unity.Burst.Intrinsics.v128 vabaq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121dd0*/ Unity.Burst.Intrinsics.v64 vaba_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122250*/ Unity.Burst.Intrinsics.v128 vabaq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121ed0*/ Unity.Burst.Intrinsics.v64 vaba_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122350*/ Unity.Burst.Intrinsics.v128 vabaq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121e50*/ Unity.Burst.Intrinsics.v64 vaba_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11222d0*/ Unity.Burst.Intrinsics.v128 vabaq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121e90*/ Unity.Burst.Intrinsics.v64 vaba_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122310*/ Unity.Burst.Intrinsics.v128 vabaq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1122110*/ Unity.Burst.Intrinsics.v128 vabal_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122090*/ Unity.Burst.Intrinsics.v128 vabal_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11220d0*/ Unity.Burst.Intrinsics.v128 vabal_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11221d0*/ Unity.Burst.Intrinsics.v128 vabal_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122150*/ Unity.Burst.Intrinsics.v128 vabal_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1122190*/ Unity.Burst.Intrinsics.v128 vabal_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112d160*/ Unity.Burst.Intrinsics.v64 vmax_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d520*/ Unity.Burst.Intrinsics.v128 vmaxq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d0e0*/ Unity.Burst.Intrinsics.v64 vmax_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d4a0*/ Unity.Burst.Intrinsics.v128 vmaxq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d120*/ Unity.Burst.Intrinsics.v64 vmax_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d4e0*/ Unity.Burst.Intrinsics.v128 vmaxq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d220*/ Unity.Burst.Intrinsics.v64 vmax_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d5e0*/ Unity.Burst.Intrinsics.v128 vmaxq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d1a0*/ Unity.Burst.Intrinsics.v64 vmax_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d560*/ Unity.Burst.Intrinsics.v128 vmaxq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d1e0*/ Unity.Burst.Intrinsics.v64 vmax_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d5a0*/ Unity.Burst.Intrinsics.v128 vmaxq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d060*/ Unity.Burst.Intrinsics.v64 vmax_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d420*/ Unity.Burst.Intrinsics.v128 vmaxq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112dae0*/ Unity.Burst.Intrinsics.v64 vmin_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112dea0*/ Unity.Burst.Intrinsics.v128 vminq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112da60*/ Unity.Burst.Intrinsics.v64 vmin_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112de20*/ Unity.Burst.Intrinsics.v128 vminq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112daa0*/ Unity.Burst.Intrinsics.v64 vmin_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112de60*/ Unity.Burst.Intrinsics.v128 vminq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112dba0*/ Unity.Burst.Intrinsics.v64 vmin_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112df60*/ Unity.Burst.Intrinsics.v128 vminq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112db20*/ Unity.Burst.Intrinsics.v64 vmin_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112dee0*/ Unity.Burst.Intrinsics.v128 vminq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112db60*/ Unity.Burst.Intrinsics.v64 vmin_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112df20*/ Unity.Burst.Intrinsics.v128 vminq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d9e0*/ Unity.Burst.Intrinsics.v64 vmin_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112dda0*/ Unity.Burst.Intrinsics.v128 vminq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dc00*/ Unity.Burst.Intrinsics.v64 vshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e390*/ Unity.Burst.Intrinsics.v128 vshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113db40*/ Unity.Burst.Intrinsics.v64 vshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e2d0*/ Unity.Burst.Intrinsics.v128 vshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113db80*/ Unity.Burst.Intrinsics.v64 vshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e310*/ Unity.Burst.Intrinsics.v128 vshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dbc0*/ Unity.Burst.Intrinsics.v64 vshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e350*/ Unity.Burst.Intrinsics.v128 vshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dd00*/ Unity.Burst.Intrinsics.v64 vshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e490*/ Unity.Burst.Intrinsics.v128 vshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dc40*/ Unity.Burst.Intrinsics.v64 vshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e3d0*/ Unity.Burst.Intrinsics.v128 vshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dc80*/ Unity.Burst.Intrinsics.v64 vshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e410*/ Unity.Burst.Intrinsics.v128 vshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dcc0*/ Unity.Burst.Intrinsics.v64 vshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113e450*/ Unity.Burst.Intrinsics.v128 vshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138b60*/ Unity.Burst.Intrinsics.v64 vqshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11392e0*/ Unity.Burst.Intrinsics.v128 vqshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138aa0*/ Unity.Burst.Intrinsics.v64 vqshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1139220*/ Unity.Burst.Intrinsics.v128 vqshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138ae0*/ Unity.Burst.Intrinsics.v64 vqshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1139260*/ Unity.Burst.Intrinsics.v128 vqshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138b20*/ Unity.Burst.Intrinsics.v64 vqshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11392a0*/ Unity.Burst.Intrinsics.v128 vqshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138c60*/ Unity.Burst.Intrinsics.v64 vqshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11393e0*/ Unity.Burst.Intrinsics.v128 vqshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138ba0*/ Unity.Burst.Intrinsics.v64 vqshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1139320*/ Unity.Burst.Intrinsics.v128 vqshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138be0*/ Unity.Burst.Intrinsics.v64 vqshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1139360*/ Unity.Burst.Intrinsics.v128 vqshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1138c20*/ Unity.Burst.Intrinsics.v64 vqshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11393a0*/ Unity.Burst.Intrinsics.v128 vqshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bd30*/ Unity.Burst.Intrinsics.v64 vrshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113bfb0*/ Unity.Burst.Intrinsics.v128 vrshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bc70*/ Unity.Burst.Intrinsics.v64 vrshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113bef0*/ Unity.Burst.Intrinsics.v128 vrshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bcb0*/ Unity.Burst.Intrinsics.v64 vrshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113bf30*/ Unity.Burst.Intrinsics.v128 vrshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bcf0*/ Unity.Burst.Intrinsics.v64 vrshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113bf70*/ Unity.Burst.Intrinsics.v128 vrshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113be30*/ Unity.Burst.Intrinsics.v64 vrshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113c0b0*/ Unity.Burst.Intrinsics.v128 vrshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bd70*/ Unity.Burst.Intrinsics.v64 vrshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113bff0*/ Unity.Burst.Intrinsics.v128 vrshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bdb0*/ Unity.Burst.Intrinsics.v64 vrshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113c030*/ Unity.Burst.Intrinsics.v128 vrshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113bdf0*/ Unity.Burst.Intrinsics.v64 vrshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113c070*/ Unity.Burst.Intrinsics.v128 vrshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137d00*/ Unity.Burst.Intrinsics.v64 vqrshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1138080*/ Unity.Burst.Intrinsics.v128 vqrshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137c40*/ Unity.Burst.Intrinsics.v64 vqrshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1137fc0*/ Unity.Burst.Intrinsics.v128 vqrshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137c80*/ Unity.Burst.Intrinsics.v64 vqrshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1138000*/ Unity.Burst.Intrinsics.v128 vqrshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137cc0*/ Unity.Burst.Intrinsics.v64 vqrshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1138040*/ Unity.Burst.Intrinsics.v128 vqrshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137e00*/ Unity.Burst.Intrinsics.v64 vqrshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1138180*/ Unity.Burst.Intrinsics.v128 vqrshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137d40*/ Unity.Burst.Intrinsics.v64 vqrshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11380c0*/ Unity.Burst.Intrinsics.v128 vqrshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137d80*/ Unity.Burst.Intrinsics.v64 vqrshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1138100*/ Unity.Burst.Intrinsics.v128 vqrshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1137dc0*/ Unity.Burst.Intrinsics.v64 vqrshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1138140*/ Unity.Burst.Intrinsics.v128 vqrshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113e590*/ Unity.Burst.Intrinsics.v64 vshr_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113eab0*/ Unity.Burst.Intrinsics.v128 vshrq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e4d0*/ Unity.Burst.Intrinsics.v64 vshr_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e9f0*/ Unity.Burst.Intrinsics.v128 vshrq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e510*/ Unity.Burst.Intrinsics.v64 vshr_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113ea30*/ Unity.Burst.Intrinsics.v128 vshrq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e550*/ Unity.Burst.Intrinsics.v64 vshr_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113ea70*/ Unity.Burst.Intrinsics.v128 vshrq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e690*/ Unity.Burst.Intrinsics.v64 vshr_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113ebb0*/ Unity.Burst.Intrinsics.v128 vshrq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e5d0*/ Unity.Burst.Intrinsics.v64 vshr_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113eaf0*/ Unity.Burst.Intrinsics.v128 vshrq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e610*/ Unity.Burst.Intrinsics.v64 vshr_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113eb30*/ Unity.Burst.Intrinsics.v128 vshrq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e650*/ Unity.Burst.Intrinsics.v64 vshr_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113eb70*/ Unity.Burst.Intrinsics.v128 vshrq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113da00*/ Unity.Burst.Intrinsics.v64 vshl_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e190*/ Unity.Burst.Intrinsics.v128 vshlq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113d940*/ Unity.Burst.Intrinsics.v64 vshl_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e0d0*/ Unity.Burst.Intrinsics.v128 vshlq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113d980*/ Unity.Burst.Intrinsics.v64 vshl_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e110*/ Unity.Burst.Intrinsics.v128 vshlq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113d9c0*/ Unity.Burst.Intrinsics.v64 vshl_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e150*/ Unity.Burst.Intrinsics.v128 vshlq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113db00*/ Unity.Burst.Intrinsics.v64 vshl_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e290*/ Unity.Burst.Intrinsics.v128 vshlq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113da40*/ Unity.Burst.Intrinsics.v64 vshl_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e1d0*/ Unity.Burst.Intrinsics.v128 vshlq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113da80*/ Unity.Burst.Intrinsics.v64 vshl_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e210*/ Unity.Burst.Intrinsics.v128 vshlq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113dac0*/ Unity.Burst.Intrinsics.v64 vshl_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e250*/ Unity.Burst.Intrinsics.v128 vshlq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c1b0*/ Unity.Burst.Intrinsics.v64 vrshr_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c770*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c0f0*/ Unity.Burst.Intrinsics.v64 vrshr_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c670*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c130*/ Unity.Burst.Intrinsics.v64 vrshr_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c6d0*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c170*/ Unity.Burst.Intrinsics.v64 vrshr_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c720*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c2b0*/ Unity.Burst.Intrinsics.v64 vrshr_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c8d0*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c1f0*/ Unity.Burst.Intrinsics.v64 vrshr_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c7d0*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c230*/ Unity.Burst.Intrinsics.v64 vrshr_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c830*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c270*/ Unity.Burst.Intrinsics.v64 vrshr_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113c880*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113f530*/ Unity.Burst.Intrinsics.v64 vsra_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f770*/ Unity.Burst.Intrinsics.v128 vsraq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f470*/ Unity.Burst.Intrinsics.v64 vsra_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f6b0*/ Unity.Burst.Intrinsics.v128 vsraq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f4b0*/ Unity.Burst.Intrinsics.v64 vsra_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f6f0*/ Unity.Burst.Intrinsics.v128 vsraq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f4f0*/ Unity.Burst.Intrinsics.v64 vsra_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f730*/ Unity.Burst.Intrinsics.v128 vsraq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f630*/ Unity.Burst.Intrinsics.v64 vsra_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f870*/ Unity.Burst.Intrinsics.v128 vsraq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f570*/ Unity.Burst.Intrinsics.v64 vsra_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f7b0*/ Unity.Burst.Intrinsics.v128 vsraq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f5b0*/ Unity.Burst.Intrinsics.v64 vsra_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f7f0*/ Unity.Burst.Intrinsics.v128 vsraq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f5f0*/ Unity.Burst.Intrinsics.v64 vsra_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f830*/ Unity.Burst.Intrinsics.v128 vsraq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113cd10*/ Unity.Burst.Intrinsics.v64 vrsra_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113cec0*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ccb0*/ Unity.Burst.Intrinsics.v64 vrsra_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113ce30*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ccd0*/ Unity.Burst.Intrinsics.v64 vrsra_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113ce60*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ccf0*/ Unity.Burst.Intrinsics.v64 vrsra_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113ce90*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113cd90*/ Unity.Burst.Intrinsics.v64 vrsra_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113cf80*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113cd30*/ Unity.Burst.Intrinsics.v64 vrsra_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113cef0*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113cd50*/ Unity.Burst.Intrinsics.v64 vrsra_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113cf20*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113cd70*/ Unity.Burst.Intrinsics.v64 vrsra_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113cf50*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11389a0*/ Unity.Burst.Intrinsics.v64 vqshl_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1139090*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138900*/ Unity.Burst.Intrinsics.v64 vqshl_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1138fa0*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138930*/ Unity.Burst.Intrinsics.v64 vqshl_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1138ff0*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138960*/ Unity.Burst.Intrinsics.v64 vqshl_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1139040*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138a70*/ Unity.Burst.Intrinsics.v64 vqshl_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x11391d0*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11389d0*/ Unity.Burst.Intrinsics.v64 vqshl_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x11390e0*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138a00*/ Unity.Burst.Intrinsics.v64 vqshl_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1139130*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138a30*/ Unity.Burst.Intrinsics.v64 vqshl_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1139180*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11395e0*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x11397a0*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139520*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x11396e0*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139560*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1139720*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11395a0*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1139760*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e870*/ Unity.Burst.Intrinsics.v64 vshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e8b0*/ Unity.Burst.Intrinsics.v64 vshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e8f0*/ Unity.Burst.Intrinsics.v64 vshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e930*/ Unity.Burst.Intrinsics.v64 vshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e970*/ Unity.Burst.Intrinsics.v64 vshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113e9b0*/ Unity.Burst.Intrinsics.v64 vshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139d60*/ Unity.Burst.Intrinsics.v64 vqshrun_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139da0*/ Unity.Burst.Intrinsics.v64 vqshrun_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139de0*/ Unity.Burst.Intrinsics.v64 vqshrun_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138780*/ Unity.Burst.Intrinsics.v64 vqrshrun_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11387c0*/ Unity.Burst.Intrinsics.v64 vqrshrun_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138800*/ Unity.Burst.Intrinsics.v64 vqrshrun_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11399a0*/ Unity.Burst.Intrinsics.v64 vqshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11399e0*/ Unity.Burst.Intrinsics.v64 vqshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139a20*/ Unity.Burst.Intrinsics.v64 vqshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139a60*/ Unity.Burst.Intrinsics.v64 vqshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139aa0*/ Unity.Burst.Intrinsics.v64 vqshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1139ae0*/ Unity.Burst.Intrinsics.v64 vqshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c4f0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c530*/ Unity.Burst.Intrinsics.v64 vrshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c570*/ Unity.Burst.Intrinsics.v64 vrshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c5b0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c5f0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113c630*/ Unity.Burst.Intrinsics.v64 vrshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11383c0*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138400*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138440*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138480*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11384c0*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1138500*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113dfd0*/ Unity.Burst.Intrinsics.v128 vshll_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113df50*/ Unity.Burst.Intrinsics.v128 vshll_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113df90*/ Unity.Burst.Intrinsics.v128 vshll_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e090*/ Unity.Burst.Intrinsics.v128 vshll_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e010*/ Unity.Burst.Intrinsics.v128 vshll_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113e050*/ Unity.Burst.Intrinsics.v128 vshll_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x113f970*/ Unity.Burst.Intrinsics.v64 vsri_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fbf0*/ Unity.Burst.Intrinsics.v128 vsriq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f8b0*/ Unity.Burst.Intrinsics.v64 vsri_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fb30*/ Unity.Burst.Intrinsics.v128 vsriq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f8f0*/ Unity.Burst.Intrinsics.v64 vsri_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fb70*/ Unity.Burst.Intrinsics.v128 vsriq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f930*/ Unity.Burst.Intrinsics.v64 vsri_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fbb0*/ Unity.Burst.Intrinsics.v128 vsriq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113fa70*/ Unity.Burst.Intrinsics.v64 vsri_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fcf0*/ Unity.Burst.Intrinsics.v128 vsriq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f9b0*/ Unity.Burst.Intrinsics.v64 vsri_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fc30*/ Unity.Burst.Intrinsics.v128 vsriq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113f9f0*/ Unity.Burst.Intrinsics.v64 vsri_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fc70*/ Unity.Burst.Intrinsics.v128 vsriq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113fa30*/ Unity.Burst.Intrinsics.v64 vsri_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113fcb0*/ Unity.Burst.Intrinsics.v128 vsriq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ecb0*/ Unity.Burst.Intrinsics.v64 vsli_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113ef30*/ Unity.Burst.Intrinsics.v128 vsliq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ebf0*/ Unity.Burst.Intrinsics.v64 vsli_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113ee70*/ Unity.Burst.Intrinsics.v128 vsliq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ec30*/ Unity.Burst.Intrinsics.v64 vsli_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113eeb0*/ Unity.Burst.Intrinsics.v128 vsliq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ec70*/ Unity.Burst.Intrinsics.v64 vsli_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113eef0*/ Unity.Burst.Intrinsics.v128 vsliq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113edb0*/ Unity.Burst.Intrinsics.v64 vsli_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113f030*/ Unity.Burst.Intrinsics.v128 vsliq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ecf0*/ Unity.Burst.Intrinsics.v64 vsli_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113ef70*/ Unity.Burst.Intrinsics.v128 vsliq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ed30*/ Unity.Burst.Intrinsics.v64 vsli_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113efb0*/ Unity.Burst.Intrinsics.v128 vsliq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113ed70*/ Unity.Burst.Intrinsics.v64 vsli_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113eff0*/ Unity.Burst.Intrinsics.v128 vsliq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1128ed0*/ Unity.Burst.Intrinsics.v64 vcvt_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112a0d0*/ Unity.Burst.Intrinsics.v128 vcvtq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128f50*/ Unity.Burst.Intrinsics.v64 vcvt_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112a150*/ Unity.Burst.Intrinsics.v128 vcvtq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128dd0*/ Unity.Burst.Intrinsics.v64 vcvt_n_s32_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1129fd0*/ Unity.Burst.Intrinsics.v128 vcvtq_n_s32_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1128e50*/ Unity.Burst.Intrinsics.v64 vcvt_n_u32_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a050*/ Unity.Burst.Intrinsics.v128 vcvtq_n_u32_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1128b10*/ Unity.Burst.Intrinsics.v64 vcvt_f32_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129dd0*/ Unity.Burst.Intrinsics.v128 vcvtq_f32_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128b50*/ Unity.Burst.Intrinsics.v64 vcvt_f32_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129e10*/ Unity.Burst.Intrinsics.v128 vcvtq_f32_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128cd0*/ Unity.Burst.Intrinsics.v64 vcvt_n_f32_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1129ed0*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f32_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1128d10*/ Unity.Burst.Intrinsics.v64 vcvt_n_f32_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1129f10*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f32_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1130f60*/ Unity.Burst.Intrinsics.v64 vmovn_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130fa0*/ Unity.Burst.Intrinsics.v64 vmovn_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130fe0*/ Unity.Burst.Intrinsics.v64 vmovn_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1131020*/ Unity.Burst.Intrinsics.v64 vmovn_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1131040*/ Unity.Burst.Intrinsics.v64 vmovn_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1131060*/ Unity.Burst.Intrinsics.v64 vmovn_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130e40*/ Unity.Burst.Intrinsics.v128 vmovn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1130e80*/ Unity.Burst.Intrinsics.v128 vmovn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1130ec0*/ Unity.Burst.Intrinsics.v128 vmovn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1130f00*/ Unity.Burst.Intrinsics.v128 vmovn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1130f20*/ Unity.Burst.Intrinsics.v128 vmovn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1130f40*/ Unity.Burst.Intrinsics.v128 vmovn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1130d40*/ Unity.Burst.Intrinsics.v128 vmovl_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1130cc0*/ Unity.Burst.Intrinsics.v128 vmovl_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1130d00*/ Unity.Burst.Intrinsics.v128 vmovl_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1130e00*/ Unity.Burst.Intrinsics.v128 vmovl_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1130d80*/ Unity.Burst.Intrinsics.v128 vmovl_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1130dc0*/ Unity.Burst.Intrinsics.v128 vmovl_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1136600*/ Unity.Burst.Intrinsics.v64 vqmovn_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136640*/ Unity.Burst.Intrinsics.v64 vqmovn_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136680*/ Unity.Burst.Intrinsics.v64 vqmovn_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11366c0*/ Unity.Burst.Intrinsics.v64 vqmovn_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136700*/ Unity.Burst.Intrinsics.v64 vqmovn_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136740*/ Unity.Burst.Intrinsics.v64 vqmovn_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11369c0*/ Unity.Burst.Intrinsics.v64 vqmovun_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136a00*/ Unity.Burst.Intrinsics.v64 vqmovun_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136a40*/ Unity.Burst.Intrinsics.v64 vqmovun_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e420*/ Unity.Burst.Intrinsics.v64 vmla_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f250*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e460*/ Unity.Burst.Intrinsics.v64 vmla_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f290*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e4a0*/ Unity.Burst.Intrinsics.v64 vmla_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f2d0*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e4e0*/ Unity.Burst.Intrinsics.v64 vmla_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f310*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e3e0*/ Unity.Burst.Intrinsics.v64 vmla_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f210*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112ed10*/ Unity.Burst.Intrinsics.v128 vmlal_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112ed50*/ Unity.Burst.Intrinsics.v128 vmlal_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112ed90*/ Unity.Burst.Intrinsics.v128 vmlal_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112edd0*/ Unity.Burst.Intrinsics.v128 vmlal_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135080*/ Unity.Burst.Intrinsics.v128 vqdmlal_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11350c0*/ Unity.Burst.Intrinsics.v128 vqdmlal_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f810*/ Unity.Burst.Intrinsics.v64 vmls_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130640*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f850*/ Unity.Burst.Intrinsics.v64 vmls_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130680*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f890*/ Unity.Burst.Intrinsics.v64 vmls_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11306c0*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f8d0*/ Unity.Burst.Intrinsics.v64 vmls_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130700*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112f7d0*/ Unity.Burst.Intrinsics.v64 vmls_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130600*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130100*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130140*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130180*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11301c0*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135600*/ Unity.Burst.Intrinsics.v128 vqdmlsl_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135640*/ Unity.Burst.Intrinsics.v128 vqdmlsl_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1131450*/ Unity.Burst.Intrinsics.v64 vmul_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x11323a0*/ Unity.Burst.Intrinsics.v128 vmulq_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x1131490*/ Unity.Burst.Intrinsics.v64 vmul_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x11323e0*/ Unity.Burst.Intrinsics.v128 vmulq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11314d0*/ Unity.Burst.Intrinsics.v64 vmul_n_u16(Unity.Burst.Intrinsics.v64 a0, ushort a1);
                    static /*0x1132420*/ Unity.Burst.Intrinsics.v128 vmulq_n_u16(Unity.Burst.Intrinsics.v128 a0, ushort a1);
                    static /*0x1131510*/ Unity.Burst.Intrinsics.v64 vmul_n_u32(Unity.Burst.Intrinsics.v64 a0, uint a1);
                    static /*0x1132460*/ Unity.Burst.Intrinsics.v128 vmulq_n_u32(Unity.Burst.Intrinsics.v128 a0, uint a1);
                    static /*0x11313d0*/ Unity.Burst.Intrinsics.v64 vmul_n_f32(Unity.Burst.Intrinsics.v64 a0, float a1);
                    static /*0x1132320*/ Unity.Burst.Intrinsics.v128 vmulq_n_f32(Unity.Burst.Intrinsics.v128 a0, float a1);
                    static /*0x1131150*/ Unity.Burst.Intrinsics.v64 vmul_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11320a0*/ Unity.Burst.Intrinsics.v128 vmulq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131190*/ Unity.Burst.Intrinsics.v64 vmul_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11320e0*/ Unity.Burst.Intrinsics.v128 vmulq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11311d0*/ Unity.Burst.Intrinsics.v64 vmul_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132120*/ Unity.Burst.Intrinsics.v128 vmulq_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131210*/ Unity.Burst.Intrinsics.v64 vmul_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132160*/ Unity.Burst.Intrinsics.v128 vmulq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131100*/ Unity.Burst.Intrinsics.v64 vmul_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132020*/ Unity.Burst.Intrinsics.v128 vmulq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131d20*/ Unity.Burst.Intrinsics.v128 vmull_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x1131d60*/ Unity.Burst.Intrinsics.v128 vmull_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1131da0*/ Unity.Burst.Intrinsics.v128 vmull_n_u16(Unity.Burst.Intrinsics.v64 a0, ushort a1);
                    static /*0x1131de0*/ Unity.Burst.Intrinsics.v128 vmull_n_u32(Unity.Burst.Intrinsics.v64 a0, uint a1);
                    static /*0x1131b20*/ Unity.Burst.Intrinsics.v128 vmull_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131b60*/ Unity.Burst.Intrinsics.v128 vmull_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131ba0*/ Unity.Burst.Intrinsics.v128 vmull_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131be0*/ Unity.Burst.Intrinsics.v128 vmull_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1136200*/ Unity.Burst.Intrinsics.v128 vqdmull_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x1136240*/ Unity.Burst.Intrinsics.v128 vqdmull_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1136100*/ Unity.Burst.Intrinsics.v128 vqdmull_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1136140*/ Unity.Burst.Intrinsics.v128 vqdmull_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135a80*/ Unity.Burst.Intrinsics.v64 vqdmulh_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x1135d40*/ Unity.Burst.Intrinsics.v128 vqdmulhq_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x1135ac0*/ Unity.Burst.Intrinsics.v64 vqdmulh_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1135d80*/ Unity.Burst.Intrinsics.v128 vqdmulhq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1135980*/ Unity.Burst.Intrinsics.v64 vqdmulh_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135c40*/ Unity.Burst.Intrinsics.v128 vqdmulhq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11359c0*/ Unity.Burst.Intrinsics.v64 vqdmulh_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135c80*/ Unity.Burst.Intrinsics.v128 vqdmulhq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11377c0*/ Unity.Burst.Intrinsics.v64 vqrdmulh_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x1137a80*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x1137800*/ Unity.Burst.Intrinsics.v64 vqrdmulh_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1137ac0*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11376c0*/ Unity.Burst.Intrinsics.v64 vqrdmulh_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1137980*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1137700*/ Unity.Burst.Intrinsics.v64 vqrdmulh_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11379c0*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112e6a0*/ Unity.Burst.Intrinsics.v64 vmla_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x112f4d0*/ Unity.Burst.Intrinsics.v128 vmlaq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x112e6e0*/ Unity.Burst.Intrinsics.v64 vmla_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112f510*/ Unity.Burst.Intrinsics.v128 vmlaq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112e720*/ Unity.Burst.Intrinsics.v64 vmla_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x112f550*/ Unity.Burst.Intrinsics.v128 vmlaq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x112e760*/ Unity.Burst.Intrinsics.v64 vmla_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x112f590*/ Unity.Burst.Intrinsics.v128 vmlaq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x112e660*/ Unity.Burst.Intrinsics.v64 vmla_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x112f490*/ Unity.Burst.Intrinsics.v128 vmlaq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x112ef10*/ Unity.Burst.Intrinsics.v128 vmlal_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x112ef50*/ Unity.Burst.Intrinsics.v128 vmlal_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112ef90*/ Unity.Burst.Intrinsics.v128 vmlal_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x112efd0*/ Unity.Burst.Intrinsics.v128 vmlal_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x1135180*/ Unity.Burst.Intrinsics.v128 vqdmlal_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x11351c0*/ Unity.Burst.Intrinsics.v128 vqdmlal_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112fa90*/ Unity.Burst.Intrinsics.v64 vmls_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x11308c0*/ Unity.Burst.Intrinsics.v128 vmlsq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x112fad0*/ Unity.Burst.Intrinsics.v64 vmls_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1130900*/ Unity.Burst.Intrinsics.v128 vmlsq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112fb10*/ Unity.Burst.Intrinsics.v64 vmls_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x1130940*/ Unity.Burst.Intrinsics.v128 vmlsq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x112fb50*/ Unity.Burst.Intrinsics.v64 vmls_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x1130980*/ Unity.Burst.Intrinsics.v128 vmlsq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x112fa50*/ Unity.Burst.Intrinsics.v64 vmls_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x1130880*/ Unity.Burst.Intrinsics.v128 vmlsq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x1130300*/ Unity.Burst.Intrinsics.v128 vmlsl_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x1130340*/ Unity.Burst.Intrinsics.v128 vmlsl_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1130380*/ Unity.Burst.Intrinsics.v128 vmlsl_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x11303c0*/ Unity.Burst.Intrinsics.v128 vmlsl_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x1135700*/ Unity.Burst.Intrinsics.v128 vqdmlsl_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x1135740*/ Unity.Burst.Intrinsics.v128 vqdmlsl_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1122c50*/ Unity.Burst.Intrinsics.v64 vabs_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1122e10*/ Unity.Burst.Intrinsics.v128 vabsq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1122b90*/ Unity.Burst.Intrinsics.v64 vabs_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1122d50*/ Unity.Burst.Intrinsics.v128 vabsq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1122bd0*/ Unity.Burst.Intrinsics.v64 vabs_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1122d90*/ Unity.Burst.Intrinsics.v128 vabsq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1122b10*/ Unity.Burst.Intrinsics.v64 vabs_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1122cd0*/ Unity.Burst.Intrinsics.v128 vabsq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1134640*/ Unity.Burst.Intrinsics.v64 vqabs_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1134800*/ Unity.Burst.Intrinsics.v128 vqabsq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1134580*/ Unity.Burst.Intrinsics.v64 vqabs_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1134740*/ Unity.Burst.Intrinsics.v128 vqabsq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11345c0*/ Unity.Burst.Intrinsics.v64 vqabs_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1134780*/ Unity.Burst.Intrinsics.v128 vqabsq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132c90*/ Unity.Burst.Intrinsics.v64 vneg_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132e50*/ Unity.Burst.Intrinsics.v128 vnegq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132bd0*/ Unity.Burst.Intrinsics.v64 vneg_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132d90*/ Unity.Burst.Intrinsics.v128 vnegq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132c10*/ Unity.Burst.Intrinsics.v64 vneg_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132dd0*/ Unity.Burst.Intrinsics.v128 vnegq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132b50*/ Unity.Burst.Intrinsics.v64 vneg_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132d10*/ Unity.Burst.Intrinsics.v128 vnegq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136c00*/ Unity.Burst.Intrinsics.v64 vqneg_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1136dc0*/ Unity.Burst.Intrinsics.v128 vqnegq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136b40*/ Unity.Burst.Intrinsics.v64 vqneg_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1136d00*/ Unity.Burst.Intrinsics.v128 vqnegq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136b80*/ Unity.Burst.Intrinsics.v64 vqneg_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1136d40*/ Unity.Burst.Intrinsics.v128 vqnegq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11273b0*/ Unity.Burst.Intrinsics.v64 vcls_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127470*/ Unity.Burst.Intrinsics.v128 vclsq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127330*/ Unity.Burst.Intrinsics.v64 vcls_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11273f0*/ Unity.Burst.Intrinsics.v128 vclsq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127370*/ Unity.Burst.Intrinsics.v64 vcls_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127430*/ Unity.Burst.Intrinsics.v128 vclsq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127ef0*/ Unity.Burst.Intrinsics.v64 vclz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127fe0*/ Unity.Burst.Intrinsics.v128 vclzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127e70*/ Unity.Burst.Intrinsics.v64 vclz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127f60*/ Unity.Burst.Intrinsics.v128 vclzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127eb0*/ Unity.Burst.Intrinsics.v64 vclz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127fa0*/ Unity.Burst.Intrinsics.v128 vclzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127f50*/ Unity.Burst.Intrinsics.v64 vclz_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1128060*/ Unity.Burst.Intrinsics.v128 vclzq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127f30*/ Unity.Burst.Intrinsics.v64 vclz_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1128020*/ Unity.Burst.Intrinsics.v128 vclzq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127f40*/ Unity.Burst.Intrinsics.v64 vclz_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1128040*/ Unity.Burst.Intrinsics.v128 vclzq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128080*/ Unity.Burst.Intrinsics.v64 vcnt_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11280d0*/ Unity.Burst.Intrinsics.v128 vcntq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11280c0*/ Unity.Burst.Intrinsics.v64 vcnt_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1128110*/ Unity.Burst.Intrinsics.v128 vcntq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113aa90*/ Unity.Burst.Intrinsics.v64 vrecpe_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ab90*/ Unity.Burst.Intrinsics.v128 vrecpeq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113aa10*/ Unity.Burst.Intrinsics.v64 vrecpe_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ab10*/ Unity.Burst.Intrinsics.v128 vrecpeq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113ac10*/ Unity.Burst.Intrinsics.v64 vrecps_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113acd0*/ Unity.Burst.Intrinsics.v128 vrecpsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113c9b0*/ Unity.Burst.Intrinsics.v64 vrsqrte_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113cab0*/ Unity.Burst.Intrinsics.v128 vrsqrteq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113c930*/ Unity.Burst.Intrinsics.v64 vrsqrte_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ca30*/ Unity.Burst.Intrinsics.v128 vrsqrteq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113cb30*/ Unity.Burst.Intrinsics.v64 vrsqrts_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113cbf0*/ Unity.Burst.Intrinsics.v128 vrsqrtsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132ab0*/ Unity.Burst.Intrinsics.v64 vmvn_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132b10*/ Unity.Burst.Intrinsics.v128 vmvnq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132aa0*/ Unity.Burst.Intrinsics.v64 vmvn_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132af0*/ Unity.Burst.Intrinsics.v128 vmvnq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132aa0*/ Unity.Burst.Intrinsics.v64 vmvn_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132af0*/ Unity.Burst.Intrinsics.v128 vmvnq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132aa0*/ Unity.Burst.Intrinsics.v64 vmvn_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132af0*/ Unity.Burst.Intrinsics.v128 vmvnq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132aa0*/ Unity.Burst.Intrinsics.v64 vmvn_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132af0*/ Unity.Burst.Intrinsics.v128 vmvnq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132aa0*/ Unity.Burst.Intrinsics.v64 vmvn_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132af0*/ Unity.Burst.Intrinsics.v128 vmvnq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11243f0*/ Unity.Burst.Intrinsics.v64 vand_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124460*/ Unity.Burst.Intrinsics.v128 vandq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243e0*/ Unity.Burst.Intrinsics.v64 vand_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124430*/ Unity.Burst.Intrinsics.v128 vandq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f60*/ Unity.Burst.Intrinsics.v64 vorr_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fd0*/ Unity.Burst.Intrinsics.v128 vorrq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132f50*/ Unity.Burst.Intrinsics.v64 vorr_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132fa0*/ Unity.Burst.Intrinsics.v128 vorrq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b750*/ Unity.Burst.Intrinsics.v64 veor_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b7c0*/ Unity.Burst.Intrinsics.v128 veorq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112b740*/ Unity.Burst.Intrinsics.v64 veor_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b790*/ Unity.Burst.Intrinsics.v128 veorq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244b0*/ Unity.Burst.Intrinsics.v64 vbic_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124520*/ Unity.Burst.Intrinsics.v128 vbicq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11244a0*/ Unity.Burst.Intrinsics.v64 vbic_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11244f0*/ Unity.Burst.Intrinsics.v128 vbicq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132ea0*/ Unity.Burst.Intrinsics.v64 vorn_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132f10*/ Unity.Burst.Intrinsics.v128 vornq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132e90*/ Unity.Burst.Intrinsics.v64 vorn_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132ee0*/ Unity.Burst.Intrinsics.v128 vornq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124570*/ Unity.Burst.Intrinsics.v64 vbsl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245f0*/ Unity.Burst.Intrinsics.v128 vbslq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112a950*/ Unity.Burst.Intrinsics.v64 vdup_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b180*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a8d0*/ Unity.Burst.Intrinsics.v64 vdup_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b100*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a910*/ Unity.Burst.Intrinsics.v64 vdup_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b140*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x621ca0*/ Unity.Burst.Intrinsics.v64 vdup_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b0d0*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112aa10*/ Unity.Burst.Intrinsics.v64 vdup_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b240*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a990*/ Unity.Burst.Intrinsics.v64 vdup_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b1c0*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a9d0*/ Unity.Burst.Intrinsics.v64 vdup_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b200*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x621ca0*/ Unity.Burst.Intrinsics.v64 vdup_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b0d0*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a890*/ Unity.Burst.Intrinsics.v64 vdup_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b090*/ Unity.Burst.Intrinsics.v128 vdupq_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x11333d0*/ Unity.Burst.Intrinsics.v64 vpadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133350*/ Unity.Burst.Intrinsics.v64 vpadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133390*/ Unity.Burst.Intrinsics.v64 vpadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133430*/ Unity.Burst.Intrinsics.v64 vpadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133410*/ Unity.Burst.Intrinsics.v64 vpadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133420*/ Unity.Burst.Intrinsics.v64 vpadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133310*/ Unity.Burst.Intrinsics.v64 vpadd_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133580*/ Unity.Burst.Intrinsics.v64 vpaddl_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133700*/ Unity.Burst.Intrinsics.v128 vpaddlq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133500*/ Unity.Burst.Intrinsics.v64 vpaddl_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133680*/ Unity.Burst.Intrinsics.v128 vpaddlq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133540*/ Unity.Burst.Intrinsics.v64 vpaddl_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11336c0*/ Unity.Burst.Intrinsics.v128 vpaddlq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133640*/ Unity.Burst.Intrinsics.v64 vpaddl_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11337c0*/ Unity.Burst.Intrinsics.v128 vpaddlq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11335c0*/ Unity.Burst.Intrinsics.v64 vpaddl_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133740*/ Unity.Burst.Intrinsics.v128 vpaddlq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133600*/ Unity.Burst.Intrinsics.v64 vpaddl_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133780*/ Unity.Burst.Intrinsics.v128 vpaddlq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133090*/ Unity.Burst.Intrinsics.v64 vpadal_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133210*/ Unity.Burst.Intrinsics.v128 vpadalq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133010*/ Unity.Burst.Intrinsics.v64 vpadal_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133190*/ Unity.Burst.Intrinsics.v128 vpadalq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133050*/ Unity.Burst.Intrinsics.v64 vpadal_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11331d0*/ Unity.Burst.Intrinsics.v128 vpadalq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133150*/ Unity.Burst.Intrinsics.v64 vpadal_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11332d0*/ Unity.Burst.Intrinsics.v128 vpadalq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11330d0*/ Unity.Burst.Intrinsics.v64 vpadal_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133250*/ Unity.Burst.Intrinsics.v128 vpadalq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133110*/ Unity.Burst.Intrinsics.v64 vpadal_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133290*/ Unity.Burst.Intrinsics.v128 vpadalq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133b40*/ Unity.Burst.Intrinsics.v64 vpmax_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133ac0*/ Unity.Burst.Intrinsics.v64 vpmax_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133b00*/ Unity.Burst.Intrinsics.v64 vpmax_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133c00*/ Unity.Burst.Intrinsics.v64 vpmax_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133b80*/ Unity.Burst.Intrinsics.v64 vpmax_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133bc0*/ Unity.Burst.Intrinsics.v64 vpmax_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133a80*/ Unity.Burst.Intrinsics.v64 vpmax_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11340c0*/ Unity.Burst.Intrinsics.v64 vpmin_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134040*/ Unity.Burst.Intrinsics.v64 vpmin_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134080*/ Unity.Burst.Intrinsics.v64 vpmin_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134180*/ Unity.Burst.Intrinsics.v64 vpmin_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134100*/ Unity.Burst.Intrinsics.v64 vpmin_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134140*/ Unity.Burst.Intrinsics.v64 vpmin_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134000*/ Unity.Burst.Intrinsics.v64 vpmin_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112b8c0*/ Unity.Burst.Intrinsics.v64 vext_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112bb00*/ Unity.Burst.Intrinsics.v128 vextq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112b840*/ Unity.Burst.Intrinsics.v64 vext_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112ba40*/ Unity.Burst.Intrinsics.v128 vextq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112b880*/ Unity.Burst.Intrinsics.v64 vext_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112ba80*/ Unity.Burst.Intrinsics.v128 vextq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x621ca0*/ Unity.Burst.Intrinsics.v64 vext_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112bac0*/ Unity.Burst.Intrinsics.v128 vextq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112b980*/ Unity.Burst.Intrinsics.v64 vext_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112bc00*/ Unity.Burst.Intrinsics.v128 vextq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112b900*/ Unity.Burst.Intrinsics.v64 vext_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112bb40*/ Unity.Burst.Intrinsics.v128 vextq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112b940*/ Unity.Burst.Intrinsics.v64 vext_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112bb80*/ Unity.Burst.Intrinsics.v128 vextq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x621ca0*/ Unity.Burst.Intrinsics.v64 vext_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112bbc0*/ Unity.Burst.Intrinsics.v128 vextq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112b800*/ Unity.Burst.Intrinsics.v64 vext_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112b9c0*/ Unity.Burst.Intrinsics.v128 vextq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113b0b0*/ Unity.Burst.Intrinsics.v64 vrev64_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b1b0*/ Unity.Burst.Intrinsics.v128 vrev64q_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b030*/ Unity.Burst.Intrinsics.v64 vrev64_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b130*/ Unity.Burst.Intrinsics.v128 vrev64q_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b070*/ Unity.Burst.Intrinsics.v64 vrev64_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b170*/ Unity.Burst.Intrinsics.v128 vrev64q_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b100*/ Unity.Burst.Intrinsics.v64 vrev64_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b210*/ Unity.Burst.Intrinsics.v128 vrev64q_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b0f0*/ Unity.Burst.Intrinsics.v64 vrev64_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b1f0*/ Unity.Burst.Intrinsics.v128 vrev64q_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b020*/ Unity.Burst.Intrinsics.v64 vrev64_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b110*/ Unity.Burst.Intrinsics.v128 vrev64q_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b020*/ Unity.Burst.Intrinsics.v64 vrev64_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b110*/ Unity.Burst.Intrinsics.v128 vrev64q_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113af00*/ Unity.Burst.Intrinsics.v64 vrev32_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113afa0*/ Unity.Burst.Intrinsics.v128 vrev32q_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113aec0*/ Unity.Burst.Intrinsics.v64 vrev32_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113af60*/ Unity.Burst.Intrinsics.v128 vrev32q_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113af50*/ Unity.Burst.Intrinsics.v64 vrev32_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b000*/ Unity.Burst.Intrinsics.v128 vrev32q_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113af40*/ Unity.Burst.Intrinsics.v64 vrev32_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113afe0*/ Unity.Burst.Intrinsics.v128 vrev32q_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113ae10*/ Unity.Burst.Intrinsics.v64 vrev16_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ae60*/ Unity.Burst.Intrinsics.v128 vrev16q_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113ae50*/ Unity.Burst.Intrinsics.v64 vrev16_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113aea0*/ Unity.Burst.Intrinsics.v128 vrev16q_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1140a80*/ Unity.Burst.Intrinsics.v64 vtbl1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140ac0*/ Unity.Burst.Intrinsics.v64 vtbl1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140ad0*/ Unity.Burst.Intrinsics.v64 vtbx1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1140b10*/ Unity.Burst.Intrinsics.v64 vtbx1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112c7a0*/ byte vget_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c720*/ ushort vget_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c760*/ uint vget_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x621ca0*/ ulong vget_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c6e0*/ sbyte vget_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c660*/ short vget_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c6a0*/ int vget_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x621ca0*/ long vget_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c620*/ float vget_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112ca20*/ byte vgetq_lane_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c960*/ ushort vgetq_lane_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c9a0*/ uint vgetq_lane_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c9e0*/ ulong vgetq_lane_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c920*/ sbyte vgetq_lane_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c860*/ short vgetq_lane_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c8a0*/ int vgetq_lane_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c8e0*/ long vgetq_lane_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112c7e0*/ float vgetq_lane_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113d400*/ Unity.Burst.Intrinsics.v64 vset_lane_u8(byte a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d380*/ Unity.Burst.Intrinsics.v64 vset_lane_u16(ushort a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d3c0*/ Unity.Burst.Intrinsics.v64 vset_lane_u32(uint a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vset_lane_u64(ulong a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d340*/ Unity.Burst.Intrinsics.v64 vset_lane_s8(sbyte a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d2c0*/ Unity.Burst.Intrinsics.v64 vset_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d300*/ Unity.Burst.Intrinsics.v64 vset_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vset_lane_s64(long a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d280*/ Unity.Burst.Intrinsics.v64 vset_lane_f32(float a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d680*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u8(byte a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d5c0*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u16(ushort a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d600*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u32(uint a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d640*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u64(ulong a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d580*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s8(sbyte a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d4c0*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d500*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d540*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s64(long a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113d440*/ Unity.Burst.Intrinsics.v128 vsetq_lane_f32(float a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112bd90*/ Unity.Burst.Intrinsics.v64 vfma_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x112c030*/ Unity.Burst.Intrinsics.v128 vfmaq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x348b00*/ bool get_IsNeonArmv82FeaturesSupported();
                    static /*0x1122e90*/ Unity.Burst.Intrinsics.v64 vadd_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11239a0*/ Unity.Burst.Intrinsics.v128 vaddq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123010*/ long vaddd_s64(long a0, long a1);
                    static /*0x1123050*/ ulong vaddd_u64(ulong a0, ulong a1);
                    static /*0x11233e0*/ Unity.Burst.Intrinsics.v128 vaddl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123360*/ Unity.Burst.Intrinsics.v128 vaddl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11233a0*/ Unity.Burst.Intrinsics.v128 vaddl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11234a0*/ Unity.Burst.Intrinsics.v128 vaddl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123420*/ Unity.Burst.Intrinsics.v128 vaddl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123460*/ Unity.Burst.Intrinsics.v128 vaddl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124060*/ Unity.Burst.Intrinsics.v128 vaddw_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1123fe0*/ Unity.Burst.Intrinsics.v128 vaddw_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124020*/ Unity.Burst.Intrinsics.v128 vaddw_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124120*/ Unity.Burst.Intrinsics.v128 vaddw_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11240a0*/ Unity.Burst.Intrinsics.v128 vaddw_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11240e0*/ Unity.Burst.Intrinsics.v128 vaddw_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134a80*/ sbyte vqaddb_s8(sbyte a0, sbyte a1);
                    static /*0x1134b80*/ short vqaddh_s16(short a0, short a1);
                    static /*0x1134e00*/ int vqadds_s32(int a0, int a1);
                    static /*0x1134b00*/ long vqaddd_s64(long a0, long a1);
                    static /*0x1134ac0*/ byte vqaddb_u8(byte a0, byte a1);
                    static /*0x1134bc0*/ ushort vqaddh_u16(ushort a0, ushort a1);
                    static /*0x1134e40*/ uint vqadds_u32(uint a0, uint a1);
                    static /*0x1134b40*/ ulong vqaddd_u64(ulong a0, ulong a1);
                    static /*0x11414c0*/ Unity.Burst.Intrinsics.v64 vuqadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141680*/ Unity.Burst.Intrinsics.v128 vuqaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141400*/ Unity.Burst.Intrinsics.v64 vuqadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11415c0*/ Unity.Burst.Intrinsics.v128 vuqaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141440*/ Unity.Burst.Intrinsics.v64 vuqadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141600*/ Unity.Burst.Intrinsics.v128 vuqaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141480*/ Unity.Burst.Intrinsics.v64 vuqadd_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141640*/ Unity.Burst.Intrinsics.v128 vuqaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141500*/ sbyte vuqaddb_s8(sbyte a0, byte a1);
                    static /*0x1141580*/ short vuqaddh_s16(short a0, ushort a1);
                    static /*0x11416c0*/ int vuqadds_s32(int a0, uint a1);
                    static /*0x1141540*/ long vuqaddd_s64(long a0, ulong a1);
                    static /*0x113f130*/ Unity.Burst.Intrinsics.v64 vsqadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113f2f0*/ Unity.Burst.Intrinsics.v128 vsqaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113f070*/ Unity.Burst.Intrinsics.v64 vsqadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113f230*/ Unity.Burst.Intrinsics.v128 vsqaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113f0b0*/ Unity.Burst.Intrinsics.v64 vsqadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113f270*/ Unity.Burst.Intrinsics.v128 vsqaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113f0f0*/ Unity.Burst.Intrinsics.v64 vsqadd_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113f2b0*/ Unity.Burst.Intrinsics.v128 vsqaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113f170*/ byte vsqaddb_u8(byte a0, sbyte a1);
                    static /*0x113f1f0*/ ushort vsqaddh_u16(ushort a0, short a1);
                    static /*0x113f330*/ uint vsqadds_u32(uint a0, int a1);
                    static /*0x113f1b0*/ ulong vsqaddd_u64(ulong a0, long a1);
                    static /*0x1123090*/ Unity.Burst.Intrinsics.v128 vaddhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11230d0*/ Unity.Burst.Intrinsics.v128 vaddhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1123110*/ Unity.Burst.Intrinsics.v128 vaddhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1123150*/ Unity.Burst.Intrinsics.v128 vaddhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1123190*/ Unity.Burst.Intrinsics.v128 vaddhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11231d0*/ Unity.Burst.Intrinsics.v128 vaddhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a690*/ Unity.Burst.Intrinsics.v128 vraddhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a6d0*/ Unity.Burst.Intrinsics.v128 vraddhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a710*/ Unity.Burst.Intrinsics.v128 vraddhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a750*/ Unity.Burst.Intrinsics.v128 vraddhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a790*/ Unity.Burst.Intrinsics.v128 vraddhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a7d0*/ Unity.Burst.Intrinsics.v128 vraddhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11310c0*/ Unity.Burst.Intrinsics.v64 vmul_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1131fe0*/ Unity.Burst.Intrinsics.v128 vmulq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1132670*/ Unity.Burst.Intrinsics.v64 vmulx_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1132860*/ Unity.Burst.Intrinsics.v128 vmulxq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11326b0*/ Unity.Burst.Intrinsics.v64 vmulx_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11328a0*/ Unity.Burst.Intrinsics.v128 vmulxq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11329e0*/ float vmulxs_f32(float a0, float a1);
                    static /*0x11327c0*/ double vmulxd_f64(double a0, double a1);
                    static /*0x11326f0*/ Unity.Burst.Intrinsics.v64 vmulx_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11328e0*/ Unity.Burst.Intrinsics.v128 vmulxq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132730*/ Unity.Burst.Intrinsics.v64 vmulx_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132920*/ Unity.Burst.Intrinsics.v128 vmulxq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132a20*/ float vmulxs_lane_f32(float a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132800*/ double vmulxd_lane_f64(double a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132740*/ Unity.Burst.Intrinsics.v64 vmulx_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132960*/ Unity.Burst.Intrinsics.v128 vmulxq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132780*/ Unity.Burst.Intrinsics.v64 vmulx_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11329a0*/ Unity.Burst.Intrinsics.v128 vmulxq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132a60*/ float vmulxs_laneq_f32(float a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132820*/ double vmulxd_laneq_f64(double a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112a490*/ Unity.Burst.Intrinsics.v64 vdiv_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112a510*/ Unity.Burst.Intrinsics.v128 vdivq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112a4d0*/ Unity.Burst.Intrinsics.v64 vdiv_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112a550*/ Unity.Burst.Intrinsics.v128 vdivq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112e3a0*/ Unity.Burst.Intrinsics.v64 vmla_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112f1d0*/ Unity.Burst.Intrinsics.v128 vmlaq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ec10*/ Unity.Burst.Intrinsics.v128 vmlal_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112eb90*/ Unity.Burst.Intrinsics.v128 vmlal_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ebd0*/ Unity.Burst.Intrinsics.v128 vmlal_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ecd0*/ Unity.Burst.Intrinsics.v128 vmlal_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ec50*/ Unity.Burst.Intrinsics.v128 vmlal_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ec90*/ Unity.Burst.Intrinsics.v128 vmlal_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112f790*/ Unity.Burst.Intrinsics.v64 vmls_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11305c0*/ Unity.Burst.Intrinsics.v128 vmlsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1130000*/ Unity.Burst.Intrinsics.v128 vmlsl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ff80*/ Unity.Burst.Intrinsics.v128 vmlsl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112ffc0*/ Unity.Burst.Intrinsics.v128 vmlsl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11300c0*/ Unity.Burst.Intrinsics.v128 vmlsl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1130040*/ Unity.Burst.Intrinsics.v128 vmlsl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1130080*/ Unity.Burst.Intrinsics.v128 vmlsl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112bc80*/ Unity.Burst.Intrinsics.v64 vfma_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112bef0*/ Unity.Burst.Intrinsics.v128 vfmaq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112bcc0*/ Unity.Burst.Intrinsics.v64 vfma_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112bf30*/ Unity.Burst.Intrinsics.v128 vfmaq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112bd00*/ Unity.Burst.Intrinsics.v64 vfma_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112bf70*/ Unity.Burst.Intrinsics.v128 vfmaq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c0b0*/ float vfmas_lane_f32(float a0, float a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112be10*/ double vfmad_lane_f64(double a0, double a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112bd10*/ Unity.Burst.Intrinsics.v64 vfma_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112bfb0*/ Unity.Burst.Intrinsics.v128 vfmaq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112bd50*/ Unity.Burst.Intrinsics.v64 vfma_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112bff0*/ Unity.Burst.Intrinsics.v128 vfmaq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c0f0*/ float vfmas_laneq_f32(float a0, float a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112be70*/ double vfmad_laneq_f64(double a0, double a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c170*/ Unity.Burst.Intrinsics.v64 vfms_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112c3e0*/ Unity.Burst.Intrinsics.v128 vfmsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112c1b0*/ Unity.Burst.Intrinsics.v64 vfms_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c420*/ Unity.Burst.Intrinsics.v128 vfmsq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c1f0*/ Unity.Burst.Intrinsics.v64 vfms_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c460*/ Unity.Burst.Intrinsics.v128 vfmsq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c5a0*/ float vfmss_lane_f32(float a0, float a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c300*/ double vfmsd_lane_f64(double a0, double a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112c200*/ Unity.Burst.Intrinsics.v64 vfms_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c4a0*/ Unity.Burst.Intrinsics.v128 vfmsq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c240*/ Unity.Burst.Intrinsics.v64 vfms_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c4e0*/ Unity.Burst.Intrinsics.v128 vfmsq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c5e0*/ float vfmss_laneq_f32(float a0, float a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112c360*/ double vfmsd_laneq_f64(double a0, double a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135c00*/ short vqdmulhh_s16(short a0, short a1);
                    static /*0x1135ec0*/ int vqdmulhs_s32(int a0, int a1);
                    static /*0x1137940*/ short vqrdmulhh_s16(short a0, short a1);
                    static /*0x1137c00*/ int vqrdmulhs_s32(int a0, int a1);
                    static /*0x1135300*/ int vqdmlalh_s16(int a0, short a1, short a2);
                    static /*0x11353c0*/ long vqdmlals_s32(long a0, int a1, int a2);
                    static /*0x1135000*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1135040*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1135880*/ int vqdmlslh_s16(int a0, short a1, short a2);
                    static /*0x1135940*/ long vqdmlsls_s32(long a0, int a1, int a2);
                    static /*0x1135580*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11355c0*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1131a20*/ Unity.Burst.Intrinsics.v128 vmull_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11319a0*/ Unity.Burst.Intrinsics.v128 vmull_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11319e0*/ Unity.Burst.Intrinsics.v128 vmull_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131ae0*/ Unity.Burst.Intrinsics.v128 vmull_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131a60*/ Unity.Burst.Intrinsics.v128 vmull_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1131aa0*/ Unity.Burst.Intrinsics.v128 vmull_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136380*/ int vqdmullh_s16(short a0, short a1);
                    static /*0x1136440*/ long vqdmulls_s32(int a0, int a1);
                    static /*0x1136080*/ Unity.Burst.Intrinsics.v128 vqdmull_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11360c0*/ Unity.Burst.Intrinsics.v128 vqdmull_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fd70*/ Unity.Burst.Intrinsics.v64 vsub_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140580*/ Unity.Burst.Intrinsics.v128 vsubq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113fef0*/ long vsubd_s64(long a0, long a1);
                    static /*0x113ff30*/ ulong vsubd_u64(ulong a0, ulong a1);
                    static /*0x11402c0*/ Unity.Burst.Intrinsics.v128 vsubl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140240*/ Unity.Burst.Intrinsics.v128 vsubl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140280*/ Unity.Burst.Intrinsics.v128 vsubl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140380*/ Unity.Burst.Intrinsics.v128 vsubl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140300*/ Unity.Burst.Intrinsics.v128 vsubl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140340*/ Unity.Burst.Intrinsics.v128 vsubl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140800*/ Unity.Burst.Intrinsics.v128 vsubw_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140780*/ Unity.Burst.Intrinsics.v128 vsubw_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11407c0*/ Unity.Burst.Intrinsics.v128 vsubw_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11408c0*/ Unity.Burst.Intrinsics.v128 vsubw_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140840*/ Unity.Burst.Intrinsics.v128 vsubw_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140880*/ Unity.Burst.Intrinsics.v128 vsubw_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a0e0*/ sbyte vqsubb_s8(sbyte a0, sbyte a1);
                    static /*0x113a1e0*/ short vqsubh_s16(short a0, short a1);
                    static /*0x113a460*/ int vqsubs_s32(int a0, int a1);
                    static /*0x113a160*/ long vqsubd_s64(long a0, long a1);
                    static /*0x113a120*/ byte vqsubb_u8(byte a0, byte a1);
                    static /*0x113a220*/ ushort vqsubh_u16(ushort a0, ushort a1);
                    static /*0x113a4a0*/ uint vqsubs_u32(uint a0, uint a1);
                    static /*0x113a1a0*/ ulong vqsubd_u64(ulong a0, ulong a1);
                    static /*0x113ff70*/ Unity.Burst.Intrinsics.v128 vsubhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113ffb0*/ Unity.Burst.Intrinsics.v128 vsubhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113fff0*/ Unity.Burst.Intrinsics.v128 vsubhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1140030*/ Unity.Burst.Intrinsics.v128 vsubhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1140070*/ Unity.Burst.Intrinsics.v128 vsubhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11400b0*/ Unity.Burst.Intrinsics.v128 vsubhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113cfb0*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113cff0*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d030*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d070*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d0b0*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d0f0*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1124d30*/ Unity.Burst.Intrinsics.v64 vceq_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124fb0*/ Unity.Burst.Intrinsics.v128 vceqq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124dd0*/ Unity.Burst.Intrinsics.v64 vceq_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125090*/ Unity.Burst.Intrinsics.v128 vceqq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124c70*/ Unity.Burst.Intrinsics.v64 vceq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124ef0*/ Unity.Burst.Intrinsics.v128 vceqq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124e30*/ ulong vceqd_s64(long a0, long a1);
                    static /*0x1124e70*/ ulong vceqd_u64(ulong a0, ulong a1);
                    static /*0x11250f0*/ uint vceqs_f32(float a0, float a1);
                    static /*0x1124df0*/ ulong vceqd_f64(double a0, double a1);
                    static /*0x1125270*/ Unity.Burst.Intrinsics.v64 vceqz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11254f0*/ Unity.Burst.Intrinsics.v128 vceqzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11251b0*/ Unity.Burst.Intrinsics.v64 vceqz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125430*/ Unity.Burst.Intrinsics.v128 vceqzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11251f0*/ Unity.Burst.Intrinsics.v64 vceqz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125470*/ Unity.Burst.Intrinsics.v128 vceqzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11252e0*/ Unity.Burst.Intrinsics.v64 vceqz_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125590*/ Unity.Burst.Intrinsics.v128 vceqzq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11252b0*/ Unity.Burst.Intrinsics.v64 vceqz_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125530*/ Unity.Burst.Intrinsics.v128 vceqzq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11252c0*/ Unity.Burst.Intrinsics.v64 vceqz_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125550*/ Unity.Burst.Intrinsics.v128 vceqzq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125130*/ Unity.Burst.Intrinsics.v64 vceqz_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11253b0*/ Unity.Burst.Intrinsics.v128 vceqzq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125230*/ Unity.Burst.Intrinsics.v64 vceqz_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11254b0*/ Unity.Burst.Intrinsics.v128 vceqzq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11252d0*/ Unity.Burst.Intrinsics.v64 vceqz_u64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125570*/ Unity.Burst.Intrinsics.v128 vceqzq_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125170*/ Unity.Burst.Intrinsics.v64 vceqz_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11253f0*/ Unity.Burst.Intrinsics.v128 vceqzq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125330*/ ulong vceqzd_s64(long a0);
                    static /*0x1125370*/ ulong vceqzd_u64(ulong a0);
                    static /*0x11255b0*/ uint vceqzs_f32(float a0);
                    static /*0x11252f0*/ ulong vceqzd_f64(double a0);
                    static /*0x11256f0*/ Unity.Burst.Intrinsics.v64 vcge_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125a30*/ Unity.Burst.Intrinsics.v128 vcgeq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11257f0*/ Unity.Burst.Intrinsics.v64 vcge_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125b30*/ Unity.Burst.Intrinsics.v128 vcgeq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125630*/ Unity.Burst.Intrinsics.v64 vcge_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1125970*/ Unity.Burst.Intrinsics.v128 vcgeq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11258b0*/ ulong vcged_s64(long a0, long a1);
                    static /*0x11258f0*/ ulong vcged_u64(ulong a0, ulong a1);
                    static /*0x1125bb0*/ uint vcges_f32(float a0, float a1);
                    static /*0x1125870*/ ulong vcged_f64(double a0, double a1);
                    static /*0x1125d30*/ Unity.Burst.Intrinsics.v64 vcgez_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125f30*/ Unity.Burst.Intrinsics.v128 vcgezq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125c70*/ Unity.Burst.Intrinsics.v64 vcgez_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125e70*/ Unity.Burst.Intrinsics.v128 vcgezq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125cb0*/ Unity.Burst.Intrinsics.v64 vcgez_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125eb0*/ Unity.Burst.Intrinsics.v128 vcgezq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125cf0*/ Unity.Burst.Intrinsics.v64 vcgez_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125ef0*/ Unity.Burst.Intrinsics.v128 vcgezq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125bf0*/ Unity.Burst.Intrinsics.v64 vcgez_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125df0*/ Unity.Burst.Intrinsics.v128 vcgezq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125c30*/ Unity.Burst.Intrinsics.v64 vcgez_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1125e30*/ Unity.Burst.Intrinsics.v128 vcgezq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1125db0*/ ulong vcgezd_s64(long a0);
                    static /*0x1125f70*/ uint vcgezs_f32(float a0);
                    static /*0x1125d70*/ ulong vcgezd_f64(double a0);
                    static /*0x1126a70*/ Unity.Burst.Intrinsics.v64 vcle_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126db0*/ Unity.Burst.Intrinsics.v128 vcleq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126b70*/ Unity.Burst.Intrinsics.v64 vcle_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126eb0*/ Unity.Burst.Intrinsics.v128 vcleq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11269b0*/ Unity.Burst.Intrinsics.v64 vcle_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126cf0*/ Unity.Burst.Intrinsics.v128 vcleq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126c30*/ ulong vcled_s64(long a0, long a1);
                    static /*0x1126c70*/ ulong vcled_u64(ulong a0, ulong a1);
                    static /*0x1126f30*/ uint vcles_f32(float a0, float a1);
                    static /*0x1126bf0*/ ulong vcled_f64(double a0, double a1);
                    static /*0x11270b0*/ Unity.Burst.Intrinsics.v64 vclez_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11272b0*/ Unity.Burst.Intrinsics.v128 vclezq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1126ff0*/ Unity.Burst.Intrinsics.v64 vclez_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11271f0*/ Unity.Burst.Intrinsics.v128 vclezq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127030*/ Unity.Burst.Intrinsics.v64 vclez_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127230*/ Unity.Burst.Intrinsics.v128 vclezq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127070*/ Unity.Burst.Intrinsics.v64 vclez_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127270*/ Unity.Burst.Intrinsics.v128 vclezq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1126f70*/ Unity.Burst.Intrinsics.v64 vclez_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127170*/ Unity.Burst.Intrinsics.v128 vclezq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1126fb0*/ Unity.Burst.Intrinsics.v64 vclez_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11271b0*/ Unity.Burst.Intrinsics.v128 vclezq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127130*/ ulong vclezd_s64(long a0);
                    static /*0x11272f0*/ uint vclezs_f32(float a0);
                    static /*0x11270f0*/ ulong vclezd_f64(double a0);
                    static /*0x11260b0*/ Unity.Burst.Intrinsics.v64 vcgt_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11263f0*/ Unity.Burst.Intrinsics.v128 vcgtq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11261b0*/ Unity.Burst.Intrinsics.v64 vcgt_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11264f0*/ Unity.Burst.Intrinsics.v128 vcgtq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1125ff0*/ Unity.Burst.Intrinsics.v64 vcgt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1126330*/ Unity.Burst.Intrinsics.v128 vcgtq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1126270*/ ulong vcgtd_s64(long a0, long a1);
                    static /*0x11262b0*/ ulong vcgtd_u64(ulong a0, ulong a1);
                    static /*0x1126570*/ uint vcgts_f32(float a0, float a1);
                    static /*0x1126230*/ ulong vcgtd_f64(double a0, double a1);
                    static /*0x11266f0*/ Unity.Burst.Intrinsics.v64 vcgtz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11268f0*/ Unity.Burst.Intrinsics.v128 vcgtzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1126630*/ Unity.Burst.Intrinsics.v64 vcgtz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1126830*/ Unity.Burst.Intrinsics.v128 vcgtzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1126670*/ Unity.Burst.Intrinsics.v64 vcgtz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1126870*/ Unity.Burst.Intrinsics.v128 vcgtzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11266b0*/ Unity.Burst.Intrinsics.v64 vcgtz_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11268b0*/ Unity.Burst.Intrinsics.v128 vcgtzq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11265b0*/ Unity.Burst.Intrinsics.v64 vcgtz_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11267b0*/ Unity.Burst.Intrinsics.v128 vcgtzq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11265f0*/ Unity.Burst.Intrinsics.v64 vcgtz_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11267f0*/ Unity.Burst.Intrinsics.v128 vcgtzq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1126770*/ ulong vcgtzd_s64(long a0);
                    static /*0x1126930*/ uint vcgtzs_f32(float a0);
                    static /*0x1126730*/ ulong vcgtzd_f64(double a0);
                    static /*0x11275b0*/ Unity.Burst.Intrinsics.v64 vclt_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11278f0*/ Unity.Burst.Intrinsics.v128 vcltq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11276b0*/ Unity.Burst.Intrinsics.v64 vclt_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11279f0*/ Unity.Burst.Intrinsics.v128 vcltq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11274f0*/ Unity.Burst.Intrinsics.v64 vclt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1127830*/ Unity.Burst.Intrinsics.v128 vcltq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1127770*/ ulong vcltd_s64(long a0, long a1);
                    static /*0x11277b0*/ ulong vcltd_u64(ulong a0, ulong a1);
                    static /*0x1127a70*/ uint vclts_f32(float a0, float a1);
                    static /*0x1127730*/ ulong vcltd_f64(double a0, double a1);
                    static /*0x1127bf0*/ Unity.Burst.Intrinsics.v64 vcltz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127df0*/ Unity.Burst.Intrinsics.v128 vcltzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127b30*/ Unity.Burst.Intrinsics.v64 vcltz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127d30*/ Unity.Burst.Intrinsics.v128 vcltzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127b70*/ Unity.Burst.Intrinsics.v64 vcltz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127d70*/ Unity.Burst.Intrinsics.v128 vcltzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127bb0*/ Unity.Burst.Intrinsics.v64 vcltz_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127db0*/ Unity.Burst.Intrinsics.v128 vcltzq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127ab0*/ Unity.Burst.Intrinsics.v64 vcltz_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127cb0*/ Unity.Burst.Intrinsics.v128 vcltzq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127af0*/ Unity.Burst.Intrinsics.v64 vcltz_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1127cf0*/ Unity.Burst.Intrinsics.v128 vcltzq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1127c70*/ ulong vcltzd_s64(long a0);
                    static /*0x1127e30*/ uint vcltzs_f32(float a0);
                    static /*0x1127c30*/ ulong vcltzd_f64(double a0);
                    static /*0x1124670*/ Unity.Burst.Intrinsics.v64 vcage_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124730*/ Unity.Burst.Intrinsics.v128 vcageq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124770*/ uint vcages_f32(float a0, float a1);
                    static /*0x11246b0*/ ulong vcaged_f64(double a0, double a1);
                    static /*0x1124970*/ Unity.Burst.Intrinsics.v64 vcale_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124a30*/ Unity.Burst.Intrinsics.v128 vcaleq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124a70*/ uint vcales_f32(float a0, float a1);
                    static /*0x11249b0*/ ulong vcaled_f64(double a0, double a1);
                    static /*0x11247f0*/ Unity.Burst.Intrinsics.v64 vcagt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11248b0*/ Unity.Burst.Intrinsics.v128 vcagtq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11248f0*/ uint vcagts_f32(float a0, float a1);
                    static /*0x1124830*/ ulong vcagtd_f64(double a0, double a1);
                    static /*0x1124af0*/ Unity.Burst.Intrinsics.v64 vcalt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1124bb0*/ Unity.Burst.Intrinsics.v128 vcaltq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1124bf0*/ uint vcalts_f32(float a0, float a1);
                    static /*0x1124b30*/ ulong vcaltd_f64(double a0, double a1);
                    static /*0x1141100*/ Unity.Burst.Intrinsics.v64 vtst_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11412c0*/ Unity.Burst.Intrinsics.v128 vtstq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11411a0*/ Unity.Burst.Intrinsics.v64 vtst_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11413a0*/ Unity.Burst.Intrinsics.v128 vtstq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11411c0*/ ulong vtstd_s64(long a0, long a1);
                    static /*0x1141200*/ ulong vtstd_u64(ulong a0, ulong a1);
                    static /*0x11223d0*/ Unity.Burst.Intrinsics.v64 vabd_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1122910*/ Unity.Burst.Intrinsics.v128 vabdq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122ad0*/ float vabds_f32(float a0, float a1);
                    static /*0x1122590*/ double vabdd_f64(double a0, double a1);
                    static /*0x1122650*/ Unity.Burst.Intrinsics.v128 vabdl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11225d0*/ Unity.Burst.Intrinsics.v128 vabdl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122610*/ Unity.Burst.Intrinsics.v128 vabdl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122710*/ Unity.Burst.Intrinsics.v128 vabdl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1122690*/ Unity.Burst.Intrinsics.v128 vabdl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11226d0*/ Unity.Burst.Intrinsics.v128 vabdl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1121f90*/ Unity.Burst.Intrinsics.v128 vabal_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121f10*/ Unity.Burst.Intrinsics.v128 vabal_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121f50*/ Unity.Burst.Intrinsics.v128 vabal_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1122050*/ Unity.Burst.Intrinsics.v128 vabal_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121fd0*/ Unity.Burst.Intrinsics.v128 vabal_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1122010*/ Unity.Burst.Intrinsics.v128 vabal_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112d0a0*/ Unity.Burst.Intrinsics.v64 vmax_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d460*/ Unity.Burst.Intrinsics.v128 vmaxq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112da20*/ Unity.Burst.Intrinsics.v64 vmin_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112dde0*/ Unity.Burst.Intrinsics.v128 vminq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d260*/ Unity.Burst.Intrinsics.v64 vmaxnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d2e0*/ Unity.Burst.Intrinsics.v128 vmaxnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112d2a0*/ Unity.Burst.Intrinsics.v64 vmaxnm_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112d320*/ Unity.Burst.Intrinsics.v128 vmaxnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112dbe0*/ Unity.Burst.Intrinsics.v64 vminnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112dc60*/ Unity.Burst.Intrinsics.v128 vminnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112dc20*/ Unity.Burst.Intrinsics.v64 vminnm_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x112dca0*/ Unity.Burst.Intrinsics.v128 vminnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113dd50*/ long vshld_s64(long a0, long a1);
                    static /*0x113dd90*/ ulong vshld_u64(ulong a0, long a1);
                    static /*0x1138d20*/ sbyte vqshlb_s8(sbyte a0, sbyte a1);
                    static /*0x1138f20*/ short vqshlh_s16(short a0, short a1);
                    static /*0x11394a0*/ int vqshls_s32(int a0, int a1);
                    static /*0x1138e20*/ long vqshld_s64(long a0, long a1);
                    static /*0x1138d60*/ byte vqshlb_u8(byte a0, sbyte a1);
                    static /*0x1138f60*/ ushort vqshlh_u16(ushort a0, short a1);
                    static /*0x11394e0*/ uint vqshls_u32(uint a0, int a1);
                    static /*0x1138e60*/ ulong vqshld_u64(ulong a0, long a1);
                    static /*0x113be70*/ long vrshld_s64(long a0, long a1);
                    static /*0x113beb0*/ ulong vrshld_u64(ulong a0, long a1);
                    static /*0x1137e40*/ sbyte vqrshlb_s8(sbyte a0, sbyte a1);
                    static /*0x1137f40*/ short vqrshlh_s16(short a0, short a1);
                    static /*0x11381c0*/ int vqrshls_s32(int a0, int a1);
                    static /*0x1137ec0*/ long vqrshld_s64(long a0, long a1);
                    static /*0x1137e80*/ byte vqrshlb_u8(byte a0, sbyte a1);
                    static /*0x1137f80*/ ushort vqrshlh_u16(ushort a0, short a1);
                    static /*0x1138200*/ uint vqrshls_u32(uint a0, int a1);
                    static /*0x1137f00*/ ulong vqrshld_u64(ulong a0, long a1);
                    static /*0x113e6d0*/ long vshrd_n_s64(long a0, int a1);
                    static /*0x113e6e0*/ ulong vshrd_n_u64(ulong a0, int a1);
                    static /*0x113dd40*/ long vshld_n_s64(long a0, int a1);
                    static /*0x113dd40*/ ulong vshld_n_u64(ulong a0, int a1);
                    static /*0x113c2f0*/ long vrshrd_n_s64(long a0, int a1);
                    static /*0x113c330*/ ulong vrshrd_n_u64(ulong a0, int a1);
                    static /*0x113f670*/ long vsrad_n_s64(long a0, long a1, int a2);
                    static /*0x113f690*/ ulong vsrad_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x113cdb0*/ long vrsrad_n_s64(long a0, long a1, int a2);
                    static /*0x113cdf0*/ ulong vrsrad_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x1138ca0*/ sbyte vqshlb_n_s8(sbyte a0, int a1);
                    static /*0x1138ea0*/ short vqshlh_n_s16(short a0, int a1);
                    static /*0x1139420*/ int vqshls_n_s32(int a0, int a1);
                    static /*0x1138da0*/ long vqshld_n_s64(long a0, int a1);
                    static /*0x1138ce0*/ byte vqshlb_n_u8(byte a0, int a1);
                    static /*0x1138ee0*/ ushort vqshlh_n_u16(ushort a0, int a1);
                    static /*0x1139460*/ uint vqshls_n_u32(uint a0, int a1);
                    static /*0x1138de0*/ ulong vqshld_n_u64(ulong a0, int a1);
                    static /*0x1139620*/ byte vqshlub_n_s8(sbyte a0, int a1);
                    static /*0x11396a0*/ ushort vqshluh_n_s16(short a0, int a1);
                    static /*0x11397e0*/ uint vqshlus_n_s32(int a0, int a1);
                    static /*0x1139660*/ ulong vqshlud_n_s64(long a0, int a1);
                    static /*0x113e6f0*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113e730*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113e770*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113e7b0*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113e7f0*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113e830*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139e60*/ byte vqshrunh_n_s16(short a0, int a1);
                    static /*0x1139ea0*/ ushort vqshruns_n_s32(int a0, int a1);
                    static /*0x1139e20*/ uint vqshrund_n_s64(long a0, int a1);
                    static /*0x1139ca0*/ Unity.Burst.Intrinsics.v128 vqshrun_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139ce0*/ Unity.Burst.Intrinsics.v128 vqshrun_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139d20*/ Unity.Burst.Intrinsics.v128 vqshrun_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138880*/ byte vqrshrunh_n_s16(short a0, int a1);
                    static /*0x11388c0*/ ushort vqrshruns_n_s32(int a0, int a1);
                    static /*0x1138840*/ uint vqrshrund_n_s64(long a0, int a1);
                    static /*0x11386c0*/ Unity.Burst.Intrinsics.v128 vqrshrun_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138700*/ Unity.Burst.Intrinsics.v128 vqrshrun_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138740*/ Unity.Burst.Intrinsics.v128 vqrshrun_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139ba0*/ sbyte vqshrnh_n_s16(short a0, int a1);
                    static /*0x1139c20*/ short vqshrns_n_s32(int a0, int a1);
                    static /*0x1139b20*/ int vqshrnd_n_s64(long a0, int a1);
                    static /*0x1139be0*/ byte vqshrnh_n_u16(ushort a0, int a1);
                    static /*0x1139c60*/ ushort vqshrns_n_u32(uint a0, int a1);
                    static /*0x1139b60*/ uint vqshrnd_n_u64(ulong a0, int a1);
                    static /*0x1139820*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139860*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11398a0*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11398e0*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139920*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1139960*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113c370*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113c3b0*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113c3f0*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113c430*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113c470*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113c4b0*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11385c0*/ sbyte vqrshrnh_n_s16(short a0, int a1);
                    static /*0x1138640*/ short vqrshrns_n_s32(int a0, int a1);
                    static /*0x1138540*/ int vqrshrnd_n_s64(long a0, int a1);
                    static /*0x1138600*/ byte vqrshrnh_n_u16(ushort a0, int a1);
                    static /*0x1138680*/ ushort vqrshrns_n_u32(uint a0, int a1);
                    static /*0x1138580*/ uint vqrshrnd_n_u64(ulong a0, int a1);
                    static /*0x1138240*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138280*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11382c0*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138300*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138340*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1138380*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113de50*/ Unity.Burst.Intrinsics.v128 vshll_high_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113ddd0*/ Unity.Burst.Intrinsics.v128 vshll_high_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113de10*/ Unity.Burst.Intrinsics.v128 vshll_high_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113df10*/ Unity.Burst.Intrinsics.v128 vshll_high_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113de90*/ Unity.Burst.Intrinsics.v128 vshll_high_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113ded0*/ Unity.Burst.Intrinsics.v128 vshll_high_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x113fab0*/ long vsrid_n_s64(long a0, long a1, int a2);
                    static /*0x113faf0*/ ulong vsrid_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x113edf0*/ long vslid_n_s64(long a0, long a1, int a2);
                    static /*0x113ee30*/ ulong vslid_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x11297d0*/ Unity.Burst.Intrinsics.v64 vcvtn_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129950*/ Unity.Burst.Intrinsics.v128 vcvtnq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129850*/ Unity.Burst.Intrinsics.v64 vcvtn_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11299d0*/ Unity.Burst.Intrinsics.v128 vcvtnq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11294d0*/ Unity.Burst.Intrinsics.v64 vcvtm_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129650*/ Unity.Burst.Intrinsics.v128 vcvtmq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129550*/ Unity.Burst.Intrinsics.v64 vcvtm_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11296d0*/ Unity.Burst.Intrinsics.v128 vcvtmq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129ad0*/ Unity.Burst.Intrinsics.v64 vcvtp_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129c50*/ Unity.Burst.Intrinsics.v128 vcvtpq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129b50*/ Unity.Burst.Intrinsics.v64 vcvtp_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129cd0*/ Unity.Burst.Intrinsics.v128 vcvtpq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128fd0*/ Unity.Burst.Intrinsics.v64 vcvta_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129150*/ Unity.Burst.Intrinsics.v128 vcvtaq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129050*/ Unity.Burst.Intrinsics.v64 vcvta_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11291d0*/ Unity.Burst.Intrinsics.v128 vcvtaq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112a350*/ int vcvts_s32_f32(float a0);
                    static /*0x112a390*/ uint vcvts_u32_f32(float a0);
                    static /*0x1129a50*/ int vcvtns_s32_f32(float a0);
                    static /*0x1129a90*/ uint vcvtns_u32_f32(float a0);
                    static /*0x1129750*/ int vcvtms_s32_f32(float a0);
                    static /*0x1129790*/ uint vcvtms_u32_f32(float a0);
                    static /*0x1129d50*/ int vcvtps_s32_f32(float a0);
                    static /*0x1129d90*/ uint vcvtps_u32_f32(float a0);
                    static /*0x1129250*/ int vcvtas_s32_f32(float a0);
                    static /*0x1129290*/ uint vcvtas_u32_f32(float a0);
                    static /*0x1128f10*/ Unity.Burst.Intrinsics.v64 vcvt_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112a110*/ Unity.Burst.Intrinsics.v128 vcvtq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128f90*/ Unity.Burst.Intrinsics.v64 vcvt_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112a190*/ Unity.Burst.Intrinsics.v128 vcvtq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129810*/ Unity.Burst.Intrinsics.v64 vcvtn_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129990*/ Unity.Burst.Intrinsics.v128 vcvtnq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129890*/ Unity.Burst.Intrinsics.v64 vcvtn_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129a10*/ Unity.Burst.Intrinsics.v128 vcvtnq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129510*/ Unity.Burst.Intrinsics.v64 vcvtm_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129690*/ Unity.Burst.Intrinsics.v128 vcvtmq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129590*/ Unity.Burst.Intrinsics.v64 vcvtm_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129710*/ Unity.Burst.Intrinsics.v128 vcvtmq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129b10*/ Unity.Burst.Intrinsics.v64 vcvtp_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129c90*/ Unity.Burst.Intrinsics.v128 vcvtpq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129b90*/ Unity.Burst.Intrinsics.v64 vcvtp_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129d10*/ Unity.Burst.Intrinsics.v128 vcvtpq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129010*/ Unity.Burst.Intrinsics.v64 vcvta_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129190*/ Unity.Burst.Intrinsics.v128 vcvtaq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129090*/ Unity.Burst.Intrinsics.v64 vcvta_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129210*/ Unity.Burst.Intrinsics.v128 vcvtaq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1129450*/ long vcvtd_s64_f64(double a0);
                    static /*0x1129490*/ ulong vcvtd_u64_f64(double a0);
                    static /*0x11298d0*/ long vcvtnd_s64_f64(double a0);
                    static /*0x1129910*/ ulong vcvtnd_u64_f64(double a0);
                    static /*0x11295d0*/ long vcvtmd_s64_f64(double a0);
                    static /*0x1129610*/ ulong vcvtmd_u64_f64(double a0);
                    static /*0x1129bd0*/ long vcvtpd_s64_f64(double a0);
                    static /*0x1129c10*/ ulong vcvtpd_u64_f64(double a0);
                    static /*0x11290d0*/ long vcvtad_s64_f64(double a0);
                    static /*0x1129110*/ ulong vcvtad_u64_f64(double a0);
                    static /*0x112a2d0*/ int vcvts_n_s32_f32(float a0, int a1);
                    static /*0x112a310*/ uint vcvts_n_u32_f32(float a0, int a1);
                    static /*0x1128e10*/ Unity.Burst.Intrinsics.v64 vcvt_n_s64_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a010*/ Unity.Burst.Intrinsics.v128 vcvtq_n_s64_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1128e90*/ Unity.Burst.Intrinsics.v64 vcvt_n_u64_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112a090*/ Unity.Burst.Intrinsics.v128 vcvtq_n_u64_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x11293d0*/ long vcvtd_n_s64_f64(double a0, int a1);
                    static /*0x1129410*/ ulong vcvtd_n_u64_f64(double a0, int a1);
                    static /*0x112a1d0*/ float vcvts_f32_s32(int a0);
                    static /*0x112a210*/ float vcvts_f32_u32(uint a0);
                    static /*0x1128bd0*/ Unity.Burst.Intrinsics.v64 vcvt_f64_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129e50*/ Unity.Burst.Intrinsics.v128 vcvtq_f64_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128c10*/ Unity.Burst.Intrinsics.v64 vcvt_f64_u64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1129e90*/ Unity.Burst.Intrinsics.v128 vcvtq_f64_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11292d0*/ double vcvtd_f64_s64(long a0);
                    static /*0x1129310*/ double vcvtd_f64_u64(ulong a0);
                    static /*0x112a250*/ float vcvts_n_f32_s32(int a0, int a1);
                    static /*0x112a290*/ float vcvts_n_f32_u32(uint a0, int a1);
                    static /*0x1128d50*/ Unity.Burst.Intrinsics.v64 vcvt_n_f64_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1129f50*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f64_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1128d90*/ Unity.Burst.Intrinsics.v64 vcvt_n_f64_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x1129f90*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f64_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1129350*/ double vcvtd_n_f64_s64(long a0, int a1);
                    static /*0x1129390*/ double vcvtd_n_f64_u64(ulong a0, int a1);
                    static /*0x1128ad0*/ Unity.Burst.Intrinsics.v64 vcvt_f32_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1128c50*/ Unity.Burst.Intrinsics.v128 vcvt_high_f32_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1128b90*/ Unity.Burst.Intrinsics.v128 vcvt_f64_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1128c90*/ Unity.Burst.Intrinsics.v128 vcvt_high_f64_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112a3d0*/ Unity.Burst.Intrinsics.v64 vcvtx_f32_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112a450*/ float vcvtxd_f32_f64(double a0);
                    static /*0x112a410*/ Unity.Burst.Intrinsics.v128 vcvtx_high_f32_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113b530*/ Unity.Burst.Intrinsics.v64 vrnd_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113baf0*/ Unity.Burst.Intrinsics.v128 vrndq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b570*/ Unity.Burst.Intrinsics.v64 vrnd_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113bb30*/ Unity.Burst.Intrinsics.v128 vrndq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b8b0*/ Unity.Burst.Intrinsics.v64 vrndn_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b930*/ Unity.Burst.Intrinsics.v128 vrndnq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b8f0*/ Unity.Burst.Intrinsics.v64 vrndn_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b970*/ Unity.Burst.Intrinsics.v128 vrndnq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b9b0*/ float vrndns_f32(float a0);
                    static /*0x113b7b0*/ Unity.Burst.Intrinsics.v64 vrndm_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b830*/ Unity.Burst.Intrinsics.v128 vrndmq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b7f0*/ Unity.Burst.Intrinsics.v64 vrndm_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b870*/ Unity.Burst.Intrinsics.v128 vrndmq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b9f0*/ Unity.Burst.Intrinsics.v64 vrndp_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ba70*/ Unity.Burst.Intrinsics.v128 vrndpq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113ba30*/ Unity.Burst.Intrinsics.v64 vrndp_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113bab0*/ Unity.Burst.Intrinsics.v128 vrndpq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b5b0*/ Unity.Burst.Intrinsics.v64 vrnda_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b630*/ Unity.Burst.Intrinsics.v128 vrndaq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b5f0*/ Unity.Burst.Intrinsics.v64 vrnda_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b670*/ Unity.Burst.Intrinsics.v128 vrndaq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b6b0*/ Unity.Burst.Intrinsics.v64 vrndi_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b730*/ Unity.Burst.Intrinsics.v128 vrndiq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113b6f0*/ Unity.Burst.Intrinsics.v64 vrndi_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113b770*/ Unity.Burst.Intrinsics.v128 vrndiq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113bb70*/ Unity.Burst.Intrinsics.v64 vrndx_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113bbf0*/ Unity.Burst.Intrinsics.v128 vrndxq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113bbb0*/ Unity.Burst.Intrinsics.v64 vrndx_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113bc30*/ Unity.Burst.Intrinsics.v128 vrndxq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130bc0*/ Unity.Burst.Intrinsics.v128 vmovl_high_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130b40*/ Unity.Burst.Intrinsics.v128 vmovl_high_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130b80*/ Unity.Burst.Intrinsics.v128 vmovl_high_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130c80*/ Unity.Burst.Intrinsics.v128 vmovl_high_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130c00*/ Unity.Burst.Intrinsics.v128 vmovl_high_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1130c40*/ Unity.Burst.Intrinsics.v128 vmovl_high_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136800*/ sbyte vqmovnh_s16(short a0);
                    static /*0x1136880*/ short vqmovns_s32(int a0);
                    static /*0x1136780*/ int vqmovnd_s64(long a0);
                    static /*0x1136840*/ byte vqmovnh_u16(ushort a0);
                    static /*0x11368c0*/ ushort vqmovns_u32(uint a0);
                    static /*0x11367c0*/ uint vqmovnd_u64(ulong a0);
                    static /*0x1136480*/ Unity.Burst.Intrinsics.v128 vqmovn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11364c0*/ Unity.Burst.Intrinsics.v128 vqmovn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136500*/ Unity.Burst.Intrinsics.v128 vqmovn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136540*/ Unity.Burst.Intrinsics.v128 vqmovn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136580*/ Unity.Burst.Intrinsics.v128 vqmovn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11365c0*/ Unity.Burst.Intrinsics.v128 vqmovn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136ac0*/ byte vqmovunh_s16(short a0);
                    static /*0x1136b00*/ ushort vqmovuns_s32(int a0);
                    static /*0x1136a80*/ uint vqmovund_s64(long a0);
                    static /*0x1136900*/ Unity.Burst.Intrinsics.v128 vqmovun_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136940*/ Unity.Burst.Intrinsics.v128 vqmovun_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1136980*/ Unity.Burst.Intrinsics.v128 vqmovun_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x112e560*/ Unity.Burst.Intrinsics.v64 vmla_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f390*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e5a0*/ Unity.Burst.Intrinsics.v64 vmla_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f3d0*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e5e0*/ Unity.Burst.Intrinsics.v64 vmla_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f410*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e620*/ Unity.Burst.Intrinsics.v64 vmla_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f450*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e520*/ Unity.Burst.Intrinsics.v64 vmla_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f350*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e890*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e8d0*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e910*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112e950*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112ee10*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112ee50*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112ee90*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112eed0*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e990*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112e9d0*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112ea10*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112ea50*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135280*/ int vqdmlalh_lane_s16(int a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135340*/ long vqdmlals_lane_s32(long a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1134e80*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1134ec0*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135100*/ Unity.Burst.Intrinsics.v128 vqdmlal_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135140*/ Unity.Burst.Intrinsics.v128 vqdmlal_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11352c0*/ int vqdmlalh_laneq_s16(int a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135380*/ long vqdmlals_laneq_s32(long a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1134f00*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1134f40*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f950*/ Unity.Burst.Intrinsics.v64 vmls_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1130780*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f990*/ Unity.Burst.Intrinsics.v64 vmls_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11307c0*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f9d0*/ Unity.Burst.Intrinsics.v64 vmls_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1130800*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112fa10*/ Unity.Burst.Intrinsics.v64 vmls_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1130840*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112f910*/ Unity.Burst.Intrinsics.v64 vmls_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1130740*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112fc80*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112fcc0*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112fd00*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112fd40*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1130200*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1130240*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1130280*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11302c0*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112fd80*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112fdc0*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112fe00*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112fe40*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135800*/ int vqdmlslh_lane_s16(int a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11358c0*/ long vqdmlsls_lane_s32(long a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135400*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135440*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1135680*/ Unity.Burst.Intrinsics.v128 vqdmlsl_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11356c0*/ Unity.Burst.Intrinsics.v128 vqdmlsl_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135840*/ int vqdmlslh_laneq_s16(int a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135900*/ long vqdmlsls_laneq_s32(long a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1135480*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11354c0*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1131410*/ Unity.Burst.Intrinsics.v64 vmul_n_f64(Unity.Burst.Intrinsics.v64 a0, double a1);
                    static /*0x1132360*/ Unity.Burst.Intrinsics.v128 vmulq_n_f64(Unity.Burst.Intrinsics.v128 a0, double a1);
                    static /*0x1131140*/ Unity.Burst.Intrinsics.v64 vmul_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1132060*/ Unity.Burst.Intrinsics.v128 vmulq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11325f0*/ float vmuls_lane_f32(float a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131640*/ double vmuld_lane_f64(double a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11312d0*/ Unity.Burst.Intrinsics.v64 vmul_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132220*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131310*/ Unity.Burst.Intrinsics.v64 vmul_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132260*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131350*/ Unity.Burst.Intrinsics.v64 vmul_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11322a0*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131390*/ Unity.Burst.Intrinsics.v64 vmul_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11322e0*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131250*/ Unity.Burst.Intrinsics.v64 vmul_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11321a0*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131290*/ Unity.Burst.Intrinsics.v64 vmul_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11321e0*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1132630*/ float vmuls_laneq_f32(float a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131660*/ double vmuld_laneq_f64(double a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11318a0*/ Unity.Burst.Intrinsics.v128 vmull_high_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x11318e0*/ Unity.Burst.Intrinsics.v128 vmull_high_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1131920*/ Unity.Burst.Intrinsics.v128 vmull_high_n_u16(Unity.Burst.Intrinsics.v128 a0, ushort a1);
                    static /*0x1131960*/ Unity.Burst.Intrinsics.v128 vmull_high_n_u32(Unity.Burst.Intrinsics.v128 a0, uint a1);
                    static /*0x11316a0*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11316e0*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131720*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131760*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1131c20*/ Unity.Burst.Intrinsics.v128 vmull_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131c60*/ Unity.Burst.Intrinsics.v128 vmull_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131ca0*/ Unity.Burst.Intrinsics.v128 vmull_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131ce0*/ Unity.Burst.Intrinsics.v128 vmull_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11317a0*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11317e0*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131820*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1131860*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1136000*/ Unity.Burst.Intrinsics.v128 vqdmull_high_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x1136040*/ Unity.Burst.Intrinsics.v128 vqdmull_high_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1136300*/ int vqdmullh_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x11363c0*/ long vqdmulls_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135f00*/ Unity.Burst.Intrinsics.v128 vqdmull_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135f40*/ Unity.Burst.Intrinsics.v128 vqdmull_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1136180*/ Unity.Burst.Intrinsics.v128 vqdmull_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11361c0*/ Unity.Burst.Intrinsics.v128 vqdmull_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1136340*/ int vqdmullh_laneq_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1136400*/ long vqdmulls_laneq_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135f80*/ Unity.Burst.Intrinsics.v128 vqdmull_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135fc0*/ Unity.Burst.Intrinsics.v128 vqdmull_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135b80*/ short vqdmulhh_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135e40*/ int vqdmulhs_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1135a00*/ Unity.Burst.Intrinsics.v64 vqdmulh_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135cc0*/ Unity.Burst.Intrinsics.v128 vqdmulhq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135a40*/ Unity.Burst.Intrinsics.v64 vqdmulh_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135d00*/ Unity.Burst.Intrinsics.v128 vqdmulhq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135bc0*/ short vqdmulhh_laneq_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1135e80*/ int vqdmulhs_laneq_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x11378c0*/ short vqrdmulhh_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1137b80*/ int vqrdmulhs_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x1137740*/ Unity.Burst.Intrinsics.v64 vqrdmulh_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1137a00*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1137780*/ Unity.Burst.Intrinsics.v64 vqrdmulh_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1137a40*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1137900*/ short vqrdmulhh_laneq_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1137bc0*/ int vqrdmulhs_laneq_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112ea90*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x112ead0*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112eb10*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x112eb50*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x1134f80*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x1134fc0*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112fe80*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x112fec0*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x112ff00*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x112ff40*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x1135500*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x1135540*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1122c10*/ Unity.Burst.Intrinsics.v64 vabs_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1122c90*/ long vabsd_s64(long a0);
                    static /*0x1122dd0*/ Unity.Burst.Intrinsics.v128 vabsq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1122b50*/ Unity.Burst.Intrinsics.v64 vabs_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1122d10*/ Unity.Burst.Intrinsics.v128 vabsq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1134600*/ Unity.Burst.Intrinsics.v64 vqabs_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11347c0*/ Unity.Burst.Intrinsics.v128 vqabsq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1134680*/ sbyte vqabsb_s8(sbyte a0);
                    static /*0x1134700*/ short vqabsh_s16(short a0);
                    static /*0x1134840*/ int vqabss_s32(int a0);
                    static /*0x11346c0*/ long vqabsd_s64(long a0);
                    static /*0x1132c50*/ Unity.Burst.Intrinsics.v64 vneg_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132cd0*/ long vnegd_s64(long a0);
                    static /*0x1132e10*/ Unity.Burst.Intrinsics.v128 vnegq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1132b90*/ Unity.Burst.Intrinsics.v64 vneg_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1132d50*/ Unity.Burst.Intrinsics.v128 vnegq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136bc0*/ Unity.Burst.Intrinsics.v64 vqneg_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1136d80*/ Unity.Burst.Intrinsics.v128 vqnegq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1136c40*/ sbyte vqnegb_s8(sbyte a0);
                    static /*0x1136cc0*/ short vqnegh_s16(short a0);
                    static /*0x1136e00*/ int vqnegs_s32(int a0);
                    static /*0x1136c80*/ long vqnegd_s64(long a0);
                    static /*0x113aa50*/ Unity.Burst.Intrinsics.v64 vrecpe_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ab50*/ Unity.Burst.Intrinsics.v128 vrecpeq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113abd0*/ float vrecpes_f32(float a0);
                    static /*0x113aad0*/ double vrecped_f64(double a0);
                    static /*0x113ac50*/ Unity.Burst.Intrinsics.v64 vrecps_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113ad10*/ Unity.Burst.Intrinsics.v128 vrecpsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113ad50*/ float vrecpss_f32(float a0, float a1);
                    static /*0x113ac90*/ double vrecpsd_f64(double a0, double a1);
                    static /*0x113f370*/ Unity.Burst.Intrinsics.v64 vsqrt_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113f3f0*/ Unity.Burst.Intrinsics.v128 vsqrtq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113f3b0*/ Unity.Burst.Intrinsics.v64 vsqrt_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113f430*/ Unity.Burst.Intrinsics.v128 vsqrtq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113c970*/ Unity.Burst.Intrinsics.v64 vrsqrte_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113ca70*/ Unity.Burst.Intrinsics.v128 vrsqrteq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113caf0*/ float vrsqrtes_f32(float a0);
                    static /*0x113c9f0*/ double vrsqrted_f64(double a0);
                    static /*0x113cb70*/ Unity.Burst.Intrinsics.v64 vrsqrts_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113cc30*/ Unity.Burst.Intrinsics.v128 vrsqrtsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113cc70*/ float vrsqrtss_f32(float a0, float a1);
                    static /*0x113cbb0*/ double vrsqrtsd_f64(double a0, double a1);
                    static /*0x1124560*/ Unity.Burst.Intrinsics.v64 vbsl_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11245b0*/ Unity.Burst.Intrinsics.v128 vbslq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1128220*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11286e0*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11281a0*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128620*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11281e0*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128660*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128190*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11286a0*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11282e0*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11287e0*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128260*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128720*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11282a0*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128760*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128190*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11287a0*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128150*/ Unity.Burst.Intrinsics.v64 vcopy_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11285a0*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_f32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128190*/ Unity.Burst.Intrinsics.v64 vcopy_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11285e0*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_f64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128460*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128960*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11283a0*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11288a0*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11283e0*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11288e0*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128420*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128920*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128560*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128a60*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11284a0*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11289a0*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11284e0*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11289e0*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128520*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128a20*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128320*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_f32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128820*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128360*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_f64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1128860*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x113a960*/ Unity.Burst.Intrinsics.v64 vrbit_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113a9b0*/ Unity.Burst.Intrinsics.v128 vrbitq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x113a9a0*/ Unity.Burst.Intrinsics.v64 vrbit_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x113a9f0*/ Unity.Burst.Intrinsics.v128 vrbitq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x621ca0*/ Unity.Burst.Intrinsics.v64 vdup_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b0d0*/ Unity.Burst.Intrinsics.v128 vdupq_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112ab90*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b3c0*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112aad0*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b300*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ab10*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b340*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ab50*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b380*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ac90*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b4c0*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112abd0*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b400*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ac10*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b440*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ac50*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b480*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112aa50*/ Unity.Burst.Intrinsics.v64 vdup_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b280*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112aa90*/ Unity.Burst.Intrinsics.v64 vdup_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b2c0*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112adc0*/ sbyte vdupb_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112af90*/ short vduph_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b600*/ int vdups_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x621ca0*/ long vdupd_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112ae00*/ byte vdupb_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112afd0*/ ushort vduph_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b640*/ uint vdups_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x621ca0*/ ulong vdupd_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112b5c0*/ float vdups_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112aec0*/ double vdupd_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112ae40*/ sbyte vdupb_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b010*/ short vduph_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b6c0*/ int vdups_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112af10*/ long vdupd_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ae80*/ byte vdupb_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b050*/ ushort vduph_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b700*/ uint vdups_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112af50*/ ulong vdupd_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112b680*/ float vdups_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112aed0*/ double vdupd_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x1133940*/ Unity.Burst.Intrinsics.v128 vpaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133880*/ Unity.Burst.Intrinsics.v128 vpaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11338c0*/ Unity.Burst.Intrinsics.v128 vpaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133900*/ Unity.Burst.Intrinsics.v128 vpaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133a10*/ Unity.Burst.Intrinsics.v128 vpaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133980*/ Unity.Burst.Intrinsics.v128 vpaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11339b0*/ Unity.Burst.Intrinsics.v128 vpaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11339e0*/ Unity.Burst.Intrinsics.v128 vpaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133800*/ Unity.Burst.Intrinsics.v128 vpaddq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133840*/ Unity.Burst.Intrinsics.v128 vpaddq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133e80*/ Unity.Burst.Intrinsics.v128 vpmaxq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133e00*/ Unity.Burst.Intrinsics.v128 vpmaxq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133e40*/ Unity.Burst.Intrinsics.v128 vpmaxq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133f40*/ Unity.Burst.Intrinsics.v128 vpmaxq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133ec0*/ Unity.Burst.Intrinsics.v128 vpmaxq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133f00*/ Unity.Burst.Intrinsics.v128 vpmaxq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133d80*/ Unity.Burst.Intrinsics.v128 vpmaxq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133dc0*/ Unity.Burst.Intrinsics.v128 vpmaxq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134400*/ Unity.Burst.Intrinsics.v128 vpminq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134380*/ Unity.Burst.Intrinsics.v128 vpminq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11343c0*/ Unity.Burst.Intrinsics.v128 vpminq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11344c0*/ Unity.Burst.Intrinsics.v128 vpminq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134440*/ Unity.Burst.Intrinsics.v128 vpminq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134480*/ Unity.Burst.Intrinsics.v128 vpminq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134300*/ Unity.Burst.Intrinsics.v128 vpminq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134340*/ Unity.Burst.Intrinsics.v128 vpminq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133c40*/ Unity.Burst.Intrinsics.v64 vpmaxnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1133c80*/ Unity.Burst.Intrinsics.v128 vpmaxnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133cc0*/ Unity.Burst.Intrinsics.v128 vpmaxnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11341c0*/ Unity.Burst.Intrinsics.v64 vpminnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1134200*/ Unity.Burst.Intrinsics.v128 vpminnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1134240*/ Unity.Burst.Intrinsics.v128 vpminnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1133480*/ long vpaddd_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11334c0*/ ulong vpaddd_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133a40*/ float vpadds_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133440*/ double vpaddd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133fc0*/ float vpmaxs_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133f80*/ double vpmaxqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1134540*/ float vpmins_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1134500*/ double vpminqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1133d40*/ float vpmaxnms_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1133d00*/ double vpmaxnmqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11342c0*/ float vpminnms_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1134280*/ double vpminnmqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123c60*/ sbyte vaddv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123ea0*/ sbyte vaddvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123be0*/ short vaddv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123de0*/ short vaddvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123c20*/ int vaddv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123e20*/ int vaddvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123e60*/ long vaddvq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123d20*/ byte vaddv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123fa0*/ byte vaddvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123ca0*/ ushort vaddv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123ee0*/ ushort vaddvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123ce0*/ uint vaddv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123f20*/ uint vaddvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123f60*/ ulong vaddvq_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123ba0*/ float vaddv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123d60*/ float vaddvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123da0*/ double vaddvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11236e0*/ short vaddlv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123860*/ short vaddlvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123660*/ int vaddlv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11237e0*/ int vaddlvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11236a0*/ long vaddlv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123820*/ long vaddlvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x11237a0*/ ushort vaddlv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x1123920*/ ushort vaddlvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123720*/ uint vaddlv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11238a0*/ uint vaddlvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1123760*/ ulong vaddlv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x11238e0*/ ulong vaddlvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d6e0*/ sbyte vmaxv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d8e0*/ sbyte vmaxvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d660*/ short vmaxv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d860*/ short vmaxvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d6a0*/ int vmaxv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d8a0*/ int vmaxvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d7a0*/ byte vmaxv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d9a0*/ byte vmaxvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d720*/ ushort vmaxv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d920*/ ushort vmaxvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d760*/ uint vmaxv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d960*/ uint vmaxvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d620*/ float vmaxv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d7e0*/ float vmaxvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d820*/ double vmaxvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e060*/ sbyte vminv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e260*/ sbyte vminvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112dfe0*/ short vminv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e1e0*/ short vminvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e020*/ int vminv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e220*/ int vminvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e120*/ byte vminv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e320*/ byte vminvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e0a0*/ ushort vminv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e2a0*/ ushort vminvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e0e0*/ uint vminv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e2e0*/ uint vminvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112dfa0*/ float vminv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112e160*/ float vminvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112e1a0*/ double vminvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d360*/ float vmaxnmv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112d3a0*/ float vmaxnmvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112d3e0*/ double vmaxnmvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112dce0*/ float vminnmv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x112dd20*/ float vminnmvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x112dd60*/ double vminnmvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x621ca0*/ Unity.Burst.Intrinsics.v64 vext_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x112ba00*/ Unity.Burst.Intrinsics.v128 vextq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x1141cf0*/ Unity.Burst.Intrinsics.v64 vzip1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141e70*/ Unity.Burst.Intrinsics.v128 vzip1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141c70*/ Unity.Burst.Intrinsics.v64 vzip1_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141db0*/ Unity.Burst.Intrinsics.v128 vzip1q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141cb0*/ Unity.Burst.Intrinsics.v64 vzip1_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141df0*/ Unity.Burst.Intrinsics.v128 vzip1q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141e30*/ Unity.Burst.Intrinsics.v128 vzip1q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141d40*/ Unity.Burst.Intrinsics.v64 vzip1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141ee0*/ Unity.Burst.Intrinsics.v128 vzip1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141d30*/ Unity.Burst.Intrinsics.v64 vzip1_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141eb0*/ Unity.Burst.Intrinsics.v128 vzip1q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141c60*/ Unity.Burst.Intrinsics.v64 vzip1_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141d50*/ Unity.Burst.Intrinsics.v128 vzip1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141d80*/ Unity.Burst.Intrinsics.v128 vzip1q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141c60*/ Unity.Burst.Intrinsics.v64 vzip1_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141d50*/ Unity.Burst.Intrinsics.v128 vzip1q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141d80*/ Unity.Burst.Intrinsics.v128 vzip1q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141fa0*/ Unity.Burst.Intrinsics.v64 vzip2_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1142120*/ Unity.Burst.Intrinsics.v128 vzip2q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141f20*/ Unity.Burst.Intrinsics.v64 vzip2_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1142060*/ Unity.Burst.Intrinsics.v128 vzip2q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141f60*/ Unity.Burst.Intrinsics.v64 vzip2_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11420a0*/ Unity.Burst.Intrinsics.v128 vzip2q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11420e0*/ Unity.Burst.Intrinsics.v128 vzip2q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141ff0*/ Unity.Burst.Intrinsics.v64 vzip2_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1142190*/ Unity.Burst.Intrinsics.v128 vzip2q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141fe0*/ Unity.Burst.Intrinsics.v64 vzip2_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1142160*/ Unity.Burst.Intrinsics.v128 vzip2q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141f10*/ Unity.Burst.Intrinsics.v64 vzip2_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1142000*/ Unity.Burst.Intrinsics.v128 vzip2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1142030*/ Unity.Burst.Intrinsics.v128 vzip2q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141f10*/ Unity.Burst.Intrinsics.v64 vzip2_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1142000*/ Unity.Burst.Intrinsics.v128 vzip2q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1142030*/ Unity.Burst.Intrinsics.v128 vzip2q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141790*/ Unity.Burst.Intrinsics.v64 vuzp1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141910*/ Unity.Burst.Intrinsics.v128 vuzp1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141710*/ Unity.Burst.Intrinsics.v64 vuzp1_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141850*/ Unity.Burst.Intrinsics.v128 vuzp1q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141750*/ Unity.Burst.Intrinsics.v64 vuzp1_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141890*/ Unity.Burst.Intrinsics.v128 vuzp1q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11418d0*/ Unity.Burst.Intrinsics.v128 vuzp1q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11417e0*/ Unity.Burst.Intrinsics.v64 vuzp1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141980*/ Unity.Burst.Intrinsics.v128 vuzp1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11417d0*/ Unity.Burst.Intrinsics.v64 vuzp1_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141950*/ Unity.Burst.Intrinsics.v128 vuzp1q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141700*/ Unity.Burst.Intrinsics.v64 vuzp1_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11417f0*/ Unity.Burst.Intrinsics.v128 vuzp1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141820*/ Unity.Burst.Intrinsics.v128 vuzp1q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141700*/ Unity.Burst.Intrinsics.v64 vuzp1_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x11417f0*/ Unity.Burst.Intrinsics.v128 vuzp1q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141820*/ Unity.Burst.Intrinsics.v128 vuzp1q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141a40*/ Unity.Burst.Intrinsics.v64 vuzp2_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141bc0*/ Unity.Burst.Intrinsics.v128 vuzp2q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11419c0*/ Unity.Burst.Intrinsics.v64 vuzp2_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141b00*/ Unity.Burst.Intrinsics.v128 vuzp2q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141a00*/ Unity.Burst.Intrinsics.v64 vuzp2_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141b40*/ Unity.Burst.Intrinsics.v128 vuzp2q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141b80*/ Unity.Burst.Intrinsics.v128 vuzp2q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141a90*/ Unity.Burst.Intrinsics.v64 vuzp2_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141c30*/ Unity.Burst.Intrinsics.v128 vuzp2q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141a80*/ Unity.Burst.Intrinsics.v64 vuzp2_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141c00*/ Unity.Burst.Intrinsics.v128 vuzp2q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11419b0*/ Unity.Burst.Intrinsics.v64 vuzp2_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141aa0*/ Unity.Burst.Intrinsics.v128 vuzp2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141ad0*/ Unity.Burst.Intrinsics.v128 vuzp2q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11419b0*/ Unity.Burst.Intrinsics.v64 vuzp2_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141aa0*/ Unity.Burst.Intrinsics.v128 vuzp2q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1141ad0*/ Unity.Burst.Intrinsics.v128 vuzp2q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140bb0*/ Unity.Burst.Intrinsics.v64 vtrn1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140d30*/ Unity.Burst.Intrinsics.v128 vtrn1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140b30*/ Unity.Burst.Intrinsics.v64 vtrn1_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140c70*/ Unity.Burst.Intrinsics.v128 vtrn1q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140b70*/ Unity.Burst.Intrinsics.v64 vtrn1_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140cb0*/ Unity.Burst.Intrinsics.v128 vtrn1q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140cf0*/ Unity.Burst.Intrinsics.v128 vtrn1q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140c00*/ Unity.Burst.Intrinsics.v64 vtrn1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140da0*/ Unity.Burst.Intrinsics.v128 vtrn1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140bf0*/ Unity.Burst.Intrinsics.v64 vtrn1_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140d70*/ Unity.Burst.Intrinsics.v128 vtrn1q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140b20*/ Unity.Burst.Intrinsics.v64 vtrn1_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140c10*/ Unity.Burst.Intrinsics.v128 vtrn1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140c40*/ Unity.Burst.Intrinsics.v128 vtrn1q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140b20*/ Unity.Burst.Intrinsics.v64 vtrn1_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140c10*/ Unity.Burst.Intrinsics.v128 vtrn1q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140c40*/ Unity.Burst.Intrinsics.v128 vtrn1q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140e60*/ Unity.Burst.Intrinsics.v64 vtrn2_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140fe0*/ Unity.Burst.Intrinsics.v128 vtrn2q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140de0*/ Unity.Burst.Intrinsics.v64 vtrn2_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140f20*/ Unity.Burst.Intrinsics.v128 vtrn2q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140e20*/ Unity.Burst.Intrinsics.v64 vtrn2_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140f60*/ Unity.Burst.Intrinsics.v128 vtrn2q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140fa0*/ Unity.Burst.Intrinsics.v128 vtrn2q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140eb0*/ Unity.Burst.Intrinsics.v64 vtrn2_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141050*/ Unity.Burst.Intrinsics.v128 vtrn2q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140ea0*/ Unity.Burst.Intrinsics.v64 vtrn2_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1141020*/ Unity.Burst.Intrinsics.v128 vtrn2q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140dd0*/ Unity.Burst.Intrinsics.v64 vtrn2_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140ec0*/ Unity.Burst.Intrinsics.v128 vtrn2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140ef0*/ Unity.Burst.Intrinsics.v128 vtrn2q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140dd0*/ Unity.Burst.Intrinsics.v64 vtrn2_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1140ec0*/ Unity.Burst.Intrinsics.v128 vtrn2q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x1140ef0*/ Unity.Burst.Intrinsics.v128 vtrn2q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a4e0*/ Unity.Burst.Intrinsics.v64 vqtbl1_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a540*/ Unity.Burst.Intrinsics.v128 vqtbl1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a520*/ Unity.Burst.Intrinsics.v64 vqtbl1_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x113a580*/ Unity.Burst.Intrinsics.v128 vqtbl1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113a5b0*/ Unity.Burst.Intrinsics.v64 vqtbx1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x113a610*/ Unity.Burst.Intrinsics.v128 vqtbx1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113a5f0*/ Unity.Burst.Intrinsics.v64 vqtbx1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x113a650*/ Unity.Burst.Intrinsics.v128 vqtbx1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112aec0*/ double vget_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x112c820*/ double vgetq_lane_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x112ad00*/ Unity.Burst.Intrinsics.v64 vset_lane_f64(double a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x113d480*/ Unity.Burst.Intrinsics.v128 vsetq_lane_f64(double a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x113add0*/ float vrecpxs_f32(float a0);
                    static /*0x113ad90*/ double vrecpxd_f64(double a0);
                    static /*0x112c280*/ Unity.Burst.Intrinsics.v64 vfms_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x112c520*/ Unity.Burst.Intrinsics.v128 vfmsq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x112bdd0*/ Unity.Burst.Intrinsics.v64 vfma_n_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, double a2);
                    static /*0x112c070*/ Unity.Burst.Intrinsics.v128 vfmaq_n_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, double a2);
                    static /*0x112c2c0*/ Unity.Burst.Intrinsics.v64 vfms_n_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, double a2);
                    static /*0x112c560*/ Unity.Burst.Intrinsics.v128 vfmsq_n_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, double a2);
                    static /*0x348b00*/ bool get_IsNeonCryptoSupported();
                    static /*0x113d6c0*/ Unity.Burst.Intrinsics.v128 vsha1cq_u32(Unity.Burst.Intrinsics.v128 a0, uint a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d780*/ Unity.Burst.Intrinsics.v128 vsha1pq_u32(Unity.Burst.Intrinsics.v128 a0, uint a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d740*/ Unity.Burst.Intrinsics.v128 vsha1mq_u32(Unity.Burst.Intrinsics.v128 a0, uint a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d700*/ uint vsha1h_u32(uint a0);
                    static /*0x113d7c0*/ Unity.Burst.Intrinsics.v128 vsha1su0q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d800*/ Unity.Burst.Intrinsics.v128 vsha1su1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d880*/ Unity.Burst.Intrinsics.v128 vsha256hq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d840*/ Unity.Burst.Intrinsics.v128 vsha256h2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x113d8c0*/ Unity.Burst.Intrinsics.v128 vsha256su0q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x113d900*/ Unity.Burst.Intrinsics.v128 vsha256su1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1121b90*/ uint __crc32b(uint a0, byte a1);
                    static /*0x1121d10*/ uint __crc32h(uint a0, ushort a1);
                    static /*0x1121d50*/ uint __crc32w(uint a0, uint a1);
                    static /*0x1121cd0*/ uint __crc32d(uint a0, ulong a1);
                    static /*0x1121bd0*/ uint __crc32cb(uint a0, byte a1);
                    static /*0x1121c50*/ uint __crc32ch(uint a0, ushort a1);
                    static /*0x1121c90*/ uint __crc32cw(uint a0, uint a1);
                    static /*0x1121c10*/ uint __crc32cd(uint a0, ulong a1);
                    static /*0x1124320*/ Unity.Burst.Intrinsics.v128 vaeseq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11242e0*/ Unity.Burst.Intrinsics.v128 vaesdq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x11243a0*/ Unity.Burst.Intrinsics.v128 vaesmcq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x1124360*/ Unity.Burst.Intrinsics.v128 vaesimcq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x348b00*/ bool get_IsNeonDotProdSupported();
                    static /*0x112a6d0*/ Unity.Burst.Intrinsics.v64 vdot_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112a690*/ Unity.Burst.Intrinsics.v64 vdot_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x112a850*/ Unity.Burst.Intrinsics.v128 vdotq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112a810*/ Unity.Burst.Intrinsics.v128 vdotq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x112a5d0*/ Unity.Burst.Intrinsics.v64 vdot_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112a590*/ Unity.Burst.Intrinsics.v64 vdot_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112a7d0*/ Unity.Burst.Intrinsics.v128 vdotq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112a790*/ Unity.Burst.Intrinsics.v128 vdotq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112a650*/ Unity.Burst.Intrinsics.v64 vdot_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112a610*/ Unity.Burst.Intrinsics.v64 vdot_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x112a750*/ Unity.Burst.Intrinsics.v128 vdotq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x112a710*/ Unity.Burst.Intrinsics.v128 vdotq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x348b00*/ bool get_IsNeonRDMASupported();
                    static /*0x1136f40*/ Unity.Burst.Intrinsics.v64 vqrdmlah_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1136f80*/ Unity.Burst.Intrinsics.v64 vqrdmlah_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x1137180*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x11371c0*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1137380*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11373c0*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x11375c0*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1137600*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x1136e40*/ Unity.Burst.Intrinsics.v64 vqrdmlah_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137080*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1136ec0*/ Unity.Burst.Intrinsics.v64 vqrdmlah_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137100*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1136e80*/ Unity.Burst.Intrinsics.v64 vqrdmlah_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11370c0*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1136f00*/ Unity.Burst.Intrinsics.v64 vqrdmlah_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137140*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137280*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x11374c0*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137300*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137540*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x11372c0*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137500*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137340*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137580*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137040*/ short vqrdmlahh_s16(short a0, short a1, short a2);
                    static /*0x1137240*/ int vqrdmlahs_s32(int a0, int a1, int a2);
                    static /*0x1137480*/ short vqrdmlshh_s16(short a0, short a1, short a2);
                    static /*0x1137680*/ int vqrdmlshs_s32(int a0, int a1, int a2);
                    static /*0x1136fc0*/ short vqrdmlahh_lane_s16(short a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137000*/ short vqrdmlahh_laneq_s16(short a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137200*/ int vqrdmlahs_lane_s32(int a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137400*/ short vqrdmlshh_lane_s16(short a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1137440*/ short vqrdmlshh_laneq_s16(short a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x1137640*/ int vqrdmlshs_lane_s32(int a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_s8(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_s16(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_s32(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_s64(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_u8(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_u16(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_u32(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_u64(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_f16(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_f32(ulong a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vcreate_f64(ulong a0);
                    static /*0x112ad90*/ Unity.Burst.Intrinsics.v64 vdup_n_s8(sbyte a0);
                    static /*0x112b5a0*/ Unity.Burst.Intrinsics.v128 vdupq_n_s8(sbyte a0);
                    static /*0x112ad30*/ Unity.Burst.Intrinsics.v64 vdup_n_s16(short a0);
                    static /*0x112b540*/ Unity.Burst.Intrinsics.v128 vdupq_n_s16(short a0);
                    static /*0x112ad60*/ Unity.Burst.Intrinsics.v64 vdup_n_s32(int a0);
                    static /*0x112b560*/ Unity.Burst.Intrinsics.v128 vdupq_n_s32(int a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vdup_n_s64(long a0);
                    static /*0x112b580*/ Unity.Burst.Intrinsics.v128 vdupq_n_s64(long a0);
                    static /*0x112ad90*/ Unity.Burst.Intrinsics.v64 vdup_n_u8(byte a0);
                    static /*0x112b5a0*/ Unity.Burst.Intrinsics.v128 vdupq_n_u8(byte a0);
                    static /*0x112ad30*/ Unity.Burst.Intrinsics.v64 vdup_n_u16(ushort a0);
                    static /*0x112b540*/ Unity.Burst.Intrinsics.v128 vdupq_n_u16(ushort a0);
                    static /*0x112ad60*/ Unity.Burst.Intrinsics.v64 vdup_n_u32(uint a0);
                    static /*0x112b560*/ Unity.Burst.Intrinsics.v128 vdupq_n_u32(uint a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vdup_n_u64(ulong a0);
                    static /*0x112b580*/ Unity.Burst.Intrinsics.v128 vdupq_n_u64(ulong a0);
                    static /*0x112acd0*/ Unity.Burst.Intrinsics.v64 vdup_n_f32(float a0);
                    static /*0x112b500*/ Unity.Burst.Intrinsics.v128 vdupq_n_f32(float a0);
                    static /*0x112ad00*/ Unity.Burst.Intrinsics.v64 vdup_n_f64(double a0);
                    static /*0x112b520*/ Unity.Burst.Intrinsics.v128 vdupq_n_f64(double a0);
                    static /*0x112ad90*/ Unity.Burst.Intrinsics.v64 vmov_n_s8(sbyte a0);
                    static /*0x112b5a0*/ Unity.Burst.Intrinsics.v128 vmovq_n_s8(sbyte a0);
                    static /*0x112ad30*/ Unity.Burst.Intrinsics.v64 vmov_n_s16(short a0);
                    static /*0x112b540*/ Unity.Burst.Intrinsics.v128 vmovq_n_s16(short a0);
                    static /*0x112ad60*/ Unity.Burst.Intrinsics.v64 vmov_n_s32(int a0);
                    static /*0x112b560*/ Unity.Burst.Intrinsics.v128 vmovq_n_s32(int a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vmov_n_s64(long a0);
                    static /*0x112b580*/ Unity.Burst.Intrinsics.v128 vmovq_n_s64(long a0);
                    static /*0x112ad90*/ Unity.Burst.Intrinsics.v64 vmov_n_u8(byte a0);
                    static /*0x112b5a0*/ Unity.Burst.Intrinsics.v128 vmovq_n_u8(byte a0);
                    static /*0x112ad30*/ Unity.Burst.Intrinsics.v64 vmov_n_u16(ushort a0);
                    static /*0x112b540*/ Unity.Burst.Intrinsics.v128 vmovq_n_u16(ushort a0);
                    static /*0x112ad60*/ Unity.Burst.Intrinsics.v64 vmov_n_u32(uint a0);
                    static /*0x112b560*/ Unity.Burst.Intrinsics.v128 vmovq_n_u32(uint a0);
                    static /*0x1128aa0*/ Unity.Burst.Intrinsics.v64 vmov_n_u64(ulong a0);
                    static /*0x112b580*/ Unity.Burst.Intrinsics.v128 vmovq_n_u64(ulong a0);
                    static /*0x112acd0*/ Unity.Burst.Intrinsics.v64 vmov_n_f32(float a0);
                    static /*0x112b500*/ Unity.Burst.Intrinsics.v128 vmovq_n_f32(float a0);
                    static /*0x112ad00*/ Unity.Burst.Intrinsics.v64 vmov_n_f64(double a0);
                    static /*0x112b520*/ Unity.Burst.Intrinsics.v128 vmovq_n_f64(double a0);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_f16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x1128130*/ Unity.Burst.Intrinsics.v128 vcombine_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0xa5a7f0*/ Unity.Burst.Intrinsics.v64 vget_high_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vget_low_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_s8(sbyte* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_s8(sbyte* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_s16(short* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_s16(short* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_s32(int* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_s32(int* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_s64(long* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_s64(long* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_u8(byte* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_u8(byte* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_u16(ushort* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_u16(ushort* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_u32(uint* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_u32(uint* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_u64(ulong* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_u64(ulong* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_f32(float* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_f32(float* a0);
                    static /*0x6937d0*/ Unity.Burst.Intrinsics.v64 vld1_f64(double* a0);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 vld1q_f64(double* a0);
                    static /*0x9e29e0*/ void vst1_s8(sbyte* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_s8(sbyte* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_s16(short* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_s16(short* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_s32(int* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_s32(int* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_s64(long* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_s64(long* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_u8(byte* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_u8(byte* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_u16(ushort* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_u16(ushort* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_u32(uint* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_u32(uint* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_u64(ulong* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_u64(ulong* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_f32(float* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_f32(float* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x9e29e0*/ void vst1_f64(double* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0xdb4640*/ void vst1q_f64(double* a0, Unity.Burst.Intrinsics.v128 a1);
                    /*0x32f970*/ Neon();
                }
            }

            class Common
            {
                static /*0x32d010*/ void Pause();
                static /*0x114e840*/ ulong umul128(ulong x, ulong y, ref ulong high);
            }

            class BurstTargetCpuAttribute : System.Attribute
            {
                /*0x10*/ Unity.Burst.BurstTargetCpu TargetCpu;

                /*0xea4040*/ BurstTargetCpuAttribute(Unity.Burst.BurstTargetCpu TargetCpu);
            }

            class V64DebugView
            {
                /*0x10*/ Unity.Burst.Intrinsics.v64 m_Value;

                /*0x1152e30*/ V64DebugView(Unity.Burst.Intrinsics.v64 value);
                /*0x1152e60*/ byte[] get_Byte();
                /*0x1152ff0*/ sbyte[] get_SByte();
                /*0x11532e0*/ ushort[] get_UShort();
                /*0x1153180*/ short[] get_SShort();
                /*0x1153210*/ uint[] get_UInt();
                /*0x11530b0*/ int[] get_SInt();
                /*0x1152f80*/ float[] get_Float();
                /*0x1153120*/ long[] get_SLong();
                /*0x1153280*/ ulong[] get_ULong();
                /*0x1152f20*/ double[] get_Double();
            }

            class V128DebugView
            {
                /*0x10*/ Unity.Burst.Intrinsics.v128 m_Value;

                /*0x836380*/ V128DebugView(Unity.Burst.Intrinsics.v128 value);
                /*0x1151c00*/ byte[] get_Byte();
                /*0x1151e40*/ sbyte[] get_SByte();
                /*0x1152220*/ ushort[] get_UShort();
                /*0x1152070*/ short[] get_SShort();
                /*0x1152130*/ uint[] get_UInt();
                /*0x1151f80*/ int[] get_SInt();
                /*0x1151db0*/ float[] get_Float();
                /*0x1152000*/ long[] get_SLong();
                /*0x11521b0*/ ulong[] get_ULong();
                /*0x1151d40*/ double[] get_Double();
            }

            class V256DebugView
            {
                /*0x10*/ Unity.Burst.Intrinsics.v256 m_Value;

                /*0x834b70*/ V256DebugView(Unity.Burst.Intrinsics.v256 value);
                /*0x11522e0*/ byte[] get_Byte();
                /*0x11526a0*/ sbyte[] get_SByte();
                /*0x1152cd0*/ ushort[] get_UShort();
                /*0x1152a30*/ short[] get_SShort();
                /*0x1152b90*/ uint[] get_UInt();
                /*0x11528f0*/ int[] get_SInt();
                /*0x11525c0*/ float[] get_Float();
                /*0x11529a0*/ long[] get_SLong();
                /*0x1152c40*/ ulong[] get_ULong();
                /*0x1152530*/ double[] get_Double();
            }

            struct v128
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x18*/ byte Byte8;
                /*0x19*/ byte Byte9;
                /*0x1a*/ byte Byte10;
                /*0x1b*/ byte Byte11;
                /*0x1c*/ byte Byte12;
                /*0x1d*/ byte Byte13;
                /*0x1e*/ byte Byte14;
                /*0x1f*/ byte Byte15;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x18*/ sbyte SByte8;
                /*0x19*/ sbyte SByte9;
                /*0x1a*/ sbyte SByte10;
                /*0x1b*/ sbyte SByte11;
                /*0x1c*/ sbyte SByte12;
                /*0x1d*/ sbyte SByte13;
                /*0x1e*/ sbyte SByte14;
                /*0x1f*/ sbyte SByte15;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x18*/ ushort UShort4;
                /*0x1a*/ ushort UShort5;
                /*0x1c*/ ushort UShort6;
                /*0x1e*/ ushort UShort7;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x18*/ short SShort4;
                /*0x1a*/ short SShort5;
                /*0x1c*/ short SShort6;
                /*0x1e*/ short SShort7;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x18*/ uint UInt2;
                /*0x1c*/ uint UInt3;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x18*/ int SInt2;
                /*0x1c*/ int SInt3;
                /*0x10*/ ulong ULong0;
                /*0x18*/ ulong ULong1;
                /*0x10*/ long SLong0;
                /*0x18*/ long SLong1;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x18*/ float Float2;
                /*0x1c*/ float Float3;
                /*0x10*/ double Double0;
                /*0x18*/ double Double1;
                /*0x10*/ Unity.Burst.Intrinsics.v64 Lo64;
                /*0x18*/ Unity.Burst.Intrinsics.v64 Hi64;

                /*0x11534e0*/ v128(byte b);
                /*0x1153420*/ v128(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p);
                /*0x11534e0*/ v128(sbyte b);
                /*0x1153420*/ v128(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p);
                /*0x1153520*/ v128(short v);
                /*0x1153550*/ v128(short a, short b, short c, short d, short e, short f, short g, short h);
                /*0x1153520*/ v128(ushort v);
                /*0x1153550*/ v128(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h);
                /*0x11535b0*/ v128(int v);
                /*0x1153590*/ v128(int a, int b, int c, int d);
                /*0x11535b0*/ v128(uint v);
                /*0x1153590*/ v128(uint a, uint b, uint c, uint d);
                /*0x1153510*/ v128(float f);
                /*0x11534a0*/ v128(float a, float b, float c, float d);
                /*0x11534c0*/ v128(double f);
                /*0x11534d0*/ v128(double a, double b);
                /*0x1153540*/ v128(long f);
                /*0xbee490*/ v128(long a, long b);
                /*0x1153540*/ v128(ulong f);
                /*0xbee490*/ v128(ulong a, ulong b);
                /*0xbee490*/ v128(Unity.Burst.Intrinsics.v64 lo, Unity.Burst.Intrinsics.v64 hi);
            }

            struct v256
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x18*/ byte Byte8;
                /*0x19*/ byte Byte9;
                /*0x1a*/ byte Byte10;
                /*0x1b*/ byte Byte11;
                /*0x1c*/ byte Byte12;
                /*0x1d*/ byte Byte13;
                /*0x1e*/ byte Byte14;
                /*0x1f*/ byte Byte15;
                /*0x20*/ byte Byte16;
                /*0x21*/ byte Byte17;
                /*0x22*/ byte Byte18;
                /*0x23*/ byte Byte19;
                /*0x24*/ byte Byte20;
                /*0x25*/ byte Byte21;
                /*0x26*/ byte Byte22;
                /*0x27*/ byte Byte23;
                /*0x28*/ byte Byte24;
                /*0x29*/ byte Byte25;
                /*0x2a*/ byte Byte26;
                /*0x2b*/ byte Byte27;
                /*0x2c*/ byte Byte28;
                /*0x2d*/ byte Byte29;
                /*0x2e*/ byte Byte30;
                /*0x2f*/ byte Byte31;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x18*/ sbyte SByte8;
                /*0x19*/ sbyte SByte9;
                /*0x1a*/ sbyte SByte10;
                /*0x1b*/ sbyte SByte11;
                /*0x1c*/ sbyte SByte12;
                /*0x1d*/ sbyte SByte13;
                /*0x1e*/ sbyte SByte14;
                /*0x1f*/ sbyte SByte15;
                /*0x20*/ sbyte SByte16;
                /*0x21*/ sbyte SByte17;
                /*0x22*/ sbyte SByte18;
                /*0x23*/ sbyte SByte19;
                /*0x24*/ sbyte SByte20;
                /*0x25*/ sbyte SByte21;
                /*0x26*/ sbyte SByte22;
                /*0x27*/ sbyte SByte23;
                /*0x28*/ sbyte SByte24;
                /*0x29*/ sbyte SByte25;
                /*0x2a*/ sbyte SByte26;
                /*0x2b*/ sbyte SByte27;
                /*0x2c*/ sbyte SByte28;
                /*0x2d*/ sbyte SByte29;
                /*0x2e*/ sbyte SByte30;
                /*0x2f*/ sbyte SByte31;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x18*/ ushort UShort4;
                /*0x1a*/ ushort UShort5;
                /*0x1c*/ ushort UShort6;
                /*0x1e*/ ushort UShort7;
                /*0x20*/ ushort UShort8;
                /*0x22*/ ushort UShort9;
                /*0x24*/ ushort UShort10;
                /*0x26*/ ushort UShort11;
                /*0x28*/ ushort UShort12;
                /*0x2a*/ ushort UShort13;
                /*0x2c*/ ushort UShort14;
                /*0x2e*/ ushort UShort15;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x18*/ short SShort4;
                /*0x1a*/ short SShort5;
                /*0x1c*/ short SShort6;
                /*0x1e*/ short SShort7;
                /*0x20*/ short SShort8;
                /*0x22*/ short SShort9;
                /*0x24*/ short SShort10;
                /*0x26*/ short SShort11;
                /*0x28*/ short SShort12;
                /*0x2a*/ short SShort13;
                /*0x2c*/ short SShort14;
                /*0x2e*/ short SShort15;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x18*/ uint UInt2;
                /*0x1c*/ uint UInt3;
                /*0x20*/ uint UInt4;
                /*0x24*/ uint UInt5;
                /*0x28*/ uint UInt6;
                /*0x2c*/ uint UInt7;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x18*/ int SInt2;
                /*0x1c*/ int SInt3;
                /*0x20*/ int SInt4;
                /*0x24*/ int SInt5;
                /*0x28*/ int SInt6;
                /*0x2c*/ int SInt7;
                /*0x10*/ ulong ULong0;
                /*0x18*/ ulong ULong1;
                /*0x20*/ ulong ULong2;
                /*0x28*/ ulong ULong3;
                /*0x10*/ long SLong0;
                /*0x18*/ long SLong1;
                /*0x20*/ long SLong2;
                /*0x28*/ long SLong3;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x18*/ float Float2;
                /*0x1c*/ float Float3;
                /*0x20*/ float Float4;
                /*0x24*/ float Float5;
                /*0x28*/ float Float6;
                /*0x2c*/ float Float7;
                /*0x10*/ double Double0;
                /*0x18*/ double Double1;
                /*0x20*/ double Double2;
                /*0x28*/ double Double3;
                /*0x10*/ Unity.Burst.Intrinsics.v128 Lo128;
                /*0x20*/ Unity.Burst.Intrinsics.v128 Hi128;

                /*0x1153890*/ v256(byte b);
                /*0x11535c0*/ v256(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p, byte q, byte r, byte s, byte t, byte u, byte v, byte w, byte x, byte y, byte z, byte A, byte B, byte C, byte D, byte E, byte F);
                /*0x1153890*/ v256(sbyte b);
                /*0x11535c0*/ v256(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p, sbyte q, sbyte r, sbyte s, sbyte t, sbyte u, sbyte v, sbyte w, sbyte x, sbyte y, sbyte z, sbyte A, sbyte B, sbyte C, sbyte D, sbyte E, sbyte F);
                /*0x1153770*/ v256(short v);
                /*0x1153800*/ v256(short a, short b, short c, short d, short e, short f, short g, short h, short i, short j, short k, short l, short m, short n, short o, short p);
                /*0x1153770*/ v256(ushort v);
                /*0x1153800*/ v256(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h, ushort i, ushort j, ushort k, ushort l, ushort m, ushort n, ushort o, ushort p);
                /*0x1153750*/ v256(int v);
                /*0x1153900*/ v256(int a, int b, int c, int d, int e, int f, int g, int h);
                /*0x1153750*/ v256(uint v);
                /*0x1153900*/ v256(uint a, uint b, uint c, uint d, uint e, uint f, uint g, uint h);
                /*0x1153710*/ v256(float f);
                /*0x11537b0*/ v256(float a, float b, float c, float d, float e, float f, float g, float h);
                /*0x11538f0*/ v256(double f);
                /*0x1153730*/ v256(double a, double b, double c, double d);
                /*0x1153720*/ v256(long f);
                /*0x11536f0*/ v256(long a, long b, long c, long d);
                /*0x1153720*/ v256(ulong f);
                /*0x11536f0*/ v256(ulong a, ulong b, ulong c, ulong d);
                /*0x99b640*/ v256(Unity.Burst.Intrinsics.v128 lo, Unity.Burst.Intrinsics.v128 hi);
            }

            struct v64
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x10*/ ulong ULong0;
                /*0x10*/ long SLong0;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x10*/ double Double0;

                /*0x1153950*/ v64(byte b);
                /*0x11539b0*/ v64(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h);
                /*0x1153950*/ v64(sbyte b);
                /*0x11539b0*/ v64(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h);
                /*0x11539a0*/ v64(short v);
                /*0x1153980*/ v64(short a, short b, short c, short d);
                /*0x11539a0*/ v64(ushort v);
                /*0x1153980*/ v64(ushort a, ushort b, ushort c, ushort d);
                /*0x1153940*/ v64(int v);
                /*0xa59f20*/ v64(int a, int b);
                /*0x1153940*/ v64(uint v);
                /*0xa59f20*/ v64(uint a, uint b);
                /*0x1153930*/ v64(float f);
                /*0x99b700*/ v64(float a, float b);
                /*0x1153970*/ v64(double a);
                /*0x9e29e0*/ v64(long a);
                /*0x9e29e0*/ v64(ulong a);
            }

            class X86
            {
                static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 GenericCSharpLoad(void* ptr);
                static /*0xdb4640*/ void GenericCSharpStore(void* ptr, Unity.Burst.Intrinsics.v128 val);
                static /*0x11533c0*/ sbyte Saturate_To_Int8(int val);
                static /*0x1153400*/ byte Saturate_To_UnsignedInt8(int val);
                static /*0x11533a0*/ short Saturate_To_Int16(int val);
                static /*0x11533e0*/ ushort Saturate_To_UnsignedInt16(int val);
                static /*0x1153370*/ bool IsNaN(uint v);
                static /*0x1153380*/ bool IsNaN(ulong v);
                static /*0x32d010*/ void BurstIntrinsicSetCSRFromManaged(int _);
                static /*0x388e90*/ int BurstIntrinsicGetCSRFromManaged();
                static /*0xbf9940*/ int getcsr_raw();
                static /*0x6b4390*/ void setcsr_raw(int bits);
                static /*0x6b4390*/ void DoSetCSRTrampoline(int bits);
                static /*0xbf9940*/ int DoGetCSRTrampoline();
                static /*0xbf9940*/ Unity.Burst.Intrinsics.X86.MXCSRBits get_MXCSR();
                static /*0x6b4390*/ void set_MXCSR(Unity.Burst.Intrinsics.X86.MXCSRBits value);

                class Avx
                {
                    static /*0x348b00*/ bool get_IsAvxSupported();
                    static /*0x114abb0*/ Unity.Burst.Intrinsics.v256 mm256_add_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114ac40*/ Unity.Burst.Intrinsics.v256 mm256_add_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114ad10*/ Unity.Burst.Intrinsics.v256 mm256_addsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114ada0*/ Unity.Burst.Intrinsics.v256 mm256_addsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143ba0*/ Unity.Burst.Intrinsics.v256 mm256_and_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114ae30*/ Unity.Burst.Intrinsics.v256 mm256_and_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143c30*/ Unity.Burst.Intrinsics.v256 mm256_andnot_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114aec0*/ Unity.Burst.Intrinsics.v256 mm256_andnot_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114af90*/ Unity.Burst.Intrinsics.v256 mm256_blend_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x114b050*/ Unity.Burst.Intrinsics.v256 mm256_blend_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x114b110*/ Unity.Burst.Intrinsics.v256 mm256_blendv_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x114b1e0*/ Unity.Burst.Intrinsics.v256 mm256_blendv_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x114b8b0*/ Unity.Burst.Intrinsics.v256 mm256_div_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114b940*/ Unity.Burst.Intrinsics.v256 mm256_div_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114ba50*/ Unity.Burst.Intrinsics.v256 mm256_dp_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x114bc70*/ Unity.Burst.Intrinsics.v256 mm256_hadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114bd00*/ Unity.Burst.Intrinsics.v256 mm256_hadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114bd90*/ Unity.Burst.Intrinsics.v256 mm256_hsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114be20*/ Unity.Burst.Intrinsics.v256 mm256_hsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c1b0*/ Unity.Burst.Intrinsics.v256 mm256_max_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c240*/ Unity.Burst.Intrinsics.v256 mm256_max_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c440*/ Unity.Burst.Intrinsics.v256 mm256_min_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c4d0*/ Unity.Burst.Intrinsics.v256 mm256_min_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c840*/ Unity.Burst.Intrinsics.v256 mm256_mul_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c8d0*/ Unity.Burst.Intrinsics.v256 mm256_mul_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146600*/ Unity.Burst.Intrinsics.v256 mm256_or_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114c9a0*/ Unity.Burst.Intrinsics.v256 mm256_or_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114d530*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x114d5f0*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x114d970*/ Unity.Burst.Intrinsics.v256 mm256_sub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114da00*/ Unity.Burst.Intrinsics.v256 mm256_sub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148720*/ Unity.Burst.Intrinsics.v256 mm256_xor_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114e060*/ Unity.Burst.Intrinsics.v256 mm256_xor_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11489d0*/ Unity.Burst.Intrinsics.v128 cmp_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x114b410*/ Unity.Burst.Intrinsics.v256 mm256_cmp_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x1149100*/ Unity.Burst.Intrinsics.v128 cmp_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x114b4c0*/ Unity.Burst.Intrinsics.v256 mm256_cmp_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x114aa20*/ Unity.Burst.Intrinsics.v128 cmp_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x114aa80*/ Unity.Burst.Intrinsics.v128 cmp_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x114b570*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi32_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114b5b0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi32_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114b6d0*/ Unity.Burst.Intrinsics.v128 mm256_cvtpd_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114b760*/ Unity.Burst.Intrinsics.v256 mm256_cvtps_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114b7d0*/ Unity.Burst.Intrinsics.v256 mm256_cvtps_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114b810*/ Unity.Burst.Intrinsics.v128 mm256_cvttpd_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114b620*/ Unity.Burst.Intrinsics.v128 mm256_cvtpd_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114b840*/ Unity.Burst.Intrinsics.v256 mm256_cvttps_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0xf72200*/ float mm256_cvtss_f32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114bb20*/ Unity.Burst.Intrinsics.v128 mm256_extractf128_ps(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x114bb20*/ Unity.Burst.Intrinsics.v128 mm256_extractf128_pd(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x114bb20*/ Unity.Burst.Intrinsics.v128 mm256_extractf128_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x32d010*/ void mm256_zeroall();
                    static /*0x32d010*/ void mm256_zeroupper();
                    static /*0x114e1e0*/ Unity.Burst.Intrinsics.v128 permutevar_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114cb30*/ Unity.Burst.Intrinsics.v256 mm256_permutevar_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114e170*/ Unity.Burst.Intrinsics.v128 permute_ps(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1146c10*/ Unity.Burst.Intrinsics.v256 mm256_permute_ps(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x114e1b0*/ Unity.Burst.Intrinsics.v128 permutevar_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114cad0*/ Unity.Burst.Intrinsics.v256 mm256_permutevar_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114ca60*/ Unity.Burst.Intrinsics.v256 mm256_permute_pd(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x114e140*/ Unity.Burst.Intrinsics.v128 permute_pd(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1148980*/ Unity.Burst.Intrinsics.v128 Select4(Unity.Burst.Intrinsics.v256 src1, Unity.Burst.Intrinsics.v256 src2, int control);
                    static /*0x11468d0*/ Unity.Burst.Intrinsics.v256 mm256_permute2f128_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x11468d0*/ Unity.Burst.Intrinsics.v256 mm256_permute2f128_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x11468d0*/ Unity.Burst.Intrinsics.v256 mm256_permute2f128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x11440b0*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_ss(void* ptr);
                    static /*0x1142ac0*/ Unity.Burst.Intrinsics.v128 broadcast_ss(void* ptr);
                    static /*0x11440f0*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_sd(void* ptr);
                    static /*0x1144110*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_ps(void* ptr);
                    static /*0x114b2b0*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_pd(void* ptr);
                    static /*0x114bf30*/ Unity.Burst.Intrinsics.v256 mm256_insertf128_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x11452a0*/ Unity.Burst.Intrinsics.v256 mm256_insertf128_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x11452a0*/ Unity.Burst.Intrinsics.v256 mm256_insertf128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_load_ps(void* ptr);
                    static /*0x114d950*/ void mm256_store_ps(void* ptr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_load_pd(void* ptr);
                    static /*0x114d950*/ void mm256_store_pd(void* ptr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_loadu_pd(void* ptr);
                    static /*0x114d950*/ void mm256_storeu_pd(void* ptr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_loadu_ps(void* ptr);
                    static /*0x114d950*/ void mm256_storeu_ps(void* ptr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_load_si256(void* ptr);
                    static /*0x114d950*/ void mm256_store_si256(void* ptr, Unity.Burst.Intrinsics.v256 v);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_loadu_si256(void* ptr);
                    static /*0x114d950*/ void mm256_storeu_si256(void* ptr, Unity.Burst.Intrinsics.v256 v);
                    static /*0x114bf60*/ Unity.Burst.Intrinsics.v256 mm256_loadu2_m128(void* hiaddr, void* loaddr);
                    static /*0x114bf60*/ Unity.Burst.Intrinsics.v256 mm256_loadu2_m128d(void* hiaddr, void* loaddr);
                    static /*0x114bf60*/ Unity.Burst.Intrinsics.v256 mm256_loadu2_m128i(void* hiaddr, void* loaddr);
                    static /*0x114d1e0*/ Unity.Burst.Intrinsics.v256 mm256_set_m128(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x114d960*/ void mm256_storeu2_m128(void* hiaddr, void* loaddr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x114d960*/ void mm256_storeu2_m128d(void* hiaddr, void* loaddr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x114d960*/ void mm256_storeu2_m128i(void* hiaddr, void* loaddr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x114aae0*/ Unity.Burst.Intrinsics.v128 maskload_pd(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x114bf80*/ Unity.Burst.Intrinsics.v256 mm256_maskload_pd(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x114ab50*/ void maskstore_pd(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x114c0c0*/ void mm256_maskstore_pd(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x114ab10*/ Unity.Burst.Intrinsics.v128 maskload_ps(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x114bff0*/ Unity.Burst.Intrinsics.v256 mm256_maskload_ps(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x114ab70*/ void maskstore_ps(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x114c110*/ void mm256_maskstore_ps(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x114c6f0*/ Unity.Burst.Intrinsics.v256 mm256_movehdup_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114c720*/ Unity.Burst.Intrinsics.v256 mm256_moveldup_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114c6d0*/ Unity.Burst.Intrinsics.v256 mm256_movedup_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_lddqu_si256(void* mem_addr);
                    static /*0x114d950*/ void mm256_stream_si256(void* mem_addr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x114d950*/ void mm256_stream_pd(void* mem_addr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x114d950*/ void mm256_stream_ps(void* mem_addr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x114cc20*/ Unity.Burst.Intrinsics.v256 mm256_rcp_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114ce30*/ Unity.Burst.Intrinsics.v256 mm256_rsqrt_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114d6c0*/ Unity.Burst.Intrinsics.v256 mm256_sqrt_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114d730*/ Unity.Burst.Intrinsics.v256 mm256_sqrt_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114cd30*/ Unity.Burst.Intrinsics.v256 mm256_round_pd(Unity.Burst.Intrinsics.v256 a, int rounding);
                    static /*0x114b2f0*/ Unity.Burst.Intrinsics.v256 mm256_ceil_pd(Unity.Burst.Intrinsics.v256 val);
                    static /*0x114bb50*/ Unity.Burst.Intrinsics.v256 mm256_floor_pd(Unity.Burst.Intrinsics.v256 val);
                    static /*0x114cdb0*/ Unity.Burst.Intrinsics.v256 mm256_round_ps(Unity.Burst.Intrinsics.v256 a, int rounding);
                    static /*0x114b380*/ Unity.Burst.Intrinsics.v256 mm256_ceil_ps(Unity.Burst.Intrinsics.v256 val);
                    static /*0x114bbe0*/ Unity.Burst.Intrinsics.v256 mm256_floor_ps(Unity.Burst.Intrinsics.v256 val);
                    static /*0x11483c0*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148600*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114df30*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114dfd0*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114dec0*/ int mm256_testz_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114db80*/ int mm256_testc_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114dd50*/ int mm256_testnzc_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114de60*/ int mm256_testz_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114db10*/ int mm256_testc_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114dbf0*/ int mm256_testnzc_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114e3a0*/ int testz_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114e230*/ int testc_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114e2a0*/ int testnzc_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114de90*/ int mm256_testz_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114db50*/ int mm256_testc_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114dca0*/ int mm256_testnzc_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x114e3d0*/ int testz_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114e270*/ int testc_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114e320*/ int testnzc_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x114c750*/ int mm256_movemask_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114c7a0*/ int mm256_movemask_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114d520*/ Unity.Burst.Intrinsics.v256 mm256_setzero_pd();
                    static /*0x114d520*/ Unity.Burst.Intrinsics.v256 mm256_setzero_ps();
                    static /*0x114d520*/ Unity.Burst.Intrinsics.v256 mm256_setzero_si256();
                    static /*0x114d200*/ Unity.Burst.Intrinsics.v256 mm256_set_pd(double d, double c, double b, double a);
                    static /*0x114d220*/ Unity.Burst.Intrinsics.v256 mm256_set_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0);
                    static /*0x114d0b0*/ Unity.Burst.Intrinsics.v256 mm256_set_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_);
                    static /*0x114cfc0*/ Unity.Burst.Intrinsics.v256 mm256_set_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_);
                    static /*0x114d050*/ Unity.Burst.Intrinsics.v256 mm256_set_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0);
                    static /*0x114d090*/ Unity.Burst.Intrinsics.v256 mm256_set_epi64x(long e3, long e2, long e1, long e0);
                    static /*0x114d1e0*/ Unity.Burst.Intrinsics.v256 mm256_set_m128d(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x114d1e0*/ Unity.Burst.Intrinsics.v256 mm256_set_m128i(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x114d4b0*/ Unity.Burst.Intrinsics.v256 mm256_setr_pd(double d, double c, double b, double a);
                    static /*0x114d4d0*/ Unity.Burst.Intrinsics.v256 mm256_setr_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0);
                    static /*0x114d360*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_);
                    static /*0x114d270*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_);
                    static /*0x114d300*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0);
                    static /*0x114d340*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi64x(long e3, long e2, long e1, long e0);
                    static /*0x114d490*/ Unity.Burst.Intrinsics.v256 mm256_setr_m128(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x114d490*/ Unity.Burst.Intrinsics.v256 mm256_setr_m128d(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x114d490*/ Unity.Burst.Intrinsics.v256 mm256_setr_m128i(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x114cfa0*/ Unity.Burst.Intrinsics.v256 mm256_set1_pd(double a);
                    static /*0x114cfb0*/ Unity.Burst.Intrinsics.v256 mm256_set1_ps(float a);
                    static /*0x114cf30*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi8(byte a);
                    static /*0x114cea0*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi16(short a);
                    static /*0x114cef0*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi32(int a);
                    static /*0x114cf10*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi64x(long a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_castpd_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_castps_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_castps_si256(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_castpd_si256(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_castsi256_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_castsi256_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 mm256_castps256_ps128(Unity.Burst.Intrinsics.v256 a);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 mm256_castpd256_pd128(Unity.Burst.Intrinsics.v256 a);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 mm256_castsi256_si128(Unity.Burst.Intrinsics.v256 a);
                    static /*0x114b2d0*/ Unity.Burst.Intrinsics.v256 mm256_castps128_ps256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114b2d0*/ Unity.Burst.Intrinsics.v256 mm256_castpd128_pd256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114b2d0*/ Unity.Burst.Intrinsics.v256 mm256_castsi128_si256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114e400*/ Unity.Burst.Intrinsics.v128 undefined_ps();
                    static /*0x114e400*/ Unity.Burst.Intrinsics.v128 undefined_pd();
                    static /*0x114e400*/ Unity.Burst.Intrinsics.v128 undefined_si128();
                    static /*0x114d520*/ Unity.Burst.Intrinsics.v256 mm256_undefined_ps();
                    static /*0x114d520*/ Unity.Burst.Intrinsics.v256 mm256_undefined_pd();
                    static /*0x114d520*/ Unity.Burst.Intrinsics.v256 mm256_undefined_si256();
                    static /*0x114b2d0*/ Unity.Burst.Intrinsics.v256 mm256_zextps128_ps256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114e120*/ Unity.Burst.Intrinsics.v256 mm256_zextpd128_pd256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114e120*/ Unity.Burst.Intrinsics.v256 mm256_zextsi128_si256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114bf10*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi8(Unity.Burst.Intrinsics.v256 a, int i, int index);
                    static /*0x114beb0*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi16(Unity.Burst.Intrinsics.v256 a, int i, int index);
                    static /*0x114bed0*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi32(Unity.Burst.Intrinsics.v256 a, int i, int index);
                    static /*0x114bef0*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi64(Unity.Burst.Intrinsics.v256 a, long i, int index);
                    static /*0x114bb00*/ int mm256_extract_epi32(Unity.Burst.Intrinsics.v256 a, int index);
                    static /*0x114bb10*/ long mm256_extract_epi64(Unity.Burst.Intrinsics.v256 a, int index);

                    enum CMP
                    {
                        EQ_OQ = 0,
                        LT_OS = 1,
                        LE_OS = 2,
                        UNORD_Q = 3,
                        NEQ_UQ = 4,
                        NLT_US = 5,
                        NLE_US = 6,
                        ORD_Q = 7,
                        EQ_UQ = 8,
                        NGE_US = 9,
                        NGT_US = 10,
                        FALSE_OQ = 11,
                        NEQ_OQ = 12,
                        GE_OS = 13,
                        GT_OS = 14,
                        TRUE_UQ = 15,
                        EQ_OS = 16,
                        LT_OQ = 17,
                        LE_OQ = 18,
                        UNORD_S = 19,
                        NEQ_US = 20,
                        NLT_UQ = 21,
                        NLE_UQ = 22,
                        ORD_S = 23,
                        EQ_US = 24,
                        NGE_UQ = 25,
                        NGT_UQ = 26,
                        FALSE_OS = 27,
                        NEQ_OS = 28,
                        GE_OQ = 29,
                        GT_OQ = 30,
                        TRUE_US = 31,
                    }
                }

                class Avx2
                {
                    static /*0x348b00*/ bool get_IsAvx2Supported();
                    static /*0x11460e0*/ int mm256_movemask_epi8(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1144a80*/ int mm256_extract_epi8(Unity.Burst.Intrinsics.v256 a, int index);
                    static /*0x1144a70*/ int mm256_extract_epi16(Unity.Burst.Intrinsics.v256 a, int index);
                    static /*0xf48cf0*/ double mm256_cvtsd_f64(Unity.Burst.Intrinsics.v256 a);
                    static /*0x6bba50*/ int mm256_cvtsi256_si32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x6937d0*/ long mm256_cvtsi256_si64(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1144460*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11442b0*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144340*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11443d0*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144700*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11444f0*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144580*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144610*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145b40*/ Unity.Burst.Intrinsics.v256 mm256_max_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145a20*/ Unity.Burst.Intrinsics.v256 mm256_max_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145ab0*/ Unity.Burst.Intrinsics.v256 mm256_max_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145cf0*/ Unity.Burst.Intrinsics.v256 mm256_max_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145bd0*/ Unity.Burst.Intrinsics.v256 mm256_max_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145c60*/ Unity.Burst.Intrinsics.v256 mm256_max_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145ea0*/ Unity.Burst.Intrinsics.v256 mm256_min_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145d80*/ Unity.Burst.Intrinsics.v256 mm256_min_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145e10*/ Unity.Burst.Intrinsics.v256 mm256_min_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146050*/ Unity.Burst.Intrinsics.v256 mm256_min_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145f30*/ Unity.Burst.Intrinsics.v256 mm256_min_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145fc0*/ Unity.Burst.Intrinsics.v256 mm256_min_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143ba0*/ Unity.Burst.Intrinsics.v256 mm256_and_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143c30*/ Unity.Burst.Intrinsics.v256 mm256_andnot_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146600*/ Unity.Burst.Intrinsics.v256 mm256_or_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148720*/ Unity.Burst.Intrinsics.v256 mm256_xor_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143600*/ Unity.Burst.Intrinsics.v256 mm256_abs_epi8(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1143520*/ Unity.Burst.Intrinsics.v256 mm256_abs_epi16(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1143590*/ Unity.Burst.Intrinsics.v256 mm256_abs_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x1143820*/ Unity.Burst.Intrinsics.v256 mm256_add_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143670*/ Unity.Burst.Intrinsics.v256 mm256_add_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143700*/ Unity.Burst.Intrinsics.v256 mm256_add_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143790*/ Unity.Burst.Intrinsics.v256 mm256_add_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143940*/ Unity.Burst.Intrinsics.v256 mm256_adds_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11438b0*/ Unity.Burst.Intrinsics.v256 mm256_adds_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143a60*/ Unity.Burst.Intrinsics.v256 mm256_adds_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11439d0*/ Unity.Burst.Intrinsics.v256 mm256_adds_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1147fd0*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1147e20*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1147eb0*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1147f40*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11480f0*/ Unity.Burst.Intrinsics.v256 mm256_subs_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148060*/ Unity.Burst.Intrinsics.v256 mm256_subs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148210*/ Unity.Burst.Intrinsics.v256 mm256_subs_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148180*/ Unity.Burst.Intrinsics.v256 mm256_subs_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143d50*/ Unity.Burst.Intrinsics.v256 mm256_avg_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1143cc0*/ Unity.Burst.Intrinsics.v256 mm256_avg_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144ac0*/ Unity.Burst.Intrinsics.v256 mm256_hadd_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144b50*/ Unity.Burst.Intrinsics.v256 mm256_hadd_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144be0*/ Unity.Burst.Intrinsics.v256 mm256_hadds_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144c70*/ Unity.Burst.Intrinsics.v256 mm256_hsub_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144d00*/ Unity.Burst.Intrinsics.v256 mm256_hsub_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1144d90*/ Unity.Burst.Intrinsics.v256 mm256_hsubs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11452e0*/ Unity.Burst.Intrinsics.v256 mm256_madd_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1145370*/ Unity.Burst.Intrinsics.v256 mm256_maddubs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146330*/ Unity.Burst.Intrinsics.v256 mm256_mulhi_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11463c0*/ Unity.Burst.Intrinsics.v256 mm256_mulhi_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11464e0*/ Unity.Burst.Intrinsics.v256 mm256_mullo_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146570*/ Unity.Burst.Intrinsics.v256 mm256_mullo_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11462a0*/ Unity.Burst.Intrinsics.v256 mm256_mul_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146210*/ Unity.Burst.Intrinsics.v256 mm256_mul_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146f40*/ Unity.Burst.Intrinsics.v256 mm256_sign_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146e20*/ Unity.Burst.Intrinsics.v256 mm256_sign_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146eb0*/ Unity.Burst.Intrinsics.v256 mm256_sign_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146450*/ Unity.Burst.Intrinsics.v256 mm256_mulhrs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146b80*/ Unity.Burst.Intrinsics.v256 mm256_sad_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146150*/ Unity.Burst.Intrinsics.v256 mm256_mpsadbw_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x1147300*/ Unity.Burst.Intrinsics.v256 mm256_slli_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1144190*/ Unity.Burst.Intrinsics.v256 mm256_bslli_epi128(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147be0*/ Unity.Burst.Intrinsics.v256 mm256_srli_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1144220*/ Unity.Burst.Intrinsics.v256 mm256_bsrli_epi128(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1146fd0*/ Unity.Burst.Intrinsics.v256 mm256_sll_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1147060*/ Unity.Burst.Intrinsics.v256 mm256_sll_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11470f0*/ Unity.Burst.Intrinsics.v256 mm256_sll_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1147180*/ Unity.Burst.Intrinsics.v256 mm256_slli_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147200*/ Unity.Burst.Intrinsics.v256 mm256_slli_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147280*/ Unity.Burst.Intrinsics.v256 mm256_slli_epi64(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147380*/ Unity.Burst.Intrinsics.v256 mm256_sllv_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x1147450*/ Unity.Burst.Intrinsics.v256 mm256_sllv_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x11487b0*/ Unity.Burst.Intrinsics.v128 sllv_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11487f0*/ Unity.Burst.Intrinsics.v128 sllv_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1147520*/ Unity.Burst.Intrinsics.v256 mm256_sra_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11475b0*/ Unity.Burst.Intrinsics.v256 mm256_sra_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1147640*/ Unity.Burst.Intrinsics.v256 mm256_srai_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x11476c0*/ Unity.Burst.Intrinsics.v256 mm256_srai_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147740*/ Unity.Burst.Intrinsics.v256 mm256_srav_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x1148830*/ Unity.Burst.Intrinsics.v128 srav_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11478b0*/ Unity.Burst.Intrinsics.v256 mm256_srl_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1147940*/ Unity.Burst.Intrinsics.v256 mm256_srl_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11479d0*/ Unity.Burst.Intrinsics.v256 mm256_srl_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1147a60*/ Unity.Burst.Intrinsics.v256 mm256_srli_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147ae0*/ Unity.Burst.Intrinsics.v256 mm256_srli_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147b60*/ Unity.Burst.Intrinsics.v256 mm256_srli_epi64(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1147c60*/ Unity.Burst.Intrinsics.v256 mm256_srlv_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x1147d30*/ Unity.Burst.Intrinsics.v256 mm256_srlv_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x1148900*/ Unity.Burst.Intrinsics.v128 srlv_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1148940*/ Unity.Burst.Intrinsics.v128 srlv_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1142a30*/ Unity.Burst.Intrinsics.v128 blend_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1143e90*/ Unity.Burst.Intrinsics.v256 mm256_blend_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x1143af0*/ Unity.Burst.Intrinsics.v256 mm256_alignr_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x1143f70*/ Unity.Burst.Intrinsics.v256 mm256_blendv_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x1143de0*/ Unity.Burst.Intrinsics.v256 mm256_blend_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x1146690*/ Unity.Burst.Intrinsics.v256 mm256_packs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146720*/ Unity.Burst.Intrinsics.v256 mm256_packs_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11467b0*/ Unity.Burst.Intrinsics.v256 mm256_packus_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146840*/ Unity.Burst.Intrinsics.v256 mm256_packus_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148450*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11482a0*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148330*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11483c0*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148690*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x11484e0*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148570*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1148600*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146c90*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x1146c10*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1146d20*/ Unity.Burst.Intrinsics.v256 mm256_shufflehi_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1146da0*/ Unity.Burst.Intrinsics.v256 mm256_shufflelo_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x1144a90*/ Unity.Burst.Intrinsics.v128 mm256_extracti128_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x11452a0*/ Unity.Burst.Intrinsics.v256 mm256_inserti128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1142b00*/ Unity.Burst.Intrinsics.v128 broadcastss_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144120*/ Unity.Burst.Intrinsics.v256 mm256_broadcastss_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1142af0*/ Unity.Burst.Intrinsics.v128 broadcastsd_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11440f0*/ Unity.Burst.Intrinsics.v256 mm256_broadcastsd_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1142a80*/ Unity.Burst.Intrinsics.v128 broadcastb_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1142b10*/ Unity.Burst.Intrinsics.v128 broadcastw_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1142ac0*/ Unity.Burst.Intrinsics.v128 broadcastd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1142ae0*/ Unity.Burst.Intrinsics.v128 broadcastq_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144040*/ Unity.Burst.Intrinsics.v256 mm256_broadcastb_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144140*/ Unity.Burst.Intrinsics.v256 mm256_broadcastw_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11440b0*/ Unity.Burst.Intrinsics.v256 mm256_broadcastd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11440d0*/ Unity.Burst.Intrinsics.v256 mm256_broadcastq_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144110*/ Unity.Burst.Intrinsics.v256 mm256_broadcastsi128_si256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144850*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144880*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11448d0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144790*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11447e0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144820*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11449c0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11449f0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144a40*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144910*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144960*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1144990*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1143460*/ Unity.Burst.Intrinsics.v128 maskload_epi32(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x11434a0*/ Unity.Burst.Intrinsics.v128 maskload_epi64(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x11434d0*/ void maskstore_epi32(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x1143500*/ void maskstore_epi64(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x11458e0*/ Unity.Burst.Intrinsics.v256 mm256_maskload_epi32(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x1145960*/ Unity.Burst.Intrinsics.v256 mm256_maskload_epi64(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x11459b0*/ void mm256_maskstore_epi32(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x11459e0*/ void mm256_maskstore_epi64(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x1146a50*/ Unity.Burst.Intrinsics.v256 mm256_permutevar8x32_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 idx);
                    static /*0x1146ad0*/ Unity.Burst.Intrinsics.v256 mm256_permutevar8x32_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 idx);
                    static /*0x1146970*/ Unity.Burst.Intrinsics.v256 mm256_permute4x64_epi64(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x11469d0*/ Unity.Burst.Intrinsics.v256 mm256_permute4x64_pd(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x11468d0*/ Unity.Burst.Intrinsics.v256 mm256_permute2x128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x1147e00*/ Unity.Burst.Intrinsics.v256 mm256_stream_load_si256(void* mem_addr);
                    static /*0x2a5510*/ void EmulatedGather<T, U>(T* dptr, void* base_addr, long* indexPtr, int scale, int n, U* mask);
                    static /*0x2a5510*/ void EmulatedGather<T, U>(T* dptr, void* base_addr, int* indexPtr, int scale, int n, U* mask);
                    static /*0x1144e20*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x1144f40*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_pd(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1144fd0*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_ps(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x1145180*/ Unity.Burst.Intrinsics.v256 mm256_i64gather_pd(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x1145210*/ Unity.Burst.Intrinsics.v128 mm256_i64gather_ps(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x1142c60*/ Unity.Burst.Intrinsics.v128 i32gather_pd(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1142cf0*/ Unity.Burst.Intrinsics.v128 i32gather_ps(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1142ea0*/ Unity.Burst.Intrinsics.v128 i64gather_pd(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1142f30*/ Unity.Burst.Intrinsics.v128 i64gather_ps(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1144eb0*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1145060*/ Unity.Burst.Intrinsics.v128 mm256_i64gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x11450f0*/ Unity.Burst.Intrinsics.v256 mm256_i64gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x1142b40*/ Unity.Burst.Intrinsics.v128 i32gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1142bd0*/ Unity.Burst.Intrinsics.v128 i32gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1142d80*/ Unity.Burst.Intrinsics.v128 i64gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1142e10*/ Unity.Burst.Intrinsics.v128 i64gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x1145540*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_pd(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x11455e0*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_ps(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x11457b0*/ Unity.Burst.Intrinsics.v256 mm256_mask_i64gather_pd(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x1145850*/ Unity.Burst.Intrinsics.v128 mm256_mask_i64gather_ps(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x1145400*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_epi32(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x11454a0*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_epi64(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x1145710*/ Unity.Burst.Intrinsics.v256 mm256_mask_i64gather_epi64(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x1145680*/ Unity.Burst.Intrinsics.v128 mm256_mask_i64gather_epi32(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x11430e0*/ Unity.Burst.Intrinsics.v128 mask_i32gather_pd(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x1143170*/ Unity.Burst.Intrinsics.v128 mask_i32gather_ps(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x1143330*/ Unity.Burst.Intrinsics.v128 mask_i64gather_pd(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x11433c0*/ Unity.Burst.Intrinsics.v128 mask_i64gather_ps(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x1142fc0*/ Unity.Burst.Intrinsics.v128 mask_i32gather_epi32(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x1143050*/ Unity.Burst.Intrinsics.v128 mask_i32gather_epi64(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x1143200*/ Unity.Burst.Intrinsics.v128 mask_i64gather_epi32(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x11432a0*/ Unity.Burst.Intrinsics.v128 mask_i64gather_epi64(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                }

                class Bmi1
                {
                    static /*0x348b00*/ bool get_IsBmi1Supported();
                    static /*0x114e410*/ uint andn_u32(uint a, uint b);
                    static /*0x114e420*/ ulong andn_u64(ulong a, ulong b);
                    static /*0x114e4a0*/ uint bextr_u32(uint a, uint start, uint len);
                    static /*0x114e4d0*/ ulong bextr_u64(ulong a, uint start, uint len);
                    static /*0x114e430*/ uint bextr2_u32(uint a, uint control);
                    static /*0x114e470*/ ulong bextr2_u64(ulong a, ulong control);
                    static /*0x114e500*/ uint blsi_u32(uint a);
                    static /*0x114e510*/ ulong blsi_u64(ulong a);
                    static /*0x114e520*/ uint blsmsk_u32(uint a);
                    static /*0x114e530*/ ulong blsmsk_u64(ulong a);
                    static /*0x114e540*/ uint blsr_u32(uint a);
                    static /*0x114e550*/ ulong blsr_u64(ulong a);
                    static /*0x114e560*/ uint tzcnt_u32(uint a);
                    static /*0x114e5b0*/ ulong tzcnt_u64(ulong a);
                }

                class Bmi2
                {
                    static /*0x348b00*/ bool get_IsBmi2Supported();
                    static /*0x114e640*/ uint bzhi_u32(uint a, uint index);
                    static /*0x114e660*/ ulong bzhi_u64(ulong a, ulong index);
                    static /*0x114e680*/ uint mulx_u32(uint a, uint b, ref uint hi);
                    static /*0x114e6a0*/ ulong mulx_u64(ulong a, ulong b, ref ulong hi);
                    static /*0x114e700*/ uint pdep_u32(uint a, uint mask);
                    static /*0x114e750*/ ulong pdep_u64(ulong a, ulong mask);
                    static /*0x114e7a0*/ uint pext_u32(uint a, uint mask);
                    static /*0x114e7f0*/ ulong pext_u64(ulong a, ulong mask);
                }

                enum MXCSRBits
                {
                    FlushToZero = 32768,
                    RoundingControlMask = 24576,
                    RoundToNearest = 0,
                    RoundDown = 8192,
                    RoundUp = 16384,
                    RoundTowardZero = 24576,
                    PrecisionMask = 4096,
                    UnderflowMask = 2048,
                    OverflowMask = 1024,
                    DivideByZeroMask = 512,
                    DenormalOperationMask = 256,
                    InvalidOperationMask = 128,
                    ExceptionMask = 8064,
                    DenormalsAreZeroes = 64,
                    PrecisionFlag = 32,
                    UnderflowFlag = 16,
                    OverflowFlag = 8,
                    DivideByZeroFlag = 4,
                    DenormalFlag = 2,
                    InvalidOperationFlag = 1,
                    FlagMask = 63,
                }

                enum RoundingMode
                {
                    FROUND_TO_NEAREST_INT = 0,
                    FROUND_TO_NEG_INF = 1,
                    FROUND_TO_POS_INF = 2,
                    FROUND_TO_ZERO = 3,
                    FROUND_CUR_DIRECTION = 4,
                    FROUND_RAISE_EXC = 0,
                    FROUND_NO_EXC = 8,
                    FROUND_NINT = 0,
                    FROUND_FLOOR = 1,
                    FROUND_CEIL = 2,
                    FROUND_TRUNC = 3,
                    FROUND_RINT = 4,
                    FROUND_NEARBYINT = 12,
                    FROUND_NINT_NOEXC = 8,
                    FROUND_FLOOR_NOEXC = 9,
                    FROUND_CEIL_NOEXC = 10,
                    FROUND_TRUNC_NOEXC = 11,
                    FROUND_RINT_NOEXC = 12,
                }

                struct RoundingScope : System.IDisposable
                {
                    /*0x10*/ Unity.Burst.Intrinsics.X86.MXCSRBits OldBits;

                    /*0x11504f0*/ RoundingScope(Unity.Burst.Intrinsics.X86.MXCSRBits roundingMode);
                    /*0x6b4390*/ void Dispose();
                }

                class F16C
                {
                    static /*0x0*/ ushort[] BaseTable;
                    static /*0x8*/ sbyte[] ShiftTable;

                    static /*0x114eb20*/ F16C();
                    static /*0x348b00*/ bool get_IsF16CSupported();
                    static /*0x114ea90*/ uint HalfToFloat(ushort h);
                    static /*0x114ec20*/ Unity.Burst.Intrinsics.v128 cvtph_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114ed90*/ Unity.Burst.Intrinsics.v256 mm256_cvtph_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x114e8a0*/ ushort FloatToHalf(uint f, int rounding);
                    static /*0x114ecb0*/ Unity.Burst.Intrinsics.v128 cvtps_ph(Unity.Burst.Intrinsics.v128 a, int rounding);
                    static /*0x114ee50*/ Unity.Burst.Intrinsics.v128 mm256_cvtps_ph(Unity.Burst.Intrinsics.v256 a, int rounding);
                }

                class Fma
                {
                    static /*0x348b00*/ bool get_IsFmaSupported();
                    static /*0x114efa0*/ float FmaHelper(float a, float b, float c);
                    static /*0x114efd0*/ float FnmaHelper(float a, float b, float c);
                    static /*0x114f000*/ Unity.Burst.Intrinsics.v128 fmadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f900*/ Unity.Burst.Intrinsics.v256 mm256_fmadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f050*/ Unity.Burst.Intrinsics.v128 fmadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f950*/ Unity.Burst.Intrinsics.v256 mm256_fmadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f100*/ Unity.Burst.Intrinsics.v128 fmadd_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f150*/ Unity.Burst.Intrinsics.v128 fmadd_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f190*/ Unity.Burst.Intrinsics.v128 fmaddsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114fab0*/ Unity.Burst.Intrinsics.v256 mm256_fmaddsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f1e0*/ Unity.Burst.Intrinsics.v128 fmaddsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114fb00*/ Unity.Burst.Intrinsics.v256 mm256_fmaddsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f2b0*/ Unity.Burst.Intrinsics.v128 fmsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114fc80*/ Unity.Burst.Intrinsics.v256 mm256_fmsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f300*/ Unity.Burst.Intrinsics.v128 fmsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114fcd0*/ Unity.Burst.Intrinsics.v256 mm256_fmsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f3d0*/ Unity.Burst.Intrinsics.v128 fmsub_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f420*/ Unity.Burst.Intrinsics.v128 fmsub_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f460*/ Unity.Burst.Intrinsics.v128 fmsubadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114fe70*/ Unity.Burst.Intrinsics.v256 mm256_fmsubadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f4b0*/ Unity.Burst.Intrinsics.v128 fmsubadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114fec0*/ Unity.Burst.Intrinsics.v256 mm256_fmsubadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f570*/ Unity.Burst.Intrinsics.v128 fnmadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x1150040*/ Unity.Burst.Intrinsics.v256 mm256_fnmadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f5c0*/ Unity.Burst.Intrinsics.v128 fnmadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x1150090*/ Unity.Burst.Intrinsics.v256 mm256_fnmadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f690*/ Unity.Burst.Intrinsics.v128 fnmadd_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f6e0*/ Unity.Burst.Intrinsics.v128 fnmadd_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f720*/ Unity.Burst.Intrinsics.v128 fnmsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x1150230*/ Unity.Burst.Intrinsics.v256 mm256_fnmsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f770*/ Unity.Burst.Intrinsics.v128 fnmsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x1150280*/ Unity.Burst.Intrinsics.v256 mm256_fnmsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x114f860*/ Unity.Burst.Intrinsics.v128 fnmsub_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x114f8b0*/ Unity.Burst.Intrinsics.v128 fnmsub_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);

                    struct Union
                    {
                        /*0x10*/ float f;
                        /*0x10*/ uint u;
                    }
                }

                class Popcnt
                {
                    static /*0x1150450*/ bool get_IsPopcntSupported();
                    static /*0x1150490*/ int popcnt_u32(uint v);
                    static /*0x11504c0*/ int popcnt_u64(ulong v);
                }

                class Sse
                {
                    static /*0x348b00*/ bool get_IsSseSupported();
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 load_ps(void* ptr);
                    static /*0x6bba70*/ Unity.Burst.Intrinsics.v128 loadu_ps(void* ptr);
                    static /*0xdb4640*/ void store_ps(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0xdb4640*/ void storeu_ps(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0xdb4640*/ void stream_ps(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151080*/ Unity.Burst.Intrinsics.v128 cvtsi32_ss(Unity.Burst.Intrinsics.v128 a, int b);
                    static /*0x11510a0*/ Unity.Burst.Intrinsics.v128 cvtsi64_ss(Unity.Burst.Intrinsics.v128 a, long b);
                    static /*0x11506f0*/ Unity.Burst.Intrinsics.v128 add_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11506a0*/ Unity.Burst.Intrinsics.v128 add_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151b70*/ Unity.Burst.Intrinsics.v128 sub_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151b20*/ Unity.Burst.Intrinsics.v128 sub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151670*/ Unity.Burst.Intrinsics.v128 mul_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151620*/ Unity.Burst.Intrinsics.v128 mul_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11512c0*/ Unity.Burst.Intrinsics.v128 div_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151270*/ Unity.Burst.Intrinsics.v128 div_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151aa0*/ Unity.Burst.Intrinsics.v128 sqrt_ss(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11519b0*/ Unity.Burst.Intrinsics.v128 sqrt_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151700*/ Unity.Burst.Intrinsics.v128 rcp_ss(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11516c0*/ Unity.Burst.Intrinsics.v128 rcp_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151840*/ Unity.Burst.Intrinsics.v128 rsqrt_ss(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151720*/ Unity.Burst.Intrinsics.v128 rsqrt_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151520*/ Unity.Burst.Intrinsics.v128 min_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151460*/ Unity.Burst.Intrinsics.v128 min_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11513e0*/ Unity.Burst.Intrinsics.v128 max_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151320*/ Unity.Burst.Intrinsics.v128 max_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150710*/ Unity.Burst.Intrinsics.v128 and_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150740*/ Unity.Burst.Intrinsics.v128 andnot_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151690*/ Unity.Burst.Intrinsics.v128 or_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151bd0*/ Unity.Burst.Intrinsics.v128 xor_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11507f0*/ Unity.Burst.Intrinsics.v128 cmpeq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150780*/ Unity.Burst.Intrinsics.v128 cmpeq_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150a60*/ Unity.Burst.Intrinsics.v128 cmplt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150a00*/ Unity.Burst.Intrinsics.v128 cmplt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11509e0*/ Unity.Burst.Intrinsics.v128 cmple_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150980*/ Unity.Burst.Intrinsics.v128 cmple_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150950*/ Unity.Burst.Intrinsics.v128 cmpgt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11508d0*/ Unity.Burst.Intrinsics.v128 cmpgt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11508a0*/ Unity.Burst.Intrinsics.v128 cmpge_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150820*/ Unity.Burst.Intrinsics.v128 cmpge_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150af0*/ Unity.Burst.Intrinsics.v128 cmpneq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150a80*/ Unity.Burst.Intrinsics.v128 cmpneq_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150d60*/ Unity.Burst.Intrinsics.v128 cmpnlt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150d00*/ Unity.Burst.Intrinsics.v128 cmpnlt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150ce0*/ Unity.Burst.Intrinsics.v128 cmpnle_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150c80*/ Unity.Burst.Intrinsics.v128 cmpnle_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150c50*/ Unity.Burst.Intrinsics.v128 cmpngt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150bd0*/ Unity.Burst.Intrinsics.v128 cmpngt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150ba0*/ Unity.Burst.Intrinsics.v128 cmpnge_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150b20*/ Unity.Burst.Intrinsics.v128 cmpnge_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150e30*/ Unity.Burst.Intrinsics.v128 cmpord_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150d80*/ Unity.Burst.Intrinsics.v128 cmpord_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f20*/ Unity.Burst.Intrinsics.v128 cmpunord_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150e70*/ Unity.Burst.Intrinsics.v128 cmpunord_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f60*/ int comieq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150fb0*/ int comilt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150fa0*/ int comile_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f90*/ int comigt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f80*/ int comige_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150fc0*/ int comineq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f60*/ int ucomieq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150fb0*/ int ucomilt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150fa0*/ int ucomile_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f90*/ int ucomigt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150f80*/ int ucomige_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150fc0*/ int ucomineq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11510c0*/ int cvtss_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1150fe0*/ int cvt_ss2si(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151150*/ long cvtss_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0xf72200*/ float cvtss_f32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151210*/ int cvttss_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11511f0*/ int cvtt_ss2si(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151240*/ long cvttss_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151920*/ Unity.Burst.Intrinsics.v128 set_ss(float a);
                    static /*0x11518d0*/ Unity.Burst.Intrinsics.v128 set1_ps(float a);
                    static /*0x11518e0*/ Unity.Burst.Intrinsics.v128 set_ps1(float a);
                    static /*0x1151900*/ Unity.Burst.Intrinsics.v128 set_ps(float e3, float e2, float e1, float e0);
                    static /*0x1151940*/ Unity.Burst.Intrinsics.v128 setr_ps(float e3, float e2, float e1, float e0);
                    static /*0x11515a0*/ Unity.Burst.Intrinsics.v128 move_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1150500*/ int SHUFFLE(int d, int c, int b, int a);
                    static /*0x1151960*/ Unity.Burst.Intrinsics.v128 shuffle_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1151b90*/ Unity.Burst.Intrinsics.v128 unpackhi_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151bb0*/ Unity.Burst.Intrinsics.v128 unpacklo_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11515b0*/ Unity.Burst.Intrinsics.v128 movehl_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11515d0*/ Unity.Burst.Intrinsics.v128 movelh_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11515f0*/ int movemask_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1150530*/ void TRANSPOSE4_PS(ref Unity.Burst.Intrinsics.v128 row0, ref Unity.Burst.Intrinsics.v128 row1, ref Unity.Burst.Intrinsics.v128 row2, ref Unity.Burst.Intrinsics.v128 row3);
                    static /*0x114e400*/ Unity.Burst.Intrinsics.v128 setzero_ps();
                    static /*0x11512e0*/ Unity.Burst.Intrinsics.v128 loadu_si16(void* mem_addr);
                    static /*0xe24ff0*/ void storeu_si16(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x1151300*/ Unity.Burst.Intrinsics.v128 loadu_si64(void* mem_addr);
                    static /*0xe25010*/ void storeu_si64(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                }

                class Sse2
                {
                    static /*0x348b00*/ bool get_IsSse2Supported();
                    static /*0x11539f0*/ int SHUFFLE2(int x, int y);
                    static /*0x6bbd40*/ void stream_si32(int* mem_addr, int a);
                    static /*0x9e29e0*/ void stream_si64(long* mem_addr, long a);
                    static /*0x11571c0*/ void stream_pd(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x11571c0*/ void stream_si128(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x1153ac0*/ Unity.Burst.Intrinsics.v128 add_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153a00*/ Unity.Burst.Intrinsics.v128 add_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153a70*/ Unity.Burst.Intrinsics.v128 add_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153aa0*/ Unity.Burst.Intrinsics.v128 add_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153c30*/ Unity.Burst.Intrinsics.v128 adds_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153bb0*/ Unity.Burst.Intrinsics.v128 adds_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153d30*/ Unity.Burst.Intrinsics.v128 adds_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153cb0*/ Unity.Burst.Intrinsics.v128 adds_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153eb0*/ Unity.Burst.Intrinsics.v128 avg_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153df0*/ Unity.Burst.Intrinsics.v128 avg_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11552a0*/ Unity.Burst.Intrinsics.v128 madd_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155340*/ Unity.Burst.Intrinsics.v128 max_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155400*/ Unity.Burst.Intrinsics.v128 max_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11555c0*/ Unity.Burst.Intrinsics.v128 min_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155680*/ Unity.Burst.Intrinsics.v128 min_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155950*/ Unity.Burst.Intrinsics.v128 mulhi_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155a10*/ Unity.Burst.Intrinsics.v128 mulhi_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155ad0*/ Unity.Burst.Intrinsics.v128 mullo_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11558e0*/ Unity.Burst.Intrinsics.v128 mul_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155d40*/ Unity.Burst.Intrinsics.v128 sad_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11572a0*/ Unity.Burst.Intrinsics.v128 sub_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11571e0*/ Unity.Burst.Intrinsics.v128 sub_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157250*/ Unity.Burst.Intrinsics.v128 sub_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157280*/ Unity.Burst.Intrinsics.v128 sub_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157410*/ Unity.Burst.Intrinsics.v128 subs_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157390*/ Unity.Burst.Intrinsics.v128 subs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157510*/ Unity.Burst.Intrinsics.v128 subs_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157490*/ Unity.Burst.Intrinsics.v128 subs_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1156660*/ Unity.Burst.Intrinsics.v128 slli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1153f80*/ Unity.Burst.Intrinsics.v128 bslli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1154040*/ Unity.Burst.Intrinsics.v128 bsrli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156470*/ Unity.Burst.Intrinsics.v128 slli_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156220*/ Unity.Burst.Intrinsics.v128 sll_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1156500*/ Unity.Burst.Intrinsics.v128 slli_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156310*/ Unity.Burst.Intrinsics.v128 sll_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11565c0*/ Unity.Burst.Intrinsics.v128 slli_epi64(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x11563d0*/ Unity.Burst.Intrinsics.v128 sll_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1156a30*/ Unity.Burst.Intrinsics.v128 srai_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156870*/ Unity.Burst.Intrinsics.v128 sra_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1156b40*/ Unity.Burst.Intrinsics.v128 srai_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156980*/ Unity.Burst.Intrinsics.v128 sra_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x11570f0*/ Unity.Burst.Intrinsics.v128 srli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156e70*/ Unity.Burst.Intrinsics.v128 srli_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156bf0*/ Unity.Burst.Intrinsics.v128 srl_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1156f90*/ Unity.Burst.Intrinsics.v128 srli_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156d10*/ Unity.Burst.Intrinsics.v128 srl_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1157040*/ Unity.Burst.Intrinsics.v128 srli_epi64(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156dc0*/ Unity.Burst.Intrinsics.v128 srl_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x1153db0*/ Unity.Burst.Intrinsics.v128 and_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153dd0*/ Unity.Burst.Intrinsics.v128 andnot_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155b70*/ Unity.Burst.Intrinsics.v128 or_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157790*/ Unity.Burst.Intrinsics.v128 xor_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154250*/ Unity.Burst.Intrinsics.v128 cmpeq_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154120*/ Unity.Burst.Intrinsics.v128 cmpeq_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11541e0*/ Unity.Burst.Intrinsics.v128 cmpeq_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11544d0*/ Unity.Burst.Intrinsics.v128 cmpgt_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11543a0*/ Unity.Burst.Intrinsics.v128 cmpgt_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154460*/ Unity.Burst.Intrinsics.v128 cmpgt_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11547b0*/ Unity.Burst.Intrinsics.v128 cmplt_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154600*/ Unity.Burst.Intrinsics.v128 cmplt_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154720*/ Unity.Burst.Intrinsics.v128 cmplt_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d90*/ Unity.Burst.Intrinsics.v128 cvtepi32_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155090*/ Unity.Burst.Intrinsics.v128 cvtsi32_sd(Unity.Burst.Intrinsics.v128 a, int b);
                    static /*0x11550c0*/ Unity.Burst.Intrinsics.v128 cvtsi64_sd(Unity.Burst.Intrinsics.v128 a, long b);
                    static /*0x11550f0*/ Unity.Burst.Intrinsics.v128 cvtsi64x_sd(Unity.Burst.Intrinsics.v128 a, long b);
                    static /*0x1154db0*/ Unity.Burst.Intrinsics.v128 cvtepi32_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11550b0*/ Unity.Burst.Intrinsics.v128 cvtsi32_si128(int a);
                    static /*0x11550e0*/ Unity.Burst.Intrinsics.v128 cvtsi64_si128(long a);
                    static /*0x1155110*/ Unity.Burst.Intrinsics.v128 cvtsi64x_si128(long a);
                    static /*0x6bba50*/ int cvtsi128_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x6937d0*/ long cvtsi128_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x6937d0*/ long cvtsi128_si64x(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155f40*/ Unity.Burst.Intrinsics.v128 set_epi64x(long e1, long e0);
                    static /*0x1155f20*/ Unity.Burst.Intrinsics.v128 set_epi32(int e3, int e2, int e1, int e0);
                    static /*0x1155ee0*/ Unity.Burst.Intrinsics.v128 set_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0);
                    static /*0x1155f50*/ Unity.Burst.Intrinsics.v128 set_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_);
                    static /*0x1155ea0*/ Unity.Burst.Intrinsics.v128 set1_epi64x(long a);
                    static /*0x1155e90*/ Unity.Burst.Intrinsics.v128 set1_epi32(int a);
                    static /*0x1155e60*/ Unity.Burst.Intrinsics.v128 set1_epi16(short a);
                    static /*0x1155eb0*/ Unity.Burst.Intrinsics.v128 set1_epi8(sbyte a);
                    static /*0x1156040*/ Unity.Burst.Intrinsics.v128 setr_epi32(int e3, int e2, int e1, int e0);
                    static /*0x1156000*/ Unity.Burst.Intrinsics.v128 setr_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0);
                    static /*0x1156060*/ Unity.Burst.Intrinsics.v128 setr_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_);
                    static /*0x114e400*/ Unity.Burst.Intrinsics.v128 setzero_si128();
                    static /*0x1151300*/ Unity.Burst.Intrinsics.v128 move_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155b90*/ Unity.Burst.Intrinsics.v128 packs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155c20*/ Unity.Burst.Intrinsics.v128 packs_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155cb0*/ Unity.Burst.Intrinsics.v128 packus_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155210*/ ushort extract_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1155220*/ Unity.Burst.Intrinsics.v128 insert_epi16(Unity.Burst.Intrinsics.v128 a, int i, int imm8);
                    static /*0x1155860*/ int movemask_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11560f0*/ Unity.Burst.Intrinsics.v128 shuffle_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1156170*/ Unity.Burst.Intrinsics.v128 shufflehi_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x11561d0*/ Unity.Burst.Intrinsics.v128 shufflelo_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1157610*/ Unity.Burst.Intrinsics.v128 unpackhi_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157590*/ Unity.Burst.Intrinsics.v128 unpackhi_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151b90*/ Unity.Burst.Intrinsics.v128 unpackhi_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11575f0*/ Unity.Burst.Intrinsics.v128 unpackhi_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157700*/ Unity.Burst.Intrinsics.v128 unpacklo_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157690*/ Unity.Burst.Intrinsics.v128 unpacklo_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1151bb0*/ Unity.Burst.Intrinsics.v128 unpacklo_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11576e0*/ Unity.Burst.Intrinsics.v128 unpacklo_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153b90*/ Unity.Burst.Intrinsics.v128 add_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153b60*/ Unity.Burst.Intrinsics.v128 add_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11551f0*/ Unity.Burst.Intrinsics.v128 div_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11551c0*/ Unity.Burst.Intrinsics.v128 div_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155540*/ Unity.Burst.Intrinsics.v128 max_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11554b0*/ Unity.Burst.Intrinsics.v128 max_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11557c0*/ Unity.Burst.Intrinsics.v128 min_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155730*/ Unity.Burst.Intrinsics.v128 min_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155930*/ Unity.Burst.Intrinsics.v128 mul_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155900*/ Unity.Burst.Intrinsics.v128 mul_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11567e0*/ Unity.Burst.Intrinsics.v128 sqrt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1156730*/ Unity.Burst.Intrinsics.v128 sqrt_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157370*/ Unity.Burst.Intrinsics.v128 sub_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157340*/ Unity.Burst.Intrinsics.v128 sub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153db0*/ Unity.Burst.Intrinsics.v128 and_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1153dd0*/ Unity.Burst.Intrinsics.v128 andnot_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155b70*/ Unity.Burst.Intrinsics.v128 or_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157790*/ Unity.Burst.Intrinsics.v128 xor_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11542e0*/ Unity.Burst.Intrinsics.v128 cmpeq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154850*/ Unity.Burst.Intrinsics.v128 cmplt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11545d0*/ Unity.Burst.Intrinsics.v128 cmple_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154550*/ Unity.Burst.Intrinsics.v128 cmpgt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154360*/ Unity.Burst.Intrinsics.v128 cmpge_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154b90*/ Unity.Burst.Intrinsics.v128 cmpord_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154ca0*/ Unity.Burst.Intrinsics.v128 cmpunord_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11548d0*/ Unity.Burst.Intrinsics.v128 cmpneq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154ac0*/ Unity.Burst.Intrinsics.v128 cmpnlt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154a50*/ Unity.Burst.Intrinsics.v128 cmpnle_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11549d0*/ Unity.Burst.Intrinsics.v128 cmpngt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154950*/ Unity.Burst.Intrinsics.v128 cmpnge_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154290*/ Unity.Burst.Intrinsics.v128 cmpeq_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154810*/ Unity.Burst.Intrinsics.v128 cmplt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154590*/ Unity.Burst.Intrinsics.v128 cmple_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154510*/ Unity.Burst.Intrinsics.v128 cmpgt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154320*/ Unity.Burst.Intrinsics.v128 cmpge_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154af0*/ Unity.Burst.Intrinsics.v128 cmpord_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154c00*/ Unity.Burst.Intrinsics.v128 cmpunord_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154880*/ Unity.Burst.Intrinsics.v128 cmpneq_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154a80*/ Unity.Burst.Intrinsics.v128 cmpnlt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154a10*/ Unity.Burst.Intrinsics.v128 cmpnle_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154990*/ Unity.Burst.Intrinsics.v128 cmpngt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154910*/ Unity.Burst.Intrinsics.v128 cmpnge_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d10*/ int comieq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d60*/ int comilt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d50*/ int comile_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d40*/ int comigt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d30*/ int comige_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d70*/ int comineq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d10*/ int ucomieq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d60*/ int ucomilt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d50*/ int ucomile_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d40*/ int ucomigt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d30*/ int ucomige_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154d70*/ int ucomineq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1154e70*/ Unity.Burst.Intrinsics.v128 cvtpd_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1154f50*/ Unity.Burst.Intrinsics.v128 cvtps_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1154df0*/ Unity.Burst.Intrinsics.v128 cvtpd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1154f70*/ int cvtsd_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1154fc0*/ long cvtsd_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155010*/ long cvtsd_si64x(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155070*/ Unity.Burst.Intrinsics.v128 cvtsd_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0xf48cf0*/ double cvtsd_f64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155130*/ Unity.Burst.Intrinsics.v128 cvtss_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155150*/ Unity.Burst.Intrinsics.v128 cvttpd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11551a0*/ int cvttsd_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11551b0*/ long cvttsd_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11551b0*/ long cvttsd_si64x(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1154ea0*/ Unity.Burst.Intrinsics.v128 cvtps_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155170*/ Unity.Burst.Intrinsics.v128 cvttps_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155ff0*/ Unity.Burst.Intrinsics.v128 set_sd(double a);
                    static /*0x1155ed0*/ Unity.Burst.Intrinsics.v128 set1_pd(double a);
                    static /*0x1155fd0*/ Unity.Burst.Intrinsics.v128 set_pd1(double a);
                    static /*0x1155fe0*/ Unity.Burst.Intrinsics.v128 set_pd(double e1, double e0);
                    static /*0x11560e0*/ Unity.Burst.Intrinsics.v128 setr_pd(double e1, double e0);
                    static /*0x11575f0*/ Unity.Burst.Intrinsics.v128 unpackhi_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11576e0*/ Unity.Burst.Intrinsics.v128 unpacklo_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11558c0*/ int movemask_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1156140*/ Unity.Burst.Intrinsics.v128 shuffle_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1155840*/ Unity.Burst.Intrinsics.v128 move_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1155270*/ Unity.Burst.Intrinsics.v128 loadu_si32(void* mem_addr);
                    static /*0xe25000*/ void storeu_si32(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x1155240*/ Unity.Burst.Intrinsics.v128 load_si128(void* ptr);
                    static /*0x1155240*/ Unity.Burst.Intrinsics.v128 loadu_si128(void* ptr);
                    static /*0x11571c0*/ void store_si128(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0x11571c0*/ void storeu_si128(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0x32d010*/ void clflush(void* ptr);
                }

                class Sse3
                {
                    static /*0x348b00*/ bool get_IsSse3Supported();
                    static /*0x11577e0*/ Unity.Burst.Intrinsics.v128 addsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11577b0*/ Unity.Burst.Intrinsics.v128 addsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157830*/ Unity.Burst.Intrinsics.v128 hadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157860*/ Unity.Burst.Intrinsics.v128 hadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11578b0*/ Unity.Burst.Intrinsics.v128 hsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11578e0*/ Unity.Burst.Intrinsics.v128 hsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157930*/ Unity.Burst.Intrinsics.v128 movedup_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157940*/ Unity.Burst.Intrinsics.v128 movehdup_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157960*/ Unity.Burst.Intrinsics.v128 moveldup_ps(Unity.Burst.Intrinsics.v128 a);
                }

                class Sse4_1
                {
                    static /*0x348b00*/ bool get_IsSse41Supported();
                    static /*0x1155240*/ Unity.Burst.Intrinsics.v128 stream_load_si128(void* mem_addr);
                    static /*0x1157bb0*/ Unity.Burst.Intrinsics.v128 blend_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1157bf0*/ Unity.Burst.Intrinsics.v128 blend_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1157ca0*/ Unity.Burst.Intrinsics.v128 blendv_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x1157ce0*/ Unity.Burst.Intrinsics.v128 blendv_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x1157c50*/ Unity.Burst.Intrinsics.v128 blendv_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x1157b00*/ Unity.Burst.Intrinsics.v128 blend_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x11581d0*/ Unity.Burst.Intrinsics.v128 dp_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1158230*/ Unity.Burst.Intrinsics.v128 dp_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x11582f0*/ int extract_ps(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1158320*/ float extractf_ps(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1158310*/ byte extract_epi8(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x11582f0*/ int extract_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x1158300*/ long extract_epi64(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x11585b0*/ Unity.Burst.Intrinsics.v128 insert_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1158590*/ Unity.Burst.Intrinsics.v128 insert_epi8(Unity.Burst.Intrinsics.v128 a, byte i, int imm8);
                    static /*0x1158550*/ Unity.Burst.Intrinsics.v128 insert_epi32(Unity.Burst.Intrinsics.v128 a, int i, int imm8);
                    static /*0x1158570*/ Unity.Burst.Intrinsics.v128 insert_epi64(Unity.Burst.Intrinsics.v128 a, long i, int imm8);
                    static /*0x11586b0*/ Unity.Burst.Intrinsics.v128 max_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158600*/ Unity.Burst.Intrinsics.v128 max_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158820*/ Unity.Burst.Intrinsics.v128 max_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158760*/ Unity.Burst.Intrinsics.v128 max_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158980*/ Unity.Burst.Intrinsics.v128 min_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11588d0*/ Unity.Burst.Intrinsics.v128 min_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158af0*/ Unity.Burst.Intrinsics.v128 min_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158a30*/ Unity.Burst.Intrinsics.v128 min_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158df0*/ Unity.Burst.Intrinsics.v128 packus_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157f60*/ Unity.Burst.Intrinsics.v128 cmpeq_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158010*/ Unity.Burst.Intrinsics.v128 cvtepi8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158060*/ Unity.Burst.Intrinsics.v128 cvtepi8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158090*/ Unity.Burst.Intrinsics.v128 cvtepi8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157f90*/ Unity.Burst.Intrinsics.v128 cvtepi16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157fc0*/ Unity.Burst.Intrinsics.v128 cvtepi16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157ff0*/ Unity.Burst.Intrinsics.v128 cvtepi32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158130*/ Unity.Burst.Intrinsics.v128 cvtepu8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158180*/ Unity.Burst.Intrinsics.v128 cvtepu8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11581b0*/ Unity.Burst.Intrinsics.v128 cvtepu8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11580c0*/ Unity.Burst.Intrinsics.v128 cvtepu16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x11580f0*/ Unity.Burst.Intrinsics.v128 cvtepu16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158110*/ Unity.Burst.Intrinsics.v128 cvtepu32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158d80*/ Unity.Burst.Intrinsics.v128 mul_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158db0*/ Unity.Burst.Intrinsics.v128 mullo_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11591d0*/ int testz_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1159150*/ int testc_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1159180*/ int testnzc_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x11590c0*/ int test_all_zeros(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x11590f0*/ int test_mix_ones_zeroes(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x1159030*/ int test_all_ones(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157990*/ double RoundDImpl(double d, int roundingMode);
                    static /*0x1158e90*/ Unity.Burst.Intrinsics.v128 round_pd(Unity.Burst.Intrinsics.v128 a, int rounding);
                    static /*0x1158330*/ Unity.Burst.Intrinsics.v128 floor_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157d40*/ Unity.Burst.Intrinsics.v128 ceil_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158ef0*/ Unity.Burst.Intrinsics.v128 round_ps(Unity.Burst.Intrinsics.v128 a, int rounding);
                    static /*0x1158390*/ Unity.Burst.Intrinsics.v128 floor_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1157da0*/ Unity.Burst.Intrinsics.v128 ceil_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158fa0*/ Unity.Burst.Intrinsics.v128 round_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int rounding);
                    static /*0x1158480*/ Unity.Burst.Intrinsics.v128 floor_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157e90*/ Unity.Burst.Intrinsics.v128 ceil_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158ff0*/ Unity.Burst.Intrinsics.v128 round_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int rounding);
                    static /*0x11584c0*/ Unity.Burst.Intrinsics.v128 floor_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1157ed0*/ Unity.Burst.Intrinsics.v128 ceil_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x1158ba0*/ Unity.Burst.Intrinsics.v128 minpos_epu16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x1158c70*/ Unity.Burst.Intrinsics.v128 mpsadbw_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1157980*/ int MK_INSERTPS_NDX(int srcField, int dstField, int zeroMask);
                }

                class Sse4_2
                {
                    static /*0x0*/ uint[] crctab;

                    static /*0x1159240*/ Sse4_2();
                    static /*0x348b00*/ bool get_IsSse42Supported();
                    static /*0x2a5510*/ Unity.Burst.Intrinsics.v128 cmpistrm_emulation<T>(T* a, T* b, int len, int imm8, int allOnes, T allOnesT);
                    static /*0x2a5510*/ Unity.Burst.Intrinsics.v128 cmpestrm_emulation<T>(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT);
                    static /*0x2a5510*/ Unity.Burst.Intrinsics.v128 ComputeStrmOutput<T>(int len, int imm8, T allOnesT, int intRes2);
                    static /*0x2a5510*/ int cmpistri_emulation<T>(T* a, T* b, int len, int imm8, int allOnes, T allOnesT);
                    static /*0x2a5510*/ int cmpestri_emulation<T>(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT);
                    static /*0x11591f0*/ int ComputeStriOutput(int len, int imm8, int intRes2);
                    static /*0x2a5510*/ int ComputeStringLength<T>(T* ptr, int max);
                    static /*0x2a5510*/ int ComputeStrCmpIntRes2<T>(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes);
                    static /*0x115a250*/ Unity.Burst.Intrinsics.v128 cmpistrm(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x115a090*/ int cmpistri(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x11598a0*/ Unity.Burst.Intrinsics.v128 cmpestrm(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x11596d0*/ int cmpestri(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x115a740*/ int cmpistrz(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1159e40*/ int cmpistrc(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x115a670*/ int cmpistrs(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x115a420*/ int cmpistro(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1159d10*/ int cmpistra(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x1159cb0*/ int cmpestrz(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x1159510*/ int cmpestrc(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x1159c80*/ int cmpestrs(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x1159ac0*/ int cmpestro(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x11592d0*/ int cmpestra(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x1159ce0*/ Unity.Burst.Intrinsics.v128 cmpgt_epi64(Unity.Burst.Intrinsics.v128 val1, Unity.Burst.Intrinsics.v128 val2);
                    static /*0x115a880*/ uint crc32_u32(uint crc, uint v);
                    static /*0x115ab10*/ uint crc32_u8(uint crc, byte v);
                    static /*0x115a810*/ uint crc32_u16(uint crc, ushort v);
                    static /*0x115a920*/ ulong crc32_u64(ulong crc_ul, long v);
                    static /*0x115aa30*/ ulong crc32_u64(ulong crc_ul, ulong v);

                    enum SIDD
                    {
                        UBYTE_OPS = 0,
                        UWORD_OPS = 1,
                        SBYTE_OPS = 2,
                        SWORD_OPS = 3,
                        CMP_EQUAL_ANY = 0,
                        CMP_RANGES = 4,
                        CMP_EQUAL_EACH = 8,
                        CMP_EQUAL_ORDERED = 12,
                        POSITIVE_POLARITY = 0,
                        NEGATIVE_POLARITY = 16,
                        MASKED_POSITIVE_POLARITY = 32,
                        MASKED_NEGATIVE_POLARITY = 48,
                        LEAST_SIGNIFICANT = 0,
                        MOST_SIGNIFICANT = 64,
                        BIT_MASK = 0,
                        UNIT_MASK = 64,
                    }

                    struct StrBoolArray
                    {
                        /*0x10*/ Unity.Burst.Intrinsics.X86.Sse4_2.StrBoolArray.<Bits> Bits;

                        /*0x115b330*/ void SetBit(int aindex, int bindex, bool val);
                        /*0x115b300*/ bool GetBit(int aindex, int bindex);

                        struct <Bits>e__FixedBuffer
                        {
                            /*0x10*/ ushort FixedElementField;
                        }
                    }
                }

                class Ssse3
                {
                    static /*0x348b00*/ bool get_IsSsse3Supported();
                    static /*0x115ace0*/ Unity.Burst.Intrinsics.v128 abs_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x115aba0*/ Unity.Burst.Intrinsics.v128 abs_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x115ac40*/ Unity.Burst.Intrinsics.v128 abs_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x115b1e0*/ Unity.Burst.Intrinsics.v128 shuffle_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115ad80*/ Unity.Burst.Intrinsics.v128 alignr_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int count);
                    static /*0x115ae20*/ Unity.Burst.Intrinsics.v128 hadd_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115aed0*/ Unity.Burst.Intrinsics.v128 hadds_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115aea0*/ Unity.Burst.Intrinsics.v128 hadd_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115af50*/ Unity.Burst.Intrinsics.v128 hsub_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115aff0*/ Unity.Burst.Intrinsics.v128 hsubs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115afc0*/ Unity.Burst.Intrinsics.v128 hsub_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115b070*/ Unity.Burst.Intrinsics.v128 maddubs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115b100*/ Unity.Burst.Intrinsics.v128 mulhrs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115b2b0*/ Unity.Burst.Intrinsics.v128 sign_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115b220*/ Unity.Burst.Intrinsics.v128 sign_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x115b270*/ Unity.Burst.Intrinsics.v128 sign_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                }
            }
        }

        namespace CompilerServices
        {
            class Aliasing
            {
                static /*0x32d010*/ void ExpectAliased(void* a, void* b);
                static /*0x177670*/ void ExpectAliased<A, B>(ref A a, ref B b);
                static /*0x2a5510*/ void ExpectAliased<B>(void* a, ref B b);
                static /*0x2a5510*/ void ExpectAliased<A>(ref A a, void* b);
                static /*0x32d010*/ void ExpectNotAliased(void* a, void* b);
                static /*0x177670*/ void ExpectNotAliased<A, B>(ref A a, ref B b);
                static /*0x2a5510*/ void ExpectNotAliased<B>(void* a, ref B b);
                static /*0x2a5510*/ void ExpectNotAliased<A>(ref A a, void* b);
            }

            class AssumeRangeAttribute : System.Attribute
            {
                /*0x534220*/ AssumeRangeAttribute(long min, long max);
                /*0x534220*/ AssumeRangeAttribute(ulong min, ulong max);
            }

            class Constant
            {
                static /*0x2a5510*/ bool IsConstantExpression<T>(T t);
                static /*0x348b00*/ bool IsConstantExpression(void* t);
            }

            class Hint
            {
                static /*0x621bd0*/ bool Likely(bool condition);
                static /*0x621bd0*/ bool Unlikely(bool condition);
                static /*0x32d010*/ void Assume(bool condition);
            }

            class IgnoreWarningAttribute : System.Attribute
            {
                /*0x534220*/ IgnoreWarningAttribute(int warning);
            }

            class SkipLocalsInitAttribute : System.Attribute
            {
                /*0x534220*/ SkipLocalsInitAttribute();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA;
    static /*0x100*/ <PrivateImplementationDetails> 18DEC2780C55CB9A28CFC322874C570E2EAF1C4618EAB8DFA0FC662098626154;
    static /*0xcfc*/ <PrivateImplementationDetails> 6AC12597E10FFB084DEE014EEBFD52580EB845FD6B5CCA643AEAC527F7B02F2A;
    static /*0x10fc*/ <PrivateImplementationDetails> 80E69247CBC7E738ECDB10A5DCF3EF62BB27B3AB61C6ECF146B2C57CEFFB212F;
    static /*0x14fc*/ <PrivateImplementationDetails> A199F717FBA4D1378A33D65E9660E45ADC176876A3450BACF2A80DA985FBDF14;
    static /*0x16fc*/ <PrivateImplementationDetails> B6EEE9EB277AC8DB2549A0E3B7076938FD9BD5E0DA706181BE7DC82CC7D88B4D;
    static /*0x24f8*/ <PrivateImplementationDetails> C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C;
    static /*0x2518*/ long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010;
    static /*0x2520*/ <PrivateImplementationDetails> D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E;

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=512
    {
    }

    struct __StaticArrayInitTypeSize=1024
    {
    }

    struct __StaticArrayInitTypeSize=3068
    {
    }

    struct __StaticArrayInitTypeSize=3580
    {
    }
}
