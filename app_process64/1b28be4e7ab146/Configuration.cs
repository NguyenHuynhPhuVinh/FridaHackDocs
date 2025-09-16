class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3f8641c*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x3f86424*/ NullableAttribute(byte );
                /*0x3f864ac*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3f864dc*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3f86504*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3f865f8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace MessagePack
{
    class GeneratedMessagePackResolver : MessagePack.IFormatterResolver
    {
        static /*0x0*/ MessagePack.IFormatterResolver Instance;

        static /*0x3f86608*/ GeneratedMessagePackResolver();
        /*0x3f86600*/ GeneratedMessagePackResolver();
        /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

        class FormatterCache<T>
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static /*0x383e7a0*/ FormatterCache();
        }

        class GeneratedMessagePackResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, int> closedTypeLookup;

            static /*0x3f86748*/ GeneratedMessagePackResolverGetFormatterHelper();
            static /*0x3f86670*/ object GetFormatter(System.Type t);
        }

        class Assets
        {
            /*0x3f86850*/ Assets();

            class Configuration
            {
                /*0x3f86858*/ Configuration();

                class RuntimeConfigurationFormatter : MessagePack.Formatters.IMessagePackFormatter<Assets.Configuration.RuntimeConfiguration>, MessagePack.Formatters.IMessagePackFormatter
                {
                    /*0x3f86740*/ RuntimeConfigurationFormatter();
                    /*0x3f86860*/ void Serialize(ref MessagePack.MessagePackWriter writer, Assets.Configuration.RuntimeConfiguration value, MessagePack.MessagePackSerializerOptions options);
                    /*0x3f868b0*/ Assets.Configuration.RuntimeConfiguration Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
                }
            }
        }
    }
}

namespace Assets
{
    namespace Configuration
    {
        interface IApplicationConfiguration
        {
            /*0x38148bc*/ string get_DisplayVersion();
            /*0x3816710*/ void set_DisplayVersion(string value);
            /*0x3814574*/ int get_VersionCode();
            /*0x3815ed0*/ void set_VersionCode(int value);
            /*0x3814574*/ Assets.Configuration.GamePlatforms get_GamePlatform();
            /*0x3814574*/ Assets.Configuration.GameEnvironment get_GameEnvironment();
            /*0x3814574*/ Assets.Configuration.GameDevices get_GameDevice();
            /*0x3814574*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x3815ed0*/ void set_GameRating(Assets.Configuration.GameRatings value);
            /*0x38148bc*/ string get_ServerEnvironmentUrl();
            /*0x3814574*/ int get_InstanceLifetime();
            /*0x3815ed0*/ void set_InstanceLifetime(int value);
            /*0x3814574*/ int get_InstanceQuantityAllowance();
            /*0x3815ed0*/ void set_InstanceQuantityAllowance(int value);
            /*0x38148bc*/ string get_DmmWebGLXIAPToken();
            /*0x38148bc*/ string get_DmmWebGLIAPToken();
            /*0x3814574*/ int get_DmmAndroidXApplicationId();
            /*0x3814574*/ int get_DmmAndroidApplicationId();
            /*0x38148bc*/ string get_DmmAndroidXConsumerKey();
            /*0x38148bc*/ string get_DmmAndroidXConsumerSecret();
            /*0x38148bc*/ string get_DmmAndroidConsumerKey();
            /*0x38148bc*/ string get_DmmAndroidConsumerSecret();
            /*0x38148bc*/ string get_DmmAndroidXIAPToken();
            /*0x38148bc*/ string get_DmmAndroidIAPToken();
            /*0x38148bc*/ string get_DmmClientXIAPToken();
            /*0x38148bc*/ string get_DmmClientIAPToken();
            /*0x38148bc*/ string get_AppsFlyerAndroidApiKey();
            /*0x38148bc*/ string get_AppsFlyerIOSDevKey();
            /*0x38148bc*/ string get_AppsFlyerIOSAppId();
            /*0x38148bc*/ string get_AzureApplicationInsightsInstrumentationKey();
            /*0x3813ffc*/ bool get_IsSandbox();
            /*0x3813ffc*/ bool get_IsDevelopmentBuild();
            /*0x3813ffc*/ bool get_UseDebugMenu();
            /*0x3814574*/ UnityEngine.LogType get_MinimalLogLevel();
        }

        class ApplicationConfiguration : UnityEngine.ScriptableObject, Assets.Configuration.IApplicationConfiguration
        {
            static /*0x0*/ string ConfigurationResourcePath;
            /*0x18*/ Assets.Configuration.GameRatings <GameRating>k__BackingField;
            /*0x20*/ string <DisplayVersion>k__BackingField;
            /*0x28*/ int <VersionCode>k__BackingField;
            /*0x2c*/ Assets.Configuration.GamePlatforms <GamePlatform>k__BackingField;
            /*0x30*/ Assets.Configuration.GameEnvironment <GameEnvironment>k__BackingField;
            /*0x38*/ string <ServerEnvironmentUrl>k__BackingField;
            /*0x40*/ int <InstanceLifetime>k__BackingField;
            /*0x44*/ int <InstanceQuantityAllowance>k__BackingField;
            /*0x48*/ bool <IsSandbox>k__BackingField;
            /*0x49*/ bool <IsDevelopmentBuild>k__BackingField;
            /*0x4a*/ bool <UseDebugMenu>k__BackingField;
            /*0x50*/ string <DmmNormalApplicationId>k__BackingField;
            /*0x58*/ string <DmmRatedApplicationId>k__BackingField;
            /*0x60*/ string <GooglePlayApplicationId>k__BackingField;
            /*0x68*/ UnityEngine.LogType <MinimalLogLevel>k__BackingField;
            /*0x70*/ string dmmWebglXIAPToken;
            /*0x78*/ string dmmWebglIAPToken;
            /*0x80*/ string dmmAndroidXIAPToken;
            /*0x88*/ string dmmAndroidIAPToken;
            /*0x90*/ string dmmClientXIAPToken;
            /*0x98*/ string dmmClientIAPToken;
            /*0xa0*/ int dmmAndroidXApplicationId;
            /*0xa8*/ string dmmAndroidXConsumerKey;
            /*0xb0*/ string dmmAndroidXConsumerSecret;
            /*0xb8*/ int dmmAndroidApplicationId;
            /*0xc0*/ string dmmAndroidConsumerKey;
            /*0xc8*/ string dmmAndroidConsumerSecret;
            /*0xd0*/ string appsFlyerAndroidDevKey;
            /*0xd8*/ string appsFlyerIOSDevKey;
            /*0xe0*/ string appsFlyerIOSAppId;
            /*0xe8*/ string azureApplicationInsightsInstrumentationKey;
            /*0xf0*/ System.Nullable<Assets.Configuration.GameDevices> gameDevice;

            static /*0x3f86d3c*/ ApplicationConfiguration();
            /*0x3f86d2c*/ ApplicationConfiguration();
            /*0x3f869ec*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x3f869f4*/ void set_GameRating(Assets.Configuration.GameRatings value);
            /*0x3f869fc*/ string get_DisplayVersion();
            /*0x3f86a04*/ void set_DisplayVersion(string value);
            /*0x3f86a0c*/ int get_VersionCode();
            /*0x3f86a14*/ void set_VersionCode(int value);
            /*0x3f86a1c*/ Assets.Configuration.GamePlatforms get_GamePlatform();
            /*0x3f86a24*/ void set_GamePlatform(Assets.Configuration.GamePlatforms value);
            /*0x3f86a2c*/ Assets.Configuration.GameEnvironment get_GameEnvironment();
            /*0x3f86a34*/ void set_GameEnvironment(Assets.Configuration.GameEnvironment value);
            /*0x3f86a3c*/ string get_ServerEnvironmentUrl();
            /*0x3f86a44*/ void set_ServerEnvironmentUrl(string value);
            /*0x3f86a4c*/ int get_InstanceLifetime();
            /*0x3f86a54*/ void set_InstanceLifetime(int value);
            /*0x3f86a5c*/ int get_InstanceQuantityAllowance();
            /*0x3f86a64*/ void set_InstanceQuantityAllowance(int value);
            /*0x3f86a6c*/ bool get_IsSandbox();
            /*0x3f86a74*/ void set_IsSandbox(bool value);
            /*0x3f86a80*/ bool get_IsDevelopmentBuild();
            /*0x3f86a88*/ void set_IsDevelopmentBuild(bool value);
            /*0x3f86a94*/ bool get_UseDebugMenu();
            /*0x3f86a9c*/ void set_UseDebugMenu(bool value);
            /*0x3f86aa8*/ string get_DmmNormalApplicationId();
            /*0x3f86ab0*/ void set_DmmNormalApplicationId(string value);
            /*0x3f86ab8*/ string get_DmmRatedApplicationId();
            /*0x3f86ac0*/ void set_DmmRatedApplicationId(string value);
            /*0x3f86ac8*/ string get_GooglePlayApplicationId();
            /*0x3f86ad0*/ void set_GooglePlayApplicationId(string value);
            /*0x3f86ad8*/ UnityEngine.LogType get_MinimalLogLevel();
            /*0x3f86ae0*/ void set_MinimalLogLevel(UnityEngine.LogType value);
            /*0x3f86ae8*/ string get_DmmWebGLXIAPToken();
            /*0x3f86af0*/ string get_DmmWebGLIAPToken();
            /*0x3f86af8*/ int get_DmmAndroidXApplicationId();
            /*0x3f86b00*/ int get_DmmAndroidApplicationId();
            /*0x3f86b08*/ string get_DmmAndroidXIAPToken();
            /*0x3f86b10*/ string get_DmmAndroidIAPToken();
            /*0x3f86b18*/ string get_DmmClientXIAPToken();
            /*0x3f86b20*/ string get_DmmClientIAPToken();
            /*0x3f86b28*/ string get_DmmAndroidXConsumerKey();
            /*0x3f86b30*/ string get_DmmAndroidXConsumerSecret();
            /*0x3f86b38*/ string get_DmmAndroidConsumerKey();
            /*0x3f86b40*/ string get_DmmAndroidConsumerSecret();
            /*0x3f86b48*/ string get_AppsFlyerAndroidApiKey();
            /*0x3f86b50*/ string get_AppsFlyerIOSDevKey();
            /*0x3f86b58*/ string get_AppsFlyerIOSAppId();
            /*0x3f86b60*/ string get_AzureApplicationInsightsInstrumentationKey();
            /*0x3f86b68*/ void set_AzureApplicationInsightsInstrumentationKey(string value);
            /*0x3f86b6c*/ Assets.Configuration.GameDevices get_GameDevice();
            /*0x3f86c0c*/ Assets.Configuration.GameDevices GetDevice();
        }

        enum GameEnvironment
        {
            Unknown = 0,
            Local = 1,
            Development = 2,
            Development01 = 3,
            Review = 4,
            Staging = 5,
            Production = 6,
            Development02 = 7,
            PreRegistration = 8,
            Development03 = 9,
        }

        enum GamePlatforms
        {
            Unknown = 0,
            Dmm = 1,
            GooglePlay = 2,
            AppStore = 3,
        }

        enum GameDevices
        {
            Unknown = 0,
            Pc = 1,
            Sp = 2,
            Client = 3,
            AppStore = 4,
            GooglePlay = 5,
        }

        enum GameRatings
        {
            Normal = 0,
            Rated = 1,
        }

        class RuntimeConfiguration
        {
            /*0x10*/ bool <IsRated>k__BackingField;

            /*0x3f869e4*/ RuntimeConfiguration();
            /*0x3f86da8*/ bool get_IsRated();
            /*0x3f86db0*/ void set_IsRated(bool value);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 5B11D67CEFA7B1404C1CE5324C4A8DB30542A69078FAE0FC7C398EC7F77DA5EF;
    static /*0x6e*/ <PrivateImplementationDetails> A4FE3A041405194325DD8FE8117CE3923AC868D193E0B7145549971306BD046C;

    struct __StaticArrayInitTypeSize=110
    {
    }

    struct __StaticArrayInitTypeSize=147
    {
    }
}
