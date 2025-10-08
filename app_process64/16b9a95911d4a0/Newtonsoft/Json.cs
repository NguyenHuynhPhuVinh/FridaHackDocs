class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x35b0294*/ EmbeddedAttribute();
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
                /*0x35b029c*/ IsReadOnlyAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x35b02a4*/ NullableAttribute(byte );
                /*0x35b032c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x35b035c*/ NullableContextAttribute(byte );
            }
        }
    }

    namespace Diagnostics
    {
        namespace CodeAnalysis
        {
            class NotNullAttribute : System.Attribute
            {
                /*0x35b0384*/ NotNullAttribute();
            }

            class NotNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x35b038c*/ NotNullWhenAttribute(bool returnValue);
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

            static /*0x35b03b4*/ DefaultJsonNameTable();
            static /*0x35b0604*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x35b0404*/ DefaultJsonNameTable();
            /*0x35b047c*/ string Get(char[] key, int start, int length);
            /*0x35b06c0*/ string Add(string key);
            /*0x35b0868*/ string AddEntry(string str, int hashCode);
            /*0x35b09d0*/ void Grow();

            class Entry
            {
                /*0x10*/ string Value;
                /*0x18*/ int HashCode;
                /*0x20*/ Newtonsoft.Json.DefaultJsonNameTable.Entry Next;

                /*0x35b097c*/ Entry(string value, int hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next);
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
            /*0x1f30240*/ T[] Rent(int minimumLength);
            /*0x1f30ebc*/ void Return(T[] array);
        }

        interface IJsonLineInfo
        {
            /*0x1f2fe14*/ bool HasLineInfo();
            /*0x1f2ffc8*/ int get_LineNumber();
            /*0x1f2ffc8*/ int get_LinePosition();
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

            /*0x35b0b30*/ System.Type get_ItemConverterType();
            /*0x35b0b38*/ object[] get_ItemConverterParameters();
            /*0x35b0b40*/ System.Type get_NamingStrategyType();
            /*0x35b0b48*/ object[] get_NamingStrategyParameters();
            /*0x35b0b50*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance();
            /*0x35b0b58*/ void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value);
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

            static /*0x35b1c7c*/ JsonConvert();
            static /*0x35b0b60*/ System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings();
            static /*0x35b0bb8*/ string ToString(bool value);
            static /*0x35b0c34*/ string ToString(char value);
            static /*0x35b0d0c*/ string ToString(float value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x35b0ec0*/ string EnsureFloatFormat(double value, string text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x35b0fd8*/ string ToString(double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x35b0dfc*/ string EnsureDecimalPlace(double value, string text);
            static /*0x35b10c4*/ string EnsureDecimalPlace(string text);
            static /*0x35b1138*/ string ToString(decimal value);
            static /*0x35b0cb4*/ string ToString(string value);
            static /*0x35b122c*/ string ToString(string value, char delimiter);
            static /*0x35b1294*/ string ToString(string value, char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
            static /*0x35b1378*/ string SerializeObject(object value);
            static /*0x35b1450*/ string SerializeObject(object value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x35b13d4*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x35b14ec*/ string SerializeObjectInternal(object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer);
            static /*0x1ffc854*/ T DeserializeObject<T>(string value);
            static /*0x1ffc854*/ T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x35b190c*/ object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
        }

        class JsonConverter
        {
            /*0x35b1df4*/ JsonConverter();
            /*0x1f310fc*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
            /*0x1f3040c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            /*0x1f2fec8*/ bool CanConvert(System.Type objectType);
            /*0x35b1de4*/ bool get_CanRead();
            /*0x35b1dec*/ bool get_CanWrite();
        }

        class JsonConverterAttribute : System.Attribute
        {
            /*0x10*/ System.Type _converterType;
            /*0x18*/ object[] <ConverterParameters>k__BackingField;

            /*0x35b1dfc*/ System.Type get_ConverterType();
            /*0x35b1e04*/ object[] get_ConverterParameters();
        }

        class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter>
        {
            /*0x35b1e0c*/ JsonConverterCollection();
        }

        class JsonDictionaryAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
        }

        class JsonException : System.Exception
        {
            /*0x35b1e54*/ JsonException();
            /*0x35b1eac*/ JsonException(string message);
            /*0x35b1f14*/ JsonException(string message, System.Exception innerException);
            /*0x35b1f84*/ JsonException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class JsonExtensionDataAttribute : System.Attribute
        {
            /*0x10*/ bool <WriteData>k__BackingField;
            /*0x11*/ bool <ReadData>k__BackingField;

            /*0x35b2004*/ bool get_WriteData();
            /*0x35b200c*/ bool get_ReadData();
        }

        class JsonIgnoreAttribute : System.Attribute
        {
        }

        class JsonNameTable
        {
            /*0x35b0474*/ JsonNameTable();
            /*0x1f30348*/ string Get(char[] key, int start, int length);
        }

        class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
            /*0x50*/ Newtonsoft.Json.MemberSerialization _memberSerialization;
            /*0x54*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;
            /*0x5c*/ System.Nullable<Newtonsoft.Json.Required> _itemRequired;
            /*0x64*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;

            /*0x35b2014*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
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

            static /*0x35b2b20*/ JsonPosition();
            static /*0x35b20a0*/ bool TypeHasIndex(Newtonsoft.Json.JsonContainerType type);
            static /*0x35b2364*/ string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition);
            static /*0x35b2800*/ string FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message);
            /*0x35b201c*/ JsonPosition(Newtonsoft.Json.JsonContainerType type);
            /*0x35b20b0*/ int CalculateLength();
            /*0x35b2144*/ void WriteTo(System.Text.StringBuilder sb, ref System.IO.StringWriter writer, ref char[] buffer);
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

            /*0x35b2be8*/ JsonPropertyAttribute();
            /*0x35b2bc0*/ System.Type get_ItemConverterType();
            /*0x35b2bc8*/ object[] get_ItemConverterParameters();
            /*0x35b2bd0*/ System.Type get_NamingStrategyType();
            /*0x35b2bd8*/ object[] get_NamingStrategyParameters();
            /*0x35b2be0*/ string get_PropertyName();
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

            /*0x35b3194*/ JsonReader();
            /*0x35b2bf0*/ Newtonsoft.Json.JsonReader.State get_CurrentState();
            /*0x35b2bf8*/ bool get_CloseInput();
            /*0x35b2c00*/ void set_CloseInput(bool value);
            /*0x35b2c08*/ bool get_SupportMultipleContent();
            /*0x35b2c10*/ void set_SupportMultipleContent(bool value);
            /*0x35b2c18*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x35b2c20*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x35b2c7c*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x35b2c84*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x35b2ce0*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x35b2ce8*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x35b2d44*/ string get_DateFormatString();
            /*0x35b2d4c*/ void set_DateFormatString(string value);
            /*0x35b2d54*/ System.Nullable<int> get_MaxDepth();
            /*0x35b2d5c*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x35b2edc*/ Newtonsoft.Json.JsonToken get_TokenType();
            /*0x35b2ee4*/ object get_Value();
            /*0x35b2eec*/ System.Type get_ValueType();
            /*0x35b2f00*/ int get_Depth();
            /*0x35b2f78*/ string get_Path();
            /*0x35b3080*/ System.Globalization.CultureInfo get_Culture();
            /*0x35b30e8*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x35b30f0*/ Newtonsoft.Json.JsonPosition GetPosition(int depth);
            /*0x35b322c*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x35b358c*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x35b37a0*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x1f2fe14*/ bool Read();
            /*0x35b37a8*/ System.Nullable<int> ReadAsInt32();
            /*0x35b3dc0*/ System.Nullable<int> ReadInt32String(string s);
            /*0x35b3f78*/ string ReadAsString();
            /*0x35b41fc*/ byte[] ReadAsBytes();
            /*0x35b47cc*/ byte[] ReadArrayIntoByteArray();
            /*0x35b48e8*/ bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<byte> buffer);
            /*0x35b4aa8*/ System.Nullable<double> ReadAsDouble();
            /*0x35b4d80*/ System.Nullable<double> ReadDoubleString(string s);
            /*0x35b4f30*/ System.Nullable<bool> ReadAsBoolean();
            /*0x35b5254*/ System.Nullable<bool> ReadBooleanString(string s);
            /*0x35b540c*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x35b5868*/ System.Nullable<decimal> ReadDecimalString(string s);
            /*0x35b5b08*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x35b5d94*/ System.Nullable<System.DateTime> ReadDateTimeString(string s);
            /*0x35b602c*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x35b62b0*/ System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s);
            /*0x35b4788*/ void ReaderReadAndAssert();
            /*0x35b6500*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException();
            /*0x35b45bc*/ void ReadIntoWrappedTypeObject();
            /*0x35b654c*/ void Skip();
            /*0x35b48dc*/ void SetToken(Newtonsoft.Json.JsonToken newToken);
            /*0x35b65e4*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value);
            /*0x35b3c1c*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value, bool updateIndex);
            /*0x35b66e8*/ void SetPostValueState(bool updateIndex);
            /*0x35b356c*/ void UpdateScopeWithFinishedValue();
            /*0x35b65ec*/ void ValidateEnd(Newtonsoft.Json.JsonToken endToken);
            /*0x35b67f0*/ void SetStateBasedOnCurrent();
            /*0x35b6724*/ void SetFinished();
            /*0x35b6748*/ Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token);
            /*0x35b68e4*/ void System.IDisposable.Dispose();
            /*0x35b6954*/ void Dispose(bool disposing);
            /*0x35b6978*/ void Close();
            /*0x35b6990*/ void ReadAndAssert();
            /*0x35b69ec*/ void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x35b6a38*/ bool ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x35b6d3c*/ bool ReadAndMoveToContent();
            /*0x35b6d6c*/ bool MoveToContent();
            /*0x35b3b40*/ Newtonsoft.Json.JsonToken GetContentToken();

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

            static /*0x35b3584*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x35b3b98*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x35b6e08*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x35b6db8*/ JsonReaderException();
            /*0x35b6dbc*/ JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x35b6dc0*/ JsonReaderException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
        }

        class JsonRequiredAttribute : System.Attribute
        {
        }

        class JsonSerializationException : Newtonsoft.Json.JsonException
        {
            /*0x8c*/ int <LineNumber>k__BackingField;
            /*0x90*/ int <LinePosition>k__BackingField;
            /*0x98*/ string <Path>k__BackingField;

            static /*0x35b69e4*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x35b7064*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x35b70e8*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x35b700c*/ JsonSerializationException();
            /*0x35b7010*/ JsonSerializationException(string message);
            /*0x35b7014*/ JsonSerializationException(string message, System.Exception innerException);
            /*0x35b7018*/ JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x35b701c*/ JsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
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

            static /*0x35b7d6c*/ Newtonsoft.Json.JsonSerializer Create();
            static /*0x35b7dbc*/ Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x35b8818*/ Newtonsoft.Json.JsonSerializer CreateDefault();
            static /*0x35b14b8*/ Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x35b7df0*/ void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x35bb74c*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType);
            /*0x35b7c20*/ JsonSerializer();
            /*0x35b72ec*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x35b739c*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x35b744c*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
            /*0x35b74bc*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
            /*0x35b752c*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x35b7534*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
            /*0x35b753c*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
            /*0x35b7544*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x35b75a0*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
            /*0x35b75fc*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
            /*0x35b7658*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x35b76b4*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x35b7710*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x35b7718*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x35b7774*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x35b77d0*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x35b782c*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
            /*0x35b7888*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x35b7890*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
            /*0x35b78ec*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
            /*0x35b7958*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x35b7960*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
            /*0x35b7a10*/ System.Runtime.Serialization.StreamingContext get_Context();
            /*0x35b7a1c*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
            /*0x35b7a28*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x35b7ae8*/ System.Nullable<int> get_MaxDepth();
            /*0x35b7af0*/ bool get_CheckAdditionalContent();
            /*0x35b7bb0*/ void set_CheckAdditionalContent(bool value);
            /*0x35b1af8*/ bool IsCheckAdditionalContentSet();
            /*0x35b9190*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
            /*0x35b91a0*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
            /*0x1ffc854*/ T Deserialize<T>(Newtonsoft.Json.JsonReader reader);
            /*0x35b1c6c*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x35ba218*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x35b9418*/ void SetupReader(Newtonsoft.Json.JsonReader reader, ref System.Globalization.CultureInfo previousCulture, ref System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, ref System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, ref System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, ref System.Nullable<int> previousMaxDepth, ref string previousDateFormatString);
            /*0x35b9e10*/ void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<int> previousMaxDepth, string previousDateFormatString);
            /*0x35b18fc*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x35ba498*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value);
            /*0x35b9d88*/ Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader);
            /*0x35ba4ac*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x35bb6d4*/ Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver();
            /*0x35bb744*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type);
            /*0x35bb8a8*/ void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e);
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

            static /*0x35bb910*/ JsonSerializerSettings();
            /*0x35bb998*/ JsonSerializerSettings();
            /*0x35b8bc8*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x35b8c88*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x35b8d48*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x35b8e08*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x35b8ec8*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x35bb8d0*/ System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters();
            /*0x35bb8d8*/ void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value);
            /*0x35b8b08*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
            /*0x35b88c8*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x35b8988*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x35b8a48*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
            /*0x35b8f88*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
            /*0x35bb8e0*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x35bb8e8*/ System.Collections.IEqualityComparer get_EqualityComparer();
            /*0x35bb8f0*/ System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider();
            /*0x35bb8f8*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x35bb900*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
            /*0x35bb908*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error();
            /*0x35b9048*/ System.Runtime.Serialization.StreamingContext get_Context();
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

            static /*0x35bc404*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x35c1788*/ object BigIntegerParse(string number, System.Globalization.CultureInfo culture);
            /*0x35b1b68*/ JsonTextReader(System.IO.TextReader reader);
            /*0x35bba20*/ Newtonsoft.Json.JsonNameTable get_PropertyNameTable();
            /*0x35bba28*/ void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value);
            /*0x35bba30*/ void EnsureBufferNotEmpty();
            /*0x35bba84*/ void SetNewLine(bool hasNextChar);
            /*0x35bbae4*/ void OnNewLine(int pos);
            /*0x35bbaf4*/ void ParseString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x35bc064*/ void ParseReadString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x35bbb3c*/ void ShiftBufferIfNeeded();
            /*0x35bc418*/ int ReadData(bool append);
            /*0x35bc4b0*/ void PrepareBufferForReadData(bool append, int charsRequired);
            /*0x35bc420*/ int ReadData(bool append, int charsRequired);
            /*0x35bc66c*/ bool EnsureChars(int relativePosition, bool append);
            /*0x35bc68c*/ bool ReadChars(int relativePosition, bool append);
            /*0x35bc6fc*/ bool Read();
            /*0x35bd5c0*/ System.Nullable<int> ReadAsInt32();
            /*0x35bda6c*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x35be030*/ string ReadAsString();
            /*0x35be064*/ byte[] ReadAsBytes();
            /*0x35bdb30*/ object ReadStringValue(Newtonsoft.Json.ReadType readType);
            /*0x35be8e0*/ object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType);
            /*0x35be678*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(char c);
            /*0x35bedac*/ System.Nullable<bool> ReadAsBoolean();
            /*0x35be614*/ void ProcessValueComma();
            /*0x35bd684*/ object ReadNumberValue(Newtonsoft.Json.ReadType readType);
            /*0x35bf360*/ object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType);
            /*0x35bf4f0*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x35bf5cc*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x35bf6a8*/ System.Nullable<double> ReadAsDouble();
            /*0x35be544*/ void HandleNull();
            /*0x35be798*/ void ReadFinished();
            /*0x35be4f4*/ bool ReadNullChar();
            /*0x35bc918*/ void EnsureBuffer();
            /*0x35bbbfc*/ void ReadStringIntoBuffer(char quote);
            /*0x35bf8a8*/ void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition);
            /*0x35bf858*/ void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition);
            /*0x35bf94c*/ char ConvertUnicode(bool enoughChars);
            /*0x35bf818*/ char ParseUnicode();
            /*0x35bfaa0*/ void ReadNumberIntoBuffer();
            /*0x35bfb24*/ bool ReadNumberCharIntoBuffer(char currentChar, int charPos);
            /*0x35bfc88*/ void ClearRecentString();
            /*0x35bcf90*/ bool ParsePostValue(bool ignoreComments);
            /*0x35bce20*/ bool ParseObject();
            /*0x35bfc94*/ bool ParseProperty();
            /*0x35bfebc*/ bool ValidIdentifierChar(char value);
            /*0x35bff10*/ void ParseUnquotedProperty();
            /*0x35c0000*/ bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition);
            /*0x35bc978*/ bool ParseValue();
            /*0x35be77c*/ void ProcessLineFeed();
            /*0x35be734*/ void ProcessCarriageReturn(bool append);
            /*0x35bd238*/ void EatWhitespace();
            /*0x35c02e0*/ void ParseConstructor();
            /*0x35beba0*/ void ParseNumber(Newtonsoft.Json.ReadType readType);
            /*0x35c06ac*/ void ParseReadNumber(Newtonsoft.Json.ReadType readType, char firstChar, int initialPosition);
            /*0x35c171c*/ Newtonsoft.Json.JsonReaderException ThrowReaderError(string message, System.Exception ex);
            /*0x35bd32c*/ void ParseComment(bool setToken);
            /*0x35c1810*/ void EndComment(bool setToken, int initialPosition, int endPosition);
            /*0x35c1850*/ bool MatchValue(string value);
            /*0x35c18ac*/ bool MatchValue(bool enoughChars, string value);
            /*0x35bec08*/ bool MatchValueWithTrailingSeparator(string value);
            /*0x35c1984*/ bool IsSeparator(char c);
            /*0x35c0130*/ void ParseTrue();
            /*0x35bf76c*/ void ParseNull();
            /*0x35c0600*/ void ParseUndefined();
            /*0x35c0208*/ void ParseFalse();
            /*0x35beb20*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType);
            /*0x35c1acc*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x35becac*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType);
            /*0x35c1c14*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x35bed2c*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType);
            /*0x35c1d5c*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x35c1ea4*/ void Close();
            /*0x35c1f24*/ bool HasLineInfo();
            /*0x35c1f2c*/ int get_LineNumber();
            /*0x35c1f74*/ int get_LinePosition();
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

            /*0x35b1738*/ JsonTextWriter(System.IO.TextWriter textWriter);
            /*0x35c1f80*/ Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder();
            /*0x35c2004*/ char get_QuoteChar();
            /*0x35c20ac*/ void Close();
            /*0x35c20e0*/ void CloseBufferAndWriter();
            /*0x35c2144*/ void WriteStartObject();
            /*0x35c21bc*/ void WriteStartArray();
            /*0x35c21f4*/ void WriteStartConstructor(string name);
            /*0x35c229c*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x35c2390*/ void WritePropertyName(string name);
            /*0x35c24c8*/ void WritePropertyName(string name, bool escape);
            /*0x35c2598*/ void OnStringEscapeHandlingChanged();
            /*0x35c2038*/ void UpdateCharEscapeFlags();
            /*0x35c259c*/ void WriteIndent();
            /*0x35c2710*/ int SetIndentChars();
            /*0x35c2804*/ void WriteValueDelimiter();
            /*0x35c2828*/ void WriteIndentSpace();
            /*0x35c284c*/ void WriteValueInternal(string value, Newtonsoft.Json.JsonToken token);
            /*0x35c286c*/ void WriteValue(object value);
            /*0x35c2adc*/ void WriteNull();
            /*0x35c2b70*/ void WriteUndefined();
            /*0x35c2c04*/ void WriteRaw(string json);
            /*0x35c2c28*/ void WriteValue(string value);
            /*0x35c240c*/ void WriteEscapedString(string value, bool quote);
            /*0x35c2d28*/ void WriteValue(int value);
            /*0x35c2db4*/ void WriteValue(uint value);
            /*0x35c2e40*/ void WriteValue(long value);
            /*0x35c2e84*/ void WriteValue(ulong value);
            /*0x35c2f3c*/ void WriteValue(float value);
            /*0x35c2ff4*/ void WriteValue(System.Nullable<float> value);
            /*0x35c31a4*/ void WriteValue(double value);
            /*0x35c325c*/ void WriteValue(System.Nullable<double> value);
            /*0x35c340c*/ void WriteValue(bool value);
            /*0x35c34a8*/ void WriteValue(short value);
            /*0x35c34ec*/ void WriteValue(ushort value);
            /*0x35c3530*/ void WriteValue(char value);
            /*0x35c35cc*/ void WriteValue(byte value);
            /*0x35c3610*/ void WriteValue(sbyte value);
            /*0x35c3654*/ void WriteValue(decimal value);
            /*0x35c3700*/ void WriteValue(System.DateTime value);
            /*0x35c3894*/ int WriteValueToBuffer(System.DateTime value);
            /*0x35c39a8*/ void WriteValue(byte[] value);
            /*0x35c3a70*/ void WriteValue(System.DateTimeOffset value);
            /*0x35c3bd8*/ int WriteValueToBuffer(System.DateTimeOffset value);
            /*0x35c3d48*/ void WriteValue(System.Guid value);
            /*0x35c3e54*/ void WriteValue(System.TimeSpan value);
            /*0x35c3f78*/ void WriteValue(System.Uri value);
            /*0x35c4048*/ void WriteComment(string text);
            /*0x35c2cdc*/ void EnsureWriteBuffer();
            /*0x35c2df8*/ void WriteIntegerValue(long value);
            /*0x35c2ecc*/ void WriteIntegerValue(ulong value, bool negative);
            /*0x35c4108*/ int WriteNumberToBuffer(ulong value, bool negative);
            /*0x35c2d6c*/ void WriteIntegerValue(int value);
            /*0x35c427c*/ void WriteIntegerValue(uint value, bool negative);
            /*0x35c41d4*/ int WriteNumberToBuffer(uint value, bool negative);
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

            static /*0x35c44d8*/ JsonWriter();
            static /*0x35c42ec*/ Newtonsoft.Json.JsonWriter.State[][] BuildStateArray();
            static /*0x35c77c4*/ void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value);
            static /*0x35c8870*/ void ResolveConvertibleValue(System.IConvertible convertible, ref Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, ref object value);
            static /*0x35c770c*/ Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, object value);
            /*0x35c200c*/ JsonWriter();
            /*0x35c47f8*/ bool get_CloseOutput();
            /*0x35c4800*/ void set_CloseOutput(bool value);
            /*0x35c4808*/ bool get_AutoCompleteOnClose();
            /*0x35c4810*/ void set_AutoCompleteOnClose(bool value);
            /*0x35c26c0*/ int get_Top();
            /*0x35c4820*/ Newtonsoft.Json.WriteState get_WriteState();
            /*0x35c48c4*/ string get_ContainerPath();
            /*0x35c4958*/ string get_Path();
            /*0x35c4a60*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x35b18a0*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x35c4a68*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0x35bb4f0*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0x35c4a70*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x35bb54c*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x35c4a78*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0x35bb604*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0x35c4a80*/ void OnStringEscapeHandlingChanged();
            /*0x35c4a84*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0x35bb5a8*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0x35c4a8c*/ string get_DateFormatString();
            /*0x35c4a94*/ void set_DateFormatString(string value);
            /*0x35bb66c*/ System.Globalization.CultureInfo get_Culture();
            /*0x35c4a9c*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x35c4aa4*/ void UpdateScopeWithFinishedValue();
            /*0x35c4abc*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x35c4bf0*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x35c4818*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x35c20d0*/ void Close();
            /*0x35c4d08*/ void WriteStartObject();
            /*0x35c4d14*/ void WriteEndObject();
            /*0x35c4d20*/ void WriteStartArray();
            /*0x35c4d2c*/ void WriteEndArray();
            /*0x35c4d34*/ void WriteStartConstructor(string name);
            /*0x35c4d40*/ void WriteEndConstructor();
            /*0x35c4d48*/ void WritePropertyName(string name);
            /*0x35c4d68*/ void WritePropertyName(string name, bool escape);
            /*0x35c4d78*/ void WriteEnd();
            /*0x35c4e58*/ void WriteToken(Newtonsoft.Json.JsonReader reader);
            /*0x35c4e60*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren);
            /*0x35c4ee0*/ void WriteToken(Newtonsoft.Json.JsonToken token, object value);
            /*0x35c5594*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            /*0x35c58a8*/ bool IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, bool writeChildren, int initialDepth);
            /*0x35c5778*/ int CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader);
            /*0x35c5914*/ int CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader);
            /*0x35c57dc*/ void WriteConstructorDate(Newtonsoft.Json.JsonReader reader);
            /*0x35c4d80*/ void WriteEnd(Newtonsoft.Json.JsonContainerType type);
            /*0x35c4cc8*/ void AutoCompleteAll();
            /*0x35c5974*/ Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type);
            /*0x35c5a10*/ void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type);
            /*0x35c5acc*/ int CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type);
            /*0x35c5bc4*/ void UpdateCurrentState();
            /*0x35c5c74*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x35c5c78*/ void WriteIndent();
            /*0x35c5c7c*/ void WriteValueDelimiter();
            /*0x35c5c80*/ void WriteIndentSpace();
            /*0x35c5c84*/ void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten);
            /*0x35c5e94*/ void WriteNull();
            /*0x35c5eb0*/ void WriteUndefined();
            /*0x35c5ecc*/ void WriteRaw(string json);
            /*0x35c5ed0*/ void WriteRawValue(string json);
            /*0x35c5f20*/ void WriteValue(string value);
            /*0x35c5f3c*/ void WriteValue(int value);
            /*0x35c5f58*/ void WriteValue(uint value);
            /*0x35c5f74*/ void WriteValue(long value);
            /*0x35c5f90*/ void WriteValue(ulong value);
            /*0x35c5fac*/ void WriteValue(float value);
            /*0x35c5fc8*/ void WriteValue(double value);
            /*0x35c5fe4*/ void WriteValue(bool value);
            /*0x35c6000*/ void WriteValue(short value);
            /*0x35c601c*/ void WriteValue(ushort value);
            /*0x35c6038*/ void WriteValue(char value);
            /*0x35c6054*/ void WriteValue(byte value);
            /*0x35c6070*/ void WriteValue(sbyte value);
            /*0x35c608c*/ void WriteValue(decimal value);
            /*0x35c60a8*/ void WriteValue(System.DateTime value);
            /*0x35c60c4*/ void WriteValue(System.DateTimeOffset value);
            /*0x35c60e0*/ void WriteValue(System.Guid value);
            /*0x35c60fc*/ void WriteValue(System.TimeSpan value);
            /*0x35c6118*/ void WriteValue(System.Nullable<int> value);
            /*0x35c6250*/ void WriteValue(System.Nullable<uint> value);
            /*0x35c6388*/ void WriteValue(System.Nullable<long> value);
            /*0x35c64c0*/ void WriteValue(System.Nullable<ulong> value);
            /*0x35c65f8*/ void WriteValue(System.Nullable<float> value);
            /*0x35c6730*/ void WriteValue(System.Nullable<double> value);
            /*0x35c6868*/ void WriteValue(System.Nullable<bool> value);
            /*0x35c69a0*/ void WriteValue(System.Nullable<short> value);
            /*0x35c6ad8*/ void WriteValue(System.Nullable<ushort> value);
            /*0x35c6c10*/ void WriteValue(System.Nullable<char> value);
            /*0x35c6d48*/ void WriteValue(System.Nullable<byte> value);
            /*0x35c6e80*/ void WriteValue(System.Nullable<sbyte> value);
            /*0x35c6fb8*/ void WriteValue(System.Nullable<decimal> value);
            /*0x35c7130*/ void WriteValue(System.Nullable<System.DateTime> value);
            /*0x35c7268*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
            /*0x35c73b0*/ void WriteValue(System.Nullable<System.Guid> value);
            /*0x35c74f8*/ void WriteValue(System.Nullable<System.TimeSpan> value);
            /*0x35c7630*/ void WriteValue(byte[] value);
            /*0x35c7660*/ void WriteValue(System.Uri value);
            /*0x35c29a8*/ void WriteValue(object value);
            /*0x35c87d8*/ void WriteComment(string text);
            /*0x35c87e0*/ void System.IDisposable.Dispose();
            /*0x35c8850*/ void Dispose(bool disposing);
            /*0x35c89f0*/ void SetWriteState(Newtonsoft.Json.JsonToken token, object value);
            /*0x35c4d1c*/ void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container);
            /*0x35c23ec*/ void InternalWritePropertyName(string name);
            /*0x35c2c24*/ void InternalWriteRaw();
            /*0x35c217c*/ void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container);
            /*0x35c2990*/ void InternalWriteValue(Newtonsoft.Json.JsonToken token);
            /*0x35c4100*/ void InternalWriteComment();

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

            static /*0x35c8c08*/ Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, string message, System.Exception ex);
            static /*0x35c8c3c*/ Newtonsoft.Json.JsonWriterException Create(string path, string message, System.Exception ex);
            /*0x35c8bc4*/ JsonWriterException();
            /*0x35c8bcc*/ JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x35c8bd4*/ JsonWriterException(string message, string path, System.Exception innerException);
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

                /*0x35c8cfc*/ Base64Encoder(System.IO.TextWriter writer);
                /*0x35c8de8*/ void ValidateEncode(byte[] buffer, int index, int count);
                /*0x35c8eac*/ void Encode(byte[] buffer, int index, int count);
                /*0x35c9108*/ void StoreLeftOverBytes(byte[] buffer, int index, ref int count);
                /*0x35c904c*/ bool FulfillFromLeftover(byte[] buffer, int index, ref int count);
                /*0x35c9220*/ void Flush();
                /*0x35c90e8*/ void WriteChars(char[] chars, int index, int count);
            }

            class BidirectionalDictionary<TFirst, TSecond>
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TFirst, TSecond> _firstToSecond;
                /*0x0*/ System.Collections.Generic.IDictionary<TSecond, TFirst> _secondToFirst;
                /*0x0*/ string _duplicateFirstErrorMessage;
                /*0x0*/ string _duplicateSecondErrorMessage;

                /*0x1f31134*/ BidirectionalDictionary(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage);
                /*0x1ffc854*/ void Set(TFirst first, TSecond second);
                /*0x1ffc854*/ bool TryGetByFirst(TFirst first, ref TSecond second);
                /*0x1ffc854*/ bool TryGetBySecond(TSecond second, ref TFirst first);
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

                static /*0x35c9928*/ BoxedPrimitives();
                static /*0x35c92d8*/ object Get(bool value);
                static /*0x35c9350*/ object Get(int value);
                static /*0x35c9594*/ object Get(long value);
                static /*0x35c9734*/ object Get(decimal value);
                static /*0x35c981c*/ object Get(double value);
            }

            class CollectionUtils
            {
                static /*0x1f31840*/ bool IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection);
                static /*0x1f36f18*/ void AddRange<T>(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection);
                static /*0x35c9e50*/ bool IsDictionaryType(System.Type type);
                static /*0x35ca04c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType);
                static /*0x35ca15c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType);
                static /*0x1f321f0*/ int IndexOf<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, bool> predicate);
                static /*0x1ffc854*/ bool Contains<T>(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer);
                static /*0x1ffc854*/ int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
                static /*0x1f350f8*/ void FastReverse<T>(System.Collections.Generic.List<T> list);
                static /*0x35ca484*/ System.Collections.Generic.IList<int> GetDimensions(System.Collections.IList values, int dimensionsCount);
                static /*0x35ca738*/ void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, int[] indices);
                static /*0x35ca9ec*/ object JaggedArrayGetValue(System.Collections.IList values, int[] indices);
                static /*0x35cab8c*/ System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, int rank);
                static /*0x1f327a0*/ T[] ArrayEmpty<T>();

                class EmptyArrayContainer<T>
                {
                    static /*0x0*/ T[] Empty;

                    static /*0x1f33998*/ EmptyArrayContainer();
                }
            }

            interface IWrappedCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x1f30214*/ object get_UnderlyingCollection();
            }

            class CollectionWrapper<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedCollection, System.Collections.IList, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IList _list;
                /*0x0*/ System.Collections.Generic.ICollection<T> _genericCollection;
                /*0x0*/ object _syncRoot;

                static /*0x1f350f8*/ void VerifyValueType(object value);
                static /*0x1f31840*/ bool IsCompatibleObject(object value);
                /*0x1ffc854*/ void Add(T item);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(T item);
                /*0x1f30ee8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2fe14*/ bool get_IsReadOnly();
                /*0x1ffc854*/ bool Remove(T item);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f3008c*/ int System.Collections.IList.Add(object value);
                /*0x1f2fec8*/ bool System.Collections.IList.Contains(object value);
                /*0x1f3008c*/ int System.Collections.IList.IndexOf(object value);
                /*0x1f30b78*/ void System.Collections.IList.RemoveAt(int index);
                /*0x1f30c88*/ void System.Collections.IList.Insert(int index, object value);
                /*0x1f2fe14*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x1f30ebc*/ void System.Collections.IList.Remove(object value);
                /*0x1f30240*/ object System.Collections.IList.get_Item(int index);
                /*0x1f30c88*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f30214*/ object get_UnderlyingCollection();
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

                /*0x35cad80*/ TypeInformation(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode);
                /*0x35cad70*/ System.Type get_Type();
                /*0x35cad78*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
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

                static /*0x35ce084*/ ConvertUtils();
                static /*0x35cadbc*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t);
                static /*0x35cae24*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, ref bool isEnum);
                static /*0x35cb190*/ Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable);
                static /*0x35cb27c*/ bool IsConvertible(System.Type t);
                static /*0x35cb2fc*/ System.TimeSpan ParseTimeSpan(string input);
                static /*0x35cb38c*/ System.Func<object, object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type> t);
                static /*0x35cb5ec*/ System.Numerics.BigInteger ToBigInteger(object value);
                static /*0x35cb98c*/ object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType);
                static /*0x35cbe14*/ object Convert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x35ccb44*/ bool TryConvert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x35cc070*/ Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x35ccff8*/ object ConvertOrCast(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x35ccd9c*/ object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType);
                static /*0x35cccf8*/ bool VersionTryParse(string input, ref System.Version result);
                static /*0x35ccc6c*/ bool IsInteger(object value);
                static /*0x35cd164*/ Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, ref int value);
                static /*0x35cd2ec*/ Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, ref long value);
                static /*0x35cd454*/ Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, ref decimal value);
                static /*0x35cdf58*/ bool TryConvertGuid(string s, ref System.Guid g);
                static /*0x35cdfb4*/ bool TryHexTextToInt(char[] text, int start, int end, ref int value);

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

                    /*0x35cb5e4*/ <>c__DisplayClass8_0();
                    /*0x35cf384*/ object <CreateCastConverter>b__0(object o);
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

                static /*0x35cf450*/ DateTimeParser();
                /*0x35cf6d4*/ bool Parse(char[] text, int startIndex, int length);
                /*0x35cf7d4*/ bool ParseDate(int start);
                /*0x35cf9c0*/ bool ParseTimeAndZoneAndWhitespace(int start);
                /*0x35cfbd8*/ bool ParseTime(ref int start);
                /*0x35cfea0*/ bool ParseZone(int start);
                /*0x35cfa5c*/ bool Parse4Digit(int start, ref int num);
                /*0x35cfb40*/ bool Parse2Digit(int start, ref int num);
                /*0x35cf974*/ bool ParseChar(int start, char ch);
            }

            class DateTimeUtils
            {
                static /*0x0*/ long InitialJavaScriptDateTicks;
                static /*0x8*/ int[] DaysToMonth365;
                static /*0x10*/ int[] DaysToMonth366;

                static /*0x35d00a0*/ DateTimeUtils();
                static /*0x35d0198*/ System.TimeSpan GetUtcOffset(System.DateTime d);
                static /*0x35d0200*/ System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind);
                static /*0x35d0378*/ System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone);
                static /*0x35d04c8*/ System.DateTime SwitchToLocalTime(System.DateTime value);
                static /*0x35d05a4*/ System.DateTime SwitchToUtcTime(System.DateTime value);
                static /*0x35d0680*/ long ToUniversalTicks(System.DateTime dateTime);
                static /*0x35d0740*/ long ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x35d0898*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x35d097c*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime);
                static /*0x35d09d4*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, bool convertToUtc);
                static /*0x35d0900*/ long UniversalTicksToJavaScriptTicks(long universalTicks);
                static /*0x35d0a90*/ System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks);
                static /*0x35d0b18*/ bool TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x35d1058*/ bool TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x35d0f5c*/ System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser);
                static /*0x35d12d4*/ bool TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x35d1920*/ bool TryParseDateTime(string s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x35d1c14*/ bool TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x35d2030*/ bool TryParseDateTimeOffset(string s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x35d22f8*/ bool TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, ref long ticks, ref System.TimeSpan offset, ref System.DateTimeKind kind);
                static /*0x35d16ac*/ bool TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x35d1838*/ bool TryParseDateTimeExact(string text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x35d1e20*/ bool TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x35d1f84*/ bool TryParseDateTimeOffsetExact(string text, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x35d24fc*/ bool TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, int startIndex, ref System.TimeSpan offset);
                static /*0x35d268c*/ void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x35d27fc*/ int WriteDateTimeString(char[] chars, int start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format);
                static /*0x35d2e28*/ int WriteDefaultIsoDate(char[] chars, int start, System.DateTime dt);
                static /*0x35d3490*/ void CopyIntToCharArray(char[] chars, int start, int value, int digits);
                static /*0x35d2c74*/ int WriteDateTimeOffset(char[] chars, int start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format);
                static /*0x35d34f8*/ void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x35d3254*/ void GetDateValues(System.DateTime td, ref int year, ref int month, ref int day);
            }

            interface IWrappedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x1f30214*/ object get_UnderlyingDictionary();
            }

            class DictionaryWrapper<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedDictionary, System.Collections.IDictionary, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IDictionary _dictionary;
                /*0x0*/ System.Collections.Generic.IDictionary<TKey, TValue> _genericDictionary;
                /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;
                /*0x0*/ object _syncRoot;

                /*0x1f30214*/ System.Collections.Generic.IDictionary<TKey, TValue> get_GenericDictionary();
                /*0x1ffc854*/ void Add(TKey key, TValue value);
                /*0x1ffc854*/ bool ContainsKey(TKey key);
                /*0x1f30214*/ System.Collections.Generic.ICollection<TKey> get_Keys();
                /*0x1ffc854*/ bool Remove(TKey key);
                /*0x1ffc854*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x1f30214*/ System.Collections.Generic.ICollection<TValue> get_Values();
                /*0x1ffc854*/ TValue get_Item(TKey key);
                /*0x1ffc854*/ void set_Item(TKey key, TValue value);
                /*0x1ffc854*/ void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f30ee8*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2fe14*/ bool get_IsReadOnly();
                /*0x1ffc854*/ bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f30ff0*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x1f302cc*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x1f30ff0*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x1f30214*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x1f2fec8*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x1f2fe14*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x1f30ebc*/ void Remove(object key);
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f30214*/ object get_UnderlyingDictionary();

                struct DictionaryEnumerator`2<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    /*0x1f30ebc*/ DictionaryEnumerator`2(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    System.Collections.DictionaryEntry get_Entry();
                    /*0x1f30214*/ object get_Key();
                    /*0x1f30214*/ object get_Value();
                    /*0x1f30214*/ object get_Current();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void Reset();
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.DictionaryEntry, System.Collections.Generic.KeyValuePair<TKey, TValue>> <>9__29_0;

                    static /*0x1f33998*/ <>c();
                    /*0x1f309e4*/ <>c();
                    /*0x1ffc854*/ System.Collections.Generic.KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(System.Collections.DictionaryEntry de);
                }
            }

            class DynamicProxy<T>
            {
                /*0x1f309e4*/ DynamicProxy();
                /*0x1ffc854*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(T instance);
                /*0x1ffc854*/ bool TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
                /*0x1ffc854*/ bool TryConvert(T instance, System.Dynamic.ConvertBinder binder, ref object result);
                /*0x1ffc854*/ bool TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, object[] args, ref object result);
                /*0x1ffc854*/ bool TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, object[] indexes);
                /*0x1ffc854*/ bool TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder);
                /*0x1ffc854*/ bool TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, object[] indexes, ref object result);
                /*0x1ffc854*/ bool TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, ref object result);
                /*0x1ffc854*/ bool TryInvoke(T instance, System.Dynamic.InvokeBinder binder, object[] args, ref object result);
                /*0x1ffc854*/ bool TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, object[] args, ref object result);
                /*0x1ffc854*/ bool TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, object[] indexes, object value);
                /*0x1ffc854*/ bool TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, object value);
                /*0x1ffc854*/ bool TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, ref object result);
            }

            class DynamicProxyMetaObject<T> : System.Dynamic.DynamicMetaObject
            {
                /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;

                static /*0x1f327a0*/ System.Linq.Expressions.Expression[] get_NoArgs();
                static /*0x1f327cc*/ System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args);
                static /*0x1f327cc*/ System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args);
                static /*0x1f32888*/ System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value);
                static /*0x1f327cc*/ System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder);
                /*0x1ffc854*/ DynamicProxyMetaObject(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy);
                /*0x1f2fec8*/ bool IsOverridden(string method);
                /*0x1f302cc*/ System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value);
                /*0x1f302cc*/ System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder);
                /*0x1f302cc*/ System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg);
                /*0x1f302cc*/ System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                /*0x1f303d0*/ System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value);
                /*0x1f30394*/ System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                /*0x1f30448*/ System.Dynamic.DynamicMetaObject CallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                /*0x1f30448*/ System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                /*0x1f3040c*/ System.Dynamic.DynamicMetaObject CallMethodReturnLast(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                /*0x1f3040c*/ System.Dynamic.DynamicMetaObject CallMethodNoResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                /*0x1f30214*/ System.Dynamic.BindingRestrictions GetRestrictions();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames();

                class Fallback<T> : System.MulticastDelegate
                {
                    Fallback(object object, nint method);
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion);
                }

                class GetBinderAdapter<T> : System.Dynamic.GetMemberBinder
                {
                    /*0x1f30ebc*/ GetBinderAdapter(System.Dynamic.InvokeMemberBinder binder);
                    /*0x1f30394*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
                }

                class <>c<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Dynamic.DynamicMetaObject, System.Linq.Expressions.Expression> <>9__18_0;

                    static /*0x1f33998*/ <>c();
                    /*0x1f309e4*/ <>c();
                    /*0x1f302cc*/ System.Linq.Expressions.Expression <GetArgs>b__18_0(System.Dynamic.DynamicMetaObject arg);
                }

                class <>c__DisplayClass10_0<T>
                {
                    /*0x0*/ System.Dynamic.BinaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject arg;

                    /*0x1f309e4*/ <>c__DisplayClass10_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindBinaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass11_0<T>
                {
                    /*0x0*/ System.Dynamic.UnaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x1f309e4*/ <>c__DisplayClass11_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindUnaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass12_0<T>
                {
                    /*0x0*/ System.Dynamic.GetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    /*0x1f309e4*/ <>c__DisplayClass12_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindGetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass13_0<T>
                {
                    /*0x0*/ System.Dynamic.SetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    /*0x1f309e4*/ <>c__DisplayClass13_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindSetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass14_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    /*0x1f309e4*/ <>c__DisplayClass14_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindDeleteIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass3_0<T>
                {
                    /*0x0*/ System.Dynamic.GetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x1f309e4*/ <>c__DisplayClass3_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindGetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Dynamic.SetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    /*0x1f309e4*/ <>c__DisplayClass4_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindSetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x1f309e4*/ <>c__DisplayClass5_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindDeleteMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Dynamic.ConvertBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x1f309e4*/ <>c__DisplayClass6_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindConvert>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x1f309e4*/ <>c__DisplayClass7_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindInvokeMember>b__0(System.Dynamic.DynamicMetaObject e);
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindInvokeMember>b__1(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Dynamic.CreateInstanceBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x1f309e4*/ <>c__DisplayClass8_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindCreateInstance>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x1f309e4*/ <>c__DisplayClass9_0();
                    /*0x1f302cc*/ System.Dynamic.DynamicMetaObject <BindInvoke>b__0(System.Dynamic.DynamicMetaObject e);
                }
            }

            class DynamicUtils
            {
                static /*0x35d36cc*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider);

                class BinderWrapper
                {
                    static /*0x0*/ object _getCSharpArgumentInfoArray;
                    static /*0x8*/ object _setCSharpArgumentInfoArray;
                    static /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _getMemberCall;
                    static /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _setMemberCall;
                    static /*0x20*/ bool _init;

                    static /*0x35d37b4*/ void Init();
                    static /*0x35d3998*/ object CreateSharpArgumentInfoArray(int[] values);
                    static /*0x35d3c58*/ void CreateMemberCalls();
                    static /*0x35d4180*/ System.Runtime.CompilerServices.CallSiteBinder GetMember(string name, System.Type context);
                    static /*0x35d4388*/ System.Runtime.CompilerServices.CallSiteBinder SetMember(string name, System.Type context);
                }
            }

            class NoThrowGetBinderMember : System.Dynamic.GetMemberBinder
            {
                /*0x28*/ System.Dynamic.GetMemberBinder _innerBinder;

                /*0x35d4590*/ NoThrowGetBinderMember(System.Dynamic.GetMemberBinder innerBinder);
                /*0x35d45d0*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowSetBinderMember : System.Dynamic.SetMemberBinder
            {
                /*0x28*/ System.Dynamic.SetMemberBinder _innerBinder;

                /*0x35d4728*/ NoThrowSetBinderMember(System.Dynamic.SetMemberBinder innerBinder);
                /*0x35d4768*/ System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
            {
                static /*0x0*/ object ErrorResult;

                static /*0x35d49a8*/ NoThrowExpressionVisitor();
                /*0x35d4720*/ NoThrowExpressionVisitor();
                /*0x35d48bc*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node);
            }

            class EnumInfo
            {
                /*0x10*/ bool IsFlags;
                /*0x18*/ ulong[] Values;
                /*0x20*/ string[] Names;
                /*0x28*/ string[] ResolvedNames;

                /*0x35d4a24*/ EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames);
            }

            class EnumUtils
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy>, Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;
                static /*0x8*/ Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;

                static /*0x35d60ec*/ EnumUtils();
                static /*0x35d4a8c*/ Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy> key);
                static /*0x35d5264*/ bool TryToString(System.Type enumType, object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, ref string name);
                static /*0x35d5414*/ string InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, ulong result);
                static /*0x35d55b8*/ Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType);
                static /*0x35d4f64*/ ulong ToUInt64(object value);
                static /*0x35d5684*/ object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, string value, bool disallowNumber);
                static /*0x35d5fd0*/ System.Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, System.StringComparison comparison);
                static /*0x35d5ed4*/ System.Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, System.StringComparison comparison);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.EnumUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Runtime.Serialization.EnumMemberAttribute, string> <>9__3_0;

                    static /*0x35d6218*/ <>c();
                    /*0x35d6280*/ <>c();
                    /*0x35d6288*/ string <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a);
                }
            }

            class FSharpFunction
            {
                /*0x10*/ object _instance;
                /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _invoker;

                /*0x35d629c*/ FSharpFunction(object instance, Newtonsoft.Json.Utilities.MethodCall<object, object> invoker);
                /*0x35d62e0*/ object Invoke(object[] args);
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

                static /*0x35d7000*/ FSharpUtils();
                static /*0x35d6ae4*/ Newtonsoft.Json.Utilities.FSharpUtils get_Instance();
                static /*0x35d6bd4*/ void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly);
                static /*0x35d6874*/ System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, System.Reflection.BindingFlags bindingFlags);
                static /*0x35d68e8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName);
                /*0x35d6318*/ FSharpUtils(System.Reflection.Assembly fsharpCoreAssembly);
                /*0x35d6b3c*/ void set_FSharpCoreAssembly(System.Reflection.Assembly value);
                /*0x35d6b44*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_IsUnion();
                /*0x35d6b4c*/ void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x35d6b54*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCases();
                /*0x35d6b5c*/ void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x35d6b64*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionTagReader();
                /*0x35d6b6c*/ void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x35d6b74*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionReader();
                /*0x35d6b7c*/ void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x35d6b84*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionConstructor();
                /*0x35d6b8c*/ void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x35d6b94*/ System.Func<object, object> get_GetUnionCaseInfoDeclaringType();
                /*0x35d6b9c*/ void set_GetUnionCaseInfoDeclaringType(System.Func<object, object> value);
                /*0x35d6ba4*/ System.Func<object, object> get_GetUnionCaseInfoName();
                /*0x35d6bac*/ void set_GetUnionCaseInfoName(System.Func<object, object> value);
                /*0x35d6bb4*/ System.Func<object, object> get_GetUnionCaseInfoTag();
                /*0x35d6bbc*/ void set_GetUnionCaseInfoTag(System.Func<object, object> value);
                /*0x35d6bc4*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCaseInfoFields();
                /*0x35d6bcc*/ void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x35d6d4c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateSeq(System.Type t);
                /*0x35d6e54*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType);
                /*0x1f30214*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> BuildMapCreator<TKey, TValue>();

                class <>c__55<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Tuple<TKey, TValue>> <>9__55_1;

                    static /*0x1f33998*/ <>c__55();
                    /*0x1f309e4*/ <>c__55();
                    /*0x1ffc854*/ System.Tuple<TKey, TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey, TValue> kv);
                }

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;
                    /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> invoke;

                    /*0x35d6d44*/ <>c__DisplayClass52_0();
                    /*0x35d707c*/ object <CreateFSharpFuncCall>b__0(object target, object[] args);
                }

                class <>c__DisplayClass55_0<TKey, TValue>
                {
                    /*0x0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> ctorDelegate;

                    /*0x1f309e4*/ <>c__DisplayClass55_0();
                    /*0x1f302cc*/ object <BuildMapCreator>b__0(object[] args);
                }
            }

            class ImmutableCollectionsUtils
            {
                static /*0x0*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;
                static /*0x8*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

                static /*0x35d7b14*/ ImmutableCollectionsUtils();
                static /*0x35d7118*/ bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);
                static /*0x35d75f8*/ bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);

                class ImmutableCollectionTypeInfo
                {
                    /*0x10*/ string <ContractTypeName>k__BackingField;
                    /*0x18*/ string <CreatedTypeName>k__BackingField;
                    /*0x20*/ string <BuilderTypeName>k__BackingField;

                    /*0x35d8010*/ ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName);
                    /*0x35d8070*/ string get_ContractTypeName();
                    /*0x35d8078*/ void set_ContractTypeName(string value);
                    /*0x35d8080*/ string get_CreatedTypeName();
                    /*0x35d8088*/ void set_CreatedTypeName(string value);
                    /*0x35d8090*/ string get_BuilderTypeName();
                    /*0x35d8098*/ void set_BuilderTypeName(string value);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__24_1;
                    static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__25_1;

                    static /*0x35d80a0*/ <>c();
                    /*0x35d8108*/ <>c();
                    /*0x35d8110*/ bool <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m);
                    /*0x35d81a4*/ bool <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string name;

                    /*0x35d75d4*/ <>c__DisplayClass24_0();
                    /*0x35d82f4*/ bool <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ string name;

                    /*0x35d7b0c*/ <>c__DisplayClass25_0();
                    /*0x35d8314*/ bool <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }
            }

            class BufferUtils
            {
                static /*0x35d8334*/ char[] RentBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int minSize);
                static /*0x35d83fc*/ void ReturnBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer);
                static /*0x35d84ac*/ char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int size, char[] buffer);
            }

            class JavaScriptUtils
            {
                static /*0x0*/ bool[] SingleQuoteCharEscapeFlags;
                static /*0x8*/ bool[] DoubleQuoteCharEscapeFlags;
                static /*0x10*/ bool[] HtmlCharEscapeFlags;

                static /*0x35d85e8*/ JavaScriptUtils();
                static /*0x35d9018*/ bool[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, char quoteChar);
                static /*0x35d90c4*/ bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags);
                static /*0x35d9140*/ void WriteEscapedJavaScriptString(System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<char> bufferPool, ref char[] writeBuffer);
                static /*0x35d98a4*/ string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x35d9734*/ int FirstCharToEscape(string s, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x35d9b40*/ bool TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, ref System.DateTime dateTime, ref string errorMessage);
                static /*0x35d9fa8*/ bool TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, ref System.Nullable<long> integer, ref string errorMessage);
            }

            class JsonTokenUtils
            {
                static /*0x35da160*/ bool IsEndToken(Newtonsoft.Json.JsonToken token);
                static /*0x35da170*/ bool IsStartToken(Newtonsoft.Json.JsonToken token);
                static /*0x35da180*/ bool IsPrimitiveToken(Newtonsoft.Json.JsonToken token);
            }

            class LateBoundReflectionDelegateFactory : Newtonsoft.Json.Utilities.ReflectionDelegateFactory
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

                static /*0x35da3a8*/ LateBoundReflectionDelegateFactory();
                static /*0x35da198*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance();
                /*0x35da398*/ LateBoundReflectionDelegateFactory();
                /*0x35da1f0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                /*0x1f302cc*/ Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                /*0x1f302cc*/ System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                /*0x1f302cc*/ System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                /*0x1f302cc*/ System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x1f302cc*/ System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x1f302cc*/ System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.Reflection.ConstructorInfo c;
                    /*0x18*/ System.Reflection.MethodBase method;

                    /*0x35da390*/ <>c__DisplayClass3_0();
                    /*0x35da410*/ object <CreateParameterizedConstructor>b__0(object[] a);
                    /*0x35da428*/ object <CreateParameterizedConstructor>b__1(object[] a);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Reflection.ConstructorInfo c;
                    /*0x0*/ System.Reflection.MethodBase method;

                    /*0x1f309e4*/ <>c__DisplayClass4_0();
                    /*0x1ffc854*/ object <CreateMethodCall>b__0(T o, object[] a);
                    /*0x1ffc854*/ object <CreateMethodCall>b__1(T o, object[] a);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Type type;
                    /*0x0*/ System.Reflection.ConstructorInfo constructorInfo;

                    /*0x1f309e4*/ <>c__DisplayClass5_0();
                    /*0x1ffc854*/ T <CreateDefaultConstructor>b__0();
                    /*0x1ffc854*/ T <CreateDefaultConstructor>b__1();
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x1f309e4*/ <>c__DisplayClass6_0();
                    /*0x1ffc854*/ object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x1f309e4*/ <>c__DisplayClass7_0();
                    /*0x1ffc854*/ object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x1f309e4*/ <>c__DisplayClass8_0();
                    /*0x1ffc854*/ void <CreateSet>b__0(T o, object v);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x1f309e4*/ <>c__DisplayClass9_0();
                    /*0x1ffc854*/ void <CreateSet>b__0(T o, object v);
                }
            }

            class MathUtils
            {
                static /*0x35da448*/ int IntLength(ulong i);
                static /*0x35da60c*/ char IntToHex(int n);
                static /*0x35da624*/ bool ApproxEquals(double d1, double d2);
            }

            class MethodCall<T, TResult> : System.MulticastDelegate
            {
                MethodCall(object object, nint method);
                /*0x1ffc854*/ TResult Invoke(T target, object[] args);
            }

            class MiscellaneousUtils
            {
                static /*0x35da6c0*/ bool ValueEquals(object objA, object objB);
                static /*0x35d0280*/ System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message);
                static /*0x35da9ec*/ string ToString(object value);
                static /*0x35daa90*/ int ByteArrayCompare(byte[] a1, byte[] a2);
                static /*0x35dab44*/ string GetPrefix(string qualifiedName);
                static /*0x35dac24*/ string GetLocalName(string qualifiedName);
                static /*0x35dab68*/ void GetQualifiedNameParts(string qualifiedName, ref string prefix, ref string localName);
                static /*0x35dac5c*/ System.Text.RegularExpressions.RegexOptions GetRegexOptions(string optionsText);
            }

            class ReflectionDelegateFactory
            {
                /*0x35da3a0*/ ReflectionDelegateFactory();
                /*0x1f302cc*/ System.Func<T, object> CreateGet<T>(System.Reflection.MemberInfo memberInfo);
                /*0x1f302cc*/ System.Action<T, object> CreateSet<T>(System.Reflection.MemberInfo memberInfo);
                /*0x1f302cc*/ Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                /*0x1f302cc*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                /*0x1f302cc*/ System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                /*0x1f302cc*/ System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                /*0x1f302cc*/ System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x1f302cc*/ System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x1f302cc*/ System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);
            }

            class ReflectionMember
            {
                /*0x10*/ System.Type <MemberType>k__BackingField;
                /*0x18*/ System.Func<object, object> <Getter>k__BackingField;
                /*0x20*/ System.Action<object, object> <Setter>k__BackingField;

                /*0x35dad34*/ ReflectionMember();
                /*0x35dad04*/ System.Type get_MemberType();
                /*0x35dad0c*/ void set_MemberType(System.Type value);
                /*0x35dad14*/ System.Func<object, object> get_Getter();
                /*0x35dad1c*/ void set_Getter(System.Func<object, object> value);
                /*0x35dad24*/ System.Action<object, object> get_Setter();
                /*0x35dad2c*/ void set_Setter(System.Action<object, object> value);
            }

            class ReflectionObject
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <Creator>k__BackingField;
                /*0x18*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;

                static /*0x35db058*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, string[] memberNames);
                static /*0x35db064*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, string[] memberNames);
                /*0x35dad4c*/ ReflectionObject(Newtonsoft.Json.Serialization.ObjectConstructor<object> creator);
                /*0x35dad3c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_Creator();
                /*0x35dad44*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> get_Members();
                /*0x35dade8*/ object GetValue(object target, string member);
                /*0x35daec8*/ void SetValue(object target, string member, object value);
                /*0x35dafa4*/ System.Type GetType(string member);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ System.Func<object> ctor;

                    /*0x35db9a0*/ <>c__DisplayClass11_0();
                    /*0x35dbec8*/ object <Create>b__0(object[] args);
                }

                class <>c__DisplayClass11_1
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x35dbc90*/ <>c__DisplayClass11_1();
                    /*0x35dbef8*/ object <Create>b__1(object target);
                }

                class <>c__DisplayClass11_2
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x35dbc98*/ <>c__DisplayClass11_2();
                    /*0x35dbfc4*/ void <Create>b__2(object target, object arg);
                }
            }

            class ReflectionUtils
            {
                static /*0x0*/ System.Type[] EmptyTypes;

                static /*0x35dc098*/ ReflectionUtils();
                static /*0x35dc10c*/ bool IsVirtual(System.Reflection.PropertyInfo propertyInfo);
                static /*0x35dc1ec*/ System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo);
                static /*0x35dc2ac*/ bool IsPublic(System.Reflection.PropertyInfo property);
                static /*0x35cd154*/ System.Type GetObjectType(object v);
                static /*0x35dc33c*/ string GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x35dc414*/ string GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x35dc54c*/ string RemoveAssemblyDetails(string fullyQualifiedTypeName);
                static /*0x35db8b4*/ bool HasDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x35dc810*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t);
                static /*0x35dc6c8*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x35ccd00*/ bool IsNullable(System.Type t);
                static /*0x35cb0b0*/ bool IsNullableType(System.Type t);
                static /*0x35dc868*/ System.Type EnsureNotNullableType(System.Type t);
                static /*0x35dc8dc*/ System.Type EnsureNotByRefType(System.Type t);
                static /*0x35dc92c*/ bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x35c9fd8*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x35dc9b4*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, ref System.Type implementingType);
                static /*0x35dcc3c*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition);
                static /*0x35dccb0*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x35dce18*/ bool InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x35dcf30*/ System.Type GetCollectionItemType(System.Type type);
                static /*0x35dd14c*/ void GetDictionaryKeyValueTypes(System.Type dictionaryType, ref System.Type keyType, ref System.Type valueType);
                static /*0x35dbca0*/ System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member);
                static /*0x35dd380*/ bool IsByRefLikeType(System.Type type);
                static /*0x35dd8a4*/ bool IsIndexedProperty(System.Reflection.PropertyInfo property);
                static /*0x35dd91c*/ object GetMemberValue(System.Reflection.MemberInfo member, object target);
                static /*0x35ddc28*/ void SetMemberValue(System.Reflection.MemberInfo member, object target, object value);
                static /*0x35db9c0*/ bool CanReadMemberValue(System.Reflection.MemberInfo member, bool nonPublic);
                static /*0x35dbb0c*/ bool CanSetMemberValue(System.Reflection.MemberInfo member, bool nonPublic, bool canSetReadOnly);
                static /*0x35dde38*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x35deb88*/ bool IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr);
                static /*0x1ffc854*/ T GetAttribute<T>(object attributeProvider);
                static /*0x1ffc854*/ T GetAttribute<T>(object attributeProvider, bool inherit);
                static T[] GetAttributes<T>(object attributeProvider, bool inherit);
                static /*0x35dd490*/ System.Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit);
                static /*0x35ded54*/ Newtonsoft.Json.Utilities.StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName);
                static /*0x35deff8*/ System.Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName);
                static /*0x35df264*/ System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo);
                static /*0x35de76c*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x35df4dc*/ void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x35de884*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x35df6c0*/ System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag);
                static /*0x35df6d0*/ void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x35dfc54*/ bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method);
                static /*0x35dfd70*/ object GetDefaultValue(System.Type type);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__11_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__31_0;
                    static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__39_0;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, bool> <>9__41_0;

                    static /*0x35dffac*/ <>c();
                    /*0x35e0014*/ <>c();
                    /*0x35e001c*/ bool <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c);
                    /*0x35e0088*/ string <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m);
                    /*0x35e00a8*/ System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p);
                    /*0x35e00c8*/ bool <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Reflection.MemberInfo memberInfo;

                    /*0x35deb80*/ <>c__DisplayClass31_0();
                    /*0x35e00e0*/ bool <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m);
                }

                class <>c__DisplayClass44_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo subTypeProperty;

                    /*0x35dfc44*/ <>c__DisplayClass44_0();
                    /*0x35e015c*/ bool <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p);
                    /*0x35e01b0*/ bool <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass44_1
                {
                    /*0x10*/ System.Type subTypePropertyDeclaringType;
                    /*0x18*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> CS$<>8__locals1;

                    /*0x35dfc4c*/ <>c__DisplayClass44_1();
                    /*0x35e027c*/ bool <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ string method;
                    /*0x18*/ System.Type methodDeclaringType;

                    /*0x35dfd68*/ <>c__DisplayClass45_0();
                    /*0x35e0388*/ bool <IsMethodOverridden>b__0(System.Reflection.MethodInfo info);
                }
            }

            struct StringBuffer
            {
                /*0x10*/ char[] _buffer;
                /*0x18*/ int _position;

                /*0x35e049c*/ StringBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int initalSize);
                /*0x35e04cc*/ StringBuffer(char[] buffer);
                /*0x35e047c*/ int get_Position();
                /*0x35e0484*/ void set_Position(int value);
                /*0x35e048c*/ bool get_IsEmpty();
                /*0x35e04e8*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char value);
                /*0x35e05cc*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count);
                /*0x35e064c*/ void Clear(Newtonsoft.Json.IArrayPool<char> bufferPool);
                /*0x35e0560*/ void EnsureSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int appendLength);
                /*0x35e0684*/ string ToString();
                /*0x35e06a0*/ string ToString(int start, int length);
                /*0x35e06bc*/ char[] get_InternalBuffer();
            }

            struct StringReference
            {
                /*0x10*/ char[] _chars;
                /*0x18*/ int _startIndex;
                /*0x1c*/ int _length;

                /*0x35d1be8*/ StringReference(char[] chars, int startIndex, int length);
                /*0x35d14f8*/ char get_Item(int i);
                /*0x35e06c4*/ char[] get_Chars();
                /*0x35e06cc*/ int get_StartIndex();
                /*0x35e06d4*/ int get_Length();
                /*0x35d1820*/ string ToString();
            }

            class StringReferenceExtensions
            {
                static /*0x35d246c*/ int IndexOf(Newtonsoft.Json.Utilities.StringReference s, char c, int startIndex, int length);
                static /*0x35d1528*/ bool StartsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
                static /*0x35d15e8*/ bool EndsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
            }

            class StringUtils
            {
                static /*0x35d1818*/ bool IsNullOrEmpty(string value);
                static /*0x35cb8d8*/ string FormatWith(string format, System.IFormatProvider provider, object arg0);
                static /*0x35cca50*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1);
                static /*0x35e0748*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2);
                static /*0x35e0874*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2, object arg3);
                static /*0x35e06dc*/ string FormatWith(string format, System.IFormatProvider provider, object[] args);
                static /*0x35d9a78*/ System.IO.StringWriter CreateStringWriter(int capacity);
                static /*0x35d97ec*/ void ToCharAsUnicode(char c, char[] buffer);
                static /*0x1ffc854*/ TSource ForgivingCaseSensitiveFind<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, string> valueSelector, string testValue);
                static /*0x35e09e0*/ string ToCamelCase(string s);
                static /*0x35e0ba4*/ char ToLower(char c);
                static /*0x35e0c28*/ string ToSnakeCase(string s);
                static /*0x35e0f0c*/ string ToKebabCase(string s);
                static /*0x35e0c30*/ string ToSeparatedCase(string s, char separator);
                static /*0x35e0f14*/ bool IsHighSurrogate(char c);
                static /*0x35e0f48*/ bool IsLowSurrogate(char c);
                static /*0x35dac48*/ int IndexOf(string s, char c);
                static /*0x35e0f7c*/ bool StartsWith(string source, char value);
                static /*0x35e0fc0*/ bool EndsWith(string source, char value);
                static /*0x35df0d4*/ string Trim(string s, int start, int length);

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

                    /*0x1f309e4*/ <>c__DisplayClass14_0();
                    /*0x1ffc854*/ bool <ForgivingCaseSensitiveFind>b__0(TSource s);
                    /*0x1ffc854*/ bool <ForgivingCaseSensitiveFind>b__1(TSource s);
                }
            }

            struct StructMultiKey<T1, T2> : System.IEquatable<Newtonsoft.Json.Utilities.StructMultiKey<T1, T2>>
            {
                /*0x0*/ T1 Value1;
                /*0x0*/ T2 Value2;

                /*0x1ffc854*/ StructMultiKey(T1 v1, T2 v2);
                /*0x1f2ffc8*/ int GetHashCode();
                /*0x1f2fec8*/ bool Equals(object obj);
                /*0x1ffc854*/ bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1, T2> other);
            }

            class ThreadSafeStore<TKey, TValue>
            {
                /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> _concurrentStore;
                /*0x0*/ System.Func<TKey, TValue> _creator;

                /*0x1f30ebc*/ ThreadSafeStore(System.Func<TKey, TValue> creator);
                /*0x1ffc854*/ TValue Get(TKey key);
            }

            class TypeExtensions
            {
                static /*0x35db9a8*/ System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo);
                static /*0x35e1000*/ bool ContainsGenericParameters(System.Type type);
                static /*0x35ccfb4*/ bool IsInterface(System.Type type);
                static /*0x35d75b8*/ bool IsGenericType(System.Type type);
                static /*0x35ccfc8*/ bool IsGenericTypeDefinition(System.Type type);
                static /*0x35dcf14*/ System.Type BaseType(System.Type type);
                static /*0x35d75dc*/ System.Reflection.Assembly Assembly(System.Type type);
                static /*0x35cb094*/ bool IsEnum(System.Type type);
                static /*0x35dce04*/ bool IsClass(System.Type type);
                static /*0x35e101c*/ bool IsSealed(System.Type type);
                static /*0x35ccfe4*/ bool IsAbstract(System.Type type);
                static /*0x35e1030*/ bool IsVisible(System.Type type);
                static /*0x35dc6b4*/ bool IsValueType(System.Type type);
                static /*0x35e1044*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces, ref System.Type match);
                static /*0x35e11a8*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces);
                static /*0x35e11c0*/ bool ImplementInterface(System.Type type, System.Type interfaceType);
            }

            class ValidationUtils
            {
                static /*0x35c8d9c*/ void ArgumentNotNull(object value, string parameterName);
            }
        }

        namespace Serialization
        {
            class CachedAttributeGetter<T>
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<object, T> TypeAttributeCache;

                static /*0x1f33998*/ CachedAttributeGetter();
                static /*0x1ffc854*/ T GetAttribute(object type);
            }

            class CamelCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x35e1578*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x35e15a8*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x35d6210*/ CamelCaseNamingStrategy();
                /*0x35e15e8*/ string ResolvePropertyName(string name);
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

                static /*0x35e8674*/ DefaultContractResolver();
                static /*0x35e15f0*/ Newtonsoft.Json.Serialization.IContractResolver get_Instance();
                static /*0x35e182c*/ bool FilterMembers(System.Reflection.MemberInfo member);
                static /*0x35e40c4*/ void ThrowUnableToSerializeError(object o, System.Runtime.Serialization.StreamingContext context);
                static /*0x35e384c*/ void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member);
                static /*0x35e625c*/ bool IsConcurrentOrObservableCollection(System.Type t);
                static /*0x35e5b44*/ bool ShouldSkipDeserialized(System.Type t);
                static /*0x35e5a70*/ bool ShouldSkipSerializing(System.Type t);
                static /*0x35e75e8*/ bool IsJsonPrimitiveType(System.Type t);
                static /*0x35e7740*/ bool IsIConvertible(System.Type t);
                static /*0x35e7648*/ bool CanConvertToString(System.Type type);
                static /*0x35e5c18*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                static /*0x35e78ac*/ string GetClrTypeFullName(System.Type type);
                /*0x35e1690*/ DefaultContractResolver();
                /*0x35e1648*/ System.Reflection.BindingFlags get_DefaultMembersSearchFlags();
                /*0x35e1650*/ void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value);
                /*0x35e1658*/ bool get_SerializeCompilerGeneratedMembers();
                /*0x35e1660*/ bool get_IgnoreSerializableInterface();
                /*0x35e1668*/ bool get_IgnoreSerializableAttribute();
                /*0x35e1670*/ void set_IgnoreSerializableAttribute(bool value);
                /*0x35e1678*/ bool get_IgnoreIsSpecifiedMembers();
                /*0x35e1680*/ bool get_IgnoreShouldSerializeMembers();
                /*0x35e1688*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x35e17a0*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
                /*0x35e1970*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType);
                /*0x35e24fc*/ bool ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo);
                /*0x35e2604*/ Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType);
                /*0x35e366c*/ System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type);
                /*0x35e2e60*/ System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType);
                /*0x35e33b8*/ System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x35e3370*/ System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType);
                /*0x35e431c*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x35e42a4*/ Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, string name, System.Type type);
                /*0x35e4498*/ Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo);
                /*0x35e4fc0*/ Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType);
                /*0x35e5018*/ System.Func<object> GetDefaultCreator(System.Type createdType);
                /*0x35e2bf4*/ void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x35e50b8*/ void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t);
                /*0x35e51f8*/ void GetCallbackMethodsForType(System.Type type, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> onError);
                /*0x35e4158*/ System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type);
                /*0x35e63a4*/ Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType);
                /*0x35e6908*/ Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType);
                /*0x35e6c40*/ Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType);
                /*0x35e6cb4*/ Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType);
                /*0x35e6d28*/ Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType);
                /*0x35e6f64*/ Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType);
                /*0x35e717c*/ Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType);
                /*0x35e71f0*/ Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType);
                /*0x35e79ac*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x35e7e44*/ Newtonsoft.Json.DefaultJsonNameTable GetNameTable();
                /*0x35e7e4c*/ Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member);
                /*0x35e7ea8*/ Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x35e4908*/ void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, object attributeProvider, string name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, ref bool allowNonPublicAccess);
                /*0x35e80c0*/ System.Predicate<object> CreateShouldSerializeTest(System.Reflection.MemberInfo member);
                /*0x35e8304*/ void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, bool allowNonPublicAccess);
                /*0x35e85fc*/ string ResolvePropertyName(string propertyName);
                /*0x35e861c*/ string ResolveExtensionDataName(string extensionDataName);
                /*0x35e8638*/ string ResolveDictionaryKey(string dictionaryKey);
                /*0x35e8664*/ string GetResolvedPropertyName(string propertyName);

                class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    /*0x1f30ebc*/ EnumerableDictionaryWrapper(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator();
                    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class <GetEnumerator>d__<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ System.Collections.Generic.KeyValuePair<object, object> <>2__current;
                        /*0x0*/ Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;
                        /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;

                        /*0x1f30b78*/ <GetEnumerator>d__(int <>1__state);
                        /*0x1f309e4*/ void System.IDisposable.Dispose();
                        /*0x1f2fe14*/ bool MoveNext();
                        /*0x1f309e4*/ void <>m__Finally1();
                        System.Collections.Generic.KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current();
                        /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                        /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
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

                    static /*0x35e8b98*/ <>c();
                    /*0x35e8c00*/ <>c();
                    /*0x35e8c08*/ bool <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m);
                    /*0x35e8cb8*/ bool <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m);
                    /*0x35e8d28*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType);
                    /*0x35e8e08*/ bool <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m);
                    /*0x35e91c4*/ bool <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c);
                    /*0x35e9248*/ int <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p);
                }

                class <>c__DisplayClass42_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x35e9368*/ <>c__DisplayClass42_0();
                    /*0x35e9370*/ string <CreateObjectContract>b__0(string s);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ System.Func<object, object> getExtensionDataDictionary;
                    /*0x18*/ System.Reflection.MemberInfo member;

                    /*0x35e938c*/ <>c__DisplayClass45_0();
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ System.Action<object, object> setExtensionDataDictionary;
                    /*0x18*/ System.Func<object> createExtensionDataDictionary;
                    /*0x20*/ Newtonsoft.Json.Utilities.MethodCall<object, object> setExtensionDataDictionaryValue;
                    /*0x28*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals1;

                    /*0x35e9394*/ <>c__DisplayClass45_1();
                    /*0x35e939c*/ void <SetExtensionDataDelegates>b__0(object o, string key, object value);
                }

                class <>c__DisplayClass45_2
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> createEnumerableWrapper;
                    /*0x18*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals2;

                    /*0x35e95c0*/ <>c__DisplayClass45_2();
                    /*0x35e95c8*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o);
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x35e96f0*/ <>c__DisplayClass62_0();
                    /*0x35e96f8*/ string <CreateDictionaryContract>b__0(string s);
                }

                class <>c__DisplayClass67_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x35e9714*/ <>c__DisplayClass67_0();
                    /*0x35e971c*/ string <CreateDynamicContract>b__0(string s);
                }

                class <>c__DisplayClass80_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> shouldSerializeCall;

                    /*0x35e9738*/ <>c__DisplayClass80_0();
                    /*0x35e9740*/ bool <CreateShouldSerializeTest>b__0(object o);
                }

                class <>c__DisplayClass81_0
                {
                    /*0x10*/ System.Func<object, object> specifiedPropertyGet;

                    /*0x35e983c*/ <>c__DisplayClass81_0();
                    /*0x35e9844*/ bool <SetIsSpecifiedActions>b__0(object o);
                }
            }

            class DefaultNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x35e98ac*/ DefaultNamingStrategy();
                /*0x35e98a4*/ string ResolvePropertyName(string name);
            }

            class DefaultReferenceResolver : Newtonsoft.Json.Serialization.IReferenceResolver
            {
                /*0x10*/ int _referenceCount;

                /*0x35e9d18*/ DefaultReferenceResolver();
                /*0x35e98b4*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> GetMappings(object context);
                /*0x35e9ad0*/ object ResolveReference(object context, string reference);
                /*0x35e9b44*/ string GetReference(object context, object value);
                /*0x35e9c38*/ void AddReference(object context, string reference, object value);
                /*0x35e9ca4*/ bool IsReferenced(object context, object value);
            }

            class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder, Newtonsoft.Json.Serialization.ISerializationBinder
            {
                static /*0x0*/ Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
                /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<string, string>, System.Type> _typeCache;

                static /*0x35ea5f0*/ DefaultSerializationBinder();
                /*0x35e9d20*/ DefaultSerializationBinder();
                /*0x35e9df8*/ System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x35ea214*/ System.Type GetGenericTypeFromTypeName(string typeName, System.Reflection.Assembly assembly);
                /*0x35ea480*/ System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x35ea4f8*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x35ea574*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            class ErrorContext
            {
                /*0x10*/ bool <Traced>k__BackingField;
                /*0x18*/ System.Exception <Error>k__BackingField;
                /*0x20*/ object <OriginalObject>k__BackingField;
                /*0x28*/ object <Member>k__BackingField;
                /*0x30*/ string <Path>k__BackingField;
                /*0x38*/ bool <Handled>k__BackingField;

                /*0x35ea654*/ ErrorContext(object originalObject, object member, string path, System.Exception error);
                /*0x35ea6c8*/ bool get_Traced();
                /*0x35ea6d0*/ void set_Traced(bool value);
                /*0x35ea6d8*/ System.Exception get_Error();
                /*0x35ea6e0*/ bool get_Handled();
            }

            class ErrorEventArgs : System.EventArgs
            {
                /*0x10*/ object <CurrentObject>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;

                /*0x35ea6e8*/ ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            interface IAttributeProvider
            {
            }

            interface IContractResolver
            {
                /*0x1f302cc*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
            }

            interface IReferenceResolver
            {
                /*0x1f30394*/ object ResolveReference(object context, string reference);
                /*0x1f30394*/ string GetReference(object context, object value);
                /*0x1f2ff00*/ bool IsReferenced(object context, object value);
                /*0x1f310fc*/ void AddReference(object context, string reference, object value);
            }

            interface ISerializationBinder
            {
                /*0x1f30394*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x1f310fc*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            interface ITraceWriter
            {
                /*0x1f2ffc8*/ System.Diagnostics.TraceLevel get_LevelFilter();
                /*0x1f30d20*/ void Trace(System.Diagnostics.TraceLevel level, string message, System.Exception ex);
            }

            interface IValueProvider
            {
                /*0x1f30ff0*/ void SetValue(object target, object value);
                /*0x1f302cc*/ object GetValue(object target);
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

                /*0x35ea924*/ JsonArrayContract(System.Type underlyingType);
                /*0x35ea770*/ System.Type get_CollectionItemType();
                /*0x35ea778*/ bool get_IsMultidimensionalArray();
                /*0x35ea780*/ bool get_IsArray();
                /*0x35ea788*/ bool get_ShouldCreateWrapper();
                /*0x35ea790*/ bool get_CanDeserialize();
                /*0x35ea798*/ void set_CanDeserialize(bool value);
                /*0x35ea7a0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x35ea868*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x35ea870*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x35ea894*/ bool get_HasParameterizedCreator();
                /*0x35ea89c*/ void set_HasParameterizedCreator(bool value);
                /*0x35ea8a4*/ bool get_HasParameterizedCreatorInternal();
                /*0x35eba24*/ Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(object list);
                /*0x35ebe34*/ System.Collections.IList CreateTemporaryCollection();
                /*0x35eb904*/ void StoreFSharpListCreatorIfNecessary(System.Type underlyingType);
            }

            class JsonContainerContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x90*/ Newtonsoft.Json.Serialization.JsonContract _itemContract;
                /*0x98*/ Newtonsoft.Json.Serialization.JsonContract _finalItemContract;
                /*0xa0*/ Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;
                /*0xa8*/ System.Nullable<bool> <ItemIsReference>k__BackingField;
                /*0xac*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;
                /*0xb4*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;

                /*0x35eb740*/ JsonContainerContract(System.Type underlyingType);
                /*0x35ec084*/ Newtonsoft.Json.Serialization.JsonContract get_ItemContract();
                /*0x35ec08c*/ void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x35ec0ec*/ Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract();
                /*0x35ec0f4*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x35ec0fc*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x35ec104*/ System.Nullable<bool> get_ItemIsReference();
                /*0x35ec10c*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x35ec114*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x35ec11c*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x35ec124*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x35ec12c*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
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
                /*0x35ec2b0*/ SerializationCallback(object object, nint method);
                /*0x35ec3bc*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context);
            }

            class SerializationErrorCallback : System.MulticastDelegate
            {
                /*0x35ec3d0*/ SerializationErrorCallback(object object, nint method);
                /*0x35ec4dc*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            class ExtensionDataSetter : System.MulticastDelegate
            {
                /*0x35ec4f0*/ ExtensionDataSetter(object object, nint method);
                /*0x35ec5fc*/ void Invoke(object o, string key, object value);
            }

            class ExtensionDataGetter : System.MulticastDelegate
            {
                /*0x35ec610*/ ExtensionDataGetter(object object, nint method);
                /*0x35ec718*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> Invoke(object o);
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

                static /*0x35ed354*/ Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo);
                static /*0x35ed414*/ Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo);
                /*0x35ec134*/ JsonContract(System.Type underlyingType);
                /*0x35ec72c*/ System.Type get_UnderlyingType();
                /*0x35ec734*/ System.Type get_CreatedType();
                /*0x35eb84c*/ void set_CreatedType(System.Type value);
                /*0x35ec73c*/ System.Nullable<bool> get_IsReference();
                /*0x35ec744*/ void set_IsReference(System.Nullable<bool> value);
                /*0x35ec74c*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x35ec754*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x35ec75c*/ Newtonsoft.Json.JsonConverter get_InternalConverter();
                /*0x35ec764*/ void set_InternalConverter(Newtonsoft.Json.JsonConverter value);
                /*0x35ec76c*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks();
                /*0x35ec7f0*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks();
                /*0x35ec874*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks();
                /*0x35ec8f8*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks();
                /*0x35ec97c*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks();
                /*0x35eca00*/ System.Func<object> get_DefaultCreator();
                /*0x35eca08*/ void set_DefaultCreator(System.Func<object> value);
                /*0x35eca10*/ bool get_DefaultCreatorNonPublic();
                /*0x35eca18*/ void set_DefaultCreatorNonPublic(bool value);
                /*0x35eca20*/ void InvokeOnSerializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x35ecbf4*/ void InvokeOnSerialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x35ecdc8*/ void InvokeOnDeserializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x35ecf9c*/ void InvokeOnDeserialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x35ed170*/ void InvokeOnError(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);

                class <>c__DisplayClass57_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x35ed40c*/ <>c__DisplayClass57_0();
                    /*0x35ed4d4*/ void <CreateSerializationCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context);
                }

                class <>c__DisplayClass58_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x35ed4cc*/ <>c__DisplayClass58_0();
                    /*0x35ed5d4*/ void <CreateSerializationErrorCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext);
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

                /*0x35ed8bc*/ JsonDictionaryContract(System.Type underlyingType);
                /*0x35ed714*/ System.Func<string, string> get_DictionaryKeyResolver();
                /*0x35ed71c*/ void set_DictionaryKeyResolver(System.Func<string, string> value);
                /*0x35ed724*/ System.Type get_DictionaryKeyType();
                /*0x35ed72c*/ System.Type get_DictionaryValueType();
                /*0x35ed734*/ Newtonsoft.Json.Serialization.JsonContract get_KeyContract();
                /*0x35ed73c*/ void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x35ed744*/ bool get_ShouldCreateWrapper();
                /*0x35ed74c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x35ed814*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x35ed81c*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x35ed82c*/ bool get_HasParameterizedCreator();
                /*0x35ed834*/ void set_HasParameterizedCreator(bool value);
                /*0x35ed83c*/ bool get_HasParameterizedCreatorInternal();
                /*0x35ee304*/ Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(object dictionary);
                /*0x35ee5cc*/ System.Collections.IDictionary CreateTemporaryDictionary();
            }

            class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;
                /*0xc8*/ System.Func<string, string> <PropertyNameResolver>k__BackingField;
                /*0xd0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>> _callSiteGetters;
                /*0xd8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>> _callSiteSetters;

                static /*0x35ee86c*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>> CreateCallSiteGetter(string name);
                static /*0x35ee984*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>> CreateCallSiteSetter(string name);
                /*0x35eea9c*/ JsonDynamicContract(System.Type underlyingType);
                /*0x35ee854*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x35ee85c*/ System.Func<string, string> get_PropertyNameResolver();
                /*0x35ee864*/ void set_PropertyNameResolver(System.Func<string, string> value);
                /*0x35eede0*/ bool TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, ref object value);
                /*0x35eeef4*/ bool TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, object value);
            }

            class JsonFormatterConverter : System.Runtime.Serialization.IFormatterConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;
                /*0x18*/ Newtonsoft.Json.Serialization.JsonISerializableContract _contract;
                /*0x20*/ Newtonsoft.Json.Serialization.JsonProperty _member;

                /*0x35eeff8*/ JsonFormatterConverter(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x1ffc854*/ T GetTokenValue<T>(object value);
                /*0x35ef0c0*/ object Convert(object value, System.Type type);
                /*0x35ef2fc*/ bool ToBoolean(object value);
                /*0x35ef360*/ byte ToByte(object value);
                /*0x35ef3c4*/ int ToInt32(object value);
                /*0x35ef428*/ long ToInt64(object value);
                /*0x35ef48c*/ float ToSingle(object value);
                /*0x35ef4f0*/ string ToString(object value);
            }

            class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <ISerializableCreator>k__BackingField;

                /*0x35ef564*/ JsonISerializableContract(System.Type underlyingType);
                /*0x35ef554*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ISerializableCreator();
                /*0x35ef55c*/ void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
            }

            class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x35ef580*/ JsonLinqContract(System.Type underlyingType);
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

                /*0x35efe20*/ JsonObjectContract(System.Type underlyingType);
                /*0x35ef59c*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
                /*0x35ef5a4*/ void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value);
                /*0x35ef5ac*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling();
                /*0x35ef5b4*/ void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value);
                /*0x35ef5bc*/ System.Nullable<Newtonsoft.Json.Required> get_ItemRequired();
                /*0x35ef5c4*/ void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value);
                /*0x35ef5cc*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling();
                /*0x35ef5d4*/ void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x35ef5dc*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x35ef5e4*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters();
                /*0x35ef658*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x35ef660*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x35ef670*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x35ef678*/ void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x35ef688*/ Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter();
                /*0x35ef690*/ void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value);
                /*0x35ef698*/ Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter();
                /*0x35ef6a0*/ void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value);
                /*0x35ef6a8*/ void set_ExtensionDataValueType(System.Type value);
                /*0x35ef774*/ System.Func<string, string> get_ExtensionDataNameResolver();
                /*0x35ef77c*/ void set_ExtensionDataNameResolver(System.Func<string, string> value);
                /*0x35ef784*/ bool get_HasRequiredOrDefaultValueProperties();
                /*0x35efea4*/ object GetUninitializedObject();
            }

            class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Newtonsoft.Json.ReadType> ReadTypeMap;
                /*0x8c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;

                static /*0x35f00b0*/ JsonPrimitiveContract();
                /*0x35effb8*/ JsonPrimitiveContract(System.Type underlyingType);
                /*0x35effa8*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
                /*0x35effb0*/ void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value);
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

                /*0x35f07d8*/ JsonProperty();
                /*0x35f03d8*/ Newtonsoft.Json.Serialization.JsonContract get_PropertyContract();
                /*0x35f03e0*/ void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x35f03e8*/ string get_PropertyName();
                /*0x35f03f0*/ void set_PropertyName(string value);
                /*0x35f0488*/ System.Type get_DeclaringType();
                /*0x35f0490*/ void set_DeclaringType(System.Type value);
                /*0x35f0498*/ System.Nullable<int> get_Order();
                /*0x35f04a0*/ void set_Order(System.Nullable<int> value);
                /*0x35f04a8*/ string get_UnderlyingName();
                /*0x35f04b0*/ void set_UnderlyingName(string value);
                /*0x35f04b8*/ Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider();
                /*0x35f04c0*/ void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value);
                /*0x35f04c8*/ void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value);
                /*0x35f04d0*/ System.Type get_PropertyType();
                /*0x35f04d8*/ void set_PropertyType(System.Type value);
                /*0x35f0544*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x35f054c*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x35f0554*/ bool get_Ignored();
                /*0x35f055c*/ void set_Ignored(bool value);
                /*0x35f0564*/ bool get_Readable();
                /*0x35f056c*/ void set_Readable(bool value);
                /*0x35f0574*/ bool get_Writable();
                /*0x35f057c*/ void set_Writable(bool value);
                /*0x35f0584*/ bool get_HasMemberAttribute();
                /*0x35f058c*/ void set_HasMemberAttribute(bool value);
                /*0x35f0594*/ object get_DefaultValue();
                /*0x35f05ac*/ void set_DefaultValue(object value);
                /*0x35f05bc*/ object GetResolvedDefaultValue();
                /*0x35efd60*/ Newtonsoft.Json.Required get_Required();
                /*0x35f0684*/ System.Nullable<bool> get_IsReference();
                /*0x35f068c*/ void set_IsReference(System.Nullable<bool> value);
                /*0x35f0694*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling();
                /*0x35f069c*/ void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x35f06a4*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling();
                /*0x35f06ac*/ void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value);
                /*0x35f06b4*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling();
                /*0x35f06bc*/ void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x35f06c4*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling();
                /*0x35f06cc*/ void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value);
                /*0x35f06d4*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling();
                /*0x35f06dc*/ void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x35f06e4*/ System.Predicate<object> get_ShouldSerialize();
                /*0x35f06ec*/ void set_ShouldSerialize(System.Predicate<object> value);
                /*0x35f06f4*/ System.Predicate<object> get_ShouldDeserialize();
                /*0x35f06fc*/ System.Predicate<object> get_GetIsSpecified();
                /*0x35f0704*/ void set_GetIsSpecified(System.Predicate<object> value);
                /*0x35f070c*/ System.Action<object, object> get_SetIsSpecified();
                /*0x35f0714*/ void set_SetIsSpecified(System.Action<object, object> value);
                /*0x35f071c*/ string ToString();
                /*0x35f0740*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x35f0748*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x35f0750*/ System.Nullable<bool> get_ItemIsReference();
                /*0x35f0758*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x35f0760*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x35f0768*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x35f0770*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x35f0778*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x35f0780*/ void WritePropertyName(Newtonsoft.Json.JsonWriter writer);
            }

            class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty>
            {
                /*0x30*/ System.Type _type;
                /*0x38*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;

                /*0x35eec60*/ JsonPropertyCollection(System.Type type);
                /*0x35f07e0*/ string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x35f07f4*/ void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x35f0aa4*/ Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName);
                /*0x35f0bdc*/ bool TryGetProperty(string key, ref Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x35f0ae4*/ Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType);
            }

            class JsonSerializerInternalBase
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;
                /*0x18*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> _mappings;
                /*0x20*/ Newtonsoft.Json.JsonSerializer Serializer;
                /*0x28*/ Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;
                /*0x30*/ Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;

                /*0x35f0cc4*/ JsonSerializerInternalBase(Newtonsoft.Json.JsonSerializer serializer);
                /*0x35e99c0*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> get_DefaultReferenceMappings();
                /*0x35f0d68*/ Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x35f0f40*/ Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(object currentObject, object member, string path, System.Exception error);
                /*0x35f1038*/ void ClearErrorContext();
                /*0x35f1098*/ bool IsErrorHandled(object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, string path, System.Exception ex);

                class ReferenceEqualsEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
                {
                    /*0x35f0d60*/ ReferenceEqualsEqualityComparer();
                    /*0x35f1458*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
                    /*0x35f1464*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj);
                }
            }

            class JsonSerializerInternalReader : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                static /*0x35f62b8*/ bool CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, string s);
                /*0x35f1470*/ JsonSerializerInternalReader(Newtonsoft.Json.JsonSerializer serializer);
                /*0x35f1474*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
                /*0x35f3624*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type);
                /*0x35f3688*/ Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type);
                /*0x35f3738*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, bool checkAdditionalContent);
                /*0x35f4408*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x35f4480*/ Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x35f4854*/ Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader);
                /*0x35f3eec*/ object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x35f63a0*/ string GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x35f3a68*/ Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x35f4c90*/ object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x35f6458*/ bool ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x35f6bac*/ bool ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x35f83c0*/ void ResolveTypeName(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, string qualifiedTypeName);
                /*0x35f8bcc*/ Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x35f5698*/ object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, object existingValue, string id);
                /*0x35f7158*/ bool HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x35f5d14*/ object EnsureType(Newtonsoft.Json.JsonReader reader, object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType);
                /*0x35f9720*/ bool SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target);
                /*0x35f9b94*/ bool CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target, ref bool useExistingValue, ref object currentValue, ref Newtonsoft.Json.Serialization.JsonContract propertyContract, ref bool gottenCurrentValue, ref bool ignoredValue);
                /*0x35fa270*/ void AddReference(Newtonsoft.Json.JsonReader reader, string id, object value);
                /*0x35fa264*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x35fa148*/ bool ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, object value);
                /*0x35f8d4c*/ System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, ref bool createdFromNonDefaultCreator);
                /*0x35f7474*/ System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, ref bool createdFromNonDefaultCreator);
                /*0x35fa634*/ void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x35fa860*/ void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x35f1f08*/ object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x35f8ffc*/ object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x35faa8c*/ void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object currentObject, string message);
                /*0x35f1994*/ object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x35f7d20*/ object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x35ef1d8*/ object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x35f76b8*/ object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x35fabc0*/ object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<object> creator, string id);
                /*0x35f3ad4*/ object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue);
                /*0x35fca38*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x35f7234*/ object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id, ref bool createdFromNonDefaultCreator);
                /*0x35f2928*/ object PopulateObject(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x35fd96c*/ bool ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x35f4b74*/ bool CheckPropertyName(Newtonsoft.Json.JsonReader reader, string memberName);
                /*0x35fd7f8*/ void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, string memberName, object o);
                /*0x35fd73c*/ object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader);
                /*0x35fd184*/ void EndProcessProperty(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, int initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue);
                /*0x35fdbc4*/ void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties);
                /*0x35f43a0*/ void HandleError(Newtonsoft.Json.JsonReader reader, bool readPastError, int initialDepth);

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

                    /*0x35fd154*/ CreatorPropertyContext(string name);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_0;
                    static /*0x10*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_2;
                    static /*0x18*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0;
                    static /*0x20*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1;

                    static /*0x35fdcc4*/ <>c();
                    /*0x35fdd2c*/ <>c();
                    /*0x35fdd34*/ string <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x35fdd48*/ string <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x35fdd5c*/ Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m);
                    /*0x35fdd64*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m);
                }

                class <>c__DisplayClass38_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.JsonProperty property;

                    /*0x35fd14c*/ <>c__DisplayClass38_0();
                    /*0x35fdd6c*/ bool <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p);
                }
            }

            class JsonSerializerInternalWriter : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                /*0x38*/ System.Type _rootType;
                /*0x40*/ int _rootLevel;
                /*0x48*/ System.Collections.Generic.List<object> _serializeStack;

                static /*0x36029c8*/ bool TryConvertToString(object value, System.Type type, ref string s);
                /*0x35fdd8c*/ JsonSerializerInternalWriter(Newtonsoft.Json.JsonSerializer serializer);
                /*0x35fde18*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
                /*0x35fecd0*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x35fe0d4*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(object value);
                /*0x35fed48*/ Newtonsoft.Json.Serialization.JsonContract GetContract(object value);
                /*0x35fee0c*/ void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x35fe5d4*/ void SerializeValue(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x36020f4*/ System.Nullable<bool> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x35fe0e4*/ bool ShouldWriteReference(object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3602238*/ bool ShouldWriteProperty(object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x3602324*/ bool CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x35fe358*/ void WriteReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x36027dc*/ string GetReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x3600ccc*/ void SerializeString(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonStringContract contract);
                /*0x3602ad8*/ void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x3602cdc*/ void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x35ffa90*/ void SerializeObject(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x36030c8*/ bool CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.Serialization.JsonContract memberContract, ref object memberValue);
                /*0x3602ee0*/ void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3603f18*/ bool HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x3603fcc*/ void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, object value);
                /*0x35ff33c*/ void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type);
                /*0x3602318*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x360222c*/ bool HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag);
                /*0x3604218*/ bool HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag);
                /*0x35ff5bc*/ void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3600490*/ void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3600b14*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3604568*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, int initialDepth, int[] indices);
                /*0x3604224*/ bool WriteStartArray(Newtonsoft.Json.JsonWriter writer, object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3601ccc*/ void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x360156c*/ void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x36048ec*/ bool ShouldWriteDynamicProperty(object memberValue);
                /*0x35fef74*/ bool ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3600d50*/ void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x3603568*/ string GetPropertyName(Newtonsoft.Json.JsonWriter writer, object name, Newtonsoft.Json.Serialization.JsonContract contract, ref bool escape);
                /*0x35fec5c*/ void HandleError(Newtonsoft.Json.JsonWriter writer, int initialDepth);
                /*0x3603a70*/ bool ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x3603cc4*/ bool IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
            }

            class JsonSerializerProxy : Newtonsoft.Json.JsonSerializer
            {
                /*0xe0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;
                /*0xe8*/ Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;
                /*0xf0*/ Newtonsoft.Json.JsonSerializer _serializer;

                /*0x3604d24*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader);
                /*0x3604db0*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter);
                /*0x36049a8*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x36049c4*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x36049e0*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
                /*0x36049fc*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
                /*0x3604a18*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
                /*0x3604a34*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
                /*0x3604a50*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
                /*0x3604a70*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
                /*0x3604a90*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
                /*0x3604ab0*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
                /*0x3604ad0*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
                /*0x3604af0*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
                /*0x3604b10*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
                /*0x3604b30*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
                /*0x3604b50*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
                /*0x3604b70*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
                /*0x3604b90*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
                /*0x3604bac*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
                /*0x3604bcc*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
                /*0x3604bec*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
                /*0x3604c08*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
                /*0x3604c28*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
                /*0x3604c44*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0x3604c64*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
                /*0x3604c84*/ Newtonsoft.Json.Formatting get_Formatting();
                /*0x3604ca4*/ System.Nullable<int> get_MaxDepth();
                /*0x3604cc4*/ bool get_CheckAdditionalContent();
                /*0x3604ce4*/ void set_CheckAdditionalContent(bool value);
                /*0x3604d08*/ Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer();
                /*0x3604e3c*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x3604e6c*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
                /*0x3604e98*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type rootType);
            }

            class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
            {
                /*0x3604ec4*/ JsonStringContract(System.Type underlyingType);
            }

            class JsonTypeReflector
            {
                static /*0x0*/ System.Nullable<bool> _fullyTrusted;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Func<System.Object[], object>> CreatorCache;
                static /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache;
                static /*0x18*/ Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;

                static /*0x36060e4*/ JsonTypeReflector();
                static /*0x1ffc854*/ T GetCachedAttribute<T>(object attributeProvider);
                static /*0x3604f38*/ bool CanTypeDescriptorConvertString(System.Type type, ref System.ComponentModel.TypeConverter typeConverter);
                static /*0x3605114*/ System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type);
                static /*0x36051d4*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo);
                static /*0x360545c*/ Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute);
                static /*0x36055b0*/ Newtonsoft.Json.JsonConverter GetJsonConverter(object attributeProvider);
                static /*0x36056e8*/ Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] args);
                static /*0x36057e8*/ Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, object[] args);
                static /*0x36058e8*/ Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute);
                static /*0x36059a8*/ System.Func<System.Object[], object> GetCreator(System.Type type);
                static /*0x3605bbc*/ System.Type GetAssociatedMetadataType(System.Type type);
                static /*0x3605c50*/ System.Type GetAssociateMetadataTypeFromAttribute(System.Type type);
                static /*0x1ffc854*/ T GetAttribute<T>(System.Type type);
                static /*0x1ffc854*/ T GetAttribute<T>(System.Reflection.MemberInfo memberInfo);
                static /*0x3605e94*/ bool IsNonSerializable(object provider);
                static /*0x3605534*/ bool IsSerializable(object provider);
                static /*0x1ffc854*/ T GetAttribute<T>(object provider);
                static /*0x3605f10*/ bool get_FullyTrusted();
                static /*0x3605b34*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory();

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonTypeReflector.<> <>9;
                    static /*0x8*/ System.Func<object, System.Type> <>9__22_1;

                    static /*0x360626c*/ <>c();
                    /*0x36062d4*/ <>c();
                    /*0x36062dc*/ System.Type <GetCreator>b__22_1(object param);
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ System.Type type;
                    /*0x18*/ System.Func<object> defaultConstructor;

                    /*0x3605b2c*/ <>c__DisplayClass22_0();
                    /*0x3606338*/ object <GetCreator>b__0(object[] parameters);
                }
            }

            class KebabCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x3606794*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x36067cc*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x360680c*/ KebabCaseNamingStrategy();
                /*0x3606814*/ string ResolvePropertyName(string name);
            }

            class NamingStrategy
            {
                /*0x10*/ bool <ProcessDictionaryKeys>k__BackingField;
                /*0x11*/ bool <ProcessExtensionDataNames>k__BackingField;
                /*0x12*/ bool <OverrideSpecifiedNames>k__BackingField;

                /*0x36067c4*/ NamingStrategy();
                /*0x3606820*/ bool get_ProcessDictionaryKeys();
                /*0x3606828*/ void set_ProcessDictionaryKeys(bool value);
                /*0x3606830*/ bool get_ProcessExtensionDataNames();
                /*0x3606838*/ void set_ProcessExtensionDataNames(bool value);
                /*0x3606840*/ bool get_OverrideSpecifiedNames();
                /*0x3606848*/ void set_OverrideSpecifiedNames(bool value);
                /*0x3606850*/ string GetPropertyName(string name, bool hasSpecifiedName);
                /*0x3606870*/ string GetExtensionDataName(string name);
                /*0x360688c*/ string GetDictionaryKey(string key);
                /*0x1f302cc*/ string ResolvePropertyName(string name);
                /*0x36068a8*/ int GetHashCode();
                /*0x3606964*/ bool Equals(object obj);
                /*0x36069e4*/ bool Equals(Newtonsoft.Json.Serialization.NamingStrategy other);
            }

            class ObjectConstructor<T> : System.MulticastDelegate
            {
                ObjectConstructor(object object, nint method);
                /*0x1f302cc*/ object Invoke(object[] args);
            }

            class OnErrorAttribute : System.Attribute
            {
            }

            class ReflectionAttributeProvider : Newtonsoft.Json.Serialization.IAttributeProvider
            {
                /*0x10*/ object _attributeProvider;

                /*0x3606ac4*/ ReflectionAttributeProvider(object attributeProvider);
            }

            class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
            {
                /*0x10*/ System.Reflection.MemberInfo _memberInfo;

                /*0x3606b38*/ ReflectionValueProvider(System.Reflection.MemberInfo memberInfo);
                /*0x3606bac*/ void SetValue(object target, object value);
                /*0x3606d48*/ object GetValue(object target);
            }

            class SnakeCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x3606fe0*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x3607010*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x3607050*/ SnakeCaseNamingStrategy();
                /*0x3607058*/ string ResolvePropertyName(string name);
            }

            class TraceJsonReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.JsonReader _innerReader;
                /*0x80*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x88*/ System.IO.StringWriter _sw;

                /*0x3607064*/ TraceJsonReader(Newtonsoft.Json.JsonReader innerReader);
                /*0x36071d0*/ string GetDeserializedJsonMessage();
                /*0x36071ec*/ bool Read();
                /*0x3607260*/ System.Nullable<int> ReadAsInt32();
                /*0x36072a0*/ string ReadAsString();
                /*0x36072e0*/ byte[] ReadAsBytes();
                /*0x3607324*/ System.Nullable<decimal> ReadAsDecimal();
                /*0x36073b0*/ System.Nullable<double> ReadAsDouble();
                /*0x36073fc*/ System.Nullable<bool> ReadAsBoolean();
                /*0x3607440*/ System.Nullable<System.DateTime> ReadAsDateTime();
                /*0x360748c*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
                /*0x360722c*/ void WriteCurrentToken();
                /*0x36074e8*/ int get_Depth();
                /*0x3607504*/ string get_Path();
                /*0x3607520*/ Newtonsoft.Json.JsonToken get_TokenType();
                /*0x360753c*/ object get_Value();
                /*0x3607558*/ System.Type get_ValueType();
                /*0x3607574*/ void Close();
                /*0x3607594*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x3607648*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x3607700*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
            }

            class TraceJsonWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.JsonWriter _innerWriter;
                /*0x68*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x70*/ System.IO.StringWriter _sw;

                /*0x36077b8*/ TraceJsonWriter(Newtonsoft.Json.JsonWriter innerWriter);
                /*0x36079c0*/ string GetSerializedJsonMessage();
                /*0x36079dc*/ void WriteValue(decimal value);
                /*0x3607a48*/ void WriteValue(System.Nullable<decimal> value);
                /*0x3607c04*/ void WriteValue(bool value);
                /*0x3607c68*/ void WriteValue(System.Nullable<bool> value);
                /*0x3607dd0*/ void WriteValue(byte value);
                /*0x3607e30*/ void WriteValue(System.Nullable<byte> value);
                /*0x3607f98*/ void WriteValue(char value);
                /*0x3607ff8*/ void WriteValue(System.Nullable<char> value);
                /*0x3608160*/ void WriteValue(byte[] value);
                /*0x36081d4*/ void WriteValue(System.DateTime value);
                /*0x3608234*/ void WriteValue(System.Nullable<System.DateTime> value);
                /*0x36083b0*/ void WriteValue(System.DateTimeOffset value);
                /*0x360841c*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
                /*0x36085a0*/ void WriteValue(double value);
                /*0x3608600*/ void WriteValue(System.Nullable<double> value);
                /*0x360877c*/ void WriteUndefined();
                /*0x36087c8*/ void WriteNull();
                /*0x3608814*/ void WriteValue(float value);
                /*0x3608874*/ void WriteValue(System.Nullable<float> value);
                /*0x36089dc*/ void WriteValue(System.Guid value);
                /*0x3608a48*/ void WriteValue(System.Nullable<System.Guid> value);
                /*0x3608bcc*/ void WriteValue(int value);
                /*0x3608c2c*/ void WriteValue(System.Nullable<int> value);
                /*0x3608d94*/ void WriteValue(long value);
                /*0x3608df4*/ void WriteValue(System.Nullable<long> value);
                /*0x3608f70*/ void WriteValue(object value);
                /*0x3609068*/ void WriteValue(sbyte value);
                /*0x36090c8*/ void WriteValue(System.Nullable<sbyte> value);
                /*0x3609230*/ void WriteValue(short value);
                /*0x3609290*/ void WriteValue(System.Nullable<short> value);
                /*0x36093f8*/ void WriteValue(string value);
                /*0x3609458*/ void WriteValue(System.TimeSpan value);
                /*0x36094b8*/ void WriteValue(System.Nullable<System.TimeSpan> value);
                /*0x3609634*/ void WriteValue(uint value);
                /*0x3609694*/ void WriteValue(System.Nullable<uint> value);
                /*0x36097fc*/ void WriteValue(ulong value);
                /*0x360985c*/ void WriteValue(System.Nullable<ulong> value);
                /*0x36099d8*/ void WriteValue(System.Uri value);
                /*0x3609a9c*/ void WriteValue(ushort value);
                /*0x3609afc*/ void WriteValue(System.Nullable<ushort> value);
                /*0x3609c64*/ void WriteComment(string text);
                /*0x3609cc4*/ void WriteStartArray();
                /*0x3609d08*/ void WriteEndArray();
                /*0x3609d4c*/ void WriteStartConstructor(string name);
                /*0x3609da4*/ void WriteEndConstructor();
                /*0x3609de8*/ void WritePropertyName(string name);
                /*0x3609e48*/ void WritePropertyName(string name, bool escape);
                /*0x3609eb4*/ void WriteStartObject();
                /*0x3609ef8*/ void WriteEndObject();
                /*0x3609f3c*/ void WriteRawValue(string json);
                /*0x3609f9c*/ void WriteRaw(string json);
                /*0x3609ffc*/ void Close();
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

                static /*0x360a608*/ Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x360a050*/ JArray();
                /*0x360a12c*/ JArray(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360a500*/ JArray(object content);
                /*0x360a040*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x360a048*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x360a5a0*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360aaa4*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x360ab84*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                /*0x360ab94*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x360aba4*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x360ac08*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x360ac18*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x360ac30*/ void RemoveAt(int index);
                /*0x360ac40*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                /*0x360acd8*/ void Add(Newtonsoft.Json.Linq.JToken item);
                /*0x360ace8*/ void Clear();
                /*0x360acf8*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x360ad08*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x360ad18*/ bool get_IsReadOnly();
                /*0x360ad20*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
            }

            class JConstructor : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ string _name;
                /*0x58*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0x360b0e8*/ Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x360adac*/ JConstructor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360ae60*/ JConstructor(string name);
                /*0x360ad30*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x360ad38*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x360ad9c*/ string get_Name();
                /*0x360ada4*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x360af94*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360affc*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
            }

            class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.ComponentModel.IBindingList, System.Collections.ICollection, System.Collections.IList
            {
                /*0x30*/ System.ComponentModel.ListChangedEventHandler _listChanged;
                /*0x38*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;
                /*0x40*/ object _syncRoot;
                /*0x48*/ bool _busy;

                static /*0x360cd58*/ bool IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue);
                static /*0x360dae0*/ Newtonsoft.Json.Linq.JToken CreateFromContent(object content);
                static /*0x360e108*/ Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent);
                /*0x360a0d4*/ JContainer();
                /*0x360a1c8*/ JContainer(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x1f30214*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x360b6d0*/ void CheckReentrancy();
                /*0x360b770*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
                /*0x360b7f8*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x360b880*/ bool get_HasValues();
                /*0x360b940*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x360ba7c*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x360bbb8*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x360bc2c*/ bool IsMultiContent(object content);
                /*0x360bd04*/ Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x1f3008c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x360be6c*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x360c2a0*/ void RemoveItemAt(int index);
                /*0x360c730*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x360c784*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x360c840*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x360ce08*/ void ClearItems();
                /*0x360d218*/ void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement);
                /*0x360d27c*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x360d2a0*/ void CopyItemsTo(System.Array array, int arrayIndex);
                /*0x360d754*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x360d870*/ void Add(object content);
                /*0x360d940*/ bool TryAdd(object content);
                /*0x360da10*/ void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token);
                /*0x360b368*/ bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations);
                /*0x360dbc4*/ void RemoveAll();
                /*0x360a948*/ void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options);
                /*0x360dbd4*/ void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x360e588*/ int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x360e598*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x360e5b0*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index);
                /*0x360e5c0*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index);
                /*0x360e5d0*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x360e5e0*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item);
                /*0x360e5f0*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear();
                /*0x360e600*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x360e610*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x360e620*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly();
                /*0x360e628*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item);
                /*0x360e638*/ Newtonsoft.Json.Linq.JToken EnsureValue(object value);
                /*0x360e6f4*/ int System.Collections.IList.Add(object value);
                /*0x360e738*/ void System.Collections.IList.Clear();
                /*0x360e748*/ bool System.Collections.IList.Contains(object value);
                /*0x360e77c*/ int System.Collections.IList.IndexOf(object value);
                /*0x360e7b0*/ void System.Collections.IList.Insert(int index, object value);
                /*0x360e7f8*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x360e800*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x360e808*/ void System.Collections.IList.Remove(object value);
                /*0x360e83c*/ void System.Collections.IList.RemoveAt(int index);
                /*0x360e84c*/ object System.Collections.IList.get_Item(int index);
                /*0x360e85c*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x360e89c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x360d6a0*/ int get_Count();
                /*0x360e8ac*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x360e8b4*/ object System.Collections.ICollection.get_SyncRoot();
            }

            struct JEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>>
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JEnumerable<T> Empty;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> _enumerable;

                static /*0x1f33998*/ JEnumerable();
                /*0x1f30ebc*/ JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1ffc854*/ bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other);
                /*0x1f2fec8*/ bool Equals(object obj);
                /*0x1f2ffc8*/ int GetHashCode();
            }

            class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x50*/ Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;
                /*0x58*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
                /*0x60*/ System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

                static /*0x360f224*/ Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x360dff0*/ JObject();
                /*0x360e9c0*/ JObject(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360e928*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x360ea3c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x360eb00*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x360eb70*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x360ee0c*/ void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x360ef58*/ void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x360ef78*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360efe0*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x360efe8*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties();
                /*0x360e2dc*/ Newtonsoft.Json.Linq.JProperty Property(string name, System.StringComparison comparison);
                /*0x360f030*/ Newtonsoft.Json.Linq.JToken get_Item(string propertyName);
                /*0x360f0b0*/ void set_Item(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x360f3e8*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x360f1a8*/ void Add(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x360f5e0*/ bool ContainsKey(string propertyName);
                /*0x360f6f8*/ System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys();
                /*0x360f764*/ bool Remove(string propertyName);
                /*0x360f7f8*/ bool TryGetValue(string propertyName, ref Newtonsoft.Json.Linq.JToken value);
                /*0x360f84c*/ System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values();
                /*0x360f884*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x360fa1c*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear();
                /*0x360fa2c*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x360fba0*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> array, int arrayIndex);
                /*0x360ffe0*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly();
                /*0x360ffe8*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x36101b0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> GetEnumerator();
                /*0x3610244*/ void OnPropertyChanged(string propertyName);
                /*0x36102d4*/ void OnPropertyChanging(string propertyName);
                /*0x3610364*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x3610400*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x36107c4*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x361081c*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x3610870*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                /*0x36108ec*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);

                class JObjectDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JObject>
                {
                    /*0x361099c*/ JObjectDynamicProxy();
                    /*0x36109e4*/ bool TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, ref object result);
                    /*0x3610a24*/ bool TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, object value);
                    /*0x3610b04*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance);

                    class <>c
                    {
                        static /*0x0*/ Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<> <>9;
                        static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JProperty, string> <>9__2_0;

                        static /*0x3610c18*/ <>c();
                        /*0x3610c80*/ <>c();
                        /*0x3610c88*/ string <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p);
                    }
                }

                class <GetEnumerator>d__64 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> <>2__current;
                    /*0x28*/ Newtonsoft.Json.Linq.JObject <>4__this;
                    /*0x30*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;

                    /*0x361021c*/ <GetEnumerator>d__64(int <>1__state);
                    /*0x3610c9c*/ void System.IDisposable.Dispose();
                    /*0x3610cb8*/ bool MoveNext();
                    /*0x3610f94*/ void <>m__Finally1();
                    /*0x3611044*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current();
                    /*0x3611050*/ void System.Collections.IEnumerator.Reset();
                    /*0x3611088*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class JProperty : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ Newtonsoft.Json.Linq.JProperty.JPropertyList _content;
                /*0x58*/ string _name;

                static /*0x36117a4*/ Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x36110f4*/ JProperty(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x360e470*/ JProperty(string name);
                /*0x360f4dc*/ JProperty(string name, object content);
                /*0x36110e4*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x36110ec*/ string get_Name();
                /*0x360dfd8*/ Newtonsoft.Json.Linq.JToken get_Value();
                /*0x360f128*/ void set_Value(Newtonsoft.Json.Linq.JToken value);
                /*0x3611194*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x36111e8*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x361132c*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x36113dc*/ void RemoveItemAt(int index);
                /*0x361148c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x36114c8*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x36115e4*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x3611604*/ void ClearItems();
                /*0x36116b4*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x361171c*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x3611724*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);

                class JPropertyList : System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JToken _token;

                    /*0x361118c*/ JPropertyList();
                    /*0x3611988*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                    /*0x3611a1c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3611a20*/ void Add(Newtonsoft.Json.Linq.JToken item);
                    /*0x3611a28*/ void Clear();
                    /*0x3611a34*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                    /*0x3611a44*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                    /*0x3611ab8*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
                    /*0x3611af0*/ int get_Count();
                    /*0x3611b00*/ bool get_IsReadOnly();
                    /*0x36114b8*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                    /*0x3611b08*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                    /*0x3611b1c*/ void RemoveAt(int index);
                    /*0x3611b30*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                    /*0x3611b74*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);

                    class <GetEnumerator>d__1 : System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ Newtonsoft.Json.Linq.JProperty.JPropertyList <>4__this;

                        /*0x36119f4*/ <GetEnumerator>d__1(int <>1__state);
                        /*0x3611bbc*/ void System.IDisposable.Dispose();
                        /*0x3611bc0*/ bool MoveNext();
                        /*0x3611c28*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0x3611c30*/ void System.Collections.IEnumerator.Reset();
                        /*0x3611c68*/ object System.Collections.IEnumerator.get_Current();
                    }
                }
            }

            class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x36107b8*/ JPropertyDescriptor(string name);
                /*0x3611c70*/ bool CanResetValue(object component);
                /*0x3611c78*/ object GetValue(object component);
                /*0x3611d14*/ void ResetValue(object component);
                /*0x3611d18*/ void SetValue(object component, object value);
                /*0x3611e48*/ bool ShouldSerializeValue(object component);
                /*0x3611e50*/ System.Type get_ComponentType();
                /*0x3611eb0*/ bool get_IsReadOnly();
                /*0x3611eb8*/ System.Type get_PropertyType();
                /*0x3611ee8*/ int get_NameHashCode();
            }

            class JPropertyKeyedCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.Linq.JToken>
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<string> Comparer;
                /*0x18*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Linq.JToken> _dictionary;

                static /*0x36124e8*/ JPropertyKeyedCollection();
                /*0x360e930*/ JPropertyKeyedCollection();
                /*0x3611ef0*/ void AddKey(string key, Newtonsoft.Json.Linq.JToken item);
                /*0x361201c*/ void ClearItems();
                /*0x360f64c*/ bool Contains(string key);
                /*0x3611f60*/ void EnsureDictionary();
                /*0x3612094*/ string GetKeyForItem(Newtonsoft.Json.Linq.JToken item);
                /*0x3612114*/ void InsertItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x361218c*/ void RemoveItem(int index);
                /*0x3612280*/ void RemoveKey(string key);
                /*0x36122e0*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x360ed84*/ bool TryGetValue(string key, ref Newtonsoft.Json.Linq.JToken value);
                /*0x360f70c*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0x360ea5c*/ int IndexOfReference(Newtonsoft.Json.Linq.JToken t);
            }

            class JRaw : Newtonsoft.Json.Linq.JValue
            {
                static /*0x36126e4*/ Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader);
                /*0x3612598*/ JRaw(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x361265c*/ JRaw(object rawJson);
                /*0x36129c4*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
            }

            class JsonCloneSettings
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JsonCloneSettings SkipCopyAnnotations;
                /*0x10*/ bool <CopyAnnotations>k__BackingField;

                static /*0x3612a5c*/ JsonCloneSettings();
                /*0x3612a2c*/ JsonCloneSettings();
                /*0x3612a4c*/ bool get_CopyAnnotations();
                /*0x3612a54*/ void set_CopyAnnotations(bool value);
            }

            class JsonLoadSettings
            {
                /*0x10*/ Newtonsoft.Json.Linq.CommentHandling _commentHandling;
                /*0x14*/ Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;
                /*0x18*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

                /*0x3612ac8*/ Newtonsoft.Json.Linq.CommentHandling get_CommentHandling();
                /*0x3612ad0*/ Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling();
                /*0x3612ad8*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling();
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

                static /*0x3619cc0*/ JToken();
                static /*0x3613238*/ Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value);
                static /*0x361334c*/ string GetType(Newtonsoft.Json.Linq.JToken token);
                static /*0x361343c*/ bool ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, bool nullable);
                static /*0x3613500*/ bool op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3613708*/ System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3613948*/ System.Nullable<bool> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3613bc0*/ long op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3613da4*/ System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3613fd0*/ System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3614274*/ System.Nullable<decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36144ec*/ System.Nullable<double> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3614714*/ System.Nullable<char> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3614954*/ int op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3614b38*/ short op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3614d1c*/ ushort op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3614f00*/ char op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36150e4*/ byte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36152c8*/ sbyte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36154ac*/ System.Nullable<int> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36156d4*/ System.Nullable<short> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3615914*/ System.Nullable<ushort> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3615b54*/ System.Nullable<byte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3615d94*/ System.Nullable<sbyte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3615fd4*/ System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36161cc*/ System.Nullable<long> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36163f4*/ System.Nullable<float> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x361661c*/ decimal op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3616800*/ System.Nullable<uint> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3616a28*/ System.Nullable<ulong> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3616c50*/ double op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3616e34*/ float op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617018*/ string op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x36172a0*/ uint op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617484*/ ulong op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617668*/ System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617888*/ System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617b00*/ System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617cfc*/ System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x3617f38*/ System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x361812c*/ System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value);
                static /*0x3618278*/ System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value);
                static /*0x3619464*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader);
                static /*0x36194bc*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x360b2cc*/ JToken();
                /*0x3612ae0*/ Newtonsoft.Json.Linq.JContainer get_Parent();
                /*0x3612ae8*/ void set_Parent(Newtonsoft.Json.Linq.JContainer value);
                /*0x360be54*/ Newtonsoft.Json.Linq.JToken get_Root();
                /*0x1f302cc*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x1f2ffc8*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x1f2fe14*/ bool get_HasValues();
                /*0x3612af0*/ Newtonsoft.Json.Linq.JToken get_Next();
                /*0x3612af8*/ void set_Next(Newtonsoft.Json.Linq.JToken value);
                /*0x3612b00*/ Newtonsoft.Json.Linq.JToken get_Previous();
                /*0x3612b08*/ void set_Previous(Newtonsoft.Json.Linq.JToken value);
                /*0x3612b10*/ string get_Path();
                /*0x3612e08*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x3612e98*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x3612f28*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x360f790*/ void Remove();
                /*0x360e518*/ void Replace(Newtonsoft.Json.Linq.JToken value);
                /*0x1f30ff0*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x3612f80*/ string ToString();
                /*0x3613020*/ string ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters);
                /*0x361841c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x36184b0*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                /*0x3618548*/ Newtonsoft.Json.JsonReader CreateReader();
                /*0x3618614*/ object ToObject(System.Type objectType);
                /*0x3619244*/ object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0x360a7a8*/ void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x36197d8*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x3619acc*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x3619b20*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x3619b74*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x3619bc8*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x3619c90*/ System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x3619ca0*/ object System.ICloneable.Clone();
                /*0x3619cb0*/ Newtonsoft.Json.Linq.JToken DeepClone();
                /*0x3619874*/ void AddAnnotation(object annotation);
                /*0x1ffc854*/ T Annotation<T>();
                /*0x360b2d4*/ void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source);

                class LineInfoAnnotation
                {
                    /*0x10*/ int LineNumber;
                    /*0x14*/ int LinePosition;

                    /*0x3619848*/ LineInfoAnnotation(int lineNumber, int linePosition);
                }
            }

            class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.Linq.JToken _root;
                /*0x80*/ string _initialPath;
                /*0x88*/ Newtonsoft.Json.Linq.JToken _parent;
                /*0x90*/ Newtonsoft.Json.Linq.JToken _current;

                /*0x36185a0*/ JTokenReader(Newtonsoft.Json.Linq.JToken token);
                /*0x3619fc8*/ Newtonsoft.Json.Linq.JToken get_CurrentToken();
                /*0x3619fd0*/ bool Read();
                /*0x361a130*/ bool ReadOver(Newtonsoft.Json.Linq.JToken t);
                /*0x361a81c*/ bool ReadToEnd();
                /*0x361a9b8*/ System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c);
                /*0x361a0ac*/ bool ReadInto(Newtonsoft.Json.Linq.JContainer c);
                /*0x361a84c*/ bool SetEnd(Newtonsoft.Json.Linq.JContainer c);
                /*0x361a1fc*/ void SetToken(Newtonsoft.Json.Linq.JToken token);
                /*0x361ab14*/ string SafeToString(object value);
                /*0x361ab34*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x361abe8*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x361aca0*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x361ad58*/ string get_Path();
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

                /*0x361ae64*/ JTokenWriter();
                /*0x361ae48*/ Newtonsoft.Json.Linq.JToken get_Token();
                /*0x361aebc*/ void Close();
                /*0x361aec4*/ void WriteStartObject();
                /*0x361af28*/ void AddParent(Newtonsoft.Json.Linq.JContainer container);
                /*0x361af88*/ void RemoveParent();
                /*0x361aff8*/ void WriteStartArray();
                /*0x361b05c*/ void WriteStartConstructor(string name);
                /*0x361b0d4*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
                /*0x361b0d8*/ void WritePropertyName(string name);
                /*0x361b198*/ void AddRawValue(object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token);
                /*0x361b208*/ void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token);
                /*0x361b2c8*/ void WriteValue(object value);
                /*0x361b358*/ void WriteNull();
                /*0x361b37c*/ void WriteUndefined();
                /*0x361b3a0*/ void WriteRaw(string json);
                /*0x361b41c*/ void WriteComment(string text);
                /*0x361b450*/ void WriteValue(string value);
                /*0x361b4d4*/ void WriteValue(int value);
                /*0x361b524*/ void WriteValue(uint value);
                /*0x361b574*/ void WriteValue(long value);
                /*0x361b660*/ void WriteValue(ulong value);
                /*0x361b73c*/ void WriteValue(float value);
                /*0x361b818*/ void WriteValue(double value);
                /*0x361b904*/ void WriteValue(bool value);
                /*0x361b9f0*/ void WriteValue(short value);
                /*0x361ba40*/ void WriteValue(ushort value);
                /*0x361ba90*/ void WriteValue(char value);
                /*0x361bb78*/ void WriteValue(byte value);
                /*0x361bbc8*/ void WriteValue(sbyte value);
                /*0x361bc18*/ void WriteValue(decimal value);
                /*0x361bd18*/ void WriteValue(System.DateTime value);
                /*0x361be3c*/ void WriteValue(System.DateTimeOffset value);
                /*0x361bf38*/ void WriteValue(byte[] value);
                /*0x361bfb4*/ void WriteValue(System.TimeSpan value);
                /*0x361c098*/ void WriteValue(System.Guid value);
                /*0x361c194*/ void WriteValue(System.Uri value);
                /*0x361c290*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            }

            class JValue : Newtonsoft.Json.Linq.JToken, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IConvertible
            {
                /*0x30*/ Newtonsoft.Json.Linq.JTokenType _valueType;
                /*0x38*/ object _value;

                static /*0x361c8c4*/ int CompareBigInteger(System.Numerics.BigInteger i1, object i2);
                static /*0x361cbac*/ int Compare(Newtonsoft.Json.Linq.JTokenType valueType, object objA, object objB);
                static /*0x361d64c*/ int CompareFloat(object objA, object objB);
                static /*0x361d748*/ bool Operation(System.Linq.Expressions.ExpressionType operation, object objA, object objB, ref object result);
                static /*0x360e054*/ Newtonsoft.Json.Linq.JValue CreateComment(string value);
                static /*0x360bdfc*/ Newtonsoft.Json.Linq.JValue CreateNull();
                static /*0x360e0b0*/ Newtonsoft.Json.Linq.JValue CreateUndefined();
                static /*0x361c594*/ Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value);
                static /*0x361dfac*/ Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current);
                static /*0x361ea84*/ bool ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2);
                /*0x3612664*/ JValue(object value, Newtonsoft.Json.Linq.JTokenType type);
                /*0x361259c*/ JValue(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x361b5ec*/ JValue(long value);
                /*0x361bc9c*/ JValue(decimal value);
                /*0x361b6fc*/ JValue(ulong value);
                /*0x361b890*/ JValue(double value);
                /*0x361b7d8*/ JValue(float value);
                /*0x361bdd0*/ JValue(System.DateTime value);
                /*0x361bec0*/ JValue(System.DateTimeOffset value);
                /*0x361b97c*/ JValue(bool value);
                /*0x361b4cc*/ JValue(string value);
                /*0x361c11c*/ JValue(System.Guid value);
                /*0x361c20c*/ JValue(System.Uri value);
                /*0x361c02c*/ JValue(System.TimeSpan value);
                /*0x360db94*/ JValue(object value);
                /*0x361c8bc*/ bool get_HasValues();
                /*0x361df44*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x361e154*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x361e15c*/ object get_Value();
                /*0x361e164*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x361eae0*/ bool Equals(Newtonsoft.Json.Linq.JValue other);
                /*0x361eaf0*/ bool Equals(object obj);
                /*0x361eb7c*/ int GetHashCode();
                /*0x361eb94*/ string ToString();
                /*0x361ebc0*/ string ToString(System.IFormatProvider formatProvider);
                /*0x361ebcc*/ string ToString(string format, System.IFormatProvider formatProvider);
                /*0x361ecd8*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x361edd0*/ int System.IComparable.CompareTo(object obj);
                /*0x361ee80*/ int CompareTo(Newtonsoft.Json.Linq.JValue obj);
                /*0x361eeb0*/ System.TypeCode System.IConvertible.GetTypeCode();
                /*0x361ef6c*/ bool System.IConvertible.ToBoolean(System.IFormatProvider provider);
                /*0x361efc0*/ char System.IConvertible.ToChar(System.IFormatProvider provider);
                /*0x361f014*/ sbyte System.IConvertible.ToSByte(System.IFormatProvider provider);
                /*0x361f068*/ byte System.IConvertible.ToByte(System.IFormatProvider provider);
                /*0x361f0bc*/ short System.IConvertible.ToInt16(System.IFormatProvider provider);
                /*0x361f110*/ ushort System.IConvertible.ToUInt16(System.IFormatProvider provider);
                /*0x361f164*/ int System.IConvertible.ToInt32(System.IFormatProvider provider);
                /*0x361f1b8*/ uint System.IConvertible.ToUInt32(System.IFormatProvider provider);
                /*0x361f20c*/ long System.IConvertible.ToInt64(System.IFormatProvider provider);
                /*0x361f260*/ ulong System.IConvertible.ToUInt64(System.IFormatProvider provider);
                /*0x361f2b4*/ float System.IConvertible.ToSingle(System.IFormatProvider provider);
                /*0x361f308*/ double System.IConvertible.ToDouble(System.IFormatProvider provider);
                /*0x361f35c*/ decimal System.IConvertible.ToDecimal(System.IFormatProvider provider);
                /*0x361f3b0*/ System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider);
                /*0x361f404*/ object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider);

                class JValueDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JValue>
                {
                    /*0x361ed88*/ JValueDynamicProxy();
                    /*0x361f408*/ bool TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, ref object result);
                    /*0x361f5e8*/ bool TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
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

                static /*0x361fb54*/ void EnsureReflectionObject(System.Type t);
                /*0x3620450*/ BinaryConverter();
                /*0x361f914*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x361f968*/ byte[] GetByteArray(object value);
                /*0x361fd08*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x36200f4*/ byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader);
                /*0x3620344*/ bool CanConvert(System.Type objectType);
            }

            class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x3620744*/ BsonObjectIdConverter();
                /*0x3620458*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x362054c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x36206d0*/ bool CanConvert(System.Type objectType);
            }

            class CustomCreationConverter<T> : Newtonsoft.Json.JsonConverter
            {
                /*0x1f309e4*/ CustomCreationConverter();
                /*0x1f310fc*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1f3040c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1ffc854*/ T Create(System.Type objectType);
                /*0x1f2fec8*/ bool CanConvert(System.Type objectType);
                /*0x1f2fe14*/ bool get_CanWrite();
            }

            class DataSetConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x3620ef4*/ DataSetConverter();
                /*0x362074c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3620bb4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3620e74*/ bool CanConvert(System.Type valueType);
            }

            class DataTableConverter : Newtonsoft.Json.JsonConverter
            {
                static /*0x3621920*/ void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer);
                static /*0x3621ddc*/ System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader);
                /*0x3620bac*/ DataTableConverter();
                /*0x3620efc*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3621654*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3621f9c*/ bool CanConvert(System.Type valueType);
            }

            class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
            {
                /*0x3622178*/ DateTimeConverterBase();
                /*0x362201c*/ bool CanConvert(System.Type objectType);
            }

            class DiscriminatedUnionConverter : Newtonsoft.Json.JsonConverter
            {
                static string CasePropertyName = "Case";
                static string FieldsPropertyName = "Fields";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache;

                static /*0x36239d4*/ DiscriminatedUnionConverter();
                static /*0x3622180*/ System.Type CreateUnionTypeLookup(System.Type t);
                static /*0x362239c*/ Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t);
                /*0x36239cc*/ DiscriminatedUnionConverter();
                /*0x3622bec*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x36230cc*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3623738*/ bool CanConvert(System.Type objectType);

                class Union
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.FSharpFunction TagReader;
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;

                    /*0x3622b24*/ Union(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases);
                }

                class UnionCase
                {
                    /*0x10*/ int Tag;
                    /*0x18*/ string Name;
                    /*0x20*/ System.Reflection.PropertyInfo[] Fields;
                    /*0x28*/ Newtonsoft.Json.Utilities.FSharpFunction FieldReader;
                    /*0x30*/ Newtonsoft.Json.Utilities.FSharpFunction Constructor;

                    /*0x3622b68*/ UnionCase(int tag, string name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ int tag;

                    /*0x36230c4*/ <>c__DisplayClass8_0();
                    /*0x3623b64*/ bool <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ string caseName;
                    /*0x18*/ System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> <>9__0;

                    /*0x3623730*/ <>c__DisplayClass9_0();
                    /*0x3623b84*/ bool <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }
            }

            class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
            {
                static string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
                static string KeyPropertyName = "Key";
                static string TypePropertyName = "Type";
                static string ValuePropertyName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0x362401c*/ void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, string propertyName);
                static /*0x3623efc*/ void EnsureReflectionObject(System.Type objectType);
                /*0x362440c*/ EntityKeyMemberConverter();
                /*0x3623ba4*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3624108*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x36243bc*/ bool CanConvert(System.Type objectType);
            }

            class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x3624938*/ ExpandoObjectConverter();
                /*0x3624414*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3624418*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x362441c*/ object ReadValue(Newtonsoft.Json.JsonReader reader);
                /*0x3624734*/ object ReadList(Newtonsoft.Json.JsonReader reader);
                /*0x3624578*/ object ReadObject(Newtonsoft.Json.JsonReader reader);
                /*0x36248bc*/ bool CanConvert(System.Type objectType);
                /*0x3624930*/ bool get_CanWrite();
            }

            class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
                /*0x10*/ System.Globalization.DateTimeStyles _dateTimeStyles;
                /*0x18*/ string _dateTimeFormat;
                /*0x20*/ System.Globalization.CultureInfo _culture;

                /*0x3625198*/ IsoDateTimeConverter();
                /*0x3624940*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
                /*0x3624948*/ void set_DateTimeStyles(System.Globalization.DateTimeStyles value);
                /*0x3624950*/ string get_DateTimeFormat();
                /*0x3624974*/ void set_DateTimeFormat(string value);
                /*0x36249b4*/ System.Globalization.CultureInfo get_Culture();
                /*0x3624a1c*/ void set_Culture(System.Globalization.CultureInfo value);
                /*0x3624a24*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3624c8c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                /*0x36256b0*/ JavaScriptDateTimeConverter();
                /*0x36251a8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x362538c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
            {
                static string KeyName = "Key";
                static string ValueName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

                static /*0x362617c*/ KeyValuePairConverter();
                static /*0x36256b8*/ Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t);
                /*0x3626174*/ KeyValuePairConverter();
                /*0x3625934*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3625bb0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3626068*/ bool CanConvert(System.Type objectType);
            }

            class RegexConverter : Newtonsoft.Json.JsonConverter
            {
                static string PatternName = "Pattern";
                static string OptionsName = "Options";

                /*0x3626d0c*/ RegexConverter();
                /*0x3626264*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x362666c*/ bool HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag);
                /*0x362637c*/ void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex);
                /*0x36264b0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3626728*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3626ac4*/ object ReadRegexString(Newtonsoft.Json.JsonReader reader);
                /*0x36267d4*/ System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3626c1c*/ bool CanConvert(System.Type objectType);
                /*0x3626c98*/ bool IsRegex(System.Type objectType);
            }

            class StringEnumConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;
                /*0x18*/ bool <AllowIntegerValues>k__BackingField;

                /*0x3626e94*/ StringEnumConverter();
                /*0x3626ea4*/ StringEnumConverter(bool camelCaseText);
                /*0x3626f2c*/ StringEnumConverter(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, bool allowIntegerValues);
                /*0x3626f70*/ StringEnumConverter(System.Type namingStrategyType);
                /*0x3627020*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters);
                /*0x36270dc*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues);
                /*0x3626d14*/ bool get_CamelCaseText();
                /*0x3626d90*/ void set_CamelCaseText(bool value);
                /*0x3626e74*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x3626e7c*/ void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value);
                /*0x3626e84*/ bool get_AllowIntegerValues();
                /*0x3626e8c*/ void set_AllowIntegerValues(bool value);
                /*0x36271a8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x36273a0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3627828*/ bool CanConvert(System.Type objectType);
            }

            class UnixDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static /*0x0*/ System.DateTime UnixEpoch;
                /*0x10*/ bool <AllowPreEpoch>k__BackingField;

                static /*0x3627f30*/ UnixDateTimeConverter();
                /*0x36278b0*/ UnixDateTimeConverter();
                /*0x36278cc*/ UnixDateTimeConverter(bool allowPreEpoch);
                /*0x36278a0*/ bool get_AllowPreEpoch();
                /*0x36278a8*/ void set_AllowPreEpoch(bool value);
                /*0x36278f4*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3627b60*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class VersionConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x3628380*/ VersionConverter();
                /*0x3627fac*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3628094*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x362830c*/ bool CanConvert(System.Type objectType);
            }

            class XmlDocumentWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocument _document;

                /*0x3628388*/ XmlDocumentWrapper(System.Xml.XmlDocument document);
                /*0x36283f8*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string data);
                /*0x362848c*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x3628520*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x36285b4*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x3628648*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x36286dc*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x36287b8*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x3628898*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x362893c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x36289f8*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x3628a84*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x3628b54*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x3628c10*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            class XmlElementWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlElement _element;

                /*0x36289b8*/ XmlElementWrapper(System.Xml.XmlElement element);
                /*0x3628ca0*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x3628d88*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x3628da8*/ bool get_IsEmpty();
            }

            class XmlDeclarationWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDeclaration _declaration;

                /*0x3628778*/ XmlDeclarationWrapper(System.Xml.XmlDeclaration declaration);
                /*0x3628dc0*/ string get_Version();
                /*0x3628dd8*/ string get_Encoding();
                /*0x3628df0*/ string get_Standalone();
            }

            class XmlDocumentTypeWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocumentType _documentType;

                /*0x3628858*/ XmlDocumentTypeWrapper(System.Xml.XmlDocumentType documentType);
                /*0x3628e08*/ string get_Name();
                /*0x3628e24*/ string get_System();
                /*0x3628e3c*/ string get_Public();
                /*0x3628e54*/ string get_InternalSubset();
                /*0x3628e6c*/ string get_LocalName();
            }

            class XmlNodeWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.XmlNode _node;
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                static /*0x36292ac*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node);
                /*0x36283c8*/ XmlNodeWrapper(System.Xml.XmlNode node);
                /*0x3628eac*/ object get_WrappedNode();
                /*0x3628eb4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x3628ed0*/ string get_LocalName();
                /*0x3628ef0*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x3629490*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x3629844*/ bool get_HasAttributes();
                /*0x36298f4*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x362999c*/ string get_Value();
                /*0x3628b38*/ void set_Value(string value);
                /*0x36299b8*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x3629a78*/ string get_NamespaceUri();
            }

            interface IXmlDocument : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x1f303d0*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x1f3040c*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x1f30394*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x1f30394*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x1f30394*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x1f303d0*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x1f30214*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            interface IXmlDeclaration : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x1f30214*/ string get_Version();
                /*0x1f30214*/ string get_Encoding();
                /*0x1f30214*/ string get_Standalone();
            }

            interface IXmlDocumentType : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x1f30214*/ string get_Name();
                /*0x1f30214*/ string get_System();
                /*0x1f30214*/ string get_Public();
                /*0x1f30214*/ string get_InternalSubset();
            }

            interface IXmlElement : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x1f30ebc*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x1f302cc*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x1f2fe14*/ bool get_IsEmpty();
            }

            interface IXmlNode
            {
                /*0x1f2ffc8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x1f30214*/ string get_LocalName();
                /*0x1f30214*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x1f30214*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x1f30214*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x1f30214*/ string get_Value();
                /*0x1f302cc*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x1f30214*/ string get_NamespaceUri();
                /*0x1f30214*/ object get_WrappedNode();
            }

            class XDeclarationWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDeclaration <Declaration>k__BackingField;

                /*0x3629aa0*/ XDeclarationWrapper(System.Xml.Linq.XDeclaration declaration);
                /*0x3629a98*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x3629b10*/ System.Xml.XmlNodeType get_NodeType();
                /*0x3629b18*/ string get_Version();
                /*0x3629b30*/ string get_Encoding();
                /*0x3629b48*/ string get_Standalone();
            }

            class XDocumentTypeWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDocumentType _documentType;

                /*0x3629b60*/ XDocumentTypeWrapper(System.Xml.Linq.XDocumentType documentType);
                /*0x3629ba0*/ string get_Name();
                /*0x3629bb8*/ string get_System();
                /*0x3629bd0*/ string get_Public();
                /*0x3629be8*/ string get_InternalSubset();
                /*0x3629c00*/ string get_LocalName();
            }

            class XDocumentWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x3629cb8*/ XDocumentWrapper(System.Xml.Linq.XDocument document);
                /*0x3629c40*/ System.Xml.Linq.XDocument get_Document();
                /*0x3629d18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x362a224*/ bool get_HasChildNodes();
                /*0x362a288*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x362a324*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x362a3c0*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x362a45c*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x362a4f8*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x362a594*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x362a638*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x362a6e4*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x362a7b8*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x362a898*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x362a958*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x362aa40*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x362ab10*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
                /*0x362abb8*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XTextWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x362adb0*/ XTextWrapper(System.Xml.Linq.XText text);
                /*0x362ad38*/ System.Xml.Linq.XText get_Text();
                /*0x362ade0*/ string get_Value();
                /*0x362adfc*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XCommentWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x362b1c0*/ XCommentWrapper(System.Xml.Linq.XComment text);
                /*0x362b148*/ System.Xml.Linq.XComment get_Text();
                /*0x362b1f0*/ string get_Value();
                /*0x362b20c*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XProcessingInstructionWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x362a788*/ XProcessingInstructionWrapper(System.Xml.Linq.XProcessingInstruction processingInstruction);
                /*0x362b250*/ System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction();
                /*0x362b2c8*/ string get_LocalName();
                /*0x362b2e4*/ string get_Value();
            }

            class XContainerWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;

                static /*0x362ae40*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node);
                /*0x3629ce8*/ XContainerWrapper(System.Xml.Linq.XContainer container);
                /*0x362b300*/ System.Xml.Linq.XContainer get_Container();
                /*0x3629e90*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x362a260*/ bool get_HasChildNodes();
                /*0x362b378*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x362ac5c*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XObjectWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.Linq.XObject _xmlObject;

                /*0x3629ae0*/ XObjectWrapper(System.Xml.Linq.XObject xmlObject);
                /*0x362b3bc*/ object get_WrappedNode();
                /*0x362b3c4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x362b3dc*/ string get_LocalName();
                /*0x362b3e4*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x362b43c*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x362b494*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x362b49c*/ string get_Value();
                /*0x362b4a4*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x362b4dc*/ string get_NamespaceUri();
            }

            class XAttributeWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x362aa10*/ XAttributeWrapper(System.Xml.Linq.XAttribute attribute);
                /*0x362b4e4*/ System.Xml.Linq.XAttribute get_Attribute();
                /*0x362b55c*/ string get_Value();
                /*0x362b578*/ string get_LocalName();
                /*0x362b59c*/ string get_NamespaceUri();
                /*0x362b5c0*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XElementWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                /*0x362a868*/ XElementWrapper(System.Xml.Linq.XElement element);
                /*0x362b604*/ System.Xml.Linq.XElement get_Element();
                /*0x362b67c*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x362b728*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x362bc14*/ bool HasImplicitNamespaceAttribute(string namespaceUri);
                /*0x362c0c4*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x362c0f8*/ string get_Value();
                /*0x362c114*/ string get_LocalName();
                /*0x362c138*/ string get_NamespaceUri();
                /*0x362c084*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x362c15c*/ bool get_IsEmpty();
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

                static /*0x36349b8*/ XmlNodeConverter();
                static /*0x362fc24*/ bool AllSameName(Newtonsoft.Json.Converters.IXmlNode node);
                static /*0x36335f0*/ void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, string attributeName, System.Xml.XmlNamespaceManager manager, string attributePrefix);
                static /*0x3631bc0*/ string ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader);
                /*0x36349b0*/ XmlNodeConverter();
                /*0x362c178*/ string get_DeserializeRootElementName();
                /*0x362c180*/ void set_DeserializeRootElementName(string value);
                /*0x362c188*/ bool get_WriteArrayAttribute();
                /*0x362c190*/ void set_WriteArrayAttribute(bool value);
                /*0x362c198*/ bool get_OmitRootObject();
                /*0x362c1a0*/ void set_OmitRootObject(bool value);
                /*0x362c1a8*/ bool get_EncodeSpecialCharacters();
                /*0x362c1b0*/ void set_EncodeSpecialCharacters(bool value);
                /*0x362c1b8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x362c304*/ Newtonsoft.Json.Converters.IXmlNode WrapXml(object value);
                /*0x362c41c*/ void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x362e284*/ string ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x362e610*/ string GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x362ea94*/ bool IsArray(Newtonsoft.Json.Converters.IXmlNode node);
                /*0x362ee80*/ void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x362f9dc*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames);
                /*0x362fb54*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, string elementNames);
                /*0x362cb10*/ void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x363029c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3631614*/ void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x3630ae8*/ void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, System.Xml.XmlNamespaceManager manager);
                /*0x363396c*/ void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string elementName, System.Xml.XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<string, string> attributeNameValues);
                /*0x3632b38*/ void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager);
                /*0x36343e8*/ void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document);
                /*0x3632f38*/ bool ShouldReadInto(Newtonsoft.Json.JsonReader reader);
                /*0x3632f78*/ System.Collections.Generic.Dictionary<string, string> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager);
                /*0x36322c8*/ void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName);
                /*0x3632760*/ void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x36341fc*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName, Newtonsoft.Json.Converters.IXmlDocument document, string elementPrefix, System.Xml.XmlNamespaceManager manager);
                /*0x3630e30*/ void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x3634728*/ bool IsNamespaceAttribute(string attributeName, ref string prefix);
                /*0x362ff3c*/ bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c);
                /*0x3634808*/ bool CanConvert(System.Type valueType);
                /*0x36348b0*/ bool IsXObject(System.Type valueType);
                /*0x3634930*/ bool IsXmlNode(System.Type valueType);
            }
        }

        namespace Bson
        {
            class BsonObjectId
            {
                /*0x10*/ byte[] <Value>k__BackingField;

                /*0x3634a58*/ BsonObjectId(byte[] value);
                /*0x3634a50*/ byte[] get_Value();
            }

            class BsonToken
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;

                /*0x3634b44*/ BsonToken();
                Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x3634b3c*/ void set_Parent(Newtonsoft.Json.Bson.BsonToken value);
            }

            class BsonObject : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;

                /*0x3634b4c*/ void Add(string name, Newtonsoft.Json.Bson.BsonToken token);
                /*0x3634ca8*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonArray : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;

                /*0x3634cb0*/ void Add(Newtonsoft.Json.Bson.BsonToken token);
                /*0x3634d1c*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonValue : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ object _value;
                /*0x20*/ Newtonsoft.Json.Bson.BsonType _type;

                /*0x3634d24*/ BsonValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x3634d60*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonString : Newtonsoft.Json.Bson.BsonValue
            {
                /*0x21*/ bool <IncludeLength>k__BackingField;

                /*0x3634c64*/ BsonString(object value, bool includeLength);
            }

            class BsonRegex : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;
                /*0x20*/ Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;

                /*0x3634d78*/ BsonRegex(string pattern, string options);
                /*0x3634d68*/ void set_Pattern(Newtonsoft.Json.Bson.BsonString value);
                /*0x3634d70*/ void set_Options(Newtonsoft.Json.Bson.BsonString value);
                /*0x3634e4c*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonProperty
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;

                /*0x3634c5c*/ BsonProperty();
                /*0x3634e54*/ void set_Name(Newtonsoft.Json.Bson.BsonString value);
                /*0x3634e5c*/ void set_Value(Newtonsoft.Json.Bson.BsonToken value);
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

                /*0x3634e64*/ void AddValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x3634ee4*/ void AddToken(Newtonsoft.Json.Bson.BsonToken token);
                /*0x36350cc*/ void WriteObjectId(byte[] value);
                /*0x3626678*/ void WriteRegex(string pattern, string options);
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
