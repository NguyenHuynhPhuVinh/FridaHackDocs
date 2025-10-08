class <Module>
{
}

namespace EA
{
    namespace Utils
    {
        class NamesAndValues
        {
            /*0x10*/ string[] Names;
            /*0x18*/ int[] Values;

            /*0x2d1d1a4*/ NamesAndValues();
        }

        class EnumUtil
        {
            static /*0x1f327a0*/ int[] GetValues<T>();
        }

        class EnumNameValueCache
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, EA.Utils.NamesAndValues> _enumNameValueSets;

            static /*0x2d1d1ac*/ EnumNameValueCache();
            static /*0x1f327a0*/ EA.Utils.NamesAndValues GetNamesAndValues<T>();
            static /*0x1f327a0*/ int[] GetValues<T>();
        }

        class ListExtensions
        {
            static /*0x1f31840*/ bool IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection);
        }

        class StringExtensions
        {
            static /*0x0*/ string[] NewLineDelimiters;
            static /*0x8*/ System.Text.StringBuilder staticStringBuilder;

            static /*0x2d1d2dc*/ StringExtensions();
            static /*0x2d1d244*/ bool IsNullOrWhiteSpace(string value);
        }
    }
}
