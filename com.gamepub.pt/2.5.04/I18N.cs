class <Module>
{
}

class Consts
{
    static string MonoVersion = "2.6.5.0";
    static string MonoCompany = "MONO development team";
    static string MonoProduct = "MONO Common language infrastructure";
    static string MonoCopyright = "(c) various MONO Authors";
    static string FxVersion = "2.0.5.0";
    static string VsVersion = "9.0.0.0";
    static string FxFileVersion = "3.0.40818.0";
    static string VsFileVersion = "9.0.50727.42";
    static string AssemblyI18N = "I18N, Version=2.0.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    static string AssemblyMicrosoft_VisualStudio = "Microsoft.VisualStudio, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblyMicrosoft_VisualStudio_Web = "Microsoft.VisualStudio.Web, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblyMicrosoft_VSDesigner = "Microsoft.VSDesigner, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblyMono_Http = "Mono.Http, Version=2.0.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    static string AssemblyMono_Posix = "Mono.Posix, Version=2.0.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    static string AssemblyMono_Security = "Mono.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    static string AssemblyMono_Messaging_RabbitMQ = "Mono.Messaging.RabbitMQ, Version=2.0.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
    static string AssemblyCorlib = "mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
    static string AssemblySystem = "System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
    static string AssemblySystem_Data = "System.Data, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
    static string AssemblySystem_Design = "System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_DirectoryServices = "System.DirectoryServices, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_Drawing = "System.Drawing, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_Drawing_Design = "System.Drawing.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_Messaging = "System.Messaging, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_Security = "System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_ServiceProcess = "System.ServiceProcess, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_Web = "System.Web, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
    static string AssemblySystem_Windows_Forms = "System.Windows.Forms, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
    static string AssemblySystem_Core = "System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
}

namespace I18N
{
    namespace Common
    {
        class ByteEncoding : I18N.Common.MonoEncoding
        {
            static /*0x0*/ byte[] isNormalized;
            static /*0x8*/ byte[] isNormalizedComputed;
            static /*0x10*/ byte[] normalization_bytes;
            /*0x40*/ char[] toChars;
            /*0x48*/ string encodingName;
            /*0x50*/ string bodyName;
            /*0x58*/ string headerName;
            /*0x60*/ string webName;
            /*0x68*/ bool isBrowserDisplay;
            /*0x69*/ bool isBrowserSave;
            /*0x6a*/ bool isMailNewsDisplay;
            /*0x6b*/ bool isMailNewsSave;
            /*0x6c*/ int windowsCodePage;

            /*0x2acea80*/ ByteEncoding(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage);
            /*0x2aceb9c*/ bool IsAlwaysNormalized(System.Text.NormalizationForm form);
            /*0x2acefc4*/ bool get_IsSingleByte();
            /*0x2acefcc*/ int GetByteCount(string s);
            /*0x2acf02c*/ int GetByteCountImpl(char* chars, int count);
            void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2acf034*/ void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x2acf0a8*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2acf0d8*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2acf4a4*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2acf6e0*/ int GetMaxByteCount(int charCount);
            /*0x2acf758*/ int GetMaxCharCount(int byteCount);
            /*0x2acf7d0*/ string GetString(byte[] bytes, int index, int count);
            /*0x2acf9ac*/ string GetString(byte[] bytes);
            /*0x2acfa1c*/ string get_BodyName();
            /*0x2acfa24*/ string get_EncodingName();
            /*0x2acfa2c*/ string get_HeaderName();
            /*0x2acfa34*/ bool get_IsBrowserDisplay();
            /*0x2acfa3c*/ bool get_IsBrowserSave();
            /*0x2acfa44*/ bool get_IsMailNewsDisplay();
            /*0x2acfa4c*/ bool get_IsMailNewsSave();
            /*0x2acfa54*/ string get_WebName();
            /*0x2acfa5c*/ int get_WindowsCodePage();
        }

        class Handlers
        {
            static /*0x0*/ string[] List;
            static /*0x8*/ System.Collections.Hashtable aliases;

            static /*0x2acfa6c*/ Handlers();
            static /*0x2ad2674*/ string GetAlias(string name);
            static /*0x2ad2760*/ void BuildHash();
            /*0x2acfa64*/ Handlers();
        }

        class Manager
        {
            static string hex = "0123456789abcdef";
            static /*0x0*/ I18N.Common.Manager manager;
            static /*0x8*/ object lockobj;
            /*0x10*/ System.Collections.Hashtable handlers;
            /*0x18*/ System.Collections.Hashtable active;
            /*0x20*/ System.Collections.Hashtable assemblies;

            static /*0x2ad3ee4*/ Manager();
            static /*0x2ad3f58*/ I18N.Common.Manager get_PrimaryManager();
            static /*0x2ad4098*/ string Normalize(string name);
            /*0x2ad3ba8*/ Manager();
            /*0x2ad4124*/ System.Text.Encoding GetEncoding(int codePage);
            /*0x2ad4644*/ System.Text.Encoding GetEncoding(string name);
            /*0x2ad48e8*/ System.Globalization.CultureInfo GetCulture(int culture, bool useUserOverride);
            /*0x2ad4ac8*/ System.Globalization.CultureInfo GetCulture(string name, bool useUserOverride);
            /*0x2ad41ec*/ object Instantiate(string name);
            /*0x2ad3c80*/ void LoadClassList();
            /*0x2ad4c28*/ void LoadInternalClasses();
        }

        class MonoEncoding : System.Text.Encoding
        {
            /*0x38*/ int win_code_page;

            /*0x2aceb74*/ MonoEncoding(int codePage);
            /*0x2ad541c*/ MonoEncoding(int codePage, int windowsCodePage);
            /*0x2ad5448*/ int get_WindowsCodePage();
            /*0x2ad51bc*/ void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount);
            /*0x2ad5460*/ int GetByteCount(char[] chars, int index, int count);
            /*0x2ad55b0*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x2ad57d4*/ int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x2ad5a30*/ int GetByteCount(char* chars, int count);
            /*0x2ad5a40*/ int GetBytes(char* chars, int charCount, byte* bytes, int byteCount);
            int GetByteCountImpl(char* chars, int charCount);
            int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class MonoEncoder : System.Text.Encoder
        {
            /*0x20*/ I18N.Common.MonoEncoding encoding;

            /*0x2ad4d7c*/ MonoEncoder(I18N.Common.MonoEncoding encoding);
            /*0x2ad4da8*/ int GetByteCount(char[] chars, int index, int count, bool refresh);
            /*0x2ad4efc*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);
            int GetByteCountImpl(char* chars, int charCount, bool refresh);
            int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);
            /*0x2ad5120*/ int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush);
            /*0x2ad5130*/ void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount);
        }

        class Strings
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, int> <>f__switch$map0;

            static /*0x2acf1f0*/ string GetString(string tag);
            /*0x2ad5a50*/ Strings();
        }
    }
}
