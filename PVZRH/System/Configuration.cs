class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationElement
        {
            /*0x10011e0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x1001150*/ bool IsModified();
            /*0x10011b0*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0x1001180*/ void ResetModified();
        }

        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0x1001210*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0x1001240*/ bool IsModified();
            /*0x1001270*/ void ResetModified();
            /*0x10012a0*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
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
            /*0x32d010*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0x10013c0*/ IgnoreSection();
            /*0x10013f0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x10012d0*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0x1001300*/ bool IsModified();
            /*0x1001360*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0x1001330*/ void ResetModified();
            /*0x1001390*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x1001420*/ void ThrowNotSupportedException();
    }
}
