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
    namespace CJK
    {
        class CP932 : I18N.Common.MonoEncoding
        {
            static int SHIFTJIS_CODE_PAGE = 932;

            /*0x2aaef20*/ CP932();
            /*0x2aaef2c*/ int GetByteCountImpl(char* chars, int count);
            /*0x2aaf104*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2aaf710*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2aaf8d0*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2aafc94*/ int GetMaxByteCount(int charCount);
            /*0x2aafd10*/ int GetMaxCharCount(int byteCount);
            /*0x2aafd8c*/ System.Text.Decoder GetDecoder();
            /*0x2aafe20*/ string get_BodyName();
            /*0x2aafe64*/ string get_EncodingName();
            /*0x2aafea8*/ string get_HeaderName();
            /*0x2aafeec*/ bool get_IsBrowserDisplay();
            /*0x2aafef4*/ bool get_IsBrowserSave();
            /*0x2aafefc*/ bool get_IsMailNewsDisplay();
            /*0x2aaff04*/ bool get_IsMailNewsSave();
            /*0x2aaff0c*/ string get_WebName();
            /*0x2aaff50*/ int get_WindowsCodePage();
        }

        class CP932Decoder : I18N.CJK.DbcsEncoding.DbcsDecoder
        {
            /*0x28*/ I18N.CJK.JISConvert convert;
            /*0x30*/ int last_byte_count;
            /*0x34*/ int last_byte_chars;

            /*0x2aaf7d8*/ CP932Decoder(I18N.CJK.JISConvert convert);
            /*0x2aaff58*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2aaf804*/ int GetCharCount(byte[] bytes, int index, int count, bool refresh);
            /*0x2aaff60*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2aaf9b0*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh);
        }

        class ENCshift_jis : I18N.CJK.CP932
        {
            /*0x2ab195c*/ ENCshift_jis();
        }

        class CP50220 : I18N.CJK.ISO2022JPEncoding
        {
            /*0x2aad6ec*/ CP50220();
            /*0x2aad764*/ string get_EncodingName();
        }

        class CP50221 : I18N.CJK.ISO2022JPEncoding
        {
            /*0x2aad7a8*/ CP50221();
            /*0x2aad7dc*/ string get_EncodingName();
        }

        class CP50222 : I18N.CJK.ISO2022JPEncoding
        {
            /*0x2aad820*/ CP50222();
            /*0x2aad854*/ string get_EncodingName();
        }

        class ISO2022JPEncoding : I18N.Common.MonoEncoding
        {
            /*0x3c*/ bool allow_1byte_kana;
            /*0x3d*/ bool allow_shift_io;

            /*0x2aad71c*/ ISO2022JPEncoding(int codePage, bool allow1ByteKana, bool allowShiftIO);
            /*0x2ab4dc4*/ string get_BodyName();
            /*0x2ab4e08*/ string get_HeaderName();
            /*0x2ab4e4c*/ string get_WebName();
            /*0x2ab4e90*/ int GetMaxByteCount(int charCount);
            /*0x2ab4eac*/ int GetMaxCharCount(int byteCount);
            /*0x2ab4eb4*/ int GetByteCount(char[] chars, int charIndex, int charCount);
            /*0x2ab4f58*/ int GetByteCountImpl(char* chars, int count);
            /*0x2ab4ff4*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2ab50a8*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2ab5144*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        enum ISO2022JPMode
        {
            ASCII = 0,
            JISX0208 = 1,
            JISX0201 = 2,
        }

        class ISO2022JPEncoder : I18N.Common.MonoEncoder
        {
            static /*0x0*/ I18N.CJK.JISConvert convert;
            static /*0x8*/ char[] full_width_map;
            /*0x28*/ bool allow_1byte_kana;
            /*0x29*/ bool allow_shift_io;
            /*0x2c*/ I18N.CJK.ISO2022JPMode m;
            /*0x30*/ bool shifted_in_count;
            /*0x31*/ bool shifted_in_conv;

            static /*0x2ab4470*/ ISO2022JPEncoder();
            /*0x2ab442c*/ ISO2022JPEncoder(I18N.Common.MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO);
            /*0x2ab453c*/ int GetByteCountImpl(char* chars, int charCount, bool flush);
            /*0x2ab487c*/ void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref I18N.CJK.ISO2022JPMode cur, I18N.CJK.ISO2022JPMode next);
            /*0x2ab4948*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush);
            /*0x2ab4db8*/ void Reset();
        }

        class ISO2022JPDecoder : System.Text.Decoder
        {
            static /*0x0*/ I18N.CJK.JISConvert convert;
            /*0x20*/ bool allow_shift_io;
            /*0x24*/ I18N.CJK.ISO2022JPMode m;
            /*0x28*/ bool shifted_in_conv;
            /*0x29*/ bool shifted_in_count;

            static /*0x2ab3dd8*/ ISO2022JPDecoder();
            /*0x2ab3da8*/ ISO2022JPDecoder(bool allow1ByteKana, bool allowShiftIO);
            /*0x2ab3e54*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2ab3fbc*/ int ToChar(int value);
            /*0x2ab40bc*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2ab4420*/ void Reset();
        }

        class ENCiso_2022_jp : I18N.CJK.CP50220
        {
            /*0x2ab192c*/ ENCiso_2022_jp();
        }

        class CP51932 : I18N.Common.MonoEncoding
        {
            static int EUC_JP_CODE_PAGE = 51932;

            /*0x2aad898*/ CP51932();
            /*0x2aad8a8*/ int GetByteCount(char[] chars, int index, int length);
            /*0x2aad94c*/ int GetByteCountImpl(char* chars, int count);
            /*0x2aad9d8*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2aada7c*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2aadb34*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2aadbdc*/ int GetMaxByteCount(int charCount);
            /*0x2aadc58*/ int GetMaxCharCount(int byteCount);
            /*0x2aadcd4*/ System.Text.Encoder GetEncoder();
            /*0x2aadd34*/ System.Text.Decoder GetDecoder();
            /*0x2aadd90*/ string get_BodyName();
            /*0x2aaddd4*/ string get_EncodingName();
            /*0x2aade18*/ string get_HeaderName();
            /*0x2aade5c*/ bool get_IsBrowserDisplay();
            /*0x2aade64*/ bool get_IsBrowserSave();
            /*0x2aade6c*/ bool get_IsMailNewsDisplay();
            /*0x2aade74*/ bool get_IsMailNewsSave();
            /*0x2aade7c*/ string get_WebName();
        }

        class CP51932Encoder : I18N.Common.MonoEncoder
        {
            /*0x2aad944*/ CP51932Encoder(I18N.Common.MonoEncoding encoding);
            /*0x2aae860*/ int GetByteCountImpl(char* chars, int count, bool refresh);
            /*0x2aaea3c*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);
        }

        class CP51932Decoder : I18N.CJK.DbcsEncoding.DbcsDecoder
        {
            /*0x28*/ int last_count;
            /*0x2c*/ int last_bytes;

            /*0x2aadb0c*/ CP51932Decoder();
            /*0x2aadeec*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2aadefc*/ int GetCharCount(byte[] bytes, int index, int count, bool refresh);
            /*0x2aae340*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2aae350*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh);
            /*0x2aae7f0*/ System.Exception Insufficient();
        }

        class ENCeuc_jp : I18N.CJK.CP51932
        {
            /*0x2ab18cc*/ ENCeuc_jp();
        }

        class CP936 : I18N.CJK.DbcsEncoding
        {
            static int GB2312_CODE_PAGE = 936;

            /*0x2aaff68*/ CP936();
            /*0x2aaff84*/ I18N.CJK.DbcsConvert GetConvert();
            /*0x2aaffe8*/ int GetByteCountImpl(char* chars, int count);
            /*0x2ab00bc*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2ab0228*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2ab0284*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2ab02f8*/ System.Text.Decoder GetDecoder();
            /*0x2ab03a0*/ string get_BodyName();
            /*0x2ab03e4*/ string get_EncodingName();
            /*0x2ab0428*/ string get_HeaderName();
            /*0x2ab046c*/ bool get_IsBrowserDisplay();
            /*0x2ab0474*/ bool get_IsBrowserSave();
            /*0x2ab047c*/ bool get_IsMailNewsDisplay();
            /*0x2ab0484*/ bool get_IsMailNewsSave();
            /*0x2ab048c*/ string get_WebName();
        }

        class CP936Decoder : I18N.CJK.DbcsEncoding.DbcsDecoder
        {
            /*0x28*/ int last_byte_count;
            /*0x2c*/ int last_byte_bytes;

            /*0x2ab0374*/ CP936Decoder(I18N.CJK.DbcsConvert convert);
            /*0x2ab04d0*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2ab04d8*/ int GetCharCount(byte[] bytes, int index, int count, bool refresh);
            /*0x2ab05c0*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2ab05c8*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh);
        }

        class ENCgb2312 : I18N.CJK.CP936
        {
            /*0x2ab191c*/ ENCgb2312();
        }

        class CP949 : I18N.CJK.KoreanEncoding
        {
            static int UHC_CODE_PAGE = 949;

            /*0x2ab0778*/ CP949();
            /*0x2ab07ac*/ string get_BodyName();
            /*0x2ab07f0*/ string get_EncodingName();
            /*0x2ab0834*/ string get_HeaderName();
            /*0x2ab0878*/ string get_WebName();
        }

        class CP51949 : I18N.CJK.KoreanEncoding
        {
            static int EUCKR_CODE_PAGE = 51949;

            /*0x2aaed8c*/ CP51949();
            /*0x2aaedf0*/ string get_BodyName();
            /*0x2aaee34*/ string get_EncodingName();
            /*0x2aaee78*/ string get_HeaderName();
            /*0x2aaeebc*/ string get_WebName();
        }

        class KoreanEncoding : I18N.CJK.DbcsEncoding
        {
            /*0x3c*/ bool useUHC;

            /*0x2aaedbc*/ KoreanEncoding(int codepage, bool useUHC);
            /*0x2ab5358*/ I18N.CJK.DbcsConvert GetConvert();
            /*0x2ab53bc*/ int GetByteCountImpl(char* chars, int count);
            /*0x2ab5490*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2ab55f8*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2ab5654*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2ab56c8*/ System.Text.Decoder GetDecoder();

            class KoreanDecoder : I18N.CJK.DbcsEncoding.DbcsDecoder
            {
                /*0x28*/ bool useUHC;
                /*0x2c*/ int last_byte_count;
                /*0x30*/ int last_byte_conv;

                /*0x2ab5754*/ KoreanDecoder(I18N.CJK.DbcsConvert convert, bool useUHC);
                /*0x2ab5af4*/ int GetCharCount(byte[] bytes, int index, int count);
                /*0x2ab5afc*/ int GetCharCount(byte[] bytes, int index, int count, bool refresh);
                /*0x2ab5d28*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
                /*0x2ab5d30*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh);
            }
        }

        class ENCuhc : I18N.CJK.CP949
        {
            /*0x2ab1968*/ ENCuhc();
        }

        class ENCeuc_kr : I18N.CJK.CP51949
        {
            /*0x2ab18dc*/ ENCeuc_kr();
        }

        class CP950 : I18N.CJK.DbcsEncoding
        {
            static int BIG5_CODE_PAGE = 950;

            /*0x2ab08bc*/ CP950();
            /*0x2ab08cc*/ I18N.CJK.DbcsConvert GetConvert();
            /*0x2ab0930*/ int GetByteCountImpl(char* chars, int count);
            /*0x2ab0a04*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2ab0b70*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2ab0be4*/ System.Text.Decoder GetDecoder();
            /*0x2ab0c8c*/ string get_BodyName();
            /*0x2ab0cd0*/ string get_EncodingName();
            /*0x2ab0d14*/ string get_HeaderName();
            /*0x2ab0d58*/ string get_WebName();

            class CP950Decoder : I18N.CJK.DbcsEncoding.DbcsDecoder
            {
                /*0x28*/ int last_byte_count;
                /*0x2c*/ int last_byte_conv;

                /*0x2ab0c60*/ CP950Decoder(I18N.CJK.DbcsConvert convert);
                /*0x2ab5794*/ int GetCharCount(byte[] bytes, int index, int count);
                /*0x2ab579c*/ int GetCharCount(byte[] bytes, int index, int count, bool refresh);
                /*0x2ab58dc*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
                /*0x2ab58e4*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh);
            }
        }

        class ENCbig5 : I18N.CJK.CP950
        {
            /*0x2ab18bc*/ ENCbig5();
        }

        class CodeTable : System.IDisposable
        {
            /*0x10*/ System.IO.Stream stream;

            /*0x2ab0d9c*/ CodeTable(string name);
            /*0x2ab0e80*/ void Dispose();
            /*0x2ab0eb8*/ byte[] GetSection(int num);
        }

        class DbcsEncoding : I18N.Common.MonoEncoding
        {
            /*0x2aaff78*/ DbcsEncoding(int codePage);
            /*0x2ab12dc*/ DbcsEncoding(int codePage, int windowsCodePage);
            I18N.CJK.DbcsConvert GetConvert();
            /*0x2ab12e4*/ int GetByteCount(char[] chars, int index, int count);
            /*0x2ab147c*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x2ab1614*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x2ab17a4*/ int GetMaxByteCount(int charCount);
            /*0x2ab1820*/ int GetMaxCharCount(int byteCount);
            /*0x2ab189c*/ bool get_IsBrowserDisplay();
            /*0x2ab18a4*/ bool get_IsBrowserSave();
            /*0x2ab18ac*/ bool get_IsMailNewsDisplay();
            /*0x2ab18b4*/ bool get_IsMailNewsSave();

            class DbcsDecoder : System.Text.Decoder
            {
                /*0x20*/ I18N.CJK.DbcsConvert convert;

                /*0x2aadec0*/ DbcsDecoder(I18N.CJK.DbcsConvert convert);
                /*0x2aae0e4*/ void CheckRange(byte[] bytes, int index, int count);
                /*0x2aae664*/ void CheckRange(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            }
        }

        class DbcsConvert
        {
            static /*0x0*/ I18N.CJK.DbcsConvert Gb2312;
            static /*0x8*/ I18N.CJK.DbcsConvert Big5;
            static /*0x10*/ I18N.CJK.DbcsConvert KS;
            /*0x10*/ byte[] n2u;
            /*0x18*/ byte[] u2n;

            static /*0x2ab1204*/ DbcsConvert();
            /*0x2ab1088*/ DbcsConvert(string fileName);
        }

        class ENCgb18030 : I18N.CJK.GB18030Encoding
        {
            /*0x2ab190c*/ ENCgb18030();
        }

        class CP54936 : I18N.CJK.GB18030Encoding
        {
            /*0x2aaef00*/ CP54936();
        }

        class GB18030Encoding : I18N.Common.MonoEncoding
        {
            /*0x2aaef10*/ GB18030Encoding();
            /*0x2ab2da4*/ string get_EncodingName();
            /*0x2ab2de8*/ string get_HeaderName();
            /*0x2ab2e2c*/ string get_BodyName();
            /*0x2ab2e70*/ string get_WebName();
            /*0x2ab2eb4*/ bool get_IsMailNewsDisplay();
            /*0x2ab2ebc*/ bool get_IsMailNewsSave();
            /*0x2ab2ec4*/ bool get_IsBrowserDisplay();
            /*0x2ab2ecc*/ bool get_IsBrowserSave();
            /*0x2ab2ed4*/ int GetMaxByteCount(int len);
            /*0x2ab2edc*/ int GetMaxCharCount(int len);
            /*0x2ab2ee4*/ int GetByteCount(char[] chars, int index, int length);
            /*0x2ab2f80*/ int GetByteCountImpl(char* chars, int count);
            /*0x2ab300c*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
            /*0x2ab30b0*/ int GetCharCount(byte[] bytes, int start, int len);
            /*0x2ab313c*/ int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx);
            /*0x2ab31e0*/ System.Text.Encoder GetEncoder();
            /*0x2ab3240*/ System.Text.Decoder GetDecoder();
        }

        class GB18030Decoder : I18N.CJK.DbcsEncoding.DbcsDecoder
        {
            static /*0x0*/ I18N.CJK.DbcsConvert gb2312;

            static /*0x2ab19c4*/ GB18030Decoder();
            /*0x2ab199c*/ GB18030Decoder();
            /*0x2ab1a48*/ int GetCharCount(byte[] bytes, int start, int len);
            /*0x2ab1ff8*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class GB18030Encoder : I18N.Common.MonoEncoder
        {
            static /*0x0*/ I18N.CJK.DbcsConvert gb2312;
            /*0x28*/ char incomplete_byte_count;
            /*0x2a*/ char incomplete_bytes;

            static /*0x2ab23c0*/ GB18030Encoder();
            /*0x2ab23b8*/ GB18030Encoder(I18N.Common.MonoEncoding owner);
            /*0x2ab2444*/ int GetByteCountImpl(char* chars, int count, bool refresh);
            /*0x2ab27f8*/ int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);
        }

        class GB18030Source
        {
            static /*0x0*/ byte* gbx2uni;
            static /*0x8*/ byte* uni2gbx;
            static /*0x10*/ int gbx2uniSize;
            static /*0x14*/ int uni2gbxSize;
            static /*0x18*/ long gbxBase;
            static /*0x20*/ long gbxSuppBase;
            static /*0x28*/ I18N.CJK.GB18030Source.GB18030Map[] ranges;

            static /*0x2ab32a4*/ GB18030Source();
            static /*0x2ab3b2c*/ void Unlinear(byte[] bytes, int start, long gbx);
            static /*0x2ab2cf0*/ void Unlinear(byte* bytes, long gbx);
            static /*0x2ab1be4*/ long FromGBX(byte[] bytes, int start);
            static /*0x2ab2c84*/ long FromUCSSurrogate(int cp);
            static /*0x2ab2638*/ long FromUCS(int cp);
            static /*0x2ab3a84*/ long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp);
            static /*0x2ab3c64*/ int ToUcsRaw(int idx);
            static /*0x2ab3ce4*/ long ToGbxRaw(int idx);
            /*0x2ab329c*/ GB18030Source();

            class GB18030Map
            {
                /*0x10*/ int UStart;
                /*0x14*/ int UEnd;
                /*0x18*/ long GStart;
                /*0x20*/ long GEnd;
                /*0x28*/ bool Dummy;

                /*0x2ab3ad4*/ GB18030Map(int ustart, int uend, long gstart, long gend, bool dummy);
            }
        }

        class JISConvert
        {
            static int JISX0208_To_Unicode = 1;
            static int JISX0212_To_Unicode = 2;
            static int CJK_To_JIS = 3;
            static int Greek_To_JIS = 4;
            static int Extra_To_JIS = 5;
            static /*0x0*/ I18N.CJK.JISConvert convert;
            static /*0x8*/ object lockobj;
            /*0x10*/ byte[] jisx0208ToUnicode;
            /*0x18*/ byte[] jisx0212ToUnicode;
            /*0x20*/ byte[] cjkToJis;
            /*0x28*/ byte[] greekToJis;
            /*0x30*/ byte[] extraToJis;

            static /*0x2ab52e4*/ JISConvert();
            static /*0x2aae200*/ I18N.CJK.JISConvert get_Convert();
            /*0x2ab51f8*/ JISConvert();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> $$field-0;

    /*0x2aad6e4*/ <PrivateImplementationDetails>();

    struct $ArrayType$132
    {
    }
}
