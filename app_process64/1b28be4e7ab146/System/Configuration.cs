class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationElement
        {
            /*0x73de868*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x73de8a0*/ bool IsModified();
            /*0x73de8d8*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0x73de910*/ void ResetModified();
        }

        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0x73de948*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0x73de980*/ bool IsModified();
            /*0x73de9b8*/ void ResetModified();
            /*0x73de9f0*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
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

        class ConfigurationElementCollection : System.Configuration.ConfigurationElement
        {
        }

        class ConfigurationCollectionAttribute : System.Attribute
        {
            /*0x73dea28*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0x73dea2c*/ IgnoreSection();
            /*0x73dea64*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x73dea9c*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0x73dead4*/ bool IsModified();
            /*0x73deb0c*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0x73deb44*/ void ResetModified();
            /*0x73deb7c*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x73debb4*/ void ThrowNotSupportedException();
    }
}
