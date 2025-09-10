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
                    /*0x16686e0*/ CloudProjectId();
                    /*0x16686d8*/ string GetCloudProjectId();
                }

                class ConfigurationCollectionHelper
                {
                    static /*0x16686e8*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.Configuration.SerializableProjectConfiguration config);
                    static /*0x1668908*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.InitializationOptions options);
                    static /*0x1668778*/ void SetOrCreateEntry(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, Unity.Services.Core.Configuration.ConfigurationEntry entry);
                }

                class ConfigurationEntry
                {
                    /*0x10*/ string m_Value;
                    /*0x18*/ bool m_IsReadOnly;

                    static /*0x1668cf8*/ string op_Implicit(Unity.Services.Core.Configuration.ConfigurationEntry entry);
                    static /*0x1668c90*/ Unity.Services.Core.Configuration.ConfigurationEntry op_Implicit(string value);
                    /*0x1668d3c*/ ConfigurationEntry();
                    /*0x1668d44*/ ConfigurationEntry(string value, bool isReadOnly);
                    /*0x1668d2c*/ string get_Value();
                    /*0x1668d34*/ bool get_IsReadOnly();
                    /*0x1668d10*/ bool TrySetValue(string value);
                }

                class ConfigurationUtils
                {
                    static /*0x0*/ string <RuntimeConfigFullPath>k__BackingField;
                    static /*0x8*/ Unity.Services.Core.Configuration.IConfigurationLoader <ConfigurationLoader>k__BackingField;

                    static /*0x1668dcc*/ ConfigurationUtils();
                    static /*0x1668d74*/ Unity.Services.Core.Configuration.IConfigurationLoader get_ConfigurationLoader();
                }

                class ExternalUserId : Unity.Services.Core.Configuration.Internal.IExternalUserId, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x1668ff4*/ ExternalUserId();
                    /*0x1668eb8*/ string get_UserId();
                    /*0x1668f1c*/ void add_UserIdChanged(System.Action<string> value);
                    /*0x1668f88*/ void remove_UserIdChanged(System.Action<string> value);
                }

                interface IConfigurationLoader
                {
                    System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();
                }

                class ProjectConfiguration : Unity.Services.Core.Configuration.Internal.IProjectConfiguration, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ string m_JsonCache;
                    /*0x18*/ System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues;

                    /*0x1668ffc*/ ProjectConfiguration(System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> configValues);
                    /*0x1669024*/ bool GetBool(string key, bool defaultValue);
                    /*0x16691a8*/ int GetInt(string key, int defaultValue);
                    /*0x16691e4*/ float GetFloat(string key, float defaultValue);
                    /*0x16690d0*/ string GetString(string key, string defaultValue);
                    /*0x166929c*/ string ToJson();

                    class <>c
                    {
                        static /*0x0*/ Unity.Services.Core.Configuration.ProjectConfiguration.<> <>9;
                        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry>, string> <>9__7_0;
                        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry>, string> <>9__7_1;

                        static /*0x1669460*/ <>c();
                        /*0x16694c4*/ <>c();
                        /*0x16694cc*/ string <ToJson>b__7_0(System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry> pair);
                        /*0x1669508*/ string <ToJson>b__7_1(System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry> pair);
                    }
                }

                struct SerializableProjectConfiguration
                {
                    /*0x10*/ string[] Keys;
                    /*0x18*/ Unity.Services.Core.Configuration.ConfigurationEntry[] Values;

                    static /*0x166954c*/ Unity.Services.Core.Configuration.SerializableProjectConfiguration get_Empty();
                }

                class StreamingAssetsConfigurationLoader : Unity.Services.Core.Configuration.IConfigurationLoader
                {
                    /*0x1668eb0*/ StreamingAssetsConfigurationLoader();
                    /*0x1669628*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();

                    struct <GetConfigAsync>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1;

                        /*0x1669714*/ void MoveNext();
                        /*0x16699c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class StreamingAssetsUtils
                {
                    static /*0x166994c*/ System.Threading.Tasks.Task<string> GetFileTextFromStreamingAssetsAsync(string path);
                }
            }
        }
    }
}
