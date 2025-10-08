class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x36ff084*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x36ff08c*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x36ff114*/ NullableContextAttribute(byte );
            }
        }
    }
}

class SR
{
    static /*0x36ff13c*/ string GetString(string name);
    static /*0x36ff140*/ string Format(string resourceFormat, object p1);
    static /*0x36ff1b0*/ string Format(string resourceFormat, object p1, object p2);
    static /*0x36ff228*/ string Format(string resourceFormat, object p1, object p2, object p3);
}

namespace System
{
    class LocalAppContextSwitches
    {
        static /*0x0*/ int s_allowArbitraryTypeInstantiation;

        static /*0x36ff2b0*/ bool get_AllowArbitraryTypeInstantiation();
    }

    class LocalAppContext
    {
        static /*0x0*/ bool s_isDisableCachingInitialized;
        static /*0x1*/ bool s_disableCaching;
        static /*0x8*/ object s_syncObject;

        static /*0x36ff330*/ bool GetCachedSwitchValue(string switchName, ref int switchValue);
        static /*0x36ff350*/ bool GetCachedSwitchValueInternal(string switchName, ref int switchValue);
        static /*0x36ff3e4*/ bool get_DisableCaching();

        class <>c
        {
            static /*0x0*/ System.LocalAppContext.<> <>9;
            static /*0x8*/ System.Func<bool> <>9__6_0;

            static /*0x36ff510*/ <>c();
            /*0x36ff578*/ <>c();
            /*0x36ff580*/ bool <get_DisableCaching>b__6_0();
        }
    }

    namespace Data
    {
        class DataColumn : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x20*/ bool _allowNull;
            /*0x28*/ string _caption;
            /*0x30*/ string _columnName;
            /*0x38*/ System.Type _dataType;
            /*0x40*/ System.Data.Common.StorageType _storageType;
            /*0x48*/ object _defaultValue;
            /*0x50*/ System.Data.DataSetDateTime _dateTimeMode;
            /*0x58*/ System.Data.DataExpression _expression;
            /*0x60*/ int _maxLength;
            /*0x64*/ int _ordinal;
            /*0x68*/ bool _readOnly;
            /*0x70*/ System.Data.Index _sortIndex;
            /*0x78*/ System.Data.DataTable _table;
            /*0x80*/ bool _unique;
            /*0x84*/ System.Data.MappingType _columnMapping;
            /*0x88*/ int _hashCode;
            /*0x8c*/ int _errors;
            /*0x90*/ bool _isSqlType;
            /*0x91*/ bool _implementsINullable;
            /*0x92*/ bool _implementsIChangeTracking;
            /*0x93*/ bool _implementsIRevertibleChangeTracking;
            /*0x94*/ bool _implementsIXMLSerializable;
            /*0x95*/ bool _defaultValueIsNull;
            /*0x98*/ System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns;
            /*0xa0*/ System.Data.PropertyCollection _extendedProperties;
            /*0xa8*/ System.Data.Common.DataStorage _storage;
            /*0xb0*/ System.Data.AutoIncrementValue _autoInc;
            /*0xb8*/ string _columnUri;
            /*0xc0*/ string _columnPrefix;
            /*0xc8*/ string _encodedColumnName;
            /*0xd0*/ System.Data.SimpleType _simpleType;
            /*0xd8*/ int _objectID;
            /*0xe0*/ string <XmlDataType>k__BackingField;
            /*0xe8*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanging;

            static /*0x3700bc4*/ bool IsAutoIncrementType(System.Type dataType);
            /*0x36ff5f8*/ DataColumn();
            /*0x36ff95c*/ DataColumn(string columnName, System.Type dataType);
            /*0x36ff650*/ DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type);
            /*0x36ffa78*/ void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode);
            /*0x37003f4*/ bool get_AllowDBNull();
            /*0x37003fc*/ void set_AllowDBNull(bool value);
            /*0x370098c*/ bool get_AutoIncrement();
            /*0x37009ac*/ void set_AutoIncrement(bool value);
            /*0x37017a0*/ object get_AutoIncrementCurrent();
            /*0x37017f0*/ void set_AutoIncrementCurrent(object value);
            /*0x37016a8*/ System.Data.AutoIncrementValue get_AutoInc();
            /*0x37017d8*/ long get_AutoIncrementSeed();
            /*0x37019ec*/ void set_AutoIncrementSeed(long value);
            /*0x3701ae4*/ long get_AutoIncrementStep();
            /*0x3701b00*/ void set_AutoIncrementStep(long value);
            /*0x3701c00*/ string get_Caption();
            /*0x3701c1c*/ void set_Caption(string value);
            /*0x3701cfc*/ string get_ColumnName();
            /*0x3701d04*/ void set_ColumnName(string value);
            /*0x370212c*/ string get_EncodedColumnName();
            /*0x37018f4*/ System.IFormatProvider get_FormatProvider();
            /*0x3701c90*/ System.Globalization.CultureInfo get_Locale();
            /*0x37021ac*/ int get_ObjectID();
            /*0x37021b4*/ string get_Prefix();
            /*0x37021bc*/ void set_Prefix(string value);
            /*0x3702374*/ string GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3702494*/ bool get_Computed();
            /*0x37024a4*/ System.Data.DataExpression get_DataExpression();
            /*0x37024ac*/ System.Type get_DataType();
            /*0x3700ea8*/ void set_DataType(System.Type value);
            /*0x3702c84*/ System.Data.DataSetDateTime get_DateTimeMode();
            /*0x3702c8c*/ void set_DateTimeMode(System.Data.DataSetDateTime value);
            /*0x37026c4*/ object get_DefaultValue();
            /*0x37027f8*/ void set_DefaultValue(object value);
            /*0x3702fe4*/ bool get_DefaultValueIsNull();
            /*0x3702fec*/ string get_Expression();
            /*0x36ffb80*/ void set_Expression(string value);
            /*0x370348c*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x3700e4c*/ bool get_HasData();
            /*0x37034fc*/ bool get_ImplementsINullable();
            /*0x3703504*/ bool get_ImplementsIChangeTracking();
            /*0x370350c*/ bool get_ImplementsIRevertibleChangeTracking();
            /*0x3703514*/ bool get_IsValueType();
            /*0x370352c*/ bool get_IsSqlType();
            /*0x3703534*/ void SetMaxLengthSimpleType();
            /*0x37035dc*/ int get_MaxLength();
            /*0x37035e4*/ void set_MaxLength(int value);
            /*0x3703da0*/ string get_Namespace();
            /*0x3703de4*/ void set_Namespace(string value);
            /*0x3703f78*/ int get_Ordinal();
            /*0x3703f80*/ void SetOrdinalInternal(int ordinal);
            /*0x37040c8*/ bool get_ReadOnly();
            /*0x3703100*/ void set_ReadOnly(bool value);
            /*0x3704110*/ System.Data.Index get_SortIndex();
            /*0x37041f4*/ System.Data.DataTable get_Table();
            /*0x37041fc*/ void SetTable(System.Data.DataTable table);
            /*0x37042d0*/ System.Data.DataRow GetDataRow(int index);
            /*0x370243c*/ object get_Item(int record);
            /*0x37042f4*/ void set_Item(int record, object value);
            /*0x3703400*/ void InitializeRecord(int record);
            /*0x370454c*/ void SetValue(int record, object value);
            /*0x3704654*/ void FreeRecord(int record);
            /*0x3704674*/ bool get_Unique();
            /*0x370467c*/ void set_Unique(bool value);
            /*0x3704b60*/ void InternalUnique(bool value);
            /*0x3704b68*/ string get_XmlDataType();
            /*0x3704b70*/ void set_XmlDataType(string value);
            /*0x3704b78*/ System.Data.SimpleType get_SimpleType();
            /*0x36ffa24*/ void set_SimpleType(System.Data.SimpleType value);
            /*0x3704b80*/ System.Data.MappingType get_ColumnMapping();
            /*0x3704b88*/ void set_ColumnMapping(System.Data.MappingType value);
            /*0x3704ec0*/ void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x37039b0*/ bool CheckMaxLength();
            /*0x3704f8c*/ void CheckMaxLength(System.Data.DataRow dr);
            /*0x3700584*/ void CheckNotAllowNull();
            /*0x3704f14*/ void CheckNullable(System.Data.DataRow row);
            /*0x3704b14*/ void CheckUnique();
            /*0x370515c*/ int Compare(int record1, int record2);
            /*0x3705178*/ bool CompareValueTo(int record1, object value, bool checkType);
            /*0x3705300*/ int CompareValueTo(int record1, object value);
            /*0x370531c*/ object ConvertValue(object value);
            /*0x3705338*/ void Copy(int srcRecordNo, int dstRecordNo);
            /*0x3705354*/ System.Data.DataColumn Clone();
            /*0x3705940*/ object GetAggregateValue(int[] records, System.Data.AggregateType kind);
            /*0x3705008*/ int GetStringLength(int record);
            /*0x37059f8*/ void Init(int record);
            /*0x3705a84*/ bool get_IsCustomType();
            /*0x3705af8*/ bool IsValueCustomTypeInstance(object value);
            /*0x3705bb8*/ bool get_ImplementsIXMLSerializable();
            /*0x3702534*/ bool IsInRelation();
            /*0x3705bc0*/ bool IsMaxLengthViolated();
            /*0x37060ec*/ bool IsNotAllowDBNullViolated();
            /*0x3706260*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x37020b8*/ void RaisePropertyChanging(string name);
            /*0x3706288*/ void InsureStorage();
            /*0x3706324*/ void SetCapacity(int capacity);
            /*0x3706360*/ void OnSetDataSet();
            /*0x3706364*/ string ToString();
            /*0x37063d8*/ object ConvertXmlToObject(string s);
            /*0x3706414*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x3702458*/ string ConvertObjectToXml(object value);
            /*0x3706458*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
            /*0x37064ac*/ object GetEmptyColumnStore(int recordCount);
            /*0x37064e0*/ void CopyValueIntoStore(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
            /*0x37064f8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            /*0x3706534*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x3706600*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x37032c8*/ void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression);
        }

        class AutoIncrementValue
        {
            /*0x10*/ bool <Auto>k__BackingField;

            /*0x37066a8*/ AutoIncrementValue();
            /*0x3706698*/ bool get_Auto();
            /*0x37066a0*/ void set_Auto(bool value);
            /*0x1f30214*/ object get_Current();
            /*0x1f30ebc*/ void set_Current(object value);
            long get_Seed();
            /*0x1f30d60*/ void set_Seed(long value);
            long get_Step();
            /*0x1f30d60*/ void set_Step(long value);
            /*0x1f30214*/ System.Type get_DataType();
            /*0x1f30ff0*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x1f30ebc*/ void SetCurrentAndIncrement(object value);
            /*0x1f309e4*/ void MoveAfter();
            /*0x3705830*/ System.Data.AutoIncrementValue Clone();
        }

        class AutoIncrementInt64 : System.Data.AutoIncrementValue
        {
            /*0x18*/ long _current;
            /*0x20*/ long _seed;
            /*0x28*/ long _step;

            /*0x3701960*/ AutoIncrementInt64();
            /*0x37066b0*/ object get_Current();
            /*0x37066d8*/ void set_Current(object value);
            /*0x370672c*/ System.Type get_DataType();
            /*0x370675c*/ long get_Seed();
            /*0x3706764*/ void set_Seed(long value);
            /*0x37068c4*/ long get_Step();
            /*0x37068cc*/ void set_Step(long value);
            /*0x370698c*/ void MoveAfter();
            /*0x37069a0*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x3706a14*/ void SetCurrentAndIncrement(object value);
            /*0x37067f4*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class AutoIncrementBigInteger : System.Data.AutoIncrementValue
        {
            /*0x18*/ System.Numerics.BigInteger _current;
            /*0x28*/ long _seed;
            /*0x30*/ System.Numerics.BigInteger _step;

            /*0x3701970*/ AutoIncrementBigInteger();
            /*0x3706b48*/ object get_Current();
            /*0x3706ba4*/ void set_Current(object value);
            /*0x3706c24*/ System.Type get_DataType();
            /*0x3706c84*/ long get_Seed();
            /*0x3706c8c*/ void set_Seed(long value);
            /*0x3706ea8*/ long get_Step();
            /*0x3706f08*/ void set_Step(long value);
            /*0x37070b8*/ void MoveAfter();
            /*0x3707150*/ void SetCurrent(object value, System.IFormatProvider formatProvider);
            /*0x3707184*/ void SetCurrentAndIncrement(object value);
            /*0x3706d80*/ bool BoundaryCheck(System.Numerics.BigInteger value);
        }

        class DataException : System.SystemException
        {
            /*0x3707264*/ DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370726c*/ DataException();
            /*0x37072c8*/ DataException(string s);
            /*0x37072ec*/ DataException(string s, System.Exception innerException);
        }

        class ConstraintException : System.Data.DataException
        {
            /*0x37072f4*/ ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x37072fc*/ ConstraintException();
            /*0x3707358*/ ConstraintException(string s);
        }

        class DeletedRowInaccessibleException : System.Data.DataException
        {
            /*0x370737c*/ DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x3707384*/ DeletedRowInaccessibleException();
            /*0x37073e0*/ DeletedRowInaccessibleException(string s);
        }

        class DuplicateNameException : System.Data.DataException
        {
            /*0x3707404*/ DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370740c*/ DuplicateNameException();
            /*0x3707468*/ DuplicateNameException(string s);
        }

        class InRowChangingEventException : System.Data.DataException
        {
            /*0x370748c*/ InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x3707494*/ InRowChangingEventException();
            /*0x37074f0*/ InRowChangingEventException(string s);
        }

        class InvalidConstraintException : System.Data.DataException
        {
            /*0x3707514*/ InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370751c*/ InvalidConstraintException();
            /*0x3707578*/ InvalidConstraintException(string s);
        }

        class NoNullAllowedException : System.Data.DataException
        {
            /*0x370759c*/ NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x37075a4*/ NoNullAllowedException();
            /*0x3707600*/ NoNullAllowedException(string s);
        }

        class ReadOnlyException : System.Data.DataException
        {
            /*0x3707624*/ ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370762c*/ ReadOnlyException();
            /*0x3707688*/ ReadOnlyException(string s);
        }

        class RowNotInTableException : System.Data.DataException
        {
            /*0x37076ac*/ RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x37076b4*/ RowNotInTableException();
            /*0x3707710*/ RowNotInTableException(string s);
        }

        class VersionNotFoundException : System.Data.DataException
        {
            /*0x3707734*/ VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370773c*/ VersionNotFoundException();
            /*0x3707798*/ VersionNotFoundException(string s);
        }

        class ExceptionBuilder
        {
            static /*0x37077bc*/ void TraceException(string trace, System.Exception e);
            static /*0x3707854*/ System.Exception TraceExceptionAsReturnValue(System.Exception e);
            static /*0x37031f8*/ System.Exception TraceExceptionForCapture(System.Exception e);
            static /*0x370343c*/ System.Exception TraceExceptionWithoutRethrow(System.Exception e);
            static /*0x37078a4*/ System.Exception _Argument(string error);
            static /*0x3707900*/ System.Exception _Argument(string error, System.Exception innerException);
            static /*0x370796c*/ System.Exception _ArgumentNull(string paramName, string msg);
            static /*0x37079d8*/ System.Exception _ArgumentOutOfRange(string paramName, string msg);
            static /*0x3707a44*/ System.Exception _IndexOutOfRange(string error);
            static /*0x3707aa0*/ System.Exception _InvalidOperation(string error);
            static /*0x3707afc*/ System.Exception _InvalidEnumArgumentException(string error);
            static /*0x1ffc854*/ System.Exception _InvalidEnumArgumentException<T>(T value);
            static /*0x3707b58*/ void ThrowDataException(string error, System.Exception innerException);
            static /*0x3707ba8*/ System.Exception _Data(string error);
            static /*0x3707c10*/ System.Exception _Constraint(string error);
            static /*0x3707c78*/ System.Exception _InvalidConstraint(string error);
            static /*0x3707ce0*/ System.Exception _DeletedRowInaccessible(string error);
            static /*0x3707d48*/ System.Exception _DuplicateName(string error);
            static /*0x3707db0*/ System.Exception _InRowChangingEvent(string error);
            static /*0x3707e18*/ System.Exception _NoNullAllowed(string error);
            static /*0x3707e80*/ System.Exception _ReadOnly(string error);
            static /*0x3707ee8*/ System.Exception _RowNotInTable(string error);
            static /*0x3707f50*/ System.Exception _VersionNotFound(string error);
            static /*0x36ff968*/ System.Exception ArgumentNull(string paramName);
            static /*0x3707fb8*/ System.Exception ArgumentOutOfRange(string paramName);
            static /*0x370800c*/ System.Exception BadObjectPropertyAccess(string error);
            static /*0x3708058*/ System.Exception TypeNotAllowed(System.Type type);
            static /*0x37080c4*/ System.Exception CaseInsensitiveNameConflict(string name);
            static /*0x3708110*/ System.Exception NamespaceNameConflict(string name);
            static /*0x370815c*/ System.Exception InvalidOffsetLength();
            static /*0x370819c*/ System.Exception ColumnNotInTheTable(string column, string table);
            static /*0x37081f8*/ System.Exception ColumnNotInAnyTable();
            static /*0x3708238*/ System.Exception ColumnOutOfRange(int index);
            static /*0x37082c8*/ System.Exception ColumnOutOfRange(string column);
            static /*0x3708314*/ System.Exception CannotAddColumn1(string column);
            static /*0x3708360*/ System.Exception CannotAddColumn2(string column);
            static /*0x3704e34*/ System.Exception CannotAddColumn3();
            static /*0x3704e74*/ System.Exception CannotAddColumn4(string column);
            static /*0x37083ac*/ System.Exception CannotAddDuplicate(string column);
            static /*0x37083f8*/ System.Exception CannotAddDuplicate2(string table);
            static /*0x3708444*/ System.Exception CannotAddDuplicate3(string table);
            static /*0x3708490*/ System.Exception CannotRemoveColumn();
            static /*0x37084d0*/ System.Exception CannotRemovePrimaryKey();
            static /*0x3708510*/ System.Exception CannotRemoveChildKey(string relation);
            static /*0x370855c*/ System.Exception CannotRemoveConstraint(string constraint, string table);
            static /*0x37085b8*/ System.Exception CannotRemoveExpression(string column, string expression);
            static /*0x3708614*/ System.Exception AddPrimaryKeyConstraint();
            static /*0x3708654*/ System.Exception NoConstraintName();
            static /*0x3708694*/ System.Exception ConstraintViolation(string constraint);
            static /*0x37086e0*/ string KeysToString(object[] keys);
            static /*0x37087f8*/ string UniqueConstraintViolationText(System.Data.DataColumn[] columns, object[] values);
            static /*0x3708968*/ System.Exception ConstraintViolation(System.Data.DataColumn[] columns, object[] values);
            static /*0x3708978*/ System.Exception ConstraintOutOfRange(int index);
            static /*0x3708a08*/ System.Exception DuplicateConstraint(string constraint);
            static /*0x3708a54*/ System.Exception DuplicateConstraintName(string constraint);
            static /*0x3708aa0*/ System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk);
            static /*0x3708b28*/ System.Exception UniqueConstraintViolation();
            static /*0x3708b68*/ System.Exception ConstraintForeignTable();
            static /*0x3708ba8*/ System.Exception ConstraintParentValues();
            static /*0x3708be8*/ System.Exception ConstraintAddFailed(System.Data.DataTable table);
            static /*0x3708c3c*/ System.Exception ConstraintRemoveFailed();
            static /*0x3708c7c*/ System.Exception FailedCascadeDelete(string constraint);
            static /*0x3708cc8*/ System.Exception FailedCascadeUpdate(string constraint);
            static /*0x3708d14*/ System.Exception FailedClearParentTable(string table, string constraint, string childTable);
            static /*0x3708d78*/ System.Exception ForeignKeyViolation(string constraint, object[] keys);
            static /*0x3708de0*/ System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint);
            static /*0x37060a4*/ string MaxLengthViolationText(string columnName);
            static /*0x3706218*/ string NotAllowDBNullViolationText(string columnName);
            static /*0x3708e48*/ System.Exception CantAddConstraintToMultipleNestedTable(string tableName);
            static /*0x3700b44*/ System.Exception AutoIncrementAndExpression();
            static /*0x3700b84*/ System.Exception AutoIncrementAndDefaultValue();
            static /*0x370694c*/ System.Exception AutoIncrementSeed();
            static /*0x37024b4*/ System.Exception CantChangeDataType();
            static /*0x37024f4*/ System.Exception NullDataType();
            static /*0x3702078*/ System.Exception ColumnNameRequired();
            static /*0x3702efc*/ System.Exception DefaultValueAndAutoIncrement();
            static /*0x3702b14*/ System.Exception DefaultValueDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x3702f3c*/ System.Exception DefaultValueColumnDataType(string column, System.Type defaultType, System.Type columnType, System.Exception inner);
            static /*0x3703048*/ System.Exception ExpressionAndUnique();
            static /*0x3703248*/ System.Exception ExpressionAndReadOnly();
            static /*0x3703088*/ System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint);
            static /*0x3708e94*/ System.Exception ExpressionInConstraint(System.Data.DataColumn column);
            static /*0x3703288*/ System.Exception ExpressionCircular();
            static /*0x3705110*/ System.Exception NonUniqueValues(string column);
            static /*0x3705078*/ System.Exception NullKeyValues(string column);
            static /*0x37050c4*/ System.Exception NullValues(string column);
            static /*0x37040d0*/ System.Exception ReadOnlyAndExpression();
            static /*0x3708ee8*/ System.Exception ReadOnly(string column);
            static /*0x3704ad4*/ System.Exception UniqueAndExpression();
            static /*0x3704474*/ System.Exception SetFailed(object value, System.Data.DataColumn column, System.Type type, System.Exception innerException);
            static /*0x3708f34*/ System.Exception CannotSetToNull(System.Data.DataColumn column);
            static /*0x3705024*/ System.Exception LongerThanMaxLength(System.Data.DataColumn column);
            static /*0x3703cfc*/ System.Exception CannotSetMaxLength(System.Data.DataColumn column, int value);
            static /*0x3703908*/ System.Exception CannotSetMaxLength2(System.Data.DataColumn column);
            static /*0x3702c28*/ System.Exception CannotSetSimpleContentType(string columnName, System.Type type);
            static /*0x3704dd8*/ System.Exception CannotSetSimpleContent(string columnName, System.Type type);
            static /*0x3703f2c*/ System.Exception CannotChangeNamespace(string columnName);
            static /*0x370395c*/ System.Exception HasToBeStringType(System.Data.DataColumn column);
            static /*0x3700e5c*/ System.Exception AutoIncrementCannotSetIfHasData(string typeName);
            static /*0x3708f88*/ System.Exception INullableUDTwithoutStaticNull(string typeName);
            static /*0x3708fd4*/ System.Exception IComparableNotImplemented(string typeName);
            static /*0x3709020*/ System.Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName);
            static /*0x370906c*/ System.Exception InvalidDataColumnMapping(System.Type type);
            static /*0x3702dac*/ System.Exception CannotSetDateTimeModeForNonDateTimeColumns();
            static /*0x3702ea4*/ System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode);
            static /*0x3702dec*/ System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue);
            static /*0x36ff9bc*/ System.Exception ColumnTypeNotSupported();
            static /*0x37090d8*/ System.Exception SetFailed(string name);
            static /*0x3709124*/ System.Exception CanNotUse();
            static /*0x3709164*/ System.Exception SetIListObject();
            static /*0x37091a4*/ System.Exception AddNewNotAllowNull();
            static /*0x37091e4*/ System.Exception NotOpen();
            static /*0x3709224*/ System.Exception CreateChildView();
            static /*0x3709264*/ System.Exception CanNotDelete();
            static /*0x37092a4*/ System.Exception GetElementIndex(int index);
            static /*0x3709334*/ System.Exception AddExternalObject();
            static /*0x3709374*/ System.Exception CanNotClear();
            static /*0x37093b4*/ System.Exception InsertExternalObject();
            static /*0x37093f4*/ System.Exception RemoveExternalObject();
            static /*0x3709434*/ System.Exception KeyTableMismatch();
            static /*0x3709474*/ System.Exception KeyNoColumns();
            static /*0x37094b4*/ System.Exception KeyTooManyColumns(int cols);
            static /*0x3709544*/ System.Exception KeyDuplicateColumns(string columnName);
            static /*0x3709590*/ System.Exception RelationDataSetMismatch();
            static /*0x3702684*/ System.Exception ColumnsTypeMismatch();
            static /*0x37095d0*/ System.Exception KeyLengthMismatch();
            static /*0x3709610*/ System.Exception KeyLengthZero();
            static /*0x3709650*/ System.Exception ForeignRelation();
            static /*0x3709690*/ System.Exception KeyColumnsIdentical();
            static /*0x37096d0*/ System.Exception RelationForeignTable(string t1, string t2);
            static /*0x370972c*/ System.Exception GetParentRowTableMismatch(string t1, string t2);
            static /*0x3709788*/ System.Exception SetParentRowTableMismatch(string t1, string t2);
            static /*0x37097e4*/ System.Exception RelationForeignRow();
            static /*0x3709824*/ System.Exception RelationNestedReadOnly();
            static /*0x3709864*/ System.Exception TableCantBeNestedInTwoTables(string tableName);
            static /*0x37098b0*/ System.Exception LoopInNestedRelations(string tableName);
            static /*0x37098fc*/ System.Exception RelationDoesNotExist();
            static /*0x370993c*/ System.Exception ParentOrChildColumnsDoNotHaveDataSet();
            static /*0x370997c*/ System.Exception InValidNestedRelation(string childTableName);
            static /*0x37099c8*/ System.Exception InvalidParentNamespaceinNestedRelation(string childTableName);
            static /*0x3709a14*/ System.Exception RowNotInTheDataSet();
            static /*0x3709a54*/ System.Exception RowNotInTheTable();
            static /*0x3709a94*/ System.Exception EditInRowChanging();
            static /*0x3709ad4*/ System.Exception EndEditInRowChanging();
            static /*0x3709b14*/ System.Exception BeginEditInRowChanging();
            static /*0x3709b54*/ System.Exception CancelEditInRowChanging();
            static /*0x3709b94*/ System.Exception DeleteInRowDeleting();
            static /*0x3709bd4*/ System.Exception ValueArrayLength();
            static /*0x3709c14*/ System.Exception NoCurrentData();
            static /*0x3709c54*/ System.Exception NoOriginalData();
            static /*0x3709c94*/ System.Exception NoProposedData();
            static /*0x3709cd4*/ System.Exception RowRemovedFromTheTable();
            static /*0x3709d14*/ System.Exception DeletedRowInaccessible();
            static /*0x3709d54*/ System.Exception RowAlreadyDeleted();
            static /*0x3709d94*/ System.Exception RowEmpty();
            static /*0x3709dd4*/ System.Exception InvalidRowVersion();
            static /*0x3709e14*/ System.Exception RowOutOfRange(int index);
            static /*0x3709ea4*/ System.Exception RowInsertTwice(int index, string tableName);
            static /*0x3709f44*/ System.Exception RowInsertMissing(string tableName);
            static /*0x3709f90*/ System.Exception RowAlreadyRemoved();
            static /*0x3709fd0*/ System.Exception MultipleParents();
            static /*0x370a010*/ System.Exception InvalidRowState(System.Data.DataRowState state);
            static /*0x370a068*/ System.Exception InvalidRowBitPattern();
            static /*0x370a0a8*/ System.Exception SetDataSetNameToEmpty();
            static /*0x370a0e8*/ System.Exception SetDataSetNameConflicting(string name);
            static /*0x370a134*/ System.Exception DataSetUnsupportedSchema(string ns);
            static /*0x370a180*/ System.Exception MergeMissingDefinition(string obj);
            static /*0x370a1cc*/ System.Exception TablesInDifferentSets();
            static /*0x370a20c*/ System.Exception RelationAlreadyExists();
            static /*0x370a24c*/ System.Exception RowAlreadyInOtherCollection();
            static /*0x370a28c*/ System.Exception RowAlreadyInTheCollection();
            static /*0x370a2cc*/ System.Exception RecordStateRange();
            static /*0x370a30c*/ System.Exception IndexKeyLength(int length, int keyLength);
            static /*0x370a3e8*/ System.Exception RemovePrimaryKey(System.Data.DataTable table);
            static /*0x370a464*/ System.Exception RelationAlreadyInOtherDataSet();
            static /*0x370a4a4*/ System.Exception RelationAlreadyInTheDataSet();
            static /*0x370a4e4*/ System.Exception RelationNotInTheDataSet(string relation);
            static /*0x370a530*/ System.Exception RelationOutOfRange(object index);
            static /*0x370a5b4*/ System.Exception DuplicateRelation(string relation);
            static /*0x370a600*/ System.Exception RelationTableNull();
            static /*0x370a640*/ System.Exception RelationDataSetNull();
            static /*0x370a680*/ System.Exception RelationTableWasRemoved();
            static /*0x370a6c0*/ System.Exception ParentTableMismatch();
            static /*0x370a700*/ System.Exception ChildTableMismatch();
            static /*0x370a740*/ System.Exception EnforceConstraint();
            static /*0x370a780*/ System.Exception CaseLocaleMismatch();
            static /*0x370a7c0*/ System.Exception CannotChangeCaseLocale();
            static /*0x370a7c8*/ System.Exception CannotChangeCaseLocale(System.Exception innerException);
            static /*0x370a810*/ System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode);
            static /*0x370a868*/ System.Exception TableForeignPrimaryKey();
            static /*0x370a8a8*/ System.Exception TableCannotAddToSimpleContent();
            static /*0x370a8e8*/ System.Exception NoTableName();
            static /*0x370a928*/ System.Exception MultipleTextOnlyColumns();
            static /*0x370a968*/ System.Exception InvalidSortString(string sort);
            static /*0x370a9b4*/ System.Exception DuplicateTableName(string table);
            static /*0x370aa00*/ System.Exception DuplicateTableName2(string table, string ns);
            static /*0x370aa5c*/ System.Exception SelfnestedDatasetConflictingName(string table);
            static /*0x370aaa8*/ System.Exception DatasetConflictingName(string table);
            static /*0x370aaf4*/ System.Exception TableAlreadyInOtherDataSet();
            static /*0x370ab34*/ System.Exception TableAlreadyInTheDataSet();
            static /*0x370ab74*/ System.Exception TableOutOfRange(int index);
            static /*0x370ac04*/ System.Exception TableNotInTheDataSet(string table);
            static /*0x370ac50*/ System.Exception TableInRelation();
            static /*0x370ac90*/ System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint);
            static /*0x370ad08*/ System.Exception CanNotSerializeDataTableHierarchy();
            static /*0x370ad48*/ System.Exception CanNotRemoteDataTable();
            static /*0x370ad88*/ System.Exception CanNotSetRemotingFormat();
            static /*0x370adc8*/ System.Exception CanNotSerializeDataTableWithEmptyName();
            static /*0x370ae08*/ System.Exception TableNotFound(string tableName);
            static /*0x370ae54*/ System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type);
            static /*0x370af0c*/ System.Exception InvalidStorageType(System.TypeCode typecode);
            static /*0x370afa0*/ System.Exception RangeArgument(int min, int max);
            static /*0x370b054*/ System.Exception NullRange();
            static /*0x370b094*/ System.Exception NegativeMinimumCapacity();
            static /*0x370b0d4*/ System.Exception ProblematicChars(char charValue);
            static /*0x370b1b0*/ System.Exception StorageSetFailed();
            static /*0x370b1f0*/ System.Exception SimpleTypeNotSupported();
            static /*0x370b230*/ System.Exception MissingAttribute(string attribute);
            static /*0x370b250*/ System.Exception MissingAttribute(string element, string attribute);
            static /*0x370b2ac*/ System.Exception InvalidAttributeValue(string name, string value);
            static /*0x370b308*/ System.Exception AttributeValues(string name, string value1, string value2);
            static /*0x370b36c*/ System.Exception ElementTypeNotFound(string name);
            static /*0x370b3b8*/ System.Exception RelationParentNameMissing(string rel);
            static /*0x370b404*/ System.Exception RelationChildNameMissing(string rel);
            static /*0x370b450*/ System.Exception RelationTableKeyMissing(string rel);
            static /*0x370b49c*/ System.Exception RelationChildKeyMissing(string rel);
            static /*0x370b4e8*/ System.Exception UndefinedDatatype(string name);
            static /*0x370b534*/ System.Exception DatatypeNotDefined();
            static /*0x370b574*/ System.Exception MismatchKeyLength();
            static /*0x370b5b4*/ System.Exception InvalidField(string name);
            static /*0x370b600*/ System.Exception InvalidSelector(string name);
            static /*0x370b64c*/ System.Exception CircularComplexType(string name);
            static /*0x370b698*/ System.Exception CannotInstantiateAbstract(string name);
            static /*0x370b6e4*/ System.Exception InvalidKey(string name);
            static /*0x370b730*/ System.Exception DiffgramMissingTable(string name);
            static /*0x370b77c*/ System.Exception DiffgramMissingSQL();
            static /*0x370b7bc*/ System.Exception DuplicateConstraintRead(string str);
            static /*0x370b808*/ System.Exception ColumnTypeConflict(string name);
            static /*0x370b854*/ System.Exception CannotConvert(string name, string type);
            static /*0x370b8b0*/ System.Exception MissingRefer(string name);
            static /*0x3702328*/ System.Exception InvalidPrefix(string name);
            static /*0x370b934*/ System.Exception CanNotDeserializeObjectType();
            static /*0x370b974*/ System.Exception IsDataSetAttributeMissingInSchema();
            static /*0x370b9b4*/ System.Exception TooManyIsDataSetAtributeInSchema();
            static /*0x370b9f4*/ System.Exception NestedCircular(string name);
            static /*0x370ba40*/ System.Exception MultipleParentRows(string tableQName);
            static /*0x370ba8c*/ System.Exception PolymorphismNotSupported(string typeName);
            static /*0x370bad8*/ System.Exception DataTableInferenceNotSupported();
            static /*0x370bb18*/ void ThrowMultipleTargetConverter(System.Exception innerException);
            static /*0x370bb78*/ System.Exception DuplicateDeclaration(string name);
            static /*0x370bbc4*/ System.Exception FoundEntity();
            static /*0x370bc04*/ System.Exception MergeFailed(string name);
            static /*0x370bc08*/ System.Exception ConvertFailed(System.Type type1, System.Type type2);
            static /*0x370bc98*/ System.Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr);
            static /*0x370bcf4*/ System.Exception InternalRBTreeError(System.Data.RBTreeError internalError);
            static /*0x370bd68*/ System.Exception EnumeratorModified();
        }

        class DataSet : System.ComponentModel.MarshalByValueComponent, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ int s_objectTypeCount;
            static /*0x8*/ System.Xml.Schema.XmlSchemaComplexType s_schemaTypeForWSDL;
            /*0x20*/ System.Data.DataViewManager _defaultViewManager;
            /*0x28*/ System.Data.DataTableCollection _tableCollection;
            /*0x30*/ System.Data.DataRelationCollection _relationCollection;
            /*0x38*/ System.Data.PropertyCollection _extendedProperties;
            /*0x40*/ string _dataSetName;
            /*0x48*/ string _datasetPrefix;
            /*0x50*/ string _namespaceURI;
            /*0x58*/ bool _enforceConstraints;
            /*0x59*/ bool _caseSensitive;
            /*0x60*/ System.Globalization.CultureInfo _culture;
            /*0x68*/ bool _cultureUserSet;
            /*0x69*/ bool _fInReadXml;
            /*0x6a*/ bool _fInLoadDiffgram;
            /*0x6b*/ bool _fTopLevelTable;
            /*0x6c*/ bool _fInitInProgress;
            /*0x6d*/ bool _fEnableCascading;
            /*0x6e*/ bool _fIsSchemaLoading;
            /*0x70*/ string _mainTableName;
            /*0x78*/ System.Data.SerializationFormat _remotingFormat;
            /*0x80*/ object _defaultViewManagerLock;
            /*0x88*/ int _objectID;
            /*0x8c*/ bool _useDataSetSchemaOnly;
            /*0x8d*/ bool _udtIsWrapped;
            /*0x90*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanging;
            /*0x98*/ System.Data.MergeFailedEventHandler MergeFailed;
            /*0xa0*/ System.Data.DataRowCreatedEventHandler DataRowCreated;
            /*0xa8*/ System.Data.DataSetClearEventhandler ClearFunctionCalled;

            static /*0x3713008*/ void MoveToElement(System.Xml.XmlReader reader);
            static /*0x37173a4*/ System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x370bda8*/ DataSet();
            /*0x370c058*/ DataSet(string dataSetName);
            /*0x370c288*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370c290*/ DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema);
            /*0x370c1d8*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x370c1e0*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x370c280*/ System.Data.SchemaSerializationMode get_SchemaSerializationMode();
            /*0x370c4d0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370cad8*/ void InitializeDerivedDataSet();
            /*0x370c4d8*/ void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x370c488*/ void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x370d778*/ void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode);
            /*0x370dc0c*/ void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat);
            /*0x370cadc*/ void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370ddac*/ void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370cc4c*/ void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370e080*/ void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x370f1b4*/ void FailedEnableConstraints();
            /*0x370f350*/ bool get_CaseSensitive();
            /*0x370f358*/ void set_CaseSensitive(bool value);
            /*0x370fa2c*/ bool get_EnforceConstraints();
            /*0x370f1e0*/ void set_EnforceConstraints(bool value);
            /*0x3710108*/ void RestoreEnforceConstraints(bool value);
            /*0x370fa34*/ void EnableConstraints();
            /*0x3710110*/ string get_DataSetName();
            /*0x370c080*/ void set_DataSetName(string value);
            /*0x3710190*/ string get_Namespace();
            /*0x3710198*/ void set_Namespace(string value);
            /*0x3710638*/ string get_Prefix();
            /*0x3710640*/ void set_Prefix(string value);
            /*0x370f144*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x3710768*/ System.Globalization.CultureInfo get_Locale();
            /*0x3710770*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x37108f8*/ void SetLocaleValue(System.Globalization.CultureInfo value, bool userSet);
            /*0x3711464*/ bool ShouldSerializeLocale();
            /*0x371146c*/ System.ComponentModel.ISite get_Site();
            /*0x3711474*/ System.Data.DataRelationCollection get_Relations();
            /*0x371147c*/ System.Data.DataTableCollection get_Tables();
            /*0x3711484*/ void Clear();
            /*0x37116a0*/ System.Data.DataSet Clone();
            /*0x370d458*/ int EstimatedXmlStringSize();
            /*0x3712604*/ string GetRemotingDiffGram(System.Data.DataTable table);
            /*0x370d2c4*/ string GetXmlSchemaForRemoting(System.Data.DataTable table);
            /*0x3712734*/ void ReadXmlSchema(System.Xml.XmlReader reader);
            /*0x370e894*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x3712b3c*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x3712bf0*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x3712894*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x371273c*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x3713080*/ void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x37132a8*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader);
            /*0x37132b0*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, bool denyResolving);
            /*0x3712c8c*/ void InferSchema(System.Xml.XmlDocument xdoc, string[] excludedNamespaces, System.Data.XmlReadMode mode);
            /*0x37155c0*/ bool IsEmpty();
            /*0x37143b4*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x370f13c*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode);
            /*0x37159f4*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x370d578*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode);
            /*0x3715880*/ void Merge(System.Data.DataSet dataSet);
            /*0x37167cc*/ void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x3716a28*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x3716a50*/ void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent);
            /*0x3716aa8*/ void RaiseMergeFailed(System.Data.DataTable table, string conflict, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x3716b4c*/ void OnDataRowCreated(System.Data.DataRow row);
            /*0x3711678*/ void OnClearFunctionCalled(System.Data.DataTable table);
            /*0x3716b74*/ void OnRemoveTable(System.Data.DataTable table);
            /*0x3716b78*/ void OnRemovedTable(System.Data.DataTable table);
            /*0x3716b9c*/ void OnRemoveRelation(System.Data.DataRelation relation);
            /*0x3716ba0*/ void OnRemoveRelationHack(System.Data.DataRelation relation);
            /*0x3710118*/ void RaisePropertyChanging(string name);
            /*0x3716bb0*/ System.Data.DataTable[] TopLevelTables();
            /*0x3716bb8*/ System.Data.DataTable[] TopLevelTables(bool forSchema);
            /*0x3716e14*/ void Reset();
            /*0x370f648*/ bool ValidateCaseConstraint();
            /*0x3711028*/ bool ValidateLocaleConstraint();
            /*0x37170bc*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x3717630*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x37177f8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x3717a48*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x3717a7c*/ string get_MainTableName();
            /*0x3717a84*/ void set_MainTableName(string value);
            /*0x3717a8c*/ int get_ObjectID();
        }

        class DataTable : System.ComponentModel.MarshalByValueComponent, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ System.Data.DataView _defaultView;
            /*0x30*/ long _nextRowID;
            /*0x38*/ System.Data.DataRowCollection _rowCollection;
            /*0x40*/ System.Data.DataColumnCollection _columnCollection;
            /*0x48*/ System.Data.ConstraintCollection _constraintCollection;
            /*0x50*/ int _elementColumnCount;
            /*0x58*/ System.Data.DataRelationCollection _parentRelationsCollection;
            /*0x60*/ System.Data.DataRelationCollection _childRelationsCollection;
            /*0x68*/ System.Data.RecordManager _recordManager;
            /*0x70*/ System.Collections.Generic.List<System.Data.Index> _indexes;
            /*0x78*/ System.Collections.Generic.List<System.Data.Index> _shadowIndexes;
            /*0x80*/ int _shadowCount;
            /*0x88*/ System.Data.PropertyCollection _extendedProperties;
            /*0x90*/ string _tableName;
            /*0x98*/ string _tableNamespace;
            /*0xa0*/ string _tablePrefix;
            /*0xa8*/ System.Data.DataExpression _displayExpression;
            /*0xb0*/ bool _fNestedInDataset;
            /*0xb8*/ System.Globalization.CultureInfo _culture;
            /*0xc0*/ bool _cultureUserSet;
            /*0xc8*/ System.Globalization.CompareInfo _compareInfo;
            /*0xd0*/ System.Globalization.CompareOptions _compareFlags;
            /*0xd8*/ System.IFormatProvider _formatProvider;
            /*0xe0*/ System.StringComparer _hashCodeProvider;
            /*0xe8*/ bool _caseSensitive;
            /*0xe9*/ bool _caseSensitiveUserSet;
            /*0xf0*/ string _encodedTableName;
            /*0xf8*/ System.Data.DataColumn _xmlText;
            /*0x100*/ System.Data.DataColumn _colUnique;
            /*0x108*/ decimal _minOccurs;
            /*0x118*/ decimal _maxOccurs;
            /*0x128*/ bool _repeatableElement;
            /*0x130*/ object _typeName;
            /*0x138*/ System.Data.UniqueConstraint _primaryKey;
            /*0x140*/ System.Data.IndexField[] _primaryIndex;
            /*0x148*/ System.Data.DataColumn[] _delayedSetPrimaryKey;
            /*0x150*/ System.Data.Index _loadIndex;
            /*0x158*/ System.Data.Index _loadIndexwithOriginalAdded;
            /*0x160*/ System.Data.Index _loadIndexwithCurrentDeleted;
            /*0x168*/ int _suspendIndexEvents;
            /*0x16c*/ bool _inDataLoad;
            /*0x16d*/ bool _schemaLoading;
            /*0x16e*/ bool _enforceConstraints;
            /*0x16f*/ bool _suspendEnforceConstraints;
            /*0x170*/ bool fInitInProgress;
            /*0x171*/ bool _inLoad;
            /*0x172*/ bool _fInLoadDiffgram;
            /*0x173*/ byte _isTypedDataTable;
            /*0x178*/ System.Data.DataRow[] _emptyDataRowArray;
            /*0x180*/ System.ComponentModel.PropertyDescriptorCollection _propertyDescriptorCollectionCache;
            /*0x188*/ System.Data.DataRelation[] _nestedParentRelations;
            /*0x190*/ System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns;
            /*0x198*/ bool _mergingData;
            /*0x1a0*/ System.Data.DataRowChangeEventHandler _onRowChangedDelegate;
            /*0x1a8*/ System.Data.DataRowChangeEventHandler _onRowChangingDelegate;
            /*0x1b0*/ System.Data.DataRowChangeEventHandler _onRowDeletingDelegate;
            /*0x1b8*/ System.Data.DataRowChangeEventHandler _onRowDeletedDelegate;
            /*0x1c0*/ System.Data.DataColumnChangeEventHandler _onColumnChangedDelegate;
            /*0x1c8*/ System.Data.DataColumnChangeEventHandler _onColumnChangingDelegate;
            /*0x1d0*/ System.Data.DataTableClearEventHandler _onTableClearingDelegate;
            /*0x1d8*/ System.Data.DataTableClearEventHandler _onTableClearedDelegate;
            /*0x1e0*/ System.Data.DataTableNewRowEventHandler _onTableNewRowDelegate;
            /*0x1e8*/ System.ComponentModel.PropertyChangedEventHandler _onPropertyChangingDelegate;
            /*0x1f0*/ System.Data.DataRowBuilder _rowBuilder;
            /*0x1f8*/ System.Collections.Generic.List<System.Data.DataView> _delayedViews;
            /*0x200*/ System.Collections.Generic.List<System.Data.DataViewListener> _dataViewListeners;
            /*0x208*/ System.Collections.Hashtable _rowDiffId;
            /*0x210*/ System.Threading.ReaderWriterLockSlim _indexesLock;
            /*0x218*/ int _ukColumnPositionForInference;
            /*0x21c*/ System.Data.SerializationFormat _remotingFormat;
            /*0x220*/ int _objectID;

            static /*0x36fe318*/ System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet);
            /*0x36e72b4*/ DataTable();
            /*0x36e7828*/ DataTable(string tableName);
            /*0x36e7890*/ DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x36e7d10*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x36e7de8*/ void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x36e7a28*/ void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat);
            /*0x36e80c0*/ void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x36e936c*/ void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool isSingleTable);
            /*0x36ec110*/ void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x36ed0d0*/ void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex, bool allConstraints);
            /*0x36edd30*/ void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x36ede80*/ void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x36e8d30*/ void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x36ea218*/ void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, int serIndex);
            /*0x36ee284*/ System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, int bitIndex);
            /*0x36edfd8*/ void GetRowAndColumnErrors(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x36ee32c*/ void ConvertToRowError(int rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors);
            /*0x36ee5dc*/ bool get_CaseSensitive();
            /*0x36ee5e4*/ void set_CaseSensitive(bool value);
            /*0x36ee684*/ bool get_AreIndexEventsSuspended();
            /*0x36ee694*/ void RestoreIndexEvents(bool forceReset);
            /*0x36eea7c*/ void SuspendIndexEvents();
            /*0x36eeb3c*/ bool get_IsTypedDataTable();
            /*0x36ec834*/ bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes);
            /*0x36eebf0*/ bool ShouldSerializeCaseSensitive();
            /*0x36eebf8*/ bool get_SelfNested();
            /*0x36eef5c*/ System.Collections.Generic.List<System.Data.Index> get_LiveIndexes();
            /*0x36ef018*/ System.Data.SerializationFormat get_RemotingFormat();
            /*0x36ef020*/ void set_RemotingFormat(System.Data.SerializationFormat value);
            /*0x36ef080*/ int get_UKColumnPositionForInference();
            /*0x36ef088*/ void set_UKColumnPositionForInference(int value);
            /*0x36ef090*/ System.Data.DataRelationCollection get_ChildRelations();
            /*0x36ef10c*/ System.Data.DataColumnCollection get_Columns();
            /*0x36ef114*/ System.Globalization.CompareInfo get_CompareInfo();
            /*0x36ef168*/ System.Data.ConstraintCollection get_Constraints();
            /*0x36ef170*/ void ResetConstraints();
            /*0x36ef188*/ System.Data.DataSet get_DataSet();
            /*0x36ef190*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x36ef254*/ string get_DisplayExpressionInternal();
            /*0x36ef27c*/ bool get_EnforceConstraints();
            /*0x36ef2ac*/ void set_EnforceConstraints(bool value);
            /*0x36ef868*/ bool get_SuspendEnforceConstraints();
            /*0x36ef870*/ void set_SuspendEnforceConstraints(bool value);
            /*0x36ef2f0*/ void EnableConstraints();
            /*0x36ebb5c*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x36ef878*/ System.IFormatProvider get_FormatProvider();
            /*0x36ef918*/ System.Globalization.CultureInfo get_Locale();
            /*0x36ef920*/ void set_Locale(System.Globalization.CultureInfo value);
            /*0x36ecb20*/ bool SetLocaleValue(System.Globalization.CultureInfo culture, bool userSet, bool resetIndexes);
            /*0x36efdc0*/ bool ShouldSerializeLocale();
            /*0x36efdc8*/ int get_MinimumCapacity();
            /*0x36ed0a8*/ void set_MinimumCapacity(int value);
            /*0x36efde0*/ int get_RecordCapacity();
            /*0x36efdf8*/ int get_ElementColumnCount();
            /*0x36efe00*/ void set_ElementColumnCount(int value);
            /*0x36eeee0*/ System.Data.DataRelationCollection get_ParentRelations();
            /*0x36efe40*/ bool get_MergingData();
            /*0x36efe48*/ void set_MergingData(bool value);
            /*0x36efe50*/ System.Data.DataRelation[] get_NestedParentRelations();
            /*0x36efe58*/ bool get_SchemaLoading();
            /*0x36efe60*/ void CacheNestedParent();
            /*0x36efe80*/ System.Data.DataRelation[] FindNestedParentRelations();
            /*0x36f0270*/ int get_NestedParentsCount();
            /*0x36f0528*/ System.Data.DataColumn[] get_PrimaryKey();
            /*0x36f05e4*/ void set_PrimaryKey(System.Data.DataColumn[] value);
            /*0x36f0a50*/ System.Data.DataRowCollection get_Rows();
            /*0x36f0a58*/ string get_TableName();
            /*0x36f0a60*/ void set_TableName(string value);
            /*0x36f1000*/ string get_EncodedTableName();
            /*0x36f1084*/ string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables);
            /*0x36e92e8*/ string get_Namespace();
            /*0x36eb834*/ void set_Namespace(string value);
            /*0x36f1f4c*/ bool IsNamespaceInherited();
            /*0x36f127c*/ void CheckCascadingNamespaceConflict(string realNamespace);
            /*0x36f161c*/ void CheckNamespaceValidityForNestedRelations(string realNamespace);
            /*0x36f1f5c*/ void CheckNamespaceValidityForNestedParentRelations(string ns, System.Data.DataTable parentTable);
            /*0x36f19f4*/ void DoRaiseNamespaceChange();
            /*0x36f22a8*/ string get_Prefix();
            /*0x36f22b0*/ void set_Prefix(string value);
            /*0x36f2420*/ System.Data.DataColumn get_XmlText();
            /*0x36f2428*/ void set_XmlText(System.Data.DataColumn value);
            /*0x36f24e8*/ decimal get_MaxOccurs();
            /*0x36f24f4*/ void set_MaxOccurs(decimal value);
            /*0x36f24fc*/ decimal get_MinOccurs();
            /*0x36f2508*/ void set_MinOccurs(decimal value);
            /*0x36f2510*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues, int record);
            /*0x36f25a4*/ System.Data.DataRow FindByIndex(System.Data.Index ndx, object[] key);
            /*0x36f263c*/ System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx);
            /*0x36f26bc*/ void SetMergeRecords(System.Data.DataRow row, int newRecord, int oldRecord, System.Data.DataRowAction action);
            /*0x36f2a2c*/ System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, bool preserveChanges, System.Data.Index idxSearch);
            /*0x36f34c0*/ System.Data.DataTable CreateInstance();
            /*0x36f354c*/ System.Data.DataTable Clone();
            /*0x36f3554*/ System.Data.DataTable Clone(System.Data.DataSet cloneDS);
            /*0x36f3738*/ System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable);
            /*0x36f3a44*/ System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap);
            /*0x36eabac*/ System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, bool skipExpressionColumns);
            /*0x36f3e88*/ System.ComponentModel.ISite get_Site();
            /*0x36f3e90*/ void AddRow(System.Data.DataRow row, int proposedID);
            /*0x36f3ea0*/ void InsertRow(System.Data.DataRow row, int proposedID, int pos);
            /*0x36f3eac*/ void InsertRow(System.Data.DataRow row, long proposedID, int pos, bool fireEvent);
            /*0x36f4b5c*/ void CheckNotModifying(System.Data.DataRow row);
            /*0x36f4b84*/ void Clear();
            /*0x36f4b8c*/ void Clear(bool clearAll);
            /*0x36f5548*/ void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x36f5600*/ void CommitRow(System.Data.DataRow row);
            /*0x36f57b8*/ int Compare(string s1, string s2);
            /*0x36f57c0*/ int Compare(string s1, string s2, System.Globalization.CompareInfo comparer);
            /*0x36f5924*/ int IndexOf(string s1, string s2);
            /*0x36f5968*/ bool IsSuffix(string s1, string s2);
            /*0x36f59ac*/ void DeleteRow(System.Data.DataRow row);
            /*0x36f5a04*/ string FormatSortString(System.Data.IndexField[] indexDesc);
            /*0x36f5b2c*/ void FreeRecord(ref int record);
            /*0x36f5b44*/ System.Data.Index GetIndex(string sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x36f5ef4*/ System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x36f60c4*/ System.Collections.Generic.List<System.Data.DataViewListener> GetListeners();
            /*0x36efcbc*/ int GetSpecialHashCode(string name);
            /*0x36f3024*/ void InsertRow(System.Data.DataRow row, long proposedID);
            /*0x36f6e50*/ int NewRecord();
            /*0x36f6f3c*/ int NewUninitializedRecord();
            /*0x36f6e58*/ int NewRecord(int sourceRecord);
            /*0x36ee230*/ System.Data.DataRow NewEmptyRow();
            /*0x36f6f54*/ System.Data.DataRow NewUninitializedRow();
            /*0x36f700c*/ System.Data.DataRow NewRow();
            /*0x36f70c4*/ System.Data.DataRow CreateEmptyRow();
            /*0x36f7040*/ void NewRowCreated(System.Data.DataRow row);
            /*0x36f6f80*/ System.Data.DataRow NewRow(int record);
            /*0x36f7468*/ System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder);
            /*0x36f74c4*/ System.Type GetRowType();
            /*0x36f7524*/ System.Data.DataRow[] NewRowArray(int size);
            /*0x36f76dc*/ bool get_NeedColumnChangeEvents();
            /*0x36f7710*/ void OnColumnChanging(System.Data.DataColumnChangeEventArgs e);
            /*0x36f77e8*/ void OnColumnChanged(System.Data.DataColumnChangeEventArgs e);
            /*0x36f78c0*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x36f7998*/ void OnRemoveColumnInternal(System.Data.DataColumn column);
            /*0x36f79a8*/ void OnRemoveColumn(System.Data.DataColumn column);
            /*0x36f5714*/ System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x36f5670*/ System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x36f79ac*/ void OnRowChanged(System.Data.DataRowChangeEventArgs e);
            /*0x36f7a84*/ void OnRowChanging(System.Data.DataRowChangeEventArgs e);
            /*0x36f7b5c*/ void OnRowDeleting(System.Data.DataRowChangeEventArgs e);
            /*0x36f7c34*/ void OnRowDeleted(System.Data.DataRowChangeEventArgs e);
            /*0x36f7d0c*/ void OnTableCleared(System.Data.DataTableClearEventArgs e);
            /*0x36f7de4*/ void OnTableClearing(System.Data.DataTableClearEventArgs e);
            /*0x36f7ebc*/ void OnTableNewRow(System.Data.DataTableNewRowEventArgs e);
            /*0x36f5b78*/ System.Data.IndexField[] ParseSortString(string sortString);
            /*0x36f0f88*/ void RaisePropertyChanging(string name);
            /*0x36f7f94*/ void RecordChanged(int record);
            /*0x36f80f4*/ void RecordChanged(int[] oldIndex, int[] newIndex);
            /*0x36f6260*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x36f63d8*/ void RecordStateChanged(int record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, int record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2);
            /*0x36f82b0*/ int[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x36f8480*/ int[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x36f8610*/ void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, object newValue);
            /*0x36f8f64*/ void RemoveRow(System.Data.DataRow row, bool check);
            /*0x36f9104*/ void Reset();
            /*0x36eaba4*/ void ResetIndexes();
            /*0x36f93a8*/ void ResetInternalIndexes(System.Data.DataColumn column);
            /*0x36f956c*/ void RollbackRow(System.Data.DataRow row);
            /*0x36f6c30*/ System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x36f95d8*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction);
            /*0x36f60cc*/ System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, bool fireEvent);
            /*0x36f2768*/ void SetNewRecord(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged);
            /*0x36f4258*/ void SetNewRecordWorker(System.Data.DataRow row, int proposedRecord, System.Data.DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, ref System.Exception deferredException);
            /*0x36f27b8*/ void SetOldRecord(System.Data.DataRow row, int proposedRecord);
            /*0x36f97d8*/ void RestoreShadowIndexes();
            /*0x36eea2c*/ void SetShadowIndexes();
            /*0x36f97f8*/ void ShadowIndexCopy();
            /*0x36f988c*/ string ToString();
            /*0x36f95b8*/ bool UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x36f9900*/ System.Data.DataColumn AddUniqueKey(int position);
            /*0x36f9b74*/ System.Data.DataColumn AddUniqueKey();
            /*0x36f9b7c*/ System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey);
            /*0x36f9c28*/ void UpdatePropertyDescriptorCollectionCache();
            /*0x36f9c3c*/ System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes);
            /*0x36ebac8*/ System.Xml.XmlQualifiedName get_TypeName();
            /*0x36f9ea8*/ void set_TypeName(System.Xml.XmlQualifiedName value);
            /*0x36f9eb8*/ void Merge(System.Data.DataTable table);
            /*0x36f9ec4*/ void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x36fa124*/ void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy);
            /*0x36fa4cc*/ bool CheckForClosureOnExpressions(System.Data.DataTable dt, bool writeHierarchy);
            /*0x36ebbcc*/ bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x36fa8ec*/ void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy);
            /*0x36fac14*/ void RestoreConstraint(bool originalEnforceConstraint);
            /*0x36fac68*/ bool IsEmptyXml(System.Xml.XmlReader reader);
            /*0x36fae38*/ System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, bool denyResolving);
            /*0x36fc6d0*/ void ReadEndElement(System.Xml.XmlReader reader);
            /*0x36fc76c*/ void ReadXDRSchema(System.Xml.XmlReader reader);
            /*0x36fdbdc*/ bool MoveToElement(System.Xml.XmlReader reader, int depth);
            /*0x36fbd38*/ void ReadXmlDiffgram(System.Xml.XmlReader reader);
            /*0x36fdc90*/ void ReadXSDSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x36fc7dc*/ void ReadXmlSchema(System.Xml.XmlReader reader, bool denyResolving);
            /*0x36fa590*/ void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x36fde24*/ void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList);
            /*0x36fe564*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
            /*0x36fe574*/ System.Xml.Schema.XmlSchema GetSchema();
            /*0x36fe73c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
            /*0x36fe8e8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            /*0x36fe91c*/ void ReadXmlSerializable(System.Xml.XmlReader reader);
            /*0x36fe928*/ System.Collections.Hashtable get_RowDiffId();
            /*0x36fe99c*/ int get_ObjectID();
            /*0x36fe9a4*/ void AddDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x36fea88*/ void RemoveDependentColumn(System.Data.DataColumn expressionColumn);
            /*0x36feb18*/ void EvaluateExpressions();
            /*0x36f65d4*/ void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows);
            /*0x36fee5c*/ void EvaluateExpressions(System.Data.DataColumn column);
            /*0x36f5378*/ void EvaluateDependentExpressions(System.Data.DataColumn column);
            /*0x36f8780*/ void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows);

            struct RowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataTable _targetTable;

                /*0x3717a94*/ void Prepare(System.Data.DataTable table);
            }

            struct DSRowDiffIdUsageSection
            {
                /*0x10*/ System.Data.DataSet _targetDS;

                /*0x3714338*/ void Prepare(System.Data.DataSet ds);
            }
        }

        class FunctionNode : System.Data.ExpressionNode
        {
            static /*0x0*/ System.Data.Function[] s_funcs;
            /*0x18*/ string _name;
            /*0x20*/ int _info;
            /*0x24*/ int _argumentCount;
            /*0x28*/ System.Data.ExpressionNode[] _arguments;
            /*0x30*/ System.Data.TypeLimiter _capturedLimiter;

            static /*0x371ab7c*/ FunctionNode();
            /*0x3717ac0*/ FunctionNode(System.Data.DataTable table, string name);
            /*0x3717c18*/ void AddArgument(System.Data.ExpressionNode argument);
            /*0x3717dfc*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x37182c8*/ object Eval();
            /*0x37182dc*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x371a434*/ object Eval(int[] recordNos);
            /*0x371a468*/ bool IsConstant();
            /*0x371a4f0*/ bool IsTableConstant();
            /*0x371a56c*/ bool HasLocalAggregate();
            /*0x371a5e8*/ bool HasRemoteAggregate();
            /*0x371a664*/ bool DependsOn(System.Data.DataColumn column);
            /*0x371a6ec*/ System.Data.ExpressionNode Optimize();
            /*0x3718be8*/ System.Type GetDataType(System.Data.ExpressionNode node);
            /*0x3718e60*/ object EvalFunction(System.Data.FunctionId id, object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x371a8b0*/ System.Data.FunctionId get_Aggregate();
            /*0x371a94c*/ bool get_IsAggregate();
            /*0x37180e8*/ void Check();
        }

        enum FunctionId
        {
            none = -1,
            Ascii = 0,
            Char = 1,
            Charindex = 2,
            Difference = 3,
            Len = 4,
            Lower = 5,
            LTrim = 6,
            Patindex = 7,
            Replicate = 8,
            Reverse = 9,
            Right = 10,
            RTrim = 11,
            Soundex = 12,
            Space = 13,
            Str = 14,
            Stuff = 15,
            Substring = 16,
            Upper = 17,
            IsNull = 18,
            Iif = 19,
            Convert = 20,
            cInt = 21,
            cBool = 22,
            cDate = 23,
            cDbl = 24,
            cStr = 25,
            Abs = 26,
            Acos = 27,
            In = 28,
            Trim = 29,
            Sum = 30,
            Avg = 31,
            Min = 32,
            Max = 33,
            Count = 34,
            StDev = 35,
            Var = 37,
            DateTimeOffset = 38,
        }

        class Function
        {
            static /*0x0*/ string[] s_functionName;
            /*0x10*/ string _name;
            /*0x18*/ System.Data.FunctionId _id;
            /*0x20*/ System.Type _result;
            /*0x28*/ bool _isValidateArguments;
            /*0x29*/ bool _isVariantArgumentList;
            /*0x2c*/ int _argumentCount;
            /*0x30*/ System.Type[] _parameters;

            static /*0x371b7e0*/ Function();
            /*0x371b5a0*/ Function(string name, System.Data.FunctionId id, System.Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, System.Type a1, System.Type a2, System.Type a3);
        }

        class TypeLimiter
        {
            [ThreadStatic] static System.Data.TypeLimiter.Scope s_activeScope;
            /*0x10*/ System.Data.TypeLimiter.Scope m_instanceScope;

            static /*0x371c050*/ bool get_IsTypeLimitingDisabled();
            static /*0x371c0c8*/ System.Data.TypeLimiter Capture();
            static /*0x371c144*/ void EnsureTypeIsAllowed(System.Type type, System.Data.TypeLimiter capturedLimiter);
            static /*0x371c368*/ System.IDisposable EnterRestrictedScope(System.Data.DataSet dataSet);
            static /*0x371c750*/ System.IDisposable EnterRestrictedScope(System.Data.DataTable dataTable);
            static /*0x371c810*/ System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(System.Data.DataTable dataTable);
            static /*0x371c428*/ System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(System.Data.DataSet dataSet);
            /*0x371c020*/ TypeLimiter(System.Data.TypeLimiter.Scope scope);

            class Scope : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.HashSet<System.Type> s_allowedTypes;
                /*0x10*/ System.Collections.Generic.HashSet<System.Type> m_allowedTypes;
                /*0x18*/ System.Data.TypeLimiter.Scope m_previousScope;

                static /*0x371cc40*/ Scope();
                static /*0x371ca88*/ bool IsTypeUnconditionallyAllowed(System.Type type);
                /*0x371c5cc*/ Scope(System.Data.TypeLimiter.Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes);
                /*0x371c9b4*/ void Dispose();
                /*0x371c1dc*/ bool IsAllowedType(System.Type type);

                class <>c
                {
                    static /*0x0*/ System.Data.TypeLimiter.Scope.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__3_0;

                    static /*0x371d474*/ <>c();
                    /*0x371d4dc*/ <>c();
                    /*0x371d4e4*/ bool <.ctor>b__3_0(System.Type type);
                }
            }

            class <>c
            {
                static /*0x0*/ System.Data.TypeLimiter.<> <>9;
                static /*0x8*/ System.Func<System.Data.DataColumn, System.Type> <>9__10_0;
                static /*0x10*/ System.Func<System.Data.DataTable, System.Collections.Generic.IEnumerable<System.Type>> <>9__11_0;

                static /*0x371d518*/ <>c();
                /*0x371d580*/ <>c();
                /*0x371d588*/ System.Type <GetPreviouslyDeclaredDataTypes>b__10_0(System.Data.DataColumn column);
                /*0x371d59c*/ System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(System.Data.DataTable table);
            }
        }

        enum AcceptRejectRule
        {
            None = 0,
            Cascade = 1,
        }

        enum AggregateType
        {
            None = 0,
            Sum = 4,
            Mean = 5,
            Min = 6,
            Max = 7,
            First = 8,
            Count = 9,
            Var = 10,
            StDev = 11,
        }

        class InternalDataCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable
        {
            static /*0x0*/ System.ComponentModel.CollectionChangeEventArgs s_refreshEventArgs;

            static /*0x371d710*/ InternalDataCollectionBase();
            /*0x371d708*/ InternalDataCollectionBase();
            /*0x371d5a4*/ int get_Count();
            /*0x371d5d0*/ void CopyTo(System.Array ar, int index);
            /*0x371d618*/ System.Collections.IEnumerator GetEnumerator();
            /*0x371d644*/ bool get_IsSynchronized();
            /*0x371d64c*/ int NamesEqual(string s1, string s2, bool fCaseSensitive, System.Globalization.CultureInfo locale);
            /*0x371d6fc*/ object get_SyncRoot();
            /*0x371d700*/ System.Collections.ArrayList get_List();
        }

        class ColumnTypeConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.Type[] s_types;
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            static /*0x371e094*/ ColumnTypeConverter();
            /*0x371d794*/ ColumnTypeConverter();
            /*0x371d79c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x371d84c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x371dd00*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x371dd8c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x371df64*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x371e084*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x371e08c*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataCommonEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Data.DataCommonEventSource Log;
            static /*0x8*/ long s_nextScopeId;

            static /*0x371ed58*/ DataCommonEventSource();
            /*0x371ed50*/ DataCommonEventSource();
            /*0x371ec6c*/ void Trace(string message);
            /*0x1ffc854*/ void Trace<T0>(string format, T0 arg0);
            /*0x1ffc854*/ void Trace<T0, T1>(string format, T0 arg0, T1 arg1);
            /*0x1ffc854*/ void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2);
            /*0x1ffc854*/ void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
            /*0x1ffc854*/ void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x1ffc854*/ void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x371ec7c*/ long EnterScope(string message);
            /*0x1ffc854*/ long EnterScope<T1>(string format, T1 arg1);
            /*0x1ffc854*/ long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2);
            /*0x1ffc854*/ long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
            /*0x1ffc854*/ long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x371ed40*/ void ExitScope(long scopeId);
        }

        class Constraint
        {
            /*0x10*/ string _schemaName;
            /*0x18*/ bool _inCollection;
            /*0x20*/ System.Data.DataSet _dataSet;
            /*0x28*/ string _name;
            /*0x30*/ System.Data.PropertyCollection _extendedProperties;

            /*0x371f50c*/ Constraint();
            /*0x371edd0*/ string get_ConstraintName();
            /*0x371edd8*/ void set_ConstraintName(string value);
            /*0x371f22c*/ string get_SchemaName();
            /*0x371f264*/ void set_SchemaName(string value);
            /*0x371f2a8*/ bool get_InCollection();
            /*0x371f2b0*/ void set_InCollection(bool value);
            /*0x1f30214*/ System.Data.DataTable get_Table();
            /*0x371f2f4*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x1f2fec8*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x1f2fe14*/ bool CanEnableConstraint();
            /*0x1f302cc*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            System.Data.Constraint Clone(System.Data.DataSet destination, bool ignoreNSforTableLookup);
            /*0x371f364*/ void CheckConstraint();
            /*0x1f30ebc*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraint);
            bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, bool fThrowException);
            /*0x1f30ee8*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x1f309e4*/ void CheckState();
            /*0x371f3b8*/ void CheckStateForProperty();
            /*0x371f4f8*/ System.Data.DataSet get__DataSet();
            /*0x1f2fe14*/ bool IsConstraintViolated();
            /*0x371f500*/ string ToString();
        }

        class ConstraintCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChanged;
            /*0x30*/ System.Data.Constraint[] _delayLoadingConstraints;
            /*0x38*/ bool _fLoadForeignKeyConstraintsOnly;

            static /*0x3720e50*/ bool CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2);
            /*0x371f560*/ ConstraintCollection(System.Data.DataTable table);
            /*0x371f618*/ System.Collections.ArrayList get_List();
            /*0x371f620*/ System.Data.Constraint get_Item(int index);
            /*0x371f71c*/ System.Data.DataTable get_Table();
            /*0x371f724*/ System.Data.Constraint get_Item(string name);
            /*0x371f96c*/ void Add(System.Data.Constraint constraint);
            /*0x371f974*/ void Add(System.Data.Constraint constraint, bool addUniqueWhenAddingForeign);
            /*0x37202fc*/ System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey);
            /*0x371ff54*/ void AddUniqueConstraint(System.Data.UniqueConstraint constraint);
            /*0x3720164*/ void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint);
            /*0x371fe84*/ bool AutoGenerated(System.Data.Constraint constraint);
            /*0x372029c*/ void ArrayAdd(System.Data.Constraint constraint);
            /*0x37203a4*/ void ArrayRemove(System.Data.Constraint constraint);
            /*0x3720140*/ string AssignName();
            /*0x37201d4*/ void BaseAdd(System.Data.Constraint constraint);
            /*0x3720494*/ void BaseGroupSwitch(System.Data.Constraint[] oldArray, int oldLength, System.Data.Constraint[] newArray, int newLength);
            /*0x3720644*/ void BaseRemove(System.Data.Constraint constraint);
            /*0x37208f0*/ bool CanRemove(System.Data.Constraint constraint, bool fThrowException);
            /*0x372091c*/ void Clear();
            /*0x3720d3c*/ bool Contains(string name);
            /*0x3720d54*/ bool Contains(string name, bool caseSensitive);
            /*0x371fd28*/ System.Data.Constraint FindConstraint(System.Data.Constraint constraint);
            /*0x3720034*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns);
            /*0x3720edc*/ System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column);
            /*0x3720fe8*/ System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x371f810*/ int InternalIndexOf(string constraintName);
            /*0x37203dc*/ string MakeName(int index);
            /*0x37202d4*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x371efc4*/ void RegisterName(string name);
            /*0x3721118*/ void Remove(System.Data.Constraint constraint);
            /*0x371f1ac*/ void UnregisterName(string name);
        }

        class ConstraintConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x3721274*/ ConstraintConverter();
            /*0x372127c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x372132c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class ConstraintEnumerator
        {
            /*0x10*/ System.Collections.IEnumerator _tables;
            /*0x18*/ System.Collections.IEnumerator _constraints;
            /*0x20*/ System.Data.Constraint _currentObject;

            /*0x3721d80*/ ConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x3721de8*/ bool GetNext();
            /*0x3722110*/ System.Data.Constraint GetConstraint();
            /*0x3722118*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x3722120*/ System.Data.Constraint get_CurrentObject();
        }

        class ForeignKeyConstraintEnumerator : System.Data.ConstraintEnumerator
        {
            /*0x3722128*/ ForeignKeyConstraintEnumerator(System.Data.DataSet dataSet);
            /*0x372212c*/ bool IsValidCandidate(System.Data.Constraint constraint);
            /*0x37221a4*/ System.Data.ForeignKeyConstraint GetForeignKeyConstraint();
        }

        class ChildForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x372221c*/ ChildForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x3722248*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class ParentForeignKeyConstraintEnumerator : System.Data.ForeignKeyConstraintEnumerator
        {
            /*0x28*/ System.Data.DataTable _table;

            /*0x37222dc*/ ParentForeignKeyConstraintEnumerator(System.Data.DataSet dataSet, System.Data.DataTable inTable);
            /*0x3722308*/ bool IsValidCandidate(System.Data.Constraint constraint);
        }

        class DataColumnChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataColumn _column;
            /*0x18*/ System.Data.DataRow <Row>k__BackingField;
            /*0x20*/ object <ProposedValue>k__BackingField;

            /*0x37223a0*/ DataColumnChangeEventArgs(System.Data.DataRow row);
            /*0x3722414*/ DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value);
            /*0x37224b8*/ object get_ProposedValue();
            /*0x37224c0*/ void set_ProposedValue(object value);
            /*0x37224c8*/ void InitializeColumnChangeEvent(System.Data.DataColumn column, object value);
        }

        class DataColumnChangeEventHandler : System.MulticastDelegate
        {
            /*0x37224f8*/ DataColumnChangeEventHandler(object object, nint method);
            /*0x3722604*/ void Invoke(object sender, System.Data.DataColumnChangeEventArgs e);
        }

        class DataColumnCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.Data.DataColumn[] _delayedAddRangeColumns;
            /*0x30*/ System.Collections.Generic.Dictionary<string, System.Data.DataColumn> _columnFromName;
            /*0x38*/ bool _fInClear;
            /*0x40*/ System.Data.DataColumn[] _columnsImplementingIChangeTracking;
            /*0x48*/ int _nColumnsImplementingIChangeTracking;
            /*0x4c*/ int _nColumnsImplementingIRevertibleChangeTracking;
            /*0x50*/ System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
            /*0x58*/ System.ComponentModel.CollectionChangeEventHandler CollectionChanging;
            /*0x60*/ System.ComponentModel.CollectionChangeEventHandler ColumnPropertyChanged;

            /*0x3722618*/ DataColumnCollection(System.Data.DataTable table);
            /*0x3722794*/ System.Collections.ArrayList get_List();
            /*0x372279c*/ System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking();
            /*0x37227a4*/ int get_ColumnsImplementingIChangeTrackingCount();
            /*0x37227ac*/ int get_ColumnsImplementingIRevertibleChangeTrackingCount();
            /*0x37227b4*/ System.Data.DataColumn get_Item(int index);
            /*0x37228e4*/ System.Data.DataColumn get_Item(string name);
            /*0x3722b78*/ System.Data.DataColumn get_Item(string name, string ns);
            /*0x3722c1c*/ void Add(System.Data.DataColumn column);
            /*0x3722c28*/ void AddAt(int index, System.Data.DataColumn column);
            /*0x3723320*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x37233bc*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x3723458*/ void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x37234f4*/ void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x3723210*/ void ArrayAdd(System.Data.DataColumn column);
            /*0x37231d0*/ void ArrayAdd(int index, System.Data.DataColumn column);
            /*0x37235d0*/ void ArrayRemove(System.Data.DataColumn column);
            /*0x372381c*/ string AssignName();
            /*0x3722eac*/ void BaseAdd(System.Data.DataColumn column);
            /*0x3723bec*/ void BaseGroupSwitch(System.Data.DataColumn[] oldArray, int oldLength, System.Data.DataColumn[] newArray, int newLength);
            /*0x3723dc8*/ void BaseRemove(System.Data.DataColumn column);
            /*0x3723e80*/ bool CanRemove(System.Data.DataColumn column, bool fThrowException);
            /*0x3723590*/ void CheckIChangeTracking(System.Data.DataColumn column);
            /*0x372470c*/ void Clear();
            /*0x3724a24*/ bool Contains(string name);
            /*0x3724ab8*/ bool Contains(string name, bool caseSensitive);
            /*0x3724b54*/ int IndexOf(string columnName);
            /*0x3722a28*/ int IndexOfCaseInsensitive(string name);
            /*0x37238b0*/ string MakeName(int index);
            /*0x372327c*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x3722e84*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x3724c54*/ void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x3723968*/ void RegisterColumnName(string name, System.Data.DataColumn column);
            /*0x3724cac*/ bool CanRegisterName(string name);
            /*0x3724d10*/ void Remove(System.Data.DataColumn column);
            /*0x3723b30*/ void UnregisterName(string name);
            /*0x3724634*/ void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
            /*0x3723700*/ void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn);
        }

        class DataColumnPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataColumn <Column>k__BackingField;

            /*0x3724e1c*/ DataColumnPropertyDescriptor(System.Data.DataColumn dataColumn);
            /*0x3724e5c*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x3725014*/ System.Data.DataColumn get_Column();
            /*0x372501c*/ System.Type get_ComponentType();
            /*0x372507c*/ bool get_IsReadOnly();
            /*0x3725094*/ System.Type get_PropertyType();
            /*0x37250ac*/ bool Equals(object other);
            /*0x372511c*/ int GetHashCode();
            /*0x3725138*/ bool CanResetValue(object component);
            /*0x3725298*/ object GetValue(object component);
            /*0x3725320*/ void ResetValue(object component);
            /*0x3725470*/ void SetValue(object component, object value);
            /*0x3725550*/ bool ShouldSerializeValue(object component);
        }

        class DataError
        {
            /*0x10*/ string _rowError;
            /*0x18*/ int _count;
            /*0x20*/ System.Data.DataError.ColumnError[] _errorList;

            /*0x3725558*/ DataError();
            /*0x372558c*/ DataError(string rowError);
            /*0x372561c*/ string get_Text();
            /*0x3725624*/ void set_Text(string value);
            /*0x3725644*/ bool get_HasErrors();
            /*0x3725674*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x372599c*/ string GetColumnError(System.Data.DataColumn column);
            /*0x37257a4*/ void Clear(System.Data.DataColumn column);
            /*0x3725a00*/ void Clear();
            /*0x3725a74*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x37255fc*/ void SetText(string errorText);
            /*0x3725850*/ int IndexOf(System.Data.DataColumn column);

            struct ColumnError
            {
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ string _error;
            }
        }

        struct DataKey
        {
            /*0x10*/ System.Data.DataColumn[] _columns;

            static /*0x3725e40*/ bool ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2);
            /*0x3725b70*/ DataKey(System.Data.DataColumn[] columns, bool copyColumns);
            /*0x3725e20*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x3725e28*/ bool get_HasValue();
            /*0x3721d50*/ System.Data.DataTable get_Table();
            /*0x3725d88*/ void CheckState();
            /*0x3725e38*/ bool ColumnsEqual(System.Data.DataKey key);
            /*0x37245a0*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x3725f30*/ int GetHashCode();
            /*0x3725f94*/ bool Equals(object value);
            /*0x3726010*/ bool Equals(System.Data.DataKey value);
            /*0x37260c8*/ string[] GetColumnNames();
            /*0x372618c*/ System.Data.IndexField[] GetIndexDesc();
            /*0x3726278*/ object[] GetKeyValues(int record);
            /*0x3726388*/ System.Data.Index GetSortIndex();
            /*0x3726390*/ System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates);
            /*0x37263e8*/ bool RecordsEqual(int record1, int record2);
            /*0x372646c*/ System.Data.DataColumn[] ToArray();
        }

        class DataRelation
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.PropertyCollection _extendedProperties;
            /*0x20*/ string _relationName;
            /*0x28*/ System.Data.DataKey _childKey;
            /*0x30*/ System.Data.DataKey _parentKey;
            /*0x38*/ System.Data.UniqueConstraint _parentKeyConstraint;
            /*0x40*/ System.Data.ForeignKeyConstraint _childKeyConstraint;
            /*0x48*/ string[] _parentColumnNames;
            /*0x50*/ string[] _childColumnNames;
            /*0x58*/ string _parentTableName;
            /*0x60*/ string _childTableName;
            /*0x68*/ string _parentTableNamespace;
            /*0x70*/ string _childTableNamespace;
            /*0x78*/ bool _nested;
            /*0x79*/ bool _createConstraints;
            /*0x7a*/ bool _checkMultipleNested;
            /*0x7c*/ int _objectID;
            /*0x80*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanging;

            static /*0x3726f40*/ bool IsKeyNull(object[] values);
            static /*0x3726ffc*/ System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version);
            static /*0x37270b4*/ System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            static /*0x372714c*/ System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version);
            /*0x3726560*/ DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints);
            /*0x3726a80*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x3726a88*/ DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x3726b44*/ DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x3726c58*/ DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested);
            /*0x3726d9c*/ System.Data.DataColumn[] get_ChildColumns();
            /*0x3726ee8*/ System.Data.DataColumn[] get_ChildColumnsReference();
            /*0x3724604*/ System.Data.DataKey get_ChildKey();
            /*0x3726f00*/ System.Data.DataTable get_ChildTable();
            /*0x3726f18*/ System.Data.DataSet get_DataSet();
            /*0x3726f30*/ string[] get_ParentColumnNames();
            /*0x3726f38*/ string[] get_ChildColumnNames();
            /*0x3727324*/ void SetDataSet(System.Data.DataSet dataSet);
            /*0x372733c*/ System.Data.DataColumn[] get_ParentColumns();
            /*0x3727354*/ System.Data.DataColumn[] get_ParentColumnsReference();
            /*0x372461c*/ System.Data.DataKey get_ParentKey();
            /*0x372735c*/ System.Data.DataTable get_ParentTable();
            /*0x3727374*/ string get_RelationName();
            /*0x372738c*/ void CheckNamespaceValidityForNestedRelations(string ns);
            /*0x37276e8*/ void CheckNestedRelations();
            /*0x3727a8c*/ bool get_Nested();
            /*0x3727aa4*/ void set_Nested(bool value);
            /*0x3729050*/ System.Data.UniqueConstraint get_ParentKeyConstraint();
            /*0x3729068*/ void SetParentKeyConstraint(System.Data.UniqueConstraint value);
            /*0x3729070*/ System.Data.ForeignKeyConstraint get_ChildKeyConstraint();
            /*0x3729088*/ System.Data.PropertyCollection get_ExtendedProperties();
            /*0x37290f8*/ bool get_CheckMultipleNested();
            /*0x3729100*/ void set_CheckMultipleNested(bool value);
            /*0x3729108*/ void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value);
            /*0x3729110*/ void CheckState();
            /*0x3726db4*/ void CheckStateForProperty();
            /*0x3726794*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints);
            /*0x3729330*/ System.Data.DataRelation Clone(System.Data.DataSet destination);
            /*0x3729a6c*/ void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent);
            /*0x3728f08*/ void RaisePropertyChanging(string name);
            /*0x3729b44*/ string ToString();
            /*0x3728a5c*/ void ValidateMultipleNestedRelations();
            /*0x3729b50*/ bool IsAutoGenerated(System.Data.DataColumn col);
            /*0x3729d04*/ int get_ObjectID();
        }

        class DataRelationCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataRelation _inTransition;
            /*0x18*/ int _defaultNameIndex;
            /*0x20*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x28*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x30*/ int _objectID;

            /*0x372b1e4*/ DataRelationCollection();
            /*0x3729d0c*/ int get_ObjectID();
            /*0x1f30240*/ System.Data.DataRelation get_Item(int index);
            /*0x1f302cc*/ System.Data.DataRelation get_Item(string name);
            /*0x3729d14*/ void Add(System.Data.DataRelation relation);
            /*0x3729fb0*/ void AddCore(System.Data.DataRelation relation);
            /*0x372a228*/ void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x372a33c*/ void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value);
            /*0x372a450*/ string AssignName();
            /*0x372a52c*/ void Clear();
            /*0x372a76c*/ bool Contains(string name);
            /*0x372a784*/ int InternalIndexOf(string name);
            /*0x1f30214*/ System.Data.DataSet GetDataSet();
            /*0x372a474*/ string MakeName(int index);
            /*0x372a8fc*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x372a9d4*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x372aaac*/ void RegisterName(string name);
            /*0x372ac78*/ void Remove(System.Data.DataRelation relation);
            /*0x372ae78*/ void RemoveAt(int index);
            /*0x372aeec*/ void RemoveCore(System.Data.DataRelation relation);
            /*0x372b0b0*/ void UnregisterName(string name);

            class DataTableRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataTable _table;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ bool _fParentCollection;
                /*0x50*/ System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged;

                /*0x372b278*/ DataTableRelationCollection(System.Data.DataTable table, bool fParentCollection);
                /*0x372b330*/ System.Collections.ArrayList get_List();
                /*0x372b338*/ void EnsureDataSet();
                /*0x372b37c*/ System.Data.DataSet GetDataSet();
                /*0x372b3a0*/ System.Data.DataRelation get_Item(int index);
                /*0x372b4a0*/ System.Data.DataRelation get_Item(string name);
                /*0x372b58c*/ void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x372b628*/ void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value);
                /*0x372b6c4*/ void AddCache(System.Data.DataRelation relation);
                /*0x372b70c*/ void AddCore(System.Data.DataRelation relation);
                /*0x372b7d4*/ void RemoveCache(System.Data.DataRelation relation);
                /*0x372b8a8*/ void RemoveCore(System.Data.DataRelation relation);
            }

            class DataSetRelationCollection : System.Data.DataRelationCollection
            {
                /*0x38*/ System.Data.DataSet _dataSet;
                /*0x40*/ System.Collections.ArrayList _relations;
                /*0x48*/ System.Data.DataRelation[] _delayLoadingRelations;

                /*0x372b970*/ DataSetRelationCollection(System.Data.DataSet dataSet);
                /*0x372ba14*/ System.Collections.ArrayList get_List();
                /*0x372ba1c*/ void Clear();
                /*0x372ba60*/ System.Data.DataSet GetDataSet();
                /*0x372ba68*/ System.Data.DataRelation get_Item(int index);
                /*0x372bb68*/ System.Data.DataRelation get_Item(string name);
                /*0x372bc54*/ void AddCore(System.Data.DataRelation relation);
                /*0x372c20c*/ void RemoveCore(System.Data.DataRelation relation);
            }
        }

        class DataRelationPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.Data.DataRelation <Relation>k__BackingField;

            /*0x372c464*/ DataRelationPropertyDescriptor(System.Data.DataRelation dataRelation);
            /*0x372c4b8*/ System.Data.DataRelation get_Relation();
            /*0x372c4c0*/ System.Type get_ComponentType();
            /*0x372c520*/ bool get_IsReadOnly();
            /*0x372c528*/ System.Type get_PropertyType();
            /*0x372c588*/ bool Equals(object other);
            /*0x372c5f8*/ int GetHashCode();
            /*0x372c614*/ bool CanResetValue(object component);
            /*0x372c61c*/ object GetValue(object component);
            /*0x372c6b0*/ void ResetValue(object component);
            /*0x372c6b4*/ void SetValue(object component, object value);
            /*0x372c6b8*/ bool ShouldSerializeValue(object component);
        }

        class DataRow
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataColumnCollection _columns;
            /*0x20*/ int _oldRecord;
            /*0x24*/ int _newRecord;
            /*0x28*/ int _tempRecord;
            /*0x30*/ long _rowID;
            /*0x38*/ System.Data.DataRowAction _action;
            /*0x3c*/ bool _inChangingEvent;
            /*0x3d*/ bool _inDeletingEvent;
            /*0x3e*/ bool _inCascade;
            /*0x40*/ System.Data.DataColumn _lastChangedColumn;
            /*0x48*/ int _countColumnChange;
            /*0x50*/ System.Data.DataError _error;
            /*0x58*/ int _rbTreeNodeId;
            /*0x5c*/ int _objectID;

            /*0x372c6c0*/ DataRow(System.Data.DataRowBuilder builder);
            /*0x372c774*/ System.Data.DataColumn get_LastChangedColumn();
            /*0x372c790*/ void set_LastChangedColumn(System.Data.DataColumn value);
            /*0x372c7a4*/ bool get_HasPropertyChanged();
            /*0x372c7b4*/ int get_RBTreeNodeId();
            /*0x372c7bc*/ void set_RBTreeNodeId(int value);
            /*0x372c874*/ string get_RowError();
            /*0x372c89c*/ void set_RowError(string value);
            /*0x372c9ec*/ void RowErrorChanged();
            /*0x372ca3c*/ long get_rowID();
            /*0x372ca44*/ void set_rowID(long value);
            /*0x372ca9c*/ System.Data.DataRowState get_RowState();
            /*0x372ccbc*/ System.Data.DataTable get_Table();
            /*0x3728f74*/ void CheckForLoops(System.Data.DataRelation rel);
            /*0x372ccc4*/ int GetNestedParentCount();
            /*0x372cd8c*/ void set_Item(string columnName, object value);
            /*0x372cc80*/ object get_Item(System.Data.DataColumn column);
            /*0x372ce20*/ void set_Item(System.Data.DataColumn column, object value);
            /*0x372d4e8*/ object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version);
            /*0x372d58c*/ void set_ItemArray(object[] value);
            /*0x372d99c*/ void AcceptChanges();
            /*0x372dcf8*/ void BeginEdit();
            /*0x372d270*/ bool BeginEditInternal();
            /*0x372d384*/ void CancelEdit();
            /*0x372d184*/ void CheckColumn(System.Data.DataColumn column);
            /*0x372dcfc*/ void CheckInTable();
            /*0x372dd34*/ void Delete();
            /*0x372d3ec*/ void EndEdit();
            /*0x372dd94*/ void SetColumnError(int columnIndex, string error);
            /*0x372ddf8*/ void SetColumnError(System.Data.DataColumn column, string error);
            /*0x372e018*/ string GetColumnError(System.Data.DataColumn column);
            /*0x372e0c4*/ void ClearErrors();
            /*0x3724578*/ void ClearError(System.Data.DataColumn column);
            /*0x372e0ec*/ bool get_HasErrors();
            /*0x372e12c*/ System.Data.DataColumn[] GetColumnsInError();
            /*0x372e1d8*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation);
            /*0x372e1e0*/ System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x372cdb8*/ System.Data.DataColumn GetDataColumn(string columnName);
            /*0x3729048*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation);
            /*0x372e308*/ System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x372e424*/ System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version);
            /*0x372e4e0*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation);
            /*0x372e4e8*/ System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version);
            /*0x372e610*/ object[] GetColumnValues(System.Data.DataColumn[] columns);
            /*0x372e618*/ object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version);
            /*0x372e668*/ object[] GetKeyValues(System.Data.DataKey key);
            /*0x3727094*/ object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version);
            /*0x372e684*/ int GetCurrentRecordNo();
            /*0x372d210*/ int GetDefaultRecord();
            /*0x372e6bc*/ int GetOriginalRecordNo();
            /*0x372d34c*/ int GetProposedRecordNo();
            /*0x372d52c*/ int GetRecordFromVersion(System.Data.DataRowVersion version);
            /*0x372e6f4*/ System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState);
            /*0x372e724*/ System.Data.DataViewRowState GetRecordState(int record);
            /*0x372e77c*/ bool HasKeyChanged(System.Data.DataKey key);
            /*0x372e788*/ bool HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x37272a0*/ bool HasVersion(System.Data.DataRowVersion version);
            /*0x372e80c*/ bool HaveValuesChanged(System.Data.DataColumn[] columns);
            /*0x372e818*/ bool HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2);
            /*0x372e8c0*/ void RejectChanges();
            /*0x372ca78*/ void ResetLastChangedColumn();
            /*0x372ee8c*/ void SetKeyValues(System.Data.DataKey key, object[] keyValues);
            /*0x372efa4*/ void SetNestedParentRow(System.Data.DataRow parentRow, bool setNonNested);
            /*0x372f364*/ void SetParentRowToDBNull();
            /*0x372f610*/ void SetParentRowToDBNull(System.Data.DataRelation relation);
            /*0x372f788*/ int CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, int storeIndex);
        }

        class DataRowBuilder
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _record;

            /*0x372fa74*/ DataRowBuilder(System.Data.DataTable table, int record);
        }

        enum DataRowAction
        {
            Nothing = 0,
            Delete = 1,
            Change = 2,
            Rollback = 4,
            Commit = 8,
            Add = 16,
            ChangeOriginal = 32,
            ChangeCurrentAndOriginal = 64,
        }

        class DataRowChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;
            /*0x18*/ System.Data.DataRowAction <Action>k__BackingField;

            /*0x372fab0*/ DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action);
        }

        class DataRowChangeEventHandler : System.MulticastDelegate
        {
            /*0x372fb30*/ DataRowChangeEventHandler(object object, nint method);
            /*0x372fc3c*/ void Invoke(object sender, System.Data.DataRowChangeEventArgs e);
        }

        class DataRowCollection : System.Data.InternalDataCollectionBase
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.DataRowCollection.DataRowTree _list;
            /*0x20*/ int _nullInList;

            /*0x372fc50*/ DataRowCollection(System.Data.DataTable table);
            /*0x372fd44*/ int get_Count();
            /*0x372450c*/ System.Data.DataRow get_Item(int index);
            /*0x372fd94*/ void Add(System.Data.DataRow row);
            /*0x372fdb0*/ void DiffInsertAt(System.Data.DataRow row, int pos);
            /*0x372ffe0*/ int IndexOf(System.Data.DataRow row);
            /*0x3730078*/ System.Data.DataRow AddWithColumnEvents(object[] values);
            /*0x37300d8*/ void ArrayAdd(System.Data.DataRow row);
            /*0x3730140*/ void ArrayInsert(System.Data.DataRow row, int pos);
            /*0x37301b8*/ void ArrayClear();
            /*0x3730208*/ void ArrayRemove(System.Data.DataRow row);
            /*0x373029c*/ void CopyTo(System.Array ar, int index);
            /*0x3730304*/ void CopyTo(System.Data.DataRow[] array, int index);
            /*0x373036c*/ System.Collections.IEnumerator GetEnumerator();

            class DataRowTree : System.Data.RBTree<System.Data.DataRow>
            {
                /*0x372fcf8*/ DataRowTree();
                /*0x37303bc*/ int CompareNode(System.Data.DataRow record1, System.Data.DataRow record2);
                /*0x37303e8*/ int CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2);
            }
        }

        class DataRowCreatedEventHandler : System.MulticastDelegate
        {
            /*0x3730414*/ DataRowCreatedEventHandler(object object, nint method);
            /*0x3730520*/ void Invoke(object sender, System.Data.DataRow r);
        }

        class DataSetClearEventhandler : System.MulticastDelegate
        {
            /*0x3730534*/ DataSetClearEventhandler(object object, nint method);
            /*0x3730640*/ void Invoke(object sender, System.Data.DataTable table);
        }

        enum DataRowState
        {
            Detached = 1,
            Unchanged = 2,
            Added = 4,
            Deleted = 8,
            Modified = 16,
        }

        enum DataRowVersion
        {
            Original = 256,
            Current = 512,
            Proposed = 1024,
            Default = 1536,
        }

        class DataRowView : System.ComponentModel.ICustomTypeDescriptor
        {
            static /*0x0*/ System.ComponentModel.PropertyDescriptorCollection s_zeroPropertyDescriptorCollection;
            /*0x10*/ System.Data.DataView _dataView;
            /*0x18*/ System.Data.DataRow _row;
            /*0x20*/ bool _delayBeginEdit;
            /*0x28*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            static /*0x3730b94*/ DataRowView();
            /*0x3730654*/ DataRowView(System.Data.DataView dataView, System.Data.DataRow row);
            /*0x3730698*/ bool Equals(object other);
            /*0x37306a4*/ int GetHashCode();
            /*0x37306c0*/ System.Data.DataView get_DataView();
            /*0x37306c8*/ System.Data.DataRowVersion get_RowVersionDefault();
            /*0x3730720*/ int GetRecord();
            /*0x3730744*/ bool HasRecord();
            /*0x3725264*/ object GetColumnValue(System.Data.DataColumn column);
            /*0x37253e4*/ void SetColumnValue(System.Data.DataColumn column, object value);
            /*0x3730768*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent);
            /*0x372c6a8*/ System.Data.DataView CreateChildView(System.Data.DataRelation relation);
            /*0x3730904*/ System.Data.DataRow get_Row();
            /*0x373090c*/ void EndEdit();
            /*0x3730958*/ bool get_IsNew();
            /*0x373097c*/ void RaisePropertyChangedEvent(string propName);
            /*0x3730a0c*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
            /*0x3730a64*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
            /*0x3730a6c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
            /*0x3730b08*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
            /*0x3730b90*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        enum SerializationFormat
        {
            Xml = 0,
            Binary = 1,
        }

        enum DataSetDateTime
        {
            Local = 1,
            Unspecified = 2,
            UnspecifiedLocal = 3,
            Utc = 4,
        }

        class DataTableClearEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataTable <Table>k__BackingField;

            /*0x3730c14*/ DataTableClearEventArgs(System.Data.DataTable dataTable);
        }

        class DataTableClearEventHandler : System.MulticastDelegate
        {
            /*0x3730c88*/ DataTableClearEventHandler(object object, nint method);
            /*0x3730d94*/ void Invoke(object sender, System.Data.DataTableClearEventArgs e);
        }

        class DataTableCollection : System.Data.InternalDataCollectionBase
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Collections.ArrayList _list;
            /*0x20*/ int _defaultNameIndex;
            /*0x28*/ System.Data.DataTable[] _delayedAddRangeTables;
            /*0x30*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;
            /*0x38*/ System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;
            /*0x40*/ int _objectID;

            /*0x3730da8*/ DataTableCollection(System.Data.DataSet dataSet);
            /*0x3730f2c*/ System.Collections.ArrayList get_List();
            /*0x3730f34*/ int get_ObjectID();
            /*0x3730f3c*/ System.Data.DataTable get_Item(int index);
            /*0x373106c*/ System.Data.DataTable get_Item(string name);
            /*0x3729964*/ System.Data.DataTable get_Item(string name, string tableNamespace);
            /*0x37314b4*/ System.Data.DataTable GetTable(string name, string ns);
            /*0x37315d0*/ System.Data.DataTable GetTableSmart(string name, string ns);
            /*0x3731708*/ void Add(System.Data.DataTable table);
            /*0x3731b70*/ void ArrayAdd(System.Data.DataTable table);
            /*0x3731c68*/ string AssignName();
            /*0x3731a5c*/ void BaseAdd(System.Data.DataTable table);
            /*0x3731fe8*/ void BaseGroupSwitch(System.Data.DataTable[] oldArray, int oldLength, System.Data.DataTable[] newArray, int newLength);
            /*0x373215c*/ void BaseRemove(System.Data.DataTable table);
            /*0x37321d4*/ bool CanRemove(System.Data.DataTable table, bool fThrowException);
            /*0x373274c*/ void Clear();
            /*0x3731d68*/ bool Contains(string name);
            /*0x3732a00*/ bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive);
            /*0x3732b74*/ bool Contains(string name, bool caseSensitive);
            /*0x3732c9c*/ int IndexOf(System.Data.DataTable table);
            /*0x3732d80*/ int IndexOf(string tableName);
            /*0x3732d98*/ int IndexOf(string tableName, string tableNamespace, bool chekforNull);
            /*0x3732df8*/ void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList);
            /*0x3731160*/ int InternalIndexOf(string tableName);
            /*0x3731328*/ int InternalIndexOf(string tableName, string tableNamespace);
            /*0x3731cb0*/ string MakeName(int index);
            /*0x3731b90*/ void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x3731984*/ void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent);
            /*0x3731d80*/ void RegisterName(string name, string tbNamespace);
            /*0x3732e48*/ void Remove(System.Data.DataTable table);
            /*0x3732638*/ void UnregisterName(string name);
        }

        class DataTableNewRowEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataRow <Row>k__BackingField;

            /*0x3733024*/ DataTableNewRowEventArgs(System.Data.DataRow dataRow);
        }

        class DataTableNewRowEventHandler : System.MulticastDelegate
        {
            /*0x3733098*/ DataTableNewRowEventHandler(object object, nint method);
            /*0x37331a4*/ void Invoke(object sender, System.Data.DataTableNewRowEventArgs e);
        }

        class DataTableTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x37331b8*/ DataTableTypeConverter();
            /*0x3733258*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DataView : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IBindingList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
            static /*0x0*/ System.ComponentModel.ListChangedEventArgs s_resetEventArgs;
            static /*0x8*/ int s_objectTypeCount;
            /*0x20*/ System.Data.DataViewManager _dataViewManager;
            /*0x28*/ System.Data.DataTable _table;
            /*0x30*/ bool _locked;
            /*0x38*/ System.Data.Index _index;
            /*0x40*/ System.Collections.Generic.Dictionary<string, System.Data.Index> _findIndexes;
            /*0x48*/ string _sort;
            /*0x50*/ System.Comparison<System.Data.DataRow> _comparison;
            /*0x58*/ System.Data.IFilter _rowFilter;
            /*0x60*/ System.Data.DataViewRowState _recordStates;
            /*0x64*/ bool _shouldOpen;
            /*0x65*/ bool _open;
            /*0x66*/ bool _allowNew;
            /*0x67*/ bool _allowEdit;
            /*0x68*/ bool _allowDelete;
            /*0x69*/ bool _applyDefaultSort;
            /*0x70*/ System.Data.DataRow _addNewRow;
            /*0x78*/ System.ComponentModel.ListChangedEventArgs _addNewMoved;
            /*0x80*/ System.ComponentModel.ListChangedEventHandler _onListChanged;
            /*0x88*/ System.Data.DataViewRowState _delayedRecordStates;
            /*0x8c*/ bool _fEndInitInProgress;
            /*0x90*/ System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRowView> _rowViewCache;
            /*0x98*/ System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRowView> _rowViewBuffer;
            /*0xa0*/ System.Data.DataViewListener _dvListener;
            /*0xa8*/ int _objectID;

            static /*0x3736620*/ DataView();
            /*0x3733260*/ DataView(System.Data.DataTable table, bool locked);
            /*0x37337c0*/ bool get_AllowDelete();
            /*0x37337c8*/ bool get_AllowNew();
            /*0x37337d0*/ int get_Count();
            /*0x3733820*/ int get_CountFromIndex();
            /*0x373383c*/ System.Data.DataViewManager get_DataViewManager();
            /*0x3733844*/ bool get_IsOpen();
            /*0x373384c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x3733854*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x373385c*/ string get_Sort();
            /*0x37338b0*/ System.Comparison<System.Data.DataRow> get_SortComparison();
            /*0x37338b8*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x37338bc*/ System.Data.DataTable get_Table();
            /*0x37338c4*/ object System.Collections.IList.get_Item(int recordIndex);
            /*0x37338fc*/ void System.Collections.IList.set_Item(int recordIndex, object value);
            /*0x37338e0*/ System.Data.DataRowView get_Item(int recordIndex);
            /*0x3733a2c*/ System.Data.DataRowView AddNew();
            /*0x3733cf8*/ void CheckOpen();
            /*0x3733e04*/ void Close();
            /*0x3733e58*/ void CopyTo(System.Array array, int index);
            /*0x3734054*/ void CopyTo(System.Data.DataRowView[] array, int index);
            /*0x373428c*/ void Delete(int index);
            /*0x37342a8*/ void Delete(System.Data.DataRow row);
            /*0x3734618*/ void Dispose(bool disposing);
            /*0x373445c*/ void FinishAddNew(bool success);
            /*0x373464c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x37346c8*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x37346d0*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x37346d8*/ int System.Collections.IList.Add(object value);
            /*0x373472c*/ void System.Collections.IList.Clear();
            /*0x3734754*/ bool System.Collections.IList.Contains(object value);
            /*0x37347e0*/ int System.Collections.IList.IndexOf(object value);
            /*0x3733d2c*/ int IndexOf(System.Data.DataRowView rowview);
            /*0x3734860*/ int IndexOfDataRowView(System.Data.DataRowView rowview);
            /*0x37348b8*/ void System.Collections.IList.Insert(int index, object value);
            /*0x37348e0*/ void System.Collections.IList.Remove(object value);
            /*0x3734a00*/ void System.Collections.IList.RemoveAt(int index);
            /*0x3734a1c*/ System.Data.IFilter GetFilter();
            /*0x3734a24*/ int GetRecord(int recordIndex);
            /*0x3733924*/ System.Data.DataRow GetRow(int index);
            /*0x3734020*/ System.Data.DataRowView GetRowView(int record);
            /*0x37339c0*/ System.Data.DataRowView GetRowView(System.Data.DataRow dr);
            /*0x3734aac*/ void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e);
            /*0x3734b3c*/ void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e);
            /*0x3734bfc*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x373513c*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x37354a8*/ void Reset();
            /*0x3734e80*/ void ResetRowViewCache();
            /*0x37354cc*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x373574c*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
            /*0x3735754*/ void SetIndex2(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, bool fireEvent);
            /*0x3733e3c*/ void UpdateIndex();
            /*0x3735ddc*/ void UpdateIndex(bool force);
            /*0x3735ac0*/ void UpdateIndex(bool force, bool fireEvent);
            /*0x3735fd8*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x37361e8*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x37363f8*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x3736608*/ void ColumnCollectionChangedInternal(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x3736618*/ int get_ObjectID();

            class DataRowReferenceComparer : System.Collections.Generic.IEqualityComparer<System.Data.DataRow>
            {
                static /*0x0*/ System.Data.DataView.DataRowReferenceComparer s_default;

                static /*0x37366cc*/ DataRowReferenceComparer();
                /*0x37366a4*/ DataRowReferenceComparer();
                /*0x37366ac*/ bool Equals(System.Data.DataRow x, System.Data.DataRow y);
                /*0x37366b8*/ int GetHashCode(System.Data.DataRow obj);
            }
        }

        class DataViewListener
        {
            /*0x10*/ System.WeakReference _dvWeak;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ System.Data.Index _index;
            /*0x28*/ int _objectID;

            /*0x3733554*/ DataViewListener(System.Data.DataView dv);
            /*0x3736734*/ void ChildRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x37367fc*/ void ParentRelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x37368ac*/ void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x3736978*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, bool trackAddRemove);
            /*0x3736a44*/ void IndexListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x37335d8*/ void RegisterMetaDataEvents(System.Data.DataTable table);
            /*0x3733e50*/ void UnregisterMetaDataEvents();
            /*0x3736cdc*/ void UnregisterMetaDataEvents(bool updateListeners);
            /*0x3735eec*/ void RegisterListChangedEvent(System.Data.Index index);
            /*0x3735de4*/ void UnregisterListChangedEvent();
            /*0x37367e4*/ void CleanUp(bool updateListeners);
            /*0x3736af4*/ void RegisterListener(System.Data.DataTable table);
        }

        class DataViewManager : System.ComponentModel.MarshalByValueComponent
        {
            static /*0x0*/ System.NotSupportedException s_notSupported;
            /*0x20*/ System.Data.DataViewSettingCollection _dataViewSettingsCollection;
            /*0x28*/ int _nViews;

            static /*0x3736f94*/ DataViewManager();
            /*0x3736f8c*/ System.Data.DataViewSettingCollection get_DataViewSettings();
        }

        enum DataViewRowState
        {
            None = 0,
            Unchanged = 2,
            Added = 4,
            Deleted = 8,
            ModifiedCurrent = 16,
            ModifiedOriginal = 32,
            OriginalRows = 42,
            CurrentRows = 22,
        }

        class DataViewSetting
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Data.DataTable _table;
            /*0x20*/ string _sort;
            /*0x28*/ string _rowFilter;
            /*0x30*/ System.Data.DataViewRowState _rowStateFilter;
            /*0x34*/ bool _applyDefaultSort;

            /*0x3737010*/ DataViewSetting();
            /*0x373706c*/ bool get_ApplyDefaultSort();
            /*0x3737074*/ void SetDataViewManager(System.Data.DataViewManager dataViewManager);
            /*0x373708c*/ void SetDataTable(System.Data.DataTable table);
            /*0x37370a4*/ string get_RowFilter();
            /*0x37370ac*/ System.Data.DataViewRowState get_RowStateFilter();
            /*0x37370b4*/ string get_Sort();
        }

        class DataViewSettingCollection
        {
            /*0x10*/ System.Data.DataViewManager _dataViewManager;
            /*0x18*/ System.Collections.Hashtable _list;

            /*0x37370bc*/ System.Data.DataViewSetting get_Item(System.Data.DataTable table);
            /*0x37371c4*/ void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value);
            /*0x3737274*/ void Remove(System.Data.DataTable table);
        }

        class DefaultValueTypeConverter : System.ComponentModel.StringConverter
        {
            /*0x3737294*/ DefaultValueTypeConverter();
            /*0x373729c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3737428*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        enum Aggregate
        {
            None = -1,
            Sum = 30,
            Avg = 31,
            Min = 32,
            Max = 33,
            Count = 34,
            StDev = 35,
            Var = 37,
        }

        class AggregateNode : System.Data.ExpressionNode
        {
            /*0x18*/ System.Data.AggregateType _type;
            /*0x1c*/ System.Data.Aggregate _aggregate;
            /*0x20*/ bool _local;
            /*0x28*/ string _relationName;
            /*0x30*/ string _columnName;
            /*0x38*/ System.Data.DataTable _childTable;
            /*0x40*/ System.Data.DataColumn _column;
            /*0x48*/ System.Data.DataRelation _relation;

            static /*0x3737aa0*/ void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x3737594*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName);
            /*0x37375a0*/ AggregateNode(System.Data.DataTable table, System.Data.FunctionId aggregateType, string columnName, bool local, string relationName);
            /*0x3737720*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x3737c0c*/ object Eval();
            /*0x3737c20*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3737f10*/ object Eval(int[] records);
            /*0x3737fd4*/ bool IsConstant();
            /*0x3737fdc*/ bool IsTableConstant();
            /*0x3737fe4*/ bool HasLocalAggregate();
            /*0x3737fec*/ bool HasRemoteAggregate();
            /*0x3737ffc*/ bool DependsOn(System.Data.DataColumn column);
            /*0x3738094*/ System.Data.ExpressionNode Optimize();
        }

        class BinaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _left;
            /*0x28*/ System.Data.ExpressionNode _right;

            static /*0x373e19c*/ object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            static /*0x373fd70*/ System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code);
            /*0x3738098*/ BinaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x3738100*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x3738170*/ object Eval();
            /*0x3738184*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x373d94c*/ object Eval(int[] recordNos);
            /*0x373d968*/ bool IsConstant();
            /*0x373d9b0*/ bool IsTableConstant();
            /*0x373d9f8*/ bool HasLocalAggregate();
            /*0x373da40*/ bool HasRemoteAggregate();
            /*0x373da88*/ bool DependsOn(System.Data.DataColumn column);
            /*0x373daec*/ System.Data.ExpressionNode Optimize();
            /*0x373e0a0*/ void SetTypeMismatchError(int op, System.Type left, System.Type right);
            /*0x373e1d4*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op);
            /*0x373e1dc*/ int BinaryCompare(object vLeft, object vRight, System.Data.Common.StorageType resultType, int op, System.Globalization.CompareInfo comparer);
            /*0x37381a0*/ object EvalBinaryOp(int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, int[] recordNos);
            /*0x373fd4c*/ System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType);
            /*0x373fd94*/ bool IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x373fe50*/ bool IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right);
            /*0x373f894*/ System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x373f4ac*/ System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, bool lc, bool rc, int op);
            /*0x3740048*/ int SqlResultType(int typeCode);

            enum DataTypePrecedence
            {
                SqlDateTime = 25,
                DateTimeOffset = 24,
                DateTime = 23,
                TimeSpan = 20,
                SqlDouble = 19,
                Double = 18,
                SqlSingle = 17,
                Single = 16,
                SqlDecimal = 15,
                Decimal = 14,
                SqlMoney = 13,
                UInt64 = 12,
                SqlInt64 = 11,
                Int64 = 10,
                UInt32 = 9,
                SqlInt32 = 8,
                Int32 = 7,
                UInt16 = 6,
                SqlInt16 = 5,
                Int16 = 4,
                Byte = 3,
                SqlByte = 2,
                SByte = 1,
                Error = 0,
                SqlBoolean = -1,
                Boolean = -2,
                SqlGuid = -3,
                SqlString = -4,
                String = -5,
                SqlXml = -6,
                SqlChars = -7,
                Char = -8,
                SqlBytes = -9,
                SqlBinary = -10,
            }
        }

        class LikeNode : System.Data.BinaryNode
        {
            /*0x30*/ int _kind;
            /*0x38*/ string _pattern;

            /*0x3740098*/ LikeNode(System.Data.DataTable table, int op, System.Data.ExpressionNode left, System.Data.ExpressionNode right);
            /*0x374009c*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x37405b8*/ string AnalyzePattern(string pat);
        }

        class ConstNode : System.Data.ExpressionNode
        {
            /*0x18*/ object _val;

            /*0x37408c4*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant);
            /*0x373dd78*/ ConstNode(System.Data.DataTable table, System.Data.ValueType type, object constant, bool fParseQuotes);
            /*0x3741220*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x3741228*/ object Eval();
            /*0x3741230*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x374123c*/ object Eval(int[] recordNos);
            /*0x3741248*/ bool IsConstant();
            /*0x3741250*/ bool IsTableConstant();
            /*0x3741258*/ bool HasLocalAggregate();
            /*0x3741260*/ bool HasRemoteAggregate();
            /*0x3741268*/ System.Data.ExpressionNode Optimize();
            /*0x3740ddc*/ object SmallestDecimal(object constant);
            /*0x37408cc*/ object SmallestNumeric(object constant);
        }

        class DataExpression : System.Data.IFilter
        {
            /*0x10*/ string _originalExpression;
            /*0x18*/ bool _parsed;
            /*0x19*/ bool _bound;
            /*0x20*/ System.Data.ExpressionNode _expr;
            /*0x28*/ System.Data.DataTable _table;
            /*0x30*/ System.Data.Common.StorageType _storageType;
            /*0x38*/ System.Type _dataType;
            /*0x40*/ System.Data.DataColumn[] _dependency;

            static /*0x37429ec*/ bool IsUnknown(object value);
            static /*0x373f22c*/ bool ToBoolean(object value);
            /*0x3735744*/ DataExpression(System.Data.DataTable table, string expression);
            /*0x374126c*/ DataExpression(System.Data.DataTable table, string expression, System.Type type);
            /*0x3742538*/ string get_Expression();
            /*0x3742588*/ bool get_HasValue();
            /*0x3742400*/ void Bind(System.Data.DataTable table);
            /*0x3738078*/ bool DependsOn(System.Data.DataColumn column);
            /*0x3742598*/ object Evaluate();
            /*0x37425a4*/ object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x374285c*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x37429cc*/ System.Data.DataColumn[] GetDependency();
            /*0x37429d4*/ bool IsTableAggregate();
            /*0x3742a44*/ bool HasLocalAggregate();
            /*0x3742a5c*/ bool HasRemoteAggregate();
        }

        class ExpressionNode
        {
            /*0x10*/ System.Data.DataTable _table;

            static /*0x373ff6c*/ bool IsInteger(System.Data.Common.StorageType type);
            static /*0x373fc00*/ bool IsIntegerSql(System.Data.Common.StorageType type);
            static /*0x373fe10*/ bool IsSigned(System.Data.Common.StorageType type);
            static /*0x373fed4*/ bool IsSignedSql(System.Data.Common.StorageType type);
            static /*0x373fe40*/ bool IsUnsigned(System.Data.Common.StorageType type);
            static /*0x373fef0*/ bool IsUnsignedSql(System.Data.Common.StorageType type);
            static /*0x373ff5c*/ bool IsNumeric(System.Data.Common.StorageType type);
            static /*0x3740078*/ bool IsNumericSql(System.Data.Common.StorageType type);
            static /*0x3742a94*/ bool IsFloat(System.Data.Common.StorageType type);
            static /*0x3742aa4*/ bool IsFloatSql(System.Data.Common.StorageType type);
            /*0x37376a0*/ ExpressionNode(System.Data.DataTable table);
            /*0x373f1c0*/ System.IFormatProvider get_FormatProvider();
            /*0x3742a74*/ bool get_IsSqlColumn();
            /*0x3742a7c*/ System.Data.DataTable get_table();
            /*0x3742a84*/ void BindTable(System.Data.DataTable table);
            /*0x1f30ff0*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x1f30214*/ object Eval();
            /*0x1f30300*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x1f302cc*/ object Eval(int[] recordNos);
            /*0x1f2fe14*/ bool IsConstant();
            /*0x1f2fe14*/ bool IsTableConstant();
            /*0x1f2fe14*/ bool HasLocalAggregate();
            /*0x1f2fe14*/ bool HasRemoteAggregate();
            /*0x1f30214*/ System.Data.ExpressionNode Optimize();
            /*0x3742a8c*/ bool DependsOn(System.Data.DataColumn column);
        }

        enum ValueType
        {
            Unknown = -1,
            Null = 0,
            Bool = 1,
            Numeric = 2,
            Str = 3,
            Float = 4,
            Decimal = 5,
            Object = 6,
            Date = 7,
        }

        enum Nodes
        {
            Noop = 0,
            Unop = 1,
            UnopSpec = 2,
            Binop = 3,
            BinopSpec = 4,
            Zop = 5,
            Call = 6,
            Const = 7,
            Name = 8,
            Paren = 9,
            Conv = 10,
        }

        class ExpressionParser
        {
            static /*0x0*/ System.Data.ExpressionParser.ReservedWords[] s_reservedwords;
            /*0x10*/ char _escape;
            /*0x12*/ char _decimalSeparator;
            /*0x14*/ char _listSeparator;
            /*0x16*/ char _exponentL;
            /*0x18*/ char _exponentU;
            /*0x20*/ char[] _text;
            /*0x28*/ int _pos;
            /*0x2c*/ int _start;
            /*0x30*/ System.Data.Tokens _token;
            /*0x34*/ int _op;
            /*0x38*/ System.Data.OperatorInfo[] _ops;
            /*0x40*/ int _topOperator;
            /*0x44*/ int _topNode;
            /*0x48*/ System.Data.DataTable _table;
            /*0x50*/ System.Data.ExpressionNode[] _nodeStack;
            /*0x58*/ int _prevOperand;
            /*0x60*/ System.Data.ExpressionNode _expression;

            static /*0x37446cc*/ ExpressionParser();
            /*0x374145c*/ ExpressionParser(System.Data.DataTable table);
            /*0x3741520*/ void LoadExpression(string data);
            /*0x3742ac0*/ void StartScan();
            /*0x3741694*/ System.Data.ExpressionNode Parse();
            /*0x374373c*/ System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate);
            /*0x3743700*/ System.Data.ExpressionNode NodePop();
            /*0x374367c*/ System.Data.ExpressionNode NodePeek();
            /*0x37435e4*/ void NodePush(System.Data.ExpressionNode node);
            /*0x3742fe4*/ void BuildExpression(int pri);
            /*0x37434a0*/ void CheckToken(System.Data.Tokens token);
            /*0x3742b94*/ System.Data.Tokens Scan();
            /*0x37441cc*/ void ScanNumeric();
            /*0x3744538*/ void ScanName();
            /*0x37440bc*/ void ScanName(char chEnd, char esc, string charsToEscape);
            /*0x3743f48*/ void ScanDate();
            /*0x37442fc*/ void ScanBinaryConstant();
            /*0x3744314*/ void ScanReserved();
            /*0x3743fe8*/ void ScanString(char escape);
            /*0x3743290*/ void ScanToken(System.Data.Tokens token);
            /*0x3743ee8*/ void ScanWhite();
            /*0x37446b8*/ bool IsWhiteSpace(char ch);
            /*0x37444f4*/ bool IsAlphaNumeric(char ch);
            /*0x3744300*/ bool IsDigit(char ch);
            /*0x3744644*/ bool IsAlpha(char ch);

            struct ReservedWords
            {
                /*0x10*/ string _word;
                /*0x18*/ System.Data.Tokens _token;
                /*0x1c*/ int _op;

                /*0x3744b40*/ ReservedWords(string word, System.Data.Tokens token, int op);
            }
        }

        enum Tokens
        {
            None = 0,
            Name = 1,
            Numeric = 2,
            Decimal = 3,
            Float = 4,
            BinaryConst = 5,
            StringConst = 6,
            Date = 7,
            ListSeparator = 8,
            LeftParen = 9,
            RightParen = 10,
            ZeroOp = 11,
            UnaryOp = 12,
            BinaryOp = 13,
            Child = 14,
            Parent = 15,
            Dot = 16,
            Unknown = 17,
            EOS = 18,
        }

        class OperatorInfo
        {
            /*0x10*/ System.Data.Nodes _type;
            /*0x14*/ int _op;
            /*0x18*/ int _priority;

            /*0x3742b58*/ OperatorInfo(System.Data.Nodes type, int op, int pri);
        }

        class InvalidExpressionException : System.Data.DataException
        {
            /*0x3744b6c*/ InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x3744b74*/ InvalidExpressionException();
            /*0x3744b7c*/ InvalidExpressionException(string s);
        }

        class EvaluateException : System.Data.InvalidExpressionException
        {
            /*0x3744b84*/ EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x3744b8c*/ EvaluateException();
            /*0x3744b94*/ EvaluateException(string s);
        }

        class SyntaxErrorException : System.Data.InvalidExpressionException
        {
            /*0x3744b9c*/ SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x3744ba4*/ SyntaxErrorException();
            /*0x3744bac*/ SyntaxErrorException(string s);
        }

        class ExprException
        {
            static /*0x3744bb4*/ System.OverflowException _Overflow(string error);
            static /*0x3744c1c*/ System.Data.InvalidExpressionException _Expr(string error);
            static /*0x3744c84*/ System.Data.SyntaxErrorException _Syntax(string error);
            static /*0x3744cec*/ System.Data.EvaluateException _Eval(string error);
            static /*0x3744d54*/ System.Data.EvaluateException _Eval(string error, System.Exception innerException);
            static /*0x3742938*/ System.Exception InvokeArgument();
            static /*0x3744dbc*/ System.Exception NYI(string moreinfo);
            static /*0x3742f58*/ System.Exception MissingOperand(System.Data.OperatorInfo before);
            static /*0x3743240*/ System.Exception MissingOperator(string token);
            static /*0x3744e0c*/ System.Exception TypeMismatch(string expr);
            static /*0x3744e5c*/ System.Exception FunctionArgumentOutOfRange(string arg, string func);
            static /*0x3743d94*/ System.Exception ExpressionTooComplex();
            static /*0x3737a50*/ System.Exception UnboundName(string name);
            static /*0x3744668*/ System.Exception InvalidString(string str);
            static /*0x37376d0*/ System.Exception UndefinedFunction(string name);
            static /*0x37436c0*/ System.Exception SyntaxError();
            static /*0x3744ec4*/ System.Exception FunctionArgumentCount(string name);
            static /*0x3743200*/ System.Exception MissingRightParen();
            static /*0x3743cb0*/ System.Exception UnknownToken(string token, int position);
            static /*0x3743dd4*/ System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, int position);
            static /*0x3744f14*/ System.Exception DatatypeConvertion(System.Type type1, System.Type type2);
            static /*0x37427d0*/ System.Exception DatavalueConvertion(object value, System.Type type, System.Exception innerException);
            static /*0x3744fa0*/ System.Exception InvalidName(string name);
            static /*0x37445f4*/ System.Exception InvalidDate(string date);
            static /*0x3744ff0*/ System.Exception NonConstantArgument();
            static /*0x3740874*/ System.Exception InvalidPattern(string pat);
            static /*0x373fc20*/ System.Exception InWithoutParentheses();
            static /*0x3745030*/ System.Exception InWithoutList();
            static /*0x373dd38*/ System.Exception InvalidIsSyntax();
            static /*0x373fce0*/ System.Exception Overflow(System.Type type);
            static /*0x3745070*/ System.Exception ArgumentType(string function, int arg, System.Type type);
            static /*0x3745138*/ System.Exception ArgumentTypeInteger(string function, int arg);
            static /*0x373e0d0*/ System.Exception TypeMismatchInBinop(int op, System.Type type1, System.Type type2);
            static /*0x373ff7c*/ System.Exception AmbiguousBinop(int op, System.Type type1, System.Type type2);
            static /*0x373fc60*/ System.Exception UnsupportedOperator(int op);
            static /*0x37445a4*/ System.Exception InvalidNameBracketing(string name);
            static /*0x3743ab0*/ System.Exception MissingOperandBefore(string op);
            static /*0x3743a1c*/ System.Exception TooManyRightParentheses();
            static /*0x37379f0*/ System.Exception UnresolvedRelation(string name, string expr);
            static /*0x37451dc*/ System.Data.EvaluateException BindFailure(string relationName);
            static /*0x3743d54*/ System.Exception AggregateArgument();
            static /*0x37379a0*/ System.Exception AggregateUnbound(string expr);
            static /*0x3737ed0*/ System.Exception EvalNoContext();
            static /*0x374522c*/ System.Exception ExpressionUnbound(string expr);
            static /*0x3737f84*/ System.Exception ComputeNotAggregate(string expr);
            static /*0x374297c*/ System.Exception FilterConvertion(string expr);
            static /*0x37434e0*/ System.Exception LookupArgument();
            static /*0x374527c*/ System.Exception InvalidType(string typeName);
            static /*0x37452cc*/ System.Exception InvalidHoursArgument();
            static /*0x374530c*/ System.Exception InvalidMinutesArgument();
            static /*0x374534c*/ System.Exception InvalidTimeZoneRange();
            static /*0x374538c*/ System.Exception MismatchKindandTimeSpan();
            static /*0x3741620*/ System.Exception UnsupportedDataType(System.Type type);
        }

        interface IFilter
        {
            bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
        }

        class LookupNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _relationName;
            /*0x20*/ string _columnName;
            /*0x28*/ System.Data.DataColumn _column;
            /*0x30*/ System.Data.DataRelation _relation;

            /*0x3743520*/ LookupNode(System.Data.DataTable table, string columnName, string relationName);
            /*0x37453cc*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x3745630*/ object Eval();
            /*0x3745654*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3745758*/ object Eval(int[] recordNos);
            /*0x3745788*/ bool IsConstant();
            /*0x3745790*/ bool IsTableConstant();
            /*0x3745798*/ bool HasLocalAggregate();
            /*0x37457a0*/ bool HasRemoteAggregate();
            /*0x37457a8*/ bool DependsOn(System.Data.DataColumn column);
            /*0x37457b8*/ System.Data.ExpressionNode Optimize();
        }

        class NameNode : System.Data.ExpressionNode
        {
            /*0x18*/ string _name;
            /*0x20*/ bool _found;
            /*0x28*/ System.Data.DataColumn _column;

            static /*0x37432b8*/ string ParseName(char[] text, int start, int pos);
            /*0x3743580*/ NameNode(System.Data.DataTable table, char[] text, int start, int pos);
            /*0x3743c6c*/ NameNode(System.Data.DataTable table, string name);
            /*0x37457bc*/ bool get_IsSqlColumn();
            /*0x37457d4*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x37459ec*/ object Eval();
            /*0x3745a10*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3745aac*/ object Eval(int[] records);
            /*0x3745adc*/ bool IsConstant();
            /*0x3745ae4*/ bool IsTableConstant();
            /*0x3745b38*/ bool HasLocalAggregate();
            /*0x3745b8c*/ bool HasRemoteAggregate();
            /*0x3745be0*/ bool DependsOn(System.Data.DataColumn column);
            /*0x3745c5c*/ System.Data.ExpressionNode Optimize();
        }

        class Operators
        {
            static /*0x0*/ int[] s_priority;
            static /*0x8*/ string[] s_looks;

            static /*0x3745c60*/ Operators();
            static /*0x373ff40*/ bool IsArithmetical(int op);
            static /*0x373ff20*/ bool IsLogical(int op);
            static /*0x373ff10*/ bool IsRelational(int op);
            static /*0x3743bc0*/ int Priority(int op);
            static /*0x3743b00*/ string ToString(int op);
        }

        class UnaryNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;
            /*0x20*/ System.Data.ExpressionNode _right;

            /*0x3743a5c*/ UnaryNode(System.Data.DataTable table, int op, System.Data.ExpressionNode right);
            /*0x37464f4*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x374653c*/ object Eval();
            /*0x3746550*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3746d28*/ object Eval(int[] recordNos);
            /*0x3746590*/ object EvalUnaryOp(int op, object vl);
            /*0x3746d44*/ bool IsConstant();
            /*0x3746d60*/ bool IsTableConstant();
            /*0x3746d7c*/ bool HasLocalAggregate();
            /*0x3746d98*/ bool HasRemoteAggregate();
            /*0x3746db4*/ bool DependsOn(System.Data.DataColumn column);
            /*0x3746dd4*/ System.Data.ExpressionNode Optimize();
        }

        class ZeroOpNode : System.Data.ExpressionNode
        {
            /*0x18*/ int _op;

            /*0x3746e98*/ ZeroOpNode(int op);
            /*0x3746ec4*/ void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list);
            /*0x3746ec8*/ object Eval();
            /*0x3746f74*/ object Eval(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x3746f80*/ object Eval(int[] recordNos);
            /*0x3746f8c*/ bool IsConstant();
            /*0x3746f94*/ bool IsTableConstant();
            /*0x3746f9c*/ bool HasLocalAggregate();
            /*0x3746fa4*/ bool HasRemoteAggregate();
            /*0x3746fac*/ System.Data.ExpressionNode Optimize();
        }

        class ForeignKeyConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.Rule _deleteRule;
            /*0x3c*/ System.Data.Rule _updateRule;
            /*0x40*/ System.Data.AcceptRejectRule _acceptRejectRule;
            /*0x48*/ System.Data.DataKey _childKey;
            /*0x50*/ System.Data.DataKey _parentKey;
            /*0x58*/ string _constraintName;
            /*0x60*/ string[] _parentColumnNames;
            /*0x68*/ string[] _childColumnNames;
            /*0x70*/ string _parentTableName;

            /*0x3746fb0*/ ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x3746ff0*/ ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x37471bc*/ ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule);
            /*0x3747264*/ System.Data.DataKey get_ChildKey();
            /*0x3747280*/ System.Data.DataColumn[] get_Columns();
            /*0x37472a0*/ System.Data.DataTable get_Table();
            /*0x37472c0*/ string[] get_ParentColumnNames();
            /*0x37472cc*/ string[] get_ChildColumnNames();
            /*0x37472d8*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x3747400*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x3747408*/ bool IsKeyNull(object[] values);
            /*0x37474c4*/ bool IsConstraintViolated();
            /*0x3747a10*/ bool CanEnableConstraint();
            /*0x3747b64*/ void CascadeCommit(System.Data.DataRow row);
            /*0x3747cc0*/ void CascadeDelete(System.Data.DataRow row);
            /*0x37481e0*/ void CascadeRollback(System.Data.DataRow row);
            /*0x37483c8*/ void CascadeUpdate(System.Data.DataRow row);
            /*0x3748854*/ void CheckCanClearParentTable(System.Data.DataTable table);
            /*0x3748930*/ void CheckCanRemoveParentRow(System.Data.DataRow row);
            /*0x37489f8*/ void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x3748b1c*/ void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action);
            /*0x3748de8*/ void NonVirtualCheckState();
            /*0x374902c*/ void CheckState();
            /*0x3749030*/ System.Data.AcceptRejectRule get_AcceptRejectRule();
            /*0x374904c*/ void set_AcceptRejectRule(System.Data.AcceptRejectRule value);
            /*0x374909c*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x37490e4*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x37490f4*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x3749838*/ System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination);
            /*0x374703c*/ void Create(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns);
            /*0x3749e18*/ System.Data.Rule get_DeleteRule();
            /*0x3749e34*/ void set_DeleteRule(System.Data.Rule value);
            /*0x3749e84*/ bool Equals(object key);
            /*0x3749f74*/ int GetHashCode();
            /*0x3749f7c*/ System.Data.DataColumn[] get_RelatedColumns();
            /*0x374981c*/ System.Data.DataColumn[] get_RelatedColumnsReference();
            /*0x37489dc*/ System.Data.DataKey get_ParentKey();
            /*0x3749f9c*/ System.Data.DataRelation FindParentRelation();
            /*0x374a064*/ System.Data.DataTable get_RelatedTable();
            /*0x374a084*/ System.Data.Rule get_UpdateRule();
            /*0x374a0a0*/ void set_UpdateRule(System.Data.Rule value);
        }

        enum MappingType
        {
            Element = 1,
            Attribute = 2,
            SimpleContent = 3,
            Hidden = 4,
        }

        class MergeFailedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Data.DataTable <Table>k__BackingField;
            /*0x18*/ string <Conflict>k__BackingField;

            /*0x374a0f0*/ MergeFailedEventArgs(System.Data.DataTable table, string conflict);
            /*0x374a178*/ string get_Conflict();
        }

        class MergeFailedEventHandler : System.MulticastDelegate
        {
            /*0x374a180*/ MergeFailedEventHandler(object object, nint method);
            /*0x374a28c*/ void Invoke(object sender, System.Data.MergeFailedEventArgs e);
        }

        class Merger
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.DataTable _dataTable;
            /*0x20*/ bool _preserveChanges;
            /*0x24*/ System.Data.MissingSchemaAction _missingSchemaAction;
            /*0x28*/ bool _isStandAlonetable;
            /*0x29*/ bool _IgnoreNSforTableLookup;

            /*0x374a2a0*/ Merger(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x374a2f4*/ Merger(System.Data.DataTable dataTable, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction);
            /*0x374a350*/ void MergeDataSet(System.Data.DataSet source);
            /*0x374be4c*/ void MergeTable(System.Data.DataTable src);
            /*0x374c07c*/ void MergeTable(System.Data.DataTable src, System.Data.DataTable dst);
            /*0x374c674*/ System.Data.DataTable MergeSchema(System.Data.DataTable table);
            /*0x374b288*/ void MergeTableData(System.Data.DataTable src);
            /*0x374b33c*/ void MergeConstraints(System.Data.DataSet source);
            /*0x374cd84*/ void MergeConstraints(System.Data.DataTable table);
            /*0x374b3ac*/ void MergeRelation(System.Data.DataRelation relation);
            /*0x374bbf8*/ void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst);
            /*0x374c520*/ System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst);
        }

        enum MissingSchemaAction
        {
            Add = 1,
            Ignore = 2,
            Error = 3,
            AddWithKey = 4,
        }

        class PrimaryKeyTypeConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x374d030*/ PrimaryKeyTypeConverter();
            /*0x374d0d0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x374d0d8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x374d164*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class PropertyCollection : System.Collections.Hashtable, System.ICloneable
        {
            /*0x374d30c*/ PropertyCollection();
            /*0x374d314*/ PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x374d31c*/ object Clone();
        }

        struct Range
        {
            /*0x10*/ int _min;
            /*0x14*/ int _max;
            /*0x18*/ bool _isNotNull;

            /*0x374d5e8*/ Range(int min, int max);
            /*0x374817c*/ int get_Count();
            /*0x3747cb0*/ bool get_IsNull();
            /*0x374819c*/ int get_Min();
            /*0x374d630*/ void CheckNull();
        }

        enum RBTreeError
        {
            InvalidPageSize = 1,
            PagePositionInSlotInUse = 3,
            NoFreeSlots = 4,
            InvalidStateinInsert = 5,
            InvalidNextSizeInDelete = 7,
            InvalidStateinDelete = 8,
            InvalidNodeSizeinDelete = 9,
            InvalidStateinEndDelete = 10,
            CannotRotateInvalidsuccessorNodeinDelete = 11,
            IndexOutOFRangeinGetNodeByIndex = 13,
            RBDeleteFixup = 14,
            UnsupportedAccessMethod1 = 15,
            UnsupportedAccessMethod2 = 16,
            UnsupportedAccessMethodInNonNillRootSubtree = 17,
            AttachedNodeWithZerorbTreeNodeId = 18,
            CompareNodeInDataRowTree = 19,
            CompareSateliteTreeNodeInDataRowTree = 20,
            NestedSatelliteTreeEnumerator = 21,
        }

        enum TreeAccessMethod
        {
            KEY_SEARCH_AND_INDEX = 1,
            INDEX_ONLY = 2,
        }

        class RBTree<K> : System.Collections.IEnumerable
        {
            /*0x0*/ System.Data.RBTree.TreePage<K> _pageTable;
            /*0x0*/ int[] _pageTableMap;
            /*0x0*/ int _inUsePageCount;
            /*0x0*/ int _nextFreePageLine;
            /*0x0*/ int root;
            /*0x0*/ int _version;
            /*0x0*/ int _inUseNodeCount;
            /*0x0*/ int _inUseSatelliteTreeCount;
            /*0x0*/ System.Data.TreeAccessMethod _accessMethod;

            static /*0x1ffc854*/ int GetIntValueFromBitMap(uint bitMap);
            /*0x1f30b78*/ RBTree(System.Data.TreeAccessMethod accessMethod);
            /*0x1ffc854*/ int CompareNode(K record1, K record2);
            /*0x1ffc854*/ int CompareSateliteTreeNode(K record1, K record2);
            /*0x1f309e4*/ void InitTree();
            /*0x1f30ebc*/ void FreePage(System.Data.RBTree.TreePage<K> page);
            /*0x1f30240*/ System.Data.RBTree.TreePage<K> AllocPage(int size);
            /*0x1f30ebc*/ void MarkPageFull(System.Data.RBTree.TreePage<K> page);
            /*0x1f30ebc*/ void MarkPageFree(System.Data.RBTree.TreePage<K> page);
            /*0x1f30b78*/ void FreeNode(int nodeId);
            int GetIndexOfPageWithFreeSlot(bool allocatedPage);
            /*0x1f2ffc8*/ int get_Count();
            /*0x1f2fe14*/ bool get_HasDuplicates();
            /*0x1ffc854*/ int GetNewNode(K key);
            int Successor(int x_id);
            /*0x1f2ff00*/ bool Successor(ref int nodeId, ref int mainTreeNodeId);
            int Minimum(int x_id);
            int LeftRotate(int root_id, int x_id, int mainTreeNode);
            int RightRotate(int root_id, int x_id, int mainTreeNode);
            /*0x1ffc854*/ int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append);
            /*0x1ffc854*/ void UpdateNodeKey(K currentKey, K newKey);
            /*0x1ffc854*/ K DeleteByIndex(int i);
            int RBDelete(int z_id);
            int RBDeleteX(int root_id, int z_id, int mainTreeNodeID);
            int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID);
            /*0x1ffc854*/ int SearchSubTree(int root_id, K key);
            /*0x1ffc854*/ K get_Item(int index);
            /*0x1ffc854*/ System.Data.RBTree.NodePath<K> GetNodeByKey(K key);
            /*0x1ffc854*/ int GetIndexByKey(K key);
            int GetIndexByNode(int node);
            /*0x1ffc854*/ int GetIndexByNodePath(System.Data.RBTree.NodePath<K> path);
            int ComputeIndexByNode(int nodeId);
            int ComputeIndexWithSatelliteByNode(int nodeId);
            /*0x1ffc854*/ System.Data.RBTree.NodePath<K> GetNodeByIndex(int userIndex);
            int ComputeNodeByIndex(int index, ref int satelliteRootId);
            /*0x1f2fff4*/ int ComputeNodeByIndex(int x_id, int index);
            /*0x1ffc854*/ int Insert(K item);
            /*0x1ffc854*/ int Add(K item);
            /*0x1f30214*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1ffc854*/ int IndexOf(int nodeId, K item);
            /*0x1ffc854*/ int Insert(int position, K item);
            /*0x1ffc854*/ int InsertAt(int position, K item, bool append);
            /*0x1f30b78*/ void RemoveAt(int position);
            /*0x1f309e4*/ void Clear();
            /*0x1f30ee8*/ void CopyTo(System.Array array, int index);
            /*0x1f30ee8*/ void CopyTo(K[] array, int index);
            /*0x1f30bb4*/ void SetRight(int nodeId, int rightNodeId);
            /*0x1f30bb4*/ void SetLeft(int nodeId, int leftNodeId);
            /*0x1f30bb4*/ void SetParent(int nodeId, int parentNodeId);
            /*0x1ffc854*/ void SetColor(int nodeId, System.Data.RBTree.NodeColor<K> color);
            /*0x1ffc854*/ void SetKey(int nodeId, K key);
            /*0x1f30bb4*/ void SetNext(int nodeId, int nextNodeId);
            /*0x1f30bb4*/ void SetSubTreeSize(int nodeId, int size);
            /*0x1f30b78*/ void IncreaseSize(int nodeId);
            /*0x1f30b78*/ void RecomputeSize(int nodeId);
            /*0x1f30b78*/ void DecreaseSize(int nodeId);
            int Right(int nodeId);
            int Left(int nodeId);
            int Parent(int nodeId);
            /*0x1ffc854*/ System.Data.RBTree.NodeColor<K> color(int nodeId);
            int Next(int nodeId);
            int SubTreeSize(int nodeId);
            /*0x1ffc854*/ K Key(int nodeId);

            enum NodeColor<K>
            {
                red = 0,
                black = 1,
            }

            struct Node<K>
            {
                /*0x0*/ int _selfId;
                /*0x0*/ int _leftId;
                /*0x0*/ int _rightId;
                /*0x0*/ int _parentId;
                /*0x0*/ int _nextId;
                /*0x0*/ int _subTreeSize;
                /*0x0*/ K _keyOfNode;
                /*0x0*/ System.Data.RBTree.NodeColor<K> _nodeColor;
            }

            struct NodePath<K>
            {
                /*0x0*/ int _nodeID;
                /*0x0*/ int _mainTreeNodeID;

                /*0x1f30bb4*/ NodePath(int nodeID, int mainTreeNodeID);
            }

            class TreePage<K>
            {
                /*0x0*/ System.Data.RBTree.Node<K> _slots;
                /*0x0*/ int[] _slotMap;
                /*0x0*/ int _inUseCount;
                /*0x0*/ int _pageId;
                /*0x0*/ int _nextFreeSlotLine;

                /*0x1f30b78*/ TreePage(int size);
                /*0x1f3008c*/ int AllocSlot(System.Data.RBTree<K> tree);
                /*0x1f2ffc8*/ int get_InUseCount();
                /*0x1f30b78*/ void set_InUseCount(int value);
                /*0x1f2ffc8*/ int get_PageId();
                /*0x1f30b78*/ void set_PageId(int value);
            }

            struct RBTreeEnumerator<K> : System.Collections.Generic.IEnumerator<K>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ System.Data.RBTree<K> _tree;
                /*0x0*/ int _version;
                /*0x0*/ int _index;
                /*0x0*/ int _mainTreeNodeId;
                /*0x0*/ K _current;

                /*0x1f30ebc*/ RBTreeEnumerator(System.Data.RBTree<K> tree);
                /*0x1f30ee8*/ RBTreeEnumerator(System.Data.RBTree<K> tree, int position);
                /*0x1f309e4*/ void Dispose();
                /*0x1f2fe14*/ bool MoveNext();
                /*0x1ffc854*/ K get_Current();
                /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
            }
        }

        class RecordManager
        {
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ int _lastFreeRecord;
            /*0x1c*/ int _minimumCapacity;
            /*0x20*/ int _recordCapacity;
            /*0x28*/ System.Collections.Generic.List<int> _freeRecordList;
            /*0x30*/ System.Data.DataRow[] _rows;

            static /*0x374d854*/ int NewCapacity(int capacity);
            /*0x374d664*/ RecordManager(System.Data.DataTable table);
            /*0x374d73c*/ void GrowRecordCapacity();
            /*0x374d92c*/ int get_LastFreeRecord();
            /*0x374d934*/ int get_MinimumCapacity();
            /*0x374d93c*/ void set_MinimumCapacity(int value);
            /*0x374d97c*/ int get_RecordCapacity();
            /*0x374d89c*/ void set_RecordCapacity(int value);
            /*0x374d868*/ int NormalizedMinimumCapacity(int capacity);
            /*0x374d984*/ int NewRecordBase();
            /*0x374da50*/ void FreeRecord(ref int record);
            /*0x374dbcc*/ void Clear(bool clearAll);
            /*0x374de24*/ System.Data.DataRow get_Item(int record);
            /*0x374db64*/ void set_Item(int record, System.Data.DataRow value);
            /*0x374de54*/ int ImportRecord(System.Data.DataTable src, int record);
            /*0x374de5c*/ int CopyRecord(System.Data.DataTable src, int record, int copy);
            /*0x374e1b0*/ void SetRowCache(System.Data.DataRow[] newRows);
        }

        class RelatedView : System.Data.DataView, System.Data.IFilter
        {
            /*0xb0*/ System.Nullable<System.Data.DataKey> _parentKey;
            /*0xc0*/ System.Data.DataKey _childKey;
            /*0xc8*/ System.Data.DataRowView _parentRowView;
            /*0xd0*/ object[] _filterValues;

            /*0x374e1f0*/ RelatedView(System.Data.DataColumn[] columns, object[] values);
            /*0x374e32c*/ RelatedView(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns);
            /*0x374e46c*/ object[] GetParentValues();
            /*0x374e508*/ bool Invoke(System.Data.DataRow row, System.Data.DataRowVersion version);
            /*0x374e690*/ System.Data.IFilter GetFilter();
            /*0x374e694*/ System.Data.DataRowView AddNew();
            /*0x374e6f4*/ void SetIndex(string newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter);
        }

        class RelationshipConverter : System.ComponentModel.ExpandableObjectConverter
        {
            /*0x374e718*/ RelationshipConverter();
            /*0x374e720*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x374e7d0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        enum Rule
        {
            None = 0,
            Cascade = 1,
            SetNull = 2,
            SetDefault = 3,
        }

        enum SchemaSerializationMode
        {
            IncludeSchema = 1,
            ExcludeSchema = 2,
        }

        struct IndexField
        {
            /*0x10*/ System.Data.DataColumn Column;
            /*0x18*/ bool IsDescending;

            static /*0x374f3d4*/ bool op_Equality(System.Data.IndexField if1, System.Data.IndexField if2);
            /*0x374f3ac*/ IndexField(System.Data.DataColumn column, bool isDescending);
            /*0x374f3e8*/ bool Equals(object obj);
            /*0x374f470*/ int GetHashCode();
        }

        class Index
        {
            static /*0x0*/ int s_objectTypeCount;
            /*0x10*/ System.Data.DataTable _table;
            /*0x18*/ System.Data.IndexField[] _indexFields;
            /*0x20*/ System.Comparison<System.Data.DataRow> _comparison;
            /*0x28*/ System.Data.DataViewRowState _recordStates;
            /*0x30*/ System.WeakReference _rowFilter;
            /*0x38*/ System.Data.Index.IndexTree _records;
            /*0x40*/ int _recordCount;
            /*0x44*/ int _refCount;
            /*0x48*/ System.Data.Listeners<System.Data.DataViewListener> _listeners;
            /*0x50*/ bool _suspendEvents;
            /*0x51*/ bool _isSharable;
            /*0x52*/ bool _hasRemoteAggregate;
            /*0x54*/ int _objectID;

            static /*0x374f86c*/ System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns);
            static /*0x3751cd8*/ int GetReplaceAction(System.Data.DataViewRowState oldState);
            static /*0x1ffc854*/ int IndexOfReference<T>(System.Collections.Generic.List<T> list, T item);
            /*0x374f4d0*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x374f814*/ Index(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x374f4e0*/ Index(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x374fd24*/ bool Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter);
            /*0x374fdbc*/ bool get_HasRemoteAggregate();
            /*0x374fdc4*/ int get_ObjectID();
            /*0x374fdcc*/ System.Data.DataViewRowState get_RecordStates();
            /*0x374fdd4*/ System.Data.IFilter get_RowFilter();
            /*0x374fe4c*/ int GetRecord(int recordIndex);
            /*0x374feb8*/ bool get_HasDuplicates();
            /*0x374ff08*/ int get_RecordCount();
            /*0x374ff10*/ bool AcceptRecord(int record);
            /*0x374ff3c*/ bool AcceptRecord(int record, System.Data.IFilter filter);
            /*0x37500dc*/ void ListChangedAdd(System.Data.DataViewListener listener);
            /*0x3750134*/ void ListChangedRemove(System.Data.DataViewListener listener);
            /*0x375018c*/ int get_RefCount();
            /*0x3750194*/ void AddRef();
            /*0x375033c*/ int RemoveRef();
            /*0x37504f4*/ void ApplyChangeAction(int record, int action, int changeRecord);
            /*0x3750998*/ bool CheckUnique();
            /*0x37509b0*/ int CompareRecords(int record1, int record2);
            /*0x3750b10*/ int CompareDataRows(int record1, int record2);
            /*0x3750b7c*/ int CompareDuplicateRecords(int record1, int record2);
            /*0x3750cd4*/ int CompareRecordToKey(int record1, object[] vals);
            /*0x3750da0*/ void DeleteRecordFromIndex(int recordIndex);
            /*0x3750928*/ void DeleteRecord(int recordIndex);
            /*0x3750da8*/ void DeleteRecord(int recordIndex, bool fireEvent);
            /*0x375109c*/ System.Data.RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex);
            /*0x3750930*/ int GetIndex(int record);
            /*0x37507a4*/ int GetIndex(int record, int changeRecord);
            /*0x37476b8*/ object[] GetUniqueKeyValues();
            /*0x37512f8*/ int FindNodeByKey(object originalKey);
            /*0x3751520*/ int FindNodeByKeys(object[] originalKey);
            /*0x3751768*/ int FindNodeByKeyRecord(int record);
            /*0x3751864*/ System.Data.Range GetRangeFromNode(int nodeId);
            /*0x375198c*/ System.Data.Range FindRecords(object key);
            /*0x37477fc*/ System.Data.Range FindRecords(object[] key);
            /*0x37519b0*/ void FireResetEvent();
            /*0x3751cbc*/ int GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x37481b4*/ System.Data.DataRow GetRow(int i);
            /*0x3751cf8*/ System.Data.DataRow[] GetRows(object[] values);
            /*0x3747820*/ System.Data.DataRow[] GetRows(System.Data.Range range);
            /*0x374f964*/ void InitRecords(System.Data.IFilter filter);
            /*0x3751d90*/ int InsertRecordToIndex(int record);
            /*0x3750598*/ int InsertRecord(int record, bool fireEvent);
            /*0x3751de0*/ bool IsKeyInIndex(object key);
            /*0x37477e4*/ bool IsKeyInIndex(object[] key);
            /*0x3751df8*/ bool IsKeyRecordInIndex(int record);
            /*0x3751aa0*/ bool get_DoListChanged();
            /*0x3751e10*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int newIndex, int oldIndex);
            /*0x375100c*/ void OnListChanged(System.ComponentModel.ListChangedType changedType, int index);
            /*0x3751b20*/ void OnListChanged(System.ComponentModel.ListChangedEventArgs e);
            /*0x3750ee0*/ void MaintainDataView(System.ComponentModel.ListChangedType changedType, int record, bool trackAddRemove);
            /*0x3751eb0*/ void Reset();
            /*0x3751f8c*/ void RecordChanged(int record);
            /*0x375206c*/ void RecordChanged(int oldIndex, int newIndex);
            /*0x3752198*/ void RecordStateChanged(int record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState);
            /*0x37522b0*/ void RecordStateChanged(int oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, int newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState);
            /*0x375261c*/ System.Data.DataTable get_Table();
            /*0x3751104*/ void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId);

            class IndexTree : System.Data.RBTree<int>
            {
                /*0x40*/ System.Data.Index _index;

                /*0x3751d28*/ IndexTree(System.Data.Index index);
                /*0x3752624*/ int CompareNode(int record1, int record2);
                /*0x3752638*/ int CompareSateliteTreeNode(int record1, int record2);
            }

            class <>c
            {
                static /*0x0*/ System.Data.Index.<> <>9;
                static /*0x8*/ System.Data.Listeners.Func<System.Data.DataViewListener, System.Data.DataViewListener, bool> <>9__22_0;
                static /*0x10*/ System.Data.Listeners.Action<System.Data.DataViewListener, System.Data.DataViewListener, System.ComponentModel.ListChangedEventArgs, bool, bool> <>9__85_0;

                static /*0x375264c*/ <>c();
                /*0x37526b4*/ <>c();
                /*0x37526bc*/ bool <.ctor>b__22_0(System.Data.DataViewListener listener);
                /*0x37526c8*/ void <OnListChanged>b__85_0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedEventArgs args, bool arg2, bool arg3);
            }

            class <>c__DisplayClass86_0
            {
                /*0x10*/ System.ComponentModel.ListChangedType changedType;

                /*0x3751ea8*/ <>c__DisplayClass86_0();
                /*0x37526e4*/ void <MaintainDataView>b__0(System.Data.DataViewListener listener, System.ComponentModel.ListChangedType type, System.Data.DataRow row, bool track);
            }
        }

        class Listeners<TElem>
        {
            /*0x0*/ System.Collections.Generic.List<TElem> _listeners;
            /*0x0*/ System.Data.Listeners.Func<TElem, TElem, bool> _filter;
            /*0x0*/ int _objectID;
            /*0x0*/ int _listenerReaderCount;

            /*0x1f30c88*/ Listeners(int ObjectID, System.Data.Listeners.Func<TElem, TElem, bool> notifyFilter);
            /*0x1f2fe14*/ bool get_HasListeners();
            /*0x1ffc854*/ void Add(TElem listener);
            /*0x1ffc854*/ int IndexOfReference(TElem listener);
            /*0x1ffc854*/ void Remove(TElem listener);
            /*0x1ffc854*/ void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem, TElem, T1, T2, T3> action);
            /*0x1f30b78*/ void RemoveNullListeners(int nullIndex);

            class Action`4<TElem, T1, T2, T3, T4> : System.MulticastDelegate
            {
                Action`4(object object, nint method);
                /*0x1ffc854*/ void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            }

            class Func`2<TElem, T1, TResult> : System.MulticastDelegate
            {
                Func`2(object object, nint method);
                /*0x1ffc854*/ TResult Invoke(T1 arg1);
            }
        }

        class SimpleType : System.Runtime.Serialization.ISerializable
        {
            /*0x10*/ string _baseType;
            /*0x18*/ System.Data.SimpleType _baseSimpleType;
            /*0x20*/ System.Xml.XmlQualifiedName _xmlBaseType;
            /*0x28*/ string _name;
            /*0x30*/ int _length;
            /*0x34*/ int _minLength;
            /*0x38*/ int _maxLength;
            /*0x40*/ string _pattern;
            /*0x48*/ string _ns;
            /*0x50*/ string _maxExclusive;
            /*0x58*/ string _maxInclusive;
            /*0x60*/ string _minExclusive;
            /*0x68*/ string _minInclusive;
            /*0x70*/ string _enumeration;

            static /*0x3753b4c*/ System.Data.SimpleType CreateEnumeratedType(string values);
            static /*0x3753bd8*/ System.Data.SimpleType CreateByteArrayType(string encoding);
            static /*0x3753c40*/ System.Data.SimpleType CreateLimitedStringType(int length);
            static /*0x3753cc0*/ System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type);
            /*0x375270c*/ SimpleType(string baseType);
            /*0x3752814*/ SimpleType(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x37532cc*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x37529e0*/ void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node);
            /*0x3753420*/ bool IsPlainString();
            /*0x37535cc*/ string get_BaseType();
            /*0x37535d4*/ System.Xml.XmlQualifiedName get_XmlBaseType();
            /*0x37535dc*/ string get_Name();
            /*0x37535e4*/ string get_Namespace();
            /*0x37535ec*/ int get_Length();
            /*0x37535f4*/ int get_MaxLength();
            /*0x37535fc*/ void set_MaxLength(int value);
            /*0x3753604*/ System.Data.SimpleType get_BaseSimpleType();
            /*0x375360c*/ string get_SimpleTypeQualifiedName();
            /*0x375367c*/ string QualifiedName(string name);
            /*0x37536f8*/ System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, bool inRemoting);
            /*0x3753d90*/ string HasConflictingDefinition(System.Data.SimpleType otherSimpleType);
            /*0x3753e84*/ bool CanHaveMaxLength();
            /*0x3753ee8*/ void ConvertToAnnonymousSimpleType();
        }

        class UniqueConstraint : System.Data.Constraint
        {
            /*0x38*/ System.Data.DataKey _key;
            /*0x40*/ System.Data.Index _constraintIndex;
            /*0x48*/ bool _bPrimaryKey;
            /*0x50*/ string _constraintName;
            /*0x58*/ string[] _columnNames;

            /*0x3753f68*/ UniqueConstraint(System.Data.DataColumn column);
            /*0x3754118*/ UniqueConstraint(string name, System.Data.DataColumn[] columns);
            /*0x375414c*/ UniqueConstraint(System.Data.DataColumn[] columns);
            /*0x375417c*/ UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey);
            /*0x37541d4*/ UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey);
            /*0x3754218*/ string[] get_ColumnNames();
            /*0x3754224*/ System.Data.Index get_ConstraintIndex();
            /*0x375422c*/ void ConstraintIndexClear();
            /*0x375425c*/ void ConstraintIndexInitialize();
            /*0x37542b4*/ void CheckState();
            /*0x37542c0*/ void NonVirtualCheckState();
            /*0x37542cc*/ void CheckCanAddToCollection(System.Data.ConstraintCollection constraints);
            /*0x37542d0*/ bool CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, bool fThrowException);
            /*0x375443c*/ bool CanEnableConstraint();
            /*0x3754488*/ bool IsConstraintViolated();
            /*0x37546e0*/ void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action);
            /*0x37547e0*/ bool ContainsColumn(System.Data.DataColumn column);
            /*0x37547ec*/ System.Data.Constraint Clone(System.Data.DataSet destination);
            /*0x37547fc*/ System.Data.Constraint Clone(System.Data.DataSet destination, bool ignorNSforTableLookup);
            /*0x3754d38*/ System.Data.UniqueConstraint Clone(System.Data.DataTable table);
            /*0x37551c4*/ System.Data.DataColumn[] get_Columns();
            /*0x37547d8*/ System.Data.DataColumn[] get_ColumnsReference();
            /*0x37551d0*/ bool get_IsPrimaryKey();
            /*0x3754024*/ void Create(string constraintName, System.Data.DataColumn[] columns);
            /*0x3755214*/ bool Equals(object key2);
            /*0x37552b8*/ int GetHashCode();
            /*0x37552c0*/ void set_InCollection(bool value);
            /*0x375530c*/ System.Data.DataKey get_Key();
            /*0x3755314*/ System.Data.DataTable get_Table();
        }

        class XDRSchema : System.Data.XMLSchema
        {
            static /*0x0*/ char[] s_colonArray;
            static /*0x8*/ System.Data.XDRSchema.NameType[] s_mapNameTypeXdr;
            static /*0x10*/ System.Data.XDRSchema.NameType s_enumerationNameType;
            /*0x10*/ string _schemaName;
            /*0x18*/ string _schemaUri;
            /*0x20*/ System.Xml.XmlElement _schemaRoot;
            /*0x28*/ System.Data.DataSet _ds;

            static /*0x3757e40*/ XDRSchema();
            static /*0x3756750*/ System.Data.XDRSchema.NameType FindNameType(string name);
            /*0x3755348*/ XDRSchema(System.Data.DataSet ds, bool fInline);
            /*0x37553c8*/ void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds);
            /*0x375585c*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node);
            /*0x3755b74*/ bool IsTextOnlyContent(System.Xml.XmlElement node);
            /*0x3755d44*/ bool IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x375569c*/ System.Data.DataTable HandleTable(System.Xml.XmlElement node);
            /*0x3756824*/ System.Type ParseDataType(string dt, string dtValues);
            /*0x3756970*/ string GetInstanceName(System.Xml.XmlElement node);
            /*0x3756ae8*/ void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table);
            /*0x3755ea4*/ void GetMinMax(System.Xml.XmlElement elNode, ref int minOccurs, ref int maxOccurs);
            /*0x375746c*/ void GetMinMax(System.Xml.XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs);
            /*0x3757c58*/ void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren);
            /*0x37560e4*/ System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode);
            /*0x3755eb4*/ System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x3758d94*/ NameType(string n, System.Type t);
                /*0x3758dd8*/ int CompareTo(object obj);
            }
        }

        class XMLDiffLoader
        {
            /*0x10*/ System.Collections.ArrayList _tables;
            /*0x18*/ System.Data.DataSet _dataSet;
            /*0x20*/ System.Data.DataTable _dataTable;

            /*0x375b378*/ XMLDiffLoader();
            /*0x3758e14*/ void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader);
            /*0x3759658*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x37599a4*/ void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader);
            /*0x3758fc8*/ void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x3759bb4*/ void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync);
            /*0x37592b8*/ void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync);
            /*0x3759e98*/ void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync);
            /*0x375b1ac*/ System.Data.DataTable GetTable(string tableName, string ns);
            /*0x375a3a8*/ int ReadOldRowData(System.Data.DataSet ds, ref System.Data.DataTable table, ref int pos, System.Xml.XmlReader row);
            /*0x375a348*/ void SkipWhitespaces(System.Xml.XmlReader reader);
        }

        class XMLSchema
        {
            static /*0x375b380*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x3757840*/ void SetProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x3755628*/ bool FEqualIdentity(System.Xml.XmlNode node, string name, string ns);
            static /*0x375b3d8*/ bool GetBooleanAttribute(System.Xml.XmlElement element, string attrName, string attrNS, bool defVal);
            static /*0x3757344*/ string GenUniqueColumnName(string proposedName, System.Data.DataTable table);
            /*0x37553c0*/ XMLSchema();
        }

        class ConstraintTable
        {
            /*0x10*/ System.Data.DataTable table;
            /*0x18*/ System.Xml.Schema.XmlSchemaIdentityConstraint constraint;

            /*0x375b528*/ ConstraintTable(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c);
        }

        class XSDSchema : System.Data.XMLSchema
        {
            static /*0x0*/ System.Data.XSDSchema.NameType[] s_mapNameTypeXsd;
            /*0x10*/ System.Xml.Schema.XmlSchemaSet _schemaSet;
            /*0x18*/ System.Xml.Schema.XmlSchemaElement _dsElement;
            /*0x20*/ System.Data.DataSet _ds;
            /*0x28*/ string _schemaName;
            /*0x30*/ System.Collections.ArrayList _columnExpressions;
            /*0x38*/ System.Collections.Hashtable _constraintNodes;
            /*0x40*/ System.Collections.ArrayList _refTables;
            /*0x48*/ System.Collections.ArrayList _complexTypes;
            /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection _annotations;
            /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection _elements;
            /*0x60*/ System.Collections.Hashtable _attributes;
            /*0x68*/ System.Collections.Hashtable _elementsTable;
            /*0x70*/ System.Collections.Hashtable _attributeGroups;
            /*0x78*/ System.Collections.Hashtable _schemaTypes;
            /*0x80*/ System.Collections.Hashtable _expressions;
            /*0x88*/ System.Collections.Generic.Dictionary<System.Data.DataTable, System.Collections.Generic.List<System.Data.DataTable>> _tableDictionary;
            /*0x90*/ System.Collections.Hashtable _udSimpleTypes;
            /*0x98*/ System.Collections.Hashtable _existingSimpleTypeMap;
            /*0xa0*/ bool _fromInference;

            static /*0x3769a44*/ XSDSchema();
            static /*0x3753550*/ string QualifiedName(string name);
            static /*0x375bf10*/ void SetProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x375c438*/ void SetExtProperties(object instance, System.Xml.XmlAttribute[] attrs);
            static /*0x3753304*/ string GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, string ln);
            static /*0x375c9cc*/ void SetExtProperties(object instance, System.Xml.XmlAttributeCollection attrs);
            static /*0x37662a4*/ System.Data.AcceptRejectRule TranslateAcceptRejectRule(string strRule);
            static /*0x3766328*/ System.Data.Rule TranslateRule(string strRule);
            static /*0x3769098*/ System.Type XsdtoClr(string xsdTypeName);
            static /*0x3769174*/ System.Data.XSDSchema.NameType FindNameType(string name);
            static /*0x37693ac*/ bool IsXsdType(string name);
            /*0x3769a3c*/ XSDSchema();
            /*0x375b56c*/ bool get_FromInference();
            /*0x375b574*/ void set_FromInference(bool value);
            /*0x375b57c*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema);
            /*0x375b604*/ void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList);
            /*0x375c7c8*/ void HandleColumnExpression(object instance, System.Xml.XmlAttribute[] attrs);
            /*0x375cc10*/ void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element);
            /*0x375cdcc*/ void HandleRelation(System.Xml.XmlElement node, bool fNested);
            /*0x375d5f4*/ bool HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
            /*0x375d834*/ bool IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x375e1e4*/ int DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x375e54c*/ System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements);
            /*0x375eb00*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt);
            /*0x375eb1c*/ void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds);
            /*0x3761f4c*/ void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, bool fNested);
            /*0x375dd58*/ System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt);
            /*0x3762230*/ void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isBase);
            /*0x3763760*/ void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, bool isBase);
            /*0x37643f4*/ void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, bool isBase);
            /*0x3764778*/ void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, bool isNillable);
            /*0x375e9e0*/ System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct);
            /*0x3765e80*/ System.Data.DataColumn FindField(System.Data.DataTable table, string field);
            /*0x3765ffc*/ System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table);
            /*0x375e3f4*/ bool GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, bool defVal);
            /*0x3760958*/ string GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, string attrName, string defVal);
            /*0x3766414*/ void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref);
            /*0x3766c94*/ void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode);
            /*0x37670c4*/ System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x375ccf4*/ string GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x3767b7c*/ System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, bool isRef);
            /*0x3769248*/ System.Type ParseDataType(string dt);
            /*0x37609d8*/ System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node);
            /*0x37654e4*/ void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x3764d64*/ void HandleSimpleContentColumn(string strType, System.Data.DataTable table, bool isBase, System.Xml.XmlAttribute[] attrs, bool isNillable);
            /*0x3763a1c*/ void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, bool isBase);
            /*0x3762b2c*/ void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, bool isBase);
            /*0x3760e34*/ void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, bool isNewDataSet);
            /*0x376941c*/ void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt);
            /*0x3767798*/ string GetPrefix(string ns);
            /*0x3769650*/ string GetNamespaceFromPrefix(string prefix);
            /*0x3768f14*/ string GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x3766b7c*/ string GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key);
            /*0x375df78*/ bool IsTable(System.Xml.Schema.XmlSchemaElement node);
            /*0x3760cbc*/ System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node);

            class NameType : System.IComparable
            {
                /*0x10*/ string name;
                /*0x18*/ System.Type type;

                /*0x376acdc*/ NameType(string n, System.Type t);
                /*0x376ad20*/ int CompareTo(object obj);
            }
        }

        class XmlIgnoreNamespaceReader : System.Xml.XmlNodeReader
        {
            /*0x30*/ System.Collections.Generic.List<string> _namespacesToIgnore;

            /*0x376ad5c*/ XmlIgnoreNamespaceReader(System.Xml.XmlDocument xdoc, string[] namespacesToIgnore);
            /*0x376adfc*/ bool MoveToFirstAttribute();
            /*0x376af0c*/ bool MoveToNextAttribute();
        }

        class XmlDataLoader
        {
            /*0x10*/ System.Data.DataSet _dataSet;
            /*0x18*/ System.Data.XmlToDatasetMap _nodeToSchemaMap;
            /*0x20*/ System.Collections.Hashtable _nodeToRowMap;
            /*0x28*/ System.Collections.Stack _childRowsStack;
            /*0x30*/ System.Collections.Hashtable _htableExcludedNS;
            /*0x38*/ bool _fIsXdr;
            /*0x39*/ bool _isDiffgram;
            /*0x40*/ System.Xml.XmlElement _topMostNode;
            /*0x48*/ bool _ignoreSchema;
            /*0x50*/ System.Data.DataTable _dataTable;
            /*0x58*/ bool _isTableLevel;
            /*0x59*/ bool _fromInference;
            /*0x60*/ System.Xml.XmlReader _dataReader;
            /*0x68*/ object _XSD_XMLNS_NS;
            /*0x70*/ object _XDR_SCHEMA;
            /*0x78*/ object _XDRNS;
            /*0x80*/ object _SQL_SYNC;
            /*0x88*/ object _UPDGNS;
            /*0x90*/ object _XSD_SCHEMA;
            /*0x98*/ object _XSDNS;
            /*0xa0*/ object _DFFNS;
            /*0xa8*/ object _MSDNS;
            /*0xb0*/ object _DIFFID;
            /*0xb8*/ object _HASCHANGES;
            /*0xc0*/ object _ROWORDER;

            /*0x376b018*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, bool ignoreSchema);
            /*0x376b0c4*/ XmlDataLoader(System.Data.DataSet dataset, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x376b1c8*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, bool ignoreSchema);
            /*0x376b28c*/ XmlDataLoader(System.Data.DataTable datatable, bool IsXdr, System.Xml.XmlElement topNode, bool ignoreSchema);
            /*0x376b3a8*/ bool get_FromInference();
            /*0x376b3b0*/ void set_FromInference(bool value);
            /*0x376b3b8*/ void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x376b5ac*/ int CountNonNSAttributes(System.Xml.XmlNode node);
            /*0x376b72c*/ string GetValueForTextOnlyColums(System.Xml.XmlNode n);
            /*0x376b944*/ string GetInitialTextFromNodes(ref System.Xml.XmlNode n);
            /*0x376bb40*/ System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row);
            /*0x376b514*/ System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e);
            /*0x376bc04*/ bool FColumnElement(System.Xml.XmlElement e);
            /*0x376b6a0*/ bool FExcludedNamespace(string ns);
            /*0x376bcec*/ bool FIgnoreNamespace(System.Xml.XmlNode node);
            /*0x376bfac*/ bool FIgnoreNamespace(System.Xml.XmlReader node);
            /*0x376b8f0*/ bool IsTextLikeNode(System.Xml.XmlNodeType n);
            /*0x376bbd4*/ bool IsTextOnly(System.Data.DataColumn c);
            /*0x376c034*/ void LoadData(System.Xml.XmlDocument xdoc);
            /*0x376c47c*/ void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement);
            /*0x376d058*/ void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement);
            /*0x376d394*/ void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, string xmlText);
            /*0x376d404*/ void InitNameTable();
            /*0x376d70c*/ void LoadData(System.Xml.XmlReader reader);
            /*0x376daec*/ void LoadTopMostTable(System.Data.DataTable table);
            /*0x376e718*/ void LoadTable(System.Data.DataTable table, bool isNested);
            /*0x376f560*/ void LoadColumn(System.Data.DataColumn column, object[] foundColumns);
            /*0x376e4f8*/ bool ProcessXsdSchema();
        }

        enum XmlReadMode
        {
            Auto = 0,
            ReadSchema = 1,
            IgnoreSchema = 2,
            InferSchema = 3,
            DiffGram = 4,
            Fragment = 5,
            InferTypedSchema = 6,
        }

        class XmlToDatasetMap
        {
            /*0x10*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap;
            /*0x18*/ System.Data.XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo;

            static /*0x376d3dc*/ bool IsMappedColumn(System.Data.DataColumn c);
            /*0x376c360*/ XmlToDatasetMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x376da84*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x376c32c*/ XmlToDatasetMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x376dab8*/ XmlToDatasetMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x3771bf4*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable);
            /*0x3771dfc*/ System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table);
            /*0x3771f84*/ bool AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x3772210*/ bool AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);
            /*0x376fe7c*/ void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable);
            /*0x3770430*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet);
            /*0x3770e98*/ void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable);
            /*0x37711cc*/ void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable);
            /*0x3772468*/ System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt);
            /*0x376bdcc*/ object GetColumnSchema(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x376f424*/ object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, bool fIgnoreNamespace);
            /*0x376c394*/ object GetSchemaForNode(System.Xml.XmlNode node, bool fIgnoreNamespace);
            /*0x376e420*/ System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, bool fIgnoreNamespace);
            /*0x37720b4*/ void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns);

            class XmlNodeIdentety
            {
                /*0x10*/ string LocalName;
                /*0x18*/ string NamespaceURI;

                /*0x3771db8*/ XmlNodeIdentety(string localName, string namespaceURI);
                /*0x3772a84*/ int GetHashCode();
                /*0x3772aa0*/ bool Equals(object obj);
            }

            class XmlNodeIdHashtable : System.Collections.Hashtable
            {
                /*0x50*/ System.Data.XmlToDatasetMap.XmlNodeIdentety _id;

                /*0x37723d4*/ XmlNodeIdHashtable(int capacity);
                /*0x3772890*/ object get_Item(System.Xml.XmlNode node);
                /*0x37729fc*/ object get_Item(System.Xml.XmlReader dataReader);
                /*0x377297c*/ object get_Item(System.Data.DataTable table);
                /*0x3772920*/ object get_Item(string name);
            }

            class TableSchemaInfo
            {
                /*0x10*/ System.Data.DataTable TableSchema;
                /*0x18*/ System.Data.XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;

                /*0x3771d14*/ TableSchemaInfo(System.Data.DataTable tableSchema);
            }
        }

        enum XmlWriteMode
        {
            WriteSchema = 0,
            IgnoreSchema = 1,
            DiffGram = 2,
        }

        enum SchemaFormat
        {
            Public = 1,
            Remoting = 2,
            WebService = 3,
            RemotingSkipSchema = 4,
            WebServiceSkipSchema = 5,
        }

        class XmlTreeGen
        {
            /*0x10*/ System.Collections.ArrayList _constraintNames;
            /*0x18*/ System.Collections.Hashtable _namespaces;
            /*0x20*/ System.Collections.Hashtable _autogenerated;
            /*0x28*/ System.Collections.Hashtable _prefixes;
            /*0x30*/ System.Data.DataSet _ds;
            /*0x38*/ System.Collections.ArrayList _tables;
            /*0x40*/ System.Collections.ArrayList _relations;
            /*0x48*/ System.Xml.XmlDocument _dc;
            /*0x50*/ System.Xml.XmlElement _sRoot;
            /*0x58*/ int _prefixCount;
            /*0x5c*/ System.Data.SchemaFormat _schFormat;
            /*0x60*/ string _filePath;
            /*0x68*/ string _fileName;
            /*0x70*/ string _fileExt;
            /*0x78*/ System.Xml.XmlElement _dsElement;
            /*0x80*/ System.Xml.XmlElement _constraintSeparator;
            /*0x88*/ System.Converter<System.Type, string> _targetConverter;

            static /*0x3772be8*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node);
            static /*0x3772bf0*/ void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type);
            static /*0x3773d0c*/ string XmlDataTypeName(System.Type type);
            static /*0x3775354*/ bool _PropsNotEmpty(System.Data.PropertyCollection props);
            static /*0x3775764*/ void ValidateColumnMapping(System.Type columnType);
            static /*0x377dd3c*/ System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, string name);
            static /*0x377f870*/ string TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule);
            static /*0x377f8e0*/ string TranslateRule(System.Data.Rule rule);
            static /*0x3776558*/ bool AutoGenerated(System.Data.DataColumn col);
            static /*0x377fd04*/ bool AutoGenerated(System.Data.DataRelation rel);
            static /*0x3776a60*/ bool AutoGenerated(System.Data.UniqueConstraint unique);
            static /*0x377fde8*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk, bool checkRelation);
            /*0x3772b3c*/ XmlTreeGen(System.Data.SchemaFormat format);
            /*0x37732c8*/ void AddXdoProperties(object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x3773478*/ void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd);
            /*0x3774aec*/ void GenerateConstraintNames(System.Data.DataTable table, bool fromTable);
            /*0x3774fb0*/ void GenerateConstraintNames(System.Collections.ArrayList tables);
            /*0x37750a8*/ void GenerateConstraintNames(System.Data.DataSet ds);
            /*0x377537c*/ bool HaveExtendedProperties(System.Data.DataSet ds);
            /*0x3775500*/ void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, string targetNamespace);
            /*0x37757ec*/ void SetupAutoGenerated(System.Data.DataSet ds);
            /*0x3776464*/ void SetupAutoGenerated(System.Collections.ArrayList dt);
            /*0x3775a94*/ void SetupAutoGenerated(System.Data.DataTable dt);
            /*0x3776b34*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x3776e80*/ void CreateRelations(System.Data.DataTable dt);
            /*0x37771a8*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x3777498*/ void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, bool writeHierarchy);
            /*0x377aae0*/ System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt);
            /*0x3779e3c*/ System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt);
            /*0x377d8bc*/ void SetPath(System.Xml.XmlWriter xw);
            /*0x377daf4*/ void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw);
            /*0x377db14*/ void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x377db08*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw);
            /*0x377dbd4*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy);
            /*0x377dbdc*/ void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, bool writeHierarchy, System.Converter<System.Type, string> multipleTargetConverter);
            /*0x377a51c*/ System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc);
            /*0x377de30*/ System.Xml.XmlElement GetSchema(string NamespaceURI);
            /*0x377e0c4*/ void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema);
            /*0x377e514*/ void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root);
            /*0x377eb00*/ string FindTargetNamespace(System.Data.DataTable table);
            /*0x377ec10*/ System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool fWriteOrdinal);
            /*0x377a464*/ void AppendChildWithoutRef(System.Xml.XmlElement node, string Namespace, System.Xml.XmlElement el, string refString);
            /*0x377f6a8*/ System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, string strType);
            /*0x377a45c*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema);
            /*0x377f994*/ bool HasMixedColumns(System.Data.DataTable table);
            /*0x3776a54*/ bool AutoGenerated(System.Data.ForeignKeyConstraint fk);
            /*0x377ff28*/ bool IsAutoGenerated(object o);
            /*0x377afac*/ System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, bool genNested);
            /*0x37748b0*/ void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type);
        }

        class NewDiffgramGen
        {
            /*0x10*/ System.Xml.XmlDocument _doc;
            /*0x18*/ System.Data.DataSet _ds;
            /*0x20*/ System.Data.DataTable _dt;
            /*0x28*/ System.Xml.XmlWriter _xmlw;
            /*0x30*/ bool _fBefore;
            /*0x31*/ bool _fErrors;
            /*0x38*/ System.Collections.Hashtable _rowsOrder;
            /*0x40*/ System.Collections.ArrayList _tables;
            /*0x48*/ bool _writeHierarchy;

            static /*0x377ff6c*/ string QualifiedName(string prefix, string name);
            /*0x377ffd4*/ NewDiffgramGen(System.Data.DataSet ds);
            /*0x3780380*/ NewDiffgramGen(System.Data.DataTable dt, bool writeHierarchy);
            /*0x37804a4*/ void CreateTableHierarchy(System.Data.DataTable dt);
            /*0x378011c*/ void DoAssignments(System.Collections.ArrayList tables);
            /*0x37807f0*/ bool EmptyData();
            /*0x37808e4*/ void Save(System.Xml.XmlWriter xmlw);
            /*0x37808ec*/ void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table);
            /*0x3780cf8*/ void GenerateTable(System.Data.DataTable table);
            /*0x3780d74*/ void GenerateTableErrors(System.Data.DataTable table);
            /*0x37812dc*/ void GenerateRow(System.Data.DataRow row);
            /*0x3781870*/ void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version);
        }

        class XmlDataTreeWriter
        {
            /*0x10*/ System.Xml.XmlWriter _xmlw;
            /*0x18*/ System.Data.DataSet _ds;
            /*0x20*/ System.Data.DataTable _dt;
            /*0x28*/ System.Collections.ArrayList _dTables;
            /*0x30*/ System.Data.DataTable[] _topLevelTables;
            /*0x38*/ bool _fFromTable;
            /*0x39*/ bool _isDiffgram;
            /*0x40*/ System.Collections.Hashtable _rowsOrder;
            /*0x48*/ bool _writeHierarchy;

            static /*0x3782d2c*/ bool RowHasErrors(System.Data.DataRow row);
            static /*0x378585c*/ bool PreserveSpace(object value);
            /*0x3782224*/ XmlDataTreeWriter(System.Data.DataSet ds);
            /*0x3782558*/ XmlDataTreeWriter(System.Data.DataTable dt, bool writeHierarchy);
            /*0x3782a3c*/ System.Data.DataTable[] CreateToplevelTables();
            /*0x37826f0*/ void CreateTablesHierarchy(System.Data.DataTable dt);
            /*0x3782df4*/ void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder);
            /*0x3784cc0*/ void Save(System.Xml.XmlWriter xw, bool writeSchema);
            /*0x3785548*/ System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row);
            /*0x37834f0*/ void XmlDataRowWriter(System.Data.DataRow row, string encodedTableName);
        }

        class DataTextWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter _xmltextWriter;

            static /*0x3783488*/ System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw);
            /*0x37858f0*/ DataTextWriter(System.Xml.XmlWriter w);
            /*0x3785920*/ System.IO.Stream get_BaseStream();
            /*0x37859a8*/ void WriteStartDocument();
            /*0x37859c4*/ void WriteStartDocument(bool standalone);
            /*0x37859e4*/ void WriteEndDocument();
            /*0x3785a00*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x3785a1c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x3785a38*/ void WriteEndElement();
            /*0x3785a54*/ void WriteFullEndElement();
            /*0x3785a70*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x3785a8c*/ void WriteEndAttribute();
            /*0x3785aac*/ void WriteCData(string text);
            /*0x3785acc*/ void WriteComment(string text);
            /*0x3785aec*/ void WriteProcessingInstruction(string name, string text);
            /*0x3785b0c*/ void WriteEntityRef(string name);
            /*0x3785b2c*/ void WriteCharEntity(char ch);
            /*0x3785b4c*/ void WriteWhitespace(string ws);
            /*0x3785b6c*/ void WriteString(string text);
            /*0x3785b8c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x3785bac*/ void WriteChars(char[] buffer, int index, int count);
            /*0x3785bcc*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x3785bec*/ void WriteRaw(string data);
            /*0x3785c0c*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x3785c2c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x3785c4c*/ System.Xml.WriteState get_WriteState();
            /*0x3785c6c*/ void Close();
            /*0x3785c8c*/ void Flush();
            /*0x3785cac*/ string LookupPrefix(string ns);
        }

        class DataTextReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader _xmlreader;

            static /*0x3785ccc*/ System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr);
            /*0x3785d24*/ DataTextReader(System.Xml.XmlReader input);
            /*0x3785d98*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x3785db4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3785dd0*/ string get_Name();
            /*0x3785dec*/ string get_LocalName();
            /*0x3785e08*/ string get_NamespaceURI();
            /*0x3785e24*/ string get_Prefix();
            /*0x3785e40*/ string get_Value();
            /*0x3785e5c*/ int get_Depth();
            /*0x3785e78*/ string get_BaseURI();
            /*0x3785e98*/ bool get_IsEmptyElement();
            /*0x3785eb8*/ bool get_IsDefault();
            /*0x3785ed8*/ char get_QuoteChar();
            /*0x3785ef8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x3785f18*/ string get_XmlLang();
            /*0x3785f38*/ int get_AttributeCount();
            /*0x3785f58*/ string GetAttribute(string name);
            /*0x3785f78*/ string GetAttribute(string localName, string namespaceURI);
            /*0x3785f98*/ string GetAttribute(int i);
            /*0x3785fb8*/ bool MoveToAttribute(string name);
            /*0x3785fd8*/ void MoveToAttribute(int i);
            /*0x3785ff8*/ bool MoveToFirstAttribute();
            /*0x3786018*/ bool MoveToNextAttribute();
            /*0x3786038*/ bool MoveToElement();
            /*0x3786058*/ bool ReadAttributeValue();
            /*0x3786078*/ bool Read();
            /*0x3786098*/ bool get_EOF();
            /*0x37860b8*/ void Close();
            /*0x37860d8*/ System.Xml.ReadState get_ReadState();
            /*0x37860f8*/ void Skip();
            /*0x3786118*/ System.Xml.XmlNameTable get_NameTable();
            /*0x3786138*/ string LookupNamespace(string prefix);
            /*0x3786158*/ bool get_CanResolveEntity();
            /*0x3786178*/ void ResolveEntity();
            /*0x3786198*/ bool get_CanReadValueChunk();
            /*0x37861b8*/ string ReadString();
        }

        namespace SqlTypes
        {
            class SQLResource
            {
                static /*0x37861d8*/ string get_NullString();
                static /*0x3786218*/ string get_ArithOverflowMessage();
                static /*0x3786258*/ string get_DivideByZeroMessage();
                static /*0x3786298*/ string get_NullValueMessage();
                static /*0x37862d8*/ string get_TruncationMessage();
                static /*0x3786318*/ string get_DateTimeOverflowMessage();
                static /*0x3786358*/ string get_ConcatDiffCollationMessage();
                static /*0x3786398*/ string get_CompareDiffCollationMessage();
                static /*0x37863d8*/ string get_ConversionOverflowMessage();
                static /*0x3786418*/ string get_TimeZoneSpecifiedMessage();
                static /*0x3786458*/ string get_InvalidPrecScaleMessage();
                static /*0x3786498*/ string get_FormatMessage();
                static /*0x37864d8*/ string InvalidOpStreamClosed(string method);
                static /*0x3786524*/ string InvalidOpStreamNonWritable(string method);
                static /*0x3786570*/ string InvalidOpStreamNonReadable(string method);
                static /*0x37865bc*/ string InvalidOpStreamNonSeekable(string method);
            }

            interface INullable
            {
                /*0x1f2fe14*/ bool get_IsNull();
            }

            struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBinary Null;
                /*0x10*/ byte[] _value;

                static /*0x378758c*/ SqlBinary();
                static /*0x3786784*/ System.Data.SqlTypes.SqlBinary op_Implicit(byte[] x);
                static /*0x37868b8*/ System.Data.SqlTypes.EComparison PerformCompareByte(byte[] x, byte[] y);
                static /*0x37869c4*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x3786ad4*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x3786bd0*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y);
                static /*0x37870f4*/ int HashByteArray(byte[] rgbValue, int length);
                static /*0x3787500*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3786608*/ SqlBinary(bool fNull);
                /*0x3786614*/ SqlBinary(byte[] value);
                /*0x37866a0*/ bool get_IsNull();
                /*0x37866b0*/ byte[] get_Value();
                /*0x37867a0*/ string ToString();
                /*0x3786ccc*/ int CompareTo(object value);
                /*0x3786dd4*/ int CompareTo(System.Data.SqlTypes.SqlBinary value);
                /*0x3786f6c*/ bool Equals(object value);
                /*0x3787154*/ int GetHashCode();
                /*0x378721c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3787224*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x37873d4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlBoolean True;
                static /*0x1*/ System.Data.SqlTypes.SqlBoolean False;
                static /*0x2*/ System.Data.SqlTypes.SqlBoolean Null;
                static /*0x3*/ System.Data.SqlTypes.SqlBoolean Zero;
                static /*0x4*/ System.Data.SqlTypes.SqlBoolean One;
                /*0x10*/ byte m_value;

                static /*0x37881c0*/ SqlBoolean();
                static /*0x37876b0*/ System.Data.SqlTypes.SqlBoolean op_Implicit(bool x);
                static /*0x3786f10*/ bool op_True(System.Data.SqlTypes.SqlBoolean x);
                static /*0x37876c0*/ System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x3787780*/ System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x37879b0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x3787a60*/ System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x3787ac4*/ System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y);
                static /*0x3788134*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3786ac0*/ SqlBoolean(bool value);
                /*0x37875f8*/ SqlBoolean(int value);
                /*0x3787664*/ SqlBoolean(int value, bool fNull);
                /*0x3787680*/ bool get_IsNull();
                /*0x37870a0*/ bool get_Value();
                /*0x3787690*/ bool get_IsTrue();
                /*0x37876a0*/ bool get_IsFalse();
                /*0x3787840*/ byte get_ByteValue();
                /*0x37878d4*/ string ToString();
                /*0x3787b28*/ int CompareTo(object value);
                /*0x3787c30*/ int CompareTo(System.Data.SqlTypes.SqlBoolean value);
                /*0x3787d30*/ bool Equals(object value);
                /*0x3787e3c*/ int GetHashCode();
                /*0x3787ef0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3787ef8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x378801c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlByte : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_iBitNotByteMax;
                static /*0x4*/ System.Data.SqlTypes.SqlByte Null;
                static /*0x6*/ System.Data.SqlTypes.SqlByte Zero;
                static /*0x8*/ System.Data.SqlTypes.SqlByte MinValue;
                static /*0xa*/ System.Data.SqlTypes.SqlByte MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x11*/ byte m_value;

                static /*0x37895a8*/ SqlByte();
                static /*0x37882d8*/ System.Data.SqlTypes.SqlByte op_Implicit(byte x);
                static /*0x3788380*/ System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x3788498*/ System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x37885ac*/ System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x37886c4*/ System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x37887c0*/ System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x3788964*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x3788a28*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x3788aec*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x3788bb0*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x3788c14*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y);
                static /*0x378951c*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3788268*/ SqlByte(bool fNull);
                /*0x3788270*/ SqlByte(byte value);
                /*0x3788280*/ bool get_IsNull();
                /*0x3788290*/ byte get_Value();
                /*0x37882e4*/ string ToString();
                /*0x3788c78*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x3788d9c*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x3788eb0*/ int CompareTo(object value);
                /*0x3788fb8*/ int CompareTo(System.Data.SqlTypes.SqlByte value);
                /*0x37890f8*/ bool Equals(object value);
                /*0x3789230*/ int GetHashCode();
                /*0x37892c4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x37892cc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x37893ec*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            enum SqlBytesCharsState
            {
                Null = 0,
                Buffer = 1,
                Stream = 3,
            }

            class SqlBytes : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ byte[] _rgbBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.IO.Stream _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ byte[] _rgbWorkBuf;

                static /*0x3789f00*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x3789fc4*/ System.Data.SqlTypes.SqlBytes get_Null();
                /*0x3789620*/ SqlBytes();
                /*0x3789680*/ SqlBytes(byte[] buffer);
                /*0x37896f8*/ SqlBytes(System.Data.SqlTypes.SqlBinary value);
                /*0x3789788*/ bool get_IsNull();
                /*0x3789798*/ byte[] get_Buffer();
                /*0x3789944*/ long get_Length();
                /*0x37899b4*/ byte[] get_Value();
                /*0x3789654*/ void SetNull();
                /*0x37897d0*/ void CopyStreamToBuffer();
                /*0x37897c0*/ bool FStream();
                /*0x3789b98*/ void SetBuffer(byte[] buffer);
                /*0x3789bf8*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3789c00*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x3789dcc*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x3789f8c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class SqlChars : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable, System.Runtime.Serialization.ISerializable
            {
                /*0x10*/ char[] _rgchBuf;
                /*0x18*/ long _lCurLen;
                /*0x20*/ System.Data.SqlTypes.SqlStreamChars _stream;
                /*0x28*/ System.Data.SqlTypes.SqlBytesCharsState _state;
                /*0x30*/ char[] _rgchWorkBuf;

                static /*0x378a818*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x378a8dc*/ System.Data.SqlTypes.SqlChars get_Null();
                /*0x378a018*/ SqlChars();
                /*0x378a078*/ SqlChars(char[] buffer);
                /*0x378a0f0*/ SqlChars(System.Data.SqlTypes.SqlString value);
                /*0x378a194*/ bool get_IsNull();
                /*0x378a1a4*/ char[] get_Buffer();
                /*0x378a348*/ long get_Length();
                /*0x378a3b8*/ char[] get_Value();
                /*0x378a04c*/ void SetNull();
                /*0x378a1cc*/ bool FStream();
                /*0x378a1dc*/ void CopyStreamToBuffer();
                /*0x378a594*/ void SetBuffer(char[] buffer);
                /*0x378a5f4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x378a5fc*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x378a718*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
                /*0x378a8a4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            struct SqlDateTime : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ double s_SQLTicksPerMillisecond;
                static /*0x8*/ int SQLTicksPerSecond;
                static /*0xc*/ int SQLTicksPerMinute;
                static /*0x10*/ int SQLTicksPerHour;
                static /*0x14*/ int s_SQLTicksPerDay;
                static /*0x18*/ long s_ticksPerSecond;
                static /*0x20*/ System.DateTime s_SQLBaseDate;
                static /*0x28*/ long s_SQLBaseDateTicks;
                static /*0x30*/ int s_minYear;
                static /*0x34*/ int s_maxYear;
                static /*0x38*/ int s_minDay;
                static /*0x3c*/ int s_maxDay;
                static /*0x40*/ int s_minTime;
                static /*0x44*/ int s_maxTime;
                static /*0x48*/ int s_dayBase;
                static /*0x50*/ int[] s_daysToMonth365;
                static /*0x58*/ int[] s_daysToMonth366;
                static /*0x60*/ System.DateTime s_minDateTime;
                static /*0x68*/ System.DateTime s_maxDateTime;
                static /*0x70*/ System.TimeSpan s_minTimeSpan;
                static /*0x78*/ System.TimeSpan s_maxTimeSpan;
                static /*0x80*/ string s_ISO8601_DateTimeFormat;
                static /*0x88*/ string[] s_dateTimeFormats;
                static /*0x90*/ System.Data.SqlTypes.SqlDateTime MinValue;
                static /*0x9c*/ System.Data.SqlTypes.SqlDateTime MaxValue;
                static /*0xa8*/ System.Data.SqlTypes.SqlDateTime Null;
                /*0x10*/ bool m_fNotNull;
                /*0x14*/ int m_day;
                /*0x18*/ int m_time;

                static /*0x378bd8c*/ SqlDateTime();
                static /*0x378abd0*/ System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value);
                static /*0x378ac78*/ System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value);
                static /*0x378ad20*/ System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value);
                static /*0x378a9a8*/ System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value);
                static /*0x378b054*/ System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value);
                static /*0x378b178*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x378b250*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x378b33c*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x378b428*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x378b4a4*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y);
                static /*0x378bd00*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x378a930*/ SqlDateTime(bool fNull);
                /*0x378a93c*/ SqlDateTime(System.DateTime value);
                /*0x378aa9c*/ SqlDateTime(int dayTicks, int timeTicks);
                /*0x378abc0*/ bool get_IsNull();
                /*0x378af28*/ System.DateTime get_Value();
                /*0x378afc4*/ int get_DayTicks();
                /*0x378b00c*/ int get_TimeTicks();
                /*0x378b084*/ string ToString();
                /*0x378b520*/ int CompareTo(object value);
                /*0x378b630*/ int CompareTo(System.Data.SqlTypes.SqlDateTime value);
                /*0x378b794*/ bool Equals(object value);
                /*0x378b8e0*/ int GetHashCode();
                /*0x378b99c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x378b9a4*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x378bba4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDecimal : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ byte s_NUMERIC_MAX_PRECISION;
                static /*0x1*/ byte MaxPrecision;
                static /*0x2*/ byte MaxScale;
                static /*0x3*/ byte s_bNullMask;
                static /*0x4*/ byte s_bIsNull;
                static /*0x5*/ byte s_bNotNull;
                static /*0x6*/ byte s_bReverseNullMask;
                static /*0x7*/ byte s_bSignMask;
                static /*0x8*/ byte s_bPositive;
                static /*0x9*/ byte s_bNegative;
                static /*0xa*/ byte s_bReverseSignMask;
                static /*0xc*/ uint s_uiZero;
                static /*0x10*/ int s_cNumeMax;
                static /*0x18*/ long s_lInt32Base;
                static /*0x20*/ ulong s_ulInt32Base;
                static /*0x28*/ ulong s_ulInt32BaseForMod;
                static /*0x30*/ ulong s_llMax;
                static /*0x38*/ uint s_ulBase10;
                static /*0x40*/ double s_DUINT_BASE;
                static /*0x48*/ double s_DUINT_BASE2;
                static /*0x50*/ double s_DUINT_BASE3;
                static /*0x58*/ double s_DMAX_NUME;
                static /*0x60*/ uint s_DBL_DIG;
                static /*0x64*/ byte s_cNumeDivScaleMin;
                static /*0x68*/ uint[] s_rgulShiftBase;
                static /*0x70*/ uint[] s_decimalHelpersLo;
                static /*0x78*/ uint[] s_decimalHelpersMid;
                static /*0x80*/ uint[] s_decimalHelpersHi;
                static /*0x88*/ uint[] s_decimalHelpersHiHi;
                static /*0x90*/ byte[] s_rgCLenFromPrec;
                static /*0x98*/ uint s_ulT1;
                static /*0x9c*/ uint s_ulT2;
                static /*0xa0*/ uint s_ulT3;
                static /*0xa4*/ uint s_ulT4;
                static /*0xa8*/ uint s_ulT5;
                static /*0xac*/ uint s_ulT6;
                static /*0xb0*/ uint s_ulT7;
                static /*0xb4*/ uint s_ulT8;
                static /*0xb8*/ uint s_ulT9;
                static /*0xc0*/ ulong s_dwlT10;
                static /*0xc8*/ ulong s_dwlT11;
                static /*0xd0*/ ulong s_dwlT12;
                static /*0xd8*/ ulong s_dwlT13;
                static /*0xe0*/ ulong s_dwlT14;
                static /*0xe8*/ ulong s_dwlT15;
                static /*0xf0*/ ulong s_dwlT16;
                static /*0xf8*/ ulong s_dwlT17;
                static /*0x100*/ ulong s_dwlT18;
                static /*0x108*/ ulong s_dwlT19;
                static /*0x110*/ System.Data.SqlTypes.SqlDecimal Null;
                static /*0x124*/ System.Data.SqlTypes.SqlDecimal MinValue;
                static /*0x138*/ System.Data.SqlTypes.SqlDecimal MaxValue;
                /*0x10*/ byte _bStatus;
                /*0x11*/ byte _bLen;
                /*0x12*/ byte _bPrec;
                /*0x13*/ byte _bScale;
                /*0x14*/ uint _data1;
                /*0x18*/ uint _data2;
                /*0x1c*/ uint _data3;
                /*0x20*/ uint _data4;

                static /*0x3792644*/ SqlDecimal();
                static /*0x378d9c8*/ System.Data.SqlTypes.SqlDecimal Parse(string s);
                static /*0x378e3e4*/ System.Data.SqlTypes.SqlDecimal op_Implicit(decimal x);
                static /*0x378e3fc*/ System.Data.SqlTypes.SqlDecimal op_Implicit(long x);
                static /*0x378e464*/ System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x);
                static /*0x378e590*/ System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x378f0a8*/ System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x378f15c*/ System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x378fb14*/ System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x37907e0*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x37908bc*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x37909f0*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x3790b6c*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x3790c54*/ System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x3790764*/ void ZeroToMaxLen(uint[] rgulData, int cUI4sCur);
                static /*0x378c918*/ byte BGetPrecUI4(uint value);
                static /*0x378cb4c*/ byte BGetPrecUI8(ulong dwlVal);
                static /*0x37910e4*/ void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, ref int ciulD);
                static /*0x3791148*/ void MpSet(uint[] rgulD, ref int ciulD, uint iulN);
                static /*0x3791174*/ void MpNormalize(uint[] rgulU, ref int ciulU);
                static /*0x37911cc*/ void MpMul1(uint[] piulD, ref int ciulD, uint iulX);
                static /*0x378d8f0*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
                static /*0x37912d8*/ ulong DWL(uint lo, uint hi);
                static /*0x37912cc*/ uint HI(ulong x);
                static /*0x37912d4*/ uint LO(ulong x);
                static /*0x378ff30*/ void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, ref int ciulQ, uint[] rgulR, ref int ciulR);
                static /*0x378cf58*/ void CheckValidPrecScale(byte bPrec, byte bScale);
                static /*0x3791548*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x3791640*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x3791738*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x3791830*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x37918c0*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y);
                static /*0x378d9c0*/ char ChFromDigit(uint uiDigit);
                static /*0x37925b8*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x378c678*/ SqlDecimal(bool fNull);
                /*0x378c6e0*/ SqlDecimal(decimal value);
                /*0x378c844*/ SqlDecimal(int value);
                /*0x378ca80*/ SqlDecimal(long value);
                /*0x378cdf8*/ SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive);
                /*0x378c230*/ byte CalculatePrecision();
                /*0x378c45c*/ bool VerifyPrecision(byte precision);
                /*0x378d0b8*/ bool get_IsNull();
                /*0x378d128*/ decimal get_Value();
                /*0x378d2dc*/ bool get_IsPositive();
                /*0x378d050*/ void SetPositive();
                /*0x378d39c*/ void SetSignBit(bool fPositive);
                /*0x378d430*/ byte get_Scale();
                /*0x378d4c4*/ int[] get_Data();
                /*0x378d5c0*/ string ToString();
                /*0x378e298*/ double ToDouble();
                /*0x378d17c*/ decimal ToDecimal();
                /*0x378d030*/ bool FZero();
                /*0x378f040*/ bool FGt10_38();
                /*0x3790e6c*/ bool FGt10_38(uint[] rglData);
                /*0x378e0e8*/ void AddULong(uint ulAdd);
                /*0x378dee0*/ void MultByULong(uint uiMultiplier);
                /*0x3790f3c*/ uint DivByULong(uint iDivisor);
                /*0x378eb84*/ void AdjustScale(int digits, bool fRound);
                /*0x378eed4*/ int LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x37912e4*/ System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp);
                /*0x3791950*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x3791a84*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x3791cb4*/ System.Data.SqlTypes.SqlMoney ToSqlMoney();
                /*0x3790ee4*/ void StoreFromWorkingArray(uint[] rguiData);
                /*0x378de68*/ void SetToZero();
                /*0x3791df8*/ int CompareTo(object value);
                /*0x3791f18*/ int CompareTo(System.Data.SqlTypes.SqlDecimal value);
                /*0x37920a8*/ bool Equals(object value);
                /*0x3792224*/ int GetHashCode();
                /*0x3792334*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x379233c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x37924a0*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlDouble Null;
                static /*0x10*/ System.Data.SqlTypes.SqlDouble Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlDouble MinValue;
                static /*0x30*/ System.Data.SqlTypes.SqlDouble MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ double m_value;

                static /*0x379406c*/ SqlDouble();
                static /*0x3792aac*/ System.Data.SqlTypes.SqlDouble op_Implicit(double x);
                static /*0x3792b6c*/ System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x);
                static /*0x3792c14*/ System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3792d3c*/ System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3792e64*/ System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3792f8c*/ System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3788cd0*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x37930e8*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x37931b4*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x379327c*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x3793344*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x);
                static /*0x3793414*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x37919c0*/ System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x3793568*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x379363c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3793710*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x37937e4*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3793860*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y);
                static /*0x3793fe0*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x37929e0*/ SqlDouble(bool fNull);
                /*0x37929ec*/ SqlDouble(double value);
                /*0x3792a54*/ bool get_IsNull();
                /*0x3792a64*/ double get_Value();
                /*0x3792ad0*/ string ToString();
                /*0x37938dc*/ System.Data.SqlTypes.SqlSingle ToSqlSingle();
                /*0x379393c*/ int CompareTo(object value);
                /*0x3793a48*/ int CompareTo(System.Data.SqlTypes.SqlDouble value);
                /*0x3793ba4*/ bool Equals(object value);
                /*0x3793ce8*/ int GetHashCode();
                /*0x3793d7c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3793d84*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x3793ea4*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_sizeOfGuid;
                static /*0x8*/ int[] s_rgiGuidOrder;
                static /*0x10*/ System.Data.SqlTypes.SqlGuid Null;
                /*0x10*/ byte[] m_value;

                static /*0x3794d90*/ SqlGuid();
                static /*0x37941f8*/ System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x);
                static /*0x37942d8*/ System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x37943d0*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x37944ac*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x3794588*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y);
                static /*0x3794d04*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x37940fc*/ SqlGuid(bool fNull);
                /*0x3794108*/ SqlGuid(System.Guid g);
                /*0x3794140*/ bool get_IsNull();
                /*0x3794150*/ System.Guid get_Value();
                /*0x379422c*/ string ToString();
                /*0x3794664*/ int CompareTo(object value);
                /*0x379476c*/ int CompareTo(System.Data.SqlTypes.SqlGuid value);
                /*0x37948a8*/ bool Equals(object value);
                /*0x37949dc*/ int GetHashCode();
                /*0x3794a70*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3794a78*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x3794bb8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlInt16 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_MASKI2;
                static /*0x4*/ System.Data.SqlTypes.SqlInt16 Null;
                static /*0x8*/ System.Data.SqlTypes.SqlInt16 Zero;
                static /*0xc*/ System.Data.SqlTypes.SqlInt16 MinValue;
                static /*0x10*/ System.Data.SqlTypes.SqlInt16 MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x12*/ short m_value;

                static /*0x37961e0*/ SqlInt16();
                static /*0x3794e88*/ System.Data.SqlTypes.SqlInt16 op_Implicit(short x);
                static /*0x3794f30*/ System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x);
                static /*0x3794fd0*/ System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x37950e0*/ System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x37951f0*/ System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x3795338*/ System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x3795494*/ System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x3795564*/ System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x379567c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x379573c*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x37957fc*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x37958bc*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x3795920*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y);
                static /*0x3796154*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3794e6c*/ SqlInt16(bool fNull);
                /*0x3794e78*/ SqlInt16(short value);
                /*0x3790998*/ bool get_IsNull();
                /*0x37909a8*/ short get_Value();
                /*0x3794e94*/ string ToString();
                /*0x3795984*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x37959dc*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x3795aec*/ int CompareTo(object value);
                /*0x3795bf4*/ int CompareTo(System.Data.SqlTypes.SqlInt16 value);
                /*0x3795d34*/ bool Equals(object value);
                /*0x3795e68*/ int GetHashCode();
                /*0x3795efc*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3795f04*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x3796024*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlInt32 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ long s_iIntMin;
                static /*0x8*/ long s_lBitNotIntMax;
                static /*0x10*/ System.Data.SqlTypes.SqlInt32 Null;
                static /*0x18*/ System.Data.SqlTypes.SqlInt32 Zero;
                static /*0x20*/ System.Data.SqlTypes.SqlInt32 MinValue;
                static /*0x28*/ System.Data.SqlTypes.SqlInt32 MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x14*/ int m_value;

                static /*0x37976fc*/ SqlInt32();
                static /*0x3796278*/ System.Data.SqlTypes.SqlInt32 op_Implicit(int x);
                static /*0x3796320*/ System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x);
                static /*0x37963bc*/ System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x37964f8*/ System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3796628*/ System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3796770*/ System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x37968d0*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x37969a0*/ System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x3796a74*/ System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x37964ec*/ bool SameSignInt(int x, int y);
                static /*0x3796b8c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3796c50*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3796d14*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3796dd8*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3796e3c*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y);
                static /*0x3797670*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x379625c*/ SqlInt32(bool fNull);
                /*0x3796268*/ SqlInt32(int value);
                /*0x3790acc*/ bool get_IsNull();
                /*0x3790adc*/ int get_Value();
                /*0x3796284*/ string ToString();
                /*0x3796ea0*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x3796ef8*/ System.Data.SqlTypes.SqlInt64 ToSqlInt64();
                /*0x3797008*/ int CompareTo(object value);
                /*0x3797110*/ int CompareTo(System.Data.SqlTypes.SqlInt32 value);
                /*0x3797250*/ bool Equals(object value);
                /*0x3797384*/ int GetHashCode();
                /*0x3797418*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x3797420*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x3797540*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlInt64 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ long s_lLowIntMask;
                static /*0x8*/ long s_lHighIntMask;
                static /*0x10*/ System.Data.SqlTypes.SqlInt64 Null;
                static /*0x20*/ System.Data.SqlTypes.SqlInt64 Zero;
                static /*0x30*/ System.Data.SqlTypes.SqlInt64 MinValue;
                static /*0x40*/ System.Data.SqlTypes.SqlInt64 MaxValue;
                /*0x10*/ bool m_fNotNull;
                /*0x18*/ long m_value;

                static /*0x3798b94*/ SqlInt64();
                static /*0x3797794*/ System.Data.SqlTypes.SqlInt64 op_Implicit(long x);
                static /*0x379783c*/ System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x);
                static /*0x37978c8*/ System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3797a0c*/ System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3797b40*/ System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3797ca8*/ System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3797de0*/ System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3788df4*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x3795a34*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x3796f50*/ System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x3791af4*/ System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x37979fc*/ bool SameSignLong(long x, long y);
                static /*0x3797f1c*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3797fe8*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x37980b4*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3798180*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x37981fc*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y);
                static /*0x3798b08*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3797778*/ SqlInt64(bool fNull);
                /*0x3797784*/ SqlInt64(long value);
                /*0x378890c*/ bool get_IsNull();
                /*0x378891c*/ long get_Value();
                /*0x37977a0*/ string ToString();
                /*0x3798278*/ System.Data.SqlTypes.SqlByte ToSqlByte();
                /*0x37982d4*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x3798330*/ System.Data.SqlTypes.SqlInt16 ToSqlInt16();
                /*0x379838c*/ System.Data.SqlTypes.SqlInt32 ToSqlInt32();
                /*0x37983e8*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x3798470*/ int CompareTo(object value);
                /*0x379857c*/ int CompareTo(System.Data.SqlTypes.SqlInt64 value);
                /*0x37986d8*/ bool Equals(object value);
                /*0x379881c*/ int GetHashCode();
                /*0x37988b0*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x37988b8*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x37989d8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlMoney : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ int s_iMoneyScale;
                static /*0x8*/ long s_lTickBase;
                static /*0x10*/ double s_dTickBase;
                static /*0x18*/ long s_minLong;
                static /*0x20*/ long s_maxLong;
                static /*0x28*/ System.Data.SqlTypes.SqlMoney Null;
                static /*0x38*/ System.Data.SqlTypes.SqlMoney Zero;
                static /*0x48*/ System.Data.SqlTypes.SqlMoney MinValue;
                static /*0x58*/ System.Data.SqlTypes.SqlMoney MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x18*/ long _value;

                static /*0x379a6d4*/ SqlMoney();
                static /*0x3798fa8*/ System.Data.SqlTypes.SqlMoney op_Implicit(decimal x);
                static /*0x3798fd4*/ System.Data.SqlTypes.SqlMoney op_Implicit(long x);
                static /*0x3799158*/ System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x);
                static /*0x3799240*/ System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x37993e8*/ System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x3799590*/ System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x37996c8*/ System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x3799800*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x37998cc*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x3799994*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x3799a5c*/ System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x3791d24*/ System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x3799b24*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x3799bf0*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x3799cbc*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x3799d88*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x3799e04*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y);
                static /*0x379a648*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3798c2c*/ SqlMoney(bool fNull);
                /*0x3798c38*/ SqlMoney(long value, int ignored);
                /*0x3798c48*/ SqlMoney(int value);
                /*0x3798cc4*/ SqlMoney(long value);
                /*0x3798dbc*/ SqlMoney(decimal value);
                /*0x3790d48*/ bool get_IsNull();
                /*0x3798f18*/ decimal get_Value();
                /*0x3790d58*/ decimal ToDecimal();
                /*0x37934d8*/ double ToDouble();
                /*0x3799030*/ string ToString();
                /*0x3799e80*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x3799edc*/ System.Data.SqlTypes.SqlDecimal ToSqlDecimal();
                /*0x3799f64*/ int CompareTo(object value);
                /*0x379a070*/ int CompareTo(System.Data.SqlTypes.SqlMoney value);
                /*0x379a1cc*/ bool Equals(object value);
                /*0x379a310*/ int GetHashCode();
                /*0x379a380*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x379a388*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x379a4f8*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlSingle Null;
                static /*0x8*/ System.Data.SqlTypes.SqlSingle Zero;
                static /*0x10*/ System.Data.SqlTypes.SqlSingle MinValue;
                static /*0x18*/ System.Data.SqlTypes.SqlSingle MaxValue;
                /*0x10*/ bool _fNotNull;
                /*0x14*/ float _value;

                static /*0x379c014*/ SqlSingle();
                static /*0x379a904*/ System.Data.SqlTypes.SqlSingle op_Implicit(float x);
                static /*0x379a990*/ System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x);
                static /*0x379aa30*/ System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379ab4c*/ System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379ac68*/ System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379ad84*/ System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379aed8*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x);
                static /*0x379afac*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x);
                static /*0x379b080*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x);
                static /*0x379b150*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x);
                static /*0x379b220*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x);
                static /*0x379b2ec*/ System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x);
                static /*0x379b3b8*/ System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x);
                static /*0x379b484*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379b564*/ System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379b644*/ System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379b724*/ System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379b788*/ System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y);
                static /*0x379bf88*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x379a79c*/ SqlSingle(bool fNull);
                /*0x379a7a8*/ SqlSingle(float value);
                /*0x379a814*/ SqlSingle(double value);
                /*0x379a878*/ bool get_IsNull();
                /*0x379a888*/ float get_Value();
                /*0x379a91c*/ string ToString();
                /*0x379b7ec*/ System.Data.SqlTypes.SqlDouble ToSqlDouble();
                /*0x379b848*/ int CompareTo(object value);
                /*0x379b94c*/ int CompareTo(System.Data.SqlTypes.SqlSingle value);
                /*0x379bb58*/ bool Equals(object value);
                /*0x379bc90*/ int GetHashCode();
                /*0x379bd24*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x379bd2c*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x379be4c*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            enum SqlCompareOptions
            {
                None = 0,
                IgnoreCase = 1,
                IgnoreNonSpace = 2,
                IgnoreKanaType = 8,
                IgnoreWidth = 16,
                BinarySort = 32768,
                BinarySort2 = 16384,
            }

            struct SqlString : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Data.SqlTypes.SqlString Null;
                static /*0x20*/ System.Text.UnicodeEncoding s_unicodeEncoding;
                static /*0x28*/ int IgnoreCase;
                static /*0x2c*/ int IgnoreWidth;
                static /*0x30*/ int IgnoreNonSpace;
                static /*0x34*/ int IgnoreKanaType;
                static /*0x38*/ int BinarySort;
                static /*0x3c*/ int BinarySort2;
                static /*0x40*/ System.Data.SqlTypes.SqlCompareOptions s_iDefaultFlag;
                static /*0x44*/ System.Globalization.CompareOptions s_iValidCompareOptionMask;
                static /*0x48*/ System.Data.SqlTypes.SqlCompareOptions s_iValidSqlCompareOptionMask;
                static /*0x4c*/ int s_lcidUSEnglish;
                static /*0x50*/ int s_lcidBinary;
                /*0x10*/ string m_value;
                /*0x18*/ System.Globalization.CompareInfo m_cmpInfo;
                /*0x20*/ int m_lcid;
                /*0x24*/ System.Data.SqlTypes.SqlCompareOptions m_flag;
                /*0x28*/ bool m_fNotNull;

                static /*0x379d834*/ SqlString();
                static /*0x379c510*/ System.Data.SqlTypes.SqlString op_Implicit(string x);
                static /*0x379c590*/ System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x379c700*/ int StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x379ccf8*/ System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult);
                static /*0x379ce68*/ System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x379c190*/ void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x379cc54*/ System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions);
                static /*0x379c914*/ int CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x379cadc*/ int CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y);
                static /*0x379d7a8*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x379c0a4*/ SqlString(bool fNull);
                /*0x379c0d8*/ SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions);
                /*0x379c23c*/ SqlString(string data);
                /*0x379c2f8*/ SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, string data, System.Globalization.CompareInfo cmpInfo);
                /*0x379c3d8*/ bool get_IsNull();
                /*0x379c3e8*/ string get_Value();
                /*0x379c474*/ void SetCompareInfo();
                /*0x379c524*/ string ToString();
                /*0x379cf7c*/ bool FBinarySort();
                /*0x379cfe8*/ int CompareTo(object value);
                /*0x379d0fc*/ int CompareTo(System.Data.SqlTypes.SqlString value);
                /*0x379d1ec*/ bool Equals(object value);
                /*0x379d380*/ int GetHashCode();
                /*0x379d5a4*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x379d5ac*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader);
                /*0x379d6ac*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            enum EComparison
            {
                LT = 0,
                LE = 1,
                EQ = 2,
                GE = 3,
                GT = 4,
                NE = 5,
            }

            class SqlTypeException : System.SystemException
            {
                static /*0x379da0c*/ System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x379d938*/ SqlTypeException();
                /*0x379c6d8*/ SqlTypeException(string message);
                /*0x379d998*/ SqlTypeException(string message, System.Exception e);
                /*0x379d9bc*/ SqlTypeException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlNullValueException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x379db8c*/ System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x379a8cc*/ SqlNullValueException();
                /*0x379db04*/ SqlNullValueException(string message);
                /*0x379dae0*/ SqlNullValueException(string message, System.Exception e);
                /*0x379db2c*/ SqlNullValueException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlTruncateException : System.Data.SqlTypes.SqlTypeException
            {
                static /*0x379dd44*/ System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
                /*0x379dc60*/ SqlTruncateException();
                /*0x379dcbc*/ SqlTruncateException(string message);
                /*0x379dc98*/ SqlTruncateException(string message, System.Exception e);
                /*0x379dce4*/ SqlTruncateException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc);
            }

            class SqlStreamChars
            {
                long get_Length();
                long get_Position();
                int Read(char[] buffer, int offset, int count);
                long Seek(long offset, System.IO.SeekOrigin origin);
            }

            class SqlXml : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable
            {
                static /*0x0*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> s_sqlReaderDelegate;
                static /*0x8*/ System.Xml.XmlReaderSettings s_defaultXmlReaderSettings;
                static /*0x10*/ System.Xml.XmlReaderSettings s_defaultXmlReaderSettingsCloseInput;
                static /*0x18*/ System.Reflection.MethodInfo s_createSqlReaderMethodInfo;
                /*0x10*/ System.Reflection.MethodInfo _createSqlReaderMethodInfo;
                /*0x18*/ bool _fNotNull;
                /*0x20*/ System.IO.Stream _stream;
                /*0x28*/ bool _firstCreateReader;

                static /*0x379ea1c*/ SqlXml();
                static /*0x379e188*/ System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, bool closeInput, bool throwTargetInvocationExceptions);
                static /*0x379e560*/ System.Func<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader> CreateSqlReaderDelegate();
                static /*0x379e070*/ System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo();
                static /*0x379e990*/ System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x379de18*/ SqlXml();
                /*0x379de78*/ System.Xml.XmlReader CreateReader();
                /*0x379dfe0*/ bool get_IsNull();
                /*0x379de4c*/ void SetNull();
                /*0x379e64c*/ System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
                /*0x379e654*/ void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r);
                /*0x379e840*/ void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer);
            }

            class SqlXmlStreamWrapper : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _stream;
                /*0x30*/ long _lPosition;
                /*0x38*/ bool _isClosed;

                /*0x379dff0*/ SqlXmlStreamWrapper(System.IO.Stream stream);
                /*0x379eb14*/ bool get_CanRead();
                /*0x379ebbc*/ bool get_CanSeek();
                /*0x379ebf4*/ bool get_CanWrite();
                /*0x379ec2c*/ long get_Length();
                /*0x379ed7c*/ long get_Position();
                /*0x379edd8*/ void set_Position(long value);
                /*0x379eeac*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x379f07c*/ int Read(byte[] buffer, int offset, int count);
                /*0x379f2b0*/ void Write(byte[] buffer, int offset, int count);
                /*0x379f4e4*/ int ReadByte();
                /*0x379f5f8*/ void WriteByte(byte value);
                /*0x379f6dc*/ void SetLength(long value);
                /*0x379f770*/ void Flush();
                /*0x379f78c*/ void Dispose(bool disposing);
                /*0x379ed00*/ void ThrowIfStreamCannotSeek(string method);
                /*0x379f234*/ void ThrowIfStreamCannotRead(string method);
                /*0x379f468*/ void ThrowIfStreamCannotWrite(string method);
                /*0x379ec98*/ void ThrowIfStreamClosed(string method);
                /*0x379eb4c*/ bool IsStreamClosed();
            }
        }

        namespace Common
        {
            class ObjectStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ object s_defaultValue;
                static /*0x8*/ object s_tempAssemblyCacheLock;
                static /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>, System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache;
                static /*0x18*/ System.Xml.Serialization.XmlSerializerFactory s_serializerFactory;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;

                static /*0x37a4e5c*/ ObjectStorage();
                static /*0x37a4cb8*/ void VerifyIDynamicMetaObjectProvider(System.Type type);
                static /*0x37a1398*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type);
                static /*0x37a3894*/ System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute);
                /*0x379f79c*/ ObjectStorage(System.Data.DataColumn column, System.Type type);
                /*0x379fb90*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x379fbc0*/ int Compare(int recordNo1, int recordNo2);
                /*0x37a0210*/ int CompareValueTo(int recordNo1, object value);
                /*0x37a03e8*/ int CompareTo(object valueNo1, object valueNo2);
                /*0x379fd74*/ int CompareWithFamilies(object valueNo1, object valueNo2);
                /*0x37a0658*/ void Copy(int recordNo1, int recordNo2);
                /*0x37a06d0*/ object Get(int recordNo);
                /*0x37a0558*/ System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType);
                /*0x37a070c*/ bool IsNull(int record);
                /*0x37a0744*/ void Set(int recordNo, object value);
                /*0x37a0dfc*/ void SetCapacity(int capacity);
                /*0x37a0ebc*/ object ConvertXmlToObject(string s);
                /*0x37a140c*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x37a41dc*/ string ConvertObjectToXml(object value);
                /*0x37a470c*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x37a4870*/ object GetEmptyStorage(int recordCount);
                /*0x37a48b8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37a4ad0*/ void SetStorage(object store, System.Collections.BitArray nullbits);

                enum Families
                {
                    DATETIME = 0,
                    NUMBER = 1,
                    STRING = 2,
                    BOOLEAN = 3,
                    ARRAY = 4,
                }

                class TempAssemblyComparer : System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute>> s_default;

                    static /*0x37a5894*/ TempAssemblyComparer();
                    /*0x37a4f30*/ TempAssemblyComparer();
                    /*0x37a4f38*/ bool Equals(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> y);
                    /*0x37a5714*/ int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type, System.Xml.Serialization.XmlRootAttribute> obj);
                }
            }

            class ADP
            {
                static /*0x0*/ System.Type s_stackOverflowType;
                static /*0x8*/ System.Type s_outOfMemoryType;
                static /*0x10*/ System.Type s_threadAbortType;
                static /*0x18*/ System.Type s_nullReferenceType;
                static /*0x20*/ System.Type s_accessViolationType;
                static /*0x28*/ System.Type s_securityType;
                static /*0x30*/ string StrEmpty;
                static /*0x38*/ string[] AzureSqlServerEndpoints;
                static /*0x40*/ nint PtrZero;
                static /*0x48*/ int PtrSize;

                static /*0x37a60cc*/ ADP();
                static /*0x37a58fc*/ void TraceException(string trace, System.Exception e);
                static /*0x37a5994*/ void TraceExceptionAsReturnValue(System.Exception e);
                static /*0x37a5a00*/ void TraceExceptionWithoutRethrow(System.Exception e);
                static /*0x37a5a6c*/ System.ArgumentException Argument(string error);
                static /*0x379ceec*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName);
                static /*0x37a5afc*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName);
                static /*0x37a4dcc*/ System.InvalidOperationException InvalidOperation(string error);
                static /*0x37a5b94*/ System.NotSupportedException NotSupported(string error);
                static /*0x379e360*/ bool IsCatchableExceptionType(System.Exception e);
                static /*0x37a5c24*/ bool IsCatchableOrSecurityExceptionType(System.Exception e);
                static /*0x37a5dec*/ System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, int value);
                static /*0x379f010*/ System.Exception InvalidSeekOrigin(string parameterName);
                static /*0x37a5ef8*/ System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value);
                static /*0x37a5f94*/ System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value);
                static /*0x37a6030*/ System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value);
                static /*0x379ba94*/ System.Exception WrongType(System.Type got, System.Type expected);
            }

            class BigIntegerStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Numerics.BigInteger[] _values;

                static /*0x37a68fc*/ System.Numerics.BigInteger ConvertToBigInteger(object value, System.IFormatProvider formatProvider);
                static /*0x37a6ef4*/ object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider);
                /*0x37a6438*/ BigIntegerStorage(System.Data.DataColumn column);
                /*0x37a6600*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37a6630*/ int Compare(int recordNo1, int recordNo2);
                /*0x37a67ac*/ int CompareValueTo(int recordNo, object value);
                /*0x37a74f8*/ object ConvertValue(object value);
                /*0x37a7598*/ void Copy(int recordNo1, int recordNo2);
                /*0x37a7638*/ object Get(int record);
                /*0x37a772c*/ void Set(int record, object value);
                /*0x37a788c*/ void SetCapacity(int capacity);
                /*0x37a79e0*/ object ConvertXmlToObject(string s);
                /*0x37a7a90*/ string ConvertObjectToXml(object value);
                /*0x37a7b84*/ object GetEmptyStorage(int recordCount);
                /*0x37a7bcc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37a7cdc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class BooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ bool[] _values;

                /*0x37a7da0*/ BooleanStorage(System.Data.DataColumn column);
                /*0x37a7e60*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37a8208*/ int Compare(int recordNo1, int recordNo2);
                /*0x37a8294*/ int CompareValueTo(int recordNo, object value);
                /*0x37a836c*/ object ConvertValue(object value);
                /*0x37a84b0*/ void Copy(int recordNo1, int recordNo2);
                /*0x37a8504*/ object Get(int record);
                /*0x37a8558*/ void Set(int record, object value);
                /*0x37a86e4*/ void SetCapacity(int capacity);
                /*0x37a87b4*/ object ConvertXmlToObject(string s);
                /*0x37a8834*/ string ConvertObjectToXml(object value);
                /*0x37a88c0*/ object GetEmptyStorage(int recordCount);
                /*0x37a8908*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37a8a08*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class ByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ byte[] _values;

                /*0x37a8acc*/ ByteStorage(System.Data.DataColumn column);
                /*0x37a8b8c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37a9370*/ int Compare(int recordNo1, int recordNo2);
                /*0x37a93e0*/ int CompareValueTo(int recordNo, object value);
                /*0x37a94a4*/ object ConvertValue(object value);
                /*0x37a95e8*/ void Copy(int recordNo1, int recordNo2);
                /*0x37a963c*/ object Get(int record);
                /*0x37a9690*/ void Set(int record, object value);
                /*0x37a9814*/ void SetCapacity(int capacity);
                /*0x37a98e4*/ object ConvertXmlToObject(string s);
                /*0x37a9964*/ string ConvertObjectToXml(object value);
                /*0x37a99f0*/ object GetEmptyStorage(int recordCount);
                /*0x37a9a38*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37a9b38*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class CharStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ char[] _values;

                /*0x37a9bfc*/ CharStorage(System.Data.DataColumn column);
                /*0x37a9cbc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37aa048*/ int Compare(int recordNo1, int recordNo2);
                /*0x37aa0d0*/ int CompareValueTo(int recordNo, object value);
                /*0x37aa1a8*/ object ConvertValue(object value);
                /*0x37aa2ec*/ void Copy(int recordNo1, int recordNo2);
                /*0x37aa340*/ object Get(int record);
                /*0x37aa394*/ void Set(int record, object value);
                /*0x37aa574*/ void SetCapacity(int capacity);
                /*0x37aa644*/ object ConvertXmlToObject(string s);
                /*0x37aa6c4*/ string ConvertObjectToXml(object value);
                /*0x37aa750*/ object GetEmptyStorage(int recordCount);
                /*0x37aa798*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37aa898*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            enum StorageType
            {
                Empty = 0,
                Object = 1,
                DBNull = 2,
                Boolean = 3,
                Char = 4,
                SByte = 5,
                Byte = 6,
                Int16 = 7,
                UInt16 = 8,
                Int32 = 9,
                UInt32 = 10,
                Int64 = 11,
                UInt64 = 12,
                Single = 13,
                Double = 14,
                Decimal = 15,
                DateTime = 16,
                TimeSpan = 17,
                String = 18,
                Guid = 19,
                ByteArray = 20,
                CharArray = 21,
                Type = 22,
                DateTimeOffset = 23,
                BigInteger = 24,
                Uri = 25,
                SqlBinary = 26,
                SqlBoolean = 27,
                SqlByte = 28,
                SqlBytes = 29,
                SqlChars = 30,
                SqlDateTime = 31,
                SqlDecimal = 32,
                SqlDouble = 33,
                SqlGuid = 34,
                SqlInt16 = 35,
                SqlInt32 = 36,
                SqlInt64 = 37,
                SqlMoney = 38,
                SqlSingle = 39,
                SqlString = 40,
            }

            class DataStorage
            {
                static /*0x0*/ System.Type[] s_storageClassType;
                static /*0x8*/ System.Func<System.Type, System.Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces;
                static /*0x10*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Tuple<bool, bool, bool, bool>> s_typeImplementsInterface;
                /*0x10*/ System.Data.DataColumn _column;
                /*0x18*/ System.Data.DataTable _table;
                /*0x20*/ System.Type _dataType;
                /*0x28*/ System.Data.Common.StorageType _storageTypeCode;
                /*0x30*/ System.Collections.BitArray _dbNullBits;
                /*0x38*/ object _defaultValue;
                /*0x40*/ object _nullValue;
                /*0x48*/ bool _isCloneable;
                /*0x49*/ bool _isCustomDefinedType;
                /*0x4a*/ bool _isStringType;
                /*0x4b*/ bool _isValueType;

                static /*0x37ac238*/ DataStorage();
                static /*0x37aab28*/ System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode);
                static /*0x379f934*/ System.Data.Common.StorageType GetStorageType(System.Type dataType);
                static /*0x37ab9cc*/ System.Type GetTypeStorage(System.Data.Common.StorageType storageType);
                static /*0x37a469c*/ bool IsTypeCustomType(System.Type type);
                static /*0x37aa968*/ bool IsTypeCustomType(System.Data.Common.StorageType typeCode);
                static /*0x37aba48*/ bool IsSqlType(System.Data.Common.StorageType storageType);
                static /*0x37aba54*/ bool IsSqlType(System.Type dataType);
                static /*0x37aa984*/ bool DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x37abb44*/ void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, ref bool sqlType, ref bool nullable, ref bool xmlSerializable, ref bool changeTracking, ref bool revertibleChangeTracking);
                static /*0x37abda0*/ System.Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(System.Type dataType);
                static /*0x37abf74*/ bool ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType);
                static /*0x37ac03c*/ bool IsObjectNull(object value);
                static /*0x37ac0dc*/ bool IsObjectSqlNull(object value);
                static /*0x37a1a90*/ System.Type GetType(string value);
                static /*0x37ac1c8*/ string GetQualifiedName(System.Type type);
                /*0x37a656c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, System.Data.Common.StorageType storageType);
                /*0x37aa95c*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, System.Data.Common.StorageType storageType);
                /*0x379fa40*/ DataStorage(System.Data.DataColumn column, System.Type type, object defaultValue, object nullValue, bool isICloneable, System.Data.Common.StorageType storageType);
                /*0x37aa9c0*/ System.Data.DataSetDateTime get_DateTimeMode();
                /*0x37a0640*/ System.IFormatProvider get_FormatProvider();
                /*0x37a81f4*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x37aa9d8*/ object AggregateCount(int[] recordNos);
                /*0x37a6748*/ int CompareBits(int recordNo1, int recordNo2);
                /*0x1f2fff4*/ int Compare(int recordNo1, int recordNo2);
                int CompareValueTo(int recordNo1, object value);
                /*0x37aaa84*/ object ConvertValue(object value);
                /*0x37a75f4*/ void CopyBits(int srcRecordNo, int dstRecordNo);
                /*0x1f30bb4*/ void Copy(int recordNo1, int recordNo2);
                /*0x1f30240*/ object Get(int recordNo);
                /*0x37a76f4*/ object GetBits(int recordNo);
                /*0x37aaa8c*/ int GetStringLength(int record);
                /*0x37a68d4*/ bool HasValue(int recordNo);
                /*0x37aaa94*/ bool IsNull(int recordNo);
                /*0x1f30c88*/ void Set(int recordNo, object value);
                /*0x37a7870*/ void SetNullBit(int recordNo, bool flag);
                /*0x37a795c*/ void SetCapacity(int capacity);
                /*0x1f302cc*/ object ConvertXmlToObject(string s);
                /*0x37aaaac*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x1f302cc*/ string ConvertObjectToXml(object value);
                /*0x37aaaec*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x37ac190*/ object GetEmptyStorageInternal(int recordCount);
                /*0x37ac1a0*/ void CopyValueInternal(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37ac1b0*/ void SetStorageInternal(object store, System.Collections.BitArray nullbits);
                /*0x1f30240*/ object GetEmptyStorage(int recordCount);
                void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x1f30ff0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
                /*0x37ac1c0*/ void SetNullStorage(System.Collections.BitArray nullbits);
            }

            class DateTimeOffsetStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTimeOffset s_defaultValue;
                /*0x50*/ System.DateTimeOffset[] _values;

                static /*0x37adfcc*/ DateTimeOffsetStorage();
                /*0x37ab8a8*/ DateTimeOffsetStorage(System.Data.DataColumn column);
                /*0x37ad06c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37ad58c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37ad728*/ int CompareValueTo(int recordNo, object value);
                /*0x37ad8a4*/ object ConvertValue(object value);
                /*0x37ad948*/ void Copy(int recordNo1, int recordNo2);
                /*0x37ad99c*/ object Get(int record);
                /*0x37adaa4*/ void Set(int record, object value);
                /*0x37adbc4*/ void SetCapacity(int capacity);
                /*0x37adc94*/ object ConvertXmlToObject(string s);
                /*0x37add20*/ string ConvertObjectToXml(object value);
                /*0x37addbc*/ object GetEmptyStorage(int recordCount);
                /*0x37ade04*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37adf08*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DateTimeStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.DateTime s_defaultValue;
                /*0x50*/ System.DateTime[] _values;

                static /*0x37af480*/ DateTimeStorage();
                /*0x37ab78c*/ DateTimeStorage(System.Data.DataColumn column);
                /*0x37ae044*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37ae534*/ int Compare(int recordNo1, int recordNo2);
                /*0x37ae6ac*/ int CompareValueTo(int recordNo, object value);
                /*0x37ae814*/ object ConvertValue(object value);
                /*0x37ae964*/ void Copy(int recordNo1, int recordNo2);
                /*0x37ae9b8*/ object Get(int record);
                /*0x37aeab0*/ void Set(int record, object value);
                /*0x37aee3c*/ void SetCapacity(int capacity);
                /*0x37aef0c*/ object ConvertXmlToObject(string s);
                /*0x37aefcc*/ string ConvertObjectToXml(object value);
                /*0x37af0bc*/ object GetEmptyStorage(int recordCount);
                /*0x37af104*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37af264*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DecimalStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ decimal s_defaultValue;
                /*0x50*/ decimal[] _values;

                /*0x37ab65c*/ DecimalStorage(System.Data.DataColumn column);
                /*0x37af4f8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37b0154*/ int Compare(int recordNo1, int recordNo2);
                /*0x37b02c8*/ int CompareValueTo(int recordNo, object value);
                /*0x37b0430*/ object ConvertValue(object value);
                /*0x37b05d8*/ void Copy(int recordNo1, int recordNo2);
                /*0x37b062c*/ object Get(int record);
                /*0x37b070c*/ void Set(int record, object value);
                /*0x37b08b0*/ void SetCapacity(int capacity);
                /*0x37b0980*/ object ConvertXmlToObject(string s);
                /*0x37b0a34*/ string ConvertObjectToXml(object value);
                /*0x37b0ad0*/ object GetEmptyStorage(int recordCount);
                /*0x37b0b18*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37b0c1c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class DoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ double[] _values;

                /*0x37ab59c*/ DoubleStorage(System.Data.DataColumn column);
                /*0x37b0ce0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37b144c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37b14cc*/ int CompareValueTo(int recordNo, object value);
                /*0x37b1594*/ object ConvertValue(object value);
                /*0x37b16d4*/ void Copy(int recordNo1, int recordNo2);
                /*0x37b1728*/ object Get(int record);
                /*0x37b1780*/ void Set(int record, object value);
                /*0x37b1904*/ void SetCapacity(int capacity);
                /*0x37b19d4*/ object ConvertXmlToObject(string s);
                /*0x37b1a50*/ string ConvertObjectToXml(object value);
                /*0x37b1ae0*/ object GetEmptyStorage(int recordCount);
                /*0x37b1b28*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37b1c28*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ short[] _values;

                /*0x37ab35c*/ Int16Storage(System.Data.DataColumn column);
                /*0x37b1cec*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37b253c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37b259c*/ int CompareValueTo(int recordNo, object value);
                /*0x37b264c*/ object ConvertValue(object value);
                /*0x37b2790*/ void Copy(int recordNo1, int recordNo2);
                /*0x37b27e4*/ object Get(int record);
                /*0x37b2838*/ void Set(int record, object value);
                /*0x37b29c0*/ void SetCapacity(int capacity);
                /*0x37b2a90*/ object ConvertXmlToObject(string s);
                /*0x37b2b10*/ string ConvertObjectToXml(object value);
                /*0x37b2b9c*/ object GetEmptyStorage(int recordCount);
                /*0x37b2be4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37b2ce0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ int[] _values;

                /*0x37ab41c*/ Int32Storage(System.Data.DataColumn column);
                /*0x37b2da4*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37b35f8*/ int Compare(int recordNo1, int recordNo2);
                /*0x37b3664*/ int CompareValueTo(int recordNo, object value);
                /*0x37b3714*/ object ConvertValue(object value);
                /*0x37b3858*/ void Copy(int recordNo1, int recordNo2);
                /*0x37b38ac*/ object Get(int record);
                /*0x37b3900*/ void Set(int record, object value);
                /*0x37b3a88*/ void SetCapacity(int capacity);
                /*0x37b3b58*/ object ConvertXmlToObject(string s);
                /*0x37b3bd8*/ string ConvertObjectToXml(object value);
                /*0x37b3c64*/ object GetEmptyStorage(int recordCount);
                /*0x37b3cac*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37b3da8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class Int64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ long[] _values;

                /*0x37ab4dc*/ Int64Storage(System.Data.DataColumn column);
                /*0x37b3e6c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37b46a8*/ int Compare(int recordNo1, int recordNo2);
                /*0x37b4714*/ int CompareValueTo(int recordNo, object value);
                /*0x37b47c4*/ object ConvertValue(object value);
                /*0x37b4908*/ void Copy(int recordNo1, int recordNo2);
                /*0x37b495c*/ object Get(int record);
                /*0x37b49b0*/ void Set(int record, object value);
                /*0x37b4b38*/ void SetCapacity(int capacity);
                /*0x37b4c08*/ object ConvertXmlToObject(string s);
                /*0x37b4c88*/ string ConvertObjectToXml(object value);
                /*0x37b4d14*/ object GetEmptyStorage(int recordCount);
                /*0x37b4d5c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37b4e58*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ sbyte[] _values;

                /*0x37ab29c*/ SByteStorage(System.Data.DataColumn column);
                /*0x37b4f1c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37b5720*/ int Compare(int recordNo1, int recordNo2);
                /*0x37b57d8*/ int CompareValueTo(int recordNo, object value);
                /*0x37b589c*/ object ConvertValue(object value);
                /*0x37b59e0*/ void Copy(int recordNo1, int recordNo2);
                /*0x37b5a34*/ object Get(int record);
                /*0x37b5abc*/ void Set(int record, object value);
                /*0x37b5c40*/ void SetCapacity(int capacity);
                /*0x37b5d10*/ object ConvertXmlToObject(string s);
                /*0x37b5d90*/ string ConvertObjectToXml(object value);
                /*0x37b5e1c*/ object GetEmptyStorage(int recordCount);
                /*0x37b5e64*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37b5f64*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlConvert
            {
                static /*0x37b6028*/ System.Data.SqlTypes.SqlByte ConvertToSqlByte(object value);
                static /*0x37b61fc*/ System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(object value);
                static /*0x37b6490*/ System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(object value);
                static /*0x37b6834*/ System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(object value);
                static /*0x37b6cc4*/ System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(object value);
                static /*0x37b7304*/ System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(object value);
                static /*0x37b78d0*/ System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(object value);
                static /*0x37b7e98*/ System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(object value);
                static /*0x37b844c*/ System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(object value);
                static /*0x37b8638*/ System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(object value);
                static /*0x37b87f8*/ System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(object value);
                static /*0x37b89d8*/ System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(object value);
                static /*0x37b8bac*/ System.Data.SqlTypes.SqlString ConvertToSqlString(object value);
                static /*0x37b8d7c*/ System.Data.SqlTypes.SqlChars ConvertToSqlChars(object value);
                static /*0x37b8ec8*/ System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(object value);
                static /*0x37b9014*/ System.DateTimeOffset ConvertStringToDateTimeOffset(string value, System.IFormatProvider formatProvider);
                static /*0x37b907c*/ object ChangeTypeForDefaultValue(object value, System.Type type, System.IFormatProvider formatProvider);
                static /*0x37b923c*/ object ChangeType2(object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider);
                static /*0x37a1bbc*/ object ChangeTypeForXML(object value, System.Type type);
            }

            class SqlBinaryStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBinary[] _values;

                /*0x37ba208*/ SqlBinaryStorage(System.Data.DataColumn column);
                /*0x37ba33c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37ba59c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37ba63c*/ int CompareValueTo(int recordNo, object value);
                /*0x37ba6f8*/ object ConvertValue(object value);
                /*0x37ba770*/ void Copy(int recordNo1, int recordNo2);
                /*0x37ba7b4*/ object Get(int record);
                /*0x37ba834*/ bool IsNull(int record);
                /*0x37ba8b0*/ void Set(int record, object value);
                /*0x37ba900*/ void SetCapacity(int capacity);
                /*0x37ba9c0*/ object ConvertXmlToObject(string s);
                /*0x37bac60*/ string ConvertObjectToXml(object value);
                /*0x37baeb0*/ object GetEmptyStorage(int recordCount);
                /*0x37baef8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37bb000*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlByteStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlByte[] _values;

                /*0x37bb09c*/ SqlByteStorage(System.Data.DataColumn column);
                /*0x37bb1c8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37bc050*/ int Compare(int recordNo1, int recordNo2);
                /*0x37bc0f0*/ int CompareValueTo(int recordNo, object value);
                /*0x37bc1ac*/ object ConvertValue(object value);
                /*0x37bc224*/ void Copy(int recordNo1, int recordNo2);
                /*0x37bc260*/ object Get(int record);
                /*0x37bc2e0*/ bool IsNull(int record);
                /*0x37bc35c*/ void Set(int record, object value);
                /*0x37bc3a4*/ void SetCapacity(int capacity);
                /*0x37bc464*/ object ConvertXmlToObject(string s);
                /*0x37bc704*/ string ConvertObjectToXml(object value);
                /*0x37bc954*/ object GetEmptyStorage(int recordCount);
                /*0x37bc99c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37bca9c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBytesStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBytes[] _values;

                /*0x37bcb38*/ SqlBytesStorage(System.Data.DataColumn column);
                /*0x37bcc0c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37bce2c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37bce34*/ int CompareValueTo(int recordNo, object value);
                /*0x37bce3c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37bce7c*/ object Get(int record);
                /*0x37bceac*/ bool IsNull(int record);
                /*0x37bcee4*/ void Set(int record, object value);
                /*0x37bcfdc*/ void SetCapacity(int capacity);
                /*0x37bd09c*/ object ConvertXmlToObject(string s);
                /*0x37bd360*/ string ConvertObjectToXml(object value);
                /*0x37bd5b0*/ object GetEmptyStorage(int recordCount);
                /*0x37bd5f8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37bd700*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlCharsStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlChars[] _values;

                /*0x37bd79c*/ SqlCharsStorage(System.Data.DataColumn column);
                /*0x37bd870*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37bda90*/ int Compare(int recordNo1, int recordNo2);
                /*0x37bda98*/ int CompareValueTo(int recordNo, object value);
                /*0x37bdaa0*/ void Copy(int recordNo1, int recordNo2);
                /*0x37bdae0*/ object Get(int record);
                /*0x37bdb10*/ bool IsNull(int record);
                /*0x37bdb48*/ void Set(int record, object value);
                /*0x37bdc40*/ void SetCapacity(int capacity);
                /*0x37bdd00*/ object ConvertXmlToObject(string s);
                /*0x37bdfd0*/ string ConvertObjectToXml(object value);
                /*0x37be220*/ object GetEmptyStorage(int recordCount);
                /*0x37be268*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37be370*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDateTimeStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDateTime[] _values;

                /*0x37be40c*/ SqlDateTimeStorage(System.Data.DataColumn column);
                /*0x37be550*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37beb78*/ int Compare(int recordNo1, int recordNo2);
                /*0x37bec2c*/ int CompareValueTo(int recordNo, object value);
                /*0x37becf0*/ object ConvertValue(object value);
                /*0x37bed6c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37bedbc*/ object Get(int record);
                /*0x37bee48*/ bool IsNull(int record);
                /*0x37beec8*/ void Set(int record, object value);
                /*0x37bef18*/ void SetCapacity(int capacity);
                /*0x37befd8*/ object ConvertXmlToObject(string s);
                /*0x37bf288*/ string ConvertObjectToXml(object value);
                /*0x37bf4d8*/ object GetEmptyStorage(int recordCount);
                /*0x37bf520*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37bf634*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDecimalStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDecimal[] _values;

                /*0x37bf6d0*/ SqlDecimalStorage(System.Data.DataColumn column);
                /*0x37bf814*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c0760*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c0838*/ int CompareValueTo(int recordNo, object value);
                /*0x37c0910*/ object ConvertValue(object value);
                /*0x37c0994*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c09e4*/ object Get(int record);
                /*0x37c0a78*/ bool IsNull(int record);
                /*0x37c0af8*/ void Set(int record, object value);
                /*0x37c0b60*/ void SetCapacity(int capacity);
                /*0x37c0c20*/ object ConvertXmlToObject(string s);
                /*0x37c0ed0*/ string ConvertObjectToXml(object value);
                /*0x37c1120*/ object GetEmptyStorage(int recordCount);
                /*0x37c1168*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37c128c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlDoubleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlDouble[] _values;

                /*0x37c1328*/ SqlDoubleStorage(System.Data.DataColumn column);
                /*0x37c145c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c21c0*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c2264*/ int CompareValueTo(int recordNo, object value);
                /*0x37c2320*/ object ConvertValue(object value);
                /*0x37c2398*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c23d4*/ object Get(int record);
                /*0x37c2454*/ bool IsNull(int record);
                /*0x37c24d0*/ void Set(int record, object value);
                /*0x37c2518*/ void SetCapacity(int capacity);
                /*0x37c25d8*/ object ConvertXmlToObject(string s);
                /*0x37c2878*/ string ConvertObjectToXml(object value);
                /*0x37c2ac8*/ object GetEmptyStorage(int recordCount);
                /*0x37c2b10*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37c2c18*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlGuidStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlGuid[] _values;

                /*0x37c2cb4*/ SqlGuidStorage(System.Data.DataColumn column);
                /*0x37c2de8*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c3048*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c30e8*/ int CompareValueTo(int recordNo, object value);
                /*0x37c31a4*/ object ConvertValue(object value);
                /*0x37c321c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c3260*/ object Get(int record);
                /*0x37c32e0*/ bool IsNull(int record);
                /*0x37c335c*/ void Set(int record, object value);
                /*0x37c33ac*/ void SetCapacity(int capacity);
                /*0x37c346c*/ object ConvertXmlToObject(string s);
                /*0x37c370c*/ string ConvertObjectToXml(object value);
                /*0x37c395c*/ object GetEmptyStorage(int recordCount);
                /*0x37c39a4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37c3aac*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt16Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt16[] _values;

                /*0x37c3b48*/ SqlInt16Storage(System.Data.DataColumn column);
                /*0x37c3c74*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c4afc*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c4b9c*/ int CompareValueTo(int recordNo, object value);
                /*0x37c4c58*/ object ConvertValue(object value);
                /*0x37c4cd0*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c4d0c*/ object Get(int record);
                /*0x37c4d8c*/ bool IsNull(int record);
                /*0x37c4e08*/ void Set(int record, object value);
                /*0x37c4e50*/ void SetCapacity(int capacity);
                /*0x37c4f10*/ object ConvertXmlToObject(string s);
                /*0x37c51b0*/ string ConvertObjectToXml(object value);
                /*0x37c5400*/ object GetEmptyStorage(int recordCount);
                /*0x37c5448*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37c5548*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt32Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt32[] _values;

                /*0x37c55e4*/ SqlInt32Storage(System.Data.DataColumn column);
                /*0x37c5718*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c6570*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c6610*/ int CompareValueTo(int recordNo, object value);
                /*0x37c66cc*/ object ConvertValue(object value);
                /*0x37c6744*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c6780*/ object Get(int record);
                /*0x37c6800*/ bool IsNull(int record);
                /*0x37c687c*/ void Set(int record, object value);
                /*0x37c68c4*/ void SetCapacity(int capacity);
                /*0x37c6984*/ object ConvertXmlToObject(string s);
                /*0x37c6c24*/ string ConvertObjectToXml(object value);
                /*0x37c6e74*/ object GetEmptyStorage(int recordCount);
                /*0x37c6ebc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37c6fbc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlInt64Storage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlInt64[] _values;

                /*0x37c7058*/ SqlInt64Storage(System.Data.DataColumn column);
                /*0x37c718c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c8064*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c8108*/ int CompareValueTo(int recordNo, object value);
                /*0x37c81c4*/ object ConvertValue(object value);
                /*0x37c823c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c8278*/ object Get(int record);
                /*0x37c82f8*/ bool IsNull(int record);
                /*0x37c8374*/ void Set(int record, object value);
                /*0x37c83bc*/ void SetCapacity(int capacity);
                /*0x37c847c*/ object ConvertXmlToObject(string s);
                /*0x37c871c*/ string ConvertObjectToXml(object value);
                /*0x37c896c*/ object GetEmptyStorage(int recordCount);
                /*0x37c89b4*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37c8abc*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlMoneyStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlMoney[] _values;

                /*0x37c8b58*/ SqlMoneyStorage(System.Data.DataColumn column);
                /*0x37c8c8c*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37c9bb4*/ int Compare(int recordNo1, int recordNo2);
                /*0x37c9c58*/ int CompareValueTo(int recordNo, object value);
                /*0x37c9d14*/ object ConvertValue(object value);
                /*0x37c9d8c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37c9dc8*/ object Get(int record);
                /*0x37c9e48*/ bool IsNull(int record);
                /*0x37c9ec4*/ void Set(int record, object value);
                /*0x37c9f0c*/ void SetCapacity(int capacity);
                /*0x37c9fcc*/ object ConvertXmlToObject(string s);
                /*0x37ca26c*/ string ConvertObjectToXml(object value);
                /*0x37ca4bc*/ object GetEmptyStorage(int recordCount);
                /*0x37ca504*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37ca60c*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlSingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlSingle[] _values;

                /*0x37ca6a8*/ SqlSingleStorage(System.Data.DataColumn column);
                /*0x37ca7dc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37cb608*/ int Compare(int recordNo1, int recordNo2);
                /*0x37cb6a8*/ int CompareValueTo(int recordNo, object value);
                /*0x37cb764*/ object ConvertValue(object value);
                /*0x37cb7dc*/ void Copy(int recordNo1, int recordNo2);
                /*0x37cb818*/ object Get(int record);
                /*0x37cb898*/ bool IsNull(int record);
                /*0x37cb914*/ void Set(int record, object value);
                /*0x37cb95c*/ void SetCapacity(int capacity);
                /*0x37cba1c*/ object ConvertXmlToObject(string s);
                /*0x37cbcbc*/ string ConvertObjectToXml(object value);
                /*0x37cbf0c*/ object GetEmptyStorage(int recordCount);
                /*0x37cbf54*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37cc054*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlStringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlString[] _values;

                /*0x37cc0f0*/ SqlStringStorage(System.Data.DataColumn column);
                /*0x37cc230*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x37cc654*/ int Compare(int recordNo1, int recordNo2);
                /*0x37cc6c0*/ int Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2);
                /*0x37cc7fc*/ int CompareValueTo(int recordNo, object value);
                /*0x37cc8c0*/ object ConvertValue(object value);
                /*0x37cc93c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37cc990*/ object Get(int record);
                /*0x37cca18*/ int GetStringLength(int record);
                /*0x37ccae4*/ bool IsNull(int record);
                /*0x37ccb64*/ void Set(int record, object value);
                /*0x37ccbcc*/ void SetCapacity(int capacity);
                /*0x37ccc8c*/ object ConvertXmlToObject(string s);
                /*0x37ccf34*/ string ConvertObjectToXml(object value);
                /*0x37cd184*/ object GetEmptyStorage(int recordCount);
                /*0x37cd1cc*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37cd2e8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlBooleanStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ System.Data.SqlTypes.SqlBoolean[] _values;

                /*0x37cd384*/ SqlBooleanStorage(System.Data.DataColumn column);
                /*0x37cd4b0*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37cd96c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37cda0c*/ int CompareValueTo(int recordNo, object value);
                /*0x37cdac8*/ object ConvertValue(object value);
                /*0x37cdb40*/ void Copy(int recordNo1, int recordNo2);
                /*0x37cdb7c*/ object Get(int record);
                /*0x37cdbfc*/ bool IsNull(int record);
                /*0x37cdc78*/ void Set(int record, object value);
                /*0x37cdcc0*/ void SetCapacity(int capacity);
                /*0x37cdd80*/ object ConvertXmlToObject(string s);
                /*0x37ce020*/ string ConvertObjectToXml(object value);
                /*0x37ce270*/ object GetEmptyStorage(int recordCount);
                /*0x37ce2b8*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37ce3b8*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SingleStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ float[] _values;

                /*0x37ce454*/ SingleStorage(System.Data.DataColumn column);
                /*0x37ce518*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37cec98*/ int Compare(int recordNo1, int recordNo2);
                /*0x37ced1c*/ int CompareValueTo(int recordNo, object value);
                /*0x37cede4*/ object ConvertValue(object value);
                /*0x37cef1c*/ void Copy(int recordNo1, int recordNo2);
                /*0x37cef74*/ object Get(int record);
                /*0x37cefd0*/ void Set(int record, object value);
                /*0x37cf14c*/ void SetCapacity(int capacity);
                /*0x37cf220*/ object ConvertXmlToObject(string s);
                /*0x37cf29c*/ string ConvertObjectToXml(object value);
                /*0x37cf32c*/ object GetEmptyStorage(int recordCount);
                /*0x37cf374*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37cf474*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class SqlUdtStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, object> s_typeToNull;
                /*0x50*/ object[] _values;
                /*0x58*/ bool _implementsIXmlSerializable;
                /*0x59*/ bool _implementsIComparable;

                static /*0x37d0b28*/ SqlUdtStorage();
                static /*0x37cf5b0*/ object GetStaticNullForUdtType(System.Type type);
                /*0x37cf538*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type);
                /*0x37cf6d8*/ SqlUdtStorage(System.Data.DataColumn column, System.Type type, object nullValue);
                /*0x37cf860*/ bool IsNull(int record);
                /*0x37cf964*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37cf994*/ int Compare(int recordNo1, int recordNo2);
                /*0x37cf9cc*/ int CompareValueTo(int recordNo1, object value);
                /*0x37cfc58*/ void Copy(int recordNo1, int recordNo2);
                /*0x37cfce0*/ object Get(int recordNo);
                /*0x37cfd10*/ void Set(int recordNo, object value);
                /*0x37cfe78*/ void SetCapacity(int capacity);
                /*0x37cff4c*/ object ConvertXmlToObject(string s);
                /*0x37d0254*/ object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x37d04e4*/ string ConvertObjectToXml(object value);
                /*0x37d07ac*/ void ConvertObjectToXml(object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib);
                /*0x37d0904*/ object GetEmptyStorage(int recordCount);
                /*0x37d094c*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37d0a8c*/ void SetStorage(object store, System.Collections.BitArray nullbits);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Type type;

                    /*0x37cf858*/ <>c__DisplayClass6_0();
                    /*0x37d0bc0*/ object <GetStaticNullForUdtType>b__0(System.Type t);
                }
            }

            class StringStorage : System.Data.Common.DataStorage
            {
                /*0x50*/ string[] _values;

                /*0x37d0ce8*/ StringStorage(System.Data.DataColumn column);
                /*0x37d0d98*/ object Aggregate(int[] recordNos, System.Data.AggregateType kind);
                /*0x37d1064*/ int Compare(int recordNo1, int recordNo2);
                /*0x37d10dc*/ int CompareValueTo(int recordNo, object value);
                /*0x37d1168*/ object ConvertValue(object value);
                /*0x37d1190*/ void Copy(int recordNo1, int recordNo2);
                /*0x37d11d0*/ object Get(int recordNo);
                /*0x37d120c*/ int GetStringLength(int record);
                /*0x37d124c*/ bool IsNull(int record);
                /*0x37d1284*/ void Set(int record, object value);
                /*0x37d12fc*/ void SetCapacity(int capacity);
                /*0x37d13bc*/ object ConvertXmlToObject(string s);
                /*0x37d13c4*/ string ConvertObjectToXml(object value);
                /*0x37d13f0*/ object GetEmptyStorage(int recordCount);
                /*0x37d1438*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37d1540*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class TimeSpanStorage : System.Data.Common.DataStorage
            {
                static /*0x0*/ System.TimeSpan s_defaultValue;
                /*0x50*/ System.TimeSpan[] _values;

                static /*0x37d2ef8*/ TimeSpanStorage();
                static /*0x37d266c*/ System.TimeSpan ConvertToTimeSpan(object value);
                /*0x37d15dc*/ TimeSpanStorage(System.Data.DataColumn column);
                /*0x37d16fc*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37d237c*/ int Compare(int recordNo1, int recordNo2);
                /*0x37d24f8*/ int CompareValueTo(int recordNo, object value);
                /*0x37d2810*/ object ConvertValue(object value);
                /*0x37d28bc*/ void Copy(int recordNo1, int recordNo2);
                /*0x37d2914*/ object Get(int record);
                /*0x37d2a14*/ void Set(int record, object value);
                /*0x37d2af4*/ void SetCapacity(int capacity);
                /*0x37d2bc8*/ object ConvertXmlToObject(string s);
                /*0x37d2c54*/ string ConvertObjectToXml(object value);
                /*0x37d2cec*/ object GetEmptyStorage(int recordCount);
                /*0x37d2d34*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37d2e34*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt16Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ushort s_defaultValue;
                /*0x50*/ ushort[] _values;

                /*0x37d2f70*/ UInt16Storage(System.Data.DataColumn column);
                /*0x37d3054*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37d38c0*/ int Compare(int recordNo1, int recordNo2);
                /*0x37d3978*/ int CompareValueTo(int recordNo, object value);
                /*0x37d3a88*/ object ConvertValue(object value);
                /*0x37d3bc4*/ void Copy(int recordNo1, int recordNo2);
                /*0x37d3c1c*/ object Get(int record);
                /*0x37d3ce0*/ void Set(int record, object value);
                /*0x37d3e78*/ void SetCapacity(int capacity);
                /*0x37d3f4c*/ object ConvertXmlToObject(string s);
                /*0x37d3fcc*/ string ConvertObjectToXml(object value);
                /*0x37d4058*/ object GetEmptyStorage(int recordCount);
                /*0x37d40a0*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37d41a0*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt32Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ uint s_defaultValue;
                /*0x50*/ uint[] _values;

                /*0x37d4264*/ UInt32Storage(System.Data.DataColumn column);
                /*0x37d4348*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37d4bb8*/ int Compare(int recordNo1, int recordNo2);
                /*0x37d4c84*/ int CompareValueTo(int recordNo, object value);
                /*0x37d4d94*/ object ConvertValue(object value);
                /*0x37d4ed0*/ void Copy(int recordNo1, int recordNo2);
                /*0x37d4f28*/ object Get(int record);
                /*0x37d4fec*/ void Set(int record, object value);
                /*0x37d5184*/ void SetCapacity(int capacity);
                /*0x37d5258*/ object ConvertXmlToObject(string s);
                /*0x37d52d8*/ string ConvertObjectToXml(object value);
                /*0x37d5364*/ object GetEmptyStorage(int recordCount);
                /*0x37d53ac*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37d54ac*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }

            class UInt64Storage : System.Data.Common.DataStorage
            {
                static /*0x0*/ ulong s_defaultValue;
                /*0x50*/ ulong[] _values;

                /*0x37d5570*/ UInt64Storage(System.Data.DataColumn column);
                /*0x37d5654*/ object Aggregate(int[] records, System.Data.AggregateType kind);
                /*0x37d5ed0*/ int Compare(int recordNo1, int recordNo2);
                /*0x37d5fd8*/ int CompareValueTo(int recordNo, object value);
                /*0x37d60e8*/ object ConvertValue(object value);
                /*0x37d6224*/ void Copy(int recordNo1, int recordNo2);
                /*0x37d627c*/ object Get(int record);
                /*0x37d6340*/ void Set(int record, object value);
                /*0x37d64d8*/ void SetCapacity(int capacity);
                /*0x37d65ac*/ object ConvertXmlToObject(string s);
                /*0x37d662c*/ string ConvertObjectToXml(object value);
                /*0x37d66b8*/ object GetEmptyStorage(int recordCount);
                /*0x37d6700*/ void CopyValue(int record, object store, System.Collections.BitArray nullbits, int storeIndex);
                /*0x37d6800*/ void SetStorage(object store, System.Collections.BitArray nullbits);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 39A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E;
    static /*0x98*/ <PrivateImplementationDetails> 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D;
    static /*0xbe*/ <PrivateImplementationDetails> 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA;
    static /*0xf2*/ <PrivateImplementationDetails> 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD;
    static /*0x116*/ <PrivateImplementationDetails> BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226;
    static /*0x1ae*/ <PrivateImplementationDetails> C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E;
    static /*0x246*/ <PrivateImplementationDetails> D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939;
    static /*0x2de*/ <PrivateImplementationDetails> E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6;
    static /*0x38e*/ <PrivateImplementationDetails> F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591;
    static /*0x3ce*/ <PrivateImplementationDetails> FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315;

    struct __StaticArrayInitTypeSize=36
    {
    }

    struct __StaticArrayInitTypeSize=38
    {
    }

    struct __StaticArrayInitTypeSize=52
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=152
    {
    }

    struct __StaticArrayInitTypeSize=176
    {
    }
}
