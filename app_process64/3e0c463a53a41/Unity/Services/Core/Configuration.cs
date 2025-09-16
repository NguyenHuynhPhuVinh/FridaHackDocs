class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Configuration
            {
                class CloudProjectId : Unity.Services.Core.Configuration.Internal.ICloudProjectId, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x7cf6a24*/ CloudProjectId();
                    /*0x7cf69d4*/ string GetCloudProjectId();
                }

                class ConfigurationCollectionHelper
                {
                    static /*0x7cf6a2c*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.Configuration.SerializableProjectConfiguration config);
                    static /*0x7cf6c50*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.InitializationOptions options);
                    static /*0x7cf6abc*/ void SetOrCreateEntry(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, Unity.Services.Core.Configuration.ConfigurationEntry entry);
                }

                class ConfigurationEntry
                {
                    /*0x10*/ string m_Value;
                    /*0x18*/ bool m_IsReadOnly;

                    static /*0x7cf7040*/ string op_Implicit(Unity.Services.Core.Configuration.ConfigurationEntry entry);
                    static /*0x7cf6fd4*/ Unity.Services.Core.Configuration.ConfigurationEntry op_Implicit(string value);
                    /*0x7cf708c*/ ConfigurationEntry();
                    /*0x7cf7094*/ ConfigurationEntry(string value, bool isReadOnly);
                    /*0x7cf707c*/ string get_Value();
                    /*0x7cf7084*/ bool get_IsReadOnly();
                    /*0x7cf7058*/ bool TrySetValue(string value);
                }

                class ConfigurationUtils
                {
                    static /*0x0*/ Unity.Services.Core.Configuration.IConfigurationLoader <ConfigurationLoader>k__BackingField;

                    static /*0x7cf7128*/ ConfigurationUtils();
                    static /*0x7cf70d0*/ Unity.Services.Core.Configuration.IConfigurationLoader get_ConfigurationLoader();
                }

                class ExternalUserId : Unity.Services.Core.Configuration.Internal.IExternalUserId, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x7cf7218*/ ExternalUserId();
                }

                interface IConfigurationLoader
                {
                    /*0x380b9e8*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();
                }

                class ProjectConfiguration : Unity.Services.Core.Configuration.Internal.IProjectConfiguration, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues;
                    /*0x18*/ Unity.Services.Core.Internal.Serialization.IJsonSerializer <Serializer>k__BackingField;

                    /*0x7cf7220*/ ProjectConfiguration(System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> configValues, Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer);
                    /*0x7cf7264*/ string GetString(string key, string defaultValue);
                }

                struct SerializableProjectConfiguration
                {
                    /*0x10*/ string[] Keys;
                    /*0x18*/ Unity.Services.Core.Configuration.ConfigurationEntry[] Values;

                    static /*0x7cf733c*/ Unity.Services.Core.Configuration.SerializableProjectConfiguration get_Empty();
                }

                class StreamingAssetsConfigurationLoader : Unity.Services.Core.Configuration.IConfigurationLoader
                {
                    /*0x10*/ Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer;

                    /*0x7cf71e8*/ StreamingAssetsConfigurationLoader(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer);
                    /*0x7cf7458*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();

                    struct <GetConfigAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Configuration.StreamingAssetsConfigurationLoader <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1;

                        /*0x7cf7564*/ void MoveNext();
                        /*0x7cf7904*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class StreamingAssetsUtils
                {
                    static /*0x7cf786c*/ System.Threading.Tasks.Task<string> GetFileTextFromStreamingAssetsAsync(string path);
                }
            }
        }
    }
}
