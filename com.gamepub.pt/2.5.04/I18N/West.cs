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
    namespace West
    {
        class CP10000 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2af97a0*/ CP10000();
            /*0x2af96d0*/ CP10000();
            /*0x2af9830*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCmacintosh : I18N.West.CP10000
        {
            /*0x2b0ed88*/ ENCmacintosh();
        }

        class CP10079 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afa030*/ CP10079();
            /*0x2af9f60*/ CP10079();
            /*0x2afa0c0*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCx_mac_icelandic : I18N.West.CP10079
        {
            /*0x2b0ef18*/ ENCx_mac_icelandic();
        }

        class CP1250 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afa854*/ CP1250();
            /*0x2afa76c*/ CP1250();
            /*0x2afa8e4*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCwindows_1250 : I18N.West.CP1250
        {
            /*0x2b0edec*/ ENCwindows_1250();
        }

        class CP1252 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afadf8*/ CP1252();
            /*0x2afad10*/ CP1252();
            /*0x2afae88*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCwindows_1252 : I18N.West.CP1252
        {
            /*0x2b0ee50*/ ENCwindows_1252();
        }

        class CP1253 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afb270*/ CP1253();
            /*0x2afb188*/ CP1253();
            /*0x2afb300*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCwindows_1253 : I18N.West.CP1253
        {
            /*0x2b0eeb4*/ ENCwindows_1253();
        }

        class CP28592 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afb64c*/ CP28592();
            /*0x2afb578*/ CP28592();
            /*0x2afb6dc*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCiso_8859_2 : I18N.West.CP28592
        {
            /*0x2b0ec5c*/ ENCiso_8859_2();
        }

        class CP28593 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afc008*/ CP28593();
            /*0x2afbf34*/ CP28593();
            /*0x2afc098*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCiso_8859_3 : I18N.West.CP28593
        {
            /*0x2b0ecc0*/ ENCiso_8859_3();
        }

        class CP28597 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afc37c*/ CP28597();
            /*0x2afc2a8*/ CP28597();
            /*0x2afc40c*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCiso_8859_7 : I18N.West.CP28597
        {
            /*0x2b0ed24*/ ENCiso_8859_7();
        }

        class CP28605 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afc6a0*/ CP28605();
            /*0x2afc5cc*/ CP28605();
            /*0x2afc730*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCiso_8859_15 : I18N.West.CP28605
        {
            /*0x2b0ebf8*/ ENCiso_8859_15();
        }

        class CP437 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afc9bc*/ CP437();
            /*0x2afc8ec*/ CP437();
            /*0x2afca4c*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCibm437 : I18N.West.CP437
        {
            /*0x2b0e9b0*/ ENCibm437();
        }

        class CP850 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2afdc28*/ CP850();
            /*0x2afdb58*/ CP850();
            /*0x2afdcb8*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCibm850 : I18N.West.CP850
        {
            /*0x2b0ea14*/ ENCibm850();
        }

        class CP860 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2b0bdd8*/ CP860();
            /*0x2b0bd08*/ CP860();
            /*0x2b0be68*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCibm860 : I18N.West.CP860
        {
            /*0x2b0ea78*/ ENCibm860();
        }

        class CP861 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2b0c8f0*/ CP861();
            /*0x2b0c820*/ CP861();
            /*0x2b0c980*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCibm861 : I18N.West.CP861
        {
            /*0x2b0ead8*/ ENCibm861();
        }

        class CP863 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2b0d420*/ CP863();
            /*0x2b0d350*/ CP863();
            /*0x2b0d4b0*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCibm863 : I18N.West.CP863
        {
            /*0x2b0eb38*/ ENCibm863();
        }

        class CP865 : I18N.Common.ByteEncoding
        {
            static /*0x0*/ char[] ToChars;

            static /*0x2b0df50*/ CP865();
            /*0x2b0de6c*/ CP865();
            /*0x2b0dfe0*/ void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
        }

        class ENCibm865 : I18N.West.CP865
        {
            /*0x2b0eb98*/ ENCibm865();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> $$field-0;
    static /*0x200*/ <PrivateImplementationDetails> $$field-1;
    static /*0x400*/ <PrivateImplementationDetails> $$field-2;
    static /*0x600*/ <PrivateImplementationDetails> $$field-3;
    static /*0x800*/ <PrivateImplementationDetails> $$field-4;
    static /*0xa00*/ <PrivateImplementationDetails> $$field-5;
    static /*0xc00*/ <PrivateImplementationDetails> $$field-6;
    static /*0xe00*/ <PrivateImplementationDetails> $$field-7;
    static /*0x1000*/ <PrivateImplementationDetails> $$field-8;
    static /*0x1200*/ <PrivateImplementationDetails> $$field-9;
    static /*0x1400*/ <PrivateImplementationDetails> $$field-10;
    static /*0x1600*/ <PrivateImplementationDetails> $$field-11;
    static /*0x1800*/ <PrivateImplementationDetails> $$field-12;
    static /*0x1a00*/ <PrivateImplementationDetails> $$field-13;
    static /*0x1c00*/ <PrivateImplementationDetails> $$field-14;

    /*0x2af96c8*/ <PrivateImplementationDetails>();

    struct $ArrayType$512
    {
    }
}
