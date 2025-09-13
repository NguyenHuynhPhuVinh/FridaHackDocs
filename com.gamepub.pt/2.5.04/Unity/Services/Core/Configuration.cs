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
                    /*0x2b13ac4*/ CloudProjectId();
                    /*0x2b13abc*/ string GetCloudProjectId();
                }

                class ConfigurationCollectionHelper
                {
                    static /*0x2b13acc*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.Configuration.SerializableProjectConfiguration config);
                    static /*0x2b13d14*/ void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.InitializationOptions options);
                    static /*0x2b13b68*/ void SetOrCreateEntry(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, Unity.Services.Core.Configuration.ConfigurationEntry entry);
                }

                class ConfigurationEntry
                {
                    /*0x10*/ string m_Value;
                    /*0x18*/ bool m_IsReadOnly;

                    static /*0x2b140ec*/ string op_Implicit(Unity.Services.Core.Configuration.ConfigurationEntry entry);
                    static /*0x2b14088*/ Unity.Services.Core.Configuration.ConfigurationEntry op_Implicit(string value);
                    /*0x2b14130*/ ConfigurationEntry();
                    /*0x2b14138*/ ConfigurationEntry(string value, bool isReadOnly);
                    /*0x2b14120*/ string get_Value();
                    /*0x2b14128*/ bool get_IsReadOnly();
                    /*0x2b14104*/ bool TrySetValue(string value);
                }

                class ConfigurationUtils
                {
                    static /*0x0*/ string <RuntimeConfigFullPath>k__BackingField;
                    static /*0x8*/ Unity.Services.Core.Configuration.IConfigurationLoader <ConfigurationLoader>k__BackingField;

                    static /*0x2b141dc*/ ConfigurationUtils();
                    static /*0x2b14178*/ Unity.Services.Core.Configuration.IConfigurationLoader get_ConfigurationLoader();
                }

                interface IConfigurationLoader
                {
                    System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();
                }

                class ProjectConfiguration : Unity.Services.Core.Configuration.Internal.IProjectConfiguration, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ string m_JsonCache;
                    /*0x18*/ System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues;

                    /*0x2b142c4*/ ProjectConfiguration(System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> configValues);
                    /*0x2b142f0*/ bool GetBool(string key, bool defaultValue);
                    /*0x2b14490*/ int GetInt(string key, int defaultValue);
                    /*0x2b143a8*/ string GetString(string key, string defaultValue);
                    /*0x2b144d0*/ string ToJson();

                    class <>c
                    {
                        static /*0x0*/ Unity.Services.Core.Configuration.ProjectConfiguration.<> <>9;
                        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry>, string> <>9__7_0;
                        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry>, string> <>9__7_1;

                        static /*0x2b149ec*/ <>c();
                        /*0x2b14a4c*/ <>c();
                        /*0x2b14a54*/ string <ToJson>b__7_0(System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry> pair);
                        /*0x2b14a94*/ string <ToJson>b__7_1(System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry> pair);
                    }
                }

                struct SerializableProjectConfiguration
                {
                    /*0x10*/ string[] Keys;
                    /*0x18*/ Unity.Services.Core.Configuration.ConfigurationEntry[] Values;

                    static /*0x2b146d8*/ Unity.Services.Core.Configuration.SerializableProjectConfiguration get_Empty();
                }

                class StreamingAssetsConfigurationLoader : Unity.Services.Core.Configuration.IConfigurationLoader
                {
                    /*0x2b142bc*/ StreamingAssetsConfigurationLoader();
                    /*0x2b14840*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync();

                    struct <GetConfigAsync>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1;

                        /*0xb4a9ec*/ void MoveNext();
                        /*0xb4a9f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class StreamingAssetsUtils
                {
                    static /*0x2b1496c*/ System.Threading.Tasks.Task<string> GetFileTextFromStreamingAssetsAsync(string path);
                }
            }
        }
    }
}
