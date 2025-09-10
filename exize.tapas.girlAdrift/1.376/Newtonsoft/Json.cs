class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x16350fc*/ EmbeddedAttribute();
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
                /*0x1635104*/ IsReadOnlyAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x163510c*/ NullableAttribute(byte );
                /*0x163518c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x16351b4*/ NullableContextAttribute(byte );
            }
        }
    }

    namespace Diagnostics
    {
        namespace CodeAnalysis
        {
            class NotNullAttribute : System.Attribute
            {
                /*0x16351dc*/ NotNullAttribute();
            }

            class NotNullWhenAttribute : System.Attribute
            {
                /*0x10*/ bool <ReturnValue>k__BackingField;

                /*0x16351e4*/ NotNullWhenAttribute(bool returnValue);
                /*0x163520c*/ bool get_ReturnValue();
            }

            class MaybeNullAttribute : System.Attribute
            {
                /*0x1635214*/ MaybeNullAttribute();
            }

            class AllowNullAttribute : System.Attribute
            {
                /*0x163521c*/ AllowNullAttribute();
            }

            class DoesNotReturnIfAttribute : System.Attribute
            {
                /*0x10*/ bool <ParameterValue>k__BackingField;

                /*0x1635224*/ DoesNotReturnIfAttribute(bool parameterValue);
                /*0x163524c*/ bool get_ParameterValue();
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

            static /*0x1635254*/ DefaultJsonNameTable();
            static /*0x163549c*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x16352a4*/ DefaultJsonNameTable();
            /*0x1635314*/ string Get(char[] key, int start, int length);
            /*0x163554c*/ string Add(string key);
            /*0x1635704*/ string AddEntry(string str, int hashCode);
            /*0x1635850*/ void Grow();

            class Entry
            {
                /*0x10*/ string Value;
                /*0x18*/ int HashCode;
                /*0x20*/ Newtonsoft.Json.DefaultJsonNameTable.Entry Next;

                /*0x1635810*/ Entry(string value, int hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next);
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
            /*0x68*/ bool _allowNullItems;

            /*0x1635988*/ JsonArrayAttribute();
            /*0x1635998*/ JsonArrayAttribute(bool allowNullItems);
            /*0x16359c0*/ JsonArrayAttribute(string id);
            /*0x1635974*/ bool get_AllowNullItems();
            /*0x163597c*/ void set_AllowNullItems(bool value);
        }

        class JsonConstructorAttribute : System.Attribute
        {
            /*0x1635a10*/ JsonConstructorAttribute();
        }

        class JsonContainerAttribute : System.Attribute
        {
            /*0x10*/ string <Id>k__BackingField;
            /*0x18*/ string <Title>k__BackingField;
            /*0x20*/ string <Description>k__BackingField;
            /*0x28*/ System.Type <ItemConverterType>k__BackingField;
            /*0x30*/ object[] <ItemConverterParameters>k__BackingField;
            /*0x38*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategyInstance>k__BackingField;
            /*0x40*/ System.Nullable<bool> _isReference;
            /*0x42*/ System.Nullable<bool> _itemIsReference;
            /*0x44*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;
            /*0x4c*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;
            /*0x58*/ System.Type _namingStrategyType;
            /*0x60*/ object[] _namingStrategyParameters;

            /*0x1635990*/ JsonContainerAttribute();
            /*0x16359e8*/ JsonContainerAttribute(string id);
            /*0x1635a18*/ string get_Id();
            /*0x1635a20*/ void set_Id(string value);
            /*0x1635a28*/ string get_Title();
            /*0x1635a30*/ void set_Title(string value);
            /*0x1635a38*/ string get_Description();
            /*0x1635a40*/ void set_Description(string value);
            /*0x1635a48*/ System.Type get_ItemConverterType();
            /*0x1635a50*/ void set_ItemConverterType(System.Type value);
            /*0x1635a58*/ object[] get_ItemConverterParameters();
            /*0x1635a60*/ void set_ItemConverterParameters(object[] value);
            /*0x1635a68*/ System.Type get_NamingStrategyType();
            /*0x1635a70*/ void set_NamingStrategyType(System.Type value);
            /*0x1635a7c*/ object[] get_NamingStrategyParameters();
            /*0x1635a84*/ void set_NamingStrategyParameters(object[] value);
            /*0x1635a90*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance();
            /*0x1635a98*/ void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value);
            /*0x1635aa0*/ bool get_IsReference();
            /*0x1635adc*/ void set_IsReference(bool value);
            /*0x1635b44*/ bool get_ItemIsReference();
            /*0x1635b80*/ void set_ItemIsReference(bool value);
            /*0x1635be8*/ Newtonsoft.Json.ReferenceLoopHandling get_ItemReferenceLoopHandling();
            /*0x1635c24*/ void set_ItemReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x1635c8c*/ Newtonsoft.Json.TypeNameHandling get_ItemTypeNameHandling();
            /*0x1635cc8*/ void set_ItemTypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
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

            static /*0x16396d8*/ JsonConvert();
            static /*0x1635d30*/ System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings();
            static /*0x1635d88*/ void set_DefaultSettings(System.Func<Newtonsoft.Json.JsonSerializerSettings> value);
            static /*0x1635de4*/ string ToString(System.DateTime value);
            static /*0x1635e40*/ string ToString(System.DateTime value, Newtonsoft.Json.DateFormatHandling format, Newtonsoft.Json.DateTimeZoneHandling timeZoneHandling);
            static /*0x16360b0*/ string ToString(System.DateTimeOffset value);
            static /*0x1636118*/ string ToString(System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format);
            static /*0x1636368*/ string ToString(bool value);
            static /*0x16363d4*/ string ToString(char value);
            static /*0x16364b8*/ string ToString(System.Enum value);
            static /*0x163650c*/ string ToString(int value);
            static /*0x1636578*/ string ToString(short value);
            static /*0x16365e4*/ string ToString(ushort value);
            static /*0x1636650*/ string ToString(uint value);
            static /*0x16366bc*/ string ToString(long value);
            static /*0x1636728*/ string ToStringInternal(System.Numerics.BigInteger value);
            static /*0x163679c*/ string ToString(ulong value);
            static /*0x1636808*/ string ToString(float value);
            static /*0x1636a24*/ string ToString(float value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x1636b14*/ string EnsureFloatFormat(double value, string text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x1636c98*/ string ToString(double value);
            static /*0x1636d60*/ string ToString(double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable);
            static /*0x16368d4*/ string EnsureDecimalPlace(double value, string text);
            static /*0x1636e4c*/ string EnsureDecimalPlace(string text);
            static /*0x1636ec8*/ string ToString(byte value);
            static /*0x1636f34*/ string ToString(sbyte value);
            static /*0x1636fa0*/ string ToString(decimal value);
            static /*0x1637068*/ string ToString(System.Guid value);
            static /*0x16370d0*/ string ToString(System.Guid value, char quoteChar);
            static /*0x1637188*/ string ToString(System.TimeSpan value);
            static /*0x16371e0*/ string ToString(System.TimeSpan value, char quoteChar);
            static /*0x16372c4*/ string ToString(System.Uri value);
            static /*0x1637378*/ string ToString(System.Uri value, char quoteChar);
            static /*0x1636460*/ string ToString(string value);
            static /*0x163725c*/ string ToString(string value, char delimiter);
            static /*0x16373f0*/ string ToString(string value, char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
            static /*0x16374d8*/ string ToString(object value);
            static /*0x1637cd8*/ string SerializeObject(object value);
            static /*0x1637db0*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting);
            static /*0x1637e88*/ string SerializeObject(object value, Newtonsoft.Json.JsonConverter[] converters);
            static /*0x1637fac*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters);
            static /*0x16380f8*/ string SerializeObject(object value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1637d34*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1637e18*/ string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1638060*/ string SerializeObject(object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1638194*/ string SerializeObjectInternal(object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer);
            static /*0x163842c*/ object DeserializeObject(string value);
            static /*0x16386d8*/ object DeserializeObject(string value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1638740*/ object DeserializeObject(string value, System.Type type);
            static T DeserializeObject<T>(string value);
            static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject);
            static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, Newtonsoft.Json.JsonSerializerSettings settings);
            static T DeserializeObject<T>(string value, Newtonsoft.Json.JsonConverter[] converters);
            static T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x16387a8*/ object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonConverter[] converters);
            static /*0x1638488*/ object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x16389b4*/ void PopulateObject(string value, object target);
            static /*0x1638a1c*/ void PopulateObject(string value, object target, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1638d08*/ string SerializeXmlNode(System.Xml.XmlNode node);
            static /*0x1638d60*/ string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting);
            static /*0x1638e50*/ string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting, bool omitRootObject);
            static /*0x1638f4c*/ System.Xml.XmlDocument DeserializeXmlNode(string value);
            static /*0x1638fa4*/ System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName);
            static /*0x163900c*/ System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute);
            static /*0x163907c*/ System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters);
            static /*0x1639234*/ string SerializeXNode(System.Xml.Linq.XObject node);
            static /*0x163928c*/ string SerializeXNode(System.Xml.Linq.XObject node, Newtonsoft.Json.Formatting formatting);
            static /*0x16392f4*/ string SerializeXNode(System.Xml.Linq.XObject node, Newtonsoft.Json.Formatting formatting, bool omitRootObject);
            static /*0x16393f0*/ System.Xml.Linq.XDocument DeserializeXNode(string value);
            static /*0x1639448*/ System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName);
            static /*0x16394b0*/ System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute);
            static /*0x1639520*/ System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters);
        }

        class JsonConverter
        {
            /*0x1639808*/ JsonConverter();
            void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
            object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            bool CanConvert(System.Type objectType);
            /*0x16397f8*/ bool get_CanRead();
            /*0x1639800*/ bool get_CanWrite();
        }

        class JsonConverter<T> : Newtonsoft.Json.JsonConverter
        {
            JsonConverter();
            void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
            void WriteJson(Newtonsoft.Json.JsonWriter writer, T value, Newtonsoft.Json.JsonSerializer serializer);
            object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            T ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, T existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer);
            bool CanConvert(System.Type objectType);
        }

        class JsonConverterAttribute : System.Attribute
        {
            /*0x10*/ System.Type _converterType;
            /*0x18*/ object[] <ConverterParameters>k__BackingField;

            /*0x1639820*/ JsonConverterAttribute(System.Type converterType);
            /*0x16398ec*/ JsonConverterAttribute(System.Type converterType, object[] converterParameters);
            /*0x1639810*/ System.Type get_ConverterType();
            /*0x1639818*/ object[] get_ConverterParameters();
        }

        class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter>
        {
            /*0x1639910*/ JsonConverterCollection();
        }

        class JsonDictionaryAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
            /*0x1639958*/ JsonDictionaryAttribute();
            /*0x1639960*/ JsonDictionaryAttribute(string id);
        }

        class JsonException : System.Exception
        {
            static /*0x1639b38*/ Newtonsoft.Json.JsonException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message);
            /*0x1639988*/ JsonException();
            /*0x16399e0*/ JsonException(string message);
            /*0x1639a48*/ JsonException(string message, System.Exception innerException);
            /*0x1639ab8*/ JsonException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class JsonExtensionDataAttribute : System.Attribute
        {
            /*0x10*/ bool <WriteData>k__BackingField;
            /*0x11*/ bool <ReadData>k__BackingField;

            /*0x1639f38*/ JsonExtensionDataAttribute();
            /*0x1639f10*/ bool get_WriteData();
            /*0x1639f18*/ void set_WriteData(bool value);
            /*0x1639f24*/ bool get_ReadData();
            /*0x1639f2c*/ void set_ReadData(bool value);
        }

        class JsonIgnoreAttribute : System.Attribute
        {
            /*0x1639f58*/ JsonIgnoreAttribute();
        }

        class JsonNameTable
        {
            /*0x163530c*/ JsonNameTable();
            string Get(char[] key, int start, int length);
        }

        class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
        {
            /*0x68*/ Newtonsoft.Json.MemberSerialization _memberSerialization;
            /*0x6c*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;
            /*0x74*/ System.Nullable<Newtonsoft.Json.Required> _itemRequired;
            /*0x7c*/ System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;

            /*0x163a15c*/ JsonObjectAttribute();
            /*0x163a164*/ JsonObjectAttribute(Newtonsoft.Json.MemberSerialization memberSerialization);
            /*0x163a18c*/ JsonObjectAttribute(string id);
            /*0x1639f60*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
            /*0x1639f68*/ void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value);
            /*0x1639f70*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x1639fac*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x163a014*/ Newtonsoft.Json.NullValueHandling get_ItemNullValueHandling();
            /*0x163a050*/ void set_ItemNullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x163a0b8*/ Newtonsoft.Json.Required get_ItemRequired();
            /*0x163a0f4*/ void set_ItemRequired(Newtonsoft.Json.Required value);
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

            static /*0x163a7ac*/ JsonPosition();
            static /*0x163a230*/ bool TypeHasIndex(Newtonsoft.Json.JsonContainerType type);
            static /*0x163a4f8*/ string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition);
            static /*0x1639be4*/ string FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message);
            /*0x163a1b4*/ JsonPosition(Newtonsoft.Json.JsonContainerType type);
            /*0x163a240*/ int CalculateLength();
            /*0x163a2d8*/ void WriteTo(System.Text.StringBuilder sb, ref System.IO.StringWriter writer, ref char[] buffer);
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

            /*0x163af9c*/ JsonPropertyAttribute();
            /*0x163afa4*/ JsonPropertyAttribute(string propertyName);
            /*0x163a840*/ System.Type get_ItemConverterType();
            /*0x163a848*/ void set_ItemConverterType(System.Type value);
            /*0x163a850*/ object[] get_ItemConverterParameters();
            /*0x163a858*/ void set_ItemConverterParameters(object[] value);
            /*0x163a860*/ System.Type get_NamingStrategyType();
            /*0x163a868*/ void set_NamingStrategyType(System.Type value);
            /*0x163a870*/ object[] get_NamingStrategyParameters();
            /*0x163a878*/ void set_NamingStrategyParameters(object[] value);
            /*0x163a880*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x163a8bc*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x163a924*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x163a960*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x163a9c8*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x163aa04*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x163aa6c*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x163aaa8*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x163ab10*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x163ab4c*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x163abb4*/ bool get_IsReference();
            /*0x163abf0*/ void set_IsReference(bool value);
            /*0x163ac58*/ int get_Order();
            /*0x163ac94*/ void set_Order(int value);
            /*0x163acfc*/ Newtonsoft.Json.Required get_Required();
            /*0x163ad38*/ void set_Required(Newtonsoft.Json.Required value);
            /*0x163ada0*/ string get_PropertyName();
            /*0x163ada8*/ void set_PropertyName(string value);
            /*0x163adb0*/ Newtonsoft.Json.ReferenceLoopHandling get_ItemReferenceLoopHandling();
            /*0x163adec*/ void set_ItemReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x163ae54*/ Newtonsoft.Json.TypeNameHandling get_ItemTypeNameHandling();
            /*0x163ae90*/ void set_ItemTypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x163aef8*/ bool get_ItemIsReference();
            /*0x163af34*/ void set_ItemIsReference(bool value);
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

            /*0x163c25c*/ JsonReader();
            /*0x163afcc*/ System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b090*/ System.Threading.Tasks.Task SkipAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b16c*/ System.Threading.Tasks.Task ReaderReadAndAssertAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b244*/ System.Threading.Tasks.Task<System.Nullable<bool>> ReadAsBooleanAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b330*/ System.Threading.Tasks.Task<System.Byte[]> ReadAsBytesAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b41c*/ System.Threading.Tasks.Task<System.Byte[]> ReadArrayIntoByteArrayAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b518*/ System.Threading.Tasks.Task<System.Nullable<System.DateTime>> ReadAsDateTimeAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b608*/ System.Threading.Tasks.Task<System.Nullable<System.DateTimeOffset>> ReadAsDateTimeOffsetAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b70c*/ System.Threading.Tasks.Task<System.Nullable<decimal>> ReadAsDecimalAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b830*/ System.Threading.Tasks.Task<System.Nullable<double>> ReadAsDoubleAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163b8bc*/ System.Threading.Tasks.Task<System.Nullable<int>> ReadAsInt32Async(System.Threading.CancellationToken cancellationToken);
            /*0x163b9a8*/ System.Threading.Tasks.Task<string> ReadAsStringAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163ba94*/ System.Threading.Tasks.Task<bool> ReadAndMoveToContentAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163bb94*/ System.Threading.Tasks.Task<bool> MoveToContentAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163bc28*/ System.Threading.Tasks.Task<bool> MoveToContentFromNonContentAsync(System.Threading.CancellationToken cancellationToken);
            /*0x163bd28*/ Newtonsoft.Json.JsonReader.State get_CurrentState();
            /*0x163bd30*/ bool get_CloseInput();
            /*0x163bd38*/ void set_CloseInput(bool value);
            /*0x163bd44*/ bool get_SupportMultipleContent();
            /*0x163bd4c*/ void set_SupportMultipleContent(bool value);
            /*0x163bd58*/ char get_QuoteChar();
            /*0x163bd60*/ void set_QuoteChar(char value);
            /*0x163bd68*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x163bd70*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x163bdd4*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x163bddc*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x163be40*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x163be48*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x163beac*/ string get_DateFormatString();
            /*0x163beb4*/ void set_DateFormatString(string value);
            /*0x163bebc*/ System.Nullable<int> get_MaxDepth();
            /*0x163bec4*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x163bf84*/ Newtonsoft.Json.JsonToken get_TokenType();
            /*0x163bf8c*/ object get_Value();
            /*0x163bf94*/ System.Type get_ValueType();
            /*0x163bfa8*/ int get_Depth();
            /*0x163c028*/ string get_Path();
            /*0x163c148*/ System.Globalization.CultureInfo get_Culture();
            /*0x163c1b0*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x163c1b8*/ Newtonsoft.Json.JsonPosition GetPosition(int depth);
            /*0x163c2ec*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0x163c598*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0x163c6b8*/ Newtonsoft.Json.JsonContainerType Peek();
            bool Read();
            /*0x163c6c0*/ System.Nullable<int> ReadAsInt32();
            /*0x163ccd0*/ System.Nullable<int> ReadInt32String(string s);
            /*0x163ceb0*/ string ReadAsString();
            /*0x163d158*/ byte[] ReadAsBytes();
            /*0x163d758*/ byte[] ReadArrayIntoByteArray();
            /*0x163d8a8*/ bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<byte> buffer);
            /*0x163dac0*/ System.Nullable<double> ReadAsDouble();
            /*0x163ddbc*/ System.Nullable<double> ReadDoubleString(string s);
            /*0x163df94*/ System.Nullable<bool> ReadAsBoolean();
            /*0x163e2c8*/ System.Nullable<bool> ReadBooleanString(string s);
            /*0x163e4a8*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x163e8b4*/ System.Nullable<decimal> ReadDecimalString(string s);
            /*0x163eb48*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x163ede8*/ System.Nullable<System.DateTime> ReadDateTimeString(string s);
            /*0x163f068*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x163f310*/ System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s);
            /*0x163d710*/ void ReaderReadAndAssert();
            /*0x163f570*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException();
            /*0x163d530*/ void ReadIntoWrappedTypeObject();
            /*0x163f5bc*/ void Skip();
            /*0x163d89c*/ void SetToken(Newtonsoft.Json.JsonToken newToken);
            /*0x163f66c*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value);
            /*0x163cb7c*/ void SetToken(Newtonsoft.Json.JsonToken newToken, object value, bool updateIndex);
            /*0x163f770*/ void SetPostValueState(bool updateIndex);
            /*0x163c578*/ void UpdateScopeWithFinishedValue();
            /*0x163f674*/ void ValidateEnd(Newtonsoft.Json.JsonToken endToken);
            /*0x163f87c*/ void SetStateBasedOnCurrent();
            /*0x163f7ac*/ void SetFinished();
            /*0x163f7d4*/ Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token);
            /*0x163f968*/ void System.IDisposable.Dispose();
            /*0x163f9d8*/ void Dispose(bool disposing);
            /*0x163f9fc*/ void Close();
            /*0x163fa10*/ void ReadAndAssert();
            /*0x163fa68*/ void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x163fab8*/ bool ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter);
            /*0x163fd68*/ bool ReadAndMoveToContent();
            /*0x163fd9c*/ bool MoveToContent();
            /*0x163ca78*/ Newtonsoft.Json.JsonToken GetContentToken();

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

            struct <SkipAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x50*/ int <depth>5__2;

                /*0x163fe00*/ void MoveNext();
                /*0x1640144*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReaderReadAndAssertAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0x1640150*/ void MoveNext();
                /*0x1640368*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadArrayIntoByteArrayAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Byte[]> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Collections.Generic.List<byte> <buffer>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0x1640374*/ void MoveNext();
                /*0x16406b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadAndMoveToContentAsync>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0x164070c*/ void MoveNext();
                /*0x16409dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MoveToContentFromNonContentAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0x1640a34*/ void MoveNext();
                /*0x1640c78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class JsonReaderException : Newtonsoft.Json.JsonException
        {
            /*0x8c*/ int <LineNumber>k__BackingField;
            /*0x90*/ int <LinePosition>k__BackingField;
            /*0x98*/ string <Path>k__BackingField;

            static /*0x163c590*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x163caf4*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x1640d34*/ Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x1640ce8*/ JsonReaderException();
            /*0x1640cec*/ JsonReaderException(string message);
            /*0x1640cf0*/ JsonReaderException(string message, System.Exception innerException);
            /*0x1640cf4*/ JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1640cf8*/ JsonReaderException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
            /*0x1640cd0*/ int get_LineNumber();
            /*0x1640cd8*/ int get_LinePosition();
            /*0x1640ce0*/ string get_Path();
        }

        class JsonRequiredAttribute : System.Attribute
        {
            /*0x1640f34*/ JsonRequiredAttribute();
        }

        class JsonSerializationException : Newtonsoft.Json.JsonException
        {
            /*0x8c*/ int <LineNumber>k__BackingField;
            /*0x90*/ int <LinePosition>k__BackingField;
            /*0x98*/ string <Path>k__BackingField;

            static /*0x1638d00*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message);
            static /*0x1640fa0*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, string message, System.Exception ex);
            static /*0x1641028*/ Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, System.Exception ex);
            /*0x1640f54*/ JsonSerializationException();
            /*0x1640f58*/ JsonSerializationException(string message);
            /*0x1640f5c*/ JsonSerializationException(string message, System.Exception innerException);
            /*0x1640f60*/ JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x1640f64*/ JsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception innerException);
            /*0x1640f3c*/ int get_LineNumber();
            /*0x1640f44*/ int get_LinePosition();
            /*0x1640f4c*/ string get_Path();
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

            static /*0x16424f4*/ Newtonsoft.Json.JsonSerializer Create();
            static /*0x164254c*/ Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1642cb4*/ Newtonsoft.Json.JsonSerializer CreateDefault();
            static /*0x1638160*/ Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x1642580*/ void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings);
            static /*0x164432c*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType);
            /*0x16423c4*/ JsonSerializer();
            /*0x1641228*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x16412d8*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x1641388*/ Newtonsoft.Json.Serialization.IReferenceResolver get_ReferenceResolver();
            /*0x16413f8*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
            /*0x1641474*/ System.Runtime.Serialization.SerializationBinder get_Binder();
            /*0x1641570*/ void set_Binder(System.Runtime.Serialization.SerializationBinder value);
            /*0x1641668*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
            /*0x1641670*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
            /*0x16416ec*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x16416f4*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
            /*0x16416fc*/ System.Collections.IEqualityComparer get_EqualityComparer();
            /*0x1641704*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
            /*0x164170c*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x1641714*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x1641778*/ System.Runtime.Serialization.Formatters.FormatterAssemblyStyle get_TypeNameAssemblyFormat();
            /*0x1641780*/ void set_TypeNameAssemblyFormat(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle value);
            /*0x16417e4*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
            /*0x16417ec*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
            /*0x1641850*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
            /*0x1641858*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
            /*0x16418bc*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x16418c4*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x1641928*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x1641930*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x1641994*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x164199c*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x1641a00*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x1641a08*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x1641a6c*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x1641a74*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x1641ad8*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
            /*0x1641ae0*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
            /*0x1641b44*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x1641b4c*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
            /*0x1641bb0*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
            /*0x1641c18*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x1641c20*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
            /*0x1641cc8*/ System.Runtime.Serialization.StreamingContext get_Context();
            /*0x1641cd4*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
            /*0x1641cdc*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x1641d18*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x1641d80*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0x1641dbc*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0x1641e24*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x1641e78*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x1641ee0*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x1641f30*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x1641f98*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x1641fd4*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x164203c*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0x1642078*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0x16420e0*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0x164211c*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0x1642184*/ string get_DateFormatString();
            /*0x16421d4*/ void set_DateFormatString(string value);
            /*0x16421e4*/ System.Globalization.CultureInfo get_Culture();
            /*0x1642248*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x1642250*/ System.Nullable<int> get_MaxDepth();
            /*0x1642258*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x1642320*/ bool get_CheckAdditionalContent();
            /*0x164235c*/ void set_CheckAdditionalContent(bool value);
            /*0x1638858*/ bool IsCheckAdditionalContentSet();
            /*0x1643040*/ void Populate(System.IO.TextReader reader, object target);
            /*0x1638cb4*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
            /*0x16430c4*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
            /*0x1643944*/ object Deserialize(Newtonsoft.Json.JsonReader reader);
            /*0x1643958*/ object Deserialize(System.IO.TextReader reader, System.Type objectType);
            T Deserialize<T>(Newtonsoft.Json.JsonReader reader);
            /*0x16389a4*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x16439dc*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
            /*0x164333c*/ void SetupReader(Newtonsoft.Json.JsonReader reader, ref System.Globalization.CultureInfo previousCulture, ref System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, ref System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, ref System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, ref System.Nullable<int> previousMaxDepth, ref string previousDateFormatString);
            /*0x1643754*/ void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<int> previousMaxDepth, string previousDateFormatString);
            /*0x1643c50*/ void Serialize(System.IO.TextWriter textWriter, object value);
            /*0x163841c*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x1643cf0*/ void Serialize(System.IO.TextWriter textWriter, object value, System.Type objectType);
            /*0x1643cdc*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value);
            /*0x16436c8*/ Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader);
            /*0x1643d88*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
            /*0x164138c*/ Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver();
            /*0x1644324*/ Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type);
            /*0x1644488*/ void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e);
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

            static /*0x1645330*/ JsonSerializerSettings();
            /*0x1637f2c*/ JsonSerializerSettings();
            /*0x1642e48*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
            /*0x16444b0*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
            /*0x1642e84*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
            /*0x1644518*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
            /*0x1642ec0*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
            /*0x1644580*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
            /*0x1642efc*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
            /*0x16445e8*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
            /*0x1642f38*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
            /*0x1644650*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
            /*0x16446b8*/ System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters();
            /*0x16446c0*/ void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value);
            /*0x1642e0c*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
            /*0x16446c8*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
            /*0x1642d58*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
            /*0x1644730*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
            /*0x1642d94*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
            /*0x1644798*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
            /*0x1644800*/ System.Runtime.Serialization.Formatters.FormatterAssemblyStyle get_TypeNameAssemblyFormat();
            /*0x164483c*/ void set_TypeNameAssemblyFormat(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle value);
            /*0x1642dd0*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
            /*0x1644840*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
            /*0x1642f74*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
            /*0x16448a8*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
            /*0x1644910*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
            /*0x1644918*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
            /*0x1644920*/ System.Collections.IEqualityComparer get_EqualityComparer();
            /*0x1644928*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
            /*0x1644930*/ Newtonsoft.Json.Serialization.IReferenceResolver get_ReferenceResolver();
            /*0x1644950*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
            /*0x1644a18*/ System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider();
            /*0x1644a20*/ void set_ReferenceResolverProvider(System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> value);
            /*0x1644a28*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
            /*0x1644a30*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
            /*0x1644a38*/ System.Runtime.Serialization.SerializationBinder get_Binder();
            /*0x1644b04*/ void set_Binder(System.Runtime.Serialization.SerializationBinder value);
            /*0x1644b7c*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
            /*0x1644b84*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
            /*0x1644b8c*/ System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error();
            /*0x1644b94*/ void set_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
            /*0x1642fb0*/ System.Runtime.Serialization.StreamingContext get_Context();
            /*0x1644b9c*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
            /*0x1644c20*/ string get_DateFormatString();
            /*0x1644c70*/ void set_DateFormatString(string value);
            /*0x1644c80*/ System.Nullable<int> get_MaxDepth();
            /*0x1644cec*/ void set_MaxDepth(System.Nullable<int> value);
            /*0x1644db4*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0x1644df0*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0x1644e58*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0x1644e94*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0x1644efc*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0x1644f50*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0x1644fb8*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
            /*0x1645008*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
            /*0x1645070*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0x16450ac*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0x1645114*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
            /*0x1645150*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
            /*0x16451b8*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0x16451f4*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0x164525c*/ System.Globalization.CultureInfo get_Culture();
            /*0x16452c0*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0x1638cc4*/ bool get_CheckAdditionalContent();
            /*0x16452c8*/ void set_CheckAdditionalContent(bool value);

            class <>c__DisplayClass93_0
            {
                /*0x10*/ Newtonsoft.Json.Serialization.IReferenceResolver value;

                /*0x1644a10*/ <>c__DisplayClass93_0();
                /*0x16453b0*/ Newtonsoft.Json.Serialization.IReferenceResolver <set_ReferenceResolver>b__0();
            }
        }

        class JsonTextReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
        {
            static char UnicodeReplacementChar = 65533;
            static int MaximumJavascriptIntegerCharacterLength = 380;
            static int LargeBufferLength = 1073741823;
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

            static /*0x1648a98*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x164da60*/ object BigIntegerParse(string number, System.Globalization.CultureInfo culture);
            /*0x1638894*/ JsonTextReader(System.IO.TextReader reader);
            /*0x16453b8*/ System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x16453c8*/ System.Threading.Tasks.Task<bool> DoReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1645928*/ System.Threading.Tasks.Task<bool> DoReadAsync(System.Threading.Tasks.Task<bool> task, System.Threading.CancellationToken cancellationToken);
            /*0x1645810*/ System.Threading.Tasks.Task<bool> ParsePostValueAsync(bool ignoreComments, System.Threading.CancellationToken cancellationToken);
            /*0x1645a38*/ System.Threading.Tasks.Task<bool> ReadFromFinishedAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1645b3c*/ System.Threading.Tasks.Task<int> ReadDataAsync(bool append, System.Threading.CancellationToken cancellationToken);
            /*0x1645b4c*/ System.Threading.Tasks.Task<int> ReadDataAsync(bool append, int charsRequired, System.Threading.CancellationToken cancellationToken);
            /*0x1645600*/ System.Threading.Tasks.Task<bool> ParseValueAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1645c68*/ System.Threading.Tasks.Task ReadStringIntoBufferAsync(char quote, System.Threading.CancellationToken cancellationToken);
            /*0x1645d54*/ System.Threading.Tasks.Task ProcessCarriageReturnAsync(bool append, System.Threading.CancellationToken cancellationToken);
            /*0x1645f7c*/ System.Threading.Tasks.Task ProcessCarriageReturnAsync(System.Threading.Tasks.Task<bool> task);
            /*0x1646054*/ System.Threading.Tasks.Task<char> ParseUnicodeAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1645e54*/ System.Threading.Tasks.Task<bool> EnsureCharsAsync(int relativePosition, bool append, System.Threading.CancellationToken cancellationToken);
            /*0x1646154*/ System.Threading.Tasks.Task<bool> ReadCharsAsync(int relativePosition, bool append, System.Threading.CancellationToken cancellationToken);
            /*0x164570c*/ System.Threading.Tasks.Task<bool> ParseObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1646270*/ System.Threading.Tasks.Task ParseCommentAsync(bool setToken, System.Threading.CancellationToken cancellationToken);
            /*0x1646358*/ System.Threading.Tasks.Task EatWhitespaceAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1646434*/ System.Threading.Tasks.Task ParseStringAsync(char quote, Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x1646528*/ System.Threading.Tasks.Task<bool> MatchValueAsync(string value, System.Threading.CancellationToken cancellationToken);
            /*0x1646638*/ System.Threading.Tasks.Task<bool> MatchValueWithTrailingSeparatorAsync(string value, System.Threading.CancellationToken cancellationToken);
            /*0x1646748*/ System.Threading.Tasks.Task MatchAndSetAsync(string value, Newtonsoft.Json.JsonToken newToken, object tokenValue, System.Threading.CancellationToken cancellationToken);
            /*0x1646844*/ System.Threading.Tasks.Task ParseTrueAsync(System.Threading.CancellationToken cancellationToken);
            /*0x16468ec*/ System.Threading.Tasks.Task ParseFalseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1646990*/ System.Threading.Tasks.Task ParseNullAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1646a08*/ System.Threading.Tasks.Task ParseConstructorAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1646aec*/ System.Threading.Tasks.Task<object> ParseNumberNaNAsync(Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x1646c00*/ System.Threading.Tasks.Task<object> ParseNumberPositiveInfinityAsync(Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x1646d14*/ System.Threading.Tasks.Task<object> ParseNumberNegativeInfinityAsync(Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x1646e28*/ System.Threading.Tasks.Task ParseNumberAsync(Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x1646f0c*/ System.Threading.Tasks.Task ParseUndefinedAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1646f84*/ System.Threading.Tasks.Task<bool> ParsePropertyAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647088*/ System.Threading.Tasks.Task ReadNumberIntoBufferAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647164*/ System.Threading.Tasks.Task ParseUnquotedPropertyAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647240*/ System.Threading.Tasks.Task<bool> ReadNullCharAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647340*/ System.Threading.Tasks.Task HandleNullAsync(System.Threading.CancellationToken cancellationToken);
            /*0x164741c*/ System.Threading.Tasks.Task ReadFinishedAsync(System.Threading.CancellationToken cancellationToken);
            /*0x16474f8*/ System.Threading.Tasks.Task<object> ReadStringValueAsync(Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x1647614*/ System.Threading.Tasks.Task<object> ReadNumberValueAsync(Newtonsoft.Json.ReadType readType, System.Threading.CancellationToken cancellationToken);
            /*0x164772c*/ System.Threading.Tasks.Task<System.Nullable<bool>> ReadAsBooleanAsync(System.Threading.CancellationToken cancellationToken);
            /*0x164773c*/ System.Threading.Tasks.Task<System.Nullable<bool>> DoReadAsBooleanAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647844*/ System.Threading.Tasks.Task<System.Byte[]> ReadAsBytesAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647854*/ System.Threading.Tasks.Task<System.Byte[]> DoReadAsBytesAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647954*/ System.Threading.Tasks.Task ReadIntoWrappedTypeObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647a2c*/ System.Threading.Tasks.Task<System.Nullable<System.DateTime>> ReadAsDateTimeAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647a3c*/ System.Threading.Tasks.Task<System.Nullable<System.DateTime>> DoReadAsDateTimeAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647b3c*/ System.Threading.Tasks.Task<System.Nullable<System.DateTimeOffset>> ReadAsDateTimeOffsetAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647b4c*/ System.Threading.Tasks.Task<System.Nullable<System.DateTimeOffset>> DoReadAsDateTimeOffsetAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647c4c*/ System.Threading.Tasks.Task<System.Nullable<decimal>> ReadAsDecimalAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647c5c*/ System.Threading.Tasks.Task<System.Nullable<decimal>> DoReadAsDecimalAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647d5c*/ System.Threading.Tasks.Task<System.Nullable<double>> ReadAsDoubleAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647d6c*/ System.Threading.Tasks.Task<System.Nullable<double>> DoReadAsDoubleAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647e6c*/ System.Threading.Tasks.Task<System.Nullable<int>> ReadAsInt32Async(System.Threading.CancellationToken cancellationToken);
            /*0x1647e7c*/ System.Threading.Tasks.Task<System.Nullable<int>> DoReadAsInt32Async(System.Threading.CancellationToken cancellationToken);
            /*0x1647f7c*/ System.Threading.Tasks.Task<string> ReadAsStringAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1647f8c*/ System.Threading.Tasks.Task<string> DoReadAsStringAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1648084*/ Newtonsoft.Json.JsonNameTable get_PropertyNameTable();
            /*0x164808c*/ void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value);
            /*0x1648094*/ Newtonsoft.Json.IArrayPool<char> get_ArrayPool();
            /*0x164809c*/ void set_ArrayPool(Newtonsoft.Json.IArrayPool<char> value);
            /*0x16480fc*/ void EnsureBufferNotEmpty();
            /*0x1645f1c*/ void SetNewLine(bool hasNextChar);
            /*0x1648150*/ void OnNewLine(int pos);
            /*0x1648160*/ void ParseString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x16486b8*/ void ParseReadString(char quote, Newtonsoft.Json.ReadType readType);
            /*0x16481a8*/ void ShiftBufferIfNeeded();
            /*0x1648aac*/ int ReadData(bool append);
            /*0x1648b48*/ void PrepareBufferForReadData(bool append, int charsRequired);
            /*0x1648ab8*/ int ReadData(bool append, int charsRequired);
            /*0x1648ce0*/ bool EnsureChars(int relativePosition, bool append);
            /*0x1648d00*/ bool ReadChars(int relativePosition, bool append);
            /*0x1648d70*/ bool Read();
            /*0x1649b7c*/ System.Nullable<int> ReadAsInt32();
            /*0x1649fdc*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0x164a528*/ string ReadAsString();
            /*0x164a58c*/ byte[] ReadAsBytes();
            /*0x164a06c*/ object ReadStringValue(Newtonsoft.Json.ReadType readType);
            /*0x164ae3c*/ object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType);
            /*0x164abbc*/ Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(char c);
            /*0x164b318*/ System.Nullable<bool> ReadAsBoolean();
            /*0x164ab50*/ void ProcessValueComma();
            /*0x1649c0c*/ object ReadNumberValue(Newtonsoft.Json.ReadType readType);
            /*0x164b888*/ object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType);
            /*0x164ba18*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0x164bae4*/ System.Nullable<decimal> ReadAsDecimal();
            /*0x164bbb0*/ System.Nullable<double> ReadAsDouble();
            /*0x164aa80*/ void HandleNull();
            /*0x164acf0*/ void ReadFinished();
            /*0x164aa30*/ bool ReadNullChar();
            /*0x16455bc*/ void EnsureBuffer();
            /*0x164825c*/ void ReadStringIntoBuffer(char quote);
            /*0x164bda0*/ void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition);
            /*0x164bd50*/ void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition);
            /*0x164be40*/ char ConvertUnicode(bool enoughChars);
            /*0x164bd10*/ char ParseUnicode();
            /*0x164bf94*/ void ReadNumberIntoBuffer();
            /*0x164c018*/ bool ReadNumberCharIntoBuffer(char currentChar, int charPos);
            /*0x164c194*/ void ClearRecentString();
            /*0x1649534*/ bool ParsePostValue(bool ignoreComments);
            /*0x16493a4*/ bool ParseObject();
            /*0x164c1a0*/ bool ParseProperty();
            /*0x164c3c4*/ bool ValidIdentifierChar(char value);
            /*0x164c444*/ void ParseUnquotedProperty();
            /*0x164c538*/ bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition);
            /*0x1648f88*/ bool ParseValue();
            /*0x164acd4*/ void ProcessLineFeed();
            /*0x164ac8c*/ void ProcessCarriageReturn(bool append);
            /*0x16497dc*/ void EatWhitespace();
            /*0x164c840*/ void ParseConstructor();
            /*0x164b114*/ void ParseNumber(Newtonsoft.Json.ReadType readType);
            /*0x164cc0c*/ void ParseReadNumber(Newtonsoft.Json.ReadType readType, char firstChar, int initialPosition);
            /*0x164d9e4*/ Newtonsoft.Json.JsonReaderException ThrowReaderError(string message, System.Exception ex);
            /*0x16498f0*/ void ParseComment(bool setToken);
            /*0x164dae8*/ void EndComment(bool setToken, int initialPosition, int endPosition);
            /*0x164db48*/ bool MatchValue(string value);
            /*0x164dba4*/ bool MatchValue(bool enoughChars, string value);
            /*0x164b17c*/ bool MatchValueWithTrailingSeparator(string value);
            /*0x164dc84*/ bool IsSeparator(char c);
            /*0x164c684*/ void ParseTrue();
            /*0x164bc64*/ void ParseNull();
            /*0x164cb60*/ void ParseUndefined();
            /*0x164c764*/ void ParseFalse();
            /*0x164b098*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType);
            /*0x164dddc*/ object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x164b220*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType);
            /*0x164df1c*/ object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x164b29c*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType);
            /*0x164e05c*/ object ParseNumberNaN(Newtonsoft.Json.ReadType readType, bool matched);
            /*0x164e19c*/ void Close();
            /*0x164e1fc*/ bool HasLineInfo();
            /*0x164e204*/ int get_LineNumber();
            /*0x164e250*/ int get_LinePosition();

            struct <DoReadAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task<bool> task;
                /*0x38*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe46fa4*/ void MoveNext();
                /*0xe4725c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParsePostValueAsync>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool ignoreComments;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xe472b4*/ void MoveNext();
                /*0xe478d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadFromFinishedAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xe47930*/ void MoveNext();
                /*0xe47e04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadDataAsync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ bool append;
                /*0x3c*/ int charsRequired;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xe47e5c*/ void MoveNext();
                /*0xe48140*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseValueAsync>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__3;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__4;

                /*0xe48198*/ void MoveNext();
                /*0xe4919c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadStringIntoBufferAsync>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ char quote;
                /*0x44*/ int <charPos>5__2;
                /*0x48*/ int <initialPosition>5__3;
                /*0x4c*/ int <lastWritePosition>5__4;
                /*0x50*/ int <escapeStartPos>5__5;
                /*0x54*/ char <writeChar>5__6;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;
                /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char> <>u__3;
                /*0x88*/ bool <anotherHighSurrogate>5__7;
                /*0x8a*/ char <highSurrogate>5__8;
                /*0x90*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__4;

                /*0xe491f4*/ void MoveNext();
                /*0xe49de8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessCarriageReturnAsync>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task<bool> task;
                /*0x38*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe49df4*/ void MoveNext();
                /*0xe49fd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseUnicodeAsync>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<char> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe49fe0*/ void MoveNext();
                /*0xe4a208*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadCharsAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ int relativePosition;
                /*0x3c*/ bool append;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ int <charsRequired>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xe4a260*/ void MoveNext();
                /*0xe4a4b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseObjectAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__3;

                /*0xe4a508*/ void MoveNext();
                /*0xe4aac0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseCommentAsync>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setToken;
                /*0x41*/ bool <singlelineComment>5__2;
                /*0x44*/ int <initialPosition>5__3;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__3;

                /*0xe4ab18*/ void MoveNext();
                /*0xe4b2f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <EatWhitespaceAsync>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xe4b300*/ void MoveNext();
                /*0xe4b68c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseStringAsync>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x40*/ char quote;
                /*0x44*/ Newtonsoft.Json.ReadType readType;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xe4b698*/ void MoveNext();
                /*0xe4b878*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MatchValueAsync>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ string value;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe4b884*/ void MoveNext();
                /*0xe4bac4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MatchValueWithTrailingSeparatorAsync>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ string value;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe4bb1c*/ void MoveNext();
                /*0xe4be84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MatchAndSetAsync>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ string value;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ Newtonsoft.Json.JsonToken newToken;
                /*0x50*/ object tokenValue;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe4bedc*/ void MoveNext();
                /*0xe4c190*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseConstructorAsync>d__25 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x50*/ int <initialPosition>5__2;
                /*0x54*/ int <endPosition>5__3;
                /*0x58*/ string <constructorName>5__4;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3;

                /*0xe4c19c*/ void MoveNext();
                /*0xe4ca90*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseNumberNaNAsync>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ Newtonsoft.Json.ReadType readType;
                /*0x38*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ Newtonsoft.Json.ReadType <>7__wrap1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe4ca9c*/ void MoveNext();
                /*0xe4ccfc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseNumberPositiveInfinityAsync>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ Newtonsoft.Json.ReadType readType;
                /*0x38*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ Newtonsoft.Json.ReadType <>7__wrap1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe4cd54*/ void MoveNext();
                /*0xe4cfb4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseNumberNegativeInfinityAsync>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ Newtonsoft.Json.ReadType readType;
                /*0x38*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ Newtonsoft.Json.ReadType <>7__wrap1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xe4d00c*/ void MoveNext();
                /*0xe4d26c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseNumberAsync>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ Newtonsoft.Json.ReadType readType;
                /*0x44*/ char <firstChar>5__2;
                /*0x48*/ int <initialPosition>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xe4d2c4*/ void MoveNext();
                /*0xe4d4c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParsePropertyAsync>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ char <quoteChar>5__2;
                /*0x48*/ string <propertyName>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xe4d4cc*/ void MoveNext();
                /*0xe4dac8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadNumberIntoBufferAsync>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ int <charPos>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xe4db20*/ void MoveNext();
                /*0xe4dd94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ParseUnquotedPropertyAsync>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ int <initialPosition>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xe4dda0*/ void MoveNext();
                /*0xe4e068*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadNullCharAsync>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xe4e074*/ void MoveNext();
                /*0xe4e2b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <HandleNullAsync>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xe4e308*/ void MoveNext();
                /*0xe4e668*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadFinishedAsync>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xe4e674*/ void MoveNext();
                /*0xe4eb18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadStringValueAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ Newtonsoft.Json.ReadType readType;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x58*/ string <expected>5__2;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__3;

                /*0xe4eb24*/ void MoveNext();
                /*0xe4fab0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadNumberValueAsync>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ Newtonsoft.Json.ReadType readType;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__3;

                /*0xe4fb08*/ void MoveNext();
                /*0xe508ec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsBooleanAsync>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<bool>> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x50*/ System.Numerics.BigInteger <i>5__2;
                /*0x60*/ bool <isTrue>5__3;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xe50944*/ void MoveNext();
                /*0xe51604*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsBytesAsync>d__42 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Byte[]> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool <isWrapped>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x58*/ byte[] <data>5__3;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Byte[]> <>u__3;

                /*0xe5165c*/ void MoveNext();
                /*0xe52348*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadIntoWrappedTypeObjectAsync>d__43 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xe523a0*/ void MoveNext();
                /*0xe52884*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsDateTimeAsync>d__45 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<System.DateTime>> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;

                /*0xe52890*/ void MoveNext();
                /*0xe52ad8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsDateTimeOffsetAsync>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<System.DateTimeOffset>> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;

                /*0xe52b30*/ void MoveNext();
                /*0xe52db0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsDecimalAsync>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<decimal>> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;

                /*0xe52e08*/ void MoveNext();
                /*0xe53088*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsDoubleAsync>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<double>> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;

                /*0xe530e0*/ void MoveNext();
                /*0xe53350*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsInt32Async>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<int>> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;

                /*0xe533a8*/ void MoveNext();
                /*0xe535f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoReadAsStringAsync>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextReader <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;

                /*0xe53648*/ void MoveNext();
                /*0xe5387c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
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
            static int IndentCharBufferSize = 12;
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

            /*0xe57314*/ JsonTextWriter(System.IO.TextWriter textWriter);
            /*0xe538d4*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe538e8*/ System.Threading.Tasks.Task DoFlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe5397c*/ System.Threading.Tasks.Task WriteValueDelimiterAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53990*/ System.Threading.Tasks.Task DoWriteValueDelimiterAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53a00*/ System.Threading.Tasks.Task WriteEndAsync(Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken cancellationToken);
            /*0xe53a14*/ System.Threading.Tasks.Task DoWriteEndAsync(Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken cancellationToken);
            /*0xe53b50*/ System.Threading.Tasks.Task CloseAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53b64*/ System.Threading.Tasks.Task DoCloseAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53c3c*/ System.Threading.Tasks.Task WriteEndAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53c54*/ System.Threading.Tasks.Task WriteIndentAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53c68*/ System.Threading.Tasks.Task DoWriteIndentAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe53e10*/ System.Threading.Tasks.Task WriteIndentAsync(int currentIndentCount, int newLineLen, System.Threading.CancellationToken cancellationToken);
            /*0xe53f00*/ System.Threading.Tasks.Task WriteValueInternalAsync(Newtonsoft.Json.JsonToken token, string value, System.Threading.CancellationToken cancellationToken);
            /*0xe53fe0*/ System.Threading.Tasks.Task WriteValueInternalAsync(System.Threading.Tasks.Task task, string value, System.Threading.CancellationToken cancellationToken);
            /*0xe540d0*/ System.Threading.Tasks.Task WriteIndentSpaceAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe540e4*/ System.Threading.Tasks.Task DoWriteIndentSpaceAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54154*/ System.Threading.Tasks.Task WriteRawAsync(string json, System.Threading.CancellationToken cancellationToken);
            /*0xe54168*/ System.Threading.Tasks.Task DoWriteRawAsync(string json, System.Threading.CancellationToken cancellationToken);
            /*0xe541dc*/ System.Threading.Tasks.Task WriteNullAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe541f0*/ System.Threading.Tasks.Task DoWriteNullAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54264*/ System.Threading.Tasks.Task WriteDigitsAsync(ulong uvalue, bool negative, System.Threading.CancellationToken cancellationToken);
            /*0xe54420*/ System.Threading.Tasks.Task WriteIntegerValueAsync(ulong uvalue, bool negative, System.Threading.CancellationToken cancellationToken);
            /*0xe544f0*/ System.Threading.Tasks.Task WriteIntegerValueAsync(System.Threading.Tasks.Task task, ulong uvalue, bool negative, System.Threading.CancellationToken cancellationToken);
            /*0xe545ec*/ System.Threading.Tasks.Task WriteIntegerValueAsync(long value, System.Threading.CancellationToken cancellationToken);
            /*0xe54604*/ System.Threading.Tasks.Task WriteIntegerValueAsync(ulong uvalue, System.Threading.CancellationToken cancellationToken);
            /*0xe54610*/ System.Threading.Tasks.Task WriteEscapedStringAsync(string value, bool quote, System.Threading.CancellationToken cancellationToken);
            /*0xe546c4*/ System.Threading.Tasks.Task WritePropertyNameAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xe546d8*/ System.Threading.Tasks.Task DoWritePropertyNameAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xe5482c*/ System.Threading.Tasks.Task DoWritePropertyNameAsync(System.Threading.Tasks.Task task, string name, System.Threading.CancellationToken cancellationToken);
            /*0xe5491c*/ System.Threading.Tasks.Task WritePropertyNameAsync(string name, bool escape, System.Threading.CancellationToken cancellationToken);
            /*0xe54938*/ System.Threading.Tasks.Task DoWritePropertyNameAsync(string name, bool escape, System.Threading.CancellationToken cancellationToken);
            /*0xe54a28*/ System.Threading.Tasks.Task WriteStartArrayAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54a3c*/ System.Threading.Tasks.Task DoWriteStartArrayAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54b08*/ System.Threading.Tasks.Task DoWriteStartArrayAsync(System.Threading.Tasks.Task task, System.Threading.CancellationToken cancellationToken);
            /*0xe54be8*/ System.Threading.Tasks.Task WriteStartObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54bfc*/ System.Threading.Tasks.Task DoWriteStartObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54cc8*/ System.Threading.Tasks.Task DoWriteStartObjectAsync(System.Threading.Tasks.Task task, System.Threading.CancellationToken cancellationToken);
            /*0xe54da8*/ System.Threading.Tasks.Task WriteStartConstructorAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xe54dbc*/ System.Threading.Tasks.Task DoWriteStartConstructorAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xe54e9c*/ System.Threading.Tasks.Task WriteUndefinedAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54eb0*/ System.Threading.Tasks.Task DoWriteUndefinedAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe54fac*/ System.Threading.Tasks.Task DoWriteUndefinedAsync(System.Threading.Tasks.Task task, System.Threading.CancellationToken cancellationToken);
            /*0xe5508c*/ System.Threading.Tasks.Task WriteWhitespaceAsync(string ws, System.Threading.CancellationToken cancellationToken);
            /*0xe550a0*/ System.Threading.Tasks.Task DoWriteWhitespaceAsync(string ws, System.Threading.CancellationToken cancellationToken);
            /*0xe55124*/ System.Threading.Tasks.Task WriteValueAsync(bool value, System.Threading.CancellationToken cancellationToken);
            /*0xe55140*/ System.Threading.Tasks.Task DoWriteValueAsync(bool value, System.Threading.CancellationToken cancellationToken);
            /*0xe551bc*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<bool> value, System.Threading.CancellationToken cancellationToken);
            /*0xe551d8*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<bool> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55260*/ System.Threading.Tasks.Task WriteValueAsync(byte value, System.Threading.CancellationToken cancellationToken);
            /*0xe55284*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<byte> value, System.Threading.CancellationToken cancellationToken);
            /*0xe552a0*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<byte> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55324*/ System.Threading.Tasks.Task WriteValueAsync(byte[] value, System.Threading.CancellationToken cancellationToken);
            /*0xe55354*/ System.Threading.Tasks.Task WriteValueNonNullAsync(byte[] value, System.Threading.CancellationToken cancellationToken);
            /*0xe55434*/ System.Threading.Tasks.Task WriteValueAsync(char value, System.Threading.CancellationToken cancellationToken);
            /*0xe55448*/ System.Threading.Tasks.Task DoWriteValueAsync(char value, System.Threading.CancellationToken cancellationToken);
            /*0xe554c4*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<char> value, System.Threading.CancellationToken cancellationToken);
            /*0xe554e0*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<char> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55560*/ System.Threading.Tasks.Task WriteValueAsync(System.DateTime value, System.Threading.CancellationToken cancellationToken);
            /*0xe55574*/ System.Threading.Tasks.Task DoWriteValueAsync(System.DateTime value, System.Threading.CancellationToken cancellationToken);
            /*0xe55654*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.DateTime> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55668*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<System.DateTime> value, System.Threading.CancellationToken cancellationToken);
            /*0xe556e8*/ System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset value, System.Threading.CancellationToken cancellationToken);
            /*0xe556fc*/ System.Threading.Tasks.Task DoWriteValueAsync(System.DateTimeOffset value, System.Threading.CancellationToken cancellationToken);
            /*0xe557ec*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.DateTimeOffset> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55840*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<System.DateTimeOffset> value, System.Threading.CancellationToken cancellationToken);
            /*0xe558c0*/ System.Threading.Tasks.Task WriteValueAsync(decimal value, System.Threading.CancellationToken cancellationToken);
            /*0xe558d4*/ System.Threading.Tasks.Task DoWriteValueAsync(decimal value, System.Threading.CancellationToken cancellationToken);
            /*0xe55960*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<decimal> value, System.Threading.CancellationToken cancellationToken);
            /*0xe559d4*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<decimal> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55a54*/ System.Threading.Tasks.Task WriteValueAsync(double value, System.Threading.CancellationToken cancellationToken);
            /*0xe55a74*/ System.Threading.Tasks.Task WriteValueAsync(double value, bool nullable, System.Threading.CancellationToken cancellationToken);
            /*0xe55b10*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<double> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55bd0*/ System.Threading.Tasks.Task WriteValueAsync(float value, System.Threading.CancellationToken cancellationToken);
            /*0xe55bf0*/ System.Threading.Tasks.Task WriteValueAsync(float value, bool nullable, System.Threading.CancellationToken cancellationToken);
            /*0xe55c8c*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<float> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55d48*/ System.Threading.Tasks.Task WriteValueAsync(System.Guid value, System.Threading.CancellationToken cancellationToken);
            /*0xe55d5c*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Guid value, System.Threading.CancellationToken cancellationToken);
            /*0xe55e4c*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.Guid> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55ea0*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<System.Guid> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55f24*/ System.Threading.Tasks.Task WriteValueAsync(int value, System.Threading.CancellationToken cancellationToken);
            /*0xe55f54*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<int> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55f68*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<int> value, System.Threading.CancellationToken cancellationToken);
            /*0xe55ff4*/ System.Threading.Tasks.Task WriteValueAsync(long value, System.Threading.CancellationToken cancellationToken);
            /*0xe56020*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<long> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56034*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<long> value, System.Threading.CancellationToken cancellationToken);
            /*0xe560c0*/ System.Threading.Tasks.Task WriteValueAsync(System.Numerics.BigInteger value, System.Threading.CancellationToken cancellationToken);
            /*0xe56154*/ System.Threading.Tasks.Task WriteValueAsync(object value, System.Threading.CancellationToken cancellationToken);
            /*0xe562ac*/ System.Threading.Tasks.Task WriteValueAsync(sbyte value, System.Threading.CancellationToken cancellationToken);
            /*0xe562e0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<sbyte> value, System.Threading.CancellationToken cancellationToken);
            /*0xe562fc*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<sbyte> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56390*/ System.Threading.Tasks.Task WriteValueAsync(short value, System.Threading.CancellationToken cancellationToken);
            /*0xe563c4*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<short> value, System.Threading.CancellationToken cancellationToken);
            /*0xe563e0*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<short> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56474*/ System.Threading.Tasks.Task WriteValueAsync(string value, System.Threading.CancellationToken cancellationToken);
            /*0xe56488*/ System.Threading.Tasks.Task DoWriteValueAsync(string value, System.Threading.CancellationToken cancellationToken);
            /*0xe565b0*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Threading.Tasks.Task task, string value, System.Threading.CancellationToken cancellationToken);
            /*0xe566a0*/ System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan value, System.Threading.CancellationToken cancellationToken);
            /*0xe566b4*/ System.Threading.Tasks.Task DoWriteValueAsync(System.TimeSpan value, System.Threading.CancellationToken cancellationToken);
            /*0xe56794*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.TimeSpan> value, System.Threading.CancellationToken cancellationToken);
            /*0xe567a8*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<System.TimeSpan> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56828*/ System.Threading.Tasks.Task WriteValueAsync(uint value, System.Threading.CancellationToken cancellationToken);
            /*0xe5684c*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<uint> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56860*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<uint> value, System.Threading.CancellationToken cancellationToken);
            /*0xe568e4*/ System.Threading.Tasks.Task WriteValueAsync(ulong value, System.Threading.CancellationToken cancellationToken);
            /*0xe56904*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<ulong> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56918*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<ulong> value, System.Threading.CancellationToken cancellationToken);
            /*0xe5699c*/ System.Threading.Tasks.Task WriteValueAsync(System.Uri value, System.Threading.CancellationToken cancellationToken);
            /*0xe56a68*/ System.Threading.Tasks.Task WriteValueNotNullAsync(System.Uri value, System.Threading.CancellationToken cancellationToken);
            /*0xe56b38*/ System.Threading.Tasks.Task WriteValueNotNullAsync(System.Threading.Tasks.Task task, System.Uri value, System.Threading.CancellationToken cancellationToken);
            /*0xe56c28*/ System.Threading.Tasks.Task WriteValueAsync(ushort value, System.Threading.CancellationToken cancellationToken);
            /*0xe56c4c*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<ushort> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56c68*/ System.Threading.Tasks.Task DoWriteValueAsync(System.Nullable<ushort> value, System.Threading.CancellationToken cancellationToken);
            /*0xe56cec*/ System.Threading.Tasks.Task WriteCommentAsync(string text, System.Threading.CancellationToken cancellationToken);
            /*0xe56d00*/ System.Threading.Tasks.Task DoWriteCommentAsync(string text, System.Threading.CancellationToken cancellationToken);
            /*0xe56de0*/ System.Threading.Tasks.Task WriteEndArrayAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe56e04*/ System.Threading.Tasks.Task WriteEndConstructorAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe56e28*/ System.Threading.Tasks.Task WriteEndObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0xe56e4c*/ System.Threading.Tasks.Task WriteRawValueAsync(string json, System.Threading.CancellationToken cancellationToken);
            /*0xe56e60*/ System.Threading.Tasks.Task DoWriteRawValueAsync(string json, System.Threading.CancellationToken cancellationToken);
            /*0xe56f2c*/ System.Threading.Tasks.Task DoWriteRawValueAsync(System.Threading.Tasks.Task task, string json, System.Threading.CancellationToken cancellationToken);
            /*0xe5701c*/ char[] EnsureWriteBuffer(int length, int copyTo);
            /*0xe570b8*/ Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder();
            /*0xe5712c*/ Newtonsoft.Json.IArrayPool<char> get_ArrayPool();
            /*0xe57134*/ void set_ArrayPool(Newtonsoft.Json.IArrayPool<char> value);
            /*0xe57194*/ int get_Indentation();
            /*0xe5719c*/ void set_Indentation(int value);
            /*0xe571fc*/ char get_QuoteChar();
            /*0xe57204*/ void set_QuoteChar(char value);
            /*0xe572e0*/ char get_IndentChar();
            /*0xe572e8*/ void set_IndentChar(char value);
            /*0xe57300*/ bool get_QuoteName();
            /*0xe57308*/ void set_QuoteName(bool value);
            /*0xe5746c*/ void Flush();
            /*0xe5748c*/ void Close();
            /*0xe574a8*/ void CloseBufferAndWriter();
            /*0xe574f0*/ void WriteStartObject();
            /*0xe5752c*/ void WriteStartArray();
            /*0xe57568*/ void WriteStartConstructor(string name);
            /*0xe57614*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0xe57708*/ void WritePropertyName(string name);
            /*0xe5782c*/ void WritePropertyName(string name, bool escape);
            /*0xe578f0*/ void OnStringEscapeHandlingChanged();
            /*0xe57274*/ void UpdateCharEscapeFlags();
            /*0xe578f4*/ void WriteIndent();
            /*0xe53d2c*/ int SetIndentChars();
            /*0xe57a1c*/ void WriteValueDelimiter();
            /*0xe57a44*/ void WriteIndentSpace();
            /*0xe57a6c*/ void WriteValueInternal(string value, Newtonsoft.Json.JsonToken token);
            /*0xe57a90*/ void WriteValue(object value);
            /*0xe57b88*/ void WriteNull();
            /*0xe57c0c*/ void WriteUndefined();
            /*0xe57c90*/ void WriteRaw(string json);
            /*0xe57cd0*/ void WriteValue(string value);
            /*0xe57758*/ void WriteEscapedString(string value, bool quote);
            /*0xe57da0*/ void WriteValue(int value);
            /*0xe57e1c*/ void WriteValue(uint value);
            /*0xe57e98*/ void WriteValue(long value);
            /*0xe57ec8*/ void WriteValue(ulong value);
            /*0xe57f6c*/ void WriteValue(float value);
            /*0xe58018*/ void WriteValue(System.Nullable<float> value);
            /*0xe5810c*/ void WriteValue(double value);
            /*0xe581b8*/ void WriteValue(System.Nullable<double> value);
            /*0xe582b8*/ void WriteValue(bool value);
            /*0xe58350*/ void WriteValue(short value);
            /*0xe58380*/ void WriteValue(ushort value);
            /*0xe583b0*/ void WriteValue(char value);
            /*0xe58448*/ void WriteValue(byte value);
            /*0xe58478*/ void WriteValue(sbyte value);
            /*0xe584a8*/ void WriteValue(decimal value);
            /*0xe58548*/ void WriteValue(System.DateTime value);
            /*0xe586a4*/ int WriteValueToBuffer(System.DateTime value);
            /*0xe587ac*/ void WriteValue(byte[] value);
            /*0xe58864*/ void WriteValue(System.DateTimeOffset value);
            /*0xe58970*/ int WriteValueToBuffer(System.DateTimeOffset value);
            /*0xe58ab0*/ void WriteValue(System.Guid value);
            /*0xe58bac*/ void WriteValue(System.TimeSpan value);
            /*0xe58c94*/ void WriteValue(System.Uri value);
            /*0xe58d54*/ void WriteComment(string text);
            /*0xe58e0c*/ void WriteWhitespace(string ws);
            /*0xe57d74*/ void EnsureWriteBuffer();
            /*0xe57e4c*/ void WriteIntegerValue(long value);
            /*0xe57efc*/ void WriteIntegerValue(ulong value, bool negative);
            /*0xe54340*/ int WriteNumberToBuffer(ulong value, bool negative);
            /*0xe57dd0*/ void WriteIntegerValue(int value);
            /*0xe58f0c*/ void WriteIntegerValue(uint value, bool negative);
            /*0xe58e4c*/ int WriteNumberToBuffer(uint value, bool negative);

            struct <DoCloseAsync>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcda890*/ void MoveNext();
                /*0xcdaacc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteIndentAsync>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ int newLineLen;
                /*0x3c*/ int currentIndentCount;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdaad8*/ void MoveNext();
                /*0xcdae30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteValueInternalAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ string value;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdae3c*/ void MoveNext();
                /*0xcdb09c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteIntegerValueAsync>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ ulong uvalue;
                /*0x48*/ bool negative;
                /*0x50*/ System.Threading.CancellationToken cancellationToken;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdb0a8*/ void MoveNext();
                /*0xcdb2d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWritePropertyNameAsync>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ string name;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdb2e0*/ void MoveNext();
                /*0xcdb5c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWritePropertyNameAsync>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ string name;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ bool escape;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdb5d0*/ void MoveNext();
                /*0xcdbbcc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteStartArrayAsync>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdbbd8*/ void MoveNext();
                /*0xcdbe38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteStartObjectAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdbe44*/ void MoveNext();
                /*0xcdc0a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteStartConstructorAsync>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ string name;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdc0b0*/ void MoveNext();
                /*0xcdc5c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteUndefinedAsync>d__42 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdc5d0*/ void MoveNext();
                /*0xcdc864*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteValueNonNullAsync>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ byte[] value;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdc870*/ void MoveNext();
                /*0xcdcdb8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteValueAsync>d__59 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.DateTime value;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdcdc4*/ void MoveNext();
                /*0xcdd38c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteValueAsync>d__63 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.DateTimeOffset value;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdd398*/ void MoveNext();
                /*0xcdd8b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteValueAsync>d__77 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Guid value;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdd8bc*/ void MoveNext();
                /*0xcddd1c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteValueAsync>d__96 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ string value;
                /*0x40*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcddd28*/ void MoveNext();
                /*0xcddfec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteValueAsync>d__98 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.TimeSpan value;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcddff8*/ void MoveNext();
                /*0xcde464*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteValueNotNullAsync>d__109 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ System.Uri value;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcde470*/ void MoveNext();
                /*0xcde6b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteCommentAsync>d__114 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ string text;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcde6c4*/ void MoveNext();
                /*0xcdeb34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DoWriteRawValueAsync>d__120 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonTextWriter <>4__this;
                /*0x40*/ string json;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcdeb40*/ void MoveNext();
                /*0xcded68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
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

        class JsonValidatingReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
        {
            static /*0x0*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> EmptySchemaList;
            /*0x78*/ Newtonsoft.Json.JsonReader _reader;
            /*0x80*/ System.Collections.Generic.Stack<Newtonsoft.Json.JsonValidatingReader.SchemaScope> _stack;
            /*0x88*/ Newtonsoft.Json.Schema.JsonSchema _schema;
            /*0x90*/ Newtonsoft.Json.Schema.JsonSchemaModel _model;
            /*0x98*/ Newtonsoft.Json.JsonValidatingReader.SchemaScope _currentScope;
            /*0xa0*/ Newtonsoft.Json.Schema.ValidationEventHandler ValidationEventHandler;

            static /*0xce58fc*/ JsonValidatingReader();
            static /*0xce5208*/ double FloatingPointRemainder(double dividend, double divisor);
            static /*0xce519c*/ bool IsZero(double value);
            /*0xce05f8*/ JsonValidatingReader(Newtonsoft.Json.JsonReader reader);
            /*0xcded74*/ void add_ValidationEventHandler(Newtonsoft.Json.Schema.ValidationEventHandler value);
            /*0xcdee10*/ void remove_ValidationEventHandler(Newtonsoft.Json.Schema.ValidationEventHandler value);
            /*0xcdeeac*/ object get_Value();
            /*0xcdeed0*/ int get_Depth();
            /*0xcdeef4*/ string get_Path();
            /*0xcdef18*/ char get_QuoteChar();
            /*0xcdef3c*/ void set_QuoteChar(char value);
            /*0xcdef40*/ Newtonsoft.Json.JsonToken get_TokenType();
            /*0xcdef64*/ System.Type get_ValueType();
            /*0xcdef88*/ void Push(Newtonsoft.Json.JsonValidatingReader.SchemaScope scope);
            /*0xcdefe8*/ Newtonsoft.Json.JsonValidatingReader.SchemaScope Pop();
            /*0xcdf08c*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> get_CurrentSchemas();
            /*0xcdf0a8*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> get_CurrentMemberSchemas();
            /*0xce0204*/ void RaiseError(string message, Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce0558*/ void OnValidationEvent(Newtonsoft.Json.Schema.JsonSchemaException exception);
            /*0xce06ac*/ Newtonsoft.Json.Schema.JsonSchema get_Schema();
            /*0xce06b4*/ void set_Schema(Newtonsoft.Json.Schema.JsonSchema value);
            /*0xce0738*/ Newtonsoft.Json.JsonReader get_Reader();
            /*0xce0740*/ void Close();
            /*0xce077c*/ void ValidateNotDisallowed(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce08b8*/ System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> GetCurrentNodeSchemaType();
            /*0xce09b8*/ System.Nullable<int> ReadAsInt32();
            /*0xce2258*/ byte[] ReadAsBytes();
            /*0xce229c*/ System.Nullable<decimal> ReadAsDecimal();
            /*0xce2318*/ System.Nullable<double> ReadAsDouble();
            /*0xce2364*/ System.Nullable<bool> ReadAsBoolean();
            /*0xce23a8*/ string ReadAsString();
            /*0xce23ec*/ System.Nullable<System.DateTime> ReadAsDateTime();
            /*0xce2438*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
            /*0xce2494*/ bool Read();
            /*0xce09fc*/ void ValidateCurrentToken();
            /*0xce2cb8*/ void WriteToken(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> schemas);
            /*0xce4a94*/ void ValidateEndObject(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce4df4*/ void ValidateEndArray(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce4a54*/ void ValidateNull(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce4a14*/ void ValidateBoolean(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce44e8*/ void ValidateString(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce3a18*/ void ValidateInteger(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce2854*/ void ProcessValue();
            /*0xce4020*/ void ValidateFloat(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce3870*/ void ValidatePropertyName(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce5274*/ bool IsPropertyDefinied(Newtonsoft.Json.Schema.JsonSchemaModel schema, string propertyName);
            /*0xce56b0*/ bool ValidateArray(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce56c4*/ bool ValidateObject(Newtonsoft.Json.Schema.JsonSchemaModel schema);
            /*0xce5058*/ bool TestType(Newtonsoft.Json.Schema.JsonSchemaModel currentSchema, Newtonsoft.Json.Schema.JsonSchemaType currentType);
            /*0xce56d8*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
            /*0xce578c*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
            /*0xce5844*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();

            class SchemaScope
            {
                /*0x10*/ Newtonsoft.Json.Linq.JTokenType _tokenType;
                /*0x18*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> _schemas;
                /*0x20*/ System.Collections.Generic.Dictionary<string, bool> _requiredProperties;
                /*0x28*/ string <CurrentPropertyName>k__BackingField;
                /*0x30*/ int <ArrayItemCount>k__BackingField;
                /*0x34*/ bool <IsUniqueArray>k__BackingField;
                /*0x38*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> <UniqueArrayItems>k__BackingField;
                /*0x40*/ Newtonsoft.Json.Linq.JTokenWriter <CurrentItemWriter>k__BackingField;

                /*0xce24f8*/ SchemaScope(Newtonsoft.Json.Linq.JTokenType tokenType, System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> schemas);
                /*0xce5988*/ string get_CurrentPropertyName();
                /*0xce5990*/ void set_CurrentPropertyName(string value);
                /*0xce5998*/ int get_ArrayItemCount();
                /*0xce59a0*/ void set_ArrayItemCount(int value);
                /*0xce59a8*/ bool get_IsUniqueArray();
                /*0xce59b0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_UniqueArrayItems();
                /*0xce59b8*/ Newtonsoft.Json.Linq.JTokenWriter get_CurrentItemWriter();
                /*0xce59c0*/ void set_CurrentItemWriter(Newtonsoft.Json.Linq.JTokenWriter value);
                /*0xce59c8*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> get_Schemas();
                /*0xce59d0*/ System.Collections.Generic.Dictionary<string, bool> get_RequiredProperties();
                /*0xce59d8*/ Newtonsoft.Json.Linq.JTokenType get_TokenType();
                /*0xce59e0*/ System.Collections.Generic.IEnumerable<string> GetRequiredProperties(Newtonsoft.Json.Schema.JsonSchemaModel schema);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.JsonValidatingReader.SchemaScope.<> <>9;
                    static /*0x8*/ System.Func<string, string> <>9__27_0;
                    static /*0x10*/ System.Func<string, bool> <>9__27_1;
                    static /*0x18*/ System.Func<Newtonsoft.Json.Schema.JsonSchemaModel, bool> <>9__27_2;
                    static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Schema.JsonSchemaModel>, bool> <>9__28_0;
                    static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Schema.JsonSchemaModel>, string> <>9__28_1;

                    static /*0xce5c04*/ <>c();
                    /*0xce5c68*/ <>c();
                    /*0xce5c70*/ string <.ctor>b__27_0(string p);
                    /*0xce5c78*/ bool <.ctor>b__27_1(string p);
                    /*0xce5c80*/ bool <.ctor>b__27_2(Newtonsoft.Json.Schema.JsonSchemaModel s);
                    /*0xce5c98*/ bool <GetRequiredProperties>b__28_0(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Schema.JsonSchemaModel> p);
                    /*0xce5cdc*/ string <GetRequiredProperties>b__28_1(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Schema.JsonSchemaModel> p);
                }
            }

            class <>c
            {
                static /*0x0*/ Newtonsoft.Json.JsonValidatingReader.<> <>9;
                static /*0x8*/ System.Func<Newtonsoft.Json.Schema.JsonSchemaModel, bool> <>9__50_0;
                static /*0x10*/ System.Func<Newtonsoft.Json.Schema.JsonSchemaModel, bool> <>9__50_1;
                static /*0x18*/ System.Func<Newtonsoft.Json.Schema.JsonSchemaModel, bool> <>9__50_2;
                static /*0x20*/ System.Func<bool, bool> <>9__51_0;
                static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<string, bool>, bool> <>9__51_1;
                static /*0x30*/ System.Func<System.Collections.Generic.KeyValuePair<string, bool>, string> <>9__51_2;

                static /*0xce5d18*/ <>c();
                /*0xce5d7c*/ <>c();
                /*0xce5d84*/ bool <WriteToken>b__50_0(Newtonsoft.Json.Schema.JsonSchemaModel s);
                /*0xce5da4*/ bool <WriteToken>b__50_1(Newtonsoft.Json.Schema.JsonSchemaModel s);
                /*0xce5dbc*/ bool <WriteToken>b__50_2(Newtonsoft.Json.Schema.JsonSchemaModel s);
                /*0xce5ddc*/ bool <ValidateEndObject>b__51_0(bool v);
                /*0xce5de8*/ bool <ValidateEndObject>b__51_1(System.Collections.Generic.KeyValuePair<string, bool> kv);
                /*0xce5e28*/ string <ValidateEndObject>b__51_2(System.Collections.Generic.KeyValuePair<string, bool> kv);
            }
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

            static /*0xceb8e8*/ JsonWriter();
            static /*0xcea248*/ System.Threading.Tasks.Task WriteValueAsync(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value, System.Threading.CancellationToken cancellationToken);
            static /*0xceb66c*/ Newtonsoft.Json.JsonWriter.State[][] BuildStateArray();
            static /*0xcedfb4*/ void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value);
            static /*0xceb41c*/ void ResolveConvertibleValue(System.IConvertible convertible, ref Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, ref object value);
            static /*0xceb5b4*/ Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, object value);
            /*0xcec130*/ JsonWriter();
            /*0xce5e64*/ System.Threading.Tasks.Task AutoCompleteAsync(Newtonsoft.Json.JsonToken tokenBeingWritten, System.Threading.CancellationToken cancellationToken);
            /*0xce60dc*/ System.Threading.Tasks.Task AutoCompleteAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce61b4*/ System.Threading.Tasks.Task CloseAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce625c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce6304*/ System.Threading.Tasks.Task WriteEndAsync(Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken cancellationToken);
            /*0xce63bc*/ System.Threading.Tasks.Task WriteIndentAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce6464*/ System.Threading.Tasks.Task WriteValueDelimiterAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce650c*/ System.Threading.Tasks.Task WriteIndentSpaceAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce65b4*/ System.Threading.Tasks.Task WriteRawAsync(string json, System.Threading.CancellationToken cancellationToken);
            /*0xce666c*/ System.Threading.Tasks.Task WriteEndAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce6714*/ System.Threading.Tasks.Task WriteEndInternalAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce686c*/ System.Threading.Tasks.Task InternalWriteEndAsync(Newtonsoft.Json.JsonContainerType type, System.Threading.CancellationToken cancellationToken);
            /*0xce7090*/ System.Threading.Tasks.Task WriteEndArrayAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce7138*/ System.Threading.Tasks.Task WriteEndConstructorAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce71e0*/ System.Threading.Tasks.Task WriteEndObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce7288*/ System.Threading.Tasks.Task WriteNullAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce7330*/ System.Threading.Tasks.Task WritePropertyNameAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xce73e8*/ System.Threading.Tasks.Task WritePropertyNameAsync(string name, bool escape, System.Threading.CancellationToken cancellationToken);
            /*0xcdbb34*/ System.Threading.Tasks.Task InternalWritePropertyNameAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xce74a8*/ System.Threading.Tasks.Task WriteStartArrayAsync(System.Threading.CancellationToken cancellationToken);
            /*0xcdc4d0*/ System.Threading.Tasks.Task InternalWriteStartAsync(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container, System.Threading.CancellationToken cancellationToken);
            /*0xce7550*/ System.Threading.Tasks.Task WriteCommentAsync(string text, System.Threading.CancellationToken cancellationToken);
            /*0xcdeb28*/ System.Threading.Tasks.Task InternalWriteCommentAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce7608*/ System.Threading.Tasks.Task WriteRawValueAsync(string json, System.Threading.CancellationToken cancellationToken);
            /*0xce76c0*/ System.Threading.Tasks.Task WriteStartConstructorAsync(string name, System.Threading.CancellationToken cancellationToken);
            /*0xce7778*/ System.Threading.Tasks.Task WriteStartObjectAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce7820*/ System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
            /*0xce782c*/ System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonReader reader, bool writeChildren, System.Threading.CancellationToken cancellationToken);
            /*0xce78bc*/ System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken cancellationToken);
            /*0xce78c8*/ System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonToken token, object value, System.Threading.CancellationToken cancellationToken);
            /*0xce7fc8*/ System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, System.Threading.CancellationToken cancellationToken);
            /*0xce80d8*/ System.Threading.Tasks.Task WriteTokenSyncReadingAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
            /*0xce81b8*/ System.Threading.Tasks.Task WriteConstructorDateAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
            /*0xce8298*/ System.Threading.Tasks.Task WriteValueAsync(bool value, System.Threading.CancellationToken cancellationToken);
            /*0xce8350*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<bool> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8408*/ System.Threading.Tasks.Task WriteValueAsync(byte value, System.Threading.CancellationToken cancellationToken);
            /*0xce84c0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<byte> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8578*/ System.Threading.Tasks.Task WriteValueAsync(byte[] value, System.Threading.CancellationToken cancellationToken);
            /*0xce8630*/ System.Threading.Tasks.Task WriteValueAsync(char value, System.Threading.CancellationToken cancellationToken);
            /*0xce86e8*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<char> value, System.Threading.CancellationToken cancellationToken);
            /*0xce87a0*/ System.Threading.Tasks.Task WriteValueAsync(System.DateTime value, System.Threading.CancellationToken cancellationToken);
            /*0xce8858*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.DateTime> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8918*/ System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset value, System.Threading.CancellationToken cancellationToken);
            /*0xce89d8*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.DateTimeOffset> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8aa8*/ System.Threading.Tasks.Task WriteValueAsync(decimal value, System.Threading.CancellationToken cancellationToken);
            /*0xce8b68*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<decimal> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8c60*/ System.Threading.Tasks.Task WriteValueAsync(double value, System.Threading.CancellationToken cancellationToken);
            /*0xce8d20*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<double> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8de0*/ System.Threading.Tasks.Task WriteValueAsync(float value, System.Threading.CancellationToken cancellationToken);
            /*0xce8ea0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<float> value, System.Threading.CancellationToken cancellationToken);
            /*0xce8f58*/ System.Threading.Tasks.Task WriteValueAsync(System.Guid value, System.Threading.CancellationToken cancellationToken);
            /*0xce9018*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.Guid> value, System.Threading.CancellationToken cancellationToken);
            /*0xce90e8*/ System.Threading.Tasks.Task WriteValueAsync(int value, System.Threading.CancellationToken cancellationToken);
            /*0xce91a0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<int> value, System.Threading.CancellationToken cancellationToken);
            /*0xce9258*/ System.Threading.Tasks.Task WriteValueAsync(long value, System.Threading.CancellationToken cancellationToken);
            /*0xce9310*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<long> value, System.Threading.CancellationToken cancellationToken);
            /*0xce93d0*/ System.Threading.Tasks.Task WriteValueAsync(object value, System.Threading.CancellationToken cancellationToken);
            /*0xce9488*/ System.Threading.Tasks.Task WriteValueAsync(sbyte value, System.Threading.CancellationToken cancellationToken);
            /*0xce9540*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<sbyte> value, System.Threading.CancellationToken cancellationToken);
            /*0xce95f8*/ System.Threading.Tasks.Task WriteValueAsync(short value, System.Threading.CancellationToken cancellationToken);
            /*0xce96b0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<short> value, System.Threading.CancellationToken cancellationToken);
            /*0xce9768*/ System.Threading.Tasks.Task WriteValueAsync(string value, System.Threading.CancellationToken cancellationToken);
            /*0xce9820*/ System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan value, System.Threading.CancellationToken cancellationToken);
            /*0xce98d8*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<System.TimeSpan> value, System.Threading.CancellationToken cancellationToken);
            /*0xce9998*/ System.Threading.Tasks.Task WriteValueAsync(uint value, System.Threading.CancellationToken cancellationToken);
            /*0xce9a50*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<uint> value, System.Threading.CancellationToken cancellationToken);
            /*0xce9b08*/ System.Threading.Tasks.Task WriteValueAsync(ulong value, System.Threading.CancellationToken cancellationToken);
            /*0xce9bc0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<ulong> value, System.Threading.CancellationToken cancellationToken);
            /*0xce9c80*/ System.Threading.Tasks.Task WriteValueAsync(System.Uri value, System.Threading.CancellationToken cancellationToken);
            /*0xce9d38*/ System.Threading.Tasks.Task WriteValueAsync(ushort value, System.Threading.CancellationToken cancellationToken);
            /*0xce9df0*/ System.Threading.Tasks.Task WriteValueAsync(System.Nullable<ushort> value, System.Threading.CancellationToken cancellationToken);
            /*0xce9ea8*/ System.Threading.Tasks.Task WriteUndefinedAsync(System.Threading.CancellationToken cancellationToken);
            /*0xce9f50*/ System.Threading.Tasks.Task WriteWhitespaceAsync(string ws, System.Threading.CancellationToken cancellationToken);
            /*0xcdcd10*/ System.Threading.Tasks.Task InternalWriteValueAsync(Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken cancellationToken);
            /*0xcea020*/ System.Threading.Tasks.Task SetWriteStateAsync(Newtonsoft.Json.JsonToken token, object value, System.Threading.CancellationToken cancellationToken);
            /*0xcebc44*/ bool get_CloseOutput();
            /*0xcebc4c*/ void set_CloseOutput(bool value);
            /*0xcebc58*/ bool get_AutoCompleteOnClose();
            /*0xcebc60*/ void set_AutoCompleteOnClose(bool value);
            /*0xcdaa7c*/ int get_Top();
            /*0xcebc6c*/ Newtonsoft.Json.WriteState get_WriteState();
            /*0xcebd1c*/ string get_ContainerPath();
            /*0xcebdc8*/ string get_Path();
            /*0xcebeec*/ Newtonsoft.Json.Formatting get_Formatting();
            /*0xcebef4*/ void set_Formatting(Newtonsoft.Json.Formatting value);
            /*0xcebf58*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
            /*0xcebf60*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
            /*0xcebfc4*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
            /*0xcebfcc*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
            /*0xcec030*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
            /*0xcec038*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
            /*0xcec0a8*/ void OnStringEscapeHandlingChanged();
            /*0xcec0ac*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
            /*0xcec0b4*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
            /*0xcec118*/ string get_DateFormatString();
            /*0xcec120*/ void set_DateFormatString(string value);
            /*0xcdd324*/ System.Globalization.CultureInfo get_Culture();
            /*0xcec128*/ void set_Culture(System.Globalization.CultureInfo value);
            /*0xcea008*/ void UpdateScopeWithFinishedValue();
            /*0xcec15c*/ void Push(Newtonsoft.Json.JsonContainerType value);
            /*0xce6b88*/ Newtonsoft.Json.JsonContainerType Pop();
            /*0xce6864*/ Newtonsoft.Json.JsonContainerType Peek();
            void Flush();
            /*0xcec2d4*/ void Close();
            /*0xcec324*/ void WriteStartObject();
            /*0xcec370*/ void WriteEndObject();
            /*0xcec37c*/ void WriteStartArray();
            /*0xcec388*/ void WriteEndArray();
            /*0xcec390*/ void WriteStartConstructor(string name);
            /*0xcec39c*/ void WriteEndConstructor();
            /*0xcec3a4*/ void WritePropertyName(string name);
            /*0xcec3c4*/ void WritePropertyName(string name, bool escape);
            /*0xcec3d4*/ void WriteEnd();
            /*0xcec4b8*/ void WriteToken(Newtonsoft.Json.JsonReader reader);
            /*0xce4fd8*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren);
            /*0xcec4c0*/ void WriteToken(Newtonsoft.Json.JsonToken token, object value);
            /*0xcecb48*/ void WriteToken(Newtonsoft.Json.JsonToken token);
            /*0xcecb50*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            /*0xcecea8*/ bool IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, bool writeChildren, int initialDepth);
            /*0xcecd70*/ int CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader);
            /*0xcecf18*/ int CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader);
            /*0xcecddc*/ void WriteConstructorDate(Newtonsoft.Json.JsonReader reader);
            /*0xcec3dc*/ void WriteEnd(Newtonsoft.Json.JsonContainerType type);
            /*0xcec2e4*/ void AutoCompleteAll();
            /*0xce6c58*/ Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type);
            /*0xcecf80*/ void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type);
            /*0xce6a90*/ int CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type);
            /*0xce6fdc*/ void UpdateCurrentState();
            /*0xced03c*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
            /*0xced040*/ void WriteIndent();
            /*0xced044*/ void WriteValueDelimiter();
            /*0xced048*/ void WriteIndentSpace();
            /*0xced04c*/ void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten);
            /*0xced254*/ void WriteNull();
            /*0xced288*/ void WriteUndefined();
            /*0xced2a4*/ void WriteRaw(string json);
            /*0xced2ac*/ void WriteRawValue(string json);
            /*0xced2fc*/ void WriteValue(string value);
            /*0xced318*/ void WriteValue(int value);
            /*0xced334*/ void WriteValue(uint value);
            /*0xced350*/ void WriteValue(long value);
            /*0xced36c*/ void WriteValue(ulong value);
            /*0xced388*/ void WriteValue(float value);
            /*0xced3a4*/ void WriteValue(double value);
            /*0xced3c0*/ void WriteValue(bool value);
            /*0xced3dc*/ void WriteValue(short value);
            /*0xced3f8*/ void WriteValue(ushort value);
            /*0xced414*/ void WriteValue(char value);
            /*0xced430*/ void WriteValue(byte value);
            /*0xced44c*/ void WriteValue(sbyte value);
            /*0xced468*/ void WriteValue(decimal value);
            /*0xced484*/ void WriteValue(System.DateTime value);
            /*0xced4a0*/ void WriteValue(System.DateTimeOffset value);
            /*0xced4bc*/ void WriteValue(System.Guid value);
            /*0xced4d8*/ void WriteValue(System.TimeSpan value);
            /*0xced4f4*/ void WriteValue(System.Nullable<int> value);
            /*0xced570*/ void WriteValue(System.Nullable<uint> value);
            /*0xced5ec*/ void WriteValue(System.Nullable<long> value);
            /*0xced678*/ void WriteValue(System.Nullable<ulong> value);
            /*0xced704*/ void WriteValue(System.Nullable<float> value);
            /*0xced784*/ void WriteValue(System.Nullable<double> value);
            /*0xced814*/ void WriteValue(System.Nullable<bool> value);
            /*0xced89c*/ void WriteValue(System.Nullable<short> value);
            /*0xced918*/ void WriteValue(System.Nullable<ushort> value);
            /*0xced994*/ void WriteValue(System.Nullable<char> value);
            /*0xceda10*/ void WriteValue(System.Nullable<byte> value);
            /*0xceda8c*/ void WriteValue(System.Nullable<sbyte> value);
            /*0xcedb08*/ void WriteValue(System.Nullable<decimal> value);
            /*0xcedb88*/ void WriteValue(System.Nullable<System.DateTime> value);
            /*0xcedc14*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
            /*0xcedc94*/ void WriteValue(System.Nullable<System.Guid> value);
            /*0xcedd18*/ void WriteValue(System.Nullable<System.TimeSpan> value);
            /*0xcedda4*/ void WriteValue(byte[] value);
            /*0xceddd4*/ void WriteValue(System.Uri value);
            /*0xcede80*/ void WriteValue(object value);
            /*0xcef168*/ void WriteComment(string text);
            /*0xcef178*/ void WriteWhitespace(string ws);
            /*0xcef1dc*/ void System.IDisposable.Dispose();
            /*0xcef24c*/ void Dispose(bool disposing);
            /*0xcef270*/ void SetWriteState(Newtonsoft.Json.JsonToken token, object value);
            /*0xcec378*/ void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container);
            /*0xcec3b4*/ void InternalWritePropertyName(string name);
            /*0xced2a8*/ void InternalWriteRaw();
            /*0xcec330*/ void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container);
            /*0xced270*/ void InternalWriteValue(Newtonsoft.Json.JsonToken token);
            /*0xcef17c*/ void InternalWriteWhitespace(string ws);
            /*0xcef170*/ void InternalWriteComment();
            /*0xce6cf4*/ System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitProperty|11_0(System.Threading.Tasks.Task task, int LevelsToComplete, Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken CancellationToken);
            /*0xce6de8*/ System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitIndent|11_1(System.Threading.Tasks.Task task, int LevelsToComplete, Newtonsoft.Json.JsonToken token, System.Threading.CancellationToken CancellationToken);
            /*0xce6ee8*/ System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitEnd|11_2(System.Threading.Tasks.Task task, int LevelsToComplete, System.Threading.CancellationToken CancellationToken);
            /*0xcef430*/ System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, System.Threading.CancellationToken CancellationToken);

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

            struct <AutoCompleteAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcef514*/ void MoveNext();
                /*0xcef758*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InternalWriteStartAsync>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x38*/ Newtonsoft.Json.JsonToken token;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ Newtonsoft.Json.JsonContainerType container;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xcef764*/ void MoveNext();
                /*0xcef920*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteTokenAsync>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x38*/ Newtonsoft.Json.JsonReader reader;
                /*0x40*/ bool writeDateConstructorAsDate;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ bool writeComments;
                /*0x51*/ bool writeChildren;
                /*0x54*/ int <initialDepth>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;

                /*0xcef92c*/ void MoveNext();
                /*0xcefed0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteTokenSyncReadingAsync>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x38*/ Newtonsoft.Json.JsonReader reader;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ int <initialDepth>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xcefedc*/ void MoveNext();
                /*0xcf02fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteConstructorDateAsync>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonReader reader;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x48*/ System.DateTime <date>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xcf0308*/ void MoveNext();
                /*0xcf0958*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<InternalWriteEndAsync>g__AwaitProperty|11_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x40*/ System.Threading.CancellationToken CancellationToken;
                /*0x48*/ Newtonsoft.Json.JsonToken token;
                /*0x4c*/ int LevelsToComplete;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xd79798*/ void MoveNext();
                /*0xd79b48*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<InternalWriteEndAsync>g__AwaitIndent|11_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x40*/ Newtonsoft.Json.JsonToken token;
                /*0x48*/ System.Threading.CancellationToken CancellationToken;
                /*0x50*/ int LevelsToComplete;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xd79b54*/ void MoveNext();
                /*0xd79e38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<InternalWriteEndAsync>g__AwaitEnd|11_2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Threading.Tasks.Task task;
                /*0x38*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x40*/ int LevelsToComplete;
                /*0x48*/ System.Threading.CancellationToken CancellationToken;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xd79e44*/ void MoveNext();
                /*0xd7a078*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Newtonsoft.Json.JsonWriter <>4__this;
                /*0x38*/ System.Threading.CancellationToken CancellationToken;
                /*0x40*/ int LevelsToComplete;
                /*0x44*/ Newtonsoft.Json.JsonToken <token>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xd7a084*/ void MoveNext();
                /*0xd7a3f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class JsonWriterException : Newtonsoft.Json.JsonException
        {
            /*0x90*/ string <Path>k__BackingField;

            static /*0xd7a458*/ Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, string message, System.Exception ex);
            static /*0xd7a48c*/ Newtonsoft.Json.JsonWriterException Create(string path, string message, System.Exception ex);
            /*0xd7a40c*/ JsonWriterException();
            /*0xd7a414*/ JsonWriterException(string message);
            /*0xd7a41c*/ JsonWriterException(string message, System.Exception innerException);
            /*0xd7a424*/ JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xd7a42c*/ JsonWriterException(string message, string path, System.Exception innerException);
            /*0xd7a404*/ string get_Path();
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

                static /*0xd7a708*/ AotHelper();
                static /*0xd7a548*/ void Ensure(System.Action action);
                static void EnsureType<T>();
                static void EnsureList<T>();
                static void EnsureDictionary<TKey, TValue>();
                static /*0xd7a6b0*/ bool IsFalse();

                class <>c__<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.AotHelper.<>c__1<T> <>9;
                    static /*0x0*/ System.Action <>9__1_0;

                    static <>c__();
                    <>c__();
                    void <EnsureType>b__1_0();
                }

                class <>c__2<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.AotHelper.<>c__2<T> <>9;
                    static /*0x0*/ System.Action <>9__2_0;

                    static <>c__2();
                    <>c__2();
                    void <EnsureList>b__2_0();
                }

                class <>c__3<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.AotHelper.<>c__3<TKey, TValue> <>9;
                    static /*0x0*/ System.Action <>9__3_0;

                    static <>c__3();
                    <>c__3();
                    void <EnsureDictionary>b__3_0();
                }
            }

            class AsyncUtils
            {
                static /*0x0*/ System.Threading.Tasks.Task<bool> False;
                static /*0x8*/ System.Threading.Tasks.Task<bool> True;
                static /*0x10*/ System.Threading.Tasks.Task CompletedTask;

                static /*0xd7ac6c*/ AsyncUtils();
                static /*0xd7a794*/ System.Threading.Tasks.Task<bool> ToAsync(bool value);
                static /*0xd7a7fc*/ System.Threading.Tasks.Task CancelIfRequestedAsync(System.Threading.CancellationToken cancellationToken);
                static System.Threading.Tasks.Task<T> CancelIfRequestedAsync<T>(System.Threading.CancellationToken cancellationToken);
                static /*0xd7a870*/ System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken cancellationToken);
                static System.Threading.Tasks.Task<T> FromCanceled<T>(System.Threading.CancellationToken cancellationToken);
                static /*0xd7a980*/ System.Threading.Tasks.Task WriteAsync(System.IO.TextWriter writer, char value, System.Threading.CancellationToken cancellationToken);
                static /*0xd7aa20*/ System.Threading.Tasks.Task WriteAsync(System.IO.TextWriter writer, string value, System.Threading.CancellationToken cancellationToken);
                static /*0xd7aac0*/ System.Threading.Tasks.Task WriteAsync(System.IO.TextWriter writer, char[] value, int start, int count, System.Threading.CancellationToken cancellationToken);
                static /*0xd7ab78*/ System.Threading.Tasks.Task<int> ReadAsync(System.IO.TextReader reader, char[] buffer, int index, int count, System.Threading.CancellationToken cancellationToken);
                static /*0xd7ac48*/ bool IsCompletedSucessfully(System.Threading.Tasks.Task task);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.AsyncUtils.<> <>9;
                    static /*0x8*/ System.Action <>9__5_0;

                    static /*0xd7ad28*/ <>c();
                    /*0xd7ad8c*/ <>c();
                    /*0xd7ad94*/ void <FromCanceled>b__5_0();
                }

                class <>c__6<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.AsyncUtils.<>c__6<T> <>9;
                    static /*0x0*/ System.Func<T> <>9__6_0;

                    static <>c__6();
                    <>c__6();
                    T <FromCanceled>b__6_0();
                }
            }

            class Base64Encoder
            {
                static int Base64LineSize = 76;
                static int LineSizeInBytes = 57;
                /*0x10*/ char[] _charsLine;
                /*0x18*/ System.IO.TextWriter _writer;
                /*0x20*/ byte[] _leftOverBytes;
                /*0x28*/ int _leftOverBytesCount;

                /*0xd7ad98*/ Base64Encoder(System.IO.TextWriter writer);
                /*0xd7ae28*/ void ValidateEncode(byte[] buffer, int index, int count);
                /*0xd7aef8*/ void Encode(byte[] buffer, int index, int count);
                /*0xd7b154*/ void StoreLeftOverBytes(byte[] buffer, int index, ref int count);
                /*0xd7b090*/ bool FulfillFromLeftover(byte[] buffer, int index, ref int count);
                /*0xd7b278*/ void Flush();
                /*0xd7b130*/ void WriteChars(char[] chars, int index, int count);
                /*0xd7b330*/ System.Threading.Tasks.Task EncodeAsync(byte[] buffer, int index, int count, System.Threading.CancellationToken cancellationToken);
                /*0xd7b42c*/ System.Threading.Tasks.Task WriteCharsAsync(char[] chars, int index, int count, System.Threading.CancellationToken cancellationToken);
                /*0xd7b4b4*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);

                struct <EncodeAsync>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Newtonsoft.Json.Utilities.Base64Encoder <>4__this;
                    /*0x38*/ byte[] buffer;
                    /*0x40*/ int index;
                    /*0x44*/ int count;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ int <num4>5__2;
                    /*0x54*/ int <length>5__3;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xd7b5c0*/ void MoveNext();
                    /*0xd7b944*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class BidirectionalDictionary<TFirst, TSecond>
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TFirst, TSecond> _firstToSecond;
                /*0x0*/ System.Collections.Generic.IDictionary<TSecond, TFirst> _secondToFirst;
                /*0x0*/ string _duplicateFirstErrorMessage;
                /*0x0*/ string _duplicateSecondErrorMessage;

                BidirectionalDictionary();
                BidirectionalDictionary(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer);
                BidirectionalDictionary(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage);
                void Set(TFirst first, TSecond second);
                bool TryGetByFirst(TFirst first, ref TSecond second);
                bool TryGetBySecond(TSecond second, ref TFirst first);
            }

            class CollectionUtils
            {
                static bool IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection);
                static void AddRange<T>(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection);
                static /*0xd7b950*/ bool IsDictionaryType(System.Type type);
                static /*0xd7bb5c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType);
                static /*0xd7bc6c*/ System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType);
                static bool AddDistinct<T>(System.Collections.Generic.IList<T> list, T value);
                static bool AddDistinct<T>(System.Collections.Generic.IList<T> list, T value, System.Collections.Generic.IEqualityComparer<T> comparer);
                static bool ContainsValue<TSource>(System.Collections.Generic.IEnumerable<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer);
                static bool AddRangeDistinct<T>(System.Collections.Generic.IList<T> list, System.Collections.Generic.IEnumerable<T> values, System.Collections.Generic.IEqualityComparer<T> comparer);
                static int IndexOf<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, bool> predicate);
                static bool Contains<T>(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer);
                static int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
                static void FastReverse<T>(System.Collections.Generic.List<T> list);
                static /*0xd7bf94*/ System.Collections.Generic.IList<int> GetDimensions(System.Collections.IList values, int dimensionsCount);
                static /*0xd7c248*/ void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, int[] indices);
                static /*0xd7c508*/ object JaggedArrayGetValue(System.Collections.IList values, int[] indices);
                static /*0xd7c644*/ System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, int rank);
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

            class CollectionWrapper<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedCollection, System.Collections.IList, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IList _list;
                /*0x0*/ System.Collections.Generic.ICollection<T> _genericCollection;
                /*0x0*/ object _syncRoot;

                static void VerifyValueType(object value);
                static bool IsCompatibleObject(object value);
                CollectionWrapper(System.Collections.IList list);
                CollectionWrapper(System.Collections.Generic.ICollection<T> list);
                void Add(T item);
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int arrayIndex);
                int get_Count();
                bool get_IsReadOnly();
                bool Remove(T item);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                int System.Collections.IList.Add(object value);
                bool System.Collections.IList.Contains(object value);
                int System.Collections.IList.IndexOf(object value);
                void System.Collections.IList.RemoveAt(int index);
                void System.Collections.IList.Insert(int index, object value);
                bool System.Collections.IList.get_IsFixedSize();
                void System.Collections.IList.Remove(object value);
                object System.Collections.IList.get_Item(int index);
                void System.Collections.IList.set_Item(int index, object value);
                void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                object get_UnderlyingCollection();
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

                /*0xd7c82c*/ TypeInformation(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode);
                /*0xd7c81c*/ System.Type get_Type();
                /*0xd7c824*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
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

                static /*0xd7f888*/ ConvertUtils();
                static /*0xd7c85c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t);
                static /*0xd7c8c4*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, ref bool isEnum);
                static /*0xd7cc14*/ Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable);
                static /*0xd7cd00*/ bool IsConvertible(System.Type t);
                static /*0xd7cd94*/ System.TimeSpan ParseTimeSpan(string input);
                static /*0xd7ce24*/ System.Func<object, object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type> t);
                static /*0xd7d06c*/ System.Numerics.BigInteger ToBigInteger(object value);
                static /*0xd7d3e8*/ object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType);
                static /*0xd7d8f4*/ object Convert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0xd7e568*/ bool TryConvert(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0xd7db74*/ Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, ref object value);
                static /*0xd7e9d0*/ object ConvertOrCast(object initialValue, System.Globalization.CultureInfo culture, System.Type targetType);
                static /*0xd7e7a0*/ object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType);
                static /*0xd7e700*/ bool VersionTryParse(string input, ref System.Version result);
                static /*0xd7e670*/ bool IsInteger(object value);
                static /*0xd7eb5c*/ Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, ref int value);
                static /*0xd7ecc0*/ Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, ref long value);
                static /*0xd7ee18*/ Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, ref decimal value);
                static /*0xd7f770*/ bool TryConvertGuid(string s, ref System.Guid g);
                static /*0xd7f7cc*/ bool TryHexTextToInt(char[] text, int start, int end, ref int value);

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

                    /*0xd7d064*/ <>c__DisplayClass8_0();
                    /*0xd809b4*/ object <CreateCastConverter>b__0(object o);
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
                static short MaxFractionDigits = 7;
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

                static /*0xd80a68*/ DateTimeParser();
                /*0xd80cdc*/ bool Parse(char[] text, int startIndex, int length);
                /*0xd80db4*/ bool ParseDate(int start);
                /*0xd80f98*/ bool ParseTimeAndZoneAndWhitespace(int start);
                /*0xd81148*/ bool ParseTime(ref int start);
                /*0xd81408*/ bool ParseZone(int start);
                /*0xd80fd8*/ bool Parse4Digit(int start, ref int num);
                /*0xd810b4*/ bool Parse2Digit(int start, ref int num);
                /*0xd80f4c*/ bool ParseChar(int start, char ch);
            }

            class DateTimeUtils
            {
                static string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";
                static int DaysPer100Years = 36524;
                static int DaysPer400Years = 146097;
                static int DaysPer4Years = 1461;
                static int DaysPerYear = 365;
                static long TicksPerDay = 864000000000;
                static /*0x0*/ long InitialJavaScriptDateTicks;
                static /*0x8*/ int[] DaysToMonth365;
                static /*0x10*/ int[] DaysToMonth366;

                static /*0xd815d8*/ DateTimeUtils();
                static /*0xd816c4*/ System.TimeSpan GetUtcOffset(System.DateTime d);
                static /*0xd8172c*/ System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind);
                static /*0xd818b0*/ System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone);
                static /*0xd819d8*/ System.DateTime SwitchToLocalTime(System.DateTime value);
                static /*0xd81a50*/ System.DateTime SwitchToUtcTime(System.DateTime value);
                static /*0xd81ac8*/ long ToUniversalTicks(System.DateTime dateTime);
                static /*0xd81b54*/ long ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0xd81c5c*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset);
                static /*0xd81d40*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime);
                static /*0xd81d98*/ long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, bool convertToUtc);
                static /*0xd81cc4*/ long UniversalTicksToJavaScriptTicks(long universalTicks);
                static /*0xd81e30*/ System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks);
                static /*0xd81eb8*/ bool TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0xd822a4*/ bool TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0xd82224*/ System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser);
                static /*0xd82470*/ bool TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0xd828d8*/ bool TryParseDateTime(string s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0xd82ba0*/ bool TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0xd82f9c*/ bool TryParseDateTimeOffset(string s, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0xd83270*/ bool TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, ref long ticks, ref System.TimeSpan offset, ref System.DateTimeKind kind);
                static /*0xd82690*/ bool TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, ref System.DateTime dt);
                static /*0xd827f0*/ bool TryParseDateTimeExact(string text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTime dt);
                static /*0xd82db0*/ bool TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, ref System.DateTimeOffset dt);
                static /*0xd82eec*/ bool TryParseDateTimeOffsetExact(string text, string dateFormatString, System.Globalization.CultureInfo culture, ref System.DateTimeOffset dt);
                static /*0xd833ec*/ bool TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, int startIndex, ref System.TimeSpan offset);
                static /*0xd8355c*/ void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0xd83694*/ int WriteDateTimeString(char[] chars, int start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format);
                static /*0xd83b10*/ int WriteDefaultIsoDate(char[] chars, int start, System.DateTime dt);
                static /*0xd83fa0*/ void CopyIntToCharArray(char[] chars, int start, int value, int digits);
                static /*0xd83998*/ int WriteDateTimeOffset(char[] chars, int start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format);
                static /*0xd84008*/ void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, string formatString, System.Globalization.CultureInfo culture);
                static /*0xd83da8*/ void GetDateValues(System.DateTime td, ref int year, ref int month, ref int day);
            }

            interface IWrappedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                object get_UnderlyingDictionary();
            }

            class DictionaryWrapper<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, Newtonsoft.Json.Utilities.IWrappedDictionary, System.Collections.IDictionary, System.Collections.ICollection
            {
                /*0x0*/ System.Collections.IDictionary _dictionary;
                /*0x0*/ System.Collections.Generic.IDictionary<TKey, TValue> _genericDictionary;
                /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;
                /*0x0*/ object _syncRoot;

                DictionaryWrapper(System.Collections.IDictionary dictionary);
                DictionaryWrapper(System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
                DictionaryWrapper(System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> dictionary);
                System.Collections.Generic.IDictionary<TKey, TValue> get_GenericDictionary();
                void Add(TKey key, TValue value);
                bool ContainsKey(TKey key);
                System.Collections.Generic.ICollection<TKey> get_Keys();
                bool Remove(TKey key);
                bool TryGetValue(TKey key, ref TValue value);
                System.Collections.Generic.ICollection<TValue> get_Values();
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                void Clear();
                bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                int get_Count();
                bool get_IsReadOnly();
                bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void System.Collections.IDictionary.Add(object key, object value);
                object System.Collections.IDictionary.get_Item(object key);
                void System.Collections.IDictionary.set_Item(object key, object value);
                System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                bool System.Collections.IDictionary.Contains(object key);
                bool System.Collections.IDictionary.get_IsFixedSize();
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                void Remove(object key);
                System.Collections.ICollection System.Collections.IDictionary.get_Values();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                object get_UnderlyingDictionary();

                struct DictionaryEnumerator`2<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

                    DictionaryEnumerator`2(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
                    System.Collections.DictionaryEntry get_Entry();
                    object get_Key();
                    object get_Value();
                    object get_Current();
                    bool MoveNext();
                    void Reset();
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.DictionaryEntry, System.Collections.Generic.KeyValuePair<TKey, TValue>> <>9__29_0;

                    static <>c();
                    <>c();
                    System.Collections.Generic.KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(System.Collections.DictionaryEntry de);
                }
            }

            class DynamicProxy<T>
            {
                DynamicProxy();
                System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(T instance);
                bool TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
                bool TryConvert(T instance, System.Dynamic.ConvertBinder binder, ref object result);
                bool TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, object[] args, ref object result);
                bool TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, object[] indexes);
                bool TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder);
                bool TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, object[] indexes, ref object result);
                bool TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, ref object result);
                bool TryInvoke(T instance, System.Dynamic.InvokeBinder binder, object[] args, ref object result);
                bool TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, object[] args, ref object result);
                bool TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, object[] indexes, object value);
                bool TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, object value);
                bool TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, ref object result);
            }

            class DynamicProxyMetaObject<T> : System.Dynamic.DynamicMetaObject
            {
                /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;

                static System.Linq.Expressions.Expression[] get_NoArgs();
                static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args);
                static System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args);
                static System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value);
                static System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder);
                DynamicProxyMetaObject(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy);
                bool IsOverridden(string method);
                System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder);
                System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value);
                System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder);
                System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder);
                System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args);
                System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args);
                System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args);
                System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg);
                System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder);
                System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value);
                System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes);
                System.Dynamic.DynamicMetaObject CallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke);
                System.Dynamic.DynamicMetaObject CallMethodReturnLast(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                System.Dynamic.DynamicMetaObject CallMethodNoResult(string methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback);
                System.Dynamic.BindingRestrictions GetRestrictions();
                System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames();

                class Fallback<T> : System.MulticastDelegate
                {
                    Fallback(object object, nint method);
                    System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion);
                    System.IAsyncResult BeginInvoke(System.Dynamic.DynamicMetaObject errorSuggestion, System.AsyncCallback callback, object object);
                    System.Dynamic.DynamicMetaObject EndInvoke(System.IAsyncResult result);
                }

                class GetBinderAdapter<T> : System.Dynamic.GetMemberBinder
                {
                    GetBinderAdapter(System.Dynamic.InvokeMemberBinder binder);
                    System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
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

                class <>c__DisplayClass5_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    <>c__DisplayClass5_0();
                    System.Dynamic.DynamicMetaObject <BindDeleteMember>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass6_0<T>
                {
                    /*0x0*/ System.Dynamic.ConvertBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    <>c__DisplayClass6_0();
                    System.Dynamic.DynamicMetaObject <BindConvert>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass7_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeMemberBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    <>c__DisplayClass7_0();
                    System.Dynamic.DynamicMetaObject <BindInvokeMember>b__0(System.Dynamic.DynamicMetaObject e);
                    System.Dynamic.DynamicMetaObject <BindInvokeMember>b__1(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ System.Dynamic.CreateInstanceBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    <>c__DisplayClass8_0();
                    System.Dynamic.DynamicMetaObject <BindCreateInstance>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ System.Dynamic.InvokeBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] args;

                    <>c__DisplayClass9_0();
                    System.Dynamic.DynamicMetaObject <BindInvoke>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass10_0<T>
                {
                    /*0x0*/ System.Dynamic.BinaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject arg;

                    <>c__DisplayClass10_0();
                    System.Dynamic.DynamicMetaObject <BindBinaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass11_0<T>
                {
                    /*0x0*/ System.Dynamic.UnaryOperationBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;

                    <>c__DisplayClass11_0();
                    System.Dynamic.DynamicMetaObject <BindUnaryOperation>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass12_0<T>
                {
                    /*0x0*/ System.Dynamic.GetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    <>c__DisplayClass12_0();
                    System.Dynamic.DynamicMetaObject <BindGetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass13_0<T>
                {
                    /*0x0*/ System.Dynamic.SetIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;
                    /*0x0*/ System.Dynamic.DynamicMetaObject value;

                    <>c__DisplayClass13_0();
                    System.Dynamic.DynamicMetaObject <BindSetIndex>b__0(System.Dynamic.DynamicMetaObject e);
                }

                class <>c__DisplayClass14_0<T>
                {
                    /*0x0*/ System.Dynamic.DeleteIndexBinder binder;
                    /*0x0*/ Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this;
                    /*0x0*/ System.Dynamic.DynamicMetaObject[] indexes;

                    <>c__DisplayClass14_0();
                    System.Dynamic.DynamicMetaObject <BindDeleteIndex>b__0(System.Dynamic.DynamicMetaObject e);
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
                static /*0xd8417c*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider);

                class BinderWrapper
                {
                    static string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                    static string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                    static string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                    static string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                    static string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
                    static /*0x0*/ object _getCSharpArgumentInfoArray;
                    static /*0x8*/ object _setCSharpArgumentInfoArray;
                    static /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _getMemberCall;
                    static /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _setMemberCall;
                    static /*0x20*/ bool _init;

                    static /*0xd84264*/ void Init();
                    static /*0xd8444c*/ object CreateSharpArgumentInfoArray(int[] values);
                    static /*0xd8471c*/ void CreateMemberCalls();
                    static /*0xd84bf8*/ System.Runtime.CompilerServices.CallSiteBinder GetMember(string name, System.Type context);
                    static /*0xd84dcc*/ System.Runtime.CompilerServices.CallSiteBinder SetMember(string name, System.Type context);
                }
            }

            class NoThrowGetBinderMember : System.Dynamic.GetMemberBinder
            {
                /*0x28*/ System.Dynamic.GetMemberBinder _innerBinder;

                /*0xd84fa0*/ NoThrowGetBinderMember(System.Dynamic.GetMemberBinder innerBinder);
                /*0xd84fd8*/ System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowSetBinderMember : System.Dynamic.SetMemberBinder
            {
                /*0x28*/ System.Dynamic.SetMemberBinder _innerBinder;

                /*0xd8511c*/ NoThrowSetBinderMember(System.Dynamic.SetMemberBinder innerBinder);
                /*0xd85154*/ System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
            }

            class NoThrowExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
            {
                static /*0x0*/ object ErrorResult;

                static /*0xd8539c*/ NoThrowExpressionVisitor();
                /*0xd85114*/ NoThrowExpressionVisitor();
                /*0xd852a0*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node);
            }

            class EnumInfo
            {
                /*0x10*/ bool IsFlags;
                /*0x18*/ ulong[] Values;
                /*0x20*/ string[] Names;
                /*0x28*/ string[] ResolvedNames;

                /*0xd85414*/ EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames);
            }

            class EnumUtils
            {
                static char EnumSeparatorChar = 44;
                static string EnumSeparatorString = ", ";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy>, Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;
                static /*0x8*/ Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;

                static /*0xd86a98*/ EnumUtils();
                static /*0xd85458*/ Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type, Newtonsoft.Json.Serialization.NamingStrategy> key);
                static System.Collections.Generic.IList<T> GetFlagsValues<T>(T value);
                static /*0xd85c88*/ bool TryToString(System.Type enumType, object value, bool camelCase, ref string name);
                static /*0xd85d28*/ bool TryToString(System.Type enumType, object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, ref string name);
                static /*0xd85ea4*/ string InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, ulong result);
                static /*0xd86040*/ Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType);
                static /*0xd85958*/ ulong ToUInt64(object value);
                static /*0xd860fc*/ object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, string value, bool disallowNumber);
                static /*0xd869b4*/ System.Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, System.StringComparison comparison);
                static /*0xd868bc*/ System.Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, System.StringComparison comparison);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.EnumUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Runtime.Serialization.EnumMemberAttribute, string> <>9__3_0;

                    static /*0xd86bb0*/ <>c();
                    /*0xd86c14*/ <>c();
                    /*0xd86c1c*/ string <InitializeValuesAndNames>b__3_0(System.Runtime.Serialization.EnumMemberAttribute a);
                }

                class <>c__4<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.EnumUtils.<>c__4<T> <>9;
                    static /*0x0*/ System.Func<ulong, bool> <>9__4_0;

                    static <>c__4();
                    <>c__4();
                    bool <GetFlagsValues>b__4_0(ulong v);
                }
            }

            class FSharpFunction
            {
                /*0x10*/ object _instance;
                /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> _invoker;

                /*0xd86c34*/ FSharpFunction(object instance, Newtonsoft.Json.Utilities.MethodCall<object, object> invoker);
                /*0xd86c60*/ object Invoke(object[] args);
            }

            class FSharpUtils
            {
                static string FSharpSetTypeName = "FSharpSet`1";
                static string FSharpListTypeName = "FSharpList`1";
                static string FSharpMapTypeName = "FSharpMap`2";
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

                static /*0xd878e4*/ FSharpUtils();
                static /*0xd873c8*/ Newtonsoft.Json.Utilities.FSharpUtils get_Instance();
                static /*0xd874c0*/ void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly);
                static /*0xd87164*/ System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, System.Reflection.BindingFlags bindingFlags);
                static /*0xd871d8*/ Newtonsoft.Json.Utilities.MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName);
                /*0xd86c8c*/ FSharpUtils(System.Reflection.Assembly fsharpCoreAssembly);
                /*0xd87420*/ System.Reflection.Assembly get_FSharpCoreAssembly();
                /*0xd87428*/ void set_FSharpCoreAssembly(System.Reflection.Assembly value);
                /*0xd87430*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_IsUnion();
                /*0xd87438*/ void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0xd87440*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCases();
                /*0xd87448*/ void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0xd87450*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionTagReader();
                /*0xd87458*/ void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0xd87460*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionReader();
                /*0xd87468*/ void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0xd87470*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_PreComputeUnionConstructor();
                /*0xd87478*/ void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0xd87480*/ System.Func<object, object> get_GetUnionCaseInfoDeclaringType();
                /*0xd87488*/ void set_GetUnionCaseInfoDeclaringType(System.Func<object, object> value);
                /*0xd87490*/ System.Func<object, object> get_GetUnionCaseInfoName();
                /*0xd87498*/ void set_GetUnionCaseInfoName(System.Func<object, object> value);
                /*0xd874a0*/ System.Func<object, object> get_GetUnionCaseInfoTag();
                /*0xd874a8*/ void set_GetUnionCaseInfoTag(System.Func<object, object> value);
                /*0xd874b0*/ Newtonsoft.Json.Utilities.MethodCall<object, object> get_GetUnionCaseInfoFields();
                /*0xd874b8*/ void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<object, object> value);
                /*0xd87640*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateSeq(System.Type t);
                /*0xd8773c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType);
                Newtonsoft.Json.Serialization.ObjectConstructor<object> BuildMapCreator<TKey, TValue>();

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;
                    /*0x18*/ Newtonsoft.Json.Utilities.MethodCall<object, object> invoke;

                    /*0xd87638*/ <>c__DisplayClass52_0();
                    /*0xd8795c*/ object <CreateFSharpFuncCall>b__0(object target, object[] args);
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
                static string ImmutableListGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableList`1";
                static string ImmutableQueueGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableQueue`1";
                static string ImmutableStackGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableStack`1";
                static string ImmutableSetGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableSet`1";
                static string ImmutableArrayTypeName = "System.Collections.Immutable.ImmutableArray";
                static string ImmutableArrayGenericTypeName = "System.Collections.Immutable.ImmutableArray`1";
                static string ImmutableListTypeName = "System.Collections.Immutable.ImmutableList";
                static string ImmutableListGenericTypeName = "System.Collections.Immutable.ImmutableList`1";
                static string ImmutableQueueTypeName = "System.Collections.Immutable.ImmutableQueue";
                static string ImmutableQueueGenericTypeName = "System.Collections.Immutable.ImmutableQueue`1";
                static string ImmutableStackTypeName = "System.Collections.Immutable.ImmutableStack";
                static string ImmutableStackGenericTypeName = "System.Collections.Immutable.ImmutableStack`1";
                static string ImmutableSortedSetTypeName = "System.Collections.Immutable.ImmutableSortedSet";
                static string ImmutableSortedSetGenericTypeName = "System.Collections.Immutable.ImmutableSortedSet`1";
                static string ImmutableHashSetTypeName = "System.Collections.Immutable.ImmutableHashSet";
                static string ImmutableHashSetGenericTypeName = "System.Collections.Immutable.ImmutableHashSet`1";
                static string ImmutableDictionaryGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableDictionary`2";
                static string ImmutableDictionaryTypeName = "System.Collections.Immutable.ImmutableDictionary";
                static string ImmutableDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableDictionary`2";
                static string ImmutableSortedDictionaryTypeName = "System.Collections.Immutable.ImmutableSortedDictionary";
                static string ImmutableSortedDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableSortedDictionary`2";
                static /*0x0*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;
                static /*0x8*/ System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

                static /*0xd882e0*/ ImmutableCollectionsUtils();
                static /*0xd879fc*/ bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);
                static /*0xd87e44*/ bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, ref System.Type createdType, ref Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator);

                class ImmutableCollectionTypeInfo
                {
                    /*0x10*/ string <ContractTypeName>k__BackingField;
                    /*0x18*/ string <CreatedTypeName>k__BackingField;
                    /*0x20*/ string <BuilderTypeName>k__BackingField;

                    /*0xd88c10*/ ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName);
                    /*0xd88c4c*/ string get_ContractTypeName();
                    /*0xd88c54*/ void set_ContractTypeName(string value);
                    /*0xd88c5c*/ string get_CreatedTypeName();
                    /*0xd88c64*/ void set_CreatedTypeName(string value);
                    /*0xd88c6c*/ string get_BuilderTypeName();
                    /*0xd88c74*/ void set_BuilderTypeName(string value);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string name;

                    /*0xd87e3c*/ <>c__DisplayClass24_0();
                    /*0xd88c7c*/ bool <TryBuildImmutableForArrayContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__24_1;
                    static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__25_1;

                    static /*0xd88ca0*/ <>c();
                    /*0xd88d04*/ <>c();
                    /*0xd88d0c*/ bool <TryBuildImmutableForArrayContract>b__24_1(System.Reflection.MethodInfo m);
                    /*0xd88da0*/ bool <TryBuildImmutableForDictionaryContract>b__25_1(System.Reflection.MethodInfo m);
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ string name;

                    /*0xd882d8*/ <>c__DisplayClass25_0();
                    /*0xd88ef0*/ bool <TryBuildImmutableForDictionaryContract>b__0(Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d);
                }
            }

            class BufferUtils
            {
                static /*0xd88f14*/ char[] RentBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int minSize);
                static /*0xd88fdc*/ void ReturnBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer);
                static /*0xd8908c*/ char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int size, char[] buffer);
            }

            class JavaScriptUtils
            {
                static int UnicodeTextLength = 6;
                static string EscapedUnicodeText = "!";
                static /*0x0*/ bool[] SingleQuoteCharEscapeFlags;
                static /*0x8*/ bool[] DoubleQuoteCharEscapeFlags;
                static /*0x10*/ bool[] HtmlCharEscapeFlags;

                static /*0xd891c8*/ JavaScriptUtils();
                static /*0xd89e34*/ bool[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, char quoteChar);
                static /*0xd89ecc*/ bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags);
                static /*0xd89f54*/ void WriteEscapedJavaScriptString(System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<char> bufferPool, ref char[] writeBuffer);
                static /*0xd8a5ec*/ string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0xd8a538*/ int FirstCharToEscape(string s, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling);
                static /*0xd8a81c*/ System.Threading.Tasks.Task WriteEscapedJavaScriptStringAsync(System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, System.Threading.CancellationToken cancellationToken);
                static /*0xd8a9a8*/ System.Threading.Tasks.Task WriteEscapedJavaScriptStringWithDelimitersAsync(System.IO.TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, System.Threading.CancellationToken cancellationToken);
                static /*0xd8acc4*/ System.Threading.Tasks.Task WriteEscapedJavaScriptStringWithDelimitersAsync(System.Threading.Tasks.Task task, System.IO.TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, System.Threading.CancellationToken cancellationToken);
                static /*0xd8adf4*/ System.Threading.Tasks.Task WriteCharAsync(System.Threading.Tasks.Task task, System.IO.TextWriter writer, char c, System.Threading.CancellationToken cancellationToken);
                static /*0xd8aba0*/ System.Threading.Tasks.Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(System.IO.TextWriter writer, string s, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, System.Threading.CancellationToken cancellationToken);
                static /*0xd8aee8*/ System.Threading.Tasks.Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(System.IO.TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, System.Threading.CancellationToken cancellationToken);
                static /*0xd8b010*/ bool TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, ref System.DateTime dateTime, ref string errorMessage);
                static /*0xd8b4c0*/ bool TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, ref System.Nullable<long> integer, ref string errorMessage);

                struct <WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.Tasks.Task task;
                    /*0x38*/ string s;
                    /*0x40*/ System.IO.TextWriter writer;
                    /*0x48*/ bool[] charEscapeFlags;
                    /*0x50*/ Newtonsoft.Json.StringEscapeHandling stringEscapeHandling;
                    /*0x58*/ Newtonsoft.Json.JsonTextWriter client;
                    /*0x60*/ char[] writeBuffer;
                    /*0x68*/ System.Threading.CancellationToken cancellationToken;
                    /*0x70*/ char delimiter;
                    /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xd8b67c*/ void MoveNext();
                    /*0xd8b9b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WriteCharAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.Tasks.Task task;
                    /*0x38*/ System.IO.TextWriter writer;
                    /*0x40*/ char c;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xd8b9c4*/ void MoveNext();
                    /*0xd8bc14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ char[] writeBuffer;
                    /*0x38*/ int lastWritePosition;
                    /*0x40*/ Newtonsoft.Json.JsonTextWriter client;
                    /*0x48*/ string s;
                    /*0x50*/ System.IO.TextWriter writer;
                    /*0x58*/ System.Threading.CancellationToken cancellationToken;
                    /*0x60*/ bool[] charEscapeFlags;
                    /*0x68*/ Newtonsoft.Json.StringEscapeHandling stringEscapeHandling;
                    /*0x6c*/ bool <isEscapedUnicodeText>5__2;
                    /*0x70*/ string <escapedValue>5__3;
                    /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x88*/ int <i>5__4;

                    /*0xd8bc20*/ void MoveNext();
                    /*0xd8c52c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class JsonTokenUtils
            {
                static /*0xd8c538*/ bool IsEndToken(Newtonsoft.Json.JsonToken token);
                static /*0xd8c548*/ bool IsStartToken(Newtonsoft.Json.JsonToken token);
                static /*0xd8c558*/ bool IsPrimitiveToken(Newtonsoft.Json.JsonToken token);
            }

            class LateBoundReflectionDelegateFactory : Newtonsoft.Json.Utilities.ReflectionDelegateFactory
            {
                static /*0x0*/ Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

                static /*0xd8c740*/ LateBoundReflectionDelegateFactory();
                static /*0xd8c57c*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance();
                /*0xd8c730*/ LateBoundReflectionDelegateFactory();
                /*0xd8c5d4*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(System.Reflection.MethodBase method);
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

                    /*0xd8c728*/ <>c__DisplayClass3_0();
                    /*0xd8c7a4*/ object <CreateParameterizedConstructor>b__0(object[] a);
                    /*0xd8c7c0*/ object <CreateParameterizedConstructor>b__1(object[] a);
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
                static /*0xd8c7e4*/ int IntLength(ulong i);
                static /*0xd8c9a8*/ char IntToHex(int n);
                static /*0xd8c9c0*/ System.Nullable<int> Min(System.Nullable<int> val1, System.Nullable<int> val2);
                static /*0xd8caa0*/ System.Nullable<int> Max(System.Nullable<int> val1, System.Nullable<int> val2);
                static /*0xd8cb80*/ System.Nullable<double> Max(System.Nullable<double> val1, System.Nullable<double> val2);
                static /*0xd8cc7c*/ bool ApproxEquals(double d1, double d2);
            }

            class MethodCall<T, TResult> : System.MulticastDelegate
            {
                MethodCall(object object, nint method);
                TResult Invoke(T target, object[] args);
                System.IAsyncResult BeginInvoke(T target, object[] args, System.AsyncCallback callback, object object);
                TResult EndInvoke(System.IAsyncResult result);
            }

            class Creator<T> : System.MulticastDelegate
            {
                Creator(object object, nint method);
                T Invoke();
                System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                T EndInvoke(System.IAsyncResult result);
            }

            class MiscellaneousUtils
            {
                static /*0xd8cd24*/ void Assert(bool condition, string message);
                static /*0xd8cd28*/ bool ValueEquals(object objA, object objB);
                static /*0xd817ac*/ System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message);
                static /*0xd8d018*/ string ToString(object value);
                static /*0xd8d0c8*/ int ByteArrayCompare(byte[] a1, byte[] a2);
                static /*0xd8d17c*/ string GetPrefix(string qualifiedName);
                static /*0xd8d234*/ string GetLocalName(string qualifiedName);
                static /*0xd8d1a0*/ void GetQualifiedNameParts(string qualifiedName, ref string prefix, ref string localName);
                static /*0xd8d258*/ System.Text.RegularExpressions.RegexOptions GetRegexOptions(string optionsText);
            }

            class ReflectionDelegateFactory
            {
                /*0xd8c738*/ ReflectionDelegateFactory();
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

                /*0xd8d330*/ ReflectionMember();
                /*0xd8d300*/ System.Type get_MemberType();
                /*0xd8d308*/ void set_MemberType(System.Type value);
                /*0xd8d310*/ System.Func<object, object> get_Getter();
                /*0xd8d318*/ void set_Getter(System.Func<object, object> value);
                /*0xd8d320*/ System.Action<object, object> get_Setter();
                /*0xd8d328*/ void set_Setter(System.Action<object, object> value);
            }

            class ReflectionObject
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <Creator>k__BackingField;
                /*0x18*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;

                static /*0xd8d638*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, string[] memberNames);
                static /*0xd8d644*/ Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, string[] memberNames);
                /*0xd8d348*/ ReflectionObject(Newtonsoft.Json.Serialization.ObjectConstructor<object> creator);
                /*0xd8d338*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_Creator();
                /*0xd8d340*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Utilities.ReflectionMember> get_Members();
                /*0xd8d3d4*/ object GetValue(object target, string member);
                /*0xd8d4a8*/ void SetValue(object target, string member, object value);
                /*0xd8d584*/ System.Type GetType(string member);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ System.Func<object> ctor;

                    /*0xd8df5c*/ <>c__DisplayClass11_0();
                    /*0xd8e520*/ object <Create>b__0(object[] args);
                }

                class <>c__DisplayClass11_1
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0xd8e240*/ <>c__DisplayClass11_1();
                    /*0xd8e544*/ object <Create>b__1(object target);
                }

                class <>c__DisplayClass11_2
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> call;

                    /*0xd8e248*/ <>c__DisplayClass11_2();
                    /*0xd8e5ec*/ void <Create>b__2(object target, object arg);
                }
            }

            class ReflectionUtils
            {
                static /*0x0*/ System.Type[] EmptyTypes;

                static /*0xd8e6a4*/ ReflectionUtils();
                static /*0xd8e71c*/ bool IsVirtual(System.Reflection.PropertyInfo propertyInfo);
                static /*0xd8e800*/ System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo);
                static /*0xd8e8c8*/ bool IsPublic(System.Reflection.PropertyInfo property);
                static /*0xd7eb4c*/ System.Type GetObjectType(object v);
                static /*0xd8e958*/ string GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0xd8ea38*/ string GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder);
                static /*0xd8eb68*/ string RemoveAssemblyDetails(string fullyQualifiedTypeName);
                static /*0xd8de74*/ bool HasDefaultConstructor(System.Type t, bool nonPublic);
                static /*0xd8edbc*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t);
                static /*0xd8ec8c*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic);
                static /*0xd7e708*/ bool IsNullable(System.Type t);
                static /*0xd7cb2c*/ bool IsNullableType(System.Type t);
                static /*0xd8ee14*/ System.Type EnsureNotNullableType(System.Type t);
                static /*0xd8ee88*/ System.Type EnsureNotByRefType(System.Type t);
                static /*0xd8eed8*/ bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0xd7bae8*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition);
                static /*0xd8ef7c*/ bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, ref System.Type implementingType);
                static /*0xd8f1ec*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition);
                static /*0xd8f260*/ bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0xd8f3b8*/ bool InheritsGenericDefinitionInternal(System.Type currentType, System.Type genericClassDefinition, ref System.Type implementingType);
                static /*0xd8f4ac*/ System.Type GetCollectionItemType(System.Type type);
                static /*0xd8f6d4*/ void GetDictionaryKeyValueTypes(System.Type dictionaryType, ref System.Type keyType, ref System.Type valueType);
                static /*0xd8e250*/ System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member);
                static /*0xd8f900*/ bool IsByRefLikeType(System.Type type);
                static /*0xd8ff18*/ bool IsIndexedProperty(System.Reflection.PropertyInfo property);
                static /*0xd8ff94*/ object GetMemberValue(System.Reflection.MemberInfo member, object target);
                static /*0xd90318*/ void SetMemberValue(System.Reflection.MemberInfo member, object target, object value);
                static /*0xd8df64*/ bool CanReadMemberValue(System.Reflection.MemberInfo member, bool nonPublic);
                static /*0xd8e0b8*/ bool CanSetMemberValue(System.Reflection.MemberInfo member, bool nonPublic, bool canSetReadOnly);
                static /*0xd90560*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr);
                static /*0xd91418*/ bool IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr);
                static T GetAttribute<T>(object attributeProvider);
                static T GetAttribute<T>(object attributeProvider, bool inherit);
                static T[] GetAttributes<T>(object attributeProvider, bool inherit);
                static /*0xd8fa04*/ System.Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit);
                static /*0xd915e8*/ Newtonsoft.Json.Utilities.StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName);
                static /*0xd916e4*/ System.Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName);
                static /*0xd917bc*/ System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo);
                static /*0xd90ff8*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0xd91a24*/ void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0xd91118*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0xd91c08*/ System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag);
                static /*0xd91c18*/ void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type targetType, System.Reflection.BindingFlags bindingAttr);
                static /*0xd9217c*/ bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method);
                static /*0xd92278*/ object GetDefaultValue(System.Type type);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__11_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__31_0;
                    static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__39_0;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, bool> <>9__41_0;

                    static /*0x8f8f98*/ <>c();
                    /*0x8f8ffc*/ <>c();
                    /*0x8f9004*/ bool <GetDefaultConstructor>b__11_0(System.Reflection.ConstructorInfo c);
                    /*0x8f9070*/ string <GetFieldsAndProperties>b__31_0(System.Reflection.MemberInfo m);
                    /*0x8f9090*/ System.Type <GetMemberInfoFromType>b__39_0(System.Reflection.ParameterInfo p);
                    /*0x8f90b0*/ bool <GetChildPrivateFields>b__41_0(System.Reflection.FieldInfo f);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Reflection.MemberInfo memberInfo;

                    /*0x8f90c8*/ <>c__DisplayClass31_0();
                    /*0x8f90d0*/ bool <GetFieldsAndProperties>b__1(System.Reflection.MemberInfo m);
                }

                class <>c__DisplayClass44_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo subTypeProperty;

                    /*0x8f916c*/ <>c__DisplayClass44_0();
                    /*0x8f9174*/ bool <GetChildPrivateProperties>b__0(System.Reflection.PropertyInfo p);
                    /*0x8f91c8*/ bool <GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass44_1
                {
                    /*0x10*/ System.Type subTypePropertyDeclaringType;
                    /*0x18*/ Newtonsoft.Json.Utilities.ReflectionUtils.<> CS$<>8__locals1;

                    /*0x8f92b4*/ <>c__DisplayClass44_1();
                    /*0x8f92bc*/ bool <GetChildPrivateProperties>b__2(System.Reflection.PropertyInfo p);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ string method;
                    /*0x18*/ System.Type methodDeclaringType;

                    /*0x8f93d0*/ <>c__DisplayClass45_0();
                    /*0x8f93d8*/ bool <IsMethodOverridden>b__0(System.Reflection.MethodInfo info);
                }
            }

            struct StringBuffer
            {
                /*0x10*/ char[] _buffer;
                /*0x18*/ int _position;

                /*0x8f950c*/ StringBuffer(Newtonsoft.Json.IArrayPool<char> bufferPool, int initalSize);
                /*0x8f9534*/ StringBuffer(char[] buffer);
                /*0x8f94ec*/ int get_Position();
                /*0x8f94f4*/ void set_Position(int value);
                /*0x8f94fc*/ bool get_IsEmpty();
                /*0x8f9540*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char value);
                /*0x8f9620*/ void Append(Newtonsoft.Json.IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count);
                /*0x8f96a0*/ void Clear(Newtonsoft.Json.IArrayPool<char> bufferPool);
                /*0x8f95b8*/ void EnsureSize(Newtonsoft.Json.IArrayPool<char> bufferPool, int appendLength);
                /*0x8f96d0*/ string ToString();
                /*0x8f96e8*/ string ToString(int start, int length);
                /*0x8f9704*/ char[] get_InternalBuffer();
            }

            struct StringReference
            {
                /*0x10*/ char[] _chars;
                /*0x18*/ int _startIndex;
                /*0x1c*/ int _length;

                /*0x8f9754*/ StringReference(char[] chars, int startIndex, int length);
                /*0x8f970c*/ char get_Item(int i);
                /*0x8f973c*/ char[] get_Chars();
                /*0x8f9744*/ int get_StartIndex();
                /*0x8f974c*/ int get_Length();
                /*0x8f9760*/ string ToString();
            }

            class StringReferenceExtensions
            {
                static /*0x8f9774*/ int IndexOf(Newtonsoft.Json.Utilities.StringReference s, char c, int startIndex, int length);
                static /*0x8f97f8*/ bool StartsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
                static /*0x8f98ac*/ bool EndsWith(Newtonsoft.Json.Utilities.StringReference s, string text);
            }

            class StringUtils
            {
                static string CarriageReturnLineFeed = "
";
                static string Empty = "";
                static char CarriageReturn = 13;
                static char LineFeed = 10;
                static char Tab = 9;

                static /*0x8f9964*/ bool IsNullOrEmpty(string value);
                static /*0x8f996c*/ string FormatWith(string format, System.IFormatProvider provider, object arg0);
                static /*0x8f9a80*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1);
                static /*0x8f9b5c*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2);
                static /*0x8f9c64*/ string FormatWith(string format, System.IFormatProvider provider, object arg0, object arg1, object arg2, object arg3);
                static /*0x8f9a14*/ string FormatWith(string format, System.IFormatProvider provider, object[] args);
                static /*0x8f9df4*/ bool IsWhiteSpace(string s);
                static /*0x8f9ef4*/ System.IO.StringWriter CreateStringWriter(int capacity);
                static /*0x8f9fc8*/ void ToCharAsUnicode(char c, char[] buffer);
                static TSource ForgivingCaseSensitiveFind<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, string> valueSelector, string testValue);
                static /*0x8fa084*/ string ToCamelCase(string s);
                static /*0x8fa26c*/ char ToLower(char c);
                static /*0x8fa2fc*/ string ToSnakeCase(string s);
                static /*0x8fa5c4*/ string ToKebabCase(string s);
                static /*0x8fa304*/ string ToSeparatedCase(string s, char separator);
                static /*0x8fa5cc*/ bool IsHighSurrogate(char c);
                static /*0x8fa624*/ bool IsLowSurrogate(char c);
                static /*0x8fa67c*/ bool StartsWith(string source, char value);
                static /*0x8fa6c0*/ bool EndsWith(string source, char value);
                static /*0x8fa700*/ string Trim(string s, int start, int length);

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
                static /*0x8fa8c4*/ System.Reflection.MethodInfo Method(System.Delegate d);
                static /*0x8fa8d8*/ System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo);
                static /*0x8fa8f4*/ bool ContainsGenericParameters(System.Type type);
                static /*0x8fa914*/ bool IsInterface(System.Type type);
                static /*0x8fa928*/ bool IsGenericType(System.Type type);
                static /*0x8fa948*/ bool IsGenericTypeDefinition(System.Type type);
                static /*0x8fa968*/ System.Type BaseType(System.Type type);
                static /*0x8fa988*/ System.Reflection.Assembly Assembly(System.Type type);
                static /*0x8fa9a8*/ bool IsEnum(System.Type type);
                static /*0x8fa9c8*/ bool IsClass(System.Type type);
                static /*0x8fa9dc*/ bool IsSealed(System.Type type);
                static /*0x8fa9f0*/ bool IsAbstract(System.Type type);
                static /*0x8faa04*/ bool IsVisible(System.Type type);
                static /*0x8faa18*/ bool IsValueType(System.Type type);
                static /*0x8faa2c*/ bool IsPrimitive(System.Type type);
                static /*0x8faa40*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces, ref System.Type match);
                static /*0x8fabb0*/ bool AssignableToTypeName(System.Type type, string fullTypeName, bool searchInterfaces);
                static /*0x8fabd0*/ bool ImplementInterface(System.Type type, System.Type interfaceType);
            }

            class ValidationUtils
            {
                static /*0x8f9da0*/ void ArgumentNotNull(object value, string parameterName);
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
                /*0x8fafc0*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0x8faff8*/ CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0x8fb044*/ CamelCaseNamingStrategy();
                /*0x8fb04c*/ string ResolvePropertyName(string name);
            }

            class CamelCasePropertyNamesContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
            {
                static /*0x0*/ object TypeContractCacheLock;
                static /*0x8*/ Newtonsoft.Json.DefaultJsonNameTable NameTable;
                static /*0x10*/ System.Collections.Generic.Dictionary<Newtonsoft.Json.Utilities.StructMultiKey<System.Type, System.Type>, Newtonsoft.Json.Serialization.JsonContract> _contractCache;

                static /*0x8fb578*/ CamelCasePropertyNamesContractResolver();
                /*0x8fb054*/ CamelCasePropertyNamesContractResolver();
                /*0x8fb1e8*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
                /*0x8fb520*/ Newtonsoft.Json.DefaultJsonNameTable GetNameTable();
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

                static /*0x904ec0*/ DefaultContractResolver();
                static /*0x8fb628*/ Newtonsoft.Json.Serialization.IContractResolver get_Instance();
                static /*0x8fb7d4*/ bool FilterMembers(System.Reflection.MemberInfo member);
                static /*0x8fe3dc*/ void ThrowUnableToSerializeError(object o, System.Runtime.Serialization.StreamingContext context);
                static /*0x8fd9e8*/ void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member);
                static /*0x901124*/ bool IsConcurrentOrObservableCollection(System.Type t);
                static /*0x9008a4*/ bool ShouldSkipDeserialized(System.Type t);
                static /*0x9007d0*/ bool ShouldSkipSerializing(System.Type t);
                static /*0x903e64*/ bool IsJsonPrimitiveType(System.Type t);
                static /*0x903fe0*/ bool IsIConvertible(System.Type t);
                static /*0x903ec8*/ bool CanConvertToString(System.Type type);
                static /*0x900978*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                static /*0x90415c*/ string GetClrTypeFullName(System.Type type);
                /*0x8fb0ec*/ DefaultContractResolver();
                /*0x8fb680*/ bool get_DynamicCodeGeneration();
                /*0x8fb6d0*/ System.Reflection.BindingFlags get_DefaultMembersSearchFlags();
                /*0x8fb6d8*/ void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value);
                /*0x8fb6e0*/ bool get_SerializeCompilerGeneratedMembers();
                /*0x8fb6e8*/ void set_SerializeCompilerGeneratedMembers(bool value);
                /*0x8fb6f4*/ bool get_IgnoreSerializableInterface();
                /*0x8fb6fc*/ void set_IgnoreSerializableInterface(bool value);
                /*0x8fb708*/ bool get_IgnoreSerializableAttribute();
                /*0x8fb710*/ void set_IgnoreSerializableAttribute(bool value);
                /*0x8fb71c*/ bool get_IgnoreIsSpecifiedMembers();
                /*0x8fb724*/ void set_IgnoreIsSpecifiedMembers(bool value);
                /*0x8fb730*/ bool get_IgnoreShouldSerializeMembers();
                /*0x8fb738*/ void set_IgnoreShouldSerializeMembers(bool value);
                /*0x8fb744*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0x8fb74c*/ void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value);
                /*0x8fb754*/ Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
                /*0x8fb91c*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType);
                /*0x8fc634*/ bool ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo);
                /*0x8fc73c*/ Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType);
                /*0x8fd820*/ System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type);
                /*0x8fcfcc*/ System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType);
                /*0x8fd56c*/ System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x8fd524*/ System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType);
                /*0x8fea18*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties);
                /*0x8fe974*/ Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, string name, System.Type type);
                /*0x8fefe4*/ Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo);
                /*0x8ffa0c*/ Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType);
                /*0x8ffa64*/ System.Func<object> GetDefaultCreator(System.Type createdType);
                /*0x8fcd7c*/ void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x8ffb10*/ void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t);
                /*0x8ffc3c*/ void GetCallbackMethodsForType(System.Type type, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onSerialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserializing, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> onDeserialized, ref System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> onError);
                /*0x8fe478*/ System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type);
                /*0x90126c*/ Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType);
                /*0x902164*/ Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType);
                /*0x9031cc*/ Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType);
                /*0x903338*/ Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType);
                /*0x9033d4*/ Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType);
                /*0x903618*/ Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType);
                /*0x9039d8*/ Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType);
                /*0x903a54*/ Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType);
                /*0x904268*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x904684*/ Newtonsoft.Json.DefaultJsonNameTable GetNameTable();
                /*0x90468c*/ Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member);
                /*0x9046f0*/ Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization);
                /*0x8ff2f8*/ void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, object attributeProvider, string name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, ref bool allowNonPublicAccess);
                /*0x9048e4*/ System.Predicate<object> CreateShouldSerializeTest(System.Reflection.MemberInfo member);
                /*0x904b48*/ void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, bool allowNonPublicAccess);
                /*0x904e48*/ string ResolvePropertyName(string propertyName);
                /*0x904e68*/ string ResolveExtensionDataName(string extensionDataName);
                /*0x904e84*/ string ResolveDictionaryKey(string dictionaryKey);
                /*0x904eb0*/ string GetResolvedPropertyName(string propertyName);

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

                    static /*0x905374*/ <>c();
                    /*0x9053d8*/ <>c();
                    /*0x9053e0*/ bool <GetSerializableMembers>b__40_0(System.Reflection.MemberInfo m);
                    /*0x905494*/ bool <GetSerializableMembers>b__40_1(System.Reflection.MemberInfo m);
                    /*0x905504*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(System.Type baseType);
                    /*0x9055e0*/ bool <GetExtensionDataMemberForType>b__44_1(System.Reflection.MemberInfo m);
                    /*0x9059bc*/ bool <GetAttributeConstructor>b__47_0(System.Reflection.ConstructorInfo c);
                    /*0x905a54*/ int <CreateProperties>b__75_0(Newtonsoft.Json.Serialization.JsonProperty p);
                }

                class <>c__DisplayClass42_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x8fcfc4*/ <>c__DisplayClass42_0();
                    /*0x905aac*/ string <CreateObjectContract>b__0(string s);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ System.Func<object, object> getExtensionDataDictionary;
                    /*0x18*/ System.Reflection.MemberInfo member;

                    /*0x8fe62c*/ <>c__DisplayClass45_0();
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ System.Action<object, object> setExtensionDataDictionary;
                    /*0x18*/ System.Func<object> createExtensionDataDictionary;
                    /*0x20*/ Newtonsoft.Json.Utilities.MethodCall<object, object> setExtensionDataDictionaryValue;
                    /*0x28*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals1;

                    /*0x8fe634*/ <>c__DisplayClass45_1();
                    /*0x905acc*/ void <SetExtensionDataDelegates>b__0(object o, string key, object value);
                }

                class <>c__DisplayClass45_2
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> createEnumerableWrapper;
                    /*0x18*/ Newtonsoft.Json.Serialization.DefaultContractResolver.<> CS$<>8__locals2;

                    /*0x8fe76c*/ <>c__DisplayClass45_2();
                    /*0x905cc4*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o);
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x90215c*/ <>c__DisplayClass62_0();
                    /*0x905dd0*/ string <CreateDictionaryContract>b__0(string s);
                }

                class <>c__DisplayClass67_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;

                    /*0x9039d0*/ <>c__DisplayClass67_0();
                    /*0x905df0*/ string <CreateDynamicContract>b__0(string s);
                }

                class <>c__DisplayClass80_0
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.MethodCall<object, object> shouldSerializeCall;

                    /*0x904e38*/ <>c__DisplayClass80_0();
                    /*0x905e10*/ bool <CreateShouldSerializeTest>b__0(object o);
                }

                class <>c__DisplayClass81_0
                {
                    /*0x10*/ System.Func<object, object> specifiedPropertyGet;

                    /*0x904e40*/ <>c__DisplayClass81_0();
                    /*0x905ef8*/ bool <SetIsSpecifiedActions>b__0(object o);
                }
            }

            class DefaultNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0x905f8c*/ DefaultNamingStrategy();
                /*0x905f84*/ string ResolvePropertyName(string name);
            }

            class DefaultReferenceResolver : Newtonsoft.Json.Serialization.IReferenceResolver
            {
                /*0x10*/ int _referenceCount;

                /*0x9063fc*/ DefaultReferenceResolver();
                /*0x905f94*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> GetMappings(object context);
                /*0x9061b4*/ object ResolveReference(object context, string reference);
                /*0x906228*/ string GetReference(object context, object value);
                /*0x90631c*/ void AddReference(object context, string reference, object value);
                /*0x906388*/ bool IsReferenced(object context, object value);
            }

            class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder, Newtonsoft.Json.Serialization.ISerializationBinder
            {
                static /*0x0*/ Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
                /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<string, string>, System.Type> _typeCache;

                static /*0x906cdc*/ DefaultSerializationBinder();
                /*0x906404*/ DefaultSerializationBinder();
                /*0x9064d0*/ System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x9068d0*/ System.Type GetGenericTypeFromTypeName(string typeName, System.Reflection.Assembly assembly);
                /*0x906b90*/ System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey);
                /*0x906bf8*/ System.Type BindToType(string assemblyName, string typeName);
                /*0x906c74*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            class DiagnosticsTraceWriter : Newtonsoft.Json.Serialization.ITraceWriter
            {
                /*0x10*/ System.Diagnostics.TraceLevel <LevelFilter>k__BackingField;

                /*0x90724c*/ DiagnosticsTraceWriter();
                /*0x906d3c*/ System.Diagnostics.TraceLevel get_LevelFilter();
                /*0x906d44*/ void set_LevelFilter(System.Diagnostics.TraceLevel value);
                /*0x906d4c*/ System.Diagnostics.TraceEventType GetTraceEventType(System.Diagnostics.TraceLevel level);
                /*0x906dbc*/ void Trace(System.Diagnostics.TraceLevel level, string message, System.Exception ex);
            }

            class ErrorContext
            {
                /*0x10*/ bool <Traced>k__BackingField;
                /*0x18*/ System.Exception <Error>k__BackingField;
                /*0x20*/ object <OriginalObject>k__BackingField;
                /*0x28*/ object <Member>k__BackingField;
                /*0x30*/ string <Path>k__BackingField;
                /*0x38*/ bool <Handled>k__BackingField;

                /*0x907254*/ ErrorContext(object originalObject, object member, string path, System.Exception error);
                /*0x907294*/ bool get_Traced();
                /*0x90729c*/ void set_Traced(bool value);
                /*0x9072a8*/ System.Exception get_Error();
                /*0x9072b0*/ object get_OriginalObject();
                /*0x9072b8*/ object get_Member();
                /*0x9072c0*/ string get_Path();
                /*0x9072c8*/ bool get_Handled();
                /*0x9072d0*/ void set_Handled(bool value);
            }

            class ErrorEventArgs : System.EventArgs
            {
                /*0x10*/ object <CurrentObject>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;

                /*0x9072ec*/ ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext);
                /*0x9072dc*/ object get_CurrentObject();
                /*0x9072e4*/ Newtonsoft.Json.Serialization.ErrorContext get_ErrorContext();
            }

            interface IAttributeProvider
            {
                System.Collections.Generic.IList<System.Attribute> GetAttributes(bool inherit);
                System.Collections.Generic.IList<System.Attribute> GetAttributes(System.Type attributeType, bool inherit);
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

                /*0x9024a0*/ JsonArrayContract(System.Type underlyingType);
                /*0x90735c*/ System.Type get_CollectionItemType();
                /*0x907364*/ bool get_IsMultidimensionalArray();
                /*0x90736c*/ bool get_IsArray();
                /*0x907374*/ bool get_ShouldCreateWrapper();
                /*0x90737c*/ bool get_CanDeserialize();
                /*0x907384*/ void set_CanDeserialize(bool value);
                /*0x907390*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x907450*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x9031bc*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x907458*/ bool get_HasParameterizedCreator();
                /*0x907460*/ void set_HasParameterizedCreator(bool value);
                /*0x90746c*/ bool get_HasParameterizedCreatorInternal();
                /*0x9077c0*/ Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(object list);
                /*0x907b8c*/ System.Collections.IList CreateTemporaryCollection();
                /*0x9076ac*/ void StoreFSharpListCreatorIfNecessary(System.Type underlyingType);
            }

            class JsonContainerContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x90*/ Newtonsoft.Json.Serialization.JsonContract _itemContract;
                /*0x98*/ Newtonsoft.Json.Serialization.JsonContract _finalItemContract;
                /*0xa0*/ Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;
                /*0xa8*/ System.Nullable<bool> <ItemIsReference>k__BackingField;
                /*0xac*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;
                /*0xb4*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;

                /*0x9074ec*/ JsonContainerContract(System.Type underlyingType);
                /*0x907ddc*/ Newtonsoft.Json.Serialization.JsonContract get_ItemContract();
                /*0x907de4*/ void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x907e28*/ Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract();
                /*0x907e30*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x907e38*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x907e40*/ System.Nullable<bool> get_ItemIsReference();
                /*0x907e48*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x907e50*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x907e58*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x907e60*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x907e68*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
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
                /*0x8fe2ac*/ SerializationCallback(object object, nint method);
                /*0x907fcc*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x907fe0*/ System.IAsyncResult BeginInvoke(object o, System.Runtime.Serialization.StreamingContext context, System.AsyncCallback callback, object object);
                /*0x908074*/ void EndInvoke(System.IAsyncResult result);
            }

            class SerializationErrorCallback : System.MulticastDelegate
            {
                /*0x908080*/ SerializationErrorCallback(object object, nint method);
                /*0x9081b0*/ void Invoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);
                /*0x9081c4*/ System.IAsyncResult BeginInvoke(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext, System.AsyncCallback callback, object object);
                /*0x90825c*/ void EndInvoke(System.IAsyncResult result);
            }

            class ExtensionDataSetter : System.MulticastDelegate
            {
                /*0x8fe63c*/ ExtensionDataSetter(object object, nint method);
                /*0x908268*/ void Invoke(object o, string key, object value);
                /*0x90827c*/ System.IAsyncResult BeginInvoke(object o, string key, object value, System.AsyncCallback callback, object object);
                /*0x9082a8*/ void EndInvoke(System.IAsyncResult result);
            }

            class ExtensionDataGetter : System.MulticastDelegate
            {
                /*0x8fe774*/ ExtensionDataGetter(object object, nint method);
                /*0x9082b4*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> Invoke(object o);
                /*0x9082c8*/ System.IAsyncResult BeginInvoke(object o, System.AsyncCallback callback, object object);
                /*0x9082e8*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EndInvoke(System.IAsyncResult result);
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

                static /*0x900fd4*/ Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo);
                static /*0x90107c*/ Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo);
                /*0x907e70*/ JsonContract(System.Type underlyingType);
                /*0x9082f4*/ System.Type get_UnderlyingType();
                /*0x9082fc*/ System.Type get_CreatedType();
                /*0x9075f8*/ void set_CreatedType(System.Type value);
                /*0x908304*/ System.Nullable<bool> get_IsReference();
                /*0x90830c*/ void set_IsReference(System.Nullable<bool> value);
                /*0x908314*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x90831c*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x908324*/ Newtonsoft.Json.JsonConverter get_InternalConverter();
                /*0x90832c*/ void set_InternalConverter(Newtonsoft.Json.JsonConverter value);
                /*0x9006d0*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks();
                /*0x900650*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks();
                /*0x9005d0*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks();
                /*0x8fe22c*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks();
                /*0x900750*/ System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks();
                /*0x908334*/ System.Func<object> get_DefaultCreator();
                /*0x90833c*/ void set_DefaultCreator(System.Func<object> value);
                /*0x908344*/ bool get_DefaultCreatorNonPublic();
                /*0x90834c*/ void set_DefaultCreatorNonPublic(bool value);
                /*0x908358*/ void InvokeOnSerializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x9084b8*/ void InvokeOnSerialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x908618*/ void InvokeOnDeserializing(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x908778*/ void InvokeOnDeserialized(object o, System.Runtime.Serialization.StreamingContext context);
                /*0x9088d8*/ void InvokeOnError(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext);

                class <>c__DisplayClass57_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x908a48*/ <>c__DisplayClass57_0();
                    /*0x908a58*/ void <CreateSerializationCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context);
                }

                class <>c__DisplayClass58_0
                {
                    /*0x10*/ System.Reflection.MethodInfo callbackMethodInfo;

                    /*0x908a50*/ <>c__DisplayClass58_0();
                    /*0x908b4c*/ void <CreateSerializationErrorCallback>b__0(object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext econtext);
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

                /*0x9017a4*/ JsonDictionaryContract(System.Type underlyingType);
                /*0x908c74*/ System.Func<string, string> get_DictionaryKeyResolver();
                /*0x908c7c*/ void set_DictionaryKeyResolver(System.Func<string, string> value);
                /*0x908c84*/ System.Type get_DictionaryKeyType();
                /*0x908c8c*/ System.Type get_DictionaryValueType();
                /*0x908c94*/ Newtonsoft.Json.Serialization.JsonContract get_KeyContract();
                /*0x908c9c*/ void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x908ca4*/ bool get_ShouldCreateWrapper();
                /*0x908cac*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x908d6c*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x908d74*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x908d7c*/ bool get_HasParameterizedCreator();
                /*0x908d84*/ void set_HasParameterizedCreator(bool value);
                /*0x908d90*/ bool get_HasParameterizedCreatorInternal();
                /*0x908e10*/ Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(object dictionary);
                /*0x909098*/ System.Collections.IDictionary CreateTemporaryDictionary();
            }

            class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;
                /*0xc8*/ System.Func<string, string> <PropertyNameResolver>k__BackingField;
                /*0xd0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>> _callSiteGetters;
                /*0xd8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<string, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>> _callSiteSetters;

                static /*0x90932c*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>> CreateCallSiteGetter(string name);
                static /*0x909460*/ System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>> CreateCallSiteSetter(string name);
                /*0x90382c*/ JsonDynamicContract(System.Type underlyingType);
                /*0x909314*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x90931c*/ System.Func<string, string> get_PropertyNameResolver();
                /*0x909324*/ void set_PropertyNameResolver(System.Func<string, string> value);
                /*0x909594*/ bool TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, ref object value);
                /*0x909694*/ bool TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, object value);
            }

            class JsonFormatterConverter : System.Runtime.Serialization.IFormatterConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;
                /*0x18*/ Newtonsoft.Json.Serialization.JsonISerializableContract _contract;
                /*0x20*/ Newtonsoft.Json.Serialization.JsonProperty _member;

                /*0x909790*/ JsonFormatterConverter(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                T GetTokenValue<T>(object value);
                /*0x90982c*/ object Convert(object value, System.Type type);
                /*0x909a38*/ object Convert(object value, System.TypeCode typeCode);
                /*0x909b40*/ bool ToBoolean(object value);
                /*0x909b98*/ byte ToByte(object value);
                /*0x909bf0*/ char ToChar(object value);
                /*0x909c48*/ System.DateTime ToDateTime(object value);
                /*0x909ca0*/ decimal ToDecimal(object value);
                /*0x909cf8*/ double ToDouble(object value);
                /*0x909d50*/ short ToInt16(object value);
                /*0x909da8*/ int ToInt32(object value);
                /*0x909e00*/ long ToInt64(object value);
                /*0x909e58*/ sbyte ToSByte(object value);
                /*0x909eb0*/ float ToSingle(object value);
                /*0x909f08*/ string ToString(object value);
                /*0x909f60*/ ushort ToUInt16(object value);
                /*0x909fb8*/ uint ToUInt32(object value);
                /*0x90a010*/ ulong ToUInt64(object value);
            }

            class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContainerContract
            {
                /*0xc0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> <ISerializableCreator>k__BackingField;

                /*0x9035fc*/ JsonISerializableContract(System.Type underlyingType);
                /*0x90a068*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ISerializableCreator();
                /*0x90a070*/ void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
            }

            class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
            {
                /*0x9033b8*/ JsonLinqContract(System.Type underlyingType);
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

                /*0x8fccf8*/ JsonObjectContract(System.Type underlyingType);
                /*0x90a078*/ Newtonsoft.Json.MemberSerialization get_MemberSerialization();
                /*0x90a080*/ void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value);
                /*0x90a088*/ System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling();
                /*0x90a090*/ void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value);
                /*0x90a098*/ System.Nullable<Newtonsoft.Json.Required> get_ItemRequired();
                /*0x90a0a0*/ void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value);
                /*0x90a0a8*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling();
                /*0x90a0b0*/ void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x90a0b8*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties();
                /*0x8fd4b4*/ Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters();
                /*0x90a0c0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_OverrideCreator();
                /*0x90a0c8*/ void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x90a0d0*/ Newtonsoft.Json.Serialization.ObjectConstructor<object> get_ParameterizedCreator();
                /*0x90a0d8*/ void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<object> value);
                /*0x90a0e0*/ Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter();
                /*0x90a0e8*/ void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value);
                /*0x90a0f0*/ Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter();
                /*0x90a0f8*/ void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value);
                /*0x90a100*/ System.Type get_ExtensionDataValueType();
                /*0x8fe8a0*/ void set_ExtensionDataValueType(System.Type value);
                /*0x90a108*/ System.Func<string, string> get_ExtensionDataNameResolver();
                /*0x90a110*/ void set_ExtensionDataNameResolver(System.Func<string, string> value);
                /*0x90a118*/ bool get_HasRequiredOrDefaultValueProperties();
                /*0x90a56c*/ object GetUninitializedObject();
            }

            class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Newtonsoft.Json.ReadType> ReadTypeMap;
                /*0x8c*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;

                static /*0x90a684*/ JsonPrimitiveContract();
                /*0x903244*/ JsonPrimitiveContract(System.Type underlyingType);
                /*0x90a674*/ Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode();
                /*0x90a67c*/ void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value);
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

                /*0x8ff274*/ JsonProperty();
                /*0x90a9dc*/ Newtonsoft.Json.Serialization.JsonContract get_PropertyContract();
                /*0x90a9e4*/ void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value);
                /*0x90a9ec*/ string get_PropertyName();
                /*0x8ff960*/ void set_PropertyName(string value);
                /*0x90a9f4*/ System.Type get_DeclaringType();
                /*0x90a9fc*/ void set_DeclaringType(System.Type value);
                /*0x90aa04*/ System.Nullable<int> get_Order();
                /*0x90aa0c*/ void set_Order(System.Nullable<int> value);
                /*0x90aa14*/ string get_UnderlyingName();
                /*0x90aa1c*/ void set_UnderlyingName(string value);
                /*0x90aa24*/ Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider();
                /*0x90aa2c*/ void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value);
                /*0x90aa34*/ Newtonsoft.Json.Serialization.IAttributeProvider get_AttributeProvider();
                /*0x90aa3c*/ void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value);
                /*0x90aa44*/ System.Type get_PropertyType();
                /*0x8ff27c*/ void set_PropertyType(System.Type value);
                /*0x90aa4c*/ Newtonsoft.Json.JsonConverter get_Converter();
                /*0x90aa54*/ void set_Converter(Newtonsoft.Json.JsonConverter value);
                /*0x90aa5c*/ Newtonsoft.Json.JsonConverter get_MemberConverter();
                /*0x90aa64*/ void set_MemberConverter(Newtonsoft.Json.JsonConverter value);
                /*0x90aa6c*/ bool get_Ignored();
                /*0x90aa74*/ void set_Ignored(bool value);
                /*0x90aa80*/ bool get_Readable();
                /*0x90aa88*/ void set_Readable(bool value);
                /*0x90aa94*/ bool get_Writable();
                /*0x90aa9c*/ void set_Writable(bool value);
                /*0x90aaa8*/ bool get_HasMemberAttribute();
                /*0x90aab0*/ void set_HasMemberAttribute(bool value);
                /*0x8ff9e4*/ object get_DefaultValue();
                /*0x8ff9fc*/ void set_DefaultValue(object value);
                /*0x90aabc*/ object GetResolvedDefaultValue();
                /*0x90a530*/ Newtonsoft.Json.Required get_Required();
                /*0x90ab80*/ void set_Required(Newtonsoft.Json.Required value);
                /*0x90abe8*/ bool get_IsRequiredSpecified();
                /*0x90ac24*/ System.Nullable<bool> get_IsReference();
                /*0x90ac2c*/ void set_IsReference(System.Nullable<bool> value);
                /*0x90ac34*/ System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling();
                /*0x90ac3c*/ void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value);
                /*0x90ac44*/ System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling();
                /*0x90ac4c*/ void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value);
                /*0x90ac54*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling();
                /*0x90ac5c*/ void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x90ac64*/ System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling();
                /*0x90ac6c*/ void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value);
                /*0x90ac74*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling();
                /*0x90ac7c*/ void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x90ac84*/ System.Predicate<object> get_ShouldSerialize();
                /*0x90ac8c*/ void set_ShouldSerialize(System.Predicate<object> value);
                /*0x90ac94*/ System.Predicate<object> get_ShouldDeserialize();
                /*0x90ac9c*/ void set_ShouldDeserialize(System.Predicate<object> value);
                /*0x90aca4*/ System.Predicate<object> get_GetIsSpecified();
                /*0x90acac*/ void set_GetIsSpecified(System.Predicate<object> value);
                /*0x90acb4*/ System.Action<object, object> get_SetIsSpecified();
                /*0x90acbc*/ void set_SetIsSpecified(System.Action<object, object> value);
                /*0x90acc4*/ string ToString();
                /*0x90ad18*/ Newtonsoft.Json.JsonConverter get_ItemConverter();
                /*0x90ad20*/ void set_ItemConverter(Newtonsoft.Json.JsonConverter value);
                /*0x90ad28*/ System.Nullable<bool> get_ItemIsReference();
                /*0x90ad30*/ void set_ItemIsReference(System.Nullable<bool> value);
                /*0x90ad38*/ System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling();
                /*0x90ad40*/ void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value);
                /*0x90ad48*/ System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling();
                /*0x90ad50*/ void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value);
                /*0x90ad58*/ void WritePropertyName(Newtonsoft.Json.JsonWriter writer);
            }

            class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty>
            {
                /*0x30*/ System.Type _type;
                /*0x38*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;

                /*0x8feb8c*/ JsonPropertyCollection(System.Type type);
                /*0x90ada4*/ string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x8fece8*/ void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x8fefa4*/ Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName);
                /*0x90aea8*/ bool TryGetValue(string key, ref Newtonsoft.Json.Serialization.JsonProperty item);
                /*0x90adbc*/ Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType);
            }

            class JsonSerializerInternalBase
            {
                /*0x10*/ Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;
                /*0x18*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> _mappings;
                /*0x20*/ Newtonsoft.Json.JsonSerializer Serializer;
                /*0x28*/ Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;
                /*0x30*/ Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;

                /*0x90af84*/ JsonSerializerInternalBase(Newtonsoft.Json.JsonSerializer serializer);
                /*0x9060a4*/ Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> get_DefaultReferenceMappings();
                /*0x90b010*/ Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0x90b09c*/ Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(object currentObject, object member, string path, System.Exception error);
                /*0x90b188*/ void ClearErrorContext();
                /*0x90b1ec*/ bool IsErrorHandled(object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, string path, System.Exception ex);

                class ReferenceEqualsEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
                {
                    /*0x90b008*/ ReferenceEqualsEqualityComparer();
                    /*0x90b5c4*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
                    /*0x90b5d0*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj);
                }
            }

            class JsonSerializerInternalReader : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                static /*0x910290*/ bool CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, string s);
                /*0x90b5dc*/ JsonSerializerInternalReader(Newtonsoft.Json.JsonSerializer serializer);
                /*0x90b5e0*/ void Populate(Newtonsoft.Json.JsonReader reader, object target);
                /*0x90d48c*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type);
                /*0x90d518*/ Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type);
                /*0x90d5c8*/ object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, bool checkAdditionalContent);
                /*0x90e2d0*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0x90e340*/ Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x90e74c*/ Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader);
                /*0x90dd88*/ object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x9103c4*/ string GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x90d908*/ Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0x90ebbc*/ object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue);
                /*0x910484*/ bool ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x910bbc*/ bool ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, ref object newValue, ref string id);
                /*0x912490*/ void ResolveTypeName(Newtonsoft.Json.JsonReader reader, ref System.Type objectType, ref Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, string qualifiedTypeName);
                /*0x912a84*/ Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x90f6a8*/ object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, object existingValue, string id);
                /*0x911260*/ bool HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract);
                /*0x90fce0*/ object EnsureType(Newtonsoft.Json.JsonReader reader, object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType);
                /*0x913560*/ bool SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target);
                /*0x913a34*/ bool CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, object target, ref bool useExistingValue, ref object currentValue, ref Newtonsoft.Json.Serialization.JsonContract propertyContract, ref bool gottenCurrentValue, ref bool ignoredValue);
                /*0x9140b0*/ void AddReference(Newtonsoft.Json.JsonReader reader, string id, object value);
                /*0x9140a4*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0x913fa8*/ bool ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, object value);
                /*0x912bfc*/ System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, ref bool createdFromNonDefaultCreator);
                /*0x911570*/ System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, ref bool createdFromNonDefaultCreator);
                /*0x914470*/ void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x91469c*/ void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0x90c04c*/ object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x912e80*/ object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x9148c8*/ void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, object currentObject, string message);
                /*0x90bb14*/ object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id);
                /*0x911df4*/ object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x909944*/ object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member);
                /*0x91179c*/ object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x914a00*/ object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<object> creator, string id);
                /*0x90d974*/ object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue);
                /*0x9166e4*/ System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0x91135c*/ object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, string id, ref bool createdFromNonDefaultCreator);
                /*0x90ca10*/ object PopulateObject(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, string id);
                /*0x917428*/ bool ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0x90eaa0*/ bool CheckPropertyName(Newtonsoft.Json.JsonReader reader, string memberName);
                /*0x9172b8*/ void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, string memberName, object o);
                /*0x9171fc*/ object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader);
                /*0x916d58*/ void EndProcessProperty(object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, int initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue);
                /*0x91769c*/ void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties);
                /*0x90e260*/ void HandleError(Newtonsoft.Json.JsonReader reader, bool readPastError, int initialDepth);

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

                    /*0xa01910*/ CreatorPropertyContext(string name);
                }

                class <>c__DisplayClass38_0
                {
                    /*0x10*/ Newtonsoft.Json.Serialization.JsonProperty property;

                    /*0xa01938*/ <>c__DisplayClass38_0();
                    /*0xa01940*/ bool <CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_0;
                    static /*0x10*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, string> <>9__38_2;
                    static /*0x18*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0;
                    static /*0x20*/ System.Func<Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1;

                    static /*0xa01964*/ <>c();
                    /*0xa019c8*/ <>c();
                    /*0xa019d0*/ string <CreateObjectUsingCreatorWithParameters>b__38_0(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0xa019e8*/ string <CreateObjectUsingCreatorWithParameters>b__38_2(Newtonsoft.Json.Serialization.JsonProperty p);
                    /*0xa01a00*/ Newtonsoft.Json.Serialization.JsonProperty <PopulateObject>b__42_0(Newtonsoft.Json.Serialization.JsonProperty m);
                    /*0xa01a08*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(Newtonsoft.Json.Serialization.JsonProperty m);
                }
            }

            class JsonSerializerInternalWriter : Newtonsoft.Json.Serialization.JsonSerializerInternalBase
            {
                /*0x38*/ System.Type _rootType;
                /*0x40*/ int _rootLevel;
                /*0x48*/ System.Collections.Generic.List<object> _serializeStack;

                static /*0xa06370*/ bool TryConvertToString(object value, System.Type type, ref string s);
                /*0xa01a10*/ JsonSerializerInternalWriter(Newtonsoft.Json.JsonSerializer serializer);
                /*0xa01a9c*/ void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type objectType);
                /*0xa02814*/ Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer();
                /*0xa01d08*/ Newtonsoft.Json.Serialization.JsonContract GetContractSafe(object value);
                /*0xa028fc*/ Newtonsoft.Json.Serialization.JsonContract GetContract(object value);
                /*0xa029c0*/ void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa0213c*/ void SerializeValue(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa05a88*/ System.Nullable<bool> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa01d18*/ bool ShouldWriteReference(object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa05b44*/ bool ShouldWriteProperty(object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0xa05c28*/ bool CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa01eb0*/ void WriteReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0xa06184*/ string GetReference(Newtonsoft.Json.JsonWriter writer, object value);
                /*0xa0455c*/ void SerializeString(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonStringContract contract);
                /*0xa06660*/ void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0xa06868*/ void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, object value);
                /*0xa03500*/ void SerializeObject(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa06bb8*/ bool CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, ref Newtonsoft.Json.Serialization.JsonContract memberContract, ref object memberValue);
                /*0xa06a70*/ void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa07988*/ bool HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property);
                /*0xa07a44*/ void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, object value);
                /*0xa02d54*/ void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type);
                /*0xa05c1c*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0xa05b38*/ bool HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag);
                /*0xa07c98*/ bool HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag);
                /*0xa02fdc*/ void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa03c58*/ void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa04364*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa07f54*/ void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, int initialDepth, int[] indices);
                /*0xa07ca4*/ bool WriteStartArray(Newtonsoft.Json.JsonWriter writer, object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa05614*/ void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa04e5c*/ void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa083e8*/ bool ShouldWriteDynamicProperty(object memberValue);
                /*0xa02b30*/ bool ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa045dc*/ void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty);
                /*0xa06fe4*/ string GetPropertyName(Newtonsoft.Json.JsonWriter writer, object name, Newtonsoft.Json.Serialization.JsonContract contract, ref bool escape);
                /*0xa0279c*/ void HandleError(Newtonsoft.Json.JsonWriter writer, int initialDepth);
                /*0xa074a8*/ bool ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
                /*0xa07718*/ bool IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, object target);
            }

            class JsonSerializerProxy : Newtonsoft.Json.JsonSerializer
            {
                /*0xe0*/ Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;
                /*0xe8*/ Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;
                /*0xf0*/ Newtonsoft.Json.JsonSerializer _serializer;

                /*0xa08d34*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader);
                /*0xa02880*/ JsonSerializerProxy(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter);
                /*0xa084a4*/ void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0xa084c4*/ void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value);
                /*0xa084e4*/ Newtonsoft.Json.Serialization.IReferenceResolver get_ReferenceResolver();
                /*0xa08504*/ void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value);
                /*0xa08524*/ Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter();
                /*0xa08544*/ void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value);
                /*0xa08568*/ System.Collections.IEqualityComparer get_EqualityComparer();
                /*0xa0858c*/ void set_EqualityComparer(System.Collections.IEqualityComparer value);
                /*0xa085b0*/ Newtonsoft.Json.JsonConverterCollection get_Converters();
                /*0xa085d4*/ Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling();
                /*0xa085f8*/ void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value);
                /*0xa0861c*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
                /*0xa08640*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
                /*0xa08664*/ Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling();
                /*0xa08688*/ void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value);
                /*0xa086ac*/ Newtonsoft.Json.NullValueHandling get_NullValueHandling();
                /*0xa086d0*/ void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value);
                /*0xa086f4*/ Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling();
                /*0xa08718*/ void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value);
                /*0xa0873c*/ Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling();
                /*0xa08760*/ void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value);
                /*0xa08784*/ Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling();
                /*0xa087a8*/ void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value);
                /*0xa087cc*/ Newtonsoft.Json.TypeNameHandling get_TypeNameHandling();
                /*0xa087f0*/ void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value);
                /*0xa08814*/ Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling();
                /*0xa08838*/ void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value);
                /*0xa0885c*/ System.Runtime.Serialization.Formatters.FormatterAssemblyStyle get_TypeNameAssemblyFormat();
                /*0xa08880*/ void set_TypeNameAssemblyFormat(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle value);
                /*0xa088a4*/ Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling();
                /*0xa088c8*/ void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value);
                /*0xa088ec*/ Newtonsoft.Json.ConstructorHandling get_ConstructorHandling();
                /*0xa08910*/ void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value);
                /*0xa08934*/ System.Runtime.Serialization.SerializationBinder get_Binder();
                /*0xa08954*/ void set_Binder(System.Runtime.Serialization.SerializationBinder value);
                /*0xa08974*/ Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder();
                /*0xa08994*/ void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value);
                /*0xa089b4*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0xa089d8*/ void set_Context(System.Runtime.Serialization.StreamingContext value);
                /*0xa089fc*/ Newtonsoft.Json.Formatting get_Formatting();
                /*0xa08a20*/ void set_Formatting(Newtonsoft.Json.Formatting value);
                /*0xa08a44*/ Newtonsoft.Json.DateFormatHandling get_DateFormatHandling();
                /*0xa08a68*/ void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value);
                /*0xa08a8c*/ Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling();
                /*0xa08ab0*/ void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value);
                /*0xa08ad4*/ Newtonsoft.Json.DateParseHandling get_DateParseHandling();
                /*0xa08af8*/ void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value);
                /*0xa08b1c*/ Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling();
                /*0xa08b40*/ void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value);
                /*0xa08b64*/ Newtonsoft.Json.FloatParseHandling get_FloatParseHandling();
                /*0xa08b88*/ void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value);
                /*0xa08bac*/ Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling();
                /*0xa08bd0*/ void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value);
                /*0xa08bf4*/ string get_DateFormatString();
                /*0xa08c18*/ void set_DateFormatString(string value);
                /*0xa08c3c*/ System.Globalization.CultureInfo get_Culture();
                /*0xa08c60*/ void set_Culture(System.Globalization.CultureInfo value);
                /*0xa08c84*/ System.Nullable<int> get_MaxDepth();
                /*0xa08ca8*/ void set_MaxDepth(System.Nullable<int> value);
                /*0xa08ccc*/ bool get_CheckAdditionalContent();
                /*0xa08cf0*/ void set_CheckAdditionalContent(bool value);
                /*0xa08d18*/ Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer();
                /*0xa08db0*/ object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType);
                /*0xa08de8*/ void PopulateInternal(Newtonsoft.Json.JsonReader reader, object target);
                /*0xa08e1c*/ void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, object value, System.Type rootType);
            }

            class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
            {
                /*0xa08e4c*/ JsonStringContract(System.Type underlyingType);
            }

            class JsonTypeReflector
            {
                static string IdPropertyName = "$id";
                static string RefPropertyName = "$ref";
                static string TypePropertyName = "$type";
                static string ValuePropertyName = "$value";
                static string ArrayValuesPropertyName = "$values";
                static string ShouldSerializePrefix = "ShouldSerialize";
                static string SpecifiedPostfix = "Specified";
                static string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";
                static /*0x0*/ System.Nullable<bool> _dynamicCodeGeneration;
                static /*0x2*/ System.Nullable<bool> _fullyTrusted;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Func<System.Object[], object>> CreatorCache;
                static /*0x10*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache;
                static /*0x18*/ Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;

                static /*0xa09d5c*/ JsonTypeReflector();
                static T GetCachedAttribute<T>(object attributeProvider);
                static /*0xa06474*/ bool CanTypeDescriptorConvertString(System.Type type, ref System.ComponentModel.TypeConverter typeConverter);
                static /*0xa08ec0*/ System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type);
                static /*0xa08f8c*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo);
                static /*0xa09210*/ Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute);
                static /*0xa09364*/ Newtonsoft.Json.JsonConverter GetJsonConverter(object attributeProvider);
                static /*0xa09484*/ Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] args);
                static /*0xa09578*/ Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, object[] args);
                static /*0xa0966c*/ Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute);
                static /*0xa09724*/ System.Func<System.Object[], object> GetCreator(System.Type type);
                static /*0xa09920*/ System.Type GetAssociatedMetadataType(System.Type type);
                static /*0xa099a0*/ System.Type GetAssociateMetadataTypeFromAttribute(System.Type type);
                static T GetAttribute<T>(System.Type type);
                static T GetAttribute<T>(System.Reflection.MemberInfo memberInfo);
                static /*0xa09c08*/ bool IsNonSerializable(object provider);
                static /*0xa092e8*/ bool IsSerializable(object provider);
                static T GetAttribute<T>(object provider);
                static /*0xa09c84*/ bool get_DynamicCodeGeneration();
                static /*0xa082d4*/ bool get_FullyTrusted();
                static /*0xa09898*/ Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory();

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ System.Type type;
                    /*0x18*/ System.Func<object> defaultConstructor;

                    /*0xa09890*/ <>c__DisplayClass22_0();
                    /*0xa09ed4*/ object <GetCreator>b__0(object[] parameters);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Serialization.JsonTypeReflector.<> <>9;
                    static /*0x8*/ System.Func<object, System.Type> <>9__22_1;

                    static /*0xa0a32c*/ <>c();
                    /*0xa0a390*/ <>c();
                    /*0xa0a398*/ System.Type <GetCreator>b__22_1(object param);
                }
            }

            class KebabCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0xa0a3f8*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0xa0a438*/ KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0xa0a484*/ KebabCaseNamingStrategy();
                /*0xa0a48c*/ string ResolvePropertyName(string name);
            }

            class MemoryTraceWriter : Newtonsoft.Json.Serialization.ITraceWriter
            {
                /*0x10*/ System.Collections.Generic.Queue<string> _traceMessages;
                /*0x18*/ object _lock;
                /*0x20*/ System.Diagnostics.TraceLevel <LevelFilter>k__BackingField;

                /*0xa0a4a8*/ MemoryTraceWriter();
                /*0xa0a498*/ System.Diagnostics.TraceLevel get_LevelFilter();
                /*0xa0a4a0*/ void set_LevelFilter(System.Diagnostics.TraceLevel value);
                /*0xa0a560*/ void Trace(System.Diagnostics.TraceLevel level, string message, System.Exception ex);
                /*0xa0a844*/ System.Collections.Generic.IEnumerable<string> GetTraceMessages();
                /*0xa0a84c*/ string ToString();
            }

            class NamingStrategy
            {
                /*0x10*/ bool <ProcessDictionaryKeys>k__BackingField;
                /*0x11*/ bool <ProcessExtensionDataNames>k__BackingField;
                /*0x12*/ bool <OverrideSpecifiedNames>k__BackingField;

                /*0xa0a430*/ NamingStrategy();
                /*0xa0aaf4*/ bool get_ProcessDictionaryKeys();
                /*0xa0aafc*/ void set_ProcessDictionaryKeys(bool value);
                /*0xa0ab08*/ bool get_ProcessExtensionDataNames();
                /*0xa0ab10*/ void set_ProcessExtensionDataNames(bool value);
                /*0xa0ab1c*/ bool get_OverrideSpecifiedNames();
                /*0xa0ab24*/ void set_OverrideSpecifiedNames(bool value);
                /*0xa0ab30*/ string GetPropertyName(string name, bool hasSpecifiedName);
                /*0xa0ab50*/ string GetExtensionDataName(string name);
                /*0xa0ab6c*/ string GetDictionaryKey(string key);
                string ResolvePropertyName(string name);
                /*0xa0ab88*/ int GetHashCode();
                /*0xa0ac2c*/ bool Equals(object obj);
                /*0xa0acac*/ bool Equals(Newtonsoft.Json.Serialization.NamingStrategy other);
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
                /*0xa0ada8*/ OnErrorAttribute();
            }

            class ReflectionAttributeProvider : Newtonsoft.Json.Serialization.IAttributeProvider
            {
                /*0x10*/ object _attributeProvider;

                /*0xa0adb0*/ ReflectionAttributeProvider(object attributeProvider);
                /*0xa0ae1c*/ System.Collections.Generic.IList<System.Attribute> GetAttributes(bool inherit);
                /*0xa0ae8c*/ System.Collections.Generic.IList<System.Attribute> GetAttributes(System.Type attributeType, bool inherit);
            }

            class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
            {
                /*0x10*/ System.Reflection.MemberInfo _memberInfo;

                /*0xa0af00*/ ReflectionValueProvider(System.Reflection.MemberInfo memberInfo);
                /*0xa0af6c*/ void SetValue(object target, object value);
                /*0xa0b110*/ object GetValue(object target);
            }

            class SerializationBinderAdapter : Newtonsoft.Json.Serialization.ISerializationBinder
            {
                /*0x10*/ System.Runtime.Serialization.SerializationBinder SerializationBinder;

                /*0xa0b3bc*/ SerializationBinderAdapter(System.Runtime.Serialization.SerializationBinder serializationBinder);
                /*0xa0b3e4*/ System.Type BindToType(string assemblyName, string typeName);
                /*0xa0b404*/ void BindToName(System.Type serializedType, ref string assemblyName, ref string typeName);
            }

            class SnakeCaseNamingStrategy : Newtonsoft.Json.Serialization.NamingStrategy
            {
                /*0xa0b424*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames);
                /*0xa0b45c*/ SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames);
                /*0xa0b4a8*/ SnakeCaseNamingStrategy();
                /*0xa0b4b0*/ string ResolvePropertyName(string name);
            }

            class TraceJsonReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.JsonReader _innerReader;
                /*0x80*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x88*/ System.IO.StringWriter _sw;

                /*0xa0b4bc*/ TraceJsonReader(Newtonsoft.Json.JsonReader innerReader);
                /*0xa0b5fc*/ string GetDeserializedJsonMessage();
                /*0xa0b61c*/ bool Read();
                /*0xa0b698*/ System.Nullable<int> ReadAsInt32();
                /*0xa0b6dc*/ string ReadAsString();
                /*0xa0b720*/ byte[] ReadAsBytes();
                /*0xa0b764*/ System.Nullable<decimal> ReadAsDecimal();
                /*0xa0b7e0*/ System.Nullable<double> ReadAsDouble();
                /*0xa0b82c*/ System.Nullable<bool> ReadAsBoolean();
                /*0xa0b870*/ System.Nullable<System.DateTime> ReadAsDateTime();
                /*0xa0b8bc*/ System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
                /*0xa0b660*/ void WriteCurrentToken();
                /*0xa0b918*/ int get_Depth();
                /*0xa0b93c*/ string get_Path();
                /*0xa0b960*/ char get_QuoteChar();
                /*0xa0b984*/ void set_QuoteChar(char value);
                /*0xa0b9a8*/ Newtonsoft.Json.JsonToken get_TokenType();
                /*0xa0b9cc*/ object get_Value();
                /*0xa0b9f0*/ System.Type get_ValueType();
                /*0xa0ba14*/ void Close();
                /*0xa0ba38*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0xa0baec*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0xa0bba4*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
            }

            class TraceJsonWriter : Newtonsoft.Json.JsonWriter
            {
                /*0x60*/ Newtonsoft.Json.JsonWriter _innerWriter;
                /*0x68*/ Newtonsoft.Json.JsonTextWriter _textWriter;
                /*0x70*/ System.IO.StringWriter _sw;

                /*0xa0bc5c*/ TraceJsonWriter(Newtonsoft.Json.JsonWriter innerWriter);
                /*0xa0be28*/ string GetSerializedJsonMessage();
                /*0xa0be48*/ void WriteValue(decimal value);
                /*0xa0beb4*/ void WriteValue(System.Nullable<decimal> value);
                /*0xa0bfd0*/ void WriteValue(bool value);
                /*0xa0c034*/ void WriteValue(System.Nullable<bool> value);
                /*0xa0c0ec*/ void WriteValue(byte value);
                /*0xa0c14c*/ void WriteValue(System.Nullable<byte> value);
                /*0xa0c1fc*/ void WriteValue(char value);
                /*0xa0c25c*/ void WriteValue(System.Nullable<char> value);
                /*0xa0c30c*/ void WriteValue(byte[] value);
                /*0xa0c380*/ void WriteValue(System.DateTime value);
                /*0xa0c3e0*/ void WriteValue(System.Nullable<System.DateTime> value);
                /*0xa0c4a0*/ void WriteValue(System.DateTimeOffset value);
                /*0xa0c50c*/ void WriteValue(System.Nullable<System.DateTimeOffset> value);
                /*0xa0c600*/ void WriteValue(double value);
                /*0xa0c660*/ void WriteValue(System.Nullable<double> value);
                /*0xa0c724*/ void WriteUndefined();
                /*0xa0c770*/ void WriteNull();
                /*0xa0c7bc*/ void WriteValue(float value);
                /*0xa0c81c*/ void WriteValue(System.Nullable<float> value);
                /*0xa0c8cc*/ void WriteValue(System.Guid value);
                /*0xa0c938*/ void WriteValue(System.Nullable<System.Guid> value);
                /*0xa0ca30*/ void WriteValue(int value);
                /*0xa0ca90*/ void WriteValue(System.Nullable<int> value);
                /*0xa0cb3c*/ void WriteValue(long value);
                /*0xa0cb9c*/ void WriteValue(System.Nullable<long> value);
                /*0xa0cc5c*/ void WriteValue(object value);
                /*0xa0cd28*/ void WriteValue(sbyte value);
                /*0xa0cd88*/ void WriteValue(System.Nullable<sbyte> value);
                /*0xa0ce38*/ void WriteValue(short value);
                /*0xa0ce98*/ void WriteValue(System.Nullable<short> value);
                /*0xa0cf48*/ void WriteValue(string value);
                /*0xa0cfa8*/ void WriteValue(System.TimeSpan value);
                /*0xa0d008*/ void WriteValue(System.Nullable<System.TimeSpan> value);
                /*0xa0d0c8*/ void WriteValue(uint value);
                /*0xa0d128*/ void WriteValue(System.Nullable<uint> value);
                /*0xa0d1d4*/ void WriteValue(ulong value);
                /*0xa0d234*/ void WriteValue(System.Nullable<ulong> value);
                /*0xa0d2f4*/ void WriteValue(System.Uri value);
                /*0xa0d3b8*/ void WriteValue(ushort value);
                /*0xa0d418*/ void WriteValue(System.Nullable<ushort> value);
                /*0xa0d4c8*/ void WriteWhitespace(string ws);
                /*0xa0d528*/ void WriteComment(string text);
                /*0xa0d588*/ void WriteStartArray();
                /*0xa0d5d4*/ void WriteEndArray();
                /*0xa0d620*/ void WriteStartConstructor(string name);
                /*0xa0d680*/ void WriteEndConstructor();
                /*0xa0d6cc*/ void WritePropertyName(string name);
                /*0xa0d72c*/ void WritePropertyName(string name, bool escape);
                /*0xa0d798*/ void WriteStartObject();
                /*0xa0d7e4*/ void WriteEndObject();
                /*0xa0d830*/ void WriteRawValue(string json);
                /*0xa0d890*/ void WriteRaw(string json);
                /*0xa0d8f0*/ void Close();
                /*0xa0d93c*/ void Flush();
            }
        }

        namespace Schema
        {
            class Extensions
            {
                static /*0xa0d97c*/ bool IsValid(Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema);
                static /*0xa0ddb0*/ bool IsValid(Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema, ref System.Collections.Generic.IList<string> errorMessages);
                static /*0xa0df44*/ void Validate(Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema);
                static /*0xa0db7c*/ void Validate(Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema, Newtonsoft.Json.Schema.ValidationEventHandler validationEventHandler);

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ bool valid;

                    /*0xa0da44*/ <>c__DisplayClass0_0();
                    /*0xa0df4c*/ void <IsValid>b__0(object sender, Newtonsoft.Json.Schema.ValidationEventArgs args);
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ System.Collections.Generic.IList<string> errors;

                    /*0xa0df3c*/ <>c__DisplayClass1_0();
                    /*0xa0df54*/ void <IsValid>b__0(object sender, Newtonsoft.Json.Schema.ValidationEventArgs args);
                }
            }

            class JsonSchema
            {
                /*0x10*/ string <Id>k__BackingField;
                /*0x18*/ string <Title>k__BackingField;
                /*0x20*/ System.Nullable<bool> <Required>k__BackingField;
                /*0x22*/ System.Nullable<bool> <ReadOnly>k__BackingField;
                /*0x24*/ System.Nullable<bool> <Hidden>k__BackingField;
                /*0x26*/ System.Nullable<bool> <Transient>k__BackingField;
                /*0x28*/ string <Description>k__BackingField;
                /*0x30*/ System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> <Type>k__BackingField;
                /*0x38*/ string <Pattern>k__BackingField;
                /*0x40*/ System.Nullable<int> <MinimumLength>k__BackingField;
                /*0x48*/ System.Nullable<int> <MaximumLength>k__BackingField;
                /*0x50*/ System.Nullable<double> <DivisibleBy>k__BackingField;
                /*0x60*/ System.Nullable<double> <Minimum>k__BackingField;
                /*0x70*/ System.Nullable<double> <Maximum>k__BackingField;
                /*0x80*/ System.Nullable<bool> <ExclusiveMinimum>k__BackingField;
                /*0x82*/ System.Nullable<bool> <ExclusiveMaximum>k__BackingField;
                /*0x84*/ System.Nullable<int> <MinimumItems>k__BackingField;
                /*0x8c*/ System.Nullable<int> <MaximumItems>k__BackingField;
                /*0x98*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> <Items>k__BackingField;
                /*0xa0*/ bool <PositionalItemsValidation>k__BackingField;
                /*0xa8*/ Newtonsoft.Json.Schema.JsonSchema <AdditionalItems>k__BackingField;
                /*0xb0*/ bool <AllowAdditionalItems>k__BackingField;
                /*0xb1*/ bool <UniqueItems>k__BackingField;
                /*0xb8*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> <Properties>k__BackingField;
                /*0xc0*/ Newtonsoft.Json.Schema.JsonSchema <AdditionalProperties>k__BackingField;
                /*0xc8*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> <PatternProperties>k__BackingField;
                /*0xd0*/ bool <AllowAdditionalProperties>k__BackingField;
                /*0xd8*/ string <Requires>k__BackingField;
                /*0xe0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> <Enum>k__BackingField;
                /*0xe8*/ System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> <Disallow>k__BackingField;
                /*0xf0*/ Newtonsoft.Json.Linq.JToken <Default>k__BackingField;
                /*0xf8*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> <Extends>k__BackingField;
                /*0x100*/ string <Format>k__BackingField;
                /*0x108*/ string <Location>k__BackingField;
                /*0x110*/ string _internalId;
                /*0x118*/ string <DeferredReference>k__BackingField;
                /*0x120*/ bool <ReferencesResolved>k__BackingField;

                static /*0xa0e328*/ Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader);
                static /*0xa0e408*/ Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Schema.JsonSchemaResolver resolver);
                static /*0xa0e670*/ Newtonsoft.Json.Schema.JsonSchema Parse(string json);
                static /*0xa0e6d0*/ Newtonsoft.Json.Schema.JsonSchema Parse(string json, Newtonsoft.Json.Schema.JsonSchemaResolver resolver);
                /*0xa0e2a4*/ JsonSchema();
                /*0xa0e03c*/ string get_Id();
                /*0xa0e044*/ void set_Id(string value);
                /*0xa0e04c*/ string get_Title();
                /*0xa0e054*/ void set_Title(string value);
                /*0xa0e05c*/ System.Nullable<bool> get_Required();
                /*0xa0e064*/ void set_Required(System.Nullable<bool> value);
                /*0xa0e06c*/ System.Nullable<bool> get_ReadOnly();
                /*0xa0e074*/ void set_ReadOnly(System.Nullable<bool> value);
                /*0xa0e07c*/ System.Nullable<bool> get_Hidden();
                /*0xa0e084*/ void set_Hidden(System.Nullable<bool> value);
                /*0xa0e08c*/ System.Nullable<bool> get_Transient();
                /*0xa0e094*/ void set_Transient(System.Nullable<bool> value);
                /*0xa0e09c*/ string get_Description();
                /*0xa0e0a4*/ void set_Description(string value);
                /*0xa0e0ac*/ System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> get_Type();
                /*0xa0e0b4*/ void set_Type(System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> value);
                /*0xa0e0bc*/ string get_Pattern();
                /*0xa0e0c4*/ void set_Pattern(string value);
                /*0xa0e0cc*/ System.Nullable<int> get_MinimumLength();
                /*0xa0e0d4*/ void set_MinimumLength(System.Nullable<int> value);
                /*0xa0e0dc*/ System.Nullable<int> get_MaximumLength();
                /*0xa0e0e4*/ void set_MaximumLength(System.Nullable<int> value);
                /*0xa0e0ec*/ System.Nullable<double> get_DivisibleBy();
                /*0xa0e0f8*/ void set_DivisibleBy(System.Nullable<double> value);
                /*0xa0e100*/ System.Nullable<double> get_Minimum();
                /*0xa0e10c*/ void set_Minimum(System.Nullable<double> value);
                /*0xa0e114*/ System.Nullable<double> get_Maximum();
                /*0xa0e120*/ void set_Maximum(System.Nullable<double> value);
                /*0xa0e128*/ System.Nullable<bool> get_ExclusiveMinimum();
                /*0xa0e130*/ void set_ExclusiveMinimum(System.Nullable<bool> value);
                /*0xa0e138*/ System.Nullable<bool> get_ExclusiveMaximum();
                /*0xa0e140*/ void set_ExclusiveMaximum(System.Nullable<bool> value);
                /*0xa0e148*/ System.Nullable<int> get_MinimumItems();
                /*0xa0e150*/ void set_MinimumItems(System.Nullable<int> value);
                /*0xa0e158*/ System.Nullable<int> get_MaximumItems();
                /*0xa0e160*/ void set_MaximumItems(System.Nullable<int> value);
                /*0xa0e168*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> get_Items();
                /*0xa0e170*/ void set_Items(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> value);
                /*0xa0e178*/ bool get_PositionalItemsValidation();
                /*0xa0e180*/ void set_PositionalItemsValidation(bool value);
                /*0xa0e18c*/ Newtonsoft.Json.Schema.JsonSchema get_AdditionalItems();
                /*0xa0e194*/ void set_AdditionalItems(Newtonsoft.Json.Schema.JsonSchema value);
                /*0xa0e19c*/ bool get_AllowAdditionalItems();
                /*0xa0e1a4*/ void set_AllowAdditionalItems(bool value);
                /*0xa0e1b0*/ bool get_UniqueItems();
                /*0xa0e1b8*/ void set_UniqueItems(bool value);
                /*0xa0e1c4*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> get_Properties();
                /*0xa0e1cc*/ void set_Properties(System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> value);
                /*0xa0e1d4*/ Newtonsoft.Json.Schema.JsonSchema get_AdditionalProperties();
                /*0xa0e1dc*/ void set_AdditionalProperties(Newtonsoft.Json.Schema.JsonSchema value);
                /*0xa0e1e4*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> get_PatternProperties();
                /*0xa0e1ec*/ void set_PatternProperties(System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> value);
                /*0xa0e1f4*/ bool get_AllowAdditionalProperties();
                /*0xa0e1fc*/ void set_AllowAdditionalProperties(bool value);
                /*0xa0e208*/ string get_Requires();
                /*0xa0e210*/ void set_Requires(string value);
                /*0xa0e218*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_Enum();
                /*0xa0e220*/ void set_Enum(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> value);
                /*0xa0e228*/ System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> get_Disallow();
                /*0xa0e230*/ void set_Disallow(System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> value);
                /*0xa0e238*/ Newtonsoft.Json.Linq.JToken get_Default();
                /*0xa0e240*/ void set_Default(Newtonsoft.Json.Linq.JToken value);
                /*0xa0e248*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> get_Extends();
                /*0xa0e250*/ void set_Extends(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> value);
                /*0xa0e258*/ string get_Format();
                /*0xa0e260*/ void set_Format(string value);
                /*0xa0e268*/ string get_Location();
                /*0xa0e270*/ void set_Location(string value);
                /*0xa0e278*/ string get_InternalId();
                /*0xa0e280*/ string get_DeferredReference();
                /*0xa0e288*/ void set_DeferredReference(string value);
                /*0xa0e290*/ bool get_ReferencesResolved();
                /*0xa0e298*/ void set_ReferencesResolved(bool value);
                /*0xa0e8c0*/ void WriteTo(Newtonsoft.Json.JsonWriter writer);
                /*0xa0e930*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Schema.JsonSchemaResolver resolver);
                /*0xa0fa84*/ string ToString();
            }

            class JsonSchemaBuilder
            {
                /*0x10*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> _stack;
                /*0x18*/ Newtonsoft.Json.Schema.JsonSchemaResolver _resolver;
                /*0x20*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> _documentSchemas;
                /*0x28*/ Newtonsoft.Json.Schema.JsonSchema _currentSchema;
                /*0x30*/ Newtonsoft.Json.Linq.JObject _rootSchema;

                static /*0xa13a40*/ Newtonsoft.Json.Schema.JsonSchemaType MapType(string type);
                static /*0xa13bac*/ string MapType(Newtonsoft.Json.Schema.JsonSchemaType type);
                /*0xa0e4c8*/ JsonSchemaBuilder(Newtonsoft.Json.Schema.JsonSchemaResolver resolver);
                /*0xa0fb78*/ void Push(Newtonsoft.Json.Schema.JsonSchema value);
                /*0xa0fd28*/ Newtonsoft.Json.Schema.JsonSchema Pop();
                /*0xa0fe78*/ Newtonsoft.Json.Schema.JsonSchema get_CurrentSchema();
                /*0xa0e598*/ Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader);
                /*0xa10b58*/ string UnescapeReference(string reference);
                /*0xa1022c*/ Newtonsoft.Json.Schema.JsonSchema ResolveReferences(Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa0fe80*/ Newtonsoft.Json.Schema.JsonSchema BuildSchema(Newtonsoft.Json.Linq.JToken token);
                /*0xa10c2c*/ void ProcessSchemaProperties(Newtonsoft.Json.Linq.JObject schemaObject);
                /*0xa13590*/ void ProcessExtends(Newtonsoft.Json.Linq.JToken token);
                /*0xa130e8*/ void ProcessEnum(Newtonsoft.Json.Linq.JToken token);
                /*0xa12f90*/ void ProcessAdditionalProperties(Newtonsoft.Json.Linq.JToken token);
                /*0xa1303c*/ void ProcessAdditionalItems(Newtonsoft.Json.Linq.JToken token);
                /*0xa12448*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> ProcessProperties(Newtonsoft.Json.Linq.JToken token);
                /*0xa12a34*/ void ProcessItems(Newtonsoft.Json.Linq.JToken token);
                /*0xa11e74*/ System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> ProcessType(Newtonsoft.Json.Linq.JToken token);

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Newtonsoft.Json.Schema.JsonSchemaType type;

                    /*0xa13cb8*/ <>c__DisplayClass23_0();
                    /*0xa13cc0*/ bool <MapType>b__0(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Schema.JsonSchemaType> kv);
                }
            }

            class JsonSchemaConstants
            {
                static string TypePropertyName = "type";
                static string PropertiesPropertyName = "properties";
                static string ItemsPropertyName = "items";
                static string AdditionalItemsPropertyName = "additionalItems";
                static string RequiredPropertyName = "required";
                static string PatternPropertiesPropertyName = "patternProperties";
                static string AdditionalPropertiesPropertyName = "additionalProperties";
                static string RequiresPropertyName = "requires";
                static string MinimumPropertyName = "minimum";
                static string MaximumPropertyName = "maximum";
                static string ExclusiveMinimumPropertyName = "exclusiveMinimum";
                static string ExclusiveMaximumPropertyName = "exclusiveMaximum";
                static string MinimumItemsPropertyName = "minItems";
                static string MaximumItemsPropertyName = "maxItems";
                static string PatternPropertyName = "pattern";
                static string MaximumLengthPropertyName = "maxLength";
                static string MinimumLengthPropertyName = "minLength";
                static string EnumPropertyName = "enum";
                static string ReadOnlyPropertyName = "readonly";
                static string TitlePropertyName = "title";
                static string DescriptionPropertyName = "description";
                static string FormatPropertyName = "format";
                static string DefaultPropertyName = "default";
                static string TransientPropertyName = "transient";
                static string DivisibleByPropertyName = "divisibleBy";
                static string HiddenPropertyName = "hidden";
                static string DisallowPropertyName = "disallow";
                static string ExtendsPropertyName = "extends";
                static string IdPropertyName = "id";
                static string UniqueItemsPropertyName = "uniqueItems";
                static string OptionValuePropertyName = "value";
                static string OptionLabelPropertyName = "label";
                static /*0x0*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaType> JsonSchemaTypeMapping;

                static /*0xa13d08*/ JsonSchemaConstants();
            }

            class JsonSchemaException : Newtonsoft.Json.JsonException
            {
                /*0x8c*/ int <LineNumber>k__BackingField;
                /*0x90*/ int <LinePosition>k__BackingField;
                /*0x98*/ string <Path>k__BackingField;

                /*0xa13f20*/ JsonSchemaException();
                /*0xa13f28*/ JsonSchemaException(string message);
                /*0xa13f30*/ JsonSchemaException(string message, System.Exception innerException);
                /*0xa13f38*/ JsonSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xa13f40*/ JsonSchemaException(string message, System.Exception innerException, string path, int lineNumber, int linePosition);
                /*0xa13f08*/ int get_LineNumber();
                /*0xa13f10*/ int get_LinePosition();
                /*0xa13f18*/ string get_Path();
            }

            class JsonSchemaGenerator
            {
                /*0x10*/ Newtonsoft.Json.Schema.UndefinedSchemaIdHandling <UndefinedSchemaIdHandling>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Serialization.IContractResolver _contractResolver;
                /*0x20*/ Newtonsoft.Json.Schema.JsonSchemaResolver _resolver;
                /*0x28*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema> _stack;
                /*0x30*/ Newtonsoft.Json.Schema.JsonSchema _currentSchema;

                static /*0xa15414*/ bool HasFlag(System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> value, Newtonsoft.Json.Schema.JsonSchemaType flag);
                /*0xa15c5c*/ JsonSchemaGenerator();
                /*0xa13f7c*/ Newtonsoft.Json.Schema.UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling();
                /*0xa13f84*/ void set_UndefinedSchemaIdHandling(Newtonsoft.Json.Schema.UndefinedSchemaIdHandling value);
                /*0xa13f8c*/ Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver();
                /*0xa14020*/ void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value);
                /*0xa14028*/ Newtonsoft.Json.Schema.JsonSchema get_CurrentSchema();
                /*0xa14030*/ void Push(Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema typeSchema);
                /*0xa14170*/ Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema Pop();
                /*0xa14390*/ Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type);
                /*0xa144b8*/ Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, Newtonsoft.Json.Schema.JsonSchemaResolver resolver);
                /*0xa144c0*/ Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, bool rootSchemaNullable);
                /*0xa14404*/ Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, Newtonsoft.Json.Schema.JsonSchemaResolver resolver, bool rootSchemaNullable);
                /*0xa15184*/ string GetTitle(System.Type type);
                /*0xa15220*/ string GetDescription(System.Type type);
                /*0xa15310*/ string GetTypeId(System.Type type, bool explicitOnly);
                /*0xa14538*/ Newtonsoft.Json.Schema.JsonSchema GenerateInternal(System.Type type, Newtonsoft.Json.Required valueRequired, bool required);
                /*0xa1558c*/ Newtonsoft.Json.Schema.JsonSchemaType AddNullType(Newtonsoft.Json.Schema.JsonSchemaType type, Newtonsoft.Json.Required valueRequired);
                /*0xa15c50*/ bool HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag);
                /*0xa1559c*/ void GenerateObjectSchema(System.Type type, Newtonsoft.Json.Serialization.JsonObjectContract contract);
                /*0xa15c30*/ void GenerateISerializableContract(System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract);
                /*0xa15a68*/ Newtonsoft.Json.Schema.JsonSchemaType GetJsonSchemaType(System.Type type, Newtonsoft.Json.Required valueRequired);

                class TypeSchema
                {
                    /*0x10*/ System.Type <Type>k__BackingField;
                    /*0x18*/ Newtonsoft.Json.Schema.JsonSchema <Schema>k__BackingField;

                    /*0xa154f0*/ TypeSchema(System.Type type, Newtonsoft.Json.Schema.JsonSchema schema);
                    /*0xa15cd8*/ System.Type get_Type();
                    /*0xa15ce0*/ Newtonsoft.Json.Schema.JsonSchema get_Schema();
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ System.Type type;

                    /*0xa1540c*/ <>c__DisplayClass23_0();
                    /*0xa15ce8*/ bool <GenerateInternal>b__0(Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema tc);
                }
            }

            class JsonSchemaModel
            {
                /*0x10*/ bool <Required>k__BackingField;
                /*0x14*/ Newtonsoft.Json.Schema.JsonSchemaType <Type>k__BackingField;
                /*0x18*/ System.Nullable<int> <MinimumLength>k__BackingField;
                /*0x20*/ System.Nullable<int> <MaximumLength>k__BackingField;
                /*0x28*/ System.Nullable<double> <DivisibleBy>k__BackingField;
                /*0x38*/ System.Nullable<double> <Minimum>k__BackingField;
                /*0x48*/ System.Nullable<double> <Maximum>k__BackingField;
                /*0x58*/ bool <ExclusiveMinimum>k__BackingField;
                /*0x59*/ bool <ExclusiveMaximum>k__BackingField;
                /*0x5c*/ System.Nullable<int> <MinimumItems>k__BackingField;
                /*0x64*/ System.Nullable<int> <MaximumItems>k__BackingField;
                /*0x70*/ System.Collections.Generic.IList<string> <Patterns>k__BackingField;
                /*0x78*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> <Items>k__BackingField;
                /*0x80*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaModel> <Properties>k__BackingField;
                /*0x88*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaModel> <PatternProperties>k__BackingField;
                /*0x90*/ Newtonsoft.Json.Schema.JsonSchemaModel <AdditionalProperties>k__BackingField;
                /*0x98*/ Newtonsoft.Json.Schema.JsonSchemaModel <AdditionalItems>k__BackingField;
                /*0xa0*/ bool <PositionalItemsValidation>k__BackingField;
                /*0xa1*/ bool <AllowAdditionalProperties>k__BackingField;
                /*0xa2*/ bool <AllowAdditionalItems>k__BackingField;
                /*0xa3*/ bool <UniqueItems>k__BackingField;
                /*0xa8*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> <Enum>k__BackingField;
                /*0xb0*/ Newtonsoft.Json.Schema.JsonSchemaType <Disallow>k__BackingField;

                static /*0xa15f1c*/ Newtonsoft.Json.Schema.JsonSchemaModel Create(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> schemata);
                static /*0xa1622c*/ void Combine(Newtonsoft.Json.Schema.JsonSchemaModel model, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa15ef0*/ JsonSchemaModel();
                /*0xa15d58*/ bool get_Required();
                /*0xa15d60*/ void set_Required(bool value);
                /*0xa15d6c*/ Newtonsoft.Json.Schema.JsonSchemaType get_Type();
                /*0xa15d74*/ void set_Type(Newtonsoft.Json.Schema.JsonSchemaType value);
                /*0xa15d7c*/ System.Nullable<int> get_MinimumLength();
                /*0xa15d84*/ void set_MinimumLength(System.Nullable<int> value);
                /*0xa15d8c*/ System.Nullable<int> get_MaximumLength();
                /*0xa15d94*/ void set_MaximumLength(System.Nullable<int> value);
                /*0xa15d9c*/ System.Nullable<double> get_DivisibleBy();
                /*0xa15da8*/ void set_DivisibleBy(System.Nullable<double> value);
                /*0xa15db0*/ System.Nullable<double> get_Minimum();
                /*0xa15dbc*/ void set_Minimum(System.Nullable<double> value);
                /*0xa15dc4*/ System.Nullable<double> get_Maximum();
                /*0xa15dd0*/ void set_Maximum(System.Nullable<double> value);
                /*0xa15dd8*/ bool get_ExclusiveMinimum();
                /*0xa15de0*/ void set_ExclusiveMinimum(bool value);
                /*0xa15dec*/ bool get_ExclusiveMaximum();
                /*0xa15df4*/ void set_ExclusiveMaximum(bool value);
                /*0xa15e00*/ System.Nullable<int> get_MinimumItems();
                /*0xa15e08*/ void set_MinimumItems(System.Nullable<int> value);
                /*0xa15e10*/ System.Nullable<int> get_MaximumItems();
                /*0xa15e18*/ void set_MaximumItems(System.Nullable<int> value);
                /*0xa15e20*/ System.Collections.Generic.IList<string> get_Patterns();
                /*0xa15e28*/ void set_Patterns(System.Collections.Generic.IList<string> value);
                /*0xa15e30*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> get_Items();
                /*0xa15e38*/ void set_Items(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchemaModel> value);
                /*0xa15e40*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaModel> get_Properties();
                /*0xa15e48*/ void set_Properties(System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaModel> value);
                /*0xa15e50*/ System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaModel> get_PatternProperties();
                /*0xa15e58*/ void set_PatternProperties(System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaModel> value);
                /*0xa15e60*/ Newtonsoft.Json.Schema.JsonSchemaModel get_AdditionalProperties();
                /*0xa15e68*/ void set_AdditionalProperties(Newtonsoft.Json.Schema.JsonSchemaModel value);
                /*0xa15e70*/ Newtonsoft.Json.Schema.JsonSchemaModel get_AdditionalItems();
                /*0xa15e78*/ void set_AdditionalItems(Newtonsoft.Json.Schema.JsonSchemaModel value);
                /*0xa15e80*/ bool get_PositionalItemsValidation();
                /*0xa15e88*/ void set_PositionalItemsValidation(bool value);
                /*0xa15e94*/ bool get_AllowAdditionalProperties();
                /*0xa15e9c*/ void set_AllowAdditionalProperties(bool value);
                /*0xa15ea8*/ bool get_AllowAdditionalItems();
                /*0xa15eb0*/ void set_AllowAdditionalItems(bool value);
                /*0xa15ebc*/ bool get_UniqueItems();
                /*0xa15ec4*/ void set_UniqueItems(bool value);
                /*0xa15ed0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_Enum();
                /*0xa15ed8*/ void set_Enum(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> value);
                /*0xa15ee0*/ Newtonsoft.Json.Schema.JsonSchemaType get_Disallow();
                /*0xa15ee8*/ void set_Disallow(Newtonsoft.Json.Schema.JsonSchemaType value);
            }

            class JsonSchemaModelBuilder
            {
                /*0x10*/ Newtonsoft.Json.Schema.JsonSchemaNodeCollection _nodes;
                /*0x18*/ System.Collections.Generic.Dictionary<Newtonsoft.Json.Schema.JsonSchemaNode, Newtonsoft.Json.Schema.JsonSchemaModel> _nodeModels;
                /*0x20*/ Newtonsoft.Json.Schema.JsonSchemaNode _node;

                /*0xa17dbc*/ JsonSchemaModelBuilder();
                /*0xa16544*/ Newtonsoft.Json.Schema.JsonSchemaModel Build(Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa16654*/ Newtonsoft.Json.Schema.JsonSchemaNode AddSchema(Newtonsoft.Json.Schema.JsonSchemaNode existingNode, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa177d8*/ void AddProperties(System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> source, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaNode> target);
                /*0xa17c78*/ void AddProperty(System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchemaNode> target, string propertyName, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa17ad4*/ void AddItem(Newtonsoft.Json.Schema.JsonSchemaNode parentNode, int index, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa17c54*/ void AddAdditionalProperties(Newtonsoft.Json.Schema.JsonSchemaNode parentNode, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa17c30*/ void AddAdditionalItems(Newtonsoft.Json.Schema.JsonSchemaNode parentNode, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa16c8c*/ Newtonsoft.Json.Schema.JsonSchemaModel BuildNodeModel(Newtonsoft.Json.Schema.JsonSchemaNode node);
            }

            class JsonSchemaNode
            {
                /*0x10*/ string <Id>k__BackingField;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<Newtonsoft.Json.Schema.JsonSchema> <Schemas>k__BackingField;
                /*0x20*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Schema.JsonSchemaNode> <Properties>k__BackingField;
                /*0x28*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Schema.JsonSchemaNode> <PatternProperties>k__BackingField;
                /*0x30*/ System.Collections.Generic.List<Newtonsoft.Json.Schema.JsonSchemaNode> <Items>k__BackingField;
                /*0x38*/ Newtonsoft.Json.Schema.JsonSchemaNode <AdditionalProperties>k__BackingField;
                /*0x40*/ Newtonsoft.Json.Schema.JsonSchemaNode <AdditionalItems>k__BackingField;

                static /*0xa17390*/ string GetId(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Schema.JsonSchema> schemata);
                /*0xa175cc*/ JsonSchemaNode(Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa17eac*/ JsonSchemaNode(Newtonsoft.Json.Schema.JsonSchemaNode source, Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa17e64*/ string get_Id();
                /*0xa17e6c*/ System.Collections.ObjectModel.ReadOnlyCollection<Newtonsoft.Json.Schema.JsonSchema> get_Schemas();
                /*0xa17e74*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Schema.JsonSchemaNode> get_Properties();
                /*0xa17e7c*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Schema.JsonSchemaNode> get_PatternProperties();
                /*0xa17e84*/ System.Collections.Generic.List<Newtonsoft.Json.Schema.JsonSchemaNode> get_Items();
                /*0xa17e8c*/ Newtonsoft.Json.Schema.JsonSchemaNode get_AdditionalProperties();
                /*0xa17e94*/ void set_AdditionalProperties(Newtonsoft.Json.Schema.JsonSchemaNode value);
                /*0xa17e9c*/ Newtonsoft.Json.Schema.JsonSchemaNode get_AdditionalItems();
                /*0xa17ea4*/ void set_AdditionalItems(Newtonsoft.Json.Schema.JsonSchemaNode value);
                /*0xa17768*/ Newtonsoft.Json.Schema.JsonSchemaNode Combine(Newtonsoft.Json.Schema.JsonSchema schema);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Schema.JsonSchemaNode.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Schema.JsonSchema, string> <>9__26_0;
                    static /*0x10*/ System.Func<string, string> <>9__26_1;

                    static /*0xa180c4*/ <>c();
                    /*0xa18128*/ <>c();
                    /*0xa18130*/ string <GetId>b__26_0(Newtonsoft.Json.Schema.JsonSchema s);
                    /*0xa18148*/ string <GetId>b__26_1(string id);
                }
            }

            class JsonSchemaNodeCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Schema.JsonSchemaNode>
            {
                /*0xa1660c*/ JsonSchemaNodeCollection();
                /*0xa18150*/ string GetKeyForItem(Newtonsoft.Json.Schema.JsonSchemaNode item);
            }

            class JsonSchemaResolver
            {
                /*0x10*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> <LoadedSchemas>k__BackingField;

                /*0xa0e388*/ JsonSchemaResolver();
                /*0xa18168*/ System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> get_LoadedSchemas();
                /*0xa18170*/ void set_LoadedSchemas(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> value);
                /*0xa18178*/ Newtonsoft.Json.Schema.JsonSchema GetSchema(string reference);

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ string reference;

                    /*0xa182b8*/ <>c__DisplayClass5_0();
                    /*0xa182c0*/ bool <GetSchema>b__0(Newtonsoft.Json.Schema.JsonSchema s);
                    /*0xa182e8*/ bool <GetSchema>b__1(Newtonsoft.Json.Schema.JsonSchema s);
                }
            }

            enum JsonSchemaType
            {
                None = 0,
                String = 1,
                Float = 2,
                Integer = 4,
                Boolean = 8,
                Object = 16,
                Array = 32,
                Null = 64,
                Any = 127,
            }

            class JsonSchemaWriter
            {
                /*0x10*/ Newtonsoft.Json.JsonWriter _writer;
                /*0x18*/ Newtonsoft.Json.Schema.JsonSchemaResolver _resolver;

                /*0xa0e9f8*/ JsonSchemaWriter(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Schema.JsonSchemaResolver resolver);
                /*0xa18310*/ void ReferenceOrWriteSchema(Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa0ea68*/ void WriteSchema(Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa18998*/ void WriteSchemaDictionaryIfNotNull(Newtonsoft.Json.JsonWriter writer, string propertyName, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> properties);
                /*0xa18d24*/ void WriteItems(Newtonsoft.Json.Schema.JsonSchema schema);
                /*0xa18458*/ void WriteType(string propertyName, Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Schema.JsonSchemaType type);
                /*0xa183f4*/ void WritePropertyIfNotNull(Newtonsoft.Json.JsonWriter writer, string propertyName, object value);

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Schema.JsonSchemaWriter.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Schema.JsonSchemaType, bool> <>9__7_0;

                    static /*0xa191d8*/ <>c();
                    /*0xa1923c*/ <>c();
                    /*0xa19244*/ bool <WriteType>b__7_0(Newtonsoft.Json.Schema.JsonSchemaType v);
                }
            }

            enum UndefinedSchemaIdHandling
            {
                None = 0,
                UseTypeName = 1,
                UseAssemblyQualifiedName = 2,
            }

            class ValidationEventArgs : System.EventArgs
            {
                /*0x10*/ Newtonsoft.Json.Schema.JsonSchemaException _ex;

                /*0xa19250*/ ValidationEventArgs(Newtonsoft.Json.Schema.JsonSchemaException ex);
                /*0xa192e0*/ Newtonsoft.Json.Schema.JsonSchemaException get_Exception();
                /*0xa192e8*/ string get_Path();
                /*0xa0e01c*/ string get_Message();
            }

            class ValidationEventHandler : System.MulticastDelegate
            {
                /*0xa0da4c*/ ValidationEventHandler(object object, nint method);
                /*0xa19304*/ void Invoke(object sender, Newtonsoft.Json.Schema.ValidationEventArgs e);
                /*0xa19318*/ System.IAsyncResult BeginInvoke(object sender, Newtonsoft.Json.Schema.ValidationEventArgs e, System.AsyncCallback callback, object object);
                /*0xa19340*/ void EndInvoke(System.IAsyncResult result);
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

            class Extensions
            {
                static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Ancestors<T>(System.Collections.Generic.IEnumerable<T> source);
                static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> AncestorsAndSelf<T>(System.Collections.Generic.IEnumerable<T> source);
                static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Descendants<T>(System.Collections.Generic.IEnumerable<T> source);
                static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> DescendantsAndSelf<T>(System.Collections.Generic.IEnumerable<T> source);
                static /*0xa1934c*/ Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JProperty> Properties(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject> source);
                static /*0xa19484*/ Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Values(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source, object key);
                static /*0xa19528*/ Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Values(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source);
                static System.Collections.Generic.IEnumerable<U> Values<U>(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source, object key);
                static System.Collections.Generic.IEnumerable<U> Values<U>(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source);
                static U Value<U>(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value);
                static U Value<T, U>(System.Collections.Generic.IEnumerable<T> value);
                static System.Collections.Generic.IEnumerable<U> Values<T, U>(System.Collections.Generic.IEnumerable<T> source, object key);
                static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Children<T>(System.Collections.Generic.IEnumerable<T> source);
                static System.Collections.Generic.IEnumerable<U> Children<T, U>(System.Collections.Generic.IEnumerable<T> source);
                static System.Collections.Generic.IEnumerable<U> Convert<T, U>(System.Collections.Generic.IEnumerable<T> source);
                static U Convert<T, U>(T token);
                static /*0xa194e0*/ Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> AsJEnumerable(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source);
                static Newtonsoft.Json.Linq.IJEnumerable<T> AsJEnumerable<T>(System.Collections.Generic.IEnumerable<T> source);

                class <>c__0<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.Extensions.<>c__0<T> <>9;
                    static /*0x0*/ System.Func<T, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> <>9__0_0;

                    static <>c__0();
                    <>c__0();
                    System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <Ancestors>b__0_0(T j);
                }

                class <>c__<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.Extensions.<>c__1<T> <>9;
                    static /*0x0*/ System.Func<T, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> <>9__1_0;

                    static <>c__();
                    <>c__();
                    System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <AncestorsAndSelf>b__1_0(T j);
                }

                class <>c__2<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.Extensions.<>c__2<T> <>9;
                    static /*0x0*/ System.Func<T, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> <>9__2_0;

                    static <>c__2();
                    <>c__2();
                    System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <Descendants>b__2_0(T j);
                }

                class <>c__3<T>
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.Extensions.<>c__3<T> <>9;
                    static /*0x0*/ System.Func<T, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> <>9__3_0;

                    static <>c__3();
                    <>c__3();
                    System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <DescendantsAndSelf>b__3_0(T j);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.Extensions.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JObject, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty>> <>9__4_0;

                    static /*0xa19530*/ <>c();
                    /*0xa19594*/ <>c();
                    /*0xa1959c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> <Properties>b__4_0(Newtonsoft.Json.Linq.JObject d);
                }

                class <Values>d__11<T, U> : System.Collections.Generic.IEnumerable<U>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<U>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ U <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                    /*0x0*/ object key;
                    /*0x0*/ object <>3__key;
                    /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;
                    /*0x0*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap2;

                    <Values>d__11(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    void <>m__Finally1();
                    void <>m__Finally2();
                    void <>m__Finally3();
                    U System.Collections.Generic.IEnumerator<U>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <>c__13<T, U>
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.Extensions.<>c__13<T, U> <>9;
                    static /*0x0*/ System.Func<T, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> <>9__13_0;

                    static <>c__13();
                    <>c__13();
                    System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <Children>b__13_0(T c);
                }

                class <Convert>d__14<T, U> : System.Collections.Generic.IEnumerable<U>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<U>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ U <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                    /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                    <Convert>d__14(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    void <>m__Finally1();
                    U System.Collections.Generic.IEnumerator<U>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            interface IJEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> get_Item(object key);
            }

            class JArray : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
            {
                /*0x58*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0xa196a8*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JArray> LoadAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xa196b4*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JArray> LoadAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                static /*0xa19a68*/ Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader);
                static /*0xa19a70*/ Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xa19c28*/ Newtonsoft.Json.Linq.JArray Parse(string json);
                static /*0xa19c30*/ Newtonsoft.Json.Linq.JArray Parse(string json, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xa19e18*/ Newtonsoft.Json.Linq.JArray FromObject(object o);
                static /*0xa19e38*/ Newtonsoft.Json.Linq.JArray FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0xa197cc*/ JArray();
                /*0xa19848*/ JArray(Newtonsoft.Json.Linq.JArray other);
                /*0xa198d4*/ JArray(object[] content);
                /*0xa198d8*/ JArray(object content);
                /*0xa195b4*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xa197bc*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0xa197c4*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0xa19978*/ bool DeepEquals(Newtonsoft.Json.Linq.JToken node);
                /*0xa19a08*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0xa19fc8*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xa1a09c*/ Newtonsoft.Json.Linq.JToken get_Item(object key);
                /*0xa1a1c8*/ void set_Item(object key, Newtonsoft.Json.Linq.JToken value);
                /*0xa1a2fc*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                /*0xa1a30c*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0xa1a31c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0xa1a380*/ void MergeItem(object content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xa1a46c*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0xa1a47c*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0xa1a490*/ void RemoveAt(int index);
                /*0xa1a4a0*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                /*0xa1a510*/ void Add(Newtonsoft.Json.Linq.JToken item);
                /*0xa1a520*/ void Clear();
                /*0xa1a530*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                /*0xa1a540*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0xa1a550*/ bool get_IsReadOnly();
                /*0xa1a558*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
                /*0xa1a568*/ int GetDeepHashCode();

                struct <WriteToAsync>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonWriter writer;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Newtonsoft.Json.Linq.JArray <>4__this;
                    /*0x48*/ Newtonsoft.Json.JsonConverter[] converters;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x60*/ int <i>5__2;

                    /*0xa1a570*/ void MoveNext();
                    /*0xa1a8e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <LoadAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Newtonsoft.Json.Linq.JArray> <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Newtonsoft.Json.Linq.JsonLoadSettings settings;
                    /*0x48*/ Newtonsoft.Json.Linq.JArray <a>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0xa1a8ec*/ void MoveNext();
                    /*0xa1ae44*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class JConstructor : Newtonsoft.Json.Linq.JContainer
            {
                /*0x58*/ string _name;
                /*0x60*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;

                static /*0xbf79ac*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JConstructor> LoadAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xbf79b8*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JConstructor> LoadAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                static /*0xbf9a60*/ Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader);
                static /*0xbf9a68*/ Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0xbf89c8*/ JConstructor();
                /*0xbf8a98*/ JConstructor(Newtonsoft.Json.Linq.JConstructor other);
                /*0xbf8e70*/ JConstructor(string name, object[] content);
                /*0xbf8ea4*/ JConstructor(string name, object content);
                /*0xbf8ed8*/ JConstructor(string name);
                /*0xbf78b8*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xbf7ac0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0xbf7ac8*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0xbf7b2c*/ void MergeItem(object content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xbf89b0*/ string get_Name();
                /*0xbf89b8*/ void set_Name(string value);
                /*0xbf89c0*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0xbf9008*/ bool DeepEquals(Newtonsoft.Json.Linq.JToken node);
                /*0xbf9370*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0xbf93d0*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xbf94b8*/ Newtonsoft.Json.Linq.JToken get_Item(object key);
                /*0xbf95e4*/ void set_Item(object key, Newtonsoft.Json.Linq.JToken value);
                /*0xbf9718*/ int GetDeepHashCode();

                struct <WriteToAsync>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonWriter writer;
                    /*0x38*/ Newtonsoft.Json.Linq.JConstructor <>4__this;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ Newtonsoft.Json.JsonConverter[] converters;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x60*/ int <i>5__2;

                    /*0xbf9f7c*/ void MoveNext();
                    /*0xbfa320*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <LoadAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Newtonsoft.Json.Linq.JConstructor> <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Newtonsoft.Json.Linq.JsonLoadSettings settings;
                    /*0x48*/ Newtonsoft.Json.Linq.JConstructor <c>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0xbfa32c*/ void MoveNext();
                    /*0xbfa9cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.ComponentModel.ITypedList, System.ComponentModel.IBindingList, System.Collections.ICollection, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged
            {
                /*0x30*/ System.ComponentModel.ListChangedEventHandler _listChanged;
                /*0x38*/ System.ComponentModel.AddingNewEventHandler _addingNew;
                /*0x40*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;
                /*0x48*/ object _syncRoot;
                /*0x50*/ bool _busy;

                static /*0xbfc8c0*/ bool IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue);
                static /*0xbfd6b4*/ Newtonsoft.Json.Linq.JToken CreateFromContent(object content);
                static /*0xbfdcdc*/ Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent);
                static /*0xbf7bdc*/ void MergeEnumerableContent(Newtonsoft.Json.Linq.JContainer target, System.Collections.IEnumerable content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xbf8a40*/ JContainer();
                /*0xbf8b30*/ JContainer(Newtonsoft.Json.Linq.JContainer other);
                /*0xbfa8d8*/ System.Threading.Tasks.Task ReadTokenFromAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options, System.Threading.CancellationToken cancellationToken);
                /*0xbfaa24*/ System.Threading.Tasks.Task ReadContentFromAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                /*0xbfab1c*/ void add_ListChanged(System.ComponentModel.ListChangedEventHandler value);
                /*0xbfab9c*/ void remove_ListChanged(System.ComponentModel.ListChangedEventHandler value);
                /*0xbfac1c*/ void add_AddingNew(System.ComponentModel.AddingNewEventHandler value);
                /*0xbfac9c*/ void remove_AddingNew(System.ComponentModel.AddingNewEventHandler value);
                /*0xbfad1c*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0xbfad9c*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0xbfb23c*/ void CheckReentrancy();
                /*0xbfb2ec*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> CreateChildrenCollection();
                /*0xbfb35c*/ void OnAddingNew(System.ComponentModel.AddingNewEventArgs e);
                /*0xbfb384*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
                /*0xbfb40c*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0xbfb494*/ bool get_HasValues();
                /*0xbf90b4*/ bool ContentsEqual(Newtonsoft.Json.Linq.JContainer container);
                /*0xbfb554*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0xbfb690*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0xbfb7cc*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                System.Collections.Generic.IEnumerable<T> Values<T>();
                /*0xbfb840*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Descendants();
                /*0xbfb8d4*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> DescendantsAndSelf();
                /*0xbfb848*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> GetDescendants(bool self);
                /*0xbfb910*/ bool IsMultiContent(object content);
                /*0xbfb9f4*/ Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0xbfbaa8*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                /*0xbfbe98*/ void RemoveItemAt(int index);
                /*0xbfc2f8*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0xbfc344*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0xbfc400*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0xbfc97c*/ void ClearItems();
                /*0xbfcd9c*/ void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement);
                /*0xbfce00*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0xbfce24*/ void CopyItemsTo(System.Array array, int arrayIndex);
                /*0xbfd318*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0xbfd440*/ void Add(object content);
                /*0xbfd50c*/ bool TryAdd(object content);
                /*0xbfd5d8*/ void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token);
                /*0xbfd6a4*/ void AddFirst(object content);
                /*0xbfae24*/ bool TryAddInternal(int index, object content, bool skipParentCheck);
                /*0xbfd760*/ Newtonsoft.Json.JsonWriter CreateWriter();
                /*0xbfd7c4*/ void ReplaceAll(object content);
                /*0xbfd808*/ void RemoveAll();
                void MergeItem(object content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xbfd818*/ void Merge(object content);
                /*0xbfd82c*/ void Merge(object content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xbf9e14*/ void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options);
                /*0xbfd83c*/ void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0xbf975c*/ int ContentsHashCode();
                /*0xbfe174*/ string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors);
                /*0xbfe1bc*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors);
                /*0xbfe284*/ int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item);
                /*0xbfe294*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item);
                /*0xbfe2a8*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index);
                /*0xbfe2b8*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index);
                /*0xbfe2c8*/ void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, Newtonsoft.Json.Linq.JToken value);
                /*0xbfe2d8*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item);
                /*0xbfe2e8*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear();
                /*0xbfe2f8*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item);
                /*0xbfe308*/ void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                /*0xbfe318*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly();
                /*0xbfe320*/ bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item);
                /*0xbfe330*/ Newtonsoft.Json.Linq.JToken EnsureValue(object value);
                /*0xbfe3f0*/ int System.Collections.IList.Add(object value);
                /*0xbfe428*/ void System.Collections.IList.Clear();
                /*0xbfe438*/ bool System.Collections.IList.Contains(object value);
                /*0xbfe460*/ int System.Collections.IList.IndexOf(object value);
                /*0xbfe488*/ void System.Collections.IList.Insert(int index, object value);
                /*0xbfe4c8*/ bool System.Collections.IList.get_IsFixedSize();
                /*0xbfe4d0*/ bool System.Collections.IList.get_IsReadOnly();
                /*0xbfe4d8*/ void System.Collections.IList.Remove(object value);
                /*0xbfe500*/ void System.Collections.IList.RemoveAt(int index);
                /*0xbfe510*/ object System.Collections.IList.get_Item(int index);
                /*0xbfe520*/ void System.Collections.IList.set_Item(int index, object value);
                /*0xbfe55c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0xbfd264*/ int get_Count();
                /*0xbfe56c*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0xbfe574*/ object System.Collections.ICollection.get_SyncRoot();
                /*0xbfe5f0*/ void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property);
                /*0xbfe5f4*/ object System.ComponentModel.IBindingList.AddNew();
                /*0xbfe7bc*/ bool System.ComponentModel.IBindingList.get_AllowEdit();
                /*0xbfe7c4*/ bool System.ComponentModel.IBindingList.get_AllowNew();
                /*0xbfe7cc*/ bool System.ComponentModel.IBindingList.get_AllowRemove();
                /*0xbfe7d4*/ void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
                /*0xbfe814*/ int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key);
                /*0xbfe854*/ bool System.ComponentModel.IBindingList.get_IsSorted();
                /*0xbfe85c*/ void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property);
                /*0xbfe860*/ void System.ComponentModel.IBindingList.RemoveSort();
                /*0xbfe8a0*/ System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.get_SortDirection();
                /*0xbfe8a8*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty();
                /*0xbfe8b0*/ bool System.ComponentModel.IBindingList.get_SupportsChangeNotification();
                /*0xbfe8b8*/ bool System.ComponentModel.IBindingList.get_SupportsSearching();
                /*0xbfe8c0*/ bool System.ComponentModel.IBindingList.get_SupportsSorting();

                struct <ReadTokenFromAsync>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Newtonsoft.Json.Linq.JContainer <>4__this;
                    /*0x48*/ Newtonsoft.Json.Linq.JsonLoadSettings options;
                    /*0x50*/ int <startDepth>5__2;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                    /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0xbfe98c*/ void MoveNext();
                    /*0xbfee38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ReadContentFromAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ Newtonsoft.Json.Linq.JContainer <>4__this;
                    /*0x40*/ Newtonsoft.Json.Linq.JsonLoadSettings settings;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ Newtonsoft.Json.IJsonLineInfo <lineInfo>5__2;
                    /*0x58*/ Newtonsoft.Json.Linq.JContainer <parent>5__3;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;

                    /*0xbfee44*/ void MoveNext();
                    /*0xbff6e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <GetDescendants>d__36 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x24*/ bool self;
                    /*0x25*/ bool <>3__self;
                    /*0x28*/ Newtonsoft.Json.Linq.JContainer <>4__this;
                    /*0x30*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                    /*0x38*/ Newtonsoft.Json.Linq.JToken <o>5__3;
                    /*0x40*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap3;

                    /*0xbfb8dc*/ <GetDescendants>d__36(int <>1__state);
                    /*0xbff6f4*/ void System.IDisposable.Dispose();
                    /*0xbff7a8*/ bool MoveNext();
                    /*0xbffd14*/ void <>m__Finally1();
                    /*0xbffc64*/ void <>m__Finally2();
                    /*0xbffdc4*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                    /*0xbffdcc*/ void System.Collections.IEnumerator.Reset();
                    /*0xbffe0c*/ object System.Collections.IEnumerator.get_Current();
                    /*0xbffe14*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                    /*0xbffec0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            struct JEnumerable<T> : Newtonsoft.Json.Linq.IJEnumerable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>>
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JEnumerable<T> Empty;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> _enumerable;

                static JEnumerable();
                JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> get_Item(object key);
                bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other);
                bool Equals(object obj);
                int GetHashCode();
            }

            class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.INotifyPropertyChanging
            {
                /*0x58*/ Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;
                /*0x60*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
                /*0x68*/ System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

                static /*0xc0016c*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JObject> LoadAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xc00178*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JObject> LoadAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                static /*0xc01340*/ bool IsNull(Newtonsoft.Json.Linq.JToken token);
                static /*0xc01b00*/ Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader);
                static /*0xc01b08*/ Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xc01cdc*/ Newtonsoft.Json.Linq.JObject Parse(string json);
                static /*0xc01ce4*/ Newtonsoft.Json.Linq.JObject Parse(string json, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xc01ecc*/ Newtonsoft.Json.Linq.JObject FromObject(object o);
                static /*0xc01eec*/ Newtonsoft.Json.Linq.JObject FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0xbfdc7c*/ JObject();
                /*0xc00588*/ JObject(Newtonsoft.Json.Linq.JObject other);
                /*0xc005f8*/ JObject(object[] content);
                /*0xc005fc*/ JObject(object content);
                /*0xbffec4*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc00280*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0xc00288*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0xc00324*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0xc003c0*/ void add_PropertyChanging(System.ComponentModel.PropertyChangingEventHandler value);
                /*0xc0045c*/ void remove_PropertyChanging(System.ComponentModel.PropertyChangingEventHandler value);
                /*0xc00680*/ bool DeepEquals(Newtonsoft.Json.Linq.JToken node);
                /*0xc00a70*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0xc00b3c*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                /*0xc00ba8*/ void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing);
                /*0xc00e3c*/ void MergeItem(object content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xc01464*/ void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0xc015b8*/ void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty);
                /*0xc015dc*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0xc0163c*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0xc01644*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties();
                /*0xc0168c*/ Newtonsoft.Json.Linq.JProperty Property(string name);
                /*0xbfdedc*/ Newtonsoft.Json.Linq.JProperty Property(string name, System.StringComparison comparison);
                /*0xc01694*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> PropertyValues();
                /*0xc017d0*/ Newtonsoft.Json.Linq.JToken get_Item(object key);
                /*0xc01968*/ void set_Item(object key, Newtonsoft.Json.Linq.JToken value);
                /*0xc018e8*/ Newtonsoft.Json.Linq.JToken get_Item(string propertyName);
                /*0xc01a88*/ void set_Item(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0xc02280*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc02370*/ Newtonsoft.Json.Linq.JToken GetValue(string propertyName);
                /*0xc02378*/ Newtonsoft.Json.Linq.JToken GetValue(string propertyName, System.StringComparison comparison);
                /*0xc023a8*/ bool TryGetValue(string propertyName, System.StringComparison comparison, ref Newtonsoft.Json.Linq.JToken value);
                /*0xc012bc*/ void Add(string propertyName, Newtonsoft.Json.Linq.JToken value);
                /*0xc024c0*/ bool ContainsKey(string propertyName);
                /*0xc025dc*/ System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys();
                /*0xc0264c*/ bool Remove(string propertyName);
                /*0xc026dc*/ bool TryGetValue(string propertyName, ref Newtonsoft.Json.Linq.JToken value);
                /*0xc02718*/ System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values();
                /*0xc02758*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0xc027f4*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear();
                /*0xc02804*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0xc02884*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> array, int arrayIndex);
                /*0xc02d00*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly();
                /*0xc02d08*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item);
                /*0xc02e4c*/ int GetDeepHashCode();
                /*0xc01254*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> GetEnumerator();
                /*0xc02e78*/ void OnPropertyChanged(string propertyName);
                /*0xc02f10*/ void OnPropertyChanging(string propertyName);
                /*0xc02fa8*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0xc03044*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0xc033b4*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0xc0340c*/ string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
                /*0xc03414*/ string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
                /*0xc0341c*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0xc03478*/ System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
                /*0xc03480*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
                /*0xc03488*/ object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType);
                /*0xc03490*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes);
                /*0xc034e8*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
                /*0xc03540*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                /*0xc035bc*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0xc00064*/ System.Threading.Tasks.Task <WriteToAsync>g__AwaitProperties|0_0(System.Threading.Tasks.Task task, int i, Newtonsoft.Json.JsonWriter Writer, System.Threading.CancellationToken CancellationToken, Newtonsoft.Json.JsonConverter[] Converters);

                class JObjectDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JObject>
                {
                    /*0xc03670*/ JObjectDynamicProxy();
                    /*0xc036b8*/ bool TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, ref object result);
                    /*0xc036ec*/ bool TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, object value);
                    /*0xc037c0*/ System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance);

                    class <>c
                    {
                        static /*0x0*/ Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<> <>9;
                        static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JProperty, string> <>9__2_0;

                        static /*0xc038d0*/ <>c();
                        /*0xc03934*/ <>c();
                        /*0xc0393c*/ string <GetDynamicMemberNames>b__2_0(Newtonsoft.Json.Linq.JProperty p);
                    }
                }

                struct <LoadAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Newtonsoft.Json.Linq.JObject> <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Newtonsoft.Json.Linq.JsonLoadSettings settings;
                    /*0x48*/ Newtonsoft.Json.Linq.JObject <o>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0xc03954*/ void MoveNext();
                    /*0xc03ecc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.JObject.<> <>9;
                    static /*0x8*/ System.Func<Newtonsoft.Json.Linq.JProperty, Newtonsoft.Json.Linq.JToken> <>9__30_0;

                    static /*0xc03f24*/ <>c();
                    /*0xc03f88*/ <>c();
                    /*0xc03f90*/ Newtonsoft.Json.Linq.JToken <PropertyValues>b__30_0(Newtonsoft.Json.Linq.JProperty p);
                }

                class <GetEnumerator>d__63 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> <>2__current;
                    /*0x28*/ Newtonsoft.Json.Linq.JObject <>4__this;
                    /*0x30*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;

                    /*0xc02e50*/ <GetEnumerator>d__63(int <>1__state);
                    /*0xc03fb0*/ void System.IDisposable.Dispose();
                    /*0xc03fcc*/ bool MoveNext();
                    /*0xc042b0*/ void <>m__Finally1();
                    /*0xc04360*/ System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current();
                    /*0xc0436c*/ void System.Collections.IEnumerator.Reset();
                    /*0xc043ac*/ object System.Collections.IEnumerator.get_Current();
                }

                struct <<WriteToAsync>g__AwaitProperties|0_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.Tasks.Task task;
                    /*0x38*/ Newtonsoft.Json.Linq.JObject <>4__this;
                    /*0x40*/ int i;
                    /*0x48*/ Newtonsoft.Json.JsonWriter Writer;
                    /*0x50*/ System.Threading.CancellationToken CancellationToken;
                    /*0x58*/ Newtonsoft.Json.JsonConverter[] Converters;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xc04408*/ void MoveNext();
                    /*0xc04778*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class JProperty : Newtonsoft.Json.Linq.JContainer
            {
                /*0x58*/ Newtonsoft.Json.Linq.JProperty.JPropertyList _content;
                /*0x60*/ string _name;

                static /*0xc0499c*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JProperty> LoadAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xc049a8*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JProperty> LoadAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                static /*0xc05330*/ Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader);
                static /*0xc05338*/ Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0xc04ac0*/ JProperty(Newtonsoft.Json.Linq.JProperty other);
                /*0xbfe060*/ JProperty(string name);
                /*0xc0525c*/ JProperty(string name, object[] content);
                /*0xc023cc*/ JProperty(string name, object content);
                /*0xc04784*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc048a4*/ System.Threading.Tasks.Task WriteToAsync(System.Threading.Tasks.Task task, Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc04858*/ System.Threading.Tasks.Task WriteValueAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc04ab0*/ System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens();
                /*0xc04ab8*/ string get_Name();
                /*0xbfdc60*/ Newtonsoft.Json.Linq.JToken get_Value();
                /*0xc013e4*/ void set_Value(Newtonsoft.Json.Linq.JToken value);
                /*0xc04b4c*/ Newtonsoft.Json.Linq.JToken GetItem(int index);
                /*0xc04ba8*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0xc04cf4*/ bool RemoveItem(Newtonsoft.Json.Linq.JToken item);
                /*0xc04da8*/ void RemoveItemAt(int index);
                /*0xc04e5c*/ int IndexOfItem(Newtonsoft.Json.Linq.JToken item);
                /*0xc04e9c*/ bool InsertItem(int index, Newtonsoft.Json.Linq.JToken item, bool skipParentCheck);
                /*0xc04fb8*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0xc04fdc*/ void MergeItem(object content, Newtonsoft.Json.Linq.JsonMergeSettings settings);
                /*0xc05094*/ void ClearItems();
                /*0xc05148*/ bool DeepEquals(Newtonsoft.Json.Linq.JToken node);
                /*0xc051f4*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0xc05254*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0xc05260*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc052e0*/ int GetDeepHashCode();

                class JPropertyList : System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JToken _token;

                    /*0xc04b44*/ JPropertyList();
                    /*0xc05544*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator();
                    /*0xc055d4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0xc055d8*/ void Add(Newtonsoft.Json.Linq.JToken item);
                    /*0xc055e0*/ void Clear();
                    /*0xc055e8*/ bool Contains(Newtonsoft.Json.Linq.JToken item);
                    /*0xc055f8*/ void CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex);
                    /*0xc0565c*/ bool Remove(Newtonsoft.Json.Linq.JToken item);
                    /*0xc0567c*/ int get_Count();
                    /*0xc0568c*/ bool get_IsReadOnly();
                    /*0xc04e8c*/ int IndexOf(Newtonsoft.Json.Linq.JToken item);
                    /*0xc05694*/ void Insert(int index, Newtonsoft.Json.Linq.JToken item);
                    /*0xc056a4*/ void RemoveAt(int index);
                    /*0xc056b4*/ Newtonsoft.Json.Linq.JToken get_Item(int index);
                    /*0xc05704*/ void set_Item(int index, Newtonsoft.Json.Linq.JToken value);

                    class <GetEnumerator>d__1 : System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ Newtonsoft.Json.Linq.JProperty.JPropertyList <>4__this;

                        /*0xc055ac*/ <GetEnumerator>d__1(int <>1__state);
                        /*0xc05754*/ void System.IDisposable.Dispose();
                        /*0xc05758*/ bool MoveNext();
                        /*0xc057b8*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xc057c0*/ void System.Collections.IEnumerator.Reset();
                        /*0xc05800*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                struct <WriteToAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.Tasks.Task task;
                    /*0x38*/ Newtonsoft.Json.Linq.JProperty <>4__this;
                    /*0x40*/ Newtonsoft.Json.JsonWriter writer;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ Newtonsoft.Json.JsonConverter[] converters;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xc05808*/ void MoveNext();
                    /*0xc05a2c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <LoadAsync>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Newtonsoft.Json.Linq.JProperty> <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Newtonsoft.Json.Linq.JsonLoadSettings settings;
                    /*0x48*/ Newtonsoft.Json.Linq.JProperty <p>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0xc05a38*/ void MoveNext();
                    /*0xc05fe4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                static /*0xc0603c*/ Newtonsoft.Json.Linq.JObject CastInstance(object instance);
                /*0xc033a8*/ JPropertyDescriptor(string name);
                /*0xc060b8*/ bool CanResetValue(object component);
                /*0xc060c0*/ object GetValue(object component);
                /*0xc0615c*/ void ResetValue(object component);
                /*0xc06160*/ void SetValue(object component, object value);
                /*0xc06290*/ bool ShouldSerializeValue(object component);
                /*0xc06298*/ System.Type get_ComponentType();
                /*0xc06304*/ bool get_IsReadOnly();
                /*0xc0630c*/ System.Type get_PropertyType();
                /*0xc06378*/ int get_NameHashCode();
            }

            class JPropertyKeyedCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.Linq.JToken>
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<string> Comparer;
                /*0x18*/ System.Collections.Generic.Dictionary<string, Newtonsoft.Json.Linq.JToken> _dictionary;

                static /*0xc06d90*/ JPropertyKeyedCollection();
                /*0xc004f8*/ JPropertyKeyedCollection();
                /*0xc06380*/ void AddKey(string key, Newtonsoft.Json.Linq.JToken item);
                /*0xc064a0*/ void ChangeItemKey(Newtonsoft.Json.Linq.JToken item, string newKey);
                /*0xc06794*/ void ClearItems();
                /*0xc0252c*/ bool Contains(string key);
                /*0xc06628*/ bool ContainsItem(Newtonsoft.Json.Linq.JToken item);
                /*0xc063f0*/ void EnsureDictionary();
                /*0xc066b4*/ string GetKeyForItem(Newtonsoft.Json.Linq.JToken item);
                /*0xc0680c*/ void InsertItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0xc06884*/ bool Remove(string key);
                /*0xc06970*/ void RemoveItem(int index);
                /*0xc06734*/ void RemoveKey(string key);
                /*0xc06a64*/ void SetItem(int index, Newtonsoft.Json.Linq.JToken item);
                /*0xc06c6c*/ Newtonsoft.Json.Linq.JToken get_Item(string key);
                /*0xc00dc4*/ bool TryGetValue(string key, ref Newtonsoft.Json.Linq.JToken value);
                /*0xc025f4*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0xc06d38*/ System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> get_Values();
                /*0xc00a98*/ int IndexOfReference(Newtonsoft.Json.Linq.JToken t);
                /*0xc0071c*/ bool Compare(Newtonsoft.Json.Linq.JPropertyKeyedCollection other);
            }

            class JRaw : Newtonsoft.Json.Linq.JValue
            {
                static /*0xc06e38*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JRaw> CreateAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xc06f48*/ Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader);
                /*0xc06f34*/ JRaw(Newtonsoft.Json.Linq.JRaw other);
                /*0xc06f3c*/ JRaw(object rawJson);
                /*0xc072c0*/ Newtonsoft.Json.Linq.JToken CloneToken();

                struct <CreateAsync>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Newtonsoft.Json.Linq.JRaw> <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.IO.StringWriter <sw>5__2;
                    /*0x48*/ Newtonsoft.Json.JsonTextWriter <jsonWriter>5__3;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xc07324*/ void MoveNext();
                    /*0xc078bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class JsonLoadSettings
            {
                /*0x10*/ Newtonsoft.Json.Linq.CommentHandling _commentHandling;
                /*0x14*/ Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;
                /*0x18*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

                /*0xc07914*/ JsonLoadSettings();
                /*0xc0793c*/ Newtonsoft.Json.Linq.CommentHandling get_CommentHandling();
                /*0xc07944*/ void set_CommentHandling(Newtonsoft.Json.Linq.CommentHandling value);
                /*0xc079a8*/ Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling();
                /*0xc079b0*/ void set_LineInfoHandling(Newtonsoft.Json.Linq.LineInfoHandling value);
                /*0xc07a14*/ Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling();
                /*0xc07a1c*/ void set_DuplicatePropertyNameHandling(Newtonsoft.Json.Linq.DuplicatePropertyNameHandling value);
            }

            class JsonMergeSettings
            {
                /*0x10*/ Newtonsoft.Json.Linq.MergeArrayHandling _mergeArrayHandling;
                /*0x14*/ Newtonsoft.Json.Linq.MergeNullValueHandling _mergeNullValueHandling;
                /*0x18*/ System.StringComparison _propertyNameComparison;

                /*0xc07a80*/ JsonMergeSettings();
                /*0xc07aa0*/ Newtonsoft.Json.Linq.MergeArrayHandling get_MergeArrayHandling();
                /*0xc07aa8*/ void set_MergeArrayHandling(Newtonsoft.Json.Linq.MergeArrayHandling value);
                /*0xc07b0c*/ Newtonsoft.Json.Linq.MergeNullValueHandling get_MergeNullValueHandling();
                /*0xc07b14*/ void set_MergeNullValueHandling(Newtonsoft.Json.Linq.MergeNullValueHandling value);
                /*0xc07b78*/ System.StringComparison get_PropertyNameComparison();
                /*0xc07b80*/ void set_PropertyNameComparison(System.StringComparison value);
            }

            class JsonSelectSettings
            {
                /*0x10*/ bool <ErrorWhenNoMatch>k__BackingField;

                /*0xc07bf8*/ JsonSelectSettings();
                /*0xc07be4*/ bool get_ErrorWhenNoMatch();
                /*0xc07bec*/ void set_ErrorWhenNoMatch(bool value);
            }

            class JToken : Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, Newtonsoft.Json.IJsonLineInfo, System.ICloneable, System.Dynamic.IDynamicMetaObjectProvider
            {
                static /*0x0*/ Newtonsoft.Json.Linq.JTokenEqualityComparer _equalityComparer;
                static /*0x8*/ Newtonsoft.Json.Linq.JTokenType[] BooleanTypes;
                static /*0x10*/ Newtonsoft.Json.Linq.JTokenType[] NumberTypes;
                static /*0x18*/ Newtonsoft.Json.Linq.JTokenType[] BigIntegerTypes;
                static /*0x20*/ Newtonsoft.Json.Linq.JTokenType[] StringTypes;
                static /*0x28*/ Newtonsoft.Json.Linq.JTokenType[] GuidTypes;
                static /*0x30*/ Newtonsoft.Json.Linq.JTokenType[] TimeSpanTypes;
                static /*0x38*/ Newtonsoft.Json.Linq.JTokenType[] UriTypes;
                static /*0x40*/ Newtonsoft.Json.Linq.JTokenType[] CharTypes;
                static /*0x48*/ Newtonsoft.Json.Linq.JTokenType[] DateTimeTypes;
                static /*0x50*/ Newtonsoft.Json.Linq.JTokenType[] BytesTypes;
                /*0x10*/ Newtonsoft.Json.Linq.JContainer _parent;
                /*0x18*/ Newtonsoft.Json.Linq.JToken _previous;
                /*0x20*/ Newtonsoft.Json.Linq.JToken _next;
                /*0x28*/ object _annotations;

                static /*0xc1155c*/ JToken();
                static /*0xc07c54*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JToken> ReadFromAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xc07cbc*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JToken> ReadFromAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                static /*0xc07dcc*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JToken> LoadAsync(Newtonsoft.Json.JsonReader reader, System.Threading.CancellationToken cancellationToken);
                static /*0xc07e34*/ System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JToken> LoadAsync(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings, System.Threading.CancellationToken cancellationToken);
                static /*0xbfe8c8*/ Newtonsoft.Json.Linq.JTokenEqualityComparer get_EqualityComparer();
                static /*0xc07eb8*/ bool DeepEquals(Newtonsoft.Json.Linq.JToken t1, Newtonsoft.Json.Linq.JToken t2);
                static /*0xc08b48*/ Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value);
                static /*0xc08c60*/ string GetType(Newtonsoft.Json.Linq.JToken token);
                static /*0xc08d54*/ bool ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, bool nullable);
                static /*0xc08e20*/ bool op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc09030*/ System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc09284*/ System.Nullable<bool> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc094d4*/ long op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc096c0*/ System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc098dc*/ System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc09ba8*/ System.Nullable<decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc09df0*/ System.Nullable<double> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0a018*/ System.Nullable<char> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0a244*/ int op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0a430*/ short op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0a61c*/ ushort op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0a808*/ char op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0a9f4*/ byte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0abe0*/ sbyte op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0adcc*/ System.Nullable<int> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0aff8*/ System.Nullable<short> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0b224*/ System.Nullable<ushort> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0b450*/ System.Nullable<byte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0b67c*/ System.Nullable<sbyte> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0b8a8*/ System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0ba8c*/ System.Nullable<long> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0bcb8*/ System.Nullable<float> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0bee0*/ decimal op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0c0cc*/ System.Nullable<uint> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0c2f8*/ System.Nullable<ulong> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0c524*/ double op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0c710*/ float op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0c8fc*/ string op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0cb54*/ uint op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0cd40*/ ulong op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0cf2c*/ byte[] op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0d168*/ System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0d390*/ System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0d5fc*/ System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0d800*/ System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0da48*/ System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0dc4c*/ System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0dda0*/ System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value);
                static /*0xc0df54*/ Newtonsoft.Json.Linq.JToken op_Implicit(bool value);
                static /*0xc0dfb8*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.DateTimeOffset value);
                static /*0xc0e02c*/ Newtonsoft.Json.Linq.JToken op_Implicit(byte value);
                static /*0xc0e090*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<byte> value);
                static /*0xc0e128*/ Newtonsoft.Json.Linq.JToken op_Implicit(sbyte value);
                static /*0xc0e18c*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<sbyte> value);
                static /*0xc0e224*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<bool> value);
                static /*0xc0e2bc*/ Newtonsoft.Json.Linq.JToken op_Implicit(long value);
                static /*0xc0e320*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<System.DateTime> value);
                static /*0xc0e3c4*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<System.DateTimeOffset> value);
                static /*0xc0e470*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<decimal> value);
                static /*0xc0e53c*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<double> value);
                static /*0xc0e5e0*/ Newtonsoft.Json.Linq.JToken op_Implicit(short value);
                static /*0xc0e644*/ Newtonsoft.Json.Linq.JToken op_Implicit(ushort value);
                static /*0xc0e6a8*/ Newtonsoft.Json.Linq.JToken op_Implicit(int value);
                static /*0xc0e70c*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<int> value);
                static /*0xc0e7a4*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.DateTime value);
                static /*0xc0e808*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<long> value);
                static /*0xc0e8ac*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<float> value);
                static /*0xc0e944*/ Newtonsoft.Json.Linq.JToken op_Implicit(decimal value);
                static /*0xc0e9b8*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<short> value);
                static /*0xc0ea50*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<ushort> value);
                static /*0xc0eae8*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<uint> value);
                static /*0xc0eb80*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<ulong> value);
                static /*0xc0ec24*/ Newtonsoft.Json.Linq.JToken op_Implicit(double value);
                static /*0xc0ec90*/ Newtonsoft.Json.Linq.JToken op_Implicit(float value);
                static /*0xc0ecfc*/ Newtonsoft.Json.Linq.JToken op_Implicit(string value);
                static /*0xc0ed60*/ Newtonsoft.Json.Linq.JToken op_Implicit(uint value);
                static /*0xc0edc4*/ Newtonsoft.Json.Linq.JToken op_Implicit(ulong value);
                static /*0xc0ee28*/ Newtonsoft.Json.Linq.JToken op_Implicit(byte[] value);
                static /*0xc0ee8c*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Uri value);
                static /*0xc0eef0*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.TimeSpan value);
                static /*0xc0ef54*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<System.TimeSpan> value);
                static /*0xc0eff8*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Guid value);
                static /*0xc0f06c*/ Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable<System.Guid> value);
                static /*0xc02078*/ Newtonsoft.Json.Linq.JToken FromObjectInternal(object o, Newtonsoft.Json.JsonSerializer jsonSerializer);
                static /*0xc0f2f8*/ Newtonsoft.Json.Linq.JToken FromObject(object o);
                static /*0xc0f360*/ Newtonsoft.Json.Linq.JToken FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer);
                static /*0xc100e8*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader);
                static /*0xc10140*/ Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xc10440*/ Newtonsoft.Json.Linq.JToken Parse(string json);
                static /*0xc10498*/ Newtonsoft.Json.Linq.JToken Parse(string json, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xc106a8*/ Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                static /*0xc1070c*/ Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader);
                /*0xbfae1c*/ JToken();
                /*0xc07c00*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc07c40*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc07ea8*/ Newtonsoft.Json.Linq.JContainer get_Parent();
                /*0xc07eb0*/ void set_Parent(Newtonsoft.Json.Linq.JContainer value);
                /*0xbfba90*/ Newtonsoft.Json.Linq.JToken get_Root();
                Newtonsoft.Json.Linq.JToken CloneToken();
                bool DeepEquals(Newtonsoft.Json.Linq.JToken node);
                Newtonsoft.Json.Linq.JTokenType get_Type();
                bool get_HasValues();
                /*0xc07ee8*/ Newtonsoft.Json.Linq.JToken get_Next();
                /*0xc07ef0*/ void set_Next(Newtonsoft.Json.Linq.JToken value);
                /*0xc07ef8*/ Newtonsoft.Json.Linq.JToken get_Previous();
                /*0xc07f00*/ void set_Previous(Newtonsoft.Json.Linq.JToken value);
                /*0xc07f08*/ string get_Path();
                /*0xc08250*/ void AddAfterSelf(object content);
                /*0xc082f0*/ void AddBeforeSelf(object content);
                /*0xc08390*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Ancestors();
                /*0xc08424*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> AncestorsAndSelf();
                /*0xc08398*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> GetAncestors(bool self);
                /*0xc08460*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> AfterSelf();
                /*0xc0850c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> BeforeSelf();
                /*0xc085b8*/ Newtonsoft.Json.Linq.JToken get_Item(object key);
                /*0xc08650*/ void set_Item(object key, Newtonsoft.Json.Linq.JToken value);
                T Value<T>(object key);
                /*0xc086e8*/ Newtonsoft.Json.Linq.JToken get_First();
                /*0xc08780*/ Newtonsoft.Json.Linq.JToken get_Last();
                /*0xc08818*/ Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children();
                Newtonsoft.Json.Linq.JEnumerable<T> Children<T>();
                System.Collections.Generic.IEnumerable<T> Values<T>();
                /*0xc0266c*/ void Remove();
                /*0xbfe0fc*/ void Replace(Newtonsoft.Json.Linq.JToken value);
                void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc08870*/ string ToString();
                /*0xc088f8*/ string ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters);
                /*0xc0f118*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0xc0f1ac*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                int GetDeepHashCode();
                /*0xc0f21c*/ Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(object key);
                /*0xc0f22c*/ Newtonsoft.Json.JsonReader CreateReader();
                T ToObject<T>();
                /*0xc0f3c4*/ object ToObject(System.Type objectType);
                T ToObject<T>(Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0xc0ff0c*/ object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer);
                /*0xbf9c74*/ void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings);
                /*0xc10764*/ void SetLineInfo(int lineNumber, int linePosition);
                /*0xc10a24*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0xc10a78*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0xc10acc*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0xc10b20*/ Newtonsoft.Json.Linq.JToken SelectToken(string path);
                /*0xc10ea4*/ Newtonsoft.Json.Linq.JToken SelectToken(string path, bool errorWhenNoMatch);
                /*0xc10b28*/ Newtonsoft.Json.Linq.JToken SelectToken(string path, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                /*0xc10f30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> SelectTokens(string path);
                /*0xc10fbc*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> SelectTokens(string path, bool errorWhenNoMatch);
                /*0xc10f38*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> SelectTokens(string path, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                /*0xc11048*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0xc11114*/ System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0xc11124*/ object System.ICloneable.Clone();
                /*0xc11134*/ Newtonsoft.Json.Linq.JToken DeepClone();
                /*0xc10808*/ void AddAnnotation(object annotation);
                T Annotation<T>();
                /*0xc11144*/ object Annotation(System.Type type);
                System.Collections.Generic.IEnumerable<T> Annotations<T>();
                /*0xc112bc*/ System.Collections.Generic.IEnumerable<object> Annotations(System.Type type);
                void RemoveAnnotations<T>();
                /*0xc11374*/ void RemoveAnnotations(System.Type type);
                /*0xbfb1ac*/ void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source);

                class LineInfoAnnotation
                {
                    /*0x10*/ int LineNumber;
                    /*0x14*/ int LinePosition;

                    /*0xc107dc*/ LineInfoAnnotation(int lineNumber, int linePosition);
                }

                struct <ReadFromAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Newtonsoft.Json.Linq.JToken> <>t__builder;
                    /*0x30*/ Newtonsoft.Json.JsonReader reader;
                    /*0x38*/ Newtonsoft.Json.Linq.JsonLoadSettings settings;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Newtonsoft.Json.Linq.JObject> <>u__2;
                    /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Newtonsoft.Json.Linq.JArray> <>u__3;
                    /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Newtonsoft.Json.Linq.JConstructor> <>u__4;
                    /*0x88*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Newtonsoft.Json.Linq.JProperty> <>u__5;

                    /*0xc11810*/ void MoveNext();
                    /*0xc1215c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <GetAncestors>d__48 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x24*/ bool self;
                    /*0x25*/ bool <>3__self;
                    /*0x28*/ Newtonsoft.Json.Linq.JToken <>4__this;
                    /*0x30*/ Newtonsoft.Json.Linq.JToken <current>5__2;

                    /*0xc0842c*/ <GetAncestors>d__48(int <>1__state);
                    /*0xc121b4*/ void System.IDisposable.Dispose();
                    /*0xc121b8*/ bool MoveNext();
                    /*0xc1222c*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                    /*0xc12234*/ void System.Collections.IEnumerator.Reset();
                    /*0xc12274*/ object System.Collections.IEnumerator.get_Current();
                    /*0xc1227c*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                    /*0xc12328*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <AfterSelf>d__49 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ Newtonsoft.Json.Linq.JToken <>4__this;
                    /*0x30*/ Newtonsoft.Json.Linq.JToken <o>5__2;

                    /*0xc084d8*/ <AfterSelf>d__49(int <>1__state);
                    /*0xc1232c*/ void System.IDisposable.Dispose();
                    /*0xc12330*/ bool MoveNext();
                    /*0xc123b0*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                    /*0xc123b8*/ void System.Collections.IEnumerator.Reset();
                    /*0xc123f8*/ object System.Collections.IEnumerator.get_Current();
                    /*0xc12400*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                    /*0xc124a4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <BeforeSelf>d__50 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ Newtonsoft.Json.Linq.JToken <>4__this;
                    /*0x30*/ Newtonsoft.Json.Linq.JToken <o>5__2;

                    /*0xc08584*/ <BeforeSelf>d__50(int <>1__state);
                    /*0xc124a8*/ void System.IDisposable.Dispose();
                    /*0xc124ac*/ bool MoveNext();
                    /*0xc12548*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                    /*0xc12550*/ void System.Collections.IEnumerator.Reset();
                    /*0xc12590*/ object System.Collections.IEnumerator.get_Current();
                    /*0xc12598*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                    /*0xc1263c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <Annotations>d__184<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ Newtonsoft.Json.Linq.JToken <>4__this;
                    /*0x0*/ object[] <annotations>5__2;
                    /*0x0*/ int <i>5__3;

                    <Annotations>d__184(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    T System.Collections.Generic.IEnumerator<T>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <Annotations>d__185 : System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Type type;
                    /*0x30*/ System.Type <>3__type;
                    /*0x38*/ Newtonsoft.Json.Linq.JToken <>4__this;
                    /*0x40*/ object[] <annotations>5__2;
                    /*0x48*/ int <i>5__3;

                    /*0xc11340*/ <Annotations>d__185(int <>1__state);
                    /*0xc12640*/ void System.IDisposable.Dispose();
                    /*0xc12644*/ bool MoveNext();
                    /*0xc1283c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xc12844*/ void System.Collections.IEnumerator.Reset();
                    /*0xc12884*/ object System.Collections.IEnumerator.get_Current();
                    /*0xc1288c*/ System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
                    /*0xc12938*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class JTokenEqualityComparer : System.Collections.Generic.IEqualityComparer<Newtonsoft.Json.Linq.JToken>
            {
                /*0xc07ea0*/ JTokenEqualityComparer();
                /*0xc1293c*/ bool Equals(Newtonsoft.Json.Linq.JToken x, Newtonsoft.Json.Linq.JToken y);
                /*0xc129d4*/ int GetHashCode(Newtonsoft.Json.Linq.JToken obj);
            }

            class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
            {
                /*0x78*/ Newtonsoft.Json.Linq.JToken _root;
                /*0x80*/ string _initialPath;
                /*0x88*/ Newtonsoft.Json.Linq.JToken _parent;
                /*0x90*/ Newtonsoft.Json.Linq.JToken _current;

                /*0xc0f28c*/ JTokenReader(Newtonsoft.Json.Linq.JToken token);
                /*0xc12a00*/ JTokenReader(Newtonsoft.Json.Linq.JToken token, string initialPath);
                /*0xc129f8*/ Newtonsoft.Json.Linq.JToken get_CurrentToken();
                /*0xc12a24*/ bool Read();
                /*0xc12b5c*/ bool ReadOver(Newtonsoft.Json.Linq.JToken t);
                /*0xc131b8*/ bool ReadToEnd();
                /*0xc1325c*/ System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c);
                /*0xc12af4*/ bool ReadInto(Newtonsoft.Json.Linq.JContainer c);
                /*0xc131d8*/ bool SetEnd(Newtonsoft.Json.Linq.JContainer c);
                /*0xc12c10*/ void SetToken(Newtonsoft.Json.Linq.JToken token);
                /*0xc133ac*/ string SafeToString(object value);
                /*0xc133cc*/ bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo();
                /*0xc13480*/ int Newtonsoft.Json.IJsonLineInfo.get_LineNumber();
                /*0xc13538*/ int Newtonsoft.Json.IJsonLineInfo.get_LinePosition();
                /*0xc135f0*/ string get_Path();
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

                /*0xb04264*/ JTokenWriter(Newtonsoft.Json.Linq.JContainer container);
                /*0xb042f4*/ JTokenWriter();
                /*0xb04134*/ System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, System.Threading.CancellationToken cancellationToken);
                /*0xb04240*/ Newtonsoft.Json.Linq.JToken get_CurrentToken();
                /*0xb04248*/ Newtonsoft.Json.Linq.JToken get_Token();
                /*0xb0434c*/ void Flush();
                /*0xb04350*/ void Close();
                /*0xb04358*/ void WriteStartObject();
                /*0xb043e4*/ void AddParent(Newtonsoft.Json.Linq.JContainer container);
                /*0xb04424*/ void RemoveParent();
                /*0xb04478*/ void WriteStartArray();
                /*0xb04504*/ void WriteStartConstructor(string name);
                /*0xb045a4*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
                /*0xb045a8*/ void WritePropertyName(string name);
                /*0xb04690*/ void AddValue(object value, Newtonsoft.Json.JsonToken token);
                /*0xb04744*/ void AddValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token);
                /*0xb04830*/ void WriteValue(object value);
                /*0xb048bc*/ void WriteNull();
                /*0xb048dc*/ void WriteUndefined();
                /*0xb048fc*/ void WriteRaw(string json);
                /*0xb04980*/ void WriteComment(string text);
                /*0xb04a18*/ void WriteValue(string value);
                /*0xb04a48*/ void WriteValue(int value);
                /*0xb04ac4*/ void WriteValue(uint value);
                /*0xb04b40*/ void WriteValue(long value);
                /*0xb04bbc*/ void WriteValue(ulong value);
                /*0xb04c38*/ void WriteValue(float value);
                /*0xb04cb4*/ void WriteValue(double value);
                /*0xb04d30*/ void WriteValue(bool value);
                /*0xb04dac*/ void WriteValue(short value);
                /*0xb04e28*/ void WriteValue(ushort value);
                /*0xb04ea4*/ void WriteValue(char value);
                /*0xb04f3c*/ void WriteValue(byte value);
                /*0xb04fb8*/ void WriteValue(sbyte value);
                /*0xb05034*/ void WriteValue(decimal value);
                /*0xb050e8*/ void WriteValue(System.DateTime value);
                /*0xb051a0*/ void WriteValue(System.DateTimeOffset value);
                /*0xb0522c*/ void WriteValue(byte[] value);
                /*0xb0525c*/ void WriteValue(System.TimeSpan value);
                /*0xb052d8*/ void WriteValue(System.Guid value);
                /*0xb05364*/ void WriteValue(System.Uri value);
                /*0xb05394*/ void WriteToken(Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments);
            }

            class JValue : Newtonsoft.Json.Linq.JToken, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IConvertible
            {
                /*0x30*/ Newtonsoft.Json.Linq.JTokenType _valueType;
                /*0x38*/ object _value;

                static /*0xb069cc*/ int CompareBigInteger(System.Numerics.BigInteger i1, object i2);
                static /*0xb06ca4*/ int Compare(Newtonsoft.Json.Linq.JTokenType valueType, object objA, object objB);
                static /*0xb07618*/ int CompareFloat(object objA, object objB);
                static /*0xb07714*/ bool Operation(System.Linq.Expressions.ExpressionType operation, object objA, object objB, ref object result);
                static /*0xb049b4*/ Newtonsoft.Json.Linq.JValue CreateComment(string value);
                static /*0xb07ffc*/ Newtonsoft.Json.Linq.JValue CreateString(string value);
                static /*0xb047d0*/ Newtonsoft.Json.Linq.JValue CreateNull();
                static /*0xb08060*/ Newtonsoft.Json.Linq.JValue CreateUndefined();
                static /*0xb06498*/ Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value);
                static /*0xb080c0*/ Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current);
                static /*0xb06968*/ bool ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2);
                /*0xb05e14*/ JValue(object value, Newtonsoft.Json.Linq.JTokenType type);
                /*0xb05e88*/ JValue(Newtonsoft.Json.Linq.JValue other);
                /*0xb05f1c*/ JValue(long value);
                /*0xb05f88*/ JValue(decimal value);
                /*0xb06028*/ JValue(char value);
                /*0xb06094*/ JValue(ulong value);
                /*0xb06100*/ JValue(double value);
                /*0xb0616c*/ JValue(float value);
                /*0xb061d8*/ JValue(System.DateTime value);
                /*0xb06244*/ JValue(System.DateTimeOffset value);
                /*0xb062bc*/ JValue(bool value);
                /*0xb06328*/ JValue(string value);
                /*0xb06330*/ JValue(System.Guid value);
                /*0xb063a8*/ JValue(System.Uri value);
                /*0xb0642c*/ JValue(System.TimeSpan value);
                /*0xb04714*/ JValue(object value);
                /*0xb05608*/ System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter writer, System.Threading.CancellationToken cancellationToken, Newtonsoft.Json.JsonConverter[] converters);
                /*0xb068cc*/ bool DeepEquals(Newtonsoft.Json.Linq.JToken node);
                /*0xb069c4*/ bool get_HasValues();
                /*0xb07f9c*/ Newtonsoft.Json.Linq.JToken CloneToken();
                /*0xb0813c*/ Newtonsoft.Json.Linq.JTokenType get_Type();
                /*0xb08144*/ object get_Value();
                /*0xb0814c*/ void set_Value(object value);
                /*0xb08238*/ void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters);
                /*0xb089ec*/ int GetDeepHashCode();
                /*0xb08a40*/ bool Equals(Newtonsoft.Json.Linq.JValue other);
                /*0xb08a50*/ bool Equals(object obj);
                /*0xb08adc*/ int GetHashCode();
                /*0xb08af4*/ string ToString();
                /*0xb08b5c*/ string ToString(string format);
                /*0xb08ce4*/ string ToString(System.IFormatProvider formatProvider);
                /*0xb08bcc*/ string ToString(string format, System.IFormatProvider formatProvider);
                /*0xb08cf0*/ System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
                /*0xb08dec*/ int System.IComparable.CompareTo(object obj);
                /*0xb08ea8*/ int CompareTo(Newtonsoft.Json.Linq.JValue obj);
                /*0xb08eec*/ System.TypeCode System.IConvertible.GetTypeCode();
                /*0xb08fa8*/ bool System.IConvertible.ToBoolean(System.IFormatProvider provider);
                /*0xb09000*/ char System.IConvertible.ToChar(System.IFormatProvider provider);
                /*0xb09058*/ sbyte System.IConvertible.ToSByte(System.IFormatProvider provider);
                /*0xb090b0*/ byte System.IConvertible.ToByte(System.IFormatProvider provider);
                /*0xb09108*/ short System.IConvertible.ToInt16(System.IFormatProvider provider);
                /*0xb09160*/ ushort System.IConvertible.ToUInt16(System.IFormatProvider provider);
                /*0xb091b8*/ int System.IConvertible.ToInt32(System.IFormatProvider provider);
                /*0xb09210*/ uint System.IConvertible.ToUInt32(System.IFormatProvider provider);
                /*0xb09268*/ long System.IConvertible.ToInt64(System.IFormatProvider provider);
                /*0xb092c0*/ ulong System.IConvertible.ToUInt64(System.IFormatProvider provider);
                /*0xb09318*/ float System.IConvertible.ToSingle(System.IFormatProvider provider);
                /*0xb09370*/ double System.IConvertible.ToDouble(System.IFormatProvider provider);
                /*0xb093c8*/ decimal System.IConvertible.ToDecimal(System.IFormatProvider provider);
                /*0xb09420*/ System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider);
                /*0xb09478*/ object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider);

                class JValueDynamicProxy : Newtonsoft.Json.Utilities.DynamicProxy<Newtonsoft.Json.Linq.JValue>
                {
                    /*0xb08da4*/ JValueDynamicProxy();
                    /*0xb09480*/ bool TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, ref object result);
                    /*0xb0964c*/ bool TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, object arg, ref object result);
                }
            }

            enum LineInfoHandling
            {
                Ignore = 0,
                Load = 1,
            }

            enum MergeArrayHandling
            {
                Concat = 0,
                Union = 1,
                Replace = 2,
                Merge = 3,
            }

            enum MergeNullValueHandling
            {
                Ignore = 0,
                Merge = 1,
            }

            namespace JsonPath
            {
                class ArrayIndexFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ System.Nullable<int> <Index>k__BackingField;

                    /*0xb09a20*/ ArrayIndexFilter();
                    /*0xb09950*/ System.Nullable<int> get_Index();
                    /*0xb09958*/ void set_Index(System.Nullable<int> value);
                    /*0xb09960*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__4 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.ArrayIndexFilter <>4__this;
                        /*0x40*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x48*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x50*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x58*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap2;

                        /*0xb099ec*/ <ExecuteFilter>d__4(int <>1__state);
                        /*0xb09a30*/ void System.IDisposable.Dispose();
                        /*0xb09ae4*/ bool MoveNext();
                        /*0xb0a450*/ void <>m__Finally1();
                        /*0xb0a3a0*/ void <>m__Finally2();
                        /*0xb0a500*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb0a508*/ void System.Collections.IEnumerator.Reset();
                        /*0xb0a548*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb0a550*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb0a604*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class ArrayMultipleIndexFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ System.Collections.Generic.List<int> Indexes;

                    /*0xb0a608*/ ArrayMultipleIndexFilter(System.Collections.Generic.List<int> indexes);
                    /*0xb0a630*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter <>4__this;
                        /*0x40*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x48*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x50*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x58*/ Newtonsoft.Json.Linq.JToken <t>5__3;
                        /*0x60*/ System.Collections.Generic.List.Enumerator<int> <>7__wrap3;

                        /*0xb0a6bc*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb0a6f0*/ void System.IDisposable.Dispose();
                        /*0xb0a7a8*/ bool MoveNext();
                        /*0xb0ab54*/ void <>m__Finally1();
                        /*0xb0ab04*/ void <>m__Finally2();
                        /*0xb0ac04*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb0ac0c*/ void System.Collections.IEnumerator.Reset();
                        /*0xb0ac4c*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb0ac54*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb0ad08*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class ArraySliceFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ System.Nullable<int> <Start>k__BackingField;
                    /*0x18*/ System.Nullable<int> <End>k__BackingField;
                    /*0x20*/ System.Nullable<int> <Step>k__BackingField;

                    /*0xb0ae18*/ ArraySliceFilter();
                    /*0xb0ad0c*/ System.Nullable<int> get_Start();
                    /*0xb0ad14*/ void set_Start(System.Nullable<int> value);
                    /*0xb0ad1c*/ System.Nullable<int> get_End();
                    /*0xb0ad24*/ void set_End(System.Nullable<int> value);
                    /*0xb0ad2c*/ System.Nullable<int> get_Step();
                    /*0xb0ad34*/ void set_Step(System.Nullable<int> value);
                    /*0xb0ad3c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                    /*0xb0ae00*/ bool IsValid(int index, int stopIndex, bool positiveStep);

                    class <ExecuteFilter>d__12 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter <>4__this;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x38*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x40*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x48*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x50*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x58*/ Newtonsoft.Json.Linq.JArray <a>5__3;
                        /*0x60*/ int <stepCount>5__4;
                        /*0x64*/ int <stopIndex>5__5;
                        /*0x68*/ bool <positiveStep>5__6;
                        /*0x6c*/ int <i>5__7;

                        /*0xb0adcc*/ <ExecuteFilter>d__12(int <>1__state);
                        /*0xb0ae20*/ void System.IDisposable.Dispose();
                        /*0xb0ae3c*/ bool MoveNext();
                        /*0xb0b78c*/ void <>m__Finally1();
                        /*0xb0b83c*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb0b844*/ void System.Collections.IEnumerator.Reset();
                        /*0xb0b884*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb0b88c*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb0b940*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class FieldFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ string Name;

                    /*0xb0b944*/ FieldFilter(string name);
                    /*0xb0b96c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.FieldFilter <>4__this;
                        /*0x40*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x48*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x50*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x58*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> <>7__wrap2;

                        /*0xb0b9f8*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb0ba2c*/ void System.IDisposable.Dispose();
                        /*0xb0bae0*/ bool MoveNext();
                        /*0xb0c1fc*/ void <>m__Finally1();
                        /*0xb0c14c*/ void <>m__Finally2();
                        /*0xb0c2ac*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb0c2b4*/ void System.Collections.IEnumerator.Reset();
                        /*0xb0c2f4*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb0c2fc*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb0c3b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class FieldMultipleFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ System.Collections.Generic.List<string> Names;

                    /*0xb0c3b4*/ FieldMultipleFilter(System.Collections.Generic.List<string> names);
                    /*0xb0c3dc*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <>c
                    {
                        static /*0x0*/ Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter.<> <>9;
                        static /*0x8*/ System.Func<string, string> <>9__2_0;

                        static /*0xb0c49c*/ <>c();
                        /*0xb0c500*/ <>c();
                        /*0xb0c508*/ string <ExecuteFilter>b__2_0(string n);
                    }

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter <>4__this;
                        /*0x40*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x48*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x50*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x58*/ Newtonsoft.Json.Linq.JObject <o>5__3;
                        /*0x60*/ System.Collections.Generic.List.Enumerator<string> <>7__wrap3;
                        /*0x78*/ string <name>5__5;

                        /*0xb0c468*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb0c558*/ void System.IDisposable.Dispose();
                        /*0xb0c610*/ bool MoveNext();
                        /*0xb0cd54*/ void <>m__Finally1();
                        /*0xb0cd04*/ void <>m__Finally2();
                        /*0xb0ce04*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb0ce0c*/ void System.Collections.IEnumerator.Reset();
                        /*0xb0ce4c*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb0ce54*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb0cf08*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class JPath
                {
                    static /*0x0*/ char[] FloatCharacters;
                    /*0x10*/ string _expression;
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.PathFilter> <Filters>k__BackingField;
                    /*0x20*/ int _currentIndex;

                    static /*0xb0fd1c*/ JPath();
                    static /*0xb0d788*/ Newtonsoft.Json.Linq.JsonPath.PathFilter CreatePathFilter(string member, bool scan);
                    static /*0xb0fb4c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Evaluate(System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.PathFilter> filters, Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                    /*0xb0cf14*/ JPath(string expression);
                    /*0xb0cf0c*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.PathFilter> get_Filters();
                    /*0xb0cfcc*/ void ParseMain();
                    /*0xb0d180*/ bool ParsePath(System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.PathFilter> filters, int currentPartStartIndex, bool query);
                    /*0xb0d810*/ Newtonsoft.Json.Linq.JsonPath.PathFilter ParseIndexer(char indexerOpenChar, bool scan);
                    /*0xb0df0c*/ Newtonsoft.Json.Linq.JsonPath.PathFilter ParseArrayIndexer(char indexerCloseChar);
                    /*0xb0d12c*/ void EatWhitespace();
                    /*0xb0dd38*/ Newtonsoft.Json.Linq.JsonPath.PathFilter ParseQuery(char indexerCloseChar, bool scan);
                    /*0xb0ebac*/ bool TryParseExpression(ref System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.PathFilter> expressionPath);
                    /*0xb0eda0*/ Newtonsoft.Json.JsonException CreateUnexpectedCharacterException();
                    /*0xb0ee5c*/ object ParseSide();
                    /*0xb0e6a4*/ Newtonsoft.Json.Linq.JsonPath.QueryExpression ParseExpression();
                    /*0xb0ef70*/ bool TryParseValue(ref object value);
                    /*0xb0f6b0*/ string ReadQuotedString();
                    /*0xb0f934*/ string ReadRegexString();
                    /*0xb0f580*/ bool Match(string s);
                    /*0xb0f2dc*/ Newtonsoft.Json.Linq.JsonPath.QueryOperator ParseOperator();
                    /*0xb0d9b4*/ Newtonsoft.Json.Linq.JsonPath.PathFilter ParseQuotedField(char indexerCloseChar, bool scan);
                    /*0xb0d940*/ void EnsureLength(string message);
                    /*0xb0facc*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Evaluate(Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                }

                class PathFilter
                {
                    static /*0xb0a0d4*/ Newtonsoft.Json.Linq.JToken GetTokenIndex(Newtonsoft.Json.Linq.JToken t, Newtonsoft.Json.Linq.JsonSelectSettings settings, int index);
                    static /*0xb0fdb0*/ Newtonsoft.Json.Linq.JToken GetNextScanValue(Newtonsoft.Json.Linq.JToken originalParent, Newtonsoft.Json.Linq.JToken container, Newtonsoft.Json.Linq.JToken value);
                    /*0xb09a28*/ PathFilter();
                    System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                }

                enum QueryOperator
                {
                    None = 0,
                    Equals = 1,
                    NotEquals = 2,
                    Exists = 3,
                    LessThan = 4,
                    LessThanOrEquals = 5,
                    GreaterThan = 6,
                    GreaterThanOrEquals = 7,
                    And = 8,
                    Or = 9,
                    RegexEquals = 10,
                    StrictEquals = 11,
                    StrictNotEquals = 12,
                }

                class QueryExpression
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JsonPath.QueryOperator Operator;

                    /*0xb0fe58*/ QueryExpression(Newtonsoft.Json.Linq.JsonPath.QueryOperator operator);
                    /*0xb0fe80*/ bool IsMatch(Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t);
                    bool IsMatch(Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                }

                class CompositeExpression : Newtonsoft.Json.Linq.JsonPath.QueryExpression
                {
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.QueryExpression> <Expressions>k__BackingField;

                    /*0xb0f620*/ CompositeExpression(Newtonsoft.Json.Linq.JsonPath.QueryOperator operator);
                    /*0xb0fe90*/ System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.QueryExpression> get_Expressions();
                    /*0xb0fe98*/ void set_Expressions(System.Collections.Generic.List<Newtonsoft.Json.Linq.JsonPath.QueryExpression> value);
                    /*0xb0fea0*/ bool IsMatch(Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                }

                class BooleanQueryExpression : Newtonsoft.Json.Linq.JsonPath.QueryExpression
                {
                    /*0x18*/ object Left;
                    /*0x20*/ object Right;

                    static /*0xb10b94*/ bool RegexEquals(Newtonsoft.Json.Linq.JValue input, Newtonsoft.Json.Linq.JValue pattern, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                    static /*0xb10d0c*/ bool EqualsWithStringCoercion(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.Linq.JValue queryValue);
                    static /*0xb11278*/ bool EqualsWithStrictMatch(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.Linq.JValue queryValue);
                    /*0xb0f544*/ BooleanQueryExpression(Newtonsoft.Json.Linq.JsonPath.QueryOperator operator, object left, object right);
                    /*0xb1013c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> GetResult(Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t, object o);
                    /*0xb102f0*/ bool IsMatch(Newtonsoft.Json.Linq.JToken root, Newtonsoft.Json.Linq.JToken t, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                    /*0xb109f0*/ bool MatchTokens(Newtonsoft.Json.Linq.JToken leftResult, Newtonsoft.Json.Linq.JToken rightResult, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                }

                class QueryFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JsonPath.QueryExpression Expression;

                    /*0xb0eb5c*/ QueryFilter(Newtonsoft.Json.Linq.JsonPath.QueryExpression expression);
                    /*0xb1138c*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.QueryFilter <>4__this;
                        /*0x40*/ Newtonsoft.Json.Linq.JToken root;
                        /*0x48*/ Newtonsoft.Json.Linq.JToken <>3__root;
                        /*0x50*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x58*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x60*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x68*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap2;

                        /*0xb11428*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb1145c*/ void System.IDisposable.Dispose();
                        /*0xb11514*/ bool MoveNext();
                        /*0xb11a00*/ void <>m__Finally1();
                        /*0xb11950*/ void <>m__Finally2();
                        /*0xb11ab0*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb11ab8*/ void System.Collections.IEnumerator.Reset();
                        /*0xb11af8*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb11b00*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb11bbc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class QueryScanFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ Newtonsoft.Json.Linq.JsonPath.QueryExpression Expression;

                    /*0xb0eb84*/ QueryScanFilter(Newtonsoft.Json.Linq.JsonPath.QueryExpression expression);
                    /*0xb11bc0*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.QueryScanFilter <>4__this;
                        /*0x40*/ Newtonsoft.Json.Linq.JToken root;
                        /*0x48*/ Newtonsoft.Json.Linq.JToken <>3__root;
                        /*0x50*/ Newtonsoft.Json.Linq.JsonSelectSettings settings;
                        /*0x58*/ Newtonsoft.Json.Linq.JsonSelectSettings <>3__settings;
                        /*0x60*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x68*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap2;

                        /*0xb11c5c*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb11c90*/ void System.IDisposable.Dispose();
                        /*0xb11d44*/ bool MoveNext();
                        /*0xb12304*/ void <>m__Finally1();
                        /*0xb12254*/ void <>m__Finally2();
                        /*0xb123b4*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb123bc*/ void System.Collections.IEnumerator.Reset();
                        /*0xb123fc*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb12404*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb124c0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class RootFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    static /*0x0*/ Newtonsoft.Json.Linq.JsonPath.RootFilter Instance;

                    static /*0xb1255c*/ RootFilter();
                    /*0xb124c4*/ RootFilter();
                    /*0xb124cc*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);
                }

                class ScanFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ string Name;

                    /*0xb0d918*/ ScanFilter(string name);
                    /*0xb125c0*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.ScanFilter <>4__this;
                        /*0x40*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x48*/ Newtonsoft.Json.Linq.JToken <c>5__3;
                        /*0x50*/ Newtonsoft.Json.Linq.JToken <value>5__4;

                        /*0xb12644*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb12678*/ void System.IDisposable.Dispose();
                        /*0xb126a4*/ bool MoveNext();
                        /*0xb12ac0*/ void <>m__Finally1();
                        /*0xb12b70*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb12b78*/ void System.Collections.IEnumerator.Reset();
                        /*0xb12bb8*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb12bc0*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb12c6c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class ScanMultipleFilter : Newtonsoft.Json.Linq.JsonPath.PathFilter
                {
                    /*0x10*/ System.Collections.Generic.List<string> _names;

                    /*0xb0faa4*/ ScanMultipleFilter(System.Collections.Generic.List<string> names);
                    /*0xb12c70*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> ExecuteFilter(Newtonsoft.Json.Linq.JToken root, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current, Newtonsoft.Json.Linq.JsonSelectSettings settings);

                    class <ExecuteFilter>d__2 : System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Newtonsoft.Json.Linq.JToken <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> current;
                        /*0x30*/ System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> <>3__current;
                        /*0x38*/ Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter <>4__this;
                        /*0x40*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1;
                        /*0x48*/ Newtonsoft.Json.Linq.JToken <c>5__3;
                        /*0x50*/ Newtonsoft.Json.Linq.JToken <value>5__4;
                        /*0x58*/ Newtonsoft.Json.Linq.JProperty <property>5__5;
                        /*0x60*/ System.Collections.Generic.List.Enumerator<string> <>7__wrap5;

                        /*0xb12cf4*/ <ExecuteFilter>d__2(int <>1__state);
                        /*0xb12d28*/ void System.IDisposable.Dispose();
                        /*0xb12de0*/ bool MoveNext();
                        /*0xb13280*/ void <>m__Finally1();
                        /*0xb13230*/ void <>m__Finally2();
                        /*0xb13330*/ Newtonsoft.Json.Linq.JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current();
                        /*0xb13338*/ void System.Collections.IEnumerator.Reset();
                        /*0xb13378*/ object System.Collections.IEnumerator.get_Current();
                        /*0xb13380*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator();
                        /*0xb1342c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }
            }
        }

        namespace Converters
        {
            class BinaryConverter : Newtonsoft.Json.JsonConverter
            {
                static string BinaryTypeName = "System.Data.Linq.Binary";
                static string BinaryToArrayName = "ToArray";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0xb13664*/ void EnsureReflectionObject(System.Type t);
                /*0xb13fbc*/ BinaryConverter();
                /*0xb13430*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb13484*/ byte[] GetByteArray(object value);
                /*0xb1380c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb13c04*/ byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader);
                /*0xb13ea4*/ bool CanConvert(System.Type objectType);
            }

            class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
            {
                /*0xb142e8*/ BsonObjectIdConverter();
                /*0xb13fc4*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb140c4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb14260*/ bool CanConvert(System.Type objectType);
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
                /*0xb14b14*/ DataSetConverter();
                /*0xb142f0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1478c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb14a80*/ bool CanConvert(System.Type valueType);
            }

            class DataTableConverter : Newtonsoft.Json.JsonConverter
            {
                static /*0xb1561c*/ void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer);
                static /*0xb15b68*/ System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader);
                /*0xb14784*/ DataTableConverter();
                /*0xb14b1c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb15310*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb15d38*/ bool CanConvert(System.Type valueType);
            }

            class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
            {
                /*0xb15f40*/ DateTimeConverterBase();
                /*0xb15dcc*/ bool CanConvert(System.Type objectType);
            }

            class DiscriminatedUnionConverter : Newtonsoft.Json.JsonConverter
            {
                static string CasePropertyName = "Case";
                static string FieldsPropertyName = "Fields";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;
                static /*0x8*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache;

                static /*0xb17710*/ DiscriminatedUnionConverter();
                static /*0xb15f48*/ System.Type CreateUnionTypeLookup(System.Type t);
                static /*0xb16148*/ Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t);
                /*0xb17708*/ DiscriminatedUnionConverter();
                /*0xb16960*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb16e10*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb17468*/ bool CanConvert(System.Type objectType);

                class Union
                {
                    /*0x10*/ Newtonsoft.Json.Utilities.FSharpFunction TagReader;
                    /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;

                    /*0xb168e4*/ Union(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases);
                }

                class UnionCase
                {
                    /*0x10*/ int Tag;
                    /*0x18*/ string Name;
                    /*0x20*/ System.Reflection.PropertyInfo[] Fields;
                    /*0x28*/ Newtonsoft.Json.Utilities.FSharpFunction FieldReader;
                    /*0x30*/ Newtonsoft.Json.Utilities.FSharpFunction Constructor;

                    /*0xb16910*/ UnionCase(int tag, string name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ int tag;

                    /*0xb16e08*/ <>c__DisplayClass8_0();
                    /*0xb17888*/ bool <WriteJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ string caseName;
                    /*0x18*/ System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> <>9__0;

                    /*0xb17460*/ <>c__DisplayClass9_0();
                    /*0xb178ac*/ bool <ReadJson>b__0(Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c);
                }
            }

            class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
            {
                static string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
                static string KeyPropertyName = "Key";
                static string TypePropertyName = "Type";
                static string ValuePropertyName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

                static /*0xb17d58*/ void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, string propertyName);
                static /*0xb17c2c*/ void EnsureReflectionObject(System.Type objectType);
                /*0xb18154*/ EntityKeyMemberConverter();
                /*0xb178d0*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb17e54*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb18104*/ bool CanConvert(System.Type objectType);
            }

            class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
            {
                /*0xb186c4*/ ExpandoObjectConverter();
                /*0xb1815c*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb18160*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb18164*/ object ReadValue(Newtonsoft.Json.JsonReader reader);
                /*0xb184a0*/ object ReadList(Newtonsoft.Json.JsonReader reader);
                /*0xb182d0*/ object ReadObject(Newtonsoft.Json.JsonReader reader);
                /*0xb18634*/ bool CanConvert(System.Type objectType);
                /*0xb186bc*/ bool get_CanWrite();
            }

            class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
                /*0x10*/ System.Globalization.DateTimeStyles _dateTimeStyles;
                /*0x18*/ string _dateTimeFormat;
                /*0x20*/ System.Globalization.CultureInfo _culture;

                /*0xb18ee4*/ IsoDateTimeConverter();
                /*0xb186cc*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
                /*0xb186d4*/ void set_DateTimeStyles(System.Globalization.DateTimeStyles value);
                /*0xb186dc*/ string get_DateTimeFormat();
                /*0xb18730*/ void set_DateTimeFormat(string value);
                /*0xb1876c*/ System.Globalization.CultureInfo get_Culture();
                /*0xb187d4*/ void set_Culture(System.Globalization.CultureInfo value);
                /*0xb187dc*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb189fc*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                /*0xb193f0*/ JavaScriptDateTimeConverter();
                /*0xb18ef4*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb190b4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
            {
                static string KeyName = "Key";
                static string ValueName = "Value";
                static /*0x0*/ Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type, Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

                static /*0xb19eac*/ KeyValuePairConverter();
                static /*0xb193f8*/ Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t);
                /*0xb19ea4*/ KeyValuePairConverter();
                /*0xb19678*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb198d4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb19d8c*/ bool CanConvert(System.Type objectType);
            }

            class RegexConverter : Newtonsoft.Json.JsonConverter
            {
                static string PatternName = "Pattern";
                static string OptionsName = "Options";

                /*0xb1a954*/ RegexConverter();
                /*0xb19f84*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1a3a0*/ bool HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag);
                /*0xb1a0a4*/ void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex);
                /*0xb1a1dc*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1a3ac*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1a6e4*/ object ReadRegexString(Newtonsoft.Json.JsonReader reader);
                /*0xb1a45c*/ System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1a850*/ bool CanConvert(System.Type objectType);
                /*0xb1a8cc*/ bool IsRegex(System.Type objectType);
            }

            class StringEnumConverter : Newtonsoft.Json.JsonConverter
            {
                /*0x10*/ Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;
                /*0x18*/ bool <AllowIntegerValues>k__BackingField;

                /*0xb1aab4*/ StringEnumConverter();
                /*0xb1aac4*/ StringEnumConverter(bool camelCaseText);
                /*0xb1ab40*/ StringEnumConverter(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, bool allowIntegerValues);
                /*0xb1ab7c*/ StringEnumConverter(System.Type namingStrategyType);
                /*0xb1ac24*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters);
                /*0xb1acd8*/ StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues);
                /*0xb1a95c*/ bool get_CamelCaseText();
                /*0xb1a9d8*/ void set_CamelCaseText(bool value);
                /*0xb1aa90*/ Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy();
                /*0xb1aa98*/ void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value);
                /*0xb1aaa0*/ bool get_AllowIntegerValues();
                /*0xb1aaa8*/ void set_AllowIntegerValues(bool value);
                /*0xb1ad98*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1af88*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1b418*/ bool CanConvert(System.Type objectType);
            }

            class UnixDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
            {
                static /*0x0*/ System.DateTime UnixEpoch;

                static /*0xb1bac4*/ UnixDateTimeConverter();
                /*0xb1babc*/ UnixDateTimeConverter();
                /*0xb1b490*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1b6c4*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
            }

            class VersionConverter : Newtonsoft.Json.JsonConverter
            {
                /*0xb1bf58*/ VersionConverter();
                /*0xb1bb40*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1bc2c*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0xb1bed0*/ bool CanConvert(System.Type objectType);
            }

            class XmlDocumentWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocument _document;

                /*0x1b94524*/ XmlDocumentWrapper(System.Xml.XmlDocument document);
                /*0x1b94578*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string data);
                /*0x1b94604*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x1b94690*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x1b9471c*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x1b947a8*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x1b94834*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x1b94908*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x1b949e0*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x1b94a7c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x1b94b30*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x1b94bc8*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x1b94c90*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x1b94d40*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
            }

            class XmlElementWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlElement _element;

                /*0x1b94b04*/ XmlElementWrapper(System.Xml.XmlElement element);
                /*0x1b94ddc*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x1b94ec4*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x1b94ee8*/ bool get_IsEmpty();
            }

            class XmlDeclarationWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDeclaration _declaration;

                /*0x1b948dc*/ XmlDeclarationWrapper(System.Xml.XmlDeclaration declaration);
                /*0x1b94f04*/ string get_Version();
                /*0x1b94f20*/ string get_Encoding();
                /*0x1b94f3c*/ void set_Encoding(string value);
                /*0x1b94f58*/ string get_Standalone();
                /*0x1b94f74*/ void set_Standalone(string value);
            }

            class XmlDocumentTypeWrapper : Newtonsoft.Json.Converters.XmlNodeWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x28*/ System.Xml.XmlDocumentType _documentType;

                /*0x1b949b4*/ XmlDocumentTypeWrapper(System.Xml.XmlDocumentType documentType);
                /*0x1b94f90*/ string get_Name();
                /*0x1b94fb0*/ string get_System();
                /*0x1b94fcc*/ string get_Public();
                /*0x1b94fe8*/ string get_InternalSubset();
                /*0x1b95004*/ string get_LocalName();
            }

            class XmlNodeWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.XmlNode _node;
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                static /*0x1b954c0*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node);
                /*0x1b94550*/ XmlNodeWrapper(System.Xml.XmlNode node);
                /*0x1b95044*/ object get_WrappedNode();
                /*0x1b9504c*/ System.Xml.XmlNodeType get_NodeType();
                /*0x1b9506c*/ string get_LocalName();
                /*0x1b95090*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x1b95644*/ bool get_HasChildNodes();
                /*0x1b95668*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x1b95a90*/ bool get_HasAttributes();
                /*0x1b95b44*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x1b95be4*/ string get_Value();
                /*0x1b94c70*/ void set_Value(string value);
                /*0x1b95c04*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x1b95ca8*/ string get_NamespaceUri();
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
                void set_Encoding(string value);
                string get_Standalone();
                void set_Standalone(string value);
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
                void set_Value(string value);
                Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                string get_NamespaceUri();
                object get_WrappedNode();
            }

            class XDeclarationWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDeclaration, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDeclaration <Declaration>k__BackingField;

                /*0x1b95cd4*/ XDeclarationWrapper(System.Xml.Linq.XDeclaration declaration);
                /*0x1b95ccc*/ System.Xml.Linq.XDeclaration get_Declaration();
                /*0x1b95d24*/ System.Xml.XmlNodeType get_NodeType();
                /*0x1b95d2c*/ string get_Version();
                /*0x1b95d48*/ string get_Encoding();
                /*0x1b95d64*/ void set_Encoding(string value);
                /*0x1b95d80*/ string get_Standalone();
                /*0x1b95d9c*/ void set_Standalone(string value);
            }

            class XDocumentTypeWrapper : Newtonsoft.Json.Converters.XObjectWrapper, Newtonsoft.Json.Converters.IXmlDocumentType, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x18*/ System.Xml.Linq.XDocumentType _documentType;

                /*0x1b95db8*/ XDocumentTypeWrapper(System.Xml.Linq.XDocumentType documentType);
                /*0x1b95de0*/ string get_Name();
                /*0x1b95dfc*/ string get_System();
                /*0x1b95e18*/ string get_Public();
                /*0x1b95e34*/ string get_InternalSubset();
                /*0x1b95e50*/ string get_LocalName();
            }

            class XDocumentWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlDocument, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x1b95f08*/ XDocumentWrapper(System.Xml.Linq.XDocument document);
                /*0x1b95e90*/ System.Xml.Linq.XDocument get_Document();
                /*0x1b95f58*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x1b964dc*/ bool get_HasChildNodes();
                /*0x1b96540*/ Newtonsoft.Json.Converters.IXmlNode CreateComment(string text);
                /*0x1b965d4*/ Newtonsoft.Json.Converters.IXmlNode CreateTextNode(string text);
                /*0x1b96668*/ Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(string data);
                /*0x1b966fc*/ Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(string text);
                /*0x1b96790*/ Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(string text);
                /*0x1b96824*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
                /*0x1b968d0*/ Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
                /*0x1b9698c*/ Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, string data);
                /*0x1b96a58*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);
                /*0x1b96b28*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);
                /*0x1b96be8*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, string value);
                /*0x1b96cc8*/ Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
                /*0x1b96d90*/ Newtonsoft.Json.Converters.IXmlElement get_DocumentElement();
                /*0x1b96e30*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XTextWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x1b9701c*/ XTextWrapper(System.Xml.Linq.XText text);
                /*0x1b96fa4*/ System.Xml.Linq.XText get_Text();
                /*0x1b97044*/ string get_Value();
                /*0x1b97060*/ void set_Value(string value);
                /*0x1b97084*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XCommentWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x1b97454*/ XCommentWrapper(System.Xml.Linq.XComment text);
                /*0x1b973dc*/ System.Xml.Linq.XComment get_Text();
                /*0x1b9747c*/ string get_Value();
                /*0x1b97498*/ void set_Value(string value);
                /*0x1b974bc*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XProcessingInstructionWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x1b96a30*/ XProcessingInstructionWrapper(System.Xml.Linq.XProcessingInstruction processingInstruction);
                /*0x1b97500*/ System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction();
                /*0x1b97578*/ string get_LocalName();
                /*0x1b97594*/ string get_Value();
                /*0x1b975b0*/ void set_Value(string value);
            }

            class XContainerWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x18*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;

                static /*0x1b970c8*/ Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node);
                /*0x1b95f30*/ XContainerWrapper(System.Xml.Linq.XContainer container);
                /*0x1b975d4*/ System.Xml.Linq.XContainer get_Container();
                /*0x1b960d4*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x1b96518*/ bool get_HasChildNodes();
                /*0x1b9764c*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x1b96ed4*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
            }

            class XObjectWrapper : Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x10*/ System.Xml.Linq.XObject _xmlObject;

                /*0x1b95cfc*/ XObjectWrapper(System.Xml.Linq.XObject xmlObject);
                /*0x1b97690*/ object get_WrappedNode();
                /*0x1b97698*/ System.Xml.XmlNodeType get_NodeType();
                /*0x1b976b0*/ string get_LocalName();
                /*0x1b976b8*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes();
                /*0x1b97710*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x1b97768*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
                /*0x1b97770*/ string get_Value();
                /*0x1b97778*/ void set_Value(string value);
                /*0x1b977b8*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x1b977f8*/ string get_NamespaceUri();
            }

            class XAttributeWrapper : Newtonsoft.Json.Converters.XObjectWrapper
            {
                /*0x1b96ca0*/ XAttributeWrapper(System.Xml.Linq.XAttribute attribute);
                /*0x1b97800*/ System.Xml.Linq.XAttribute get_Attribute();
                /*0x1b97878*/ string get_Value();
                /*0x1b97894*/ void set_Value(string value);
                /*0x1b978b8*/ string get_LocalName();
                /*0x1b978dc*/ string get_NamespaceUri();
                /*0x1b97900*/ Newtonsoft.Json.Converters.IXmlNode get_ParentNode();
            }

            class XElementWrapper : Newtonsoft.Json.Converters.XContainerWrapper, Newtonsoft.Json.Converters.IXmlElement, Newtonsoft.Json.Converters.IXmlNode
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;

                /*0x1b96b00*/ XElementWrapper(System.Xml.Linq.XElement element);
                /*0x1b97944*/ System.Xml.Linq.XElement get_Element();
                /*0x1b979bc*/ void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute);
                /*0x1b97a60*/ System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes();
                /*0x1b97fc0*/ bool HasImplicitNamespaceAttribute(string namespaceUri);
                /*0x1b984b0*/ Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild);
                /*0x1b984c8*/ string get_Value();
                /*0x1b984e4*/ void set_Value(string value);
                /*0x1b98508*/ string get_LocalName();
                /*0x1b9852c*/ string get_NamespaceUri();
                /*0x1b98470*/ string GetPrefixOfNamespace(string namespaceUri);
                /*0x1b98550*/ bool get_IsEmpty();
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

                static /*0x1ba05f4*/ XmlNodeConverter();
                static /*0x1b9bcec*/ bool AllSameName(Newtonsoft.Json.Converters.IXmlNode node);
                static /*0x1b9f478*/ void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, string attributeName, System.Xml.XmlNamespaceManager manager, string attributePrefix);
                static /*0x1b9dbac*/ string ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader);
                /*0x1ba05ec*/ XmlNodeConverter();
                /*0x1b9856c*/ string get_DeserializeRootElementName();
                /*0x1b98574*/ void set_DeserializeRootElementName(string value);
                /*0x1b9857c*/ bool get_WriteArrayAttribute();
                /*0x1b98584*/ void set_WriteArrayAttribute(bool value);
                /*0x1b98590*/ bool get_OmitRootObject();
                /*0x1b98598*/ void set_OmitRootObject(bool value);
                /*0x1b985a4*/ bool get_EncodeSpecialCharacters();
                /*0x1b985ac*/ void set_EncodeSpecialCharacters(bool value);
                /*0x1b985b8*/ void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1b986fc*/ Newtonsoft.Json.Converters.IXmlNode WrapXml(object value);
                /*0x1b98818*/ void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x1b9a5f4*/ string ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x1b9a910*/ string GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager);
                /*0x1b9ad48*/ bool IsArray(Newtonsoft.Json.Converters.IXmlNode node);
                /*0x1b9b0e0*/ void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x1b9baa8*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames);
                /*0x1b9bc14*/ void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, bool writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, string elementNames);
                /*0x1b98e80*/ void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, bool writePropertyName);
                /*0x1b9c2b0*/ object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
                /*0x1b9d62c*/ void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x1b9cb1c*/ void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, System.Xml.XmlNamespaceManager manager);
                /*0x1b9f7ec*/ void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string elementName, System.Xml.XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<string, string> attributeNameValues);
                /*0x1b9ea7c*/ void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, string propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager);
                /*0x1b9fff8*/ void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document);
                /*0x1b9ee18*/ bool ShouldReadInto(Newtonsoft.Json.JsonReader reader);
                /*0x1b9ee60*/ System.Collections.Generic.Dictionary<string, string> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager);
                /*0x1b9e1c0*/ void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName);
                /*0x1b9e674*/ void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x1b9fe3c*/ Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName, Newtonsoft.Json.Converters.IXmlDocument document, string elementPrefix, System.Xml.XmlNamespaceManager manager);
                /*0x1b9ce68*/ void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode);
                /*0x1ba0338*/ bool IsNamespaceAttribute(string attributeName, ref string prefix);
                /*0x1b9bf98*/ bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c);
                /*0x1ba041c*/ bool CanConvert(System.Type valueType);
                /*0x1ba04c4*/ bool IsXObject(System.Type valueType);
                /*0x1ba0558*/ bool IsXmlNode(System.Type valueType);
            }
        }

        namespace Bson
        {
            enum BsonBinaryType
            {
                Binary = 0,
                Function = 1,
                BinaryOld = 2,
                UuidOld = 3,
                Uuid = 4,
                Md5 = 5,
                UserDefined = 128,
            }

            class BsonBinaryWriter
            {
                static /*0x0*/ System.Text.Encoding Encoding;
                /*0x10*/ System.IO.BinaryWriter _writer;
                /*0x18*/ byte[] _largeByteBuffer;
                /*0x20*/ System.DateTimeKind <DateTimeKindHandling>k__BackingField;

                static /*0x1ba2128*/ BsonBinaryWriter();
                /*0x1ba0690*/ BsonBinaryWriter(System.IO.BinaryWriter writer);
                /*0x1ba0680*/ System.DateTimeKind get_DateTimeKindHandling();
                /*0x1ba0688*/ void set_DateTimeKindHandling(System.DateTimeKind value);
                /*0x1ba06c0*/ void Flush();
                /*0x1ba06e0*/ void Close();
                /*0x1ba0700*/ void WriteToken(Newtonsoft.Json.Bson.BsonToken t);
                /*0x1ba0fc4*/ void WriteTokenInternal(Newtonsoft.Json.Bson.BsonToken t);
                /*0x1ba1e7c*/ void WriteString(string s, int byteCount, System.Nullable<int> calculatedlengthPrefix);
                /*0x1ba1fb0*/ void WriteUtf8Bytes(string s, int byteCount);
                /*0x1ba210c*/ int CalculateSize(int stringByteCount);
                /*0x1ba2114*/ int CalculateSizeWithLength(int stringByteCount, bool includeSize);
                /*0x1ba0728*/ int CalculateSize(Newtonsoft.Json.Bson.BsonToken t);
            }

            class BsonObjectId
            {
                /*0x10*/ byte[] <Value>k__BackingField;

                /*0x1ba21ac*/ BsonObjectId(byte[] value);
                /*0x1ba21a4*/ byte[] get_Value();
            }

            class BsonReader : Newtonsoft.Json.JsonReader
            {
                static int MaxCharBytesSize = 128;
                static /*0x0*/ byte[] SeqRange1;
                static /*0x8*/ byte[] SeqRange2;
                static /*0x10*/ byte[] SeqRange3;
                static /*0x18*/ byte[] SeqRange4;
                /*0x78*/ System.IO.BinaryReader _reader;
                /*0x80*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonReader.ContainerContext> _stack;
                /*0x88*/ byte[] _byteBuffer;
                /*0x90*/ char[] _charBuffer;
                /*0x98*/ Newtonsoft.Json.Bson.BsonType _currentElementType;
                /*0x9c*/ Newtonsoft.Json.Bson.BsonReader.BsonReaderState _bsonReaderState;
                /*0xa0*/ Newtonsoft.Json.Bson.BsonReader.ContainerContext _currentContext;
                /*0xa8*/ bool _readRootValueAsArray;
                /*0xa9*/ bool _jsonNet35BinaryCompatibility;
                /*0xac*/ System.DateTimeKind _dateTimeKindHandling;

                static /*0x1ba3cf4*/ BsonReader();
                /*0x1ba22c4*/ BsonReader(System.IO.Stream stream);
                /*0x1ba23d0*/ BsonReader(System.IO.BinaryReader reader);
                /*0x1ba22d0*/ BsonReader(System.IO.Stream stream, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling);
                /*0x1ba23dc*/ BsonReader(System.IO.BinaryReader reader, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling);
                /*0x1ba228c*/ bool get_JsonNet35BinaryCompatibility();
                /*0x1ba2294*/ void set_JsonNet35BinaryCompatibility(bool value);
                /*0x1ba22a0*/ bool get_ReadRootValueAsArray();
                /*0x1ba22a8*/ void set_ReadRootValueAsArray(bool value);
                /*0x1ba22b4*/ System.DateTimeKind get_DateTimeKindHandling();
                /*0x1ba22bc*/ void set_DateTimeKindHandling(System.DateTimeKind value);
                /*0x1ba24ac*/ string ReadElement();
                /*0x1ba276c*/ bool Read();
                /*0x1ba2eac*/ void Close();
                /*0x1ba2cc8*/ bool ReadCodeWScope();
                /*0x1ba2b10*/ bool ReadReference();
                /*0x1ba2914*/ bool ReadNormal();
                /*0x1ba35f0*/ void PopContext();
                /*0x1ba2f9c*/ void PushContext(Newtonsoft.Json.Bson.BsonReader.ContainerContext newContext);
                /*0x1ba35bc*/ byte ReadByte();
                /*0x1ba307c*/ void ReadType(Newtonsoft.Json.Bson.BsonType type);
                /*0x1ba36f0*/ byte[] ReadBinary(ref Newtonsoft.Json.Bson.BsonBinaryType binaryType);
                /*0x1ba24fc*/ string ReadString();
                /*0x1ba2f1c*/ string ReadLengthString();
                /*0x1ba38b0*/ string GetString(int length);
                /*0x1ba382c*/ int GetLastFullCharStop(int start);
                /*0x1ba3b24*/ int BytesInSequence(byte b);
                /*0x1ba3780*/ void EnsureBuffers();
                /*0x1ba36b8*/ double ReadDouble();
                /*0x1ba2ee4*/ int ReadInt32();
                /*0x1ba3748*/ long ReadInt64();
                /*0x1ba24c8*/ Newtonsoft.Json.Bson.BsonType ReadType();
                /*0x1ba3694*/ void MovePosition(int count);
                /*0x1ba3044*/ byte[] ReadBytes(int count);

                enum BsonReaderState
                {
                    Normal = 0,
                    ReferenceStart = 1,
                    ReferenceRef = 2,
                    ReferenceId = 3,
                    CodeWScopeStart = 4,
                    CodeWScopeCode = 5,
                    CodeWScopeScope = 6,
                    CodeWScopeScopeObject = 7,
                    CodeWScopeScopeEnd = 8,
                }

                class ContainerContext
                {
                    /*0x10*/ Newtonsoft.Json.Bson.BsonType Type;
                    /*0x14*/ int Length;
                    /*0x18*/ int Position;

                    /*0x1ba2f74*/ ContainerContext(Newtonsoft.Json.Bson.BsonType type);
                }
            }

            class BsonToken
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;
                /*0x18*/ int <CalculatedSize>k__BackingField;

                /*0x1ba3e50*/ BsonToken();
                Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x1ba3e30*/ Newtonsoft.Json.Bson.BsonToken get_Parent();
                /*0x1ba3e38*/ void set_Parent(Newtonsoft.Json.Bson.BsonToken value);
                /*0x1ba3e40*/ int get_CalculatedSize();
                /*0x1ba3e48*/ void set_CalculatedSize(int value);
            }

            class BsonObject : Newtonsoft.Json.Bson.BsonToken, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Bson.BsonProperty>, System.Collections.IEnumerable
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;

                /*0x1ba3fd8*/ BsonObject();
                /*0x1ba3e58*/ void Add(string name, Newtonsoft.Json.Bson.BsonToken token);
                /*0x1ba3fcc*/ Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x1ba1dec*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Bson.BsonProperty> GetEnumerator();
                /*0x1ba3fd4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class BsonArray : Newtonsoft.Json.Bson.BsonToken, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Bson.BsonToken>, System.Collections.IEnumerable
            {
                /*0x20*/ System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;

                /*0x1ba4110*/ BsonArray();
                /*0x1ba4054*/ void Add(Newtonsoft.Json.Bson.BsonToken token);
                /*0x1ba4104*/ Newtonsoft.Json.Bson.BsonType get_Type();
                /*0x1ba1f20*/ System.Collections.Generic.IEnumerator<Newtonsoft.Json.Bson.BsonToken> GetEnumerator();
                /*0x1ba410c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class BsonEmpty : Newtonsoft.Json.Bson.BsonToken
            {
                static /*0x0*/ Newtonsoft.Json.Bson.BsonToken Null;
                static /*0x8*/ Newtonsoft.Json.Bson.BsonToken Undefined;
                /*0x1c*/ Newtonsoft.Json.Bson.BsonType <Type>k__BackingField;

                static /*0x1ba41bc*/ BsonEmpty();
                /*0x1ba418c*/ BsonEmpty(Newtonsoft.Json.Bson.BsonType type);
                /*0x1ba41b4*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonValue : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x20*/ object _value;
                /*0x28*/ Newtonsoft.Json.Bson.BsonType _type;

                /*0x1ba4254*/ BsonValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x1ba4284*/ object get_Value();
                /*0x1ba428c*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonBoolean : Newtonsoft.Json.Bson.BsonValue
            {
                static /*0x0*/ Newtonsoft.Json.Bson.BsonBoolean False;
                static /*0x8*/ Newtonsoft.Json.Bson.BsonBoolean True;

                static /*0x1ba430c*/ BsonBoolean();
                /*0x1ba4294*/ BsonBoolean(bool value);
            }

            class BsonString : Newtonsoft.Json.Bson.BsonValue
            {
                /*0x2c*/ int <ByteCount>k__BackingField;
                /*0x30*/ bool <IncludeLength>k__BackingField;

                /*0x1ba3f94*/ BsonString(object value, bool includeLength);
                /*0x1ba4394*/ int get_ByteCount();
                /*0x1ba439c*/ void set_ByteCount(int value);
                /*0x1ba43a4*/ bool get_IncludeLength();
            }

            class BsonBinary : Newtonsoft.Json.Bson.BsonValue
            {
                /*0x29*/ Newtonsoft.Json.Bson.BsonBinaryType <BinaryType>k__BackingField;

                /*0x1ba43bc*/ BsonBinary(byte[] value, Newtonsoft.Json.Bson.BsonBinaryType binaryType);
                /*0x1ba43ac*/ Newtonsoft.Json.Bson.BsonBinaryType get_BinaryType();
                /*0x1ba43b4*/ void set_BinaryType(Newtonsoft.Json.Bson.BsonBinaryType value);
            }

            class BsonRegex : Newtonsoft.Json.Bson.BsonToken
            {
                /*0x20*/ Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;
                /*0x28*/ Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;

                /*0x1ba4414*/ BsonRegex(string pattern, string options);
                /*0x1ba43f4*/ Newtonsoft.Json.Bson.BsonString get_Pattern();
                /*0x1ba43fc*/ void set_Pattern(Newtonsoft.Json.Bson.BsonString value);
                /*0x1ba4404*/ Newtonsoft.Json.Bson.BsonString get_Options();
                /*0x1ba440c*/ void set_Options(Newtonsoft.Json.Bson.BsonString value);
                /*0x1ba44d0*/ Newtonsoft.Json.Bson.BsonType get_Type();
            }

            class BsonProperty
            {
                /*0x10*/ Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;
                /*0x18*/ Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;

                /*0x1ba3f8c*/ BsonProperty();
                /*0x1ba44d8*/ Newtonsoft.Json.Bson.BsonString get_Name();
                /*0x1ba44e0*/ void set_Name(Newtonsoft.Json.Bson.BsonString value);
                /*0x1ba44e8*/ Newtonsoft.Json.Bson.BsonToken get_Value();
                /*0x1ba44f0*/ void set_Value(Newtonsoft.Json.Bson.BsonToken value);
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
                /*0x60*/ Newtonsoft.Json.Bson.BsonBinaryWriter _writer;
                /*0x68*/ Newtonsoft.Json.Bson.BsonToken _root;
                /*0x70*/ Newtonsoft.Json.Bson.BsonToken _parent;
                /*0x78*/ string _propertyName;

                /*0x1ba4530*/ BsonWriter(System.IO.Stream stream);
                /*0x1ba462c*/ BsonWriter(System.IO.BinaryWriter writer);
                /*0x1ba44f8*/ System.DateTimeKind get_DateTimeKindHandling();
                /*0x1ba4514*/ void set_DateTimeKindHandling(System.DateTimeKind value);
                /*0x1ba46f8*/ void Flush();
                /*0x1ba4720*/ void WriteEnd(Newtonsoft.Json.JsonToken token);
                /*0x1ba47b0*/ void WriteComment(string text);
                /*0x1ba47f4*/ void WriteStartConstructor(string name);
                /*0x1ba4838*/ void WriteRaw(string json);
                /*0x1ba487c*/ void WriteRawValue(string json);
                /*0x1ba48c0*/ void WriteStartArray();
                /*0x1ba4958*/ void WriteStartObject();
                /*0x1ba49cc*/ void WritePropertyName(string name);
                /*0x1ba49f4*/ void Close();
                /*0x1ba4934*/ void AddParent(Newtonsoft.Json.Bson.BsonToken container);
                /*0x1ba4790*/ void RemoveParent();
                /*0x1ba4c24*/ void AddValue(object value, Newtonsoft.Json.Bson.BsonType type);
                /*0x1ba4a38*/ void AddToken(Newtonsoft.Json.Bson.BsonToken token);
                /*0x1ba4ca0*/ void WriteValue(object value);
                /*0x1ba4d98*/ void WriteNull();
                /*0x1ba4e04*/ void WriteUndefined();
                /*0x1ba4e70*/ void WriteValue(string value);
                /*0x1ba4f38*/ void WriteValue(int value);
                /*0x1ba4fb4*/ void WriteValue(uint value);
                /*0x1ba5070*/ void WriteValue(long value);
                /*0x1ba50ec*/ void WriteValue(ulong value);
                /*0x1ba51a8*/ void WriteValue(float value);
                /*0x1ba5224*/ void WriteValue(double value);
                /*0x1ba52a0*/ void WriteValue(bool value);
                /*0x1ba5330*/ void WriteValue(short value);
                /*0x1ba53ac*/ void WriteValue(ushort value);
                /*0x1ba5428*/ void WriteValue(char value);
                /*0x1ba5508*/ void WriteValue(byte value);
                /*0x1ba5584*/ void WriteValue(sbyte value);
                /*0x1ba5600*/ void WriteValue(decimal value);
                /*0x1ba56b4*/ void WriteValue(System.DateTime value);
                /*0x1ba576c*/ void WriteValue(System.DateTimeOffset value);
                /*0x1ba57f8*/ void WriteValue(byte[] value);
                /*0x1ba589c*/ void WriteValue(System.Guid value);
                /*0x1ba5954*/ void WriteValue(System.TimeSpan value);
                /*0x1ba5a04*/ void WriteValue(System.Uri value);
                /*0x1ba5b0c*/ void WriteObjectId(byte[] value);
                /*0x1ba5bd8*/ void WriteRegex(string pattern, string options);
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
    static /*0x18a*/ <PrivateImplementationDetails> 772907508FD7AA0ED404C8FC80B6B772E26D67FA3C3662C22D62B871067C28DA;
    static /*0x190*/ <PrivateImplementationDetails> 990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5;
    static /*0x1b8*/ <PrivateImplementationDetails> A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89;
    static /*0x1c8*/ <PrivateImplementationDetails> B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122;
    static /*0x1dc*/ <PrivateImplementationDetails> CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326;
    static /*0x1f0*/ <PrivateImplementationDetails> D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A;
    static /*0x218*/ <PrivateImplementationDetails> F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7;
    static /*0x240*/ <PrivateImplementationDetails> FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315;
    static /*0x274*/ <PrivateImplementationDetails> FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A;

    static /*0x1ba5c90*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=6
    {
    }

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
