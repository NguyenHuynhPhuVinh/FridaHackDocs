class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0x2b392ac*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0x2b392e8*/ bool IsModified();
            /*0x2b39324*/ void ResetModified();
            /*0x2b39360*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }

        class ConfigurationElement
        {
            /*0x2b391bc*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x2b391f8*/ bool IsModified();
            /*0x2b39234*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0x2b39270*/ void ResetModified();
        }

        class ConfigurationElementCollection : System.Configuration.ConfigurationElement
        {
        }

        enum ConfigurationSaveMode
        {
            Full = 2,
            Minimal = 1,
            Modified = 0,
        }

        class ConfigurationPropertyCollection
        {
        }

        class ConfigurationCollectionAttribute : System.Attribute
        {
            /*0x2b391b8*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0x2b3939c*/ IgnoreSection();
            /*0x2b393d8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x2b39414*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0x2b39450*/ bool IsModified();
            /*0x2b3948c*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0x2b394c8*/ void ResetModified();
            /*0x2b39504*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x2b39540*/ void ThrowNotSupportedException();
    }
}
