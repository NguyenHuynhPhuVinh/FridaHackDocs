class <Module>
{
}

namespace EA
{
    namespace Logging
    {
        namespace Support
        {
            class MessageFormatValidator
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex Regex;
                /*0x10*/ System.Collections.Generic.Dictionary<string, string> _cache;

                static /*0x2bbc290*/ MessageFormatValidator();
                static /*0x2bbc110*/ string ConvertMessageFormat(string originalMessageFormat);
                /*0x2bbc208*/ MessageFormatValidator();
                /*0x2bbc03c*/ string Get(string originalMessageFormat);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ int index;

                    /*0x2bbc200*/ <>c__DisplayClass3_0();
                    /*0x2bbc32c*/ string <ConvertMessageFormat>b__0(System.Text.RegularExpressions.Match m);
                }
            }
        }
    }
}
