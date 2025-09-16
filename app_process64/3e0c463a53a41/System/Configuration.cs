class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationElement
        {
            /*0x73c7438*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x73c7470*/ bool IsModified();
            /*0x73c74a8*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0x73c74e0*/ void ResetModified();
        }

        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0x73c7518*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0x73c7550*/ bool IsModified();
            /*0x73c7588*/ void ResetModified();
            /*0x73c75c0*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
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
            /*0x73c75f8*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0x73c75fc*/ IgnoreSection();
            /*0x73c7634*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x73c766c*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0x73c76a4*/ bool IsModified();
            /*0x73c76dc*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0x73c7714*/ void ResetModified();
            /*0x73c774c*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x73c7784*/ void ThrowNotSupportedException();
    }
}
