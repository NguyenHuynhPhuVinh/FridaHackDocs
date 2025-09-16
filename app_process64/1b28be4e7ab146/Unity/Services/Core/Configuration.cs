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
                    /*0x7d0de54*/ CloudProjectId();
                    /*0x7d0de04*/ string GetCloudProjectId();
                }

                class ConfigurationCollectionHelper
                {
                    static /*0x7d0de5c*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.Configuration.SerializableProjectConfiguration config);
                    static /*0x7d0e080*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.InitializationOptions options);
                    static /*0x7d0deec*/ void SetOrCreateEntry(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, Unity.Services.Core.Configuration.ConfigurationEntry entry);
                }

                class ConfigurationEntry
                {
                    /*0x10*/ string m_Value;
                    /*0x18*/ bool m_IsReadOnly;

                    static /*0x7d0e470*/ string op_Implicit(Unity.Services.Core.Configuration.ConfigurationEntry entry);
                    static /*0x7d0e404*/ Unity.Services.Core.Configuration.ConfigurationEntry op_Implicit(string value);
                    /*0x7d0e4bc*/ ConfigurationEntry();
                    /*0x7d0e4c4*/ ConfigurationEntry(string value, bool isReadOnly);
                    /*0x7d0e4ac*/ string get_Value();
                    /*0x7d0e4b4*/ bool get_IsReadOnly();
                    /*0x7d0e488*/ bool TrySetValue(string value);
                }

                class ConfigurationUtils
                {
                    static /*0x0*/ Unity.Services.Core.Configuration.IConfigurationLoader <ConfigurationLoader>k__BackingField;

                    static /*0x7d0e558*/ ConfigurationUtils();
                    static /*0x7d0e500*/ Unity.Services.Core.Configuration.IConfigurationLoader get_ConfigurationLoader();
                }

                class ExternalUserId : Unity.Services.Core.Configuration.Internal.IExternalUserId, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x7d0e648*/ ExternalUserId();
                }

                interface IConfigurationLoader
                {
                    /*0x38148bc*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();
                }

                class ProjectConfiguration : Unity.Services.Core.Configuration.Internal.IProjectConfiguration, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues;
                    /*0x18*/ Unity.Services.Core.Internal.Serialization.IJsonSerializer <Serializer>k__BackingField;

                    /*0x7d0e650*/ ProjectConfiguration(System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> configValues, Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer);
                    /*0x7d0e694*/ string GetString(string key, string defaultValue);
                }

                struct SerializableProjectConfiguration
                {
                    /*0x10*/ string[] Keys;
                    /*0x18*/ Unity.Services.Core.Configuration.ConfigurationEntry[] Values;

                    static /*0x7d0e76c*/ Unity.Services.Core.Configuration.SerializableProjectConfiguration get_Empty();
                }

                class StreamingAssetsConfigurationLoader : Unity.Services.Core.Configuration.IConfigurationLoader
                {
                    /*0x10*/ Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer;

                    /*0x7d0e618*/ StreamingAssetsConfigurationLoader(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer);
                    /*0x7d0e888*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();

                    struct <GetConfigAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Configuration.StreamingAssetsConfigurationLoader <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1;

                        /*0x7d0e994*/ void MoveNext();
                        /*0x7d0ed34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class StreamingAssetsUtils
                {
                    static /*0x7d0ec9c*/ System.Threading.Tasks.Task<string> GetFileTextFromStreamingAssetsAsync(string path);
                }
            }
        }
    }
}
