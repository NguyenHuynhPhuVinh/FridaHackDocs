class <Module>
{
}

namespace Mono
{
    namespace Security
    {
        class ASN1
        {
            /*0x10*/ byte m_nTag;
            /*0x18*/ byte[] m_aValue;
            /*0x20*/ System.Collections.ArrayList elist;

            /*0xe05fd0*/ ASN1(byte tag);
            /*0xe06010*/ ASN1(byte tag, byte[] data);
            /*0xe05e40*/ ASN1(byte[] data);
            /*0xe06060*/ int get_Count();
            /*0x793eb0*/ byte get_Tag();
            /*0xe06160*/ byte[] get_Value();
            /*0xe06200*/ void set_Value(byte[] value);
            /*0xe050f0*/ Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1);
            /*0xe05490*/ byte[] GetBytes();
            /*0xe052b0*/ void Decode(byte[] asn1, ref int anPos, int anLength);
            /*0xe05190*/ void DecodeTLV(byte[] asn1, ref int pos, ref byte tag, ref int length, ref byte[] content);
            /*0xe06090*/ Mono.Security.ASN1 get_Item(int index);
            /*0xe05b20*/ string ToString();
        }

        class ASN1Convert
        {
            static /*0xe04940*/ Mono.Security.ASN1 FromInt32(int value);
            static /*0xe04ca0*/ int ToInt32(Mono.Security.ASN1 asn1);
            static /*0xe04e60*/ string ToOid(Mono.Security.ASN1 asn1);
        }

        class BitConverterLE
        {
            static /*0xe06350*/ byte[] GetUIntBytes(byte* bytes);
            static /*0xe062c0*/ byte[] GetBytes(int value);
        }

        namespace Cryptography
        {
            class CryptoConvert
            {
                static /*0xe063d0*/ string ToHex(byte[] input);
            }
        }
    }
}
