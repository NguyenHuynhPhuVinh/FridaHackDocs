class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x172e7a0*/ EmbeddedAttribute();
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
                /*0x1a9cb84*/ IsReadOnlyAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x20a1c78*/ NullableAttribute(byte );
                /*0x20a1d04*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x20a1d30*/ NullableContextAttribute(byte );
            }
        }
    }

    namespace Diagnostics
    {
        namespace CodeAnalysis
        {
            class NotNullAttribute : System.Attribute
            {
                /*0x20a1c40*/ NotNullAttribute();
            }

            class NotNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x20a1c48*/ NotNullWhenAttribute(bool returnValue);
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

            static /*0x172b7a0*/ DefaultJsonNameTable();
            static /*0x172b99c*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x1723b28*/ DefaultJsonNameTable();
            /*0x172b7f4*/ string Get(char[] key, int start, int length);
            /*0x172a860*/ string Add(string key);
            /*0x172ba5c*/ string AddEntry(string str, int hashCode);
            /*0x172bb80*/ void Grow();

            class Entry
            {
                /*0x10*/ string Value;
                /*0x18*/ int HashCode;
                /*0x20*/ Newtonsoft.Json.DefaultJsonNameTable.Entry Next;

                /*0x21fd69c*/ Entry(string value, int hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next);
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
            T[] Rent(int minimumLength);
            void Return(T[] array);
        }

        interface IJsonLineInfo
        {
            bool HasLineInfo();
            int get_LineNumber();
            int get_LinePosition();
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

            /*0x1ab6190*/ System.Type get_ItemConverterType();
            /*0x1ab6198*/ object[] get_ItemConverterParameters();
            /*0x1ab61a0*/ System.Type get_NamingStrategyType();
            /*0x1ab61a8*/ object[] get_NamingStrategyParameters();
            /*0x1ab61b0*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance();
            /*0x1ab61b8*/ void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value);
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

            static /*0x1ab7cec*/ JsonConvert();
            static /*0x1ab6e20*/ System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings();
            static /*0x1ab6e84*/ string ToString(bool value);
            static /*0x1ab6f14*/ string ToString(char value);
            static /*0x1ab7018*/ string ToString(float value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x1ab7240*/ string EnsureFloatFormat(double value, string text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x1ab7398*/ string ToString(double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x1ab711c*/ string EnsureDecimalPlace(double value, string text);
            static /*0x1ab7498*/ string EnsureDecimalPlace(string text);
            static /*0x1ab7518*/ string ToString(decimal value);
            static /*0x1ab6fb4*/ string ToString(string value);
            static /*0x1ab75d4*/ string ToString(string value, char delimiter);
            static /*0x1ab7648*/ string ToString(string value, char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
            static /*0x1ab7734*/ string SerializeObject(object value);
            static /*0x1ab779c*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1ab7828*/ string SerializeObjectInternal(object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer);
            static /*0x1ab7a84*/ object DeserializeObject(string value);
            static T DeserializeObject<T>(string value);
            static T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1ab7aec*/ object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
        }

        class JsonConverter
        {
            /*0x1ab7e20*/ JsonConverter();
            void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
            object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            bool CanConvert(System.Type objectType);
            /*0x1ab7e10*/ bool get_CanRead();
            /*0x1ab7e18*/ bool get_CanWrite();
        }

        class JsonConverterAttribute : System.Attribute
        {
            /*0x10*/ System.Type _converterType;
            /*0x18*/ object[] <ConverterParameters>k__BackingField;

            /*0x1ab7e38*/ JsonConverterAttribute(System.Type converterType);
            /*0x1ab7e28*/ System.Type get_ConverterType();
            /*0x1ab7e30*/ object[] get_ConverterParameters();
        }

        class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter>
        {
            /*0x1ab7f0c*/ JsonConverterCollection();
        }

        class JsonDictionaryAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
        }

        class JsonException : System.Exception
        {
            /*0x1ab9760*/ JsonException();
            /*0x1aa4490*/ JsonException(string message);
            /*0x1ab97c4*/ JsonException(string message, System.Exception innerException);
            /*0x1ab9840*/ JsonException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class JsonExtensionDataAttribute : System.Attribute
        {
            /*0x10*/ bool <WriteData>k__BackingField;
            /*0x11*/ bool <ReadData>k__BackingField;

            /*0x1ab98cc*/ bool get_WriteData();
            /*0x1ab98d4*/ bool get_ReadData();
        }

        class JsonIgnoreAttribute : System.Attribute
        {
            /*0x190f7c4*/ JsonIgnoreAttribute();
        }

        class JsonNameTable
        {
            /*0x190f810*/ JsonNameTable();
            string Get(char[] key, int start, int length);
        }

        class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
            /*0x50*/ Newtonsoft.Json.MemberSerialization _memberSerialization;
            /*0x54*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;
            /*0x5c*/ System.Nullable<Newtonsoft.Json.Required> _itemRequired;
            /*0x64*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;

            /*0x190f818*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
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

            static /*0x1910abc*/ JsonPosition();
            static /*0x19101e4*/ bool TypeHasIndex(Newtonsoft.Json.JsonContainerType type);
            static /*0x19104c4*/ string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition);
            static /*0x1910764*/ string FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message);
            /*0xaccdcc*/ JsonPosition(Newtonsoft.Json.JsonContainerType type);
            /*0xaccdd4*/ int CalculateLength();
            /*0xaccddc*/ void WriteTo(System.Text.StringBuilder sb, ref System.IO.StringWriter writer, ref char[] buffer);
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

            /*0x191143c*/ JsonPropertyAttribute(string propertyName);
            /*0x191140c*/ System.Type get_ItemConverterType();
            /*0x1911414*/ object[] get_ItemConverterParameters();
            /*0x191141c*/ System.Type get_NamingStrategyType();
            /*0x1911424*/ object[] get_NamingStrategyParameters();
            /*0x191142c*/ string get_PropertyName();
            /*0x1911434*/ void set_PropertyName(string value);
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

            /*0x1911ee8*/ JsonReader();
            /*0x19119a8*/ Newtonsoft.Json.JsonReader.State get_CurrentState();
            /*0x19119b0*/ bool get_CloseInput();
            /*0x19119b8*/ void set_CloseInput(bool value);
            /*0x19119c4*/ bool get_SupportMultipleContent();
            /*0x19119cc*/ void set_SupportMultipleContent(bool value);
            /*0x19119d8*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x19119e0*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x1911a44*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x1911a4c*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x1911ab0*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x1911ab8*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x1911b1c*/ string get_DateFormatString();
            /*0x1911b24*/ void set_DateFormatString(string value);
            /*0x1911b2c*/ System.Nullable<int> get_MaxDepth();
            /*0x1911b34*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x1911bf8*/ Newtonsoft.Json.JsonToken get_TokenType();
            /*0x1911c00*/ object get_Value();
            /*0x1911c08*/ System.Type get_ValueType();
            /*0x1911c1c*/ int get_Depth();
            /*0x1911c9c*/ string get_Path();
            /*0x1911dc8*/ System.Globalization.CultureInfo get_Culture();
            /*0x1911e3c*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x1911e44*/ Newtonsoft.Json.JsonPosition GetPosition(int depth);
            /*0x1911f7c*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x19121fc*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x19122fc*/ Newtonsoft.Json.JsonContainerType Peek();
            bool Read();
            /*0x1912304*/ System.Nullable<int> ReadAsInt32();
            /*0x1912980*/ System.Nullable<int> ReadInt32String(string s);
            /*0x1912bcc*/ string ReadAsString();
            /*0x1912ea8*/ byte[] ReadAsBytes();
            /*0x191355c*/ byte[] ReadArrayIntoByteArray();
            /*0x19136ac*/ bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<byte> buffer);
            /*0x19138a4*/ System.Nullable<double> ReadAsDouble();
            /*0x1913be8*/ System.Nullable<double> ReadDoubleString(string s);
            /*0x1913e4c*/ System.Nullable<bool> ReadAsBoolean();
            /*0x19141bc*/ System.Nullable<bool> ReadBooleanString(string s);
            /*0x1914410*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x191487c*/ System.Nullable<decimal> ReadDecimalString(string s);
            /*0x1914b5c*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x1914e20*/ System.Nullable<System.DateTime> ReadDateTimeString(string s);
            /*0x1915118*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x19153e4*/ System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s);
            /*0x191350c*/ void ReaderReadAndAssert();
            /*0x19156cc*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException();
            /*0x1913314*/ void ReadIntoWrappedTypeObject();
            /*0x191571c*/ void Skip();
            /*0x19136a0*/ void SetToken(Newtonsoft.Json.JsonToken newToken);
            /*0x19157b8*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value);
            /*0x191282c*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value, bool updateIndex);
            /*0x19158f0*/ void SetPostValueState(bool updateIndex);
            /*0x19121dc*/ void UpdateScopeWithFinishedValue();
            /*0x19157c0*/ void ValidateEnd(Newtonsoft.Json.JsonToken endToken);
            /*0x1915a24*/ void SetStateBasedOnCurrent();
            /*0x191592c*/ void SetFinished();
            /*0x1915954*/ Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token);
            /*0x1915b34*/ void System.IDisposable.Dispose();
            /*0x1915bb0*/ void Dispose(bool disposing);
            /*0x1915bd4*/ void Close();
            /*0x1915be8*/ void ReadAndAssert();
            /*0x1915c50*/ void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x1915cac*/ bool ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x1915f5c*/ bool ReadAndMoveToContent();
            /*0x1915f9c*/ bool MoveToContent();
            /*0x191272c*/ Newtonsoft.Json.JsonToken GetContentToken();

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
            /*0x88*/ int <LineNumber>k__BackingField;
            /*0x8c*/ int <LinePosition>k__BackingField;
            /*0x90*/ string <Path>k__BackingField;

            static /*0x19121f4*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x19127a4*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x1916054*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x1916000*/ JsonReaderException();
            /*0x1916008*/ JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1916010*/ JsonReaderException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
        }

        class JsonRequiredAttribute : System.Attribute
        {
            /*0x1916274*/ JsonRequiredAttribute();
        }

        class JsonSerializationException : Newtonsoft.Json.JsonException
        {
            /*0x88*/ int <LineNumber>k__BackingField;
            /*0x8c*/ int <LinePosition>k__BackingField;
            /*0x90*/ string <Path>k__BackingField;

            static /*0x1915c48*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x19162d8*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x1916360*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x191627c*/ JsonSerializationException();
            /*0x1911780*/ JsonSerializationException(string message);
            /*0x1916284*/ JsonSerializationException(string message, System.Exception innerException);
            /*0x191628c*/ JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1916294*/ JsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
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

            static /*0x1916f80*/ Newtonsoft.Json.JsonSerializer Create();
            static /*0x1916fd4*/ Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1917690*/ Newtonsoft.Json.JsonSerializer CreateDefault();
            static /*0x191774c*/ Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x191700c*/ void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1919504*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType);
            /*0x1916e2c*/ JsonSerializer();
            /*0x1916580*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x1916620*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x19166c0*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
            /*0x1916734*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
            /*0x19167a8*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x19167b0*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
            /*0x19167b8*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
            /*0x19167c0*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x1916824*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
            /*0x1916888*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
            /*0x19168ec*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x1916950*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x19169b4*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x19169bc*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x1916a20*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x1916a84*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x1916ae8*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
            /*0x1916b4c*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x1916b54*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
            /*0x1916bb8*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
            /*0x1916c20*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x1916c28*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
            /*0x1916cec*/ System.Runtime.Serialization.StreamingContext get_Context();
            /*0x1916cf8*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
            /*0x1916d00*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x1916d40*/ bool get_CheckAdditionalContent();
            /*0x1916d80*/ void set_CheckAdditionalContent(bool value);
            /*0x1916dec*/ bool IsCheckAdditionalContentSet();
            /*0x1917784*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
            /*0x1917794*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
            T Deserialize<T>(Newtonsoft.Json.JsonReader reader);
            /*0x19185e4*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x19185f4*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x1917a20*/ void SetupReader(Newtonsoft.Json.JsonReader reader, ref System.Globalization.CultureInfo previousCulture, ref System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, ref System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, ref System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, ref System.Nullable<int> previousMaxDepth, ref string previousDateFormatString);
            /*0x19183e8*/ void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<int> previousMaxDepth, string previousDateFormatString);
            /*0x1918bdc*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x1918bec*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value);
            /*0x1917dac*/ Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader);
            /*0x1918c00*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x1919494*/ Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver();
            /*0x19194fc*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type);
            /*0x1919674*/ void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e);
        }

        class JsonSerializerSettings
        {
            static Newtonsoft.Json.ReferenceLoopHandling DefaultReferenceLoopHandling = 0;
            static Newtonsoft.Json.MissingMemberHandling DefaultMissingMemberHandling = 0;
            static Newtonsoft.Json.NullValueHandling DefaultNullValueHandling = 0;
            static Newtonsoft.Json.DefaultValueHandling DefaultDefaultValueHandling = 0;
            static Newtonsoft.Json.ObjectCreationHandling DefaultObjectCreationHandling = 0;
            static Newtonsoft.Json.PreserveReferencesHandling DefaultPreserveReferencesHandling = 0;
            static Newtonsoft.Json.ConstructorHandling DefaultConstructorHandling = 0;
            static Newtonsoft.Json.TypeNameHandling DefaultTypeNameHandling = 0;
            static Newtonsoft.Json.MetadataPropertyHandling DefaultMetadataPropertyHandling = 0;
            static Newtonsoft.Json.Formatting DefaultFormatting = 0;
            static Newtonsoft.Json.DateFormatHandling DefaultDateFormatHandling = 0;
            static Newtonsoft.Json.DateTimeZoneHandling DefaultDateTimeZoneHandling = 3;
            static Newtonsoft.Json.DateParseHandling DefaultDateParseHandling = 1;
            static Newtonsoft.Json.FloatParseHandling DefaultFloatParseHandling = 0;
            static Newtonsoft.Json.FloatFormatHandling DefaultFloatFormatHandling = 0;
            static Newtonsoft.Json.StringEscapeHandling DefaultStringEscapeHandling = 0;
            static Newtonsoft.Json.TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0;
            static bool DefaultCheckAdditionalContent = false;
            static string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
            static int DefaultMaxDepth = 64;
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

            static /*0x208fac4*/ JsonSerializerSettings();
            /*0x208fb50*/ JsonSerializerSettings();
            /*0x208f6fc*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x208f73c*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x208f77c*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x208f7bc*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x208f7fc*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x208f868*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x208f8a8*/ System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters();
            /*0x208f8b0*/ void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value);
            /*0x208f8b8*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
            /*0x208f8f8*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x208f938*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x208f978*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
            /*0x208f9b8*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
            /*0x208f9f8*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x208fa00*/ System.Collections.IEqualityComparer get_EqualityComparer();
            /*0x208fa08*/ System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider();
            /*0x208fa10*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x208fa18*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
            /*0x208fa20*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error();
            /*0x208fa28*/ System.Runtime.Serialization.StreamingContext get_Context();
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

            static /*0x20907cc*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x2095fa0*/ object BigIntegerParse(string number, System.Globalization.CultureInfo culture);
            /*0x208fc4c*/ JsonTextReader(System.IO.TextReader reader);
            /*0x208fd68*/ Newtonsoft.Json.JsonNameTable get_PropertyNameTable();
            /*0x208fd70*/ void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value);
            /*0x208fd78*/ void EnsureBufferNotEmpty();
            /*0x208fdcc*/ void SetNewLine(bool hasNextChar);
            /*0x208fe38*/ void OnNewLine(int pos);
            /*0x208fe48*/ void ParseString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x2090448*/ void ParseReadString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x208fe9c*/ void ShiftBufferIfNeeded();
            /*0x20907e0*/ int ReadData(bool append);
            /*0x2090890*/ void PrepareBufferForReadData(bool append, int charsRequired);
            /*0x20907ec*/ int ReadData(bool append, int charsRequired);
            /*0x2090a34*/ bool EnsureChars(int relativePosition, bool append);
            /*0x2090a54*/ bool ReadChars(int relativePosition, bool append);
            /*0x2090ac8*/ bool Read();
            /*0x2091a48*/ System.Nullable<int> ReadAsInt32();
            /*0x2091ec4*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x209244c*/ string ReadAsString();
            /*0x20924b4*/ byte[] ReadAsBytes();
            /*0x2091f4c*/ object ReadStringValue(Newtonsoft.Json.ReadType readType);
            /*0x2092de8*/ object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType);
            /*0x2092b20*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(char c);
            /*0x2093314*/ System.Nullable<bool> ReadAsBoolean();
            /*0x2092ab0*/ void ProcessValueComma();
            /*0x2091ad0*/ object ReadNumberValue(Newtonsoft.Json.ReadType readType);
            /*0x2093894*/ object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType);
            /*0x2093a14*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x2093ab4*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x2093b54*/ System.Nullable<double> ReadAsDouble();
            /*0x20929c8*/ void HandleNull();
            /*0x2092c64*/ void ReadFinished();
            /*0x209296c*/ bool ReadNullChar();
            /*0x2090d34*/ void EnsureBuffer();
            /*0x208ff5c*/ void ReadStringIntoBuffer(char quote);
            /*0x2093d40*/ void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition);
            /*0x2093ce0*/ void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition);
            /*0x2093de4*/ char ConvertUnicode(bool enoughChars);
            /*0x2093c94*/ char ParseUnicode();
            /*0x2093f78*/ void ReadNumberIntoBuffer();
            /*0x2094010*/ bool ReadNumberCharIntoBuffer(char currentChar, int charPos);
            /*0x20941cc*/ void ClearRecentString();
            /*0x2091370*/ bool ParsePostValue(bool ignoreComments);
            /*0x20911cc*/ bool ParseObject();
            /*0x20941d8*/ bool ParseProperty();
            /*0x2094464*/ bool ValidIdentifierChar(char value);
            /*0x20944f0*/ void ParseUnquotedProperty();
            /*0x20945f4*/ bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition);
            /*0x2090d8c*/ bool ParseValue();
            /*0x2092c48*/ void ProcessLineFeed();
            /*0x2092bf4*/ void ProcessCarriageReturn(bool append);
            /*0x2091644*/ void EatWhitespace();
            /*0x2094954*/ void ParseConstructor();
            /*0x20930d8*/ void ParseNumber(Newtonsoft.Json.ReadType readType);
            /*0x2094da4*/ void ParseReadNumber(Newtonsoft.Json.ReadType readType, char firstChar, int initialPosition);
            /*0x2095f50*/ Newtonsoft.Json.JsonReaderException ThrowReaderError(string message, System.Exception ex);
            /*0x2091774*/ void ParseComment(bool setToken);
            /*0x2096034*/ void EndComment(bool setToken, int initialPosition, int endPosition);
            /*0x209607c*/ bool MatchValue(string value);
            /*0x20960dc*/ bool MatchValue(bool enoughChars, string value);
            /*0x209314c*/ bool MatchValueWithTrailingSeparator(string value);
            /*0x20961cc*/ bool IsSeparator(char c);
            /*0x2094778*/ void ParseTrue();
            /*0x2093bdc*/ void ParseNull();
            /*0x2094cec*/ void ParseUndefined();
            /*0x2094868*/ void ParseFalse();
            /*0x2093050*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType);
            /*0x2096340*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x2093204*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType);
            /*0x2096490*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x209328c*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType);
            /*0x20965e0*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x2096730*/ void Close();
            /*0x2096794*/ bool HasLineInfo();
            /*0x209679c*/ int get_LineNumber();
            /*0x20967f0*/ int get_LinePosition();
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

            /*0x209687c*/ JsonTextWriter(System.IO.TextWriter textWriter);
            /*0x20967fc*/ Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder();
            /*0x2096874*/ char get_QuoteChar();
            /*0x2096ab0*/ void Close();
            /*0x2096af0*/ void CloseBufferAndWriter();
            /*0x2096b48*/ void WriteStartObject();
            /*0x2096bd0*/ void WriteStartArray();
            /*0x2096c14*/ void WriteStartConstructor(string name);
            /*0x2096cc8*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x2096e08*/ void WritePropertyName(string name);
            /*0x2096f50*/ void WritePropertyName(string name, bool escape);
            /*0x209702c*/ void OnStringEscapeHandlingChanged();
            /*0x2096a30*/ void UpdateCharEscapeFlags();
            /*0x2097030*/ void WriteIndent();
            /*0x20971ec*/ int SetIndentChars();
            /*0x20972e0*/ void WriteValueDelimiter();
            /*0x2097308*/ void WriteIndentSpace();
            /*0x2097330*/ void WriteValueInternal(string value, Newtonsoft.Json.JsonToken token);
            /*0x2097354*/ void WriteValue(object value);
            /*0x20975f4*/ void WriteNull();
            /*0x2097694*/ void WriteUndefined();
            /*0x2097734*/ void WriteRaw(string json);
            /*0x209775c*/ void WriteValue(string value);
            /*0x2096e70*/ void WriteEscapedString(string value, bool quote);
            /*0x2097864*/ void WriteValue(int value);
            /*0x20978fc*/ void WriteValue(uint value);
            /*0x2097994*/ void WriteValue(long value);
            /*0x20979dc*/ void WriteValue(ulong value);
            /*0x2097aa8*/ void WriteValue(float value);
            /*0x2097b78*/ void WriteValue(System.Nullable<float> value);
            /*0x2097c90*/ void WriteValue(double value);
            /*0x2097d60*/ void WriteValue(System.Nullable<double> value);
            /*0x2097e7c*/ void WriteValue(bool value);
            /*0x2097f30*/ void WriteValue(short value);
            /*0x2097f78*/ void WriteValue(ushort value);
            /*0x2097fc0*/ void WriteValue(char value);
            /*0x2098074*/ void WriteValue(byte value);
            /*0x20980bc*/ void WriteValue(sbyte value);
            /*0x2098104*/ void WriteValue(decimal value);
            /*0x20981c0*/ void WriteValue(System.DateTime value);
            /*0x2098334*/ int WriteValueToBuffer(System.DateTime value);
            /*0x20984c4*/ void WriteValue(byte[] value);
            /*0x2098590*/ void WriteValue(System.DateTimeOffset value);
            /*0x20986bc*/ int WriteValueToBuffer(System.DateTimeOffset value);
            /*0x2098810*/ void WriteValue(System.Guid value);
            /*0x2098928*/ void WriteValue(System.TimeSpan value);
            /*0x2098a2c*/ void WriteValue(System.Uri value);
            /*0x2098b08*/ void WriteComment(string text);
            /*0x2097828*/ void EnsureWriteBuffer();
            /*0x2097944*/ void WriteIntegerValue(long value);
            /*0x2097a28*/ void WriteIntegerValue(ulong value, bool negative);
            /*0x2098bd4*/ int WriteNumberToBuffer(ulong value, bool negative);
            /*0x20978ac*/ void WriteIntegerValue(int value);
            /*0x2098f58*/ void WriteIntegerValue(uint value, bool negative);
            /*0x2098cc4*/ int WriteNumberToBuffer(uint value, bool negative);
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

            static /*0x209b0b8*/ JsonWriter();
            static /*0x209ae8c*/ Newtonsoft.Json.JsonWriter.State[][] BuildStateArray();
            static /*0x209dd80*/ void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value);
            static /*0x209ef9c*/ void ResolveConvertibleValue(System.IConvertible convertible, ref Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, ref object value);
            static /*0x209dcc0*/ Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, object value);
            /*0x20969f8*/ JsonWriter();
            /*0x209b420*/ bool get_CloseOutput();
            /*0x209b428*/ void set_CloseOutput(bool value);
            /*0x209b434*/ bool get_AutoCompleteOnClose();
            /*0x209b43c*/ void set_AutoCompleteOnClose(bool value);
            /*0x2097198*/ int get_Top();
            /*0x209b450*/ Newtonsoft.Json.WriteState get_WriteState();
            /*0x209b518*/ string get_ContainerPath();
            /*0x209b5d0*/ string get_Path();
            /*0x209b700*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x209b708*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x209b76c*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0x209b774*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0x209b7d8*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x209b7e0*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x209b844*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0x209b84c*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0x209b8b8*/ void OnStringEscapeHandlingChanged();
            /*0x209b8bc*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0x209b8c4*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0x209b928*/ string get_DateFormatString();
            /*0x209b930*/ void set_DateFormatString(string value);
            /*0x2098450*/ System.Globalization.CultureInfo get_Culture();
            /*0x209b938*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x209b940*/ void UpdateScopeWithFinishedValue();
            /*0x209b958*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x209ba80*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x209b448*/ Newtonsoft.Json.JsonContainerType Peek();
            /*0x2096ae0*/ void Close();
            /*0x209bbb0*/ void WriteStartObject();
            /*0x209bbbc*/ void WriteEndObject();
            /*0x209bbc8*/ void WriteStartArray();
            /*0x209bbd4*/ void WriteEndArray();
            /*0x209bbdc*/ void WriteStartConstructor(string name);
            /*0x209bbe8*/ void WriteEndConstructor();
            /*0x209bbf0*/ void WritePropertyName(string name);
            /*0x209bc00*/ void WritePropertyName(string name, bool escape);
            /*0x209bc10*/ void WriteEnd();
            /*0x209bd00*/ void WriteToken(Newtonsoft.Json.JsonReader reader);
            /*0x209bd08*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren);
            /*0x209bd8c*/ void WriteToken(Newtonsoft.Json.JsonToken token, object value);
            /*0x209c598*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            /*0x209c8c8*/ bool IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, bool writeChildren, int initialDepth);
            /*0x209c798*/ int CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader);
            /*0x209c940*/ int CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader);
            /*0x209c7f4*/ void WriteConstructorDate(Newtonsoft.Json.JsonReader reader);
            /*0x209bc18*/ void WriteEnd(Newtonsoft.Json.JsonContainerType type);
            /*0x209bb30*/ void AutoCompleteAll();
            /*0x209c9a0*/ Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type);
            /*0x209ca60*/ void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type);
            /*0x209cb28*/ int CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type);
            /*0x209cc7c*/ void UpdateCurrentState();
            /*0x209cd48*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0x209cd4c*/ void WriteIndent();
            /*0x209cd50*/ void WriteValueDelimiter();
            /*0x209cd54*/ void WriteIndentSpace();
            /*0x209cd58*/ void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten);
            /*0x209cfd8*/ void WriteNull();
            /*0x209cff4*/ void WriteUndefined();
            /*0x209d010*/ void WriteRaw(string json);
            /*0x209d014*/ void WriteRawValue(string json);
            /*0x209d068*/ void WriteValue(string value);
            /*0x209d084*/ void WriteValue(int value);
            /*0x209d0a0*/ void WriteValue(uint value);
            /*0x209d0bc*/ void WriteValue(long value);
            /*0x209d0d8*/ void WriteValue(ulong value);
            /*0x209d0f4*/ void WriteValue(float value);
            /*0x209d110*/ void WriteValue(double value);
            /*0x209d12c*/ void WriteValue(bool value);
            /*0x209d148*/ void WriteValue(short value);
            /*0x209d164*/ void WriteValue(ushort value);
            /*0x209d180*/ void WriteValue(char value);
            /*0x209d19c*/ void WriteValue(byte value);
            /*0x209d1b8*/ void WriteValue(sbyte value);
            /*0x209d1d4*/ void WriteValue(decimal value);
            /*0x209d1f0*/ void WriteValue(System.DateTime value);
            /*0x209d20c*/ void WriteValue(System.DateTimeOffset value);
            /*0x209d228*/ void WriteValue(System.Guid value);
            /*0x209d244*/ void WriteValue(System.TimeSpan value);
            /*0x209d260*/ void WriteValue(System.Nullable<int> value);
            /*0x209d2ec*/ void WriteValue(System.Nullable<uint> value);
            /*0x209d378*/ void WriteValue(System.Nullable<long> value);
            /*0x209d408*/ void WriteValue(System.Nullable<ulong> value);
            /*0x209d498*/ void WriteValue(System.Nullable<float> value);
            /*0x209d524*/ void WriteValue(System.Nullable<double> value);
            /*0x209d5b8*/ void WriteValue(System.Nullable<bool> value);
            /*0x209d64c*/ void WriteValue(System.Nullable<short> value);
            /*0x209d6d8*/ void WriteValue(System.Nullable<ushort> value);
            /*0x209d764*/ void WriteValue(System.Nullable<char> value);
            /*0x209d7f0*/ void WriteValue(System.Nullable<byte> value);
            /*0x209d87c*/ void WriteValue(System.Nullable<sbyte> value);
            /*0x209d908*/ void WriteValue(System.Nullable<decimal> value);
            /*0x209d998*/ void WriteValue(System.Nullable<System.DateTime> value);
            /*0x209da28*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
            /*0x209dab8*/ void WriteValue(System.Nullable<System.Guid> value);
            /*0x209db48*/ void WriteValue(System.Nullable<System.TimeSpan> value);
            /*0x209dbd8*/ void WriteValue(byte[] value);
            /*0x209dc08*/ void WriteValue(System.Uri value);
            /*0x2097484*/ void WriteValue(object value);
            /*0x209eef8*/ void WriteComment(string text);
            /*0x209ef00*/ void System.IDisposable.Dispose();
            /*0x209ef7c*/ void Dispose(bool disposing);
            /*0x209f158*/ void SetWriteState(Newtonsoft.Json.JsonToken token, object value);
            /*0x209bbc4*/ void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container);
            /*0x2096e60*/ void InternalWritePropertyName(string name);
            /*0x2097758*/ void InternalWriteRaw();
            /*0x2096b8c*/ void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container);
            /*0x209746c*/ void InternalWriteValue(Newtonsoft.Json.JsonToken token);
            /*0x2098bcc*/ void InternalWriteComment();

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
            /*0x88*/ string <Path>k__BackingField;

            static /*0x2096dd4*/ Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, string message, System.Exception ex);
            static /*0x209f350*/ Newtonsoft.Json.JsonWriterException Create(string path, string message, System.Exception ex);
            /*0x209f310*/ JsonWriterException();
            /*0x209f318*/ JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x209f320*/ JsonWriterException(string message, string path, System.Exception innerException);
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
            class AotHelper
            {
                static /*0x0*/ bool s_alwaysFalse;

                static /*0x17170b0*/ AotHelper();
                static /*0x1716ed0*/ void Ensure(System.Action action);
                static void EnsureType<T>();
                static /*0x171704c*/ bool IsFalse();

                class <>c__<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.AotHelper.<>c__1<T> <>9;
                    static /*0x0*/ System.Action <>9__1_0;

                    static <>c__();
                    <>c__();
                    void <EnsureType>b__1_0();
                }
            }

            class Base64Encoder
            {
                /*0x10*/ char[] _charsLine;
                /*0x18*/ System.IO.TextWriter _writer;
                /*0x20*/ byte[] _leftOverBytes;
                /*0x28*/ int _leftOverBytesCount;

                /*0x1717148*/ Base64Encoder(System.IO.TextWriter writer);
                /*0x17171dc*/ void ValidateEncode(byte[] buffer, int index, int count);
                /*0x17172ac*/ void Encode(byte[] buffer, int index, int count);
                /*0x1717530*/ void StoreLeftOverBytes(byte[] buffer, int index, ref int count);
                /*0x1717460*/ bool FulfillFromLeftover(byte[] buffer, int index, ref int count);
                /*0x1717664*/ void Flush();
                /*0x171750c*/ void WriteChars(char[] chars, int index, int count);
            }

            class BidirectionalDictionary<System.Runtime.CompilerServices.CallSite<T>, TSecond>
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TFirst, TSecond> _firstToSecond;
                /*0x0*/ System.Collections.Generic.IDictionary<TSecond, TFirst> _secondToFirst;
                /*0x0*/ string _duplicateFirstErrorMessage;
                /*0x0*/ string _duplicateSecondErrorMessage;

                BidirectionalDictionary(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage);
                void Set(TFirst first, TSecond second);
                bool TryGetByFirst(TFirst first, ref TSecond second);
                bool TryGetBySecond(TSecond second, ref TFirst first);
            }

            class CollectionUtils
            {
                static bool IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection);
                static void AddRange<T>(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection);
                static /*0x1719268*/ bool IsDictionaryType(System.Type type);
                static /*0x1719434*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType);
                static /*0x1719558*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType);
                static int IndexOf<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, bool> predicate);
                static bool Contains<T>(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer);
                static int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
                static void FastReverse<T>(System.Collections.Generic.List<T> list);
                static /*0x17198bc*/ System.Collections.Generic.IList<int> GetDimensions(System.Collections.IList values, int dimensionsCount);
                static /*0x1719ba4*/ void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, int[] indices);
                static /*0x1719e80*/ object JaggedArrayGetValue(System.Collections.IList values, int[] indices);
                static /*0x1719fd0*/ System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, int rank);
                static T[] ArrayEmpty<T>();

                class EmptyArrayContainer<T>
                {
                    static /*0x0*/ T[] Empty;

                    static EmptyArrayContainer();
                }
            }

            interface IWrappedCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                object get_UnderlyingCollection();
            }

            class CollectionWrapper<T>
            {
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

                /*0x21ef7ac*/ TypeInformation(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode);
                /*0x21ef79c*/ System.Type get_Type();
                /*0x21ef7a4*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
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

                static /*0x171d1d4*/ ConvertUtils();
                static /*0x171a1f4*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t);
                static /*0x171a268*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, ref bool isEnum);
                static /*0x171a518*/ Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable);
                static /*0x171a620*/ bool IsConvertible(System.Type t);
                static /*0x171a6b8*/ System.TimeSpan ParseTimeSpan(string input);
                static /*0x171a75c*/ System.Func<object, object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type> t);
                static /*0x171a9c0*/ System.Numerics.BigInteger ToBigInteger(object value);
                static /*0x171ad70*/ object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType);
                static /*0x171b2fc*/ bool TryConvert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x171b410*/ Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0x171c274*/ object ConvertOrCast(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0x171c00c*/ object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType);
                static /*0x171bf98*/ bool VersionTryParse(string input, ref System.Version result);
                static /*0x171befc*/ bool IsInteger(object value);
                static /*0x171c41c*/ Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, ref int value);
                static /*0x171c5a4*/ Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, ref long value);
                static /*0x171c714*/ Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, ref decimal value);
                static /*0x171d088*/ bool TryConvertGuid(string s, ref System.Guid g);
                static /*0x171d114*/ bool TryHexTextToInt(char[] text, int start, int end, ref int value);

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

                    /*0x21fc778*/ <>c__DisplayClass8_0();
                    /*0x21fc780*/ object <CreateCastConverter>b__0(object o);
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

                static /*0x171feac*/ DateTimeParser();
                /*0xac34a0*/ bool Parse(char[] text, int startIndex, int length);
                /*0xac34a8*/ bool ParseDate(int start);
                /*0xac34b0*/ bool ParseTimeAndZoneAndWhitespace(int start);
                /*0xac34b8*/ bool ParseTime(ref int start);
                /*0xac34c0*/ bool ParseZone(int start);
                /*0xac34c8*/ bool Parse4Digit(int start, ref int num);
                /*0xac34d0*/ bool Parse2Digit(int start, ref int num);
                /*0xac34d8*/ bool ParseChar(int start, char ch);
            }

            class DateTimeUtils
            {
                static /*0x0*/ long InitialJavaScriptDateTicks;
                static /*0x8*/ int[] DaysToMonth365;
                static /*0x10*/ int[] DaysToMonth366;

                static /*0x1720b40*/ DateTimeUtils();
                static /*0x1720c30*/ System.TimeSpan GetUtcOffset(System.DateTime d);
                static /*0x1720c64*/ System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind);
                static /*0x1720cf0*/ System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone);
                static /*0x1720e2c*/ System.DateTime SwitchToLocalTime(System.DateTime value);
                static /*0x1720eac*/ System.DateTime SwitchToUtcTime(System.DateTime value);
                static /*0x1720f2c*/ long ToUniversalTicks(System.DateTime dateTime);
                static /*0x1720fc4*/ long ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x17210e0*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0x17211dc*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime);
                static /*0x1721240*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, bool convertToUtc);
                static /*0x1721154*/ long UniversalTicksToJavaScriptTicks(long universalTicks);
                static /*0x17212f4*/ System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks);
                static /*0x1721388*/ bool TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x17217e8*/ bool TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x172175c*/ System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser);
                static /*0x1721998*/ bool TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x1721e70*/ bool TryParseDateTime(string s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x1722174*/ bool TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x17225d0*/ bool TryParseDateTimeOffset(string s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x17228e8*/ bool TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, ref long ticks, ref System.TimeSpan offset, ref System.DateTimeKind kind);
                static /*0x1721bf4*/ bool TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0x1721d74*/ bool TryParseDateTimeExact(string text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0x17223b8*/ bool TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0x1722514*/ bool TryParseDateTimeOffsetExact(string text, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0x1722a80*/ bool TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, int startIndex, ref System.TimeSpan offset);
                static /*0x1722c14*/ void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x1722d60*/ int WriteDateTimeString(char[] chars, int start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format);
                static /*0x1723274*/ int WriteDefaultIsoDate(char[] chars, int start, System.DateTime dt);
                static /*0x1723774*/ void CopyIntToCharArray(char[] chars, int start, int value, int digits);
                static /*0x17230d0*/ int WriteDateTimeOffset(char[] chars, int start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format);
                static /*0x17237e8*/ void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0x172352c*/ void GetDateValues(System.DateTime td, ref int year, ref int month, ref int day);
            }

            interface IWrappedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                object get_UnderlyingDictionary();
            }

            class DictionaryWrapper<TKey, TValue>
            {
            }

            class DynamicProxy<T>
            {
                DynamicProxy();
                System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(T instance);
            }

            class DynamicProxyMetaObject<T> : System.Dynamic.DynamicMetaObject
            {
                /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;

                static System.Linq.Expressions.Expression[] get_NoArgs();
                static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args);
                static System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder);
                DynamicProxyMetaObject(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy);
                bool IsOverridden(string method);
                System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder);
                System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value);
                System.Dynamic.DynamicMetaObject CallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                System.Dynamic.DynamicMetaObject CallMethodReturnLast(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                System.Dynamic.BindingRestrictions GetRestrictions();
                System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames();

                class Fallback<T> : System.MulticastDelegate
                {
                    Fallback(object object, nint method);
                    System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion);
                    System.IAsyncResult BeginInvoke(System.Dynamic.DynamicMetaObject errorSuggestion, System.AsyncCallback callback, object object);
                    System.Dynamic.DynamicMetaObject EndInvoke(System.IAsyncResult result);
                }

                class <>c__DisplayClass3_0<T>
                {
                    /*0x0*/ System.Dynamic.GetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    <>c__DisplayClass3_0();
                    System.Dynamic.DynamicMetaObject <BindGetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Dynamic.SetMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    <>c__DisplayClass4_0();
                    System.Dynamic.DynamicMetaObject <BindSetMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Dynamic.DynamicMetaObject, System.Linq.Expressions.Expression> <>9__18_0;

                    static <>c();
                    <>c();
                    System.Linq.Expressions.Expression <GetArgs>b__18_0(System.Dynamic.DynamicMetaObject arg);
                }
            }

            class DynamicUtils
            {
                static /*0x172e6a8*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider);

                class BinderWrapper
                {
                    static /*0x0*/ object _getCSharpArgumentInfoArray;
                    static /*0x8*/ object _setCSharpArgumentInfoArray;
                    static /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _getMemberCall;
                    static /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _setMemberCall;
                    static /*0x20*/ bool _init;

                    static /*0x21fd7c4*/ void Init();
                    static /*0x21fd9d4*/ object CreateSharpArgumentInfoArray(int[] values);
                    static /*0x21fdcc0*/ void CreateMemberCalls();
                    static /*0x21fe1b0*/ System.Runtime.CompilerServices.CallSiteBinder GetMember(string name, System.Type context);
                    static /*0x21fe3a8*/ System.Runtime.CompilerServices.CallSiteBinder SetMember(string name, System.Type context);
                }
            }

            class NoThrowGetBinderMember : System.Dynamic.GetMemberBinder
            {
                /*0x28*/ System.Dynamic.GetMemberBinder _innerBinder;

                /*0x20a18f4*/ NoThrowGetBinderMember(System.Dynamic.GetMemberBinder innerBinder);
                /*0x20a1930*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowSetBinderMember : System.Dynamic.SetMemberBinder
            {
                /*0x28*/ System.Dynamic.SetMemberBinder _innerBinder;

                /*0x20a1ab0*/ NoThrowSetBinderMember(System.Dynamic.SetMemberBinder innerBinder);
                /*0x20a1aec*/ System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
            {
                static /*0x0*/ object ErrorResult;

                static /*0x20a1880*/ NoThrowExpressionVisitor();
                /*0x20a1878*/ NoThrowExpressionVisitor();
                /*0x20a176c*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node);
            }

            class EnumInfo
            {
                /*0x10*/ bool IsFlags;
                /*0x18*/ ulong[] Values;
                /*0x20*/ string[] Names;
                /*0x28*/ string[] ResolvedNames;

                /*0x172f0cc*/ EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames);
            }

            class EnumUtils
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy>, Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;
                static /*0x8*/ Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;

                static /*0x1730874*/ EnumUtils();
                static /*0x172f120*/ Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy> key);
                static /*0x172f9e0*/ bool TryToString(System.Type enumType, object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, ref string name);
                static /*0x172fb78*/ string InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, ulong result);
                static /*0x172fd1c*/ Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType);
                static /*0x172f69c*/ ulong ToUInt64(object value);
                static /*0x172fde4*/ object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, string value, bool disallowNumber);
                static /*0x1730788*/ System.Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, System.StringComparison comparison);
                static /*0x1730684*/ System.Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, System.StringComparison comparison);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.EnumUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Runtime.Serialization.EnumMemberAttribute, string> <>9__3_0;

                    static /*0x21fe5a0*/ <>c();
                    /*0x21fe600*/ <>c();
                    /*0x21fe608*/ string <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a);
                }
            }

            class FSharpFunction
            {
                /*0x10*/ object _instance;
                /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _invoker;

                /*0x17317ac*/ FSharpFunction(object instance, Newtonsoft.Json.Utilities.MethodCall<object, object> invoker);
                /*0x172d92c*/ object Invoke(object[] args);
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

                static /*0x1732308*/ FSharpUtils();
                static /*0x1731f4c*/ Newtonsoft.Json.Utilities.FSharpUtils get_Instance();
                static /*0x172e388*/ void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly);
                static /*0x1731cc0*/ System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, System.Reflection.BindingFlags bindingFlags);
                static /*0x1731d38*/ Newtonsoft.Json.Utilities.MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName);
                /*0x17317e4*/ FSharpUtils(System.Reflection.Assembly fsharpCoreAssembly);
                /*0x1731fb0*/ void set_FSharpCoreAssembly(System.Reflection.Assembly value);
                /*0x1731fb8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_IsUnion();
                /*0x1731fc0*/ void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x1731fc8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCases();
                /*0x1731fd0*/ void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x1731fd8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionTagReader();
                /*0x1731fe0*/ void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x1731fe8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionReader();
                /*0x1731ff0*/ void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x1731ff8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionConstructor();
                /*0x1732000*/ void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x1732008*/ System.Func<object, object> get_GetUnionCaseInfoDeclaringType();
                /*0x1732010*/ void set_GetUnionCaseInfoDeclaringType(System.Func<object, object> value);
                /*0x1732018*/ System.Func<object, object> get_GetUnionCaseInfoName();
                /*0x1732020*/ void set_GetUnionCaseInfoName(System.Func<object, object> value);
                /*0x1732028*/ System.Func<object, object> get_GetUnionCaseInfoTag();
                /*0x1732030*/ void set_GetUnionCaseInfoTag(System.Func<object, object> value);
                /*0x1732038*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCaseInfoFields();
                /*0x1732040*/ void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0x1732048*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateSeq(System.Type t);
                /*0x1732158*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType);
                Newtonsoft.Json.Serialization.ObjectConstructor<object> BuildMapCreator<TKey, TValue>();

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;
                    /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> invoke;

                    /*0x21fe620*/ <>c__DisplayClass52_0();
                    /*0x21fe628*/ object <CreateFSharpFuncCall>b__0(object target, object[] args);
                }

                class <>c__DisplayClass55_0<TKey, TValue>
                {
                    /*0x0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> ctorDelegate;

                    <>c__DisplayClass55_0();
                    object <BuildMapCreator>b__0(object[] args);
                }

                class <>c__55<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Tuple<TKey, TValue>> <>9__55_1;

                    static <>c__55();
                    <>c__55();
                    System.Tuple<TKey, TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey, TValue> kv);
                }
            }

            class ImmutableCollectionsUtils
            {
                static /*0x0*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;
                static /*0x8*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

                static /*0x1a9c67c*/ ImmutableCollectionsUtils();
                static /*0x1a9bce8*/ bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);
                static /*0x1a9c184*/ bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);

                class ImmutableCollectionTypeInfo
                {
                    /*0x10*/ string <ContractTypeName>k__BackingField;
                    /*0x18*/ string <CreatedTypeName>k__BackingField;
                    /*0x20*/ string <BuilderTypeName>k__BackingField;

                    /*0x21fe9a0*/ ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName);
                    /*0x21fe9e0*/ string get_ContractTypeName();
                    /*0x21fe9e8*/ void set_ContractTypeName(string value);
                    /*0x21fe9f0*/ string get_CreatedTypeName();
                    /*0x21fe9f8*/ void set_CreatedTypeName(string value);
                    /*0x21fea00*/ string get_BuilderTypeName();
                    /*0x21fea08*/ void set_BuilderTypeName(string value);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string name;

                    /*0x21fe948*/ <>c__DisplayClass24_0();
                    /*0x21fe950*/ bool <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__24_1;
                    static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__25_1;

                    static /*0x21fe6d8*/ <>c();
                    /*0x21fe738*/ <>c();
                    /*0x21fe740*/ bool <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m);
                    /*0x21fe7d8*/ bool <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m);
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ string name;

                    /*0x21fe974*/ <>c__DisplayClass25_0();
                    /*0x21fe97c*/ bool <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }
            }

            class BufferUtils
            {
                static /*0x1718ec0*/ char[] RentBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int minSize);
                static /*0x1718fa0*/ void ReturnBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer);
                static /*0x1719068*/ char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int size, char[] buffer);
            }

            class JavaScriptUtils
            {
                static /*0x0*/ bool[] SingleQuoteCharEscapeFlags;
                static /*0x8*/ bool[] DoubleQuoteCharEscapeFlags;
                static /*0x10*/ bool[] HtmlCharEscapeFlags;

                static /*0x1ab3120*/ JavaScriptUtils();
                static /*0x1ab3b60*/ bool[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, char quoteChar);
                static /*0x1ab3c38*/ bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags);
                static /*0x1ab3cd4*/ void WriteEscapedJavaScriptString(System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<char> bufferPool, ref char[] writeBuffer);
                static /*0x1ab438c*/ string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x1ab42c4*/ int FirstCharToEscape(string s, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0x1ab2d6c*/ bool TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, ref System.DateTime dateTime, ref string errorMessage);
                static /*0x1ab4588*/ bool TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, ref System.Nullable<long> integer, ref string errorMessage);
            }

            class JsonTokenUtils
            {
                static /*0x2098fd8*/ bool IsEndToken(Newtonsoft.Json.JsonToken token);
                static /*0x2098fe8*/ bool IsStartToken(Newtonsoft.Json.JsonToken token);
                static /*0x2098ff8*/ bool IsPrimitiveToken(Newtonsoft.Json.JsonToken token);
            }

            class LateBoundReflectionDelegateFactory : Newtonsoft.Json.Utilities.ReflectionDelegateFactory
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

                static /*0x20a0d34*/ LateBoundReflectionDelegateFactory();
                static /*0x20a0b60*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance();
                /*0x20a0d24*/ LateBoundReflectionDelegateFactory();
                /*0x20a0bc4*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.Reflection.ConstructorInfo c;
                    /*0x18*/ System.Reflection.MethodBase method;

                    /*0x21ffbd4*/ <>c__DisplayClass3_0();
                    /*0x21ffbdc*/ object <CreateParameterizedConstructor>b__0(object[] a);
                    /*0x21ffbf8*/ object <CreateParameterizedConstructor>b__1(object[] a);
                }

                class <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ System.Reflection.ConstructorInfo c;
                    /*0x0*/ System.Reflection.MethodBase method;

                    <>c__DisplayClass4_0();
                    object <CreateMethodCall>b__0(T o, object[] a);
                    object <CreateMethodCall>b__1(T o, object[] a);
                }

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Type type;
                    /*0x0*/ System.Reflection.ConstructorInfo constructorInfo;

                    <>c__DisplayClass5_0();
                    T <CreateDefaultConstructor>b__0();
                    T <CreateDefaultConstructor>b__1();
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    <>c__DisplayClass6_0();
                    object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass7_0();
                    object <CreateGet>b__0(T o);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass8_0();
                    void <CreateSet>b__0(T o, object v);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    <>c__DisplayClass9_0();
                    void <CreateSet>b__0(T o, object v);
                }
            }

            class MathUtils
            {
                static /*0x2098d90*/ int IntLength(ulong i);
                static /*0x20a0d94*/ char IntToHex(int n);
                static /*0x20a0dac*/ bool ApproxEquals(double d1, double d2);
            }

            class MethodCall<T, TResult> : System.MulticastDelegate
            {
                MethodCall(object object, nint method);
                TResult Invoke(T target, object[] args);
                System.IAsyncResult BeginInvoke(T target, object[] args, System.AsyncCallback callback, object object);
                TResult EndInvoke(System.IAsyncResult result);
            }

            class MiscellaneousUtils
            {
                static /*0x20a0e60*/ bool ValueEquals(object objA, object objB);
                static /*0x209c498*/ System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message);
                static /*0x20a117c*/ string ToString(object value);
                static /*0x20a1230*/ int ByteArrayCompare(byte[] a1, byte[] a2);
                static /*0x20a12f0*/ string GetPrefix(string qualifiedName);
                static /*0x20a13b4*/ string GetLocalName(string qualifiedName);
                static /*0x20a131c*/ void GetQualifiedNameParts(string qualifiedName, ref string prefix, ref string localName);
                static /*0x20a13e0*/ System.Text.RegularExpressions.RegexOptions GetRegexOptions(string optionsText);
            }

            class ReflectionDelegateFactory
            {
                /*0x20a0d2c*/ ReflectionDelegateFactory();
                System.Func<T, object> CreateGet<T>(System.Reflection.MemberInfo memberInfo);
                System.Action<T, object> CreateSet<T>(System.Reflection.MemberInfo memberInfo);
                Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<T>(System.Reflection.MethodBase method);
                Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
                System.Func<T> CreateDefaultConstructor<T>(System.Type type);
                System.Func<T, object> CreateGet<T>(System.Reflection.PropertyInfo propertyInfo);
                System.Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
                System.Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
                System.Action<T, object> CreateSet<T>(System.Reflection.PropertyInfo propertyInfo);
            }

            class ReflectionMember
            {
                /*0x10*/ System.Type <MemberType>k__BackingField;
                /*0x18*/ System.Func<object, object> <Getter>k__BackingField;
                /*0x20*/ System.Action<object, object> <Setter>k__BackingField;

                /*0x20a1dfc*/ ReflectionMember();
                /*0x20a1dcc*/ System.Type get_MemberType();
                /*0x20a1dd4*/ void set_MemberType(System.Type value);
                /*0x20a1ddc*/ System.Func<object, object> get_Getter();
                /*0x20a1de4*/ void set_Getter(System.Func<object, object> value);
                /*0x20a1dec*/ System.Action<object, object> get_Setter();
                /*0x20a1df4*/ void set_Setter(System.Action<object, object> value);
            }

            class ReflectionObject
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <Creator>k__BackingField;
                /*0x18*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;

                static /*0x209aa4c*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, string[] memberNames);
                static /*0x209f758*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, string[] memberNames);
                /*0x20a1e14*/ ReflectionObject(Newtonsoft.Json.Serialization.ObjectConstructor<object> creator);
                /*0x20a1e04*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_Creator();
                /*0x20a1e0c*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> get_Members();
                /*0x209aa58*/ object GetValue(object target, string member);
                /*0x20a1e9c*/ void SetValue(object target, string member, object value);
                /*0x20a02ac*/ System.Type GetType(string member);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ System.Func<object> ctor;

                    /*0x21ffc1c*/ <>c__DisplayClass11_0();
                    /*0x21ffc24*/ object <Create>b__0(object[] args);
                }

                class <>c__DisplayClass11_1
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x21ffc78*/ <>c__DisplayClass11_1();
                    /*0x21ffc80*/ object <Create>b__1(object target);
                }

                class <>c__DisplayClass11_2
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0x21ffd80*/ <>c__DisplayClass11_2();
                    /*0x21ffd88*/ void <Create>b__2(object target, object arg);
                }
            }

            class ReflectionUtils
            {
                static /*0x0*/ System.Type[] EmptyTypes;

                static /*0x20a255c*/ ReflectionUtils();
                static /*0x20995bc*/ bool IsVirtual(System.Reflection.PropertyInfo propertyInfo);
                static /*0x20a25e0*/ System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo);
                static /*0x20a26ac*/ bool IsPublic(System.Reflection.PropertyInfo property);
                static /*0x20a2740*/ System.Type GetObjectType(object v);
                static /*0x20a2750*/ string GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x20a283c*/ string GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0x20a2988*/ string RemoveAssemblyDetails(string fullyQualifiedTypeName);
                static /*0x209a050*/ bool HasDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x20a2c18*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t);
                static /*0x20a2ac4*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic);
                static /*0x20a2c7c*/ bool IsNullable(System.Type t);
                static /*0x20a0858*/ bool IsNullableType(System.Type t);
                static /*0x20a2d20*/ System.Type EnsureNotNullableType(System.Type t);
                static /*0x20a2da0*/ System.Type EnsureNotByRefType(System.Type t);
                static /*0x20a2e00*/ bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x20a2ebc*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0x20a2f3c*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, ref System.Type implementingType);
                static /*0x20a31f0*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition);
                static /*0x20a3270*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x20a33ec*/ bool InheritsGenericDefinitionInternal(System.Type currentType, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0x20a34fc*/ System.Type GetCollectionItemType(System.Type type);
                static /*0x20a3768*/ void GetDictionaryKeyValueTypes(System.Type dictionaryType, ref System.Type keyType, ref System.Type valueType);
                static /*0x20a228c*/ System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member);
                static /*0x20a39d4*/ bool IsByRefLikeType(System.Type type);
                static /*0x20a3af4*/ bool IsIndexedProperty(System.Reflection.PropertyInfo property);
                static /*0x20a3b74*/ object GetMemberValue(System.Reflection.MemberInfo member, object target);
                static /*0x20a3f40*/ void SetMemberValue(System.Reflection.MemberInfo member, object target, object value);
                static /*0x20a1f98*/ bool CanReadMemberValue(System.Reflection.MemberInfo member, bool nonPublic);
                static /*0x20a2100*/ bool CanSetMemberValue(System.Reflection.MemberInfo member, bool nonPublic, bool canSetReadOnly);
                static /*0x20a41a4*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0x20a4fa4*/ bool IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr);
                static T GetAttribute<T>(object attributeProvider);
                static T GetAttribute<T>(object attributeProvider, bool inherit);
                static T[] GetAttributes<T>(object attributeProvider, bool inherit);
                static /*0x209a500*/ System.Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit);
                static /*0x20a5198*/ Newtonsoft.Json.Utilities.StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName);
                static /*0x20a52a8*/ System.Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName);
                static /*0x20996a4*/ System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo);
                static /*0x20a4b58*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x20a5384*/ void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x20a4c78*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x20a559c*/ System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag);
                static /*0x20a55ac*/ void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0x20a5bb0*/ bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method);
                static /*0x20a5cc0*/ object GetDefaultValue(System.Type type);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__11_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__31_0;
                    static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__39_0;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, bool> <>9__41_0;

                    static /*0x21ffe5c*/ <>c();
                    /*0x21ffebc*/ <>c();
                    /*0x21ffec4*/ bool <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c);
                    /*0x21fff34*/ string <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m);
                    /*0x21fff54*/ System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p);
                    /*0x21fff74*/ bool <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Reflection.MemberInfo memberInfo;

                    /*0x21fff90*/ <>c__DisplayClass31_0();
                    /*0x21fff98*/ bool <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m);
                }

                class <>c__DisplayClass44_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo subTypeProperty;

                    /*0x2200048*/ <>c__DisplayClass44_0();
                    /*0x2200050*/ bool <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p);
                    /*0x22000b0*/ bool <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass44_1
                {
                    /*0x10*/ System.Type subTypePropertyDeclaringType;
                    /*0x18*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> CS$<>8__locals1;

                    /*0x22001b4*/ <>c__DisplayClass44_1();
                    /*0x22001bc*/ bool <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ string method;
                    /*0x18*/ System.Type methodDeclaringType;

                    /*0x22002f0*/ <>c__DisplayClass45_0();
                    /*0x22002f8*/ bool <IsMethodOverridden>b__0(System.Reflection.MethodInfo info);
                }
            }

            struct StringBuffer
            {
                /*0x10*/ char[] _buffer;
                /*0x18*/ int _position;

                /*0xae268c*/ StringBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int initalSize);
                /*0xae26c0*/ StringBuffer(char[] buffer);
                /*0xae266c*/ int get_Position();
                /*0xae2674*/ void set_Position(int value);
                /*0xae267c*/ bool get_IsEmpty();
                /*0xae26cc*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char value);
                /*0xae26d4*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count);
                /*0xae26dc*/ void Clear(Newtonsoft.Json.IArrayPool<char> bufferPool);
                /*0xae2718*/ void EnsureSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int appendLength);
                /*0xae2720*/ string ToString();
                /*0xae2738*/ string ToString(int start, int length);
                /*0xae2754*/ char[] get_InternalBuffer();
            }

            struct StringReference
            {
                /*0x10*/ char[] _chars;
                /*0x18*/ int _startIndex;
                /*0x1c*/ int _length;

                /*0xae2914*/ StringReference(char[] chars, int startIndex, int length);
                /*0xae28f4*/ char get_Item(int i);
                /*0xae28fc*/ char[] get_Chars();
                /*0xae2904*/ int get_StartIndex();
                /*0xae290c*/ int get_Length();
                /*0xae2920*/ string ToString();
            }

            class StringReferenceExtensions
            {
                static /*0x21ebbb0*/ int IndexOf(Newtonsoft.Json.Utilities.StringReference s, char c, int startIndex, int length);
                static /*0x21ebc38*/ bool StartsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
                static /*0x21ebcfc*/ bool EndsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
            }

            class StringUtils
            {
                static /*0x21eba80*/ bool IsNullOrEmpty(string value);
                static /*0x21e9788*/ string FormatWith(string format, System.IFormatProvider provider, object arg0);
                static /*0x21e93bc*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1);
                static /*0x21ebe34*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2);
                static /*0x21ebf48*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2, object arg3);
                static /*0x21ebdc4*/ string FormatWith(string format, System.IFormatProvider provider, object[] args);
                static /*0x21ec090*/ System.IO.StringWriter CreateStringWriter(int capacity);
                static /*0x21ec164*/ void ToCharAsUnicode(char c, char[] buffer);
                static TSource ForgivingCaseSensitiveFind<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, string> valueSelector, string testValue);
                static /*0x21ec22c*/ string ToCamelCase(string s);
                static /*0x21ec44c*/ char ToLower(char c);
                static /*0x21eac5c*/ string ToSnakeCase(string s);
                static /*0x21ec808*/ string ToKebabCase(string s);
                static /*0x21ec4f0*/ string ToSeparatedCase(string s, char separator);
                static /*0x21ec810*/ bool IsHighSurrogate(char c);
                static /*0x21ec874*/ bool IsLowSurrogate(char c);
                static /*0x21ec8d8*/ bool StartsWith(string source, char value);
                static /*0x21ec928*/ bool EndsWith(string source, char value);
                static /*0x21ec974*/ string Trim(string s, int start, int length);

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

                    <>c__DisplayClass14_0();
                    bool <ForgivingCaseSensitiveFind>b__0(TSource s);
                    bool <ForgivingCaseSensitiveFind>b__1(TSource s);
                }
            }

            struct StructMultiKey<T1, T2> : System.IEquatable<Newtonsoft.Json.Utilities.StructMultiKey<T1, T2>>
            {
                /*0x0*/ T1 Value1;
                /*0x0*/ T2 Value2;

                StructMultiKey(T1 v1, T2 v2);
                int GetHashCode();
                bool Equals(object obj);
                bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1, T2> other);
            }

            class ThreadSafeStore<TKey, TValue>
            {
                /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> _concurrentStore;
                /*0x0*/ System.Func<TKey, TValue> _creator;

                ThreadSafeStore(System.Func<TKey, TValue> creator);
                TValue Get(TKey key);
            }

            class TypeExtensions
            {
                static /*0x21ef0ac*/ System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo);
                static /*0x21ef0c8*/ bool ContainsGenericParameters(System.Type type);
                static /*0x21ef0e8*/ bool IsInterface(System.Type type);
                static /*0x21ef100*/ bool IsGenericType(System.Type type);
                static /*0x21ef120*/ bool IsGenericTypeDefinition(System.Type type);
                static /*0x21ef140*/ System.Type BaseType(System.Type type);
                static /*0x21ef160*/ System.Reflection.Assembly Assembly(System.Type type);
                static /*0x21ebb1c*/ bool IsEnum(System.Type type);
                static /*0x21ef180*/ bool IsClass(System.Type type);
                static /*0x21ef198*/ bool IsSealed(System.Type type);
                static /*0x21ef1b0*/ bool IsAbstract(System.Type type);
                static /*0x21ef1c8*/ bool IsVisible(System.Type type);
                static /*0x21ef1e0*/ bool IsValueType(System.Type type);
                static /*0x21ef1f8*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces, ref System.Type match);
                static /*0x21ef37c*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces);
                static /*0x21ef3a8*/ bool ImplementInterface(System.Type type, System.Type interfaceType);
            }

            class ValidationUtils
            {
                static /*0x21e91a0*/ void ArgumentNotNull(object value, string parameterName);
            }
        }

        namespace Serialization
        {
            class CachedAttributeGetter<T>
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<object, T> TypeAttributeCache;

                static CachedAttributeGetter();
                static T GetAttribute(object type);
            }

            class CamelCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x17191c0*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x1719204*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x1719254*/ CamelCaseNamingStrategy();
                /*0x171925c*/ string ResolvePropertyName(string name);
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

                static /*0x172b2c4*/ DefaultContractResolver();
                static /*0x1723968*/ Newtonsoft.Json.Serialization.IContractResolver get_Instance();
                static /*0x1723c1c*/ bool FilterMembers(System.Reflection.MemberInfo member);
                static /*0x17266cc*/ void ThrowUnableToSerializeError(object o, System.Runtime.Serialization.StreamingContext context);
                static /*0x1725e00*/ void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member);
                static /*0x1728a9c*/ bool IsConcurrentOrObservableCollection(System.Type t);
                static /*0x172810c*/ bool ShouldSkipDeserialized(System.Type t);
                static /*0x172802c*/ bool ShouldSkipSerializing(System.Type t);
                static /*0x1729fc0*/ bool IsJsonPrimitiveType(System.Type t);
                static /*0x172a168*/ bool IsIConvertible(System.Type t);
                static /*0x172a02c*/ bool CanConvertToString(System.Type type);
                static /*0x17281ec*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                static /*0x172a308*/ string GetClrTypeFullName(System.Type type);
                /*0x1723a18*/ DefaultContractResolver();
                /*0x17239cc*/ System.Reflection.BindingFlags get_DefaultMembersSearchFlags();
                /*0x17239d4*/ void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value);
                /*0x17239dc*/ bool get_SerializeCompilerGeneratedMembers();
                /*0x17239e4*/ bool get_IgnoreSerializableInterface();
                /*0x17239ec*/ bool get_IgnoreSerializableAttribute();
                /*0x17239f4*/ void set_IgnoreSerializableAttribute(bool value);
                /*0x1723a00*/ bool get_IgnoreIsSpecifiedMembers();
                /*0x1723a08*/ bool get_IgnoreShouldSerializeMembers();
                /*0x1723a10*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x1723b94*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
                /*0x1723d88*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType);
                /*0x17249a4*/ bool ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo);
                /*0x1724aa4*/ Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType);
                /*0x1725bf8*/ System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type);
                /*0x1725378*/ System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType);
                /*0x1725910*/ System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x17258c4*/ System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType);
                /*0x1726a78*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x17269c4*/ Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, string name, System.Type type);
                /*0x1726c08*/ Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo);
                /*0x1727594*/ Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType);
                /*0x17275f8*/ System.Func<object> GetDefaultCreator(System.Type createdType);
                /*0x1725104*/ void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x17276a4*/ void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t);
                /*0x1727808*/ void GetCallbackMethodsForType(System.Type type, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> onError);
                /*0x1726790*/ System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type);
                /*0x1728be0*/ Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType);
                /*0x17291b4*/ Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType);
                /*0x1729550*/ Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType);
                /*0x17295c8*/ Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType);
                /*0x1729640*/ Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType);
                /*0x1729888*/ Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType);
                /*0x1729ad4*/ Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType);
                /*0x1729b4c*/ Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType);
                /*0x172a418*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x172aa28*/ Newtonsoft.Json.DefaultJsonNameTable GetNameTable();
                /*0x172aa30*/ Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member);
                /*0x172aa90*/ Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x1726e9c*/ void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, object attributeProvider, string name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, ref bool allowNonPublicAccess);
                /*0x172aca0*/ System.Predicate<object> CreateShouldSerializeTest(System.Reflection.MemberInfo member);
                /*0x172af28*/ void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, bool allowNonPublicAccess);
                /*0x172b25c*/ string ResolvePropertyName(string propertyName);
                /*0x172b27c*/ string ResolveExtensionDataName(string extensionDataName);
                /*0x172b298*/ string ResolveDictionaryKey(string dictionaryKey);
                /*0x171e724*/ string GetResolvedPropertyName(string propertyName);

                class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
                {
                    /*0x0*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    EnumerableDictionaryWrapper(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class <GetEnumerator>d__<TEnumeratorKey, TEnumeratorValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ System.Collections.Generic.KeyValuePair<object, object> <>2__current;
                        /*0x0*/ Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;
                        /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;

                        <GetEnumerator>d__(int <>1__state);
                        void System.IDisposable.Dispose();
                        bool MoveNext();
                        void <>m__Finally1();
                        System.Collections.Generic.KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current();
                        void System.Collections.IEnumerator.Reset();
                        object System.Collections.IEnumerator.get_Current();
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

                    static /*0x21fc850*/ <>c();
                    /*0x21fc8b0*/ <>c();
                    /*0x21fc8b8*/ bool <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m);
                    /*0x21fc978*/ bool <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m);
                    /*0x21fc9ec*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType);
                    /*0x21fcad0*/ bool <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m);
                    /*0x21fcf7c*/ bool <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c);
                    /*0x21fd01c*/ int <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p);
                }

                class <>c__DisplayClass42_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x21fd078*/ <>c__DisplayClass42_0();
                    /*0x21fd080*/ string <CreateObjectContract>b__0(string s);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ System.Func<object, object> getExtensionDataDictionary;
                    /*0x18*/ System.Reflection.MemberInfo member;

                    /*0x21fd0a0*/ <>c__DisplayClass45_0();
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ System.Action<object, object> setExtensionDataDictionary;
                    /*0x18*/ System.Func<object> createExtensionDataDictionary;
                    /*0x20*/ Newtonsoft.Json.Utilities.MethodCall<object, object> setExtensionDataDictionaryValue;
                    /*0x28*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals1;

                    /*0x21fd0a8*/ <>c__DisplayClass45_1();
                    /*0x21fd0b0*/ void <SetExtensionDataDelegates>b__0(object o, string key, object value);
                }

                class <>c__DisplayClass45_2
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> createEnumerableWrapper;
                    /*0x18*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals2;

                    /*0x21fd314*/ <>c__DisplayClass45_2();
                    /*0x21fd31c*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o);
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x21fd458*/ <>c__DisplayClass62_0();
                    /*0x21fd460*/ string <CreateDictionaryContract>b__0(string s);
                }

                class <>c__DisplayClass67_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x21fd480*/ <>c__DisplayClass67_0();
                    /*0x21fd488*/ string <CreateDynamicContract>b__0(string s);
                }

                class <>c__DisplayClass80_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> shouldSerializeCall;

                    /*0x21fd4a8*/ <>c__DisplayClass80_0();
                    /*0x21fd4b0*/ bool <CreateShouldSerializeTest>b__0(object o);
                }

                class <>c__DisplayClass81_0
                {
                    /*0x10*/ System.Func<object, object> specifiedPropertyGet;

                    /*0x21fd5f0*/ <>c__DisplayClass81_0();
                    /*0x21fd5f8*/ bool <SetIsSpecifiedActions>b__0(object o);
                }
            }

            class DefaultNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x172bcc0*/ DefaultNamingStrategy();
                /*0x172bcb8*/ string ResolvePropertyName(string name);
            }

            class DefaultReferenceResolver : Newtonsoft.Json.Serialization.IReferenceResolver
            {
                /*0x10*/ int _referenceCount;

                /*0x172c044*/ DefaultReferenceResolver();
                /*0x172bcc8*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> GetMappings(object context);
                /*0x172bddc*/ object ResolveReference(object context, string reference);
                /*0x172be54*/ string GetReference(object context, object value);
                /*0x172bf5c*/ void AddReference(object context, string reference, object value);
                /*0x172bfcc*/ bool IsReferenced(object context, object value);
            }

            class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder, Newtonsoft.Json.Serialization.ISerializationBinder
            {
                static /*0x0*/ Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
                /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<string, string>, System.Type> _typeCache;

                static /*0x172c9b0*/ DefaultSerializationBinder();
                /*0x172c04c*/ DefaultSerializationBinder();
                /*0x172c12c*/ System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x172c5cc*/ System.Type GetGenericTypeFromTypeName(string typeName, System.Reflection.Assembly assembly);
                /*0x172c850*/ System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x172c8bc*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x172c93c*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            class ErrorContext
            {
                /*0x10*/ bool <Traced>k__BackingField;
                /*0x18*/ System.Exception <Error>k__BackingField;
                /*0x20*/ object <OriginalObject>k__BackingField;
                /*0x28*/ object <Member>k__BackingField;
                /*0x30*/ string <Path>k__BackingField;
                /*0x38*/ bool <Handled>k__BackingField;

                /*0x1730994*/ ErrorContext(object originalObject, object member, string path, System.Exception error);
                /*0x17309e0*/ bool get_Traced();
                /*0x17309e8*/ void set_Traced(bool value);
                /*0x17309f4*/ System.Exception get_Error();
                /*0x17309fc*/ bool get_Handled();
            }

            class ErrorEventArgs : System.EventArgs
            {
                /*0x10*/ object <CurrentObject>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;

                /*0x1730a04*/ ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext);
            }

            interface IAttributeProvider
            {
            }

            interface IContractResolver
            {
                Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
            }

            interface IReferenceResolver
            {
                object ResolveReference(object context, string reference);
                string GetReference(object context, object value);
                bool IsReferenced(object context, object value);
                void AddReference(object context, string reference, object value);
            }

            interface ISerializationBinder
            {
                System.Type BindToType(string assemblyName, string typeName);
                void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            interface ITraceWriter
            {
                System.Diagnostics.TraceLevel get_LevelFilter();
                void Trace(System.Diagnostics.TraceLevel level, string message, System.Exception ex);
            }

            interface IValueProvider
            {
                void SetValue(object target, object value);
                object GetValue(object target);
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

                /*0x1ab4914*/ JsonArrayContract(System.Type underlyingType);
                /*0x1ab4754*/ System.Type get_CollectionItemType();
                /*0x1ab475c*/ bool get_IsMultidimensionalArray();
                /*0x1ab4764*/ bool get_IsArray();
                /*0x1ab476c*/ bool get_ShouldCreateWrapper();
                /*0x1ab4774*/ bool get_CanDeserialize();
                /*0x1ab477c*/ void set_CanDeserialize(bool value);
                /*0x1ab4788*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x1ab485c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x1ab4864*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x1ab4874*/ bool get_HasParameterizedCreator();
                /*0x1ab487c*/ void set_HasParameterizedCreator(bool value);
                /*0x1ab4888*/ bool get_HasParameterizedCreatorInternal();
                /*0x1ab5af4*/ Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(object list);
                /*0x1ab5f04*/ System.Collections.IList CreateTemporaryCollection();
                /*0x1ab59cc*/ void StoreFSharpListCreatorIfNecessary(System.Type underlyingType);
            }

            class JsonContainerContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x90*/ Newtonsoft.Json.Serialization.JsonContract _itemContract;
                /*0x98*/ Newtonsoft.Json.Serialization.JsonContract _finalItemContract;
                /*0xa0*/ Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;
                /*0xa8*/ System.Nullable<bool> <ItemIsReference>k__BackingField;
                /*0xac*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;
                /*0xb4*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;

                /*0x1ab57f8*/ JsonContainerContract(System.Type underlyingType);
                /*0x1ab61c0*/ Newtonsoft.Json.Serialization.JsonContract get_ItemContract();
                /*0x1ab61c8*/ void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x1ab6210*/ Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract();
                /*0x1ab6218*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x1ab6220*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x1ab6228*/ System.Nullable<bool> get_ItemIsReference();
                /*0x1ab6230*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x1ab6238*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x1ab6240*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x1ab6248*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x1ab6250*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
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
                /*0x21ea218*/ SerializationCallback(object object, nint method);
                /*0x21ea278*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x21ea630*/ System.IAsyncResult BeginInvoke(object o, System.Runtime.Serialization.StreamingContext context, System.AsyncCallback callback, object object);
                /*0x21ea6c8*/ void EndInvoke(System.IAsyncResult result);
            }

            class SerializationErrorCallback : System.MulticastDelegate
            {
                /*0x21ea6d4*/ SerializationErrorCallback(object object, nint method);
                /*0x21ea734*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);
                /*0x21eab0c*/ System.IAsyncResult BeginInvoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext, System.AsyncCallback callback, object object);
                /*0x21eaba8*/ void EndInvoke(System.IAsyncResult result);
            }

            class ExtensionDataSetter : System.MulticastDelegate
            {
                /*0x1726904*/ ExtensionDataSetter(object object, nint method);
                /*0x17313b8*/ void Invoke(object o, string key, object value);
                /*0x1731770*/ System.IAsyncResult BeginInvoke(object o, string key, object value, System.AsyncCallback callback, object object);
                /*0x17317a0*/ void EndInvoke(System.IAsyncResult result);
            }

            class ExtensionDataGetter : System.MulticastDelegate
            {
                /*0x1726964*/ ExtensionDataGetter(object object, nint method);
                /*0x1731008*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> Invoke(object o);
                /*0x1731388*/ System.IAsyncResult BeginInvoke(object o, System.AsyncCallback callback, object object);
                /*0x17313ac*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EndInvoke(System.IAsyncResult result);
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

                static /*0x1ab6cc8*/ Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo);
                static /*0x1ab6d74*/ Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo);
                /*0x1ab6258*/ JsonContract(System.Type underlyingType);
                /*0x1ab63c4*/ System.Type get_UnderlyingType();
                /*0x1ab63cc*/ System.Type get_CreatedType();
                /*0x1ab5920*/ void set_CreatedType(System.Type value);
                /*0x1ab63d4*/ System.Nullable<bool> get_IsReference();
                /*0x1ab63dc*/ void set_IsReference(System.Nullable<bool> value);
                /*0x1ab63e4*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x1ab63ec*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x1ab63f4*/ Newtonsoft.Json.JsonConverter get_InternalConverter();
                /*0x1ab63fc*/ void set_InternalConverter(Newtonsoft.Json.JsonConverter value);
                /*0x1ab6404*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks();
                /*0x1ab6480*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks();
                /*0x1ab64fc*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks();
                /*0x1ab6578*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks();
                /*0x1ab65f4*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks();
                /*0x1ab6670*/ System.Func<object> get_DefaultCreator();
                /*0x1ab6678*/ void set_DefaultCreator(System.Func<object> value);
                /*0x1ab6680*/ bool get_DefaultCreatorNonPublic();
                /*0x1ab6688*/ void set_DefaultCreatorNonPublic(bool value);
                /*0x1ab6694*/ void InvokeOnSerializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x1ab67d0*/ void InvokeOnSerialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x1ab690c*/ void InvokeOnDeserializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x1ab6a48*/ void InvokeOnDeserialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x1ab6b84*/ void InvokeOnError(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);

                class <>c__DisplayClass57_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x21ff2cc*/ <>c__DisplayClass57_0();
                    /*0x21ff2d4*/ void <CreateSerializationCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context);
                }

                class <>c__DisplayClass58_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x21ff3d4*/ <>c__DisplayClass58_0();
                    /*0x21ff3dc*/ void <CreateSerializationErrorCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext);
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

                /*0x1ab8114*/ JsonDictionaryContract(System.Type underlyingType);
                /*0x1ab7f58*/ System.Func<string, string> get_DictionaryKeyResolver();
                /*0x1ab7f60*/ void set_DictionaryKeyResolver(System.Func<string, string> value);
                /*0x1ab7f68*/ System.Type get_DictionaryKeyType();
                /*0x1ab7f70*/ System.Type get_DictionaryValueType();
                /*0x1ab7f78*/ Newtonsoft.Json.Serialization.JsonContract get_KeyContract();
                /*0x1ab7f80*/ void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x1ab7f88*/ bool get_ShouldCreateWrapper();
                /*0x1ab7f90*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x1ab8064*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x1ab806c*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x1ab8074*/ bool get_HasParameterizedCreator();
                /*0x1ab807c*/ void set_HasParameterizedCreator(bool value);
                /*0x1ab8088*/ bool get_HasParameterizedCreatorInternal();
                /*0x1ab8b94*/ Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(object dictionary);
                /*0x1ab8e48*/ System.Collections.IDictionary CreateTemporaryDictionary();
            }

            class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;
                /*0xc8*/ System.Func<string, string> <PropertyNameResolver>k__BackingField;
                /*0xd0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>> _callSiteGetters;
                /*0xd8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>> _callSiteSetters;

                static /*0x1ab9110*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>> CreateCallSiteGetter(string name);
                static /*0x1ab9240*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>> CreateCallSiteSetter(string name);
                /*0x1ab9370*/ JsonDynamicContract(System.Type underlyingType);
                /*0x1ab90f8*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x1ab9100*/ System.Func<string, string> get_PropertyNameResolver();
                /*0x1ab9108*/ void set_PropertyNameResolver(System.Func<string, string> value);
                /*0x1ab952c*/ bool TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, ref object value);
                /*0x1ab9648*/ bool TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, object value);
            }

            class JsonFormatterConverter : System.Runtime.Serialization.IFormatterConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;
                /*0x18*/ Newtonsoft.Json.Serialization.JsonISerializableContract _contract;
                /*0x20*/ Newtonsoft.Json.Serialization.JsonProperty _member;

                /*0x1ab98dc*/ JsonFormatterConverter(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                T GetTokenValue<T>(object value);
                /*0x1ab9984*/ object Convert(object value, System.Type type);
                /*0x1ab9aa4*/ bool ToBoolean(object value);
                /*0x1ab9b00*/ int ToInt32(object value);
                /*0x1ab9b5c*/ long ToInt64(object value);
                /*0x1ab9bb8*/ float ToSingle(object value);
                /*0x1ab9c14*/ string ToString(object value);
            }

            class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <ISerializableCreator>k__BackingField;

                /*0x190f798*/ JsonISerializableContract(System.Type underlyingType);
                /*0x190f788*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ISerializableCreator();
                /*0x190f790*/ void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
            }

            class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x190f7cc*/ JsonLinqContract(System.Type underlyingType);
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

                /*0x190ff98*/ JsonObjectContract(System.Type underlyingType);
                /*0x190f820*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
                /*0x190f828*/ void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value);
                /*0x190f830*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling();
                /*0x190f838*/ void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value);
                /*0x190f840*/ System.Nullable<Newtonsoft.Json.Required> get_ItemRequired();
                /*0x190f848*/ void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value);
                /*0x190f850*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling();
                /*0x190f858*/ void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x190f860*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x190f868*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters();
                /*0x190fa2c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x190fa34*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x190fa3c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x190fa44*/ void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x190fa4c*/ Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter();
                /*0x190fa54*/ void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value);
                /*0x190fa5c*/ Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter();
                /*0x190fa64*/ void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value);
                /*0x190fa6c*/ void set_ExtensionDataValueType(System.Type value);
                /*0x190fb54*/ System.Func<string, string> get_ExtensionDataNameResolver();
                /*0x190fb5c*/ void set_ExtensionDataNameResolver(System.Func<string, string> value);
                /*0x190fb64*/ bool get_HasRequiredOrDefaultValueProperties();
                /*0x191001c*/ object GetUninitializedObject();
            }

            class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Newtonsoft.Json.ReadType> ReadTypeMap;
                /*0x8c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;

                static /*0x1910c68*/ JsonPrimitiveContract();
                /*0x1910b5c*/ JsonPrimitiveContract(System.Type underlyingType);
                /*0x1910b4c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
                /*0x1910b54*/ void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value);
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

                /*0x1911404*/ JsonProperty();
                /*0x1910fac*/ Newtonsoft.Json.Serialization.JsonContract get_PropertyContract();
                /*0x1910fb4*/ void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x1910fbc*/ string get_PropertyName();
                /*0x1910fc4*/ void set_PropertyName(string value);
                /*0x1911054*/ System.Type get_DeclaringType();
                /*0x191105c*/ void set_DeclaringType(System.Type value);
                /*0x1911064*/ System.Nullable<int> get_Order();
                /*0x191106c*/ void set_Order(System.Nullable<int> value);
                /*0x1911074*/ string get_UnderlyingName();
                /*0x191107c*/ void set_UnderlyingName(string value);
                /*0x1911084*/ Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider();
                /*0x191108c*/ void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value);
                /*0x1911094*/ void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value);
                /*0x191109c*/ System.Type get_PropertyType();
                /*0x19110a4*/ void set_PropertyType(System.Type value);
                /*0x191112c*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x1911134*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x191113c*/ bool get_Ignored();
                /*0x1911144*/ void set_Ignored(bool value);
                /*0x1911150*/ bool get_Readable();
                /*0x1911158*/ void set_Readable(bool value);
                /*0x1911164*/ bool get_Writable();
                /*0x191116c*/ void set_Writable(bool value);
                /*0x1911178*/ bool get_HasMemberAttribute();
                /*0x1911180*/ void set_HasMemberAttribute(bool value);
                /*0x191118c*/ object get_DefaultValue();
                /*0x19111a4*/ void set_DefaultValue(object value);
                /*0x19111b4*/ object GetResolvedDefaultValue();
                /*0x190ff58*/ Newtonsoft.Json.Required get_Required();
                /*0x191128c*/ System.Nullable<bool> get_IsReference();
                /*0x1911294*/ void set_IsReference(System.Nullable<bool> value);
                /*0x191129c*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling();
                /*0x19112a4*/ void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x19112ac*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling();
                /*0x19112b4*/ void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value);
                /*0x19112bc*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling();
                /*0x19112c4*/ void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x19112cc*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling();
                /*0x19112d4*/ void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value);
                /*0x19112dc*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling();
                /*0x19112e4*/ void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x19112ec*/ System.Predicate<object> get_ShouldSerialize();
                /*0x19112f4*/ void set_ShouldSerialize(System.Predicate<object> value);
                /*0x19112fc*/ System.Predicate<object> get_ShouldDeserialize();
                /*0x1911304*/ System.Predicate<object> get_GetIsSpecified();
                /*0x191130c*/ void set_GetIsSpecified(System.Predicate<object> value);
                /*0x1911314*/ System.Action<object, object> get_SetIsSpecified();
                /*0x191131c*/ void set_SetIsSpecified(System.Action<object, object> value);
                /*0x1911324*/ string ToString();
                /*0x191137c*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x1911384*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x191138c*/ System.Nullable<bool> get_ItemIsReference();
                /*0x1911394*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x191139c*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x19113a4*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x19113ac*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x19113b4*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x19113bc*/ void WritePropertyName(Newtonsoft.Json.JsonWriter writer);
            }

            class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty>
            {
                /*0x38*/ System.Type _type;
                /*0x40*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;

                /*0x190f8dc*/ JsonPropertyCollection(System.Type type);
                /*0x1911468*/ string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x1911480*/ void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x1911788*/ Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName);
                /*0x19118c0*/ bool TryGetValue(string key, ref Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x19117cc*/ Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType);
            }

            class JsonSerializerInternalBase
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;
                /*0x18*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> _mappings;
                /*0x20*/ Newtonsoft.Json.JsonSerializer Serializer;
                /*0x28*/ Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;
                /*0x30*/ Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;

                /*0x19196e8*/ JsonSerializerInternalBase(Newtonsoft.Json.JsonSerializer serializer);
                /*0x1919774*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> get_DefaultReferenceMappings();
                /*0x191987c*/ Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x1919904*/ Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(object currentObject, object member, string path, System.Exception error);
                /*0x19199f8*/ void ClearErrorContext();
                /*0x1919a5c*/ bool IsErrorHandled(object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, string path, System.Exception ex);

                class ReferenceEqualsEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
                {
                    /*0x21ff520*/ ReferenceEqualsEqualityComparer();
                    /*0x21ff508*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
                    /*0x21ff514*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj);
                }
            }

            class JsonSerializerInternalReader : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                static /*0x191e760*/ bool CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, string s);
                /*0x1917e38*/ JsonSerializerInternalReader(Newtonsoft.Json.JsonSerializer serializer);
                /*0x1917e3c*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
                /*0x191b9e4*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type);
                /*0x191ba7c*/ Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type);
                /*0x191887c*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, bool checkAdditionalContent);
                /*0x191c500*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x191c56c*/ Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x191c984*/ Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader);
                /*0x191c004*/ object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x191e8b0*/ string GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x191bb40*/ Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x191cdb8*/ object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x191e96c*/ bool ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x191f0f8*/ bool ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x1920d80*/ void ResolveTypeName(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, string qualifiedTypeName);
                /*0x1921418*/ Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x191d9b4*/ object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, object existingValue, string id);
                /*0x191f7cc*/ bool HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x191e10c*/ object EnsureType(Newtonsoft.Json.JsonReader reader, object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType);
                /*0x1922094*/ bool SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target);
                /*0x19225b4*/ bool CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target, ref bool useExistingValue, ref object currentValue, ref Newtonsoft.Json.Serialization.JsonContract propertyContract, ref bool gottenCurrentValue, ref bool ignoredValue);
                /*0x1922c44*/ void AddReference(Newtonsoft.Json.JsonReader reader, string id, object value);
                /*0x1922c38*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x1922b38*/ bool ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, object value);
                /*0x19215e8*/ System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, ref bool createdFromNonDefaultCreator);
                /*0x191fbc8*/ System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, ref bool createdFromNonDefaultCreator);
                /*0x1923050*/ void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x19232a0*/ void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x191a3c8*/ object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x1921974*/ object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x19234f0*/ void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object currentObject, string message);
                /*0x1919e54*/ object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x19205f4*/ object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x1923638*/ object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x191fee0*/ object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x1923738*/ object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<object> creator, string id);
                /*0x191bbb8*/ object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue);
                /*0x19253ec*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x191f8dc*/ object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id, ref bool createdFromNonDefaultCreator);
                /*0x191aea8*/ object PopulateObject(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x1926214*/ bool ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x191cc9c*/ bool CheckPropertyName(Newtonsoft.Json.JsonReader reader, string memberName);
                /*0x1926084*/ void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, string memberName, object o);
                /*0x1925fb0*/ object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader);
                /*0x1925a80*/ void EndProcessProperty(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, int initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue);
                /*0x19264ac*/ void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties);
                /*0x191c490*/ void HandleError(Newtonsoft.Json.JsonReader reader, bool readPastError, int initialDepth);

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

                    /*0x21ff5fc*/ CreatorPropertyContext(string name);
                }

                class <>c__DisplayClass38_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.JsonProperty property;

                    /*0x21ff5d0*/ <>c__DisplayClass38_0();
                    /*0x21ff5d8*/ bool <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_0;
                    static /*0x10*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_2;
                    static /*0x18*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0;
                    static /*0x20*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1;

                    static /*0x21ff528*/ <>c();
                    /*0x21ff588*/ <>c();
                    /*0x21ff590*/ string <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x21ff5a8*/ string <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0x21ff5c0*/ Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m);
                    /*0x21ff5c8*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m);
                }
            }

            class JsonSerializerInternalWriter : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                /*0x38*/ System.Type _rootType;
                /*0x40*/ int _rootLevel;
                /*0x48*/ System.Collections.Generic.List<object> _serializeStack;

                static /*0x192ac8c*/ bool TryConvertToString(object value, System.Type type, ref string s);
                /*0x19191b0*/ JsonSerializerInternalWriter(Newtonsoft.Json.JsonSerializer serializer);
                /*0x1919234*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
                /*0x19270fc*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x19265c4*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(object value);
                /*0x1927168*/ Newtonsoft.Json.Serialization.JsonContract GetContract(object value);
                /*0x1927240*/ void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x1926a24*/ void SerializeValue(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192a31c*/ System.Nullable<bool> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x19265d4*/ bool ShouldWriteReference(object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192a3d8*/ bool ShouldWriteProperty(object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x192a4b8*/ bool CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x1926780*/ void WriteReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x192aa74*/ string GetReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0x1928df0*/ void SerializeString(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonStringContract contract);
                /*0x192ada0*/ void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x192afd0*/ void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x1927dd8*/ void SerializeObject(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192b344*/ bool CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.Serialization.JsonContract memberContract, ref object memberValue);
                /*0x192b200*/ void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192c22c*/ bool HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x192c2f4*/ void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, object value);
                /*0x1927610*/ void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type);
                /*0x192a4ac*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x192a3cc*/ bool HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag);
                /*0x192c560*/ bool HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag);
                /*0x19278b8*/ void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x19284dc*/ void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x1928c00*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192c828*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, int initialDepth, int[] indices);
                /*0x192c56c*/ bool WriteStartArray(Newtonsoft.Json.JsonWriter writer, object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x1929eb4*/ void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x19296fc*/ void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192cbe0*/ bool ShouldWriteDynamicProperty(object memberValue);
                /*0x19273c4*/ bool ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x1928e80*/ void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x192b7c0*/ string GetPropertyName(Newtonsoft.Json.JsonWriter writer, object name, Newtonsoft.Json.Serialization.JsonContract contract, ref bool escape);
                /*0x1927084*/ void HandleError(Newtonsoft.Json.JsonWriter writer, int initialDepth);
                /*0x192bd04*/ bool ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x192bf98*/ bool IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
            }

            class JsonSerializerProxy : Newtonsoft.Json.JsonSerializer
            {
                /*0xe0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;
                /*0xe8*/ Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;
                /*0xf0*/ Newtonsoft.Json.JsonSerializer _serializer;

                /*0x208f568*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader);
                /*0x208f5e8*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter);
                /*0x208f1a4*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x208f1c4*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0x208f1e4*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
                /*0x208f204*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
                /*0x208f224*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
                /*0x208f244*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
                /*0x208f264*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
                /*0x208f288*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
                /*0x208f2ac*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
                /*0x208f2d0*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
                /*0x208f2f4*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
                /*0x208f318*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
                /*0x208f33c*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
                /*0x208f360*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
                /*0x208f384*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
                /*0x208f3a8*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
                /*0x208f3cc*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
                /*0x208f3ec*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
                /*0x208f410*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
                /*0x208f434*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
                /*0x208f454*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
                /*0x208f478*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
                /*0x208f498*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0x208f4bc*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
                /*0x208f4e0*/ Newtonsoft.Json.Formatting get_Formatting();
                /*0x208f504*/ bool get_CheckAdditionalContent();
                /*0x208f528*/ void set_CheckAdditionalContent(bool value);
                /*0x208f550*/ Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer();
                /*0x208f668*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x208f69c*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
                /*0x208f6cc*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type rootType);
            }

            class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
            {
                /*0x208fbcc*/ JsonStringContract(System.Type underlyingType);
            }

            class JsonTypeReflector
            {
                static /*0x0*/ System.Nullable<bool> _fullyTrusted;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Func<System.Object[], object>> CreatorCache;
                static /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache;
                static /*0x18*/ Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;

                static /*0x209acfc*/ JsonTypeReflector();
                static T GetCachedAttribute<T>(object attributeProvider);
                static /*0x209901c*/ bool CanTypeDescriptorConvertString(System.Type type, ref System.ComponentModel.TypeConverter typeConverter);
                static /*0x2099224*/ System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type);
                static /*0x20992fc*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo);
                static /*0x2099928*/ Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute);
                static /*0x2099aa4*/ Newtonsoft.Json.JsonConverter GetJsonConverter(object attributeProvider);
                static /*0x2099be0*/ Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] args);
                static /*0x2099ce8*/ Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, object[] args);
                static /*0x2099df0*/ Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute);
                static /*0x2099ec4*/ System.Func<System.Object[], object> GetCreator(System.Type type);
                static /*0x209a1e8*/ System.Type GetAssociatedMetadataType(System.Type type);
                static /*0x209a274*/ System.Type GetAssociateMetadataTypeFromAttribute(System.Type type);
                static T GetAttribute<T>(System.Type type);
                static T GetAttribute<T>(System.Reflection.MemberInfo memberInfo);
                static /*0x209ab44*/ bool IsNonSerializable(object provider);
                static /*0x2099a1c*/ bool IsSerializable(object provider);
                static T GetAttribute<T>(object provider);
                static /*0x209abcc*/ bool get_FullyTrusted();
                static /*0x209a14c*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory();

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ System.Type type;
                    /*0x18*/ System.Func<object> defaultConstructor;

                    /*0x21ff6f4*/ <>c__DisplayClass22_0();
                    /*0x21ff6fc*/ object <GetCreator>b__0(object[] parameters);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonTypeReflector.<> <>9;
                    static /*0x8*/ System.Func<object, System.Type> <>9__22_1;

                    static /*0x21ff628*/ <>c();
                    /*0x21ff688*/ <>c();
                    /*0x21ff690*/ System.Type <GetCreator>b__22_1(object param);
                }
            }

            class KebabCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x209f410*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x209f45c*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x209f4ac*/ KebabCaseNamingStrategy();
                /*0x209f4b4*/ string ResolvePropertyName(string name);
            }

            class NamingStrategy
            {
                /*0x10*/ bool <ProcessDictionaryKeys>k__BackingField;
                /*0x11*/ bool <ProcessExtensionDataNames>k__BackingField;
                /*0x12*/ bool <OverrideSpecifiedNames>k__BackingField;

                /*0x209f454*/ NamingStrategy();
                /*0x20a1494*/ bool get_ProcessDictionaryKeys();
                /*0x20a149c*/ void set_ProcessDictionaryKeys(bool value);
                /*0x20a14a8*/ bool get_ProcessExtensionDataNames();
                /*0x20a14b0*/ void set_ProcessExtensionDataNames(bool value);
                /*0x20a14bc*/ bool get_OverrideSpecifiedNames();
                /*0x20a14c4*/ void set_OverrideSpecifiedNames(bool value);
                /*0x20a14d0*/ string GetPropertyName(string name, bool hasSpecifiedName);
                /*0x20a14f0*/ string GetExtensionDataName(string name);
                /*0x20a150c*/ string GetDictionaryKey(string key);
                string ResolvePropertyName(string name);
                /*0x20a1528*/ int GetHashCode();
                /*0x20a15d8*/ bool Equals(object obj);
                /*0x20a1664*/ bool Equals(Newtonsoft.Json.Serialization.NamingStrategy other);
            }

            class ObjectConstructor<T> : System.MulticastDelegate
            {
                ObjectConstructor(object object, nint method);
                object Invoke(object[] args);
                System.IAsyncResult BeginInvoke(object[] args, System.AsyncCallback callback, object object);
                object EndInvoke(System.IAsyncResult result);
            }

            class OnErrorAttribute : System.Attribute
            {
            }

            class ReflectionAttributeProvider : Newtonsoft.Json.Serialization.IAttributeProvider
            {
                /*0x10*/ object _attributeProvider;

                /*0x20a1d5c*/ ReflectionAttributeProvider(object attributeProvider);
            }

            class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
            {
                /*0x10*/ System.Reflection.MemberInfo _memberInfo;

                /*0x21e9134*/ ReflectionValueProvider(System.Reflection.MemberInfo memberInfo);
                /*0x21e91f0*/ void SetValue(object target, object value);
                /*0x21e94a4*/ object GetValue(object target);
            }

            class SnakeCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x21eabb4*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x21eabf8*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x21eac48*/ SnakeCaseNamingStrategy();
                /*0x21eac50*/ string ResolvePropertyName(string name);
            }

            class TraceJsonReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.JsonReader _innerReader;
                /*0x80*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x88*/ System.IO.StringWriter _sw;

                /*0x21ecb40*/ TraceJsonReader(Newtonsoft.Json.JsonReader innerReader);
                /*0x21ecc8c*/ string GetDeserializedJsonMessage();
                /*0x21eccac*/ bool Read();
                /*0x21ecd28*/ System.Nullable<int> ReadAsInt32();
                /*0x21ecd6c*/ string ReadAsString();
                /*0x21ecdb0*/ byte[] ReadAsBytes();
                /*0x21ecdf8*/ System.Nullable<decimal> ReadAsDecimal();
                /*0x21ece58*/ System.Nullable<double> ReadAsDouble();
                /*0x21eceb0*/ System.Nullable<bool> ReadAsBoolean();
                /*0x21ecef8*/ System.Nullable<System.DateTime> ReadAsDateTime();
                /*0x21ecf50*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
                /*0x21eccf0*/ void WriteCurrentToken();
                /*0x21ecfb0*/ int get_Depth();
                /*0x21ecfd0*/ string get_Path();
                /*0x21ecff0*/ Newtonsoft.Json.JsonToken get_TokenType();
                /*0x21ed010*/ object get_Value();
                /*0x21ed030*/ System.Type get_ValueType();
                /*0x21ed050*/ void Close();
                /*0x21ed074*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x21ed134*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x21ed1f8*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
            }

            class TraceJsonWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.JsonWriter _innerWriter;
                /*0x68*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x70*/ System.IO.StringWriter _sw;

                /*0x21ed2bc*/ TraceJsonWriter(Newtonsoft.Json.JsonWriter innerWriter);
                /*0x21ed49c*/ string GetSerializedJsonMessage();
                /*0x21ed4bc*/ void WriteValue(decimal value);
                /*0x21ed534*/ void WriteValue(System.Nullable<decimal> value);
                /*0x21ed634*/ void WriteValue(bool value);
                /*0x21ed69c*/ void WriteValue(System.Nullable<bool> value);
                /*0x21ed760*/ void WriteValue(byte value);
                /*0x21ed7c4*/ void WriteValue(System.Nullable<byte> value);
                /*0x21ed880*/ void WriteValue(char value);
                /*0x21ed8e4*/ void WriteValue(System.Nullable<char> value);
                /*0x21ed9a0*/ void WriteValue(byte[] value);
                /*0x21eda18*/ void WriteValue(System.DateTime value);
                /*0x21eda7c*/ void WriteValue(System.Nullable<System.DateTime> value);
                /*0x21edb40*/ void WriteValue(System.DateTimeOffset value);
                /*0x21edbb8*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
                /*0x21edcb8*/ void WriteValue(double value);
                /*0x21edd24*/ void WriteValue(System.Nullable<double> value);
                /*0x21eddec*/ void WriteUndefined();
                /*0x21ede44*/ void WriteNull();
                /*0x21ede9c*/ void WriteValue(float value);
                /*0x21edf08*/ void WriteValue(System.Nullable<float> value);
                /*0x21edfc4*/ void WriteValue(System.Guid value);
                /*0x21ee03c*/ void WriteValue(System.Nullable<System.Guid> value);
                /*0x21ee13c*/ void WriteValue(int value);
                /*0x21ee1a0*/ void WriteValue(System.Nullable<int> value);
                /*0x21ee258*/ void WriteValue(long value);
                /*0x21ee2bc*/ void WriteValue(System.Nullable<long> value);
                /*0x21ee380*/ void WriteValue(object value);
                /*0x21ee45c*/ void WriteValue(sbyte value);
                /*0x21ee4c0*/ void WriteValue(System.Nullable<sbyte> value);
                /*0x21ee57c*/ void WriteValue(short value);
                /*0x21ee5e0*/ void WriteValue(System.Nullable<short> value);
                /*0x21ee69c*/ void WriteValue(string value);
                /*0x21ee700*/ void WriteValue(System.TimeSpan value);
                /*0x21ee764*/ void WriteValue(System.Nullable<System.TimeSpan> value);
                /*0x21ee828*/ void WriteValue(uint value);
                /*0x21ee88c*/ void WriteValue(System.Nullable<uint> value);
                /*0x21ee944*/ void WriteValue(ulong value);
                /*0x21ee9a8*/ void WriteValue(System.Nullable<ulong> value);
                /*0x21eea6c*/ void WriteValue(System.Uri value);
                /*0x21eeb48*/ void WriteValue(ushort value);
                /*0x21eebac*/ void WriteValue(System.Nullable<ushort> value);
                /*0x21eec68*/ void WriteComment(string text);
                /*0x21eeccc*/ void WriteStartArray();
                /*0x21eed1c*/ void WriteEndArray();
                /*0x21eed6c*/ void WriteStartConstructor(string name);
                /*0x21eedc8*/ void WriteEndConstructor();
                /*0x21eee18*/ void WritePropertyName(string name);
                /*0x21eee7c*/ void WritePropertyName(string name, bool escape);
                /*0x21eeef4*/ void WriteStartObject();
                /*0x21eef44*/ void WriteEndObject();
                /*0x21eef94*/ void WriteRawValue(string json);
                /*0x21eeff8*/ void WriteRaw(string json);
                /*0x21ef05c*/ void Close();
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

                static /*0x1a9da60*/ Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1a9d4e0*/ JArray();
                /*0x1a9d5b8*/ JArray(Newtonsoft.Json.Linq.JArray other);
                /*0x1a9d96c*/ JArray(object content);
                /*0x1a9d4d0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x1a9d4d8*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x1a9da04*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0x1a9df98*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x1a9e078*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                /*0x1a9e088*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x1a9e098*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9e10c*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9e11c*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x1a9e130*/ void RemoveAt(int index);
                /*0x1a9e140*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                /*0x1a9e1b4*/ void Add(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9e1c4*/ void Clear();
                /*0x1a9e1d4*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9e1e4*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x1a9e1f4*/ bool get_IsReadOnly();
                /*0x1a9e1fc*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
            }

            class JConstructor : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ string _name;
                /*0x58*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0x1a9e5a0*/ Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1a9e298*/ JConstructor(Newtonsoft.Json.Linq.JConstructor other);
                /*0x1a9e330*/ JConstructor(string name);
                /*0x1a9e20c*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x1a9e214*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9e288*/ string get_Name();
                /*0x1a9e290*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x1a9e454*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0x1a9e4b0*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
            }

            class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.ComponentModel.IBindingList, System.Collections.ICollection, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged
            {
                /*0x30*/ System.ComponentModel.ListChangedEventHandler _listChanged;
                /*0x38*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;
                /*0x40*/ object _syncRoot;
                /*0x48*/ bool _busy;

                static /*0x1aa02e4*/ bool IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue);
                static /*0x1aa10dc*/ Newtonsoft.Json.Linq.JToken CreateFromContent(object content);
                static /*0x1aa1738*/ Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent);
                /*0x1a9d554*/ JContainer();
                /*0x1a9d63c*/ JContainer(Newtonsoft.Json.Linq.JContainer other);
                /*0x1a9e7c4*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x1a9e840*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x1a9ecb0*/ void CheckReentrancy();
                /*0x1a9ed7c*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
                /*0x1a9ede8*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x1a9ee54*/ bool get_HasValues();
                /*0x1a9ef20*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x1a9f070*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x1a9f1c0*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x1a9f238*/ bool IsMultiContent(object content);
                /*0x1a9f320*/ Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9f428*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                /*0x1a9f848*/ void RemoveItemAt(int index);
                /*0x1a9fcd8*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1a9fd30*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x1a9fe00*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x1aa03ac*/ void ClearItems();
                /*0x1aa0794*/ void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement);
                /*0x1aa07fc*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa0824*/ void CopyItemsTo(System.Array array, int arrayIndex);
                /*0x1aa0cf4*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x1aa0e3c*/ void Add(object content);
                /*0x1aa0f1c*/ bool TryAdd(object content);
                /*0x1aa0ffc*/ void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token);
                /*0x1a9e8c4*/ bool TryAddInternal(int index, object content, bool skipParentCheck);
                /*0x1aa11c8*/ void RemoveAll();
                /*0x1a9dde8*/ void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options);
                /*0x1aa11d8*/ void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1aa1c10*/ int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa1c20*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x1aa1c34*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index);
                /*0x1aa1c44*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index);
                /*0x1aa1c54*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0x1aa1c64*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa1c74*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear();
                /*0x1aa1c84*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa1c94*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0x1aa1ca4*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly();
                /*0x1aa1cac*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa1cbc*/ Newtonsoft.Json.Linq.JToken EnsureValue(object value);
                /*0x1aa1d7c*/ int System.Collections.IList.Add(object value);
                /*0x1aa1dc0*/ void System.Collections.IList.Clear();
                /*0x1aa1dd0*/ bool System.Collections.IList.Contains(object value);
                /*0x1aa1e04*/ int System.Collections.IList.IndexOf(object value);
                /*0x1aa1e38*/ void System.Collections.IList.Insert(int index, object value);
                /*0x1aa1e7c*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x1aa1e84*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x1aa1e8c*/ void System.Collections.IList.Remove(object value);
                /*0x1aa1ec0*/ void System.Collections.IList.RemoveAt(int index);
                /*0x1aa1ed0*/ object System.Collections.IList.get_Item(int index);
                /*0x1aa1ee0*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x1aa1f20*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1aa0c34*/ int get_Count();
                /*0x1aa1f30*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1aa1f38*/ object System.Collections.ICollection.get_SyncRoot();
            }

            struct JEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>>
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JEnumerable<T> Empty;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> _enumerable;

                static JEnumerable();
                JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other);
                bool Equals(object obj);
                int GetHashCode();
            }

            class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x50*/ Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;
                /*0x58*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
                /*0x60*/ System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

                static /*0x1aa2ad0*/ Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0x1aa2cc0*/ Newtonsoft.Json.Linq.JObject Parse(string json);
                static /*0x1aa2cc8*/ Newtonsoft.Json.Linq.JObject Parse(string json, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1aa1620*/ JObject();
                /*0x1aa2184*/ JObject(Newtonsoft.Json.Linq.JObject other);
                /*0x1aa21f0*/ JObject(object[] content);
                /*0x1aa21f4*/ JObject(object content);
                /*0x1aa1fb0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x1aa1fb8*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x1aa2058*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x1aa2274*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa2348*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                /*0x1aa23b4*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0x1aa26a0*/ void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x1aa27f0*/ void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0x1aa2814*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0x1aa2870*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x1aa2878*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties();
                /*0x1aa1968*/ Newtonsoft.Json.Linq.JProperty Property(string name, System.StringComparison comparison);
                /*0x1aa28c4*/ Newtonsoft.Json.Linq.JToken get_Item(string propertyName);
                /*0x1aa2948*/ void set_Item(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x1aa2e88*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x1aa2a50*/ void Add(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0x1aa305c*/ bool ContainsKey(string propertyName);
                /*0x1aa3188*/ System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys();
                /*0x1aa31fc*/ bool Remove(string propertyName);
                /*0x1aa3290*/ bool TryGetValue(string propertyName, ref Newtonsoft.Json.Linq.JToken value);
                /*0x1aa32d8*/ System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values();
                /*0x1aa3318*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x1aa33b0*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear();
                /*0x1aa33c0*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x1aa3444*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> array, int arrayIndex);
                /*0x1aa388c*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly();
                /*0x1aa3894*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0x1aa39ec*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> GetEnumerator();
                /*0x1aa3a58*/ void OnPropertyChanged(string propertyName);
                /*0x1aa3ae8*/ void OnPropertyChanging(string propertyName);
                /*0x1aa3b78*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x1aa3c20*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x1aa3f64*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x1aa3fc8*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x1aa4020*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                /*0x1aa40a8*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);

                class JObjectDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JObject>
                {
                    /*0x21fefc0*/ JObjectDynamicProxy();
                    /*0x21fee88*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance);

                    class <>c
                    {
                        static /*0x0*/ Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<> <>9;
                        static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JProperty, string> <>9__2_0;

                        static /*0x220042c*/ <>c();
                        /*0x220048c*/ <>c();
                        /*0x2200494*/ string <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p);
                    }
                }

                class <GetEnumerator>d__63 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> <>2__current;
                    /*0x28*/ Newtonsoft.Json.Linq.JObject <>4__this;
                    /*0x30*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;

                    /*0x21fea10*/ <GetEnumerator>d__63(int <>1__state);
                    /*0x21fea3c*/ void System.IDisposable.Dispose();
                    /*0x21feb14*/ bool MoveNext();
                    /*0x21fea58*/ void <>m__Finally1();
                    /*0x21feddc*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current();
                    /*0x21fede8*/ void System.Collections.IEnumerator.Reset();
                    /*0x21fee28*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class JProperty : Newtonsoft.Json.Linq.JContainer
            {
                /*0x50*/ Newtonsoft.Json.Linq.JProperty.JPropertyList _content;
                /*0x58*/ string _name;

                static /*0x1aa499c*/ Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1aa4168*/ JProperty(Newtonsoft.Json.Linq.JProperty other);
                /*0x1aa1b00*/ JProperty(string name);
                /*0x1aa2f74*/ JProperty(string name, object content);
                /*0x1aa4158*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0x1aa4160*/ string get_Name();
                /*0x1aa1604*/ Newtonsoft.Json.Linq.JToken get_Value();
                /*0x1aa29d0*/ void set_Value(Newtonsoft.Json.Linq.JToken value);
                /*0x1aa41ec*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0x1aa424c*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x1aa4394*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa4504*/ void RemoveItemAt(int index);
                /*0x1aa4600*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa4628*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                /*0x1aa4788*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa47ac*/ void ClearItems();
                /*0x1aa48a8*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0x1aa4904*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x1aa490c*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);

                class JPropertyList : System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JToken _token;

                    /*0x21ff240*/ JPropertyList();
                    /*0x21ff00c*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                    /*0x21ff0a4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x21ff0a8*/ void Add(Newtonsoft.Json.Linq.JToken item);
                    /*0x21ff0b0*/ void Clear();
                    /*0x21ff0b8*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                    /*0x21ff0c8*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                    /*0x21ff140*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
                    /*0x21ff160*/ int get_Count();
                    /*0x21ff170*/ bool get_IsReadOnly();
                    /*0x21ff178*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                    /*0x21ff188*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                    /*0x21ff198*/ void RemoveAt(int index);
                    /*0x21ff1a8*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                    /*0x21ff1f4*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);

                    class <GetEnumerator>d__1 : System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ Newtonsoft.Json.Linq.JProperty.JPropertyList <>4__this;

                        /*0x21ff078*/ <GetEnumerator>d__1(int <>1__state);
                        /*0x22004ac*/ void System.IDisposable.Dispose();
                        /*0x22004b0*/ bool MoveNext();
                        /*0x2200510*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0x2200518*/ void System.Collections.IEnumerator.Reset();
                        /*0x2200558*/ object System.Collections.IEnumerator.get_Current();
                    }
                }
            }

            class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x1aa3f58*/ JPropertyDescriptor(string name);
                /*0x1aa4bc0*/ bool CanResetValue(object component);
                /*0x1aa4bc8*/ object GetValue(object component);
                /*0x1aa4c6c*/ void ResetValue(object component);
                /*0x1aa4c70*/ void SetValue(object component, object value);
                /*0x1aa4db0*/ bool ShouldSerializeValue(object component);
                /*0x1aa4db8*/ System.Type get_ComponentType();
                /*0x1aa4e30*/ bool get_IsReadOnly();
                /*0x1aa4e38*/ System.Type get_PropertyType();
                /*0x1aa4eb0*/ int get_NameHashCode();
            }

            class JPropertyKeyedCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.Linq.JToken>
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<string> Comparer;
                /*0x20*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Linq.JToken> _dictionary;

                static /*0x1aa54f8*/ JPropertyKeyedCollection();
                /*0x1aa20f8*/ JPropertyKeyedCollection();
                /*0x1aa4eb8*/ void AddKey(string key, Newtonsoft.Json.Linq.JToken item);
                /*0x1aa4fe8*/ void ClearItems();
                /*0x1aa30cc*/ bool Contains(string key);
                /*0x1aa4f2c*/ void EnsureDictionary();
                /*0x1aa5064*/ string GetKeyForItem(Newtonsoft.Json.Linq.JToken item);
                /*0x1aa50e8*/ void InsertItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x1aa5164*/ void RemoveItem(int index);
                /*0x1aa5264*/ void RemoveKey(string key);
                /*0x1aa52d4*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0x1aa2624*/ bool TryGetValue(string key, ref Newtonsoft.Json.Linq.JToken value);
                /*0x1aa31a0*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0x1aa2298*/ int IndexOfReference(Newtonsoft.Json.Linq.JToken t);
            }

            class JRaw : Newtonsoft.Json.Linq.JValue
            {
                static /*0x1aa56dc*/ Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader);
                /*0x1aa55b4*/ JRaw(Newtonsoft.Json.Linq.JRaw other);
                /*0x1aa5654*/ JRaw(object rawJson);
                /*0x1aa59b0*/ Newtonsoft.Json.Linq.JToken CloneToken();
            }

            class JsonLoadSettings
            {
                /*0x10*/ Newtonsoft.Json.Linq.CommentHandling _commentHandling;
                /*0x14*/ Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;
                /*0x18*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

                /*0x190f7f8*/ Newtonsoft.Json.Linq.CommentHandling get_CommentHandling();
                /*0x190f800*/ Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling();
                /*0x190f808*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling();
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

                static /*0x1aadf8c*/ JToken();
                static /*0x1aa6200*/ Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa6318*/ string GetType(Newtonsoft.Json.Linq.JToken token);
                static /*0x1aa642c*/ bool ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, bool nullable);
                static /*0x1aa64f0*/ bool op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa6790*/ System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa6a70*/ System.Nullable<bool> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa6d44*/ long op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa6fb0*/ System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa7240*/ System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa7598*/ System.Nullable<decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa7854*/ System.Nullable<double> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa7af8*/ System.Nullable<char> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa7d98*/ int op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa8004*/ short op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa8270*/ ushort op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa84dc*/ char op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa8748*/ byte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa89b4*/ sbyte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa8c20*/ System.Nullable<int> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa8ec0*/ System.Nullable<short> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa9160*/ System.Nullable<ushort> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa9400*/ System.Nullable<byte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa96a0*/ System.Nullable<sbyte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa9940*/ System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa9b98*/ System.Nullable<long> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aa9e40*/ System.Nullable<float> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aaa0dc*/ decimal op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aaa348*/ System.Nullable<uint> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aaa5e8*/ System.Nullable<ulong> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aaa890*/ double op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aaaafc*/ float op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aaad68*/ string op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aab054*/ uint op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aab2c0*/ ulong op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aab52c*/ System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aab7c8*/ System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aabaa0*/ System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aabd24*/ System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aabfe0*/ System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aac250*/ System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aac410*/ System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value);
                static /*0x1aad79c*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader);
                static /*0x1aad800*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1a9e8bc*/ JToken();
                /*0x1aa5a0c*/ Newtonsoft.Json.Linq.JContainer get_Parent();
                /*0x1aa5a14*/ void set_Parent(Newtonsoft.Json.Linq.JContainer value);
                /*0x1a9f410*/ Newtonsoft.Json.Linq.JToken get_Root();
                Newtonsoft.Json.Linq.JToken CloneToken();
                Newtonsoft.Json.Linq.JTokenType get_Type();
                bool get_HasValues();
                /*0x1aa5a1c*/ Newtonsoft.Json.Linq.JToken get_Next();
                /*0x1aa5a24*/ void set_Next(Newtonsoft.Json.Linq.JToken value);
                /*0x1aa5a2c*/ Newtonsoft.Json.Linq.JToken get_Previous();
                /*0x1aa5a34*/ void set_Previous(Newtonsoft.Json.Linq.JToken value);
                /*0x1aa5a3c*/ string get_Path();
                /*0x1aa5d2c*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0x1aa5de8*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0x1aa5ea4*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                /*0x1aa3220*/ void Remove();
                /*0x1aa1b98*/ void Replace(Newtonsoft.Json.Linq.JToken value);
                void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x1aa5f08*/ string ToString();
                /*0x1aa5fe0*/ string ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters);
                /*0x1aac628*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1aac6c8*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                /*0x1aac73c*/ Newtonsoft.Json.JsonReader CreateReader();
                /*0x1aac808*/ object ToObject(System.Type objectType);
                /*0x1aad5fc*/ object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0x1a9dc2c*/ void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0x1aadaf4*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0x1aadd98*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x1aaddf0*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x1aade48*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x1aadea0*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x1aadf64*/ System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x1aadf74*/ object System.ICloneable.Clone();
                /*0x1aadf80*/ Newtonsoft.Json.Linq.JToken DeepClone();
                /*0x1aadb6c*/ void AddAnnotation(object annotation);
                T Annotation<T>();
                /*0x1a9ec14*/ void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source);

                class LineInfoAnnotation
                {
                    /*0x10*/ int LineNumber;
                    /*0x14*/ int LinePosition;

                    /*0x21ff248*/ LineInfoAnnotation(int lineNumber, int linePosition);
                }
            }

            class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.Linq.JToken _root;
                /*0x80*/ string _initialPath;
                /*0x88*/ Newtonsoft.Json.Linq.JToken _parent;
                /*0x90*/ Newtonsoft.Json.Linq.JToken _current;

                /*0x1aac798*/ JTokenReader(Newtonsoft.Json.Linq.JToken token);
                /*0x1aae22c*/ Newtonsoft.Json.Linq.JToken get_CurrentToken();
                /*0x1aae234*/ bool Read();
                /*0x1aae380*/ bool ReadOver(Newtonsoft.Json.Linq.JToken t);
                /*0x1aaea44*/ bool ReadToEnd();
                /*0x1aaeafc*/ System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c);
                /*0x1aae308*/ bool ReadInto(Newtonsoft.Json.Linq.JContainer c);
                /*0x1aaea68*/ bool SetEnd(Newtonsoft.Json.Linq.JContainer c);
                /*0x1aae444*/ void SetToken(Newtonsoft.Json.Linq.JToken token);
                /*0x1aaec50*/ string SafeToString(object value);
                /*0x1aaec70*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0x1aaed30*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0x1aaedf4*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0x1aaeeb8*/ string get_Path();
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

                /*0x1aaefb8*/ JTokenWriter();
                /*0x1aaefa0*/ Newtonsoft.Json.Linq.JToken get_Token();
                /*0x1aaf01c*/ void Close();
                /*0x1aaf024*/ void WriteStartObject();
                /*0x1aaf0a4*/ void AddParent(Newtonsoft.Json.Linq.JContainer container);
                /*0x1aaf0e4*/ void RemoveParent();
                /*0x1aaf140*/ void WriteStartArray();
                /*0x1aaf1c0*/ void WriteStartConstructor(string name);
                /*0x1aaf254*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
                /*0x1aaf258*/ void WritePropertyName(string name);
                /*0x1aaf338*/ void AddValue(object value, Newtonsoft.Json.JsonToken token);
                /*0x1aaf3b8*/ void AddValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token);
                /*0x1aaf448*/ void WriteValue(object value);
                /*0x1aaf4e4*/ void WriteNull();
                /*0x1aaf510*/ void WriteUndefined();
                /*0x1aaf53c*/ void WriteRaw(string json);
                /*0x1aaf5bc*/ void WriteComment(string text);
                /*0x1aaf5f4*/ void WriteValue(string value);
                /*0x1aaf628*/ void WriteValue(int value);
                /*0x1aaf6a8*/ void WriteValue(uint value);
                /*0x1aaf728*/ void WriteValue(long value);
                /*0x1aaf7a8*/ void WriteValue(ulong value);
                /*0x1aaf828*/ void WriteValue(float value);
                /*0x1aaf8a8*/ void WriteValue(double value);
                /*0x1aaf928*/ void WriteValue(bool value);
                /*0x1aaf9a8*/ void WriteValue(short value);
                /*0x1aafa28*/ void WriteValue(ushort value);
                /*0x1aafaa8*/ void WriteValue(char value);
                /*0x1aafb4c*/ void WriteValue(byte value);
                /*0x1aafbcc*/ void WriteValue(sbyte value);
                /*0x1aafc4c*/ void WriteValue(decimal value);
                /*0x1aafcdc*/ void WriteValue(System.DateTime value);
                /*0x1aafda0*/ void WriteValue(System.DateTimeOffset value);
                /*0x1aafe30*/ void WriteValue(byte[] value);
                /*0x1aafe64*/ void WriteValue(System.TimeSpan value);
                /*0x1aafee4*/ void WriteValue(System.Guid value);
                /*0x1aaff74*/ void WriteValue(System.Uri value);
                /*0x1aaffa8*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            }

            class JValue : Newtonsoft.Json.Linq.JToken, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IConvertible
            {
                /*0x30*/ Newtonsoft.Json.Linq.JTokenType _valueType;
                /*0x38*/ object _value;

                static /*0x1ab06a0*/ int CompareBigInteger(System.Numerics.BigInteger i1, object i2);
                static /*0x1ab092c*/ int Compare(Newtonsoft.Json.Linq.JTokenType valueType, object objA, object objB);
                static /*0x1ab1368*/ int CompareFloat(object objA, object objB);
                static /*0x1aa167c*/ Newtonsoft.Json.Linq.JValue CreateComment(string value);
                static /*0x1a9f3b4*/ Newtonsoft.Json.Linq.JValue CreateNull();
                static /*0x1aa16dc*/ Newtonsoft.Json.Linq.JValue CreateUndefined();
                static /*0x1ab0214*/ Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value);
                static /*0x1ab14d4*/ Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current);
                static /*0x1ab1d94*/ bool ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2);
                /*0x1aa565c*/ JValue(object value, Newtonsoft.Json.Linq.JTokenType type);
                /*0x1aa55b8*/ JValue(Newtonsoft.Json.Linq.JValue other);
                /*0x1aa1194*/ JValue(object value);
                /*0x1ab0698*/ bool get_HasValues();
                /*0x1ab1478*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0x1ab1550*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0x1ab1558*/ object get_Value();
                /*0x1ab1560*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0x1ab1df4*/ bool Equals(Newtonsoft.Json.Linq.JValue other);
                /*0x1ab1e04*/ bool Equals(object obj);
                /*0x1ab1ea0*/ int GetHashCode();
                /*0x1ab1eb8*/ string ToString();
                /*0x1ab1f24*/ string ToString(System.IFormatProvider formatProvider);
                /*0x1ab1f30*/ string ToString(string format, System.IFormatProvider formatProvider);
                /*0x1ab2064*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0x1ab2114*/ int System.IComparable.CompareTo(object obj);
                /*0x1ab21d0*/ int CompareTo(Newtonsoft.Json.Linq.JValue obj);
                /*0x1ab2200*/ System.TypeCode System.IConvertible.GetTypeCode();
                /*0x1ab22c8*/ bool System.IConvertible.ToBoolean(System.IFormatProvider provider);
                /*0x1ab2328*/ char System.IConvertible.ToChar(System.IFormatProvider provider);
                /*0x1ab2388*/ sbyte System.IConvertible.ToSByte(System.IFormatProvider provider);
                /*0x1ab23e8*/ byte System.IConvertible.ToByte(System.IFormatProvider provider);
                /*0x1ab2448*/ short System.IConvertible.ToInt16(System.IFormatProvider provider);
                /*0x1ab24a8*/ ushort System.IConvertible.ToUInt16(System.IFormatProvider provider);
                /*0x1ab2508*/ int System.IConvertible.ToInt32(System.IFormatProvider provider);
                /*0x1ab2568*/ uint System.IConvertible.ToUInt32(System.IFormatProvider provider);
                /*0x1ab25c8*/ long System.IConvertible.ToInt64(System.IFormatProvider provider);
                /*0x1ab2628*/ ulong System.IConvertible.ToUInt64(System.IFormatProvider provider);
                /*0x1ab2688*/ float System.IConvertible.ToSingle(System.IFormatProvider provider);
                /*0x1ab26e8*/ double System.IConvertible.ToDouble(System.IFormatProvider provider);
                /*0x1ab2748*/ decimal System.IConvertible.ToDecimal(System.IFormatProvider provider);
                /*0x1ab27a8*/ System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider);
                /*0x1ab2808*/ object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider);

                class JValueDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JValue>
                {
                    /*0x21ff280*/ JValueDynamicProxy();
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

                static /*0x1717998*/ void EnsureReflectionObject(System.Type t);
                /*0x17183c4*/ BinaryConverter();
                /*0x1717728*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x171778c*/ byte[] GetByteArray(object value);
                /*0x1717b5c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1718008*/ byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader);
                /*0x171828c*/ bool CanConvert(System.Type objectType);
            }

            class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x1718a7c*/ BsonObjectIdConverter();
                /*0x1718668*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1718844*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x17189f0*/ bool CanConvert(System.Type objectType);
            }

            class CustomCreationConverter<T> : Newtonsoft.Json.JsonConverter
            {
                CustomCreationConverter();
                void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                T Create(System.Type objectType);
                bool CanConvert(System.Type objectType);
                bool get_CanWrite();
            }

            class DataSetConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x171eac8*/ DataSetConverter();
                /*0x171e2e0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x171e734*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x171ea30*/ bool CanConvert(System.Type valueType);
            }

            class DataTableConverter : Newtonsoft.Json.JsonConverter
            {
                static /*0x171f568*/ void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer);
                static /*0x171fa78*/ System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader);
                /*0x171e71c*/ DataTableConverter();
                /*0x171ead0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x171f248*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x171fc74*/ bool CanConvert(System.Type valueType);
            }

            class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
            {
                /*0x171fea4*/ DateTimeConverterBase();
                /*0x171fd0c*/ bool CanConvert(System.Type objectType);
            }

            class DiscriminatedUnionConverter : Newtonsoft.Json.JsonConverter
            {
                static string CasePropertyName = "Case";
                static string FieldsPropertyName = "Fields";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache;

                static /*0x172e518*/ DiscriminatedUnionConverter();
                static /*0x172ca0c*/ System.Type CreateUnionTypeLookup(System.Type t);
                static /*0x172cc4c*/ Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t);
                /*0x172b798*/ DiscriminatedUnionConverter();
                /*0x172d458*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x172d994*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x172e0bc*/ bool CanConvert(System.Type objectType);

                class Union
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.FSharpFunction TagReader;
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;

                    /*0x21fd738*/ Union(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases);
                }

                class UnionCase
                {
                    /*0x10*/ int Tag;
                    /*0x18*/ string Name;
                    /*0x20*/ System.Reflection.PropertyInfo[] Fields;
                    /*0x28*/ Newtonsoft.Json.Utilities.FSharpFunction FieldReader;
                    /*0x30*/ Newtonsoft.Json.Utilities.FSharpFunction Constructor;

                    /*0x21fd770*/ UnionCase(int tag, string name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ int tag;

                    /*0x21fd6e0*/ <>c__DisplayClass8_0();
                    /*0x21fd6e8*/ bool <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ string caseName;
                    /*0x18*/ System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> <>9__0;

                    /*0x21fd70c*/ <>c__DisplayClass9_0();
                    /*0x21fd714*/ bool <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }
            }

            class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
            {
                static string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
                static string KeyPropertyName = "Key";
                static string TypePropertyName = "Type";
                static string ValuePropertyName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0x172ec58*/ void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, string propertyName);
                static /*0x172eb20*/ void EnsureReflectionObject(System.Type objectType);
                /*0x172b788*/ EntityKeyMemberConverter();
                /*0x172e7a8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x172ed70*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x172f078*/ bool CanConvert(System.Type objectType);
            }

            class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x172b790*/ ExpandoObjectConverter();
                /*0x1730a80*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1730a84*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1730a88*/ object ReadValue(Newtonsoft.Json.JsonReader reader);
                /*0x1730dd8*/ object ReadList(Newtonsoft.Json.JsonReader reader);
                /*0x1730c10*/ object ReadObject(Newtonsoft.Json.JsonReader reader);
                /*0x1730f74*/ bool CanConvert(System.Type objectType);
                /*0x1731000*/ bool get_CanWrite();
            }

            class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
                /*0x10*/ System.Globalization.DateTimeStyles _dateTimeStyles;
                /*0x18*/ string _dateTimeFormat;
                /*0x20*/ System.Globalization.CultureInfo _culture;

                /*0x1a9d4c0*/ IsoDateTimeConverter();
                /*0x1a9cb8c*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
                /*0x1a9cb94*/ void set_DateTimeStyles(System.Globalization.DateTimeStyles value);
                /*0x1a9cb9c*/ string get_DateTimeFormat();
                /*0x1a9cbf4*/ void set_DateTimeFormat(string value);
                /*0x1a9cc34*/ System.Globalization.CultureInfo get_Culture();
                /*0x1a9cca8*/ void set_Culture(System.Globalization.CultureInfo value);
                /*0x1a9ccb0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1a9cf24*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                /*0x1ab3118*/ JavaScriptDateTimeConverter();
                /*0x1ab280c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1ab29d4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
            {
                static string KeyName = "Key";
                static string ValueName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

                static /*0x20a0a7c*/ KeyValuePairConverter();
                static /*0x209f4c0*/ Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t);
                /*0x20a0a74*/ KeyValuePairConverter();
                /*0x20a005c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x20a0374*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x20a094c*/ bool CanConvert(System.Type objectType);
            }

            class RegexConverter : Newtonsoft.Json.JsonConverter
            {
                static string PatternName = "Pattern";
                static string OptionsName = "Options";

                /*0x21ea210*/ RegexConverter();
                /*0x21e983c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21e9c74*/ bool HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag);
                /*0x21e9970*/ void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex);
                /*0x21e9ab4*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21e9c80*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21e9f9c*/ object ReadRegexString(Newtonsoft.Json.JsonReader reader);
                /*0x21e9d2c*/ System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21ea104*/ bool CanConvert(System.Type objectType);
                /*0x21ea184*/ bool IsRegex(System.Type objectType);
            }

            class StringEnumConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;
                /*0x18*/ bool <AllowIntegerValues>k__BackingField;

                /*0x21eb010*/ StringEnumConverter();
                /*0x21eb020*/ StringEnumConverter(bool camelCaseText);
                /*0x21eb0a0*/ StringEnumConverter(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, bool allowIntegerValues);
                /*0x21eb0e8*/ StringEnumConverter(System.Type namingStrategyType);
                /*0x21eb198*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters);
                /*0x21eb24c*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues);
                /*0x21eaeb8*/ bool get_CamelCaseText();
                /*0x21eaf38*/ void set_CamelCaseText(bool value);
                /*0x21eafec*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x21eaff4*/ void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value);
                /*0x21eaffc*/ bool get_AllowIntegerValues();
                /*0x21eb004*/ void set_AllowIntegerValues(bool value);
                /*0x21eb314*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21eb534*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21eba88*/ bool CanConvert(System.Type objectType);
            }

            class UnixDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static /*0x0*/ System.DateTime UnixEpoch;

                static /*0x21efef4*/ UnixDateTimeConverter();
                /*0x21efeec*/ UnixDateTimeConverter();
                /*0x21ef7e8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21efa50*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class VersionConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x21f03d4*/ VersionConverter();
                /*0x21eff78*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21f0070*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21f0348*/ bool CanConvert(System.Type objectType);
            }

            class XmlDocumentWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocument _document;

                /*0x21f2c68*/ XmlDocumentWrapper(System.Xml.XmlDocument document);
                /*0x21f2c98*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string data);
                /*0x21f2d2c*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x21f2dc0*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x21f2e54*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x21f2ee8*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x21f2f7c*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x21f302c*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x21f30e0*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x21f317c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x21f323c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x21f32d4*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x21f33a0*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x21f345c*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            class XmlElementWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlElement _element;

                /*0x21f320c*/ XmlElementWrapper(System.Xml.XmlElement element);
                /*0x21f34f8*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x21f35ec*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x21f3610*/ bool get_IsEmpty();
            }

            class XmlDeclarationWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDeclaration _declaration;

                /*0x21f2ad0*/ XmlDeclarationWrapper(System.Xml.XmlDeclaration declaration);
                /*0x21f2b2c*/ string get_Version();
                /*0x21f2b48*/ string get_Encoding();
                /*0x21f2b64*/ string get_Standalone();
            }

            class XmlDocumentTypeWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocumentType _documentType;

                /*0x21f2b80*/ XmlDocumentTypeWrapper(System.Xml.XmlDocumentType documentType);
                /*0x21f2bb0*/ string get_Name();
                /*0x21f2bd0*/ string get_System();
                /*0x21f2bec*/ string get_Public();
                /*0x21f2c08*/ string get_InternalSubset();
                /*0x21f2c24*/ string get_LocalName();
            }

            class XmlNodeWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.XmlNode _node;
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                static /*0x21f5834*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node);
                /*0x21f2b00*/ XmlNodeWrapper(System.Xml.XmlNode node);
                /*0x21fbd8c*/ object get_WrappedNode();
                /*0x21fbd94*/ System.Xml.XmlNodeType get_NodeType();
                /*0x21fbdb4*/ string get_LocalName();
                /*0x21fbdd8*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x21fc188*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x21fc530*/ bool get_HasAttributes();
                /*0x21fc5e4*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x21fc684*/ string get_Value();
                /*0x21f3380*/ void set_Value(string value);
                /*0x21fc6a4*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x21fc754*/ string get_NamespaceUri();
            }

            interface IXmlDocument : Newtonsoft.Json.Converters.IXmlNode
            {
                Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            interface IXmlDeclaration : Newtonsoft.Json.Converters.IXmlNode
            {
                string get_Version();
                string get_Encoding();
                string get_Standalone();
            }

            interface IXmlDocumentType : Newtonsoft.Json.Converters.IXmlNode
            {
                string get_Name();
                string get_System();
                string get_Public();
                string get_InternalSubset();
            }

            interface IXmlElement : Newtonsoft.Json.Converters.IXmlNode
            {
                void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                string GetPrefixOfNamespace(string namespaceUri);
                bool get_IsEmpty();
            }

            interface IXmlNode
            {
                System.Xml.XmlNodeType get_NodeType();
                string get_LocalName();
                System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                string get_Value();
                Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                string get_NamespaceUri();
                object get_WrappedNode();
            }

            class XDeclarationWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDeclaration <Declaration>k__BackingField;

                /*0x21f102c*/ XDeclarationWrapper(System.Xml.Linq.XDeclaration declaration);
                /*0x21f1024*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x21f1058*/ System.Xml.XmlNodeType get_NodeType();
                /*0x21f1060*/ string get_Version();
                /*0x21f107c*/ string get_Encoding();
                /*0x21f1098*/ string get_Standalone();
            }

            class XDocumentTypeWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDocumentType _documentType;

                /*0x21f0f14*/ XDocumentTypeWrapper(System.Xml.Linq.XDocumentType documentType);
                /*0x21f10b4*/ string get_Name();
                /*0x21f10d0*/ string get_System();
                /*0x21f10ec*/ string get_Public();
                /*0x21f1108*/ string get_InternalSubset();
                /*0x21f1124*/ string get_LocalName();
            }

            class XDocumentWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x21f0e64*/ XDocumentWrapper(System.Xml.Linq.XDocument document);
                /*0x21f1168*/ System.Xml.Linq.XDocument get_Document();
                /*0x21f11e4*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x21f1354*/ bool get_HasChildNodes();
                /*0x21f139c*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x21f1428*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x21f14b4*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x21f1540*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x21f15cc*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x21f1658*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x21f16fc*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x21f17b0*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x21f184c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x21f18ec*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x21f19a4*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x21f1a54*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x21f1b14*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
                /*0x21f1bb4*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XTextWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x21f0ee8*/ XTextWrapper(System.Xml.Linq.XText text);
                /*0x21f29e0*/ System.Xml.Linq.XText get_Text();
                /*0x21f2a5c*/ string get_Value();
                /*0x21f2a7c*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XCommentWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x21f08fc*/ XCommentWrapper(System.Xml.Linq.XComment text);
                /*0x21f0880*/ System.Xml.Linq.XComment get_Text();
                /*0x21f0928*/ string get_Value();
                /*0x21f0948*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XProcessingInstructionWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x21f0ebc*/ XProcessingInstructionWrapper(System.Xml.Linq.XProcessingInstruction processingInstruction);
                /*0x21f2924*/ System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction();
                /*0x21f29a0*/ string get_LocalName();
                /*0x21f29c0*/ string get_Value();
            }

            class XContainerWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;

                static /*0x21f0574*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node);
                /*0x21f0a18*/ XContainerWrapper(System.Xml.Linq.XContainer container);
                /*0x21f099c*/ System.Xml.Linq.XContainer get_Container();
                /*0x21f0a44*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x21f0de4*/ bool get_HasChildNodes();
                /*0x21f0e10*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x21f0f40*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XObjectWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.Linq.XObject _xmlObject;

                /*0x21f0484*/ XObjectWrapper(System.Xml.Linq.XObject xmlObject);
                /*0x21f27dc*/ object get_WrappedNode();
                /*0x21f27e4*/ System.Xml.XmlNodeType get_NodeType();
                /*0x21f27fc*/ string get_LocalName();
                /*0x21f2804*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x21f2868*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x21f28cc*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x21f28d4*/ string get_Value();
                /*0x21f28dc*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x21f291c*/ string get_NamespaceUri();
            }

            class XAttributeWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x21f0458*/ XAttributeWrapper(System.Xml.Linq.XAttribute attribute);
                /*0x21f03dc*/ System.Xml.Linq.XAttribute get_Attribute();
                /*0x21f04b0*/ string get_Value();
                /*0x21f04d0*/ string get_LocalName();
                /*0x21f04f8*/ string get_NamespaceUri();
                /*0x21f0520*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XElementWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                /*0x21f0e90*/ XElementWrapper(System.Xml.Linq.XElement element);
                /*0x21f1c68*/ System.Xml.Linq.XElement get_Element();
                /*0x21f1ce4*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x21f1d98*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x21f2264*/ bool HasImplicitNamespaceAttribute(string namespaceUri);
                /*0x21f2728*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x21f274c*/ string get_Value();
                /*0x21f276c*/ string get_LocalName();
                /*0x21f2794*/ string get_NamespaceUri();
                /*0x21f26e4*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x21f27bc*/ bool get_IsEmpty();
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

                static /*0x21fbd04*/ XmlNodeConverter();
                static /*0x21f7048*/ bool AllSameName(Newtonsoft.Json.Converters.IXmlNode node);
                static /*0x21faa84*/ void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, string attributeName, System.Xml.XmlNamespaceManager manager, string attributePrefix);
                static /*0x21f9068*/ string ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader);
                /*0x21fbcfc*/ XmlNodeConverter();
                /*0x21f362c*/ string get_DeserializeRootElementName();
                /*0x21f3634*/ void set_DeserializeRootElementName(string value);
                /*0x21f363c*/ bool get_WriteArrayAttribute();
                /*0x21f3644*/ void set_WriteArrayAttribute(bool value);
                /*0x21f3650*/ bool get_OmitRootObject();
                /*0x21f3658*/ void set_OmitRootObject(bool value);
                /*0x21f3664*/ bool get_EncodeSpecialCharacters();
                /*0x21f366c*/ void set_EncodeSpecialCharacters(bool value);
                /*0x21f3678*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21f37bc*/ Newtonsoft.Json.Converters.IXmlNode WrapXml(object value);
                /*0x21f38d8*/ void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x21f59ac*/ string ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x21f5d14*/ string GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x21f6188*/ bool IsArray(Newtonsoft.Json.Converters.IXmlNode node);
                /*0x21f6514*/ void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x21f6e08*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames);
                /*0x21f6f74*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, string elementNames);
                /*0x21f3f74*/ void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x21f75e8*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x21f8a40*/ void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x21f7ee0*/ void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, System.Xml.XmlNamespaceManager manager);
                /*0x21fae58*/ void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string elementName, System.Xml.XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<string, string> attributeNameValues);
                /*0x21fa094*/ void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager);
                /*0x21fb6b0*/ void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document);
                /*0x21fa418*/ bool ShouldReadInto(Newtonsoft.Json.JsonReader reader);
                /*0x21fa464*/ System.Collections.Generic.Dictionary<string, string> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager);
                /*0x21f976c*/ void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName);
                /*0x21f9c60*/ void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x21fb4c0*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName, Newtonsoft.Json.Converters.IXmlDocument document, string elementPrefix, System.Xml.XmlNamespaceManager manager);
                /*0x21f822c*/ void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x21fba1c*/ bool IsNamespaceAttribute(string attributeName, ref string prefix);
                /*0x21f72e8*/ bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c);
                /*0x21fbb08*/ bool CanConvert(System.Type valueType);
                /*0x21fbbcc*/ bool IsXObject(System.Type valueType);
                /*0x21fbc64*/ bool IsXmlNode(System.Type valueType);
            }
        }

        namespace Bson
        {
            class BsonObjectId
            {
                /*0x10*/ byte[] <Value>k__BackingField;

                /*0x1718588*/ BsonObjectId(byte[] value);
                /*0x1718580*/ byte[] get_Value();
            }

            class BsonToken
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;

                /*0x1718b50*/ BsonToken();
                Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x1718b9c*/ void set_Parent(Newtonsoft.Json.Bson.BsonToken value);
            }

            class BsonObject : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;

                /*0x1718444*/ void Add(string name, Newtonsoft.Json.Bson.BsonToken token);
                /*0x1718578*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonArray : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;

                /*0x17183cc*/ void Add(Newtonsoft.Json.Bson.BsonToken token);
                /*0x171843c*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonValue : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ object _value;
                /*0x20*/ Newtonsoft.Json.Bson.BsonType _type;

                /*0x1718b60*/ BsonValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x1718ba4*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonString : Newtonsoft.Json.Bson.BsonValue
            {
                /*0x21*/ bool <IncludeLength>k__BackingField;

                /*0x1718530*/ BsonString(object value, bool includeLength);
            }

            class BsonRegex : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x18*/ Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;
                /*0x20*/ Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;

                /*0x1718aa4*/ BsonRegex(string pattern, string options);
                /*0x1718a94*/ void set_Pattern(Newtonsoft.Json.Bson.BsonString value);
                /*0x1718a9c*/ void set_Options(Newtonsoft.Json.Bson.BsonString value);
                /*0x1718b58*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonProperty
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;

                /*0x1718528*/ BsonProperty();
                /*0x1718a84*/ void set_Name(Newtonsoft.Json.Bson.BsonString value);
                /*0x1718a8c*/ void set_Value(Newtonsoft.Json.Bson.BsonToken value);
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

                /*0x1718bac*/ void AddValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x1718c24*/ void AddToken(Newtonsoft.Json.Bson.BsonToken token);
                /*0x1718774*/ void WriteObjectId(byte[] value);
                /*0x1718e14*/ void WriteRegex(string pattern, string options);
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
