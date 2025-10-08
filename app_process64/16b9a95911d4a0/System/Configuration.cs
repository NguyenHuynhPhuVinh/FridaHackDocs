class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationElement
        {
            /*0x36542b8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x36542f0*/ bool IsModified();
            /*0x3654328*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0x3654360*/ void ResetModified();
        }

        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0x3654398*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0x36543d0*/ bool IsModified();
            /*0x3654408*/ void ResetModified();
            /*0x3654440*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
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
            /*0x3654478*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0x365447c*/ IgnoreSection();
            /*0x36544b4*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x36544ec*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0x3654524*/ bool IsModified();
            /*0x365455c*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0x3654594*/ void ResetModified();
            /*0x36545cc*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x3654604*/ void ThrowNotSupportedException();
    }
}
