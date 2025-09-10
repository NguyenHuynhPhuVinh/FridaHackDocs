class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationElement
        {
            /*0xe81d5c*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0xe81d94*/ bool IsModified();
            /*0xe81dcc*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0xe81e04*/ void ResetModified();
        }

        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0xe81e3c*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0xe81e74*/ bool IsModified();
            /*0xe81eac*/ void ResetModified();
            /*0xe81ee4*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
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
            /*0xe81f1c*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0xe81f20*/ IgnoreSection();
            /*0xe81f58*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0xe81f90*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0xe81fc8*/ bool IsModified();
            /*0xe82000*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0xe82038*/ void ResetModified();
            /*0xe82070*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0xe820a8*/ void ThrowNotSupportedException();
    }
}
