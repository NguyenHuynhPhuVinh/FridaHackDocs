class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace CustomerSupport
            {
                namespace Data
                {
                    class CustomerSupportConfigData : EA.Unity.StarlightWrapper.ConfigData
                    {
                        /*0x18*/ EA.Unity.StarlightWrapper.CustomerSupport.Data.IosNotificationAuthorizationTypes iosNotificationAuthorizationTypes;
                        /*0x20*/ string androidNotificationIcon;
                        /*0x28*/ string androidLargeNotificationIcon;

                        /*0x2bfabcc*/ CustomerSupportConfigData();
                    }

                    enum IosNotificationAuthorizationTypes
                    {
                        Badge = 1,
                        Sound = 2,
                        Alert = 4,
                        CarPlay = 8,
                        CriticalAlert = 16,
                        ProvidesAppNotificationSettings = 32,
                        Provisional = 64,
                    }

                    class HelpshiftMetadata
                    {
                        /*0x10*/ System.Collections.Generic.Dictionary<string, object> <Metadata>k__BackingField;
                        /*0x18*/ System.Collections.Generic.List<object> <Tags>k__BackingField;
                        /*0x20*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> <Fields>k__BackingField;

                        /*0x2bfac0c*/ HelpshiftMetadata(System.Collections.Generic.Dictionary<string, object> metadata, System.Collections.Generic.List<object> tags, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> fields);
                        /*0x2bfabdc*/ System.Collections.Generic.Dictionary<string, object> get_Metadata();
                        /*0x2bfabe4*/ void set_Metadata(System.Collections.Generic.Dictionary<string, object> value);
                        /*0x2bfabec*/ System.Collections.Generic.List<object> get_Tags();
                        /*0x2bfabf4*/ void set_Tags(System.Collections.Generic.List<object> value);
                        /*0x2bfabfc*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> get_Fields();
                        /*0x2bfac04*/ void set_Fields(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> value);
                        /*0x2bfb208*/ string ToString();
                        /*0x2bfb0b0*/ void EnsureValid();
                    }
                }
            }
        }
    }
}
