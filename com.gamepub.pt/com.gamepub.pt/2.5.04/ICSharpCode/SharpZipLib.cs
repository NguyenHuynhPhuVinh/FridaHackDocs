class <Module>
{
}

namespace ICSharpCode
{
    namespace SharpZipLib
    {
        class SharpZipBaseException : System.ApplicationException
        {
            /*0x2a83754*/ SharpZipBaseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x2a80f08*/ SharpZipBaseException();
            /*0x2a7f264*/ SharpZipBaseException(string message);
        }

        namespace Checksums
        {
            class Adler32
            {
                /*0x10*/ uint checksum;

                /*0x2a7e48c*/ Adler32();
                /*0x2a7e484*/ long get_Value();
                /*0x2a7e4b8*/ void Reset();
                /*0x2a7e4c4*/ void Update(byte[] buffer, int offset, int count);
            }

            class Crc32
            {
                static /*0x0*/ uint[] CrcTable;
                /*0x10*/ uint crc;

                static /*0x2a7e94c*/ Crc32();
                static /*0x2a7e6b0*/ uint ComputeCrc32(uint oldCrc, byte value);
                /*0x2a7e944*/ Crc32();
                /*0x2a7e758*/ long get_Value();
                /*0x2a7e760*/ void Reset();
                /*0x2a7e768*/ void Update(byte[] buffer, int offset, int count);
            }
        }

        namespace Encryption
        {
            class PkzipClassic : System.Security.Cryptography.SymmetricAlgorithm
            {
                static /*0x2a82804*/ byte[] GenerateKeys(byte[] seed);
                /*0x2a82ba0*/ PkzipClassic();
            }

            class PkzipClassicCryptoBase
            {
                /*0x10*/ uint[] keys;

                /*0x2a82f40*/ PkzipClassicCryptoBase();
                /*0x2a82ba8*/ byte TransformByte();
                /*0x2a82bf8*/ void SetKeys(byte[] keyData);
                /*0x2a82db8*/ void UpdateKeys(byte ch);
                /*0x2a82edc*/ void Reset();
            }

            class PkzipClassicEncryptCryptoTransform : ICSharpCode.SharpZipLib.Encryption.PkzipClassicCryptoBase, System.Security.Cryptography.ICryptoTransform, System.IDisposable
            {
                /*0x2a830fc*/ PkzipClassicEncryptCryptoTransform(byte[] keyBlock);
                /*0x2a8312c*/ byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
                /*0x2a831bc*/ int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
                /*0x2a83298*/ int get_InputBlockSize();
                /*0x2a832a0*/ int get_OutputBlockSize();
                /*0x2a832a8*/ bool get_CanTransformMultipleBlocks();
                /*0x2a832b0*/ void Dispose();
            }

            class PkzipClassicDecryptCryptoTransform : ICSharpCode.SharpZipLib.Encryption.PkzipClassicCryptoBase, System.Security.Cryptography.ICryptoTransform, System.IDisposable
            {
                /*0x2a82f48*/ PkzipClassicDecryptCryptoTransform(byte[] keyBlock);
                /*0x2a82f78*/ byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
                /*0x2a83008*/ int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
                /*0x2a830e0*/ int get_InputBlockSize();
                /*0x2a830e8*/ int get_OutputBlockSize();
                /*0x2a830f0*/ bool get_CanTransformMultipleBlocks();
                /*0x2a830f8*/ void Dispose();
            }

            class PkzipClassicManaged : ICSharpCode.SharpZipLib.Encryption.PkzipClassic
            {
                /*0x48*/ byte[] key_;

                /*0x2a8374c*/ PkzipClassicManaged();
                /*0x2a832b4*/ int get_BlockSize();
                /*0x2a832bc*/ void set_BlockSize(int value);
                /*0x2a8331c*/ System.Security.Cryptography.KeySizes[] get_LegalKeySizes();
                /*0x2a833ec*/ void GenerateIV();
                /*0x2a833f0*/ byte[] get_Key();
                /*0x2a83488*/ void set_Key(byte[] value);
                /*0x2a83598*/ void GenerateKey();
                /*0x2a8362c*/ System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);
                /*0x2a836bc*/ System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);
            }
        }

        namespace Zip
        {
            namespace Compression
            {
                namespace Streams
                {
                    class InflaterInputStream : System.IO.Stream
                    {
                        /*0x28*/ ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf;
                        /*0x30*/ ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer inputBuffer;
                        /*0x38*/ System.IO.Stream baseInputStream;
                        /*0x40*/ long csize;
                        /*0x48*/ bool isClosed;
                        /*0x49*/ bool isStreamOwner;

                        /*0x2a81e94*/ InflaterInputStream(System.IO.Stream baseInputStream, ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf);
                        /*0x2a81e9c*/ InflaterInputStream(System.IO.Stream baseInputStream, ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater, int bufferSize);
                        /*0x2a8200c*/ long Skip(long count);
                        /*0x2a8215c*/ void StopDecrypting();
                        /*0x2a82178*/ void Fill();
                        /*0x2a8220c*/ bool get_CanRead();
                        /*0x2a8222c*/ bool get_CanSeek();
                        /*0x2a82234*/ bool get_CanWrite();
                        /*0x2a8223c*/ long get_Length();
                        /*0x2a82258*/ long get_Position();
                        /*0x2a82278*/ void set_Position(long value);
                        /*0x2a822cc*/ void Flush();
                        /*0x2a822f0*/ long Seek(long offset, System.IO.SeekOrigin origin);
                        /*0x2a82344*/ void Write(byte[] buffer, int offset, int count);
                        /*0x2a82398*/ void WriteByte(byte value);
                        /*0x2a823ec*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                        /*0x2a82440*/ void Close();
                        /*0x2a82480*/ int Read(byte[] buffer, int offset, int count);
                    }

                    class InflaterInputBuffer
                    {
                        /*0x10*/ int rawLength;
                        /*0x18*/ byte[] rawData;
                        /*0x20*/ int clearTextLength;
                        /*0x28*/ byte[] clearText;
                        /*0x30*/ byte[] internalClearText;
                        /*0x38*/ int available;
                        /*0x40*/ System.Security.Cryptography.ICryptoTransform cryptoTransform;
                        /*0x48*/ System.IO.Stream inputStream;

                        /*0x2a816b8*/ InflaterInputBuffer(System.IO.Stream stream, int bufferSize);
                        /*0x2a81738*/ int get_RawLength();
                        /*0x2a81740*/ int get_Available();
                        /*0x2a81748*/ void set_Available(int value);
                        /*0x2a81750*/ void SetInflaterInput(ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater);
                        /*0x2a8179c*/ void Fill();
                        /*0x2a818ec*/ int ReadRawBuffer(byte[] buffer);
                        /*0x2a81908*/ int ReadRawBuffer(byte[] outBuffer, int offset, int length);
                        /*0x2a81a5c*/ int ReadClearTextBuffer(byte[] outBuffer, int offset, int length);
                        /*0x2a81bb0*/ int ReadLeByte();
                        /*0x2a81c74*/ int ReadLeShort();
                        /*0x2a81ca4*/ int ReadLeInt();
                        /*0x2a81cf8*/ long ReadLeLong();
                        /*0x2a81d30*/ void set_CryptoTransform(System.Security.Cryptography.ICryptoTransform value);
                    }

                    class OutputWindow
                    {
                        /*0x10*/ byte[] window;
                        /*0x18*/ int windowEnd;
                        /*0x1c*/ int windowFilled;

                        /*0x2a7efac*/ OutputWindow();
                        /*0x2a7f770*/ void Write(int value);
                        /*0x2a825c8*/ void SlowRepeat(int repStart, int length, int distance);
                        /*0x2a7f96c*/ void Repeat(int length, int distance);
                        /*0x2a800d8*/ int CopyStored(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input, int length);
                        /*0x2a7f760*/ int GetFreeSpace();
                        /*0x2a827fc*/ int GetAvailable();
                        /*0x2a80bdc*/ int CopyOutput(byte[] output, int offset, int len);
                        /*0x2a7f074*/ void Reset();
                    }

                    class StreamManipulator
                    {
                        /*0x10*/ byte[] window_;
                        /*0x18*/ int windowStart_;
                        /*0x1c*/ int windowEnd_;
                        /*0x20*/ uint buffer_;
                        /*0x24*/ int bitsInBuffer_;

                        /*0x2a7efa4*/ StreamManipulator();
                        /*0x2a7f1a0*/ int PeekBits(int bitCount);
                        /*0x2a7f250*/ void DropBits(int bitCount);
                        /*0x2a8375c*/ int get_AvailableBits();
                        /*0x2a80d78*/ int get_AvailableBytes();
                        /*0x2a800b8*/ void SkipToByteBoundary();
                        /*0x2a801e8*/ bool get_IsNeedingInput();
                        /*0x2a82648*/ int CopyBytes(byte[] output, int offset, int length);
                        /*0x2a7f06c*/ void Reset();
                        /*0x2a807f0*/ void SetInput(byte[] buffer, int offset, int count);
                    }
                }

                class DeflaterHuffman
                {
                    static /*0x0*/ int[] BL_ORDER;
                    static /*0x8*/ byte[] bit4Reverse;
                    static /*0x10*/ short[] staticLCodes;
                    static /*0x18*/ byte[] staticLLength;
                    static /*0x20*/ short[] staticDCodes;
                    static /*0x28*/ byte[] staticDLength;

                    static /*0x2a7e9dc*/ DeflaterHuffman();
                    static /*0x2a7edd8*/ short BitReverse(int toReverse);
                }

                class Inflater
                {
                    static /*0x0*/ int[] CPLENS;
                    static /*0x8*/ int[] CPLEXT;
                    static /*0x10*/ int[] CPDIST;
                    static /*0x18*/ int[] CPDEXT;
                    /*0x10*/ int mode;
                    /*0x14*/ int readAdler;
                    /*0x18*/ int neededBits;
                    /*0x1c*/ int repLength;
                    /*0x20*/ int repDist;
                    /*0x24*/ int uncomprLen;
                    /*0x28*/ bool isLastBlock;
                    /*0x30*/ long totalOut;
                    /*0x38*/ long totalIn;
                    /*0x40*/ bool noHeader;
                    /*0x48*/ ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input;
                    /*0x50*/ ICSharpCode.SharpZipLib.Zip.Compression.Streams.OutputWindow outputWindow;
                    /*0x58*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader dynHeader;
                    /*0x60*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree litlenTree;
                    /*0x68*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree distTree;
                    /*0x70*/ ICSharpCode.SharpZipLib.Checksums.Adler32 adler;

                    static /*0x2a80d8c*/ Inflater();
                    /*0x2a7eeb4*/ Inflater(bool noHeader);
                    /*0x2a7f008*/ void Reset();
                    /*0x2a7f07c*/ bool DecodeHeader();
                    /*0x2a7f26c*/ bool DecodeDict();
                    /*0x2a7f2e0*/ bool DecodeHuffman();
                    /*0x2a7fab0*/ bool DecodeChksum();
                    /*0x2a7fcb8*/ bool Decode();
                    /*0x2a807b4*/ void SetInput(byte[] buffer, int index, int count);
                    /*0x2a80990*/ int Inflate(byte[] buffer, int offset, int count);
                    /*0x2a80cd0*/ bool get_IsNeedingInput();
                    /*0x2a80cf4*/ bool get_IsNeedingDictionary();
                    /*0x2a80ba4*/ bool get_IsFinished();
                    /*0x2a80d18*/ long get_TotalOut();
                    /*0x2a80d20*/ long get_TotalIn();
                    /*0x2a80d50*/ int get_RemainingInput();
                }

                class InflaterDynHeader
                {
                    static /*0x0*/ int[] repMin;
                    static /*0x8*/ int[] repBits;
                    static /*0x10*/ int[] BL_ORDER;
                    /*0x10*/ byte[] blLens;
                    /*0x18*/ byte[] litdistLens;
                    /*0x20*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree blTree;
                    /*0x28*/ int mode;
                    /*0x2c*/ int lnum;
                    /*0x30*/ int dnum;
                    /*0x34*/ int blnum;
                    /*0x38*/ int num;
                    /*0x3c*/ int repSymbol;
                    /*0x40*/ byte lastLen;
                    /*0x44*/ int ptr;

                    static /*0x2a80f10*/ InflaterDynHeader();
                    /*0x2a800d0*/ InflaterDynHeader();
                    /*0x2a801f8*/ bool Decode(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input);
                    /*0x2a80660*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree BuildLitLenTree();
                    /*0x2a8070c*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree BuildDistTree();
                }

                class InflaterHuffmanTree
                {
                    static /*0x0*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defLitLenTree;
                    static /*0x8*/ ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defDistTree;
                    /*0x10*/ short[] tree;

                    static /*0x2a81020*/ InflaterHuffmanTree();
                    /*0x2a80ed8*/ InflaterHuffmanTree(byte[] codeLengths);
                    /*0x2a81300*/ void BuildTree(byte[] codeLengths);
                    /*0x2a7f828*/ int GetSymbol(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input);
                }
            }

            enum CompressionMethod
            {
                Stored = 0,
                Deflated = 8,
                Deflate64 = 9,
                BZip2 = 11,
                WinZipAES = 99,
            }

            class ZipConstants
            {
                static /*0x0*/ int defaultCodePage;

                static /*0x2a83aa8*/ ZipConstants();
                static /*0x2a83764*/ int get_DefaultCodePage();
                static /*0x2a837c8*/ string ConvertToString(byte[] data, int count);
                static /*0x2a838d0*/ string ConvertToStringExt(int flags, byte[] data);
                static /*0x2a839b0*/ byte[] ConvertToArray(string str);
            }

            class ZipEntry : System.ICloneable
            {
                /*0x10*/ ICSharpCode.SharpZipLib.Zip.ZipEntry.Known known;
                /*0x14*/ int externalFileAttributes;
                /*0x18*/ ushort versionMadeBy;
                /*0x20*/ string name;
                /*0x28*/ ulong size;
                /*0x30*/ ulong compressedSize;
                /*0x38*/ ushort versionToExtract;
                /*0x3c*/ uint crc;
                /*0x40*/ uint dosTime;
                /*0x44*/ ICSharpCode.SharpZipLib.Zip.CompressionMethod method;
                /*0x48*/ byte[] extra;
                /*0x50*/ int flags;
                /*0x58*/ long zipFileIndex;
                /*0x60*/ long offset;
                /*0x68*/ bool forceZip64_;
                /*0x69*/ byte cryptoCheckValue_;
                /*0x6c*/ int _aesVer;
                /*0x70*/ int _aesEncryptionStrength;

                static /*0x2a842cc*/ bool IsCompressionMethodSupported(ICSharpCode.SharpZipLib.Zip.CompressionMethod method);
                /*0x2a83b2c*/ ZipEntry(string name, int versionRequiredToExtract);
                /*0x2a83b38*/ ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, ICSharpCode.SharpZipLib.Zip.CompressionMethod method);
                /*0x2a83e08*/ bool get_IsCrypted();
                /*0x2a83e14*/ byte get_CryptoCheckValue();
                /*0x2a83e1c*/ void set_CryptoCheckValue(byte value);
                /*0x2a83e24*/ int get_Flags();
                /*0x2a83e2c*/ void set_Flags(int value);
                /*0x2a83e34*/ int get_ExternalFileAttributes();
                /*0x2a83e4c*/ bool HasDosAttributes(int attributes);
                /*0x2a83e80*/ int get_HostSystem();
                /*0x2a83e88*/ int get_Version();
                /*0x2a840b8*/ bool get_CanDecompress();
                /*0x2a8415c*/ bool get_LocalHeaderRequiresZip64();
                /*0x2a83fdc*/ bool get_CentralHeaderRequiresZip64();
                /*0x2a841bc*/ void set_DosTime(long value);
                /*0x2a83cdc*/ void set_DateTime(System.DateTime value);
                /*0x2a841d0*/ string get_Name();
                /*0x2a841d8*/ long get_Size();
                /*0x2a841f0*/ void set_Size(long value);
                /*0x2a84204*/ long get_CompressedSize();
                /*0x2a8421c*/ void set_CompressedSize(long value);
                /*0x2a84230*/ long get_Crc();
                /*0x2a84248*/ void set_Crc(long value);
                /*0x2a8425c*/ ICSharpCode.SharpZipLib.Zip.CompressionMethod get_CompressionMethod();
                /*0x2a84264*/ void set_CompressionMethod(ICSharpCode.SharpZipLib.Zip.CompressionMethod value);
                /*0x2a842dc*/ void set_ExtraData(byte[] value);
                /*0x2a83f40*/ int get_AESKeySize();
                /*0x2a843bc*/ void ProcessExtraData(bool localHeader);
                /*0x2a84af4*/ void ProcessAESExtraData(ICSharpCode.SharpZipLib.Zip.ZipExtraData extraData);
                /*0x2a84018*/ bool get_IsDirectory();
                /*0x2a84148*/ bool IsCompressionMethodSupported();
                /*0x2a84c54*/ object Clone();
                /*0x2a84d38*/ string ToString();

                enum Known
                {
                    None = 0,
                    Size = 1,
                    CompressedSize = 2,
                    Crc = 4,
                    Time = 8,
                    ExternalAttributes = 16,
                }
            }

            class ZipException : ICSharpCode.SharpZipLib.SharpZipBaseException
            {
                /*0x2a84d40*/ ZipException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x2a84d48*/ ZipException();
                /*0x2a81c6c*/ ZipException(string message);
            }

            class ZipExtraData : System.IDisposable
            {
                /*0x10*/ int _index;
                /*0x14*/ int _readValueStart;
                /*0x18*/ int _readValueLength;
                /*0x20*/ System.IO.MemoryStream _newEntry;
                /*0x28*/ byte[] _data;

                /*0x2a84750*/ ZipExtraData(byte[] data);
                /*0x2a84d50*/ int get_ValueLength();
                /*0x2a849f8*/ int get_UnreadCount();
                /*0x2a847c8*/ bool Find(int headerID);
                /*0x2a84874*/ long ReadLong();
                /*0x2a848b8*/ int ReadInt();
                /*0x2a84958*/ int ReadShort();
                /*0x2a84a88*/ int ReadByte();
                /*0x2a849c8*/ void Skip(int amount);
                /*0x2a84e10*/ void ReadCheck(int length);
                /*0x2a84d58*/ int ReadShortInternal();
                /*0x2a84ef4*/ void Dispose();
            }

            class ZipInputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
            {
                /*0x50*/ ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler internalReader;
                /*0x58*/ ICSharpCode.SharpZipLib.Checksums.Crc32 crc;
                /*0x60*/ ICSharpCode.SharpZipLib.Zip.ZipEntry entry;
                /*0x68*/ long size;
                /*0x70*/ int method;
                /*0x74*/ int flags;
                /*0x78*/ string password;

                /*0x2a84f10*/ ZipInputStream(System.IO.Stream baseInputStream);
                /*0x2a85058*/ void set_Password(string value);
                /*0x2a85060*/ bool get_CanDecompressEntry();
                /*0x2a85070*/ ICSharpCode.SharpZipLib.Zip.ZipEntry GetNextEntry();
                /*0x2a85880*/ void ReadDataDescriptor();
                /*0x2a859e4*/ void CompleteCloseEntry(bool testCrc);
                /*0x2a8569c*/ void CloseEntry();
                /*0x2a85ab4*/ long get_Length();
                /*0x2a85b5c*/ int ReadByte();
                /*0x2a85c00*/ int ReadingNotAvailable(byte[] destination, int offset, int count);
                /*0x2a85c54*/ int ReadingNotSupported(byte[] destination, int offset, int count);
                /*0x2a85ca4*/ int InitialRead(byte[] destination, int offset, int count);
                /*0x2a86580*/ int Read(byte[] buffer, int offset, int count);
                /*0x2a86058*/ int BodyRead(byte[] buffer, int offset, int count);
                /*0x2a86a64*/ void Close();

                class ReadDataHandler : System.MulticastDelegate
                {
                    /*0x2a84ff8*/ ReadDataHandler(object object, nint method);
                    /*0x2a866a4*/ int Invoke(byte[] b, int offset, int length);
                    /*0x2a86ae0*/ System.IAsyncResult BeginInvoke(byte[] b, int offset, int length, System.AsyncCallback callback, object object);
                    /*0x2a86b90*/ int EndInvoke(System.IAsyncResult result);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>{8E8FA28D-216A-43EC-8DCB-2258D1F7BF00}
{
    static /*0x0*/ <PrivateImplementationDetails> $$method0x60004f9-1;
    static /*0x400*/ <PrivateImplementationDetails> $$method0x60000dd-1;
    static /*0x40c*/ <PrivateImplementationDetails> $$method0x600029d-1;
    static /*0x458*/ <PrivateImplementationDetails> $$method0x600029d-2;
    static /*0x468*/ <PrivateImplementationDetails> $$method0x60004fd-1;
    static /*0x4dc*/ <PrivateImplementationDetails> $$method0x60004fd-2;
    static /*0x550*/ <PrivateImplementationDetails> $$method0x60004fd-3;
    static /*0x5c8*/ <PrivateImplementationDetails> $$method0x60004fd-4;
    static /*0x640*/ <PrivateImplementationDetails> $$method0x60004fe-1;
    static /*0x64c*/ <PrivateImplementationDetails> $$method0x60004fe-2;
    static /*0x658*/ <PrivateImplementationDetails> $$method0x60004fe-3;

    struct __StaticArrayInitTypeSize=1024
    {
    }

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=76
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=116
    {
    }

    struct __StaticArrayInitTypeSize=120
    {
    }
}
