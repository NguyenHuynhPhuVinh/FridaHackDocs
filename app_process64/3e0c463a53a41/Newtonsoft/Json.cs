class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x722a87c*/ EmbeddedAttribute();
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
                /*0x722a884*/ IsReadOnlyAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x722a88c*/ NullableAttribute(byte );
                /*0x722a914*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x722a944*/ NullableContextAttribute(byte );
            }
        }
    }

    namespace Diagnostics
    {
        namespace CodeAnalysis
        {
            class NotNullAttribute : System.Attribute
            {
                /*0x722a96c*/ NotNullAttribute();
            }

            class NotNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x722a974*/ NotNullWhenAttribute(bool returnValue);
            }
        }
    }
}

namespace Newtonsoft
{
    namespace Json
    {
        enum ConstructorHandling
        {
            Default = 0,
            AllowNonPublicDefaultConstructor = 1,
        }

        enum DateFormatHandling
        {
            IsoDateFormat = 0,
            MicrosoftDateFormat = 1,
        }

        enum DateParseHandling
        {
            None = 0,
            DateTime = 1,
            DateTimeOffset = 2,
        }

        enum DateTimeZoneHandling
        {
            Local = 0,
            Utc = 1,
            Unspecified = 2,
            RoundtripKind = 3,
        }

        class DefaultJsonNameTable : Newtonsoft.Json.JsonNameTable
        {
            static /*0x0*/ int HashCodeRandomizer;
            /*0x10*/ int _count;
            /*0x18*/ Newtonsoft.Json.DefaultJsonNameTable.Entry[] _entries;
            /*0x20*/ int _mask;

            static /*0x722a99c*/ DefaultJsonNameTable();
            static /*0x722abec*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x722a9ec*/ DefaultJsonNameTable();
            /*0x722aa64*/ string Get(char[] key, int start, int length);
            /*0x722aca8*/ string Add(string key);
            /*0x722ae50*/ string AddEntry(string str, int hashCode);
            /*0x722afb8*/ void Grow();

            class Entry
            {
                /*0x10*/ string Value;
                /*0x18*/ int HashCode;
                /*0x20*/ Newtonsoft.Json.DefaultJsonNameTable.Entry Next;

                /*0x722af64*/ Entry(string value, int hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next);
            }
        }

        enum DefaultValueHandling
        {
            Include = 0,
            Ignore = 1,
            Populate = 2,
            IgnoreAndPopulate = 3,
        }

        enum FloatFormatHandling
        {
            String = 0,
            Symbol = 1,
            DefaultValue = 2,
        }

        enum FloatParseHandling
        {
            Double = 0,
            Decimal = 1,
        }

        enum Formatting
        {
            None = 0,
            Indented = 1,
        }

        interface IArrayPool<T>
        {
            /*0x380ba90*/ T[] Rent(int minimumLength);
            /*0x380d83c*/ void Return(T[] array);
        }

        interface IJsonLineInfo
        {
            /*0x380b128*/ bool HasLineInfo();
            /*0x380b6a0*/ int get_LineNumber();
            /*0x380b6a0*/ int get_LinePosition();
        }

        class JsonArrayAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
        }

        class JsonConstructorAttribute : System.Attribute
        {
        }

        class JsonContainerAttribute : System.Attribute
        {
            /*0x10*/ System.Type <ItemConverterType>k__BackingField;
            /*0x18*/ object[] <ItemConverterParameters>k__BackingField;
            /*0x20*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategyInstance>k__BackingField;
            /*0x28*/ System.Nullable<bool> _isReference;
            /*0x2a*/ System.Nullable<bool> _itemIsReference;
            /*0x2c*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;
            /*0x34*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;
            /*0x40*/ System.Type _namingStrategyType;
            /*0x48*/ object[] _namingStrategyParameters;

            /*0x722b110*/ System.Type get_ItemConverterType();
            /*0x722b118*/ object[] get_ItemConverterParameters();
            /*0x722b120*/ System.Type get_NamingStrategyType();
            /*0x722b128*/ object[] get_NamingStrategyParameters();
            /*0x722b130*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance();
            /*0x722b138*/ void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value);
        }

        class JsonConvert
        {
            static /*0x0*/ System.Func<Newtonsoft.Json.JsonSerializerSettings> <DefaultSettings>k__BackingField;
            static /*0x8*/ string True;
            static /*0x10*/ string False;
            static /*0x18*/ string Null;
            static /*0x20*/ string Undefined;
            static /*0x28*/ string PositiveInfinity;
            static /*0x30*/ string NegativeInfinity;
            static /*0x38*/ string NaN;

            static /*0x722c4a8*/ JsonConvert();
            static /*0x722b140*/ System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings();
            static /*0x722b198*/ string ToString(bool value);
            static /*0x722b204*/ string ToString(char value);
            static /*0x722b2dc*/ string ToString(float value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x722b490*/ string EnsureFloatFormat(double value, string text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x722b5a8*/ string ToString(double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x722b3cc*/ string EnsureDecimalPlace(double value, string text);
            static /*0x722b694*/ string EnsureDecimalPlace(string text);
            static /*0x722b708*/ string ToString(decimal value);
            static /*0x722b284*/ string ToString(string value);
            static /*0x722b7fc*/ string ToString(string value, char delimiter);
            static /*0x722b864*/ string ToString(string value, char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
            static /*0x722b948*/ string SerializeObject(object value);
            static /*0x722ba20*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting);
            static /*0x722baf8*/ string SerializeObject(object value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x722b9a4*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x722ba88*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x722be24*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x722bb94*/ string SerializeObjectInternal(object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer);
            static /*0x722c094*/ object DeserializeObject(string value, System.Type type);
            static /*0x3907c14*/ T DeserializeObject<T>(string value);
            static /*0x3907c14*/ T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x722c0fc*/ object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
        }

        class JsonConverter
        {
            /*0x722c620*/ JsonConverter();
            /*0x380da4c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
            /*0x380bd7c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            /*0x380b2f0*/ bool CanConvert(System.Type objectType);
            /*0x722c610*/ bool get_CanRead();
            /*0x722c618*/ bool get_CanWrite();
        }

        class JsonConverterAttribute : System.Attribute
        {
            /*0x10*/ System.Type _converterType;
            /*0x18*/ object[] <ConverterParameters>k__BackingField;

            /*0x722c628*/ System.Type get_ConverterType();
            /*0x722c630*/ object[] get_ConverterParameters();
        }

        class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter>
        {
            /*0x722c638*/ JsonConverterCollection();
        }

        class JsonDictionaryAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
        }

        class JsonException : System.Exception
        {
            /*0x722c680*/ JsonException();
            /*0x722c6d8*/ JsonException(string message);
            /*0x722c740*/ JsonException(string message, System.Exception innerException);
            /*0x722c7b0*/ JsonException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class JsonExtensionDataAttribute : System.Attribute
        {
            /*0x10*/ bool <WriteData>k__BackingField;
            /*0x11*/ bool <ReadData>k__BackingField;

            /*0x722c830*/ bool get_WriteData();
            /*0x722c838*/ bool get_ReadData();
        }

        class JsonIgnoreAttribute : System.Attribute
        {
            /*0x722c840*/ JsonIgnoreAttribute();
        }

        class JsonNameTable
        {
            /*0x722aa5c*/ JsonNameTable();
            string Get(char[] key, int start, int length);
        }

        class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
            /*0x50*/ Newtonsoft.Json.MemberSerialization _memberSerialization;
            /*0x54*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;
            /*0x5c*/ System.Nullable<Newtonsoft.Json.Required> _itemRequired;
            /*0x64*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;

            /*0x722c848*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
        }

        enum JsonContainerType
        {
            None = 0,
            Object = 1,
            Array = 2,
            Constructor = 3,
        }

        struct JsonPosition
        {
            static /*0x0*/ char[] SpecialCharacters;
            /*0x10*/ Newtonsoft.Json.JsonContainerType Type;
            /*0x14*/ int Position;
            /*0x18*/ string PropertyName;
            /*0x20*/ bool HasIndex;

            static /*0x722d1c8*/ JsonPosition();
            static /*0x722c8d4*/ bool TypeHasIndex(Newtonsoft.Json.JsonContainerType type);
            static /*0x722cb94*/ string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition);
            static /*0x722cea8*/ string FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message);
            /*0x722c850*/ JsonPosition(Newtonsoft.Json.JsonContainerType type);
            /*0x722c8e4*/ int CalculateLength();
            /*0x722c978*/ void WriteTo(System.Text.StringBuilder sb, ref System.IO.StringWriter writer, ref char[] buffer);
        }

        class JsonPropertyAttribute : System.Attribute
        {
            /*0x10*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling;
            /*0x18*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling;
            /*0x20*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling;
            /*0x28*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling;
            /*0x30*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling;
            /*0x38*/ System.Nullable<bool> _isReference;
            /*0x3c*/ System.Nullable<int> _order;
            /*0x44*/ System.Nullable<Newtonsoft.Json.Required> _required;
            /*0x4c*/ System.Nullable<bool> _itemIsReference;
            /*0x50*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;
            /*0x58*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;
            /*0x60*/ System.Type <ItemConverterType>k__BackingField;
            /*0x68*/ object[] <ItemConverterParameters>k__BackingField;
            /*0x70*/ System.Type <NamingStrategyType>k__BackingField;
            /*0x78*/ object[] <NamingStrategyParameters>k__BackingField;
            /*0x80*/ string <PropertyName>k__BackingField;

            /*0x722d298*/ JsonPropertyAttribute();
            /*0x722d268*/ System.Type get_ItemConverterType();
            /*0x722d270*/ object[] get_ItemConverterParameters();
            /*0x722d278*/ System.Type get_NamingStrategyType();
            /*0x722d280*/ object[] get_NamingStrategyParameters();
            /*0x722d288*/ string get_PropertyName();
            /*0x722d290*/ void set_PropertyName(string value);
        }

        class JsonReader : System.IDisposable
        {
            /*0x10*/ Newtonsoft.Json.JsonToken _tokenType;
            /*0x18*/ object _value;
            /*0x20*/ char _quoteChar;
            /*0x24*/ Newtonsoft.Json.JsonReader.State _currentState;
            /*0x28*/ Newtonsoft.Json.JsonPosition _currentPosition;
            /*0x40*/ System.Globalization.CultureInfo _culture;
            /*0x48*/ Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;
            /*0x4c*/ System.Nullable<int> _maxDepth;
            /*0x54*/ bool _hasExceededMaxDepth;
            /*0x58*/ Newtonsoft.Json.DateParseHandling _dateParseHandling;
            /*0x5c*/ Newtonsoft.Json.FloatParseHandling _floatParseHandling;
            /*0x60*/ string _dateFormatString;
            /*0x68*/ System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack;
            /*0x70*/ bool <CloseInput>k__BackingField;
            /*0x71*/ bool <SupportMultipleContent>k__BackingField;

            /*0x722d7a4*/ JsonReader();
            /*0x722d2a0*/ Newtonsoft.Json.JsonReader.State get_CurrentState();
            /*0x722d2a8*/ bool get_CloseInput();
            /*0x722d2b0*/ void set_CloseInput(bool value);
            /*0x722d2bc*/ bool get_SupportMultipleContent();
            /*0x722d2c4*/ void set_SupportMultipleContent(bool value);
            /*0x722d2d0*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x722d2d8*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x722d338*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x722d340*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x722d3a0*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x722d3a8*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x722d408*/ string get_DateFormatString();
            /*0x722d410*/ void set_DateFormatString(string value);
            /*0x722d418*/ System.Nullable<int> get_MaxDepth();
            /*0x722d420*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x722d4dc*/ Newtonsoft.Json.JsonToken get_TokenType();
            /*0x722d4e4*/ object get_Value();
            /*0x722d4ec*/ System.Type get_ValueType();
            /*0x722d500*/ int get_Depth();
            /*0x722d57c*/ string get_Path();
            /*0x722d690*/ System.Globalization.CultureInfo get_Culture();
            /*0x722d6f8*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x722d700*/ Newtonsoft.Json.JsonPosition GetPosition(int depth);
            /*0x722d834*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x722db20*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x722dc48*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x380b128*/ bool Read();
            /*0x722dc50*/ System.Nullable<int> ReadAsInt32();
            /*0x722e208*/ System.Nullable<int> ReadInt32String(string s);
            /*0x722e3b8*/ string ReadAsString();
            /*0x722e63c*/ byte[] ReadAsBytes();
            /*0x722ec00*/ byte[] ReadArrayIntoByteArray();
            /*0x722ed20*/ bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<byte> buffer);
            /*0x722ef24*/ System.Nullable<double> ReadAsDouble();
            /*0x722f1f0*/ System.Nullable<double> ReadDoubleString(string s);
            /*0x722f398*/ System.Nullable<bool> ReadAsBoolean();
            /*0x722f698*/ System.Nullable<bool> ReadBooleanString(string s);
            /*0x722f848*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x722fc34*/ System.Nullable<decimal> ReadDecimalString(string s);
            /*0x722fe9c*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x723011c*/ System.Nullable<System.DateTime> ReadDateTimeString(string s);
            /*0x72303a8*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x7230624*/ System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s);
            /*0x722ebbc*/ void ReaderReadAndAssert();
            /*0x723086c*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException();
            /*0x722e9f0*/ void ReadIntoWrappedTypeObject();
            /*0x72308b8*/ void Skip();
            /*0x722ed14*/ void SetToken(Newtonsoft.Json.JsonToken newToken);
            /*0x7230950*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value);
            /*0x722e0b8*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value, bool updateIndex);
            /*0x7230a54*/ void SetPostValueState(bool updateIndex);
            /*0x722db00*/ void UpdateScopeWithFinishedValue();
            /*0x7230958*/ void ValidateEnd(Newtonsoft.Json.JsonToken endToken);
            /*0x7230b60*/ void SetStateBasedOnCurrent();
            /*0x7230a90*/ void SetFinished();
            /*0x7230ab8*/ Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token);
            /*0x7230c4c*/ void System.IDisposable.Dispose();
            /*0x7230cbc*/ void Dispose(bool disposing);
            /*0x7230ce0*/ void Close();
            /*0x7230cf8*/ void ReadAndAssert();
            /*0x7230d54*/ void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x7230da4*/ bool ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x723101c*/ bool ReadAndMoveToContent();
            /*0x723104c*/ bool MoveToContent();
            /*0x722dfdc*/ Newtonsoft.Json.JsonToken GetContentToken();

            enum State
            {
                Start = 0,
                Complete = 1,
                Property = 2,
                ObjectStart = 3,
                Object = 4,
                ArrayStart = 5,
                Array = 6,
                Closed = 7,
                PostValue = 8,
                ConstructorStart = 9,
                Constructor = 10,
                Error = 11,
                Finished = 12,
            }
        }

        class JsonReaderException : Newtonsoft.Json.JsonException
        {
            /*0x8c*/ int <LineNumber>k__BackingField;
            /*0x90*/ int <LinePosition>k__BackingField;
            /*0x98*/ string <Path>k__BackingField;

            static /*0x722db18*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x722e034*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x72310f4*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x72310a4*/ JsonReaderException();
            /*0x72310a8*/ JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x72310ac*/ JsonReaderException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
        }

        class JsonRequiredAttribute : System.Attribute
        {
            /*0x72312f8*/ JsonRequiredAttribute();
        }

        class JsonSerializationException : Newtonsoft.Json.JsonException
        {
            /*0x8c*/ int <LineNumber>k__BackingField;
            /*0x90*/ int <LinePosition>k__BackingField;
            /*0x98*/ string <Path>k__BackingField;

            static /*0x7230d4c*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x7231358*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x72313dc*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x7231300*/ JsonSerializationException();
            /*0x7231304*/ JsonSerializationException(string message);
            /*0x7231308*/ JsonSerializationException(string message, System.Exception innerException);
            /*0x723130c*/ JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7231310*/ JsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
        }

        class JsonSerializer
        {
            /*0x10*/ Newtonsoft.Json.TypeNameHandling _typeNameHandling;
            /*0x14*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;
            /*0x18*/ Newtonsoft.Json.PreserveReferencesHandling _preserveReferencesHandling;
            /*0x1c*/ Newtonsoft.Json.ReferenceLoopHandling _referenceLoopHandling;
            /*0x20*/ Newtonsoft.Json.MissingMemberHandling _missingMemberHandling;
            /*0x24*/ Newtonsoft.Json.ObjectCreationHandling _objectCreationHandling;
            /*0x28*/ Newtonsoft.Json.NullValueHandling _nullValueHandling;
            /*0x2c*/ Newtonsoft.Json.DefaultValueHandling _defaultValueHandling;
            /*0x30*/ Newtonsoft.Json.ConstructorHandling _constructorHandling;
            /*0x34*/ Newtonsoft.Json.MetadataPropertyHandling _metadataPropertyHandling;
            /*0x38*/ Newtonsoft.Json.JsonConverterCollection _converters;
            /*0x40*/ Newtonsoft.Json.Serialization.IContractResolver _contractResolver;
            /*0x48*/ Newtonsoft.Json.Serialization.ITraceWriter _traceWriter;
            /*0x50*/ System.Collections.IEqualityComparer _equalityComparer;
            /*0x58*/ Newtonsoft.Json.Serialization.ISerializationBinder _serializationBinder;
            /*0x60*/ System.Runtime.Serialization.StreamingContext _context;
            /*0x70*/ Newtonsoft.Json.Serialization.IReferenceResolver _referenceResolver;
            /*0x78*/ System.Nullable<Newtonsoft.Json.Formatting> _formatting;
            /*0x80*/ System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling;
            /*0x88*/ System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling;
            /*0x90*/ System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling;
            /*0x98*/ System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling;
            /*0xa0*/ System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling;
            /*0xa8*/ System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling;
            /*0xb0*/ System.Globalization.CultureInfo _culture;
            /*0xb8*/ System.Nullable<int> _maxDepth;
            /*0xc0*/ bool _maxDepthSet;
            /*0xc1*/ System.Nullable<bool> _checkAdditionalContent;
            /*0xc8*/ string _dateFormatString;
            /*0xd0*/ bool _dateFormatStringSet;
            /*0xd8*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error;

            static /*0x7231ff4*/ Newtonsoft.Json.JsonSerializer Create();
            static /*0x7232044*/ Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x72327b0*/ Newtonsoft.Json.JsonSerializer CreateDefault();
            static /*0x722bb60*/ Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7232078*/ void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7233ec4*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType);
            /*0x7231ea8*/ JsonSerializer();
            /*0x72315e0*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x7231690*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x7231740*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
            /*0x72317b8*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
            /*0x7231830*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x7231838*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
            /*0x7231840*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
            /*0x7231848*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x72318a8*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
            /*0x7231908*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
            /*0x7231968*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x72319c8*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x7231a28*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x7231a30*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x7231a90*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x7231af0*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x7231b50*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
            /*0x7231bb0*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x7231bb8*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
            /*0x7231c18*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
            /*0x7231c84*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x7231c8c*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
            /*0x7231d3c*/ System.Runtime.Serialization.StreamingContext get_Context();
            /*0x7231d48*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
            /*0x7231d58*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x7231d94*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x7231dfc*/ System.Nullable<int> get_MaxDepth();
            /*0x7231e04*/ bool get_CheckAdditionalContent();
            /*0x7231e40*/ void set_CheckAdditionalContent(bool value);
            /*0x722c358*/ bool IsCheckAdditionalContentSet();
            /*0x7232b3c*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
            /*0x7232b4c*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
            /*0x3907c14*/ T Deserialize<T>(Newtonsoft.Json.JsonReader reader);
            /*0x722c498*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x723342c*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x7232dc4*/ void SetupReader(Newtonsoft.Json.JsonReader reader, ref System.Globalization.CultureInfo previousCulture, ref System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, ref System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, ref System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, ref System.Nullable<int> previousMaxDepth, ref string previousDateFormatString);
            /*0x7233210*/ void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<int> previousMaxDepth, string previousDateFormatString);
            /*0x722c084*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x72336ac*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value);
            /*0x7233188*/ Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader);
            /*0x72336c0*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x7233e4c*/ Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver();
            /*0x7233ebc*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type);
            /*0x7234020*/ void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e);
        }

        class JsonSerializerSettings
        {
            static /*0x0*/ System.Runtime.Serialization.StreamingContext DefaultContext;
            static /*0x10*/ System.Globalization.CultureInfo DefaultCulture;
            /*0x10*/ System.Nullable<Newtonsoft.Json.Formatting> _formatting;
            /*0x18*/ System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling;
            /*0x20*/ System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling;
            /*0x28*/ System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling;
            /*0x30*/ System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling;
            /*0x38*/ System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling;
            /*0x40*/ System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling;
            /*0x48*/ System.Globalization.CultureInfo _culture;
            /*0x50*/ System.Nullable<bool> _checkAdditionalContent;
            /*0x54*/ System.Nullable<int> _maxDepth;
            /*0x5c*/ bool _maxDepthSet;
            /*0x60*/ string _dateFormatString;
            /*0x68*/ bool _dateFormatStringSet;
            /*0x6c*/ System.Nullable<Newtonsoft.Json.TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling;
            /*0x74*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling;
            /*0x7c*/ System.Nullable<Newtonsoft.Json.PreserveReferencesHandling> _preserveReferencesHandling;
            /*0x84*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling;
            /*0x8c*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling;
            /*0x94*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;
            /*0x9c*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling;
            /*0xa8*/ System.Nullable<System.Runtime.Serialization.StreamingContext> _context;
            /*0xc0*/ System.Nullable<Newtonsoft.Json.ConstructorHandling> _constructorHandling;
            /*0xc8*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling;
            /*0xd0*/ System.Nullable<Newtonsoft.Json.MetadataPropertyHandling> _metadataPropertyHandling;
            /*0xd8*/ System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> <Converters>k__BackingField;
            /*0xe0*/ Newtonsoft.Json.Serialization.IContractResolver <ContractResolver>k__BackingField;
            /*0xe8*/ System.Collections.IEqualityComparer <EqualityComparer>k__BackingField;
            /*0xf0*/ System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> <ReferenceResolverProvider>k__BackingField;
            /*0xf8*/ Newtonsoft.Json.Serialization.ITraceWriter <TraceWriter>k__BackingField;
            /*0x100*/ Newtonsoft.Json.Serialization.ISerializationBinder <SerializationBinder>k__BackingField;
            /*0x108*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> <Error>k__BackingField;

            static /*0x7234158*/ JsonSerializerSettings();
            /*0x72341e0*/ JsonSerializerSettings();
            /*0x7232944*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x7234048*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x7232980*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x72329bc*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x72329f8*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x7232a34*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x72340b0*/ System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters();
            /*0x72340b8*/ void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value);
            /*0x7232908*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
            /*0x7232854*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x72340c0*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x7232890*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x72328cc*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
            /*0x7232a70*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
            /*0x7234128*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x7234130*/ System.Collections.IEqualityComparer get_EqualityComparer();
            /*0x7234138*/ System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider();
            /*0x7234140*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x7234148*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
            /*0x7234150*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error();
            /*0x7232aac*/ System.Runtime.Serialization.StreamingContext get_Context();
        }

        class JsonTextReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
        {
            /*0x72*/ bool _safeAsync;
            /*0x78*/ System.IO.TextReader _reader;
            /*0x80*/ char[] _chars;
            /*0x88*/ int _charsUsed;
            /*0x8c*/ int _charPos;
            /*0x90*/ int _lineStartPos;
            /*0x94*/ int _lineNumber;
            /*0x98*/ bool _isEndOfFile;
            /*0xa0*/ Newtonsoft.Json.Utilities.StringBuffer _stringBuffer;
            /*0xb0*/ Newtonsoft.Json.Utilities.StringReference _stringReference;
            /*0xc0*/ Newtonsoft.Json.IArrayPool<char> _arrayPool;
            /*0xc8*/ Newtonsoft.Json.JsonNameTable <PropertyNameTable>k__BackingField;

            static /*0x7234c6c*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x7239da4*/ object BigIntegerParse(string number, System.Globalization.CultureInfo culture);
            /*0x722c394*/ JsonTextReader(System.IO.TextReader reader);
            /*0x7234268*/ Newtonsoft.Json.JsonNameTable get_PropertyNameTable();
            /*0x7234270*/ void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value);
            /*0x7234278*/ void EnsureBufferNotEmpty();
            /*0x72342d8*/ void SetNewLine(bool hasNextChar);
            /*0x7234338*/ void OnNewLine(int pos);
            /*0x7234348*/ void ParseString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x72348b0*/ void ParseReadString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x7234390*/ void ShiftBufferIfNeeded();
            /*0x7234c80*/ int ReadData(bool append);
            /*0x7234d1c*/ void PrepareBufferForReadData(bool append, int charsRequired);
            /*0x7234c8c*/ int ReadData(bool append, int charsRequired);
            /*0x7234ed8*/ bool EnsureChars(int relativePosition, bool append);
            /*0x7234ef8*/ bool ReadChars(int relativePosition, bool append);
            /*0x7234f68*/ bool Read();
            /*0x7235e1c*/ System.Nullable<int> ReadAsInt32();
            /*0x7236250*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x7236784*/ string ReadAsString();
            /*0x72367b8*/ byte[] ReadAsBytes();
            /*0x72362e0*/ object ReadStringValue(Newtonsoft.Json.ReadType readType);
            /*0x723704c*/ object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType);
            /*0x7236de4*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(char c);
            /*0x723750c*/ System.Nullable<bool> ReadAsBoolean();
            /*0x7236d78*/ void ProcessValueComma();
            /*0x7235eac*/ object ReadNumberValue(Newtonsoft.Json.ReadType readType);
            /*0x7237a44*/ object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType);
            /*0x7237bcc*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x7237c98*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x7237d64*/ System.Nullable<double> ReadAsDouble();
            /*0x7236ca8*/ void HandleNull();
            /*0x7236f04*/ void ReadFinished();
            /*0x7236c58*/ bool ReadNullChar();
            /*0x7235184*/ void EnsureBuffer();
            /*0x7234444*/ void ReadStringIntoBuffer(char quote);
            /*0x7237f54*/ void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition);
            /*0x7237f04*/ void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition);
            /*0x7237ff8*/ char ConvertUnicode(bool enoughChars);
            /*0x7237ec4*/ char ParseUnicode();
            /*0x723814c*/ void ReadNumberIntoBuffer();
            /*0x72381d0*/ bool ReadNumberCharIntoBuffer(char currentChar, int charPos);
            /*0x7238324*/ void ClearRecentString();
            /*0x72357e8*/ bool ParsePostValue(bool ignoreComments);
            /*0x723566c*/ bool ParseObject();
            /*0x7238330*/ bool ParseProperty();
            /*0x723855c*/ bool ValidIdentifierChar(char value);
            /*0x72385b0*/ void ParseUnquotedProperty();
            /*0x72386b0*/ bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition);
            /*0x72351e4*/ bool ParseValue();
            /*0x7236ee8*/ void ProcessLineFeed();
            /*0x7236ea0*/ void ProcessCarriageReturn(bool append);
            /*0x7235a98*/ void EatWhitespace();
            /*0x7238990*/ void ParseConstructor();
            /*0x7237308*/ void ParseNumber(Newtonsoft.Json.ReadType readType);
            /*0x7238d6c*/ void ParseReadNumber(Newtonsoft.Json.ReadType readType, char firstChar, int initialPosition);
            /*0x7239d38*/ Newtonsoft.Json.JsonReaderException ThrowReaderError(string message, System.Exception ex);
            /*0x7235b8c*/ void ParseComment(bool setToken);
            /*0x7239e2c*/ void EndComment(bool setToken, int initialPosition, int endPosition);
            /*0x7239e6c*/ bool MatchValue(string value);
            /*0x7239ec8*/ bool MatchValue(bool enoughChars, string value);
            /*0x7237370*/ bool MatchValueWithTrailingSeparator(string value);
            /*0x7239fa8*/ bool IsSeparator(char c);
            /*0x72387e0*/ void ParseTrue();
            /*0x7237e18*/ void ParseNull();
            /*0x7238cc0*/ void ParseUndefined();
            /*0x72388b8*/ void ParseFalse();
            /*0x723728c*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType);
            /*0x723a0e0*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x7237414*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType);
            /*0x723a228*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x7237490*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType);
            /*0x723a370*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x723a4b8*/ void Close();
            /*0x723a538*/ bool HasLineInfo();
            /*0x723a540*/ int get_LineNumber();
            /*0x723a588*/ int get_LinePosition();
        }

        enum ReadType
        {
            Read = 0,
            ReadAsInt32 = 1,
            ReadAsInt64 = 2,
            ReadAsBytes = 3,
            ReadAsString = 4,
            ReadAsDecimal = 5,
            ReadAsDateTime = 6,
            ReadAsDateTimeOffset = 7,
            ReadAsDouble = 8,
            ReadAsBoolean = 9,
        }

        class JsonTextWriter : Newtonsoft.Json.JsonWriter
        {
            /*0x60*/ bool _safeAsync;
            /*0x68*/ System.IO.TextWriter _writer;
            /*0x70*/ Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder;
            /*0x78*/ char _indentChar;
            /*0x7c*/ int _indentation;
            /*0x80*/ char _quoteChar;
            /*0x82*/ bool _quoteName;
            /*0x88*/ bool[] _charEscapeFlags;
            /*0x90*/ char[] _writeBuffer;
            /*0x98*/ Newtonsoft.Json.IArrayPool<char> _arrayPool;
            /*0xa0*/ char[] _indentChars;

            /*0x722bebc*/ JsonTextWriter(System.IO.TextWriter textWriter);
            /*0x723a594*/ Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder();
            /*0x723a618*/ char get_QuoteChar();
            /*0x723a6c0*/ void Close();
            /*0x723a6f4*/ void CloseBufferAndWriter();
            /*0x723a758*/ void WriteStartObject();
            /*0x723a7d0*/ void WriteStartArray();
            /*0x723a808*/ void WriteStartConstructor(string name);
            /*0x723a8b0*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x723a9a4*/ void WritePropertyName(string name);
            /*0x723aadc*/ void WritePropertyName(string name, bool escape);
            /*0x723abac*/ void OnStringEscapeHandlingChanged();
            /*0x723a64c*/ void UpdateCharEscapeFlags();
            /*0x723abb0*/ void WriteIndent();
            /*0x723ad24*/ int SetIndentChars();
            /*0x723ae1c*/ void WriteValueDelimiter();
            /*0x723ae44*/ void WriteIndentSpace();
            /*0x723ae6c*/ void WriteValueInternal(string value, Newtonsoft.Json.JsonToken token);
            /*0x723ae90*/ void WriteValue(object value);
            /*0x723b0f8*/ void WriteNull();
            /*0x723b18c*/ void WriteUndefined();
            /*0x723b220*/ void WriteRaw(string json);
            /*0x723b248*/ void WriteValue(string value);
            /*0x723aa20*/ void WriteEscapedString(string value, bool quote);
            /*0x723b348*/ void WriteValue(int value);
            /*0x723b3d8*/ void WriteValue(uint value);
            /*0x723b468*/ void WriteValue(long value);
            /*0x723b4ac*/ void WriteValue(ulong value);
            /*0x723b564*/ void WriteValue(float value);
            /*0x723b61c*/ void WriteValue(System.Nullable<float> value);
            /*0x723b71c*/ void WriteValue(double value);
            /*0x723b7d4*/ void WriteValue(System.Nullable<double> value);
            /*0x723b8e0*/ void WriteValue(bool value);
            /*0x723b97c*/ void WriteValue(short value);
            /*0x723b9c0*/ void WriteValue(ushort value);
            /*0x723ba04*/ void WriteValue(char value);
            /*0x723baa0*/ void WriteValue(byte value);
            /*0x723bae4*/ void WriteValue(sbyte value);
            /*0x723bb28*/ void WriteValue(decimal value);
            /*0x723bbd4*/ void WriteValue(System.DateTime value);
            /*0x723bd68*/ int WriteValueToBuffer(System.DateTime value);
            /*0x723be80*/ void WriteValue(byte[] value);
            /*0x723bf48*/ void WriteValue(System.DateTimeOffset value);
            /*0x723c0b0*/ int WriteValueToBuffer(System.DateTimeOffset value);
            /*0x723c210*/ void WriteValue(System.Guid value);
            /*0x723c31c*/ void WriteValue(System.TimeSpan value);
            /*0x723c440*/ void WriteValue(System.Uri value);
            /*0x723c510*/ void WriteComment(string text);
            /*0x723b2fc*/ void EnsureWriteBuffer();
            /*0x723b41c*/ void WriteIntegerValue(long value);
            /*0x723b4f4*/ void WriteIntegerValue(ulong value, bool negative);
            /*0x723c5d0*/ int WriteNumberToBuffer(ulong value, bool negative);
            /*0x723b38c*/ void WriteIntegerValue(int value);
            /*0x723c744*/ void WriteIntegerValue(uint value, bool negative);
            /*0x723c69c*/ int WriteNumberToBuffer(uint value, bool negative);
        }

        enum JsonToken
        {
            None = 0,
            StartObject = 1,
            StartArray = 2,
            StartConstructor = 3,
            PropertyName = 4,
            Comment = 5,
            Raw = 6,
            Integer = 7,
            Float = 8,
            String = 9,
            Boolean = 10,
            Null = 11,
            Undefined = 12,
            EndObject = 13,
            EndArray = 14,
            EndConstructor = 15,
            Date = 16,
            Bytes = 17,
        }

        class JsonWriter : System.IDisposable
        {
            static /*0x0*/ Newtonsoft.Json.JsonWriter.State[][] StateArray;
            static /*0x8*/ Newtonsoft.Json.JsonWriter.State[][] StateArrayTemplate;
            /*0x10*/ System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack;
            /*0x18*/ Newtonsoft.Json.JsonPosition _currentPosition;
            /*0x30*/ Newtonsoft.Json.JsonWriter.State _currentState;
            /*0x34*/ Newtonsoft.Json.Formatting _formatting;
            /*0x38*/ bool <CloseOutput>k__BackingField;
            /*0x39*/ bool <AutoCompleteOnClose>k__BackingField;
            /*0x3c*/ Newtonsoft.Json.DateFormatHandling _dateFormatHandling;
            /*0x40*/ Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;
            /*0x44*/ Newtonsoft.Json.StringEscapeHandling _stringEscapeHandling;
            /*0x48*/ Newtonsoft.Json.FloatFormatHandling _floatFormatHandling;
            /*0x50*/ string _dateFormatString;
            /*0x58*/ System.Globalization.CultureInfo _culture;

            static /*0x723ca2c*/ JsonWriter();
            static /*0x723c7b4*/ Newtonsoft.Json.JsonWriter.State[][] BuildStateArray();
            static /*0x723f14c*/ void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value);
            static /*0x7240268*/ void ResolveConvertibleValue(System.IConvertible convertible, ref Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, ref object value);
            static /*0x723f094*/ Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, object value);
            /*0x723a620*/ JsonWriter();
            /*0x723cd4c*/ bool get_CloseOutput();
            /*0x723cd54*/ void set_CloseOutput(bool value);
            /*0x723cd60*/ bool get_AutoCompleteOnClose();
            /*0x723cd68*/ void set_AutoCompleteOnClose(bool value);
            /*0x723acd4*/ int get_Top();
            /*0x723cd7c*/ Newtonsoft.Json.WriteState get_WriteState();
            /*0x723ce2c*/ string get_ContainerPath();
            /*0x723cec8*/ string get_Path();
            /*0x723cfdc*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x722c024*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x723cfe4*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0x7233c5c*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0x723cfec*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x7233cbc*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x723cff4*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0x7233d7c*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0x723cffc*/ void OnStringEscapeHandlingChanged();
            /*0x723d000*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0x7233d1c*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0x723d008*/ string get_DateFormatString();
            /*0x723d010*/ void set_DateFormatString(string value);
            /*0x7233de4*/ System.Globalization.CultureInfo get_Culture();
            /*0x723d018*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x723d020*/ void UpdateScopeWithFinishedValue();
            /*0x723d038*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x723d1e4*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x723cd74*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x723a6e4*/ void Close();
            /*0x723d300*/ void WriteStartObject();
            /*0x723d30c*/ void WriteEndObject();
            /*0x723d318*/ void WriteStartArray();
            /*0x723d324*/ void WriteEndArray();
            /*0x723d32c*/ void WriteStartConstructor(string name);
            /*0x723d338*/ void WriteEndConstructor();
            /*0x723d340*/ void WritePropertyName(string name);
            /*0x723d360*/ void WritePropertyName(string name, bool escape);
            /*0x723d370*/ void WriteEnd();
            /*0x723d448*/ void WriteToken(Newtonsoft.Json.JsonReader reader);
            /*0x723d450*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren);
            /*0x723d4d0*/ void WriteToken(Newtonsoft.Json.JsonToken token, object value);
            /*0x723db74*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            /*0x723dea4*/ bool IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, bool writeChildren, int initialDepth);
            /*0x723dd74*/ int CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader);
            /*0x723df10*/ int CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader);
            /*0x723ddd8*/ void WriteConstructorDate(Newtonsoft.Json.JsonReader reader);
            /*0x723d378*/ void WriteEnd(Newtonsoft.Json.JsonContainerType type);
            /*0x723d2c0*/ void AutoCompleteAll();
            /*0x723df70*/ Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type);
            /*0x723e00c*/ void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type);
            /*0x723e0c8*/ int CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type);
            /*0x723e1c0*/ void UpdateCurrentState();
            /*0x723e274*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x723e278*/ void WriteIndent();
            /*0x723e27c*/ void WriteValueDelimiter();
            /*0x723e280*/ void WriteIndentSpace();
            /*0x723e284*/ void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten);
            /*0x723e48c*/ void WriteNull();
            /*0x723e4a8*/ void WriteUndefined();
            /*0x723e4c4*/ void WriteRaw(string json);
            /*0x723e4c8*/ void WriteRawValue(string json);
            /*0x723e518*/ void WriteValue(string value);
            /*0x723e534*/ void WriteValue(int value);
            /*0x723e550*/ void WriteValue(uint value);
            /*0x723e56c*/ void WriteValue(long value);
            /*0x723e588*/ void WriteValue(ulong value);
            /*0x723e5a4*/ void WriteValue(float value);
            /*0x723e5c0*/ void WriteValue(double value);
            /*0x723e5dc*/ void WriteValue(bool value);
            /*0x723e5f8*/ void WriteValue(short value);
            /*0x723e614*/ void WriteValue(ushort value);
            /*0x723e630*/ void WriteValue(char value);
            /*0x723e64c*/ void WriteValue(byte value);
            /*0x723e668*/ void WriteValue(sbyte value);
            /*0x723e684*/ void WriteValue(decimal value);
            /*0x723e6a0*/ void WriteValue(System.DateTime value);
            /*0x723e6bc*/ void WriteValue(System.DateTimeOffset value);
            /*0x723e6d8*/ void WriteValue(System.Guid value);
            /*0x723e6f4*/ void WriteValue(System.TimeSpan value);
            /*0x723e710*/ void WriteValue(System.Nullable<int> value);
            /*0x723e78c*/ void WriteValue(System.Nullable<uint> value);
            /*0x723e808*/ void WriteValue(System.Nullable<long> value);
            /*0x723e894*/ void WriteValue(System.Nullable<ulong> value);
            /*0x723e920*/ void WriteValue(System.Nullable<float> value);
            /*0x723e9a0*/ void WriteValue(System.Nullable<double> value);
            /*0x723ea2c*/ void WriteValue(System.Nullable<bool> value);
            /*0x723eab0*/ void WriteValue(System.Nullable<short> value);
            /*0x723eb2c*/ void WriteValue(System.Nullable<ushort> value);
            /*0x723eba8*/ void WriteValue(System.Nullable<char> value);
            /*0x723ec24*/ void WriteValue(System.Nullable<byte> value);
            /*0x723eca0*/ void WriteValue(System.Nullable<sbyte> value);
            /*0x723ed1c*/ void WriteValue(System.Nullable<decimal> value);
            /*0x723ed9c*/ void WriteValue(System.Nullable<System.DateTime> value);
            /*0x723ee28*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
            /*0x723eea8*/ void WriteValue(System.Nullable<System.Guid> value);
            /*0x723ef2c*/ void WriteValue(System.Nullable<System.TimeSpan> value);
            /*0x723efb8*/ void WriteValue(byte[] value);
            /*0x723efe8*/ void WriteValue(System.Uri value);
            /*0x723afc4*/ void WriteValue(object value);
            /*0x72401d0*/ void WriteComment(string text);
            /*0x72401d8*/ void System.IDisposable.Dispose();
            /*0x7240248*/ void Dispose(bool disposing);
            /*0x72403ec*/ void SetWriteState(Newtonsoft.Json.JsonToken token, object value);
            /*0x723d314*/ void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container);
            /*0x723aa00*/ void InternalWritePropertyName(string name);
            /*0x723b244*/ void InternalWriteRaw();
            /*0x723a790*/ void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container);
            /*0x723afac*/ void InternalWriteValue(Newtonsoft.Json.JsonToken token);
            /*0x723c5c8*/ void InternalWriteComment();

            enum State
            {
                Start = 0,
                Property = 1,
                ObjectStart = 2,
                Object = 3,
                ArrayStart = 4,
                Array = 5,
                ConstructorStart = 6,
                Constructor = 7,
                Closed = 8,
                Error = 9,
            }
        }

        class JsonWriterException : Newtonsoft.Json.JsonException
        {
            /*0x90*/ string <Path>k__BackingField;

            static /*0x72405b0*/ Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, string message, System.Exception ex);
            static /*0x72405e4*/ Newtonsoft.Json.JsonWriterException Create(string path, string message, System.Exception ex);
            /*0x724056c*/ JsonWriterException();
            /*0x7240574*/ JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x724057c*/ JsonWriterException(string message, string path, System.Exception innerException);
        }

        enum MemberSerialization
        {
            OptOut = 0,
            OptIn = 1,
            Fields = 2,
        }

        enum MetadataPropertyHandling
        {
            Default = 0,
            ReadAhead = 1,
            Ignore = 2,
        }

        enum MissingMemberHandling
        {
            Ignore = 0,
            Error = 1,
        }

        enum NullValueHandling
        {
            Include = 0,
            Ignore = 1,
        }

        enum ObjectCreationHandling
        {
            Auto = 0,
            Reuse = 1,
            Replace = 2,
        }

        enum PreserveReferencesHandling
        {
            None = 0,
            Objects = 1,
            Arrays = 2,
            All = 3,
        }

        enum ReferenceLoopHandling
        {
            Error = 0,
            Ignore = 1,
            Serialize = 2,
        }

        enum Required
        {
            Default = 0,
            AllowNull = 1,
            Always = 2,
            DisallowNull = 3,
        }

        enum StringEscapeHandling
        {
            Default = 0,
            EscapeNonAscii = 1,
            EscapeHtml = 2,
        }

        enum TypeNameAssemblyFormatHandling
        {
            Simple = 0,
            Full = 1,
        }

        enum TypeNameHandling
        {
            None = 0,
            Objects = 1,
            Arrays = 2,
            All = 3,
            Auto = 4,
        }

        enum WriteState
        {
            Error = 0,
            Closed = 1,
            Object = 2,
            Array = 3,
            Constructor = 4,
            Property = 5,
            Start = 6,
        }

        namespace Utilities
        {
            class Base64Encoder
            {
                /*0x10*/ char[] _charsLine;
                /*0x18*/ System.IO.TextWriter _writer;
                /*0x20*/ byte[] _leftOverBytes;
                /*0x28*/ int _leftOverBytesCount;

                /*0x72406a4*/ Base64Encoder(System.IO.TextWriter writer);
                /*0x7240790*/ void ValidateEncode(byte[] buffer, int index, int count);
                /*0x7240854*/ void Encode(byte[] buffer, int index, int count);
                /*0x7240ab4*/ void StoreLeftOverBytes(byte[] buffer, int index, ref int count);
                /*0x72409f4*/ bool FulfillFromLeftover(byte[] buffer, int index, ref int count);
                /*0x7240bd0*/ void Flush();
                /*0x7240a90*/ void WriteChars(char[] chars, int index, int count);
            }

            class BidirectionalDictionary<TFirst, TSecond>
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TFirst, TSecond> _firstToSecond;
                /*0x0*/ System.Collections.Generic.IDictionary<TSecond, TFirst> _secondToFirst;
                /*0x0*/ string _duplicateFirstErrorMessage;
                /*0x0*/ string _duplicateSecondErrorMessage;

                /*0x380da84*/ BidirectionalDictionary(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage);
                /*0x3907c14*/ void Set(TFirst first, TSecond second);
                /*0x3907c14*/ bool TryGetByFirst(TFirst first, ref TSecond second);
                /*0x3907c14*/ bool TryGetBySecond(TSecond second, ref TFirst first);
            }

            class BoxedPrimitives
            {
                static /*0x0*/ object BooleanTrue;
                static /*0x8*/ object BooleanFalse;
                static /*0x10*/ object Int32_M1;
                static /*0x18*/ object Int32_0;
                static /*0x20*/ object Int32_1;
                static /*0x28*/ object Int32_2;
                static /*0x30*/ object Int32_3;
                static /*0x38*/ object Int32_4;
                static /*0x40*/ object Int32_5;
                static /*0x48*/ object Int32_6;
                static /*0x50*/ object Int32_7;
                static /*0x58*/ object Int32_8;
                static /*0x60*/ object Int64_M1;
                static /*0x68*/ object Int64_0;
                static /*0x70*/ object Int64_1;
                static /*0x78*/ object Int64_2;
                static /*0x80*/ object Int64_3;
                static /*0x88*/ object Int64_4;
                static /*0x90*/ object Int64_5;
                static /*0x98*/ object Int64_6;
                static /*0xa0*/ object Int64_7;
                static /*0xa8*/ object Int64_8;
                static /*0xb0*/ object DecimalZero;
                static /*0xb8*/ object DoubleNaN;
                static /*0xc0*/ object DoublePositiveInfinity;
                static /*0xc8*/ object DoubleNegativeInfinity;
                static /*0xd0*/ object DoubleZero;

                static /*0x72412e8*/ BoxedPrimitives();
                static /*0x7240c88*/ object Get(bool value);
                static /*0x7240cf0*/ object Get(int value);
                static /*0x7240ef4*/ object Get(long value);
                static /*0x7241104*/ object Get(decimal value);
                static /*0x72411ec*/ object Get(double value);
            }

            class CollectionUtils
            {
                static /*0x381ac0c*/ bool IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection);
                static /*0x383af28*/ void AddRange<T>(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection);
                static /*0x7241810*/ bool IsDictionaryType(System.Type type);
                static /*0x7241a0c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType);
                static /*0x7241b1c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType);
                static /*0x3827170*/ int IndexOf<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, bool> predicate);
                static /*0x3907c14*/ bool Contains<T>(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer);
                static /*0x3907c14*/ int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
                static /*0x3837da0*/ void FastReverse<T>(System.Collections.Generic.List<T> list);
                static /*0x7241e44*/ System.Collections.Generic.IList<int> GetDimensions(System.Collections.IList values, int dimensionsCount);
                static /*0x72420f8*/ void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, int[] indices);
                static /*0x72423b4*/ object JaggedArrayGetValue(System.Collections.IList values, int[] indices);
                static /*0x72424f0*/ System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, int rank);
                static /*0x382dee4*/ T[] ArrayEmpty<T>();

                class EmptyArrayContainer<T>
                {
                    static /*0x0*/ T[] Empty;

                    static /*0x38358cc*/ EmptyArrayContainer();
                }
            }

            interface IWrappedCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x380b9e8*/ object get_UnderlyingCollection();
            }

            class CollectionWrapper<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedCollection, System.Collections.IList, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IList _list;
                /*0x0*/ System.Collections.Generic.ICollection<T> _genericCollection;
                /*0x0*/ object _syncRoot;

                static /*0x3837da0*/ void VerifyValueType(object value);
                static /*0x381ac0c*/ bool IsCompatibleObject(object value);
                /*0x3907c14*/ void Add(T item);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool Contains(T item);
                /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x380b6a0*/ int get_Count();
                /*0x380b128*/ bool get_IsReadOnly();
                /*0x3907c14*/ bool Remove(T item);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380b7a8*/ int System.Collections.IList.Add(object value);
                /*0x380b2f0*/ bool System.Collections.IList.Contains(object value);
                /*0x380b7a8*/ int System.Collections.IList.IndexOf(object value);
                /*0x380cffc*/ void System.Collections.IList.RemoveAt(int index);
                /*0x380d170*/ void System.Collections.IList.Insert(int index, object value);
                /*0x380b128*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x380d83c*/ void System.Collections.IList.Remove(object value);
                /*0x380ba90*/ object System.Collections.IList.get_Item(int index);
                /*0x380d170*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b9e8*/ object get_UnderlyingCollection();
            }

            enum PrimitiveTypeCode
            {
                Empty = 0,
                Object = 1,
                Char = 2,
                CharNullable = 3,
                Boolean = 4,
                BooleanNullable = 5,
                SByte = 6,
                SByteNullable = 7,
                Int16 = 8,
                Int16Nullable = 9,
                UInt16 = 10,
                UInt16Nullable = 11,
                Int32 = 12,
                Int32Nullable = 13,
                Byte = 14,
                ByteNullable = 15,
                UInt32 = 16,
                UInt32Nullable = 17,
                Int64 = 18,
                Int64Nullable = 19,
                UInt64 = 20,
                UInt64Nullable = 21,
                Single = 22,
                SingleNullable = 23,
                Double = 24,
                DoubleNullable = 25,
                DateTime = 26,
                DateTimeNullable = 27,
                DateTimeOffset = 28,
                DateTimeOffsetNullable = 29,
                Decimal = 30,
                DecimalNullable = 31,
                Guid = 32,
                GuidNullable = 33,
                TimeSpan = 34,
                TimeSpanNullable = 35,
                BigInteger = 36,
                BigIntegerNullable = 37,
                Uri = 38,
                String = 39,
                Bytes = 40,
                DBNull = 41,
            }

            class TypeInformation
            {
                /*0x10*/ System.Type <Type>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;

                /*0x72426dc*/ TypeInformation(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode);
                /*0x72426cc*/ System.Type get_Type();
                /*0x72426d4*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
            }

            enum ParseResult
            {
                None = 0,
                Success = 1,
                Overflow = 2,
                Invalid = 3,
            }

            class ConvertUtils
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Newtonsoft.Json.Utilities.PrimitiveTypeCode> TypeCodeMap;
                static /*0x8*/ Newtonsoft.Json.Utilities.TypeInformation[] PrimitiveTypeCodes;
                static /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type>, System.Func<object, object>> CastConverters;

                static /*0x72458a8*/ ConvertUtils();
                static /*0x7242718*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t);
                static /*0x7242780*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, ref bool isEnum);
                static /*0x7242af4*/ Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable);
                static /*0x7242be0*/ bool IsConvertible(System.Type t);
                static /*0x7242c60*/ System.TimeSpan ParseTimeSpan(string input);
                static /*0x7242cf0*/ System.Func<object, object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type> t);
                static /*0x7242f54*/ System.Numerics.BigInteger ToBigInteger(object value);
                static /*0x72432f4*/ object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType);
                static /*0x7243764*/ object Convert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x7244498*/ bool TryConvert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x72439c0*/ Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x7244944*/ object ConvertOrCast(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x72446f4*/ object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType);
                static /*0x7244650*/ bool VersionTryParse(string input, ref System.Version result);
                static /*0x72445c0*/ bool IsInteger(object value);
                static /*0x7244ab4*/ Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, ref int value);
                static /*0x7244c30*/ Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, ref long value);
                static /*0x7244da0*/ Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, ref decimal value);
                static /*0x724577c*/ bool TryConvertGuid(string s, ref System.Guid g);
                static /*0x72457d8*/ bool TryHexTextToInt(char[] text, int start, int end, ref int value);

                enum ConvertResult
                {
                    Success = 0,
                    CannotConvertNull = 1,
                    NotInstantiableType = 2,
                    NoValidConversion = 3,
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x7242f4c*/ <>c__DisplayClass8_0();
                    /*0x7246a60*/ object <CreateCastConverter>b__0(object o);
                }
            }

            enum ParserTimeZone
            {
                Unspecified = 0,
                Utc = 1,
                LocalWestOfUtc = 2,
                LocalEastOfUtc = 3,
            }

            struct DateTimeParser
            {
                static /*0x0*/ int[] Power10;
                static /*0x8*/ int Lzyyyy;
                static /*0xc*/ int Lzyyyy_;
                static /*0x10*/ int Lzyyyy_MM;
                static /*0x14*/ int Lzyyyy_MM_;
                static /*0x18*/ int Lzyyyy_MM_dd;
                static /*0x1c*/ int Lzyyyy_MM_ddT;
                static /*0x20*/ int LzHH;
                static /*0x24*/ int LzHH_;
                static /*0x28*/ int LzHH_mm;
                static /*0x2c*/ int LzHH_mm_;
                static /*0x30*/ int LzHH_mm_ss;
                static /*0x34*/ int Lz_;
                static /*0x38*/ int Lz_zz;
                /*0x10*/ int Year;
                /*0x14*/ int Month;
                /*0x18*/ int Day;
                /*0x1c*/ int Hour;
                /*0x20*/ int Minute;
                /*0x24*/ int Second;
                /*0x28*/ int Fraction;
                /*0x2c*/ int ZoneHour;
                /*0x30*/ int ZoneMinute;
                /*0x34*/ Newtonsoft.Json.Utilities.ParserTimeZone Zone;
                /*0x38*/ char[] _text;
                /*0x40*/ int _end;

                static /*0x7246b20*/ DateTimeParser();
                /*0x7246da4*/ bool Parse(char[] text, int startIndex, int length);
                /*0x7246ea4*/ bool ParseDate(int start);
                /*0x7247098*/ bool ParseTimeAndZoneAndWhitespace(int start);
                /*0x72472c0*/ bool ParseTime(ref int start);
                /*0x724759c*/ bool ParseZone(int start);
                /*0x7247134*/ bool Parse4Digit(int start, ref int num);
                /*0x7247224*/ bool Parse2Digit(int start, ref int num);
                /*0x724704c*/ bool ParseChar(int start, char ch);
            }

            class DateTimeUtils
            {
                static /*0x0*/ long InitialJavaScriptDateTicks;
                static /*0x8*/ int[] DaysToMonth365;
                static /*0x10*/ int[] DaysToMonth366;

                static /*0x72477a4*/ DateTimeUtils();
                static /*0x724789c*/ System.TimeSpan GetUtcOffset(System.DateTime d);
                static /*0x7247904*/ System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind);
                static /*0x7247a7c*/ System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone);
                static /*0x7247bcc*/ System.DateTime SwitchToLocalTime(System.DateTime value);
                static /*0x7247ca4*/ System.DateTime SwitchToUtcTime(System.DateTime value);
                static /*0x7247d7c*/ long ToUniversalTicks(System.DateTime dateTime);
                static /*0x7247e3c*/ long ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x7247f98*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x724807c*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime);
                static /*0x72480d4*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, bool convertToUtc);
                static /*0x7248000*/ long UniversalTicksToJavaScriptTicks(long universalTicks);
                static /*0x7248190*/ System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks);
                static /*0x7248218*/ bool TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x7248758*/ bool TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x724865c*/ System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser);
                static /*0x72489e4*/ bool TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x724902c*/ bool TryParseDateTime(string s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x7249318*/ bool TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x7249734*/ bool TryParseDateTimeOffset(string s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x72499fc*/ bool TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, ref long ticks, ref System.TimeSpan offset, ref System.DateTimeKind kind);
                static /*0x7248dbc*/ bool TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x7248f44*/ bool TryParseDateTimeExact(string text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x7249524*/ bool TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x7249688*/ bool TryParseDateTimeOffsetExact(string text, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x7249bf4*/ bool TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, int startIndex, ref System.TimeSpan offset);
                static /*0x7249d78*/ void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x7249ef0*/ int WriteDateTimeString(char[] chars, int start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format);
                static /*0x724a3bc*/ int WriteDefaultIsoDate(char[] chars, int start, System.DateTime dt);
                static /*0x724aa18*/ void CopyIntToCharArray(char[] chars, int start, int value, int digits);
                static /*0x724a204*/ int WriteDateTimeOffset(char[] chars, int start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format);
                static /*0x724aa80*/ void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x724a7e8*/ void GetDateValues(System.DateTime td, ref int year, ref int month, ref int day);
            }

            interface IWrappedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x380b9e8*/ object get_UnderlyingDictionary();
            }

            class DictionaryWrapper<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedDictionary, System.Collections.IDictionary, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IDictionary _dictionary;
                /*0x0*/ System.Collections.Generic.IDictionary<TKey, TValue> _genericDictionary;
                /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;
                /*0x0*/ object _syncRoot;

                /*0x380b9e8*/ System.Collections.Generic.IDictionary<TKey, TValue> get_GenericDictionary();
                /*0x3907c14*/ void Add(TKey key, TValue value);
                /*0x3907c14*/ bool ContainsKey(TKey key);
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> get_Keys();
                /*0x3907c14*/ bool Remove(TKey key);
                /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> get_Values();
                /*0x3907c14*/ TValue get_Item(TKey key);
                /*0x3907c14*/ void set_Item(TKey key, TValue value);
                /*0x3907c14*/ void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380d8b8*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x380b6a0*/ int get_Count();
                /*0x380b128*/ bool get_IsReadOnly();
                /*0x3907c14*/ bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x380d83c*/ void Remove(object key);
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b9e8*/ object get_UnderlyingDictionary();

                struct DictionaryEnumerator`2<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    /*0x380d83c*/ DictionaryEnumerator`2(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    System.Collections.DictionaryEntry get_Entry();
                    /*0x380b9e8*/ object get_Key();
                    /*0x380b9e8*/ object get_Value();
                    /*0x380b9e8*/ object get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.DictionaryEntry, System.Collections.Generic.KeyValuePair<TKey, TValue>> <>9__29_0;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(System.Collections.DictionaryEntry de);
                }
            }

            class DynamicProxy<T>
            {
                /*0x380cb08*/ DynamicProxy();
                /*0x3907c14*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(T instance);
                /*0x3907c14*/ bool TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
                /*0x3907c14*/ bool TryConvert(T instance, System.Dynamic.ConvertBinder binder, ref object result);
                /*0x3907c14*/ bool TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, object[] args, ref object result);
                /*0x3907c14*/ bool TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, object[] indexes);
                /*0x3907c14*/ bool TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder);
                /*0x3907c14*/ bool TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, object[] indexes, ref object result);
                /*0x3907c14*/ bool TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, ref object result);
                /*0x3907c14*/ bool TryInvoke(T instance, System.Dynamic.InvokeBinder binder, object[] args, ref object result);
                /*0x3907c14*/ bool TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, object[] args, ref object result);
                /*0x3907c14*/ bool TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, object[] indexes, object value);
                /*0x3907c14*/ bool TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, object value);
                /*0x3907c14*/ bool TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, ref object result);
            }

            class DynamicProxyMetaObject<T> : System.Dynamic.DynamicMetaObject
            {
                /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;

                static /*0x382dee4*/ System.Linq.Expressions.Expression[] get_NoArgs();
                static /*0x382eaf0*/ System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args);
                static /*0x382eaf0*/ System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args);
                static /*0x3830700*/ System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value);
                static /*0x382eaf0*/ System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder);
                /*0x3907c14*/ DynamicProxyMetaObject(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy);
                /*0x380b2f0*/ bool IsOverridden(string method);
                /*0x380bb68*/ System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value);
                /*0x380bb68*/ System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder);
                /*0x380bb68*/ System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg);
                /*0x380bb68*/ System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                /*0x380bd40*/ System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value);
                /*0x380bcbc*/ System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                /*0x380bdb8*/ System.Dynamic.DynamicMetaObject CallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                /*0x380bdb8*/ System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                /*0x380bd7c*/ System.Dynamic.DynamicMetaObject CallMethodReturnLast(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                /*0x380bd7c*/ System.Dynamic.DynamicMetaObject CallMethodNoResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                /*0x380b9e8*/ System.Dynamic.BindingRestrictions GetRestrictions();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames();

                class Fallback<T> : System.MulticastDelegate
                {
                    Fallback(object object, nint method);
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion);
                }

                class GetBinderAdapter<T> : System.Dynamic.GetMemberBinder
                {
                    /*0x380d83c*/ GetBinderAdapter(System.Dynamic.InvokeMemberBinder binder);
                    /*0x380bcbc*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
                }

                class <>c<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Dynamic.DynamicMetaObject, System.Linq.Expressions.Expression> <>9__18_0;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x380bb68*/ System.Linq.Expressions.Expression <GetArgs>b__18_0(System.Dynamic.DynamicMetaObject arg);
                }

                class <>c__DisplayClass10_0<T>
                {
                    /*0x0*/ System.Dynamic.BinaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject arg;

                    /*0x380cb08*/ <>c__DisplayClass10_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindBinaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass11_0<T>
                {
                    /*0x0*/ System.Dynamic.UnaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x380cb08*/ <>c__DisplayClass11_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindUnaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass12_0<T>
                {
                    /*0x0*/ System.Dynamic.GetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    /*0x380cb08*/ <>c__DisplayClass12_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindGetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass13_0<T>
                {
                    /*0x0*/ System.Dynamic.SetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    /*0x380cb08*/ <>c__DisplayClass13_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindSetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass14_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    /*0x380cb08*/ <>c__DisplayClass14_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindDeleteIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass3_0<T>
                {
                    /*0x0*/ System.Dynamic.GetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x380cb08*/ <>c__DisplayClass3_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindGetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Dynamic.SetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    /*0x380cb08*/ <>c__DisplayClass4_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindSetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x380cb08*/ <>c__DisplayClass5_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindDeleteMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Dynamic.ConvertBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x380cb08*/ <>c__DisplayClass6_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindConvert>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x380cb08*/ <>c__DisplayClass7_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindInvokeMember>b__0(System.Dynamic.DynamicMetaObject e);
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindInvokeMember>b__1(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Dynamic.CreateInstanceBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x380cb08*/ <>c__DisplayClass8_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindCreateInstance>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x380cb08*/ <>c__DisplayClass9_0();
                    /*0x380bb68*/ System.Dynamic.DynamicMetaObject <BindInvoke>b__0(System.Dynamic.DynamicMetaObject e);
                }
            }

            class DynamicUtils
            {
                static /*0x724ac3c*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider);

                class BinderWrapper
                {
                    static /*0x0*/ object _getCSharpArgumentInfoArray;
                    static /*0x8*/ object _setCSharpArgumentInfoArray;
                    static /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _getMemberCall;
                    static /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _setMemberCall;
                    static /*0x20*/ bool _init;

                    static /*0x724ad24*/ void Init();
                    static /*0x724af08*/ object CreateSharpArgumentInfoArray(int[] values);
                    static /*0x724b1c8*/ void CreateMemberCalls();
                    static /*0x724b6f0*/ System.Runtime.CompilerServices.CallSiteBinder GetMember(string name, System.Type context);
                    static /*0x724b8e8*/ System.Runtime.CompilerServices.CallSiteBinder SetMember(string name, System.Type context);
                }
            }

            class NoThrowGetBinderMember : System.Dynamic.GetMemberBinder
            {
                /*0x28*/ System.Dynamic.GetMemberBinder _innerBinder;

                /*0x724bae0*/ NoThrowGetBinderMember(System.Dynamic.GetMemberBinder innerBinder);
                /*0x724bb20*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowSetBinderMember : System.Dynamic.SetMemberBinder
            {
                /*0x28*/ System.Dynamic.SetMemberBinder _innerBinder;

                /*0x724bc70*/ NoThrowSetBinderMember(System.Dynamic.SetMemberBinder innerBinder);
                /*0x724bcb0*/ System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
            {
                static /*0x0*/ object ErrorResult;

                static /*0x724bef0*/ NoThrowExpressionVisitor();
                /*0x724bc68*/ NoThrowExpressionVisitor();
                /*0x724be04*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node);
            }

            class EnumInfo
            {
                /*0x10*/ bool IsFlags;
                /*0x18*/ ulong[] Values;
                /*0x20*/ string[] Names;
                /*0x28*/ string[] ResolvedNames;

                /*0x724bf6c*/ EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames);
            }

            class EnumUtils
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy>, Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;
                static /*0x8*/ Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;

                static /*0x724d488*/ EnumUtils();
                static /*0x724bfd4*/ Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy> key);
                static /*0x724c76c*/ bool TryToString(System.Type enumType, object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, ref string name);
                static /*0x724c90c*/ string InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, ulong result);
                static /*0x724caa4*/ Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType);
                static /*0x724c4a8*/ ulong ToUInt64(object value);
                static /*0x724cb60*/ object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, string value, bool disallowNumber);
                static /*0x724d3a4*/ System.Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, System.StringComparison comparison);
                static /*0x724d2b4*/ System.Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, System.StringComparison comparison);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.EnumUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Runtime.Serialization.EnumMemberAttribute, string> <>9__3_0;

                    static /*0x724d5b4*/ <>c();
                    /*0x724d61c*/ <>c();
                    /*0x724d624*/ string <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a);
                }
            }

            class FSharpFunction
            {
                /*0x10*/ object _instance;
                /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _invoker;

                /*0x724d63c*/ FSharpFunction(object instance, Newtonsoft.Json.Utilities.MethodCall<object, object> invoker);
                /*0x724d680*/ object Invoke(object[] args);
            }

            class FSharpUtils
            {
                static /*0x0*/ object Lock;
                static /*0x8*/ Newtonsoft.Json.Utilities.FSharpUtils _instance;
                /*0x10*/ System.Reflection.MethodInfo _ofSeq;
                /*0x18*/ System.Type _mapType;
                /*0x20*/ System.Reflection.Assembly <FSharpCoreAssembly>k__BackingField;
                /*0x28*/ Newtonsoft.Json.Utilities.MethodCall<object, object> <IsUnion>k__BackingField;
                /*0x30*/ Newtonsoft.Json.Utilities.MethodCall<object, object> <GetUnionCases>k__BackingField;
                /*0x38*/ Newtonsoft.Json.Utilities.MethodCall<object, object> <PreComputeUnionTagReader>k__BackingField;
                /*0x40*/ Newtonsoft.Json.Utilities.MethodCall<object, object> <PreComputeUnionReader>k__BackingField;
                /*0x48*/ Newtonsoft.Json.Utilities.MethodCall<object, object> <PreComputeUnionConstructor>k__BackingField;
                /*0x50*/ System.Func<object, object> <GetUnionCaseInfoDeclaringType>k__BackingField;
                /*0x58*/ System.Func<object, object> <GetUnionCaseInfoName>k__BackingField;
                /*0x60*/ System.Func<object, object> <GetUnionCaseInfoTag>k__BackingField;
                /*0x68*/ Newtonsoft.Json.Utilities.MethodCall<object, object> <GetUnionCaseInfoFields>k__BackingField;

                static /*0x724e390*/ FSharpUtils();
                static /*0x724de78*/ Newtonsoft.Json.Utilities.FSharpUtils get_Instance();
                static /*0x724df68*/ void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly);
                static /*0x724dc08*/ System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, System.Reflection.BindingFlags bindingFlags);
                static /*0x724dc7c*/ Newtonsoft.Json.Utilities.MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName);
                /*0x724d6ac*/ FSharpUtils(System.Reflection.Assembly fsharpCoreAssembly);
                /*0x724ded0*/ void set_FSharpCoreAssembly(System.Reflection.Assembly value);
                /*0x724ded8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_IsUnion();
                /*0x724dee0*/ void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x724dee8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCases();
                /*0x724def0*/ void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x724def8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionTagReader();
                /*0x724df00*/ void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x724df08*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionReader();
                /*0x724df10*/ void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x724df18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionConstructor();
                /*0x724df20*/ void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x724df28*/ System.Func<object, object> get_GetUnionCaseInfoDeclaringType();
                /*0x724df30*/ void set_GetUnionCaseInfoDeclaringType(System.Func<object, object> value);
                /*0x724df38*/ System.Func<object, object> get_GetUnionCaseInfoName();
                /*0x724df40*/ void set_GetUnionCaseInfoName(System.Func<object, object> value);
                /*0x724df48*/ System.Func<object, object> get_GetUnionCaseInfoTag();
                /*0x724df50*/ void set_GetUnionCaseInfoTag(System.Func<object, object> value);
                /*0x724df58*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCaseInfoFields();
                /*0x724df60*/ void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x724e0dc*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateSeq(System.Type t);
                /*0x724e1e4*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType);
                /*0x380b9e8*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> BuildMapCreator<TKey, TValue>();

                class <>c__55<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Tuple<TKey, TValue>> <>9__55_1;

                    static /*0x38358cc*/ <>c__55();
                    /*0x380cb08*/ <>c__55();
                    /*0x3907c14*/ System.Tuple<TKey, TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey, TValue> kv);
                }

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;
                    /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> invoke;

                    /*0x724e0d4*/ <>c__DisplayClass52_0();
                    /*0x724e40c*/ object <CreateFSharpFuncCall>b__0(object target, object[] args);
                }

                class <>c__DisplayClass55_0<TKey, TValue>
                {
                    /*0x0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> ctorDelegate;

                    /*0x380cb08*/ <>c__DisplayClass55_0();
                    /*0x380bb68*/ object <BuildMapCreator>b__0(object[] args);
                }
            }

            class ImmutableCollectionsUtils
            {
                static /*0x0*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;
                static /*0x8*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

                static /*0x724ee9c*/ ImmutableCollectionsUtils();
                static /*0x724e4a8*/ bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);
                static /*0x724e98c*/ bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);

                class ImmutableCollectionTypeInfo
                {
                    /*0x10*/ string <ContractTypeName>k__BackingField;
                    /*0x18*/ string <CreatedTypeName>k__BackingField;
                    /*0x20*/ string <BuilderTypeName>k__BackingField;

                    /*0x724f764*/ ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName);
                    /*0x724f7c4*/ string get_ContractTypeName();
                    /*0x724f7cc*/ void set_ContractTypeName(string value);
                    /*0x724f7d4*/ string get_CreatedTypeName();
                    /*0x724f7dc*/ void set_CreatedTypeName(string value);
                    /*0x724f7e4*/ string get_BuilderTypeName();
                    /*0x724f7ec*/ void set_BuilderTypeName(string value);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__24_1;
                    static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__25_1;

                    static /*0x724f7f4*/ <>c();
                    /*0x724f85c*/ <>c();
                    /*0x724f864*/ bool <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m);
                    /*0x724f8f8*/ bool <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string name;

                    /*0x724e964*/ <>c__DisplayClass24_0();
                    /*0x724fa48*/ bool <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ string name;

                    /*0x724ee94*/ <>c__DisplayClass25_0();
                    /*0x724fa6c*/ bool <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }
            }

            class BufferUtils
            {
                static /*0x724fa90*/ char[] RentBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int minSize);
                static /*0x724fb58*/ void ReturnBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer);
                static /*0x724fc08*/ char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int size, char[] buffer);
            }

            class JavaScriptUtils
            {
                static /*0x0*/ bool[] SingleQuoteCharEscapeFlags;
                static /*0x8*/ bool[] DoubleQuoteCharEscapeFlags;
                static /*0x10*/ bool[] HtmlCharEscapeFlags;

                static /*0x724fd44*/ JavaScriptUtils();
                static /*0x72509b4*/ bool[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, char quoteChar);
                static /*0x7250a4c*/ bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags);
                static /*0x7250ad4*/ void WriteEscapedJavaScriptString(System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<char> bufferPool, ref char[] writeBuffer);
                static /*0x725122c*/ string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x72510bc*/ int FirstCharToEscape(string s, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x725151c*/ bool TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, ref System.DateTime dateTime, ref string errorMessage);
                static /*0x7251980*/ bool TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, ref System.Nullable<long> integer, ref string errorMessage);
            }

            class JsonTokenUtils
            {
                static /*0x7251b34*/ bool IsEndToken(Newtonsoft.Json.JsonToken token);
                static /*0x7251b44*/ bool IsStartToken(Newtonsoft.Json.JsonToken token);
                static /*0x7251b54*/ bool IsPrimitiveToken(Newtonsoft.Json.JsonToken token);
            }

            class LateBoundReflectionDelegateFactory : Newtonsoft.Json.Utilities.ReflectionDelegateFactory
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

                static /*0x7251d8c*/ LateBoundReflectionDelegateFactory();
                static /*0x7251b78*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance();
                /*0x7251d7c*/ LateBoundReflectionDelegateFactory();
                /*0x7251bd0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                /*0x380bb68*/ Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                /*0x380bb68*/ System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                /*0x380bb68*/ System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                /*0x380bb68*/ System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x380bb68*/ System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x380bb68*/ System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.Reflection.ConstructorInfo c;
                    /*0x18*/ System.Reflection.MethodBase method;

                    /*0x7251d74*/ <>c__DisplayClass3_0();
                    /*0x7251df4*/ object <CreateParameterizedConstructor>b__0(object[] a);
                    /*0x7251e10*/ object <CreateParameterizedConstructor>b__1(object[] a);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Reflection.ConstructorInfo c;
                    /*0x0*/ System.Reflection.MethodBase method;

                    /*0x380cb08*/ <>c__DisplayClass4_0();
                    /*0x3907c14*/ object <CreateMethodCall>b__0(T o, object[] a);
                    /*0x3907c14*/ object <CreateMethodCall>b__1(T o, object[] a);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Type type;
                    /*0x0*/ System.Reflection.ConstructorInfo constructorInfo;

                    /*0x380cb08*/ <>c__DisplayClass5_0();
                    /*0x3907c14*/ T <CreateDefaultConstructor>b__0();
                    /*0x3907c14*/ T <CreateDefaultConstructor>b__1();
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x380cb08*/ <>c__DisplayClass6_0();
                    /*0x3907c14*/ object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x380cb08*/ <>c__DisplayClass7_0();
                    /*0x3907c14*/ object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x380cb08*/ <>c__DisplayClass8_0();
                    /*0x3907c14*/ void <CreateSet>b__0(T o, object v);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x380cb08*/ <>c__DisplayClass9_0();
                    /*0x3907c14*/ void <CreateSet>b__0(T o, object v);
                }
            }

            class MathUtils
            {
                static /*0x7251e34*/ int IntLength(ulong i);
                static /*0x7251ff8*/ char IntToHex(int n);
                static /*0x7252010*/ bool ApproxEquals(double d1, double d2);
            }

            class MethodCall<T, TResult> : System.MulticastDelegate
            {
                MethodCall(object object, nint method);
                /*0x3907c14*/ TResult Invoke(T target, object[] args);
            }

            class MiscellaneousUtils
            {
                static /*0x72520b0*/ bool ValueEquals(object objA, object objB);
                static /*0x7247984*/ System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message);
                static /*0x7252394*/ string ToString(object value);
                static /*0x7252438*/ int ByteArrayCompare(byte[] a1, byte[] a2);
                static /*0x72524ec*/ string GetPrefix(string qualifiedName);
                static /*0x72525cc*/ string GetLocalName(string qualifiedName);
                static /*0x7252510*/ void GetQualifiedNameParts(string qualifiedName, ref string prefix, ref string localName);
                static /*0x7252604*/ System.Text.RegularExpressions.RegexOptions GetRegexOptions(string optionsText);
            }

            class ReflectionDelegateFactory
            {
                /*0x7251d84*/ ReflectionDelegateFactory();
                /*0x380bb68*/ System.Func<T, object> CreateGet<T>(System.Reflection.MemberInfo memberInfo);
                /*0x380bb68*/ System.Action<T, object> CreateSet<T>(System.Reflection.MemberInfo memberInfo);
                /*0x380bb68*/ Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                /*0x380bb68*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                /*0x380bb68*/ System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                /*0x380bb68*/ System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                /*0x380bb68*/ System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x380bb68*/ System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x380bb68*/ System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);
            }

            class ReflectionMember
            {
                /*0x10*/ System.Type <MemberType>k__BackingField;
                /*0x18*/ System.Func<object, object> <Getter>k__BackingField;
                /*0x20*/ System.Action<object, object> <Setter>k__BackingField;

                /*0x72526dc*/ ReflectionMember();
                /*0x72526ac*/ System.Type get_MemberType();
                /*0x72526b4*/ void set_MemberType(System.Type value);
                /*0x72526bc*/ System.Func<object, object> get_Getter();
                /*0x72526c4*/ void set_Getter(System.Func<object, object> value);
                /*0x72526cc*/ System.Action<object, object> get_Setter();
                /*0x72526d4*/ void set_Setter(System.Action<object, object> value);
            }

            class ReflectionObject
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <Creator>k__BackingField;
                /*0x18*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;

                static /*0x72529f4*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, string[] memberNames);
                static /*0x7252a00*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, string[] memberNames);
                /*0x72526f4*/ ReflectionObject(Newtonsoft.Json.Serialization.ObjectConstructor<object> creator);
                /*0x72526e4*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_Creator();
                /*0x72526ec*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> get_Members();
                /*0x7252790*/ object GetValue(object target, string member);
                /*0x7252864*/ void SetValue(object target, string member, object value);
                /*0x7252940*/ System.Type GetType(string member);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ System.Func<object> ctor;

                    /*0x7253334*/ <>c__DisplayClass11_0();
                    /*0x7253858*/ object <Create>b__0(object[] args);
                }

                class <>c__DisplayClass11_1
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x7253628*/ <>c__DisplayClass11_1();
                    /*0x725387c*/ object <Create>b__1(object target);
                }

                class <>c__DisplayClass11_2
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x7253630*/ <>c__DisplayClass11_2();
                    /*0x7253934*/ void <Create>b__2(object target, object arg);
                }
            }

            class ReflectionUtils
            {
                static /*0x0*/ System.Type[] EmptyTypes;

                static /*0x72539f8*/ ReflectionUtils();
                static /*0x7253a6c*/ bool IsVirtual(System.Reflection.PropertyInfo propertyInfo);
                static /*0x7253b4c*/ System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo);
                static /*0x7253c10*/ bool IsPublic(System.Reflection.PropertyInfo property);
                static /*0x7244aa4*/ System.Type GetObjectType(object v);
                static /*0x7253ca0*/ string GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x7253d78*/ string GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x7253ea8*/ string RemoveAssemblyDetails(string fullyQualifiedTypeName);
                static /*0x7253248*/ bool HasDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x7254184*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t);
                static /*0x7254050*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x7244658*/ bool IsNullable(System.Type t);
                static /*0x7242a14*/ bool IsNullableType(System.Type t);
                static /*0x72541dc*/ System.Type EnsureNotNullableType(System.Type t);
                static /*0x7254250*/ System.Type EnsureNotByRefType(System.Type t);
                static /*0x72542a0*/ bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x7241998*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x7254328*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, ref System.Type implementingType);
                static /*0x72545b0*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition);
                static /*0x7254624*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x725478c*/ bool InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x72548a8*/ System.Type GetCollectionItemType(System.Type type);
                static /*0x7254abc*/ void GetDictionaryKeyValueTypes(System.Type dictionaryType, ref System.Type keyType, ref System.Type valueType);
                static /*0x7253638*/ System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member);
                static /*0x7254cf8*/ bool IsByRefLikeType(System.Type type);
                static /*0x7255304*/ bool IsIndexedProperty(System.Reflection.PropertyInfo property);
                static /*0x725537c*/ object GetMemberValue(System.Reflection.MemberInfo member, object target);
                static /*0x7255688*/ void SetMemberValue(System.Reflection.MemberInfo member, object target, object value);
                static /*0x7253358*/ bool CanReadMemberValue(System.Reflection.MemberInfo member, bool nonPublic);
                static /*0x72534a4*/ bool CanSetMemberValue(System.Reflection.MemberInfo member, bool nonPublic, bool canSetReadOnly);
                static /*0x7255898*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x7256750*/ bool IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr);
                static /*0x3907c14*/ T GetAttribute<T>(object attributeProvider);
                static /*0x3907c14*/ T GetAttribute<T>(object attributeProvider, bool inherit);
                static /*0x382fccc*/ T[] GetAttributes<T>(object attributeProvider, bool inherit);
                static /*0x7254e00*/ System.Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit);
                static /*0x725691c*/ Newtonsoft.Json.Utilities.StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName);
                static /*0x7256a10*/ System.Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName);
                static /*0x7256c78*/ System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo);
                static /*0x725633c*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x7256ee4*/ void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x7256454*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x72570cc*/ System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag);
                static /*0x72570dc*/ void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x725769c*/ bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method);
                static /*0x72577b8*/ object GetDefaultValue(System.Type type);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__11_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__31_0;
                    static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__39_0;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, bool> <>9__41_0;

                    static /*0x72579c8*/ <>c();
                    /*0x7257a30*/ <>c();
                    /*0x7257a38*/ bool <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c);
                    /*0x7257aa4*/ string <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m);
                    /*0x7257ac8*/ System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p);
                    /*0x7257aec*/ bool <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Reflection.MemberInfo memberInfo;

                    /*0x7256748*/ <>c__DisplayClass31_0();
                    /*0x7257b04*/ bool <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m);
                }

                class <>c__DisplayClass44_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo subTypeProperty;

                    /*0x725768c*/ <>c__DisplayClass44_0();
                    /*0x7257b80*/ bool <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p);
                    /*0x7257bd4*/ bool <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass44_1
                {
                    /*0x10*/ System.Type subTypePropertyDeclaringType;
                    /*0x18*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> CS$<>8__locals1;

                    /*0x7257694*/ <>c__DisplayClass44_1();
                    /*0x7257ca0*/ bool <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ string method;
                    /*0x18*/ System.Type methodDeclaringType;

                    /*0x72577b0*/ <>c__DisplayClass45_0();
                    /*0x7257dac*/ bool <IsMethodOverridden>b__0(System.Reflection.MethodInfo info);
                }
            }

            struct StringBuffer
            {
                /*0x10*/ char[] _buffer;
                /*0x18*/ int _position;

                /*0x7257ec0*/ StringBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int initalSize);
                /*0x7257ef0*/ StringBuffer(char[] buffer);
                /*0x7257ea0*/ int get_Position();
                /*0x7257ea8*/ void set_Position(int value);
                /*0x7257eb0*/ bool get_IsEmpty();
                /*0x7257f0c*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char value);
                /*0x7257fec*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count);
                /*0x725806c*/ void Clear(Newtonsoft.Json.IArrayPool<char> bufferPool);
                /*0x7257f84*/ void EnsureSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int appendLength);
                /*0x72580a4*/ string ToString();
                /*0x72580bc*/ string ToString(int start, int length);
                /*0x72580d8*/ char[] get_InternalBuffer();
            }

            struct StringReference
            {
                /*0x10*/ char[] _chars;
                /*0x18*/ int _startIndex;
                /*0x1c*/ int _length;

                /*0x72492ec*/ StringReference(char[] chars, int startIndex, int length);
                /*0x7248c08*/ char get_Item(int i);
                /*0x72580e0*/ char[] get_Chars();
                /*0x72580e8*/ int get_StartIndex();
                /*0x72580f0*/ int get_Length();
                /*0x7248f30*/ string ToString();
            }

            class StringReferenceExtensions
            {
                static /*0x7249b70*/ int IndexOf(Newtonsoft.Json.Utilities.StringReference s, char c, int startIndex, int length);
                static /*0x7248c38*/ bool StartsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
                static /*0x7248cf8*/ bool EndsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
            }

            class StringUtils
            {
                static /*0x7248f28*/ bool IsNullOrEmpty(string value);
                static /*0x7243240*/ string FormatWith(string format, System.IFormatProvider provider, object arg0);
                static /*0x72443a4*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1);
                static /*0x7258164*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2);
                static /*0x7258290*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2, object arg3);
                static /*0x72580f8*/ string FormatWith(string format, System.IFormatProvider provider, object[] args);
                static /*0x7251454*/ System.IO.StringWriter CreateStringWriter(int capacity);
                static /*0x7251170*/ void ToCharAsUnicode(char c, char[] buffer);
                static /*0x3907c14*/ TSource ForgivingCaseSensitiveFind<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, string> valueSelector, string testValue);
                static /*0x72583fc*/ string ToCamelCase(string s);
                static /*0x72585c0*/ char ToLower(char c);
                static /*0x7258644*/ string ToSnakeCase(string s);
                static /*0x7258928*/ string ToKebabCase(string s);
                static /*0x725864c*/ string ToSeparatedCase(string s, char separator);
                static /*0x7258930*/ bool IsHighSurrogate(char c);
                static /*0x7258964*/ bool IsLowSurrogate(char c);
                static /*0x72525f0*/ int IndexOf(string s, char c);
                static /*0x7258998*/ bool StartsWith(string source, char value);
                static /*0x72589dc*/ bool EndsWith(string source, char value);
                static /*0x7256ae8*/ string Trim(string s, int start, int length);

                enum SeparatedCaseState
                {
                    Start = 0,
                    Lower = 1,
                    Upper = 2,
                    NewWord = 3,
                }

                class <>c__DisplayClass14_0<TSource>
                {
                    /*0x0*/ System.Func<TSource, string> valueSelector;
                    /*0x0*/ string testValue;

                    /*0x380cb08*/ <>c__DisplayClass14_0();
                    /*0x3907c14*/ bool <ForgivingCaseSensitiveFind>b__0(TSource s);
                    /*0x3907c14*/ bool <ForgivingCaseSensitiveFind>b__1(TSource s);
                }
            }

            struct StructMultiKey<T1, T2> : System.IEquatable<Newtonsoft.Json.Utilities.StructMultiKey<T1, T2>>
            {
                /*0x0*/ T1 Value1;
                /*0x0*/ T2 Value2;

                /*0x3907c14*/ StructMultiKey(T1 v1, T2 v2);
                /*0x380b6a0*/ int GetHashCode();
                /*0x380b2f0*/ bool Equals(object obj);
                /*0x3907c14*/ bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1, T2> other);
            }

            class ThreadSafeStore<TKey, TValue>
            {
                /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> _concurrentStore;
                /*0x0*/ System.Func<TKey, TValue> _creator;

                /*0x380d83c*/ ThreadSafeStore(System.Func<TKey, TValue> creator);
                /*0x3907c14*/ TValue Get(TKey key);
            }

            class TypeExtensions
            {
                static /*0x725333c*/ System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo);
                static /*0x7258a1c*/ bool ContainsGenericParameters(System.Type type);
                static /*0x72448fc*/ bool IsInterface(System.Type type);
                static /*0x724e944*/ bool IsGenericType(System.Type type);
                static /*0x7244910*/ bool IsGenericTypeDefinition(System.Type type);
                static /*0x7254888*/ System.Type BaseType(System.Type type);
                static /*0x724e96c*/ System.Reflection.Assembly Assembly(System.Type type);
                static /*0x72429f4*/ bool IsEnum(System.Type type);
                static /*0x7254778*/ bool IsClass(System.Type type);
                static /*0x7258a3c*/ bool IsSealed(System.Type type);
                static /*0x7244930*/ bool IsAbstract(System.Type type);
                static /*0x7258a50*/ bool IsVisible(System.Type type);
                static /*0x725403c*/ bool IsValueType(System.Type type);
                static /*0x7258a64*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces, ref System.Type match);
                static /*0x7258bc8*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces);
                static /*0x7258be8*/ bool ImplementInterface(System.Type type, System.Type interfaceType);
            }

            class ValidationUtils
            {
                static /*0x7240744*/ void ArgumentNotNull(object value, string parameterName);
            }
        }

        namespace Serialization
        {
            class CachedAttributeGetter<T>
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<object, T> TypeAttributeCache;

                static /*0x38358cc*/ CachedAttributeGetter();
                static /*0x3907c14*/ T GetAttribute(object type);
            }

            class CamelCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x7258fc8*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x7259000*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x724d5ac*/ CamelCaseNamingStrategy();
                /*0x725904c*/ string ResolvePropertyName(string name);
            }

            class DefaultContractResolver : Newtonsoft.Json.Serialization.IContractResolver
            {
                static /*0x0*/ Newtonsoft.Json.Serialization.IContractResolver _instance;
                static /*0x8*/ string[] BlacklistedTypeNames;
                static /*0x10*/ Newtonsoft.Json.JsonConverter[] BuiltInConverters;
                /*0x10*/ Newtonsoft.Json.DefaultJsonNameTable _nameTable;
                /*0x18*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Serialization.JsonContract> _contractCache;
                /*0x20*/ System.Reflection.BindingFlags <DefaultMembersSearchFlags>k__BackingField;
                /*0x24*/ bool <SerializeCompilerGeneratedMembers>k__BackingField;
                /*0x25*/ bool <IgnoreSerializableInterface>k__BackingField;
                /*0x26*/ bool <IgnoreSerializableAttribute>k__BackingField;
                /*0x27*/ bool <IgnoreIsSpecifiedMembers>k__BackingField;
                /*0x28*/ bool <IgnoreShouldSerializeMembers>k__BackingField;
                /*0x30*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;

                static /*0x726021c*/ DefaultContractResolver();
                static /*0x7259054*/ Newtonsoft.Json.Serialization.IContractResolver get_Instance();
                static /*0x7259288*/ bool FilterMembers(System.Reflection.MemberInfo member);
                static /*0x725bd10*/ void ThrowUnableToSerializeError(object o, System.Runtime.Serialization.StreamingContext context);
                static /*0x725b498*/ void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member);
                static /*0x725de6c*/ bool IsConcurrentOrObservableCollection(System.Type t);
                static /*0x725d754*/ bool ShouldSkipDeserialized(System.Type t);
                static /*0x725d680*/ bool ShouldSkipSerializing(System.Type t);
                static /*0x725f208*/ bool IsJsonPrimitiveType(System.Type t);
                static /*0x725f360*/ bool IsIConvertible(System.Type t);
                static /*0x725f268*/ bool CanConvertToString(System.Type type);
                static /*0x725d828*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                static /*0x725f4cc*/ string GetClrTypeFullName(System.Type type);
                /*0x72590f8*/ DefaultContractResolver();
                /*0x72590ac*/ System.Reflection.BindingFlags get_DefaultMembersSearchFlags();
                /*0x72590b4*/ void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value);
                /*0x72590bc*/ bool get_SerializeCompilerGeneratedMembers();
                /*0x72590c4*/ bool get_IgnoreSerializableInterface();
                /*0x72590cc*/ bool get_IgnoreSerializableAttribute();
                /*0x72590d4*/ void set_IgnoreSerializableAttribute(bool value);
                /*0x72590e0*/ bool get_IgnoreIsSpecifiedMembers();
                /*0x72590e8*/ bool get_IgnoreShouldSerializeMembers();
                /*0x72590f0*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x7259208*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
                /*0x72593cc*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType);
                /*0x725a164*/ bool ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo);
                /*0x725a26c*/ Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType);
                /*0x725b2cc*/ System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type);
                /*0x725aac0*/ System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType);
                /*0x725b018*/ System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x725afd0*/ System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType);
                /*0x725bfb4*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x725bf3c*/ Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, string name, System.Type type);
                /*0x725c130*/ Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo);
                /*0x725ca9c*/ Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType);
                /*0x725caf4*/ System.Func<object> GetDefaultCreator(System.Type createdType);
                /*0x725a85c*/ void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x725cb94*/ void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t);
                /*0x725ccd4*/ void GetCallbackMethodsForType(System.Type type, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> onError);
                /*0x725bda4*/ System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type);
                /*0x725dfb4*/ Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType);
                /*0x725e524*/ Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType);
                /*0x725e860*/ Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType);
                /*0x725e8d4*/ Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType);
                /*0x725e948*/ Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType);
                /*0x725eb84*/ Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType);
                /*0x725ed9c*/ Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType);
                /*0x725ee10*/ Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType);
                /*0x725f5cc*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x725f9ec*/ Newtonsoft.Json.DefaultJsonNameTable GetNameTable();
                /*0x725f9f4*/ Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member);
                /*0x725fa50*/ Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x725c3e4*/ void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, object attributeProvider, string name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, ref bool allowNonPublicAccess);
                /*0x725fc68*/ System.Predicate<object> CreateShouldSerializeTest(System.Reflection.MemberInfo member);
                /*0x725feac*/ void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, bool allowNonPublicAccess);
                /*0x72601a4*/ string ResolvePropertyName(string propertyName);
                /*0x72601c4*/ string ResolveExtensionDataName(string extensionDataName);
                /*0x72601e0*/ string ResolveDictionaryKey(string dictionaryKey);
                /*0x726020c*/ string GetResolvedPropertyName(string propertyName);

                class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    /*0x380d83c*/ EnumerableDictionaryWrapper(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class <GetEnumerator>d__<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ System.Collections.Generic.KeyValuePair<object, object> <>2__current;
                        /*0x0*/ Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;
                        /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;

                        /*0x380cffc*/ <GetEnumerator>d__(int <>1__state);
                        /*0x380cb08*/ void System.IDisposable.Dispose();
                        /*0x380b128*/ bool MoveNext();
                        /*0x380cb08*/ void <>m__Finally1();
                        System.Collections.Generic.KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current();
                        /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MemberInfo, bool> <>9__40_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, bool> <>9__40_1;
                    static /*0x18*/ System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>> <>9__44_0;
                    static /*0x20*/ System.Func<System.Reflection.MemberInfo, bool> <>9__44_1;
                    static /*0x28*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__47_0;
                    static /*0x30*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, int> <>9__75_0;

                    static /*0x7260740*/ <>c();
                    /*0x72607a8*/ <>c();
                    /*0x72607b0*/ bool <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m);
                    /*0x7260864*/ bool <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m);
                    /*0x72608d4*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType);
                    /*0x72609b4*/ bool <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m);
                    /*0x7260d74*/ bool <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c);
                    /*0x7260df8*/ int <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p);
                }

                class <>c__DisplayClass42_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x7260e50*/ <>c__DisplayClass42_0();
                    /*0x7260e58*/ string <CreateObjectContract>b__0(string s);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ System.Func<object, object> getExtensionDataDictionary;
                    /*0x18*/ System.Reflection.MemberInfo member;

                    /*0x7260e78*/ <>c__DisplayClass45_0();
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ System.Action<object, object> setExtensionDataDictionary;
                    /*0x18*/ System.Func<object> createExtensionDataDictionary;
                    /*0x20*/ Newtonsoft.Json.Utilities.MethodCall<object, object> setExtensionDataDictionaryValue;
                    /*0x28*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals1;

                    /*0x7260e80*/ <>c__DisplayClass45_1();
                    /*0x7260e88*/ void <SetExtensionDataDelegates>b__0(object o, string key, object value);
                }

                class <>c__DisplayClass45_2
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> createEnumerableWrapper;
                    /*0x18*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals2;

                    /*0x7261094*/ <>c__DisplayClass45_2();
                    /*0x726109c*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o);
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x72611b4*/ <>c__DisplayClass62_0();
                    /*0x72611bc*/ string <CreateDictionaryContract>b__0(string s);
                }

                class <>c__DisplayClass67_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x72611dc*/ <>c__DisplayClass67_0();
                    /*0x72611e4*/ string <CreateDynamicContract>b__0(string s);
                }

                class <>c__DisplayClass80_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> shouldSerializeCall;

                    /*0x7261204*/ <>c__DisplayClass80_0();
                    /*0x726120c*/ bool <CreateShouldSerializeTest>b__0(object o);
                }

                class <>c__DisplayClass81_0
                {
                    /*0x10*/ System.Func<object, object> specifiedPropertyGet;

                    /*0x72612f8*/ <>c__DisplayClass81_0();
                    /*0x7261300*/ bool <SetIsSpecifiedActions>b__0(object o);
                }
            }

            class DefaultNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x7261360*/ DefaultNamingStrategy();
                /*0x7261358*/ string ResolvePropertyName(string name);
            }

            class DefaultReferenceResolver : Newtonsoft.Json.Serialization.IReferenceResolver
            {
                /*0x10*/ int _referenceCount;

                /*0x72617cc*/ DefaultReferenceResolver();
                /*0x7261368*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> GetMappings(object context);
                /*0x7261584*/ object ResolveReference(object context, string reference);
                /*0x72615f8*/ string GetReference(object context, object value);
                /*0x72616ec*/ void AddReference(object context, string reference, object value);
                /*0x7261758*/ bool IsReferenced(object context, object value);
            }

            class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder, Newtonsoft.Json.Serialization.ISerializationBinder
            {
                static /*0x0*/ Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
                /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<string, string>, System.Type> _typeCache;

                static /*0x72620a8*/ DefaultSerializationBinder();
                /*0x72617d4*/ DefaultSerializationBinder();
                /*0x72618ac*/ System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x7261c94*/ System.Type GetGenericTypeFromTypeName(string typeName, System.Reflection.Assembly assembly);
                /*0x7261f48*/ System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x7261fb0*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x726202c*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            class ErrorContext
            {
                /*0x10*/ bool <Traced>k__BackingField;
                /*0x18*/ System.Exception <Error>k__BackingField;
                /*0x20*/ object <OriginalObject>k__BackingField;
                /*0x28*/ object <Member>k__BackingField;
                /*0x30*/ string <Path>k__BackingField;
                /*0x38*/ bool <Handled>k__BackingField;

                /*0x726210c*/ ErrorContext(object originalObject, object member, string path, System.Exception error);
                /*0x7262180*/ bool get_Traced();
                /*0x7262188*/ void set_Traced(bool value);
                /*0x7262194*/ System.Exception get_Error();
                /*0x726219c*/ bool get_Handled();
            }

            class ErrorEventArgs : System.EventArgs
            {
                /*0x10*/ object <CurrentObject>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;

                /*0x72621a4*/ ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            interface IAttributeProvider
            {
            }

            interface IContractResolver
            {
                /*0x380bb68*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
            }

            interface IReferenceResolver
            {
                /*0x380bcbc*/ object ResolveReference(object context, string reference);
                /*0x380bcbc*/ string GetReference(object context, object value);
                /*0x380b32c*/ bool IsReferenced(object context, object value);
                /*0x380da4c*/ void AddReference(object context, string reference, object value);
            }

            interface ISerializationBinder
            {
                /*0x380bcbc*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x380da4c*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            interface ITraceWriter
            {
                /*0x380b6a0*/ System.Diagnostics.TraceLevel get_LevelFilter();
                void Trace(System.Diagnostics.TraceLevel level, string message, System.Exception ex);
            }

            interface IValueProvider
            {
                /*0x380d93c*/ void SetValue(object target, object value);
                /*0x380bb68*/ object GetValue(object target);
            }

            class JsonArrayContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ System.Type <CollectionItemType>k__BackingField;
                /*0xc8*/ bool <IsMultidimensionalArray>k__BackingField;
                /*0xd0*/ System.Type _genericCollectionDefinitionType;
                /*0xd8*/ System.Type _genericWrapperType;
                /*0xe0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _genericWrapperCreator;
                /*0xe8*/ System.Func<object> _genericTemporaryCollectionCreator;
                /*0xf0*/ bool <IsArray>k__BackingField;
                /*0xf1*/ bool <ShouldCreateWrapper>k__BackingField;
                /*0xf2*/ bool <CanDeserialize>k__BackingField;
                /*0xf8*/ System.Reflection.ConstructorInfo _parameterizedConstructor;
                /*0x100*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _parameterizedCreator;
                /*0x108*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _overrideCreator;
                /*0x110*/ bool <HasParameterizedCreator>k__BackingField;

                /*0x72623ec*/ JsonArrayContract(System.Type underlyingType);
                /*0x726222c*/ System.Type get_CollectionItemType();
                /*0x7262234*/ bool get_IsMultidimensionalArray();
                /*0x726223c*/ bool get_IsArray();
                /*0x7262244*/ bool get_ShouldCreateWrapper();
                /*0x726224c*/ bool get_CanDeserialize();
                /*0x7262254*/ void set_CanDeserialize(bool value);
                /*0x7262260*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x726232c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x7262334*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x7262358*/ bool get_HasParameterizedCreator();
                /*0x7262360*/ void set_HasParameterizedCreator(bool value);
                /*0x726236c*/ bool get_HasParameterizedCreatorInternal();
                /*0x72634b8*/ Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(object list);
                /*0x72638c8*/ System.Collections.IList CreateTemporaryCollection();
                /*0x7263398*/ void StoreFSharpListCreatorIfNecessary(System.Type underlyingType);
            }

            class JsonContainerContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x90*/ Newtonsoft.Json.Serialization.JsonContract _itemContract;
                /*0x98*/ Newtonsoft.Json.Serialization.JsonContract _finalItemContract;
                /*0xa0*/ Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;
                /*0xa8*/ System.Nullable<bool> <ItemIsReference>k__BackingField;
                /*0xac*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;
                /*0xb4*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;

                /*0x72631d4*/ JsonContainerContract(System.Type underlyingType);
                /*0x7263b10*/ Newtonsoft.Json.Serialization.JsonContract get_ItemContract();
                /*0x7263b18*/ void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x7263b78*/ Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract();
                /*0x7263b80*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x7263b88*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x7263b90*/ System.Nullable<bool> get_ItemIsReference();
                /*0x7263b98*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x7263ba0*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x7263ba8*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x7263bb0*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x7263bb8*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
            }

            enum JsonContractType
            {
                None = 0,
                Object = 1,
                Array = 2,
                Primitive = 3,
                String = 4,
                Dictionary = 5,
                Dynamic = 6,
                Serializable = 7,
                Linq = 8,
            }

            class SerializationCallback : System.MulticastDelegate
            {
                /*0x7263d3c*/ SerializationCallback(object object, nint method);
                /*0x7263e48*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context);
            }

            class SerializationErrorCallback : System.MulticastDelegate
            {
                /*0x7263e5c*/ SerializationErrorCallback(object object, nint method);
                /*0x7263f68*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            class ExtensionDataSetter : System.MulticastDelegate
            {
                /*0x7263f7c*/ ExtensionDataSetter(object object, nint method);
                /*0x7264088*/ void Invoke(object o, string key, object value);
            }

            class ExtensionDataGetter : System.MulticastDelegate
            {
                /*0x726409c*/ ExtensionDataGetter(object object, nint method);
                /*0x72641a4*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> Invoke(object o);
            }

            class JsonContract
            {
                /*0x10*/ bool IsNullable;
                /*0x11*/ bool IsConvertable;
                /*0x12*/ bool IsEnum;
                /*0x18*/ System.Type NonNullableUnderlyingType;
                /*0x20*/ Newtonsoft.Json.ReadType InternalReadType;
                /*0x24*/ Newtonsoft.Json.Serialization.JsonContractType ContractType;
                /*0x28*/ bool IsReadOnlyOrFixedSize;
                /*0x29*/ bool IsSealed;
                /*0x2a*/ bool IsInstantiable;
                /*0x30*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks;
                /*0x38*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks;
                /*0x40*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks;
                /*0x48*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks;
                /*0x50*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks;
                /*0x58*/ System.Type _createdType;
                /*0x60*/ System.Type <UnderlyingType>k__BackingField;
                /*0x68*/ System.Nullable<bool> <IsReference>k__BackingField;
                /*0x70*/ Newtonsoft.Json.JsonConverter <Converter>k__BackingField;
                /*0x78*/ Newtonsoft.Json.JsonConverter <InternalConverter>k__BackingField;
                /*0x80*/ System.Func<object> <DefaultCreator>k__BackingField;
                /*0x88*/ bool <DefaultCreatorNonPublic>k__BackingField;

                static /*0x7264ba0*/ Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo);
                static /*0x7264c60*/ Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo);
                /*0x7263bc0*/ JsonContract(System.Type underlyingType);
                /*0x72641b8*/ System.Type get_UnderlyingType();
                /*0x72641c0*/ System.Type get_CreatedType();
                /*0x72632e0*/ void set_CreatedType(System.Type value);
                /*0x72641c8*/ System.Nullable<bool> get_IsReference();
                /*0x72641d0*/ void set_IsReference(System.Nullable<bool> value);
                /*0x72641d8*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x72641e0*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x72641e8*/ Newtonsoft.Json.JsonConverter get_InternalConverter();
                /*0x72641f0*/ void set_InternalConverter(Newtonsoft.Json.JsonConverter value);
                /*0x72641f8*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks();
                /*0x726427c*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks();
                /*0x7264300*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks();
                /*0x7264384*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks();
                /*0x7264408*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks();
                /*0x726448c*/ System.Func<object> get_DefaultCreator();
                /*0x7264494*/ void set_DefaultCreator(System.Func<object> value);
                /*0x726449c*/ bool get_DefaultCreatorNonPublic();
                /*0x72644a4*/ void set_DefaultCreatorNonPublic(bool value);
                /*0x72644b0*/ void InvokeOnSerializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x7264610*/ void InvokeOnSerialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x7264770*/ void InvokeOnDeserializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x72648d0*/ void InvokeOnDeserialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x7264a30*/ void InvokeOnError(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);

                class <>c__DisplayClass57_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x7264c58*/ <>c__DisplayClass57_0();
                    /*0x7264d20*/ void <CreateSerializationCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context);
                }

                class <>c__DisplayClass58_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x7264d18*/ <>c__DisplayClass58_0();
                    /*0x7264e20*/ void <CreateSerializationErrorCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext);
                }
            }

            class JsonDictionaryContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ System.Func<string, string> <DictionaryKeyResolver>k__BackingField;
                /*0xc8*/ System.Type <DictionaryKeyType>k__BackingField;
                /*0xd0*/ System.Type <DictionaryValueType>k__BackingField;
                /*0xd8*/ Newtonsoft.Json.Serialization.JsonContract <KeyContract>k__BackingField;
                /*0xe0*/ System.Type _genericCollectionDefinitionType;
                /*0xe8*/ System.Type _genericWrapperType;
                /*0xf0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _genericWrapperCreator;
                /*0xf8*/ System.Func<object> _genericTemporaryDictionaryCreator;
                /*0x100*/ bool <ShouldCreateWrapper>k__BackingField;
                /*0x108*/ System.Reflection.ConstructorInfo _parameterizedConstructor;
                /*0x110*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _overrideCreator;
                /*0x118*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _parameterizedCreator;
                /*0x120*/ bool <HasParameterizedCreator>k__BackingField;

                /*0x7265110*/ JsonDictionaryContract(System.Type underlyingType);
                /*0x7264f60*/ System.Func<string, string> get_DictionaryKeyResolver();
                /*0x7264f68*/ void set_DictionaryKeyResolver(System.Func<string, string> value);
                /*0x7264f70*/ System.Type get_DictionaryKeyType();
                /*0x7264f78*/ System.Type get_DictionaryValueType();
                /*0x7264f80*/ Newtonsoft.Json.Serialization.JsonContract get_KeyContract();
                /*0x7264f88*/ void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x7264f90*/ bool get_ShouldCreateWrapper();
                /*0x7264f98*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x7265064*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x726506c*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x726507c*/ bool get_HasParameterizedCreator();
                /*0x7265084*/ void set_HasParameterizedCreator(bool value);
                /*0x7265090*/ bool get_HasParameterizedCreatorInternal();
                /*0x7265b58*/ Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(object dictionary);
                /*0x7265e20*/ System.Collections.IDictionary CreateTemporaryDictionary();
            }

            class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;
                /*0xc8*/ System.Func<string, string> <PropertyNameResolver>k__BackingField;
                /*0xd0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>> _callSiteGetters;
                /*0xd8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>> _callSiteSetters;

                static /*0x72660c8*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>> CreateCallSiteGetter(string name);
                static /*0x72661e0*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>> CreateCallSiteSetter(string name);
                /*0x72662f8*/ JsonDynamicContract(System.Type underlyingType);
                /*0x72660b0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x72660b8*/ System.Func<string, string> get_PropertyNameResolver();
                /*0x72660c0*/ void set_PropertyNameResolver(System.Func<string, string> value);
                /*0x7266638*/ bool TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, ref object value);
                /*0x726675c*/ bool TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, object value);
            }

            class JsonFormatterConverter : System.Runtime.Serialization.IFormatterConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;
                /*0x18*/ Newtonsoft.Json.Serialization.JsonISerializableContract _contract;
                /*0x20*/ Newtonsoft.Json.Serialization.JsonProperty _member;

                /*0x726685c*/ JsonFormatterConverter(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x3907c14*/ T GetTokenValue<T>(object value);
                /*0x7266924*/ object Convert(object value, System.Type type);
                /*0x7266b60*/ bool ToBoolean(object value);
                /*0x7266bb8*/ byte ToByte(object value);
                /*0x7266c10*/ int ToInt32(object value);
                /*0x7266c68*/ long ToInt64(object value);
                /*0x7266cc0*/ float ToSingle(object value);
                /*0x7266d18*/ string ToString(object value);
            }

            class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <ISerializableCreator>k__BackingField;

                /*0x7266d80*/ JsonISerializableContract(System.Type underlyingType);
                /*0x7266d70*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ISerializableCreator();
                /*0x7266d78*/ void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
            }

            class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x7266d9c*/ JsonLinqContract(System.Type underlyingType);
            }

            class JsonObjectContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xbc*/ Newtonsoft.Json.MemberSerialization <MemberSerialization>k__BackingField;
                /*0xc0*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> <MissingMemberHandling>k__BackingField;
                /*0xc8*/ System.Nullable<Newtonsoft.Json.Required> <ItemRequired>k__BackingField;
                /*0xd0*/ System.Nullable<Newtonsoft.Json.NullValueHandling> <ItemNullValueHandling>k__BackingField;
                /*0xd8*/ Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;
                /*0xe0*/ Newtonsoft.Json.Serialization.ExtensionDataSetter <ExtensionDataSetter>k__BackingField;
                /*0xe8*/ Newtonsoft.Json.Serialization.ExtensionDataGetter <ExtensionDataGetter>k__BackingField;
                /*0xf0*/ System.Func<string, string> <ExtensionDataNameResolver>k__BackingField;
                /*0xf8*/ bool ExtensionDataIsJToken;
                /*0xf9*/ System.Nullable<bool> _hasRequiredOrDefaultValueProperties;
                /*0x100*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _overrideCreator;
                /*0x108*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> _parameterizedCreator;
                /*0x110*/ Newtonsoft.Json.Serialization.JsonPropertyCollection _creatorParameters;
                /*0x118*/ System.Type _extensionDataValueType;

                /*0x7267400*/ JsonObjectContract(System.Type underlyingType);
                /*0x7266db8*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
                /*0x7266dc0*/ void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value);
                /*0x7266dc8*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling();
                /*0x7266dd0*/ void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value);
                /*0x7266dd8*/ System.Nullable<Newtonsoft.Json.Required> get_ItemRequired();
                /*0x7266de0*/ void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value);
                /*0x7266de8*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling();
                /*0x7266df0*/ void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x7266df8*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x7266e00*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters();
                /*0x7266e80*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x7266e88*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x7266e98*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x7266ea0*/ void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x7266eb0*/ Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter();
                /*0x7266eb8*/ void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value);
                /*0x7266ec0*/ Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter();
                /*0x7266ec8*/ void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value);
                /*0x7266ed0*/ void set_ExtensionDataValueType(System.Type value);
                /*0x7266f9c*/ System.Func<string, string> get_ExtensionDataNameResolver();
                /*0x7266fa4*/ void set_ExtensionDataNameResolver(System.Func<string, string> value);
                /*0x7266fac*/ bool get_HasRequiredOrDefaultValueProperties();
                /*0x7267484*/ object GetUninitializedObject();
            }

            class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Newtonsoft.Json.ReadType> ReadTypeMap;
                /*0x8c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;

                static /*0x726768c*/ JsonPrimitiveContract();
                /*0x7267598*/ JsonPrimitiveContract(System.Type underlyingType);
                /*0x7267588*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
                /*0x7267590*/ void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value);
            }

            class JsonProperty
            {
                /*0x10*/ System.Nullable<Newtonsoft.Json.Required> _required;
                /*0x18*/ bool _hasExplicitDefaultValue;
                /*0x20*/ object _defaultValue;
                /*0x28*/ bool _hasGeneratedDefaultValue;
                /*0x30*/ string _propertyName;
                /*0x38*/ bool _skipPropertyNameEscape;
                /*0x40*/ System.Type _propertyType;
                /*0x48*/ Newtonsoft.Json.Serialization.JsonContract <PropertyContract>k__BackingField;
                /*0x50*/ System.Type <DeclaringType>k__BackingField;
                /*0x58*/ System.Nullable<int> <Order>k__BackingField;
                /*0x60*/ string <UnderlyingName>k__BackingField;
                /*0x68*/ Newtonsoft.Json.Serialization.IValueProvider <ValueProvider>k__BackingField;
                /*0x70*/ Newtonsoft.Json.Serialization.IAttributeProvider <AttributeProvider>k__BackingField;
                /*0x78*/ Newtonsoft.Json.JsonConverter <Converter>k__BackingField;
                /*0x80*/ bool <Ignored>k__BackingField;
                /*0x81*/ bool <Readable>k__BackingField;
                /*0x82*/ bool <Writable>k__BackingField;
                /*0x83*/ bool <HasMemberAttribute>k__BackingField;
                /*0x84*/ System.Nullable<bool> <IsReference>k__BackingField;
                /*0x88*/ System.Nullable<Newtonsoft.Json.NullValueHandling> <NullValueHandling>k__BackingField;
                /*0x90*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> <DefaultValueHandling>k__BackingField;
                /*0x98*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField;
                /*0xa0*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> <ObjectCreationHandling>k__BackingField;
                /*0xa8*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <TypeNameHandling>k__BackingField;
                /*0xb0*/ System.Predicate<object> <ShouldSerialize>k__BackingField;
                /*0xb8*/ System.Predicate<object> <ShouldDeserialize>k__BackingField;
                /*0xc0*/ System.Predicate<object> <GetIsSpecified>k__BackingField;
                /*0xc8*/ System.Action<object, object> <SetIsSpecified>k__BackingField;
                /*0xd0*/ Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;
                /*0xd8*/ System.Nullable<bool> <ItemIsReference>k__BackingField;
                /*0xdc*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;
                /*0xe4*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;

                /*0x7267d5c*/ JsonProperty();
                /*0x7267954*/ Newtonsoft.Json.Serialization.JsonContract get_PropertyContract();
                /*0x726795c*/ void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x7267964*/ string get_PropertyName();
                /*0x726796c*/ void set_PropertyName(string value);
                /*0x7267a04*/ System.Type get_DeclaringType();
                /*0x7267a0c*/ void set_DeclaringType(System.Type value);
                /*0x7267a14*/ System.Nullable<int> get_Order();
                /*0x7267a1c*/ void set_Order(System.Nullable<int> value);
                /*0x7267a24*/ string get_UnderlyingName();
                /*0x7267a2c*/ void set_UnderlyingName(string value);
                /*0x7267a34*/ Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider();
                /*0x7267a3c*/ void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value);
                /*0x7267a44*/ void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value);
                /*0x7267a4c*/ System.Type get_PropertyType();
                /*0x7267a54*/ void set_PropertyType(System.Type value);
                /*0x7267ac0*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x7267ac8*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x7267ad0*/ bool get_Ignored();
                /*0x7267ad8*/ void set_Ignored(bool value);
                /*0x7267ae4*/ bool get_Readable();
                /*0x7267aec*/ void set_Readable(bool value);
                /*0x7267af8*/ bool get_Writable();
                /*0x7267b00*/ void set_Writable(bool value);
                /*0x7267b0c*/ bool get_HasMemberAttribute();
                /*0x7267b14*/ void set_HasMemberAttribute(bool value);
                /*0x7267b20*/ object get_DefaultValue();
                /*0x7267b38*/ void set_DefaultValue(object value);
                /*0x7267b48*/ object GetResolvedDefaultValue();
                /*0x72673c4*/ Newtonsoft.Json.Required get_Required();
                /*0x7267c10*/ System.Nullable<bool> get_IsReference();
                /*0x7267c18*/ void set_IsReference(System.Nullable<bool> value);
                /*0x7267c20*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling();
                /*0x7267c28*/ void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x7267c30*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling();
                /*0x7267c38*/ void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value);
                /*0x7267c40*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling();
                /*0x7267c48*/ void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x7267c50*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling();
                /*0x7267c58*/ void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value);
                /*0x7267c60*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling();
                /*0x7267c68*/ void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x7267c70*/ System.Predicate<object> get_ShouldSerialize();
                /*0x7267c78*/ void set_ShouldSerialize(System.Predicate<object> value);
                /*0x7267c80*/ System.Predicate<object> get_ShouldDeserialize();
                /*0x7267c88*/ System.Predicate<object> get_GetIsSpecified();
                /*0x7267c90*/ void set_GetIsSpecified(System.Predicate<object> value);
                /*0x7267c98*/ System.Action<object, object> get_SetIsSpecified();
                /*0x7267ca0*/ void set_SetIsSpecified(System.Action<object, object> value);
                /*0x7267ca8*/ string ToString();
                /*0x7267ccc*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x7267cd4*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x7267cdc*/ System.Nullable<bool> get_ItemIsReference();
                /*0x7267ce4*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x7267cec*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x7267cf4*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x7267cfc*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x7267d04*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x7267d0c*/ void WritePropertyName(Newtonsoft.Json.JsonWriter writer);
            }

            class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty>
            {
                /*0x30*/ System.Type _type;
                /*0x38*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;

                /*0x72664bc*/ JsonPropertyCollection(System.Type type);
                /*0x7267d64*/ string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x7267d7c*/ void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x726802c*/ Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName);
                /*0x7268158*/ bool TryGetProperty(string key, ref Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x726806c*/ Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType);
            }

            class JsonSerializerInternalBase
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;
                /*0x18*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> _mappings;
                /*0x20*/ Newtonsoft.Json.JsonSerializer Serializer;
                /*0x28*/ Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;
                /*0x30*/ Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;

                /*0x7268240*/ JsonSerializerInternalBase(Newtonsoft.Json.JsonSerializer serializer);
                /*0x7261474*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> get_DefaultReferenceMappings();
                /*0x72682e4*/ Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x7268370*/ Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(object currentObject, object member, string path, System.Exception error);
                /*0x7268468*/ void ClearErrorContext();
                /*0x72684cc*/ bool IsErrorHandled(object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, string path, System.Exception ex);

                class ReferenceEqualsEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
                {
                    /*0x72682dc*/ ReferenceEqualsEqualityComparer();
                    /*0x7268894*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
                    /*0x72688a0*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj);
                }
            }

            class JsonSerializerInternalReader : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                static /*0x726d4d0*/ bool CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, string s);
                /*0x72688ac*/ JsonSerializerInternalReader(Newtonsoft.Json.JsonSerializer serializer);
                /*0x72688b0*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
                /*0x726a74c*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type);
                /*0x726a7b0*/ Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type);
                /*0x726a860*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, bool checkAdditionalContent);
                /*0x726b4fc*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x726b574*/ Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x726b984*/ Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader);
                /*0x726b010*/ object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x726d5c0*/ string GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x726ab90*/ Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x726bddc*/ object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x726d678*/ bool ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x726ddd4*/ bool ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x726f6a4*/ void ResolveTypeName(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, string qualifiedTypeName);
                /*0x726fcbc*/ Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x726c904*/ object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, object existingValue, string id);
                /*0x726e494*/ bool HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x726cf48*/ object EnsureType(Newtonsoft.Json.JsonReader reader, object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType);
                /*0x7270788*/ bool SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target);
                /*0x7270c4c*/ bool CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target, ref bool useExistingValue, ref object currentValue, ref Newtonsoft.Json.Serialization.JsonContract propertyContract, ref bool gottenCurrentValue, ref bool ignoredValue);
                /*0x7271324*/ void AddReference(Newtonsoft.Json.JsonReader reader, string id, object value);
                /*0x7271318*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x727121c*/ bool ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, object value);
                /*0x726fe3c*/ System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, ref bool createdFromNonDefaultCreator);
                /*0x726e798*/ System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, ref bool createdFromNonDefaultCreator);
                /*0x72716e8*/ void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x7271914*/ void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x72692f8*/ object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x72700c4*/ object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x7271b40*/ void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object currentObject, string message);
                /*0x7268dd0*/ object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x726f004*/ object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x7266a3c*/ object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x726e9c4*/ object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x7271c74*/ object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<object> creator, string id);
                /*0x726abfc*/ object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue);
                /*0x7273938*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x726e574*/ object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id, ref bool createdFromNonDefaultCreator);
                /*0x7269cc4*/ object PopulateObject(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x72746e8*/ bool ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x726bcc0*/ bool CheckPropertyName(Newtonsoft.Json.JsonReader reader, string memberName);
                /*0x7274574*/ void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, string memberName, object o);
                /*0x72744b8*/ object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader);
                /*0x7274014*/ void EndProcessProperty(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, int initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue);
                /*0x7274940*/ void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties);
                /*0x726b494*/ void HandleError(Newtonsoft.Json.JsonReader reader, bool readPastError, int initialDepth);

                enum PropertyPresence
                {
                    None = 0,
                    Null = 1,
                    Value = 2,
                }

                class CreatorPropertyContext
                {
                    /*0x10*/ string Name;
                    /*0x18*/ Newtonsoft.Json.Serialization.JsonProperty Property;
                    /*0x20*/ Newtonsoft.Json.Serialization.JsonProperty ConstructorProperty;
                    /*0x28*/ System.Nullable<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> Presence;
                    /*0x30*/ object Value;
                    /*0x38*/ bool Used;

                    /*0x7273fe4*/ CreatorPropertyContext(string name);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_0;
                    static /*0x10*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_2;
                    static /*0x18*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0;
                    static /*0x20*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1;

                    static /*0x7274a3c*/ <>c();
                    /*0x7274aa4*/ <>c();
                    /*0x7274aac*/ string <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x7274ac4*/ string <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x7274adc*/ Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m);
                    /*0x7274ae4*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m);
                }

                class <>c__DisplayClass38_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.JsonProperty property;

                    /*0x7273fdc*/ <>c__DisplayClass38_0();
                    /*0x7274aec*/ bool <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p);
                }
            }

            class JsonSerializerInternalWriter : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                /*0x38*/ System.Type _rootType;
                /*0x40*/ int _rootLevel;
                /*0x48*/ System.Collections.Generic.List<object> _serializeStack;

                static /*0x72793f0*/ bool TryConvertToString(object value, System.Type type, ref string s);
                /*0x7274b10*/ JsonSerializerInternalWriter(Newtonsoft.Json.JsonSerializer serializer);
                /*0x7274b9c*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
                /*0x7275928*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x7274e3c*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(object value);
                /*0x72759a0*/ Newtonsoft.Json.Serialization.JsonContract GetContract(object value);
                /*0x7275a64*/ void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7275260*/ void SerializeValue(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7278af8*/ System.Nullable<bool> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7274e4c*/ bool ShouldWriteReference(object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7278bb4*/ bool ShouldWriteProperty(object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x7278c90*/ bool CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7274fe4*/ void WriteReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x7279204*/ string GetReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x72775d4*/ void SerializeString(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonStringContract contract);
                /*0x7279500*/ void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x7279704*/ void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x7276590*/ void SerializeObject(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7279a48*/ bool CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.Serialization.JsonContract memberContract, ref object memberValue);
                /*0x7279908*/ void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x727a824*/ bool HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x727a8d8*/ void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, object value);
                /*0x7275dec*/ void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type);
                /*0x7278c84*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x7278ba8*/ bool HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag);
                /*0x727ab24*/ bool HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag);
                /*0x727606c*/ void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7276ce0*/ void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x72773d4*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x727adc0*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, int initialDepth, int[] indices);
                /*0x727ab30*/ bool WriteStartArray(Newtonsoft.Json.JsonWriter writer, object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7278680*/ void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7277ee4*/ void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x727b12c*/ bool ShouldWriteDynamicProperty(object memberValue);
                /*0x7275bcc*/ bool ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7277658*/ void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7279ea0*/ string GetPropertyName(Newtonsoft.Json.JsonWriter writer, object name, Newtonsoft.Json.Serialization.JsonContract contract, ref bool escape);
                /*0x72758b4*/ void HandleError(Newtonsoft.Json.JsonWriter writer, int initialDepth);
                /*0x727a37c*/ bool ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x727a5d0*/ bool IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
            }

            class JsonSerializerProxy : Newtonsoft.Json.JsonSerializer
            {
                /*0xe0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;
                /*0xe8*/ Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;
                /*0xf0*/ Newtonsoft.Json.JsonSerializer _serializer;

                /*0x727b5f8*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader);
                /*0x727b684*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter);
                /*0x727b1e8*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x727b208*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x727b228*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
                /*0x727b248*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
                /*0x727b268*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
                /*0x727b288*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
                /*0x727b2a8*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
                /*0x727b2cc*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
                /*0x727b2f0*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
                /*0x727b314*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
                /*0x727b338*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
                /*0x727b35c*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
                /*0x727b380*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
                /*0x727b3a4*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
                /*0x727b3c8*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
                /*0x727b3ec*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
                /*0x727b410*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
                /*0x727b430*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
                /*0x727b454*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
                /*0x727b478*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
                /*0x727b498*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
                /*0x727b4bc*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
                /*0x727b4dc*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0x727b500*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
                /*0x727b524*/ Newtonsoft.Json.Formatting get_Formatting();
                /*0x727b548*/ void set_Formatting(Newtonsoft.Json.Formatting value);
                /*0x727b56c*/ System.Nullable<int> get_MaxDepth();
                /*0x727b590*/ bool get_CheckAdditionalContent();
                /*0x727b5b4*/ void set_CheckAdditionalContent(bool value);
                /*0x727b5dc*/ Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer();
                /*0x727b710*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x727b748*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
                /*0x727b77c*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type rootType);
            }

            class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
            {
                /*0x727b7b0*/ JsonStringContract(System.Type underlyingType);
            }

            class JsonTypeReflector
            {
                static /*0x0*/ System.Nullable<bool> _fullyTrusted;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Func<System.Object[], object>> CreatorCache;
                static /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache;
                static /*0x18*/ Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;

                static /*0x727c8b0*/ JsonTypeReflector();
                static /*0x3907c14*/ T GetCachedAttribute<T>(object attributeProvider);
                static /*0x727b824*/ bool CanTypeDescriptorConvertString(System.Type type, ref System.ComponentModel.TypeConverter typeConverter);
                static /*0x727ba04*/ System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type);
                static /*0x727bac4*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo);
                static /*0x727bd3c*/ Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute);
                static /*0x727be90*/ Newtonsoft.Json.JsonConverter GetJsonConverter(object attributeProvider);
                static /*0x727bfb0*/ Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] args);
                static /*0x727c0a4*/ Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, object[] args);
                static /*0x727c198*/ Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute);
                static /*0x727c258*/ System.Func<System.Object[], object> GetCreator(System.Type type);
                static /*0x727c46c*/ System.Type GetAssociatedMetadataType(System.Type type);
                static /*0x727c4ec*/ System.Type GetAssociateMetadataTypeFromAttribute(System.Type type);
                static /*0x3907c14*/ T GetAttribute<T>(System.Type type);
                static /*0x3907c14*/ T GetAttribute<T>(System.Reflection.MemberInfo memberInfo);
                static /*0x727c728*/ bool IsNonSerializable(object provider);
                static /*0x727be14*/ bool IsSerializable(object provider);
                static /*0x3907c14*/ T GetAttribute<T>(object provider);
                static /*0x727c7a4*/ bool get_FullyTrusted();
                static /*0x727c3e4*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory();

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonTypeReflector.<> <>9;
                    static /*0x8*/ System.Func<object, System.Type> <>9__22_1;

                    static /*0x727ca38*/ <>c();
                    /*0x727caa0*/ <>c();
                    /*0x727caa8*/ System.Type <GetCreator>b__22_1(object param);
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ System.Type type;
                    /*0x18*/ System.Func<object> defaultConstructor;

                    /*0x727c3dc*/ <>c__DisplayClass22_0();
                    /*0x727cb04*/ object <GetCreator>b__0(object[] parameters);
                }
            }

            class KebabCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x727cf3c*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x727cf7c*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x727cfc8*/ KebabCaseNamingStrategy();
                /*0x727cfd0*/ string ResolvePropertyName(string name);
            }

            class NamingStrategy
            {
                /*0x10*/ bool <ProcessDictionaryKeys>k__BackingField;
                /*0x11*/ bool <ProcessExtensionDataNames>k__BackingField;
                /*0x12*/ bool <OverrideSpecifiedNames>k__BackingField;

                /*0x727cf74*/ NamingStrategy();
                /*0x727cfdc*/ bool get_ProcessDictionaryKeys();
                /*0x727cfe4*/ void set_ProcessDictionaryKeys(bool value);
                /*0x727cff0*/ bool get_ProcessExtensionDataNames();
                /*0x727cff8*/ void set_ProcessExtensionDataNames(bool value);
                /*0x727d004*/ bool get_OverrideSpecifiedNames();
                /*0x727d00c*/ void set_OverrideSpecifiedNames(bool value);
                /*0x727d018*/ string GetPropertyName(string name, bool hasSpecifiedName);
                /*0x727d038*/ string GetExtensionDataName(string name);
                /*0x727d054*/ string GetDictionaryKey(string key);
                /*0x380bb68*/ string ResolvePropertyName(string name);
                /*0x727d070*/ int GetHashCode();
                /*0x727d130*/ bool Equals(object obj);
                /*0x727d1b0*/ bool Equals(Newtonsoft.Json.Serialization.NamingStrategy other);
            }

            class ObjectConstructor<T> : System.MulticastDelegate
            {
                ObjectConstructor(object object, nint method);
                /*0x380bb68*/ object Invoke(object[] args);
            }

            class OnErrorAttribute : System.Attribute
            {
            }

            class ReflectionAttributeProvider : Newtonsoft.Json.Serialization.IAttributeProvider
            {
                /*0x10*/ object _attributeProvider;

                /*0x727d288*/ ReflectionAttributeProvider(object attributeProvider);
            }

            class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
            {
                /*0x10*/ System.Reflection.MemberInfo _memberInfo;

                /*0x727d2fc*/ ReflectionValueProvider(System.Reflection.MemberInfo memberInfo);
                /*0x727d370*/ void SetValue(object target, object value);
                /*0x727d50c*/ object GetValue(object target);
            }

            class SnakeCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x727d7a4*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x727d7dc*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x727d828*/ SnakeCaseNamingStrategy();
                /*0x727d830*/ string ResolvePropertyName(string name);
            }

            class TraceJsonReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.JsonReader _innerReader;
                /*0x80*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x88*/ System.IO.StringWriter _sw;

                /*0x727d83c*/ TraceJsonReader(Newtonsoft.Json.JsonReader innerReader);
                /*0x727d9a8*/ string GetDeserializedJsonMessage();
                /*0x727d9c8*/ bool Read();
                /*0x727da40*/ System.Nullable<int> ReadAsInt32();
                /*0x727da80*/ string ReadAsString();
                /*0x727dac0*/ byte[] ReadAsBytes();
                /*0x727db04*/ System.Nullable<decimal> ReadAsDecimal();
                /*0x727db80*/ System.Nullable<double> ReadAsDouble();
                /*0x727dbcc*/ System.Nullable<bool> ReadAsBoolean();
                /*0x727dc10*/ System.Nullable<System.DateTime> ReadAsDateTime();
                /*0x727dc5c*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
                /*0x727da08*/ void WriteCurrentToken();
                /*0x727dcb8*/ int get_Depth();
                /*0x727dcd8*/ string get_Path();
                /*0x727dcf8*/ Newtonsoft.Json.JsonToken get_TokenType();
                /*0x727dd18*/ object get_Value();
                /*0x727dd38*/ System.Type get_ValueType();
                /*0x727dd58*/ void Close();
                /*0x727dd7c*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x727de30*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x727dee8*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
            }

            class TraceJsonWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.JsonWriter _innerWriter;
                /*0x68*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x70*/ System.IO.StringWriter _sw;

                /*0x727dfa0*/ TraceJsonWriter(Newtonsoft.Json.JsonWriter innerWriter);
                /*0x727e1a8*/ string GetSerializedJsonMessage();
                /*0x727e1c8*/ void WriteValue(decimal value);
                /*0x727e234*/ void WriteValue(System.Nullable<decimal> value);
                /*0x727e350*/ void WriteValue(bool value);
                /*0x727e3b4*/ void WriteValue(System.Nullable<bool> value);
                /*0x727e468*/ void WriteValue(byte value);
                /*0x727e4c8*/ void WriteValue(System.Nullable<byte> value);
                /*0x727e578*/ void WriteValue(char value);
                /*0x727e5d8*/ void WriteValue(System.Nullable<char> value);
                /*0x727e688*/ void WriteValue(byte[] value);
                /*0x727e6fc*/ void WriteValue(System.DateTime value);
                /*0x727e75c*/ void WriteValue(System.Nullable<System.DateTime> value);
                /*0x727e81c*/ void WriteValue(System.DateTimeOffset value);
                /*0x727e888*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
                /*0x727e97c*/ void WriteValue(double value);
                /*0x727e9dc*/ void WriteValue(System.Nullable<double> value);
                /*0x727eaa0*/ void WriteUndefined();
                /*0x727eaec*/ void WriteNull();
                /*0x727eb38*/ void WriteValue(float value);
                /*0x727eb98*/ void WriteValue(System.Nullable<float> value);
                /*0x727ec48*/ void WriteValue(System.Guid value);
                /*0x727ecb4*/ void WriteValue(System.Nullable<System.Guid> value);
                /*0x727edac*/ void WriteValue(int value);
                /*0x727ee0c*/ void WriteValue(System.Nullable<int> value);
                /*0x727eeb8*/ void WriteValue(long value);
                /*0x727ef18*/ void WriteValue(System.Nullable<long> value);
                /*0x727efd8*/ void WriteValue(object value);
                /*0x727f0a4*/ void WriteValue(sbyte value);
                /*0x727f104*/ void WriteValue(System.Nullable<sbyte> value);
                /*0x727f1b4*/ void WriteValue(short value);
                /*0x727f214*/ void WriteValue(System.Nullable<short> value);
                /*0x727f2c4*/ void WriteValue(string value);
                /*0x727f324*/ void WriteValue(System.TimeSpan value);
                /*0x727f384*/ void WriteValue(System.Nullable<System.TimeSpan> value);
                /*0x727f444*/ void WriteValue(uint value);
                /*0x727f4a4*/ void WriteValue(System.Nullable<uint> value);
                /*0x727f550*/ void WriteValue(ulong value);
                /*0x727f5b0*/ void WriteValue(System.Nullable<ulong> value);
                /*0x727f670*/ void WriteValue(System.Uri value);
                /*0x727f734*/ void WriteValue(ushort value);
                /*0x727f794*/ void WriteValue(System.Nullable<ushort> value);
                /*0x727f844*/ void WriteComment(string text);
                /*0x727f8a4*/ void WriteStartArray();
                /*0x727f8e8*/ void WriteEndArray();
                /*0x727f92c*/ void WriteStartConstructor(string name);
                /*0x727f984*/ void WriteEndConstructor();
                /*0x727f9c8*/ void WritePropertyName(string name);
                /*0x727fa28*/ void WritePropertyName(string name, bool escape);
                /*0x727fa94*/ void WriteStartObject();
                /*0x727fad8*/ void WriteEndObject();
                /*0x727fb1c*/ void WriteRawValue(string json);
                /*0x727fb7c*/ void WriteRaw(string json);
                /*0x727fbdc*/ void Close();
            }
        }

        namespace Linq
        {
            enum CommentHandling
            {
                Ignore = 0,
                Load = 1,
            }

            enum DuplicatePropertyNameHandling
            {
                Replace = 0,
                Ignore = 1,
                Error = 2,
            }

            class JArray : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
            {
                /*0x50*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0x7280214*/ Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x727fc30*/ JArray();
                /*0x727fd0c*/ JArray(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x728010c*/ JArray(object content);
                /*0x727fc20*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x727fc28*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x72801ac*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x72806b0*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x728077c*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                /*0x728078c*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x728079c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7280800*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x7280810*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7280828*/ void RemoveAt(int index);
                /*0x7280838*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                /*0x72808d0*/ void Add(Newtonsoft.Json.Linq.JToken item);
                /*0x72808e0*/ void Clear();
                /*0x72808f0*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x7280900*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x7280910*/ bool get_IsReadOnly();
                /*0x7280918*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
            }

            class JConstructor : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ string _name;
                /*0x58*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0x7280cd4*/ Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x72809a4*/ JConstructor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7280a58*/ JConstructor(string name);
                /*0x7280928*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x7280930*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7280994*/ string get_Name();
                /*0x728099c*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x7280b8c*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7280bf4*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
            }

            class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.ComponentModel.IBindingList, System.Collections.ICollection, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged
            {
                /*0x30*/ System.ComponentModel.ListChangedEventHandler _listChanged;
                /*0x38*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;
                /*0x40*/ object _syncRoot;
                /*0x48*/ bool _busy;

                static /*0x7282aa4*/ bool IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue);
                static /*0x7283888*/ Newtonsoft.Json.Linq.JToken CreateFromContent(object content);
                static /*0x7283eb4*/ Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent);
                /*0x727fcb4*/ JContainer();
                /*0x727fda8*/ JContainer(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7280eb8*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x7280f48*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380b9e8*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x7281410*/ void CheckReentrancy();
                /*0x72814b8*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
                /*0x7281540*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x72815c8*/ bool get_HasValues();
                /*0x7281688*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x72817c4*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x7281900*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x7281974*/ bool IsMultiContent(object content);
                /*0x7281a4c*/ Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x380b7a8*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7281bb8*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x7281fec*/ void RemoveItemAt(int index);
                /*0x7282480*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x72824cc*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x7282588*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7282b50*/ void ClearItems();
                /*0x7282f94*/ void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement);
                /*0x7282ff8*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x728301c*/ void CopyItemsTo(System.Array array, int arrayIndex);
                /*0x72834fc*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x7283618*/ void Add(object content);
                /*0x72836e8*/ bool TryAdd(object content);
                /*0x72837b8*/ void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token);
                /*0x7281074*/ bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations);
                /*0x728396c*/ void RemoveAll();
                /*0x7280554*/ void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options);
                /*0x728397c*/ void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x728432c*/ int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x728433c*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7284354*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index);
                /*0x7284364*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index);
                /*0x7284374*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x7284384*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item);
                /*0x7284394*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear();
                /*0x72843a4*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x72843b4*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x72843c4*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly();
                /*0x72843cc*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item);
                /*0x72843dc*/ Newtonsoft.Json.Linq.JToken EnsureValue(object value);
                /*0x7284498*/ int System.Collections.IList.Add(object value);
                /*0x72844d0*/ void System.Collections.IList.Clear();
                /*0x72844e0*/ bool System.Collections.IList.Contains(object value);
                /*0x7284508*/ int System.Collections.IList.IndexOf(object value);
                /*0x7284530*/ void System.Collections.IList.Insert(int index, object value);
                /*0x7284574*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x728457c*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x7284584*/ void System.Collections.IList.Remove(object value);
                /*0x72845ac*/ void System.Collections.IList.RemoveAt(int index);
                /*0x72845bc*/ object System.Collections.IList.get_Item(int index);
                /*0x72845cc*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x7284608*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x7283448*/ int get_Count();
                /*0x7284618*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x7284620*/ object System.Collections.ICollection.get_SyncRoot();
            }

            struct JEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>>
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JEnumerable<T> Empty;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> _enumerable;

                static /*0x38358cc*/ JEnumerable();
                /*0x380d83c*/ JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other);
                /*0x380b2f0*/ bool Equals(object obj);
                /*0x380b6a0*/ int GetHashCode();
            }

            class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x50*/ Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;
                /*0x58*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
                /*0x60*/ System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

                static /*0x72851d4*/ Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x7283d9c*/ JObject();
                /*0x7284864*/ JObject(Newtonsoft.Json.Linq.JObject other);
                /*0x72848dc*/ JObject(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7284958*/ JObject(object[] content);
                /*0x728495c*/ JObject(object content);
                /*0x7284694*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x728469c*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x7284738*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x72849e4*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7284ab0*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x7284b20*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x7284db8*/ void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x7284f04*/ void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x7284f28*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7284f90*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x7284f98*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties();
                /*0x7284088*/ Newtonsoft.Json.Linq.JProperty Property(string name, System.StringComparison comparison);
                /*0x7284fe0*/ Newtonsoft.Json.Linq.JToken get_Item(string propertyName);
                /*0x7285060*/ void set_Item(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x7285398*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x7285158*/ void Add(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x7285584*/ bool ContainsKey(string propertyName);
                /*0x728569c*/ System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys();
                /*0x728570c*/ bool Remove(string propertyName);
                /*0x72857a4*/ bool TryGetValue(string propertyName, ref Newtonsoft.Json.Linq.JToken value);
                /*0x7285800*/ System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values();
                /*0x7285838*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x72858cc*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear();
                /*0x72858dc*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x728595c*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> array, int arrayIndex);
                /*0x7285dcc*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly();
                /*0x7285dd4*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x7285f14*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> GetEnumerator();
                /*0x7285fa8*/ void OnPropertyChanged(string propertyName);
                /*0x7286038*/ void OnPropertyChanging(string propertyName);
                /*0x72860c8*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x7286164*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x72864c8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x7286520*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x7286574*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                /*0x72865f0*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);

                class JObjectDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JObject>
                {
                    /*0x72866a0*/ JObjectDynamicProxy();
                    /*0x72866e8*/ bool TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, ref object result);
                    /*0x7286728*/ bool TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, object value);
                    /*0x7286808*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance);

                    class <>c
                    {
                        static /*0x0*/ Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<> <>9;
                        static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JProperty, string> <>9__2_0;

                        static /*0x728691c*/ <>c();
                        /*0x7286984*/ <>c();
                        /*0x728698c*/ string <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p);
                    }
                }

                class <GetEnumerator>d__64 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> <>2__current;
                    /*0x28*/ Newtonsoft.Json.Linq.JObject <>4__this;
                    /*0x30*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;

                    /*0x7285f80*/ <GetEnumerator>d__64(int <>1__state);
                    /*0x72869a4*/ void System.IDisposable.Dispose();
                    /*0x72869c0*/ bool MoveNext();
                    /*0x7286cac*/ void <>m__Finally1();
                    /*0x7286d5c*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current();
                    /*0x7286d68*/ void System.Collections.IEnumerator.Reset();
                    /*0x7286da0*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class JProperty : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ Newtonsoft.Json.Linq.JProperty.JPropertyList _content;
                /*0x58*/ string _name;

                static /*0x72874c4*/ Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x7286e0c*/ JProperty(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7284210*/ JProperty(string name);
                /*0x7285480*/ JProperty(string name, object content);
                /*0x7286dfc*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x7286e04*/ string get_Name();
                /*0x7283d80*/ Newtonsoft.Json.Linq.JToken get_Value();
                /*0x72850d8*/ void set_Value(Newtonsoft.Json.Linq.JToken value);
                /*0x7286eac*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x7286f00*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7287044*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x72870f4*/ void RemoveItemAt(int index);
                /*0x72871a4*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x72871e4*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x7287300*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7287324*/ void ClearItems();
                /*0x72873d4*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x728743c*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x7287444*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);

                class JPropertyList : System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JToken _token;

                    /*0x7286ea4*/ JPropertyList();
                    /*0x72876a8*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                    /*0x728773c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x7287740*/ void Add(Newtonsoft.Json.Linq.JToken item);
                    /*0x7287748*/ void Clear();
                    /*0x7287754*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                    /*0x7287764*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                    /*0x72877d8*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
                    /*0x7287810*/ int get_Count();
                    /*0x7287820*/ bool get_IsReadOnly();
                    /*0x72871d4*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                    /*0x7287828*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                    /*0x728783c*/ void RemoveAt(int index);
                    /*0x7287850*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                    /*0x7287898*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);

                    class <GetEnumerator>d__1 : System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ Newtonsoft.Json.Linq.JProperty.JPropertyList <>4__this;

                        /*0x7287714*/ <GetEnumerator>d__1(int <>1__state);
                        /*0x72878e4*/ void System.IDisposable.Dispose();
                        /*0x72878e8*/ bool MoveNext();
                        /*0x7287950*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0x7287958*/ void System.Collections.IEnumerator.Reset();
                        /*0x7287990*/ object System.Collections.IEnumerator.get_Current();
                    }
                }
            }

            class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x72864bc*/ JPropertyDescriptor(string name);
                /*0x7287998*/ bool CanResetValue(object component);
                /*0x72879a0*/ object GetValue(object component);
                /*0x7287a3c*/ void ResetValue(object component);
                /*0x7287a40*/ void SetValue(object component, object value);
                /*0x7287b7c*/ bool ShouldSerializeValue(object component);
                /*0x7287b84*/ System.Type get_ComponentType();
                /*0x7287be4*/ bool get_IsReadOnly();
                /*0x7287bec*/ System.Type get_PropertyType();
                /*0x7287c1c*/ int get_NameHashCode();
            }

            class JPropertyKeyedCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.Linq.JToken>
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<string> Comparer;
                /*0x18*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Linq.JToken> _dictionary;

                static /*0x728821c*/ JPropertyKeyedCollection();
                /*0x72847d4*/ JPropertyKeyedCollection();
                /*0x7287c24*/ void AddKey(string key, Newtonsoft.Json.Linq.JToken item);
                /*0x7287d50*/ void ClearItems();
                /*0x72855f0*/ bool Contains(string key);
                /*0x7287c94*/ void EnsureDictionary();
                /*0x7287dc8*/ string GetKeyForItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7287e48*/ void InsertItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7287ec0*/ void RemoveItem(int index);
                /*0x7287fb4*/ void RemoveKey(string key);
                /*0x7288014*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7284d30*/ bool TryGetValue(string key, ref Newtonsoft.Json.Linq.JToken value);
                /*0x72856b4*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0x7284a0c*/ int IndexOfReference(Newtonsoft.Json.Linq.JToken t);
            }

            class JRaw : Newtonsoft.Json.Linq.JValue
            {
                static /*0x7288418*/ Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader);
                /*0x72882cc*/ JRaw(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7288390*/ JRaw(object rawJson);
                /*0x7288794*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
            }

            class JsonCloneSettings
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JsonCloneSettings SkipCopyAnnotations;
                /*0x10*/ bool <CopyAnnotations>k__BackingField;

                static /*0x7288830*/ JsonCloneSettings();
                /*0x72887fc*/ JsonCloneSettings();
                /*0x728881c*/ bool get_CopyAnnotations();
                /*0x7288824*/ void set_CopyAnnotations(bool value);
            }

            class JsonLoadSettings
            {
                /*0x10*/ Newtonsoft.Json.Linq.CommentHandling _commentHandling;
                /*0x14*/ Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;
                /*0x18*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

                /*0x728889c*/ Newtonsoft.Json.Linq.CommentHandling get_CommentHandling();
                /*0x72888a4*/ Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling();
                /*0x72888ac*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling();
            }

            class JToken : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, Newtonsoft.Json.IJsonLineInfo, System.ICloneable, System.Dynamic.IDynamicMetaObjectProvider
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JTokenType[] BooleanTypes;
                static /*0x8*/ Newtonsoft.Json.Linq.JTokenType[] NumberTypes;
                static /*0x10*/ Newtonsoft.Json.Linq.JTokenType[] BigIntegerTypes;
                static /*0x18*/ Newtonsoft.Json.Linq.JTokenType[] StringTypes;
                static /*0x20*/ Newtonsoft.Json.Linq.JTokenType[] GuidTypes;
                static /*0x28*/ Newtonsoft.Json.Linq.JTokenType[] TimeSpanTypes;
                static /*0x30*/ Newtonsoft.Json.Linq.JTokenType[] UriTypes;
                static /*0x38*/ Newtonsoft.Json.Linq.JTokenType[] CharTypes;
                static /*0x40*/ Newtonsoft.Json.Linq.JTokenType[] DateTimeTypes;
                static /*0x48*/ Newtonsoft.Json.Linq.JTokenType[] BytesTypes;
                /*0x10*/ Newtonsoft.Json.Linq.JContainer _parent;
                /*0x18*/ Newtonsoft.Json.Linq.JToken _previous;
                /*0x20*/ Newtonsoft.Json.Linq.JToken _next;
                /*0x28*/ object _annotations;

                static /*0x728fa0c*/ JToken();
                static /*0x72890cc*/ Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value);
                static /*0x72891e0*/ string GetType(Newtonsoft.Json.Linq.JToken token);
                static /*0x72892d0*/ bool ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, bool nullable);
                static /*0x7289390*/ bool op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x7289598*/ System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72897d8*/ System.Nullable<bool> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x7289a28*/ long op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x7289c0c*/ System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x7289e30*/ System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728a0f8*/ System.Nullable<decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728a338*/ System.Nullable<double> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728a558*/ System.Nullable<char> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728a77c*/ int op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728a960*/ short op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728ab44*/ ushort op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728ad28*/ char op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728af0c*/ byte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728b0f0*/ sbyte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728b2d4*/ System.Nullable<int> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728b4f8*/ System.Nullable<short> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728b71c*/ System.Nullable<ushort> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728b940*/ System.Nullable<byte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728bb64*/ System.Nullable<sbyte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728bd88*/ System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728bf74*/ System.Nullable<long> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728c198*/ System.Nullable<float> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728c3b8*/ decimal op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728c59c*/ System.Nullable<uint> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728c7c0*/ System.Nullable<ulong> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728c9e4*/ double op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728cbc8*/ float op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728cdac*/ string op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728d024*/ uint op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728d208*/ ulong op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728d3ec*/ System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728d60c*/ System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728d870*/ System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728da6c*/ System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728dca4*/ System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x728dea0*/ System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value);
                static /*0x728dfec*/ System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value);
                static /*0x728f1e8*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader);
                static /*0x728f240*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x7280fd8*/ JToken();
                /*0x72888b4*/ Newtonsoft.Json.Linq.JContainer get_Parent();
                /*0x72888bc*/ void set_Parent(Newtonsoft.Json.Linq.JContainer value);
                /*0x7281ba0*/ Newtonsoft.Json.Linq.JToken get_Root();
                /*0x380bb68*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x380b6a0*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x380b128*/ bool get_HasValues();
                /*0x72888c4*/ Newtonsoft.Json.Linq.JToken get_Next();
                /*0x72888cc*/ void set_Next(Newtonsoft.Json.Linq.JToken value);
                /*0x72888d4*/ Newtonsoft.Json.Linq.JToken get_Previous();
                /*0x72888dc*/ void set_Previous(Newtonsoft.Json.Linq.JToken value);
                /*0x72888e4*/ string get_Path();
                /*0x7288c64*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x7288cf4*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x7288d84*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x7285738*/ void Remove();
                /*0x72842b8*/ void Replace(Newtonsoft.Json.Linq.JToken value);
                /*0x380d93c*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x7288ddc*/ string ToString();
                /*0x7288e74*/ string ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters);
                /*0x728e198*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x728e22c*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                /*0x728e2c4*/ Newtonsoft.Json.JsonReader CreateReader();
                /*0x728e390*/ object ToObject(System.Type objectType);
                /*0x728ef7c*/ object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0x72803b4*/ void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x728f520*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x728f818*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x728f86c*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x728f8c0*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x728f914*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x728f9dc*/ System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x728f9ec*/ object System.ICloneable.Clone();
                /*0x728f9fc*/ Newtonsoft.Json.Linq.JToken DeepClone();
                /*0x728f5bc*/ void AddAnnotation(object annotation);
                /*0x3907c14*/ T Annotation<T>();
                /*0x7280fe0*/ void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source);

                class LineInfoAnnotation
                {
                    /*0x10*/ int LineNumber;
                    /*0x14*/ int LinePosition;

                    /*0x728f590*/ LineInfoAnnotation(int lineNumber, int linePosition);
                }
            }

            class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.Linq.JToken _root;
                /*0x80*/ string _initialPath;
                /*0x88*/ Newtonsoft.Json.Linq.JToken _parent;
                /*0x90*/ Newtonsoft.Json.Linq.JToken _current;

                /*0x728e31c*/ JTokenReader(Newtonsoft.Json.Linq.JToken token);
                /*0x728fd14*/ Newtonsoft.Json.Linq.JToken get_CurrentToken();
                /*0x728fd1c*/ bool Read();
                /*0x728fe7c*/ bool ReadOver(Newtonsoft.Json.Linq.JToken t);
                /*0x7290540*/ bool ReadToEnd();
                /*0x7290610*/ System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c);
                /*0x728fdf8*/ bool ReadInto(Newtonsoft.Json.Linq.JContainer c);
                /*0x7290570*/ bool SetEnd(Newtonsoft.Json.Linq.JContainer c);
                /*0x728ff4c*/ void SetToken(Newtonsoft.Json.Linq.JToken token);
                /*0x7290760*/ string SafeToString(object value);
                /*0x7290780*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x7290834*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x72908ec*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x72909a4*/ string get_Path();
            }

            enum JTokenType
            {
                None = 0,
                Object = 1,
                Array = 2,
                Constructor = 3,
                Property = 4,
                Comment = 5,
                Integer = 6,
                Float = 7,
                String = 8,
                Boolean = 9,
                Null = 10,
                Undefined = 11,
                Date = 12,
                Raw = 13,
                Bytes = 14,
                Guid = 15,
                Uri = 16,
                TimeSpan = 17,
            }

            class JTokenWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.Linq.JContainer _token;
                /*0x68*/ Newtonsoft.Json.Linq.JContainer _parent;
                /*0x70*/ Newtonsoft.Json.Linq.JValue _value;
                /*0x78*/ Newtonsoft.Json.Linq.JToken _current;

                /*0x7290ab4*/ JTokenWriter();
                /*0x7290a98*/ Newtonsoft.Json.Linq.JToken get_Token();
                /*0x7290b0c*/ void Close();
                /*0x7290b14*/ void WriteStartObject();
                /*0x7290b78*/ void AddParent(Newtonsoft.Json.Linq.JContainer container);
                /*0x7290bd8*/ void RemoveParent();
                /*0x7290c48*/ void WriteStartArray();
                /*0x7290cac*/ void WriteStartConstructor(string name);
                /*0x7290d24*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
                /*0x7290d28*/ void WritePropertyName(string name);
                /*0x7290de8*/ void AddRawValue(object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token);
                /*0x7290e58*/ void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token);
                /*0x7290f18*/ void WriteValue(object value);
                /*0x7290fa8*/ void WriteNull();
                /*0x7290fcc*/ void WriteUndefined();
                /*0x7290ff0*/ void WriteRaw(string json);
                /*0x729106c*/ void WriteComment(string text);
                /*0x72910a0*/ void WriteValue(string value);
                /*0x7291124*/ void WriteValue(int value);
                /*0x7291174*/ void WriteValue(uint value);
                /*0x72911c4*/ void WriteValue(long value);
                /*0x72912b0*/ void WriteValue(ulong value);
                /*0x729138c*/ void WriteValue(float value);
                /*0x7291468*/ void WriteValue(double value);
                /*0x7291554*/ void WriteValue(bool value);
                /*0x7291644*/ void WriteValue(short value);
                /*0x7291694*/ void WriteValue(ushort value);
                /*0x72916e4*/ void WriteValue(char value);
                /*0x72917cc*/ void WriteValue(byte value);
                /*0x729181c*/ void WriteValue(sbyte value);
                /*0x729186c*/ void WriteValue(decimal value);
                /*0x729196c*/ void WriteValue(System.DateTime value);
                /*0x7291a90*/ void WriteValue(System.DateTimeOffset value);
                /*0x7291b8c*/ void WriteValue(byte[] value);
                /*0x7291c08*/ void WriteValue(System.TimeSpan value);
                /*0x7291cec*/ void WriteValue(System.Guid value);
                /*0x7291de8*/ void WriteValue(System.Uri value);
                /*0x7291ee4*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            }

            class JValue : Newtonsoft.Json.Linq.JToken, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IConvertible
            {
                /*0x30*/ Newtonsoft.Json.Linq.JTokenType _valueType;
                /*0x38*/ object _value;

                static /*0x7292520*/ int CompareBigInteger(System.Numerics.BigInteger i1, object i2);
                static /*0x7292804*/ int Compare(Newtonsoft.Json.Linq.JTokenType valueType, object objA, object objB);
                static /*0x729323c*/ int CompareFloat(object objA, object objB);
                static /*0x7293338*/ bool Operation(System.Linq.Expressions.ExpressionType operation, object objA, object objB, ref object result);
                static /*0x7283e00*/ Newtonsoft.Json.Linq.JValue CreateComment(string value);
                static /*0x7281b48*/ Newtonsoft.Json.Linq.JValue CreateNull();
                static /*0x7283e5c*/ Newtonsoft.Json.Linq.JValue CreateUndefined();
                static /*0x72921e8*/ Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value);
                static /*0x7293bb4*/ Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current);
                static /*0x72943bc*/ bool ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2);
                /*0x7288398*/ JValue(object value, Newtonsoft.Json.Linq.JTokenType type);
                /*0x72882d0*/ JValue(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729123c*/ JValue(long value);
                /*0x72918f0*/ JValue(decimal value);
                /*0x729134c*/ JValue(ulong value);
                /*0x72914e0*/ JValue(double value);
                /*0x7291428*/ JValue(float value);
                /*0x7291a24*/ JValue(System.DateTime value);
                /*0x7291b14*/ JValue(System.DateTimeOffset value);
                /*0x72915d0*/ JValue(bool value);
                /*0x729111c*/ JValue(string value);
                /*0x7291d70*/ JValue(System.Guid value);
                /*0x7291e60*/ JValue(System.Uri value);
                /*0x7291c80*/ JValue(System.TimeSpan value);
                /*0x728393c*/ JValue(object value);
                /*0x7292518*/ bool get_HasValues();
                /*0x7293b4c*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7293c30*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x7293c38*/ object get_Value();
                /*0x7293c40*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x7294418*/ bool Equals(Newtonsoft.Json.Linq.JValue other);
                /*0x7294428*/ bool Equals(object obj);
                /*0x72944b4*/ int GetHashCode();
                /*0x72944cc*/ string ToString();
                /*0x72944f8*/ string ToString(System.IFormatProvider formatProvider);
                /*0x7294504*/ string ToString(string format, System.IFormatProvider formatProvider);
                /*0x7294610*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x7294708*/ int System.IComparable.CompareTo(object obj);
                /*0x72947c4*/ int CompareTo(Newtonsoft.Json.Linq.JValue obj);
                /*0x7294808*/ System.TypeCode System.IConvertible.GetTypeCode();
                /*0x72948c4*/ bool System.IConvertible.ToBoolean(System.IFormatProvider provider);
                /*0x7294918*/ char System.IConvertible.ToChar(System.IFormatProvider provider);
                /*0x729496c*/ sbyte System.IConvertible.ToSByte(System.IFormatProvider provider);
                /*0x72949c0*/ byte System.IConvertible.ToByte(System.IFormatProvider provider);
                /*0x7294a14*/ short System.IConvertible.ToInt16(System.IFormatProvider provider);
                /*0x7294a68*/ ushort System.IConvertible.ToUInt16(System.IFormatProvider provider);
                /*0x7294abc*/ int System.IConvertible.ToInt32(System.IFormatProvider provider);
                /*0x7294b10*/ uint System.IConvertible.ToUInt32(System.IFormatProvider provider);
                /*0x7294b64*/ long System.IConvertible.ToInt64(System.IFormatProvider provider);
                /*0x7294bb8*/ ulong System.IConvertible.ToUInt64(System.IFormatProvider provider);
                /*0x7294c0c*/ float System.IConvertible.ToSingle(System.IFormatProvider provider);
                /*0x7294c60*/ double System.IConvertible.ToDouble(System.IFormatProvider provider);
                /*0x7294cb4*/ decimal System.IConvertible.ToDecimal(System.IFormatProvider provider);
                /*0x7294d08*/ System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider);
                /*0x7294d5c*/ object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider);

                class JValueDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JValue>
                {
                    /*0x72946c0*/ JValueDynamicProxy();
                    /*0x7294d60*/ bool TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, ref object result);
                    /*0x7294f40*/ bool TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
                }
            }

            enum LineInfoHandling
            {
                Ignore = 0,
                Load = 1,
            }
        }

        namespace Converters
        {
            class BinaryConverter : Newtonsoft.Json.JsonConverter
            {
                static string BinaryTypeName = "System.Data.Linq.Binary";
                static string BinaryToArrayName = "ToArray";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0x72954a0*/ void EnsureReflectionObject(System.Type t);
                /*0x7295dd8*/ BinaryConverter();
                /*0x7295264*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72952b8*/ byte[] GetByteArray(object value);
                /*0x7295654*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7295a40*/ byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader);
                /*0x7295ccc*/ bool CanConvert(System.Type objectType);
            }

            class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x72960d8*/ BsonObjectIdConverter();
                /*0x7295de0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7295ee0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7296064*/ bool CanConvert(System.Type objectType);
            }

            class CustomCreationConverter<T> : Newtonsoft.Json.JsonConverter
            {
                /*0x380cb08*/ CustomCreationConverter();
                /*0x380da4c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x380bd7c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3907c14*/ T Create(System.Type objectType);
                /*0x380b2f0*/ bool CanConvert(System.Type objectType);
                /*0x380b128*/ bool get_CanWrite();
            }

            class DataSetConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x72968b0*/ DataSetConverter();
                /*0x72960e0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7296570*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7296830*/ bool CanConvert(System.Type valueType);
            }

            class DataTableConverter : Newtonsoft.Json.JsonConverter
            {
                static /*0x7297380*/ void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer);
                static /*0x7297880*/ System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader);
                /*0x7296568*/ DataTableConverter();
                /*0x72968b8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72970b4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7297a3c*/ bool CanConvert(System.Type valueType);
            }

            class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
            {
                /*0x7297c18*/ DateTimeConverterBase();
                /*0x7297abc*/ bool CanConvert(System.Type objectType);
            }

            class DiscriminatedUnionConverter : Newtonsoft.Json.JsonConverter
            {
                static string CasePropertyName = "Case";
                static string FieldsPropertyName = "Fields";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache;

                static /*0x7299434*/ DiscriminatedUnionConverter();
                static /*0x7297c20*/ System.Type CreateUnionTypeLookup(System.Type t);
                static /*0x7297e20*/ Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t);
                /*0x729942c*/ DiscriminatedUnionConverter();
                /*0x72986a0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7298b20*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72991a8*/ bool CanConvert(System.Type objectType);

                class Union
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.FSharpFunction TagReader;
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;

                    /*0x72985d8*/ Union(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases);
                }

                class UnionCase
                {
                    /*0x10*/ int Tag;
                    /*0x18*/ string Name;
                    /*0x20*/ System.Reflection.PropertyInfo[] Fields;
                    /*0x28*/ Newtonsoft.Json.Utilities.FSharpFunction FieldReader;
                    /*0x30*/ Newtonsoft.Json.Utilities.FSharpFunction Constructor;

                    /*0x729861c*/ UnionCase(int tag, string name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ int tag;

                    /*0x7298b18*/ <>c__DisplayClass8_0();
                    /*0x72995c4*/ bool <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ string caseName;
                    /*0x18*/ System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> <>9__0;

                    /*0x72991a0*/ <>c__DisplayClass9_0();
                    /*0x72995e8*/ bool <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }
            }

            class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
            {
                static string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
                static string KeyPropertyName = "Key";
                static string TypePropertyName = "Type";
                static string ValuePropertyName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0x7299a68*/ void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, string propertyName);
                static /*0x7299948*/ void EnsureReflectionObject(System.Type objectType);
                /*0x7299e50*/ EntityKeyMemberConverter();
                /*0x729960c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7299b54*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7299e00*/ bool CanConvert(System.Type objectType);
            }

            class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x729a37c*/ ExpandoObjectConverter();
                /*0x7299e58*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7299e5c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x7299e60*/ object ReadValue(Newtonsoft.Json.JsonReader reader);
                /*0x729a178*/ object ReadList(Newtonsoft.Json.JsonReader reader);
                /*0x7299fbc*/ object ReadObject(Newtonsoft.Json.JsonReader reader);
                /*0x729a300*/ bool CanConvert(System.Type objectType);
                /*0x729a374*/ bool get_CanWrite();
            }

            class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
                /*0x10*/ System.Globalization.DateTimeStyles _dateTimeStyles;
                /*0x18*/ string _dateTimeFormat;
                /*0x20*/ System.Globalization.CultureInfo _culture;

                /*0x729abcc*/ IsoDateTimeConverter();
                /*0x729a384*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
                /*0x729a38c*/ void set_DateTimeStyles(System.Globalization.DateTimeStyles value);
                /*0x729a394*/ string get_DateTimeFormat();
                /*0x729a3b8*/ void set_DateTimeFormat(string value);
                /*0x729a3f8*/ System.Globalization.CultureInfo get_Culture();
                /*0x729a460*/ void set_Culture(System.Globalization.CultureInfo value);
                /*0x729a468*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729a6d0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                /*0x729b0d8*/ JavaScriptDateTimeConverter();
                /*0x729abdc*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729adb8*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
            {
                static string KeyName = "Key";
                static string ValueName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

                static /*0x729bb8c*/ KeyValuePairConverter();
                static /*0x729b0e0*/ Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t);
                /*0x729bb84*/ KeyValuePairConverter();
                /*0x729b35c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729b5b0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729ba78*/ bool CanConvert(System.Type objectType);
            }

            class RegexConverter : Newtonsoft.Json.JsonConverter
            {
                static string PatternName = "Pattern";
                static string OptionsName = "Options";

                /*0x729c694*/ RegexConverter();
                /*0x729bc74*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729c084*/ bool HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag);
                /*0x729bd94*/ void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex);
                /*0x729bec8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729c140*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729c44c*/ object ReadRegexString(Newtonsoft.Json.JsonReader reader);
                /*0x729c1ec*/ System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729c5a4*/ bool CanConvert(System.Type objectType);
                /*0x729c620*/ bool IsRegex(System.Type objectType);
            }

            class StringEnumConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;
                /*0x18*/ bool <AllowIntegerValues>k__BackingField;

                /*0x729c80c*/ StringEnumConverter();
                /*0x729c81c*/ StringEnumConverter(bool camelCaseText);
                /*0x729c8a4*/ StringEnumConverter(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, bool allowIntegerValues);
                /*0x729c8ec*/ StringEnumConverter(System.Type namingStrategyType);
                /*0x729c99c*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters);
                /*0x729ca58*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues);
                /*0x729c69c*/ bool get_CamelCaseText();
                /*0x729c718*/ void set_CamelCaseText(bool value);
                /*0x729c7e8*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x729c7f0*/ void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value);
                /*0x729c7f8*/ bool get_AllowIntegerValues();
                /*0x729c800*/ void set_AllowIntegerValues(bool value);
                /*0x729cb24*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729cd08*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729d178*/ bool CanConvert(System.Type objectType);
            }

            class UnixDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static /*0x0*/ System.DateTime UnixEpoch;
                /*0x10*/ bool <AllowPreEpoch>k__BackingField;

                static /*0x729d87c*/ UnixDateTimeConverter();
                /*0x729d204*/ UnixDateTimeConverter();
                /*0x729d220*/ UnixDateTimeConverter(bool allowPreEpoch);
                /*0x729d1f0*/ bool get_AllowPreEpoch();
                /*0x729d1f8*/ void set_AllowPreEpoch(bool value);
                /*0x729d24c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729d4b0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class VersionConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x729dccc*/ VersionConverter();
                /*0x729d8f8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729d9e0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x729dc58*/ bool CanConvert(System.Type objectType);
            }

            class XmlDocumentWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocument _document;

                /*0x729dcd4*/ XmlDocumentWrapper(System.Xml.XmlDocument document);
                /*0x729dd44*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string data);
                /*0x729ddd8*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x729de6c*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x729df00*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x729df94*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x729e028*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x729e104*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x729e1e4*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x729e288*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x729e344*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x729e3d0*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x729e4a4*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x729e560*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            class XmlElementWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlElement _element;

                /*0x729e304*/ XmlElementWrapper(System.Xml.XmlElement element);
                /*0x729e5f0*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x729e6d8*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x729e6fc*/ bool get_IsEmpty();
            }

            class XmlDeclarationWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDeclaration _declaration;

                /*0x729e0c4*/ XmlDeclarationWrapper(System.Xml.XmlDeclaration declaration);
                /*0x729e718*/ string get_Version();
                /*0x729e734*/ string get_Encoding();
                /*0x729e750*/ string get_Standalone();
            }

            class XmlDocumentTypeWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocumentType _documentType;

                /*0x729e1a4*/ XmlDocumentTypeWrapper(System.Xml.XmlDocumentType documentType);
                /*0x729e76c*/ string get_Name();
                /*0x729e78c*/ string get_System();
                /*0x729e7a8*/ string get_Public();
                /*0x729e7c4*/ string get_InternalSubset();
                /*0x729e7e0*/ string get_LocalName();
            }

            class XmlNodeWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.XmlNode _node;
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                static /*0x729ecb8*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node);
                /*0x729dd14*/ XmlNodeWrapper(System.Xml.XmlNode node);
                /*0x729e820*/ object get_WrappedNode();
                /*0x729e828*/ System.Xml.XmlNodeType get_NodeType();
                /*0x729e848*/ string get_LocalName();
                /*0x729e86c*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x729ee9c*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x729f2e0*/ bool get_HasAttributes();
                /*0x729f394*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x729f434*/ string get_Value();
                /*0x729e484*/ void set_Value(string value);
                /*0x729f454*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x729f514*/ string get_NamespaceUri();
            }

            interface IXmlDocument : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x380bd40*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x380bd7c*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x380bcbc*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x380bcbc*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x380bcbc*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x380bd40*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x380b9e8*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            interface IXmlDeclaration : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x380b9e8*/ string get_Version();
                /*0x380b9e8*/ string get_Encoding();
                /*0x380b9e8*/ string get_Standalone();
            }

            interface IXmlDocumentType : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x380b9e8*/ string get_Name();
                /*0x380b9e8*/ string get_System();
                /*0x380b9e8*/ string get_Public();
                /*0x380b9e8*/ string get_InternalSubset();
            }

            interface IXmlElement : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x380d83c*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x380bb68*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x380b128*/ bool get_IsEmpty();
            }

            interface IXmlNode
            {
                /*0x380b6a0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x380b9e8*/ string get_LocalName();
                /*0x380b9e8*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x380b9e8*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x380b9e8*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x380b9e8*/ string get_Value();
                /*0x380bb68*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x380b9e8*/ string get_NamespaceUri();
                /*0x380b9e8*/ object get_WrappedNode();
            }

            class XDeclarationWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDeclaration <Declaration>k__BackingField;

                /*0x729f540*/ XDeclarationWrapper(System.Xml.Linq.XDeclaration declaration);
                /*0x729f538*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x729f5b0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x729f5b8*/ string get_Version();
                /*0x729f5d4*/ string get_Encoding();
                /*0x729f5f0*/ string get_Standalone();
            }

            class XDocumentTypeWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDocumentType _documentType;

                /*0x729f60c*/ XDocumentTypeWrapper(System.Xml.Linq.XDocumentType documentType);
                /*0x729f64c*/ string get_Name();
                /*0x729f668*/ string get_System();
                /*0x729f684*/ string get_Public();
                /*0x729f6a0*/ string get_InternalSubset();
                /*0x729f6bc*/ string get_LocalName();
            }

            class XDocumentWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x729f774*/ XDocumentWrapper(System.Xml.Linq.XDocument document);
                /*0x729f6fc*/ System.Xml.Linq.XDocument get_Document();
                /*0x729f7d4*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x729fd60*/ bool get_HasChildNodes();
                /*0x729fdc4*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x729fe60*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x729fefc*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x729ff98*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x72a0034*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x72a00d0*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x72a0174*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x72a0220*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x72a02f4*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x72a03d4*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x72a0494*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x72a057c*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x72a064c*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
                /*0x72a06f4*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XTextWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72a08ec*/ XTextWrapper(System.Xml.Linq.XText text);
                /*0x72a0874*/ System.Xml.Linq.XText get_Text();
                /*0x72a091c*/ string get_Value();
                /*0x72a0938*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XCommentWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72a0cfc*/ XCommentWrapper(System.Xml.Linq.XComment text);
                /*0x72a0c84*/ System.Xml.Linq.XComment get_Text();
                /*0x72a0d2c*/ string get_Value();
                /*0x72a0d48*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XProcessingInstructionWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72a02c4*/ XProcessingInstructionWrapper(System.Xml.Linq.XProcessingInstruction processingInstruction);
                /*0x72a0d8c*/ System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction();
                /*0x72a0e04*/ string get_LocalName();
                /*0x72a0e20*/ string get_Value();
            }

            class XContainerWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;

                static /*0x72a097c*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node);
                /*0x729f7a4*/ XContainerWrapper(System.Xml.Linq.XContainer container);
                /*0x72a0e3c*/ System.Xml.Linq.XContainer get_Container();
                /*0x729f940*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x729fd9c*/ bool get_HasChildNodes();
                /*0x72a0eb4*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x72a0798*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XObjectWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.Linq.XObject _xmlObject;

                /*0x729f580*/ XObjectWrapper(System.Xml.Linq.XObject xmlObject);
                /*0x72a0ef8*/ object get_WrappedNode();
                /*0x72a0f00*/ System.Xml.XmlNodeType get_NodeType();
                /*0x72a0f18*/ string get_LocalName();
                /*0x72a0f20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x72a0f78*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x72a0fd0*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x72a0fd8*/ string get_Value();
                /*0x72a0fe0*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x72a1018*/ string get_NamespaceUri();
            }

            class XAttributeWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72a054c*/ XAttributeWrapper(System.Xml.Linq.XAttribute attribute);
                /*0x72a1020*/ System.Xml.Linq.XAttribute get_Attribute();
                /*0x72a1098*/ string get_Value();
                /*0x72a10b4*/ string get_LocalName();
                /*0x72a10d8*/ string get_NamespaceUri();
                /*0x72a10fc*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XElementWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                /*0x72a03a4*/ XElementWrapper(System.Xml.Linq.XElement element);
                /*0x72a1140*/ System.Xml.Linq.XElement get_Element();
                /*0x72a11b8*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x72a1264*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x72a17ec*/ bool HasImplicitNamespaceAttribute(string namespaceUri);
                /*0x72a1cd8*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x72a1d0c*/ string get_Value();
                /*0x72a1d28*/ string get_LocalName();
                /*0x72a1d4c*/ string get_NamespaceUri();
                /*0x72a1c98*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x72a1d70*/ bool get_IsEmpty();
            }

            class XmlNodeConverter : Newtonsoft.Json.JsonConverter
            {
                static string TextName = "#text";
                static string CommentName = "#comment";
                static string CDataName = "#cdata-section";
                static string WhitespaceName = "#whitespace";
                static string SignificantWhitespaceName = "#significant-whitespace";
                static string DeclarationName = "?xml";
                static string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
                static /*0x0*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes;
                /*0x10*/ string <DeserializeRootElementName>k__BackingField;
                /*0x18*/ bool <WriteArrayAttribute>k__BackingField;
                /*0x19*/ bool <OmitRootObject>k__BackingField;
                /*0x1a*/ bool <EncodeSpecialCharacters>k__BackingField;

                static /*0x72a9df0*/ XmlNodeConverter();
                static /*0x72a54e4*/ bool AllSameName(Newtonsoft.Json.Converters.IXmlNode node);
                static /*0x72a8c9c*/ void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, string attributeName, System.Xml.XmlNamespaceManager manager, string attributePrefix);
                static /*0x72a7374*/ string ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader);
                /*0x72a9de8*/ XmlNodeConverter();
                /*0x72a1d8c*/ string get_DeserializeRootElementName();
                /*0x72a1d94*/ void set_DeserializeRootElementName(string value);
                /*0x72a1d9c*/ bool get_WriteArrayAttribute();
                /*0x72a1da4*/ void set_WriteArrayAttribute(bool value);
                /*0x72a1db0*/ bool get_OmitRootObject();
                /*0x72a1db8*/ void set_OmitRootObject(bool value);
                /*0x72a1dc4*/ bool get_EncodeSpecialCharacters();
                /*0x72a1dcc*/ void set_EncodeSpecialCharacters(bool value);
                /*0x72a1dd8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72a1f18*/ Newtonsoft.Json.Converters.IXmlNode WrapXml(object value);
                /*0x72a2030*/ void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x72a3e04*/ string ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x72a4120*/ string GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x72a4560*/ bool IsArray(Newtonsoft.Json.Converters.IXmlNode node);
                /*0x72a48f8*/ void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x72a52a8*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames);
                /*0x72a5414*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, string elementNames);
                /*0x72a2698*/ void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x72a5aa8*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72a6dc8*/ void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x72a62fc*/ void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, System.Xml.XmlNamespaceManager manager);
                /*0x72a9018*/ void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string elementName, System.Xml.XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<string, string> attributeNameValues);
                /*0x72a82a0*/ void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager);
                /*0x72a9814*/ void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document);
                /*0x72a8640*/ bool ShouldReadInto(Newtonsoft.Json.JsonReader reader);
                /*0x72a8688*/ System.Collections.Generic.Dictionary<string, string> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager);
                /*0x72a79f4*/ void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName);
                /*0x72a7ea8*/ void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x72a9658*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName, Newtonsoft.Json.Converters.IXmlDocument document, string elementPrefix, System.Xml.XmlNamespaceManager manager);
                /*0x72a6644*/ void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x72a9b54*/ bool IsNamespaceAttribute(string attributeName, ref string prefix);
                /*0x72a5790*/ bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c);
                /*0x72a9c40*/ bool CanConvert(System.Type valueType);
                /*0x72a9ce8*/ bool IsXObject(System.Type valueType);
                /*0x72a9d68*/ bool IsXmlNode(System.Type valueType);
            }
        }

        namespace Bson
        {
            class BsonObjectId
            {
                /*0x10*/ byte[] <Value>k__BackingField;

                /*0x72a9e90*/ BsonObjectId(byte[] value);
                /*0x72a9e88*/ byte[] get_Value();
            }

            class BsonToken
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;

                /*0x72a9f7c*/ BsonToken();
                /*0x380c21c*/ Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x72a9f74*/ void set_Parent(Newtonsoft.Json.Bson.BsonToken value);
            }

            class BsonObject : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;

                /*0x72a9f84*/ void Add(string name, Newtonsoft.Json.Bson.BsonToken token);
                /*0x72aa12c*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonArray : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;

                /*0x72aa134*/ void Add(Newtonsoft.Json.Bson.BsonToken token);
                /*0x72aa1f0*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonValue : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ object _value;
                /*0x20*/ Newtonsoft.Json.Bson.BsonType _type;

                /*0x72aa1f8*/ BsonValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x72aa234*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonString : Newtonsoft.Json.Bson.BsonValue
            {
                /*0x21*/ bool <IncludeLength>k__BackingField;

                /*0x72aa0e8*/ BsonString(object value, bool includeLength);
            }

            class BsonRegex : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;
                /*0x20*/ Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;

                /*0x72aa24c*/ BsonRegex(string pattern, string options);
                /*0x72aa23c*/ void set_Pattern(Newtonsoft.Json.Bson.BsonString value);
                /*0x72aa244*/ void set_Options(Newtonsoft.Json.Bson.BsonString value);
                /*0x72aa320*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonProperty
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;

                /*0x72aa0e0*/ BsonProperty();
                /*0x72aa328*/ void set_Name(Newtonsoft.Json.Bson.BsonString value);
                /*0x72aa330*/ void set_Value(Newtonsoft.Json.Bson.BsonToken value);
            }

            enum BsonType
            {
                Number = 1,
                String = 2,
                Object = 3,
                Array = 4,
                Binary = 5,
                Undefined = 6,
                Oid = 7,
                Boolean = 8,
                Date = 9,
                Null = 10,
                Regex = 11,
                Reference = 12,
                Code = 13,
                Symbol = 14,
                CodeWScope = 15,
                Integer = 16,
                TimeStamp = 17,
                Long = 18,
                MinKey = -1,
                MaxKey = 127,
            }

            class BsonWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.Bson.BsonToken _root;
                /*0x68*/ Newtonsoft.Json.Bson.BsonToken _parent;
                /*0x70*/ string _propertyName;

                /*0x72aa338*/ void AddValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x72aa3b8*/ void AddToken(Newtonsoft.Json.Bson.BsonToken token);
                /*0x72aa5a0*/ void WriteObjectId(byte[] value);
                /*0x729c090*/ void WriteRegex(string pattern, string options);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0698228BF899CAEAB9A53E5E6C7099E846C44F56432050D234DDF03AD772F139;
    static /*0x2c*/ <PrivateImplementationDetails> 19AE20A57B073E3E8DD45C6F6A4E9AB1076EA3EBFFF28E4AEB58B411472CF994;
    static /*0x36*/ <PrivateImplementationDetails> 223D6CA32241C349E421A0164F2341E20CC5B65D5A04AA021CFF71D623895570;
    static /*0x5e*/ <PrivateImplementationDetails> 33350F5DA385CE1B8749AEC68BA060CD54EE981968522B5EDF62178537A1FEEE;
    static /*0x72*/ <PrivateImplementationDetails> 38809B9974198671140931F729415F3FD75DF68A6398E3486AE3B58554329A63;
    static /*0x9a*/ <PrivateImplementationDetails> 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6;
    static /*0xb6*/ <PrivateImplementationDetails> 4EDE3546F1189E450DF4D4A2739BE90BEB3B1708B3B9F406B02E0773A92A10FF;
    static /*0xc6*/ <PrivateImplementationDetails> 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA;
    static /*0xfa*/ <PrivateImplementationDetails> 5ADB7CA81690556AB2A3201A849839FA3562604BB469382C7D6D78AB426283E2;
    static /*0x116*/ <PrivateImplementationDetails> 5DDF815AC046E7D4603FA586D1BDE42118AD4FE9875D64F716BC7D2740EE52C9;
    static /*0x12e*/ <PrivateImplementationDetails> 605A3F93AE7A97E00C156F977E942027EA532E263A5B440A4219984F803FDD04;
    static /*0x13e*/ <PrivateImplementationDetails> 7367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62;
    static /*0x162*/ <PrivateImplementationDetails> 7439A4C9E30AC42BCC55AD1A2B617E29E7129B6DDAC79C886944B17819262CC1;
    static /*0x18a*/ <PrivateImplementationDetails> 990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5;
    static /*0x1b2*/ <PrivateImplementationDetails> A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89;
    static /*0x1c2*/ <PrivateImplementationDetails> B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122;
    static /*0x1d6*/ <PrivateImplementationDetails> CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326;
    static /*0x1ea*/ <PrivateImplementationDetails> D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A;
    static /*0x212*/ <PrivateImplementationDetails> F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7;
    static /*0x23a*/ <PrivateImplementationDetails> FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315;
    static /*0x26e*/ <PrivateImplementationDetails> FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A;

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=28
    {
    }

    struct __StaticArrayInitTypeSize=36
    {
    }

    struct __StaticArrayInitTypeSize=40
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=52
    {
    }
}
