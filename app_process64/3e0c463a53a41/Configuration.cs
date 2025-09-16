class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3f7a748*/ EmbeddedAttribute();
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

                /*0x3f7a750*/ NullableAttribute(byte );
                /*0x3f7a7d8*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3f7a808*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3f7a830*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3f7a924*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        static /*0x3f7a934*/ GeneratedMessagePackResolver();
        /*0x3f7a92c*/ GeneratedMessagePackResolver();
        /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

        class FormatterCache<T>
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static /*0x38358cc*/ FormatterCache();
        }

        class GeneratedMessagePackResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, int> closedTypeLookup;

            static /*0x3f7aa74*/ GeneratedMessagePackResolverGetFormatterHelper();
            static /*0x3f7a99c*/ object GetFormatter(System.Type t);
        }

        class Assets
        {
            /*0x3f7ab7c*/ Assets();

            class Configuration
            {
                /*0x3f7ab84*/ Configuration();

                class RuntimeConfigurationFormatter : MessagePack.Formatters.IMessagePackFormatter<Assets.Configuration.RuntimeConfiguration>, MessagePack.Formatters.IMessagePackFormatter
                {
                    /*0x3f7aa6c*/ RuntimeConfigurationFormatter();
                    /*0x3f7ab8c*/ void Serialize(ref MessagePack.MessagePackWriter writer, Assets.Configuration.RuntimeConfiguration value, MessagePack.MessagePackSerializerOptions options);
                    /*0x3f7abdc*/ Assets.Configuration.RuntimeConfiguration Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
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
            /*0x380b9e8*/ string get_DisplayVersion();
            /*0x380d83c*/ void set_DisplayVersion(string value);
            /*0x380b6a0*/ int get_VersionCode();
            /*0x380cffc*/ void set_VersionCode(int value);
            /*0x380b6a0*/ Assets.Configuration.GamePlatforms get_GamePlatform();
            /*0x380b6a0*/ Assets.Configuration.GameEnvironment get_GameEnvironment();
            /*0x380b6a0*/ Assets.Configuration.GameDevices get_GameDevice();
            /*0x380b6a0*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x380cffc*/ void set_GameRating(Assets.Configuration.GameRatings value);
            /*0x380b9e8*/ string get_ServerEnvironmentUrl();
            /*0x380b6a0*/ int get_InstanceLifetime();
            /*0x380cffc*/ void set_InstanceLifetime(int value);
            /*0x380b6a0*/ int get_InstanceQuantityAllowance();
            /*0x380cffc*/ void set_InstanceQuantityAllowance(int value);
            /*0x380b9e8*/ string get_DmmWebGLXIAPToken();
            /*0x380b9e8*/ string get_DmmWebGLIAPToken();
            /*0x380b6a0*/ int get_DmmAndroidXApplicationId();
            /*0x380b6a0*/ int get_DmmAndroidApplicationId();
            /*0x380b9e8*/ string get_DmmAndroidXConsumerKey();
            /*0x380b9e8*/ string get_DmmAndroidXConsumerSecret();
            /*0x380b9e8*/ string get_DmmAndroidConsumerKey();
            /*0x380b9e8*/ string get_DmmAndroidConsumerSecret();
            /*0x380b9e8*/ string get_DmmAndroidXIAPToken();
            /*0x380b9e8*/ string get_DmmAndroidIAPToken();
            /*0x380b9e8*/ string get_DmmClientXIAPToken();
            /*0x380b9e8*/ string get_DmmClientIAPToken();
            /*0x380b9e8*/ string get_AppsFlyerAndroidApiKey();
            /*0x380b9e8*/ string get_AppsFlyerIOSDevKey();
            /*0x380b9e8*/ string get_AppsFlyerIOSAppId();
            /*0x380b9e8*/ string get_AzureApplicationInsightsInstrumentationKey();
            /*0x380b128*/ bool get_IsSandbox();
            /*0x380b128*/ bool get_IsDevelopmentBuild();
            /*0x380b128*/ bool get_UseDebugMenu();
            /*0x380b6a0*/ UnityEngine.LogType get_MinimalLogLevel();
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

            static /*0x3f7b068*/ ApplicationConfiguration();
            /*0x3f7b058*/ ApplicationConfiguration();
            /*0x3f7ad18*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x3f7ad20*/ void set_GameRating(Assets.Configuration.GameRatings value);
            /*0x3f7ad28*/ string get_DisplayVersion();
            /*0x3f7ad30*/ void set_DisplayVersion(string value);
            /*0x3f7ad38*/ int get_VersionCode();
            /*0x3f7ad40*/ void set_VersionCode(int value);
            /*0x3f7ad48*/ Assets.Configuration.GamePlatforms get_GamePlatform();
            /*0x3f7ad50*/ void set_GamePlatform(Assets.Configuration.GamePlatforms value);
            /*0x3f7ad58*/ Assets.Configuration.GameEnvironment get_GameEnvironment();
            /*0x3f7ad60*/ void set_GameEnvironment(Assets.Configuration.GameEnvironment value);
            /*0x3f7ad68*/ string get_ServerEnvironmentUrl();
            /*0x3f7ad70*/ void set_ServerEnvironmentUrl(string value);
            /*0x3f7ad78*/ int get_InstanceLifetime();
            /*0x3f7ad80*/ void set_InstanceLifetime(int value);
            /*0x3f7ad88*/ int get_InstanceQuantityAllowance();
            /*0x3f7ad90*/ void set_InstanceQuantityAllowance(int value);
            /*0x3f7ad98*/ bool get_IsSandbox();
            /*0x3f7ada0*/ void set_IsSandbox(bool value);
            /*0x3f7adac*/ bool get_IsDevelopmentBuild();
            /*0x3f7adb4*/ void set_IsDevelopmentBuild(bool value);
            /*0x3f7adc0*/ bool get_UseDebugMenu();
            /*0x3f7adc8*/ void set_UseDebugMenu(bool value);
            /*0x3f7add4*/ string get_DmmNormalApplicationId();
            /*0x3f7addc*/ void set_DmmNormalApplicationId(string value);
            /*0x3f7ade4*/ string get_DmmRatedApplicationId();
            /*0x3f7adec*/ void set_DmmRatedApplicationId(string value);
            /*0x3f7adf4*/ string get_GooglePlayApplicationId();
            /*0x3f7adfc*/ void set_GooglePlayApplicationId(string value);
            /*0x3f7ae04*/ UnityEngine.LogType get_MinimalLogLevel();
            /*0x3f7ae0c*/ void set_MinimalLogLevel(UnityEngine.LogType value);
            /*0x3f7ae14*/ string get_DmmWebGLXIAPToken();
            /*0x3f7ae1c*/ string get_DmmWebGLIAPToken();
            /*0x3f7ae24*/ int get_DmmAndroidXApplicationId();
            /*0x3f7ae2c*/ int get_DmmAndroidApplicationId();
            /*0x3f7ae34*/ string get_DmmAndroidXIAPToken();
            /*0x3f7ae3c*/ string get_DmmAndroidIAPToken();
            /*0x3f7ae44*/ string get_DmmClientXIAPToken();
            /*0x3f7ae4c*/ string get_DmmClientIAPToken();
            /*0x3f7ae54*/ string get_DmmAndroidXConsumerKey();
            /*0x3f7ae5c*/ string get_DmmAndroidXConsumerSecret();
            /*0x3f7ae64*/ string get_DmmAndroidConsumerKey();
            /*0x3f7ae6c*/ string get_DmmAndroidConsumerSecret();
            /*0x3f7ae74*/ string get_AppsFlyerAndroidApiKey();
            /*0x3f7ae7c*/ string get_AppsFlyerIOSDevKey();
            /*0x3f7ae84*/ string get_AppsFlyerIOSAppId();
            /*0x3f7ae8c*/ string get_AzureApplicationInsightsInstrumentationKey();
            /*0x3f7ae94*/ void set_AzureApplicationInsightsInstrumentationKey(string value);
            /*0x3f7ae98*/ Assets.Configuration.GameDevices get_GameDevice();
            /*0x3f7af38*/ Assets.Configuration.GameDevices GetDevice();
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

            /*0x3f7ad10*/ RuntimeConfiguration();
            /*0x3f7b0d4*/ bool get_IsRated();
            /*0x3f7b0dc*/ void set_IsRated(bool value);
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
