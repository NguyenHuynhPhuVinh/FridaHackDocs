class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2581360*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x2581f04*/ IsReadOnlyAttribute();
            }

            class IsByRefLikeAttribute : System.Attribute
            {
                /*0x2581efc*/ IsByRefLikeAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x25822f0*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x258237c*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace CsvHelper
{
    class ArrayHelper
    {
        static /*0x25704d8*/ void Trim(char[] buffer, ref int start, ref int length, char[] trimChars);
        static /*0x25705f4*/ bool Contains(char[] array, ref char c);
    }

    class BadDataException : CsvHelper.CsvHelperException
    {
        /*0x257065c*/ BadDataException(CsvHelper.CsvContext context, string message);
    }

    class CsvContext
    {
        /*0x10*/ CsvHelper.TypeConversion.TypeConverterOptionsCache <TypeConverterOptionsCache>k__BackingField;
        /*0x18*/ CsvHelper.TypeConversion.TypeConverterCache <TypeConverterCache>k__BackingField;
        /*0x20*/ CsvHelper.Configuration.ClassMapCollection <Maps>k__BackingField;
        /*0x28*/ CsvHelper.IParser <Parser>k__BackingField;
        /*0x30*/ CsvHelper.IReader <Reader>k__BackingField;
        /*0x38*/ CsvHelper.IWriter <Writer>k__BackingField;
        /*0x40*/ CsvHelper.Configuration.CsvConfiguration <Configuration>k__BackingField;

        /*0x2575e10*/ CsvContext(CsvHelper.IParser parser);
        /*0x2575dd0*/ void set_Maps(CsvHelper.Configuration.ClassMapCollection value);
        /*0x2575dd8*/ CsvHelper.IParser get_Parser();
        /*0x2575de0*/ void set_Parser(CsvHelper.IParser value);
        /*0x2575de8*/ CsvHelper.IReader get_Reader();
        /*0x2575df0*/ void set_Reader(CsvHelper.IReader value);
        /*0x2575df8*/ CsvHelper.IWriter get_Writer();
        /*0x2575e00*/ CsvHelper.Configuration.CsvConfiguration get_Configuration();
        /*0x2575e08*/ void set_Configuration(CsvHelper.Configuration.CsvConfiguration value);
    }

    class CsvHelperException : System.Exception
    {
        /*0x88*/ CsvHelper.CsvContext context;

        static /*0x25760e4*/ string AddDetails(string message, CsvHelper.CsvContext context);
        /*0x2570fbc*/ CsvHelperException();
        /*0x2571020*/ CsvHelperException(string message);
        /*0x2570660*/ CsvHelperException(CsvHelper.CsvContext context, string message);
    }

    enum CsvMode
    {
        RFC4180 = 0,
        Escape = 1,
        NoEscape = 2,
    }

    class CsvParser : CsvHelper.IParser, System.IDisposable
    {
        /*0x10*/ CsvHelper.Configuration.CsvConfiguration configuration;
        /*0x18*/ CsvHelper.FieldCache fieldCache;
        /*0x20*/ System.IO.TextReader reader;
        /*0x28*/ char quote;
        /*0x2a*/ char escape;
        /*0x2c*/ bool countBytes;
        /*0x30*/ System.Text.Encoding encoding;
        /*0x38*/ bool ignoreBlankLines;
        /*0x3a*/ char comment;
        /*0x3c*/ bool allowComments;
        /*0x40*/ CsvHelper.BadDataFound badDataFound;
        /*0x48*/ bool lineBreakInQuotedFieldIsBadData;
        /*0x4c*/ CsvHelper.Configuration.TrimOptions trimOptions;
        /*0x50*/ char[] whiteSpaceChars;
        /*0x58*/ bool leaveOpen;
        /*0x5c*/ CsvHelper.CsvMode mode;
        /*0x60*/ string newLine;
        /*0x68*/ char newLineFirstChar;
        /*0x6a*/ bool isNewLineSet;
        /*0x6b*/ bool cacheFields;
        /*0x70*/ string[] delimiterValues;
        /*0x78*/ bool detectDelimiter;
        /*0x80*/ string delimiter;
        /*0x88*/ char delimiterFirstChar;
        /*0x90*/ char[] buffer;
        /*0x98*/ int bufferSize;
        /*0x9c*/ int charsRead;
        /*0xa0*/ int bufferPosition;
        /*0xa4*/ int rowStartPosition;
        /*0xa8*/ int fieldStartPosition;
        /*0xac*/ int row;
        /*0xb0*/ int rawRow;
        /*0xb8*/ long charCount;
        /*0xc0*/ long byteCount;
        /*0xc8*/ bool inQuotes;
        /*0xc9*/ bool inEscape;
        /*0xd0*/ CsvHelper.CsvParser.Field[] fields;
        /*0xd8*/ int fieldsPosition;
        /*0xdc*/ bool disposed;
        /*0xe0*/ int quoteCount;
        /*0xe8*/ char[] processFieldBuffer;
        /*0xf0*/ int processFieldBufferSize;
        /*0xf4*/ CsvHelper.CsvParser.ParserState state;
        /*0xf8*/ int delimiterPosition;
        /*0xfc*/ int newLinePosition;
        /*0x100*/ bool fieldIsBadData;
        /*0x101*/ bool fieldIsQuoted;
        /*0x102*/ bool isProcessingField;
        /*0x108*/ CsvHelper.CsvContext <Context>k__BackingField;

        /*0x25783f8*/ CsvParser(System.IO.TextReader reader, System.Globalization.CultureInfo culture, bool leaveOpen);
        /*0x2578498*/ CsvParser(System.IO.TextReader reader, CsvHelper.Configuration.CsvConfiguration configuration);
        /*0x2577258*/ long get_CharCount();
        /*0x2577260*/ long get_ByteCount();
        /*0x2577268*/ int get_Row();
        /*0x2577270*/ string[] get_Record();
        /*0x25783b4*/ string get_RawRecord();
        /*0x25783cc*/ int get_Count();
        /*0x25783d4*/ int get_RawRow();
        /*0x25783dc*/ CsvHelper.CsvContext get_Context();
        /*0x25783e4*/ void set_Context(CsvHelper.CsvContext value);
        /*0x25783ec*/ CsvHelper.Configuration.IParserConfiguration get_Configuration();
        /*0x257735c*/ string get_Item(int index);
        /*0x25788a4*/ bool Read();
        /*0x257a428*/ void DetectDelimiter();
        /*0x257a808*/ CsvHelper.CsvParser.ReadLineResult ReadLine(ref char c, ref char cPrev);
        /*0x257bedc*/ CsvHelper.CsvParser.ReadLineResult ReadSpaces(ref char c);
        /*0x257c030*/ CsvHelper.CsvParser.ReadLineResult ReadBlankLine(ref char c);
        /*0x257c314*/ CsvHelper.CsvParser.ReadLineResult ReadDelimiter(ref char c);
        /*0x257c574*/ CsvHelper.CsvParser.ReadLineResult ReadLineEnding(ref char c);
        /*0x257c76c*/ CsvHelper.CsvParser.ReadLineResult ReadNewLine(ref char c);
        /*0x257c9cc*/ bool ReadEndOfFile();
        /*0x257cd74*/ void AddField(ref int start, ref int length);
        /*0x257ce54*/ bool FillBuffer();
        /*0x257cfb0*/ string GetField(ref int index);
        /*0x257e4c4*/ CsvHelper.CsvParser.ProcessedField ProcessRFC4180Field(ref int start, ref int length, ref int quoteCount);
        /*0x257ede4*/ CsvHelper.CsvParser.ProcessedField ProcessRFC4180BadField(ref int start, ref int length);
        /*0x257f0d4*/ CsvHelper.CsvParser.ProcessedField ProcessEscapeField(ref int start, ref int length);
        /*0x257f300*/ CsvHelper.CsvParser.ProcessedField ProcessNoEscapeField(ref int start, ref int length);
        /*0x257f424*/ void Dispose();
        /*0x257f4a0*/ void Dispose(bool disposing);

        struct ProcessedField
        {
            /*0x10*/ int Start;
            /*0x14*/ int Length;
            /*0x18*/ char[] Buffer;

            /*0xaf158c*/ ProcessedField(int start, int length, char[] buffer);
        }

        enum ReadLineResult
        {
            None = 0,
            Complete = 1,
            Incomplete = 2,
        }

        enum ParserState
        {
            None = 0,
            Spaces = 1,
            BlankLine = 2,
            Delimiter = 3,
            LineEnding = 4,
            NewLine = 5,
        }

        struct Field
        {
            /*0x10*/ int Start;
            /*0x14*/ int Length;
            /*0x18*/ int QuoteCount;
            /*0x1c*/ bool IsBad;
        }

        class <>c
        {
            static /*0x0*/ CsvHelper.CsvParser.<> <>9;
            static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, int>, int> <>9__76_0;

            static /*0x25870a4*/ <>c();
            /*0x2587104*/ <>c();
            /*0x258710c*/ int <DetectDelimiter>b__76_0(System.Collections.Generic.KeyValuePair<string, int> c);
        }
    }

    class CsvReader : CsvHelper.IReader, CsvHelper.IReaderRow, System.IDisposable
    {
        /*0x10*/ System.Lazy<CsvHelper.Expressions.RecordManager> recordManager;
        /*0x18*/ bool detectColumnCountChanges;
        /*0x20*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> namedIndexes;
        /*0x28*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<string, int>> namedIndexCache;
        /*0x30*/ System.Collections.Generic.Dictionary<System.Type, CsvHelper.TypeConversion.TypeConverterOptions> typeConverterOptionsCache;
        /*0x38*/ CsvHelper.Configuration.MemberMapData reusableMemberMapData;
        /*0x40*/ bool hasHeaderRecord;
        /*0x48*/ CsvHelper.HeaderValidated headerValidated;
        /*0x50*/ CsvHelper.ShouldSkipRecord shouldSkipRecord;
        /*0x58*/ CsvHelper.ReadingExceptionOccurred readingExceptionOccurred;
        /*0x60*/ System.Globalization.CultureInfo cultureInfo;
        /*0x68*/ bool ignoreBlankLines;
        /*0x70*/ CsvHelper.MissingFieldFound missingFieldFound;
        /*0x78*/ bool includePrivateMembers;
        /*0x80*/ CsvHelper.PrepareHeaderForMatch prepareHeaderForMatch;
        /*0x88*/ CsvHelper.CsvContext context;
        /*0x90*/ bool disposed;
        /*0x98*/ CsvHelper.IParser parser;
        /*0xa0*/ int columnCount;
        /*0xa4*/ int currentIndex;
        /*0xa8*/ bool hasBeenRead;
        /*0xb0*/ string[] headerRecord;
        /*0xb8*/ CsvHelper.Configuration.IReaderConfiguration <Configuration>k__BackingField;

        /*0x257f514*/ CsvReader(System.IO.TextReader reader, System.Globalization.CultureInfo culture, bool leaveOpen);
        /*0x257f598*/ CsvReader(CsvHelper.IParser parser);
        /*0x257f4ec*/ int get_ColumnCount();
        /*0x257f4f4*/ int get_CurrentIndex();
        /*0x257f4fc*/ string[] get_HeaderRecord();
        /*0x257f504*/ CsvHelper.Configuration.IReaderConfiguration get_Configuration();
        /*0x257f50c*/ void set_Configuration(CsvHelper.Configuration.IReaderConfiguration value);
        /*0x257fed0*/ bool ReadHeader();
        /*0x2580000*/ bool Read();
        /*0x2580788*/ string get_Item(int index);
        /*0x25807d0*/ string GetField(int index);
        /*0x2580c7c*/ void Dispose();
        /*0x2580cf8*/ void Dispose(bool disposing);
        /*0x2580dcc*/ void CheckHasBeenRead();
        /*0x2580e30*/ void ParseNamedIndexes();
        /*0x258105c*/ CsvHelper.Expressions.RecordManager <.ctor>b__38_0();
    }

    class BadDataFound : System.MulticastDelegate
    {
        /*0x25706f4*/ BadDataFound(object object, nint method);
        /*0x2570754*/ void Invoke(CsvHelper.BadDataFoundArgs args);
        /*0x2570a58*/ System.IAsyncResult BeginInvoke(CsvHelper.BadDataFoundArgs args, System.AsyncCallback callback, object object);
        /*0x2570ae8*/ void EndInvoke(System.IAsyncResult result);
    }

    struct BadDataFoundArgs
    {
        /*0x10*/ string Field;
        /*0x18*/ string RawRecord;
        /*0x20*/ CsvHelper.CsvContext Context;

        /*0xaf0df4*/ BadDataFoundArgs(string field, string rawRecord, CsvHelper.CsvContext context);
    }

    class GetConstructor : System.MulticastDelegate
    {
        /*0x2572a68*/ GetConstructor(object object, nint method);
        /*0x25815d0*/ System.Reflection.ConstructorInfo Invoke(CsvHelper.GetConstructorArgs args);
        /*0x2581824*/ System.IAsyncResult BeginInvoke(CsvHelper.GetConstructorArgs args, System.AsyncCallback callback, object object);
        /*0x25818ac*/ System.Reflection.ConstructorInfo EndInvoke(System.IAsyncResult result);
    }

    struct GetConstructorArgs
    {
        /*0x10*/ System.Type ClassType;
    }

    class GetDynamicPropertyName : System.MulticastDelegate
    {
        /*0x2572ac8*/ GetDynamicPropertyName(object object, nint method);
        /*0x25818b8*/ string Invoke(CsvHelper.GetDynamicPropertyNameArgs args);
        /*0x2581b24*/ System.IAsyncResult BeginInvoke(CsvHelper.GetDynamicPropertyNameArgs args, System.AsyncCallback callback, object object);
        /*0x2581bac*/ string EndInvoke(System.IAsyncResult result);
    }

    struct GetDynamicPropertyNameArgs
    {
        /*0x10*/ int FieldIndex;
        /*0x18*/ CsvHelper.CsvContext Context;
    }

    class HeaderValidated : System.MulticastDelegate
    {
        /*0x2572b28*/ HeaderValidated(object object, nint method);
        /*0x2581bc0*/ void Invoke(CsvHelper.HeaderValidatedArgs args);
        /*0x2581e24*/ System.IAsyncResult BeginInvoke(CsvHelper.HeaderValidatedArgs args, System.AsyncCallback callback, object object);
        /*0x2581eac*/ void EndInvoke(System.IAsyncResult result);
    }

    struct HeaderValidatedArgs
    {
        /*0x10*/ CsvHelper.InvalidHeader[] InvalidHeaders;
        /*0x18*/ CsvHelper.CsvContext Context;
    }

    class MissingFieldFound : System.MulticastDelegate
    {
        /*0x2572b88*/ MissingFieldFound(object object, nint method);
        /*0x2580978*/ void Invoke(CsvHelper.MissingFieldFoundArgs args);
        /*0x2582254*/ System.IAsyncResult BeginInvoke(CsvHelper.MissingFieldFoundArgs args, System.AsyncCallback callback, object object);
        /*0x25822e4*/ void EndInvoke(System.IAsyncResult result);
    }

    struct MissingFieldFoundArgs
    {
        /*0x10*/ string[] HeaderNames;
        /*0x18*/ int Index;
        /*0x20*/ CsvHelper.CsvContext Context;

        /*0xaf1154*/ MissingFieldFoundArgs(string[] headerNames, int index, CsvHelper.CsvContext context);
    }

    class PrepareHeaderForMatch : System.MulticastDelegate
    {
        /*0x2572be8*/ PrepareHeaderForMatch(object object, nint method);
        /*0x257200c*/ string Invoke(CsvHelper.PrepareHeaderForMatchArgs args);
        /*0x258540c*/ System.IAsyncResult BeginInvoke(CsvHelper.PrepareHeaderForMatchArgs args, System.AsyncCallback callback, object object);
        /*0x2585494*/ string EndInvoke(System.IAsyncResult result);
    }

    struct PrepareHeaderForMatchArgs
    {
        /*0x10*/ string Header;
        /*0x18*/ int FieldIndex;

        /*0xaf1258*/ PrepareHeaderForMatchArgs(string header, int fieldIndex);
    }

    class ReadingExceptionOccurred : System.MulticastDelegate
    {
        /*0x2572c48*/ ReadingExceptionOccurred(object object, nint method);
        /*0x2580530*/ bool Invoke(CsvHelper.ReadingExceptionOccurredArgs args);
        /*0x25854a0*/ System.IAsyncResult BeginInvoke(CsvHelper.ReadingExceptionOccurredArgs args, System.AsyncCallback callback, object object);
        /*0x2585528*/ bool EndInvoke(System.IAsyncResult result);
    }

    struct ReadingExceptionOccurredArgs
    {
        /*0x10*/ CsvHelper.CsvHelperException Exception;

        /*0xaf12a0*/ ReadingExceptionOccurredArgs(CsvHelper.CsvHelperException exception);
    }

    class ReferenceHeaderPrefix : System.MulticastDelegate
    {
        /*0x258555c*/ ReferenceHeaderPrefix(object object, nint method);
        /*0x25855bc*/ string Invoke(CsvHelper.ReferenceHeaderPrefixArgs args);
        /*0x2585828*/ System.IAsyncResult BeginInvoke(CsvHelper.ReferenceHeaderPrefixArgs args, System.AsyncCallback callback, object object);
        /*0x25858b0*/ string EndInvoke(System.IAsyncResult result);
    }

    struct ReferenceHeaderPrefixArgs
    {
        /*0x10*/ System.Type MemberType;
        /*0x18*/ string MemberName;
    }

    class ShouldQuote : System.MulticastDelegate
    {
        /*0x2572ca8*/ ShouldQuote(object object, nint method);
        /*0x2585b54*/ bool Invoke(CsvHelper.ShouldQuoteArgs args);
        /*0x2585e64*/ System.IAsyncResult BeginInvoke(CsvHelper.ShouldQuoteArgs args, System.AsyncCallback callback, object object);
        /*0x2585ef4*/ bool EndInvoke(System.IAsyncResult result);
    }

    struct ShouldQuoteArgs
    {
        /*0x10*/ string Field;
        /*0x18*/ System.Type FieldType;
        /*0x20*/ CsvHelper.IWriterRow Row;
    }

    class ShouldSkipRecord : System.MulticastDelegate
    {
        /*0x2572d08*/ ShouldSkipRecord(object object, nint method);
        /*0x25802d8*/ bool Invoke(CsvHelper.ShouldSkipRecordArgs args);
        /*0x2585f20*/ System.IAsyncResult BeginInvoke(CsvHelper.ShouldSkipRecordArgs args, System.AsyncCallback callback, object object);
        /*0x2585fa8*/ bool EndInvoke(System.IAsyncResult result);
    }

    struct ShouldSkipRecordArgs
    {
        /*0x10*/ string[] Record;

        /*0xaf135c*/ ShouldSkipRecordArgs(string[] record);
    }

    class ShouldUseConstructorParameters : System.MulticastDelegate
    {
        /*0x2572d68*/ ShouldUseConstructorParameters(object object, nint method);
        /*0x2585fdc*/ bool Invoke(CsvHelper.ShouldUseConstructorParametersArgs args);
        /*0x2586234*/ System.IAsyncResult BeginInvoke(CsvHelper.ShouldUseConstructorParametersArgs args, System.AsyncCallback callback, object object);
        /*0x25862bc*/ bool EndInvoke(System.IAsyncResult result);
    }

    struct ShouldUseConstructorParametersArgs
    {
        /*0x10*/ System.Type ParameterType;
    }

    class FieldCache
    {
        /*0x10*/ int maxFieldSize;
        /*0x14*/ int size;
        /*0x18*/ int[] buckets;
        /*0x20*/ CsvHelper.FieldCache.Entry[] entries;
        /*0x28*/ int count;

        /*0x257880c*/ FieldCache(int initialSize, int maxFieldSize);
        /*0x257dfa8*/ string GetField(char[] buffer, int start, int length);
        /*0x2581368*/ uint GetHashCode(char[] buffer, int start, int length);
        /*0x25813d8*/ ref int GetBucket(uint hashCode);
        /*0x258145c*/ void Resize();

        struct Entry
        {
            /*0x10*/ uint HashCode;
            /*0x14*/ int Next;
            /*0x18*/ string Value;
        }
    }

    class HeaderValidationException : CsvHelper.ValidationException
    {
        /*0x90*/ CsvHelper.InvalidHeader[] <InvalidHeaders>k__BackingField;

        /*0x257128c*/ HeaderValidationException(CsvHelper.CsvContext context, CsvHelper.InvalidHeader[] invalidHeaders, string message);
        /*0x2581eb8*/ void set_InvalidHeaders(CsvHelper.InvalidHeader[] value);
    }

    class InvalidHeader
    {
        /*0x10*/ System.Collections.Generic.List<string> <Names>k__BackingField;
        /*0x18*/ int <Index>k__BackingField;

        /*0x2581eec*/ System.Collections.Generic.List<string> get_Names();
        /*0x2581ef4*/ int get_Index();
    }

    interface IObjectResolver
    {
        T Resolve<T>(object[] constructorArgs);
    }

    interface IParser : System.IDisposable
    {
        long get_ByteCount();
        long get_CharCount();
        int get_Count();
        string get_Item(int index);
        string[] get_Record();
        string get_RawRecord();
        int get_Row();
        int get_RawRow();
        CsvHelper.CsvContext get_Context();
        CsvHelper.Configuration.IParserConfiguration get_Configuration();
        bool Read();
    }

    interface IReader : CsvHelper.IReaderRow, System.IDisposable
    {
    }

    interface IReaderRow
    {
        int get_ColumnCount();
        int get_CurrentIndex();
        string[] get_HeaderRecord();
        CsvHelper.Configuration.IReaderConfiguration get_Configuration();
    }

    interface IWriter : CsvHelper.IWriterRow, System.IDisposable
    {
    }

    interface IWriterRow
    {
        string[] get_HeaderRecord();
        int get_Row();
        int get_Index();
        CsvHelper.Configuration.IWriterConfiguration get_Configuration();
    }

    class MissingFieldException : CsvHelper.ReaderException
    {
        /*0x257159c*/ MissingFieldException(CsvHelper.CsvContext context, string message);
    }

    class ObjectCreator
    {
        /*0x10*/ System.Collections.Generic.Dictionary<int, System.Func<System.Object[], object>> cache;

        static /*0x2583b78*/ System.Type[] GetArgTypes(object[] args);
        static /*0x2583cf0*/ int GetConstructorCacheKey(System.Type type, System.Type[] args);
        static /*0x2583de4*/ System.Func<System.Object[], object> CreateInstanceFunc(System.Type type, System.Type[] argTypes);
        static /*0x258474c*/ System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo[] constructors, System.Type type, System.Type[] argTypes);
        static /*0x2584c80*/ System.MissingMethodException GetConstructorNotFoundException(System.Type type, System.Type[] argTypes);
        /*0x2584eb4*/ ObjectCreator();
        /*0x25823a8*/ object CreateInstance(System.Type type, object[] args);
        /*0x2582fb0*/ System.Func<System.Object[], object> GetFunc(System.Type type, object[] args);

        enum MatchType
        {
            None = 0,
            Exact = 1,
            Fuzzy = 2,
        }

        class <>c
        {
            static /*0x0*/ CsvHelper.ObjectCreator.<> <>9;
            static /*0x8*/ System.Func<System.Type, string> <>9__8_0;

            static /*0x258737c*/ <>c();
            /*0x25873dc*/ <>c();
            /*0x25873e4*/ string <GetConstructorNotFoundException>b__8_0(System.Type a);
        }
    }

    class ObjectResolver : CsvHelper.IObjectResolver
    {
        static /*0x0*/ CsvHelper.IObjectResolver current;
        /*0x10*/ CsvHelper.ObjectCreator objectCreator;
        /*0x18*/ bool <UseFallback>k__BackingField;
        /*0x20*/ System.Func<System.Type, bool> <CanResolve>k__BackingField;
        /*0x28*/ System.Func<System.Type, System.Object[], object> <ResolveFunction>k__BackingField;

        static /*0x2584fc4*/ ObjectResolver();
        static /*0x2584f2c*/ CsvHelper.IObjectResolver get_Current();
        /*0x25851a8*/ ObjectResolver(System.Func<System.Type, bool> canResolve, System.Func<System.Type, System.Object[], object> resolveFunction, bool useFallback);
        /*0x2584f90*/ bool get_UseFallback();
        /*0x2584f98*/ void set_UseFallback(bool value);
        /*0x2584fa4*/ System.Func<System.Type, bool> get_CanResolve();
        /*0x2584fac*/ void set_CanResolve(System.Func<System.Type, bool> value);
        /*0x2584fb4*/ System.Func<System.Type, System.Object[], object> get_ResolveFunction();
        /*0x2584fbc*/ void set_ResolveFunction(System.Func<System.Type, System.Object[], object> value);
        /*0x25852c4*/ object Resolve(System.Type type, object[] constructorArgs);
        T Resolve<T>(object[] constructorArgs);

        class <>c__DisplayClass17_0
        {
            /*0x10*/ object locker;
            /*0x18*/ CsvHelper.ObjectCreator objectCreator;

            /*0x25851a0*/ <>c__DisplayClass17_0();
            /*0x2587478*/ object <.cctor>b__1(System.Type type, object[] args);
        }

        class <>c
        {
            static /*0x0*/ CsvHelper.ObjectResolver.<> <>9;

            static /*0x2587408*/ <>c();
            /*0x2587468*/ <>c();
            /*0x2587470*/ bool <.cctor>b__17_0(System.Type type);
        }
    }

    class ParserException : CsvHelper.CsvHelperException
    {
        /*0x25783f4*/ ParserException(CsvHelper.CsvContext context, string message);
    }

    class ReaderException : CsvHelper.CsvHelperException
    {
        /*0x257fffc*/ ReaderException(CsvHelper.CsvContext context, string message);
    }

    class ReflectionExtensions
    {
        static /*0x25858bc*/ bool HasParameterlessConstructor(System.Type type);
        static /*0x2585964*/ bool HasConstructor(System.Type type);
        static /*0x2585994*/ System.Reflection.ConstructorInfo GetConstructorWithMostParameters(System.Type type);
        static /*0x2585ae8*/ bool IsUserDefinedStruct(System.Type type);

        class <>c
        {
            static /*0x0*/ CsvHelper.ReflectionExtensions.<> <>9;
            static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, int> <>9__5_0;

            static /*0x2587568*/ <>c();
            /*0x25875c8*/ <>c();
            /*0x25875d0*/ int <GetConstructorWithMostParameters>b__5_0(System.Reflection.ConstructorInfo c);
        }
    }

    class ValidationException : CsvHelper.CsvHelperException
    {
        /*0x2581ec0*/ ValidationException(CsvHelper.CsvContext context, string message);
    }

    namespace TypeConversion
    {
        class ArrayConverter : CsvHelper.TypeConversion.IEnumerableConverter
        {
        }

        class BigIntegerConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2570b00*/ BigIntegerConverter();
        }

        class BooleanConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2570b10*/ BooleanConverter();
        }

        class ByteArrayConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x10*/ CsvHelper.TypeConversion.ByteArrayConverterOptions options;
            /*0x18*/ string HexStringPrefix;
            /*0x20*/ byte ByteLength;

            /*0x2570b18*/ ByteArrayConverter(CsvHelper.TypeConversion.ByteArrayConverterOptions options);
            /*0x2570bbc*/ void ValidateOptions();
        }

        enum ByteArrayConverterOptions
        {
            None = 0,
            Hexadecimal = 1,
            Base64 = 2,
            HexDashes = 4,
            HexInclude0x = 8,
        }

        class ByteConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2570cf8*/ ByteConverter();
        }

        class CharConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2570d00*/ CharConverter();
        }

        class CollectionGenericConverter : CsvHelper.TypeConversion.IEnumerableConverter
        {
        }

        class DateTimeConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x25811fc*/ DateTimeConverter();
        }

        class DateTimeOffsetConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581204*/ DateTimeOffsetConverter();
        }

        class DecimalConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x258120c*/ DecimalConverter();
        }

        class DefaultTypeConverter : CsvHelper.TypeConversion.ITypeConverter
        {
            /*0x2570b08*/ DefaultTypeConverter();
        }

        class DoubleConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x10*/ System.Lazy<string> defaultFormat;

            /*0x2581214*/ DoubleConverter();

            class <>c
            {
                static /*0x0*/ CsvHelper.TypeConversion.DoubleConverter.<> <>9;
                static /*0x8*/ System.Func<string> <>9__3_0;

                static /*0x258714c*/ <>c();
                /*0x25871ac*/ <>c();
                /*0x25871b4*/ string <.ctor>b__3_0();
            }
        }

        class EnumerableConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
        }

        class GuidConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581bb8*/ GuidConverter();
        }

        class IDictionaryConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581ec4*/ IDictionaryConverter();
        }

        class IDictionaryGenericConverter : CsvHelper.TypeConversion.IDictionaryConverter
        {
        }

        class IEnumerableConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581ecc*/ IEnumerableConverter();
        }

        class IEnumerableGenericConverter : CsvHelper.TypeConversion.IEnumerableConverter
        {
        }

        class Int16Converter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581ed4*/ Int16Converter();
        }

        class Int32Converter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581edc*/ Int32Converter();
        }

        class Int64Converter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2581ee4*/ Int64Converter();
        }

        interface ITypeConverter
        {
        }

        class SByteConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2585b4c*/ SByteConverter();
        }

        class SingleConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x10*/ System.Lazy<string> defaultFormat;

            /*0x25862e8*/ SingleConverter();

            class <>c
            {
                static /*0x0*/ CsvHelper.TypeConversion.SingleConverter.<> <>9;
                static /*0x8*/ System.Func<string> <>9__3_0;

                static /*0x2587604*/ <>c();
                /*0x2587664*/ <>c();
                /*0x258766c*/ string <.ctor>b__3_0();
            }
        }

        class StringConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2586434*/ StringConverter();
        }

        class TimeSpanConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x258643c*/ TimeSpanConverter();
        }

        class TypeConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2586444*/ TypeConverter();
        }

        class TypeConverterCache
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, CsvHelper.TypeConversion.ITypeConverter> typeConverters;

            /*0x2576064*/ TypeConverterCache();
            /*0x2586e40*/ void AddConverter(System.Type type, CsvHelper.TypeConversion.ITypeConverter typeConverter);
            /*0x258644c*/ void CreateDefaultConverters();
        }

        class TypeConverterOptions
        {
            static /*0x0*/ string[] defaultBooleanTrueValues;
            static /*0x8*/ string[] defaultBooleanFalseValues;
            static /*0x10*/ string[] defaultNullValues;
            /*0x10*/ System.Collections.Generic.List<string> <BooleanTrueValues>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<string> <BooleanFalseValues>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<string> <NullValues>k__BackingField;

            static /*0x2586f78*/ TypeConverterOptions();
            /*0x2581f8c*/ TypeConverterOptions();
        }

        class TypeConverterOptionsCache
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, CsvHelper.TypeConversion.TypeConverterOptions> typeConverterOptions;

            /*0x2575fec*/ TypeConverterOptionsCache();
        }

        class UInt16Converter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2586f58*/ UInt16Converter();
        }

        class UInt32Converter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2586f60*/ UInt32Converter();
        }

        class UInt64Converter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2586f68*/ UInt64Converter();
        }

        class UriConverter : CsvHelper.TypeConversion.DefaultTypeConverter
        {
            /*0x2586f70*/ UriConverter();
        }
    }

    namespace Expressions
    {
        class RecordManager
        {
        }
    }

    namespace Configuration
    {
        class ClassMap
        {
            static /*0x0*/ System.Collections.Generic.List<System.Type> enumerableConverters;

            static /*0x2570d08*/ ClassMap();
        }

        class ClassMapCollection
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, CsvHelper.Configuration.ClassMap> data;
            /*0x18*/ CsvHelper.CsvContext context;

            /*0x2570f2c*/ ClassMapCollection(CsvHelper.CsvContext context);
        }

        class ConfigurationException : CsvHelper.CsvHelperException
        {
            /*0x2570fb8*/ ConfigurationException();
            /*0x2570cf4*/ ConfigurationException(string message);
        }

        class ConfigurationFunctions
        {
            static /*0x0*/ char[] lineEndingChars;

            static /*0x2572278*/ ConfigurationFunctions();
            static /*0x2571094*/ void HeaderValidated(CsvHelper.HeaderValidatedArgs args);
            static /*0x25712b8*/ void MissingFieldFound(CsvHelper.MissingFieldFoundArgs args);
            static /*0x25715a0*/ void BadDataFound(CsvHelper.BadDataFoundArgs args);
            static /*0x25715f8*/ bool ReadingExceptionOccurred(CsvHelper.ReadingExceptionOccurredArgs args);
            static /*0x2571600*/ bool ShouldQuote(CsvHelper.ShouldQuoteArgs args);
            static /*0x2571a74*/ bool ShouldSkipRecord(CsvHelper.ShouldSkipRecordArgs args);
            static /*0x2571a7c*/ string PrepareHeaderForMatch(CsvHelper.PrepareHeaderForMatchArgs args);
            static /*0x2571a80*/ bool ShouldUseConstructorParameters(CsvHelper.ShouldUseConstructorParametersArgs args);
            static /*0x2571bec*/ System.Reflection.ConstructorInfo GetConstructor(CsvHelper.GetConstructorArgs args);
            static /*0x2571d40*/ string GetDynamicPropertyName(CsvHelper.GetDynamicPropertyNameArgs args);
        }

        class CsvConfiguration : CsvHelper.Configuration.IReaderConfiguration, CsvHelper.Configuration.IParserConfiguration, CsvHelper.Configuration.IWriterConfiguration, System.IEquatable<CsvHelper.Configuration.CsvConfiguration>
        {
            /*0x10*/ string newLine;
            /*0x18*/ bool <AllowComments>k__BackingField;
            /*0x20*/ CsvHelper.BadDataFound <BadDataFound>k__BackingField;
            /*0x28*/ int <BufferSize>k__BackingField;
            /*0x2c*/ bool <CacheFields>k__BackingField;
            /*0x2e*/ char <Comment>k__BackingField;
            /*0x30*/ bool <CountBytes>k__BackingField;
            /*0x38*/ System.Globalization.CultureInfo <CultureInfo>k__BackingField;
            /*0x40*/ string <Delimiter>k__BackingField;
            /*0x48*/ bool <DetectDelimiter>k__BackingField;
            /*0x50*/ string[] <DetectDelimiterValues>k__BackingField;
            /*0x58*/ bool <DetectColumnCountChanges>k__BackingField;
            /*0x60*/ System.Collections.Generic.IComparer<string> <DynamicPropertySort>k__BackingField;
            /*0x68*/ System.Text.Encoding <Encoding>k__BackingField;
            /*0x70*/ char <Escape>k__BackingField;
            /*0x72*/ bool <ExceptionMessagesContainRawData>k__BackingField;
            /*0x78*/ CsvHelper.GetConstructor <GetConstructor>k__BackingField;
            /*0x80*/ CsvHelper.GetDynamicPropertyName <GetDynamicPropertyName>k__BackingField;
            /*0x88*/ bool <HasHeaderRecord>k__BackingField;
            /*0x90*/ CsvHelper.HeaderValidated <HeaderValidated>k__BackingField;
            /*0x98*/ bool <IgnoreBlankLines>k__BackingField;
            /*0x99*/ bool <IgnoreReferences>k__BackingField;
            /*0x9a*/ bool <IncludePrivateMembers>k__BackingField;
            /*0xa0*/ char[] <InjectionCharacters>k__BackingField;
            /*0xa8*/ char <InjectionEscapeCharacter>k__BackingField;
            /*0xaa*/ bool <IsNewLineSet>k__BackingField;
            /*0xab*/ bool <LeaveOpen>k__BackingField;
            /*0xac*/ bool <LineBreakInQuotedFieldIsBadData>k__BackingField;
            /*0xb0*/ CsvHelper.Configuration.MemberTypes <MemberTypes>k__BackingField;
            /*0xb8*/ CsvHelper.MissingFieldFound <MissingFieldFound>k__BackingField;
            /*0xc0*/ CsvHelper.CsvMode <Mode>k__BackingField;
            /*0xc8*/ CsvHelper.PrepareHeaderForMatch <PrepareHeaderForMatch>k__BackingField;
            /*0xd0*/ int <ProcessFieldBufferSize>k__BackingField;
            /*0xd4*/ char <Quote>k__BackingField;
            /*0xd8*/ CsvHelper.ReadingExceptionOccurred <ReadingExceptionOccurred>k__BackingField;
            /*0xe0*/ CsvHelper.ReferenceHeaderPrefix <ReferenceHeaderPrefix>k__BackingField;
            /*0xe8*/ bool <SanitizeForInjection>k__BackingField;
            /*0xf0*/ CsvHelper.ShouldQuote <ShouldQuote>k__BackingField;
            /*0xf8*/ CsvHelper.ShouldSkipRecord <ShouldSkipRecord>k__BackingField;
            /*0x100*/ CsvHelper.ShouldUseConstructorParameters <ShouldUseConstructorParameters>k__BackingField;
            /*0x108*/ CsvHelper.Configuration.TrimOptions <TrimOptions>k__BackingField;
            /*0x10c*/ bool <UseNewObjectForNullReferenceMembers>k__BackingField;
            /*0x110*/ char[] <WhiteSpaceChars>k__BackingField;

            /*0x2572504*/ CsvConfiguration(System.Globalization.CultureInfo cultureInfo);
            /*0x2572318*/ System.Type get_EqualityContract();
            /*0x2572390*/ bool get_AllowComments();
            /*0x2572398*/ CsvHelper.BadDataFound get_BadDataFound();
            /*0x25723a0*/ int get_BufferSize();
            /*0x25723a8*/ bool get_CacheFields();
            /*0x25723b0*/ char get_Comment();
            /*0x25723b8*/ bool get_CountBytes();
            /*0x25723c0*/ System.Globalization.CultureInfo get_CultureInfo();
            /*0x25723c8*/ void set_CultureInfo(System.Globalization.CultureInfo value);
            /*0x25723d0*/ string get_Delimiter();
            /*0x25723d8*/ void set_Delimiter(string value);
            /*0x25723e0*/ bool get_DetectDelimiter();
            /*0x25723e8*/ string[] get_DetectDelimiterValues();
            /*0x25723f0*/ bool get_DetectColumnCountChanges();
            /*0x25723f8*/ System.Collections.Generic.IComparer<string> get_DynamicPropertySort();
            /*0x2572400*/ System.Text.Encoding get_Encoding();
            /*0x2572408*/ char get_Escape();
            /*0x2572410*/ bool get_ExceptionMessagesContainRawData();
            /*0x2572418*/ CsvHelper.GetConstructor get_GetConstructor();
            /*0x2572420*/ CsvHelper.GetDynamicPropertyName get_GetDynamicPropertyName();
            /*0x2572428*/ bool get_HasHeaderRecord();
            /*0x2572430*/ CsvHelper.HeaderValidated get_HeaderValidated();
            /*0x2572438*/ bool get_IgnoreBlankLines();
            /*0x2572440*/ bool get_IgnoreReferences();
            /*0x2572448*/ bool get_IncludePrivateMembers();
            /*0x2572450*/ char[] get_InjectionCharacters();
            /*0x2572458*/ char get_InjectionEscapeCharacter();
            /*0x2572460*/ bool get_IsNewLineSet();
            /*0x2572468*/ bool get_LeaveOpen();
            /*0x2572470*/ void set_LeaveOpen(bool value);
            /*0x257247c*/ bool get_LineBreakInQuotedFieldIsBadData();
            /*0x2572484*/ CsvHelper.Configuration.MemberTypes get_MemberTypes();
            /*0x257248c*/ CsvHelper.MissingFieldFound get_MissingFieldFound();
            /*0x2572494*/ CsvHelper.CsvMode get_Mode();
            /*0x257249c*/ string get_NewLine();
            /*0x25724a4*/ CsvHelper.PrepareHeaderForMatch get_PrepareHeaderForMatch();
            /*0x25724ac*/ int get_ProcessFieldBufferSize();
            /*0x25724b4*/ char get_Quote();
            /*0x25724bc*/ CsvHelper.ReadingExceptionOccurred get_ReadingExceptionOccurred();
            /*0x25724c4*/ CsvHelper.ReferenceHeaderPrefix get_ReferenceHeaderPrefix();
            /*0x25724cc*/ bool get_SanitizeForInjection();
            /*0x25724d4*/ CsvHelper.ShouldQuote get_ShouldQuote();
            /*0x25724dc*/ CsvHelper.ShouldSkipRecord get_ShouldSkipRecord();
            /*0x25724e4*/ CsvHelper.ShouldUseConstructorParameters get_ShouldUseConstructorParameters();
            /*0x25724ec*/ CsvHelper.Configuration.TrimOptions get_TrimOptions();
            /*0x25724f4*/ bool get_UseNewObjectForNullReferenceMembers();
            /*0x25724fc*/ char[] get_WhiteSpaceChars();
            /*0x2572dc8*/ void Validate();
            /*0x2573548*/ string ToString();
            /*0x2573660*/ bool PrintMembers(System.Text.StringBuilder builder);
            /*0x2574ab0*/ int GetHashCode();
            /*0x2575480*/ bool Equals(object obj);
            /*0x2575518*/ bool Equals(CsvHelper.Configuration.CsvConfiguration other);

            class <>c
            {
                static /*0x0*/ CsvHelper.Configuration.CsvConfiguration.<> <>9;
                static /*0x8*/ System.Func<char, string> <>9__175_0;

                static /*0x2587014*/ <>c();
                /*0x2587074*/ <>c();
                /*0x258707c*/ string <Validate>b__175_0(char c);
            }
        }

        interface IParserConfiguration
        {
            bool get_IgnoreBlankLines();
        }

        interface IReaderConfiguration : CsvHelper.Configuration.IParserConfiguration
        {
            bool get_HasHeaderRecord();
            CsvHelper.HeaderValidated get_HeaderValidated();
            CsvHelper.MissingFieldFound get_MissingFieldFound();
            CsvHelper.ReadingExceptionOccurred get_ReadingExceptionOccurred();
            System.Globalization.CultureInfo get_CultureInfo();
            CsvHelper.PrepareHeaderForMatch get_PrepareHeaderForMatch();
            CsvHelper.ShouldSkipRecord get_ShouldSkipRecord();
            bool get_IncludePrivateMembers();
            bool get_DetectColumnCountChanges();
        }

        interface IWriterConfiguration
        {
            string get_Delimiter();
            char get_Quote();
            string get_NewLine();
            bool get_IsNewLineSet();
        }

        class MemberMapData
        {
            /*0x10*/ System.Reflection.MemberInfo <Member>k__BackingField;
            /*0x18*/ CsvHelper.Configuration.MemberNameCollection <Names>k__BackingField;
            /*0x20*/ int <Index>k__BackingField;
            /*0x24*/ int <IndexEnd>k__BackingField;
            /*0x28*/ CsvHelper.TypeConversion.TypeConverterOptions <TypeConverterOptions>k__BackingField;

            /*0x257fe2c*/ MemberMapData(System.Reflection.MemberInfo member);
            /*0x2581f0c*/ void set_Member(System.Reflection.MemberInfo value);
        }

        class MemberNameCollection : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.List<string> names;
            /*0x18*/ string <Prefix>k__BackingField;

            /*0x2581f14*/ MemberNameCollection();
            /*0x25820a0*/ string get_Item(int index);
            /*0x2582120*/ string get_Prefix();
            /*0x2582128*/ System.Collections.Generic.IEnumerator<string> GetEnumerator();
            /*0x25821c0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            class <GetEnumerator>d__15 : System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ CsvHelper.Configuration.MemberNameCollection <>4__this;
                /*0x28*/ int <i>5__2;

                /*0x2582194*/ <GetEnumerator>d__15(int <>1__state);
                /*0x2587278*/ void System.IDisposable.Dispose();
                /*0x258727c*/ bool MoveNext();
                /*0x258732c*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x2587334*/ void System.Collections.IEnumerator.Reset();
                /*0x2587374*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        enum MemberTypes
        {
            None = 0,
            Properties = 1,
            Fields = 2,
        }

        enum TrimOptions
        {
            None = 0,
            Trim = 1,
            InsideQuotes = 2,
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ long 64BBD28B85D14B67F3AF758AE6CE58239A5A89FB1313A39720CF2D9939A68B1E;
}
