class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7241cac*/ EmbeddedAttribute();
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
                /*0x7241cb4*/ IsReadOnlyAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x7241cbc*/ NullableAttribute(byte );
                /*0x7241d44*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7241d74*/ NullableContextAttribute(byte );
            }
        }
    }

    namespace Diagnostics
    {
        namespace CodeAnalysis
        {
            class NotNullAttribute : System.Attribute
            {
                /*0x7241d9c*/ NotNullAttribute();
            }

            class NotNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x7241da4*/ NotNullWhenAttribute(bool returnValue);
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

            static /*0x7241dcc*/ DefaultJsonNameTable();
            static /*0x724201c*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x7241e1c*/ DefaultJsonNameTable();
            /*0x7241e94*/ string Get(char[] key, int start, int length);
            /*0x72420d8*/ string Add(string key);
            /*0x7242280*/ string AddEntry(string str, int hashCode);
            /*0x72423e8*/ void Grow();

            class Entry
            {
                /*0x10*/ string Value;
                /*0x18*/ int HashCode;
                /*0x20*/ Newtonsoft.Json.DefaultJsonNameTable.Entry Next;

                /*0x7242394*/ Entry(string value, int hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next);
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
            /*0x3814964*/ T[] Rent(int minimumLength);
            /*0x3816710*/ void Return(T[] array);
        }

        interface IJsonLineInfo
        {
            /*0x3813ffc*/ bool HasLineInfo();
            /*0x3814574*/ int get_LineNumber();
            /*0x3814574*/ int get_LinePosition();
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

            /*0x7242540*/ System.Type get_ItemConverterType();
            /*0x7242548*/ object[] get_ItemConverterParameters();
            /*0x7242550*/ System.Type get_NamingStrategyType();
            /*0x7242558*/ object[] get_NamingStrategyParameters();
            /*0x7242560*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance();
            /*0x7242568*/ void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value);
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

            static /*0x72438d8*/ JsonConvert();
            static /*0x7242570*/ System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings();
            static /*0x72425c8*/ string ToString(bool value);
            static /*0x7242634*/ string ToString(char value);
            static /*0x724270c*/ string ToString(float value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x72428c0*/ string EnsureFloatFormat(double value, string text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x72429d8*/ string ToString(double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x72427fc*/ string EnsureDecimalPlace(double value, string text);
            static /*0x7242ac4*/ string EnsureDecimalPlace(string text);
            static /*0x7242b38*/ string ToString(decimal value);
            static /*0x72426b4*/ string ToString(string value);
            static /*0x7242c2c*/ string ToString(string value, char delimiter);
            static /*0x7242c94*/ string ToString(string value, char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
            static /*0x7242d78*/ string SerializeObject(object value);
            static /*0x7242e50*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting);
            static /*0x7242f28*/ string SerializeObject(object value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7242dd4*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7242eb8*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7243254*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7242fc4*/ string SerializeObjectInternal(object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer);
            static /*0x72434c4*/ object DeserializeObject(string value, System.Type type);
            static /*0x3910ae8*/ T DeserializeObject<T>(string value);
            static /*0x3910ae8*/ T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x724352c*/ object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
        }

        class JsonConverter
        {
            /*0x7243a50*/ JsonConverter();
            /*0x3816920*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
            /*0x3814c50*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            /*0x38141c4*/ bool CanConvert(System.Type objectType);
            /*0x7243a40*/ bool get_CanRead();
            /*0x7243a48*/ bool get_CanWrite();
        }

        class JsonConverterAttribute : System.Attribute
        {
            /*0x10*/ System.Type _converterType;
            /*0x18*/ object[] <ConverterParameters>k__BackingField;

            /*0x7243a58*/ System.Type get_ConverterType();
            /*0x7243a60*/ object[] get_ConverterParameters();
        }

        class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter>
        {
            /*0x7243a68*/ JsonConverterCollection();
        }

        class JsonDictionaryAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
        }

        class JsonException : System.Exception
        {
            /*0x7243ab0*/ JsonException();
            /*0x7243b08*/ JsonException(string message);
            /*0x7243b70*/ JsonException(string message, System.Exception innerException);
            /*0x7243be0*/ JsonException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class JsonExtensionDataAttribute : System.Attribute
        {
            /*0x10*/ bool <WriteData>k__BackingField;
            /*0x11*/ bool <ReadData>k__BackingField;

            /*0x7243c60*/ bool get_WriteData();
            /*0x7243c68*/ bool get_ReadData();
        }

        class JsonIgnoreAttribute : System.Attribute
        {
            /*0x7243c70*/ JsonIgnoreAttribute();
        }

        class JsonNameTable
        {
            /*0x7241e8c*/ JsonNameTable();
            string Get(char[] key, int start, int length);
        }

        class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
            /*0x50*/ Newtonsoft.Json.MemberSerialization _memberSerialization;
            /*0x54*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;
            /*0x5c*/ System.Nullable<Newtonsoft.Json.Required> _itemRequired;
            /*0x64*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;

            /*0x7243c78*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
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

            static /*0x72445f8*/ JsonPosition();
            static /*0x7243d04*/ bool TypeHasIndex(Newtonsoft.Json.JsonContainerType type);
            static /*0x7243fc4*/ string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition);
            static /*0x72442d8*/ string FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message);
            /*0x7243c80*/ JsonPosition(Newtonsoft.Json.JsonContainerType type);
            /*0x7243d14*/ int CalculateLength();
            /*0x7243da8*/ void WriteTo(System.Text.StringBuilder sb, ref System.IO.StringWriter writer, ref char[] buffer);
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

            /*0x72446c8*/ JsonPropertyAttribute();
            /*0x7244698*/ System.Type get_ItemConverterType();
            /*0x72446a0*/ object[] get_ItemConverterParameters();
            /*0x72446a8*/ System.Type get_NamingStrategyType();
            /*0x72446b0*/ object[] get_NamingStrategyParameters();
            /*0x72446b8*/ string get_PropertyName();
            /*0x72446c0*/ void set_PropertyName(string value);
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

            /*0x7244bd4*/ JsonReader();
            /*0x72446d0*/ Newtonsoft.Json.JsonReader.State get_CurrentState();
            /*0x72446d8*/ bool get_CloseInput();
            /*0x72446e0*/ void set_CloseInput(bool value);
            /*0x72446ec*/ bool get_SupportMultipleContent();
            /*0x72446f4*/ void set_SupportMultipleContent(bool value);
            /*0x7244700*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x7244708*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x7244768*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x7244770*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x72447d0*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x72447d8*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x7244838*/ string get_DateFormatString();
            /*0x7244840*/ void set_DateFormatString(string value);
            /*0x7244848*/ System.Nullable<int> get_MaxDepth();
            /*0x7244850*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x724490c*/ Newtonsoft.Json.JsonToken get_TokenType();
            /*0x7244914*/ object get_Value();
            /*0x724491c*/ System.Type get_ValueType();
            /*0x7244930*/ int get_Depth();
            /*0x72449ac*/ string get_Path();
            /*0x7244ac0*/ System.Globalization.CultureInfo get_Culture();
            /*0x7244b28*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x7244b30*/ Newtonsoft.Json.JsonPosition GetPosition(int depth);
            /*0x7244c64*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x7244f50*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x7245078*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x3813ffc*/ bool Read();
            /*0x7245080*/ System.Nullable<int> ReadAsInt32();
            /*0x7245638*/ System.Nullable<int> ReadInt32String(string s);
            /*0x72457e8*/ string ReadAsString();
            /*0x7245a6c*/ byte[] ReadAsBytes();
            /*0x7246030*/ byte[] ReadArrayIntoByteArray();
            /*0x7246150*/ bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<byte> buffer);
            /*0x7246354*/ System.Nullable<double> ReadAsDouble();
            /*0x7246620*/ System.Nullable<double> ReadDoubleString(string s);
            /*0x72467c8*/ System.Nullable<bool> ReadAsBoolean();
            /*0x7246ac8*/ System.Nullable<bool> ReadBooleanString(string s);
            /*0x7246c78*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x7247064*/ System.Nullable<decimal> ReadDecimalString(string s);
            /*0x72472cc*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x724754c*/ System.Nullable<System.DateTime> ReadDateTimeString(string s);
            /*0x72477d8*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x7247a54*/ System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s);
            /*0x7245fec*/ void ReaderReadAndAssert();
            /*0x7247c9c*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException();
            /*0x7245e20*/ void ReadIntoWrappedTypeObject();
            /*0x7247ce8*/ void Skip();
            /*0x7246144*/ void SetToken(Newtonsoft.Json.JsonToken newToken);
            /*0x7247d80*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value);
            /*0x72454e8*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value, bool updateIndex);
            /*0x7247e84*/ void SetPostValueState(bool updateIndex);
            /*0x7244f30*/ void UpdateScopeWithFinishedValue();
            /*0x7247d88*/ void ValidateEnd(Newtonsoft.Json.JsonToken endToken);
            /*0x7247f90*/ void SetStateBasedOnCurrent();
            /*0x7247ec0*/ void SetFinished();
            /*0x7247ee8*/ Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token);
            /*0x724807c*/ void System.IDisposable.Dispose();
            /*0x72480ec*/ void Dispose(bool disposing);
            /*0x7248110*/ void Close();
            /*0x7248128*/ void ReadAndAssert();
            /*0x7248184*/ void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x72481d4*/ bool ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x724844c*/ bool ReadAndMoveToContent();
            /*0x724847c*/ bool MoveToContent();
            /*0x724540c*/ Newtonsoft.Json.JsonToken GetContentToken();

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

            static /*0x7244f48*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x7245464*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x7248524*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x72484d4*/ JsonReaderException();
            /*0x72484d8*/ JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x72484dc*/ JsonReaderException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
        }

        class JsonRequiredAttribute : System.Attribute
        {
            /*0x7248728*/ JsonRequiredAttribute();
        }

        class JsonSerializationException : Newtonsoft.Json.JsonException
        {
            /*0x8c*/ int <LineNumber>k__BackingField;
            /*0x90*/ int <LinePosition>k__BackingField;
            /*0x98*/ string <Path>k__BackingField;

            static /*0x724817c*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x7248788*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x724880c*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x7248730*/ JsonSerializationException();
            /*0x7248734*/ JsonSerializationException(string message);
            /*0x7248738*/ JsonSerializationException(string message, System.Exception innerException);
            /*0x724873c*/ JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7248740*/ JsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
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

            static /*0x7249424*/ Newtonsoft.Json.JsonSerializer Create();
            static /*0x7249474*/ Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x7249be0*/ Newtonsoft.Json.JsonSerializer CreateDefault();
            static /*0x7242f90*/ Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x72494a8*/ void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x724b2f4*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType);
            /*0x72492d8*/ JsonSerializer();
            /*0x7248a10*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x7248ac0*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x7248b70*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
            /*0x7248be8*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
            /*0x7248c60*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x7248c68*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
            /*0x7248c70*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
            /*0x7248c78*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x7248cd8*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
            /*0x7248d38*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
            /*0x7248d98*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x7248df8*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x7248e58*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x7248e60*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x7248ec0*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x7248f20*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x7248f80*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
            /*0x7248fe0*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x7248fe8*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
            /*0x7249048*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
            /*0x72490b4*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x72490bc*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
            /*0x724916c*/ System.Runtime.Serialization.StreamingContext get_Context();
            /*0x7249178*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
            /*0x7249188*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x72491c4*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x724922c*/ System.Nullable<int> get_MaxDepth();
            /*0x7249234*/ bool get_CheckAdditionalContent();
            /*0x7249270*/ void set_CheckAdditionalContent(bool value);
            /*0x7243788*/ bool IsCheckAdditionalContentSet();
            /*0x7249f6c*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
            /*0x7249f7c*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
            /*0x3910ae8*/ T Deserialize<T>(Newtonsoft.Json.JsonReader reader);
            /*0x72438c8*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x724a85c*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x724a1f4*/ void SetupReader(Newtonsoft.Json.JsonReader reader, ref System.Globalization.CultureInfo previousCulture, ref System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, ref System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, ref System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, ref System.Nullable<int> previousMaxDepth, ref string previousDateFormatString);
            /*0x724a640*/ void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<int> previousMaxDepth, string previousDateFormatString);
            /*0x72434b4*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x724aadc*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value);
            /*0x724a5b8*/ Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader);
            /*0x724aaf0*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x724b27c*/ Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver();
            /*0x724b2ec*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type);
            /*0x724b450*/ void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e);
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

            static /*0x724b588*/ JsonSerializerSettings();
            /*0x724b610*/ JsonSerializerSettings();
            /*0x7249d74*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x724b478*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x7249db0*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x7249dec*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x7249e28*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x7249e64*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x724b4e0*/ System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters();
            /*0x724b4e8*/ void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value);
            /*0x7249d38*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
            /*0x7249c84*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x724b4f0*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x7249cc0*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x7249cfc*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
            /*0x7249ea0*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
            /*0x724b558*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x724b560*/ System.Collections.IEqualityComparer get_EqualityComparer();
            /*0x724b568*/ System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider();
            /*0x724b570*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x724b578*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
            /*0x724b580*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error();
            /*0x7249edc*/ System.Runtime.Serialization.StreamingContext get_Context();
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

            static /*0x724c09c*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x72511d4*/ object BigIntegerParse(string number, System.Globalization.CultureInfo culture);
            /*0x72437c4*/ JsonTextReader(System.IO.TextReader reader);
            /*0x724b698*/ Newtonsoft.Json.JsonNameTable get_PropertyNameTable();
            /*0x724b6a0*/ void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value);
            /*0x724b6a8*/ void EnsureBufferNotEmpty();
            /*0x724b708*/ void SetNewLine(bool hasNextChar);
            /*0x724b768*/ void OnNewLine(int pos);
            /*0x724b778*/ void ParseString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x724bce0*/ void ParseReadString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x724b7c0*/ void ShiftBufferIfNeeded();
            /*0x724c0b0*/ int ReadData(bool append);
            /*0x724c14c*/ void PrepareBufferForReadData(bool append, int charsRequired);
            /*0x724c0bc*/ int ReadData(bool append, int charsRequired);
            /*0x724c308*/ bool EnsureChars(int relativePosition, bool append);
            /*0x724c328*/ bool ReadChars(int relativePosition, bool append);
            /*0x724c398*/ bool Read();
            /*0x724d24c*/ System.Nullable<int> ReadAsInt32();
            /*0x724d680*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x724dbb4*/ string ReadAsString();
            /*0x724dbe8*/ byte[] ReadAsBytes();
            /*0x724d710*/ object ReadStringValue(Newtonsoft.Json.ReadType readType);
            /*0x724e47c*/ object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType);
            /*0x724e214*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(char c);
            /*0x724e93c*/ System.Nullable<bool> ReadAsBoolean();
            /*0x724e1a8*/ void ProcessValueComma();
            /*0x724d2dc*/ object ReadNumberValue(Newtonsoft.Json.ReadType readType);
            /*0x724ee74*/ object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType);
            /*0x724effc*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x724f0c8*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x724f194*/ System.Nullable<double> ReadAsDouble();
            /*0x724e0d8*/ void HandleNull();
            /*0x724e334*/ void ReadFinished();
            /*0x724e088*/ bool ReadNullChar();
            /*0x724c5b4*/ void EnsureBuffer();
            /*0x724b874*/ void ReadStringIntoBuffer(char quote);
            /*0x724f384*/ void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition);
            /*0x724f334*/ void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition);
            /*0x724f428*/ char ConvertUnicode(bool enoughChars);
            /*0x724f2f4*/ char ParseUnicode();
            /*0x724f57c*/ void ReadNumberIntoBuffer();
            /*0x724f600*/ bool ReadNumberCharIntoBuffer(char currentChar, int charPos);
            /*0x724f754*/ void ClearRecentString();
            /*0x724cc18*/ bool ParsePostValue(bool ignoreComments);
            /*0x724ca9c*/ bool ParseObject();
            /*0x724f760*/ bool ParseProperty();
            /*0x724f98c*/ bool ValidIdentifierChar(char value);
            /*0x724f9e0*/ void ParseUnquotedProperty();
            /*0x724fae0*/ bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition);
            /*0x724c614*/ bool ParseValue();
            /*0x724e318*/ void ProcessLineFeed();
            /*0x724e2d0*/ void ProcessCarriageReturn(bool append);
            /*0x724cec8*/ void EatWhitespace();
            /*0x724fdc0*/ void ParseConstructor();
            /*0x724e738*/ void ParseNumber(Newtonsoft.Json.ReadType readType);
            /*0x725019c*/ void ParseReadNumber(Newtonsoft.Json.ReadType readType, char firstChar, int initialPosition);
            /*0x7251168*/ Newtonsoft.Json.JsonReaderException ThrowReaderError(string message, System.Exception ex);
            /*0x724cfbc*/ void ParseComment(bool setToken);
            /*0x725125c*/ void EndComment(bool setToken, int initialPosition, int endPosition);
            /*0x725129c*/ bool MatchValue(string value);
            /*0x72512f8*/ bool MatchValue(bool enoughChars, string value);
            /*0x724e7a0*/ bool MatchValueWithTrailingSeparator(string value);
            /*0x72513d8*/ bool IsSeparator(char c);
            /*0x724fc10*/ void ParseTrue();
            /*0x724f248*/ void ParseNull();
            /*0x72500f0*/ void ParseUndefined();
            /*0x724fce8*/ void ParseFalse();
            /*0x724e6bc*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType);
            /*0x7251510*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x724e844*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType);
            /*0x7251658*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x724e8c0*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType);
            /*0x72517a0*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x72518e8*/ void Close();
            /*0x7251968*/ bool HasLineInfo();
            /*0x7251970*/ int get_LineNumber();
            /*0x72519b8*/ int get_LinePosition();
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

            /*0x72432ec*/ JsonTextWriter(System.IO.TextWriter textWriter);
            /*0x72519c4*/ Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder();
            /*0x7251a48*/ char get_QuoteChar();
            /*0x7251af0*/ void Close();
            /*0x7251b24*/ void CloseBufferAndWriter();
            /*0x7251b88*/ void WriteStartObject();
            /*0x7251c00*/ void WriteStartArray();
            /*0x7251c38*/ void WriteStartConstructor(string name);
            /*0x7251ce0*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x7251dd4*/ void WritePropertyName(string name);
            /*0x7251f0c*/ void WritePropertyName(string name, bool escape);
            /*0x7251fdc*/ void OnStringEscapeHandlingChanged();
            /*0x7251a7c*/ void UpdateCharEscapeFlags();
            /*0x7251fe0*/ void WriteIndent();
            /*0x7252154*/ int SetIndentChars();
            /*0x725224c*/ void WriteValueDelimiter();
            /*0x7252274*/ void WriteIndentSpace();
            /*0x725229c*/ void WriteValueInternal(string value, Newtonsoft.Json.JsonToken token);
            /*0x72522c0*/ void WriteValue(object value);
            /*0x7252528*/ void WriteNull();
            /*0x72525bc*/ void WriteUndefined();
            /*0x7252650*/ void WriteRaw(string json);
            /*0x7252678*/ void WriteValue(string value);
            /*0x7251e50*/ void WriteEscapedString(string value, bool quote);
            /*0x7252778*/ void WriteValue(int value);
            /*0x7252808*/ void WriteValue(uint value);
            /*0x7252898*/ void WriteValue(long value);
            /*0x72528dc*/ void WriteValue(ulong value);
            /*0x7252994*/ void WriteValue(float value);
            /*0x7252a4c*/ void WriteValue(System.Nullable<float> value);
            /*0x7252b4c*/ void WriteValue(double value);
            /*0x7252c04*/ void WriteValue(System.Nullable<double> value);
            /*0x7252d10*/ void WriteValue(bool value);
            /*0x7252dac*/ void WriteValue(short value);
            /*0x7252df0*/ void WriteValue(ushort value);
            /*0x7252e34*/ void WriteValue(char value);
            /*0x7252ed0*/ void WriteValue(byte value);
            /*0x7252f14*/ void WriteValue(sbyte value);
            /*0x7252f58*/ void WriteValue(decimal value);
            /*0x7253004*/ void WriteValue(System.DateTime value);
            /*0x7253198*/ int WriteValueToBuffer(System.DateTime value);
            /*0x72532b0*/ void WriteValue(byte[] value);
            /*0x7253378*/ void WriteValue(System.DateTimeOffset value);
            /*0x72534e0*/ int WriteValueToBuffer(System.DateTimeOffset value);
            /*0x7253640*/ void WriteValue(System.Guid value);
            /*0x725374c*/ void WriteValue(System.TimeSpan value);
            /*0x7253870*/ void WriteValue(System.Uri value);
            /*0x7253940*/ void WriteComment(string text);
            /*0x725272c*/ void EnsureWriteBuffer();
            /*0x725284c*/ void WriteIntegerValue(long value);
            /*0x7252924*/ void WriteIntegerValue(ulong value, bool negative);
            /*0x7253a00*/ int WriteNumberToBuffer(ulong value, bool negative);
            /*0x72527bc*/ void WriteIntegerValue(int value);
            /*0x7253b74*/ void WriteIntegerValue(uint value, bool negative);
            /*0x7253acc*/ int WriteNumberToBuffer(uint value, bool negative);
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

            static /*0x7253e5c*/ JsonWriter();
            static /*0x7253be4*/ Newtonsoft.Json.JsonWriter.State[][] BuildStateArray();
            static /*0x725657c*/ void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value);
            static /*0x7257698*/ void ResolveConvertibleValue(System.IConvertible convertible, ref Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, ref object value);
            static /*0x72564c4*/ Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, object value);
            /*0x7251a50*/ JsonWriter();
            /*0x725417c*/ bool get_CloseOutput();
            /*0x7254184*/ void set_CloseOutput(bool value);
            /*0x7254190*/ bool get_AutoCompleteOnClose();
            /*0x7254198*/ void set_AutoCompleteOnClose(bool value);
            /*0x7252104*/ int get_Top();
            /*0x72541ac*/ Newtonsoft.Json.WriteState get_WriteState();
            /*0x725425c*/ string get_ContainerPath();
            /*0x72542f8*/ string get_Path();
            /*0x725440c*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x7243454*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x7254414*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0x724b08c*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0x725441c*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x724b0ec*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x7254424*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0x724b1ac*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0x725442c*/ void OnStringEscapeHandlingChanged();
            /*0x7254430*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0x724b14c*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0x7254438*/ string get_DateFormatString();
            /*0x7254440*/ void set_DateFormatString(string value);
            /*0x724b214*/ System.Globalization.CultureInfo get_Culture();
            /*0x7254448*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x7254450*/ void UpdateScopeWithFinishedValue();
            /*0x7254468*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x7254614*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x72541a4*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x7251b14*/ void Close();
            /*0x7254730*/ void WriteStartObject();
            /*0x725473c*/ void WriteEndObject();
            /*0x7254748*/ void WriteStartArray();
            /*0x7254754*/ void WriteEndArray();
            /*0x725475c*/ void WriteStartConstructor(string name);
            /*0x7254768*/ void WriteEndConstructor();
            /*0x7254770*/ void WritePropertyName(string name);
            /*0x7254790*/ void WritePropertyName(string name, bool escape);
            /*0x72547a0*/ void WriteEnd();
            /*0x7254878*/ void WriteToken(Newtonsoft.Json.JsonReader reader);
            /*0x7254880*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren);
            /*0x7254900*/ void WriteToken(Newtonsoft.Json.JsonToken token, object value);
            /*0x7254fa4*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            /*0x72552d4*/ bool IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, bool writeChildren, int initialDepth);
            /*0x72551a4*/ int CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader);
            /*0x7255340*/ int CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader);
            /*0x7255208*/ void WriteConstructorDate(Newtonsoft.Json.JsonReader reader);
            /*0x72547a8*/ void WriteEnd(Newtonsoft.Json.JsonContainerType type);
            /*0x72546f0*/ void AutoCompleteAll();
            /*0x72553a0*/ Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type);
            /*0x725543c*/ void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type);
            /*0x72554f8*/ int CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type);
            /*0x72555f0*/ void UpdateCurrentState();
            /*0x72556a4*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x72556a8*/ void WriteIndent();
            /*0x72556ac*/ void WriteValueDelimiter();
            /*0x72556b0*/ void WriteIndentSpace();
            /*0x72556b4*/ void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten);
            /*0x72558bc*/ void WriteNull();
            /*0x72558d8*/ void WriteUndefined();
            /*0x72558f4*/ void WriteRaw(string json);
            /*0x72558f8*/ void WriteRawValue(string json);
            /*0x7255948*/ void WriteValue(string value);
            /*0x7255964*/ void WriteValue(int value);
            /*0x7255980*/ void WriteValue(uint value);
            /*0x725599c*/ void WriteValue(long value);
            /*0x72559b8*/ void WriteValue(ulong value);
            /*0x72559d4*/ void WriteValue(float value);
            /*0x72559f0*/ void WriteValue(double value);
            /*0x7255a0c*/ void WriteValue(bool value);
            /*0x7255a28*/ void WriteValue(short value);
            /*0x7255a44*/ void WriteValue(ushort value);
            /*0x7255a60*/ void WriteValue(char value);
            /*0x7255a7c*/ void WriteValue(byte value);
            /*0x7255a98*/ void WriteValue(sbyte value);
            /*0x7255ab4*/ void WriteValue(decimal value);
            /*0x7255ad0*/ void WriteValue(System.DateTime value);
            /*0x7255aec*/ void WriteValue(System.DateTimeOffset value);
            /*0x7255b08*/ void WriteValue(System.Guid value);
            /*0x7255b24*/ void WriteValue(System.TimeSpan value);
            /*0x7255b40*/ void WriteValue(System.Nullable<int> value);
            /*0x7255bbc*/ void WriteValue(System.Nullable<uint> value);
            /*0x7255c38*/ void WriteValue(System.Nullable<long> value);
            /*0x7255cc4*/ void WriteValue(System.Nullable<ulong> value);
            /*0x7255d50*/ void WriteValue(System.Nullable<float> value);
            /*0x7255dd0*/ void WriteValue(System.Nullable<double> value);
            /*0x7255e5c*/ void WriteValue(System.Nullable<bool> value);
            /*0x7255ee0*/ void WriteValue(System.Nullable<short> value);
            /*0x7255f5c*/ void WriteValue(System.Nullable<ushort> value);
            /*0x7255fd8*/ void WriteValue(System.Nullable<char> value);
            /*0x7256054*/ void WriteValue(System.Nullable<byte> value);
            /*0x72560d0*/ void WriteValue(System.Nullable<sbyte> value);
            /*0x725614c*/ void WriteValue(System.Nullable<decimal> value);
            /*0x72561cc*/ void WriteValue(System.Nullable<System.DateTime> value);
            /*0x7256258*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
            /*0x72562d8*/ void WriteValue(System.Nullable<System.Guid> value);
            /*0x725635c*/ void WriteValue(System.Nullable<System.TimeSpan> value);
            /*0x72563e8*/ void WriteValue(byte[] value);
            /*0x7256418*/ void WriteValue(System.Uri value);
            /*0x72523f4*/ void WriteValue(object value);
            /*0x7257600*/ void WriteComment(string text);
            /*0x7257608*/ void System.IDisposable.Dispose();
            /*0x7257678*/ void Dispose(bool disposing);
            /*0x725781c*/ void SetWriteState(Newtonsoft.Json.JsonToken token, object value);
            /*0x7254744*/ void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container);
            /*0x7251e30*/ void InternalWritePropertyName(string name);
            /*0x7252674*/ void InternalWriteRaw();
            /*0x7251bc0*/ void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container);
            /*0x72523dc*/ void InternalWriteValue(Newtonsoft.Json.JsonToken token);
            /*0x72539f8*/ void InternalWriteComment();

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

            static /*0x72579e0*/ Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, string message, System.Exception ex);
            static /*0x7257a14*/ Newtonsoft.Json.JsonWriterException Create(string path, string message, System.Exception ex);
            /*0x725799c*/ JsonWriterException();
            /*0x72579a4*/ JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x72579ac*/ JsonWriterException(string message, string path, System.Exception innerException);
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

                /*0x7257ad4*/ Base64Encoder(System.IO.TextWriter writer);
                /*0x7257bc0*/ void ValidateEncode(byte[] buffer, int index, int count);
                /*0x7257c84*/ void Encode(byte[] buffer, int index, int count);
                /*0x7257ee4*/ void StoreLeftOverBytes(byte[] buffer, int index, ref int count);
                /*0x7257e24*/ bool FulfillFromLeftover(byte[] buffer, int index, ref int count);
                /*0x7258000*/ void Flush();
                /*0x7257ec0*/ void WriteChars(char[] chars, int index, int count);
            }

            class BidirectionalDictionary<TFirst, TSecond>
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TFirst, TSecond> _firstToSecond;
                /*0x0*/ System.Collections.Generic.IDictionary<TSecond, TFirst> _secondToFirst;
                /*0x0*/ string _duplicateFirstErrorMessage;
                /*0x0*/ string _duplicateSecondErrorMessage;

                /*0x3816958*/ BidirectionalDictionary(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage);
                /*0x3910ae8*/ void Set(TFirst first, TSecond second);
                /*0x3910ae8*/ bool TryGetByFirst(TFirst first, ref TSecond second);
                /*0x3910ae8*/ bool TryGetBySecond(TSecond second, ref TFirst first);
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

                static /*0x7258718*/ BoxedPrimitives();
                static /*0x72580b8*/ object Get(bool value);
                static /*0x7258120*/ object Get(int value);
                static /*0x7258324*/ object Get(long value);
                static /*0x7258534*/ object Get(decimal value);
                static /*0x725861c*/ object Get(double value);
            }

            class CollectionUtils
            {
                static /*0x3823ae0*/ bool IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection);
                static /*0x3843dfc*/ void AddRange<T>(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection);
                static /*0x7258c40*/ bool IsDictionaryType(System.Type type);
                static /*0x7258e3c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType);
                static /*0x7258f4c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType);
                static /*0x3830044*/ int IndexOf<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, bool> predicate);
                static /*0x3910ae8*/ bool Contains<T>(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer);
                static /*0x3910ae8*/ int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
                static /*0x3840c74*/ void FastReverse<T>(System.Collections.Generic.List<T> list);
                static /*0x7259274*/ System.Collections.Generic.IList<int> GetDimensions(System.Collections.IList values, int dimensionsCount);
                static /*0x7259528*/ void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, int[] indices);
                static /*0x72597e4*/ object JaggedArrayGetValue(System.Collections.IList values, int[] indices);
                static /*0x7259920*/ System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, int rank);
                static /*0x3836db8*/ T[] ArrayEmpty<T>();

                class EmptyArrayContainer<T>
                {
                    static /*0x0*/ T[] Empty;

                    static /*0x383e7a0*/ EmptyArrayContainer();
                }
            }

            interface IWrappedCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x38148bc*/ object get_UnderlyingCollection();
            }

            class CollectionWrapper<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedCollection, System.Collections.IList, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IList _list;
                /*0x0*/ System.Collections.Generic.ICollection<T> _genericCollection;
                /*0x0*/ object _syncRoot;

                static /*0x3840c74*/ void VerifyValueType(object value);
                static /*0x3823ae0*/ bool IsCompatibleObject(object value);
                /*0x3910ae8*/ void Add(T item);
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ bool Contains(T item);
                /*0x381678c*/ void CopyTo(T[] array, int arrayIndex);
                /*0x3814574*/ int get_Count();
                /*0x3813ffc*/ bool get_IsReadOnly();
                /*0x3910ae8*/ bool Remove(T item);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x381467c*/ int System.Collections.IList.Add(object value);
                /*0x38141c4*/ bool System.Collections.IList.Contains(object value);
                /*0x381467c*/ int System.Collections.IList.IndexOf(object value);
                /*0x3815ed0*/ void System.Collections.IList.RemoveAt(int index);
                /*0x3816044*/ void System.Collections.IList.Insert(int index, object value);
                /*0x3813ffc*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x3816710*/ void System.Collections.IList.Remove(object value);
                /*0x3814964*/ object System.Collections.IList.get_Item(int index);
                /*0x3816044*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x38148bc*/ object get_UnderlyingCollection();
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

                /*0x7259b0c*/ TypeInformation(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode);
                /*0x7259afc*/ System.Type get_Type();
                /*0x7259b04*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
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

                static /*0x725ccd8*/ ConvertUtils();
                static /*0x7259b48*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t);
                static /*0x7259bb0*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, ref bool isEnum);
                static /*0x7259f24*/ Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable);
                static /*0x725a010*/ bool IsConvertible(System.Type t);
                static /*0x725a090*/ System.TimeSpan ParseTimeSpan(string input);
                static /*0x725a120*/ System.Func<object, object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type> t);
                static /*0x725a384*/ System.Numerics.BigInteger ToBigInteger(object value);
                static /*0x725a724*/ object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType);
                static /*0x725ab94*/ object Convert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x725b8c8*/ bool TryConvert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x725adf0*/ Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x725bd74*/ object ConvertOrCast(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x725bb24*/ object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType);
                static /*0x725ba80*/ bool VersionTryParse(string input, ref System.Version result);
                static /*0x725b9f0*/ bool IsInteger(object value);
                static /*0x725bee4*/ Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, ref int value);
                static /*0x725c060*/ Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, ref long value);
                static /*0x725c1d0*/ Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, ref decimal value);
                static /*0x725cbac*/ bool TryConvertGuid(string s, ref System.Guid g);
                static /*0x725cc08*/ bool TryHexTextToInt(char[] text, int start, int end, ref int value);

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

                    /*0x725a37c*/ <>c__DisplayClass8_0();
                    /*0x725de90*/ object <CreateCastConverter>b__0(object o);
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

                static /*0x725df50*/ DateTimeParser();
                /*0x725e1d4*/ bool Parse(char[] text, int startIndex, int length);
                /*0x725e2d4*/ bool ParseDate(int start);
                /*0x725e4c8*/ bool ParseTimeAndZoneAndWhitespace(int start);
                /*0x725e6f0*/ bool ParseTime(ref int start);
                /*0x725e9cc*/ bool ParseZone(int start);
                /*0x725e564*/ bool Parse4Digit(int start, ref int num);
                /*0x725e654*/ bool Parse2Digit(int start, ref int num);
                /*0x725e47c*/ bool ParseChar(int start, char ch);
            }

            class DateTimeUtils
            {
                static /*0x0*/ long InitialJavaScriptDateTicks;
                static /*0x8*/ int[] DaysToMonth365;
                static /*0x10*/ int[] DaysToMonth366;

                static /*0x725ebd4*/ DateTimeUtils();
                static /*0x725eccc*/ System.TimeSpan GetUtcOffset(System.DateTime d);
                static /*0x725ed34*/ System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind);
                static /*0x725eeac*/ System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone);
                static /*0x725effc*/ System.DateTime SwitchToLocalTime(System.DateTime value);
                static /*0x725f0d4*/ System.DateTime SwitchToUtcTime(System.DateTime value);
                static /*0x725f1ac*/ long ToUniversalTicks(System.DateTime dateTime);
                static /*0x725f26c*/ long ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x725f3c8*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x725f4ac*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime);
                static /*0x725f504*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, bool convertToUtc);
                static /*0x725f430*/ long UniversalTicksToJavaScriptTicks(long universalTicks);
                static /*0x725f5c0*/ System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks);
                static /*0x725f648*/ bool TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x725fb88*/ bool TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x725fa8c*/ System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser);
                static /*0x725fe14*/ bool TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x726045c*/ bool TryParseDateTime(string s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x7260748*/ bool TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x7260b64*/ bool TryParseDateTimeOffset(string s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x7260e2c*/ bool TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, ref long ticks, ref System.TimeSpan offset, ref System.DateTimeKind kind);
                static /*0x72601ec*/ bool TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x7260374*/ bool TryParseDateTimeExact(string text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x7260954*/ bool TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x7260ab8*/ bool TryParseDateTimeOffsetExact(string text, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x7261024*/ bool TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, int startIndex, ref System.TimeSpan offset);
                static /*0x72611a8*/ void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x7261320*/ int WriteDateTimeString(char[] chars, int start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format);
                static /*0x72617ec*/ int WriteDefaultIsoDate(char[] chars, int start, System.DateTime dt);
                static /*0x7261e48*/ void CopyIntToCharArray(char[] chars, int start, int value, int digits);
                static /*0x7261634*/ int WriteDateTimeOffset(char[] chars, int start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format);
                static /*0x7261eb0*/ void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x7261c18*/ void GetDateValues(System.DateTime td, ref int year, ref int month, ref int day);
            }

            interface IWrappedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x38148bc*/ object get_UnderlyingDictionary();
            }

            class DictionaryWrapper<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedDictionary, System.Collections.IDictionary, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IDictionary _dictionary;
                /*0x0*/ System.Collections.Generic.IDictionary<TKey, TValue> _genericDictionary;
                /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;
                /*0x0*/ object _syncRoot;

                /*0x38148bc*/ System.Collections.Generic.IDictionary<TKey, TValue> get_GenericDictionary();
                /*0x3910ae8*/ void Add(TKey key, TValue value);
                /*0x3910ae8*/ bool ContainsKey(TKey key);
                /*0x38148bc*/ System.Collections.Generic.ICollection<TKey> get_Keys();
                /*0x3910ae8*/ bool Remove(TKey key);
                /*0x3910ae8*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x38148bc*/ System.Collections.Generic.ICollection<TValue> get_Values();
                /*0x3910ae8*/ TValue get_Item(TKey key);
                /*0x3910ae8*/ void set_Item(TKey key, TValue value);
                /*0x3910ae8*/ void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x381678c*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x3814574*/ int get_Count();
                /*0x3813ffc*/ bool get_IsReadOnly();
                /*0x3910ae8*/ bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3816810*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x3814a3c*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x3816810*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x38148bc*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x38141c4*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x3813ffc*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x38148bc*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x3816710*/ void Remove(object key);
                /*0x38148bc*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x38148bc*/ object get_UnderlyingDictionary();

                struct DictionaryEnumerator`2<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    /*0x3816710*/ DictionaryEnumerator`2(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    System.Collections.DictionaryEntry get_Entry();
                    /*0x38148bc*/ object get_Key();
                    /*0x38148bc*/ object get_Value();
                    /*0x38148bc*/ object get_Current();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.DictionaryEntry, System.Collections.Generic.KeyValuePair<TKey, TValue>> <>9__29_0;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x3910ae8*/ System.Collections.Generic.KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(System.Collections.DictionaryEntry de);
                }
            }

            class DynamicProxy<T>
            {
                /*0x38159dc*/ DynamicProxy();
                /*0x3910ae8*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(T instance);
                /*0x3910ae8*/ bool TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
                /*0x3910ae8*/ bool TryConvert(T instance, System.Dynamic.ConvertBinder binder, ref object result);
                /*0x3910ae8*/ bool TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, object[] args, ref object result);
                /*0x3910ae8*/ bool TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, object[] indexes);
                /*0x3910ae8*/ bool TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder);
                /*0x3910ae8*/ bool TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, object[] indexes, ref object result);
                /*0x3910ae8*/ bool TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, ref object result);
                /*0x3910ae8*/ bool TryInvoke(T instance, System.Dynamic.InvokeBinder binder, object[] args, ref object result);
                /*0x3910ae8*/ bool TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, object[] args, ref object result);
                /*0x3910ae8*/ bool TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, object[] indexes, object value);
                /*0x3910ae8*/ bool TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, object value);
                /*0x3910ae8*/ bool TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, ref object result);
            }

            class DynamicProxyMetaObject<T> : System.Dynamic.DynamicMetaObject
            {
                /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;

                static /*0x3836db8*/ System.Linq.Expressions.Expression[] get_NoArgs();
                static /*0x38379c4*/ System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args);
                static /*0x38379c4*/ System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args);
                static /*0x38395d4*/ System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value);
                static /*0x38379c4*/ System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder);
                /*0x3910ae8*/ DynamicProxyMetaObject(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy);
                /*0x38141c4*/ bool IsOverridden(string method);
                /*0x3814a3c*/ System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value);
                /*0x3814a3c*/ System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder);
                /*0x3814a3c*/ System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg);
                /*0x3814a3c*/ System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                /*0x3814c14*/ System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value);
                /*0x3814b90*/ System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                /*0x3814c8c*/ System.Dynamic.DynamicMetaObject CallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                /*0x3814c8c*/ System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                /*0x3814c50*/ System.Dynamic.DynamicMetaObject CallMethodReturnLast(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                /*0x3814c50*/ System.Dynamic.DynamicMetaObject CallMethodNoResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                /*0x38148bc*/ System.Dynamic.BindingRestrictions GetRestrictions();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames();

                class Fallback<T> : System.MulticastDelegate
                {
                    Fallback(object object, nint method);
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion);
                }

                class GetBinderAdapter<T> : System.Dynamic.GetMemberBinder
                {
                    /*0x3816710*/ GetBinderAdapter(System.Dynamic.InvokeMemberBinder binder);
                    /*0x3814b90*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
                }

                class <>c<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Dynamic.DynamicMetaObject, System.Linq.Expressions.Expression> <>9__18_0;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x3814a3c*/ System.Linq.Expressions.Expression <GetArgs>b__18_0(System.Dynamic.DynamicMetaObject arg);
                }

                class <>c__DisplayClass10_0<T>
                {
                    /*0x0*/ System.Dynamic.BinaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject arg;

                    /*0x38159dc*/ <>c__DisplayClass10_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindBinaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass11_0<T>
                {
                    /*0x0*/ System.Dynamic.UnaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x38159dc*/ <>c__DisplayClass11_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindUnaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass12_0<T>
                {
                    /*0x0*/ System.Dynamic.GetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    /*0x38159dc*/ <>c__DisplayClass12_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindGetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass13_0<T>
                {
                    /*0x0*/ System.Dynamic.SetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    /*0x38159dc*/ <>c__DisplayClass13_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindSetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass14_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    /*0x38159dc*/ <>c__DisplayClass14_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindDeleteIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass3_0<T>
                {
                    /*0x0*/ System.Dynamic.GetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x38159dc*/ <>c__DisplayClass3_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindGetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Dynamic.SetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    /*0x38159dc*/ <>c__DisplayClass4_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindSetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x38159dc*/ <>c__DisplayClass5_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindDeleteMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Dynamic.ConvertBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    /*0x38159dc*/ <>c__DisplayClass6_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindConvert>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x38159dc*/ <>c__DisplayClass7_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindInvokeMember>b__0(System.Dynamic.DynamicMetaObject e);
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindInvokeMember>b__1(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Dynamic.CreateInstanceBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x38159dc*/ <>c__DisplayClass8_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindCreateInstance>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    /*0x38159dc*/ <>c__DisplayClass9_0();
                    /*0x3814a3c*/ System.Dynamic.DynamicMetaObject <BindInvoke>b__0(System.Dynamic.DynamicMetaObject e);
                }
            }

            class DynamicUtils
            {
                static /*0x726206c*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider);

                class BinderWrapper
                {
                    static /*0x0*/ object _getCSharpArgumentInfoArray;
                    static /*0x8*/ object _setCSharpArgumentInfoArray;
                    static /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _getMemberCall;
                    static /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _setMemberCall;
                    static /*0x20*/ bool _init;

                    static /*0x7262154*/ void Init();
                    static /*0x7262338*/ object CreateSharpArgumentInfoArray(int[] values);
                    static /*0x72625f8*/ void CreateMemberCalls();
                    static /*0x7262b20*/ System.Runtime.CompilerServices.CallSiteBinder GetMember(string name, System.Type context);
                    static /*0x7262d18*/ System.Runtime.CompilerServices.CallSiteBinder SetMember(string name, System.Type context);
                }
            }

            class NoThrowGetBinderMember : System.Dynamic.GetMemberBinder
            {
                /*0x28*/ System.Dynamic.GetMemberBinder _innerBinder;

                /*0x7262f10*/ NoThrowGetBinderMember(System.Dynamic.GetMemberBinder innerBinder);
                /*0x7262f50*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowSetBinderMember : System.Dynamic.SetMemberBinder
            {
                /*0x28*/ System.Dynamic.SetMemberBinder _innerBinder;

                /*0x72630a0*/ NoThrowSetBinderMember(System.Dynamic.SetMemberBinder innerBinder);
                /*0x72630e0*/ System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
            {
                static /*0x0*/ object ErrorResult;

                static /*0x7263320*/ NoThrowExpressionVisitor();
                /*0x7263098*/ NoThrowExpressionVisitor();
                /*0x7263234*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node);
            }

            class EnumInfo
            {
                /*0x10*/ bool IsFlags;
                /*0x18*/ ulong[] Values;
                /*0x20*/ string[] Names;
                /*0x28*/ string[] ResolvedNames;

                /*0x726339c*/ EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames);
            }

            class EnumUtils
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy>, Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;
                static /*0x8*/ Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;

                static /*0x72648b8*/ EnumUtils();
                static /*0x7263404*/ Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy> key);
                static /*0x7263b9c*/ bool TryToString(System.Type enumType, object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, ref string name);
                static /*0x7263d3c*/ string InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, ulong result);
                static /*0x7263ed4*/ Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType);
                static /*0x72638d8*/ ulong ToUInt64(object value);
                static /*0x7263f90*/ object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, string value, bool disallowNumber);
                static /*0x72647d4*/ System.Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, System.StringComparison comparison);
                static /*0x72646e4*/ System.Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, System.StringComparison comparison);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.EnumUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Runtime.Serialization.EnumMemberAttribute, string> <>9__3_0;

                    static /*0x72649e4*/ <>c();
                    /*0x7264a4c*/ <>c();
                    /*0x7264a54*/ string <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a);
                }
            }

            class FSharpFunction
            {
                /*0x10*/ object _instance;
                /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _invoker;

                /*0x7264a6c*/ FSharpFunction(object instance, Newtonsoft.Json.Utilities.MethodCall<object, object> invoker);
                /*0x7264ab0*/ object Invoke(object[] args);
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

                static /*0x72657c0*/ FSharpUtils();
                static /*0x72652a8*/ Newtonsoft.Json.Utilities.FSharpUtils get_Instance();
                static /*0x7265398*/ void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly);
                static /*0x7265038*/ System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, System.Reflection.BindingFlags bindingFlags);
                static /*0x72650ac*/ Newtonsoft.Json.Utilities.MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName);
                /*0x7264adc*/ FSharpUtils(System.Reflection.Assembly fsharpCoreAssembly);
                /*0x7265300*/ void set_FSharpCoreAssembly(System.Reflection.Assembly value);
                /*0x7265308*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_IsUnion();
                /*0x7265310*/ void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x7265318*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCases();
                /*0x7265320*/ void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x7265328*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionTagReader();
                /*0x7265330*/ void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x7265338*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionReader();
                /*0x7265340*/ void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x7265348*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionConstructor();
                /*0x7265350*/ void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x7265358*/ System.Func<object, object> get_GetUnionCaseInfoDeclaringType();
                /*0x7265360*/ void set_GetUnionCaseInfoDeclaringType(System.Func<object, object> value);
                /*0x7265368*/ System.Func<object, object> get_GetUnionCaseInfoName();
                /*0x7265370*/ void set_GetUnionCaseInfoName(System.Func<object, object> value);
                /*0x7265378*/ System.Func<object, object> get_GetUnionCaseInfoTag();
                /*0x7265380*/ void set_GetUnionCaseInfoTag(System.Func<object, object> value);
                /*0x7265388*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCaseInfoFields();
                /*0x7265390*/ void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x726550c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateSeq(System.Type t);
                /*0x7265614*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType);
                /*0x38148bc*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> BuildMapCreator<TKey, TValue>();

                class <>c__55<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Tuple<TKey, TValue>> <>9__55_1;

                    static /*0x383e7a0*/ <>c__55();
                    /*0x38159dc*/ <>c__55();
                    /*0x3910ae8*/ System.Tuple<TKey, TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey, TValue> kv);
                }

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;
                    /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> invoke;

                    /*0x7265504*/ <>c__DisplayClass52_0();
                    /*0x726583c*/ object <CreateFSharpFuncCall>b__0(object target, object[] args);
                }

                class <>c__DisplayClass55_0<TKey, TValue>
                {
                    /*0x0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> ctorDelegate;

                    /*0x38159dc*/ <>c__DisplayClass55_0();
                    /*0x3814a3c*/ object <BuildMapCreator>b__0(object[] args);
                }
            }

            class ImmutableCollectionsUtils
            {
                static /*0x0*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;
                static /*0x8*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

                static /*0x72662cc*/ ImmutableCollectionsUtils();
                static /*0x72658d8*/ bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);
                static /*0x7265dbc*/ bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);

                class ImmutableCollectionTypeInfo
                {
                    /*0x10*/ string <ContractTypeName>k__BackingField;
                    /*0x18*/ string <CreatedTypeName>k__BackingField;
                    /*0x20*/ string <BuilderTypeName>k__BackingField;

                    /*0x7266b94*/ ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName);
                    /*0x7266bf4*/ string get_ContractTypeName();
                    /*0x7266bfc*/ void set_ContractTypeName(string value);
                    /*0x7266c04*/ string get_CreatedTypeName();
                    /*0x7266c0c*/ void set_CreatedTypeName(string value);
                    /*0x7266c14*/ string get_BuilderTypeName();
                    /*0x7266c1c*/ void set_BuilderTypeName(string value);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__24_1;
                    static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__25_1;

                    static /*0x7266c24*/ <>c();
                    /*0x7266c8c*/ <>c();
                    /*0x7266c94*/ bool <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m);
                    /*0x7266d28*/ bool <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string name;

                    /*0x7265d94*/ <>c__DisplayClass24_0();
                    /*0x7266e78*/ bool <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ string name;

                    /*0x72662c4*/ <>c__DisplayClass25_0();
                    /*0x7266e9c*/ bool <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }
            }

            class BufferUtils
            {
                static /*0x7266ec0*/ char[] RentBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int minSize);
                static /*0x7266f88*/ void ReturnBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer);
                static /*0x7267038*/ char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int size, char[] buffer);
            }

            class JavaScriptUtils
            {
                static /*0x0*/ bool[] SingleQuoteCharEscapeFlags;
                static /*0x8*/ bool[] DoubleQuoteCharEscapeFlags;
                static /*0x10*/ bool[] HtmlCharEscapeFlags;

                static /*0x7267174*/ JavaScriptUtils();
                static /*0x7267de4*/ bool[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, char quoteChar);
                static /*0x7267e7c*/ bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags);
                static /*0x7267f04*/ void WriteEscapedJavaScriptString(System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<char> bufferPool, ref char[] writeBuffer);
                static /*0x726865c*/ string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x72684ec*/ int FirstCharToEscape(string s, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x726894c*/ bool TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, ref System.DateTime dateTime, ref string errorMessage);
                static /*0x7268db0*/ bool TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, ref System.Nullable<long> integer, ref string errorMessage);
            }

            class JsonTokenUtils
            {
                static /*0x7268f64*/ bool IsEndToken(Newtonsoft.Json.JsonToken token);
                static /*0x7268f74*/ bool IsStartToken(Newtonsoft.Json.JsonToken token);
                static /*0x7268f84*/ bool IsPrimitiveToken(Newtonsoft.Json.JsonToken token);
            }

            class LateBoundReflectionDelegateFactory : Newtonsoft.Json.Utilities.ReflectionDelegateFactory
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

                static /*0x72691bc*/ LateBoundReflectionDelegateFactory();
                static /*0x7268fa8*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance();
                /*0x72691ac*/ LateBoundReflectionDelegateFactory();
                /*0x7269000*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                /*0x3814a3c*/ Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                /*0x3814a3c*/ System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                /*0x3814a3c*/ System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                /*0x3814a3c*/ System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x3814a3c*/ System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x3814a3c*/ System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.Reflection.ConstructorInfo c;
                    /*0x18*/ System.Reflection.MethodBase method;

                    /*0x72691a4*/ <>c__DisplayClass3_0();
                    /*0x7269224*/ object <CreateParameterizedConstructor>b__0(object[] a);
                    /*0x7269240*/ object <CreateParameterizedConstructor>b__1(object[] a);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Reflection.ConstructorInfo c;
                    /*0x0*/ System.Reflection.MethodBase method;

                    /*0x38159dc*/ <>c__DisplayClass4_0();
                    /*0x3910ae8*/ object <CreateMethodCall>b__0(T o, object[] a);
                    /*0x3910ae8*/ object <CreateMethodCall>b__1(T o, object[] a);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Type type;
                    /*0x0*/ System.Reflection.ConstructorInfo constructorInfo;

                    /*0x38159dc*/ <>c__DisplayClass5_0();
                    /*0x3910ae8*/ T <CreateDefaultConstructor>b__0();
                    /*0x3910ae8*/ T <CreateDefaultConstructor>b__1();
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x38159dc*/ <>c__DisplayClass6_0();
                    /*0x3910ae8*/ object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x38159dc*/ <>c__DisplayClass7_0();
                    /*0x3910ae8*/ object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x38159dc*/ <>c__DisplayClass8_0();
                    /*0x3910ae8*/ void <CreateSet>b__0(T o, object v);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x38159dc*/ <>c__DisplayClass9_0();
                    /*0x3910ae8*/ void <CreateSet>b__0(T o, object v);
                }
            }

            class MathUtils
            {
                static /*0x7269264*/ int IntLength(ulong i);
                static /*0x7269428*/ char IntToHex(int n);
                static /*0x7269440*/ bool ApproxEquals(double d1, double d2);
            }

            class MethodCall<T, TResult> : System.MulticastDelegate
            {
                MethodCall(object object, nint method);
                /*0x3910ae8*/ TResult Invoke(T target, object[] args);
            }

            class MiscellaneousUtils
            {
                static /*0x72694e0*/ bool ValueEquals(object objA, object objB);
                static /*0x725edb4*/ System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message);
                static /*0x72697c4*/ string ToString(object value);
                static /*0x7269868*/ int ByteArrayCompare(byte[] a1, byte[] a2);
                static /*0x726991c*/ string GetPrefix(string qualifiedName);
                static /*0x72699fc*/ string GetLocalName(string qualifiedName);
                static /*0x7269940*/ void GetQualifiedNameParts(string qualifiedName, ref string prefix, ref string localName);
                static /*0x7269a34*/ System.Text.RegularExpressions.RegexOptions GetRegexOptions(string optionsText);
            }

            class ReflectionDelegateFactory
            {
                /*0x72691b4*/ ReflectionDelegateFactory();
                /*0x3814a3c*/ System.Func<T, object> CreateGet<T>(System.Reflection.MemberInfo memberInfo);
                /*0x3814a3c*/ System.Action<T, object> CreateSet<T>(System.Reflection.MemberInfo memberInfo);
                /*0x3814a3c*/ Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                /*0x3814a3c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                /*0x3814a3c*/ System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                /*0x3814a3c*/ System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                /*0x3814a3c*/ System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x3814a3c*/ System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                /*0x3814a3c*/ System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);
            }

            class ReflectionMember
            {
                /*0x10*/ System.Type <MemberType>k__BackingField;
                /*0x18*/ System.Func<object, object> <Getter>k__BackingField;
                /*0x20*/ System.Action<object, object> <Setter>k__BackingField;

                /*0x7269b0c*/ ReflectionMember();
                /*0x7269adc*/ System.Type get_MemberType();
                /*0x7269ae4*/ void set_MemberType(System.Type value);
                /*0x7269aec*/ System.Func<object, object> get_Getter();
                /*0x7269af4*/ void set_Getter(System.Func<object, object> value);
                /*0x7269afc*/ System.Action<object, object> get_Setter();
                /*0x7269b04*/ void set_Setter(System.Action<object, object> value);
            }

            class ReflectionObject
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <Creator>k__BackingField;
                /*0x18*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;

                static /*0x7269e24*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, string[] memberNames);
                static /*0x7269e30*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, string[] memberNames);
                /*0x7269b24*/ ReflectionObject(Newtonsoft.Json.Serialization.ObjectConstructor<object> creator);
                /*0x7269b14*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_Creator();
                /*0x7269b1c*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> get_Members();
                /*0x7269bc0*/ object GetValue(object target, string member);
                /*0x7269c94*/ void SetValue(object target, string member, object value);
                /*0x7269d70*/ System.Type GetType(string member);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ System.Func<object> ctor;

                    /*0x726a764*/ <>c__DisplayClass11_0();
                    /*0x726ac88*/ object <Create>b__0(object[] args);
                }

                class <>c__DisplayClass11_1
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x726aa58*/ <>c__DisplayClass11_1();
                    /*0x726acac*/ object <Create>b__1(object target);
                }

                class <>c__DisplayClass11_2
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x726aa60*/ <>c__DisplayClass11_2();
                    /*0x726ad64*/ void <Create>b__2(object target, object arg);
                }
            }

            class ReflectionUtils
            {
                static /*0x0*/ System.Type[] EmptyTypes;

                static /*0x726ae28*/ ReflectionUtils();
                static /*0x726ae9c*/ bool IsVirtual(System.Reflection.PropertyInfo propertyInfo);
                static /*0x726af7c*/ System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo);
                static /*0x726b040*/ bool IsPublic(System.Reflection.PropertyInfo property);
                static /*0x725bed4*/ System.Type GetObjectType(object v);
                static /*0x726b0d0*/ string GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x726b1a8*/ string GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x726b2d8*/ string RemoveAssemblyDetails(string fullyQualifiedTypeName);
                static /*0x726a678*/ bool HasDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x726b5b4*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t);
                static /*0x726b480*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x725ba88*/ bool IsNullable(System.Type t);
                static /*0x7259e44*/ bool IsNullableType(System.Type t);
                static /*0x726b60c*/ System.Type EnsureNotNullableType(System.Type t);
                static /*0x726b680*/ System.Type EnsureNotByRefType(System.Type t);
                static /*0x726b6d0*/ bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x7258dc8*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x726b758*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, ref System.Type implementingType);
                static /*0x726b9e0*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition);
                static /*0x726ba54*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x726bbbc*/ bool InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x726bcd8*/ System.Type GetCollectionItemType(System.Type type);
                static /*0x726beec*/ void GetDictionaryKeyValueTypes(System.Type dictionaryType, ref System.Type keyType, ref System.Type valueType);
                static /*0x726aa68*/ System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member);
                static /*0x726c128*/ bool IsByRefLikeType(System.Type type);
                static /*0x726c734*/ bool IsIndexedProperty(System.Reflection.PropertyInfo property);
                static /*0x726c7ac*/ object GetMemberValue(System.Reflection.MemberInfo member, object target);
                static /*0x726cab8*/ void SetMemberValue(System.Reflection.MemberInfo member, object target, object value);
                static /*0x726a788*/ bool CanReadMemberValue(System.Reflection.MemberInfo member, bool nonPublic);
                static /*0x726a8d4*/ bool CanSetMemberValue(System.Reflection.MemberInfo member, bool nonPublic, bool canSetReadOnly);
                static /*0x726ccc8*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x726db80*/ bool IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr);
                static /*0x3910ae8*/ T GetAttribute<T>(object attributeProvider);
                static /*0x3910ae8*/ T GetAttribute<T>(object attributeProvider, bool inherit);
                static /*0x3838ba0*/ T[] GetAttributes<T>(object attributeProvider, bool inherit);
                static /*0x726c230*/ System.Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit);
                static /*0x726dd4c*/ Newtonsoft.Json.Utilities.StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName);
                static /*0x726de40*/ System.Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName);
                static /*0x726e0a8*/ System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo);
                static /*0x726d76c*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x726e314*/ void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x726d884*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x726e4fc*/ System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag);
                static /*0x726e50c*/ void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x726eacc*/ bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method);
                static /*0x726ebe8*/ object GetDefaultValue(System.Type type);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__11_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__31_0;
                    static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__39_0;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, bool> <>9__41_0;

                    static /*0x726edf8*/ <>c();
                    /*0x726ee60*/ <>c();
                    /*0x726ee68*/ bool <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c);
                    /*0x726eed4*/ string <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m);
                    /*0x726eef8*/ System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p);
                    /*0x726ef1c*/ bool <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Reflection.MemberInfo memberInfo;

                    /*0x726db78*/ <>c__DisplayClass31_0();
                    /*0x726ef34*/ bool <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m);
                }

                class <>c__DisplayClass44_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo subTypeProperty;

                    /*0x726eabc*/ <>c__DisplayClass44_0();
                    /*0x726efb0*/ bool <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p);
                    /*0x726f004*/ bool <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass44_1
                {
                    /*0x10*/ System.Type subTypePropertyDeclaringType;
                    /*0x18*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> CS$<>8__locals1;

                    /*0x726eac4*/ <>c__DisplayClass44_1();
                    /*0x726f0d0*/ bool <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ string method;
                    /*0x18*/ System.Type methodDeclaringType;

                    /*0x726ebe0*/ <>c__DisplayClass45_0();
                    /*0x726f1dc*/ bool <IsMethodOverridden>b__0(System.Reflection.MethodInfo info);
                }
            }

            struct StringBuffer
            {
                /*0x10*/ char[] _buffer;
                /*0x18*/ int _position;

                /*0x726f2f0*/ StringBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int initalSize);
                /*0x726f320*/ StringBuffer(char[] buffer);
                /*0x726f2d0*/ int get_Position();
                /*0x726f2d8*/ void set_Position(int value);
                /*0x726f2e0*/ bool get_IsEmpty();
                /*0x726f33c*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char value);
                /*0x726f41c*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count);
                /*0x726f49c*/ void Clear(Newtonsoft.Json.IArrayPool<char> bufferPool);
                /*0x726f3b4*/ void EnsureSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int appendLength);
                /*0x726f4d4*/ string ToString();
                /*0x726f4ec*/ string ToString(int start, int length);
                /*0x726f508*/ char[] get_InternalBuffer();
            }

            struct StringReference
            {
                /*0x10*/ char[] _chars;
                /*0x18*/ int _startIndex;
                /*0x1c*/ int _length;

                /*0x726071c*/ StringReference(char[] chars, int startIndex, int length);
                /*0x7260038*/ char get_Item(int i);
                /*0x726f510*/ char[] get_Chars();
                /*0x726f518*/ int get_StartIndex();
                /*0x726f520*/ int get_Length();
                /*0x7260360*/ string ToString();
            }

            class StringReferenceExtensions
            {
                static /*0x7260fa0*/ int IndexOf(Newtonsoft.Json.Utilities.StringReference s, char c, int startIndex, int length);
                static /*0x7260068*/ bool StartsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
                static /*0x7260128*/ bool EndsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
            }

            class StringUtils
            {
                static /*0x7260358*/ bool IsNullOrEmpty(string value);
                static /*0x725a670*/ string FormatWith(string format, System.IFormatProvider provider, object arg0);
                static /*0x725b7d4*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1);
                static /*0x726f594*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2);
                static /*0x726f6c0*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2, object arg3);
                static /*0x726f528*/ string FormatWith(string format, System.IFormatProvider provider, object[] args);
                static /*0x7268884*/ System.IO.StringWriter CreateStringWriter(int capacity);
                static /*0x72685a0*/ void ToCharAsUnicode(char c, char[] buffer);
                static /*0x3910ae8*/ TSource ForgivingCaseSensitiveFind<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, string> valueSelector, string testValue);
                static /*0x726f82c*/ string ToCamelCase(string s);
                static /*0x726f9f0*/ char ToLower(char c);
                static /*0x726fa74*/ string ToSnakeCase(string s);
                static /*0x726fd58*/ string ToKebabCase(string s);
                static /*0x726fa7c*/ string ToSeparatedCase(string s, char separator);
                static /*0x726fd60*/ bool IsHighSurrogate(char c);
                static /*0x726fd94*/ bool IsLowSurrogate(char c);
                static /*0x7269a20*/ int IndexOf(string s, char c);
                static /*0x726fdc8*/ bool StartsWith(string source, char value);
                static /*0x726fe0c*/ bool EndsWith(string source, char value);
                static /*0x726df18*/ string Trim(string s, int start, int length);

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

                    /*0x38159dc*/ <>c__DisplayClass14_0();
                    /*0x3910ae8*/ bool <ForgivingCaseSensitiveFind>b__0(TSource s);
                    /*0x3910ae8*/ bool <ForgivingCaseSensitiveFind>b__1(TSource s);
                }
            }

            struct StructMultiKey<T1, T2> : System.IEquatable<Newtonsoft.Json.Utilities.StructMultiKey<T1, T2>>
            {
                /*0x0*/ T1 Value1;
                /*0x0*/ T2 Value2;

                /*0x3910ae8*/ StructMultiKey(T1 v1, T2 v2);
                /*0x3814574*/ int GetHashCode();
                /*0x38141c4*/ bool Equals(object obj);
                /*0x3910ae8*/ bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1, T2> other);
            }

            class ThreadSafeStore<TKey, TValue>
            {
                /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> _concurrentStore;
                /*0x0*/ System.Func<TKey, TValue> _creator;

                /*0x3816710*/ ThreadSafeStore(System.Func<TKey, TValue> creator);
                /*0x3910ae8*/ TValue Get(TKey key);
            }

            class TypeExtensions
            {
                static /*0x726a76c*/ System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo);
                static /*0x726fe4c*/ bool ContainsGenericParameters(System.Type type);
                static /*0x725bd2c*/ bool IsInterface(System.Type type);
                static /*0x7265d74*/ bool IsGenericType(System.Type type);
                static /*0x725bd40*/ bool IsGenericTypeDefinition(System.Type type);
                static /*0x726bcb8*/ System.Type BaseType(System.Type type);
                static /*0x7265d9c*/ System.Reflection.Assembly Assembly(System.Type type);
                static /*0x7259e24*/ bool IsEnum(System.Type type);
                static /*0x726bba8*/ bool IsClass(System.Type type);
                static /*0x726fe6c*/ bool IsSealed(System.Type type);
                static /*0x725bd60*/ bool IsAbstract(System.Type type);
                static /*0x726fe80*/ bool IsVisible(System.Type type);
                static /*0x726b46c*/ bool IsValueType(System.Type type);
                static /*0x726fe94*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces, ref System.Type match);
                static /*0x726fff8*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces);
                static /*0x7270018*/ bool ImplementInterface(System.Type type, System.Type interfaceType);
            }

            class ValidationUtils
            {
                static /*0x7257b74*/ void ArgumentNotNull(object value, string parameterName);
            }
        }

        namespace Serialization
        {
            class CachedAttributeGetter<T>
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<object, T> TypeAttributeCache;

                static /*0x383e7a0*/ CachedAttributeGetter();
                static /*0x3910ae8*/ T GetAttribute(object type);
            }

            class CamelCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x72703f8*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x7270430*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x72649dc*/ CamelCaseNamingStrategy();
                /*0x727047c*/ string ResolvePropertyName(string name);
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

                static /*0x727764c*/ DefaultContractResolver();
                static /*0x7270484*/ Newtonsoft.Json.Serialization.IContractResolver get_Instance();
                static /*0x72706b8*/ bool FilterMembers(System.Reflection.MemberInfo member);
                static /*0x7273140*/ void ThrowUnableToSerializeError(object o, System.Runtime.Serialization.StreamingContext context);
                static /*0x72728c8*/ void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member);
                static /*0x727529c*/ bool IsConcurrentOrObservableCollection(System.Type t);
                static /*0x7274b84*/ bool ShouldSkipDeserialized(System.Type t);
                static /*0x7274ab0*/ bool ShouldSkipSerializing(System.Type t);
                static /*0x7276638*/ bool IsJsonPrimitiveType(System.Type t);
                static /*0x7276790*/ bool IsIConvertible(System.Type t);
                static /*0x7276698*/ bool CanConvertToString(System.Type type);
                static /*0x7274c58*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                static /*0x72768fc*/ string GetClrTypeFullName(System.Type type);
                /*0x7270528*/ DefaultContractResolver();
                /*0x72704dc*/ System.Reflection.BindingFlags get_DefaultMembersSearchFlags();
                /*0x72704e4*/ void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value);
                /*0x72704ec*/ bool get_SerializeCompilerGeneratedMembers();
                /*0x72704f4*/ bool get_IgnoreSerializableInterface();
                /*0x72704fc*/ bool get_IgnoreSerializableAttribute();
                /*0x7270504*/ void set_IgnoreSerializableAttribute(bool value);
                /*0x7270510*/ bool get_IgnoreIsSpecifiedMembers();
                /*0x7270518*/ bool get_IgnoreShouldSerializeMembers();
                /*0x7270520*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x7270638*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
                /*0x72707fc*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType);
                /*0x7271594*/ bool ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo);
                /*0x727169c*/ Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType);
                /*0x72726fc*/ System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type);
                /*0x7271ef0*/ System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType);
                /*0x7272448*/ System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x7272400*/ System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType);
                /*0x72733e4*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x727336c*/ Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, string name, System.Type type);
                /*0x7273560*/ Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo);
                /*0x7273ecc*/ Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType);
                /*0x7273f24*/ System.Func<object> GetDefaultCreator(System.Type createdType);
                /*0x7271c8c*/ void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x7273fc4*/ void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t);
                /*0x7274104*/ void GetCallbackMethodsForType(System.Type type, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> onError);
                /*0x72731d4*/ System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type);
                /*0x72753e4*/ Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType);
                /*0x7275954*/ Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType);
                /*0x7275c90*/ Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType);
                /*0x7275d04*/ Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType);
                /*0x7275d78*/ Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType);
                /*0x7275fb4*/ Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType);
                /*0x72761cc*/ Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType);
                /*0x7276240*/ Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType);
                /*0x72769fc*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x7276e1c*/ Newtonsoft.Json.DefaultJsonNameTable GetNameTable();
                /*0x7276e24*/ Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member);
                /*0x7276e80*/ Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x7273814*/ void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, object attributeProvider, string name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, ref bool allowNonPublicAccess);
                /*0x7277098*/ System.Predicate<object> CreateShouldSerializeTest(System.Reflection.MemberInfo member);
                /*0x72772dc*/ void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, bool allowNonPublicAccess);
                /*0x72775d4*/ string ResolvePropertyName(string propertyName);
                /*0x72775f4*/ string ResolveExtensionDataName(string extensionDataName);
                /*0x7277610*/ string ResolveDictionaryKey(string dictionaryKey);
                /*0x727763c*/ string GetResolvedPropertyName(string propertyName);

                class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    /*0x3816710*/ EnumerableDictionaryWrapper(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class <GetEnumerator>d__<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ System.Collections.Generic.KeyValuePair<object, object> <>2__current;
                        /*0x0*/ Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;
                        /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;

                        /*0x3815ed0*/ <GetEnumerator>d__(int <>1__state);
                        /*0x38159dc*/ void System.IDisposable.Dispose();
                        /*0x3813ffc*/ bool MoveNext();
                        /*0x38159dc*/ void <>m__Finally1();
                        System.Collections.Generic.KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current();
                        /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                        /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
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

                    static /*0x7277b70*/ <>c();
                    /*0x7277bd8*/ <>c();
                    /*0x7277be0*/ bool <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m);
                    /*0x7277c94*/ bool <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m);
                    /*0x7277d04*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType);
                    /*0x7277de4*/ bool <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m);
                    /*0x72781a4*/ bool <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c);
                    /*0x7278228*/ int <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p);
                }

                class <>c__DisplayClass42_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x7278280*/ <>c__DisplayClass42_0();
                    /*0x7278288*/ string <CreateObjectContract>b__0(string s);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ System.Func<object, object> getExtensionDataDictionary;
                    /*0x18*/ System.Reflection.MemberInfo member;

                    /*0x72782a8*/ <>c__DisplayClass45_0();
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ System.Action<object, object> setExtensionDataDictionary;
                    /*0x18*/ System.Func<object> createExtensionDataDictionary;
                    /*0x20*/ Newtonsoft.Json.Utilities.MethodCall<object, object> setExtensionDataDictionaryValue;
                    /*0x28*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals1;

                    /*0x72782b0*/ <>c__DisplayClass45_1();
                    /*0x72782b8*/ void <SetExtensionDataDelegates>b__0(object o, string key, object value);
                }

                class <>c__DisplayClass45_2
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> createEnumerableWrapper;
                    /*0x18*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals2;

                    /*0x72784c4*/ <>c__DisplayClass45_2();
                    /*0x72784cc*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o);
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x72785e4*/ <>c__DisplayClass62_0();
                    /*0x72785ec*/ string <CreateDictionaryContract>b__0(string s);
                }

                class <>c__DisplayClass67_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x727860c*/ <>c__DisplayClass67_0();
                    /*0x7278614*/ string <CreateDynamicContract>b__0(string s);
                }

                class <>c__DisplayClass80_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> shouldSerializeCall;

                    /*0x7278634*/ <>c__DisplayClass80_0();
                    /*0x727863c*/ bool <CreateShouldSerializeTest>b__0(object o);
                }

                class <>c__DisplayClass81_0
                {
                    /*0x10*/ System.Func<object, object> specifiedPropertyGet;

                    /*0x7278728*/ <>c__DisplayClass81_0();
                    /*0x7278730*/ bool <SetIsSpecifiedActions>b__0(object o);
                }
            }

            class DefaultNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x7278790*/ DefaultNamingStrategy();
                /*0x7278788*/ string ResolvePropertyName(string name);
            }

            class DefaultReferenceResolver : Newtonsoft.Json.Serialization.IReferenceResolver
            {
                /*0x10*/ int _referenceCount;

                /*0x7278bfc*/ DefaultReferenceResolver();
                /*0x7278798*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> GetMappings(object context);
                /*0x72789b4*/ object ResolveReference(object context, string reference);
                /*0x7278a28*/ string GetReference(object context, object value);
                /*0x7278b1c*/ void AddReference(object context, string reference, object value);
                /*0x7278b88*/ bool IsReferenced(object context, object value);
            }

            class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder, Newtonsoft.Json.Serialization.ISerializationBinder
            {
                static /*0x0*/ Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
                /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<string, string>, System.Type> _typeCache;

                static /*0x72794d8*/ DefaultSerializationBinder();
                /*0x7278c04*/ DefaultSerializationBinder();
                /*0x7278cdc*/ System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x72790c4*/ System.Type GetGenericTypeFromTypeName(string typeName, System.Reflection.Assembly assembly);
                /*0x7279378*/ System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x72793e0*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x727945c*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            class ErrorContext
            {
                /*0x10*/ bool <Traced>k__BackingField;
                /*0x18*/ System.Exception <Error>k__BackingField;
                /*0x20*/ object <OriginalObject>k__BackingField;
                /*0x28*/ object <Member>k__BackingField;
                /*0x30*/ string <Path>k__BackingField;
                /*0x38*/ bool <Handled>k__BackingField;

                /*0x727953c*/ ErrorContext(object originalObject, object member, string path, System.Exception error);
                /*0x72795b0*/ bool get_Traced();
                /*0x72795b8*/ void set_Traced(bool value);
                /*0x72795c4*/ System.Exception get_Error();
                /*0x72795cc*/ bool get_Handled();
            }

            class ErrorEventArgs : System.EventArgs
            {
                /*0x10*/ object <CurrentObject>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;

                /*0x72795d4*/ ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            interface IAttributeProvider
            {
            }

            interface IContractResolver
            {
                /*0x3814a3c*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
            }

            interface IReferenceResolver
            {
                /*0x3814b90*/ object ResolveReference(object context, string reference);
                /*0x3814b90*/ string GetReference(object context, object value);
                /*0x3814200*/ bool IsReferenced(object context, object value);
                /*0x3816920*/ void AddReference(object context, string reference, object value);
            }

            interface ISerializationBinder
            {
                /*0x3814b90*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x3816920*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            interface ITraceWriter
            {
                /*0x3814574*/ System.Diagnostics.TraceLevel get_LevelFilter();
                void Trace(System.Diagnostics.TraceLevel level, string message, System.Exception ex);
            }

            interface IValueProvider
            {
                /*0x3816810*/ void SetValue(object target, object value);
                /*0x3814a3c*/ object GetValue(object target);
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

                /*0x727981c*/ JsonArrayContract(System.Type underlyingType);
                /*0x727965c*/ System.Type get_CollectionItemType();
                /*0x7279664*/ bool get_IsMultidimensionalArray();
                /*0x727966c*/ bool get_IsArray();
                /*0x7279674*/ bool get_ShouldCreateWrapper();
                /*0x727967c*/ bool get_CanDeserialize();
                /*0x7279684*/ void set_CanDeserialize(bool value);
                /*0x7279690*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x727975c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x7279764*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x7279788*/ bool get_HasParameterizedCreator();
                /*0x7279790*/ void set_HasParameterizedCreator(bool value);
                /*0x727979c*/ bool get_HasParameterizedCreatorInternal();
                /*0x727a8e8*/ Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(object list);
                /*0x727acf8*/ System.Collections.IList CreateTemporaryCollection();
                /*0x727a7c8*/ void StoreFSharpListCreatorIfNecessary(System.Type underlyingType);
            }

            class JsonContainerContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x90*/ Newtonsoft.Json.Serialization.JsonContract _itemContract;
                /*0x98*/ Newtonsoft.Json.Serialization.JsonContract _finalItemContract;
                /*0xa0*/ Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;
                /*0xa8*/ System.Nullable<bool> <ItemIsReference>k__BackingField;
                /*0xac*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;
                /*0xb4*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;

                /*0x727a604*/ JsonContainerContract(System.Type underlyingType);
                /*0x727af40*/ Newtonsoft.Json.Serialization.JsonContract get_ItemContract();
                /*0x727af48*/ void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x727afa8*/ Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract();
                /*0x727afb0*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x727afb8*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x727afc0*/ System.Nullable<bool> get_ItemIsReference();
                /*0x727afc8*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x727afd0*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x727afd8*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x727afe0*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x727afe8*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
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
                /*0x727b16c*/ SerializationCallback(object object, nint method);
                /*0x727b278*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context);
            }

            class SerializationErrorCallback : System.MulticastDelegate
            {
                /*0x727b28c*/ SerializationErrorCallback(object object, nint method);
                /*0x727b398*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            class ExtensionDataSetter : System.MulticastDelegate
            {
                /*0x727b3ac*/ ExtensionDataSetter(object object, nint method);
                /*0x727b4b8*/ void Invoke(object o, string key, object value);
            }

            class ExtensionDataGetter : System.MulticastDelegate
            {
                /*0x727b4cc*/ ExtensionDataGetter(object object, nint method);
                /*0x727b5d4*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> Invoke(object o);
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

                static /*0x727bfd0*/ Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo);
                static /*0x727c090*/ Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo);
                /*0x727aff0*/ JsonContract(System.Type underlyingType);
                /*0x727b5e8*/ System.Type get_UnderlyingType();
                /*0x727b5f0*/ System.Type get_CreatedType();
                /*0x727a710*/ void set_CreatedType(System.Type value);
                /*0x727b5f8*/ System.Nullable<bool> get_IsReference();
                /*0x727b600*/ void set_IsReference(System.Nullable<bool> value);
                /*0x727b608*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x727b610*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x727b618*/ Newtonsoft.Json.JsonConverter get_InternalConverter();
                /*0x727b620*/ void set_InternalConverter(Newtonsoft.Json.JsonConverter value);
                /*0x727b628*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks();
                /*0x727b6ac*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks();
                /*0x727b730*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks();
                /*0x727b7b4*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks();
                /*0x727b838*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks();
                /*0x727b8bc*/ System.Func<object> get_DefaultCreator();
                /*0x727b8c4*/ void set_DefaultCreator(System.Func<object> value);
                /*0x727b8cc*/ bool get_DefaultCreatorNonPublic();
                /*0x727b8d4*/ void set_DefaultCreatorNonPublic(bool value);
                /*0x727b8e0*/ void InvokeOnSerializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x727ba40*/ void InvokeOnSerialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x727bba0*/ void InvokeOnDeserializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x727bd00*/ void InvokeOnDeserialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x727be60*/ void InvokeOnError(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);

                class <>c__DisplayClass57_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x727c088*/ <>c__DisplayClass57_0();
                    /*0x727c150*/ void <CreateSerializationCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context);
                }

                class <>c__DisplayClass58_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x727c148*/ <>c__DisplayClass58_0();
                    /*0x727c250*/ void <CreateSerializationErrorCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext);
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

                /*0x727c540*/ JsonDictionaryContract(System.Type underlyingType);
                /*0x727c390*/ System.Func<string, string> get_DictionaryKeyResolver();
                /*0x727c398*/ void set_DictionaryKeyResolver(System.Func<string, string> value);
                /*0x727c3a0*/ System.Type get_DictionaryKeyType();
                /*0x727c3a8*/ System.Type get_DictionaryValueType();
                /*0x727c3b0*/ Newtonsoft.Json.Serialization.JsonContract get_KeyContract();
                /*0x727c3b8*/ void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x727c3c0*/ bool get_ShouldCreateWrapper();
                /*0x727c3c8*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x727c494*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x727c49c*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x727c4ac*/ bool get_HasParameterizedCreator();
                /*0x727c4b4*/ void set_HasParameterizedCreator(bool value);
                /*0x727c4c0*/ bool get_HasParameterizedCreatorInternal();
                /*0x727cf88*/ Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(object dictionary);
                /*0x727d250*/ System.Collections.IDictionary CreateTemporaryDictionary();
            }

            class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;
                /*0xc8*/ System.Func<string, string> <PropertyNameResolver>k__BackingField;
                /*0xd0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>> _callSiteGetters;
                /*0xd8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>> _callSiteSetters;

                static /*0x727d4f8*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>> CreateCallSiteGetter(string name);
                static /*0x727d610*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>> CreateCallSiteSetter(string name);
                /*0x727d728*/ JsonDynamicContract(System.Type underlyingType);
                /*0x727d4e0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x727d4e8*/ System.Func<string, string> get_PropertyNameResolver();
                /*0x727d4f0*/ void set_PropertyNameResolver(System.Func<string, string> value);
                /*0x727da68*/ bool TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, ref object value);
                /*0x727db8c*/ bool TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, object value);
            }

            class JsonFormatterConverter : System.Runtime.Serialization.IFormatterConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;
                /*0x18*/ Newtonsoft.Json.Serialization.JsonISerializableContract _contract;
                /*0x20*/ Newtonsoft.Json.Serialization.JsonProperty _member;

                /*0x727dc8c*/ JsonFormatterConverter(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x3910ae8*/ T GetTokenValue<T>(object value);
                /*0x727dd54*/ object Convert(object value, System.Type type);
                /*0x727df90*/ bool ToBoolean(object value);
                /*0x727dfe8*/ byte ToByte(object value);
                /*0x727e040*/ int ToInt32(object value);
                /*0x727e098*/ long ToInt64(object value);
                /*0x727e0f0*/ float ToSingle(object value);
                /*0x727e148*/ string ToString(object value);
            }

            class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <ISerializableCreator>k__BackingField;

                /*0x727e1b0*/ JsonISerializableContract(System.Type underlyingType);
                /*0x727e1a0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ISerializableCreator();
                /*0x727e1a8*/ void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
            }

            class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x727e1cc*/ JsonLinqContract(System.Type underlyingType);
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

                /*0x727e830*/ JsonObjectContract(System.Type underlyingType);
                /*0x727e1e8*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
                /*0x727e1f0*/ void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value);
                /*0x727e1f8*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling();
                /*0x727e200*/ void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value);
                /*0x727e208*/ System.Nullable<Newtonsoft.Json.Required> get_ItemRequired();
                /*0x727e210*/ void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value);
                /*0x727e218*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling();
                /*0x727e220*/ void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x727e228*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x727e230*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters();
                /*0x727e2b0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x727e2b8*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x727e2c8*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x727e2d0*/ void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x727e2e0*/ Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter();
                /*0x727e2e8*/ void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value);
                /*0x727e2f0*/ Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter();
                /*0x727e2f8*/ void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value);
                /*0x727e300*/ void set_ExtensionDataValueType(System.Type value);
                /*0x727e3cc*/ System.Func<string, string> get_ExtensionDataNameResolver();
                /*0x727e3d4*/ void set_ExtensionDataNameResolver(System.Func<string, string> value);
                /*0x727e3dc*/ bool get_HasRequiredOrDefaultValueProperties();
                /*0x727e8b4*/ object GetUninitializedObject();
            }

            class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Newtonsoft.Json.ReadType> ReadTypeMap;
                /*0x8c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;

                static /*0x727eabc*/ JsonPrimitiveContract();
                /*0x727e9c8*/ JsonPrimitiveContract(System.Type underlyingType);
                /*0x727e9b8*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
                /*0x727e9c0*/ void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value);
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

                /*0x727f18c*/ JsonProperty();
                /*0x727ed84*/ Newtonsoft.Json.Serialization.JsonContract get_PropertyContract();
                /*0x727ed8c*/ void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x727ed94*/ string get_PropertyName();
                /*0x727ed9c*/ void set_PropertyName(string value);
                /*0x727ee34*/ System.Type get_DeclaringType();
                /*0x727ee3c*/ void set_DeclaringType(System.Type value);
                /*0x727ee44*/ System.Nullable<int> get_Order();
                /*0x727ee4c*/ void set_Order(System.Nullable<int> value);
                /*0x727ee54*/ string get_UnderlyingName();
                /*0x727ee5c*/ void set_UnderlyingName(string value);
                /*0x727ee64*/ Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider();
                /*0x727ee6c*/ void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value);
                /*0x727ee74*/ void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value);
                /*0x727ee7c*/ System.Type get_PropertyType();
                /*0x727ee84*/ void set_PropertyType(System.Type value);
                /*0x727eef0*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x727eef8*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x727ef00*/ bool get_Ignored();
                /*0x727ef08*/ void set_Ignored(bool value);
                /*0x727ef14*/ bool get_Readable();
                /*0x727ef1c*/ void set_Readable(bool value);
                /*0x727ef28*/ bool get_Writable();
                /*0x727ef30*/ void set_Writable(bool value);
                /*0x727ef3c*/ bool get_HasMemberAttribute();
                /*0x727ef44*/ void set_HasMemberAttribute(bool value);
                /*0x727ef50*/ object get_DefaultValue();
                /*0x727ef68*/ void set_DefaultValue(object value);
                /*0x727ef78*/ object GetResolvedDefaultValue();
                /*0x727e7f4*/ Newtonsoft.Json.Required get_Required();
                /*0x727f040*/ System.Nullable<bool> get_IsReference();
                /*0x727f048*/ void set_IsReference(System.Nullable<bool> value);
                /*0x727f050*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling();
                /*0x727f058*/ void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x727f060*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling();
                /*0x727f068*/ void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value);
                /*0x727f070*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling();
                /*0x727f078*/ void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x727f080*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling();
                /*0x727f088*/ void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value);
                /*0x727f090*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling();
                /*0x727f098*/ void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x727f0a0*/ System.Predicate<object> get_ShouldSerialize();
                /*0x727f0a8*/ void set_ShouldSerialize(System.Predicate<object> value);
                /*0x727f0b0*/ System.Predicate<object> get_ShouldDeserialize();
                /*0x727f0b8*/ System.Predicate<object> get_GetIsSpecified();
                /*0x727f0c0*/ void set_GetIsSpecified(System.Predicate<object> value);
                /*0x727f0c8*/ System.Action<object, object> get_SetIsSpecified();
                /*0x727f0d0*/ void set_SetIsSpecified(System.Action<object, object> value);
                /*0x727f0d8*/ string ToString();
                /*0x727f0fc*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x727f104*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x727f10c*/ System.Nullable<bool> get_ItemIsReference();
                /*0x727f114*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x727f11c*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x727f124*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x727f12c*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x727f134*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x727f13c*/ void WritePropertyName(Newtonsoft.Json.JsonWriter writer);
            }

            class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty>
            {
                /*0x30*/ System.Type _type;
                /*0x38*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;

                /*0x727d8ec*/ JsonPropertyCollection(System.Type type);
                /*0x727f194*/ string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x727f1ac*/ void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x727f45c*/ Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName);
                /*0x727f588*/ bool TryGetProperty(string key, ref Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x727f49c*/ Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType);
            }

            class JsonSerializerInternalBase
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;
                /*0x18*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> _mappings;
                /*0x20*/ Newtonsoft.Json.JsonSerializer Serializer;
                /*0x28*/ Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;
                /*0x30*/ Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;

                /*0x727f670*/ JsonSerializerInternalBase(Newtonsoft.Json.JsonSerializer serializer);
                /*0x72788a4*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> get_DefaultReferenceMappings();
                /*0x727f714*/ Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x727f7a0*/ Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(object currentObject, object member, string path, System.Exception error);
                /*0x727f898*/ void ClearErrorContext();
                /*0x727f8fc*/ bool IsErrorHandled(object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, string path, System.Exception ex);

                class ReferenceEqualsEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
                {
                    /*0x727f70c*/ ReferenceEqualsEqualityComparer();
                    /*0x727fcc4*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
                    /*0x727fcd0*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj);
                }
            }

            class JsonSerializerInternalReader : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                static /*0x7284900*/ bool CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, string s);
                /*0x727fcdc*/ JsonSerializerInternalReader(Newtonsoft.Json.JsonSerializer serializer);
                /*0x727fce0*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
                /*0x7281b7c*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type);
                /*0x7281be0*/ Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type);
                /*0x7281c90*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, bool checkAdditionalContent);
                /*0x728292c*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x72829a4*/ Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x7282db4*/ Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader);
                /*0x7282440*/ object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x72849f0*/ string GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x7281fc0*/ Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728320c*/ object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x7284aa8*/ bool ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x7285204*/ bool ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x7286ad4*/ void ResolveTypeName(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, string qualifiedTypeName);
                /*0x72870ec*/ Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x7283d34*/ object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, object existingValue, string id);
                /*0x72858c4*/ bool HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x7284378*/ object EnsureType(Newtonsoft.Json.JsonReader reader, object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType);
                /*0x7287bb8*/ bool SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target);
                /*0x728807c*/ bool CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target, ref bool useExistingValue, ref object currentValue, ref Newtonsoft.Json.Serialization.JsonContract propertyContract, ref bool gottenCurrentValue, ref bool ignoredValue);
                /*0x7288754*/ void AddReference(Newtonsoft.Json.JsonReader reader, string id, object value);
                /*0x7288748*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x728864c*/ bool ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, object value);
                /*0x728726c*/ System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, ref bool createdFromNonDefaultCreator);
                /*0x7285bc8*/ System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, ref bool createdFromNonDefaultCreator);
                /*0x7288b18*/ void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x7288d44*/ void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x7280728*/ object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x72874f4*/ object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x7288f70*/ void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object currentObject, string message);
                /*0x7280200*/ object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x7286434*/ object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x727de6c*/ object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x7285df4*/ object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x72890a4*/ object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<object> creator, string id);
                /*0x728202c*/ object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue);
                /*0x728ad68*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x72859a4*/ object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id, ref bool createdFromNonDefaultCreator);
                /*0x72810f4*/ object PopulateObject(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x728bb18*/ bool ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x72830f0*/ bool CheckPropertyName(Newtonsoft.Json.JsonReader reader, string memberName);
                /*0x728b9a4*/ void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, string memberName, object o);
                /*0x728b8e8*/ object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader);
                /*0x728b444*/ void EndProcessProperty(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, int initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue);
                /*0x728bd70*/ void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties);
                /*0x72828c4*/ void HandleError(Newtonsoft.Json.JsonReader reader, bool readPastError, int initialDepth);

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

                    /*0x728b414*/ CreatorPropertyContext(string name);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_0;
                    static /*0x10*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_2;
                    static /*0x18*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0;
                    static /*0x20*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1;

                    static /*0x728be6c*/ <>c();
                    /*0x728bed4*/ <>c();
                    /*0x728bedc*/ string <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x728bef4*/ string <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x728bf0c*/ Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m);
                    /*0x728bf14*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m);
                }

                class <>c__DisplayClass38_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.JsonProperty property;

                    /*0x728b40c*/ <>c__DisplayClass38_0();
                    /*0x728bf1c*/ bool <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p);
                }
            }

            class JsonSerializerInternalWriter : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                /*0x38*/ System.Type _rootType;
                /*0x40*/ int _rootLevel;
                /*0x48*/ System.Collections.Generic.List<object> _serializeStack;

                static /*0x7290820*/ bool TryConvertToString(object value, System.Type type, ref string s);
                /*0x728bf40*/ JsonSerializerInternalWriter(Newtonsoft.Json.JsonSerializer serializer);
                /*0x728bfcc*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
                /*0x728cd58*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x728c26c*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(object value);
                /*0x728cdd0*/ Newtonsoft.Json.Serialization.JsonContract GetContract(object value);
                /*0x728ce94*/ void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728c690*/ void SerializeValue(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728ff28*/ System.Nullable<bool> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728c27c*/ bool ShouldWriteReference(object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728ffe4*/ bool ShouldWriteProperty(object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x72900c0*/ bool CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728c414*/ void WriteReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x7290634*/ string GetReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x728ea04*/ void SerializeString(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonStringContract contract);
                /*0x7290930*/ void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x7290b34*/ void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x728d9c0*/ void SerializeObject(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7290e78*/ bool CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.Serialization.JsonContract memberContract, ref object memberValue);
                /*0x7290d38*/ void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x7291c54*/ bool HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x7291d08*/ void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, object value);
                /*0x728d21c*/ void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type);
                /*0x72900b4*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x728ffd8*/ bool HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag);
                /*0x7291f54*/ bool HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag);
                /*0x728d49c*/ void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728e110*/ void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728e804*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x72921f0*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, int initialDepth, int[] indices);
                /*0x7291f60*/ bool WriteStartArray(Newtonsoft.Json.JsonWriter writer, object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728fab0*/ void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728f314*/ void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x729255c*/ bool ShouldWriteDynamicProperty(object memberValue);
                /*0x728cffc*/ bool ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x728ea88*/ void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x72912d0*/ string GetPropertyName(Newtonsoft.Json.JsonWriter writer, object name, Newtonsoft.Json.Serialization.JsonContract contract, ref bool escape);
                /*0x728cce4*/ void HandleError(Newtonsoft.Json.JsonWriter writer, int initialDepth);
                /*0x72917ac*/ bool ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x7291a00*/ bool IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
            }

            class JsonSerializerProxy : Newtonsoft.Json.JsonSerializer
            {
                /*0xe0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;
                /*0xe8*/ Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;
                /*0xf0*/ Newtonsoft.Json.JsonSerializer _serializer;

                /*0x7292a28*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader);
                /*0x7292ab4*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter);
                /*0x7292618*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x7292638*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x7292658*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
                /*0x7292678*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
                /*0x7292698*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
                /*0x72926b8*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
                /*0x72926d8*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
                /*0x72926fc*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
                /*0x7292720*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
                /*0x7292744*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
                /*0x7292768*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
                /*0x729278c*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
                /*0x72927b0*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
                /*0x72927d4*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
                /*0x72927f8*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
                /*0x729281c*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
                /*0x7292840*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
                /*0x7292860*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
                /*0x7292884*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
                /*0x72928a8*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
                /*0x72928c8*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
                /*0x72928ec*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
                /*0x729290c*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0x7292930*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
                /*0x7292954*/ Newtonsoft.Json.Formatting get_Formatting();
                /*0x7292978*/ void set_Formatting(Newtonsoft.Json.Formatting value);
                /*0x729299c*/ System.Nullable<int> get_MaxDepth();
                /*0x72929c0*/ bool get_CheckAdditionalContent();
                /*0x72929e4*/ void set_CheckAdditionalContent(bool value);
                /*0x7292a0c*/ Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer();
                /*0x7292b40*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x7292b78*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
                /*0x7292bac*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type rootType);
            }

            class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
            {
                /*0x7292be0*/ JsonStringContract(System.Type underlyingType);
            }

            class JsonTypeReflector
            {
                static /*0x0*/ System.Nullable<bool> _fullyTrusted;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Func<System.Object[], object>> CreatorCache;
                static /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache;
                static /*0x18*/ Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;

                static /*0x7293ce0*/ JsonTypeReflector();
                static /*0x3910ae8*/ T GetCachedAttribute<T>(object attributeProvider);
                static /*0x7292c54*/ bool CanTypeDescriptorConvertString(System.Type type, ref System.ComponentModel.TypeConverter typeConverter);
                static /*0x7292e34*/ System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type);
                static /*0x7292ef4*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo);
                static /*0x729316c*/ Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute);
                static /*0x72932c0*/ Newtonsoft.Json.JsonConverter GetJsonConverter(object attributeProvider);
                static /*0x72933e0*/ Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] args);
                static /*0x72934d4*/ Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, object[] args);
                static /*0x72935c8*/ Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute);
                static /*0x7293688*/ System.Func<System.Object[], object> GetCreator(System.Type type);
                static /*0x729389c*/ System.Type GetAssociatedMetadataType(System.Type type);
                static /*0x729391c*/ System.Type GetAssociateMetadataTypeFromAttribute(System.Type type);
                static /*0x3910ae8*/ T GetAttribute<T>(System.Type type);
                static /*0x3910ae8*/ T GetAttribute<T>(System.Reflection.MemberInfo memberInfo);
                static /*0x7293b58*/ bool IsNonSerializable(object provider);
                static /*0x7293244*/ bool IsSerializable(object provider);
                static /*0x3910ae8*/ T GetAttribute<T>(object provider);
                static /*0x7293bd4*/ bool get_FullyTrusted();
                static /*0x7293814*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory();

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonTypeReflector.<> <>9;
                    static /*0x8*/ System.Func<object, System.Type> <>9__22_1;

                    static /*0x7293e68*/ <>c();
                    /*0x7293ed0*/ <>c();
                    /*0x7293ed8*/ System.Type <GetCreator>b__22_1(object param);
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ System.Type type;
                    /*0x18*/ System.Func<object> defaultConstructor;

                    /*0x729380c*/ <>c__DisplayClass22_0();
                    /*0x7293f34*/ object <GetCreator>b__0(object[] parameters);
                }
            }

            class KebabCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x729436c*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x72943ac*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x72943f8*/ KebabCaseNamingStrategy();
                /*0x7294400*/ string ResolvePropertyName(string name);
            }

            class NamingStrategy
            {
                /*0x10*/ bool <ProcessDictionaryKeys>k__BackingField;
                /*0x11*/ bool <ProcessExtensionDataNames>k__BackingField;
                /*0x12*/ bool <OverrideSpecifiedNames>k__BackingField;

                /*0x72943a4*/ NamingStrategy();
                /*0x729440c*/ bool get_ProcessDictionaryKeys();
                /*0x7294414*/ void set_ProcessDictionaryKeys(bool value);
                /*0x7294420*/ bool get_ProcessExtensionDataNames();
                /*0x7294428*/ void set_ProcessExtensionDataNames(bool value);
                /*0x7294434*/ bool get_OverrideSpecifiedNames();
                /*0x729443c*/ void set_OverrideSpecifiedNames(bool value);
                /*0x7294448*/ string GetPropertyName(string name, bool hasSpecifiedName);
                /*0x7294468*/ string GetExtensionDataName(string name);
                /*0x7294484*/ string GetDictionaryKey(string key);
                /*0x3814a3c*/ string ResolvePropertyName(string name);
                /*0x72944a0*/ int GetHashCode();
                /*0x7294560*/ bool Equals(object obj);
                /*0x72945e0*/ bool Equals(Newtonsoft.Json.Serialization.NamingStrategy other);
            }

            class ObjectConstructor<T> : System.MulticastDelegate
            {
                ObjectConstructor(object object, nint method);
                /*0x3814a3c*/ object Invoke(object[] args);
            }

            class OnErrorAttribute : System.Attribute
            {
            }

            class ReflectionAttributeProvider : Newtonsoft.Json.Serialization.IAttributeProvider
            {
                /*0x10*/ object _attributeProvider;

                /*0x72946b8*/ ReflectionAttributeProvider(object attributeProvider);
            }

            class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
            {
                /*0x10*/ System.Reflection.MemberInfo _memberInfo;

                /*0x729472c*/ ReflectionValueProvider(System.Reflection.MemberInfo memberInfo);
                /*0x72947a0*/ void SetValue(object target, object value);
                /*0x729493c*/ object GetValue(object target);
            }

            class SnakeCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x7294bd4*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x7294c0c*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x7294c58*/ SnakeCaseNamingStrategy();
                /*0x7294c60*/ string ResolvePropertyName(string name);
            }

            class TraceJsonReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.JsonReader _innerReader;
                /*0x80*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x88*/ System.IO.StringWriter _sw;

                /*0x7294c6c*/ TraceJsonReader(Newtonsoft.Json.JsonReader innerReader);
                /*0x7294dd8*/ string GetDeserializedJsonMessage();
                /*0x7294df8*/ bool Read();
                /*0x7294e70*/ System.Nullable<int> ReadAsInt32();
                /*0x7294eb0*/ string ReadAsString();
                /*0x7294ef0*/ byte[] ReadAsBytes();
                /*0x7294f34*/ System.Nullable<decimal> ReadAsDecimal();
                /*0x7294fb0*/ System.Nullable<double> ReadAsDouble();
                /*0x7294ffc*/ System.Nullable<bool> ReadAsBoolean();
                /*0x7295040*/ System.Nullable<System.DateTime> ReadAsDateTime();
                /*0x729508c*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
                /*0x7294e38*/ void WriteCurrentToken();
                /*0x72950e8*/ int get_Depth();
                /*0x7295108*/ string get_Path();
                /*0x7295128*/ Newtonsoft.Json.JsonToken get_TokenType();
                /*0x7295148*/ object get_Value();
                /*0x7295168*/ System.Type get_ValueType();
                /*0x7295188*/ void Close();
                /*0x72951ac*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x7295260*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x7295318*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
            }

            class TraceJsonWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.JsonWriter _innerWriter;
                /*0x68*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x70*/ System.IO.StringWriter _sw;

                /*0x72953d0*/ TraceJsonWriter(Newtonsoft.Json.JsonWriter innerWriter);
                /*0x72955d8*/ string GetSerializedJsonMessage();
                /*0x72955f8*/ void WriteValue(decimal value);
                /*0x7295664*/ void WriteValue(System.Nullable<decimal> value);
                /*0x7295780*/ void WriteValue(bool value);
                /*0x72957e4*/ void WriteValue(System.Nullable<bool> value);
                /*0x7295898*/ void WriteValue(byte value);
                /*0x72958f8*/ void WriteValue(System.Nullable<byte> value);
                /*0x72959a8*/ void WriteValue(char value);
                /*0x7295a08*/ void WriteValue(System.Nullable<char> value);
                /*0x7295ab8*/ void WriteValue(byte[] value);
                /*0x7295b2c*/ void WriteValue(System.DateTime value);
                /*0x7295b8c*/ void WriteValue(System.Nullable<System.DateTime> value);
                /*0x7295c4c*/ void WriteValue(System.DateTimeOffset value);
                /*0x7295cb8*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
                /*0x7295dac*/ void WriteValue(double value);
                /*0x7295e0c*/ void WriteValue(System.Nullable<double> value);
                /*0x7295ed0*/ void WriteUndefined();
                /*0x7295f1c*/ void WriteNull();
                /*0x7295f68*/ void WriteValue(float value);
                /*0x7295fc8*/ void WriteValue(System.Nullable<float> value);
                /*0x7296078*/ void WriteValue(System.Guid value);
                /*0x72960e4*/ void WriteValue(System.Nullable<System.Guid> value);
                /*0x72961dc*/ void WriteValue(int value);
                /*0x729623c*/ void WriteValue(System.Nullable<int> value);
                /*0x72962e8*/ void WriteValue(long value);
                /*0x7296348*/ void WriteValue(System.Nullable<long> value);
                /*0x7296408*/ void WriteValue(object value);
                /*0x72964d4*/ void WriteValue(sbyte value);
                /*0x7296534*/ void WriteValue(System.Nullable<sbyte> value);
                /*0x72965e4*/ void WriteValue(short value);
                /*0x7296644*/ void WriteValue(System.Nullable<short> value);
                /*0x72966f4*/ void WriteValue(string value);
                /*0x7296754*/ void WriteValue(System.TimeSpan value);
                /*0x72967b4*/ void WriteValue(System.Nullable<System.TimeSpan> value);
                /*0x7296874*/ void WriteValue(uint value);
                /*0x72968d4*/ void WriteValue(System.Nullable<uint> value);
                /*0x7296980*/ void WriteValue(ulong value);
                /*0x72969e0*/ void WriteValue(System.Nullable<ulong> value);
                /*0x7296aa0*/ void WriteValue(System.Uri value);
                /*0x7296b64*/ void WriteValue(ushort value);
                /*0x7296bc4*/ void WriteValue(System.Nullable<ushort> value);
                /*0x7296c74*/ void WriteComment(string text);
                /*0x7296cd4*/ void WriteStartArray();
                /*0x7296d18*/ void WriteEndArray();
                /*0x7296d5c*/ void WriteStartConstructor(string name);
                /*0x7296db4*/ void WriteEndConstructor();
                /*0x7296df8*/ void WritePropertyName(string name);
                /*0x7296e58*/ void WritePropertyName(string name, bool escape);
                /*0x7296ec4*/ void WriteStartObject();
                /*0x7296f08*/ void WriteEndObject();
                /*0x7296f4c*/ void WriteRawValue(string json);
                /*0x7296fac*/ void WriteRaw(string json);
                /*0x729700c*/ void Close();
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

                static /*0x7297644*/ Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x7297060*/ JArray();
                /*0x729713c*/ JArray(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729753c*/ JArray(object content);
                /*0x7297050*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x7297058*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x72975dc*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7297ae0*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x7297bac*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                /*0x7297bbc*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x7297bcc*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7297c30*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x7297c40*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7297c58*/ void RemoveAt(int index);
                /*0x7297c68*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                /*0x7297d00*/ void Add(Newtonsoft.Json.Linq.JToken item);
                /*0x7297d10*/ void Clear();
                /*0x7297d20*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x7297d30*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x7297d40*/ bool get_IsReadOnly();
                /*0x7297d48*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
            }

            class JConstructor : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ string _name;
                /*0x58*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0x7298104*/ Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x7297dd4*/ JConstructor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7297e88*/ JConstructor(string name);
                /*0x7297d58*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x7297d60*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7297dc4*/ string get_Name();
                /*0x7297dcc*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x7297fbc*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x7298024*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
            }

            class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.ComponentModel.IBindingList, System.Collections.ICollection, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged
            {
                /*0x30*/ System.ComponentModel.ListChangedEventHandler _listChanged;
                /*0x38*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;
                /*0x40*/ object _syncRoot;
                /*0x48*/ bool _busy;

                static /*0x7299ed4*/ bool IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue);
                static /*0x729acb8*/ Newtonsoft.Json.Linq.JToken CreateFromContent(object content);
                static /*0x729b2e4*/ Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent);
                /*0x72970e4*/ JContainer();
                /*0x72971d8*/ JContainer(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x72982e8*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x7298378*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x38148bc*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x7298840*/ void CheckReentrancy();
                /*0x72988e8*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
                /*0x7298970*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x72989f8*/ bool get_HasValues();
                /*0x7298ab8*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x7298bf4*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x7298d30*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x7298da4*/ bool IsMultiContent(object content);
                /*0x7298e7c*/ Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x381467c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x7298fe8*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x729941c*/ void RemoveItemAt(int index);
                /*0x72998b0*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x72998fc*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x72999b8*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x7299f80*/ void ClearItems();
                /*0x729a3c4*/ void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement);
                /*0x729a428*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x729a44c*/ void CopyItemsTo(System.Array array, int arrayIndex);
                /*0x729a92c*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x729aa48*/ void Add(object content);
                /*0x729ab18*/ bool TryAdd(object content);
                /*0x729abe8*/ void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token);
                /*0x72984a4*/ bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations);
                /*0x729ad9c*/ void RemoveAll();
                /*0x7297984*/ void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options);
                /*0x729adac*/ void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x729b75c*/ int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x729b76c*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x729b784*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index);
                /*0x729b794*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index);
                /*0x729b7a4*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x729b7b4*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item);
                /*0x729b7c4*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear();
                /*0x729b7d4*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x729b7e4*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x729b7f4*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly();
                /*0x729b7fc*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item);
                /*0x729b80c*/ Newtonsoft.Json.Linq.JToken EnsureValue(object value);
                /*0x729b8c8*/ int System.Collections.IList.Add(object value);
                /*0x729b900*/ void System.Collections.IList.Clear();
                /*0x729b910*/ bool System.Collections.IList.Contains(object value);
                /*0x729b938*/ int System.Collections.IList.IndexOf(object value);
                /*0x729b960*/ void System.Collections.IList.Insert(int index, object value);
                /*0x729b9a4*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x729b9ac*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x729b9b4*/ void System.Collections.IList.Remove(object value);
                /*0x729b9dc*/ void System.Collections.IList.RemoveAt(int index);
                /*0x729b9ec*/ object System.Collections.IList.get_Item(int index);
                /*0x729b9fc*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x729ba38*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x729a878*/ int get_Count();
                /*0x729ba48*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x729ba50*/ object System.Collections.ICollection.get_SyncRoot();
            }

            struct JEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>>
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JEnumerable<T> Empty;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> _enumerable;

                static /*0x383e7a0*/ JEnumerable();
                /*0x3816710*/ JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3910ae8*/ bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other);
                /*0x38141c4*/ bool Equals(object obj);
                /*0x3814574*/ int GetHashCode();
            }

            class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x50*/ Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;
                /*0x58*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
                /*0x60*/ System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

                static /*0x729c604*/ Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x729b1cc*/ JObject();
                /*0x729bc94*/ JObject(Newtonsoft.Json.Linq.JObject other);
                /*0x729bd0c*/ JObject(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729bd88*/ JObject(object[] content);
                /*0x729bd8c*/ JObject(object content);
                /*0x729bac4*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x729bacc*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x729bb68*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x729be14*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x729bee0*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x729bf50*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x729c1e8*/ void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x729c334*/ void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x729c358*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729c3c0*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x729c3c8*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties();
                /*0x729b4b8*/ Newtonsoft.Json.Linq.JProperty Property(string name, System.StringComparison comparison);
                /*0x729c410*/ Newtonsoft.Json.Linq.JToken get_Item(string propertyName);
                /*0x729c490*/ void set_Item(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x729c7c8*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x729c588*/ void Add(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x729c9b4*/ bool ContainsKey(string propertyName);
                /*0x729cacc*/ System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys();
                /*0x729cb3c*/ bool Remove(string propertyName);
                /*0x729cbd4*/ bool TryGetValue(string propertyName, ref Newtonsoft.Json.Linq.JToken value);
                /*0x729cc30*/ System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values();
                /*0x729cc68*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x729ccfc*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear();
                /*0x729cd0c*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x729cd8c*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> array, int arrayIndex);
                /*0x729d1fc*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly();
                /*0x729d204*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x729d344*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> GetEnumerator();
                /*0x729d3d8*/ void OnPropertyChanged(string propertyName);
                /*0x729d468*/ void OnPropertyChanging(string propertyName);
                /*0x729d4f8*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x729d594*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x729d8f8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x729d950*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x729d9a4*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                /*0x729da20*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);

                class JObjectDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JObject>
                {
                    /*0x729dad0*/ JObjectDynamicProxy();
                    /*0x729db18*/ bool TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, ref object result);
                    /*0x729db58*/ bool TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, object value);
                    /*0x729dc38*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance);

                    class <>c
                    {
                        static /*0x0*/ Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<> <>9;
                        static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JProperty, string> <>9__2_0;

                        static /*0x729dd4c*/ <>c();
                        /*0x729ddb4*/ <>c();
                        /*0x729ddbc*/ string <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p);
                    }
                }

                class <GetEnumerator>d__64 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> <>2__current;
                    /*0x28*/ Newtonsoft.Json.Linq.JObject <>4__this;
                    /*0x30*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;

                    /*0x729d3b0*/ <GetEnumerator>d__64(int <>1__state);
                    /*0x729ddd4*/ void System.IDisposable.Dispose();
                    /*0x729ddf0*/ bool MoveNext();
                    /*0x729e0dc*/ void <>m__Finally1();
                    /*0x729e18c*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current();
                    /*0x729e198*/ void System.Collections.IEnumerator.Reset();
                    /*0x729e1d0*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class JProperty : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ Newtonsoft.Json.Linq.JProperty.JPropertyList _content;
                /*0x58*/ string _name;

                static /*0x729e8f4*/ Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x729e23c*/ JProperty(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729b640*/ JProperty(string name);
                /*0x729c8b0*/ JProperty(string name, object content);
                /*0x729e22c*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x729e234*/ string get_Name();
                /*0x729b1b0*/ Newtonsoft.Json.Linq.JToken get_Value();
                /*0x729c508*/ void set_Value(Newtonsoft.Json.Linq.JToken value);
                /*0x729e2dc*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x729e330*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x729e474*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x729e524*/ void RemoveItemAt(int index);
                /*0x729e5d4*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x729e614*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck, bool copyAnnotations);
                /*0x729e730*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x729e754*/ void ClearItems();
                /*0x729e804*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729e86c*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x729e874*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);

                class JPropertyList : System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JToken _token;

                    /*0x729e2d4*/ JPropertyList();
                    /*0x729ead8*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                    /*0x729eb6c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x729eb70*/ void Add(Newtonsoft.Json.Linq.JToken item);
                    /*0x729eb78*/ void Clear();
                    /*0x729eb84*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                    /*0x729eb94*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                    /*0x729ec08*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
                    /*0x729ec40*/ int get_Count();
                    /*0x729ec50*/ bool get_IsReadOnly();
                    /*0x729e604*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                    /*0x729ec58*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                    /*0x729ec6c*/ void RemoveAt(int index);
                    /*0x729ec80*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                    /*0x729ecc8*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);

                    class <GetEnumerator>d__1 : System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ Newtonsoft.Json.Linq.JProperty.JPropertyList <>4__this;

                        /*0x729eb44*/ <GetEnumerator>d__1(int <>1__state);
                        /*0x729ed14*/ void System.IDisposable.Dispose();
                        /*0x729ed18*/ bool MoveNext();
                        /*0x729ed80*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0x729ed88*/ void System.Collections.IEnumerator.Reset();
                        /*0x729edc0*/ object System.Collections.IEnumerator.get_Current();
                    }
                }
            }

            class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x729d8ec*/ JPropertyDescriptor(string name);
                /*0x729edc8*/ bool CanResetValue(object component);
                /*0x729edd0*/ object GetValue(object component);
                /*0x729ee6c*/ void ResetValue(object component);
                /*0x729ee70*/ void SetValue(object component, object value);
                /*0x729efac*/ bool ShouldSerializeValue(object component);
                /*0x729efb4*/ System.Type get_ComponentType();
                /*0x729f014*/ bool get_IsReadOnly();
                /*0x729f01c*/ System.Type get_PropertyType();
                /*0x729f04c*/ int get_NameHashCode();
            }

            class JPropertyKeyedCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.Linq.JToken>
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<string> Comparer;
                /*0x18*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Linq.JToken> _dictionary;

                static /*0x729f64c*/ JPropertyKeyedCollection();
                /*0x729bc04*/ JPropertyKeyedCollection();
                /*0x729f054*/ void AddKey(string key, Newtonsoft.Json.Linq.JToken item);
                /*0x729f180*/ void ClearItems();
                /*0x729ca20*/ bool Contains(string key);
                /*0x729f0c4*/ void EnsureDictionary();
                /*0x729f1f8*/ string GetKeyForItem(Newtonsoft.Json.Linq.JToken item);
                /*0x729f278*/ void InsertItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x729f2f0*/ void RemoveItem(int index);
                /*0x729f3e4*/ void RemoveKey(string key);
                /*0x729f444*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x729c160*/ bool TryGetValue(string key, ref Newtonsoft.Json.Linq.JToken value);
                /*0x729cae4*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0x729be3c*/ int IndexOfReference(Newtonsoft.Json.Linq.JToken t);
            }

            class JRaw : Newtonsoft.Json.Linq.JValue
            {
                static /*0x729f848*/ Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader);
                /*0x729f6fc*/ JRaw(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x729f7c0*/ JRaw(object rawJson);
                /*0x729fbc4*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
            }

            class JsonCloneSettings
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JsonCloneSettings SkipCopyAnnotations;
                /*0x10*/ bool <CopyAnnotations>k__BackingField;

                static /*0x729fc60*/ JsonCloneSettings();
                /*0x729fc2c*/ JsonCloneSettings();
                /*0x729fc4c*/ bool get_CopyAnnotations();
                /*0x729fc54*/ void set_CopyAnnotations(bool value);
            }

            class JsonLoadSettings
            {
                /*0x10*/ Newtonsoft.Json.Linq.CommentHandling _commentHandling;
                /*0x14*/ Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;
                /*0x18*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

                /*0x729fccc*/ Newtonsoft.Json.Linq.CommentHandling get_CommentHandling();
                /*0x729fcd4*/ Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling();
                /*0x729fcdc*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling();
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

                static /*0x72a6e3c*/ JToken();
                static /*0x72a04fc*/ Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a0610*/ string GetType(Newtonsoft.Json.Linq.JToken token);
                static /*0x72a0700*/ bool ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, bool nullable);
                static /*0x72a07c0*/ bool op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a09c8*/ System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a0c08*/ System.Nullable<bool> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a0e58*/ long op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a103c*/ System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1260*/ System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1528*/ System.Nullable<decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1768*/ System.Nullable<double> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1988*/ System.Nullable<char> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1bac*/ int op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1d90*/ short op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a1f74*/ ushort op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2158*/ char op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a233c*/ byte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2520*/ sbyte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2704*/ System.Nullable<int> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2928*/ System.Nullable<short> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2b4c*/ System.Nullable<ushort> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2d70*/ System.Nullable<byte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a2f94*/ System.Nullable<sbyte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a31b8*/ System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a33a4*/ System.Nullable<long> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a35c8*/ System.Nullable<float> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a37e8*/ decimal op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a39cc*/ System.Nullable<uint> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a3bf0*/ System.Nullable<ulong> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a3e14*/ double op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a3ff8*/ float op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a41dc*/ string op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a4454*/ uint op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a4638*/ ulong op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a481c*/ System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a4a3c*/ System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a4ca0*/ System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a4e9c*/ System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a50d4*/ System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a52d0*/ System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a541c*/ System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value);
                static /*0x72a6618*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader);
                static /*0x72a6670*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x7298408*/ JToken();
                /*0x729fce4*/ Newtonsoft.Json.Linq.JContainer get_Parent();
                /*0x729fcec*/ void set_Parent(Newtonsoft.Json.Linq.JContainer value);
                /*0x7298fd0*/ Newtonsoft.Json.Linq.JToken get_Root();
                /*0x3814a3c*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x3814574*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x3813ffc*/ bool get_HasValues();
                /*0x729fcf4*/ Newtonsoft.Json.Linq.JToken get_Next();
                /*0x729fcfc*/ void set_Next(Newtonsoft.Json.Linq.JToken value);
                /*0x729fd04*/ Newtonsoft.Json.Linq.JToken get_Previous();
                /*0x729fd0c*/ void set_Previous(Newtonsoft.Json.Linq.JToken value);
                /*0x729fd14*/ string get_Path();
                /*0x72a0094*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x72a0124*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x72a01b4*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x729cb68*/ void Remove();
                /*0x729b6e8*/ void Replace(Newtonsoft.Json.Linq.JToken value);
                /*0x3816810*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x72a020c*/ string ToString();
                /*0x72a02a4*/ string ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters);
                /*0x72a55c8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x72a565c*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                /*0x72a56f4*/ Newtonsoft.Json.JsonReader CreateReader();
                /*0x72a57c0*/ object ToObject(System.Type objectType);
                /*0x72a63ac*/ object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0x72977e4*/ void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x72a6950*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x72a6c48*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x72a6c9c*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x72a6cf0*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x72a6d44*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x72a6e0c*/ System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x72a6e1c*/ object System.ICloneable.Clone();
                /*0x72a6e2c*/ Newtonsoft.Json.Linq.JToken DeepClone();
                /*0x72a69ec*/ void AddAnnotation(object annotation);
                /*0x3910ae8*/ T Annotation<T>();
                /*0x7298410*/ void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source);

                class LineInfoAnnotation
                {
                    /*0x10*/ int LineNumber;
                    /*0x14*/ int LinePosition;

                    /*0x72a69c0*/ LineInfoAnnotation(int lineNumber, int linePosition);
                }
            }

            class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.Linq.JToken _root;
                /*0x80*/ string _initialPath;
                /*0x88*/ Newtonsoft.Json.Linq.JToken _parent;
                /*0x90*/ Newtonsoft.Json.Linq.JToken _current;

                /*0x72a574c*/ JTokenReader(Newtonsoft.Json.Linq.JToken token);
                /*0x72a7144*/ Newtonsoft.Json.Linq.JToken get_CurrentToken();
                /*0x72a714c*/ bool Read();
                /*0x72a72ac*/ bool ReadOver(Newtonsoft.Json.Linq.JToken t);
                /*0x72a7970*/ bool ReadToEnd();
                /*0x72a7a40*/ System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c);
                /*0x72a7228*/ bool ReadInto(Newtonsoft.Json.Linq.JContainer c);
                /*0x72a79a0*/ bool SetEnd(Newtonsoft.Json.Linq.JContainer c);
                /*0x72a737c*/ void SetToken(Newtonsoft.Json.Linq.JToken token);
                /*0x72a7b90*/ string SafeToString(object value);
                /*0x72a7bb0*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x72a7c64*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x72a7d1c*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x72a7dd4*/ string get_Path();
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

                /*0x72a7ee4*/ JTokenWriter();
                /*0x72a7ec8*/ Newtonsoft.Json.Linq.JToken get_Token();
                /*0x72a7f3c*/ void Close();
                /*0x72a7f44*/ void WriteStartObject();
                /*0x72a7fa8*/ void AddParent(Newtonsoft.Json.Linq.JContainer container);
                /*0x72a8008*/ void RemoveParent();
                /*0x72a8078*/ void WriteStartArray();
                /*0x72a80dc*/ void WriteStartConstructor(string name);
                /*0x72a8154*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
                /*0x72a8158*/ void WritePropertyName(string name);
                /*0x72a8218*/ void AddRawValue(object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token);
                /*0x72a8288*/ void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token);
                /*0x72a8348*/ void WriteValue(object value);
                /*0x72a83d8*/ void WriteNull();
                /*0x72a83fc*/ void WriteUndefined();
                /*0x72a8420*/ void WriteRaw(string json);
                /*0x72a849c*/ void WriteComment(string text);
                /*0x72a84d0*/ void WriteValue(string value);
                /*0x72a8554*/ void WriteValue(int value);
                /*0x72a85a4*/ void WriteValue(uint value);
                /*0x72a85f4*/ void WriteValue(long value);
                /*0x72a86e0*/ void WriteValue(ulong value);
                /*0x72a87bc*/ void WriteValue(float value);
                /*0x72a8898*/ void WriteValue(double value);
                /*0x72a8984*/ void WriteValue(bool value);
                /*0x72a8a74*/ void WriteValue(short value);
                /*0x72a8ac4*/ void WriteValue(ushort value);
                /*0x72a8b14*/ void WriteValue(char value);
                /*0x72a8bfc*/ void WriteValue(byte value);
                /*0x72a8c4c*/ void WriteValue(sbyte value);
                /*0x72a8c9c*/ void WriteValue(decimal value);
                /*0x72a8d9c*/ void WriteValue(System.DateTime value);
                /*0x72a8ec0*/ void WriteValue(System.DateTimeOffset value);
                /*0x72a8fbc*/ void WriteValue(byte[] value);
                /*0x72a9038*/ void WriteValue(System.TimeSpan value);
                /*0x72a911c*/ void WriteValue(System.Guid value);
                /*0x72a9218*/ void WriteValue(System.Uri value);
                /*0x72a9314*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            }

            class JValue : Newtonsoft.Json.Linq.JToken, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IConvertible
            {
                /*0x30*/ Newtonsoft.Json.Linq.JTokenType _valueType;
                /*0x38*/ object _value;

                static /*0x72a9950*/ int CompareBigInteger(System.Numerics.BigInteger i1, object i2);
                static /*0x72a9c34*/ int Compare(Newtonsoft.Json.Linq.JTokenType valueType, object objA, object objB);
                static /*0x72aa66c*/ int CompareFloat(object objA, object objB);
                static /*0x72aa768*/ bool Operation(System.Linq.Expressions.ExpressionType operation, object objA, object objB, ref object result);
                static /*0x729b230*/ Newtonsoft.Json.Linq.JValue CreateComment(string value);
                static /*0x7298f78*/ Newtonsoft.Json.Linq.JValue CreateNull();
                static /*0x729b28c*/ Newtonsoft.Json.Linq.JValue CreateUndefined();
                static /*0x72a9618*/ Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value);
                static /*0x72aafe4*/ Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current);
                static /*0x72ab7ec*/ bool ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2);
                /*0x729f7c8*/ JValue(object value, Newtonsoft.Json.Linq.JTokenType type);
                /*0x729f700*/ JValue(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x72a866c*/ JValue(long value);
                /*0x72a8d20*/ JValue(decimal value);
                /*0x72a877c*/ JValue(ulong value);
                /*0x72a8910*/ JValue(double value);
                /*0x72a8858*/ JValue(float value);
                /*0x72a8e54*/ JValue(System.DateTime value);
                /*0x72a8f44*/ JValue(System.DateTimeOffset value);
                /*0x72a8a00*/ JValue(bool value);
                /*0x72a854c*/ JValue(string value);
                /*0x72a91a0*/ JValue(System.Guid value);
                /*0x72a9290*/ JValue(System.Uri value);
                /*0x72a90b0*/ JValue(System.TimeSpan value);
                /*0x729ad6c*/ JValue(object value);
                /*0x72a9948*/ bool get_HasValues();
                /*0x72aaf7c*/ Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings);
                /*0x72ab060*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x72ab068*/ object get_Value();
                /*0x72ab070*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x72ab848*/ bool Equals(Newtonsoft.Json.Linq.JValue other);
                /*0x72ab858*/ bool Equals(object obj);
                /*0x72ab8e4*/ int GetHashCode();
                /*0x72ab8fc*/ string ToString();
                /*0x72ab928*/ string ToString(System.IFormatProvider formatProvider);
                /*0x72ab934*/ string ToString(string format, System.IFormatProvider formatProvider);
                /*0x72aba40*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x72abb38*/ int System.IComparable.CompareTo(object obj);
                /*0x72abbf4*/ int CompareTo(Newtonsoft.Json.Linq.JValue obj);
                /*0x72abc38*/ System.TypeCode System.IConvertible.GetTypeCode();
                /*0x72abcf4*/ bool System.IConvertible.ToBoolean(System.IFormatProvider provider);
                /*0x72abd48*/ char System.IConvertible.ToChar(System.IFormatProvider provider);
                /*0x72abd9c*/ sbyte System.IConvertible.ToSByte(System.IFormatProvider provider);
                /*0x72abdf0*/ byte System.IConvertible.ToByte(System.IFormatProvider provider);
                /*0x72abe44*/ short System.IConvertible.ToInt16(System.IFormatProvider provider);
                /*0x72abe98*/ ushort System.IConvertible.ToUInt16(System.IFormatProvider provider);
                /*0x72abeec*/ int System.IConvertible.ToInt32(System.IFormatProvider provider);
                /*0x72abf40*/ uint System.IConvertible.ToUInt32(System.IFormatProvider provider);
                /*0x72abf94*/ long System.IConvertible.ToInt64(System.IFormatProvider provider);
                /*0x72abfe8*/ ulong System.IConvertible.ToUInt64(System.IFormatProvider provider);
                /*0x72ac03c*/ float System.IConvertible.ToSingle(System.IFormatProvider provider);
                /*0x72ac090*/ double System.IConvertible.ToDouble(System.IFormatProvider provider);
                /*0x72ac0e4*/ decimal System.IConvertible.ToDecimal(System.IFormatProvider provider);
                /*0x72ac138*/ System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider);
                /*0x72ac18c*/ object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider);

                class JValueDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JValue>
                {
                    /*0x72abaf0*/ JValueDynamicProxy();
                    /*0x72ac190*/ bool TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, ref object result);
                    /*0x72ac370*/ bool TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
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

                static /*0x72ac8d0*/ void EnsureReflectionObject(System.Type t);
                /*0x72ad208*/ BinaryConverter();
                /*0x72ac694*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72ac6e8*/ byte[] GetByteArray(object value);
                /*0x72aca84*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72ace70*/ byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader);
                /*0x72ad0fc*/ bool CanConvert(System.Type objectType);
            }

            class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x72ad508*/ BsonObjectIdConverter();
                /*0x72ad210*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72ad310*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72ad494*/ bool CanConvert(System.Type objectType);
            }

            class CustomCreationConverter<T> : Newtonsoft.Json.JsonConverter
            {
                /*0x38159dc*/ CustomCreationConverter();
                /*0x3816920*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3814c50*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x3910ae8*/ T Create(System.Type objectType);
                /*0x38141c4*/ bool CanConvert(System.Type objectType);
                /*0x3813ffc*/ bool get_CanWrite();
            }

            class DataSetConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x72adce0*/ DataSetConverter();
                /*0x72ad510*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72ad9a0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72adc60*/ bool CanConvert(System.Type valueType);
            }

            class DataTableConverter : Newtonsoft.Json.JsonConverter
            {
                static /*0x72ae7b0*/ void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer);
                static /*0x72aecb0*/ System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader);
                /*0x72ad998*/ DataTableConverter();
                /*0x72adce8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72ae4e4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72aee6c*/ bool CanConvert(System.Type valueType);
            }

            class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
            {
                /*0x72af048*/ DateTimeConverterBase();
                /*0x72aeeec*/ bool CanConvert(System.Type objectType);
            }

            class DiscriminatedUnionConverter : Newtonsoft.Json.JsonConverter
            {
                static string CasePropertyName = "Case";
                static string FieldsPropertyName = "Fields";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache;

                static /*0x72b0864*/ DiscriminatedUnionConverter();
                static /*0x72af050*/ System.Type CreateUnionTypeLookup(System.Type t);
                static /*0x72af250*/ Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t);
                /*0x72b085c*/ DiscriminatedUnionConverter();
                /*0x72afad0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72aff50*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b05d8*/ bool CanConvert(System.Type objectType);

                class Union
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.FSharpFunction TagReader;
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;

                    /*0x72afa08*/ Union(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases);
                }

                class UnionCase
                {
                    /*0x10*/ int Tag;
                    /*0x18*/ string Name;
                    /*0x20*/ System.Reflection.PropertyInfo[] Fields;
                    /*0x28*/ Newtonsoft.Json.Utilities.FSharpFunction FieldReader;
                    /*0x30*/ Newtonsoft.Json.Utilities.FSharpFunction Constructor;

                    /*0x72afa4c*/ UnionCase(int tag, string name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ int tag;

                    /*0x72aff48*/ <>c__DisplayClass8_0();
                    /*0x72b09f4*/ bool <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ string caseName;
                    /*0x18*/ System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> <>9__0;

                    /*0x72b05d0*/ <>c__DisplayClass9_0();
                    /*0x72b0a18*/ bool <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }
            }

            class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
            {
                static string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
                static string KeyPropertyName = "Key";
                static string TypePropertyName = "Type";
                static string ValuePropertyName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0x72b0e98*/ void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, string propertyName);
                static /*0x72b0d78*/ void EnsureReflectionObject(System.Type objectType);
                /*0x72b1280*/ EntityKeyMemberConverter();
                /*0x72b0a3c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b0f84*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b1230*/ bool CanConvert(System.Type objectType);
            }

            class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x72b17ac*/ ExpandoObjectConverter();
                /*0x72b1288*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b128c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b1290*/ object ReadValue(Newtonsoft.Json.JsonReader reader);
                /*0x72b15a8*/ object ReadList(Newtonsoft.Json.JsonReader reader);
                /*0x72b13ec*/ object ReadObject(Newtonsoft.Json.JsonReader reader);
                /*0x72b1730*/ bool CanConvert(System.Type objectType);
                /*0x72b17a4*/ bool get_CanWrite();
            }

            class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
                /*0x10*/ System.Globalization.DateTimeStyles _dateTimeStyles;
                /*0x18*/ string _dateTimeFormat;
                /*0x20*/ System.Globalization.CultureInfo _culture;

                /*0x72b1ffc*/ IsoDateTimeConverter();
                /*0x72b17b4*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
                /*0x72b17bc*/ void set_DateTimeStyles(System.Globalization.DateTimeStyles value);
                /*0x72b17c4*/ string get_DateTimeFormat();
                /*0x72b17e8*/ void set_DateTimeFormat(string value);
                /*0x72b1828*/ System.Globalization.CultureInfo get_Culture();
                /*0x72b1890*/ void set_Culture(System.Globalization.CultureInfo value);
                /*0x72b1898*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b1b00*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                /*0x72b2508*/ JavaScriptDateTimeConverter();
                /*0x72b200c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b21e8*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
            {
                static string KeyName = "Key";
                static string ValueName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

                static /*0x72b2fbc*/ KeyValuePairConverter();
                static /*0x72b2510*/ Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t);
                /*0x72b2fb4*/ KeyValuePairConverter();
                /*0x72b278c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b29e0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b2ea8*/ bool CanConvert(System.Type objectType);
            }

            class RegexConverter : Newtonsoft.Json.JsonConverter
            {
                static string PatternName = "Pattern";
                static string OptionsName = "Options";

                /*0x72b3ac4*/ RegexConverter();
                /*0x72b30a4*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b34b4*/ bool HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag);
                /*0x72b31c4*/ void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex);
                /*0x72b32f8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b3570*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b387c*/ object ReadRegexString(Newtonsoft.Json.JsonReader reader);
                /*0x72b361c*/ System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b39d4*/ bool CanConvert(System.Type objectType);
                /*0x72b3a50*/ bool IsRegex(System.Type objectType);
            }

            class StringEnumConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;
                /*0x18*/ bool <AllowIntegerValues>k__BackingField;

                /*0x72b3c3c*/ StringEnumConverter();
                /*0x72b3c4c*/ StringEnumConverter(bool camelCaseText);
                /*0x72b3cd4*/ StringEnumConverter(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, bool allowIntegerValues);
                /*0x72b3d1c*/ StringEnumConverter(System.Type namingStrategyType);
                /*0x72b3dcc*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters);
                /*0x72b3e88*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues);
                /*0x72b3acc*/ bool get_CamelCaseText();
                /*0x72b3b48*/ void set_CamelCaseText(bool value);
                /*0x72b3c18*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x72b3c20*/ void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value);
                /*0x72b3c28*/ bool get_AllowIntegerValues();
                /*0x72b3c30*/ void set_AllowIntegerValues(bool value);
                /*0x72b3f54*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b4138*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b45a8*/ bool CanConvert(System.Type objectType);
            }

            class UnixDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static /*0x0*/ System.DateTime UnixEpoch;
                /*0x10*/ bool <AllowPreEpoch>k__BackingField;

                static /*0x72b4cac*/ UnixDateTimeConverter();
                /*0x72b4634*/ UnixDateTimeConverter();
                /*0x72b4650*/ UnixDateTimeConverter(bool allowPreEpoch);
                /*0x72b4620*/ bool get_AllowPreEpoch();
                /*0x72b4628*/ void set_AllowPreEpoch(bool value);
                /*0x72b467c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b48e0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class VersionConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x72b50fc*/ VersionConverter();
                /*0x72b4d28*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b4e10*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b5088*/ bool CanConvert(System.Type objectType);
            }

            class XmlDocumentWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocument _document;

                /*0x72b5104*/ XmlDocumentWrapper(System.Xml.XmlDocument document);
                /*0x72b5174*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string data);
                /*0x72b5208*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x72b529c*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x72b5330*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x72b53c4*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x72b5458*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x72b5534*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x72b5614*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x72b56b8*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x72b5774*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x72b5800*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x72b58d4*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x72b5990*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            class XmlElementWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlElement _element;

                /*0x72b5734*/ XmlElementWrapper(System.Xml.XmlElement element);
                /*0x72b5a20*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x72b5b08*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x72b5b2c*/ bool get_IsEmpty();
            }

            class XmlDeclarationWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDeclaration _declaration;

                /*0x72b54f4*/ XmlDeclarationWrapper(System.Xml.XmlDeclaration declaration);
                /*0x72b5b48*/ string get_Version();
                /*0x72b5b64*/ string get_Encoding();
                /*0x72b5b80*/ string get_Standalone();
            }

            class XmlDocumentTypeWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocumentType _documentType;

                /*0x72b55d4*/ XmlDocumentTypeWrapper(System.Xml.XmlDocumentType documentType);
                /*0x72b5b9c*/ string get_Name();
                /*0x72b5bbc*/ string get_System();
                /*0x72b5bd8*/ string get_Public();
                /*0x72b5bf4*/ string get_InternalSubset();
                /*0x72b5c10*/ string get_LocalName();
            }

            class XmlNodeWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.XmlNode _node;
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                static /*0x72b60e8*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node);
                /*0x72b5144*/ XmlNodeWrapper(System.Xml.XmlNode node);
                /*0x72b5c50*/ object get_WrappedNode();
                /*0x72b5c58*/ System.Xml.XmlNodeType get_NodeType();
                /*0x72b5c78*/ string get_LocalName();
                /*0x72b5c9c*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x72b62cc*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x72b6710*/ bool get_HasAttributes();
                /*0x72b67c4*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x72b6864*/ string get_Value();
                /*0x72b58b4*/ void set_Value(string value);
                /*0x72b6884*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x72b6944*/ string get_NamespaceUri();
            }

            interface IXmlDocument : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x3814c14*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x3814c50*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x3814b90*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x3814b90*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x3814b90*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x3814c14*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x38148bc*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            interface IXmlDeclaration : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x38148bc*/ string get_Version();
                /*0x38148bc*/ string get_Encoding();
                /*0x38148bc*/ string get_Standalone();
            }

            interface IXmlDocumentType : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x38148bc*/ string get_Name();
                /*0x38148bc*/ string get_System();
                /*0x38148bc*/ string get_Public();
                /*0x38148bc*/ string get_InternalSubset();
            }

            interface IXmlElement : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x3816710*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x3814a3c*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x3813ffc*/ bool get_IsEmpty();
            }

            interface IXmlNode
            {
                /*0x3814574*/ System.Xml.XmlNodeType get_NodeType();
                /*0x38148bc*/ string get_LocalName();
                /*0x38148bc*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x38148bc*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x38148bc*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x38148bc*/ string get_Value();
                /*0x3814a3c*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x38148bc*/ string get_NamespaceUri();
                /*0x38148bc*/ object get_WrappedNode();
            }

            class XDeclarationWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDeclaration <Declaration>k__BackingField;

                /*0x72b6970*/ XDeclarationWrapper(System.Xml.Linq.XDeclaration declaration);
                /*0x72b6968*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x72b69e0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x72b69e8*/ string get_Version();
                /*0x72b6a04*/ string get_Encoding();
                /*0x72b6a20*/ string get_Standalone();
            }

            class XDocumentTypeWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDocumentType _documentType;

                /*0x72b6a3c*/ XDocumentTypeWrapper(System.Xml.Linq.XDocumentType documentType);
                /*0x72b6a7c*/ string get_Name();
                /*0x72b6a98*/ string get_System();
                /*0x72b6ab4*/ string get_Public();
                /*0x72b6ad0*/ string get_InternalSubset();
                /*0x72b6aec*/ string get_LocalName();
            }

            class XDocumentWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x72b6ba4*/ XDocumentWrapper(System.Xml.Linq.XDocument document);
                /*0x72b6b2c*/ System.Xml.Linq.XDocument get_Document();
                /*0x72b6c04*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x72b7190*/ bool get_HasChildNodes();
                /*0x72b71f4*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x72b7290*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x72b732c*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x72b73c8*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x72b7464*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x72b7500*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x72b75a4*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x72b7650*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x72b7724*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x72b7804*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x72b78c4*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x72b79ac*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x72b7a7c*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
                /*0x72b7b24*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XTextWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72b7d1c*/ XTextWrapper(System.Xml.Linq.XText text);
                /*0x72b7ca4*/ System.Xml.Linq.XText get_Text();
                /*0x72b7d4c*/ string get_Value();
                /*0x72b7d68*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XCommentWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72b812c*/ XCommentWrapper(System.Xml.Linq.XComment text);
                /*0x72b80b4*/ System.Xml.Linq.XComment get_Text();
                /*0x72b815c*/ string get_Value();
                /*0x72b8178*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XProcessingInstructionWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72b76f4*/ XProcessingInstructionWrapper(System.Xml.Linq.XProcessingInstruction processingInstruction);
                /*0x72b81bc*/ System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction();
                /*0x72b8234*/ string get_LocalName();
                /*0x72b8250*/ string get_Value();
            }

            class XContainerWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;

                static /*0x72b7dac*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node);
                /*0x72b6bd4*/ XContainerWrapper(System.Xml.Linq.XContainer container);
                /*0x72b826c*/ System.Xml.Linq.XContainer get_Container();
                /*0x72b6d70*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x72b71cc*/ bool get_HasChildNodes();
                /*0x72b82e4*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x72b7bc8*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XObjectWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.Linq.XObject _xmlObject;

                /*0x72b69b0*/ XObjectWrapper(System.Xml.Linq.XObject xmlObject);
                /*0x72b8328*/ object get_WrappedNode();
                /*0x72b8330*/ System.Xml.XmlNodeType get_NodeType();
                /*0x72b8348*/ string get_LocalName();
                /*0x72b8350*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x72b83a8*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x72b8400*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x72b8408*/ string get_Value();
                /*0x72b8410*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x72b8448*/ string get_NamespaceUri();
            }

            class XAttributeWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x72b797c*/ XAttributeWrapper(System.Xml.Linq.XAttribute attribute);
                /*0x72b8450*/ System.Xml.Linq.XAttribute get_Attribute();
                /*0x72b84c8*/ string get_Value();
                /*0x72b84e4*/ string get_LocalName();
                /*0x72b8508*/ string get_NamespaceUri();
                /*0x72b852c*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XElementWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                /*0x72b77d4*/ XElementWrapper(System.Xml.Linq.XElement element);
                /*0x72b8570*/ System.Xml.Linq.XElement get_Element();
                /*0x72b85e8*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x72b8694*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x72b8c1c*/ bool HasImplicitNamespaceAttribute(string namespaceUri);
                /*0x72b9108*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x72b913c*/ string get_Value();
                /*0x72b9158*/ string get_LocalName();
                /*0x72b917c*/ string get_NamespaceUri();
                /*0x72b90c8*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x72b91a0*/ bool get_IsEmpty();
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

                static /*0x72c1220*/ XmlNodeConverter();
                static /*0x72bc914*/ bool AllSameName(Newtonsoft.Json.Converters.IXmlNode node);
                static /*0x72c00cc*/ void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, string attributeName, System.Xml.XmlNamespaceManager manager, string attributePrefix);
                static /*0x72be7a4*/ string ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader);
                /*0x72c1218*/ XmlNodeConverter();
                /*0x72b91bc*/ string get_DeserializeRootElementName();
                /*0x72b91c4*/ void set_DeserializeRootElementName(string value);
                /*0x72b91cc*/ bool get_WriteArrayAttribute();
                /*0x72b91d4*/ void set_WriteArrayAttribute(bool value);
                /*0x72b91e0*/ bool get_OmitRootObject();
                /*0x72b91e8*/ void set_OmitRootObject(bool value);
                /*0x72b91f4*/ bool get_EncodeSpecialCharacters();
                /*0x72b91fc*/ void set_EncodeSpecialCharacters(bool value);
                /*0x72b9208*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72b9348*/ Newtonsoft.Json.Converters.IXmlNode WrapXml(object value);
                /*0x72b9460*/ void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x72bb234*/ string ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x72bb550*/ string GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x72bb990*/ bool IsArray(Newtonsoft.Json.Converters.IXmlNode node);
                /*0x72bbd28*/ void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x72bc6d8*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames);
                /*0x72bc844*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, string elementNames);
                /*0x72b9ac8*/ void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x72bced8*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x72be1f8*/ void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x72bd72c*/ void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, System.Xml.XmlNamespaceManager manager);
                /*0x72c0448*/ void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string elementName, System.Xml.XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<string, string> attributeNameValues);
                /*0x72bf6d0*/ void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager);
                /*0x72c0c44*/ void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document);
                /*0x72bfa70*/ bool ShouldReadInto(Newtonsoft.Json.JsonReader reader);
                /*0x72bfab8*/ System.Collections.Generic.Dictionary<string, string> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager);
                /*0x72bee24*/ void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName);
                /*0x72bf2d8*/ void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x72c0a88*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName, Newtonsoft.Json.Converters.IXmlDocument document, string elementPrefix, System.Xml.XmlNamespaceManager manager);
                /*0x72bda74*/ void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x72c0f84*/ bool IsNamespaceAttribute(string attributeName, ref string prefix);
                /*0x72bcbc0*/ bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c);
                /*0x72c1070*/ bool CanConvert(System.Type valueType);
                /*0x72c1118*/ bool IsXObject(System.Type valueType);
                /*0x72c1198*/ bool IsXmlNode(System.Type valueType);
            }
        }

        namespace Bson
        {
            class BsonObjectId
            {
                /*0x10*/ byte[] <Value>k__BackingField;

                /*0x72c12c0*/ BsonObjectId(byte[] value);
                /*0x72c12b8*/ byte[] get_Value();
            }

            class BsonToken
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;

                /*0x72c13ac*/ BsonToken();
                /*0x38150f0*/ Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x72c13a4*/ void set_Parent(Newtonsoft.Json.Bson.BsonToken value);
            }

            class BsonObject : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;

                /*0x72c13b4*/ void Add(string name, Newtonsoft.Json.Bson.BsonToken token);
                /*0x72c155c*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonArray : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;

                /*0x72c1564*/ void Add(Newtonsoft.Json.Bson.BsonToken token);
                /*0x72c1620*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonValue : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ object _value;
                /*0x20*/ Newtonsoft.Json.Bson.BsonType _type;

                /*0x72c1628*/ BsonValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x72c1664*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonString : Newtonsoft.Json.Bson.BsonValue
            {
                /*0x21*/ bool <IncludeLength>k__BackingField;

                /*0x72c1518*/ BsonString(object value, bool includeLength);
            }

            class BsonRegex : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;
                /*0x20*/ Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;

                /*0x72c167c*/ BsonRegex(string pattern, string options);
                /*0x72c166c*/ void set_Pattern(Newtonsoft.Json.Bson.BsonString value);
                /*0x72c1674*/ void set_Options(Newtonsoft.Json.Bson.BsonString value);
                /*0x72c1750*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonProperty
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;

                /*0x72c1510*/ BsonProperty();
                /*0x72c1758*/ void set_Name(Newtonsoft.Json.Bson.BsonString value);
                /*0x72c1760*/ void set_Value(Newtonsoft.Json.Bson.BsonToken value);
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

                /*0x72c1768*/ void AddValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x72c17e8*/ void AddToken(Newtonsoft.Json.Bson.BsonToken token);
                /*0x72c19d0*/ void WriteObjectId(byte[] value);
                /*0x72b34c0*/ void WriteRegex(string pattern, string options);
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
